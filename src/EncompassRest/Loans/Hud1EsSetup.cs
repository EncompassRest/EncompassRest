using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsSetup
    {
        public JsonNullable<bool?> AnnualFeePrepaid { get; set; }
        public JsonNullable<int?> AnnualFees { get; set; }
        public string Date { get; set; }
        public JsonNullable<int?> FloodInsDisb { get; set; }
        public JsonNullable<bool?> FloodInsPrepaid { get; set; }
        public JsonNullable<int?> HazInsDisb { get; set; }
        public JsonNullable<bool?> HazInsPrepaid { get; set; }
        public int? Hud1EsSetupIndex { get; set; }
        public string Id { get; set; }
        public JsonNullable<int?> MtgInsDisb { get; set; }
        public JsonNullable<bool?> MtgInsPrepaid { get; set; }
        public JsonNullable<int?> SchoolTaxes { get; set; }
        public JsonNullable<bool?> SchoolTaxesPrepaid { get; set; }
        public JsonNullable<int?> TaxDisb { get; set; }
        public JsonNullable<bool?> TaxPrepaid { get; set; }
        public JsonNullable<int?> UserDefined1 { get; set; }
        public JsonNullable<int?> UserDefined2 { get; set; }
        public JsonNullable<int?> UserDefined3 { get; set; }
        public JsonNullable<bool?> UserDefinedPrepaid1 { get; set; }
        public JsonNullable<bool?> UserDefinedPrepaid2 { get; set; }
        public JsonNullable<bool?> UserDefinedPrepaid3 { get; set; }
    }
}