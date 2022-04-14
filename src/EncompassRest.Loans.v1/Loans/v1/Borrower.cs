using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

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
    private DirtyValue<decimal?>? _bottomRatioPercent;
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
    private DirtyValue<StringEnumValue<FreddieBorrowerAlienStatus>>? _freddieAlienStatus;
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
    private DirtyValue<DateTime?>? _rwtFannieVoe1Date;
    private DirtyValue<string?>? _rwtFannieVoe1Description;
    private DirtyValue<DateTime?>? _rwtFannieVoe2Date;
    private DirtyValue<string?>? _rwtFannieVoe2Description;
    private DirtyValue<string?>? _rwtFannieVoe2Message;
    private DirtyValue<string?>? _rwtFannieVoe2Status;
    private DirtyValue<DateTime?>? _rwtFannieVoe3Date;
    private DirtyValue<string?>? _rwtFannieVoe3Description;
    private DirtyValue<string?>? _rwtFannieVoe3Message;
    private DirtyValue<string?>? _rwtFannieVoe3Status;
    private DirtyValue<DateTime?>? _rwtFannieVoiBaseIncomeDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiBonusDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiCommissionDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiOvertimeDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiRetirementDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiSelfEmployedDate;
    private DirtyValue<DateTime?>? _rwtFannieVoiSocialSecurityDate;
    private DirtyValue<DateTime?>? _rwtFreddieVoe1Date;
    private DirtyValue<string?>? _rwtFreddieVoe1Description;
    private DirtyValue<string?>? _rwtFreddieVoe1Message;
    private DirtyValue<string?>? _rwtFreddieVoe1Status;
    private DirtyValue<DateTime?>? _rwtFreddieVoe2Date;
    private DirtyValue<string?>? _rwtFreddieVoe2Description;
    private DirtyValue<string?>? _rwtFreddieVoe2Message;
    private DirtyValue<string?>? _rwtFreddieVoe2Status;
    private DirtyValue<DateTime?>? _rwtFreddieVoe3Date;
    private DirtyValue<string?>? _rwtFreddieVoe3Description;
    private DirtyValue<string?>? _rwtFreddieVoe3Message;
    private DirtyValue<string?>? _rwtFreddieVoe3Status;
    private DirtyValue<DateTime?>? _rwtFreddieVoiChildSupportDate;
    private DirtyValue<string?>? _rwtFreddieVoiChildSupportMessage;
    private DirtyValue<string?>? _rwtFreddieVoiChildSupportStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiMilitaryDate;
    private DirtyValue<string?>? _rwtFreddieVoiMilitaryMessage;
    private DirtyValue<string?>? _rwtFreddieVoiMilitaryStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiPayrollDate;
    private DirtyValue<string?>? _rwtFreddieVoiPayrollMessage;
    private DirtyValue<string?>? _rwtFreddieVoiPayrollStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiPensionDate;
    private DirtyValue<string?>? _rwtFreddieVoiPensionMessage;
    private DirtyValue<string?>? _rwtFreddieVoiPensionStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiSelfEmployedDate;
    private DirtyValue<string?>? _rwtFreddieVoiSelfEmployedMessage;
    private DirtyValue<string?>? _rwtFreddieVoiSelfEmployedStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiSocialSecurityDate;
    private DirtyValue<string?>? _rwtFreddieVoiSocialSecurityMessage;
    private DirtyValue<string?>? _rwtFreddieVoiSocialSecurityStatus;
    private DirtyValue<DateTime?>? _rwtFreddieVoiVaBenefitsDate;
    private DirtyValue<string?>? _rwtFreddieVoiVaBenefitsMessage;
    private DirtyValue<string?>? _rwtFreddieVoiVaBenefitsStatus;
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
    private DirtyValue<bool?>? _sSA89ApplyForLoan;
    private DirtyValue<bool?>? _sSA89BackgroundCheckIndicator;
    private DirtyValue<bool?>? _sSA89BankingServiceIndicator;
    private DirtyValue<bool?>? _sSA89CreditCheckIndicator;
    private DirtyValue<string?>? _sSA89DescriptionForOther;
    private DirtyValue<bool?>? _sSA89LicenseRequirementIndicator;
    private DirtyValue<bool?>? _sSA89MortgageServiceIndicator;
    private DirtyValue<bool?>? _sSA89OpenRetirementAcct;
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
    private DirtyValue<decimal?>? _topRatioPercent;
    private DirtyValue<decimal?>? _totalAdditionalLiabilitiesAmount;
    private DirtyValue<decimal?>? _totalAdditionalOtherLiabilitiesAmount;
    private DirtyValue<decimal?>? _totalAnnualIncome;
    private DirtyValue<decimal?>? _totalAssets;
    private DirtyValue<decimal?>? _totalGrossMonthlyIncomeAmount;
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
    /// Borrower AcountChekAssetId [FANNIESERVICE.X3], [FANNIESERVICE.X4]
    /// </summary>
    public string? AcountChekAssetId { get => _acountChekAssetId; set => SetField(ref _acountChekAssetId, value); }

    /// <summary>
    /// Borrower ActiveDuty [URLA.X123], [URLA.X126]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently serving on active duty\"}")]
    public bool? ActiveDuty { get => _activeDuty; set => SetField(ref _activeDuty, value); }

    /// <summary>
    /// Borrower AdditionalEmploymentDoesNotApply [URLA.X201], [URLA.X202]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? AdditionalEmploymentDoesNotApply { get => _additionalEmploymentDoesNotApply; set => SetField(ref _additionalEmploymentDoesNotApply, value); }

    /// <summary>
    /// USDA - Additional Income to Primary Employment (Commission, Bonus, Overtime, Automobile Allowance, Mortgage Differential, Tips, Military, Secondary Employment, Seasonal Employment, Unemployment) [USDA.X168]
    /// </summary>
    public decimal? AdditionalIncomeFromPrimaryEmployment { get => _additionalIncomeFromPrimaryEmployment; set => SetField(ref _additionalIncomeFromPrimaryEmployment, value); }

    /// <summary>
    /// Borrower AdditionalInformation [URLA.X213], [URLA.X214]
    /// </summary>
    public string? AdditionalInformation { get => _additionalInformation; set => SetField(ref _additionalInformation, value); }

    /// <summary>
    /// Borrower AdditionalOtherIncome [URLA.X42], [URLA.X43]
    /// </summary>
    public decimal? AdditionalOtherIncome { get => _additionalOtherIncome; set => SetField(ref _additionalOtherIncome, value); }

    /// <summary>
    /// USDA - Adjusted Annual income for the household [USDA.X17]
    /// </summary>
    public decimal? AdjustedAnnualIncome { get => _adjustedAnnualIncome; set => SetField(ref _adjustedAnnualIncome, value); }

    /// <summary>
    /// Borrower AgeAtApplicationYearsCount [38], [70]
    /// </summary>
    public int? AgeAtApplicationYearsCount { get => _ageAtApplicationYearsCount; set => SetField(ref _ageAtApplicationYearsCount, value); }

    /// <summary>
    /// Borrower AliasName [1869], [1874]
    /// </summary>
    public string? AliasName { get => _aliasName; set => SetField(ref _aliasName, value); }

    /// <summary>
    /// Borrower AlimonyChildSupportObligationIndicator [173], [179]
    /// </summary>
    public bool? AlimonyChildSupportObligationIndicator { get => _alimonyChildSupportObligationIndicator; set => SetField(ref _alimonyChildSupportObligationIndicator, value); }

    /// <summary>
    /// Borrower AltId
    /// </summary>
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// USDA - Annual income for the household [USDA.X16]
    /// </summary>
    public decimal? AnnualIncome { get => _annualIncome; set => SetField(ref _annualIncome, value); }

    /// <summary>
    /// Borrower ApplicantType
    /// </summary>
    public string? ApplicantType { get => _applicantType; set => SetField(ref _applicantType, value); }

    /// <summary>
    /// Borrower ApplicationTakenMethodType [4143], [4131]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"FaceToFace\":\"Face-to-Face Interview\"}")]
    public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => SetField(ref _applicationTakenMethodType, value); }

    /// <summary>
    /// USDA - Asset Income (Income from household assets as described in 1980.347(d) of RD Instruction 1980-D) [USDA.X170]
    /// </summary>
    public decimal? AssetIncome { get => _assetIncome; set => SetField(ref _assetIncome, value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Asset Validation Message [MORNET.X114]
    /// </summary>
    public string? AssetRepAndWarrantyMessage { get => _assetRepAndWarrantyMessage; set => SetField(ref _assetRepAndWarrantyMessage, value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Asset Validation [MORNET.X117]
    /// </summary>
    public bool? AssetRepAndWarrantyReliefAvailable { get => _assetRepAndWarrantyReliefAvailable; set => SetField(ref _assetRepAndWarrantyReliefAvailable, value); }

    /// <summary>
    /// Borrower AuthorizedCreditReportIndicator [4073], [4076]
    /// </summary>
    public bool? AuthorizedCreditReportIndicator { get => _authorizedCreditReportIndicator; set => SetField(ref _authorizedCreditReportIndicator, value); }

    /// <summary>
    /// Borrower AuthorizedToSignIndicator [2968], [2969]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Authorized to Sign\"}")]
    public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => SetField(ref _authorizedToSignIndicator, value); }

    /// <summary>
    /// Borrower BankAccountNumber [CAPIAP.X122], [CAPIAP.X129]
    /// </summary>
    public string? BankAccountNumber { get => _bankAccountNumber; set => SetField(ref _bankAccountNumber, value); }

    /// <summary>
    /// Borrower BankAccountType [CAPIAP.X120], [CAPIAP.X127]
    /// </summary>
    public StringEnumValue<BankAccountType> BankAccountType { get => _bankAccountType; set => SetField(ref _bankAccountType, value); }

    /// <summary>
    /// Borrower BankContactAddress [CAPIAP.X123], [CAPIAP.X130]
    /// </summary>
    public string? BankContactAddress { get => _bankContactAddress; set => SetField(ref _bankContactAddress, value); }

    /// <summary>
    /// Borrower BankContactCity [CAPIAP.X124], [CAPIAP.X131]
    /// </summary>
    public string? BankContactCity { get => _bankContactCity; set => SetField(ref _bankContactCity, value); }

    /// <summary>
    /// Borrower BankContactName [CAPIAP.X121], [CAPIAP.X128]
    /// </summary>
    public string? BankContactName { get => _bankContactName; set => SetField(ref _bankContactName, value); }

    /// <summary>
    /// Borrower BankContactPostalCode [CAPIAP.X126], [CAPIAP.X133]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? BankContactPostalCode { get => _bankContactPostalCode; set => SetField(ref _bankContactPostalCode, value); }

    /// <summary>
    /// Borrower BankContactState [CAPIAP.X125], [CAPIAP.X132]
    /// </summary>
    public StringEnumValue<State> BankContactState { get => _bankContactState; set => SetField(ref _bankContactState, value); }

    /// <summary>
    /// Borrower BankruptcyIndicator [265], [266]
    /// </summary>
    public bool? BankruptcyIndicator { get => _bankruptcyIndicator; set => SetField(ref _bankruptcyIndicator, value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterEleven [URLA.X175], [URLA.X179]
    /// </summary>
    public bool? BankruptcyIndicatorChapterEleven { get => _bankruptcyIndicatorChapterEleven; set => SetField(ref _bankruptcyIndicatorChapterEleven, value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterSeven [URLA.X174], [URLA.X178]
    /// </summary>
    public bool? BankruptcyIndicatorChapterSeven { get => _bankruptcyIndicatorChapterSeven; set => SetField(ref _bankruptcyIndicatorChapterSeven, value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterThirteen [URLA.X177], [URLA.X181]
    /// </summary>
    public bool? BankruptcyIndicatorChapterThirteen { get => _bankruptcyIndicatorChapterThirteen; set => SetField(ref _bankruptcyIndicatorChapterThirteen, value); }

    /// <summary>
    /// Borrower BankruptcyIndicatorChapterTwelve [URLA.X176], [URLA.X180]
    /// </summary>
    public bool? BankruptcyIndicatorChapterTwelve { get => _bankruptcyIndicatorChapterTwelve; set => SetField(ref _bankruptcyIndicatorChapterTwelve, value); }

    /// <summary>
    /// Underwriting Bankruptcy Status [2570]
    /// </summary>
    public StringEnumValue<BankruptcyForeclosureStatus> BankruptcyStatus { get => _bankruptcyStatus; set => SetField(ref _bankruptcyStatus, value); }

    /// <summary>
    /// Borrower BaseIncome [USDA.X164], [USDA.X165]
    /// </summary>
    public decimal? BaseIncome { get => _baseIncome; set => SetField(ref _baseIncome, value); }

    /// <summary>
    /// Borrower BaseIncomeValidationMessage [MORNET.X132], [MORNET.X144]
    /// </summary>
    public string? BaseIncomeValidationMessage { get => _baseIncomeValidationMessage; set => SetField(ref _baseIncomeValidationMessage, value); }

    /// <summary>
    /// Borrower BaseMonthlyIncomeAmount [1088], [1089]
    /// </summary>
    public decimal? BaseMonthlyIncomeAmount { get => _baseMonthlyIncomeAmount; set => SetField(ref _baseMonthlyIncomeAmount, value); }

    /// <summary>
    /// Borrower BirthDate [1402], [1403]
    /// </summary>
    public DateTime? BirthDate { get => _birthDate; set => SetField(ref _birthDate, value); }

    /// <summary>
    /// Borrower BonusValidationMessage [MORNET.X133], [MORNET.X145]
    /// </summary>
    public string? BonusValidationMessage { get => _bonusValidationMessage; set => SetField(ref _bonusValidationMessage, value); }

    /// <summary>
    /// Borrower BorrowedDownPaymentIndicator [174], [180]
    /// </summary>
    public bool? BorrowedDownPaymentIndicator { get => _borrowedDownPaymentIndicator; set => SetField(ref _borrowedDownPaymentIndicator, value); }

    /// <summary>
    /// Borrower BorrowerConsentRequestDate [4108], [4109]
    /// </summary>
    public DateTime? BorrowerConsentRequestDate { get => _borrowerConsentRequestDate; set => SetField(ref _borrowerConsentRequestDate, value); }

    /// <summary>
    /// Borrower BorrowerIndex
    /// </summary>
    public int? BorrowerIndex { get => _borrowerIndex; set => SetField(ref _borrowerIndex, value); }

    /// <summary>
    /// Borrower BorrowerType [1871], [1876]
    /// </summary>
    public StringEnumValue<BorrowerType> BorrowerType { get => _borrowerType; set => SetField(ref _borrowerType, value); }

    /// <summary>
    /// Borrower BorrowerTypeInSummary [4008], [4009]
    /// </summary>
    public StringEnumValue<BorrowerType> BorrowerTypeInSummary { get => _borrowerTypeInSummary; set => SetField(ref _borrowerTypeInSummary, value); }

    /// <summary>
    /// Fannie Mae Bottom Ratio [MORNET.X159]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? BottomRatioPercent { get => _bottomRatioPercent; set => SetField(ref _bottomRatioPercent, value); }

    /// <summary>
    /// Borrower CaivrsIdentifier [1018], [1144]
    /// </summary>
    public string? CaivrsIdentifier { get => _caivrsIdentifier; set => SetField(ref _caivrsIdentifier, value); }

    /// <summary>
    /// Borrower CdDeliveryMethod [CORRESPONDENT.X388], [CORRESPONDENT.X389]
    /// </summary>
    public string? CdDeliveryMethod { get => _cdDeliveryMethod; set => SetField(ref _cdDeliveryMethod, value); }

    /// <summary>
    /// Borrower CitizenshipResidencyType [BORCIT], [COBORCIT]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CitizenshipResidencyType { get => _citizenshipResidencyType; set => SetField(ref _citizenshipResidencyType, value); }

    /// <summary>
    /// CoBorrower Attended Same Counseling [URLA.X215]
    /// </summary>
    public bool? CoBorrAttendedSameCounselingIndicator { get => _coBorrAttendedSameCounselingIndicator; set => SetField(ref _coBorrAttendedSameCounselingIndicator, value); }

    /// <summary>
    /// Borrower CoMakerEndorserOfNoteIndicator [171], [177]
    /// </summary>
    public bool? CoMakerEndorserOfNoteIndicator { get => _coMakerEndorserOfNoteIndicator; set => SetField(ref _coMakerEndorserOfNoteIndicator, value); }

    /// <summary>
    /// Credit Report Comment [4079]
    /// </summary>
    public string? CommentOfCreditReport { get => _commentOfCreditReport; set => SetField(ref _commentOfCreditReport, value); }

    /// <summary>
    /// Borrower CommissionValidationMessage [MORNET.X135], [MORNET.X147]
    /// </summary>
    public string? CommissionValidationMessage { get => _commissionValidationMessage; set => SetField(ref _commissionValidationMessage, value); }

    /// <summary>
    /// Borrower ConfirmedCRBKEC [MORNET.X152], [MORNET.X156]
    /// </summary>
    public bool? ConfirmedCRBKEC { get => _confirmedCRBKEC; set => SetField(ref _confirmedCRBKEC, value); }

    /// <summary>
    /// Borrower ConfirmedCRBKIncorrect [MORNET.X151], [MORNET.X155]
    /// </summary>
    public bool? ConfirmedCRBKIncorrect { get => _confirmedCRBKIncorrect; set => SetField(ref _confirmedCRBKIncorrect, value); }

    /// <summary>
    /// Borrower ConfirmedCRDIL [MORNET.X81], [MORNET.X87]
    /// </summary>
    public bool? ConfirmedCRDIL { get => _confirmedCRDIL; set => SetField(ref _confirmedCRDIL, value); }

    /// <summary>
    /// Borrower ConfirmedCRFCEC [MORNET.X80], [MORNET.X86]
    /// </summary>
    public bool? ConfirmedCRFCEC { get => _confirmedCRFCEC; set => SetField(ref _confirmedCRFCEC, value); }

    /// <summary>
    /// Borrower ConfirmedCRFCIncorrect [MORNET.X79], [MORNET.X85]
    /// </summary>
    public bool? ConfirmedCRFCIncorrect { get => _confirmedCRFCIncorrect; set => SetField(ref _confirmedCRFCIncorrect, value); }

    /// <summary>
    /// Borrower ConfirmedCRPFS [MORNET.X82], [MORNET.X88]
    /// </summary>
    public bool? ConfirmedCRPFS { get => _confirmedCRPFS; set => SetField(ref _confirmedCRPFS, value); }

    /// <summary>
    /// Borrower ConfirmedMtgDelIncorrect [MORNET.X153], [MORNET.X154]
    /// </summary>
    public bool? ConfirmedMtgDelIncorrect { get => _confirmedMtgDelIncorrect; set => SetField(ref _confirmedMtgDelIncorrect, value); }

    /// <summary>
    /// Borrower ConfirmedOther [MORNET.X83], [MORNET.X89]
    /// </summary>
    public bool? ConfirmedOther { get => _confirmedOther; set => SetField(ref _confirmedOther, value); }

    /// <summary>
    /// Borrower ConfirmedOtherDescription [MORNET.X84], [MORNET.X90]
    /// </summary>
    public string? ConfirmedOtherDescription { get => _confirmedOtherDescription; set => SetField(ref _confirmedOtherDescription, value); }

    /// <summary>
    /// Borrower Contact
    /// </summary>
    public EntityReference? Contact { get => _contact; set => SetField(ref _contact, value); }

    /// <summary>
    /// Borrower CounselingConfirmationType [CORRESPONDENT.X440], [CORRESPONDENT.X441]
    /// </summary>
    public string? CounselingConfirmationType { get => _counselingConfirmationType; set => SetField(ref _counselingConfirmationType, value); }

    /// <summary>
    /// Borrower CounselingConfirmationTypeDescription [CORRESPONDENT.X442], [CORRESPONDENT.X443]
    /// </summary>
    public string? CounselingConfirmationTypeDescription { get => _counselingConfirmationTypeDescription; set => SetField(ref _counselingConfirmationTypeDescription, value); }

    /// <summary>
    /// Borrower CounselingFormatTypeDescription [CORRESPONDENT.X444], [CORRESPONDENT.X452]
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
    /// Borrower CreditReportAuthorizationMethod [4075], [4078]
    /// </summary>
    public StringEnumValue<CreditReportAuthorizationMethod> CreditReportAuthorizationMethod { get => _creditReportAuthorizationMethod; set => SetField(ref _creditReportAuthorizationMethod, value); }

    /// <summary>
    /// Borrower CreditReports
    /// </summary>
    [AllowNull]
    public IList<CreditReport> CreditReports { get => GetField(ref _creditReports); set => SetField(ref _creditReports, value); }

    /// <summary>
    /// Borrower CreditScoreIndicator [USDA.X12], [USDA.X15]
    /// </summary>
    public bool? CreditScoreIndicator { get => _creditScoreIndicator; set => SetField(ref _creditScoreIndicator, value); }

    /// <summary>
    /// Borrower CurrentEmploymentDoesNotApply [URLA.X199], [URLA.X200]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? CurrentEmploymentDoesNotApply { get => _currentEmploymentDoesNotApply; set => SetField(ref _currentEmploymentDoesNotApply, value); }

    /// <summary>
    /// GSE Vendor Provider Data - DataVerify [GSEVENDOR.X3]
    /// </summary>
    public string? DataVerify { get => _dataVerify; set => SetField(ref _dataVerify, value); }

    /// <summary>
    /// Borrower DateAuthorizedCreditReport [4074], [4077]
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
    /// Borrower DeclarationsJIndicator [965], [985]
    /// </summary>
    public bool? DeclarationsJIndicator { get => _declarationsJIndicator; set => SetField(ref _declarationsJIndicator, value); }

    /// <summary>
    /// Borrower DeclarationsKIndicator [466], [467]
    /// </summary>
    public bool? DeclarationsKIndicator { get => _declarationsKIndicator; set => SetField(ref _declarationsKIndicator, value); }

    /// <summary>
    /// Borrower DependentCount [53], [85]
    /// </summary>
    public int? DependentCount { get => _dependentCount; set => SetField(ref _dependentCount, value); }

    /// <summary>
    /// Borrower DependentsAgesDescription [54], [86]
    /// </summary>
    public string? DependentsAgesDescription { get => _dependentsAgesDescription; set => SetField(ref _dependentsAgesDescription, value); }

    /// <summary>
    /// Borrower DisabledIndicator [USDA.X2], [USDA.X5]
    /// </summary>
    public bool? DisabledIndicator { get => _disabledIndicator; set => SetField(ref _disabledIndicator, value); }

    /// <summary>
    /// Borrower DomesticRelationshipType [URLA.X113], [URLA.X114]
    /// </summary>
    public StringEnumValue<DomesticRelationshipType> DomesticRelationshipType { get => _domesticRelationshipType; set => SetField(ref _domesticRelationshipType, value); }

    /// <summary>
    /// Borrower DUVerificationEmploymentIncomeIndicator [TQL.X98], [TQL.X100]
    /// </summary>
    public bool? DUVerificationEmploymentIncomeIndicator { get => _dUVerificationEmploymentIncomeIndicator; set => SetField(ref _dUVerificationEmploymentIncomeIndicator, value); }

    /// <summary>
    /// Borrower DUVerificationEmploymentIncomeMessage [TQL.X99], [TQL.X101]
    /// </summary>
    public string? DUVerificationEmploymentIncomeMessage { get => _dUVerificationEmploymentIncomeMessage; set => SetField(ref _dUVerificationEmploymentIncomeMessage, value); }

    /// <summary>
    /// Borrower EmailAddressText [1240], [1268]
    /// </summary>
    public string? EmailAddressText { get => _emailAddressText; set => SetField(ref _emailAddressText, value); }

    /// <summary>
    /// Borrower EmploymentVerificationAvailable [MORNET.X129], [MORNET.X141]
    /// </summary>
    public bool? EmploymentVerificationAvailable { get => _employmentVerificationAvailable; set => SetField(ref _employmentVerificationAvailable, value); }

    /// <summary>
    /// Borrower EmploymentVerificationMessage [MORNET.X131], [MORNET.X143]
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
    /// Borrower EquifaxCreditScoreForDisclosure [DISCLOSURE.X629], [DISCLOSURE.X630]
    /// </summary>
    public bool? EquifaxCreditScoreForDisclosure { get => _equifaxCreditScoreForDisclosure; set => SetField(ref _equifaxCreditScoreForDisclosure, value); }

    /// <summary>
    /// Borrower EquifaxCreditScoreRanksPercent [DISCLOSURE.X635], [DISCLOSURE.X636]
    /// </summary>
    public int? EquifaxCreditScoreRanksPercent { get => _equifaxCreditScoreRanksPercent; set => SetField(ref _equifaxCreditScoreRanksPercent, value); }

    /// <summary>
    /// Borrower EquifaxDatePulled [DISCLOSURE.X51], [DISCLOSURE.X52]
    /// </summary>
    public DateTime? EquifaxDatePulled { get => _equifaxDatePulled; set => SetField(ref _equifaxDatePulled, value); }

    /// <summary>
    /// Borrower EquifaxFactorCode1 [DISCLOSURE.X1017], [DISCLOSURE.X1022]
    /// </summary>
    public string? EquifaxFactorCode1 { get => _equifaxFactorCode1; set => SetField(ref _equifaxFactorCode1, value); }

    /// <summary>
    /// Borrower EquifaxFactorCode2 [DISCLOSURE.X1018], [DISCLOSURE.X1023]
    /// </summary>
    public string? EquifaxFactorCode2 { get => _equifaxFactorCode2; set => SetField(ref _equifaxFactorCode2, value); }

    /// <summary>
    /// Borrower EquifaxFactorCode3 [DISCLOSURE.X1019], [DISCLOSURE.X1024]
    /// </summary>
    public string? EquifaxFactorCode3 { get => _equifaxFactorCode3; set => SetField(ref _equifaxFactorCode3, value); }

    /// <summary>
    /// Borrower EquifaxFactorCode4 [DISCLOSURE.X1020], [DISCLOSURE.X1025]
    /// </summary>
    public string? EquifaxFactorCode4 { get => _equifaxFactorCode4; set => SetField(ref _equifaxFactorCode4, value); }

    /// <summary>
    /// Borrower EquifaxFactorCode5 [DISCLOSURE.X1021], [DISCLOSURE.X1026]
    /// </summary>
    public string? EquifaxFactorCode5 { get => _equifaxFactorCode5; set => SetField(ref _equifaxFactorCode5, value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor1 [DISCLOSURE.X53], [DISCLOSURE.X57]
    /// </summary>
    public string? EquifaxKeyFactor1 { get => _equifaxKeyFactor1; set => SetField(ref _equifaxKeyFactor1, value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor2 [DISCLOSURE.X54], [DISCLOSURE.X58]
    /// </summary>
    public string? EquifaxKeyFactor2 { get => _equifaxKeyFactor2; set => SetField(ref _equifaxKeyFactor2, value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor3 [DISCLOSURE.X55], [DISCLOSURE.X59]
    /// </summary>
    public string? EquifaxKeyFactor3 { get => _equifaxKeyFactor3; set => SetField(ref _equifaxKeyFactor3, value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor4 [DISCLOSURE.X56], [DISCLOSURE.X60]
    /// </summary>
    public string? EquifaxKeyFactor4 { get => _equifaxKeyFactor4; set => SetField(ref _equifaxKeyFactor4, value); }

    /// <summary>
    /// Borrower EquifaxKeyFactor5 [DISCLOSURE.X175], [DISCLOSURE.X178]
    /// </summary>
    public string? EquifaxKeyFactor5 { get => _equifaxKeyFactor5; set => SetField(ref _equifaxKeyFactor5, value); }

    /// <summary>
    /// Borrower EquifaxMaterialTermsCreditByScore [DISCLOSURE.X947], [DISCLOSURE.X948]
    /// </summary>
    public bool? EquifaxMaterialTermsCreditByScore { get => _equifaxMaterialTermsCreditByScore; set => SetField(ref _equifaxMaterialTermsCreditByScore, value); }

    /// <summary>
    /// Borrower EquifaxScore [1414], [1415]
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
    /// Borrower ExperianCreditScore [60], [67]
    /// </summary>
    public string? ExperianCreditScore { get => _experianCreditScore; set => SetField(ref _experianCreditScore, value); }

    /// <summary>
    /// Borrower ExperianCreditScoreForDisclosure [DISCLOSURE.X625], [DISCLOSURE.X626]
    /// </summary>
    public bool? ExperianCreditScoreForDisclosure { get => _experianCreditScoreForDisclosure; set => SetField(ref _experianCreditScoreForDisclosure, value); }

    /// <summary>
    /// Borrower ExperianCreditScoreRanksPercent [DISCLOSURE.X631], [DISCLOSURE.X632]
    /// </summary>
    public int? ExperianCreditScoreRanksPercent { get => _experianCreditScoreRanksPercent; set => SetField(ref _experianCreditScoreRanksPercent, value); }

    /// <summary>
    /// Borrower ExperianDatePulled [DISCLOSURE.X11], [DISCLOSURE.X12]
    /// </summary>
    public DateTime? ExperianDatePulled { get => _experianDatePulled; set => SetField(ref _experianDatePulled, value); }

    /// <summary>
    /// Borrower ExperianFactorCode1 [DISCLOSURE.X997], [DISCLOSURE.X1002]
    /// </summary>
    public string? ExperianFactorCode1 { get => _experianFactorCode1; set => SetField(ref _experianFactorCode1, value); }

    /// <summary>
    /// Borrower ExperianFactorCode2 [DISCLOSURE.X998], [DISCLOSURE.X1003]
    /// </summary>
    public string? ExperianFactorCode2 { get => _experianFactorCode2; set => SetField(ref _experianFactorCode2, value); }

    /// <summary>
    /// Borrower ExperianFactorCode3 [DISCLOSURE.X999], [DISCLOSURE.X1004]
    /// </summary>
    public string? ExperianFactorCode3 { get => _experianFactorCode3; set => SetField(ref _experianFactorCode3, value); }

    /// <summary>
    /// Borrower ExperianFactorCode4 [DISCLOSURE.X1000], [DISCLOSURE.X1005]
    /// </summary>
    public string? ExperianFactorCode4 { get => _experianFactorCode4; set => SetField(ref _experianFactorCode4, value); }

    /// <summary>
    /// Borrower ExperianFactorCode5 [DISCLOSURE.X1001], [DISCLOSURE.X1006]
    /// </summary>
    public string? ExperianFactorCode5 { get => _experianFactorCode5; set => SetField(ref _experianFactorCode5, value); }

    /// <summary>
    /// Borrower ExperianKeyFactor1 [DISCLOSURE.X13], [DISCLOSURE.X17]
    /// </summary>
    public string? ExperianKeyFactor1 { get => _experianKeyFactor1; set => SetField(ref _experianKeyFactor1, value); }

    /// <summary>
    /// Borrower ExperianKeyFactor2 [DISCLOSURE.X14], [DISCLOSURE.X18]
    /// </summary>
    public string? ExperianKeyFactor2 { get => _experianKeyFactor2; set => SetField(ref _experianKeyFactor2, value); }

    /// <summary>
    /// Borrower ExperianKeyFactor3 [DISCLOSURE.X15], [DISCLOSURE.X19]
    /// </summary>
    public string? ExperianKeyFactor3 { get => _experianKeyFactor3; set => SetField(ref _experianKeyFactor3, value); }

    /// <summary>
    /// Borrower ExperianKeyFactor4 [DISCLOSURE.X16], [DISCLOSURE.X20]
    /// </summary>
    public string? ExperianKeyFactor4 { get => _experianKeyFactor4; set => SetField(ref _experianKeyFactor4, value); }

    /// <summary>
    /// Borrower ExperianKeyFactor5 [DISCLOSURE.X173], [DISCLOSURE.X176]
    /// </summary>
    public string? ExperianKeyFactor5 { get => _experianKeyFactor5; set => SetField(ref _experianKeyFactor5, value); }

    /// <summary>
    /// Borrower ExperianMaterialTermsCreditByScore [DISCLOSURE.X943], [DISCLOSURE.X944]
    /// </summary>
    public bool? ExperianMaterialTermsCreditByScore { get => _experianMaterialTermsCreditByScore; set => SetField(ref _experianMaterialTermsCreditByScore, value); }

    /// <summary>
    /// Borrower FannieFirstName [ULDD.FNM.4000], [ULDD.FNM.4004]
    /// </summary>
    public string? FannieFirstName { get => _fannieFirstName; set => SetField(ref _fannieFirstName, value); }

    /// <summary>
    /// Borrower FannieMiddleName [ULDD.FNM.4001], [ULDD.FNM.4005]
    /// </summary>
    public string? FannieMiddleName { get => _fannieMiddleName; set => SetField(ref _fannieMiddleName, value); }

    /// <summary>
    /// Borrower Final1003Provided [CORRESPONDENT.X455], [CORRESPONDENT.X456]
    /// </summary>
    public bool? Final1003Provided { get => _final1003Provided; set => SetField(ref _final1003Provided, value); }

    /// <summary>
    /// Borrower FirstName [4000], [4004]
    /// </summary>
    public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

    /// <summary>
    /// Borrower FirstNameWithMiddleName [36], [68]
    /// </summary>
    public string? FirstNameWithMiddleName { get => _firstNameWithMiddleName; set => SetField(ref _firstNameWithMiddleName, value); }

    /// <summary>
    /// Borrower FirstTimeHomeBuyer [USDA.X3], [USDA.X6]
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
    /// Borrower FreddieAlienStatus [4709], [4710]
    /// </summary>
    public StringEnumValue<FreddieBorrowerAlienStatus> FreddieAlienStatus { get => _freddieAlienStatus; set => SetField(ref _freddieAlienStatus, value); }

    /// <summary>
    /// Borrower FreddieMacPerson1 [CASASRN.X170], [CASASRN.X180]
    /// </summary>
    public string? FreddieMacPerson1 { get => _freddieMacPerson1; set => SetField(ref _freddieMacPerson1, value); }

    /// <summary>
    /// Borrower FreddieMacPerson2 [CASASRN.X171], [CASASRN.X181]
    /// </summary>
    public string? FreddieMacPerson2 { get => _freddieMacPerson2; set => SetField(ref _freddieMacPerson2, value); }

    /// <summary>
    /// Borrower FullName
    /// </summary>
    public string? FullName { get => _fullName; set => SetField(ref _fullName, value); }

    /// <summary>
    /// Borrower FullNameWithSuffix [1868], [1873]
    /// </summary>
    public string? FullNameWithSuffix { get => _fullNameWithSuffix; set => SetField(ref _fullNameWithSuffix, value); }

    /// <summary>
    /// Borrower GiftsAndGrantsIndicatorBor [URLA.X82], [URLA.X83]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does not apply\"}")]
    public bool? GiftsAndGrantsIndicatorBor { get => _giftsAndGrantsIndicatorBor; set => SetField(ref _giftsAndGrantsIndicatorBor, value); }

    /// <summary>
    /// Underwriting Highest Credit Limit [2567]
    /// </summary>
    public decimal? HighestCreditLimit { get => _highestCreditLimit; set => SetField(ref _highestCreditLimit, value); }

    /// <summary>
    /// Borrower Hmda2003OtherRaceNationalOriginDescription [1136], [1300]
    /// </summary>
    public string? Hmda2003OtherRaceNationalOriginDescription { get => _hmda2003OtherRaceNationalOriginDescription; set => SetField(ref _hmda2003OtherRaceNationalOriginDescription, value); }

    /// <summary>
    /// Borrower Hmda2003RaceNationalOriginType [470], [477]
    /// </summary>
    public StringEnumValue<Hmda2003RaceNationalOriginType> Hmda2003RaceNationalOriginType { get => _hmda2003RaceNationalOriginType; set => SetField(ref _hmda2003RaceNationalOriginType, value); }

    /// <summary>
    /// Borrower Hmda2CreditScoreForDecisionMaking [HMDA.X116], [HMDA.X118]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"9999\"]")]
    public StringEnumValue<HmdaCreditScoreForDecisionMaking> Hmda2CreditScoreForDecisionMaking { get => _hmda2CreditScoreForDecisionMaking; set => SetField(ref _hmda2CreditScoreForDecisionMaking, value); }

    /// <summary>
    /// Borrower Hmda2CreditScoringModel [HMDA.X117], [HMDA.X119]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"No co-applicant\"]")]
    public StringEnumValue<HmdaCreditScoringModel> Hmda2CreditScoringModel { get => _hmda2CreditScoringModel; set => SetField(ref _hmda2CreditScoringModel, value); }

    /// <summary>
    /// Borrower HmdaAfricanAmericanIndicator [1526], [1534]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Black or African American\"}")]
    public bool? HmdaAfricanAmericanIndicator { get => _hmdaAfricanAmericanIndicator; set => SetField(ref _hmdaAfricanAmericanIndicator, value); }

    /// <summary>
    /// Borrower HmdaAge [4183], [4184]
    /// </summary>
    public StringEnumValue<HmdaAge> HmdaAge { get => _hmdaAge; set => SetField(ref _hmdaAge, value); }

    /// <summary>
    /// Borrower HmdaAmericanIndianIndicator [1524], [1532]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"American Indian or Alaska Native\"}")]
    public bool? HmdaAmericanIndianIndicator { get => _hmdaAmericanIndianIndicator; set => SetField(ref _hmdaAmericanIndianIndicator, value); }

    /// <summary>
    /// Borrower HmdaAmericanIndianTribe [4126], [4137]
    /// </summary>
    public string? HmdaAmericanIndianTribe { get => _hmdaAmericanIndianTribe; set => SetField(ref _hmdaAmericanIndianTribe, value); }

    /// <summary>
    /// Borrower HmdaAsianIndianIndicator [4148], [4163]
    /// </summary>
    public bool? HmdaAsianIndianIndicator { get => _hmdaAsianIndianIndicator; set => SetField(ref _hmdaAsianIndianIndicator, value); }

    /// <summary>
    /// Borrower HmdaAsianIndicator [1525], [1533]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Asian\"}")]
    public bool? HmdaAsianIndicator { get => _hmdaAsianIndicator; set => SetField(ref _hmdaAsianIndicator, value); }

    /// <summary>
    /// Borrower HmdaAsianOtherRaceIndicator [4154], [4169]
    /// </summary>
    public bool? HmdaAsianOtherRaceIndicator { get => _hmdaAsianOtherRaceIndicator; set => SetField(ref _hmdaAsianOtherRaceIndicator, value); }

    /// <summary>
    /// Borrower HmdaChineseIndicator [4149], [4164]
    /// </summary>
    public bool? HmdaChineseIndicator { get => _hmdaChineseIndicator; set => SetField(ref _hmdaChineseIndicator, value); }

    /// <summary>
    /// Borrower HmdaCreditScoreForDecisionMaking [4174], [4177]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Exempt\",\"9999\"]")]
    public StringEnumValue<HmdaCreditScoreForDecisionMaking> HmdaCreditScoreForDecisionMaking { get => _hmdaCreditScoreForDecisionMaking; set => SetField(ref _hmdaCreditScoreForDecisionMaking, value); }

    /// <summary>
    /// Borrower HmdaCreditScoringModel [4175], [4178]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Exempt\",\"No co-applicant\"]")]
    public StringEnumValue<HmdaCreditScoringModel> HmdaCreditScoringModel { get => _hmdaCreditScoringModel; set => SetField(ref _hmdaCreditScoringModel, value); }

    /// <summary>
    /// Borrower HmdaCubanIndicator [4146], [4161]
    /// </summary>
    public bool? HmdaCubanIndicator { get => _hmdaCubanIndicator; set => SetField(ref _hmdaCubanIndicator, value); }

    /// <summary>
    /// Borrower HmdaEthnicityDoNotWishIndicator [4205], [4206]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaEthnicityDoNotWishIndicator { get => _hmdaEthnicityDoNotWishIndicator; set => SetField(ref _hmdaEthnicityDoNotWishIndicator, value); }

    /// <summary>
    /// Borrower HmdaEthnicityHispanicLatinoIndicator [4210], [4213]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Hispanic or Latino\"}")]
    public bool? HmdaEthnicityHispanicLatinoIndicator { get => _hmdaEthnicityHispanicLatinoIndicator; set => SetField(ref _hmdaEthnicityHispanicLatinoIndicator, value); }

    /// <summary>
    /// Borrower HmdaEthnicityInfoNotProvided [4243], [4246]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaEthnicityInfoNotProvided { get => _hmdaEthnicityInfoNotProvided; set => SetField(ref _hmdaEthnicityInfoNotProvided, value); }

    /// <summary>
    /// Borrower HmdaEthnicityNotApplicableIndicator [4212], [4215]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
    public bool? HmdaEthnicityNotApplicableIndicator { get => _hmdaEthnicityNotApplicableIndicator; set => SetField(ref _hmdaEthnicityNotApplicableIndicator, value); }

    /// <summary>
    /// Borrower HmdaEthnicityNotHispanicLatinoIndicator [4211], [4214]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Hispanic or Latino\"}")]
    public bool? HmdaEthnicityNotHispanicLatinoIndicator { get => _hmdaEthnicityNotHispanicLatinoIndicator; set => SetField(ref _hmdaEthnicityNotHispanicLatinoIndicator, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField1 [4221], [4231]
    /// </summary>
    public string? HmdaEthnicityReportedField1 { get => _hmdaEthnicityReportedField1; set => SetField(ref _hmdaEthnicityReportedField1, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField2 [4222], [4232]
    /// </summary>
    public string? HmdaEthnicityReportedField2 { get => _hmdaEthnicityReportedField2; set => SetField(ref _hmdaEthnicityReportedField2, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField3 [4223], [4233]
    /// </summary>
    public string? HmdaEthnicityReportedField3 { get => _hmdaEthnicityReportedField3; set => SetField(ref _hmdaEthnicityReportedField3, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField4 [4224], [4234]
    /// </summary>
    public string? HmdaEthnicityReportedField4 { get => _hmdaEthnicityReportedField4; set => SetField(ref _hmdaEthnicityReportedField4, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedField5 [4225], [4235]
    /// </summary>
    public string? HmdaEthnicityReportedField5 { get => _hmdaEthnicityReportedField5; set => SetField(ref _hmdaEthnicityReportedField5, value); }

    /// <summary>
    /// Borrower HmdaEthnicityReportedFields [4236], [4238]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaEthnicityReportedFields { get => _hmdaEthnicityReportedFields; set => SetField(ref _hmdaEthnicityReportedFields, value); }

    /// <summary>
    /// Borrower HmdaEthnicityType [1523], [1531]
    /// </summary>
    public StringEnumValue<HmdaEthnicityType> HmdaEthnicityType { get => _hmdaEthnicityType; set => SetField(ref _hmdaEthnicityType, value); }

    /// <summary>
    /// Borrower HmdaFilipinoIndicator [4150], [4165]
    /// </summary>
    public bool? HmdaFilipinoIndicator { get => _hmdaFilipinoIndicator; set => SetField(ref _hmdaFilipinoIndicator, value); }

    /// <summary>
    /// Borrower HmdaGenderType [471], [478]
    /// </summary>
    public StringEnumValue<HmdaGenderType> HmdaGenderType { get => _hmdaGenderType; set => SetField(ref _hmdaGenderType, value); }

    /// <summary>
    /// Borrower HmdaGendertypeDoNotWishIndicator [4195], [4199]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaGendertypeDoNotWishIndicator { get => _hmdaGendertypeDoNotWishIndicator; set => SetField(ref _hmdaGendertypeDoNotWishIndicator, value); }

    /// <summary>
    /// Borrower HmdaGendertypeFemaleIndicator [4193], [4197]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Female\"}")]
    public bool? HmdaGendertypeFemaleIndicator { get => _hmdaGendertypeFemaleIndicator; set => SetField(ref _hmdaGendertypeFemaleIndicator, value); }

    /// <summary>
    /// Borrower HmdaGendertypeMaleIndicator [4194], [4198]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Male\"}")]
    public bool? HmdaGendertypeMaleIndicator { get => _hmdaGendertypeMaleIndicator; set => SetField(ref _hmdaGendertypeMaleIndicator, value); }

    /// <summary>
    /// Borrower HmdaGendertypeNotApplicableIndicator [4196], [4200]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not Applicable\"}")]
    public bool? HmdaGendertypeNotApplicableIndicator { get => _hmdaGendertypeNotApplicableIndicator; set => SetField(ref _hmdaGendertypeNotApplicableIndicator, value); }

    /// <summary>
    /// Borrower HmdaGuamanianOrChamorroIndicator [4156], [4171]
    /// </summary>
    public bool? HmdaGuamanianOrChamorroIndicator { get => _hmdaGuamanianOrChamorroIndicator; set => SetField(ref _hmdaGuamanianOrChamorroIndicator, value); }

    /// <summary>
    /// Borrower HmdaHispanicLatinoOtherOriginIndicator [4147], [4162]
    /// </summary>
    public bool? HmdaHispanicLatinoOtherOriginIndicator { get => _hmdaHispanicLatinoOtherOriginIndicator; set => SetField(ref _hmdaHispanicLatinoOtherOriginIndicator, value); }

    /// <summary>
    /// Borrower HmdaJapaneseIndicator [4151], [4166]
    /// </summary>
    public bool? HmdaJapaneseIndicator { get => _hmdaJapaneseIndicator; set => SetField(ref _hmdaJapaneseIndicator, value); }

    /// <summary>
    /// Borrower HmdaKoreanIndicator [4152], [4167]
    /// </summary>
    public bool? HmdaKoreanIndicator { get => _hmdaKoreanIndicator; set => SetField(ref _hmdaKoreanIndicator, value); }

    /// <summary>
    /// Borrower HmdaMexicanIndicator [4144], [4159]
    /// </summary>
    public bool? HmdaMexicanIndicator { get => _hmdaMexicanIndicator; set => SetField(ref _hmdaMexicanIndicator, value); }

    /// <summary>
    /// Borrower HmdaNativeHawaiianIndicator [4155], [4170]
    /// </summary>
    public bool? HmdaNativeHawaiianIndicator { get => _hmdaNativeHawaiianIndicator; set => SetField(ref _hmdaNativeHawaiianIndicator, value); }

    /// <summary>
    /// No Co-applicant Indicator [3840]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No Co-applicant\"}")]
    public bool? HmdaNoCoApplicantIndicator { get => _hmdaNoCoApplicantIndicator; set => SetField(ref _hmdaNoCoApplicantIndicator, value); }

    /// <summary>
    /// Borrower HmdaNotApplicableIndicator [1530], [1538]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Not applicable\"}")]
    public bool? HmdaNotApplicableIndicator { get => _hmdaNotApplicableIndicator; set => SetField(ref _hmdaNotApplicableIndicator, value); }

    /// <summary>
    /// Borrower HmdaNotProvidedIndicator [1529], [1537]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaNotProvidedIndicator { get => _hmdaNotProvidedIndicator; set => SetField(ref _hmdaNotProvidedIndicator, value); }

    /// <summary>
    /// Borrower HmdaOtherAsianRace [4128], [4139]
    /// </summary>
    public string? HmdaOtherAsianRace { get => _hmdaOtherAsianRace; set => SetField(ref _hmdaOtherAsianRace, value); }

    /// <summary>
    /// Borrower HmdaOtherHispanicLatinoOrigin [4125], [4136]
    /// </summary>
    public string? HmdaOtherHispanicLatinoOrigin { get => _hmdaOtherHispanicLatinoOrigin; set => SetField(ref _hmdaOtherHispanicLatinoOrigin, value); }

    /// <summary>
    /// Borrower HmdaOtherPacificIslanderRace [4130], [4141]
    /// </summary>
    public string? HmdaOtherPacificIslanderRace { get => _hmdaOtherPacificIslanderRace; set => SetField(ref _hmdaOtherPacificIslanderRace, value); }

    /// <summary>
    /// Borrower HmdaOtherScoringModel [4176], [4179]
    /// </summary>
    public string? HmdaOtherScoringModel { get => _hmdaOtherScoringModel; set => SetField(ref _hmdaOtherScoringModel, value); }

    /// <summary>
    /// Borrower HmdaPacificIslanderIndicator [1527], [1535]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Native Hawaiian or Other Pacific Islander\"}")]
    public bool? HmdaPacificIslanderIndicator { get => _hmdaPacificIslanderIndicator; set => SetField(ref _hmdaPacificIslanderIndicator, value); }

    /// <summary>
    /// Borrower HmdaPacificIslanderOtherIndicator [4158], [4173]
    /// </summary>
    public bool? HmdaPacificIslanderOtherIndicator { get => _hmdaPacificIslanderOtherIndicator; set => SetField(ref _hmdaPacificIslanderOtherIndicator, value); }

    /// <summary>
    /// Borrower HmdaPuertoRicanIndicator [4145], [4160]
    /// </summary>
    public bool? HmdaPuertoRicanIndicator { get => _hmdaPuertoRicanIndicator; set => SetField(ref _hmdaPuertoRicanIndicator, value); }

    /// <summary>
    /// Borrower HmdaRaceDoNotWishProvideIndicator [4252], [4253]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to provide this information\"}")]
    public bool? HmdaRaceDoNotWishProvideIndicator { get => _hmdaRaceDoNotWishProvideIndicator; set => SetField(ref _hmdaRaceDoNotWishProvideIndicator, value); }

    /// <summary>
    /// Borrower HmdaRaceInfoNotProvided [4244], [4247]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaRaceInfoNotProvided { get => _hmdaRaceInfoNotProvided; set => SetField(ref _hmdaRaceInfoNotProvided, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField1 [4216], [4226]
    /// </summary>
    public string? HmdaRaceReportedField1 { get => _hmdaRaceReportedField1; set => SetField(ref _hmdaRaceReportedField1, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField2 [4217], [4227]
    /// </summary>
    public string? HmdaRaceReportedField2 { get => _hmdaRaceReportedField2; set => SetField(ref _hmdaRaceReportedField2, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField3 [4218], [4228]
    /// </summary>
    public string? HmdaRaceReportedField3 { get => _hmdaRaceReportedField3; set => SetField(ref _hmdaRaceReportedField3, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField4 [4219], [4229]
    /// </summary>
    public string? HmdaRaceReportedField4 { get => _hmdaRaceReportedField4; set => SetField(ref _hmdaRaceReportedField4, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedField5 [4220], [4230]
    /// </summary>
    public string? HmdaRaceReportedField5 { get => _hmdaRaceReportedField5; set => SetField(ref _hmdaRaceReportedField5, value); }

    /// <summary>
    /// Borrower HmdaRaceReportedFields [4237], [4239]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaRaceReportedFields { get => _hmdaRaceReportedFields; set => SetField(ref _hmdaRaceReportedFields, value); }

    /// <summary>
    /// Borrower HmdaRefusalIndicator [188], [189]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"I do not wish to furnish this info\"}")]
    public bool? HmdaRefusalIndicator { get => _hmdaRefusalIndicator; set => SetField(ref _hmdaRefusalIndicator, value); }

    /// <summary>
    /// Borrower HmdaSamoanIndicator [4157], [4172]
    /// </summary>
    public bool? HmdaSamoanIndicator { get => _hmdaSamoanIndicator; set => SetField(ref _hmdaSamoanIndicator, value); }

    /// <summary>
    /// Borrower HmdaSexInfoNotProvided [4245], [4248]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Information Not Provided\"}")]
    public bool? HmdaSexInfoNotProvided { get => _hmdaSexInfoNotProvided; set => SetField(ref _hmdaSexInfoNotProvided, value); }

    /// <summary>
    /// Borrower HmdaVietnameseIndicator [4153], [4168]
    /// </summary>
    public bool? HmdaVietnameseIndicator { get => _hmdaVietnameseIndicator; set => SetField(ref _hmdaVietnameseIndicator, value); }

    /// <summary>
    /// Borrower HmdaWhiteIndicator [1528], [1536]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"White\"}")]
    public bool? HmdaWhiteIndicator { get => _hmdaWhiteIndicator; set => SetField(ref _hmdaWhiteIndicator, value); }

    /// <summary>
    /// Borrower HomeCounselingAgencyName [URLA.X232], [URLA.X244]
    /// </summary>
    public string? HomeCounselingAgencyName { get => _homeCounselingAgencyName; set => SetField(ref _homeCounselingAgencyName, value); }

    /// <summary>
    /// Borrower HomeCounselingCompletionDate [URLA.X233], [URLA.X243]
    /// </summary>
    public DateTime? HomeCounselingCompletionDate { get => _homeCounselingCompletionDate; set => SetField(ref _homeCounselingCompletionDate, value); }

    /// <summary>
    /// Borrower HomeownerPastThreeYearsIndicator [403], [1108]
    /// </summary>
    public bool? HomeownerPastThreeYearsIndicator { get => _homeownerPastThreeYearsIndicator; set => SetField(ref _homeownerPastThreeYearsIndicator, value); }

    /// <summary>
    /// Borrower HomePhoneNumber [66], [98]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? HomePhoneNumber { get => _homePhoneNumber; set => SetField(ref _homePhoneNumber, value); }

    /// <summary>
    /// Borrower Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Borrower IncomeRepAndWarrantyMessage [MORNET.X99], [MORNET.X113]
    /// </summary>
    public string? IncomeRepAndWarrantyMessage { get => _incomeRepAndWarrantyMessage; set => SetField(ref _incomeRepAndWarrantyMessage, value); }

    /// <summary>
    /// Borrower IncomeRepAndWarrantyReliefAvailable [MORNET.X104], [MORNET.X118]
    /// </summary>
    public bool? IncomeRepAndWarrantyReliefAvailable { get => _incomeRepAndWarrantyReliefAvailable; set => SetField(ref _incomeRepAndWarrantyReliefAvailable, value); }

    /// <summary>
    /// Borrower Initial1003Provided [CORRESPONDENT.X453], [CORRESPONDENT.X454]
    /// </summary>
    public bool? Initial1003Provided { get => _initial1003Provided; set => SetField(ref _initial1003Provided, value); }

    /// <summary>
    /// Borrower IntentToOccupyIndicator [418], [1343]
    /// </summary>
    public bool? IntentToOccupyIndicator { get => _intentToOccupyIndicator; set => SetField(ref _intentToOccupyIndicator, value); }

    /// <summary>
    /// Borrower IntuitReportId [FANNIESERVICE.X5], [FANNIESERVICE.X6]
    /// </summary>
    public string? IntuitReportId { get => _intuitReportId; set => SetField(ref _intuitReportId, value); }

    /// <summary>
    /// Borrower IsBaseIncomeAvailable [MORNET.X105], [MORNET.X119]
    /// </summary>
    public bool? IsBaseIncomeAvailable { get => _isBaseIncomeAvailable; set => SetField(ref _isBaseIncomeAvailable, value); }

    /// <summary>
    /// Borrower IsBonusAvailable [MORNET.X106], [MORNET.X120]
    /// </summary>
    public bool? IsBonusAvailable { get => _isBonusAvailable; set => SetField(ref _isBonusAvailable, value); }

    /// <summary>
    /// Borrower IsBorrower
    /// </summary>
    public bool? IsBorrower { get => _isBorrower; set => SetField(ref _isBorrower, value); }

    /// <summary>
    /// Borrower IsCommissionAvailable [MORNET.X108], [MORNET.X122]
    /// </summary>
    public bool? IsCommissionAvailable { get => _isCommissionAvailable; set => SetField(ref _isCommissionAvailable, value); }

    /// <summary>
    /// Borrower IsEthnicityBasedOnVisual [4121], [4132]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"NoCoApplicant\"]")]
    public StringEnumValue<YNOrNA> IsEthnicityBasedOnVisual { get => _isEthnicityBasedOnVisual; set => SetField(ref _isEthnicityBasedOnVisual, value); }

    /// <summary>
    /// Borrower IsOvertimeAvailable [MORNET.X107], [MORNET.X121]
    /// </summary>
    public bool? IsOvertimeAvailable { get => _isOvertimeAvailable; set => SetField(ref _isOvertimeAvailable, value); }

    /// <summary>
    /// Borrower IsRaceBasedOnVisual [4122], [4133]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"NoCoApplicant\"]")]
    public StringEnumValue<YNOrNA> IsRaceBasedOnVisual { get => _isRaceBasedOnVisual; set => SetField(ref _isRaceBasedOnVisual, value); }

    /// <summary>
    /// Borrower IsSelfEmployed [MORNET.X110], [MORNET.X124]
    /// </summary>
    public bool? IsSelfEmployed { get => _isSelfEmployed; set => SetField(ref _isSelfEmployed, value); }

    /// <summary>
    /// Borrower IsSexBasedOnVisual [4123], [4134]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"NoCoApplicant\"]")]
    public StringEnumValue<YNOrNA> IsSexBasedOnVisual { get => _isSexBasedOnVisual; set => SetField(ref _isSexBasedOnVisual, value); }

    /// <summary>
    /// Borrower IsSocialSecurityAvailable [MORNET.X109], [MORNET.X123]
    /// </summary>
    public bool? IsSocialSecurityAvailable { get => _isSocialSecurityAvailable; set => SetField(ref _isSocialSecurityAvailable, value); }

    /// <summary>
    /// Borrower IsTaxReturnAvailable [MORNET.X128], [MORNET.X140]
    /// </summary>
    public bool? IsTaxReturnAvailable { get => _isTaxReturnAvailable; set => SetField(ref _isTaxReturnAvailable, value); }

    /// <summary>
    /// Borrower JointAssetLiabilityReportingIndicator [URLA.X3], [URLA.X4]
    /// </summary>
    public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator { get => _jointAssetLiabilityReportingIndicator; set => SetField(ref _jointAssetLiabilityReportingIndicator, value); }

    /// <summary>
    /// Assets/Liabilities Completed Jointly/Not Jointly [URLA.X234]
    /// </summary>
    public StringEnumValue<JointAssetLiabilityReportingIndicator> JointAssetLiabilityReportingIndicator1 { get => _jointAssetLiabilityReportingIndicator1; set => SetField(ref _jointAssetLiabilityReportingIndicator1, value); }

    /// <summary>
    /// Borrower LanguageCodeOtherDescription [URLA.X35], [URLA.X36]
    /// </summary>
    public string? LanguageCodeOtherDescription { get => _languageCodeOtherDescription; set => SetField(ref _languageCodeOtherDescription, value); }

    /// <summary>
    /// Borrower LanguagePreference [URLA.X21], [URLA.X22]
    /// </summary>
    public StringEnumValue<LanguagePreference> LanguagePreference { get => _languagePreference; set => SetField(ref _languagePreference, value); }

    /// <summary>
    /// Borrower LastName [4002], [4006]
    /// </summary>
    public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

    /// <summary>
    /// Borrower LastNameWithSuffix [37], [69]
    /// </summary>
    public string? LastNameWithSuffix { get => _lastNameWithSuffix; set => SetField(ref _lastNameWithSuffix, value); }

    /// <summary>
    /// Borrower LeaveAndEarningsStatement [CORRESPONDENT.X457], [CORRESPONDENT.X458]
    /// </summary>
    public bool? LeaveAndEarningsStatement { get => _leaveAndEarningsStatement; set => SetField(ref _leaveAndEarningsStatement, value); }

    /// <summary>
    /// Borrower LeDeliveryMethod [CORRESPONDENT.X386], [CORRESPONDENT.X387]
    /// </summary>
    public string? LeDeliveryMethod { get => _leDeliveryMethod; set => SetField(ref _leDeliveryMethod, value); }

    /// <summary>
    /// Borrower LegalOtherThanSpouse [URLA.X111], [URLA.X112]
    /// </summary>
    public bool? LegalOtherThanSpouse { get => _legalOtherThanSpouse; set => SetField(ref _legalOtherThanSpouse, value); }

    /// <summary>
    /// Borrower LiabilitiesDoesNotApply [URLA.X59], [URLA.X60]
    /// </summary>
    public bool? LiabilitiesDoesNotApply { get => _liabilitiesDoesNotApply; set => SetField(ref _liabilitiesDoesNotApply, value); }

    /// <summary>
    /// Borrower LoanForeclosureOrJudgementIndicator [1057], [1197]
    /// </summary>
    public bool? LoanForeclosureOrJudgementIndicator { get => _loanForeclosureOrJudgementIndicator; set => SetField(ref _loanForeclosureOrJudgementIndicator, value); }

    /// <summary>
    /// Borrower LpdGsa [940], [942]
    /// </summary>
    public string? LpdGsa { get => _lpdGsa; set => SetField(ref _lpdGsa, value); }

    /// <summary>
    /// Borrower MailingAddressSameAsPresentIndicator [1819], [1820]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Same as present address\"}")]
    public bool? MailingAddressSameAsPresentIndicator { get => _mailingAddressSameAsPresentIndicator; set => SetField(ref _mailingAddressSameAsPresentIndicator, value); }

    /// <summary>
    /// Borrower MaritalStatusType [52], [84]
    /// </summary>
    public StringEnumValue<MaritalStatusType> MaritalStatusType { get => _maritalStatusType; set => SetField(ref _maritalStatusType, value); }

    /// <summary>
    /// Borrower MiddleCreditScore [USDA.X194], [USDA.X195]
    /// </summary>
    public int? MiddleCreditScore { get => _middleCreditScore; set => SetField(ref _middleCreditScore, value); }

    /// <summary>
    /// Borrower MiddleFicoScore [2849], [2850]
    /// </summary>
    public string? MiddleFicoScore { get => _middleFicoScore; set => SetField(ref _middleFicoScore, value); }

    /// <summary>
    /// Borrower MiddleName [4001], [4005]
    /// </summary>
    public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

    /// <summary>
    /// Borrower MilitaryServiceExpectedCompletionDate [URLA.X17], [URLA.X18]
    /// </summary>
    public DateTime? MilitaryServiceExpectedCompletionDate { get => _militaryServiceExpectedCompletionDate; set => SetField(ref _militaryServiceExpectedCompletionDate, value); }

    /// <summary>
    /// Borrower MinFicoScore [1484], [1502]
    /// </summary>
    public string? MinFicoScore { get => _minFicoScore; set => SetField(ref _minFicoScore, value); }

    /// <summary>
    /// Borrower MobilePhone [1480], [1490]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? MobilePhone { get => _mobilePhone; set => SetField(ref _mobilePhone, value); }

    /// <summary>
    /// Underwriting Mortgage on Credit [2563]
    /// </summary>
    public bool? MortgageOnCredit { get => _mortgageOnCredit; set => SetField(ref _mortgageOnCredit, value); }

    /// <summary>
    /// Borrower NameToObtainLoanFromRHS [USDA.X45], [USDA.X47]
    /// </summary>
    public string? NameToObtainLoanFromRHS { get => _nameToObtainLoanFromRHS; set => SetField(ref _nameToObtainLoanFromRHS, value); }

    /// <summary>
    /// Borrower NearestRelativeAddress [CAPIAP.X10], [CAPIAP.X17]
    /// </summary>
    public string? NearestRelativeAddress { get => _nearestRelativeAddress; set => SetField(ref _nearestRelativeAddress, value); }

    /// <summary>
    /// Borrower NearestRelativeCity [CAPIAP.X11], [CAPIAP.X18]
    /// </summary>
    public string? NearestRelativeCity { get => _nearestRelativeCity; set => SetField(ref _nearestRelativeCity, value); }

    /// <summary>
    /// Borrower NearestRelativeCountry [CAPIAP.X64], [CAPIAP.X65]
    /// </summary>
    public string? NearestRelativeCountry { get => _nearestRelativeCountry; set => SetField(ref _nearestRelativeCountry, value); }

    /// <summary>
    /// Borrower NearestRelativeForeignAddressIndicator [CAPIAP.X62], [CAPIAP.X63]
    /// </summary>
    public bool? NearestRelativeForeignAddressIndicator { get => _nearestRelativeForeignAddressIndicator; set => SetField(ref _nearestRelativeForeignAddressIndicator, value); }

    /// <summary>
    /// Borrower NearestRelativeName [CAPIAP.X16], [CAPIAP.X9]
    /// </summary>
    public string? NearestRelativeName { get => _nearestRelativeName; set => SetField(ref _nearestRelativeName, value); }

    /// <summary>
    /// Borrower NearestRelativePhone [CAPIAP.X15], [CAPIAP.X22]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? NearestRelativePhone { get => _nearestRelativePhone; set => SetField(ref _nearestRelativePhone, value); }

    /// <summary>
    /// Borrower NearestRelativePostalCode [CAPIAP.X13], [CAPIAP.X20]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? NearestRelativePostalCode { get => _nearestRelativePostalCode; set => SetField(ref _nearestRelativePostalCode, value); }

    /// <summary>
    /// Borrower NearestRelativeRelationship [CAPIAP.X14], [CAPIAP.X21]
    /// </summary>
    public string? NearestRelativeRelationship { get => _nearestRelativeRelationship; set => SetField(ref _nearestRelativeRelationship, value); }

    /// <summary>
    /// Borrower NearestRelativeState [CAPIAP.X12], [CAPIAP.X19]
    /// </summary>
    public StringEnumValue<State> NearestRelativeState { get => _nearestRelativeState; set => SetField(ref _nearestRelativeState, value); }

    /// <summary>
    /// Borrower NetRentalIncome [CORRESPONDENT.X43], [CORRESPONDENT.X44]
    /// </summary>
    public decimal? NetRentalIncome { get => _netRentalIncome; set => SetField(ref _netRentalIncome, value); }

    /// <summary>
    /// Borrower No3rdPartyEmailIndicator [2857], [2858]
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
    /// Borrower ObtainLoanFromRHSIndicator [USDA.X44], [USDA.X46]
    /// </summary>
    public bool? ObtainLoanFromRHSIndicator { get => _obtainLoanFromRHSIndicator; set => SetField(ref _obtainLoanFromRHSIndicator, value); }

    /// <summary>
    /// Underwriting Open Bankruptcy [2568]
    /// </summary>
    public StringEnumValue<OpenBankruptcy> OpenBankruptcy2 { get => _openBankruptcy2; set => SetField(ref _openBankruptcy2, value); }

    /// <summary>
    /// Borrower OtherAssetsDoesNotApply [URLA.X51], [URLA.X52]
    /// </summary>
    public bool? OtherAssetsDoesNotApply { get => _otherAssetsDoesNotApply; set => SetField(ref _otherAssetsDoesNotApply, value); }

    /// <summary>
    /// Borrower OtherLiabilitiesDoesNotApply [URLA.X63], [URLA.X64]
    /// </summary>
    public bool? OtherLiabilitiesDoesNotApply { get => _otherLiabilitiesDoesNotApply; set => SetField(ref _otherLiabilitiesDoesNotApply, value); }

    /// <summary>
    /// Borrower OtherMonthlyIncomeAmount [1145], [1146]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherMonthlyIncomeAmount { get => _otherMonthlyIncomeAmount; set => SetField(ref _otherMonthlyIncomeAmount, value); }

    /// <summary>
    /// Borrower OtherRelationshipTypeDescription [URLA.X115], [URLA.X116]
    /// </summary>
    public string? OtherRelationshipTypeDescription { get => _otherRelationshipTypeDescription; set => SetField(ref _otherRelationshipTypeDescription, value); }

    /// <summary>
    /// Borrower OtherSrcIncomeDoesNotApply [URLA.X40], [URLA.X41]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? OtherSrcIncomeDoesNotApply { get => _otherSrcIncomeDoesNotApply; set => SetField(ref _otherSrcIncomeDoesNotApply, value); }

    /// <summary>
    /// Borrower OtherSumAmount [108], [117]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? OtherSumAmount { get => _otherSumAmount; set => SetField(ref _otherSumAmount, value); }

    /// <summary>
    /// Borrower OutstandingJudgementsIndicator [169], [175]
    /// </summary>
    public bool? OutstandingJudgementsIndicator { get => _outstandingJudgementsIndicator; set => SetField(ref _outstandingJudgementsIndicator, value); }

    /// <summary>
    /// Borrower OvertimeValidationMessage [MORNET.X134], [MORNET.X146]
    /// </summary>
    public string? OvertimeValidationMessage { get => _overtimeValidationMessage; set => SetField(ref _overtimeValidationMessage, value); }

    /// <summary>
    /// Borrower OwnershipConfirmationIndicator [URLA.X153], [URLA.X159]
    /// </summary>
    public bool? OwnershipConfirmationIndicator { get => _ownershipConfirmationIndicator; set => SetField(ref _ownershipConfirmationIndicator, value); }

    /// <summary>
    /// Borrower OwnershipFormatType [URLA.X154], [URLA.X160]
    /// </summary>
    public StringEnumValue<OwnershipFormatType> OwnershipFormatType { get => _ownershipFormatType; set => SetField(ref _ownershipFormatType, value); }

    /// <summary>
    /// Borrower OwnershipPartyRoleIdentifier [URLA.X155], [URLA.X161]
    /// </summary>
    public string? OwnershipPartyRoleIdentifier { get => _ownershipPartyRoleIdentifier; set => SetField(ref _ownershipPartyRoleIdentifier, value); }

    /// <summary>
    /// Borrower PartyToLawsuitIndicator [172], [178]
    /// </summary>
    public bool? PartyToLawsuitIndicator { get => _partyToLawsuitIndicator; set => SetField(ref _partyToLawsuitIndicator, value); }

    /// <summary>
    /// Borrower PartyToLawsuitIndicatorURLA [URLA.X100], [URLA.X101]
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
    /// Borrower PensionRetireIncomeMessage [MORNET.X130], [MORNET.X142]
    /// </summary>
    public string? PensionRetireIncomeMessage { get => _pensionRetireIncomeMessage; set => SetField(ref _pensionRetireIncomeMessage, value); }

    /// <summary>
    /// Borrower PersonFaxNumber [1188], [1241]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PersonFaxNumber { get => _personFaxNumber; set => SetField(ref _personFaxNumber, value); }

    /// <summary>
    /// Borrower PersonHoursPerWeek [HRSPERWEEK1], [HRSPERWEEK2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PersonHoursPerWeek { get => _personHoursPerWeek; set => SetField(ref _personHoursPerWeek, value); }

    /// <summary>
    /// Borrower PersonIncomeAmount [INCOMEAMT1], [INCOMEAMT2]
    /// </summary>
    public decimal? PersonIncomeAmount { get => _personIncomeAmount; set => SetField(ref _personIncomeAmount, value); }

    /// <summary>
    /// Borrower PersonIncomeFrequencyType [INCOMEFREQ1], [INCOMEFREQ2]
    /// </summary>
    public string? PersonIncomeFrequencyType { get => _personIncomeFrequencyType; set => SetField(ref _personIncomeFrequencyType, value); }

    /// <summary>
    /// Borrower PersonMonthlyIncome [MONTHLYINCOME1], [MONTHLYINCOME2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? PersonMonthlyIncome { get => _personMonthlyIncome; set => SetField(ref _personMonthlyIncome, value); }

    /// <summary>
    /// Borrower PIWAccepted [MORNET.X101], [MORNET.X115]
    /// </summary>
    public bool? PIWAccepted { get => _pIWAccepted; set => SetField(ref _pIWAccepted, value); }

    /// <summary>
    /// Fannie Mae - Coborrower - PIW Message [MORNET.X111]
    /// </summary>
    public string? PIWMessage { get => _pIWMessage; set => SetField(ref _pIWMessage, value); }

    /// <summary>
    /// Borrower PoaOccupancyIntent [Borr.OccupancyIntent], [CoBorr.OccupancyIntent]
    /// </summary>
    public StringEnumValue<OccupancyIntent> PoaOccupancyIntent { get => _poaOccupancyIntent; set => SetField(ref _poaOccupancyIntent, value); }

    /// <summary>
    /// Borrower PoaSignatureText [Borr.POASigTxt], [CoBorr.POASigTxt]
    /// </summary>
    public string? PoaSignatureText { get => _poaSignatureText; set => SetField(ref _poaSignatureText, value); }

    /// <summary>
    /// Borrower PositiveCashFlow [1169], [1170]
    /// </summary>
    public decimal? PositiveCashFlow { get => _positiveCashFlow; set => SetField(ref _positiveCashFlow, value); }

    /// <summary>
    /// Borrower PowerOfAttorneyName [1870], [1875]
    /// </summary>
    public string? PowerOfAttorneyName { get => _powerOfAttorneyName; set => SetField(ref _powerOfAttorneyName, value); }

    /// <summary>
    /// Borrower PowerOfAttorneyTitleDescription [1872], [1877]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PowerOfAttorneyTitleDescription { get => _powerOfAttorneyTitleDescription; set => SetField(ref _powerOfAttorneyTitleDescription, value); }

    /// <summary>
    /// Borrower PresentlyDelinquentIndicator [463], [464]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Have any past due obligations owed to/insured by any agency of the Federal Government\"}")]
    public bool? PresentlyDelinquentIndicator { get => _presentlyDelinquentIndicator; set => SetField(ref _presentlyDelinquentIndicator, value); }

    /// <summary>
    /// Borrower PresentlyDelinquentIndicatorURLA [URLA.X98], [URLA.X99]
    /// </summary>
    public bool? PresentlyDelinquentIndicatorURLA { get => _presentlyDelinquentIndicatorURLA; set => SetField(ref _presentlyDelinquentIndicatorURLA, value); }

    /// <summary>
    /// Borrower PreviousEmploymentDoesNotApply [URLA.X203], [URLA.X204]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Does Not Apply\"}")]
    public bool? PreviousEmploymentDoesNotApply { get => _previousEmploymentDoesNotApply; set => SetField(ref _previousEmploymentDoesNotApply, value); }

    /// <summary>
    /// Borrower PreviousGrossMonthlyIncome [URLA.X245], [URLA.X246]
    /// </summary>
    public decimal? PreviousGrossMonthlyIncome { get => _previousGrossMonthlyIncome; set => SetField(ref _previousGrossMonthlyIncome, value); }

    /// <summary>
    /// Borrower PrintOnAdditionalBorrowerPage [URLA.X121], [URLA.X122]
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
    /// Borrower PriorPropertyDeedInLieuConveyedIndicator [URLA.X102], [URLA.X103]
    /// </summary>
    public bool? PriorPropertyDeedInLieuConveyedIndicator { get => _priorPropertyDeedInLieuConveyedIndicator; set => SetField(ref _priorPropertyDeedInLieuConveyedIndicator, value); }

    /// <summary>
    /// Borrower PriorPropertyForeclosureCompletedIndicator [URLA.X106], [URLA.X107]
    /// </summary>
    public bool? PriorPropertyForeclosureCompletedIndicator { get => _priorPropertyForeclosureCompletedIndicator; set => SetField(ref _priorPropertyForeclosureCompletedIndicator, value); }

    /// <summary>
    /// Borrower PriorPropertyShortSaleCompletedIndicator [URLA.X104], [URLA.X105]
    /// </summary>
    public bool? PriorPropertyShortSaleCompletedIndicator { get => _priorPropertyShortSaleCompletedIndicator; set => SetField(ref _priorPropertyShortSaleCompletedIndicator, value); }

    /// <summary>
    /// Borrower PriorPropertyTitleType [1069], [1070]
    /// </summary>
    public StringEnumValue<PriorPropertyTitleType> PriorPropertyTitleType { get => _priorPropertyTitleType; set => SetField(ref _priorPropertyTitleType, value); }

    /// <summary>
    /// Borrower PriorPropertyUsageType [981], [1015]
    /// </summary>
    public StringEnumValue<PriorPropertyUsageType> PriorPropertyUsageType { get => _priorPropertyUsageType; set => SetField(ref _priorPropertyUsageType, value); }

    /// <summary>
    /// Borrower PriorResidenceDoesNotApply [URLA.X265], [URLA.X266]
    /// </summary>
    public bool? PriorResidenceDoesNotApply { get => _priorResidenceDoesNotApply; set => SetField(ref _priorResidenceDoesNotApply, value); }

    /// <summary>
    /// Borrower PropertyForeclosedPastSevenYearsIndicator [170], [176]
    /// </summary>
    public bool? PropertyForeclosedPastSevenYearsIndicator { get => _propertyForeclosedPastSevenYearsIndicator; set => SetField(ref _propertyForeclosedPastSevenYearsIndicator, value); }

    /// <summary>
    /// Borrower PropertyProposedCleanEnergyLienIndicator [URLA.X94], [URLA.X95]
    /// </summary>
    public bool? PropertyProposedCleanEnergyLienIndicator { get => _propertyProposedCleanEnergyLienIndicator; set => SetField(ref _propertyProposedCleanEnergyLienIndicator, value); }

    /// <summary>
    /// Borrower RealEstateDoesNotApply [URLA.X69], [URLA.X110]
    /// </summary>
    public bool? RealEstateDoesNotApply { get => _realEstateDoesNotApply; set => SetField(ref _realEstateDoesNotApply, value); }

    /// <summary>
    /// Borrower RelationshipDescription [USDA.X11], [USDA.X14]
    /// </summary>
    public string? RelationshipDescription { get => _relationshipDescription; set => SetField(ref _relationshipDescription, value); }

    /// <summary>
    /// Borrower RelationshipWithRDEmployeeIndicator [USDA.X10], [USDA.X13]
    /// </summary>
    public bool? RelationshipWithRDEmployeeIndicator { get => _relationshipWithRDEmployeeIndicator; set => SetField(ref _relationshipWithRDEmployeeIndicator, value); }

    /// <summary>
    /// Borrower ReserveNationalGuardReserveActivated [URLA.X125], [URLA.X128]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Only period of service was as a non-activated member of the Reserve or National Guard\"}")]
    public bool? ReserveNationalGuardReserveActivated { get => _reserveNationalGuardReserveActivated; set => SetField(ref _reserveNationalGuardReserveActivated, value); }

    /// <summary>
    /// Borrower RetirementPensionIncomeAvailable [MORNET.X127], [MORNET.X139]
    /// </summary>
    public bool? RetirementPensionIncomeAvailable { get => _retirementPensionIncomeAvailable; set => SetField(ref _retirementPensionIncomeAvailable, value); }

    /// <summary>
    /// Borrower RwtFannieVoe1Date [TQL.X147], [TQL.X197]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe1Date { get => _rwtFannieVoe1Date; set => SetField(ref _rwtFannieVoe1Date, value); }

    /// <summary>
    /// Borrower RwtFannieVoe1Description [TQL.X142], [TQL.X192]
    /// </summary>
    public string? RwtFannieVoe1Description { get => _rwtFannieVoe1Description; set => SetField(ref _rwtFannieVoe1Description, value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Date [TQL.X148], [TQL.X198]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe2Date { get => _rwtFannieVoe2Date; set => SetField(ref _rwtFannieVoe2Date, value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Description [TQL.X143], [TQL.X193]
    /// </summary>
    public string? RwtFannieVoe2Description { get => _rwtFannieVoe2Description; set => SetField(ref _rwtFannieVoe2Description, value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Message [TQL.X150], [TQL.X200]
    /// </summary>
    public string? RwtFannieVoe2Message { get => _rwtFannieVoe2Message; set => SetField(ref _rwtFannieVoe2Message, value); }

    /// <summary>
    /// Borrower RwtFannieVoe2Status [TQL.X145], [TQL.X195]
    /// </summary>
    public string? RwtFannieVoe2Status { get => _rwtFannieVoe2Status; set => SetField(ref _rwtFannieVoe2Status, value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Date [TQL.X149], [TQL.X199]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoe3Date { get => _rwtFannieVoe3Date; set => SetField(ref _rwtFannieVoe3Date, value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Description [TQL.X144], [TQL.X194]
    /// </summary>
    public string? RwtFannieVoe3Description { get => _rwtFannieVoe3Description; set => SetField(ref _rwtFannieVoe3Description, value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Message [TQL.X151], [TQL.X201]
    /// </summary>
    public string? RwtFannieVoe3Message { get => _rwtFannieVoe3Message; set => SetField(ref _rwtFannieVoe3Message, value); }

    /// <summary>
    /// Borrower RwtFannieVoe3Status [TQL.X146], [TQL.X196]
    /// </summary>
    public string? RwtFannieVoe3Status { get => _rwtFannieVoe3Status; set => SetField(ref _rwtFannieVoe3Status, value); }

    /// <summary>
    /// Borrower RwtFannieVoiBaseIncomeDate [TQL.X164], [TQL.X214]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiBaseIncomeDate { get => _rwtFannieVoiBaseIncomeDate; set => SetField(ref _rwtFannieVoiBaseIncomeDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiBonusDate [TQL.X165], [TQL.X215]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiBonusDate { get => _rwtFannieVoiBonusDate; set => SetField(ref _rwtFannieVoiBonusDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiCommissionDate [TQL.X167], [TQL.X217]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiCommissionDate { get => _rwtFannieVoiCommissionDate; set => SetField(ref _rwtFannieVoiCommissionDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiOvertimeDate [TQL.X166], [TQL.X216]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiOvertimeDate { get => _rwtFannieVoiOvertimeDate; set => SetField(ref _rwtFannieVoiOvertimeDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiRetirementDate [TQL.X169], [TQL.X219]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiRetirementDate { get => _rwtFannieVoiRetirementDate; set => SetField(ref _rwtFannieVoiRetirementDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiSelfEmployedDate [TQL.X170], [TQL.X220]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiSelfEmployedDate { get => _rwtFannieVoiSelfEmployedDate; set => SetField(ref _rwtFannieVoiSelfEmployedDate, value); }

    /// <summary>
    /// Borrower RwtFannieVoiSocialSecurityDate [TQL.X168], [TQL.X218]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFannieVoiSocialSecurityDate { get => _rwtFannieVoiSocialSecurityDate; set => SetField(ref _rwtFannieVoiSocialSecurityDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Date [TQL.X158], [TQL.X208]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe1Date { get => _rwtFreddieVoe1Date; set => SetField(ref _rwtFreddieVoe1Date, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Description [TQL.X152], [TQL.X202]
    /// </summary>
    public string? RwtFreddieVoe1Description { get => _rwtFreddieVoe1Description; set => SetField(ref _rwtFreddieVoe1Description, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Message [TQL.X161], [TQL.X211]
    /// </summary>
    public string? RwtFreddieVoe1Message { get => _rwtFreddieVoe1Message; set => SetField(ref _rwtFreddieVoe1Message, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe1Status [TQL.X155], [TQL.X205]
    /// </summary>
    public string? RwtFreddieVoe1Status { get => _rwtFreddieVoe1Status; set => SetField(ref _rwtFreddieVoe1Status, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Date [TQL.X159], [TQL.X209]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe2Date { get => _rwtFreddieVoe2Date; set => SetField(ref _rwtFreddieVoe2Date, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Description [TQL.X153], [TQL.X203]
    /// </summary>
    public string? RwtFreddieVoe2Description { get => _rwtFreddieVoe2Description; set => SetField(ref _rwtFreddieVoe2Description, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Message [TQL.X162], [TQL.X212]
    /// </summary>
    public string? RwtFreddieVoe2Message { get => _rwtFreddieVoe2Message; set => SetField(ref _rwtFreddieVoe2Message, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe2Status [TQL.X156], [TQL.X206]
    /// </summary>
    public string? RwtFreddieVoe2Status { get => _rwtFreddieVoe2Status; set => SetField(ref _rwtFreddieVoe2Status, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Date [TQL.X160], [TQL.X210]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoe3Date { get => _rwtFreddieVoe3Date; set => SetField(ref _rwtFreddieVoe3Date, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Description [TQL.X154], [TQL.X204]
    /// </summary>
    public string? RwtFreddieVoe3Description { get => _rwtFreddieVoe3Description; set => SetField(ref _rwtFreddieVoe3Description, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Message [TQL.X163], [TQL.X213]
    /// </summary>
    public string? RwtFreddieVoe3Message { get => _rwtFreddieVoe3Message; set => SetField(ref _rwtFreddieVoe3Message, value); }

    /// <summary>
    /// Borrower RwtFreddieVoe3Status [TQL.X157], [TQL.X207]
    /// </summary>
    public string? RwtFreddieVoe3Status { get => _rwtFreddieVoe3Status; set => SetField(ref _rwtFreddieVoe3Status, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportDate [TQL.X183], [TQL.X233]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiChildSupportDate { get => _rwtFreddieVoiChildSupportDate; set => SetField(ref _rwtFreddieVoiChildSupportDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportMessage [TQL.X190], [TQL.X240]
    /// </summary>
    public string? RwtFreddieVoiChildSupportMessage { get => _rwtFreddieVoiChildSupportMessage; set => SetField(ref _rwtFreddieVoiChildSupportMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiChildSupportStatus [TQL.X176], [TQL.X226]
    /// </summary>
    public string? RwtFreddieVoiChildSupportStatus { get => _rwtFreddieVoiChildSupportStatus; set => SetField(ref _rwtFreddieVoiChildSupportStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryDate [TQL.X182], [TQL.X232]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiMilitaryDate { get => _rwtFreddieVoiMilitaryDate; set => SetField(ref _rwtFreddieVoiMilitaryDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryMessage [TQL.X189], [TQL.X239]
    /// </summary>
    public string? RwtFreddieVoiMilitaryMessage { get => _rwtFreddieVoiMilitaryMessage; set => SetField(ref _rwtFreddieVoiMilitaryMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiMilitaryStatus [TQL.X175], [TQL.X225]
    /// </summary>
    public string? RwtFreddieVoiMilitaryStatus { get => _rwtFreddieVoiMilitaryStatus; set => SetField(ref _rwtFreddieVoiMilitaryStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollDate [TQL.X178], [TQL.X228]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiPayrollDate { get => _rwtFreddieVoiPayrollDate; set => SetField(ref _rwtFreddieVoiPayrollDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollMessage [TQL.X185], [TQL.X235]
    /// </summary>
    public string? RwtFreddieVoiPayrollMessage { get => _rwtFreddieVoiPayrollMessage; set => SetField(ref _rwtFreddieVoiPayrollMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPayrollStatus [TQL.X171], [TQL.X221]
    /// </summary>
    public string? RwtFreddieVoiPayrollStatus { get => _rwtFreddieVoiPayrollStatus; set => SetField(ref _rwtFreddieVoiPayrollStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionDate [TQL.X179], [TQL.X229]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiPensionDate { get => _rwtFreddieVoiPensionDate; set => SetField(ref _rwtFreddieVoiPensionDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionMessage [TQL.X186], [TQL.X236]
    /// </summary>
    public string? RwtFreddieVoiPensionMessage { get => _rwtFreddieVoiPensionMessage; set => SetField(ref _rwtFreddieVoiPensionMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiPensionStatus [TQL.X172], [TQL.X222]
    /// </summary>
    public string? RwtFreddieVoiPensionStatus { get => _rwtFreddieVoiPensionStatus; set => SetField(ref _rwtFreddieVoiPensionStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedDate [TQL.X184], [TQL.X234]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiSelfEmployedDate { get => _rwtFreddieVoiSelfEmployedDate; set => SetField(ref _rwtFreddieVoiSelfEmployedDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedMessage [TQL.X191], [TQL.X241]
    /// </summary>
    public string? RwtFreddieVoiSelfEmployedMessage { get => _rwtFreddieVoiSelfEmployedMessage; set => SetField(ref _rwtFreddieVoiSelfEmployedMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSelfEmployedStatus [TQL.X177], [TQL.X227]
    /// </summary>
    public string? RwtFreddieVoiSelfEmployedStatus { get => _rwtFreddieVoiSelfEmployedStatus; set => SetField(ref _rwtFreddieVoiSelfEmployedStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityDate [TQL.X180], [TQL.X230]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiSocialSecurityDate { get => _rwtFreddieVoiSocialSecurityDate; set => SetField(ref _rwtFreddieVoiSocialSecurityDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityMessage [TQL.X187], [TQL.X237]
    /// </summary>
    public string? RwtFreddieVoiSocialSecurityMessage { get => _rwtFreddieVoiSocialSecurityMessage; set => SetField(ref _rwtFreddieVoiSocialSecurityMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiSocialSecurityStatus [TQL.X173], [TQL.X223]
    /// </summary>
    public string? RwtFreddieVoiSocialSecurityStatus { get => _rwtFreddieVoiSocialSecurityStatus; set => SetField(ref _rwtFreddieVoiSocialSecurityStatus, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsDate [TQL.X181], [TQL.X231]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? RwtFreddieVoiVaBenefitsDate { get => _rwtFreddieVoiVaBenefitsDate; set => SetField(ref _rwtFreddieVoiVaBenefitsDate, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsMessage [TQL.X188], [TQL.X238]
    /// </summary>
    public string? RwtFreddieVoiVaBenefitsMessage { get => _rwtFreddieVoiVaBenefitsMessage; set => SetField(ref _rwtFreddieVoiVaBenefitsMessage, value); }

    /// <summary>
    /// Borrower RwtFreddieVoiVaBenefitsStatus [TQL.X174], [TQL.X224]
    /// </summary>
    public string? RwtFreddieVoiVaBenefitsStatus { get => _rwtFreddieVoiVaBenefitsStatus; set => SetField(ref _rwtFreddieVoiVaBenefitsStatus, value); }

    /// <summary>
    /// Borrower SchoolingTermYears [39], [71]
    /// </summary>
    public int? SchoolingTermYears { get => _schoolingTermYears; set => SetField(ref _schoolingTermYears, value); }

    /// <summary>
    /// Borrower SectionAExplanation [URLA.X216], [URLA.X271]
    /// </summary>
    public string? SectionAExplanation { get => _sectionAExplanation; set => SetField(ref _sectionAExplanation, value); }

    /// <summary>
    /// Borrower SectionAPrintExplanation [URLA.X247], [URLA.X285]
    /// </summary>
    public bool? SectionAPrintExplanation { get => _sectionAPrintExplanation; set => SetField(ref _sectionAPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionBExplanation [URLA.X217], [URLA.X272]
    /// </summary>
    public string? SectionBExplanation { get => _sectionBExplanation; set => SetField(ref _sectionBExplanation, value); }

    /// <summary>
    /// Borrower SectionBPrintExplanation [URLA.X248], [URLA.X286]
    /// </summary>
    public bool? SectionBPrintExplanation { get => _sectionBPrintExplanation; set => SetField(ref _sectionBPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionCExplanation [URLA.X218], [URLA.X273]
    /// </summary>
    public string? SectionCExplanation { get => _sectionCExplanation; set => SetField(ref _sectionCExplanation, value); }

    /// <summary>
    /// Borrower SectionCPrintExplanation [URLA.X249], [URLA.X287]
    /// </summary>
    public bool? SectionCPrintExplanation { get => _sectionCPrintExplanation; set => SetField(ref _sectionCPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionD1PrintExplanation [URLA.X250], [URLA.X288]
    /// </summary>
    public bool? SectionD1PrintExplanation { get => _sectionD1PrintExplanation; set => SetField(ref _sectionD1PrintExplanation, value); }

    /// <summary>
    /// Borrower SectionD2Explanation [URLA.X235], [URLA.X275]
    /// </summary>
    public string? SectionD2Explanation { get => _sectionD2Explanation; set => SetField(ref _sectionD2Explanation, value); }

    /// <summary>
    /// Borrower SectionD2PrintExplanation [URLA.X251], [URLA.X289]
    /// </summary>
    public bool? SectionD2PrintExplanation { get => _sectionD2PrintExplanation; set => SetField(ref _sectionD2PrintExplanation, value); }

    /// <summary>
    /// Borrower SectionDExplanation [URLA.X219], [URLA.X274]
    /// </summary>
    public string? SectionDExplanation { get => _sectionDExplanation; set => SetField(ref _sectionDExplanation, value); }

    /// <summary>
    /// Borrower SectionEExplanation [URLA.X220], [URLA.X276]
    /// </summary>
    public string? SectionEExplanation { get => _sectionEExplanation; set => SetField(ref _sectionEExplanation, value); }

    /// <summary>
    /// Borrower SectionEPrintExplanation [URLA.X252], [URLA.X290]
    /// </summary>
    public bool? SectionEPrintExplanation { get => _sectionEPrintExplanation; set => SetField(ref _sectionEPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionFExplanation [URLA.X221], [URLA.X277]
    /// </summary>
    public string? SectionFExplanation { get => _sectionFExplanation; set => SetField(ref _sectionFExplanation, value); }

    /// <summary>
    /// Borrower SectionFPrintExplanation [URLA.X253], [URLA.X291]
    /// </summary>
    public bool? SectionFPrintExplanation { get => _sectionFPrintExplanation; set => SetField(ref _sectionFPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionGExplanation [URLA.X222], [URLA.X278]
    /// </summary>
    public string? SectionGExplanation { get => _sectionGExplanation; set => SetField(ref _sectionGExplanation, value); }

    /// <summary>
    /// Borrower SectionGPrintExplanation [URLA.X254], [URLA.X292]
    /// </summary>
    public bool? SectionGPrintExplanation { get => _sectionGPrintExplanation; set => SetField(ref _sectionGPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionHExplanation [URLA.X223], [URLA.X279]
    /// </summary>
    public string? SectionHExplanation { get => _sectionHExplanation; set => SetField(ref _sectionHExplanation, value); }

    /// <summary>
    /// Borrower SectionHPrintExplanation [URLA.X255], [URLA.X293]
    /// </summary>
    public bool? SectionHPrintExplanation { get => _sectionHPrintExplanation; set => SetField(ref _sectionHPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionIExplanation [URLA.X224], [URLA.X280]
    /// </summary>
    public string? SectionIExplanation { get => _sectionIExplanation; set => SetField(ref _sectionIExplanation, value); }

    /// <summary>
    /// Borrower SectionIPrintExplanation [URLA.X256], [URLA.X294]
    /// </summary>
    public bool? SectionIPrintExplanation { get => _sectionIPrintExplanation; set => SetField(ref _sectionIPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionJExplanation [URLA.X225], [URLA.X281]
    /// </summary>
    public string? SectionJExplanation { get => _sectionJExplanation; set => SetField(ref _sectionJExplanation, value); }

    /// <summary>
    /// Borrower SectionJPrintExplanation [URLA.X257], [URLA.X295]
    /// </summary>
    public bool? SectionJPrintExplanation { get => _sectionJPrintExplanation; set => SetField(ref _sectionJPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionKExplanation [URLA.X226], [URLA.X282]
    /// </summary>
    public string? SectionKExplanation { get => _sectionKExplanation; set => SetField(ref _sectionKExplanation, value); }

    /// <summary>
    /// Borrower SectionKPrintExplanation [URLA.X258], [URLA.X296]
    /// </summary>
    public bool? SectionKPrintExplanation { get => _sectionKPrintExplanation; set => SetField(ref _sectionKPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionLExplanation [URLA.X227], [URLA.X283]
    /// </summary>
    public string? SectionLExplanation { get => _sectionLExplanation; set => SetField(ref _sectionLExplanation, value); }

    /// <summary>
    /// Borrower SectionLPrintExplanation [URLA.X259], [URLA.X297]
    /// </summary>
    public bool? SectionLPrintExplanation { get => _sectionLPrintExplanation; set => SetField(ref _sectionLPrintExplanation, value); }

    /// <summary>
    /// Borrower SectionMExplanation [URLA.X228], [URLA.X284]
    /// </summary>
    public string? SectionMExplanation { get => _sectionMExplanation; set => SetField(ref _sectionMExplanation, value); }

    /// <summary>
    /// Borrower SectionMPrintExplanation [URLA.X260], [URLA.X298]
    /// </summary>
    public bool? SectionMPrintExplanation { get => _sectionMPrintExplanation; set => SetField(ref _sectionMPrintExplanation, value); }

    /// <summary>
    /// Borrower SelfDeclaredMilitaryServiceIndicator [URLA.X13], [URLA.X14]
    /// </summary>
    public bool? SelfDeclaredMilitaryServiceIndicator { get => _selfDeclaredMilitaryServiceIndicator; set => SetField(ref _selfDeclaredMilitaryServiceIndicator, value); }

    /// <summary>
    /// Borrower SelfEmployedValidationMessage [MORNET.X137], [MORNET.X149]
    /// </summary>
    public string? SelfEmployedValidationMessage { get => _selfEmployedValidationMessage; set => SetField(ref _selfEmployedValidationMessage, value); }

    /// <summary>
    /// Borrower SpecialBorrowerSellerRelationshipIndicator [URLA.X84], [URLA.X85]
    /// </summary>
    public bool? SpecialBorrowerSellerRelationshipIndicator { get => _specialBorrowerSellerRelationshipIndicator; set => SetField(ref _specialBorrowerSellerRelationshipIndicator, value); }

    /// <summary>
    /// Borrower SpousalVABenefitsEligibilityIndicator [URLA.X19], [URLA.X20]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Surviving Spouse\"}")]
    public bool? SpousalVABenefitsEligibilityIndicator { get => _spousalVABenefitsEligibilityIndicator; set => SetField(ref _spousalVABenefitsEligibilityIndicator, value); }

    /// <summary>
    /// Borrower SSA89ApplyForLoan [4717], [4718]
    /// </summary>
    public bool? SSA89ApplyForLoan { get => _sSA89ApplyForLoan; set => SetField(ref _sSA89ApplyForLoan, value); }

    /// <summary>
    /// Borrower SSA89BackgroundCheckIndicator [3862], [3868]
    /// </summary>
    public bool? SSA89BackgroundCheckIndicator { get => _sSA89BackgroundCheckIndicator; set => SetField(ref _sSA89BackgroundCheckIndicator, value); }

    /// <summary>
    /// Borrower SSA89BankingServiceIndicator [3861], [3867]
    /// </summary>
    public bool? SSA89BankingServiceIndicator { get => _sSA89BankingServiceIndicator; set => SetField(ref _sSA89BankingServiceIndicator, value); }

    /// <summary>
    /// Borrower SSA89CreditCheckIndicator [3864], [3870]
    /// </summary>
    public bool? SSA89CreditCheckIndicator { get => _sSA89CreditCheckIndicator; set => SetField(ref _sSA89CreditCheckIndicator, value); }

    /// <summary>
    /// Borrower SSA89DescriptionForOther [4719], [4720]
    /// </summary>
    public string? SSA89DescriptionForOther { get => _sSA89DescriptionForOther; set => SetField(ref _sSA89DescriptionForOther, value); }

    /// <summary>
    /// Borrower SSA89LicenseRequirementIndicator [3863], [3869]
    /// </summary>
    public bool? SSA89LicenseRequirementIndicator { get => _sSA89LicenseRequirementIndicator; set => SetField(ref _sSA89LicenseRequirementIndicator, value); }

    /// <summary>
    /// Borrower SSA89MortgageServiceIndicator [3860], [3866]
    /// </summary>
    public bool? SSA89MortgageServiceIndicator { get => _sSA89MortgageServiceIndicator; set => SetField(ref _sSA89MortgageServiceIndicator, value); }

    /// <summary>
    /// Borrower SSA89OpenRetirementAcct [4715], [4716]
    /// </summary>
    public bool? SSA89OpenRetirementAcct { get => _sSA89OpenRetirementAcct; set => SetField(ref _sSA89OpenRetirementAcct, value); }

    /// <summary>
    /// Borrower SSA89OtherIndicator [3865], [3871]
    /// </summary>
    public bool? SSA89OtherIndicator { get => _sSA89OtherIndicator; set => SetField(ref _sSA89OtherIndicator, value); }

    /// <summary>
    /// Borrower SSNValidationMessage [MORNET.X136], [MORNET.X148]
    /// </summary>
    public string? SSNValidationMessage { get => _sSNValidationMessage; set => SetField(ref _sSNValidationMessage, value); }

    /// <summary>
    /// Borrower State [URLA.X117], [URLA.X118]
    /// </summary>
    public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// Assets Subtotal Liquid Assets [915]
    /// </summary>
    public decimal? SubtotalLiquidAssetsMinusGiftAmount { get => _subtotalLiquidAssetsMinusGiftAmount; set => SetField(ref _subtotalLiquidAssetsMinusGiftAmount, value); }

    /// <summary>
    /// Borrower SuffixToName [4003], [4007]
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
    /// Borrower Tax4506TotalYearlyIncome1 [3319], [3323]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome1 { get => _tax4506TotalYearlyIncome1; set => SetField(ref _tax4506TotalYearlyIncome1, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome2 [3320], [3324]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome2 { get => _tax4506TotalYearlyIncome2; set => SetField(ref _tax4506TotalYearlyIncome2, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome3 [TQL.X14], [TQL.X16]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome3 { get => _tax4506TotalYearlyIncome3; set => SetField(ref _tax4506TotalYearlyIncome3, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyIncome4 [TQL.X15], [TQL.X17]
    /// </summary>
    public decimal? Tax4506TotalYearlyIncome4 { get => _tax4506TotalYearlyIncome4; set => SetField(ref _tax4506TotalYearlyIncome4, value); }

    /// <summary>
    /// Income Year 1 Total Joint Income Borr and Co-Borrower [3327]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome1 { get => _tax4506TotalYearlyJointIncome1; set => SetField(ref _tax4506TotalYearlyJointIncome1, value); }

    /// <summary>
    /// Income Year 2 Total Joint Income Borr and Co-Borrower [3328]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome2 { get => _tax4506TotalYearlyJointIncome2; set => SetField(ref _tax4506TotalYearlyJointIncome2, value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 3 Total Joint Income Borr and Co-Borrower [TQL.X18]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome3 { get => _tax4506TotalYearlyJointIncome3; set => SetField(ref _tax4506TotalYearlyJointIncome3, value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 4 Total Joint Income Borr and Co-Borrower [TQL.X19]
    /// </summary>
    public decimal? Tax4506TotalYearlyJointIncome4 { get => _tax4506TotalYearlyJointIncome4; set => SetField(ref _tax4506TotalYearlyJointIncome4, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome1 [3321], [3325]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome1 { get => _tax4506TotalYearlyVarianceIncome1; set => SetField(ref _tax4506TotalYearlyVarianceIncome1, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome2 [3322], [3326]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome2 { get => _tax4506TotalYearlyVarianceIncome2; set => SetField(ref _tax4506TotalYearlyVarianceIncome2, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome3 [TQL.X20], [TQL.X22]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome3 { get => _tax4506TotalYearlyVarianceIncome3; set => SetField(ref _tax4506TotalYearlyVarianceIncome3, value); }

    /// <summary>
    /// Borrower Tax4506TotalYearlyVarianceIncome4 [TQL.X21], [TQL.X23]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceIncome4 { get => _tax4506TotalYearlyVarianceIncome4; set => SetField(ref _tax4506TotalYearlyVarianceIncome4, value); }

    /// <summary>
    /// Income Year 1 Total Variance Joint Income Borr and Co-Borrower [3329]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get => _tax4506TotalYearlyVarianceJointIncome1; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome1, value); }

    /// <summary>
    /// Income Year 2 Total Variance Joint Income Borr and Co-Borrower [3330]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get => _tax4506TotalYearlyVarianceJointIncome2; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome2, value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 3 Total Variance Joint Income Borr and Co-Borrower [TQL.X24]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get => _tax4506TotalYearlyVarianceJointIncome3; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome3, value); }

    /// <summary>
    /// TQL - Coborrower 4506T Orders - Income Year 4 Total Variance Joint Income Borr and Co-Borrower [TQL.X25]
    /// </summary>
    public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get => _tax4506TotalYearlyVarianceJointIncome4; set => SetField(ref _tax4506TotalYearlyVarianceJointIncome4, value); }

    /// <summary>
    /// Borrower TaxIdentificationIdentifier [65], [97]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
    public string? TaxIdentificationIdentifier { get => _taxIdentificationIdentifier; set => SetField(ref _taxIdentificationIdentifier, value); }

    /// <summary>
    /// Borrower TaxReturnValidationMessage [MORNET.X138], [MORNET.X150]
    /// </summary>
    public string? TaxReturnValidationMessage { get => _taxReturnValidationMessage; set => SetField(ref _taxReturnValidationMessage, value); }

    /// <summary>
    /// Fannie Mae Top Ratio [MORNET.X158]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
    public decimal? TopRatioPercent { get => _topRatioPercent; set => SetField(ref _topRatioPercent, value); }

    /// <summary>
    /// Total Additional Liabilities Amount [URLA.X61]
    /// </summary>
    public decimal? TotalAdditionalLiabilitiesAmount { get => _totalAdditionalLiabilitiesAmount; set => SetField(ref _totalAdditionalLiabilitiesAmount, value); }

    /// <summary>
    /// Total Additional Other Liabilities Amount [URLA.X67]
    /// </summary>
    public decimal? TotalAdditionalOtherLiabilitiesAmount { get => _totalAdditionalOtherLiabilitiesAmount; set => SetField(ref _totalAdditionalOtherLiabilitiesAmount, value); }

    /// <summary>
    /// Borrower TotalAnnualIncome [CORRESPONDENT.X45], [CORRESPONDENT.X46]
    /// </summary>
    public decimal? TotalAnnualIncome { get => _totalAnnualIncome; set => SetField(ref _totalAnnualIncome, value); }

    /// <summary>
    /// Borrower TotalAssets [URLA.X55], [URLA.X56]
    /// </summary>
    public decimal? TotalAssets { get => _totalAssets; set => SetField(ref _totalAssets, value); }

    /// <summary>
    /// Income Total Mo Income (Borr/Co-Borr) [MORNET.X160]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalGrossMonthlyIncomeAmount { get => _totalGrossMonthlyIncomeAmount; set => SetField(ref _totalGrossMonthlyIncomeAmount, value); }

    /// <summary>
    /// Borrower TotalGrossMonthlySalary [CORRESPONDENT.X47], [CORRESPONDENT.X48]
    /// </summary>
    public decimal? TotalGrossMonthlySalary { get => _totalGrossMonthlySalary; set => SetField(ref _totalGrossMonthlySalary, value); }

    /// <summary>
    /// Total Liabilities Amount [URLA.X62]
    /// </summary>
    public decimal? TotalLiabilitiesAmount { get => _totalLiabilitiesAmount; set => SetField(ref _totalLiabilitiesAmount, value); }

    /// <summary>
    /// Liabilities Total Liability Balance [733]
    /// </summary>
    public decimal? TotalLiabilitiesBalanceAmount { get => _totalLiabilitiesBalanceAmount; set => SetField(ref _totalLiabilitiesBalanceAmount, value); }

    /// <summary>
    /// Borrower TotalMonthlyIncomeAmount [1758], [1759]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyIncomeAmount { get => _totalMonthlyIncomeAmount; set => SetField(ref _totalMonthlyIncomeAmount, value); }

    /// <summary>
    /// Borrower TotalMonthlyIncomeMinusNetRentalAmount [910], [911]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get => _totalMonthlyIncomeMinusNetRentalAmount; set => SetField(ref _totalMonthlyIncomeMinusNetRentalAmount, value); }

    /// <summary>
    /// Borrower TotalOtherAssets [URLA.X57], [URLA.X58]
    /// </summary>
    public decimal? TotalOtherAssets { get => _totalOtherAssets; set => SetField(ref _totalOtherAssets, value); }

    /// <summary>
    /// Borrower TotalOtherIncome [CORRESPONDENT.X49], [CORRESPONDENT.X50]
    /// </summary>
    public decimal? TotalOtherIncome { get => _totalOtherIncome; set => SetField(ref _totalOtherIncome, value); }

    /// <summary>
    /// Borrower TotalOtherLiabilities [URLA.X65], [URLA.X66]
    /// </summary>
    public decimal? TotalOtherLiabilities { get => _totalOtherLiabilities; set => SetField(ref _totalOtherLiabilities, value); }

    /// <summary>
    /// Total Other Liabilities Amount [URLA.X68]
    /// </summary>
    public decimal? TotalOtherLiabilitiesAmount { get => _totalOtherLiabilitiesAmount; set => SetField(ref _totalOtherLiabilitiesAmount, value); }

    /// <summary>
    /// Borrower TotalOtherMonthlyLiability [CORRESPONDENT.X51], [CORRESPONDENT.X52]
    /// </summary>
    public decimal? TotalOtherMonthlyLiability { get => _totalOtherMonthlyLiability; set => SetField(ref _totalOtherMonthlyLiability, value); }

    /// <summary>
    /// Expenses Present Total Housing [737]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPresentHousingExpenseAmount { get => _totalPresentHousingExpenseAmount; set => SetField(ref _totalPresentHousingExpenseAmount, value); }

    /// <summary>
    /// Borrower TransactionPurposeDescription [3249], [3251]
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
    /// Borrower TransUnionCreditScoreForDisclosure [DISCLOSURE.X627], [DISCLOSURE.X628]
    /// </summary>
    public bool? TransUnionCreditScoreForDisclosure { get => _transUnionCreditScoreForDisclosure; set => SetField(ref _transUnionCreditScoreForDisclosure, value); }

    /// <summary>
    /// Borrower TransUnionCreditScoreRanksPercent [DISCLOSURE.X633], [DISCLOSURE.X634]
    /// </summary>
    public int? TransUnionCreditScoreRanksPercent { get => _transUnionCreditScoreRanksPercent; set => SetField(ref _transUnionCreditScoreRanksPercent, value); }

    /// <summary>
    /// Borrower TransUnionDatePulled [DISCLOSURE.X31], [DISCLOSURE.X32]
    /// </summary>
    public DateTime? TransUnionDatePulled { get => _transUnionDatePulled; set => SetField(ref _transUnionDatePulled, value); }

    /// <summary>
    /// Borrower TransUnionFactorCode1 [DISCLOSURE.X1007], [DISCLOSURE.X1012]
    /// </summary>
    public string? TransUnionFactorCode1 { get => _transUnionFactorCode1; set => SetField(ref _transUnionFactorCode1, value); }

    /// <summary>
    /// Borrower TransUnionFactorCode2 [DISCLOSURE.X1008], [DISCLOSURE.X1013]
    /// </summary>
    public string? TransUnionFactorCode2 { get => _transUnionFactorCode2; set => SetField(ref _transUnionFactorCode2, value); }

    /// <summary>
    /// Borrower TransUnionFactorCode3 [DISCLOSURE.X1009], [DISCLOSURE.X1014]
    /// </summary>
    public string? TransUnionFactorCode3 { get => _transUnionFactorCode3; set => SetField(ref _transUnionFactorCode3, value); }

    /// <summary>
    /// Borrower TransUnionFactorCode4 [DISCLOSURE.X1010], [DISCLOSURE.X1015]
    /// </summary>
    public string? TransUnionFactorCode4 { get => _transUnionFactorCode4; set => SetField(ref _transUnionFactorCode4, value); }

    /// <summary>
    /// Borrower TransUnionFactorCode5 [DISCLOSURE.X1011], [DISCLOSURE.X1016]
    /// </summary>
    public string? TransUnionFactorCode5 { get => _transUnionFactorCode5; set => SetField(ref _transUnionFactorCode5, value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor1 [DISCLOSURE.X33], [DISCLOSURE.X37]
    /// </summary>
    public string? TransUnionKeyFactor1 { get => _transUnionKeyFactor1; set => SetField(ref _transUnionKeyFactor1, value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor2 [DISCLOSURE.X34], [DISCLOSURE.X38]
    /// </summary>
    public string? TransUnionKeyFactor2 { get => _transUnionKeyFactor2; set => SetField(ref _transUnionKeyFactor2, value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor3 [DISCLOSURE.X35], [DISCLOSURE.X39]
    /// </summary>
    public string? TransUnionKeyFactor3 { get => _transUnionKeyFactor3; set => SetField(ref _transUnionKeyFactor3, value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor4 [DISCLOSURE.X36], [DISCLOSURE.X40]
    /// </summary>
    public string? TransUnionKeyFactor4 { get => _transUnionKeyFactor4; set => SetField(ref _transUnionKeyFactor4, value); }

    /// <summary>
    /// Borrower TransUnionKeyFactor5 [DISCLOSURE.X174], [DISCLOSURE.X177]
    /// </summary>
    public string? TransUnionKeyFactor5 { get => _transUnionKeyFactor5; set => SetField(ref _transUnionKeyFactor5, value); }

    /// <summary>
    /// Borrower TransUnionMaterialTermsCreditByScore [DISCLOSURE.X945], [DISCLOSURE.X946]
    /// </summary>
    public bool? TransUnionMaterialTermsCreditByScore { get => _transUnionMaterialTermsCreditByScore; set => SetField(ref _transUnionMaterialTermsCreditByScore, value); }

    /// <summary>
    /// Borrower TransUnionScore [1450], [1452]
    /// </summary>
    public string? TransUnionScore { get => _transUnionScore; set => SetField(ref _transUnionScore, value); }

    /// <summary>
    /// Borrower UndisclosedBorrowedFundsAmount [URLA.X88], [URLA.X89]
    /// </summary>
    public decimal? UndisclosedBorrowedFundsAmount { get => _undisclosedBorrowedFundsAmount; set => SetField(ref _undisclosedBorrowedFundsAmount, value); }

    /// <summary>
    /// Borrower UndisclosedBorrowedFundsIndicator [URLA.X86], [URLA.X87]
    /// </summary>
    public bool? UndisclosedBorrowedFundsIndicator { get => _undisclosedBorrowedFundsIndicator; set => SetField(ref _undisclosedBorrowedFundsIndicator, value); }

    /// <summary>
    /// Borrower UndisclosedComakerOfNoteIndicator [URLA.X96], [URLA.X97]
    /// </summary>
    public bool? UndisclosedComakerOfNoteIndicator { get => _undisclosedComakerOfNoteIndicator; set => SetField(ref _undisclosedComakerOfNoteIndicator, value); }

    /// <summary>
    /// Borrower UndisclosedCreditApplicationIndicator [URLA.X92], [URLA.X93]
    /// </summary>
    public bool? UndisclosedCreditApplicationIndicator { get => _undisclosedCreditApplicationIndicator; set => SetField(ref _undisclosedCreditApplicationIndicator, value); }

    /// <summary>
    /// Borrower UndisclosedMortgageApplicationIndicator [URLA.X90], [URLA.X91]
    /// </summary>
    public bool? UndisclosedMortgageApplicationIndicator { get => _undisclosedMortgageApplicationIndicator; set => SetField(ref _undisclosedMortgageApplicationIndicator, value); }

    /// <summary>
    /// Borrower Urla2020CitizenshipResidencyType [URLA.X1], [URLA.X2]
    /// </summary>
    public StringEnumValue<Urla2020CitizenshipResidencyType> Urla2020CitizenshipResidencyType { get => _urla2020CitizenshipResidencyType; set => SetField(ref _urla2020CitizenshipResidencyType, value); }

    /// <summary>
    /// Borrower Urla2020CountryOfCitizenship [URLA.X263], [URLA.X264]
    /// </summary>
    public string? Urla2020CountryOfCitizenship { get => _urla2020CountryOfCitizenship; set => SetField(ref _urla2020CountryOfCitizenship, value); }

    /// <summary>
    /// Borrower URLAAliasName [URLA.X195], [URLA.X196]
    /// </summary>
    public string? URLAAliasName { get => _uRLAAliasName; set => SetField(ref _uRLAAliasName, value); }

    /// <summary>
    /// Borrower UserDefinedIncome [1815], [1816]
    /// </summary>
    public decimal? UserDefinedIncome { get => _userDefinedIncome; set => SetField(ref _userDefinedIncome, value); }

    /// <summary>
    /// Borrower VaFederalTaxAmount [1156], [1306]
    /// </summary>
    public decimal? VaFederalTaxAmount { get => _vaFederalTaxAmount; set => SetField(ref _vaFederalTaxAmount, value); }

    /// <summary>
    /// Borrower ValidDaysForConsentCount [3250], [3252]
    /// </summary>
    public int? ValidDaysForConsentCount { get => _validDaysForConsentCount; set => SetField(ref _validDaysForConsentCount, value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Value Rep and Warranty [MORNET.X116]
    /// </summary>
    public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => SetField(ref _valueRepAndWarrantyAvailable, value); }

    /// <summary>
    /// Fannie Mae - Coborrower - Value Rep and Warranty Message [MORNET.X112]
    /// </summary>
    public string? ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => SetField(ref _valueRepAndWarrantyMessage, value); }

    /// <summary>
    /// Borrower VaNetTakeHomePayAmount [1313], [1314]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaNetTakeHomePayAmount { get => _vaNetTakeHomePayAmount; set => SetField(ref _vaNetTakeHomePayAmount, value); }

    /// <summary>
    /// Borrower VaOtherAmount [1309], [VALA.X19]
    /// </summary>
    public decimal? VaOtherAmount { get => _vaOtherAmount; set => SetField(ref _vaOtherAmount, value); }

    /// <summary>
    /// Borrower VaOtherNetIncomeAmount [1316], [1317]
    /// </summary>
    public decimal? VaOtherNetIncomeAmount { get => _vaOtherNetIncomeAmount; set => SetField(ref _vaOtherNetIncomeAmount, value); }

    /// <summary>
    /// Borrower VaRetirementAmount [1159], [1308]
    /// </summary>
    public decimal? VaRetirementAmount { get => _vaRetirementAmount; set => SetField(ref _vaRetirementAmount, value); }

    /// <summary>
    /// Borrower VaStateTaxAmount [1158], [1307]
    /// </summary>
    public decimal? VaStateTaxAmount { get => _vaStateTaxAmount; set => SetField(ref _vaStateTaxAmount, value); }

    /// <summary>
    /// Borrower VaTotalIncomeDeductionsAmount [1310], [1311]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaTotalIncomeDeductionsAmount { get => _vaTotalIncomeDeductionsAmount; set => SetField(ref _vaTotalIncomeDeductionsAmount, value); }

    /// <summary>
    /// Borrower VaTotalNetIncomeAmount [1319], [1320]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? VaTotalNetIncomeAmount { get => _vaTotalNetIncomeAmount; set => SetField(ref _vaTotalNetIncomeAmount, value); }

    /// <summary>
    /// Borrower Vendor1 [GSEVENDOR.X1], [GSEVENDOR.X2]
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
    /// Borrower Vendor2 [GSEVENDOR.X4], [GSEVENDOR.X5]
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
    /// Borrower Vendor3 [GSEVENDOR.X6], [GSEVENDOR.X7]
    /// </summary>
    public string? Vendor3 { get => _vendor3; set => SetField(ref _vendor3, value); }

    /// <summary>
    /// Borrower Vendor30 [GSEVENDOR.X37], [GSEVENDOR.X38]
    /// </summary>
    public string? Vendor30 { get => _vendor30; set => SetField(ref _vendor30, value); }

    /// <summary>
    /// Borrower Vendor31 [GSEVENDOR.X47], [GSEVENDOR.X48]
    /// </summary>
    public string? Vendor31 { get => _vendor31; set => SetField(ref _vendor31, value); }

    /// <summary>
    /// Borrower Vendor32 [GSEVENDOR.X49], [GSEVENDOR.X50]
    /// </summary>
    public string? Vendor32 { get => _vendor32; set => SetField(ref _vendor32, value); }

    /// <summary>
    /// Borrower Vendor33 [GSEVENDOR.X51], [GSEVENDOR.X52]
    /// </summary>
    public string? Vendor33 { get => _vendor33; set => SetField(ref _vendor33, value); }

    /// <summary>
    /// Borrower Vendor34 [GSEVENDOR.X53], [GSEVENDOR.X54]
    /// </summary>
    public string? Vendor34 { get => _vendor34; set => SetField(ref _vendor34, value); }

    /// <summary>
    /// Borrower Vendor35 [GSEVENDOR.X55], [GSEVENDOR.X56]
    /// </summary>
    public string? Vendor35 { get => _vendor35; set => SetField(ref _vendor35, value); }

    /// <summary>
    /// Borrower Vendor36 [GSEVENDOR.X57], [GSEVENDOR.X58]
    /// </summary>
    public string? Vendor36 { get => _vendor36; set => SetField(ref _vendor36, value); }

    /// <summary>
    /// Borrower Vendor37 [GSEVENDOR.X39], [GSEVENDOR.X40]
    /// </summary>
    public string? Vendor37 { get => _vendor37; set => SetField(ref _vendor37, value); }

    /// <summary>
    /// Borrower Vendor38 [GSEVENDOR.X41], [GSEVENDOR.X42]
    /// </summary>
    public string? Vendor38 { get => _vendor38; set => SetField(ref _vendor38, value); }

    /// <summary>
    /// Borrower Vendor39 [GSEVENDOR.X43], [GSEVENDOR.X44]
    /// </summary>
    public string? Vendor39 { get => _vendor39; set => SetField(ref _vendor39, value); }

    /// <summary>
    /// Borrower Vendor4 [GSEVENDOR.X8], [GSEVENDOR.X9]
    /// </summary>
    public string? Vendor4 { get => _vendor4; set => SetField(ref _vendor4, value); }

    /// <summary>
    /// Borrower Vendor40 [GSEVENDOR.X45], [GSEVENDOR.X46]
    /// </summary>
    public string? Vendor40 { get => _vendor40; set => SetField(ref _vendor40, value); }

    /// <summary>
    /// Borrower Vendor5 [GSEVENDOR.X10], [GSEVENDOR.X11]
    /// </summary>
    public string? Vendor5 { get => _vendor5; set => SetField(ref _vendor5, value); }

    /// <summary>
    /// Borrower Vendor6 [GSEVENDOR.X12], [GSEVENDOR.X13]
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
    /// Borrower VestingTrusteeOfType [Borr.TrusteeOf], [CoBorr.TrusteeOf]
    /// </summary>
    public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => SetField(ref _vestingTrusteeOfType, value); }

    /// <summary>
    /// Borrower Veteran [URLA.X124], [URLA.X127]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Currently retired, discharged, or separated from service\"}")]
    public bool? Veteran { get => _veteran; set => SetField(ref _veteran, value); }

    /// <summary>
    /// Borrower VeteranIndicator [USDA.X1], [USDA.X4]
    /// </summary>
    public bool? VeteranIndicator { get => _veteranIndicator; set => SetField(ref _veteranIndicator, value); }

    /// <summary>
    /// Borrower VvoeWorkNumberDate [CORRESPONDENT.X459], [CORRESPONDENT.X460]
    /// </summary>
    public DateTime? VvoeWorkNumberDate { get => _vvoeWorkNumberDate; set => SetField(ref _vvoeWorkNumberDate, value); }

    /// <summary>
    /// Borrower WorkEmailAddress [1178], [1179]
    /// </summary>
    public string? WorkEmailAddress { get => _workEmailAddress; set => SetField(ref _workEmailAddress, value); }

    /// <summary>
    /// Borrower WorkPhoneNumber [4533], [4534]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? WorkPhoneNumber { get => _workPhoneNumber; set => SetField(ref _workPhoneNumber, value); }

    /// <summary>
    /// Underwriting Years of Credit on File [2565]
    /// </summary>
    public int? YearsofCreditOnFile { get => _yearsofCreditOnFile; set => SetField(ref _yearsofCreditOnFile, value); }
}