using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Borrower
    {
        public Value<string> AcountChekAssetId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAcountChekAssetId() => !AcountChekAssetId.Clean;
        public Value<int?> AgeAtApplicationYearsCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgeAtApplicationYearsCount() => !AgeAtApplicationYearsCount.Clean;
        public Value<string> AliasName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAliasName() => !AliasName.Clean;
        public Value<bool?> AlimonyChildSupportObligationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlimonyChildSupportObligationIndicator() => !AlimonyChildSupportObligationIndicator.Clean;
        public Value<string> AltId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAltId() => !AltId.Clean;
        public Value<string> ApplicantType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicantType() => !ApplicantType.Clean;
        public Application Application { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplication() => Application?.Clean == false;
        public Value<string> ApplicationTakenMethodType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationTakenMethodType() => !ApplicationTakenMethodType.Clean;
        public Value<bool?> AuthorizedCreditReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAuthorizedCreditReportIndicator() => !AuthorizedCreditReportIndicator.Clean;
        public Value<bool?> AuthorizedToSignIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAuthorizedToSignIndicator() => !AuthorizedToSignIndicator.Clean;
        public Value<string> BankAccountNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankAccountNumber() => !BankAccountNumber.Clean;
        public Value<string> BankAccountType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankAccountType() => !BankAccountType.Clean;
        public Value<string> BankContactAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankContactAddress() => !BankContactAddress.Clean;
        public Value<string> BankContactCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankContactCity() => !BankContactCity.Clean;
        public Value<string> BankContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankContactName() => !BankContactName.Clean;
        public Value<string> BankContactPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankContactPostalCode() => !BankContactPostalCode.Clean;
        public Value<string> BankContactState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankContactState() => !BankContactState.Clean;
        public Value<bool?> BankruptcyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankruptcyIndicator() => !BankruptcyIndicator.Clean;
        public Value<string> BankruptcyStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBankruptcyStatus() => !BankruptcyStatus.Clean;
        public Value<decimal?> BaseMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBaseMonthlyIncomeAmount() => !BaseMonthlyIncomeAmount.Clean;
        public Value<DateTime?> BirthDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBirthDate() => !BirthDate.Clean;
        public Value<bool?> BorrowedDownPaymentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowedDownPaymentIndicator() => !BorrowedDownPaymentIndicator.Clean;
        public Value<DateTime?> BorrowerConsentRequestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerConsentRequestDate() => !BorrowerConsentRequestDate.Clean;
        public Value<int?> BorrowerIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerIndex() => !BorrowerIndex.Clean;
        public Value<string> BorrowerType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerType() => !BorrowerType.Clean;
        public Value<string> BorrowerTypeInSummary { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerTypeInSummary() => !BorrowerTypeInSummary.Clean;
        public Value<string> CaivrsIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCaivrsIdentifier() => !CaivrsIdentifier.Clean;
        public Value<string> CitizenshipResidencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCitizenshipResidencyType() => !CitizenshipResidencyType.Clean;
        public Value<bool?> CoMakerEndorserOfNoteIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCoMakerEndorserOfNoteIndicator() => !CoMakerEndorserOfNoteIndicator.Clean;
        public Value<string> CommentOfCreditReport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommentOfCreditReport() => !CommentOfCreditReport.Clean;
        public Value<bool?> ConfirmedCRDIL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedCRDIL() => !ConfirmedCRDIL.Clean;
        public Value<bool?> ConfirmedCRFCEC { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedCRFCEC() => !ConfirmedCRFCEC.Clean;
        public Value<bool?> ConfirmedCRFCIncorrect { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedCRFCIncorrect() => !ConfirmedCRFCIncorrect.Clean;
        public Value<bool?> ConfirmedCRPFS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedCRPFS() => !ConfirmedCRPFS.Clean;
        public Value<bool?> ConfirmedOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedOther() => !ConfirmedOther.Clean;
        public Value<string> ConfirmedOtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConfirmedOtherDescription() => !ConfirmedOtherDescription.Clean;
        public Value<bool?> CreditCounseling { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditCounseling() => !CreditCounseling.Clean;
        public Value<DateTime?> CreditReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReceivedDate() => !CreditReceivedDate.Clean;
        public Value<string> CreditReportAuthorizationMethod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditReportAuthorizationMethod() => !CreditReportAuthorizationMethod.Clean;
        public Value<bool?> CreditScoreIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScoreIndicator() => !CreditScoreIndicator.Clean;
        public Value<DateTime?> DateAuthorizedCreditReport { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateAuthorizedCreditReport() => !DateAuthorizedCreditReport.Clean;
        public Value<DateTime?> DateOfBankruptcy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfBankruptcy() => !DateOfBankruptcy.Clean;
        public Value<DateTime?> DateOfForeclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateOfForeclosure() => !DateOfForeclosure.Clean;
        public Value<bool?> DeclarationsJIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeclarationsJIndicator() => !DeclarationsJIndicator.Clean;
        public Value<bool?> DeclarationsKIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDeclarationsKIndicator() => !DeclarationsKIndicator.Clean;
        public Value<int?> DependentCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDependentCount() => !DependentCount.Clean;
        public Value<string> DependentsAgesDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDependentsAgesDescription() => !DependentsAgesDescription.Clean;
        public Value<bool?> DisabledIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDisabledIndicator() => !DisabledIndicator.Clean;
        public Value<string> EmailAddressText { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEmailAddressText() => !EmailAddressText.Clean;
        public Value<int?> Equifax120Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifax120Days() => !Equifax120Days.Clean;
        public Value<int?> Equifax150Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifax150Days() => !Equifax150Days.Clean;
        public Value<int?> Equifax30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifax30Days() => !Equifax30Days.Clean;
        public Value<int?> Equifax60Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifax60Days() => !Equifax60Days.Clean;
        public Value<int?> Equifax90Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifax90Days() => !Equifax90Days.Clean;
        public Value<bool?> EquifaxCreditScoreForDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxCreditScoreForDisclosure() => !EquifaxCreditScoreForDisclosure.Clean;
        public Value<int?> EquifaxCreditScoreRanksPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxCreditScoreRanksPercent() => !EquifaxCreditScoreRanksPercent.Clean;
        public Value<DateTime?> EquifaxDatePulled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxDatePulled() => !EquifaxDatePulled.Clean;
        public Value<string> EquifaxFactorCode1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFactorCode1() => !EquifaxFactorCode1.Clean;
        public Value<string> EquifaxFactorCode2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFactorCode2() => !EquifaxFactorCode2.Clean;
        public Value<string> EquifaxFactorCode3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFactorCode3() => !EquifaxFactorCode3.Clean;
        public Value<string> EquifaxFactorCode4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFactorCode4() => !EquifaxFactorCode4.Clean;
        public Value<string> EquifaxFactorCode5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxFactorCode5() => !EquifaxFactorCode5.Clean;
        public Value<string> EquifaxKeyFactor1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxKeyFactor1() => !EquifaxKeyFactor1.Clean;
        public Value<string> EquifaxKeyFactor2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxKeyFactor2() => !EquifaxKeyFactor2.Clean;
        public Value<string> EquifaxKeyFactor3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxKeyFactor3() => !EquifaxKeyFactor3.Clean;
        public Value<string> EquifaxKeyFactor4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxKeyFactor4() => !EquifaxKeyFactor4.Clean;
        public Value<string> EquifaxKeyFactor5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxKeyFactor5() => !EquifaxKeyFactor5.Clean;
        public Value<bool?> EquifaxMaterialTermsCreditByScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxMaterialTermsCreditByScore() => !EquifaxMaterialTermsCreditByScore.Clean;
        public Value<string> EquifaxScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEquifaxScore() => !EquifaxScore.Clean;
        public Value<int?> Experian120Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperian120Days() => !Experian120Days.Clean;
        public Value<int?> Experian150Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperian150Days() => !Experian150Days.Clean;
        public Value<int?> Experian30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperian30Days() => !Experian30Days.Clean;
        public Value<int?> Experian60Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperian60Days() => !Experian60Days.Clean;
        public Value<int?> Experian90Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperian90Days() => !Experian90Days.Clean;
        public Value<string> ExperianCreditScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianCreditScore() => !ExperianCreditScore.Clean;
        public Value<bool?> ExperianCreditScoreForDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianCreditScoreForDisclosure() => !ExperianCreditScoreForDisclosure.Clean;
        public Value<int?> ExperianCreditScoreRanksPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianCreditScoreRanksPercent() => !ExperianCreditScoreRanksPercent.Clean;
        public Value<DateTime?> ExperianDatePulled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianDatePulled() => !ExperianDatePulled.Clean;
        public Value<string> ExperianFactorCode1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFactorCode1() => !ExperianFactorCode1.Clean;
        public Value<string> ExperianFactorCode2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFactorCode2() => !ExperianFactorCode2.Clean;
        public Value<string> ExperianFactorCode3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFactorCode3() => !ExperianFactorCode3.Clean;
        public Value<string> ExperianFactorCode4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFactorCode4() => !ExperianFactorCode4.Clean;
        public Value<string> ExperianFactorCode5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianFactorCode5() => !ExperianFactorCode5.Clean;
        public Value<string> ExperianKeyFactor1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianKeyFactor1() => !ExperianKeyFactor1.Clean;
        public Value<string> ExperianKeyFactor2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianKeyFactor2() => !ExperianKeyFactor2.Clean;
        public Value<string> ExperianKeyFactor3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianKeyFactor3() => !ExperianKeyFactor3.Clean;
        public Value<string> ExperianKeyFactor4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianKeyFactor4() => !ExperianKeyFactor4.Clean;
        public Value<string> ExperianKeyFactor5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianKeyFactor5() => !ExperianKeyFactor5.Clean;
        public Value<bool?> ExperianMaterialTermsCreditByScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExperianMaterialTermsCreditByScore() => !ExperianMaterialTermsCreditByScore.Clean;
        public Value<string> FirstName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstName() => !FirstName.Clean;
        public Value<string> FirstNameWithMiddleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstNameWithMiddleName() => !FirstNameWithMiddleName.Clean;
        public Value<bool?> FirstTimeHomeBuyer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstTimeHomeBuyer() => !FirstTimeHomeBuyer.Clean;
        public Value<DateTime?> ForeclosureSatisfied { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForeclosureSatisfied() => !ForeclosureSatisfied.Clean;
        public Value<string> ForeclosureStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeForeclosureStatus() => !ForeclosureStatus.Clean;
        public Value<string> FreddieMacPerson1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacPerson1() => !FreddieMacPerson1.Clean;
        public Value<string> FreddieMacPerson2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFreddieMacPerson2() => !FreddieMacPerson2.Clean;
        public Value<string> FullName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullName() => !FullName.Clean;
        public Value<string> FullNameWithSuffix { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFullNameWithSuffix() => !FullNameWithSuffix.Clean;
        public Value<decimal?> HighestCreditLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighestCreditLimit() => !HighestCreditLimit.Clean;
        public Value<string> Hmda2003OtherRaceNationalOriginDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmda2003OtherRaceNationalOriginDescription() => !Hmda2003OtherRaceNationalOriginDescription.Clean;
        public Value<string> Hmda2003RaceNationalOriginType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmda2003RaceNationalOriginType() => !Hmda2003RaceNationalOriginType.Clean;
        public Value<bool?> HmdaAfricanAmericanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAfricanAmericanIndicator() => !HmdaAfricanAmericanIndicator.Clean;
        public Value<string> HmdaAge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAge() => !HmdaAge.Clean;
        public Value<bool?> HmdaAmericanIndianIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAmericanIndianIndicator() => !HmdaAmericanIndianIndicator.Clean;
        public Value<string> HmdaAmericanIndianTribe { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAmericanIndianTribe() => !HmdaAmericanIndianTribe.Clean;
        public Value<bool?> HmdaAsianIndianIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAsianIndianIndicator() => !HmdaAsianIndianIndicator.Clean;
        public Value<bool?> HmdaAsianIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAsianIndicator() => !HmdaAsianIndicator.Clean;
        public Value<bool?> HmdaAsianOtherRaceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaAsianOtherRaceIndicator() => !HmdaAsianOtherRaceIndicator.Clean;
        public Value<bool?> HmdaChineseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaChineseIndicator() => !HmdaChineseIndicator.Clean;
        public Value<string> HmdaCreditScoreForDecisionMaking { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaCreditScoreForDecisionMaking() => !HmdaCreditScoreForDecisionMaking.Clean;
        public Value<string> HmdaCreditScoringModel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaCreditScoringModel() => !HmdaCreditScoringModel.Clean;
        public Value<bool?> HmdaCubanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaCubanIndicator() => !HmdaCubanIndicator.Clean;
        public Value<string> HmdaEthnicityType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaEthnicityType() => !HmdaEthnicityType.Clean;
        public Value<bool?> HmdaFilipinoIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaFilipinoIndicator() => !HmdaFilipinoIndicator.Clean;
        public Value<string> HmdaGenderType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaGenderType() => !HmdaGenderType.Clean;
        public Value<bool?> HmdaGuamanianOrChamorroIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaGuamanianOrChamorroIndicator() => !HmdaGuamanianOrChamorroIndicator.Clean;
        public Value<bool?> HmdaHispanicLatinoOtherOriginIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaHispanicLatinoOtherOriginIndicator() => !HmdaHispanicLatinoOtherOriginIndicator.Clean;
        public Value<bool?> HmdaJapaneseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaJapaneseIndicator() => !HmdaJapaneseIndicator.Clean;
        public Value<bool?> HmdaKoreanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaKoreanIndicator() => !HmdaKoreanIndicator.Clean;
        public Value<bool?> HmdaMexicanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaMexicanIndicator() => !HmdaMexicanIndicator.Clean;
        public Value<bool?> HmdaNativeHawaiianIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaNativeHawaiianIndicator() => !HmdaNativeHawaiianIndicator.Clean;
        public Value<bool?> HmdaNoCoApplicantIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaNoCoApplicantIndicator() => !HmdaNoCoApplicantIndicator.Clean;
        public Value<bool?> HmdaNotApplicableIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaNotApplicableIndicator() => !HmdaNotApplicableIndicator.Clean;
        public Value<bool?> HmdaNotProvidedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaNotProvidedIndicator() => !HmdaNotProvidedIndicator.Clean;
        public Value<string> HmdaOtherAsianRace { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaOtherAsianRace() => !HmdaOtherAsianRace.Clean;
        public Value<string> HmdaOtherHispanicLatinoOrigin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaOtherHispanicLatinoOrigin() => !HmdaOtherHispanicLatinoOrigin.Clean;
        public Value<string> HmdaOtherPacificIslanderRace { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaOtherPacificIslanderRace() => !HmdaOtherPacificIslanderRace.Clean;
        public Value<string> HmdaOtherScoringModel { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaOtherScoringModel() => !HmdaOtherScoringModel.Clean;
        public Value<bool?> HmdaPacificIslanderIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaPacificIslanderIndicator() => !HmdaPacificIslanderIndicator.Clean;
        public Value<bool?> HmdaPacificIslanderOtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaPacificIslanderOtherIndicator() => !HmdaPacificIslanderOtherIndicator.Clean;
        public Value<bool?> HmdaPuertoRicanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaPuertoRicanIndicator() => !HmdaPuertoRicanIndicator.Clean;
        public Value<bool?> HmdaRefusalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaRefusalIndicator() => !HmdaRefusalIndicator.Clean;
        public Value<bool?> HmdaSamoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaSamoanIndicator() => !HmdaSamoanIndicator.Clean;
        public Value<bool?> HmdaVietnameseIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaVietnameseIndicator() => !HmdaVietnameseIndicator.Clean;
        public Value<bool?> HmdaWhiteIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaWhiteIndicator() => !HmdaWhiteIndicator.Clean;
        public Value<bool?> HomeownerPastThreeYearsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeownerPastThreeYearsIndicator() => !HomeownerPastThreeYearsIndicator.Clean;
        public Value<string> HomePhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomePhoneNumber() => !HomePhoneNumber.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IntentToOccupyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntentToOccupyIndicator() => !IntentToOccupyIndicator.Clean;
        public Value<string> IntuitReportId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntuitReportId() => !IntuitReportId.Clean;
        public Value<bool?> IsBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsBorrower() => !IsBorrower.Clean;
        public Value<string> IsEthnicityBasedOnVisual { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsEthnicityBasedOnVisual() => !IsEthnicityBasedOnVisual.Clean;
        public Value<string> IsRaceBasedOnVisual { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsRaceBasedOnVisual() => !IsRaceBasedOnVisual.Clean;
        public Value<string> IsSexBasedOnVisual { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSexBasedOnVisual() => !IsSexBasedOnVisual.Clean;
        public Value<string> LastName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastName() => !LastName.Clean;
        public Value<string> LastNameWithSuffix { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastNameWithSuffix() => !LastNameWithSuffix.Clean;
        public Value<bool?> LoanForeclosureOrJudgementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanForeclosureOrJudgementIndicator() => !LoanForeclosureOrJudgementIndicator.Clean;
        public Value<string> LpdGsa { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLpdGsa() => !LpdGsa.Clean;
        public Value<bool?> MailingAddressSameAsPresentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingAddressSameAsPresentIndicator() => !MailingAddressSameAsPresentIndicator.Clean;
        public Value<string> MaritalStatusType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaritalStatusType() => !MaritalStatusType.Clean;
        public Value<int?> MiddleCreditScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiddleCreditScore() => !MiddleCreditScore.Clean;
        public Value<string> MiddleFicoScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiddleFicoScore() => !MiddleFicoScore.Clean;
        public Value<string> MiddleName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiddleName() => !MiddleName.Clean;
        public Value<string> MinFicoScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinFicoScore() => !MinFicoScore.Clean;
        public Value<string> MobilePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMobilePhone() => !MobilePhone.Clean;
        public Value<bool?> MortgageOnCredit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageOnCredit() => !MortgageOnCredit.Clean;
        public Value<string> NameToObtainLoanFromRHS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNameToObtainLoanFromRHS() => !NameToObtainLoanFromRHS.Clean;
        public Value<string> NearestRelativeAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativeAddress() => !NearestRelativeAddress.Clean;
        public Value<string> NearestRelativeCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativeCity() => !NearestRelativeCity.Clean;
        public Value<string> NearestRelativeName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativeName() => !NearestRelativeName.Clean;
        public Value<string> NearestRelativePhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativePhone() => !NearestRelativePhone.Clean;
        public Value<string> NearestRelativePostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativePostalCode() => !NearestRelativePostalCode.Clean;
        public Value<string> NearestRelativeRelationship { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativeRelationship() => !NearestRelativeRelationship.Clean;
        public Value<string> NearestRelativeState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNearestRelativeState() => !NearestRelativeState.Clean;
        public Value<bool?> No3rdPartyEmailIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNo3rdPartyEmailIndicator() => !No3rdPartyEmailIndicator.Clean;
        public Value<bool?> NoCoApplicantIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoCoApplicantIndicator() => !NoCoApplicantIndicator.Clean;
        public Value<int?> NumberofTradelines { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberofTradelines() => !NumberofTradelines.Clean;
        public Value<bool?> ObtainLoanFromRHSIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeObtainLoanFromRHSIndicator() => !ObtainLoanFromRHSIndicator.Clean;
        public Value<string> OpenBankruptcy2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpenBankruptcy2() => !OpenBankruptcy2.Clean;
        public Value<decimal?> OtherMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherMonthlyIncomeAmount() => !OtherMonthlyIncomeAmount.Clean;
        public Value<decimal?> OtherSumAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherSumAmount() => !OtherSumAmount.Clean;
        public Value<bool?> OutstandingJudgementsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOutstandingJudgementsIndicator() => !OutstandingJudgementsIndicator.Clean;
        public Value<bool?> PartyToLawsuitIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartyToLawsuitIndicator() => !PartyToLawsuitIndicator.Clean;
        public Value<int?> Pass120Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePass120Days() => !Pass120Days.Clean;
        public Value<int?> Pass150Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePass150Days() => !Pass150Days.Clean;
        public Value<int?> Pass30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePass30Days() => !Pass30Days.Clean;
        public Value<int?> Pass60Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePass60Days() => !Pass60Days.Clean;
        public Value<int?> Pass90Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePass90Days() => !Pass90Days.Clean;
        public Value<string> PersonFaxNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonFaxNumber() => !PersonFaxNumber.Clean;
        public Value<decimal?> PersonHoursPerWeek { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonHoursPerWeek() => !PersonHoursPerWeek.Clean;
        public Value<decimal?> PersonIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonIncomeAmount() => !PersonIncomeAmount.Clean;
        public Value<string> PersonIncomeFrequencyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonIncomeFrequencyType() => !PersonIncomeFrequencyType.Clean;
        public Value<decimal?> PersonMonthlyIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePersonMonthlyIncome() => !PersonMonthlyIncome.Clean;
        public Value<string> PoaOccupancyIntent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoaOccupancyIntent() => !PoaOccupancyIntent.Clean;
        public Value<string> PoaSignatureText { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePoaSignatureText() => !PoaSignatureText.Clean;
        public Value<decimal?> PositiveCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePositiveCashFlow() => !PositiveCashFlow.Clean;
        public Value<string> PowerOfAttorneyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePowerOfAttorneyName() => !PowerOfAttorneyName.Clean;
        public Value<string> PowerOfAttorneyTitleDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePowerOfAttorneyTitleDescription() => !PowerOfAttorneyTitleDescription.Clean;
        public Value<bool?> PresentlyDelinquentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePresentlyDelinquentIndicator() => !PresentlyDelinquentIndicator.Clean;
        public Value<DateTime?> PriorBankruptcy2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorBankruptcy2() => !PriorBankruptcy2.Clean;
        public Value<bool?> PriorForeclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorForeclosure() => !PriorForeclosure.Clean;
        public Value<string> PriorPropertyTitleType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorPropertyTitleType() => !PriorPropertyTitleType.Clean;
        public Value<string> PriorPropertyUsageType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorPropertyUsageType() => !PriorPropertyUsageType.Clean;
        public Value<bool?> PropertyForeclosedPastSevenYearsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyForeclosedPastSevenYearsIndicator() => !PropertyForeclosedPastSevenYearsIndicator.Clean;
        public Value<string> RelationshipDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationshipDescription() => !RelationshipDescription.Clean;
        public Value<bool?> RelationshipWithRDEmployeeIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRelationshipWithRDEmployeeIndicator() => !RelationshipWithRDEmployeeIndicator.Clean;
        public Value<int?> SchoolingTermYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchoolingTermYears() => !SchoolingTermYears.Clean;
        public Value<bool?> SSA89BackgroundCheckIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89BackgroundCheckIndicator() => !SSA89BackgroundCheckIndicator.Clean;
        public Value<bool?> SSA89BankingServiceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89BankingServiceIndicator() => !SSA89BankingServiceIndicator.Clean;
        public Value<bool?> SSA89CreditCheckIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89CreditCheckIndicator() => !SSA89CreditCheckIndicator.Clean;
        public Value<bool?> SSA89LicenseRequirementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89LicenseRequirementIndicator() => !SSA89LicenseRequirementIndicator.Clean;
        public Value<bool?> SSA89MortgageServiceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89MortgageServiceIndicator() => !SSA89MortgageServiceIndicator.Clean;
        public Value<bool?> SSA89OtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSSA89OtherIndicator() => !SSA89OtherIndicator.Clean;
        public Value<decimal?> SubtotalLiquidAssetsMinusGiftAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubtotalLiquidAssetsMinusGiftAmount() => !SubtotalLiquidAssetsMinusGiftAmount.Clean;
        public Value<string> SuffixToName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSuffixToName() => !SuffixToName.Clean;
        public Value<string> Tax4506LastInvestor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastInvestor() => !Tax4506LastInvestor.Clean;
        public Value<string> Tax4506LastOrderNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastOrderNumber() => !Tax4506LastOrderNumber.Clean;
        public Value<int?> Tax4506LastOrderYear1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastOrderYear1() => !Tax4506LastOrderYear1.Clean;
        public Value<int?> Tax4506LastOrderYear2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastOrderYear2() => !Tax4506LastOrderYear2.Clean;
        public Value<int?> Tax4506LastOrderYear3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastOrderYear3() => !Tax4506LastOrderYear3.Clean;
        public Value<int?> Tax4506LastOrderYear4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastOrderYear4() => !Tax4506LastOrderYear4.Clean;
        public Value<string> Tax4506LastProductsOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastProductsOrdered() => !Tax4506LastProductsOrdered.Clean;
        public Value<string> Tax4506LastStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastStatus() => !Tax4506LastStatus.Clean;
        public Value<string> Tax4506LastTranscriptType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastTranscriptType() => !Tax4506LastTranscriptType.Clean;
        public Value<string> Tax4506LastUserIDWhoOrdered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506LastUserIDWhoOrdered() => !Tax4506LastUserIDWhoOrdered.Clean;
        public Value<decimal?> Tax4506TotalYearlyIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyIncome1() => !Tax4506TotalYearlyIncome1.Clean;
        public Value<decimal?> Tax4506TotalYearlyIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyIncome2() => !Tax4506TotalYearlyIncome2.Clean;
        public Value<decimal?> Tax4506TotalYearlyIncome3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyIncome3() => !Tax4506TotalYearlyIncome3.Clean;
        public Value<decimal?> Tax4506TotalYearlyIncome4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyIncome4() => !Tax4506TotalYearlyIncome4.Clean;
        public Value<decimal?> Tax4506TotalYearlyJointIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyJointIncome1() => !Tax4506TotalYearlyJointIncome1.Clean;
        public Value<decimal?> Tax4506TotalYearlyJointIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyJointIncome2() => !Tax4506TotalYearlyJointIncome2.Clean;
        public Value<decimal?> Tax4506TotalYearlyJointIncome3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyJointIncome3() => !Tax4506TotalYearlyJointIncome3.Clean;
        public Value<decimal?> Tax4506TotalYearlyJointIncome4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyJointIncome4() => !Tax4506TotalYearlyJointIncome4.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceIncome1() => !Tax4506TotalYearlyVarianceIncome1.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceIncome2() => !Tax4506TotalYearlyVarianceIncome2.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceIncome3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceIncome3() => !Tax4506TotalYearlyVarianceIncome3.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceIncome4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceIncome4() => !Tax4506TotalYearlyVarianceIncome4.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceJointIncome1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceJointIncome1() => !Tax4506TotalYearlyVarianceJointIncome1.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceJointIncome2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceJointIncome2() => !Tax4506TotalYearlyVarianceJointIncome2.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceJointIncome3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceJointIncome3() => !Tax4506TotalYearlyVarianceJointIncome3.Clean;
        public Value<decimal?> Tax4506TotalYearlyVarianceJointIncome4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTax4506TotalYearlyVarianceJointIncome4() => !Tax4506TotalYearlyVarianceJointIncome4.Clean;
        public Value<string> TaxIdentificationIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxIdentificationIdentifier() => !TaxIdentificationIdentifier.Clean;
        public Value<decimal?> TotalLiabilitiesBalanceAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLiabilitiesBalanceAmount() => !TotalLiabilitiesBalanceAmount.Clean;
        public Value<decimal?> TotalMonthlyIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyIncomeAmount() => !TotalMonthlyIncomeAmount.Clean;
        public Value<decimal?> TotalMonthlyIncomeMinusNetRentalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMonthlyIncomeMinusNetRentalAmount() => !TotalMonthlyIncomeMinusNetRentalAmount.Clean;
        public Value<decimal?> TotalPresentHousingExpenseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPresentHousingExpenseAmount() => !TotalPresentHousingExpenseAmount.Clean;
        public Value<string> TransactionPurposeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransactionPurposeDescription() => !TransactionPurposeDescription.Clean;
        public Value<int?> TransUnion120Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnion120Days() => !TransUnion120Days.Clean;
        public Value<int?> TransUnion150Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnion150Days() => !TransUnion150Days.Clean;
        public Value<int?> TransUnion30Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnion30Days() => !TransUnion30Days.Clean;
        public Value<int?> TransUnion60Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnion60Days() => !TransUnion60Days.Clean;
        public Value<int?> TransUnion90Days { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnion90Days() => !TransUnion90Days.Clean;
        public Value<bool?> TransUnionCreditScoreForDisclosure { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionCreditScoreForDisclosure() => !TransUnionCreditScoreForDisclosure.Clean;
        public Value<int?> TransUnionCreditScoreRanksPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionCreditScoreRanksPercent() => !TransUnionCreditScoreRanksPercent.Clean;
        public Value<DateTime?> TransUnionDatePulled { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionDatePulled() => !TransUnionDatePulled.Clean;
        public Value<string> TransUnionFactorCode1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFactorCode1() => !TransUnionFactorCode1.Clean;
        public Value<string> TransUnionFactorCode2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFactorCode2() => !TransUnionFactorCode2.Clean;
        public Value<string> TransUnionFactorCode3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFactorCode3() => !TransUnionFactorCode3.Clean;
        public Value<string> TransUnionFactorCode4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFactorCode4() => !TransUnionFactorCode4.Clean;
        public Value<string> TransUnionFactorCode5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionFactorCode5() => !TransUnionFactorCode5.Clean;
        public Value<string> TransUnionKeyFactor1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionKeyFactor1() => !TransUnionKeyFactor1.Clean;
        public Value<string> TransUnionKeyFactor2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionKeyFactor2() => !TransUnionKeyFactor2.Clean;
        public Value<string> TransUnionKeyFactor3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionKeyFactor3() => !TransUnionKeyFactor3.Clean;
        public Value<string> TransUnionKeyFactor4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionKeyFactor4() => !TransUnionKeyFactor4.Clean;
        public Value<string> TransUnionKeyFactor5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionKeyFactor5() => !TransUnionKeyFactor5.Clean;
        public Value<bool?> TransUnionMaterialTermsCreditByScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionMaterialTermsCreditByScore() => !TransUnionMaterialTermsCreditByScore.Clean;
        public Value<string> TransUnionScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTransUnionScore() => !TransUnionScore.Clean;
        public Value<decimal?> UserDefinedIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUserDefinedIncome() => !UserDefinedIncome.Clean;
        public Value<decimal?> VaFederalTaxAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaFederalTaxAmount() => !VaFederalTaxAmount.Clean;
        public Value<int?> ValidDaysForConsentCount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeValidDaysForConsentCount() => !ValidDaysForConsentCount.Clean;
        public Value<decimal?> VaNetTakeHomePayAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaNetTakeHomePayAmount() => !VaNetTakeHomePayAmount.Clean;
        public Value<decimal?> VaOtherAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaOtherAmount() => !VaOtherAmount.Clean;
        public Value<decimal?> VaOtherNetIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaOtherNetIncomeAmount() => !VaOtherNetIncomeAmount.Clean;
        public Value<decimal?> VaRetirementAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaRetirementAmount() => !VaRetirementAmount.Clean;
        public Value<decimal?> VaStateTaxAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaStateTaxAmount() => !VaStateTaxAmount.Clean;
        public Value<decimal?> VaTotalIncomeDeductionsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaTotalIncomeDeductionsAmount() => !VaTotalIncomeDeductionsAmount.Clean;
        public Value<decimal?> VaTotalNetIncomeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVaTotalNetIncomeAmount() => !VaTotalNetIncomeAmount.Clean;
        public Value<string> Vendor1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor1() => !Vendor1.Clean;
        public Value<string> Vendor10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor10() => !Vendor10.Clean;
        public Value<string> Vendor11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor11() => !Vendor11.Clean;
        public Value<string> Vendor12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor12() => !Vendor12.Clean;
        public Value<string> Vendor2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor2() => !Vendor2.Clean;
        public Value<string> Vendor3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor3() => !Vendor3.Clean;
        public Value<string> Vendor4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor4() => !Vendor4.Clean;
        public Value<string> Vendor5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor5() => !Vendor5.Clean;
        public Value<string> Vendor6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor6() => !Vendor6.Clean;
        public Value<string> Vendor7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor7() => !Vendor7.Clean;
        public Value<string> Vendor8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor8() => !Vendor8.Clean;
        public Value<string> Vendor9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVendor9() => !Vendor9.Clean;
        public Value<string> VestingTrusteeOfType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVestingTrusteeOfType() => !VestingTrusteeOfType.Clean;
        public Value<bool?> VeteranIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVeteranIndicator() => !VeteranIndicator.Clean;
        public Value<string> WorkEmailAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWorkEmailAddress() => !WorkEmailAddress.Clean;
        public Value<int?> YearsofCreditOnFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearsofCreditOnFile() => !YearsofCreditOnFile.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AcountChekAssetId.Clean
                    && AgeAtApplicationYearsCount.Clean
                    && AliasName.Clean
                    && AlimonyChildSupportObligationIndicator.Clean
                    && AltId.Clean
                    && ApplicantType.Clean
                    && ApplicationTakenMethodType.Clean
                    && AuthorizedCreditReportIndicator.Clean
                    && AuthorizedToSignIndicator.Clean
                    && BankAccountNumber.Clean
                    && BankAccountType.Clean
                    && BankContactAddress.Clean
                    && BankContactCity.Clean
                    && BankContactName.Clean
                    && BankContactPostalCode.Clean
                    && BankContactState.Clean
                    && BankruptcyIndicator.Clean
                    && BankruptcyStatus.Clean
                    && BaseMonthlyIncomeAmount.Clean
                    && BirthDate.Clean
                    && BorrowedDownPaymentIndicator.Clean
                    && BorrowerConsentRequestDate.Clean
                    && BorrowerIndex.Clean
                    && BorrowerType.Clean
                    && BorrowerTypeInSummary.Clean
                    && CaivrsIdentifier.Clean
                    && CitizenshipResidencyType.Clean
                    && CoMakerEndorserOfNoteIndicator.Clean
                    && CommentOfCreditReport.Clean
                    && ConfirmedCRDIL.Clean
                    && ConfirmedCRFCEC.Clean
                    && ConfirmedCRFCIncorrect.Clean
                    && ConfirmedCRPFS.Clean
                    && ConfirmedOther.Clean
                    && ConfirmedOtherDescription.Clean
                    && CreditCounseling.Clean
                    && CreditReceivedDate.Clean
                    && CreditReportAuthorizationMethod.Clean
                    && CreditScoreIndicator.Clean
                    && DateAuthorizedCreditReport.Clean
                    && DateOfBankruptcy.Clean
                    && DateOfForeclosure.Clean
                    && DeclarationsJIndicator.Clean
                    && DeclarationsKIndicator.Clean
                    && DependentCount.Clean
                    && DependentsAgesDescription.Clean
                    && DisabledIndicator.Clean
                    && EmailAddressText.Clean
                    && Equifax120Days.Clean
                    && Equifax150Days.Clean
                    && Equifax30Days.Clean
                    && Equifax60Days.Clean
                    && Equifax90Days.Clean
                    && EquifaxCreditScoreForDisclosure.Clean
                    && EquifaxCreditScoreRanksPercent.Clean
                    && EquifaxDatePulled.Clean
                    && EquifaxFactorCode1.Clean
                    && EquifaxFactorCode2.Clean
                    && EquifaxFactorCode3.Clean
                    && EquifaxFactorCode4.Clean
                    && EquifaxFactorCode5.Clean
                    && EquifaxKeyFactor1.Clean
                    && EquifaxKeyFactor2.Clean
                    && EquifaxKeyFactor3.Clean
                    && EquifaxKeyFactor4.Clean
                    && EquifaxKeyFactor5.Clean
                    && EquifaxMaterialTermsCreditByScore.Clean
                    && EquifaxScore.Clean
                    && Experian120Days.Clean
                    && Experian150Days.Clean
                    && Experian30Days.Clean
                    && Experian60Days.Clean
                    && Experian90Days.Clean
                    && ExperianCreditScore.Clean
                    && ExperianCreditScoreForDisclosure.Clean
                    && ExperianCreditScoreRanksPercent.Clean
                    && ExperianDatePulled.Clean
                    && ExperianFactorCode1.Clean
                    && ExperianFactorCode2.Clean
                    && ExperianFactorCode3.Clean
                    && ExperianFactorCode4.Clean
                    && ExperianFactorCode5.Clean
                    && ExperianKeyFactor1.Clean
                    && ExperianKeyFactor2.Clean
                    && ExperianKeyFactor3.Clean
                    && ExperianKeyFactor4.Clean
                    && ExperianKeyFactor5.Clean
                    && ExperianMaterialTermsCreditByScore.Clean
                    && FirstName.Clean
                    && FirstNameWithMiddleName.Clean
                    && FirstTimeHomeBuyer.Clean
                    && ForeclosureSatisfied.Clean
                    && ForeclosureStatus.Clean
                    && FreddieMacPerson1.Clean
                    && FreddieMacPerson2.Clean
                    && FullName.Clean
                    && FullNameWithSuffix.Clean
                    && HighestCreditLimit.Clean
                    && Hmda2003OtherRaceNationalOriginDescription.Clean
                    && Hmda2003RaceNationalOriginType.Clean
                    && HmdaAfricanAmericanIndicator.Clean
                    && HmdaAge.Clean
                    && HmdaAmericanIndianIndicator.Clean
                    && HmdaAmericanIndianTribe.Clean
                    && HmdaAsianIndianIndicator.Clean
                    && HmdaAsianIndicator.Clean
                    && HmdaAsianOtherRaceIndicator.Clean
                    && HmdaChineseIndicator.Clean
                    && HmdaCreditScoreForDecisionMaking.Clean
                    && HmdaCreditScoringModel.Clean
                    && HmdaCubanIndicator.Clean
                    && HmdaEthnicityType.Clean
                    && HmdaFilipinoIndicator.Clean
                    && HmdaGenderType.Clean
                    && HmdaGuamanianOrChamorroIndicator.Clean
                    && HmdaHispanicLatinoOtherOriginIndicator.Clean
                    && HmdaJapaneseIndicator.Clean
                    && HmdaKoreanIndicator.Clean
                    && HmdaMexicanIndicator.Clean
                    && HmdaNativeHawaiianIndicator.Clean
                    && HmdaNoCoApplicantIndicator.Clean
                    && HmdaNotApplicableIndicator.Clean
                    && HmdaNotProvidedIndicator.Clean
                    && HmdaOtherAsianRace.Clean
                    && HmdaOtherHispanicLatinoOrigin.Clean
                    && HmdaOtherPacificIslanderRace.Clean
                    && HmdaOtherScoringModel.Clean
                    && HmdaPacificIslanderIndicator.Clean
                    && HmdaPacificIslanderOtherIndicator.Clean
                    && HmdaPuertoRicanIndicator.Clean
                    && HmdaRefusalIndicator.Clean
                    && HmdaSamoanIndicator.Clean
                    && HmdaVietnameseIndicator.Clean
                    && HmdaWhiteIndicator.Clean
                    && HomeownerPastThreeYearsIndicator.Clean
                    && HomePhoneNumber.Clean
                    && Id.Clean
                    && IntentToOccupyIndicator.Clean
                    && IntuitReportId.Clean
                    && IsBorrower.Clean
                    && IsEthnicityBasedOnVisual.Clean
                    && IsRaceBasedOnVisual.Clean
                    && IsSexBasedOnVisual.Clean
                    && LastName.Clean
                    && LastNameWithSuffix.Clean
                    && LoanForeclosureOrJudgementIndicator.Clean
                    && LpdGsa.Clean
                    && MailingAddressSameAsPresentIndicator.Clean
                    && MaritalStatusType.Clean
                    && MiddleCreditScore.Clean
                    && MiddleFicoScore.Clean
                    && MiddleName.Clean
                    && MinFicoScore.Clean
                    && MobilePhone.Clean
                    && MortgageOnCredit.Clean
                    && NameToObtainLoanFromRHS.Clean
                    && NearestRelativeAddress.Clean
                    && NearestRelativeCity.Clean
                    && NearestRelativeName.Clean
                    && NearestRelativePhone.Clean
                    && NearestRelativePostalCode.Clean
                    && NearestRelativeRelationship.Clean
                    && NearestRelativeState.Clean
                    && No3rdPartyEmailIndicator.Clean
                    && NoCoApplicantIndicator.Clean
                    && NumberofTradelines.Clean
                    && ObtainLoanFromRHSIndicator.Clean
                    && OpenBankruptcy2.Clean
                    && OtherMonthlyIncomeAmount.Clean
                    && OtherSumAmount.Clean
                    && OutstandingJudgementsIndicator.Clean
                    && PartyToLawsuitIndicator.Clean
                    && Pass120Days.Clean
                    && Pass150Days.Clean
                    && Pass30Days.Clean
                    && Pass60Days.Clean
                    && Pass90Days.Clean
                    && PersonFaxNumber.Clean
                    && PersonHoursPerWeek.Clean
                    && PersonIncomeAmount.Clean
                    && PersonIncomeFrequencyType.Clean
                    && PersonMonthlyIncome.Clean
                    && PoaOccupancyIntent.Clean
                    && PoaSignatureText.Clean
                    && PositiveCashFlow.Clean
                    && PowerOfAttorneyName.Clean
                    && PowerOfAttorneyTitleDescription.Clean
                    && PresentlyDelinquentIndicator.Clean
                    && PriorBankruptcy2.Clean
                    && PriorForeclosure.Clean
                    && PriorPropertyTitleType.Clean
                    && PriorPropertyUsageType.Clean
                    && PropertyForeclosedPastSevenYearsIndicator.Clean
                    && RelationshipDescription.Clean
                    && RelationshipWithRDEmployeeIndicator.Clean
                    && SchoolingTermYears.Clean
                    && SSA89BackgroundCheckIndicator.Clean
                    && SSA89BankingServiceIndicator.Clean
                    && SSA89CreditCheckIndicator.Clean
                    && SSA89LicenseRequirementIndicator.Clean
                    && SSA89MortgageServiceIndicator.Clean
                    && SSA89OtherIndicator.Clean
                    && SubtotalLiquidAssetsMinusGiftAmount.Clean
                    && SuffixToName.Clean
                    && Tax4506LastInvestor.Clean
                    && Tax4506LastOrderNumber.Clean
                    && Tax4506LastOrderYear1.Clean
                    && Tax4506LastOrderYear2.Clean
                    && Tax4506LastOrderYear3.Clean
                    && Tax4506LastOrderYear4.Clean
                    && Tax4506LastProductsOrdered.Clean
                    && Tax4506LastStatus.Clean
                    && Tax4506LastTranscriptType.Clean
                    && Tax4506LastUserIDWhoOrdered.Clean
                    && Tax4506TotalYearlyIncome1.Clean
                    && Tax4506TotalYearlyIncome2.Clean
                    && Tax4506TotalYearlyIncome3.Clean
                    && Tax4506TotalYearlyIncome4.Clean
                    && Tax4506TotalYearlyJointIncome1.Clean
                    && Tax4506TotalYearlyJointIncome2.Clean
                    && Tax4506TotalYearlyJointIncome3.Clean
                    && Tax4506TotalYearlyJointIncome4.Clean
                    && Tax4506TotalYearlyVarianceIncome1.Clean
                    && Tax4506TotalYearlyVarianceIncome2.Clean
                    && Tax4506TotalYearlyVarianceIncome3.Clean
                    && Tax4506TotalYearlyVarianceIncome4.Clean
                    && Tax4506TotalYearlyVarianceJointIncome1.Clean
                    && Tax4506TotalYearlyVarianceJointIncome2.Clean
                    && Tax4506TotalYearlyVarianceJointIncome3.Clean
                    && Tax4506TotalYearlyVarianceJointIncome4.Clean
                    && TaxIdentificationIdentifier.Clean
                    && TotalLiabilitiesBalanceAmount.Clean
                    && TotalMonthlyIncomeAmount.Clean
                    && TotalMonthlyIncomeMinusNetRentalAmount.Clean
                    && TotalPresentHousingExpenseAmount.Clean
                    && TransactionPurposeDescription.Clean
                    && TransUnion120Days.Clean
                    && TransUnion150Days.Clean
                    && TransUnion30Days.Clean
                    && TransUnion60Days.Clean
                    && TransUnion90Days.Clean
                    && TransUnionCreditScoreForDisclosure.Clean
                    && TransUnionCreditScoreRanksPercent.Clean
                    && TransUnionDatePulled.Clean
                    && TransUnionFactorCode1.Clean
                    && TransUnionFactorCode2.Clean
                    && TransUnionFactorCode3.Clean
                    && TransUnionFactorCode4.Clean
                    && TransUnionFactorCode5.Clean
                    && TransUnionKeyFactor1.Clean
                    && TransUnionKeyFactor2.Clean
                    && TransUnionKeyFactor3.Clean
                    && TransUnionKeyFactor4.Clean
                    && TransUnionKeyFactor5.Clean
                    && TransUnionMaterialTermsCreditByScore.Clean
                    && TransUnionScore.Clean
                    && UserDefinedIncome.Clean
                    && VaFederalTaxAmount.Clean
                    && ValidDaysForConsentCount.Clean
                    && VaNetTakeHomePayAmount.Clean
                    && VaOtherAmount.Clean
                    && VaOtherNetIncomeAmount.Clean
                    && VaRetirementAmount.Clean
                    && VaStateTaxAmount.Clean
                    && VaTotalIncomeDeductionsAmount.Clean
                    && VaTotalNetIncomeAmount.Clean
                    && Vendor1.Clean
                    && Vendor10.Clean
                    && Vendor11.Clean
                    && Vendor12.Clean
                    && Vendor2.Clean
                    && Vendor3.Clean
                    && Vendor4.Clean
                    && Vendor5.Clean
                    && Vendor6.Clean
                    && Vendor7.Clean
                    && Vendor8.Clean
                    && Vendor9.Clean
                    && VestingTrusteeOfType.Clean
                    && VeteranIndicator.Clean
                    && WorkEmailAddress.Clean
                    && YearsofCreditOnFile.Clean
                    && Application.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AcountChekAssetId; v0.Clean = value; AcountChekAssetId = v0;
                var v1 = AgeAtApplicationYearsCount; v1.Clean = value; AgeAtApplicationYearsCount = v1;
                var v2 = AliasName; v2.Clean = value; AliasName = v2;
                var v3 = AlimonyChildSupportObligationIndicator; v3.Clean = value; AlimonyChildSupportObligationIndicator = v3;
                var v4 = AltId; v4.Clean = value; AltId = v4;
                var v5 = ApplicantType; v5.Clean = value; ApplicantType = v5;
                var v6 = ApplicationTakenMethodType; v6.Clean = value; ApplicationTakenMethodType = v6;
                var v7 = AuthorizedCreditReportIndicator; v7.Clean = value; AuthorizedCreditReportIndicator = v7;
                var v8 = AuthorizedToSignIndicator; v8.Clean = value; AuthorizedToSignIndicator = v8;
                var v9 = BankAccountNumber; v9.Clean = value; BankAccountNumber = v9;
                var v10 = BankAccountType; v10.Clean = value; BankAccountType = v10;
                var v11 = BankContactAddress; v11.Clean = value; BankContactAddress = v11;
                var v12 = BankContactCity; v12.Clean = value; BankContactCity = v12;
                var v13 = BankContactName; v13.Clean = value; BankContactName = v13;
                var v14 = BankContactPostalCode; v14.Clean = value; BankContactPostalCode = v14;
                var v15 = BankContactState; v15.Clean = value; BankContactState = v15;
                var v16 = BankruptcyIndicator; v16.Clean = value; BankruptcyIndicator = v16;
                var v17 = BankruptcyStatus; v17.Clean = value; BankruptcyStatus = v17;
                var v18 = BaseMonthlyIncomeAmount; v18.Clean = value; BaseMonthlyIncomeAmount = v18;
                var v19 = BirthDate; v19.Clean = value; BirthDate = v19;
                var v20 = BorrowedDownPaymentIndicator; v20.Clean = value; BorrowedDownPaymentIndicator = v20;
                var v21 = BorrowerConsentRequestDate; v21.Clean = value; BorrowerConsentRequestDate = v21;
                var v22 = BorrowerIndex; v22.Clean = value; BorrowerIndex = v22;
                var v23 = BorrowerType; v23.Clean = value; BorrowerType = v23;
                var v24 = BorrowerTypeInSummary; v24.Clean = value; BorrowerTypeInSummary = v24;
                var v25 = CaivrsIdentifier; v25.Clean = value; CaivrsIdentifier = v25;
                var v26 = CitizenshipResidencyType; v26.Clean = value; CitizenshipResidencyType = v26;
                var v27 = CoMakerEndorserOfNoteIndicator; v27.Clean = value; CoMakerEndorserOfNoteIndicator = v27;
                var v28 = CommentOfCreditReport; v28.Clean = value; CommentOfCreditReport = v28;
                var v29 = ConfirmedCRDIL; v29.Clean = value; ConfirmedCRDIL = v29;
                var v30 = ConfirmedCRFCEC; v30.Clean = value; ConfirmedCRFCEC = v30;
                var v31 = ConfirmedCRFCIncorrect; v31.Clean = value; ConfirmedCRFCIncorrect = v31;
                var v32 = ConfirmedCRPFS; v32.Clean = value; ConfirmedCRPFS = v32;
                var v33 = ConfirmedOther; v33.Clean = value; ConfirmedOther = v33;
                var v34 = ConfirmedOtherDescription; v34.Clean = value; ConfirmedOtherDescription = v34;
                var v35 = CreditCounseling; v35.Clean = value; CreditCounseling = v35;
                var v36 = CreditReceivedDate; v36.Clean = value; CreditReceivedDate = v36;
                var v37 = CreditReportAuthorizationMethod; v37.Clean = value; CreditReportAuthorizationMethod = v37;
                var v38 = CreditScoreIndicator; v38.Clean = value; CreditScoreIndicator = v38;
                var v39 = DateAuthorizedCreditReport; v39.Clean = value; DateAuthorizedCreditReport = v39;
                var v40 = DateOfBankruptcy; v40.Clean = value; DateOfBankruptcy = v40;
                var v41 = DateOfForeclosure; v41.Clean = value; DateOfForeclosure = v41;
                var v42 = DeclarationsJIndicator; v42.Clean = value; DeclarationsJIndicator = v42;
                var v43 = DeclarationsKIndicator; v43.Clean = value; DeclarationsKIndicator = v43;
                var v44 = DependentCount; v44.Clean = value; DependentCount = v44;
                var v45 = DependentsAgesDescription; v45.Clean = value; DependentsAgesDescription = v45;
                var v46 = DisabledIndicator; v46.Clean = value; DisabledIndicator = v46;
                var v47 = EmailAddressText; v47.Clean = value; EmailAddressText = v47;
                var v48 = Equifax120Days; v48.Clean = value; Equifax120Days = v48;
                var v49 = Equifax150Days; v49.Clean = value; Equifax150Days = v49;
                var v50 = Equifax30Days; v50.Clean = value; Equifax30Days = v50;
                var v51 = Equifax60Days; v51.Clean = value; Equifax60Days = v51;
                var v52 = Equifax90Days; v52.Clean = value; Equifax90Days = v52;
                var v53 = EquifaxCreditScoreForDisclosure; v53.Clean = value; EquifaxCreditScoreForDisclosure = v53;
                var v54 = EquifaxCreditScoreRanksPercent; v54.Clean = value; EquifaxCreditScoreRanksPercent = v54;
                var v55 = EquifaxDatePulled; v55.Clean = value; EquifaxDatePulled = v55;
                var v56 = EquifaxFactorCode1; v56.Clean = value; EquifaxFactorCode1 = v56;
                var v57 = EquifaxFactorCode2; v57.Clean = value; EquifaxFactorCode2 = v57;
                var v58 = EquifaxFactorCode3; v58.Clean = value; EquifaxFactorCode3 = v58;
                var v59 = EquifaxFactorCode4; v59.Clean = value; EquifaxFactorCode4 = v59;
                var v60 = EquifaxFactorCode5; v60.Clean = value; EquifaxFactorCode5 = v60;
                var v61 = EquifaxKeyFactor1; v61.Clean = value; EquifaxKeyFactor1 = v61;
                var v62 = EquifaxKeyFactor2; v62.Clean = value; EquifaxKeyFactor2 = v62;
                var v63 = EquifaxKeyFactor3; v63.Clean = value; EquifaxKeyFactor3 = v63;
                var v64 = EquifaxKeyFactor4; v64.Clean = value; EquifaxKeyFactor4 = v64;
                var v65 = EquifaxKeyFactor5; v65.Clean = value; EquifaxKeyFactor5 = v65;
                var v66 = EquifaxMaterialTermsCreditByScore; v66.Clean = value; EquifaxMaterialTermsCreditByScore = v66;
                var v67 = EquifaxScore; v67.Clean = value; EquifaxScore = v67;
                var v68 = Experian120Days; v68.Clean = value; Experian120Days = v68;
                var v69 = Experian150Days; v69.Clean = value; Experian150Days = v69;
                var v70 = Experian30Days; v70.Clean = value; Experian30Days = v70;
                var v71 = Experian60Days; v71.Clean = value; Experian60Days = v71;
                var v72 = Experian90Days; v72.Clean = value; Experian90Days = v72;
                var v73 = ExperianCreditScore; v73.Clean = value; ExperianCreditScore = v73;
                var v74 = ExperianCreditScoreForDisclosure; v74.Clean = value; ExperianCreditScoreForDisclosure = v74;
                var v75 = ExperianCreditScoreRanksPercent; v75.Clean = value; ExperianCreditScoreRanksPercent = v75;
                var v76 = ExperianDatePulled; v76.Clean = value; ExperianDatePulled = v76;
                var v77 = ExperianFactorCode1; v77.Clean = value; ExperianFactorCode1 = v77;
                var v78 = ExperianFactorCode2; v78.Clean = value; ExperianFactorCode2 = v78;
                var v79 = ExperianFactorCode3; v79.Clean = value; ExperianFactorCode3 = v79;
                var v80 = ExperianFactorCode4; v80.Clean = value; ExperianFactorCode4 = v80;
                var v81 = ExperianFactorCode5; v81.Clean = value; ExperianFactorCode5 = v81;
                var v82 = ExperianKeyFactor1; v82.Clean = value; ExperianKeyFactor1 = v82;
                var v83 = ExperianKeyFactor2; v83.Clean = value; ExperianKeyFactor2 = v83;
                var v84 = ExperianKeyFactor3; v84.Clean = value; ExperianKeyFactor3 = v84;
                var v85 = ExperianKeyFactor4; v85.Clean = value; ExperianKeyFactor4 = v85;
                var v86 = ExperianKeyFactor5; v86.Clean = value; ExperianKeyFactor5 = v86;
                var v87 = ExperianMaterialTermsCreditByScore; v87.Clean = value; ExperianMaterialTermsCreditByScore = v87;
                var v88 = FirstName; v88.Clean = value; FirstName = v88;
                var v89 = FirstNameWithMiddleName; v89.Clean = value; FirstNameWithMiddleName = v89;
                var v90 = FirstTimeHomeBuyer; v90.Clean = value; FirstTimeHomeBuyer = v90;
                var v91 = ForeclosureSatisfied; v91.Clean = value; ForeclosureSatisfied = v91;
                var v92 = ForeclosureStatus; v92.Clean = value; ForeclosureStatus = v92;
                var v93 = FreddieMacPerson1; v93.Clean = value; FreddieMacPerson1 = v93;
                var v94 = FreddieMacPerson2; v94.Clean = value; FreddieMacPerson2 = v94;
                var v95 = FullName; v95.Clean = value; FullName = v95;
                var v96 = FullNameWithSuffix; v96.Clean = value; FullNameWithSuffix = v96;
                var v97 = HighestCreditLimit; v97.Clean = value; HighestCreditLimit = v97;
                var v98 = Hmda2003OtherRaceNationalOriginDescription; v98.Clean = value; Hmda2003OtherRaceNationalOriginDescription = v98;
                var v99 = Hmda2003RaceNationalOriginType; v99.Clean = value; Hmda2003RaceNationalOriginType = v99;
                var v100 = HmdaAfricanAmericanIndicator; v100.Clean = value; HmdaAfricanAmericanIndicator = v100;
                var v101 = HmdaAge; v101.Clean = value; HmdaAge = v101;
                var v102 = HmdaAmericanIndianIndicator; v102.Clean = value; HmdaAmericanIndianIndicator = v102;
                var v103 = HmdaAmericanIndianTribe; v103.Clean = value; HmdaAmericanIndianTribe = v103;
                var v104 = HmdaAsianIndianIndicator; v104.Clean = value; HmdaAsianIndianIndicator = v104;
                var v105 = HmdaAsianIndicator; v105.Clean = value; HmdaAsianIndicator = v105;
                var v106 = HmdaAsianOtherRaceIndicator; v106.Clean = value; HmdaAsianOtherRaceIndicator = v106;
                var v107 = HmdaChineseIndicator; v107.Clean = value; HmdaChineseIndicator = v107;
                var v108 = HmdaCreditScoreForDecisionMaking; v108.Clean = value; HmdaCreditScoreForDecisionMaking = v108;
                var v109 = HmdaCreditScoringModel; v109.Clean = value; HmdaCreditScoringModel = v109;
                var v110 = HmdaCubanIndicator; v110.Clean = value; HmdaCubanIndicator = v110;
                var v111 = HmdaEthnicityType; v111.Clean = value; HmdaEthnicityType = v111;
                var v112 = HmdaFilipinoIndicator; v112.Clean = value; HmdaFilipinoIndicator = v112;
                var v113 = HmdaGenderType; v113.Clean = value; HmdaGenderType = v113;
                var v114 = HmdaGuamanianOrChamorroIndicator; v114.Clean = value; HmdaGuamanianOrChamorroIndicator = v114;
                var v115 = HmdaHispanicLatinoOtherOriginIndicator; v115.Clean = value; HmdaHispanicLatinoOtherOriginIndicator = v115;
                var v116 = HmdaJapaneseIndicator; v116.Clean = value; HmdaJapaneseIndicator = v116;
                var v117 = HmdaKoreanIndicator; v117.Clean = value; HmdaKoreanIndicator = v117;
                var v118 = HmdaMexicanIndicator; v118.Clean = value; HmdaMexicanIndicator = v118;
                var v119 = HmdaNativeHawaiianIndicator; v119.Clean = value; HmdaNativeHawaiianIndicator = v119;
                var v120 = HmdaNoCoApplicantIndicator; v120.Clean = value; HmdaNoCoApplicantIndicator = v120;
                var v121 = HmdaNotApplicableIndicator; v121.Clean = value; HmdaNotApplicableIndicator = v121;
                var v122 = HmdaNotProvidedIndicator; v122.Clean = value; HmdaNotProvidedIndicator = v122;
                var v123 = HmdaOtherAsianRace; v123.Clean = value; HmdaOtherAsianRace = v123;
                var v124 = HmdaOtherHispanicLatinoOrigin; v124.Clean = value; HmdaOtherHispanicLatinoOrigin = v124;
                var v125 = HmdaOtherPacificIslanderRace; v125.Clean = value; HmdaOtherPacificIslanderRace = v125;
                var v126 = HmdaOtherScoringModel; v126.Clean = value; HmdaOtherScoringModel = v126;
                var v127 = HmdaPacificIslanderIndicator; v127.Clean = value; HmdaPacificIslanderIndicator = v127;
                var v128 = HmdaPacificIslanderOtherIndicator; v128.Clean = value; HmdaPacificIslanderOtherIndicator = v128;
                var v129 = HmdaPuertoRicanIndicator; v129.Clean = value; HmdaPuertoRicanIndicator = v129;
                var v130 = HmdaRefusalIndicator; v130.Clean = value; HmdaRefusalIndicator = v130;
                var v131 = HmdaSamoanIndicator; v131.Clean = value; HmdaSamoanIndicator = v131;
                var v132 = HmdaVietnameseIndicator; v132.Clean = value; HmdaVietnameseIndicator = v132;
                var v133 = HmdaWhiteIndicator; v133.Clean = value; HmdaWhiteIndicator = v133;
                var v134 = HomeownerPastThreeYearsIndicator; v134.Clean = value; HomeownerPastThreeYearsIndicator = v134;
                var v135 = HomePhoneNumber; v135.Clean = value; HomePhoneNumber = v135;
                var v136 = Id; v136.Clean = value; Id = v136;
                var v137 = IntentToOccupyIndicator; v137.Clean = value; IntentToOccupyIndicator = v137;
                var v138 = IntuitReportId; v138.Clean = value; IntuitReportId = v138;
                var v139 = IsBorrower; v139.Clean = value; IsBorrower = v139;
                var v140 = IsEthnicityBasedOnVisual; v140.Clean = value; IsEthnicityBasedOnVisual = v140;
                var v141 = IsRaceBasedOnVisual; v141.Clean = value; IsRaceBasedOnVisual = v141;
                var v142 = IsSexBasedOnVisual; v142.Clean = value; IsSexBasedOnVisual = v142;
                var v143 = LastName; v143.Clean = value; LastName = v143;
                var v144 = LastNameWithSuffix; v144.Clean = value; LastNameWithSuffix = v144;
                var v145 = LoanForeclosureOrJudgementIndicator; v145.Clean = value; LoanForeclosureOrJudgementIndicator = v145;
                var v146 = LpdGsa; v146.Clean = value; LpdGsa = v146;
                var v147 = MailingAddressSameAsPresentIndicator; v147.Clean = value; MailingAddressSameAsPresentIndicator = v147;
                var v148 = MaritalStatusType; v148.Clean = value; MaritalStatusType = v148;
                var v149 = MiddleCreditScore; v149.Clean = value; MiddleCreditScore = v149;
                var v150 = MiddleFicoScore; v150.Clean = value; MiddleFicoScore = v150;
                var v151 = MiddleName; v151.Clean = value; MiddleName = v151;
                var v152 = MinFicoScore; v152.Clean = value; MinFicoScore = v152;
                var v153 = MobilePhone; v153.Clean = value; MobilePhone = v153;
                var v154 = MortgageOnCredit; v154.Clean = value; MortgageOnCredit = v154;
                var v155 = NameToObtainLoanFromRHS; v155.Clean = value; NameToObtainLoanFromRHS = v155;
                var v156 = NearestRelativeAddress; v156.Clean = value; NearestRelativeAddress = v156;
                var v157 = NearestRelativeCity; v157.Clean = value; NearestRelativeCity = v157;
                var v158 = NearestRelativeName; v158.Clean = value; NearestRelativeName = v158;
                var v159 = NearestRelativePhone; v159.Clean = value; NearestRelativePhone = v159;
                var v160 = NearestRelativePostalCode; v160.Clean = value; NearestRelativePostalCode = v160;
                var v161 = NearestRelativeRelationship; v161.Clean = value; NearestRelativeRelationship = v161;
                var v162 = NearestRelativeState; v162.Clean = value; NearestRelativeState = v162;
                var v163 = No3rdPartyEmailIndicator; v163.Clean = value; No3rdPartyEmailIndicator = v163;
                var v164 = NoCoApplicantIndicator; v164.Clean = value; NoCoApplicantIndicator = v164;
                var v165 = NumberofTradelines; v165.Clean = value; NumberofTradelines = v165;
                var v166 = ObtainLoanFromRHSIndicator; v166.Clean = value; ObtainLoanFromRHSIndicator = v166;
                var v167 = OpenBankruptcy2; v167.Clean = value; OpenBankruptcy2 = v167;
                var v168 = OtherMonthlyIncomeAmount; v168.Clean = value; OtherMonthlyIncomeAmount = v168;
                var v169 = OtherSumAmount; v169.Clean = value; OtherSumAmount = v169;
                var v170 = OutstandingJudgementsIndicator; v170.Clean = value; OutstandingJudgementsIndicator = v170;
                var v171 = PartyToLawsuitIndicator; v171.Clean = value; PartyToLawsuitIndicator = v171;
                var v172 = Pass120Days; v172.Clean = value; Pass120Days = v172;
                var v173 = Pass150Days; v173.Clean = value; Pass150Days = v173;
                var v174 = Pass30Days; v174.Clean = value; Pass30Days = v174;
                var v175 = Pass60Days; v175.Clean = value; Pass60Days = v175;
                var v176 = Pass90Days; v176.Clean = value; Pass90Days = v176;
                var v177 = PersonFaxNumber; v177.Clean = value; PersonFaxNumber = v177;
                var v178 = PersonHoursPerWeek; v178.Clean = value; PersonHoursPerWeek = v178;
                var v179 = PersonIncomeAmount; v179.Clean = value; PersonIncomeAmount = v179;
                var v180 = PersonIncomeFrequencyType; v180.Clean = value; PersonIncomeFrequencyType = v180;
                var v181 = PersonMonthlyIncome; v181.Clean = value; PersonMonthlyIncome = v181;
                var v182 = PoaOccupancyIntent; v182.Clean = value; PoaOccupancyIntent = v182;
                var v183 = PoaSignatureText; v183.Clean = value; PoaSignatureText = v183;
                var v184 = PositiveCashFlow; v184.Clean = value; PositiveCashFlow = v184;
                var v185 = PowerOfAttorneyName; v185.Clean = value; PowerOfAttorneyName = v185;
                var v186 = PowerOfAttorneyTitleDescription; v186.Clean = value; PowerOfAttorneyTitleDescription = v186;
                var v187 = PresentlyDelinquentIndicator; v187.Clean = value; PresentlyDelinquentIndicator = v187;
                var v188 = PriorBankruptcy2; v188.Clean = value; PriorBankruptcy2 = v188;
                var v189 = PriorForeclosure; v189.Clean = value; PriorForeclosure = v189;
                var v190 = PriorPropertyTitleType; v190.Clean = value; PriorPropertyTitleType = v190;
                var v191 = PriorPropertyUsageType; v191.Clean = value; PriorPropertyUsageType = v191;
                var v192 = PropertyForeclosedPastSevenYearsIndicator; v192.Clean = value; PropertyForeclosedPastSevenYearsIndicator = v192;
                var v193 = RelationshipDescription; v193.Clean = value; RelationshipDescription = v193;
                var v194 = RelationshipWithRDEmployeeIndicator; v194.Clean = value; RelationshipWithRDEmployeeIndicator = v194;
                var v195 = SchoolingTermYears; v195.Clean = value; SchoolingTermYears = v195;
                var v196 = SSA89BackgroundCheckIndicator; v196.Clean = value; SSA89BackgroundCheckIndicator = v196;
                var v197 = SSA89BankingServiceIndicator; v197.Clean = value; SSA89BankingServiceIndicator = v197;
                var v198 = SSA89CreditCheckIndicator; v198.Clean = value; SSA89CreditCheckIndicator = v198;
                var v199 = SSA89LicenseRequirementIndicator; v199.Clean = value; SSA89LicenseRequirementIndicator = v199;
                var v200 = SSA89MortgageServiceIndicator; v200.Clean = value; SSA89MortgageServiceIndicator = v200;
                var v201 = SSA89OtherIndicator; v201.Clean = value; SSA89OtherIndicator = v201;
                var v202 = SubtotalLiquidAssetsMinusGiftAmount; v202.Clean = value; SubtotalLiquidAssetsMinusGiftAmount = v202;
                var v203 = SuffixToName; v203.Clean = value; SuffixToName = v203;
                var v204 = Tax4506LastInvestor; v204.Clean = value; Tax4506LastInvestor = v204;
                var v205 = Tax4506LastOrderNumber; v205.Clean = value; Tax4506LastOrderNumber = v205;
                var v206 = Tax4506LastOrderYear1; v206.Clean = value; Tax4506LastOrderYear1 = v206;
                var v207 = Tax4506LastOrderYear2; v207.Clean = value; Tax4506LastOrderYear2 = v207;
                var v208 = Tax4506LastOrderYear3; v208.Clean = value; Tax4506LastOrderYear3 = v208;
                var v209 = Tax4506LastOrderYear4; v209.Clean = value; Tax4506LastOrderYear4 = v209;
                var v210 = Tax4506LastProductsOrdered; v210.Clean = value; Tax4506LastProductsOrdered = v210;
                var v211 = Tax4506LastStatus; v211.Clean = value; Tax4506LastStatus = v211;
                var v212 = Tax4506LastTranscriptType; v212.Clean = value; Tax4506LastTranscriptType = v212;
                var v213 = Tax4506LastUserIDWhoOrdered; v213.Clean = value; Tax4506LastUserIDWhoOrdered = v213;
                var v214 = Tax4506TotalYearlyIncome1; v214.Clean = value; Tax4506TotalYearlyIncome1 = v214;
                var v215 = Tax4506TotalYearlyIncome2; v215.Clean = value; Tax4506TotalYearlyIncome2 = v215;
                var v216 = Tax4506TotalYearlyIncome3; v216.Clean = value; Tax4506TotalYearlyIncome3 = v216;
                var v217 = Tax4506TotalYearlyIncome4; v217.Clean = value; Tax4506TotalYearlyIncome4 = v217;
                var v218 = Tax4506TotalYearlyJointIncome1; v218.Clean = value; Tax4506TotalYearlyJointIncome1 = v218;
                var v219 = Tax4506TotalYearlyJointIncome2; v219.Clean = value; Tax4506TotalYearlyJointIncome2 = v219;
                var v220 = Tax4506TotalYearlyJointIncome3; v220.Clean = value; Tax4506TotalYearlyJointIncome3 = v220;
                var v221 = Tax4506TotalYearlyJointIncome4; v221.Clean = value; Tax4506TotalYearlyJointIncome4 = v221;
                var v222 = Tax4506TotalYearlyVarianceIncome1; v222.Clean = value; Tax4506TotalYearlyVarianceIncome1 = v222;
                var v223 = Tax4506TotalYearlyVarianceIncome2; v223.Clean = value; Tax4506TotalYearlyVarianceIncome2 = v223;
                var v224 = Tax4506TotalYearlyVarianceIncome3; v224.Clean = value; Tax4506TotalYearlyVarianceIncome3 = v224;
                var v225 = Tax4506TotalYearlyVarianceIncome4; v225.Clean = value; Tax4506TotalYearlyVarianceIncome4 = v225;
                var v226 = Tax4506TotalYearlyVarianceJointIncome1; v226.Clean = value; Tax4506TotalYearlyVarianceJointIncome1 = v226;
                var v227 = Tax4506TotalYearlyVarianceJointIncome2; v227.Clean = value; Tax4506TotalYearlyVarianceJointIncome2 = v227;
                var v228 = Tax4506TotalYearlyVarianceJointIncome3; v228.Clean = value; Tax4506TotalYearlyVarianceJointIncome3 = v228;
                var v229 = Tax4506TotalYearlyVarianceJointIncome4; v229.Clean = value; Tax4506TotalYearlyVarianceJointIncome4 = v229;
                var v230 = TaxIdentificationIdentifier; v230.Clean = value; TaxIdentificationIdentifier = v230;
                var v231 = TotalLiabilitiesBalanceAmount; v231.Clean = value; TotalLiabilitiesBalanceAmount = v231;
                var v232 = TotalMonthlyIncomeAmount; v232.Clean = value; TotalMonthlyIncomeAmount = v232;
                var v233 = TotalMonthlyIncomeMinusNetRentalAmount; v233.Clean = value; TotalMonthlyIncomeMinusNetRentalAmount = v233;
                var v234 = TotalPresentHousingExpenseAmount; v234.Clean = value; TotalPresentHousingExpenseAmount = v234;
                var v235 = TransactionPurposeDescription; v235.Clean = value; TransactionPurposeDescription = v235;
                var v236 = TransUnion120Days; v236.Clean = value; TransUnion120Days = v236;
                var v237 = TransUnion150Days; v237.Clean = value; TransUnion150Days = v237;
                var v238 = TransUnion30Days; v238.Clean = value; TransUnion30Days = v238;
                var v239 = TransUnion60Days; v239.Clean = value; TransUnion60Days = v239;
                var v240 = TransUnion90Days; v240.Clean = value; TransUnion90Days = v240;
                var v241 = TransUnionCreditScoreForDisclosure; v241.Clean = value; TransUnionCreditScoreForDisclosure = v241;
                var v242 = TransUnionCreditScoreRanksPercent; v242.Clean = value; TransUnionCreditScoreRanksPercent = v242;
                var v243 = TransUnionDatePulled; v243.Clean = value; TransUnionDatePulled = v243;
                var v244 = TransUnionFactorCode1; v244.Clean = value; TransUnionFactorCode1 = v244;
                var v245 = TransUnionFactorCode2; v245.Clean = value; TransUnionFactorCode2 = v245;
                var v246 = TransUnionFactorCode3; v246.Clean = value; TransUnionFactorCode3 = v246;
                var v247 = TransUnionFactorCode4; v247.Clean = value; TransUnionFactorCode4 = v247;
                var v248 = TransUnionFactorCode5; v248.Clean = value; TransUnionFactorCode5 = v248;
                var v249 = TransUnionKeyFactor1; v249.Clean = value; TransUnionKeyFactor1 = v249;
                var v250 = TransUnionKeyFactor2; v250.Clean = value; TransUnionKeyFactor2 = v250;
                var v251 = TransUnionKeyFactor3; v251.Clean = value; TransUnionKeyFactor3 = v251;
                var v252 = TransUnionKeyFactor4; v252.Clean = value; TransUnionKeyFactor4 = v252;
                var v253 = TransUnionKeyFactor5; v253.Clean = value; TransUnionKeyFactor5 = v253;
                var v254 = TransUnionMaterialTermsCreditByScore; v254.Clean = value; TransUnionMaterialTermsCreditByScore = v254;
                var v255 = TransUnionScore; v255.Clean = value; TransUnionScore = v255;
                var v256 = UserDefinedIncome; v256.Clean = value; UserDefinedIncome = v256;
                var v257 = VaFederalTaxAmount; v257.Clean = value; VaFederalTaxAmount = v257;
                var v258 = ValidDaysForConsentCount; v258.Clean = value; ValidDaysForConsentCount = v258;
                var v259 = VaNetTakeHomePayAmount; v259.Clean = value; VaNetTakeHomePayAmount = v259;
                var v260 = VaOtherAmount; v260.Clean = value; VaOtherAmount = v260;
                var v261 = VaOtherNetIncomeAmount; v261.Clean = value; VaOtherNetIncomeAmount = v261;
                var v262 = VaRetirementAmount; v262.Clean = value; VaRetirementAmount = v262;
                var v263 = VaStateTaxAmount; v263.Clean = value; VaStateTaxAmount = v263;
                var v264 = VaTotalIncomeDeductionsAmount; v264.Clean = value; VaTotalIncomeDeductionsAmount = v264;
                var v265 = VaTotalNetIncomeAmount; v265.Clean = value; VaTotalNetIncomeAmount = v265;
                var v266 = Vendor1; v266.Clean = value; Vendor1 = v266;
                var v267 = Vendor10; v267.Clean = value; Vendor10 = v267;
                var v268 = Vendor11; v268.Clean = value; Vendor11 = v268;
                var v269 = Vendor12; v269.Clean = value; Vendor12 = v269;
                var v270 = Vendor2; v270.Clean = value; Vendor2 = v270;
                var v271 = Vendor3; v271.Clean = value; Vendor3 = v271;
                var v272 = Vendor4; v272.Clean = value; Vendor4 = v272;
                var v273 = Vendor5; v273.Clean = value; Vendor5 = v273;
                var v274 = Vendor6; v274.Clean = value; Vendor6 = v274;
                var v275 = Vendor7; v275.Clean = value; Vendor7 = v275;
                var v276 = Vendor8; v276.Clean = value; Vendor8 = v276;
                var v277 = Vendor9; v277.Clean = value; Vendor9 = v277;
                var v278 = VestingTrusteeOfType; v278.Clean = value; VestingTrusteeOfType = v278;
                var v279 = VeteranIndicator; v279.Clean = value; VeteranIndicator = v279;
                var v280 = WorkEmailAddress; v280.Clean = value; WorkEmailAddress = v280;
                var v281 = YearsofCreditOnFile; v281.Clean = value; YearsofCreditOnFile = v281;
                if (Application != null) Application.Clean = value;
                _settingClean = 0;
            }
        }
    }
}