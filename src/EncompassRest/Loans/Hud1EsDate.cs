#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDate : ExtensibleObject
    {
        private DirtyValue<decimal?> _aggrMthDisb;
        public decimal? AggrMthDisb { get => _aggrMthDisb; set => _aggrMthDisb = value; }
        private DirtyValue<decimal?> _annualFee;
        public decimal? AnnualFee { get => _annualFee; set => _annualFee = value; }
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _date;
        public string Date { get => _date; set => _date = value; }
        private DirtyValue<decimal?> _floodInsDisb;
        public decimal? FloodInsDisb { get => _floodInsDisb; set => _floodInsDisb = value; }
        private DirtyValue<decimal?> _hazInsDisb;
        public decimal? HazInsDisb { get => _hazInsDisb; set => _hazInsDisb = value; }
        private DirtyValue<int?> _hud1EsDateIndex;
        public int? Hud1EsDateIndex { get => _hud1EsDateIndex; set => _hud1EsDateIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _mtgInsDisb;
        public decimal? MtgInsDisb { get => _mtgInsDisb; set => _mtgInsDisb = value; }
        private DirtyValue<decimal?> _schoolTaxes;
        public decimal? SchoolTaxes { get => _schoolTaxes; set => _schoolTaxes = value; }
        private DirtyValue<decimal?> _taxDisb;
        public decimal? TaxDisb { get => _taxDisb; set => _taxDisb = value; }
        private DirtyValue<decimal?> _userDefined1;
        public decimal? UserDefined1 { get => _userDefined1; set => _userDefined1 = value; }
        private DirtyValue<decimal?> _userDefined2;
        public decimal? UserDefined2 { get => _userDefined2; set => _userDefined2 = value; }
        private DirtyValue<decimal?> _userDefined3;
        public decimal? UserDefined3 { get => _userDefined3; set => _userDefined3 = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aggrMthDisb.Dirty
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
            }
            set
            {
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
            }
        }
    }
}