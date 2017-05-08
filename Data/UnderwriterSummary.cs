using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class UnderwriterSummary
    {
        public DateTime? submittedDate { get; set; }
        public DateTime? resubmittedDate { get; set; }
        public DateTime? creditApprovalDate { get; set; }
        public DateTime? approvedDate { get; set; }
        public DateTime? approvalExpiredDate { get; set; }
        public DateTime? suspendedDate { get; set; }
        public DateTime? signOffDate { get; set; }
        public DateTime? clearToCloseDate { get; set; }
        public DateTime? miOrderedDate { get; set; }
        public DateTime? miReceivedDate { get; set; }
        public decimal? maxRate { get; set; }
        public string suspendedReasons { get; set; }
        public string ausSource { get; set; }
        public DateTime? ausRunDate { get; set; }
        public string signOffBy { get; set; }
        public string ausNumber { get; set; }
        public DateTime? exceptionSignOffDate { get; set; }
        public string exceptionSignOffBy { get; set; }
        public string strengths { get; set; }
        public string concerns { get; set; }
        public string credit { get; set; }
        public string appraisal { get; set; }
        public string exceptions { get; set; }
        public string originalAppraiser { get; set; }
        public DateTime? appraisalOrderedDate { get; set; }
        public DateTime? appraisalCompletedDate { get; set; }
        public DateTime? appraisalExpiredDate { get; set; }
        public decimal? originalAppraisersValue { get; set; }
        public string appraisalType { get; set; }
        public string reviewAppraiser { get; set; }
        public string reviewType { get; set; }
        public DateTime? reviewRequestedDate { get; set; }
        public DateTime? reviewCompletedDate { get; set; }
        public decimal? reviewValue { get; set; }
        public string conditions { get; set; }
        public DateTime? sentToDate { get; set; }
        public bool? benefitRequiredIndicator { get; set; }
        public string approvedBy { get; set; }
        public string suspendedBy { get; set; }
        public string deniedBy { get; set; }
        public DateTime? deniedDate { get; set; }
        public string differentApprovedBy { get; set; }
        public DateTime? differentApprovedDate { get; set; }
        public DateTime? differentApprovalExpiredDate { get; set; }
        public decimal? modifiedLoanAmount { get; set; }
        public decimal? modifiedLoanRate { get; set; }
        public int? modifiedLoanTerm { get; set; }
        public decimal? modifiedMonthlyPayment { get; set; }
        public decimal? modifiedLtv { get; set; }
        public bool? isAgencyWithAgreement { get; set; }
        public bool? isAgencyWaiver { get; set; }
        public bool? isAgencyManually { get; set; }
        public string supervisoryAppraiserLicenseNumber { get; set; }
        public string id { get; set; }

    }
}
