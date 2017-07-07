using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsSetup : IClean
    {
        private Value<bool?> _annualFeePrepaid;
        public bool? AnnualFeePrepaid { get { return _annualFeePrepaid; } set { _annualFeePrepaid = value; } }
        private Value<int?> _annualFees;
        public int? AnnualFees { get { return _annualFees; } set { _annualFees = value; } }
        private Value<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private Value<int?> _floodInsDisb;
        public int? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private Value<bool?> _floodInsPrepaid;
        public bool? FloodInsPrepaid { get { return _floodInsPrepaid; } set { _floodInsPrepaid = value; } }
        private Value<int?> _hazInsDisb;
        public int? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private Value<bool?> _hazInsPrepaid;
        public bool? HazInsPrepaid { get { return _hazInsPrepaid; } set { _hazInsPrepaid = value; } }
        private Value<int?> _hud1EsSetupIndex;
        public int? Hud1EsSetupIndex { get { return _hud1EsSetupIndex; } set { _hud1EsSetupIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<int?> _mtgInsDisb;
        public int? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private Value<bool?> _mtgInsPrepaid;
        public bool? MtgInsPrepaid { get { return _mtgInsPrepaid; } set { _mtgInsPrepaid = value; } }
        private Value<int?> _schoolTaxes;
        public int? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private Value<bool?> _schoolTaxesPrepaid;
        public bool? SchoolTaxesPrepaid { get { return _schoolTaxesPrepaid; } set { _schoolTaxesPrepaid = value; } }
        private Value<int?> _taxDisb;
        public int? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private Value<bool?> _taxPrepaid;
        public bool? TaxPrepaid { get { return _taxPrepaid; } set { _taxPrepaid = value; } }
        private Value<int?> _userDefined1;
        public int? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private Value<int?> _userDefined2;
        public int? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private Value<int?> _userDefined3;
        public int? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private Value<bool?> _userDefinedPrepaid1;
        public bool? UserDefinedPrepaid1 { get { return _userDefinedPrepaid1; } set { _userDefinedPrepaid1 = value; } }
        private Value<bool?> _userDefinedPrepaid2;
        public bool? UserDefinedPrepaid2 { get { return _userDefinedPrepaid2; } set { _userDefinedPrepaid2 = value; } }
        private Value<bool?> _userDefinedPrepaid3;
        public bool? UserDefinedPrepaid3 { get { return _userDefinedPrepaid3; } set { _userDefinedPrepaid3 = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _annualFeePrepaid.Clean
                    && _annualFees.Clean
                    && _date.Clean
                    && _floodInsDisb.Clean
                    && _floodInsPrepaid.Clean
                    && _hazInsDisb.Clean
                    && _hazInsPrepaid.Clean
                    && _hud1EsSetupIndex.Clean
                    && _id.Clean
                    && _mtgInsDisb.Clean
                    && _mtgInsPrepaid.Clean
                    && _schoolTaxes.Clean
                    && _schoolTaxesPrepaid.Clean
                    && _taxDisb.Clean
                    && _taxPrepaid.Clean
                    && _userDefined1.Clean
                    && _userDefined2.Clean
                    && _userDefined3.Clean
                    && _userDefinedPrepaid1.Clean
                    && _userDefinedPrepaid2.Clean
                    && _userDefinedPrepaid3.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var annualFeePrepaid = _annualFeePrepaid; annualFeePrepaid.Clean = value; _annualFeePrepaid = annualFeePrepaid;
                var annualFees = _annualFees; annualFees.Clean = value; _annualFees = annualFees;
                var date = _date; date.Clean = value; _date = date;
                var floodInsDisb = _floodInsDisb; floodInsDisb.Clean = value; _floodInsDisb = floodInsDisb;
                var floodInsPrepaid = _floodInsPrepaid; floodInsPrepaid.Clean = value; _floodInsPrepaid = floodInsPrepaid;
                var hazInsDisb = _hazInsDisb; hazInsDisb.Clean = value; _hazInsDisb = hazInsDisb;
                var hazInsPrepaid = _hazInsPrepaid; hazInsPrepaid.Clean = value; _hazInsPrepaid = hazInsPrepaid;
                var hud1EsSetupIndex = _hud1EsSetupIndex; hud1EsSetupIndex.Clean = value; _hud1EsSetupIndex = hud1EsSetupIndex;
                var id = _id; id.Clean = value; _id = id;
                var mtgInsDisb = _mtgInsDisb; mtgInsDisb.Clean = value; _mtgInsDisb = mtgInsDisb;
                var mtgInsPrepaid = _mtgInsPrepaid; mtgInsPrepaid.Clean = value; _mtgInsPrepaid = mtgInsPrepaid;
                var schoolTaxes = _schoolTaxes; schoolTaxes.Clean = value; _schoolTaxes = schoolTaxes;
                var schoolTaxesPrepaid = _schoolTaxesPrepaid; schoolTaxesPrepaid.Clean = value; _schoolTaxesPrepaid = schoolTaxesPrepaid;
                var taxDisb = _taxDisb; taxDisb.Clean = value; _taxDisb = taxDisb;
                var taxPrepaid = _taxPrepaid; taxPrepaid.Clean = value; _taxPrepaid = taxPrepaid;
                var userDefined1 = _userDefined1; userDefined1.Clean = value; _userDefined1 = userDefined1;
                var userDefined2 = _userDefined2; userDefined2.Clean = value; _userDefined2 = userDefined2;
                var userDefined3 = _userDefined3; userDefined3.Clean = value; _userDefined3 = userDefined3;
                var userDefinedPrepaid1 = _userDefinedPrepaid1; userDefinedPrepaid1.Clean = value; _userDefinedPrepaid1 = userDefinedPrepaid1;
                var userDefinedPrepaid2 = _userDefinedPrepaid2; userDefinedPrepaid2.Clean = value; _userDefinedPrepaid2 = userDefinedPrepaid2;
                var userDefinedPrepaid3 = _userDefinedPrepaid3; userDefinedPrepaid3.Clean = value; _userDefinedPrepaid3 = userDefinedPrepaid3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hud1EsSetup()
        {
            Clean = true;
        }
    }
}