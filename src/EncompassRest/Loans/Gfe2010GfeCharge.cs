using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010GfeCharge
    {
        public Value<bool?> ChargeBelow10Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeChargeBelow10Indicator() => !ChargeBelow10Indicator.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<int?> Gfe2010GfeChargeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010GfeChargeIndex() => !Gfe2010GfeChargeIndex.Clean;
        public Value<decimal?> GfeCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeCharge() => !GfeCharge.Clean;
        public Value<decimal?> HudCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudCharge() => !HudCharge.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> Line { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine() => !Line.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ChargeBelow10Indicator.Clean
                    && Description.Clean
                    && Gfe2010GfeChargeIndex.Clean
                    && GfeCharge.Clean
                    && HudCharge.Clean
                    && Id.Clean
                    && Line.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ChargeBelow10Indicator; v0.Clean = value; ChargeBelow10Indicator = v0;
                var v1 = Description; v1.Clean = value; Description = v1;
                var v2 = Gfe2010GfeChargeIndex; v2.Clean = value; Gfe2010GfeChargeIndex = v2;
                var v3 = GfeCharge; v3.Clean = value; GfeCharge = v3;
                var v4 = HudCharge; v4.Clean = value; HudCharge = v4;
                var v5 = Id; v5.Clean = value; Id = v5;
                var v6 = Line; v6.Clean = value; Line = v6;
                _settingClean = 0;
            }
        }
    }
}