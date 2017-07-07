using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010GfeCharge : IClean
    {
        private Value<bool?> _chargeBelow10Indicator;
        public bool? ChargeBelow10Indicator { get { return _chargeBelow10Indicator; } set { _chargeBelow10Indicator = value; } }
        private Value<string> _description;
        public string Description { get { return _description; } set { _description = value; } }
        private Value<int?> _gfe2010GfeChargeIndex;
        public int? Gfe2010GfeChargeIndex { get { return _gfe2010GfeChargeIndex; } set { _gfe2010GfeChargeIndex = value; } }
        private Value<decimal?> _gfeCharge;
        public decimal? GfeCharge { get { return _gfeCharge; } set { _gfeCharge = value; } }
        private Value<decimal?> _hudCharge;
        public decimal? HudCharge { get { return _hudCharge; } set { _hudCharge = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _line;
        public string Line { get { return _line; } set { _line = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _chargeBelow10Indicator.Clean
                    && _description.Clean
                    && _gfe2010GfeChargeIndex.Clean
                    && _gfeCharge.Clean
                    && _hudCharge.Clean
                    && _id.Clean
                    && _line.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var chargeBelow10Indicator = _chargeBelow10Indicator; chargeBelow10Indicator.Clean = value; _chargeBelow10Indicator = chargeBelow10Indicator;
                var description = _description; description.Clean = value; _description = description;
                var gfe2010GfeChargeIndex = _gfe2010GfeChargeIndex; gfe2010GfeChargeIndex.Clean = value; _gfe2010GfeChargeIndex = gfe2010GfeChargeIndex;
                var gfeCharge = _gfeCharge; gfeCharge.Clean = value; _gfeCharge = gfeCharge;
                var hudCharge = _hudCharge; hudCharge.Clean = value; _hudCharge = hudCharge;
                var id = _id; id.Clean = value; _id = id;
                var line = _line; line.Clean = value; _line = line;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010GfeCharge()
        {
            Clean = true;
        }
    }
}