using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace EncompassRest.Utilities
{
    internal sealed class TypeDictionary
    {
        private readonly ConcurrentDictionary<Type, object> _dictionary = new ConcurrentDictionary<Type, object>();

        public ICollection<object> Values => _dictionary.Values;

        public T GetOrAdd<T>(Func<T> valueProvider)
        {
            Preconditions.NotNull(valueProvider, nameof(valueProvider));

            return (T)_dictionary.GetOrAdd(typeof(T), t => valueProvider()!);
        }
    }
}