using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class GfeLien
    {
        public JsonNullable<decimal?> AmountOwing { get; set; }
        public int? GfeLienIndex { get; set; }
        public string GfeLienType { get; set; }
        public string HolderName { get; set; }
        public string Id { get; set; }
        public string Priority { get; set; }
    }
}