using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgage : IClean
    {
        private Value<decimal?> _appraisedValue;
        public decimal? AppraisedValue { get { return _appraisedValue; } set { _appraisedValue = value; } }
        private Value<decimal?> _auditCost;
        public decimal? AuditCost { get { return _auditCost; } set { _auditCost = value; } }
        private Value<decimal?> _backRatio;
        public decimal? BackRatio { get { return _backRatio; } set { _backRatio = value; } }
        private Value<decimal?> _baseLoanAmtFromTsum;
        public decimal? BaseLoanAmtFromTsum { get { return _baseLoanAmtFromTsum; } set { _baseLoanAmtFromTsum = value; } }
        private Value<decimal?> _costEffectiveEnergyPackage;
        public decimal? CostEffectiveEnergyPackage { get { return _costEffectiveEnergyPackage; } set { _costEffectiveEnergyPackage = value; } }
        private Value<decimal?> _eeCostMaximumAmount;
        public decimal? EeCostMaximumAmount { get { return _eeCostMaximumAmount; } set { _eeCostMaximumAmount = value; } }
        private Value<decimal?> _eeImprovementsInstalledCost;
        public decimal? EeImprovementsInstalledCost { get { return _eeImprovementsInstalledCost; } set { _eeImprovementsInstalledCost = value; } }
        private Value<decimal?> _energyCost;
        public decimal? EnergyCost { get { return _energyCost; } set { _energyCost = value; } }
        private Value<decimal?> _energySavings;
        public decimal? EnergySavings { get { return _energySavings; } set { _energySavings = value; } }
        private Value<decimal?> _hoa;
        public decimal? Hoa { get { return _hoa; } set { _hoa = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _improvementCostExceed2000;
        public decimal? ImprovementCostExceed2000 { get { return _improvementCostExceed2000; } set { _improvementCostExceed2000 = value; } }
        private Value<decimal?> _inspectionCost;
        public decimal? InspectionCost { get { return _inspectionCost; } set { _inspectionCost = value; } }
        private Value<decimal?> _lesserC1ORC2;
        public decimal? LesserC1ORC2 { get { return _lesserC1ORC2; } set { _lesserC1ORC2 = value; } }
        private Value<decimal?> _monthlyHousingPayment;
        public decimal? MonthlyHousingPayment { get { return _monthlyHousingPayment; } set { _monthlyHousingPayment = value; } }
        private Value<decimal?> _monthlyMI;
        public decimal? MonthlyMI { get { return _monthlyMI; } set { _monthlyMI = value; } }
        private Value<decimal?> _mortgageAmountUsedForQualifyingRate;
        public decimal? MortgageAmountUsedForQualifyingRate { get { return _mortgageAmountUsedForQualifyingRate; } set { _mortgageAmountUsedForQualifyingRate = value; } }
        private Value<decimal?> _mortgageAmountUsedForQualifyingRateD1;
        public decimal? MortgageAmountUsedForQualifyingRateD1 { get { return _mortgageAmountUsedForQualifyingRateD1; } set { _mortgageAmountUsedForQualifyingRateD1 = value; } }
        private Value<bool?> _newOrExisting;
        public bool? NewOrExisting { get { return _newOrExisting; } set { _newOrExisting = value; } }
        private Value<decimal?> _originalSalesPriceIfLess12Months;
        public decimal? OriginalSalesPriceIfLess12Months { get { return _originalSalesPriceIfLess12Months; } set { _originalSalesPriceIfLess12Months = value; } }
        private Value<decimal?> _otherHousingPayment;
        public decimal? OtherHousingPayment { get { return _otherHousingPayment; } set { _otherHousingPayment = value; } }
        private Value<decimal?> _solarNotIncluded;
        public decimal? SolarNotIncluded { get { return _solarNotIncluded; } set { _solarNotIncluded = value; } }
        private Value<decimal?> _solarSystemCostAllowance;
        public decimal? SolarSystemCostAllowance { get { return _solarSystemCostAllowance; } set { _solarSystemCostAllowance = value; } }
        private Value<decimal?> _totalActualAmount;
        public decimal? TotalActualAmount { get { return _totalActualAmount; } set { _totalActualAmount = value; } }
        private Value<decimal?> _totalAllowedAmount;
        public decimal? TotalAllowedAmount { get { return _totalAllowedAmount; } set { _totalAllowedAmount = value; } }
        private Value<decimal?> _totalBaseEemLoanAmount;
        public decimal? TotalBaseEemLoanAmount { get { return _totalBaseEemLoanAmount; } set { _totalBaseEemLoanAmount = value; } }
        private Value<decimal?> _totalCombinedLoanAmount;
        public decimal? TotalCombinedLoanAmount { get { return _totalCombinedLoanAmount; } set { _totalCombinedLoanAmount = value; } }
        private Value<decimal?> _totalMonthlyHousingPayment;
        public decimal? TotalMonthlyHousingPayment { get { return _totalMonthlyHousingPayment; } set { _totalMonthlyHousingPayment = value; } }
        private Value<decimal?> _totalMonthlyObligations;
        public decimal? TotalMonthlyObligations { get { return _totalMonthlyObligations; } set { _totalMonthlyObligations = value; } }
        private Value<decimal?> _ufmipBasedOn;
        public decimal? UfmipBasedOn { get { return _ufmipBasedOn; } set { _ufmipBasedOn = value; } }
        private Value<decimal?> _ufmipFactor;
        public decimal? UfmipFactor { get { return _ufmipFactor; } set { _ufmipFactor = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisedValue.Clean
                    && _auditCost.Clean
                    && _backRatio.Clean
                    && _baseLoanAmtFromTsum.Clean
                    && _costEffectiveEnergyPackage.Clean
                    && _eeCostMaximumAmount.Clean
                    && _eeImprovementsInstalledCost.Clean
                    && _energyCost.Clean
                    && _energySavings.Clean
                    && _hoa.Clean
                    && _id.Clean
                    && _improvementCostExceed2000.Clean
                    && _inspectionCost.Clean
                    && _lesserC1ORC2.Clean
                    && _monthlyHousingPayment.Clean
                    && _monthlyMI.Clean
                    && _mortgageAmountUsedForQualifyingRate.Clean
                    && _mortgageAmountUsedForQualifyingRateD1.Clean
                    && _newOrExisting.Clean
                    && _originalSalesPriceIfLess12Months.Clean
                    && _otherHousingPayment.Clean
                    && _solarNotIncluded.Clean
                    && _solarSystemCostAllowance.Clean
                    && _totalActualAmount.Clean
                    && _totalAllowedAmount.Clean
                    && _totalBaseEemLoanAmount.Clean
                    && _totalCombinedLoanAmount.Clean
                    && _totalMonthlyHousingPayment.Clean
                    && _totalMonthlyObligations.Clean
                    && _ufmipBasedOn.Clean
                    && _ufmipFactor.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var appraisedValue = _appraisedValue; appraisedValue.Clean = value; _appraisedValue = appraisedValue;
                var auditCost = _auditCost; auditCost.Clean = value; _auditCost = auditCost;
                var backRatio = _backRatio; backRatio.Clean = value; _backRatio = backRatio;
                var baseLoanAmtFromTsum = _baseLoanAmtFromTsum; baseLoanAmtFromTsum.Clean = value; _baseLoanAmtFromTsum = baseLoanAmtFromTsum;
                var costEffectiveEnergyPackage = _costEffectiveEnergyPackage; costEffectiveEnergyPackage.Clean = value; _costEffectiveEnergyPackage = costEffectiveEnergyPackage;
                var eeCostMaximumAmount = _eeCostMaximumAmount; eeCostMaximumAmount.Clean = value; _eeCostMaximumAmount = eeCostMaximumAmount;
                var eeImprovementsInstalledCost = _eeImprovementsInstalledCost; eeImprovementsInstalledCost.Clean = value; _eeImprovementsInstalledCost = eeImprovementsInstalledCost;
                var energyCost = _energyCost; energyCost.Clean = value; _energyCost = energyCost;
                var energySavings = _energySavings; energySavings.Clean = value; _energySavings = energySavings;
                var hoa = _hoa; hoa.Clean = value; _hoa = hoa;
                var id = _id; id.Clean = value; _id = id;
                var improvementCostExceed2000 = _improvementCostExceed2000; improvementCostExceed2000.Clean = value; _improvementCostExceed2000 = improvementCostExceed2000;
                var inspectionCost = _inspectionCost; inspectionCost.Clean = value; _inspectionCost = inspectionCost;
                var lesserC1ORC2 = _lesserC1ORC2; lesserC1ORC2.Clean = value; _lesserC1ORC2 = lesserC1ORC2;
                var monthlyHousingPayment = _monthlyHousingPayment; monthlyHousingPayment.Clean = value; _monthlyHousingPayment = monthlyHousingPayment;
                var monthlyMI = _monthlyMI; monthlyMI.Clean = value; _monthlyMI = monthlyMI;
                var mortgageAmountUsedForQualifyingRate = _mortgageAmountUsedForQualifyingRate; mortgageAmountUsedForQualifyingRate.Clean = value; _mortgageAmountUsedForQualifyingRate = mortgageAmountUsedForQualifyingRate;
                var mortgageAmountUsedForQualifyingRateD1 = _mortgageAmountUsedForQualifyingRateD1; mortgageAmountUsedForQualifyingRateD1.Clean = value; _mortgageAmountUsedForQualifyingRateD1 = mortgageAmountUsedForQualifyingRateD1;
                var newOrExisting = _newOrExisting; newOrExisting.Clean = value; _newOrExisting = newOrExisting;
                var originalSalesPriceIfLess12Months = _originalSalesPriceIfLess12Months; originalSalesPriceIfLess12Months.Clean = value; _originalSalesPriceIfLess12Months = originalSalesPriceIfLess12Months;
                var otherHousingPayment = _otherHousingPayment; otherHousingPayment.Clean = value; _otherHousingPayment = otherHousingPayment;
                var solarNotIncluded = _solarNotIncluded; solarNotIncluded.Clean = value; _solarNotIncluded = solarNotIncluded;
                var solarSystemCostAllowance = _solarSystemCostAllowance; solarSystemCostAllowance.Clean = value; _solarSystemCostAllowance = solarSystemCostAllowance;
                var totalActualAmount = _totalActualAmount; totalActualAmount.Clean = value; _totalActualAmount = totalActualAmount;
                var totalAllowedAmount = _totalAllowedAmount; totalAllowedAmount.Clean = value; _totalAllowedAmount = totalAllowedAmount;
                var totalBaseEemLoanAmount = _totalBaseEemLoanAmount; totalBaseEemLoanAmount.Clean = value; _totalBaseEemLoanAmount = totalBaseEemLoanAmount;
                var totalCombinedLoanAmount = _totalCombinedLoanAmount; totalCombinedLoanAmount.Clean = value; _totalCombinedLoanAmount = totalCombinedLoanAmount;
                var totalMonthlyHousingPayment = _totalMonthlyHousingPayment; totalMonthlyHousingPayment.Clean = value; _totalMonthlyHousingPayment = totalMonthlyHousingPayment;
                var totalMonthlyObligations = _totalMonthlyObligations; totalMonthlyObligations.Clean = value; _totalMonthlyObligations = totalMonthlyObligations;
                var ufmipBasedOn = _ufmipBasedOn; ufmipBasedOn.Clean = value; _ufmipBasedOn = ufmipBasedOn;
                var ufmipFactor = _ufmipFactor; ufmipFactor.Clean = value; _ufmipFactor = ufmipFactor;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public EnergyEfficientMortgage()
        {
            Clean = true;
        }
    }
}