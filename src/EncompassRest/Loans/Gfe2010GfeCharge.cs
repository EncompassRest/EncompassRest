using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010GfeCharge
    {
        public JsonNullable<bool?> ChargeBelow10Indicator { get; set; }
        public string Description { get; set; }
        public int? Gfe2010GfeChargeIndex { get; set; }
        public JsonNullable<decimal?> GfeCharge { get; set; }
        public JsonNullable<decimal?> HudCharge { get; set; }
        public string Id { get; set; }
        public string Line { get; set; }
    }
}