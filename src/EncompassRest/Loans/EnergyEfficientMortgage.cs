using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgage : IDirty
    {
        private DirtyValue<decimal?> _appraisedValue;
        public decimal? AppraisedValue { get { return _appraisedValue; } set { _appraisedValue = value; } }
        private DirtyValue<decimal?> _auditCost;
        public decimal? AuditCost { get { return _auditCost; } set { _auditCost = value; } }
        private DirtyValue<decimal?> _backRatio;
        public decimal? BackRatio { get { return _backRatio; } set { _backRatio = value; } }
        private DirtyValue<decimal?> _baseLoanAmtFromTsum;
        public decimal? BaseLoanAmtFromTsum { get { return _baseLoanAmtFromTsum; } set { _baseLoanAmtFromTsum = value; } }
        private DirtyValue<decimal?> _costEffectiveEnergyPackage;
        public decimal? CostEffectiveEnergyPackage { get { return _costEffectiveEnergyPackage; } set { _costEffectiveEnergyPackage = value; } }
        private DirtyValue<decimal?> _eeCostMaximumAmount;
        public decimal? EeCostMaximumAmount { get { return _eeCostMaximumAmount; } set { _eeCostMaximumAmount = value; } }
        private DirtyValue<decimal?> _eeImprovementsInstalledCost;
        public decimal? EeImprovementsInstalledCost { get { return _eeImprovementsInstalledCost; } set { _eeImprovementsInstalledCost = value; } }
        private DirtyValue<decimal?> _energyCost;
        public decimal? EnergyCost { get { return _energyCost; } set { _energyCost = value; } }
        private DirtyValue<decimal?> _energySavings;
        public decimal? EnergySavings { get { return _energySavings; } set { _energySavings = value; } }
        private DirtyValue<decimal?> _hoa;
        public decimal? Hoa { get { return _hoa; } set { _hoa = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<decimal?> _improvementCostExceed2000;
        public decimal? ImprovementCostExceed2000 { get { return _improvementCostExceed2000; } set { _improvementCostExceed2000 = value; } }
        private DirtyValue<decimal?> _inspectionCost;
        public decimal? InspectionCost { get { return _inspectionCost; } set { _inspectionCost = value; } }
        private DirtyValue<decimal?> _lesserC1ORC2;
        public decimal? LesserC1ORC2 { get { return _lesserC1ORC2; } set { _lesserC1ORC2 = value; } }
        private DirtyValue<decimal?> _monthlyHousingPayment;
        public decimal? MonthlyHousingPayment { get { return _monthlyHousingPayment; } set { _monthlyHousingPayment = value; } }
        private DirtyValue<decimal?> _monthlyMI;
        public decimal? MonthlyMI { get { return _monthlyMI; } set { _monthlyMI = value; } }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRate;
        public decimal? MortgageAmountUsedForQualifyingRate { get { return _mortgageAmountUsedForQualifyingRate; } set { _mortgageAmountUsedForQualifyingRate = value; } }
        private DirtyValue<decimal?> _mortgageAmountUsedForQualifyingRateD1;
        public decimal? MortgageAmountUsedForQualifyingRateD1 { get { return _mortgageAmountUsedForQualifyingRateD1; } set { _mortgageAmountUsedForQualifyingRateD1 = value; } }
        private DirtyValue<bool?> _newOrExisting;
        public bool? NewOrExisting { get { return _newOrExisting; } set { _newOrExisting = value; } }
        private DirtyValue<decimal?> _originalSalesPriceIfLess12Months;
        public decimal? OriginalSalesPriceIfLess12Months { get { return _originalSalesPriceIfLess12Months; } set { _originalSalesPriceIfLess12Months = value; } }
        private DirtyValue<decimal?> _otherHousingPayment;
        public decimal? OtherHousingPayment { get { return _otherHousingPayment; } set { _otherHousingPayment = value; } }
        private DirtyValue<decimal?> _solarNotIncluded;
        public decimal? SolarNotIncluded { get { return _solarNotIncluded; } set { _solarNotIncluded = value; } }
        private DirtyValue<decimal?> _solarSystemCostAllowance;
        public decimal? SolarSystemCostAllowance { get { return _solarSystemCostAllowance; } set { _solarSystemCostAllowance = value; } }
        private DirtyValue<decimal?> _totalActualAmount;
        public decimal? TotalActualAmount { get { return _totalActualAmount; } set { _totalActualAmount = value; } }
        private DirtyValue<decimal?> _totalAllowedAmount;
        public decimal? TotalAllowedAmount { get { return _totalAllowedAmount; } set { _totalAllowedAmount = value; } }
        private DirtyValue<decimal?> _totalBaseEemLoanAmount;
        public decimal? TotalBaseEemLoanAmount { get { return _totalBaseEemLoanAmount; } set { _totalBaseEemLoanAmount = value; } }
        private DirtyValue<decimal?> _totalCombinedLoanAmount;
        public decimal? TotalCombinedLoanAmount { get { return _totalCombinedLoanAmount; } set { _totalCombinedLoanAmount = value; } }
        private DirtyValue<decimal?> _totalMonthlyHousingPayment;
        public decimal? TotalMonthlyHousingPayment { get { return _totalMonthlyHousingPayment; } set { _totalMonthlyHousingPayment = value; } }
        private DirtyValue<decimal?> _totalMonthlyObligations;
        public decimal? TotalMonthlyObligations { get { return _totalMonthlyObligations; } set { _totalMonthlyObligations = value; } }
        private DirtyValue<decimal?> _ufmipBasedOn;
        public decimal? UfmipBasedOn { get { return _ufmipBasedOn; } set { _ufmipBasedOn = value; } }
        private DirtyValue<decimal?> _ufmipFactor;
        public decimal? UfmipFactor { get { return _ufmipFactor; } set { _ufmipFactor = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _appraisedValue.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}