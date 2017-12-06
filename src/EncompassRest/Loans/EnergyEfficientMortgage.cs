#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgage : ExtensibleObject
    {
        private DirtyValue<decimal?> _appraisedValue;
        public decimal? AppraisedValue { get => _appraisedValue; set => _appraisedValue = value; }
        private DirtyValue<decimal?> _auditCost;
        public decimal? AuditCost { get => _auditCost; set => _auditCost = value; }
        private DirtyValue<decimal?> _backRatio;
        public decimal? BackRatio { get => _backRatio; set => _backRatio = value; }
        private DirtyValue<decimal?> _baseLoanAmtFromTsum;
        public decimal? BaseLoanAmtFromTsum { get => _baseLoanAmtFromTsum; set => _baseLoanAmtFromTsum = value; }
        private DirtyValue<decimal?> _costEffectiveEnergyPackage;
        public decimal? CostEffectiveEnergyPackage { get => _costEffectiveEnergyPackage; set => _costEffectiveEnergyPackage = value; }
        private DirtyValue<decimal?> _eeCostMaximumAmount;
        public decimal? EeCostMaximumAmount { get => _eeCostMaximumAmount; set => _eeCostMaximumAmount = value; }
        private DirtyValue<decimal?> _eeImprovementsInstalledCost;
        public decimal? EeImprovementsInstalledCost { get => _eeImprovementsInstalledCost; set => _eeImprovementsInstalledCost = value; }
        private DirtyValue<decimal?> _energyCost;
        public decimal? EnergyCost { get => _energyCost; set => _energyCost = value; }
        private DirtyValue<decimal?> _energySavings;
        public decimal? EnergySavings { get => _energySavings; set => _energySavings = value; }
        private DirtyValue<decimal?> _hoa;
        public decimal? Hoa { get => _hoa; set => _hoa = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _improvementCostExceed2000;
        public decimal? ImprovementCostExceed2000 { get => _improvementCostExceed2000; set => _improvementCostExceed2000 = value; }
        private DirtyValue<decimal?> _inspectionCost;
        public decimal? InspectionCost { get => _inspectionCost; set => _inspectionCost = value; }
        private DirtyValue<decimal?> _lesserC1ORC2;
        public decimal? LesserC1ORC2 { get => _lesserC1ORC2; set => _lesserC1ORC2 = value; }
        private DirtyValue<decimal?> _monthlyHousingPayment;
        public decimal? MonthlyHousingPayment { get => _monthlyHousingPayment; set => _monthlyHousingPayment = value; }
        private DirtyValue<decimal?> _monthlyMI;
        public decimal? MonthlyMI { get => _monthlyMI; set => _monthlyMI = value; }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRate;
        public decimal? MortgageAmountUsedForQualifyingRate { get => _mortgageAmountUsedForQualifyingRate; set => _mortgageAmountUsedForQualifyingRate = value; }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRateD1;
        public decimal? MortgageAmountUsedForQualifyingRateD1 { get => _mortgageAmountUsedForQualifyingRateD1; set => _mortgageAmountUsedForQualifyingRateD1 = value; }
        private DirtyValue<bool?> _newOrExisting;
        public bool? NewOrExisting { get => _newOrExisting; set => _newOrExisting = value; }
        private DirtyValue<decimal?> _originalSalesPriceIfLess12Months;
        public decimal? OriginalSalesPriceIfLess12Months { get => _originalSalesPriceIfLess12Months; set => _originalSalesPriceIfLess12Months = value; }
        private DirtyValue<decimal?> _otherHousingPayment;
        public decimal? OtherHousingPayment { get => _otherHousingPayment; set => _otherHousingPayment = value; }
        private DirtyValue<decimal?> _solarNotIncluded;
        public decimal? SolarNotIncluded { get => _solarNotIncluded; set => _solarNotIncluded = value; }
        private DirtyValue<decimal?> _solarSystemCostAllowance;
        public decimal? SolarSystemCostAllowance { get => _solarSystemCostAllowance; set => _solarSystemCostAllowance = value; }
        private DirtyValue<decimal?> _totalActualAmount;
        public decimal? TotalActualAmount { get => _totalActualAmount; set => _totalActualAmount = value; }
        private DirtyValue<decimal?> _totalAllowedAmount;
        public decimal? TotalAllowedAmount { get => _totalAllowedAmount; set => _totalAllowedAmount = value; }
        private DirtyValue<decimal?> _totalBaseEemLoanAmount;
        public decimal? TotalBaseEemLoanAmount { get => _totalBaseEemLoanAmount; set => _totalBaseEemLoanAmount = value; }
        private DirtyValue<decimal?> _totalCombinedLoanAmount;
        public decimal? TotalCombinedLoanAmount { get => _totalCombinedLoanAmount; set => _totalCombinedLoanAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyHousingPayment;
        public decimal? TotalMonthlyHousingPayment { get => _totalMonthlyHousingPayment; set => _totalMonthlyHousingPayment = value; }
        private DirtyValue<decimal?> _totalMonthlyObligations;
        public decimal? TotalMonthlyObligations { get => _totalMonthlyObligations; set => _totalMonthlyObligations = value; }
        private DirtyValue<decimal?> _ufmipBasedOn;
        public decimal? UfmipBasedOn { get => _ufmipBasedOn; set => _ufmipBasedOn = value; }
        private DirtyValue<decimal?> _ufmipFactor;
        public decimal? UfmipFactor { get => _ufmipFactor; set => _ufmipFactor = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _appraisedValue.Dirty
                    || _auditCost.Dirty
                    || _backRatio.Dirty
                    || _baseLoanAmtFromTsum.Dirty
                    || _costEffectiveEnergyPackage.Dirty
                    || _eeCostMaximumAmount.Dirty
                    || _eeImprovementsInstalledCost.Dirty
                    || _energyCost.Dirty
                    || _energySavings.Dirty
                    || _hoa.Dirty
                    || _id.Dirty
                    || _improvementCostExceed2000.Dirty
                    || _inspectionCost.Dirty
                    || _lesserC1ORC2.Dirty
                    || _monthlyHousingPayment.Dirty
                    || _monthlyMI.Dirty
                    || _mortgageAmountUsedForQualifyingRate.Dirty
                    || _mortgageAmountUsedForQualifyingRateD1.Dirty
                    || _newOrExisting.Dirty
                    || _originalSalesPriceIfLess12Months.Dirty
                    || _otherHousingPayment.Dirty
                    || _solarNotIncluded.Dirty
                    || _solarSystemCostAllowance.Dirty
                    || _totalActualAmount.Dirty
                    || _totalAllowedAmount.Dirty
                    || _totalBaseEemLoanAmount.Dirty
                    || _totalCombinedLoanAmount.Dirty
                    || _totalMonthlyHousingPayment.Dirty
                    || _totalMonthlyObligations.Dirty
                    || _ufmipBasedOn.Dirty
                    || _ufmipFactor.Dirty;
            }
            set
            {
                _appraisedValue.Dirty = value;
                _auditCost.Dirty = value;
                _backRatio.Dirty = value;
                _baseLoanAmtFromTsum.Dirty = value;
                _costEffectiveEnergyPackage.Dirty = value;
                _eeCostMaximumAmount.Dirty = value;
                _eeImprovementsInstalledCost.Dirty = value;
                _energyCost.Dirty = value;
                _energySavings.Dirty = value;
                _hoa.Dirty = value;
                _id.Dirty = value;
                _improvementCostExceed2000.Dirty = value;
                _inspectionCost.Dirty = value;
                _lesserC1ORC2.Dirty = value;
                _monthlyHousingPayment.Dirty = value;
                _monthlyMI.Dirty = value;
                _mortgageAmountUsedForQualifyingRate.Dirty = value;
                _mortgageAmountUsedForQualifyingRateD1.Dirty = value;
                _newOrExisting.Dirty = value;
                _originalSalesPriceIfLess12Months.Dirty = value;
                _otherHousingPayment.Dirty = value;
                _solarNotIncluded.Dirty = value;
                _solarSystemCostAllowance.Dirty = value;
                _totalActualAmount.Dirty = value;
                _totalAllowedAmount.Dirty = value;
                _totalBaseEemLoanAmount.Dirty = value;
                _totalCombinedLoanAmount.Dirty = value;
                _totalMonthlyHousingPayment.Dirty = value;
                _totalMonthlyObligations.Dirty = value;
                _ufmipBasedOn.Dirty = value;
                _ufmipFactor.Dirty = value;
            }
        }
    }
}