using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsSetup : IDirty
    {
        private DirtyValue<bool?> _annualFeePrepaid;
        public bool? AnnualFeePrepaid { get { return _annualFeePrepaid; } set { _annualFeePrepaid = value; } }
        private DirtyValue<int?> _annualFees;
        public int? AnnualFees { get { return _annualFees; } set { _annualFees = value; } }
        private DirtyValue<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private DirtyValue<int?> _floodInsDisb;
        public int? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private DirtyValue<bool?> _floodInsPrepaid;
        public bool? FloodInsPrepaid { get { return _floodInsPrepaid; } set { _floodInsPrepaid = value; } }
        private DirtyValue<int?> _hazInsDisb;
        public int? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private DirtyValue<bool?> _hazInsPrepaid;
        public bool? HazInsPrepaid { get { return _hazInsPrepaid; } set { _hazInsPrepaid = value; } }
        private DirtyValue<int?> _hud1EsSetupIndex;
        public int? Hud1EsSetupIndex { get { return _hud1EsSetupIndex; } set { _hud1EsSetupIndex = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<int?> _mtgInsDisb;
        public int? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private DirtyValue<bool?> _mtgInsPrepaid;
        public bool? MtgInsPrepaid { get { return _mtgInsPrepaid; } set { _mtgInsPrepaid = value; } }
        private DirtyValue<int?> _schoolTaxes;
        public int? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private DirtyValue<bool?> _schoolTaxesPrepaid;
        public bool? SchoolTaxesPrepaid { get { return _schoolTaxesPrepaid; } set { _schoolTaxesPrepaid = value; } }
        private DirtyValue<int?> _taxDisb;
        public int? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private DirtyValue<bool?> _taxPrepaid;
        public bool? TaxPrepaid { get { return _taxPrepaid; } set { _taxPrepaid = value; } }
        private DirtyValue<int?> _userDefined1;
        public int? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private DirtyValue<int?> _userDefined2;
        public int? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private DirtyValue<int?> _userDefined3;
        public int? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private DirtyValue<bool?> _userDefinedPrepaid1;
        public bool? UserDefinedPrepaid1 { get { return _userDefinedPrepaid1; } set { _userDefinedPrepaid1 = value; } }
        private DirtyValue<bool?> _userDefinedPrepaid2;
        public bool? UserDefinedPrepaid2 { get { return _userDefinedPrepaid2; } set { _userDefinedPrepaid2 = value; } }
        private DirtyValue<bool?> _userDefinedPrepaid3;
        public bool? UserDefinedPrepaid3 { get { return _userDefinedPrepaid3; } set { _userDefinedPrepaid3 = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _annualFeePrepaid.Dirty
                    || _annualFees.Dirty
                    || _date.Dirty
                    || _floodInsDisb.Dirty
                    || _floodInsPrepaid.Dirty
                    || _hazInsDisb.Dirty
                    || _hazInsPrepaid.Dirty
                    || _hud1EsSetupIndex.Dirty
                    || _id.Dirty
                    || _mtgInsDisb.Dirty
                    || _mtgInsPrepaid.Dirty
                    || _schoolTaxes.Dirty
                    || _schoolTaxesPrepaid.Dirty
                    || _taxDisb.Dirty
                    || _taxPrepaid.Dirty
                    || _userDefined1.Dirty
                    || _userDefined2.Dirty
                    || _userDefined3.Dirty
                    || _userDefinedPrepaid1.Dirty
                    || _userDefinedPrepaid2.Dirty
                    || _userDefinedPrepaid3.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _annualFeePrepaid.Dirty = value;
                _annualFees.Dirty = value;
                _date.Dirty = value;
                _floodInsDisb.Dirty = value;
                _floodInsPrepaid.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hazInsPrepaid.Dirty = value;
                _hud1EsSetupIndex.Dirty = value;
                _id.Dirty = value;
                _mtgInsDisb.Dirty = value;
                _mtgInsPrepaid.Dirty = value;
                _schoolTaxes.Dirty = value;
                _schoolTaxesPrepaid.Dirty = value;
                _taxDisb.Dirty = value;
                _taxPrepaid.Dirty = value;
                _userDefined1.Dirty = value;
                _userDefined2.Dirty = value;
                _userDefined3.Dirty = value;
                _userDefinedPrepaid1.Dirty = value;
                _userDefinedPrepaid2.Dirty = value;
                _userDefinedPrepaid3.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}