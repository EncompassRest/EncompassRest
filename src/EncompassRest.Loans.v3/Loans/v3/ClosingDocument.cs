using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDocument
/// </summary>
public sealed partial class ClosingDocument : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _additionalLienHolderAddress;
    private DirtyValue<string?>? _additionalLienHolderAddressCity;
    private DirtyValue<string?>? _additionalLienHolderAddressPostalCode;
    private DirtyValue<string?>? _additionalLienHolderAddressState;
    private DirtyValue<string?>? _additionalLienHolderName;
    private DirtyValue<decimal?>? _additionalOriginalPrincipalAmountSecured;
    private DirtyValue<StringEnumValue<AdditionalSigVerbiageType>>? _additionalSigVerbiageType;
    private DirtyList<AdditionalStateDisclosure>? _additionalStateDisclosures;
    private DirtyValue<bool?>? _affectedByInterest;
    private DirtyValue<string?>? _alternateLender;
    private DirtyValue<string?>? _altLenderId;
    private DirtyList<AntiSteeringLoanOption>? _antiSteeringLoanOptions;
    private DirtyValue<DateTime?>? _appraisalOrderAccepted;
    private DirtyValue<DateTime?>? _appraisalOrderSent;
    private DirtyValue<DateTime?>? _appraiserSentDataForReview;
    private DirtyValue<DateTime?>? _appraiserSentDocForReview;
    private DirtyValue<string?>? _areAbleToServiceIndicator;
    private DirtyValue<string?>? _associatedDocumentNumber;
    private DirtyValue<string?>? _beneficiaries;
    private DirtyValue<bool?>? _borrowerConsentType1;
    private DirtyValue<bool?>? _borrowerConsentType2;
    private DirtyValue<string?>? _borrowerOrganizationType1;
    private DirtyValue<string?>? _borrowerOrganizationType2;
    private DirtyValue<string?>? _borrowerOrganizedUnderTheLawsOfJurisdictionName1;
    private DirtyValue<string?>? _borrowerOrganizedUnderTheLawsOfJurisdictionName2;
    private DirtyValue<string?>? _borrowerTaxIdentificationNumberIdentifier1;
    private DirtyValue<string?>? _borrowerTaxIdentificationNumberIdentifier2;
    private DirtyValue<DateTime?>? _borrowerTrustAmendedDateOrYear1;
    private DirtyValue<DateTime?>? _borrowerTrustAmendedDateOrYear2;
    private DirtyValue<DateTime?>? _borrowerTrustDateOrYear1;
    private DirtyValue<DateTime?>? _borrowerTrustDateOrYear2;
    private DirtyValue<string?>? _borrowerUnparsedName1;
    private DirtyValue<string?>? _borrowerUnparsedName2;
    private DirtyValue<string?>? _brokerAuthorizedRepresentativeTitle;
    private DirtyValue<string?>? _brokerCompensationMethod;
    private DirtyValue<string?>? _brokerFeeRefundConditions1;
    private DirtyValue<string?>? _brokerFeeRefundConditions2;
    private DirtyValue<string?>? _brokerFeeRefundConditions3;
    private DirtyValue<StringEnumValue<BrokerForPlacingLoan>>? _brokerForPlacingLoan;
    private DirtyValue<string?>? _brokerInterestRateEffect;
    private DirtyValue<string?>? _brokerLenderRelationship;
    private DirtyValue<string?>? _brokerLicenseNumberIdentifier;
    private DirtyValue<string?>? _brokerNameAsLicensed;
    private DirtyValue<string?>? _brokerTaxIdentificationNumberIdentifier;
    private DirtyValue<StringEnumValue<BrokerWithLenders>>? _brokerWithLenders;
    private DirtyValue<decimal?>? _cashCheckFromBorrower;
    private DirtyValue<DateTime?>? _clClearCloseStatusReceivedByLenderDateTime;
    private DirtyValue<DateTime?>? _clClosingEscrowOrderAcceptedDateTime;
    private DirtyValue<DateTime?>? _clClosingEscrowOrderSentDateTime;
    private DirtyValue<DateTime?>? _clDraftClosingDisclosureReceivedByLenderDateTime;
    private DirtyValue<DateTime?>? _clFinalCdSentDateTime;
    private DirtyValue<DateTime?>? _clFinalTitlePolicyDateTime;
    private DirtyValue<DateTime?>? _clLastFeeQuoteReceivedDateTime;
    private DirtyValue<DateTime?>? _clLastFeeQuoteRequestedDateTime;
    private DirtyValue<StringEnumValue<DocsLoanProgramType>>? _closingDocsLoanProgramType;
    private DirtyList<ClosingEntity>? _closingEntities;
    private DirtyValue<string?>? _closingProvider;
    private DirtyValue<string?>? _closingState;
    private DirtyValue<DateTime?>? _clPayoffsRequestedDateTime;
    private DirtyValue<DateTime?>? _clPrelimCommitmentReceivedByLenderDateTime;
    private DirtyValue<DateTime?>? _clProviderDisburseFundsDateTime;
    private DirtyValue<DateTime?>? _clTitleOrderAcceptedDateTime;
    private DirtyValue<DateTime?>? _clTitleOrderSentDateTime;
    private DirtyValue<string?>? _complianceJurisdictionCounty;
    private DirtyValue<DateTime?>? _compliancePropertyIdentifiedDate;
    private DirtyValue<string?>? _conditionDescription;
    private DirtyValue<bool?>? _conflictofInterestCheck1;
    private DirtyValue<bool?>? _conflictofInterestCheck2;
    private DirtyValue<bool?>? _conflictofInterestCheck3;
    private DirtyValue<bool?>? _conflictofInterestCheck4;
    private DirtyValue<bool?>? _conflictofInterestCheck5;
    private DirtyValue<bool?>? _conflictofInterestCheck6;
    private DirtyValue<string?>? _coopApartmentNumber;
    private DirtyValue<DateTime?>? _coopAssignmentLeaseDate;
    private DirtyValue<string?>? _coopAttorneyInFact;
    private DirtyValue<string?>? _coopBuildingName;
    private DirtyValue<string?>? _coopCompanyExistsUnderTheLawsOf;
    private DirtyValue<string?>? _coopCompanyName;
    private DirtyValue<DateTime?>? _coopProprietaryLeaseDate;
    private DirtyValue<decimal?>? _coopSharesOwned;
    private DirtyValue<string?>? _coopStockCertificationNumber;
    private DirtyValue<decimal?>? _coopVacancyPercentNotification;
    private DirtyValue<string?>? _customOtherRiderDescription;
    private DirtyValue<DateTime?>? _disbursementDate;
    private DirtyValue<decimal?>? _disbursementsToBorrower;
    private DirtyValue<string?>? _disclosureAlternateLender;
    private DirtyValue<string?>? _disclosureCompanyFunction;
    private DirtyValue<string?>? _disclosurePlanCode;
    private DirtyValue<DateTime?>? _docOrMessageByLenderDateTime;
    private DirtyValue<string?>? _docReportGuid;
    private DirtyValue<DateTime?>? _documentPreparationDate;
    private DirtyValue<DateTime?>? _documentSigningDate;
    private DirtyValue<string?>? _drawCity;
    private DirtyValue<string?>? _drawCounty;
    private DirtyValue<string?>? _drawState;
    private DirtyValue<StringEnumValue<eCloseClosingType>>? _eCloseClosingType;
    private DirtyValue<StringEnumValue<YNOrOther>>? _employeeofMortgageLender;
    private DirtyValue<string?>? _expectToAssignSellOrTransferPercent;
    private DirtyValue<string?>? _finalVestingDescription;
    private DirtyValue<string?>? _firstTransferYear;
    private DirtyValue<decimal?>? _firstTransferYearValue;
    private DirtyValue<string?>? _hoursDocumentsNeededPriorToDisbursementCount;
    private DirtyValue<bool?>? _housingIndicator;
    private DirtyValue<string?>? _housingProgramName;
    private DirtyValue<string?>? _hud1FileNumberIdentifier;
    private DirtyValue<string?>? _hud1SettlementAgentUnparsedAddress;
    private DirtyValue<string?>? _hud1SettlementAgentUnparsedName;
    private DirtyValue<DateTime?>? _hud1SettlementDate;
    private DirtyValue<decimal?>? _includeSafeHarborDisclosure;
    private DirtyValue<string?>? _investorCode;
    private DirtyValue<DateTime?>? _lastAuditDate;
    private DirtyValue<string?>? _lastDocumentOrdered;
    private DirtyValue<bool?>? _legalAttached;
    private DirtyValue<string?>? _lenderAuthorizedRepresentativeTitle;
    private DirtyValue<string?>? _lenderBrokerRepresents;
    private DirtyValue<string?>? _lienHolderAddress;
    private DirtyValue<string?>? _lienHolderAddressCity;
    private DirtyValue<string?>? _lienHolderAddressPostalCode;
    private DirtyValue<string?>? _lienHolderAddressState;
    private DirtyValue<string?>? _lienHolderName;
    private DirtyValue<bool?>? _loanIsLocked;
    private DirtyValue<StringEnumValue<LoanOption>>? _loanOption;
    private DirtyValue<StringEnumValue<LockInFeeType>>? _lockInFeeType;
    private DirtyValue<StringEnumValue<MfgHomeAnchored>>? _mfgHomeAnchored;
    private DirtyValue<string?>? _mfgHomeCertificateOfTitleIdentifier;
    private DirtyValue<StringEnumValue<MfgHomeCertificateOfTitleType>>? _mfgHomeCertificateOfTitleType;
    private DirtyValue<string?>? _mfgHomeDescription;
    private DirtyValue<string?>? _mfgHomeHudCertificationLabelIdentifier;
    private DirtyValue<int?>? _mfgHomeLengthFeetCount;
    private DirtyValue<string?>? _mfgHomeMakeIdentifier;
    private DirtyValue<string?>? _mfgHomeManufacturer;
    private DirtyValue<string?>? _mfgHomeManufacturerAddress;
    private DirtyValue<string?>? _mfgHomeManufacturerCity;
    private DirtyValue<string?>? _mfgHomeManufacturerPhoneNumber;
    private DirtyValue<string?>? _mfgHomeManufacturerPostalCode;
    private DirtyValue<string?>? _mfgHomeManufacturerState;
    private DirtyValue<int?>? _mfgHomeManufactureYear;
    private DirtyValue<string?>? _mfgHomeModelIdentifier;
    private DirtyValue<StringEnumValue<MfgHomeNewOrUsed>>? _mfgHomeNewOrUsed;
    private DirtyValue<string?>? _mfgHomeSerialNumberIdentifier;
    private DirtyValue<int?>? _mfgHomeWidthFeetCount;
    private DirtyValue<string?>? _mineralRightsDescription;
    private DirtyValue<StringEnumValue<MortgageType>>? _mortgageType;
    private DirtyValue<int?>? _numberBrokerAgreements;
    private DirtyValue<int?>? _numberSuccessfulBrokerAgreements;
    private DirtyValue<string?>? _officeOfRecordationName;
    private DirtyValue<bool?>? _onlyOneEntity;
    private DirtyValue<string?>? _optionSelectedReason;
    private DirtyValue<decimal?>? _originalPincipalAmountSecured;
    private DirtyValue<string?>? _otherOptionDescription;
    private DirtyValue<string?>? _parentAffiliatedCoName;
    private DirtyValue<string?>? _payToTheOrderOfDescription;
    private DirtyValue<StringEnumValue<PerDiemCalculationMethodType>>? _perDiemCalculationMethodType;
    private DirtyValue<string?>? _planCode;
    private DirtyValue<string?>? _planCodeDescription;
    private DirtyValue<string?>? _planCodeId;
    private DirtyValue<DateTime?>? _preliminaryTitleReportDate;
    private DirtyValue<string?>? _prepaymentPenaltyDescriptions1;
    private DirtyValue<string?>? _prepaymentPenaltyDescriptions2;
    private DirtyValue<string?>? _prepaymentPenaltyDescriptions3;
    private DirtyValue<bool?>? _printTrustNameIndicator;
    private DirtyValue<int?>? _processingNumberDays;
    private DirtyValue<string?>? _programCode;
    private DirtyValue<string?>? _programSponsor;
    private DirtyValue<bool?>? _propertyIsLandTrust;
    private DirtyValue<string?>? _propertyTaxMessageDescription;
    private DirtyValue<string?>? _rateLockRefundConditions1;
    private DirtyValue<string?>? _rateLockRefundConditions2;
    private DirtyValue<string?>? _rateLockRefundConditions3;
    private DirtyValue<string?>? _recordingJurisdictionName;
    private DirtyValue<bool?>? _refinanceBalloonMortgageGuarantee;
    private DirtyValue<bool?>? _refinanceRightOfRescissionExemptFlag;
    private DirtyValue<string?>? _renewalExtensionDescription;
    private DirtyValue<DateTime?>? _rescissionDate;
    private DirtyList<RespaHudDetail>? _respaHudDetails;
    private DirtyValue<string?>? _rmlaNamePreceding10Years;
    private DirtyValue<string?>? _rmlLenderBrokerRepresents;
    private DirtyValue<string?>? _secondTransferYear;
    private DirtyValue<decimal?>? _secondTransferYearValue;
    private DirtyValue<DateTime?>? _signatureDateFor1003;
    private DirtyValue<StringEnumValue<FloodZone>>? _specialFloodHazardAreaIndictor;
    private DirtyList<StateLicense>? _stateLicenses;
    private DirtyValue<string?>? _suretyCompanyName;
    private DirtyValue<bool?>? _syncInterestDateDisbursementDate;
    private DirtyValue<StringEnumValue<YOrN>>? _termiteReportRequiredIndicator;
    private DirtyValue<string?>? _textDescription;
    private DirtyValue<string?>? _thirdTransferYear;
    private DirtyValue<decimal?>? _thirdTransferYearValue;
    private DirtyValue<DateTime?>? _titleClosingAgentSentDataForReview;
    private DirtyValue<DateTime?>? _titleClosingAgentSentDocForReview;
    private DirtyValue<string?>? _titleReportItemsDescription;
    private DirtyValue<string?>? _titleReportRequiredEndorsementsDescription;
    private DirtyValue<decimal?>? _totalDisbursed;
    private DirtyValue<string?>? _trust2Beneficiaries;
    private DirtyValue<StringEnumValue<WeConductBusiness>>? _weConductBusiness;

    /// <summary>
    /// Closing Docs Mfg Home Address of Additional Lien Holder [3651]
    /// </summary>
    public string? AdditionalLienHolderAddress { get => _additionalLienHolderAddress; set => SetField(ref _additionalLienHolderAddress, value); }

    /// <summary>
    /// Closing Docs Mfg Home Address City of Additional Lien Holder [3652]
    /// </summary>
    public string? AdditionalLienHolderAddressCity { get => _additionalLienHolderAddressCity; set => SetField(ref _additionalLienHolderAddressCity, value); }

    /// <summary>
    /// Closing Docs Mfg Home Postal Code of Additional Lien Holder [3654]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? AdditionalLienHolderAddressPostalCode { get => _additionalLienHolderAddressPostalCode; set => SetField(ref _additionalLienHolderAddressPostalCode, value); }

    /// <summary>
    /// Closing Docs Mfg Home Address State of Additional Lien Holder [3653]
    /// </summary>
    public string? AdditionalLienHolderAddressState { get => _additionalLienHolderAddressState; set => SetField(ref _additionalLienHolderAddressState, value); }

    /// <summary>
    /// Closing Docs Mfg Home Name of Additional Lien Holder [3650]
    /// </summary>
    public string? AdditionalLienHolderName { get => _additionalLienHolderName; set => SetField(ref _additionalLienHolderName, value); }

    /// <summary>
    /// Closing Docs Mfg Home Additional Original Pincipal Amount Secured [3655]
    /// </summary>
    public decimal? AdditionalOriginalPrincipalAmountSecured { get => _additionalOriginalPrincipalAmountSecured; set => SetField(ref _additionalOriginalPrincipalAmountSecured, value); }

    /// <summary>
    /// Closing Documents - Additional Signature Verbiage Type [PlanCode.AdtlSgVbgTyp]
    /// </summary>
    public StringEnumValue<AdditionalSigVerbiageType> AdditionalSigVerbiageType { get => _additionalSigVerbiageType; set => SetField(ref _additionalSigVerbiageType, value); }

    /// <summary>
    /// ClosingDocumentContract AdditionalStateDisclosures
    /// </summary>
    [AllowNull]
    public IList<AdditionalStateDisclosure> AdditionalStateDisclosures { get => GetField(ref _additionalStateDisclosures); set => SetField(ref _additionalStateDisclosures, value); }

    /// <summary>
    /// State Disc - Broker Comp Affected by Interest [DISCLOSURE.X210]
    /// </summary>
    public bool? AffectedByInterest { get => _affectedByInterest; set => SetField(ref _affectedByInterest, value); }

    /// <summary>
    /// REGZ Loan Info Alternate Lender [1882]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AlternateLender { get => _alternateLender; set => SetField(ref _alternateLender, value); }

    /// <summary>
    /// Encompass Docs Alt Lender ID [AltLender.ID]
    /// </summary>
    public string? AltLenderId { get => _altLenderId; set => SetField(ref _altLenderId, value); }

    /// <summary>
    /// ClosingDocumentContract AntiSteeringLoanOptions
    /// </summary>
    [AllowNull]
    public IList<AntiSteeringLoanOption> AntiSteeringLoanOptions { get => GetField(ref _antiSteeringLoanOptions); set => SetField(ref _antiSteeringLoanOptions, value); }

    /// <summary>
    /// Appraisal Order Accepted [AP.WF.EVNT.APODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderAccepted { get => _appraisalOrderAccepted; set => SetField(ref _appraisalOrderAccepted, value); }

    /// <summary>
    /// Appraisal Order Sent [AP.WF.EVNT.APODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraisalOrderSent { get => _appraisalOrderSent; set => SetField(ref _appraisalOrderSent, value); }

    /// <summary>
    /// Appraiser Sent Data for Review [AP.WF.EVNT.DATAREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraiserSentDataForReview { get => _appraiserSentDataForReview; set => SetField(ref _appraiserSentDataForReview, value); }

    /// <summary>
    /// Appraiser Sent Doc(s) for Review [AP.WF.EVNT.DOCREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? AppraiserSentDocForReview { get => _appraiserSentDocForReview; set => SetField(ref _appraiserSentDocForReview, value); }

    /// <summary>
    /// Closing Docs RESPA Able to Service [1926]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AreAbleToServiceIndicator { get => _areAbleToServiceIndicator; set => SetField(ref _areAbleToServiceIndicator, value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Number [1934]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AssociatedDocumentNumber { get => _associatedDocumentNumber; set => SetField(ref _associatedDocumentNumber, value); }

    /// <summary>
    /// Borrower Vesting Borr Beneficiaries [2970]
    /// </summary>
    public string? Beneficiaries { get => _beneficiaries; set => SetField(ref _beneficiaries, value); }

    /// <summary>
    /// State Disc - Borrower Consent Type [DISCLOSURE.X199]
    /// </summary>
    public bool? BorrowerConsentType1 { get => _borrowerConsentType1; set => SetField(ref _borrowerConsentType1, value); }

    /// <summary>
    /// State Disc - Borrower Consent Type 2 [DISCLOSURE.X220]
    /// </summary>
    public bool? BorrowerConsentType2 { get => _borrowerConsentType2; set => SetField(ref _borrowerConsentType2, value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org Type [1861]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerOrganizationType1 { get => _borrowerOrganizationType1; set => SetField(ref _borrowerOrganizationType1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Type [Vesting.Trst2Type]
    /// </summary>
    public string? BorrowerOrganizationType2 { get => _borrowerOrganizationType2; set => SetField(ref _borrowerOrganizationType2, value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org State [1860]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName1; set => SetField(ref _borrowerOrganizedUnderTheLawsOfJurisdictionName1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 State [Vesting.Trst2State]
    /// </summary>
    public string? BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName2; set => SetField(ref _borrowerOrganizedUnderTheLawsOfJurisdictionName2, value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Org Tax ID [1862]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerTaxIdentificationNumberIdentifier1 { get => _borrowerTaxIdentificationNumberIdentifier1; set => SetField(ref _borrowerTaxIdentificationNumberIdentifier1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Tax ID [Vesting.Trst2TaxID]
    /// </summary>
    public string? BorrowerTaxIdentificationNumberIdentifier2 { get => _borrowerTaxIdentificationNumberIdentifier2; set => SetField(ref _borrowerTaxIdentificationNumberIdentifier2, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 1 Amended Date or Year [Vesting.Trst1AmdDate]
    /// </summary>
    public DateTime? BorrowerTrustAmendedDateOrYear1 { get => _borrowerTrustAmendedDateOrYear1; set => SetField(ref _borrowerTrustAmendedDateOrYear1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Amended Date or Year [Vesting.Trst2AmdDate]
    /// </summary>
    public DateTime? BorrowerTrustAmendedDateOrYear2 { get => _borrowerTrustAmendedDateOrYear2; set => SetField(ref _borrowerTrustAmendedDateOrYear2, value); }

    /// <summary>
    /// Closing Docs Borr 1 Org Trust Date or Year [2554]
    /// </summary>
    public DateTime? BorrowerTrustDateOrYear1 { get => _borrowerTrustDateOrYear1; set => SetField(ref _borrowerTrustDateOrYear1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Date or Year [Vesting.Trst2Date]
    /// </summary>
    public DateTime? BorrowerTrustDateOrYear2 { get => _borrowerTrustDateOrYear2; set => SetField(ref _borrowerTrustDateOrYear2, value); }

    /// <summary>
    /// Borrower Vesting Borr 1 Corp/Trust Name [1859]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BorrowerUnparsedName1 { get => _borrowerUnparsedName1; set => SetField(ref _borrowerUnparsedName1, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Name [Vesting.Trst2Name]
    /// </summary>
    public string? BorrowerUnparsedName2 { get => _borrowerUnparsedName2; set => SetField(ref _borrowerUnparsedName2, value); }

    /// <summary>
    /// State Disc - Broker Rep Title [DISCLOSURE.X188]
    /// </summary>
    public string? BrokerAuthorizedRepresentativeTitle { get => _brokerAuthorizedRepresentativeTitle; set => SetField(ref _brokerAuthorizedRepresentativeTitle, value); }

    /// <summary>
    /// State Disc - Broker Method of Compensation [DISCLOSURE.X211]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerCompensationMethod { get => _brokerCompensationMethod; set => SetField(ref _brokerCompensationMethod, value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 1 [DISCLOSURE.X195]
    /// </summary>
    public string? BrokerFeeRefundConditions1 { get => _brokerFeeRefundConditions1; set => SetField(ref _brokerFeeRefundConditions1, value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 2 [DISCLOSURE.X196]
    /// </summary>
    public string? BrokerFeeRefundConditions2 { get => _brokerFeeRefundConditions2; set => SetField(ref _brokerFeeRefundConditions2, value); }

    /// <summary>
    /// State Disc - Broker Fee Refund Descr 3 [DISCLOSURE.X197]
    /// </summary>
    public string? BrokerFeeRefundConditions3 { get => _brokerFeeRefundConditions3; set => SetField(ref _brokerFeeRefundConditions3, value); }

    /// <summary>
    /// State Disc - Broker Consideration for Placing Loan [DISCLOSURE.X209]
    /// </summary>
    public StringEnumValue<BrokerForPlacingLoan> BrokerForPlacingLoan { get => _brokerForPlacingLoan; set => SetField(ref _brokerForPlacingLoan, value); }

    /// <summary>
    /// State Disc - Effect of Int Rate on Broker Comp [DISCLOSURE.X212]
    /// </summary>
    public string? BrokerInterestRateEffect { get => _brokerInterestRateEffect; set => SetField(ref _brokerInterestRateEffect, value); }

    /// <summary>
    /// State Disc - Broker Relationship with Lender [DISCLOSURE.X213]
    /// </summary>
    public string? BrokerLenderRelationship { get => _brokerLenderRelationship; set => SetField(ref _brokerLenderRelationship, value); }

    /// <summary>
    /// Closing Docs Mort Broker Lic Number [1935]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerLicenseNumberIdentifier { get => _brokerLicenseNumberIdentifier; set => SetField(ref _brokerLicenseNumberIdentifier, value); }

    /// <summary>
    /// State Disc - Broker Name As Licensed [DISCLOSURE.X202]
    /// </summary>
    public string? BrokerNameAsLicensed { get => _brokerNameAsLicensed; set => SetField(ref _brokerNameAsLicensed, value); }

    /// <summary>
    /// Closing Docs Mort Broker Tax ID Number [1937]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? BrokerTaxIdentificationNumberIdentifier { get => _brokerTaxIdentificationNumberIdentifier; set => SetField(ref _brokerTaxIdentificationNumberIdentifier, value); }

    /// <summary>
    /// State Disc - Broker Places Loans W/Lender(s) [DISCLOSURE.X200]
    /// </summary>
    public StringEnumValue<BrokerWithLenders> BrokerWithLenders { get => _brokerWithLenders; set => SetField(ref _brokerWithLenders, value); }

    /// <summary>
    /// HUD1 HUD1A - Plus Cash/Ck from Borr [HUD1A.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CashCheckFromBorrower { get => _cashCheckFromBorrower; set => SetField(ref _cashCheckFromBorrower, value); }

    /// <summary>
    /// Title Closing Disclosure - Clear to Close Status Received by Lender Date Time [CL.WF.EVNT.CLRTOCLOS]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClClearCloseStatusReceivedByLenderDateTime { get => _clClearCloseStatusReceivedByLenderDateTime; set => SetField(ref _clClearCloseStatusReceivedByLenderDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Closing + Escrow Order Accepted Date Time [CL.WF.EVNT.CODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClClosingEscrowOrderAcceptedDateTime { get => _clClosingEscrowOrderAcceptedDateTime; set => SetField(ref _clClosingEscrowOrderAcceptedDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Closing + Escrow Order Sent Date Time [CL.WF.EVNT.CODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClClosingEscrowOrderSentDateTime { get => _clClosingEscrowOrderSentDateTime; set => SetField(ref _clClosingEscrowOrderSentDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Draft Closing Disclosure Received by the Lender Date Time [CL.WF.EVNT.INIDSCLO]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClDraftClosingDisclosureReceivedByLenderDateTime { get => _clDraftClosingDisclosureReceivedByLenderDateTime; set => SetField(ref _clDraftClosingDisclosureReceivedByLenderDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Final CD Sent Date Time [CL.WF.EVNT.FINLCDSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClFinalCdSentDateTime { get => _clFinalCdSentDateTime; set => SetField(ref _clFinalCdSentDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Final Title Policy Date Time [CL.WF.EVNT.FINLTITLPLCY]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClFinalTitlePolicyDateTime { get => _clFinalTitlePolicyDateTime; set => SetField(ref _clFinalTitlePolicyDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Last Fee Quote Received Date Time [CL.WF.EVNT.ODRQOTEACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClLastFeeQuoteReceivedDateTime { get => _clLastFeeQuoteReceivedDateTime; set => SetField(ref _clLastFeeQuoteReceivedDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Last Fee Quote Requested Date Time [CL.WF.EVNT.ODRQUOTE]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClLastFeeQuoteRequestedDateTime { get => _clLastFeeQuoteRequestedDateTime; set => SetField(ref _clLastFeeQuoteRequestedDateTime, value); }

    /// <summary>
    /// Closing Documents - Plan Code Type [PlanCode.LoanProgTyp]
    /// </summary>
    public StringEnumValue<DocsLoanProgramType> ClosingDocsLoanProgramType { get => _closingDocsLoanProgramType; set => SetField(ref _closingDocsLoanProgramType, value); }

    /// <summary>
    /// ClosingDocumentContract ClosingEntities
    /// </summary>
    [AllowNull]
    public IList<ClosingEntity> ClosingEntities { get => GetField(ref _closingEntities); set => SetField(ref _closingEntities, value); }

    /// <summary>
    /// Closing Loan Info Plan Closing Provider [2399]
    /// </summary>
    public string? ClosingProvider { get => _closingProvider; set => SetField(ref _closingProvider, value); }

    /// <summary>
    /// Closing State [3542]
    /// </summary>
    public string? ClosingState { get => _closingState; set => SetField(ref _closingState, value); }

    /// <summary>
    /// Title Closing Disclosure - Payoffs Requested Date Time [CL.WF.EVNT.ODRPAYOFF]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClPayoffsRequestedDateTime { get => _clPayoffsRequestedDateTime; set => SetField(ref _clPayoffsRequestedDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Prelim / Commitment Received by the Lender Date Time [CL.WF.EVNT.PRELIMRECV]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClPrelimCommitmentReceivedByLenderDateTime { get => _clPrelimCommitmentReceivedByLenderDateTime; set => SetField(ref _clPrelimCommitmentReceivedByLenderDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Provider Disburse Funds [CL.WF.EVNT.FNDDISB]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClProviderDisburseFundsDateTime { get => _clProviderDisburseFundsDateTime; set => SetField(ref _clProviderDisburseFundsDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Title Order Accepted Date Time [CL.WF.EVNT.TODRACCP]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClTitleOrderAcceptedDateTime { get => _clTitleOrderAcceptedDateTime; set => SetField(ref _clTitleOrderAcceptedDateTime, value); }

    /// <summary>
    /// Title Closing Disclosure - Title Order Sent Date Time [CL.WF.EVNT.TODRSENT]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? ClTitleOrderSentDateTime { get => _clTitleOrderSentDateTime; set => SetField(ref _clTitleOrderSentDateTime, value); }

    /// <summary>
    /// Compliance Jurisdiction Type [2550]
    /// </summary>
    public string? ComplianceJurisdictionCounty { get => _complianceJurisdictionCounty; set => SetField(ref _complianceJurisdictionCounty, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Property Identified Date [2851]
    /// </summary>
    public DateTime? CompliancePropertyIdentifiedDate { get => _compliancePropertyIdentifiedDate; set => SetField(ref _compliancePropertyIdentifiedDate, value); }

    /// <summary>
    /// Closing Docs Instructions Condition Descrip [1952]
    /// </summary>
    public string? ConditionDescription { get => _conditionDescription; set => SetField(ref _conditionDescription, value); }

    /// <summary>
    /// State Disc - Licensee Provides Services [DISCLOSURE.X214]
    /// </summary>
    public bool? ConflictofInterestCheck1 { get => _conflictofInterestCheck1; set => SetField(ref _conflictofInterestCheck1, value); }

    /// <summary>
    /// State Disc - Licensee/Relative Controls 10% Equity [DISCLOSURE.X215]
    /// </summary>
    public bool? ConflictofInterestCheck2 { get => _conflictofInterestCheck2; set => SetField(ref _conflictofInterestCheck2, value); }

    /// <summary>
    /// State Disc - Provider Controls 10% Equity [DISCLOSURE.X216]
    /// </summary>
    public bool? ConflictofInterestCheck3 { get => _conflictofInterestCheck3; set => SetField(ref _conflictofInterestCheck3, value); }

    /// <summary>
    /// State Disc - Holding Company Controls 10% Equity [DISCLOSURE.X217]
    /// </summary>
    public bool? ConflictofInterestCheck4 { get => _conflictofInterestCheck4; set => SetField(ref _conflictofInterestCheck4, value); }

    /// <summary>
    /// State Disc - Same Officer/Director for Licensee/Prvdr [DISCLOSURE.X218]
    /// </summary>
    public bool? ConflictofInterestCheck5 { get => _conflictofInterestCheck5; set => SetField(ref _conflictofInterestCheck5, value); }

    /// <summary>
    /// State Disc - Licensee Is Officer/Director for Prvdr [DISCLOSURE.X219]
    /// </summary>
    public bool? ConflictofInterestCheck6 { get => _conflictofInterestCheck6; set => SetField(ref _conflictofInterestCheck6, value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Apartment Number [2644]
    /// </summary>
    public string? CoopApartmentNumber { get => _coopApartmentNumber; set => SetField(ref _coopApartmentNumber, value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Assignment Lease date [2642]
    /// </summary>
    public DateTime? CoopAssignmentLeaseDate { get => _coopAssignmentLeaseDate; set => SetField(ref _coopAssignmentLeaseDate, value); }

    /// <summary>
    /// Closing Docs Coop Loan Attorney in Fact [2640]
    /// </summary>
    public string? CoopAttorneyInFact { get => _coopAttorneyInFact; set => SetField(ref _coopAttorneyInFact, value); }

    /// <summary>
    /// Closing Docs Coop Loan Building Name [2639]
    /// </summary>
    public string? CoopBuildingName { get => _coopBuildingName; set => SetField(ref _coopBuildingName, value); }

    /// <summary>
    /// Closing Docs Coop Loan Company Exists Under The Laws Of [2638]
    /// </summary>
    public string? CoopCompanyExistsUnderTheLawsOf { get => _coopCompanyExistsUnderTheLawsOf; set => SetField(ref _coopCompanyExistsUnderTheLawsOf, value); }

    /// <summary>
    /// Closing Docs Coop Loan Company Name [2636]
    /// </summary>
    public string? CoopCompanyName { get => _coopCompanyName; set => SetField(ref _coopCompanyName, value); }

    /// <summary>
    /// Closing Docs Coop Loan Proprietary Lease Date [2641]
    /// </summary>
    public DateTime? CoopProprietaryLeaseDate { get => _coopProprietaryLeaseDate; set => SetField(ref _coopProprietaryLeaseDate, value); }

    /// <summary>
    /// Closing Docs Coop Loan Shares Owned [2635]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CoopSharesOwned { get => _coopSharesOwned; set => SetField(ref _coopSharesOwned, value); }

    /// <summary>
    /// Closing Docs Coop Loan Coop Stock Certification Number [2643]
    /// </summary>
    public string? CoopStockCertificationNumber { get => _coopStockCertificationNumber; set => SetField(ref _coopStockCertificationNumber, value); }

    /// <summary>
    /// Closing Docs Coop Loan Vacancy Percent Notification [2637]
    /// </summary>
    public decimal? CoopVacancyPercentNotification { get => _coopVacancyPercentNotification; set => SetField(ref _coopVacancyPercentNotification, value); }

    /// <summary>
    /// Custom Other Rider Description [4055]
    /// </summary>
    public string? CustomOtherRiderDescription { get => _customOtherRiderDescription; set => SetField(ref _customOtherRiderDescription, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disbursement Date [2553]
    /// </summary>
    public DateTime? DisbursementDate { get => _disbursementDate; set => SetField(ref _disbursementDate, value); }

    /// <summary>
    /// HUD1 HUD1A - Equals Disburs to Borr [HUD1A.X32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? DisbursementsToBorrower { get => _disbursementsToBorrower; set => SetField(ref _disbursementsToBorrower, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Alt Lender [DISCLOSUREALTLENDER]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureAlternateLender { get => _disclosureAlternateLender; set => SetField(ref _disclosureAlternateLender, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Company Function [DISCLOSURECOFUNCTION]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosureCompanyFunction { get => _disclosureCompanyFunction; set => SetField(ref _disclosureCompanyFunction, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Disclosure Plan Code [DISCLOSUREPLANCODE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DisclosurePlanCode { get => _disclosurePlanCode; set => SetField(ref _disclosurePlanCode, value); }

    /// <summary>
    /// Title Closing Disclosure - Unspecified Event Occurred [CL.WF.EVNT.LENDOTHER]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DocOrMessageByLenderDateTime { get => _docOrMessageByLenderDateTime; set => SetField(ref _docOrMessageByLenderDateTime, value); }

    /// <summary>
    /// REGZ Loan Info DOC Report GUID [3900]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DocReportGuid { get => _docReportGuid; set => SetField(ref _docReportGuid, value); }

    /// <summary>
    /// REGZ Loan Info Document Date [L770]
    /// </summary>
    public DateTime? DocumentPreparationDate { get => _documentPreparationDate; set => SetField(ref _documentPreparationDate, value); }

    /// <summary>
    /// REGZ Loan Info Document Signing Date [1887]
    /// </summary>
    public DateTime? DocumentSigningDate { get => _documentSigningDate; set => SetField(ref _documentSigningDate, value); }

    /// <summary>
    /// Closing Draw City [L827]
    /// </summary>
    public string? DrawCity { get => _drawCity; set => SetField(ref _drawCity, value); }

    /// <summary>
    /// Closing County [1949]
    /// </summary>
    public string? DrawCounty { get => _drawCounty; set => SetField(ref _drawCounty, value); }

    /// <summary>
    /// Closing Draw State [L812]
    /// </summary>
    public string? DrawState { get => _drawState; set => SetField(ref _drawState, value); }

    /// <summary>
    /// eClose Closing Type [4689]
    /// </summary>
    public StringEnumValue<eCloseClosingType> ECloseClosingType { get => _eCloseClosingType; set => SetField(ref _eCloseClosingType, value); }

    /// <summary>
    /// State Disc - Broker Is Employee of Mtg Lender [DISCLOSURE.X208]
    /// </summary>
    public StringEnumValue<YNOrOther> EmployeeofMortgageLender { get => _employeeofMortgageLender; set => SetField(ref _employeeofMortgageLender, value); }

    /// <summary>
    /// Closing Docs RESPA Expect to Assign, Sell, Service Percent [1927]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ExpectToAssignSellOrTransferPercent { get => _expectToAssignSellOrTransferPercent; set => SetField(ref _expectToAssignSellOrTransferPercent, value); }

    /// <summary>
    /// Borrower Vesting Borr Final Vesting to Read [1867]
    /// </summary>
    public string? FinalVestingDescription { get => _finalVestingDescription; set => SetField(ref _finalVestingDescription, value); }

    /// <summary>
    /// Closing Docs RESPA First Transfer Year [1928]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? FirstTransferYear { get => _firstTransferYear; set => SetField(ref _firstTransferYear, value); }

    /// <summary>
    /// Closing Docs RESPA First Transfer Year Value [1929]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? FirstTransferYearValue { get => _firstTransferYearValue; set => SetField(ref _firstTransferYearValue, value); }

    /// <summary>
    /// Closing Hrs Docs needed prior to disbrsmnt [1950]
    /// </summary>
    public string? HoursDocumentsNeededPriorToDisbursementCount { get => _hoursDocumentsNeededPriorToDisbursementCount; set => SetField(ref _hoursDocumentsNeededPriorToDisbursementCount, value); }

    /// <summary>
    /// Closing Docs for Ellie Mae Network Housing Indicator [HOUSINGPROGRAM.X1]
    /// </summary>
    public bool? HousingIndicator { get => _housingIndicator; set => SetField(ref _housingIndicator, value); }

    /// <summary>
    /// Closing Docs for Ellie Mae Network Housing Program Name [HOUSINGPROGRAM.X2]
    /// </summary>
    public string? HousingProgramName { get => _housingProgramName; set => SetField(ref _housingProgramName, value); }

    /// <summary>
    /// HUD1 File # [L72]
    /// </summary>
    public string? Hud1FileNumberIdentifier { get => _hud1FileNumberIdentifier; set => SetField(ref _hud1FileNumberIdentifier, value); }

    /// <summary>
    /// HUD1 Place of Settlement [L75]
    /// </summary>
    public string? Hud1SettlementAgentUnparsedAddress { get => _hud1SettlementAgentUnparsedAddress; set => SetField(ref _hud1SettlementAgentUnparsedAddress, value); }

    /// <summary>
    /// HUD1 Settlement Agent [L74]
    /// </summary>
    public string? Hud1SettlementAgentUnparsedName { get => _hud1SettlementAgentUnparsedName; set => SetField(ref _hud1SettlementAgentUnparsedName, value); }

    /// <summary>
    /// HUD1 Settlement Date [L76]
    /// </summary>
    public DateTime? Hud1SettlementDate { get => _hud1SettlementDate; set => SetField(ref _hud1SettlementDate, value); }

    /// <summary>
    /// Anti-Steering Disclosure - Include Safe Habor Disclosure [DISCLOSURE.X867]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? IncludeSafeHarborDisclosure { get => _includeSafeHarborDisclosure; set => SetField(ref _includeSafeHarborDisclosure, value); }

    /// <summary>
    /// Closing Documents - Investor Code [PlanCode.InvCd]
    /// </summary>
    public string? InvestorCode { get => _investorCode; set => SetField(ref _investorCode, value); }

    /// <summary>
    /// REGZ Loan Info Last Audit Date [1885]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastAuditDate { get => _lastAuditDate; set => SetField(ref _lastAuditDate, value); }

    /// <summary>
    /// REGZ Loan Info Last Document Ordered [1886]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastDocumentOrdered { get => _lastDocumentOrdered; set => SetField(ref _lastDocumentOrdered, value); }

    /// <summary>
    /// Property Info Attach Legal Descr [1884]
    /// </summary>
    public bool? LegalAttached { get => _legalAttached; set => SetField(ref _legalAttached, value); }

    /// <summary>
    /// State Disc - Lender Rep Title [DISCLOSURE.X187]
    /// </summary>
    public string? LenderAuthorizedRepresentativeTitle { get => _lenderAuthorizedRepresentativeTitle; set => SetField(ref _lenderAuthorizedRepresentativeTitle, value); }

    /// <summary>
    /// State Disc - Lender Broker Rep [DISCLOSURE.X185]
    /// </summary>
    public string? LenderBrokerRepresents { get => _lenderBrokerRepresents; set => SetField(ref _lenderBrokerRepresents, value); }

    /// <summary>
    /// Closing Docs Mfg Home Address of Lien Holder [3645]
    /// </summary>
    public string? LienHolderAddress { get => _lienHolderAddress; set => SetField(ref _lienHolderAddress, value); }

    /// <summary>
    /// Closing Docs Mfg Home Address City of Lien Holder [3646]
    /// </summary>
    public string? LienHolderAddressCity { get => _lienHolderAddressCity; set => SetField(ref _lienHolderAddressCity, value); }

    /// <summary>
    /// Closing Docs Mfg Home Postal Code of Lien Holder [3648]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? LienHolderAddressPostalCode { get => _lienHolderAddressPostalCode; set => SetField(ref _lienHolderAddressPostalCode, value); }

    /// <summary>
    /// Closing Docs Mfg Home Address State of Lien Holder [3647]
    /// </summary>
    public string? LienHolderAddressState { get => _lienHolderAddressState; set => SetField(ref _lienHolderAddressState, value); }

    /// <summary>
    /// Closing Docs Mfg Home Name of Lien Holder [3644]
    /// </summary>
    public string? LienHolderName { get => _lienHolderName; set => SetField(ref _lienHolderName, value); }

    /// <summary>
    /// Closing Loan Info Loan is Locked [2400]
    /// </summary>
    public bool? LoanIsLocked { get => _loanIsLocked; set => SetField(ref _loanIsLocked, value); }

    /// <summary>
    /// Anti-Steering Disclosure - LoanOption [DISCLOSURE.X732]
    /// </summary>
    public StringEnumValue<LoanOption> LoanOption { get => _loanOption; set => SetField(ref _loanOption, value); }

    /// <summary>
    /// State Disc - Lock In Fee Type [DISCLOSURE.X198]
    /// </summary>
    public StringEnumValue<LockInFeeType> LockInFeeType { get => _lockInFeeType; set => SetField(ref _lockInFeeType, value); }

    /// <summary>
    /// Closing Docs Mfg Home Anchored [2589]
    /// </summary>
    public StringEnumValue<MfgHomeAnchored> MfgHomeAnchored { get => _mfgHomeAnchored; set => SetField(ref _mfgHomeAnchored, value); }

    /// <summary>
    /// Closing Docs Mfg Home Cert of Title ID [2584]
    /// </summary>
    public string? MfgHomeCertificateOfTitleIdentifier { get => _mfgHomeCertificateOfTitleIdentifier; set => SetField(ref _mfgHomeCertificateOfTitleIdentifier, value); }

    /// <summary>
    /// Closing Docs Mfg Home Cert of Title Type [2585]
    /// </summary>
    public StringEnumValue<MfgHomeCertificateOfTitleType> MfgHomeCertificateOfTitleType { get => _mfgHomeCertificateOfTitleType; set => SetField(ref _mfgHomeCertificateOfTitleType, value); }

    /// <summary>
    /// Closing Docs Mfg Home Descr [2590]
    /// </summary>
    public string? MfgHomeDescription { get => _mfgHomeDescription; set => SetField(ref _mfgHomeDescription, value); }

    /// <summary>
    /// Closing Docs Mfg Home HUD Cert. Label ID [2588]
    /// </summary>
    public string? MfgHomeHudCertificationLabelIdentifier { get => _mfgHomeHudCertificationLabelIdentifier; set => SetField(ref _mfgHomeHudCertificationLabelIdentifier, value); }

    /// <summary>
    /// Closing Docs Mfg Home Length (Ft) [2580]
    /// </summary>
    public int? MfgHomeLengthFeetCount { get => _mfgHomeLengthFeetCount; set => SetField(ref _mfgHomeLengthFeetCount, value); }

    /// <summary>
    /// Closing Docs Mfg Home Make [2578]
    /// </summary>
    public string? MfgHomeMakeIdentifier { get => _mfgHomeMakeIdentifier; set => SetField(ref _mfgHomeMakeIdentifier, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer [2582]
    /// </summary>
    public string? MfgHomeManufacturer { get => _mfgHomeManufacturer; set => SetField(ref _mfgHomeManufacturer, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Address [4064]
    /// </summary>
    public string? MfgHomeManufacturerAddress { get => _mfgHomeManufacturerAddress; set => SetField(ref _mfgHomeManufacturerAddress, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer City [4065]
    /// </summary>
    public string? MfgHomeManufacturerCity { get => _mfgHomeManufacturerCity; set => SetField(ref _mfgHomeManufacturerCity, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Phone Number [4068]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MfgHomeManufacturerPhoneNumber { get => _mfgHomeManufacturerPhoneNumber; set => SetField(ref _mfgHomeManufacturerPhoneNumber, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer Postal Code [4067]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MfgHomeManufacturerPostalCode { get => _mfgHomeManufacturerPostalCode; set => SetField(ref _mfgHomeManufacturerPostalCode, value); }

    /// <summary>
    /// Closing Docs Mfg Home Manufacturer State [4066]
    /// </summary>
    public string? MfgHomeManufacturerState { get => _mfgHomeManufacturerState; set => SetField(ref _mfgHomeManufacturerState, value); }

    /// <summary>
    /// Closing Docs Mfg Home Year [2579]
    /// </summary>
    public int? MfgHomeManufactureYear { get => _mfgHomeManufactureYear; set => SetField(ref _mfgHomeManufactureYear, value); }

    /// <summary>
    /// Closing Docs Mfg Home Model [2586]
    /// </summary>
    public string? MfgHomeModelIdentifier { get => _mfgHomeModelIdentifier; set => SetField(ref _mfgHomeModelIdentifier, value); }

    /// <summary>
    /// Closing Docs Mfg Home New or Used [2587]
    /// </summary>
    public StringEnumValue<MfgHomeNewOrUsed> MfgHomeNewOrUsed { get => _mfgHomeNewOrUsed; set => SetField(ref _mfgHomeNewOrUsed, value); }

    /// <summary>
    /// Closing Docs Mfg Home Serial No [2583]
    /// </summary>
    public string? MfgHomeSerialNumberIdentifier { get => _mfgHomeSerialNumberIdentifier; set => SetField(ref _mfgHomeSerialNumberIdentifier, value); }

    /// <summary>
    /// Closing Docs Mfg Home Width (Ft) [2581]
    /// </summary>
    public int? MfgHomeWidthFeetCount { get => _mfgHomeWidthFeetCount; set => SetField(ref _mfgHomeWidthFeetCount, value); }

    /// <summary>
    /// Property Info Mineral Rights Descr [1883]
    /// </summary>
    public string? MineralRightsDescription { get => _mineralRightsDescription; set => SetField(ref _mineralRightsDescription, value); }

    /// <summary>
    /// HUD1 Loan Type [L83]
    /// </summary>
    public StringEnumValue<MortgageType> MortgageType { get => _mortgageType; set => SetField(ref _mortgageType, value); }

    /// <summary>
    /// State Disc - No. Broker Agreements [DISCLOSURE.X182]
    /// </summary>
    public int? NumberBrokerAgreements { get => _numberBrokerAgreements; set => SetField(ref _numberBrokerAgreements, value); }

    /// <summary>
    /// State Disc - No. Successful Broker Agreements [DISCLOSURE.X183]
    /// </summary>
    public int? NumberSuccessfulBrokerAgreements { get => _numberSuccessfulBrokerAgreements; set => SetField(ref _numberSuccessfulBrokerAgreements, value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Office of Rec Name [1938]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OfficeOfRecordationName { get => _officeOfRecordationName; set => SetField(ref _officeOfRecordationName, value); }

    /// <summary>
    /// State Disc - Loans Brokered to Only 1 Entity [DISCLOSURE.X206]
    /// </summary>
    public bool? OnlyOneEntity { get => _onlyOneEntity; set => SetField(ref _onlyOneEntity, value); }

    /// <summary>
    /// Anti-Steering Disclosure - The Reason to Select this Option [DISCLOSURE.X734]
    /// </summary>
    public string? OptionSelectedReason { get => _optionSelectedReason; set => SetField(ref _optionSelectedReason, value); }

    /// <summary>
    /// Closing Docs Mfg Home Original Pincipal Amount Secured [3649]
    /// </summary>
    public decimal? OriginalPincipalAmountSecured { get => _originalPincipalAmountSecured; set => SetField(ref _originalPincipalAmountSecured, value); }

    /// <summary>
    /// Anti-Steering Disclosure - Other Option Description [DISCLOSURE.X733]
    /// </summary>
    public string? OtherOptionDescription { get => _otherOptionDescription; set => SetField(ref _otherOptionDescription, value); }

    /// <summary>
    /// State Disc - Parent or Affiliated Co Name [DISCLOSURE.X204]
    /// </summary>
    public string? ParentAffiliatedCoName { get => _parentAffiliatedCoName; set => SetField(ref _parentAffiliatedCoName, value); }

    /// <summary>
    /// REGZ Transfer To [1951]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PayToTheOrderOfDescription { get => _payToTheOrderOfDescription; set => SetField(ref _payToTheOrderOfDescription, value); }

    /// <summary>
    /// REGZ Construction Mortgage Number of Days [1962]
    /// </summary>
    public StringEnumValue<PerDiemCalculationMethodType> PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => SetField(ref _perDiemCalculationMethodType, value); }

    /// <summary>
    /// REGZ Loan Info Plan Code [1881]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PlanCode { get => _planCode; set => SetField(ref _planCode, value); }

    /// <summary>
    /// Plan Code Description [PlanCode.Desc]
    /// </summary>
    public string? PlanCodeDescription { get => _planCodeDescription; set => SetField(ref _planCodeDescription, value); }

    /// <summary>
    /// Plan Code [PlanCode.ID]
    /// </summary>
    public string? PlanCodeId { get => _planCodeId; set => SetField(ref _planCodeId, value); }

    /// <summary>
    /// Property Info Title Report Date [L362]
    /// </summary>
    public DateTime? PreliminaryTitleReportDate { get => _preliminaryTitleReportDate; set => SetField(ref _preliminaryTitleReportDate, value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 1 [DISCLOSURE.X192]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions1 { get => _prepaymentPenaltyDescriptions1; set => SetField(ref _prepaymentPenaltyDescriptions1, value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 2 [DISCLOSURE.X193]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions2 { get => _prepaymentPenaltyDescriptions2; set => SetField(ref _prepaymentPenaltyDescriptions2, value); }

    /// <summary>
    /// State Disc - Prepay Penalty Descr 3 [DISCLOSURE.X194]
    /// </summary>
    public string? PrepaymentPenaltyDescriptions3 { get => _prepaymentPenaltyDescriptions3; set => SetField(ref _prepaymentPenaltyDescriptions3, value); }

    /// <summary>
    /// Print Trust Name(s) on LE/CD Addendum [4662]
    /// </summary>
    public bool? PrintTrustNameIndicator { get => _printTrustNameIndicator; set => SetField(ref _printTrustNameIndicator, value); }

    /// <summary>
    /// State Disc - Days to Process [DISCLOSURE.X184]
    /// </summary>
    public int? ProcessingNumberDays { get => _processingNumberDays; set => SetField(ref _processingNumberDays, value); }

    /// <summary>
    /// Closing Documents - Program Code [PlanCode.ProgCd]
    /// </summary>
    public string? ProgramCode { get => _programCode; set => SetField(ref _programCode, value); }

    /// <summary>
    /// Closing Documents - Investor [PlanCode.ProgSpnsrNm]
    /// </summary>
    public string? ProgramSponsor { get => _programSponsor; set => SetField(ref _programSponsor, value); }

    /// <summary>
    /// State Disc - Property Is In A Land Trust [DISCLOSURE.X207]
    /// </summary>
    public bool? PropertyIsLandTrust { get => _propertyIsLandTrust; set => SetField(ref _propertyIsLandTrust, value); }

    /// <summary>
    /// Property Info Tax Message [L360]
    /// </summary>
    public string? PropertyTaxMessageDescription { get => _propertyTaxMessageDescription; set => SetField(ref _propertyTaxMessageDescription, value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 1 [DISCLOSURE.X189]
    /// </summary>
    public string? RateLockRefundConditions1 { get => _rateLockRefundConditions1; set => SetField(ref _rateLockRefundConditions1, value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 2 [DISCLOSURE.X190]
    /// </summary>
    public string? RateLockRefundConditions2 { get => _rateLockRefundConditions2; set => SetField(ref _rateLockRefundConditions2, value); }

    /// <summary>
    /// State Disc - Rate Lock Refund Condition 3 [DISCLOSURE.X191]
    /// </summary>
    public string? RateLockRefundConditions3 { get => _rateLockRefundConditions3; set => SetField(ref _rateLockRefundConditions3, value); }

    /// <summary>
    /// Closing Docs Recordable Doc Associated Doc Juris Name [1936]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? RecordingJurisdictionName { get => _recordingJurisdictionName; set => SetField(ref _recordingJurisdictionName, value); }

    /// <summary>
    /// State Disc - Lender Guarantees Balloon Refi [DISCLOSURE.X201]
    /// </summary>
    public bool? RefinanceBalloonMortgageGuarantee { get => _refinanceBalloonMortgageGuarantee; set => SetField(ref _refinanceBalloonMortgageGuarantee, value); }

    /// <summary>
    /// REGZ Loan Info Exempt from Right of Rescission [3942]
    /// </summary>
    public bool? RefinanceRightOfRescissionExemptFlag { get => _refinanceRightOfRescissionExemptFlag; set => SetField(ref _refinanceRightOfRescissionExemptFlag, value); }

    /// <summary>
    /// Closing Docs Renewal and Extension [3240]
    /// </summary>
    public string? RenewalExtensionDescription { get => _renewalExtensionDescription; set => SetField(ref _renewalExtensionDescription, value); }

    /// <summary>
    /// REGZ Loan Info Rescission Date [L724]
    /// </summary>
    public DateTime? RescissionDate { get => _rescissionDate; set => SetField(ref _rescissionDate, value); }

    /// <summary>
    /// ClosingDocumentContract RespaHudDetails
    /// </summary>
    [AllowNull]
    public IList<RespaHudDetail> RespaHudDetails { get => GetField(ref _respaHudDetails); set => SetField(ref _respaHudDetails, value); }

    /// <summary>
    /// State Disc - RMLA Name Preceding 10 Yrs [DISCLOSURE.X203]
    /// </summary>
    public string? RmlaNamePreceding10Years { get => _rmlaNamePreceding10Years; set => SetField(ref _rmlaNamePreceding10Years, value); }

    /// <summary>
    /// State Disc - RML Licensees- Lender Broker Rep [DISCLOSURE.X952]
    /// </summary>
    public string? RmlLenderBrokerRepresents { get => _rmlLenderBrokerRepresents; set => SetField(ref _rmlLenderBrokerRepresents, value); }

    /// <summary>
    /// Closing Docs RESPA Second Transfer Year [1930]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SecondTransferYear { get => _secondTransferYear; set => SetField(ref _secondTransferYear, value); }

    /// <summary>
    /// Closing Docs RESPA Second Transfer Year Value [1931]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? SecondTransferYearValue { get => _secondTransferYearValue; set => SetField(ref _secondTransferYearValue, value); }

    /// <summary>
    /// Closing Docs 1003 Signature Date [3261]
    /// </summary>
    public DateTime? SignatureDateFor1003 { get => _signatureDateFor1003; set => SetField(ref _signatureDateFor1003, value); }

    /// <summary>
    /// Property Info Flood Zone [541]
    /// </summary>
    public StringEnumValue<FloodZone> SpecialFloodHazardAreaIndictor { get => _specialFloodHazardAreaIndictor; set => SetField(ref _specialFloodHazardAreaIndictor, value); }

    /// <summary>
    /// ClosingDocumentContract StateLicenses
    /// </summary>
    [AllowNull]
    public IList<StateLicense> StateLicenses { get => GetField(ref _stateLicenses); set => SetField(ref _stateLicenses, value); }

    /// <summary>
    /// State Disc - Surety Company Name [DISCLOSURE.X186]
    /// </summary>
    public string? SuretyCompanyName { get => _suretyCompanyName; set => SetField(ref _suretyCompanyName, value); }

    /// <summary>
    /// Closing Docs REGZ Loan Info Sync Prepaid Int [2852]
    /// </summary>
    public bool? SyncInterestDateDisbursementDate { get => _syncInterestDateDisbursementDate; set => SetField(ref _syncInterestDateDisbursementDate, value); }

    /// <summary>
    /// Closing Documents Termite Report Required [L493]
    /// </summary>
    public StringEnumValue<YOrN> TermiteReportRequiredIndicator { get => _termiteReportRequiredIndicator; set => SetField(ref _termiteReportRequiredIndicator, value); }

    /// <summary>
    /// Property Info Legal Descr [1846]
    /// </summary>
    public string? TextDescription { get => _textDescription; set => SetField(ref _textDescription, value); }

    /// <summary>
    /// Closing Docs RESPA Third Transfer Year [1932]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ThirdTransferYear { get => _thirdTransferYear; set => SetField(ref _thirdTransferYear, value); }

    /// <summary>
    /// Closing Docs RESPA Third Transfer Year Value [1933]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? ThirdTransferYearValue { get => _thirdTransferYearValue; set => SetField(ref _thirdTransferYearValue, value); }

    /// <summary>
    /// Title Closing Disclosure - Title/Closing Agent Sent Data for Review [CL.WF.EVNT.DATAREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleClosingAgentSentDataForReview { get => _titleClosingAgentSentDataForReview; set => SetField(ref _titleClosingAgentSentDataForReview, value); }

    /// <summary>
    /// Title Closing Disclosure - Title/Closing Agent Sent Doc(s) for Review [CL.WF.EVNT.DOCREVIEW]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? TitleClosingAgentSentDocForReview { get => _titleClosingAgentSentDocForReview; set => SetField(ref _titleClosingAgentSentDocForReview, value); }

    /// <summary>
    /// Property Info Approved Items [L361]
    /// </summary>
    public string? TitleReportItemsDescription { get => _titleReportItemsDescription; set => SetField(ref _titleReportItemsDescription, value); }

    /// <summary>
    /// Property Info Special Endorsements [L358]
    /// </summary>
    public string? TitleReportRequiredEndorsementsDescription { get => _titleReportRequiredEndorsementsDescription; set => SetField(ref _titleReportRequiredEndorsementsDescription, value); }

    /// <summary>
    /// HUD1 HUD1A - 1520 Total Disbursed [HUD1A.X31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalDisbursed { get => _totalDisbursed; set => SetField(ref _totalDisbursed, value); }

    /// <summary>
    /// Borrower Vesting Corp/Trust 2 Beneficiaries [Vesting.Trst2Bfcry]
    /// </summary>
    public string? Trust2Beneficiaries { get => _trust2Beneficiaries; set => SetField(ref _trust2Beneficiaries, value); }

    /// <summary>
    /// State Disc - We Conduct Business As [DISCLOSURE.X205]
    /// </summary>
    public StringEnumValue<WeConductBusiness> WeConductBusiness { get => _weConductBusiness; set => SetField(ref _weConductBusiness, value); }
}