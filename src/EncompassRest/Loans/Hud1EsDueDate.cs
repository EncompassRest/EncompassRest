using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsDueDate
    {
        public JsonNullable<DateTime?> AnnualFee { get; set; }
        public JsonNullable<DateTime?> FloodInsDisb { get; set; }
        public JsonNullable<DateTime?> HazInsDisb { get; set; }
        public int? Hud1EsDueDateIndex { get; set; }
        public string Id { get; set; }
        public JsonNullable<DateTime?> MtgInsDisb { get; set; }
        public JsonNullable<DateTime?> SchoolTaxes { get; set; }
        public JsonNullable<DateTime?> TaxDisb { get; set; }
        public JsonNullable<DateTime?> UserDefined1 { get; set; }
        public JsonNullable<DateTime?> UserDefined2 { get; set; }
        public JsonNullable<DateTime?> UserDefined3 { get; set; }
    }
}