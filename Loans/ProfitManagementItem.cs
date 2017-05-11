using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ProfitManagementItem
    {
        public int? ProfitManagementItemIndex { get; set; }
        public decimal? AtPercent { get; set; }
        public string Type { get; set; }
        public decimal? PlusAmount { get; set; }
        public decimal? Total { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
    }
}