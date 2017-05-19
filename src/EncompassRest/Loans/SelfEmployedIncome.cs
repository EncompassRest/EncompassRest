using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class SelfEmployedIncome
    {
        public string FormType { get; set; }
        public string FieldName { get; set; }
        public bool? BoolFieldValue { get; set; }
        public decimal? FirstYearAmount { get; set; }
        public decimal? FieldValue { get; set; }
        public decimal? SecondYearAmount { get; set; }
        public string BusinessName { get; set; }
        public string Id { get; set; }
    }
}