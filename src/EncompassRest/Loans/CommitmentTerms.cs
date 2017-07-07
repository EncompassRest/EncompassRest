using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class CommitmentTerms : IClean
    {
        private Value<DateTime?> _actionDate;
        public DateTime? ActionDate { get { return _actionDate; } set { _actionDate = value; } }
        private Value<string> _additionalConditions;
        public string AdditionalConditions { get { return _additionalConditions; } set { _additionalConditions = value; } }
        private Value<string> _additionalItems1;
        public string AdditionalItems1 { get { return _additionalItems1; } set { _additionalItems1 = value; } }
        private Value<string> _additionalItems2;
        public string AdditionalItems2 { get { return _additionalItems2; } set { _additionalItems2 = value; } }
        private Value<string> _additionalItems3;
        public string AdditionalItems3 { get { return _additionalItems3; } set { _additionalItems3 = value; } }
        private Value<bool?> _appraisalDone;
        public bool? AppraisalDone { get { return _appraisalDone; } set { _appraisalDone = value; } }
        private Value<decimal?> _assuranceOfCompletion;
        public decimal? AssuranceOfCompletion { get { return _assuranceOfCompletion; } set { _assuranceOfCompletion = value; } }
        private Value<DateTime?> _commitmentDate;
        public DateTime? CommitmentDate { get { return _commitmentDate; } set { _commitmentDate = value; } }
        private Value<DateTime?> _commitmentExpired;
        public DateTime? CommitmentExpired { get { return _commitmentExpired; } set { _commitmentExpired = value; } }
        private Value<DateTime?> _commitmentIssued;
        public DateTime? CommitmentIssued { get { return _commitmentIssued; } set { _commitmentIssued = value; } }
        private Value<bool?> _conditionalCommitmentUnderActg;
        public bool? ConditionalCommitmentUnderActg { get { return _conditionalCommitmentUnderActg; } set { _conditionalCommitmentUnderActg = value; } }
        private Value<bool?> _eligibleForHighLtv;
        public bool? EligibleForHighLtv { get { return _eligibleForHighLtv; } set { _eligibleForHighLtv = value; } }
        private Value<int?> _estimatedRemainingYears;
        public int? EstimatedRemainingYears { get { return _estimatedRemainingYears; } set { _estimatedRemainingYears = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _improvedLivingAreas;
        public string ImprovedLivingAreas { get { return _improvedLivingAreas; } set { _improvedLivingAreas = value; } }
        private Value<bool?> _manufacturedHousing;
        public bool? ManufacturedHousing { get { return _manufacturedHousing; } set { _manufacturedHousing = value; } }
        private Value<decimal?> _maxInsurableMortgage;
        public decimal? MaxInsurableMortgage { get { return _maxInsurableMortgage; } set { _maxInsurableMortgage = value; } }
        private Value<string> _mortgageeAddress;
        public string MortgageeAddress { get { return _mortgageeAddress; } set { _mortgageeAddress = value; } }
        private Value<string> _mortgageeCity;
        public string MortgageeCity { get { return _mortgageeCity; } set { _mortgageeCity = value; } }
        private Value<string> _mortgageeName;
        public string MortgageeName { get { return _mortgageeName; } set { _mortgageeName = value; } }
        private Value<string> _mortgageePostalCode;
        public string MortgageePostalCode { get { return _mortgageePostalCode; } set { _mortgageePostalCode = value; } }
        private Value<string> _mortgageeState;
        public string MortgageeState { get { return _mortgageeState; } set { _mortgageeState = value; } }
        private Value<string> _otherMonthlyExpenseDescription;
        public string OtherMonthlyExpenseDescription { get { return _otherMonthlyExpenseDescription; } set { _otherMonthlyExpenseDescription = value; } }
        private Value<DateTime?> _reportDate;
        public DateTime? ReportDate { get { return _reportDate; } set { _reportDate = value; } }
        private Value<string> _requirementsNumber;
        public string RequirementsNumber { get { return _requirementsNumber; } set { _requirementsNumber = value; } }
        private Value<string> _subdivisionDescription;
        public string SubdivisionDescription { get { return _subdivisionDescription; } set { _subdivisionDescription = value; } }
        private Value<string> _subdivisionRequirements;
        public string SubdivisionRequirements { get { return _subdivisionRequirements; } set { _subdivisionRequirements = value; } }
        private Value<decimal?> _totalMonthlyExpense;
        public decimal? TotalMonthlyExpense { get { return _totalMonthlyExpense; } set { _totalMonthlyExpense = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actionDate.Clean
                    && _additionalConditions.Clean
                    && _additionalItems1.Clean
                    && _additionalItems2.Clean
                    && _additionalItems3.Clean
                    && _appraisalDone.Clean
                    && _assuranceOfCompletion.Clean
                    && _commitmentDate.Clean
                    && _commitmentExpired.Clean
                    && _commitmentIssued.Clean
                    && _conditionalCommitmentUnderActg.Clean
                    && _eligibleForHighLtv.Clean
                    && _estimatedRemainingYears.Clean
                    && _id.Clean
                    && _improvedLivingAreas.Clean
                    && _manufacturedHousing.Clean
                    && _maxInsurableMortgage.Clean
                    && _mortgageeAddress.Clean
                    && _mortgageeCity.Clean
                    && _mortgageeName.Clean
                    && _mortgageePostalCode.Clean
                    && _mortgageeState.Clean
                    && _otherMonthlyExpenseDescription.Clean
                    && _reportDate.Clean
                    && _requirementsNumber.Clean
                    && _subdivisionDescription.Clean
                    && _subdivisionRequirements.Clean
                    && _totalMonthlyExpense.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var actionDate = _actionDate; actionDate.Clean = value; _actionDate = actionDate;
                var additionalConditions = _additionalConditions; additionalConditions.Clean = value; _additionalConditions = additionalConditions;
                var additionalItems1 = _additionalItems1; additionalItems1.Clean = value; _additionalItems1 = additionalItems1;
                var additionalItems2 = _additionalItems2; additionalItems2.Clean = value; _additionalItems2 = additionalItems2;
                var additionalItems3 = _additionalItems3; additionalItems3.Clean = value; _additionalItems3 = additionalItems3;
                var appraisalDone = _appraisalDone; appraisalDone.Clean = value; _appraisalDone = appraisalDone;
                var assuranceOfCompletion = _assuranceOfCompletion; assuranceOfCompletion.Clean = value; _assuranceOfCompletion = assuranceOfCompletion;
                var commitmentDate = _commitmentDate; commitmentDate.Clean = value; _commitmentDate = commitmentDate;
                var commitmentExpired = _commitmentExpired; commitmentExpired.Clean = value; _commitmentExpired = commitmentExpired;
                var commitmentIssued = _commitmentIssued; commitmentIssued.Clean = value; _commitmentIssued = commitmentIssued;
                var conditionalCommitmentUnderActg = _conditionalCommitmentUnderActg; conditionalCommitmentUnderActg.Clean = value; _conditionalCommitmentUnderActg = conditionalCommitmentUnderActg;
                var eligibleForHighLtv = _eligibleForHighLtv; eligibleForHighLtv.Clean = value; _eligibleForHighLtv = eligibleForHighLtv;
                var estimatedRemainingYears = _estimatedRemainingYears; estimatedRemainingYears.Clean = value; _estimatedRemainingYears = estimatedRemainingYears;
                var id = _id; id.Clean = value; _id = id;
                var improvedLivingAreas = _improvedLivingAreas; improvedLivingAreas.Clean = value; _improvedLivingAreas = improvedLivingAreas;
                var manufacturedHousing = _manufacturedHousing; manufacturedHousing.Clean = value; _manufacturedHousing = manufacturedHousing;
                var maxInsurableMortgage = _maxInsurableMortgage; maxInsurableMortgage.Clean = value; _maxInsurableMortgage = maxInsurableMortgage;
                var mortgageeAddress = _mortgageeAddress; mortgageeAddress.Clean = value; _mortgageeAddress = mortgageeAddress;
                var mortgageeCity = _mortgageeCity; mortgageeCity.Clean = value; _mortgageeCity = mortgageeCity;
                var mortgageeName = _mortgageeName; mortgageeName.Clean = value; _mortgageeName = mortgageeName;
                var mortgageePostalCode = _mortgageePostalCode; mortgageePostalCode.Clean = value; _mortgageePostalCode = mortgageePostalCode;
                var mortgageeState = _mortgageeState; mortgageeState.Clean = value; _mortgageeState = mortgageeState;
                var otherMonthlyExpenseDescription = _otherMonthlyExpenseDescription; otherMonthlyExpenseDescription.Clean = value; _otherMonthlyExpenseDescription = otherMonthlyExpenseDescription;
                var reportDate = _reportDate; reportDate.Clean = value; _reportDate = reportDate;
                var requirementsNumber = _requirementsNumber; requirementsNumber.Clean = value; _requirementsNumber = requirementsNumber;
                var subdivisionDescription = _subdivisionDescription; subdivisionDescription.Clean = value; _subdivisionDescription = subdivisionDescription;
                var subdivisionRequirements = _subdivisionRequirements; subdivisionRequirements.Clean = value; _subdivisionRequirements = subdivisionRequirements;
                var totalMonthlyExpense = _totalMonthlyExpense; totalMonthlyExpense.Clean = value; _totalMonthlyExpense = totalMonthlyExpense;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public CommitmentTerms()
        {
            Clean = true;
        }
    }
}