using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgage
    {
        public JsonNullable<decimal?> AppraisedValue { get; set; }
        public JsonNullable<decimal?> AuditCost { get; set; }
        public JsonNullable<decimal?> BackRatio { get; set; }
        public JsonNullable<decimal?> BaseLoanAmtFromTsum { get; set; }
        public JsonNullable<decimal?> CostEffectiveEnergyPackage { get; set; }
        public JsonNullable<decimal?> EeCostMaximumAmount { get; set; }
        public JsonNullable<decimal?> EeImprovementsInstalledCost { get; set; }
        public JsonNullable<decimal?> EnergyCost { get; set; }
        public JsonNullable<decimal?> EnergySavings { get; set; }
        public JsonNullable<decimal?> Hoa { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> ImprovementCostExceed2000 { get; set; }
        public JsonNullable<decimal?> InspectionCost { get; set; }
        public JsonNullable<decimal?> LesserC1ORC2 { get; set; }
        public JsonNullable<decimal?> MonthlyHousingPayment { get; set; }
        public JsonNullable<decimal?> MonthlyMI { get; set; }
        public JsonNullable<decimal?> MortgageAmountUsedForQualifyingRate { get; set; }
        public JsonNullable<decimal?> MortgageAmountUsedForQualifyingRateD1 { get; set; }
        public JsonNullable<bool?> NewOrExisting { get; set; }
        public JsonNullable<decimal?> OriginalSalesPriceIfLess12Months { get; set; }
        public JsonNullable<decimal?> OtherHousingPayment { get; set; }
        public JsonNullable<decimal?> SolarNotIncluded { get; set; }
        public JsonNullable<decimal?> SolarSystemCostAllowance { get; set; }
        public JsonNullable<decimal?> TotalActualAmount { get; set; }
        public JsonNullable<decimal?> TotalAllowedAmount { get; set; }
        public JsonNullable<decimal?> TotalBaseEemLoanAmount { get; set; }
        public JsonNullable<decimal?> TotalCombinedLoanAmount { get; set; }
        public JsonNullable<decimal?> TotalMonthlyHousingPayment { get; set; }
        public JsonNullable<decimal?> TotalMonthlyObligations { get; set; }
        public JsonNullable<decimal?> UfmipBasedOn { get; set; }
        public JsonNullable<decimal?> UfmipFactor { get; set; }
    }
}