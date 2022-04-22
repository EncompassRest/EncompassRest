namespace EncompassRest.Loans.v1;

/// <summary>
/// FundingFee
/// </summary>
public sealed partial class FundingFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// FundingFee Amount
    /// </summary>
    public decimal? Amount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee BalanceChecked
    /// </summary>
    public bool? BalanceChecked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee CdLineId
    /// </summary>
    public string? CdLineId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee FeeDescription
    /// </summary>
    public string? FeeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee FeeDescription2015
    /// </summary>
    public string? FeeDescription2015 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee LineId
    /// </summary>
    public string? LineId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee LineNumber
    /// </summary>
    public int? LineNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PacBroker2015
    /// </summary>
    public decimal? PacBroker2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PacLender2015
    /// </summary>
    public decimal? PacLender2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PacOther2015
    /// </summary>
    public decimal? PacOther2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PaidBy
    /// </summary>
    public string? PaidBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PaidTo
    /// </summary>
    public string? PaidTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee Payee
    /// </summary>
    public string? Payee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocAmount
    /// </summary>
    public decimal? PocAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocBorrower2015
    /// </summary>
    public decimal? PocBorrower2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocBroker2015
    /// </summary>
    public decimal? PocBroker2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocLender2015
    /// </summary>
    public decimal? PocLender2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocOther2015
    /// </summary>
    public decimal? PocOther2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocPaidBy
    /// </summary>
    public string? PocPaidBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PocSeller2015
    /// </summary>
    public decimal? PocSeller2015 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PtcAmount
    /// </summary>
    public decimal? PtcAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// FundingFee PtcPaidBy
    /// </summary>
    public string? PtcPaidBy { get => GetValue<string?>(); set => SetValue(value); }
}