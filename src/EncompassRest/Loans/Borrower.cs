using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Borrower
    /// </summary>
    public sealed partial class Borrower : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _acountChekAssetId;
        /// <summary>
        /// Borrower AcountChekAssetId
        /// </summary>
        public string AcountChekAssetId { get => _acountChekAssetId; set => _acountChekAssetId = value; }
        private DirtyValue<int?> _ageAtApplicationYearsCount;
        /// <summary>
        /// Borrower AgeAtApplicationYearsCount
        /// </summary>
        public int? AgeAtApplicationYearsCount { get => _ageAtApplicationYearsCount; set => _ageAtApplicationYearsCount = value; }
        private DirtyValue<string> _aliasName;
        /// <summary>
        /// Borrower AliasName
        /// </summary>
        public string AliasName { get => _aliasName; set => _aliasName = value; }
        private DirtyValue<bool?> _alimonyChildSupportObligationIndicator;
        /// <summary>
        /// Borrower AlimonyChildSupportObligationIndicator
        /// </summary>
        public bool? AlimonyChildSupportObligationIndicator { get => _alimonyChildSupportObligationIndicator; set => _alimonyChildSupportObligationIndicator = value; }
        private DirtyValue<string> _altId;
        /// <summary>
        /// Borrower AltId
        /// </summary>
        public string AltId { get => _altId; set => _altId = value; }
        private DirtyValue<string> _applicantType;
        /// <summary>
        /// Borrower ApplicantType
        /// </summary>
        public string ApplicantType { get => _applicantType; set => _applicantType = value; }
        private DirtyValue<StringEnumValue<ApplicationTakenMethodType>> _applicationTakenMethodType;
        /// <summary>
        /// Borrower ApplicationTakenMethodType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"FaceToFace\":\"Face-to-Face Interview\"}")]
        public StringEnumValue<ApplicationTakenMethodType> ApplicationTakenMethodType { get => _applicationTakenMethodType; set => _applicationTakenMethodType = value; }
        private DirtyValue<string> _assetRepAndWarrantyMessage;
        /// <summary>
        /// Borrower AssetRepAndWarrantyMessage
        /// </summary>
        public string AssetRepAndWarrantyMessage { get => _assetRepAndWarrantyMessage; set => _assetRepAndWarrantyMessage = value; }
        private DirtyValue<bool?> _assetRepAndWarrantyReliefAvailable;
        /// <summary>
        /// Borrower AssetRepAndWarrantyReliefAvailable
        /// </summary>
        public bool? AssetRepAndWarrantyReliefAvailable { get => _assetRepAndWarrantyReliefAvailable; set => _assetRepAndWarrantyReliefAvailable = value; }
        private DirtyValue<bool?> _authorizedCreditReportIndicator;
        /// <summary>
        /// Borrower AuthorizedCreditReportIndicator
        /// </summary>
        public bool? AuthorizedCreditReportIndicator { get => _authorizedCreditReportIndicator; set => _authorizedCreditReportIndicator = value; }
        private DirtyValue<bool?> _authorizedToSignIndicator;
        /// <summary>
        /// Borrower AuthorizedToSignIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Authorized to Sign\"}")]
        public bool? AuthorizedToSignIndicator { get => _authorizedToSignIndicator; set => _authorizedToSignIndicator = value; }
        private DirtyValue<string> _bankAccountNumber;
        /// <summary>
        /// Borrower BankAccountNumber
        /// </summary>
        public string BankAccountNumber { get => _bankAccountNumber; set => _bankAccountNumber = value; }
        private DirtyValue<StringEnumValue<BankAccountType>> _bankAccountType;
        /// <summary>
        /// Borrower BankAccountType
        /// </summary>
        public StringEnumValue<BankAccountType> BankAccountType { get => _bankAccountType; set => _bankAccountType = value; }
        private DirtyValue<string> _bankContactAddress;
        /// <summary>
        /// Borrower BankContactAddress
        /// </summary>
        public string BankContactAddress { get => _bankContactAddress; set => _bankContactAddress = value; }
        private DirtyValue<string> _bankContactCity;
        /// <summary>
        /// Borrower BankContactCity
        /// </summary>
        public string BankContactCity { get => _bankContactCity; set => _bankContactCity = value; }
        private DirtyValue<string> _bankContactName;
        /// <summary>
        /// Borrower BankContactName
        /// </summary>
        public string BankContactName { get => _bankContactName; set => _bankContactName = value; }
        private DirtyValue<string> _bankContactPostalCode;
        /// <summary>
        /// Borrower BankContactPostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string BankContactPostalCode { get => _bankContactPostalCode; set => _bankContactPostalCode = value; }
        private DirtyValue<string> _bankContactState;
        /// <summary>
        /// Borrower BankContactState
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string BankContactState { get => _bankContactState; set => _bankContactState = value; }
        private DirtyValue<bool?> _bankruptcyIndicator;
        /// <summary>
        /// Borrower BankruptcyIndicator
        /// </summary>
        public bool? BankruptcyIndicator { get => _bankruptcyIndicator; set => _bankruptcyIndicator = value; }
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>> _bankruptcyStatus;
        /// <summary>
        /// Underwriting Bankruptcy Status [2570]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Bankruptcy Status")]
        public StringEnumValue<BankruptcyForeclosureStatus> BankruptcyStatus { get => _bankruptcyStatus; set => _bankruptcyStatus = value; }
        private DirtyValue<decimal?> _baseMonthlyIncomeAmount;
        /// <summary>
        /// Borrower BaseMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BaseMonthlyIncomeAmount { get => _baseMonthlyIncomeAmount; set => _baseMonthlyIncomeAmount = value; }
        private DirtyValue<DateTime?> _birthDate;
        /// <summary>
        /// Borrower BirthDate
        /// </summary>
        public DateTime? BirthDate { get => _birthDate; set => _birthDate = value; }
        private DirtyValue<bool?> _borrowedDownPaymentIndicator;
        /// <summary>
        /// Borrower BorrowedDownPaymentIndicator
        /// </summary>
        public bool? BorrowedDownPaymentIndicator { get => _borrowedDownPaymentIndicator; set => _borrowedDownPaymentIndicator = value; }
        private DirtyValue<DateTime?> _borrowerConsentRequestDate;
        /// <summary>
        /// Borrower BorrowerConsentRequestDate
        /// </summary>
        public DateTime? BorrowerConsentRequestDate { get => _borrowerConsentRequestDate; set => _borrowerConsentRequestDate = value; }
        private DirtyValue<int?> _borrowerIndex;
        /// <summary>
        /// Borrower BorrowerIndex
        /// </summary>
        public int? BorrowerIndex { get => _borrowerIndex; set => _borrowerIndex = value; }
        private DirtyValue<StringEnumValue<BorrowerType>> _borrowerType;
        /// <summary>
        /// Borrower BorrowerType
        /// </summary>
        public StringEnumValue<BorrowerType> BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<StringEnumValue<BorrowerType>> _borrowerTypeInSummary;
        /// <summary>
        /// Borrower BorrowerTypeInSummary
        /// </summary>
        public StringEnumValue<BorrowerType> BorrowerTypeInSummary { get => _borrowerTypeInSummary; set => _borrowerTypeInSummary = value; }
        private DirtyValue<string> _caivrsIdentifier;
        /// <summary>
        /// Borrower CaivrsIdentifier
        /// </summary>
        public string CaivrsIdentifier { get => _caivrsIdentifier; set => _caivrsIdentifier = value; }
        private DirtyValue<string> _citizenshipResidencyType;
        /// <summary>
        /// Borrower CitizenshipResidencyType
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CitizenshipResidencyType { get => _citizenshipResidencyType; set => _citizenshipResidencyType = value; }
        private DirtyValue<bool?> _coMakerEndorserOfNoteIndicator;
        /// <summary>
        /// Borrower CoMakerEndorserOfNoteIndicator
        /// </summary>
        public bool? CoMakerEndorserOfNoteIndicator { get => _coMakerEndorserOfNoteIndicator; set => _coMakerEndorserOfNoteIndicator = value; }
        private DirtyValue<string> _commentOfCreditReport;
        /// <summary>
        /// Credit Report Comment [4079]
        /// </summary>
        [LoanFieldProperty(Description = "Credit Report Comment")]
        public string CommentOfCreditReport { get => _commentOfCreditReport; set => _commentOfCreditReport = value; }
        private DirtyValue<bool?> _confirmedCRDIL;
        /// <summary>
        /// Borrower ConfirmedCRDIL
        /// </summary>
        public bool? ConfirmedCRDIL { get => _confirmedCRDIL; set => _confirmedCRDIL = value; }
        private DirtyValue<bool?> _confirmedCRFCEC;
        /// <summary>
        /// Borrower ConfirmedCRFCEC
        /// </summary>
        public bool? ConfirmedCRFCEC { get => _confirmedCRFCEC; set => _confirmedCRFCEC = value; }
        private DirtyValue<bool?> _confirmedCRFCIncorrect;
        /// <summary>
        /// Borrower ConfirmedCRFCIncorrect
        /// </summary>
        public bool? ConfirmedCRFCIncorrect { get => _confirmedCRFCIncorrect; set => _confirmedCRFCIncorrect = value; }
        private DirtyValue<bool?> _confirmedCRPFS;
        /// <summary>
        /// Borrower ConfirmedCRPFS
        /// </summary>
        public bool? ConfirmedCRPFS { get => _confirmedCRPFS; set => _confirmedCRPFS = value; }
        private DirtyValue<bool?> _confirmedOther;
        /// <summary>
        /// Borrower ConfirmedOther
        /// </summary>
        public bool? ConfirmedOther { get => _confirmedOther; set => _confirmedOther = value; }
        private DirtyValue<string> _confirmedOtherDescription;
        /// <summary>
        /// Borrower ConfirmedOtherDescription
        /// </summary>
        public string ConfirmedOtherDescription { get => _confirmedOtherDescription; set => _confirmedOtherDescription = value; }
        private EntityReference _contact;
        /// <summary>
        /// Borrower Contact
        /// </summary>
        public EntityReference Contact { get => _contact ?? (_contact = new EntityReference()); set => _contact = value; }
        private DirtyValue<bool?> _creditCounseling;
        /// <summary>
        /// Underwriting Credit Counseling [2566]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Credit Counseling")]
        public bool? CreditCounseling { get => _creditCounseling; set => _creditCounseling = value; }
        private DirtyValue<DateTime?> _creditReceivedDate;
        /// <summary>
        /// Underwriting Credit Received Date [2336]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Credit Received Date")]
        public DateTime? CreditReceivedDate { get => _creditReceivedDate; set => _creditReceivedDate = value; }
        private DirtyValue<StringEnumValue<CreditReportAuthorizationMethod>> _creditReportAuthorizationMethod;
        /// <summary>
        /// Borrower CreditReportAuthorizationMethod
        /// </summary>
        public StringEnumValue<CreditReportAuthorizationMethod> CreditReportAuthorizationMethod { get => _creditReportAuthorizationMethod; set => _creditReportAuthorizationMethod = value; }
        private DirtyValue<bool?> _creditScoreIndicator;
        /// <summary>
        /// Borrower CreditScoreIndicator
        /// </summary>
        public bool? CreditScoreIndicator { get => _creditScoreIndicator; set => _creditScoreIndicator = value; }
        private DirtyValue<DateTime?> _dateAuthorizedCreditReport;
        /// <summary>
        /// Borrower DateAuthorizedCreditReport
        /// </summary>
        public DateTime? DateAuthorizedCreditReport { get => _dateAuthorizedCreditReport; set => _dateAuthorizedCreditReport = value; }
        private DirtyValue<DateTime?> _dateOfBankruptcy;
        /// <summary>
        /// Underwriting Date of Bankruptcy [2340]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Date of Bankruptcy")]
        public DateTime? DateOfBankruptcy { get => _dateOfBankruptcy; set => _dateOfBankruptcy = value; }
        private DirtyValue<DateTime?> _dateOfForeclosure;
        /// <summary>
        /// Underwriting Date of Foreclosure [2341]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Date of Foreclosure")]
        public DateTime? DateOfForeclosure { get => _dateOfForeclosure; set => _dateOfForeclosure = value; }
        private DirtyValue<bool?> _declarationsJIndicator;
        /// <summary>
        /// Borrower DeclarationsJIndicator
        /// </summary>
        public bool? DeclarationsJIndicator { get => _declarationsJIndicator; set => _declarationsJIndicator = value; }
        private DirtyValue<bool?> _declarationsKIndicator;
        /// <summary>
        /// Borrower DeclarationsKIndicator
        /// </summary>
        public bool? DeclarationsKIndicator { get => _declarationsKIndicator; set => _declarationsKIndicator = value; }
        private DirtyValue<int?> _dependentCount;
        /// <summary>
        /// Borrower DependentCount
        /// </summary>
        public int? DependentCount { get => _dependentCount; set => _dependentCount = value; }
        private DirtyValue<string> _dependentsAgesDescription;
        /// <summary>
        /// Borrower DependentsAgesDescription
        /// </summary>
        public string DependentsAgesDescription { get => _dependentsAgesDescription; set => _dependentsAgesDescription = value; }
        private DirtyValue<bool?> _disabledIndicator;
        /// <summary>
        /// Borrower DisabledIndicator
        /// </summary>
        public bool? DisabledIndicator { get => _disabledIndicator; set => _disabledIndicator = value; }
        private DirtyValue<string> _emailAddressText;
        /// <summary>
        /// Borrower EmailAddressText
        /// </summary>
        public string EmailAddressText { get => _emailAddressText; set => _emailAddressText = value; }
        private DirtyValue<int?> _equifax120Days;
        /// <summary>
        /// Underwriting Equifax 120 Days [2335]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Equifax 120 Days")]
        public int? Equifax120Days { get => _equifax120Days; set => _equifax120Days = value; }
        private DirtyValue<int?> _equifax150Days;
        /// <summary>
        /// Underwriting Equifax 150 Days [2557]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Equifax 150 Days")]
        public int? Equifax150Days { get => _equifax150Days; set => _equifax150Days = value; }
        private DirtyValue<int?> _equifax30Days;
        /// <summary>
        /// Underwriting Equifax 30 Days [2332]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Equifax 30 Days")]
        public int? Equifax30Days { get => _equifax30Days; set => _equifax30Days = value; }
        private DirtyValue<int?> _equifax60Days;
        /// <summary>
        /// Underwriting Equifax 60 Days [2333]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Equifax 60 Days")]
        public int? Equifax60Days { get => _equifax60Days; set => _equifax60Days = value; }
        private DirtyValue<int?> _equifax90Days;
        /// <summary>
        /// Underwriting Equifax 90 Days [2334]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Equifax 90 Days")]
        public int? Equifax90Days { get => _equifax90Days; set => _equifax90Days = value; }
        private DirtyValue<bool?> _equifaxCreditScoreForDisclosure;
        /// <summary>
        /// Borrower EquifaxCreditScoreForDisclosure
        /// </summary>
        public bool? EquifaxCreditScoreForDisclosure { get => _equifaxCreditScoreForDisclosure; set => _equifaxCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _equifaxCreditScoreRanksPercent;
        /// <summary>
        /// Borrower EquifaxCreditScoreRanksPercent
        /// </summary>
        public int? EquifaxCreditScoreRanksPercent { get => _equifaxCreditScoreRanksPercent; set => _equifaxCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _equifaxDatePulled;
        /// <summary>
        /// Borrower EquifaxDatePulled
        /// </summary>
        public DateTime? EquifaxDatePulled { get => _equifaxDatePulled; set => _equifaxDatePulled = value; }
        private DirtyValue<string> _equifaxFactorCode1;
        /// <summary>
        /// Borrower EquifaxFactorCode1
        /// </summary>
        public string EquifaxFactorCode1 { get => _equifaxFactorCode1; set => _equifaxFactorCode1 = value; }
        private DirtyValue<string> _equifaxFactorCode2;
        /// <summary>
        /// Borrower EquifaxFactorCode2
        /// </summary>
        public string EquifaxFactorCode2 { get => _equifaxFactorCode2; set => _equifaxFactorCode2 = value; }
        private DirtyValue<string> _equifaxFactorCode3;
        /// <summary>
        /// Borrower EquifaxFactorCode3
        /// </summary>
        public string EquifaxFactorCode3 { get => _equifaxFactorCode3; set => _equifaxFactorCode3 = value; }
        private DirtyValue<string> _equifaxFactorCode4;
        /// <summary>
        /// Borrower EquifaxFactorCode4
        /// </summary>
        public string EquifaxFactorCode4 { get => _equifaxFactorCode4; set => _equifaxFactorCode4 = value; }
        private DirtyValue<string> _equifaxFactorCode5;
        /// <summary>
        /// Borrower EquifaxFactorCode5
        /// </summary>
        public string EquifaxFactorCode5 { get => _equifaxFactorCode5; set => _equifaxFactorCode5 = value; }
        private DirtyValue<string> _equifaxKeyFactor1;
        /// <summary>
        /// Borrower EquifaxKeyFactor1
        /// </summary>
        public string EquifaxKeyFactor1 { get => _equifaxKeyFactor1; set => _equifaxKeyFactor1 = value; }
        private DirtyValue<string> _equifaxKeyFactor2;
        /// <summary>
        /// Borrower EquifaxKeyFactor2
        /// </summary>
        public string EquifaxKeyFactor2 { get => _equifaxKeyFactor2; set => _equifaxKeyFactor2 = value; }
        private DirtyValue<string> _equifaxKeyFactor3;
        /// <summary>
        /// Borrower EquifaxKeyFactor3
        /// </summary>
        public string EquifaxKeyFactor3 { get => _equifaxKeyFactor3; set => _equifaxKeyFactor3 = value; }
        private DirtyValue<string> _equifaxKeyFactor4;
        /// <summary>
        /// Borrower EquifaxKeyFactor4
        /// </summary>
        public string EquifaxKeyFactor4 { get => _equifaxKeyFactor4; set => _equifaxKeyFactor4 = value; }
        private DirtyValue<string> _equifaxKeyFactor5;
        /// <summary>
        /// Borrower EquifaxKeyFactor5
        /// </summary>
        public string EquifaxKeyFactor5 { get => _equifaxKeyFactor5; set => _equifaxKeyFactor5 = value; }
        private DirtyValue<bool?> _equifaxMaterialTermsCreditByScore;
        /// <summary>
        /// Borrower EquifaxMaterialTermsCreditByScore
        /// </summary>
        public bool? EquifaxMaterialTermsCreditByScore { get => _equifaxMaterialTermsCreditByScore; set => _equifaxMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _equifaxScore;
        /// <summary>
        /// Borrower EquifaxScore
        /// </summary>
        public string EquifaxScore { get => _equifaxScore; set => _equifaxScore = value; }
        private DirtyValue<int?> _experian120Days;
        /// <summary>
        /// Underwriting Experian 120 Days [2327]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Experian 120 Days")]
        public int? Experian120Days { get => _experian120Days; set => _experian120Days = value; }
        private DirtyValue<int?> _experian150Days;
        /// <summary>
        /// Underwriting Experian 150 Days [2555]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Experian 150 Days")]
        public int? Experian150Days { get => _experian150Days; set => _experian150Days = value; }
        private DirtyValue<int?> _experian30Days;
        /// <summary>
        /// Underwriting Experian 30 Days [2324]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Experian 30 Days")]
        public int? Experian30Days { get => _experian30Days; set => _experian30Days = value; }
        private DirtyValue<int?> _experian60Days;
        /// <summary>
        /// Underwriting Experian 60 Days [2325]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Experian 60 Days")]
        public int? Experian60Days { get => _experian60Days; set => _experian60Days = value; }
        private DirtyValue<int?> _experian90Days;
        /// <summary>
        /// Underwriting Experian 90 Days [2326]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Experian 90 Days")]
        public int? Experian90Days { get => _experian90Days; set => _experian90Days = value; }
        private DirtyValue<string> _experianCreditScore;
        /// <summary>
        /// Borrower ExperianCreditScore
        /// </summary>
        public string ExperianCreditScore { get => _experianCreditScore; set => _experianCreditScore = value; }
        private DirtyValue<bool?> _experianCreditScoreForDisclosure;
        /// <summary>
        /// Borrower ExperianCreditScoreForDisclosure
        /// </summary>
        public bool? ExperianCreditScoreForDisclosure { get => _experianCreditScoreForDisclosure; set => _experianCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _experianCreditScoreRanksPercent;
        /// <summary>
        /// Borrower ExperianCreditScoreRanksPercent
        /// </summary>
        public int? ExperianCreditScoreRanksPercent { get => _experianCreditScoreRanksPercent; set => _experianCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _experianDatePulled;
        /// <summary>
        /// Borrower ExperianDatePulled
        /// </summary>
        public DateTime? ExperianDatePulled { get => _experianDatePulled; set => _experianDatePulled = value; }
        private DirtyValue<string> _experianFactorCode1;
        /// <summary>
        /// Borrower ExperianFactorCode1
        /// </summary>
        public string ExperianFactorCode1 { get => _experianFactorCode1; set => _experianFactorCode1 = value; }
        private DirtyValue<string> _experianFactorCode2;
        /// <summary>
        /// Borrower ExperianFactorCode2
        /// </summary>
        public string ExperianFactorCode2 { get => _experianFactorCode2; set => _experianFactorCode2 = value; }
        private DirtyValue<string> _experianFactorCode3;
        /// <summary>
        /// Borrower ExperianFactorCode3
        /// </summary>
        public string ExperianFactorCode3 { get => _experianFactorCode3; set => _experianFactorCode3 = value; }
        private DirtyValue<string> _experianFactorCode4;
        /// <summary>
        /// Borrower ExperianFactorCode4
        /// </summary>
        public string ExperianFactorCode4 { get => _experianFactorCode4; set => _experianFactorCode4 = value; }
        private DirtyValue<string> _experianFactorCode5;
        /// <summary>
        /// Borrower ExperianFactorCode5
        /// </summary>
        public string ExperianFactorCode5 { get => _experianFactorCode5; set => _experianFactorCode5 = value; }
        private DirtyValue<string> _experianKeyFactor1;
        /// <summary>
        /// Borrower ExperianKeyFactor1
        /// </summary>
        public string ExperianKeyFactor1 { get => _experianKeyFactor1; set => _experianKeyFactor1 = value; }
        private DirtyValue<string> _experianKeyFactor2;
        /// <summary>
        /// Borrower ExperianKeyFactor2
        /// </summary>
        public string ExperianKeyFactor2 { get => _experianKeyFactor2; set => _experianKeyFactor2 = value; }
        private DirtyValue<string> _experianKeyFactor3;
        /// <summary>
        /// Borrower ExperianKeyFactor3
        /// </summary>
        public string ExperianKeyFactor3 { get => _experianKeyFactor3; set => _experianKeyFactor3 = value; }
        private DirtyValue<string> _experianKeyFactor4;
        /// <summary>
        /// Borrower ExperianKeyFactor4
        /// </summary>
        public string ExperianKeyFactor4 { get => _experianKeyFactor4; set => _experianKeyFactor4 = value; }
        private DirtyValue<string> _experianKeyFactor5;
        /// <summary>
        /// Borrower ExperianKeyFactor5
        /// </summary>
        public string ExperianKeyFactor5 { get => _experianKeyFactor5; set => _experianKeyFactor5 = value; }
        private DirtyValue<bool?> _experianMaterialTermsCreditByScore;
        /// <summary>
        /// Borrower ExperianMaterialTermsCreditByScore
        /// </summary>
        public bool? ExperianMaterialTermsCreditByScore { get => _experianMaterialTermsCreditByScore; set => _experianMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _fannieFirstName;
        /// <summary>
        /// Borrower FannieFirstName
        /// </summary>
        public string FannieFirstName { get => _fannieFirstName; set => _fannieFirstName = value; }
        private DirtyValue<string> _fannieMiddleName;
        /// <summary>
        /// Borrower FannieMiddleName
        /// </summary>
        public string FannieMiddleName { get => _fannieMiddleName; set => _fannieMiddleName = value; }
        private DirtyValue<string> _firstName;
        /// <summary>
        /// Borrower FirstName
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        private DirtyValue<string> _firstNameWithMiddleName;
        /// <summary>
        /// Borrower FirstNameWithMiddleName
        /// </summary>
        public string FirstNameWithMiddleName { get => _firstNameWithMiddleName; set => _firstNameWithMiddleName = value; }
        private DirtyValue<bool?> _firstTimeHomeBuyer;
        /// <summary>
        /// Borrower FirstTimeHomeBuyer
        /// </summary>
        public bool? FirstTimeHomeBuyer { get => _firstTimeHomeBuyer; set => _firstTimeHomeBuyer = value; }
        private DirtyValue<DateTime?> _foreclosureSatisfied;
        /// <summary>
        /// Underwriting Foreclosure Satisfied [2571]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Foreclosure Satisfied")]
        public DateTime? ForeclosureSatisfied { get => _foreclosureSatisfied; set => _foreclosureSatisfied = value; }
        private DirtyValue<StringEnumValue<BankruptcyForeclosureStatus>> _foreclosureStatus;
        /// <summary>
        /// Underwriting Foreclosure Status [2572]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Foreclosure Status")]
        public StringEnumValue<BankruptcyForeclosureStatus> ForeclosureStatus { get => _foreclosureStatus; set => _foreclosureStatus = value; }
        private DirtyValue<string> _freddieMacPerson1;
        /// <summary>
        /// Borrower FreddieMacPerson1
        /// </summary>
        public string FreddieMacPerson1 { get => _freddieMacPerson1; set => _freddieMacPerson1 = value; }
        private DirtyValue<string> _freddieMacPerson2;
        /// <summary>
        /// Borrower FreddieMacPerson2
        /// </summary>
        public string FreddieMacPerson2 { get => _freddieMacPerson2; set => _freddieMacPerson2 = value; }
        private DirtyValue<string> _fullName;
        /// <summary>
        /// Borrower FullName
        /// </summary>
        public string FullName { get => _fullName; set => _fullName = value; }
        private DirtyValue<string> _fullNameWithSuffix;
        /// <summary>
        /// Borrower FullNameWithSuffix
        /// </summary>
        public string FullNameWithSuffix { get => _fullNameWithSuffix; set => _fullNameWithSuffix = value; }
        private DirtyValue<decimal?> _highestCreditLimit;
        /// <summary>
        /// Underwriting Highest Credit Limit [2567]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Highest Credit Limit")]
        public decimal? HighestCreditLimit { get => _highestCreditLimit; set => _highestCreditLimit = value; }
        private DirtyValue<string> _hmda2003OtherRaceNationalOriginDescription;
        /// <summary>
        /// Borrower Hmda2003OtherRaceNationalOriginDescription
        /// </summary>
        public string Hmda2003OtherRaceNationalOriginDescription { get => _hmda2003OtherRaceNationalOriginDescription; set => _hmda2003OtherRaceNationalOriginDescription = value; }
        private DirtyValue<StringEnumValue<Hmda2003RaceNationalOriginType>> _hmda2003RaceNationalOriginType;
        /// <summary>
        /// Borrower Hmda2003RaceNationalOriginType
        /// </summary>
        public StringEnumValue<Hmda2003RaceNationalOriginType> Hmda2003RaceNationalOriginType { get => _hmda2003RaceNationalOriginType; set => _hmda2003RaceNationalOriginType = value; }
        private DirtyValue<bool?> _hmdaAfricanAmericanIndicator;
        /// <summary>
        /// Borrower HmdaAfricanAmericanIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Black or African American\"}")]
        public bool? HmdaAfricanAmericanIndicator { get => _hmdaAfricanAmericanIndicator; set => _hmdaAfricanAmericanIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaAge>> _hmdaAge;
        /// <summary>
        /// Borrower HmdaAge
        /// </summary>
        public StringEnumValue<HmdaAge> HmdaAge { get => _hmdaAge; set => _hmdaAge = value; }
        private DirtyValue<bool?> _hmdaAmericanIndianIndicator;
        /// <summary>
        /// Borrower HmdaAmericanIndianIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"American Indian or Alaska Native\"}")]
        public bool? HmdaAmericanIndianIndicator { get => _hmdaAmericanIndianIndicator; set => _hmdaAmericanIndianIndicator = value; }
        private DirtyValue<string> _hmdaAmericanIndianTribe;
        /// <summary>
        /// Borrower HmdaAmericanIndianTribe
        /// </summary>
        public string HmdaAmericanIndianTribe { get => _hmdaAmericanIndianTribe; set => _hmdaAmericanIndianTribe = value; }
        private DirtyValue<bool?> _hmdaAsianIndianIndicator;
        /// <summary>
        /// Borrower HmdaAsianIndianIndicator
        /// </summary>
        public bool? HmdaAsianIndianIndicator { get => _hmdaAsianIndianIndicator; set => _hmdaAsianIndianIndicator = value; }
        private DirtyValue<bool?> _hmdaAsianIndicator;
        /// <summary>
        /// Borrower HmdaAsianIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Asian\"}")]
        public bool? HmdaAsianIndicator { get => _hmdaAsianIndicator; set => _hmdaAsianIndicator = value; }
        private DirtyValue<bool?> _hmdaAsianOtherRaceIndicator;
        /// <summary>
        /// Borrower HmdaAsianOtherRaceIndicator
        /// </summary>
        public bool? HmdaAsianOtherRaceIndicator { get => _hmdaAsianOtherRaceIndicator; set => _hmdaAsianOtherRaceIndicator = value; }
        private DirtyValue<bool?> _hmdaChineseIndicator;
        /// <summary>
        /// Borrower HmdaChineseIndicator
        /// </summary>
        public bool? HmdaChineseIndicator { get => _hmdaChineseIndicator; set => _hmdaChineseIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaCreditScoreForDecisionMaking>> _hmdaCreditScoreForDecisionMaking;
        /// <summary>
        /// Borrower HmdaCreditScoreForDecisionMaking
        /// </summary>
        public StringEnumValue<HmdaCreditScoreForDecisionMaking> HmdaCreditScoreForDecisionMaking { get => _hmdaCreditScoreForDecisionMaking; set => _hmdaCreditScoreForDecisionMaking = value; }
        private DirtyValue<StringEnumValue<HmdaCreditScoringModel>> _hmdaCreditScoringModel;
        /// <summary>
        /// Borrower HmdaCreditScoringModel
        /// </summary>
        public StringEnumValue<HmdaCreditScoringModel> HmdaCreditScoringModel { get => _hmdaCreditScoringModel; set => _hmdaCreditScoringModel = value; }
        private DirtyValue<bool?> _hmdaCubanIndicator;
        /// <summary>
        /// Borrower HmdaCubanIndicator
        /// </summary>
        public bool? HmdaCubanIndicator { get => _hmdaCubanIndicator; set => _hmdaCubanIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityDoNotWishIndicator;
        /// <summary>
        /// Borrower HmdaEthnicityDoNotWishIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"I do not wish to provide this information\"}")]
        public bool? HmdaEthnicityDoNotWishIndicator { get => _hmdaEthnicityDoNotWishIndicator; set => _hmdaEthnicityDoNotWishIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityHispanicLatinoIndicator;
        /// <summary>
        /// Borrower HmdaEthnicityHispanicLatinoIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Hispanic or Latino\"}")]
        public bool? HmdaEthnicityHispanicLatinoIndicator { get => _hmdaEthnicityHispanicLatinoIndicator; set => _hmdaEthnicityHispanicLatinoIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityInfoNotProvided;
        /// <summary>
        /// Borrower HmdaEthnicityInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Information Not Provided\"}")]
        public bool? HmdaEthnicityInfoNotProvided { get => _hmdaEthnicityInfoNotProvided; set => _hmdaEthnicityInfoNotProvided = value; }
        private DirtyValue<bool?> _hmdaEthnicityNotApplicableIndicator;
        /// <summary>
        /// Borrower HmdaEthnicityNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Not Applicable\"}")]
        public bool? HmdaEthnicityNotApplicableIndicator { get => _hmdaEthnicityNotApplicableIndicator; set => _hmdaEthnicityNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaEthnicityNotHispanicLatinoIndicator;
        /// <summary>
        /// Borrower HmdaEthnicityNotHispanicLatinoIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Not Hispanic or Latino\"}")]
        public bool? HmdaEthnicityNotHispanicLatinoIndicator { get => _hmdaEthnicityNotHispanicLatinoIndicator; set => _hmdaEthnicityNotHispanicLatinoIndicator = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField1;
        /// <summary>
        /// Borrower HmdaEthnicityReportedField1
        /// </summary>
        public string HmdaEthnicityReportedField1 { get => _hmdaEthnicityReportedField1; set => _hmdaEthnicityReportedField1 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField2;
        /// <summary>
        /// Borrower HmdaEthnicityReportedField2
        /// </summary>
        public string HmdaEthnicityReportedField2 { get => _hmdaEthnicityReportedField2; set => _hmdaEthnicityReportedField2 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField3;
        /// <summary>
        /// Borrower HmdaEthnicityReportedField3
        /// </summary>
        public string HmdaEthnicityReportedField3 { get => _hmdaEthnicityReportedField3; set => _hmdaEthnicityReportedField3 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField4;
        /// <summary>
        /// Borrower HmdaEthnicityReportedField4
        /// </summary>
        public string HmdaEthnicityReportedField4 { get => _hmdaEthnicityReportedField4; set => _hmdaEthnicityReportedField4 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedField5;
        /// <summary>
        /// Borrower HmdaEthnicityReportedField5
        /// </summary>
        public string HmdaEthnicityReportedField5 { get => _hmdaEthnicityReportedField5; set => _hmdaEthnicityReportedField5 = value; }
        private DirtyValue<string> _hmdaEthnicityReportedFields;
        /// <summary>
        /// Borrower HmdaEthnicityReportedFields
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HmdaEthnicityReportedFields { get => _hmdaEthnicityReportedFields; set => _hmdaEthnicityReportedFields = value; }
        private DirtyValue<StringEnumValue<HmdaEthnicityType>> _hmdaEthnicityType;
        /// <summary>
        /// Borrower HmdaEthnicityType
        /// </summary>
        public StringEnumValue<HmdaEthnicityType> HmdaEthnicityType { get => _hmdaEthnicityType; set => _hmdaEthnicityType = value; }
        private DirtyValue<bool?> _hmdaFilipinoIndicator;
        /// <summary>
        /// Borrower HmdaFilipinoIndicator
        /// </summary>
        public bool? HmdaFilipinoIndicator { get => _hmdaFilipinoIndicator; set => _hmdaFilipinoIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaGenderType>> _hmdaGenderType;
        /// <summary>
        /// Borrower HmdaGenderType
        /// </summary>
        public StringEnumValue<HmdaGenderType> HmdaGenderType { get => _hmdaGenderType; set => _hmdaGenderType = value; }
        private DirtyValue<bool?> _hmdaGendertypeDoNotWishIndicator;
        /// <summary>
        /// Borrower HmdaGendertypeDoNotWishIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"I do not wish to provide this information\"}")]
        public bool? HmdaGendertypeDoNotWishIndicator { get => _hmdaGendertypeDoNotWishIndicator; set => _hmdaGendertypeDoNotWishIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeFemaleIndicator;
        /// <summary>
        /// Borrower HmdaGendertypeFemaleIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Female\"}")]
        public bool? HmdaGendertypeFemaleIndicator { get => _hmdaGendertypeFemaleIndicator; set => _hmdaGendertypeFemaleIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeMaleIndicator;
        /// <summary>
        /// Borrower HmdaGendertypeMaleIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Male\"}")]
        public bool? HmdaGendertypeMaleIndicator { get => _hmdaGendertypeMaleIndicator; set => _hmdaGendertypeMaleIndicator = value; }
        private DirtyValue<bool?> _hmdaGendertypeNotApplicableIndicator;
        /// <summary>
        /// Borrower HmdaGendertypeNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Not Applicable\"}")]
        public bool? HmdaGendertypeNotApplicableIndicator { get => _hmdaGendertypeNotApplicableIndicator; set => _hmdaGendertypeNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaGuamanianOrChamorroIndicator;
        /// <summary>
        /// Borrower HmdaGuamanianOrChamorroIndicator
        /// </summary>
        public bool? HmdaGuamanianOrChamorroIndicator { get => _hmdaGuamanianOrChamorroIndicator; set => _hmdaGuamanianOrChamorroIndicator = value; }
        private DirtyValue<bool?> _hmdaHispanicLatinoOtherOriginIndicator;
        /// <summary>
        /// Borrower HmdaHispanicLatinoOtherOriginIndicator
        /// </summary>
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get => _hmdaHispanicLatinoOtherOriginIndicator; set => _hmdaHispanicLatinoOtherOriginIndicator = value; }
        private DirtyValue<bool?> _hmdaJapaneseIndicator;
        /// <summary>
        /// Borrower HmdaJapaneseIndicator
        /// </summary>
        public bool? HmdaJapaneseIndicator { get => _hmdaJapaneseIndicator; set => _hmdaJapaneseIndicator = value; }
        private DirtyValue<bool?> _hmdaKoreanIndicator;
        /// <summary>
        /// Borrower HmdaKoreanIndicator
        /// </summary>
        public bool? HmdaKoreanIndicator { get => _hmdaKoreanIndicator; set => _hmdaKoreanIndicator = value; }
        private DirtyValue<bool?> _hmdaMexicanIndicator;
        /// <summary>
        /// Borrower HmdaMexicanIndicator
        /// </summary>
        public bool? HmdaMexicanIndicator { get => _hmdaMexicanIndicator; set => _hmdaMexicanIndicator = value; }
        private DirtyValue<bool?> _hmdaNativeHawaiianIndicator;
        /// <summary>
        /// Borrower HmdaNativeHawaiianIndicator
        /// </summary>
        public bool? HmdaNativeHawaiianIndicator { get => _hmdaNativeHawaiianIndicator; set => _hmdaNativeHawaiianIndicator = value; }
        private DirtyValue<bool?> _hmdaNoCoApplicantIndicator;
        /// <summary>
        /// No Co-applicant Indicator [3840]
        /// </summary>
        [LoanFieldProperty(Description = "No Co-applicant Indicator", OptionsJson = "{\"true\":\"No Co-applicant\"}")]
        public bool? HmdaNoCoApplicantIndicator { get => _hmdaNoCoApplicantIndicator; set => _hmdaNoCoApplicantIndicator = value; }
        private DirtyValue<bool?> _hmdaNotApplicableIndicator;
        /// <summary>
        /// Borrower HmdaNotApplicableIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Not applicable\"}")]
        public bool? HmdaNotApplicableIndicator { get => _hmdaNotApplicableIndicator; set => _hmdaNotApplicableIndicator = value; }
        private DirtyValue<bool?> _hmdaNotProvidedIndicator;
        /// <summary>
        /// Borrower HmdaNotProvidedIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"I do not wish to provide this information\"}")]
        public bool? HmdaNotProvidedIndicator { get => _hmdaNotProvidedIndicator; set => _hmdaNotProvidedIndicator = value; }
        private DirtyValue<string> _hmdaOtherAsianRace;
        /// <summary>
        /// Borrower HmdaOtherAsianRace
        /// </summary>
        public string HmdaOtherAsianRace { get => _hmdaOtherAsianRace; set => _hmdaOtherAsianRace = value; }
        private DirtyValue<string> _hmdaOtherHispanicLatinoOrigin;
        /// <summary>
        /// Borrower HmdaOtherHispanicLatinoOrigin
        /// </summary>
        public string HmdaOtherHispanicLatinoOrigin { get => _hmdaOtherHispanicLatinoOrigin; set => _hmdaOtherHispanicLatinoOrigin = value; }
        private DirtyValue<string> _hmdaOtherPacificIslanderRace;
        /// <summary>
        /// Borrower HmdaOtherPacificIslanderRace
        /// </summary>
        public string HmdaOtherPacificIslanderRace { get => _hmdaOtherPacificIslanderRace; set => _hmdaOtherPacificIslanderRace = value; }
        private DirtyValue<string> _hmdaOtherScoringModel;
        /// <summary>
        /// Borrower HmdaOtherScoringModel
        /// </summary>
        public string HmdaOtherScoringModel { get => _hmdaOtherScoringModel; set => _hmdaOtherScoringModel = value; }
        private DirtyValue<bool?> _hmdaPacificIslanderIndicator;
        /// <summary>
        /// Borrower HmdaPacificIslanderIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Native Hawaiian or Other Pacific Islander\"}")]
        public bool? HmdaPacificIslanderIndicator { get => _hmdaPacificIslanderIndicator; set => _hmdaPacificIslanderIndicator = value; }
        private DirtyValue<bool?> _hmdaPacificIslanderOtherIndicator;
        /// <summary>
        /// Borrower HmdaPacificIslanderOtherIndicator
        /// </summary>
        public bool? HmdaPacificIslanderOtherIndicator { get => _hmdaPacificIslanderOtherIndicator; set => _hmdaPacificIslanderOtherIndicator = value; }
        private DirtyValue<bool?> _hmdaPuertoRicanIndicator;
        /// <summary>
        /// Borrower HmdaPuertoRicanIndicator
        /// </summary>
        public bool? HmdaPuertoRicanIndicator { get => _hmdaPuertoRicanIndicator; set => _hmdaPuertoRicanIndicator = value; }
        private DirtyValue<bool?> _hmdaRaceDoNotWishProvideIndicator;
        /// <summary>
        /// Borrower HmdaRaceDoNotWishProvideIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"I do not wish to provide this information\"}")]
        public bool? HmdaRaceDoNotWishProvideIndicator { get => _hmdaRaceDoNotWishProvideIndicator; set => _hmdaRaceDoNotWishProvideIndicator = value; }
        private DirtyValue<bool?> _hmdaRaceInfoNotProvided;
        /// <summary>
        /// Borrower HmdaRaceInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Information Not Provided\"}")]
        public bool? HmdaRaceInfoNotProvided { get => _hmdaRaceInfoNotProvided; set => _hmdaRaceInfoNotProvided = value; }
        private DirtyValue<string> _hmdaRaceReportedField1;
        /// <summary>
        /// Borrower HmdaRaceReportedField1
        /// </summary>
        public string HmdaRaceReportedField1 { get => _hmdaRaceReportedField1; set => _hmdaRaceReportedField1 = value; }
        private DirtyValue<string> _hmdaRaceReportedField2;
        /// <summary>
        /// Borrower HmdaRaceReportedField2
        /// </summary>
        public string HmdaRaceReportedField2 { get => _hmdaRaceReportedField2; set => _hmdaRaceReportedField2 = value; }
        private DirtyValue<string> _hmdaRaceReportedField3;
        /// <summary>
        /// Borrower HmdaRaceReportedField3
        /// </summary>
        public string HmdaRaceReportedField3 { get => _hmdaRaceReportedField3; set => _hmdaRaceReportedField3 = value; }
        private DirtyValue<string> _hmdaRaceReportedField4;
        /// <summary>
        /// Borrower HmdaRaceReportedField4
        /// </summary>
        public string HmdaRaceReportedField4 { get => _hmdaRaceReportedField4; set => _hmdaRaceReportedField4 = value; }
        private DirtyValue<string> _hmdaRaceReportedField5;
        /// <summary>
        /// Borrower HmdaRaceReportedField5
        /// </summary>
        public string HmdaRaceReportedField5 { get => _hmdaRaceReportedField5; set => _hmdaRaceReportedField5 = value; }
        private DirtyValue<string> _hmdaRaceReportedFields;
        /// <summary>
        /// Borrower HmdaRaceReportedFields
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string HmdaRaceReportedFields { get => _hmdaRaceReportedFields; set => _hmdaRaceReportedFields = value; }
        private DirtyValue<bool?> _hmdaRefusalIndicator;
        /// <summary>
        /// Borrower HmdaRefusalIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"I do not wish to furnish this info\"}")]
        public bool? HmdaRefusalIndicator { get => _hmdaRefusalIndicator; set => _hmdaRefusalIndicator = value; }
        private DirtyValue<bool?> _hmdaSamoanIndicator;
        /// <summary>
        /// Borrower HmdaSamoanIndicator
        /// </summary>
        public bool? HmdaSamoanIndicator { get => _hmdaSamoanIndicator; set => _hmdaSamoanIndicator = value; }
        private DirtyValue<bool?> _hmdaSexInfoNotProvided;
        /// <summary>
        /// Borrower HmdaSexInfoNotProvided
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Information Not Provided\"}")]
        public bool? HmdaSexInfoNotProvided { get => _hmdaSexInfoNotProvided; set => _hmdaSexInfoNotProvided = value; }
        private DirtyValue<bool?> _hmdaVietnameseIndicator;
        /// <summary>
        /// Borrower HmdaVietnameseIndicator
        /// </summary>
        public bool? HmdaVietnameseIndicator { get => _hmdaVietnameseIndicator; set => _hmdaVietnameseIndicator = value; }
        private DirtyValue<bool?> _hmdaWhiteIndicator;
        /// <summary>
        /// Borrower HmdaWhiteIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"White\"}")]
        public bool? HmdaWhiteIndicator { get => _hmdaWhiteIndicator; set => _hmdaWhiteIndicator = value; }
        private DirtyValue<bool?> _homeownerPastThreeYearsIndicator;
        /// <summary>
        /// Borrower HomeownerPastThreeYearsIndicator
        /// </summary>
        public bool? HomeownerPastThreeYearsIndicator { get => _homeownerPastThreeYearsIndicator; set => _homeownerPastThreeYearsIndicator = value; }
        private DirtyValue<string> _homePhoneNumber;
        /// <summary>
        /// Borrower HomePhoneNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string HomePhoneNumber { get => _homePhoneNumber; set => _homePhoneNumber = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Borrower Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _incomeRepAndWarrantyMessage;
        /// <summary>
        /// Borrower IncomeRepAndWarrantyMessage
        /// </summary>
        public string IncomeRepAndWarrantyMessage { get => _incomeRepAndWarrantyMessage; set => _incomeRepAndWarrantyMessage = value; }
        private DirtyValue<bool?> _incomeRepAndWarrantyReliefAvailable;
        /// <summary>
        /// Borrower IncomeRepAndWarrantyReliefAvailable
        /// </summary>
        public bool? IncomeRepAndWarrantyReliefAvailable { get => _incomeRepAndWarrantyReliefAvailable; set => _incomeRepAndWarrantyReliefAvailable = value; }
        private DirtyValue<bool?> _intentToOccupyIndicator;
        /// <summary>
        /// Borrower IntentToOccupyIndicator
        /// </summary>
        public bool? IntentToOccupyIndicator { get => _intentToOccupyIndicator; set => _intentToOccupyIndicator = value; }
        private DirtyValue<string> _intuitReportId;
        /// <summary>
        /// Borrower IntuitReportId
        /// </summary>
        public string IntuitReportId { get => _intuitReportId; set => _intuitReportId = value; }
        private DirtyValue<bool?> _isBaseIncomeAvailable;
        /// <summary>
        /// Borrower IsBaseIncomeAvailable
        /// </summary>
        public bool? IsBaseIncomeAvailable { get => _isBaseIncomeAvailable; set => _isBaseIncomeAvailable = value; }
        private DirtyValue<bool?> _isBonusAvailable;
        /// <summary>
        /// Borrower IsBonusAvailable
        /// </summary>
        public bool? IsBonusAvailable { get => _isBonusAvailable; set => _isBonusAvailable = value; }
        private DirtyValue<bool?> _isBorrower;
        /// <summary>
        /// Borrower IsBorrower
        /// </summary>
        public bool? IsBorrower { get => _isBorrower; set => _isBorrower = value; }
        private DirtyValue<bool?> _isCommissionAvailable;
        /// <summary>
        /// Borrower IsCommissionAvailable
        /// </summary>
        public bool? IsCommissionAvailable { get => _isCommissionAvailable; set => _isCommissionAvailable = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isEthnicityBasedOnVisual;
        /// <summary>
        /// Borrower IsEthnicityBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsEthnicityBasedOnVisual { get => _isEthnicityBasedOnVisual; set => _isEthnicityBasedOnVisual = value; }
        private DirtyValue<bool?> _isOvertimeAvailable;
        /// <summary>
        /// Borrower IsOvertimeAvailable
        /// </summary>
        public bool? IsOvertimeAvailable { get => _isOvertimeAvailable; set => _isOvertimeAvailable = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isRaceBasedOnVisual;
        /// <summary>
        /// Borrower IsRaceBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsRaceBasedOnVisual { get => _isRaceBasedOnVisual; set => _isRaceBasedOnVisual = value; }
        private DirtyValue<bool?> _isSelfEmployed;
        /// <summary>
        /// Borrower IsSelfEmployed
        /// </summary>
        public bool? IsSelfEmployed { get => _isSelfEmployed; set => _isSelfEmployed = value; }
        private DirtyValue<StringEnumValue<YNOrNA>> _isSexBasedOnVisual;
        /// <summary>
        /// Borrower IsSexBasedOnVisual
        /// </summary>
        public StringEnumValue<YNOrNA> IsSexBasedOnVisual { get => _isSexBasedOnVisual; set => _isSexBasedOnVisual = value; }
        private DirtyValue<bool?> _isSocialSecurityAvailable;
        /// <summary>
        /// Borrower IsSocialSecurityAvailable
        /// </summary>
        public bool? IsSocialSecurityAvailable { get => _isSocialSecurityAvailable; set => _isSocialSecurityAvailable = value; }
        private DirtyValue<string> _lastName;
        /// <summary>
        /// Borrower LastName
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }
        private DirtyValue<string> _lastNameWithSuffix;
        /// <summary>
        /// Borrower LastNameWithSuffix
        /// </summary>
        public string LastNameWithSuffix { get => _lastNameWithSuffix; set => _lastNameWithSuffix = value; }
        private DirtyValue<bool?> _loanForeclosureOrJudgementIndicator;
        /// <summary>
        /// Borrower LoanForeclosureOrJudgementIndicator
        /// </summary>
        public bool? LoanForeclosureOrJudgementIndicator { get => _loanForeclosureOrJudgementIndicator; set => _loanForeclosureOrJudgementIndicator = value; }
        private DirtyValue<string> _lpdGsa;
        /// <summary>
        /// Borrower LpdGsa
        /// </summary>
        public string LpdGsa { get => _lpdGsa; set => _lpdGsa = value; }
        private DirtyValue<bool?> _mailingAddressSameAsPresentIndicator;
        /// <summary>
        /// Borrower MailingAddressSameAsPresentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Same as present address\"}")]
        public bool? MailingAddressSameAsPresentIndicator { get => _mailingAddressSameAsPresentIndicator; set => _mailingAddressSameAsPresentIndicator = value; }
        private DirtyValue<StringEnumValue<MaritalStatusType>> _maritalStatusType;
        /// <summary>
        /// Borrower MaritalStatusType
        /// </summary>
        public StringEnumValue<MaritalStatusType> MaritalStatusType { get => _maritalStatusType; set => _maritalStatusType = value; }
        private DirtyValue<int?> _middleCreditScore;
        /// <summary>
        /// Borrower MiddleCreditScore
        /// </summary>
        public int? MiddleCreditScore { get => _middleCreditScore; set => _middleCreditScore = value; }
        private DirtyValue<string> _middleFicoScore;
        /// <summary>
        /// Borrower MiddleFicoScore
        /// </summary>
        public string MiddleFicoScore { get => _middleFicoScore; set => _middleFicoScore = value; }
        private DirtyValue<string> _middleName;
        /// <summary>
        /// Borrower MiddleName
        /// </summary>
        public string MiddleName { get => _middleName; set => _middleName = value; }
        private DirtyValue<string> _minFicoScore;
        /// <summary>
        /// Borrower MinFicoScore
        /// </summary>
        public string MinFicoScore { get => _minFicoScore; set => _minFicoScore = value; }
        private DirtyValue<string> _mobilePhone;
        /// <summary>
        /// Borrower MobilePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string MobilePhone { get => _mobilePhone; set => _mobilePhone = value; }
        private DirtyValue<bool?> _mortgageOnCredit;
        /// <summary>
        /// Underwriting Mortgage on Credit [2563]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgage on Credit")]
        public bool? MortgageOnCredit { get => _mortgageOnCredit; set => _mortgageOnCredit = value; }
        private DirtyValue<string> _nameToObtainLoanFromRHS;
        /// <summary>
        /// Borrower NameToObtainLoanFromRHS
        /// </summary>
        public string NameToObtainLoanFromRHS { get => _nameToObtainLoanFromRHS; set => _nameToObtainLoanFromRHS = value; }
        private DirtyValue<string> _nearestRelativeAddress;
        /// <summary>
        /// Borrower NearestRelativeAddress
        /// </summary>
        public string NearestRelativeAddress { get => _nearestRelativeAddress; set => _nearestRelativeAddress = value; }
        private DirtyValue<string> _nearestRelativeCity;
        /// <summary>
        /// Borrower NearestRelativeCity
        /// </summary>
        public string NearestRelativeCity { get => _nearestRelativeCity; set => _nearestRelativeCity = value; }
        private DirtyValue<string> _nearestRelativeName;
        /// <summary>
        /// Borrower NearestRelativeName
        /// </summary>
        public string NearestRelativeName { get => _nearestRelativeName; set => _nearestRelativeName = value; }
        private DirtyValue<string> _nearestRelativePhone;
        /// <summary>
        /// Borrower NearestRelativePhone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string NearestRelativePhone { get => _nearestRelativePhone; set => _nearestRelativePhone = value; }
        private DirtyValue<string> _nearestRelativePostalCode;
        /// <summary>
        /// Borrower NearestRelativePostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string NearestRelativePostalCode { get => _nearestRelativePostalCode; set => _nearestRelativePostalCode = value; }
        private DirtyValue<string> _nearestRelativeRelationship;
        /// <summary>
        /// Borrower NearestRelativeRelationship
        /// </summary>
        public string NearestRelativeRelationship { get => _nearestRelativeRelationship; set => _nearestRelativeRelationship = value; }
        private DirtyValue<string> _nearestRelativeState;
        /// <summary>
        /// Borrower NearestRelativeState
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE)]
        public string NearestRelativeState { get => _nearestRelativeState; set => _nearestRelativeState = value; }
        private DirtyValue<bool?> _no3rdPartyEmailIndicator;
        /// <summary>
        /// Borrower No3rdPartyEmailIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Borrower No Third-Party Email for HomePoints\"}")]
        public bool? No3rdPartyEmailIndicator { get => _no3rdPartyEmailIndicator; set => _no3rdPartyEmailIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantEthnicityIndicator;
        /// <summary>
        /// Co-Borr Race No Co Applicant [4188]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borr Race No Co Applicant", OptionsJson = "{\"true\":\"No co-applicant\"}")]
        public bool? NoCoApplicantEthnicityIndicator { get => _noCoApplicantEthnicityIndicator; set => _noCoApplicantEthnicityIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantIndicator;
        /// <summary>
        /// Co-Borr Race No Co Applicant [3174]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borr Race No Co Applicant", OptionsJson = "{\"true\":\"No co-applicant\"}")]
        public bool? NoCoApplicantIndicator { get => _noCoApplicantIndicator; set => _noCoApplicantIndicator = value; }
        private DirtyValue<bool?> _noCoApplicantSexIndicator;
        /// <summary>
        /// Co-Borr Race No Co Applicant [4189]
        /// </summary>
        [LoanFieldProperty(Description = "Co-Borr Race No Co Applicant", OptionsJson = "{\"true\":\"No co-applicant\"}")]
        public bool? NoCoApplicantSexIndicator { get => _noCoApplicantSexIndicator; set => _noCoApplicantSexIndicator = value; }
        private DirtyValue<int?> _numberofTradelines;
        /// <summary>
        /// Underwriting Number of Tradelines [2564]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Number of Tradelines")]
        public int? NumberofTradelines { get => _numberofTradelines; set => _numberofTradelines = value; }
        private DirtyValue<bool?> _obtainLoanFromRHSIndicator;
        /// <summary>
        /// Borrower ObtainLoanFromRHSIndicator
        /// </summary>
        public bool? ObtainLoanFromRHSIndicator { get => _obtainLoanFromRHSIndicator; set => _obtainLoanFromRHSIndicator = value; }
        private DirtyValue<StringEnumValue<OpenBankruptcy>> _openBankruptcy2;
        /// <summary>
        /// Underwriting Open Bankruptcy [2568]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Open Bankruptcy")]
        public StringEnumValue<OpenBankruptcy> OpenBankruptcy2 { get => _openBankruptcy2; set => _openBankruptcy2 = value; }
        private DirtyValue<decimal?> _otherMonthlyIncomeAmount;
        /// <summary>
        /// Borrower OtherMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherMonthlyIncomeAmount { get => _otherMonthlyIncomeAmount; set => _otherMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _otherSumAmount;
        /// <summary>
        /// Borrower OtherSumAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? OtherSumAmount { get => _otherSumAmount; set => _otherSumAmount = value; }
        private DirtyValue<bool?> _outstandingJudgementsIndicator;
        /// <summary>
        /// Borrower OutstandingJudgementsIndicator
        /// </summary>
        public bool? OutstandingJudgementsIndicator { get => _outstandingJudgementsIndicator; set => _outstandingJudgementsIndicator = value; }
        private DirtyValue<bool?> _partyToLawsuitIndicator;
        /// <summary>
        /// Borrower PartyToLawsuitIndicator
        /// </summary>
        public bool? PartyToLawsuitIndicator { get => _partyToLawsuitIndicator; set => _partyToLawsuitIndicator = value; }
        private DirtyValue<int?> _pass120Days;
        /// <summary>
        /// Underwriting Mortgage 120 Days [2561]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgage 120 Days")]
        public int? Pass120Days { get => _pass120Days; set => _pass120Days = value; }
        private DirtyValue<int?> _pass150Days;
        /// <summary>
        /// Underwriting Mortgage 150 Days [2562]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgage 150 Days")]
        public int? Pass150Days { get => _pass150Days; set => _pass150Days = value; }
        private DirtyValue<int?> _pass30Days;
        /// <summary>
        /// Underwriting Mortgage 30 Days [2558]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgage 30 Days")]
        public int? Pass30Days { get => _pass30Days; set => _pass30Days = value; }
        private DirtyValue<int?> _pass60Days;
        /// <summary>
        /// Underwriting Mortgaget 60 Days [2559]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgaget 60 Days")]
        public int? Pass60Days { get => _pass60Days; set => _pass60Days = value; }
        private DirtyValue<int?> _pass90Days;
        /// <summary>
        /// Underwriting Mortgage 90 Days [2560]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Mortgage 90 Days")]
        public int? Pass90Days { get => _pass90Days; set => _pass90Days = value; }
        private DirtyValue<string> _personFaxNumber;
        /// <summary>
        /// Borrower PersonFaxNumber
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string PersonFaxNumber { get => _personFaxNumber; set => _personFaxNumber = value; }
        private DirtyValue<decimal?> _personHoursPerWeek;
        /// <summary>
        /// Borrower PersonHoursPerWeek
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PersonHoursPerWeek { get => _personHoursPerWeek; set => _personHoursPerWeek = value; }
        private DirtyValue<decimal?> _personIncomeAmount;
        /// <summary>
        /// Borrower PersonIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PersonIncomeAmount { get => _personIncomeAmount; set => _personIncomeAmount = value; }
        private DirtyValue<string> _personIncomeFrequencyType;
        /// <summary>
        /// Borrower PersonIncomeFrequencyType
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PersonIncomeFrequencyType { get => _personIncomeFrequencyType; set => _personIncomeFrequencyType = value; }
        private DirtyValue<decimal?> _personMonthlyIncome;
        /// <summary>
        /// Borrower PersonMonthlyIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PersonMonthlyIncome { get => _personMonthlyIncome; set => _personMonthlyIncome = value; }
        private DirtyValue<bool?> _pIWAccepted;
        /// <summary>
        /// Borrower PIWAccepted
        /// </summary>
        public bool? PIWAccepted { get => _pIWAccepted; set => _pIWAccepted = value; }
        private DirtyValue<string> _pIWMessage;
        /// <summary>
        /// Borrower PIWMessage
        /// </summary>
        public string PIWMessage { get => _pIWMessage; set => _pIWMessage = value; }
        private DirtyValue<StringEnumValue<OccupancyIntent>> _poaOccupancyIntent;
        /// <summary>
        /// Borrower PoaOccupancyIntent
        /// </summary>
        public StringEnumValue<OccupancyIntent> PoaOccupancyIntent { get => _poaOccupancyIntent; set => _poaOccupancyIntent = value; }
        private DirtyValue<string> _poaSignatureText;
        /// <summary>
        /// Borrower PoaSignatureText
        /// </summary>
        public string PoaSignatureText { get => _poaSignatureText; set => _poaSignatureText = value; }
        private DirtyValue<decimal?> _positiveCashFlow;
        /// <summary>
        /// Borrower PositiveCashFlow
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PositiveCashFlow { get => _positiveCashFlow; set => _positiveCashFlow = value; }
        private DirtyValue<string> _powerOfAttorneyName;
        /// <summary>
        /// Borrower PowerOfAttorneyName
        /// </summary>
        public string PowerOfAttorneyName { get => _powerOfAttorneyName; set => _powerOfAttorneyName = value; }
        private DirtyValue<string> _powerOfAttorneyTitleDescription;
        /// <summary>
        /// Borrower PowerOfAttorneyTitleDescription
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PowerOfAttorneyTitleDescription { get => _powerOfAttorneyTitleDescription; set => _powerOfAttorneyTitleDescription = value; }
        private DirtyValue<bool?> _presentlyDelinquentIndicator;
        /// <summary>
        /// Borrower PresentlyDelinquentIndicator
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"true\":\"Have any past due obligations owed to/insured by any agency of the Federal Government\"}")]
        public bool? PresentlyDelinquentIndicator { get => _presentlyDelinquentIndicator; set => _presentlyDelinquentIndicator = value; }
        private DirtyValue<DateTime?> _priorBankruptcy2;
        /// <summary>
        /// Underwriting Prior Bankruptcy [2569]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Prior Bankruptcy")]
        public DateTime? PriorBankruptcy2 { get => _priorBankruptcy2; set => _priorBankruptcy2 = value; }
        private DirtyValue<bool?> _priorForeclosure;
        /// <summary>
        /// Underwriting Prior Foreclosure [2339]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Prior Foreclosure")]
        public bool? PriorForeclosure { get => _priorForeclosure; set => _priorForeclosure = value; }
        private DirtyValue<StringEnumValue<PriorPropertyTitleType>> _priorPropertyTitleType;
        /// <summary>
        /// Borrower PriorPropertyTitleType
        /// </summary>
        public StringEnumValue<PriorPropertyTitleType> PriorPropertyTitleType { get => _priorPropertyTitleType; set => _priorPropertyTitleType = value; }
        private DirtyValue<StringEnumValue<PriorPropertyUsageType>> _priorPropertyUsageType;
        /// <summary>
        /// Borrower PriorPropertyUsageType
        /// </summary>
        public StringEnumValue<PriorPropertyUsageType> PriorPropertyUsageType { get => _priorPropertyUsageType; set => _priorPropertyUsageType = value; }
        private DirtyValue<bool?> _propertyForeclosedPastSevenYearsIndicator;
        /// <summary>
        /// Borrower PropertyForeclosedPastSevenYearsIndicator
        /// </summary>
        public bool? PropertyForeclosedPastSevenYearsIndicator { get => _propertyForeclosedPastSevenYearsIndicator; set => _propertyForeclosedPastSevenYearsIndicator = value; }
        private DirtyValue<string> _relationshipDescription;
        /// <summary>
        /// Borrower RelationshipDescription
        /// </summary>
        public string RelationshipDescription { get => _relationshipDescription; set => _relationshipDescription = value; }
        private DirtyValue<bool?> _relationshipWithRDEmployeeIndicator;
        /// <summary>
        /// Borrower RelationshipWithRDEmployeeIndicator
        /// </summary>
        public bool? RelationshipWithRDEmployeeIndicator { get => _relationshipWithRDEmployeeIndicator; set => _relationshipWithRDEmployeeIndicator = value; }
        private DirtyValue<int?> _schoolingTermYears;
        /// <summary>
        /// Borrower SchoolingTermYears
        /// </summary>
        public int? SchoolingTermYears { get => _schoolingTermYears; set => _schoolingTermYears = value; }
        private DirtyValue<bool?> _sSA89BackgroundCheckIndicator;
        /// <summary>
        /// Borrower SSA89BackgroundCheckIndicator
        /// </summary>
        public bool? SSA89BackgroundCheckIndicator { get => _sSA89BackgroundCheckIndicator; set => _sSA89BackgroundCheckIndicator = value; }
        private DirtyValue<bool?> _sSA89BankingServiceIndicator;
        /// <summary>
        /// Borrower SSA89BankingServiceIndicator
        /// </summary>
        public bool? SSA89BankingServiceIndicator { get => _sSA89BankingServiceIndicator; set => _sSA89BankingServiceIndicator = value; }
        private DirtyValue<bool?> _sSA89CreditCheckIndicator;
        /// <summary>
        /// Borrower SSA89CreditCheckIndicator
        /// </summary>
        public bool? SSA89CreditCheckIndicator { get => _sSA89CreditCheckIndicator; set => _sSA89CreditCheckIndicator = value; }
        private DirtyValue<bool?> _sSA89LicenseRequirementIndicator;
        /// <summary>
        /// Borrower SSA89LicenseRequirementIndicator
        /// </summary>
        public bool? SSA89LicenseRequirementIndicator { get => _sSA89LicenseRequirementIndicator; set => _sSA89LicenseRequirementIndicator = value; }
        private DirtyValue<bool?> _sSA89MortgageServiceIndicator;
        /// <summary>
        /// Borrower SSA89MortgageServiceIndicator
        /// </summary>
        public bool? SSA89MortgageServiceIndicator { get => _sSA89MortgageServiceIndicator; set => _sSA89MortgageServiceIndicator = value; }
        private DirtyValue<bool?> _sSA89OtherIndicator;
        /// <summary>
        /// Borrower SSA89OtherIndicator
        /// </summary>
        public bool? SSA89OtherIndicator { get => _sSA89OtherIndicator; set => _sSA89OtherIndicator = value; }
        private DirtyValue<decimal?> _subtotalLiquidAssetsMinusGiftAmount;
        /// <summary>
        /// Assets Subtotal Liquid Assets [915]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Assets Subtotal Liquid Assets")]
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get => _subtotalLiquidAssetsMinusGiftAmount; set => _subtotalLiquidAssetsMinusGiftAmount = value; }
        private DirtyValue<string> _suffixToName;
        /// <summary>
        /// Borrower SuffixToName
        /// </summary>
        public string SuffixToName { get => _suffixToName; set => _suffixToName = value; }
        private DirtyValue<string> _tax4506LastInvestor;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Investor [TQL.X7]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Investor")]
        public string Tax4506LastInvestor { get => _tax4506LastInvestor; set => _tax4506LastInvestor = value; }
        private DirtyValue<string> _tax4506LastOrderNumber;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Order Number [TQL.X6]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Order Number")]
        public string Tax4506LastOrderNumber { get => _tax4506LastOrderNumber; set => _tax4506LastOrderNumber = value; }
        private DirtyValue<int?> _tax4506LastOrderYear1;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 1 [TQL.X8]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Year 1")]
        public int? Tax4506LastOrderYear1 { get => _tax4506LastOrderYear1; set => _tax4506LastOrderYear1 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear2;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 2 [TQL.X9]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Year 2")]
        public int? Tax4506LastOrderYear2 { get => _tax4506LastOrderYear2; set => _tax4506LastOrderYear2 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear3;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 3 [TQL.X10]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Year 3")]
        public int? Tax4506LastOrderYear3 { get => _tax4506LastOrderYear3; set => _tax4506LastOrderYear3 = value; }
        private DirtyValue<int?> _tax4506LastOrderYear4;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Year 4 [TQL.X11]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Year 4")]
        public int? Tax4506LastOrderYear4 { get => _tax4506LastOrderYear4; set => _tax4506LastOrderYear4 = value; }
        private DirtyValue<string> _tax4506LastProductsOrdered;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Products Ordered [TQL.X12]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Products Ordered")]
        public string Tax4506LastProductsOrdered { get => _tax4506LastProductsOrdered; set => _tax4506LastProductsOrdered = value; }
        private DirtyValue<string> _tax4506LastStatus;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Status [TQL.X5]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Status")]
        public string Tax4506LastStatus { get => _tax4506LastStatus; set => _tax4506LastStatus = value; }
        private DirtyValue<string> _tax4506LastTranscriptType;
        /// <summary>
        /// TQL - Borrower 4506T Orders - Last 4506T Transcript Type [TQL.X13]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Borrower 4506T Orders - Last 4506T Transcript Type")]
        public string Tax4506LastTranscriptType { get => _tax4506LastTranscriptType; set => _tax4506LastTranscriptType = value; }
        private DirtyValue<string> _tax4506LastUserIDWhoOrdered;
        /// <summary>
        /// TQL - Coborrower 4506T Orders - Last User ID of Person Who Ordered 4506T [TQL.X26]
        /// </summary>
        [LoanFieldProperty(Description = "TQL - Coborrower 4506T Orders - Last User ID of Person Who Ordered 4506T")]
        public string Tax4506LastUserIDWhoOrdered { get => _tax4506LastUserIDWhoOrdered; set => _tax4506LastUserIDWhoOrdered = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome1;
        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome1
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome1 { get => _tax4506TotalYearlyIncome1; set => _tax4506TotalYearlyIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome2;
        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome2 { get => _tax4506TotalYearlyIncome2; set => _tax4506TotalYearlyIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome3;
        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome3
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome3 { get => _tax4506TotalYearlyIncome3; set => _tax4506TotalYearlyIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyIncome4;
        /// <summary>
        /// Borrower Tax4506TotalYearlyIncome4
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyIncome4 { get => _tax4506TotalYearlyIncome4; set => _tax4506TotalYearlyIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome1;
        /// <summary>
        /// Income Year 1 Total Joint Income Borr and Co-Borrower [3327]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Year 1 Total Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyJointIncome1 { get => _tax4506TotalYearlyJointIncome1; set => _tax4506TotalYearlyJointIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome2;
        /// <summary>
        /// Income Year 2 Total Joint Income Borr and Co-Borrower [3328]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Year 2 Total Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyJointIncome2 { get => _tax4506TotalYearlyJointIncome2; set => _tax4506TotalYearlyJointIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome3;
        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 3 Total Joint Income Borr and Co-Borrower [TQL.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Coborrower 4506T Orders - Income Year 3 Total Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyJointIncome3 { get => _tax4506TotalYearlyJointIncome3; set => _tax4506TotalYearlyJointIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyJointIncome4;
        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 4 Total Joint Income Borr and Co-Borrower [TQL.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Coborrower 4506T Orders - Income Year 4 Total Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyJointIncome4 { get => _tax4506TotalYearlyJointIncome4; set => _tax4506TotalYearlyJointIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome1;
        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome1
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get => _tax4506TotalYearlyVarianceIncome1; set => _tax4506TotalYearlyVarianceIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome2;
        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome2
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get => _tax4506TotalYearlyVarianceIncome2; set => _tax4506TotalYearlyVarianceIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome3;
        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome3
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get => _tax4506TotalYearlyVarianceIncome3; set => _tax4506TotalYearlyVarianceIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceIncome4;
        /// <summary>
        /// Borrower Tax4506TotalYearlyVarianceIncome4
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get => _tax4506TotalYearlyVarianceIncome4; set => _tax4506TotalYearlyVarianceIncome4 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome1;
        /// <summary>
        /// Income Year 1 Total Variance Joint Income Borr and Co-Borrower [3329]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Year 1 Total Variance Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get => _tax4506TotalYearlyVarianceJointIncome1; set => _tax4506TotalYearlyVarianceJointIncome1 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome2;
        /// <summary>
        /// Income Year 2 Total Variance Joint Income Borr and Co-Borrower [3330]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Year 2 Total Variance Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get => _tax4506TotalYearlyVarianceJointIncome2; set => _tax4506TotalYearlyVarianceJointIncome2 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome3;
        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 3 Total Variance Joint Income Borr and Co-Borrower [TQL.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Coborrower 4506T Orders - Income Year 3 Total Variance Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get => _tax4506TotalYearlyVarianceJointIncome3; set => _tax4506TotalYearlyVarianceJointIncome3 = value; }
        private DirtyValue<decimal?> _tax4506TotalYearlyVarianceJointIncome4;
        /// <summary>
        /// TQL - Coborrower 4506T Orders - Income Year 4 Total Variance Joint Income Borr and Co-Borrower [TQL.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "TQL - Coborrower 4506T Orders - Income Year 4 Total Variance Joint Income Borr and Co-Borrower")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get => _tax4506TotalYearlyVarianceJointIncome4; set => _tax4506TotalYearlyVarianceJointIncome4 = value; }
        private DirtyValue<string> _taxIdentificationIdentifier;
        /// <summary>
        /// Borrower TaxIdentificationIdentifier
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.SSN)]
        public string TaxIdentificationIdentifier { get => _taxIdentificationIdentifier; set => _taxIdentificationIdentifier = value; }
        private DirtyValue<decimal?> _totalLiabilitiesBalanceAmount;
        /// <summary>
        /// Liabilities Total Liability Balance [733]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liabilities Total Liability Balance")]
        public decimal? TotalLiabilitiesBalanceAmount { get => _totalLiabilitiesBalanceAmount; set => _totalLiabilitiesBalanceAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyIncomeAmount;
        /// <summary>
        /// Borrower TotalMonthlyIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMonthlyIncomeAmount { get => _totalMonthlyIncomeAmount; set => _totalMonthlyIncomeAmount = value; }
        private DirtyValue<decimal?> _totalMonthlyIncomeMinusNetRentalAmount;
        /// <summary>
        /// Borrower TotalMonthlyIncomeMinusNetRentalAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get => _totalMonthlyIncomeMinusNetRentalAmount; set => _totalMonthlyIncomeMinusNetRentalAmount = value; }
        private DirtyValue<decimal?> _totalPresentHousingExpenseAmount;
        /// <summary>
        /// Expenses Present Total Housing [737]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Present Total Housing")]
        public decimal? TotalPresentHousingExpenseAmount { get => _totalPresentHousingExpenseAmount; set => _totalPresentHousingExpenseAmount = value; }
        private DirtyValue<string> _transactionPurposeDescription;
        /// <summary>
        /// Borrower TransactionPurposeDescription
        /// </summary>
        public string TransactionPurposeDescription { get => _transactionPurposeDescription; set => _transactionPurposeDescription = value; }
        private DirtyValue<int?> _transUnion120Days;
        /// <summary>
        /// Underwriting Trans Union 120 Days [2331]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Trans Union 120 Days")]
        public int? TransUnion120Days { get => _transUnion120Days; set => _transUnion120Days = value; }
        private DirtyValue<int?> _transUnion150Days;
        /// <summary>
        /// Underwriting Trans Union 150 Days [2556]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Trans Union 150 Days")]
        public int? TransUnion150Days { get => _transUnion150Days; set => _transUnion150Days = value; }
        private DirtyValue<int?> _transUnion30Days;
        /// <summary>
        /// Underwriting Trans Union 30 Days [2328]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Trans Union 30 Days")]
        public int? TransUnion30Days { get => _transUnion30Days; set => _transUnion30Days = value; }
        private DirtyValue<int?> _transUnion60Days;
        /// <summary>
        /// Underwriting Trans Union 60 Days [2329]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Trans Union 60 Days")]
        public int? TransUnion60Days { get => _transUnion60Days; set => _transUnion60Days = value; }
        private DirtyValue<int?> _transUnion90Days;
        /// <summary>
        /// Underwriting Trans Union 90 Days [2330]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Trans Union 90 Days")]
        public int? TransUnion90Days { get => _transUnion90Days; set => _transUnion90Days = value; }
        private DirtyValue<bool?> _transUnionCreditScoreForDisclosure;
        /// <summary>
        /// Borrower TransUnionCreditScoreForDisclosure
        /// </summary>
        public bool? TransUnionCreditScoreForDisclosure { get => _transUnionCreditScoreForDisclosure; set => _transUnionCreditScoreForDisclosure = value; }
        private DirtyValue<int?> _transUnionCreditScoreRanksPercent;
        /// <summary>
        /// Borrower TransUnionCreditScoreRanksPercent
        /// </summary>
        public int? TransUnionCreditScoreRanksPercent { get => _transUnionCreditScoreRanksPercent; set => _transUnionCreditScoreRanksPercent = value; }
        private DirtyValue<DateTime?> _transUnionDatePulled;
        /// <summary>
        /// Borrower TransUnionDatePulled
        /// </summary>
        public DateTime? TransUnionDatePulled { get => _transUnionDatePulled; set => _transUnionDatePulled = value; }
        private DirtyValue<string> _transUnionFactorCode1;
        /// <summary>
        /// Borrower TransUnionFactorCode1
        /// </summary>
        public string TransUnionFactorCode1 { get => _transUnionFactorCode1; set => _transUnionFactorCode1 = value; }
        private DirtyValue<string> _transUnionFactorCode2;
        /// <summary>
        /// Borrower TransUnionFactorCode2
        /// </summary>
        public string TransUnionFactorCode2 { get => _transUnionFactorCode2; set => _transUnionFactorCode2 = value; }
        private DirtyValue<string> _transUnionFactorCode3;
        /// <summary>
        /// Borrower TransUnionFactorCode3
        /// </summary>
        public string TransUnionFactorCode3 { get => _transUnionFactorCode3; set => _transUnionFactorCode3 = value; }
        private DirtyValue<string> _transUnionFactorCode4;
        /// <summary>
        /// Borrower TransUnionFactorCode4
        /// </summary>
        public string TransUnionFactorCode4 { get => _transUnionFactorCode4; set => _transUnionFactorCode4 = value; }
        private DirtyValue<string> _transUnionFactorCode5;
        /// <summary>
        /// Borrower TransUnionFactorCode5
        /// </summary>
        public string TransUnionFactorCode5 { get => _transUnionFactorCode5; set => _transUnionFactorCode5 = value; }
        private DirtyValue<string> _transUnionKeyFactor1;
        /// <summary>
        /// Borrower TransUnionKeyFactor1
        /// </summary>
        public string TransUnionKeyFactor1 { get => _transUnionKeyFactor1; set => _transUnionKeyFactor1 = value; }
        private DirtyValue<string> _transUnionKeyFactor2;
        /// <summary>
        /// Borrower TransUnionKeyFactor2
        /// </summary>
        public string TransUnionKeyFactor2 { get => _transUnionKeyFactor2; set => _transUnionKeyFactor2 = value; }
        private DirtyValue<string> _transUnionKeyFactor3;
        /// <summary>
        /// Borrower TransUnionKeyFactor3
        /// </summary>
        public string TransUnionKeyFactor3 { get => _transUnionKeyFactor3; set => _transUnionKeyFactor3 = value; }
        private DirtyValue<string> _transUnionKeyFactor4;
        /// <summary>
        /// Borrower TransUnionKeyFactor4
        /// </summary>
        public string TransUnionKeyFactor4 { get => _transUnionKeyFactor4; set => _transUnionKeyFactor4 = value; }
        private DirtyValue<string> _transUnionKeyFactor5;
        /// <summary>
        /// Borrower TransUnionKeyFactor5
        /// </summary>
        public string TransUnionKeyFactor5 { get => _transUnionKeyFactor5; set => _transUnionKeyFactor5 = value; }
        private DirtyValue<bool?> _transUnionMaterialTermsCreditByScore;
        /// <summary>
        /// Borrower TransUnionMaterialTermsCreditByScore
        /// </summary>
        public bool? TransUnionMaterialTermsCreditByScore { get => _transUnionMaterialTermsCreditByScore; set => _transUnionMaterialTermsCreditByScore = value; }
        private DirtyValue<string> _transUnionScore;
        /// <summary>
        /// Borrower TransUnionScore
        /// </summary>
        public string TransUnionScore { get => _transUnionScore; set => _transUnionScore = value; }
        private DirtyValue<decimal?> _userDefinedIncome;
        /// <summary>
        /// Borrower UserDefinedIncome
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UserDefinedIncome { get => _userDefinedIncome; set => _userDefinedIncome = value; }
        private DirtyValue<decimal?> _vaFederalTaxAmount;
        /// <summary>
        /// Borrower VaFederalTaxAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaFederalTaxAmount { get => _vaFederalTaxAmount; set => _vaFederalTaxAmount = value; }
        private DirtyValue<int?> _validDaysForConsentCount;
        /// <summary>
        /// Borrower ValidDaysForConsentCount
        /// </summary>
        public int? ValidDaysForConsentCount { get => _validDaysForConsentCount; set => _validDaysForConsentCount = value; }
        private DirtyValue<bool?> _valueRepAndWarrantyAvailable;
        /// <summary>
        /// Borrower ValueRepAndWarrantyAvailable
        /// </summary>
        public bool? ValueRepAndWarrantyAvailable { get => _valueRepAndWarrantyAvailable; set => _valueRepAndWarrantyAvailable = value; }
        private DirtyValue<string> _valueRepAndWarrantyMessage;
        /// <summary>
        /// Borrower ValueRepAndWarrantyMessage
        /// </summary>
        public string ValueRepAndWarrantyMessage { get => _valueRepAndWarrantyMessage; set => _valueRepAndWarrantyMessage = value; }
        private DirtyValue<decimal?> _vaNetTakeHomePayAmount;
        /// <summary>
        /// Borrower VaNetTakeHomePayAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaNetTakeHomePayAmount { get => _vaNetTakeHomePayAmount; set => _vaNetTakeHomePayAmount = value; }
        private DirtyValue<decimal?> _vaOtherAmount;
        /// <summary>
        /// Borrower VaOtherAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaOtherAmount { get => _vaOtherAmount; set => _vaOtherAmount = value; }
        private DirtyValue<decimal?> _vaOtherNetIncomeAmount;
        /// <summary>
        /// Borrower VaOtherNetIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaOtherNetIncomeAmount { get => _vaOtherNetIncomeAmount; set => _vaOtherNetIncomeAmount = value; }
        private DirtyValue<decimal?> _vaRetirementAmount;
        /// <summary>
        /// Borrower VaRetirementAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaRetirementAmount { get => _vaRetirementAmount; set => _vaRetirementAmount = value; }
        private DirtyValue<decimal?> _vaStateTaxAmount;
        /// <summary>
        /// Borrower VaStateTaxAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? VaStateTaxAmount { get => _vaStateTaxAmount; set => _vaStateTaxAmount = value; }
        private DirtyValue<decimal?> _vaTotalIncomeDeductionsAmount;
        /// <summary>
        /// Borrower VaTotalIncomeDeductionsAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaTotalIncomeDeductionsAmount { get => _vaTotalIncomeDeductionsAmount; set => _vaTotalIncomeDeductionsAmount = value; }
        private DirtyValue<decimal?> _vaTotalNetIncomeAmount;
        /// <summary>
        /// Borrower VaTotalNetIncomeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? VaTotalNetIncomeAmount { get => _vaTotalNetIncomeAmount; set => _vaTotalNetIncomeAmount = value; }
        private DirtyValue<string> _vendor1;
        /// <summary>
        /// Borrower Vendor1
        /// </summary>
        public string Vendor1 { get => _vendor1; set => _vendor1 = value; }
        private DirtyValue<string> _vendor10;
        /// <summary>
        /// Borrower Vendor10
        /// </summary>
        public string Vendor10 { get => _vendor10; set => _vendor10 = value; }
        private DirtyValue<string> _vendor11;
        /// <summary>
        /// Borrower Vendor11
        /// </summary>
        public string Vendor11 { get => _vendor11; set => _vendor11 = value; }
        private DirtyValue<string> _vendor12;
        /// <summary>
        /// Borrower Vendor12
        /// </summary>
        public string Vendor12 { get => _vendor12; set => _vendor12 = value; }
        private DirtyValue<string> _vendor13;
        /// <summary>
        /// GSE Vendor Provider Data - BankVOD (Bor,CoBor) [GSEVENDOR.X25]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - BankVOD (Bor,CoBor)")]
        public string Vendor13 { get => _vendor13; set => _vendor13 = value; }
        private DirtyValue<string> _vendor14;
        /// <summary>
        /// GSE Vendor Provider Data - LendSnap (Bor,CoBor) [GSEVENDOR.X26]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - LendSnap (Bor,CoBor)")]
        public string Vendor14 { get => _vendor14; set => _vendor14 = value; }
        private DirtyValue<string> _vendor15;
        /// <summary>
        /// GSE Vendor Provider Data - Quovo (Bor,CoBor) [GSEVENDOR.X27]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Quovo (Bor,CoBor)")]
        public string Vendor15 { get => _vendor15; set => _vendor15 = value; }
        private DirtyValue<string> _vendor16;
        /// <summary>
        /// GSE Vendor Provider Data - Roostify (Bor,CoBor) [GSEVENDOR.X28]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Roostify (Bor,CoBor)")]
        public string Vendor16 { get => _vendor16; set => _vendor16 = value; }
        private DirtyValue<string> _vendor17;
        /// <summary>
        /// GSE Vendor Provider Data - CoreLogic (VOE/VOI) (Bor,CoBor) [GSEVENDOR.X29]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - CoreLogic (VOE/VOI) (Bor,CoBor)")]
        public string Vendor17 { get => _vendor17; set => _vendor17 = value; }
        private DirtyValue<string> _vendor18;
        /// <summary>
        /// GSE Vendor Provider Data - Advanced Data Income Tax Verification (Bor,CoBor) [GSEVENDOR.X30]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Advanced Data Income Tax Verification (Bor,CoBor)")]
        public string Vendor18 { get => _vendor18; set => _vendor18 = value; }
        private DirtyValue<string> _vendor19;
        /// <summary>
        /// GSE Vendor Provider Data - Partners Credit (IncomeVerify) (Bor,CoBor) [GSEVENDOR.X31]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Partners Credit (IncomeVerify) (Bor,CoBor)")]
        public string Vendor19 { get => _vendor19; set => _vendor19 = value; }
        private DirtyValue<string> _vendor2;
        /// <summary>
        /// Borrower Vendor2
        /// </summary>
        public string Vendor2 { get => _vendor2; set => _vendor2 = value; }
        private DirtyValue<string> _vendor20;
        /// <summary>
        /// GSE Vendor Provider Data - Taxdoor 4506-T Service (Chronos) (Bor,CoBor) [GSEVENDOR.X32]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Taxdoor 4506-T Service (Chronos) (Bor,CoBor)")]
        public string Vendor20 { get => _vendor20; set => _vendor20 = value; }
        private DirtyValue<string> _vendor21;
        /// <summary>
        /// GSE Vendor Provider Data - ComplianceEase IRS Tax Transcript (Bor,CoBor) [GSEVENDOR.X33]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - ComplianceEase IRS Tax Transcript (Bor,CoBor)")]
        public string Vendor21 { get => _vendor21; set => _vendor21 = value; }
        private DirtyValue<string> _vendor22;
        /// <summary>
        /// GSE Vendor Provider Data - Private Eyes (4506-Transcripts.com) (Bor,CoBor) [GSEVENDOR.X34]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - Private Eyes (4506-Transcripts.com) (Bor,CoBor)")]
        public string Vendor22 { get => _vendor22; set => _vendor22 = value; }
        private DirtyValue<string> _vendor23;
        /// <summary>
        /// GSE Vendor Provider Data - BankVOD IRS (Bor,CoBor) [GSEVENDOR.X35]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - BankVOD IRS (Bor,CoBor)")]
        public string Vendor23 { get => _vendor23; set => _vendor23 = value; }
        private DirtyValue<string> _vendor24;
        /// <summary>
        /// GSE Vendor Provider Data - QuestSoft (Bor,CoBor) [GSEVENDOR.X36]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - QuestSoft (Bor,CoBor)")]
        public string Vendor24 { get => _vendor24; set => _vendor24 = value; }
        private DirtyValue<string> _vendor25;
        /// <summary>
        /// GSE Vendor Provider Data - GSEVENDOR.X37  [GSEVENDOR.X37]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - GSEVENDOR.X37 ")]
        public string Vendor25 { get => _vendor25; set => _vendor25 = value; }
        private DirtyValue<string> _vendor26;
        /// <summary>
        /// GSE Vendor Provider Data - GSEVENDOR.X38 [GSEVENDOR.X38]
        /// </summary>
        [LoanFieldProperty(Description = "GSE Vendor Provider Data - GSEVENDOR.X38")]
        public string Vendor26 { get => _vendor26; set => _vendor26 = value; }
        private DirtyValue<string> _vendor3;
        /// <summary>
        /// Borrower Vendor3
        /// </summary>
        public string Vendor3 { get => _vendor3; set => _vendor3 = value; }
        private DirtyValue<string> _vendor4;
        /// <summary>
        /// Borrower Vendor4
        /// </summary>
        public string Vendor4 { get => _vendor4; set => _vendor4 = value; }
        private DirtyValue<string> _vendor5;
        /// <summary>
        /// Borrower Vendor5
        /// </summary>
        public string Vendor5 { get => _vendor5; set => _vendor5 = value; }
        private DirtyValue<string> _vendor6;
        /// <summary>
        /// Borrower Vendor6
        /// </summary>
        public string Vendor6 { get => _vendor6; set => _vendor6 = value; }
        private DirtyValue<string> _vendor7;
        /// <summary>
        /// Borrower Vendor7
        /// </summary>
        public string Vendor7 { get => _vendor7; set => _vendor7 = value; }
        private DirtyValue<string> _vendor8;
        /// <summary>
        /// Borrower Vendor8
        /// </summary>
        public string Vendor8 { get => _vendor8; set => _vendor8 = value; }
        private DirtyValue<string> _vendor9;
        /// <summary>
        /// Borrower Vendor9
        /// </summary>
        public string Vendor9 { get => _vendor9; set => _vendor9 = value; }
        private DirtyValue<StringEnumValue<VestingTrusteeOfType>> _vestingTrusteeOfType;
        /// <summary>
        /// Borrower VestingTrusteeOfType
        /// </summary>
        public StringEnumValue<VestingTrusteeOfType> VestingTrusteeOfType { get => _vestingTrusteeOfType; set => _vestingTrusteeOfType = value; }
        private DirtyValue<bool?> _veteranIndicator;
        /// <summary>
        /// Borrower VeteranIndicator
        /// </summary>
        public bool? VeteranIndicator { get => _veteranIndicator; set => _veteranIndicator = value; }
        private DirtyValue<string> _workEmailAddress;
        /// <summary>
        /// Borrower WorkEmailAddress
        /// </summary>
        public string WorkEmailAddress { get => _workEmailAddress; set => _workEmailAddress = value; }
        private DirtyValue<int?> _yearsofCreditOnFile;
        /// <summary>
        /// Underwriting Years of Credit on File [2565]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Years of Credit on File")]
        public int? YearsofCreditOnFile { get => _yearsofCreditOnFile; set => _yearsofCreditOnFile = value; }
        internal override bool DirtyInternal
        {
            get => _acountChekAssetId.Dirty
                || _ageAtApplicationYearsCount.Dirty
                || _aliasName.Dirty
                || _alimonyChildSupportObligationIndicator.Dirty
                || _altId.Dirty
                || _applicantType.Dirty
                || _applicationTakenMethodType.Dirty
                || _assetRepAndWarrantyMessage.Dirty
                || _assetRepAndWarrantyReliefAvailable.Dirty
                || _authorizedCreditReportIndicator.Dirty
                || _authorizedToSignIndicator.Dirty
                || _bankAccountNumber.Dirty
                || _bankAccountType.Dirty
                || _bankContactAddress.Dirty
                || _bankContactCity.Dirty
                || _bankContactName.Dirty
                || _bankContactPostalCode.Dirty
                || _bankContactState.Dirty
                || _bankruptcyIndicator.Dirty
                || _bankruptcyStatus.Dirty
                || _baseMonthlyIncomeAmount.Dirty
                || _birthDate.Dirty
                || _borrowedDownPaymentIndicator.Dirty
                || _borrowerConsentRequestDate.Dirty
                || _borrowerIndex.Dirty
                || _borrowerType.Dirty
                || _borrowerTypeInSummary.Dirty
                || _caivrsIdentifier.Dirty
                || _citizenshipResidencyType.Dirty
                || _coMakerEndorserOfNoteIndicator.Dirty
                || _commentOfCreditReport.Dirty
                || _confirmedCRDIL.Dirty
                || _confirmedCRFCEC.Dirty
                || _confirmedCRFCIncorrect.Dirty
                || _confirmedCRPFS.Dirty
                || _confirmedOther.Dirty
                || _confirmedOtherDescription.Dirty
                || _creditCounseling.Dirty
                || _creditReceivedDate.Dirty
                || _creditReportAuthorizationMethod.Dirty
                || _creditScoreIndicator.Dirty
                || _dateAuthorizedCreditReport.Dirty
                || _dateOfBankruptcy.Dirty
                || _dateOfForeclosure.Dirty
                || _declarationsJIndicator.Dirty
                || _declarationsKIndicator.Dirty
                || _dependentCount.Dirty
                || _dependentsAgesDescription.Dirty
                || _disabledIndicator.Dirty
                || _emailAddressText.Dirty
                || _equifax120Days.Dirty
                || _equifax150Days.Dirty
                || _equifax30Days.Dirty
                || _equifax60Days.Dirty
                || _equifax90Days.Dirty
                || _equifaxCreditScoreForDisclosure.Dirty
                || _equifaxCreditScoreRanksPercent.Dirty
                || _equifaxDatePulled.Dirty
                || _equifaxFactorCode1.Dirty
                || _equifaxFactorCode2.Dirty
                || _equifaxFactorCode3.Dirty
                || _equifaxFactorCode4.Dirty
                || _equifaxFactorCode5.Dirty
                || _equifaxKeyFactor1.Dirty
                || _equifaxKeyFactor2.Dirty
                || _equifaxKeyFactor3.Dirty
                || _equifaxKeyFactor4.Dirty
                || _equifaxKeyFactor5.Dirty
                || _equifaxMaterialTermsCreditByScore.Dirty
                || _equifaxScore.Dirty
                || _experian120Days.Dirty
                || _experian150Days.Dirty
                || _experian30Days.Dirty
                || _experian60Days.Dirty
                || _experian90Days.Dirty
                || _experianCreditScore.Dirty
                || _experianCreditScoreForDisclosure.Dirty
                || _experianCreditScoreRanksPercent.Dirty
                || _experianDatePulled.Dirty
                || _experianFactorCode1.Dirty
                || _experianFactorCode2.Dirty
                || _experianFactorCode3.Dirty
                || _experianFactorCode4.Dirty
                || _experianFactorCode5.Dirty
                || _experianKeyFactor1.Dirty
                || _experianKeyFactor2.Dirty
                || _experianKeyFactor3.Dirty
                || _experianKeyFactor4.Dirty
                || _experianKeyFactor5.Dirty
                || _experianMaterialTermsCreditByScore.Dirty
                || _fannieFirstName.Dirty
                || _fannieMiddleName.Dirty
                || _firstName.Dirty
                || _firstNameWithMiddleName.Dirty
                || _firstTimeHomeBuyer.Dirty
                || _foreclosureSatisfied.Dirty
                || _foreclosureStatus.Dirty
                || _freddieMacPerson1.Dirty
                || _freddieMacPerson2.Dirty
                || _fullName.Dirty
                || _fullNameWithSuffix.Dirty
                || _highestCreditLimit.Dirty
                || _hmda2003OtherRaceNationalOriginDescription.Dirty
                || _hmda2003RaceNationalOriginType.Dirty
                || _hmdaAfricanAmericanIndicator.Dirty
                || _hmdaAge.Dirty
                || _hmdaAmericanIndianIndicator.Dirty
                || _hmdaAmericanIndianTribe.Dirty
                || _hmdaAsianIndianIndicator.Dirty
                || _hmdaAsianIndicator.Dirty
                || _hmdaAsianOtherRaceIndicator.Dirty
                || _hmdaChineseIndicator.Dirty
                || _hmdaCreditScoreForDecisionMaking.Dirty
                || _hmdaCreditScoringModel.Dirty
                || _hmdaCubanIndicator.Dirty
                || _hmdaEthnicityDoNotWishIndicator.Dirty
                || _hmdaEthnicityHispanicLatinoIndicator.Dirty
                || _hmdaEthnicityInfoNotProvided.Dirty
                || _hmdaEthnicityNotApplicableIndicator.Dirty
                || _hmdaEthnicityNotHispanicLatinoIndicator.Dirty
                || _hmdaEthnicityReportedField1.Dirty
                || _hmdaEthnicityReportedField2.Dirty
                || _hmdaEthnicityReportedField3.Dirty
                || _hmdaEthnicityReportedField4.Dirty
                || _hmdaEthnicityReportedField5.Dirty
                || _hmdaEthnicityReportedFields.Dirty
                || _hmdaEthnicityType.Dirty
                || _hmdaFilipinoIndicator.Dirty
                || _hmdaGenderType.Dirty
                || _hmdaGendertypeDoNotWishIndicator.Dirty
                || _hmdaGendertypeFemaleIndicator.Dirty
                || _hmdaGendertypeMaleIndicator.Dirty
                || _hmdaGendertypeNotApplicableIndicator.Dirty
                || _hmdaGuamanianOrChamorroIndicator.Dirty
                || _hmdaHispanicLatinoOtherOriginIndicator.Dirty
                || _hmdaJapaneseIndicator.Dirty
                || _hmdaKoreanIndicator.Dirty
                || _hmdaMexicanIndicator.Dirty
                || _hmdaNativeHawaiianIndicator.Dirty
                || _hmdaNoCoApplicantIndicator.Dirty
                || _hmdaNotApplicableIndicator.Dirty
                || _hmdaNotProvidedIndicator.Dirty
                || _hmdaOtherAsianRace.Dirty
                || _hmdaOtherHispanicLatinoOrigin.Dirty
                || _hmdaOtherPacificIslanderRace.Dirty
                || _hmdaOtherScoringModel.Dirty
                || _hmdaPacificIslanderIndicator.Dirty
                || _hmdaPacificIslanderOtherIndicator.Dirty
                || _hmdaPuertoRicanIndicator.Dirty
                || _hmdaRaceDoNotWishProvideIndicator.Dirty
                || _hmdaRaceInfoNotProvided.Dirty
                || _hmdaRaceReportedField1.Dirty
                || _hmdaRaceReportedField2.Dirty
                || _hmdaRaceReportedField3.Dirty
                || _hmdaRaceReportedField4.Dirty
                || _hmdaRaceReportedField5.Dirty
                || _hmdaRaceReportedFields.Dirty
                || _hmdaRefusalIndicator.Dirty
                || _hmdaSamoanIndicator.Dirty
                || _hmdaSexInfoNotProvided.Dirty
                || _hmdaVietnameseIndicator.Dirty
                || _hmdaWhiteIndicator.Dirty
                || _homeownerPastThreeYearsIndicator.Dirty
                || _homePhoneNumber.Dirty
                || _id.Dirty
                || _incomeRepAndWarrantyMessage.Dirty
                || _incomeRepAndWarrantyReliefAvailable.Dirty
                || _intentToOccupyIndicator.Dirty
                || _intuitReportId.Dirty
                || _isBaseIncomeAvailable.Dirty
                || _isBonusAvailable.Dirty
                || _isBorrower.Dirty
                || _isCommissionAvailable.Dirty
                || _isEthnicityBasedOnVisual.Dirty
                || _isOvertimeAvailable.Dirty
                || _isRaceBasedOnVisual.Dirty
                || _isSelfEmployed.Dirty
                || _isSexBasedOnVisual.Dirty
                || _isSocialSecurityAvailable.Dirty
                || _lastName.Dirty
                || _lastNameWithSuffix.Dirty
                || _loanForeclosureOrJudgementIndicator.Dirty
                || _lpdGsa.Dirty
                || _mailingAddressSameAsPresentIndicator.Dirty
                || _maritalStatusType.Dirty
                || _middleCreditScore.Dirty
                || _middleFicoScore.Dirty
                || _middleName.Dirty
                || _minFicoScore.Dirty
                || _mobilePhone.Dirty
                || _mortgageOnCredit.Dirty
                || _nameToObtainLoanFromRHS.Dirty
                || _nearestRelativeAddress.Dirty
                || _nearestRelativeCity.Dirty
                || _nearestRelativeName.Dirty
                || _nearestRelativePhone.Dirty
                || _nearestRelativePostalCode.Dirty
                || _nearestRelativeRelationship.Dirty
                || _nearestRelativeState.Dirty
                || _no3rdPartyEmailIndicator.Dirty
                || _noCoApplicantEthnicityIndicator.Dirty
                || _noCoApplicantIndicator.Dirty
                || _noCoApplicantSexIndicator.Dirty
                || _numberofTradelines.Dirty
                || _obtainLoanFromRHSIndicator.Dirty
                || _openBankruptcy2.Dirty
                || _otherMonthlyIncomeAmount.Dirty
                || _otherSumAmount.Dirty
                || _outstandingJudgementsIndicator.Dirty
                || _partyToLawsuitIndicator.Dirty
                || _pass120Days.Dirty
                || _pass150Days.Dirty
                || _pass30Days.Dirty
                || _pass60Days.Dirty
                || _pass90Days.Dirty
                || _personFaxNumber.Dirty
                || _personHoursPerWeek.Dirty
                || _personIncomeAmount.Dirty
                || _personIncomeFrequencyType.Dirty
                || _personMonthlyIncome.Dirty
                || _pIWAccepted.Dirty
                || _pIWMessage.Dirty
                || _poaOccupancyIntent.Dirty
                || _poaSignatureText.Dirty
                || _positiveCashFlow.Dirty
                || _powerOfAttorneyName.Dirty
                || _powerOfAttorneyTitleDescription.Dirty
                || _presentlyDelinquentIndicator.Dirty
                || _priorBankruptcy2.Dirty
                || _priorForeclosure.Dirty
                || _priorPropertyTitleType.Dirty
                || _priorPropertyUsageType.Dirty
                || _propertyForeclosedPastSevenYearsIndicator.Dirty
                || _relationshipDescription.Dirty
                || _relationshipWithRDEmployeeIndicator.Dirty
                || _schoolingTermYears.Dirty
                || _sSA89BackgroundCheckIndicator.Dirty
                || _sSA89BankingServiceIndicator.Dirty
                || _sSA89CreditCheckIndicator.Dirty
                || _sSA89LicenseRequirementIndicator.Dirty
                || _sSA89MortgageServiceIndicator.Dirty
                || _sSA89OtherIndicator.Dirty
                || _subtotalLiquidAssetsMinusGiftAmount.Dirty
                || _suffixToName.Dirty
                || _tax4506LastInvestor.Dirty
                || _tax4506LastOrderNumber.Dirty
                || _tax4506LastOrderYear1.Dirty
                || _tax4506LastOrderYear2.Dirty
                || _tax4506LastOrderYear3.Dirty
                || _tax4506LastOrderYear4.Dirty
                || _tax4506LastProductsOrdered.Dirty
                || _tax4506LastStatus.Dirty
                || _tax4506LastTranscriptType.Dirty
                || _tax4506LastUserIDWhoOrdered.Dirty
                || _tax4506TotalYearlyIncome1.Dirty
                || _tax4506TotalYearlyIncome2.Dirty
                || _tax4506TotalYearlyIncome3.Dirty
                || _tax4506TotalYearlyIncome4.Dirty
                || _tax4506TotalYearlyJointIncome1.Dirty
                || _tax4506TotalYearlyJointIncome2.Dirty
                || _tax4506TotalYearlyJointIncome3.Dirty
                || _tax4506TotalYearlyJointIncome4.Dirty
                || _tax4506TotalYearlyVarianceIncome1.Dirty
                || _tax4506TotalYearlyVarianceIncome2.Dirty
                || _tax4506TotalYearlyVarianceIncome3.Dirty
                || _tax4506TotalYearlyVarianceIncome4.Dirty
                || _tax4506TotalYearlyVarianceJointIncome1.Dirty
                || _tax4506TotalYearlyVarianceJointIncome2.Dirty
                || _tax4506TotalYearlyVarianceJointIncome3.Dirty
                || _tax4506TotalYearlyVarianceJointIncome4.Dirty
                || _taxIdentificationIdentifier.Dirty
                || _totalLiabilitiesBalanceAmount.Dirty
                || _totalMonthlyIncomeAmount.Dirty
                || _totalMonthlyIncomeMinusNetRentalAmount.Dirty
                || _totalPresentHousingExpenseAmount.Dirty
                || _transactionPurposeDescription.Dirty
                || _transUnion120Days.Dirty
                || _transUnion150Days.Dirty
                || _transUnion30Days.Dirty
                || _transUnion60Days.Dirty
                || _transUnion90Days.Dirty
                || _transUnionCreditScoreForDisclosure.Dirty
                || _transUnionCreditScoreRanksPercent.Dirty
                || _transUnionDatePulled.Dirty
                || _transUnionFactorCode1.Dirty
                || _transUnionFactorCode2.Dirty
                || _transUnionFactorCode3.Dirty
                || _transUnionFactorCode4.Dirty
                || _transUnionFactorCode5.Dirty
                || _transUnionKeyFactor1.Dirty
                || _transUnionKeyFactor2.Dirty
                || _transUnionKeyFactor3.Dirty
                || _transUnionKeyFactor4.Dirty
                || _transUnionKeyFactor5.Dirty
                || _transUnionMaterialTermsCreditByScore.Dirty
                || _transUnionScore.Dirty
                || _userDefinedIncome.Dirty
                || _vaFederalTaxAmount.Dirty
                || _validDaysForConsentCount.Dirty
                || _valueRepAndWarrantyAvailable.Dirty
                || _valueRepAndWarrantyMessage.Dirty
                || _vaNetTakeHomePayAmount.Dirty
                || _vaOtherAmount.Dirty
                || _vaOtherNetIncomeAmount.Dirty
                || _vaRetirementAmount.Dirty
                || _vaStateTaxAmount.Dirty
                || _vaTotalIncomeDeductionsAmount.Dirty
                || _vaTotalNetIncomeAmount.Dirty
                || _vendor1.Dirty
                || _vendor10.Dirty
                || _vendor11.Dirty
                || _vendor12.Dirty
                || _vendor13.Dirty
                || _vendor14.Dirty
                || _vendor15.Dirty
                || _vendor16.Dirty
                || _vendor17.Dirty
                || _vendor18.Dirty
                || _vendor19.Dirty
                || _vendor2.Dirty
                || _vendor20.Dirty
                || _vendor21.Dirty
                || _vendor22.Dirty
                || _vendor23.Dirty
                || _vendor24.Dirty
                || _vendor25.Dirty
                || _vendor26.Dirty
                || _vendor3.Dirty
                || _vendor4.Dirty
                || _vendor5.Dirty
                || _vendor6.Dirty
                || _vendor7.Dirty
                || _vendor8.Dirty
                || _vendor9.Dirty
                || _vestingTrusteeOfType.Dirty
                || _veteranIndicator.Dirty
                || _workEmailAddress.Dirty
                || _yearsofCreditOnFile.Dirty
                || _contact?.Dirty == true;
            set
            {
                _acountChekAssetId.Dirty = value;
                _ageAtApplicationYearsCount.Dirty = value;
                _aliasName.Dirty = value;
                _alimonyChildSupportObligationIndicator.Dirty = value;
                _altId.Dirty = value;
                _applicantType.Dirty = value;
                _applicationTakenMethodType.Dirty = value;
                _assetRepAndWarrantyMessage.Dirty = value;
                _assetRepAndWarrantyReliefAvailable.Dirty = value;
                _authorizedCreditReportIndicator.Dirty = value;
                _authorizedToSignIndicator.Dirty = value;
                _bankAccountNumber.Dirty = value;
                _bankAccountType.Dirty = value;
                _bankContactAddress.Dirty = value;
                _bankContactCity.Dirty = value;
                _bankContactName.Dirty = value;
                _bankContactPostalCode.Dirty = value;
                _bankContactState.Dirty = value;
                _bankruptcyIndicator.Dirty = value;
                _bankruptcyStatus.Dirty = value;
                _baseMonthlyIncomeAmount.Dirty = value;
                _birthDate.Dirty = value;
                _borrowedDownPaymentIndicator.Dirty = value;
                _borrowerConsentRequestDate.Dirty = value;
                _borrowerIndex.Dirty = value;
                _borrowerType.Dirty = value;
                _borrowerTypeInSummary.Dirty = value;
                _caivrsIdentifier.Dirty = value;
                _citizenshipResidencyType.Dirty = value;
                _coMakerEndorserOfNoteIndicator.Dirty = value;
                _commentOfCreditReport.Dirty = value;
                _confirmedCRDIL.Dirty = value;
                _confirmedCRFCEC.Dirty = value;
                _confirmedCRFCIncorrect.Dirty = value;
                _confirmedCRPFS.Dirty = value;
                _confirmedOther.Dirty = value;
                _confirmedOtherDescription.Dirty = value;
                _creditCounseling.Dirty = value;
                _creditReceivedDate.Dirty = value;
                _creditReportAuthorizationMethod.Dirty = value;
                _creditScoreIndicator.Dirty = value;
                _dateAuthorizedCreditReport.Dirty = value;
                _dateOfBankruptcy.Dirty = value;
                _dateOfForeclosure.Dirty = value;
                _declarationsJIndicator.Dirty = value;
                _declarationsKIndicator.Dirty = value;
                _dependentCount.Dirty = value;
                _dependentsAgesDescription.Dirty = value;
                _disabledIndicator.Dirty = value;
                _emailAddressText.Dirty = value;
                _equifax120Days.Dirty = value;
                _equifax150Days.Dirty = value;
                _equifax30Days.Dirty = value;
                _equifax60Days.Dirty = value;
                _equifax90Days.Dirty = value;
                _equifaxCreditScoreForDisclosure.Dirty = value;
                _equifaxCreditScoreRanksPercent.Dirty = value;
                _equifaxDatePulled.Dirty = value;
                _equifaxFactorCode1.Dirty = value;
                _equifaxFactorCode2.Dirty = value;
                _equifaxFactorCode3.Dirty = value;
                _equifaxFactorCode4.Dirty = value;
                _equifaxFactorCode5.Dirty = value;
                _equifaxKeyFactor1.Dirty = value;
                _equifaxKeyFactor2.Dirty = value;
                _equifaxKeyFactor3.Dirty = value;
                _equifaxKeyFactor4.Dirty = value;
                _equifaxKeyFactor5.Dirty = value;
                _equifaxMaterialTermsCreditByScore.Dirty = value;
                _equifaxScore.Dirty = value;
                _experian120Days.Dirty = value;
                _experian150Days.Dirty = value;
                _experian30Days.Dirty = value;
                _experian60Days.Dirty = value;
                _experian90Days.Dirty = value;
                _experianCreditScore.Dirty = value;
                _experianCreditScoreForDisclosure.Dirty = value;
                _experianCreditScoreRanksPercent.Dirty = value;
                _experianDatePulled.Dirty = value;
                _experianFactorCode1.Dirty = value;
                _experianFactorCode2.Dirty = value;
                _experianFactorCode3.Dirty = value;
                _experianFactorCode4.Dirty = value;
                _experianFactorCode5.Dirty = value;
                _experianKeyFactor1.Dirty = value;
                _experianKeyFactor2.Dirty = value;
                _experianKeyFactor3.Dirty = value;
                _experianKeyFactor4.Dirty = value;
                _experianKeyFactor5.Dirty = value;
                _experianMaterialTermsCreditByScore.Dirty = value;
                _fannieFirstName.Dirty = value;
                _fannieMiddleName.Dirty = value;
                _firstName.Dirty = value;
                _firstNameWithMiddleName.Dirty = value;
                _firstTimeHomeBuyer.Dirty = value;
                _foreclosureSatisfied.Dirty = value;
                _foreclosureStatus.Dirty = value;
                _freddieMacPerson1.Dirty = value;
                _freddieMacPerson2.Dirty = value;
                _fullName.Dirty = value;
                _fullNameWithSuffix.Dirty = value;
                _highestCreditLimit.Dirty = value;
                _hmda2003OtherRaceNationalOriginDescription.Dirty = value;
                _hmda2003RaceNationalOriginType.Dirty = value;
                _hmdaAfricanAmericanIndicator.Dirty = value;
                _hmdaAge.Dirty = value;
                _hmdaAmericanIndianIndicator.Dirty = value;
                _hmdaAmericanIndianTribe.Dirty = value;
                _hmdaAsianIndianIndicator.Dirty = value;
                _hmdaAsianIndicator.Dirty = value;
                _hmdaAsianOtherRaceIndicator.Dirty = value;
                _hmdaChineseIndicator.Dirty = value;
                _hmdaCreditScoreForDecisionMaking.Dirty = value;
                _hmdaCreditScoringModel.Dirty = value;
                _hmdaCubanIndicator.Dirty = value;
                _hmdaEthnicityDoNotWishIndicator.Dirty = value;
                _hmdaEthnicityHispanicLatinoIndicator.Dirty = value;
                _hmdaEthnicityInfoNotProvided.Dirty = value;
                _hmdaEthnicityNotApplicableIndicator.Dirty = value;
                _hmdaEthnicityNotHispanicLatinoIndicator.Dirty = value;
                _hmdaEthnicityReportedField1.Dirty = value;
                _hmdaEthnicityReportedField2.Dirty = value;
                _hmdaEthnicityReportedField3.Dirty = value;
                _hmdaEthnicityReportedField4.Dirty = value;
                _hmdaEthnicityReportedField5.Dirty = value;
                _hmdaEthnicityReportedFields.Dirty = value;
                _hmdaEthnicityType.Dirty = value;
                _hmdaFilipinoIndicator.Dirty = value;
                _hmdaGenderType.Dirty = value;
                _hmdaGendertypeDoNotWishIndicator.Dirty = value;
                _hmdaGendertypeFemaleIndicator.Dirty = value;
                _hmdaGendertypeMaleIndicator.Dirty = value;
                _hmdaGendertypeNotApplicableIndicator.Dirty = value;
                _hmdaGuamanianOrChamorroIndicator.Dirty = value;
                _hmdaHispanicLatinoOtherOriginIndicator.Dirty = value;
                _hmdaJapaneseIndicator.Dirty = value;
                _hmdaKoreanIndicator.Dirty = value;
                _hmdaMexicanIndicator.Dirty = value;
                _hmdaNativeHawaiianIndicator.Dirty = value;
                _hmdaNoCoApplicantIndicator.Dirty = value;
                _hmdaNotApplicableIndicator.Dirty = value;
                _hmdaNotProvidedIndicator.Dirty = value;
                _hmdaOtherAsianRace.Dirty = value;
                _hmdaOtherHispanicLatinoOrigin.Dirty = value;
                _hmdaOtherPacificIslanderRace.Dirty = value;
                _hmdaOtherScoringModel.Dirty = value;
                _hmdaPacificIslanderIndicator.Dirty = value;
                _hmdaPacificIslanderOtherIndicator.Dirty = value;
                _hmdaPuertoRicanIndicator.Dirty = value;
                _hmdaRaceDoNotWishProvideIndicator.Dirty = value;
                _hmdaRaceInfoNotProvided.Dirty = value;
                _hmdaRaceReportedField1.Dirty = value;
                _hmdaRaceReportedField2.Dirty = value;
                _hmdaRaceReportedField3.Dirty = value;
                _hmdaRaceReportedField4.Dirty = value;
                _hmdaRaceReportedField5.Dirty = value;
                _hmdaRaceReportedFields.Dirty = value;
                _hmdaRefusalIndicator.Dirty = value;
                _hmdaSamoanIndicator.Dirty = value;
                _hmdaSexInfoNotProvided.Dirty = value;
                _hmdaVietnameseIndicator.Dirty = value;
                _hmdaWhiteIndicator.Dirty = value;
                _homeownerPastThreeYearsIndicator.Dirty = value;
                _homePhoneNumber.Dirty = value;
                _id.Dirty = value;
                _incomeRepAndWarrantyMessage.Dirty = value;
                _incomeRepAndWarrantyReliefAvailable.Dirty = value;
                _intentToOccupyIndicator.Dirty = value;
                _intuitReportId.Dirty = value;
                _isBaseIncomeAvailable.Dirty = value;
                _isBonusAvailable.Dirty = value;
                _isBorrower.Dirty = value;
                _isCommissionAvailable.Dirty = value;
                _isEthnicityBasedOnVisual.Dirty = value;
                _isOvertimeAvailable.Dirty = value;
                _isRaceBasedOnVisual.Dirty = value;
                _isSelfEmployed.Dirty = value;
                _isSexBasedOnVisual.Dirty = value;
                _isSocialSecurityAvailable.Dirty = value;
                _lastName.Dirty = value;
                _lastNameWithSuffix.Dirty = value;
                _loanForeclosureOrJudgementIndicator.Dirty = value;
                _lpdGsa.Dirty = value;
                _mailingAddressSameAsPresentIndicator.Dirty = value;
                _maritalStatusType.Dirty = value;
                _middleCreditScore.Dirty = value;
                _middleFicoScore.Dirty = value;
                _middleName.Dirty = value;
                _minFicoScore.Dirty = value;
                _mobilePhone.Dirty = value;
                _mortgageOnCredit.Dirty = value;
                _nameToObtainLoanFromRHS.Dirty = value;
                _nearestRelativeAddress.Dirty = value;
                _nearestRelativeCity.Dirty = value;
                _nearestRelativeName.Dirty = value;
                _nearestRelativePhone.Dirty = value;
                _nearestRelativePostalCode.Dirty = value;
                _nearestRelativeRelationship.Dirty = value;
                _nearestRelativeState.Dirty = value;
                _no3rdPartyEmailIndicator.Dirty = value;
                _noCoApplicantEthnicityIndicator.Dirty = value;
                _noCoApplicantIndicator.Dirty = value;
                _noCoApplicantSexIndicator.Dirty = value;
                _numberofTradelines.Dirty = value;
                _obtainLoanFromRHSIndicator.Dirty = value;
                _openBankruptcy2.Dirty = value;
                _otherMonthlyIncomeAmount.Dirty = value;
                _otherSumAmount.Dirty = value;
                _outstandingJudgementsIndicator.Dirty = value;
                _partyToLawsuitIndicator.Dirty = value;
                _pass120Days.Dirty = value;
                _pass150Days.Dirty = value;
                _pass30Days.Dirty = value;
                _pass60Days.Dirty = value;
                _pass90Days.Dirty = value;
                _personFaxNumber.Dirty = value;
                _personHoursPerWeek.Dirty = value;
                _personIncomeAmount.Dirty = value;
                _personIncomeFrequencyType.Dirty = value;
                _personMonthlyIncome.Dirty = value;
                _pIWAccepted.Dirty = value;
                _pIWMessage.Dirty = value;
                _poaOccupancyIntent.Dirty = value;
                _poaSignatureText.Dirty = value;
                _positiveCashFlow.Dirty = value;
                _powerOfAttorneyName.Dirty = value;
                _powerOfAttorneyTitleDescription.Dirty = value;
                _presentlyDelinquentIndicator.Dirty = value;
                _priorBankruptcy2.Dirty = value;
                _priorForeclosure.Dirty = value;
                _priorPropertyTitleType.Dirty = value;
                _priorPropertyUsageType.Dirty = value;
                _propertyForeclosedPastSevenYearsIndicator.Dirty = value;
                _relationshipDescription.Dirty = value;
                _relationshipWithRDEmployeeIndicator.Dirty = value;
                _schoolingTermYears.Dirty = value;
                _sSA89BackgroundCheckIndicator.Dirty = value;
                _sSA89BankingServiceIndicator.Dirty = value;
                _sSA89CreditCheckIndicator.Dirty = value;
                _sSA89LicenseRequirementIndicator.Dirty = value;
                _sSA89MortgageServiceIndicator.Dirty = value;
                _sSA89OtherIndicator.Dirty = value;
                _subtotalLiquidAssetsMinusGiftAmount.Dirty = value;
                _suffixToName.Dirty = value;
                _tax4506LastInvestor.Dirty = value;
                _tax4506LastOrderNumber.Dirty = value;
                _tax4506LastOrderYear1.Dirty = value;
                _tax4506LastOrderYear2.Dirty = value;
                _tax4506LastOrderYear3.Dirty = value;
                _tax4506LastOrderYear4.Dirty = value;
                _tax4506LastProductsOrdered.Dirty = value;
                _tax4506LastStatus.Dirty = value;
                _tax4506LastTranscriptType.Dirty = value;
                _tax4506LastUserIDWhoOrdered.Dirty = value;
                _tax4506TotalYearlyIncome1.Dirty = value;
                _tax4506TotalYearlyIncome2.Dirty = value;
                _tax4506TotalYearlyIncome3.Dirty = value;
                _tax4506TotalYearlyIncome4.Dirty = value;
                _tax4506TotalYearlyJointIncome1.Dirty = value;
                _tax4506TotalYearlyJointIncome2.Dirty = value;
                _tax4506TotalYearlyJointIncome3.Dirty = value;
                _tax4506TotalYearlyJointIncome4.Dirty = value;
                _tax4506TotalYearlyVarianceIncome1.Dirty = value;
                _tax4506TotalYearlyVarianceIncome2.Dirty = value;
                _tax4506TotalYearlyVarianceIncome3.Dirty = value;
                _tax4506TotalYearlyVarianceIncome4.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome1.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome2.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome3.Dirty = value;
                _tax4506TotalYearlyVarianceJointIncome4.Dirty = value;
                _taxIdentificationIdentifier.Dirty = value;
                _totalLiabilitiesBalanceAmount.Dirty = value;
                _totalMonthlyIncomeAmount.Dirty = value;
                _totalMonthlyIncomeMinusNetRentalAmount.Dirty = value;
                _totalPresentHousingExpenseAmount.Dirty = value;
                _transactionPurposeDescription.Dirty = value;
                _transUnion120Days.Dirty = value;
                _transUnion150Days.Dirty = value;
                _transUnion30Days.Dirty = value;
                _transUnion60Days.Dirty = value;
                _transUnion90Days.Dirty = value;
                _transUnionCreditScoreForDisclosure.Dirty = value;
                _transUnionCreditScoreRanksPercent.Dirty = value;
                _transUnionDatePulled.Dirty = value;
                _transUnionFactorCode1.Dirty = value;
                _transUnionFactorCode2.Dirty = value;
                _transUnionFactorCode3.Dirty = value;
                _transUnionFactorCode4.Dirty = value;
                _transUnionFactorCode5.Dirty = value;
                _transUnionKeyFactor1.Dirty = value;
                _transUnionKeyFactor2.Dirty = value;
                _transUnionKeyFactor3.Dirty = value;
                _transUnionKeyFactor4.Dirty = value;
                _transUnionKeyFactor5.Dirty = value;
                _transUnionMaterialTermsCreditByScore.Dirty = value;
                _transUnionScore.Dirty = value;
                _userDefinedIncome.Dirty = value;
                _vaFederalTaxAmount.Dirty = value;
                _validDaysForConsentCount.Dirty = value;
                _valueRepAndWarrantyAvailable.Dirty = value;
                _valueRepAndWarrantyMessage.Dirty = value;
                _vaNetTakeHomePayAmount.Dirty = value;
                _vaOtherAmount.Dirty = value;
                _vaOtherNetIncomeAmount.Dirty = value;
                _vaRetirementAmount.Dirty = value;
                _vaStateTaxAmount.Dirty = value;
                _vaTotalIncomeDeductionsAmount.Dirty = value;
                _vaTotalNetIncomeAmount.Dirty = value;
                _vendor1.Dirty = value;
                _vendor10.Dirty = value;
                _vendor11.Dirty = value;
                _vendor12.Dirty = value;
                _vendor13.Dirty = value;
                _vendor14.Dirty = value;
                _vendor15.Dirty = value;
                _vendor16.Dirty = value;
                _vendor17.Dirty = value;
                _vendor18.Dirty = value;
                _vendor19.Dirty = value;
                _vendor2.Dirty = value;
                _vendor20.Dirty = value;
                _vendor21.Dirty = value;
                _vendor22.Dirty = value;
                _vendor23.Dirty = value;
                _vendor24.Dirty = value;
                _vendor25.Dirty = value;
                _vendor26.Dirty = value;
                _vendor3.Dirty = value;
                _vendor4.Dirty = value;
                _vendor5.Dirty = value;
                _vendor6.Dirty = value;
                _vendor7.Dirty = value;
                _vendor8.Dirty = value;
                _vendor9.Dirty = value;
                _vestingTrusteeOfType.Dirty = value;
                _veteranIndicator.Dirty = value;
                _workEmailAddress.Dirty = value;
                _yearsofCreditOnFile.Dirty = value;
                if (_contact != null) _contact.Dirty = value;
            }
        }
    }
}