using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Mcaw : IDirty
    {
        private DirtyValue<StringEnumValue<AcceptOrReject>> _adequacyOfAvailableAssetsType;
        public StringEnumValue<AcceptOrReject> AdequacyOfAvailableAssetsType { get => _adequacyOfAvailableAssetsType; set => _adequacyOfAvailableAssetsType = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _adequacyOfEffectiveIncomeType;
        public StringEnumValue<AcceptOrReject> AdequacyOfEffectiveIncomeType { get => _adequacyOfEffectiveIncomeType; set => _adequacyOfEffectiveIncomeType = value; }
        private DirtyValue<decimal?> _adjustedPurchasePrice;
        public decimal? AdjustedPurchasePrice { get => _adjustedPurchasePrice; set => _adjustedPurchasePrice = value; }
        private DirtyValue<decimal?> _appraisedValue1;
        public decimal? AppraisedValue1 { get => _appraisedValue1; set => _appraisedValue1 = value; }
        private DirtyValue<decimal?> _appraisedValue2;
        public decimal? AppraisedValue2 { get => _appraisedValue2; set => _appraisedValue2 = value; }
        private DirtyValue<decimal?> _borrowerPaidClosingCost;
        public decimal? BorrowerPaidClosingCost { get => _borrowerPaidClosingCost; set => _borrowerPaidClosingCost = value; }
        private DirtyValue<decimal?> _calculatedMortgageAmount;
        public decimal? CalculatedMortgageAmount { get => _calculatedMortgageAmount; set => _calculatedMortgageAmount = value; }
        private DirtyValue<decimal?> _cashReserves;
        public decimal? CashReserves { get => _cashReserves; set => _cashReserves = value; }
        private DirtyValue<StringEnumValue<ConstructionType>> _constructionType;
        public StringEnumValue<ConstructionType> ConstructionType { get => _constructionType; set => _constructionType = value; }
        private DirtyValue<decimal?> _contractSalesPrice;
        public decimal? ContractSalesPrice { get => _contractSalesPrice; set => _contractSalesPrice = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _creditCharacteristicsType;
        public StringEnumValue<AcceptOrReject> CreditCharacteristicsType { get => _creditCharacteristicsType; set => _creditCharacteristicsType = value; }
        private DirtyValue<decimal?> _equityToExSpouse;
        public decimal? EquityToExSpouse { get => _equityToExSpouse; set => _equityToExSpouse = value; }
        private DirtyValue<decimal?> _fhaMaxLoanAmount;
        public decimal? FhaMaxLoanAmount { get => _fhaMaxLoanAmount; set => _fhaMaxLoanAmount = value; }
        private DirtyValue<string> _fhaUnderwriterChumsId;
        public string FhaUnderwriterChumsId { get => _fhaUnderwriterChumsId; set => _fhaUnderwriterChumsId = value; }
        private DirtyValue<StringEnumValue<GiftFundsSource>> _giftFundsSource;
        public StringEnumValue<GiftFundsSource> GiftFundsSource { get => _giftFundsSource; set => _giftFundsSource = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lesserSalesPrice;
        public decimal? LesserSalesPrice { get => _lesserSalesPrice; set => _lesserSalesPrice = value; }
        private DirtyValue<decimal?> _ltv1;
        public decimal? Ltv1 { get => _ltv1; set => _ltv1 = value; }
        private DirtyValue<decimal?> _ltv2;
        public decimal? Ltv2 { get => _ltv2; set => _ltv2 = value; }
        private DirtyValue<decimal?> _maximumSellerContribution4Percent;
        public decimal? MaximumSellerContribution4Percent { get => _maximumSellerContribution4Percent; set => _maximumSellerContribution4Percent = value; }
        private DirtyValue<decimal?> _mortgageAmount;
        public decimal? MortgageAmount { get => _mortgageAmount; set => _mortgageAmount = value; }
        private DirtyValue<decimal?> _mortgageAmountPercent;
        public decimal? MortgageAmountPercent { get => _mortgageAmountPercent; set => _mortgageAmountPercent = value; }
        private DirtyValue<decimal?> _mortgageBasisPurchase;
        public decimal? MortgageBasisPurchase { get => _mortgageBasisPurchase; set => _mortgageBasisPurchase = value; }
        private DirtyValue<decimal?> _mortgageBasisRefinance;
        public decimal? MortgageBasisRefinance { get => _mortgageBasisRefinance; set => _mortgageBasisRefinance = value; }
        private DirtyValue<StringEnumValue<PaidType>> _paidType1;
        public StringEnumValue<PaidType> PaidType1 { get => _paidType1; set => _paidType1 = value; }
        private DirtyValue<StringEnumValue<PaidType>> _paidType2;
        public StringEnumValue<PaidType> PaidType2 { get => _paidType2; set => _paidType2 = value; }
        private DirtyValue<decimal?> _principalBalance;
        public decimal? PrincipalBalance { get => _principalBalance; set => _principalBalance = value; }
        private DirtyValue<StringEnumValue<RefinanceType>> _refinanceType;
        public StringEnumValue<RefinanceType> RefinanceType { get => _refinanceType; set => _refinanceType = value; }
        private DirtyValue<string> _remarks;
        public string Remarks { get => _remarks; set => _remarks = value; }
        private DirtyValue<decimal?> _repairsAndImprovements;
        public decimal? RepairsAndImprovements { get => _repairsAndImprovements; set => _repairsAndImprovements = value; }
        private DirtyValue<string> _repairsAndImprovementsDescription;
        public string RepairsAndImprovementsDescription { get => _repairsAndImprovementsDescription; set => _repairsAndImprovementsDescription = value; }
        private DirtyValue<decimal?> _repairsImprovementAmount;
        public decimal? RepairsImprovementAmount { get => _repairsImprovementAmount; set => _repairsImprovementAmount = value; }
        private DirtyValue<decimal?> _repairsRequiredByAppraiser;
        public decimal? RepairsRequiredByAppraiser { get => _repairsRequiredByAppraiser; set => _repairsRequiredByAppraiser = value; }
        private DirtyValue<decimal?> _requiredInvestment;
        public decimal? RequiredInvestment { get => _requiredInvestment; set => _requiredInvestment = value; }
        private DirtyValue<decimal?> _requirementAdjustment;
        public decimal? RequirementAdjustment { get => _requirementAdjustment; set => _requirementAdjustment = value; }
        private DirtyValue<bool?> _roundTo50Indicator;
        public bool? RoundTo50Indicator { get => _roundTo50Indicator; set => _roundTo50Indicator = value; }
        private DirtyValue<decimal?> _seasonedSubordinateLiens;
        public decimal? SeasonedSubordinateLiens { get => _seasonedSubordinateLiens; set => _seasonedSubordinateLiens = value; }
        private DirtyValue<string> _secondMortgageSource;
        public string SecondMortgageSource { get => _secondMortgageSource; set => _secondMortgageSource = value; }
        private DirtyValue<decimal?> _sixPercentOfLineA1;
        public decimal? SixPercentOfLineA1 { get => _sixPercentOfLineA1; set => _sixPercentOfLineA1 = value; }
        private DirtyValue<StringEnumValue<AcceptOrReject>> _stabilityOfEffectiveIncomeType;
        public StringEnumValue<AcceptOrReject> StabilityOfEffectiveIncomeType { get => _stabilityOfEffectiveIncomeType; set => _stabilityOfEffectiveIncomeType = value; }
        private DirtyValue<decimal?> _statutoryInvestment;
        public decimal? StatutoryInvestment { get => _statutoryInvestment; set => _statutoryInvestment = value; }
        private DirtyValue<decimal?> _toBePaidAmount;
        public decimal? ToBePaidAmount { get => _toBePaidAmount; set => _toBePaidAmount = value; }
        private DirtyValue<decimal?> _totalCashToClose;
        public decimal? TotalCashToClose { get => _totalCashToClose; set => _totalCashToClose = value; }
        private DirtyValue<decimal?> _totalRequirements;
        public decimal? TotalRequirements { get => _totalRequirements; set => _totalRequirements = value; }
        private DirtyValue<decimal?> _totalSellerContribution;
        public decimal? TotalSellerContribution { get => _totalSellerContribution; set => _totalSellerContribution = value; }
        private DirtyValue<decimal?> _unadjustedAcquisition;
        public decimal? UnadjustedAcquisition { get => _unadjustedAcquisition; set => _unadjustedAcquisition = value; }
        private DirtyValue<bool?> _use85PercentRuleIndicator;
        public bool? Use85PercentRuleIndicator { get => _use85PercentRuleIndicator; set => _use85PercentRuleIndicator = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
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
                    || _use85PercentRuleIndicator.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}