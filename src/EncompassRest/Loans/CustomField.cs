using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class CustomField
    {
        public JsonNullable<DateTime?> DateValue { get; set; }
        public string FieldName { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> NumericValue { get; set; }
        public string StringValue { get; set; }
    }
}