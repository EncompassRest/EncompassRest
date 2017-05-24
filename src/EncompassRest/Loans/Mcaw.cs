using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Mcaw
    {
        public Value<string> AdequacyOfAvailableAssetsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdequacyOfAvailableAssetsType() => !AdequacyOfAvailableAssetsType.Clean;
        public Value<string> AdequacyOfEffectiveIncomeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdequacyOfEffectiveIncomeType() => !AdequacyOfEffectiveIncomeType.Clean;
        public Value<decimal?> AdjustedPurchasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustedPurchasePrice() => !AdjustedPurchasePrice.Clean;
        public Value<decimal?> AppraisedValue1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisedValue1() => !AppraisedValue1.Clean;
        public Value<decimal?> AppraisedValue2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisedValue2() => !AppraisedValue2.Clean;
        public Value<decimal?> BorrowerPaidClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidClosingCost() => !BorrowerPaidClosingCost.Clean;
        public Value<decimal?> CalculatedMortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCalculatedMortgageAmount() => !CalculatedMortgageAmount.Clean;
        public Value<decimal?> CashReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashReserves() => !CashReserves.Clean;
        public Value<string> ConstructionType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionType() => !ConstructionType.Clean;
        public Value<decimal?> ContractSalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractSalesPrice() => !ContractSalesPrice.Clean;
        public Value<string> CreditCharacteristicsType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditCharacteristicsType() => !CreditCharacteristicsType.Clean;
        public Value<decimal?> EquityToExSpouse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquityToExSpouse() => !EquityToExSpouse.Clean;
        public Value<decimal?> FhaMaxLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaMaxLoanAmount() => !FhaMaxLoanAmount.Clean;
        public Value<string> FhaUnderwriterChumsId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaUnderwriterChumsId() => !FhaUnderwriterChumsId.Clean;
        public Value<string> GiftFundsSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGiftFundsSource() => !GiftFundsSource.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> LesserSalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLesserSalesPrice() => !LesserSalesPrice.Clean;
        public Value<decimal?> Ltv1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv1() => !Ltv1.Clean;
        public Value<decimal?> Ltv2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv2() => !Ltv2.Clean;
        public Value<decimal?> MaximumSellerContribution4Percent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumSellerContribution4Percent() => !MaximumSellerContribution4Percent.Clean;
        public Value<decimal?> MortgageAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAmount() => !MortgageAmount.Clean;
        public Value<decimal?> MortgageAmountPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAmountPercent() => !MortgageAmountPercent.Clean;
        public Value<decimal?> MortgageBasisPurchase { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBasisPurchase() => !MortgageBasisPurchase.Clean;
        public Value<decimal?> MortgageBasisRefinance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBasisRefinance() => !MortgageBasisRefinance.Clean;
        public Value<string> PaidType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidType1() => !PaidType1.Clean;
        public Value<string> PaidType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidType2() => !PaidType2.Clean;
        public Value<decimal?> PrincipalBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalBalance() => !PrincipalBalance.Clean;
        public Value<string> RefinanceType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceType() => !RefinanceType.Clean;
        public Value<string> Remarks { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRemarks() => !Remarks.Clean;
        public Value<decimal?> RepairsAndImprovements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairsAndImprovements() => !RepairsAndImprovements.Clean;
        public Value<string> RepairsAndImprovementsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairsAndImprovementsDescription() => !RepairsAndImprovementsDescription.Clean;
        public Value<decimal?> RepairsImprovementAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairsImprovementAmount() => !RepairsImprovementAmount.Clean;
        public Value<decimal?> RepairsRequiredByAppraiser { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepairsRequiredByAppraiser() => !RepairsRequiredByAppraiser.Clean;
        public Value<decimal?> RequiredInvestment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequiredInvestment() => !RequiredInvestment.Clean;
        public Value<decimal?> RequirementAdjustment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequirementAdjustment() => !RequirementAdjustment.Clean;
        public Value<bool?> RoundTo50Indicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRoundTo50Indicator() => !RoundTo50Indicator.Clean;
        public Value<decimal?> SeasonedSubordinateLiens { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeasonedSubordinateLiens() => !SeasonedSubordinateLiens.Clean;
        public Value<string> SecondMortgageSource { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondMortgageSource() => !SecondMortgageSource.Clean;
        public Value<decimal?> SixPercentOfLineA1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSixPercentOfLineA1() => !SixPercentOfLineA1.Clean;
        public Value<string> StabilityOfEffectiveIncomeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStabilityOfEffectiveIncomeType() => !StabilityOfEffectiveIncomeType.Clean;
        public Value<decimal?> StatutoryInvestment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStatutoryInvestment() => !StatutoryInvestment.Clean;
        public Value<decimal?> ToBePaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeToBePaidAmount() => !ToBePaidAmount.Clean;
        public Value<decimal?> TotalCashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCashToClose() => !TotalCashToClose.Clean;
        public Value<decimal?> TotalRequirements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalRequirements() => !TotalRequirements.Clean;
        public Value<decimal?> TotalSellerContribution { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSellerContribution() => !TotalSellerContribution.Clean;
        public Value<decimal?> UnadjustedAcquisition { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnadjustedAcquisition() => !UnadjustedAcquisition.Clean;
        public Value<bool?> Use85PercentRuleIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUse85PercentRuleIndicator() => !Use85PercentRuleIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdequacyOfAvailableAssetsType.Clean
                    && AdequacyOfEffectiveIncomeType.Clean
                    && AdjustedPurchasePrice.Clean
                    && AppraisedValue1.Clean
                    && AppraisedValue2.Clean
                    && BorrowerPaidClosingCost.Clean
                    && CalculatedMortgageAmount.Clean
                    && CashReserves.Clean
                    && ConstructionType.Clean
                    && ContractSalesPrice.Clean
                    && CreditCharacteristicsType.Clean
                    && EquityToExSpouse.Clean
                    && FhaMaxLoanAmount.Clean
                    && FhaUnderwriterChumsId.Clean
                    && GiftFundsSource.Clean
                    && Id.Clean
                    && LesserSalesPrice.Clean
                    && Ltv1.Clean
                    && Ltv2.Clean
                    && MaximumSellerContribution4Percent.Clean
                    && MortgageAmount.Clean
                    && MortgageAmountPercent.Clean
                    && MortgageBasisPurchase.Clean
                    && MortgageBasisRefinance.Clean
                    && PaidType1.Clean
                    && PaidType2.Clean
                    && PrincipalBalance.Clean
                    && RefinanceType.Clean
                    && Remarks.Clean
                    && RepairsAndImprovements.Clean
                    && RepairsAndImprovementsDescription.Clean
                    && RepairsImprovementAmount.Clean
                    && RepairsRequiredByAppraiser.Clean
                    && RequiredInvestment.Clean
                    && RequirementAdjustment.Clean
                    && RoundTo50Indicator.Clean
                    && SeasonedSubordinateLiens.Clean
                    && SecondMortgageSource.Clean
                    && SixPercentOfLineA1.Clean
                    && StabilityOfEffectiveIncomeType.Clean
                    && StatutoryInvestment.Clean
                    && ToBePaidAmount.Clean
                    && TotalCashToClose.Clean
                    && TotalRequirements.Clean
                    && TotalSellerContribution.Clean
                    && UnadjustedAcquisition.Clean
                    && Use85PercentRuleIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdequacyOfAvailableAssetsType; v0.Clean = value; AdequacyOfAvailableAssetsType = v0;
                var v1 = AdequacyOfEffectiveIncomeType; v1.Clean = value; AdequacyOfEffectiveIncomeType = v1;
                var v2 = AdjustedPurchasePrice; v2.Clean = value; AdjustedPurchasePrice = v2;
                var v3 = AppraisedValue1; v3.Clean = value; AppraisedValue1 = v3;
                var v4 = AppraisedValue2; v4.Clean = value; AppraisedValue2 = v4;
                var v5 = BorrowerPaidClosingCost; v5.Clean = value; BorrowerPaidClosingCost = v5;
                var v6 = CalculatedMortgageAmount; v6.Clean = value; CalculatedMortgageAmount = v6;
                var v7 = CashReserves; v7.Clean = value; CashReserves = v7;
                var v8 = ConstructionType; v8.Clean = value; ConstructionType = v8;
                var v9 = ContractSalesPrice; v9.Clean = value; ContractSalesPrice = v9;
                var v10 = CreditCharacteristicsType; v10.Clean = value; CreditCharacteristicsType = v10;
                var v11 = EquityToExSpouse; v11.Clean = value; EquityToExSpouse = v11;
                var v12 = FhaMaxLoanAmount; v12.Clean = value; FhaMaxLoanAmount = v12;
                var v13 = FhaUnderwriterChumsId; v13.Clean = value; FhaUnderwriterChumsId = v13;
                var v14 = GiftFundsSource; v14.Clean = value; GiftFundsSource = v14;
                var v15 = Id; v15.Clean = value; Id = v15;
                var v16 = LesserSalesPrice; v16.Clean = value; LesserSalesPrice = v16;
                var v17 = Ltv1; v17.Clean = value; Ltv1 = v17;
                var v18 = Ltv2; v18.Clean = value; Ltv2 = v18;
                var v19 = MaximumSellerContribution4Percent; v19.Clean = value; MaximumSellerContribution4Percent = v19;
                var v20 = MortgageAmount; v20.Clean = value; MortgageAmount = v20;
                var v21 = MortgageAmountPercent; v21.Clean = value; MortgageAmountPercent = v21;
                var v22 = MortgageBasisPurchase; v22.Clean = value; MortgageBasisPurchase = v22;
                var v23 = MortgageBasisRefinance; v23.Clean = value; MortgageBasisRefinance = v23;
                var v24 = PaidType1; v24.Clean = value; PaidType1 = v24;
                var v25 = PaidType2; v25.Clean = value; PaidType2 = v25;
                var v26 = PrincipalBalance; v26.Clean = value; PrincipalBalance = v26;
                var v27 = RefinanceType; v27.Clean = value; RefinanceType = v27;
                var v28 = Remarks; v28.Clean = value; Remarks = v28;
                var v29 = RepairsAndImprovements; v29.Clean = value; RepairsAndImprovements = v29;
                var v30 = RepairsAndImprovementsDescription; v30.Clean = value; RepairsAndImprovementsDescription = v30;
                var v31 = RepairsImprovementAmount; v31.Clean = value; RepairsImprovementAmount = v31;
                var v32 = RepairsRequiredByAppraiser; v32.Clean = value; RepairsRequiredByAppraiser = v32;
                var v33 = RequiredInvestment; v33.Clean = value; RequiredInvestment = v33;
                var v34 = RequirementAdjustment; v34.Clean = value; RequirementAdjustment = v34;
                var v35 = RoundTo50Indicator; v35.Clean = value; RoundTo50Indicator = v35;
                var v36 = SeasonedSubordinateLiens; v36.Clean = value; SeasonedSubordinateLiens = v36;
                var v37 = SecondMortgageSource; v37.Clean = value; SecondMortgageSource = v37;
                var v38 = SixPercentOfLineA1; v38.Clean = value; SixPercentOfLineA1 = v38;
                var v39 = StabilityOfEffectiveIncomeType; v39.Clean = value; StabilityOfEffectiveIncomeType = v39;
                var v40 = StatutoryInvestment; v40.Clean = value; StatutoryInvestment = v40;
                var v41 = ToBePaidAmount; v41.Clean = value; ToBePaidAmount = v41;
                var v42 = TotalCashToClose; v42.Clean = value; TotalCashToClose = v42;
                var v43 = TotalRequirements; v43.Clean = value; TotalRequirements = v43;
                var v44 = TotalSellerContribution; v44.Clean = value; TotalSellerContribution = v44;
                var v45 = UnadjustedAcquisition; v45.Clean = value; UnadjustedAcquisition = v45;
                var v46 = Use85PercentRuleIndicator; v46.Clean = value; Use85PercentRuleIndicator = v46;
                _settingClean = 0;
            }
        }
    }
}