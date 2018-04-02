using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace EncompassRest
{
    internal sealed class ModelPathContext
    {
        public ConcurrentDictionary<string, ModelPathSettings> Settings { get; }

        public int DefaultIndexOffset { get; }

        public ModelPathContext(IEnumerable<KeyValuePair<string, ModelPathSettings>> settings, int defaultIndexOffset)
        {
            Settings = new ConcurrentDictionary<string, ModelPathSettings>(settings, StringComparer.OrdinalIgnoreCase);
            DefaultIndexOffset = defaultIndexOffset;
        }
    }
}