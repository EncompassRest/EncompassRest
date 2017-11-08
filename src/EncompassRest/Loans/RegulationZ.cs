using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class RegulationZ : IDirty
    {
        private DirtyValue<string> _acknowledgedDay;
        public string AcknowledgedDay { get { return _acknowledgedDay; } set { _acknowledgedDay = value; } }
        private DirtyValue<string> _acknowledgedMonth;
        public string AcknowledgedMonth { get { return _acknowledgedMonth; } set { _acknowledgedMonth = value; } }
        private DirtyValue<string> _acknowledgedYear;
        public string AcknowledgedYear { get { return _acknowledgedYear; } set { _acknowledgedYear = value; } }
        private DirtyValue<bool?> _acquisition;
        public bool? Acquisition { get { return _acquisition; } set { _acquisition = value; } }
        private DirtyValue<string> _additionalArmInformation;
        public string AdditionalArmInformation { get { return _additionalArmInformation; } set { _additionalArmInformation = value; } }
        private DirtyValue<bool?> _allDateAndNumericalDisclosuresIndicator;
        public bool? AllDateAndNumericalDisclosuresIndicator { get { return _allDateAndNumericalDisclosuresIndicator; } set { _allDateAndNumericalDisclosuresIndicator = value; } }
        private DirtyValue<decimal?> _amountFinanced;
        public decimal? AmountFinanced { get { return _amountFinanced; } set { _amountFinanced = value; } }
        private DirtyValue<decimal?> _aprPercent;
        public decimal? AprPercent { get { return _aprPercent; } set { _aprPercent = value; } }
        private DirtyValue<string> _armDisclosureDescription;
        public string ArmDisclosureDescription { get { return _armDisclosureDescription; } set { _armDisclosureDescription = value; } }
        private DirtyValue<string> _assumptionOnYourProperty;
        public string AssumptionOnYourProperty { get { return _assumptionOnYourProperty; } set { _assumptionOnYourProperty = value; } }
        private DirtyValue<DateTime?> _borrowerIntendToContinueDate;
        public DateTime? BorrowerIntendToContinueDate { get { return _borrowerIntendToContinueDate; } set { _borrowerIntendToContinueDate = value; } }
        private DirtyValue<bool?> _borrowerIntendToContinueIndicator;
        public bool? BorrowerIntendToContinueIndicator { get { return _borrowerIntendToContinueIndicator; } set { _borrowerIntendToContinueIndicator = value; } }
        private DirtyValue<string> _borrowerMiTerminationDate;
        public string BorrowerMiTerminationDate { get { return _borrowerMiTerminationDate; } set { _borrowerMiTerminationDate = value; } }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        public string CalculateBasedOnRemainingBalance { get { return _calculateBasedOnRemainingBalance; } set { _calculateBasedOnRemainingBalance = value; } }
        private DirtyValue<bool?> _chargesAddedToPaymentsIndicator;
        public bool? ChargesAddedToPaymentsIndicator { get { return _chargesAddedToPaymentsIndicator; } set { _chargesAddedToPaymentsIndicator = value; } }
        private DirtyValue<bool?> _chargesAtLoanClosingIndicator;
        public bool? ChargesAtLoanClosingIndicator { get { return _chargesAtLoanClosingIndicator; } set { _chargesAtLoanClosingIndicator = value; } }
        private DirtyValue<string> _circumstanceChangeReason;
        public string CircumstanceChangeReason { get { return _circumstanceChangeReason; } set { _circumstanceChangeReason = value; } }
        private DirtyValue<DateTime?> _circumstanceChangeReceivedDate;
        public DateTime? CircumstanceChangeReceivedDate { get { return _circumstanceChangeReceivedDate; } set { _circumstanceChangeReceivedDate = value; } }
        private DirtyValue<DateTime?> _closingDisclosureReceivedDate;
        public DateTime? ClosingDisclosureReceivedDate { get { return _closingDisclosureReceivedDate; } set { _closingDisclosureReceivedDate = value; } }
        private DirtyValue<DateTime?> _closingDisclosureSentDate;
        public DateTime? ClosingDisclosureSentDate { get { return _closingDisclosureSentDate; } set { _closingDisclosureSentDate = value; } }
        private DirtyValue<string> _constructionFirstIntChangeAdjType;
        public string ConstructionFirstIntChangeAdjType { get { return _constructionFirstIntChangeAdjType; } set { _constructionFirstIntChangeAdjType = value; } }
        private DirtyValue<string> _constructionLoanDescription;
        public string ConstructionLoanDescription { get { return _constructionLoanDescription; } set { _constructionLoanDescription = value; } }
        private DirtyValue<string> _constructionLoanMethod;
        public string ConstructionLoanMethod { get { return _constructionLoanMethod; } set { _constructionLoanMethod = value; } }
        private DirtyValue<int?> _constructionPeriodMonths;
        public int? ConstructionPeriodMonths { get { return _constructionPeriodMonths; } set { _constructionPeriodMonths = value; } }
        private DirtyValue<decimal?> _constructionRatePercent;
        public decimal? ConstructionRatePercent { get { return _constructionRatePercent; } set { _constructionRatePercent = value; } }
        private DirtyValue<bool?> _constructionRefinanceIndicator;
        public bool? ConstructionRefinanceIndicator { get { return _constructionRefinanceIndicator; } set { _constructionRefinanceIndicator = value; } }
        private DirtyValue<decimal?> _creditDisability;
        public decimal? CreditDisability { get { return _creditDisability; } set { _creditDisability = value; } }
        private DirtyValue<bool?> _creditDisabilityIndicator;
        public bool? CreditDisabilityIndicator { get { return _creditDisabilityIndicator; } set { _creditDisabilityIndicator = value; } }
        private DirtyValue<decimal?> _creditLife;
        public decimal? CreditLife { get { return _creditLife; } set { _creditLife = value; } }
        private DirtyValue<decimal?> _creditLifeAndCreditDisability;
        public decimal? CreditLifeAndCreditDisability { get { return _creditLifeAndCreditDisability; } set { _creditLifeAndCreditDisability = value; } }
        private DirtyValue<bool?> _creditLifeInsuranceIndicator;
        public bool? CreditLifeInsuranceIndicator { get { return _creditLifeInsuranceIndicator; } set { _creditLifeInsuranceIndicator = value; } }
        private DirtyValue<bool?> _customizePaymentScheduleIndicator;
        public bool? CustomizePaymentScheduleIndicator { get { return _customizePaymentScheduleIndicator; } set { _customizePaymentScheduleIndicator = value; } }
        private DirtyValue<bool?> _demandFeatureIndicator;
        public bool? DemandFeatureIndicator { get { return _demandFeatureIndicator; } set { _demandFeatureIndicator = value; } }
        private DirtyValue<decimal?> _disclosedAprPercent;
        public decimal? DisclosedAprPercent { get { return _disclosedAprPercent; } set { _disclosedAprPercent = value; } }
        private DirtyValue<bool?> _disclosedByBrokerIndicator;
        public bool? DisclosedByBrokerIndicator { get { return _disclosedByBrokerIndicator; } set { _disclosedByBrokerIndicator = value; } }
        private DirtyValue<string> _disclosedComments;
        public string DisclosedComments { get { return _disclosedComments; } set { _disclosedComments = value; } }
        private DirtyValue<decimal?> _disclosedDailyInterestCharge;
        public decimal? DisclosedDailyInterestCharge { get { return _disclosedDailyInterestCharge; } set { _disclosedDailyInterestCharge = value; } }
        private DirtyValue<decimal?> _disclosedFinanceCharge;
        public decimal? DisclosedFinanceCharge { get { return _disclosedFinanceCharge; } set { _disclosedFinanceCharge = value; } }
        private DirtyValue<bool?> _disclosedPrepayment;
        public bool? DisclosedPrepayment { get { return _disclosedPrepayment; } set { _disclosedPrepayment = value; } }
        private DirtyValue<string> _disclosedProduct;
        public string DisclosedProduct { get { return _disclosedProduct; } set { _disclosedProduct = value; } }
        private DirtyValue<string> _disclosureMethod;
        public string DisclosureMethod { get { return _disclosureMethod; } set { _disclosureMethod = value; } }
        private DirtyValue<string> _disclosureType;
        public string DisclosureType { get { return _disclosureType; } set { _disclosureType = value; } }
        private DirtyValue<int?> _discountPeriod;
        public int? DiscountPeriod { get { return _discountPeriod; } set { _discountPeriod = value; } }
        private DirtyValue<decimal?> _discountRatePercent;
        public decimal? DiscountRatePercent { get { return _discountRatePercent; } set { _discountRatePercent = value; } }
        private DirtyValue<string> _discountType;
        public string DiscountType { get { return _discountType; } set { _discountType = value; } }
        private DirtyValue<DateTime?> _dueDate;
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; } }
        private DirtyValue<DateTime?> _earliestClosingDate;
        public DateTime? EarliestClosingDate { get { return _earliestClosingDate; } set { _earliestClosingDate = value; } }
        private DirtyValue<DateTime?> _earliestFeeCollectionDate;
        public DateTime? EarliestFeeCollectionDate { get { return _earliestFeeCollectionDate; } set { _earliestFeeCollectionDate = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted1;
        public DateTime? eSignConsentBorrowerDateAccepted1 { get { return _eSignConsentBorrowerDateAccepted1; } set { _eSignConsentBorrowerDateAccepted1 = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted2;
        public DateTime? eSignConsentBorrowerDateAccepted2 { get { return _eSignConsentBorrowerDateAccepted2; } set { _eSignConsentBorrowerDateAccepted2 = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted3;
        public DateTime? eSignConsentBorrowerDateAccepted3 { get { return _eSignConsentBorrowerDateAccepted3; } set { _eSignConsentBorrowerDateAccepted3 = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted4;
        public DateTime? eSignConsentBorrowerDateAccepted4 { get { return _eSignConsentBorrowerDateAccepted4; } set { _eSignConsentBorrowerDateAccepted4 = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted5;
        public DateTime? eSignConsentBorrowerDateAccepted5 { get { return _eSignConsentBorrowerDateAccepted5; } set { _eSignConsentBorrowerDateAccepted5 = value; } }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted6;
        public DateTime? eSignConsentBorrowerDateAccepted6 { get { return _eSignConsentBorrowerDateAccepted6; } set { _eSignConsentBorrowerDateAccepted6 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress1;
        public string eSignConsentBorrowerIPAddress1 { get { return _eSignConsentBorrowerIPAddress1; } set { _eSignConsentBorrowerIPAddress1 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress2;
        public string eSignConsentBorrowerIPAddress2 { get { return _eSignConsentBorrowerIPAddress2; } set { _eSignConsentBorrowerIPAddress2 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress3;
        public string eSignConsentBorrowerIPAddress3 { get { return _eSignConsentBorrowerIPAddress3; } set { _eSignConsentBorrowerIPAddress3 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress4;
        public string eSignConsentBorrowerIPAddress4 { get { return _eSignConsentBorrowerIPAddress4; } set { _eSignConsentBorrowerIPAddress4 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress5;
        public string eSignConsentBorrowerIPAddress5 { get { return _eSignConsentBorrowerIPAddress5; } set { _eSignConsentBorrowerIPAddress5 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress6;
        public string eSignConsentBorrowerIPAddress6 { get { return _eSignConsentBorrowerIPAddress6; } set { _eSignConsentBorrowerIPAddress6 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource1;
        public string eSignConsentBorrowerSource1 { get { return _eSignConsentBorrowerSource1; } set { _eSignConsentBorrowerSource1 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource2;
        public string eSignConsentBorrowerSource2 { get { return _eSignConsentBorrowerSource2; } set { _eSignConsentBorrowerSource2 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource3;
        public string eSignConsentBorrowerSource3 { get { return _eSignConsentBorrowerSource3; } set { _eSignConsentBorrowerSource3 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource4;
        public string eSignConsentBorrowerSource4 { get { return _eSignConsentBorrowerSource4; } set { _eSignConsentBorrowerSource4 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource5;
        public string eSignConsentBorrowerSource5 { get { return _eSignConsentBorrowerSource5; } set { _eSignConsentBorrowerSource5 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerSource6;
        public string eSignConsentBorrowerSource6 { get { return _eSignConsentBorrowerSource6; } set { _eSignConsentBorrowerSource6 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus1;
        public string eSignConsentBorrowerStatus1 { get { return _eSignConsentBorrowerStatus1; } set { _eSignConsentBorrowerStatus1 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus2;
        public string eSignConsentBorrowerStatus2 { get { return _eSignConsentBorrowerStatus2; } set { _eSignConsentBorrowerStatus2 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus3;
        public string eSignConsentBorrowerStatus3 { get { return _eSignConsentBorrowerStatus3; } set { _eSignConsentBorrowerStatus3 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus4;
        public string eSignConsentBorrowerStatus4 { get { return _eSignConsentBorrowerStatus4; } set { _eSignConsentBorrowerStatus4 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus5;
        public string eSignConsentBorrowerStatus5 { get { return _eSignConsentBorrowerStatus5; } set { _eSignConsentBorrowerStatus5 = value; } }
        private DirtyValue<string> _eSignConsentBorrowerStatus6;
        public string eSignConsentBorrowerStatus6 { get { return _eSignConsentBorrowerStatus6; } set { _eSignConsentBorrowerStatus6 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted1;
        public DateTime? eSignConsentCoBorrowerDateAccepted1 { get { return _eSignConsentCoBorrowerDateAccepted1; } set { _eSignConsentCoBorrowerDateAccepted1 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted2;
        public DateTime? eSignConsentCoBorrowerDateAccepted2 { get { return _eSignConsentCoBorrowerDateAccepted2; } set { _eSignConsentCoBorrowerDateAccepted2 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted3;
        public DateTime? eSignConsentCoBorrowerDateAccepted3 { get { return _eSignConsentCoBorrowerDateAccepted3; } set { _eSignConsentCoBorrowerDateAccepted3 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted4;
        public DateTime? eSignConsentCoBorrowerDateAccepted4 { get { return _eSignConsentCoBorrowerDateAccepted4; } set { _eSignConsentCoBorrowerDateAccepted4 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted5;
        public DateTime? eSignConsentCoBorrowerDateAccepted5 { get { return _eSignConsentCoBorrowerDateAccepted5; } set { _eSignConsentCoBorrowerDateAccepted5 = value; } }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted6;
        public DateTime? eSignConsentCoBorrowerDateAccepted6 { get { return _eSignConsentCoBorrowerDateAccepted6; } set { _eSignConsentCoBorrowerDateAccepted6 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress1;
        public string eSignConsentCoBorrowerIPAddress1 { get { return _eSignConsentCoBorrowerIPAddress1; } set { _eSignConsentCoBorrowerIPAddress1 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress2;
        public string eSignConsentCoBorrowerIPAddress2 { get { return _eSignConsentCoBorrowerIPAddress2; } set { _eSignConsentCoBorrowerIPAddress2 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress3;
        public string eSignConsentCoBorrowerIPAddress3 { get { return _eSignConsentCoBorrowerIPAddress3; } set { _eSignConsentCoBorrowerIPAddress3 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress4;
        public string eSignConsentCoBorrowerIPAddress4 { get { return _eSignConsentCoBorrowerIPAddress4; } set { _eSignConsentCoBorrowerIPAddress4 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress5;
        public string eSignConsentCoBorrowerIPAddress5 { get { return _eSignConsentCoBorrowerIPAddress5; } set { _eSignConsentCoBorrowerIPAddress5 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress6;
        public string eSignConsentCoBorrowerIPAddress6 { get { return _eSignConsentCoBorrowerIPAddress6; } set { _eSignConsentCoBorrowerIPAddress6 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource1;
        public string eSignConsentCoBorrowerSource1 { get { return _eSignConsentCoBorrowerSource1; } set { _eSignConsentCoBorrowerSource1 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource2;
        public string eSignConsentCoBorrowerSource2 { get { return _eSignConsentCoBorrowerSource2; } set { _eSignConsentCoBorrowerSource2 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource3;
        public string eSignConsentCoBorrowerSource3 { get { return _eSignConsentCoBorrowerSource3; } set { _eSignConsentCoBorrowerSource3 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource4;
        public string eSignConsentCoBorrowerSource4 { get { return _eSignConsentCoBorrowerSource4; } set { _eSignConsentCoBorrowerSource4 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource5;
        public string eSignConsentCoBorrowerSource5 { get { return _eSignConsentCoBorrowerSource5; } set { _eSignConsentCoBorrowerSource5 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerSource6;
        public string eSignConsentCoBorrowerSource6 { get { return _eSignConsentCoBorrowerSource6; } set { _eSignConsentCoBorrowerSource6 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus1;
        public string eSignConsentCoBorrowerStatus1 { get { return _eSignConsentCoBorrowerStatus1; } set { _eSignConsentCoBorrowerStatus1 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus2;
        public string eSignConsentCoBorrowerStatus2 { get { return _eSignConsentCoBorrowerStatus2; } set { _eSignConsentCoBorrowerStatus2 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus3;
        public string eSignConsentCoBorrowerStatus3 { get { return _eSignConsentCoBorrowerStatus3; } set { _eSignConsentCoBorrowerStatus3 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus4;
        public string eSignConsentCoBorrowerStatus4 { get { return _eSignConsentCoBorrowerStatus4; } set { _eSignConsentCoBorrowerStatus4 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus5;
        public string eSignConsentCoBorrowerStatus5 { get { return _eSignConsentCoBorrowerStatus5; } set { _eSignConsentCoBorrowerStatus5 = value; } }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus6;
        public string eSignConsentCoBorrowerStatus6 { get { return _eSignConsentCoBorrowerStatus6; } set { _eSignConsentCoBorrowerStatus6 = value; } }
        private DirtyValue<DateTime?> _eSignConsentDate;
        public DateTime? eSignConsentDate { get { return _eSignConsentDate; } set { _eSignConsentDate = value; } }
        private DirtyValue<decimal?> _extraPaymentForEarlyPayOff;
        public decimal? ExtraPaymentForEarlyPayOff { get { return _extraPaymentForEarlyPayOff; } set { _extraPaymentForEarlyPayOff = value; } }
        private DirtyValue<DateTime?> _feeCollectedDate;
        public DateTime? FeeCollectedDate { get { return _feeCollectedDate; } set { _feeCollectedDate = value; } }
        private DirtyValue<decimal?> _filingFees;
        public decimal? FilingFees { get { return _filingFees; } set { _filingFees = value; } }
        private DirtyValue<DateTime?> _finalPaymentDate;
        public DateTime? FinalPaymentDate { get { return _finalPaymentDate; } set { _finalPaymentDate = value; } }
        private DirtyValue<decimal?> _financeCharge;
        public decimal? FinanceCharge { get { return _financeCharge; } set { _financeCharge = value; } }
        private DirtyValue<decimal?> _financedAllGuaranteeFeeAmount;
        public decimal? FinancedAllGuaranteeFeeAmount { get { return _financedAllGuaranteeFeeAmount; } set { _financedAllGuaranteeFeeAmount = value; } }
        private DirtyValue<decimal?> _financedAllGuaranteeFeePercent;
        public decimal? FinancedAllGuaranteeFeePercent { get { return _financedAllGuaranteeFeePercent; } set { _financedAllGuaranteeFeePercent = value; } }
        private DirtyValue<decimal?> _financedAllTotalLoanAmount;
        public decimal? FinancedAllTotalLoanAmount { get { return _financedAllTotalLoanAmount; } set { _financedAllTotalLoanAmount = value; } }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeeAmount;
        public decimal? FinancedPortionGuaranteeFeeAmount { get { return _financedPortionGuaranteeFeeAmount; } set { _financedPortionGuaranteeFeeAmount = value; } }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeePercent;
        public decimal? FinancedPortionGuaranteeFeePercent { get { return _financedPortionGuaranteeFeePercent; } set { _financedPortionGuaranteeFeePercent = value; } }
        private DirtyValue<decimal?> _financedPortionTotalLoanAmount;
        public decimal? FinancedPortionTotalLoanAmount { get { return _financedPortionTotalLoanAmount; } set { _financedPortionTotalLoanAmount = value; } }
        private DirtyValue<string> _financingType;
        public string FinancingType { get { return _financingType; } set { _financingType = value; } }
        private DirtyValue<DateTime?> _firstAmortizationPaymentDate;
        public DateTime? FirstAmortizationPaymentDate { get { return _firstAmortizationPaymentDate; } set { _firstAmortizationPaymentDate = value; } }
        private DirtyValue<bool?> _floodInsuranceIndicator;
        public bool? FloodInsuranceIndicator { get { return _floodInsuranceIndicator; } set { _floodInsuranceIndicator = value; } }
        private DirtyValue<DateTime?> _gfeApplicationDate;
        public DateTime? GfeApplicationDate { get { return _gfeApplicationDate; } set { _gfeApplicationDate = value; } }
        private DirtyValue<bool?> _gfeChangedCircumstanceIndicator;
        public bool? GfeChangedCircumstanceIndicator { get { return _gfeChangedCircumstanceIndicator; } set { _gfeChangedCircumstanceIndicator = value; } }
        private DirtyValue<string> _gfeChangedCircumstanceItem;
        public string GfeChangedCircumstanceItem { get { return _gfeChangedCircumstanceItem; } set { _gfeChangedCircumstanceItem = value; } }
        private DirtyValue<string> _gFEChangedCirsumstanceItemCode;
        public string GFEChangedCirsumstanceItemCode { get { return _gFEChangedCirsumstanceItemCode; } set { _gFEChangedCirsumstanceItemCode = value; } }
        private DirtyValue<DateTime?> _gfeDate;
        public DateTime? GfeDate { get { return _gfeDate; } set { _gfeDate = value; } }
        private DirtyValue<DateTime?> _gfeExpirationDate;
        public DateTime? GfeExpirationDate { get { return _gfeExpirationDate; } set { _gfeExpirationDate = value; } }
        private DirtyValue<string> _gfeExpirationPeriod;
        public string GfeExpirationPeriod { get { return _gfeExpirationPeriod; } set { _gfeExpirationPeriod = value; } }
        private DirtyValue<bool?> _gfeRateLockRedisclosureRequiredIndicator;
        public bool? GfeRateLockRedisclosureRequiredIndicator { get { return _gfeRateLockRedisclosureRequiredIndicator; } set { _gfeRateLockRedisclosureRequiredIndicator = value; } }
        private DirtyValue<DateTime?> _gfeRedisclosureProvidedDate;
        public DateTime? GfeRedisclosureProvidedDate { get { return _gfeRedisclosureProvidedDate; } set { _gfeRedisclosureProvidedDate = value; } }
        private DirtyValue<DateTime?> _gfeRedisclosureReceivedDate;
        public DateTime? GfeRedisclosureReceivedDate { get { return _gfeRedisclosureReceivedDate; } set { _gfeRedisclosureReceivedDate = value; } }
        private DirtyValue<DateTime?> _highCostDisclosure;
        public DateTime? HighCostDisclosure { get { return _highCostDisclosure; } set { _highCostDisclosure = value; } }
        private DirtyValue<DateTime?> _homeCounselingProvidedDate;
        public DateTime? HomeCounselingProvidedDate { get { return _homeCounselingProvidedDate; } set { _homeCounselingProvidedDate = value; } }
        private DirtyValue<bool?> _hud1ToleranceViolatedIndicator;
        public bool? Hud1ToleranceViolatedIndicator { get { return _hud1ToleranceViolatedIndicator; } set { _hud1ToleranceViolatedIndicator = value; } }
        private DirtyValue<string> _hudToleranceResolutionComments;
        public string HudToleranceResolutionComments { get { return _hudToleranceResolutionComments; } set { _hudToleranceResolutionComments = value; } }
        private DirtyValue<DateTime?> _hudToleranceResolutionDate;
        public DateTime? HudToleranceResolutionDate { get { return _hudToleranceResolutionDate; } set { _hudToleranceResolutionDate = value; } }
        private DirtyValue<string> _hudToleranceResolvedBy;
        public string HudToleranceResolvedBy { get { return _hudToleranceResolvedBy; } set { _hudToleranceResolvedBy = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _ifYouPurchaseIndicator;
        public bool? IfYouPurchaseIndicator { get { return _ifYouPurchaseIndicator; } set { _ifYouPurchaseIndicator = value; } }
        private DirtyValue<string> _ifYouPurchaseType;
        public string IfYouPurchaseType { get { return _ifYouPurchaseType; } set { _ifYouPurchaseType = value; } }
        private DirtyValue<bool?> _includeMiIndicator;
        public bool? IncludeMiIndicator { get { return _includeMiIndicator; } set { _includeMiIndicator = value; } }
        private DirtyValue<bool?> _includePmiIndicator;
        public bool? IncludePmiIndicator { get { return _includePmiIndicator; } set { _includePmiIndicator = value; } }
        private DirtyValue<bool?> _includeTaxesInsuranceIndicator;
        public bool? IncludeTaxesInsuranceIndicator { get { return _includeTaxesInsuranceIndicator; } set { _includeTaxesInsuranceIndicator = value; } }
        private DirtyValue<DateTime?> _initialAVMProvidedDate;
        public DateTime? InitialAVMProvidedDate { get { return _initialAVMProvidedDate; } set { _initialAVMProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialDisclosureDueDate;
        public DateTime? InitialDisclosureDueDate { get { return _initialDisclosureDueDate; } set { _initialDisclosureDueDate = value; } }
        private DirtyValue<DateTime?> _initialDisclosureProvidedDate;
        public DateTime? InitialDisclosureProvidedDate { get { return _initialDisclosureProvidedDate; } set { _initialDisclosureProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeAffiliatedBusinessProvidedDate;
        public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get { return _initialGfeAffiliatedBusinessProvidedDate; } set { _initialGfeAffiliatedBusinessProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGFEAppraisalProvidedDate;
        public DateTime? InitialGFEAppraisalProvidedDate { get { return _initialGFEAppraisalProvidedDate; } set { _initialGFEAppraisalProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeCharmBookletProvidedDate;
        public DateTime? InitialGfeCharmBookletProvidedDate { get { return _initialGfeCharmBookletProvidedDate; } set { _initialGfeCharmBookletProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeDisclosureProvidedDate;
        public DateTime? InitialGfeDisclosureProvidedDate { get { return _initialGfeDisclosureProvidedDate; } set { _initialGfeDisclosureProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeDisclosureReceivedDate;
        public DateTime? InitialGfeDisclosureReceivedDate { get { return _initialGfeDisclosureReceivedDate; } set { _initialGfeDisclosureReceivedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeHelocBrochureProvidedDate;
        public DateTime? InitialGfeHelocBrochureProvidedDate { get { return _initialGfeHelocBrochureProvidedDate; } set { _initialGfeHelocBrochureProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialGfeHudSpecialBookletProvidedDate;
        public DateTime? InitialGfeHudSpecialBookletProvidedDate { get { return _initialGfeHudSpecialBookletProvidedDate; } set { _initialGfeHudSpecialBookletProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialSubsequentAppraisalProvidedDate;
        public DateTime? InitialSubsequentAppraisalProvidedDate { get { return _initialSubsequentAppraisalProvidedDate; } set { _initialSubsequentAppraisalProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialTilDisclosureProvidedDate;
        public DateTime? InitialTilDisclosureProvidedDate { get { return _initialTilDisclosureProvidedDate; } set { _initialTilDisclosureProvidedDate = value; } }
        private DirtyValue<DateTime?> _initialTilDisclosureReceivedDate;
        public DateTime? InitialTilDisclosureReceivedDate { get { return _initialTilDisclosureReceivedDate; } set { _initialTilDisclosureReceivedDate = value; } }
        private DirtyValue<string> _insuranceRequiredDescription;
        public string InsuranceRequiredDescription { get { return _insuranceRequiredDescription; } set { _insuranceRequiredDescription = value; } }
        private DirtyValue<string> _interestInNameOf;
        public string InterestInNameOf { get { return _interestInNameOf; } set { _interestInNameOf = value; } }
        private DirtyValue<bool?> _interestOnly;
        public bool? InterestOnly { get { return _interestOnly; } set { _interestOnly = value; } }
        private DirtyValue<bool?> _interestOnlyIndicator;
        public bool? InterestOnlyIndicator { get { return _interestOnlyIndicator; } set { _interestOnlyIndicator = value; } }
        private DirtyValue<int?> _interestOnlyMonths;
        public int? InterestOnlyMonths { get { return _interestOnlyMonths; } set { _interestOnlyMonths = value; } }
        private DirtyValue<string> _interestRateType;
        public string InterestRateType { get { return _interestRateType; } set { _interestRateType = value; } }
        private DirtyValue<decimal?> _interestReserveAmount;
        public decimal? InterestReserveAmount { get { return _interestReserveAmount; } set { _interestReserveAmount = value; } }
        private DirtyValue<string> _lastDisclosedBy;
        public string LastDisclosedBy { get { return _lastDisclosedBy; } set { _lastDisclosedBy = value; } }
        private DirtyValue<DateTime?> _lastDisclosedDate;
        public DateTime? LastDisclosedDate { get { return _lastDisclosedDate; } set { _lastDisclosedDate = value; } }
        private DirtyValue<DateTime?> _lastDisclosedGfeReceivedDate;
        public DateTime? LastDisclosedGfeReceivedDate { get { return _lastDisclosedGfeReceivedDate; } set { _lastDisclosedGfeReceivedDate = value; } }
        private DirtyValue<decimal?> _lateChargeBasis;
        public decimal? LateChargeBasis { get { return _lateChargeBasis; } set { _lateChargeBasis = value; } }
        private DirtyValue<string> _lateChargeComments;
        public string LateChargeComments { get { return _lateChargeComments; } set { _lateChargeComments = value; } }
        private DirtyValue<int?> _lateChargeDays;
        public int? LateChargeDays { get { return _lateChargeDays; } set { _lateChargeDays = value; } }
        private DirtyValue<decimal?> _lateChargePercent;
        public decimal? LateChargePercent { get { return _lateChargePercent; } set { _lateChargePercent = value; } }
        private DirtyValue<string> _lateChargeType;
        public string LateChargeType { get { return _lateChargeType; } set { _lateChargeType = value; } }
        private DirtyValue<decimal?> _lateFee;
        public decimal? LateFee { get { return _lateFee; } set { _lateFee = value; } }
        private DirtyValue<string> _lEIntentToProceedComment;
        public string LEIntentToProceedComment { get { return _lEIntentToProceedComment; } set { _lEIntentToProceedComment = value; } }
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        public bool? LenderPaidMortgageInsuranceIndicator { get { return _lenderPaidMortgageInsuranceIndicator; } set { _lenderPaidMortgageInsuranceIndicator = value; } }
        private DirtyValue<decimal?> _lendersInspectionFee;
        public decimal? LendersInspectionFee { get { return _lendersInspectionFee; } set { _lendersInspectionFee = value; } }
        private DirtyValue<string> _lEReceivedBy;
        public string LEReceivedBy { get { return _lEReceivedBy; } set { _lEReceivedBy = value; } }
        private DirtyValue<string> _lEReceivedMethod;
        public string LEReceivedMethod { get { return _lEReceivedMethod; } set { _lEReceivedMethod = value; } }
        private DirtyValue<string> _lEReceivedMethodOther;
        public string LEReceivedMethodOther { get { return _lEReceivedMethodOther; } set { _lEReceivedMethodOther = value; } }
        private DirtyValue<DateTime?> _lESentOnDate;
        public DateTime? LESentOnDate { get { return _lESentOnDate; } set { _lESentOnDate = value; } }
        private DirtyValue<decimal?> _marginPlusIndexPercent;
        public decimal? MarginPlusIndexPercent { get { return _marginPlusIndexPercent; } set { _marginPlusIndexPercent = value; } }
        private DirtyValue<decimal?> _maximumLateCharge;
        public decimal? MaximumLateCharge { get { return _maximumLateCharge; } set { _maximumLateCharge = value; } }
        private DirtyValue<decimal?> _maximumPayment;
        public decimal? MaximumPayment { get { return _maximumPayment; } set { _maximumPayment = value; } }
        private DirtyValue<bool?> _meansAnEstimateIndicator;
        public bool? MeansAnEstimateIndicator { get { return _meansAnEstimateIndicator; } set { _meansAnEstimateIndicator = value; } }
        private DirtyValue<decimal?> _miAdjustmentFactorLevel2;
        public decimal? MiAdjustmentFactorLevel2 { get { return _miAdjustmentFactorLevel2; } set { _miAdjustmentFactorLevel2 = value; } }
        private DirtyValue<bool?> _miDecliningRenewalsIndicator;
        public bool? MiDecliningRenewalsIndicator { get { return _miDecliningRenewalsIndicator; } set { _miDecliningRenewalsIndicator = value; } }
        private DirtyValue<string> _midpointCancellation;
        public string MidpointCancellation { get { return _midpointCancellation; } set { _midpointCancellation = value; } }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel1;
        public decimal? MiMonthlyPaymentLevel1 { get { return _miMonthlyPaymentLevel1; } set { _miMonthlyPaymentLevel1 = value; } }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel2;
        public decimal? MiMonthlyPaymentLevel2 { get { return _miMonthlyPaymentLevel2; } set { _miMonthlyPaymentLevel2 = value; } }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel1;
        public int? MiMonthsOfAdjustmentLevel1 { get { return _miMonthsOfAdjustmentLevel1; } set { _miMonthsOfAdjustmentLevel1 = value; } }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel2;
        public int? MiMonthsOfAdjustmentLevel2 { get { return _miMonthsOfAdjustmentLevel2; } set { _miMonthsOfAdjustmentLevel2 = value; } }
        private DirtyValue<decimal?> _minimumLateCharge;
        public decimal? MinimumLateCharge { get { return _minimumLateCharge; } set { _minimumLateCharge = value; } }
        private DirtyValue<decimal?> _minimumPayment;
        public decimal? MinimumPayment { get { return _minimumPayment; } set { _minimumPayment = value; } }
        private DirtyValue<bool?> _mIPFactorLocked;
        public bool? MIPFactorLocked { get { return _mIPFactorLocked; } set { _mIPFactorLocked = value; } }
        private DirtyValue<decimal?> _mIPrepaidAmount;
        public decimal? MIPrepaidAmount { get { return _mIPrepaidAmount; } set { _mIPrepaidAmount = value; } }
        private DirtyValue<bool?> _miPrepaidIndicator;
        public bool? MiPrepaidIndicator { get { return _miPrepaidIndicator; } set { _miPrepaidIndicator = value; } }
        private DirtyValue<string> _miScheduledTerminationDate;
        public string MiScheduledTerminationDate { get { return _miScheduledTerminationDate; } set { _miScheduledTerminationDate = value; } }
        private DirtyValue<bool?> _mmiIndicator;
        public bool? MmiIndicator { get { return _mmiIndicator; } set { _mmiIndicator = value; } }
        private DirtyValue<decimal?> _monthlyTerm;
        public decimal? MonthlyTerm { get { return _monthlyTerm; } set { _monthlyTerm = value; } }
        private DirtyValue<int?> _monthsOfMiPrepaid;
        public int? MonthsOfMiPrepaid { get { return _monthsOfMiPrepaid; } set { _monthsOfMiPrepaid = value; } }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        public decimal? MortgageInsuranceCancelPercent { get { return _mortgageInsuranceCancelPercent; } set { _mortgageInsuranceCancelPercent = value; } }
        private DirtyValue<string> _namePreparedBy;
        public string NamePreparedBy { get { return _namePreparedBy; } set { _namePreparedBy = value; } }
        private DirtyValue<string> _newConstructionIndicator;
        public string NewConstructionIndicator { get { return _newConstructionIndicator; } set { _newConstructionIndicator = value; } }
        private DirtyValue<int?> _numberOfPayments;
        public int? NumberOfPayments { get { return _numberOfPayments; } set { _numberOfPayments = value; } }
        private DirtyValue<DateTime?> _occupancyCertDate;
        public DateTime? OccupancyCertDate { get { return _occupancyCertDate; } set { _occupancyCertDate = value; } }
        private DirtyValue<DateTime?> _originalContractDate;
        public DateTime? OriginalContractDate { get { return _originalContractDate; } set { _originalContractDate = value; } }
        private DirtyValue<decimal?> _outstandingBalance;
        public decimal? OutstandingBalance { get { return _outstandingBalance; } set { _outstandingBalance = value; } }
        private DirtyValue<string> _paymentFrequencyType;
        public string PaymentFrequencyType { get { return _paymentFrequencyType; } set { _paymentFrequencyType = value; } }
        private DirtyValue<decimal?> _paymentIncreasePercent;
        public decimal? PaymentIncreasePercent { get { return _paymentIncreasePercent; } set { _paymentIncreasePercent = value; } }
        private DirtyValue<string> _phonePreparedBy;
        public string PhonePreparedBy { get { return _phonePreparedBy; } set { _phonePreparedBy = value; } }
        private DirtyValue<bool?> _pmiIndicator;
        public bool? PmiIndicator { get { return _pmiIndicator; } set { _pmiIndicator = value; } }
        private DirtyValue<DateTime?> _pmiMidpointCancelationDate;
        public DateTime? PmiMidpointCancelationDate { get { return _pmiMidpointCancelationDate; } set { _pmiMidpointCancelationDate = value; } }
        private DirtyValue<DateTime?> _postConsummationDisclosureReceivedDate;
        public DateTime? PostConsummationDisclosureReceivedDate { get { return _postConsummationDisclosureReceivedDate; } set { _postConsummationDisclosureReceivedDate = value; } }
        private DirtyValue<DateTime?> _postConsummationDisclosureSentDate;
        public DateTime? PostConsummationDisclosureSentDate { get { return _postConsummationDisclosureSentDate; } set { _postConsummationDisclosureSentDate = value; } }
        private DirtyValue<decimal?> _prepaidFinanceCharge;
        public decimal? PrepaidFinanceCharge { get { return _prepaidFinanceCharge; } set { _prepaidFinanceCharge = value; } }
        private DirtyValue<bool?> _propertyInsuranceIndicator;
        public bool? PropertyInsuranceIndicator { get { return _propertyInsuranceIndicator; } set { _propertyInsuranceIndicator = value; } }
        private DirtyValue<DateTime?> _rateLockGfeDueDate;
        public DateTime? RateLockGfeDueDate { get { return _rateLockGfeDueDate; } set { _rateLockGfeDueDate = value; } }
        private DirtyValue<decimal?> _ratePercent;
        public decimal? RatePercent { get { return _ratePercent; } set { _ratePercent = value; } }
        private DirtyValue<int?> _recastPaidMonths;
        public int? RecastPaidMonths { get { return _recastPaidMonths; } set { _recastPaidMonths = value; } }
        private DirtyValue<int?> _recastStopMonths;
        public int? RecastStopMonths { get { return _recastStopMonths; } set { _recastStopMonths = value; } }
        private DirtyValue<bool?> _refundPaymentIndicator;
        public bool? RefundPaymentIndicator { get { return _refundPaymentIndicator; } set { _refundPaymentIndicator = value; } }
        private DirtyValue<bool?> _refundUnearnedMipIndicator;
        public bool? RefundUnearnedMipIndicator { get { return _refundUnearnedMipIndicator; } set { _refundUnearnedMipIndicator = value; } }
        private DirtyList<RegulationZInterestRatePeriod> _regulationZInterestRatePeriods;
        public IList<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get { return _regulationZInterestRatePeriods ?? (_regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>()); } set { _regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>(value); } }
        private DirtyList<RegulationZPayment> _regulationZPayments;
        public IList<RegulationZPayment> RegulationZPayments { get { return _regulationZPayments ?? (_regulationZPayments = new DirtyList<RegulationZPayment>()); } set { _regulationZPayments = new DirtyList<RegulationZPayment>(value); } }
        private DirtyValue<string> _regzTableType;
        public string RegzTableType { get { return _regzTableType; } set { _regzTableType = value; } }
        private DirtyValue<bool?> _requiredDepositIndicator;
        public bool? RequiredDepositIndicator { get { return _requiredDepositIndicator; } set { _requiredDepositIndicator = value; } }
        private DirtyValue<DateTime?> _revisedClosingDisclosureReceivedDate;
        public DateTime? RevisedClosingDisclosureReceivedDate { get { return _revisedClosingDisclosureReceivedDate; } set { _revisedClosingDisclosureReceivedDate = value; } }
        private DirtyValue<DateTime?> _revisedClosingDisclosureSentDate;
        public DateTime? RevisedClosingDisclosureSentDate { get { return _revisedClosingDisclosureSentDate; } set { _revisedClosingDisclosureSentDate = value; } }
        private DirtyValue<DateTime?> _revisedGfeDueDate;
        public DateTime? RevisedGfeDueDate { get { return _revisedGfeDueDate; } set { _revisedGfeDueDate = value; } }
        private DirtyValue<decimal?> _roundedMarginPlusIndexPercent;
        public decimal? RoundedMarginPlusIndexPercent { get { return _roundedMarginPlusIndexPercent; } set { _roundedMarginPlusIndexPercent = value; } }
        private DirtyValue<DateTime?> _safeHarborSentDate;
        public DateTime? SafeHarborSentDate { get { return _safeHarborSentDate; } set { _safeHarborSentDate = value; } }
        private DirtyValue<decimal?> _samplePayments;
        public decimal? SamplePayments { get { return _samplePayments; } set { _samplePayments = value; } }
        private DirtyValue<string> _securityType;
        public string SecurityType { get { return _securityType; } set { _securityType = value; } }
        private DirtyValue<DateTime?> _sSPLSentDate;
        public DateTime? SSPLSentDate { get { return _sSPLSentDate; } set { _sSPLSentDate = value; } }
        private DirtyValue<DateTime?> _tilDate;
        public DateTime? TilDate { get { return _tilDate; } set { _tilDate = value; } }
        private DirtyValue<string> _tilDisclosedComments;
        public string TilDisclosedComments { get { return _tilDisclosedComments; } set { _tilDisclosedComments = value; } }
        private DirtyValue<string> _tilDisclosureMethod;
        public string TilDisclosureMethod { get { return _tilDisclosureMethod; } set { _tilDisclosureMethod = value; } }
        private DirtyValue<DateTime?> _tilLastDisclosedBorrowerReceivedDate;
        public DateTime? TilLastDisclosedBorrowerReceivedDate { get { return _tilLastDisclosedBorrowerReceivedDate; } set { _tilLastDisclosedBorrowerReceivedDate = value; } }
        private DirtyValue<string> _tilLastDisclosedBy;
        public string TilLastDisclosedBy { get { return _tilLastDisclosedBy; } set { _tilLastDisclosedBy = value; } }
        private DirtyValue<DateTime?> _tilLastDisclosedDate;
        public DateTime? TilLastDisclosedDate { get { return _tilLastDisclosedDate; } set { _tilLastDisclosedDate = value; } }
        private DirtyValue<DateTime?> _tilRedisclosureProvidedDate;
        public DateTime? TilRedisclosureProvidedDate { get { return _tilRedisclosureProvidedDate; } set { _tilRedisclosureProvidedDate = value; } }
        private DirtyValue<DateTime?> _tilRedisclosureReceivedDate;
        public DateTime? TilRedisclosureReceivedDate { get { return _tilRedisclosureReceivedDate; } set { _tilRedisclosureReceivedDate = value; } }
        private DirtyValue<decimal?> _totalBrokerFees;
        public decimal? TotalBrokerFees { get { return _totalBrokerFees; } set { _totalBrokerFees = value; } }
        private DirtyValue<decimal?> _totalLatePayment;
        public decimal? TotalLatePayment { get { return _totalLatePayment; } set { _totalLatePayment = value; } }
        private DirtyValue<decimal?> _totalLenderFees;
        public decimal? TotalLenderFees { get { return _totalLenderFees; } set { _totalLenderFees = value; } }
        private DirtyValue<decimal?> _totalOfPayments;
        public decimal? TotalOfPayments { get { return _totalOfPayments; } set { _totalOfPayments = value; } }
        private DirtyValue<decimal?> _totalOfPrincipalAndInterest;
        public decimal? TotalOfPrincipalAndInterest { get { return _totalOfPrincipalAndInterest; } set { _totalOfPrincipalAndInterest = value; } }
        private DirtyValue<bool?> _useCustomLenderProfile;
        public bool? UseCustomLenderProfile { get { return _useCustomLenderProfile; } set { _useCustomLenderProfile = value; } }
        private DirtyValue<string> _useDaysInYears;
        public string UseDaysInYears { get { return _useDaysInYears; } set { _useDaysInYears = value; } }
        private DirtyValue<bool?> _usePitiForRatioIndicator;
        public bool? UsePitiForRatioIndicator { get { return _usePitiForRatioIndicator; } set { _usePitiForRatioIndicator = value; } }
        private DirtyValue<bool?> _variableRateFeatureIndicator;
        public bool? VariableRateFeatureIndicator { get { return _variableRateFeatureIndicator; } set { _variableRateFeatureIndicator = value; } }
        private DirtyValue<decimal?> _yearlyTerm;
        public decimal? YearlyTerm { get { return _yearlyTerm; } set { _yearlyTerm = value; } }
        private DirtyValue<string> _yearOfMaximumPayment;
        public string YearOfMaximumPayment { get { return _yearOfMaximumPayment; } set { _yearOfMaximumPayment = value; } }
        private DirtyValue<int?> _years;
        public int? Years { get { return _years; } set { _years = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _acknowledgedDay.Dirty
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
                    || _regulationZPayments?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}