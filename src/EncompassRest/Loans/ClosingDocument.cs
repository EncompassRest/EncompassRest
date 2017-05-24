using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDocument
    {
        private Value<string> _additionalLienHolderAddress;
        public string AdditionalLienHolderAddress { get { return _additionalLienHolderAddress; } set { _additionalLienHolderAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddress() => !_additionalLienHolderAddress.Clean;
        private Value<string> _additionalLienHolderAddressCity;
        public string AdditionalLienHolderAddressCity { get { return _additionalLienHolderAddressCity; } set { _additionalLienHolderAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressCity() => !_additionalLienHolderAddressCity.Clean;
        private Value<string> _additionalLienHolderAddressPostalCode;
        public string AdditionalLienHolderAddressPostalCode { get { return _additionalLienHolderAddressPostalCode; } set { _additionalLienHolderAddressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressPostalCode() => !_additionalLienHolderAddressPostalCode.Clean;
        private Value<string> _additionalLienHolderAddressState;
        public string AdditionalLienHolderAddressState { get { return _additionalLienHolderAddressState; } set { _additionalLienHolderAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressState() => !_additionalLienHolderAddressState.Clean;
        private Value<string> _additionalLienHolderName;
        public string AdditionalLienHolderName { get { return _additionalLienHolderName; } set { _additionalLienHolderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderName() => !_additionalLienHolderName.Clean;
        private Value<decimal?> _additionalOriginalPincipalAmountSecured;
        public decimal? AdditionalOriginalPincipalAmountSecured { get { return _additionalOriginalPincipalAmountSecured; } set { _additionalOriginalPincipalAmountSecured = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalOriginalPincipalAmountSecured() => !_additionalOriginalPincipalAmountSecured.Clean;
        private Value<string> _additionalSigVerbiageType;
        public string AdditionalSigVerbiageType { get { return _additionalSigVerbiageType; } set { _additionalSigVerbiageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalSigVerbiageType() => !_additionalSigVerbiageType.Clean;
        private Value<List<AdditionalStateDisclosure>> _additionalStateDisclosures;
        public List<AdditionalStateDisclosure> AdditionalStateDisclosures { get { return _additionalStateDisclosures; } set { _additionalStateDisclosures = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalStateDisclosures() => !_additionalStateDisclosures.Clean;
        private Value<bool?> _affectedByInterest;
        public bool? AffectedByInterest { get { return _affectedByInterest; } set { _affectedByInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffectedByInterest() => !_affectedByInterest.Clean;
        private Value<string> _alternateLender;
        public string AlternateLender { get { return _alternateLender; } set { _alternateLender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlternateLender() => !_alternateLender.Clean;
        private Value<string> _altLenderId;
        public string AltLenderId { get { return _altLenderId; } set { _altLenderId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltLenderId() => !_altLenderId.Clean;
        private Value<List<AntiSteeringLoanOption>> _antiSteeringLoanOptions;
        public List<AntiSteeringLoanOption> AntiSteeringLoanOptions { get { return _antiSteeringLoanOptions; } set { _antiSteeringLoanOptions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAntiSteeringLoanOptions() => !_antiSteeringLoanOptions.Clean;
        private Value<string> _areAbleToServiceIndicator;
        public string AreAbleToServiceIndicator { get { return _areAbleToServiceIndicator; } set { _areAbleToServiceIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAreAbleToServiceIndicator() => !_areAbleToServiceIndicator.Clean;
        private Value<string> _associatedDocumentNumber;
        public string AssociatedDocumentNumber { get { return _associatedDocumentNumber; } set { _associatedDocumentNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssociatedDocumentNumber() => !_associatedDocumentNumber.Clean;
        private Value<string> _beneficiaries;
        public string Beneficiaries { get { return _beneficiaries; } set { _beneficiaries = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeneficiaries() => !_beneficiaries.Clean;
        private Value<bool?> _borrowerConsentType1;
        public bool? BorrowerConsentType1 { get { return _borrowerConsentType1; } set { _borrowerConsentType1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerConsentType1() => !_borrowerConsentType1.Clean;
        private Value<bool?> _borrowerConsentType2;
        public bool? BorrowerConsentType2 { get { return _borrowerConsentType2; } set { _borrowerConsentType2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerConsentType2() => !_borrowerConsentType2.Clean;
        private Value<string> _borrowerOrganizationType1;
        public string BorrowerOrganizationType1 { get { return _borrowerOrganizationType1; } set { _borrowerOrganizationType1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizationType1() => !_borrowerOrganizationType1.Clean;
        private Value<string> _borrowerOrganizationType2;
        public string BorrowerOrganizationType2 { get { return _borrowerOrganizationType2; } set { _borrowerOrganizationType2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizationType2() => !_borrowerOrganizationType2.Clean;
        private Value<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName1;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get { return _borrowerOrganizedUnderTheLawsOfJurisdictionName1; } set { _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizedUnderTheLawsOfJurisdictionName1() => !_borrowerOrganizedUnderTheLawsOfJurisdictionName1.Clean;
        private Value<string> _borrowerOrganizedUnderTheLawsOfJurisdictionName2;
        public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get { return _borrowerOrganizedUnderTheLawsOfJurisdictionName2; } set { _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizedUnderTheLawsOfJurisdictionName2() => !_borrowerOrganizedUnderTheLawsOfJurisdictionName2.Clean;
        private Value<string> _borrowerTaxIdentificationNumberIdentifier1;
        public string BorrowerTaxIdentificationNumberIdentifier1 { get { return _borrowerTaxIdentificationNumberIdentifier1; } set { _borrowerTaxIdentificationNumberIdentifier1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTaxIdentificationNumberIdentifier1() => !_borrowerTaxIdentificationNumberIdentifier1.Clean;
        private Value<string> _borrowerTaxIdentificationNumberIdentifier2;
        public string BorrowerTaxIdentificationNumberIdentifier2 { get { return _borrowerTaxIdentificationNumberIdentifier2; } set { _borrowerTaxIdentificationNumberIdentifier2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTaxIdentificationNumberIdentifier2() => !_borrowerTaxIdentificationNumberIdentifier2.Clean;
        private Value<string> _borrowerTrustAmendedDateOrYear1;
        public string BorrowerTrustAmendedDateOrYear1 { get { return _borrowerTrustAmendedDateOrYear1; } set { _borrowerTrustAmendedDateOrYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustAmendedDateOrYear1() => !_borrowerTrustAmendedDateOrYear1.Clean;
        private Value<string> _borrowerTrustAmendedDateOrYear2;
        public string BorrowerTrustAmendedDateOrYear2 { get { return _borrowerTrustAmendedDateOrYear2; } set { _borrowerTrustAmendedDateOrYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustAmendedDateOrYear2() => !_borrowerTrustAmendedDateOrYear2.Clean;
        private Value<string> _borrowerTrustDateOrYear1;
        public string BorrowerTrustDateOrYear1 { get { return _borrowerTrustDateOrYear1; } set { _borrowerTrustDateOrYear1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustDateOrYear1() => !_borrowerTrustDateOrYear1.Clean;
        private Value<string> _borrowerTrustDateOrYear2;
        public string BorrowerTrustDateOrYear2 { get { return _borrowerTrustDateOrYear2; } set { _borrowerTrustDateOrYear2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustDateOrYear2() => !_borrowerTrustDateOrYear2.Clean;
        private Value<string> _borrowerUnparsedName1;
        public string BorrowerUnparsedName1 { get { return _borrowerUnparsedName1; } set { _borrowerUnparsedName1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerUnparsedName1() => !_borrowerUnparsedName1.Clean;
        private Value<string> _borrowerUnparsedName2;
        public string BorrowerUnparsedName2 { get { return _borrowerUnparsedName2; } set { _borrowerUnparsedName2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerUnparsedName2() => !_borrowerUnparsedName2.Clean;
        private Value<string> _brokerAuthorizedRepresentativeTitle;
        public string BrokerAuthorizedRepresentativeTitle { get { return _brokerAuthorizedRepresentativeTitle; } set { _brokerAuthorizedRepresentativeTitle = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAuthorizedRepresentativeTitle() => !_brokerAuthorizedRepresentativeTitle.Clean;
        private Value<string> _brokerCompensationMethod;
        public string BrokerCompensationMethod { get { return _brokerCompensationMethod; } set { _brokerCompensationMethod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationMethod() => !_brokerCompensationMethod.Clean;
        private Value<string> _brokerFeeRefundConditions1;
        public string BrokerFeeRefundConditions1 { get { return _brokerFeeRefundConditions1; } set { _brokerFeeRefundConditions1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions1() => !_brokerFeeRefundConditions1.Clean;
        private Value<string> _brokerFeeRefundConditions2;
        public string BrokerFeeRefundConditions2 { get { return _brokerFeeRefundConditions2; } set { _brokerFeeRefundConditions2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions2() => !_brokerFeeRefundConditions2.Clean;
        private Value<string> _brokerFeeRefundConditions3;
        public string BrokerFeeRefundConditions3 { get { return _brokerFeeRefundConditions3; } set { _brokerFeeRefundConditions3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions3() => !_brokerFeeRefundConditions3.Clean;
        private Value<string> _brokerForPlacingLoan;
        public string BrokerForPlacingLoan { get { return _brokerForPlacingLoan; } set { _brokerForPlacingLoan = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerForPlacingLoan() => !_brokerForPlacingLoan.Clean;
        private Value<string> _brokerInterestRateEffect;
        public string BrokerInterestRateEffect { get { return _brokerInterestRateEffect; } set { _brokerInterestRateEffect = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerInterestRateEffect() => !_brokerInterestRateEffect.Clean;
        private Value<string> _brokerLenderRelationship;
        public string BrokerLenderRelationship { get { return _brokerLenderRelationship; } set { _brokerLenderRelationship = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLenderRelationship() => !_brokerLenderRelationship.Clean;
        private Value<string> _brokerLicenseNumberIdentifier;
        public string BrokerLicenseNumberIdentifier { get { return _brokerLicenseNumberIdentifier; } set { _brokerLicenseNumberIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseNumberIdentifier() => !_brokerLicenseNumberIdentifier.Clean;
        private Value<string> _brokerNameAsLicensed;
        public string BrokerNameAsLicensed { get { return _brokerNameAsLicensed; } set { _brokerNameAsLicensed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerNameAsLicensed() => !_brokerNameAsLicensed.Clean;
        private Value<string> _brokerTaxIdentificationNumberIdentifier;
        public string BrokerTaxIdentificationNumberIdentifier { get { return _brokerTaxIdentificationNumberIdentifier; } set { _brokerTaxIdentificationNumberIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerTaxIdentificationNumberIdentifier() => !_brokerTaxIdentificationNumberIdentifier.Clean;
        private Value<string> _brokerWithLenders;
        public string BrokerWithLenders { get { return _brokerWithLenders; } set { _brokerWithLenders = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerWithLenders() => !_brokerWithLenders.Clean;
        private Value<decimal?> _cashCheckFromBorrower;
        public decimal? CashCheckFromBorrower { get { return _cashCheckFromBorrower; } set { _cashCheckFromBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashCheckFromBorrower() => !_cashCheckFromBorrower.Clean;
        private Value<string> _closingDocsLoanProgramType;
        public string ClosingDocsLoanProgramType { get { return _closingDocsLoanProgramType; } set { _closingDocsLoanProgramType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocsLoanProgramType() => !_closingDocsLoanProgramType.Clean;
        private Value<List<ClosingEntity>> _closingEntities;
        public List<ClosingEntity> ClosingEntities { get { return _closingEntities; } set { _closingEntities = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingEntities() => !_closingEntities.Clean;
        private Value<string> _closingProvider;
        public string ClosingProvider { get { return _closingProvider; } set { _closingProvider = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingProvider() => !_closingProvider.Clean;
        private Value<string> _closingState;
        public string ClosingState { get { return _closingState; } set { _closingState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingState() => !_closingState.Clean;
        private Value<string> _complianceJurisdictionCounty;
        public string ComplianceJurisdictionCounty { get { return _complianceJurisdictionCounty; } set { _complianceJurisdictionCounty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComplianceJurisdictionCounty() => !_complianceJurisdictionCounty.Clean;
        private Value<DateTime?> _compliancePropertyIdentifiedDate;
        public DateTime? CompliancePropertyIdentifiedDate { get { return _compliancePropertyIdentifiedDate; } set { _compliancePropertyIdentifiedDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompliancePropertyIdentifiedDate() => !_compliancePropertyIdentifiedDate.Clean;
        private Value<string> _conditionDescription;
        public string ConditionDescription { get { return _conditionDescription; } set { _conditionDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionDescription() => !_conditionDescription.Clean;
        private Value<bool?> _conflictofInterestCheck1;
        public bool? ConflictofInterestCheck1 { get { return _conflictofInterestCheck1; } set { _conflictofInterestCheck1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck1() => !_conflictofInterestCheck1.Clean;
        private Value<bool?> _conflictofInterestCheck2;
        public bool? ConflictofInterestCheck2 { get { return _conflictofInterestCheck2; } set { _conflictofInterestCheck2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck2() => !_conflictofInterestCheck2.Clean;
        private Value<bool?> _conflictofInterestCheck3;
        public bool? ConflictofInterestCheck3 { get { return _conflictofInterestCheck3; } set { _conflictofInterestCheck3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck3() => !_conflictofInterestCheck3.Clean;
        private Value<bool?> _conflictofInterestCheck4;
        public bool? ConflictofInterestCheck4 { get { return _conflictofInterestCheck4; } set { _conflictofInterestCheck4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck4() => !_conflictofInterestCheck4.Clean;
        private Value<bool?> _conflictofInterestCheck5;
        public bool? ConflictofInterestCheck5 { get { return _conflictofInterestCheck5; } set { _conflictofInterestCheck5 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck5() => !_conflictofInterestCheck5.Clean;
        private Value<bool?> _conflictofInterestCheck6;
        public bool? ConflictofInterestCheck6 { get { return _conflictofInterestCheck6; } set { _conflictofInterestCheck6 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck6() => !_conflictofInterestCheck6.Clean;
        private Value<string> _coopApartmentNumber;
        public string CoopApartmentNumber { get { return _coopApartmentNumber; } set { _coopApartmentNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopApartmentNumber() => !_coopApartmentNumber.Clean;
        private Value<DateTime?> _coopAssignmentLeaseDate;
        public DateTime? CoopAssignmentLeaseDate { get { return _coopAssignmentLeaseDate; } set { _coopAssignmentLeaseDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopAssignmentLeaseDate() => !_coopAssignmentLeaseDate.Clean;
        private Value<string> _coopAttorneyInFact;
        public string CoopAttorneyInFact { get { return _coopAttorneyInFact; } set { _coopAttorneyInFact = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopAttorneyInFact() => !_coopAttorneyInFact.Clean;
        private Value<string> _coopBuildingName;
        public string CoopBuildingName { get { return _coopBuildingName; } set { _coopBuildingName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopBuildingName() => !_coopBuildingName.Clean;
        private Value<string> _coopCompanyExistsUnderTHeLawsOf;
        public string CoopCompanyExistsUnderTHeLawsOf { get { return _coopCompanyExistsUnderTHeLawsOf; } set { _coopCompanyExistsUnderTHeLawsOf = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopCompanyExistsUnderTHeLawsOf() => !_coopCompanyExistsUnderTHeLawsOf.Clean;
        private Value<string> _coopCompanyName;
        public string CoopCompanyName { get { return _coopCompanyName; } set { _coopCompanyName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopCompanyName() => !_coopCompanyName.Clean;
        private Value<DateTime?> _coopProprietaryLeaseDate;
        public DateTime? CoopProprietaryLeaseDate { get { return _coopProprietaryLeaseDate; } set { _coopProprietaryLeaseDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopProprietaryLeaseDate() => !_coopProprietaryLeaseDate.Clean;
        private Value<decimal?> _coopSharesOwned;
        public decimal? CoopSharesOwned { get { return _coopSharesOwned; } set { _coopSharesOwned = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopSharesOwned() => !_coopSharesOwned.Clean;
        private Value<string> _coopStockCertificationNumber;
        public string CoopStockCertificationNumber { get { return _coopStockCertificationNumber; } set { _coopStockCertificationNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopStockCertificationNumber() => !_coopStockCertificationNumber.Clean;
        private Value<decimal?> _coopVacancyPercentNotification;
        public decimal? CoopVacancyPercentNotification { get { return _coopVacancyPercentNotification; } set { _coopVacancyPercentNotification = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopVacancyPercentNotification() => !_coopVacancyPercentNotification.Clean;
        private Value<string> _customOtherRiderDescription;
        public string CustomOtherRiderDescription { get { return _customOtherRiderDescription; } set { _customOtherRiderDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCustomOtherRiderDescription() => !_customOtherRiderDescription.Clean;
        private Value<DateTime?> _disbursementDate;
        public DateTime? DisbursementDate { get { return _disbursementDate; } set { _disbursementDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementDate() => !_disbursementDate.Clean;
        private Value<decimal?> _disbursementsToBorrower;
        public decimal? DisbursementsToBorrower { get { return _disbursementsToBorrower; } set { _disbursementsToBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementsToBorrower() => !_disbursementsToBorrower.Clean;
        private Value<string> _disclosureAlternateLender;
        public string DisclosureAlternateLender { get { return _disclosureAlternateLender; } set { _disclosureAlternateLender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureAlternateLender() => !_disclosureAlternateLender.Clean;
        private Value<string> _disclosureCompanyFunction;
        public string DisclosureCompanyFunction { get { return _disclosureCompanyFunction; } set { _disclosureCompanyFunction = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureCompanyFunction() => !_disclosureCompanyFunction.Clean;
        private Value<string> _disclosurePlanCode;
        public string DisclosurePlanCode { get { return _disclosurePlanCode; } set { _disclosurePlanCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosurePlanCode() => !_disclosurePlanCode.Clean;
        private Value<string> _docReportGUID;
        public string DocReportGUID { get { return _docReportGUID; } set { _docReportGUID = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocReportGUID() => !_docReportGUID.Clean;
        private Value<DateTime?> _documentPreparationDate;
        public DateTime? DocumentPreparationDate { get { return _documentPreparationDate; } set { _documentPreparationDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentPreparationDate() => !_documentPreparationDate.Clean;
        private Value<DateTime?> _documentSigningDate;
        public DateTime? DocumentSigningDate { get { return _documentSigningDate; } set { _documentSigningDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentSigningDate() => !_documentSigningDate.Clean;
        private Value<string> _drawCity;
        public string DrawCity { get { return _drawCity; } set { _drawCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawCity() => !_drawCity.Clean;
        private Value<string> _drawCounty;
        public string DrawCounty { get { return _drawCounty; } set { _drawCounty = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawCounty() => !_drawCounty.Clean;
        private Value<string> _drawState;
        public string DrawState { get { return _drawState; } set { _drawState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawState() => !_drawState.Clean;
        private Value<string> _employeeofMortgageLender;
        public string EmployeeofMortgageLender { get { return _employeeofMortgageLender; } set { _employeeofMortgageLender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployeeofMortgageLender() => !_employeeofMortgageLender.Clean;
        private Value<string> _expectToAssignSellOrTransferPercent;
        public string ExpectToAssignSellOrTransferPercent { get { return _expectToAssignSellOrTransferPercent; } set { _expectToAssignSellOrTransferPercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectToAssignSellOrTransferPercent() => !_expectToAssignSellOrTransferPercent.Clean;
        private Value<string> _finalVestingDescription;
        public string FinalVestingDescription { get { return _finalVestingDescription; } set { _finalVestingDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalVestingDescription() => !_finalVestingDescription.Clean;
        private Value<string> _firstTransferYear;
        public string FirstTransferYear { get { return _firstTransferYear; } set { _firstTransferYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTransferYear() => !_firstTransferYear.Clean;
        private Value<decimal?> _firstTransferYearValue;
        public decimal? FirstTransferYearValue { get { return _firstTransferYearValue; } set { _firstTransferYearValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTransferYearValue() => !_firstTransferYearValue.Clean;
        private Value<string> _hoursDocumentsNeededPriorToDisbursementCount;
        public string HoursDocumentsNeededPriorToDisbursementCount { get { return _hoursDocumentsNeededPriorToDisbursementCount; } set { _hoursDocumentsNeededPriorToDisbursementCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoursDocumentsNeededPriorToDisbursementCount() => !_hoursDocumentsNeededPriorToDisbursementCount.Clean;
        private Value<bool?> _housingIndicator;
        public bool? HousingIndicator { get { return _housingIndicator; } set { _housingIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingIndicator() => !_housingIndicator.Clean;
        private Value<string> _housingProgramName;
        public string HousingProgramName { get { return _housingProgramName; } set { _housingProgramName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingProgramName() => !_housingProgramName.Clean;
        private Value<string> _hUD1FileNumberIdentifier;
        public string HUD1FileNumberIdentifier { get { return _hUD1FileNumberIdentifier; } set { _hUD1FileNumberIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1FileNumberIdentifier() => !_hUD1FileNumberIdentifier.Clean;
        private Value<string> _hUD1SettlementAgentUnparsedAddress;
        public string HUD1SettlementAgentUnparsedAddress { get { return _hUD1SettlementAgentUnparsedAddress; } set { _hUD1SettlementAgentUnparsedAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementAgentUnparsedAddress() => !_hUD1SettlementAgentUnparsedAddress.Clean;
        private Value<string> _hUD1SettlementAgentUnparsedName;
        public string HUD1SettlementAgentUnparsedName { get { return _hUD1SettlementAgentUnparsedName; } set { _hUD1SettlementAgentUnparsedName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementAgentUnparsedName() => !_hUD1SettlementAgentUnparsedName.Clean;
        private Value<DateTime?> _hUD1SettlementDate;
        public DateTime? HUD1SettlementDate { get { return _hUD1SettlementDate; } set { _hUD1SettlementDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementDate() => !_hUD1SettlementDate.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _includeSafeHaborDisclosure;
        public decimal? IncludeSafeHaborDisclosure { get { return _includeSafeHaborDisclosure; } set { _includeSafeHaborDisclosure = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeSafeHaborDisclosure() => !_includeSafeHaborDisclosure.Clean;
        private Value<string> _investorCode;
        public string InvestorCode { get { return _investorCode; } set { _investorCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCode() => !_investorCode.Clean;
        private Value<string> _lastAuditDate;
        public string LastAuditDate { get { return _lastAuditDate; } set { _lastAuditDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAuditDate() => !_lastAuditDate.Clean;
        private Value<string> _lastDocumentOrdered;
        public string LastDocumentOrdered { get { return _lastDocumentOrdered; } set { _lastDocumentOrdered = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDocumentOrdered() => !_lastDocumentOrdered.Clean;
        private Value<bool?> _legalAttached;
        public bool? LegalAttached { get { return _legalAttached; } set { _legalAttached = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalAttached() => !_legalAttached.Clean;
        private Value<string> _lenderAuthorizedRepresentativeTitle;
        public string LenderAuthorizedRepresentativeTitle { get { return _lenderAuthorizedRepresentativeTitle; } set { _lenderAuthorizedRepresentativeTitle = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepresentativeTitle() => !_lenderAuthorizedRepresentativeTitle.Clean;
        private Value<string> _lenderBrokerRepresents;
        public string LenderBrokerRepresents { get { return _lenderBrokerRepresents; } set { _lenderBrokerRepresents = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderBrokerRepresents() => !_lenderBrokerRepresents.Clean;
        private Value<string> _lienHolderAddress;
        public string LienHolderAddress { get { return _lienHolderAddress; } set { _lienHolderAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddress() => !_lienHolderAddress.Clean;
        private Value<string> _lienHolderAddressCity;
        public string LienHolderAddressCity { get { return _lienHolderAddressCity; } set { _lienHolderAddressCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressCity() => !_lienHolderAddressCity.Clean;
        private Value<string> _lienHolderAddressPostalCode;
        public string LienHolderAddressPostalCode { get { return _lienHolderAddressPostalCode; } set { _lienHolderAddressPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressPostalCode() => !_lienHolderAddressPostalCode.Clean;
        private Value<string> _lienHolderAddressState;
        public string LienHolderAddressState { get { return _lienHolderAddressState; } set { _lienHolderAddressState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressState() => !_lienHolderAddressState.Clean;
        private Value<string> _lienHolderName;
        public string LienHolderName { get { return _lienHolderName; } set { _lienHolderName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderName() => !_lienHolderName.Clean;
        private Value<bool?> _loanIsLocked;
        public bool? LoanIsLocked { get { return _loanIsLocked; } set { _loanIsLocked = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanIsLocked() => !_loanIsLocked.Clean;
        private Value<string> _loanOption;
        public string LoanOption { get { return _loanOption; } set { _loanOption = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOption() => !_loanOption.Clean;
        private Value<string> _lockInFeeType;
        public string LockInFeeType { get { return _lockInFeeType; } set { _lockInFeeType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockInFeeType() => !_lockInFeeType.Clean;
        private Value<string> _mfgHomeAnchored;
        public string MfgHomeAnchored { get { return _mfgHomeAnchored; } set { _mfgHomeAnchored = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeAnchored() => !_mfgHomeAnchored.Clean;
        private Value<string> _mfgHomeCertificateOfTitleIdentifier;
        public string MfgHomeCertificateOfTitleIdentifier { get { return _mfgHomeCertificateOfTitleIdentifier; } set { _mfgHomeCertificateOfTitleIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeCertificateOfTitleIdentifier() => !_mfgHomeCertificateOfTitleIdentifier.Clean;
        private Value<string> _mfgHomeCertificateOfTitleType;
        public string MfgHomeCertificateOfTitleType { get { return _mfgHomeCertificateOfTitleType; } set { _mfgHomeCertificateOfTitleType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeCertificateOfTitleType() => !_mfgHomeCertificateOfTitleType.Clean;
        private Value<string> _mfgHomeDescription;
        public string MfgHomeDescription { get { return _mfgHomeDescription; } set { _mfgHomeDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeDescription() => !_mfgHomeDescription.Clean;
        private Value<string> _mfgHomeHUDCertificationLabelIdentifier;
        public string MfgHomeHUDCertificationLabelIdentifier { get { return _mfgHomeHUDCertificationLabelIdentifier; } set { _mfgHomeHUDCertificationLabelIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeHUDCertificationLabelIdentifier() => !_mfgHomeHUDCertificationLabelIdentifier.Clean;
        private Value<int?> _mfgHomeLengthFeetCount;
        public int? MfgHomeLengthFeetCount { get { return _mfgHomeLengthFeetCount; } set { _mfgHomeLengthFeetCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeLengthFeetCount() => !_mfgHomeLengthFeetCount.Clean;
        private Value<string> _mfgHomeMakeIdentifier;
        public string MfgHomeMakeIdentifier { get { return _mfgHomeMakeIdentifier; } set { _mfgHomeMakeIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeMakeIdentifier() => !_mfgHomeMakeIdentifier.Clean;
        private Value<string> _mfgHomeManufacturer;
        public string MfgHomeManufacturer { get { return _mfgHomeManufacturer; } set { _mfgHomeManufacturer = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturer() => !_mfgHomeManufacturer.Clean;
        private Value<string> _mfgHomeManufacturerAddress;
        public string MfgHomeManufacturerAddress { get { return _mfgHomeManufacturerAddress; } set { _mfgHomeManufacturerAddress = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerAddress() => !_mfgHomeManufacturerAddress.Clean;
        private Value<string> _mfgHomeManufacturerCity;
        public string MfgHomeManufacturerCity { get { return _mfgHomeManufacturerCity; } set { _mfgHomeManufacturerCity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerCity() => !_mfgHomeManufacturerCity.Clean;
        private Value<string> _mfgHomeManufacturerPhoneNumber;
        public string MfgHomeManufacturerPhoneNumber { get { return _mfgHomeManufacturerPhoneNumber; } set { _mfgHomeManufacturerPhoneNumber = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerPhoneNumber() => !_mfgHomeManufacturerPhoneNumber.Clean;
        private Value<string> _mfgHomeManufacturerPostalCode;
        public string MfgHomeManufacturerPostalCode { get { return _mfgHomeManufacturerPostalCode; } set { _mfgHomeManufacturerPostalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerPostalCode() => !_mfgHomeManufacturerPostalCode.Clean;
        private Value<string> _mfgHomeManufacturerState;
        public string MfgHomeManufacturerState { get { return _mfgHomeManufacturerState; } set { _mfgHomeManufacturerState = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerState() => !_mfgHomeManufacturerState.Clean;
        private Value<int?> _mfgHomeManufactureYear;
        public int? MfgHomeManufactureYear { get { return _mfgHomeManufactureYear; } set { _mfgHomeManufactureYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufactureYear() => !_mfgHomeManufactureYear.Clean;
        private Value<string> _mfgHomeModelIdentifier;
        public string MfgHomeModelIdentifier { get { return _mfgHomeModelIdentifier; } set { _mfgHomeModelIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeModelIdentifier() => !_mfgHomeModelIdentifier.Clean;
        private Value<string> _mfgHomeNewOrUsed;
        public string MfgHomeNewOrUsed { get { return _mfgHomeNewOrUsed; } set { _mfgHomeNewOrUsed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeNewOrUsed() => !_mfgHomeNewOrUsed.Clean;
        private Value<string> _mfgHomeSerialNumberIdentifier;
        public string MfgHomeSerialNumberIdentifier { get { return _mfgHomeSerialNumberIdentifier; } set { _mfgHomeSerialNumberIdentifier = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeSerialNumberIdentifier() => !_mfgHomeSerialNumberIdentifier.Clean;
        private Value<int?> _mfgHomeWidthFeetCount;
        public int? MfgHomeWidthFeetCount { get { return _mfgHomeWidthFeetCount; } set { _mfgHomeWidthFeetCount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeWidthFeetCount() => !_mfgHomeWidthFeetCount.Clean;
        private Value<string> _mineralRightsDescription;
        public string MineralRightsDescription { get { return _mineralRightsDescription; } set { _mineralRightsDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMineralRightsDescription() => !_mineralRightsDescription.Clean;
        private Value<string> _mortgageType;
        public string MortgageType { get { return _mortgageType; } set { _mortgageType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageType() => !_mortgageType.Clean;
        private Value<int?> _numberBrokerAgreements;
        public int? NumberBrokerAgreements { get { return _numberBrokerAgreements; } set { _numberBrokerAgreements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberBrokerAgreements() => !_numberBrokerAgreements.Clean;
        private Value<int?> _numberSuccessfulBrokerAgreements;
        public int? NumberSuccessfulBrokerAgreements { get { return _numberSuccessfulBrokerAgreements; } set { _numberSuccessfulBrokerAgreements = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberSuccessfulBrokerAgreements() => !_numberSuccessfulBrokerAgreements.Clean;
        private Value<string> _officeOfRecordationName;
        public string OfficeOfRecordationName { get { return _officeOfRecordationName; } set { _officeOfRecordationName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficeOfRecordationName() => !_officeOfRecordationName.Clean;
        private Value<bool?> _onlyOneEntity;
        public bool? OnlyOneEntity { get { return _onlyOneEntity; } set { _onlyOneEntity = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOnlyOneEntity() => !_onlyOneEntity.Clean;
        private Value<string> _optionSelectedReason;
        public string OptionSelectedReason { get { return _optionSelectedReason; } set { _optionSelectedReason = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptionSelectedReason() => !_optionSelectedReason.Clean;
        private Value<decimal?> _originalPincipalAmountSecured;
        public decimal? OriginalPincipalAmountSecured { get { return _originalPincipalAmountSecured; } set { _originalPincipalAmountSecured = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalPincipalAmountSecured() => !_originalPincipalAmountSecured.Clean;
        private Value<string> _otherOptionDescription;
        public string OtherOptionDescription { get { return _otherOptionDescription; } set { _otherOptionDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherOptionDescription() => !_otherOptionDescription.Clean;
        private Value<string> _parentAffiliatedCoName;
        public string ParentAffiliatedCoName { get { return _parentAffiliatedCoName; } set { _parentAffiliatedCoName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentAffiliatedCoName() => !_parentAffiliatedCoName.Clean;
        private Value<string> _payToTheOrderOfDescription;
        public string PayToTheOrderOfDescription { get { return _payToTheOrderOfDescription; } set { _payToTheOrderOfDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayToTheOrderOfDescription() => !_payToTheOrderOfDescription.Clean;
        private Value<string> _perDiemCalculationMethodType;
        public string PerDiemCalculationMethodType { get { return _perDiemCalculationMethodType; } set { _perDiemCalculationMethodType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerDiemCalculationMethodType() => !_perDiemCalculationMethodType.Clean;
        private Value<string> _planCode;
        public string PlanCode { get { return _planCode; } set { _planCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCode() => !_planCode.Clean;
        private Value<string> _planCodeDescription;
        public string PlanCodeDescription { get { return _planCodeDescription; } set { _planCodeDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCodeDescription() => !_planCodeDescription.Clean;
        private Value<string> _planCodeId;
        public string PlanCodeId { get { return _planCodeId; } set { _planCodeId = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCodeId() => !_planCodeId.Clean;
        private Value<DateTime?> _preliminaryTitleReportDate;
        public DateTime? PreliminaryTitleReportDate { get { return _preliminaryTitleReportDate; } set { _preliminaryTitleReportDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryTitleReportDate() => !_preliminaryTitleReportDate.Clean;
        private Value<string> _prepaymentPenaltyDescriptions1;
        public string PrepaymentPenaltyDescriptions1 { get { return _prepaymentPenaltyDescriptions1; } set { _prepaymentPenaltyDescriptions1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions1() => !_prepaymentPenaltyDescriptions1.Clean;
        private Value<string> _prepaymentPenaltyDescriptions2;
        public string PrepaymentPenaltyDescriptions2 { get { return _prepaymentPenaltyDescriptions2; } set { _prepaymentPenaltyDescriptions2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions2() => !_prepaymentPenaltyDescriptions2.Clean;
        private Value<string> _prepaymentPenaltyDescriptions3;
        public string PrepaymentPenaltyDescriptions3 { get { return _prepaymentPenaltyDescriptions3; } set { _prepaymentPenaltyDescriptions3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions3() => !_prepaymentPenaltyDescriptions3.Clean;
        private Value<int?> _processingNumberDays;
        public int? ProcessingNumberDays { get { return _processingNumberDays; } set { _processingNumberDays = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingNumberDays() => !_processingNumberDays.Clean;
        private Value<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramCode() => !_programCode.Clean;
        private Value<string> _programSponsor;
        public string ProgramSponsor { get { return _programSponsor; } set { _programSponsor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramSponsor() => !_programSponsor.Clean;
        private Value<bool?> _propertyIsLandTrust;
        public bool? PropertyIsLandTrust { get { return _propertyIsLandTrust; } set { _propertyIsLandTrust = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyIsLandTrust() => !_propertyIsLandTrust.Clean;
        private Value<string> _propertyTaxMessageDescription;
        public string PropertyTaxMessageDescription { get { return _propertyTaxMessageDescription; } set { _propertyTaxMessageDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyTaxMessageDescription() => !_propertyTaxMessageDescription.Clean;
        private Value<string> _rateLockRefundConditions1;
        public string RateLockRefundConditions1 { get { return _rateLockRefundConditions1; } set { _rateLockRefundConditions1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions1() => !_rateLockRefundConditions1.Clean;
        private Value<string> _rateLockRefundConditions2;
        public string RateLockRefundConditions2 { get { return _rateLockRefundConditions2; } set { _rateLockRefundConditions2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions2() => !_rateLockRefundConditions2.Clean;
        private Value<string> _rateLockRefundConditions3;
        public string RateLockRefundConditions3 { get { return _rateLockRefundConditions3; } set { _rateLockRefundConditions3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions3() => !_rateLockRefundConditions3.Clean;
        private Value<string> _recordingJurisdictionName;
        public string RecordingJurisdictionName { get { return _recordingJurisdictionName; } set { _recordingJurisdictionName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordingJurisdictionName() => !_recordingJurisdictionName.Clean;
        private Value<bool?> _refinanceBalloonMortgageGuarantee;
        public bool? RefinanceBalloonMortgageGuarantee { get { return _refinanceBalloonMortgageGuarantee; } set { _refinanceBalloonMortgageGuarantee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceBalloonMortgageGuarantee() => !_refinanceBalloonMortgageGuarantee.Clean;
        private Value<bool?> _refinanceRightOfRescissionExemptFlag;
        public bool? RefinanceRightOfRescissionExemptFlag { get { return _refinanceRightOfRescissionExemptFlag; } set { _refinanceRightOfRescissionExemptFlag = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceRightOfRescissionExemptFlag() => !_refinanceRightOfRescissionExemptFlag.Clean;
        private Value<string> _renewalExtensionDescription;
        public string RenewalExtensionDescription { get { return _renewalExtensionDescription; } set { _renewalExtensionDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRenewalExtensionDescription() => !_renewalExtensionDescription.Clean;
        private Value<DateTime?> _rescissionDate;
        public DateTime? RescissionDate { get { return _rescissionDate; } set { _rescissionDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRescissionDate() => !_rescissionDate.Clean;
        private Value<List<RespaHudDetail>> _respaHudDetails;
        public List<RespaHudDetail> RespaHudDetails { get { return _respaHudDetails; } set { _respaHudDetails = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRespaHudDetails() => !_respaHudDetails.Clean;
        private Value<string> _rMLANamePreceding10Years;
        public string RMLANamePreceding10Years { get { return _rMLANamePreceding10Years; } set { _rMLANamePreceding10Years = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRMLANamePreceding10Years() => !_rMLANamePreceding10Years.Clean;
        private Value<string> _rmlLenderBrokerRepresents;
        public string RmlLenderBrokerRepresents { get { return _rmlLenderBrokerRepresents; } set { _rmlLenderBrokerRepresents = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRmlLenderBrokerRepresents() => !_rmlLenderBrokerRepresents.Clean;
        private Value<string> _secondTransferYear;
        public string SecondTransferYear { get { return _secondTransferYear; } set { _secondTransferYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondTransferYear() => !_secondTransferYear.Clean;
        private Value<decimal?> _secondTransferYearValue;
        public decimal? SecondTransferYearValue { get { return _secondTransferYearValue; } set { _secondTransferYearValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondTransferYearValue() => !_secondTransferYearValue.Clean;
        private Value<DateTime?> _signatureDateFor1003;
        public DateTime? SignatureDateFor1003 { get { return _signatureDateFor1003; } set { _signatureDateFor1003 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureDateFor1003() => !_signatureDateFor1003.Clean;
        private Value<string> _specialFloodHazardAreaIndictor;
        public string SpecialFloodHazardAreaIndictor { get { return _specialFloodHazardAreaIndictor; } set { _specialFloodHazardAreaIndictor = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFloodHazardAreaIndictor() => !_specialFloodHazardAreaIndictor.Clean;
        private Value<List<StateLicense>> _stateLicenses;
        public List<StateLicense> StateLicenses { get { return _stateLicenses; } set { _stateLicenses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateLicenses() => !_stateLicenses.Clean;
        private Value<string> _suretyCompanyName;
        public string SuretyCompanyName { get { return _suretyCompanyName; } set { _suretyCompanyName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuretyCompanyName() => !_suretyCompanyName.Clean;
        private Value<bool?> _syncInterestDateDisbursementDate;
        public bool? SyncInterestDateDisbursementDate { get { return _syncInterestDateDisbursementDate; } set { _syncInterestDateDisbursementDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSyncInterestDateDisbursementDate() => !_syncInterestDateDisbursementDate.Clean;
        private Value<string> _termiteReportRequiredIndicator;
        public string TermiteReportRequiredIndicator { get { return _termiteReportRequiredIndicator; } set { _termiteReportRequiredIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermiteReportRequiredIndicator() => !_termiteReportRequiredIndicator.Clean;
        private Value<string> _textDescription;
        public string TextDescription { get { return _textDescription; } set { _textDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTextDescription() => !_textDescription.Clean;
        private Value<string> _thirdTransferYear;
        public string ThirdTransferYear { get { return _thirdTransferYear; } set { _thirdTransferYear = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdTransferYear() => !_thirdTransferYear.Clean;
        private Value<decimal?> _thirdTransferYearValue;
        public decimal? ThirdTransferYearValue { get { return _thirdTransferYearValue; } set { _thirdTransferYearValue = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdTransferYearValue() => !_thirdTransferYearValue.Clean;
        private Value<string> _titleReportItemsDescription;
        public string TitleReportItemsDescription { get { return _titleReportItemsDescription; } set { _titleReportItemsDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleReportItemsDescription() => !_titleReportItemsDescription.Clean;
        private Value<string> _titleReportRequiredEndorsementsDescription;
        public string TitleReportRequiredEndorsementsDescription { get { return _titleReportRequiredEndorsementsDescription; } set { _titleReportRequiredEndorsementsDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleReportRequiredEndorsementsDescription() => !_titleReportRequiredEndorsementsDescription.Clean;
        private Value<decimal?> _totalDisbursed;
        public decimal? TotalDisbursed { get { return _totalDisbursed; } set { _totalDisbursed = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDisbursed() => !_totalDisbursed.Clean;
        private Value<string> _trust2Beneficiaries;
        public string Trust2Beneficiaries { get { return _trust2Beneficiaries; } set { _trust2Beneficiaries = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrust2Beneficiaries() => !_trust2Beneficiaries.Clean;
        private Value<string> _weConductBusiness;
        public string WeConductBusiness { get { return _weConductBusiness; } set { _weConductBusiness = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeConductBusiness() => !_weConductBusiness.Clean;
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
                var v0 = _additionalLienHolderAddress; v0.Clean = value; _additionalLienHolderAddress = v0;
                var v1 = _additionalLienHolderAddressCity; v1.Clean = value; _additionalLienHolderAddressCity = v1;
                var v2 = _additionalLienHolderAddressPostalCode; v2.Clean = value; _additionalLienHolderAddressPostalCode = v2;
                var v3 = _additionalLienHolderAddressState; v3.Clean = value; _additionalLienHolderAddressState = v3;
                var v4 = _additionalLienHolderName; v4.Clean = value; _additionalLienHolderName = v4;
                var v5 = _additionalOriginalPincipalAmountSecured; v5.Clean = value; _additionalOriginalPincipalAmountSecured = v5;
                var v6 = _additionalSigVerbiageType; v6.Clean = value; _additionalSigVerbiageType = v6;
                var v7 = _additionalStateDisclosures; v7.Clean = value; _additionalStateDisclosures = v7;
                var v8 = _affectedByInterest; v8.Clean = value; _affectedByInterest = v8;
                var v9 = _alternateLender; v9.Clean = value; _alternateLender = v9;
                var v10 = _altLenderId; v10.Clean = value; _altLenderId = v10;
                var v11 = _antiSteeringLoanOptions; v11.Clean = value; _antiSteeringLoanOptions = v11;
                var v12 = _areAbleToServiceIndicator; v12.Clean = value; _areAbleToServiceIndicator = v12;
                var v13 = _associatedDocumentNumber; v13.Clean = value; _associatedDocumentNumber = v13;
                var v14 = _beneficiaries; v14.Clean = value; _beneficiaries = v14;
                var v15 = _borrowerConsentType1; v15.Clean = value; _borrowerConsentType1 = v15;
                var v16 = _borrowerConsentType2; v16.Clean = value; _borrowerConsentType2 = v16;
                var v17 = _borrowerOrganizationType1; v17.Clean = value; _borrowerOrganizationType1 = v17;
                var v18 = _borrowerOrganizationType2; v18.Clean = value; _borrowerOrganizationType2 = v18;
                var v19 = _borrowerOrganizedUnderTheLawsOfJurisdictionName1; v19.Clean = value; _borrowerOrganizedUnderTheLawsOfJurisdictionName1 = v19;
                var v20 = _borrowerOrganizedUnderTheLawsOfJurisdictionName2; v20.Clean = value; _borrowerOrganizedUnderTheLawsOfJurisdictionName2 = v20;
                var v21 = _borrowerTaxIdentificationNumberIdentifier1; v21.Clean = value; _borrowerTaxIdentificationNumberIdentifier1 = v21;
                var v22 = _borrowerTaxIdentificationNumberIdentifier2; v22.Clean = value; _borrowerTaxIdentificationNumberIdentifier2 = v22;
                var v23 = _borrowerTrustAmendedDateOrYear1; v23.Clean = value; _borrowerTrustAmendedDateOrYear1 = v23;
                var v24 = _borrowerTrustAmendedDateOrYear2; v24.Clean = value; _borrowerTrustAmendedDateOrYear2 = v24;
                var v25 = _borrowerTrustDateOrYear1; v25.Clean = value; _borrowerTrustDateOrYear1 = v25;
                var v26 = _borrowerTrustDateOrYear2; v26.Clean = value; _borrowerTrustDateOrYear2 = v26;
                var v27 = _borrowerUnparsedName1; v27.Clean = value; _borrowerUnparsedName1 = v27;
                var v28 = _borrowerUnparsedName2; v28.Clean = value; _borrowerUnparsedName2 = v28;
                var v29 = _brokerAuthorizedRepresentativeTitle; v29.Clean = value; _brokerAuthorizedRepresentativeTitle = v29;
                var v30 = _brokerCompensationMethod; v30.Clean = value; _brokerCompensationMethod = v30;
                var v31 = _brokerFeeRefundConditions1; v31.Clean = value; _brokerFeeRefundConditions1 = v31;
                var v32 = _brokerFeeRefundConditions2; v32.Clean = value; _brokerFeeRefundConditions2 = v32;
                var v33 = _brokerFeeRefundConditions3; v33.Clean = value; _brokerFeeRefundConditions3 = v33;
                var v34 = _brokerForPlacingLoan; v34.Clean = value; _brokerForPlacingLoan = v34;
                var v35 = _brokerInterestRateEffect; v35.Clean = value; _brokerInterestRateEffect = v35;
                var v36 = _brokerLenderRelationship; v36.Clean = value; _brokerLenderRelationship = v36;
                var v37 = _brokerLicenseNumberIdentifier; v37.Clean = value; _brokerLicenseNumberIdentifier = v37;
                var v38 = _brokerNameAsLicensed; v38.Clean = value; _brokerNameAsLicensed = v38;
                var v39 = _brokerTaxIdentificationNumberIdentifier; v39.Clean = value; _brokerTaxIdentificationNumberIdentifier = v39;
                var v40 = _brokerWithLenders; v40.Clean = value; _brokerWithLenders = v40;
                var v41 = _cashCheckFromBorrower; v41.Clean = value; _cashCheckFromBorrower = v41;
                var v42 = _closingDocsLoanProgramType; v42.Clean = value; _closingDocsLoanProgramType = v42;
                var v43 = _closingEntities; v43.Clean = value; _closingEntities = v43;
                var v44 = _closingProvider; v44.Clean = value; _closingProvider = v44;
                var v45 = _closingState; v45.Clean = value; _closingState = v45;
                var v46 = _complianceJurisdictionCounty; v46.Clean = value; _complianceJurisdictionCounty = v46;
                var v47 = _compliancePropertyIdentifiedDate; v47.Clean = value; _compliancePropertyIdentifiedDate = v47;
                var v48 = _conditionDescription; v48.Clean = value; _conditionDescription = v48;
                var v49 = _conflictofInterestCheck1; v49.Clean = value; _conflictofInterestCheck1 = v49;
                var v50 = _conflictofInterestCheck2; v50.Clean = value; _conflictofInterestCheck2 = v50;
                var v51 = _conflictofInterestCheck3; v51.Clean = value; _conflictofInterestCheck3 = v51;
                var v52 = _conflictofInterestCheck4; v52.Clean = value; _conflictofInterestCheck4 = v52;
                var v53 = _conflictofInterestCheck5; v53.Clean = value; _conflictofInterestCheck5 = v53;
                var v54 = _conflictofInterestCheck6; v54.Clean = value; _conflictofInterestCheck6 = v54;
                var v55 = _coopApartmentNumber; v55.Clean = value; _coopApartmentNumber = v55;
                var v56 = _coopAssignmentLeaseDate; v56.Clean = value; _coopAssignmentLeaseDate = v56;
                var v57 = _coopAttorneyInFact; v57.Clean = value; _coopAttorneyInFact = v57;
                var v58 = _coopBuildingName; v58.Clean = value; _coopBuildingName = v58;
                var v59 = _coopCompanyExistsUnderTHeLawsOf; v59.Clean = value; _coopCompanyExistsUnderTHeLawsOf = v59;
                var v60 = _coopCompanyName; v60.Clean = value; _coopCompanyName = v60;
                var v61 = _coopProprietaryLeaseDate; v61.Clean = value; _coopProprietaryLeaseDate = v61;
                var v62 = _coopSharesOwned; v62.Clean = value; _coopSharesOwned = v62;
                var v63 = _coopStockCertificationNumber; v63.Clean = value; _coopStockCertificationNumber = v63;
                var v64 = _coopVacancyPercentNotification; v64.Clean = value; _coopVacancyPercentNotification = v64;
                var v65 = _customOtherRiderDescription; v65.Clean = value; _customOtherRiderDescription = v65;
                var v66 = _disbursementDate; v66.Clean = value; _disbursementDate = v66;
                var v67 = _disbursementsToBorrower; v67.Clean = value; _disbursementsToBorrower = v67;
                var v68 = _disclosureAlternateLender; v68.Clean = value; _disclosureAlternateLender = v68;
                var v69 = _disclosureCompanyFunction; v69.Clean = value; _disclosureCompanyFunction = v69;
                var v70 = _disclosurePlanCode; v70.Clean = value; _disclosurePlanCode = v70;
                var v71 = _docReportGUID; v71.Clean = value; _docReportGUID = v71;
                var v72 = _documentPreparationDate; v72.Clean = value; _documentPreparationDate = v72;
                var v73 = _documentSigningDate; v73.Clean = value; _documentSigningDate = v73;
                var v74 = _drawCity; v74.Clean = value; _drawCity = v74;
                var v75 = _drawCounty; v75.Clean = value; _drawCounty = v75;
                var v76 = _drawState; v76.Clean = value; _drawState = v76;
                var v77 = _employeeofMortgageLender; v77.Clean = value; _employeeofMortgageLender = v77;
                var v78 = _expectToAssignSellOrTransferPercent; v78.Clean = value; _expectToAssignSellOrTransferPercent = v78;
                var v79 = _finalVestingDescription; v79.Clean = value; _finalVestingDescription = v79;
                var v80 = _firstTransferYear; v80.Clean = value; _firstTransferYear = v80;
                var v81 = _firstTransferYearValue; v81.Clean = value; _firstTransferYearValue = v81;
                var v82 = _hoursDocumentsNeededPriorToDisbursementCount; v82.Clean = value; _hoursDocumentsNeededPriorToDisbursementCount = v82;
                var v83 = _housingIndicator; v83.Clean = value; _housingIndicator = v83;
                var v84 = _housingProgramName; v84.Clean = value; _housingProgramName = v84;
                var v85 = _hUD1FileNumberIdentifier; v85.Clean = value; _hUD1FileNumberIdentifier = v85;
                var v86 = _hUD1SettlementAgentUnparsedAddress; v86.Clean = value; _hUD1SettlementAgentUnparsedAddress = v86;
                var v87 = _hUD1SettlementAgentUnparsedName; v87.Clean = value; _hUD1SettlementAgentUnparsedName = v87;
                var v88 = _hUD1SettlementDate; v88.Clean = value; _hUD1SettlementDate = v88;
                var v89 = _id; v89.Clean = value; _id = v89;
                var v90 = _includeSafeHaborDisclosure; v90.Clean = value; _includeSafeHaborDisclosure = v90;
                var v91 = _investorCode; v91.Clean = value; _investorCode = v91;
                var v92 = _lastAuditDate; v92.Clean = value; _lastAuditDate = v92;
                var v93 = _lastDocumentOrdered; v93.Clean = value; _lastDocumentOrdered = v93;
                var v94 = _legalAttached; v94.Clean = value; _legalAttached = v94;
                var v95 = _lenderAuthorizedRepresentativeTitle; v95.Clean = value; _lenderAuthorizedRepresentativeTitle = v95;
                var v96 = _lenderBrokerRepresents; v96.Clean = value; _lenderBrokerRepresents = v96;
                var v97 = _lienHolderAddress; v97.Clean = value; _lienHolderAddress = v97;
                var v98 = _lienHolderAddressCity; v98.Clean = value; _lienHolderAddressCity = v98;
                var v99 = _lienHolderAddressPostalCode; v99.Clean = value; _lienHolderAddressPostalCode = v99;
                var v100 = _lienHolderAddressState; v100.Clean = value; _lienHolderAddressState = v100;
                var v101 = _lienHolderName; v101.Clean = value; _lienHolderName = v101;
                var v102 = _loanIsLocked; v102.Clean = value; _loanIsLocked = v102;
                var v103 = _loanOption; v103.Clean = value; _loanOption = v103;
                var v104 = _lockInFeeType; v104.Clean = value; _lockInFeeType = v104;
                var v105 = _mfgHomeAnchored; v105.Clean = value; _mfgHomeAnchored = v105;
                var v106 = _mfgHomeCertificateOfTitleIdentifier; v106.Clean = value; _mfgHomeCertificateOfTitleIdentifier = v106;
                var v107 = _mfgHomeCertificateOfTitleType; v107.Clean = value; _mfgHomeCertificateOfTitleType = v107;
                var v108 = _mfgHomeDescription; v108.Clean = value; _mfgHomeDescription = v108;
                var v109 = _mfgHomeHUDCertificationLabelIdentifier; v109.Clean = value; _mfgHomeHUDCertificationLabelIdentifier = v109;
                var v110 = _mfgHomeLengthFeetCount; v110.Clean = value; _mfgHomeLengthFeetCount = v110;
                var v111 = _mfgHomeMakeIdentifier; v111.Clean = value; _mfgHomeMakeIdentifier = v111;
                var v112 = _mfgHomeManufacturer; v112.Clean = value; _mfgHomeManufacturer = v112;
                var v113 = _mfgHomeManufacturerAddress; v113.Clean = value; _mfgHomeManufacturerAddress = v113;
                var v114 = _mfgHomeManufacturerCity; v114.Clean = value; _mfgHomeManufacturerCity = v114;
                var v115 = _mfgHomeManufacturerPhoneNumber; v115.Clean = value; _mfgHomeManufacturerPhoneNumber = v115;
                var v116 = _mfgHomeManufacturerPostalCode; v116.Clean = value; _mfgHomeManufacturerPostalCode = v116;
                var v117 = _mfgHomeManufacturerState; v117.Clean = value; _mfgHomeManufacturerState = v117;
                var v118 = _mfgHomeManufactureYear; v118.Clean = value; _mfgHomeManufactureYear = v118;
                var v119 = _mfgHomeModelIdentifier; v119.Clean = value; _mfgHomeModelIdentifier = v119;
                var v120 = _mfgHomeNewOrUsed; v120.Clean = value; _mfgHomeNewOrUsed = v120;
                var v121 = _mfgHomeSerialNumberIdentifier; v121.Clean = value; _mfgHomeSerialNumberIdentifier = v121;
                var v122 = _mfgHomeWidthFeetCount; v122.Clean = value; _mfgHomeWidthFeetCount = v122;
                var v123 = _mineralRightsDescription; v123.Clean = value; _mineralRightsDescription = v123;
                var v124 = _mortgageType; v124.Clean = value; _mortgageType = v124;
                var v125 = _numberBrokerAgreements; v125.Clean = value; _numberBrokerAgreements = v125;
                var v126 = _numberSuccessfulBrokerAgreements; v126.Clean = value; _numberSuccessfulBrokerAgreements = v126;
                var v127 = _officeOfRecordationName; v127.Clean = value; _officeOfRecordationName = v127;
                var v128 = _onlyOneEntity; v128.Clean = value; _onlyOneEntity = v128;
                var v129 = _optionSelectedReason; v129.Clean = value; _optionSelectedReason = v129;
                var v130 = _originalPincipalAmountSecured; v130.Clean = value; _originalPincipalAmountSecured = v130;
                var v131 = _otherOptionDescription; v131.Clean = value; _otherOptionDescription = v131;
                var v132 = _parentAffiliatedCoName; v132.Clean = value; _parentAffiliatedCoName = v132;
                var v133 = _payToTheOrderOfDescription; v133.Clean = value; _payToTheOrderOfDescription = v133;
                var v134 = _perDiemCalculationMethodType; v134.Clean = value; _perDiemCalculationMethodType = v134;
                var v135 = _planCode; v135.Clean = value; _planCode = v135;
                var v136 = _planCodeDescription; v136.Clean = value; _planCodeDescription = v136;
                var v137 = _planCodeId; v137.Clean = value; _planCodeId = v137;
                var v138 = _preliminaryTitleReportDate; v138.Clean = value; _preliminaryTitleReportDate = v138;
                var v139 = _prepaymentPenaltyDescriptions1; v139.Clean = value; _prepaymentPenaltyDescriptions1 = v139;
                var v140 = _prepaymentPenaltyDescriptions2; v140.Clean = value; _prepaymentPenaltyDescriptions2 = v140;
                var v141 = _prepaymentPenaltyDescriptions3; v141.Clean = value; _prepaymentPenaltyDescriptions3 = v141;
                var v142 = _processingNumberDays; v142.Clean = value; _processingNumberDays = v142;
                var v143 = _programCode; v143.Clean = value; _programCode = v143;
                var v144 = _programSponsor; v144.Clean = value; _programSponsor = v144;
                var v145 = _propertyIsLandTrust; v145.Clean = value; _propertyIsLandTrust = v145;
                var v146 = _propertyTaxMessageDescription; v146.Clean = value; _propertyTaxMessageDescription = v146;
                var v147 = _rateLockRefundConditions1; v147.Clean = value; _rateLockRefundConditions1 = v147;
                var v148 = _rateLockRefundConditions2; v148.Clean = value; _rateLockRefundConditions2 = v148;
                var v149 = _rateLockRefundConditions3; v149.Clean = value; _rateLockRefundConditions3 = v149;
                var v150 = _recordingJurisdictionName; v150.Clean = value; _recordingJurisdictionName = v150;
                var v151 = _refinanceBalloonMortgageGuarantee; v151.Clean = value; _refinanceBalloonMortgageGuarantee = v151;
                var v152 = _refinanceRightOfRescissionExemptFlag; v152.Clean = value; _refinanceRightOfRescissionExemptFlag = v152;
                var v153 = _renewalExtensionDescription; v153.Clean = value; _renewalExtensionDescription = v153;
                var v154 = _rescissionDate; v154.Clean = value; _rescissionDate = v154;
                var v155 = _respaHudDetails; v155.Clean = value; _respaHudDetails = v155;
                var v156 = _rMLANamePreceding10Years; v156.Clean = value; _rMLANamePreceding10Years = v156;
                var v157 = _rmlLenderBrokerRepresents; v157.Clean = value; _rmlLenderBrokerRepresents = v157;
                var v158 = _secondTransferYear; v158.Clean = value; _secondTransferYear = v158;
                var v159 = _secondTransferYearValue; v159.Clean = value; _secondTransferYearValue = v159;
                var v160 = _signatureDateFor1003; v160.Clean = value; _signatureDateFor1003 = v160;
                var v161 = _specialFloodHazardAreaIndictor; v161.Clean = value; _specialFloodHazardAreaIndictor = v161;
                var v162 = _stateLicenses; v162.Clean = value; _stateLicenses = v162;
                var v163 = _suretyCompanyName; v163.Clean = value; _suretyCompanyName = v163;
                var v164 = _syncInterestDateDisbursementDate; v164.Clean = value; _syncInterestDateDisbursementDate = v164;
                var v165 = _termiteReportRequiredIndicator; v165.Clean = value; _termiteReportRequiredIndicator = v165;
                var v166 = _textDescription; v166.Clean = value; _textDescription = v166;
                var v167 = _thirdTransferYear; v167.Clean = value; _thirdTransferYear = v167;
                var v168 = _thirdTransferYearValue; v168.Clean = value; _thirdTransferYearValue = v168;
                var v169 = _titleReportItemsDescription; v169.Clean = value; _titleReportItemsDescription = v169;
                var v170 = _titleReportRequiredEndorsementsDescription; v170.Clean = value; _titleReportRequiredEndorsementsDescription = v170;
                var v171 = _totalDisbursed; v171.Clean = value; _totalDisbursed = v171;
                var v172 = _trust2Beneficiaries; v172.Clean = value; _trust2Beneficiaries = v172;
                var v173 = _weConductBusiness; v173.Clean = value; _weConductBusiness = v173;
                _settingClean = 0;
            }
        }
    }
}