using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Income
    {
        public string Owner { get; set; }
        public string IncomeType { get; set; }
        public decimal? Amount { get; set; }
        public int? OtherIncomeIndex { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public bool? CurrentIndicator { get; set; }
    }
}