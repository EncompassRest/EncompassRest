using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _appraisedValue; v0.Clean = value; _appraisedValue = v0;
                var v1 = _auditCost; v1.Clean = value; _auditCost = v1;
                var v2 = _backRatio; v2.Clean = value; _backRatio = v2;
                var v3 = _baseLoanAmtFromTsum; v3.Clean = value; _baseLoanAmtFromTsum = v3;
                var v4 = _costEffectiveEnergyPackage; v4.Clean = value; _costEffectiveEnergyPackage = v4;
                var v5 = _eeCostMaximumAmount; v5.Clean = value; _eeCostMaximumAmount = v5;
                var v6 = _eeImprovementsInstalledCost; v6.Clean = value; _eeImprovementsInstalledCost = v6;
                var v7 = _energyCost; v7.Clean = value; _energyCost = v7;
                var v8 = _energySavings; v8.Clean = value; _energySavings = v8;
                var v9 = _hoa; v9.Clean = value; _hoa = v9;
                var v10 = _id; v10.Clean = value; _id = v10;
                var v11 = _improvementCostExceed2000; v11.Clean = value; _improvementCostExceed2000 = v11;
                var v12 = _inspectionCost; v12.Clean = value; _inspectionCost = v12;
                var v13 = _lesserC1ORC2; v13.Clean = value; _lesserC1ORC2 = v13;
                var v14 = _monthlyHousingPayment; v14.Clean = value; _monthlyHousingPayment = v14;
                var v15 = _monthlyMI; v15.Clean = value; _monthlyMI = v15;
                var v16 = _mortgageAmountUsedForQualifyingRate; v16.Clean = value; _mortgageAmountUsedForQualifyingRate = v16;
                var v17 = _mortgageAmountUsedForQualifyingRateD1; v17.Clean = value; _mortgageAmountUsedForQualifyingRateD1 = v17;
                var v18 = _newOrExisting; v18.Clean = value; _newOrExisting = v18;
                var v19 = _originalSalesPriceIfLess12Months; v19.Clean = value; _originalSalesPriceIfLess12Months = v19;
                var v20 = _otherHousingPayment; v20.Clean = value; _otherHousingPayment = v20;
                var v21 = _solarNotIncluded; v21.Clean = value; _solarNotIncluded = v21;
                var v22 = _solarSystemCostAllowance; v22.Clean = value; _solarSystemCostAllowance = v22;
                var v23 = _totalActualAmount; v23.Clean = value; _totalActualAmount = v23;
                var v24 = _totalAllowedAmount; v24.Clean = value; _totalAllowedAmount = v24;
                var v25 = _totalBaseEemLoanAmount; v25.Clean = value; _totalBaseEemLoanAmount = v25;
                var v26 = _totalCombinedLoanAmount; v26.Clean = value; _totalCombinedLoanAmount = v26;
                var v27 = _totalMonthlyHousingPayment; v27.Clean = value; _totalMonthlyHousingPayment = v27;
                var v28 = _totalMonthlyObligations; v28.Clean = value; _totalMonthlyObligations = v28;
                var v29 = _ufmipBasedOn; v29.Clean = value; _ufmipBasedOn = v29;
                var v30 = _ufmipFactor; v30.Clean = value; _ufmipFactor = v30;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}