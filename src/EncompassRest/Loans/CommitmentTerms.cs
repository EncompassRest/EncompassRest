using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CommitmentTerms
    /// </summary>
    public sealed partial class CommitmentTerms : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actionDate;
        /// <summary>
        /// HUD Action Date [1038]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Action Date")]
        public DateTime? ActionDate { get => _actionDate; set => _actionDate = value; }
        private DirtyValue<string> _additionalConditions;
        /// <summary>
        /// HUD See Conditions on Reverse [1190]
        /// </summary>
        [LoanFieldProperty(Description = "HUD See Conditions on Reverse")]
        public string AdditionalConditions { get => _additionalConditions; set => _additionalConditions = value; }
        private DirtyValue<string> _additionalItems1;
        /// <summary>
        /// HUD Conditions See Attached 1 [966]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Conditions See Attached 1")]
        public string AdditionalItems1 { get => _additionalItems1; set => _additionalItems1 = value; }
        private DirtyValue<string> _additionalItems2;
        /// <summary>
        /// HUD Conditions See Attached 2 [1081]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Conditions See Attached 2")]
        public string AdditionalItems2 { get => _additionalItems2; set => _additionalItems2 = value; }
        private DirtyValue<string> _additionalItems3;
        /// <summary>
        /// HUD Conditions See Attached 3 [1189]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Conditions See Attached 3")]
        public string AdditionalItems3 { get => _additionalItems3; set => _additionalItems3 = value; }
        private DirtyValue<bool?> _appraisalDone;
        /// <summary>
        /// HUD Commit Terms See Below [1365]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Commit Terms See Below", OptionsJson = "{\"true\":\"See Below  (Appraisal done)\"}")]
        public bool? AppraisalDone { get => _appraisalDone; set => _appraisalDone = value; }
        private DirtyValue<decimal?> _assuranceOfCompletion;
        /// <summary>
        /// HUD Assurance of Completion $ [649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Assurance of Completion $")]
        public decimal? AssuranceOfCompletion { get => _assuranceOfCompletion; set => _assuranceOfCompletion = value; }
        private DirtyValue<DateTime?> _commitmentDate;
        /// <summary>
        /// Mortgage Loan Commitment Date [3094]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Loan Commitment Date")]
        public DateTime? CommitmentDate { get => _commitmentDate; set => _commitmentDate = value; }
        private DirtyValue<DateTime?> _commitmentExpired;
        /// <summary>
        /// Trans Details Loan Commit Expires [1072]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Commit Expires")]
        public DateTime? CommitmentExpired { get => _commitmentExpired; set => _commitmentExpired = value; }
        private DirtyValue<DateTime?> _commitmentIssued;
        /// <summary>
        /// HUD Commit Issued Date [1068]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Commit Issued Date")]
        public DateTime? CommitmentIssued { get => _commitmentIssued; set => _commitmentIssued = value; }
        private DirtyValue<bool?> _conditionalCommitmentUnderActg;
        /// <summary>
        /// HUD Conditional Commit Under Act [1141]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Conditional Commit Under Act", OptionsJson = "{\"true\":\"Conditional Commitment under Act\"}")]
        public bool? ConditionalCommitmentUnderActg { get => _conditionalCommitmentUnderActg; set => _conditionalCommitmentUnderActg = value; }
        private DirtyValue<bool?> _eligibleForHighLtv;
        /// <summary>
        /// HUD Conditions Elig High Loan to Value Ratio [1342]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Conditions Elig High Loan to Value Ratio", OptionsJson = "{\"true\":\"Eligible for high loan to value ratio\"}")]
        public bool? EligibleForHighLtv { get => _eligibleForHighLtv; set => _eligibleForHighLtv = value; }
        private DirtyValue<int?> _estimatedRemainingYears;
        /// <summary>
        /// HUD Property Remaining Economic Life [1142]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Property Remaining Economic Life")]
        public int? EstimatedRemainingYears { get => _estimatedRemainingYears; set => _estimatedRemainingYears = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// CommitmentTerms Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _improvedLivingAreas;
        /// <summary>
        /// HUD Improved Living Area [1082]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Improved Living Area")]
        public string ImprovedLivingAreas { get => _improvedLivingAreas; set => _improvedLivingAreas = value; }
        private DirtyValue<bool?> _manufacturedHousing;
        /// <summary>
        /// Subject Property Manufactured Housing [603]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Manufactured Housing", OptionsJson = "{\"true\":\"Manufactured Housing\"}")]
        public bool? ManufacturedHousing { get => _manufacturedHousing; set => _manufacturedHousing = value; }
        private DirtyValue<decimal?> _maxInsurableMortgage;
        /// <summary>
        /// HUD Mtg Ins Maximum [1080]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD Mtg Ins Maximum")]
        public decimal? MaxInsurableMortgage { get => _maxInsurableMortgage; set => _maxInsurableMortgage = value; }
        private DirtyValue<string> _mortgageeAddress;
        /// <summary>
        /// Commitment Mortgagee Addr [3343]
        /// </summary>
        [LoanFieldProperty(Description = "Commitment Mortgagee Addr")]
        public string MortgageeAddress { get => _mortgageeAddress; set => _mortgageeAddress = value; }
        private DirtyValue<string> _mortgageeCity;
        /// <summary>
        /// Commitment Mortgagee City [3344]
        /// </summary>
        [LoanFieldProperty(Description = "Commitment Mortgagee City")]
        public string MortgageeCity { get => _mortgageeCity; set => _mortgageeCity = value; }
        private DirtyValue<string> _mortgageeName;
        /// <summary>
        /// Commitment Mortgagee Name [3342]
        /// </summary>
        [LoanFieldProperty(Description = "Commitment Mortgagee Name")]
        public string MortgageeName { get => _mortgageeName; set => _mortgageeName = value; }
        private DirtyValue<string> _mortgageePostalCode;
        /// <summary>
        /// Commitment Mortgagee Zip [3346]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Commitment Mortgagee Zip")]
        public string MortgageePostalCode { get => _mortgageePostalCode; set => _mortgageePostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _mortgageeState;
        /// <summary>
        /// Commitment Mortgagee State [3345]
        /// </summary>
        [LoanFieldProperty(Description = "Commitment Mortgagee State")]
        public StringEnumValue<State> MortgageeState { get => _mortgageeState; set => _mortgageeState = value; }
        private DirtyValue<string> _otherMonthlyExpenseDescription;
        /// <summary>
        /// HUD Expenses Oth Mo Expense Descr [1071]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Expenses Oth Mo Expense Descr")]
        public string OtherMonthlyExpenseDescription { get => _otherMonthlyExpenseDescription; set => _otherMonthlyExpenseDescription = value; }
        private DirtyValue<DateTime?> _reportDate;
        /// <summary>
        /// HUD Report Date [1078]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Report Date")]
        public DateTime? ReportDate { get => _reportDate; set => _reportDate = value; }
        private DirtyValue<string> _requirementsNumber;
        /// <summary>
        /// HUD Comply w/ Requirements # [1077]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Comply w/ Requirements #")]
        public string RequirementsNumber { get => _requirementsNumber; set => _requirementsNumber = value; }
        private DirtyValue<string> _subdivisionDescription;
        /// <summary>
        /// HUD Subdivision Descr [1079]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Subdivision Descr")]
        public string SubdivisionDescription { get => _subdivisionDescription; set => _subdivisionDescription = value; }
        private DirtyValue<string> _subdivisionRequirements;
        /// <summary>
        /// HUD Subdivision Requirements [1076]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Subdivision Requirements")]
        public string SubdivisionRequirements { get => _subdivisionRequirements; set => _subdivisionRequirements = value; }
        private DirtyValue<decimal?> _totalMonthlyExpense;
        /// <summary>
        /// HUD Expenses Total Mo Expenses Est [1075]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD Expenses Total Mo Expenses Est")]
        public decimal? TotalMonthlyExpense { get => _totalMonthlyExpense; set => _totalMonthlyExpense = value; }
        internal override bool DirtyInternal
        {
            get => _actionDate.Dirty
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