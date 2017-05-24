using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilitaryService
    {
        public Value<string> Branch { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranch() => !Branch.Clean;
        public Value<DateTime?> EndDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndDate() => !EndDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> MilitaryServiceIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryServiceIndex() => !MilitaryServiceIndex.Clean;
        public Value<string> Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !Name.Clean;
        public Value<string> OfficerOrEnlisted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficerOrEnlisted() => !OfficerOrEnlisted.Clean;
        public Value<string> ServiceNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceNumber() => !ServiceNumber.Clean;
        public Value<string> SSN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSN() => !SSN.Clean;
        public Value<DateTime?> StartDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartDate() => !StartDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = Branch.Clean
                    && EndDate.Clean
                    && Id.Clean
                    && MilitaryServiceIndex.Clean
                    && Name.Clean
                    && OfficerOrEnlisted.Clean
                    && ServiceNumber.Clean
                    && SSN.Clean
                    && StartDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = Branch; v0.Clean = value; Branch = v0;
                var v1 = EndDate; v1.Clean = value; EndDate = v1;
                var v2 = Id; v2.Clean = value; Id = v2;
                var v3 = MilitaryServiceIndex; v3.Clean = value; MilitaryServiceIndex = v3;
                var v4 = Name; v4.Clean = value; Name = v4;
                var v5 = OfficerOrEnlisted; v5.Clean = value; OfficerOrEnlisted = v5;
                var v6 = ServiceNumber; v6.Clean = value; ServiceNumber = v6;
                var v7 = SSN; v7.Clean = value; SSN = v7;
                var v8 = StartDate; v8.Clean = value; StartDate = v8;
                _settingClean = 0;
            }
        }
    }
}