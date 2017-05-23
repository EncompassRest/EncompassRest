using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwriterSummary
    {
        public string Appraisal { get; set; }
        public JsonNullable<DateTime?> AppraisalCompletedDate { get; set; }
        public JsonNullable<DateTime?> AppraisalExpiredDate { get; set; }
        public JsonNullable<DateTime?> AppraisalOrderedDate { get; set; }
        public string AppraisalType { get; set; }
        public JsonNullable<DateTime?> ApprovalExpiredDate { get; set; }
        public string ApprovedBy { get; set; }
        public JsonNullable<DateTime?> ApprovedDate { get; set; }
        public string AusNumber { get; set; }
        public JsonNullable<DateTime?> AusRunDate { get; set; }
        public string AusSource { get; set; }
        public JsonNullable<bool?> BenefitRequiredIndicator { get; set; }
        public JsonNullable<DateTime?> ClearToCloseDate { get; set; }
        public string Concerns { get; set; }
        public string Conditions { get; set; }
        public string Credit { get; set; }
        public JsonNullable<DateTime?> CreditApprovalDate { get; set; }
        public string DeniedBy { get; set; }
        public JsonNullable<DateTime?> DeniedDate { get; set; }
        public JsonNullable<DateTime?> DifferentApprovalExpiredDate { get; set; }
        public string DifferentApprovedBy { get; set; }
        public JsonNullable<DateTime?> DifferentApprovedDate { get; set; }
        public string Exceptions { get; set; }
        public string ExceptionSignOffBy { get; set; }
        public JsonNullable<DateTime?> ExceptionSignOffDate { get; set; }
        public string Id { get; set; }
        public JsonNullable<bool?> IsAgencyManually { get; set; }
        public JsonNullable<bool?> IsAgencyWaiver { get; set; }
        public JsonNullable<bool?> IsAgencyWithAgreement { get; set; }
        public JsonNullable<decimal?> MaxRate { get; set; }
        public JsonNullable<DateTime?> MiOrderedDate { get; set; }
        public JsonNullable<DateTime?> MiReceivedDate { get; set; }
        public JsonNullable<decimal?> ModifiedLoanAmount { get; set; }
        public JsonNullable<decimal?> ModifiedLoanRate { get; set; }
        public JsonNullable<int?> ModifiedLoanTerm { get; set; }
        public JsonNullable<decimal?> ModifiedLtv { get; set; }
        public JsonNullable<decimal?> ModifiedMonthlyPayment { get; set; }
        public string OriginalAppraiser { get; set; }
        public JsonNullable<decimal?> OriginalAppraisersValue { get; set; }
        public JsonNullable<DateTime?> ResubmittedDate { get; set; }
        public string ReviewAppraiser { get; set; }
        public JsonNullable<DateTime?> ReviewCompletedDate { get; set; }
        public JsonNullable<DateTime?> ReviewRequestedDate { get; set; }
        public string ReviewType { get; set; }
        public JsonNullable<decimal?> ReviewValue { get; set; }
        public JsonNullable<DateTime?> SentToDate { get; set; }
        public string SignOffBy { get; set; }
        public JsonNullable<DateTime?> SignOffDate { get; set; }
        public string Strengths { get; set; }
        public JsonNullable<DateTime?> SubmittedDate { get; set; }
        public string SupervisoryAppraiserLicenseNumber { get; set; }
        public string SuspendedBy { get; set; }
        public JsonNullable<DateTime?> SuspendedDate { get; set; }
        public string SuspendedReasons { get; set; }
    }
}