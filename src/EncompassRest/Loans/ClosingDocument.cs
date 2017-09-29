using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDocument : IDirty
    {
        private Value<string> _additionalLienHolderAddress;
        public string AdditionalLienHolderAddress { get { return _additionalLienHolderAddress; } set { _additionalLienHolderAddress = value; } }
        private Value<string> _additionalLienHolderAddressCity;
        public string AdditionalLienHolderAddressCity { get { return _additionalLienHolderAddressCity; } set { _additionalLienHolderAddressCity = value; } }
        private Value<string> _additionalLienHolderAddressPostalCode;
        public string AdditionalLienHolderAddressPostalCode { get { return _additionalLienHolderAddressPostalCode; } set { _additionalLienHolderAddressPostalCode = value; } }
        private Value<string> _additionalLienHolderAddressState;
        public string AdditionalLienHolderAddressState { get { return _additionalLienHolderAddressState; } set { _additionalLienHolderAddressState = value; } }
        private Value<string> _additionalLienHolderName;
        public string AdditionalLienHolderName { get { return _additionalLienHolderName; } set { _additionalLienHolderName = value; } }
        private Value<decimal?> _additionalOriginalPincipalAmountSecured;
        public decimal? AdditionalOriginalPincipalAmountSecured { get { return _additionalOriginalPincipalAmountSecured; } set { _additionalOriginalPincipalAmountSecured = value; } }
        private Value<string> _additionalSigVerbiageType;
        public string AdditionalSigVerbiageType { get { return _additionalSigVerbiageType; } set { _additionalSigVerbiageType = value; } }
        private DirtyList<AdditionalStateDisclosure> _additionalStateDisclosures;
        public IList<AdditionalStateDisclosure> AdditionalStateDisclosures { get { var v = _additionalStateDisclosures; return v ?? Interlocked.CompareExchange(ref _additionalStateDisclosures, (v = new DirtyList<AdditionalStateDisclosure>()), null) ?? v; } set { _additionalStateDisclosures = new DirtyList<AdditionalStateDisclosure>(value); } }
        private Value<bool?> _affectedByInterest;
        public bool? AffectedByInterest { get { return _affectedByInterest; } set { _affectedByInterest = value; } }
        private Value<string> _alternateLender;
        public string AlternateLender { get { return _alternateLender; } set { _alternateLender = value; } }
        private Value<string> _altLenderId;
        public string AltLenderId { get { return _altLenderId; } set { _altLenderId = value; } }
        private DirtyList<AntiSteeringLoanOption> _antiSteeringLoanOptions;
        public IList<AntiSteeringLoanOption> AntiSteeringLoanOptions { get { var v = _antiSteeringLoanOptions; return v ?? Interlocked.CompareExchange(ref _antiSteeringLoanOptions, (v = new DirtyList<AntiSteeringLoanOption>()), null) ?? v; } set { _antiSteeringLoanOptions = new DirtyList<AntiSteeringLoanOption>(value); } }
        private Value<string> _areAbleToServiceIndicator;
        public string AreAbleToServiceIndicator { get { return _areAbleToServiceIndicator; } set { _areAbleToServiceIndicator = value; } }
        private Value<string> _associatedDocumentNumber;
        public string AssociatedDocumentNumber { get { return _associatedDocumentNumber; } set { _associatedDocumentNumber = value; } }
        private Value<string> _beneficiaries;
        public string Beneficiaries { get { return _beneficiaries; } set { _beneficiaries = value; } }
        private Value<bool?> _borrowerConsentType1;
        public bool? BorrowerConsentType1 { get { return _borrowerConsentType1; } set { _borrowerConsentType1 = value; } }
        private Value<bool?> _borrowerConsentType2;
        public bool? BorrowerConsentType2 { get { return _borrowerConsentType2; } set { _borrowerConsentType2 = value; } }
        private Value<string> _borrowerOrganizationType1;
        public string BorrowerOrganizationType1 { get { return _borrowerOrganizationType1; } set { _borrowerOrganizationType1 = value; } }
        private Value<string> _borrowerOrganizationType2;
        public string BorrowerOrganizationType2 { get { return _borrowerOrganizationType2; } set { _borrowerOrganizationType2 = value; } }
        private Value<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName1;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get { return _borrowerOrganizedUnderTheLawsOfJurisdictionName1; } set { _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = value; } }
        private Value<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName2;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get { return _borrowerOrganizedUnderTheLawsOfJurisdictionName2; } set { _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = value; } }
        private Value<string> _borrowerTaxIdentificationNumberIdentifier1;
        public string BorrowerTaxIdentificationNumberIdentifier1 { get { return _borrowerTaxIdentificationNumberIdentifier1; } set { _borrowerTaxIdentificationNumberIdentifier1 = value; } }
        private Value<string> _borrowerTaxIdentificationNumberIdentifier2;
        public string BorrowerTaxIdentificationNumberIdentifier2 { get { return _borrowerTaxIdentificationNumberIdentifier2; } set { _borrowerTaxIdentificationNumberIdentifier2 = value; } }
        private Value<string> _borrowerTrustAmendedDateOrYear1;
        public string BorrowerTrustAmendedDateOrYear1 { get { return _borrowerTrustAmendedDateOrYear1; } set { _borrowerTrustAmendedDateOrYear1 = value; } }
        private Value<string> _borrowerTrustAmendedDateOrYear2;
        public string BorrowerTrustAmendedDateOrYear2 { get { return _borrowerTrustAmendedDateOrYear2; } set { _borrowerTrustAmendedDateOrYear2 = value; } }
        private Value<string> _borrowerTrustDateOrYear1;
        public string BorrowerTrustDateOrYear1 { get { return _borrowerTrustDateOrYear1; } set { _borrowerTrustDateOrYear1 = value; } }
        private Value<string> _borrowerTrustDateOrYear2;
        public string BorrowerTrustDateOrYear2 { get { return _borrowerTrustDateOrYear2; } set { _borrowerTrustDateOrYear2 = value; } }
        private Value<string> _borrowerUnparsedName1;
        public string BorrowerUnparsedName1 { get { return _borrowerUnparsedName1; } set { _borrowerUnparsedName1 = value; } }
        private Value<string> _borrowerUnparsedName2;
        public string BorrowerUnparsedName2 { get { return _borrowerUnparsedName2; } set { _borrowerUnparsedName2 = value; } }
        private Value<string> _brokerAuthorizedRepresentativeTitle;
        public string BrokerAuthorizedRepresentativeTitle { get { return _brokerAuthorizedRepresentativeTitle; } set { _brokerAuthorizedRepresentativeTitle = value; } }
        private Value<string> _brokerCompensationMethod;
        public string BrokerCompensationMethod { get { return _brokerCompensationMethod; } set { _brokerCompensationMethod = value; } }
        private Value<string> _brokerFeeRefundConditions1;
        public string BrokerFeeRefundConditions1 { get { return _brokerFeeRefundConditions1; } set { _brokerFeeRefundConditions1 = value; } }
        private Value<string> _brokerFeeRefundConditions2;
        public string BrokerFeeRefundConditions2 { get { return _brokerFeeRefundConditions2; } set { _brokerFeeRefundConditions2 = value; } }
        private Value<string> _brokerFeeRefundConditions3;
        public string BrokerFeeRefundConditions3 { get { return _brokerFeeRefundConditions3; } set { _brokerFeeRefundConditions3 = value; } }
        private Value<string> _brokerForPlacingLoan;
        public string BrokerForPlacingLoan { get { return _brokerForPlacingLoan; } set { _brokerForPlacingLoan = value; } }
        private Value<string> _brokerInterestRateEffect;
        public string BrokerInterestRateEffect { get { return _brokerInterestRateEffect; } set { _brokerInterestRateEffect = value; } }
        private Value<string> _brokerLenderRelationship;
        public string BrokerLenderRelationship { get { return _brokerLenderRelationship; } set { _brokerLenderRelationship = value; } }
        private Value<string> _brokerLicenseNumberIdentifier;
        public string BrokerLicenseNumberIdentifier { get { return _brokerLicenseNumberIdentifier; } set { _brokerLicenseNumberIdentifier = value; } }
        private Value<string> _brokerNameAsLicensed;
        public string BrokerNameAsLicensed { get { return _brokerNameAsLicensed; } set { _brokerNameAsLicensed = value; } }
        private Value<string> _brokerTaxIdentificationNumberIdentifier;
        public string BrokerTaxIdentificationNumberIdentifier { get { return _brokerTaxIdentificationNumberIdentifier; } set { _brokerTaxIdentificationNumberIdentifier = value; } }
        private Value<string> _brokerWithLenders;
        public string BrokerWithLenders { get { return _brokerWithLenders; } set { _brokerWithLenders = value; } }
        private Value<decimal?> _cashCheckFromBorrower;
        public decimal? CashCheckFromBorrower { get { return _cashCheckFromBorrower; } set { _cashCheckFromBorrower = value; } }
        private Value<DateTime?> _cLClearCloseStatusReceivedByLenderDateTime;
        public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get { return _cLClearCloseStatusReceivedByLenderDateTime; } set { _cLClearCloseStatusReceivedByLenderDateTime = value; } }
        private Value<DateTime?> _cLClosingEscrowOrderAcceptedDateTime;
        public DateTime? CLClosingEscrowOrderAcceptedDateTime { get { return _cLClosingEscrowOrderAcceptedDateTime; } set { _cLClosingEscrowOrderAcceptedDateTime = value; } }
        private Value<DateTime?> _cLClosingEscrowOrderSentDateTime;
        public DateTime? CLClosingEscrowOrderSentDateTime { get { return _cLClosingEscrowOrderSentDateTime; } set { _cLClosingEscrowOrderSentDateTime = value; } }
        private Value<DateTime?> _cLDraftClosingDisclosureReceivedByLenderDateTime;
        public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get { return _cLDraftClosingDisclosureReceivedByLenderDateTime; } set { _cLDraftClosingDisclosureReceivedByLenderDateTime = value; } }
        private Value<DateTime?> _cLFinalCDSentDateTime;
        public DateTime? CLFinalCDSentDateTime { get { return _cLFinalCDSentDateTime; } set { _cLFinalCDSentDateTime = value; } }
        private Value<DateTime?> _cLFinalTitlePolicyDateTime;
        public DateTime? CLFinalTitlePolicyDateTime { get { return _cLFinalTitlePolicyDateTime; } set { _cLFinalTitlePolicyDateTime = value; } }
        private Value<DateTime?> _cLLastFeeQuoteReceivedDateTime;
        public DateTime? CLLastFeeQuoteReceivedDateTime { get { return _cLLastFeeQuoteReceivedDateTime; } set { _cLLastFeeQuoteReceivedDateTime = value; } }
        private Value<DateTime?> _cLLastFeeQuoteRequestedDateTime;
        public DateTime? CLLastFeeQuoteRequestedDateTime { get { return _cLLastFeeQuoteRequestedDateTime; } set { _cLLastFeeQuoteRequestedDateTime = value; } }
        private Value<string> _closingDocsLoanProgramType;
        public string ClosingDocsLoanProgramType { get { return _closingDocsLoanProgramType; } set { _closingDocsLoanProgramType = value; } }
        private DirtyList<ClosingEntity> _closingEntities;
        public IList<ClosingEntity> ClosingEntities { get { var v = _closingEntities; return v ?? Interlocked.CompareExchange(ref _closingEntities, (v = new DirtyList<ClosingEntity>()), null) ?? v; } set { _closingEntities = new DirtyList<ClosingEntity>(value); } }
        private Value<string> _closingProvider;
        public string ClosingProvider { get { return _closingProvider; } set { _closingProvider = value; } }
        private Value<string> _closingState;
        public string ClosingState { get { return _closingState; } set { _closingState = value; } }
        private Value<DateTime?> _cLPayoffsRequestedDateTime;
        public DateTime? CLPayoffsRequestedDateTime { get { return _cLPayoffsRequestedDateTime; } set { _cLPayoffsRequestedDateTime = value; } }
        private Value<DateTime?> _cLPrelimCommitmentReceivedByLenderDateTime;
        public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get { return _cLPrelimCommitmentReceivedByLenderDateTime; } set { _cLPrelimCommitmentReceivedByLenderDateTime = value; } }
        private Value<DateTime?> _cLProviderDisburseFundsDateTime;
        public DateTime? CLProviderDisburseFundsDateTime { get { return _cLProviderDisburseFundsDateTime; } set { _cLProviderDisburseFundsDateTime = value; } }
        private Value<DateTime?> _cLTitleOrderAcceptedDateTime;
        public DateTime? CLTitleOrderAcceptedDateTime { get { return _cLTitleOrderAcceptedDateTime; } set { _cLTitleOrderAcceptedDateTime = value; } }
        private Value<DateTime?> _cLTitleOrderSentDateTime;
        public DateTime? CLTitleOrderSentDateTime { get { return _cLTitleOrderSentDateTime; } set { _cLTitleOrderSentDateTime = value; } }
        private Value<string> _complianceJurisdictionCounty;
        public string ComplianceJurisdictionCounty { get { return _complianceJurisdictionCounty; } set { _complianceJurisdictionCounty = value; } }
        private Value<DateTime?> _compliancePropertyIdentifiedDate;
        public DateTime? CompliancePropertyIdentifiedDate { get { return _compliancePropertyIdentifiedDate; } set { _compliancePropertyIdentifiedDate = value; } }
        private Value<string> _conditionDescription;
        public string ConditionDescription { get { return _conditionDescription; } set { _conditionDescription = value; } }
        private Value<bool?> _conflictofInterestCheck1;
        public bool? ConflictofInterestCheck1 { get { return _conflictofInterestCheck1; } set { _conflictofInterestCheck1 = value; } }
        private Value<bool?> _conflictofInterestCheck2;
        public bool? ConflictofInterestCheck2 { get { return _conflictofInterestCheck2; } set { _conflictofInterestCheck2 = value; } }
        private Value<bool?> _conflictofInterestCheck3;
        public bool? ConflictofInterestCheck3 { get { return _conflictofInterestCheck3; } set { _conflictofInterestCheck3 = value; } }
        private Value<bool?> _conflictofInterestCheck4;
        public bool? ConflictofInterestCheck4 { get { return _conflictofInterestCheck4; } set { _conflictofInterestCheck4 = value; } }
        private Value<bool?> _conflictofInterestCheck5;
        public bool? ConflictofInterestCheck5 { get { return _conflictofInterestCheck5; } set { _conflictofInterestCheck5 = value; } }
        private Value<bool?> _conflictofInterestCheck6;
        public bool? ConflictofInterestCheck6 { get { return _conflictofInterestCheck6; } set { _conflictofInterestCheck6 = value; } }
        private Value<string> _coopApartmentNumber;
        public string CoopApartmentNumber { get { return _coopApartmentNumber; } set { _coopApartmentNumber = value; } }
        private Value<DateTime?> _coopAssignmentLeaseDate;
        public DateTime? CoopAssignmentLeaseDate { get { return _coopAssignmentLeaseDate; } set { _coopAssignmentLeaseDate = value; } }
        private Value<string> _coopAttorneyInFact;
        public string CoopAttorneyInFact { get { return _coopAttorneyInFact; } set { _coopAttorneyInFact = value; } }
        private Value<string> _coopBuildingName;
        public string CoopBuildingName { get { return _coopBuildingName; } set { _coopBuildingName = value; } }
        private Value<string> _coopCompanyExistsUnderTHeLawsOf;
        public string CoopCompanyExistsUnderTHeLawsOf { get { return _coopCompanyExistsUnderTHeLawsOf; } set { _coopCompanyExistsUnderTHeLawsOf = value; } }
        private Value<string> _coopCompanyName;
        public string CoopCompanyName { get { return _coopCompanyName; } set { _coopCompanyName = value; } }
        private Value<DateTime?> _coopProprietaryLeaseDate;
        public DateTime? CoopProprietaryLeaseDate { get { return _coopProprietaryLeaseDate; } set { _coopProprietaryLeaseDate = value; } }
        private Value<decimal?> _coopSharesOwned;
        public decimal? CoopSharesOwned { get { return _coopSharesOwned; } set { _coopSharesOwned = value; } }
        private Value<string> _coopStockCertificationNumber;
        public string CoopStockCertificationNumber { get { return _coopStockCertificationNumber; } set { _coopStockCertificationNumber = value; } }
        private Value<decimal?> _coopVacancyPercentNotification;
        public decimal? CoopVacancyPercentNotification { get { return _coopVacancyPercentNotification; } set { _coopVacancyPercentNotification = value; } }
        private Value<string> _customOtherRiderDescription;
        public string CustomOtherRiderDescription { get { return _customOtherRiderDescription; } set { _customOtherRiderDescription = value; } }
        private Value<DateTime?> _disbursementDate;
        public DateTime? DisbursementDate { get { return _disbursementDate; } set { _disbursementDate = value; } }
        private Value<decimal?> _disbursementsToBorrower;
        public decimal? DisbursementsToBorrower { get { return _disbursementsToBorrower; } set { _disbursementsToBorrower = value; } }
        private Value<string> _disclosureAlternateLender;
        public string DisclosureAlternateLender { get { return _disclosureAlternateLender; } set { _disclosureAlternateLender = value; } }
        private Value<string> _disclosureCompanyFunction;
        public string DisclosureCompanyFunction { get { return _disclosureCompanyFunction; } set { _disclosureCompanyFunction = value; } }
        private Value<string> _disclosurePlanCode;
        public string DisclosurePlanCode { get { return _disclosurePlanCode; } set { _disclosurePlanCode = value; } }
        private Value<string> _docReportGUID;
        public string DocReportGUID { get { return _docReportGUID; } set { _docReportGUID = value; } }
        private Value<DateTime?> _documentPreparationDate;
        public DateTime? DocumentPreparationDate { get { return _documentPreparationDate; } set { _documentPreparationDate = value; } }
        private Value<DateTime?> _documentSigningDate;
        public DateTime? DocumentSigningDate { get { return _documentSigningDate; } set { _documentSigningDate = value; } }
        private Value<string> _drawCity;
        public string DrawCity { get { return _drawCity; } set { _drawCity = value; } }
        private Value<string> _drawCounty;
        public string DrawCounty { get { return _drawCounty; } set { _drawCounty = value; } }
        private Value<string> _drawState;
        public string DrawState { get { return _drawState; } set { _drawState = value; } }
        private Value<string> _employeeofMortgageLender;
        public string EmployeeofMortgageLender { get { return _employeeofMortgageLender; } set { _employeeofMortgageLender = value; } }
        private Value<string> _expectToAssignSellOrTransferPercent;
        public string ExpectToAssignSellOrTransferPercent { get { return _expectToAssignSellOrTransferPercent; } set { _expectToAssignSellOrTransferPercent = value; } }
        private Value<string> _finalVestingDescription;
        public string FinalVestingDescription { get { return _finalVestingDescription; } set { _finalVestingDescription = value; } }
        private Value<string> _firstTransferYear;
        public string FirstTransferYear { get { return _firstTransferYear; } set { _firstTransferYear = value; } }
        private Value<decimal?> _firstTransferYearValue;
        public decimal? FirstTransferYearValue { get { return _firstTransferYearValue; } set { _firstTransferYearValue = value; } }
        private Value<string> _hoursDocumentsNeededPriorToDisbursementCount;
        public string HoursDocumentsNeededPriorToDisbursementCount { get { return _hoursDocumentsNeededPriorToDisbursementCount; } set { _hoursDocumentsNeededPriorToDisbursementCount = value; } }
        private Value<bool?> _housingIndicator;
        public bool? HousingIndicator { get { return _housingIndicator; } set { _housingIndicator = value; } }
        private Value<string> _housingProgramName;
        public string HousingProgramName { get { return _housingProgramName; } set { _housingProgramName = value; } }
        private Value<string> _hUD1FileNumberIdentifier;
        public string HUD1FileNumberIdentifier { get { return _hUD1FileNumberIdentifier; } set { _hUD1FileNumberIdentifier = value; } }
        private Value<string> _hUD1SettlementAgentUnparsedAddress;
        public string HUD1SettlementAgentUnparsedAddress { get { return _hUD1SettlementAgentUnparsedAddress; } set { _hUD1SettlementAgentUnparsedAddress = value; } }
        private Value<string> _hUD1SettlementAgentUnparsedName;
        public string HUD1SettlementAgentUnparsedName { get { return _hUD1SettlementAgentUnparsedName; } set { _hUD1SettlementAgentUnparsedName = value; } }
        private Value<DateTime?> _hUD1SettlementDate;
        public DateTime? HUD1SettlementDate { get { return _hUD1SettlementDate; } set { _hUD1SettlementDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _includeSafeHaborDisclosure;
        public decimal? IncludeSafeHaborDisclosure { get { return _includeSafeHaborDisclosure; } set { _includeSafeHaborDisclosure = value; } }
        private Value<string> _investorCode;
        public string InvestorCode { get { return _investorCode; } set { _investorCode = value; } }
        private Value<string> _lastAuditDate;
        public string LastAuditDate { get { return _lastAuditDate; } set { _lastAuditDate = value; } }
        private Value<string> _lastDocumentOrdered;
        public string LastDocumentOrdered { get { return _lastDocumentOrdered; } set { _lastDocumentOrdered = value; } }
        private Value<bool?> _legalAttached;
        public bool? LegalAttached { get { return _legalAttached; } set { _legalAttached = value; } }
        private Value<string> _lenderAuthorizedRepresentativeTitle;
        public string LenderAuthorizedRepresentativeTitle { get { return _lenderAuthorizedRepresentativeTitle; } set { _lenderAuthorizedRepresentativeTitle = value; } }
        private Value<string> _lenderBrokerRepresents;
        public string LenderBrokerRepresents { get { return _lenderBrokerRepresents; } set { _lenderBrokerRepresents = value; } }
        private Value<string> _lienHolderAddress;
        public string LienHolderAddress { get { return _lienHolderAddress; } set { _lienHolderAddress = value; } }
        private Value<string> _lienHolderAddressCity;
        public string LienHolderAddressCity { get { return _lienHolderAddressCity; } set { _lienHolderAddressCity = value; } }
        private Value<string> _lienHolderAddressPostalCode;
        public string LienHolderAddressPostalCode { get { return _lienHolderAddressPostalCode; } set { _lienHolderAddressPostalCode = value; } }
        private Value<string> _lienHolderAddressState;
        public string LienHolderAddressState { get { return _lienHolderAddressState; } set { _lienHolderAddressState = value; } }
        private Value<string> _lienHolderName;
        public string LienHolderName { get { return _lienHolderName; } set { _lienHolderName = value; } }
        private Value<bool?> _loanIsLocked;
        public bool? LoanIsLocked { get { return _loanIsLocked; } set { _loanIsLocked = value; } }
        private Value<string> _loanOption;
        public string LoanOption { get { return _loanOption; } set { _loanOption = value; } }
        private Value<string> _lockInFeeType;
        public string LockInFeeType { get { return _lockInFeeType; } set { _lockInFeeType = value; } }
        private Value<string> _mfgHomeAnchored;
        public string MfgHomeAnchored { get { return _mfgHomeAnchored; } set { _mfgHomeAnchored = value; } }
        private Value<string> _mfgHomeCertificateOfTitleIdentifier;
        public string MfgHomeCertificateOfTitleIdentifier { get { return _mfgHomeCertificateOfTitleIdentifier; } set { _mfgHomeCertificateOfTitleIdentifier = value; } }
        private Value<string> _mfgHomeCertificateOfTitleType;
        public string MfgHomeCertificateOfTitleType { get { return _mfgHomeCertificateOfTitleType; } set { _mfgHomeCertificateOfTitleType = value; } }
        private Value<string> _mfgHomeDescription;
        public string MfgHomeDescription { get { return _mfgHomeDescription; } set { _mfgHomeDescription = value; } }
        private Value<string> _mfgHomeHUDCertificationLabelIdentifier;
        public string MfgHomeHUDCertificationLabelIdentifier { get { return _mfgHomeHUDCertificationLabelIdentifier; } set { _mfgHomeHUDCertificationLabelIdentifier = value; } }
        private Value<int?> _mfgHomeLengthFeetCount;
        public int? MfgHomeLengthFeetCount { get { return _mfgHomeLengthFeetCount; } set { _mfgHomeLengthFeetCount = value; } }
        private Value<string> _mfgHomeMakeIdentifier;
        public string MfgHomeMakeIdentifier { get { return _mfgHomeMakeIdentifier; } set { _mfgHomeMakeIdentifier = value; } }
        private Value<string> _mfgHomeManufacturer;
        public string MfgHomeManufacturer { get { return _mfgHomeManufacturer; } set { _mfgHomeManufacturer = value; } }
        private Value<string> _mfgHomeManufacturerAddress;
        public string MfgHomeManufacturerAddress { get { return _mfgHomeManufacturerAddress; } set { _mfgHomeManufacturerAddress = value; } }
        private Value<string> _mfgHomeManufacturerCity;
        public string MfgHomeManufacturerCity { get { return _mfgHomeManufacturerCity; } set { _mfgHomeManufacturerCity = value; } }
        private Value<string> _mfgHomeManufacturerPhoneNumber;
        public string MfgHomeManufacturerPhoneNumber { get { return _mfgHomeManufacturerPhoneNumber; } set { _mfgHomeManufacturerPhoneNumber = value; } }
        private Value<string> _mfgHomeManufacturerPostalCode;
        public string MfgHomeManufacturerPostalCode { get { return _mfgHomeManufacturerPostalCode; } set { _mfgHomeManufacturerPostalCode = value; } }
        private Value<string> _mfgHomeManufacturerState;
        public string MfgHomeManufacturerState { get { return _mfgHomeManufacturerState; } set { _mfgHomeManufacturerState = value; } }
        private Value<int?> _mfgHomeManufactureYear;
        public int? MfgHomeManufactureYear { get { return _mfgHomeManufactureYear; } set { _mfgHomeManufactureYear = value; } }
        private Value<string> _mfgHomeModelIdentifier;
        public string MfgHomeModelIdentifier { get { return _mfgHomeModelIdentifier; } set { _mfgHomeModelIdentifier = value; } }
        private Value<string> _mfgHomeNewOrUsed;
        public string MfgHomeNewOrUsed { get { return _mfgHomeNewOrUsed; } set { _mfgHomeNewOrUsed = value; } }
        private Value<string> _mfgHomeSerialNumberIdentifier;
        public string MfgHomeSerialNumberIdentifier { get { return _mfgHomeSerialNumberIdentifier; } set { _mfgHomeSerialNumberIdentifier = value; } }
        private Value<int?> _mfgHomeWidthFeetCount;
        public int? MfgHomeWidthFeetCount { get { return _mfgHomeWidthFeetCount; } set { _mfgHomeWidthFeetCount = value; } }
        private Value<string> _mineralRightsDescription;
        public string MineralRightsDescription { get { return _mineralRightsDescription; } set { _mineralRightsDescription = value; } }
        private Value<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        private Value<int?> _numberBrokerAgreements;
        public int? NumberBrokerAgreements { get { return _numberBrokerAgreements; } set { _numberBrokerAgreements = value; } }
        private Value<int?> _numberSuccessfulBrokerAgreements;
        public int? NumberSuccessfulBrokerAgreements { get { return _numberSuccessfulBrokerAgreements; } set { _numberSuccessfulBrokerAgreements = value; } }
        private Value<string> _officeOfRecordationName;
        public string OfficeOfRecordationName { get { return _officeOfRecordationName; } set { _officeOfRecordationName = value; } }
        private Value<bool?> _onlyOneEntity;
        public bool? OnlyOneEntity { get { return _onlyOneEntity; } set { _onlyOneEntity = value; } }
        private Value<string> _optionSelectedReason;
        public string OptionSelectedReason { get { return _optionSelectedReason; } set { _optionSelectedReason = value; } }
        private Value<decimal?> _originalPincipalAmountSecured;
        public decimal? OriginalPincipalAmountSecured { get { return _originalPincipalAmountSecured; } set { _originalPincipalAmountSecured = value; } }
        private Value<string> _otherOptionDescription;
        public string OtherOptionDescription { get { return _otherOptionDescription; } set { _otherOptionDescription = value; } }
        private Value<string> _parentAffiliatedCoName;
        public string ParentAffiliatedCoName { get { return _parentAffiliatedCoName; } set { _parentAffiliatedCoName = value; } }
        private Value<string> _payToTheOrderOfDescription;
        public string PayToTheOrderOfDescription { get { return _payToTheOrderOfDescription; } set { _payToTheOrderOfDescription = value; } }
        private Value<string> _perDiemCalculationMethodType;
        public string PerDiemCalculationMethodType { get { return _perDiemCalculationMethodType; } set { _perDiemCalculationMethodType = value; } }
        private Value<string> _planCode;
        public string PlanCode { get { return _planCode; } set { _planCode = value; } }
        private Value<string> _planCodeDescription;
        public string PlanCodeDescription { get { return _planCodeDescription; } set { _planCodeDescription = value; } }
        private Value<string> _planCodeId;
        public string PlanCodeId { get { return _planCodeId; } set { _planCodeId = value; } }
        private Value<DateTime?> _preliminaryTitleReportDate;
        public DateTime? PreliminaryTitleReportDate { get { return _preliminaryTitleReportDate; } set { _preliminaryTitleReportDate = value; } }
        private Value<string> _prepaymentPenaltyDescriptions1;
        public string PrepaymentPenaltyDescriptions1 { get { return _prepaymentPenaltyDescriptions1; } set { _prepaymentPenaltyDescriptions1 = value; } }
        private Value<string> _prepaymentPenaltyDescriptions2;
        public string PrepaymentPenaltyDescriptions2 { get { return _prepaymentPenaltyDescriptions2; } set { _prepaymentPenaltyDescriptions2 = value; } }
        private Value<string> _prepaymentPenaltyDescriptions3;
        public string PrepaymentPenaltyDescriptions3 { get { return _prepaymentPenaltyDescriptions3; } set { _prepaymentPenaltyDescriptions3 = value; } }
        private Value<int?> _processingNumberDays;
        public int? ProcessingNumberDays { get { return _processingNumberDays; } set { _processingNumberDays = value; } }
        private Value<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        private Value<string> _programSponsor;
        public string ProgramSponsor { get { return _programSponsor; } set { _programSponsor = value; } }
        private Value<bool?> _propertyIsLandTrust;
        public bool? PropertyIsLandTrust { get { return _propertyIsLandTrust; } set { _propertyIsLandTrust = value; } }
        private Value<string> _propertyTaxMessageDescription;
        public string PropertyTaxMessageDescription { get { return _propertyTaxMessageDescription; } set { _propertyTaxMessageDescription = value; } }
        private Value<string> _rateLockRefundConditions1;
        public string RateLockRefundConditions1 { get { return _rateLockRefundConditions1; } set { _rateLockRefundConditions1 = value; } }
        private Value<string> _rateLockRefundConditions2;
        public string RateLockRefundConditions2 { get { return _rateLockRefundConditions2; } set { _rateLockRefundConditions2 = value; } }
        private Value<string> _rateLockRefundConditions3;
        public string RateLockRefundConditions3 { get { return _rateLockRefundConditions3; } set { _rateLockRefundConditions3 = value; } }
        private Value<string> _recordingJurisdictionName;
        public string RecordingJurisdictionName { get { return _recordingJurisdictionName; } set { _recordingJurisdictionName = value; } }
        private Value<bool?> _refinanceBalloonMortgageGuarantee;
        public bool? RefinanceBalloonMortgageGuarantee { get { return _refinanceBalloonMortgageGuarantee; } set { _refinanceBalloonMortgageGuarantee = value; } }
        private Value<bool?> _refinanceRightOfRescissionExemptFlag;
        public bool? RefinanceRightOfRescissionExemptFlag { get { return _refinanceRightOfRescissionExemptFlag; } set { _refinanceRightOfRescissionExemptFlag = value; } }
        private Value<string> _renewalExtensionDescription;
        public string RenewalExtensionDescription { get { return _renewalExtensionDescription; } set { _renewalExtensionDescription = value; } }
        private Value<DateTime?> _rescissionDate;
        public DateTime? RescissionDate { get { return _rescissionDate; } set { _rescissionDate = value; } }
        private DirtyList<RespaHudDetail> _respaHudDetails;
        public IList<RespaHudDetail> RespaHudDetails { get { var v = _respaHudDetails; return v ?? Interlocked.CompareExchange(ref _respaHudDetails, (v = new DirtyList<RespaHudDetail>()), null) ?? v; } set { _respaHudDetails = new DirtyList<RespaHudDetail>(value); } }
        private Value<string> _rMLANamePreceding10Years;
        public string RMLANamePreceding10Years { get { return _rMLANamePreceding10Years; } set { _rMLANamePreceding10Years = value; } }
        private Value<string> _rmlLenderBrokerRepresents;
        public string RmlLenderBrokerRepresents { get { return _rmlLenderBrokerRepresents; } set { _rmlLenderBrokerRepresents = value; } }
        private Value<string> _secondTransferYear;
        public string SecondTransferYear { get { return _secondTransferYear; } set { _secondTransferYear = value; } }
        private Value<decimal?> _secondTransferYearValue;
        public decimal? SecondTransferYearValue { get { return _secondTransferYearValue; } set { _secondTransferYearValue = value; } }
        private Value<DateTime?> _signatureDateFor1003;
        public DateTime? SignatureDateFor1003 { get { return _signatureDateFor1003; } set { _signatureDateFor1003 = value; } }
        private Value<string> _specialFloodHazardAreaIndictor;
        public string SpecialFloodHazardAreaIndictor { get { return _specialFloodHazardAreaIndictor; } set { _specialFloodHazardAreaIndictor = value; } }
        private DirtyList<StateLicense> _stateLicenses;
        public IList<StateLicense> StateLicenses { get { var v = _stateLicenses; return v ?? Interlocked.CompareExchange(ref _stateLicenses, (v = new DirtyList<StateLicense>()), null) ?? v; } set { _stateLicenses = new DirtyList<StateLicense>(value); } }
        private Value<string> _suretyCompanyName;
        public string SuretyCompanyName { get { return _suretyCompanyName; } set { _suretyCompanyName = value; } }
        private Value<bool?> _syncInterestDateDisbursementDate;
        public bool? SyncInterestDateDisbursementDate { get { return _syncInterestDateDisbursementDate; } set { _syncInterestDateDisbursementDate = value; } }
        private Value<string> _termiteReportRequiredIndicator;
        public string TermiteReportRequiredIndicator { get { return _termiteReportRequiredIndicator; } set { _termiteReportRequiredIndicator = value; } }
        private Value<string> _textDescription;
        public string TextDescription { get { return _textDescription; } set { _textDescription = value; } }
        private Value<string> _thirdTransferYear;
        public string ThirdTransferYear { get { return _thirdTransferYear; } set { _thirdTransferYear = value; } }
        private Value<decimal?> _thirdTransferYearValue;
        public decimal? ThirdTransferYearValue { get { return _thirdTransferYearValue; } set { _thirdTransferYearValue = value; } }
        private Value<string> _titleReportItemsDescription;
        public string TitleReportItemsDescription { get { return _titleReportItemsDescription; } set { _titleReportItemsDescription = value; } }
        private Value<string> _titleReportRequiredEndorsementsDescription;
        public string TitleReportRequiredEndorsementsDescription { get { return _titleReportRequiredEndorsementsDescription; } set { _titleReportRequiredEndorsementsDescription = value; } }
        private Value<decimal?> _totalDisbursed;
        public decimal? TotalDisbursed { get { return _totalDisbursed; } set { _totalDisbursed = value; } }
        private Value<string> _trust2Beneficiaries;
        public string Trust2Beneficiaries { get { return _trust2Beneficiaries; } set { _trust2Beneficiaries = value; } }
        private Value<string> _weConductBusiness;
        public string WeConductBusiness { get { return _weConductBusiness; } set { _weConductBusiness = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _stateLicenses?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}