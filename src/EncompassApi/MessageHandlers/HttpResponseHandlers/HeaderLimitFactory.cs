using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class HeaderLimitFactory<THeader> where THeader: IHeaderLimit
    {
        private ConcurrentDictionary<string, THeader> _dic;
        private readonly ILogger<HeaderLimitFactory<THeader>> _logger;

        public HeaderLimitFactory()
        {
            _dic = new ConcurrentDictionary<string, THeader>();
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
            if (_dic.TryGetValue(header.Tag, out THeader obj)){
               obj.Collection.Add(key, value);
            }
            else
            {
                header.Collection.Add(key, value);
                _dic.TryAdd(header.Tag, header);
            }
           
        }

        public decimal GetRemainingLimitRatio(IHeaderLimit header)
        {
            if(_dic.TryGetValue(header.Tag, out THeader scopedHeader)){
                if (scopedHeader.Collection.TryGetValue("X-Concurrency-Limit-Limit", out decimal limit) && scopedHeader.Collection.TryGetValue("X-Concurrency-Limit-Remaining", out decimal remaining))
                {
                    _dic.TryRemove(header.Tag, out THeader concurrencyLimit);
                    return Math.Round(remaining / limit, 2) * 100;
                }
                return -1;
            }

            return -1;
           
        }

 

    }
    public static class ConcurrencyLimitFactroyExtension
    {
        public static HeaderLimitFactory<THeader> Log<THeader,TLogger>(this HeaderLimitFactory<THeader> factory, THeader header, ILogger<TLogger> logger) where THeader: IHeaderLimit
        {
            var ratio = factory.GetRemainingLimitRatio(header);
            var message = $"Concurrency remaining is {ratio}% of limits for tag : {header.Tag} and Uri : {header.Uri}";
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

        public static HeaderLimitFactory<THeader> Add<THeader>(this HeaderLimitFactory<THeader> factory, THeader header,  string key, string value) where THeader : IHeaderLimit
        {
            if (int.TryParse(value, out int i))
            {
                factory.AddToDictionary(header, key, i);
            }
            return factory;
        }
    }
}
