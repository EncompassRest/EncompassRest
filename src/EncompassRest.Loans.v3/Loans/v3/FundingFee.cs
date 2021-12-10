namespace EncompassRest.Loans.v3;

/// <summary>
/// FundingFee
/// </summary>
public sealed partial class FundingFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<bool?>? _balanceChecked;
    private DirtyValue<string?>? _cdLineId;
    private DirtyValue<string?>? _feeDescription;
    private DirtyValue<string?>? _feeDescription2015;
    private DirtyValue<string?>? _lineId;
    private DirtyValue<int?>? _lineNumber;
    private DirtyValue<decimal?>? _pacBroker2015;
    private DirtyValue<decimal?>? _pacLender2015;
    private DirtyValue<decimal?>? _pacOther2015;
    private DirtyValue<string?>? _paidBy;
    private DirtyValue<string?>? _paidTo;
    private DirtyValue<string?>? _payee;
    private DirtyValue<decimal?>? _pocAmount;
    private DirtyValue<decimal?>? _pocBorrower2015;
    private DirtyValue<decimal?>? _pocBroker2015;
    private DirtyValue<decimal?>? _pocLender2015;
    private DirtyValue<decimal?>? _pocOther2015;
    private DirtyValue<string?>? _pocPaidBy;
    private DirtyValue<decimal?>? _pocSeller2015;
    private DirtyValue<decimal?>? _ptcAmount;
    private DirtyValue<string?>? _ptcPaidBy;

    /// <summary>
    /// FundingFeeContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// FundingFeeContract BalanceChecked
    /// </summary>
    public bool? BalanceChecked { get => _balanceChecked; set => SetField(ref _balanceChecked, value); }

    /// <summary>
    /// FundingFeeContract CdLineId
    /// </summary>
    public string? CdLineId { get => _cdLineId; set => SetField(ref _cdLineId, value); }

    /// <summary>
    /// FundingFeeContract FeeDescription
    /// </summary>
    public string? FeeDescription { get => _feeDescription; set => SetField(ref _feeDescription, value); }

    /// <summary>
    /// FundingFeeContract FeeDescription2015
    /// </summary>
    public string? FeeDescription2015 { get => _feeDescription2015; set => SetField(ref _feeDescription2015, value); }

    /// <summary>
    /// FundingFeeContract LineId
    /// </summary>
    public string? LineId { get => _lineId; set => SetField(ref _lineId, value); }

    /// <summary>
    /// FundingFeeContract LineNumber
    /// </summary>
    public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

    /// <summary>
    /// FundingFeeContract PacBroker2015
    /// </summary>
    public decimal? PacBroker2015 { get => _pacBroker2015; set => SetField(ref _pacBroker2015, value); }

    /// <summary>
    /// FundingFeeContract PacLender2015
    /// </summary>
    public decimal? PacLender2015 { get => _pacLender2015; set => SetField(ref _pacLender2015, value); }

    /// <summary>
    /// FundingFeeContract PacOther2015
    /// </summary>
    public decimal? PacOther2015 { get => _pacOther2015; set => SetField(ref _pacOther2015, value); }

    /// <summary>
    /// FundingFeeContract PaidBy
    /// </summary>
    public string? PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

    /// <summary>
    /// FundingFeeContract PaidTo
    /// </summary>
    public string? PaidTo { get => _paidTo; set => SetField(ref _paidTo, value); }

    /// <summary>
    /// FundingFeeContract Payee
    /// </summary>
    public string? Payee { get => _payee; set => SetField(ref _payee, value); }

    /// <summary>
    /// FundingFeeContract PocAmount
    /// </summary>
    public decimal? PocAmount { get => _pocAmount; set => SetField(ref _pocAmount, value); }

    /// <summary>
    /// FundingFeeContract PocBorrower2015
    /// </summary>
    public decimal? PocBorrower2015 { get => _pocBorrower2015; set => SetField(ref _pocBorrower2015, value); }

    /// <summary>
    /// FundingFeeContract PocBroker2015
    /// </summary>
    public decimal? PocBroker2015 { get => _pocBroker2015; set => SetField(ref _pocBroker2015, value); }

    /// <summary>
    /// FundingFeeContract PocLender2015
    /// </summary>
    public decimal? PocLender2015 { get => _pocLender2015; set => SetField(ref _pocLender2015, value); }

    /// <summary>
    /// FundingFeeContract PocOther2015
    /// </summary>
    public decimal? PocOther2015 { get => _pocOther2015; set => SetField(ref _pocOther2015, value); }

    /// <summary>
    /// FundingFeeContract PocPaidBy
    /// </summary>
    public string? PocPaidBy { get => _pocPaidBy; set => SetField(ref _pocPaidBy, value); }

    /// <summary>
    /// FundingFeeContract PocSeller2015
    /// </summary>
    public decimal? PocSeller2015 { get => _pocSeller2015; set => SetField(ref _pocSeller2015, value); }

    /// <summary>
    /// FundingFeeContract PtcAmount
    /// </summary>
    public decimal? PtcAmount { get => _ptcAmount; set => SetField(ref _ptcAmount, value); }

    /// <summary>
    /// FundingFeeContract PtcPaidBy
    /// </summary>
    public string? PtcPaidBy { get => _ptcPaidBy; set => SetField(ref _ptcPaidBy, value); }
}