using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Gfe2010GfeCharge
    {
        public bool? ChargeBelow10Indicator { get; set; }
        public int? Gfe2010GfeChargeIndex { get; set; }
        public string Description { get; set; }
        public string Line { get; set; }
        public decimal? GfeCharge { get; set; }
        public decimal? HudCharge { get; set; }
        public string Id { get; set; }
    }
}