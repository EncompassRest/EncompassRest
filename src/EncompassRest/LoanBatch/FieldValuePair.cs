using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    /// <summary>
    /// FieldValuePair
    /// </summary>
    public sealed class FieldValuePair : SerializableObject
    {
        /// <summary>
        /// The canonical field name.
        /// </summary>
        [JsonRequired]
        public string FieldId { get; }

        /// <summary>
        /// The value to update the field to.
        /// </summary>
        [JsonProperty(Required = Required.AllowNull)]
        public object Value { get; }

        /// <summary>
        /// FieldValuePair constructor.
        /// </summary>
        /// <param name="fieldId">The canonical field name.</param>
        /// <param name="value">The value to update the field to.</param>
        public FieldValuePair(string fieldId, object value)
        {
            Preconditions.NotNull(fieldId, nameof(fieldId));

            FieldId = fieldId;
            Value = value;
        }
    }
}