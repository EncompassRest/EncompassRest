namespace EncompassRest.Loans.v1;

/// <summary>
/// Disclosure
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Disclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CD Appraisal Fee [DISCNN20]
    /// </summary>
    public decimal? CdAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Credit Report Fee [DISCNN17]
    /// </summary>
    public decimal? CdCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Loan Discount Fee [DISCNN14]
    /// </summary>
    public decimal? CdLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Non Shoppable Services [DISCNN05]
    /// </summary>
    public decimal? CdNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Origination Charges [DISCNN02]
    /// </summary>
    public decimal? CdOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Shoppable Services [DISCNN08]
    /// </summary>
    public decimal? CdShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD Taxes and Goveernment Fees [DISCNN11]
    /// </summary>
    public decimal? CdTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure DisclosureIndex
    /// </summary>
    public int? DisclosureIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Appraisal Fee [DISCNN19]
    /// </summary>
    public decimal? LeAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Credit Report Fee [DISCNN16]
    /// </summary>
    public decimal? LeCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Loan Discount Fee [DISCNN13]
    /// </summary>
    public decimal? LeLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Non Shoppable Services [DISCNN04]
    /// </summary>
    public decimal? LeNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Origination Charges [DISCNN01]
    /// </summary>
    public decimal? LeOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Shoppable Services [DISCNN07]
    /// </summary>
    public decimal? LeShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Taxes and Goveernment Fees [DISCNN10]
    /// </summary>
    public decimal? LeTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Appraisal Fee [DISCNN21]
    /// </summary>
    public decimal? PcAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Credit Report Fee [DISCNN18]
    /// </summary>
    public decimal? PcCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Loan Discount Fee [DISCNN15]
    /// </summary>
    public decimal? PcLoanDiscountFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Non Shoppable Services [DISCNN06]
    /// </summary>
    public decimal? PcNonShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Origination Charges [DISCNN03]
    /// </summary>
    public decimal? PcOriginationCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Shoppable Services [DISCNN09]
    /// </summary>
    public decimal? PcShoppableServices { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// PC Taxes and Goveernment Fees [DISCNN12]
    /// </summary>
    public decimal? PcTaxesGovtFees { get => GetValue<decimal?>(); set => SetValue(value); }
}