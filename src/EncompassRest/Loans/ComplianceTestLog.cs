using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var details = _details; details.Clean = value; _details = details;
                var name = _name; name.Clean = value; _name = name;
                var result = _result; result.Clean = value; _result = result;
                var showAlert = _showAlert; showAlert.Clean = value; _showAlert = showAlert;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ComplianceTestLog()
        {
            Clean = true;
        }
    }
}