using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class CustomField : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _dateValue.Dirty
                    || _fieldName.Dirty
                    || _id.Dirty
                    || _numericValue.Dirty
                    || _stringValue.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _dateValue.Dirty = value;
                _fieldName.Dirty = value;
                _id.Dirty = value;
                _numericValue.Dirty = value;
                _stringValue.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}