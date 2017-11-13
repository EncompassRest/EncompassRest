using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class MilitaryService : IDirty
    {
        private DirtyValue<string> _branch;
        public string Branch { get => _branch; set => _branch = value; }
        private DirtyValue<DateTime?> _endDate;
        public DateTime? EndDate { get => _endDate; set => _endDate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _militaryServiceIndex;
        public int? MilitaryServiceIndex { get => _militaryServiceIndex; set => _militaryServiceIndex = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private StringEnumValue<OfficerOrEnlisted> _officerOrEnlisted;
        public StringEnumValue<OfficerOrEnlisted> OfficerOrEnlisted { get => _officerOrEnlisted; set => _officerOrEnlisted = value; }
        private DirtyValue<string> _serviceNumber;
        public string ServiceNumber { get => _serviceNumber; set => _serviceNumber = value; }
        private DirtyValue<string> _sSN;
        public string SSN { get => _sSN; set => _sSN = value; }
        private DirtyValue<DateTime?> _startDate;
        public DateTime? StartDate { get => _startDate; set => _startDate = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _branch.Dirty
                    || _endDate.Dirty
                    || _id.Dirty
                    || _militaryServiceIndex.Dirty
                    || _name.Dirty
                    || _officerOrEnlisted.Dirty
                    || _serviceNumber.Dirty
                    || _sSN.Dirty
                    || _startDate.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _branch.Dirty = value;
                _endDate.Dirty = value;
                _id.Dirty = value;
                _militaryServiceIndex.Dirty = value;
                _name.Dirty = value;
                _officerOrEnlisted.Dirty = value;
                _serviceNumber.Dirty = value;
                _sSN.Dirty = value;
                _startDate.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}