using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class CommitmentTerms
    {
        public bool? ManufacturedHousing { get; set; }
        public decimal? AssuranceOfCompletion { get; set; }
        public string AdditionalItems1 { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime? CommitmentIssued { get; set; }
        public string OtherMonthlyExpenseDescription { get; set; }
        public DateTime? CommitmentExpired { get; set; }
        public decimal? TotalMonthlyExpense { get; set; }
        public string SubdivisionRequirements { get; set; }
        public string RequirementsNumber { get; set; }
        public DateTime? ReportDate { get; set; }
        public string SubdivisionDescription { get; set; }
        public decimal? MaxInsurableMortgage { get; set; }
        public string AdditionalItems2 { get; set; }
        public string ImprovedLivingAreas { get; set; }
        public bool? ConditionalCommitmentUnderActg { get; set; }
        public int? EstimatedRemainingYears { get; set; }
        public string AdditionalItems3 { get; set; }
        public string AdditionalConditions { get; set; }
        public bool? EligibleForHighLtv { get; set; }
        public bool? AppraisalDone { get; set; }
        public DateTime? CommitmentDate { get; set; }
        public string MortgageeName { get; set; }
        public string MortgageeAddress { get; set; }
        public string MortgageeCity { get; set; }
        public string MortgageeState { get; set; }
        public string MortgageePostalCode { get; set; }
        public string Id { get; set; }
    }
}