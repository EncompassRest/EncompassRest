using System;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CustomField
    /// </summary>
    public sealed partial class CustomField : DirtyExtensibleObject, IIdentifiable
    {
        internal DirtyValue<DateTime?>? _dateValue;
        private DirtyValue<string?>? _fieldName;
        private DirtyValue<string?>? _id;
        internal DirtyValue<decimal?>? _numericValue;
        internal DirtyValue<string?>? _stringValue;

        /// <summary>
        /// CustomField DateValue
        /// </summary>
        public DateTime? DateValue { get => _dateValue; set => SetField(ref _dateValue, value); }

        /// <summary>
        /// CustomField FieldName
        /// </summary>
        public string? FieldName { get => _fieldName; set => SetField(ref _fieldName, value); }

        /// <summary>
        /// CustomField Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// CustomField NumericValue
        /// </summary>
        public decimal? NumericValue { get => _numericValue; set => SetField(ref _numericValue, value); }

        /// <summary>
        /// Custom Field Value [CUSTNNFV]
        /// </summary>
        public string? StringValue { get => _stringValue; set => SetField(ref _stringValue, value); }
    }
}