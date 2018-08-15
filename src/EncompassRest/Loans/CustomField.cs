using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CustomField
    /// </summary>
    public sealed partial class CustomField : ExtensibleObject, IIdentifiable
    {
        internal DirtyValue<DateTime?> _dateValue;
        /// <summary>
        /// CustomField DateValue
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? DateValue { get => _dateValue; set => SetField(ref _dateValue, value); }
        private DirtyValue<string> _fieldName;
        /// <summary>
        /// CustomField FieldName
        /// </summary>
        public string FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// CustomField Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        internal DirtyValue<decimal?> _numericValue;
        /// <summary>
        /// CustomField NumericValue
        /// </summary>
        public decimal? NumericValue { get => _numericValue; set => SetField(ref _numericValue, value); }
        internal DirtyValue<string> _stringValue;
        /// <summary>
        /// Custom Field Value [CUSTNNFV]
        /// </summary>
        [LoanFieldProperty(Description = "Custom Field Value")]
        public string StringValue { get => _stringValue; set => SetField(ref _stringValue, value); }
    }
}