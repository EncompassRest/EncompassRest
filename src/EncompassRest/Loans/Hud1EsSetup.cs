using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _annualFeePrepaid; v0.Clean = value; _annualFeePrepaid = v0;
                var v1 = _annualFees; v1.Clean = value; _annualFees = v1;
                var v2 = _date; v2.Clean = value; _date = v2;
                var v3 = _floodInsDisb; v3.Clean = value; _floodInsDisb = v3;
                var v4 = _floodInsPrepaid; v4.Clean = value; _floodInsPrepaid = v4;
                var v5 = _hazInsDisb; v5.Clean = value; _hazInsDisb = v5;
                var v6 = _hazInsPrepaid; v6.Clean = value; _hazInsPrepaid = v6;
                var v7 = _hud1EsSetupIndex; v7.Clean = value; _hud1EsSetupIndex = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _mtgInsDisb; v9.Clean = value; _mtgInsDisb = v9;
                var v10 = _mtgInsPrepaid; v10.Clean = value; _mtgInsPrepaid = v10;
                var v11 = _schoolTaxes; v11.Clean = value; _schoolTaxes = v11;
                var v12 = _schoolTaxesPrepaid; v12.Clean = value; _schoolTaxesPrepaid = v12;
                var v13 = _taxDisb; v13.Clean = value; _taxDisb = v13;
                var v14 = _taxPrepaid; v14.Clean = value; _taxPrepaid = v14;
                var v15 = _userDefined1; v15.Clean = value; _userDefined1 = v15;
                var v16 = _userDefined2; v16.Clean = value; _userDefined2 = v16;
                var v17 = _userDefined3; v17.Clean = value; _userDefined3 = v17;
                var v18 = _userDefinedPrepaid1; v18.Clean = value; _userDefinedPrepaid1 = v18;
                var v19 = _userDefinedPrepaid2; v19.Clean = value; _userDefinedPrepaid2 = v19;
                var v20 = _userDefinedPrepaid3; v20.Clean = value; _userDefinedPrepaid3 = v20;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}