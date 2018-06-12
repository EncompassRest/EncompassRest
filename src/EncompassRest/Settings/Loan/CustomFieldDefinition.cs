using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan
{
    public sealed class CustomFieldDefinition : ExtensibleObject, IIdentifiable
    {
        public string Id { get; }

        public string Description { get; set; }

        public StringEnumValue<LoanFieldFormat> Format { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxLength { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Calculation { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FieldAudit Audit { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Options { get; set; }

        private NeverSerializeValue<string> _modelPath;
        [JsonProperty]
        public string ModelPath { get => _modelPath; internal set => _modelPath = value; }

        private NeverSerializeValue<bool> _isCalculatedField;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsCalculatedField { get => _isCalculatedField; internal set => _isCalculatedField = value; }

        public CustomFieldDefinition(string id, string description, LoanFieldFormat format)
            : this(id, description, format.Validate(nameof(format)).AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))
        {
        }
        
        public CustomFieldDefinition(string id, string description, string format)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNullOrEmpty(description, nameof(description));
            Preconditions.NotNullOrEmpty(format, nameof(format));

            Id = id;
            Description = description;
            Format = format;
        }

        [JsonConstructor]
        private CustomFieldDefinition(string id, string description, string format, int maxLength)
        {
            Preconditions.NotNullOrEmpty(id, nameof(id));
            Preconditions.NotNull(description, nameof(description));
            Preconditions.NotNullOrEmpty(format, nameof(format));
            Preconditions.GreaterThanOrEquals(maxLength, nameof(maxLength), 0);

            Id = id;
            Description = description;
            Format = format;
            MaxLength = maxLength;
        }
    }
}