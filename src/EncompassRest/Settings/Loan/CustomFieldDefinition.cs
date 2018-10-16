using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan
{
    public sealed class CustomFieldDefinition : DirtyExtensibleObject, IIdentifiable
    {
        private string _id;
        [JsonRequired]
        public string Id { get => _id; set => SetField(ref _id, value); }
        private string _description;
        public string Description { get => _description; set => SetField(ref _description, value); }
        private StringEnumValue<LoanFieldFormat> _format;
        public StringEnumValue<LoanFieldFormat> Format { get => _format; set => SetField(ref _format, value); }
        private int _maxLength;
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxLength { get => _maxLength; set => SetField(ref _maxLength, value); }
        private string _calculation;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Calculation { get => _calculation; set => SetField(ref _calculation, value); }
        private FieldAudit _audit;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FieldAudit Audit { get => _audit; set => SetField(ref _audit, value); }
        private IList<string> _options;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string> Options { get => _options; set => SetField(ref _options, value); }
        private NeverSerializeValue<string> _modelPath;
        public string ModelPath { get => _modelPath; internal set => SetField(ref _modelPath, value); }
        private NeverSerializeValue<bool> _isCalculatedField;
        public bool IsCalculatedField { get => _isCalculatedField; internal set => SetField(ref _isCalculatedField, value); }

        public CustomFieldDefinition(string id, string description, LoanFieldFormat format)
            : this(id, description, format.Validate(nameof(format)).GetValue())
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