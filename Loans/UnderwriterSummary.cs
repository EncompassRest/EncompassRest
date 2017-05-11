using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class UnderwriterSummary
    {
        public DateTime? SubmittedDate { get; set; }
        public DateTime? ResubmittedDate { get; set; }
        public DateTime? CreditApprovalDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? ApprovalExpiredDate { get; set; }
        public DateTime? SuspendedDate { get; set; }
        public DateTime? SignOffDate { get; set; }
        public DateTime? ClearToCloseDate { get; set; }
        public DateTime? MiOrderedDate { get; set; }
        public DateTime? MiReceivedDate { get; set; }
        public decimal? MaxRate { get; set; }
        public string SuspendedReasons { get; set; }
        public string AusSource { get; set; }
        public DateTime? AusRunDate { get; set; }
        public string SignOffBy { get; set; }
        public string AusNumber { get; set; }
        public DateTime? ExceptionSignOffDate { get; set; }
        public string ExceptionSignOffBy { get; set; }
        public string Strengths { get; set; }
        public string Concerns { get; set; }
        public string Credit { get; set; }
        public string Appraisal { get; set; }
        public string Exceptions { get; set; }
        public string OriginalAppraiser { get; set; }
        public DateTime? AppraisalOrderedDate { get; set; }
        public DateTime? AppraisalCompletedDate { get; set; }
        public DateTime? AppraisalExpiredDate { get; set; }
        public decimal? OriginalAppraisersValue { get; set; }
        public string AppraisalType { get; set; }
        public string ReviewAppraiser { get; set; }
        public string ReviewType { get; set; }
        public DateTime? ReviewRequestedDate { get; set; }
        public DateTime? ReviewCompletedDate { get; set; }
        public decimal? ReviewValue { get; set; }
        public string Conditions { get; set; }
        public DateTime? SentToDate { get; set; }
        public bool? BenefitRequiredIndicator { get; set; }
        public string ApprovedBy { get; set; }
        public string SuspendedBy { get; set; }
        public string DeniedBy { get; set; }
        public DateTime? DeniedDate { get; set; }
        public string DifferentApprovedBy { get; set; }
        public DateTime? DifferentApprovedDate { get; set; }
        public DateTime? DifferentApprovalExpiredDate { get; set; }
        public decimal? ModifiedLoanAmount { get; set; }
        public decimal? ModifiedLoanRate { get; set; }
        public int? ModifiedLoanTerm { get; set; }
        public decimal? ModifiedMonthlyPayment { get; set; }
        public decimal? ModifiedLtv { get; set; }
        public bool? IsAgencyWithAgreement { get; set; }
        public bool? IsAgencyWaiver { get; set; }
        public bool? IsAgencyManually { get; set; }
        public string SupervisoryAppraiserLicenseNumber { get; set; }
        public string Id { get; set; }
    }
}