using System;
using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.Schema
{
    /// <summary>
    /// Field option.
    /// </summary>
    public sealed class FieldOption : ExtensibleObject, IEquatable<FieldOption>
    {
        /// <summary>
        /// Field option value.
        /// </summary>
        [JsonProperty]
        public string Value { get; internal set; }

        /// <summary>
        /// Field option text.
        /// </summary>
        [JsonProperty]
        public string Text { get; internal set; }

        /// <summary>
        /// Field option reporting database value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ReportingDatabaseValue { get; internal set; }

        /// <summary>
        /// FieldOption constructor.
        /// </summary>
        /// <param name="value">Field option value.</param>
        public FieldOption(string value)
            : this(value, value)
        {
        }

        /// <summary>
        /// FieldOption constructor.
        /// </summary>
        /// <param name="value">Field option value.</param>
        /// <param name="text">Field option text.</param>
        [JsonConstructor]
#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        public FieldOption(string value, string text)
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        {
            Preconditions.NotNull(text, nameof(text));
            Preconditions.NotNull(value, nameof(value));

            Text = text;
            Value = value;
        }

        /// <summary>
        /// Indicates whether this object equals the <paramref name="other"/> object.
        /// </summary>
        /// <param name="other">The other object to compare with.</param>
        /// <returns></returns>
        public bool Equals(FieldOption? other) => other != null && string.Equals(Value, other.Value, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Indicates whether this object equals the other object.
        /// </summary>
        /// <param name="obj">The other object to compare with.</param>
        /// <returns></returns>
        public override bool Equals(object? obj) => Equals(obj as FieldOption);

        /// <summary>
        /// Gets a hash code for the object.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Value != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Value) : 0;
    }
}