using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class HeaderLimitFactory<THeader> where THeader : IHeaderLimit
    {
        public virtual ConcurrentDictionary<string, THeader> Dic { get; private set; }
        private readonly ILogger<HeaderLimitFactory<THeader>> _logger;
        public decimal? Ratio { get; private set; }

        public HeaderLimitFactory()
        {
            Dic = new ConcurrentDictionary<string, THeader>();
        }

        private static HeaderLimitFactory<THeader> _factory;
        public static HeaderLimitFactory<THeader> Factory
        {
            get
            {
                if (_factory == null) { _factory = new HeaderLimitFactory<THeader>(); }
                return _factory;
            }
        }

        public void AddToDictionary(THeader header, string key, int value)
        {
            if (Dic.TryGetValue(header.Tag, out THeader obj))
            {
                obj.Collection.Add(key, value);
            }
            else
            {
                header.Collection.Add(key, value);
                Dic.TryAdd(header.Tag, header);
            }
        }

        public decimal? GetRemainingLimitRatio(IHeaderLimit header)
        {
            if (Dic.TryGetValue(header.Tag, out THeader scopedHeader))
            {
                if (scopedHeader.Collection.TryGetValue(header.LimitName, out decimal limit) && scopedHeader.Collection.TryGetValue(header.RemainingName, out decimal remaining))
                {
                    Dic.TryRemove(header.Tag, out THeader concurrencyLimit);
                    Ratio = Math.Round(remaining / limit, 2) * 100;
                    return Ratio;
                }
                return null;
            }
            return null;
        }

    }

    public static class HeaderLimitFactoryExtensions
    {
        public static HeaderLimitFactory<THeader> Log<THeader, TLogger>(this HeaderLimitFactory<THeader> factory, THeader header, ILogger<TLogger> logger) where THeader : IHeaderLimit
        {

            var ratio = factory.GetRemainingLimitRatio(header);
            if (!ratio.HasValue) return factory;
            var message = $"{header.Name} remaining is {ratio}% of limits for tag : {header.Tag} and Uri : {header.Uri}";
            if (ratio <= 70m && ratio > 0)
            {
                logger.LogWarning(message);
            }
            else if (ratio == 0)
            {
                logger.LogError(message);
            }

            return factory;
        }

        public static HeaderLimitFactory<THeader> Add<THeader, TLogger>(this HeaderLimitFactory<THeader> factory, THeader header, string key, string value, ILogger<TLogger> logger) where THeader : IHeaderLimit
        {
            if (header.LogAll) { logger.LogDebug("Header {0} : {1} for tag: {2}", key, value, header.Tag); }
            if (int.TryParse(value, out int i))
            {
                factory.AddToDictionary(header, key, i);
            }
            return factory;
        }
    }
}
