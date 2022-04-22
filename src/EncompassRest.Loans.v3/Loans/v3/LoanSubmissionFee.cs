using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// LoanSubmissionFee
/// </summary>
public sealed partial class LoanSubmissionFee : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// LoanSubmissionFee Description
    /// </summary>
    public string? Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LoanSubmissionFee DueBroker
    /// </summary>
    public decimal? DueBroker { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanSubmissionFee DueLender
    /// </summary>
    public decimal? DueLender { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LoanSubmissionFee LoanSubmissionFeeType
    /// </summary>
    public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => GetValue<StringEnumValue<LoanSubmissionFeeType>>(); set => SetValue(value); }

    /// <summary>
    /// LoanSubmissionFee Total
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Total { get => GetValue<decimal?>(); set => SetValue(value); }
}