using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Income
    {
        public JsonNullable<decimal?> Amount { get; set; }
        public bool? CurrentIndicator { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string IncomeType { get; set; }
        public int? OtherIncomeIndex { get; set; }
        public string Owner { get; set; }
    }
}