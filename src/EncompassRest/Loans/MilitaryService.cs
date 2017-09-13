using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class MilitaryService : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _branch.Dirty
                    || _endDate.Dirty
                    || _id.Dirty
                    || _militaryServiceIndex.Dirty
                    || _name.Dirty
                    || _officerOrEnlisted.Dirty
                    || _serviceNumber.Dirty
                    || _sSN.Dirty
                    || _startDate.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _branch.Dirty = value;
                _endDate.Dirty = value;
                _id.Dirty = value;
                _militaryServiceIndex.Dirty = value;
                _name.Dirty = value;
                _officerOrEnlisted.Dirty = value;
                _serviceNumber.Dirty = value;
                _sSN.Dirty = value;
                _startDate.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}