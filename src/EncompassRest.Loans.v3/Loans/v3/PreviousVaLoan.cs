using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// PreviousVaLoan
/// </summary>
public sealed partial class PreviousVaLoan : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _loanDate;
    private DirtyValue<StringEnumValue<PreviousVaLoanLoanType>>? _loanType;
    private DirtyValue<int?>? _previousVaLoanIndex;
    private DirtyValue<string?>? _propertyAddress;
    private DirtyValue<string?>? _propertyCity;
    private DirtyValue<bool?>? _propertyOwned;
    private DirtyValue<string?>? _propertyPostalCode;
    private DirtyValue<string?>? _propertyState;
    private DirtyValue<DateTime?>? _soldDate;
    private DirtyValue<string?>? _vaLoanNumber;

    /// <summary>
    /// PreviousVaLoanContract LoanDate
    /// </summary>
    public DateTime? LoanDate { get => _loanDate; set => SetField(ref _loanDate, value); }

    /// <summary>
    /// PreviousVaLoanContract LoanType
    /// </summary>
    public StringEnumValue<PreviousVaLoanLoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

    /// <summary>
    /// PreviousVaLoanContract PreviousVaLoanIndex
    /// </summary>
    public int? PreviousVaLoanIndex { get => _previousVaLoanIndex; set => SetField(ref _previousVaLoanIndex, value); }

    /// <summary>
    /// PreviousVaLoanContract PropertyAddress
    /// </summary>
    public string? PropertyAddress { get => _propertyAddress; set => SetField(ref _propertyAddress, value); }

    /// <summary>
    /// PreviousVaLoanContract PropertyCity
    /// </summary>
    public string? PropertyCity { get => _propertyCity; set => SetField(ref _propertyCity, value); }

    /// <summary>
    /// PreviousVaLoanContract PropertyOwned
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? PropertyOwned { get => _propertyOwned; set => SetField(ref _propertyOwned, value); }

    /// <summary>
    /// PreviousVaLoanContract PropertyPostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PropertyPostalCode { get => _propertyPostalCode; set => SetField(ref _propertyPostalCode, value); }

    /// <summary>
    /// PreviousVaLoanContract PropertyState
    /// </summary>
    public string? PropertyState { get => _propertyState; set => SetField(ref _propertyState, value); }

    /// <summary>
    /// PreviousVaLoanContract SoldDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SoldDate { get => _soldDate; set => SetField(ref _soldDate, value); }

    /// <summary>
    /// PreviousVaLoanContract VaLoanNumber
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? VaLoanNumber { get => _vaLoanNumber; set => SetField(ref _vaLoanNumber, value); }
}