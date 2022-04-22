using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// EnergyEfficientMortgage
/// </summary>
public sealed partial class EnergyEfficientMortgage : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// EEM Appraised Value [EEM.X64]
    /// </summary>
    public decimal? AppraisedValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Audit Cost [EEM.X70]
    /// </summary>
    public decimal? AuditCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Debt-to-Income (Back) Ratio [EEM.X89]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BackRatio { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Base Loan Amount From Loan Transmittal [EEM.X75]
    /// </summary>
    public decimal? BaseLoanAmtFromTsum { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Cost (All Costs Supported by Receipts) [EEM.X72]
    /// </summary>
    public decimal? CostEffectiveEnergyPackage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Maximum Amount of EE Improvement Cost Per The EEM Calculator in FHA Connection (Note 3) [EEM.X73]
    /// </summary>
    public decimal? EeCostMaximumAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Installed Cost of EE Improvements (B1 or B2) [EEM.X69]
    /// </summary>
    public decimal? EeImprovementsInstalledCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Installed Cost of Energy Improvements (Existing Construction) [EEM.X67]
    /// </summary>
    public decimal? EnergyCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Expected Energy Savings Over Useful Life of Improvements (Calculated at Present Value) Per Audit Report [EEM.X68]
    /// </summary>
    public decimal? EnergySavings { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - HOA [EEM.X84]
    /// </summary>
    public decimal? Hoa { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Cost of Improvements That Exceed 2000 IECC (New Construction Only) [EEM.X66]
    /// </summary>
    public decimal? ImprovementCostExceed2000 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Inspection(s) Cost [EEM.X71]
    /// </summary>
    public decimal? InspectionCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Lesser of C1 or C2 (This is The Cost-Effective Energy Package And The Amount That May be Added to the Base Loan Amount) (Note 4) [EEM.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LesserC1OrC2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment for E1 + E2  (PITI) [EEM.X83]
    /// </summary>
    public decimal? MonthlyHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - Monthly MI [EEM.X85]
    /// </summary>
    public decimal? MonthlyMi { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios [EEM.X82]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MortgageAmountUsedForQualifyingRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios - D1 [EEM.X80]
    /// </summary>
    public decimal? MortgageAmountUsedForQualifyingRateD1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Either New or Existing Construction [EEM.X90]
    /// </summary>
    public bool? NewOrExisting { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Original Sales Price if Owned less than 12 months [EEM.X63]
    /// </summary>
    public decimal? OriginalSalesPriceIfLess12Months { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment - Other/etc. [EEM.X86]
    /// </summary>
    public decimal? OtherHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Weatherization And/Or Solar Not Yet Included in A1, A3 Or A4 [EEM.X65]
    /// </summary>
    public decimal? SolarNotIncluded { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Solar System Cost Allowance [EEM.X76]
    /// </summary>
    public decimal? SolarSystemCostAllowance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Actual Amount [EEM.X61]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalActualAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total FHA Allowed Amount [EEM.X62]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAllowedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Base EEM Loan Amount (D1 + D2 + D3) [EEM.X77]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBaseEemLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Combined Loan Amount (D4 + D5) (Note: Only Whole Dollar Amounts May be Insured by FHA) [EEM.X79]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCombinedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Housing Payment [EEM.X87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyHousingPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Total Monthly Obligations [EEM.X88]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TotalMonthlyObligations { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM Mortgage Amount Used for Qualifying Ratios - UFMIP Based on D1 [EEM.X81]
    /// </summary>
    public decimal? UfmipBasedOn { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// EEM UFMIP (Factor Applied to D4) [EEM.X78]
    /// </summary>
    public decimal? UfmipFactor { get => GetValue<decimal?>(); set => SetValue(value); }
}