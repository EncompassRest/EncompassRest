using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Settings.Loan.v1
{
    /// <summary>
    /// CustomFieldDefinition
    /// </summary>
    public sealed class CustomFieldDefinition : ExtensibleObject, IIdentifiable
    {
        /// <summary>
        /// Loan custom field name.
        /// </summary>
        [JsonRequired]
        public string? Id { get; set; }

        /// <summary>
        /// Description for loan custom field.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Indicates the range and format of values the custom field can store.
        /// </summary>
        public StringEnumValue<LoanFieldFormat> Format { get; set; }

        /// <summary>
        /// Indicates the maximum length of the value for the custom field.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxLength { get; set; }

        /// <summary>
        /// A custom calculation is an expression that returns a number or text value, which is then saved into the associated custom field.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Calculation { get; set; }

        /// <summary>
        /// Defines the audit data to return.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FieldAudit? Audit { get; set; }

        /// <summary>
        /// If the format is DROPDOWNLIST or DROPDOWN, provide the values that will appear in the drop-down list.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IList<string>? Options { get; set; }

        /// <summary>
        /// Model path for loan custom field.
        /// </summary>
        [NeverSerialize]
        public string? ModelPath { get; internal set; }

        /// <summary>
        /// A value of <c>true</c> indicates the field has a calculation associated.
        /// </summary>
        [NeverSerialize]
        public bool IsCalculatedField { get; internal set; }

        /// <summary>
        /// Custom field definition constructor.
        /// </summary>
        /// <param name="id">Loan custom field name.</param>
        /// <param name="description">Description for loan custom field.</param>
        /// <param name="format">Indicates the range and format of values the custom field can store.</param>
        public CustomFieldDefinition(string id, string description, LoanFieldFormat format)
            : this(id, description, format.Validate(nameof(format)).GetValue())
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