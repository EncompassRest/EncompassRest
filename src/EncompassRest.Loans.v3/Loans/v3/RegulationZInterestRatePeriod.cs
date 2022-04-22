using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegulationZInterestRatePeriod
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(RegulationZInterestRatePeriodType))]
public sealed partial class RegulationZInterestRatePeriod : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RegulationZInterestRatePeriod AdjustmentDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? AdjustmentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months [3289]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? AdjustmentMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod InterestPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InterestPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod InterestPrincipalPayment [3285], [3286]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InterestPrincipalPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod InterestRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? InterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment [3290]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod PrincipalPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrincipalPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod RegulationZInterestRatePeriodType
    /// </summary>
    public StringEnumValue<RegulationZInterestRatePeriodType> RegulationZInterestRatePeriodType { get => GetValue<StringEnumValue<RegulationZInterestRatePeriodType>>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod TaxInsuranceAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TaxInsuranceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZInterestRatePeriod TotalPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPayment { get => GetValue<decimal?>(); set => SetValue(value); }
}