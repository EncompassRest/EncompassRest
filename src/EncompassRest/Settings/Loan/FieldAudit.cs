using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan
{
    public sealed class FieldAudit : ExtensibleObject, IDirty
    {
        public string FieldId { get; set; }

        public StringEnumValue<AuditData> Data { get; set; }

        bool IDirty.Dirty { get => true; set { } }

        public FieldAudit(string fieldId, AuditData data)
            : this(fieldId, data.Validate(nameof(data)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }

        [JsonConstructor]
        public FieldAudit(string fieldId, string data)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));
            Preconditions.NotNullOrEmpty(data, nameof(data));

            FieldId = fieldId;
            Data = data;
        }
    }
}