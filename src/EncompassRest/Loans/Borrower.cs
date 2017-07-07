using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Borrower : IClean
    {
        private Value<string> _acountChekAssetId;
        public string AcountChekAssetId { get { return _acountChekAssetId; } set { _acountChekAssetId = value; } }
        private Value<int?> _ageAtApplicationYearsCount;
        public int? AgeAtApplicationYearsCount { get { return _ageAtApplicationYearsCount; } set { _ageAtApplicationYearsCount = value; } }
        private Value<string> _aliasName;
        public string AliasName { get { return _aliasName; } set { _aliasName = value; } }
        private Value<bool?> _alimonyChildSupportObligationIndicator;
        public bool? AlimonyChildSupportObligationIndicator { get { return _alimonyChildSupportObligationIndicator; } set { _alimonyChildSupportObligationIndicator = value; } }
        private Value<string> _altId;
        public string AltId { get { return _altId; } set { _altId = value; } }
        private Value<string> _applicantType;
        public string ApplicantType { get { return _applicantType; } set { _applicantType = value; } }
        public Application Application { get; set; }
        private Value<string> _applicationTakenMethodType;
        public string ApplicationTakenMethodType { get { return _applicationTakenMethodType; } set { _applicationTakenMethodType = value; } }
        private Value<string> _assetRepAndWarrantyMessage;
        public string AssetRepAndWarrantyMessage { get { return _assetRepAndWarrantyMessage; } set { _assetRepAndWarrantyMessage = value; } }
        private Value<bool?> _assetRepAndWarrantyReliefAvailable;
        public bool? AssetRepAndWarrantyReliefAvailable { get { return _assetRepAndWarrantyReliefAvailable; } set { _assetRepAndWarrantyReliefAvailable = value; } }
        private Value<bool?> _authorizedCreditReportIndicator;
        public bool? AuthorizedCreditReportIndicator { get { return _authorizedCreditReportIndicator; } set { _authorizedCreditReportIndicator = value; } }
        private Value<bool?> _authorizedToSignIndicator;
        public bool? AuthorizedToSignIndicator { get { return _authorizedToSignIndicator; } set { _authorizedToSignIndicator = value; } }
        private Value<string> _bankAccountNumber;
        public string BankAccountNumber { get { return _bankAccountNumber; } set { _bankAccountNumber = value; } }
        private Value<string> _bankAccountType;
        public string BankAccountType { get { return _bankAccountType; } set { _bankAccountType = value; } }
        private Value<string> _bankContactAddress;
        public string BankContactAddress { get { return _bankContactAddress; } set { _bankContactAddress = value; } }
        private Value<string> _bankContactCity;
        public string BankContactCity { get { return _bankContactCity; } set { _bankContactCity = value; } }
        private Value<string> _bankContactName;
        public string BankContactName { get { return _bankContactName; } set { _bankContactName = value; } }
        private Value<string> _bankContactPostalCode;
        public string BankContactPostalCode { get { return _bankContactPostalCode; } set { _bankContactPostalCode = value; } }
        private Value<string> _bankContactState;
        public string BankContactState { get { return _bankContactState; } set { _bankContactState = value; } }
        private Value<bool?> _bankruptcyIndicator;
        public bool? BankruptcyIndicator { get { return _bankruptcyIndicator; } set { _bankruptcyIndicator = value; } }
        private Value<string> _bankruptcyStatus;
        public string BankruptcyStatus { get { return _bankruptcyStatus; } set { _bankruptcyStatus = value; } }
        private Value<decimal?> _baseMonthlyIncomeAmount;
        public decimal? BaseMonthlyIncomeAmount { get { return _baseMonthlyIncomeAmount; } set { _baseMonthlyIncomeAmount = value; } }
        private Value<DateTime?> _birthDate;
        public DateTime? BirthDate { get { return _birthDate; } set { _birthDate = value; } }
        private Value<bool?> _borrowedDownPaymentIndicator;
        public bool? BorrowedDownPaymentIndicator { get { return _borrowedDownPaymentIndicator; } set { _borrowedDownPaymentIndicator = value; } }
        private Value<DateTime?> _borrowerConsentRequestDate;
        public DateTime? BorrowerConsentRequestDate { get { return _borrowerConsentRequestDate; } set { _borrowerConsentRequestDate = value; } }
        private Value<int?> _borrowerIndex;
        public int? BorrowerIndex { get { return _borrowerIndex; } set { _borrowerIndex = value; } }
        private Value<string> _borrowerType;
        public string BorrowerType { get { return _borrowerType; } set { _borrowerType = value; } }
        private Value<string> _borrowerTypeInSummary;
        public string BorrowerTypeInSummary { get { return _borrowerTypeInSummary; } set { _borrowerTypeInSummary = value; } }
        private Value<string> _caivrsIdentifier;
        public string CaivrsIdentifier { get { return _caivrsIdentifier; } set { _caivrsIdentifier = value; } }
        private Value<string> _citizenshipResidencyType;
        public string CitizenshipResidencyType { get { return _citizenshipResidencyType; } set { _citizenshipResidencyType = value; } }
        private Value<bool?> _coMakerEndorserOfNoteIndicator;
        public bool? CoMakerEndorserOfNoteIndicator { get { return _coMakerEndorserOfNoteIndicator; } set { _coMakerEndorserOfNoteIndicator = value; } }
        private Value<string> _commentOfCreditReport;
        public string CommentOfCreditReport { get { return _commentOfCreditReport; } set { _commentOfCreditReport = value; } }
        private Value<bool?> _confirmedCRDIL;
        public bool? ConfirmedCRDIL { get { return _confirmedCRDIL; } set { _confirmedCRDIL = value; } }
        private Value<bool?> _confirmedCRFCEC;
        public bool? ConfirmedCRFCEC { get { return _confirmedCRFCEC; } set { _confirmedCRFCEC = value; } }
        private Value<bool?> _confirmedCRFCIncorrect;
        public bool? ConfirmedCRFCIncorrect { get { return _confirmedCRFCIncorrect; } set { _confirmedCRFCIncorrect = value; } }
        private Value<bool?> _confirmedCRPFS;
        public bool? ConfirmedCRPFS { get { return _confirmedCRPFS; } set { _confirmedCRPFS = value; } }
        private Value<bool?> _confirmedOther;
        public bool? ConfirmedOther { get { return _confirmedOther; } set { _confirmedOther = value; } }
        private Value<string> _confirmedOtherDescription;
        public string ConfirmedOtherDescription { get { return _confirmedOtherDescription; } set { _confirmedOtherDescription = value; } }
        private Value<bool?> _creditCounseling;
        public bool? CreditCounseling { get { return _creditCounseling; } set { _creditCounseling = value; } }
        private Value<DateTime?> _creditReceivedDate;
        public DateTime? CreditReceivedDate { get { return _creditReceivedDate; } set { _creditReceivedDate = value; } }
        private Value<string> _creditReportAuthorizationMethod;
        public string CreditReportAuthorizationMethod { get { return _creditReportAuthorizationMethod; } set { _creditReportAuthorizationMethod = value; } }
        private Value<bool?> _creditScoreIndicator;
        public bool? CreditScoreIndicator { get { return _creditScoreIndicator; } set { _creditScoreIndicator = value; } }
        private Value<DateTime?> _dateAuthorizedCreditReport;
        public DateTime? DateAuthorizedCreditReport { get { return _dateAuthorizedCreditReport; } set { _dateAuthorizedCreditReport = value; } }
        private Value<DateTime?> _dateOfBankruptcy;
        public DateTime? DateOfBankruptcy { get { return _dateOfBankruptcy; } set { _dateOfBankruptcy = value; } }
        private Value<DateTime?> _dateOfForeclosure;
        public DateTime? DateOfForeclosure { get { return _dateOfForeclosure; } set { _dateOfForeclosure = value; } }
        private Value<bool?> _declarationsJIndicator;
        public bool? DeclarationsJIndicator { get { return _declarationsJIndicator; } set { _declarationsJIndicator = value; } }
        private Value<bool?> _declarationsKIndicator;
        public bool? DeclarationsKIndicator { get { return _declarationsKIndicator; } set { _declarationsKIndicator = value; } }
        private Value<int?> _dependentCount;
        public int? DependentCount { get { return _dependentCount; } set { _dependentCount = value; } }
        private Value<string> _dependentsAgesDescription;
        public string DependentsAgesDescription { get { return _dependentsAgesDescription; } set { _dependentsAgesDescription = value; } }
        private Value<bool?> _disabledIndicator;
        public bool? DisabledIndicator { get { return _disabledIndicator; } set { _disabledIndicator = value; } }
        private Value<string> _emailAddressText;
        public string EmailAddressText { get { return _emailAddressText; } set { _emailAddressText = value; } }
        private Value<int?> _equifax120Days;
        public int? Equifax120Days { get { return _equifax120Days; } set { _equifax120Days = value; } }
        private Value<int?> _equifax150Days;
        public int? Equifax150Days { get { return _equifax150Days; } set { _equifax150Days = value; } }
        private Value<int?> _equifax30Days;
        public int? Equifax30Days { get { return _equifax30Days; } set { _equifax30Days = value; } }
        private Value<int?> _equifax60Days;
        public int? Equifax60Days { get { return _equifax60Days; } set { _equifax60Days = value; } }
        private Value<int?> _equifax90Days;
        public int? Equifax90Days { get { return _equifax90Days; } set { _equifax90Days = value; } }
        private Value<bool?> _equifaxCreditScoreForDisclosure;
        public bool? EquifaxCreditScoreForDisclosure { get { return _equifaxCreditScoreForDisclosure; } set { _equifaxCreditScoreForDisclosure = value; } }
        private Value<int?> _equifaxCreditScoreRanksPercent;
        public int? EquifaxCreditScoreRanksPercent { get { return _equifaxCreditScoreRanksPercent; } set { _equifaxCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _equifaxDatePulled;
        public DateTime? EquifaxDatePulled { get { return _equifaxDatePulled; } set { _equifaxDatePulled = value; } }
        private Value<string> _equifaxFactorCode1;
        public string EquifaxFactorCode1 { get { return _equifaxFactorCode1; } set { _equifaxFactorCode1 = value; } }
        private Value<string> _equifaxFactorCode2;
        public string EquifaxFactorCode2 { get { return _equifaxFactorCode2; } set { _equifaxFactorCode2 = value; } }
        private Value<string> _equifaxFactorCode3;
        public string EquifaxFactorCode3 { get { return _equifaxFactorCode3; } set { _equifaxFactorCode3 = value; } }
        private Value<string> _equifaxFactorCode4;
        public string EquifaxFactorCode4 { get { return _equifaxFactorCode4; } set { _equifaxFactorCode4 = value; } }
        private Value<string> _equifaxFactorCode5;
        public string EquifaxFactorCode5 { get { return _equifaxFactorCode5; } set { _equifaxFactorCode5 = value; } }
        private Value<string> _equifaxKeyFactor1;
        public string EquifaxKeyFactor1 { get { return _equifaxKeyFactor1; } set { _equifaxKeyFactor1 = value; } }
        private Value<string> _equifaxKeyFactor2;
        public string EquifaxKeyFactor2 { get { return _equifaxKeyFactor2; } set { _equifaxKeyFactor2 = value; } }
        private Value<string> _equifaxKeyFactor3;
        public string EquifaxKeyFactor3 { get { return _equifaxKeyFactor3; } set { _equifaxKeyFactor3 = value; } }
        private Value<string> _equifaxKeyFactor4;
        public string EquifaxKeyFactor4 { get { return _equifaxKeyFactor4; } set { _equifaxKeyFactor4 = value; } }
        private Value<string> _equifaxKeyFactor5;
        public string EquifaxKeyFactor5 { get { return _equifaxKeyFactor5; } set { _equifaxKeyFactor5 = value; } }
        private Value<bool?> _equifaxMaterialTermsCreditByScore;
        public bool? EquifaxMaterialTermsCreditByScore { get { return _equifaxMaterialTermsCreditByScore; } set { _equifaxMaterialTermsCreditByScore = value; } }
        private Value<string> _equifaxScore;
        public string EquifaxScore { get { return _equifaxScore; } set { _equifaxScore = value; } }
        private Value<int?> _experian120Days;
        public int? Experian120Days { get { return _experian120Days; } set { _experian120Days = value; } }
        private Value<int?> _experian150Days;
        public int? Experian150Days { get { return _experian150Days; } set { _experian150Days = value; } }
        private Value<int?> _experian30Days;
        public int? Experian30Days { get { return _experian30Days; } set { _experian30Days = value; } }
        private Value<int?> _experian60Days;
        public int? Experian60Days { get { return _experian60Days; } set { _experian60Days = value; } }
        private Value<int?> _experian90Days;
        public int? Experian90Days { get { return _experian90Days; } set { _experian90Days = value; } }
        private Value<string> _experianCreditScore;
        public string ExperianCreditScore { get { return _experianCreditScore; } set { _experianCreditScore = value; } }
        private Value<bool?> _experianCreditScoreForDisclosure;
        public bool? ExperianCreditScoreForDisclosure { get { return _experianCreditScoreForDisclosure; } set { _experianCreditScoreForDisclosure = value; } }
        private Value<int?> _experianCreditScoreRanksPercent;
        public int? ExperianCreditScoreRanksPercent { get { return _experianCreditScoreRanksPercent; } set { _experianCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _experianDatePulled;
        public DateTime? ExperianDatePulled { get { return _experianDatePulled; } set { _experianDatePulled = value; } }
        private Value<string> _experianFactorCode1;
        public string ExperianFactorCode1 { get { return _experianFactorCode1; } set { _experianFactorCode1 = value; } }
        private Value<string> _experianFactorCode2;
        public string ExperianFactorCode2 { get { return _experianFactorCode2; } set { _experianFactorCode2 = value; } }
        private Value<string> _experianFactorCode3;
        public string ExperianFactorCode3 { get { return _experianFactorCode3; } set { _experianFactorCode3 = value; } }
        private Value<string> _experianFactorCode4;
        public string ExperianFactorCode4 { get { return _experianFactorCode4; } set { _experianFactorCode4 = value; } }
        private Value<string> _experianFactorCode5;
        public string ExperianFactorCode5 { get { return _experianFactorCode5; } set { _experianFactorCode5 = value; } }
        private Value<string> _experianKeyFactor1;
        public string ExperianKeyFactor1 { get { return _experianKeyFactor1; } set { _experianKeyFactor1 = value; } }
        private Value<string> _experianKeyFactor2;
        public string ExperianKeyFactor2 { get { return _experianKeyFactor2; } set { _experianKeyFactor2 = value; } }
        private Value<string> _experianKeyFactor3;
        public string ExperianKeyFactor3 { get { return _experianKeyFactor3; } set { _experianKeyFactor3 = value; } }
        private Value<string> _experianKeyFactor4;
        public string ExperianKeyFactor4 { get { return _experianKeyFactor4; } set { _experianKeyFactor4 = value; } }
        private Value<string> _experianKeyFactor5;
        public string ExperianKeyFactor5 { get { return _experianKeyFactor5; } set { _experianKeyFactor5 = value; } }
        private Value<bool?> _experianMaterialTermsCreditByScore;
        public bool? ExperianMaterialTermsCreditByScore { get { return _experianMaterialTermsCreditByScore; } set { _experianMaterialTermsCreditByScore = value; } }
        private Value<string> _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private Value<string> _firstNameWithMiddleName;
        public string FirstNameWithMiddleName { get { return _firstNameWithMiddleName; } set { _firstNameWithMiddleName = value; } }
        private Value<bool?> _firstTimeHomeBuyer;
        public bool? FirstTimeHomeBuyer { get { return _firstTimeHomeBuyer; } set { _firstTimeHomeBuyer = value; } }
        private Value<DateTime?> _foreclosureSatisfied;
        public DateTime? ForeclosureSatisfied { get { return _foreclosureSatisfied; } set { _foreclosureSatisfied = value; } }
        private Value<string> _foreclosureStatus;
        public string ForeclosureStatus { get { return _foreclosureStatus; } set { _foreclosureStatus = value; } }
        private Value<string> _freddieMacPerson1;
        public string FreddieMacPerson1 { get { return _freddieMacPerson1; } set { _freddieMacPerson1 = value; } }
        private Value<string> _freddieMacPerson2;
        public string FreddieMacPerson2 { get { return _freddieMacPerson2; } set { _freddieMacPerson2 = value; } }
        private Value<string> _fullName;
        public string FullName { get { return _fullName; } set { _fullName = value; } }
        private Value<string> _fullNameWithSuffix;
        public string FullNameWithSuffix { get { return _fullNameWithSuffix; } set { _fullNameWithSuffix = value; } }
        private Value<decimal?> _highestCreditLimit;
        public decimal? HighestCreditLimit { get { return _highestCreditLimit; } set { _highestCreditLimit = value; } }
        private Value<string> _hmda2003OtherRaceNationalOriginDescription;
        public string Hmda2003OtherRaceNationalOriginDescription { get { return _hmda2003OtherRaceNationalOriginDescription; } set { _hmda2003OtherRaceNationalOriginDescription = value; } }
        private Value<string> _hmda2003RaceNationalOriginType;
        public string Hmda2003RaceNationalOriginType { get { return _hmda2003RaceNationalOriginType; } set { _hmda2003RaceNationalOriginType = value; } }
        private Value<bool?> _hmdaAfricanAmericanIndicator;
        public bool? HmdaAfricanAmericanIndicator { get { return _hmdaAfricanAmericanIndicator; } set { _hmdaAfricanAmericanIndicator = value; } }
        private Value<string> _hmdaAge;
        public string HmdaAge { get { return _hmdaAge; } set { _hmdaAge = value; } }
        private Value<bool?> _hmdaAmericanIndianIndicator;
        public bool? HmdaAmericanIndianIndicator { get { return _hmdaAmericanIndianIndicator; } set { _hmdaAmericanIndianIndicator = value; } }
        private Value<string> _hmdaAmericanIndianTribe;
        public string HmdaAmericanIndianTribe { get { return _hmdaAmericanIndianTribe; } set { _hmdaAmericanIndianTribe = value; } }
        private Value<bool?> _hmdaAsianIndianIndicator;
        public bool? HmdaAsianIndianIndicator { get { return _hmdaAsianIndianIndicator; } set { _hmdaAsianIndianIndicator = value; } }
        private Value<bool?> _hmdaAsianIndicator;
        public bool? HmdaAsianIndicator { get { return _hmdaAsianIndicator; } set { _hmdaAsianIndicator = value; } }
        private Value<bool?> _hmdaAsianOtherRaceIndicator;
        public bool? HmdaAsianOtherRaceIndicator { get { return _hmdaAsianOtherRaceIndicator; } set { _hmdaAsianOtherRaceIndicator = value; } }
        private Value<bool?> _hmdaChineseIndicator;
        public bool? HmdaChineseIndicator { get { return _hmdaChineseIndicator; } set { _hmdaChineseIndicator = value; } }
        private Value<string> _hmdaCreditScoreForDecisionMaking;
        public string HmdaCreditScoreForDecisionMaking { get { return _hmdaCreditScoreForDecisionMaking; } set { _hmdaCreditScoreForDecisionMaking = value; } }
        private Value<string> _hmdaCreditScoringModel;
        public string HmdaCreditScoringModel { get { return _hmdaCreditScoringModel; } set { _hmdaCreditScoringModel = value; } }
        private Value<bool?> _hmdaCubanIndicator;
        public bool? HmdaCubanIndicator { get { return _hmdaCubanIndicator; } set { _hmdaCubanIndicator = value; } }
        private Value<string> _hmdaEthnicityType;
        public string HmdaEthnicityType { get { return _hmdaEthnicityType; } set { _hmdaEthnicityType = value; } }
        private Value<bool?> _hmdaFilipinoIndicator;
        public bool? HmdaFilipinoIndicator { get { return _hmdaFilipinoIndicator; } set { _hmdaFilipinoIndicator = value; } }
        private Value<string> _hmdaGenderType;
        public string HmdaGenderType { get { return _hmdaGenderType; } set { _hmdaGenderType = value; } }
        private Value<bool?> _hmdaGendertypeDoNotWishIndicator;
        public bool? HmdaGendertypeDoNotWishIndicator { get { return _hmdaGendertypeDoNotWishIndicator; } set { _hmdaGendertypeDoNotWishIndicator = value; } }
        private Value<bool?> _hmdaGendertypeFemaleIndicator;
        public bool? HmdaGendertypeFemaleIndicator { get { return _hmdaGendertypeFemaleIndicator; } set { _hmdaGendertypeFemaleIndicator = value; } }
        private Value<bool?> _hmdaGendertypeMaleIndicator;
        public bool? HmdaGendertypeMaleIndicator { get { return _hmdaGendertypeMaleIndicator; } set { _hmdaGendertypeMaleIndicator = value; } }
        private Value<bool?> _hmdaGendertypeNotApplicableIndicator;
        public bool? HmdaGendertypeNotApplicableIndicator { get { return _hmdaGendertypeNotApplicableIndicator; } set { _hmdaGendertypeNotApplicableIndicator = value; } }
        private Value<bool?> _hmdaGuamanianOrChamorroIndicator;
        public bool? HmdaGuamanianOrChamorroIndicator { get { return _hmdaGuamanianOrChamorroIndicator; } set { _hmdaGuamanianOrChamorroIndicator = value; } }
        private Value<bool?> _hmdaHispanicLatinoOtherOriginIndicator;
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get { return _hmdaHispanicLatinoOtherOriginIndicator; } set { _hmdaHispanicLatinoOtherOriginIndicator = value; } }
        private Value<bool?> _hmdaJapaneseIndicator;
        public bool? HmdaJapaneseIndicator { get { return _hmdaJapaneseIndicator; } set { _hmdaJapaneseIndicator = value; } }
        private Value<bool?> _hmdaKoreanIndicator;
        public bool? HmdaKoreanIndicator { get { return _hmdaKoreanIndicator; } set { _hmdaKoreanIndicator = value; } }
        private Value<bool?> _hmdaMexicanIndicator;
        public bool? HmdaMexicanIndicator { get { return _hmdaMexicanIndicator; } set { _hmdaMexicanIndicator = value; } }
        private Value<bool?> _hmdaNativeHawaiianIndicator;
        public bool? HmdaNativeHawaiianIndicator { get { return _hmdaNativeHawaiianIndicator; } set { _hmdaNativeHawaiianIndicator = value; } }
        private Value<bool?> _hmdaNoCoApplicantIndicator;
        public bool? HmdaNoCoApplicantIndicator { get { return _hmdaNoCoApplicantIndicator; } set { _hmdaNoCoApplicantIndicator = value; } }
        private Value<bool?> _hmdaNotApplicableIndicator;
        public bool? HmdaNotApplicableIndicator { get { return _hmdaNotApplicableIndicator; } set { _hmdaNotApplicableIndicator = value; } }
        private Value<bool?> _hmdaNotProvidedIndicator;
        public bool? HmdaNotProvidedIndicator { get { return _hmdaNotProvidedIndicator; } set { _hmdaNotProvidedIndicator = value; } }
        private Value<string> _hmdaOtherAsianRace;
        public string HmdaOtherAsianRace { get { return _hmdaOtherAsianRace; } set { _hmdaOtherAsianRace = value; } }
        private Value<string> _hmdaOtherHispanicLatinoOrigin;
        public string HmdaOtherHispanicLatinoOrigin { get { return _hmdaOtherHispanicLatinoOrigin; } set { _hmdaOtherHispanicLatinoOrigin = value; } }
        private Value<string> _hmdaOtherPacificIslanderRace;
        public string HmdaOtherPacificIslanderRace { get { return _hmdaOtherPacificIslanderRace; } set { _hmdaOtherPacificIslanderRace = value; } }
        private Value<string> _hmdaOtherScoringModel;
        public string HmdaOtherScoringModel { get { return _hmdaOtherScoringModel; } set { _hmdaOtherScoringModel = value; } }
        private Value<bool?> _hmdaPacificIslanderIndicator;
        public bool? HmdaPacificIslanderIndicator { get { return _hmdaPacificIslanderIndicator; } set { _hmdaPacificIslanderIndicator = value; } }
        private Value<bool?> _hmdaPacificIslanderOtherIndicator;
        public bool? HmdaPacificIslanderOtherIndicator { get { return _hmdaPacificIslanderOtherIndicator; } set { _hmdaPacificIslanderOtherIndicator = value; } }
        private Value<bool?> _hmdaPuertoRicanIndicator;
        public bool? HmdaPuertoRicanIndicator { get { return _hmdaPuertoRicanIndicator; } set { _hmdaPuertoRicanIndicator = value; } }
        private Value<bool?> _hmdaRefusalIndicator;
        public bool? HmdaRefusalIndicator { get { return _hmdaRefusalIndicator; } set { _hmdaRefusalIndicator = value; } }
        private Value<bool?> _hmdaSamoanIndicator;
        public bool? HmdaSamoanIndicator { get { return _hmdaSamoanIndicator; } set { _hmdaSamoanIndicator = value; } }
        private Value<bool?> _hmdaVietnameseIndicator;
        public bool? HmdaVietnameseIndicator { get { return _hmdaVietnameseIndicator; } set { _hmdaVietnameseIndicator = value; } }
        private Value<bool?> _hmdaWhiteIndicator;
        public bool? HmdaWhiteIndicator { get { return _hmdaWhiteIndicator; } set { _hmdaWhiteIndicator = value; } }
        private Value<bool?> _homeownerPastThreeYearsIndicator;
        public bool? HomeownerPastThreeYearsIndicator { get { return _homeownerPastThreeYearsIndicator; } set { _homeownerPastThreeYearsIndicator = value; } }
        private Value<string> _homePhoneNumber;
        public string HomePhoneNumber { get { return _homePhoneNumber; } set { _homePhoneNumber = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _incomeRepAndWarrantyMessage;
        public string IncomeRepAndWarrantyMessage { get { return _incomeRepAndWarrantyMessage; } set { _incomeRepAndWarrantyMessage = value; } }
        private Value<bool?> _incomeRepAndWarrantyReliefAvailable;
        public bool? IncomeRepAndWarrantyReliefAvailable { get { return _incomeRepAndWarrantyReliefAvailable; } set { _incomeRepAndWarrantyReliefAvailable = value; } }
        private Value<bool?> _intentToOccupyIndicator;
        public bool? IntentToOccupyIndicator { get { return _intentToOccupyIndicator; } set { _intentToOccupyIndicator = value; } }
        private Value<string> _intuitReportId;
        public string IntuitReportId { get { return _intuitReportId; } set { _intuitReportId = value; } }
        private Value<bool?> _isBaseIncomeAvailable;
        public bool? IsBaseIncomeAvailable { get { return _isBaseIncomeAvailable; } set { _isBaseIncomeAvailable = value; } }
        private Value<bool?> _isBonusAvailable;
        public bool? IsBonusAvailable { get { return _isBonusAvailable; } set { _isBonusAvailable = value; } }
        private Value<bool?> _isBorrower;
        public bool? IsBorrower { get { return _isBorrower; } set { _isBorrower = value; } }
        private Value<bool?> _isCommissionAvailable;
        public bool? IsCommissionAvailable { get { return _isCommissionAvailable; } set { _isCommissionAvailable = value; } }
        private Value<string> _isEthnicityBasedOnVisual;
        public string IsEthnicityBasedOnVisual { get { return _isEthnicityBasedOnVisual; } set { _isEthnicityBasedOnVisual = value; } }
        private Value<bool?> _isOvertimeAvailable;
        public bool? IsOvertimeAvailable { get { return _isOvertimeAvailable; } set { _isOvertimeAvailable = value; } }
        private Value<string> _isRaceBasedOnVisual;
        public string IsRaceBasedOnVisual { get { return _isRaceBasedOnVisual; } set { _isRaceBasedOnVisual = value; } }
        private Value<bool?> _isSelfEmployed;
        public bool? IsSelfEmployed { get { return _isSelfEmployed; } set { _isSelfEmployed = value; } }
        private Value<string> _isSexBasedOnVisual;
        public string IsSexBasedOnVisual { get { return _isSexBasedOnVisual; } set { _isSexBasedOnVisual = value; } }
        private Value<bool?> _isSocialSecurityAvailable;
        public bool? IsSocialSecurityAvailable { get { return _isSocialSecurityAvailable; } set { _isSocialSecurityAvailable = value; } }
        private Value<string> _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private Value<string> _lastNameWithSuffix;
        public string LastNameWithSuffix { get { return _lastNameWithSuffix; } set { _lastNameWithSuffix = value; } }
        private Value<bool?> _loanForeclosureOrJudgementIndicator;
        public bool? LoanForeclosureOrJudgementIndicator { get { return _loanForeclosureOrJudgementIndicator; } set { _loanForeclosureOrJudgementIndicator = value; } }
        private Value<string> _lpdGsa;
        public string LpdGsa { get { return _lpdGsa; } set { _lpdGsa = value; } }
        private Value<bool?> _mailingAddressSameAsPresentIndicator;
        public bool? MailingAddressSameAsPresentIndicator { get { return _mailingAddressSameAsPresentIndicator; } set { _mailingAddressSameAsPresentIndicator = value; } }
        private Value<string> _maritalStatusType;
        public string MaritalStatusType { get { return _maritalStatusType; } set { _maritalStatusType = value; } }
        private Value<int?> _middleCreditScore;
        public int? MiddleCreditScore { get { return _middleCreditScore; } set { _middleCreditScore = value; } }
        private Value<string> _middleFicoScore;
        public string MiddleFicoScore { get { return _middleFicoScore; } set { _middleFicoScore = value; } }
        private Value<string> _middleName;
        public string MiddleName { get { return _middleName; } set { _middleName = value; } }
        private Value<string> _minFicoScore;
        public string MinFicoScore { get { return _minFicoScore; } set { _minFicoScore = value; } }
        private Value<string> _mobilePhone;
        public string MobilePhone { get { return _mobilePhone; } set { _mobilePhone = value; } }
        private Value<bool?> _mortgageOnCredit;
        public bool? MortgageOnCredit { get { return _mortgageOnCredit; } set { _mortgageOnCredit = value; } }
        private Value<string> _nameToObtainLoanFromRHS;
        public string NameToObtainLoanFromRHS { get { return _nameToObtainLoanFromRHS; } set { _nameToObtainLoanFromRHS = value; } }
        private Value<string> _nearestRelativeAddress;
        public string NearestRelativeAddress { get { return _nearestRelativeAddress; } set { _nearestRelativeAddress = value; } }
        private Value<string> _nearestRelativeCity;
        public string NearestRelativeCity { get { return _nearestRelativeCity; } set { _nearestRelativeCity = value; } }
        private Value<string> _nearestRelativeName;
        public string NearestRelativeName { get { return _nearestRelativeName; } set { _nearestRelativeName = value; } }
        private Value<string> _nearestRelativePhone;
        public string NearestRelativePhone { get { return _nearestRelativePhone; } set { _nearestRelativePhone = value; } }
        private Value<string> _nearestRelativePostalCode;
        public string NearestRelativePostalCode { get { return _nearestRelativePostalCode; } set { _nearestRelativePostalCode = value; } }
        private Value<string> _nearestRelativeRelationship;
        public string NearestRelativeRelationship { get { return _nearestRelativeRelationship; } set { _nearestRelativeRelationship = value; } }
        private Value<string> _nearestRelativeState;
        public string NearestRelativeState { get { return _nearestRelativeState; } set { _nearestRelativeState = value; } }
        private Value<bool?> _no3rdPartyEmailIndicator;
        public bool? No3rdPartyEmailIndicator { get { return _no3rdPartyEmailIndicator; } set { _no3rdPartyEmailIndicator = value; } }
        private Value<bool?> _noCoApplicantEthnicityIndicator;
        public bool? NoCoApplicantEthnicityIndicator { get { return _noCoApplicantEthnicityIndicator; } set { _noCoApplicantEthnicityIndicator = value; } }
        private Value<bool?> _noCoApplicantIndicator;
        public bool? NoCoApplicantIndicator { get { return _noCoApplicantIndicator; } set { _noCoApplicantIndicator = value; } }
        private Value<bool?> _noCoApplicantSexIndicator;
        public bool? NoCoApplicantSexIndicator { get { return _noCoApplicantSexIndicator; } set { _noCoApplicantSexIndicator = value; } }
        private Value<int?> _numberofTradelines;
        public int? NumberofTradelines { get { return _numberofTradelines; } set { _numberofTradelines = value; } }
        private Value<bool?> _obtainLoanFromRHSIndicator;
        public bool? ObtainLoanFromRHSIndicator { get { return _obtainLoanFromRHSIndicator; } set { _obtainLoanFromRHSIndicator = value; } }
        private Value<string> _openBankruptcy2;
        public string OpenBankruptcy2 { get { return _openBankruptcy2; } set { _openBankruptcy2 = value; } }
        private Value<decimal?> _otherMonthlyIncomeAmount;
        public decimal? OtherMonthlyIncomeAmount { get { return _otherMonthlyIncomeAmount; } set { _otherMonthlyIncomeAmount = value; } }
        private Value<decimal?> _otherSumAmount;
        public decimal? OtherSumAmount { get { return _otherSumAmount; } set { _otherSumAmount = value; } }
        private Value<bool?> _outstandingJudgementsIndicator;
        public bool? OutstandingJudgementsIndicator { get { return _outstandingJudgementsIndicator; } set { _outstandingJudgementsIndicator = value; } }
        private Value<bool?> _partyToLawsuitIndicator;
        public bool? PartyToLawsuitIndicator { get { return _partyToLawsuitIndicator; } set { _partyToLawsuitIndicator = value; } }
        private Value<int?> _pass120Days;
        public int? Pass120Days { get { return _pass120Days; } set { _pass120Days = value; } }
        private Value<int?> _pass150Days;
        public int? Pass150Days { get { return _pass150Days; } set { _pass150Days = value; } }
        private Value<int?> _pass30Days;
        public int? Pass30Days { get { return _pass30Days; } set { _pass30Days = value; } }
        private Value<int?> _pass60Days;
        public int? Pass60Days { get { return _pass60Days; } set { _pass60Days = value; } }
        private Value<int?> _pass90Days;
        public int? Pass90Days { get { return _pass90Days; } set { _pass90Days = value; } }
        private Value<string> _personFaxNumber;
        public string PersonFaxNumber { get { return _personFaxNumber; } set { _personFaxNumber = value; } }
        private Value<decimal?> _personHoursPerWeek;
        public decimal? PersonHoursPerWeek { get { return _personHoursPerWeek; } set { _personHoursPerWeek = value; } }
        private Value<decimal?> _personIncomeAmount;
        public decimal? PersonIncomeAmount { get { return _personIncomeAmount; } set { _personIncomeAmount = value; } }
        private Value<string> _personIncomeFrequencyType;
        public string PersonIncomeFrequencyType { get { return _personIncomeFrequencyType; } set { _personIncomeFrequencyType = value; } }
        private Value<decimal?> _personMonthlyIncome;
        public decimal? PersonMonthlyIncome { get { return _personMonthlyIncome; } set { _personMonthlyIncome = value; } }
        private Value<bool?> _pIWAccepted;
        public bool? PIWAccepted { get { return _pIWAccepted; } set { _pIWAccepted = value; } }
        private Value<string> _pIWMessage;
        public string PIWMessage { get { return _pIWMessage; } set { _pIWMessage = value; } }
        private Value<string> _poaOccupancyIntent;
        public string PoaOccupancyIntent { get { return _poaOccupancyIntent; } set { _poaOccupancyIntent = value; } }
        private Value<string> _poaSignatureText;
        public string PoaSignatureText { get { return _poaSignatureText; } set { _poaSignatureText = value; } }
        private Value<decimal?> _positiveCashFlow;
        public decimal? PositiveCashFlow { get { return _positiveCashFlow; } set { _positiveCashFlow = value; } }
        private Value<string> _powerOfAttorneyName;
        public string PowerOfAttorneyName { get { return _powerOfAttorneyName; } set { _powerOfAttorneyName = value; } }
        private Value<string> _powerOfAttorneyTitleDescription;
        public string PowerOfAttorneyTitleDescription { get { return _powerOfAttorneyTitleDescription; } set { _powerOfAttorneyTitleDescription = value; } }
        private Value<bool?> _presentlyDelinquentIndicator;
        public bool? PresentlyDelinquentIndicator { get { return _presentlyDelinquentIndicator; } set { _presentlyDelinquentIndicator = value; } }
        private Value<DateTime?> _priorBankruptcy2;
        public DateTime? PriorBankruptcy2 { get { return _priorBankruptcy2; } set { _priorBankruptcy2 = value; } }
        private Value<bool?> _priorForeclosure;
        public bool? PriorForeclosure { get { return _priorForeclosure; } set { _priorForeclosure = value; } }
        private Value<string> _priorPropertyTitleType;
        public string PriorPropertyTitleType { get { return _priorPropertyTitleType; } set { _priorPropertyTitleType = value; } }
        private Value<string> _priorPropertyUsageType;
        public string PriorPropertyUsageType { get { return _priorPropertyUsageType; } set { _priorPropertyUsageType = value; } }
        private Value<bool?> _propertyForeclosedPastSevenYearsIndicator;
        public bool? PropertyForeclosedPastSevenYearsIndicator { get { return _propertyForeclosedPastSevenYearsIndicator; } set { _propertyForeclosedPastSevenYearsIndicator = value; } }
        private Value<string> _relationshipDescription;
        public string RelationshipDescription { get { return _relationshipDescription; } set { _relationshipDescription = value; } }
        private Value<bool?> _relationshipWithRDEmployeeIndicator;
        public bool? RelationshipWithRDEmployeeIndicator { get { return _relationshipWithRDEmployeeIndicator; } set { _relationshipWithRDEmployeeIndicator = value; } }
        private Value<int?> _schoolingTermYears;
        public int? SchoolingTermYears { get { return _schoolingTermYears; } set { _schoolingTermYears = value; } }
        private Value<bool?> _sSA89BackgroundCheckIndicator;
        public bool? SSA89BackgroundCheckIndicator { get { return _sSA89BackgroundCheckIndicator; } set { _sSA89BackgroundCheckIndicator = value; } }
        private Value<bool?> _sSA89BankingServiceIndicator;
        public bool? SSA89BankingServiceIndicator { get { return _sSA89BankingServiceIndicator; } set { _sSA89BankingServiceIndicator = value; } }
        private Value<bool?> _sSA89CreditCheckIndicator;
        public bool? SSA89CreditCheckIndicator { get { return _sSA89CreditCheckIndicator; } set { _sSA89CreditCheckIndicator = value; } }
        private Value<bool?> _sSA89LicenseRequirementIndicator;
        public bool? SSA89LicenseRequirementIndicator { get { return _sSA89LicenseRequirementIndicator; } set { _sSA89LicenseRequirementIndicator = value; } }
        private Value<bool?> _sSA89MortgageServiceIndicator;
        public bool? SSA89MortgageServiceIndicator { get { return _sSA89MortgageServiceIndicator; } set { _sSA89MortgageServiceIndicator = value; } }
        private Value<bool?> _sSA89OtherIndicator;
        public bool? SSA89OtherIndicator { get { return _sSA89OtherIndicator; } set { _sSA89OtherIndicator = value; } }
        private Value<decimal?> _subtotalLiquidAssetsMinusGiftAmount;
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get { return _subtotalLiquidAssetsMinusGiftAmount; } set { _subtotalLiquidAssetsMinusGiftAmount = value; } }
        private Value<string> _suffixToName;
        public string SuffixToName { get { return _suffixToName; } set { _suffixToName = value; } }
        private Value<string> _tax4506LastInvestor;
        public string Tax4506LastInvestor { get { return _tax4506LastInvestor; } set { _tax4506LastInvestor = value; } }
        private Value<string> _tax4506LastOrderNumber;
        public string Tax4506LastOrderNumber { get { return _tax4506LastOrderNumber; } set { _tax4506LastOrderNumber = value; } }
        private Value<int?> _tax4506LastOrderYear1;
        public int? Tax4506LastOrderYear1 { get { return _tax4506LastOrderYear1; } set { _tax4506LastOrderYear1 = value; } }
        private Value<int?> _tax4506LastOrderYear2;
        public int? Tax4506LastOrderYear2 { get { return _tax4506LastOrderYear2; } set { _tax4506LastOrderYear2 = value; } }
        private Value<int?> _tax4506LastOrderYear3;
        public int? Tax4506LastOrderYear3 { get { return _tax4506LastOrderYear3; } set { _tax4506LastOrderYear3 = value; } }
        private Value<int?> _tax4506LastOrderYear4;
        public int? Tax4506LastOrderYear4 { get { return _tax4506LastOrderYear4; } set { _tax4506LastOrderYear4 = value; } }
        private Value<string> _tax4506LastProductsOrdered;
        public string Tax4506LastProductsOrdered { get { return _tax4506LastProductsOrdered; } set { _tax4506LastProductsOrdered = value; } }
        private Value<string> _tax4506LastStatus;
        public string Tax4506LastStatus { get { return _tax4506LastStatus; } set { _tax4506LastStatus = value; } }
        private Value<string> _tax4506LastTranscriptType;
        public string Tax4506LastTranscriptType { get { return _tax4506LastTranscriptType; } set { _tax4506LastTranscriptType = value; } }
        private Value<string> _tax4506LastUserIDWhoOrdered;
        public string Tax4506LastUserIDWhoOrdered { get { return _tax4506LastUserIDWhoOrdered; } set { _tax4506LastUserIDWhoOrdered = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome1;
        public decimal? Tax4506TotalYearlyIncome1 { get { return _tax4506TotalYearlyIncome1; } set { _tax4506TotalYearlyIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome2;
        public decimal? Tax4506TotalYearlyIncome2 { get { return _tax4506TotalYearlyIncome2; } set { _tax4506TotalYearlyIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome3;
        public decimal? Tax4506TotalYearlyIncome3 { get { return _tax4506TotalYearlyIncome3; } set { _tax4506TotalYearlyIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyIncome4;
        public decimal? Tax4506TotalYearlyIncome4 { get { return _tax4506TotalYearlyIncome4; } set { _tax4506TotalYearlyIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome1;
        public decimal? Tax4506TotalYearlyJointIncome1 { get { return _tax4506TotalYearlyJointIncome1; } set { _tax4506TotalYearlyJointIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome2;
        public decimal? Tax4506TotalYearlyJointIncome2 { get { return _tax4506TotalYearlyJointIncome2; } set { _tax4506TotalYearlyJointIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome3;
        public decimal? Tax4506TotalYearlyJointIncome3 { get { return _tax4506TotalYearlyJointIncome3; } set { _tax4506TotalYearlyJointIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyJointIncome4;
        public decimal? Tax4506TotalYearlyJointIncome4 { get { return _tax4506TotalYearlyJointIncome4; } set { _tax4506TotalYearlyJointIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome1;
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get { return _tax4506TotalYearlyVarianceIncome1; } set { _tax4506TotalYearlyVarianceIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome2;
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get { return _tax4506TotalYearlyVarianceIncome2; } set { _tax4506TotalYearlyVarianceIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome3;
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get { return _tax4506TotalYearlyVarianceIncome3; } set { _tax4506TotalYearlyVarianceIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceIncome4;
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get { return _tax4506TotalYearlyVarianceIncome4; } set { _tax4506TotalYearlyVarianceIncome4 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome1;
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get { return _tax4506TotalYearlyVarianceJointIncome1; } set { _tax4506TotalYearlyVarianceJointIncome1 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome2;
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get { return _tax4506TotalYearlyVarianceJointIncome2; } set { _tax4506TotalYearlyVarianceJointIncome2 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome3;
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get { return _tax4506TotalYearlyVarianceJointIncome3; } set { _tax4506TotalYearlyVarianceJointIncome3 = value; } }
        private Value<decimal?> _tax4506TotalYearlyVarianceJointIncome4;
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get { return _tax4506TotalYearlyVarianceJointIncome4; } set { _tax4506TotalYearlyVarianceJointIncome4 = value; } }
        private Value<string> _taxIdentificationIdentifier;
        public string TaxIdentificationIdentifier { get { return _taxIdentificationIdentifier; } set { _taxIdentificationIdentifier = value; } }
        private Value<decimal?> _totalLiabilitiesBalanceAmount;
        public decimal? TotalLiabilitiesBalanceAmount { get { return _totalLiabilitiesBalanceAmount; } set { _totalLiabilitiesBalanceAmount = value; } }
        private Value<decimal?> _totalMonthlyIncomeAmount;
        public decimal? TotalMonthlyIncomeAmount { get { return _totalMonthlyIncomeAmount; } set { _totalMonthlyIncomeAmount = value; } }
        private Value<decimal?> _totalMonthlyIncomeMinusNetRentalAmount;
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get { return _totalMonthlyIncomeMinusNetRentalAmount; } set { _totalMonthlyIncomeMinusNetRentalAmount = value; } }
        private Value<decimal?> _totalPresentHousingExpenseAmount;
        public decimal? TotalPresentHousingExpenseAmount { get { return _totalPresentHousingExpenseAmount; } set { _totalPresentHousingExpenseAmount = value; } }
        private Value<string> _transactionPurposeDescription;
        public string TransactionPurposeDescription { get { return _transactionPurposeDescription; } set { _transactionPurposeDescription = value; } }
        private Value<int?> _transUnion120Days;
        public int? TransUnion120Days { get { return _transUnion120Days; } set { _transUnion120Days = value; } }
        private Value<int?> _transUnion150Days;
        public int? TransUnion150Days { get { return _transUnion150Days; } set { _transUnion150Days = value; } }
        private Value<int?> _transUnion30Days;
        public int? TransUnion30Days { get { return _transUnion30Days; } set { _transUnion30Days = value; } }
        private Value<int?> _transUnion60Days;
        public int? TransUnion60Days { get { return _transUnion60Days; } set { _transUnion60Days = value; } }
        private Value<int?> _transUnion90Days;
        public int? TransUnion90Days { get { return _transUnion90Days; } set { _transUnion90Days = value; } }
        private Value<bool?> _transUnionCreditScoreForDisclosure;
        public bool? TransUnionCreditScoreForDisclosure { get { return _transUnionCreditScoreForDisclosure; } set { _transUnionCreditScoreForDisclosure = value; } }
        private Value<int?> _transUnionCreditScoreRanksPercent;
        public int? TransUnionCreditScoreRanksPercent { get { return _transUnionCreditScoreRanksPercent; } set { _transUnionCreditScoreRanksPercent = value; } }
        private Value<DateTime?> _transUnionDatePulled;
        public DateTime? TransUnionDatePulled { get { return _transUnionDatePulled; } set { _transUnionDatePulled = value; } }
        private Value<string> _transUnionFactorCode1;
        public string TransUnionFactorCode1 { get { return _transUnionFactorCode1; } set { _transUnionFactorCode1 = value; } }
        private Value<string> _transUnionFactorCode2;
        public string TransUnionFactorCode2 { get { return _transUnionFactorCode2; } set { _transUnionFactorCode2 = value; } }
        private Value<string> _transUnionFactorCode3;
        public string TransUnionFactorCode3 { get { return _transUnionFactorCode3; } set { _transUnionFactorCode3 = value; } }
        private Value<string> _transUnionFactorCode4;
        public string TransUnionFactorCode4 { get { return _transUnionFactorCode4; } set { _transUnionFactorCode4 = value; } }
        private Value<string> _transUnionFactorCode5;
        public string TransUnionFactorCode5 { get { return _transUnionFactorCode5; } set { _transUnionFactorCode5 = value; } }
        private Value<string> _transUnionKeyFactor1;
        public string TransUnionKeyFactor1 { get { return _transUnionKeyFactor1; } set { _transUnionKeyFactor1 = value; } }
        private Value<string> _transUnionKeyFactor2;
        public string TransUnionKeyFactor2 { get { return _transUnionKeyFactor2; } set { _transUnionKeyFactor2 = value; } }
        private Value<string> _transUnionKeyFactor3;
        public string TransUnionKeyFactor3 { get { return _transUnionKeyFactor3; } set { _transUnionKeyFactor3 = value; } }
        private Value<string> _transUnionKeyFactor4;
        public string TransUnionKeyFactor4 { get { return _transUnionKeyFactor4; } set { _transUnionKeyFactor4 = value; } }
        private Value<string> _transUnionKeyFactor5;
        public string TransUnionKeyFactor5 { get { return _transUnionKeyFactor5; } set { _transUnionKeyFactor5 = value; } }
        private Value<bool?> _transUnionMaterialTermsCreditByScore;
        public bool? TransUnionMaterialTermsCreditByScore { get { return _transUnionMaterialTermsCreditByScore; } set { _transUnionMaterialTermsCreditByScore = value; } }
        private Value<string> _transUnionScore;
        public string TransUnionScore { get { return _transUnionScore; } set { _transUnionScore = value; } }
        private Value<decimal?> _userDefinedIncome;
        public decimal? UserDefinedIncome { get { return _userDefinedIncome; } set { _userDefinedIncome = value; } }
        private Value<decimal?> _vaFederalTaxAmount;
        public decimal? VaFederalTaxAmount { get { return _vaFederalTaxAmount; } set { _vaFederalTaxAmount = value; } }
        private Value<int?> _validDaysForConsentCount;
        public int? ValidDaysForConsentCount { get { return _validDaysForConsentCount; } set { _validDaysForConsentCount = value; } }
        private Value<bool?> _valueRepAndWarrantyAvailable;
        public bool? ValueRepAndWarrantyAvailable { get { return _valueRepAndWarrantyAvailable; } set { _valueRepAndWarrantyAvailable = value; } }
        private Value<string> _valueRepAndWarrantyMessage;
        public string ValueRepAndWarrantyMessage { get { return _valueRepAndWarrantyMessage; } set { _valueRepAndWarrantyMessage = value; } }
        private Value<decimal?> _vaNetTakeHomePayAmount;
        public decimal? VaNetTakeHomePayAmount { get { return _vaNetTakeHomePayAmount; } set { _vaNetTakeHomePayAmount = value; } }
        private Value<decimal?> _vaOtherAmount;
        public decimal? VaOtherAmount { get { return _vaOtherAmount; } set { _vaOtherAmount = value; } }
        private Value<decimal?> _vaOtherNetIncomeAmount;
        public decimal? VaOtherNetIncomeAmount { get { return _vaOtherNetIncomeAmount; } set { _vaOtherNetIncomeAmount = value; } }
        private Value<decimal?> _vaRetirementAmount;
        public decimal? VaRetirementAmount { get { return _vaRetirementAmount; } set { _vaRetirementAmount = value; } }
        private Value<decimal?> _vaStateTaxAmount;
        public decimal? VaStateTaxAmount { get { return _vaStateTaxAmount; } set { _vaStateTaxAmount = value; } }
        private Value<decimal?> _vaTotalIncomeDeductionsAmount;
        public decimal? VaTotalIncomeDeductionsAmount { get { return _vaTotalIncomeDeductionsAmount; } set { _vaTotalIncomeDeductionsAmount = value; } }
        private Value<decimal?> _vaTotalNetIncomeAmount;
        public decimal? VaTotalNetIncomeAmount { get { return _vaTotalNetIncomeAmount; } set { _vaTotalNetIncomeAmount = value; } }
        private Value<string> _vendor1;
        public string Vendor1 { get { return _vendor1; } set { _vendor1 = value; } }
        private Value<string> _vendor10;
        public string Vendor10 { get { return _vendor10; } set { _vendor10 = value; } }
        private Value<string> _vendor11;
        public string Vendor11 { get { return _vendor11; } set { _vendor11 = value; } }
        private Value<string> _vendor12;
        public string Vendor12 { get { return _vendor12; } set { _vendor12 = value; } }
        private Value<string> _vendor2;
        public string Vendor2 { get { return _vendor2; } set { _vendor2 = value; } }
        private Value<string> _vendor3;
        public string Vendor3 { get { return _vendor3; } set { _vendor3 = value; } }
        private Value<string> _vendor4;
        public string Vendor4 { get { return _vendor4; } set { _vendor4 = value; } }
        private Value<string> _vendor5;
        public string Vendor5 { get { return _vendor5; } set { _vendor5 = value; } }
        private Value<string> _vendor6;
        public string Vendor6 { get { return _vendor6; } set { _vendor6 = value; } }
        private Value<string> _vendor7;
        public string Vendor7 { get { return _vendor7; } set { _vendor7 = value; } }
        private Value<string> _vendor8;
        public string Vendor8 { get { return _vendor8; } set { _vendor8 = value; } }
        private Value<string> _vendor9;
        public string Vendor9 { get { return _vendor9; } set { _vendor9 = value; } }
        private Value<string> _vestingTrusteeOfType;
        public string VestingTrusteeOfType { get { return _vestingTrusteeOfType; } set { _vestingTrusteeOfType = value; } }
        private Value<bool?> _veteranIndicator;
        public bool? VeteranIndicator { get { return _veteranIndicator; } set { _veteranIndicator = value; } }
        private Value<string> _workEmailAddress;
        public string WorkEmailAddress { get { return _workEmailAddress; } set { _workEmailAddress = value; } }
        private Value<int?> _yearsofCreditOnFile;
        public int? YearsofCreditOnFile { get { return _yearsofCreditOnFile; } set { _yearsofCreditOnFile = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _acountChekAssetId.Clean
                    && _ageAtApplicationYearsCount.Clean
                    && _aliasName.Clean
                    && _alimonyChildSupportObligationIndicator.Clean
                    && _altId.Clean
                    && _applicantType.Clean
                    && _applicationTakenMethodType.Clean
                    && _assetRepAndWarrantyMessage.Clean
                    && _assetRepAndWarrantyReliefAvailable.Clean
                    && _authorizedCreditReportIndicator.Clean
                    && _authorizedToSignIndicator.Clean
                    && _bankAccountNumber.Clean
                    && _bankAccountType.Clean
                    && _bankContactAddress.Clean
                    && _bankContactCity.Clean
                    && _bankContactName.Clean
                    && _bankContactPostalCode.Clean
                    && _bankContactState.Clean
                    && _bankruptcyIndicator.Clean
                    && _bankruptcyStatus.Clean
                    && _baseMonthlyIncomeAmount.Clean
                    && _birthDate.Clean
                    && _borrowedDownPaymentIndicator.Clean
                    && _borrowerConsentRequestDate.Clean
                    && _borrowerIndex.Clean
                    && _borrowerType.Clean
                    && _borrowerTypeInSummary.Clean
                    && _caivrsIdentifier.Clean
                    && _citizenshipResidencyType.Clean
                    && _coMakerEndorserOfNoteIndicator.Clean
                    && _commentOfCreditReport.Clean
                    && _confirmedCRDIL.Clean
                    && _confirmedCRFCEC.Clean
                    && _confirmedCRFCIncorrect.Clean
                    && _confirmedCRPFS.Clean
                    && _confirmedOther.Clean
                    && _confirmedOtherDescription.Clean
                    && _creditCounseling.Clean
                    && _creditReceivedDate.Clean
                    && _creditReportAuthorizationMethod.Clean
                    && _creditScoreIndicator.Clean
                    && _dateAuthorizedCreditReport.Clean
                    && _dateOfBankruptcy.Clean
                    && _dateOfForeclosure.Clean
                    && _declarationsJIndicator.Clean
                    && _declarationsKIndicator.Clean
                    && _dependentCount.Clean
                    && _dependentsAgesDescription.Clean
                    && _disabledIndicator.Clean
                    && _emailAddressText.Clean
                    && _equifax120Days.Clean
                    && _equifax150Days.Clean
                    && _equifax30Days.Clean
                    && _equifax60Days.Clean
                    && _equifax90Days.Clean
                    && _equifaxCreditScoreForDisclosure.Clean
                    && _equifaxCreditScoreRanksPercent.Clean
                    && _equifaxDatePulled.Clean
                    && _equifaxFactorCode1.Clean
                    && _equifaxFactorCode2.Clean
                    && _equifaxFactorCode3.Clean
                    && _equifaxFactorCode4.Clean
                    && _equifaxFactorCode5.Clean
                    && _equifaxKeyFactor1.Clean
                    && _equifaxKeyFactor2.Clean
                    && _equifaxKeyFactor3.Clean
                    && _equifaxKeyFactor4.Clean
                    && _equifaxKeyFactor5.Clean
                    && _equifaxMaterialTermsCreditByScore.Clean
                    && _equifaxScore.Clean
                    && _experian120Days.Clean
                    && _experian150Days.Clean
                    && _experian30Days.Clean
                    && _experian60Days.Clean
                    && _experian90Days.Clean
                    && _experianCreditScore.Clean
                    && _experianCreditScoreForDisclosure.Clean
                    && _experianCreditScoreRanksPercent.Clean
                    && _experianDatePulled.Clean
                    && _experianFactorCode1.Clean
                    && _experianFactorCode2.Clean
                    && _experianFactorCode3.Clean
                    && _experianFactorCode4.Clean
                    && _experianFactorCode5.Clean
                    && _experianKeyFactor1.Clean
                    && _experianKeyFactor2.Clean
                    && _experianKeyFactor3.Clean
                    && _experianKeyFactor4.Clean
                    && _experianKeyFactor5.Clean
                    && _experianMaterialTermsCreditByScore.Clean
                    && _firstName.Clean
                    && _firstNameWithMiddleName.Clean
                    && _firstTimeHomeBuyer.Clean
                    && _foreclosureSatisfied.Clean
                    && _foreclosureStatus.Clean
                    && _freddieMacPerson1.Clean
                    && _freddieMacPerson2.Clean
                    && _fullName.Clean
                    && _fullNameWithSuffix.Clean
                    && _highestCreditLimit.Clean
                    && _hmda2003OtherRaceNationalOriginDescription.Clean
                    && _hmda2003RaceNationalOriginType.Clean
                    && _hmdaAfricanAmericanIndicator.Clean
                    && _hmdaAge.Clean
                    && _hmdaAmericanIndianIndicator.Clean
                    && _hmdaAmericanIndianTribe.Clean
                    && _hmdaAsianIndianIndicator.Clean
                    && _hmdaAsianIndicator.Clean
                    && _hmdaAsianOtherRaceIndicator.Clean
                    && _hmdaChineseIndicator.Clean
                    && _hmdaCreditScoreForDecisionMaking.Clean
                    && _hmdaCreditScoringModel.Clean
                    && _hmdaCubanIndicator.Clean
                    && _hmdaEthnicityType.Clean
                    && _hmdaFilipinoIndicator.Clean
                    && _hmdaGenderType.Clean
                    && _hmdaGendertypeDoNotWishIndicator.Clean
                    && _hmdaGendertypeFemaleIndicator.Clean
                    && _hmdaGendertypeMaleIndicator.Clean
                    && _hmdaGendertypeNotApplicableIndicator.Clean
                    && _hmdaGuamanianOrChamorroIndicator.Clean
                    && _hmdaHispanicLatinoOtherOriginIndicator.Clean
                    && _hmdaJapaneseIndicator.Clean
                    && _hmdaKoreanIndicator.Clean
                    && _hmdaMexicanIndicator.Clean
                    && _hmdaNativeHawaiianIndicator.Clean
                    && _hmdaNoCoApplicantIndicator.Clean
                    && _hmdaNotApplicableIndicator.Clean
                    && _hmdaNotProvidedIndicator.Clean
                    && _hmdaOtherAsianRace.Clean
                    && _hmdaOtherHispanicLatinoOrigin.Clean
                    && _hmdaOtherPacificIslanderRace.Clean
                    && _hmdaOtherScoringModel.Clean
                    && _hmdaPacificIslanderIndicator.Clean
                    && _hmdaPacificIslanderOtherIndicator.Clean
                    && _hmdaPuertoRicanIndicator.Clean
                    && _hmdaRefusalIndicator.Clean
                    && _hmdaSamoanIndicator.Clean
                    && _hmdaVietnameseIndicator.Clean
                    && _hmdaWhiteIndicator.Clean
                    && _homeownerPastThreeYearsIndicator.Clean
                    && _homePhoneNumber.Clean
                    && _id.Clean
                    && _incomeRepAndWarrantyMessage.Clean
                    && _incomeRepAndWarrantyReliefAvailable.Clean
                    && _intentToOccupyIndicator.Clean
                    && _intuitReportId.Clean
                    && _isBaseIncomeAvailable.Clean
                    && _isBonusAvailable.Clean
                    && _isBorrower.Clean
                    && _isCommissionAvailable.Clean
                    && _isEthnicityBasedOnVisual.Clean
                    && _isOvertimeAvailable.Clean
                    && _isRaceBasedOnVisual.Clean
                    && _isSelfEmployed.Clean
                    && _isSexBasedOnVisual.Clean
                    && _isSocialSecurityAvailable.Clean
                    && _lastName.Clean
                    && _lastNameWithSuffix.Clean
                    && _loanForeclosureOrJudgementIndicator.Clean
                    && _lpdGsa.Clean
                    && _mailingAddressSameAsPresentIndicator.Clean
                    && _maritalStatusType.Clean
                    && _middleCreditScore.Clean
                    && _middleFicoScore.Clean
                    && _middleName.Clean
                    && _minFicoScore.Clean
                    && _mobilePhone.Clean
                    && _mortgageOnCredit.Clean
                    && _nameToObtainLoanFromRHS.Clean
                    && _nearestRelativeAddress.Clean
                    && _nearestRelativeCity.Clean
                    && _nearestRelativeName.Clean
                    && _nearestRelativePhone.Clean
                    && _nearestRelativePostalCode.Clean
                    && _nearestRelativeRelationship.Clean
                    && _nearestRelativeState.Clean
                    && _no3rdPartyEmailIndicator.Clean
                    && _noCoApplicantEthnicityIndicator.Clean
                    && _noCoApplicantIndicator.Clean
                    && _noCoApplicantSexIndicator.Clean
                    && _numberofTradelines.Clean
                    && _obtainLoanFromRHSIndicator.Clean
                    && _openBankruptcy2.Clean
                    && _otherMonthlyIncomeAmount.Clean
                    && _otherSumAmount.Clean
                    && _outstandingJudgementsIndicator.Clean
                    && _partyToLawsuitIndicator.Clean
                    && _pass120Days.Clean
                    && _pass150Days.Clean
                    && _pass30Days.Clean
                    && _pass60Days.Clean
                    && _pass90Days.Clean
                    && _personFaxNumber.Clean
                    && _personHoursPerWeek.Clean
                    && _personIncomeAmount.Clean
                    && _personIncomeFrequencyType.Clean
                    && _personMonthlyIncome.Clean
                    && _pIWAccepted.Clean
                    && _pIWMessage.Clean
                    && _poaOccupancyIntent.Clean
                    && _poaSignatureText.Clean
                    && _positiveCashFlow.Clean
                    && _powerOfAttorneyName.Clean
                    && _powerOfAttorneyTitleDescription.Clean
                    && _presentlyDelinquentIndicator.Clean
                    && _priorBankruptcy2.Clean
                    && _priorForeclosure.Clean
                    && _priorPropertyTitleType.Clean
                    && _priorPropertyUsageType.Clean
                    && _propertyForeclosedPastSevenYearsIndicator.Clean
                    && _relationshipDescription.Clean
                    && _relationshipWithRDEmployeeIndicator.Clean
                    && _schoolingTermYears.Clean
                    && _sSA89BackgroundCheckIndicator.Clean
                    && _sSA89BankingServiceIndicator.Clean
                    && _sSA89CreditCheckIndicator.Clean
                    && _sSA89LicenseRequirementIndicator.Clean
                    && _sSA89MortgageServiceIndicator.Clean
                    && _sSA89OtherIndicator.Clean
                    && _subtotalLiquidAssetsMinusGiftAmount.Clean
                    && _suffixToName.Clean
                    && _tax4506LastInvestor.Clean
                    && _tax4506LastOrderNumber.Clean
                    && _tax4506LastOrderYear1.Clean
                    && _tax4506LastOrderYear2.Clean
                    && _tax4506LastOrderYear3.Clean
                    && _tax4506LastOrderYear4.Clean
                    && _tax4506LastProductsOrdered.Clean
                    && _tax4506LastStatus.Clean
                    && _tax4506LastTranscriptType.Clean
                    && _tax4506LastUserIDWhoOrdered.Clean
                    && _tax4506TotalYearlyIncome1.Clean
                    && _tax4506TotalYearlyIncome2.Clean
                    && _tax4506TotalYearlyIncome3.Clean
                    && _tax4506TotalYearlyIncome4.Clean
                    && _tax4506TotalYearlyJointIncome1.Clean
                    && _tax4506TotalYearlyJointIncome2.Clean
                    && _tax4506TotalYearlyJointIncome3.Clean
                    && _tax4506TotalYearlyJointIncome4.Clean
                    && _tax4506TotalYearlyVarianceIncome1.Clean
                    && _tax4506TotalYearlyVarianceIncome2.Clean
                    && _tax4506TotalYearlyVarianceIncome3.Clean
                    && _tax4506TotalYearlyVarianceIncome4.Clean
                    && _tax4506TotalYearlyVarianceJointIncome1.Clean
                    && _tax4506TotalYearlyVarianceJointIncome2.Clean
                    && _tax4506TotalYearlyVarianceJointIncome3.Clean
                    && _tax4506TotalYearlyVarianceJointIncome4.Clean
                    && _taxIdentificationIdentifier.Clean
                    && _totalLiabilitiesBalanceAmount.Clean
                    && _totalMonthlyIncomeAmount.Clean
                    && _totalMonthlyIncomeMinusNetRentalAmount.Clean
                    && _totalPresentHousingExpenseAmount.Clean
                    && _transactionPurposeDescription.Clean
                    && _transUnion120Days.Clean
                    && _transUnion150Days.Clean
                    && _transUnion30Days.Clean
                    && _transUnion60Days.Clean
                    && _transUnion90Days.Clean
                    && _transUnionCreditScoreForDisclosure.Clean
                    && _transUnionCreditScoreRanksPercent.Clean
                    && _transUnionDatePulled.Clean
                    && _transUnionFactorCode1.Clean
                    && _transUnionFactorCode2.Clean
                    && _transUnionFactorCode3.Clean
                    && _transUnionFactorCode4.Clean
                    && _transUnionFactorCode5.Clean
                    && _transUnionKeyFactor1.Clean
                    && _transUnionKeyFactor2.Clean
                    && _transUnionKeyFactor3.Clean
                    && _transUnionKeyFactor4.Clean
                    && _transUnionKeyFactor5.Clean
                    && _transUnionMaterialTermsCreditByScore.Clean
                    && _transUnionScore.Clean
                    && _userDefinedIncome.Clean
                    && _vaFederalTaxAmount.Clean
                    && _validDaysForConsentCount.Clean
                    && _valueRepAndWarrantyAvailable.Clean
                    && _valueRepAndWarrantyMessage.Clean
                    && _vaNetTakeHomePayAmount.Clean
                    && _vaOtherAmount.Clean
                    && _vaOtherNetIncomeAmount.Clean
                    && _vaRetirementAmount.Clean
                    && _vaStateTaxAmount.Clean
                    && _vaTotalIncomeDeductionsAmount.Clean
                    && _vaTotalNetIncomeAmount.Clean
                    && _vendor1.Clean
                    && _vendor10.Clean
                    && _vendor11.Clean
                    && _vendor12.Clean
                    && _vendor2.Clean
                    && _vendor3.Clean
                    && _vendor4.Clean
                    && _vendor5.Clean
                    && _vendor6.Clean
                    && _vendor7.Clean
                    && _vendor8.Clean
                    && _vendor9.Clean
                    && _vestingTrusteeOfType.Clean
                    && _veteranIndicator.Clean
                    && _workEmailAddress.Clean
                    && _yearsofCreditOnFile.Clean
                    && Application.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var acountChekAssetId = _acountChekAssetId; acountChekAssetId.Clean = value; _acountChekAssetId = acountChekAssetId;
                var ageAtApplicationYearsCount = _ageAtApplicationYearsCount; ageAtApplicationYearsCount.Clean = value; _ageAtApplicationYearsCount = ageAtApplicationYearsCount;
                var aliasName = _aliasName; aliasName.Clean = value; _aliasName = aliasName;
                var alimonyChildSupportObligationIndicator = _alimonyChildSupportObligationIndicator; alimonyChildSupportObligationIndicator.Clean = value; _alimonyChildSupportObligationIndicator = alimonyChildSupportObligationIndicator;
                var altId = _altId; altId.Clean = value; _altId = altId;
                var applicantType = _applicantType; applicantType.Clean = value; _applicantType = applicantType;
                var applicationTakenMethodType = _applicationTakenMethodType; applicationTakenMethodType.Clean = value; _applicationTakenMethodType = applicationTakenMethodType;
                var assetRepAndWarrantyMessage = _assetRepAndWarrantyMessage; assetRepAndWarrantyMessage.Clean = value; _assetRepAndWarrantyMessage = assetRepAndWarrantyMessage;
                var assetRepAndWarrantyReliefAvailable = _assetRepAndWarrantyReliefAvailable; assetRepAndWarrantyReliefAvailable.Clean = value; _assetRepAndWarrantyReliefAvailable = assetRepAndWarrantyReliefAvailable;
                var authorizedCreditReportIndicator = _authorizedCreditReportIndicator; authorizedCreditReportIndicator.Clean = value; _authorizedCreditReportIndicator = authorizedCreditReportIndicator;
                var authorizedToSignIndicator = _authorizedToSignIndicator; authorizedToSignIndicator.Clean = value; _authorizedToSignIndicator = authorizedToSignIndicator;
                var bankAccountNumber = _bankAccountNumber; bankAccountNumber.Clean = value; _bankAccountNumber = bankAccountNumber;
                var bankAccountType = _bankAccountType; bankAccountType.Clean = value; _bankAccountType = bankAccountType;
                var bankContactAddress = _bankContactAddress; bankContactAddress.Clean = value; _bankContactAddress = bankContactAddress;
                var bankContactCity = _bankContactCity; bankContactCity.Clean = value; _bankContactCity = bankContactCity;
                var bankContactName = _bankContactName; bankContactName.Clean = value; _bankContactName = bankContactName;
                var bankContactPostalCode = _bankContactPostalCode; bankContactPostalCode.Clean = value; _bankContactPostalCode = bankContactPostalCode;
                var bankContactState = _bankContactState; bankContactState.Clean = value; _bankContactState = bankContactState;
                var bankruptcyIndicator = _bankruptcyIndicator; bankruptcyIndicator.Clean = value; _bankruptcyIndicator = bankruptcyIndicator;
                var bankruptcyStatus = _bankruptcyStatus; bankruptcyStatus.Clean = value; _bankruptcyStatus = bankruptcyStatus;
                var baseMonthlyIncomeAmount = _baseMonthlyIncomeAmount; baseMonthlyIncomeAmount.Clean = value; _baseMonthlyIncomeAmount = baseMonthlyIncomeAmount;
                var birthDate = _birthDate; birthDate.Clean = value; _birthDate = birthDate;
                var borrowedDownPaymentIndicator = _borrowedDownPaymentIndicator; borrowedDownPaymentIndicator.Clean = value; _borrowedDownPaymentIndicator = borrowedDownPaymentIndicator;
                var borrowerConsentRequestDate = _borrowerConsentRequestDate; borrowerConsentRequestDate.Clean = value; _borrowerConsentRequestDate = borrowerConsentRequestDate;
                var borrowerIndex = _borrowerIndex; borrowerIndex.Clean = value; _borrowerIndex = borrowerIndex;
                var borrowerType = _borrowerType; borrowerType.Clean = value; _borrowerType = borrowerType;
                var borrowerTypeInSummary = _borrowerTypeInSummary; borrowerTypeInSummary.Clean = value; _borrowerTypeInSummary = borrowerTypeInSummary;
                var caivrsIdentifier = _caivrsIdentifier; caivrsIdentifier.Clean = value; _caivrsIdentifier = caivrsIdentifier;
                var citizenshipResidencyType = _citizenshipResidencyType; citizenshipResidencyType.Clean = value; _citizenshipResidencyType = citizenshipResidencyType;
                var coMakerEndorserOfNoteIndicator = _coMakerEndorserOfNoteIndicator; coMakerEndorserOfNoteIndicator.Clean = value; _coMakerEndorserOfNoteIndicator = coMakerEndorserOfNoteIndicator;
                var commentOfCreditReport = _commentOfCreditReport; commentOfCreditReport.Clean = value; _commentOfCreditReport = commentOfCreditReport;
                var confirmedCRDIL = _confirmedCRDIL; confirmedCRDIL.Clean = value; _confirmedCRDIL = confirmedCRDIL;
                var confirmedCRFCEC = _confirmedCRFCEC; confirmedCRFCEC.Clean = value; _confirmedCRFCEC = confirmedCRFCEC;
                var confirmedCRFCIncorrect = _confirmedCRFCIncorrect; confirmedCRFCIncorrect.Clean = value; _confirmedCRFCIncorrect = confirmedCRFCIncorrect;
                var confirmedCRPFS = _confirmedCRPFS; confirmedCRPFS.Clean = value; _confirmedCRPFS = confirmedCRPFS;
                var confirmedOther = _confirmedOther; confirmedOther.Clean = value; _confirmedOther = confirmedOther;
                var confirmedOtherDescription = _confirmedOtherDescription; confirmedOtherDescription.Clean = value; _confirmedOtherDescription = confirmedOtherDescription;
                var creditCounseling = _creditCounseling; creditCounseling.Clean = value; _creditCounseling = creditCounseling;
                var creditReceivedDate = _creditReceivedDate; creditReceivedDate.Clean = value; _creditReceivedDate = creditReceivedDate;
                var creditReportAuthorizationMethod = _creditReportAuthorizationMethod; creditReportAuthorizationMethod.Clean = value; _creditReportAuthorizationMethod = creditReportAuthorizationMethod;
                var creditScoreIndicator = _creditScoreIndicator; creditScoreIndicator.Clean = value; _creditScoreIndicator = creditScoreIndicator;
                var dateAuthorizedCreditReport = _dateAuthorizedCreditReport; dateAuthorizedCreditReport.Clean = value; _dateAuthorizedCreditReport = dateAuthorizedCreditReport;
                var dateOfBankruptcy = _dateOfBankruptcy; dateOfBankruptcy.Clean = value; _dateOfBankruptcy = dateOfBankruptcy;
                var dateOfForeclosure = _dateOfForeclosure; dateOfForeclosure.Clean = value; _dateOfForeclosure = dateOfForeclosure;
                var declarationsJIndicator = _declarationsJIndicator; declarationsJIndicator.Clean = value; _declarationsJIndicator = declarationsJIndicator;
                var declarationsKIndicator = _declarationsKIndicator; declarationsKIndicator.Clean = value; _declarationsKIndicator = declarationsKIndicator;
                var dependentCount = _dependentCount; dependentCount.Clean = value; _dependentCount = dependentCount;
                var dependentsAgesDescription = _dependentsAgesDescription; dependentsAgesDescription.Clean = value; _dependentsAgesDescription = dependentsAgesDescription;
                var disabledIndicator = _disabledIndicator; disabledIndicator.Clean = value; _disabledIndicator = disabledIndicator;
                var emailAddressText = _emailAddressText; emailAddressText.Clean = value; _emailAddressText = emailAddressText;
                var equifax120Days = _equifax120Days; equifax120Days.Clean = value; _equifax120Days = equifax120Days;
                var equifax150Days = _equifax150Days; equifax150Days.Clean = value; _equifax150Days = equifax150Days;
                var equifax30Days = _equifax30Days; equifax30Days.Clean = value; _equifax30Days = equifax30Days;
                var equifax60Days = _equifax60Days; equifax60Days.Clean = value; _equifax60Days = equifax60Days;
                var equifax90Days = _equifax90Days; equifax90Days.Clean = value; _equifax90Days = equifax90Days;
                var equifaxCreditScoreForDisclosure = _equifaxCreditScoreForDisclosure; equifaxCreditScoreForDisclosure.Clean = value; _equifaxCreditScoreForDisclosure = equifaxCreditScoreForDisclosure;
                var equifaxCreditScoreRanksPercent = _equifaxCreditScoreRanksPercent; equifaxCreditScoreRanksPercent.Clean = value; _equifaxCreditScoreRanksPercent = equifaxCreditScoreRanksPercent;
                var equifaxDatePulled = _equifaxDatePulled; equifaxDatePulled.Clean = value; _equifaxDatePulled = equifaxDatePulled;
                var equifaxFactorCode1 = _equifaxFactorCode1; equifaxFactorCode1.Clean = value; _equifaxFactorCode1 = equifaxFactorCode1;
                var equifaxFactorCode2 = _equifaxFactorCode2; equifaxFactorCode2.Clean = value; _equifaxFactorCode2 = equifaxFactorCode2;
                var equifaxFactorCode3 = _equifaxFactorCode3; equifaxFactorCode3.Clean = value; _equifaxFactorCode3 = equifaxFactorCode3;
                var equifaxFactorCode4 = _equifaxFactorCode4; equifaxFactorCode4.Clean = value; _equifaxFactorCode4 = equifaxFactorCode4;
                var equifaxFactorCode5 = _equifaxFactorCode5; equifaxFactorCode5.Clean = value; _equifaxFactorCode5 = equifaxFactorCode5;
                var equifaxKeyFactor1 = _equifaxKeyFactor1; equifaxKeyFactor1.Clean = value; _equifaxKeyFactor1 = equifaxKeyFactor1;
                var equifaxKeyFactor2 = _equifaxKeyFactor2; equifaxKeyFactor2.Clean = value; _equifaxKeyFactor2 = equifaxKeyFactor2;
                var equifaxKeyFactor3 = _equifaxKeyFactor3; equifaxKeyFactor3.Clean = value; _equifaxKeyFactor3 = equifaxKeyFactor3;
                var equifaxKeyFactor4 = _equifaxKeyFactor4; equifaxKeyFactor4.Clean = value; _equifaxKeyFactor4 = equifaxKeyFactor4;
                var equifaxKeyFactor5 = _equifaxKeyFactor5; equifaxKeyFactor5.Clean = value; _equifaxKeyFactor5 = equifaxKeyFactor5;
                var equifaxMaterialTermsCreditByScore = _equifaxMaterialTermsCreditByScore; equifaxMaterialTermsCreditByScore.Clean = value; _equifaxMaterialTermsCreditByScore = equifaxMaterialTermsCreditByScore;
                var equifaxScore = _equifaxScore; equifaxScore.Clean = value; _equifaxScore = equifaxScore;
                var experian120Days = _experian120Days; experian120Days.Clean = value; _experian120Days = experian120Days;
                var experian150Days = _experian150Days; experian150Days.Clean = value; _experian150Days = experian150Days;
                var experian30Days = _experian30Days; experian30Days.Clean = value; _experian30Days = experian30Days;
                var experian60Days = _experian60Days; experian60Days.Clean = value; _experian60Days = experian60Days;
                var experian90Days = _experian90Days; experian90Days.Clean = value; _experian90Days = experian90Days;
                var experianCreditScore = _experianCreditScore; experianCreditScore.Clean = value; _experianCreditScore = experianCreditScore;
                var experianCreditScoreForDisclosure = _experianCreditScoreForDisclosure; experianCreditScoreForDisclosure.Clean = value; _experianCreditScoreForDisclosure = experianCreditScoreForDisclosure;
                var experianCreditScoreRanksPercent = _experianCreditScoreRanksPercent; experianCreditScoreRanksPercent.Clean = value; _experianCreditScoreRanksPercent = experianCreditScoreRanksPercent;
                var experianDatePulled = _experianDatePulled; experianDatePulled.Clean = value; _experianDatePulled = experianDatePulled;
                var experianFactorCode1 = _experianFactorCode1; experianFactorCode1.Clean = value; _experianFactorCode1 = experianFactorCode1;
                var experianFactorCode2 = _experianFactorCode2; experianFactorCode2.Clean = value; _experianFactorCode2 = experianFactorCode2;
                var experianFactorCode3 = _experianFactorCode3; experianFactorCode3.Clean = value; _experianFactorCode3 = experianFactorCode3;
                var experianFactorCode4 = _experianFactorCode4; experianFactorCode4.Clean = value; _experianFactorCode4 = experianFactorCode4;
                var experianFactorCode5 = _experianFactorCode5; experianFactorCode5.Clean = value; _experianFactorCode5 = experianFactorCode5;
                var experianKeyFactor1 = _experianKeyFactor1; experianKeyFactor1.Clean = value; _experianKeyFactor1 = experianKeyFactor1;
                var experianKeyFactor2 = _experianKeyFactor2; experianKeyFactor2.Clean = value; _experianKeyFactor2 = experianKeyFactor2;
                var experianKeyFactor3 = _experianKeyFactor3; experianKeyFactor3.Clean = value; _experianKeyFactor3 = experianKeyFactor3;
                var experianKeyFactor4 = _experianKeyFactor4; experianKeyFactor4.Clean = value; _experianKeyFactor4 = experianKeyFactor4;
                var experianKeyFactor5 = _experianKeyFactor5; experianKeyFactor5.Clean = value; _experianKeyFactor5 = experianKeyFactor5;
                var experianMaterialTermsCreditByScore = _experianMaterialTermsCreditByScore; experianMaterialTermsCreditByScore.Clean = value; _experianMaterialTermsCreditByScore = experianMaterialTermsCreditByScore;
                var firstName = _firstName; firstName.Clean = value; _firstName = firstName;
                var firstNameWithMiddleName = _firstNameWithMiddleName; firstNameWithMiddleName.Clean = value; _firstNameWithMiddleName = firstNameWithMiddleName;
                var firstTimeHomeBuyer = _firstTimeHomeBuyer; firstTimeHomeBuyer.Clean = value; _firstTimeHomeBuyer = firstTimeHomeBuyer;
                var foreclosureSatisfied = _foreclosureSatisfied; foreclosureSatisfied.Clean = value; _foreclosureSatisfied = foreclosureSatisfied;
                var foreclosureStatus = _foreclosureStatus; foreclosureStatus.Clean = value; _foreclosureStatus = foreclosureStatus;
                var freddieMacPerson1 = _freddieMacPerson1; freddieMacPerson1.Clean = value; _freddieMacPerson1 = freddieMacPerson1;
                var freddieMacPerson2 = _freddieMacPerson2; freddieMacPerson2.Clean = value; _freddieMacPerson2 = freddieMacPerson2;
                var fullName = _fullName; fullName.Clean = value; _fullName = fullName;
                var fullNameWithSuffix = _fullNameWithSuffix; fullNameWithSuffix.Clean = value; _fullNameWithSuffix = fullNameWithSuffix;
                var highestCreditLimit = _highestCreditLimit; highestCreditLimit.Clean = value; _highestCreditLimit = highestCreditLimit;
                var hmda2003OtherRaceNationalOriginDescription = _hmda2003OtherRaceNationalOriginDescription; hmda2003OtherRaceNationalOriginDescription.Clean = value; _hmda2003OtherRaceNationalOriginDescription = hmda2003OtherRaceNationalOriginDescription;
                var hmda2003RaceNationalOriginType = _hmda2003RaceNationalOriginType; hmda2003RaceNationalOriginType.Clean = value; _hmda2003RaceNationalOriginType = hmda2003RaceNationalOriginType;
                var hmdaAfricanAmericanIndicator = _hmdaAfricanAmericanIndicator; hmdaAfricanAmericanIndicator.Clean = value; _hmdaAfricanAmericanIndicator = hmdaAfricanAmericanIndicator;
                var hmdaAge = _hmdaAge; hmdaAge.Clean = value; _hmdaAge = hmdaAge;
                var hmdaAmericanIndianIndicator = _hmdaAmericanIndianIndicator; hmdaAmericanIndianIndicator.Clean = value; _hmdaAmericanIndianIndicator = hmdaAmericanIndianIndicator;
                var hmdaAmericanIndianTribe = _hmdaAmericanIndianTribe; hmdaAmericanIndianTribe.Clean = value; _hmdaAmericanIndianTribe = hmdaAmericanIndianTribe;
                var hmdaAsianIndianIndicator = _hmdaAsianIndianIndicator; hmdaAsianIndianIndicator.Clean = value; _hmdaAsianIndianIndicator = hmdaAsianIndianIndicator;
                var hmdaAsianIndicator = _hmdaAsianIndicator; hmdaAsianIndicator.Clean = value; _hmdaAsianIndicator = hmdaAsianIndicator;
                var hmdaAsianOtherRaceIndicator = _hmdaAsianOtherRaceIndicator; hmdaAsianOtherRaceIndicator.Clean = value; _hmdaAsianOtherRaceIndicator = hmdaAsianOtherRaceIndicator;
                var hmdaChineseIndicator = _hmdaChineseIndicator; hmdaChineseIndicator.Clean = value; _hmdaChineseIndicator = hmdaChineseIndicator;
                var hmdaCreditScoreForDecisionMaking = _hmdaCreditScoreForDecisionMaking; hmdaCreditScoreForDecisionMaking.Clean = value; _hmdaCreditScoreForDecisionMaking = hmdaCreditScoreForDecisionMaking;
                var hmdaCreditScoringModel = _hmdaCreditScoringModel; hmdaCreditScoringModel.Clean = value; _hmdaCreditScoringModel = hmdaCreditScoringModel;
                var hmdaCubanIndicator = _hmdaCubanIndicator; hmdaCubanIndicator.Clean = value; _hmdaCubanIndicator = hmdaCubanIndicator;
                var hmdaEthnicityType = _hmdaEthnicityType; hmdaEthnicityType.Clean = value; _hmdaEthnicityType = hmdaEthnicityType;
                var hmdaFilipinoIndicator = _hmdaFilipinoIndicator; hmdaFilipinoIndicator.Clean = value; _hmdaFilipinoIndicator = hmdaFilipinoIndicator;
                var hmdaGenderType = _hmdaGenderType; hmdaGenderType.Clean = value; _hmdaGenderType = hmdaGenderType;
                var hmdaGendertypeDoNotWishIndicator = _hmdaGendertypeDoNotWishIndicator; hmdaGendertypeDoNotWishIndicator.Clean = value; _hmdaGendertypeDoNotWishIndicator = hmdaGendertypeDoNotWishIndicator;
                var hmdaGendertypeFemaleIndicator = _hmdaGendertypeFemaleIndicator; hmdaGendertypeFemaleIndicator.Clean = value; _hmdaGendertypeFemaleIndicator = hmdaGendertypeFemaleIndicator;
                var hmdaGendertypeMaleIndicator = _hmdaGendertypeMaleIndicator; hmdaGendertypeMaleIndicator.Clean = value; _hmdaGendertypeMaleIndicator = hmdaGendertypeMaleIndicator;
                var hmdaGendertypeNotApplicableIndicator = _hmdaGendertypeNotApplicableIndicator; hmdaGendertypeNotApplicableIndicator.Clean = value; _hmdaGendertypeNotApplicableIndicator = hmdaGendertypeNotApplicableIndicator;
                var hmdaGuamanianOrChamorroIndicator = _hmdaGuamanianOrChamorroIndicator; hmdaGuamanianOrChamorroIndicator.Clean = value; _hmdaGuamanianOrChamorroIndicator = hmdaGuamanianOrChamorroIndicator;
                var hmdaHispanicLatinoOtherOriginIndicator = _hmdaHispanicLatinoOtherOriginIndicator; hmdaHispanicLatinoOtherOriginIndicator.Clean = value; _hmdaHispanicLatinoOtherOriginIndicator = hmdaHispanicLatinoOtherOriginIndicator;
                var hmdaJapaneseIndicator = _hmdaJapaneseIndicator; hmdaJapaneseIndicator.Clean = value; _hmdaJapaneseIndicator = hmdaJapaneseIndicator;
                var hmdaKoreanIndicator = _hmdaKoreanIndicator; hmdaKoreanIndicator.Clean = value; _hmdaKoreanIndicator = hmdaKoreanIndicator;
                var hmdaMexicanIndicator = _hmdaMexicanIndicator; hmdaMexicanIndicator.Clean = value; _hmdaMexicanIndicator = hmdaMexicanIndicator;
                var hmdaNativeHawaiianIndicator = _hmdaNativeHawaiianIndicator; hmdaNativeHawaiianIndicator.Clean = value; _hmdaNativeHawaiianIndicator = hmdaNativeHawaiianIndicator;
                var hmdaNoCoApplicantIndicator = _hmdaNoCoApplicantIndicator; hmdaNoCoApplicantIndicator.Clean = value; _hmdaNoCoApplicantIndicator = hmdaNoCoApplicantIndicator;
                var hmdaNotApplicableIndicator = _hmdaNotApplicableIndicator; hmdaNotApplicableIndicator.Clean = value; _hmdaNotApplicableIndicator = hmdaNotApplicableIndicator;
                var hmdaNotProvidedIndicator = _hmdaNotProvidedIndicator; hmdaNotProvidedIndicator.Clean = value; _hmdaNotProvidedIndicator = hmdaNotProvidedIndicator;
                var hmdaOtherAsianRace = _hmdaOtherAsianRace; hmdaOtherAsianRace.Clean = value; _hmdaOtherAsianRace = hmdaOtherAsianRace;
                var hmdaOtherHispanicLatinoOrigin = _hmdaOtherHispanicLatinoOrigin; hmdaOtherHispanicLatinoOrigin.Clean = value; _hmdaOtherHispanicLatinoOrigin = hmdaOtherHispanicLatinoOrigin;
                var hmdaOtherPacificIslanderRace = _hmdaOtherPacificIslanderRace; hmdaOtherPacificIslanderRace.Clean = value; _hmdaOtherPacificIslanderRace = hmdaOtherPacificIslanderRace;
                var hmdaOtherScoringModel = _hmdaOtherScoringModel; hmdaOtherScoringModel.Clean = value; _hmdaOtherScoringModel = hmdaOtherScoringModel;
                var hmdaPacificIslanderIndicator = _hmdaPacificIslanderIndicator; hmdaPacificIslanderIndicator.Clean = value; _hmdaPacificIslanderIndicator = hmdaPacificIslanderIndicator;
                var hmdaPacificIslanderOtherIndicator = _hmdaPacificIslanderOtherIndicator; hmdaPacificIslanderOtherIndicator.Clean = value; _hmdaPacificIslanderOtherIndicator = hmdaPacificIslanderOtherIndicator;
                var hmdaPuertoRicanIndicator = _hmdaPuertoRicanIndicator; hmdaPuertoRicanIndicator.Clean = value; _hmdaPuertoRicanIndicator = hmdaPuertoRicanIndicator;
                var hmdaRefusalIndicator = _hmdaRefusalIndicator; hmdaRefusalIndicator.Clean = value; _hmdaRefusalIndicator = hmdaRefusalIndicator;
                var hmdaSamoanIndicator = _hmdaSamoanIndicator; hmdaSamoanIndicator.Clean = value; _hmdaSamoanIndicator = hmdaSamoanIndicator;
                var hmdaVietnameseIndicator = _hmdaVietnameseIndicator; hmdaVietnameseIndicator.Clean = value; _hmdaVietnameseIndicator = hmdaVietnameseIndicator;
                var hmdaWhiteIndicator = _hmdaWhiteIndicator; hmdaWhiteIndicator.Clean = value; _hmdaWhiteIndicator = hmdaWhiteIndicator;
                var homeownerPastThreeYearsIndicator = _homeownerPastThreeYearsIndicator; homeownerPastThreeYearsIndicator.Clean = value; _homeownerPastThreeYearsIndicator = homeownerPastThreeYearsIndicator;
                var homePhoneNumber = _homePhoneNumber; homePhoneNumber.Clean = value; _homePhoneNumber = homePhoneNumber;
                var id = _id; id.Clean = value; _id = id;
                var incomeRepAndWarrantyMessage = _incomeRepAndWarrantyMessage; incomeRepAndWarrantyMessage.Clean = value; _incomeRepAndWarrantyMessage = incomeRepAndWarrantyMessage;
                var incomeRepAndWarrantyReliefAvailable = _incomeRepAndWarrantyReliefAvailable; incomeRepAndWarrantyReliefAvailable.Clean = value; _incomeRepAndWarrantyReliefAvailable = incomeRepAndWarrantyReliefAvailable;
                var intentToOccupyIndicator = _intentToOccupyIndicator; intentToOccupyIndicator.Clean = value; _intentToOccupyIndicator = intentToOccupyIndicator;
                var intuitReportId = _intuitReportId; intuitReportId.Clean = value; _intuitReportId = intuitReportId;
                var isBaseIncomeAvailable = _isBaseIncomeAvailable; isBaseIncomeAvailable.Clean = value; _isBaseIncomeAvailable = isBaseIncomeAvailable;
                var isBonusAvailable = _isBonusAvailable; isBonusAvailable.Clean = value; _isBonusAvailable = isBonusAvailable;
                var isBorrower = _isBorrower; isBorrower.Clean = value; _isBorrower = isBorrower;
                var isCommissionAvailable = _isCommissionAvailable; isCommissionAvailable.Clean = value; _isCommissionAvailable = isCommissionAvailable;
                var isEthnicityBasedOnVisual = _isEthnicityBasedOnVisual; isEthnicityBasedOnVisual.Clean = value; _isEthnicityBasedOnVisual = isEthnicityBasedOnVisual;
                var isOvertimeAvailable = _isOvertimeAvailable; isOvertimeAvailable.Clean = value; _isOvertimeAvailable = isOvertimeAvailable;
                var isRaceBasedOnVisual = _isRaceBasedOnVisual; isRaceBasedOnVisual.Clean = value; _isRaceBasedOnVisual = isRaceBasedOnVisual;
                var isSelfEmployed = _isSelfEmployed; isSelfEmployed.Clean = value; _isSelfEmployed = isSelfEmployed;
                var isSexBasedOnVisual = _isSexBasedOnVisual; isSexBasedOnVisual.Clean = value; _isSexBasedOnVisual = isSexBasedOnVisual;
                var isSocialSecurityAvailable = _isSocialSecurityAvailable; isSocialSecurityAvailable.Clean = value; _isSocialSecurityAvailable = isSocialSecurityAvailable;
                var lastName = _lastName; lastName.Clean = value; _lastName = lastName;
                var lastNameWithSuffix = _lastNameWithSuffix; lastNameWithSuffix.Clean = value; _lastNameWithSuffix = lastNameWithSuffix;
                var loanForeclosureOrJudgementIndicator = _loanForeclosureOrJudgementIndicator; loanForeclosureOrJudgementIndicator.Clean = value; _loanForeclosureOrJudgementIndicator = loanForeclosureOrJudgementIndicator;
                var lpdGsa = _lpdGsa; lpdGsa.Clean = value; _lpdGsa = lpdGsa;
                var mailingAddressSameAsPresentIndicator = _mailingAddressSameAsPresentIndicator; mailingAddressSameAsPresentIndicator.Clean = value; _mailingAddressSameAsPresentIndicator = mailingAddressSameAsPresentIndicator;
                var maritalStatusType = _maritalStatusType; maritalStatusType.Clean = value; _maritalStatusType = maritalStatusType;
                var middleCreditScore = _middleCreditScore; middleCreditScore.Clean = value; _middleCreditScore = middleCreditScore;
                var middleFicoScore = _middleFicoScore; middleFicoScore.Clean = value; _middleFicoScore = middleFicoScore;
                var middleName = _middleName; middleName.Clean = value; _middleName = middleName;
                var minFicoScore = _minFicoScore; minFicoScore.Clean = value; _minFicoScore = minFicoScore;
                var mobilePhone = _mobilePhone; mobilePhone.Clean = value; _mobilePhone = mobilePhone;
                var mortgageOnCredit = _mortgageOnCredit; mortgageOnCredit.Clean = value; _mortgageOnCredit = mortgageOnCredit;
                var nameToObtainLoanFromRHS = _nameToObtainLoanFromRHS; nameToObtainLoanFromRHS.Clean = value; _nameToObtainLoanFromRHS = nameToObtainLoanFromRHS;
                var nearestRelativeAddress = _nearestRelativeAddress; nearestRelativeAddress.Clean = value; _nearestRelativeAddress = nearestRelativeAddress;
                var nearestRelativeCity = _nearestRelativeCity; nearestRelativeCity.Clean = value; _nearestRelativeCity = nearestRelativeCity;
                var nearestRelativeName = _nearestRelativeName; nearestRelativeName.Clean = value; _nearestRelativeName = nearestRelativeName;
                var nearestRelativePhone = _nearestRelativePhone; nearestRelativePhone.Clean = value; _nearestRelativePhone = nearestRelativePhone;
                var nearestRelativePostalCode = _nearestRelativePostalCode; nearestRelativePostalCode.Clean = value; _nearestRelativePostalCode = nearestRelativePostalCode;
                var nearestRelativeRelationship = _nearestRelativeRelationship; nearestRelativeRelationship.Clean = value; _nearestRelativeRelationship = nearestRelativeRelationship;
                var nearestRelativeState = _nearestRelativeState; nearestRelativeState.Clean = value; _nearestRelativeState = nearestRelativeState;
                var no3rdPartyEmailIndicator = _no3rdPartyEmailIndicator; no3rdPartyEmailIndicator.Clean = value; _no3rdPartyEmailIndicator = no3rdPartyEmailIndicator;
                var noCoApplicantEthnicityIndicator = _noCoApplicantEthnicityIndicator; noCoApplicantEthnicityIndicator.Clean = value; _noCoApplicantEthnicityIndicator = noCoApplicantEthnicityIndicator;
                var noCoApplicantIndicator = _noCoApplicantIndicator; noCoApplicantIndicator.Clean = value; _noCoApplicantIndicator = noCoApplicantIndicator;
                var noCoApplicantSexIndicator = _noCoApplicantSexIndicator; noCoApplicantSexIndicator.Clean = value; _noCoApplicantSexIndicator = noCoApplicantSexIndicator;
                var numberofTradelines = _numberofTradelines; numberofTradelines.Clean = value; _numberofTradelines = numberofTradelines;
                var obtainLoanFromRHSIndicator = _obtainLoanFromRHSIndicator; obtainLoanFromRHSIndicator.Clean = value; _obtainLoanFromRHSIndicator = obtainLoanFromRHSIndicator;
                var openBankruptcy2 = _openBankruptcy2; openBankruptcy2.Clean = value; _openBankruptcy2 = openBankruptcy2;
                var otherMonthlyIncomeAmount = _otherMonthlyIncomeAmount; otherMonthlyIncomeAmount.Clean = value; _otherMonthlyIncomeAmount = otherMonthlyIncomeAmount;
                var otherSumAmount = _otherSumAmount; otherSumAmount.Clean = value; _otherSumAmount = otherSumAmount;
                var outstandingJudgementsIndicator = _outstandingJudgementsIndicator; outstandingJudgementsIndicator.Clean = value; _outstandingJudgementsIndicator = outstandingJudgementsIndicator;
                var partyToLawsuitIndicator = _partyToLawsuitIndicator; partyToLawsuitIndicator.Clean = value; _partyToLawsuitIndicator = partyToLawsuitIndicator;
                var pass120Days = _pass120Days; pass120Days.Clean = value; _pass120Days = pass120Days;
                var pass150Days = _pass150Days; pass150Days.Clean = value; _pass150Days = pass150Days;
                var pass30Days = _pass30Days; pass30Days.Clean = value; _pass30Days = pass30Days;
                var pass60Days = _pass60Days; pass60Days.Clean = value; _pass60Days = pass60Days;
                var pass90Days = _pass90Days; pass90Days.Clean = value; _pass90Days = pass90Days;
                var personFaxNumber = _personFaxNumber; personFaxNumber.Clean = value; _personFaxNumber = personFaxNumber;
                var personHoursPerWeek = _personHoursPerWeek; personHoursPerWeek.Clean = value; _personHoursPerWeek = personHoursPerWeek;
                var personIncomeAmount = _personIncomeAmount; personIncomeAmount.Clean = value; _personIncomeAmount = personIncomeAmount;
                var personIncomeFrequencyType = _personIncomeFrequencyType; personIncomeFrequencyType.Clean = value; _personIncomeFrequencyType = personIncomeFrequencyType;
                var personMonthlyIncome = _personMonthlyIncome; personMonthlyIncome.Clean = value; _personMonthlyIncome = personMonthlyIncome;
                var pIWAccepted = _pIWAccepted; pIWAccepted.Clean = value; _pIWAccepted = pIWAccepted;
                var pIWMessage = _pIWMessage; pIWMessage.Clean = value; _pIWMessage = pIWMessage;
                var poaOccupancyIntent = _poaOccupancyIntent; poaOccupancyIntent.Clean = value; _poaOccupancyIntent = poaOccupancyIntent;
                var poaSignatureText = _poaSignatureText; poaSignatureText.Clean = value; _poaSignatureText = poaSignatureText;
                var positiveCashFlow = _positiveCashFlow; positiveCashFlow.Clean = value; _positiveCashFlow = positiveCashFlow;
                var powerOfAttorneyName = _powerOfAttorneyName; powerOfAttorneyName.Clean = value; _powerOfAttorneyName = powerOfAttorneyName;
                var powerOfAttorneyTitleDescription = _powerOfAttorneyTitleDescription; powerOfAttorneyTitleDescription.Clean = value; _powerOfAttorneyTitleDescription = powerOfAttorneyTitleDescription;
                var presentlyDelinquentIndicator = _presentlyDelinquentIndicator; presentlyDelinquentIndicator.Clean = value; _presentlyDelinquentIndicator = presentlyDelinquentIndicator;
                var priorBankruptcy2 = _priorBankruptcy2; priorBankruptcy2.Clean = value; _priorBankruptcy2 = priorBankruptcy2;
                var priorForeclosure = _priorForeclosure; priorForeclosure.Clean = value; _priorForeclosure = priorForeclosure;
                var priorPropertyTitleType = _priorPropertyTitleType; priorPropertyTitleType.Clean = value; _priorPropertyTitleType = priorPropertyTitleType;
                var priorPropertyUsageType = _priorPropertyUsageType; priorPropertyUsageType.Clean = value; _priorPropertyUsageType = priorPropertyUsageType;
                var propertyForeclosedPastSevenYearsIndicator = _propertyForeclosedPastSevenYearsIndicator; propertyForeclosedPastSevenYearsIndicator.Clean = value; _propertyForeclosedPastSevenYearsIndicator = propertyForeclosedPastSevenYearsIndicator;
                var relationshipDescription = _relationshipDescription; relationshipDescription.Clean = value; _relationshipDescription = relationshipDescription;
                var relationshipWithRDEmployeeIndicator = _relationshipWithRDEmployeeIndicator; relationshipWithRDEmployeeIndicator.Clean = value; _relationshipWithRDEmployeeIndicator = relationshipWithRDEmployeeIndicator;
                var schoolingTermYears = _schoolingTermYears; schoolingTermYears.Clean = value; _schoolingTermYears = schoolingTermYears;
                var sSA89BackgroundCheckIndicator = _sSA89BackgroundCheckIndicator; sSA89BackgroundCheckIndicator.Clean = value; _sSA89BackgroundCheckIndicator = sSA89BackgroundCheckIndicator;
                var sSA89BankingServiceIndicator = _sSA89BankingServiceIndicator; sSA89BankingServiceIndicator.Clean = value; _sSA89BankingServiceIndicator = sSA89BankingServiceIndicator;
                var sSA89CreditCheckIndicator = _sSA89CreditCheckIndicator; sSA89CreditCheckIndicator.Clean = value; _sSA89CreditCheckIndicator = sSA89CreditCheckIndicator;
                var sSA89LicenseRequirementIndicator = _sSA89LicenseRequirementIndicator; sSA89LicenseRequirementIndicator.Clean = value; _sSA89LicenseRequirementIndicator = sSA89LicenseRequirementIndicator;
                var sSA89MortgageServiceIndicator = _sSA89MortgageServiceIndicator; sSA89MortgageServiceIndicator.Clean = value; _sSA89MortgageServiceIndicator = sSA89MortgageServiceIndicator;
                var sSA89OtherIndicator = _sSA89OtherIndicator; sSA89OtherIndicator.Clean = value; _sSA89OtherIndicator = sSA89OtherIndicator;
                var subtotalLiquidAssetsMinusGiftAmount = _subtotalLiquidAssetsMinusGiftAmount; subtotalLiquidAssetsMinusGiftAmount.Clean = value; _subtotalLiquidAssetsMinusGiftAmount = subtotalLiquidAssetsMinusGiftAmount;
                var suffixToName = _suffixToName; suffixToName.Clean = value; _suffixToName = suffixToName;
                var tax4506LastInvestor = _tax4506LastInvestor; tax4506LastInvestor.Clean = value; _tax4506LastInvestor = tax4506LastInvestor;
                var tax4506LastOrderNumber = _tax4506LastOrderNumber; tax4506LastOrderNumber.Clean = value; _tax4506LastOrderNumber = tax4506LastOrderNumber;
                var tax4506LastOrderYear1 = _tax4506LastOrderYear1; tax4506LastOrderYear1.Clean = value; _tax4506LastOrderYear1 = tax4506LastOrderYear1;
                var tax4506LastOrderYear2 = _tax4506LastOrderYear2; tax4506LastOrderYear2.Clean = value; _tax4506LastOrderYear2 = tax4506LastOrderYear2;
                var tax4506LastOrderYear3 = _tax4506LastOrderYear3; tax4506LastOrderYear3.Clean = value; _tax4506LastOrderYear3 = tax4506LastOrderYear3;
                var tax4506LastOrderYear4 = _tax4506LastOrderYear4; tax4506LastOrderYear4.Clean = value; _tax4506LastOrderYear4 = tax4506LastOrderYear4;
                var tax4506LastProductsOrdered = _tax4506LastProductsOrdered; tax4506LastProductsOrdered.Clean = value; _tax4506LastProductsOrdered = tax4506LastProductsOrdered;
                var tax4506LastStatus = _tax4506LastStatus; tax4506LastStatus.Clean = value; _tax4506LastStatus = tax4506LastStatus;
                var tax4506LastTranscriptType = _tax4506LastTranscriptType; tax4506LastTranscriptType.Clean = value; _tax4506LastTranscriptType = tax4506LastTranscriptType;
                var tax4506LastUserIDWhoOrdered = _tax4506LastUserIDWhoOrdered; tax4506LastUserIDWhoOrdered.Clean = value; _tax4506LastUserIDWhoOrdered = tax4506LastUserIDWhoOrdered;
                var tax4506TotalYearlyIncome1 = _tax4506TotalYearlyIncome1; tax4506TotalYearlyIncome1.Clean = value; _tax4506TotalYearlyIncome1 = tax4506TotalYearlyIncome1;
                var tax4506TotalYearlyIncome2 = _tax4506TotalYearlyIncome2; tax4506TotalYearlyIncome2.Clean = value; _tax4506TotalYearlyIncome2 = tax4506TotalYearlyIncome2;
                var tax4506TotalYearlyIncome3 = _tax4506TotalYearlyIncome3; tax4506TotalYearlyIncome3.Clean = value; _tax4506TotalYearlyIncome3 = tax4506TotalYearlyIncome3;
                var tax4506TotalYearlyIncome4 = _tax4506TotalYearlyIncome4; tax4506TotalYearlyIncome4.Clean = value; _tax4506TotalYearlyIncome4 = tax4506TotalYearlyIncome4;
                var tax4506TotalYearlyJointIncome1 = _tax4506TotalYearlyJointIncome1; tax4506TotalYearlyJointIncome1.Clean = value; _tax4506TotalYearlyJointIncome1 = tax4506TotalYearlyJointIncome1;
                var tax4506TotalYearlyJointIncome2 = _tax4506TotalYearlyJointIncome2; tax4506TotalYearlyJointIncome2.Clean = value; _tax4506TotalYearlyJointIncome2 = tax4506TotalYearlyJointIncome2;
                var tax4506TotalYearlyJointIncome3 = _tax4506TotalYearlyJointIncome3; tax4506TotalYearlyJointIncome3.Clean = value; _tax4506TotalYearlyJointIncome3 = tax4506TotalYearlyJointIncome3;
                var tax4506TotalYearlyJointIncome4 = _tax4506TotalYearlyJointIncome4; tax4506TotalYearlyJointIncome4.Clean = value; _tax4506TotalYearlyJointIncome4 = tax4506TotalYearlyJointIncome4;
                var tax4506TotalYearlyVarianceIncome1 = _tax4506TotalYearlyVarianceIncome1; tax4506TotalYearlyVarianceIncome1.Clean = value; _tax4506TotalYearlyVarianceIncome1 = tax4506TotalYearlyVarianceIncome1;
                var tax4506TotalYearlyVarianceIncome2 = _tax4506TotalYearlyVarianceIncome2; tax4506TotalYearlyVarianceIncome2.Clean = value; _tax4506TotalYearlyVarianceIncome2 = tax4506TotalYearlyVarianceIncome2;
                var tax4506TotalYearlyVarianceIncome3 = _tax4506TotalYearlyVarianceIncome3; tax4506TotalYearlyVarianceIncome3.Clean = value; _tax4506TotalYearlyVarianceIncome3 = tax4506TotalYearlyVarianceIncome3;
                var tax4506TotalYearlyVarianceIncome4 = _tax4506TotalYearlyVarianceIncome4; tax4506TotalYearlyVarianceIncome4.Clean = value; _tax4506TotalYearlyVarianceIncome4 = tax4506TotalYearlyVarianceIncome4;
                var tax4506TotalYearlyVarianceJointIncome1 = _tax4506TotalYearlyVarianceJointIncome1; tax4506TotalYearlyVarianceJointIncome1.Clean = value; _tax4506TotalYearlyVarianceJointIncome1 = tax4506TotalYearlyVarianceJointIncome1;
                var tax4506TotalYearlyVarianceJointIncome2 = _tax4506TotalYearlyVarianceJointIncome2; tax4506TotalYearlyVarianceJointIncome2.Clean = value; _tax4506TotalYearlyVarianceJointIncome2 = tax4506TotalYearlyVarianceJointIncome2;
                var tax4506TotalYearlyVarianceJointIncome3 = _tax4506TotalYearlyVarianceJointIncome3; tax4506TotalYearlyVarianceJointIncome3.Clean = value; _tax4506TotalYearlyVarianceJointIncome3 = tax4506TotalYearlyVarianceJointIncome3;
                var tax4506TotalYearlyVarianceJointIncome4 = _tax4506TotalYearlyVarianceJointIncome4; tax4506TotalYearlyVarianceJointIncome4.Clean = value; _tax4506TotalYearlyVarianceJointIncome4 = tax4506TotalYearlyVarianceJointIncome4;
                var taxIdentificationIdentifier = _taxIdentificationIdentifier; taxIdentificationIdentifier.Clean = value; _taxIdentificationIdentifier = taxIdentificationIdentifier;
                var totalLiabilitiesBalanceAmount = _totalLiabilitiesBalanceAmount; totalLiabilitiesBalanceAmount.Clean = value; _totalLiabilitiesBalanceAmount = totalLiabilitiesBalanceAmount;
                var totalMonthlyIncomeAmount = _totalMonthlyIncomeAmount; totalMonthlyIncomeAmount.Clean = value; _totalMonthlyIncomeAmount = totalMonthlyIncomeAmount;
                var totalMonthlyIncomeMinusNetRentalAmount = _totalMonthlyIncomeMinusNetRentalAmount; totalMonthlyIncomeMinusNetRentalAmount.Clean = value; _totalMonthlyIncomeMinusNetRentalAmount = totalMonthlyIncomeMinusNetRentalAmount;
                var totalPresentHousingExpenseAmount = _totalPresentHousingExpenseAmount; totalPresentHousingExpenseAmount.Clean = value; _totalPresentHousingExpenseAmount = totalPresentHousingExpenseAmount;
                var transactionPurposeDescription = _transactionPurposeDescription; transactionPurposeDescription.Clean = value; _transactionPurposeDescription = transactionPurposeDescription;
                var transUnion120Days = _transUnion120Days; transUnion120Days.Clean = value; _transUnion120Days = transUnion120Days;
                var transUnion150Days = _transUnion150Days; transUnion150Days.Clean = value; _transUnion150Days = transUnion150Days;
                var transUnion30Days = _transUnion30Days; transUnion30Days.Clean = value; _transUnion30Days = transUnion30Days;
                var transUnion60Days = _transUnion60Days; transUnion60Days.Clean = value; _transUnion60Days = transUnion60Days;
                var transUnion90Days = _transUnion90Days; transUnion90Days.Clean = value; _transUnion90Days = transUnion90Days;
                var transUnionCreditScoreForDisclosure = _transUnionCreditScoreForDisclosure; transUnionCreditScoreForDisclosure.Clean = value; _transUnionCreditScoreForDisclosure = transUnionCreditScoreForDisclosure;
                var transUnionCreditScoreRanksPercent = _transUnionCreditScoreRanksPercent; transUnionCreditScoreRanksPercent.Clean = value; _transUnionCreditScoreRanksPercent = transUnionCreditScoreRanksPercent;
                var transUnionDatePulled = _transUnionDatePulled; transUnionDatePulled.Clean = value; _transUnionDatePulled = transUnionDatePulled;
                var transUnionFactorCode1 = _transUnionFactorCode1; transUnionFactorCode1.Clean = value; _transUnionFactorCode1 = transUnionFactorCode1;
                var transUnionFactorCode2 = _transUnionFactorCode2; transUnionFactorCode2.Clean = value; _transUnionFactorCode2 = transUnionFactorCode2;
                var transUnionFactorCode3 = _transUnionFactorCode3; transUnionFactorCode3.Clean = value; _transUnionFactorCode3 = transUnionFactorCode3;
                var transUnionFactorCode4 = _transUnionFactorCode4; transUnionFactorCode4.Clean = value; _transUnionFactorCode4 = transUnionFactorCode4;
                var transUnionFactorCode5 = _transUnionFactorCode5; transUnionFactorCode5.Clean = value; _transUnionFactorCode5 = transUnionFactorCode5;
                var transUnionKeyFactor1 = _transUnionKeyFactor1; transUnionKeyFactor1.Clean = value; _transUnionKeyFactor1 = transUnionKeyFactor1;
                var transUnionKeyFactor2 = _transUnionKeyFactor2; transUnionKeyFactor2.Clean = value; _transUnionKeyFactor2 = transUnionKeyFactor2;
                var transUnionKeyFactor3 = _transUnionKeyFactor3; transUnionKeyFactor3.Clean = value; _transUnionKeyFactor3 = transUnionKeyFactor3;
                var transUnionKeyFactor4 = _transUnionKeyFactor4; transUnionKeyFactor4.Clean = value; _transUnionKeyFactor4 = transUnionKeyFactor4;
                var transUnionKeyFactor5 = _transUnionKeyFactor5; transUnionKeyFactor5.Clean = value; _transUnionKeyFactor5 = transUnionKeyFactor5;
                var transUnionMaterialTermsCreditByScore = _transUnionMaterialTermsCreditByScore; transUnionMaterialTermsCreditByScore.Clean = value; _transUnionMaterialTermsCreditByScore = transUnionMaterialTermsCreditByScore;
                var transUnionScore = _transUnionScore; transUnionScore.Clean = value; _transUnionScore = transUnionScore;
                var userDefinedIncome = _userDefinedIncome; userDefinedIncome.Clean = value; _userDefinedIncome = userDefinedIncome;
                var vaFederalTaxAmount = _vaFederalTaxAmount; vaFederalTaxAmount.Clean = value; _vaFederalTaxAmount = vaFederalTaxAmount;
                var validDaysForConsentCount = _validDaysForConsentCount; validDaysForConsentCount.Clean = value; _validDaysForConsentCount = validDaysForConsentCount;
                var valueRepAndWarrantyAvailable = _valueRepAndWarrantyAvailable; valueRepAndWarrantyAvailable.Clean = value; _valueRepAndWarrantyAvailable = valueRepAndWarrantyAvailable;
                var valueRepAndWarrantyMessage = _valueRepAndWarrantyMessage; valueRepAndWarrantyMessage.Clean = value; _valueRepAndWarrantyMessage = valueRepAndWarrantyMessage;
                var vaNetTakeHomePayAmount = _vaNetTakeHomePayAmount; vaNetTakeHomePayAmount.Clean = value; _vaNetTakeHomePayAmount = vaNetTakeHomePayAmount;
                var vaOtherAmount = _vaOtherAmount; vaOtherAmount.Clean = value; _vaOtherAmount = vaOtherAmount;
                var vaOtherNetIncomeAmount = _vaOtherNetIncomeAmount; vaOtherNetIncomeAmount.Clean = value; _vaOtherNetIncomeAmount = vaOtherNetIncomeAmount;
                var vaRetirementAmount = _vaRetirementAmount; vaRetirementAmount.Clean = value; _vaRetirementAmount = vaRetirementAmount;
                var vaStateTaxAmount = _vaStateTaxAmount; vaStateTaxAmount.Clean = value; _vaStateTaxAmount = vaStateTaxAmount;
                var vaTotalIncomeDeductionsAmount = _vaTotalIncomeDeductionsAmount; vaTotalIncomeDeductionsAmount.Clean = value; _vaTotalIncomeDeductionsAmount = vaTotalIncomeDeductionsAmount;
                var vaTotalNetIncomeAmount = _vaTotalNetIncomeAmount; vaTotalNetIncomeAmount.Clean = value; _vaTotalNetIncomeAmount = vaTotalNetIncomeAmount;
                var vendor1 = _vendor1; vendor1.Clean = value; _vendor1 = vendor1;
                var vendor10 = _vendor10; vendor10.Clean = value; _vendor10 = vendor10;
                var vendor11 = _vendor11; vendor11.Clean = value; _vendor11 = vendor11;
                var vendor12 = _vendor12; vendor12.Clean = value; _vendor12 = vendor12;
                var vendor2 = _vendor2; vendor2.Clean = value; _vendor2 = vendor2;
                var vendor3 = _vendor3; vendor3.Clean = value; _vendor3 = vendor3;
                var vendor4 = _vendor4; vendor4.Clean = value; _vendor4 = vendor4;
                var vendor5 = _vendor5; vendor5.Clean = value; _vendor5 = vendor5;
                var vendor6 = _vendor6; vendor6.Clean = value; _vendor6 = vendor6;
                var vendor7 = _vendor7; vendor7.Clean = value; _vendor7 = vendor7;
                var vendor8 = _vendor8; vendor8.Clean = value; _vendor8 = vendor8;
                var vendor9 = _vendor9; vendor9.Clean = value; _vendor9 = vendor9;
                var vestingTrusteeOfType = _vestingTrusteeOfType; vestingTrusteeOfType.Clean = value; _vestingTrusteeOfType = vestingTrusteeOfType;
                var veteranIndicator = _veteranIndicator; veteranIndicator.Clean = value; _veteranIndicator = veteranIndicator;
                var workEmailAddress = _workEmailAddress; workEmailAddress.Clean = value; _workEmailAddress = workEmailAddress;
                var yearsofCreditOnFile = _yearsofCreditOnFile; yearsofCreditOnFile.Clean = value; _yearsofCreditOnFile = yearsofCreditOnFile;
                if (Application != null) Application.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Borrower()
        {
            Clean = true;
        }
    }
}