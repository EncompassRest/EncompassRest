using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AffiliatedBusinessArrangement
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AffiliatedBusinessArrangement : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Affiliated Business Arrangements - Affiliate Name [AB0006]
    /// </summary>
    public string? AffiliateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AffiliatedBusinessArrangement AltId
    /// </summary>
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 1 [AB0016]
    /// </summary>
    public string? ChargeRangeChargesDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 2 [AB0017]
    /// </summary>
    public string? ChargeRangeChargesDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 3 [AB0018]
    /// </summary>
    public string? ChargeRangeChargesDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 4 [AB0019]
    /// </summary>
    public string? ChargeRangeChargesDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 5 [AB0020]
    /// </summary>
    public string? ChargeRangeChargesDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Charge or Range of Charges Line 6 [AB0021]
    /// </summary>
    public string? ChargeRangeChargesDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AffiliatedBusinessArrangement Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address [AB0002]
    /// </summary>
    public string? LenderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address City [AB0003]
    /// </summary>
    public string? LenderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address State [AB0004]
    /// </summary>
    public string? LenderAddressState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender's Address Zipcode [AB0005]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LenderAddressZipcode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Lender Name [AB0001]
    /// </summary>
    public string? LenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Nature of Relationship [AB0007]
    /// </summary>
    public string? NatureOfRelationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Percentage of Ownership Interest [AB0028]
    /// </summary>
    public decimal? PercentOwnershipInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Purchase/Sale/Refinance Indicator [AB0009]
    /// </summary>
    public bool? PurchaseSaleRefinanceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 1 [AB0022]
    /// </summary>
    public bool? RequiredUseIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 2 [AB0023]
    /// </summary>
    public bool? RequiredUseIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 3 [AB0024]
    /// </summary>
    public bool? RequiredUseIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 4 [AB0025]
    /// </summary>
    public bool? RequiredUseIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 5 [AB0026]
    /// </summary>
    public bool? RequiredUseIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Required Use Indicator Line 6 [AB0027]
    /// </summary>
    public bool? RequiredUseIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 1 [AB0010]
    /// </summary>
    public string? ServiceDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 2 [AB0011]
    /// </summary>
    public string? ServiceDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 3 [AB0012]
    /// </summary>
    public string? ServiceDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 4 [AB0013]
    /// </summary>
    public string? ServiceDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 5 [AB0014]
    /// </summary>
    public string? ServiceDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Service Description Line 6 [AB0015]
    /// </summary>
    public string? ServiceDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Affiliated Business Arrangements - Settlement Indicator [AB0008]
    /// </summary>
    public bool? SettlementIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}