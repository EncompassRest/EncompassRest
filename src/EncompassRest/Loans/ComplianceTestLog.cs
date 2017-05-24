using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ComplianceTestLog
    {
        public Value<string> Details { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDetails() => !Details.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> Result { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeResult() => !Result.Clean;
        public Value<bool?> ShowAlert { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShowAlert() => !ShowAlert.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Details.Clean
                    && Name.Clean
                    && Result.Clean
                    && ShowAlert.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Details; v0.Clean = value; Details = v0;
                var v1 = Name; v1.Clean = value; Name = v1;
                var v2 = Result; v2.Clean = value; Result = v2;
                var v3 = ShowAlert; v3.Clean = value; ShowAlert = v3;
                _settingClean = 0;
            }
        }
    }
}