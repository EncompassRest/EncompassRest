using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010WholePoc
    {
        public int? Gfe2010WholePocIndex { get; set; }
        public string Id { get; set; }
        public int? LineNumber { get; set; }
        public JsonNullable<decimal?> WholePoc { get; set; }
        public string WholePocPaidByType { get; set; }
    }
}