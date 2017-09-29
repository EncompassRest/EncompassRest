using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome : IDirty
    {
        private DirtyValue<bool?> _boolFieldValue;
        public bool? BoolFieldValue { get { return _boolFieldValue; } set { _boolFieldValue = value; } }
        private DirtyValue<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        private DirtyValue<string> _fieldName;
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        private DirtyValue<decimal?> _fieldValue;
        public decimal? FieldValue { get { return _fieldValue; } set { _fieldValue = value; } }
        private DirtyValue<decimal?> _firstYearAmount;
        public decimal? FirstYearAmount { get { return _firstYearAmount; } set { _firstYearAmount = value; } }
        private DirtyValue<string> _formType;
        public string FormType { get { return _formType; } set { _formType = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _secondYearAmount;
        public decimal? SecondYearAmount { get { return _secondYearAmount; } set { _secondYearAmount = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _boolFieldValue.Dirty
                    || _businessName.Dirty
                    || _fieldName.Dirty
                    || _fieldValue.Dirty
                    || _firstYearAmount.Dirty
                    || _formType.Dirty
                    || _id.Dirty
                    || _secondYearAmount.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _boolFieldValue.Dirty = value;
                _businessName.Dirty = value;
                _fieldName.Dirty = value;
                _fieldValue.Dirty = value;
                _firstYearAmount.Dirty = value;
                _formType.Dirty = value;
                _id.Dirty = value;
                _secondYearAmount.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}