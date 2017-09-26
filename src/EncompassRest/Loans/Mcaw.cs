using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Mcaw : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _adequacyOfAvailableAssetsType.Dirty
                    || _adequacyOfEffectiveIncomeType.Dirty
                    || _adjustedPurchasePrice.Dirty
                    || _appraisedValue1.Dirty
                    || _appraisedValue2.Dirty
                    || _borrowerPaidClosingCost.Dirty
                    || _calculatedMortgageAmount.Dirty
                    || _cashReserves.Dirty
                    || _constructionType.Dirty
                    || _contractSalesPrice.Dirty
                    || _creditCharacteristicsType.Dirty
                    || _equityToExSpouse.Dirty
                    || _fhaMaxLoanAmount.Dirty
                    || _fhaUnderwriterChumsId.Dirty
                    || _giftFundsSource.Dirty
                    || _id.Dirty
                    || _lesserSalesPrice.Dirty
                    || _ltv1.Dirty
                    || _ltv2.Dirty
                    || _maximumSellerContribution4Percent.Dirty
                    || _mortgageAmount.Dirty
                    || _mortgageAmountPercent.Dirty
                    || _mortgageBasisPurchase.Dirty
                    || _mortgageBasisRefinance.Dirty
                    || _paidType1.Dirty
                    || _paidType2.Dirty
                    || _principalBalance.Dirty
                    || _refinanceType.Dirty
                    || _remarks.Dirty
                    || _repairsAndImprovements.Dirty
                    || _repairsAndImprovementsDescription.Dirty
                    || _repairsImprovementAmount.Dirty
                    || _repairsRequiredByAppraiser.Dirty
                    || _requiredInvestment.Dirty
                    || _requirementAdjustment.Dirty
                    || _roundTo50Indicator.Dirty
                    || _seasonedSubordinateLiens.Dirty
                    || _secondMortgageSource.Dirty
                    || _sixPercentOfLineA1.Dirty
                    || _stabilityOfEffectiveIncomeType.Dirty
                    || _statutoryInvestment.Dirty
                    || _toBePaidAmount.Dirty
                    || _totalCashToClose.Dirty
                    || _totalRequirements.Dirty
                    || _totalSellerContribution.Dirty
                    || _unadjustedAcquisition.Dirty
                    || _use85PercentRuleIndicator.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _adequacyOfAvailableAssetsType.Dirty = value;
                _adequacyOfEffectiveIncomeType.Dirty = value;
                _adjustedPurchasePrice.Dirty = value;
                _appraisedValue1.Dirty = value;
                _appraisedValue2.Dirty = value;
                _borrowerPaidClosingCost.Dirty = value;
                _calculatedMortgageAmount.Dirty = value;
                _cashReserves.Dirty = value;
                _constructionType.Dirty = value;
                _contractSalesPrice.Dirty = value;
                _creditCharacteristicsType.Dirty = value;
                _equityToExSpouse.Dirty = value;
                _fhaMaxLoanAmount.Dirty = value;
                _fhaUnderwriterChumsId.Dirty = value;
                _giftFundsSource.Dirty = value;
                _id.Dirty = value;
                _lesserSalesPrice.Dirty = value;
                _ltv1.Dirty = value;
                _ltv2.Dirty = value;
                _maximumSellerContribution4Percent.Dirty = value;
                _mortgageAmount.Dirty = value;
                _mortgageAmountPercent.Dirty = value;
                _mortgageBasisPurchase.Dirty = value;
                _mortgageBasisRefinance.Dirty = value;
                _paidType1.Dirty = value;
                _paidType2.Dirty = value;
                _principalBalance.Dirty = value;
                _refinanceType.Dirty = value;
                _remarks.Dirty = value;
                _repairsAndImprovements.Dirty = value;
                _repairsAndImprovementsDescription.Dirty = value;
                _repairsImprovementAmount.Dirty = value;
                _repairsRequiredByAppraiser.Dirty = value;
                _requiredInvestment.Dirty = value;
                _requirementAdjustment.Dirty = value;
                _roundTo50Indicator.Dirty = value;
                _seasonedSubordinateLiens.Dirty = value;
                _secondMortgageSource.Dirty = value;
                _sixPercentOfLineA1.Dirty = value;
                _stabilityOfEffectiveIncomeType.Dirty = value;
                _statutoryInvestment.Dirty = value;
                _toBePaidAmount.Dirty = value;
                _totalCashToClose.Dirty = value;
                _totalRequirements.Dirty = value;
                _totalSellerContribution.Dirty = value;
                _unadjustedAcquisition.Dirty = value;
                _use85PercentRuleIndicator.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}