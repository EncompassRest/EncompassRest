using System.Collections.Generic;

namespace EncompassRest.Schema
{
    public sealed class FieldOption
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public string ReportingDatabaseValue { get; set; }

        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
    }
}