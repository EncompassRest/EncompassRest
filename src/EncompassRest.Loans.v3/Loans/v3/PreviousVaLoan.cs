using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PreviousVaLoan
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(PreviousVaLoanIndex))]
public sealed partial class PreviousVaLoan : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// PreviousVaLoan LoanDate
    /// </summary>
    public DateTime? LoanDate { get => GetValue<DateTime?>(); set => SetValue(value); }

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
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Property Owned\"}", ReadOnly = true)]
    public bool? PropertyOwned { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan PropertyState
    /// </summary>
    public string? PropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan SoldDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SoldDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// PreviousVaLoan VaLoanNumber
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VaLoanNumber { get => GetValue<string?>(); set => SetValue(value); }
}