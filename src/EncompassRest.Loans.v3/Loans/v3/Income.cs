using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Income
/// </summary>
public sealed partial class Income : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _amount;
    private DirtyValue<StringEnumValue<Description>>? _description;
    private DirtyValue<StringEnumValue<IncomeType>>? _incomeType;
    private DirtyValue<int?>? _otherIncomeIndex;
    private DirtyValue<StringEnumValue<BorrowerOrCoBorrower>>? _owner;

    /// <summary>
    /// IncomeContract Amount
    /// </summary>
    public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

    /// <summary>
    /// IncomeContract Description
    /// </summary>
    public StringEnumValue<Description> Description { get => _description; set => SetField(ref _description, value); }

    /// <summary>
    /// IncomeContract IncomeType
    /// </summary>
    public StringEnumValue<IncomeType> IncomeType { get => _incomeType; set => SetField(ref _incomeType, value); }

    /// <summary>
    /// IncomeContract OtherIncomeIndex
    /// </summary>
    public int? OtherIncomeIndex { get => _otherIncomeIndex; set => SetField(ref _otherIncomeIndex, value); }

    /// <summary>
    /// IncomeContract Owner
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => _owner; set => SetField(ref _owner, value); }
}