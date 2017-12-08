#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZ : ExtensibleObject
    {
        private DirtyValue<string> _acknowledgedDay;
        public string AcknowledgedDay { get => _acknowledgedDay; set => _acknowledgedDay = value; }
        private DirtyValue<string> _acknowledgedMonth;
        public string AcknowledgedMonth { get => _acknowledgedMonth; set => _acknowledgedMonth = value; }
        private DirtyValue<string> _acknowledgedYear;
        public string AcknowledgedYear { get => _acknowledgedYear; set => _acknowledgedYear = value; }
        private DirtyValue<bool?> _acquisition;
        public bool? Acquisition { get => _acquisition; set => _acquisition = value; }
        private DirtyValue<string> _additionalArmInformation;
        public string AdditionalArmInformation { get => _additionalArmInformation; set => _additionalArmInformation = value; }
        private DirtyValue<bool?> _allDateAndNumericalDisclosuresIndicator;
        public bool? AllDateAndNumericalDisclosuresIndicator { get => _allDateAndNumericalDisclosuresIndicator; set => _allDateAndNumericalDisclosuresIndicator = value; }
        private DirtyValue<decimal?> _amountFinanced;
        public decimal? AmountFinanced { get => _amountFinanced; set => _amountFinanced = value; }
        private DirtyValue<decimal?> _aprPercent;
        public decimal? AprPercent { get => _aprPercent; set => _aprPercent = value; }
        private DirtyValue<string> _armDisclosureDescription;
        public string ArmDisclosureDescription { get => _armDisclosureDescription; set => _armDisclosureDescription = value; }
        private DirtyValue<StringEnumValue<AssumptionOnYourProperty>> _assumptionOnYourProperty;
        public StringEnumValue<AssumptionOnYourProperty> AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => _assumptionOnYourProperty = value; }
        private DirtyValue<DateTime?> _borrowerIntendToContinueDate;
        public DateTime? BorrowerIntendToContinueDate { get => _borrowerIntendToContinueDate; set => _borrowerIntendToContinueDate = value; }
        private DirtyValue<bool?> _borrowerIntendToContinueIndicator;
        public bool? BorrowerIntendToContinueIndicator { get => _borrowerIntendToContinueIndicator; set => _borrowerIntendToContinueIndicator = value; }
        private DirtyValue<string> _borrowerMiTerminationDate;
        public string BorrowerMiTerminationDate { get => _borrowerMiTerminationDate; set => _borrowerMiTerminationDate = value; }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        public string CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => _calculateBasedOnRemainingBalance = value; }
        private DirtyValue<bool?> _chargesAddedToPaymentsIndicator;
        public bool? ChargesAddedToPaymentsIndicator { get => _chargesAddedToPaymentsIndicator; set => _chargesAddedToPaymentsIndicator = value; }
        private DirtyValue<bool?> _chargesAtLoanClosingIndicator;
        public bool? ChargesAtLoanClosingIndicator { get => _chargesAtLoanClosingIndicator; set => _chargesAtLoanClosingIndicator = value; }
        private DirtyValue<string> _circumstanceChangeReason;
        public string CircumstanceChangeReason { get => _circumstanceChangeReason; set => _circumstanceChangeReason = value; }
        private DirtyValue<DateTime?> _circumstanceChangeReceivedDate;
        public DateTime? CircumstanceChangeReceivedDate { get => _circumstanceChangeReceivedDate; set => _circumstanceChangeReceivedDate = value; }
        private DirtyValue<DateTime?> _closingDisclosureReceivedDate;
        public DateTime? ClosingDisclosureReceivedDate { get => _closingDisclosureReceivedDate; set => _closingDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _closingDisclosureSentDate;
        public DateTime? ClosingDisclosureSentDate { get => _closingDisclosureSentDate; set => _closingDisclosureSentDate = value; }
        private DirtyValue<StringEnumValue<ConstructionFirstIntChangeAdjType>> _constructionFirstIntChangeAdjType;
        public StringEnumValue<ConstructionFirstIntChangeAdjType> ConstructionFirstIntChangeAdjType { get => _constructionFirstIntChangeAdjType; set => _constructionFirstIntChangeAdjType = value; }
        private DirtyValue<string> _constructionLoanDescription;
        public string ConstructionLoanDescription { get => _constructionLoanDescription; set => _constructionLoanDescription = value; }
        private DirtyValue<StringEnumValue<ConstructionLoanMethod>> _constructionLoanMethod;
        public StringEnumValue<ConstructionLoanMethod> ConstructionLoanMethod { get => _constructionLoanMethod; set => _constructionLoanMethod = value; }
        private DirtyValue<int?> _constructionPeriodMonths;
        public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => _constructionPeriodMonths = value; }
        private DirtyValue<decimal?> _constructionRatePercent;
        public decimal? ConstructionRatePercent { get => _constructionRatePercent; set => _constructionRatePercent = value; }
        private DirtyValue<bool?> _constructionRefinanceIndicator;
        public bool? ConstructionRefinanceIndicator { get => _constructionRefinanceIndicator; set => _constructionRefinanceIndicator = value; }
        private DirtyValue<decimal?> _creditDisability;
        public decimal? CreditDisability { get => _creditDisability; set => _creditDisability = value; }
        private DirtyValue<bool?> _creditDisabilityIndicator;
        public bool? CreditDisabilityIndicator { get => _creditDisabilityIndicator; set => _creditDisabilityIndicator = value; }
        private DirtyValue<decimal?> _creditLife;
        public decimal? CreditLife { get => _creditLife; set => _creditLife = value; }
        private DirtyValue<decimal?> _creditLifeAndCreditDisability;
        public decimal? CreditLifeAndCreditDisability { get => _creditLifeAndCreditDisability; set => _creditLifeAndCreditDisability = value; }
        private DirtyValue<bool?> _creditLifeInsuranceIndicator;
        public bool? CreditLifeInsuranceIndicator { get => _creditLifeInsuranceIndicator; set => _creditLifeInsuranceIndicator = value; }
        private DirtyValue<bool?> _customizePaymentScheduleIndicator;
        public bool? CustomizePaymentScheduleIndicator { get => _customizePaymentScheduleIndicator; set => _customizePaymentScheduleIndicator = value; }
        private DirtyValue<bool?> _demandFeatureIndicator;
        public bool? DemandFeatureIndicator { get => _demandFeatureIndicator; set => _demandFeatureIndicator = value; }
        private DirtyValue<decimal?> _disclosedAprPercent;
        public decimal? DisclosedAprPercent { get => _disclosedAprPercent; set => _disclosedAprPercent = value; }
        private DirtyValue<bool?> _disclosedByBrokerIndicator;
        public bool? DisclosedByBrokerIndicator { get => _disclosedByBrokerIndicator; set => _disclosedByBrokerIndicator = value; }
        private DirtyValue<string> _disclosedComments;
        public string DisclosedComments { get => _disclosedComments; set => _disclosedComments = value; }
        private DirtyValue<decimal?> _disclosedDailyInterestCharge;
        public decimal? DisclosedDailyInterestCharge { get => _disclosedDailyInterestCharge; set => _disclosedDailyInterestCharge = value; }
        private DirtyValue<decimal?> _disclosedFinanceCharge;
        public decimal? DisclosedFinanceCharge { get => _disclosedFinanceCharge; set => _disclosedFinanceCharge = value; }
        private DirtyValue<bool?> _disclosedPrepayment;
        public bool? DisclosedPrepayment { get => _disclosedPrepayment; set => _disclosedPrepayment = value; }
        private DirtyValue<string> _disclosedProduct;
        public string DisclosedProduct { get => _disclosedProduct; set => _disclosedProduct = value; }
        private DirtyValue<StringEnumValue<DisclosureMethod>> _disclosureMethod;
        public StringEnumValue<DisclosureMethod> DisclosureMethod { get => _disclosureMethod; set => _disclosureMethod = value; }
        private DirtyValue<StringEnumValue<DisclosureType>> _disclosureType;
        public StringEnumValue<DisclosureType> DisclosureType { get => _disclosureType; set => _disclosureType = value; }
        private DirtyValue<int?> _discountPeriod;
        public int? DiscountPeriod { get => _discountPeriod; set => _discountPeriod = value; }
        private DirtyValue<decimal?> _discountRatePercent;
        public decimal? DiscountRatePercent { get => _discountRatePercent; set => _discountRatePercent = value; }
        private DirtyValue<StringEnumValue<DiscountType>> _discountType;
        public StringEnumValue<DiscountType> DiscountType { get => _discountType; set => _discountType = value; }
        private DirtyValue<DateTime?> _dueDate;
        public DateTime? DueDate { get => _dueDate; set => _dueDate = value; }
        private DirtyValue<DateTime?> _earliestClosingDate;
        public DateTime? EarliestClosingDate { get => _earliestClosingDate; set => _earliestClosingDate = value; }
        private DirtyValue<DateTime?> _earliestFeeCollectionDate;
        public DateTime? EarliestFeeCollectionDate { get => _earliestFeeCollectionDate; set => _earliestFeeCollectionDate = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted1;
        public DateTime? eSignConsentBorrowerDateAccepted1 { get => _eSignConsentBorrowerDateAccepted1; set => _eSignConsentBorrowerDateAccepted1 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted2;
        public DateTime? eSignConsentBorrowerDateAccepted2 { get => _eSignConsentBorrowerDateAccepted2; set => _eSignConsentBorrowerDateAccepted2 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted3;
        public DateTime? eSignConsentBorrowerDateAccepted3 { get => _eSignConsentBorrowerDateAccepted3; set => _eSignConsentBorrowerDateAccepted3 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted4;
        public DateTime? eSignConsentBorrowerDateAccepted4 { get => _eSignConsentBorrowerDateAccepted4; set => _eSignConsentBorrowerDateAccepted4 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted5;
        public DateTime? eSignConsentBorrowerDateAccepted5 { get => _eSignConsentBorrowerDateAccepted5; set => _eSignConsentBorrowerDateAccepted5 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted6;
        public DateTime? eSignConsentBorrowerDateAccepted6 { get => _eSignConsentBorrowerDateAccepted6; set => _eSignConsentBorrowerDateAccepted6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress1;
        public string eSignConsentBorrowerIPAddress1 { get => _eSignConsentBorrowerIPAddress1; set => _eSignConsentBorrowerIPAddress1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress2;
        public string eSignConsentBorrowerIPAddress2 { get => _eSignConsentBorrowerIPAddress2; set => _eSignConsentBorrowerIPAddress2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress3;
        public string eSignConsentBorrowerIPAddress3 { get => _eSignConsentBorrowerIPAddress3; set => _eSignConsentBorrowerIPAddress3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress4;
        public string eSignConsentBorrowerIPAddress4 { get => _eSignConsentBorrowerIPAddress4; set => _eSignConsentBorrowerIPAddress4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress5;
        public string eSignConsentBorrowerIPAddress5 { get => _eSignConsentBorrowerIPAddress5; set => _eSignConsentBorrowerIPAddress5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress6;
        public string eSignConsentBorrowerIPAddress6 { get => _eSignConsentBorrowerIPAddress6; set => _eSignConsentBorrowerIPAddress6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource1;
        public string eSignConsentBorrowerSource1 { get => _eSignConsentBorrowerSource1; set => _eSignConsentBorrowerSource1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource2;
        public string eSignConsentBorrowerSource2 { get => _eSignConsentBorrowerSource2; set => _eSignConsentBorrowerSource2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource3;
        public string eSignConsentBorrowerSource3 { get => _eSignConsentBorrowerSource3; set => _eSignConsentBorrowerSource3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource4;
        public string eSignConsentBorrowerSource4 { get => _eSignConsentBorrowerSource4; set => _eSignConsentBorrowerSource4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource5;
        public string eSignConsentBorrowerSource5 { get => _eSignConsentBorrowerSource5; set => _eSignConsentBorrowerSource5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource6;
        public string eSignConsentBorrowerSource6 { get => _eSignConsentBorrowerSource6; set => _eSignConsentBorrowerSource6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus1;
        public string eSignConsentBorrowerStatus1 { get => _eSignConsentBorrowerStatus1; set => _eSignConsentBorrowerStatus1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus2;
        public string eSignConsentBorrowerStatus2 { get => _eSignConsentBorrowerStatus2; set => _eSignConsentBorrowerStatus2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus3;
        public string eSignConsentBorrowerStatus3 { get => _eSignConsentBorrowerStatus3; set => _eSignConsentBorrowerStatus3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus4;
        public string eSignConsentBorrowerStatus4 { get => _eSignConsentBorrowerStatus4; set => _eSignConsentBorrowerStatus4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus5;
        public string eSignConsentBorrowerStatus5 { get => _eSignConsentBorrowerStatus5; set => _eSignConsentBorrowerStatus5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus6;
        public string eSignConsentBorrowerStatus6 { get => _eSignConsentBorrowerStatus6; set => _eSignConsentBorrowerStatus6 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted1;
        public DateTime? eSignConsentCoBorrowerDateAccepted1 { get => _eSignConsentCoBorrowerDateAccepted1; set => _eSignConsentCoBorrowerDateAccepted1 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted2;
        public DateTime? eSignConsentCoBorrowerDateAccepted2 { get => _eSignConsentCoBorrowerDateAccepted2; set => _eSignConsentCoBorrowerDateAccepted2 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted3;
        public DateTime? eSignConsentCoBorrowerDateAccepted3 { get => _eSignConsentCoBorrowerDateAccepted3; set => _eSignConsentCoBorrowerDateAccepted3 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted4;
        public DateTime? eSignConsentCoBorrowerDateAccepted4 { get => _eSignConsentCoBorrowerDateAccepted4; set => _eSignConsentCoBorrowerDateAccepted4 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted5;
        public DateTime? eSignConsentCoBorrowerDateAccepted5 { get => _eSignConsentCoBorrowerDateAccepted5; set => _eSignConsentCoBorrowerDateAccepted5 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted6;
        public DateTime? eSignConsentCoBorrowerDateAccepted6 { get => _eSignConsentCoBorrowerDateAccepted6; set => _eSignConsentCoBorrowerDateAccepted6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress1;
        public string eSignConsentCoBorrowerIPAddress1 { get => _eSignConsentCoBorrowerIPAddress1; set => _eSignConsentCoBorrowerIPAddress1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress2;
        public string eSignConsentCoBorrowerIPAddress2 { get => _eSignConsentCoBorrowerIPAddress2; set => _eSignConsentCoBorrowerIPAddress2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress3;
        public string eSignConsentCoBorrowerIPAddress3 { get => _eSignConsentCoBorrowerIPAddress3; set => _eSignConsentCoBorrowerIPAddress3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress4;
        public string eSignConsentCoBorrowerIPAddress4 { get => _eSignConsentCoBorrowerIPAddress4; set => _eSignConsentCoBorrowerIPAddress4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress5;
        public string eSignConsentCoBorrowerIPAddress5 { get => _eSignConsentCoBorrowerIPAddress5; set => _eSignConsentCoBorrowerIPAddress5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress6;
        public string eSignConsentCoBorrowerIPAddress6 { get => _eSignConsentCoBorrowerIPAddress6; set => _eSignConsentCoBorrowerIPAddress6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource1;
        public string eSignConsentCoBorrowerSource1 { get => _eSignConsentCoBorrowerSource1; set => _eSignConsentCoBorrowerSource1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource2;
        public string eSignConsentCoBorrowerSource2 { get => _eSignConsentCoBorrowerSource2; set => _eSignConsentCoBorrowerSource2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource3;
        public string eSignConsentCoBorrowerSource3 { get => _eSignConsentCoBorrowerSource3; set => _eSignConsentCoBorrowerSource3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource4;
        public string eSignConsentCoBorrowerSource4 { get => _eSignConsentCoBorrowerSource4; set => _eSignConsentCoBorrowerSource4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource5;
        public string eSignConsentCoBorrowerSource5 { get => _eSignConsentCoBorrowerSource5; set => _eSignConsentCoBorrowerSource5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource6;
        public string eSignConsentCoBorrowerSource6 { get => _eSignConsentCoBorrowerSource6; set => _eSignConsentCoBorrowerSource6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus1;
        public string eSignConsentCoBorrowerStatus1 { get => _eSignConsentCoBorrowerStatus1; set => _eSignConsentCoBorrowerStatus1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus2;
        public string eSignConsentCoBorrowerStatus2 { get => _eSignConsentCoBorrowerStatus2; set => _eSignConsentCoBorrowerStatus2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus3;
        public string eSignConsentCoBorrowerStatus3 { get => _eSignConsentCoBorrowerStatus3; set => _eSignConsentCoBorrowerStatus3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus4;
        public string eSignConsentCoBorrowerStatus4 { get => _eSignConsentCoBorrowerStatus4; set => _eSignConsentCoBorrowerStatus4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus5;
        public string eSignConsentCoBorrowerStatus5 { get => _eSignConsentCoBorrowerStatus5; set => _eSignConsentCoBorrowerStatus5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus6;
        public string eSignConsentCoBorrowerStatus6 { get => _eSignConsentCoBorrowerStatus6; set => _eSignConsentCoBorrowerStatus6 = value; }
        private DirtyValue<DateTime?> _eSignConsentDate;
        public DateTime? eSignConsentDate { get => _eSignConsentDate; set => _eSignConsentDate = value; }
        private DirtyValue<decimal?> _extraPaymentForEarlyPayOff;
        public decimal? ExtraPaymentForEarlyPayOff { get => _extraPaymentForEarlyPayOff; set => _extraPaymentForEarlyPayOff = value; }
        private DirtyValue<DateTime?> _feeCollectedDate;
        public DateTime? FeeCollectedDate { get => _feeCollectedDate; set => _feeCollectedDate = value; }
        private DirtyValue<decimal?> _filingFees;
        public decimal? FilingFees { get => _filingFees; set => _filingFees = value; }
        private DirtyValue<DateTime?> _finalPaymentDate;
        public DateTime? FinalPaymentDate { get => _finalPaymentDate; set => _finalPaymentDate = value; }
        private DirtyValue<decimal?> _financeCharge;
        public decimal? FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyValue<decimal?> _financedAllGuaranteeFeeAmount;
        public decimal? FinancedAllGuaranteeFeeAmount { get => _financedAllGuaranteeFeeAmount; set => _financedAllGuaranteeFeeAmount = value; }
        private DirtyValue<decimal?> _financedAllGuaranteeFeePercent;
        public decimal? FinancedAllGuaranteeFeePercent { get => _financedAllGuaranteeFeePercent; set => _financedAllGuaranteeFeePercent = value; }
        private DirtyValue<decimal?> _financedAllTotalLoanAmount;
        public decimal? FinancedAllTotalLoanAmount { get => _financedAllTotalLoanAmount; set => _financedAllTotalLoanAmount = value; }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeeAmount;
        public decimal? FinancedPortionGuaranteeFeeAmount { get => _financedPortionGuaranteeFeeAmount; set => _financedPortionGuaranteeFeeAmount = value; }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeePercent;
        public decimal? FinancedPortionGuaranteeFeePercent { get => _financedPortionGuaranteeFeePercent; set => _financedPortionGuaranteeFeePercent = value; }
        private DirtyValue<decimal?> _financedPortionTotalLoanAmount;
        public decimal? FinancedPortionTotalLoanAmount { get => _financedPortionTotalLoanAmount; set => _financedPortionTotalLoanAmount = value; }
        private DirtyValue<StringEnumValue<FinancingType>> _financingType;
        public StringEnumValue<FinancingType> FinancingType { get => _financingType; set => _financingType = value; }
        private DirtyValue<DateTime?> _firstAmortizationPaymentDate;
        public DateTime? FirstAmortizationPaymentDate { get => _firstAmortizationPaymentDate; set => _firstAmortizationPaymentDate = value; }
        private DirtyValue<bool?> _floodInsuranceIndicator;
        public bool? FloodInsuranceIndicator { get => _floodInsuranceIndicator; set => _floodInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _gfeApplicationDate;
        public DateTime? GfeApplicationDate { get => _gfeApplicationDate; set => _gfeApplicationDate = value; }
        private DirtyValue<bool?> _gfeChangedCircumstanceIndicator;
        public bool? GfeChangedCircumstanceIndicator { get => _gfeChangedCircumstanceIndicator; set => _gfeChangedCircumstanceIndicator = value; }
        private DirtyValue<string> _gfeChangedCircumstanceItem;
        public string GfeChangedCircumstanceItem { get => _gfeChangedCircumstanceItem; set => _gfeChangedCircumstanceItem = value; }
        private DirtyValue<string> _gFEChangedCirsumstanceItemCode;
        public string GFEChangedCirsumstanceItemCode { get => _gFEChangedCirsumstanceItemCode; set => _gFEChangedCirsumstanceItemCode = value; }
        private DirtyValue<DateTime?> _gfeDate;
        public DateTime? GfeDate { get => _gfeDate; set => _gfeDate = value; }
        private DirtyValue<DateTime?> _gfeExpirationDate;
        public DateTime? GfeExpirationDate { get => _gfeExpirationDate; set => _gfeExpirationDate = value; }
        private DirtyValue<string> _gfeExpirationPeriod;
        public string GfeExpirationPeriod { get => _gfeExpirationPeriod; set => _gfeExpirationPeriod = value; }
        private DirtyValue<bool?> _gfeRateLockRedisclosureRequiredIndicator;
        public bool? GfeRateLockRedisclosureRequiredIndicator { get => _gfeRateLockRedisclosureRequiredIndicator; set => _gfeRateLockRedisclosureRequiredIndicator = value; }
        private DirtyValue<DateTime?> _gfeRedisclosureProvidedDate;
        public DateTime? GfeRedisclosureProvidedDate { get => _gfeRedisclosureProvidedDate; set => _gfeRedisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _gfeRedisclosureReceivedDate;
        public DateTime? GfeRedisclosureReceivedDate { get => _gfeRedisclosureReceivedDate; set => _gfeRedisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _highCostDisclosure;
        public DateTime? HighCostDisclosure { get => _highCostDisclosure; set => _highCostDisclosure = value; }
        private DirtyValue<DateTime?> _homeCounselingProvidedDate;
        public DateTime? HomeCounselingProvidedDate { get => _homeCounselingProvidedDate; set => _homeCounselingProvidedDate = value; }
        private DirtyValue<bool?> _hud1ToleranceViolatedIndicator;
        public bool? Hud1ToleranceViolatedIndicator { get => _hud1ToleranceViolatedIndicator; set => _hud1ToleranceViolatedIndicator = value; }
        private DirtyValue<string> _hudToleranceResolutionComments;
        public string HudToleranceResolutionComments { get => _hudToleranceResolutionComments; set => _hudToleranceResolutionComments = value; }
        private DirtyValue<DateTime?> _hudToleranceResolutionDate;
        public DateTime? HudToleranceResolutionDate { get => _hudToleranceResolutionDate; set => _hudToleranceResolutionDate = value; }
        private DirtyValue<string> _hudToleranceResolvedBy;
        public string HudToleranceResolvedBy { get => _hudToleranceResolvedBy; set => _hudToleranceResolvedBy = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ifYouPurchaseIndicator;
        public bool? IfYouPurchaseIndicator { get => _ifYouPurchaseIndicator; set => _ifYouPurchaseIndicator = value; }
        private DirtyValue<StringEnumValue<IfYouPurchaseType>> _ifYouPurchaseType;
        public StringEnumValue<IfYouPurchaseType> IfYouPurchaseType { get => _ifYouPurchaseType; set => _ifYouPurchaseType = value; }
        private DirtyValue<bool?> _includeMiIndicator;
        public bool? IncludeMiIndicator { get => _includeMiIndicator; set => _includeMiIndicator = value; }
        private DirtyValue<bool?> _includePmiIndicator;
        public bool? IncludePmiIndicator { get => _includePmiIndicator; set => _includePmiIndicator = value; }
        private DirtyValue<bool?> _includeTaxesInsuranceIndicator;
        public bool? IncludeTaxesInsuranceIndicator { get => _includeTaxesInsuranceIndicator; set => _includeTaxesInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _initialAVMProvidedDate;
        public DateTime? InitialAVMProvidedDate { get => _initialAVMProvidedDate; set => _initialAVMProvidedDate = value; }
        private DirtyValue<DateTime?> _initialDisclosureDueDate;
        public DateTime? InitialDisclosureDueDate { get => _initialDisclosureDueDate; set => _initialDisclosureDueDate = value; }
        private DirtyValue<DateTime?> _initialDisclosureProvidedDate;
        public DateTime? InitialDisclosureProvidedDate { get => _initialDisclosureProvidedDate; set => _initialDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeAffiliatedBusinessProvidedDate;
        public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get => _initialGfeAffiliatedBusinessProvidedDate; set => _initialGfeAffiliatedBusinessProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGFEAppraisalProvidedDate;
        public DateTime? InitialGFEAppraisalProvidedDate { get => _initialGFEAppraisalProvidedDate; set => _initialGFEAppraisalProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeCharmBookletProvidedDate;
        public DateTime? InitialGfeCharmBookletProvidedDate { get => _initialGfeCharmBookletProvidedDate; set => _initialGfeCharmBookletProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeDisclosureProvidedDate;
        public DateTime? InitialGfeDisclosureProvidedDate { get => _initialGfeDisclosureProvidedDate; set => _initialGfeDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeDisclosureReceivedDate;
        public DateTime? InitialGfeDisclosureReceivedDate { get => _initialGfeDisclosureReceivedDate; set => _initialGfeDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _initialGfeHelocBrochureProvidedDate;
        public DateTime? InitialGfeHelocBrochureProvidedDate { get => _initialGfeHelocBrochureProvidedDate; set => _initialGfeHelocBrochureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeHudSpecialBookletProvidedDate;
        public DateTime? InitialGfeHudSpecialBookletProvidedDate { get => _initialGfeHudSpecialBookletProvidedDate; set => _initialGfeHudSpecialBookletProvidedDate = value; }
        private DirtyValue<DateTime?> _initialSubsequentAppraisalProvidedDate;
        public DateTime? InitialSubsequentAppraisalProvidedDate { get => _initialSubsequentAppraisalProvidedDate; set => _initialSubsequentAppraisalProvidedDate = value; }
        private DirtyValue<DateTime?> _initialTilDisclosureProvidedDate;
        public DateTime? InitialTilDisclosureProvidedDate { get => _initialTilDisclosureProvidedDate; set => _initialTilDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialTilDisclosureReceivedDate;
        public DateTime? InitialTilDisclosureReceivedDate { get => _initialTilDisclosureReceivedDate; set => _initialTilDisclosureReceivedDate = value; }
        private DirtyValue<string> _insuranceRequiredDescription;
        public string InsuranceRequiredDescription { get => _insuranceRequiredDescription; set => _insuranceRequiredDescription = value; }
        private DirtyValue<string> _interestInNameOf;
        public string InterestInNameOf { get => _interestInNameOf; set => _interestInNameOf = value; }
        private DirtyValue<bool?> _interestOnly;
        public bool? InterestOnly { get => _interestOnly; set => _interestOnly = value; }
        private DirtyValue<bool?> _interestOnlyIndicator;
        public bool? InterestOnlyIndicator { get => _interestOnlyIndicator; set => _interestOnlyIndicator = value; }
        private DirtyValue<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => _interestOnlyMonths = value; }
        private DirtyValue<StringEnumValue<InterestRateType>> _interestRateType;
        public StringEnumValue<InterestRateType> InterestRateType { get => _interestRateType; set => _interestRateType = value; }
        private DirtyValue<decimal?> _interestReserveAmount;
        public decimal? InterestReserveAmount { get => _interestReserveAmount; set => _interestReserveAmount = value; }
        private DirtyValue<string> _lastDisclosedBy;
        public string LastDisclosedBy { get => _lastDisclosedBy; set => _lastDisclosedBy = value; }
        private DirtyValue<DateTime?> _lastDisclosedDate;
        public DateTime? LastDisclosedDate { get => _lastDisclosedDate; set => _lastDisclosedDate = value; }
        private DirtyValue<DateTime?> _lastDisclosedGfeReceivedDate;
        public DateTime? LastDisclosedGfeReceivedDate { get => _lastDisclosedGfeReceivedDate; set => _lastDisclosedGfeReceivedDate = value; }
        private DirtyValue<decimal?> _lateChargeBasis;
        public decimal? LateChargeBasis { get => _lateChargeBasis; set => _lateChargeBasis = value; }
        private DirtyValue<string> _lateChargeComments;
        public string LateChargeComments { get => _lateChargeComments; set => _lateChargeComments = value; }
        private DirtyValue<int?> _lateChargeDays;
        public int? LateChargeDays { get => _lateChargeDays; set => _lateChargeDays = value; }
        private DirtyValue<decimal?> _lateChargePercent;
        public decimal? LateChargePercent { get => _lateChargePercent; set => _lateChargePercent = value; }
        private DirtyValue<StringEnumValue<LateChargeType>> _lateChargeType;
        public StringEnumValue<LateChargeType> LateChargeType { get => _lateChargeType; set => _lateChargeType = value; }
        private DirtyValue<decimal?> _lateFee;
        public decimal? LateFee { get => _lateFee; set => _lateFee = value; }
        private DirtyValue<string> _lEIntentToProceedComment;
        public string LEIntentToProceedComment { get => _lEIntentToProceedComment; set => _lEIntentToProceedComment = value; }
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => _lenderPaidMortgageInsuranceIndicator = value; }
        private DirtyValue<decimal?> _lendersInspectionFee;
        public decimal? LendersInspectionFee { get => _lendersInspectionFee; set => _lendersInspectionFee = value; }
        private DirtyValue<string> _lEReceivedBy;
        public string LEReceivedBy { get => _lEReceivedBy; set => _lEReceivedBy = value; }
        private DirtyValue<StringEnumValue<LEReceivedMethod>> _lEReceivedMethod;
        public StringEnumValue<LEReceivedMethod> LEReceivedMethod { get => _lEReceivedMethod; set => _lEReceivedMethod = value; }
        private DirtyValue<string> _lEReceivedMethodOther;
        public string LEReceivedMethodOther { get => _lEReceivedMethodOther; set => _lEReceivedMethodOther = value; }
        private DirtyValue<DateTime?> _lESentOnDate;
        public DateTime? LESentOnDate { get => _lESentOnDate; set => _lESentOnDate = value; }
        private DirtyValue<decimal?> _marginPlusIndexPercent;
        public decimal? MarginPlusIndexPercent { get => _marginPlusIndexPercent; set => _marginPlusIndexPercent = value; }
        private DirtyValue<decimal?> _maximumLateCharge;
        public decimal? MaximumLateCharge { get => _maximumLateCharge; set => _maximumLateCharge = value; }
        private DirtyValue<decimal?> _maximumPayment;
        public decimal? MaximumPayment { get => _maximumPayment; set => _maximumPayment = value; }
        private DirtyValue<bool?> _meansAnEstimateIndicator;
        public bool? MeansAnEstimateIndicator { get => _meansAnEstimateIndicator; set => _meansAnEstimateIndicator = value; }
        private DirtyValue<decimal?> _miAdjustmentFactorLevel2;
        public decimal? MiAdjustmentFactorLevel2 { get => _miAdjustmentFactorLevel2; set => _miAdjustmentFactorLevel2 = value; }
        private DirtyValue<bool?> _miDecliningRenewalsIndicator;
        public bool? MiDecliningRenewalsIndicator { get => _miDecliningRenewalsIndicator; set => _miDecliningRenewalsIndicator = value; }
        private DirtyValue<string> _midpointCancellation;
        public string MidpointCancellation { get => _midpointCancellation; set => _midpointCancellation = value; }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel1;
        public decimal? MiMonthlyPaymentLevel1 { get => _miMonthlyPaymentLevel1; set => _miMonthlyPaymentLevel1 = value; }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel2;
        public decimal? MiMonthlyPaymentLevel2 { get => _miMonthlyPaymentLevel2; set => _miMonthlyPaymentLevel2 = value; }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel1;
        public int? MiMonthsOfAdjustmentLevel1 { get => _miMonthsOfAdjustmentLevel1; set => _miMonthsOfAdjustmentLevel1 = value; }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel2;
        public int? MiMonthsOfAdjustmentLevel2 { get => _miMonthsOfAdjustmentLevel2; set => _miMonthsOfAdjustmentLevel2 = value; }
        private DirtyValue<decimal?> _minimumLateCharge;
        public decimal? MinimumLateCharge { get => _minimumLateCharge; set => _minimumLateCharge = value; }
        private DirtyValue<decimal?> _minimumPayment;
        public decimal? MinimumPayment { get => _minimumPayment; set => _minimumPayment = value; }
        private DirtyValue<bool?> _mIPFactorLocked;
        public bool? MIPFactorLocked { get => _mIPFactorLocked; set => _mIPFactorLocked = value; }
        private DirtyValue<decimal?> _mIPrepaidAmount;
        public decimal? MIPrepaidAmount { get => _mIPrepaidAmount; set => _mIPrepaidAmount = value; }
        private DirtyValue<bool?> _miPrepaidIndicator;
        public bool? MiPrepaidIndicator { get => _miPrepaidIndicator; set => _miPrepaidIndicator = value; }
        private DirtyValue<string> _miScheduledTerminationDate;
        public string MiScheduledTerminationDate { get => _miScheduledTerminationDate; set => _miScheduledTerminationDate = value; }
        private DirtyValue<bool?> _mmiIndicator;
        public bool? MmiIndicator { get => _mmiIndicator; set => _mmiIndicator = value; }
        private DirtyValue<decimal?> _monthlyTerm;
        public decimal? MonthlyTerm { get => _monthlyTerm; set => _monthlyTerm = value; }
        private DirtyValue<int?> _monthsOfMiPrepaid;
        public int? MonthsOfMiPrepaid { get => _monthsOfMiPrepaid; set => _monthsOfMiPrepaid = value; }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => _mortgageInsuranceCancelPercent = value; }
        private DirtyValue<string> _namePreparedBy;
        public string NamePreparedBy { get => _namePreparedBy; set => _namePreparedBy = value; }
        private DirtyValue<string> _newConstructionIndicator;
        public string NewConstructionIndicator { get => _newConstructionIndicator; set => _newConstructionIndicator = value; }
        private DirtyValue<int?> _numberOfPayments;
        public int? NumberOfPayments { get => _numberOfPayments; set => _numberOfPayments = value; }
        private DirtyValue<DateTime?> _occupancyCertDate;
        public DateTime? OccupancyCertDate { get => _occupancyCertDate; set => _occupancyCertDate = value; }
        private DirtyValue<DateTime?> _originalContractDate;
        public DateTime? OriginalContractDate { get => _originalContractDate; set => _originalContractDate = value; }
        private DirtyValue<decimal?> _outstandingBalance;
        public decimal? OutstandingBalance { get => _outstandingBalance; set => _outstandingBalance = value; }
        private DirtyValue<string> _paymentFrequencyType;
        public string PaymentFrequencyType { get => _paymentFrequencyType; set => _paymentFrequencyType = value; }
        private DirtyValue<decimal?> _paymentIncreasePercent;
        public decimal? PaymentIncreasePercent { get => _paymentIncreasePercent; set => _paymentIncreasePercent = value; }
        private DirtyValue<string> _phonePreparedBy;
        public string PhonePreparedBy { get => _phonePreparedBy; set => _phonePreparedBy = value; }
        private DirtyValue<bool?> _pmiIndicator;
        public bool? PmiIndicator { get => _pmiIndicator; set => _pmiIndicator = value; }
        private DirtyValue<DateTime?> _pmiMidpointCancelationDate;
        public DateTime? PmiMidpointCancelationDate { get => _pmiMidpointCancelationDate; set => _pmiMidpointCancelationDate = value; }
        private DirtyValue<DateTime?> _postConsummationDisclosureReceivedDate;
        public DateTime? PostConsummationDisclosureReceivedDate { get => _postConsummationDisclosureReceivedDate; set => _postConsummationDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _postConsummationDisclosureSentDate;
        public DateTime? PostConsummationDisclosureSentDate { get => _postConsummationDisclosureSentDate; set => _postConsummationDisclosureSentDate = value; }
        private DirtyValue<decimal?> _prepaidFinanceCharge;
        public decimal? PrepaidFinanceCharge { get => _prepaidFinanceCharge; set => _prepaidFinanceCharge = value; }
        private DirtyValue<bool?> _propertyInsuranceIndicator;
        public bool? PropertyInsuranceIndicator { get => _propertyInsuranceIndicator; set => _propertyInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _rateLockGfeDueDate;
        public DateTime? RateLockGfeDueDate { get => _rateLockGfeDueDate; set => _rateLockGfeDueDate = value; }
        private DirtyValue<decimal?> _ratePercent;
        public decimal? RatePercent { get => _ratePercent; set => _ratePercent = value; }
        private DirtyValue<int?> _recastPaidMonths;
        public int? RecastPaidMonths { get => _recastPaidMonths; set => _recastPaidMonths = value; }
        private DirtyValue<int?> _recastStopMonths;
        public int? RecastStopMonths { get => _recastStopMonths; set => _recastStopMonths = value; }
        private DirtyValue<bool?> _refundPaymentIndicator;
        public bool? RefundPaymentIndicator { get => _refundPaymentIndicator; set => _refundPaymentIndicator = value; }
        private DirtyValue<bool?> _refundUnearnedMipIndicator;
        public bool? RefundUnearnedMipIndicator { get => _refundUnearnedMipIndicator; set => _refundUnearnedMipIndicator = value; }
        private DirtyList<RegulationZInterestRatePeriod> _regulationZInterestRatePeriods;
        public IList<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get => _regulationZInterestRatePeriods ?? (_regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>()); set => _regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>(value); }
        private DirtyList<RegulationZPayment> _regulationZPayments;
        public IList<RegulationZPayment> RegulationZPayments { get => _regulationZPayments ?? (_regulationZPayments = new DirtyList<RegulationZPayment>()); set => _regulationZPayments = new DirtyList<RegulationZPayment>(value); }
        private DirtyValue<string> _regzTableType;
        public string RegzTableType { get => _regzTableType; set => _regzTableType = value; }
        private DirtyValue<bool?> _requiredDepositIndicator;
        public bool? RequiredDepositIndicator { get => _requiredDepositIndicator; set => _requiredDepositIndicator = value; }
        private DirtyValue<DateTime?> _revisedClosingDisclosureReceivedDate;
        public DateTime? RevisedClosingDisclosureReceivedDate { get => _revisedClosingDisclosureReceivedDate; set => _revisedClosingDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _revisedClosingDisclosureSentDate;
        public DateTime? RevisedClosingDisclosureSentDate { get => _revisedClosingDisclosureSentDate; set => _revisedClosingDisclosureSentDate = value; }
        private DirtyValue<DateTime?> _revisedGfeDueDate;
        public DateTime? RevisedGfeDueDate { get => _revisedGfeDueDate; set => _revisedGfeDueDate = value; }
        private DirtyValue<decimal?> _roundedMarginPlusIndexPercent;
        public decimal? RoundedMarginPlusIndexPercent { get => _roundedMarginPlusIndexPercent; set => _roundedMarginPlusIndexPercent = value; }
        private DirtyValue<DateTime?> _safeHarborSentDate;
        public DateTime? SafeHarborSentDate { get => _safeHarborSentDate; set => _safeHarborSentDate = value; }
        private DirtyValue<decimal?> _samplePayments;
        public decimal? SamplePayments { get => _samplePayments; set => _samplePayments = value; }
        private DirtyValue<StringEnumValue<SecurityType>> _securityType;
        public StringEnumValue<SecurityType> SecurityType { get => _securityType; set => _securityType = value; }
        private DirtyValue<DateTime?> _sSPLSentDate;
        public DateTime? SSPLSentDate { get => _sSPLSentDate; set => _sSPLSentDate = value; }
        private DirtyValue<DateTime?> _tilDate;
        public DateTime? TilDate { get => _tilDate; set => _tilDate = value; }
        private DirtyValue<string> _tilDisclosedComments;
        public string TilDisclosedComments { get => _tilDisclosedComments; set => _tilDisclosedComments = value; }
        private DirtyValue<StringEnumValue<DisclosureMethod>> _tilDisclosureMethod;
        public StringEnumValue<DisclosureMethod> TilDisclosureMethod { get => _tilDisclosureMethod; set => _tilDisclosureMethod = value; }
        private DirtyValue<DateTime?> _tilLastDisclosedBorrowerReceivedDate;
        public DateTime? TilLastDisclosedBorrowerReceivedDate { get => _tilLastDisclosedBorrowerReceivedDate; set => _tilLastDisclosedBorrowerReceivedDate = value; }
        private DirtyValue<string> _tilLastDisclosedBy;
        public string TilLastDisclosedBy { get => _tilLastDisclosedBy; set => _tilLastDisclosedBy = value; }
        private DirtyValue<DateTime?> _tilLastDisclosedDate;
        public DateTime? TilLastDisclosedDate { get => _tilLastDisclosedDate; set => _tilLastDisclosedDate = value; }
        private DirtyValue<DateTime?> _tilRedisclosureProvidedDate;
        public DateTime? TilRedisclosureProvidedDate { get => _tilRedisclosureProvidedDate; set => _tilRedisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _tilRedisclosureReceivedDate;
        public DateTime? TilRedisclosureReceivedDate { get => _tilRedisclosureReceivedDate; set => _tilRedisclosureReceivedDate = value; }
        private DirtyValue<decimal?> _totalBrokerFees;
        public decimal? TotalBrokerFees { get => _totalBrokerFees; set => _totalBrokerFees = value; }
        private DirtyValue<decimal?> _totalLatePayment;
        public decimal? TotalLatePayment { get => _totalLatePayment; set => _totalLatePayment = value; }
        private DirtyValue<decimal?> _totalLenderFees;
        public decimal? TotalLenderFees { get => _totalLenderFees; set => _totalLenderFees = value; }
        private DirtyValue<decimal?> _totalOfPayments;
        public decimal? TotalOfPayments { get => _totalOfPayments; set => _totalOfPayments = value; }
        private DirtyValue<decimal?> _totalOfPrincipalAndInterest;
        public decimal? TotalOfPrincipalAndInterest { get => _totalOfPrincipalAndInterest; set => _totalOfPrincipalAndInterest = value; }
        private DirtyValue<bool?> _useCustomLenderProfile;
        public bool? UseCustomLenderProfile { get => _useCustomLenderProfile; set => _useCustomLenderProfile = value; }
        private DirtyValue<StringEnumValue<DaysInYear>> _useDaysInYears;
        public StringEnumValue<DaysInYear> UseDaysInYears { get => _useDaysInYears; set => _useDaysInYears = value; }
        private DirtyValue<bool?> _usePitiForRatioIndicator;
        public bool? UsePitiForRatioIndicator { get => _usePitiForRatioIndicator; set => _usePitiForRatioIndicator = value; }
        private DirtyValue<bool?> _variableRateFeatureIndicator;
        public bool? VariableRateFeatureIndicator { get => _variableRateFeatureIndicator; set => _variableRateFeatureIndicator = value; }
        private DirtyValue<decimal?> _yearlyTerm;
        public decimal? YearlyTerm { get => _yearlyTerm; set => _yearlyTerm = value; }
        private DirtyValue<string> _yearOfMaximumPayment;
        public string YearOfMaximumPayment { get => _yearOfMaximumPayment; set => _yearOfMaximumPayment = value; }
        private DirtyValue<int?> _years;
        public int? Years { get => _years; set => _years = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _acknowledgedDay.Dirty
                    || _acknowledgedMonth.Dirty
                    || _acknowledgedYear.Dirty
                    || _acquisition.Dirty
                    || _additionalArmInformation.Dirty
                    || _allDateAndNumericalDisclosuresIndicator.Dirty
                    || _amountFinanced.Dirty
                    || _aprPercent.Dirty
                    || _armDisclosureDescription.Dirty
                    || _assumptionOnYourProperty.Dirty
                    || _borrowerIntendToContinueDate.Dirty
                    || _borrowerIntendToContinueIndicator.Dirty
                    || _borrowerMiTerminationDate.Dirty
                    || _calculateBasedOnRemainingBalance.Dirty
                    || _chargesAddedToPaymentsIndicator.Dirty
                    || _chargesAtLoanClosingIndicator.Dirty
                    || _circumstanceChangeReason.Dirty
                    || _circumstanceChangeReceivedDate.Dirty
                    || _closingDisclosureReceivedDate.Dirty
                    || _closingDisclosureSentDate.Dirty
                    || _constructionFirstIntChangeAdjType.Dirty
                    || _constructionLoanDescription.Dirty
                    || _constructionLoanMethod.Dirty
                    || _constructionPeriodMonths.Dirty
                    || _constructionRatePercent.Dirty
                    || _constructionRefinanceIndicator.Dirty
                    || _creditDisability.Dirty
                    || _creditDisabilityIndicator.Dirty
                    || _creditLife.Dirty
                    || _creditLifeAndCreditDisability.Dirty
                    || _creditLifeInsuranceIndicator.Dirty
                    || _customizePaymentScheduleIndicator.Dirty
                    || _demandFeatureIndicator.Dirty
                    || _disclosedAprPercent.Dirty
                    || _disclosedByBrokerIndicator.Dirty
                    || _disclosedComments.Dirty
                    || _disclosedDailyInterestCharge.Dirty
                    || _disclosedFinanceCharge.Dirty
                    || _disclosedPrepayment.Dirty
                    || _disclosedProduct.Dirty
                    || _disclosureMethod.Dirty
                    || _disclosureType.Dirty
                    || _discountPeriod.Dirty
                    || _discountRatePercent.Dirty
                    || _discountType.Dirty
                    || _dueDate.Dirty
                    || _earliestClosingDate.Dirty
                    || _earliestFeeCollectionDate.Dirty
                    || _eSignConsentBorrowerDateAccepted1.Dirty
                    || _eSignConsentBorrowerDateAccepted2.Dirty
                    || _eSignConsentBorrowerDateAccepted3.Dirty
                    || _eSignConsentBorrowerDateAccepted4.Dirty
                    || _eSignConsentBorrowerDateAccepted5.Dirty
                    || _eSignConsentBorrowerDateAccepted6.Dirty
                    || _eSignConsentBorrowerIPAddress1.Dirty
                    || _eSignConsentBorrowerIPAddress2.Dirty
                    || _eSignConsentBorrowerIPAddress3.Dirty
                    || _eSignConsentBorrowerIPAddress4.Dirty
                    || _eSignConsentBorrowerIPAddress5.Dirty
                    || _eSignConsentBorrowerIPAddress6.Dirty
                    || _eSignConsentBorrowerSource1.Dirty
                    || _eSignConsentBorrowerSource2.Dirty
                    || _eSignConsentBorrowerSource3.Dirty
                    || _eSignConsentBorrowerSource4.Dirty
                    || _eSignConsentBorrowerSource5.Dirty
                    || _eSignConsentBorrowerSource6.Dirty
                    || _eSignConsentBorrowerStatus1.Dirty
                    || _eSignConsentBorrowerStatus2.Dirty
                    || _eSignConsentBorrowerStatus3.Dirty
                    || _eSignConsentBorrowerStatus4.Dirty
                    || _eSignConsentBorrowerStatus5.Dirty
                    || _eSignConsentBorrowerStatus6.Dirty
                    || _eSignConsentCoBorrowerDateAccepted1.Dirty
                    || _eSignConsentCoBorrowerDateAccepted2.Dirty
                    || _eSignConsentCoBorrowerDateAccepted3.Dirty
                    || _eSignConsentCoBorrowerDateAccepted4.Dirty
                    || _eSignConsentCoBorrowerDateAccepted5.Dirty
                    || _eSignConsentCoBorrowerDateAccepted6.Dirty
                    || _eSignConsentCoBorrowerIPAddress1.Dirty
                    || _eSignConsentCoBorrowerIPAddress2.Dirty
                    || _eSignConsentCoBorrowerIPAddress3.Dirty
                    || _eSignConsentCoBorrowerIPAddress4.Dirty
                    || _eSignConsentCoBorrowerIPAddress5.Dirty
                    || _eSignConsentCoBorrowerIPAddress6.Dirty
                    || _eSignConsentCoBorrowerSource1.Dirty
                    || _eSignConsentCoBorrowerSource2.Dirty
                    || _eSignConsentCoBorrowerSource3.Dirty
                    || _eSignConsentCoBorrowerSource4.Dirty
                    || _eSignConsentCoBorrowerSource5.Dirty
                    || _eSignConsentCoBorrowerSource6.Dirty
                    || _eSignConsentCoBorrowerStatus1.Dirty
                    || _eSignConsentCoBorrowerStatus2.Dirty
                    || _eSignConsentCoBorrowerStatus3.Dirty
                    || _eSignConsentCoBorrowerStatus4.Dirty
                    || _eSignConsentCoBorrowerStatus5.Dirty
                    || _eSignConsentCoBorrowerStatus6.Dirty
                    || _eSignConsentDate.Dirty
                    || _extraPaymentForEarlyPayOff.Dirty
                    || _feeCollectedDate.Dirty
                    || _filingFees.Dirty
                    || _finalPaymentDate.Dirty
                    || _financeCharge.Dirty
                    || _financedAllGuaranteeFeeAmount.Dirty
                    || _financedAllGuaranteeFeePercent.Dirty
                    || _financedAllTotalLoanAmount.Dirty
                    || _financedPortionGuaranteeFeeAmount.Dirty
                    || _financedPortionGuaranteeFeePercent.Dirty
                    || _financedPortionTotalLoanAmount.Dirty
                    || _financingType.Dirty
                    || _firstAmortizationPaymentDate.Dirty
                    || _floodInsuranceIndicator.Dirty
                    || _gfeApplicationDate.Dirty
                    || _gfeChangedCircumstanceIndicator.Dirty
                    || _gfeChangedCircumstanceItem.Dirty
                    || _gFEChangedCirsumstanceItemCode.Dirty
                    || _gfeDate.Dirty
                    || _gfeExpirationDate.Dirty
                    || _gfeExpirationPeriod.Dirty
                    || _gfeRateLockRedisclosureRequiredIndicator.Dirty
                    || _gfeRedisclosureProvidedDate.Dirty
                    || _gfeRedisclosureReceivedDate.Dirty
                    || _highCostDisclosure.Dirty
                    || _homeCounselingProvidedDate.Dirty
                    || _hud1ToleranceViolatedIndicator.Dirty
                    || _hudToleranceResolutionComments.Dirty
                    || _hudToleranceResolutionDate.Dirty
                    || _hudToleranceResolvedBy.Dirty
                    || _id.Dirty
                    || _ifYouPurchaseIndicator.Dirty
                    || _ifYouPurchaseType.Dirty
                    || _includeMiIndicator.Dirty
                    || _includePmiIndicator.Dirty
                    || _includeTaxesInsuranceIndicator.Dirty
                    || _initialAVMProvidedDate.Dirty
                    || _initialDisclosureDueDate.Dirty
                    || _initialDisclosureProvidedDate.Dirty
                    || _initialGfeAffiliatedBusinessProvidedDate.Dirty
                    || _initialGFEAppraisalProvidedDate.Dirty
                    || _initialGfeCharmBookletProvidedDate.Dirty
                    || _initialGfeDisclosureProvidedDate.Dirty
                    || _initialGfeDisclosureReceivedDate.Dirty
                    || _initialGfeHelocBrochureProvidedDate.Dirty
                    || _initialGfeHudSpecialBookletProvidedDate.Dirty
                    || _initialSubsequentAppraisalProvidedDate.Dirty
                    || _initialTilDisclosureProvidedDate.Dirty
                    || _initialTilDisclosureReceivedDate.Dirty
                    || _insuranceRequiredDescription.Dirty
                    || _interestInNameOf.Dirty
                    || _interestOnly.Dirty
                    || _interestOnlyIndicator.Dirty
                    || _interestOnlyMonths.Dirty
                    || _interestRateType.Dirty
                    || _interestReserveAmount.Dirty
                    || _lastDisclosedBy.Dirty
                    || _lastDisclosedDate.Dirty
                    || _lastDisclosedGfeReceivedDate.Dirty
                    || _lateChargeBasis.Dirty
                    || _lateChargeComments.Dirty
                    || _lateChargeDays.Dirty
                    || _lateChargePercent.Dirty
                    || _lateChargeType.Dirty
                    || _lateFee.Dirty
                    || _lEIntentToProceedComment.Dirty
                    || _lenderPaidMortgageInsuranceIndicator.Dirty
                    || _lendersInspectionFee.Dirty
                    || _lEReceivedBy.Dirty
                    || _lEReceivedMethod.Dirty
                    || _lEReceivedMethodOther.Dirty
                    || _lESentOnDate.Dirty
                    || _marginPlusIndexPercent.Dirty
                    || _maximumLateCharge.Dirty
                    || _maximumPayment.Dirty
                    || _meansAnEstimateIndicator.Dirty
                    || _miAdjustmentFactorLevel2.Dirty
                    || _miDecliningRenewalsIndicator.Dirty
                    || _midpointCancellation.Dirty
                    || _miMonthlyPaymentLevel1.Dirty
                    || _miMonthlyPaymentLevel2.Dirty
                    || _miMonthsOfAdjustmentLevel1.Dirty
                    || _miMonthsOfAdjustmentLevel2.Dirty
                    || _minimumLateCharge.Dirty
                    || _minimumPayment.Dirty
                    || _mIPFactorLocked.Dirty
                    || _mIPrepaidAmount.Dirty
                    || _miPrepaidIndicator.Dirty
                    || _miScheduledTerminationDate.Dirty
                    || _mmiIndicator.Dirty
                    || _monthlyTerm.Dirty
                    || _monthsOfMiPrepaid.Dirty
                    || _mortgageInsuranceCancelPercent.Dirty
                    || _namePreparedBy.Dirty
                    || _newConstructionIndicator.Dirty
                    || _numberOfPayments.Dirty
                    || _occupancyCertDate.Dirty
                    || _originalContractDate.Dirty
                    || _outstandingBalance.Dirty
                    || _paymentFrequencyType.Dirty
                    || _paymentIncreasePercent.Dirty
                    || _phonePreparedBy.Dirty
                    || _pmiIndicator.Dirty
                    || _pmiMidpointCancelationDate.Dirty
                    || _postConsummationDisclosureReceivedDate.Dirty
                    || _postConsummationDisclosureSentDate.Dirty
                    || _prepaidFinanceCharge.Dirty
                    || _propertyInsuranceIndicator.Dirty
                    || _rateLockGfeDueDate.Dirty
                    || _ratePercent.Dirty
                    || _recastPaidMonths.Dirty
                    || _recastStopMonths.Dirty
                    || _refundPaymentIndicator.Dirty
                    || _refundUnearnedMipIndicator.Dirty
                    || _regzTableType.Dirty
                    || _requiredDepositIndicator.Dirty
                    || _revisedClosingDisclosureReceivedDate.Dirty
                    || _revisedClosingDisclosureSentDate.Dirty
                    || _revisedGfeDueDate.Dirty
                    || _roundedMarginPlusIndexPercent.Dirty
                    || _safeHarborSentDate.Dirty
                    || _samplePayments.Dirty
                    || _securityType.Dirty
                    || _sSPLSentDate.Dirty
                    || _tilDate.Dirty
                    || _tilDisclosedComments.Dirty
                    || _tilDisclosureMethod.Dirty
                    || _tilLastDisclosedBorrowerReceivedDate.Dirty
                    || _tilLastDisclosedBy.Dirty
                    || _tilLastDisclosedDate.Dirty
                    || _tilRedisclosureProvidedDate.Dirty
                    || _tilRedisclosureReceivedDate.Dirty
                    || _totalBrokerFees.Dirty
                    || _totalLatePayment.Dirty
                    || _totalLenderFees.Dirty
                    || _totalOfPayments.Dirty
                    || _totalOfPrincipalAndInterest.Dirty
                    || _useCustomLenderProfile.Dirty
                    || _useDaysInYears.Dirty
                    || _usePitiForRatioIndicator.Dirty
                    || _variableRateFeatureIndicator.Dirty
                    || _yearlyTerm.Dirty
                    || _yearOfMaximumPayment.Dirty
                    || _years.Dirty
                    || _regulationZInterestRatePeriods?.Dirty == true
                    || _regulationZPayments?.Dirty == true;
            }
            set
            {
                _acknowledgedDay.Dirty = value;
                _acknowledgedMonth.Dirty = value;
                _acknowledgedYear.Dirty = value;
                _acquisition.Dirty = value;
                _additionalArmInformation.Dirty = value;
                _allDateAndNumericalDisclosuresIndicator.Dirty = value;
                _amountFinanced.Dirty = value;
                _aprPercent.Dirty = value;
                _armDisclosureDescription.Dirty = value;
                _assumptionOnYourProperty.Dirty = value;
                _borrowerIntendToContinueDate.Dirty = value;
                _borrowerIntendToContinueIndicator.Dirty = value;
                _borrowerMiTerminationDate.Dirty = value;
                _calculateBasedOnRemainingBalance.Dirty = value;
                _chargesAddedToPaymentsIndicator.Dirty = value;
                _chargesAtLoanClosingIndicator.Dirty = value;
                _circumstanceChangeReason.Dirty = value;
                _circumstanceChangeReceivedDate.Dirty = value;
                _closingDisclosureReceivedDate.Dirty = value;
                _closingDisclosureSentDate.Dirty = value;
                _constructionFirstIntChangeAdjType.Dirty = value;
                _constructionLoanDescription.Dirty = value;
                _constructionLoanMethod.Dirty = value;
                _constructionPeriodMonths.Dirty = value;
                _constructionRatePercent.Dirty = value;
                _constructionRefinanceIndicator.Dirty = value;
                _creditDisability.Dirty = value;
                _creditDisabilityIndicator.Dirty = value;
                _creditLife.Dirty = value;
                _creditLifeAndCreditDisability.Dirty = value;
                _creditLifeInsuranceIndicator.Dirty = value;
                _customizePaymentScheduleIndicator.Dirty = value;
                _demandFeatureIndicator.Dirty = value;
                _disclosedAprPercent.Dirty = value;
                _disclosedByBrokerIndicator.Dirty = value;
                _disclosedComments.Dirty = value;
                _disclosedDailyInterestCharge.Dirty = value;
                _disclosedFinanceCharge.Dirty = value;
                _disclosedPrepayment.Dirty = value;
                _disclosedProduct.Dirty = value;
                _disclosureMethod.Dirty = value;
                _disclosureType.Dirty = value;
                _discountPeriod.Dirty = value;
                _discountRatePercent.Dirty = value;
                _discountType.Dirty = value;
                _dueDate.Dirty = value;
                _earliestClosingDate.Dirty = value;
                _earliestFeeCollectionDate.Dirty = value;
                _eSignConsentBorrowerDateAccepted1.Dirty = value;
                _eSignConsentBorrowerDateAccepted2.Dirty = value;
                _eSignConsentBorrowerDateAccepted3.Dirty = value;
                _eSignConsentBorrowerDateAccepted4.Dirty = value;
                _eSignConsentBorrowerDateAccepted5.Dirty = value;
                _eSignConsentBorrowerDateAccepted6.Dirty = value;
                _eSignConsentBorrowerIPAddress1.Dirty = value;
                _eSignConsentBorrowerIPAddress2.Dirty = value;
                _eSignConsentBorrowerIPAddress3.Dirty = value;
                _eSignConsentBorrowerIPAddress4.Dirty = value;
                _eSignConsentBorrowerIPAddress5.Dirty = value;
                _eSignConsentBorrowerIPAddress6.Dirty = value;
                _eSignConsentBorrowerSource1.Dirty = value;
                _eSignConsentBorrowerSource2.Dirty = value;
                _eSignConsentBorrowerSource3.Dirty = value;
                _eSignConsentBorrowerSource4.Dirty = value;
                _eSignConsentBorrowerSource5.Dirty = value;
                _eSignConsentBorrowerSource6.Dirty = value;
                _eSignConsentBorrowerStatus1.Dirty = value;
                _eSignConsentBorrowerStatus2.Dirty = value;
                _eSignConsentBorrowerStatus3.Dirty = value;
                _eSignConsentBorrowerStatus4.Dirty = value;
                _eSignConsentBorrowerStatus5.Dirty = value;
                _eSignConsentBorrowerStatus6.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted1.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted2.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted3.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted4.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted5.Dirty = value;
                _eSignConsentCoBorrowerDateAccepted6.Dirty = value;
                _eSignConsentCoBorrowerIPAddress1.Dirty = value;
                _eSignConsentCoBorrowerIPAddress2.Dirty = value;
                _eSignConsentCoBorrowerIPAddress3.Dirty = value;
                _eSignConsentCoBorrowerIPAddress4.Dirty = value;
                _eSignConsentCoBorrowerIPAddress5.Dirty = value;
                _eSignConsentCoBorrowerIPAddress6.Dirty = value;
                _eSignConsentCoBorrowerSource1.Dirty = value;
                _eSignConsentCoBorrowerSource2.Dirty = value;
                _eSignConsentCoBorrowerSource3.Dirty = value;
                _eSignConsentCoBorrowerSource4.Dirty = value;
                _eSignConsentCoBorrowerSource5.Dirty = value;
                _eSignConsentCoBorrowerSource6.Dirty = value;
                _eSignConsentCoBorrowerStatus1.Dirty = value;
                _eSignConsentCoBorrowerStatus2.Dirty = value;
                _eSignConsentCoBorrowerStatus3.Dirty = value;
                _eSignConsentCoBorrowerStatus4.Dirty = value;
                _eSignConsentCoBorrowerStatus5.Dirty = value;
                _eSignConsentCoBorrowerStatus6.Dirty = value;
                _eSignConsentDate.Dirty = value;
                _extraPaymentForEarlyPayOff.Dirty = value;
                _feeCollectedDate.Dirty = value;
                _filingFees.Dirty = value;
                _finalPaymentDate.Dirty = value;
                _financeCharge.Dirty = value;
                _financedAllGuaranteeFeeAmount.Dirty = value;
                _financedAllGuaranteeFeePercent.Dirty = value;
                _financedAllTotalLoanAmount.Dirty = value;
                _financedPortionGuaranteeFeeAmount.Dirty = value;
                _financedPortionGuaranteeFeePercent.Dirty = value;
                _financedPortionTotalLoanAmount.Dirty = value;
                _financingType.Dirty = value;
                _firstAmortizationPaymentDate.Dirty = value;
                _floodInsuranceIndicator.Dirty = value;
                _gfeApplicationDate.Dirty = value;
                _gfeChangedCircumstanceIndicator.Dirty = value;
                _gfeChangedCircumstanceItem.Dirty = value;
                _gFEChangedCirsumstanceItemCode.Dirty = value;
                _gfeDate.Dirty = value;
                _gfeExpirationDate.Dirty = value;
                _gfeExpirationPeriod.Dirty = value;
                _gfeRateLockRedisclosureRequiredIndicator.Dirty = value;
                _gfeRedisclosureProvidedDate.Dirty = value;
                _gfeRedisclosureReceivedDate.Dirty = value;
                _highCostDisclosure.Dirty = value;
                _homeCounselingProvidedDate.Dirty = value;
                _hud1ToleranceViolatedIndicator.Dirty = value;
                _hudToleranceResolutionComments.Dirty = value;
                _hudToleranceResolutionDate.Dirty = value;
                _hudToleranceResolvedBy.Dirty = value;
                _id.Dirty = value;
                _ifYouPurchaseIndicator.Dirty = value;
                _ifYouPurchaseType.Dirty = value;
                _includeMiIndicator.Dirty = value;
                _includePmiIndicator.Dirty = value;
                _includeTaxesInsuranceIndicator.Dirty = value;
                _initialAVMProvidedDate.Dirty = value;
                _initialDisclosureDueDate.Dirty = value;
                _initialDisclosureProvidedDate.Dirty = value;
                _initialGfeAffiliatedBusinessProvidedDate.Dirty = value;
                _initialGFEAppraisalProvidedDate.Dirty = value;
                _initialGfeCharmBookletProvidedDate.Dirty = value;
                _initialGfeDisclosureProvidedDate.Dirty = value;
                _initialGfeDisclosureReceivedDate.Dirty = value;
                _initialGfeHelocBrochureProvidedDate.Dirty = value;
                _initialGfeHudSpecialBookletProvidedDate.Dirty = value;
                _initialSubsequentAppraisalProvidedDate.Dirty = value;
                _initialTilDisclosureProvidedDate.Dirty = value;
                _initialTilDisclosureReceivedDate.Dirty = value;
                _insuranceRequiredDescription.Dirty = value;
                _interestInNameOf.Dirty = value;
                _interestOnly.Dirty = value;
                _interestOnlyIndicator.Dirty = value;
                _interestOnlyMonths.Dirty = value;
                _interestRateType.Dirty = value;
                _interestReserveAmount.Dirty = value;
                _lastDisclosedBy.Dirty = value;
                _lastDisclosedDate.Dirty = value;
                _lastDisclosedGfeReceivedDate.Dirty = value;
                _lateChargeBasis.Dirty = value;
                _lateChargeComments.Dirty = value;
                _lateChargeDays.Dirty = value;
                _lateChargePercent.Dirty = value;
                _lateChargeType.Dirty = value;
                _lateFee.Dirty = value;
                _lEIntentToProceedComment.Dirty = value;
                _lenderPaidMortgageInsuranceIndicator.Dirty = value;
                _lendersInspectionFee.Dirty = value;
                _lEReceivedBy.Dirty = value;
                _lEReceivedMethod.Dirty = value;
                _lEReceivedMethodOther.Dirty = value;
                _lESentOnDate.Dirty = value;
                _marginPlusIndexPercent.Dirty = value;
                _maximumLateCharge.Dirty = value;
                _maximumPayment.Dirty = value;
                _meansAnEstimateIndicator.Dirty = value;
                _miAdjustmentFactorLevel2.Dirty = value;
                _miDecliningRenewalsIndicator.Dirty = value;
                _midpointCancellation.Dirty = value;
                _miMonthlyPaymentLevel1.Dirty = value;
                _miMonthlyPaymentLevel2.Dirty = value;
                _miMonthsOfAdjustmentLevel1.Dirty = value;
                _miMonthsOfAdjustmentLevel2.Dirty = value;
                _minimumLateCharge.Dirty = value;
                _minimumPayment.Dirty = value;
                _mIPFactorLocked.Dirty = value;
                _mIPrepaidAmount.Dirty = value;
                _miPrepaidIndicator.Dirty = value;
                _miScheduledTerminationDate.Dirty = value;
                _mmiIndicator.Dirty = value;
                _monthlyTerm.Dirty = value;
                _monthsOfMiPrepaid.Dirty = value;
                _mortgageInsuranceCancelPercent.Dirty = value;
                _namePreparedBy.Dirty = value;
                _newConstructionIndicator.Dirty = value;
                _numberOfPayments.Dirty = value;
                _occupancyCertDate.Dirty = value;
                _originalContractDate.Dirty = value;
                _outstandingBalance.Dirty = value;
                _paymentFrequencyType.Dirty = value;
                _paymentIncreasePercent.Dirty = value;
                _phonePreparedBy.Dirty = value;
                _pmiIndicator.Dirty = value;
                _pmiMidpointCancelationDate.Dirty = value;
                _postConsummationDisclosureReceivedDate.Dirty = value;
                _postConsummationDisclosureSentDate.Dirty = value;
                _prepaidFinanceCharge.Dirty = value;
                _propertyInsuranceIndicator.Dirty = value;
                _rateLockGfeDueDate.Dirty = value;
                _ratePercent.Dirty = value;
                _recastPaidMonths.Dirty = value;
                _recastStopMonths.Dirty = value;
                _refundPaymentIndicator.Dirty = value;
                _refundUnearnedMipIndicator.Dirty = value;
                _regzTableType.Dirty = value;
                _requiredDepositIndicator.Dirty = value;
                _revisedClosingDisclosureReceivedDate.Dirty = value;
                _revisedClosingDisclosureSentDate.Dirty = value;
                _revisedGfeDueDate.Dirty = value;
                _roundedMarginPlusIndexPercent.Dirty = value;
                _safeHarborSentDate.Dirty = value;
                _samplePayments.Dirty = value;
                _securityType.Dirty = value;
                _sSPLSentDate.Dirty = value;
                _tilDate.Dirty = value;
                _tilDisclosedComments.Dirty = value;
                _tilDisclosureMethod.Dirty = value;
                _tilLastDisclosedBorrowerReceivedDate.Dirty = value;
                _tilLastDisclosedBy.Dirty = value;
                _tilLastDisclosedDate.Dirty = value;
                _tilRedisclosureProvidedDate.Dirty = value;
                _tilRedisclosureReceivedDate.Dirty = value;
                _totalBrokerFees.Dirty = value;
                _totalLatePayment.Dirty = value;
                _totalLenderFees.Dirty = value;
                _totalOfPayments.Dirty = value;
                _totalOfPrincipalAndInterest.Dirty = value;
                _useCustomLenderProfile.Dirty = value;
                _useDaysInYears.Dirty = value;
                _usePitiForRatioIndicator.Dirty = value;
                _variableRateFeatureIndicator.Dirty = value;
                _yearlyTerm.Dirty = value;
                _yearOfMaximumPayment.Dirty = value;
                _years.Dirty = value;
                if (_regulationZInterestRatePeriods != null) _regulationZInterestRatePeriods.Dirty = value;
                if (_regulationZPayments != null) _regulationZPayments.Dirty = value;
            }
        }
    }
}