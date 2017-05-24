using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDate
    {
        public Value<decimal?> AggrMthDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAggrMthDisb() => !AggrMthDisb.Clean;
        public Value<decimal?> AnnualFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFee() => !AnnualFee.Clean;
        public Value<decimal?> Balance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalance() => !Balance.Clean;
        public Value<string> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<decimal?> FloodInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsDisb() => !FloodInsDisb.Clean;
        public Value<decimal?> HazInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsDisb() => !HazInsDisb.Clean;
        public Value<int?> Hud1EsDateIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsDateIndex() => !Hud1EsDateIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> MtgInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsDisb() => !MtgInsDisb.Clean;
        public Value<decimal?> SchoolTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxes() => !SchoolTaxes.Clean;
        public Value<decimal?> TaxDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxDisb() => !TaxDisb.Clean;
        public Value<decimal?> UserDefined1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1() => !UserDefined1.Clean;
        public Value<decimal?> UserDefined2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined2() => !UserDefined2.Clean;
        public Value<decimal?> UserDefined3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined3() => !UserDefined3.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AggrMthDisb.Clean
                    && AnnualFee.Clean
                    && Balance.Clean
                    && Date.Clean
                    && FloodInsDisb.Clean
                    && HazInsDisb.Clean
                    && Hud1EsDateIndex.Clean
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
                var v0 = AggrMthDisb; v0.Clean = value; AggrMthDisb = v0;
                var v1 = AnnualFee; v1.Clean = value; AnnualFee = v1;
                var v2 = Balance; v2.Clean = value; Balance = v2;
                var v3 = Date; v3.Clean = value; Date = v3;
                var v4 = FloodInsDisb; v4.Clean = value; FloodInsDisb = v4;
                var v5 = HazInsDisb; v5.Clean = value; HazInsDisb = v5;
                var v6 = Hud1EsDateIndex; v6.Clean = value; Hud1EsDateIndex = v6;
                var v7 = Id; v7.Clean = value; Id = v7;
                var v8 = MtgInsDisb; v8.Clean = value; MtgInsDisb = v8;
                var v9 = SchoolTaxes; v9.Clean = value; SchoolTaxes = v9;
                var v10 = TaxDisb; v10.Clean = value; TaxDisb = v10;
                var v11 = UserDefined1; v11.Clean = value; UserDefined1 = v11;
                var v12 = UserDefined2; v12.Clean = value; UserDefined2 = v12;
                var v13 = UserDefined3; v13.Clean = value; UserDefined3 = v13;
                _settingClean = 0;
            }
        }
    }
}