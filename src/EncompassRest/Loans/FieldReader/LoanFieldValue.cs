using System.Collections.Generic;
using EncompassRest.Schema;

namespace EncompassRest.Loans.FieldReader
{
    /// <summary>
    /// LoanFieldValue
    /// </summary>
    public sealed class LoanFieldValue : ExtensibleObject
    {
        /// <summary>
        /// Loan field ID.
        /// </summary>
        public string FieldId { get; set; }

        /// <summary>
        /// Value of the field in the loan.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Description for loan field.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates the range and format of values the field can store.
        /// </summary>
        public StringEnumValue<LoanFieldFormat> Format { get; set; }

        /// <summary>
        /// Whether the field is readOnly or is allowed to be edited.
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Defines the data type of field.
        /// </summary>
        public StringEnumValue<LoanFieldValueTypeAlt> Type { get; set; }

        /// <summary>
        /// Represents the possible values for the field id.
        /// </summary>
        public List<string> Options { get; set; }
    }
}