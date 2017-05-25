using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZ : IClean
    {
        private Value<string> _acknowledgedDay;
        public string AcknowledgedDay { get { return _acknowledgedDay; } set { _acknowledgedDay = value; } }
        private Value<string> _acknowledgedMonth;
        public string AcknowledgedMonth { get { return _acknowledgedMonth; } set { _acknowledgedMonth = value; } }
        private Value<string> _acknowledgedYear;
        public string AcknowledgedYear { get { return _acknowledgedYear; } set { _acknowledgedYear = value; } }
        private Value<bool?> _acquisition;
        public bool? Acquisition { get { return _acquisition; } set { _acquisition = value; } }
        private Value<string> _additionalArmInformation;
        public string AdditionalArmInformation { get { return _additionalArmInformation; } set { _additionalArmInformation = value; } }
        private Value<bool?> _allDateAndNumericalDisclosuresIndicator;
        public bool? AllDateAndNumericalDisclosuresIndicator { get { return _allDateAndNumericalDisclosuresIndicator; } set { _allDateAndNumericalDisclosuresIndicator = value; } }
        private Value<decimal?> _amountFinanced;
        public decimal? AmountFinanced { get { return _amountFinanced; } set { _amountFinanced = value; } }
        private Value<decimal?> _aprPercent;
        public decimal? AprPercent { get { return _aprPercent; } set { _aprPercent = value; } }
        private Value<string> _armDisclosureDescription;
        public string ArmDisclosureDescription { get { return _armDisclosureDescription; } set { _armDisclosureDescription = value; } }
        private Value<string> _assumptionOnYourProperty;
        public string AssumptionOnYourProperty { get { return _assumptionOnYourProperty; } set { _assumptionOnYourProperty = value; } }
        private Value<DateTime?> _borrowerIntendToContinueDate;
        public DateTime? BorrowerIntendToContinueDate { get { return _borrowerIntendToContinueDate; } set { _borrowerIntendToContinueDate = value; } }
        private Value<bool?> _borrowerIntendToContinueIndicator;
        public bool? BorrowerIntendToContinueIndicator { get { return _borrowerIntendToContinueIndicator; } set { _borrowerIntendToContinueIndicator = value; } }
        private Value<string> _borrowerMiTerminationDate;
        public string BorrowerMiTerminationDate { get { return _borrowerMiTerminationDate; } set { _borrowerMiTerminationDate = value; } }
        private Value<string> _calculateBasedOnRemainingBalance;
        public string CalculateBasedOnRemainingBalance { get { return _calculateBasedOnRemainingBalance; } set { _calculateBasedOnRemainingBalance = value; } }
        private Value<bool?> _chargesAddedToPaymentsIndicator;
        public bool? ChargesAddedToPaymentsIndicator { get { return _chargesAddedToPaymentsIndicator; } set { _chargesAddedToPaymentsIndicator = value; } }
        private Value<bool?> _chargesAtLoanClosingIndicator;
        public bool? ChargesAtLoanClosingIndicator { get { return _chargesAtLoanClosingIndicator; } set { _chargesAtLoanClosingIndicator = value; } }
        private Value<string> _circumstanceChangeReason;
        public string CircumstanceChangeReason { get { return _circumstanceChangeReason; } set { _circumstanceChangeReason = value; } }
        private Value<DateTime?> _circumstanceChangeReceivedDate;
        public DateTime? CircumstanceChangeReceivedDate { get { return _circumstanceChangeReceivedDate; } set { _circumstanceChangeReceivedDate = value; } }
        private Value<DateTime?> _closingDisclosureReceivedDate;
        public DateTime? ClosingDisclosureReceivedDate { get { return _closingDisclosureReceivedDate; } set { _closingDisclosureReceivedDate = value; } }
        private Value<DateTime?> _closingDisclosureSentDate;
        public DateTime? ClosingDisclosureSentDate { get { return _closingDisclosureSentDate; } set { _closingDisclosureSentDate = value; } }
        private Value<string> _constructionFirstIntChangeAdjType;
        public string ConstructionFirstIntChangeAdjType { get { return _constructionFirstIntChangeAdjType; } set { _constructionFirstIntChangeAdjType = value; } }
        private Value<string> _constructionLoanDescription;
        public string ConstructionLoanDescription { get { return _constructionLoanDescription; } set { _constructionLoanDescription = value; } }
        private Value<string> _constructionLoanMethod;
        public string ConstructionLoanMethod { get { return _constructionLoanMethod; } set { _constructionLoanMethod = value; } }
        private Value<int?> _constructionPeriodMonths;
        public int? ConstructionPeriodMonths { get { return _constructionPeriodMonths; } set { _constructionPeriodMonths = value; } }
        private Value<decimal?> _constructionRatePercent;
        public decimal? ConstructionRatePercent { get { return _constructionRatePercent; } set { _constructionRatePercent = value; } }
        private Value<bool?> _constructionRefinanceIndicator;
        public bool? ConstructionRefinanceIndicator { get { return _constructionRefinanceIndicator; } set { _constructionRefinanceIndicator = value; } }
        private Value<decimal?> _creditDisability;
        public decimal? CreditDisability { get { return _creditDisability; } set { _creditDisability = value; } }
        private Value<bool?> _creditDisabilityIndicator;
        public bool? CreditDisabilityIndicator { get { return _creditDisabilityIndicator; } set { _creditDisabilityIndicator = value; } }
        private Value<decimal?> _creditLife;
        public decimal? CreditLife { get { return _creditLife; } set { _creditLife = value; } }
        private Value<decimal?> _creditLifeAndCreditDisability;
        public decimal? CreditLifeAndCreditDisability { get { return _creditLifeAndCreditDisability; } set { _creditLifeAndCreditDisability = value; } }
        private Value<bool?> _creditLifeInsuranceIndicator;
        public bool? CreditLifeInsuranceIndicator { get { return _creditLifeInsuranceIndicator; } set { _creditLifeInsuranceIndicator = value; } }
        private Value<bool?> _customizePaymentScheduleIndicator;
        public bool? CustomizePaymentScheduleIndicator { get { return _customizePaymentScheduleIndicator; } set { _customizePaymentScheduleIndicator = value; } }
        private Value<bool?> _demandFeatureIndicator;
        public bool? DemandFeatureIndicator { get { return _demandFeatureIndicator; } set { _demandFeatureIndicator = value; } }
        private Value<decimal?> _disclosedAprPercent;
        public decimal? DisclosedAprPercent { get { return _disclosedAprPercent; } set { _disclosedAprPercent = value; } }
        private Value<bool?> _disclosedByBrokerIndicator;
        public bool? DisclosedByBrokerIndicator { get { return _disclosedByBrokerIndicator; } set { _disclosedByBrokerIndicator = value; } }
        private Value<string> _disclosedComments;
        public string DisclosedComments { get { return _disclosedComments; } set { _disclosedComments = value; } }
        private Value<decimal?> _disclosedDailyInterestCharge;
        public decimal? DisclosedDailyInterestCharge { get { return _disclosedDailyInterestCharge; } set { _disclosedDailyInterestCharge = value; } }
        private Value<decimal?> _disclosedFinanceCharge;
        public decimal? DisclosedFinanceCharge { get { return _disclosedFinanceCharge; } set { _disclosedFinanceCharge = value; } }
        private Value<bool?> _disclosedPrepayment;
        public bool? DisclosedPrepayment { get { return _disclosedPrepayment; } set { _disclosedPrepayment = value; } }
        private Value<string> _disclosedProduct;
        public string DisclosedProduct { get { return _disclosedProduct; } set { _disclosedProduct = value; } }
        private Value<string> _disclosureMethod;
        public string DisclosureMethod { get { return _disclosureMethod; } set { _disclosureMethod = value; } }
        private Value<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        private Value<int?> _discountPeriod;
        public int? DiscountPeriod { get { return _discountPeriod; } set { _discountPeriod = value; } }
        private Value<decimal?> _discountRatePercent;
        public decimal? DiscountRatePercent { get { return _discountRatePercent; } set { _discountRatePercent = value; } }
        private Value<string> _discountType;
        public string DiscountType { get { return _discountType; } set { _discountType = value; } }
        private Value<DateTime?> _dueDate;
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; } }
        private Value<DateTime?> _earliestClosingDate;
        public DateTime? EarliestClosingDate { get { return _earliestClosingDate; } set { _earliestClosingDate = value; } }
        private Value<DateTime?> _earliestFeeCollectionDate;
        public DateTime? EarliestFeeCollectionDate { get { return _earliestFeeCollectionDate; } set { _earliestFeeCollectionDate = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted1;
        public DateTime? eSignConsentBorrowerDateAccepted1 { get { return _eSignConsentBorrowerDateAccepted1; } set { _eSignConsentBorrowerDateAccepted1 = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted2;
        public DateTime? eSignConsentBorrowerDateAccepted2 { get { return _eSignConsentBorrowerDateAccepted2; } set { _eSignConsentBorrowerDateAccepted2 = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted3;
        public DateTime? eSignConsentBorrowerDateAccepted3 { get { return _eSignConsentBorrowerDateAccepted3; } set { _eSignConsentBorrowerDateAccepted3 = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted4;
        public DateTime? eSignConsentBorrowerDateAccepted4 { get { return _eSignConsentBorrowerDateAccepted4; } set { _eSignConsentBorrowerDateAccepted4 = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted5;
        public DateTime? eSignConsentBorrowerDateAccepted5 { get { return _eSignConsentBorrowerDateAccepted5; } set { _eSignConsentBorrowerDateAccepted5 = value; } }
        private Value<DateTime?> _eSignConsentBorrowerDateAccepted6;
        public DateTime? eSignConsentBorrowerDateAccepted6 { get { return _eSignConsentBorrowerDateAccepted6; } set { _eSignConsentBorrowerDateAccepted6 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress1;
        public string eSignConsentBorrowerIPAddress1 { get { return _eSignConsentBorrowerIPAddress1; } set { _eSignConsentBorrowerIPAddress1 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress2;
        public string eSignConsentBorrowerIPAddress2 { get { return _eSignConsentBorrowerIPAddress2; } set { _eSignConsentBorrowerIPAddress2 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress3;
        public string eSignConsentBorrowerIPAddress3 { get { return _eSignConsentBorrowerIPAddress3; } set { _eSignConsentBorrowerIPAddress3 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress4;
        public string eSignConsentBorrowerIPAddress4 { get { return _eSignConsentBorrowerIPAddress4; } set { _eSignConsentBorrowerIPAddress4 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress5;
        public string eSignConsentBorrowerIPAddress5 { get { return _eSignConsentBorrowerIPAddress5; } set { _eSignConsentBorrowerIPAddress5 = value; } }
        private Value<string> _eSignConsentBorrowerIPAddress6;
        public string eSignConsentBorrowerIPAddress6 { get { return _eSignConsentBorrowerIPAddress6; } set { _eSignConsentBorrowerIPAddress6 = value; } }
        private Value<string> _eSignConsentBorrowerSource1;
        public string eSignConsentBorrowerSource1 { get { return _eSignConsentBorrowerSource1; } set { _eSignConsentBorrowerSource1 = value; } }
        private Value<string> _eSignConsentBorrowerSource2;
        public string eSignConsentBorrowerSource2 { get { return _eSignConsentBorrowerSource2; } set { _eSignConsentBorrowerSource2 = value; } }
        private Value<string> _eSignConsentBorrowerSource3;
        public string eSignConsentBorrowerSource3 { get { return _eSignConsentBorrowerSource3; } set { _eSignConsentBorrowerSource3 = value; } }
        private Value<string> _eSignConsentBorrowerSource4;
        public string eSignConsentBorrowerSource4 { get { return _eSignConsentBorrowerSource4; } set { _eSignConsentBorrowerSource4 = value; } }
        private Value<string> _eSignConsentBorrowerSource5;
        public string eSignConsentBorrowerSource5 { get { return _eSignConsentBorrowerSource5; } set { _eSignConsentBorrowerSource5 = value; } }
        private Value<string> _eSignConsentBorrowerSource6;
        public string eSignConsentBorrowerSource6 { get { return _eSignConsentBorrowerSource6; } set { _eSignConsentBorrowerSource6 = value; } }
        private Value<string> _eSignConsentBorrowerStatus1;
        public string eSignConsentBorrowerStatus1 { get { return _eSignConsentBorrowerStatus1; } set { _eSignConsentBorrowerStatus1 = value; } }
        private Value<string> _eSignConsentBorrowerStatus2;
        public string eSignConsentBorrowerStatus2 { get { return _eSignConsentBorrowerStatus2; } set { _eSignConsentBorrowerStatus2 = value; } }
        private Value<string> _eSignConsentBorrowerStatus3;
        public string eSignConsentBorrowerStatus3 { get { return _eSignConsentBorrowerStatus3; } set { _eSignConsentBorrowerStatus3 = value; } }
        private Value<string> _eSignConsentBorrowerStatus4;
        public string eSignConsentBorrowerStatus4 { get { return _eSignConsentBorrowerStatus4; } set { _eSignConsentBorrowerStatus4 = value; } }
        private Value<string> _eSignConsentBorrowerStatus5;
        public string eSignConsentBorrowerStatus5 { get { return _eSignConsentBorrowerStatus5; } set { _eSignConsentBorrowerStatus5 = value; } }
        private Value<string> _eSignConsentBorrowerStatus6;
        public string eSignConsentBorrowerStatus6 { get { return _eSignConsentBorrowerStatus6; } set { _eSignConsentBorrowerStatus6 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted1;
        public DateTime? eSignConsentCoBorrowerDateAccepted1 { get { return _eSignConsentCoBorrowerDateAccepted1; } set { _eSignConsentCoBorrowerDateAccepted1 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted2;
        public DateTime? eSignConsentCoBorrowerDateAccepted2 { get { return _eSignConsentCoBorrowerDateAccepted2; } set { _eSignConsentCoBorrowerDateAccepted2 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted3;
        public DateTime? eSignConsentCoBorrowerDateAccepted3 { get { return _eSignConsentCoBorrowerDateAccepted3; } set { _eSignConsentCoBorrowerDateAccepted3 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted4;
        public DateTime? eSignConsentCoBorrowerDateAccepted4 { get { return _eSignConsentCoBorrowerDateAccepted4; } set { _eSignConsentCoBorrowerDateAccepted4 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted5;
        public DateTime? eSignConsentCoBorrowerDateAccepted5 { get { return _eSignConsentCoBorrowerDateAccepted5; } set { _eSignConsentCoBorrowerDateAccepted5 = value; } }
        private Value<DateTime?> _eSignConsentCoBorrowerDateAccepted6;
        public DateTime? eSignConsentCoBorrowerDateAccepted6 { get { return _eSignConsentCoBorrowerDateAccepted6; } set { _eSignConsentCoBorrowerDateAccepted6 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress1;
        public string eSignConsentCoBorrowerIPAddress1 { get { return _eSignConsentCoBorrowerIPAddress1; } set { _eSignConsentCoBorrowerIPAddress1 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress2;
        public string eSignConsentCoBorrowerIPAddress2 { get { return _eSignConsentCoBorrowerIPAddress2; } set { _eSignConsentCoBorrowerIPAddress2 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress3;
        public string eSignConsentCoBorrowerIPAddress3 { get { return _eSignConsentCoBorrowerIPAddress3; } set { _eSignConsentCoBorrowerIPAddress3 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress4;
        public string eSignConsentCoBorrowerIPAddress4 { get { return _eSignConsentCoBorrowerIPAddress4; } set { _eSignConsentCoBorrowerIPAddress4 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress5;
        public string eSignConsentCoBorrowerIPAddress5 { get { return _eSignConsentCoBorrowerIPAddress5; } set { _eSignConsentCoBorrowerIPAddress5 = value; } }
        private Value<string> _eSignConsentCoBorrowerIPAddress6;
        public string eSignConsentCoBorrowerIPAddress6 { get { return _eSignConsentCoBorrowerIPAddress6; } set { _eSignConsentCoBorrowerIPAddress6 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource1;
        public string eSignConsentCoBorrowerSource1 { get { return _eSignConsentCoBorrowerSource1; } set { _eSignConsentCoBorrowerSource1 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource2;
        public string eSignConsentCoBorrowerSource2 { get { return _eSignConsentCoBorrowerSource2; } set { _eSignConsentCoBorrowerSource2 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource3;
        public string eSignConsentCoBorrowerSource3 { get { return _eSignConsentCoBorrowerSource3; } set { _eSignConsentCoBorrowerSource3 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource4;
        public string eSignConsentCoBorrowerSource4 { get { return _eSignConsentCoBorrowerSource4; } set { _eSignConsentCoBorrowerSource4 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource5;
        public string eSignConsentCoBorrowerSource5 { get { return _eSignConsentCoBorrowerSource5; } set { _eSignConsentCoBorrowerSource5 = value; } }
        private Value<string> _eSignConsentCoBorrowerSource6;
        public string eSignConsentCoBorrowerSource6 { get { return _eSignConsentCoBorrowerSource6; } set { _eSignConsentCoBorrowerSource6 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus1;
        public string eSignConsentCoBorrowerStatus1 { get { return _eSignConsentCoBorrowerStatus1; } set { _eSignConsentCoBorrowerStatus1 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus2;
        public string eSignConsentCoBorrowerStatus2 { get { return _eSignConsentCoBorrowerStatus2; } set { _eSignConsentCoBorrowerStatus2 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus3;
        public string eSignConsentCoBorrowerStatus3 { get { return _eSignConsentCoBorrowerStatus3; } set { _eSignConsentCoBorrowerStatus3 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus4;
        public string eSignConsentCoBorrowerStatus4 { get { return _eSignConsentCoBorrowerStatus4; } set { _eSignConsentCoBorrowerStatus4 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus5;
        public string eSignConsentCoBorrowerStatus5 { get { return _eSignConsentCoBorrowerStatus5; } set { _eSignConsentCoBorrowerStatus5 = value; } }
        private Value<string> _eSignConsentCoBorrowerStatus6;
        public string eSignConsentCoBorrowerStatus6 { get { return _eSignConsentCoBorrowerStatus6; } set { _eSignConsentCoBorrowerStatus6 = value; } }
        private Value<DateTime?> _eSignConsentDate;
        public DateTime? eSignConsentDate { get { return _eSignConsentDate; } set { _eSignConsentDate = value; } }
        private Value<decimal?> _extraPaymentForEarlyPayOff;
        public decimal? ExtraPaymentForEarlyPayOff { get { return _extraPaymentForEarlyPayOff; } set { _extraPaymentForEarlyPayOff = value; } }
        private Value<DateTime?> _feeCollectedDate;
        public DateTime? FeeCollectedDate { get { return _feeCollectedDate; } set { _feeCollectedDate = value; } }
        private Value<decimal?> _filingFees;
        public decimal? FilingFees { get { return _filingFees; } set { _filingFees = value; } }
        private Value<DateTime?> _finalPaymentDate;
        public DateTime? FinalPaymentDate { get { return _finalPaymentDate; } set { _finalPaymentDate = value; } }
        private Value<decimal?> _financeCharge;
        public decimal? FinanceCharge { get { return _financeCharge; } set { _financeCharge = value; } }
        private Value<decimal?> _financedAllGuaranteeFeeAmount;
        public decimal? FinancedAllGuaranteeFeeAmount { get { return _financedAllGuaranteeFeeAmount; } set { _financedAllGuaranteeFeeAmount = value; } }
        private Value<decimal?> _financedAllGuaranteeFeePercent;
        public decimal? FinancedAllGuaranteeFeePercent { get { return _financedAllGuaranteeFeePercent; } set { _financedAllGuaranteeFeePercent = value; } }
        private Value<decimal?> _financedAllTotalLoanAmount;
        public decimal? FinancedAllTotalLoanAmount { get { return _financedAllTotalLoanAmount; } set { _financedAllTotalLoanAmount = value; } }
        private Value<decimal?> _financedPortionGuaranteeFeeAmount;
        public decimal? FinancedPortionGuaranteeFeeAmount { get { return _financedPortionGuaranteeFeeAmount; } set { _financedPortionGuaranteeFeeAmount = value; } }
        private Value<decimal?> _financedPortionGuaranteeFeePercent;
        public decimal? FinancedPortionGuaranteeFeePercent { get { return _financedPortionGuaranteeFeePercent; } set { _financedPortionGuaranteeFeePercent = value; } }
        private Value<decimal?> _financedPortionTotalLoanAmount;
        public decimal? FinancedPortionTotalLoanAmount { get { return _financedPortionTotalLoanAmount; } set { _financedPortionTotalLoanAmount = value; } }
        private Value<string> _financingType;
        public string FinancingType { get { return _financingType; } set { _financingType = value; } }
        private Value<DateTime?> _firstAmortizationPaymentDate;
        public DateTime? FirstAmortizationPaymentDate { get { return _firstAmortizationPaymentDate; } set { _firstAmortizationPaymentDate = value; } }
        private Value<bool?> _floodInsuranceIndicator;
        public bool? FloodInsuranceIndicator { get { return _floodInsuranceIndicator; } set { _floodInsuranceIndicator = value; } }
        private Value<DateTime?> _gfeApplicationDate;
        public DateTime? GfeApplicationDate { get { return _gfeApplicationDate; } set { _gfeApplicationDate = value; } }
        private Value<bool?> _gfeChangedCircumstanceIndicator;
        public bool? GfeChangedCircumstanceIndicator { get { return _gfeChangedCircumstanceIndicator; } set { _gfeChangedCircumstanceIndicator = value; } }
        private Value<string> _gfeChangedCircumstanceItem;
        public string GfeChangedCircumstanceItem { get { return _gfeChangedCircumstanceItem; } set { _gfeChangedCircumstanceItem = value; } }
        private Value<string> _gFEChangedCirsumstanceItemCode;
        public string GFEChangedCirsumstanceItemCode { get { return _gFEChangedCirsumstanceItemCode; } set { _gFEChangedCirsumstanceItemCode = value; } }
        private Value<DateTime?> _gfeDate;
        public DateTime? GfeDate { get { return _gfeDate; } set { _gfeDate = value; } }
        private Value<DateTime?> _gfeExpirationDate;
        public DateTime? GfeExpirationDate { get { return _gfeExpirationDate; } set { _gfeExpirationDate = value; } }
        private Value<string> _gfeExpirationPeriod;
        public string GfeExpirationPeriod { get { return _gfeExpirationPeriod; } set { _gfeExpirationPeriod = value; } }
        private Value<bool?> _gfeRateLockRedisclosureRequiredIndicator;
        public bool? GfeRateLockRedisclosureRequiredIndicator { get { return _gfeRateLockRedisclosureRequiredIndicator; } set { _gfeRateLockRedisclosureRequiredIndicator = value; } }
        private Value<DateTime?> _gfeRedisclosureProvidedDate;
        public DateTime? GfeRedisclosureProvidedDate { get { return _gfeRedisclosureProvidedDate; } set { _gfeRedisclosureProvidedDate = value; } }
        private Value<DateTime?> _gfeRedisclosureReceivedDate;
        public DateTime? GfeRedisclosureReceivedDate { get { return _gfeRedisclosureReceivedDate; } set { _gfeRedisclosureReceivedDate = value; } }
        private Value<DateTime?> _highCostDisclosure;
        public DateTime? HighCostDisclosure { get { return _highCostDisclosure; } set { _highCostDisclosure = value; } }
        private Value<DateTime?> _homeCounselingProvidedDate;
        public DateTime? HomeCounselingProvidedDate { get { return _homeCounselingProvidedDate; } set { _homeCounselingProvidedDate = value; } }
        private Value<bool?> _hud1ToleranceViolatedIndicator;
        public bool? Hud1ToleranceViolatedIndicator { get { return _hud1ToleranceViolatedIndicator; } set { _hud1ToleranceViolatedIndicator = value; } }
        private Value<string> _hudToleranceResolutionComments;
        public string HudToleranceResolutionComments { get { return _hudToleranceResolutionComments; } set { _hudToleranceResolutionComments = value; } }
        private Value<DateTime?> _hudToleranceResolutionDate;
        public DateTime? HudToleranceResolutionDate { get { return _hudToleranceResolutionDate; } set { _hudToleranceResolutionDate = value; } }
        private Value<string> _hudToleranceResolvedBy;
        public string HudToleranceResolvedBy { get { return _hudToleranceResolvedBy; } set { _hudToleranceResolvedBy = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _ifYouPurchaseIndicator;
        public bool? IfYouPurchaseIndicator { get { return _ifYouPurchaseIndicator; } set { _ifYouPurchaseIndicator = value; } }
        private Value<string> _ifYouPurchaseType;
        public string IfYouPurchaseType { get { return _ifYouPurchaseType; } set { _ifYouPurchaseType = value; } }
        private Value<bool?> _includeMiIndicator;
        public bool? IncludeMiIndicator { get { return _includeMiIndicator; } set { _includeMiIndicator = value; } }
        private Value<bool?> _includePmiIndicator;
        public bool? IncludePmiIndicator { get { return _includePmiIndicator; } set { _includePmiIndicator = value; } }
        private Value<bool?> _includeTaxesInsuranceIndicator;
        public bool? IncludeTaxesInsuranceIndicator { get { return _includeTaxesInsuranceIndicator; } set { _includeTaxesInsuranceIndicator = value; } }
        private Value<DateTime?> _initialAVMProvidedDate;
        public DateTime? InitialAVMProvidedDate { get { return _initialAVMProvidedDate; } set { _initialAVMProvidedDate = value; } }
        private Value<DateTime?> _initialDisclosureDueDate;
        public DateTime? InitialDisclosureDueDate { get { return _initialDisclosureDueDate; } set { _initialDisclosureDueDate = value; } }
        private Value<DateTime?> _initialDisclosureProvidedDate;
        public DateTime? InitialDisclosureProvidedDate { get { return _initialDisclosureProvidedDate; } set { _initialDisclosureProvidedDate = value; } }
        private Value<DateTime?> _initialGfeAffiliatedBusinessProvidedDate;
        public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get { return _initialGfeAffiliatedBusinessProvidedDate; } set { _initialGfeAffiliatedBusinessProvidedDate = value; } }
        private Value<DateTime?> _initialGFEAppraisalProvidedDate;
        public DateTime? InitialGFEAppraisalProvidedDate { get { return _initialGFEAppraisalProvidedDate; } set { _initialGFEAppraisalProvidedDate = value; } }
        private Value<DateTime?> _initialGfeCharmBookletProvidedDate;
        public DateTime? InitialGfeCharmBookletProvidedDate { get { return _initialGfeCharmBookletProvidedDate; } set { _initialGfeCharmBookletProvidedDate = value; } }
        private Value<DateTime?> _initialGfeDisclosureProvidedDate;
        public DateTime? InitialGfeDisclosureProvidedDate { get { return _initialGfeDisclosureProvidedDate; } set { _initialGfeDisclosureProvidedDate = value; } }
        private Value<DateTime?> _initialGfeDisclosureReceivedDate;
        public DateTime? InitialGfeDisclosureReceivedDate { get { return _initialGfeDisclosureReceivedDate; } set { _initialGfeDisclosureReceivedDate = value; } }
        private Value<DateTime?> _initialGfeHelocBrochureProvidedDate;
        public DateTime? InitialGfeHelocBrochureProvidedDate { get { return _initialGfeHelocBrochureProvidedDate; } set { _initialGfeHelocBrochureProvidedDate = value; } }
        private Value<DateTime?> _initialGfeHudSpecialBookletProvidedDate;
        public DateTime? InitialGfeHudSpecialBookletProvidedDate { get { return _initialGfeHudSpecialBookletProvidedDate; } set { _initialGfeHudSpecialBookletProvidedDate = value; } }
        private Value<DateTime?> _initialSubsequentAppraisalProvidedDate;
        public DateTime? InitialSubsequentAppraisalProvidedDate { get { return _initialSubsequentAppraisalProvidedDate; } set { _initialSubsequentAppraisalProvidedDate = value; } }
        private Value<DateTime?> _initialTilDisclosureProvidedDate;
        public DateTime? InitialTilDisclosureProvidedDate { get { return _initialTilDisclosureProvidedDate; } set { _initialTilDisclosureProvidedDate = value; } }
        private Value<DateTime?> _initialTilDisclosureReceivedDate;
        public DateTime? InitialTilDisclosureReceivedDate { get { return _initialTilDisclosureReceivedDate; } set { _initialTilDisclosureReceivedDate = value; } }
        private Value<string> _insuranceRequiredDescription;
        public string InsuranceRequiredDescription { get { return _insuranceRequiredDescription; } set { _insuranceRequiredDescription = value; } }
        private Value<string> _interestInNameOf;
        public string InterestInNameOf { get { return _interestInNameOf; } set { _interestInNameOf = value; } }
        private Value<bool?> _interestOnly;
        public bool? InterestOnly { get { return _interestOnly; } set { _interestOnly = value; } }
        private Value<bool?> _interestOnlyIndicator;
        public bool? InterestOnlyIndicator { get { return _interestOnlyIndicator; } set { _interestOnlyIndicator = value; } }
        private Value<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private Value<string> _interestRateType;
        public string InterestRateType { get { return _interestRateType; } set { _interestRateType = value; } }
        private Value<decimal?> _interestReserveAmount;
        public decimal? InterestReserveAmount { get { return _interestReserveAmount; } set { _interestReserveAmount = value; } }
        private Value<string> _lastDisclosedBy;
        public string LastDisclosedBy { get { return _lastDisclosedBy; } set { _lastDisclosedBy = value; } }
        private Value<DateTime?> _lastDisclosedDate;
        public DateTime? LastDisclosedDate { get { return _lastDisclosedDate; } set { _lastDisclosedDate = value; } }
        private Value<DateTime?> _lastDisclosedGfeReceivedDate;
        public DateTime? LastDisclosedGfeReceivedDate { get { return _lastDisclosedGfeReceivedDate; } set { _lastDisclosedGfeReceivedDate = value; } }
        private Value<string> _lateChargeComments;
        public string LateChargeComments { get { return _lateChargeComments; } set { _lateChargeComments = value; } }
        private Value<int?> _lateChargeDays;
        public int? LateChargeDays { get { return _lateChargeDays; } set { _lateChargeDays = value; } }
        private Value<decimal?> _lateChargePercent;
        public decimal? LateChargePercent { get { return _lateChargePercent; } set { _lateChargePercent = value; } }
        private Value<string> _lateChargeType;
        public string LateChargeType { get { return _lateChargeType; } set { _lateChargeType = value; } }
        private Value<decimal?> _lateFee;
        public decimal? LateFee { get { return _lateFee; } set { _lateFee = value; } }
        private Value<string> _lEIntentToProceedComment;
        public string LEIntentToProceedComment { get { return _lEIntentToProceedComment; } set { _lEIntentToProceedComment = value; } }
        private Value<bool?> _lenderPaidMortgageInsuranceIndicator;
        public bool? LenderPaidMortgageInsuranceIndicator { get { return _lenderPaidMortgageInsuranceIndicator; } set { _lenderPaidMortgageInsuranceIndicator = value; } }
        private Value<decimal?> _lendersInspectionFee;
        public decimal? LendersInspectionFee { get { return _lendersInspectionFee; } set { _lendersInspectionFee = value; } }
        private Value<string> _lEReceivedBy;
        public string LEReceivedBy { get { return _lEReceivedBy; } set { _lEReceivedBy = value; } }
        private Value<string> _lEReceivedMethod;
        public string LEReceivedMethod { get { return _lEReceivedMethod; } set { _lEReceivedMethod = value; } }
        private Value<string> _lEReceivedMethodOther;
        public string LEReceivedMethodOther { get { return _lEReceivedMethodOther; } set { _lEReceivedMethodOther = value; } }
        private Value<DateTime?> _lESentOnDate;
        public DateTime? LESentOnDate { get { return _lESentOnDate; } set { _lESentOnDate = value; } }
        private Value<decimal?> _marginPlusIndexPercent;
        public decimal? MarginPlusIndexPercent { get { return _marginPlusIndexPercent; } set { _marginPlusIndexPercent = value; } }
        private Value<decimal?> _maximumLateCharge;
        public decimal? MaximumLateCharge { get { return _maximumLateCharge; } set { _maximumLateCharge = value; } }
        private Value<decimal?> _maximumPayment;
        public decimal? MaximumPayment { get { return _maximumPayment; } set { _maximumPayment = value; } }
        private Value<bool?> _meansAnEstimateIndicator;
        public bool? MeansAnEstimateIndicator { get { return _meansAnEstimateIndicator; } set { _meansAnEstimateIndicator = value; } }
        private Value<decimal?> _miAdjustmentFactorLevel2;
        public decimal? MiAdjustmentFactorLevel2 { get { return _miAdjustmentFactorLevel2; } set { _miAdjustmentFactorLevel2 = value; } }
        private Value<bool?> _miDecliningRenewalsIndicator;
        public bool? MiDecliningRenewalsIndicator { get { return _miDecliningRenewalsIndicator; } set { _miDecliningRenewalsIndicator = value; } }
        private Value<string> _midpointCancellation;
        public string MidpointCancellation { get { return _midpointCancellation; } set { _midpointCancellation = value; } }
        private Value<decimal?> _miMonthlyPaymentLevel1;
        public decimal? MiMonthlyPaymentLevel1 { get { return _miMonthlyPaymentLevel1; } set { _miMonthlyPaymentLevel1 = value; } }
        private Value<decimal?> _miMonthlyPaymentLevel2;
        public decimal? MiMonthlyPaymentLevel2 { get { return _miMonthlyPaymentLevel2; } set { _miMonthlyPaymentLevel2 = value; } }
        private Value<int?> _miMonthsOfAdjustmentLevel1;
        public int? MiMonthsOfAdjustmentLevel1 { get { return _miMonthsOfAdjustmentLevel1; } set { _miMonthsOfAdjustmentLevel1 = value; } }
        private Value<int?> _miMonthsOfAdjustmentLevel2;
        public int? MiMonthsOfAdjustmentLevel2 { get { return _miMonthsOfAdjustmentLevel2; } set { _miMonthsOfAdjustmentLevel2 = value; } }
        private Value<decimal?> _minimumLateCharge;
        public decimal? MinimumLateCharge { get { return _minimumLateCharge; } set { _minimumLateCharge = value; } }
        private Value<decimal?> _minimumPayment;
        public decimal? MinimumPayment { get { return _minimumPayment; } set { _minimumPayment = value; } }
        private Value<bool?> _mIPFactorLocked;
        public bool? MIPFactorLocked { get { return _mIPFactorLocked; } set { _mIPFactorLocked = value; } }
        private Value<decimal?> _mIPrepaidAmount;
        public decimal? MIPrepaidAmount { get { return _mIPrepaidAmount; } set { _mIPrepaidAmount = value; } }
        private Value<bool?> _miPrepaidIndicator;
        public bool? MiPrepaidIndicator { get { return _miPrepaidIndicator; } set { _miPrepaidIndicator = value; } }
        private Value<string> _miScheduledTerminationDate;
        public string MiScheduledTerminationDate { get { return _miScheduledTerminationDate; } set { _miScheduledTerminationDate = value; } }
        private Value<bool?> _mmiIndicator;
        public bool? MmiIndicator { get { return _mmiIndicator; } set { _mmiIndicator = value; } }
        private Value<decimal?> _monthlyTerm;
        public decimal? MonthlyTerm { get { return _monthlyTerm; } set { _monthlyTerm = value; } }
        private Value<int?> _monthsOfMiPrepaid;
        public int? MonthsOfMiPrepaid { get { return _monthsOfMiPrepaid; } set { _monthsOfMiPrepaid = value; } }
        private Value<decimal?> _mortgageInsuranceCancelPercent;
        public decimal? MortgageInsuranceCancelPercent { get { return _mortgageInsuranceCancelPercent; } set { _mortgageInsuranceCancelPercent = value; } }
        private Value<string> _namePreparedBy;
        public string NamePreparedBy { get { return _namePreparedBy; } set { _namePreparedBy = value; } }
        private Value<string> _newConstructionIndicator;
        public string NewConstructionIndicator { get { return _newConstructionIndicator; } set { _newConstructionIndicator = value; } }
        private Value<int?> _numberOfPayments;
        public int? NumberOfPayments { get { return _numberOfPayments; } set { _numberOfPayments = value; } }
        private Value<DateTime?> _occupancyCertDate;
        public DateTime? OccupancyCertDate { get { return _occupancyCertDate; } set { _occupancyCertDate = value; } }
        private Value<DateTime?> _originalContractDate;
        public DateTime? OriginalContractDate { get { return _originalContractDate; } set { _originalContractDate = value; } }
        private Value<decimal?> _outstandingBalance;
        public decimal? OutstandingBalance { get { return _outstandingBalance; } set { _outstandingBalance = value; } }
        private Value<string> _paymentFrequencyType;
        public string PaymentFrequencyType { get { return _paymentFrequencyType; } set { _paymentFrequencyType = value; } }
        private Value<decimal?> _paymentIncreasePercent;
        public decimal? PaymentIncreasePercent { get { return _paymentIncreasePercent; } set { _paymentIncreasePercent = value; } }
        private Value<string> _phonePreparedBy;
        public string PhonePreparedBy { get { return _phonePreparedBy; } set { _phonePreparedBy = value; } }
        private Value<bool?> _pmiIndicator;
        public bool? PmiIndicator { get { return _pmiIndicator; } set { _pmiIndicator = value; } }
        private Value<DateTime?> _pmiMidpointCancelationDate;
        public DateTime? PmiMidpointCancelationDate { get { return _pmiMidpointCancelationDate; } set { _pmiMidpointCancelationDate = value; } }
        private Value<DateTime?> _postConsummationDisclosureReceivedDate;
        public DateTime? PostConsummationDisclosureReceivedDate { get { return _postConsummationDisclosureReceivedDate; } set { _postConsummationDisclosureReceivedDate = value; } }
        private Value<DateTime?> _postConsummationDisclosureSentDate;
        public DateTime? PostConsummationDisclosureSentDate { get { return _postConsummationDisclosureSentDate; } set { _postConsummationDisclosureSentDate = value; } }
        private Value<decimal?> _prepaidFinanceCharge;
        public decimal? PrepaidFinanceCharge { get { return _prepaidFinanceCharge; } set { _prepaidFinanceCharge = value; } }
        private Value<bool?> _propertyInsuranceIndicator;
        public bool? PropertyInsuranceIndicator { get { return _propertyInsuranceIndicator; } set { _propertyInsuranceIndicator = value; } }
        private Value<DateTime?> _rateLockGfeDueDate;
        public DateTime? RateLockGfeDueDate { get { return _rateLockGfeDueDate; } set { _rateLockGfeDueDate = value; } }
        private Value<decimal?> _ratePercent;
        public decimal? RatePercent { get { return _ratePercent; } set { _ratePercent = value; } }
        private Value<int?> _recastPaidMonths;
        public int? RecastPaidMonths { get { return _recastPaidMonths; } set { _recastPaidMonths = value; } }
        private Value<int?> _recastStopMonths;
        public int? RecastStopMonths { get { return _recastStopMonths; } set { _recastStopMonths = value; } }
        private Value<bool?> _refundPaymentIndicator;
        public bool? RefundPaymentIndicator { get { return _refundPaymentIndicator; } set { _refundPaymentIndicator = value; } }
        private Value<bool?> _refundUnearnedMipIndicator;
        public bool? RefundUnearnedMipIndicator { get { return _refundUnearnedMipIndicator; } set { _refundUnearnedMipIndicator = value; } }
        private Value<List<RegulationZInterestRatePeriod>> _regulationZInterestRatePeriods;
        public List<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get { return _regulationZInterestRatePeriods; } set { _regulationZInterestRatePeriods = value; } }
        private Value<List<RegulationZPayment>> _regulationZPayments;
        public List<RegulationZPayment> RegulationZPayments { get { return _regulationZPayments; } set { _regulationZPayments = value; } }
        private Value<string> _regzTableType;
        public string RegzTableType { get { return _regzTableType; } set { _regzTableType = value; } }
        private Value<bool?> _requiredDepositIndicator;
        public bool? RequiredDepositIndicator { get { return _requiredDepositIndicator; } set { _requiredDepositIndicator = value; } }
        private Value<DateTime?> _revisedClosingDisclosureReceivedDate;
        public DateTime? RevisedClosingDisclosureReceivedDate { get { return _revisedClosingDisclosureReceivedDate; } set { _revisedClosingDisclosureReceivedDate = value; } }
        private Value<DateTime?> _revisedClosingDisclosureSentDate;
        public DateTime? RevisedClosingDisclosureSentDate { get { return _revisedClosingDisclosureSentDate; } set { _revisedClosingDisclosureSentDate = value; } }
        private Value<DateTime?> _revisedGfeDueDate;
        public DateTime? RevisedGfeDueDate { get { return _revisedGfeDueDate; } set { _revisedGfeDueDate = value; } }
        private Value<decimal?> _roundedMarginPlusIndexPercent;
        public decimal? RoundedMarginPlusIndexPercent { get { return _roundedMarginPlusIndexPercent; } set { _roundedMarginPlusIndexPercent = value; } }
        private Value<DateTime?> _safeHarborSentDate;
        public DateTime? SafeHarborSentDate { get { return _safeHarborSentDate; } set { _safeHarborSentDate = value; } }
        private Value<decimal?> _samplePayments;
        public decimal? SamplePayments { get { return _samplePayments; } set { _samplePayments = value; } }
        private Value<string> _securityType;
        public string SecurityType { get { return _securityType; } set { _securityType = value; } }
        private Value<DateTime?> _sSPLSentDate;
        public DateTime? SSPLSentDate { get { return _sSPLSentDate; } set { _sSPLSentDate = value; } }
        private Value<DateTime?> _tilDate;
        public DateTime? TilDate { get { return _tilDate; } set { _tilDate = value; } }
        private Value<string> _tilDisclosedComments;
        public string TilDisclosedComments { get { return _tilDisclosedComments; } set { _tilDisclosedComments = value; } }
        private Value<string> _tilDisclosureMethod;
        public string TilDisclosureMethod { get { return _tilDisclosureMethod; } set { _tilDisclosureMethod = value; } }
        private Value<DateTime?> _tilLastDisclosedBorrowerReceivedDate;
        public DateTime? TilLastDisclosedBorrowerReceivedDate { get { return _tilLastDisclosedBorrowerReceivedDate; } set { _tilLastDisclosedBorrowerReceivedDate = value; } }
        private Value<string> _tilLastDisclosedBy;
        public string TilLastDisclosedBy { get { return _tilLastDisclosedBy; } set { _tilLastDisclosedBy = value; } }
        private Value<DateTime?> _tilLastDisclosedDate;
        public DateTime? TilLastDisclosedDate { get { return _tilLastDisclosedDate; } set { _tilLastDisclosedDate = value; } }
        private Value<DateTime?> _tilRedisclosureProvidedDate;
        public DateTime? TilRedisclosureProvidedDate { get { return _tilRedisclosureProvidedDate; } set { _tilRedisclosureProvidedDate = value; } }
        private Value<DateTime?> _tilRedisclosureReceivedDate;
        public DateTime? TilRedisclosureReceivedDate { get { return _tilRedisclosureReceivedDate; } set { _tilRedisclosureReceivedDate = value; } }
        private Value<decimal?> _totalBrokerFees;
        public decimal? TotalBrokerFees { get { return _totalBrokerFees; } set { _totalBrokerFees = value; } }
        private Value<decimal?> _totalLatePayment;
        public decimal? TotalLatePayment { get { return _totalLatePayment; } set { _totalLatePayment = value; } }
        private Value<decimal?> _totalLenderFees;
        public decimal? TotalLenderFees { get { return _totalLenderFees; } set { _totalLenderFees = value; } }
        private Value<decimal?> _totalOfPayments;
        public decimal? TotalOfPayments { get { return _totalOfPayments; } set { _totalOfPayments = value; } }
        private Value<decimal?> _totalOfPrincipalAndInterest;
        public decimal? TotalOfPrincipalAndInterest { get { return _totalOfPrincipalAndInterest; } set { _totalOfPrincipalAndInterest = value; } }
        private Value<bool?> _useCustomLenderProfile;
        public bool? UseCustomLenderProfile { get { return _useCustomLenderProfile; } set { _useCustomLenderProfile = value; } }
        private Value<string> _useDaysInYears;
        public string UseDaysInYears { get { return _useDaysInYears; } set { _useDaysInYears = value; } }
        private Value<bool?> _usePitiForRatioIndicator;
        public bool? UsePitiForRatioIndicator { get { return _usePitiForRatioIndicator; } set { _usePitiForRatioIndicator = value; } }
        private Value<bool?> _variableRateFeatureIndicator;
        public bool? VariableRateFeatureIndicator { get { return _variableRateFeatureIndicator; } set { _variableRateFeatureIndicator = value; } }
        private Value<decimal?> _yearlyTerm;
        public decimal? YearlyTerm { get { return _yearlyTerm; } set { _yearlyTerm = value; } }
        private Value<string> _yearOfMaximumPayment;
        public string YearOfMaximumPayment { get { return _yearOfMaximumPayment; } set { _yearOfMaximumPayment = value; } }
        private Value<int?> _years;
        public int? Years { get { return _years; } set { _years = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acknowledgedDay.Clean
                    && _acknowledgedMonth.Clean
                    && _acknowledgedYear.Clean
                    && _acquisition.Clean
                    && _additionalArmInformation.Clean
                    && _allDateAndNumericalDisclosuresIndicator.Clean
                    && _amountFinanced.Clean
                    && _aprPercent.Clean
                    && _armDisclosureDescription.Clean
                    && _assumptionOnYourProperty.Clean
                    && _borrowerIntendToContinueDate.Clean
                    && _borrowerIntendToContinueIndicator.Clean
                    && _borrowerMiTerminationDate.Clean
                    && _calculateBasedOnRemainingBalance.Clean
                    && _chargesAddedToPaymentsIndicator.Clean
                    && _chargesAtLoanClosingIndicator.Clean
                    && _circumstanceChangeReason.Clean
                    && _circumstanceChangeReceivedDate.Clean
                    && _closingDisclosureReceivedDate.Clean
                    && _closingDisclosureSentDate.Clean
                    && _constructionFirstIntChangeAdjType.Clean
                    && _constructionLoanDescription.Clean
                    && _constructionLoanMethod.Clean
                    && _constructionPeriodMonths.Clean
                    && _constructionRatePercent.Clean
                    && _constructionRefinanceIndicator.Clean
                    && _creditDisability.Clean
                    && _creditDisabilityIndicator.Clean
                    && _creditLife.Clean
                    && _creditLifeAndCreditDisability.Clean
                    && _creditLifeInsuranceIndicator.Clean
                    && _customizePaymentScheduleIndicator.Clean
                    && _demandFeatureIndicator.Clean
                    && _disclosedAprPercent.Clean
                    && _disclosedByBrokerIndicator.Clean
                    && _disclosedComments.Clean
                    && _disclosedDailyInterestCharge.Clean
                    && _disclosedFinanceCharge.Clean
                    && _disclosedPrepayment.Clean
                    && _disclosedProduct.Clean
                    && _disclosureMethod.Clean
                    && _disclosureType.Clean
                    && _discountPeriod.Clean
                    && _discountRatePercent.Clean
                    && _discountType.Clean
                    && _dueDate.Clean
                    && _earliestClosingDate.Clean
                    && _earliestFeeCollectionDate.Clean
                    && _eSignConsentBorrowerDateAccepted1.Clean
                    && _eSignConsentBorrowerDateAccepted2.Clean
                    && _eSignConsentBorrowerDateAccepted3.Clean
                    && _eSignConsentBorrowerDateAccepted4.Clean
                    && _eSignConsentBorrowerDateAccepted5.Clean
                    && _eSignConsentBorrowerDateAccepted6.Clean
                    && _eSignConsentBorrowerIPAddress1.Clean
                    && _eSignConsentBorrowerIPAddress2.Clean
                    && _eSignConsentBorrowerIPAddress3.Clean
                    && _eSignConsentBorrowerIPAddress4.Clean
                    && _eSignConsentBorrowerIPAddress5.Clean
                    && _eSignConsentBorrowerIPAddress6.Clean
                    && _eSignConsentBorrowerSource1.Clean
                    && _eSignConsentBorrowerSource2.Clean
                    && _eSignConsentBorrowerSource3.Clean
                    && _eSignConsentBorrowerSource4.Clean
                    && _eSignConsentBorrowerSource5.Clean
                    && _eSignConsentBorrowerSource6.Clean
                    && _eSignConsentBorrowerStatus1.Clean
                    && _eSignConsentBorrowerStatus2.Clean
                    && _eSignConsentBorrowerStatus3.Clean
                    && _eSignConsentBorrowerStatus4.Clean
                    && _eSignConsentBorrowerStatus5.Clean
                    && _eSignConsentBorrowerStatus6.Clean
                    && _eSignConsentCoBorrowerDateAccepted1.Clean
                    && _eSignConsentCoBorrowerDateAccepted2.Clean
                    && _eSignConsentCoBorrowerDateAccepted3.Clean
                    && _eSignConsentCoBorrowerDateAccepted4.Clean
                    && _eSignConsentCoBorrowerDateAccepted5.Clean
                    && _eSignConsentCoBorrowerDateAccepted6.Clean
                    && _eSignConsentCoBorrowerIPAddress1.Clean
                    && _eSignConsentCoBorrowerIPAddress2.Clean
                    && _eSignConsentCoBorrowerIPAddress3.Clean
                    && _eSignConsentCoBorrowerIPAddress4.Clean
                    && _eSignConsentCoBorrowerIPAddress5.Clean
                    && _eSignConsentCoBorrowerIPAddress6.Clean
                    && _eSignConsentCoBorrowerSource1.Clean
                    && _eSignConsentCoBorrowerSource2.Clean
                    && _eSignConsentCoBorrowerSource3.Clean
                    && _eSignConsentCoBorrowerSource4.Clean
                    && _eSignConsentCoBorrowerSource5.Clean
                    && _eSignConsentCoBorrowerSource6.Clean
                    && _eSignConsentCoBorrowerStatus1.Clean
                    && _eSignConsentCoBorrowerStatus2.Clean
                    && _eSignConsentCoBorrowerStatus3.Clean
                    && _eSignConsentCoBorrowerStatus4.Clean
                    && _eSignConsentCoBorrowerStatus5.Clean
                    && _eSignConsentCoBorrowerStatus6.Clean
                    && _eSignConsentDate.Clean
                    && _extraPaymentForEarlyPayOff.Clean
                    && _feeCollectedDate.Clean
                    && _filingFees.Clean
                    && _finalPaymentDate.Clean
                    && _financeCharge.Clean
                    && _financedAllGuaranteeFeeAmount.Clean
                    && _financedAllGuaranteeFeePercent.Clean
                    && _financedAllTotalLoanAmount.Clean
                    && _financedPortionGuaranteeFeeAmount.Clean
                    && _financedPortionGuaranteeFeePercent.Clean
                    && _financedPortionTotalLoanAmount.Clean
                    && _financingType.Clean
                    && _firstAmortizationPaymentDate.Clean
                    && _floodInsuranceIndicator.Clean
                    && _gfeApplicationDate.Clean
                    && _gfeChangedCircumstanceIndicator.Clean
                    && _gfeChangedCircumstanceItem.Clean
                    && _gFEChangedCirsumstanceItemCode.Clean
                    && _gfeDate.Clean
                    && _gfeExpirationDate.Clean
                    && _gfeExpirationPeriod.Clean
                    && _gfeRateLockRedisclosureRequiredIndicator.Clean
                    && _gfeRedisclosureProvidedDate.Clean
                    && _gfeRedisclosureReceivedDate.Clean
                    && _highCostDisclosure.Clean
                    && _homeCounselingProvidedDate.Clean
                    && _hud1ToleranceViolatedIndicator.Clean
                    && _hudToleranceResolutionComments.Clean
                    && _hudToleranceResolutionDate.Clean
                    && _hudToleranceResolvedBy.Clean
                    && _id.Clean
                    && _ifYouPurchaseIndicator.Clean
                    && _ifYouPurchaseType.Clean
                    && _includeMiIndicator.Clean
                    && _includePmiIndicator.Clean
                    && _includeTaxesInsuranceIndicator.Clean
                    && _initialAVMProvidedDate.Clean
                    && _initialDisclosureDueDate.Clean
                    && _initialDisclosureProvidedDate.Clean
                    && _initialGfeAffiliatedBusinessProvidedDate.Clean
                    && _initialGFEAppraisalProvidedDate.Clean
                    && _initialGfeCharmBookletProvidedDate.Clean
                    && _initialGfeDisclosureProvidedDate.Clean
                    && _initialGfeDisclosureReceivedDate.Clean
                    && _initialGfeHelocBrochureProvidedDate.Clean
                    && _initialGfeHudSpecialBookletProvidedDate.Clean
                    && _initialSubsequentAppraisalProvidedDate.Clean
                    && _initialTilDisclosureProvidedDate.Clean
                    && _initialTilDisclosureReceivedDate.Clean
                    && _insuranceRequiredDescription.Clean
                    && _interestInNameOf.Clean
                    && _interestOnly.Clean
                    && _interestOnlyIndicator.Clean
                    && _interestOnlyMonths.Clean
                    && _interestRateType.Clean
                    && _interestReserveAmount.Clean
                    && _lastDisclosedBy.Clean
                    && _lastDisclosedDate.Clean
                    && _lastDisclosedGfeReceivedDate.Clean
                    && _lateChargeComments.Clean
                    && _lateChargeDays.Clean
                    && _lateChargePercent.Clean
                    && _lateChargeType.Clean
                    && _lateFee.Clean
                    && _lEIntentToProceedComment.Clean
                    && _lenderPaidMortgageInsuranceIndicator.Clean
                    && _lendersInspectionFee.Clean
                    && _lEReceivedBy.Clean
                    && _lEReceivedMethod.Clean
                    && _lEReceivedMethodOther.Clean
                    && _lESentOnDate.Clean
                    && _marginPlusIndexPercent.Clean
                    && _maximumLateCharge.Clean
                    && _maximumPayment.Clean
                    && _meansAnEstimateIndicator.Clean
                    && _miAdjustmentFactorLevel2.Clean
                    && _miDecliningRenewalsIndicator.Clean
                    && _midpointCancellation.Clean
                    && _miMonthlyPaymentLevel1.Clean
                    && _miMonthlyPaymentLevel2.Clean
                    && _miMonthsOfAdjustmentLevel1.Clean
                    && _miMonthsOfAdjustmentLevel2.Clean
                    && _minimumLateCharge.Clean
                    && _minimumPayment.Clean
                    && _mIPFactorLocked.Clean
                    && _mIPrepaidAmount.Clean
                    && _miPrepaidIndicator.Clean
                    && _miScheduledTerminationDate.Clean
                    && _mmiIndicator.Clean
                    && _monthlyTerm.Clean
                    && _monthsOfMiPrepaid.Clean
                    && _mortgageInsuranceCancelPercent.Clean
                    && _namePreparedBy.Clean
                    && _newConstructionIndicator.Clean
                    && _numberOfPayments.Clean
                    && _occupancyCertDate.Clean
                    && _originalContractDate.Clean
                    && _outstandingBalance.Clean
                    && _paymentFrequencyType.Clean
                    && _paymentIncreasePercent.Clean
                    && _phonePreparedBy.Clean
                    && _pmiIndicator.Clean
                    && _pmiMidpointCancelationDate.Clean
                    && _postConsummationDisclosureReceivedDate.Clean
                    && _postConsummationDisclosureSentDate.Clean
                    && _prepaidFinanceCharge.Clean
                    && _propertyInsuranceIndicator.Clean
                    && _rateLockGfeDueDate.Clean
                    && _ratePercent.Clean
                    && _recastPaidMonths.Clean
                    && _recastStopMonths.Clean
                    && _refundPaymentIndicator.Clean
                    && _refundUnearnedMipIndicator.Clean
                    && _regulationZInterestRatePeriods.Clean
                    && _regulationZPayments.Clean
                    && _regzTableType.Clean
                    && _requiredDepositIndicator.Clean
                    && _revisedClosingDisclosureReceivedDate.Clean
                    && _revisedClosingDisclosureSentDate.Clean
                    && _revisedGfeDueDate.Clean
                    && _roundedMarginPlusIndexPercent.Clean
                    && _safeHarborSentDate.Clean
                    && _samplePayments.Clean
                    && _securityType.Clean
                    && _sSPLSentDate.Clean
                    && _tilDate.Clean
                    && _tilDisclosedComments.Clean
                    && _tilDisclosureMethod.Clean
                    && _tilLastDisclosedBorrowerReceivedDate.Clean
                    && _tilLastDisclosedBy.Clean
                    && _tilLastDisclosedDate.Clean
                    && _tilRedisclosureProvidedDate.Clean
                    && _tilRedisclosureReceivedDate.Clean
                    && _totalBrokerFees.Clean
                    && _totalLatePayment.Clean
                    && _totalLenderFees.Clean
                    && _totalOfPayments.Clean
                    && _totalOfPrincipalAndInterest.Clean
                    && _useCustomLenderProfile.Clean
                    && _useDaysInYears.Clean
                    && _usePitiForRatioIndicator.Clean
                    && _variableRateFeatureIndicator.Clean
                    && _yearlyTerm.Clean
                    && _yearOfMaximumPayment.Clean
                    && _years.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _acknowledgedDay; v0.Clean = value; _acknowledgedDay = v0;
                var v1 = _acknowledgedMonth; v1.Clean = value; _acknowledgedMonth = v1;
                var v2 = _acknowledgedYear; v2.Clean = value; _acknowledgedYear = v2;
                var v3 = _acquisition; v3.Clean = value; _acquisition = v3;
                var v4 = _additionalArmInformation; v4.Clean = value; _additionalArmInformation = v4;
                var v5 = _allDateAndNumericalDisclosuresIndicator; v5.Clean = value; _allDateAndNumericalDisclosuresIndicator = v5;
                var v6 = _amountFinanced; v6.Clean = value; _amountFinanced = v6;
                var v7 = _aprPercent; v7.Clean = value; _aprPercent = v7;
                var v8 = _armDisclosureDescription; v8.Clean = value; _armDisclosureDescription = v8;
                var v9 = _assumptionOnYourProperty; v9.Clean = value; _assumptionOnYourProperty = v9;
                var v10 = _borrowerIntendToContinueDate; v10.Clean = value; _borrowerIntendToContinueDate = v10;
                var v11 = _borrowerIntendToContinueIndicator; v11.Clean = value; _borrowerIntendToContinueIndicator = v11;
                var v12 = _borrowerMiTerminationDate; v12.Clean = value; _borrowerMiTerminationDate = v12;
                var v13 = _calculateBasedOnRemainingBalance; v13.Clean = value; _calculateBasedOnRemainingBalance = v13;
                var v14 = _chargesAddedToPaymentsIndicator; v14.Clean = value; _chargesAddedToPaymentsIndicator = v14;
                var v15 = _chargesAtLoanClosingIndicator; v15.Clean = value; _chargesAtLoanClosingIndicator = v15;
                var v16 = _circumstanceChangeReason; v16.Clean = value; _circumstanceChangeReason = v16;
                var v17 = _circumstanceChangeReceivedDate; v17.Clean = value; _circumstanceChangeReceivedDate = v17;
                var v18 = _closingDisclosureReceivedDate; v18.Clean = value; _closingDisclosureReceivedDate = v18;
                var v19 = _closingDisclosureSentDate; v19.Clean = value; _closingDisclosureSentDate = v19;
                var v20 = _constructionFirstIntChangeAdjType; v20.Clean = value; _constructionFirstIntChangeAdjType = v20;
                var v21 = _constructionLoanDescription; v21.Clean = value; _constructionLoanDescription = v21;
                var v22 = _constructionLoanMethod; v22.Clean = value; _constructionLoanMethod = v22;
                var v23 = _constructionPeriodMonths; v23.Clean = value; _constructionPeriodMonths = v23;
                var v24 = _constructionRatePercent; v24.Clean = value; _constructionRatePercent = v24;
                var v25 = _constructionRefinanceIndicator; v25.Clean = value; _constructionRefinanceIndicator = v25;
                var v26 = _creditDisability; v26.Clean = value; _creditDisability = v26;
                var v27 = _creditDisabilityIndicator; v27.Clean = value; _creditDisabilityIndicator = v27;
                var v28 = _creditLife; v28.Clean = value; _creditLife = v28;
                var v29 = _creditLifeAndCreditDisability; v29.Clean = value; _creditLifeAndCreditDisability = v29;
                var v30 = _creditLifeInsuranceIndicator; v30.Clean = value; _creditLifeInsuranceIndicator = v30;
                var v31 = _customizePaymentScheduleIndicator; v31.Clean = value; _customizePaymentScheduleIndicator = v31;
                var v32 = _demandFeatureIndicator; v32.Clean = value; _demandFeatureIndicator = v32;
                var v33 = _disclosedAprPercent; v33.Clean = value; _disclosedAprPercent = v33;
                var v34 = _disclosedByBrokerIndicator; v34.Clean = value; _disclosedByBrokerIndicator = v34;
                var v35 = _disclosedComments; v35.Clean = value; _disclosedComments = v35;
                var v36 = _disclosedDailyInterestCharge; v36.Clean = value; _disclosedDailyInterestCharge = v36;
                var v37 = _disclosedFinanceCharge; v37.Clean = value; _disclosedFinanceCharge = v37;
                var v38 = _disclosedPrepayment; v38.Clean = value; _disclosedPrepayment = v38;
                var v39 = _disclosedProduct; v39.Clean = value; _disclosedProduct = v39;
                var v40 = _disclosureMethod; v40.Clean = value; _disclosureMethod = v40;
                var v41 = _disclosureType; v41.Clean = value; _disclosureType = v41;
                var v42 = _discountPeriod; v42.Clean = value; _discountPeriod = v42;
                var v43 = _discountRatePercent; v43.Clean = value; _discountRatePercent = v43;
                var v44 = _discountType; v44.Clean = value; _discountType = v44;
                var v45 = _dueDate; v45.Clean = value; _dueDate = v45;
                var v46 = _earliestClosingDate; v46.Clean = value; _earliestClosingDate = v46;
                var v47 = _earliestFeeCollectionDate; v47.Clean = value; _earliestFeeCollectionDate = v47;
                var v48 = _eSignConsentBorrowerDateAccepted1; v48.Clean = value; _eSignConsentBorrowerDateAccepted1 = v48;
                var v49 = _eSignConsentBorrowerDateAccepted2; v49.Clean = value; _eSignConsentBorrowerDateAccepted2 = v49;
                var v50 = _eSignConsentBorrowerDateAccepted3; v50.Clean = value; _eSignConsentBorrowerDateAccepted3 = v50;
                var v51 = _eSignConsentBorrowerDateAccepted4; v51.Clean = value; _eSignConsentBorrowerDateAccepted4 = v51;
                var v52 = _eSignConsentBorrowerDateAccepted5; v52.Clean = value; _eSignConsentBorrowerDateAccepted5 = v52;
                var v53 = _eSignConsentBorrowerDateAccepted6; v53.Clean = value; _eSignConsentBorrowerDateAccepted6 = v53;
                var v54 = _eSignConsentBorrowerIPAddress1; v54.Clean = value; _eSignConsentBorrowerIPAddress1 = v54;
                var v55 = _eSignConsentBorrowerIPAddress2; v55.Clean = value; _eSignConsentBorrowerIPAddress2 = v55;
                var v56 = _eSignConsentBorrowerIPAddress3; v56.Clean = value; _eSignConsentBorrowerIPAddress3 = v56;
                var v57 = _eSignConsentBorrowerIPAddress4; v57.Clean = value; _eSignConsentBorrowerIPAddress4 = v57;
                var v58 = _eSignConsentBorrowerIPAddress5; v58.Clean = value; _eSignConsentBorrowerIPAddress5 = v58;
                var v59 = _eSignConsentBorrowerIPAddress6; v59.Clean = value; _eSignConsentBorrowerIPAddress6 = v59;
                var v60 = _eSignConsentBorrowerSource1; v60.Clean = value; _eSignConsentBorrowerSource1 = v60;
                var v61 = _eSignConsentBorrowerSource2; v61.Clean = value; _eSignConsentBorrowerSource2 = v61;
                var v62 = _eSignConsentBorrowerSource3; v62.Clean = value; _eSignConsentBorrowerSource3 = v62;
                var v63 = _eSignConsentBorrowerSource4; v63.Clean = value; _eSignConsentBorrowerSource4 = v63;
                var v64 = _eSignConsentBorrowerSource5; v64.Clean = value; _eSignConsentBorrowerSource5 = v64;
                var v65 = _eSignConsentBorrowerSource6; v65.Clean = value; _eSignConsentBorrowerSource6 = v65;
                var v66 = _eSignConsentBorrowerStatus1; v66.Clean = value; _eSignConsentBorrowerStatus1 = v66;
                var v67 = _eSignConsentBorrowerStatus2; v67.Clean = value; _eSignConsentBorrowerStatus2 = v67;
                var v68 = _eSignConsentBorrowerStatus3; v68.Clean = value; _eSignConsentBorrowerStatus3 = v68;
                var v69 = _eSignConsentBorrowerStatus4; v69.Clean = value; _eSignConsentBorrowerStatus4 = v69;
                var v70 = _eSignConsentBorrowerStatus5; v70.Clean = value; _eSignConsentBorrowerStatus5 = v70;
                var v71 = _eSignConsentBorrowerStatus6; v71.Clean = value; _eSignConsentBorrowerStatus6 = v71;
                var v72 = _eSignConsentCoBorrowerDateAccepted1; v72.Clean = value; _eSignConsentCoBorrowerDateAccepted1 = v72;
                var v73 = _eSignConsentCoBorrowerDateAccepted2; v73.Clean = value; _eSignConsentCoBorrowerDateAccepted2 = v73;
                var v74 = _eSignConsentCoBorrowerDateAccepted3; v74.Clean = value; _eSignConsentCoBorrowerDateAccepted3 = v74;
                var v75 = _eSignConsentCoBorrowerDateAccepted4; v75.Clean = value; _eSignConsentCoBorrowerDateAccepted4 = v75;
                var v76 = _eSignConsentCoBorrowerDateAccepted5; v76.Clean = value; _eSignConsentCoBorrowerDateAccepted5 = v76;
                var v77 = _eSignConsentCoBorrowerDateAccepted6; v77.Clean = value; _eSignConsentCoBorrowerDateAccepted6 = v77;
                var v78 = _eSignConsentCoBorrowerIPAddress1; v78.Clean = value; _eSignConsentCoBorrowerIPAddress1 = v78;
                var v79 = _eSignConsentCoBorrowerIPAddress2; v79.Clean = value; _eSignConsentCoBorrowerIPAddress2 = v79;
                var v80 = _eSignConsentCoBorrowerIPAddress3; v80.Clean = value; _eSignConsentCoBorrowerIPAddress3 = v80;
                var v81 = _eSignConsentCoBorrowerIPAddress4; v81.Clean = value; _eSignConsentCoBorrowerIPAddress4 = v81;
                var v82 = _eSignConsentCoBorrowerIPAddress5; v82.Clean = value; _eSignConsentCoBorrowerIPAddress5 = v82;
                var v83 = _eSignConsentCoBorrowerIPAddress6; v83.Clean = value; _eSignConsentCoBorrowerIPAddress6 = v83;
                var v84 = _eSignConsentCoBorrowerSource1; v84.Clean = value; _eSignConsentCoBorrowerSource1 = v84;
                var v85 = _eSignConsentCoBorrowerSource2; v85.Clean = value; _eSignConsentCoBorrowerSource2 = v85;
                var v86 = _eSignConsentCoBorrowerSource3; v86.Clean = value; _eSignConsentCoBorrowerSource3 = v86;
                var v87 = _eSignConsentCoBorrowerSource4; v87.Clean = value; _eSignConsentCoBorrowerSource4 = v87;
                var v88 = _eSignConsentCoBorrowerSource5; v88.Clean = value; _eSignConsentCoBorrowerSource5 = v88;
                var v89 = _eSignConsentCoBorrowerSource6; v89.Clean = value; _eSignConsentCoBorrowerSource6 = v89;
                var v90 = _eSignConsentCoBorrowerStatus1; v90.Clean = value; _eSignConsentCoBorrowerStatus1 = v90;
                var v91 = _eSignConsentCoBorrowerStatus2; v91.Clean = value; _eSignConsentCoBorrowerStatus2 = v91;
                var v92 = _eSignConsentCoBorrowerStatus3; v92.Clean = value; _eSignConsentCoBorrowerStatus3 = v92;
                var v93 = _eSignConsentCoBorrowerStatus4; v93.Clean = value; _eSignConsentCoBorrowerStatus4 = v93;
                var v94 = _eSignConsentCoBorrowerStatus5; v94.Clean = value; _eSignConsentCoBorrowerStatus5 = v94;
                var v95 = _eSignConsentCoBorrowerStatus6; v95.Clean = value; _eSignConsentCoBorrowerStatus6 = v95;
                var v96 = _eSignConsentDate; v96.Clean = value; _eSignConsentDate = v96;
                var v97 = _extraPaymentForEarlyPayOff; v97.Clean = value; _extraPaymentForEarlyPayOff = v97;
                var v98 = _feeCollectedDate; v98.Clean = value; _feeCollectedDate = v98;
                var v99 = _filingFees; v99.Clean = value; _filingFees = v99;
                var v100 = _finalPaymentDate; v100.Clean = value; _finalPaymentDate = v100;
                var v101 = _financeCharge; v101.Clean = value; _financeCharge = v101;
                var v102 = _financedAllGuaranteeFeeAmount; v102.Clean = value; _financedAllGuaranteeFeeAmount = v102;
                var v103 = _financedAllGuaranteeFeePercent; v103.Clean = value; _financedAllGuaranteeFeePercent = v103;
                var v104 = _financedAllTotalLoanAmount; v104.Clean = value; _financedAllTotalLoanAmount = v104;
                var v105 = _financedPortionGuaranteeFeeAmount; v105.Clean = value; _financedPortionGuaranteeFeeAmount = v105;
                var v106 = _financedPortionGuaranteeFeePercent; v106.Clean = value; _financedPortionGuaranteeFeePercent = v106;
                var v107 = _financedPortionTotalLoanAmount; v107.Clean = value; _financedPortionTotalLoanAmount = v107;
                var v108 = _financingType; v108.Clean = value; _financingType = v108;
                var v109 = _firstAmortizationPaymentDate; v109.Clean = value; _firstAmortizationPaymentDate = v109;
                var v110 = _floodInsuranceIndicator; v110.Clean = value; _floodInsuranceIndicator = v110;
                var v111 = _gfeApplicationDate; v111.Clean = value; _gfeApplicationDate = v111;
                var v112 = _gfeChangedCircumstanceIndicator; v112.Clean = value; _gfeChangedCircumstanceIndicator = v112;
                var v113 = _gfeChangedCircumstanceItem; v113.Clean = value; _gfeChangedCircumstanceItem = v113;
                var v114 = _gFEChangedCirsumstanceItemCode; v114.Clean = value; _gFEChangedCirsumstanceItemCode = v114;
                var v115 = _gfeDate; v115.Clean = value; _gfeDate = v115;
                var v116 = _gfeExpirationDate; v116.Clean = value; _gfeExpirationDate = v116;
                var v117 = _gfeExpirationPeriod; v117.Clean = value; _gfeExpirationPeriod = v117;
                var v118 = _gfeRateLockRedisclosureRequiredIndicator; v118.Clean = value; _gfeRateLockRedisclosureRequiredIndicator = v118;
                var v119 = _gfeRedisclosureProvidedDate; v119.Clean = value; _gfeRedisclosureProvidedDate = v119;
                var v120 = _gfeRedisclosureReceivedDate; v120.Clean = value; _gfeRedisclosureReceivedDate = v120;
                var v121 = _highCostDisclosure; v121.Clean = value; _highCostDisclosure = v121;
                var v122 = _homeCounselingProvidedDate; v122.Clean = value; _homeCounselingProvidedDate = v122;
                var v123 = _hud1ToleranceViolatedIndicator; v123.Clean = value; _hud1ToleranceViolatedIndicator = v123;
                var v124 = _hudToleranceResolutionComments; v124.Clean = value; _hudToleranceResolutionComments = v124;
                var v125 = _hudToleranceResolutionDate; v125.Clean = value; _hudToleranceResolutionDate = v125;
                var v126 = _hudToleranceResolvedBy; v126.Clean = value; _hudToleranceResolvedBy = v126;
                var v127 = _id; v127.Clean = value; _id = v127;
                var v128 = _ifYouPurchaseIndicator; v128.Clean = value; _ifYouPurchaseIndicator = v128;
                var v129 = _ifYouPurchaseType; v129.Clean = value; _ifYouPurchaseType = v129;
                var v130 = _includeMiIndicator; v130.Clean = value; _includeMiIndicator = v130;
                var v131 = _includePmiIndicator; v131.Clean = value; _includePmiIndicator = v131;
                var v132 = _includeTaxesInsuranceIndicator; v132.Clean = value; _includeTaxesInsuranceIndicator = v132;
                var v133 = _initialAVMProvidedDate; v133.Clean = value; _initialAVMProvidedDate = v133;
                var v134 = _initialDisclosureDueDate; v134.Clean = value; _initialDisclosureDueDate = v134;
                var v135 = _initialDisclosureProvidedDate; v135.Clean = value; _initialDisclosureProvidedDate = v135;
                var v136 = _initialGfeAffiliatedBusinessProvidedDate; v136.Clean = value; _initialGfeAffiliatedBusinessProvidedDate = v136;
                var v137 = _initialGFEAppraisalProvidedDate; v137.Clean = value; _initialGFEAppraisalProvidedDate = v137;
                var v138 = _initialGfeCharmBookletProvidedDate; v138.Clean = value; _initialGfeCharmBookletProvidedDate = v138;
                var v139 = _initialGfeDisclosureProvidedDate; v139.Clean = value; _initialGfeDisclosureProvidedDate = v139;
                var v140 = _initialGfeDisclosureReceivedDate; v140.Clean = value; _initialGfeDisclosureReceivedDate = v140;
                var v141 = _initialGfeHelocBrochureProvidedDate; v141.Clean = value; _initialGfeHelocBrochureProvidedDate = v141;
                var v142 = _initialGfeHudSpecialBookletProvidedDate; v142.Clean = value; _initialGfeHudSpecialBookletProvidedDate = v142;
                var v143 = _initialSubsequentAppraisalProvidedDate; v143.Clean = value; _initialSubsequentAppraisalProvidedDate = v143;
                var v144 = _initialTilDisclosureProvidedDate; v144.Clean = value; _initialTilDisclosureProvidedDate = v144;
                var v145 = _initialTilDisclosureReceivedDate; v145.Clean = value; _initialTilDisclosureReceivedDate = v145;
                var v146 = _insuranceRequiredDescription; v146.Clean = value; _insuranceRequiredDescription = v146;
                var v147 = _interestInNameOf; v147.Clean = value; _interestInNameOf = v147;
                var v148 = _interestOnly; v148.Clean = value; _interestOnly = v148;
                var v149 = _interestOnlyIndicator; v149.Clean = value; _interestOnlyIndicator = v149;
                var v150 = _interestOnlyMonths; v150.Clean = value; _interestOnlyMonths = v150;
                var v151 = _interestRateType; v151.Clean = value; _interestRateType = v151;
                var v152 = _interestReserveAmount; v152.Clean = value; _interestReserveAmount = v152;
                var v153 = _lastDisclosedBy; v153.Clean = value; _lastDisclosedBy = v153;
                var v154 = _lastDisclosedDate; v154.Clean = value; _lastDisclosedDate = v154;
                var v155 = _lastDisclosedGfeReceivedDate; v155.Clean = value; _lastDisclosedGfeReceivedDate = v155;
                var v156 = _lateChargeComments; v156.Clean = value; _lateChargeComments = v156;
                var v157 = _lateChargeDays; v157.Clean = value; _lateChargeDays = v157;
                var v158 = _lateChargePercent; v158.Clean = value; _lateChargePercent = v158;
                var v159 = _lateChargeType; v159.Clean = value; _lateChargeType = v159;
                var v160 = _lateFee; v160.Clean = value; _lateFee = v160;
                var v161 = _lEIntentToProceedComment; v161.Clean = value; _lEIntentToProceedComment = v161;
                var v162 = _lenderPaidMortgageInsuranceIndicator; v162.Clean = value; _lenderPaidMortgageInsuranceIndicator = v162;
                var v163 = _lendersInspectionFee; v163.Clean = value; _lendersInspectionFee = v163;
                var v164 = _lEReceivedBy; v164.Clean = value; _lEReceivedBy = v164;
                var v165 = _lEReceivedMethod; v165.Clean = value; _lEReceivedMethod = v165;
                var v166 = _lEReceivedMethodOther; v166.Clean = value; _lEReceivedMethodOther = v166;
                var v167 = _lESentOnDate; v167.Clean = value; _lESentOnDate = v167;
                var v168 = _marginPlusIndexPercent; v168.Clean = value; _marginPlusIndexPercent = v168;
                var v169 = _maximumLateCharge; v169.Clean = value; _maximumLateCharge = v169;
                var v170 = _maximumPayment; v170.Clean = value; _maximumPayment = v170;
                var v171 = _meansAnEstimateIndicator; v171.Clean = value; _meansAnEstimateIndicator = v171;
                var v172 = _miAdjustmentFactorLevel2; v172.Clean = value; _miAdjustmentFactorLevel2 = v172;
                var v173 = _miDecliningRenewalsIndicator; v173.Clean = value; _miDecliningRenewalsIndicator = v173;
                var v174 = _midpointCancellation; v174.Clean = value; _midpointCancellation = v174;
                var v175 = _miMonthlyPaymentLevel1; v175.Clean = value; _miMonthlyPaymentLevel1 = v175;
                var v176 = _miMonthlyPaymentLevel2; v176.Clean = value; _miMonthlyPaymentLevel2 = v176;
                var v177 = _miMonthsOfAdjustmentLevel1; v177.Clean = value; _miMonthsOfAdjustmentLevel1 = v177;
                var v178 = _miMonthsOfAdjustmentLevel2; v178.Clean = value; _miMonthsOfAdjustmentLevel2 = v178;
                var v179 = _minimumLateCharge; v179.Clean = value; _minimumLateCharge = v179;
                var v180 = _minimumPayment; v180.Clean = value; _minimumPayment = v180;
                var v181 = _mIPFactorLocked; v181.Clean = value; _mIPFactorLocked = v181;
                var v182 = _mIPrepaidAmount; v182.Clean = value; _mIPrepaidAmount = v182;
                var v183 = _miPrepaidIndicator; v183.Clean = value; _miPrepaidIndicator = v183;
                var v184 = _miScheduledTerminationDate; v184.Clean = value; _miScheduledTerminationDate = v184;
                var v185 = _mmiIndicator; v185.Clean = value; _mmiIndicator = v185;
                var v186 = _monthlyTerm; v186.Clean = value; _monthlyTerm = v186;
                var v187 = _monthsOfMiPrepaid; v187.Clean = value; _monthsOfMiPrepaid = v187;
                var v188 = _mortgageInsuranceCancelPercent; v188.Clean = value; _mortgageInsuranceCancelPercent = v188;
                var v189 = _namePreparedBy; v189.Clean = value; _namePreparedBy = v189;
                var v190 = _newConstructionIndicator; v190.Clean = value; _newConstructionIndicator = v190;
                var v191 = _numberOfPayments; v191.Clean = value; _numberOfPayments = v191;
                var v192 = _occupancyCertDate; v192.Clean = value; _occupancyCertDate = v192;
                var v193 = _originalContractDate; v193.Clean = value; _originalContractDate = v193;
                var v194 = _outstandingBalance; v194.Clean = value; _outstandingBalance = v194;
                var v195 = _paymentFrequencyType; v195.Clean = value; _paymentFrequencyType = v195;
                var v196 = _paymentIncreasePercent; v196.Clean = value; _paymentIncreasePercent = v196;
                var v197 = _phonePreparedBy; v197.Clean = value; _phonePreparedBy = v197;
                var v198 = _pmiIndicator; v198.Clean = value; _pmiIndicator = v198;
                var v199 = _pmiMidpointCancelationDate; v199.Clean = value; _pmiMidpointCancelationDate = v199;
                var v200 = _postConsummationDisclosureReceivedDate; v200.Clean = value; _postConsummationDisclosureReceivedDate = v200;
                var v201 = _postConsummationDisclosureSentDate; v201.Clean = value; _postConsummationDisclosureSentDate = v201;
                var v202 = _prepaidFinanceCharge; v202.Clean = value; _prepaidFinanceCharge = v202;
                var v203 = _propertyInsuranceIndicator; v203.Clean = value; _propertyInsuranceIndicator = v203;
                var v204 = _rateLockGfeDueDate; v204.Clean = value; _rateLockGfeDueDate = v204;
                var v205 = _ratePercent; v205.Clean = value; _ratePercent = v205;
                var v206 = _recastPaidMonths; v206.Clean = value; _recastPaidMonths = v206;
                var v207 = _recastStopMonths; v207.Clean = value; _recastStopMonths = v207;
                var v208 = _refundPaymentIndicator; v208.Clean = value; _refundPaymentIndicator = v208;
                var v209 = _refundUnearnedMipIndicator; v209.Clean = value; _refundUnearnedMipIndicator = v209;
                var v210 = _regulationZInterestRatePeriods; v210.Clean = value; _regulationZInterestRatePeriods = v210;
                var v211 = _regulationZPayments; v211.Clean = value; _regulationZPayments = v211;
                var v212 = _regzTableType; v212.Clean = value; _regzTableType = v212;
                var v213 = _requiredDepositIndicator; v213.Clean = value; _requiredDepositIndicator = v213;
                var v214 = _revisedClosingDisclosureReceivedDate; v214.Clean = value; _revisedClosingDisclosureReceivedDate = v214;
                var v215 = _revisedClosingDisclosureSentDate; v215.Clean = value; _revisedClosingDisclosureSentDate = v215;
                var v216 = _revisedGfeDueDate; v216.Clean = value; _revisedGfeDueDate = v216;
                var v217 = _roundedMarginPlusIndexPercent; v217.Clean = value; _roundedMarginPlusIndexPercent = v217;
                var v218 = _safeHarborSentDate; v218.Clean = value; _safeHarborSentDate = v218;
                var v219 = _samplePayments; v219.Clean = value; _samplePayments = v219;
                var v220 = _securityType; v220.Clean = value; _securityType = v220;
                var v221 = _sSPLSentDate; v221.Clean = value; _sSPLSentDate = v221;
                var v222 = _tilDate; v222.Clean = value; _tilDate = v222;
                var v223 = _tilDisclosedComments; v223.Clean = value; _tilDisclosedComments = v223;
                var v224 = _tilDisclosureMethod; v224.Clean = value; _tilDisclosureMethod = v224;
                var v225 = _tilLastDisclosedBorrowerReceivedDate; v225.Clean = value; _tilLastDisclosedBorrowerReceivedDate = v225;
                var v226 = _tilLastDisclosedBy; v226.Clean = value; _tilLastDisclosedBy = v226;
                var v227 = _tilLastDisclosedDate; v227.Clean = value; _tilLastDisclosedDate = v227;
                var v228 = _tilRedisclosureProvidedDate; v228.Clean = value; _tilRedisclosureProvidedDate = v228;
                var v229 = _tilRedisclosureReceivedDate; v229.Clean = value; _tilRedisclosureReceivedDate = v229;
                var v230 = _totalBrokerFees; v230.Clean = value; _totalBrokerFees = v230;
                var v231 = _totalLatePayment; v231.Clean = value; _totalLatePayment = v231;
                var v232 = _totalLenderFees; v232.Clean = value; _totalLenderFees = v232;
                var v233 = _totalOfPayments; v233.Clean = value; _totalOfPayments = v233;
                var v234 = _totalOfPrincipalAndInterest; v234.Clean = value; _totalOfPrincipalAndInterest = v234;
                var v235 = _useCustomLenderProfile; v235.Clean = value; _useCustomLenderProfile = v235;
                var v236 = _useDaysInYears; v236.Clean = value; _useDaysInYears = v236;
                var v237 = _usePitiForRatioIndicator; v237.Clean = value; _usePitiForRatioIndicator = v237;
                var v238 = _variableRateFeatureIndicator; v238.Clean = value; _variableRateFeatureIndicator = v238;
                var v239 = _yearlyTerm; v239.Clean = value; _yearlyTerm = v239;
                var v240 = _yearOfMaximumPayment; v240.Clean = value; _yearOfMaximumPayment = v240;
                var v241 = _years; v241.Clean = value; _years = v241;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}