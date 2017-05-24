using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDocument
    {
        public Value<string> AdditionalLienHolderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddress() => !AdditionalLienHolderAddress.Clean;
        public Value<string> AdditionalLienHolderAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressCity() => !AdditionalLienHolderAddressCity.Clean;
        public Value<string> AdditionalLienHolderAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressPostalCode() => !AdditionalLienHolderAddressPostalCode.Clean;
        public Value<string> AdditionalLienHolderAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderAddressState() => !AdditionalLienHolderAddressState.Clean;
        public Value<string> AdditionalLienHolderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalLienHolderName() => !AdditionalLienHolderName.Clean;
        public Value<decimal?> AdditionalOriginalPincipalAmountSecured { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalOriginalPincipalAmountSecured() => !AdditionalOriginalPincipalAmountSecured.Clean;
        public Value<string> AdditionalSigVerbiageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalSigVerbiageType() => !AdditionalSigVerbiageType.Clean;
        public Value<List<AdditionalStateDisclosure>> AdditionalStateDisclosures { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalStateDisclosures() => !AdditionalStateDisclosures.Clean;
        public Value<bool?> AffectedByInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffectedByInterest() => !AffectedByInterest.Clean;
        public Value<string> AlternateLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlternateLender() => !AlternateLender.Clean;
        public Value<string> AltLenderId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltLenderId() => !AltLenderId.Clean;
        public Value<List<AntiSteeringLoanOption>> AntiSteeringLoanOptions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAntiSteeringLoanOptions() => !AntiSteeringLoanOptions.Clean;
        public Value<string> AreAbleToServiceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAreAbleToServiceIndicator() => !AreAbleToServiceIndicator.Clean;
        public Value<string> AssociatedDocumentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAssociatedDocumentNumber() => !AssociatedDocumentNumber.Clean;
        public Value<string> Beneficiaries { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBeneficiaries() => !Beneficiaries.Clean;
        public Value<bool?> BorrowerConsentType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerConsentType1() => !BorrowerConsentType1.Clean;
        public Value<bool?> BorrowerConsentType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerConsentType2() => !BorrowerConsentType2.Clean;
        public Value<string> BorrowerOrganizationType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizationType1() => !BorrowerOrganizationType1.Clean;
        public Value<string> BorrowerOrganizationType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizationType2() => !BorrowerOrganizationType2.Clean;
        public Value<string> BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizedUnderTheLawsOfJurisdictionName1() => !BorrowerOrganizedUnderTheLawsOfJurisdictionName1.Clean;
        public Value<string> BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerOrganizedUnderTheLawsOfJurisdictionName2() => !BorrowerOrganizedUnderTheLawsOfJurisdictionName2.Clean;
        public Value<string> BorrowerTaxIdentificationNumberIdentifier1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTaxIdentificationNumberIdentifier1() => !BorrowerTaxIdentificationNumberIdentifier1.Clean;
        public Value<string> BorrowerTaxIdentificationNumberIdentifier2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTaxIdentificationNumberIdentifier2() => !BorrowerTaxIdentificationNumberIdentifier2.Clean;
        public Value<string> BorrowerTrustAmendedDateOrYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustAmendedDateOrYear1() => !BorrowerTrustAmendedDateOrYear1.Clean;
        public Value<string> BorrowerTrustAmendedDateOrYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustAmendedDateOrYear2() => !BorrowerTrustAmendedDateOrYear2.Clean;
        public Value<string> BorrowerTrustDateOrYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustDateOrYear1() => !BorrowerTrustDateOrYear1.Clean;
        public Value<string> BorrowerTrustDateOrYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTrustDateOrYear2() => !BorrowerTrustDateOrYear2.Clean;
        public Value<string> BorrowerUnparsedName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerUnparsedName1() => !BorrowerUnparsedName1.Clean;
        public Value<string> BorrowerUnparsedName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerUnparsedName2() => !BorrowerUnparsedName2.Clean;
        public Value<string> BrokerAuthorizedRepresentativeTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAuthorizedRepresentativeTitle() => !BrokerAuthorizedRepresentativeTitle.Clean;
        public Value<string> BrokerCompensationMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationMethod() => !BrokerCompensationMethod.Clean;
        public Value<string> BrokerFeeRefundConditions1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions1() => !BrokerFeeRefundConditions1.Clean;
        public Value<string> BrokerFeeRefundConditions2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions2() => !BrokerFeeRefundConditions2.Clean;
        public Value<string> BrokerFeeRefundConditions3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerFeeRefundConditions3() => !BrokerFeeRefundConditions3.Clean;
        public Value<string> BrokerForPlacingLoan { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerForPlacingLoan() => !BrokerForPlacingLoan.Clean;
        public Value<string> BrokerInterestRateEffect { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerInterestRateEffect() => !BrokerInterestRateEffect.Clean;
        public Value<string> BrokerLenderRelationship { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLenderRelationship() => !BrokerLenderRelationship.Clean;
        public Value<string> BrokerLicenseNumberIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicenseNumberIdentifier() => !BrokerLicenseNumberIdentifier.Clean;
        public Value<string> BrokerNameAsLicensed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerNameAsLicensed() => !BrokerNameAsLicensed.Clean;
        public Value<string> BrokerTaxIdentificationNumberIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerTaxIdentificationNumberIdentifier() => !BrokerTaxIdentificationNumberIdentifier.Clean;
        public Value<string> BrokerWithLenders { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerWithLenders() => !BrokerWithLenders.Clean;
        public Value<decimal?> CashCheckFromBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashCheckFromBorrower() => !CashCheckFromBorrower.Clean;
        public Value<string> ClosingDocsLoanProgramType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDocsLoanProgramType() => !ClosingDocsLoanProgramType.Clean;
        public Value<List<ClosingEntity>> ClosingEntities { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingEntities() => !ClosingEntities.Clean;
        public Value<string> ClosingProvider { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingProvider() => !ClosingProvider.Clean;
        public Value<string> ClosingState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingState() => !ClosingState.Clean;
        public Value<string> ComplianceJurisdictionCounty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComplianceJurisdictionCounty() => !ComplianceJurisdictionCounty.Clean;
        public Value<DateTime?> CompliancePropertyIdentifiedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompliancePropertyIdentifiedDate() => !CompliancePropertyIdentifiedDate.Clean;
        public Value<string> ConditionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConditionDescription() => !ConditionDescription.Clean;
        public Value<bool?> ConflictofInterestCheck1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck1() => !ConflictofInterestCheck1.Clean;
        public Value<bool?> ConflictofInterestCheck2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck2() => !ConflictofInterestCheck2.Clean;
        public Value<bool?> ConflictofInterestCheck3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck3() => !ConflictofInterestCheck3.Clean;
        public Value<bool?> ConflictofInterestCheck4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck4() => !ConflictofInterestCheck4.Clean;
        public Value<bool?> ConflictofInterestCheck5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck5() => !ConflictofInterestCheck5.Clean;
        public Value<bool?> ConflictofInterestCheck6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConflictofInterestCheck6() => !ConflictofInterestCheck6.Clean;
        public Value<string> CoopApartmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopApartmentNumber() => !CoopApartmentNumber.Clean;
        public Value<DateTime?> CoopAssignmentLeaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopAssignmentLeaseDate() => !CoopAssignmentLeaseDate.Clean;
        public Value<string> CoopAttorneyInFact { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopAttorneyInFact() => !CoopAttorneyInFact.Clean;
        public Value<string> CoopBuildingName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopBuildingName() => !CoopBuildingName.Clean;
        public Value<string> CoopCompanyExistsUnderTHeLawsOf { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopCompanyExistsUnderTHeLawsOf() => !CoopCompanyExistsUnderTHeLawsOf.Clean;
        public Value<string> CoopCompanyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopCompanyName() => !CoopCompanyName.Clean;
        public Value<DateTime?> CoopProprietaryLeaseDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopProprietaryLeaseDate() => !CoopProprietaryLeaseDate.Clean;
        public Value<decimal?> CoopSharesOwned { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopSharesOwned() => !CoopSharesOwned.Clean;
        public Value<string> CoopStockCertificationNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopStockCertificationNumber() => !CoopStockCertificationNumber.Clean;
        public Value<decimal?> CoopVacancyPercentNotification { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoopVacancyPercentNotification() => !CoopVacancyPercentNotification.Clean;
        public Value<string> CustomOtherRiderDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCustomOtherRiderDescription() => !CustomOtherRiderDescription.Clean;
        public Value<DateTime?> DisbursementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementDate() => !DisbursementDate.Clean;
        public Value<decimal?> DisbursementsToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisbursementsToBorrower() => !DisbursementsToBorrower.Clean;
        public Value<string> DisclosureAlternateLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureAlternateLender() => !DisclosureAlternateLender.Clean;
        public Value<string> DisclosureCompanyFunction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosureCompanyFunction() => !DisclosureCompanyFunction.Clean;
        public Value<string> DisclosurePlanCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisclosurePlanCode() => !DisclosurePlanCode.Clean;
        public Value<string> DocReportGUID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocReportGUID() => !DocReportGUID.Clean;
        public Value<DateTime?> DocumentPreparationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentPreparationDate() => !DocumentPreparationDate.Clean;
        public Value<DateTime?> DocumentSigningDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDocumentSigningDate() => !DocumentSigningDate.Clean;
        public Value<string> DrawCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawCity() => !DrawCity.Clean;
        public Value<string> DrawCounty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawCounty() => !DrawCounty.Clean;
        public Value<string> DrawState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDrawState() => !DrawState.Clean;
        public Value<string> EmployeeofMortgageLender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmployeeofMortgageLender() => !EmployeeofMortgageLender.Clean;
        public Value<string> ExpectToAssignSellOrTransferPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExpectToAssignSellOrTransferPercent() => !ExpectToAssignSellOrTransferPercent.Clean;
        public Value<string> FinalVestingDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalVestingDescription() => !FinalVestingDescription.Clean;
        public Value<string> FirstTransferYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTransferYear() => !FirstTransferYear.Clean;
        public Value<decimal?> FirstTransferYearValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTransferYearValue() => !FirstTransferYearValue.Clean;
        public Value<string> HoursDocumentsNeededPriorToDisbursementCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoursDocumentsNeededPriorToDisbursementCount() => !HoursDocumentsNeededPriorToDisbursementCount.Clean;
        public Value<bool?> HousingIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingIndicator() => !HousingIndicator.Clean;
        public Value<string> HousingProgramName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHousingProgramName() => !HousingProgramName.Clean;
        public Value<string> HUD1FileNumberIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1FileNumberIdentifier() => !HUD1FileNumberIdentifier.Clean;
        public Value<string> HUD1SettlementAgentUnparsedAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementAgentUnparsedAddress() => !HUD1SettlementAgentUnparsedAddress.Clean;
        public Value<string> HUD1SettlementAgentUnparsedName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementAgentUnparsedName() => !HUD1SettlementAgentUnparsedName.Clean;
        public Value<DateTime?> HUD1SettlementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHUD1SettlementDate() => !HUD1SettlementDate.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> IncludeSafeHaborDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncludeSafeHaborDisclosure() => !IncludeSafeHaborDisclosure.Clean;
        public Value<string> InvestorCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorCode() => !InvestorCode.Clean;
        public Value<string> LastAuditDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastAuditDate() => !LastAuditDate.Clean;
        public Value<string> LastDocumentOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDocumentOrdered() => !LastDocumentOrdered.Clean;
        public Value<bool?> LegalAttached { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalAttached() => !LegalAttached.Clean;
        public Value<string> LenderAuthorizedRepresentativeTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAuthorizedRepresentativeTitle() => !LenderAuthorizedRepresentativeTitle.Clean;
        public Value<string> LenderBrokerRepresents { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderBrokerRepresents() => !LenderBrokerRepresents.Clean;
        public Value<string> LienHolderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddress() => !LienHolderAddress.Clean;
        public Value<string> LienHolderAddressCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressCity() => !LienHolderAddressCity.Clean;
        public Value<string> LienHolderAddressPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressPostalCode() => !LienHolderAddressPostalCode.Clean;
        public Value<string> LienHolderAddressState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderAddressState() => !LienHolderAddressState.Clean;
        public Value<string> LienHolderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienHolderName() => !LienHolderName.Clean;
        public Value<bool?> LoanIsLocked { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanIsLocked() => !LoanIsLocked.Clean;
        public Value<string> LoanOption { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanOption() => !LoanOption.Clean;
        public Value<string> LockInFeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockInFeeType() => !LockInFeeType.Clean;
        public Value<string> MfgHomeAnchored { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeAnchored() => !MfgHomeAnchored.Clean;
        public Value<string> MfgHomeCertificateOfTitleIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeCertificateOfTitleIdentifier() => !MfgHomeCertificateOfTitleIdentifier.Clean;
        public Value<string> MfgHomeCertificateOfTitleType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeCertificateOfTitleType() => !MfgHomeCertificateOfTitleType.Clean;
        public Value<string> MfgHomeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeDescription() => !MfgHomeDescription.Clean;
        public Value<string> MfgHomeHUDCertificationLabelIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeHUDCertificationLabelIdentifier() => !MfgHomeHUDCertificationLabelIdentifier.Clean;
        public Value<int?> MfgHomeLengthFeetCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeLengthFeetCount() => !MfgHomeLengthFeetCount.Clean;
        public Value<string> MfgHomeMakeIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeMakeIdentifier() => !MfgHomeMakeIdentifier.Clean;
        public Value<string> MfgHomeManufacturer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturer() => !MfgHomeManufacturer.Clean;
        public Value<string> MfgHomeManufacturerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerAddress() => !MfgHomeManufacturerAddress.Clean;
        public Value<string> MfgHomeManufacturerCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerCity() => !MfgHomeManufacturerCity.Clean;
        public Value<string> MfgHomeManufacturerPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerPhoneNumber() => !MfgHomeManufacturerPhoneNumber.Clean;
        public Value<string> MfgHomeManufacturerPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerPostalCode() => !MfgHomeManufacturerPostalCode.Clean;
        public Value<string> MfgHomeManufacturerState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufacturerState() => !MfgHomeManufacturerState.Clean;
        public Value<int?> MfgHomeManufactureYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeManufactureYear() => !MfgHomeManufactureYear.Clean;
        public Value<string> MfgHomeModelIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeModelIdentifier() => !MfgHomeModelIdentifier.Clean;
        public Value<string> MfgHomeNewOrUsed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeNewOrUsed() => !MfgHomeNewOrUsed.Clean;
        public Value<string> MfgHomeSerialNumberIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeSerialNumberIdentifier() => !MfgHomeSerialNumberIdentifier.Clean;
        public Value<int?> MfgHomeWidthFeetCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMfgHomeWidthFeetCount() => !MfgHomeWidthFeetCount.Clean;
        public Value<string> MineralRightsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMineralRightsDescription() => !MineralRightsDescription.Clean;
        public Value<string> MortgageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageType() => !MortgageType.Clean;
        public Value<int?> NumberBrokerAgreements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberBrokerAgreements() => !NumberBrokerAgreements.Clean;
        public Value<int?> NumberSuccessfulBrokerAgreements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberSuccessfulBrokerAgreements() => !NumberSuccessfulBrokerAgreements.Clean;
        public Value<string> OfficeOfRecordationName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOfficeOfRecordationName() => !OfficeOfRecordationName.Clean;
        public Value<bool?> OnlyOneEntity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOnlyOneEntity() => !OnlyOneEntity.Clean;
        public Value<string> OptionSelectedReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptionSelectedReason() => !OptionSelectedReason.Clean;
        public Value<decimal?> OriginalPincipalAmountSecured { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalPincipalAmountSecured() => !OriginalPincipalAmountSecured.Clean;
        public Value<string> OtherOptionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherOptionDescription() => !OtherOptionDescription.Clean;
        public Value<string> ParentAffiliatedCoName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentAffiliatedCoName() => !ParentAffiliatedCoName.Clean;
        public Value<string> PayToTheOrderOfDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePayToTheOrderOfDescription() => !PayToTheOrderOfDescription.Clean;
        public Value<string> PerDiemCalculationMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePerDiemCalculationMethodType() => !PerDiemCalculationMethodType.Clean;
        public Value<string> PlanCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCode() => !PlanCode.Clean;
        public Value<string> PlanCodeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCodeDescription() => !PlanCodeDescription.Clean;
        public Value<string> PlanCodeId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlanCodeId() => !PlanCodeId.Clean;
        public Value<DateTime?> PreliminaryTitleReportDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreliminaryTitleReportDate() => !PreliminaryTitleReportDate.Clean;
        public Value<string> PrepaymentPenaltyDescriptions1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions1() => !PrepaymentPenaltyDescriptions1.Clean;
        public Value<string> PrepaymentPenaltyDescriptions2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions2() => !PrepaymentPenaltyDescriptions2.Clean;
        public Value<string> PrepaymentPenaltyDescriptions3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyDescriptions3() => !PrepaymentPenaltyDescriptions3.Clean;
        public Value<int?> ProcessingNumberDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProcessingNumberDays() => !ProcessingNumberDays.Clean;
        public Value<string> ProgramCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramCode() => !ProgramCode.Clean;
        public Value<string> ProgramSponsor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramSponsor() => !ProgramSponsor.Clean;
        public Value<bool?> PropertyIsLandTrust { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyIsLandTrust() => !PropertyIsLandTrust.Clean;
        public Value<string> PropertyTaxMessageDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyTaxMessageDescription() => !PropertyTaxMessageDescription.Clean;
        public Value<string> RateLockRefundConditions1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions1() => !RateLockRefundConditions1.Clean;
        public Value<string> RateLockRefundConditions2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions2() => !RateLockRefundConditions2.Clean;
        public Value<string> RateLockRefundConditions3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockRefundConditions3() => !RateLockRefundConditions3.Clean;
        public Value<string> RecordingJurisdictionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRecordingJurisdictionName() => !RecordingJurisdictionName.Clean;
        public Value<bool?> RefinanceBalloonMortgageGuarantee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceBalloonMortgageGuarantee() => !RefinanceBalloonMortgageGuarantee.Clean;
        public Value<bool?> RefinanceRightOfRescissionExemptFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRefinanceRightOfRescissionExemptFlag() => !RefinanceRightOfRescissionExemptFlag.Clean;
        public Value<string> RenewalExtensionDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRenewalExtensionDescription() => !RenewalExtensionDescription.Clean;
        public Value<DateTime?> RescissionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRescissionDate() => !RescissionDate.Clean;
        public Value<List<RespaHudDetail>> RespaHudDetails { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRespaHudDetails() => !RespaHudDetails.Clean;
        public Value<string> RMLANamePreceding10Years { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRMLANamePreceding10Years() => !RMLANamePreceding10Years.Clean;
        public Value<string> RmlLenderBrokerRepresents { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRmlLenderBrokerRepresents() => !RmlLenderBrokerRepresents.Clean;
        public Value<string> SecondTransferYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondTransferYear() => !SecondTransferYear.Clean;
        public Value<decimal?> SecondTransferYearValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecondTransferYearValue() => !SecondTransferYearValue.Clean;
        public Value<DateTime?> SignatureDateFor1003 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSignatureDateFor1003() => !SignatureDateFor1003.Clean;
        public Value<string> SpecialFloodHazardAreaIndictor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFloodHazardAreaIndictor() => !SpecialFloodHazardAreaIndictor.Clean;
        public Value<List<StateLicense>> StateLicenses { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateLicenses() => !StateLicenses.Clean;
        public Value<string> SuretyCompanyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuretyCompanyName() => !SuretyCompanyName.Clean;
        public Value<bool?> SyncInterestDateDisbursementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSyncInterestDateDisbursementDate() => !SyncInterestDateDisbursementDate.Clean;
        public Value<string> TermiteReportRequiredIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTermiteReportRequiredIndicator() => !TermiteReportRequiredIndicator.Clean;
        public Value<string> TextDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTextDescription() => !TextDescription.Clean;
        public Value<string> ThirdTransferYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdTransferYear() => !ThirdTransferYear.Clean;
        public Value<decimal?> ThirdTransferYearValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdTransferYearValue() => !ThirdTransferYearValue.Clean;
        public Value<string> TitleReportItemsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleReportItemsDescription() => !TitleReportItemsDescription.Clean;
        public Value<string> TitleReportRequiredEndorsementsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleReportRequiredEndorsementsDescription() => !TitleReportRequiredEndorsementsDescription.Clean;
        public Value<decimal?> TotalDisbursed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDisbursed() => !TotalDisbursed.Clean;
        public Value<string> Trust2Beneficiaries { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTrust2Beneficiaries() => !Trust2Beneficiaries.Clean;
        public Value<string> WeConductBusiness { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWeConductBusiness() => !WeConductBusiness.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalLienHolderAddress.Clean
                    && AdditionalLienHolderAddressCity.Clean
                    && AdditionalLienHolderAddressPostalCode.Clean
                    && AdditionalLienHolderAddressState.Clean
                    && AdditionalLienHolderName.Clean
                    && AdditionalOriginalPincipalAmountSecured.Clean
                    && AdditionalSigVerbiageType.Clean
                    && AdditionalStateDisclosures.Clean
                    && AffectedByInterest.Clean
                    && AlternateLender.Clean
                    && AltLenderId.Clean
                    && AntiSteeringLoanOptions.Clean
                    && AreAbleToServiceIndicator.Clean
                    && AssociatedDocumentNumber.Clean
                    && Beneficiaries.Clean
                    && BorrowerConsentType1.Clean
                    && BorrowerConsentType2.Clean
                    && BorrowerOrganizationType1.Clean
                    && BorrowerOrganizationType2.Clean
                    && BorrowerOrganizedUnderTheLawsOfJurisdictionName1.Clean
                    && BorrowerOrganizedUnderTheLawsOfJurisdictionName2.Clean
                    && BorrowerTaxIdentificationNumberIdentifier1.Clean
                    && BorrowerTaxIdentificationNumberIdentifier2.Clean
                    && BorrowerTrustAmendedDateOrYear1.Clean
                    && BorrowerTrustAmendedDateOrYear2.Clean
                    && BorrowerTrustDateOrYear1.Clean
                    && BorrowerTrustDateOrYear2.Clean
                    && BorrowerUnparsedName1.Clean
                    && BorrowerUnparsedName2.Clean
                    && BrokerAuthorizedRepresentativeTitle.Clean
                    && BrokerCompensationMethod.Clean
                    && BrokerFeeRefundConditions1.Clean
                    && BrokerFeeRefundConditions2.Clean
                    && BrokerFeeRefundConditions3.Clean
                    && BrokerForPlacingLoan.Clean
                    && BrokerInterestRateEffect.Clean
                    && BrokerLenderRelationship.Clean
                    && BrokerLicenseNumberIdentifier.Clean
                    && BrokerNameAsLicensed.Clean
                    && BrokerTaxIdentificationNumberIdentifier.Clean
                    && BrokerWithLenders.Clean
                    && CashCheckFromBorrower.Clean
                    && ClosingDocsLoanProgramType.Clean
                    && ClosingEntities.Clean
                    && ClosingProvider.Clean
                    && ClosingState.Clean
                    && ComplianceJurisdictionCounty.Clean
                    && CompliancePropertyIdentifiedDate.Clean
                    && ConditionDescription.Clean
                    && ConflictofInterestCheck1.Clean
                    && ConflictofInterestCheck2.Clean
                    && ConflictofInterestCheck3.Clean
                    && ConflictofInterestCheck4.Clean
                    && ConflictofInterestCheck5.Clean
                    && ConflictofInterestCheck6.Clean
                    && CoopApartmentNumber.Clean
                    && CoopAssignmentLeaseDate.Clean
                    && CoopAttorneyInFact.Clean
                    && CoopBuildingName.Clean
                    && CoopCompanyExistsUnderTHeLawsOf.Clean
                    && CoopCompanyName.Clean
                    && CoopProprietaryLeaseDate.Clean
                    && CoopSharesOwned.Clean
                    && CoopStockCertificationNumber.Clean
                    && CoopVacancyPercentNotification.Clean
                    && CustomOtherRiderDescription.Clean
                    && DisbursementDate.Clean
                    && DisbursementsToBorrower.Clean
                    && DisclosureAlternateLender.Clean
                    && DisclosureCompanyFunction.Clean
                    && DisclosurePlanCode.Clean
                    && DocReportGUID.Clean
                    && DocumentPreparationDate.Clean
                    && DocumentSigningDate.Clean
                    && DrawCity.Clean
                    && DrawCounty.Clean
                    && DrawState.Clean
                    && EmployeeofMortgageLender.Clean
                    && ExpectToAssignSellOrTransferPercent.Clean
                    && FinalVestingDescription.Clean
                    && FirstTransferYear.Clean
                    && FirstTransferYearValue.Clean
                    && HoursDocumentsNeededPriorToDisbursementCount.Clean
                    && HousingIndicator.Clean
                    && HousingProgramName.Clean
                    && HUD1FileNumberIdentifier.Clean
                    && HUD1SettlementAgentUnparsedAddress.Clean
                    && HUD1SettlementAgentUnparsedName.Clean
                    && HUD1SettlementDate.Clean
                    && Id.Clean
                    && IncludeSafeHaborDisclosure.Clean
                    && InvestorCode.Clean
                    && LastAuditDate.Clean
                    && LastDocumentOrdered.Clean
                    && LegalAttached.Clean
                    && LenderAuthorizedRepresentativeTitle.Clean
                    && LenderBrokerRepresents.Clean
                    && LienHolderAddress.Clean
                    && LienHolderAddressCity.Clean
                    && LienHolderAddressPostalCode.Clean
                    && LienHolderAddressState.Clean
                    && LienHolderName.Clean
                    && LoanIsLocked.Clean
                    && LoanOption.Clean
                    && LockInFeeType.Clean
                    && MfgHomeAnchored.Clean
                    && MfgHomeCertificateOfTitleIdentifier.Clean
                    && MfgHomeCertificateOfTitleType.Clean
                    && MfgHomeDescription.Clean
                    && MfgHomeHUDCertificationLabelIdentifier.Clean
                    && MfgHomeLengthFeetCount.Clean
                    && MfgHomeMakeIdentifier.Clean
                    && MfgHomeManufacturer.Clean
                    && MfgHomeManufacturerAddress.Clean
                    && MfgHomeManufacturerCity.Clean
                    && MfgHomeManufacturerPhoneNumber.Clean
                    && MfgHomeManufacturerPostalCode.Clean
                    && MfgHomeManufacturerState.Clean
                    && MfgHomeManufactureYear.Clean
                    && MfgHomeModelIdentifier.Clean
                    && MfgHomeNewOrUsed.Clean
                    && MfgHomeSerialNumberIdentifier.Clean
                    && MfgHomeWidthFeetCount.Clean
                    && MineralRightsDescription.Clean
                    && MortgageType.Clean
                    && NumberBrokerAgreements.Clean
                    && NumberSuccessfulBrokerAgreements.Clean
                    && OfficeOfRecordationName.Clean
                    && OnlyOneEntity.Clean
                    && OptionSelectedReason.Clean
                    && OriginalPincipalAmountSecured.Clean
                    && OtherOptionDescription.Clean
                    && ParentAffiliatedCoName.Clean
                    && PayToTheOrderOfDescription.Clean
                    && PerDiemCalculationMethodType.Clean
                    && PlanCode.Clean
                    && PlanCodeDescription.Clean
                    && PlanCodeId.Clean
                    && PreliminaryTitleReportDate.Clean
                    && PrepaymentPenaltyDescriptions1.Clean
                    && PrepaymentPenaltyDescriptions2.Clean
                    && PrepaymentPenaltyDescriptions3.Clean
                    && ProcessingNumberDays.Clean
                    && ProgramCode.Clean
                    && ProgramSponsor.Clean
                    && PropertyIsLandTrust.Clean
                    && PropertyTaxMessageDescription.Clean
                    && RateLockRefundConditions1.Clean
                    && RateLockRefundConditions2.Clean
                    && RateLockRefundConditions3.Clean
                    && RecordingJurisdictionName.Clean
                    && RefinanceBalloonMortgageGuarantee.Clean
                    && RefinanceRightOfRescissionExemptFlag.Clean
                    && RenewalExtensionDescription.Clean
                    && RescissionDate.Clean
                    && RespaHudDetails.Clean
                    && RMLANamePreceding10Years.Clean
                    && RmlLenderBrokerRepresents.Clean
                    && SecondTransferYear.Clean
                    && SecondTransferYearValue.Clean
                    && SignatureDateFor1003.Clean
                    && SpecialFloodHazardAreaIndictor.Clean
                    && StateLicenses.Clean
                    && SuretyCompanyName.Clean
                    && SyncInterestDateDisbursementDate.Clean
                    && TermiteReportRequiredIndicator.Clean
                    && TextDescription.Clean
                    && ThirdTransferYear.Clean
                    && ThirdTransferYearValue.Clean
                    && TitleReportItemsDescription.Clean
                    && TitleReportRequiredEndorsementsDescription.Clean
                    && TotalDisbursed.Clean
                    && Trust2Beneficiaries.Clean
                    && WeConductBusiness.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalLienHolderAddress; v0.Clean = value; AdditionalLienHolderAddress = v0;
                var v1 = AdditionalLienHolderAddressCity; v1.Clean = value; AdditionalLienHolderAddressCity = v1;
                var v2 = AdditionalLienHolderAddressPostalCode; v2.Clean = value; AdditionalLienHolderAddressPostalCode = v2;
                var v3 = AdditionalLienHolderAddressState; v3.Clean = value; AdditionalLienHolderAddressState = v3;
                var v4 = AdditionalLienHolderName; v4.Clean = value; AdditionalLienHolderName = v4;
                var v5 = AdditionalOriginalPincipalAmountSecured; v5.Clean = value; AdditionalOriginalPincipalAmountSecured = v5;
                var v6 = AdditionalSigVerbiageType; v6.Clean = value; AdditionalSigVerbiageType = v6;
                var v7 = AdditionalStateDisclosures; v7.Clean = value; AdditionalStateDisclosures = v7;
                var v8 = AffectedByInterest; v8.Clean = value; AffectedByInterest = v8;
                var v9 = AlternateLender; v9.Clean = value; AlternateLender = v9;
                var v10 = AltLenderId; v10.Clean = value; AltLenderId = v10;
                var v11 = AntiSteeringLoanOptions; v11.Clean = value; AntiSteeringLoanOptions = v11;
                var v12 = AreAbleToServiceIndicator; v12.Clean = value; AreAbleToServiceIndicator = v12;
                var v13 = AssociatedDocumentNumber; v13.Clean = value; AssociatedDocumentNumber = v13;
                var v14 = Beneficiaries; v14.Clean = value; Beneficiaries = v14;
                var v15 = BorrowerConsentType1; v15.Clean = value; BorrowerConsentType1 = v15;
                var v16 = BorrowerConsentType2; v16.Clean = value; BorrowerConsentType2 = v16;
                var v17 = BorrowerOrganizationType1; v17.Clean = value; BorrowerOrganizationType1 = v17;
                var v18 = BorrowerOrganizationType2; v18.Clean = value; BorrowerOrganizationType2 = v18;
                var v19 = BorrowerOrganizedUnderTheLawsOfJurisdictionName1; v19.Clean = value; BorrowerOrganizedUnderTheLawsOfJurisdictionName1 = v19;
                var v20 = BorrowerOrganizedUnderTheLawsOfJurisdictionName2; v20.Clean = value; BorrowerOrganizedUnderTheLawsOfJurisdictionName2 = v20;
                var v21 = BorrowerTaxIdentificationNumberIdentifier1; v21.Clean = value; BorrowerTaxIdentificationNumberIdentifier1 = v21;
                var v22 = BorrowerTaxIdentificationNumberIdentifier2; v22.Clean = value; BorrowerTaxIdentificationNumberIdentifier2 = v22;
                var v23 = BorrowerTrustAmendedDateOrYear1; v23.Clean = value; BorrowerTrustAmendedDateOrYear1 = v23;
                var v24 = BorrowerTrustAmendedDateOrYear2; v24.Clean = value; BorrowerTrustAmendedDateOrYear2 = v24;
                var v25 = BorrowerTrustDateOrYear1; v25.Clean = value; BorrowerTrustDateOrYear1 = v25;
                var v26 = BorrowerTrustDateOrYear2; v26.Clean = value; BorrowerTrustDateOrYear2 = v26;
                var v27 = BorrowerUnparsedName1; v27.Clean = value; BorrowerUnparsedName1 = v27;
                var v28 = BorrowerUnparsedName2; v28.Clean = value; BorrowerUnparsedName2 = v28;
                var v29 = BrokerAuthorizedRepresentativeTitle; v29.Clean = value; BrokerAuthorizedRepresentativeTitle = v29;
                var v30 = BrokerCompensationMethod; v30.Clean = value; BrokerCompensationMethod = v30;
                var v31 = BrokerFeeRefundConditions1; v31.Clean = value; BrokerFeeRefundConditions1 = v31;
                var v32 = BrokerFeeRefundConditions2; v32.Clean = value; BrokerFeeRefundConditions2 = v32;
                var v33 = BrokerFeeRefundConditions3; v33.Clean = value; BrokerFeeRefundConditions3 = v33;
                var v34 = BrokerForPlacingLoan; v34.Clean = value; BrokerForPlacingLoan = v34;
                var v35 = BrokerInterestRateEffect; v35.Clean = value; BrokerInterestRateEffect = v35;
                var v36 = BrokerLenderRelationship; v36.Clean = value; BrokerLenderRelationship = v36;
                var v37 = BrokerLicenseNumberIdentifier; v37.Clean = value; BrokerLicenseNumberIdentifier = v37;
                var v38 = BrokerNameAsLicensed; v38.Clean = value; BrokerNameAsLicensed = v38;
                var v39 = BrokerTaxIdentificationNumberIdentifier; v39.Clean = value; BrokerTaxIdentificationNumberIdentifier = v39;
                var v40 = BrokerWithLenders; v40.Clean = value; BrokerWithLenders = v40;
                var v41 = CashCheckFromBorrower; v41.Clean = value; CashCheckFromBorrower = v41;
                var v42 = ClosingDocsLoanProgramType; v42.Clean = value; ClosingDocsLoanProgramType = v42;
                var v43 = ClosingEntities; v43.Clean = value; ClosingEntities = v43;
                var v44 = ClosingProvider; v44.Clean = value; ClosingProvider = v44;
                var v45 = ClosingState; v45.Clean = value; ClosingState = v45;
                var v46 = ComplianceJurisdictionCounty; v46.Clean = value; ComplianceJurisdictionCounty = v46;
                var v47 = CompliancePropertyIdentifiedDate; v47.Clean = value; CompliancePropertyIdentifiedDate = v47;
                var v48 = ConditionDescription; v48.Clean = value; ConditionDescription = v48;
                var v49 = ConflictofInterestCheck1; v49.Clean = value; ConflictofInterestCheck1 = v49;
                var v50 = ConflictofInterestCheck2; v50.Clean = value; ConflictofInterestCheck2 = v50;
                var v51 = ConflictofInterestCheck3; v51.Clean = value; ConflictofInterestCheck3 = v51;
                var v52 = ConflictofInterestCheck4; v52.Clean = value; ConflictofInterestCheck4 = v52;
                var v53 = ConflictofInterestCheck5; v53.Clean = value; ConflictofInterestCheck5 = v53;
                var v54 = ConflictofInterestCheck6; v54.Clean = value; ConflictofInterestCheck6 = v54;
                var v55 = CoopApartmentNumber; v55.Clean = value; CoopApartmentNumber = v55;
                var v56 = CoopAssignmentLeaseDate; v56.Clean = value; CoopAssignmentLeaseDate = v56;
                var v57 = CoopAttorneyInFact; v57.Clean = value; CoopAttorneyInFact = v57;
                var v58 = CoopBuildingName; v58.Clean = value; CoopBuildingName = v58;
                var v59 = CoopCompanyExistsUnderTHeLawsOf; v59.Clean = value; CoopCompanyExistsUnderTHeLawsOf = v59;
                var v60 = CoopCompanyName; v60.Clean = value; CoopCompanyName = v60;
                var v61 = CoopProprietaryLeaseDate; v61.Clean = value; CoopProprietaryLeaseDate = v61;
                var v62 = CoopSharesOwned; v62.Clean = value; CoopSharesOwned = v62;
                var v63 = CoopStockCertificationNumber; v63.Clean = value; CoopStockCertificationNumber = v63;
                var v64 = CoopVacancyPercentNotification; v64.Clean = value; CoopVacancyPercentNotification = v64;
                var v65 = CustomOtherRiderDescription; v65.Clean = value; CustomOtherRiderDescription = v65;
                var v66 = DisbursementDate; v66.Clean = value; DisbursementDate = v66;
                var v67 = DisbursementsToBorrower; v67.Clean = value; DisbursementsToBorrower = v67;
                var v68 = DisclosureAlternateLender; v68.Clean = value; DisclosureAlternateLender = v68;
                var v69 = DisclosureCompanyFunction; v69.Clean = value; DisclosureCompanyFunction = v69;
                var v70 = DisclosurePlanCode; v70.Clean = value; DisclosurePlanCode = v70;
                var v71 = DocReportGUID; v71.Clean = value; DocReportGUID = v71;
                var v72 = DocumentPreparationDate; v72.Clean = value; DocumentPreparationDate = v72;
                var v73 = DocumentSigningDate; v73.Clean = value; DocumentSigningDate = v73;
                var v74 = DrawCity; v74.Clean = value; DrawCity = v74;
                var v75 = DrawCounty; v75.Clean = value; DrawCounty = v75;
                var v76 = DrawState; v76.Clean = value; DrawState = v76;
                var v77 = EmployeeofMortgageLender; v77.Clean = value; EmployeeofMortgageLender = v77;
                var v78 = ExpectToAssignSellOrTransferPercent; v78.Clean = value; ExpectToAssignSellOrTransferPercent = v78;
                var v79 = FinalVestingDescription; v79.Clean = value; FinalVestingDescription = v79;
                var v80 = FirstTransferYear; v80.Clean = value; FirstTransferYear = v80;
                var v81 = FirstTransferYearValue; v81.Clean = value; FirstTransferYearValue = v81;
                var v82 = HoursDocumentsNeededPriorToDisbursementCount; v82.Clean = value; HoursDocumentsNeededPriorToDisbursementCount = v82;
                var v83 = HousingIndicator; v83.Clean = value; HousingIndicator = v83;
                var v84 = HousingProgramName; v84.Clean = value; HousingProgramName = v84;
                var v85 = HUD1FileNumberIdentifier; v85.Clean = value; HUD1FileNumberIdentifier = v85;
                var v86 = HUD1SettlementAgentUnparsedAddress; v86.Clean = value; HUD1SettlementAgentUnparsedAddress = v86;
                var v87 = HUD1SettlementAgentUnparsedName; v87.Clean = value; HUD1SettlementAgentUnparsedName = v87;
                var v88 = HUD1SettlementDate; v88.Clean = value; HUD1SettlementDate = v88;
                var v89 = Id; v89.Clean = value; Id = v89;
                var v90 = IncludeSafeHaborDisclosure; v90.Clean = value; IncludeSafeHaborDisclosure = v90;
                var v91 = InvestorCode; v91.Clean = value; InvestorCode = v91;
                var v92 = LastAuditDate; v92.Clean = value; LastAuditDate = v92;
                var v93 = LastDocumentOrdered; v93.Clean = value; LastDocumentOrdered = v93;
                var v94 = LegalAttached; v94.Clean = value; LegalAttached = v94;
                var v95 = LenderAuthorizedRepresentativeTitle; v95.Clean = value; LenderAuthorizedRepresentativeTitle = v95;
                var v96 = LenderBrokerRepresents; v96.Clean = value; LenderBrokerRepresents = v96;
                var v97 = LienHolderAddress; v97.Clean = value; LienHolderAddress = v97;
                var v98 = LienHolderAddressCity; v98.Clean = value; LienHolderAddressCity = v98;
                var v99 = LienHolderAddressPostalCode; v99.Clean = value; LienHolderAddressPostalCode = v99;
                var v100 = LienHolderAddressState; v100.Clean = value; LienHolderAddressState = v100;
                var v101 = LienHolderName; v101.Clean = value; LienHolderName = v101;
                var v102 = LoanIsLocked; v102.Clean = value; LoanIsLocked = v102;
                var v103 = LoanOption; v103.Clean = value; LoanOption = v103;
                var v104 = LockInFeeType; v104.Clean = value; LockInFeeType = v104;
                var v105 = MfgHomeAnchored; v105.Clean = value; MfgHomeAnchored = v105;
                var v106 = MfgHomeCertificateOfTitleIdentifier; v106.Clean = value; MfgHomeCertificateOfTitleIdentifier = v106;
                var v107 = MfgHomeCertificateOfTitleType; v107.Clean = value; MfgHomeCertificateOfTitleType = v107;
                var v108 = MfgHomeDescription; v108.Clean = value; MfgHomeDescription = v108;
                var v109 = MfgHomeHUDCertificationLabelIdentifier; v109.Clean = value; MfgHomeHUDCertificationLabelIdentifier = v109;
                var v110 = MfgHomeLengthFeetCount; v110.Clean = value; MfgHomeLengthFeetCount = v110;
                var v111 = MfgHomeMakeIdentifier; v111.Clean = value; MfgHomeMakeIdentifier = v111;
                var v112 = MfgHomeManufacturer; v112.Clean = value; MfgHomeManufacturer = v112;
                var v113 = MfgHomeManufacturerAddress; v113.Clean = value; MfgHomeManufacturerAddress = v113;
                var v114 = MfgHomeManufacturerCity; v114.Clean = value; MfgHomeManufacturerCity = v114;
                var v115 = MfgHomeManufacturerPhoneNumber; v115.Clean = value; MfgHomeManufacturerPhoneNumber = v115;
                var v116 = MfgHomeManufacturerPostalCode; v116.Clean = value; MfgHomeManufacturerPostalCode = v116;
                var v117 = MfgHomeManufacturerState; v117.Clean = value; MfgHomeManufacturerState = v117;
                var v118 = MfgHomeManufactureYear; v118.Clean = value; MfgHomeManufactureYear = v118;
                var v119 = MfgHomeModelIdentifier; v119.Clean = value; MfgHomeModelIdentifier = v119;
                var v120 = MfgHomeNewOrUsed; v120.Clean = value; MfgHomeNewOrUsed = v120;
                var v121 = MfgHomeSerialNumberIdentifier; v121.Clean = value; MfgHomeSerialNumberIdentifier = v121;
                var v122 = MfgHomeWidthFeetCount; v122.Clean = value; MfgHomeWidthFeetCount = v122;
                var v123 = MineralRightsDescription; v123.Clean = value; MineralRightsDescription = v123;
                var v124 = MortgageType; v124.Clean = value; MortgageType = v124;
                var v125 = NumberBrokerAgreements; v125.Clean = value; NumberBrokerAgreements = v125;
                var v126 = NumberSuccessfulBrokerAgreements; v126.Clean = value; NumberSuccessfulBrokerAgreements = v126;
                var v127 = OfficeOfRecordationName; v127.Clean = value; OfficeOfRecordationName = v127;
                var v128 = OnlyOneEntity; v128.Clean = value; OnlyOneEntity = v128;
                var v129 = OptionSelectedReason; v129.Clean = value; OptionSelectedReason = v129;
                var v130 = OriginalPincipalAmountSecured; v130.Clean = value; OriginalPincipalAmountSecured = v130;
                var v131 = OtherOptionDescription; v131.Clean = value; OtherOptionDescription = v131;
                var v132 = ParentAffiliatedCoName; v132.Clean = value; ParentAffiliatedCoName = v132;
                var v133 = PayToTheOrderOfDescription; v133.Clean = value; PayToTheOrderOfDescription = v133;
                var v134 = PerDiemCalculationMethodType; v134.Clean = value; PerDiemCalculationMethodType = v134;
                var v135 = PlanCode; v135.Clean = value; PlanCode = v135;
                var v136 = PlanCodeDescription; v136.Clean = value; PlanCodeDescription = v136;
                var v137 = PlanCodeId; v137.Clean = value; PlanCodeId = v137;
                var v138 = PreliminaryTitleReportDate; v138.Clean = value; PreliminaryTitleReportDate = v138;
                var v139 = PrepaymentPenaltyDescriptions1; v139.Clean = value; PrepaymentPenaltyDescriptions1 = v139;
                var v140 = PrepaymentPenaltyDescriptions2; v140.Clean = value; PrepaymentPenaltyDescriptions2 = v140;
                var v141 = PrepaymentPenaltyDescriptions3; v141.Clean = value; PrepaymentPenaltyDescriptions3 = v141;
                var v142 = ProcessingNumberDays; v142.Clean = value; ProcessingNumberDays = v142;
                var v143 = ProgramCode; v143.Clean = value; ProgramCode = v143;
                var v144 = ProgramSponsor; v144.Clean = value; ProgramSponsor = v144;
                var v145 = PropertyIsLandTrust; v145.Clean = value; PropertyIsLandTrust = v145;
                var v146 = PropertyTaxMessageDescription; v146.Clean = value; PropertyTaxMessageDescription = v146;
                var v147 = RateLockRefundConditions1; v147.Clean = value; RateLockRefundConditions1 = v147;
                var v148 = RateLockRefundConditions2; v148.Clean = value; RateLockRefundConditions2 = v148;
                var v149 = RateLockRefundConditions3; v149.Clean = value; RateLockRefundConditions3 = v149;
                var v150 = RecordingJurisdictionName; v150.Clean = value; RecordingJurisdictionName = v150;
                var v151 = RefinanceBalloonMortgageGuarantee; v151.Clean = value; RefinanceBalloonMortgageGuarantee = v151;
                var v152 = RefinanceRightOfRescissionExemptFlag; v152.Clean = value; RefinanceRightOfRescissionExemptFlag = v152;
                var v153 = RenewalExtensionDescription; v153.Clean = value; RenewalExtensionDescription = v153;
                var v154 = RescissionDate; v154.Clean = value; RescissionDate = v154;
                var v155 = RespaHudDetails; v155.Clean = value; RespaHudDetails = v155;
                var v156 = RMLANamePreceding10Years; v156.Clean = value; RMLANamePreceding10Years = v156;
                var v157 = RmlLenderBrokerRepresents; v157.Clean = value; RmlLenderBrokerRepresents = v157;
                var v158 = SecondTransferYear; v158.Clean = value; SecondTransferYear = v158;
                var v159 = SecondTransferYearValue; v159.Clean = value; SecondTransferYearValue = v159;
                var v160 = SignatureDateFor1003; v160.Clean = value; SignatureDateFor1003 = v160;
                var v161 = SpecialFloodHazardAreaIndictor; v161.Clean = value; SpecialFloodHazardAreaIndictor = v161;
                var v162 = StateLicenses; v162.Clean = value; StateLicenses = v162;
                var v163 = SuretyCompanyName; v163.Clean = value; SuretyCompanyName = v163;
                var v164 = SyncInterestDateDisbursementDate; v164.Clean = value; SyncInterestDateDisbursementDate = v164;
                var v165 = TermiteReportRequiredIndicator; v165.Clean = value; TermiteReportRequiredIndicator = v165;
                var v166 = TextDescription; v166.Clean = value; TextDescription = v166;
                var v167 = ThirdTransferYear; v167.Clean = value; ThirdTransferYear = v167;
                var v168 = ThirdTransferYearValue; v168.Clean = value; ThirdTransferYearValue = v168;
                var v169 = TitleReportItemsDescription; v169.Clean = value; TitleReportItemsDescription = v169;
                var v170 = TitleReportRequiredEndorsementsDescription; v170.Clean = value; TitleReportRequiredEndorsementsDescription = v170;
                var v171 = TotalDisbursed; v171.Clean = value; TotalDisbursed = v171;
                var v172 = Trust2Beneficiaries; v172.Clean = value; Trust2Beneficiaries = v172;
                var v173 = WeConductBusiness; v173.Clean = value; WeConductBusiness = v173;
                _settingClean = 0;
            }
        }
    }
}