using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var adequacyOfAvailableAssetsType = _adequacyOfAvailableAssetsType; adequacyOfAvailableAssetsType.Clean = value; _adequacyOfAvailableAssetsType = adequacyOfAvailableAssetsType;
                var adequacyOfEffectiveIncomeType = _adequacyOfEffectiveIncomeType; adequacyOfEffectiveIncomeType.Clean = value; _adequacyOfEffectiveIncomeType = adequacyOfEffectiveIncomeType;
                var adjustedPurchasePrice = _adjustedPurchasePrice; adjustedPurchasePrice.Clean = value; _adjustedPurchasePrice = adjustedPurchasePrice;
                var appraisedValue1 = _appraisedValue1; appraisedValue1.Clean = value; _appraisedValue1 = appraisedValue1;
                var appraisedValue2 = _appraisedValue2; appraisedValue2.Clean = value; _appraisedValue2 = appraisedValue2;
                var borrowerPaidClosingCost = _borrowerPaidClosingCost; borrowerPaidClosingCost.Clean = value; _borrowerPaidClosingCost = borrowerPaidClosingCost;
                var calculatedMortgageAmount = _calculatedMortgageAmount; calculatedMortgageAmount.Clean = value; _calculatedMortgageAmount = calculatedMortgageAmount;
                var cashReserves = _cashReserves; cashReserves.Clean = value; _cashReserves = cashReserves;
                var constructionType = _constructionType; constructionType.Clean = value; _constructionType = constructionType;
                var contractSalesPrice = _contractSalesPrice; contractSalesPrice.Clean = value; _contractSalesPrice = contractSalesPrice;
                var creditCharacteristicsType = _creditCharacteristicsType; creditCharacteristicsType.Clean = value; _creditCharacteristicsType = creditCharacteristicsType;
                var equityToExSpouse = _equityToExSpouse; equityToExSpouse.Clean = value; _equityToExSpouse = equityToExSpouse;
                var fhaMaxLoanAmount = _fhaMaxLoanAmount; fhaMaxLoanAmount.Clean = value; _fhaMaxLoanAmount = fhaMaxLoanAmount;
                var fhaUnderwriterChumsId = _fhaUnderwriterChumsId; fhaUnderwriterChumsId.Clean = value; _fhaUnderwriterChumsId = fhaUnderwriterChumsId;
                var giftFundsSource = _giftFundsSource; giftFundsSource.Clean = value; _giftFundsSource = giftFundsSource;
                var id = _id; id.Clean = value; _id = id;
                var lesserSalesPrice = _lesserSalesPrice; lesserSalesPrice.Clean = value; _lesserSalesPrice = lesserSalesPrice;
                var ltv1 = _ltv1; ltv1.Clean = value; _ltv1 = ltv1;
                var ltv2 = _ltv2; ltv2.Clean = value; _ltv2 = ltv2;
                var maximumSellerContribution4Percent = _maximumSellerContribution4Percent; maximumSellerContribution4Percent.Clean = value; _maximumSellerContribution4Percent = maximumSellerContribution4Percent;
                var mortgageAmount = _mortgageAmount; mortgageAmount.Clean = value; _mortgageAmount = mortgageAmount;
                var mortgageAmountPercent = _mortgageAmountPercent; mortgageAmountPercent.Clean = value; _mortgageAmountPercent = mortgageAmountPercent;
                var mortgageBasisPurchase = _mortgageBasisPurchase; mortgageBasisPurchase.Clean = value; _mortgageBasisPurchase = mortgageBasisPurchase;
                var mortgageBasisRefinance = _mortgageBasisRefinance; mortgageBasisRefinance.Clean = value; _mortgageBasisRefinance = mortgageBasisRefinance;
                var paidType1 = _paidType1; paidType1.Clean = value; _paidType1 = paidType1;
                var paidType2 = _paidType2; paidType2.Clean = value; _paidType2 = paidType2;
                var principalBalance = _principalBalance; principalBalance.Clean = value; _principalBalance = principalBalance;
                var refinanceType = _refinanceType; refinanceType.Clean = value; _refinanceType = refinanceType;
                var remarks = _remarks; remarks.Clean = value; _remarks = remarks;
                var repairsAndImprovements = _repairsAndImprovements; repairsAndImprovements.Clean = value; _repairsAndImprovements = repairsAndImprovements;
                var repairsAndImprovementsDescription = _repairsAndImprovementsDescription; repairsAndImprovementsDescription.Clean = value; _repairsAndImprovementsDescription = repairsAndImprovementsDescription;
                var repairsImprovementAmount = _repairsImprovementAmount; repairsImprovementAmount.Clean = value; _repairsImprovementAmount = repairsImprovementAmount;
                var repairsRequiredByAppraiser = _repairsRequiredByAppraiser; repairsRequiredByAppraiser.Clean = value; _repairsRequiredByAppraiser = repairsRequiredByAppraiser;
                var requiredInvestment = _requiredInvestment; requiredInvestment.Clean = value; _requiredInvestment = requiredInvestment;
                var requirementAdjustment = _requirementAdjustment; requirementAdjustment.Clean = value; _requirementAdjustment = requirementAdjustment;
                var roundTo50Indicator = _roundTo50Indicator; roundTo50Indicator.Clean = value; _roundTo50Indicator = roundTo50Indicator;
                var seasonedSubordinateLiens = _seasonedSubordinateLiens; seasonedSubordinateLiens.Clean = value; _seasonedSubordinateLiens = seasonedSubordinateLiens;
                var secondMortgageSource = _secondMortgageSource; secondMortgageSource.Clean = value; _secondMortgageSource = secondMortgageSource;
                var sixPercentOfLineA1 = _sixPercentOfLineA1; sixPercentOfLineA1.Clean = value; _sixPercentOfLineA1 = sixPercentOfLineA1;
                var stabilityOfEffectiveIncomeType = _stabilityOfEffectiveIncomeType; stabilityOfEffectiveIncomeType.Clean = value; _stabilityOfEffectiveIncomeType = stabilityOfEffectiveIncomeType;
                var statutoryInvestment = _statutoryInvestment; statutoryInvestment.Clean = value; _statutoryInvestment = statutoryInvestment;
                var toBePaidAmount = _toBePaidAmount; toBePaidAmount.Clean = value; _toBePaidAmount = toBePaidAmount;
                var totalCashToClose = _totalCashToClose; totalCashToClose.Clean = value; _totalCashToClose = totalCashToClose;
                var totalRequirements = _totalRequirements; totalRequirements.Clean = value; _totalRequirements = totalRequirements;
                var totalSellerContribution = _totalSellerContribution; totalSellerContribution.Clean = value; _totalSellerContribution = totalSellerContribution;
                var unadjustedAcquisition = _unadjustedAcquisition; unadjustedAcquisition.Clean = value; _unadjustedAcquisition = unadjustedAcquisition;
                var use85PercentRuleIndicator = _use85PercentRuleIndicator; use85PercentRuleIndicator.Clean = value; _use85PercentRuleIndicator = use85PercentRuleIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Mcaw()
        {
            Clean = true;
        }
    }
}