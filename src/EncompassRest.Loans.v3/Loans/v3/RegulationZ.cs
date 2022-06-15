using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// RegulationZ
/// </summary>
public sealed partial class RegulationZ : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// REGZ Acknowledgement Day [REGZ_DAY]
    /// </summary>
    public string? AcknowledgedDay { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Acknowledgement Mo [REGZ_MONTH]
    /// </summary>
    public string? AcknowledgedMonth { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Acknowledgement Yr [REGZ_YR]
    /// </summary>
    public string? AcknowledgedYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Acquisition of Land [1964]
    /// </summary>
    public bool? Acquisition { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Pymt Sched Additional Info [666]
    /// </summary>
    public string? AdditionalArmInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Dates/Num Discl Are Estimates [679]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"all dates and numerical disclosures except the late payment disclosures are estimates.\"}")]
    public bool? AllDateAndNumericalDisclosuresIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Total Amt Financed [948]
    /// </summary>
    public decimal? AmountFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details APR [799]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AprPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details APR - Display field with KBYO rounding rules [KBYO.XD799]
    /// </summary>
    public string? AprPercentUi { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal ARM Index [1960]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ArmDisclosureDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Assumption May/May Not [677]
    /// </summary>
    public StringEnumValue<AssumptionOnYourProperty> AssumptionOnYourProperty { get => GetValue<StringEnumValue<AssumptionOnYourProperty>>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Intent to Continue Date [3197]
    /// </summary>
    public DateTime? BorrowerIntendToContinueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Intends to Continue Chkbx [3164]
    /// </summary>
    public bool? BorrowerIntendToContinueIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Borr MI Termination Date [109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? BorrowerMiTerminationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Based On Remain Bal [1775]
    /// </summary>
    public string? CalculateBasedOnRemainingBalance { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Charges for the insurance are added to your loan payments [3531]
    /// </summary>
    public bool? ChargesAddedToPaymentsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Charges for the insurance are collected upfront at loan closing [3532]
    /// </summary>
    public bool? ChargesAtLoanClosingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Changed Circumstance Comments [3166]
    /// </summary>
    public string? CircumstanceChangeReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Changed Circumstance Rcvd Date [3165]
    /// </summary>
    public DateTime? CircumstanceChangeReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Received Date [3978]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ClosingDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Disclosure Sent Date [3977]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ClosingDisclosureSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction 1st Int. Change Adj. [Constr.FstIntChgAdj]
    /// </summary>
    public StringEnumValue<ConstructionFirstIntChangeAdjType> ConstructionFirstIntChangeAdjType { get => GetValue<StringEnumValue<ConstructionFirstIntChangeAdjType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Descr [1404]
    /// </summary>
    public string? ConstructionLoanDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage Est Interest On [SYS.X6]
    /// </summary>
    public StringEnumValue<ConstructionLoanMethod> ConstructionLoanMethod { get => GetValue<StringEnumValue<ConstructionLoanMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Period [1176]
    /// </summary>
    public int? ConstructionPeriodMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Interest Rate [1677]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? ConstructionRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Refinance Indicator [Constr.Refi]
    /// </summary>
    public bool? ConstructionRefinanceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium Credit Disability [1704]
    /// </summary>
    public decimal? CreditDisability { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Credit Disability [1698]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Credit insurance\"}")]
    public bool? CreditDisabilityIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium Credit Life [1703]
    /// </summary>
    public decimal? CreditLife { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium Credit Life/Disability [1705]
    /// </summary>
    public decimal? CreditLifeAndCreditDisability { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Credit Life [1697]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Credit life insurance\"}")]
    public bool? CreditLifeInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Pymt Sched Customize [1678]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Customize\"}")]
    public bool? CustomizePaymentScheduleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Pymt Sched Demand Feature [663]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"DEMAND FEATURE: This obligation has a demand feature.\"}")]
    public bool? DemandFeatureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Disclosed APR [3121]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DisclosedAprPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosed By Broker Chbx [3136]
    /// </summary>
    public bool? DisclosedByBrokerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Disclosed Comments [3141]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosedComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosed Daily Interest Charges [3887]
    /// </summary>
    public decimal? DisclosedDailyInterestCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosed Fees Total Finance Charges [3246]
    /// </summary>
    public decimal? DisclosedFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosed Prepayment [4018]
    /// </summary>
    public bool? DisclosedPrepayment { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosed Product [4017]
    /// </summary>
    public string? DisclosedProduct { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Disclosure Method [3138]
    /// </summary>
    public StringEnumValue<DisclosureMethod> DisclosureMethod { get => GetValue<StringEnumValue<DisclosureMethod>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Initial/Final Disclosure [662]
    /// </summary>
    public StringEnumValue<DisclosureType> DisclosureType { get => GetValue<StringEnumValue<DisclosureType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Period [2552]
    /// </summary>
    public int? DiscountPeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Rate [2551]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DiscountRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Pymt Discount Type [2307]
    /// </summary>
    public StringEnumValue<DiscountType> DiscountType { get => GetValue<StringEnumValue<DiscountType>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Due Date [3287]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? DueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Earliest Closing Date [3147]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? EarliestClosingDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Earliest Fee Collection Date [3145]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? EarliestFeeCollectionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 1 [3985]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 2 [3993]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 3 [4024]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 4 [4032]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 5 [4040]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Date Accepted Pair 6 [4048]
    /// </summary>
    public DateTime? ESignConsentBorrowerDateAccepted6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 1 [3986]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 2 [3994]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 3 [4025]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 4 [4033]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 5 [4041]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower IP Address Pair 6 [4049]
    /// </summary>
    public string? ESignConsentBorrowerIpAddress6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 1 [3987]
    /// </summary>
    public string? ESignConsentBorrowerSource1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 2 [3995]
    /// </summary>
    public string? ESignConsentBorrowerSource2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 3 [4026]
    /// </summary>
    public string? ESignConsentBorrowerSource3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 4 [4034]
    /// </summary>
    public string? ESignConsentBorrowerSource4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 5 [4042]
    /// </summary>
    public string? ESignConsentBorrowerSource5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Borrower Source Pair 6 [4050]
    /// </summary>
    public string? ESignConsentBorrowerSource6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 1 eConsent Status [3984]
    /// </summary>
    public string? ESignConsentBorrowerStatus1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 2 eConsent Status [3992]
    /// </summary>
    public string? ESignConsentBorrowerStatus2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 3 eConsent Status [4023]
    /// </summary>
    public string? ESignConsentBorrowerStatus3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 4 eConsent Status [4031]
    /// </summary>
    public string? ESignConsentBorrowerStatus4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 5 eConsent Status [4039]
    /// </summary>
    public string? ESignConsentBorrowerStatus5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower 6 eConsent Status [4047]
    /// </summary>
    public string? ESignConsentBorrowerStatus6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 1 [3989]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted1 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 2 [3997]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted2 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 3 [4028]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted3 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 4 [4036]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted4 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 5 [4044]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted5 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Date Accepted Pair 6 [4052]
    /// </summary>
    public DateTime? ESignConsentCoBorrowerDateAccepted6 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 1 [3990]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 2 [3998]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 3 [4029]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 4 [4037]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 5 [4045]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower IP Address Pair 6 [4053]
    /// </summary>
    public string? ESignConsentCoBorrowerIpAddress6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 1 [3991]
    /// </summary>
    public string? ESignConsentCoBorrowerSource1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 2 [3999]
    /// </summary>
    public string? ESignConsentCoBorrowerSource2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 3 [4030]
    /// </summary>
    public string? ESignConsentCoBorrowerSource3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 4 [4038]
    /// </summary>
    public string? ESignConsentCoBorrowerSource4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 5 [4046]
    /// </summary>
    public string? ESignConsentCoBorrowerSource5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Co-Borrower Source Pair 6 [4054]
    /// </summary>
    public string? ESignConsentCoBorrowerSource6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 1 eConsent Status [3988]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 2 eConsent Status [3996]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 3 eConsent Status [4027]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 4 eConsent Status [4035]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 5 eConsent Status [4043]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Co-Borrower 6 eConsent Status [4051]
    /// </summary>
    public string? ESignConsentCoBorrowerStatus6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// eConsent Date [3983]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? ESignConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Flag to know whether loan is external eConsent [4499]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ExternaleConsent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type GPM Extra Pymt [312]
    /// </summary>
    public decimal? ExtraPaymentForEarlyPayOff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Collected Date [3146]
    /// </summary>
    public DateTime? FeeCollectedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fee Level Disclosures Indicator [4461]
    /// </summary>
    public bool? FeeLevelDisclosuresIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Filing Fees [1707]
    /// </summary>
    public decimal? FilingFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage Final Pymt Date [1961]
    /// </summary>
    public DateTime? FinalPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Finance Charges [1206]
    /// </summary>
    public decimal? FinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Financed Guarantee Fee - Guarantee Amount [3561]
    /// </summary>
    public decimal? FinancedAllGuaranteeFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Financed Guarantee Fee - Guarantee Percentage [3560]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"0.50\":\"0.50\",\"1.00\":\"1.00\",\"1.25\":\"1.25\",\"1.50\":\"1.50\",\"1.75\":\"1.75\",\"2.00\":\"2.00\",\"2.25\":\"2.25\",\"2.50\":\"2.50\",\"2.75\":\"2.75\",\"3.00\":\"3.00\",\"3.25\":\"3.25\",\"3.50\":\"3.50\",\"3.75\":\"3.75\",\"4.00\":\"4.00\"}")]
    public decimal? FinancedAllGuaranteeFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Financed Guarantee Fee - Total Loan Amount [3562]
    /// </summary>
    public decimal? FinancedAllTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Guarantee Amount [3564]
    /// </summary>
    public decimal? FinancedPortionGuaranteeFeeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Guarantee Percentage [3563]
    /// </summary>
    public decimal? FinancedPortionGuaranteeFeePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Portion of Financed Guarantee Fee - Total Loan Amount [3565]
    /// </summary>
    public decimal? FinancedPortionTotalLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// USDA Financing Type [3566]
    /// </summary>
    public StringEnumValue<FinancingType> FinancingType { get => GetValue<StringEnumValue<FinancingType>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage 1st Amortization Date [1963]
    /// </summary>
    public DateTime? FirstAmortizationPaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Flood [676]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Flood insurance\"}")]
    public bool? FloodInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Application Date [3142]
    /// </summary>
    public DateTime? GfeApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Changed Circumstance Chkbx [3168]
    /// </summary>
    public bool? GfeChangedCircumstanceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Changed Circumstance [3169]
    /// </summary>
    public string? GfeChangedCircumstanceItem { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Changed Circumstance Code [3627]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? GfeChangedCirsumstanceItemCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Date for Printed Form [3170]
    /// </summary>
    public DateTime? GfeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Expiration Date [3140]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// No. of Days GFE Valid After Received [3162]
    /// </summary>
    public string? GfeExpirationPeriod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Redisclosure Required Due to Rate Lock [3201]
    /// </summary>
    public bool? GfeRateLockRedisclosureRequiredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Redisclosure Provided Date [3150]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeRedisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Redisclosure Received Date [3151]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? GfeRedisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Heloc Teaser Rate Period Months [4492]
    /// </summary>
    public int? HelocTeaserRatePeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// The Date that the High Cost Disclosure is signed [4022]
    /// </summary>
    public DateTime? HighCostDisclosure { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Date the Home Counseling Disclosure Provided to the Borrower [3859]
    /// </summary>
    public DateTime? HomeCounselingProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1Tolerance Lmt Violation [3160]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? Hud1ToleranceViolatedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution Comments [3172]
    /// </summary>
    public string? HudToleranceResolutionComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution Date [3171]
    /// </summary>
    public DateTime? HudToleranceResolutionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1 Tolerance Resolution User [3173]
    /// </summary>
    public string? HudToleranceResolvedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium If you purchase [1708]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"If you purchase\"}")]
    public bool? IfYouPurchaseIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium Haz/Flood/Haz&amp;Flood [1709]
    /// </summary>
    public StringEnumValue<IfYouPurchaseType> IfYouPurchaseType { get => GetValue<StringEnumValue<IfYouPurchaseType>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Mortgage Insurance [3266]
    /// </summary>
    public bool? IncludeMiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Private Mortgage Insurance [3265]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? IncludePmiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Include Escrowed Taxes and Insurance [3264]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? IncludeTaxesInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Date the AVM Provided to the Borrower [3858]
    /// </summary>
    public DateTime? InitialAvmProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Disclosure Due Date [3143]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialDisclosureDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Initial Disclosure Provided Date [3144]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialDisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Affiliated Business Disclosure Provided Date [3544]
    /// </summary>
    public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Date the Appraisal was provided to the Borrower [3624]
    /// </summary>
    public DateTime? InitialGfeAppraisalProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure CHARM Booklet Provided Date [3545]
    /// </summary>
    public DateTime? InitialGfeCharmBookletProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Provided Date [3148]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialGfeDisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure Received Date [3149]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialGfeDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure HELOC Brochure Provided Date [3547]
    /// </summary>
    public DateTime? InitialGfeHelocBrochureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Initial GFE Disclosure HUD Special Booklet Provided Date [3546]
    /// </summary>
    public DateTime? InitialGfeHudSpecialBookletProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Date the Subsequent Appraisal Provided to the Borrower [3857]
    /// </summary>
    public DateTime? InitialSubsequentAppraisalProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Intl Disclosure Provided Date [3152]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialTilDisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Intl TIL Disclosure Rcvd Date [3153]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? InitialTilDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Required [1702]
    /// </summary>
    public string? InsuranceRequiredDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Interest Accrual for APR [4747]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<InterestAccrual> InterestAccrual { get => GetValue<StringEnumValue<InterestAccrual>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Security Interest [1603]
    /// </summary>
    public string? InterestInNameOf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Interest Only Indicator [Terms.IntrOnly]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public bool? InterestOnly { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [2982]
    /// </summary>
    public bool? InterestOnlyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Only Mos [1177]
    /// </summary>
    public int? InterestOnlyMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage Interest Rate Type [2820]
    /// </summary>
    public StringEnumValue<InterestRateType> InterestRateType { get => GetValue<StringEnumValue<InterestRateType>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Constr Loan Required Resrv [1265]
    /// </summary>
    public decimal? InterestReserveAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Loan Info - Land Value Type [URLA.X262]
    /// </summary>
    public StringEnumValue<LandValueType> LandValueType { get => GetValue<StringEnumValue<LandValueType>>(); set => SetValue(value); }

    /// <summary>
    /// GFE Last Disclosed By [3139]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastDisclosedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Last Disclosed Date [3137]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastDisclosedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// GFE Last Disclosure Rcvd Date [3163]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastDisclosedGfeReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Late Charge Basis [4186]
    /// </summary>
    public decimal? LateChargeBasis { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Late Charge Additional Detail [1854]
    /// </summary>
    public string? LateChargeComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Late Charge Days [672]
    /// </summary>
    public int? LateChargeDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Late Charge % [674]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LateChargePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Late Charge % Based On [1719]
    /// </summary>
    public StringEnumValue<LateChargeType> LateChargeType { get => GetValue<StringEnumValue<LateChargeType>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Late Fee [3876]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Intent To Proceed Comment [3976]
    /// </summary>
    public string? LeIntentToProceedComment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Paid Mortgage Insurance [3533]
    /// </summary>
    public bool? LenderPaidMortgageInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage Lenders Inspection Rate [3899]
    /// </summary>
    public decimal? LendersInspectionFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Intent To Proceed Received By [3973]
    /// </summary>
    public string? LeReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Intent To Proceed Received Method [3974]
    /// </summary>
    public StringEnumValue<LEReceivedMethod> LeReceivedMethod { get => GetValue<StringEnumValue<LEReceivedMethod>>(); set => SetValue(value); }

    /// <summary>
    /// LE Intent To Proceed Received Method Other [3975]
    /// </summary>
    public string? LeReceivedMethodOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE Intent To Proceed Sent On Date [3972]
    /// </summary>
    public DateTime? LeSentOnDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Margin + Index [1827]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? MarginPlusIndexPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Maximum Late Charge [2832]
    /// </summary>
    public decimal? MaximumLateCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Maximum Payment [1896]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MaximumPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details E Means Estimate [680]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"means an estimate\"}")]
    public bool? MeansAnEstimateIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Periodic Factor 2 [1201]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? MiAdjustmentFactorLevel2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Declining Renewals [3248]
    /// </summary>
    public bool? MiDecliningRenewalsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Midpoint Pymt Cancel [1753]
    /// </summary>
    public string? MidpointCancellation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Pymt 1 [1766]
    /// </summary>
    public decimal? MiMonthlyPaymentLevel1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Pymt 2 [1770]
    /// </summary>
    public decimal? MiMonthlyPaymentLevel2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Period 1 [1198]
    /// </summary>
    public int? MiMonthsOfAdjustmentLevel1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Period 2 [1200]
    /// </summary>
    public int? MiMonthsOfAdjustmentLevel2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Minimum Late Charge [2831]
    /// </summary>
    public decimal? MinimumLateCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Minimum Payment [1895]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MinimumPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MI Factor Field Locked [3625]
    /// </summary>
    public bool? MipFactorLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MI Prepaid Amount [3971]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MiPrepaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Mnths Prepaid [2978]
    /// </summary>
    public bool? MiPrepaidIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Calculation Borr MI Termination Date [118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? MiScheduledTerminationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance MMI [723]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"MMI\"}")]
    public bool? MmiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium 1 Monthly Term Pymt [4081]
    /// </summary>
    public decimal? MonthlyTerm { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Mos Prepaid [1209]
    /// </summary>
    public int? MonthsOfMiPrepaid { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Mtg Ins Cancel at % [1205]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? MortgageInsuranceCancelPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Prepared By Name [2026]
    /// </summary>
    public string? NamePreparedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Loan New Construction Indicator [2645]
    /// </summary>
    public string? NewConstructionIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Total # Pymts [1701]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? NumberOfPayments { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Occupancy Cert Date [4080]
    /// </summary>
    public DateTime? OccupancyCertDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Construction Loan Original Contract Date [2646]
    /// </summary>
    public DateTime? OriginalContractDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ-TIL Interest Rate and Payment Summary Table - Construction - Outstanding Balance [3288]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OutstandingBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Payment Frequency Type Description [3291]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PaymentFrequencyType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// GPM Payment Increase [Terms.GPMPmtIncr]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? PaymentIncreasePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Prepared By Phone [2027]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhonePreparedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance PMI [8]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"PMI\"}")]
    public bool? PmiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// PMI Midpoint Cancelation Date [3548]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PmiMidpointCancelationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Post Consummation Disclosure Received Date [3982]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PostConsummationDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Post Consummation Disclosure Sent Date [3981]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? PostConsummationDisclosureSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Prepaid Finance Charges [949]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PrepaidFinanceCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Property [1242]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Hazard Insurance\"}")]
    public bool? PropertyInsuranceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Rate Lock GFE Due Date [3161]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RateLockGfeDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type GPM Rate [1267]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? RatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Recast Period [1712]
    /// </summary>
    public int? RecastPaidMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Recast Stop [1713]
    /// </summary>
    public int? RecastStopMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Prepymt - May/Will Not Refund [670]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"may\",\"N\":\"will not\"}")]
    public bool? RefundPaymentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Refund prorated unearned Up Front MI Premiums [3262]
    /// </summary>
    public bool? RefundUnearnedMipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RegulationZ RegulationZInterestRatePeriods
    /// </summary>
    [AllowNull]
    public IList<RegulationZInterestRatePeriod> RegulationZInterestRatePeriods { get => GetList<RegulationZInterestRatePeriod>(); set => SetList(value); }

    /// <summary>
    /// RegulationZ RegulationZPayments
    /// </summary>
    [AllowNull]
    public IList<RegulationZPayment> RegulationZPayments { get => GetList<RegulationZPayment>(); set => SetList(value); }

    /// <summary>
    /// REGZ Summary Table Type Used in REGZ-TIL Output [REGZ_TABLETYPE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RegzTableType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Pymt Sched Required Deposit [664]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"REQUIRED DEPOSIT: The annual % rate does not take into account your required deposit.\"}")]
    public bool? RequiredDepositIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Revised Closing Disclosure received date [3980]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedClosingDisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Revised Closing Disclosure sent date [3979]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedClosingDisclosureSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Revised GFE Due Date [3167]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? RevisedGfeDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info ARM Rounded Margin + Index [3296]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? RoundedMarginPlusIndexPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Safe Harbor Sent Date [4015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SafeHarborSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Sample Pymt Amt [1958]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SamplePayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Goods Prchsd/Prprty Owned [671]
    /// </summary>
    public StringEnumValue<SecurityType> SecurityType { get => GetValue<StringEnumValue<SecurityType>>(); set => SetValue(value); }

    /// <summary>
    /// Use Simple Interest Accrual [4749]
    /// </summary>
    public bool? SimpleInterestAccrualIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Simple Interest Uses Leap Year [4748]
    /// </summary>
    public bool? SimpleInterestLeapYearIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Settlement Services Provider List Sent Date [4014]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? SsplSentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Disclosed Date [3122]
    /// </summary>
    public DateTime? TilDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Disclosed Comments [3159]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TilDisclosedComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Disclosure Method Drpdwn [3157]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<DisclosureMethod> TilDisclosureMethod { get => GetValue<StringEnumValue<DisclosureMethod>>(); set => SetValue(value); }

    /// <summary>
    /// TIL Last Disclosed Borrower Received Date [3247]
    /// </summary>
    public DateTime? TilLastDisclosedBorrowerReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Last Disclosed By [3158]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TilLastDisclosedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    ///  Last CD Sent Date [3156]
    /// </summary>
    public DateTime? TilLastDisclosedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Redisclosure Provided Date [3154]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? TilRedisclosureProvidedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// TIL Redisclosure Rcvd Date [3155]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? TilRedisclosureReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Total Broker Fees Collected [3310]
    /// </summary>
    public decimal? TotalBrokerFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Total Late Payment [3877]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLatePayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Lender Fees Collected [3311]
    /// </summary>
    public decimal? TotalLenderFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Total Amt All Pymts [1207]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOfPayments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Total Amt All Principal and Interest [4071]
    /// </summary>
    public decimal? TotalOfPrincipalAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Use Custom Lender Profile [3626]
    /// </summary>
    public bool? UseCustomLenderProfile { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type Biweekly Days/Yr [SYS.X2]
    /// </summary>
    public StringEnumValue<DaysInYear> UseDaysInYears { get => GetValue<StringEnumValue<DaysInYear>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Qualify Using P&amp;I [1853]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Qualify using P&I\"}")]
    public bool? UsePitiForRatioIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Pymt Sched Variable Rate Feature [665]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"VARIABLE RATE FEATURE: This loan contains a variable rate feature.\"}")]
    public bool? VariableRateFeatureIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Insurance Premium 1 Yr Term Pymt [1710]
    /// </summary>
    public decimal? YearlyTerm { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prequal Max Pymt Yr [1957]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? YearOfMaximumPayment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type GPM Yrs [1266]
    /// </summary>
    public int? Years { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Zero Percent Payment Options [4746]
    /// </summary>
    public StringEnumValue<ZeroPercentPaymentOption> ZeroPercentPaymentOption { get => GetValue<StringEnumValue<ZeroPercentPaymentOption>>(); set => SetValue(value); }
}