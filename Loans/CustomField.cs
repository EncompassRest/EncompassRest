using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class CustomField
    {
        public string StringValue { get; set; }
        public string Id { get; set; }
        public DateTime? DateValue { get; set; }
        public string FieldName { get; set; }
        public decimal? NumericValue { get; set; }
    }
}