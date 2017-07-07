using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
        private Value<decimal?> _lateChargeBasis;
        public decimal? LateChargeBasis { get { return _lateChargeBasis; } set { _lateChargeBasis = value; } }
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
                    && _lateChargeBasis.Clean
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
                var acknowledgedDay = _acknowledgedDay; acknowledgedDay.Clean = value; _acknowledgedDay = acknowledgedDay;
                var acknowledgedMonth = _acknowledgedMonth; acknowledgedMonth.Clean = value; _acknowledgedMonth = acknowledgedMonth;
                var acknowledgedYear = _acknowledgedYear; acknowledgedYear.Clean = value; _acknowledgedYear = acknowledgedYear;
                var acquisition = _acquisition; acquisition.Clean = value; _acquisition = acquisition;
                var additionalArmInformation = _additionalArmInformation; additionalArmInformation.Clean = value; _additionalArmInformation = additionalArmInformation;
                var allDateAndNumericalDisclosuresIndicator = _allDateAndNumericalDisclosuresIndicator; allDateAndNumericalDisclosuresIndicator.Clean = value; _allDateAndNumericalDisclosuresIndicator = allDateAndNumericalDisclosuresIndicator;
                var amountFinanced = _amountFinanced; amountFinanced.Clean = value; _amountFinanced = amountFinanced;
                var aprPercent = _aprPercent; aprPercent.Clean = value; _aprPercent = aprPercent;
                var armDisclosureDescription = _armDisclosureDescription; armDisclosureDescription.Clean = value; _armDisclosureDescription = armDisclosureDescription;
                var assumptionOnYourProperty = _assumptionOnYourProperty; assumptionOnYourProperty.Clean = value; _assumptionOnYourProperty = assumptionOnYourProperty;
                var borrowerIntendToContinueDate = _borrowerIntendToContinueDate; borrowerIntendToContinueDate.Clean = value; _borrowerIntendToContinueDate = borrowerIntendToContinueDate;
                var borrowerIntendToContinueIndicator = _borrowerIntendToContinueIndicator; borrowerIntendToContinueIndicator.Clean = value; _borrowerIntendToContinueIndicator = borrowerIntendToContinueIndicator;
                var borrowerMiTerminationDate = _borrowerMiTerminationDate; borrowerMiTerminationDate.Clean = value; _borrowerMiTerminationDate = borrowerMiTerminationDate;
                var calculateBasedOnRemainingBalance = _calculateBasedOnRemainingBalance; calculateBasedOnRemainingBalance.Clean = value; _calculateBasedOnRemainingBalance = calculateBasedOnRemainingBalance;
                var chargesAddedToPaymentsIndicator = _chargesAddedToPaymentsIndicator; chargesAddedToPaymentsIndicator.Clean = value; _chargesAddedToPaymentsIndicator = chargesAddedToPaymentsIndicator;
                var chargesAtLoanClosingIndicator = _chargesAtLoanClosingIndicator; chargesAtLoanClosingIndicator.Clean = value; _chargesAtLoanClosingIndicator = chargesAtLoanClosingIndicator;
                var circumstanceChangeReason = _circumstanceChangeReason; circumstanceChangeReason.Clean = value; _circumstanceChangeReason = circumstanceChangeReason;
                var circumstanceChangeReceivedDate = _circumstanceChangeReceivedDate; circumstanceChangeReceivedDate.Clean = value; _circumstanceChangeReceivedDate = circumstanceChangeReceivedDate;
                var closingDisclosureReceivedDate = _closingDisclosureReceivedDate; closingDisclosureReceivedDate.Clean = value; _closingDisclosureReceivedDate = closingDisclosureReceivedDate;
                var closingDisclosureSentDate = _closingDisclosureSentDate; closingDisclosureSentDate.Clean = value; _closingDisclosureSentDate = closingDisclosureSentDate;
                var constructionFirstIntChangeAdjType = _constructionFirstIntChangeAdjType; constructionFirstIntChangeAdjType.Clean = value; _constructionFirstIntChangeAdjType = constructionFirstIntChangeAdjType;
                var constructionLoanDescription = _constructionLoanDescription; constructionLoanDescription.Clean = value; _constructionLoanDescription = constructionLoanDescription;
                var constructionLoanMethod = _constructionLoanMethod; constructionLoanMethod.Clean = value; _constructionLoanMethod = constructionLoanMethod;
                var constructionPeriodMonths = _constructionPeriodMonths; constructionPeriodMonths.Clean = value; _constructionPeriodMonths = constructionPeriodMonths;
                var constructionRatePercent = _constructionRatePercent; constructionRatePercent.Clean = value; _constructionRatePercent = constructionRatePercent;
                var constructionRefinanceIndicator = _constructionRefinanceIndicator; constructionRefinanceIndicator.Clean = value; _constructionRefinanceIndicator = constructionRefinanceIndicator;
                var creditDisability = _creditDisability; creditDisability.Clean = value; _creditDisability = creditDisability;
                var creditDisabilityIndicator = _creditDisabilityIndicator; creditDisabilityIndicator.Clean = value; _creditDisabilityIndicator = creditDisabilityIndicator;
                var creditLife = _creditLife; creditLife.Clean = value; _creditLife = creditLife;
                var creditLifeAndCreditDisability = _creditLifeAndCreditDisability; creditLifeAndCreditDisability.Clean = value; _creditLifeAndCreditDisability = creditLifeAndCreditDisability;
                var creditLifeInsuranceIndicator = _creditLifeInsuranceIndicator; creditLifeInsuranceIndicator.Clean = value; _creditLifeInsuranceIndicator = creditLifeInsuranceIndicator;
                var customizePaymentScheduleIndicator = _customizePaymentScheduleIndicator; customizePaymentScheduleIndicator.Clean = value; _customizePaymentScheduleIndicator = customizePaymentScheduleIndicator;
                var demandFeatureIndicator = _demandFeatureIndicator; demandFeatureIndicator.Clean = value; _demandFeatureIndicator = demandFeatureIndicator;
                var disclosedAprPercent = _disclosedAprPercent; disclosedAprPercent.Clean = value; _disclosedAprPercent = disclosedAprPercent;
                var disclosedByBrokerIndicator = _disclosedByBrokerIndicator; disclosedByBrokerIndicator.Clean = value; _disclosedByBrokerIndicator = disclosedByBrokerIndicator;
                var disclosedComments = _disclosedComments; disclosedComments.Clean = value; _disclosedComments = disclosedComments;
                var disclosedDailyInterestCharge = _disclosedDailyInterestCharge; disclosedDailyInterestCharge.Clean = value; _disclosedDailyInterestCharge = disclosedDailyInterestCharge;
                var disclosedFinanceCharge = _disclosedFinanceCharge; disclosedFinanceCharge.Clean = value; _disclosedFinanceCharge = disclosedFinanceCharge;
                var disclosedPrepayment = _disclosedPrepayment; disclosedPrepayment.Clean = value; _disclosedPrepayment = disclosedPrepayment;
                var disclosedProduct = _disclosedProduct; disclosedProduct.Clean = value; _disclosedProduct = disclosedProduct;
                var disclosureMethod = _disclosureMethod; disclosureMethod.Clean = value; _disclosureMethod = disclosureMethod;
                var disclosureType = _disclosureType; disclosureType.Clean = value; _disclosureType = disclosureType;
                var discountPeriod = _discountPeriod; discountPeriod.Clean = value; _discountPeriod = discountPeriod;
                var discountRatePercent = _discountRatePercent; discountRatePercent.Clean = value; _discountRatePercent = discountRatePercent;
                var discountType = _discountType; discountType.Clean = value; _discountType = discountType;
                var dueDate = _dueDate; dueDate.Clean = value; _dueDate = dueDate;
                var earliestClosingDate = _earliestClosingDate; earliestClosingDate.Clean = value; _earliestClosingDate = earliestClosingDate;
                var earliestFeeCollectionDate = _earliestFeeCollectionDate; earliestFeeCollectionDate.Clean = value; _earliestFeeCollectionDate = earliestFeeCollectionDate;
                var eSignConsentBorrowerDateAccepted1 = _eSignConsentBorrowerDateAccepted1; eSignConsentBorrowerDateAccepted1.Clean = value; _eSignConsentBorrowerDateAccepted1 = eSignConsentBorrowerDateAccepted1;
                var eSignConsentBorrowerDateAccepted2 = _eSignConsentBorrowerDateAccepted2; eSignConsentBorrowerDateAccepted2.Clean = value; _eSignConsentBorrowerDateAccepted2 = eSignConsentBorrowerDateAccepted2;
                var eSignConsentBorrowerDateAccepted3 = _eSignConsentBorrowerDateAccepted3; eSignConsentBorrowerDateAccepted3.Clean = value; _eSignConsentBorrowerDateAccepted3 = eSignConsentBorrowerDateAccepted3;
                var eSignConsentBorrowerDateAccepted4 = _eSignConsentBorrowerDateAccepted4; eSignConsentBorrowerDateAccepted4.Clean = value; _eSignConsentBorrowerDateAccepted4 = eSignConsentBorrowerDateAccepted4;
                var eSignConsentBorrowerDateAccepted5 = _eSignConsentBorrowerDateAccepted5; eSignConsentBorrowerDateAccepted5.Clean = value; _eSignConsentBorrowerDateAccepted5 = eSignConsentBorrowerDateAccepted5;
                var eSignConsentBorrowerDateAccepted6 = _eSignConsentBorrowerDateAccepted6; eSignConsentBorrowerDateAccepted6.Clean = value; _eSignConsentBorrowerDateAccepted6 = eSignConsentBorrowerDateAccepted6;
                var eSignConsentBorrowerIPAddress1 = _eSignConsentBorrowerIPAddress1; eSignConsentBorrowerIPAddress1.Clean = value; _eSignConsentBorrowerIPAddress1 = eSignConsentBorrowerIPAddress1;
                var eSignConsentBorrowerIPAddress2 = _eSignConsentBorrowerIPAddress2; eSignConsentBorrowerIPAddress2.Clean = value; _eSignConsentBorrowerIPAddress2 = eSignConsentBorrowerIPAddress2;
                var eSignConsentBorrowerIPAddress3 = _eSignConsentBorrowerIPAddress3; eSignConsentBorrowerIPAddress3.Clean = value; _eSignConsentBorrowerIPAddress3 = eSignConsentBorrowerIPAddress3;
                var eSignConsentBorrowerIPAddress4 = _eSignConsentBorrowerIPAddress4; eSignConsentBorrowerIPAddress4.Clean = value; _eSignConsentBorrowerIPAddress4 = eSignConsentBorrowerIPAddress4;
                var eSignConsentBorrowerIPAddress5 = _eSignConsentBorrowerIPAddress5; eSignConsentBorrowerIPAddress5.Clean = value; _eSignConsentBorrowerIPAddress5 = eSignConsentBorrowerIPAddress5;
                var eSignConsentBorrowerIPAddress6 = _eSignConsentBorrowerIPAddress6; eSignConsentBorrowerIPAddress6.Clean = value; _eSignConsentBorrowerIPAddress6 = eSignConsentBorrowerIPAddress6;
                var eSignConsentBorrowerSource1 = _eSignConsentBorrowerSource1; eSignConsentBorrowerSource1.Clean = value; _eSignConsentBorrowerSource1 = eSignConsentBorrowerSource1;
                var eSignConsentBorrowerSource2 = _eSignConsentBorrowerSource2; eSignConsentBorrowerSource2.Clean = value; _eSignConsentBorrowerSource2 = eSignConsentBorrowerSource2;
                var eSignConsentBorrowerSource3 = _eSignConsentBorrowerSource3; eSignConsentBorrowerSource3.Clean = value; _eSignConsentBorrowerSource3 = eSignConsentBorrowerSource3;
                var eSignConsentBorrowerSource4 = _eSignConsentBorrowerSource4; eSignConsentBorrowerSource4.Clean = value; _eSignConsentBorrowerSource4 = eSignConsentBorrowerSource4;
                var eSignConsentBorrowerSource5 = _eSignConsentBorrowerSource5; eSignConsentBorrowerSource5.Clean = value; _eSignConsentBorrowerSource5 = eSignConsentBorrowerSource5;
                var eSignConsentBorrowerSource6 = _eSignConsentBorrowerSource6; eSignConsentBorrowerSource6.Clean = value; _eSignConsentBorrowerSource6 = eSignConsentBorrowerSource6;
                var eSignConsentBorrowerStatus1 = _eSignConsentBorrowerStatus1; eSignConsentBorrowerStatus1.Clean = value; _eSignConsentBorrowerStatus1 = eSignConsentBorrowerStatus1;
                var eSignConsentBorrowerStatus2 = _eSignConsentBorrowerStatus2; eSignConsentBorrowerStatus2.Clean = value; _eSignConsentBorrowerStatus2 = eSignConsentBorrowerStatus2;
                var eSignConsentBorrowerStatus3 = _eSignConsentBorrowerStatus3; eSignConsentBorrowerStatus3.Clean = value; _eSignConsentBorrowerStatus3 = eSignConsentBorrowerStatus3;
                var eSignConsentBorrowerStatus4 = _eSignConsentBorrowerStatus4; eSignConsentBorrowerStatus4.Clean = value; _eSignConsentBorrowerStatus4 = eSignConsentBorrowerStatus4;
                var eSignConsentBorrowerStatus5 = _eSignConsentBorrowerStatus5; eSignConsentBorrowerStatus5.Clean = value; _eSignConsentBorrowerStatus5 = eSignConsentBorrowerStatus5;
                var eSignConsentBorrowerStatus6 = _eSignConsentBorrowerStatus6; eSignConsentBorrowerStatus6.Clean = value; _eSignConsentBorrowerStatus6 = eSignConsentBorrowerStatus6;
                var eSignConsentCoBorrowerDateAccepted1 = _eSignConsentCoBorrowerDateAccepted1; eSignConsentCoBorrowerDateAccepted1.Clean = value; _eSignConsentCoBorrowerDateAccepted1 = eSignConsentCoBorrowerDateAccepted1;
                var eSignConsentCoBorrowerDateAccepted2 = _eSignConsentCoBorrowerDateAccepted2; eSignConsentCoBorrowerDateAccepted2.Clean = value; _eSignConsentCoBorrowerDateAccepted2 = eSignConsentCoBorrowerDateAccepted2;
                var eSignConsentCoBorrowerDateAccepted3 = _eSignConsentCoBorrowerDateAccepted3; eSignConsentCoBorrowerDateAccepted3.Clean = value; _eSignConsentCoBorrowerDateAccepted3 = eSignConsentCoBorrowerDateAccepted3;
                var eSignConsentCoBorrowerDateAccepted4 = _eSignConsentCoBorrowerDateAccepted4; eSignConsentCoBorrowerDateAccepted4.Clean = value; _eSignConsentCoBorrowerDateAccepted4 = eSignConsentCoBorrowerDateAccepted4;
                var eSignConsentCoBorrowerDateAccepted5 = _eSignConsentCoBorrowerDateAccepted5; eSignConsentCoBorrowerDateAccepted5.Clean = value; _eSignConsentCoBorrowerDateAccepted5 = eSignConsentCoBorrowerDateAccepted5;
                var eSignConsentCoBorrowerDateAccepted6 = _eSignConsentCoBorrowerDateAccepted6; eSignConsentCoBorrowerDateAccepted6.Clean = value; _eSignConsentCoBorrowerDateAccepted6 = eSignConsentCoBorrowerDateAccepted6;
                var eSignConsentCoBorrowerIPAddress1 = _eSignConsentCoBorrowerIPAddress1; eSignConsentCoBorrowerIPAddress1.Clean = value; _eSignConsentCoBorrowerIPAddress1 = eSignConsentCoBorrowerIPAddress1;
                var eSignConsentCoBorrowerIPAddress2 = _eSignConsentCoBorrowerIPAddress2; eSignConsentCoBorrowerIPAddress2.Clean = value; _eSignConsentCoBorrowerIPAddress2 = eSignConsentCoBorrowerIPAddress2;
                var eSignConsentCoBorrowerIPAddress3 = _eSignConsentCoBorrowerIPAddress3; eSignConsentCoBorrowerIPAddress3.Clean = value; _eSignConsentCoBorrowerIPAddress3 = eSignConsentCoBorrowerIPAddress3;
                var eSignConsentCoBorrowerIPAddress4 = _eSignConsentCoBorrowerIPAddress4; eSignConsentCoBorrowerIPAddress4.Clean = value; _eSignConsentCoBorrowerIPAddress4 = eSignConsentCoBorrowerIPAddress4;
                var eSignConsentCoBorrowerIPAddress5 = _eSignConsentCoBorrowerIPAddress5; eSignConsentCoBorrowerIPAddress5.Clean = value; _eSignConsentCoBorrowerIPAddress5 = eSignConsentCoBorrowerIPAddress5;
                var eSignConsentCoBorrowerIPAddress6 = _eSignConsentCoBorrowerIPAddress6; eSignConsentCoBorrowerIPAddress6.Clean = value; _eSignConsentCoBorrowerIPAddress6 = eSignConsentCoBorrowerIPAddress6;
                var eSignConsentCoBorrowerSource1 = _eSignConsentCoBorrowerSource1; eSignConsentCoBorrowerSource1.Clean = value; _eSignConsentCoBorrowerSource1 = eSignConsentCoBorrowerSource1;
                var eSignConsentCoBorrowerSource2 = _eSignConsentCoBorrowerSource2; eSignConsentCoBorrowerSource2.Clean = value; _eSignConsentCoBorrowerSource2 = eSignConsentCoBorrowerSource2;
                var eSignConsentCoBorrowerSource3 = _eSignConsentCoBorrowerSource3; eSignConsentCoBorrowerSource3.Clean = value; _eSignConsentCoBorrowerSource3 = eSignConsentCoBorrowerSource3;
                var eSignConsentCoBorrowerSource4 = _eSignConsentCoBorrowerSource4; eSignConsentCoBorrowerSource4.Clean = value; _eSignConsentCoBorrowerSource4 = eSignConsentCoBorrowerSource4;
                var eSignConsentCoBorrowerSource5 = _eSignConsentCoBorrowerSource5; eSignConsentCoBorrowerSource5.Clean = value; _eSignConsentCoBorrowerSource5 = eSignConsentCoBorrowerSource5;
                var eSignConsentCoBorrowerSource6 = _eSignConsentCoBorrowerSource6; eSignConsentCoBorrowerSource6.Clean = value; _eSignConsentCoBorrowerSource6 = eSignConsentCoBorrowerSource6;
                var eSignConsentCoBorrowerStatus1 = _eSignConsentCoBorrowerStatus1; eSignConsentCoBorrowerStatus1.Clean = value; _eSignConsentCoBorrowerStatus1 = eSignConsentCoBorrowerStatus1;
                var eSignConsentCoBorrowerStatus2 = _eSignConsentCoBorrowerStatus2; eSignConsentCoBorrowerStatus2.Clean = value; _eSignConsentCoBorrowerStatus2 = eSignConsentCoBorrowerStatus2;
                var eSignConsentCoBorrowerStatus3 = _eSignConsentCoBorrowerStatus3; eSignConsentCoBorrowerStatus3.Clean = value; _eSignConsentCoBorrowerStatus3 = eSignConsentCoBorrowerStatus3;
                var eSignConsentCoBorrowerStatus4 = _eSignConsentCoBorrowerStatus4; eSignConsentCoBorrowerStatus4.Clean = value; _eSignConsentCoBorrowerStatus4 = eSignConsentCoBorrowerStatus4;
                var eSignConsentCoBorrowerStatus5 = _eSignConsentCoBorrowerStatus5; eSignConsentCoBorrowerStatus5.Clean = value; _eSignConsentCoBorrowerStatus5 = eSignConsentCoBorrowerStatus5;
                var eSignConsentCoBorrowerStatus6 = _eSignConsentCoBorrowerStatus6; eSignConsentCoBorrowerStatus6.Clean = value; _eSignConsentCoBorrowerStatus6 = eSignConsentCoBorrowerStatus6;
                var eSignConsentDate = _eSignConsentDate; eSignConsentDate.Clean = value; _eSignConsentDate = eSignConsentDate;
                var extraPaymentForEarlyPayOff = _extraPaymentForEarlyPayOff; extraPaymentForEarlyPayOff.Clean = value; _extraPaymentForEarlyPayOff = extraPaymentForEarlyPayOff;
                var feeCollectedDate = _feeCollectedDate; feeCollectedDate.Clean = value; _feeCollectedDate = feeCollectedDate;
                var filingFees = _filingFees; filingFees.Clean = value; _filingFees = filingFees;
                var finalPaymentDate = _finalPaymentDate; finalPaymentDate.Clean = value; _finalPaymentDate = finalPaymentDate;
                var financeCharge = _financeCharge; financeCharge.Clean = value; _financeCharge = financeCharge;
                var financedAllGuaranteeFeeAmount = _financedAllGuaranteeFeeAmount; financedAllGuaranteeFeeAmount.Clean = value; _financedAllGuaranteeFeeAmount = financedAllGuaranteeFeeAmount;
                var financedAllGuaranteeFeePercent = _financedAllGuaranteeFeePercent; financedAllGuaranteeFeePercent.Clean = value; _financedAllGuaranteeFeePercent = financedAllGuaranteeFeePercent;
                var financedAllTotalLoanAmount = _financedAllTotalLoanAmount; financedAllTotalLoanAmount.Clean = value; _financedAllTotalLoanAmount = financedAllTotalLoanAmount;
                var financedPortionGuaranteeFeeAmount = _financedPortionGuaranteeFeeAmount; financedPortionGuaranteeFeeAmount.Clean = value; _financedPortionGuaranteeFeeAmount = financedPortionGuaranteeFeeAmount;
                var financedPortionGuaranteeFeePercent = _financedPortionGuaranteeFeePercent; financedPortionGuaranteeFeePercent.Clean = value; _financedPortionGuaranteeFeePercent = financedPortionGuaranteeFeePercent;
                var financedPortionTotalLoanAmount = _financedPortionTotalLoanAmount; financedPortionTotalLoanAmount.Clean = value; _financedPortionTotalLoanAmount = financedPortionTotalLoanAmount;
                var financingType = _financingType; financingType.Clean = value; _financingType = financingType;
                var firstAmortizationPaymentDate = _firstAmortizationPaymentDate; firstAmortizationPaymentDate.Clean = value; _firstAmortizationPaymentDate = firstAmortizationPaymentDate;
                var floodInsuranceIndicator = _floodInsuranceIndicator; floodInsuranceIndicator.Clean = value; _floodInsuranceIndicator = floodInsuranceIndicator;
                var gfeApplicationDate = _gfeApplicationDate; gfeApplicationDate.Clean = value; _gfeApplicationDate = gfeApplicationDate;
                var gfeChangedCircumstanceIndicator = _gfeChangedCircumstanceIndicator; gfeChangedCircumstanceIndicator.Clean = value; _gfeChangedCircumstanceIndicator = gfeChangedCircumstanceIndicator;
                var gfeChangedCircumstanceItem = _gfeChangedCircumstanceItem; gfeChangedCircumstanceItem.Clean = value; _gfeChangedCircumstanceItem = gfeChangedCircumstanceItem;
                var gFEChangedCirsumstanceItemCode = _gFEChangedCirsumstanceItemCode; gFEChangedCirsumstanceItemCode.Clean = value; _gFEChangedCirsumstanceItemCode = gFEChangedCirsumstanceItemCode;
                var gfeDate = _gfeDate; gfeDate.Clean = value; _gfeDate = gfeDate;
                var gfeExpirationDate = _gfeExpirationDate; gfeExpirationDate.Clean = value; _gfeExpirationDate = gfeExpirationDate;
                var gfeExpirationPeriod = _gfeExpirationPeriod; gfeExpirationPeriod.Clean = value; _gfeExpirationPeriod = gfeExpirationPeriod;
                var gfeRateLockRedisclosureRequiredIndicator = _gfeRateLockRedisclosureRequiredIndicator; gfeRateLockRedisclosureRequiredIndicator.Clean = value; _gfeRateLockRedisclosureRequiredIndicator = gfeRateLockRedisclosureRequiredIndicator;
                var gfeRedisclosureProvidedDate = _gfeRedisclosureProvidedDate; gfeRedisclosureProvidedDate.Clean = value; _gfeRedisclosureProvidedDate = gfeRedisclosureProvidedDate;
                var gfeRedisclosureReceivedDate = _gfeRedisclosureReceivedDate; gfeRedisclosureReceivedDate.Clean = value; _gfeRedisclosureReceivedDate = gfeRedisclosureReceivedDate;
                var highCostDisclosure = _highCostDisclosure; highCostDisclosure.Clean = value; _highCostDisclosure = highCostDisclosure;
                var homeCounselingProvidedDate = _homeCounselingProvidedDate; homeCounselingProvidedDate.Clean = value; _homeCounselingProvidedDate = homeCounselingProvidedDate;
                var hud1ToleranceViolatedIndicator = _hud1ToleranceViolatedIndicator; hud1ToleranceViolatedIndicator.Clean = value; _hud1ToleranceViolatedIndicator = hud1ToleranceViolatedIndicator;
                var hudToleranceResolutionComments = _hudToleranceResolutionComments; hudToleranceResolutionComments.Clean = value; _hudToleranceResolutionComments = hudToleranceResolutionComments;
                var hudToleranceResolutionDate = _hudToleranceResolutionDate; hudToleranceResolutionDate.Clean = value; _hudToleranceResolutionDate = hudToleranceResolutionDate;
                var hudToleranceResolvedBy = _hudToleranceResolvedBy; hudToleranceResolvedBy.Clean = value; _hudToleranceResolvedBy = hudToleranceResolvedBy;
                var id = _id; id.Clean = value; _id = id;
                var ifYouPurchaseIndicator = _ifYouPurchaseIndicator; ifYouPurchaseIndicator.Clean = value; _ifYouPurchaseIndicator = ifYouPurchaseIndicator;
                var ifYouPurchaseType = _ifYouPurchaseType; ifYouPurchaseType.Clean = value; _ifYouPurchaseType = ifYouPurchaseType;
                var includeMiIndicator = _includeMiIndicator; includeMiIndicator.Clean = value; _includeMiIndicator = includeMiIndicator;
                var includePmiIndicator = _includePmiIndicator; includePmiIndicator.Clean = value; _includePmiIndicator = includePmiIndicator;
                var includeTaxesInsuranceIndicator = _includeTaxesInsuranceIndicator; includeTaxesInsuranceIndicator.Clean = value; _includeTaxesInsuranceIndicator = includeTaxesInsuranceIndicator;
                var initialAVMProvidedDate = _initialAVMProvidedDate; initialAVMProvidedDate.Clean = value; _initialAVMProvidedDate = initialAVMProvidedDate;
                var initialDisclosureDueDate = _initialDisclosureDueDate; initialDisclosureDueDate.Clean = value; _initialDisclosureDueDate = initialDisclosureDueDate;
                var initialDisclosureProvidedDate = _initialDisclosureProvidedDate; initialDisclosureProvidedDate.Clean = value; _initialDisclosureProvidedDate = initialDisclosureProvidedDate;
                var initialGfeAffiliatedBusinessProvidedDate = _initialGfeAffiliatedBusinessProvidedDate; initialGfeAffiliatedBusinessProvidedDate.Clean = value; _initialGfeAffiliatedBusinessProvidedDate = initialGfeAffiliatedBusinessProvidedDate;
                var initialGFEAppraisalProvidedDate = _initialGFEAppraisalProvidedDate; initialGFEAppraisalProvidedDate.Clean = value; _initialGFEAppraisalProvidedDate = initialGFEAppraisalProvidedDate;
                var initialGfeCharmBookletProvidedDate = _initialGfeCharmBookletProvidedDate; initialGfeCharmBookletProvidedDate.Clean = value; _initialGfeCharmBookletProvidedDate = initialGfeCharmBookletProvidedDate;
                var initialGfeDisclosureProvidedDate = _initialGfeDisclosureProvidedDate; initialGfeDisclosureProvidedDate.Clean = value; _initialGfeDisclosureProvidedDate = initialGfeDisclosureProvidedDate;
                var initialGfeDisclosureReceivedDate = _initialGfeDisclosureReceivedDate; initialGfeDisclosureReceivedDate.Clean = value; _initialGfeDisclosureReceivedDate = initialGfeDisclosureReceivedDate;
                var initialGfeHelocBrochureProvidedDate = _initialGfeHelocBrochureProvidedDate; initialGfeHelocBrochureProvidedDate.Clean = value; _initialGfeHelocBrochureProvidedDate = initialGfeHelocBrochureProvidedDate;
                var initialGfeHudSpecialBookletProvidedDate = _initialGfeHudSpecialBookletProvidedDate; initialGfeHudSpecialBookletProvidedDate.Clean = value; _initialGfeHudSpecialBookletProvidedDate = initialGfeHudSpecialBookletProvidedDate;
                var initialSubsequentAppraisalProvidedDate = _initialSubsequentAppraisalProvidedDate; initialSubsequentAppraisalProvidedDate.Clean = value; _initialSubsequentAppraisalProvidedDate = initialSubsequentAppraisalProvidedDate;
                var initialTilDisclosureProvidedDate = _initialTilDisclosureProvidedDate; initialTilDisclosureProvidedDate.Clean = value; _initialTilDisclosureProvidedDate = initialTilDisclosureProvidedDate;
                var initialTilDisclosureReceivedDate = _initialTilDisclosureReceivedDate; initialTilDisclosureReceivedDate.Clean = value; _initialTilDisclosureReceivedDate = initialTilDisclosureReceivedDate;
                var insuranceRequiredDescription = _insuranceRequiredDescription; insuranceRequiredDescription.Clean = value; _insuranceRequiredDescription = insuranceRequiredDescription;
                var interestInNameOf = _interestInNameOf; interestInNameOf.Clean = value; _interestInNameOf = interestInNameOf;
                var interestOnly = _interestOnly; interestOnly.Clean = value; _interestOnly = interestOnly;
                var interestOnlyIndicator = _interestOnlyIndicator; interestOnlyIndicator.Clean = value; _interestOnlyIndicator = interestOnlyIndicator;
                var interestOnlyMonths = _interestOnlyMonths; interestOnlyMonths.Clean = value; _interestOnlyMonths = interestOnlyMonths;
                var interestRateType = _interestRateType; interestRateType.Clean = value; _interestRateType = interestRateType;
                var interestReserveAmount = _interestReserveAmount; interestReserveAmount.Clean = value; _interestReserveAmount = interestReserveAmount;
                var lastDisclosedBy = _lastDisclosedBy; lastDisclosedBy.Clean = value; _lastDisclosedBy = lastDisclosedBy;
                var lastDisclosedDate = _lastDisclosedDate; lastDisclosedDate.Clean = value; _lastDisclosedDate = lastDisclosedDate;
                var lastDisclosedGfeReceivedDate = _lastDisclosedGfeReceivedDate; lastDisclosedGfeReceivedDate.Clean = value; _lastDisclosedGfeReceivedDate = lastDisclosedGfeReceivedDate;
                var lateChargeBasis = _lateChargeBasis; lateChargeBasis.Clean = value; _lateChargeBasis = lateChargeBasis;
                var lateChargeComments = _lateChargeComments; lateChargeComments.Clean = value; _lateChargeComments = lateChargeComments;
                var lateChargeDays = _lateChargeDays; lateChargeDays.Clean = value; _lateChargeDays = lateChargeDays;
                var lateChargePercent = _lateChargePercent; lateChargePercent.Clean = value; _lateChargePercent = lateChargePercent;
                var lateChargeType = _lateChargeType; lateChargeType.Clean = value; _lateChargeType = lateChargeType;
                var lateFee = _lateFee; lateFee.Clean = value; _lateFee = lateFee;
                var lEIntentToProceedComment = _lEIntentToProceedComment; lEIntentToProceedComment.Clean = value; _lEIntentToProceedComment = lEIntentToProceedComment;
                var lenderPaidMortgageInsuranceIndicator = _lenderPaidMortgageInsuranceIndicator; lenderPaidMortgageInsuranceIndicator.Clean = value; _lenderPaidMortgageInsuranceIndicator = lenderPaidMortgageInsuranceIndicator;
                var lendersInspectionFee = _lendersInspectionFee; lendersInspectionFee.Clean = value; _lendersInspectionFee = lendersInspectionFee;
                var lEReceivedBy = _lEReceivedBy; lEReceivedBy.Clean = value; _lEReceivedBy = lEReceivedBy;
                var lEReceivedMethod = _lEReceivedMethod; lEReceivedMethod.Clean = value; _lEReceivedMethod = lEReceivedMethod;
                var lEReceivedMethodOther = _lEReceivedMethodOther; lEReceivedMethodOther.Clean = value; _lEReceivedMethodOther = lEReceivedMethodOther;
                var lESentOnDate = _lESentOnDate; lESentOnDate.Clean = value; _lESentOnDate = lESentOnDate;
                var marginPlusIndexPercent = _marginPlusIndexPercent; marginPlusIndexPercent.Clean = value; _marginPlusIndexPercent = marginPlusIndexPercent;
                var maximumLateCharge = _maximumLateCharge; maximumLateCharge.Clean = value; _maximumLateCharge = maximumLateCharge;
                var maximumPayment = _maximumPayment; maximumPayment.Clean = value; _maximumPayment = maximumPayment;
                var meansAnEstimateIndicator = _meansAnEstimateIndicator; meansAnEstimateIndicator.Clean = value; _meansAnEstimateIndicator = meansAnEstimateIndicator;
                var miAdjustmentFactorLevel2 = _miAdjustmentFactorLevel2; miAdjustmentFactorLevel2.Clean = value; _miAdjustmentFactorLevel2 = miAdjustmentFactorLevel2;
                var miDecliningRenewalsIndicator = _miDecliningRenewalsIndicator; miDecliningRenewalsIndicator.Clean = value; _miDecliningRenewalsIndicator = miDecliningRenewalsIndicator;
                var midpointCancellation = _midpointCancellation; midpointCancellation.Clean = value; _midpointCancellation = midpointCancellation;
                var miMonthlyPaymentLevel1 = _miMonthlyPaymentLevel1; miMonthlyPaymentLevel1.Clean = value; _miMonthlyPaymentLevel1 = miMonthlyPaymentLevel1;
                var miMonthlyPaymentLevel2 = _miMonthlyPaymentLevel2; miMonthlyPaymentLevel2.Clean = value; _miMonthlyPaymentLevel2 = miMonthlyPaymentLevel2;
                var miMonthsOfAdjustmentLevel1 = _miMonthsOfAdjustmentLevel1; miMonthsOfAdjustmentLevel1.Clean = value; _miMonthsOfAdjustmentLevel1 = miMonthsOfAdjustmentLevel1;
                var miMonthsOfAdjustmentLevel2 = _miMonthsOfAdjustmentLevel2; miMonthsOfAdjustmentLevel2.Clean = value; _miMonthsOfAdjustmentLevel2 = miMonthsOfAdjustmentLevel2;
                var minimumLateCharge = _minimumLateCharge; minimumLateCharge.Clean = value; _minimumLateCharge = minimumLateCharge;
                var minimumPayment = _minimumPayment; minimumPayment.Clean = value; _minimumPayment = minimumPayment;
                var mIPFactorLocked = _mIPFactorLocked; mIPFactorLocked.Clean = value; _mIPFactorLocked = mIPFactorLocked;
                var mIPrepaidAmount = _mIPrepaidAmount; mIPrepaidAmount.Clean = value; _mIPrepaidAmount = mIPrepaidAmount;
                var miPrepaidIndicator = _miPrepaidIndicator; miPrepaidIndicator.Clean = value; _miPrepaidIndicator = miPrepaidIndicator;
                var miScheduledTerminationDate = _miScheduledTerminationDate; miScheduledTerminationDate.Clean = value; _miScheduledTerminationDate = miScheduledTerminationDate;
                var mmiIndicator = _mmiIndicator; mmiIndicator.Clean = value; _mmiIndicator = mmiIndicator;
                var monthlyTerm = _monthlyTerm; monthlyTerm.Clean = value; _monthlyTerm = monthlyTerm;
                var monthsOfMiPrepaid = _monthsOfMiPrepaid; monthsOfMiPrepaid.Clean = value; _monthsOfMiPrepaid = monthsOfMiPrepaid;
                var mortgageInsuranceCancelPercent = _mortgageInsuranceCancelPercent; mortgageInsuranceCancelPercent.Clean = value; _mortgageInsuranceCancelPercent = mortgageInsuranceCancelPercent;
                var namePreparedBy = _namePreparedBy; namePreparedBy.Clean = value; _namePreparedBy = namePreparedBy;
                var newConstructionIndicator = _newConstructionIndicator; newConstructionIndicator.Clean = value; _newConstructionIndicator = newConstructionIndicator;
                var numberOfPayments = _numberOfPayments; numberOfPayments.Clean = value; _numberOfPayments = numberOfPayments;
                var occupancyCertDate = _occupancyCertDate; occupancyCertDate.Clean = value; _occupancyCertDate = occupancyCertDate;
                var originalContractDate = _originalContractDate; originalContractDate.Clean = value; _originalContractDate = originalContractDate;
                var outstandingBalance = _outstandingBalance; outstandingBalance.Clean = value; _outstandingBalance = outstandingBalance;
                var paymentFrequencyType = _paymentFrequencyType; paymentFrequencyType.Clean = value; _paymentFrequencyType = paymentFrequencyType;
                var paymentIncreasePercent = _paymentIncreasePercent; paymentIncreasePercent.Clean = value; _paymentIncreasePercent = paymentIncreasePercent;
                var phonePreparedBy = _phonePreparedBy; phonePreparedBy.Clean = value; _phonePreparedBy = phonePreparedBy;
                var pmiIndicator = _pmiIndicator; pmiIndicator.Clean = value; _pmiIndicator = pmiIndicator;
                var pmiMidpointCancelationDate = _pmiMidpointCancelationDate; pmiMidpointCancelationDate.Clean = value; _pmiMidpointCancelationDate = pmiMidpointCancelationDate;
                var postConsummationDisclosureReceivedDate = _postConsummationDisclosureReceivedDate; postConsummationDisclosureReceivedDate.Clean = value; _postConsummationDisclosureReceivedDate = postConsummationDisclosureReceivedDate;
                var postConsummationDisclosureSentDate = _postConsummationDisclosureSentDate; postConsummationDisclosureSentDate.Clean = value; _postConsummationDisclosureSentDate = postConsummationDisclosureSentDate;
                var prepaidFinanceCharge = _prepaidFinanceCharge; prepaidFinanceCharge.Clean = value; _prepaidFinanceCharge = prepaidFinanceCharge;
                var propertyInsuranceIndicator = _propertyInsuranceIndicator; propertyInsuranceIndicator.Clean = value; _propertyInsuranceIndicator = propertyInsuranceIndicator;
                var rateLockGfeDueDate = _rateLockGfeDueDate; rateLockGfeDueDate.Clean = value; _rateLockGfeDueDate = rateLockGfeDueDate;
                var ratePercent = _ratePercent; ratePercent.Clean = value; _ratePercent = ratePercent;
                var recastPaidMonths = _recastPaidMonths; recastPaidMonths.Clean = value; _recastPaidMonths = recastPaidMonths;
                var recastStopMonths = _recastStopMonths; recastStopMonths.Clean = value; _recastStopMonths = recastStopMonths;
                var refundPaymentIndicator = _refundPaymentIndicator; refundPaymentIndicator.Clean = value; _refundPaymentIndicator = refundPaymentIndicator;
                var refundUnearnedMipIndicator = _refundUnearnedMipIndicator; refundUnearnedMipIndicator.Clean = value; _refundUnearnedMipIndicator = refundUnearnedMipIndicator;
                var regulationZInterestRatePeriods = _regulationZInterestRatePeriods; regulationZInterestRatePeriods.Clean = value; _regulationZInterestRatePeriods = regulationZInterestRatePeriods;
                var regulationZPayments = _regulationZPayments; regulationZPayments.Clean = value; _regulationZPayments = regulationZPayments;
                var regzTableType = _regzTableType; regzTableType.Clean = value; _regzTableType = regzTableType;
                var requiredDepositIndicator = _requiredDepositIndicator; requiredDepositIndicator.Clean = value; _requiredDepositIndicator = requiredDepositIndicator;
                var revisedClosingDisclosureReceivedDate = _revisedClosingDisclosureReceivedDate; revisedClosingDisclosureReceivedDate.Clean = value; _revisedClosingDisclosureReceivedDate = revisedClosingDisclosureReceivedDate;
                var revisedClosingDisclosureSentDate = _revisedClosingDisclosureSentDate; revisedClosingDisclosureSentDate.Clean = value; _revisedClosingDisclosureSentDate = revisedClosingDisclosureSentDate;
                var revisedGfeDueDate = _revisedGfeDueDate; revisedGfeDueDate.Clean = value; _revisedGfeDueDate = revisedGfeDueDate;
                var roundedMarginPlusIndexPercent = _roundedMarginPlusIndexPercent; roundedMarginPlusIndexPercent.Clean = value; _roundedMarginPlusIndexPercent = roundedMarginPlusIndexPercent;
                var safeHarborSentDate = _safeHarborSentDate; safeHarborSentDate.Clean = value; _safeHarborSentDate = safeHarborSentDate;
                var samplePayments = _samplePayments; samplePayments.Clean = value; _samplePayments = samplePayments;
                var securityType = _securityType; securityType.Clean = value; _securityType = securityType;
                var sSPLSentDate = _sSPLSentDate; sSPLSentDate.Clean = value; _sSPLSentDate = sSPLSentDate;
                var tilDate = _tilDate; tilDate.Clean = value; _tilDate = tilDate;
                var tilDisclosedComments = _tilDisclosedComments; tilDisclosedComments.Clean = value; _tilDisclosedComments = tilDisclosedComments;
                var tilDisclosureMethod = _tilDisclosureMethod; tilDisclosureMethod.Clean = value; _tilDisclosureMethod = tilDisclosureMethod;
                var tilLastDisclosedBorrowerReceivedDate = _tilLastDisclosedBorrowerReceivedDate; tilLastDisclosedBorrowerReceivedDate.Clean = value; _tilLastDisclosedBorrowerReceivedDate = tilLastDisclosedBorrowerReceivedDate;
                var tilLastDisclosedBy = _tilLastDisclosedBy; tilLastDisclosedBy.Clean = value; _tilLastDisclosedBy = tilLastDisclosedBy;
                var tilLastDisclosedDate = _tilLastDisclosedDate; tilLastDisclosedDate.Clean = value; _tilLastDisclosedDate = tilLastDisclosedDate;
                var tilRedisclosureProvidedDate = _tilRedisclosureProvidedDate; tilRedisclosureProvidedDate.Clean = value; _tilRedisclosureProvidedDate = tilRedisclosureProvidedDate;
                var tilRedisclosureReceivedDate = _tilRedisclosureReceivedDate; tilRedisclosureReceivedDate.Clean = value; _tilRedisclosureReceivedDate = tilRedisclosureReceivedDate;
                var totalBrokerFees = _totalBrokerFees; totalBrokerFees.Clean = value; _totalBrokerFees = totalBrokerFees;
                var totalLatePayment = _totalLatePayment; totalLatePayment.Clean = value; _totalLatePayment = totalLatePayment;
                var totalLenderFees = _totalLenderFees; totalLenderFees.Clean = value; _totalLenderFees = totalLenderFees;
                var totalOfPayments = _totalOfPayments; totalOfPayments.Clean = value; _totalOfPayments = totalOfPayments;
                var totalOfPrincipalAndInterest = _totalOfPrincipalAndInterest; totalOfPrincipalAndInterest.Clean = value; _totalOfPrincipalAndInterest = totalOfPrincipalAndInterest;
                var useCustomLenderProfile = _useCustomLenderProfile; useCustomLenderProfile.Clean = value; _useCustomLenderProfile = useCustomLenderProfile;
                var useDaysInYears = _useDaysInYears; useDaysInYears.Clean = value; _useDaysInYears = useDaysInYears;
                var usePitiForRatioIndicator = _usePitiForRatioIndicator; usePitiForRatioIndicator.Clean = value; _usePitiForRatioIndicator = usePitiForRatioIndicator;
                var variableRateFeatureIndicator = _variableRateFeatureIndicator; variableRateFeatureIndicator.Clean = value; _variableRateFeatureIndicator = variableRateFeatureIndicator;
                var yearlyTerm = _yearlyTerm; yearlyTerm.Clean = value; _yearlyTerm = yearlyTerm;
                var yearOfMaximumPayment = _yearOfMaximumPayment; yearOfMaximumPayment.Clean = value; _yearOfMaximumPayment = yearOfMaximumPayment;
                var years = _years; years.Clean = value; _years = years;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public RegulationZ()
        {
            Clean = true;
        }
    }
}