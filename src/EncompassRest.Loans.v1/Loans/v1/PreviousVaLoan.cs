using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PreviousVaLoan
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(PreviousVaLoanIndex))]
public sealed partial class PreviousVaLoan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PreviousVaLoan DateOfLoan
    /// </summary>
    public DateTime? DateOfLoan { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan DateSold
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? DateSold { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan LoanType
    /// </summary>
    public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => GetValue<StringEnumValue<PreviousVaLoanLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PreviousVaLoanIndex
    /// </summary>
    public int? PreviousVaLoanIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyCity
    /// </summary>
    public string? PropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyOwned
    /// </summary>
    [LoanFieldProperty(ReadOnly = true, OptionsJson = "{\"Y\":\"Property Owned\"}")]
    public bool? PropertyOwned { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyState
    /// </summary>
    public StringEnumValue<State> PropertyState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan VALoanNumber
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VALoanNumber { get => GetValue<string?>(); set => SetValue(value); }
}