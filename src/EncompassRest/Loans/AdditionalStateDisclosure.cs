using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure
    {
        public Value<string> DisclosureName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureName() => !DisclosureName.Clean;
        public Value<string> DisclosureValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureValue() => !DisclosureValue.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> StateCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateCode() => !StateCode.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DisclosureName.Clean
                    && DisclosureValue.Clean
                    && Id.Clean
                    && StateCode.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DisclosureName; v0.Clean = value; DisclosureName = v0;
                var v1 = DisclosureValue; v1.Clean = value; DisclosureValue = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = StateCode; v3.Clean = value; StateCode = v3;
                _settingClean = 0;
            }
        }
    }
}