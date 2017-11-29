using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome : ExtensibleObject
    {
        private DirtyValue<bool?> _boolFieldValue;
        public bool? BoolFieldValue { get => _boolFieldValue; set => _boolFieldValue = value; }
        private DirtyValue<string> _businessName;
        public string BusinessName { get => _businessName; set => _businessName = value; }
        private DirtyValue<string> _fieldName;
        public string FieldName { get => _fieldName; set => _fieldName = value; }
        private DirtyValue<decimal?> _fieldValue;
        public decimal? FieldValue { get => _fieldValue; set => _fieldValue = value; }
        private DirtyValue<decimal?> _firstYearAmount;
        public decimal? FirstYearAmount { get => _firstYearAmount; set => _firstYearAmount = value; }
        private DirtyValue<StringEnumValue<FormType>> _formType;
        public StringEnumValue<FormType> FormType { get => _formType; set => _formType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _secondYearAmount;
        public decimal? SecondYearAmount { get => _secondYearAmount; set => _secondYearAmount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _boolFieldValue.Dirty
                    || _businessName.Dirty
                    || _fieldName.Dirty
                    || _fieldValue.Dirty
                    || _firstYearAmount.Dirty
                    || _formType.Dirty
                    || _id.Dirty
                    || _secondYearAmount.Dirty;
            }
            set
            {
                _boolFieldValue.Dirty = value;
                _businessName.Dirty = value;
                _fieldName.Dirty = value;
                _fieldValue.Dirty = value;
                _firstYearAmount.Dirty = value;
                _formType.Dirty = value;
                _id.Dirty = value;
                _secondYearAmount.Dirty = value;
            }
        }
    }
}