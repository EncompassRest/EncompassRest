using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// LoanSubmissionFee
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(LoanSubmissionFeeType))]
public sealed partial class LoanSubmissionFee : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _description;
    private DirtyValue<decimal?>? _dueBroker;
    private DirtyValue<decimal?>? _dueLender;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<LoanSubmissionFeeType>>? _loanSubmissionFeeType;
    private DirtyValue<decimal?>? _total;

    /// <summary>
    /// LoanSubmissionFee Description
    /// </summary>
    public string? Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// LoanSubmissionFee DueBroker
    /// </summary>
    public decimal? DueBroker { get => _dueBroker; set => SetField(ref _dueBroker, value); }

    /// <summary>
    /// LoanSubmissionFee DueLender
    /// </summary>
    public decimal? DueLender { get => _dueLender; set => SetField(ref _dueLender, value); }

    /// <summary>
    /// LoanSubmissionFee Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// LoanSubmissionFee LoanSubmissionFeeType
    /// </summary>
    public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => _loanSubmissionFeeType; set => SetField(ref _loanSubmissionFeeType, value); }

    /// <summary>
    /// LoanSubmissionFee Total
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => _total; set => SetField(ref _total, value); }
}