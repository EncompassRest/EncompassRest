using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncompassApi.MessageHandlers
{
    public class ConcurrencyLimitHeaderFactory
    {
        private Dictionary<string, Dictionary<string, decimal>> _dic;
        private readonly ILogger<ConcurrencyLimitHeaderFactory> _logger;

        private ConcurrencyLimitHeaderFactory()
        {
            _dic = new Dictionary<string, Dictionary<string, decimal>>();
        }

        private static ConcurrencyLimitHeaderFactory _factory;
        public static ConcurrencyLimitHeaderFactory Factory
        {
            get
            {
                if (_factory == null) { _factory = new ConcurrencyLimitHeaderFactory(); }
                return _factory;
            }
        }

        public void AddToDictionary(string tag, string key, int value)
        {
            if (_dic.TryGetValue(tag, out Dictionary<string , decimal> dic)){
                dic.Add(key, value);
            }
            else
            {
                var newDic = new Dictionary<string, decimal>();
                newDic.Add(key, value);
                _dic.Add(tag, newDic);
            }
           
        }

        public decimal GetRemainingLimitRatio(string tag)
        {
            if(_dic.TryGetValue(tag, out Dictionary<string, decimal> scopedDic)){
                if (scopedDic.TryGetValue("X-Concurrency-Limit-Limit", out decimal limit) && scopedDic.TryGetValue("X-Concurrency-Limit-Remaining", out decimal remaining))
                {
                    _dic.Clear();
                    return remaining / limit;
                }
                return 0;
            }

            return 0;
           
        }

 

    }
    public static class ConcurrencyLimitFactroyExtension
    {
        public static ConcurrencyLimitHeaderFactory Log<TLogger>(this ConcurrencyLimitHeaderFactory factory, string tag, ILogger<TLogger> logger)
        {
            var ratio = factory.GetRemainingLimitRatio(tag);
            var message = $"Concurrency is: {ratio} for tag : {tag}";
            if (ratio <= 0.70m)
            {
                logger.LogWarning(message);
            }
            else if (ratio == 0)
            {
                logger.LogError(message);
            }

            return factory;
        }

        public static ConcurrencyLimitHeaderFactory Add(this ConcurrencyLimitHeaderFactory factory, string tag,  string key, string value)
        {
            if (int.TryParse(value, out int i))
            {
                factory.AddToDictionary(tag, key, i);
            }
            return factory;
        }
    }
}
