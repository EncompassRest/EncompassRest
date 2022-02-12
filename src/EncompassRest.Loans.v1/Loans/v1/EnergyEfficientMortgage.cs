using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// EnergyEfficientMortgage
/// </summary>
public sealed partial class EnergyEfficientMortgage : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _appraisedValue;
    private DirtyValue<decimal?>? _auditCost;
    private DirtyValue<decimal?>? _backRatio;
    private DirtyValue<decimal?>? _baseLoanAmtFromTsum;
    private DirtyValue<decimal?>? _costEffectiveEnergyPackage;
    private DirtyValue<decimal?>? _eeCostMaximumAmount;
    private DirtyValue<decimal?>? _eeImprovementsInstalledCost;
    private DirtyValue<decimal?>? _energyCost;
    private DirtyValue<decimal?>? _energySavings;
    private DirtyValue<decimal?>? _hoa;
    private DirtyValue<string?>? _id;
    private DirtyValue<decimal?>? _improvementCostExceed2000;
    private DirtyValue<decimal?>? _inspectionCost;
    private DirtyValue<decimal?>? _lesserC1ORC2;
    private DirtyValue<decimal?>? _monthlyHousingPayment;
    private DirtyValue<decimal?>? _monthlyMI;
    private DirtyValue<decimal?>? _mortgageAmountUsedForQualifyingRate;
    private DirtyValue<decimal?>? _mortgageAmountUsedForQualifyingRateD1;
    private DirtyValue<bool?>? _newOrExisting;
    private DirtyValue<decimal?>? _originalSalesPriceIfLess12Months;
    private DirtyValue<decimal?>? _otherHousingPayment;
    private DirtyValue<decimal?>? _solarNotIncluded;
    private DirtyValue<decimal?>? _solarSystemCostAllowance;
    private DirtyValue<decimal?>? _totalActualAmount;
    private DirtyValue<decimal?>? _totalAllowedAmount;
    private DirtyValue<decimal?>? _totalBaseEemLoanAmount;
    private DirtyValue<decimal?>? _totalCombinedLoanAmount;
    private DirtyValue<decimal?>? _totalMonthlyHousingPayment;
    private DirtyValue<decimal?>? _totalMonthlyObligations;
    private DirtyValue<decimal?>? _ufmipBasedOn;
    private DirtyValue<decimal?>? _ufmipFactor;

    /// <summary>
    /// EEM Appraised Value [EEM.X64]
    /// </summary>
    public decimal? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }

    /// <summary>
    /// EEM Audit Cost [EEM.X70]
    /// </summary>
    public decimal? AuditCost { get => _auditCost; set => SetField(ref _auditCost, value); }

    /// <summary>
    /// EEM Total Debt-to-Income (Back) Ratio [EEM.X89]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BackRatio { get => _backRatio; set => SetField(ref _backRatio, value); }

    /// <summary>
    /// EEM Base Loan Amount From Loan Transmittal [EEM.X75]
    /// </summary>
    public decimal? BaseLoanAmtFromTsum { get => _baseLoanAmtFromTsum; set => SetField(ref _baseLoanAmtFromTsum, value); }

    /// <summary>
    /// EEM Cost (All Costs Supported by Receipts) [EEM.X72]
    /// </summary>
    public decimal? CostEffectiveEnergyPackage { get => _costEffectiveEnergyPackage; set => SetField(ref _costEffectiveEnergyPackage, value); }

    /// <summary>
    /// EEM Maximum Amount of EE Improvement Cost Per The EEM Calculator in FHA Connection (Note 3) [EEM.X73]
    /// </summary>
    public decimal? EeCostMaximumAmount { get => _eeCostMaximumAmount; set => SetField(ref _eeCostMaximumAmount, value); }

    /// <summary>
    /// EEM Installed Cost of EE Improvements (B1 or B2) [EEM.X69]
    /// </summary>
    public decimal? EeImprovementsInstalledCost { get => _eeImprovementsInstalledCost; set => SetField(ref _eeImprovementsInstalledCost, value); }

    /// <summary>
    /// EEM Installed Cost of Energy Improvements (Existing Construction) [EEM.X67]
    /// </summary>
    public decimal? EnergyCost { get => _energyCost; set => SetField(ref _energyCost, value); }

    /// <summary>
    /// EEM Expected Energy Savings Over Useful Life of Improvements (Calculated at Present Value) Per Audit Report [EEM.X68]
    /// </summary>
    public decimal? EnergySavings { get => _energySavings; set => SetField(ref _energySavings, value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - HOA [EEM.X84]
    /// </summary>
    public decimal? Hoa { get => _hoa; set => SetField(ref _hoa, value); }

    /// <summary>
    /// EnergyEfficientMortgage Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// EEM Cost of Improvements That Exceed 2000 IECC (New Construction Only) [EEM.X66]
    /// </summary>
    public decimal? ImprovementCostExceed2000 { get => _improvementCostExceed2000; set => SetField(ref _improvementCostExceed2000, value); }

    /// <summary>
    /// EEM Inspection(s) Cost [EEM.X71]
    /// </summary>
    public decimal? InspectionCost { get => _inspectionCost; set => SetField(ref _inspectionCost, value); }

    /// <summary>
    /// EEM Lesser of C1 or C2 (This is The Cost-Effective Energy Package And The Amount That May be Added to the Base Loan Amount) (Note 4) [EEM.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserC1ORC2 { get => _lesserC1ORC2; set => SetField(ref _lesserC1ORC2, value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment for E1 + E2  (PITI) [EEM.X83]
    /// </summary>
    public decimal? MonthlyHousingPayment { get => _monthlyHousingPayment; set => SetField(ref _monthlyHousingPayment, value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - Monthly MI [EEM.X85]
    /// </summary>
    public decimal? MonthlyMI { get => _monthlyMI; set => SetField(ref _monthlyMI, value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios [EEM.X82]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageAmountUsedForQualifyingRate { get => _mortgageAmountUsedForQualifyingRate; set => SetField(ref _mortgageAmountUsedForQualifyingRate, value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios - D1 [EEM.X80]
    /// </summary>
    public decimal? MortgageAmountUsedForQualifyingRateD1 { get => _mortgageAmountUsedForQualifyingRateD1; set => SetField(ref _mortgageAmountUsedForQualifyingRateD1, value); }

    /// <summary>
    /// EEM Either New or Existing Construction [EEM.X90]
    /// </summary>
    public bool? NewOrExisting { get => _newOrExisting; set => SetField(ref _newOrExisting, value); }

    /// <summary>
    /// EEM Original Sales Price if Owned less than 12 months [EEM.X63]
    /// </summary>
    public decimal? OriginalSalesPriceIfLess12Months { get => _originalSalesPriceIfLess12Months; set => SetField(ref _originalSalesPriceIfLess12Months, value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - Other/etc. [EEM.X86]
    /// </summary>
    public decimal? OtherHousingPayment { get => _otherHousingPayment; set => SetField(ref _otherHousingPayment, value); }

    /// <summary>
    /// EEM Weatherization And/Or Solar Not Yet Included in A1, A3 Or A4 [EEM.X65]
    /// </summary>
    public decimal? SolarNotIncluded { get => _solarNotIncluded; set => SetField(ref _solarNotIncluded, value); }

    /// <summary>
    /// EEM Solar System Cost Allowance [EEM.X76]
    /// </summary>
    public decimal? SolarSystemCostAllowance { get => _solarSystemCostAllowance; set => SetField(ref _solarSystemCostAllowance, value); }

    /// <summary>
    /// EEM Total Actual Amount [EEM.X61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalActualAmount { get => _totalActualAmount; set => SetField(ref _totalActualAmount, value); }

    /// <summary>
    /// EEM Total FHA Allowed Amount [EEM.X62]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAllowedAmount { get => _totalAllowedAmount; set => SetField(ref _totalAllowedAmount, value); }

    /// <summary>
    /// EEM Total Base EEM Loan Amount (D1 + D2 + D3) [EEM.X77]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBaseEemLoanAmount { get => _totalBaseEemLoanAmount; set => SetField(ref _totalBaseEemLoanAmount, value); }

    /// <summary>
    /// EEM Total Combined Loan Amount (D4 + D5) (Note: Only Whole Dollar Amounts May be Insured by FHA) [EEM.X79]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCombinedLoanAmount { get => _totalCombinedLoanAmount; set => SetField(ref _totalCombinedLoanAmount, value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment [EEM.X87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyHousingPayment { get => _totalMonthlyHousingPayment; set => SetField(ref _totalMonthlyHousingPayment, value); }

    /// <summary>
    /// EEM Total Monthly Obligations [EEM.X88]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TotalMonthlyObligations { get => _totalMonthlyObligations; set => SetField(ref _totalMonthlyObligations, value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios - UFMIP Based on D1 [EEM.X81]
    /// </summary>
    public decimal? UfmipBasedOn { get => _ufmipBasedOn; set => SetField(ref _ufmipBasedOn, value); }

    /// <summary>
    /// EEM UFMIP (Factor Applied to D4) [EEM.X78]
    /// </summary>
    public decimal? UfmipFactor { get => _ufmipFactor; set => SetField(ref _ufmipFactor, value); }
}