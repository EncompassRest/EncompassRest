using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Funding
    {
        public string FunderName { get; set; }
        public DateTime? SentToFunderDate { get; set; }
        public string FundingType { get; set; }
        public DateTime? FundingCloseDate { get; set; }
        public string FundingClearedBy { get; set; }
        public DateTime? FundingOrderDate { get; set; }
        public DateTime? FundsSentDate { get; set; }
        public DateTime? CollateralSentDate { get; set; }
        public DateTime? FundsReleasedDate { get; set; }
        public string FundsReleaseNumber { get; set; }
        public string FundsWireTo { get; set; }
        public string WiredToForCreditTo1 { get; set; }
        public string WiredToForCreditTo2 { get; set; }
        public string WiredToForFurtherCreditTo1 { get; set; }
        public string WiredToForFurtherCreditTo2 { get; set; }
        public string WiredToAbaNumber { get; set; }
        public string WiredToAccountNumber { get; set; }
        public string WiredToForCreditTo { get; set; }
        public string FunderUrl { get; set; }
        public string FundingFees { get; set; }
        public string Id { get; set; }
    }
}