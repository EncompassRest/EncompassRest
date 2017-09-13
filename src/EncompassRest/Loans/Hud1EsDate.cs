using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDate : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _userDefined3.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}