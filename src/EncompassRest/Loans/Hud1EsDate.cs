using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDate : IClean
    {
        private Value<decimal?> _aggrMthDisb;
        public decimal? AggrMthDisb { get { return _aggrMthDisb; } set { _aggrMthDisb = value; } }
        private Value<decimal?> _annualFee;
        public decimal? AnnualFee { get { return _annualFee; } set { _annualFee = value; } }
        private Value<decimal?> _balance;
        public decimal? Balance { get { return _balance; } set { _balance = value; } }
        private Value<string> _date;
        public string Date { get { return _date; } set { _date = value; } }
        private Value<decimal?> _floodInsDisb;
        public decimal? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private Value<decimal?> _hazInsDisb;
        public decimal? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private Value<int?> _hud1EsDateIndex;
        public int? Hud1EsDateIndex { get { return _hud1EsDateIndex; } set { _hud1EsDateIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _mtgInsDisb;
        public decimal? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private Value<decimal?> _schoolTaxes;
        public decimal? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private Value<decimal?> _taxDisb;
        public decimal? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private Value<decimal?> _userDefined1;
        public decimal? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private Value<decimal?> _userDefined2;
        public decimal? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private Value<decimal?> _userDefined3;
        public decimal? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aggrMthDisb.Clean
                    && _annualFee.Clean
                    && _balance.Clean
                    && _date.Clean
                    && _floodInsDisb.Clean
                    && _hazInsDisb.Clean
                    && _hud1EsDateIndex.Clean
                    && _id.Clean
                    && _mtgInsDisb.Clean
                    && _schoolTaxes.Clean
                    && _taxDisb.Clean
                    && _userDefined1.Clean
                    && _userDefined2.Clean
                    && _userDefined3.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _aggrMthDisb; v0.Clean = value; _aggrMthDisb = v0;
                var v1 = _annualFee; v1.Clean = value; _annualFee = v1;
                var v2 = _balance; v2.Clean = value; _balance = v2;
                var v3 = _date; v3.Clean = value; _date = v3;
                var v4 = _floodInsDisb; v4.Clean = value; _floodInsDisb = v4;
                var v5 = _hazInsDisb; v5.Clean = value; _hazInsDisb = v5;
                var v6 = _hud1EsDateIndex; v6.Clean = value; _hud1EsDateIndex = v6;
                var v7 = _id; v7.Clean = value; _id = v7;
                var v8 = _mtgInsDisb; v8.Clean = value; _mtgInsDisb = v8;
                var v9 = _schoolTaxes; v9.Clean = value; _schoolTaxes = v9;
                var v10 = _taxDisb; v10.Clean = value; _taxDisb = v10;
                var v11 = _userDefined1; v11.Clean = value; _userDefined1 = v11;
                var v12 = _userDefined2; v12.Clean = value; _userDefined2 = v12;
                var v13 = _userDefined3; v13.Clean = value; _userDefined3 = v13;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}