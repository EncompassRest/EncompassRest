using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDueDate : IDirty
    {
        private DirtyValue<DateTime?> _annualFee;
        public DateTime? AnnualFee { get { return _annualFee; } set { _annualFee = value; } }
        private DirtyValue<DateTime?> _floodInsDisb;
        public DateTime? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private DirtyValue<DateTime?> _hazInsDisb;
        public DateTime? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private DirtyValue<int?> _hud1EsDueDateIndex;
        public int? Hud1EsDueDateIndex { get { return _hud1EsDueDateIndex; } set { _hud1EsDueDateIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<DateTime?> _mtgInsDisb;
        public DateTime? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private DirtyValue<DateTime?> _schoolTaxes;
        public DateTime? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private DirtyValue<DateTime?> _taxDisb;
        public DateTime? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private DirtyValue<DateTime?> _userDefined1;
        public DateTime? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private DirtyValue<DateTime?> _userDefined2;
        public DateTime? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private DirtyValue<DateTime?> _userDefined3;
        public DateTime? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _annualFee.Dirty
                    || _floodInsDisb.Dirty
                    || _hazInsDisb.Dirty
                    || _hud1EsDueDateIndex.Dirty
                    || _id.Dirty
                    || _mtgInsDisb.Dirty
                    || _schoolTaxes.Dirty
                    || _taxDisb.Dirty
                    || _userDefined1.Dirty
                    || _userDefined2.Dirty
                    || _userDefined3.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _annualFee.Dirty = value;
                _floodInsDisb.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hud1EsDueDateIndex.Dirty = value;
                _id.Dirty = value;
                _mtgInsDisb.Dirty = value;
                _schoolTaxes.Dirty = value;
                _taxDisb.Dirty = value;
                _userDefined1.Dirty = value;
                _userDefined2.Dirty = value;
                _userDefined3.Dirty = value;
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}