using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan
{
    public sealed class FieldAudit : DirtyExtensibleObject, IDirty, IIdentifiable
    {
        private string _fieldId;
        public string FieldId { get => _fieldId; set => SetField(ref _fieldId, value); }
        private StringEnumValue<AuditData> _data;
        public StringEnumValue<AuditData> Data { get => _data; set => SetField(ref _data, value); }
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