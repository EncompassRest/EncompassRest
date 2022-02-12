using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ClosingDisclosure4
/// </summary>
public sealed partial class ClosingDisclosure4 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<DemandFeature>>? _demandFeature;
    private DirtyValue<StringEnumValue<EscrowedPropertyCostsBasis>>? _escrowedPropertyCostsBasis;
    private DirtyValue<bool?>? _escrowIndicator;
    private DirtyValue<decimal?>? _estimatedPropertyCosts;
    private DirtyValue<string?>? _firstChangeAmt;
    private DirtyValue<decimal?>? _firstChangeMaxAmt;
    private DirtyValue<decimal?>? _firstChangeMinAmt;
    private DirtyValue<string?>? _firstChangePayment;
    private DirtyValue<bool?>? _hOADuesIsEscrow;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _ignoreARMAdj;
    private DirtyValue<decimal?>? _initialEscrowPayment;
    private DirtyValue<int?>? _interestOnlyPaymentMonths;
    private DirtyValue<bool?>? _interestOnlyPayments;
    private DirtyValue<int?>? _interestRateAdjustments;
    private DirtyValue<bool?>? _lender;
    private DirtyValue<int?>? _maximumARMPaymentAmount;
    private DirtyValue<int?>? _maximumARMPaymentMonthReached;
    private DirtyValue<string?>? _maximumPaymentAmt;
    private DirtyValue<string?>? _maxPayment;
    private DirtyValue<decimal?>? _maxPaymentAmt;
    private DirtyValue<decimal?>? _monthlyEscrowPayment;
    private DirtyValue<StringEnumValue<NegativeAmortization>>? _negativeAmortization;
    private DirtyValue<decimal?>? _nonEscrowedPropertyCosts1YearConsummation;
    private DirtyValue<bool?>? _other1;
    private DirtyValue<bool?>? _other2;
    private DirtyValue<bool?>? _other3;
    private DirtyValue<string?>? _partialPayment;
    private DirtyValue<string?>? _partialPaymentHoldUntilComplete;
    private DirtyValue<string?>? _partialPaymentNone;
    private DirtyValue<string?>? _seasonalPaymentFromYr;
    private DirtyValue<bool?>? _seasonalPayments;
    private DirtyValue<int?>? _stepPayment;
    private DirtyValue<bool?>? _stepPayments;
    private DirtyValue<decimal?>? _stepRateFirstChange;
    private DirtyValue<string?>? _subsequentChanges;
    private DirtyValue<decimal?>? _totalDisbursed1YearConsummation;

    /// <summary>
    /// Demand Feature [CD4.X1]
    /// </summary>
    public StringEnumValue<DemandFeature> DemandFeature { get => _demandFeature; set => SetField(ref _demandFeature, value); }

    /// <summary>
    /// Escrowed Property Costs Basis [CD4.X51]
    /// </summary>
    public StringEnumValue<EscrowedPropertyCostsBasis> EscrowedPropertyCostsBasis { get => _escrowedPropertyCostsBasis; set => SetField(ref _escrowedPropertyCostsBasis, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Escrow Indicator [CD4.X9]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Escrow (T&I)\"}")]
    public bool? EscrowIndicator { get => _escrowIndicator; set => SetField(ref _escrowIndicator, value); }

    /// <summary>
    /// Estimated Property Costs [CD4.X8]
    /// </summary>
    public decimal? EstimatedPropertyCosts { get => _estimatedPropertyCosts; set => SetField(ref _estimatedPropertyCosts, value); }

    /// <summary>
    /// First Change Min Amount [CD4.X30]
    /// </summary>
    public string? FirstChangeAmt { get => _firstChangeAmt; set => SetField(ref _firstChangeAmt, value); }

    /// <summary>
    /// First Change Max Amt [CD4.X36]
    /// </summary>
    public decimal? FirstChangeMaxAmt { get => _firstChangeMaxAmt; set => SetField(ref _firstChangeMaxAmt, value); }

    /// <summary>
    /// First Change Min Amt [CD4.X35]
    /// </summary>
    public decimal? FirstChangeMinAmt { get => _firstChangeMinAmt; set => SetField(ref _firstChangeMinAmt, value); }

    /// <summary>
    /// FirstChange Payment [CD4.X37]
    /// </summary>
    public string? FirstChangePayment { get => _firstChangePayment; set => SetField(ref _firstChangePayment, value); }

    /// <summary>
    /// Closing Disclosure Page 4 - Is HOA Dues Escrow [CD4.X45]
    /// </summary>
    public bool? HOADuesIsEscrow { get => _hOADuesIsEscrow; set => SetField(ref _hOADuesIsEscrow, value); }

    /// <summary>
    /// ClosingDisclosure4 Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Ignore 1st ARM Adjustment [CD4.X31]
    /// </summary>
    public bool? IgnoreARMAdj { get => _ignoreARMAdj; set => SetField(ref _ignoreARMAdj, value); }

    /// <summary>
    /// Closing Disclosure Page 4 - Initial Escrow Payment [CD4.X44]
    /// </summary>
    public decimal? InitialEscrowPayment { get => _initialEscrowPayment; set => SetField(ref _initialEscrowPayment, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Interest Only Payment Months [CD4.X46]
    /// </summary>
    public int? InterestOnlyPaymentMonths { get => _interestOnlyPaymentMonths; set => SetField(ref _interestOnlyPaymentMonths, value); }

    /// <summary>
    /// Interest Only Payments [CD4.X23]
    /// </summary>
    public bool? InterestOnlyPayments { get => _interestOnlyPayments; set => SetField(ref _interestOnlyPayments, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Interest Rate Adjustments [CD4.X47]
    /// </summary>
    public int? InterestRateAdjustments { get => _interestRateAdjustments; set => SetField(ref _interestRateAdjustments, value); }

    /// <summary>
    /// your lender does not offer one. [CD4.X7]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"your lender does not offer one\"}")]
    public bool? Lender { get => _lender; set => SetField(ref _lender, value); }

    /// <summary>
    /// Maximum ARM Payment Amount [CD4.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MaximumARMPaymentAmount { get => _maximumARMPaymentAmount; set => SetField(ref _maximumARMPaymentAmount, value); }

    /// <summary>
    /// Maximum ARM Payment Month Reached [CD4.X50]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MaximumARMPaymentMonthReached { get => _maximumARMPaymentMonthReached; set => SetField(ref _maximumARMPaymentMonthReached, value); }

    /// <summary>
    /// Maximum Payment Amount [CD4.X34]
    /// </summary>
    public string? MaximumPaymentAmt { get => _maximumPaymentAmt; set => SetField(ref _maximumPaymentAmt, value); }

    /// <summary>
    /// Max Payment [CD4.X39]
    /// </summary>
    public string? MaxPayment { get => _maxPayment; set => SetField(ref _maxPayment, value); }

    /// <summary>
    /// Max payment Amt [CD4.X38]
    /// </summary>
    public decimal? MaxPaymentAmt { get => _maxPaymentAmt; set => SetField(ref _maxPaymentAmt, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Monthly Escrow Payment [CD4.X10]
    /// </summary>
    public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => SetField(ref _monthlyEscrowPayment, value); }

    /// <summary>
    /// Negative Amortization [CD4.X2]
    /// </summary>
    public StringEnumValue<NegativeAmortization> NegativeAmortization { get => _negativeAmortization; set => SetField(ref _negativeAmortization, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Non-Escrowed Property Costs Within 1 Year of Consummation [CD4.X41]
    /// </summary>
    public decimal? NonEscrowedPropertyCosts1YearConsummation { get => _nonEscrowedPropertyCosts1YearConsummation; set => SetField(ref _nonEscrowedPropertyCosts1YearConsummation, value); }

    /// <summary>
    /// Escrow Other1 [CD4.X4]
    /// </summary>
    public bool? Other1 { get => _other1; set => SetField(ref _other1, value); }

    /// <summary>
    /// Escrow Other2 [CD4.X5]
    /// </summary>
    public bool? Other2 { get => _other2; set => SetField(ref _other2, value); }

    /// <summary>
    /// Escrow Other3 [CD4.X6]
    /// </summary>
    public bool? Other3 { get => _other3; set => SetField(ref _other3, value); }

    /// <summary>
    /// Partial Payments - Apply Partial Payment [CD4.X3]
    /// </summary>
    public string? PartialPayment { get => _partialPayment; set => SetField(ref _partialPayment, value); }

    /// <summary>
    /// Partial Payments - Hold Until Complete [CD4.X42]
    /// </summary>
    public string? PartialPaymentHoldUntilComplete { get => _partialPaymentHoldUntilComplete; set => SetField(ref _partialPaymentHoldUntilComplete, value); }

    /// <summary>
    /// Partial Payments - None [CD4.X43]
    /// </summary>
    public string? PartialPaymentNone { get => _partialPaymentNone; set => SetField(ref _partialPaymentNone, value); }

    /// <summary>
    /// Seasonal Payment From Year [CD4.X28]
    /// </summary>
    public string? SeasonalPaymentFromYr { get => _seasonalPaymentFromYr; set => SetField(ref _seasonalPaymentFromYr, value); }

    /// <summary>
    /// Seasonal Payments [CD4.X27]
    /// </summary>
    public bool? SeasonalPayments { get => _seasonalPayments; set => SetField(ref _seasonalPayments, value); }

    /// <summary>
    /// Step Payment [CD4.X26]
    /// </summary>
    public int? StepPayment { get => _stepPayment; set => SetField(ref _stepPayment, value); }

    /// <summary>
    /// Step Payments [CD4.X25]
    /// </summary>
    public bool? StepPayments { get => _stepPayments; set => SetField(ref _stepPayments, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Step Rate First Change [CD4.X48]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? StepRateFirstChange { get => _stepRateFirstChange; set => SetField(ref _stepRateFirstChange, value); }

    /// <summary>
    /// Subsequent Changes [CD4.X33]
    /// </summary>
    public string? SubsequentChanges { get => _subsequentChanges; set => SetField(ref _subsequentChanges, value); }

    /// <summary>
    /// Closing Disclosure Page 4 Escrowed Property Costs Within 1 Year of Consummation [CD4.X40]
    /// </summary>
    public decimal? TotalDisbursed1YearConsummation { get => _totalDisbursed1YearConsummation; set => SetField(ref _totalDisbursed1YearConsummation, value); }
}