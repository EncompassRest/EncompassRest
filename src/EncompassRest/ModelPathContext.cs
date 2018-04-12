using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace EncompassRest
{
    internal sealed class ModelPathContext
    {
        public ConcurrentDictionary<string, ModelPathSettings> Settings { get; }

        public int DefaultIndexOffset { get; }

        public Func<string, string> PropertyNameTransformer { get; }

        public ModelPathContext(IEnumerable<KeyValuePair<string, ModelPathSettings>> settings, int defaultIndexOffset, Func<string, string> propertyNameTransformer = null)
        {
            Settings = new ConcurrentDictionary<string, ModelPathSettings>(settings, StringComparer.OrdinalIgnoreCase);
            DefaultIndexOffset = defaultIndexOffset;
            PropertyNameTransformer = propertyNameTransformer;
        }
    }
}