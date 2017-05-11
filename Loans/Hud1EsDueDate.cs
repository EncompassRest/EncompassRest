using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1EsDueDate
    {
        public DateTime? TaxDisb { get; set; }
        public DateTime? HazInsDisb { get; set; }
        public DateTime? MtgInsDisb { get; set; }
        public DateTime? FloodInsDisb { get; set; }
        public DateTime? SchoolTaxes { get; set; }
        public DateTime? UserDefined1 { get; set; }
        public DateTime? UserDefined2 { get; set; }
        public DateTime? UserDefined3 { get; set; }
        public DateTime? AnnualFee { get; set; }
        public string Id { get; set; }
        public int? Hud1EsDueDateIndex { get; set; }
    }
}