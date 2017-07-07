using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome : IClean
    {
        private Value<bool?> _boolFieldValue;
        public bool? BoolFieldValue { get { return _boolFieldValue; } set { _boolFieldValue = value; } }
        private Value<string> _businessName;
        public string BusinessName { get { return _businessName; } set { _businessName = value; } }
        private Value<string> _fieldName;
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        private Value<decimal?> _fieldValue;
        public decimal? FieldValue { get { return _fieldValue; } set { _fieldValue = value; } }
        private Value<decimal?> _firstYearAmount;
        public decimal? FirstYearAmount { get { return _firstYearAmount; } set { _firstYearAmount = value; } }
        private Value<string> _formType;
        public string FormType { get { return _formType; } set { _formType = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _secondYearAmount;
        public decimal? SecondYearAmount { get { return _secondYearAmount; } set { _secondYearAmount = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _boolFieldValue.Clean
                    && _businessName.Clean
                    && _fieldName.Clean
                    && _fieldValue.Clean
                    && _firstYearAmount.Clean
                    && _formType.Clean
                    && _id.Clean
                    && _secondYearAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _boolFieldValue; v0.Clean = value; _boolFieldValue = v0;
                var v1 = _businessName; v1.Clean = value; _businessName = v1;
                var v2 = _fieldName; v2.Clean = value; _fieldName = v2;
                var v3 = _fieldValue; v3.Clean = value; _fieldValue = v3;
                var v4 = _firstYearAmount; v4.Clean = value; _firstYearAmount = v4;
                var v5 = _formType; v5.Clean = value; _formType = v5;
                var v6 = _id; v6.Clean = value; _id = v6;
                var v7 = _secondYearAmount; v7.Clean = value; _secondYearAmount = v7;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public SelfEmployedIncome()
        {
            Clean = true;
        }
    }
}