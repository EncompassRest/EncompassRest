using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class NewYorkFee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Comments { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public string FeeType { get; set; }
        public string Id { get; set; }
        public int? NewYorkFeeIndex { get; set; }
    }
}