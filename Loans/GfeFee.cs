using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class GfeFee
    {
        public string GfeFeeType { get; set; }
        public int? GfeFeeIndex { get; set; }
        public string Description { get; set; }
        public string AmountDescription { get; set; }
        public decimal? BrokerAmount { get; set; }
        public string Rate { get; set; }
        public decimal? OtherAmount { get; set; }
        public string Id { get; set; }
    }
}