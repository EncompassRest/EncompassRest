using System.Collections.Generic;
using EncompassRest.Schema;
using EncompassRest.Schema.v1;

namespace EncompassRest.Settings.Contacts.v1
{
    /// <summary>
    /// ContactFieldDefinition
    /// </summary>
    public sealed class ContactFieldDefinition : ExtensibleObject
    {
        /// <summary>
        /// When set to <c>true</c>, the corresponding canonical field is used only for filtering contacts.
        /// When set to <c>false</c>, the corresponding canonical field is used for selection, sorting and filtering contacts.
        /// </summary>
        public bool FilterOnly { get; set; }

        /// <summary>
        /// Category of a field.
        /// </summary>
        public StringEnumValue<FieldDefinitionCategory> Category { get; set; }

        /// <summary>
        /// A detailed explanation of what each field represents.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The canonical name of the field.
        /// </summary>
        public string? CanonicalName { get; set; }

        /// <summary>
        /// Type of a field.
        /// </summary>
        public StringEnumValue<LoanFieldFormat> DataType { get; set; }

        /// <summary>
        /// Source of the field.
        /// </summary>
        public StringEnumValue<FieldDefinitionDataSource> DataSource { get; set; }

        /// <summary>
        /// Array of strings representing possible options for field values.
        /// </summary>
        public List<string>? Options { get; set; }

        /// <summary>
        /// ContactFieldDefinition MaxLength
        /// </summary>
        public int? MaxLength { get; set; }
    }
}