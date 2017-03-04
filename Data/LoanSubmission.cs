using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class LoanSubmission
    {
        public decimal? amountAvailable { get; set; }
        public List<LoanSubmissionFee> loanSubmissionFees { get; set; }
        public bool? reducedDocsIndicator { get; set; }
        public decimal? totalDiscountPointCharged { get; set; }
        public string rateLock { get; set; }
        public int? numberOfDays { get; set; }
        public decimal? totalForDueLender { get; set; }
        public decimal? totalForDueBroker { get; set; }
        public decimal? total { get; set; }
        public string comments { get; set; }
        public decimal? amountRequiredToClose { get; set; }
        public DateTime? lockDate { get; set; }
        public DateTime? lockExpiresDate { get; set; }
        public string programCode { get; set; }
        public string buydownMonthsPerAdjustment { get; set; }
        public string buydownDescription { get; set; }
        public decimal? totalForPrimaryResidence { get; set; }
        public bool? taxesIndicator { get; set; }
        public bool? hazardIndicator { get; set; }
        public bool? mmmPmiIndicator { get; set; }
        public bool? floodIndicator { get; set; }
        public bool? otherIndicator { get; set; }
        public string otherDescription { get; set; }
        public DateTime? dateLastPaymentReceived { get; set; }
        public DateTime? lockDateTimestampUtc { get; set; }
        public DateTime? currentRateSetDate { get; set; }
        public DateTime? rateLockDisclosureDate { get; set; }
        public bool? isSecondaryRegistration { get; set; }
        public string id { get; set; }

    }
}
