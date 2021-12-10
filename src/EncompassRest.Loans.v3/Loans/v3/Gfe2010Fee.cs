using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Gfe2010Fee
/// </summary>
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
    private DirtyValue<decimal?>? _borrowerPac2015;
    private DirtyValue<decimal?>? _borrowerPoc2015;
    private DirtyValue<decimal?>? _borrowerPtc2015;
    private DirtyValue<bool?>? _borrowerSelectIndicator;
    private DirtyValue<decimal?>? _brokerAmountPaid2015;
    private DirtyValue<decimal?>? _brokerPac2015;
    private DirtyValue<decimal?>? _brokerPoc2015;
    private DirtyValue<bool?>? _collectedPostConsummationIndicator2015;
    private DirtyValue<string?>? _description;
    private DirtyValue<bool?>? _escrowedIndicator2015;
    private DirtyValue<bool?>? _financedIndicator;
    private DirtyValue<int?>? _gfe2010FeeIndex;
    private DirtyValue<StringEnumValue<Gfe2010FeeParentType>>? _gfe2010FeeParentType;
    private DirtyValue<StringEnumValue<Gfe2010FeeType>>? _gfe2010FeeType;
    private DirtyValue<decimal?>? _gfeAmount;
    private DirtyValue<bool?>? _insuranceIndicator2015;
    private DirtyValue<decimal?>? _lastDisclosedClosingDisclosure2015;
    private DirtyValue<int?>? _lastDisclosedLoanEstimate2015;
    private DirtyValue<decimal?>? _lenderAmountPaid2015;
    private DirtyValue<decimal?>? _lenderPac2015;
    private DirtyValue<decimal?>? _lenderPoc2015;
    private DirtyValue<decimal?>? _monthlyPayment;
    private DirtyValue<int?>? _numberOfMonths;
    private DirtyValue<bool?>? _optionalIndicator2015;
    private DirtyValue<decimal?>? _otherAmountPaid2015;
    private DirtyValue<decimal?>? _otherPac2015;
    private DirtyValue<decimal?>? _otherPoc2015;
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
    private DirtyValue<decimal?>? _sellerPac2015;
    private DirtyValue<decimal?>? _sellerPoc2015;
    private DirtyValue<decimal?>? _selPaidAmount;
    private DirtyValue<bool?>? _simultaneousIssuanceIndicator2015;
    private DirtyValue<bool?>? _taxesIndicator2015;
    private DirtyValue<bool?>? _titleServiceSelectIndicator;
    private DirtyValue<decimal?>? _totalFeeAmount2015;
    private DirtyValue<decimal?>? _totalFeePercentage2015;
    private DirtyValue<decimal?>? _totalPaidByBLo2015;
    private DirtyValue<decimal?>? _undiscountedInsurance2015;
    private DirtyValue<decimal?>? _wholePoc;
    private DirtyValue<StringEnumValue<WholePocPaidByType>>? _wholePocPaidByType;

    /// <summary>
    /// Gfe2010FeeContract AdditionalAmount
    /// </summary>
    public decimal? AdditionalAmount { get => _additionalAmount; set => SetField(ref _additionalAmount, value); }

    /// <summary>
    /// Gfe2010FeeContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// Gfe2010FeeContract AprIndicator
    /// </summary>
    public bool? AprIndicator { get => _aprIndicator; set => SetField(ref _aprIndicator, value); }

    /// <summary>
    /// Gfe2010FeeContract BorPaidAmount
    /// </summary>
    public decimal? BorPaidAmount { get => _borPaidAmount; set => SetField(ref _borPaidAmount, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerAmountPaid2015
    /// </summary>
    public decimal? BorrowerAmountPaid2015 { get => _borrowerAmountPaid2015; set => SetField(ref _borrowerAmountPaid2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerCanShopForIndicator2015
    /// </summary>
    public bool? BorrowerCanShopForIndicator2015 { get => _borrowerCanShopForIndicator2015; set => SetField(ref _borrowerCanShopForIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerDidShopForIndicator2015
    /// </summary>
    public bool? BorrowerDidShopForIndicator2015 { get => _borrowerDidShopForIndicator2015; set => SetField(ref _borrowerDidShopForIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerFinanced2015
    /// </summary>
    public decimal? BorrowerFinanced2015 { get => _borrowerFinanced2015; set => SetField(ref _borrowerFinanced2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerPac2015
    /// </summary>
    public decimal? BorrowerPac2015 { get => _borrowerPac2015; set => SetField(ref _borrowerPac2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerPoc2015
    /// </summary>
    public decimal? BorrowerPoc2015 { get => _borrowerPoc2015; set => SetField(ref _borrowerPoc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerPtc2015
    /// </summary>
    public decimal? BorrowerPtc2015 { get => _borrowerPtc2015; set => SetField(ref _borrowerPtc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BorrowerSelectIndicator
    /// </summary>
    public bool? BorrowerSelectIndicator { get => _borrowerSelectIndicator; set => SetField(ref _borrowerSelectIndicator, value); }

    /// <summary>
    /// Gfe2010FeeContract BrokerAmountPaid2015
    /// </summary>
    public decimal? BrokerAmountPaid2015 { get => _brokerAmountPaid2015; set => SetField(ref _brokerAmountPaid2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BrokerPac2015
    /// </summary>
    public decimal? BrokerPac2015 { get => _brokerPac2015; set => SetField(ref _brokerPac2015, value); }

    /// <summary>
    /// Gfe2010FeeContract BrokerPoc2015
    /// </summary>
    public decimal? BrokerPoc2015 { get => _brokerPoc2015; set => SetField(ref _brokerPoc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract CollectedPostConsummationIndicator2015
    /// </summary>
    public bool? CollectedPostConsummationIndicator2015 { get => _collectedPostConsummationIndicator2015; set => SetField(ref _collectedPostConsummationIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// Gfe2010FeeContract EscrowedIndicator2015
    /// </summary>
    public bool? EscrowedIndicator2015 { get => _escrowedIndicator2015; set => SetField(ref _escrowedIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract FinancedIndicator
    /// </summary>
    public bool? FinancedIndicator { get => _financedIndicator; set => SetField(ref _financedIndicator, value); }

    /// <summary>
    /// Gfe2010FeeContract Gfe2010FeeIndex
    /// </summary>
    public int? Gfe2010FeeIndex { get => _gfe2010FeeIndex; set => SetField(ref _gfe2010FeeIndex, value); }

    /// <summary>
    /// Gfe2010FeeContract Gfe2010FeeParentType
    /// </summary>
    public StringEnumValue<Gfe2010FeeParentType> Gfe2010FeeParentType { get => _gfe2010FeeParentType; set => SetField(ref _gfe2010FeeParentType, value); }

    /// <summary>
    /// Gfe2010FeeContract Gfe2010FeeType
    /// </summary>
    public StringEnumValue<Gfe2010FeeType> Gfe2010FeeType { get => _gfe2010FeeType; set => SetField(ref _gfe2010FeeType, value); }

    /// <summary>
    /// Gfe2010FeeContract GfeAmount
    /// </summary>
    public decimal? GfeAmount { get => _gfeAmount; set => SetField(ref _gfeAmount, value); }

    /// <summary>
    /// Gfe2010FeeContract InsuranceIndicator2015
    /// </summary>
    public bool? InsuranceIndicator2015 { get => _insuranceIndicator2015; set => SetField(ref _insuranceIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract LastDisclosedClosingDisclosure2015
    /// </summary>
    public decimal? LastDisclosedClosingDisclosure2015 { get => _lastDisclosedClosingDisclosure2015; set => SetField(ref _lastDisclosedClosingDisclosure2015, value); }

    /// <summary>
    /// Gfe2010FeeContract LastDisclosedLoanEstimate2015
    /// </summary>
    public int? LastDisclosedLoanEstimate2015 { get => _lastDisclosedLoanEstimate2015; set => SetField(ref _lastDisclosedLoanEstimate2015, value); }

    /// <summary>
    /// Gfe2010FeeContract LenderAmountPaid2015
    /// </summary>
    public decimal? LenderAmountPaid2015 { get => _lenderAmountPaid2015; set => SetField(ref _lenderAmountPaid2015, value); }

    /// <summary>
    /// Gfe2010FeeContract LenderPac2015
    /// </summary>
    public decimal? LenderPac2015 { get => _lenderPac2015; set => SetField(ref _lenderPac2015, value); }

    /// <summary>
    /// Gfe2010FeeContract LenderPoc2015
    /// </summary>
    public decimal? LenderPoc2015 { get => _lenderPoc2015; set => SetField(ref _lenderPoc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract MonthlyPayment
    /// </summary>
    public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

    /// <summary>
    /// Gfe2010FeeContract NumberOfMonths
    /// </summary>
    public int? NumberOfMonths { get => _numberOfMonths; set => SetField(ref _numberOfMonths, value); }

    /// <summary>
    /// Gfe2010FeeContract OptionalIndicator2015
    /// </summary>
    public bool? OptionalIndicator2015 { get => _optionalIndicator2015; set => SetField(ref _optionalIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract OtherAmountPaid2015
    /// </summary>
    public decimal? OtherAmountPaid2015 { get => _otherAmountPaid2015; set => SetField(ref _otherAmountPaid2015, value); }

    /// <summary>
    /// Gfe2010FeeContract OtherPac2015
    /// </summary>
    public decimal? OtherPac2015 { get => _otherPac2015; set => SetField(ref _otherPac2015, value); }

    /// <summary>
    /// Gfe2010FeeContract OtherPoc2015
    /// </summary>
    public decimal? OtherPoc2015 { get => _otherPoc2015; set => SetField(ref _otherPoc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract PaidByType
    /// </summary>
    public StringEnumValue<PaidBy> PaidByType { get => _paidByType; set => SetField(ref _paidByType, value); }

    /// <summary>
    /// Gfe2010FeeContract PaidToName
    /// </summary>
    public string? PaidToName { get => _paidToName; set => SetField(ref _paidToName, value); }

    /// <summary>
    /// Gfe2010FeeContract PocPtcIndicator
    /// </summary>
    public bool? PocPtcIndicator { get => _pocPtcIndicator; set => SetField(ref _pocPtcIndicator, value); }

    /// <summary>
    /// Gfe2010FeeContract PropertyIndicator2015
    /// </summary>
    public bool? PropertyIndicator2015 { get => _propertyIndicator2015; set => SetField(ref _propertyIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract PtbType
    /// </summary>
    public StringEnumValue<PTB> PtbType { get => _ptbType; set => SetField(ref _ptbType, value); }

    /// <summary>
    /// Gfe2010FeeContract Rate
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Rate { get => _rate; set => SetField(ref _rate, value); }

    /// <summary>
    /// Gfe2010FeeContract RetainedAmount2015 [NEWHUD2.X2219], [NEWHUD2.X2318]
    /// </summary>
    public decimal? RetainedAmount2015 { get => _retainedAmount2015; set => SetField(ref _retainedAmount2015, value); }

    /// <summary>
    /// Gfe2010FeeContract Sec32PointsAndFees2015
    /// </summary>
    public decimal? Sec32PointsAndFees2015 { get => _sec32PointsAndFees2015; set => SetField(ref _sec32PointsAndFees2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerAmountPaid2015
    /// </summary>
    public decimal? SellerAmountPaid2015 { get => _sellerAmountPaid2015; set => SetField(ref _sellerAmountPaid2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerCreditIndicator2015
    /// </summary>
    public bool? SellerCreditIndicator2015 { get => _sellerCreditIndicator2015; set => SetField(ref _sellerCreditIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerObligatedAmount2015
    /// </summary>
    public decimal? SellerObligatedAmount2015 { get => _sellerObligatedAmount2015; set => SetField(ref _sellerObligatedAmount2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerObligatedIndicator2015
    /// </summary>
    public bool? SellerObligatedIndicator2015 { get => _sellerObligatedIndicator2015; set => SetField(ref _sellerObligatedIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerPac2015
    /// </summary>
    public decimal? SellerPac2015 { get => _sellerPac2015; set => SetField(ref _sellerPac2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SellerPoc2015
    /// </summary>
    public decimal? SellerPoc2015 { get => _sellerPoc2015; set => SetField(ref _sellerPoc2015, value); }

    /// <summary>
    /// Gfe2010FeeContract SelPaidAmount
    /// </summary>
    public decimal? SelPaidAmount { get => _selPaidAmount; set => SetField(ref _selPaidAmount, value); }

    /// <summary>
    /// Gfe2010FeeContract SimultaneousIssuanceIndicator2015 [NEWHUD2.X4441], [NEWHUD2.X4443]
    /// </summary>
    public bool? SimultaneousIssuanceIndicator2015 { get => _simultaneousIssuanceIndicator2015; set => SetField(ref _simultaneousIssuanceIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract TaxesIndicator2015
    /// </summary>
    public bool? TaxesIndicator2015 { get => _taxesIndicator2015; set => SetField(ref _taxesIndicator2015, value); }

    /// <summary>
    /// Gfe2010FeeContract TitleServiceSelectIndicator
    /// </summary>
    public bool? TitleServiceSelectIndicator { get => _titleServiceSelectIndicator; set => SetField(ref _titleServiceSelectIndicator, value); }

    /// <summary>
    /// Gfe2010FeeContract TotalFeeAmount2015
    /// </summary>
    public decimal? TotalFeeAmount2015 { get => _totalFeeAmount2015; set => SetField(ref _totalFeeAmount2015, value); }

    /// <summary>
    /// Gfe2010FeeContract TotalFeePercentage2015
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? TotalFeePercentage2015 { get => _totalFeePercentage2015; set => SetField(ref _totalFeePercentage2015, value); }

    /// <summary>
    /// Gfe2010FeeContract TotalPaidByBLo2015
    /// </summary>
    public decimal? TotalPaidByBLo2015 { get => _totalPaidByBLo2015; set => SetField(ref _totalPaidByBLo2015, value); }

    /// <summary>
    /// Gfe2010FeeContract UndiscountedInsurance2015 [NEWHUD2.X4442], [NEWHUD2.X4444]
    /// </summary>
    public decimal? UndiscountedInsurance2015 { get => _undiscountedInsurance2015; set => SetField(ref _undiscountedInsurance2015, value); }

    /// <summary>
    /// Gfe2010FeeContract WholePoc
    /// </summary>
    public decimal? WholePoc { get => _wholePoc; set => SetField(ref _wholePoc, value); }

    /// <summary>
    /// Gfe2010FeeContract WholePocPaidByType
    /// </summary>
    public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => SetField(ref _wholePocPaidByType, value); }
}