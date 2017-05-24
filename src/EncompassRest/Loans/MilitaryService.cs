using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilitaryService
    {
        private Value<string> _branch;
        public string Branch { get { return _branch; } set { _branch = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBranch() => !_branch.Clean;
        private Value<DateTime?> _endDate;
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEndDate() => !_endDate.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<int?> _militaryServiceIndex;
        public int? MilitaryServiceIndex { get { return _militaryServiceIndex; } set { _militaryServiceIndex = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMilitaryServiceIndex() => !_militaryServiceIndex.Clean;
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeName() => !_name.Clean;
        private Value<string> _officerOrEnlisted;
        public string OfficerOrEnlisted { get { return _officerOrEnlisted; } set { _officerOrEnlisted = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficerOrEnlisted() => !_officerOrEnlisted.Clean;
        private Value<string> _serviceNumber;
        public string ServiceNumber { get { return _serviceNumber; } set { _serviceNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServiceNumber() => !_serviceNumber.Clean;
        private Value<string> _sSN;
        public string SSN { get { return _sSN; } set { _sSN = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSN() => !_sSN.Clean;
        private Value<DateTime?> _startDate;
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStartDate() => !_startDate.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _branch.Clean
                    && _endDate.Clean
                    && _id.Clean
                    && _militaryServiceIndex.Clean
                    && _name.Clean
                    && _officerOrEnlisted.Clean
                    && _serviceNumber.Clean
                    && _sSN.Clean
                    && _startDate.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _branch; v0.Clean = value; _branch = v0;
                var v1 = _endDate; v1.Clean = value; _endDate = v1;
                var v2 = _id; v2.Clean = value; _id = v2;
                var v3 = _militaryServiceIndex; v3.Clean = value; _militaryServiceIndex = v3;
                var v4 = _name; v4.Clean = value; _name = v4;
                var v5 = _officerOrEnlisted; v5.Clean = value; _officerOrEnlisted = v5;
                var v6 = _serviceNumber; v6.Clean = value; _serviceNumber = v6;
                var v7 = _sSN; v7.Clean = value; _sSN = v7;
                var v8 = _startDate; v8.Clean = value; _startDate = v8;
                _settingClean = 0;
            }
        }
    }
}