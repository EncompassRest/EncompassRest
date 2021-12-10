using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Gfe2010Fee
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010FeeIndex) + "," + nameof(Gfe2010FeeParentType) + "," + nameof(Gfe2010FeeType))]
    public sealed partial class Gfe2010Fee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _additionalAmount;
        private DirtyValue<decimal?>? _amount;
        private DirtyValue<bool?>? _aprIndicator;
        private DirtyValue<decimal?>? _borPaidAmount;
        private DirtyValue<decimal?>? _borrowerAmountPaid2015;
        private DirtyValue<bool?>? _borrowerCanShopForIndicator2015;
        private DirtyValue<bool?>? _borrowerDidShopForIndicator2015;
        private DirtyValue<decimal?>? _borrowerFinanced2015;
        private DirtyValue<decimal?>? _borrowerPAC2015;
        private DirtyValue<decimal?>? _borrowerPOC2015;
        private DirtyValue<decimal?>? _borrowerPTC2015;
        private DirtyValue<bool?>? _borrowerSelectIndicator;
        private DirtyValue<decimal?>? _brokerAmountPaid2015;
        private DirtyValue<decimal?>? _brokerPAC2015;
        private DirtyValue<decimal?>? _brokerPOC2015;
        private DirtyValue<bool?>? _collectedPostConsummationIndicator2015;
        private DirtyValue<string?>? _description;
        private DirtyValue<bool?>? _escrowedIndicator2015;
        private DirtyValue<bool?>? _financedIndicator;
        private DirtyValue<int?>? _gfe2010FeeIndex;
        private DirtyValue<StringEnumValue<Gfe2010FeeParentType>>? _gfe2010FeeParentType;
        private DirtyValue<StringEnumValue<Gfe2010FeeType>>? _gfe2010FeeType;
        private DirtyValue<decimal?>? _gfeAmount;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _insuranceIndicator2015;
        private DirtyValue<decimal?>? _lastDisclosedClosingDisclosure2015;
        private DirtyValue<int?>? _lastDisclosedLoanEstimate2015;
        private DirtyValue<decimal?>? _lenderAmountPaid2015;
        private DirtyValue<decimal?>? _lenderPAC2015;
        private DirtyValue<decimal?>? _lenderPOC2015;
        private DirtyValue<decimal?>? _monthlyPayment;
        private DirtyValue<int?>? _numberOfMonths;
        private DirtyValue<bool?>? _optionalIndicator2015;
        private DirtyValue<decimal?>? _otherAmountPaid2015;
        private DirtyValue<decimal?>? _otherPAC2015;
        private DirtyValue<decimal?>? _otherPOC2015;
        private DirtyValue<StringEnumValue<PaidBy>>? _paidByType;
        private DirtyValue<string?>? _paidToName;
        private DirtyValue<bool?>? _pocPtcIndicator;
        private DirtyValue<bool?>? _propertyIndicator2015;
        private DirtyValue<StringEnumValue<PTB>>? _ptbType;
        private DirtyValue<decimal?>? _rate;
        private DirtyValue<decimal?>? _retainedAmount2015;
        private DirtyValue<decimal?>? _sec32PointsAndFees2015;
        private DirtyValue<decimal?>? _sellerAmountPaid2015;
        private DirtyValue<bool?>? _sellerCreditIndicator2015;
        private DirtyValue<decimal?>? _sellerObligatedAmount2015;
        private DirtyValue<bool?>? _sellerObligatedIndicator2015;
        private DirtyValue<decimal?>? _sellerPAC2015;
        private DirtyValue<decimal?>? _sellerPOC2015;
        private DirtyValue<decimal?>? _selPaidAmount;
        private DirtyValue<bool?>? _simultaneousIssuanceIndicator2015;
        private DirtyValue<bool?>? _taxesIndicator2015;
        private DirtyValue<bool?>? _titleServiceSelectIndicator;
        private DirtyValue<decimal?>? _totalFeeAmount2015;
        private DirtyValue<decimal?>? _totalFeePercentage2015;
        private DirtyValue<decimal?>? _totalPaidByBLO2015;
        private DirtyValue<decimal?>? _undiscountedInsurance2015;
        private DirtyValue<decimal?>? _wholePoc;
        private DirtyValue<StringEnumValue<WholePocPaidByType>>? _wholePocPaidByType;

        /// <summary>
        /// Gfe2010Fee AdditionalAmount
        /// </summary>
        public decimal? AdditionalAmount { get => _additionalAmount; set => SetField(ref _additionalAmount, value); }

        /// <summary>
        /// Gfe2010Fee Amount
        /// </summary>
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// Gfe2010Fee AprIndicator
        /// </summary>
        public bool? AprIndicator { get => _aprIndicator; set => SetField(ref _aprIndicator, value); }

        /// <summary>
        /// Gfe2010Fee BorPaidAmount
        /// </summary>
        public decimal? BorPaidAmount { get => _borPaidAmount; set => SetField(ref _borPaidAmount, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerAmountPaid2015
        /// </summary>
        public decimal? BorrowerAmountPaid2015 { get => _borrowerAmountPaid2015; set => SetField(ref _borrowerAmountPaid2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerCanShopForIndicator2015
        /// </summary>
        public bool? BorrowerCanShopForIndicator2015 { get => _borrowerCanShopForIndicator2015; set => SetField(ref _borrowerCanShopForIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerDidShopForIndicator2015
        /// </summary>
        public bool? BorrowerDidShopForIndicator2015 { get => _borrowerDidShopForIndicator2015; set => SetField(ref _borrowerDidShopForIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerFinanced2015
        /// </summary>
        public decimal? BorrowerFinanced2015 { get => _borrowerFinanced2015; set => SetField(ref _borrowerFinanced2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerPAC2015
        /// </summary>
        public decimal? BorrowerPAC2015 { get => _borrowerPAC2015; set => SetField(ref _borrowerPAC2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerPOC2015
        /// </summary>
        public decimal? BorrowerPOC2015 { get => _borrowerPOC2015; set => SetField(ref _borrowerPOC2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerPTC2015
        /// </summary>
        public decimal? BorrowerPTC2015 { get => _borrowerPTC2015; set => SetField(ref _borrowerPTC2015, value); }

        /// <summary>
        /// Gfe2010Fee BorrowerSelectIndicator
        /// </summary>
        public bool? BorrowerSelectIndicator { get => _borrowerSelectIndicator; set => SetField(ref _borrowerSelectIndicator, value); }

        /// <summary>
        /// Gfe2010Fee BrokerAmountPaid2015
        /// </summary>
        public decimal? BrokerAmountPaid2015 { get => _brokerAmountPaid2015; set => SetField(ref _brokerAmountPaid2015, value); }

        /// <summary>
        /// Gfe2010Fee BrokerPAC2015
        /// </summary>
        public decimal? BrokerPAC2015 { get => _brokerPAC2015; set => SetField(ref _brokerPAC2015, value); }

        /// <summary>
        /// Gfe2010Fee BrokerPOC2015
        /// </summary>
        public decimal? BrokerPOC2015 { get => _brokerPOC2015; set => SetField(ref _brokerPOC2015, value); }

        /// <summary>
        /// Gfe2010Fee CollectedPostConsummationIndicator2015
        /// </summary>
        public bool? CollectedPostConsummationIndicator2015 { get => _collectedPostConsummationIndicator2015; set => SetField(ref _collectedPostConsummationIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee Description
        /// </summary>
        public string? Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// Gfe2010Fee EscrowedIndicator2015
        /// </summary>
        public bool? EscrowedIndicator2015 { get => _escrowedIndicator2015; set => SetField(ref _escrowedIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee FinancedIndicator
        /// </summary>
        public bool? FinancedIndicator { get => _financedIndicator; set => SetField(ref _financedIndicator, value); }

        /// <summary>
        /// Gfe2010Fee Gfe2010FeeIndex
        /// </summary>
        public int? Gfe2010FeeIndex { get => _gfe2010FeeIndex; set => SetField(ref _gfe2010FeeIndex, value); }

        /// <summary>
        /// Gfe2010Fee Gfe2010FeeParentType
        /// </summary>
        public StringEnumValue<Gfe2010FeeParentType> Gfe2010FeeParentType { get => _gfe2010FeeParentType; set => SetField(ref _gfe2010FeeParentType, value); }

        /// <summary>
        /// Gfe2010Fee Gfe2010FeeType
        /// </summary>
        public StringEnumValue<Gfe2010FeeType> Gfe2010FeeType { get => _gfe2010FeeType; set => SetField(ref _gfe2010FeeType, value); }

        /// <summary>
        /// Gfe2010Fee GfeAmount
        /// </summary>
        public decimal? GfeAmount { get => _gfeAmount; set => SetField(ref _gfeAmount, value); }

        /// <summary>
        /// Gfe2010Fee Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Gfe2010Fee InsuranceIndicator2015
        /// </summary>
        public bool? InsuranceIndicator2015 { get => _insuranceIndicator2015; set => SetField(ref _insuranceIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee LastDisclosedClosingDisclosure2015
        /// </summary>
        public decimal? LastDisclosedClosingDisclosure2015 { get => _lastDisclosedClosingDisclosure2015; set => SetField(ref _lastDisclosedClosingDisclosure2015, value); }

        /// <summary>
        /// Gfe2010Fee LastDisclosedLoanEstimate2015
        /// </summary>
        public int? LastDisclosedLoanEstimate2015 { get => _lastDisclosedLoanEstimate2015; set => SetField(ref _lastDisclosedLoanEstimate2015, value); }

        /// <summary>
        /// Gfe2010Fee LenderAmountPaid2015
        /// </summary>
        public decimal? LenderAmountPaid2015 { get => _lenderAmountPaid2015; set => SetField(ref _lenderAmountPaid2015, value); }

        /// <summary>
        /// Gfe2010Fee LenderPAC2015
        /// </summary>
        public decimal? LenderPAC2015 { get => _lenderPAC2015; set => SetField(ref _lenderPAC2015, value); }

        /// <summary>
        /// Gfe2010Fee LenderPOC2015
        /// </summary>
        public decimal? LenderPOC2015 { get => _lenderPOC2015; set => SetField(ref _lenderPOC2015, value); }

        /// <summary>
        /// Gfe2010Fee MonthlyPayment
        /// </summary>
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

        /// <summary>
        /// Gfe2010Fee NumberOfMonths
        /// </summary>
        public int? NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }

        /// <summary>
        /// Gfe2010Fee OptionalIndicator2015
        /// </summary>
        public bool? OptionalIndicator2015 { get => _optionalIndicator2015; set => SetField(ref _optionalIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee OtherAmountPaid2015
        /// </summary>
        public decimal? OtherAmountPaid2015 { get => _otherAmountPaid2015; set => SetField(ref _otherAmountPaid2015, value); }

        /// <summary>
        /// Gfe2010Fee OtherPAC2015
        /// </summary>
        public decimal? OtherPAC2015 { get => _otherPAC2015; set => SetField(ref _otherPAC2015, value); }

        /// <summary>
        /// Gfe2010Fee OtherPOC2015
        /// </summary>
        public decimal? OtherPOC2015 { get => _otherPOC2015; set => SetField(ref _otherPOC2015, value); }

        /// <summary>
        /// Gfe2010Fee PaidByType
        /// </summary>
        public StringEnumValue<PaidBy> PaidByType { get => _paidByType; set => SetField(ref _paidByType, value); }

        /// <summary>
        /// Gfe2010Fee PaidToName
        /// </summary>
        public string? PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }

        /// <summary>
        /// Gfe2010Fee PocPtcIndicator
        /// </summary>
        public bool? PocPtcIndicator { get => _pocPtcIndicator; set => SetField(ref _pocPtcIndicator, value); }

        /// <summary>
        /// Gfe2010Fee PropertyIndicator2015
        /// </summary>
        public bool? PropertyIndicator2015 { get => _propertyIndicator2015; set => SetField(ref _propertyIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee PtbType
        /// </summary>
        public StringEnumValue<PTB> PtbType { get => _ptbType; set => SetField(ref _ptbType, value); }

        /// <summary>
        /// Gfe2010Fee Rate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Rate { get => _rate; set => SetField(ref _rate, value); }

        /// <summary>
        /// Gfe2010Fee RetainedAmount2015 [NEWHUD2.X2219], [NEWHUD2.X2318]
        /// </summary>
        public decimal? RetainedAmount2015 { get => _retainedAmount2015; set => SetField(ref _retainedAmount2015, value); }

        /// <summary>
        /// Gfe2010Fee Sec32PointsAndFees2015
        /// </summary>
        public decimal? Sec32PointsAndFees2015 { get => _sec32PointsAndFees2015; set => SetField(ref _sec32PointsAndFees2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerAmountPaid2015
        /// </summary>
        public decimal? SellerAmountPaid2015 { get => _sellerAmountPaid2015; set => SetField(ref _sellerAmountPaid2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerCreditIndicator2015
        /// </summary>
        public bool? SellerCreditIndicator2015 { get => _sellerCreditIndicator2015; set => SetField(ref _sellerCreditIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerObligatedAmount2015
        /// </summary>
        public decimal? SellerObligatedAmount2015 { get => _sellerObligatedAmount2015; set => SetField(ref _sellerObligatedAmount2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerObligatedIndicator2015
        /// </summary>
        public bool? SellerObligatedIndicator2015 { get => _sellerObligatedIndicator2015; set => SetField(ref _sellerObligatedIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerPAC2015
        /// </summary>
        public decimal? SellerPAC2015 { get => _sellerPAC2015; set => SetField(ref _sellerPAC2015, value); }

        /// <summary>
        /// Gfe2010Fee SellerPOC2015
        /// </summary>
        public decimal? SellerPOC2015 { get => _sellerPOC2015; set => SetField(ref _sellerPOC2015, value); }

        /// <summary>
        /// Gfe2010Fee SelPaidAmount
        /// </summary>
        public decimal? SelPaidAmount { get => _selPaidAmount; set => SetField(ref _selPaidAmount, value); }

        /// <summary>
        /// Gfe2010Fee SimultaneousIssuanceIndicator2015 [NEWHUD2.X4441], [NEWHUD2.X4443]
        /// </summary>
        public bool? SimultaneousIssuanceIndicator2015 { get => _simultaneousIssuanceIndicator2015; set => SetField(ref _simultaneousIssuanceIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee TaxesIndicator2015
        /// </summary>
        public bool? TaxesIndicator2015 { get => _taxesIndicator2015; set => SetField(ref _taxesIndicator2015, value); }

        /// <summary>
        /// Gfe2010Fee TitleServiceSelectIndicator
        /// </summary>
        public bool? TitleServiceSelectIndicator { get => _titleServiceSelectIndicator; set => SetField(ref _titleServiceSelectIndicator, value); }

        /// <summary>
        /// Gfe2010Fee TotalFeeAmount2015
        /// </summary>
        public decimal? TotalFeeAmount2015 { get => _totalFeeAmount2015; set => SetField(ref _totalFeeAmount2015, value); }

        /// <summary>
        /// Gfe2010Fee TotalFeePercentage2015
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? TotalFeePercentage2015 { get => _totalFeePercentage2015; set => SetField(ref _totalFeePercentage2015, value); }

        /// <summary>
        /// Gfe2010Fee TotalPaidByBLO2015
        /// </summary>
        public decimal? TotalPaidByBLO2015 { get => _totalPaidByBLO2015; set => SetField(ref _totalPaidByBLO2015, value); }

        /// <summary>
        /// Gfe2010Fee UndiscountedInsurance2015 [NEWHUD2.X4442], [NEWHUD2.X4444]
        /// </summary>
        public decimal? UndiscountedInsurance2015 { get => _undiscountedInsurance2015; set => SetField(ref _undiscountedInsurance2015, value); }

        /// <summary>
        /// Gfe2010Fee WholePoc
        /// </summary>
        public decimal? WholePoc { get => _wholePoc; set => SetField(ref _wholePoc, value); }

        /// <summary>
        /// Gfe2010Fee WholePocPaidByType
        /// </summary>
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => SetField(ref _wholePocPaidByType, value); }
    }
}