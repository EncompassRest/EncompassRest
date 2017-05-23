using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount
    {
        public JsonNullable<decimal?> Balance { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> Total1 { get; set; }
        public JsonNullable<decimal?> Total2 { get; set; }
        public JsonNullable<List<TrustAccountItem>> TrustAccountItems { get; set; }
    }
}