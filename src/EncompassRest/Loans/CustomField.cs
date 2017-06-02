using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class CustomField : IClean
    {
        private Value<DateTime?> _dateValue;
        public DateTime? DateValue { get { return _dateValue; } set { _dateValue = value; } }
        private Value<string> _fieldName;
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _numericValue;
        public decimal? NumericValue { get { return _numericValue; } set { _numericValue = value; } }
        private Value<string> _stringValue;
        public string StringValue { get { return _stringValue; } set { _stringValue = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _dateValue.Clean
                    && _fieldName.Clean
                    && _id.Clean
                    && _numericValue.Clean
                    && _stringValue.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _dateValue; v0.Clean = value; _dateValue = v0;
                var v1 = _fieldName; v1.Clean = value; _fieldName = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _numericValue; v3.Clean = value; _numericValue = v3;
                var v4 = _stringValue; v4.Clean = value; _stringValue = v4;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public CustomField()
        {
            Clean = true;
        }
    }
}