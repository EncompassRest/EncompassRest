using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Borrower
    /// </summary>
    public sealed partial class Borrower : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _acountChekAssetId;
        private DirtyValue<bool?>? _activeDuty;
        private DirtyValue<bool?>? _additionalEmploymentDoesNotApply;
        private DirtyValue<decimal?>? _additionalIncomeFromPrimaryEmployment;
        private DirtyValue<string?>? _additionalInformation;
        private DirtyValue<decimal?>? _additionalOtherIncome;
        private DirtyValue<decimal?>? _adjustedAnnualIncome;
        private DirtyValue<int?>? _ageAtApplicationYearsCount;
        private DirtyValue<string?>? _aliasName;
        private DirtyValue<bool?>? _alimonyChildSupportObligationIndicator;
        private DirtyValue<string?>? _altId;
        private DirtyValue<decimal?>? _annualIncome;
        private DirtyValue<string?>? _applicantType;
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>>? _applicationTakenMethodType;
        private DirtyValue<decimal?>? _assetIncome;
        private DirtyValue<string?>? _assetRepAndWarrantyMessage;
        private DirtyValue<bool?>? _assetRepAndWarrantyReliefAvailable;
        private DirtyValue<bool?>? _authorizedCreditReportIndicator;
        private DirtyValue<bool?>? _authorizedToSignIndicator;
        private DirtyValue<string?>? _bankAccountNumber;
        private DirtyValue<StringEnumValue<BankAccountType>>? _bankAccountType;
        private DirtyValue<string?>? _bankContactAddress;
        private DirtyValue<string?>? _bankContactCity;
        private DirtyValue<string?>? _bankContactName;
        private DirtyValue<string?>? _bankContactPostalCode;
        private DirtyValue<StringEnumValue<State>>? _bankContactState;
        private DirtyValue<bool?>? _bankruptcyIndicator;
        private DirtyValue<bool?>? _bankruptcyIndicatorChapterEleven;
        private DirtyValue<bool?>? _bankruptcyIndicatorChapterSeven;
        private DirtyValue<bool?>? _bankruptcyIndicatorChapterThirteen;
        private DirtyValue<bool?>? _bankruptcyIndicatorChapterTwelve;
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>>? _bankruptcyStatus;
        private DirtyValue<decimal?>? _baseIncome;
        private DirtyValue<string?>? _baseIncomeValidationMessage;
        private DirtyValue<decimal?>? _baseMonthlyIncomeAmount;
        private DirtyValue<DateTime?>? _birthDate;
        private DirtyValue<string?>? _bonusValidationMessage;
        private DirtyValue<bool?>? _borrowedDownPaymentIndicator;
        private DirtyValue<DateTime?>? _borrowerConsentRequestDate;
        private DirtyValue<int?>? _borrowerIndex;
        private DirtyValue<StringEnumValue<BorrowerType>>? _borrowerType;
        private DirtyValue<StringEnumValue<BorrowerType>>? _borrowerTypeInSummary;
        private DirtyValue<string?>? _caivrsIdentifier;
        private DirtyValue<string?>? _cdDeliveryMethod;
        private DirtyValue<string?>? _citizenshipResidencyType;
        private DirtyValue<bool?>? _coBorrAttendedSameCounselingIndicator;
        private DirtyValue<bool?>? _coMakerEndorserOfNoteIndicator;
        private DirtyValue<string?>? _commentOfCreditReport;
        private DirtyValue<string?>? _commissionValidationMessage;
        private DirtyValue<bool?>? _confirmedCRBKEC;
        private DirtyValue<bool?>? _confirmedCRBKIncorrect;
        private DirtyValue<bool?>? _confirmedCRDIL;
        private DirtyValue<bool?>? _confirmedCRFCEC;
        private DirtyValue<bool?>? _confirmedCRFCIncorrect;
        private DirtyValue<bool?>? _confirmedCRPFS;
        private DirtyValue<bool?>? _confirmedMtgDelIncorrect;
        private DirtyValue<bool?>? _confirmedOther;
        private DirtyValue<string?>? _confirmedOtherDescription;
        private DirtyValue<EntityReference?>? _contact;
        private DirtyValue<string?>? _counselingConfirmationType;
        private DirtyValue<string?>? _counselingConfirmationTypeDescription;
        private DirtyValue<string?>? _counselingFormatTypeDescription;
        private DirtyValue<bool?>? _creditCounseling;
        private DirtyValue<DateTime?>? _creditReceivedDate;
        private DirtyValue<StringEnumValue<CreditReportAuthorizationMethod>>? _creditReportAuthorizationMethod;
        private DirtyList<CreditReport>? _creditReports;
        private DirtyValue<bool?>? _creditScoreIndicator;
        private DirtyValue<bool?>? _currentEmploymentDoesNotApply;
        private DirtyValue<string?>? _dataVerify;
        private DirtyValue<DateTime?>? _dateAuthorizedCreditReport;
        private DirtyValue<DateTime?>? _dateOfBankruptcy;
        private DirtyValue<DateTime?>? _dateOfForeclosure;
        private DirtyValue<bool?>? _declarationsJIndicator;
        private DirtyValue<bool?>? _declarationsKIndicator;
        private DirtyValue<int?>? _dependentCount;
        private DirtyValue<string?>? _dependentsAgesDescription;
        private DirtyValue<bool?>? _disabledIndicator;
        private DirtyValue<StringEnumValue<DomesticRelationshipType>>? _domesticRelationshipType;
        private DirtyValue<bool?>? _dUVerificationEmploymentIncomeIndicator;
        private DirtyValue<string?>? _dUVerificationEmploymentIncomeMessage;
        private DirtyValue<string?>? _emailAddressText;
        private DirtyValue<bool?>? _employmentVerificationAvailable;
        private DirtyValue<string?>? _employmentVerificationMessage;
        private DirtyValue<int?>? _equifax120Days;
        private DirtyValue<int?>? _equifax150Days;
        private DirtyValue<int?>? _equifax30Days;
        private DirtyValue<int?>? _equifax60Days;
        private DirtyValue<int?>? _equifax90Days;
        private DirtyValue<bool?>? _equifaxCreditScoreForDisclosure;
        private DirtyValue<int?>? _equifaxCreditScoreRanksPercent;
        private DirtyValue<DateTime?>? _equifaxDatePulled;
        private DirtyValue<string?>? _equifaxFactorCode1;
        private DirtyValue<string?>? _equifaxFactorCode2;
        private DirtyValue<string?>? _equifaxFactorCode3;
        private DirtyValue<string?>? _equifaxFactorCode4;
        private DirtyValue<string?>? _equifaxFactorCode5;
        private DirtyValue<string?>? _equifaxKeyFactor1;
        private DirtyValue<string?>? _equifaxKeyFactor2;
        private DirtyValue<string?>? _equifaxKeyFactor3;
        private DirtyValue<string?>? _equifaxKeyFactor4;
        private DirtyValue<string?>? _equifaxKeyFactor5;
        private DirtyValue<bool?>? _equifaxMaterialTermsCreditByScore;
        private DirtyValue<string?>? _equifaxScore;
        private DirtyValue<int?>? _experian120Days;
        private DirtyValue<int?>? _experian150Days;
        private DirtyValue<int?>? _experian30Days;
        private DirtyValue<int?>? _experian60Days;
        private DirtyValue<int?>? _experian90Days;
        private DirtyValue<string?>? _experianCreditScore;
        private DirtyValue<bool?>? _experianCreditScoreForDisclosure;
        private DirtyValue<int?>? _experianCreditScoreRanksPercent;
        private DirtyValue<DateTime?>? _experianDatePulled;
        private DirtyValue<string?>? _experianFactorCode1;
        private DirtyValue<string?>? _experianFactorCode2;
        private DirtyValue<string?>? _experianFactorCode3;
        private DirtyValue<string?>? _experianFactorCode4;
        private DirtyValue<string?>? _experianFactorCode5;
        private DirtyValue<string?>? _experianKeyFactor1;
        private DirtyValue<string?>? _experianKeyFactor2;
        private DirtyValue<string?>? _experianKeyFactor3;
        private DirtyValue<string?>? _experianKeyFactor4;
        private DirtyValue<string?>? _experianKeyFactor5;
        private DirtyValue<bool?>? _experianMaterialTermsCreditByScore;
        private DirtyValue<string?>? _fannieFirstName;
        private DirtyValue<string?>? _fannieMiddleName;
        private DirtyValue<bool?>? _final1003Provided;
        private DirtyValue<string?>? _firstName;
        private DirtyValue<string?>? _firstNameWithMiddleName;
        private DirtyValue<bool?>? _firstTimeHomeBuyer;
        private DirtyValue<DateTime?>? _foreclosureSatisfied;
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>>? _foreclosureStatus;
        private DirtyValue<string?>? _freddieMacPerson1;
        private DirtyValue<string?>? _freddieMacPerson2;
        private DirtyValue<string?>? _fullName;
        private DirtyValue<string?>? _fullNameWithSuffix;
        private DirtyValue<bool?>? _giftsAndGrantsIndicatorBor;
        private DirtyValue<decimal?>? _highestCreditLimit;
        private DirtyValue<string?>? _hmda2003OtherRaceNationalOriginDescription;
        private DirtyValue<StringEnumValue<Hmda2003RaceNationalOriginType>>? _hmda2003RaceNationalOriginType;
        private DirtyValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>>? _hmda2CreditScoreForDecisionMaking;
        private DirtyValue<StringEnumValue<HmdaCreditScoringModel>>? _hmda2CreditScoringModel;
        private DirtyValue<bool?>? _hmdaAfricanAmericanIndicator;
        private DirtyValue<StringEnumValue<HmdaAge>>? _hmdaAge;
        private DirtyValue<bool?>? _hmdaAmericanIndianIndicator;
        private DirtyValue<string?>? _hmdaAmericanIndianTribe;
        private DirtyValue<bool?>? _hmdaAsianIndianIndicator;
        private DirtyValue<bool?>? _hmdaAsianIndicator;
        private DirtyValue<bool?>? _hmdaAsianOtherRaceIndicator;
        private DirtyValue<bool?>? _hmdaChineseIndicator;
        private DirtyValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>>? _hmdaCreditScoreForDecisionMaking;
        private DirtyValue<StringEnumValue<HmdaCreditScoringModel>>? _hmdaCreditScoringModel;
        private DirtyValue<bool?>? _hmdaCubanIndicator;
        private DirtyValue<bool?>? _hmdaEthnicityDoNotWishIndicator;
        private DirtyValue<bool?>? _hmdaEthnicityHispanicLatinoIndicator;
        private DirtyValue<bool?>? _hmdaEthnicityInfoNotProvided;
        private DirtyValue<bool?>? _hmdaEthnicityNotApplicableIndicator;
        private DirtyValue<bool?>? _hmdaEthnicityNotHispanicLatinoIndicator;
        private DirtyValue<string?>? _hmdaEthnicityReportedField1;
        private DirtyValue<string?>? _hmdaEthnicityReportedField2;
        private DirtyValue<string?>? _hmdaEthnicityReportedField3;
        private DirtyValue<string?>? _hmdaEthnicityReportedField4;
        private DirtyValue<string?>? _hmdaEthnicityReportedField5;
        private DirtyValue<string?>? _hmdaEthnicityReportedFields;
        private DirtyValue<StringEnumValue<HmdaEthnicityType>>? _hmdaEthnicityType;
        private DirtyValue<bool?>? _hmdaFilipinoIndicator;
        private DirtyValue<StringEnumValue<HmdaGenderType>>? _hmdaGenderType;
        private DirtyValue<bool?>? _hmdaGendertypeDoNotWishIndicator;
        private DirtyValue<bool?>? _hmdaGendertypeFemaleIndicator;
        private DirtyValue<bool?>? _hmdaGendertypeMaleIndicator;
        private DirtyValue<bool?>? _hmdaGendertypeNotApplicableIndicator;
        private DirtyValue<bool?>? _hmdaGuamanianOrChamorroIndicator;
        private DirtyValue<bool?>? _hmdaHispanicLatinoOtherOriginIndicator;
        private DirtyValue<bool?>? _hmdaJapaneseIndicator;
        private DirtyValue<bool?>? _hmdaKoreanIndicator;
        private DirtyValue<bool?>? _hmdaMexicanIndicator;
        private DirtyValue<bool?>? _hmdaNativeHawaiianIndicator;
        private DirtyValue<bool?>? _hmdaNoCoApplicantIndicator;
        private DirtyValue<bool?>? _hmdaNotApplicableIndicator;
        private DirtyValue<bool?>? _hmdaNotProvidedIndicator;
        private DirtyValue<string?>? _hmdaOtherAsianRace;
        private DirtyValue<string?>? _hmdaOtherHispanicLatinoOrigin;
        private DirtyValue<string?>? _hmdaOtherPacificIslanderRace;
        private DirtyValue<string?>? _hmdaOtherScoringModel;
        private DirtyValue<bool?>? _hmdaPacificIslanderIndicator;
        private DirtyValue<bool?>? _hmdaPacificIslanderOtherIndicator;
        private DirtyValue<bool?>? _hmdaPuertoRicanIndicator;
        private DirtyValue<bool?>? _hmdaRaceDoNotWishProvideIndicator;
        private DirtyValue<bool?>? _hmdaRaceInfoNotProvided;
        private DirtyValue<string?>? _hmdaRaceReportedField1;
        private DirtyValue<string?>? _hmdaRaceReportedField2;
        private DirtyValue<string?>? _hmdaRaceReportedField3;
        private DirtyValue<string?>? _hmdaRaceReportedField4;
        private DirtyValue<string?>? _hmdaRaceReportedField5;
        private DirtyValue<string?>? _hmdaRaceReportedFields;
        private DirtyValue<bool?>? _hmdaRefusalIndicator;
        private DirtyValue<bool?>? _hmdaSamoanIndicator;
        private DirtyValue<bool?>? _hmdaSexInfoNotProvided;
        private DirtyValue<bool?>? _hmdaVietnameseIndicator;
        private DirtyValue<bool?>? _hmdaWhiteIndicator;
        private DirtyValue<string?>? _homeCounselingAgencyName;
        private DirtyValue<DateTime?>? _homeCounselingCompletionDate;
        private DirtyValue<bool?>? _homeownerPastThreeYearsIndicator;
        private DirtyValue<string?>? _homePhoneNumber;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _incomeRepAndWarrantyMessage;
        private DirtyValue<bool?>? _incomeRepAndWarrantyReliefAvailable;
        private DirtyValue<bool?>? _initial1003Provided;
        private DirtyValue<bool?>? _intentToOccupyIndicator;
        private DirtyValue<string?>? _intuitReportId;
        private DirtyValue<bool?>? _isBaseIncomeAvailable;
        private DirtyValue<bool?>? _isBonusAvailable;
        private DirtyValue<bool?>? _isBorrower;
        private DirtyValue<bool?>? _isCommissionAvailable;
        private DirtyValue<StringEnumValue<YNOrNA>>? _isEthnicityBasedOnVisual;
        private DirtyValue<bool?>? _isOvertimeAvailable;
        private DirtyValue<StringEnumValue<YNOrNA>>? _isRaceBasedOnVisual;
        private DirtyValue<bool?>? _isSelfEmployed;
        private DirtyValue<StringEnumValue<YNOrNA>>? _isSexBasedOnVisual;
        private DirtyValue<bool?>? _isSocialSecurityAvailable;
        private DirtyValue<bool?>? _isTaxReturnAvailable;
        private DirtyValue<StringEnumValue<JointAssetLiabilityReportingIndicator>>? _jointAssetLiabilityReportingIndicator;
        private DirtyValue<StringEnumValue<JointAssetLiabilityReportingIndicator>>? _jointAssetLiabilityReportingIndicator1;
        private DirtyValue<string?>? _languageCodeOtherDescription;
        private DirtyValue<StringEnumValue<LanguagePreference>>? _languagePreference;
        private DirtyValue<string?>? _lastName;
        private DirtyValue<string?>? _lastNameWithSuffix;
        private DirtyValue<bool?>? _leaveAndEarningsStatement;
        private DirtyValue<string?>? _leDeliveryMethod;
        private DirtyValue<bool?>? _legalOtherThanSpouse;
        private DirtyValue<bool?>? _liabilitiesDoesNotApply;
        private DirtyValue<bool?>? _loanForeclosureOrJudgementIndicator;
        private DirtyValue<string?>? _lpdGsa;
        private DirtyValue<bool?>? _mailingAddressSameAsPresentIndicator;
        private DirtyValue<StringEnumValue<MaritalStatusType>>? _maritalStatusType;
        private DirtyValue<int?>? _middleCreditScore;
        private DirtyValue<string?>? _middleFicoScore;
        private DirtyValue<string?>? _middleName;
        private DirtyValue<DateTime?>? _militaryServiceExpectedCompletionDate;
        private DirtyValue<string?>? _minFicoScore;
        private DirtyValue<string?>? _mobilePhone;
        private DirtyValue<bool?>? _mortgageOnCredit;
        private DirtyValue<string?>? _nameToObtainLoanFromRHS;
        private DirtyValue<string?>? _nearestRelativeAddress;
        private DirtyValue<string?>? _nearestRelativeCity;
        private DirtyValue<string?>? _nearestRelativeCountry;
        private DirtyValue<bool?>? _nearestRelativeForeignAddressIndicator;
        private DirtyValue<string?>? _nearestRelativeName;
        private DirtyValue<string?>? _nearestRelativePhone;
        private DirtyValue<string?>? _nearestRelativePostalCode;
        private DirtyValue<string?>? _nearestRelativeRelationship;
        private DirtyValue<StringEnumValue<State>>? _nearestRelativeState;
        private DirtyValue<decimal?>? _netRentalIncome;
        private DirtyValue<bool?>? _no3rdPartyEmailIndicator;
        private DirtyValue<bool?>? _noCoApplicantEthnicityIndicator;
        private DirtyValue<bool?>? _noCoApplicantIndicator;
        private DirtyValue<bool?>? _noCoApplicantSexIndicator;
        private DirtyValue<int?>? _numberofTradelines;
        private DirtyValue<bool?>? _obtainLoanFromRHSIndicator;
        private DirtyValue<StringEnumValue<OpenBankruptcy>>? _openBankruptcy2;
        private DirtyValue<bool?>? _otherAssetsDoesNotApply;
        private DirtyValue<bool?>? _otherLiabilitiesDoesNotApply;
        private DirtyValue<decimal?>? _otherMonthlyIncomeAmount;
        private DirtyValue<string?>? _otherRelationshipTypeDescription;
        private DirtyValue<bool?>? _otherSrcIncomeDoesNotApply;
        private DirtyValue<decimal?>? _otherSumAmount;
        private DirtyValue<bool?>? _outstandingJudgementsIndicator;
        private DirtyValue<string?>? _overtimeValidationMessage;
        private DirtyValue<bool?>? _ownershipConfirmationIndicator;
        private DirtyValue<StringEnumValue<OwnershipFormatType>>? _ownershipFormatType;
        private DirtyValue<string?>? _ownershipPartyRoleIdentifier;
        private DirtyValue<bool?>? _partyToLawsuitIndicator;
        private DirtyValue<bool?>? _partyToLawsuitIndicatorURLA;
        private DirtyValue<int?>? _pass120Days;
        private DirtyValue<int?>? _pass150Days;
        private DirtyValue<int?>? _pass30Days;
        private DirtyValue<int?>? _pass60Days;
        private DirtyValue<int?>? _pass90Days;
        private DirtyValue<string?>? _pensionRetireIncomeMessage;
        private DirtyValue<string?>? _personFaxNumber;
        private DirtyValue<decimal?>? _personHoursPerWeek;
        private DirtyValue<decimal?>? _personIncomeAmount;
        private DirtyValue<string?>? _personIncomeFrequencyType;
        private DirtyValue<decimal?>? _personMonthlyIncome;
        private DirtyValue<bool?>? _pIWAccepted;
        private DirtyValue<string?>? _pIWMessage;
        private DirtyValue<StringEnumValue<OccupancyIntent>>? _poaOccupancyIntent;
        private DirtyValue<string?>? _poaSignatureText;
        private DirtyValue<decimal?>? _positiveCashFlow;
        private DirtyValue<string?>? _powerOfAttorneyName;
        private DirtyValue<string?>? _powerOfAttorneyTitleDescription;
        private DirtyValue<bool?>? _presentlyDelinquentIndicator;
        private DirtyValue<bool?>? _presentlyDelinquentIndicatorURLA;
        private DirtyValue<bool?>? _previousEmploymentDoesNotApply;
        private DirtyValue<decimal?>? _previousGrossMonthlyIncome;
        private DirtyValue<bool?>? _printOnAdditionalBorrowerPage;
        private DirtyValue<DateTime?>? _priorBankruptcy2;
        private DirtyValue<bool?>? _priorForeclosure;
        private DirtyValue<bool?>? _priorPropertyDeedInLieuConveyedIndicator;
        private DirtyValue<bool?>? _priorPropertyForeclosureCompletedIndicator;
        private DirtyValue<bool?>? _priorPropertyShortSaleCompletedIndicator;
        private DirtyValue<StringEnumValue<PriorPropertyTitleType>>? _priorPropertyTitleType;
        private DirtyValue<StringEnumValue<PriorPropertyUsageType>>? _priorPropertyUsageType;
        private DirtyValue<bool?>? _priorResidenceDoesNotApply;
        private DirtyValue<bool?>? _propertyForeclosedPastSevenYearsIndicator;
        private DirtyValue<bool?>? _propertyProposedCleanEnergyLienIndicator;
        private DirtyValue<bool?>? _realEstateDoesNotApply;
        private DirtyValue<string?>? _relationshipDescription;
        private DirtyValue<bool?>? _relationshipWithRDEmployeeIndicator;
        private DirtyValue<bool?>? _reserveNationalGuardReserveActivated;
        private DirtyValue<bool?>? _retirementPensionIncomeAvailable;
        private DirtyValue<int?>? _schoolingTermYears;
        private DirtyValue<string?>? _sectionAExplanation;
        private DirtyValue<bool?>? _sectionAPrintExplanation;
        private DirtyValue<string?>? _sectionBExplanation;
        private DirtyValue<bool?>? _sectionBPrintExplanation;
        private DirtyValue<string?>? _sectionCExplanation;
        private DirtyValue<bool?>? _sectionCPrintExplanation;
        private DirtyValue<bool?>? _sectionD1PrintExplanation;
        private DirtyValue<string?>? _sectionD2Explanation;
        private DirtyValue<bool?>? _sectionD2PrintExplanation;
        private DirtyValue<string?>? _sectionDExplanation;
        private DirtyValue<string?>? _sectionEExplanation;
        private DirtyValue<bool?>? _sectionEPrintExplanation;
        private DirtyValue<string?>? _sectionFExplanation;
        private DirtyValue<bool?>? _sectionFPrintExplanation;
        private DirtyValue<string?>? _sectionGExplanation;
        private DirtyValue<bool?>? _sectionGPrintExplanation;
        private DirtyValue<string?>? _sectionHExplanation;
        private DirtyValue<bool?>? _sectionHPrintExplanation;
        private DirtyValue<string?>? _sectionIExplanation;
        private DirtyValue<bool?>? _sectionIPrintExplanation;
        private DirtyValue<string?>? _sectionJExplanation;
        private DirtyValue<bool?>? _sectionJPrintExplanation;
        private DirtyValue<string?>? _sectionKExplanation;
        private DirtyValue<bool?>? _sectionKPrintExplanation;
        private DirtyValue<string?>? _sectionLExplanation;
        private DirtyValue<bool?>? _sectionLPrintExplanation;
        private DirtyValue<string?>? _sectionMExplanation;
        private DirtyValue<bool?>? _sectionMPrintExplanation;
        private DirtyValue<bool?>? _selfDeclaredMilitaryServiceIndicator;
        private DirtyValue<string?>? _selfEmployedValidationMessage;
        private DirtyValue<bool?>? _specialBorrowerSellerRelationshipIndicator;
        private DirtyValue<bool?>? _spousalVABenefitsEligibilityIndicator;
        private DirtyValue<bool?>? _sSA89BackgroundCheckIndicator;
        private DirtyValue<bool?>? _sSA89BankingServiceIndicator;
        private DirtyValue<bool?>? _sSA89CreditCheckIndicator;
        private DirtyValue<bool?>? _sSA89LicenseRequirementIndicator;
        private DirtyValue<bool?>? _sSA89MortgageServiceIndicator;
        private DirtyValue<bool?>? _sSA89OtherIndicator;
        private DirtyValue<string?>? _sSNValidationMessage;
        private DirtyValue<StringEnumValue<State>>? _state;
        private DirtyValue<decimal?>? _subtotalLiquidAssetsMinusGiftAmount;
        private DirtyValue<string?>? _suffixToName;
        private DirtyValue<string?>? _tax4506LastInvestor;
        private DirtyValue<string?>? _tax4506LastOrderNumber;
        private DirtyValue<int?>? _tax4506LastOrderYear1;
        private DirtyValue<int?>? _tax4506LastOrderYear2;
        private DirtyValue<int?>? _tax4506LastOrderYear3;
        private DirtyValue<int?>? _tax4506LastOrderYear4;
        private DirtyValue<string?>? _tax4506LastProductsOrdered;
        private DirtyValue<string?>? _tax4506LastStatus;
        private DirtyValue<string?>? _tax4506LastTranscriptType;
        private DirtyValue<string?>? _tax4506LastUserIDWhoOrdered;
        private DirtyValue<decimal?>? _tax4506TotalYearlyIncome1;
        private DirtyValue<decimal?>? _tax4506TotalYearlyIncome2;
        private DirtyValue<decimal?>? _tax4506TotalYearlyIncome3;
        private DirtyValue<decimal?>? _tax4506TotalYearlyIncome4;
        private DirtyValue<decimal?>? _tax4506TotalYearlyJointIncome1;
        private DirtyValue<decimal?>? _tax4506TotalYearlyJointIncome2;
        private DirtyValue<decimal?>? _tax4506TotalYearlyJointIncome3;
        private DirtyValue<decimal?>? _tax4506TotalYearlyJointIncome4;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceIncome1;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceIncome2;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceIncome3;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceIncome4;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceJointIncome1;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceJointIncome2;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceJointIncome3;
        private DirtyValue<decimal?>? _tax4506TotalYearlyVarianceJointIncome4;
        private DirtyValue<string?>? _taxIdentificationIdentifier;
        private DirtyValue<string?>? _taxReturnValidationMessage;
        private DirtyValue<decimal?>? _totalAdditionalLiabilitiesAmount;
        private DirtyValue<decimal?>? _totalAdditionalOtherLiabilitiesAmount;
        private DirtyValue<decimal?>? _totalAnnualIncome;
        private DirtyValue<decimal?>? _totalAssets;
        private DirtyValue<decimal?>? _totalGrossMonthlySalary;
        private DirtyValue<decimal?>? _totalLiabilitiesAmount;
        private DirtyValue<decimal?>? _totalLiabilitiesBalanceAmount;
        private DirtyValue<decimal?>? _totalMonthlyIncomeAmount;
        private DirtyValue<decimal?>? _totalMonthlyIncomeMinusNetRentalAmount;
        private DirtyValue<decimal?>? _totalOtherAssets;
        private DirtyValue<decimal?>? _totalOtherIncome;
        private DirtyValue<decimal?>? _totalOtherLiabilities;
        private DirtyValue<decimal?>? _totalOtherLiabilitiesAmount;
        private DirtyValue<decimal?>? _totalOtherMonthlyLiability;
        private DirtyValue<decimal?>? _totalPresentHousingExpenseAmount;
        private DirtyValue<string?>? _transactionPurposeDescription;
        private DirtyValue<int?>? _transUnion120Days;
        private DirtyValue<int?>? _transUnion150Days;
        private DirtyValue<int?>? _transUnion30Days;
        private DirtyValue<int?>? _transUnion60Days;
        private DirtyValue<int?>? _transUnion90Days;
        private DirtyValue<bool?>? _transUnionCreditScoreForDisclosure;
        private DirtyValue<int?>? _transUnionCreditScoreRanksPercent;
        private DirtyValue<DateTime?>? _transUnionDatePulled;
        private DirtyValue<string?>? _transUnionFactorCode1;
        private DirtyValue<string?>? _transUnionFactorCode2;
        private DirtyValue<string?>? _transUnionFactorCode3;
        private DirtyValue<string?>? _transUnionFactorCode4;
        private DirtyValue<string?>? _transUnionFactorCode5;
        private DirtyValue<string?>? _transUnionKeyFactor1;
        private DirtyValue<string?>? _transUnionKeyFactor2;
        private DirtyValue<string?>? _transUnionKeyFactor3;
        private DirtyValue<string?>? _transUnionKeyFactor4;
        private DirtyValue<string?>? _transUnionKeyFactor5;
        private DirtyValue<bool?>? _transUnionMaterialTermsCreditByScore;
        private DirtyValue<string?>? _transUnionScore;
        private DirtyValue<decimal?>? _undisclosedBorrowedFundsAmount;
        private DirtyValue<bool?>? _undisclosedBorrowedFundsIndicator;
        private DirtyValue<bool?>? _undisclosedComakerOfNoteIndicator;
        private DirtyValue<bool?>? _undisclosedCreditApplicationIndicator;
        private DirtyValue<bool?>? _undisclosedMortgageApplicationIndicator;
        private DirtyValue<StringEnumValue<Urla2020CitizenshipResidencyType>>? _urla2020CitizenshipResidencyType;
        private DirtyValue<string?>? _urla2020CountryOfCitizenship;
        private DirtyValue<string?>? _uRLAAliasName;
        private DirtyValue<decimal?>? _userDefinedIncome;
        private DirtyValue<decimal?>? _vaFederalTaxAmount;
        private DirtyValue<int?>? _validDaysForConsentCount;
        private DirtyValue<bool?>? _valueRepAndWarrantyAvailable;
        private DirtyValue<string?>? _valueRepAndWarrantyMessage;
        private DirtyValue<decimal?>? _vaNetTakeHomePayAmount;
        private DirtyValue<decimal?>? _vaOtherAmount;
        private DirtyValue<decimal?>? _vaOtherNetIncomeAmount;
        private DirtyValue<decimal?>? _vaRetirementAmount;
        private DirtyValue<decimal?>? _vaStateTaxAmount;
        private DirtyValue<decimal?>? _vaTotalIncomeDeductionsAmount;
        private DirtyValue<decimal?>? _vaTotalNetIncomeAmount;
        private DirtyValue<string?>? _vendor1;
        private DirtyValue<string?>? _vendor10;
        private DirtyValue<string?>? _vendor11;
        private DirtyValue<string?>? _vendor12;
        private DirtyValue<string?>? _vendor13;
        private DirtyValue<string?>? _vendor14;
        private DirtyValue<string?>? _vendor15;
        private DirtyValue<string?>? _vendor16;
        private DirtyValue<string?>? _vendor17;
        private DirtyValue<string?>? _vendor18;
        private DirtyValue<string?>? _vendor19;
        private DirtyValue<string?>? _vendor2;
        private DirtyValue<string?>? _vendor20;
        private DirtyValue<string?>? _vendor21;
        private DirtyValue<string?>? _vendor22;
        private DirtyValue<string?>? _vendor23;
        private DirtyValue<string?>? _vendor24;
        private DirtyValue<string?>? _vendor25;
        private DirtyValue<string?>? _vendor26;
        private DirtyValue<string?>? _vendor27;
        private DirtyValue<string?>? _vendor28;
        private DirtyValue<string?>? _vendor29;
        private DirtyValue<string?>? _vendor3;
        private DirtyValue<string?>? _vendor30;
        private DirtyValue<string?>? _vendor31;
        private DirtyValue<string?>? _vendor32;
        private DirtyValue<string?>? _vendor33;
        private DirtyValue<string?>? _vendor34;
        private DirtyValue<string?>? _vendor35;
        private DirtyValue<string?>? _vendor36;
        private DirtyValue<string?>? _vendor37;
        private DirtyValue<string?>? _vendor38;
        private DirtyValue<string?>? _vendor39;
        private DirtyValue<string?>? _vendor4;
        private DirtyValue<string?>? _vendor40;
        private DirtyValue<string?>? _vendor5;
        private DirtyValue<string?>? _vendor6;
        private DirtyValue<string?>? _vendor7;
        private DirtyValue<string?>? _vendor8;
        private DirtyValue<string?>? _vendor9;
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>>? _vestingTrusteeOfType;
        private DirtyValue<bool?>? _veteran;
        private DirtyValue<bool?>? _veteranIndicator;
        private DirtyValue<DateTime?>? _vvoeWorkNumberDate;
        private DirtyValue<string?>? _workEmailAddress;
        private DirtyValue<string?>? _workPhoneNumber;
        private DirtyValue<int?>? _yearsofCreditOnFile;

        /// <summary>
        /// Borrower AcountChekAssetId
        /// </summary>
        public string? AcountChekAssetId { get => _acountChekAssetId; set => SetField(ref _acountChekAssetId, value); }

        /// <summary>
        /// Borrower ActiveDuty
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently serving on active duty\"}")]
        public bool? ActiveDuty { get => _activeDuty; set => SetField(ref _activeDuty, value); }

        /// <summary>
        /// Borrower AdditionalEmploymentDoesNotApply
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
        public bool? AdditionalEmploymentDoesNotApply { get => _additionalEmploymentDoesNotApply; set => SetField(ref _additionalEmploymentDoesNotApply, value); }

        /// <summary>
        /// USDA - Additional Income to Primary Employment (Commission, Bonus, Overtime, Automobile Allowance, Mortgage Differential, Tips, Military, Secondary Employment, Seasonal Employment, Unemployment) [USDA.X168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdditionalIncomeFromPrimaryEmployment { get => _additionalIncomeFromPrimaryEmployment; set => SetField(ref _additionalIncomeFromPrimaryEmployment, value); }

        /// <summary>
        /// Borrower AdditionalInformation
        /// </summary>
        public string? AdditionalInformation { get => _additionalInformation; set => SetField(ref _additionalInformation, value); }

        /// <summary>
        /// Borrower AdditionalOtherIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdditionalOtherIncome { get => _additionalOtherIncome; set => SetField(ref _additionalOtherIncome, value); }

        /// <summary>
        /// USDA - Adjusted Annual income for the household [USDA.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? AdjustedAnnualIncome { get => _adjustedAnnualIncome; set => SetField(ref _adjustedAnnualIncome, value); }

        /// <summary>
        /// Borrower AgeAtApplicationYearsCount
        /// </summary>
        public int? AgeAtApplicationYearsCount { get => _ageAtApplicationYearsCount; set => SetField(ref _ageAtApplicationYearsCount, value); }

        /// <summary>
        /// Borrower AliasName
        /// </summary>
        public string? AliasName { get => _aliasName; set => SetField(ref _aliasName, value); }

        /// <summary>
        /// Borrower AlimonyChildSupportObligationIndicator
        /// </summary>
        public bool? AlimonyChildSupportObligationIndicator { get => _alimonyChildSupportObligationIndicator; set => SetField(ref _alimonyChildSupportObligationIndicator, value); }

        /// <summary>
        /// Borrower AltId
        /// </summary>
        public string? AltId { get => _altId; set => SetField(ref _altId, value); }

        /// <summary>
        /// USDA - Annual income for the household [USDA.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? AnnualIncome { get => _annualIncome; set => SetField(ref _annualIncome, value); }

        /// <summary>
        /// Borrower ApplicantType
        /// </summary>
        public string? ApplicantType { get => _applicantType; set => SetField(ref _applicantType, value); }

        /// <summary>
        /// Borrower ApplicationTakenMethodType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"FaceToFace\":\"Face-to-Face Interview\"}")]
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => SetField(ref _applicationTakenMethodType, value); }

        /// <summary>
        /// USDA - Asset Income (Income from household assets as described in 1980.347(d) of RD Instruction 1980-D) [USDA.X170]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AssetIncome { get => _assetIncome; set => SetField(ref _assetIncome, value); }

        /// <summary>
        /// Borrower AssetRepAndWarrantyMessage
        /// </summary>
        public string? AssetRepAndWarrantyMessage { get => _assetRepAndWarrantyMessage; set => SetField(ref _assetRepAndWarrantyMessage, value); }

        /// <summary>
        /// Borrower AssetRepAndWarrantyReliefAvailable
        /// </summary>
        public bool? AssetRepAndWarrantyReliefAvailable { get => _assetRepAndWarrantyReliefAvailable; set => SetField(ref _assetRepAndWarrantyReliefAvailable, value); }

        /// <summary>
        /// Borrower AuthorizedCreditReportIndicator
        /// </summary>
        public bool? AuthorizedCreditReportIndicator { get => _authorizedCreditReportIndicator; set => SetField(ref _authorizedCreditReportIndicator, value); }

        /// <summary>
        /// Borrower AuthorizedToSignIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => SetField(ref _authorizedToSignIndicator, value); }

        /// <summary>
        /// Borrower BankAccountNumber
        /// </summary>
        public string? BankAccountNumber { get => _bankAccountNumber; set => SetField(ref _bankAccountNumber, value); }

        /// <summary>
        /// Borrower BankAccountType
        /// </summary>
        public StringEnumValue<BankAccountType> BankAccountType { get => _bankAccountType; set => SetField(ref _bankAccountType, value); }

        /// <summary>
        /// Borrower BankContactAddress
        /// </summary>
        public string? BankContactAddress { get => _bankContactAddress; set => SetField(ref _bankContactAddress, value); }

        /// <summary>
        /// Borrower BankContactCity
        /// </summary>
        public string? BankContactCity { get => _bankContactCity; set => SetField(ref _bankContactCity, value); }

        /// <summary>
        /// Borrower BankContactName
        /// </summary>
        public string? BankContactName { get => _bankContactName; set => SetField(ref _bankContactName, value); }

        /// <summary>
        /// Borrower BankContactPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? BankContactPostalCode { get => _bankContactPostalCode; set => SetField(ref _bankContactPostalCode, value); }

        /// <summary>
        /// Borrower BankContactState
        /// </summary>
        public StringEnumValue<State> BankContactState { get => _bankContactState; set => SetField(ref _bankContactState, value); }

        /// <summary>
        /// Borrower BankruptcyIndicator
        /// </summary>
        public bool? BankruptcyIndicator { get => _bankruptcyIndicator; set => SetField(ref _bankruptcyIndicator, value); }

        /// <summary>
        /// Borrower BankruptcyIndicatorChapterEleven
        /// </summary>
        public bool? BankruptcyIndicatorChapterEleven { get => _bankruptcyIndicatorChapterEleven; set => SetField(ref _bankruptcyIndicatorChapterEleven, value); }

        /// <summary>
        /// Borrower BankruptcyIndicatorChapterSeven
        /// </summary>
        public bool? BankruptcyIndicatorChapterSeven { get => _bankruptcyIndicatorChapterSeven; set => SetField(ref _bankruptcyIndicatorChapterSeven, value); }

        /// <summary>
        /// Borrower BankruptcyIndicatorChapterThirteen
        /// </summary>
        public bool? BankruptcyIndicatorChapterThirteen { get => _bankruptcyIndicatorChapterThirteen; set => SetField(ref _bankruptcyIndicatorChapterThirteen, value); }

        /// <summary>
        /// Borrower BankruptcyIndicatorChapterTwelve
        /// </summary>
        public bool? BankruptcyIndicatorChapterTwelve { get => _bankruptcyIndicatorChapterTwelve; set => SetField(ref _bankruptcyIndicatorChapterTwelve, value); }

        /// <summary>
        /// Underwriting Bankruptcy Status [2570]
        /// </summary>
        public StringEnumValue<BankruptcyForeclosureStatus> BankruptcyStatus { get => _bankruptcyStatus; set => SetField(ref _bankruptcyStatus, value); }

        /// <summary>
        /// Borrower BaseIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BaseIncome { get => _baseIncome; set => SetField(ref _baseIncome, value); }

        /// <summary>
        /// Borrower BaseIncomeValidationMessage
        /// </summary>
        public string? BaseIncomeValidationMessage { get => _baseIncomeValidationMessage; set => SetField(ref _baseIncomeValidationMessage, value); }

        /// <summary>
        /// Borrower BaseMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BaseMonthlyIncomeAmount { get => _baseMonthlyIncomeAmount; set => SetField(ref _baseMonthlyIncomeAmount, value); }

        /// <summary>
        /// Borrower BirthDate
        /// </summary>
        public DateTime? BirthDate { get => _birthDate; set => SetField(ref _birthDate, value); }

        /// <summary>
        /// Borrower BonusValidationMessage
        /// </summary>
        public string? BonusValidationMessage { get => _bonusValidationMessage; set => SetField(ref _bonusValidationMessage, value); }

        /// <summary>
        /// Borrower BorrowedDownPaymentIndicator
        /// </summary>
        public bool? BorrowedDownPaymentIndicator { get => _borrowedDownPaymentIndicator; set => SetField(ref _borrowedDownPaymentIndicator, value); }

        /// <summary>
        /// Borrower BorrowerConsentRequestDate
        /// </summary>
        public DateTime? BorrowerConsentRequestDate { get => _borrowerConsentRequestDate; set => SetField(ref _borrowerConsentRequestDate, value); }

        /// <summary>
        /// Borrower BorrowerIndex
        /// </summary>
        public int? BorrowerIndex { get => _borrowerIndex; set => SetField(ref _borrowerIndex, value); }

        /// <summary>
        /// Borrower BorrowerType
        /// </summary>
        public StringEnumValue<BorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

        /// <summary>
        /// Borrower BorrowerTypeInSummary
        /// </summary>
        public StringEnumValue<BorrowerType> BorrowerTypeInSummary { get => _borrowerTypeInSummary; set => SetField(ref _borrowerTypeInSummary, value); }

        /// <summary>
        /// Borrower CaivrsIdentifier
        /// </summary>
        public string? CaivrsIdentifier { get => _caivrsIdentifier; set => SetField(ref _caivrsIdentifier, value); }

        /// <summary>
        /// Borrower CdDeliveryMethod
        /// </summary>
        public string? CdDeliveryMethod { get => _cdDeliveryMethod; set => SetField(ref _cdDeliveryMethod, value); }

        /// <summary>
        /// Borrower CitizenshipResidencyType
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CitizenshipResidencyType { get => _citizenshipResidencyType; set => SetField(ref _citizenshipResidencyType, value); }

        /// <summary>
        /// CoBorrower Attended Same Counseling [URLA.X215]
        /// </summary>
        public bool? CoBorrAttendedSameCounselingIndicator { get => _coBorrAttendedSameCounselingIndicator; set => SetField(ref _coBorrAttendedSameCounselingIndicator, value); }

        /// <summary>
        /// Borrower CoMakerEndorserOfNoteIndicator
        /// </summary>
        public bool? CoMakerEndorserOfNoteIndicator { get => _coMakerEndorserOfNoteIndicator; set => SetField(ref _coMakerEndorserOfNoteIndicator, value); }

        /// <summary>
        /// Credit Report Comment [4079]
        /// </summary>
        public string? CommentOfCreditReport { get => _commentOfCreditReport; set => SetField(ref _commentOfCreditReport, value); }

        /// <summary>
        /// Borrower CommissionValidationMessage
        /// </summary>
        public string? CommissionValidationMessage { get => _commissionValidationMessage; set => SetField(ref _commissionValidationMessage, value); }

        /// <summary>
        /// Borrower ConfirmedCRBKEC
        /// </summary>
        public bool? ConfirmedCRBKEC { get => _confirmedCRBKEC; set => SetField(ref _confirmedCRBKEC, value); }

        /// <summary>
        /// Borrower ConfirmedCRBKIncorrect
        /// </summary>
        public bool? ConfirmedCRBKIncorrect { get => _confirmedCRBKIncorrect; set => SetField(ref _confirmedCRBKIncorrect, value); }

        /// <summary>
        /// Borrower ConfirmedCRDIL
        /// </summary>
        public bool? ConfirmedCRDIL { get => _confirmedCRDIL; set => SetField(ref _confirmedCRDIL, value); }

        /// <summary>
        /// Borrower ConfirmedCRFCEC
        /// </summary>
        public bool? ConfirmedCRFCEC { get => _confirmedCRFCEC; set => SetField(ref _confirmedCRFCEC, value); }

        /// <summary>
        /// Borrower ConfirmedCRFCIncorrect
        /// </summary>
        public bool? ConfirmedCRFCIncorrect { get => _confirmedCRFCIncorrect; set => SetField(ref _confirmedCRFCIncorrect, value); }

        /// <summary>
        /// Borrower ConfirmedCRPFS
        /// </summary>
        public bool? ConfirmedCRPFS { get => _confirmedCRPFS; set => SetField(ref _confirmedCRPFS, value); }

        /// <summary>
        /// Borrower ConfirmedMtgDelIncorrect
        /// </summary>
        public bool? ConfirmedMtgDelIncorrect { get => _confirmedMtgDelIncorrect; set => SetField(ref _confirmedMtgDelIncorrect, value); }

        /// <summary>
        /// Borrower ConfirmedOther
        /// </summary>
        public bool? ConfirmedOther { get => _confirmedOther; set => SetField(ref _confirmedOther, value); }

        /// <summary>
        /// Borrower ConfirmedOtherDescription
        /// </summary>
        public string? ConfirmedOtherDescription { get => _confirmedOtherDescription; set => SetField(ref _confirmedOtherDescription, value); }

        /// <summary>
        /// Borrower Contact
        /// </summary>
        public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

        /// <summary>
        /// Borrower CounselingConfirmationType
        /// </summary>
        public string? CounselingConfirmationType { get => _counselingConfirmationType; set => SetField(ref _counselingConfirmationType, value); }

        /// <summary>
        /// Borrower CounselingConfirmationTypeDescription
        /// </summary>
        public string? CounselingConfirmationTypeDescription { get => _counselingConfirmationTypeDescription; set => SetField(ref _counselingConfirmationTypeDescription, value); }

        /// <summary>
        /// Borrower CounselingFormatTypeDescription
        /// </summary>
        public string? CounselingFormatTypeDescription { get => _counselingFormatTypeDescription; set => SetField(ref _counselingFormatTypeDescription, value); }

        /// <summary>
        /// Underwriting Credit Counseling [2566]
        /// </summary>
        public bool? CreditCounseling { get => _creditCounseling; set => SetField(ref _creditCounseling, value); }

        /// <summary>
        /// Underwriting Credit Received Date [2336]
        /// </summary>
        public DateTime? CreditReceivedDate { get => _creditReceivedDate; set => SetField(ref _creditReceivedDate, value); }

        /// <summary>
        /// Borrower CreditReportAuthorizationMethod
        /// </summary>
        public StringEnumValue<CreditReportAuthorizationMethod> CreditReportAuthorizationMethod { get => _creditReportAuthorizationMethod; set => SetField(ref _creditReportAuthorizationMethod, value); }

        /// <summary>
        /// Borrower CreditReports
        /// </summary>
        [AllowNull]
        public IList<CreditReport> CreditReports { get => GetField(ref _creditReports); set => SetField(ref _creditReports, value); }

        /// <summary>
        /// Borrower CreditScoreIndicator
        /// </summary>
        public bool? CreditScoreIndicator { get => _creditScoreIndicator; set => SetField(ref _creditScoreIndicator, value); }

        /// <summary>
        /// Borrower CurrentEmploymentDoesNotApply
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
        public bool? CurrentEmploymentDoesNotApply { get => _currentEmploymentDoesNotApply; set => SetField(ref _currentEmploymentDoesNotApply, value); }

        /// <summary>
        /// GSE Vendor Provider Data - DataVerify [GSEVENDOR.X3]
        /// </summary>
        public string? DataVerify { get => _dataVerify; set => SetField(ref _dataVerify, value); }

        /// <summary>
        /// Borrower DateAuthorizedCreditReport
        /// </summary>
        public DateTime? DateAuthorizedCreditReport { get => _dateAuthorizedCreditReport; set => SetField(ref _dateAuthorizedCreditReport, value); }

        /// <summary>
        /// Underwriting Date of Bankruptcy [2340]
        /// </summary>
        public DateTime? DateOfBankruptcy { get => _dateOfBankruptcy; set => SetField(ref _dateOfBankruptcy, value); }

        /// <summary>
        /// Underwriting Date of Foreclosure [2341]
        /// </summary>
        public DateTime? DateOfForeclosure { get => _dateOfForeclosure; set => SetField(ref _dateOfForeclosure, value); }

        /// <summary>
        /// Borrower DeclarationsJIndicator
        /// </summary>
        public bool? DeclarationsJIndicator { get => _declarationsJIndicator; set => SetField(ref _declarationsJIndicator, value); }

        /// <summary>
        /// Borrower DeclarationsKIndicator
        /// </summary>
        public bool? DeclarationsKIndicator { get => _declarationsKIndicator; set => SetField(ref _declarationsKIndicator, value); }

        /// <summary>
        /// Borrower DependentCount
        /// </summary>
        public int? DependentCount { get => _dependentCount; set => SetField(ref _dependentCount, value); }

        /// <summary>
        /// Borrower DependentsAgesDescription
        /// </summary>
        public string? DependentsAgesDescription { get => _dependentsAgesDescription; set => SetField(ref _dependentsAgesDescription, value); }

        /// <summary>
        /// Borrower DisabledIndicator
        /// </summary>
        public bool? DisabledIndicator { get => _disabledIndicator; set => SetField(ref _disabledIndicator, value); }

        /// <summary>
        /// Borrower DomesticRelationshipType
        /// </summary>
        public StringEnumValue<DomesticRelationshipType> DomesticRelationshipType { get => _domesticRelationshipType; set => SetField(ref _domesticRelationshipType, value); }

        /// <summary>
        /// Borrower DUVerificationEmploymentIncomeIndicator
        /// </summary>
        public bool? DUVerificationEmploymentIncomeIndicator { get => _dUVerificationEmploymentIncomeIndicator; set => SetField(ref _dUVerificationEmploymentIncomeIndicator, value); }

        /// <summary>
        /// Borrower DUVerificationEmploymentIncomeMessage
        /// </summary>
        public string? DUVerificationEmploymentIncomeMessage { get => _dUVerificationEmploymentIncomeMessage; set => SetField(ref _dUVerificationEmploymentIncomeMessage, value); }

        /// <summary>
        /// Borrower EmailAddressText
        /// </summary>
        public string? EmailAddressText { get => _emailAddressText; set => SetField(ref _emailAddressText, value); }

        /// <summary>
        /// Borrower EmploymentVerificationAvailable
        /// </summary>
        public bool? EmploymentVerificationAvailable { get => _employmentVerificationAvailable; set => SetField(ref _employmentVerificationAvailable, value); }

        /// <summary>
        /// Borrower EmploymentVerificationMessage
        /// </summary>
        public string? EmploymentVerificationMessage { get => _employmentVerificationMessage; set => SetField(ref _employmentVerificationMessage, value); }

        /// <summary>
        /// Underwriting Equifax 120 Days [2335]
        /// </summary>
        public int? Equifax120Days { get => _equifax120Days; set => SetField(ref _equifax120Days, value); }

        /// <summary>
        /// Underwriting Equifax 150 Days [2557]
        /// </summary>
        public int? Equifax150Days { get => _equifax150Days; set => SetField(ref _equifax150Days, value); }

        /// <summary>
        /// Underwriting Equifax 30 Days [2332]
        /// </summary>
        public int? Equifax30Days { get => _equifax30Days; set => SetField(ref _equifax30Days, value); }

        /// <summary>
        /// Underwriting Equifax 60 Days [2333]
        /// </summary>
        public int? Equifax60Days { get => _equifax60Days; set => SetField(ref _equifax60Days, value); }

        /// <summary>
        /// Underwriting Equifax 90 Days [2334]
        /// </summary>
        public int? Equifax90Days { get => _equifax90Days; set => SetField(ref _equifax90Days, value); }

        /// <summary>
        /// Borrower EquifaxCreditScoreForDisclosure
        /// </summary>
        public bool? EquifaxCreditScoreForDisclosure { get => _equifaxCreditScoreForDisclosure; set => SetField(ref _equifaxCreditScoreForDisclosure, value); }

        /// <summary>
        /// Borrower EquifaxCreditScoreRanksPercent
        /// </summary>
        public int? EquifaxCreditScoreRanksPercent { get => _equifaxCreditScoreRanksPercent; set => SetField(ref _equifaxCreditScoreRanksPercent, value); }

        /// <summary>
        /// Borrower EquifaxDatePulled
        /// </summary>
        public DateTime? EquifaxDatePulled { get => _equifaxDatePulled; set => SetField(ref _equifaxDatePulled, value); }

        /// <summary>
        /// Borrower EquifaxFactorCode1
        /// </summary>
        public string? EquifaxFactorCode1 { get => _equifaxFactorCode1; set => SetField(ref _equifaxFactorCode1, value); }

        /// <summary>
        /// Borrower EquifaxFactorCode2
        /// </summary>
        public string? EquifaxFactorCode2 { get => _equifaxFactorCode2; set => SetField(ref _equifaxFactorCode2, value); }

        /// <summary>
        /// Borrower EquifaxFactorCode3
        /// </summary>
        public string? EquifaxFactorCode3 { get => _equifaxFactorCode3; set => SetField(ref _equifaxFactorCode3, value); }

        /// <summary>
        /// Borrower EquifaxFactorCode4
        /// </summary>
        public string? EquifaxFactorCode4 { get => _equifaxFactorCode4; set => SetField(ref _equifaxFactorCode4, value); }

        /// <summary>
        /// Borrower EquifaxFactorCode5
        /// </summary>
        public string? EquifaxFactorCode5 { get => _equifaxFactorCode5; set => SetField(ref _equifaxFactorCode5, value); }

        /// <summary>
        /// Borrower EquifaxKeyFactor1
        /// </summary>
        public string? EquifaxKeyFactor1 { get => _equifaxKeyFactor1; set => SetField(ref _equifaxKeyFactor1, value); }

        /// <summary>
        /// Borrower EquifaxKeyFactor2
        /// </summary>
        public string? EquifaxKeyFactor2 { get => _equifaxKeyFactor2; set => SetField(ref _equifaxKeyFactor2, value); }

        /// <summary>
        /// Borrower EquifaxKeyFactor3
        /// </summary>
        public string? EquifaxKeyFactor3 { get => _equifaxKeyFactor3; set => SetField(ref _equifaxKeyFactor3, value); }

        /// <summary>
        /// Borrower EquifaxKeyFactor4
        /// </summary>
        public string? EquifaxKeyFactor4 { get => _equifaxKeyFactor4; set => SetField(ref _equifaxKeyFactor4, value); }

        /// <summary>
        /// Borrower EquifaxKeyFactor5
        /// </summary>
        public string? EquifaxKeyFactor5 { get => _equifaxKeyFactor5; set => SetField(ref _equifaxKeyFactor5, value); }

        /// <summary>
        /// Borrower EquifaxMaterialTermsCreditByScore
        /// </summary>
        public bool? EquifaxMaterialTermsCreditByScore { get => _equifaxMaterialTermsCreditByScore; set => SetField(ref _equifaxMaterialTermsCreditByScore, value); }

        /// <summary>
        /// Borrower EquifaxScore
        /// </summary>
        public string? EquifaxScore { get => _equifaxScore; set => SetField(ref _equifaxScore, value); }

        /// <summary>
        /// Underwriting Experian 120 Days [2327]
        /// </summary>
        public int? Experian120Days { get => _experian120Days; set => SetField(ref _experian120Days, value); }

        /// <summary>
        /// Underwriting Experian 150 Days [2555]
        /// </summary>
        public int? Experian150Days { get => _experian150Days; set => SetField(ref _experian150Days, value); }

        /// <summary>
        /// Underwriting Experian 30 Days [2324]
        /// </summary>
        public int? Experian30Days { get => _experian30Days; set => SetField(ref _experian30Days, value); }

        /// <summary>
        /// Underwriting Experian 60 Days [2325]
        /// </summary>
        public int? Experian60Days { get => _experian60Days; set => SetField(ref _experian60Days, value); }

        /// <summary>
        /// Underwriting Experian 90 Days [2326]
        /// </summary>
        public int? Experian90Days { get => _experian90Days; set => SetField(ref _experian90Days, value); }

        /// <summary>
        /// Borrower ExperianCreditScore
        /// </summary>
        public string? ExperianCreditScore { get => _experianCreditScore; set => SetField(ref _experianCreditScore, value); }

        /// <summary>
        /// Borrower ExperianCreditScoreForDisclosure
        /// </summary>
        public bool? ExperianCreditScoreForDisclosure { get => _experianCreditScoreForDisclosure; set => SetField(ref _experianCreditScoreForDisclosure, value); }

        /// <summary>
        /// Borrower ExperianCreditScoreRanksPercent
        /// </summary>
        public int? ExperianCreditScoreRanksPercent { get => _experianCreditScoreRanksPercent; set => SetField(ref _experianCreditScoreRanksPercent, value); }

        /// <summary>
        /// Borrower ExperianDatePulled
        /// </summary>
        public DateTime? ExperianDatePulled { get => _experianDatePulled; set => SetField(ref _experianDatePulled, value); }

        /// <summary>
        /// Borrower ExperianFactorCode1
        /// </summary>
        public string? ExperianFactorCode1 { get => _experianFactorCode1; set => SetField(ref _experianFactorCode1, value); }

        /// <summary>
        /// Borrower ExperianFactorCode2
        /// </summary>
        public string? ExperianFactorCode2 { get => _experianFactorCode2; set => SetField(ref _experianFactorCode2, value); }

        /// <summary>
        /// Borrower ExperianFactorCode3
        /// </summary>
        public string? ExperianFactorCode3 { get => _experianFactorCode3; set => SetField(ref _experianFactorCode3, value); }

        /// <summary>
        /// Borrower ExperianFactorCode4
        /// </summary>
        public string? ExperianFactorCode4 { get => _experianFactorCode4; set => SetField(ref _experianFactorCode4, value); }

        /// <summary>
        /// Borrower ExperianFactorCode5
        /// </summary>
        public string? ExperianFactorCode5 { get => _experianFactorCode5; set => SetField(ref _experianFactorCode5, value); }

        /// <summary>
        /// Borrower ExperianKeyFactor1
        /// </summary>
        public string? ExperianKeyFactor1 { get => _experianKeyFactor1; set => SetField(ref _experianKeyFactor1, value); }

        /// <summary>
        /// Borrower ExperianKeyFactor2
        /// </summary>
        public string? ExperianKeyFactor2 { get => _experianKeyFactor2; set => SetField(ref _experianKeyFactor2, value); }

        /// <summary>
        /// Borrower ExperianKeyFactor3
        /// </summary>
        public string? ExperianKeyFactor3 { get => _experianKeyFactor3; set => SetField(ref _experianKeyFactor3, value); }

        /// <summary>
        /// Borrower ExperianKeyFactor4
        /// </summary>
        public string? ExperianKeyFactor4 { get => _experianKeyFactor4; set => SetField(ref _experianKeyFactor4, value); }

        /// <summary>
        /// Borrower ExperianKeyFactor5
        /// </summary>
        public string? ExperianKeyFactor5 { get => _experianKeyFactor5; set => SetField(ref _experianKeyFactor5, value); }

        /// <summary>
        /// Borrower ExperianMaterialTermsCreditByScore
        /// </summary>
        public bool? ExperianMaterialTermsCreditByScore { get => _experianMaterialTermsCreditByScore; set => SetField(ref _experianMaterialTermsCreditByScore, value); }

        /// <summary>
        /// Borrower FannieFirstName
        /// </summary>
        public string? FannieFirstName { get => _fannieFirstName; set => SetField(ref _fannieFirstName, value); }

        /// <summary>
        /// Borrower FannieMiddleName
        /// </summary>
        public string? FannieMiddleName { get => _fannieMiddleName; set => SetField(ref _fannieMiddleName, value); }

        /// <summary>
        /// Borrower Final1003Provided
        /// </summary>
        public bool? Final1003Provided { get => _final1003Provided; set => SetField(ref _final1003Provided, value); }

        /// <summary>
        /// Borrower FirstName
        /// </summary>
        public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

        /// <summary>
        /// Borrower FirstNameWithMiddleName
        /// </summary>
        public string? FirstNameWithMiddleName { get => _firstNameWithMiddleName; set => SetField(ref _firstNameWithMiddleName, value); }

        /// <summary>
        /// Borrower FirstTimeHomeBuyer
        /// </summary>
        public bool? FirstTimeHomeBuyer { get => _firstTimeHomeBuyer; set => SetField(ref _firstTimeHomeBuyer, value); }

        /// <summary>
        /// Underwriting Foreclosure Satisfied [2571]
        /// </summary>
        public DateTime? ForeclosureSatisfied { get => _foreclosureSatisfied; set => SetField(ref _foreclosureSatisfied, value); }

        /// <summary>
        /// Underwriting Foreclosure Status [2572]
        /// </summary>
        public StringEnumValue<BankruptcyForeclosureStatus> ForeclosureStatus { get => _foreclosureStatus; set => SetField(ref _foreclosureStatus, value); }

        /// <summary>
        /// Borrower FreddieMacPerson1
        /// </summary>
        public string? FreddieMacPerson1 { get => _freddieMacPerson1; set => SetField(ref _freddieMacPerson1, value); }

        /// <summary>
        /// Borrower FreddieMacPerson2
        /// </summary>
        public string? FreddieMacPerson2 { get => _freddieMacPerson2; set => SetField(ref _freddieMacPerson2, value); }

        /// <summary>
        /// Borrower FullName
        /// </summary>
        public string? FullName { get => _fullName; set => SetField(ref _fullName, value); }

        /// <summary>
        /// Borrower FullNameWithSuffix
        /// </summary>
        public string? FullNameWithSuffix { get => _fullNameWithSuffix; set => SetField(ref _fullNameWithSuffix, value); }

        /// <summary>
        /// Borrower GiftsAndGrantsIndicatorBor
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
        public bool? GiftsAndGrantsIndicatorBor { get => _giftsAndGrantsIndicatorBor; set => SetField(ref _giftsAndGrantsIndicatorBor, value); }

        /// <summary>
        /// Underwriting Highest Credit Limit [2567]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HighestCreditLimit { get => _highestCreditLimit; set => SetField(ref _highestCreditLimit, value); }

        /// <summary>
        /// Borrower Hmda2003OtherRaceNationalOriginDescription
        /// </summary>
        public string? Hmda2003OtherRaceNationalOriginDescription { get => _hmda2003OtherRaceNationalOriginDescription; set => SetField(ref _hmda2003OtherRaceNationalOriginDescription, value); }

        /// <summary>
        /// Borrower Hmda2003RaceNationalOriginType
        /// </summary>
        public StringEnumValue<Hmda2003RaceNationalOriginType> Hmda2003RaceNationalOriginType { get => _hmda2003RaceNationalOriginType; set => SetField(ref _hmda2003RaceNationalOriginType, value); }

        /// <summary>
        /// Borrower Hmda2CreditScoreForDecisionMaking
        /// </summary>
        public StringEnumValue<HmdaCreditScoreForDecisionMaking> Hmda2CreditScoreForDecisionMaking { get => _hmda2CreditScoreForDecisionMaking; set => SetField(ref _hmda2CreditScoreForDecisionMaking, value); }

        /// <summary>
        /// Borrower Hmda2CreditScoringModel
        /// </summary>
        public StringEnumValue<HmdaCreditScoringModel> Hmda2CreditScoringModel { get => _hmda2CreditScoringModel; set => SetField(ref _hmda2CreditScoringModel, value); }

        /// <summary>
        /// Borrower HmdaAfricanAmericanIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Black or African American\"}")]
        public bool? HmdaAfricanAmericanIndicator { get => _hmdaAfricanAmericanIndicator; set => SetField(ref _hmdaAfricanAmericanIndicator, value); }

        /// <summary>
        /// Borrower HmdaAge
        /// </summary>
        public StringEnumValue<HmdaAge> HmdaAge { get => _hmdaAge; set => SetField(ref _hmdaAge, value); }

        /// <summary>
        /// Borrower HmdaAmericanIndianIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"American Indian or Alaska Native\"}")]
        public bool? HmdaAmericanIndianIndicator { get => _hmdaAmericanIndianIndicator; set => SetField(ref _hmdaAmericanIndianIndicator, value); }

        /// <summary>
        /// Borrower HmdaAmericanIndianTribe
        /// </summary>
        public string? HmdaAmericanIndianTribe { get => _hmdaAmericanIndianTribe; set => SetField(ref _hmdaAmericanIndianTribe, value); }

        /// <summary>
        /// Borrower HmdaAsianIndianIndicator
        /// </summary>
        public bool? HmdaAsianIndianIndicator { get => _hmdaAsianIndianIndicator; set => SetField(ref _hmdaAsianIndianIndicator, value); }

        /// <summary>
        /// Borrower HmdaAsianIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Asian\"}")]
        public bool? HmdaAsianIndicator { get => _hmdaAsianIndicator; set => SetField(ref _hmdaAsianIndicator, value); }

        /// <summary>
        /// Borrower HmdaAsianOtherRaceIndicator
        /// </summary>
        public bool? HmdaAsianOtherRaceIndicator { get => _hmdaAsianOtherRaceIndicator; set => SetField(ref _hmdaAsianOtherRaceIndicator, value); }

        /// <summary>
        /// Borrower HmdaChineseIndicator
        /// </summary>
        public bool? HmdaChineseIndicator { get => _hmdaChineseIndicator; set => SetField(ref _hmdaChineseIndicator, value); }

        /// <summary>
        /// Borrower HmdaCreditScoreForDecisionMaking
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Exempt\"]")]
        public StringEnumValue<HmdaCreditScoreForDecisionMaking> HmdaCreditScoreForDecisionMaking { get => _hmdaCreditScoreForDecisionMaking; set => SetField(ref _hmdaCreditScoreForDecisionMaking, value); }

        /// <summary>
        /// Borrower HmdaCreditScoringModel
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"Exempt\"]")]
        public StringEnumValue<HmdaCreditScoringModel> HmdaCreditScoringModel { get => _hmdaCreditScoringModel; set => SetField(ref _hmdaCreditScoringModel, value); }

        /// <summary>
        /// Borrower HmdaCubanIndicator
        /// </summary>
        public bool? HmdaCubanIndicator { get => _hmdaCubanIndicator; set => SetField(ref _hmdaCubanIndicator, value); }

        /// <summary>
        /// Borrower HmdaEthnicityDoNotWishIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
        public bool? HmdaEthnicityDoNotWishIndicator { get => _hmdaEthnicityDoNotWishIndicator; set => SetField(ref _hmdaEthnicityDoNotWishIndicator, value); }

        /// <summary>
        /// Borrower HmdaEthnicityHispanicLatinoIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Hispanic or Latino\"}")]
        public bool? HmdaEthnicityHispanicLatinoIndicator { get => _hmdaEthnicityHispanicLatinoIndicator; set => SetField(ref _hmdaEthnicityHispanicLatinoIndicator, value); }

        /// <summary>
        /// Borrower HmdaEthnicityInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
        public bool? HmdaEthnicityInfoNotProvided { get => _hmdaEthnicityInfoNotProvided; set => SetField(ref _hmdaEthnicityInfoNotProvided, value); }

        /// <summary>
        /// Borrower HmdaEthnicityNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
        public bool? HmdaEthnicityNotApplicableIndicator { get => _hmdaEthnicityNotApplicableIndicator; set => SetField(ref _hmdaEthnicityNotApplicableIndicator, value); }

        /// <summary>
        /// Borrower HmdaEthnicityNotHispanicLatinoIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Hispanic or Latino\"}")]
        public bool? HmdaEthnicityNotHispanicLatinoIndicator { get => _hmdaEthnicityNotHispanicLatinoIndicator; set => SetField(ref _hmdaEthnicityNotHispanicLatinoIndicator, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedField1
        /// </summary>
        public string? HmdaEthnicityReportedField1 { get => _hmdaEthnicityReportedField1; set => SetField(ref _hmdaEthnicityReportedField1, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedField2
        /// </summary>
        public string? HmdaEthnicityReportedField2 { get => _hmdaEthnicityReportedField2; set => SetField(ref _hmdaEthnicityReportedField2, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedField3
        /// </summary>
        public string? HmdaEthnicityReportedField3 { get => _hmdaEthnicityReportedField3; set => SetField(ref _hmdaEthnicityReportedField3, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedField4
        /// </summary>
        public string? HmdaEthnicityReportedField4 { get => _hmdaEthnicityReportedField4; set => SetField(ref _hmdaEthnicityReportedField4, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedField5
        /// </summary>
        public string? HmdaEthnicityReportedField5 { get => _hmdaEthnicityReportedField5; set => SetField(ref _hmdaEthnicityReportedField5, value); }

        /// <summary>
        /// Borrower HmdaEthnicityReportedFields
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? HmdaEthnicityReportedFields { get => _hmdaEthnicityReportedFields; set => SetField(ref _hmdaEthnicityReportedFields, value); }

        /// <summary>
        /// Borrower HmdaEthnicityType
        /// </summary>
        public StringEnumValue<HmdaEthnicityType> HmdaEthnicityType { get => _hmdaEthnicityType; set => SetField(ref _hmdaEthnicityType, value); }

        /// <summary>
        /// Borrower HmdaFilipinoIndicator
        /// </summary>
        public bool? HmdaFilipinoIndicator { get => _hmdaFilipinoIndicator; set => SetField(ref _hmdaFilipinoIndicator, value); }

        /// <summary>
        /// Borrower HmdaGenderType
        /// </summary>
        public StringEnumValue<HmdaGenderType> HmdaGenderType { get => _hmdaGenderType; set => SetField(ref _hmdaGenderType, value); }

        /// <summary>
        /// Borrower HmdaGendertypeDoNotWishIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
        public bool? HmdaGendertypeDoNotWishIndicator { get => _hmdaGendertypeDoNotWishIndicator; set => SetField(ref _hmdaGendertypeDoNotWishIndicator, value); }

        /// <summary>
        /// Borrower HmdaGendertypeFemaleIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Female\"}")]
        public bool? HmdaGendertypeFemaleIndicator { get => _hmdaGendertypeFemaleIndicator; set => SetField(ref _hmdaGendertypeFemaleIndicator, value); }

        /// <summary>
        /// Borrower HmdaGendertypeMaleIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Male\"}")]
        public bool? HmdaGendertypeMaleIndicator { get => _hmdaGendertypeMaleIndicator; set => SetField(ref _hmdaGendertypeMaleIndicator, value); }

        /// <summary>
        /// Borrower HmdaGendertypeNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
        public bool? HmdaGendertypeNotApplicableIndicator { get => _hmdaGendertypeNotApplicableIndicator; set => SetField(ref _hmdaGendertypeNotApplicableIndicator, value); }

        /// <summary>
        /// Borrower HmdaGuamanianOrChamorroIndicator
        /// </summary>
        public bool? HmdaGuamanianOrChamorroIndicator { get => _hmdaGuamanianOrChamorroIndicator; set => SetField(ref _hmdaGuamanianOrChamorroIndicator, value); }

        /// <summary>
        /// Borrower HmdaHispanicLatinoOtherOriginIndicator
        /// </summary>
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get => _hmdaHispanicLatinoOtherOriginIndicator; set => SetField(ref _hmdaHispanicLatinoOtherOriginIndicator, value); }

        /// <summary>
        /// Borrower HmdaJapaneseIndicator
        /// </summary>
        public bool? HmdaJapaneseIndicator { get => _hmdaJapaneseIndicator; set => SetField(ref _hmdaJapaneseIndicator, value); }

        /// <summary>
        /// Borrower HmdaKoreanIndicator
        /// </summary>
        public bool? HmdaKoreanIndicator { get => _hmdaKoreanIndicator; set => SetField(ref _hmdaKoreanIndicator, value); }

        /// <summary>
        /// Borrower HmdaMexicanIndicator
        /// </summary>
        public bool? HmdaMexicanIndicator { get => _hmdaMexicanIndicator; set => SetField(ref _hmdaMexicanIndicator, value); }

        /// <summary>
        /// Borrower HmdaNativeHawaiianIndicator
        /// </summary>
        public bool? HmdaNativeHawaiianIndicator { get => _hmdaNativeHawaiianIndicator; set => SetField(ref _hmdaNativeHawaiianIndicator, value); }

        /// <summary>
        /// No Co-applicant Indicator [3840]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"No Co-applicant\"}")]
        public bool? HmdaNoCoApplicantIndicator { get => _hmdaNoCoApplicantIndicator; set => SetField(ref _hmdaNoCoApplicantIndicator, value); }

        /// <summary>
        /// Borrower HmdaNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not applicable\"}")]
        public bool? HmdaNotApplicableIndicator { get => _hmdaNotApplicableIndicator; set => SetField(ref _hmdaNotApplicableIndicator, value); }

        /// <summary>
        /// Borrower HmdaNotProvidedIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
        public bool? HmdaNotProvidedIndicator { get => _hmdaNotProvidedIndicator; set => SetField(ref _hmdaNotProvidedIndicator, value); }

        /// <summary>
        /// Borrower HmdaOtherAsianRace
        /// </summary>
        public string? HmdaOtherAsianRace { get => _hmdaOtherAsianRace; set => SetField(ref _hmdaOtherAsianRace, value); }

        /// <summary>
        /// Borrower HmdaOtherHispanicLatinoOrigin
        /// </summary>
        public string? HmdaOtherHispanicLatinoOrigin { get => _hmdaOtherHispanicLatinoOrigin; set => SetField(ref _hmdaOtherHispanicLatinoOrigin, value); }

        /// <summary>
        /// Borrower HmdaOtherPacificIslanderRace
        /// </summary>
        public string? HmdaOtherPacificIslanderRace { get => _hmdaOtherPacificIslanderRace; set => SetField(ref _hmdaOtherPacificIslanderRace, value); }

        /// <summary>
        /// Borrower HmdaOtherScoringModel
        /// </summary>
        public string? HmdaOtherScoringModel { get => _hmdaOtherScoringModel; set => SetField(ref _hmdaOtherScoringModel, value); }

        /// <summary>
        /// Borrower HmdaPacificIslanderIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Native Hawaiian or Other Pacific Islander\"}")]
        public bool? HmdaPacificIslanderIndicator { get => _hmdaPacificIslanderIndicator; set => SetField(ref _hmdaPacificIslanderIndicator, value); }

        /// <summary>
        /// Borrower HmdaPacificIslanderOtherIndicator
        /// </summary>
        public bool? HmdaPacificIslanderOtherIndicator { get => _hmdaPacificIslanderOtherIndicator; set => SetField(ref _hmdaPacificIslanderOtherIndicator, value); }

        /// <summary>
        /// Borrower HmdaPuertoRicanIndicator
        /// </summary>
        public bool? HmdaPuertoRicanIndicator { get => _hmdaPuertoRicanIndicator; set => SetField(ref _hmdaPuertoRicanIndicator, value); }

        /// <summary>
        /// Borrower HmdaRaceDoNotWishProvideIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
        public bool? HmdaRaceDoNotWishProvideIndicator { get => _hmdaRaceDoNotWishProvideIndicator; set => SetField(ref _hmdaRaceDoNotWishProvideIndicator, value); }

        /// <summary>
        /// Borrower HmdaRaceInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
        public bool? HmdaRaceInfoNotProvided { get => _hmdaRaceInfoNotProvided; set => SetField(ref _hmdaRaceInfoNotProvided, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedField1
        /// </summary>
        public string? HmdaRaceReportedField1 { get => _hmdaRaceReportedField1; set => SetField(ref _hmdaRaceReportedField1, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedField2
        /// </summary>
        public string? HmdaRaceReportedField2 { get => _hmdaRaceReportedField2; set => SetField(ref _hmdaRaceReportedField2, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedField3
        /// </summary>
        public string? HmdaRaceReportedField3 { get => _hmdaRaceReportedField3; set => SetField(ref _hmdaRaceReportedField3, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedField4
        /// </summary>
        public string? HmdaRaceReportedField4 { get => _hmdaRaceReportedField4; set => SetField(ref _hmdaRaceReportedField4, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedField5
        /// </summary>
        public string? HmdaRaceReportedField5 { get => _hmdaRaceReportedField5; set => SetField(ref _hmdaRaceReportedField5, value); }

        /// <summary>
        /// Borrower HmdaRaceReportedFields
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? HmdaRaceReportedFields { get => _hmdaRaceReportedFields; set => SetField(ref _hmdaRaceReportedFields, value); }

        /// <summary>
        /// Borrower HmdaRefusalIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to furnish this info\"}")]
        public bool? HmdaRefusalIndicator { get => _hmdaRefusalIndicator; set => SetField(ref _hmdaRefusalIndicator, value); }

        /// <summary>
        /// Borrower HmdaSamoanIndicator
        /// </summary>
        public bool? HmdaSamoanIndicator { get => _hmdaSamoanIndicator; set => SetField(ref _hmdaSamoanIndicator, value); }

        /// <summary>
        /// Borrower HmdaSexInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
        public bool? HmdaSexInfoNotProvided { get => _hmdaSexInfoNotProvided; set => SetField(ref _hmdaSexInfoNotProvided, value); }

        /// <summary>
        /// Borrower HmdaVietnameseIndicator
        /// </summary>
        public bool? HmdaVietnameseIndicator { get => _hmdaVietnameseIndicator; set => SetField(ref _hmdaVietnameseIndicator, value); }

        /// <summary>
        /// Borrower HmdaWhiteIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"White\"}")]
        public bool? HmdaWhiteIndicator { get => _hmdaWhiteIndicator; set => SetField(ref _hmdaWhiteIndicator, value); }

        /// <summary>
        /// Borrower HomeCounselingAgencyName
        /// </summary>
        public string? HomeCounselingAgencyName { get => _homeCounselingAgencyName; set => SetField(ref _homeCounselingAgencyName, value); }

        /// <summary>
        /// Borrower HomeCounselingCompletionDate
        /// </summary>
        public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => SetField(ref _homeCounselingCompletionDate, value); }

        /// <summary>
        /// Borrower HomeownerPastThreeYearsIndicator
        /// </summary>
        public bool? HomeownerPastThreeYearsIndicator { get => _homeownerPastThreeYearsIndicator; set => SetField(ref _homeownerPastThreeYearsIndicator, value); }

        /// <summary>
        /// Borrower HomePhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? HomePhoneNumber { get => _homePhoneNumber; set => SetField(ref _homePhoneNumber, value); }

        /// <summary>
        /// Borrower Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Borrower IncomeRepAndWarrantyMessage
        /// </summary>
        public string? IncomeRepAndWarrantyMessage { get => _incomeRepAndWarrantyMessage; set => SetField(ref _incomeRepAndWarrantyMessage, value); }

        /// <summary>
        /// Borrower IncomeRepAndWarrantyReliefAvailable
        /// </summary>
        public bool? IncomeRepAndWarrantyReliefAvailable { get => _incomeRepAndWarrantyReliefAvailable; set => SetField(ref _incomeRepAndWarrantyReliefAvailable, value); }

        /// <summary>
        /// Borrower Initial1003Provided
        /// </summary>
        public bool? Initial1003Provided { get => _initial1003Provided; set => SetField(ref _initial1003Provided, value); }

        /// <summary>
        /// Borrower IntentToOccupyIndicator
        /// </summary>
        public bool? IntentToOccupyIndicator { get => _intentToOccupyIndicator; set => SetField(ref _intentToOccupyIndicator, value); }

        /// <summary>
        /// Borrower IntuitReportId
        /// </summary>
        public string? IntuitReportId { get => _intuitReportId; set => SetField(ref _intuitReportId, value); }

        /// <summary>
        /// Borrower IsBaseIncomeAvailable
        /// </summary>
        public bool? IsBaseIncomeAvailable { get => _isBaseIncomeAvailable; set => SetField(ref _isBaseIncomeAvailable, value); }

        /// <summary>
        /// Borrower IsBonusAvailable
        /// </summary>
        public bool? IsBonusAvailable { get => _isBonusAvailable; set => SetField(ref _isBonusAvailable, value); }

        /// <summary>
        /// Borrower IsBorrower
        /// </summary>
        public bool? IsBorrower { get => _isBorrower; set => SetField(ref _isBorrower, value); }

        /// <summary>
        /// Borrower IsCommissionAvailable
        /// </summary>
        public bool? IsCommissionAvailable { get => _isCommissionAvailable; set => SetField(ref _isCommissionAvailable, value); }

        /// <summary>
        /// Borrower IsEthnicityBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsEthnicityBasedOnVisual { get => _isEthnicityBasedOnVisual; set => SetField(ref _isEthnicityBasedOnVisual, value); }

        /// <summary>
        /// Borrower IsOvertimeAvailable
        /// </summary>
        public bool? IsOvertimeAvailable { get => _isOvertimeAvailable; set => SetField(ref _isOvertimeAvailable, value); }

        /// <summary>
        /// Borrower IsRaceBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsRaceBasedOnVisual { get => _isRaceBasedOnVisual; set => SetField(ref _isRaceBasedOnVisual, value); }

        /// <summary>
        /// Borrower IsSelfEmployed
        /// </summary>
        public bool? IsSelfEmployed { get => _isSelfEmployed; set => SetField(ref _isSelfEmployed, value); }

        /// <summary>
        /// Borrower IsSexBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsSexBasedOnVisual { get => _isSexBasedOnVisual; set => SetField(ref _isSexBasedOnVisual, value); }

        /// <summary>
        /// Borrower IsSocialSecurityAvailable
        /// </summary>
        public bool? IsSocialSecurityAvailable { get => _isSocialSecurityAvailable; set => SetField(ref _isSocialSecurityAvailable, value); }

        /// <summary>
        /// Borrower IsTaxReturnAvailable
        /// </summary>
        public bool? IsTaxReturnAvailable { get => _isTaxReturnAvailable; set => SetField(ref _isTaxReturnAvailable, value); }

        /// <summary>
        /// Borrower JointAssetLiabilityReportingIndicator
        /// </summary>
        public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => SetField(ref _jointAssetLiabilityReportingIndicator, value); }

        /// <summary>
        /// Assets/Liabilities Completed Jointly/Not Jointly [URLA.X234]
        /// </summary>
        public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator1 { get => _jointAssetLiabilityReportingIndicator1; set => SetField(ref _jointAssetLiabilityReportingIndicator1, value); }

        /// <summary>
        /// Borrower LanguageCodeOtherDescription
        /// </summary>
        public string? LanguageCodeOtherDescription { get => _languageCodeOtherDescription; set => SetField(ref _languageCodeOtherDescription, value); }

        /// <summary>
        /// Borrower LanguagePreference
        /// </summary>
        public StringEnumValue<LanguagePreference> LanguagePreference { get => _languagePreference; set => SetField(ref _languagePreference, value); }

        /// <summary>
        /// Borrower LastName
        /// </summary>
        public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

        /// <summary>
        /// Borrower LastNameWithSuffix
        /// </summary>
        public string? LastNameWithSuffix { get => _lastNameWithSuffix; set => SetField(ref _lastNameWithSuffix, value); }

        /// <summary>
        /// Borrower LeaveAndEarningsStatement
        /// </summary>
        public bool? LeaveAndEarningsStatement { get => _leaveAndEarningsStatement; set => SetField(ref _leaveAndEarningsStatement, value); }

        /// <summary>
        /// Borrower LeDeliveryMethod
        /// </summary>
        public string? LeDeliveryMethod { get => _leDeliveryMethod; set => SetField(ref _leDeliveryMethod, value); }

        /// <summary>
        /// Borrower LegalOtherThanSpouse
        /// </summary>
        public bool? LegalOtherThanSpouse { get => _legalOtherThanSpouse; set => SetField(ref _legalOtherThanSpouse, value); }

        /// <summary>
        /// Borrower LiabilitiesDoesNotApply
        /// </summary>
        public bool? LiabilitiesDoesNotApply { get => _liabilitiesDoesNotApply; set => SetField(ref _liabilitiesDoesNotApply, value); }

        /// <summary>
        /// Borrower LoanForeclosureOrJudgementIndicator
        /// </summary>
        public bool? LoanForeclosureOrJudgementIndicator { get => _loanForeclosureOrJudgementIndicator; set => SetField(ref _loanForeclosureOrJudgementIndicator, value); }

        /// <summary>
        /// Borrower LpdGsa
        /// </summary>
        public string? LpdGsa { get => _lpdGsa; set => SetField(ref _lpdGsa, value); }

        /// <summary>
        /// Borrower MailingAddressSameAsPresentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Same as present address\"}")]
        public bool? MailingAddressSameAsPresentIndicator { get => _mailingAddressSameAsPresentIndicator; set => SetField(ref _mailingAddressSameAsPresentIndicator, value); }

        /// <summary>
        /// Borrower MaritalStatusType
        /// </summary>
        public StringEnumValue<MaritalStatusType> MaritalStatusType { get => _maritalStatusType; set => SetField(ref _maritalStatusType, value); }

        /// <summary>
        /// Borrower MiddleCreditScore
        /// </summary>
        public int? MiddleCreditScore { get => _middleCreditScore; set => SetField(ref _middleCreditScore, value); }

        /// <summary>
        /// Borrower MiddleFicoScore
        /// </summary>
        public string? MiddleFicoScore { get => _middleFicoScore; set => SetField(ref _middleFicoScore, value); }

        /// <summary>
        /// Borrower MiddleName
        /// </summary>
        public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

        /// <summary>
        /// Borrower MilitaryServiceExpectedCompletionDate
        /// </summary>
        public DateTime? MilitaryServiceExpectedCompletionDate { get => _militaryServiceExpectedCompletionDate; set => SetField(ref _militaryServiceExpectedCompletionDate, value); }

        /// <summary>
        /// Borrower MinFicoScore
        /// </summary>
        public string? MinFicoScore { get => _minFicoScore; set => SetField(ref _minFicoScore, value); }

        /// <summary>
        /// Borrower MobilePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? MobilePhone { get => _mobilePhone; set => SetField(ref _mobilePhone, value); }

        /// <summary>
        /// Underwriting Mortgage on Credit [2563]
        /// </summary>
        public bool? MortgageOnCredit { get => _mortgageOnCredit; set => SetField(ref _mortgageOnCredit, value); }

        /// <summary>
        /// Borrower NameToObtainLoanFromRHS
        /// </summary>
        public string? NameToObtainLoanFromRHS { get => _nameToObtainLoanFromRHS; set => SetField(ref _nameToObtainLoanFromRHS, value); }

        /// <summary>
        /// Borrower NearestRelativeAddress
        /// </summary>
        public string? NearestRelativeAddress { get => _nearestRelativeAddress; set => SetField(ref _nearestRelativeAddress, value); }

        /// <summary>
        /// Borrower NearestRelativeCity
        /// </summary>
        public string? NearestRelativeCity { get => _nearestRelativeCity; set => SetField(ref _nearestRelativeCity, value); }

        /// <summary>
        /// Borrower NearestRelativeCountry
        /// </summary>
        public string? NearestRelativeCountry { get => _nearestRelativeCountry; set => SetField(ref _nearestRelativeCountry, value); }

        /// <summary>
        /// Borrower NearestRelativeForeignAddressIndicator
        /// </summary>
        public bool? NearestRelativeForeignAddressIndicator { get => _nearestRelativeForeignAddressIndicator; set => SetField(ref _nearestRelativeForeignAddressIndicator, value); }

        /// <summary>
        /// Borrower NearestRelativeName
        /// </summary>
        public string? NearestRelativeName { get => _nearestRelativeName; set => SetField(ref _nearestRelativeName, value); }

        /// <summary>
        /// Borrower NearestRelativePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? NearestRelativePhone { get => _nearestRelativePhone; set => SetField(ref _nearestRelativePhone, value); }

        /// <summary>
        /// Borrower NearestRelativePostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? NearestRelativePostalCode { get => _nearestRelativePostalCode; set => SetField(ref _nearestRelativePostalCode, value); }

        /// <summary>
        /// Borrower NearestRelativeRelationship
        /// </summary>
        public string? NearestRelativeRelationship { get => _nearestRelativeRelationship; set => SetField(ref _nearestRelativeRelationship, value); }

        /// <summary>
        /// Borrower NearestRelativeState
        /// </summary>
        public StringEnumValue<State> NearestRelativeState { get => _nearestRelativeState; set => SetField(ref _nearestRelativeState, value); }

        /// <summary>
        /// Borrower NetRentalIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NetRentalIncome { get => _netRentalIncome; set => SetField(ref _netRentalIncome, value); }

        /// <summary>
        /// Borrower No3rdPartyEmailIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Borrower No Third-Party Email for HomePoints\"}")]
        public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => SetField(ref _no3rdPartyEmailIndicator, value); }

        /// <summary>
        /// Co-Borr Ethnicity No Co Applicant [4188]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
        public bool? NoCoApplicantEthnicityIndicator { get => _noCoApplicantEthnicityIndicator; set => SetField(ref _noCoApplicantEthnicityIndicator, value); }

        /// <summary>
        /// Co-Borr Race No Co Applicant [3174]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
        public bool? NoCoApplicantIndicator { get => _noCoApplicantIndicator; set => SetField(ref _noCoApplicantIndicator, value); }

        /// <summary>
        /// Co-Borr Sex No Co Applicant [4189]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"No co-applicant\"}")]
        public bool? NoCoApplicantSexIndicator { get => _noCoApplicantSexIndicator; set => SetField(ref _noCoApplicantSexIndicator, value); }

        /// <summary>
        /// Underwriting Number of Tradelines [2564]
        /// </summary>
        public int? NumberofTradelines { get => _numberofTradelines; set => SetField(ref _numberofTradelines, value); }

        /// <summary>
        /// Borrower ObtainLoanFromRHSIndicator
        /// </summary>
        public bool? ObtainLoanFromRHSIndicator { get => _obtainLoanFromRHSIndicator; set => SetField(ref _obtainLoanFromRHSIndicator, value); }

        /// <summary>
        /// Underwriting Open Bankruptcy [2568]
        /// </summary>
        public StringEnumValue<OpenBankruptcy> OpenBankruptcy2 { get => _openBankruptcy2; set => SetField(ref _openBankruptcy2, value); }

        /// <summary>
        /// Borrower OtherAssetsDoesNotApply
        /// </summary>
        public bool? OtherAssetsDoesNotApply { get => _otherAssetsDoesNotApply; set => SetField(ref _otherAssetsDoesNotApply, value); }

        /// <summary>
        /// Borrower OtherLiabilitiesDoesNotApply
        /// </summary>
        public bool? OtherLiabilitiesDoesNotApply { get => _otherLiabilitiesDoesNotApply; set => SetField(ref _otherLiabilitiesDoesNotApply, value); }

        /// <summary>
        /// Borrower OtherMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherMonthlyIncomeAmount { get => _otherMonthlyIncomeAmount; set => SetField(ref _otherMonthlyIncomeAmount, value); }

        /// <summary>
        /// Borrower OtherRelationshipTypeDescription
        /// </summary>
        public string? OtherRelationshipTypeDescription { get => _otherRelationshipTypeDescription; set => SetField(ref _otherRelationshipTypeDescription, value); }

        /// <summary>
        /// Borrower OtherSrcIncomeDoesNotApply
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
        public bool? OtherSrcIncomeDoesNotApply { get => _otherSrcIncomeDoesNotApply; set => SetField(ref _otherSrcIncomeDoesNotApply, value); }

        /// <summary>
        /// Borrower OtherSumAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherSumAmount { get => _otherSumAmount; set => SetField(ref _otherSumAmount, value); }

        /// <summary>
        /// Borrower OutstandingJudgementsIndicator
        /// </summary>
        public bool? OutstandingJudgementsIndicator { get => _outstandingJudgementsIndicator; set => SetField(ref _outstandingJudgementsIndicator, value); }

        /// <summary>
        /// Borrower OvertimeValidationMessage
        /// </summary>
        public string? OvertimeValidationMessage { get => _overtimeValidationMessage; set => SetField(ref _overtimeValidationMessage, value); }

        /// <summary>
        /// Borrower OwnershipConfirmationIndicator
        /// </summary>
        public bool? OwnershipConfirmationIndicator { get => _ownershipConfirmationIndicator; set => SetField(ref _ownershipConfirmationIndicator, value); }

        /// <summary>
        /// Borrower OwnershipFormatType
        /// </summary>
        public StringEnumValue<OwnershipFormatType> OwnershipFormatType { get => _ownershipFormatType; set => SetField(ref _ownershipFormatType, value); }

        /// <summary>
        /// Borrower OwnershipPartyRoleIdentifier
        /// </summary>
        public string? OwnershipPartyRoleIdentifier { get => _ownershipPartyRoleIdentifier; set => SetField(ref _ownershipPartyRoleIdentifier, value); }

        /// <summary>
        /// Borrower PartyToLawsuitIndicator
        /// </summary>
        public bool? PartyToLawsuitIndicator { get => _partyToLawsuitIndicator; set => SetField(ref _partyToLawsuitIndicator, value); }

        /// <summary>
        /// Borrower PartyToLawsuitIndicatorURLA
        /// </summary>
        public bool? PartyToLawsuitIndicatorURLA { get => _partyToLawsuitIndicatorURLA; set => SetField(ref _partyToLawsuitIndicatorURLA, value); }

        /// <summary>
        /// Underwriting Mortgage 120 Days [2561]
        /// </summary>
        public int? Pass120Days { get => _pass120Days; set => SetField(ref _pass120Days, value); }

        /// <summary>
        /// Underwriting Mortgage 150 Days [2562]
        /// </summary>
        public int? Pass150Days { get => _pass150Days; set => SetField(ref _pass150Days, value); }

        /// <summary>
        /// Underwriting Mortgage 30 Days [2558]
        /// </summary>
        public int? Pass30Days { get => _pass30Days; set => SetField(ref _pass30Days, value); }

        /// <summary>
        /// Underwriting Mortgaget 60 Days [2559]
        /// </summary>
        public int? Pass60Days { get => _pass60Days; set => SetField(ref _pass60Days, value); }

        /// <summary>
        /// Underwriting Mortgage 90 Days [2560]
        /// </summary>
        public int? Pass90Days { get => _pass90Days; set => SetField(ref _pass90Days, value); }

        /// <summary>
        /// Borrower PensionRetireIncomeMessage
        /// </summary>
        public string? PensionRetireIncomeMessage { get => _pensionRetireIncomeMessage; set => SetField(ref _pensionRetireIncomeMessage, value); }

        /// <summary>
        /// Borrower PersonFaxNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? PersonFaxNumber { get => _personFaxNumber; set => SetField(ref _personFaxNumber, value); }

        /// <summary>
        /// Borrower PersonHoursPerWeek
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PersonHoursPerWeek { get => _personHoursPerWeek; set => SetField(ref _personHoursPerWeek, value); }

        /// <summary>
        /// Borrower PersonIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PersonIncomeAmount { get => _personIncomeAmount; set => SetField(ref _personIncomeAmount, value); }

        /// <summary>
        /// Borrower PersonIncomeFrequencyType
        /// </summary>
        public string? PersonIncomeFrequencyType { get => _personIncomeFrequencyType; set => SetField(ref _personIncomeFrequencyType, value); }

        /// <summary>
        /// Borrower PersonMonthlyIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PersonMonthlyIncome { get => _personMonthlyIncome; set => SetField(ref _personMonthlyIncome, value); }

        /// <summary>
        /// Borrower PIWAccepted
        /// </summary>
        public bool? PIWAccepted { get => _pIWAccepted; set => SetField(ref _pIWAccepted, value); }

        /// <summary>
        /// Borrower PIWMessage
        /// </summary>
        public string? PIWMessage { get => _pIWMessage; set => SetField(ref _pIWMessage, value); }

        /// <summary>
        /// Borrower PoaOccupancyIntent
        /// </summary>
        public StringEnumValue<OccupancyIntent> PoaOccupancyIntent { get => _poaOccupancyIntent; set => SetField(ref _poaOccupancyIntent, value); }

        /// <summary>
        /// Borrower PoaSignatureText
        /// </summary>
        public string? PoaSignatureText { get => _poaSignatureText; set => SetField(ref _poaSignatureText, value); }

        /// <summary>
        /// Borrower PositiveCashFlow
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PositiveCashFlow { get => _positiveCashFlow; set => SetField(ref _positiveCashFlow, value); }

        /// <summary>
        /// Borrower PowerOfAttorneyName
        /// </summary>
        public string? PowerOfAttorneyName { get => _powerOfAttorneyName; set => SetField(ref _powerOfAttorneyName, value); }

        /// <summary>
        /// Borrower PowerOfAttorneyTitleDescription
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PowerOfAttorneyTitleDescription { get => _powerOfAttorneyTitleDescription; set => SetField(ref _powerOfAttorneyTitleDescription, value); }

        /// <summary>
        /// Borrower PresentlyDelinquentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Have any past due obligations owed to/insured by any agency of the Federal Government\"}")]
        public bool? PresentlyDelinquentIndicator { get => _presentlyDelinquentIndicator; set => SetField(ref _presentlyDelinquentIndicator, value); }

        /// <summary>
        /// Borrower PresentlyDelinquentIndicatorURLA
        /// </summary>
        public bool? PresentlyDelinquentIndicatorURLA { get => _presentlyDelinquentIndicatorURLA; set => SetField(ref _presentlyDelinquentIndicatorURLA, value); }

        /// <summary>
        /// Borrower PreviousEmploymentDoesNotApply
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
        public bool? PreviousEmploymentDoesNotApply { get => _previousEmploymentDoesNotApply; set => SetField(ref _previousEmploymentDoesNotApply, value); }

        /// <summary>
        /// Borrower PreviousGrossMonthlyIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PreviousGrossMonthlyIncome { get => _previousGrossMonthlyIncome; set => SetField(ref _previousGrossMonthlyIncome, value); }

        /// <summary>
        /// Borrower PrintOnAdditionalBorrowerPage
        /// </summary>
        public bool? PrintOnAdditionalBorrowerPage { get => _printOnAdditionalBorrowerPage; set => SetField(ref _printOnAdditionalBorrowerPage, value); }

        /// <summary>
        /// Underwriting Prior Bankruptcy [2569]
        /// </summary>
        public DateTime? PriorBankruptcy2 { get => _priorBankruptcy2; set => SetField(ref _priorBankruptcy2, value); }

        /// <summary>
        /// Underwriting Prior Foreclosure [2339]
        /// </summary>
        public bool? PriorForeclosure { get => _priorForeclosure; set => SetField(ref _priorForeclosure, value); }

        /// <summary>
        /// Borrower PriorPropertyDeedInLieuConveyedIndicator
        /// </summary>
        public bool? PriorPropertyDeedInLieuConveyedIndicator { get => _priorPropertyDeedInLieuConveyedIndicator; set => SetField(ref _priorPropertyDeedInLieuConveyedIndicator, value); }

        /// <summary>
        /// Borrower PriorPropertyForeclosureCompletedIndicator
        /// </summary>
        public bool? PriorPropertyForeclosureCompletedIndicator { get => _priorPropertyForeclosureCompletedIndicator; set => SetField(ref _priorPropertyForeclosureCompletedIndicator, value); }

        /// <summary>
        /// Borrower PriorPropertyShortSaleCompletedIndicator
        /// </summary>
        public bool? PriorPropertyShortSaleCompletedIndicator { get => _priorPropertyShortSaleCompletedIndicator; set => SetField(ref _priorPropertyShortSaleCompletedIndicator, value); }

        /// <summary>
        /// Borrower PriorPropertyTitleType
        /// </summary>
        public StringEnumValue<PriorPropertyTitleType> PriorPropertyTitleType { get => _priorPropertyTitleType; set => SetField(ref _priorPropertyTitleType, value); }

        /// <summary>
        /// Borrower PriorPropertyUsageType
        /// </summary>
        public StringEnumValue<PriorPropertyUsageType> PriorPropertyUsageType { get => _priorPropertyUsageType; set => SetField(ref _priorPropertyUsageType, value); }

        /// <summary>
        /// Borrower PriorResidenceDoesNotApply
        /// </summary>
        public bool? PriorResidenceDoesNotApply { get => _priorResidenceDoesNotApply; set => SetField(ref _priorResidenceDoesNotApply, value); }

        /// <summary>
        /// Borrower PropertyForeclosedPastSevenYearsIndicator
        /// </summary>
        public bool? PropertyForeclosedPastSevenYearsIndicator { get => _propertyForeclosedPastSevenYearsIndicator; set => SetField(ref _propertyForeclosedPastSevenYearsIndicator, value); }

        /// <summary>
        /// Borrower PropertyProposedCleanEnergyLienIndicator
        /// </summary>
        public bool? PropertyProposedCleanEnergyLienIndicator { get => _propertyProposedCleanEnergyLienIndicator; set => SetField(ref _propertyProposedCleanEnergyLienIndicator, value); }

        /// <summary>
        /// Borrower RealEstateDoesNotApply
        /// </summary>
        public bool? RealEstateDoesNotApply { get => _realEstateDoesNotApply; set => SetField(ref _realEstateDoesNotApply, value); }

        /// <summary>
        /// Borrower RelationshipDescription
        /// </summary>
        public string? RelationshipDescription { get => _relationshipDescription; set => SetField(ref _relationshipDescription, value); }

        /// <summary>
        /// Borrower RelationshipWithRDEmployeeIndicator
        /// </summary>
        public bool? RelationshipWithRDEmployeeIndicator { get => _relationshipWithRDEmployeeIndicator; set => SetField(ref _relationshipWithRDEmployeeIndicator, value); }

        /// <summary>
        /// Borrower ReserveNationalGuardReserveActivated
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Only period of service was as a non-activated member of the Reserve or National Guard\"}")]
        public bool? ReserveNationalGuardReserveActivated { get => _reserveNationalGuardReserveActivated; set => SetField(ref _reserveNationalGuardReserveActivated, value); }

        /// <summary>
        /// Borrower RetirementPensionIncomeAvailable
        /// </summary>
        public bool? RetirementPensionIncomeAvailable { get => _retirementPensionIncomeAvailable; set => SetField(ref _retirementPensionIncomeAvailable, value); }

        /// <summary>
        /// Borrower SchoolingTermYears
        /// </summary>
        public int? SchoolingTermYears { get => _schoolingTermYears; set => SetField(ref _schoolingTermYears, value); }

        /// <summary>
        /// Declarations Section A Occupancy Explanation [URLA.X216]
        /// </summary>
        public string? SectionAExplanation { get => _sectionAExplanation; set => SetField(ref _sectionAExplanation, value); }

        /// <summary>
        /// Print Section A explanation - Borrower [URLA.X247]
        /// </summary>
        public bool? SectionAPrintExplanation { get => _sectionAPrintExplanation; set => SetField(ref _sectionAPrintExplanation, value); }

        /// <summary>
        /// Declarations Section B Explanation [URLA.X217]
        /// </summary>
        public string? SectionBExplanation { get => _sectionBExplanation; set => SetField(ref _sectionBExplanation, value); }

        /// <summary>
        /// Print Section B explanation - Borrower [URLA.X248]
        /// </summary>
        public bool? SectionBPrintExplanation { get => _sectionBPrintExplanation; set => SetField(ref _sectionBPrintExplanation, value); }

        /// <summary>
        /// Declarations Section C Explanation [URLA.X218]
        /// </summary>
        public string? SectionCExplanation { get => _sectionCExplanation; set => SetField(ref _sectionCExplanation, value); }

        /// <summary>
        /// Print Section C explanation - Borrower [URLA.X249]
        /// </summary>
        public bool? SectionCPrintExplanation { get => _sectionCPrintExplanation; set => SetField(ref _sectionCPrintExplanation, value); }

        /// <summary>
        /// Print Section D1 explanation - Borrower [URLA.X250]
        /// </summary>
        public bool? SectionD1PrintExplanation { get => _sectionD1PrintExplanation; set => SetField(ref _sectionD1PrintExplanation, value); }

        /// <summary>
        /// Declarations Section D2 Explanation [URLA.X235]
        /// </summary>
        public string? SectionD2Explanation { get => _sectionD2Explanation; set => SetField(ref _sectionD2Explanation, value); }

        /// <summary>
        /// Print Section D2 explanation - Borrower [URLA.X251]
        /// </summary>
        public bool? SectionD2PrintExplanation { get => _sectionD2PrintExplanation; set => SetField(ref _sectionD2PrintExplanation, value); }

        /// <summary>
        /// Declarations Section D Explanation [URLA.X219]
        /// </summary>
        public string? SectionDExplanation { get => _sectionDExplanation; set => SetField(ref _sectionDExplanation, value); }

        /// <summary>
        /// Declarations Section E Explanation [URLA.X220]
        /// </summary>
        public string? SectionEExplanation { get => _sectionEExplanation; set => SetField(ref _sectionEExplanation, value); }

        /// <summary>
        /// Print Section E explanation - Borrower [URLA.X252]
        /// </summary>
        public bool? SectionEPrintExplanation { get => _sectionEPrintExplanation; set => SetField(ref _sectionEPrintExplanation, value); }

        /// <summary>
        /// Declarations Section F Explanation [URLA.X221]
        /// </summary>
        public string? SectionFExplanation { get => _sectionFExplanation; set => SetField(ref _sectionFExplanation, value); }

        /// <summary>
        /// Print Section F explanation - Borrower [URLA.X253]
        /// </summary>
        public bool? SectionFPrintExplanation { get => _sectionFPrintExplanation; set => SetField(ref _sectionFPrintExplanation, value); }

        /// <summary>
        /// Declarations Section G Explanation [URLA.X222]
        /// </summary>
        public string? SectionGExplanation { get => _sectionGExplanation; set => SetField(ref _sectionGExplanation, value); }

        /// <summary>
        /// Print Section G explanation - Borrower [URLA.X254]
        /// </summary>
        public bool? SectionGPrintExplanation { get => _sectionGPrintExplanation; set => SetField(ref _sectionGPrintExplanation, value); }

        /// <summary>
        /// Declarations Section H Explanation [URLA.X223]
        /// </summary>
        public string? SectionHExplanation { get => _sectionHExplanation; set => SetField(ref _sectionHExplanation, value); }

        /// <summary>
        /// Print Section H explanation - Borrower [URLA.X255]
        /// </summary>
        public bool? SectionHPrintExplanation { get => _sectionHPrintExplanation; set => SetField(ref _sectionHPrintExplanation, value); }

        /// <summary>
        /// Declarations Section I Explanation [URLA.X224]
        /// </summary>
        public string? SectionIExplanation { get => _sectionIExplanation; set => SetField(ref _sectionIExplanation, value); }

        /// <summary>
        /// Print Section I explanation - Borrower [URLA.X256]
        /// </summary>
        public bool? SectionIPrintExplanation { get => _sectionIPrintExplanation; set => SetField(ref _sectionIPrintExplanation, value); }

        /// <summary>
        /// Declarations Section J Explanation [URLA.X225]
        /// </summary>
        public string? SectionJExplanation { get => _sectionJExplanation; set => SetField(ref _sectionJExplanation, value); }

        /// <summary>
        /// Print Section J explanation - Borrower [URLA.X257]
        /// </summary>
        public bool? SectionJPrintExplanation { get => _sectionJPrintExplanation; set => SetField(ref _sectionJPrintExplanation, value); }

        /// <summary>
        /// Declarations Section K Explanation [URLA.X226]
        /// </summary>
        public string? SectionKExplanation { get => _sectionKExplanation; set => SetField(ref _sectionKExplanation, value); }

        /// <summary>
        /// Print Section K explanation - Borrower [URLA.X258]
        /// </summary>
        public bool? SectionKPrintExplanation { get => _sectionKPrintExplanation; set => SetField(ref _sectionKPrintExplanation, value); }

        /// <summary>
        /// Declarations Section L Explanation [URLA.X227]
        /// </summary>
        public string? SectionLExplanation { get => _sectionLExplanation; set => SetField(ref _sectionLExplanation, value); }

        /// <summary>
        /// Print Section L explanation - Borrower [URLA.X259]
        /// </summary>
        public bool? SectionLPrintExplanation { get => _sectionLPrintExplanation; set => SetField(ref _sectionLPrintExplanation, value); }

        /// <summary>
        /// Declarations Section M Explanation [URLA.X228]
        /// </summary>
        public string? SectionMExplanation { get => _sectionMExplanation; set => SetField(ref _sectionMExplanation, value); }

        /// <summary>
        /// Print Section M explanation - Borrower [URLA.X260]
        /// </summary>
        public bool? SectionMPrintExplanation { get => _sectionMPrintExplanation; set => SetField(ref _sectionMPrintExplanation, value); }

        /// <summary>
        /// Borrower SelfDeclaredMilitaryServiceIndicator
        /// </summary>
        public bool? SelfDeclaredMilitaryServiceIndicator { get => _selfDeclaredMilitaryServiceIndicator; set => SetField(ref _selfDeclaredMilitaryServiceIndicator, value); }

        /// <summary>
        /// Borrower SelfEmployedValidationMessage
        /// </summary>
        public string? SelfEmployedValidationMessage { get => _selfEmployedValidationMessage; set => SetField(ref _selfEmployedValidationMessage, value); }

        /// <summary>
        /// Borrower SpecialBorrowerSellerRelationshipIndicator
        /// </summary>
        public bool? SpecialBorrowerSellerRelationshipIndicator { get => _specialBorrowerSellerRelationshipIndicator; set => SetField(ref _specialBorrowerSellerRelationshipIndicator, value); }

        /// <summary>
        /// Borrower SpousalVABenefitsEligibilityIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Surviving Spouse\"}")]
        public bool? SpousalVABenefitsEligibilityIndicator { get => _spousalVABenefitsEligibilityIndicator; set => SetField(ref _spousalVABenefitsEligibilityIndicator, value); }

        /// <summary>
        /// Borrower SSA89BackgroundCheckIndicator
        /// </summary>
        public bool? SSA89BackgroundCheckIndicator { get => _sSA89BackgroundCheckIndicator; set => SetField(ref _sSA89BackgroundCheckIndicator, value); }

        /// <summary>
        /// Borrower SSA89BankingServiceIndicator
        /// </summary>
        public bool? SSA89BankingServiceIndicator { get => _sSA89BankingServiceIndicator; set => SetField(ref _sSA89BankingServiceIndicator, value); }

        /// <summary>
        /// Borrower SSA89CreditCheckIndicator
        /// </summary>
        public bool? SSA89CreditCheckIndicator { get => _sSA89CreditCheckIndicator; set => SetField(ref _sSA89CreditCheckIndicator, value); }

        /// <summary>
        /// Borrower SSA89LicenseRequirementIndicator
        /// </summary>
        public bool? SSA89LicenseRequirementIndicator { get => _sSA89LicenseRequirementIndicator; set => SetField(ref _sSA89LicenseRequirementIndicator, value); }

        /// <summary>
        /// Borrower SSA89MortgageServiceIndicator
        /// </summary>
        public bool? SSA89MortgageServiceIndicator { get => _sSA89MortgageServiceIndicator; set => SetField(ref _sSA89MortgageServiceIndicator, value); }

        /// <summary>
        /// Borrower SSA89OtherIndicator
        /// </summary>
        public bool? SSA89OtherIndicator { get => _sSA89OtherIndicator; set => SetField(ref _sSA89OtherIndicator, value); }

        /// <summary>
        /// Borrower SSNValidationMessage
        /// </summary>
        public string? SSNValidationMessage { get => _sSNValidationMessage; set => SetField(ref _sSNValidationMessage, value); }

        /// <summary>
        /// Borrower State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Assets Subtotal Liquid Assets [915]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get => _subtotalLiquidAssetsMinusGiftAmount; set => SetField(ref _subtotalLiquidAssetsMinusGiftAmount, value); }

        /// <summary>
        /// Borrower SuffixToName
        /// </summary>
        public string? SuffixToName { get => _suffixToName; set => SetField(ref _suffixToName, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Investor [TQL.X7]
        /// </summary>
        public string? Tax4506LastInvestor { get => _tax4506LastInvestor; set => SetField(ref _tax4506LastInvestor, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Order Number [TQL.X6]
        /// </summary>
        public string? Tax4506LastOrderNumber { get => _tax4506LastOrderNumber; set => SetField(ref _tax4506LastOrderNumber, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 1 [TQL.X8]
        /// </summary>
        public int? Tax4506LastOrderYear1 { get => _tax4506LastOrderYear1; set => SetField(ref _tax4506LastOrderYear1, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 2 [TQL.X9]
        /// </summary>
        public int? Tax4506LastOrderYear2 { get => _tax4506LastOrderYear2; set => SetField(ref _tax4506LastOrderYear2, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 3 [TQL.X10]
        /// </summary>
        public int? Tax4506LastOrderYear3 { get => _tax4506LastOrderYear3; set => SetField(ref _tax4506LastOrderYear3, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 4 [TQL.X11]
        /// </summary>
        public int? Tax4506LastOrderYear4 { get => _tax4506LastOrderYear4; set => SetField(ref _tax4506LastOrderYear4, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Products Ordered [TQL.X12]
        /// </summary>
        public string? Tax4506LastProductsOrdered { get => _tax4506LastProductsOrdered; set => SetField(ref _tax4506LastProductsOrdered, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Status [TQL.X5]
        /// </summary>
        public string? Tax4506LastStatus { get => _tax4506LastStatus; set => SetField(ref _tax4506LastStatus, value); }

        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Transcript Type [TQL.X13]
        /// </summary>
        public string? Tax4506LastTranscriptType { get => _tax4506LastTranscriptType; set => SetField(ref _tax4506LastTranscriptType, value); }

        /// <summary>
        /// TQL - Coborrower 4506T Orders - Last User ID of Person Who Ordered 4506T [TQL.X26]
        /// </summary>
        public string? Tax4506LastUserIDWhoOrdered { get => _tax4506LastUserIDWhoOrdered; set => SetField(ref _tax4506LastUserIDWhoOrdered, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome1
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome1 { get => _tax4506TotalYearlyIncome1; set => SetField(ref _tax4506TotalYearlyIncome1, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome2 { get => _tax4506TotalYearlyIncome2; set => SetField(ref _tax4506TotalYearlyIncome2, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome3
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome3 { get => _tax4506TotalYearlyIncome3; set => SetField(ref _tax4506TotalYearlyIncome3, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome4
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome4 { get => _tax4506TotalYearlyIncome4; set => SetField(ref _tax4506TotalYearlyIncome4, value); }

        /// <summary>
        /// Income Year 1 Total Joint Income Borr and Co-Borrower [3327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyJointIncome1 { get => _tax4506TotalYearlyJointIncome1; set => SetField(ref _tax4506TotalYearlyJointIncome1, value); }

        /// <summary>
        /// Income Year 2 Total Joint Income Borr and Co-Borrower [3328]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyJointIncome2 { get => _tax4506TotalYearlyJointIncome2; set => SetField(ref _tax4506TotalYearlyJointIncome2, value); }

        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 3 Total Joint Income Borr and Co-Borrower [TQL.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyJointIncome3 { get => _tax4506TotalYearlyJointIncome3; set => SetField(ref _tax4506TotalYearlyJointIncome3, value); }

        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 4 Total Joint Income Borr and Co-Borrower [TQL.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyJointIncome4 { get => _tax4506TotalYearlyJointIncome4; set => SetField(ref _tax4506TotalYearlyJointIncome4, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome1
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get => _tax4506TotalYearlyVarianceIncome1; set => SetField(ref _tax4506TotalYearlyVarianceIncome1, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get => _tax4506TotalYearlyVarianceIncome2; set => SetField(ref _tax4506TotalYearlyVarianceIncome2, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome3
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get => _tax4506TotalYearlyVarianceIncome3; set => SetField(ref _tax4506TotalYearlyVarianceIncome3, value); }

        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome4
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get => _tax4506TotalYearlyVarianceIncome4; set => SetField(ref _tax4506TotalYearlyVarianceIncome4, value); }

        /// <summary>
        /// Income Year 1 Total Variance Joint Income Borr and Co-Borrower [3329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get => _tax4506TotalYearlyVarianceJointIncome1; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome1, value); }

        /// <summary>
        /// Income Year 2 Total Variance Joint Income Borr and Co-Borrower [3330]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get => _tax4506TotalYearlyVarianceJointIncome2; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome2, value); }

        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 3 Total Variance Joint Income Borr and Co-Borrower [TQL.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get => _tax4506TotalYearlyVarianceJointIncome3; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome3, value); }

        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 4 Total Variance Joint Income Borr and Co-Borrower [TQL.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get => _tax4506TotalYearlyVarianceJointIncome4; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome4, value); }

        /// <summary>
        /// Borrower TaxIdentificationIdentifier
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string? TaxIdentificationIdentifier { get => _taxIdentificationIdentifier; set => SetField(ref _taxIdentificationIdentifier, value); }

        /// <summary>
        /// Borrower TaxReturnValidationMessage
        /// </summary>
        public string? TaxReturnValidationMessage { get => _taxReturnValidationMessage; set => SetField(ref _taxReturnValidationMessage, value); }

        /// <summary>
        /// Total Additional Liabilities Amount [URLA.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalAdditionalLiabilitiesAmount { get => _totalAdditionalLiabilitiesAmount; set => SetField(ref _totalAdditionalLiabilitiesAmount, value); }

        /// <summary>
        /// Total Additional Other Liabilities Amount [URLA.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalAdditionalOtherLiabilitiesAmount { get => _totalAdditionalOtherLiabilitiesAmount; set => SetField(ref _totalAdditionalOtherLiabilitiesAmount, value); }

        /// <summary>
        /// Borrower TotalAnnualIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalAnnualIncome { get => _totalAnnualIncome; set => SetField(ref _totalAnnualIncome, value); }

        /// <summary>
        /// Borrower TotalAssets
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalAssets { get => _totalAssets; set => SetField(ref _totalAssets, value); }

        /// <summary>
        /// Borrower TotalGrossMonthlySalary
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalGrossMonthlySalary { get => _totalGrossMonthlySalary; set => SetField(ref _totalGrossMonthlySalary, value); }

        /// <summary>
        /// Total Liabilities Amount [URLA.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalLiabilitiesAmount { get => _totalLiabilitiesAmount; set => SetField(ref _totalLiabilitiesAmount, value); }

        /// <summary>
        /// Liabilities Total Liability Balance [733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalLiabilitiesBalanceAmount { get => _totalLiabilitiesBalanceAmount; set => SetField(ref _totalLiabilitiesBalanceAmount, value); }

        /// <summary>
        /// Borrower TotalMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMonthlyIncomeAmount { get => _totalMonthlyIncomeAmount; set => SetField(ref _totalMonthlyIncomeAmount, value); }

        /// <summary>
        /// Borrower TotalMonthlyIncomeMinusNetRentalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get => _totalMonthlyIncomeMinusNetRentalAmount; set => SetField(ref _totalMonthlyIncomeMinusNetRentalAmount, value); }

        /// <summary>
        /// Borrower TotalOtherAssets
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherAssets { get => _totalOtherAssets; set => SetField(ref _totalOtherAssets, value); }

        /// <summary>
        /// Borrower TotalOtherIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherIncome { get => _totalOtherIncome; set => SetField(ref _totalOtherIncome, value); }

        /// <summary>
        /// Borrower TotalOtherLiabilities
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherLiabilities { get => _totalOtherLiabilities; set => SetField(ref _totalOtherLiabilities, value); }

        /// <summary>
        /// Total Other Liabilities Amount [URLA.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherLiabilitiesAmount { get => _totalOtherLiabilitiesAmount; set => SetField(ref _totalOtherLiabilitiesAmount, value); }

        /// <summary>
        /// Borrower TotalOtherMonthlyLiability
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalOtherMonthlyLiability { get => _totalOtherMonthlyLiability; set => SetField(ref _totalOtherMonthlyLiability, value); }

        /// <summary>
        /// Expenses Present Total Housing [737]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPresentHousingExpenseAmount { get => _totalPresentHousingExpenseAmount; set => SetField(ref _totalPresentHousingExpenseAmount, value); }

        /// <summary>
        /// Borrower TransactionPurposeDescription
        /// </summary>
        public string? TransactionPurposeDescription { get => _transactionPurposeDescription; set => SetField(ref _transactionPurposeDescription, value); }

        /// <summary>
        /// Underwriting Trans Union 120 Days [2331]
        /// </summary>
        public int? TransUnion120Days { get => _transUnion120Days; set => SetField(ref _transUnion120Days, value); }

        /// <summary>
        /// Underwriting Trans Union 150 Days [2556]
        /// </summary>
        public int? TransUnion150Days { get => _transUnion150Days; set => SetField(ref _transUnion150Days, value); }

        /// <summary>
        /// Underwriting Trans Union 30 Days [2328]
        /// </summary>
        public int? TransUnion30Days { get => _transUnion30Days; set => SetField(ref _transUnion30Days, value); }

        /// <summary>
        /// Underwriting Trans Union 60 Days [2329]
        /// </summary>
        public int? TransUnion60Days { get => _transUnion60Days; set => SetField(ref _transUnion60Days, value); }

        /// <summary>
        /// Underwriting Trans Union 90 Days [2330]
        /// </summary>
        public int? TransUnion90Days { get => _transUnion90Days; set => SetField(ref _transUnion90Days, value); }

        /// <summary>
        /// Borrower TransUnionCreditScoreForDisclosure
        /// </summary>
        public bool? TransUnionCreditScoreForDisclosure { get => _transUnionCreditScoreForDisclosure; set => SetField(ref _transUnionCreditScoreForDisclosure, value); }

        /// <summary>
        /// Borrower TransUnionCreditScoreRanksPercent
        /// </summary>
        public int? TransUnionCreditScoreRanksPercent { get => _transUnionCreditScoreRanksPercent; set => SetField(ref _transUnionCreditScoreRanksPercent, value); }

        /// <summary>
        /// Borrower TransUnionDatePulled
        /// </summary>
        public DateTime? TransUnionDatePulled { get => _transUnionDatePulled; set => SetField(ref _transUnionDatePulled, value); }

        /// <summary>
        /// Borrower TransUnionFactorCode1
        /// </summary>
        public string? TransUnionFactorCode1 { get => _transUnionFactorCode1; set => SetField(ref _transUnionFactorCode1, value); }

        /// <summary>
        /// Borrower TransUnionFactorCode2
        /// </summary>
        public string? TransUnionFactorCode2 { get => _transUnionFactorCode2; set => SetField(ref _transUnionFactorCode2, value); }

        /// <summary>
        /// Borrower TransUnionFactorCode3
        /// </summary>
        public string? TransUnionFactorCode3 { get => _transUnionFactorCode3; set => SetField(ref _transUnionFactorCode3, value); }

        /// <summary>
        /// Borrower TransUnionFactorCode4
        /// </summary>
        public string? TransUnionFactorCode4 { get => _transUnionFactorCode4; set => SetField(ref _transUnionFactorCode4, value); }

        /// <summary>
        /// Borrower TransUnionFactorCode5
        /// </summary>
        public string? TransUnionFactorCode5 { get => _transUnionFactorCode5; set => SetField(ref _transUnionFactorCode5, value); }

        /// <summary>
        /// Borrower TransUnionKeyFactor1
        /// </summary>
        public string? TransUnionKeyFactor1 { get => _transUnionKeyFactor1; set => SetField(ref _transUnionKeyFactor1, value); }

        /// <summary>
        /// Borrower TransUnionKeyFactor2
        /// </summary>
        public string? TransUnionKeyFactor2 { get => _transUnionKeyFactor2; set => SetField(ref _transUnionKeyFactor2, value); }

        /// <summary>
        /// Borrower TransUnionKeyFactor3
        /// </summary>
        public string? TransUnionKeyFactor3 { get => _transUnionKeyFactor3; set => SetField(ref _transUnionKeyFactor3, value); }

        /// <summary>
        /// Borrower TransUnionKeyFactor4
        /// </summary>
        public string? TransUnionKeyFactor4 { get => _transUnionKeyFactor4; set => SetField(ref _transUnionKeyFactor4, value); }

        /// <summary>
        /// Borrower TransUnionKeyFactor5
        /// </summary>
        public string? TransUnionKeyFactor5 { get => _transUnionKeyFactor5; set => SetField(ref _transUnionKeyFactor5, value); }

        /// <summary>
        /// Borrower TransUnionMaterialTermsCreditByScore
        /// </summary>
        public bool? TransUnionMaterialTermsCreditByScore { get => _transUnionMaterialTermsCreditByScore; set => SetField(ref _transUnionMaterialTermsCreditByScore, value); }

        /// <summary>
        /// Borrower TransUnionScore
        /// </summary>
        public string? TransUnionScore { get => _transUnionScore; set => SetField(ref _transUnionScore, value); }

        /// <summary>
        /// Borrower UndisclosedBorrowedFundsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UndisclosedBorrowedFundsAmount { get => _undisclosedBorrowedFundsAmount; set => SetField(ref _undisclosedBorrowedFundsAmount, value); }

        /// <summary>
        /// Borrower UndisclosedBorrowedFundsIndicator
        /// </summary>
        public bool? UndisclosedBorrowedFundsIndicator { get => _undisclosedBorrowedFundsIndicator; set => SetField(ref _undisclosedBorrowedFundsIndicator, value); }

        /// <summary>
        /// Borrower UndisclosedComakerOfNoteIndicator
        /// </summary>
        public bool? UndisclosedComakerOfNoteIndicator { get => _undisclosedComakerOfNoteIndicator; set => SetField(ref _undisclosedComakerOfNoteIndicator, value); }

        /// <summary>
        /// Borrower UndisclosedCreditApplicationIndicator
        /// </summary>
        public bool? UndisclosedCreditApplicationIndicator { get => _undisclosedCreditApplicationIndicator; set => SetField(ref _undisclosedCreditApplicationIndicator, value); }

        /// <summary>
        /// Borrower UndisclosedMortgageApplicationIndicator
        /// </summary>
        public bool? UndisclosedMortgageApplicationIndicator { get => _undisclosedMortgageApplicationIndicator; set => SetField(ref _undisclosedMortgageApplicationIndicator, value); }

        /// <summary>
        /// Borrower Urla2020CitizenshipResidencyType
        /// </summary>
        public StringEnumValue<Urla2020CitizenshipResidencyType> Urla2020CitizenshipResidencyType { get => _urla2020CitizenshipResidencyType; set => SetField(ref _urla2020CitizenshipResidencyType, value); }

        /// <summary>
        /// Borrower Urla2020CountryOfCitizenship
        /// </summary>
        public string? Urla2020CountryOfCitizenship { get => _urla2020CountryOfCitizenship; set => SetField(ref _urla2020CountryOfCitizenship, value); }

        /// <summary>
        /// Borrower URLAAliasName
        /// </summary>
        public string? URLAAliasName { get => _uRLAAliasName; set => SetField(ref _uRLAAliasName, value); }

        /// <summary>
        /// Borrower UserDefinedIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => SetField(ref _userDefinedIncome, value); }

        /// <summary>
        /// Borrower VaFederalTaxAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaFederalTaxAmount { get => _vaFederalTaxAmount; set => SetField(ref _vaFederalTaxAmount, value); }

        /// <summary>
        /// Borrower ValidDaysForConsentCount
        /// </summary>
        public int? ValidDaysForConsentCount { get => _validDaysForConsentCount; set => SetField(ref _validDaysForConsentCount, value); }

        /// <summary>
        /// Borrower ValueRepAndWarrantyAvailable
        /// </summary>
        public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => SetField(ref _valueRepAndWarrantyAvailable, value); }

        /// <summary>
        /// Borrower ValueRepAndWarrantyMessage
        /// </summary>
        public string? ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => SetField(ref _valueRepAndWarrantyMessage, value); }

        /// <summary>
        /// Borrower VaNetTakeHomePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaNetTakeHomePayAmount { get => _vaNetTakeHomePayAmount; set => SetField(ref _vaNetTakeHomePayAmount, value); }

        /// <summary>
        /// Borrower VaOtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaOtherAmount { get => _vaOtherAmount; set => SetField(ref _vaOtherAmount, value); }

        /// <summary>
        /// Borrower VaOtherNetIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaOtherNetIncomeAmount { get => _vaOtherNetIncomeAmount; set => SetField(ref _vaOtherNetIncomeAmount, value); }

        /// <summary>
        /// Borrower VaRetirementAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaRetirementAmount { get => _vaRetirementAmount; set => SetField(ref _vaRetirementAmount, value); }

        /// <summary>
        /// Borrower VaStateTaxAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaStateTaxAmount { get => _vaStateTaxAmount; set => SetField(ref _vaStateTaxAmount, value); }

        /// <summary>
        /// Borrower VaTotalIncomeDeductionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaTotalIncomeDeductionsAmount { get => _vaTotalIncomeDeductionsAmount; set => SetField(ref _vaTotalIncomeDeductionsAmount, value); }

        /// <summary>
        /// Borrower VaTotalNetIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaTotalNetIncomeAmount { get => _vaTotalNetIncomeAmount; set => SetField(ref _vaTotalNetIncomeAmount, value); }

        /// <summary>
        /// Borrower Vendor1
        /// </summary>
        public string? Vendor1 { get => _vendor1; set => SetField(ref _vendor1, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Inco-Check (Bor,CoBor) [GSEVENDOR.X17]
        /// </summary>
        public string? Vendor10 { get => _vendor10; set => SetField(ref _vendor10, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Meridian Link (Bor,CoBor) [GSEVENDOR.X18]
        /// </summary>
        public string? Vendor11 { get => _vendor11; set => SetField(ref _vendor11, value); }

        /// <summary>
        /// GSE Vendor Provider Data - NCS (Bor,CoBor) [GSEVENDOR.X19]
        /// </summary>
        public string? Vendor12 { get => _vendor12; set => SetField(ref _vendor12, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Plaid (Bor,CoBor) [GSEVENDOR.X20]
        /// </summary>
        public string? Vendor13 { get => _vendor13; set => SetField(ref _vendor13, value); }

        /// <summary>
        /// GSE Vendor Provider Data - PointServ (VOE/VOI/4506T/Asset) (Bor,CoBor) [GSEVENDOR.X21]
        /// </summary>
        public string? Vendor14 { get => _vendor14; set => SetField(ref _vendor14, value); }

        /// <summary>
        /// GSE Vendor Provider Data - SharperLending (Bor,CoBor) [GSEVENDOR.X22]
        /// </summary>
        public string? Vendor15 { get => _vendor15; set => SetField(ref _vendor15, value); }

        /// <summary>
        /// GSE Vendor Provider Data - VeriTax (Bor,CoBor) [GSEVENDOR.X23]
        /// </summary>
        public string? Vendor16 { get => _vendor16; set => SetField(ref _vendor16, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Yodlee (Bor,CoBor) [GSEVENDOR.X24]
        /// </summary>
        public string? Vendor17 { get => _vendor17; set => SetField(ref _vendor17, value); }

        /// <summary>
        /// GSE Vendor Provider Data - BankVOD (Bor,CoBor) [GSEVENDOR.X25]
        /// </summary>
        public string? Vendor18 { get => _vendor18; set => SetField(ref _vendor18, value); }

        /// <summary>
        /// GSE Vendor Provider Data - LendSnap (Bor,CoBor) [GSEVENDOR.X26]
        /// </summary>
        public string? Vendor19 { get => _vendor19; set => SetField(ref _vendor19, value); }

        /// <summary>
        /// Borrower Vendor2
        /// </summary>
        public string? Vendor2 { get => _vendor2; set => SetField(ref _vendor2, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Quovo (Bor,CoBor) [GSEVENDOR.X27]
        /// </summary>
        public string? Vendor20 { get => _vendor20; set => SetField(ref _vendor20, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Roostify (Bor,CoBor) [GSEVENDOR.X28]
        /// </summary>
        public string? Vendor21 { get => _vendor21; set => SetField(ref _vendor21, value); }

        /// <summary>
        /// GSE Vendor Provider Data - CoreLogic (VOE/VOI) (Bor,CoBor) [GSEVENDOR.X29]
        /// </summary>
        public string? Vendor22 { get => _vendor22; set => SetField(ref _vendor22, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Advanced Data (4506-T, VOE, VOI) (Bor,CoBor) [GSEVENDOR.X30]
        /// </summary>
        public string? Vendor23 { get => _vendor23; set => SetField(ref _vendor23, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Partners Credit (IncomeVerify) (Bor,CoBor) [GSEVENDOR.X31]
        /// </summary>
        public string? Vendor24 { get => _vendor24; set => SetField(ref _vendor24, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Taxdoor 4506-T Service (Chronos) (Bor,CoBor) [GSEVENDOR.X32]
        /// </summary>
        public string? Vendor25 { get => _vendor25; set => SetField(ref _vendor25, value); }

        /// <summary>
        /// GSE Vendor Provider Data - ComplianceEase IRS Tax Transcript (Bor,CoBor) [GSEVENDOR.X33]
        /// </summary>
        public string? Vendor26 { get => _vendor26; set => SetField(ref _vendor26, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Private Eyes (4506-Transcripts.com) (Bor,CoBor) [GSEVENDOR.X34]
        /// </summary>
        public string? Vendor27 { get => _vendor27; set => SetField(ref _vendor27, value); }

        /// <summary>
        /// GSE Vendor Provider Data - BankVOD IRS (Bor,CoBor) [GSEVENDOR.X35]
        /// </summary>
        public string? Vendor28 { get => _vendor28; set => SetField(ref _vendor28, value); }

        /// <summary>
        /// GSE Vendor Provider Data - QuestSoft (Bor,CoBor) [GSEVENDOR.X36]
        /// </summary>
        public string? Vendor29 { get => _vendor29; set => SetField(ref _vendor29, value); }

        /// <summary>
        /// Borrower Vendor3
        /// </summary>
        public string? Vendor3 { get => _vendor3; set => SetField(ref _vendor3, value); }

        /// <summary>
        /// Borrower Vendor30
        /// </summary>
        public string? Vendor30 { get => _vendor30; set => SetField(ref _vendor30, value); }

        /// <summary>
        /// Borrower Vendor31
        /// </summary>
        public string? Vendor31 { get => _vendor31; set => SetField(ref _vendor31, value); }

        /// <summary>
        /// Borrower Vendor32
        /// </summary>
        public string? Vendor32 { get => _vendor32; set => SetField(ref _vendor32, value); }

        /// <summary>
        /// Borrower Vendor33
        /// </summary>
        public string? Vendor33 { get => _vendor33; set => SetField(ref _vendor33, value); }

        /// <summary>
        /// Borrower Vendor34
        /// </summary>
        public string? Vendor34 { get => _vendor34; set => SetField(ref _vendor34, value); }

        /// <summary>
        /// Borrower Vendor35
        /// </summary>
        public string? Vendor35 { get => _vendor35; set => SetField(ref _vendor35, value); }

        /// <summary>
        /// Borrower Vendor36
        /// </summary>
        public string? Vendor36 { get => _vendor36; set => SetField(ref _vendor36, value); }

        /// <summary>
        /// Borrower Vendor37
        /// </summary>
        public string? Vendor37 { get => _vendor37; set => SetField(ref _vendor37, value); }

        /// <summary>
        /// Borrower Vendor38
        /// </summary>
        public string? Vendor38 { get => _vendor38; set => SetField(ref _vendor38, value); }

        /// <summary>
        /// Borrower Vendor39
        /// </summary>
        public string? Vendor39 { get => _vendor39; set => SetField(ref _vendor39, value); }

        /// <summary>
        /// Borrower Vendor4
        /// </summary>
        public string? Vendor4 { get => _vendor4; set => SetField(ref _vendor4, value); }

        /// <summary>
        /// Borrower Vendor40
        /// </summary>
        public string? Vendor40 { get => _vendor40; set => SetField(ref _vendor40, value); }

        /// <summary>
        /// Borrower Vendor5
        /// </summary>
        public string? Vendor5 { get => _vendor5; set => SetField(ref _vendor5, value); }

        /// <summary>
        /// Borrower Vendor6
        /// </summary>
        public string? Vendor6 { get => _vendor6; set => SetField(ref _vendor6, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Corvius (Bor,CoBor) [GSEVENDOR.X14]
        /// </summary>
        public string? Vendor7 { get => _vendor7; set => SetField(ref _vendor7, value); }

        /// <summary>
        /// GSE Vendor Provider Data - Finlocker (Bor,CoBor) [GSEVENDOR.X15]
        /// </summary>
        public string? Vendor8 { get => _vendor8; set => SetField(ref _vendor8, value); }

        /// <summary>
        /// GSE Vendor Provider Data - FirstAmerican (Bor,CoBor) [GSEVENDOR.X16]
        /// </summary>
        public string? Vendor9 { get => _vendor9; set => SetField(ref _vendor9, value); }

        /// <summary>
        /// Borrower VestingTrusteeOfType
        /// </summary>
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => SetField(ref _vestingTrusteeOfType, value); }

        /// <summary>
        /// Borrower Veteran
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently retired, discharged, or separated from service\"}")]
        public bool? Veteran { get => _veteran; set => SetField(ref _veteran, value); }

        /// <summary>
        /// Borrower VeteranIndicator
        /// </summary>
        public bool? VeteranIndicator { get => _veteranIndicator; set => SetField(ref _veteranIndicator, value); }

        /// <summary>
        /// Borrower VvoeWorkNumberDate
        /// </summary>
        public DateTime? VvoeWorkNumberDate { get => _vvoeWorkNumberDate; set => SetField(ref _vvoeWorkNumberDate, value); }

        /// <summary>
        /// Borrower WorkEmailAddress
        /// </summary>
        public string? WorkEmailAddress { get => _workEmailAddress; set => SetField(ref _workEmailAddress, value); }

        /// <summary>
        /// Borrower WorkPhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? WorkPhoneNumber { get => _workPhoneNumber; set => SetField(ref _workPhoneNumber, value); }

        /// <summary>
        /// Underwriting Years of Credit on File [2565]
        /// </summary>
        public int? YearsofCreditOnFile { get => _yearsofCreditOnFile; set => SetField(ref _yearsofCreditOnFile, value); }
    }
}