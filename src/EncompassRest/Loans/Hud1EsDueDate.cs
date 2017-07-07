using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var annualFee = _annualFee; annualFee.Clean = value; _annualFee = annualFee;
                var floodInsDisb = _floodInsDisb; floodInsDisb.Clean = value; _floodInsDisb = floodInsDisb;
                var hazInsDisb = _hazInsDisb; hazInsDisb.Clean = value; _hazInsDisb = hazInsDisb;
                var hud1EsDueDateIndex = _hud1EsDueDateIndex; hud1EsDueDateIndex.Clean = value; _hud1EsDueDateIndex = hud1EsDueDateIndex;
                var id = _id; id.Clean = value; _id = id;
                var mtgInsDisb = _mtgInsDisb; mtgInsDisb.Clean = value; _mtgInsDisb = mtgInsDisb;
                var schoolTaxes = _schoolTaxes; schoolTaxes.Clean = value; _schoolTaxes = schoolTaxes;
                var taxDisb = _taxDisb; taxDisb.Clean = value; _taxDisb = taxDisb;
                var userDefined1 = _userDefined1; userDefined1.Clean = value; _userDefined1 = userDefined1;
                var userDefined2 = _userDefined2; userDefined2.Clean = value; _userDefined2 = userDefined2;
                var userDefined3 = _userDefined3; userDefined3.Clean = value; _userDefined3 = userDefined3;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hud1EsDueDate()
        {
            Clean = true;
        }
    }
}