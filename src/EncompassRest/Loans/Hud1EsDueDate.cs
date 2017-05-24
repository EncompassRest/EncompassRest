using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDueDate
    {
        public Value<DateTime?> AnnualFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFee() => !AnnualFee.Clean;
        public Value<DateTime?> FloodInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsDisb() => !FloodInsDisb.Clean;
        public Value<DateTime?> HazInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsDisb() => !HazInsDisb.Clean;
        public Value<int?> Hud1EsDueDateIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDueDateIndex() => !Hud1EsDueDateIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<DateTime?> MtgInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsDisb() => !MtgInsDisb.Clean;
        public Value<DateTime?> SchoolTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxes() => !SchoolTaxes.Clean;
        public Value<DateTime?> TaxDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxDisb() => !TaxDisb.Clean;
        public Value<DateTime?> UserDefined1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1() => !UserDefined1.Clean;
        public Value<DateTime?> UserDefined2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined2() => !UserDefined2.Clean;
        public Value<DateTime?> UserDefined3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined3() => !UserDefined3.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AnnualFee.Clean
                    && FloodInsDisb.Clean
                    && HazInsDisb.Clean
                    && Hud1EsDueDateIndex.Clean
                    && Id.Clean
                    && MtgInsDisb.Clean
                    && SchoolTaxes.Clean
                    && TaxDisb.Clean
                    && UserDefined1.Clean
                    && UserDefined2.Clean
                    && UserDefined3.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AnnualFee; v0.Clean = value; AnnualFee = v0;
                var v1 = FloodInsDisb; v1.Clean = value; FloodInsDisb = v1;
                var v2 = HazInsDisb; v2.Clean = value; HazInsDisb = v2;
                var v3 = Hud1EsDueDateIndex; v3.Clean = value; Hud1EsDueDateIndex = v3;
                var v4 = Id; v4.Clean = value; Id = v4;
                var v5 = MtgInsDisb; v5.Clean = value; MtgInsDisb = v5;
                var v6 = SchoolTaxes; v6.Clean = value; SchoolTaxes = v6;
                var v7 = TaxDisb; v7.Clean = value; TaxDisb = v7;
                var v8 = UserDefined1; v8.Clean = value; UserDefined1 = v8;
                var v9 = UserDefined2; v9.Clean = value; UserDefined2 = v9;
                var v10 = UserDefined3; v10.Clean = value; UserDefined3 = v10;
                _settingClean = 0;
            }
        }
    }
}