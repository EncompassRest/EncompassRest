using EncompassRest.Utilities;
using Newtonsoft.Json;

namespace EncompassRest.LoanBatch
{
    public sealed class FieldValuePair
    {
        [JsonRequired]
        public string FieldId { get; }

        [JsonProperty(NullValueHandling = NullValueHandling.Include, Required = Required.AllowNull)]
        public object Value { get; }

        public FieldValuePair(string fieldId, object value)
        {
            Preconditions.NotNull(fieldId, nameof(fieldId));

            FieldId = fieldId;
            Value = value;
        }
    }
}