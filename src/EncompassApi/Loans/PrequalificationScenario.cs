using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// PrequalificationScenario
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PrequalificationScenario : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _appraisedValue;
        private DirtyValue<decimal?>? _apr;
        private DirtyValue<decimal?>? _cashToClose;
        private DirtyValue<decimal?>? _closingCost;
        private DirtyValue<decimal?>? _cltv;
        private DirtyValue<string?>? _comments;
        private DirtyValue<string?>? _creditScore;
        private DirtyValue<string?>? _currentStatus;
        private DirtyValue<decimal?>? _downPaymentAmount;
        private DirtyValue<decimal?>? _downPaymentPercent;
        private DirtyValue<decimal?>? _fhaUpfrontMIPremiumPercent;
        private DirtyValue<decimal?>? _grossNegativeCashFlow;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _loanAmount;
        private DirtyValue<decimal?>? _ltv;
        private DirtyValue<decimal?>? _maximumDebt;
        private DirtyValue<decimal?>? _maximumLoanAmount;
        private DirtyValue<decimal?>? _miAndFundingFeeFinancedAmount;
        private DirtyValue<decimal?>? _minimumIncome;
        private DirtyValue<decimal?>? _monthlyPayment;
        private DirtyValue<decimal?>? _prepaidItemsEstimatedAmount;
        private DirtyValue<int?>? _prequalificationScenarioIndex;
        private DirtyValue<decimal?>? _qualBottomRatioPercent;
        private DirtyValue<decimal?>? _qualTopRatioPercent;
        private DirtyValue<decimal?>? _salesPrice;
        private DirtyValue<decimal?>? _subordinateFin;
        private DirtyValue<decimal?>? _totalBaseCost;
        private DirtyValue<decimal?>? _totalCashAvailable;
        private DirtyValue<decimal?>? _totalCashLeft;
        private DirtyValue<decimal?>? _totalCosts;
        private DirtyValue<decimal?>? _totalFinancing;
        private DirtyValue<decimal?>? _totalHe;
        private DirtyValue<decimal?>? _totalIncome;
        private DirtyValue<decimal?>? _totalLoanAmount;
        private DirtyValue<decimal?>? _totalOtherExpense;
        private DirtyValue<decimal?>? _totalPaidOffMortgage;
        private DirtyValue<decimal?>? _totalPaidOffOthers;
        private DirtyValue<decimal?>? _totalPayments;

        /// <summary>
        /// PrequalificationScenario AppraisedValue [PREQUAL.X254], [PREQUAL.X255]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

        /// <summary>
        /// PrequalificationScenario Apr [PREQUAL.X48], [PREQUAL.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => SetField(ref _apr, value); }

        /// <summary>
        /// PrequalificationScenario CashToClose [PREQUAL.X44], [PREQUAL.X84]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CashToClose { get => _cashToClose; set => SetField(ref _cashToClose, value); }

        /// <summary>
        /// PrequalificationScenario ClosingCost [PREQUAL.X43], [PREQUAL.X83]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ClosingCost { get => _closingCost; set => SetField(ref _closingCost, value); }

        /// <summary>
        /// PrequalificationScenario Cltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Cltv { get => _cltv; set => SetField(ref _cltv, value); }

        /// <summary>
        /// PrequalificationScenario Comments
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// PrequalificationScenario CreditScore [PREQUAL.X305], [PREQUAL.X306]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CreditScore { get => _creditScore; set => SetField(ref _creditScore, value); }

        /// <summary>
        /// PrequalificationScenario CurrentStatus [PREQUAL.X303], [PREQUAL.X304]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CurrentStatus { get => _currentStatus; set => SetField(ref _currentStatus, value); }

        /// <summary>
        /// PrequalificationScenario DownPaymentAmount [PREQUAL.X234], [PREQUAL.X240]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? DownPaymentAmount { get => _downPaymentAmount; set => SetField(ref _downPaymentAmount, value); }

        /// <summary>
        /// PrequalificationScenario DownPaymentPercent [PREQUAL.X233], [PREQUAL.X239]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? DownPaymentPercent { get => _downPaymentPercent; set => SetField(ref _downPaymentPercent, value); }

        /// <summary>
        /// PrequalificationScenario FhaUpfrontMIPremiumPercent [PREQUAL.X295], [PREQUAL.X296]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? FhaUpfrontMIPremiumPercent { get => _fhaUpfrontMIPremiumPercent; set => SetField(ref _fhaUpfrontMIPremiumPercent, value); }

        /// <summary>
        /// PrequalificationScenario GrossNegativeCashFlow [PREQUAL.X301], [PREQUAL.X302]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? GrossNegativeCashFlow { get => _grossNegativeCashFlow; set => SetField(ref _grossNegativeCashFlow, value); }

        /// <summary>
        /// PrequalificationScenario Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PrequalificationScenario LoanAmount [PREQUAL.X34], [PREQUAL.X74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

        /// <summary>
        /// PrequalificationScenario Ltv
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Ltv { get => _ltv; set => SetField(ref _ltv, value); }

        /// <summary>
        /// PrequalificationScenario MaximumDebt
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MaximumDebt { get => _maximumDebt; set => SetField(ref _maximumDebt, value); }

        /// <summary>
        /// PrequalificationScenario MaximumLoanAmount
        /// </summary>
        public decimal? MaximumLoanAmount { get => _maximumLoanAmount; set => SetField(ref _maximumLoanAmount, value); }

        /// <summary>
        /// PrequalificationScenario MiAndFundingFeeFinancedAmount [PREQUAL.X297], [PREQUAL.X298]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MiAndFundingFeeFinancedAmount { get => _miAndFundingFeeFinancedAmount; set => SetField(ref _miAndFundingFeeFinancedAmount, value); }

        /// <summary>
        /// PrequalificationScenario MinimumIncome
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MinimumIncome { get => _minimumIncome; set => SetField(ref _minimumIncome, value); }

        /// <summary>
        /// PrequalificationScenario MonthlyPayment [PREQUAL.X256], [PREQUAL.X257]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

        /// <summary>
        /// PrequalificationScenario PrepaidItemsEstimatedAmount [PREQUAL.X282], [PREQUAL.X283]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? PrepaidItemsEstimatedAmount { get => _prepaidItemsEstimatedAmount; set => SetField(ref _prepaidItemsEstimatedAmount, value); }

        /// <summary>
        /// PrequalificationScenario PrequalificationScenarioIndex
        /// </summary>
        public int? PrequalificationScenarioIndex { get => _prequalificationScenarioIndex; set => SetField(ref _prequalificationScenarioIndex, value); }

        /// <summary>
        /// PrequalificationScenario QualBottomRatioPercent [PREQUAL.X238], [PREQUAL.X244]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualBottomRatioPercent { get => _qualBottomRatioPercent; set => SetField(ref _qualBottomRatioPercent, value); }

        /// <summary>
        /// PrequalificationScenario QualTopRatioPercent [PREQUAL.X237], [PREQUAL.X243]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? QualTopRatioPercent { get => _qualTopRatioPercent; set => SetField(ref _qualTopRatioPercent, value); }

        /// <summary>
        /// PrequalificationScenario SalesPrice [PREQUAL.X33], [PREQUAL.X73]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? SalesPrice { get => _salesPrice; set => SetField(ref _salesPrice, value); }

        /// <summary>
        /// PrequalificationScenario SubordinateFin [PREQUAL.X236], [PREQUAL.X242]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? SubordinateFin { get => _subordinateFin; set => SetField(ref _subordinateFin, value); }

        /// <summary>
        /// PrequalificationScenario TotalBaseCost
        /// </summary>
        public decimal? TotalBaseCost { get => _totalBaseCost; set => SetField(ref _totalBaseCost, value); }

        /// <summary>
        /// PrequalificationScenario TotalCashAvailable [PREQUAL.X290], [PREQUAL.X291]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalCashAvailable { get => _totalCashAvailable; set => SetField(ref _totalCashAvailable, value); }

        /// <summary>
        /// PrequalificationScenario TotalCashLeft
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalCashLeft { get => _totalCashLeft; set => SetField(ref _totalCashLeft, value); }

        /// <summary>
        /// PrequalificationScenario TotalCosts [PREQUAL.X284], [PREQUAL.X285]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalCosts { get => _totalCosts; set => SetField(ref _totalCosts, value); }

        /// <summary>
        /// PrequalificationScenario TotalFinancing [PREQUAL.X288], [PREQUAL.X289]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalFinancing { get => _totalFinancing; set => SetField(ref _totalFinancing, value); }

        /// <summary>
        /// PrequalificationScenario TotalHe [PREQUAL.X235], [PREQUAL.X241]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalHe { get => _totalHe; set => SetField(ref _totalHe, value); }

        /// <summary>
        /// PrequalificationScenario TotalIncome [PREQUAL.X266], [PREQUAL.X267]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalIncome { get => _totalIncome; set => SetField(ref _totalIncome, value); }

        /// <summary>
        /// PrequalificationScenario TotalLoanAmount [PREQUAL.X299], [PREQUAL.X300]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalLoanAmount { get => _totalLoanAmount; set => SetField(ref _totalLoanAmount, value); }

        /// <summary>
        /// PrequalificationScenario TotalOtherExpense [PREQUAL.X268], [PREQUAL.X269]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalOtherExpense { get => _totalOtherExpense; set => SetField(ref _totalOtherExpense, value); }

        /// <summary>
        /// PrequalificationScenario TotalPaidOffMortgage
        /// </summary>
        public decimal? TotalPaidOffMortgage { get => _totalPaidOffMortgage; set => SetField(ref _totalPaidOffMortgage, value); }

        /// <summary>
        /// PrequalificationScenario TotalPaidOffOthers
        /// </summary>
        public decimal? TotalPaidOffOthers { get => _totalPaidOffOthers; set => SetField(ref _totalPaidOffOthers, value); }

        /// <summary>
        /// PrequalificationScenario TotalPayments [PREQUAL.X258], [PREQUAL.X259]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPayments { get => _totalPayments; set => SetField(ref _totalPayments, value); }
    }
}