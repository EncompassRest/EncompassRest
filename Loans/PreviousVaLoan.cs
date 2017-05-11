using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class PreviousVaLoan
    {
        public int? PreviousVaLoanIndex { get; set; }
        public string LoanType { get; set; }
        public string PropertyAddress { get; set; }
        public DateTime? DateOfLoan { get; set; }
        public bool? PropertyOwned { get; set; }
        public DateTime? DateSold { get; set; }
        public string VALoanNumber { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyPostalCode { get; set; }
        public string Id { get; set; }
    }
}