using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Mcaw : IClean
    {
        private Value<string> _adequacyOfAvailableAssetsType;
        public string AdequacyOfAvailableAssetsType { get { return _adequacyOfAvailableAssetsType; } set { _adequacyOfAvailableAssetsType = value; } }
        private Value<string> _adequacyOfEffectiveIncomeType;
        public string AdequacyOfEffectiveIncomeType { get { return _adequacyOfEffectiveIncomeType; } set { _adequacyOfEffectiveIncomeType = value; } }
        private Value<decimal?> _adjustedPurchasePrice;
        public decimal? AdjustedPurchasePrice { get { return _adjustedPurchasePrice; } set { _adjustedPurchasePrice = value; } }
        private Value<decimal?> _appraisedValue1;
        public decimal? AppraisedValue1 { get { return _appraisedValue1; } set { _appraisedValue1 = value; } }
        private Value<decimal?> _appraisedValue2;
        public decimal? AppraisedValue2 { get { return _appraisedValue2; } set { _appraisedValue2 = value; } }
        private Value<decimal?> _borrowerPaidClosingCost;
        public decimal? BorrowerPaidClosingCost { get { return _borrowerPaidClosingCost; } set { _borrowerPaidClosingCost = value; } }
        private Value<decimal?> _calculatedMortgageAmount;
        public decimal? CalculatedMortgageAmount { get { return _calculatedMortgageAmount; } set { _calculatedMortgageAmount = value; } }
        private Value<decimal?> _cashReserves;
        public decimal? CashReserves { get { return _cashReserves; } set { _cashReserves = value; } }
        private Value<string> _constructionType;
        public string ConstructionType { get { return _constructionType; } set { _constructionType = value; } }
        private Value<decimal?> _contractSalesPrice;
        public decimal? ContractSalesPrice { get { return _contractSalesPrice; } set { _contractSalesPrice = value; } }
        private Value<string> _creditCharacteristicsType;
        public string CreditCharacteristicsType { get { return _creditCharacteristicsType; } set { _creditCharacteristicsType = value; } }
        private Value<decimal?> _equityToExSpouse;
        public decimal? EquityToExSpouse { get { return _equityToExSpouse; } set { _equityToExSpouse = value; } }
        private Value<decimal?> _fhaMaxLoanAmount;
        public decimal? FhaMaxLoanAmount { get { return _fhaMaxLoanAmount; } set { _fhaMaxLoanAmount = value; } }
        private Value<string> _fhaUnderwriterChumsId;
        public string FhaUnderwriterChumsId { get { return _fhaUnderwriterChumsId; } set { _fhaUnderwriterChumsId = value; } }
        private Value<string> _giftFundsSource;
        public string GiftFundsSource { get { return _giftFundsSource; } set { _giftFundsSource = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _lesserSalesPrice;
        public decimal? LesserSalesPrice { get { return _lesserSalesPrice; } set { _lesserSalesPrice = value; } }
        private Value<decimal?> _ltv1;
        public decimal? Ltv1 { get { return _ltv1; } set { _ltv1 = value; } }
        private Value<decimal?> _ltv2;
        public decimal? Ltv2 { get { return _ltv2; } set { _ltv2 = value; } }
        private Value<decimal?> _maximumSellerContribution4Percent;
        public decimal? MaximumSellerContribution4Percent { get { return _maximumSellerContribution4Percent; } set { _maximumSellerContribution4Percent = value; } }
        private Value<decimal?> _mortgageAmount;
        public decimal? MortgageAmount { get { return _mortgageAmount; } set { _mortgageAmount = value; } }
        private Value<decimal?> _mortgageAmountPercent;
        public decimal? MortgageAmountPercent { get { return _mortgageAmountPercent; } set { _mortgageAmountPercent = value; } }
        private Value<decimal?> _mortgageBasisPurchase;
        public decimal? MortgageBasisPurchase { get { return _mortgageBasisPurchase; } set { _mortgageBasisPurchase = value; } }
        private Value<decimal?> _mortgageBasisRefinance;
        public decimal? MortgageBasisRefinance { get { return _mortgageBasisRefinance; } set { _mortgageBasisRefinance = value; } }
        private Value<string> _paidType1;
        public string PaidType1 { get { return _paidType1; } set { _paidType1 = value; } }
        private Value<string> _paidType2;
        public string PaidType2 { get { return _paidType2; } set { _paidType2 = value; } }
        private Value<decimal?> _principalBalance;
        public decimal? PrincipalBalance { get { return _principalBalance; } set { _principalBalance = value; } }
        private Value<string> _refinanceType;
        public string RefinanceType { get { return _refinanceType; } set { _refinanceType = value; } }
        private Value<string> _remarks;
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        private Value<decimal?> _repairsAndImprovements;
        public decimal? RepairsAndImprovements { get { return _repairsAndImprovements; } set { _repairsAndImprovements = value; } }
        private Value<string> _repairsAndImprovementsDescription;
        public string RepairsAndImprovementsDescription { get { return _repairsAndImprovementsDescription; } set { _repairsAndImprovementsDescription = value; } }
        private Value<decimal?> _repairsImprovementAmount;
        public decimal? RepairsImprovementAmount { get { return _repairsImprovementAmount; } set { _repairsImprovementAmount = value; } }
        private Value<decimal?> _repairsRequiredByAppraiser;
        public decimal? RepairsRequiredByAppraiser { get { return _repairsRequiredByAppraiser; } set { _repairsRequiredByAppraiser = value; } }
        private Value<decimal?> _requiredInvestment;
        public decimal? RequiredInvestment { get { return _requiredInvestment; } set { _requiredInvestment = value; } }
        private Value<decimal?> _requirementAdjustment;
        public decimal? RequirementAdjustment { get { return _requirementAdjustment; } set { _requirementAdjustment = value; } }
        private Value<bool?> _roundTo50Indicator;
        public bool? RoundTo50Indicator { get { return _roundTo50Indicator; } set { _roundTo50Indicator = value; } }
        private Value<decimal?> _seasonedSubordinateLiens;
        public decimal? SeasonedSubordinateLiens { get { return _seasonedSubordinateLiens; } set { _seasonedSubordinateLiens = value; } }
        private Value<string> _secondMortgageSource;
        public string SecondMortgageSource { get { return _secondMortgageSource; } set { _secondMortgageSource = value; } }
        private Value<decimal?> _sixPercentOfLineA1;
        public decimal? SixPercentOfLineA1 { get { return _sixPercentOfLineA1; } set { _sixPercentOfLineA1 = value; } }
        private Value<string> _stabilityOfEffectiveIncomeType;
        public string StabilityOfEffectiveIncomeType { get { return _stabilityOfEffectiveIncomeType; } set { _stabilityOfEffectiveIncomeType = value; } }
        private Value<decimal?> _statutoryInvestment;
        public decimal? StatutoryInvestment { get { return _statutoryInvestment; } set { _statutoryInvestment = value; } }
        private Value<decimal?> _toBePaidAmount;
        public decimal? ToBePaidAmount { get { return _toBePaidAmount; } set { _toBePaidAmount = value; } }
        private Value<decimal?> _totalCashToClose;
        public decimal? TotalCashToClose { get { return _totalCashToClose; } set { _totalCashToClose = value; } }
        private Value<decimal?> _totalRequirements;
        public decimal? TotalRequirements { get { return _totalRequirements; } set { _totalRequirements = value; } }
        private Value<decimal?> _totalSellerContribution;
        public decimal? TotalSellerContribution { get { return _totalSellerContribution; } set { _totalSellerContribution = value; } }
        private Value<decimal?> _unadjustedAcquisition;
        public decimal? UnadjustedAcquisition { get { return _unadjustedAcquisition; } set { _unadjustedAcquisition = value; } }
        private Value<bool?> _use85PercentRuleIndicator;
        public bool? Use85PercentRuleIndicator { get { return _use85PercentRuleIndicator; } set { _use85PercentRuleIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adequacyOfAvailableAssetsType.Clean
                    && _adequacyOfEffectiveIncomeType.Clean
                    && _adjustedPurchasePrice.Clean
                    && _appraisedValue1.Clean
                    && _appraisedValue2.Clean
                    && _borrowerPaidClosingCost.Clean
                    && _calculatedMortgageAmount.Clean
                    && _cashReserves.Clean
                    && _constructionType.Clean
                    && _contractSalesPrice.Clean
                    && _creditCharacteristicsType.Clean
                    && _equityToExSpouse.Clean
                    && _fhaMaxLoanAmount.Clean
                    && _fhaUnderwriterChumsId.Clean
                    && _giftFundsSource.Clean
                    && _id.Clean
                    && _lesserSalesPrice.Clean
                    && _ltv1.Clean
                    && _ltv2.Clean
                    && _maximumSellerContribution4Percent.Clean
                    && _mortgageAmount.Clean
                    && _mortgageAmountPercent.Clean
                    && _mortgageBasisPurchase.Clean
                    && _mortgageBasisRefinance.Clean
                    && _paidType1.Clean
                    && _paidType2.Clean
                    && _principalBalance.Clean
                    && _refinanceType.Clean
                    && _remarks.Clean
                    && _repairsAndImprovements.Clean
                    && _repairsAndImprovementsDescription.Clean
                    && _repairsImprovementAmount.Clean
                    && _repairsRequiredByAppraiser.Clean
                    && _requiredInvestment.Clean
                    && _requirementAdjustment.Clean
                    && _roundTo50Indicator.Clean
                    && _seasonedSubordinateLiens.Clean
                    && _secondMortgageSource.Clean
                    && _sixPercentOfLineA1.Clean
                    && _stabilityOfEffectiveIncomeType.Clean
                    && _statutoryInvestment.Clean
                    && _toBePaidAmount.Clean
                    && _totalCashToClose.Clean
                    && _totalRequirements.Clean
                    && _totalSellerContribution.Clean
                    && _unadjustedAcquisition.Clean
                    && _use85PercentRuleIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _adequacyOfAvailableAssetsType; v0.Clean = value; _adequacyOfAvailableAssetsType = v0;
                var v1 = _adequacyOfEffectiveIncomeType; v1.Clean = value; _adequacyOfEffectiveIncomeType = v1;
                var v2 = _adjustedPurchasePrice; v2.Clean = value; _adjustedPurchasePrice = v2;
                var v3 = _appraisedValue1; v3.Clean = value; _appraisedValue1 = v3;
                var v4 = _appraisedValue2; v4.Clean = value; _appraisedValue2 = v4;
                var v5 = _borrowerPaidClosingCost; v5.Clean = value; _borrowerPaidClosingCost = v5;
                var v6 = _calculatedMortgageAmount; v6.Clean = value; _calculatedMortgageAmount = v6;
                var v7 = _cashReserves; v7.Clean = value; _cashReserves = v7;
                var v8 = _constructionType; v8.Clean = value; _constructionType = v8;
                var v9 = _contractSalesPrice; v9.Clean = value; _contractSalesPrice = v9;
                var v10 = _creditCharacteristicsType; v10.Clean = value; _creditCharacteristicsType = v10;
                var v11 = _equityToExSpouse; v11.Clean = value; _equityToExSpouse = v11;
                var v12 = _fhaMaxLoanAmount; v12.Clean = value; _fhaMaxLoanAmount = v12;
                var v13 = _fhaUnderwriterChumsId; v13.Clean = value; _fhaUnderwriterChumsId = v13;
                var v14 = _giftFundsSource; v14.Clean = value; _giftFundsSource = v14;
                var v15 = _id; v15.Clean = value; _id = v15;
                var v16 = _lesserSalesPrice; v16.Clean = value; _lesserSalesPrice = v16;
                var v17 = _ltv1; v17.Clean = value; _ltv1 = v17;
                var v18 = _ltv2; v18.Clean = value; _ltv2 = v18;
                var v19 = _maximumSellerContribution4Percent; v19.Clean = value; _maximumSellerContribution4Percent = v19;
                var v20 = _mortgageAmount; v20.Clean = value; _mortgageAmount = v20;
                var v21 = _mortgageAmountPercent; v21.Clean = value; _mortgageAmountPercent = v21;
                var v22 = _mortgageBasisPurchase; v22.Clean = value; _mortgageBasisPurchase = v22;
                var v23 = _mortgageBasisRefinance; v23.Clean = value; _mortgageBasisRefinance = v23;
                var v24 = _paidType1; v24.Clean = value; _paidType1 = v24;
                var v25 = _paidType2; v25.Clean = value; _paidType2 = v25;
                var v26 = _principalBalance; v26.Clean = value; _principalBalance = v26;
                var v27 = _refinanceType; v27.Clean = value; _refinanceType = v27;
                var v28 = _remarks; v28.Clean = value; _remarks = v28;
                var v29 = _repairsAndImprovements; v29.Clean = value; _repairsAndImprovements = v29;
                var v30 = _repairsAndImprovementsDescription; v30.Clean = value; _repairsAndImprovementsDescription = v30;
                var v31 = _repairsImprovementAmount; v31.Clean = value; _repairsImprovementAmount = v31;
                var v32 = _repairsRequiredByAppraiser; v32.Clean = value; _repairsRequiredByAppraiser = v32;
                var v33 = _requiredInvestment; v33.Clean = value; _requiredInvestment = v33;
                var v34 = _requirementAdjustment; v34.Clean = value; _requirementAdjustment = v34;
                var v35 = _roundTo50Indicator; v35.Clean = value; _roundTo50Indicator = v35;
                var v36 = _seasonedSubordinateLiens; v36.Clean = value; _seasonedSubordinateLiens = v36;
                var v37 = _secondMortgageSource; v37.Clean = value; _secondMortgageSource = v37;
                var v38 = _sixPercentOfLineA1; v38.Clean = value; _sixPercentOfLineA1 = v38;
                var v39 = _stabilityOfEffectiveIncomeType; v39.Clean = value; _stabilityOfEffectiveIncomeType = v39;
                var v40 = _statutoryInvestment; v40.Clean = value; _statutoryInvestment = v40;
                var v41 = _toBePaidAmount; v41.Clean = value; _toBePaidAmount = v41;
                var v42 = _totalCashToClose; v42.Clean = value; _totalCashToClose = v42;
                var v43 = _totalRequirements; v43.Clean = value; _totalRequirements = v43;
                var v44 = _totalSellerContribution; v44.Clean = value; _totalSellerContribution = v44;
                var v45 = _unadjustedAcquisition; v45.Clean = value; _unadjustedAcquisition = v45;
                var v46 = _use85PercentRuleIndicator; v46.Clean = value; _use85PercentRuleIndicator = v46;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}