using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Hud1EsDate : IDirty
    {
        private DirtyValue<decimal?> _aggrMthDisb;
        public decimal? AggrMthDisb { get { return _aggrMthDisb; } set { _aggrMthDisb = value; } }
        private DirtyValue<decimal?> _annualFee;
        public decimal? AnnualFee { get { return _annualFee; } set { _annualFee = value; } }
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private DirtyValue<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private DirtyValue<decimal?> _floodInsDisb;
        public decimal? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private DirtyValue<decimal?> _hazInsDisb;
        public decimal? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private DirtyValue<int?> _hud1EsDateIndex;
        public int? Hud1EsDateIndex { get { return _hud1EsDateIndex; } set { _hud1EsDateIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _mtgInsDisb;
        public decimal? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private DirtyValue<decimal?> _schoolTaxes;
        public decimal? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private DirtyValue<decimal?> _taxDisb;
        public decimal? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private DirtyValue<decimal?> _userDefined1;
        public decimal? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private DirtyValue<decimal?> _userDefined2;
        public decimal? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private DirtyValue<decimal?> _userDefined3;
        public decimal? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _aggrMthDisb.Dirty
                    || _annualFee.Dirty
                    || _balance.Dirty
                    || _date.Dirty
                    || _floodInsDisb.Dirty
                    || _hazInsDisb.Dirty
                    || _hud1EsDateIndex.Dirty
                    || _id.Dirty
                    || _mtgInsDisb.Dirty
                    || _schoolTaxes.Dirty
                    || _taxDisb.Dirty
                    || _userDefined1.Dirty
                    || _userDefined2.Dirty
                    || _userDefined3.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _aggrMthDisb.Dirty = value;
                _annualFee.Dirty = value;
                _balance.Dirty = value;
                _date.Dirty = value;
                _floodInsDisb.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hud1EsDateIndex.Dirty = value;
                _id.Dirty = value;
                _mtgInsDisb.Dirty = value;
                _schoolTaxes.Dirty = value;
                _taxDisb.Dirty = value;
                _userDefined1.Dirty = value;
                _userDefined2.Dirty = value;
                _userDefined3.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}