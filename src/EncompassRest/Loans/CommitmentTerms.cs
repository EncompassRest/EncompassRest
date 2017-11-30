using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class CommitmentTerms : ExtensibleObject
    {
        private DirtyValue<DateTime?> _actionDate;
        public DateTime? ActionDate { get => _actionDate; set => _actionDate = value; }
        private DirtyValue<string> _additionalConditions;
        public string AdditionalConditions { get => _additionalConditions; set => _additionalConditions = value; }
        private DirtyValue<string> _additionalItems1;
        public string AdditionalItems1 { get => _additionalItems1; set => _additionalItems1 = value; }
        private DirtyValue<string> _additionalItems2;
        public string AdditionalItems2 { get => _additionalItems2; set => _additionalItems2 = value; }
        private DirtyValue<string> _additionalItems3;
        public string AdditionalItems3 { get => _additionalItems3; set => _additionalItems3 = value; }
        private DirtyValue<bool?> _appraisalDone;
        public bool? AppraisalDone { get => _appraisalDone; set => _appraisalDone = value; }
        private DirtyValue<decimal?> _assuranceOfCompletion;
        public decimal? AssuranceOfCompletion { get => _assuranceOfCompletion; set => _assuranceOfCompletion = value; }
        private DirtyValue<DateTime?> _commitmentDate;
        public DateTime? CommitmentDate { get => _commitmentDate; set => _commitmentDate = value; }
        private DirtyValue<DateTime?> _commitmentExpired;
        public DateTime? CommitmentExpired { get => _commitmentExpired; set => _commitmentExpired = value; }
        private DirtyValue<DateTime?> _commitmentIssued;
        public DateTime? CommitmentIssued { get => _commitmentIssued; set => _commitmentIssued = value; }
        private DirtyValue<bool?> _conditionalCommitmentUnderActg;
        public bool? ConditionalCommitmentUnderActg { get => _conditionalCommitmentUnderActg; set => _conditionalCommitmentUnderActg = value; }
        private DirtyValue<bool?> _eligibleForHighLtv;
        public bool? EligibleForHighLtv { get => _eligibleForHighLtv; set => _eligibleForHighLtv = value; }
        private DirtyValue<int?> _estimatedRemainingYears;
        public int? EstimatedRemainingYears { get => _estimatedRemainingYears; set => _estimatedRemainingYears = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _improvedLivingAreas;
        public string ImprovedLivingAreas { get => _improvedLivingAreas; set => _improvedLivingAreas = value; }
        private DirtyValue<bool?> _manufacturedHousing;
        public bool? ManufacturedHousing { get => _manufacturedHousing; set => _manufacturedHousing = value; }
        private DirtyValue<decimal?> _maxInsurableMortgage;
        public decimal? MaxInsurableMortgage { get => _maxInsurableMortgage; set => _maxInsurableMortgage = value; }
        private DirtyValue<string> _mortgageeAddress;
        public string MortgageeAddress { get => _mortgageeAddress; set => _mortgageeAddress = value; }
        private DirtyValue<string> _mortgageeCity;
        public string MortgageeCity { get => _mortgageeCity; set => _mortgageeCity = value; }
        private DirtyValue<string> _mortgageeName;
        public string MortgageeName { get => _mortgageeName; set => _mortgageeName = value; }
        private DirtyValue<string> _mortgageePostalCode;
        public string MortgageePostalCode { get => _mortgageePostalCode; set => _mortgageePostalCode = value; }
        private DirtyValue<string> _mortgageeState;
        public string MortgageeState { get => _mortgageeState; set => _mortgageeState = value; }
        private DirtyValue<string> _otherMonthlyExpenseDescription;
        public string OtherMonthlyExpenseDescription { get => _otherMonthlyExpenseDescription; set => _otherMonthlyExpenseDescription = value; }
        private DirtyValue<DateTime?> _reportDate;
        public DateTime? ReportDate { get => _reportDate; set => _reportDate = value; }
        private DirtyValue<string> _requirementsNumber;
        public string RequirementsNumber { get => _requirementsNumber; set => _requirementsNumber = value; }
        private DirtyValue<string> _subdivisionDescription;
        public string SubdivisionDescription { get => _subdivisionDescription; set => _subdivisionDescription = value; }
        private DirtyValue<string> _subdivisionRequirements;
        public string SubdivisionRequirements { get => _subdivisionRequirements; set => _subdivisionRequirements = value; }
        private DirtyValue<decimal?> _totalMonthlyExpense;
        public decimal? TotalMonthlyExpense { get => _totalMonthlyExpense; set => _totalMonthlyExpense = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _actionDate.Dirty
                    || _additionalConditions.Dirty
                    || _additionalItems1.Dirty
                    || _additionalItems2.Dirty
                    || _additionalItems3.Dirty
                    || _appraisalDone.Dirty
                    || _assuranceOfCompletion.Dirty
                    || _commitmentDate.Dirty
                    || _commitmentExpired.Dirty
                    || _commitmentIssued.Dirty
                    || _conditionalCommitmentUnderActg.Dirty
                    || _eligibleForHighLtv.Dirty
                    || _estimatedRemainingYears.Dirty
                    || _id.Dirty
                    || _improvedLivingAreas.Dirty
                    || _manufacturedHousing.Dirty
                    || _maxInsurableMortgage.Dirty
                    || _mortgageeAddress.Dirty
                    || _mortgageeCity.Dirty
                    || _mortgageeName.Dirty
                    || _mortgageePostalCode.Dirty
                    || _mortgageeState.Dirty
                    || _otherMonthlyExpenseDescription.Dirty
                    || _reportDate.Dirty
                    || _requirementsNumber.Dirty
                    || _subdivisionDescription.Dirty
                    || _subdivisionRequirements.Dirty
                    || _totalMonthlyExpense.Dirty;
            }
            set
            {
                _actionDate.Dirty = value;
                _additionalConditions.Dirty = value;
                _additionalItems1.Dirty = value;
                _additionalItems2.Dirty = value;
                _additionalItems3.Dirty = value;
                _appraisalDone.Dirty = value;
                _assuranceOfCompletion.Dirty = value;
                _commitmentDate.Dirty = value;
                _commitmentExpired.Dirty = value;
                _commitmentIssued.Dirty = value;
                _conditionalCommitmentUnderActg.Dirty = value;
                _eligibleForHighLtv.Dirty = value;
                _estimatedRemainingYears.Dirty = value;
                _id.Dirty = value;
                _improvedLivingAreas.Dirty = value;
                _manufacturedHousing.Dirty = value;
                _maxInsurableMortgage.Dirty = value;
                _mortgageeAddress.Dirty = value;
                _mortgageeCity.Dirty = value;
                _mortgageeName.Dirty = value;
                _mortgageePostalCode.Dirty = value;
                _mortgageeState.Dirty = value;
                _otherMonthlyExpenseDescription.Dirty = value;
                _reportDate.Dirty = value;
                _requirementsNumber.Dirty = value;
                _subdivisionDescription.Dirty = value;
                _subdivisionRequirements.Dirty = value;
                _totalMonthlyExpense.Dirty = value;
            }
        }
    }
}