using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegulationZInterestRatePeriod
/// </summary>
public sealed partial class RegulationZInterestRatePeriod : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _adjustmentDate;
    private DirtyValue<int?>? _adjustmentMonths;
    private DirtyValue<decimal?>? _interestPayment;
    private DirtyValue<decimal?>? _interestPrincipalPayment;
    private DirtyValue<decimal?>? _interestRatePercent;
    private DirtyValue<decimal?>? _monthlyPayment;
    private DirtyValue<decimal?>? _principalPayment;
    private DirtyValue<StringEnumValue<RegulationZInterestRatePeriodType>>? _regulationZInterestRatePeriodType;
    private DirtyValue<decimal?>? _taxInsuranceAmount;
    private DirtyValue<decimal?>? _totalPayment;

    /// <summary>
    /// RegulationZInterestRatePeriodContract AdjustmentDate
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? AdjustmentDate { get => _adjustmentDate; set => SetField(ref _adjustmentDate, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months [3289]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? AdjustmentMonths { get => _adjustmentMonths; set => SetField(ref _adjustmentMonths, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract InterestPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InterestPayment { get => _interestPayment; set => SetField(ref _interestPayment, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract InterestPrincipalPayment [3285], [3286]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? InterestPrincipalPayment { get => _interestPrincipalPayment; set => SetField(ref _interestPrincipalPayment, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract InterestRatePercent
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? InterestRatePercent { get => _interestRatePercent; set => SetField(ref _interestRatePercent, value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment [3290]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract PrincipalPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrincipalPayment { get => _principalPayment; set => SetField(ref _principalPayment, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract RegulationZInterestRatePeriodType
    /// </summary>
    public StringEnumValue<RegulationZInterestRatePeriodType> RegulationZInterestRatePeriodType { get => _regulationZInterestRatePeriodType; set => SetField(ref _regulationZInterestRatePeriodType, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract TaxInsuranceAmount
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TaxInsuranceAmount { get => _taxInsuranceAmount; set => SetField(ref _taxInsuranceAmount, value); }

    /// <summary>
    /// RegulationZInterestRatePeriodContract TotalPayment
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPayment { get => _totalPayment; set => SetField(ref _totalPayment, value); }
}