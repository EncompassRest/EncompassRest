using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDate
    {
        public JsonNullable<decimal?> AggrMthDisb { get; set; }
        public JsonNullable<decimal?> AnnualFee { get; set; }
        public JsonNullable<decimal?> Balance { get; set; }
        public string Date { get; set; }
        public JsonNullable<decimal?> FloodInsDisb { get; set; }
        public JsonNullable<decimal?> HazInsDisb { get; set; }
        public int? Hud1EsDateIndex { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> MtgInsDisb { get; set; }
        public JsonNullable<decimal?> SchoolTaxes { get; set; }
        public JsonNullable<decimal?> TaxDisb { get; set; }
        public JsonNullable<decimal?> UserDefined1 { get; set; }
        public JsonNullable<decimal?> UserDefined2 { get; set; }
        public JsonNullable<decimal?> UserDefined3 { get; set; }
    }
}