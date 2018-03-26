using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EncompassRest
{
    internal sealed class ModelPathSettings
    {
        public int? IndexOffset { get; }

        public ReadOnlyDictionary<string, string> DefaultValues { get; }

        public ModelPathSettings(int indexOffset)
            : this(indexOffset, null)
        {
        }

        public ModelPathSettings(IDictionary<string, string> defaultValues)
            : this(null, defaultValues)
        {
        }
        
        public ModelPathSettings(int? indexOffset, IDictionary<string, string> defaultValues)
        {
            IndexOffset = indexOffset;
            DefaultValues = defaultValues != null ? new ReadOnlyDictionary<string, string>(new Dictionary<string, string>(defaultValues, StringComparer.OrdinalIgnoreCase)) : null;
        }
    }
}