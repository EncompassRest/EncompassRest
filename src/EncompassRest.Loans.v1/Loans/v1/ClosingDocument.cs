using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ClosingDocument
/// </summary>
public sealed partial class ClosingDocument : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Closing Docs Mfg Home Address of Additional Lien Holder [3651]
    /// </summary>
    public string? AdditionalLienHolderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Address City of Additional Lien Holder [3652]
    /// </summary>
    public string? AdditionalLienHolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Postal Code of Additional Lien Holder [3654]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AdditionalLienHolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Address State of Additional Lien Holder [3653]
    /// </summary>
    public StringEnumValue<State> AdditionalLienHolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Name of Additional Lien Holder [3650]
    /// </summary>
    public string? AdditionalLienHolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Additional Original Pincipal Amount Secured [3655]
    /// </summary>
    public decimal? AdditionalOriginalPincipalAmountSecured { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents - Additional Signature Verbiage Type [PlanCode.AdtlSgVbgTyp]
    /// </summary>
    public StringEnumValue<AdditionalSigVerbiageType> AdditionalSigVerbiageType { get => GetValue<StringEnumValue<AdditionalSigVerbiageType>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument AdditionalStateDisclosures
    /// </summary>
    [AllowNull]
    public IList<AdditionalStateDisclosure> AdditionalStateDisclosures { get => GetList<AdditionalStateDisclosure>(); set => SetList(value); }

    /// <summary>
    /// State Disc - Broker Comp Affected by Interest [DISCLOSURE.X210]
    /// </summary>
    public bool? AffectedByInterest { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Alternate Lender [1882]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AlternateLender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Encompass Docs Alt Lender ID [AltLender.ID]
    /// </summary>
    public string? AltLenderId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument AntiSteeringLoanOptions
    /// </summary>
    [AllowNull]
    public IList<AntiSteeringLoanOption> AntiSteeringLoanOptions { get => GetList<AntiSteeringLoanOption>(); set => SetList(value); }

    /// <summary>
    /// Appraisal Order Accepted [AP.WF.EVNT.APODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderAccepted { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Appraisal Order Sent [AP.WF.EVNT.APODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderSent { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Appraiser Sent Data for Review [AP.WF.EVNT.DATAREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraiserSentDataForReview { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Appraiser Sent Doc(s) for Review [AP.WF.EVNT.DOCREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraiserSentDocForReview { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Able to Service [1926]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AreAbleToServiceIndicator { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Number [1934]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AssociatedDocumentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr Beneficiaries [2970]
    /// </summary>
    public string? Beneficiaries { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Borrower Consent Type [DISCLOSURE.X199]
    /// </summary>
    public bool? BorrowerConsentType1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Borrower Consent Type 2 [DISCLOSURE.X220]
    /// </summary>
    public bool? BorrowerConsentType2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org Type [1861]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerOrganizationType1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Type [Vesting.Trst2Type]
    /// </summary>
    public string? BorrowerOrganizationType2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org State [1860]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 State [Vesting.Trst2State]
    /// </summary>
    public string? BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org Tax ID [1862]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerTaxIdentificationNumberIdentifier1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Tax ID [Vesting.Trst2TaxID]
    /// </summary>
    public string? BorrowerTaxIdentificationNumberIdentifier2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 1 Amended Date or Year [Vesting.Trst1AmdDate]
    /// </summary>
    public string? BorrowerTrustAmendedDateOrYear1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Amended Date or Year [Vesting.Trst2AmdDate]
    /// </summary>
    public string? BorrowerTrustAmendedDateOrYear2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Borr 1 Org Trust Date or Year [2554]
    /// </summary>
    public string? BorrowerTrustDateOrYear1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Date or Year [Vesting.Trst2Date]
    /// </summary>
    public string? BorrowerTrustDateOrYear2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Corp/Trust Name [1859]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerUnparsedName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Name [Vesting.Trst2Name]
    /// </summary>
    public string? BorrowerUnparsedName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Rep Title [DISCLOSURE.X188]
    /// </summary>
    public string? BrokerAuthorizedRepresentativeTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Method of Compensation [DISCLOSURE.X211]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerCompensationMethod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 1 [DISCLOSURE.X195]
    /// </summary>
    public string? BrokerFeeRefundConditions1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 2 [DISCLOSURE.X196]
    /// </summary>
    public string? BrokerFeeRefundConditions2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 3 [DISCLOSURE.X197]
    /// </summary>
    public string? BrokerFeeRefundConditions3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Consideration for Placing Loan [DISCLOSURE.X209]
    /// </summary>
    public StringEnumValue<BrokerForPlacingLoan> BrokerForPlacingLoan { get => GetValue<StringEnumValue<BrokerForPlacingLoan>>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Effect of Int Rate on Broker Comp [DISCLOSURE.X212]
    /// </summary>
    public string? BrokerInterestRateEffect { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Relationship with Lender [DISCLOSURE.X213]
    /// </summary>
    public string? BrokerLenderRelationship { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mort Broker Lic Number [1935]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerLicenseNumberIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Name As Licensed [DISCLOSURE.X202]
    /// </summary>
    public string? BrokerNameAsLicensed { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mort Broker Tax ID Number [1937]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerTaxIdentificationNumberIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Places Loans W/Lender(s) [DISCLOSURE.X200]
    /// </summary>
    public StringEnumValue<BrokerWithLenders> BrokerWithLenders { get => GetValue<StringEnumValue<BrokerWithLenders>>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 HUD1A - Plus Cash/Ck from Borr [HUD1A.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CashCheckFromBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Clear to Close Status Received by Lender Date Time [CL.WF.EVNT.CLRTOCLOS]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Closing + Escrow Order Accepted Date Time [CL.WF.EVNT.CODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLClosingEscrowOrderAcceptedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Closing + Escrow Order Sent Date Time [CL.WF.EVNT.CODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLClosingEscrowOrderSentDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Draft Closing Disclosure Received by the Lender Date Time [CL.WF.EVNT.INIDSCLO]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Final CD Sent Date Time [CL.WF.EVNT.FINLCDSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLFinalCDSentDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Final Title Policy Date Time [CL.WF.EVNT.FINLTITLPLCY]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLFinalTitlePolicyDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Last Fee Quote Received Date Time [CL.WF.EVNT.ODRQOTEACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLLastFeeQuoteReceivedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Last Fee Quote Requested Date Time [CL.WF.EVNT.ODRQUOTE]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLLastFeeQuoteRequestedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents - Plan Code Type [PlanCode.LoanProgTyp]
    /// </summary>
    public StringEnumValue<DocsLoanProgramType> ClosingDocsLoanProgramType { get => GetValue<StringEnumValue<DocsLoanProgramType>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument ClosingEntities
    /// </summary>
    [AllowNull]
    public IList<ClosingEntity> ClosingEntities { get => GetList<ClosingEntity>(); set => SetList(value); }

    /// <summary>
    /// Closing Loan Info Plan Closing Provider [2399]
    /// </summary>
    public string? ClosingProvider { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing State [3542]
    /// </summary>
    public StringEnumValue<State> ClosingState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Payoffs Requested Date Time [CL.WF.EVNT.ODRPAYOFF]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLPayoffsRequestedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Prelim / Commitment Received by the Lender Date Time [CL.WF.EVNT.PRELIMRECV]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Provider Disburse Funds [CL.WF.EVNT.FNDDISB]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLProviderDisburseFundsDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Title Order Accepted Date Time [CL.WF.EVNT.TODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLTitleOrderAcceptedDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Title Order Sent Date Time [CL.WF.EVNT.TODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? CLTitleOrderSentDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Compliance Jurisdiction Type [2550]
    /// </summary>
    public string? ComplianceJurisdictionCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Property Identified Date [2851]
    /// </summary>
    public DateTime? CompliancePropertyIdentifiedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Instructions Condition Descrip [1952]
    /// </summary>
    public string? ConditionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Licensee Provides Services [DISCLOSURE.X214]
    /// </summary>
    public bool? ConflictofInterestCheck1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Licensee/Relative Controls 10% Equity [DISCLOSURE.X215]
    /// </summary>
    public bool? ConflictofInterestCheck2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Provider Controls 10% Equity [DISCLOSURE.X216]
    /// </summary>
    public bool? ConflictofInterestCheck3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Holding Company Controls 10% Equity [DISCLOSURE.X217]
    /// </summary>
    public bool? ConflictofInterestCheck4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Same Officer/Director for Licensee/Prvdr [DISCLOSURE.X218]
    /// </summary>
    public bool? ConflictofInterestCheck5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Licensee Is Officer/Director for Prvdr [DISCLOSURE.X219]
    /// </summary>
    public bool? ConflictofInterestCheck6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Apartment Number [2644]
    /// </summary>
    public string? CoopApartmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Assignment Lease date [2642]
    /// </summary>
    public DateTime? CoopAssignmentLeaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Attorney in Fact [2640]
    /// </summary>
    public string? CoopAttorneyInFact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Building Name [2639]
    /// </summary>
    public string? CoopBuildingName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Company Exists Under The Laws Of [2638]
    /// </summary>
    public string? CoopCompanyExistsUnderTHeLawsOf { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Company Name [2636]
    /// </summary>
    public string? CoopCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Proprietary Lease Date [2641]
    /// </summary>
    public DateTime? CoopProprietaryLeaseDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Shares Owned [2635]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CoopSharesOwned { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Stock Certification Number [2643]
    /// </summary>
    public string? CoopStockCertificationNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Coop Loan Vacancy Percent Notification [2637]
    /// </summary>
    public decimal? CoopVacancyPercentNotification { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Custom Other Rider Description [4055]
    /// </summary>
    public string? CustomOtherRiderDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disbursement Date [2553]
    /// </summary>
    public DateTime? DisbursementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 HUD1A - Equals Disburs to Borr [HUD1A.X32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DisbursementsToBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Alt Lender [DISCLOSUREALTLENDER]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureAlternateLender { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Company Function [DISCLOSURECOFUNCTION]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureCompanyFunction { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Plan Code [DISCLOSUREPLANCODE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosurePlanCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Unspecified Event Occurred [CL.WF.EVNT.LENDOTHER]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DocOrMessageByLenderDateTime { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info DOC Report GUID [3900]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocReportGUID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Document Date [L770]
    /// </summary>
    public DateTime? DocumentPreparationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Document Signing Date [1887]
    /// </summary>
    public DateTime? DocumentSigningDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Draw City [L827]
    /// </summary>
    public string? DrawCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing County [1949]
    /// </summary>
    public string? DrawCounty { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Draw State [L812]
    /// </summary>
    public StringEnumValue<State> DrawState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// eClose Closing Type [4689]
    /// </summary>
    public StringEnumValue<eCloseClosingType> eCloseClosingType { get => GetValue<StringEnumValue<eCloseClosingType>>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Broker Is Employee of Mtg Lender [DISCLOSURE.X208]
    /// </summary>
    public StringEnumValue<YNOrOther> EmployeeofMortgageLender { get => GetValue<StringEnumValue<YNOrOther>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Expect to Assign, Sell, Service Percent [1927]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ExpectToAssignSellOrTransferPercent { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Borr Final Vesting to Read [1867]
    /// </summary>
    public string? FinalVestingDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA First Transfer Year [1928]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FirstTransferYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA First Transfer Year Value [1929]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FirstTransferYearValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Hrs Docs needed prior to disbrsmnt [1950]
    /// </summary>
    public string? HoursDocumentsNeededPriorToDisbursementCount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs for Ellie Mae Network Housing Indicator [HOUSINGPROGRAM.X1]
    /// </summary>
    public bool? HousingIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs for Ellie Mae Network Housing Program Name [HOUSINGPROGRAM.X2]
    /// </summary>
    public string? HousingProgramName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 File # [L72]
    /// </summary>
    public string? HUD1FileNumberIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Place of Settlement [L75]
    /// </summary>
    public string? HUD1SettlementAgentUnparsedAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Settlement Agent [L74]
    /// </summary>
    public string? HUD1SettlementAgentUnparsedName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Settlement Date [L76]
    /// </summary>
    public DateTime? HUD1SettlementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Anti-Steering Disclosure - Include Safe Habor Disclosure [DISCLOSURE.X867]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? IncludeSafeHaborDisclosure { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents - Investor Code [PlanCode.InvCd]
    /// </summary>
    public string? InvestorCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Last Audit Date [1885]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastAuditDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Last Document Ordered [1886]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastDocumentOrdered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Attach Legal Descr [1884]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Attach legal description\"}")]
    public bool? LegalAttached { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Lender Rep Title [DISCLOSURE.X187]
    /// </summary>
    public string? LenderAuthorizedRepresentativeTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Lender Broker Rep [DISCLOSURE.X185]
    /// </summary>
    public string? LenderBrokerRepresents { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Address of Lien Holder [3645]
    /// </summary>
    public string? LienHolderAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Address City of Lien Holder [3646]
    /// </summary>
    public string? LienHolderAddressCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Postal Code of Lien Holder [3648]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LienHolderAddressPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Address State of Lien Holder [3647]
    /// </summary>
    public StringEnumValue<State> LienHolderAddressState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Name of Lien Holder [3644]
    /// </summary>
    public string? LienHolderName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Loan Info Loan is Locked [2400]
    /// </summary>
    public bool? LoanIsLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Anti-Steering Disclosure - LoanOption [DISCLOSURE.X732]
    /// </summary>
    public StringEnumValue<LoanOption> LoanOption { get => GetValue<StringEnumValue<LoanOption>>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Lock In Fee Type [DISCLOSURE.X198]
    /// </summary>
    public StringEnumValue<LockInFeeType> LockInFeeType { get => GetValue<StringEnumValue<LockInFeeType>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Anchored [2589]
    /// </summary>
    public StringEnumValue<MfgHomeAnchored> MfgHomeAnchored { get => GetValue<StringEnumValue<MfgHomeAnchored>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Cert of Title ID [2584]
    /// </summary>
    public string? MfgHomeCertificateOfTitleIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Cert of Title Type [2585]
    /// </summary>
    public StringEnumValue<MfgHomeCertificateOfTitleType> MfgHomeCertificateOfTitleType { get => GetValue<StringEnumValue<MfgHomeCertificateOfTitleType>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Descr [2590]
    /// </summary>
    public string? MfgHomeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home HUD Cert. Label ID [2588]
    /// </summary>
    public string? MfgHomeHUDCertificationLabelIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Length (Ft) [2580]
    /// </summary>
    public int? MfgHomeLengthFeetCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Make [2578]
    /// </summary>
    public string? MfgHomeMakeIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer [2582]
    /// </summary>
    public string? MfgHomeManufacturer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Address [4064]
    /// </summary>
    public string? MfgHomeManufacturerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer City [4065]
    /// </summary>
    public string? MfgHomeManufacturerCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Phone Number [4068]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MfgHomeManufacturerPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Postal Code [4067]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MfgHomeManufacturerPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer State [4066]
    /// </summary>
    public StringEnumValue<State> MfgHomeManufacturerState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Year [2579]
    /// </summary>
    public int? MfgHomeManufactureYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Model [2586]
    /// </summary>
    public string? MfgHomeModelIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home New or Used [2587]
    /// </summary>
    public StringEnumValue<MfgHomeNewOrUsed> MfgHomeNewOrUsed { get => GetValue<StringEnumValue<MfgHomeNewOrUsed>>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Serial No [2583]
    /// </summary>
    public string? MfgHomeSerialNumberIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Width (Ft) [2581]
    /// </summary>
    public int? MfgHomeWidthFeetCount { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Mineral Rights Descr [1883]
    /// </summary>
    public string? MineralRightsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Loan Type [L83]
    /// </summary>
    public StringEnumValue<MortgageType> MortgageType { get => GetValue<StringEnumValue<MortgageType>>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - No. Broker Agreements [DISCLOSURE.X182]
    /// </summary>
    public int? NumberBrokerAgreements { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - No. Successful Broker Agreements [DISCLOSURE.X183]
    /// </summary>
    public int? NumberSuccessfulBrokerAgreements { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Office of Rec Name [1938]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OfficeOfRecordationName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Loans Brokered to Only 1 Entity [DISCLOSURE.X206]
    /// </summary>
    public bool? OnlyOneEntity { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Anti-Steering Disclosure - The Reason to Select this Option [DISCLOSURE.X734]
    /// </summary>
    public string? OptionSelectedReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Mfg Home Original Pincipal Amount Secured [3649]
    /// </summary>
    public decimal? OriginalPincipalAmountSecured { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Anti-Steering Disclosure - Other Option Description [DISCLOSURE.X733]
    /// </summary>
    public string? OtherOptionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Parent or Affiliated Co Name [DISCLOSURE.X204]
    /// </summary>
    public string? ParentAffiliatedCoName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Transfer To [1951]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PayToTheOrderOfDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Construction Mortgage Number of Days [1962]
    /// </summary>
    public StringEnumValue<PerDiemCalculationMethodType> PerDiemCalculationMethodType { get => GetValue<StringEnumValue<PerDiemCalculationMethodType>>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Plan Code [1881]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PlanCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Plan Code Description [PlanCode.Desc]
    /// </summary>
    public string? PlanCodeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Plan Code [PlanCode.ID]
    /// </summary>
    public string? PlanCodeId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Title Report Date [L362]
    /// </summary>
    public DateTime? PreliminaryTitleReportDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 1 [DISCLOSURE.X192]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 2 [DISCLOSURE.X193]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 3 [DISCLOSURE.X194]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Print Trust Name(s) on LE/CD Addendum [4662]
    /// </summary>
    public bool? PrintTrustNameIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Days to Process [DISCLOSURE.X184]
    /// </summary>
    public int? ProcessingNumberDays { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents - Program Code [PlanCode.ProgCd]
    /// </summary>
    public string? ProgramCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents - Investor [PlanCode.ProgSpnsrNm]
    /// </summary>
    public string? ProgramSponsor { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Property Is In A Land Trust [DISCLOSURE.X207]
    /// </summary>
    public bool? PropertyIsLandTrust { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Tax Message [L360]
    /// </summary>
    public string? PropertyTaxMessageDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 1 [DISCLOSURE.X189]
    /// </summary>
    public string? RateLockRefundConditions1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 2 [DISCLOSURE.X190]
    /// </summary>
    public string? RateLockRefundConditions2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 3 [DISCLOSURE.X191]
    /// </summary>
    public string? RateLockRefundConditions3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Juris Name [1936]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RecordingJurisdictionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - Lender Guarantees Balloon Refi [DISCLOSURE.X201]
    /// </summary>
    public bool? RefinanceBalloonMortgageGuarantee { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Exempt from Right of Rescission [3942]
    /// </summary>
    public bool? RefinanceRightOfRescissionExemptFlag { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs Renewal and Extension [3240]
    /// </summary>
    public string? RenewalExtensionDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// REGZ Loan Info Rescission Date [L724]
    /// </summary>
    public DateTime? RescissionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument RespaHudDetails
    /// </summary>
    [AllowNull]
    public IList<RespaHudDetail> RespaHudDetails { get => GetList<RespaHudDetail>(); set => SetList(value); }

    /// <summary>
    /// State Disc - RMLA Name Preceding 10 Yrs [DISCLOSURE.X203]
    /// </summary>
    public string? RMLANamePreceding10Years { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - RML Licensees- Lender Broker Rep [DISCLOSURE.X952]
    /// </summary>
    public string? RmlLenderBrokerRepresents { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Second Transfer Year [1930]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecondTransferYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Second Transfer Year Value [1931]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? SecondTransferYearValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs 1003 Signature Date [3261]
    /// </summary>
    public DateTime? SignatureDateFor1003 { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Flood Zone [541]
    /// </summary>
    public StringEnumValue<FloodZone> SpecialFloodHazardAreaIndictor { get => GetValue<StringEnumValue<FloodZone>>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDocument StateLicenses
    /// </summary>
    [AllowNull]
    public IList<StateLicense> StateLicenses { get => GetList<StateLicense>(); set => SetList(value); }

    /// <summary>
    /// State Disc - Surety Company Name [DISCLOSURE.X186]
    /// </summary>
    public string? SuretyCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Sync Prepaid Int [2852]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Y\",\"N\":\"N\"}")]
    public bool? SyncInterestDateDisbursementDate { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Documents Termite Report Required [L493]
    /// </summary>
    public StringEnumValue<YOrN> TermiteReportRequiredIndicator { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Legal Descr [1846]
    /// </summary>
    public string? TextDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Third Transfer Year [1932]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ThirdTransferYear { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Docs RESPA Third Transfer Year Value [1933]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ThirdTransferYearValue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Title/Closing Agent Sent Data for Review [CL.WF.EVNT.DATAREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleClosingAgentSentDataForReview { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Title Closing Disclosure - Title/Closing Agent Sent Doc(s) for Review [CL.WF.EVNT.DOCREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleClosingAgentSentDocForReview { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Approved Items [L361]
    /// </summary>
    public string? TitleReportItemsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Info Special Endorsements [L358]
    /// </summary>
    public string? TitleReportRequiredEndorsementsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 HUD1A - 1520 Total Disbursed [HUD1A.X31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDisbursed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Beneficiaries [Vesting.Trst2Bfcry]
    /// </summary>
    public string? Trust2Beneficiaries { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// State Disc - We Conduct Business As [DISCLOSURE.X205]
    /// </summary>
    public StringEnumValue<WeConductBusiness> WeConductBusiness { get => GetValue<StringEnumValue<WeConductBusiness>>(); set => SetValue(value); }
}