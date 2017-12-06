#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class CustomField : ExtensibleObject
    {
        private DirtyValue<DateTime?> _dateValue;
        public DateTime? DateValue { get => _dateValue; set => _dateValue = value; }
        private DirtyValue<string> _fieldName;
        public string FieldName { get => _fieldName; set => _fieldName = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _numericValue;
        public decimal? NumericValue { get => _numericValue; set => _numericValue = value; }
        private DirtyValue<string> _stringValue;
        public string StringValue { get => _stringValue; set => _stringValue = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _dateValue.Dirty
                    || _fieldName.Dirty
                    || _id.Dirty
                    || _numericValue.Dirty
                    || _stringValue.Dirty;
            }
            set
            {
                _dateValue.Dirty = value;
                _fieldName.Dirty = value;
                _id.Dirty = value;
                _numericValue.Dirty = value;
                _stringValue.Dirty = value;
            }
        }
    }
}