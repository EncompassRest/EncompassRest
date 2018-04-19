using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegulationZ
    /// </summary>
    public sealed partial class RegulationZ : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _acknowledgedDay;
        /// <summary>
        /// REGZ Acknowledgement Day [REGZ_DAY]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Acknowledgement Day")]
        public string AcknowledgedDay { get => _acknowledgedDay; set => _acknowledgedDay = value; }
        private DirtyValue<string> _acknowledgedMonth;
        /// <summary>
        /// REGZ Acknowledgement Mo [REGZ_MONTH]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Acknowledgement Mo")]
        public string AcknowledgedMonth { get => _acknowledgedMonth; set => _acknowledgedMonth = value; }
        private DirtyValue<string> _acknowledgedYear;
        /// <summary>
        /// REGZ Acknowledgement Yr [REGZ_YR]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Acknowledgement Yr")]
        public string AcknowledgedYear { get => _acknowledgedYear; set => _acknowledgedYear = value; }
        private DirtyValue<bool?> _acquisition;
        /// <summary>
        /// Initial Acquisition of Land [1964]
        /// </summary>
        [LoanFieldProperty(Description = "Initial Acquisition of Land")]
        public bool? Acquisition { get => _acquisition; set => _acquisition = value; }
        private DirtyValue<string> _additionalArmInformation;
        /// <summary>
        /// REGZ Pymt Sched Additional Info [666]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Pymt Sched Additional Info")]
        public string AdditionalArmInformation { get => _additionalArmInformation; set => _additionalArmInformation = value; }
        private DirtyValue<bool?> _allDateAndNumericalDisclosuresIndicator;
        /// <summary>
        /// Trans Details Dates/Num Discl Are Estimates [679]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Dates/Num Discl Are Estimates", OptionsJson = "{\"true\":\"all dates and numerical disclosures except the late payment disclosures are estimates.\"}")]
        public bool? AllDateAndNumericalDisclosuresIndicator { get => _allDateAndNumericalDisclosuresIndicator; set => _allDateAndNumericalDisclosuresIndicator = value; }
        private DirtyValue<decimal?> _amountFinanced;
        /// <summary>
        /// REGZ Total Amt Financed [948]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "REGZ Total Amt Financed")]
        public decimal? AmountFinanced { get => _amountFinanced; set => _amountFinanced = value; }
        private DirtyValue<decimal?> _aprPercent;
        /// <summary>
        /// Trans Details APR [799]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details APR")]
        public decimal? AprPercent { get => _aprPercent; set => _aprPercent = value; }
        private DirtyValue<string> _aprPercentUI;
        /// <summary>
        /// Trans Details APR - Display field with KBYO rounding rules [KBYO.XD799]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details APR - Display field with KBYO rounding rules")]
        public string AprPercentUI { get => _aprPercentUI; set => _aprPercentUI = value; }
        private DirtyValue<string> _armDisclosureDescription;
        /// <summary>
        /// Prequal ARM Index [1960]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal ARM Index")]
        public string ArmDisclosureDescription { get => _armDisclosureDescription; set => _armDisclosureDescription = value; }
        private DirtyValue<StringEnumValue<AssumptionOnYourProperty>> _assumptionOnYourProperty;
        /// <summary>
        /// Trans Details Assumption May/May Not [677]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Assumption May/May Not")]
        public StringEnumValue<AssumptionOnYourProperty> AssumptionOnYourProperty { get => _assumptionOnYourProperty; set => _assumptionOnYourProperty = value; }
        private DirtyValue<DateTime?> _borrowerIntendToContinueDate;
        /// <summary>
        /// Borrower Intent to Continue Date [3197]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Intent to Continue Date")]
        public DateTime? BorrowerIntendToContinueDate { get => _borrowerIntendToContinueDate; set => _borrowerIntendToContinueDate = value; }
        private DirtyValue<bool?> _borrowerIntendToContinueIndicator;
        /// <summary>
        /// Borrower Intends to Continue Chkbx [3164]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Intends to Continue Chkbx")]
        public bool? BorrowerIntendToContinueIndicator { get => _borrowerIntendToContinueIndicator; set => _borrowerIntendToContinueIndicator = value; }
        private DirtyValue<string> _borrowerMiTerminationDate;
        /// <summary>
        /// Insurance Borr MI Termination Date [109]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Borr MI Termination Date")]
        public string BorrowerMiTerminationDate { get => _borrowerMiTerminationDate; set => _borrowerMiTerminationDate = value; }
        private DirtyValue<string> _calculateBasedOnRemainingBalance;
        /// <summary>
        /// Expenses Calc MIP/PMI Based On Remain Bal [1775]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc MIP/PMI Based On Remain Bal")]
        public string CalculateBasedOnRemainingBalance { get => _calculateBasedOnRemainingBalance; set => _calculateBasedOnRemainingBalance = value; }
        private DirtyValue<bool?> _chargesAddedToPaymentsIndicator;
        /// <summary>
        /// Charges for the insurance are added to your loan payments [3531]
        /// </summary>
        [LoanFieldProperty(Description = "Charges for the insurance are added to your loan payments")]
        public bool? ChargesAddedToPaymentsIndicator { get => _chargesAddedToPaymentsIndicator; set => _chargesAddedToPaymentsIndicator = value; }
        private DirtyValue<bool?> _chargesAtLoanClosingIndicator;
        /// <summary>
        /// Charges for the insurance are collected upfront at loan closing [3532]
        /// </summary>
        [LoanFieldProperty(Description = "Charges for the insurance are collected upfront at loan closing")]
        public bool? ChargesAtLoanClosingIndicator { get => _chargesAtLoanClosingIndicator; set => _chargesAtLoanClosingIndicator = value; }
        private DirtyValue<string> _circumstanceChangeReason;
        /// <summary>
        /// GFE Changed Circumstance Comments [3166]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Changed Circumstance Comments")]
        public string CircumstanceChangeReason { get => _circumstanceChangeReason; set => _circumstanceChangeReason = value; }
        private DirtyValue<DateTime?> _circumstanceChangeReceivedDate;
        /// <summary>
        /// Changed Circumstance Rcvd Date [3165]
        /// </summary>
        [LoanFieldProperty(Description = "Changed Circumstance Rcvd Date")]
        public DateTime? CircumstanceChangeReceivedDate { get => _circumstanceChangeReceivedDate; set => _circumstanceChangeReceivedDate = value; }
        private DirtyValue<DateTime?> _closingDisclosureReceivedDate;
        /// <summary>
        /// Closing Disclosure Received Date [3978]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure Received Date")]
        public DateTime? ClosingDisclosureReceivedDate { get => _closingDisclosureReceivedDate; set => _closingDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _closingDisclosureSentDate;
        /// <summary>
        /// Closing Disclosure Sent Date [3977]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Disclosure Sent Date")]
        public DateTime? ClosingDisclosureSentDate { get => _closingDisclosureSentDate; set => _closingDisclosureSentDate = value; }
        private DirtyValue<StringEnumValue<ConstructionFirstIntChangeAdjType>> _constructionFirstIntChangeAdjType;
        /// <summary>
        /// Construction 1st Int. Change Adj. [Constr.FstIntChgAdj]
        /// </summary>
        [LoanFieldProperty(Description = "Construction 1st Int. Change Adj.")]
        public StringEnumValue<ConstructionFirstIntChangeAdjType> ConstructionFirstIntChangeAdjType { get => _constructionFirstIntChangeAdjType; set => _constructionFirstIntChangeAdjType = value; }
        private DirtyValue<string> _constructionLoanDescription;
        /// <summary>
        /// Loan Info Constr Loan Descr [1404]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Constr Loan Descr")]
        public string ConstructionLoanDescription { get => _constructionLoanDescription; set => _constructionLoanDescription = value; }
        private DirtyValue<StringEnumValue<ConstructionLoanMethod>> _constructionLoanMethod;
        /// <summary>
        /// REGZ Construction Mortgage Est Interest On [SYS.X6]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Construction Mortgage Est Interest On")]
        public StringEnumValue<ConstructionLoanMethod> ConstructionLoanMethod { get => _constructionLoanMethod; set => _constructionLoanMethod = value; }
        private DirtyValue<int?> _constructionPeriodMonths;
        /// <summary>
        /// Loan Info Constr Loan Period [1176]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Constr Loan Period")]
        public int? ConstructionPeriodMonths { get => _constructionPeriodMonths; set => _constructionPeriodMonths = value; }
        private DirtyValue<decimal?> _constructionRatePercent;
        /// <summary>
        /// Loan Info Constr Loan Interest Rate [1677]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info Constr Loan Interest Rate")]
        public decimal? ConstructionRatePercent { get => _constructionRatePercent; set => _constructionRatePercent = value; }
        private DirtyValue<bool?> _constructionRefinanceIndicator;
        /// <summary>
        /// Construction Refinance Indicator [Constr.Refi]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Refinance Indicator")]
        public bool? ConstructionRefinanceIndicator { get => _constructionRefinanceIndicator; set => _constructionRefinanceIndicator = value; }
        private DirtyValue<decimal?> _creditDisability;
        /// <summary>
        /// Insurance Premium Credit Disability [1704]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Premium Credit Disability")]
        public decimal? CreditDisability { get => _creditDisability; set => _creditDisability = value; }
        private DirtyValue<bool?> _creditDisabilityIndicator;
        /// <summary>
        /// Insurance Credit Disability [1698]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Credit Disability", OptionsJson = "{\"true\":\"Credit insurance\"}")]
        public bool? CreditDisabilityIndicator { get => _creditDisabilityIndicator; set => _creditDisabilityIndicator = value; }
        private DirtyValue<decimal?> _creditLife;
        /// <summary>
        /// Insurance Premium Credit Life [1703]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Premium Credit Life")]
        public decimal? CreditLife { get => _creditLife; set => _creditLife = value; }
        private DirtyValue<decimal?> _creditLifeAndCreditDisability;
        /// <summary>
        /// Insurance Premium Credit Life/Disability [1705]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Premium Credit Life/Disability")]
        public decimal? CreditLifeAndCreditDisability { get => _creditLifeAndCreditDisability; set => _creditLifeAndCreditDisability = value; }
        private DirtyValue<bool?> _creditLifeInsuranceIndicator;
        /// <summary>
        /// Insurance Credit Life [1697]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Credit Life", OptionsJson = "{\"true\":\"Credit life insurance\"}")]
        public bool? CreditLifeInsuranceIndicator { get => _creditLifeInsuranceIndicator; set => _creditLifeInsuranceIndicator = value; }
        private DirtyValue<bool?> _customizePaymentScheduleIndicator;
        /// <summary>
        /// REGZ Pymt Sched Customize [1678]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Pymt Sched Customize", OptionsJson = "{\"true\":\"Customize\"}")]
        public bool? CustomizePaymentScheduleIndicator { get => _customizePaymentScheduleIndicator; set => _customizePaymentScheduleIndicator = value; }
        private DirtyValue<bool?> _demandFeatureIndicator;
        /// <summary>
        /// REGZ Pymt Sched Demand Feature [663]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Pymt Sched Demand Feature", OptionsJson = "{\"true\":\"DEMAND FEATURE: This obligation has a demand feature.\"}")]
        public bool? DemandFeatureIndicator { get => _demandFeatureIndicator; set => _demandFeatureIndicator = value; }
        private DirtyValue<decimal?> _disclosedAprPercent;
        /// <summary>
        /// Trans Details Disclosed APR [3121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Disclosed APR")]
        public decimal? DisclosedAprPercent { get => _disclosedAprPercent; set => _disclosedAprPercent = value; }
        private DirtyValue<bool?> _disclosedByBrokerIndicator;
        /// <summary>
        /// Disclosed By Broker Chbx [3136]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosed By Broker Chbx")]
        public bool? DisclosedByBrokerIndicator { get => _disclosedByBrokerIndicator; set => _disclosedByBrokerIndicator = value; }
        private DirtyValue<string> _disclosedComments;
        /// <summary>
        /// GFE Disclosed Comments [3141]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Disclosed Comments")]
        public string DisclosedComments { get => _disclosedComments; set => _disclosedComments = value; }
        private DirtyValue<decimal?> _disclosedDailyInterestCharge;
        /// <summary>
        /// Disclosed Daily Interest Charges [3887]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosed Daily Interest Charges")]
        public decimal? DisclosedDailyInterestCharge { get => _disclosedDailyInterestCharge; set => _disclosedDailyInterestCharge = value; }
        private DirtyValue<decimal?> _disclosedFinanceCharge;
        /// <summary>
        /// Disclosed Fees Total Finance Charges [3246]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosed Fees Total Finance Charges")]
        public decimal? DisclosedFinanceCharge { get => _disclosedFinanceCharge; set => _disclosedFinanceCharge = value; }
        private DirtyValue<bool?> _disclosedPrepayment;
        /// <summary>
        /// Disclosed Prepayment [4018]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosed Prepayment")]
        public bool? DisclosedPrepayment { get => _disclosedPrepayment; set => _disclosedPrepayment = value; }
        private DirtyValue<string> _disclosedProduct;
        /// <summary>
        /// Disclosed Product [4017]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosed Product")]
        public string DisclosedProduct { get => _disclosedProduct; set => _disclosedProduct = value; }
        private DirtyValue<StringEnumValue<DisclosureMethod>> _disclosureMethod;
        /// <summary>
        /// GFE Disclosure Method [3138]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Disclosure Method")]
        public StringEnumValue<DisclosureMethod> DisclosureMethod { get => _disclosureMethod; set => _disclosureMethod = value; }
        private DirtyValue<StringEnumValue<DisclosureType>> _disclosureType;
        /// <summary>
        /// Trans Details Initial/Final Disclosure [662]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Initial/Final Disclosure")]
        public StringEnumValue<DisclosureType> DisclosureType { get => _disclosureType; set => _disclosureType = value; }
        private DirtyValue<int?> _discountPeriod;
        /// <summary>
        /// Loan Info ARM Pymt Discount Period [2552]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Pymt Discount Period")]
        public int? DiscountPeriod { get => _discountPeriod; set => _discountPeriod = value; }
        private DirtyValue<decimal?> _discountRatePercent;
        /// <summary>
        /// Loan Info ARM Pymt Discount Rate [2551]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Info ARM Pymt Discount Rate")]
        public decimal? DiscountRatePercent { get => _discountRatePercent; set => _discountRatePercent = value; }
        private DirtyValue<StringEnumValue<DiscountType>> _discountType;
        /// <summary>
        /// Loan Info ARM Pymt Discount Type [2307]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Pymt Discount Type")]
        public StringEnumValue<DiscountType> DiscountType { get => _discountType; set => _discountType = value; }
        private DirtyValue<DateTime?> _dueDate;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Due Date [3287]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Construction - Due Date")]
        public DateTime? DueDate { get => _dueDate; set => _dueDate = value; }
        private DirtyValue<DateTime?> _earliestClosingDate;
        /// <summary>
        /// Earliest Closing Date [3147]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Earliest Closing Date")]
        public DateTime? EarliestClosingDate { get => _earliestClosingDate; set => _earliestClosingDate = value; }
        private DirtyValue<DateTime?> _earliestFeeCollectionDate;
        /// <summary>
        /// Earliest Fee Collection Date [3145]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Earliest Fee Collection Date")]
        public DateTime? EarliestFeeCollectionDate { get => _earliestFeeCollectionDate; set => _earliestFeeCollectionDate = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted1;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 1 [3985]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 1")]
        public DateTime? eSignConsentBorrowerDateAccepted1 { get => _eSignConsentBorrowerDateAccepted1; set => _eSignConsentBorrowerDateAccepted1 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted2;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 2 [3993]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 2")]
        public DateTime? eSignConsentBorrowerDateAccepted2 { get => _eSignConsentBorrowerDateAccepted2; set => _eSignConsentBorrowerDateAccepted2 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted3;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 3 [4024]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 3")]
        public DateTime? eSignConsentBorrowerDateAccepted3 { get => _eSignConsentBorrowerDateAccepted3; set => _eSignConsentBorrowerDateAccepted3 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted4;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 4 [4032]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 4")]
        public DateTime? eSignConsentBorrowerDateAccepted4 { get => _eSignConsentBorrowerDateAccepted4; set => _eSignConsentBorrowerDateAccepted4 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted5;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 5 [4040]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 5")]
        public DateTime? eSignConsentBorrowerDateAccepted5 { get => _eSignConsentBorrowerDateAccepted5; set => _eSignConsentBorrowerDateAccepted5 = value; }
        private DirtyValue<DateTime?> _eSignConsentBorrowerDateAccepted6;
        /// <summary>
        /// eConsent Borrower Date Accepted Pair 6 [4048]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Date Accepted Pair 6")]
        public DateTime? eSignConsentBorrowerDateAccepted6 { get => _eSignConsentBorrowerDateAccepted6; set => _eSignConsentBorrowerDateAccepted6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress1;
        /// <summary>
        /// eConsent Borrower IP Address Pair 1 [3986]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 1")]
        public string eSignConsentBorrowerIPAddress1 { get => _eSignConsentBorrowerIPAddress1; set => _eSignConsentBorrowerIPAddress1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress2;
        /// <summary>
        /// eConsent Borrower IP Address Pair 2 [3994]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 2")]
        public string eSignConsentBorrowerIPAddress2 { get => _eSignConsentBorrowerIPAddress2; set => _eSignConsentBorrowerIPAddress2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress3;
        /// <summary>
        /// eConsent Borrower IP Address Pair 3 [4025]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 3")]
        public string eSignConsentBorrowerIPAddress3 { get => _eSignConsentBorrowerIPAddress3; set => _eSignConsentBorrowerIPAddress3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress4;
        /// <summary>
        /// eConsent Borrower IP Address Pair 4 [4033]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 4")]
        public string eSignConsentBorrowerIPAddress4 { get => _eSignConsentBorrowerIPAddress4; set => _eSignConsentBorrowerIPAddress4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress5;
        /// <summary>
        /// eConsent Borrower IP Address Pair 5 [4041]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 5")]
        public string eSignConsentBorrowerIPAddress5 { get => _eSignConsentBorrowerIPAddress5; set => _eSignConsentBorrowerIPAddress5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerIPAddress6;
        /// <summary>
        /// eConsent Borrower IP Address Pair 6 [4049]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower IP Address Pair 6")]
        public string eSignConsentBorrowerIPAddress6 { get => _eSignConsentBorrowerIPAddress6; set => _eSignConsentBorrowerIPAddress6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource1;
        /// <summary>
        /// eConsent Borrower Source Pair 1 [3987]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 1")]
        public string eSignConsentBorrowerSource1 { get => _eSignConsentBorrowerSource1; set => _eSignConsentBorrowerSource1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource2;
        /// <summary>
        /// eConsent Borrower Source Pair 2 [3995]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 2")]
        public string eSignConsentBorrowerSource2 { get => _eSignConsentBorrowerSource2; set => _eSignConsentBorrowerSource2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource3;
        /// <summary>
        /// eConsent Borrower Source Pair 3 [4026]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 3")]
        public string eSignConsentBorrowerSource3 { get => _eSignConsentBorrowerSource3; set => _eSignConsentBorrowerSource3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource4;
        /// <summary>
        /// eConsent Borrower Source Pair 4 [4034]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 4")]
        public string eSignConsentBorrowerSource4 { get => _eSignConsentBorrowerSource4; set => _eSignConsentBorrowerSource4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource5;
        /// <summary>
        /// eConsent Borrower Source Pair 5 [4042]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 5")]
        public string eSignConsentBorrowerSource5 { get => _eSignConsentBorrowerSource5; set => _eSignConsentBorrowerSource5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerSource6;
        /// <summary>
        /// eConsent Borrower Source Pair 6 [4050]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Borrower Source Pair 6")]
        public string eSignConsentBorrowerSource6 { get => _eSignConsentBorrowerSource6; set => _eSignConsentBorrowerSource6 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus1;
        /// <summary>
        /// Borrower 1 eConsent Status [3984]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 1 eConsent Status")]
        public string eSignConsentBorrowerStatus1 { get => _eSignConsentBorrowerStatus1; set => _eSignConsentBorrowerStatus1 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus2;
        /// <summary>
        /// Borrower 2 eConsent Status [3992]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 2 eConsent Status")]
        public string eSignConsentBorrowerStatus2 { get => _eSignConsentBorrowerStatus2; set => _eSignConsentBorrowerStatus2 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus3;
        /// <summary>
        /// Borrower 3 eConsent Status [4023]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 3 eConsent Status")]
        public string eSignConsentBorrowerStatus3 { get => _eSignConsentBorrowerStatus3; set => _eSignConsentBorrowerStatus3 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus4;
        /// <summary>
        /// Borrower 4 eConsent Status [4031]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 4 eConsent Status")]
        public string eSignConsentBorrowerStatus4 { get => _eSignConsentBorrowerStatus4; set => _eSignConsentBorrowerStatus4 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus5;
        /// <summary>
        /// Borrower 5 eConsent Status [4039]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 5 eConsent Status")]
        public string eSignConsentBorrowerStatus5 { get => _eSignConsentBorrowerStatus5; set => _eSignConsentBorrowerStatus5 = value; }
        private DirtyValue<string> _eSignConsentBorrowerStatus6;
        /// <summary>
        /// Borrower 6 eConsent Status [4047]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower 6 eConsent Status")]
        public string eSignConsentBorrowerStatus6 { get => _eSignConsentBorrowerStatus6; set => _eSignConsentBorrowerStatus6 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted1;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 1 [3989]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 1")]
        public DateTime? eSignConsentCoBorrowerDateAccepted1 { get => _eSignConsentCoBorrowerDateAccepted1; set => _eSignConsentCoBorrowerDateAccepted1 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted2;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 2 [3997]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 2")]
        public DateTime? eSignConsentCoBorrowerDateAccepted2 { get => _eSignConsentCoBorrowerDateAccepted2; set => _eSignConsentCoBorrowerDateAccepted2 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted3;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 3 [4028]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 3")]
        public DateTime? eSignConsentCoBorrowerDateAccepted3 { get => _eSignConsentCoBorrowerDateAccepted3; set => _eSignConsentCoBorrowerDateAccepted3 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted4;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 4 [4036]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 4")]
        public DateTime? eSignConsentCoBorrowerDateAccepted4 { get => _eSignConsentCoBorrowerDateAccepted4; set => _eSignConsentCoBorrowerDateAccepted4 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted5;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 5 [4044]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 5")]
        public DateTime? eSignConsentCoBorrowerDateAccepted5 { get => _eSignConsentCoBorrowerDateAccepted5; set => _eSignConsentCoBorrowerDateAccepted5 = value; }
        private DirtyValue<DateTime?> _eSignConsentCoBorrowerDateAccepted6;
        /// <summary>
        /// eConsent Co-Borrower Date Accepted Pair 6 [4052]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Date Accepted Pair 6")]
        public DateTime? eSignConsentCoBorrowerDateAccepted6 { get => _eSignConsentCoBorrowerDateAccepted6; set => _eSignConsentCoBorrowerDateAccepted6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress1;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 1 [3990]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 1")]
        public string eSignConsentCoBorrowerIPAddress1 { get => _eSignConsentCoBorrowerIPAddress1; set => _eSignConsentCoBorrowerIPAddress1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress2;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 2 [3998]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 2")]
        public string eSignConsentCoBorrowerIPAddress2 { get => _eSignConsentCoBorrowerIPAddress2; set => _eSignConsentCoBorrowerIPAddress2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress3;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 3 [4029]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 3")]
        public string eSignConsentCoBorrowerIPAddress3 { get => _eSignConsentCoBorrowerIPAddress3; set => _eSignConsentCoBorrowerIPAddress3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress4;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 4 [4037]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 4")]
        public string eSignConsentCoBorrowerIPAddress4 { get => _eSignConsentCoBorrowerIPAddress4; set => _eSignConsentCoBorrowerIPAddress4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress5;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 5 [4045]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 5")]
        public string eSignConsentCoBorrowerIPAddress5 { get => _eSignConsentCoBorrowerIPAddress5; set => _eSignConsentCoBorrowerIPAddress5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerIPAddress6;
        /// <summary>
        /// eConsent Co-Borrower IP Address Pair 6 [4053]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower IP Address Pair 6")]
        public string eSignConsentCoBorrowerIPAddress6 { get => _eSignConsentCoBorrowerIPAddress6; set => _eSignConsentCoBorrowerIPAddress6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource1;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 1 [3991]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 1")]
        public string eSignConsentCoBorrowerSource1 { get => _eSignConsentCoBorrowerSource1; set => _eSignConsentCoBorrowerSource1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource2;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 2 [3999]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 2")]
        public string eSignConsentCoBorrowerSource2 { get => _eSignConsentCoBorrowerSource2; set => _eSignConsentCoBorrowerSource2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource3;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 3 [4030]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 3")]
        public string eSignConsentCoBorrowerSource3 { get => _eSignConsentCoBorrowerSource3; set => _eSignConsentCoBorrowerSource3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource4;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 4 [4038]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 4")]
        public string eSignConsentCoBorrowerSource4 { get => _eSignConsentCoBorrowerSource4; set => _eSignConsentCoBorrowerSource4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource5;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 5 [4046]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 5")]
        public string eSignConsentCoBorrowerSource5 { get => _eSignConsentCoBorrowerSource5; set => _eSignConsentCoBorrowerSource5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerSource6;
        /// <summary>
        /// eConsent Co-Borrower Source Pair 6 [4054]
        /// </summary>
        [LoanFieldProperty(Description = "eConsent Co-Borrower Source Pair 6")]
        public string eSignConsentCoBorrowerSource6 { get => _eSignConsentCoBorrowerSource6; set => _eSignConsentCoBorrowerSource6 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus1;
        /// <summary>
        /// Co-Borrower 1 eConsent Status [3988]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 1 eConsent Status")]
        public string eSignConsentCoBorrowerStatus1 { get => _eSignConsentCoBorrowerStatus1; set => _eSignConsentCoBorrowerStatus1 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus2;
        /// <summary>
        /// Co-Borrower 2 eConsent Status [3996]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 2 eConsent Status")]
        public string eSignConsentCoBorrowerStatus2 { get => _eSignConsentCoBorrowerStatus2; set => _eSignConsentCoBorrowerStatus2 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus3;
        /// <summary>
        /// Co-Borrower 3 eConsent Status [4027]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 3 eConsent Status")]
        public string eSignConsentCoBorrowerStatus3 { get => _eSignConsentCoBorrowerStatus3; set => _eSignConsentCoBorrowerStatus3 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus4;
        /// <summary>
        /// Co-Borrower 4 eConsent Status [4035]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 4 eConsent Status")]
        public string eSignConsentCoBorrowerStatus4 { get => _eSignConsentCoBorrowerStatus4; set => _eSignConsentCoBorrowerStatus4 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus5;
        /// <summary>
        /// Co-Borrower 5 eConsent Status [4043]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 5 eConsent Status")]
        public string eSignConsentCoBorrowerStatus5 { get => _eSignConsentCoBorrowerStatus5; set => _eSignConsentCoBorrowerStatus5 = value; }
        private DirtyValue<string> _eSignConsentCoBorrowerStatus6;
        /// <summary>
        /// Co-Borrower 6 eConsent Status [4051]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borrower 6 eConsent Status")]
        public string eSignConsentCoBorrowerStatus6 { get => _eSignConsentCoBorrowerStatus6; set => _eSignConsentCoBorrowerStatus6 = value; }
        private DirtyValue<DateTime?> _eSignConsentDate;
        /// <summary>
        /// eConsent Date [3983]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "eConsent Date")]
        public DateTime? eSignConsentDate { get => _eSignConsentDate; set => _eSignConsentDate = value; }
        private DirtyValue<decimal?> _extraPaymentForEarlyPayOff;
        /// <summary>
        /// Trans Details Amort Type GPM Extra Pymt [312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Amort Type GPM Extra Pymt")]
        public decimal? ExtraPaymentForEarlyPayOff { get => _extraPaymentForEarlyPayOff; set => _extraPaymentForEarlyPayOff = value; }
        private DirtyValue<DateTime?> _feeCollectedDate;
        /// <summary>
        /// Fee Collected Date [3146]
        /// </summary>
        [LoanFieldProperty(Description = "Fee Collected Date")]
        public DateTime? FeeCollectedDate { get => _feeCollectedDate; set => _feeCollectedDate = value; }
        private DirtyValue<decimal?> _filingFees;
        /// <summary>
        /// Trans Details Filing Fees [1707]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Filing Fees")]
        public decimal? FilingFees { get => _filingFees; set => _filingFees = value; }
        private DirtyValue<DateTime?> _finalPaymentDate;
        /// <summary>
        /// REGZ Construction Mortgage Final Pymt Date [1961]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Construction Mortgage Final Pymt Date")]
        public DateTime? FinalPaymentDate { get => _finalPaymentDate; set => _finalPaymentDate = value; }
        private DirtyValue<decimal?> _financeCharge;
        /// <summary>
        /// Fees Total Finance Charges [1206]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Finance Charges")]
        public decimal? FinanceCharge { get => _financeCharge; set => _financeCharge = value; }
        private DirtyValue<decimal?> _financedAllGuaranteeFeeAmount;
        /// <summary>
        /// Financed Guarantee Fee - Guarantee Amount [3561]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Financed Guarantee Fee - Guarantee Amount")]
        public decimal? FinancedAllGuaranteeFeeAmount { get => _financedAllGuaranteeFeeAmount; set => _financedAllGuaranteeFeeAmount = value; }
        private DirtyValue<decimal?> _financedAllGuaranteeFeePercent;
        /// <summary>
        /// Financed Guarantee Fee - Guarantee Percentage [3560]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Financed Guarantee Fee - Guarantee Percentage", OptionsJson = "{\"0.50\":\"0.50\",\"1.00\":\"1.00\",\"1.25\":\"1.25\",\"1.50\":\"1.50\",\"1.75\":\"1.75\",\"2.00\":\"2.00\",\"2.25\":\"2.25\",\"2.50\":\"2.50\",\"2.75\":\"2.75\",\"3.00\":\"3.00\",\"3.25\":\"3.25\",\"3.50\":\"3.50\",\"3.75\":\"3.75\",\"4.00\":\"4.00\"}")]
        public decimal? FinancedAllGuaranteeFeePercent { get => _financedAllGuaranteeFeePercent; set => _financedAllGuaranteeFeePercent = value; }
        private DirtyValue<decimal?> _financedAllTotalLoanAmount;
        /// <summary>
        /// Financed Guarantee Fee - Total Loan Amount [3562]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Financed Guarantee Fee - Total Loan Amount")]
        public decimal? FinancedAllTotalLoanAmount { get => _financedAllTotalLoanAmount; set => _financedAllTotalLoanAmount = value; }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeeAmount;
        /// <summary>
        /// Portion of Financed Guarantee Fee - Guarantee Amount [3564]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Portion of Financed Guarantee Fee - Guarantee Amount")]
        public decimal? FinancedPortionGuaranteeFeeAmount { get => _financedPortionGuaranteeFeeAmount; set => _financedPortionGuaranteeFeeAmount = value; }
        private DirtyValue<decimal?> _financedPortionGuaranteeFeePercent;
        /// <summary>
        /// Portion of Financed Guarantee Fee - Guarantee Percentage [3563]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Portion of Financed Guarantee Fee - Guarantee Percentage")]
        public decimal? FinancedPortionGuaranteeFeePercent { get => _financedPortionGuaranteeFeePercent; set => _financedPortionGuaranteeFeePercent = value; }
        private DirtyValue<decimal?> _financedPortionTotalLoanAmount;
        /// <summary>
        /// Portion of Financed Guarantee Fee - Total Loan Amount [3565]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Portion of Financed Guarantee Fee - Total Loan Amount")]
        public decimal? FinancedPortionTotalLoanAmount { get => _financedPortionTotalLoanAmount; set => _financedPortionTotalLoanAmount = value; }
        private DirtyValue<StringEnumValue<FinancingType>> _financingType;
        /// <summary>
        /// USDA Financing Type [3566]
        /// </summary>
        [LoanFieldProperty(Description = "USDA Financing Type")]
        public StringEnumValue<FinancingType> FinancingType { get => _financingType; set => _financingType = value; }
        private DirtyValue<DateTime?> _firstAmortizationPaymentDate;
        /// <summary>
        /// REGZ Construction Mortgage 1st Amortization Date [1963]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Construction Mortgage 1st Amortization Date")]
        public DateTime? FirstAmortizationPaymentDate { get => _firstAmortizationPaymentDate; set => _firstAmortizationPaymentDate = value; }
        private DirtyValue<bool?> _floodInsuranceIndicator;
        /// <summary>
        /// Insurance Flood [676]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Flood", OptionsJson = "{\"true\":\"Flood insurance\"}")]
        public bool? FloodInsuranceIndicator { get => _floodInsuranceIndicator; set => _floodInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _gfeApplicationDate;
        /// <summary>
        /// Application Date [3142]
        /// </summary>
        [LoanFieldProperty(Description = "Application Date")]
        public DateTime? GfeApplicationDate { get => _gfeApplicationDate; set => _gfeApplicationDate = value; }
        private DirtyValue<bool?> _gfeChangedCircumstanceIndicator;
        /// <summary>
        /// Changed Circumstance Chkbx [3168]
        /// </summary>
        [LoanFieldProperty(Description = "Changed Circumstance Chkbx")]
        public bool? GfeChangedCircumstanceIndicator { get => _gfeChangedCircumstanceIndicator; set => _gfeChangedCircumstanceIndicator = value; }
        private DirtyValue<string> _gfeChangedCircumstanceItem;
        /// <summary>
        /// GFE Changed Circumstance [3169]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Changed Circumstance")]
        public string GfeChangedCircumstanceItem { get => _gfeChangedCircumstanceItem; set => _gfeChangedCircumstanceItem = value; }
        private DirtyValue<string> _gFEChangedCirsumstanceItemCode;
        /// <summary>
        /// GFE Changed Circumstance Code [3627]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Changed Circumstance Code")]
        public string GFEChangedCirsumstanceItemCode { get => _gFEChangedCirsumstanceItemCode; set => _gFEChangedCirsumstanceItemCode = value; }
        private DirtyValue<DateTime?> _gfeDate;
        /// <summary>
        /// GFE Date for Printed Form [3170]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Date for Printed Form")]
        public DateTime? GfeDate { get => _gfeDate; set => _gfeDate = value; }
        private DirtyValue<DateTime?> _gfeExpirationDate;
        /// <summary>
        /// GFE Expiration Date [3140]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Expiration Date")]
        public DateTime? GfeExpirationDate { get => _gfeExpirationDate; set => _gfeExpirationDate = value; }
        private DirtyValue<string> _gfeExpirationPeriod;
        /// <summary>
        /// No. of Days GFE Valid After Received [3162]
        /// </summary>
        [LoanFieldProperty(Description = "No. of Days GFE Valid After Received")]
        public string GfeExpirationPeriod { get => _gfeExpirationPeriod; set => _gfeExpirationPeriod = value; }
        private DirtyValue<bool?> _gfeRateLockRedisclosureRequiredIndicator;
        /// <summary>
        /// GFE Redisclosure Required Due to Rate Lock [3201]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Redisclosure Required Due to Rate Lock")]
        public bool? GfeRateLockRedisclosureRequiredIndicator { get => _gfeRateLockRedisclosureRequiredIndicator; set => _gfeRateLockRedisclosureRequiredIndicator = value; }
        private DirtyValue<DateTime?> _gfeRedisclosureProvidedDate;
        /// <summary>
        /// GFE Redisclosure Provided Date [3150]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Redisclosure Provided Date")]
        public DateTime? GfeRedisclosureProvidedDate { get => _gfeRedisclosureProvidedDate; set => _gfeRedisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _gfeRedisclosureReceivedDate;
        /// <summary>
        /// GFE Redisclosure Received Date [3151]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Redisclosure Received Date")]
        public DateTime? GfeRedisclosureReceivedDate { get => _gfeRedisclosureReceivedDate; set => _gfeRedisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _highCostDisclosure;
        /// <summary>
        /// The Date that the High Cost Disclosure is signed [4022]
        /// </summary>
        [LoanFieldProperty(Description = "The Date that the High Cost Disclosure is signed")]
        public DateTime? HighCostDisclosure { get => _highCostDisclosure; set => _highCostDisclosure = value; }
        private DirtyValue<DateTime?> _homeCounselingProvidedDate;
        /// <summary>
        /// Date the Home Counseling Disclosure Provided to the Borrower [3859]
        /// </summary>
        [LoanFieldProperty(Description = "Date the Home Counseling Disclosure Provided to the Borrower")]
        public DateTime? HomeCounselingProvidedDate { get => _homeCounselingProvidedDate; set => _homeCounselingProvidedDate = value; }
        private DirtyValue<bool?> _hud1ToleranceViolatedIndicator;
        /// <summary>
        /// HUD-1Tolerance Lmt Violation [3160]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HUD-1Tolerance Lmt Violation")]
        public bool? Hud1ToleranceViolatedIndicator { get => _hud1ToleranceViolatedIndicator; set => _hud1ToleranceViolatedIndicator = value; }
        private DirtyValue<string> _hudToleranceResolutionComments;
        /// <summary>
        /// HUD-1 Tolerance Resolution Comments [3172]
        /// </summary>
        [LoanFieldProperty(Description = "HUD-1 Tolerance Resolution Comments")]
        public string HudToleranceResolutionComments { get => _hudToleranceResolutionComments; set => _hudToleranceResolutionComments = value; }
        private DirtyValue<DateTime?> _hudToleranceResolutionDate;
        /// <summary>
        /// HUD-1 Tolerance Resolution Date [3171]
        /// </summary>
        [LoanFieldProperty(Description = "HUD-1 Tolerance Resolution Date")]
        public DateTime? HudToleranceResolutionDate { get => _hudToleranceResolutionDate; set => _hudToleranceResolutionDate = value; }
        private DirtyValue<string> _hudToleranceResolvedBy;
        /// <summary>
        /// HUD-1 Tolerance Resolution User [3173]
        /// </summary>
        [LoanFieldProperty(Description = "HUD-1 Tolerance Resolution User")]
        public string HudToleranceResolvedBy { get => _hudToleranceResolvedBy; set => _hudToleranceResolvedBy = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// RegulationZ Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ifYouPurchaseIndicator;
        /// <summary>
        /// Insurance Premium If you purchase [1708]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Premium If you purchase", OptionsJson = "{\"true\":\"If you purchase\"}")]
        public bool? IfYouPurchaseIndicator { get => _ifYouPurchaseIndicator; set => _ifYouPurchaseIndicator = value; }
        private DirtyValue<StringEnumValue<IfYouPurchaseType>> _ifYouPurchaseType;
        /// <summary>
        /// Insurance Premium Haz/Flood/Haz&amp;Flood [1709]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Premium Haz/Flood/Haz&Flood")]
        public StringEnumValue<IfYouPurchaseType> IfYouPurchaseType { get => _ifYouPurchaseType; set => _ifYouPurchaseType = value; }
        private DirtyValue<bool?> _includeMiIndicator;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Include Mortgage Insurance [3266]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ-TIL Interest Rate and Payment Summary Table - Include Mortgage Insurance")]
        public bool? IncludeMiIndicator { get => _includeMiIndicator; set => _includeMiIndicator = value; }
        private DirtyValue<bool?> _includePmiIndicator;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Include Private Mortgage Insurance [3265]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Include Private Mortgage Insurance")]
        public bool? IncludePmiIndicator { get => _includePmiIndicator; set => _includePmiIndicator = value; }
        private DirtyValue<bool?> _includeTaxesInsuranceIndicator;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Include Escrowed Taxes and Insurance [3264]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Include Escrowed Taxes and Insurance")]
        public bool? IncludeTaxesInsuranceIndicator { get => _includeTaxesInsuranceIndicator; set => _includeTaxesInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _initialAVMProvidedDate;
        /// <summary>
        /// Date the AVM Provided to the Borrower [3858]
        /// </summary>
        [LoanFieldProperty(Description = "Date the AVM Provided to the Borrower")]
        public DateTime? InitialAVMProvidedDate { get => _initialAVMProvidedDate; set => _initialAVMProvidedDate = value; }
        private DirtyValue<DateTime?> _initialDisclosureDueDate;
        /// <summary>
        /// Initial Disclosure Due Date [3143]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Initial Disclosure Due Date")]
        public DateTime? InitialDisclosureDueDate { get => _initialDisclosureDueDate; set => _initialDisclosureDueDate = value; }
        private DirtyValue<DateTime?> _initialDisclosureProvidedDate;
        /// <summary>
        /// Initial Disclosure Provided Date [3144]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Initial Disclosure Provided Date")]
        public DateTime? InitialDisclosureProvidedDate { get => _initialDisclosureProvidedDate; set => _initialDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeAffiliatedBusinessProvidedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure Affiliated Business Disclosure Provided Date [3544]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Initial GFE Disclosure Affiliated Business Disclosure Provided Date")]
        public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get => _initialGfeAffiliatedBusinessProvidedDate; set => _initialGfeAffiliatedBusinessProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGFEAppraisalProvidedDate;
        /// <summary>
        /// Date the Appraisal was provided to the Borrower [3624]
        /// </summary>
        [LoanFieldProperty(Description = "Date the Appraisal was provided to the Borrower")]
        public DateTime? InitialGFEAppraisalProvidedDate { get => _initialGFEAppraisalProvidedDate; set => _initialGFEAppraisalProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeCharmBookletProvidedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure CHARM Booklet Provided Date [3545]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Initial GFE Disclosure CHARM Booklet Provided Date")]
        public DateTime? InitialGfeCharmBookletProvidedDate { get => _initialGfeCharmBookletProvidedDate; set => _initialGfeCharmBookletProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeDisclosureProvidedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure Provided Date [3148]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Initial GFE Disclosure Provided Date")]
        public DateTime? InitialGfeDisclosureProvidedDate { get => _initialGfeDisclosureProvidedDate; set => _initialGfeDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeDisclosureReceivedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure Received Date [3149]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Initial GFE Disclosure Received Date")]
        public DateTime? InitialGfeDisclosureReceivedDate { get => _initialGfeDisclosureReceivedDate; set => _initialGfeDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _initialGfeHelocBrochureProvidedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure HELOC Brochure Provided Date [3547]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Initial GFE Disclosure HELOC Brochure Provided Date")]
        public DateTime? InitialGfeHelocBrochureProvidedDate { get => _initialGfeHelocBrochureProvidedDate; set => _initialGfeHelocBrochureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialGfeHudSpecialBookletProvidedDate;
        /// <summary>
        /// GFE Initial GFE Disclosure HUD Special Booklet Provided Date [3546]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Initial GFE Disclosure HUD Special Booklet Provided Date")]
        public DateTime? InitialGfeHudSpecialBookletProvidedDate { get => _initialGfeHudSpecialBookletProvidedDate; set => _initialGfeHudSpecialBookletProvidedDate = value; }
        private DirtyValue<DateTime?> _initialSubsequentAppraisalProvidedDate;
        /// <summary>
        /// Date the Subsequent Appraisal Provided to the Borrower [3857]
        /// </summary>
        [LoanFieldProperty(Description = "Date the Subsequent Appraisal Provided to the Borrower")]
        public DateTime? InitialSubsequentAppraisalProvidedDate { get => _initialSubsequentAppraisalProvidedDate; set => _initialSubsequentAppraisalProvidedDate = value; }
        private DirtyValue<DateTime?> _initialTilDisclosureProvidedDate;
        /// <summary>
        /// TIL Intl Disclosure Provided Date [3152]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Intl Disclosure Provided Date")]
        public DateTime? InitialTilDisclosureProvidedDate { get => _initialTilDisclosureProvidedDate; set => _initialTilDisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _initialTilDisclosureReceivedDate;
        /// <summary>
        /// TIL Intl TIL Disclosure Rcvd Date [3153]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Intl TIL Disclosure Rcvd Date")]
        public DateTime? InitialTilDisclosureReceivedDate { get => _initialTilDisclosureReceivedDate; set => _initialTilDisclosureReceivedDate = value; }
        private DirtyValue<string> _insuranceRequiredDescription;
        /// <summary>
        /// Insurance Required [1702]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Required")]
        public string InsuranceRequiredDescription { get => _insuranceRequiredDescription; set => _insuranceRequiredDescription = value; }
        private DirtyValue<string> _interestInNameOf;
        /// <summary>
        /// Trans Details Security Interest [1603]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Security Interest")]
        public string InterestInNameOf { get => _interestInNameOf; set => _interestInNameOf = value; }
        private DirtyValue<bool?> _interestOnly;
        /// <summary>
        /// Interest Only Indicator [Terms.IntrOnly]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Interest Only Indicator")]
        public bool? InterestOnly { get => _interestOnly; set => _interestOnly = value; }
        private DirtyValue<bool?> _interestOnlyIndicator;
        /// <summary>
        /// Trans Details Interest Only Indicator [2982]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interest Only Indicator")]
        public bool? InterestOnlyIndicator { get => _interestOnlyIndicator; set => _interestOnlyIndicator = value; }
        private DirtyValue<int?> _interestOnlyMonths;
        /// <summary>
        /// Trans Details Interest Only Mos [1177]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interest Only Mos")]
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => _interestOnlyMonths = value; }
        private DirtyValue<StringEnumValue<InterestRateType>> _interestRateType;
        /// <summary>
        /// REGZ Construction Mortgage Interest Rate Type [2820]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Construction Mortgage Interest Rate Type")]
        public StringEnumValue<InterestRateType> InterestRateType { get => _interestRateType; set => _interestRateType = value; }
        private DirtyValue<decimal?> _interestReserveAmount;
        /// <summary>
        /// Loan Info Constr Loan Required Resrv [1265]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Info Constr Loan Required Resrv")]
        public decimal? InterestReserveAmount { get => _interestReserveAmount; set => _interestReserveAmount = value; }
        private DirtyValue<string> _lastDisclosedBy;
        /// <summary>
        /// GFE Last Disclosed By [3139]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Last Disclosed By")]
        public string LastDisclosedBy { get => _lastDisclosedBy; set => _lastDisclosedBy = value; }
        private DirtyValue<DateTime?> _lastDisclosedDate;
        /// <summary>
        /// GFE Last Disclosed Date [3137]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Last Disclosed Date")]
        public DateTime? LastDisclosedDate { get => _lastDisclosedDate; set => _lastDisclosedDate = value; }
        private DirtyValue<DateTime?> _lastDisclosedGfeReceivedDate;
        /// <summary>
        /// GFE Last Disclosure Rcvd Date [3163]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "GFE Last Disclosure Rcvd Date")]
        public DateTime? LastDisclosedGfeReceivedDate { get => _lastDisclosedGfeReceivedDate; set => _lastDisclosedGfeReceivedDate = value; }
        private DirtyValue<decimal?> _lateChargeBasis;
        /// <summary>
        /// Late Charge Basis [4186]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Late Charge Basis")]
        public decimal? LateChargeBasis { get => _lateChargeBasis; set => _lateChargeBasis = value; }
        private DirtyValue<string> _lateChargeComments;
        /// <summary>
        /// Trans Details Late Charge Additional Detail [1854]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Late Charge Additional Detail")]
        public string LateChargeComments { get => _lateChargeComments; set => _lateChargeComments = value; }
        private DirtyValue<int?> _lateChargeDays;
        /// <summary>
        /// Trans Details Late Charge Days [672]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Late Charge Days")]
        public int? LateChargeDays { get => _lateChargeDays; set => _lateChargeDays = value; }
        private DirtyValue<decimal?> _lateChargePercent;
        /// <summary>
        /// Trans Details Late Charge % [674]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Late Charge %")]
        public decimal? LateChargePercent { get => _lateChargePercent; set => _lateChargePercent = value; }
        private DirtyValue<StringEnumValue<LateChargeType>> _lateChargeType;
        /// <summary>
        /// Trans Details Late Charge % Based On [1719]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Late Charge % Based On")]
        public StringEnumValue<LateChargeType> LateChargeType { get => _lateChargeType; set => _lateChargeType = value; }
        private DirtyValue<decimal?> _lateFee;
        /// <summary>
        /// Trans Details Late Fee [3876]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Late Fee")]
        public decimal? LateFee { get => _lateFee; set => _lateFee = value; }
        private DirtyValue<string> _lEIntentToProceedComment;
        /// <summary>
        /// LE Intent To Proceed Comment [3976]
        /// </summary>
        [LoanFieldProperty(Description = "LE Intent To Proceed Comment")]
        public string LEIntentToProceedComment { get => _lEIntentToProceedComment; set => _lEIntentToProceedComment = value; }
        private DirtyValue<bool?> _lenderPaidMortgageInsuranceIndicator;
        /// <summary>
        /// Lender Paid Mortgage Insurance [3533]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Paid Mortgage Insurance")]
        public bool? LenderPaidMortgageInsuranceIndicator { get => _lenderPaidMortgageInsuranceIndicator; set => _lenderPaidMortgageInsuranceIndicator = value; }
        private DirtyValue<decimal?> _lendersInspectionFee;
        /// <summary>
        /// REGZ Construction Mortgage Lenders Inspection Rate [3899]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "REGZ Construction Mortgage Lenders Inspection Rate")]
        public decimal? LendersInspectionFee { get => _lendersInspectionFee; set => _lendersInspectionFee = value; }
        private DirtyValue<string> _lEReceivedBy;
        /// <summary>
        /// LE Intent To Proceed Received By [3973]
        /// </summary>
        [LoanFieldProperty(Description = "LE Intent To Proceed Received By")]
        public string LEReceivedBy { get => _lEReceivedBy; set => _lEReceivedBy = value; }
        private DirtyValue<StringEnumValue<LEReceivedMethod>> _lEReceivedMethod;
        /// <summary>
        /// LE Intent To Proceed Received Method [3974]
        /// </summary>
        [LoanFieldProperty(Description = "LE Intent To Proceed Received Method")]
        public StringEnumValue<LEReceivedMethod> LEReceivedMethod { get => _lEReceivedMethod; set => _lEReceivedMethod = value; }
        private DirtyValue<string> _lEReceivedMethodOther;
        /// <summary>
        /// LE Intent To Proceed Received Method Other [3975]
        /// </summary>
        [LoanFieldProperty(Description = "LE Intent To Proceed Received Method Other")]
        public string LEReceivedMethodOther { get => _lEReceivedMethodOther; set => _lEReceivedMethodOther = value; }
        private DirtyValue<DateTime?> _lESentOnDate;
        /// <summary>
        /// LE Intent To Proceed Sent On Date [3972]
        /// </summary>
        [LoanFieldProperty(Description = "LE Intent To Proceed Sent On Date")]
        public DateTime? LESentOnDate { get => _lESentOnDate; set => _lESentOnDate = value; }
        private DirtyValue<decimal?> _marginPlusIndexPercent;
        /// <summary>
        /// Loan Info ARM Margin + Index [1827]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Loan Info ARM Margin + Index")]
        public decimal? MarginPlusIndexPercent { get => _marginPlusIndexPercent; set => _marginPlusIndexPercent = value; }
        private DirtyValue<decimal?> _maximumLateCharge;
        /// <summary>
        /// Trans Details Maximum Late Charge [2832]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Maximum Late Charge")]
        public decimal? MaximumLateCharge { get => _maximumLateCharge; set => _maximumLateCharge = value; }
        private DirtyValue<decimal?> _maximumPayment;
        /// <summary>
        /// Prequal Maximum Payment [1896]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Maximum Payment")]
        public decimal? MaximumPayment { get => _maximumPayment; set => _maximumPayment = value; }
        private DirtyValue<bool?> _meansAnEstimateIndicator;
        /// <summary>
        /// Trans Details E Means Estimate [680]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details E Means Estimate", OptionsJson = "{\"true\":\"means an estimate\"}")]
        public bool? MeansAnEstimateIndicator { get => _meansAnEstimateIndicator; set => _meansAnEstimateIndicator = value; }
        private DirtyValue<decimal?> _miAdjustmentFactorLevel2;
        /// <summary>
        /// Insurance Mtg Ins Periodic Factor 2 [1201]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Insurance Mtg Ins Periodic Factor 2")]
        public decimal? MiAdjustmentFactorLevel2 { get => _miAdjustmentFactorLevel2; set => _miAdjustmentFactorLevel2 = value; }
        private DirtyValue<bool?> _miDecliningRenewalsIndicator;
        /// <summary>
        /// Insurance Mtg Declining Renewals [3248]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Mtg Declining Renewals")]
        public bool? MiDecliningRenewalsIndicator { get => _miDecliningRenewalsIndicator; set => _miDecliningRenewalsIndicator = value; }
        private DirtyValue<string> _midpointCancellation;
        /// <summary>
        /// Expenses Calc MIP/PMI Midpoint Pymt Cancel [1753]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc MIP/PMI Midpoint Pymt Cancel")]
        public string MidpointCancellation { get => _midpointCancellation; set => _midpointCancellation = value; }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel1;
        /// <summary>
        /// Insurance Mtg Ins Pymt 1 [1766]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Mtg Ins Pymt 1")]
        public decimal? MiMonthlyPaymentLevel1 { get => _miMonthlyPaymentLevel1; set => _miMonthlyPaymentLevel1 = value; }
        private DirtyValue<decimal?> _miMonthlyPaymentLevel2;
        /// <summary>
        /// Insurance Mtg Ins Pymt 2 [1770]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Mtg Ins Pymt 2")]
        public decimal? MiMonthlyPaymentLevel2 { get => _miMonthlyPaymentLevel2; set => _miMonthlyPaymentLevel2 = value; }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel1;
        /// <summary>
        /// Insurance Mtg Ins Period 1 [1198]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Mtg Ins Period 1")]
        public int? MiMonthsOfAdjustmentLevel1 { get => _miMonthsOfAdjustmentLevel1; set => _miMonthsOfAdjustmentLevel1 = value; }
        private DirtyValue<int?> _miMonthsOfAdjustmentLevel2;
        /// <summary>
        /// Insurance Mtg Ins Period 2 [1200]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Mtg Ins Period 2")]
        public int? MiMonthsOfAdjustmentLevel2 { get => _miMonthsOfAdjustmentLevel2; set => _miMonthsOfAdjustmentLevel2 = value; }
        private DirtyValue<decimal?> _minimumLateCharge;
        /// <summary>
        /// Trans Details Minimum Late Charge [2831]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Minimum Late Charge")]
        public decimal? MinimumLateCharge { get => _minimumLateCharge; set => _minimumLateCharge = value; }
        private DirtyValue<decimal?> _minimumPayment;
        /// <summary>
        /// Prequal Minimum Payment [1895]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Minimum Payment")]
        public decimal? MinimumPayment { get => _minimumPayment; set => _minimumPayment = value; }
        private DirtyValue<bool?> _mIPFactorLocked;
        /// <summary>
        /// MI Factor Field Locked [3625]
        /// </summary>
        [LoanFieldProperty(Description = "MI Factor Field Locked")]
        public bool? MIPFactorLocked { get => _mIPFactorLocked; set => _mIPFactorLocked = value; }
        private DirtyValue<decimal?> _mIPrepaidAmount;
        /// <summary>
        /// MI Prepaid Amount [3971]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MI Prepaid Amount")]
        public decimal? MIPrepaidAmount { get => _mIPrepaidAmount; set => _mIPrepaidAmount = value; }
        private DirtyValue<bool?> _miPrepaidIndicator;
        /// <summary>
        /// Insurance Mtg Ins Mnths Prepaid [2978]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Mtg Ins Mnths Prepaid")]
        public bool? MiPrepaidIndicator { get => _miPrepaidIndicator; set => _miPrepaidIndicator = value; }
        private DirtyValue<string> _miScheduledTerminationDate;
        /// <summary>
        /// Insurance Calculation Borr MI Termination Date [118]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Insurance Calculation Borr MI Termination Date")]
        public string MiScheduledTerminationDate { get => _miScheduledTerminationDate; set => _miScheduledTerminationDate = value; }
        private DirtyValue<bool?> _mmiIndicator;
        /// <summary>
        /// Insurance MMI [723]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance MMI", OptionsJson = "{\"true\":\"MMI\"}")]
        public bool? MmiIndicator { get => _mmiIndicator; set => _mmiIndicator = value; }
        private DirtyValue<decimal?> _monthlyTerm;
        /// <summary>
        /// Insurance Premium 1 Monthly Term Pymt [4081]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Premium 1 Monthly Term Pymt")]
        public decimal? MonthlyTerm { get => _monthlyTerm; set => _monthlyTerm = value; }
        private DirtyValue<int?> _monthsOfMiPrepaid;
        /// <summary>
        /// Insurance Mtg Ins Mos Prepaid [1209]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Mtg Ins Mos Prepaid")]
        public int? MonthsOfMiPrepaid { get => _monthsOfMiPrepaid; set => _monthsOfMiPrepaid = value; }
        private DirtyValue<decimal?> _mortgageInsuranceCancelPercent;
        /// <summary>
        /// Insurance Mtg Ins Cancel at % [1205]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Insurance Mtg Ins Cancel at %")]
        public decimal? MortgageInsuranceCancelPercent { get => _mortgageInsuranceCancelPercent; set => _mortgageInsuranceCancelPercent = value; }
        private DirtyValue<string> _namePreparedBy;
        /// <summary>
        /// Loan Info Prepared By Name [2026]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Prepared By Name")]
        public string NamePreparedBy { get => _namePreparedBy; set => _namePreparedBy = value; }
        private DirtyValue<string> _newConstructionIndicator;
        /// <summary>
        /// Construction Loan New Construction Indicator [2645]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Loan New Construction Indicator")]
        public string NewConstructionIndicator { get => _newConstructionIndicator; set => _newConstructionIndicator = value; }
        private DirtyValue<int?> _numberOfPayments;
        /// <summary>
        /// REGZ Total # Pymts [1701]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Total # Pymts")]
        public int? NumberOfPayments { get => _numberOfPayments; set => _numberOfPayments = value; }
        private DirtyValue<DateTime?> _occupancyCertDate;
        /// <summary>
        /// Occupancy Cert Date [4080]
        /// </summary>
        [LoanFieldProperty(Description = "Occupancy Cert Date")]
        public DateTime? OccupancyCertDate { get => _occupancyCertDate; set => _occupancyCertDate = value; }
        private DirtyValue<DateTime?> _originalContractDate;
        /// <summary>
        /// Construction Loan Original Contract Date [2646]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Loan Original Contract Date")]
        public DateTime? OriginalContractDate { get => _originalContractDate; set => _originalContractDate = value; }
        private DirtyValue<decimal?> _outstandingBalance;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Outstanding Balance [3288]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Construction - Outstanding Balance")]
        public decimal? OutstandingBalance { get => _outstandingBalance; set => _outstandingBalance = value; }
        private DirtyValue<string> _paymentFrequencyType;
        /// <summary>
        /// REGZ Payment Frequency Type Description [3291]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Payment Frequency Type Description")]
        public string PaymentFrequencyType { get => _paymentFrequencyType; set => _paymentFrequencyType = value; }
        private DirtyValue<decimal?> _paymentIncreasePercent;
        /// <summary>
        /// GPM Payment Increase [Terms.GPMPmtIncr]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "GPM Payment Increase")]
        public decimal? PaymentIncreasePercent { get => _paymentIncreasePercent; set => _paymentIncreasePercent = value; }
        private DirtyValue<string> _phonePreparedBy;
        /// <summary>
        /// Loan Info Prepared By Phone [2027]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Loan Info Prepared By Phone")]
        public string PhonePreparedBy { get => _phonePreparedBy; set => _phonePreparedBy = value; }
        private DirtyValue<bool?> _pmiIndicator;
        /// <summary>
        /// Insurance PMI [8]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance PMI", OptionsJson = "{\"true\":\"PMI\"}")]
        public bool? PmiIndicator { get => _pmiIndicator; set => _pmiIndicator = value; }
        private DirtyValue<DateTime?> _pmiMidpointCancelationDate;
        /// <summary>
        /// PMI Midpoint Cancelation Date [3548]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "PMI Midpoint Cancelation Date")]
        public DateTime? PmiMidpointCancelationDate { get => _pmiMidpointCancelationDate; set => _pmiMidpointCancelationDate = value; }
        private DirtyValue<DateTime?> _postConsummationDisclosureReceivedDate;
        /// <summary>
        /// Post Consummation Disclosure Received Date [3982]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Post Consummation Disclosure Received Date")]
        public DateTime? PostConsummationDisclosureReceivedDate { get => _postConsummationDisclosureReceivedDate; set => _postConsummationDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _postConsummationDisclosureSentDate;
        /// <summary>
        /// Post Consummation Disclosure Sent Date [3981]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Post Consummation Disclosure Sent Date")]
        public DateTime? PostConsummationDisclosureSentDate { get => _postConsummationDisclosureSentDate; set => _postConsummationDisclosureSentDate = value; }
        private DirtyValue<decimal?> _prepaidFinanceCharge;
        /// <summary>
        /// Fees Total Prepaid Finance Charges [949]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Prepaid Finance Charges")]
        public decimal? PrepaidFinanceCharge { get => _prepaidFinanceCharge; set => _prepaidFinanceCharge = value; }
        private DirtyValue<bool?> _propertyInsuranceIndicator;
        /// <summary>
        /// Insurance Property [1242]
        /// </summary>
        [LoanFieldProperty(Description = "Insurance Property", OptionsJson = "{\"true\":\"Hazard Insurance\"}")]
        public bool? PropertyInsuranceIndicator { get => _propertyInsuranceIndicator; set => _propertyInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _rateLockGfeDueDate;
        /// <summary>
        /// Rate Lock GFE Due Date [3161]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Rate Lock GFE Due Date")]
        public DateTime? RateLockGfeDueDate { get => _rateLockGfeDueDate; set => _rateLockGfeDueDate = value; }
        private DirtyValue<decimal?> _ratePercent;
        /// <summary>
        /// Trans Details Amort Type GPM Rate [1267]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Amort Type GPM Rate")]
        public decimal? RatePercent { get => _ratePercent; set => _ratePercent = value; }
        private DirtyValue<int?> _recastPaidMonths;
        /// <summary>
        /// Loan Info ARM Recast Period [1712]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Recast Period")]
        public int? RecastPaidMonths { get => _recastPaidMonths; set => _recastPaidMonths = value; }
        private DirtyValue<int?> _recastStopMonths;
        /// <summary>
        /// Loan Info ARM Recast Stop [1713]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Recast Stop")]
        public int? RecastStopMonths { get => _recastStopMonths; set => _recastStopMonths = value; }
        private DirtyValue<bool?> _refundPaymentIndicator;
        /// <summary>
        /// Trans Details Prepymt - May/Will Not Refund [670]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Prepymt - May/Will Not Refund", OptionsJson = "{\"true\":\"may\",\"false\":\"will not\"}")]
        public bool? RefundPaymentIndicator { get => _refundPaymentIndicator; set => _refundPaymentIndicator = value; }
        private DirtyValue<bool?> _refundUnearnedMipIndicator;
        /// <summary>
        /// Refund prorated unearned Up Front MI Premiums [3262]
        /// </summary>
        [LoanFieldProperty(Description = "Refund prorated unearned Up Front MI Premiums")]
        public bool? RefundUnearnedMipIndicator { get => _refundUnearnedMipIndicator; set => _refundUnearnedMipIndicator = value; }
        private DirtyList<RegulationZInterestRatePeriod> _regulationZInterestRatePeriods;
        /// <summary>
        /// RegulationZ RegulationZInterestRatePeriods
        /// </summary>
        public IList<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get => _regulationZInterestRatePeriods ?? (_regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>()); set => _regulationZInterestRatePeriods = new DirtyList<RegulationZInterestRatePeriod>(value); }
        private DirtyList<RegulationZPayment> _regulationZPayments;
        /// <summary>
        /// RegulationZ RegulationZPayments
        /// </summary>
        public IList<RegulationZPayment> RegulationZPayments { get => _regulationZPayments ?? (_regulationZPayments = new DirtyList<RegulationZPayment>()); set => _regulationZPayments = new DirtyList<RegulationZPayment>(value); }
        private DirtyValue<string> _regzTableType;
        /// <summary>
        /// REGZ Summary Table Type Used in REGZ-TIL Output [REGZ_TABLETYPE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Summary Table Type Used in REGZ-TIL Output")]
        public string RegzTableType { get => _regzTableType; set => _regzTableType = value; }
        private DirtyValue<bool?> _requiredDepositIndicator;
        /// <summary>
        /// REGZ Pymt Sched Required Deposit [664]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Pymt Sched Required Deposit", OptionsJson = "{\"true\":\"REQUIRED DEPOSIT: The annual % rate does not take into account your required deposit.\"}")]
        public bool? RequiredDepositIndicator { get => _requiredDepositIndicator; set => _requiredDepositIndicator = value; }
        private DirtyValue<DateTime?> _revisedClosingDisclosureReceivedDate;
        /// <summary>
        /// Revised Closing Disclosure received date [3980]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Revised Closing Disclosure received date")]
        public DateTime? RevisedClosingDisclosureReceivedDate { get => _revisedClosingDisclosureReceivedDate; set => _revisedClosingDisclosureReceivedDate = value; }
        private DirtyValue<DateTime?> _revisedClosingDisclosureSentDate;
        /// <summary>
        /// Revised Closing Disclosure sent date [3979]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Revised Closing Disclosure sent date")]
        public DateTime? RevisedClosingDisclosureSentDate { get => _revisedClosingDisclosureSentDate; set => _revisedClosingDisclosureSentDate = value; }
        private DirtyValue<DateTime?> _revisedGfeDueDate;
        /// <summary>
        /// Revised GFE Due Date [3167]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Revised GFE Due Date")]
        public DateTime? RevisedGfeDueDate { get => _revisedGfeDueDate; set => _revisedGfeDueDate = value; }
        private DirtyValue<decimal?> _roundedMarginPlusIndexPercent;
        /// <summary>
        /// Loan Info ARM Rounded Margin + Index [3296]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Loan Info ARM Rounded Margin + Index")]
        public decimal? RoundedMarginPlusIndexPercent { get => _roundedMarginPlusIndexPercent; set => _roundedMarginPlusIndexPercent = value; }
        private DirtyValue<DateTime?> _safeHarborSentDate;
        /// <summary>
        /// Safe Harbor Sent Date [4015]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Safe Harbor Sent Date")]
        public DateTime? SafeHarborSentDate { get => _safeHarborSentDate; set => _safeHarborSentDate = value; }
        private DirtyValue<decimal?> _samplePayments;
        /// <summary>
        /// Prequal Sample Pymt Amt [1958]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Prequal Sample Pymt Amt")]
        public decimal? SamplePayments { get => _samplePayments; set => _samplePayments = value; }
        private DirtyValue<StringEnumValue<SecurityType>> _securityType;
        /// <summary>
        /// Trans Details Goods Prchsd/Prprty Owned [671]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Goods Prchsd/Prprty Owned")]
        public StringEnumValue<SecurityType> SecurityType { get => _securityType; set => _securityType = value; }
        private DirtyValue<DateTime?> _sSPLSentDate;
        /// <summary>
        /// Settlement Services Provider List Sent Date [4014]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Settlement Services Provider List Sent Date")]
        public DateTime? SSPLSentDate { get => _sSPLSentDate; set => _sSPLSentDate = value; }
        private DirtyValue<DateTime?> _tilDate;
        /// <summary>
        /// Rans Details Disclosed Date [3122]
        /// </summary>
        [LoanFieldProperty(Description = "Rans Details Disclosed Date")]
        public DateTime? TilDate { get => _tilDate; set => _tilDate = value; }
        private DirtyValue<string> _tilDisclosedComments;
        /// <summary>
        /// TIL Disclosed Comments [3159]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Disclosed Comments")]
        public string TilDisclosedComments { get => _tilDisclosedComments; set => _tilDisclosedComments = value; }
        private DirtyValue<StringEnumValue<DisclosureMethod>> _tilDisclosureMethod;
        /// <summary>
        /// TIL Disclosure Method Drpdwn [3157]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Disclosure Method Drpdwn")]
        public StringEnumValue<DisclosureMethod> TilDisclosureMethod { get => _tilDisclosureMethod; set => _tilDisclosureMethod = value; }
        private DirtyValue<DateTime?> _tilLastDisclosedBorrowerReceivedDate;
        /// <summary>
        /// TIL Last Disclosed Borrower Received Date [3247]
        /// </summary>
        [LoanFieldProperty(Description = "TIL Last Disclosed Borrower Received Date")]
        public DateTime? TilLastDisclosedBorrowerReceivedDate { get => _tilLastDisclosedBorrowerReceivedDate; set => _tilLastDisclosedBorrowerReceivedDate = value; }
        private DirtyValue<string> _tilLastDisclosedBy;
        /// <summary>
        /// TIL Last Disclosed By [3158]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Last Disclosed By")]
        public string TilLastDisclosedBy { get => _tilLastDisclosedBy; set => _tilLastDisclosedBy = value; }
        private DirtyValue<DateTime?> _tilLastDisclosedDate;
        /// <summary>
        ///  Last CD Sent Date [3156]
        /// </summary>
        [LoanFieldProperty(Description = " Last CD Sent Date")]
        public DateTime? TilLastDisclosedDate { get => _tilLastDisclosedDate; set => _tilLastDisclosedDate = value; }
        private DirtyValue<DateTime?> _tilRedisclosureProvidedDate;
        /// <summary>
        /// TIL Redisclosure Provided Date [3154]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Redisclosure Provided Date")]
        public DateTime? TilRedisclosureProvidedDate { get => _tilRedisclosureProvidedDate; set => _tilRedisclosureProvidedDate = value; }
        private DirtyValue<DateTime?> _tilRedisclosureReceivedDate;
        /// <summary>
        /// TIL Redisclosure Rcvd Date [3155]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "TIL Redisclosure Rcvd Date")]
        public DateTime? TilRedisclosureReceivedDate { get => _tilRedisclosureReceivedDate; set => _tilRedisclosureReceivedDate = value; }
        private DirtyValue<decimal?> _totalBrokerFees;
        /// <summary>
        /// Total Broker Fees Collected [3310]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Broker Fees Collected")]
        public decimal? TotalBrokerFees { get => _totalBrokerFees; set => _totalBrokerFees = value; }
        private DirtyValue<decimal?> _totalLatePayment;
        /// <summary>
        /// Trans Details Total Late Payment [3877]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Total Late Payment")]
        public decimal? TotalLatePayment { get => _totalLatePayment; set => _totalLatePayment = value; }
        private DirtyValue<decimal?> _totalLenderFees;
        /// <summary>
        /// Total Lender Fees Collected [3311]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Lender Fees Collected")]
        public decimal? TotalLenderFees { get => _totalLenderFees; set => _totalLenderFees = value; }
        private DirtyValue<decimal?> _totalOfPayments;
        /// <summary>
        /// REGZ Total Amt All Pymts [1207]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "REGZ Total Amt All Pymts")]
        public decimal? TotalOfPayments { get => _totalOfPayments; set => _totalOfPayments = value; }
        private DirtyValue<decimal?> _totalOfPrincipalAndInterest;
        /// <summary>
        /// REGZ Total Amt All Principal and Interest [4071]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "REGZ Total Amt All Principal and Interest")]
        public decimal? TotalOfPrincipalAndInterest { get => _totalOfPrincipalAndInterest; set => _totalOfPrincipalAndInterest = value; }
        private DirtyValue<bool?> _useCustomLenderProfile;
        /// <summary>
        /// Use Custom Lender Profile [3626]
        /// </summary>
        [LoanFieldProperty(Description = "Use Custom Lender Profile")]
        public bool? UseCustomLenderProfile { get => _useCustomLenderProfile; set => _useCustomLenderProfile = value; }
        private DirtyValue<StringEnumValue<DaysInYear>> _useDaysInYears;
        /// <summary>
        /// Trans Details Amort Type Biweekly Days/Yr [SYS.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type Biweekly Days/Yr")]
        public StringEnumValue<DaysInYear> UseDaysInYears { get => _useDaysInYears; set => _useDaysInYears = value; }
        private DirtyValue<bool?> _usePitiForRatioIndicator;
        /// <summary>
        /// Trans Details Qualify Using P&amp;I [1853]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Qualify Using P&I", OptionsJson = "{\"true\":\"Qualify using P&I\"}")]
        public bool? UsePitiForRatioIndicator { get => _usePitiForRatioIndicator; set => _usePitiForRatioIndicator = value; }
        private DirtyValue<bool?> _variableRateFeatureIndicator;
        /// <summary>
        /// REGZ Pymt Sched Variable Rate Feature [665]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Pymt Sched Variable Rate Feature", OptionsJson = "{\"true\":\"VARIABLE RATE FEATURE: This loan contains a variable rate feature.\"}")]
        public bool? VariableRateFeatureIndicator { get => _variableRateFeatureIndicator; set => _variableRateFeatureIndicator = value; }
        private DirtyValue<decimal?> _yearlyTerm;
        /// <summary>
        /// Insurance Premium 1 Yr Term Pymt [1710]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Insurance Premium 1 Yr Term Pymt")]
        public decimal? YearlyTerm { get => _yearlyTerm; set => _yearlyTerm = value; }
        private DirtyValue<string> _yearOfMaximumPayment;
        /// <summary>
        /// Prequal Max Pymt Yr [1957]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Prequal Max Pymt Yr")]
        public string YearOfMaximumPayment { get => _yearOfMaximumPayment; set => _yearOfMaximumPayment = value; }
        private DirtyValue<int?> _years;
        /// <summary>
        /// Trans Details Amort Type GPM Yrs [1266]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Amort Type GPM Yrs")]
        public int? Years { get => _years; set => _years = value; }
        internal override bool DirtyInternal
        {
            get => _acknowledgedDay.Dirty
                || _acknowledgedMonth.Dirty
                || _acknowledgedYear.Dirty
                || _acquisition.Dirty
                || _additionalArmInformation.Dirty
                || _allDateAndNumericalDisclosuresIndicator.Dirty
                || _amountFinanced.Dirty
                || _aprPercent.Dirty
                || _aprPercentUI.Dirty
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
                _aprPercentUI.Dirty = value;
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