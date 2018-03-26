using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using EncompassRest.Utilities;

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

        public ModelPath Create(string modelPath)
        {
            Preconditions.NotNullOrEmpty(modelPath, nameof(modelPath));

            try
            {
                return new ModelPath(this, modelPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}