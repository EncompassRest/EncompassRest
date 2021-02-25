using System.Collections.Generic;
using System.Linq;
using EncompassApi.Schema;
using EncompassApi.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassApi.Settings.Loan
{
    /// <summary>
    /// CustomFieldDefinition
    /// </summary>
    public sealed class CustomFieldDefinition : DirtyExtensibleObject, IIdentifiable
    {
        private string? _id;
        private string? _description;
        private StringEnumValue<LoanFieldFormat> _format;
        private int _maxLength;
        private string? _calculation;
        private FieldAudit? _audit;
        private List<string>? _options;
        private NeverSerializeValue<string?>? _modelPath;
        private NeverSerializeValue<bool>? _isCalculatedField;

        /// <summary>
        /// Loan custom field name.
        /// </summary>
        [JsonRequired]
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Description for loan custom field.
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Indicates the range and format of values the custom field can store.
        /// </summary>
        public StringEnumValue<LoanFieldFormat> Format { get => _format; set => SetField(ref _format, value); }

        /// <summary>
        /// Indicates the maximum length of the value for the custom field.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxLength { get => _maxLength; set => SetField(ref _maxLength, value); }

        /// <summary>
        /// A custom calculation is an expression that returns a number or text value, which is then saved into the associated custom field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Calculation { get => _calculation; set => SetField(ref _calculation, value); }

        /// <summary>
        /// Defines the audit data to return.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FieldAudit? Audit { get => _audit; set => SetField(ref _audit, value); }

        /// <summary>
        /// If the format is DROPDOWNLIST or DROPDOWN, provide the values that will appear in the drop-down list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string>? Options { get => _options; set => SetField(ref _options, value?.ToList()); }

        /// <summary>
        /// Model path for loan custom field.
        /// </summary>
        public string? ModelPath { get => _modelPath; internal set => SetField(ref _modelPath!, value); }

        /// <summary>
        /// A value of <c>true</c> indicates the field has a calculation associated.
        /// </summary>
        public bool IsCalculatedField { get => _isCalculatedField; internal set => SetField(ref _isCalculatedField!, value); }

        /// <summary>
        /// Custom field definition constructor.
        /// </summary>
        /// <param name="id">Loan custom field name.</param>
        /// <param name="description">Description for loan custom field.</param>
        /// <param name="format">Indicates the range and format of values the custom field can store.</param>
        public CustomFieldDefinition(string id, string description, LoanFieldFormat format)
            : this(id, description, format.Validate(nameof(format)).GetValue()!)
        {
        }

        /// <summary>
        /// Custom field definition constructor.
        /// </summary>
        /// <param name="id">Loan custom field name.</param>
        /// <param name="description">Description for loan custom field.</param>
        /// <param name="format">Indicates the range and format of values the custom field can store.</param>
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