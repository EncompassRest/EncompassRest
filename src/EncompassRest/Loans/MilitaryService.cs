using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class MilitaryService : IClean
    {
        private Value<string> _branch;
        public string Branch { get { return _branch; } set { _branch = value; } }
        private Value<DateTime?> _endDate;
        public DateTime? EndDate { get { return _endDate; } set { _endDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _militaryServiceIndex;
        public int? MilitaryServiceIndex { get { return _militaryServiceIndex; } set { _militaryServiceIndex = value; } }
        private Value<string> _name;
        public string Name { get { return _name; } set { _name = value; } }
        private Value<string> _officerOrEnlisted;
        public string OfficerOrEnlisted { get { return _officerOrEnlisted; } set { _officerOrEnlisted = value; } }
        private Value<string> _serviceNumber;
        public string ServiceNumber { get { return _serviceNumber; } set { _serviceNumber = value; } }
        private Value<string> _sSN;
        public string SSN { get { return _sSN; } set { _sSN = value; } }
        private Value<DateTime?> _startDate;
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
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
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}