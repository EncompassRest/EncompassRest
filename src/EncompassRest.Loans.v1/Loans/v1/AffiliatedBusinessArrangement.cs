using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AffiliatedBusinessArrangement
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AffiliatedBusinessArrangement : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AffiliatedBusinessArrangement AffiliatedBusinessArrangementIndex
    /// </summary>
    public int? AffiliatedBusinessArrangementIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Affiliate Name [ABNN06]
    /// </summary>
    public string? AffiliateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 1 [ABNN16]
    /// </summary>
    public string? ChargeRangeChargesDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 2 [ABNN17]
    /// </summary>
    public string? ChargeRangeChargesDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 3 [ABNN18]
    /// </summary>
    public string? ChargeRangeChargesDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 4 [ABNN19]
    /// </summary>
    public string? ChargeRangeChargesDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 5 [ABNN20]
    /// </summary>
    public string? ChargeRangeChargesDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 6 [ABNN21]
    /// </summary>
    public string? ChargeRangeChargesDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AffiliatedBusinessArrangement Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address [ABNN02]
    /// </summary>
    public string? LenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address City [ABNN03]
    /// </summary>
    public string? LenderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address State [ABNN04]
    /// </summary>
    public StringEnumValue<State> LenderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address Zipcode [ABNN05]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LenderAddressZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender Name [ABNN01]
    /// </summary>
    public string? LenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Nature of Relationship [ABNN07]
    /// </summary>
    public string? NatureOfRelationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Percentage of Ownership Interest [ABNN28]
    /// </summary>
    public decimal? PercentOwnershipInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Purchase/Sale/Refinance Indicator [ABNN09]
    /// </summary>
    public bool? PurchaseSaleRefinanceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 1 [ABNN22]
    /// </summary>
    public bool? RequiredUseIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 2 [ABNN23]
    /// </summary>
    public bool? RequiredUseIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 3 [ABNN24]
    /// </summary>
    public bool? RequiredUseIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 4 [ABNN25]
    /// </summary>
    public bool? RequiredUseIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 5 [ABNN26]
    /// </summary>
    public bool? RequiredUseIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 6 [ABNN27]
    /// </summary>
    public bool? RequiredUseIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 1 [ABNN10]
    /// </summary>
    public string? ServiceDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 2 [ABNN11]
    /// </summary>
    public string? ServiceDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 3 [ABNN12]
    /// </summary>
    public string? ServiceDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 4 [ABNN13]
    /// </summary>
    public string? ServiceDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 5 [ABNN14]
    /// </summary>
    public string? ServiceDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 6 [ABNN15]
    /// </summary>
    public string? ServiceDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Settlement Indicator [ABNN08]
    /// </summary>
    public bool? SettlementIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}