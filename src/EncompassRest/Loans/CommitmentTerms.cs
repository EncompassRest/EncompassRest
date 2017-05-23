using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class CommitmentTerms
    {
        public JsonNullable<DateTime?> ActionDate { get; set; }
        public string AdditionalConditions { get; set; }
        public string AdditionalItems1 { get; set; }
        public string AdditionalItems2 { get; set; }
        public string AdditionalItems3 { get; set; }
        public JsonNullable<bool?> AppraisalDone { get; set; }
        public JsonNullable<decimal?> AssuranceOfCompletion { get; set; }
        public JsonNullable<DateTime?> CommitmentDate { get; set; }
        public JsonNullable<DateTime?> CommitmentExpired { get; set; }
        public JsonNullable<DateTime?> CommitmentIssued { get; set; }
        public JsonNullable<bool?> ConditionalCommitmentUnderActg { get; set; }
        public JsonNullable<bool?> EligibleForHighLtv { get; set; }
        public JsonNullable<int?> EstimatedRemainingYears { get; set; }
        public string Id { get; set; }
        public string ImprovedLivingAreas { get; set; }
        public JsonNullable<bool?> ManufacturedHousing { get; set; }
        public JsonNullable<decimal?> MaxInsurableMortgage { get; set; }
        public string MortgageeAddress { get; set; }
        public string MortgageeCity { get; set; }
        public string MortgageeName { get; set; }
        public string MortgageePostalCode { get; set; }
        public string MortgageeState { get; set; }
        public string OtherMonthlyExpenseDescription { get; set; }
        public JsonNullable<DateTime?> ReportDate { get; set; }
        public string RequirementsNumber { get; set; }
        public string SubdivisionDescription { get; set; }
        public string SubdivisionRequirements { get; set; }
        public JsonNullable<decimal?> TotalMonthlyExpense { get; set; }
    }
}