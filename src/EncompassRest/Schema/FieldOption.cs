using System;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    public sealed class FieldOption : ExtensibleObject, IEquatable<FieldOption>
    {
        [JsonProperty]
        public string Value { get; internal set; }

        [JsonProperty]
        public string Text { get; internal set; }

        public string ReportingDatabaseValue { get; set; }

        public bool Equals(FieldOption other) => other != null && string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);

        public override bool Equals(object obj) => Equals(obj as FieldOption);

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    }
}