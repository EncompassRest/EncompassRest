using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class NewYorkFee
    {
        public string Address { get; set; }
        public JsonNullable<decimal?> Amount { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public JsonNullable<DateTime?> Date { get; set; }
        public string FeeType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public int? NewYorkFeeIndex { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
    }
}