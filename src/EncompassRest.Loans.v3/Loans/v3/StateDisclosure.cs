using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// StateDisclosure
/// </summary>
public sealed partial class StateDisclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Disclosure-FL Borr Accept [FLMTGCM.X10]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The date by which the commitment must be accepted by the borrower is\"}")]
    public bool? AcceptedByBorrowerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Accept Date [FLMTGCM.X11]
    /// </summary>
    public DateTime? AcceptedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Act Descr 1 [DISCLOSURE.X77]
    /// </summary>
    public string? ActingOtherDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Act Descr 2 [DISCLOSURE.X78]
    /// </summary>
    public string? ActingOtherDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Act as Follows [DISCLOSURE.X76]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"We will be acting as follows:\"}")]
    public bool? ActingOthersIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ Advance Fee Agreement In Effect Number Of Days [DISCLOSURE.X915]
    /// </summary>
    public int? AdvFeeAgmtInEfctNumDay { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Acknowledge 1 [DISCLOSURE.X105]
    /// </summary>
    public string? AdvisoryCondition1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Acknowledge 2 [DISCLOSURE.X106]
    /// </summary>
    public string? AdvisoryCondition2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Acknowledge 3 [DISCLOSURE.X107]
    /// </summary>
    public string? AdvisoryCondition3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Acknowledge 4 [DISCLOSURE.X108]
    /// </summary>
    public string? AdvisoryCondition4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Amended Acquisition Cost [DISCLOSURE.X974]
    /// </summary>
    public decimal? AmendedAcquisitionCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Application Date [DISCLOSURE.X172]
    /// </summary>
    public DateTime? ApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Appraisal Fee Descr [DISCLOSURE.X84]
    /// </summary>
    public string? AppraisalContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Appraisal Fee [DISCLOSURE.X69]
    /// </summary>
    public decimal? AppraisalDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Areas [DISCLOSURE.X960]
    /// </summary>
    public StringEnumValue<Areas> Areas { get => GetValue<StringEnumValue<Areas>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Role - Attorney [DISCLOSURE.X99]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"as an attorney for\"}")]
    public bool? AsAttorneyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Role - RE Broker/Agent [DISCLOSURE.X95]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"as a real estate broker, agent, or salesperson for\"}")]
    public bool? AsRealBrokerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Attorney for Buyer [DISCLOSURE.X101]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"you (the buyer)\"}")]
    public bool? AttorneyForTheBuyerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Attorney for Buyer/Seller [DISCLOSURE.X102]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"the lender\"}")]
    public bool? AttorneyForTheLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Attorney for Seller [DISCLOSURE.X100]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"the seller\"}")]
    public bool? AttorneyForTheSellerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document Description 1 [DISCLOSURE.X917]
    /// </summary>
    public string? AzCmplBlankSpcsDoc1BlankFldDesc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document Description 2 [DISCLOSURE.X919]
    /// </summary>
    public string? AzCmplBlankSpcsDoc1BlankFldDesc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document Description 3 [DISCLOSURE.X921]
    /// </summary>
    public string? AzCmplBlankSpcsDoc1BlankFldDesc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document 1 [DISCLOSURE.X916]
    /// </summary>
    public string? AzCmplBlankSpcsDoc1Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document 2 [DISCLOSURE.X918]
    /// </summary>
    public string? AzCmplBlankSpcsDoc2Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-AZ AZ Complete Blank Spaces Document 3 [DISCLOSURE.X920]
    /// </summary>
    public string? AzCmplBlankSpcsDoc3Nm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Compensated Based on Others Description [DISCLOSURE.X909]
    /// </summary>
    public string? BasedOnOthersDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Compensated Based on Others [DISCLOSURE.X908]
    /// </summary>
    public bool? BasedOnOthersIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Compensated Wholesale Options [DISCLOSURE.X80]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Our pricing for your loan is based upon current wholesale options available to us\"}")]
    public bool? BasedOnWholesaleOptionsIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure- CA Borrower Elects To Establish Escrow Account Amount [DISCLOSURE.X914]
    /// </summary>
    public decimal? BorrowerElectsEstablishEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure- CA Borrower Elects To Establish Escrow Account Indicator [DISCLOSURE.X913]
    /// </summary>
    public bool? BorrowerElectsEstablishEscrowIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Broker Fee Amt [DISCLOSURE.X62]
    /// </summary>
    public decimal? BrokerageFeeAddition1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp From Amt [DISCLOSURE.X64]
    /// </summary>
    public decimal? BrokerageFeeAddition2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp To Amt [DISCLOSURE.X66]
    /// </summary>
    public decimal? BrokerageFeeAddition3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Broker Fee Total [FLGFE.X38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrokerageFeeAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp From Total [FLGFE.X39]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrokerageFeeAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp To Total [FLGFE.X40]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrokerageFeeAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Broker Fee # Days [FLGFE.X41]
    /// </summary>
    public int? BrokerageFeeDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Broker Fee % [DISCLOSURE.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerageFeePercent1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp From % [DISCLOSURE.X63]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerageFeePercent2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Borr Paid Comp To % [DISCLOSURE.X65]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerageFeePercent3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Broker Authorized Signing Representative Name [DISCLOSURE.X922]
    /// </summary>
    public string? BrokerAuthorizedSigningRepName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Broker Authorized Signing Representative Title [DISCLOSURE.X923]
    /// </summary>
    public string? BrokerAuthorizedSigningRepTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Broker for Seller/Buyer/Buyer and Seller [DISCLOSURE.X96]
    /// </summary>
    public StringEnumValue<BrokerForTheSeller> BrokerForTheSeller { get => GetValue<StringEnumValue<BrokerForTheSeller>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX License # [DISCLOSURE.X73]
    /// </summary>
    public string? BrokerLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Broker/Loan Officer [DISCLOSURE.X72]
    /// </summary>
    public string? BrokerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Fee + [DISCLOSURE.X98]
    /// </summary>
    public decimal? BrokerPayAddition { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Fee Amt [DISCLOSURE.X116]
    /// </summary>
    public decimal? BrokerPayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Fee [DISCLOSURE.X114]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I will pay you a fee of\"}")]
    public bool? BrokerPayIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Fee % [DISCLOSURE.X115]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerPayPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Federal CHARM booklet [FLGFE.X73]
    /// </summary>
    public bool? CharmBookletIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Check Payable To [DISCLOSURE.X170]
    /// </summary>
    public string? CheckPayableTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Interest Rate Fee Amt [FLMTGCM.X15]
    /// </summary>
    public decimal? CommitmentAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Loan Commit Conditions 1 [DISCLOSURE.X103]
    /// </summary>
    public string? CommitmentCondition1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Loan Commit Conditions 2 [DISCLOSURE.X104]
    /// </summary>
    public string? CommitmentCondition2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Commitment Fee [FLMTGCM.X7]
    /// </summary>
    public decimal? CommitmentFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Interest Rate Fee % [FLMTGCM.X14]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CommitmentPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Lender Paid Broker Comp To % [FLGFE.X51]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CompensationAddition { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Lender Paid Broker Comp From % [FLGFE.X50]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? CompensationPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Credit Deposit [DISCLOSURE.X70]
    /// </summary>
    public decimal? CreditDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Credit Score Used From The Credit Report to Set the Terms of Credit [DISCLOSURE.X637]
    /// </summary>
    public string? CreditIsUsedForReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Credit Rpt Fee Descr [DISCLOSURE.X86]
    /// </summary>
    public string? CreditReportContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Rate Est # Days Before Close [FLMTGCM.X6]
    /// </summary>
    public int? DaysBeforeClosing { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Receipt of Deposit Amt [FLGFE.X53]
    /// </summary>
    public decimal? DepositReceipt { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Deposit Refundable [FLGFE.X55]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Refundable by\"}", ReadOnly = true)]
    public bool? DepositRefundableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Direct inquiries To [FLGFE.X70]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DirectContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Direct Amt [DISCLOSURE.X121]
    /// </summary>
    public decimal? DirectPayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY  Broker Paid Direct at Close [DISCLOSURE.X119]
    /// </summary>
    public decimal? DirectPayClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Direct at Commit [DISCLOSURE.X118]
    /// </summary>
    public decimal? DirectPayCommitment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Direct [DISCLOSURE.X117]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I will pay you directly, upon my signed acceptance of a commitment\"}")]
    public bool? DirectPayIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Paid Direct % [DISCLOSURE.X120]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? DirectPayPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - TX - Disclosure Delivered By [DISCLOSURE.X957]
    /// </summary>
    public StringEnumValue<DisclosureDeliveredBy> DisclosureDeliveredBy { get => GetValue<StringEnumValue<DisclosureDeliveredBy>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - TX - Disclosure Delivered By Other Method [DISCLOSURE.X958]
    /// </summary>
    public string? DisclosureDeliveredByOtherMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - TX - Disclosure Delivered Date [DISCLOSURE.X959]
    /// </summary>
    public DateTime? DisclosureDeliveredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Estimated fees Will be Shown on the Good Faith Estimate Which We are Providing Now or Within three (3) Days. [DISCLOSURE.X910]
    /// </summary>
    public bool? EstimatedChargeShownOnGfeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Expiration Date [FLMTGCM.X1]
    /// </summary>
    public DateTime? ExpirationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Federally-Subsidized Amount [DISCLOSURE.X964]
    /// </summary>
    public decimal? FederallySubsidizedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Federally-Subsidized Amount Percentage [DISCLOSURE.X963]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FederallySubsidizedAmountPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Fee Amt [DISCLOSURE.X150]
    /// </summary>
    public decimal? FeeReceived1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Recipient Fee Amt [DISCLOSURE.X152]
    /// </summary>
    public decimal? FeeReceived2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Lender Fee Refund/Non-Refund [FLGFE.X71]
    /// </summary>
    public StringEnumValue<RefundableType> FeeReceivedByLender { get => GetValue<StringEnumValue<RefundableType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Rec $ Fees [DISCLOSURE.X81]
    /// </summary>
    public decimal? FeesReceiving { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Application Fee [DISCLOSURE.X67]
    /// </summary>
    public decimal? FloridaApplicationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 1 Amt [FLMTGCM.X18]
    /// </summary>
    public decimal? FloridaOtherFee1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 3 Amt [FLMTGCM.X21]
    /// </summary>
    public decimal? FloridaOtherFee2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 1 Descr [FLMTGCM.X17]
    /// </summary>
    public string? FloridaOtherFeeTo1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 2 Descr [FLMTGCM.X19]
    /// </summary>
    public string? FloridaOtherFeeTo2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 3 Descr [FLMTGCM.X20]
    /// </summary>
    public string? FloridaOtherFeeTo3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Other Fee 4 Descr [FLMTGCM.X22]
    /// </summary>
    public string? FloridaOtherFeeTo4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Further Explanation of Any Fee Earned by Mortgage Broker [DISCLOSURE.X949]
    /// </summary>
    public string? FurtherFeesEarnedByMortgageBroker { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY GFE Amt [DISCLOSURE.X151]
    /// </summary>
    public decimal? GfeFeeReceived1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Recipient GFE Amt [DISCLOSURE.X153]
    /// </summary>
    public decimal? GfeFeeReceived2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL HUD settlement booklet [FLGFE.X75]
    /// </summary>
    public bool? HudBookletIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Act as Independent Contractor [DISCLOSURE.X75]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"We are acting as an independent contractor\"}")]
    public bool? IndependentContractorIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Int Rate Index Used [DISCLOSURE.X168]
    /// </summary>
    public string? IndexUsed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Int Rate Index Info [DISCLOSURE.X169]
    /// </summary>
    public string? InformationAboutTheIndexCanBeFound { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Licensed No [DISCLOSURE.X1027]
    /// </summary>
    public string? InLicensedNo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Licensed Type [DISCLOSURE.X1028]
    /// </summary>
    public StringEnumValue<InLicensedType> InLicensedType { get => GetValue<StringEnumValue<InLicensedType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL is Estimate [FLMTGCM.X12]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"This disclosure is an ESTIMATE. Some of the information necessary for an accurate disclosure is unknown to the lender. This disclosure is based upon the best information reasonably available to the lender at this time.\"}")]
    public bool? IsEstimateIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - KS - Kansas UCCC Election [DISCLOSURE.X954]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? KsUcccElectionIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - KY - Kentucky Home Solicitation Loan [DISCLOSURE.X956]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? KyHomeSolicitationLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Lease Agreement Date [DISCLOSURE.X975]
    /// </summary>
    public DateTime? LeaseAgreementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Date [DISCLOSURE.X156]
    /// </summary>
    public DateTime? LenderDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender [DISCLOSURE.X154]
    /// </summary>
    public string? LenderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Lender fee paid to licensee [FLGFE.X77]
    /// </summary>
    public decimal? LenderPaid { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Paid Fee Amt [DISCLOSURE.X111]
    /// </summary>
    public decimal? LenderPayAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Paid Fee [DISCLOSURE.X109]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The lender will pay you a fee of\"}")]
    public bool? LenderPayIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Paid Points Max [DISCLOSURE.X113]
    /// </summary>
    public decimal? LenderPayMaxPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Paid Fee % [DISCLOSURE.X110]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LenderPayPercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Paid Points [DISCLOSURE.X112]
    /// </summary>
    public decimal? LenderPayPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Fee Unknown [DISCLOSURE.X97]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The fee the lender will pay you is not known. The maximum points paid including premium pricing shall not\"}")]
    public bool? LenderPayUnknownIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Status/Disposition [DISCLOSURE.X155]
    /// </summary>
    public string? LenderStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Lessor Name [DISCLOSURE.X976]
    /// </summary>
    public string? LessorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-Loan Terms Fixed Through Date of Loan Closing [DISCLOSURE.X951]
    /// </summary>
    public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Lock-in Fee [FLMTGCM.X13]
    /// </summary>
    public decimal? LockInFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Rate Index at Closing [FLMTGCM.X4]
    /// </summary>
    public string? MethodDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Rate Index Subject to Change [FLMTGCM.X3]
    /// </summary>
    public StringEnumValue<MethodDetermine> MethodDetermine { get => GetValue<StringEnumValue<MethodDetermine>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Mortgage loan origination agreement [FLGFE.X72]
    /// </summary>
    public bool? MortgageAgreementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Broker License # [FLGFE.X57]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? MtgBrokerLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Licensee Name [DISCLOSURE.X171]
    /// </summary>
    public string? NameOfLicensee { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY New Money Amount [DISCLOSURE.X993]
    /// </summary>
    public decimal? NewMoneyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Application Fee [DISCLOSURE.X122]
    /// </summary>
    public decimal? NewYorkApplicationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appraisal Fee [DISCLOSURE.X123]
    /// </summary>
    public decimal? NewYorkAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Credit Fee [DISCLOSURE.X124]
    /// </summary>
    public decimal? NewYorkCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// StateDisclosure NewYorkFees
    /// </summary>
    [AllowNull]
    public IList<NewYorkFee> NewYorkFees { get => GetList<NewYorkFee>(); set => SetList(value); }

    /// <summary>
    /// StateDisclosure NewYorkPrimaryLenders
    /// </summary>
    [AllowNull]
    public IList<NewYorkPrimaryLender> NewYorkPrimaryLenders { get => GetList<NewYorkPrimaryLender>(); set => SetList(value); }

    /// <summary>
    /// Disclosure-NY Processing Fee [DISCLOSURE.X127]
    /// </summary>
    public decimal? NewYorkProcessingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Non-Refundable Amt [DISCLOSURE.X94]
    /// </summary>
    public decimal? NotRefundableAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Compensated Retail Price [DISCLOSURE.X79]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"The retail price we offer you\"}")]
    public bool? OfferRetailPriceIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Original Acquisition Cost [DISCLOSURE.X973]
    /// </summary>
    public decimal? OriginalAcquisitionCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Origination Fee Charged Amount [DISCLOSURE.X925]
    /// </summary>
    public decimal? OriginationFeeChargedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Origination Fee Charged Indicator [DISCLOSURE.X924]
    /// </summary>
    public bool? OriginationFeeChargedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Origination Fee Decreases Interest Rate By [DISCLOSURE.X928]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationFeeDecreasesRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Origination Fee Increases Interest Rate By [DISCLOSURE.X929]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? OriginationFeeIncreasesRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Identify one of three possible impacts of Origination Fee on the Interest Rate [DISCLOSURE.X927]
    /// </summary>
    public StringEnumValue<InterestRateImpactedStatus> OriginationFeeInterestRateImpactedStatus { get => GetValue<StringEnumValue<InterestRateImpactedStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Origination Fee Paid By [DISCLOSURE.X926]
    /// </summary>
    public StringEnumValue<StateDisclosureFeePaidBy> OriginationFeePaidBy { get => GetValue<StringEnumValue<StateDisclosureFeePaidBy>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Fee Borr [DISCLOSURE.X158]
    /// </summary>
    public decimal? PaidByBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Broker Fee Lender Paid [DISCLOSURE.X157]
    /// </summary>
    public decimal? PaidByLender { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Other Fee 1 Amt [DISCLOSURE.X160]
    /// </summary>
    public decimal? PaidByOther1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Other Fee 2 Amt [DISCLOSURE.X162]
    /// </summary>
    public decimal? PaidByOther2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Other Fee 1 Descr [DISCLOSURE.X159]
    /// </summary>
    public string? PaidByOtherDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Other Fee 2 Descr [DISCLOSURE.X161]
    /// </summary>
    public string? PaidByOtherDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Previous Mortgage Amount 1 [DISCLOSURE.X994]
    /// </summary>
    public decimal? PreviousMortgageAmountOne { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Previous Mortgage Amount 2 [DISCLOSURE.X995]
    /// </summary>
    public decimal? PreviousMortgageAmountTwo { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Print Certification O fCosts [DISCLOSURE.X962]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? PrintCertificationOfCosts { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Print Interest Rate Reduction Rider [DISCLOSURE.X961]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? PrintInterestRateReductionRider { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-MD Print MD Delivery of Net Proceeds Authorization Disclosure [DISCLOSURE.X911]
    /// </summary>
    public bool? PrintMdDeliveryIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL GFE Provided By [FLGFE.X67]
    /// </summary>
    public StringEnumValue<ProvidedBy> ProvidedBy { get => GetValue<StringEnumValue<ProvidedBy>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Ques/Comments To [DISCLOSURE.X128]
    /// </summary>
    public string? QuestionContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Ques/Comments Phone [DISCLOSURE.X129]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? QuestionContactPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Ques/Comments Toll Free [DISCLOSURE.X130]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? QuestionContactTollFree { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY-Rate Lock honored only if loan closes at least 3 business days prior to the Lock Expiration Date [DISCLOSURE.X950]
    /// </summary>
    public bool? RateLockHonoredIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Fee Recipient [DISCLOSURE.X149]
    /// </summary>
    public string? ReceivedBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Refi Fee [FLMTGCM.X16]
    /// </summary>
    public decimal? RefinancingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Deposit Refundable By [FLGFE.X56]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RefundableBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Commitment Fee Refundable If [FLMTGCM.X8]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Refundable If\"}")]
    public bool? RefundableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Appl Fee Refund/Non Refund [DISCLOSURE.X68]
    /// </summary>
    public StringEnumValue<RefundableType> RefundableType { get => GetValue<StringEnumValue<RefundableType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 1 [DISCLOSURE.X125]
    /// </summary>
    public string? RefundCondition1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 2 [DISCLOSURE.X126]
    /// </summary>
    public string? RefundCondition2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 3 [DISCLOSURE.X164]
    /// </summary>
    public string? RefundCondition3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 4 [DISCLOSURE.X165]
    /// </summary>
    public string? RefundCondition4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 5 [DISCLOSURE.X166]
    /// </summary>
    public string? RefundCondition5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Appl Fee Refund If 6 [DISCLOSURE.X167]
    /// </summary>
    public string? RefundCondition6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Address [DISCLOSURE.X1064]
    /// </summary>
    public string? RegulatorAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator City [DISCLOSURE.X1065]
    /// </summary>
    public string? RegulatorCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Mailing Address [DISCLOSURE.X1070]
    /// </summary>
    public string? RegulatorMailingAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Mailing City [DISCLOSURE.X1071]
    /// </summary>
    public string? RegulatorMailingCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Mailing State [DISCLOSURE.X1072]
    /// </summary>
    public string? RegulatorMailingState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Mailing Zip Code [DISCLOSURE.X1073]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? RegulatorMailingZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Phone [DISCLOSURE.X1068]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RegulatorPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator State [DISCLOSURE.X1066]
    /// </summary>
    public string? RegulatorState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Toll-free Phone [DISCLOSURE.X1069]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? RegulatorTollFreePhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure - Regulatory Agency - Web Address [DISCLOSURE.X1156]
    /// </summary>
    public string? RegulatorWebAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// South Carolina State Specific Disclosure -  Regulator Zip Code [DISCLOSURE.X1067]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? RegulatorZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-MD The schedule of charges is Estimated, subject to change or Final, not subject to change [DISCLOSURE.X912]
    /// </summary>
    public StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator> ScheduleOfChargesEstimatedFinalIndicator { get => GetValue<StringEnumValue<ScheduleOfChargesEstimatedFinalIndicator>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - SC - Regulatory Agency [DISCLOSURE.X953]
    /// </summary>
    public StringEnumValue<ScRegulatoryAgencyType> ScRegulatoryAgencyType { get => GetValue<StringEnumValue<ScRegulatoryAgencyType>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Division of Fees Is Selected [DISCLOSURE.X181]
    /// </summary>
    public bool? SelectDivisionFeesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Primary Lender Is Selected [DISCLOSURE.X179]
    /// </summary>
    public bool? SelectPrimaryLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Lender Private Lender Is Selected [DISCLOSURE.X180]
    /// </summary>
    public bool? SelectPrivateLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Servicing Fee Charged Amount [DISCLOSURE.X940]
    /// </summary>
    public decimal? ServicingFeeChargedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Servicing Fee Indicator [DISCLOSURE.X939]
    /// </summary>
    public bool? ServicingFeeChargedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Servicing Fee Paid By [DISCLOSURE.X941]
    /// </summary>
    public StringEnumValue<StateDisclosureFeePaidBy> ServicingFeePaidBy { get => GetValue<StringEnumValue<StateDisclosureFeePaidBy>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Servicing Fee Paid Frequency [DISCLOSURE.X942]
    /// </summary>
    public StringEnumValue<ServicingFeePaidFrequence> ServicingFeePaidFrequency { get => GetValue<StringEnumValue<ServicingFeePaidFrequence>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL GFE of settlemnt chrgs dated/signed by borrower [FLGFE.X76]
    /// </summary>
    public bool? SignedByBorrowerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Specific ARM rates, terms, and conditions [FLGFE.X74]
    /// </summary>
    public bool? SpecificArmIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Will Submit to Lender [DISCLOSURE.X74]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"We will submit your loan application to a participating lender\"}")]
    public bool? SubmitToLenderIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Assessments [DISCLOSURE.X968]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationAssessments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Other [DISCLOSURE.X970]
    /// </summary>
    public string? TaxExemptAcquisitionCostCertificationOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Other Amount [DISCLOSURE.X971]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Owners Title Insurance [DISCLOSURE.X965]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Real Estate Commission [DISCLOSURE.X967]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Repairs/Improvements [DISCLOSURE.X969]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Survey [DISCLOSURE.X966]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationSurvey { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - AK - Total Adjustments [DISCLOSURE.X972]
    /// </summary>
    public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Terms Are/Are Not Subject to Change [FLMTGCM.X2]
    /// </summary>
    public StringEnumValue<TermsChange> TermsChange { get => GetValue<StringEnumValue<TermsChange>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Application Fee [DISCLOSURE.X82]
    /// </summary>
    public decimal? TexasApplicationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Appraisal Fee [DISCLOSURE.X85]
    /// </summary>
    public decimal? TexasAppraisalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Credit Rpt Fee [DISCLOSURE.X87]
    /// </summary>
    public decimal? TexasCreditReportFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Other Fee 1 [DISCLOSURE.X91]
    /// </summary>
    public decimal? TexasOtherFee1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Other Fee 2 [DISCLOSURE.X93]
    /// </summary>
    public decimal? TexasOtherFee2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Other Fee 1 Descr [DISCLOSURE.X90]
    /// </summary>
    public string? TexasOtherFeeContact1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Other Fee 2 Descr [DISCLOSURE.X92]
    /// </summary>
    public string? TexasOtherFeeContact2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Processing Fee [DISCLOSURE.X83]
    /// </summary>
    public decimal? TexasProcessingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-FL Third Party Fee Amt [FLGFE.X54]
    /// </summary>
    public decimal? ThirdPartyFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Total Broker Fee [DISCLOSURE.X163]
    /// </summary>
    public decimal? TotalFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Service Rights Transfer Fee Charged Amount [DISCLOSURE.X937]
    /// </summary>
    public decimal? TransferFeeChargedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Service Rights Transfer Fee Indicator [DISCLOSURE.X936]
    /// </summary>
    public bool? TransferFeeChargedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Service Rights Transfer Fee Paid By [DISCLOSURE.X938]
    /// </summary>
    public StringEnumValue<StateDisclosureFeePaidBy> TransferFeePaidBy { get => GetValue<StringEnumValue<StateDisclosureFeePaidBy>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure - TX - Texas Veterans Land Board [DISCLOSURE.X955]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? TxVeteransLandBoardIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NY Type of Property [DISCLOSURE.X996]
    /// </summary>
    public StringEnumValue<TypeOfProperty> TypeOfProperty { get => GetValue<StringEnumValue<TypeOfProperty>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Underwriting Fee Descr [DISCLOSURE.X88]
    /// </summary>
    public string? UnderwritingContact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-TX Underwriting Fee [DISCLOSURE.X89]
    /// </summary>
    public decimal? UnderwritingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Yield Spread Premium (YSP) Charged Amount [DISCLOSURE.X931]
    /// </summary>
    public decimal? YspChargedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Yield Spread Premium (YSP) Indicator [DISCLOSURE.X930]
    /// </summary>
    public bool? YspChargedIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Yield Spread Premium (YSP) Decreases Interest Rate By [DISCLOSURE.X934]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? YspDecreasesRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Yield Spread Premium (YSP) Increases Interest Rate By [DISCLOSURE.X935]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? YspIncreasesRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Identify one of three possible impacts of Yield Spread Premium (YSP) on the Interest Rate [DISCLOSURE.X933]
    /// </summary>
    public StringEnumValue<InterestRateImpactedStatus> YspInterestRateImpactedStatus { get => GetValue<StringEnumValue<InterestRateImpactedStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure-NV Yield Spread Premium (YSP)  Paid By [DISCLOSURE.X932]
    /// </summary>
    public StringEnumValue<StateDisclosureFeePaidBy> YspPaidBy { get => GetValue<StringEnumValue<StateDisclosureFeePaidBy>>(); set => SetValue(value); }
}