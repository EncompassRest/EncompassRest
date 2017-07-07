using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var branch = _branch; branch.Clean = value; _branch = branch;
                var endDate = _endDate; endDate.Clean = value; _endDate = endDate;
                var id = _id; id.Clean = value; _id = id;
                var militaryServiceIndex = _militaryServiceIndex; militaryServiceIndex.Clean = value; _militaryServiceIndex = militaryServiceIndex;
                var name = _name; name.Clean = value; _name = name;
                var officerOrEnlisted = _officerOrEnlisted; officerOrEnlisted.Clean = value; _officerOrEnlisted = officerOrEnlisted;
                var serviceNumber = _serviceNumber; serviceNumber.Clean = value; _serviceNumber = serviceNumber;
                var sSN = _sSN; sSN.Clean = value; _sSN = sSN;
                var startDate = _startDate; startDate.Clean = value; _startDate = startDate;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public MilitaryService()
        {
            Clean = true;
        }
    }
}