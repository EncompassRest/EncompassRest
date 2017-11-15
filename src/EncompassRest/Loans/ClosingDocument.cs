using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ClosingDocument : IDirty
    {
        private DirtyValue<string> _additionalLienHolderAddress;
        public string AdditionalLienHolderAddress { get => _additionalLienHolderAddress; set => _additionalLienHolderAddress = value; }
        private DirtyValue<string> _additionalLienHolderAddressCity;
        public string AdditionalLienHolderAddressCity { get => _additionalLienHolderAddressCity; set => _additionalLienHolderAddressCity = value; }
        private DirtyValue<string> _additionalLienHolderAddressPostalCode;
        public string AdditionalLienHolderAddressPostalCode { get => _additionalLienHolderAddressPostalCode; set => _additionalLienHolderAddressPostalCode = value; }
        private DirtyValue<string> _additionalLienHolderAddressState;
        public string AdditionalLienHolderAddressState { get => _additionalLienHolderAddressState; set => _additionalLienHolderAddressState = value; }
        private DirtyValue<string> _additionalLienHolderName;
        public string AdditionalLienHolderName { get => _additionalLienHolderName; set => _additionalLienHolderName = value; }
        private DirtyValue<decimal?> _additionalOriginalPincipalAmountSecured;
        public decimal? AdditionalOriginalPincipalAmountSecured { get => _additionalOriginalPincipalAmountSecured; set => _additionalOriginalPincipalAmountSecured = value; }
        private DirtyValue<StringEnumValue<AdditionalSigVerbiageType>> _additionalSigVerbiageType;
        public StringEnumValue<AdditionalSigVerbiageType> AdditionalSigVerbiageType { get => _additionalSigVerbiageType; set => _additionalSigVerbiageType = value; }
        private DirtyList<AdditionalStateDisclosure> _additionalStateDisclosures;
        public IList<AdditionalStateDisclosure> AdditionalStateDisclosures { get => _additionalStateDisclosures ?? (_additionalStateDisclosures = new DirtyList<AdditionalStateDisclosure>()); set => _additionalStateDisclosures = new DirtyList<AdditionalStateDisclosure>(value); }
        private DirtyValue<bool?> _affectedByInterest;
        public bool? AffectedByInterest { get => _affectedByInterest; set => _affectedByInterest = value; }
        private DirtyValue<string> _alternateLender;
        public string AlternateLender { get => _alternateLender; set => _alternateLender = value; }
        private DirtyValue<string> _altLenderId;
        public string AltLenderId { get => _altLenderId; set => _altLenderId = value; }
        private DirtyList<AntiSteeringLoanOption> _antiSteeringLoanOptions;
        public IList<AntiSteeringLoanOption> AntiSteeringLoanOptions { get => _antiSteeringLoanOptions ?? (_antiSteeringLoanOptions = new DirtyList<AntiSteeringLoanOption>()); set => _antiSteeringLoanOptions = new DirtyList<AntiSteeringLoanOption>(value); }
        private DirtyValue<string> _areAbleToServiceIndicator;
        public string AreAbleToServiceIndicator { get => _areAbleToServiceIndicator; set => _areAbleToServiceIndicator = value; }
        private DirtyValue<string> _associatedDocumentNumber;
        public string AssociatedDocumentNumber { get => _associatedDocumentNumber; set => _associatedDocumentNumber = value; }
        private DirtyValue<string> _beneficiaries;
        public string Beneficiaries { get => _beneficiaries; set => _beneficiaries = value; }
        private DirtyValue<bool?> _borrowerConsentType1;
        public bool? BorrowerConsentType1 { get => _borrowerConsentType1; set => _borrowerConsentType1 = value; }
        private DirtyValue<bool?> _borrowerConsentType2;
        public bool? BorrowerConsentType2 { get => _borrowerConsentType2; set => _borrowerConsentType2 = value; }
        private DirtyValue<string> _borrowerOrganizationType1;
        public string BorrowerOrganizationType1 { get => _borrowerOrganizationType1; set => _borrowerOrganizationType1 = value; }
        private DirtyValue<string> _borrowerOrganizationType2;
        public string BorrowerOrganizationType2 { get => _borrowerOrganizationType2; set => _borrowerOrganizationType2 = value; }
        private DirtyValue<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName1;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName1; set => _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = value; }
        private DirtyValue<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName2;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get => _borrowerOrganizedUnderTheLawsOfJurisdictionName2; set => _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = value; }
        private DirtyValue<string> _borrowerTaxIdentificationNumberIdentifier1;
        public string BorrowerTaxIdentificationNumberIdentifier1 { get => _borrowerTaxIdentificationNumberIdentifier1; set => _borrowerTaxIdentificationNumberIdentifier1 = value; }
        private DirtyValue<string> _borrowerTaxIdentificationNumberIdentifier2;
        public string BorrowerTaxIdentificationNumberIdentifier2 { get => _borrowerTaxIdentificationNumberIdentifier2; set => _borrowerTaxIdentificationNumberIdentifier2 = value; }
        private DirtyValue<string> _borrowerTrustAmendedDateOrYear1;
        public string BorrowerTrustAmendedDateOrYear1 { get => _borrowerTrustAmendedDateOrYear1; set => _borrowerTrustAmendedDateOrYear1 = value; }
        private DirtyValue<string> _borrowerTrustAmendedDateOrYear2;
        public string BorrowerTrustAmendedDateOrYear2 { get => _borrowerTrustAmendedDateOrYear2; set => _borrowerTrustAmendedDateOrYear2 = value; }
        private DirtyValue<string> _borrowerTrustDateOrYear1;
        public string BorrowerTrustDateOrYear1 { get => _borrowerTrustDateOrYear1; set => _borrowerTrustDateOrYear1 = value; }
        private DirtyValue<string> _borrowerTrustDateOrYear2;
        public string BorrowerTrustDateOrYear2 { get => _borrowerTrustDateOrYear2; set => _borrowerTrustDateOrYear2 = value; }
        private DirtyValue<string> _borrowerUnparsedName1;
        public string BorrowerUnparsedName1 { get => _borrowerUnparsedName1; set => _borrowerUnparsedName1 = value; }
        private DirtyValue<string> _borrowerUnparsedName2;
        public string BorrowerUnparsedName2 { get => _borrowerUnparsedName2; set => _borrowerUnparsedName2 = value; }
        private DirtyValue<string> _brokerAuthorizedRepresentativeTitle;
        public string BrokerAuthorizedRepresentativeTitle { get => _brokerAuthorizedRepresentativeTitle; set => _brokerAuthorizedRepresentativeTitle = value; }
        private DirtyValue<string> _brokerCompensationMethod;
        public string BrokerCompensationMethod { get => _brokerCompensationMethod; set => _brokerCompensationMethod = value; }
        private DirtyValue<string> _brokerFeeRefundConditions1;
        public string BrokerFeeRefundConditions1 { get => _brokerFeeRefundConditions1; set => _brokerFeeRefundConditions1 = value; }
        private DirtyValue<string> _brokerFeeRefundConditions2;
        public string BrokerFeeRefundConditions2 { get => _brokerFeeRefundConditions2; set => _brokerFeeRefundConditions2 = value; }
        private DirtyValue<string> _brokerFeeRefundConditions3;
        public string BrokerFeeRefundConditions3 { get => _brokerFeeRefundConditions3; set => _brokerFeeRefundConditions3 = value; }
        private DirtyValue<StringEnumValue<BrokerForPlacingLoan>> _brokerForPlacingLoan;
        public StringEnumValue<BrokerForPlacingLoan> BrokerForPlacingLoan { get => _brokerForPlacingLoan; set => _brokerForPlacingLoan = value; }
        private DirtyValue<string> _brokerInterestRateEffect;
        public string BrokerInterestRateEffect { get => _brokerInterestRateEffect; set => _brokerInterestRateEffect = value; }
        private DirtyValue<string> _brokerLenderRelationship;
        public string BrokerLenderRelationship { get => _brokerLenderRelationship; set => _brokerLenderRelationship = value; }
        private DirtyValue<string> _brokerLicenseNumberIdentifier;
        public string BrokerLicenseNumberIdentifier { get => _brokerLicenseNumberIdentifier; set => _brokerLicenseNumberIdentifier = value; }
        private DirtyValue<string> _brokerNameAsLicensed;
        public string BrokerNameAsLicensed { get => _brokerNameAsLicensed; set => _brokerNameAsLicensed = value; }
        private DirtyValue<string> _brokerTaxIdentificationNumberIdentifier;
        public string BrokerTaxIdentificationNumberIdentifier { get => _brokerTaxIdentificationNumberIdentifier; set => _brokerTaxIdentificationNumberIdentifier = value; }
        private DirtyValue<StringEnumValue<BrokerWithLenders>> _brokerWithLenders;
        public StringEnumValue<BrokerWithLenders> BrokerWithLenders { get => _brokerWithLenders; set => _brokerWithLenders = value; }
        private DirtyValue<decimal?> _cashCheckFromBorrower;
        public decimal? CashCheckFromBorrower { get => _cashCheckFromBorrower; set => _cashCheckFromBorrower = value; }
        private DirtyValue<DateTime?> _cLClearCloseStatusReceivedByLenderDateTime;
        public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get => _cLClearCloseStatusReceivedByLenderDateTime; set => _cLClearCloseStatusReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLClosingEscrowOrderAcceptedDateTime;
        public DateTime? CLClosingEscrowOrderAcceptedDateTime { get => _cLClosingEscrowOrderAcceptedDateTime; set => _cLClosingEscrowOrderAcceptedDateTime = value; }
        private DirtyValue<DateTime?> _cLClosingEscrowOrderSentDateTime;
        public DateTime? CLClosingEscrowOrderSentDateTime { get => _cLClosingEscrowOrderSentDateTime; set => _cLClosingEscrowOrderSentDateTime = value; }
        private DirtyValue<DateTime?> _cLDraftClosingDisclosureReceivedByLenderDateTime;
        public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get => _cLDraftClosingDisclosureReceivedByLenderDateTime; set => _cLDraftClosingDisclosureReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLFinalCDSentDateTime;
        public DateTime? CLFinalCDSentDateTime { get => _cLFinalCDSentDateTime; set => _cLFinalCDSentDateTime = value; }
        private DirtyValue<DateTime?> _cLFinalTitlePolicyDateTime;
        public DateTime? CLFinalTitlePolicyDateTime { get => _cLFinalTitlePolicyDateTime; set => _cLFinalTitlePolicyDateTime = value; }
        private DirtyValue<DateTime?> _cLLastFeeQuoteReceivedDateTime;
        public DateTime? CLLastFeeQuoteReceivedDateTime { get => _cLLastFeeQuoteReceivedDateTime; set => _cLLastFeeQuoteReceivedDateTime = value; }
        private DirtyValue<DateTime?> _cLLastFeeQuoteRequestedDateTime;
        public DateTime? CLLastFeeQuoteRequestedDateTime { get => _cLLastFeeQuoteRequestedDateTime; set => _cLLastFeeQuoteRequestedDateTime = value; }
        private DirtyValue<StringEnumValue<DocsLoanProgramType>> _closingDocsLoanProgramType;
        public StringEnumValue<DocsLoanProgramType> ClosingDocsLoanProgramType { get => _closingDocsLoanProgramType; set => _closingDocsLoanProgramType = value; }
        private DirtyList<ClosingEntity> _closingEntities;
        public IList<ClosingEntity> ClosingEntities { get => _closingEntities ?? (_closingEntities = new DirtyList<ClosingEntity>()); set => _closingEntities = new DirtyList<ClosingEntity>(value); }
        private DirtyValue<string> _closingProvider;
        public string ClosingProvider { get => _closingProvider; set => _closingProvider = value; }
        private DirtyValue<string> _closingState;
        public string ClosingState { get => _closingState; set => _closingState = value; }
        private DirtyValue<DateTime?> _cLPayoffsRequestedDateTime;
        public DateTime? CLPayoffsRequestedDateTime { get => _cLPayoffsRequestedDateTime; set => _cLPayoffsRequestedDateTime = value; }
        private DirtyValue<DateTime?> _cLPrelimCommitmentReceivedByLenderDateTime;
        public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get => _cLPrelimCommitmentReceivedByLenderDateTime; set => _cLPrelimCommitmentReceivedByLenderDateTime = value; }
        private DirtyValue<DateTime?> _cLProviderDisburseFundsDateTime;
        public DateTime? CLProviderDisburseFundsDateTime { get => _cLProviderDisburseFundsDateTime; set => _cLProviderDisburseFundsDateTime = value; }
        private DirtyValue<DateTime?> _cLTitleOrderAcceptedDateTime;
        public DateTime? CLTitleOrderAcceptedDateTime { get => _cLTitleOrderAcceptedDateTime; set => _cLTitleOrderAcceptedDateTime = value; }
        private DirtyValue<DateTime?> _cLTitleOrderSentDateTime;
        public DateTime? CLTitleOrderSentDateTime { get => _cLTitleOrderSentDateTime; set => _cLTitleOrderSentDateTime = value; }
        private DirtyValue<string> _complianceJurisdictionCounty;
        public string ComplianceJurisdictionCounty { get => _complianceJurisdictionCounty; set => _complianceJurisdictionCounty = value; }
        private DirtyValue<DateTime?> _compliancePropertyIdentifiedDate;
        public DateTime? CompliancePropertyIdentifiedDate { get => _compliancePropertyIdentifiedDate; set => _compliancePropertyIdentifiedDate = value; }
        private DirtyValue<string> _conditionDescription;
        public string ConditionDescription { get => _conditionDescription; set => _conditionDescription = value; }
        private DirtyValue<bool?> _conflictofInterestCheck1;
        public bool? ConflictofInterestCheck1 { get => _conflictofInterestCheck1; set => _conflictofInterestCheck1 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck2;
        public bool? ConflictofInterestCheck2 { get => _conflictofInterestCheck2; set => _conflictofInterestCheck2 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck3;
        public bool? ConflictofInterestCheck3 { get => _conflictofInterestCheck3; set => _conflictofInterestCheck3 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck4;
        public bool? ConflictofInterestCheck4 { get => _conflictofInterestCheck4; set => _conflictofInterestCheck4 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck5;
        public bool? ConflictofInterestCheck5 { get => _conflictofInterestCheck5; set => _conflictofInterestCheck5 = value; }
        private DirtyValue<bool?> _conflictofInterestCheck6;
        public bool? ConflictofInterestCheck6 { get => _conflictofInterestCheck6; set => _conflictofInterestCheck6 = value; }
        private DirtyValue<string> _coopApartmentNumber;
        public string CoopApartmentNumber { get => _coopApartmentNumber; set => _coopApartmentNumber = value; }
        private DirtyValue<DateTime?> _coopAssignmentLeaseDate;
        public DateTime? CoopAssignmentLeaseDate { get => _coopAssignmentLeaseDate; set => _coopAssignmentLeaseDate = value; }
        private DirtyValue<string> _coopAttorneyInFact;
        public string CoopAttorneyInFact { get => _coopAttorneyInFact; set => _coopAttorneyInFact = value; }
        private DirtyValue<string> _coopBuildingName;
        public string CoopBuildingName { get => _coopBuildingName; set => _coopBuildingName = value; }
        private DirtyValue<string> _coopCompanyExistsUnderTHeLawsOf;
        public string CoopCompanyExistsUnderTHeLawsOf { get => _coopCompanyExistsUnderTHeLawsOf; set => _coopCompanyExistsUnderTHeLawsOf = value; }
        private DirtyValue<string> _coopCompanyName;
        public string CoopCompanyName { get => _coopCompanyName; set => _coopCompanyName = value; }
        private DirtyValue<DateTime?> _coopProprietaryLeaseDate;
        public DateTime? CoopProprietaryLeaseDate { get => _coopProprietaryLeaseDate; set => _coopProprietaryLeaseDate = value; }
        private DirtyValue<decimal?> _coopSharesOwned;
        public decimal? CoopSharesOwned { get => _coopSharesOwned; set => _coopSharesOwned = value; }
        private DirtyValue<string> _coopStockCertificationNumber;
        public string CoopStockCertificationNumber { get => _coopStockCertificationNumber; set => _coopStockCertificationNumber = value; }
        private DirtyValue<decimal?> _coopVacancyPercentNotification;
        public decimal? CoopVacancyPercentNotification { get => _coopVacancyPercentNotification; set => _coopVacancyPercentNotification = value; }
        private DirtyValue<string> _customOtherRiderDescription;
        public string CustomOtherRiderDescription { get => _customOtherRiderDescription; set => _customOtherRiderDescription = value; }
        private DirtyValue<DateTime?> _disbursementDate;
        public DateTime? DisbursementDate { get => _disbursementDate; set => _disbursementDate = value; }
        private DirtyValue<decimal?> _disbursementsToBorrower;
        public decimal? DisbursementsToBorrower { get => _disbursementsToBorrower; set => _disbursementsToBorrower = value; }
        private DirtyValue<string> _disclosureAlternateLender;
        public string DisclosureAlternateLender { get => _disclosureAlternateLender; set => _disclosureAlternateLender = value; }
        private DirtyValue<string> _disclosureCompanyFunction;
        public string DisclosureCompanyFunction { get => _disclosureCompanyFunction; set => _disclosureCompanyFunction = value; }
        private DirtyValue<string> _disclosurePlanCode;
        public string DisclosurePlanCode { get => _disclosurePlanCode; set => _disclosurePlanCode = value; }
        private DirtyValue<string> _docReportGUID;
        public string DocReportGUID { get => _docReportGUID; set => _docReportGUID = value; }
        private DirtyValue<DateTime?> _documentPreparationDate;
        public DateTime? DocumentPreparationDate { get => _documentPreparationDate; set => _documentPreparationDate = value; }
        private DirtyValue<DateTime?> _documentSigningDate;
        public DateTime? DocumentSigningDate { get => _documentSigningDate; set => _documentSigningDate = value; }
        private DirtyValue<string> _drawCity;
        public string DrawCity { get => _drawCity; set => _drawCity = value; }
        private DirtyValue<string> _drawCounty;
        public string DrawCounty { get => _drawCounty; set => _drawCounty = value; }
        private DirtyValue<string> _drawState;
        public string DrawState { get => _drawState; set => _drawState = value; }
        private DirtyValue<StringEnumValue<YNOrOther>> _employeeofMortgageLender;
        public StringEnumValue<YNOrOther> EmployeeofMortgageLender { get => _employeeofMortgageLender; set => _employeeofMortgageLender = value; }
        private DirtyValue<string> _expectToAssignSellOrTransferPercent;
        public string ExpectToAssignSellOrTransferPercent { get => _expectToAssignSellOrTransferPercent; set => _expectToAssignSellOrTransferPercent = value; }
        private DirtyValue<string> _finalVestingDescription;
        public string FinalVestingDescription { get => _finalVestingDescription; set => _finalVestingDescription = value; }
        private DirtyValue<string> _firstTransferYear;
        public string FirstTransferYear { get => _firstTransferYear; set => _firstTransferYear = value; }
        private DirtyValue<decimal?> _firstTransferYearValue;
        public decimal? FirstTransferYearValue { get => _firstTransferYearValue; set => _firstTransferYearValue = value; }
        private DirtyValue<string> _hoursDocumentsNeededPriorToDisbursementCount;
        public string HoursDocumentsNeededPriorToDisbursementCount { get => _hoursDocumentsNeededPriorToDisbursementCount; set => _hoursDocumentsNeededPriorToDisbursementCount = value; }
        private DirtyValue<bool?> _housingIndicator;
        public bool? HousingIndicator { get => _housingIndicator; set => _housingIndicator = value; }
        private DirtyValue<string> _housingProgramName;
        public string HousingProgramName { get => _housingProgramName; set => _housingProgramName = value; }
        private DirtyValue<string> _hUD1FileNumberIdentifier;
        public string HUD1FileNumberIdentifier { get => _hUD1FileNumberIdentifier; set => _hUD1FileNumberIdentifier = value; }
        private DirtyValue<string> _hUD1SettlementAgentUnparsedAddress;
        public string HUD1SettlementAgentUnparsedAddress { get => _hUD1SettlementAgentUnparsedAddress; set => _hUD1SettlementAgentUnparsedAddress = value; }
        private DirtyValue<string> _hUD1SettlementAgentUnparsedName;
        public string HUD1SettlementAgentUnparsedName { get => _hUD1SettlementAgentUnparsedName; set => _hUD1SettlementAgentUnparsedName = value; }
        private DirtyValue<DateTime?> _hUD1SettlementDate;
        public DateTime? HUD1SettlementDate { get => _hUD1SettlementDate; set => _hUD1SettlementDate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _includeSafeHaborDisclosure;
        public decimal? IncludeSafeHaborDisclosure { get => _includeSafeHaborDisclosure; set => _includeSafeHaborDisclosure = value; }
        private DirtyValue<string> _investorCode;
        public string InvestorCode { get => _investorCode; set => _investorCode = value; }
        private DirtyValue<string> _lastAuditDate;
        public string LastAuditDate { get => _lastAuditDate; set => _lastAuditDate = value; }
        private DirtyValue<string> _lastDocumentOrdered;
        public string LastDocumentOrdered { get => _lastDocumentOrdered; set => _lastDocumentOrdered = value; }
        private DirtyValue<bool?> _legalAttached;
        public bool? LegalAttached { get => _legalAttached; set => _legalAttached = value; }
        private DirtyValue<string> _lenderAuthorizedRepresentativeTitle;
        public string LenderAuthorizedRepresentativeTitle { get => _lenderAuthorizedRepresentativeTitle; set => _lenderAuthorizedRepresentativeTitle = value; }
        private DirtyValue<string> _lenderBrokerRepresents;
        public string LenderBrokerRepresents { get => _lenderBrokerRepresents; set => _lenderBrokerRepresents = value; }
        private DirtyValue<string> _lienHolderAddress;
        public string LienHolderAddress { get => _lienHolderAddress; set => _lienHolderAddress = value; }
        private DirtyValue<string> _lienHolderAddressCity;
        public string LienHolderAddressCity { get => _lienHolderAddressCity; set => _lienHolderAddressCity = value; }
        private DirtyValue<string> _lienHolderAddressPostalCode;
        public string LienHolderAddressPostalCode { get => _lienHolderAddressPostalCode; set => _lienHolderAddressPostalCode = value; }
        private DirtyValue<string> _lienHolderAddressState;
        public string LienHolderAddressState { get => _lienHolderAddressState; set => _lienHolderAddressState = value; }
        private DirtyValue<string> _lienHolderName;
        public string LienHolderName { get => _lienHolderName; set => _lienHolderName = value; }
        private DirtyValue<bool?> _loanIsLocked;
        public bool? LoanIsLocked { get => _loanIsLocked; set => _loanIsLocked = value; }
        private DirtyValue<StringEnumValue<LoanOption>> _loanOption;
        public StringEnumValue<LoanOption> LoanOption { get => _loanOption; set => _loanOption = value; }
        private DirtyValue<StringEnumValue<LockInFeeType>> _lockInFeeType;
        public StringEnumValue<LockInFeeType> LockInFeeType { get => _lockInFeeType; set => _lockInFeeType = value; }
        private DirtyValue<StringEnumValue<MfgHomeAnchored>> _mfgHomeAnchored;
        public StringEnumValue<MfgHomeAnchored> MfgHomeAnchored { get => _mfgHomeAnchored; set => _mfgHomeAnchored = value; }
        private DirtyValue<string> _mfgHomeCertificateOfTitleIdentifier;
        public string MfgHomeCertificateOfTitleIdentifier { get => _mfgHomeCertificateOfTitleIdentifier; set => _mfgHomeCertificateOfTitleIdentifier = value; }
        private DirtyValue<StringEnumValue<MfgHomeCertificateOfTitleType>> _mfgHomeCertificateOfTitleType;
        public StringEnumValue<MfgHomeCertificateOfTitleType> MfgHomeCertificateOfTitleType { get => _mfgHomeCertificateOfTitleType; set => _mfgHomeCertificateOfTitleType = value; }
        private DirtyValue<string> _mfgHomeDescription;
        public string MfgHomeDescription { get => _mfgHomeDescription; set => _mfgHomeDescription = value; }
        private DirtyValue<string> _mfgHomeHUDCertificationLabelIdentifier;
        public string MfgHomeHUDCertificationLabelIdentifier { get => _mfgHomeHUDCertificationLabelIdentifier; set => _mfgHomeHUDCertificationLabelIdentifier = value; }
        private DirtyValue<int?> _mfgHomeLengthFeetCount;
        public int? MfgHomeLengthFeetCount { get => _mfgHomeLengthFeetCount; set => _mfgHomeLengthFeetCount = value; }
        private DirtyValue<string> _mfgHomeMakeIdentifier;
        public string MfgHomeMakeIdentifier { get => _mfgHomeMakeIdentifier; set => _mfgHomeMakeIdentifier = value; }
        private DirtyValue<string> _mfgHomeManufacturer;
        public string MfgHomeManufacturer { get => _mfgHomeManufacturer; set => _mfgHomeManufacturer = value; }
        private DirtyValue<string> _mfgHomeManufacturerAddress;
        public string MfgHomeManufacturerAddress { get => _mfgHomeManufacturerAddress; set => _mfgHomeManufacturerAddress = value; }
        private DirtyValue<string> _mfgHomeManufacturerCity;
        public string MfgHomeManufacturerCity { get => _mfgHomeManufacturerCity; set => _mfgHomeManufacturerCity = value; }
        private DirtyValue<string> _mfgHomeManufacturerPhoneNumber;
        public string MfgHomeManufacturerPhoneNumber { get => _mfgHomeManufacturerPhoneNumber; set => _mfgHomeManufacturerPhoneNumber = value; }
        private DirtyValue<string> _mfgHomeManufacturerPostalCode;
        public string MfgHomeManufacturerPostalCode { get => _mfgHomeManufacturerPostalCode; set => _mfgHomeManufacturerPostalCode = value; }
        private DirtyValue<string> _mfgHomeManufacturerState;
        public string MfgHomeManufacturerState { get => _mfgHomeManufacturerState; set => _mfgHomeManufacturerState = value; }
        private DirtyValue<int?> _mfgHomeManufactureYear;
        public int? MfgHomeManufactureYear { get => _mfgHomeManufactureYear; set => _mfgHomeManufactureYear = value; }
        private DirtyValue<string> _mfgHomeModelIdentifier;
        public string MfgHomeModelIdentifier { get => _mfgHomeModelIdentifier; set => _mfgHomeModelIdentifier = value; }
        private DirtyValue<StringEnumValue<MfgHomeNewOrUsed>> _mfgHomeNewOrUsed;
        public StringEnumValue<MfgHomeNewOrUsed> MfgHomeNewOrUsed { get => _mfgHomeNewOrUsed; set => _mfgHomeNewOrUsed = value; }
        private DirtyValue<string> _mfgHomeSerialNumberIdentifier;
        public string MfgHomeSerialNumberIdentifier { get => _mfgHomeSerialNumberIdentifier; set => _mfgHomeSerialNumberIdentifier = value; }
        private DirtyValue<int?> _mfgHomeWidthFeetCount;
        public int? MfgHomeWidthFeetCount { get => _mfgHomeWidthFeetCount; set => _mfgHomeWidthFeetCount = value; }
        private DirtyValue<string> _mineralRightsDescription;
        public string MineralRightsDescription { get => _mineralRightsDescription; set => _mineralRightsDescription = value; }
        private DirtyValue<StringEnumValue<MortgageType>> _mortgageType;
        public StringEnumValue<MortgageType> MortgageType { get => _mortgageType; set => _mortgageType = value; }
        private DirtyValue<int?> _numberBrokerAgreements;
        public int? NumberBrokerAgreements { get => _numberBrokerAgreements; set => _numberBrokerAgreements = value; }
        private DirtyValue<int?> _numberSuccessfulBrokerAgreements;
        public int? NumberSuccessfulBrokerAgreements { get => _numberSuccessfulBrokerAgreements; set => _numberSuccessfulBrokerAgreements = value; }
        private DirtyValue<string> _officeOfRecordationName;
        public string OfficeOfRecordationName { get => _officeOfRecordationName; set => _officeOfRecordationName = value; }
        private DirtyValue<bool?> _onlyOneEntity;
        public bool? OnlyOneEntity { get => _onlyOneEntity; set => _onlyOneEntity = value; }
        private DirtyValue<string> _optionSelectedReason;
        public string OptionSelectedReason { get => _optionSelectedReason; set => _optionSelectedReason = value; }
        private DirtyValue<decimal?> _originalPincipalAmountSecured;
        public decimal? OriginalPincipalAmountSecured { get => _originalPincipalAmountSecured; set => _originalPincipalAmountSecured = value; }
        private DirtyValue<string> _otherOptionDescription;
        public string OtherOptionDescription { get => _otherOptionDescription; set => _otherOptionDescription = value; }
        private DirtyValue<string> _parentAffiliatedCoName;
        public string ParentAffiliatedCoName { get => _parentAffiliatedCoName; set => _parentAffiliatedCoName = value; }
        private DirtyValue<string> _payToTheOrderOfDescription;
        public string PayToTheOrderOfDescription { get => _payToTheOrderOfDescription; set => _payToTheOrderOfDescription = value; }
        private DirtyValue<StringEnumValue<PerDiemCalculationMethodType>> _perDiemCalculationMethodType;
        public StringEnumValue<PerDiemCalculationMethodType> PerDiemCalculationMethodType { get => _perDiemCalculationMethodType; set => _perDiemCalculationMethodType = value; }
        private DirtyValue<string> _planCode;
        public string PlanCode { get => _planCode; set => _planCode = value; }
        private DirtyValue<string> _planCodeDescription;
        public string PlanCodeDescription { get => _planCodeDescription; set => _planCodeDescription = value; }
        private DirtyValue<string> _planCodeId;
        public string PlanCodeId { get => _planCodeId; set => _planCodeId = value; }
        private DirtyValue<DateTime?> _preliminaryTitleReportDate;
        public DateTime? PreliminaryTitleReportDate { get => _preliminaryTitleReportDate; set => _preliminaryTitleReportDate = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions1;
        public string PrepaymentPenaltyDescriptions1 { get => _prepaymentPenaltyDescriptions1; set => _prepaymentPenaltyDescriptions1 = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions2;
        public string PrepaymentPenaltyDescriptions2 { get => _prepaymentPenaltyDescriptions2; set => _prepaymentPenaltyDescriptions2 = value; }
        private DirtyValue<string> _prepaymentPenaltyDescriptions3;
        public string PrepaymentPenaltyDescriptions3 { get => _prepaymentPenaltyDescriptions3; set => _prepaymentPenaltyDescriptions3 = value; }
        private DirtyValue<int?> _processingNumberDays;
        public int? ProcessingNumberDays { get => _processingNumberDays; set => _processingNumberDays = value; }
        private DirtyValue<string> _programCode;
        public string ProgramCode { get => _programCode; set => _programCode = value; }
        private DirtyValue<string> _programSponsor;
        public string ProgramSponsor { get => _programSponsor; set => _programSponsor = value; }
        private DirtyValue<bool?> _propertyIsLandTrust;
        public bool? PropertyIsLandTrust { get => _propertyIsLandTrust; set => _propertyIsLandTrust = value; }
        private DirtyValue<string> _propertyTaxMessageDescription;
        public string PropertyTaxMessageDescription { get => _propertyTaxMessageDescription; set => _propertyTaxMessageDescription = value; }
        private DirtyValue<string> _rateLockRefundConditions1;
        public string RateLockRefundConditions1 { get => _rateLockRefundConditions1; set => _rateLockRefundConditions1 = value; }
        private DirtyValue<string> _rateLockRefundConditions2;
        public string RateLockRefundConditions2 { get => _rateLockRefundConditions2; set => _rateLockRefundConditions2 = value; }
        private DirtyValue<string> _rateLockRefundConditions3;
        public string RateLockRefundConditions3 { get => _rateLockRefundConditions3; set => _rateLockRefundConditions3 = value; }
        private DirtyValue<string> _recordingJurisdictionName;
        public string RecordingJurisdictionName { get => _recordingJurisdictionName; set => _recordingJurisdictionName = value; }
        private DirtyValue<bool?> _refinanceBalloonMortgageGuarantee;
        public bool? RefinanceBalloonMortgageGuarantee { get => _refinanceBalloonMortgageGuarantee; set => _refinanceBalloonMortgageGuarantee = value; }
        private DirtyValue<bool?> _refinanceRightOfRescissionExemptFlag;
        public bool? RefinanceRightOfRescissionExemptFlag { get => _refinanceRightOfRescissionExemptFlag; set => _refinanceRightOfRescissionExemptFlag = value; }
        private DirtyValue<string> _renewalExtensionDescription;
        public string RenewalExtensionDescription { get => _renewalExtensionDescription; set => _renewalExtensionDescription = value; }
        private DirtyValue<DateTime?> _rescissionDate;
        public DateTime? RescissionDate { get => _rescissionDate; set => _rescissionDate = value; }
        private DirtyList<RespaHudDetail> _respaHudDetails;
        public IList<RespaHudDetail> RespaHudDetails { get => _respaHudDetails ?? (_respaHudDetails = new DirtyList<RespaHudDetail>()); set => _respaHudDetails = new DirtyList<RespaHudDetail>(value); }
        private DirtyValue<string> _rMLANamePreceding10Years;
        public string RMLANamePreceding10Years { get => _rMLANamePreceding10Years; set => _rMLANamePreceding10Years = value; }
        private DirtyValue<string> _rmlLenderBrokerRepresents;
        public string RmlLenderBrokerRepresents { get => _rmlLenderBrokerRepresents; set => _rmlLenderBrokerRepresents = value; }
        private DirtyValue<string> _secondTransferYear;
        public string SecondTransferYear { get => _secondTransferYear; set => _secondTransferYear = value; }
        private DirtyValue<decimal?> _secondTransferYearValue;
        public decimal? SecondTransferYearValue { get => _secondTransferYearValue; set => _secondTransferYearValue = value; }
        private DirtyValue<DateTime?> _signatureDateFor1003;
        public DateTime? SignatureDateFor1003 { get => _signatureDateFor1003; set => _signatureDateFor1003 = value; }
        private DirtyValue<StringEnumValue<SpecialFloodHazardAreaIndictor>> _specialFloodHazardAreaIndictor;
        public StringEnumValue<SpecialFloodHazardAreaIndictor> SpecialFloodHazardAreaIndictor { get => _specialFloodHazardAreaIndictor; set => _specialFloodHazardAreaIndictor = value; }
        private DirtyList<StateLicense> _stateLicenses;
        public IList<StateLicense> StateLicenses { get => _stateLicenses ?? (_stateLicenses = new DirtyList<StateLicense>()); set => _stateLicenses = new DirtyList<StateLicense>(value); }
        private DirtyValue<string> _suretyCompanyName;
        public string SuretyCompanyName { get => _suretyCompanyName; set => _suretyCompanyName = value; }
        private DirtyValue<bool?> _syncInterestDateDisbursementDate;
        public bool? SyncInterestDateDisbursementDate { get => _syncInterestDateDisbursementDate; set => _syncInterestDateDisbursementDate = value; }
        private DirtyValue<StringEnumValue<YOrN>> _termiteReportRequiredIndicator;
        public StringEnumValue<YOrN> TermiteReportRequiredIndicator { get => _termiteReportRequiredIndicator; set => _termiteReportRequiredIndicator = value; }
        private DirtyValue<string> _textDescription;
        public string TextDescription { get => _textDescription; set => _textDescription = value; }
        private DirtyValue<string> _thirdTransferYear;
        public string ThirdTransferYear { get => _thirdTransferYear; set => _thirdTransferYear = value; }
        private DirtyValue<decimal?> _thirdTransferYearValue;
        public decimal? ThirdTransferYearValue { get => _thirdTransferYearValue; set => _thirdTransferYearValue = value; }
        private DirtyValue<string> _titleReportItemsDescription;
        public string TitleReportItemsDescription { get => _titleReportItemsDescription; set => _titleReportItemsDescription = value; }
        private DirtyValue<string> _titleReportRequiredEndorsementsDescription;
        public string TitleReportRequiredEndorsementsDescription { get => _titleReportRequiredEndorsementsDescription; set => _titleReportRequiredEndorsementsDescription = value; }
        private DirtyValue<decimal?> _totalDisbursed;
        public decimal? TotalDisbursed { get => _totalDisbursed; set => _totalDisbursed = value; }
        private DirtyValue<string> _trust2Beneficiaries;
        public string Trust2Beneficiaries { get => _trust2Beneficiaries; set => _trust2Beneficiaries = value; }
        private DirtyValue<StringEnumValue<WeConductBusiness>> _weConductBusiness;
        public StringEnumValue<WeConductBusiness> WeConductBusiness { get => _weConductBusiness; set => _weConductBusiness = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _additionalLienHolderAddress.Dirty
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
                    || _stateLicenses?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}