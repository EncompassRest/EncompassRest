using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1EsDate
    {
        public string Date { get; set; }
        public decimal? TaxDisb { get; set; }
        public decimal? HazInsDisb { get; set; }
        public decimal? MtgInsDisb { get; set; }
        public decimal? FloodInsDisb { get; set; }
        public decimal? SchoolTaxes { get; set; }
        public decimal? UserDefined1 { get; set; }
        public decimal? UserDefined2 { get; set; }
        public decimal? UserDefined3 { get; set; }
        public decimal? AnnualFee { get; set; }
        public decimal? AggrMthDisb { get; set; }
        public decimal? Balance { get; set; }
        public string Id { get; set; }
        public int? Hud1EsDateIndex { get; set; }
    }
}