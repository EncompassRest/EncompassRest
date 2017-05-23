using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ProfitManagementItem
    {
        public JsonNullable<decimal?> AtPercent { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> PlusAmount { get; set; }
        public int? ProfitManagementItemIndex { get; set; }
        public JsonNullable<decimal?> Total { get; set; }
        public string Type { get; set; }
    }
}