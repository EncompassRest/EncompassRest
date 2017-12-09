#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsSetup : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _annualFeePrepaid;
        public bool? AnnualFeePrepaid { get => _annualFeePrepaid; set => _annualFeePrepaid = value; }
        private DirtyValue<int?> _annualFees;
        public int? AnnualFees { get => _annualFees; set => _annualFees = value; }
        private DirtyValue<string> _date;
        public string Date { get => _date; set => _date = value; }
        private DirtyValue<int?> _floodInsDisb;
        public int? FloodInsDisb { get => _floodInsDisb; set => _floodInsDisb = value; }
        private DirtyValue<bool?> _floodInsPrepaid;
        public bool? FloodInsPrepaid { get => _floodInsPrepaid; set => _floodInsPrepaid = value; }
        private DirtyValue<int?> _hazInsDisb;
        public int? HazInsDisb { get => _hazInsDisb; set => _hazInsDisb = value; }
        private DirtyValue<bool?> _hazInsPrepaid;
        public bool? HazInsPrepaid { get => _hazInsPrepaid; set => _hazInsPrepaid = value; }
        private DirtyValue<int?> _hud1EsSetupIndex;
        public int? Hud1EsSetupIndex { get => _hud1EsSetupIndex; set => _hud1EsSetupIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _mtgInsDisb;
        public int? MtgInsDisb { get => _mtgInsDisb; set => _mtgInsDisb = value; }
        private DirtyValue<bool?> _mtgInsPrepaid;
        public bool? MtgInsPrepaid { get => _mtgInsPrepaid; set => _mtgInsPrepaid = value; }
        private DirtyValue<int?> _schoolTaxes;
        public int? SchoolTaxes { get => _schoolTaxes; set => _schoolTaxes = value; }
        private DirtyValue<bool?> _schoolTaxesPrepaid;
        public bool? SchoolTaxesPrepaid { get => _schoolTaxesPrepaid; set => _schoolTaxesPrepaid = value; }
        private DirtyValue<int?> _taxDisb;
        public int? TaxDisb { get => _taxDisb; set => _taxDisb = value; }
        private DirtyValue<bool?> _taxPrepaid;
        public bool? TaxPrepaid { get => _taxPrepaid; set => _taxPrepaid = value; }
        private DirtyValue<int?> _userDefined1;
        public int? UserDefined1 { get => _userDefined1; set => _userDefined1 = value; }
        private DirtyValue<int?> _userDefined2;
        public int? UserDefined2 { get => _userDefined2; set => _userDefined2 = value; }
        private DirtyValue<int?> _userDefined3;
        public int? UserDefined3 { get => _userDefined3; set => _userDefined3 = value; }
        private DirtyValue<bool?> _userDefinedPrepaid1;
        public bool? UserDefinedPrepaid1 { get => _userDefinedPrepaid1; set => _userDefinedPrepaid1 = value; }
        private DirtyValue<bool?> _userDefinedPrepaid2;
        public bool? UserDefinedPrepaid2 { get => _userDefinedPrepaid2; set => _userDefinedPrepaid2 = value; }
        private DirtyValue<bool?> _userDefinedPrepaid3;
        public bool? UserDefinedPrepaid3 { get => _userDefinedPrepaid3; set => _userDefinedPrepaid3 = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _annualFeePrepaid.Dirty
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
            }
            set
            {
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
            }
        }
    }
}