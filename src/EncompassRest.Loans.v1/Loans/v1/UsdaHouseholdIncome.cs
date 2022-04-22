using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// UsdaHouseholdIncome
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(UsdaHouseholdIncomeIndex))]
public sealed partial class UsdaHouseholdIncome : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// UsdaHouseholdIncome Age
    /// </summary>
    public int? Age { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// USDA - House Income - Written Analysis Documenting Annual and Repayment Income [USDA.X193]
    /// </summary>
    public string? AnalysisDocumenting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome AnnualNonWageIncome
    /// </summary>
    public decimal? AnnualNonWageIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome AnnualWageIncome
    /// </summary>
    public decimal? AnnualWageIncome { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome DisabledIndicator
    /// </summary>
    public bool? DisabledIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome FullTimeStudentIndicator
    /// </summary>
    public bool? FullTimeStudentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome RecordOwnerType
    /// </summary>
    public StringEnumValue<RecordOwnerType> RecordOwnerType { get => GetValue<StringEnumValue<RecordOwnerType>>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome SourceofNonWageIncomeDescription
    /// </summary>
    public string? SourceofNonWageIncomeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome SourceofWageIncomeEmployerName
    /// </summary>
    public string? SourceofWageIncomeEmployerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UsdaHouseholdIncome UsdaHouseholdIncomeIndex
    /// </summary>
    public int? UsdaHouseholdIncomeIndex { get => GetValue<int?>(); set => SetValue(value); }
}