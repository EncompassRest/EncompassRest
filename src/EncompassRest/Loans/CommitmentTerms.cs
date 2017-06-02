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
                var v0 = _actionDate; v0.Clean = value; _actionDate = v0;
                var v1 = _additionalConditions; v1.Clean = value; _additionalConditions = v1;
                var v2 = _additionalItems1; v2.Clean = value; _additionalItems1 = v2;
                var v3 = _additionalItems2; v3.Clean = value; _additionalItems2 = v3;
                var v4 = _additionalItems3; v4.Clean = value; _additionalItems3 = v4;
                var v5 = _appraisalDone; v5.Clean = value; _appraisalDone = v5;
                var v6 = _assuranceOfCompletion; v6.Clean = value; _assuranceOfCompletion = v6;
                var v7 = _commitmentDate; v7.Clean = value; _commitmentDate = v7;
                var v8 = _commitmentExpired; v8.Clean = value; _commitmentExpired = v8;
                var v9 = _commitmentIssued; v9.Clean = value; _commitmentIssued = v9;
                var v10 = _conditionalCommitmentUnderActg; v10.Clean = value; _conditionalCommitmentUnderActg = v10;
                var v11 = _eligibleForHighLtv; v11.Clean = value; _eligibleForHighLtv = v11;
                var v12 = _estimatedRemainingYears; v12.Clean = value; _estimatedRemainingYears = v12;
                var v13 = _id; v13.Clean = value; _id = v13;
                var v14 = _improvedLivingAreas; v14.Clean = value; _improvedLivingAreas = v14;
                var v15 = _manufacturedHousing; v15.Clean = value; _manufacturedHousing = v15;
                var v16 = _maxInsurableMortgage; v16.Clean = value; _maxInsurableMortgage = v16;
                var v17 = _mortgageeAddress; v17.Clean = value; _mortgageeAddress = v17;
                var v18 = _mortgageeCity; v18.Clean = value; _mortgageeCity = v18;
                var v19 = _mortgageeName; v19.Clean = value; _mortgageeName = v19;
                var v20 = _mortgageePostalCode; v20.Clean = value; _mortgageePostalCode = v20;
                var v21 = _mortgageeState; v21.Clean = value; _mortgageeState = v21;
                var v22 = _otherMonthlyExpenseDescription; v22.Clean = value; _otherMonthlyExpenseDescription = v22;
                var v23 = _reportDate; v23.Clean = value; _reportDate = v23;
                var v24 = _requirementsNumber; v24.Clean = value; _requirementsNumber = v24;
                var v25 = _subdivisionDescription; v25.Clean = value; _subdivisionDescription = v25;
                var v26 = _subdivisionRequirements; v26.Clean = value; _subdivisionRequirements = v26;
                var v27 = _totalMonthlyExpense; v27.Clean = value; _totalMonthlyExpense = v27;
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