using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure : IClean
    {
        private Value<string> _disclosureName;
        public string DisclosureName { get { return _disclosureName; } set { _disclosureName = value; } }
        private Value<string> _disclosureValue;
        public string DisclosureValue { get { return _disclosureValue; } set { _disclosureValue = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _stateCode;
        public string StateCode { get { return _stateCode; } set { _stateCode = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _disclosureName.Clean
                    && _disclosureValue.Clean
                    && _id.Clean
                    && _stateCode.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var disclosureName = _disclosureName; disclosureName.Clean = value; _disclosureName = disclosureName;
                var disclosureValue = _disclosureValue; disclosureValue.Clean = value; _disclosureValue = disclosureValue;
                var id = _id; id.Clean = value; _id = id;
                var stateCode = _stateCode; stateCode.Clean = value; _stateCode = stateCode;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public AdditionalStateDisclosure()
        {
            Clean = true;
        }
    }
}