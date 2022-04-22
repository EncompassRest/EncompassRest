namespace EncompassRest.Loans.v3;

/// <summary>
/// Disclosure
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Disclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CD Appraisal Fee [DISC0020]
    /// </summary>
    public decimal? CdAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Credit Report Fee [DISC0017]
    /// </summary>
    public decimal? CdCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Loan Discount Fee [DISC0014]
    /// </summary>
    public decimal? CdLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Non Shoppable Services [DISC0005]
    /// </summary>
    public decimal? CdNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Origination Charges [DISC0002]
    /// </summary>
    public decimal? CdOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Shoppable Services [DISC0008]
    /// </summary>
    public decimal? CdShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Taxes and Goveernment Fees [DISC0011]
    /// </summary>
    public decimal? CdTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Appraisal Fee [DISC0019]
    /// </summary>
    public decimal? LeAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Credit Report Fee [DISC0016]
    /// </summary>
    public decimal? LeCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Loan Discount Fee [DISC0013]
    /// </summary>
    public decimal? LeLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Non Shoppable Services [DISC0004]
    /// </summary>
    public decimal? LeNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Origination Charges [DISC0001]
    /// </summary>
    public decimal? LeOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Shoppable Services [DISC0007]
    /// </summary>
    public decimal? LeShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Taxes and Goveernment Fees [DISC0010]
    /// </summary>
    public decimal? LeTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Appraisal Fee [DISC0021]
    /// </summary>
    public decimal? PcAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Credit Report Fee [DISC0018]
    /// </summary>
    public decimal? PcCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Loan Discount Fee [DISC0015]
    /// </summary>
    public decimal? PcLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Non Shoppable Services [DISC0006]
    /// </summary>
    public decimal? PcNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Origination Charges [DISC0003]
    /// </summary>
    public decimal? PcOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Shoppable Services [DISC0009]
    /// </summary>
    public decimal? PcShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Taxes and Goveernment Fees [DISC0012]
    /// </summary>
    public decimal? PcTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }
}