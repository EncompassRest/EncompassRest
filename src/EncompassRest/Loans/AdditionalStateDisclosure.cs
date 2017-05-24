using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure
    {
        private Value<string> _disclosureName;
        public string DisclosureName { get { return _disclosureName; } set { _disclosureName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureName() => !_disclosureName.Clean;
        private Value<string> _disclosureValue;
        public string DisclosureValue { get { return _disclosureValue; } set { _disclosureValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureValue() => !_disclosureValue.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _stateCode;
        public string StateCode { get { return _stateCode; } set { _stateCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateCode() => !_stateCode.Clean;
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
                var v0 = _disclosureName; v0.Clean = value; _disclosureName = v0;
                var v1 = _disclosureValue; v1.Clean = value; _disclosureValue = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _stateCode; v3.Clean = value; _stateCode = v3;
                _settingClean = 0;
            }
        }
    }
}