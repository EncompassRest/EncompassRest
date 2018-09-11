using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EnergyEfficientMortgage
    /// </summary>
    public sealed partial class EnergyEfficientMortgage : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _appraisedValue;
        /// <summary>
        /// EEM Appraised Value [EEM.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Appraised Value")]
        public decimal? AppraisedValue { get => _appraisedValue; set => SetField(ref _appraisedValue, value); }
        private DirtyValue<decimal?> _auditCost;
        /// <summary>
        /// EEM Audit Cost [EEM.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Audit Cost")]
        public decimal? AuditCost { get => _auditCost; set => SetField(ref _auditCost, value); }
        private DirtyValue<decimal?> _backRatio;
        /// <summary>
        /// EEM Total Debt-to-Income (Back) Ratio [EEM.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "EEM Total Debt-to-Income (Back) Ratio")]
        public decimal? BackRatio { get => _backRatio; set => SetField(ref _backRatio, value); }
        private DirtyValue<decimal?> _baseLoanAmtFromTsum;
        /// <summary>
        /// EEM Base Loan Amount From Loan Transmittal [EEM.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Base Loan Amount From Loan Transmittal")]
        public decimal? BaseLoanAmtFromTsum { get => _baseLoanAmtFromTsum; set => SetField(ref _baseLoanAmtFromTsum, value); }
        private DirtyValue<decimal?> _costEffectiveEnergyPackage;
        /// <summary>
        /// EEM Cost (All Costs Supported by Receipts) [EEM.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Cost (All Costs Supported by Receipts)")]
        public decimal? CostEffectiveEnergyPackage { get => _costEffectiveEnergyPackage; set => SetField(ref _costEffectiveEnergyPackage, value); }
        private DirtyValue<decimal?> _eeCostMaximumAmount;
        /// <summary>
        /// EEM Maximum Amount of EE Improvement Cost Per The EEM Calculator in FHA Connection (Note 3) [EEM.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Maximum Amount of EE Improvement Cost Per The EEM Calculator in FHA Connection (Note 3)")]
        public decimal? EeCostMaximumAmount { get => _eeCostMaximumAmount; set => SetField(ref _eeCostMaximumAmount, value); }
        private DirtyValue<decimal?> _eeImprovementsInstalledCost;
        /// <summary>
        /// EEM Installed Cost of EE Improvements (B1 or B2) [EEM.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Installed Cost of EE Improvements (B1 or B2)")]
        public decimal? EeImprovementsInstalledCost { get => _eeImprovementsInstalledCost; set => SetField(ref _eeImprovementsInstalledCost, value); }
        private DirtyValue<decimal?> _energyCost;
        /// <summary>
        /// EEM Installed Cost of Energy Improvements (Existing Construction) [EEM.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Installed Cost of Energy Improvements (Existing Construction)")]
        public decimal? EnergyCost { get => _energyCost; set => SetField(ref _energyCost, value); }
        private DirtyValue<decimal?> _energySavings;
        /// <summary>
        /// EEM Expected Energy Savings Over Useful Life of Improvements (Calculated at Present Value) Per Audit Report [EEM.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Expected Energy Savings Over Useful Life of Improvements (Calculated at Present Value) Per Audit Report")]
        public decimal? EnergySavings { get => _energySavings; set => SetField(ref _energySavings, value); }
        private DirtyValue<decimal?> _hoa;
        /// <summary>
        /// EEM Total Monthly Housing Payment - HOA [EEM.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Total Monthly Housing Payment - HOA")]
        public decimal? Hoa { get => _hoa; set => SetField(ref _hoa, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// EnergyEfficientMortgage Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _improvementCostExceed2000;
        /// <summary>
        /// EEM Cost of Improvements That Exceed 2000 IECC (New Construction Only) [EEM.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Cost of Improvements That Exceed 2000 IECC (New Construction Only)")]
        public decimal? ImprovementCostExceed2000 { get => _improvementCostExceed2000; set => SetField(ref _improvementCostExceed2000, value); }
        private DirtyValue<decimal?> _inspectionCost;
        /// <summary>
        /// EEM Inspection(s) Cost [EEM.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Inspection(s) Cost")]
        public decimal? InspectionCost { get => _inspectionCost; set => SetField(ref _inspectionCost, value); }
        private DirtyValue<decimal?> _lesserC1ORC2;
        /// <summary>
        /// EEM Lesser of C1 or C2 (This is The Cost-Effective Energy Package And The Amount That May be Added to the Base Loan Amount) (Note 4) [EEM.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Lesser of C1 or C2 (This is The Cost-Effective Energy Package And The Amount That May be Added to the Base Loan Amount) (Note 4)")]
        public decimal? LesserC1ORC2 { get => _lesserC1ORC2; set => SetField(ref _lesserC1ORC2, value); }
        private DirtyValue<decimal?> _monthlyHousingPayment;
        /// <summary>
        /// EEM Total Monthly Housing Payment for E1 + E2  (PITI) [EEM.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Total Monthly Housing Payment for E1 + E2  (PITI)")]
        public decimal? MonthlyHousingPayment { get => _monthlyHousingPayment; set => SetField(ref _monthlyHousingPayment, value); }
        private DirtyValue<decimal?> _monthlyMI;
        /// <summary>
        /// EEM Total Monthly Housing Payment - Monthly MI [EEM.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Total Monthly Housing Payment - Monthly MI")]
        public decimal? MonthlyMI { get => _monthlyMI; set => SetField(ref _monthlyMI, value); }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRate;
        /// <summary>
        /// EEM Mortgage Amount Used for Qualifying Ratios [EEM.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Mortgage Amount Used for Qualifying Ratios")]
        public decimal? MortgageAmountUsedForQualifyingRate { get => _mortgageAmountUsedForQualifyingRate; set => SetField(ref _mortgageAmountUsedForQualifyingRate, value); }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRateD1;
        /// <summary>
        /// EEM Mortgage Amount Used for Qualifying Ratios - D1 [EEM.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Mortgage Amount Used for Qualifying Ratios - D1")]
        public decimal? MortgageAmountUsedForQualifyingRateD1 { get => _mortgageAmountUsedForQualifyingRateD1; set => SetField(ref _mortgageAmountUsedForQualifyingRateD1, value); }
        private DirtyValue<bool?> _newOrExisting;
        /// <summary>
        /// EEM Either New or Existing Construction [EEM.X90]
        /// </summary>
        [LoanFieldProperty(Description = "EEM Either New or Existing Construction")]
        public bool? NewOrExisting { get => _newOrExisting; set => SetField(ref _newOrExisting, value); }
        private DirtyValue<decimal?> _originalSalesPriceIfLess12Months;
        /// <summary>
        /// EEM Original Sales Price if Owned less than 12 months [EEM.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Original Sales Price if Owned less than 12 months")]
        public decimal? OriginalSalesPriceIfLess12Months { get => _originalSalesPriceIfLess12Months; set => SetField(ref _originalSalesPriceIfLess12Months, value); }
        private DirtyValue<decimal?> _otherHousingPayment;
        /// <summary>
        /// EEM Total Monthly Housing Payment - Other/etc. [EEM.X86]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Total Monthly Housing Payment - Other/etc.")]
        public decimal? OtherHousingPayment { get => _otherHousingPayment; set => SetField(ref _otherHousingPayment, value); }
        private DirtyValue<decimal?> _solarNotIncluded;
        /// <summary>
        /// EEM Weatherization And/Or Solar Not Yet Included in A1, A3 Or A4 [EEM.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Weatherization And/Or Solar Not Yet Included in A1, A3 Or A4")]
        public decimal? SolarNotIncluded { get => _solarNotIncluded; set => SetField(ref _solarNotIncluded, value); }
        private DirtyValue<decimal?> _solarSystemCostAllowance;
        /// <summary>
        /// EEM Solar System Cost Allowance [EEM.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Solar System Cost Allowance")]
        public decimal? SolarSystemCostAllowance { get => _solarSystemCostAllowance; set => SetField(ref _solarSystemCostAllowance, value); }
        private DirtyValue<decimal?> _totalActualAmount;
        /// <summary>
        /// EEM Total Actual Amount [EEM.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Total Actual Amount")]
        public decimal? TotalActualAmount { get => _totalActualAmount; set => SetField(ref _totalActualAmount, value); }
        private DirtyValue<decimal?> _totalAllowedAmount;
        /// <summary>
        /// EEM Total FHA Allowed Amount [EEM.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Total FHA Allowed Amount")]
        public decimal? TotalAllowedAmount { get => _totalAllowedAmount; set => SetField(ref _totalAllowedAmount, value); }
        private DirtyValue<decimal?> _totalBaseEemLoanAmount;
        /// <summary>
        /// EEM Total Base EEM Loan Amount (D1 + D2 + D3) [EEM.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Total Base EEM Loan Amount (D1 + D2 + D3)")]
        public decimal? TotalBaseEemLoanAmount { get => _totalBaseEemLoanAmount; set => SetField(ref _totalBaseEemLoanAmount, value); }
        private DirtyValue<decimal?> _totalCombinedLoanAmount;
        /// <summary>
        /// EEM Total Combined Loan Amount (D4 + D5) (Note: Only Whole Dollar Amounts May be Insured by FHA) [EEM.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Total Combined Loan Amount (D4 + D5) (Note: Only Whole Dollar Amounts May be Insured by FHA)")]
        public decimal? TotalCombinedLoanAmount { get => _totalCombinedLoanAmount; set => SetField(ref _totalCombinedLoanAmount, value); }
        private DirtyValue<decimal?> _totalMonthlyHousingPayment;
        /// <summary>
        /// EEM Total Monthly Housing Payment [EEM.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "EEM Total Monthly Housing Payment")]
        public decimal? TotalMonthlyHousingPayment { get => _totalMonthlyHousingPayment; set => SetField(ref _totalMonthlyHousingPayment, value); }
        private DirtyValue<decimal?> _totalMonthlyObligations;
        /// <summary>
        /// EEM Total Monthly Obligations [EEM.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "EEM Total Monthly Obligations")]
        public decimal? TotalMonthlyObligations { get => _totalMonthlyObligations; set => SetField(ref _totalMonthlyObligations, value); }
        private DirtyValue<decimal?> _ufmipBasedOn;
        /// <summary>
        /// EEM Mortgage Amount Used for Qualifying Ratios - UFMIP Based on D1 [EEM.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM Mortgage Amount Used for Qualifying Ratios - UFMIP Based on D1")]
        public decimal? UfmipBasedOn { get => _ufmipBasedOn; set => SetField(ref _ufmipBasedOn, value); }
        private DirtyValue<decimal?> _ufmipFactor;
        /// <summary>
        /// EEM UFMIP (Factor Applied to D4) [EEM.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "EEM UFMIP (Factor Applied to D4)")]
        public decimal? UfmipFactor { get => _ufmipFactor; set => SetField(ref _ufmipFactor, value); }
    }
}