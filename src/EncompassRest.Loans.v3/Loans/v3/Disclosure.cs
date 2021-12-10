namespace EncompassRest.Loans.v3;

/// <summary>
/// Disclosure
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Disclosure : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _cdAppraisalFee;
    private DirtyValue<decimal?>? _cdCreditReportFee;
    private DirtyValue<decimal?>? _cdLoanDiscountFee;
    private DirtyValue<decimal?>? _cdNonShoppableServices;
    private DirtyValue<decimal?>? _cdOriginationCharges;
    private DirtyValue<decimal?>? _cdShoppableServices;
    private DirtyValue<decimal?>? _cdTaxesGovtFees;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _leAppraisalFee;
    private DirtyValue<decimal?>? _leCreditReportFee;
    private DirtyValue<decimal?>? _leLoanDiscountFee;
    private DirtyValue<decimal?>? _leNonShoppableServices;
    private DirtyValue<decimal?>? _leOriginationCharges;
    private DirtyValue<decimal?>? _leShoppableServices;
    private DirtyValue<decimal?>? _leTaxesGovtFees;
    private DirtyValue<decimal?>? _pcAppraisalFee;
    private DirtyValue<decimal?>? _pcCreditReportFee;
    private DirtyValue<decimal?>? _pcLoanDiscountFee;
    private DirtyValue<decimal?>? _pcNonShoppableServices;
    private DirtyValue<decimal?>? _pcOriginationCharges;
    private DirtyValue<decimal?>? _pcShoppableServices;
    private DirtyValue<decimal?>? _pcTaxesGovtFees;

    /// <summary>
    /// CD Appraisal Fee [DISC0020]
    /// </summary>
    public decimal? CdAppraisalFee { get => _cdAppraisalFee; set => SetField(ref _cdAppraisalFee, value); }

    /// <summary>
    /// CD Credit Report Fee [DISC0017]
    /// </summary>
    public decimal? CdCreditReportFee { get => _cdCreditReportFee; set => SetField(ref _cdCreditReportFee, value); }

    /// <summary>
    /// CD Loan Discount Fee [DISC0014]
    /// </summary>
    public decimal? CdLoanDiscountFee { get => _cdLoanDiscountFee; set => SetField(ref _cdLoanDiscountFee, value); }

    /// <summary>
    /// CD Non Shoppable Services [DISC0005]
    /// </summary>
    public decimal? CdNonShoppableServices { get => _cdNonShoppableServices; set => SetField(ref _cdNonShoppableServices, value); }

    /// <summary>
    /// CD Origination Charges [DISC0002]
    /// </summary>
    public decimal? CdOriginationCharges { get => _cdOriginationCharges; set => SetField(ref _cdOriginationCharges, value); }

    /// <summary>
    /// CD Shoppable Services [DISC0008]
    /// </summary>
    public decimal? CdShoppableServices { get => _cdShoppableServices; set => SetField(ref _cdShoppableServices, value); }

    /// <summary>
    /// CD Taxes and Goveernment Fees [DISC0011]
    /// </summary>
    public decimal? CdTaxesGovtFees { get => _cdTaxesGovtFees; set => SetField(ref _cdTaxesGovtFees, value); }

    /// <summary>
    /// DisclosureContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LE Appraisal Fee [DISC0019]
    /// </summary>
    public decimal? LeAppraisalFee { get => _leAppraisalFee; set => SetField(ref _leAppraisalFee, value); }

    /// <summary>
    /// LE Credit Report Fee [DISC0016]
    /// </summary>
    public decimal? LeCreditReportFee { get => _leCreditReportFee; set => SetField(ref _leCreditReportFee, value); }

    /// <summary>
    /// LE Loan Discount Fee [DISC0013]
    /// </summary>
    public decimal? LeLoanDiscountFee { get => _leLoanDiscountFee; set => SetField(ref _leLoanDiscountFee, value); }

    /// <summary>
    /// LE Non Shoppable Services [DISC0004]
    /// </summary>
    public decimal? LeNonShoppableServices { get => _leNonShoppableServices; set => SetField(ref _leNonShoppableServices, value); }

    /// <summary>
    /// LE Origination Charges [DISC0001]
    /// </summary>
    public decimal? LeOriginationCharges { get => _leOriginationCharges; set => SetField(ref _leOriginationCharges, value); }

    /// <summary>
    /// LE Shoppable Services [DISC0007]
    /// </summary>
    public decimal? LeShoppableServices { get => _leShoppableServices; set => SetField(ref _leShoppableServices, value); }

    /// <summary>
    /// LE Taxes and Goveernment Fees [DISC0010]
    /// </summary>
    public decimal? LeTaxesGovtFees { get => _leTaxesGovtFees; set => SetField(ref _leTaxesGovtFees, value); }

    /// <summary>
    /// PC Appraisal Fee [DISC0021]
    /// </summary>
    public decimal? PcAppraisalFee { get => _pcAppraisalFee; set => SetField(ref _pcAppraisalFee, value); }

    /// <summary>
    /// PC Credit Report Fee [DISC0018]
    /// </summary>
    public decimal? PcCreditReportFee { get => _pcCreditReportFee; set => SetField(ref _pcCreditReportFee, value); }

    /// <summary>
    /// PC Loan Discount Fee [DISC0015]
    /// </summary>
    public decimal? PcLoanDiscountFee { get => _pcLoanDiscountFee; set => SetField(ref _pcLoanDiscountFee, value); }

    /// <summary>
    /// PC Non Shoppable Services [DISC0006]
    /// </summary>
    public decimal? PcNonShoppableServices { get => _pcNonShoppableServices; set => SetField(ref _pcNonShoppableServices, value); }

    /// <summary>
    /// PC Origination Charges [DISC0003]
    /// </summary>
    public decimal? PcOriginationCharges { get => _pcOriginationCharges; set => SetField(ref _pcOriginationCharges, value); }

    /// <summary>
    /// PC Shoppable Services [DISC0009]
    /// </summary>
    public decimal? PcShoppableServices { get => _pcShoppableServices; set => SetField(ref _pcShoppableServices, value); }

    /// <summary>
    /// PC Taxes and Goveernment Fees [DISC0012]
    /// </summary>
    public decimal? PcTaxesGovtFees { get => _pcTaxesGovtFees; set => SetField(ref _pcTaxesGovtFees, value); }
}