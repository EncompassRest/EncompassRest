using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class EnergyEfficientMortgage
    {
        public Value<decimal?> AppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisedValue() => !AppraisedValue.Clean;
        public Value<decimal?> AuditCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAuditCost() => !AuditCost.Clean;
        public Value<decimal?> BackRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBackRatio() => !BackRatio.Clean;
        public Value<decimal?> BaseLoanAmtFromTsum { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseLoanAmtFromTsum() => !BaseLoanAmtFromTsum.Clean;
        public Value<decimal?> CostEffectiveEnergyPackage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCostEffectiveEnergyPackage() => !CostEffectiveEnergyPackage.Clean;
        public Value<decimal?> EeCostMaximumAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEeCostMaximumAmount() => !EeCostMaximumAmount.Clean;
        public Value<decimal?> EeImprovementsInstalledCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEeImprovementsInstalledCost() => !EeImprovementsInstalledCost.Clean;
        public Value<decimal?> EnergyCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergyCost() => !EnergyCost.Clean;
        public Value<decimal?> EnergySavings { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnergySavings() => !EnergySavings.Clean;
        public Value<decimal?> Hoa { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoa() => !Hoa.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> ImprovementCostExceed2000 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImprovementCostExceed2000() => !ImprovementCostExceed2000.Clean;
        public Value<decimal?> InspectionCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInspectionCost() => !InspectionCost.Clean;
        public Value<decimal?> LesserC1ORC2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserC1ORC2() => !LesserC1ORC2.Clean;
        public Value<decimal?> MonthlyHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyHousingPayment() => !MonthlyHousingPayment.Clean;
        public Value<decimal?> MonthlyMI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyMI() => !MonthlyMI.Clean;
        public Value<decimal?> MortgageAmountUsedForQualifyingRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAmountUsedForQualifyingRate() => !MortgageAmountUsedForQualifyingRate.Clean;
        public Value<decimal?> MortgageAmountUsedForQualifyingRateD1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAmountUsedForQualifyingRateD1() => !MortgageAmountUsedForQualifyingRateD1.Clean;
        public Value<bool?> NewOrExisting { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNewOrExisting() => !NewOrExisting.Clean;
        public Value<decimal?> OriginalSalesPriceIfLess12Months { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalSalesPriceIfLess12Months() => !OriginalSalesPriceIfLess12Months.Clean;
        public Value<decimal?> OtherHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherHousingPayment() => !OtherHousingPayment.Clean;
        public Value<decimal?> SolarNotIncluded { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSolarNotIncluded() => !SolarNotIncluded.Clean;
        public Value<decimal?> SolarSystemCostAllowance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSolarSystemCostAllowance() => !SolarSystemCostAllowance.Clean;
        public Value<decimal?> TotalActualAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalActualAmount() => !TotalActualAmount.Clean;
        public Value<decimal?> TotalAllowedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAllowedAmount() => !TotalAllowedAmount.Clean;
        public Value<decimal?> TotalBaseEemLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBaseEemLoanAmount() => !TotalBaseEemLoanAmount.Clean;
        public Value<decimal?> TotalCombinedLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCombinedLoanAmount() => !TotalCombinedLoanAmount.Clean;
        public Value<decimal?> TotalMonthlyHousingPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyHousingPayment() => !TotalMonthlyHousingPayment.Clean;
        public Value<decimal?> TotalMonthlyObligations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyObligations() => !TotalMonthlyObligations.Clean;
        public Value<decimal?> UfmipBasedOn { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUfmipBasedOn() => !UfmipBasedOn.Clean;
        public Value<decimal?> UfmipFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUfmipFactor() => !UfmipFactor.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AppraisedValue.Clean
                    && AuditCost.Clean
                    && BackRatio.Clean
                    && BaseLoanAmtFromTsum.Clean
                    && CostEffectiveEnergyPackage.Clean
                    && EeCostMaximumAmount.Clean
                    && EeImprovementsInstalledCost.Clean
                    && EnergyCost.Clean
                    && EnergySavings.Clean
                    && Hoa.Clean
                    && Id.Clean
                    && ImprovementCostExceed2000.Clean
                    && InspectionCost.Clean
                    && LesserC1ORC2.Clean
                    && MonthlyHousingPayment.Clean
                    && MonthlyMI.Clean
                    && MortgageAmountUsedForQualifyingRate.Clean
                    && MortgageAmountUsedForQualifyingRateD1.Clean
                    && NewOrExisting.Clean
                    && OriginalSalesPriceIfLess12Months.Clean
                    && OtherHousingPayment.Clean
                    && SolarNotIncluded.Clean
                    && SolarSystemCostAllowance.Clean
                    && TotalActualAmount.Clean
                    && TotalAllowedAmount.Clean
                    && TotalBaseEemLoanAmount.Clean
                    && TotalCombinedLoanAmount.Clean
                    && TotalMonthlyHousingPayment.Clean
                    && TotalMonthlyObligations.Clean
                    && UfmipBasedOn.Clean
                    && UfmipFactor.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AppraisedValue; v0.Clean = value; AppraisedValue = v0;
                var v1 = AuditCost; v1.Clean = value; AuditCost = v1;
                var v2 = BackRatio; v2.Clean = value; BackRatio = v2;
                var v3 = BaseLoanAmtFromTsum; v3.Clean = value; BaseLoanAmtFromTsum = v3;
                var v4 = CostEffectiveEnergyPackage; v4.Clean = value; CostEffectiveEnergyPackage = v4;
                var v5 = EeCostMaximumAmount; v5.Clean = value; EeCostMaximumAmount = v5;
                var v6 = EeImprovementsInstalledCost; v6.Clean = value; EeImprovementsInstalledCost = v6;
                var v7 = EnergyCost; v7.Clean = value; EnergyCost = v7;
                var v8 = EnergySavings; v8.Clean = value; EnergySavings = v8;
                var v9 = Hoa; v9.Clean = value; Hoa = v9;
                var v10 = Id; v10.Clean = value; Id = v10;
                var v11 = ImprovementCostExceed2000; v11.Clean = value; ImprovementCostExceed2000 = v11;
                var v12 = InspectionCost; v12.Clean = value; InspectionCost = v12;
                var v13 = LesserC1ORC2; v13.Clean = value; LesserC1ORC2 = v13;
                var v14 = MonthlyHousingPayment; v14.Clean = value; MonthlyHousingPayment = v14;
                var v15 = MonthlyMI; v15.Clean = value; MonthlyMI = v15;
                var v16 = MortgageAmountUsedForQualifyingRate; v16.Clean = value; MortgageAmountUsedForQualifyingRate = v16;
                var v17 = MortgageAmountUsedForQualifyingRateD1; v17.Clean = value; MortgageAmountUsedForQualifyingRateD1 = v17;
                var v18 = NewOrExisting; v18.Clean = value; NewOrExisting = v18;
                var v19 = OriginalSalesPriceIfLess12Months; v19.Clean = value; OriginalSalesPriceIfLess12Months = v19;
                var v20 = OtherHousingPayment; v20.Clean = value; OtherHousingPayment = v20;
                var v21 = SolarNotIncluded; v21.Clean = value; SolarNotIncluded = v21;
                var v22 = SolarSystemCostAllowance; v22.Clean = value; SolarSystemCostAllowance = v22;
                var v23 = TotalActualAmount; v23.Clean = value; TotalActualAmount = v23;
                var v24 = TotalAllowedAmount; v24.Clean = value; TotalAllowedAmount = v24;
                var v25 = TotalBaseEemLoanAmount; v25.Clean = value; TotalBaseEemLoanAmount = v25;
                var v26 = TotalCombinedLoanAmount; v26.Clean = value; TotalCombinedLoanAmount = v26;
                var v27 = TotalMonthlyHousingPayment; v27.Clean = value; TotalMonthlyHousingPayment = v27;
                var v28 = TotalMonthlyObligations; v28.Clean = value; TotalMonthlyObligations = v28;
                var v29 = UfmipBasedOn; v29.Clean = value; UfmipBasedOn = v29;
                var v30 = UfmipFactor; v30.Clean = value; UfmipFactor = v30;
                _settingClean = 0;
            }
        }
    }
}