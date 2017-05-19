using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Hud1EsItemize
    {
        public string Date { get; set; }
        public decimal? EscrowPaymentTo { get; set; }
        public decimal? EscrowPaymentFrom { get; set; }
        public string EscrowPaymentDescription { get; set; }
        public decimal? EscrowPaymentBalance { get; set; }
        public string Id { get; set; }
        public int? Hud1EsItemizeIndex { get; set; }
    }
}