using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class FieldLockData : IClean
    {
        private Value<bool?> _lockRemoved;
        public bool? LockRemoved { get { return _lockRemoved; } set { _lockRemoved = value; } }
        private Value<string> _modelPath;
        public string ModelPath { get { return _modelPath; } set { _modelPath = value; } }
        private Value<string> _value;
        public string Value { get { return _value; } set { _value = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _lockRemoved.Clean
                    && _modelPath.Clean
                    && _value.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _lockRemoved; v0.Clean = value; _lockRemoved = v0;
                var v1 = _modelPath; v1.Clean = value; _modelPath = v1;
                var v2 = _value; v2.Clean = value; _value = v2;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public FieldLockData()
        {
            Clean = true;
        }
    }
}