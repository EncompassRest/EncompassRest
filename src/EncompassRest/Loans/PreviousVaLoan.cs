using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class PreviousVaLoan
    {
        public JsonNullable<DateTime?> DateOfLoan { get; set; }
        public JsonNullable<DateTime?> DateSold { get; set; }
        public string Id { get; set; }
        public string LoanType { get; set; }
        public int? PreviousVaLoanIndex { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public JsonNullable<bool?> PropertyOwned { get; set; }
        public string PropertyPostalCode { get; set; }
        public string PropertyState { get; set; }
        public string VALoanNumber { get; set; }
    }
}