using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Funding
    {
        public JsonNullable<DateTime?> CollateralSentDate { get; set; }
        public string FunderName { get; set; }
        public string FunderUrl { get; set; }
        public string FundingClearedBy { get; set; }
        public JsonNullable<DateTime?> FundingCloseDate { get; set; }
        public string FundingFees { get; set; }
        public JsonNullable<DateTime?> FundingOrderDate { get; set; }
        public string FundingType { get; set; }
        public JsonNullable<DateTime?> FundsReleasedDate { get; set; }
        public string FundsReleaseNumber { get; set; }
        public JsonNullable<DateTime?> FundsSentDate { get; set; }
        public string FundsWireTo { get; set; }
        public string Id { get; set; }
        public JsonNullable<DateTime?> SentToFunderDate { get; set; }
        public string WiredToAbaNumber { get; set; }
        public string WiredToAccountNumber { get; set; }
        public string WiredToForCreditTo { get; set; }
        public string WiredToForCreditTo1 { get; set; }
        public string WiredToForCreditTo2 { get; set; }
        public string WiredToForFurtherCreditTo1 { get; set; }
        public string WiredToForFurtherCreditTo2 { get; set; }
    }
}