using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    public sealed class FieldOption : ExtensibleObject, IEquatable<FieldOption>
    {
        [JsonProperty]
        public string Value { get; internal set; }

        [JsonProperty]
        public string Text { get; internal set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReportingDatabaseValue { get; internal set; }

        public FieldOption(string value)
            : this(value, value)
        {
        }

        [JsonConstructor]
        public FieldOption(string value, string text)
        {
            Preconditions.NotNull(text, nameof(text));
            Preconditions.NotNull(value, nameof(value));

            Text = text;
            Value = value;
        }

        public bool Equals(FieldOption other) => other != null && string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);

        public override bool Equals(object obj) => Equals(obj as FieldOption);

        public override int GetHashCode() => Value?.GetHashCode() ?? 0;
    }
}