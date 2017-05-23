using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize
    {
        public string Date { get; set; }
        public JsonNullable<decimal?> EscrowPaymentBalance { get; set; }
        public string EscrowPaymentDescription { get; set; }
        public JsonNullable<decimal?> EscrowPaymentFrom { get; set; }
        public JsonNullable<decimal?> EscrowPaymentTo { get; set; }
        public int? Hud1EsItemizeIndex { get; set; }
        public string Id { get; set; }
    }
}