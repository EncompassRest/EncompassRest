using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDueDate : IClean
    {
        private Value<DateTime?> _annualFee;
        public DateTime? AnnualFee { get { return _annualFee; } set { _annualFee = value; } }
        private Value<DateTime?> _floodInsDisb;
        public DateTime? FloodInsDisb { get { return _floodInsDisb; } set { _floodInsDisb = value; } }
        private Value<DateTime?> _hazInsDisb;
        public DateTime? HazInsDisb { get { return _hazInsDisb; } set { _hazInsDisb = value; } }
        private Value<int?> _hud1EsDueDateIndex;
        public int? Hud1EsDueDateIndex { get { return _hud1EsDueDateIndex; } set { _hud1EsDueDateIndex = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<DateTime?> _mtgInsDisb;
        public DateTime? MtgInsDisb { get { return _mtgInsDisb; } set { _mtgInsDisb = value; } }
        private Value<DateTime?> _schoolTaxes;
        public DateTime? SchoolTaxes { get { return _schoolTaxes; } set { _schoolTaxes = value; } }
        private Value<DateTime?> _taxDisb;
        public DateTime? TaxDisb { get { return _taxDisb; } set { _taxDisb = value; } }
        private Value<DateTime?> _userDefined1;
        public DateTime? UserDefined1 { get { return _userDefined1; } set { _userDefined1 = value; } }
        private Value<DateTime?> _userDefined2;
        public DateTime? UserDefined2 { get { return _userDefined2; } set { _userDefined2 = value; } }
        private Value<DateTime?> _userDefined3;
        public DateTime? UserDefined3 { get { return _userDefined3; } set { _userDefined3 = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _annualFee.Clean
                    && _floodInsDisb.Clean
                    && _hazInsDisb.Clean
                    && _hud1EsDueDateIndex.Clean
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
                var v0 = _annualFee; v0.Clean = value; _annualFee = v0;
                var v1 = _floodInsDisb; v1.Clean = value; _floodInsDisb = v1;
                var v2 = _hazInsDisb; v2.Clean = value; _hazInsDisb = v2;
                var v3 = _hud1EsDueDateIndex; v3.Clean = value; _hud1EsDueDateIndex = v3;
                var v4 = _id; v4.Clean = value; _id = v4;
                var v5 = _mtgInsDisb; v5.Clean = value; _mtgInsDisb = v5;
                var v6 = _schoolTaxes; v6.Clean = value; _schoolTaxes = v6;
                var v7 = _taxDisb; v7.Clean = value; _taxDisb = v7;
                var v8 = _userDefined1; v8.Clean = value; _userDefined1 = v8;
                var v9 = _userDefined2; v9.Clean = value; _userDefined2 = v9;
                var v10 = _userDefined3; v10.Clean = value; _userDefined3 = v10;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}