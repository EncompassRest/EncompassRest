using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ComplianceTestLog : IClean
    {
        private Value<string> _details;
        public string Details { get { return _details; } set { _details = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _result;
        public string Result { get { return _result; } set { _result = value; } }
        private Value<bool?> _showAlert;
        public bool? ShowAlert { get { return _showAlert; } set { _showAlert = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _details.Clean
                    && _name.Clean
                    && _result.Clean
                    && _showAlert.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _details; v0.Clean = value; _details = v0;
                var v1 = _name; v1.Clean = value; _name = v1;
                var v2 = _result; v2.Clean = value; _result = v2;
                var v3 = _showAlert; v3.Clean = value; _showAlert = v3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}