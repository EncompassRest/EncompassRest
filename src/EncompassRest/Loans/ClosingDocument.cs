using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDocument : IClean
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
        private Value<List<AdditionalStateDisclosure>> _additionalStateDisclosures;
        public List<AdditionalStateDisclosure> AdditionalStateDisclosures { get { return _additionalStateDisclosures; } set { _additionalStateDisclosures = value; } }
        private Value<bool?> _affectedByInterest;
        public bool? AffectedByInterest { get { return _affectedByInterest; } set { _affectedByInterest = value; } }
        private Value<string> _alternateLender;
        public string AlternateLender { get { return _alternateLender; } set { _alternateLender = value; } }
        private Value<string> _altLenderId;
        public string AltLenderId { get { return _altLenderId; } set { _altLenderId = value; } }
        private Value<List<AntiSteeringLoanOption>> _antiSteeringLoanOptions;
        public List<AntiSteeringLoanOption> AntiSteeringLoanOptions { get { return _antiSteeringLoanOptions; } set { _antiSteeringLoanOptions = value; } }
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
        private Value<string> _closingDocsLoanProgramType;
        public string ClosingDocsLoanProgramType { get { return _closingDocsLoanProgramType; } set { _closingDocsLoanProgramType = value; } }
        private Value<List<ClosingEntity>> _closingEntities;
        public List<ClosingEntity> ClosingEntities { get { return _closingEntities; } set { _closingEntities = value; } }
        private Value<string> _closingProvider;
        public string ClosingProvider { get { return _closingProvider; } set { _closingProvider = value; } }
        private Value<string> _closingState;
        public string ClosingState { get { return _closingState; } set { _closingState = value; } }
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
        private Value<List<RespaHudDetail>> _respaHudDetails;
        public List<RespaHudDetail> RespaHudDetails { get { return _respaHudDetails; } set { _respaHudDetails = value; } }
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
        private Value<List<StateLicense>> _stateLicenses;
        public List<StateLicense> StateLicenses { get { return _stateLicenses; } set { _stateLicenses = value; } }
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalLienHolderAddress.Clean
                    && _additionalLienHolderAddressCity.Clean
                    && _additionalLienHolderAddressPostalCode.Clean
                    && _additionalLienHolderAddressState.Clean
                    && _additionalLienHolderName.Clean
                    && _additionalOriginalPincipalAmountSecured.Clean
                    && _additionalSigVerbiageType.Clean
                    && _additionalStateDisclosures.Clean
                    && _affectedByInterest.Clean
                    && _alternateLender.Clean
                    && _altLenderId.Clean
                    && _antiSteeringLoanOptions.Clean
                    && _areAbleToServiceIndicator.Clean
                    && _associatedDocumentNumber.Clean
                    && _beneficiaries.Clean
                    && _borrowerConsentType1.Clean
                    && _borrowerConsentType2.Clean
                    && _borrowerOrganizationType1.Clean
                    && _borrowerOrganizationType2.Clean
                    && _borrowerOrganizedUnderTheLawsOfJurisdictionName1.Clean
                    && _borrowerOrganizedUnderTheLawsOfJurisdictionName2.Clean
                    && _borrowerTaxIdentificationNumberIdentifier1.Clean
                    && _borrowerTaxIdentificationNumberIdentifier2.Clean
                    && _borrowerTrustAmendedDateOrYear1.Clean
                    && _borrowerTrustAmendedDateOrYear2.Clean
                    && _borrowerTrustDateOrYear1.Clean
                    && _borrowerTrustDateOrYear2.Clean
                    && _borrowerUnparsedName1.Clean
                    && _borrowerUnparsedName2.Clean
                    && _brokerAuthorizedRepresentativeTitle.Clean
                    && _brokerCompensationMethod.Clean
                    && _brokerFeeRefundConditions1.Clean
                    && _brokerFeeRefundConditions2.Clean
                    && _brokerFeeRefundConditions3.Clean
                    && _brokerForPlacingLoan.Clean
                    && _brokerInterestRateEffect.Clean
                    && _brokerLenderRelationship.Clean
                    && _brokerLicenseNumberIdentifier.Clean
                    && _brokerNameAsLicensed.Clean
                    && _brokerTaxIdentificationNumberIdentifier.Clean
                    && _brokerWithLenders.Clean
                    && _cashCheckFromBorrower.Clean
                    && _closingDocsLoanProgramType.Clean
                    && _closingEntities.Clean
                    && _closingProvider.Clean
                    && _closingState.Clean
                    && _complianceJurisdictionCounty.Clean
                    && _compliancePropertyIdentifiedDate.Clean
                    && _conditionDescription.Clean
                    && _conflictofInterestCheck1.Clean
                    && _conflictofInterestCheck2.Clean
                    && _conflictofInterestCheck3.Clean
                    && _conflictofInterestCheck4.Clean
                    && _conflictofInterestCheck5.Clean
                    && _conflictofInterestCheck6.Clean
                    && _coopApartmentNumber.Clean
                    && _coopAssignmentLeaseDate.Clean
                    && _coopAttorneyInFact.Clean
                    && _coopBuildingName.Clean
                    && _coopCompanyExistsUnderTHeLawsOf.Clean
                    && _coopCompanyName.Clean
                    && _coopProprietaryLeaseDate.Clean
                    && _coopSharesOwned.Clean
                    && _coopStockCertificationNumber.Clean
                    && _coopVacancyPercentNotification.Clean
                    && _customOtherRiderDescription.Clean
                    && _disbursementDate.Clean
                    && _disbursementsToBorrower.Clean
                    && _disclosureAlternateLender.Clean
                    && _disclosureCompanyFunction.Clean
                    && _disclosurePlanCode.Clean
                    && _docReportGUID.Clean
                    && _documentPreparationDate.Clean
                    && _documentSigningDate.Clean
                    && _drawCity.Clean
                    && _drawCounty.Clean
                    && _drawState.Clean
                    && _employeeofMortgageLender.Clean
                    && _expectToAssignSellOrTransferPercent.Clean
                    && _finalVestingDescription.Clean
                    && _firstTransferYear.Clean
                    && _firstTransferYearValue.Clean
                    && _hoursDocumentsNeededPriorToDisbursementCount.Clean
                    && _housingIndicator.Clean
                    && _housingProgramName.Clean
                    && _hUD1FileNumberIdentifier.Clean
                    && _hUD1SettlementAgentUnparsedAddress.Clean
                    && _hUD1SettlementAgentUnparsedName.Clean
                    && _hUD1SettlementDate.Clean
                    && _id.Clean
                    && _includeSafeHaborDisclosure.Clean
                    && _investorCode.Clean
                    && _lastAuditDate.Clean
                    && _lastDocumentOrdered.Clean
                    && _legalAttached.Clean
                    && _lenderAuthorizedRepresentativeTitle.Clean
                    && _lenderBrokerRepresents.Clean
                    && _lienHolderAddress.Clean
                    && _lienHolderAddressCity.Clean
                    && _lienHolderAddressPostalCode.Clean
                    && _lienHolderAddressState.Clean
                    && _lienHolderName.Clean
                    && _loanIsLocked.Clean
                    && _loanOption.Clean
                    && _lockInFeeType.Clean
                    && _mfgHomeAnchored.Clean
                    && _mfgHomeCertificateOfTitleIdentifier.Clean
                    && _mfgHomeCertificateOfTitleType.Clean
                    && _mfgHomeDescription.Clean
                    && _mfgHomeHUDCertificationLabelIdentifier.Clean
                    && _mfgHomeLengthFeetCount.Clean
                    && _mfgHomeMakeIdentifier.Clean
                    && _mfgHomeManufacturer.Clean
                    && _mfgHomeManufacturerAddress.Clean
                    && _mfgHomeManufacturerCity.Clean
                    && _mfgHomeManufacturerPhoneNumber.Clean
                    && _mfgHomeManufacturerPostalCode.Clean
                    && _mfgHomeManufacturerState.Clean
                    && _mfgHomeManufactureYear.Clean
                    && _mfgHomeModelIdentifier.Clean
                    && _mfgHomeNewOrUsed.Clean
                    && _mfgHomeSerialNumberIdentifier.Clean
                    && _mfgHomeWidthFeetCount.Clean
                    && _mineralRightsDescription.Clean
                    && _mortgageType.Clean
                    && _numberBrokerAgreements.Clean
                    && _numberSuccessfulBrokerAgreements.Clean
                    && _officeOfRecordationName.Clean
                    && _onlyOneEntity.Clean
                    && _optionSelectedReason.Clean
                    && _originalPincipalAmountSecured.Clean
                    && _otherOptionDescription.Clean
                    && _parentAffiliatedCoName.Clean
                    && _payToTheOrderOfDescription.Clean
                    && _perDiemCalculationMethodType.Clean
                    && _planCode.Clean
                    && _planCodeDescription.Clean
                    && _planCodeId.Clean
                    && _preliminaryTitleReportDate.Clean
                    && _prepaymentPenaltyDescriptions1.Clean
                    && _prepaymentPenaltyDescriptions2.Clean
                    && _prepaymentPenaltyDescriptions3.Clean
                    && _processingNumberDays.Clean
                    && _programCode.Clean
                    && _programSponsor.Clean
                    && _propertyIsLandTrust.Clean
                    && _propertyTaxMessageDescription.Clean
                    && _rateLockRefundConditions1.Clean
                    && _rateLockRefundConditions2.Clean
                    && _rateLockRefundConditions3.Clean
                    && _recordingJurisdictionName.Clean
                    && _refinanceBalloonMortgageGuarantee.Clean
                    && _refinanceRightOfRescissionExemptFlag.Clean
                    && _renewalExtensionDescription.Clean
                    && _rescissionDate.Clean
                    && _respaHudDetails.Clean
                    && _rMLANamePreceding10Years.Clean
                    && _rmlLenderBrokerRepresents.Clean
                    && _secondTransferYear.Clean
                    && _secondTransferYearValue.Clean
                    && _signatureDateFor1003.Clean
                    && _specialFloodHazardAreaIndictor.Clean
                    && _stateLicenses.Clean
                    && _suretyCompanyName.Clean
                    && _syncInterestDateDisbursementDate.Clean
                    && _termiteReportRequiredIndicator.Clean
                    && _textDescription.Clean
                    && _thirdTransferYear.Clean
                    && _thirdTransferYearValue.Clean
                    && _titleReportItemsDescription.Clean
                    && _titleReportRequiredEndorsementsDescription.Clean
                    && _totalDisbursed.Clean
                    && _trust2Beneficiaries.Clean
                    && _weConductBusiness.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var additionalLienHolderAddress = _additionalLienHolderAddress; additionalLienHolderAddress.Clean = value; _additionalLienHolderAddress = additionalLienHolderAddress;
                var additionalLienHolderAddressCity = _additionalLienHolderAddressCity; additionalLienHolderAddressCity.Clean = value; _additionalLienHolderAddressCity = additionalLienHolderAddressCity;
                var additionalLienHolderAddressPostalCode = _additionalLienHolderAddressPostalCode; additionalLienHolderAddressPostalCode.Clean = value; _additionalLienHolderAddressPostalCode = additionalLienHolderAddressPostalCode;
                var additionalLienHolderAddressState = _additionalLienHolderAddressState; additionalLienHolderAddressState.Clean = value; _additionalLienHolderAddressState = additionalLienHolderAddressState;
                var additionalLienHolderName = _additionalLienHolderName; additionalLienHolderName.Clean = value; _additionalLienHolderName = additionalLienHolderName;
                var additionalOriginalPincipalAmountSecured = _additionalOriginalPincipalAmountSecured; additionalOriginalPincipalAmountSecured.Clean = value; _additionalOriginalPincipalAmountSecured = additionalOriginalPincipalAmountSecured;
                var additionalSigVerbiageType = _additionalSigVerbiageType; additionalSigVerbiageType.Clean = value; _additionalSigVerbiageType = additionalSigVerbiageType;
                var additionalStateDisclosures = _additionalStateDisclosures; additionalStateDisclosures.Clean = value; _additionalStateDisclosures = additionalStateDisclosures;
                var affectedByInterest = _affectedByInterest; affectedByInterest.Clean = value; _affectedByInterest = affectedByInterest;
                var alternateLender = _alternateLender; alternateLender.Clean = value; _alternateLender = alternateLender;
                var altLenderId = _altLenderId; altLenderId.Clean = value; _altLenderId = altLenderId;
                var antiSteeringLoanOptions = _antiSteeringLoanOptions; antiSteeringLoanOptions.Clean = value; _antiSteeringLoanOptions = antiSteeringLoanOptions;
                var areAbleToServiceIndicator = _areAbleToServiceIndicator; areAbleToServiceIndicator.Clean = value; _areAbleToServiceIndicator = areAbleToServiceIndicator;
                var associatedDocumentNumber = _associatedDocumentNumber; associatedDocumentNumber.Clean = value; _associatedDocumentNumber = associatedDocumentNumber;
                var beneficiaries = _beneficiaries; beneficiaries.Clean = value; _beneficiaries = beneficiaries;
                var borrowerConsentType1 = _borrowerConsentType1; borrowerConsentType1.Clean = value; _borrowerConsentType1 = borrowerConsentType1;
                var borrowerConsentType2 = _borrowerConsentType2; borrowerConsentType2.Clean = value; _borrowerConsentType2 = borrowerConsentType2;
                var borrowerOrganizationType1 = _borrowerOrganizationType1; borrowerOrganizationType1.Clean = value; _borrowerOrganizationType1 = borrowerOrganizationType1;
                var borrowerOrganizationType2 = _borrowerOrganizationType2; borrowerOrganizationType2.Clean = value; _borrowerOrganizationType2 = borrowerOrganizationType2;
                var borrowerOrganizedUnderTheLawsOfJurisdictionName1 = _borrowerOrganizedUnderTheLawsOfJurisdictionName1; borrowerOrganizedUnderTheLawsOfJurisdictionName1.Clean = value; _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = borrowerOrganizedUnderTheLawsOfJurisdictionName1;
                var borrowerOrganizedUnderTheLawsOfJurisdictionName2 = _borrowerOrganizedUnderTheLawsOfJurisdictionName2; borrowerOrganizedUnderTheLawsOfJurisdictionName2.Clean = value; _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = borrowerOrganizedUnderTheLawsOfJurisdictionName2;
                var borrowerTaxIdentificationNumberIdentifier1 = _borrowerTaxIdentificationNumberIdentifier1; borrowerTaxIdentificationNumberIdentifier1.Clean = value; _borrowerTaxIdentificationNumberIdentifier1 = borrowerTaxIdentificationNumberIdentifier1;
                var borrowerTaxIdentificationNumberIdentifier2 = _borrowerTaxIdentificationNumberIdentifier2; borrowerTaxIdentificationNumberIdentifier2.Clean = value; _borrowerTaxIdentificationNumberIdentifier2 = borrowerTaxIdentificationNumberIdentifier2;
                var borrowerTrustAmendedDateOrYear1 = _borrowerTrustAmendedDateOrYear1; borrowerTrustAmendedDateOrYear1.Clean = value; _borrowerTrustAmendedDateOrYear1 = borrowerTrustAmendedDateOrYear1;
                var borrowerTrustAmendedDateOrYear2 = _borrowerTrustAmendedDateOrYear2; borrowerTrustAmendedDateOrYear2.Clean = value; _borrowerTrustAmendedDateOrYear2 = borrowerTrustAmendedDateOrYear2;
                var borrowerTrustDateOrYear1 = _borrowerTrustDateOrYear1; borrowerTrustDateOrYear1.Clean = value; _borrowerTrustDateOrYear1 = borrowerTrustDateOrYear1;
                var borrowerTrustDateOrYear2 = _borrowerTrustDateOrYear2; borrowerTrustDateOrYear2.Clean = value; _borrowerTrustDateOrYear2 = borrowerTrustDateOrYear2;
                var borrowerUnparsedName1 = _borrowerUnparsedName1; borrowerUnparsedName1.Clean = value; _borrowerUnparsedName1 = borrowerUnparsedName1;
                var borrowerUnparsedName2 = _borrowerUnparsedName2; borrowerUnparsedName2.Clean = value; _borrowerUnparsedName2 = borrowerUnparsedName2;
                var brokerAuthorizedRepresentativeTitle = _brokerAuthorizedRepresentativeTitle; brokerAuthorizedRepresentativeTitle.Clean = value; _brokerAuthorizedRepresentativeTitle = brokerAuthorizedRepresentativeTitle;
                var brokerCompensationMethod = _brokerCompensationMethod; brokerCompensationMethod.Clean = value; _brokerCompensationMethod = brokerCompensationMethod;
                var brokerFeeRefundConditions1 = _brokerFeeRefundConditions1; brokerFeeRefundConditions1.Clean = value; _brokerFeeRefundConditions1 = brokerFeeRefundConditions1;
                var brokerFeeRefundConditions2 = _brokerFeeRefundConditions2; brokerFeeRefundConditions2.Clean = value; _brokerFeeRefundConditions2 = brokerFeeRefundConditions2;
                var brokerFeeRefundConditions3 = _brokerFeeRefundConditions3; brokerFeeRefundConditions3.Clean = value; _brokerFeeRefundConditions3 = brokerFeeRefundConditions3;
                var brokerForPlacingLoan = _brokerForPlacingLoan; brokerForPlacingLoan.Clean = value; _brokerForPlacingLoan = brokerForPlacingLoan;
                var brokerInterestRateEffect = _brokerInterestRateEffect; brokerInterestRateEffect.Clean = value; _brokerInterestRateEffect = brokerInterestRateEffect;
                var brokerLenderRelationship = _brokerLenderRelationship; brokerLenderRelationship.Clean = value; _brokerLenderRelationship = brokerLenderRelationship;
                var brokerLicenseNumberIdentifier = _brokerLicenseNumberIdentifier; brokerLicenseNumberIdentifier.Clean = value; _brokerLicenseNumberIdentifier = brokerLicenseNumberIdentifier;
                var brokerNameAsLicensed = _brokerNameAsLicensed; brokerNameAsLicensed.Clean = value; _brokerNameAsLicensed = brokerNameAsLicensed;
                var brokerTaxIdentificationNumberIdentifier = _brokerTaxIdentificationNumberIdentifier; brokerTaxIdentificationNumberIdentifier.Clean = value; _brokerTaxIdentificationNumberIdentifier = brokerTaxIdentificationNumberIdentifier;
                var brokerWithLenders = _brokerWithLenders; brokerWithLenders.Clean = value; _brokerWithLenders = brokerWithLenders;
                var cashCheckFromBorrower = _cashCheckFromBorrower; cashCheckFromBorrower.Clean = value; _cashCheckFromBorrower = cashCheckFromBorrower;
                var closingDocsLoanProgramType = _closingDocsLoanProgramType; closingDocsLoanProgramType.Clean = value; _closingDocsLoanProgramType = closingDocsLoanProgramType;
                var closingEntities = _closingEntities; closingEntities.Clean = value; _closingEntities = closingEntities;
                var closingProvider = _closingProvider; closingProvider.Clean = value; _closingProvider = closingProvider;
                var closingState = _closingState; closingState.Clean = value; _closingState = closingState;
                var complianceJurisdictionCounty = _complianceJurisdictionCounty; complianceJurisdictionCounty.Clean = value; _complianceJurisdictionCounty = complianceJurisdictionCounty;
                var compliancePropertyIdentifiedDate = _compliancePropertyIdentifiedDate; compliancePropertyIdentifiedDate.Clean = value; _compliancePropertyIdentifiedDate = compliancePropertyIdentifiedDate;
                var conditionDescription = _conditionDescription; conditionDescription.Clean = value; _conditionDescription = conditionDescription;
                var conflictofInterestCheck1 = _conflictofInterestCheck1; conflictofInterestCheck1.Clean = value; _conflictofInterestCheck1 = conflictofInterestCheck1;
                var conflictofInterestCheck2 = _conflictofInterestCheck2; conflictofInterestCheck2.Clean = value; _conflictofInterestCheck2 = conflictofInterestCheck2;
                var conflictofInterestCheck3 = _conflictofInterestCheck3; conflictofInterestCheck3.Clean = value; _conflictofInterestCheck3 = conflictofInterestCheck3;
                var conflictofInterestCheck4 = _conflictofInterestCheck4; conflictofInterestCheck4.Clean = value; _conflictofInterestCheck4 = conflictofInterestCheck4;
                var conflictofInterestCheck5 = _conflictofInterestCheck5; conflictofInterestCheck5.Clean = value; _conflictofInterestCheck5 = conflictofInterestCheck5;
                var conflictofInterestCheck6 = _conflictofInterestCheck6; conflictofInterestCheck6.Clean = value; _conflictofInterestCheck6 = conflictofInterestCheck6;
                var coopApartmentNumber = _coopApartmentNumber; coopApartmentNumber.Clean = value; _coopApartmentNumber = coopApartmentNumber;
                var coopAssignmentLeaseDate = _coopAssignmentLeaseDate; coopAssignmentLeaseDate.Clean = value; _coopAssignmentLeaseDate = coopAssignmentLeaseDate;
                var coopAttorneyInFact = _coopAttorneyInFact; coopAttorneyInFact.Clean = value; _coopAttorneyInFact = coopAttorneyInFact;
                var coopBuildingName = _coopBuildingName; coopBuildingName.Clean = value; _coopBuildingName = coopBuildingName;
                var coopCompanyExistsUnderTHeLawsOf = _coopCompanyExistsUnderTHeLawsOf; coopCompanyExistsUnderTHeLawsOf.Clean = value; _coopCompanyExistsUnderTHeLawsOf = coopCompanyExistsUnderTHeLawsOf;
                var coopCompanyName = _coopCompanyName; coopCompanyName.Clean = value; _coopCompanyName = coopCompanyName;
                var coopProprietaryLeaseDate = _coopProprietaryLeaseDate; coopProprietaryLeaseDate.Clean = value; _coopProprietaryLeaseDate = coopProprietaryLeaseDate;
                var coopSharesOwned = _coopSharesOwned; coopSharesOwned.Clean = value; _coopSharesOwned = coopSharesOwned;
                var coopStockCertificationNumber = _coopStockCertificationNumber; coopStockCertificationNumber.Clean = value; _coopStockCertificationNumber = coopStockCertificationNumber;
                var coopVacancyPercentNotification = _coopVacancyPercentNotification; coopVacancyPercentNotification.Clean = value; _coopVacancyPercentNotification = coopVacancyPercentNotification;
                var customOtherRiderDescription = _customOtherRiderDescription; customOtherRiderDescription.Clean = value; _customOtherRiderDescription = customOtherRiderDescription;
                var disbursementDate = _disbursementDate; disbursementDate.Clean = value; _disbursementDate = disbursementDate;
                var disbursementsToBorrower = _disbursementsToBorrower; disbursementsToBorrower.Clean = value; _disbursementsToBorrower = disbursementsToBorrower;
                var disclosureAlternateLender = _disclosureAlternateLender; disclosureAlternateLender.Clean = value; _disclosureAlternateLender = disclosureAlternateLender;
                var disclosureCompanyFunction = _disclosureCompanyFunction; disclosureCompanyFunction.Clean = value; _disclosureCompanyFunction = disclosureCompanyFunction;
                var disclosurePlanCode = _disclosurePlanCode; disclosurePlanCode.Clean = value; _disclosurePlanCode = disclosurePlanCode;
                var docReportGUID = _docReportGUID; docReportGUID.Clean = value; _docReportGUID = docReportGUID;
                var documentPreparationDate = _documentPreparationDate; documentPreparationDate.Clean = value; _documentPreparationDate = documentPreparationDate;
                var documentSigningDate = _documentSigningDate; documentSigningDate.Clean = value; _documentSigningDate = documentSigningDate;
                var drawCity = _drawCity; drawCity.Clean = value; _drawCity = drawCity;
                var drawCounty = _drawCounty; drawCounty.Clean = value; _drawCounty = drawCounty;
                var drawState = _drawState; drawState.Clean = value; _drawState = drawState;
                var employeeofMortgageLender = _employeeofMortgageLender; employeeofMortgageLender.Clean = value; _employeeofMortgageLender = employeeofMortgageLender;
                var expectToAssignSellOrTransferPercent = _expectToAssignSellOrTransferPercent; expectToAssignSellOrTransferPercent.Clean = value; _expectToAssignSellOrTransferPercent = expectToAssignSellOrTransferPercent;
                var finalVestingDescription = _finalVestingDescription; finalVestingDescription.Clean = value; _finalVestingDescription = finalVestingDescription;
                var firstTransferYear = _firstTransferYear; firstTransferYear.Clean = value; _firstTransferYear = firstTransferYear;
                var firstTransferYearValue = _firstTransferYearValue; firstTransferYearValue.Clean = value; _firstTransferYearValue = firstTransferYearValue;
                var hoursDocumentsNeededPriorToDisbursementCount = _hoursDocumentsNeededPriorToDisbursementCount; hoursDocumentsNeededPriorToDisbursementCount.Clean = value; _hoursDocumentsNeededPriorToDisbursementCount = hoursDocumentsNeededPriorToDisbursementCount;
                var housingIndicator = _housingIndicator; housingIndicator.Clean = value; _housingIndicator = housingIndicator;
                var housingProgramName = _housingProgramName; housingProgramName.Clean = value; _housingProgramName = housingProgramName;
                var hUD1FileNumberIdentifier = _hUD1FileNumberIdentifier; hUD1FileNumberIdentifier.Clean = value; _hUD1FileNumberIdentifier = hUD1FileNumberIdentifier;
                var hUD1SettlementAgentUnparsedAddress = _hUD1SettlementAgentUnparsedAddress; hUD1SettlementAgentUnparsedAddress.Clean = value; _hUD1SettlementAgentUnparsedAddress = hUD1SettlementAgentUnparsedAddress;
                var hUD1SettlementAgentUnparsedName = _hUD1SettlementAgentUnparsedName; hUD1SettlementAgentUnparsedName.Clean = value; _hUD1SettlementAgentUnparsedName = hUD1SettlementAgentUnparsedName;
                var hUD1SettlementDate = _hUD1SettlementDate; hUD1SettlementDate.Clean = value; _hUD1SettlementDate = hUD1SettlementDate;
                var id = _id; id.Clean = value; _id = id;
                var includeSafeHaborDisclosure = _includeSafeHaborDisclosure; includeSafeHaborDisclosure.Clean = value; _includeSafeHaborDisclosure = includeSafeHaborDisclosure;
                var investorCode = _investorCode; investorCode.Clean = value; _investorCode = investorCode;
                var lastAuditDate = _lastAuditDate; lastAuditDate.Clean = value; _lastAuditDate = lastAuditDate;
                var lastDocumentOrdered = _lastDocumentOrdered; lastDocumentOrdered.Clean = value; _lastDocumentOrdered = lastDocumentOrdered;
                var legalAttached = _legalAttached; legalAttached.Clean = value; _legalAttached = legalAttached;
                var lenderAuthorizedRepresentativeTitle = _lenderAuthorizedRepresentativeTitle; lenderAuthorizedRepresentativeTitle.Clean = value; _lenderAuthorizedRepresentativeTitle = lenderAuthorizedRepresentativeTitle;
                var lenderBrokerRepresents = _lenderBrokerRepresents; lenderBrokerRepresents.Clean = value; _lenderBrokerRepresents = lenderBrokerRepresents;
                var lienHolderAddress = _lienHolderAddress; lienHolderAddress.Clean = value; _lienHolderAddress = lienHolderAddress;
                var lienHolderAddressCity = _lienHolderAddressCity; lienHolderAddressCity.Clean = value; _lienHolderAddressCity = lienHolderAddressCity;
                var lienHolderAddressPostalCode = _lienHolderAddressPostalCode; lienHolderAddressPostalCode.Clean = value; _lienHolderAddressPostalCode = lienHolderAddressPostalCode;
                var lienHolderAddressState = _lienHolderAddressState; lienHolderAddressState.Clean = value; _lienHolderAddressState = lienHolderAddressState;
                var lienHolderName = _lienHolderName; lienHolderName.Clean = value; _lienHolderName = lienHolderName;
                var loanIsLocked = _loanIsLocked; loanIsLocked.Clean = value; _loanIsLocked = loanIsLocked;
                var loanOption = _loanOption; loanOption.Clean = value; _loanOption = loanOption;
                var lockInFeeType = _lockInFeeType; lockInFeeType.Clean = value; _lockInFeeType = lockInFeeType;
                var mfgHomeAnchored = _mfgHomeAnchored; mfgHomeAnchored.Clean = value; _mfgHomeAnchored = mfgHomeAnchored;
                var mfgHomeCertificateOfTitleIdentifier = _mfgHomeCertificateOfTitleIdentifier; mfgHomeCertificateOfTitleIdentifier.Clean = value; _mfgHomeCertificateOfTitleIdentifier = mfgHomeCertificateOfTitleIdentifier;
                var mfgHomeCertificateOfTitleType = _mfgHomeCertificateOfTitleType; mfgHomeCertificateOfTitleType.Clean = value; _mfgHomeCertificateOfTitleType = mfgHomeCertificateOfTitleType;
                var mfgHomeDescription = _mfgHomeDescription; mfgHomeDescription.Clean = value; _mfgHomeDescription = mfgHomeDescription;
                var mfgHomeHUDCertificationLabelIdentifier = _mfgHomeHUDCertificationLabelIdentifier; mfgHomeHUDCertificationLabelIdentifier.Clean = value; _mfgHomeHUDCertificationLabelIdentifier = mfgHomeHUDCertificationLabelIdentifier;
                var mfgHomeLengthFeetCount = _mfgHomeLengthFeetCount; mfgHomeLengthFeetCount.Clean = value; _mfgHomeLengthFeetCount = mfgHomeLengthFeetCount;
                var mfgHomeMakeIdentifier = _mfgHomeMakeIdentifier; mfgHomeMakeIdentifier.Clean = value; _mfgHomeMakeIdentifier = mfgHomeMakeIdentifier;
                var mfgHomeManufacturer = _mfgHomeManufacturer; mfgHomeManufacturer.Clean = value; _mfgHomeManufacturer = mfgHomeManufacturer;
                var mfgHomeManufacturerAddress = _mfgHomeManufacturerAddress; mfgHomeManufacturerAddress.Clean = value; _mfgHomeManufacturerAddress = mfgHomeManufacturerAddress;
                var mfgHomeManufacturerCity = _mfgHomeManufacturerCity; mfgHomeManufacturerCity.Clean = value; _mfgHomeManufacturerCity = mfgHomeManufacturerCity;
                var mfgHomeManufacturerPhoneNumber = _mfgHomeManufacturerPhoneNumber; mfgHomeManufacturerPhoneNumber.Clean = value; _mfgHomeManufacturerPhoneNumber = mfgHomeManufacturerPhoneNumber;
                var mfgHomeManufacturerPostalCode = _mfgHomeManufacturerPostalCode; mfgHomeManufacturerPostalCode.Clean = value; _mfgHomeManufacturerPostalCode = mfgHomeManufacturerPostalCode;
                var mfgHomeManufacturerState = _mfgHomeManufacturerState; mfgHomeManufacturerState.Clean = value; _mfgHomeManufacturerState = mfgHomeManufacturerState;
                var mfgHomeManufactureYear = _mfgHomeManufactureYear; mfgHomeManufactureYear.Clean = value; _mfgHomeManufactureYear = mfgHomeManufactureYear;
                var mfgHomeModelIdentifier = _mfgHomeModelIdentifier; mfgHomeModelIdentifier.Clean = value; _mfgHomeModelIdentifier = mfgHomeModelIdentifier;
                var mfgHomeNewOrUsed = _mfgHomeNewOrUsed; mfgHomeNewOrUsed.Clean = value; _mfgHomeNewOrUsed = mfgHomeNewOrUsed;
                var mfgHomeSerialNumberIdentifier = _mfgHomeSerialNumberIdentifier; mfgHomeSerialNumberIdentifier.Clean = value; _mfgHomeSerialNumberIdentifier = mfgHomeSerialNumberIdentifier;
                var mfgHomeWidthFeetCount = _mfgHomeWidthFeetCount; mfgHomeWidthFeetCount.Clean = value; _mfgHomeWidthFeetCount = mfgHomeWidthFeetCount;
                var mineralRightsDescription = _mineralRightsDescription; mineralRightsDescription.Clean = value; _mineralRightsDescription = mineralRightsDescription;
                var mortgageType = _mortgageType; mortgageType.Clean = value; _mortgageType = mortgageType;
                var numberBrokerAgreements = _numberBrokerAgreements; numberBrokerAgreements.Clean = value; _numberBrokerAgreements = numberBrokerAgreements;
                var numberSuccessfulBrokerAgreements = _numberSuccessfulBrokerAgreements; numberSuccessfulBrokerAgreements.Clean = value; _numberSuccessfulBrokerAgreements = numberSuccessfulBrokerAgreements;
                var officeOfRecordationName = _officeOfRecordationName; officeOfRecordationName.Clean = value; _officeOfRecordationName = officeOfRecordationName;
                var onlyOneEntity = _onlyOneEntity; onlyOneEntity.Clean = value; _onlyOneEntity = onlyOneEntity;
                var optionSelectedReason = _optionSelectedReason; optionSelectedReason.Clean = value; _optionSelectedReason = optionSelectedReason;
                var originalPincipalAmountSecured = _originalPincipalAmountSecured; originalPincipalAmountSecured.Clean = value; _originalPincipalAmountSecured = originalPincipalAmountSecured;
                var otherOptionDescription = _otherOptionDescription; otherOptionDescription.Clean = value; _otherOptionDescription = otherOptionDescription;
                var parentAffiliatedCoName = _parentAffiliatedCoName; parentAffiliatedCoName.Clean = value; _parentAffiliatedCoName = parentAffiliatedCoName;
                var payToTheOrderOfDescription = _payToTheOrderOfDescription; payToTheOrderOfDescription.Clean = value; _payToTheOrderOfDescription = payToTheOrderOfDescription;
                var perDiemCalculationMethodType = _perDiemCalculationMethodType; perDiemCalculationMethodType.Clean = value; _perDiemCalculationMethodType = perDiemCalculationMethodType;
                var planCode = _planCode; planCode.Clean = value; _planCode = planCode;
                var planCodeDescription = _planCodeDescription; planCodeDescription.Clean = value; _planCodeDescription = planCodeDescription;
                var planCodeId = _planCodeId; planCodeId.Clean = value; _planCodeId = planCodeId;
                var preliminaryTitleReportDate = _preliminaryTitleReportDate; preliminaryTitleReportDate.Clean = value; _preliminaryTitleReportDate = preliminaryTitleReportDate;
                var prepaymentPenaltyDescriptions1 = _prepaymentPenaltyDescriptions1; prepaymentPenaltyDescriptions1.Clean = value; _prepaymentPenaltyDescriptions1 = prepaymentPenaltyDescriptions1;
                var prepaymentPenaltyDescriptions2 = _prepaymentPenaltyDescriptions2; prepaymentPenaltyDescriptions2.Clean = value; _prepaymentPenaltyDescriptions2 = prepaymentPenaltyDescriptions2;
                var prepaymentPenaltyDescriptions3 = _prepaymentPenaltyDescriptions3; prepaymentPenaltyDescriptions3.Clean = value; _prepaymentPenaltyDescriptions3 = prepaymentPenaltyDescriptions3;
                var processingNumberDays = _processingNumberDays; processingNumberDays.Clean = value; _processingNumberDays = processingNumberDays;
                var programCode = _programCode; programCode.Clean = value; _programCode = programCode;
                var programSponsor = _programSponsor; programSponsor.Clean = value; _programSponsor = programSponsor;
                var propertyIsLandTrust = _propertyIsLandTrust; propertyIsLandTrust.Clean = value; _propertyIsLandTrust = propertyIsLandTrust;
                var propertyTaxMessageDescription = _propertyTaxMessageDescription; propertyTaxMessageDescription.Clean = value; _propertyTaxMessageDescription = propertyTaxMessageDescription;
                var rateLockRefundConditions1 = _rateLockRefundConditions1; rateLockRefundConditions1.Clean = value; _rateLockRefundConditions1 = rateLockRefundConditions1;
                var rateLockRefundConditions2 = _rateLockRefundConditions2; rateLockRefundConditions2.Clean = value; _rateLockRefundConditions2 = rateLockRefundConditions2;
                var rateLockRefundConditions3 = _rateLockRefundConditions3; rateLockRefundConditions3.Clean = value; _rateLockRefundConditions3 = rateLockRefundConditions3;
                var recordingJurisdictionName = _recordingJurisdictionName; recordingJurisdictionName.Clean = value; _recordingJurisdictionName = recordingJurisdictionName;
                var refinanceBalloonMortgageGuarantee = _refinanceBalloonMortgageGuarantee; refinanceBalloonMortgageGuarantee.Clean = value; _refinanceBalloonMortgageGuarantee = refinanceBalloonMortgageGuarantee;
                var refinanceRightOfRescissionExemptFlag = _refinanceRightOfRescissionExemptFlag; refinanceRightOfRescissionExemptFlag.Clean = value; _refinanceRightOfRescissionExemptFlag = refinanceRightOfRescissionExemptFlag;
                var renewalExtensionDescription = _renewalExtensionDescription; renewalExtensionDescription.Clean = value; _renewalExtensionDescription = renewalExtensionDescription;
                var rescissionDate = _rescissionDate; rescissionDate.Clean = value; _rescissionDate = rescissionDate;
                var respaHudDetails = _respaHudDetails; respaHudDetails.Clean = value; _respaHudDetails = respaHudDetails;
                var rMLANamePreceding10Years = _rMLANamePreceding10Years; rMLANamePreceding10Years.Clean = value; _rMLANamePreceding10Years = rMLANamePreceding10Years;
                var rmlLenderBrokerRepresents = _rmlLenderBrokerRepresents; rmlLenderBrokerRepresents.Clean = value; _rmlLenderBrokerRepresents = rmlLenderBrokerRepresents;
                var secondTransferYear = _secondTransferYear; secondTransferYear.Clean = value; _secondTransferYear = secondTransferYear;
                var secondTransferYearValue = _secondTransferYearValue; secondTransferYearValue.Clean = value; _secondTransferYearValue = secondTransferYearValue;
                var signatureDateFor1003 = _signatureDateFor1003; signatureDateFor1003.Clean = value; _signatureDateFor1003 = signatureDateFor1003;
                var specialFloodHazardAreaIndictor = _specialFloodHazardAreaIndictor; specialFloodHazardAreaIndictor.Clean = value; _specialFloodHazardAreaIndictor = specialFloodHazardAreaIndictor;
                var stateLicenses = _stateLicenses; stateLicenses.Clean = value; _stateLicenses = stateLicenses;
                var suretyCompanyName = _suretyCompanyName; suretyCompanyName.Clean = value; _suretyCompanyName = suretyCompanyName;
                var syncInterestDateDisbursementDate = _syncInterestDateDisbursementDate; syncInterestDateDisbursementDate.Clean = value; _syncInterestDateDisbursementDate = syncInterestDateDisbursementDate;
                var termiteReportRequiredIndicator = _termiteReportRequiredIndicator; termiteReportRequiredIndicator.Clean = value; _termiteReportRequiredIndicator = termiteReportRequiredIndicator;
                var textDescription = _textDescription; textDescription.Clean = value; _textDescription = textDescription;
                var thirdTransferYear = _thirdTransferYear; thirdTransferYear.Clean = value; _thirdTransferYear = thirdTransferYear;
                var thirdTransferYearValue = _thirdTransferYearValue; thirdTransferYearValue.Clean = value; _thirdTransferYearValue = thirdTransferYearValue;
                var titleReportItemsDescription = _titleReportItemsDescription; titleReportItemsDescription.Clean = value; _titleReportItemsDescription = titleReportItemsDescription;
                var titleReportRequiredEndorsementsDescription = _titleReportRequiredEndorsementsDescription; titleReportRequiredEndorsementsDescription.Clean = value; _titleReportRequiredEndorsementsDescription = titleReportRequiredEndorsementsDescription;
                var totalDisbursed = _totalDisbursed; totalDisbursed.Clean = value; _totalDisbursed = totalDisbursed;
                var trust2Beneficiaries = _trust2Beneficiaries; trust2Beneficiaries.Clean = value; _trust2Beneficiaries = trust2Beneficiaries;
                var weConductBusiness = _weConductBusiness; weConductBusiness.Clean = value; _weConductBusiness = weConductBusiness;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDocument()
        {
            Clean = true;
        }
    }
}