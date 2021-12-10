using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// UsdaHouseholdIncome
/// </summary>
public sealed partial class UsdaHouseholdIncome : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _age;
    private DirtyValue<string?>? _analysisDocumenting;
    private DirtyValue<decimal?>? _annualNonWageIncome;
    private DirtyValue<decimal?>? _annualWageIncome;
    private DirtyValue<bool?>? _disabledIndicator;
    private DirtyValue<bool?>? _fullTimeStudentIndicator;
    private DirtyValue<string?>? _name;
    private DirtyValue<StringEnumValue<RecordOwnerType>>? _recordOwnerType;
    private DirtyValue<string?>? _sourceofNonWageIncomeDescription;
    private DirtyValue<string?>? _sourceofWageIncomeEmployerName;
    private DirtyValue<int?>? _usdaHouseholdIncomeIndex;

    /// <summary>
    /// UsdaHouseholdIncomeContract Age
    /// </summary>
    public int? Age { get => _age; set => SetField(ref _age, value); }

    /// <summary>
    /// USDA - House Income - Written Analysis Documenting Annual and Repayment Income [USDA.X193]
    /// </summary>
    public string? AnalysisDocumenting { get => _analysisDocumenting; set => SetField(ref _analysisDocumenting, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract AnnualNonWageIncome
    /// </summary>
    public decimal? AnnualNonWageIncome { get => _annualNonWageIncome; set => SetField(ref _annualNonWageIncome, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract AnnualWageIncome
    /// </summary>
    public decimal? AnnualWageIncome { get => _annualWageIncome; set => SetField(ref _annualWageIncome, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract DisabledIndicator
    /// </summary>
    public bool? DisabledIndicator { get => _disabledIndicator; set => SetField(ref _disabledIndicator, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract FullTimeStudentIndicator
    /// </summary>
    public bool? FullTimeStudentIndicator { get => _fullTimeStudentIndicator; set => SetField(ref _fullTimeStudentIndicator, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract RecordOwnerType
    /// </summary>
    public StringEnumValue<RecordOwnerType> RecordOwnerType { get => _recordOwnerType; set => SetField(ref _recordOwnerType, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract SourceofNonWageIncomeDescription
    /// </summary>
    public string? SourceofNonWageIncomeDescription { get => _sourceofNonWageIncomeDescription; set => SetField(ref _sourceofNonWageIncomeDescription, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract SourceofWageIncomeEmployerName
    /// </summary>
    public string? SourceofWageIncomeEmployerName { get => _sourceofWageIncomeEmployerName; set => SetField(ref _sourceofWageIncomeEmployerName, value); }

    /// <summary>
    /// UsdaHouseholdIncomeContract UsdaHouseholdIncomeIndex
    /// </summary>
    public int? UsdaHouseholdIncomeIndex { get => _usdaHouseholdIncomeIndex; set => SetField(ref _usdaHouseholdIncomeIndex, value); }
}