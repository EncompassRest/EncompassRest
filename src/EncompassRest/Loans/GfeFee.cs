using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class GfeFee
    {
        public string AmountDescription { get; set; }
        public JsonNullable<decimal?> BrokerAmount { get; set; }
        public string Description { get; set; }
        public int? GfeFeeIndex { get; set; }
        public string GfeFeeType { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> OtherAmount { get; set; }
        public string Rate { get; set; }
    }
}