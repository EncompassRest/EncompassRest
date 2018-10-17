using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CommitmentTerms
    /// </summary>
    public sealed partial class CommitmentTerms : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _actionDate;
        private DirtyValue<string> _additionalConditions;
        private DirtyValue<string> _additionalItems1;
        private DirtyValue<string> _additionalItems2;
        private DirtyValue<string> _additionalItems3;
        private DirtyValue<bool?> _appraisalDone;
        private DirtyValue<decimal?> _assuranceOfCompletion;
        private DirtyValue<DateTime?> _commitmentDate;
        private DirtyValue<DateTime?> _commitmentExpired;
        private DirtyValue<DateTime?> _commitmentIssued;
        private DirtyValue<bool?> _conditionalCommitmentUnderActg;
        private DirtyValue<bool?> _eligibleForHighLtv;
        private DirtyValue<int?> _estimatedRemainingYears;
        private DirtyValue<string> _id;
        private DirtyValue<string> _improvedLivingAreas;
        private DirtyValue<bool?> _manufacturedHousing;
        private DirtyValue<decimal?> _maxInsurableMortgage;
        private DirtyValue<string> _mortgageeAddress;
        private DirtyValue<string> _mortgageeCity;
        private DirtyValue<string> _mortgageeName;
        private DirtyValue<string> _mortgageePostalCode;
        private DirtyValue<StringEnumValue<State>> _mortgageeState;
        private DirtyValue<string> _otherMonthlyExpenseDescription;
        private DirtyValue<DateTime?> _reportDate;
        private DirtyValue<string> _requirementsNumber;
        private DirtyValue<string> _subdivisionDescription;
        private DirtyValue<string> _subdivisionRequirements;
        private DirtyValue<decimal?> _totalMonthlyExpense;

        /// <summary>
        /// HUD Action Date [1038]
        /// </summary>
        public DateTime? ActionDate { get => _actionDate; set => SetField(ref _actionDate, value); }

        /// <summary>
        /// HUD See Conditions on Reverse [1190]
        /// </summary>
        public string AdditionalConditions { get => _additionalConditions; set => SetField(ref _additionalConditions, value); }

        /// <summary>
        /// HUD Conditions See Attached 1 [966]
        /// </summary>
        public string AdditionalItems1 { get => _additionalItems1; set => SetField(ref _additionalItems1, value); }

        /// <summary>
        /// HUD Conditions See Attached 2 [1081]
        /// </summary>
        public string AdditionalItems2 { get => _additionalItems2; set => SetField(ref _additionalItems2, value); }

        /// <summary>
        /// HUD Conditions See Attached 3 [1189]
        /// </summary>
        public string AdditionalItems3 { get => _additionalItems3; set => SetField(ref _additionalItems3, value); }

        /// <summary>
        /// HUD Commit Terms See Below [1365]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"See Below  (Appraisal done)\"}")]
        public bool? AppraisalDone { get => _appraisalDone; set => SetField(ref _appraisalDone, value); }

        /// <summary>
        /// HUD Assurance of Completion $ [649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AssuranceOfCompletion { get => _assuranceOfCompletion; set => SetField(ref _assuranceOfCompletion, value); }

        /// <summary>
        /// Mortgage Loan Commitment Date [3094]
        /// </summary>
        public DateTime? CommitmentDate { get => _commitmentDate; set => SetField(ref _commitmentDate, value); }

        /// <summary>
        /// Trans Details Loan Commit Expires [1072]
        /// </summary>
        public DateTime? CommitmentExpired { get => _commitmentExpired; set => SetField(ref _commitmentExpired, value); }

        /// <summary>
        /// HUD Commit Issued Date [1068]
        /// </summary>
        public DateTime? CommitmentIssued { get => _commitmentIssued; set => SetField(ref _commitmentIssued, value); }

        /// <summary>
        /// HUD Conditional Commit Under Act [1141]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Conditional Commitment under Act\"}")]
        public bool? ConditionalCommitmentUnderActg { get => _conditionalCommitmentUnderActg; set => SetField(ref _conditionalCommitmentUnderActg, value); }

        /// <summary>
        /// HUD Conditions Elig High Loan to Value Ratio [1342]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Eligible for high loan to value ratio\"}")]
        public bool? EligibleForHighLtv { get => _eligibleForHighLtv; set => SetField(ref _eligibleForHighLtv, value); }

        /// <summary>
        /// HUD Property Remaining Economic Life [1142]
        /// </summary>
        public int? EstimatedRemainingYears { get => _estimatedRemainingYears; set => SetField(ref _estimatedRemainingYears, value); }

        /// <summary>
        /// CommitmentTerms Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// HUD Improved Living Area [1082]
        /// </summary>
        public string ImprovedLivingAreas { get => _improvedLivingAreas; set => SetField(ref _improvedLivingAreas, value); }

        /// <summary>
        /// Subject Property Manufactured Housing [603]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Manufactured Housing\"}")]
        public bool? ManufacturedHousing { get => _manufacturedHousing; set => SetField(ref _manufacturedHousing, value); }

        /// <summary>
        /// HUD Mtg Ins Maximum [1080]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaxInsurableMortgage { get => _maxInsurableMortgage; set => SetField(ref _maxInsurableMortgage, value); }

        /// <summary>
        /// Commitment Mortgagee Addr [3343]
        /// </summary>
        public string MortgageeAddress { get => _mortgageeAddress; set => SetField(ref _mortgageeAddress, value); }

        /// <summary>
        /// Commitment Mortgagee City [3344]
        /// </summary>
        public string MortgageeCity { get => _mortgageeCity; set => SetField(ref _mortgageeCity, value); }

        /// <summary>
        /// Commitment Mortgagee Name [3342]
        /// </summary>
        public string MortgageeName { get => _mortgageeName; set => SetField(ref _mortgageeName, value); }

        /// <summary>
        /// Commitment Mortgagee Zip [3346]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string MortgageePostalCode { get => _mortgageePostalCode; set => SetField(ref _mortgageePostalCode, value); }

        /// <summary>
        /// Commitment Mortgagee State [3345]
        /// </summary>
        public StringEnumValue<State> MortgageeState { get => _mortgageeState; set => SetField(ref _mortgageeState, value); }

        /// <summary>
        /// HUD Expenses Oth Mo Expense Descr [1071]
        /// </summary>
        public string OtherMonthlyExpenseDescription { get => _otherMonthlyExpenseDescription; set => SetField(ref _otherMonthlyExpenseDescription, value); }

        /// <summary>
        /// HUD Report Date [1078]
        /// </summary>
        public DateTime? ReportDate { get => _reportDate; set => SetField(ref _reportDate, value); }

        /// <summary>
        /// HUD Comply w/ Requirements # [1077]
        /// </summary>
        public string RequirementsNumber { get => _requirementsNumber; set => SetField(ref _requirementsNumber, value); }

        /// <summary>
        /// HUD Subdivision Descr [1079]
        /// </summary>
        public string SubdivisionDescription { get => _subdivisionDescription; set => SetField(ref _subdivisionDescription, value); }

        /// <summary>
        /// HUD Subdivision Requirements [1076]
        /// </summary>
        public string SubdivisionRequirements { get => _subdivisionRequirements; set => SetField(ref _subdivisionRequirements, value); }

        /// <summary>
        /// HUD Expenses Total Mo Expenses Est [1075]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMonthlyExpense { get => _totalMonthlyExpense; set => SetField(ref _totalMonthlyExpense, value); }
    }
}