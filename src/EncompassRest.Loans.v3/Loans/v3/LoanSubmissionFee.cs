using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanSubmissionFee
/// </summary>
public sealed partial class LoanSubmissionFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _dueBroker;
    private DirtyValue<decimal?>? _dueLender;
    private DirtyValue<StringEnumValue<LoanSubmissionFeeType>>? _loanSubmissionFeeType;
    private DirtyValue<decimal?>? _total;

    /// <summary>
    /// LoanSubmissionFeeContract Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// LoanSubmissionFeeContract DueBroker
    /// </summary>
    public decimal? DueBroker { get => _dueBroker; set => SetField(ref _dueBroker, value); }

    /// <summary>
    /// LoanSubmissionFeeContract DueLender
    /// </summary>
    public decimal? DueLender { get => _dueLender; set => SetField(ref _dueLender, value); }

    /// <summary>
    /// LoanSubmissionFeeContract LoanSubmissionFeeType
    /// </summary>
    public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => _loanSubmissionFeeType; set => SetField(ref _loanSubmissionFeeType, value); }

    /// <summary>
    /// LoanSubmissionFeeContract Total
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => _total; set => SetField(ref _total, value); }
}