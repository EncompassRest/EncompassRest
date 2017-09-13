using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDueDate : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _annualFee.Dirty
                    || _floodInsDisb.Dirty
                    || _hazInsDisb.Dirty
                    || _hud1EsDueDateIndex.Dirty
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
                _annualFee.Dirty = value;
                _floodInsDisb.Dirty = value;
                _hazInsDisb.Dirty = value;
                _hud1EsDueDateIndex.Dirty = value;
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