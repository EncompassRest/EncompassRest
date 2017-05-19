using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class RespaHudDetail
    {
        public int? LineNumber { get; set; }
        public decimal? LineItemAmount { get; set; }
        public DateTime? HUD1LineItemFromDate { get; set; }
        public DateTime? HUD1LineItemToDate { get; set; }
        public string LineItemDescription { get; set; }
        public decimal? RealValue { get; set; }
        public string CreditDebt { get; set; }
        public string FWBC { get; set; }
        public string Id { get; set; }
    }
}