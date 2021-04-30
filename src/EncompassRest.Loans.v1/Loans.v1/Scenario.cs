using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Scenario
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Scenario : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _allOtherMonthlyPayments;
        private DirtyValue<decimal?>? _baseIncome;
        private DirtyValue<decimal?>? _baseLoanAmount;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _createdBy;
        private DirtyValue<decimal?>? _effectivePropValue;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<decimal?>? _hoaFees;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _interestedPartyContribution;
        private DirtyValue<decimal?>? _leaseOrGroundRent;
        private DirtyValue<decimal?>? _monthlyPaymentTotal;
        private DirtyValue<decimal?>? _mortgageInsurance;
        private DirtyValue<decimal?>? _negativeCashFlow;
        private DirtyValue<decimal?>? _otherHousingExpenses;
        private DirtyValue<decimal?>? _otherIncome;
        private DirtyValue<decimal?>? _positiveCashFlow;
        private DirtyValue<int?>? _qualFico;
        private DirtyValue<decimal?>? _qualifyingRate;
        private DirtyValue<decimal?>? _required;
        private DirtyValue<string?>? _scenarioName;
        private DirtyValue<decimal?>? _secondMortgagePandI;
        private DirtyValue<decimal?>? _subordinateFinancingAmount;
        private DirtyValue<decimal?>? _totalInsurance;
        private DirtyValue<decimal?>? _totalInsuranceScenarioData;
        private DirtyValue<decimal?>? _totalLoanAmount;
        private DirtyValue<decimal?>? _totalTaxes;
        private DirtyValue<decimal?>? _totalTaxesScenarioData;
        private DirtyValue<decimal?>? _verifiedAssets;
        private DirtyValue<decimal?>? _verifiedAssetsScenarioData;

        /// <summary>
        /// Scenario All Other Monthly Payments [SCENNN20]
        /// </summary>
        public decimal? AllOtherMonthlyPayments { get => _allOtherMonthlyPayments; set => SetField(ref _allOtherMonthlyPayments, value); }

        /// <summary>
        /// Scenario Base Income [SCENNN08]
        /// </summary>
        public decimal? BaseIncome { get => _baseIncome; set => SetField(ref _baseIncome, value); }

        /// <summary>
        /// Scenario Base Loan Amount [SCENNN04]
        /// </summary>
        public decimal? BaseLoanAmount { get => _baseLoanAmount; set => SetField(ref _baseLoanAmount, value); }

        /// <summary>
        /// Scenario Comments [SCENNN28]
        /// </summary>
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Scenario Created By [SCENNN27]
        /// </summary>
        public string? CreatedBy { get => _createdBy; set => SetField(ref _createdBy, value); }

        /// <summary>
        /// Scenario Effective Prop Value [SCENNN01]
        /// </summary>
        public decimal? EffectivePropValue { get => _effectivePropValue; set => SetField(ref _effectivePropValue, value); }

        /// <summary>
        /// Scenario EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Scenario HOA Fees [SCENNN16]
        /// </summary>
        public decimal? HoaFees { get => _hoaFees; set => SetField(ref _hoaFees, value); }

        /// <summary>
        /// Scenario Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Scenario Interested Party Contribution percent [SCENNN25]
        /// </summary>
        public decimal? InterestedPartyContribution { get => _interestedPartyContribution; set => SetField(ref _interestedPartyContribution, value); }

        /// <summary>
        /// Scenario Lease or Ground Rent [SCENNN17]
        /// </summary>
        public decimal? LeaseOrGroundRent { get => _leaseOrGroundRent; set => SetField(ref _leaseOrGroundRent, value); }

        /// <summary>
        /// Scenario Total of All Monthly Payments [SCENNN21]
        /// </summary>
        public decimal? MonthlyPaymentTotal { get => _monthlyPaymentTotal; set => SetField(ref _monthlyPaymentTotal, value); }

        /// <summary>
        /// Scenario Mortgage Insurance [SCENNN15]
        /// </summary>
        public decimal? MortgageInsurance { get => _mortgageInsurance; set => SetField(ref _mortgageInsurance, value); }

        /// <summary>
        /// Scenario Negative Cash Flow [SCENNN19]
        /// </summary>
        public decimal? NegativeCashFlow { get => _negativeCashFlow; set => SetField(ref _negativeCashFlow, value); }

        /// <summary>
        /// Scenario Other Housing Expenses [SCENNN18]
        /// </summary>
        public decimal? OtherHousingExpenses { get => _otherHousingExpenses; set => SetField(ref _otherHousingExpenses, value); }

        /// <summary>
        /// Scenario Other Income [SCENNN09]
        /// </summary>
        public decimal? OtherIncome { get => _otherIncome; set => SetField(ref _otherIncome, value); }

        /// <summary>
        /// Scenario Positive Cash Flow [SCENNN10]
        /// </summary>
        public decimal? PositiveCashFlow { get => _positiveCashFlow; set => SetField(ref _positiveCashFlow, value); }

        /// <summary>
        /// Scenario Qual FICO  [SCENNN03]
        /// </summary>
        public int? QualFico { get => _qualFico; set => SetField(ref _qualFico, value); }

        /// <summary>
        /// Scenario Qualifying Rate [SCENNN07]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? QualifyingRate { get => _qualifyingRate; set => SetField(ref _qualifyingRate, value); }

        /// <summary>
        /// Scenario Required Amount [SCENNN22]
        /// </summary>
        public decimal? Required { get => _required; set => SetField(ref _required, value); }

        /// <summary>
        /// Scenario Name [SCENNN26]
        /// </summary>
        public string? ScenarioName { get => _scenarioName; set => SetField(ref _scenarioName, value); }

        /// <summary>
        /// Scenario Second Mortgage P and I  [SCENNN06]
        /// </summary>
        public decimal? SecondMortgagePandI { get => _secondMortgagePandI; set => SetField(ref _secondMortgagePandI, value); }

        /// <summary>
        /// Scenario Subordinate Financing Amount [SCENNN02]
        /// </summary>
        public decimal? SubordinateFinancingAmount { get => _subordinateFinancingAmount; set => SetField(ref _subordinateFinancingAmount, value); }

        /// <summary>
        /// Scenario Total Insurance [SCENNN11]
        /// </summary>
        public decimal? TotalInsurance { get => _totalInsurance; set => SetField(ref _totalInsurance, value); }

        /// <summary>
        /// Scenario Total Insurance Scenario Data [SCENNN13]
        /// </summary>
        public decimal? TotalInsuranceScenarioData { get => _totalInsuranceScenarioData; set => SetField(ref _totalInsuranceScenarioData, value); }

        /// <summary>
        /// Scenario Total Loan Amount [SCENNN05]
        /// </summary>
        public decimal? TotalLoanAmount { get => _totalLoanAmount; set => SetField(ref _totalLoanAmount, value); }

        /// <summary>
        /// Scenario Total Taxes [SCENNN12]
        /// </summary>
        public decimal? TotalTaxes { get => _totalTaxes; set => SetField(ref _totalTaxes, value); }

        /// <summary>
        /// Scenario Total Taxes Scenario Data [SCENNN14]
        /// </summary>
        public decimal? TotalTaxesScenarioData { get => _totalTaxesScenarioData; set => SetField(ref _totalTaxesScenarioData, value); }

        /// <summary>
        /// Scenario Verified Assets [SCENNN23]
        /// </summary>
        public decimal? VerifiedAssets { get => _verifiedAssets; set => SetField(ref _verifiedAssets, value); }

        /// <summary>
        /// Scenario Verified Assets Scenario Data [SCENNN24]
        /// </summary>
        public decimal? VerifiedAssetsScenarioData { get => _verifiedAssetsScenarioData; set => SetField(ref _verifiedAssetsScenarioData, value); }
    }
}