using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class SelfEmployedIncome
    {
        public JsonNullable<bool?> BoolFieldValue { get; set; }
        public string BusinessName { get; set; }
        public string FieldName { get; set; }
        public decimal? FieldValue { get; set; }
        public JsonNullable<decimal?> FirstYearAmount { get; set; }
        public string FormType { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> SecondYearAmount { get; set; }
    }
}