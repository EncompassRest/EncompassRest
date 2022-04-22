using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosure4
/// </summary>
public sealed partial class ClosingDisclosure4 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Demand Feature [CD4.X1]
    /// </summary>
    public StringEnumValue<DemandFeature> DemandFeature { get => GetValue<StringEnumValue<DemandFeature>>(); set => SetValue(value); }

    /// <summary>
    /// Escrowed Property Costs Basis [CD4.X51]
    /// </summary>
    public StringEnumValue<EscrowedPropertyCostsBasis> EscrowedPropertyCostsBasis { get => GetValue<StringEnumValue<EscrowedPropertyCostsBasis>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Escrow Indicator [CD4.X9]
    /// </summary>
    public bool? EscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Estimated Property Costs [CD4.X8]
    /// </summary>
    public decimal? EstimatedPropertyCosts { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// First Change Min Amount [CD4.X30]
    /// </summary>
    public string? FirstChangeAmt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// First Change Max Amt [CD4.X36]
    /// </summary>
    public decimal? FirstChangeMaxAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// First Change Min Amt [CD4.X35]
    /// </summary>
    public decimal? FirstChangeMinAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FirstChange Payment [CD4.X37]
    /// </summary>
    public string? FirstChangePayment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 - Is HOA Dues Escrow [CD4.X45]
    /// </summary>
    public bool? HoaDuesIsEscrow { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Ignore 1st ARM Adjustment [CD4.X31]
    /// </summary>
    public bool? IgnoreArmAdj { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 - Initial Escrow Payment [CD4.X44]
    /// </summary>
    public decimal? InitialEscrowPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Interest Only Payment Months [CD4.X46]
    /// </summary>
    public int? InterestOnlyPaymentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Interest Only Payments [CD4.X23]
    /// </summary>
    public bool? InterestOnlyPayments { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Interest Rate Adjustments [CD4.X47]
    /// </summary>
    public int? InterestRateAdjustments { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// your lender does not offer one. [CD4.X7]
    /// </summary>
    public bool? Lender { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum ARM Payment Amount [CD4.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MaximumArmPaymentAmount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum ARM Payment Month Reached [CD4.X50]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? MaximumArmPaymentMonthReached { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Maximum Payment Amount [CD4.X34]
    /// </summary>
    public string? MaximumPaymentAmt { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Max Payment [CD4.X39]
    /// </summary>
    public string? MaxPayment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Max payment Amt [CD4.X38]
    /// </summary>
    public decimal? MaxPaymentAmt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Monthly Escrow Payment [CD4.X10]
    /// </summary>
    public decimal? MonthlyEscrowPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Negative Amortization [CD4.X2]
    /// </summary>
    public StringEnumValue<NegativeAmortization> NegativeAmortization { get => GetValue<StringEnumValue<NegativeAmortization>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Non-Escrowed Property Costs Within 1 Year of Consummation [CD4.X41]
    /// </summary>
    public decimal? NonEscrowedPropertyCosts1YearConsummation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Other1 [CD4.X4]
    /// </summary>
    public bool? Other1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Other2 [CD4.X5]
    /// </summary>
    public bool? Other2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Escrow Other3 [CD4.X6]
    /// </summary>
    public bool? Other3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Partial Payments - Apply Partial Payment [CD4.X3]
    /// </summary>
    public string? PartialPayment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Partial Payments - Hold Until Complete [CD4.X42]
    /// </summary>
    public string? PartialPaymentHoldUntilComplete { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Partial Payments - None [CD4.X43]
    /// </summary>
    public string? PartialPaymentNone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Seasonal Payment From Year [CD4.X28]
    /// </summary>
    public string? SeasonalPaymentFromYr { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Seasonal Payments [CD4.X27]
    /// </summary>
    public bool? SeasonalPayments { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Step Payment [CD4.X26]
    /// </summary>
    public int? StepPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Step Payments [CD4.X25]
    /// </summary>
    public bool? StepPayments { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Step Rate First Change [CD4.X48]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? StepRateFirstChange { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Subsequent Changes [CD4.X33]
    /// </summary>
    public string? SubsequentChanges { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Page 4 Escrowed Property Costs Within 1 Year of Consummation [CD4.X40]
    /// </summary>
    public decimal? TotalDisbursed1YearConsummation { get => GetValue<decimal?>(); set => SetValue(value); }
}