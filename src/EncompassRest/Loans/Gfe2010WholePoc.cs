using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Gfe2010WholePoc
    {
        public int? LineNumber { get; set; }
        public int? Gfe2010WholePocIndex { get; set; }
        public decimal? WholePoc { get; set; }
        public string WholePocPaidByType { get; set; }
        public string Id { get; set; }
    }
}