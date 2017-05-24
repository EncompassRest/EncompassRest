using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsSetup
    {
        public Value<bool?> AnnualFeePrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFeePrepaid() => !AnnualFeePrepaid.Clean;
        public Value<int?> AnnualFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAnnualFees() => !AnnualFees.Clean;
        public Value<string> Date { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDate() => !Date.Clean;
        public Value<int?> FloodInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsDisb() => !FloodInsDisb.Clean;
        public Value<bool?> FloodInsPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsPrepaid() => !FloodInsPrepaid.Clean;
        public Value<int?> HazInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsDisb() => !HazInsDisb.Clean;
        public Value<bool?> HazInsPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazInsPrepaid() => !HazInsPrepaid.Clean;
        public Value<int?> Hud1EsSetupIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1EsSetupIndex() => !Hud1EsSetupIndex.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<int?> MtgInsDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsDisb() => !MtgInsDisb.Clean;
        public Value<bool?> MtgInsPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMtgInsPrepaid() => !MtgInsPrepaid.Clean;
        public Value<int?> SchoolTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxes() => !SchoolTaxes.Clean;
        public Value<bool?> SchoolTaxesPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolTaxesPrepaid() => !SchoolTaxesPrepaid.Clean;
        public Value<int?> TaxDisb { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxDisb() => !TaxDisb.Clean;
        public Value<bool?> TaxPrepaid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxPrepaid() => !TaxPrepaid.Clean;
        public Value<int?> UserDefined1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined1() => !UserDefined1.Clean;
        public Value<int?> UserDefined2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined2() => !UserDefined2.Clean;
        public Value<int?> UserDefined3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefined3() => !UserDefined3.Clean;
        public Value<bool?> UserDefinedPrepaid1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedPrepaid1() => !UserDefinedPrepaid1.Clean;
        public Value<bool?> UserDefinedPrepaid2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedPrepaid2() => !UserDefinedPrepaid2.Clean;
        public Value<bool?> UserDefinedPrepaid3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedPrepaid3() => !UserDefinedPrepaid3.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AnnualFeePrepaid.Clean
                    && AnnualFees.Clean
                    && Date.Clean
                    && FloodInsDisb.Clean
                    && FloodInsPrepaid.Clean
                    && HazInsDisb.Clean
                    && HazInsPrepaid.Clean
                    && Hud1EsSetupIndex.Clean
                    && Id.Clean
                    && MtgInsDisb.Clean
                    && MtgInsPrepaid.Clean
                    && SchoolTaxes.Clean
                    && SchoolTaxesPrepaid.Clean
                    && TaxDisb.Clean
                    && TaxPrepaid.Clean
                    && UserDefined1.Clean
                    && UserDefined2.Clean
                    && UserDefined3.Clean
                    && UserDefinedPrepaid1.Clean
                    && UserDefinedPrepaid2.Clean
                    && UserDefinedPrepaid3.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AnnualFeePrepaid; v0.Clean = value; AnnualFeePrepaid = v0;
                var v1 = AnnualFees; v1.Clean = value; AnnualFees = v1;
                var v2 = Date; v2.Clean = value; Date = v2;
                var v3 = FloodInsDisb; v3.Clean = value; FloodInsDisb = v3;
                var v4 = FloodInsPrepaid; v4.Clean = value; FloodInsPrepaid = v4;
                var v5 = HazInsDisb; v5.Clean = value; HazInsDisb = v5;
                var v6 = HazInsPrepaid; v6.Clean = value; HazInsPrepaid = v6;
                var v7 = Hud1EsSetupIndex; v7.Clean = value; Hud1EsSetupIndex = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = MtgInsDisb; v9.Clean = value; MtgInsDisb = v9;
                var v10 = MtgInsPrepaid; v10.Clean = value; MtgInsPrepaid = v10;
                var v11 = SchoolTaxes; v11.Clean = value; SchoolTaxes = v11;
                var v12 = SchoolTaxesPrepaid; v12.Clean = value; SchoolTaxesPrepaid = v12;
                var v13 = TaxDisb; v13.Clean = value; TaxDisb = v13;
                var v14 = TaxPrepaid; v14.Clean = value; TaxPrepaid = v14;
                var v15 = UserDefined1; v15.Clean = value; UserDefined1 = v15;
                var v16 = UserDefined2; v16.Clean = value; UserDefined2 = v16;
                var v17 = UserDefined3; v17.Clean = value; UserDefined3 = v17;
                var v18 = UserDefinedPrepaid1; v18.Clean = value; UserDefinedPrepaid1 = v18;
                var v19 = UserDefinedPrepaid2; v19.Clean = value; UserDefinedPrepaid2 = v19;
                var v20 = UserDefinedPrepaid3; v20.Clean = value; UserDefinedPrepaid3 = v20;
                _settingClean = 0;
            }
        }
    }
}