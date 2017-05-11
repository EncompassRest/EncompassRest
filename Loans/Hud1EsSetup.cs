using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1EsSetup
    {
        public string Date { get; set; }
        public int? TaxDisb { get; set; }
        public int? HazInsDisb { get; set; }
        public int? MtgInsDisb { get; set; }
        public int? FloodInsDisb { get; set; }
        public int? SchoolTaxes { get; set; }
        public int? UserDefined1 { get; set; }
        public int? UserDefined2 { get; set; }
        public int? UserDefined3 { get; set; }
        public int? AnnualFees { get; set; }
        public bool? TaxPrepaid { get; set; }
        public bool? HazInsPrepaid { get; set; }
        public bool? MtgInsPrepaid { get; set; }
        public bool? FloodInsPrepaid { get; set; }
        public bool? SchoolTaxesPrepaid { get; set; }
        public bool? UserDefinedPrepaid1 { get; set; }
        public bool? UserDefinedPrepaid2 { get; set; }
        public bool? UserDefinedPrepaid3 { get; set; }
        public bool? AnnualFeePrepaid { get; set; }
        public string Id { get; set; }
        public int? Hud1EsSetupIndex { get; set; }
    }
}