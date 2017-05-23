using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class RespaHudDetail
    {
        public string CreditDebt { get; set; }
        public string FWBC { get; set; }
        public JsonNullable<DateTime?> HUD1LineItemFromDate { get; set; }
        public JsonNullable<DateTime?> HUD1LineItemToDate { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> LineItemAmount { get; set; }
        public string LineItemDescription { get; set; }
        public int? LineNumber { get; set; }
        public JsonNullable<decimal?> RealValue { get; set; }
    }
}