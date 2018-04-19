using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDocument
    /// </summary>
    public sealed partial class ClosingDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _additionalLienHolderAddress;
        /// <summary>
        /// Closing Docs Mfg Home Address of Additional Lien Holder [3651]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Address of Additional Lien Holder")]
        public string AdditionalLienHolderAddress { get => _additionalLienHolderAddress; set => _additionalLienHolderAddress = value; }
        private DirtyValue<string> _additionalLienHolderAddressCity;
        /// <summary>
        /// Closing Docs Mfg Home Address City of Additional Lien Holder [3652]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Address City of Additional Lien Holder")]
        public string AdditionalLienHolderAddressCity { get => _additionalLienHolderAddressCity; set => _additionalLienHolderAddressCity = value; }
        private DirtyValue<string> _additionalLienHolderAddressPostalCode;
        /// <summary>
        /// Closing Docs Mfg Home Postal Code of Additional Lien Holder [3654]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Closing Docs Mfg Home Postal Code of Additional Lien Holder")]
        public string AdditionalLienHolderAddressPostalCode { get => _additionalLienHolderAddressPostalCode; set => _additionalLienHolderAddressPostalCode = value; }
        private DirtyValue<string> _additionalLienHolderAddressState;
        /// <summary>
        /// Closing Docs Mfg Home Address State of Additional Lien Holder [3653]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Closing Docs Mfg Home Address State of Additional Lien Holder")]
        public string AdditionalLienHolderAddressState { get => _additionalLienHolderAddressState; set => _additionalLienHolderAddressState = value; }
        private DirtyValue<string> _additionalLienHolderName;
        /// <summary>
        /// Closing Docs Mfg Home Name of Additional Lien Holder [3650]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Name of Additional Lien Holder")]
        public string AdditionalLienHolderName { get => _additionalLienHolderName; set => _additionalLienHolderName = value; }
        private DirtyValue<decimal?> _additionalOriginalPincipalAmountSecured;
        /// <summary>
        /// Closing Docs Mfg Home Additional Original Pincipal Amount Secured [3655]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Docs Mfg Home Additional Original Pincipal Amount Secured")]
        public decimal? AdditionalOriginalPincipalAmountSecured { get => _additionalOriginalPincipalAmountSecured; set => _additionalOriginalPincipalAmountSecured = value; }
        private DirtyValue<StringEnumValue<AdditionalSigVerbiageType>> _additionalSigVerbiageType;
        /// <summary>
        /// Closing Documents - Additional Signature Verbiage Type [PlanCode.AdtlSgVbgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents - Additional Signature Verbiage Type")]
        public StringEnumValue<AdditionalSigVerbiageType> AdditionalSigVerbiageType { get => _additionalSigVerbiageType; set => _additionalSigVerbiageType = value; }
        private DirtyList<AdditionalStateDisclosure> _additionalStateDisclosures;
        /// <summary>
        /// ClosingDocument AdditionalStateDisclosures
        /// </summary>
        public IList<AdditionalStateDisclosure> AdditionalStateDisclosures { get => _additionalStateDisclosures ?? (_additionalStateDisclosures = new DirtyList<AdditionalStateDisclosure>()); set => _additionalStateDisclosures = new DirtyList<AdditionalStateDisclosure>(value); }
        private DirtyValue<bool?> _affectedByInterest;
        /// <summary>
        /// State Disc - Broker Comp Affected by Interest [DISCLOSURE.X210]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Comp Affected by Interest")]
        public bool? AffectedByInterest { get => _affectedByInterest; set => _affectedByInterest = value; }
        private DirtyValue<string> _alternateLender;
        /// <summary>
        /// REGZ Loan Info Alternate Lender [1882]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Loan Info Alternate Lender")]
        public string AlternateLender { get => _alternateLender; set => _alternateLender = value; }
        private DirtyValue<string> _altLenderId;
        /// <summary>
        /// Encompass Docs Alt Lender ID [AltLender.ID]
        /// </summary>
        [LoanFieldProperty(Description = "Encompass Docs Alt Lender ID")]
        public string AltLenderId { get => _altLenderId; set => _altLenderId = value; }
        private DirtyList<AntiSteeringLoanOption> _antiSteeringLoanOptions;
        /// <summary>
        /// ClosingDocument AntiSteeringLoanOptions
        /// </summary>
        public IList<AntiSteeringLoanOption> AntiSteeringLoanOptions { get => _antiSteeringLoanOptions ?? (_antiSteeringLoanOptions = new DirtyList<AntiSteeringLoanOption>()); set => _antiSteeringLoanOptions = new DirtyList<AntiSteeringLoanOption>(value); }
        private DirtyValue<string> _areAbleToServiceIndicator;
        /// <summary>
        /// Closing Docs RESPA Able to Service [1926]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs RESPA Able to Service")]
        public string AreAbleToServiceIndicator { get => _areAbleToServiceIndicator; set => _areAbleToServiceIndicator = value; }
        private DirtyValue<string> _associatedDocumentNumber;
        /// <summary>
        /// Closing Docs Recordable Doc Associated Doc Number [1934]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Recordable Doc Associated Doc Number")]
        public string AssociatedDocumentNumber { get => _associatedDocumentNumber; set => _associatedDocumentNumber = value; }
        private DirtyValue<string> _beneficiaries;
        /// <summary>
        /// Borrower Vesting Borr Beneficiaries [2970]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Borr Beneficiaries")]
        public string Beneficiaries { get => _beneficiaries; set => _beneficiaries = value; }
        private DirtyValue<bool?> _borrowerConsentType1;
        /// <summary>
        /// State Disc - Borrower Consent Type [DISCLOSURE.X199]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Borrower Consent Type")]
        public bool? BorrowerConsentType1 { get => _borrowerConsentType1; set => _borrowerConsentType1 = value; }
        private DirtyValue<bool?> _borrowerConsentType2;
        /// <summary>
        /// State Disc - Borrower Consent Type 2 [DISCLOSURE.X220]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Borrower Consent Type 2")]
        public bool? BorrowerConsentType2 { get => _borrowerConsentType2; set => _borrowerConsentType2 = value; }
        private DirtyValue<string> _borrowerOrganizationType1;
        /// <summary>
        /// Borrower Vesting Borr 1 Org Type [1861]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Borr 1 Org Type")]
        public string BorrowerOrganizationType1 { get => _borrowerOrganizationType1; set => _borrowerOrganizationType1 = value; }
        private DirtyValue<string> _borrowerOrganizationType2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Type [Vesting.Trst2Type]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Type")]
        public string BorrowerOrganizationType2 { get => _borrowerOrganizationType2; set => _borrowerOrganizationType2 = value; }
        private DirtyValue<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName1;
        /// <summary>
        /// Borrower Vesting Borr 1 Org State [1860]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Borr 1 Org State")]
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName1; set => _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = value; }
        private DirtyValue<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 State [Vesting.Trst2State]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 State")]
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName2; set => _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = value; }
        private DirtyValue<string> _borrowerTaxIdentificationNumberIdentifier1;
        /// <summary>
        /// Borrower Vesting Borr 1 Org Tax ID [1862]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Borr 1 Org Tax ID")]
        public string BorrowerTaxIdentificationNumberIdentifier1 { get => _borrowerTaxIdentificationNumberIdentifier1; set => _borrowerTaxIdentificationNumberIdentifier1 = value; }
        private DirtyValue<string> _borrowerTaxIdentificationNumberIdentifier2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Tax ID [Vesting.Trst2TaxID]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Tax ID")]
        public string BorrowerTaxIdentificationNumberIdentifier2 { get => _borrowerTaxIdentificationNumberIdentifier2; set => _borrowerTaxIdentificationNumberIdentifier2 = value; }
        private DirtyValue<string> _borrowerTrustAmendedDateOrYear1;
        /// <summary>
        /// Borrower Vesting Corp/Trust 1 Amended Date or Year [Vesting.Trst1AmdDate]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 1 Amended Date or Year")]
        public string BorrowerTrustAmendedDateOrYear1 { get => _borrowerTrustAmendedDateOrYear1; set => _borrowerTrustAmendedDateOrYear1 = value; }
        private DirtyValue<string> _borrowerTrustAmendedDateOrYear2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Amended Date or Year [Vesting.Trst2AmdDate]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Amended Date or Year")]
        public string BorrowerTrustAmendedDateOrYear2 { get => _borrowerTrustAmendedDateOrYear2; set => _borrowerTrustAmendedDateOrYear2 = value; }
        private DirtyValue<string> _borrowerTrustDateOrYear1;
        /// <summary>
        /// Closing Docs Borr 1 Org Trust Date or Year [2554]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Borr 1 Org Trust Date or Year")]
        public string BorrowerTrustDateOrYear1 { get => _borrowerTrustDateOrYear1; set => _borrowerTrustDateOrYear1 = value; }
        private DirtyValue<string> _borrowerTrustDateOrYear2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Date or Year [Vesting.Trst2Date]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Date or Year")]
        public string BorrowerTrustDateOrYear2 { get => _borrowerTrustDateOrYear2; set => _borrowerTrustDateOrYear2 = value; }
        private DirtyValue<string> _borrowerUnparsedName1;
        /// <summary>
        /// Borrower Vesting Borr 1 Corp/Trust Name [1859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Borr 1 Corp/Trust Name")]
        public string BorrowerUnparsedName1 { get => _borrowerUnparsedName1; set => _borrowerUnparsedName1 = value; }
        private DirtyValue<string> _borrowerUnparsedName2;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Name [Vesting.Trst2Name]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Name")]
        public string BorrowerUnparsedName2 { get => _borrowerUnparsedName2; set => _borrowerUnparsedName2 = value; }
        private DirtyValue<string> _brokerAuthorizedRepresentativeTitle;
        /// <summary>
        /// State Disc - Broker Rep Title [DISCLOSURE.X188]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Rep Title")]
        public string BrokerAuthorizedRepresentativeTitle { get => _brokerAuthorizedRepresentativeTitle; set => _brokerAuthorizedRepresentativeTitle = value; }
        private DirtyValue<string> _brokerCompensationMethod;
        /// <summary>
        /// State Disc - Broker Method of Compensation [DISCLOSURE.X211]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "State Disc - Broker Method of Compensation")]
        public string BrokerCompensationMethod { get => _brokerCompensationMethod; set => _brokerCompensationMethod = value; }
        private DirtyValue<string> _brokerFeeRefundConditions1;
        /// <summary>
        /// State Disc - Broker Fee Refund Descr 1 [DISCLOSURE.X195]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Fee Refund Descr 1")]
        public string BrokerFeeRefundConditions1 { get => _brokerFeeRefundConditions1; set => _brokerFeeRefundConditions1 = value; }
        private DirtyValue<string> _brokerFeeRefundConditions2;
        /// <summary>
        /// State Disc - Broker Fee Refund Descr 2 [DISCLOSURE.X196]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Fee Refund Descr 2")]
        public string BrokerFeeRefundConditions2 { get => _brokerFeeRefundConditions2; set => _brokerFeeRefundConditions2 = value; }
        private DirtyValue<string> _brokerFeeRefundConditions3;
        /// <summary>
        /// State Disc - Broker Fee Refund Descr 3 [DISCLOSURE.X197]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Fee Refund Descr 3")]
        public string BrokerFeeRefundConditions3 { get => _brokerFeeRefundConditions3; set => _brokerFeeRefundConditions3 = value; }
        private DirtyValue<StringEnumValue<BrokerForPlacingLoan>> _brokerForPlacingLoan;
        /// <summary>
        /// State Disc - Broker Consideration for Placing Loan [DISCLOSURE.X209]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Consideration for Placing Loan")]
        public StringEnumValue<BrokerForPlacingLoan> BrokerForPlacingLoan { get => _brokerForPlacingLoan; set => _brokerForPlacingLoan = value; }
        private DirtyValue<string> _brokerInterestRateEffect;
        /// <summary>
        /// State Disc - Effect of Int Rate on Broker Comp [DISCLOSURE.X212]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Effect of Int Rate on Broker Comp")]
        public string BrokerInterestRateEffect { get => _brokerInterestRateEffect; set => _brokerInterestRateEffect = value; }
        private DirtyValue<string> _brokerLenderRelationship;
        /// <summary>
        /// State Disc - Broker Relationship with Lender [DISCLOSURE.X213]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Relationship with Lender")]
        public string BrokerLenderRelationship { get => _brokerLenderRelationship; set => _brokerLenderRelationship = value; }
        private DirtyValue<string> _brokerLicenseNumberIdentifier;
        /// <summary>
        /// Closing Docs Mort Broker Lic Number [1935]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Mort Broker Lic Number")]
        public string BrokerLicenseNumberIdentifier { get => _brokerLicenseNumberIdentifier; set => _brokerLicenseNumberIdentifier = value; }
        private DirtyValue<string> _brokerNameAsLicensed;
        /// <summary>
        /// State Disc - Broker Name As Licensed [DISCLOSURE.X202]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Name As Licensed")]
        public string BrokerNameAsLicensed { get => _brokerNameAsLicensed; set => _brokerNameAsLicensed = value; }
        private DirtyValue<string> _brokerTaxIdentificationNumberIdentifier;
        /// <summary>
        /// Closing Docs Mort Broker Tax ID Number [1937]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Mort Broker Tax ID Number")]
        public string BrokerTaxIdentificationNumberIdentifier { get => _brokerTaxIdentificationNumberIdentifier; set => _brokerTaxIdentificationNumberIdentifier = value; }
        private DirtyValue<StringEnumValue<BrokerWithLenders>> _brokerWithLenders;
        /// <summary>
        /// State Disc - Broker Places Loans W/Lender(s) [DISCLOSURE.X200]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Places Loans W/Lender(s)")]
        public StringEnumValue<BrokerWithLenders> BrokerWithLenders { get => _brokerWithLenders; set => _brokerWithLenders = value; }
        private DirtyValue<decimal?> _cashCheckFromBorrower;
        /// <summary>
        /// HUD1 HUD1A - Plus Cash/Ck from Borr [HUD1A.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD1 HUD1A - Plus Cash/Ck from Borr")]
        public decimal? CashCheckFromBorrower { get => _cashCheckFromBorrower; set => _cashCheckFromBorrower = value; }
        private DirtyValue<DateTime?> _cLClearCloseStatusReceivedByLenderDateTime;
        /// <summary>
        /// Title Closing Disclosure - Clear to Close Status Received by Lender Date Time [CL.WF.EVNT.CLRTOCLOS]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Clear to Close Status Received by Lender Date Time")]
        public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get => _cLClearCloseStatusReceivedByLenderDateTime; set => _cLClearCloseStatusReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLClosingEscrowOrderAcceptedDateTime;
        /// <summary>
        /// Title Closing Disclosure - Closing + Escrow Order Accepted Date Time [CL.WF.EVNT.CODRACCP]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Closing + Escrow Order Accepted Date Time")]
        public DateTime? CLClosingEscrowOrderAcceptedDateTime { get => _cLClosingEscrowOrderAcceptedDateTime; set => _cLClosingEscrowOrderAcceptedDateTime = value; }
        private DirtyValue<DateTime?> _cLClosingEscrowOrderSentDateTime;
        /// <summary>
        /// Title Closing Disclosure - Closing + Escrow Order Sent Date Time [CL.WF.EVNT.CODRSENT]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Closing + Escrow Order Sent Date Time")]
        public DateTime? CLClosingEscrowOrderSentDateTime { get => _cLClosingEscrowOrderSentDateTime; set => _cLClosingEscrowOrderSentDateTime = value; }
        private DirtyValue<DateTime?> _cLDraftClosingDisclosureReceivedByLenderDateTime;
        /// <summary>
        /// Title Closing Disclosure - Draft Closing Disclosure Received by the Lender Date Time [CL.WF.EVNT.INIDSCLO]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Draft Closing Disclosure Received by the Lender Date Time")]
        public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get => _cLDraftClosingDisclosureReceivedByLenderDateTime; set => _cLDraftClosingDisclosureReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLFinalCDSentDateTime;
        /// <summary>
        /// Title Closing Disclosure - Final CD Sent Date Time [CL.WF.EVNT.FINLCDSENT]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Final CD Sent Date Time")]
        public DateTime? CLFinalCDSentDateTime { get => _cLFinalCDSentDateTime; set => _cLFinalCDSentDateTime = value; }
        private DirtyValue<DateTime?> _cLFinalTitlePolicyDateTime;
        /// <summary>
        /// Title Closing Disclosure - Final Title Policy Date Time [CL.WF.EVNT.FINLTITLPLCY]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Final Title Policy Date Time")]
        public DateTime? CLFinalTitlePolicyDateTime { get => _cLFinalTitlePolicyDateTime; set => _cLFinalTitlePolicyDateTime = value; }
        private DirtyValue<DateTime?> _cLLastFeeQuoteReceivedDateTime;
        /// <summary>
        /// Title Closing Disclosure - Last Fee Quote Received Date Time [CL.WF.EVNT.ODRQOTEACCP]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Last Fee Quote Received Date Time")]
        public DateTime? CLLastFeeQuoteReceivedDateTime { get => _cLLastFeeQuoteReceivedDateTime; set => _cLLastFeeQuoteReceivedDateTime = value; }
        private DirtyValue<DateTime?> _cLLastFeeQuoteRequestedDateTime;
        /// <summary>
        /// Title Closing Disclosure - Last Fee Quote Requested Date Time [CL.WF.EVNT.ODRQUOTE]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Last Fee Quote Requested Date Time")]
        public DateTime? CLLastFeeQuoteRequestedDateTime { get => _cLLastFeeQuoteRequestedDateTime; set => _cLLastFeeQuoteRequestedDateTime = value; }
        private DirtyValue<StringEnumValue<DocsLoanProgramType>> _closingDocsLoanProgramType;
        /// <summary>
        /// Closing Documents - Plan Code Type [PlanCode.LoanProgTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents - Plan Code Type")]
        public StringEnumValue<DocsLoanProgramType> ClosingDocsLoanProgramType { get => _closingDocsLoanProgramType; set => _closingDocsLoanProgramType = value; }
        private DirtyList<ClosingEntity> _closingEntities;
        /// <summary>
        /// ClosingDocument ClosingEntities
        /// </summary>
        public IList<ClosingEntity> ClosingEntities { get => _closingEntities ?? (_closingEntities = new DirtyList<ClosingEntity>()); set => _closingEntities = new DirtyList<ClosingEntity>(value); }
        private DirtyValue<string> _closingProvider;
        /// <summary>
        /// Closing Loan Info Plan Closing Provider [2399]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Loan Info Plan Closing Provider")]
        public string ClosingProvider { get => _closingProvider; set => _closingProvider = value; }
        private DirtyValue<string> _closingState;
        /// <summary>
        /// Closing State [3542]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Closing State")]
        public string ClosingState { get => _closingState; set => _closingState = value; }
        private DirtyValue<DateTime?> _cLPayoffsRequestedDateTime;
        /// <summary>
        /// Title Closing Disclosure - Payoffs Requested Date Time [CL.WF.EVNT.ODRPAYOFF]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Payoffs Requested Date Time")]
        public DateTime? CLPayoffsRequestedDateTime { get => _cLPayoffsRequestedDateTime; set => _cLPayoffsRequestedDateTime = value; }
        private DirtyValue<DateTime?> _cLPrelimCommitmentReceivedByLenderDateTime;
        /// <summary>
        /// Title Closing Disclosure - Prelim / Commitment Received by the Lender Date Time [CL.WF.EVNT.PRELIMRECV]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Prelim / Commitment Received by the Lender Date Time")]
        public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get => _cLPrelimCommitmentReceivedByLenderDateTime; set => _cLPrelimCommitmentReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLProviderDisburseFundsDateTime;
        /// <summary>
        /// Title Closing Disclosure - Provider Disburse Funds [CL.WF.EVNT.FNDDISB]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Provider Disburse Funds")]
        public DateTime? CLProviderDisburseFundsDateTime { get => _cLProviderDisburseFundsDateTime; set => _cLProviderDisburseFundsDateTime = value; }
        private DirtyValue<DateTime?> _cLTitleOrderAcceptedDateTime;
        /// <summary>
        /// Title Closing Disclosure - Title Order Accepted Date Time [CL.WF.EVNT.TODRACCP]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Title Order Accepted Date Time")]
        public DateTime? CLTitleOrderAcceptedDateTime { get => _cLTitleOrderAcceptedDateTime; set => _cLTitleOrderAcceptedDateTime = value; }
        private DirtyValue<DateTime?> _cLTitleOrderSentDateTime;
        /// <summary>
        /// Title Closing Disclosure - Title Order Sent Date Time [CL.WF.EVNT.TODRSENT]
        /// </summary>
        [LoanFieldProperty(Description = "Title Closing Disclosure - Title Order Sent Date Time")]
        public DateTime? CLTitleOrderSentDateTime { get => _cLTitleOrderSentDateTime; set => _cLTitleOrderSentDateTime = value; }
        private DirtyValue<string> _complianceJurisdictionCounty;
        /// <summary>
        /// Compliance Jurisdiction Type [2550]
        /// </summary>
        [LoanFieldProperty(Description = "Compliance Jurisdiction Type")]
        public string ComplianceJurisdictionCounty { get => _complianceJurisdictionCounty; set => _complianceJurisdictionCounty = value; }
        private DirtyValue<DateTime?> _compliancePropertyIdentifiedDate;
        /// <summary>
        /// Closing Docs REGZ Loan Info Property Identified Date [2851]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs REGZ Loan Info Property Identified Date")]
        public DateTime? CompliancePropertyIdentifiedDate { get => _compliancePropertyIdentifiedDate; set => _compliancePropertyIdentifiedDate = value; }
        private DirtyValue<string> _conditionDescription;
        /// <summary>
        /// Closing Docs Instructions Condition Descrip [1952]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Instructions Condition Descrip")]
        public string ConditionDescription { get => _conditionDescription; set => _conditionDescription = value; }
        private DirtyValue<bool?> _conflictofInterestCheck1;
        /// <summary>
        /// State Disc - Licensee Provides Services [DISCLOSURE.X214]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Licensee Provides Services")]
        public bool? ConflictofInterestCheck1 { get => _conflictofInterestCheck1; set => _conflictofInterestCheck1 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck2;
        /// <summary>
        /// State Disc - Licensee/Relative Controls 10% Equity [DISCLOSURE.X215]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Licensee/Relative Controls 10% Equity")]
        public bool? ConflictofInterestCheck2 { get => _conflictofInterestCheck2; set => _conflictofInterestCheck2 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck3;
        /// <summary>
        /// State Disc - Provider Controls 10% Equity [DISCLOSURE.X216]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Provider Controls 10% Equity")]
        public bool? ConflictofInterestCheck3 { get => _conflictofInterestCheck3; set => _conflictofInterestCheck3 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck4;
        /// <summary>
        /// State Disc - Holding Company Controls 10% Equity [DISCLOSURE.X217]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Holding Company Controls 10% Equity")]
        public bool? ConflictofInterestCheck4 { get => _conflictofInterestCheck4; set => _conflictofInterestCheck4 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck5;
        /// <summary>
        /// State Disc - Same Officer/Director for Licensee/Prvdr [DISCLOSURE.X218]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Same Officer/Director for Licensee/Prvdr")]
        public bool? ConflictofInterestCheck5 { get => _conflictofInterestCheck5; set => _conflictofInterestCheck5 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck6;
        /// <summary>
        /// State Disc - Licensee Is Officer/Director for Prvdr [DISCLOSURE.X219]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Licensee Is Officer/Director for Prvdr")]
        public bool? ConflictofInterestCheck6 { get => _conflictofInterestCheck6; set => _conflictofInterestCheck6 = value; }
        private DirtyValue<string> _coopApartmentNumber;
        /// <summary>
        /// Closing Docs Coop Loan Coop Apartment Number [2644]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Coop Apartment Number")]
        public string CoopApartmentNumber { get => _coopApartmentNumber; set => _coopApartmentNumber = value; }
        private DirtyValue<DateTime?> _coopAssignmentLeaseDate;
        /// <summary>
        /// Closing Docs Coop Loan Coop Assignment Lease date [2642]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Coop Assignment Lease date")]
        public DateTime? CoopAssignmentLeaseDate { get => _coopAssignmentLeaseDate; set => _coopAssignmentLeaseDate = value; }
        private DirtyValue<string> _coopAttorneyInFact;
        /// <summary>
        /// Closing Docs Coop Loan Attorney in Fact [2640]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Attorney in Fact")]
        public string CoopAttorneyInFact { get => _coopAttorneyInFact; set => _coopAttorneyInFact = value; }
        private DirtyValue<string> _coopBuildingName;
        /// <summary>
        /// Closing Docs Coop Loan Building Name [2639]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Building Name")]
        public string CoopBuildingName { get => _coopBuildingName; set => _coopBuildingName = value; }
        private DirtyValue<string> _coopCompanyExistsUnderTHeLawsOf;
        /// <summary>
        /// Closing Docs Coop Loan Company Exists Under The Laws Of [2638]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Company Exists Under The Laws Of")]
        public string CoopCompanyExistsUnderTHeLawsOf { get => _coopCompanyExistsUnderTHeLawsOf; set => _coopCompanyExistsUnderTHeLawsOf = value; }
        private DirtyValue<string> _coopCompanyName;
        /// <summary>
        /// Closing Docs Coop Loan Company Name [2636]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Company Name")]
        public string CoopCompanyName { get => _coopCompanyName; set => _coopCompanyName = value; }
        private DirtyValue<DateTime?> _coopProprietaryLeaseDate;
        /// <summary>
        /// Closing Docs Coop Loan Proprietary Lease Date [2641]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Proprietary Lease Date")]
        public DateTime? CoopProprietaryLeaseDate { get => _coopProprietaryLeaseDate; set => _coopProprietaryLeaseDate = value; }
        private DirtyValue<decimal?> _coopSharesOwned;
        /// <summary>
        /// Closing Docs Coop Loan Shares Owned [2635]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Closing Docs Coop Loan Shares Owned")]
        public decimal? CoopSharesOwned { get => _coopSharesOwned; set => _coopSharesOwned = value; }
        private DirtyValue<string> _coopStockCertificationNumber;
        /// <summary>
        /// Closing Docs Coop Loan Coop Stock Certification Number [2643]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Coop Loan Coop Stock Certification Number")]
        public string CoopStockCertificationNumber { get => _coopStockCertificationNumber; set => _coopStockCertificationNumber = value; }
        private DirtyValue<decimal?> _coopVacancyPercentNotification;
        /// <summary>
        /// Closing Docs Coop Loan Vacancy Percent Notification [2637]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Docs Coop Loan Vacancy Percent Notification")]
        public decimal? CoopVacancyPercentNotification { get => _coopVacancyPercentNotification; set => _coopVacancyPercentNotification = value; }
        private DirtyValue<string> _customOtherRiderDescription;
        /// <summary>
        /// Custom Other Rider Description [4055]
        /// </summary>
        [LoanFieldProperty(Description = "Custom Other Rider Description")]
        public string CustomOtherRiderDescription { get => _customOtherRiderDescription; set => _customOtherRiderDescription = value; }
        private DirtyValue<DateTime?> _disbursementDate;
        /// <summary>
        /// Closing Docs REGZ Loan Info Disbursement Date [2553]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs REGZ Loan Info Disbursement Date")]
        public DateTime? DisbursementDate { get => _disbursementDate; set => _disbursementDate = value; }
        private DirtyValue<decimal?> _disbursementsToBorrower;
        /// <summary>
        /// HUD1 HUD1A - Equals Disburs to Borr [HUD1A.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD1 HUD1A - Equals Disburs to Borr")]
        public decimal? DisbursementsToBorrower { get => _disbursementsToBorrower; set => _disbursementsToBorrower = value; }
        private DirtyValue<string> _disclosureAlternateLender;
        /// <summary>
        /// Closing Docs REGZ Loan Info Disclosure Alt Lender [DISCLOSUREALTLENDER]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs REGZ Loan Info Disclosure Alt Lender")]
        public string DisclosureAlternateLender { get => _disclosureAlternateLender; set => _disclosureAlternateLender = value; }
        private DirtyValue<string> _disclosureCompanyFunction;
        /// <summary>
        /// Closing Docs REGZ Loan Info Disclosure Company Function [DISCLOSURECOFUNCTION]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs REGZ Loan Info Disclosure Company Function")]
        public string DisclosureCompanyFunction { get => _disclosureCompanyFunction; set => _disclosureCompanyFunction = value; }
        private DirtyValue<string> _disclosurePlanCode;
        /// <summary>
        /// Closing Docs REGZ Loan Info Disclosure Plan Code [DISCLOSUREPLANCODE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs REGZ Loan Info Disclosure Plan Code")]
        public string DisclosurePlanCode { get => _disclosurePlanCode; set => _disclosurePlanCode = value; }
        private DirtyValue<string> _docReportGUID;
        /// <summary>
        /// REGZ Loan Info DOC Report GUID [3900]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Loan Info DOC Report GUID")]
        public string DocReportGUID { get => _docReportGUID; set => _docReportGUID = value; }
        private DirtyValue<DateTime?> _documentPreparationDate;
        /// <summary>
        /// REGZ Loan Info Document Date [L770]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Loan Info Document Date")]
        public DateTime? DocumentPreparationDate { get => _documentPreparationDate; set => _documentPreparationDate = value; }
        private DirtyValue<DateTime?> _documentSigningDate;
        /// <summary>
        /// REGZ Loan Info Document Signing Date [1887]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Loan Info Document Signing Date")]
        public DateTime? DocumentSigningDate { get => _documentSigningDate; set => _documentSigningDate = value; }
        private DirtyValue<string> _drawCity;
        /// <summary>
        /// Closing Draw City [L827]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Draw City")]
        public string DrawCity { get => _drawCity; set => _drawCity = value; }
        private DirtyValue<string> _drawCounty;
        /// <summary>
        /// Closing County [1949]
        /// </summary>
        [LoanFieldProperty(Description = "Closing County")]
        public string DrawCounty { get => _drawCounty; set => _drawCounty = value; }
        private DirtyValue<string> _drawState;
        /// <summary>
        /// Closing Draw State [L812]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Closing Draw State")]
        public string DrawState { get => _drawState; set => _drawState = value; }
        private DirtyValue<StringEnumValue<YNOrOther>> _employeeofMortgageLender;
        /// <summary>
        /// State Disc - Broker Is Employee of Mtg Lender [DISCLOSURE.X208]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Broker Is Employee of Mtg Lender")]
        public StringEnumValue<YNOrOther> EmployeeofMortgageLender { get => _employeeofMortgageLender; set => _employeeofMortgageLender = value; }
        private DirtyValue<string> _expectToAssignSellOrTransferPercent;
        /// <summary>
        /// Closing Docs RESPA Expect to Assign, Sell, Service Percent [1927]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs RESPA Expect to Assign, Sell, Service Percent")]
        public string ExpectToAssignSellOrTransferPercent { get => _expectToAssignSellOrTransferPercent; set => _expectToAssignSellOrTransferPercent = value; }
        private DirtyValue<string> _finalVestingDescription;
        /// <summary>
        /// Borrower Vesting Borr Final Vesting to Read [1867]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Borrower Vesting Borr Final Vesting to Read")]
        public string FinalVestingDescription { get => _finalVestingDescription; set => _finalVestingDescription = value; }
        private DirtyValue<string> _firstTransferYear;
        /// <summary>
        /// Closing Docs RESPA First Transfer Year [1928]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs RESPA First Transfer Year")]
        public string FirstTransferYear { get => _firstTransferYear; set => _firstTransferYear = value; }
        private DirtyValue<decimal?> _firstTransferYearValue;
        /// <summary>
        /// Closing Docs RESPA First Transfer Year Value [1929]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Closing Docs RESPA First Transfer Year Value")]
        public decimal? FirstTransferYearValue { get => _firstTransferYearValue; set => _firstTransferYearValue = value; }
        private DirtyValue<string> _hoursDocumentsNeededPriorToDisbursementCount;
        /// <summary>
        /// Closing Hrs Docs needed prior to disbrsmnt [1950]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Hrs Docs needed prior to disbrsmnt")]
        public string HoursDocumentsNeededPriorToDisbursementCount { get => _hoursDocumentsNeededPriorToDisbursementCount; set => _hoursDocumentsNeededPriorToDisbursementCount = value; }
        private DirtyValue<bool?> _housingIndicator;
        /// <summary>
        /// Closing Docs for Ellie Mae Network Housing Indicator [HOUSINGPROGRAM.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs for Ellie Mae Network Housing Indicator")]
        public bool? HousingIndicator { get => _housingIndicator; set => _housingIndicator = value; }
        private DirtyValue<string> _housingProgramName;
        /// <summary>
        /// Closing Docs for Ellie Mae Network Housing Program Name [HOUSINGPROGRAM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs for Ellie Mae Network Housing Program Name")]
        public string HousingProgramName { get => _housingProgramName; set => _housingProgramName = value; }
        private DirtyValue<string> _hUD1FileNumberIdentifier;
        /// <summary>
        /// HUD1 File # [L72]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1 File #")]
        public string HUD1FileNumberIdentifier { get => _hUD1FileNumberIdentifier; set => _hUD1FileNumberIdentifier = value; }
        private DirtyValue<string> _hUD1SettlementAgentUnparsedAddress;
        /// <summary>
        /// HUD1 Place of Settlement [L75]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1 Place of Settlement")]
        public string HUD1SettlementAgentUnparsedAddress { get => _hUD1SettlementAgentUnparsedAddress; set => _hUD1SettlementAgentUnparsedAddress = value; }
        private DirtyValue<string> _hUD1SettlementAgentUnparsedName;
        /// <summary>
        /// HUD1 Settlement Agent [L74]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1 Settlement Agent")]
        public string HUD1SettlementAgentUnparsedName { get => _hUD1SettlementAgentUnparsedName; set => _hUD1SettlementAgentUnparsedName = value; }
        private DirtyValue<DateTime?> _hUD1SettlementDate;
        /// <summary>
        /// HUD1 Settlement Date [L76]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1 Settlement Date")]
        public DateTime? HUD1SettlementDate { get => _hUD1SettlementDate; set => _hUD1SettlementDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDocument Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _includeSafeHaborDisclosure;
        /// <summary>
        /// Anti-Steering Disclosure - Include Safe Habor Disclosure [DISCLOSURE.X867]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Anti-Steering Disclosure - Include Safe Habor Disclosure")]
        public decimal? IncludeSafeHaborDisclosure { get => _includeSafeHaborDisclosure; set => _includeSafeHaborDisclosure = value; }
        private DirtyValue<string> _investorCode;
        /// <summary>
        /// Closing Documents - Investor Code [PlanCode.InvCd]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents - Investor Code")]
        public string InvestorCode { get => _investorCode; set => _investorCode = value; }
        private DirtyValue<string> _lastAuditDate;
        /// <summary>
        /// REGZ Loan Info Last Audit Date [1885]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Loan Info Last Audit Date")]
        public string LastAuditDate { get => _lastAuditDate; set => _lastAuditDate = value; }
        private DirtyValue<string> _lastDocumentOrdered;
        /// <summary>
        /// REGZ Loan Info Last Document Ordered [1886]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Loan Info Last Document Ordered")]
        public string LastDocumentOrdered { get => _lastDocumentOrdered; set => _lastDocumentOrdered = value; }
        private DirtyValue<bool?> _legalAttached;
        /// <summary>
        /// Property Info Attach Legal Descr [1884]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Attach Legal Descr", OptionsJson = "{\"true\":\"Attach legal description\"}")]
        public bool? LegalAttached { get => _legalAttached; set => _legalAttached = value; }
        private DirtyValue<string> _lenderAuthorizedRepresentativeTitle;
        /// <summary>
        /// State Disc - Lender Rep Title [DISCLOSURE.X187]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Lender Rep Title")]
        public string LenderAuthorizedRepresentativeTitle { get => _lenderAuthorizedRepresentativeTitle; set => _lenderAuthorizedRepresentativeTitle = value; }
        private DirtyValue<string> _lenderBrokerRepresents;
        /// <summary>
        /// State Disc - Lender Broker Rep [DISCLOSURE.X185]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Lender Broker Rep")]
        public string LenderBrokerRepresents { get => _lenderBrokerRepresents; set => _lenderBrokerRepresents = value; }
        private DirtyValue<string> _lienHolderAddress;
        /// <summary>
        /// Closing Docs Mfg Home Address of Lien Holder [3645]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Address of Lien Holder")]
        public string LienHolderAddress { get => _lienHolderAddress; set => _lienHolderAddress = value; }
        private DirtyValue<string> _lienHolderAddressCity;
        /// <summary>
        /// Closing Docs Mfg Home Address City of Lien Holder [3646]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Address City of Lien Holder")]
        public string LienHolderAddressCity { get => _lienHolderAddressCity; set => _lienHolderAddressCity = value; }
        private DirtyValue<string> _lienHolderAddressPostalCode;
        /// <summary>
        /// Closing Docs Mfg Home Postal Code of Lien Holder [3648]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Closing Docs Mfg Home Postal Code of Lien Holder")]
        public string LienHolderAddressPostalCode { get => _lienHolderAddressPostalCode; set => _lienHolderAddressPostalCode = value; }
        private DirtyValue<string> _lienHolderAddressState;
        /// <summary>
        /// Closing Docs Mfg Home Address State of Lien Holder [3647]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Closing Docs Mfg Home Address State of Lien Holder")]
        public string LienHolderAddressState { get => _lienHolderAddressState; set => _lienHolderAddressState = value; }
        private DirtyValue<string> _lienHolderName;
        /// <summary>
        /// Closing Docs Mfg Home Name of Lien Holder [3644]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Name of Lien Holder")]
        public string LienHolderName { get => _lienHolderName; set => _lienHolderName = value; }
        private DirtyValue<bool?> _loanIsLocked;
        /// <summary>
        /// Closing Loan Info Loan is Locked [2400]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Loan Info Loan is Locked")]
        public bool? LoanIsLocked { get => _loanIsLocked; set => _loanIsLocked = value; }
        private DirtyValue<StringEnumValue<LoanOption>> _loanOption;
        /// <summary>
        /// Anti-Steering Disclosure - LoanOption [DISCLOSURE.X732]
        /// </summary>
        [LoanFieldProperty(Description = "Anti-Steering Disclosure - LoanOption")]
        public StringEnumValue<LoanOption> LoanOption { get => _loanOption; set => _loanOption = value; }
        private DirtyValue<StringEnumValue<LockInFeeType>> _lockInFeeType;
        /// <summary>
        /// State Disc - Lock In Fee Type [DISCLOSURE.X198]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Lock In Fee Type")]
        public StringEnumValue<LockInFeeType> LockInFeeType { get => _lockInFeeType; set => _lockInFeeType = value; }
        private DirtyValue<StringEnumValue<MfgHomeAnchored>> _mfgHomeAnchored;
        /// <summary>
        /// Closing Docs Mfg Home Anchored [2589]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Anchored")]
        public StringEnumValue<MfgHomeAnchored> MfgHomeAnchored { get => _mfgHomeAnchored; set => _mfgHomeAnchored = value; }
        private DirtyValue<string> _mfgHomeCertificateOfTitleIdentifier;
        /// <summary>
        /// Closing Docs Mfg Home Cert of Title ID [2584]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Cert of Title ID")]
        public string MfgHomeCertificateOfTitleIdentifier { get => _mfgHomeCertificateOfTitleIdentifier; set => _mfgHomeCertificateOfTitleIdentifier = value; }
        private DirtyValue<StringEnumValue<MfgHomeCertificateOfTitleType>> _mfgHomeCertificateOfTitleType;
        /// <summary>
        /// Closing Docs Mfg Home Cert of Title Type [2585]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Cert of Title Type")]
        public StringEnumValue<MfgHomeCertificateOfTitleType> MfgHomeCertificateOfTitleType { get => _mfgHomeCertificateOfTitleType; set => _mfgHomeCertificateOfTitleType = value; }
        private DirtyValue<string> _mfgHomeDescription;
        /// <summary>
        /// Closing Docs Mfg Home Descr [2590]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Descr")]
        public string MfgHomeDescription { get => _mfgHomeDescription; set => _mfgHomeDescription = value; }
        private DirtyValue<string> _mfgHomeHUDCertificationLabelIdentifier;
        /// <summary>
        /// Closing Docs Mfg Home HUD Cert. Label ID [2588]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home HUD Cert. Label ID")]
        public string MfgHomeHUDCertificationLabelIdentifier { get => _mfgHomeHUDCertificationLabelIdentifier; set => _mfgHomeHUDCertificationLabelIdentifier = value; }
        private DirtyValue<int?> _mfgHomeLengthFeetCount;
        /// <summary>
        /// Closing Docs Mfg Home Length (Ft) [2580]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Length (Ft)")]
        public int? MfgHomeLengthFeetCount { get => _mfgHomeLengthFeetCount; set => _mfgHomeLengthFeetCount = value; }
        private DirtyValue<string> _mfgHomeMakeIdentifier;
        /// <summary>
        /// Closing Docs Mfg Home Make [2578]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Make")]
        public string MfgHomeMakeIdentifier { get => _mfgHomeMakeIdentifier; set => _mfgHomeMakeIdentifier = value; }
        private DirtyValue<string> _mfgHomeManufacturer;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer [2582]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Manufacturer")]
        public string MfgHomeManufacturer { get => _mfgHomeManufacturer; set => _mfgHomeManufacturer = value; }
        private DirtyValue<string> _mfgHomeManufacturerAddress;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer Address [4064]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Manufacturer Address")]
        public string MfgHomeManufacturerAddress { get => _mfgHomeManufacturerAddress; set => _mfgHomeManufacturerAddress = value; }
        private DirtyValue<string> _mfgHomeManufacturerCity;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer City [4065]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Manufacturer City")]
        public string MfgHomeManufacturerCity { get => _mfgHomeManufacturerCity; set => _mfgHomeManufacturerCity = value; }
        private DirtyValue<string> _mfgHomeManufacturerPhoneNumber;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer Phone Number [4068]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Closing Docs Mfg Home Manufacturer Phone Number")]
        public string MfgHomeManufacturerPhoneNumber { get => _mfgHomeManufacturerPhoneNumber; set => _mfgHomeManufacturerPhoneNumber = value; }
        private DirtyValue<string> _mfgHomeManufacturerPostalCode;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer Postal Code [4067]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Closing Docs Mfg Home Manufacturer Postal Code")]
        public string MfgHomeManufacturerPostalCode { get => _mfgHomeManufacturerPostalCode; set => _mfgHomeManufacturerPostalCode = value; }
        private DirtyValue<string> _mfgHomeManufacturerState;
        /// <summary>
        /// Closing Docs Mfg Home Manufacturer State [4066]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "Closing Docs Mfg Home Manufacturer State")]
        public string MfgHomeManufacturerState { get => _mfgHomeManufacturerState; set => _mfgHomeManufacturerState = value; }
        private DirtyValue<int?> _mfgHomeManufactureYear;
        /// <summary>
        /// Closing Docs Mfg Home Year [2579]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Year")]
        public int? MfgHomeManufactureYear { get => _mfgHomeManufactureYear; set => _mfgHomeManufactureYear = value; }
        private DirtyValue<string> _mfgHomeModelIdentifier;
        /// <summary>
        /// Closing Docs Mfg Home Model [2586]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Model")]
        public string MfgHomeModelIdentifier { get => _mfgHomeModelIdentifier; set => _mfgHomeModelIdentifier = value; }
        private DirtyValue<StringEnumValue<MfgHomeNewOrUsed>> _mfgHomeNewOrUsed;
        /// <summary>
        /// Closing Docs Mfg Home New or Used [2587]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home New or Used")]
        public StringEnumValue<MfgHomeNewOrUsed> MfgHomeNewOrUsed { get => _mfgHomeNewOrUsed; set => _mfgHomeNewOrUsed = value; }
        private DirtyValue<string> _mfgHomeSerialNumberIdentifier;
        /// <summary>
        /// Closing Docs Mfg Home Serial No [2583]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Serial No")]
        public string MfgHomeSerialNumberIdentifier { get => _mfgHomeSerialNumberIdentifier; set => _mfgHomeSerialNumberIdentifier = value; }
        private DirtyValue<int?> _mfgHomeWidthFeetCount;
        /// <summary>
        /// Closing Docs Mfg Home Width (Ft) [2581]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Mfg Home Width (Ft)")]
        public int? MfgHomeWidthFeetCount { get => _mfgHomeWidthFeetCount; set => _mfgHomeWidthFeetCount = value; }
        private DirtyValue<string> _mineralRightsDescription;
        /// <summary>
        /// Property Info Mineral Rights Descr [1883]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Mineral Rights Descr")]
        public string MineralRightsDescription { get => _mineralRightsDescription; set => _mineralRightsDescription = value; }
        private DirtyValue<StringEnumValue<MortgageType>> _mortgageType;
        /// <summary>
        /// HUD1 Loan Type [L83]
        /// </summary>
        [LoanFieldProperty(Description = "HUD1 Loan Type")]
        public StringEnumValue<MortgageType> MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<int?> _numberBrokerAgreements;
        /// <summary>
        /// State Disc - No. Broker Agreements [DISCLOSURE.X182]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - No. Broker Agreements")]
        public int? NumberBrokerAgreements { get => _numberBrokerAgreements; set => _numberBrokerAgreements = value; }
        private DirtyValue<int?> _numberSuccessfulBrokerAgreements;
        /// <summary>
        /// State Disc - No. Successful Broker Agreements [DISCLOSURE.X183]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - No. Successful Broker Agreements")]
        public int? NumberSuccessfulBrokerAgreements { get => _numberSuccessfulBrokerAgreements; set => _numberSuccessfulBrokerAgreements = value; }
        private DirtyValue<string> _officeOfRecordationName;
        /// <summary>
        /// Closing Docs Recordable Doc Associated Doc Office of Rec Name [1938]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Recordable Doc Associated Doc Office of Rec Name")]
        public string OfficeOfRecordationName { get => _officeOfRecordationName; set => _officeOfRecordationName = value; }
        private DirtyValue<bool?> _onlyOneEntity;
        /// <summary>
        /// State Disc - Loans Brokered to Only 1 Entity [DISCLOSURE.X206]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Loans Brokered to Only 1 Entity")]
        public bool? OnlyOneEntity { get => _onlyOneEntity; set => _onlyOneEntity = value; }
        private DirtyValue<string> _optionSelectedReason;
        /// <summary>
        /// Anti-Steering Disclosure - The Reason to Select this Option [DISCLOSURE.X734]
        /// </summary>
        [LoanFieldProperty(Description = "Anti-Steering Disclosure - The Reason to Select this Option")]
        public string OptionSelectedReason { get => _optionSelectedReason; set => _optionSelectedReason = value; }
        private DirtyValue<decimal?> _originalPincipalAmountSecured;
        /// <summary>
        /// Closing Docs Mfg Home Original Pincipal Amount Secured [3649]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Docs Mfg Home Original Pincipal Amount Secured")]
        public decimal? OriginalPincipalAmountSecured { get => _originalPincipalAmountSecured; set => _originalPincipalAmountSecured = value; }
        private DirtyValue<string> _otherOptionDescription;
        /// <summary>
        /// Anti-Steering Disclosure - Other Option Description [DISCLOSURE.X733]
        /// </summary>
        [LoanFieldProperty(Description = "Anti-Steering Disclosure - Other Option Description")]
        public string OtherOptionDescription { get => _otherOptionDescription; set => _otherOptionDescription = value; }
        private DirtyValue<string> _parentAffiliatedCoName;
        /// <summary>
        /// State Disc - Parent or Affiliated Co Name [DISCLOSURE.X204]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Parent or Affiliated Co Name")]
        public string ParentAffiliatedCoName { get => _parentAffiliatedCoName; set => _parentAffiliatedCoName = value; }
        private DirtyValue<string> _payToTheOrderOfDescription;
        /// <summary>
        /// REGZ Transfer To [1951]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Transfer To")]
        public string PayToTheOrderOfDescription { get => _payToTheOrderOfDescription; set => _payToTheOrderOfDescription = value; }
        private DirtyValue<StringEnumValue<PerDiemCalculationMethodType>> _perDiemCalculationMethodType;
        /// <summary>
        /// REGZ Construction Mortgage Number of Days [1962]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Construction Mortgage Number of Days")]
        public StringEnumValue<PerDiemCalculationMethodType> PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => _perDiemCalculationMethodType = value; }
        private DirtyValue<string> _planCode;
        /// <summary>
        /// REGZ Loan Info Plan Code [1881]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ Loan Info Plan Code")]
        public string PlanCode { get => _planCode; set => _planCode = value; }
        private DirtyValue<string> _planCodeDescription;
        /// <summary>
        /// Plan Code Description [PlanCode.Desc]
        /// </summary>
        [LoanFieldProperty(Description = "Plan Code Description")]
        public string PlanCodeDescription { get => _planCodeDescription; set => _planCodeDescription = value; }
        private DirtyValue<string> _planCodeId;
        /// <summary>
        /// Plan Code [PlanCode.ID]
        /// </summary>
        [LoanFieldProperty(Description = "Plan Code")]
        public string PlanCodeId { get => _planCodeId; set => _planCodeId = value; }
        private DirtyValue<DateTime?> _preliminaryTitleReportDate;
        /// <summary>
        /// Property Info Title Report Date [L362]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Title Report Date")]
        public DateTime? PreliminaryTitleReportDate { get => _preliminaryTitleReportDate; set => _preliminaryTitleReportDate = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions1;
        /// <summary>
        /// State Disc - Prepay Penalty Descr 1 [DISCLOSURE.X192]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Prepay Penalty Descr 1")]
        public string PrepaymentPenaltyDescriptions1 { get => _prepaymentPenaltyDescriptions1; set => _prepaymentPenaltyDescriptions1 = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions2;
        /// <summary>
        /// State Disc - Prepay Penalty Descr 2 [DISCLOSURE.X193]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Prepay Penalty Descr 2")]
        public string PrepaymentPenaltyDescriptions2 { get => _prepaymentPenaltyDescriptions2; set => _prepaymentPenaltyDescriptions2 = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions3;
        /// <summary>
        /// State Disc - Prepay Penalty Descr 3 [DISCLOSURE.X194]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Prepay Penalty Descr 3")]
        public string PrepaymentPenaltyDescriptions3 { get => _prepaymentPenaltyDescriptions3; set => _prepaymentPenaltyDescriptions3 = value; }
        private DirtyValue<int?> _processingNumberDays;
        /// <summary>
        /// State Disc - Days to Process [DISCLOSURE.X184]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Days to Process")]
        public int? ProcessingNumberDays { get => _processingNumberDays; set => _processingNumberDays = value; }
        private DirtyValue<string> _programCode;
        /// <summary>
        /// Closing Documents - Program Code [PlanCode.ProgCd]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents - Program Code")]
        public string ProgramCode { get => _programCode; set => _programCode = value; }
        private DirtyValue<string> _programSponsor;
        /// <summary>
        /// Closing Documents - Investor [PlanCode.ProgSpnsrNm]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents - Investor")]
        public string ProgramSponsor { get => _programSponsor; set => _programSponsor = value; }
        private DirtyValue<bool?> _propertyIsLandTrust;
        /// <summary>
        /// State Disc - Property Is In A Land Trust [DISCLOSURE.X207]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Property Is In A Land Trust")]
        public bool? PropertyIsLandTrust { get => _propertyIsLandTrust; set => _propertyIsLandTrust = value; }
        private DirtyValue<string> _propertyTaxMessageDescription;
        /// <summary>
        /// Property Info Tax Message [L360]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Tax Message")]
        public string PropertyTaxMessageDescription { get => _propertyTaxMessageDescription; set => _propertyTaxMessageDescription = value; }
        private DirtyValue<string> _rateLockRefundConditions1;
        /// <summary>
        /// State Disc - Rate Lock Refund Condition 1 [DISCLOSURE.X189]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Rate Lock Refund Condition 1")]
        public string RateLockRefundConditions1 { get => _rateLockRefundConditions1; set => _rateLockRefundConditions1 = value; }
        private DirtyValue<string> _rateLockRefundConditions2;
        /// <summary>
        /// State Disc - Rate Lock Refund Condition 2 [DISCLOSURE.X190]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Rate Lock Refund Condition 2")]
        public string RateLockRefundConditions2 { get => _rateLockRefundConditions2; set => _rateLockRefundConditions2 = value; }
        private DirtyValue<string> _rateLockRefundConditions3;
        /// <summary>
        /// State Disc - Rate Lock Refund Condition 3 [DISCLOSURE.X191]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Rate Lock Refund Condition 3")]
        public string RateLockRefundConditions3 { get => _rateLockRefundConditions3; set => _rateLockRefundConditions3 = value; }
        private DirtyValue<string> _recordingJurisdictionName;
        /// <summary>
        /// Closing Docs Recordable Doc Associated Doc Juris Name [1936]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs Recordable Doc Associated Doc Juris Name")]
        public string RecordingJurisdictionName { get => _recordingJurisdictionName; set => _recordingJurisdictionName = value; }
        private DirtyValue<bool?> _refinanceBalloonMortgageGuarantee;
        /// <summary>
        /// State Disc - Lender Guarantees Balloon Refi [DISCLOSURE.X201]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Lender Guarantees Balloon Refi")]
        public bool? RefinanceBalloonMortgageGuarantee { get => _refinanceBalloonMortgageGuarantee; set => _refinanceBalloonMortgageGuarantee = value; }
        private DirtyValue<bool?> _refinanceRightOfRescissionExemptFlag;
        /// <summary>
        /// REGZ Loan Info Exempt from Right of Rescission [3942]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Loan Info Exempt from Right of Rescission")]
        public bool? RefinanceRightOfRescissionExemptFlag { get => _refinanceRightOfRescissionExemptFlag; set => _refinanceRightOfRescissionExemptFlag = value; }
        private DirtyValue<string> _renewalExtensionDescription;
        /// <summary>
        /// Closing Docs Renewal and Extension [3240]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs Renewal and Extension")]
        public string RenewalExtensionDescription { get => _renewalExtensionDescription; set => _renewalExtensionDescription = value; }
        private DirtyValue<DateTime?> _rescissionDate;
        /// <summary>
        /// REGZ Loan Info Rescission Date [L724]
        /// </summary>
        [LoanFieldProperty(Description = "REGZ Loan Info Rescission Date")]
        public DateTime? RescissionDate { get => _rescissionDate; set => _rescissionDate = value; }
        private DirtyList<RespaHudDetail> _respaHudDetails;
        /// <summary>
        /// ClosingDocument RespaHudDetails
        /// </summary>
        public IList<RespaHudDetail> RespaHudDetails { get => _respaHudDetails ?? (_respaHudDetails = new DirtyList<RespaHudDetail>()); set => _respaHudDetails = new DirtyList<RespaHudDetail>(value); }
        private DirtyValue<string> _rMLANamePreceding10Years;
        /// <summary>
        /// State Disc - RMLA Name Preceding 10 Yrs [DISCLOSURE.X203]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - RMLA Name Preceding 10 Yrs")]
        public string RMLANamePreceding10Years { get => _rMLANamePreceding10Years; set => _rMLANamePreceding10Years = value; }
        private DirtyValue<string> _rmlLenderBrokerRepresents;
        /// <summary>
        /// State Disc - RML Licensees- Lender Broker Rep [DISCLOSURE.X952]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - RML Licensees- Lender Broker Rep")]
        public string RmlLenderBrokerRepresents { get => _rmlLenderBrokerRepresents; set => _rmlLenderBrokerRepresents = value; }
        private DirtyValue<string> _secondTransferYear;
        /// <summary>
        /// Closing Docs RESPA Second Transfer Year [1930]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs RESPA Second Transfer Year")]
        public string SecondTransferYear { get => _secondTransferYear; set => _secondTransferYear = value; }
        private DirtyValue<decimal?> _secondTransferYearValue;
        /// <summary>
        /// Closing Docs RESPA Second Transfer Year Value [1931]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Closing Docs RESPA Second Transfer Year Value")]
        public decimal? SecondTransferYearValue { get => _secondTransferYearValue; set => _secondTransferYearValue = value; }
        private DirtyValue<DateTime?> _signatureDateFor1003;
        /// <summary>
        /// Closing Docs 1003 Signature Date [3261]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs 1003 Signature Date")]
        public DateTime? SignatureDateFor1003 { get => _signatureDateFor1003; set => _signatureDateFor1003 = value; }
        private DirtyValue<StringEnumValue<SpecialFloodHazardAreaIndictor>> _specialFloodHazardAreaIndictor;
        /// <summary>
        /// Property Info Flood Zone [541]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Flood Zone")]
        public StringEnumValue<SpecialFloodHazardAreaIndictor> SpecialFloodHazardAreaIndictor { get => _specialFloodHazardAreaIndictor; set => _specialFloodHazardAreaIndictor = value; }
        private DirtyList<StateLicense> _stateLicenses;
        /// <summary>
        /// ClosingDocument StateLicenses
        /// </summary>
        public IList<StateLicense> StateLicenses { get => _stateLicenses ?? (_stateLicenses = new DirtyList<StateLicense>()); set => _stateLicenses = new DirtyList<StateLicense>(value); }
        private DirtyValue<string> _suretyCompanyName;
        /// <summary>
        /// State Disc - Surety Company Name [DISCLOSURE.X186]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - Surety Company Name")]
        public string SuretyCompanyName { get => _suretyCompanyName; set => _suretyCompanyName = value; }
        private DirtyValue<bool?> _syncInterestDateDisbursementDate;
        /// <summary>
        /// Closing Docs REGZ Loan Info Sync Prepaid Int [2852]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Docs REGZ Loan Info Sync Prepaid Int", OptionsJson = "{\"true\":\"Y\",\"false\":\"N\"}")]
        public bool? SyncInterestDateDisbursementDate { get => _syncInterestDateDisbursementDate; set => _syncInterestDateDisbursementDate = value; }
        private DirtyValue<StringEnumValue<YOrN>> _termiteReportRequiredIndicator;
        /// <summary>
        /// Closing Documents Termite Report Required [L493]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Documents Termite Report Required")]
        public StringEnumValue<YOrN> TermiteReportRequiredIndicator { get => _termiteReportRequiredIndicator; set => _termiteReportRequiredIndicator = value; }
        private DirtyValue<string> _textDescription;
        /// <summary>
        /// Property Info Legal Descr [1846]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Legal Descr")]
        public string TextDescription { get => _textDescription; set => _textDescription = value; }
        private DirtyValue<string> _thirdTransferYear;
        /// <summary>
        /// Closing Docs RESPA Third Transfer Year [1932]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Closing Docs RESPA Third Transfer Year")]
        public string ThirdTransferYear { get => _thirdTransferYear; set => _thirdTransferYear = value; }
        private DirtyValue<decimal?> _thirdTransferYearValue;
        /// <summary>
        /// Closing Docs RESPA Third Transfer Year Value [1933]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Closing Docs RESPA Third Transfer Year Value")]
        public decimal? ThirdTransferYearValue { get => _thirdTransferYearValue; set => _thirdTransferYearValue = value; }
        private DirtyValue<string> _titleReportItemsDescription;
        /// <summary>
        /// Property Info Approved Items [L361]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Approved Items")]
        public string TitleReportItemsDescription { get => _titleReportItemsDescription; set => _titleReportItemsDescription = value; }
        private DirtyValue<string> _titleReportRequiredEndorsementsDescription;
        /// <summary>
        /// Property Info Special Endorsements [L358]
        /// </summary>
        [LoanFieldProperty(Description = "Property Info Special Endorsements")]
        public string TitleReportRequiredEndorsementsDescription { get => _titleReportRequiredEndorsementsDescription; set => _titleReportRequiredEndorsementsDescription = value; }
        private DirtyValue<decimal?> _totalDisbursed;
        /// <summary>
        /// HUD1 HUD1A - 1520 Total Disbursed [HUD1A.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD1 HUD1A - 1520 Total Disbursed")]
        public decimal? TotalDisbursed { get => _totalDisbursed; set => _totalDisbursed = value; }
        private DirtyValue<string> _trust2Beneficiaries;
        /// <summary>
        /// Borrower Vesting Corp/Trust 2 Beneficiaries [Vesting.Trst2Bfcry]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Vesting Corp/Trust 2 Beneficiaries")]
        public string Trust2Beneficiaries { get => _trust2Beneficiaries; set => _trust2Beneficiaries = value; }
        private DirtyValue<StringEnumValue<WeConductBusiness>> _weConductBusiness;
        /// <summary>
        /// State Disc - We Conduct Business As [DISCLOSURE.X205]
        /// </summary>
        [LoanFieldProperty(Description = "State Disc - We Conduct Business As")]
        public StringEnumValue<WeConductBusiness> WeConductBusiness { get => _weConductBusiness; set => _weConductBusiness = value; }
        internal override bool DirtyInternal
        {
            get => _additionalLienHolderAddress.Dirty
                || _additionalLienHolderAddressCity.Dirty
                || _additionalLienHolderAddressPostalCode.Dirty
                || _additionalLienHolderAddressState.Dirty
                || _additionalLienHolderName.Dirty
                || _additionalOriginalPincipalAmountSecured.Dirty
                || _additionalSigVerbiageType.Dirty
                || _affectedByInterest.Dirty
                || _alternateLender.Dirty
                || _altLenderId.Dirty
                || _areAbleToServiceIndicator.Dirty
                || _associatedDocumentNumber.Dirty
                || _beneficiaries.Dirty
                || _borrowerConsentType1.Dirty
                || _borrowerConsentType2.Dirty
                || _borrowerOrganizationType1.Dirty
                || _borrowerOrganizationType2.Dirty
                || _borrowerOrganizedUnderTheLawsOfJurisdictionName1.Dirty
                || _borrowerOrganizedUnderTheLawsOfJurisdictionName2.Dirty
                || _borrowerTaxIdentificationNumberIdentifier1.Dirty
                || _borrowerTaxIdentificationNumberIdentifier2.Dirty
                || _borrowerTrustAmendedDateOrYear1.Dirty
                || _borrowerTrustAmendedDateOrYear2.Dirty
                || _borrowerTrustDateOrYear1.Dirty
                || _borrowerTrustDateOrYear2.Dirty
                || _borrowerUnparsedName1.Dirty
                || _borrowerUnparsedName2.Dirty
                || _brokerAuthorizedRepresentativeTitle.Dirty
                || _brokerCompensationMethod.Dirty
                || _brokerFeeRefundConditions1.Dirty
                || _brokerFeeRefundConditions2.Dirty
                || _brokerFeeRefundConditions3.Dirty
                || _brokerForPlacingLoan.Dirty
                || _brokerInterestRateEffect.Dirty
                || _brokerLenderRelationship.Dirty
                || _brokerLicenseNumberIdentifier.Dirty
                || _brokerNameAsLicensed.Dirty
                || _brokerTaxIdentificationNumberIdentifier.Dirty
                || _brokerWithLenders.Dirty
                || _cashCheckFromBorrower.Dirty
                || _cLClearCloseStatusReceivedByLenderDateTime.Dirty
                || _cLClosingEscrowOrderAcceptedDateTime.Dirty
                || _cLClosingEscrowOrderSentDateTime.Dirty
                || _cLDraftClosingDisclosureReceivedByLenderDateTime.Dirty
                || _cLFinalCDSentDateTime.Dirty
                || _cLFinalTitlePolicyDateTime.Dirty
                || _cLLastFeeQuoteReceivedDateTime.Dirty
                || _cLLastFeeQuoteRequestedDateTime.Dirty
                || _closingDocsLoanProgramType.Dirty
                || _closingProvider.Dirty
                || _closingState.Dirty
                || _cLPayoffsRequestedDateTime.Dirty
                || _cLPrelimCommitmentReceivedByLenderDateTime.Dirty
                || _cLProviderDisburseFundsDateTime.Dirty
                || _cLTitleOrderAcceptedDateTime.Dirty
                || _cLTitleOrderSentDateTime.Dirty
                || _complianceJurisdictionCounty.Dirty
                || _compliancePropertyIdentifiedDate.Dirty
                || _conditionDescription.Dirty
                || _conflictofInterestCheck1.Dirty
                || _conflictofInterestCheck2.Dirty
                || _conflictofInterestCheck3.Dirty
                || _conflictofInterestCheck4.Dirty
                || _conflictofInterestCheck5.Dirty
                || _conflictofInterestCheck6.Dirty
                || _coopApartmentNumber.Dirty
                || _coopAssignmentLeaseDate.Dirty
                || _coopAttorneyInFact.Dirty
                || _coopBuildingName.Dirty
                || _coopCompanyExistsUnderTHeLawsOf.Dirty
                || _coopCompanyName.Dirty
                || _coopProprietaryLeaseDate.Dirty
                || _coopSharesOwned.Dirty
                || _coopStockCertificationNumber.Dirty
                || _coopVacancyPercentNotification.Dirty
                || _customOtherRiderDescription.Dirty
                || _disbursementDate.Dirty
                || _disbursementsToBorrower.Dirty
                || _disclosureAlternateLender.Dirty
                || _disclosureCompanyFunction.Dirty
                || _disclosurePlanCode.Dirty
                || _docReportGUID.Dirty
                || _documentPreparationDate.Dirty
                || _documentSigningDate.Dirty
                || _drawCity.Dirty
                || _drawCounty.Dirty
                || _drawState.Dirty
                || _employeeofMortgageLender.Dirty
                || _expectToAssignSellOrTransferPercent.Dirty
                || _finalVestingDescription.Dirty
                || _firstTransferYear.Dirty
                || _firstTransferYearValue.Dirty
                || _hoursDocumentsNeededPriorToDisbursementCount.Dirty
                || _housingIndicator.Dirty
                || _housingProgramName.Dirty
                || _hUD1FileNumberIdentifier.Dirty
                || _hUD1SettlementAgentUnparsedAddress.Dirty
                || _hUD1SettlementAgentUnparsedName.Dirty
                || _hUD1SettlementDate.Dirty
                || _id.Dirty
                || _includeSafeHaborDisclosure.Dirty
                || _investorCode.Dirty
                || _lastAuditDate.Dirty
                || _lastDocumentOrdered.Dirty
                || _legalAttached.Dirty
                || _lenderAuthorizedRepresentativeTitle.Dirty
                || _lenderBrokerRepresents.Dirty
                || _lienHolderAddress.Dirty
                || _lienHolderAddressCity.Dirty
                || _lienHolderAddressPostalCode.Dirty
                || _lienHolderAddressState.Dirty
                || _lienHolderName.Dirty
                || _loanIsLocked.Dirty
                || _loanOption.Dirty
                || _lockInFeeType.Dirty
                || _mfgHomeAnchored.Dirty
                || _mfgHomeCertificateOfTitleIdentifier.Dirty
                || _mfgHomeCertificateOfTitleType.Dirty
                || _mfgHomeDescription.Dirty
                || _mfgHomeHUDCertificationLabelIdentifier.Dirty
                || _mfgHomeLengthFeetCount.Dirty
                || _mfgHomeMakeIdentifier.Dirty
                || _mfgHomeManufacturer.Dirty
                || _mfgHomeManufacturerAddress.Dirty
                || _mfgHomeManufacturerCity.Dirty
                || _mfgHomeManufacturerPhoneNumber.Dirty
                || _mfgHomeManufacturerPostalCode.Dirty
                || _mfgHomeManufacturerState.Dirty
                || _mfgHomeManufactureYear.Dirty
                || _mfgHomeModelIdentifier.Dirty
                || _mfgHomeNewOrUsed.Dirty
                || _mfgHomeSerialNumberIdentifier.Dirty
                || _mfgHomeWidthFeetCount.Dirty
                || _mineralRightsDescription.Dirty
                || _mortgageType.Dirty
                || _numberBrokerAgreements.Dirty
                || _numberSuccessfulBrokerAgreements.Dirty
                || _officeOfRecordationName.Dirty
                || _onlyOneEntity.Dirty
                || _optionSelectedReason.Dirty
                || _originalPincipalAmountSecured.Dirty
                || _otherOptionDescription.Dirty
                || _parentAffiliatedCoName.Dirty
                || _payToTheOrderOfDescription.Dirty
                || _perDiemCalculationMethodType.Dirty
                || _planCode.Dirty
                || _planCodeDescription.Dirty
                || _planCodeId.Dirty
                || _preliminaryTitleReportDate.Dirty
                || _prepaymentPenaltyDescriptions1.Dirty
                || _prepaymentPenaltyDescriptions2.Dirty
                || _prepaymentPenaltyDescriptions3.Dirty
                || _processingNumberDays.Dirty
                || _programCode.Dirty
                || _programSponsor.Dirty
                || _propertyIsLandTrust.Dirty
                || _propertyTaxMessageDescription.Dirty
                || _rateLockRefundConditions1.Dirty
                || _rateLockRefundConditions2.Dirty
                || _rateLockRefundConditions3.Dirty
                || _recordingJurisdictionName.Dirty
                || _refinanceBalloonMortgageGuarantee.Dirty
                || _refinanceRightOfRescissionExemptFlag.Dirty
                || _renewalExtensionDescription.Dirty
                || _rescissionDate.Dirty
                || _rMLANamePreceding10Years.Dirty
                || _rmlLenderBrokerRepresents.Dirty
                || _secondTransferYear.Dirty
                || _secondTransferYearValue.Dirty
                || _signatureDateFor1003.Dirty
                || _specialFloodHazardAreaIndictor.Dirty
                || _suretyCompanyName.Dirty
                || _syncInterestDateDisbursementDate.Dirty
                || _termiteReportRequiredIndicator.Dirty
                || _textDescription.Dirty
                || _thirdTransferYear.Dirty
                || _thirdTransferYearValue.Dirty
                || _titleReportItemsDescription.Dirty
                || _titleReportRequiredEndorsementsDescription.Dirty
                || _totalDisbursed.Dirty
                || _trust2Beneficiaries.Dirty
                || _weConductBusiness.Dirty
                || _additionalStateDisclosures?.Dirty == true
                || _antiSteeringLoanOptions?.Dirty == true
                || _closingEntities?.Dirty == true
                || _respaHudDetails?.Dirty == true
                || _stateLicenses?.Dirty == true;
            set
            {
                _additionalLienHolderAddress.Dirty = value;
                _additionalLienHolderAddressCity.Dirty = value;
                _additionalLienHolderAddressPostalCode.Dirty = value;
                _additionalLienHolderAddressState.Dirty = value;
                _additionalLienHolderName.Dirty = value;
                _additionalOriginalPincipalAmountSecured.Dirty = value;
                _additionalSigVerbiageType.Dirty = value;
                _affectedByInterest.Dirty = value;
                _alternateLender.Dirty = value;
                _altLenderId.Dirty = value;
                _areAbleToServiceIndicator.Dirty = value;
                _associatedDocumentNumber.Dirty = value;
                _beneficiaries.Dirty = value;
                _borrowerConsentType1.Dirty = value;
                _borrowerConsentType2.Dirty = value;
                _borrowerOrganizationType1.Dirty = value;
                _borrowerOrganizationType2.Dirty = value;
                _borrowerOrganizedUnderTheLawsOfJurisdictionName1.Dirty = value;
                _borrowerOrganizedUnderTheLawsOfJurisdictionName2.Dirty = value;
                _borrowerTaxIdentificationNumberIdentifier1.Dirty = value;
                _borrowerTaxIdentificationNumberIdentifier2.Dirty = value;
                _borrowerTrustAmendedDateOrYear1.Dirty = value;
                _borrowerTrustAmendedDateOrYear2.Dirty = value;
                _borrowerTrustDateOrYear1.Dirty = value;
                _borrowerTrustDateOrYear2.Dirty = value;
                _borrowerUnparsedName1.Dirty = value;
                _borrowerUnparsedName2.Dirty = value;
                _brokerAuthorizedRepresentativeTitle.Dirty = value;
                _brokerCompensationMethod.Dirty = value;
                _brokerFeeRefundConditions1.Dirty = value;
                _brokerFeeRefundConditions2.Dirty = value;
                _brokerFeeRefundConditions3.Dirty = value;
                _brokerForPlacingLoan.Dirty = value;
                _brokerInterestRateEffect.Dirty = value;
                _brokerLenderRelationship.Dirty = value;
                _brokerLicenseNumberIdentifier.Dirty = value;
                _brokerNameAsLicensed.Dirty = value;
                _brokerTaxIdentificationNumberIdentifier.Dirty = value;
                _brokerWithLenders.Dirty = value;
                _cashCheckFromBorrower.Dirty = value;
                _cLClearCloseStatusReceivedByLenderDateTime.Dirty = value;
                _cLClosingEscrowOrderAcceptedDateTime.Dirty = value;
                _cLClosingEscrowOrderSentDateTime.Dirty = value;
                _cLDraftClosingDisclosureReceivedByLenderDateTime.Dirty = value;
                _cLFinalCDSentDateTime.Dirty = value;
                _cLFinalTitlePolicyDateTime.Dirty = value;
                _cLLastFeeQuoteReceivedDateTime.Dirty = value;
                _cLLastFeeQuoteRequestedDateTime.Dirty = value;
                _closingDocsLoanProgramType.Dirty = value;
                _closingProvider.Dirty = value;
                _closingState.Dirty = value;
                _cLPayoffsRequestedDateTime.Dirty = value;
                _cLPrelimCommitmentReceivedByLenderDateTime.Dirty = value;
                _cLProviderDisburseFundsDateTime.Dirty = value;
                _cLTitleOrderAcceptedDateTime.Dirty = value;
                _cLTitleOrderSentDateTime.Dirty = value;
                _complianceJurisdictionCounty.Dirty = value;
                _compliancePropertyIdentifiedDate.Dirty = value;
                _conditionDescription.Dirty = value;
                _conflictofInterestCheck1.Dirty = value;
                _conflictofInterestCheck2.Dirty = value;
                _conflictofInterestCheck3.Dirty = value;
                _conflictofInterestCheck4.Dirty = value;
                _conflictofInterestCheck5.Dirty = value;
                _conflictofInterestCheck6.Dirty = value;
                _coopApartmentNumber.Dirty = value;
                _coopAssignmentLeaseDate.Dirty = value;
                _coopAttorneyInFact.Dirty = value;
                _coopBuildingName.Dirty = value;
                _coopCompanyExistsUnderTHeLawsOf.Dirty = value;
                _coopCompanyName.Dirty = value;
                _coopProprietaryLeaseDate.Dirty = value;
                _coopSharesOwned.Dirty = value;
                _coopStockCertificationNumber.Dirty = value;
                _coopVacancyPercentNotification.Dirty = value;
                _customOtherRiderDescription.Dirty = value;
                _disbursementDate.Dirty = value;
                _disbursementsToBorrower.Dirty = value;
                _disclosureAlternateLender.Dirty = value;
                _disclosureCompanyFunction.Dirty = value;
                _disclosurePlanCode.Dirty = value;
                _docReportGUID.Dirty = value;
                _documentPreparationDate.Dirty = value;
                _documentSigningDate.Dirty = value;
                _drawCity.Dirty = value;
                _drawCounty.Dirty = value;
                _drawState.Dirty = value;
                _employeeofMortgageLender.Dirty = value;
                _expectToAssignSellOrTransferPercent.Dirty = value;
                _finalVestingDescription.Dirty = value;
                _firstTransferYear.Dirty = value;
                _firstTransferYearValue.Dirty = value;
                _hoursDocumentsNeededPriorToDisbursementCount.Dirty = value;
                _housingIndicator.Dirty = value;
                _housingProgramName.Dirty = value;
                _hUD1FileNumberIdentifier.Dirty = value;
                _hUD1SettlementAgentUnparsedAddress.Dirty = value;
                _hUD1SettlementAgentUnparsedName.Dirty = value;
                _hUD1SettlementDate.Dirty = value;
                _id.Dirty = value;
                _includeSafeHaborDisclosure.Dirty = value;
                _investorCode.Dirty = value;
                _lastAuditDate.Dirty = value;
                _lastDocumentOrdered.Dirty = value;
                _legalAttached.Dirty = value;
                _lenderAuthorizedRepresentativeTitle.Dirty = value;
                _lenderBrokerRepresents.Dirty = value;
                _lienHolderAddress.Dirty = value;
                _lienHolderAddressCity.Dirty = value;
                _lienHolderAddressPostalCode.Dirty = value;
                _lienHolderAddressState.Dirty = value;
                _lienHolderName.Dirty = value;
                _loanIsLocked.Dirty = value;
                _loanOption.Dirty = value;
                _lockInFeeType.Dirty = value;
                _mfgHomeAnchored.Dirty = value;
                _mfgHomeCertificateOfTitleIdentifier.Dirty = value;
                _mfgHomeCertificateOfTitleType.Dirty = value;
                _mfgHomeDescription.Dirty = value;
                _mfgHomeHUDCertificationLabelIdentifier.Dirty = value;
                _mfgHomeLengthFeetCount.Dirty = value;
                _mfgHomeMakeIdentifier.Dirty = value;
                _mfgHomeManufacturer.Dirty = value;
                _mfgHomeManufacturerAddress.Dirty = value;
                _mfgHomeManufacturerCity.Dirty = value;
                _mfgHomeManufacturerPhoneNumber.Dirty = value;
                _mfgHomeManufacturerPostalCode.Dirty = value;
                _mfgHomeManufacturerState.Dirty = value;
                _mfgHomeManufactureYear.Dirty = value;
                _mfgHomeModelIdentifier.Dirty = value;
                _mfgHomeNewOrUsed.Dirty = value;
                _mfgHomeSerialNumberIdentifier.Dirty = value;
                _mfgHomeWidthFeetCount.Dirty = value;
                _mineralRightsDescription.Dirty = value;
                _mortgageType.Dirty = value;
                _numberBrokerAgreements.Dirty = value;
                _numberSuccessfulBrokerAgreements.Dirty = value;
                _officeOfRecordationName.Dirty = value;
                _onlyOneEntity.Dirty = value;
                _optionSelectedReason.Dirty = value;
                _originalPincipalAmountSecured.Dirty = value;
                _otherOptionDescription.Dirty = value;
                _parentAffiliatedCoName.Dirty = value;
                _payToTheOrderOfDescription.Dirty = value;
                _perDiemCalculationMethodType.Dirty = value;
                _planCode.Dirty = value;
                _planCodeDescription.Dirty = value;
                _planCodeId.Dirty = value;
                _preliminaryTitleReportDate.Dirty = value;
                _prepaymentPenaltyDescriptions1.Dirty = value;
                _prepaymentPenaltyDescriptions2.Dirty = value;
                _prepaymentPenaltyDescriptions3.Dirty = value;
                _processingNumberDays.Dirty = value;
                _programCode.Dirty = value;
                _programSponsor.Dirty = value;
                _propertyIsLandTrust.Dirty = value;
                _propertyTaxMessageDescription.Dirty = value;
                _rateLockRefundConditions1.Dirty = value;
                _rateLockRefundConditions2.Dirty = value;
                _rateLockRefundConditions3.Dirty = value;
                _recordingJurisdictionName.Dirty = value;
                _refinanceBalloonMortgageGuarantee.Dirty = value;
                _refinanceRightOfRescissionExemptFlag.Dirty = value;
                _renewalExtensionDescription.Dirty = value;
                _rescissionDate.Dirty = value;
                _rMLANamePreceding10Years.Dirty = value;
                _rmlLenderBrokerRepresents.Dirty = value;
                _secondTransferYear.Dirty = value;
                _secondTransferYearValue.Dirty = value;
                _signatureDateFor1003.Dirty = value;
                _specialFloodHazardAreaIndictor.Dirty = value;
                _suretyCompanyName.Dirty = value;
                _syncInterestDateDisbursementDate.Dirty = value;
                _termiteReportRequiredIndicator.Dirty = value;
                _textDescription.Dirty = value;
                _thirdTransferYear.Dirty = value;
                _thirdTransferYearValue.Dirty = value;
                _titleReportItemsDescription.Dirty = value;
                _titleReportRequiredEndorsementsDescription.Dirty = value;
                _totalDisbursed.Dirty = value;
                _trust2Beneficiaries.Dirty = value;
                _weConductBusiness.Dirty = value;
                if (_additionalStateDisclosures != null) _additionalStateDisclosures.Dirty = value;
                if (_antiSteeringLoanOptions != null) _antiSteeringLoanOptions.Dirty = value;
                if (_closingEntities != null) _closingEntities.Dirty = value;
                if (_respaHudDetails != null) _respaHudDetails.Dirty = value;
                if (_stateLicenses != null) _stateLicenses.Dirty = value;
            }
        }
    }
}