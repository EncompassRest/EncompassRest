using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hmda
    /// </summary>
    public sealed partial class Hmda : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<ActionTaken>> _actionTaken;
        /// <summary>
        /// Trans Details Current Loan Status [1393]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Current Loan Status")]
        public StringEnumValue<ActionTaken> ActionTaken { get => _actionTaken; set => _actionTaken = value; }
        private DirtyValue<string> _applicationDate;
        /// <summary>
        /// Application Date [HMDA.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Application Date")]
        public string ApplicationDate { get => _applicationDate; set => _applicationDate = value; }
        private DirtyValue<StringEnumValue<AUS>> _aUS1;
        /// <summary>
        /// AUS #1 [HMDA.X44]
        /// </summary>
        [LoanFieldProperty(Description = "AUS #1")]
        public StringEnumValue<AUS> AUS1 { get => _aUS1; set => _aUS1 = value; }
        private DirtyValue<StringEnumValue<AUS>> _aUS2;
        /// <summary>
        /// AUS #2 [HMDA.X45]
        /// </summary>
        [LoanFieldProperty(Description = "AUS #2", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUS> AUS2 { get => _aUS2; set => _aUS2 = value; }
        private DirtyValue<StringEnumValue<AUS>> _aUS3;
        /// <summary>
        /// AUS #3 [HMDA.X46]
        /// </summary>
        [LoanFieldProperty(Description = "AUS #3", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUS> AUS3 { get => _aUS3; set => _aUS3 = value; }
        private DirtyValue<StringEnumValue<AUS>> _aUS4;
        /// <summary>
        /// AUS #4 [HMDA.X47]
        /// </summary>
        [LoanFieldProperty(Description = "AUS #4", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUS> AUS4 { get => _aUS4; set => _aUS4 = value; }
        private DirtyValue<StringEnumValue<AUS>> _aUS5;
        /// <summary>
        /// AUS #5 [HMDA.X48]
        /// </summary>
        [LoanFieldProperty(Description = "AUS #5", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUS> AUS5 { get => _aUS5; set => _aUS5 = value; }
        private DirtyValue<StringEnumValue<AUSRecommendation>> _aUSRecommendation1;
        /// <summary>
        /// AUS Recommendation #1 [HMDA.X50]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Recommendation #1")]
        public StringEnumValue<AUSRecommendation> AUSRecommendation1 { get => _aUSRecommendation1; set => _aUSRecommendation1 = value; }
        private DirtyValue<StringEnumValue<AUSRecommendation>> _aUSRecommendation2;
        /// <summary>
        /// AUS Recommendation #2 [HMDA.X51]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Recommendation #2", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUSRecommendation> AUSRecommendation2 { get => _aUSRecommendation2; set => _aUSRecommendation2 = value; }
        private DirtyValue<StringEnumValue<AUSRecommendation>> _aUSRecommendation3;
        /// <summary>
        /// AUS Recommendation #3 [HMDA.X52]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Recommendation #3", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUSRecommendation> AUSRecommendation3 { get => _aUSRecommendation3; set => _aUSRecommendation3 = value; }
        private DirtyValue<StringEnumValue<AUSRecommendation>> _aUSRecommendation4;
        /// <summary>
        /// AUS Recommendation #4 [HMDA.X53]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Recommendation #4", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUSRecommendation> AUSRecommendation4 { get => _aUSRecommendation4; set => _aUSRecommendation4 = value; }
        private DirtyValue<StringEnumValue<AUSRecommendation>> _aUSRecommendation5;
        /// <summary>
        /// AUS Recommendation #5 [HMDA.X54]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Recommendation #5", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<AUSRecommendation> AUSRecommendation5 { get => _aUSRecommendation5; set => _aUSRecommendation5 = value; }
        private DirtyValue<StringEnumValue<BusinessOrCommercialPurpose>> _businessOrCommercialPurpose;
        /// <summary>
        /// Business or Commercial Purpose [HMDA.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Business or Commercial Purpose")]
        public StringEnumValue<BusinessOrCommercialPurpose> BusinessOrCommercialPurpose { get => _businessOrCommercialPurpose; set => _businessOrCommercialPurpose = value; }
        private DirtyValue<string> _censusTrack;
        /// <summary>
        /// Subject Property Census Tract [700]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Census Tract")]
        public string CensusTrack { get => _censusTrack; set => _censusTrack = value; }
        private DirtyValue<NA<decimal>> _cLTV;
        /// <summary>
        /// CLTV [HMDA.X37]
        /// </summary>
        [LoanFieldProperty(Description = "CLTV")]
        public NA<decimal> CLTV { get => _cLTV; set => _cLTV = value; }
        private DirtyValue<string> _contactEmailAddress;
        /// <summary>
        /// HMDA Contact Person Email [HMDA.X62]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Contact Person Email")]
        public string ContactEmailAddress { get => _contactEmailAddress; set => _contactEmailAddress = value; }
        private DirtyValue<string> _contactFaxNumber;
        /// <summary>
        /// HMDA Contact Person Fax # [HMDA.X67]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Contact Person Fax #")]
        public string ContactFaxNumber { get => _contactFaxNumber; set => _contactFaxNumber = value; }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// HMDA Contact Person Name [HMDA.X60]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Contact Person Name")]
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<string> _contactOfficeCity;
        /// <summary>
        /// HMDA Contact Person City [HMDA.X64]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Contact Person City")]
        public string ContactOfficeCity { get => _contactOfficeCity; set => _contactOfficeCity = value; }
        private DirtyValue<string> _contactOfficeState;
        /// <summary>
        /// HMDA Contact Person State [HMDA.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "HMDA Contact Person State")]
        public string ContactOfficeState { get => _contactOfficeState; set => _contactOfficeState = value; }
        private DirtyValue<string> _contactOfficeStreetAddress;
        /// <summary>
        /// HMDA Contact Person Street Address [HMDA.X63]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Contact Person Street Address")]
        public string ContactOfficeStreetAddress { get => _contactOfficeStreetAddress; set => _contactOfficeStreetAddress = value; }
        private DirtyValue<string> _contactOfficeZIPCode;
        /// <summary>
        /// HMDA Contact Person ZIP [HMDA.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HMDA Contact Person ZIP")]
        public string ContactOfficeZIPCode { get => _contactOfficeZIPCode; set => _contactOfficeZIPCode = value; }
        private DirtyValue<string> _contactPhoneNumber;
        /// <summary>
        /// HMDA Contact Person Phone # [HMDA.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "HMDA Contact Person Phone #")]
        public string ContactPhoneNumber { get => _contactPhoneNumber; set => _contactPhoneNumber = value; }
        private DirtyValue<string> _countyCode;
        /// <summary>
        /// Subject Property County Code [1396]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property County Code")]
        public string CountyCode { get => _countyCode; set => _countyCode = value; }
        private DirtyValue<NA<decimal>> _debtToIncomeRatio;
        /// <summary>
        /// Debt to Income Ratio [HMDA.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Debt to Income Ratio")]
        public NA<decimal> DebtToIncomeRatio { get => _debtToIncomeRatio; set => _debtToIncomeRatio = value; }
        private DirtyValue<StringEnumValue<DenialReason>> _denialReason1;
        /// <summary>
        /// Denial Reason 1 [HMDA.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Reason 1")]
        public StringEnumValue<DenialReason> DenialReason1 { get => _denialReason1; set => _denialReason1 = value; }
        private DirtyValue<StringEnumValue<DenialReason>> _denialReason2;
        /// <summary>
        /// Denial Reason 2 [HMDA.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Reason 2", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<DenialReason> DenialReason2 { get => _denialReason2; set => _denialReason2 = value; }
        private DirtyValue<StringEnumValue<DenialReason>> _denialReason3;
        /// <summary>
        /// Denial Reason 3 [HMDA.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Reason 3", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<DenialReason> DenialReason3 { get => _denialReason3; set => _denialReason3 = value; }
        private DirtyValue<StringEnumValue<DenialReason>> _denialReason4;
        /// <summary>
        /// Denial Reason 4 [HMDA.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Reason 4", MissingOptionsJson = "[\"Not applicable\"]")]
        public StringEnumValue<DenialReason> DenialReason4 { get => _denialReason4; set => _denialReason4 = value; }
        private DirtyValue<NA<decimal>> _discountPoints;
        /// <summary>
        /// Discount Points [HMDA.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Discount Points")]
        public NA<decimal> DiscountPoints { get => _discountPoints; set => _discountPoints = value; }
        private DirtyValue<bool?> _excludeLoanFromHMDAReportIndicator;
        /// <summary>
        /// Subject Property Exclude from HMDA Report [HMDA.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Exclude from HMDA Report", OptionsJson = "{\"true\":\"Exclude loan from HMDA report\"}")]
        public bool? ExcludeLoanFromHMDAReportIndicator { get => _excludeLoanFromHMDAReportIndicator; set => _excludeLoanFromHMDAReportIndicator = value; }
        private DirtyValue<StringEnumValue<FederalAgency>> _federalAgency;
        /// <summary>
        /// HMDA Federal Agency [HMDA.X68]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Federal Agency")]
        public StringEnumValue<FederalAgency> FederalAgency { get => _federalAgency; set => _federalAgency = value; }
        private DirtyValue<string> _federalTaxpayerIdNumber;
        /// <summary>
        /// HMDA Fedral Tax ID [HMDA.X69]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Fedral Tax ID")]
        public string FederalTaxpayerIdNumber { get => _federalTaxpayerIdNumber; set => _federalTaxpayerIdNumber = value; }
        private DirtyValue<string> _financialInstitutionName;
        /// <summary>
        /// HMDA Company Name [HMDA.X59]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Company Name")]
        public string FinancialInstitutionName { get => _financialInstitutionName; set => _financialInstitutionName = value; }
        private DirtyValue<bool?> _hmdaCltvIndicator;
        /// <summary>
        /// HMDA CLTV [HMDA.X98]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA CLTV", OptionsJson = "{\"true\":\"HMDA CLTV\"}")]
        public bool? HmdaCltvIndicator { get => _hmdaCltvIndicator; set => _hmdaCltvIndicator = value; }
        private DirtyValue<bool?> _hmdaDtiIndicator;
        /// <summary>
        /// HMDA DTI [HMDA.X97]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA DTI", OptionsJson = "{\"true\":\"HMDA DTI\"}")]
        public bool? HmdaDtiIndicator { get => _hmdaDtiIndicator; set => _hmdaDtiIndicator = value; }
        private DirtyValue<bool?> _hmdaIncomeIndicator;
        /// <summary>
        /// HMDA Income [HMDA.X99]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Income", OptionsJson = "{\"true\":\"HMDA Income\"}")]
        public bool? HmdaIncomeIndicator { get => _hmdaIncomeIndicator; set => _hmdaIncomeIndicator = value; }
        private DirtyValue<bool?> _hmdaInterestOnlyIndicator;
        /// <summary>
        /// Trans Details Interest Only Indicator [HMDA.X109]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Interest Only Indicator")]
        public bool? HmdaInterestOnlyIndicator { get => _hmdaInterestOnlyIndicator; set => _hmdaInterestOnlyIndicator = value; }
        private DirtyValue<StringEnumValue<HmdaLoanPurpose>> _hMDALoanPurpose;
        /// <summary>
        /// HMDA Loan Purpose [HMDA.X107]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Loan Purpose", OptionsJson = "{\"Home Purchase\":\"1. Home purchase\",\"Home Improvement\":\"2. Home improvement\",\"Cash-out refinancing\":\"32. Cash-out refinancing (consumer only)\",\"Other purpose\":\"4. Other purpose (consumer only)\"}")]
        public StringEnumValue<HmdaLoanPurpose> HMDALoanPurpose { get => _hMDALoanPurpose; set => _hMDALoanPurpose = value; }
        private DirtyValue<string> _hMDAProfileApplicationDateValue;
        /// <summary>
        /// HMDA Profile - Application Date value from Setting [HMDA.X104]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HMDA Profile - Application Date value from Setting")]
        public string HMDAProfileApplicationDateValue { get => _hMDAProfileApplicationDateValue; set => _hMDAProfileApplicationDateValue = value; }
        private DirtyValue<string> _hMDAProfileCLTVValue;
        /// <summary>
        /// HMDA Profile - CLTV value from Setting [HMDA.X102]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HMDA Profile - CLTV value from Setting")]
        public string HMDAProfileCLTVValue { get => _hMDAProfileCLTVValue; set => _hMDAProfileCLTVValue = value; }
        private DirtyValue<string> _hMDAProfileDTIValue;
        /// <summary>
        /// HMDA Profile - DTI value from Setting [HMDA.X101]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HMDA Profile - DTI value from Setting")]
        public string HMDAProfileDTIValue { get => _hMDAProfileDTIValue; set => _hMDAProfileDTIValue = value; }
        private DirtyValue<string> _hMDAProfileID;
        /// <summary>
        /// HMDA Profile ID [HMDA.X100]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Profile ID")]
        public string HMDAProfileID { get => _hMDAProfileID; set => _hMDAProfileID = value; }
        private DirtyValue<string> _hMDAProfileIncomeValue;
        /// <summary>
        /// HMDA Profile - Income value from Setting [HMDA.X103]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "HMDA Profile - Income value from Setting")]
        public string HMDAProfileIncomeValue { get => _hMDAProfileIncomeValue; set => _hMDAProfileIncomeValue = value; }
        private DirtyValue<string> _hmdaPropertyAddress;
        /// <summary>
        /// HMDA Property Address [HMDA.X88]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Property Address")]
        public string HmdaPropertyAddress { get => _hmdaPropertyAddress; set => _hmdaPropertyAddress = value; }
        private DirtyValue<string> _hmdaPropertyCity;
        /// <summary>
        /// HMDA Property City [HMDA.X89]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Property City")]
        public string HmdaPropertyCity { get => _hmdaPropertyCity; set => _hmdaPropertyCity = value; }
        private DirtyValue<string> _hmdaPropertyState;
        /// <summary>
        /// HMDA Property State [HMDA.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "HMDA Property State")]
        public string HmdaPropertyState { get => _hmdaPropertyState; set => _hmdaPropertyState = value; }
        private DirtyValue<bool?> _hmdaPropertyValueNotReliedUponIndicator;
        /// <summary>
        /// Property Value Not Relied Upon [HMDA.X108]
        /// </summary>
        [LoanFieldProperty(Description = "Property Value Not Relied Upon", OptionsJson = "{\"true\":\"Property Value Not Relied Upon\"}")]
        public bool? HmdaPropertyValueNotReliedUponIndicator { get => _hmdaPropertyValueNotReliedUponIndicator; set => _hmdaPropertyValueNotReliedUponIndicator = value; }
        private DirtyValue<string> _hmdaPropertyZipCode;
        /// <summary>
        /// HMDA Property Zip Code [HMDA.X87]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Property Zip Code")]
        public string HmdaPropertyZipCode { get => _hmdaPropertyZipCode; set => _hmdaPropertyZipCode = value; }
        private DirtyValue<bool?> _hmdaSyncAddressIndicator;
        /// <summary>
        /// HMDA Sync address fields with subject property address [HMDA.X91]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Sync address fields with subject property address", OptionsJson = "{\"true\":\"HMDA Sync Address Indicator\"}")]
        public bool? HmdaSyncAddressIndicator { get => _hmdaSyncAddressIndicator; set => _hmdaSyncAddressIndicator = value; }
        private DirtyValue<StringEnumValue<HOEPAStatus>> _hOEPAStatus;
        /// <summary>
        /// Trans Details HOEPA Status [HMDA.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details HOEPA Status")]
        public StringEnumValue<HOEPAStatus> HOEPAStatus { get => _hOEPAStatus; set => _hOEPAStatus = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hmda Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<NA<decimal>> _income;
        /// <summary>
        /// HMDA Income [HMDA.X32]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Income")]
        public NA<decimal> Income { get => _income; set => _income = value; }
        private DirtyValue<decimal?> _incomeExcludedFromHmda;
        /// <summary>
        /// Income Excluded From HMDA [HMDA.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Income Excluded From HMDA")]
        public decimal? IncomeExcludedFromHmda { get => _incomeExcludedFromHmda; set => _incomeExcludedFromHmda = value; }
        private DirtyValue<StringEnumValue<InitiallyPayableToYourInstitution>> _initiallyPayableToYourInstitution;
        /// <summary>
        /// Initially Payable to Your Institution [HMDA.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Initially Payable to Your Institution")]
        public StringEnumValue<InitiallyPayableToYourInstitution> InitiallyPayableToYourInstitution { get => _initiallyPayableToYourInstitution; set => _initiallyPayableToYourInstitution = value; }
        private DirtyValue<NA<decimal>> _interestRate;
        /// <summary>
        /// Interest Rate [HMDA.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Interest Rate")]
        public NA<decimal> InterestRate { get => _interestRate; set => _interestRate = value; }
        private DirtyValue<string> _introRatePeriod;
        /// <summary>
        /// Intro Rate Period [HMDA.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Intro Rate Period")]
        public string IntroRatePeriod { get => _introRatePeriod; set => _introRatePeriod = value; }
        private DirtyValue<string> _legalEntityIdentifier;
        /// <summary>
        /// HMDA LEI [HMDA.X70]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA LEI")]
        public string LegalEntityIdentifier { get => _legalEntityIdentifier; set => _legalEntityIdentifier = value; }
        private DirtyValue<string> _legalEntityIdentifierReporting;
        /// <summary>
        /// HMDA LEI Reporting [HMDA.X106]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA LEI Reporting")]
        public string LegalEntityIdentifierReporting { get => _legalEntityIdentifierReporting; set => _legalEntityIdentifierReporting = value; }
        private DirtyValue<StringEnumValue<LegalEntityIdentifierUsed>> _legalEntityIdentifierUsed;
        /// <summary>
        /// HMDA LEI Used [HMDA.X105]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA LEI Used")]
        public StringEnumValue<LegalEntityIdentifierUsed> LegalEntityIdentifierUsed { get => _legalEntityIdentifierUsed; set => _legalEntityIdentifierUsed = value; }
        private DirtyValue<NA<decimal>> _lenderCredits;
        /// <summary>
        /// Lender Credits [HMDA.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Credits")]
        public NA<decimal> LenderCredits { get => _lenderCredits; set => _lenderCredits = value; }
        private DirtyValue<StringEnumValue<LienStatus>> _lienStatus;
        /// <summary>
        /// Trans Details Lien Status [HMDA.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lien Status")]
        public StringEnumValue<LienStatus> LienStatus { get => _lienStatus; set => _lienStatus = value; }
        private DirtyValue<decimal?> _loanAmount;
        /// <summary>
        /// HMDA Loan Amount [HMDA.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HMDA Loan Amount")]
        public decimal? LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<StringEnumValue<HmdaLoanPurpose>> _loanPurpose;
        /// <summary>
        /// Trans Details Loan Purpose [384]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Purpose")]
        public StringEnumValue<HmdaLoanPurpose> LoanPurpose { get => _loanPurpose; set => _loanPurpose = value; }
        private DirtyValue<string> _loanTerm;
        /// <summary>
        /// Loan Term [HMDA.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Term")]
        public string LoanTerm { get => _loanTerm; set => _loanTerm = value; }
        private DirtyValue<StringEnumValue<HmdaLoanType>> _loanType;
        /// <summary>
        /// HMDA Loan Type [HMDA.X30]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Loan Type")]
        public StringEnumValue<HmdaLoanType> LoanType { get => _loanType; set => _loanType = value; }
        private DirtyValue<StringEnumValue<ManufacturedHomeLandPropertyInterest>> _manufacturedHomeLandPropertyInterest;
        /// <summary>
        /// Manufactured Home Land Property Interest [HMDA.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Manufactured Home Land Property Interest")]
        public StringEnumValue<ManufacturedHomeLandPropertyInterest> ManufacturedHomeLandPropertyInterest { get => _manufacturedHomeLandPropertyInterest; set => _manufacturedHomeLandPropertyInterest = value; }
        private DirtyValue<StringEnumValue<ManufacturedSecuredProperyType>> _manufacturedSecuredProperyType;
        /// <summary>
        /// Manufactured Secured Property Type [HMDA.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Manufactured Secured Property Type")]
        public StringEnumValue<ManufacturedSecuredProperyType> ManufacturedSecuredProperyType { get => _manufacturedSecuredProperyType; set => _manufacturedSecuredProperyType = value; }
        private DirtyValue<string> _mSANumber;
        /// <summary>
        /// Subject Property MSA # [699]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property MSA #")]
        public string MSANumber { get => _mSANumber; set => _mSANumber = value; }
        private DirtyValue<string> _multifamilyNoUnits;
        /// <summary>
        /// Multifamily No Units [HMDA.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Multifamily No Units")]
        public string MultifamilyNoUnits { get => _multifamilyNoUnits; set => _multifamilyNoUnits = value; }
        private DirtyValue<string> _nMLSLoanOriginatorID;
        /// <summary>
        /// NMLS Loan Originator ID [HMDA.X86]
        /// </summary>
        [LoanFieldProperty(Description = "NMLS Loan Originator ID")]
        public string NMLSLoanOriginatorID { get => _nMLSLoanOriginatorID; set => _nMLSLoanOriginatorID = value; }
        private DirtyValue<StringEnumValue<OpenEndLineOfCredit>> _openEndLineOfCredit;
        /// <summary>
        /// Open-End Line of Credit [HMDA.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Open-End Line of Credit")]
        public StringEnumValue<OpenEndLineOfCredit> OpenEndLineOfCredit { get => _openEndLineOfCredit; set => _openEndLineOfCredit = value; }
        private DirtyValue<string> _originationCharges;
        /// <summary>
        /// Origination Charges [HMDA.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Origination Charges")]
        public string OriginationCharges { get => _originationCharges; set => _originationCharges = value; }
        private DirtyValue<string> _otherAUS;
        /// <summary>
        /// Other AUX(s) [HMDA.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Other AUX(s)")]
        public string OtherAUS { get => _otherAUS; set => _otherAUS = value; }
        private DirtyValue<string> _otherAUSRecommendations;
        /// <summary>
        /// Other AUS Recommendation(s) [HMDA.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Other AUS Recommendation(s)")]
        public string OtherAUSRecommendations { get => _otherAUSRecommendations; set => _otherAUSRecommendations = value; }
        private DirtyValue<string> _otherDenialReason;
        /// <summary>
        /// Other Denial Reason [HMDA.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Other Denial Reason")]
        public string OtherDenialReason { get => _otherDenialReason; set => _otherDenialReason = value; }
        private DirtyValue<StringEnumValue<OtherNonAmortization>> _otherNonAmortization;
        /// <summary>
        /// Other Non-Amortization [HMDA.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Other Non-Amortization")]
        public StringEnumValue<OtherNonAmortization> OtherNonAmortization { get => _otherNonAmortization; set => _otherNonAmortization = value; }
        private DirtyValue<string> _parentAddress;
        /// <summary>
        /// HMDA Parent Address [HMDA.X73]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Parent Address")]
        public string ParentAddress { get => _parentAddress; set => _parentAddress = value; }
        private DirtyValue<string> _parentCity;
        /// <summary>
        /// HMDA Parent City [HMDA.X74]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Parent City")]
        public string ParentCity { get => _parentCity; set => _parentCity = value; }
        private DirtyValue<string> _parentName;
        /// <summary>
        /// HMDA Parent Contact Name [HMDA.X72]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Parent Contact Name")]
        public string ParentName { get => _parentName; set => _parentName = value; }
        private DirtyValue<string> _parentState;
        /// <summary>
        /// HMDA Parent State [HMDA.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.STATE, Description = "HMDA Parent State")]
        public string ParentState { get => _parentState; set => _parentState = value; }
        private DirtyValue<string> _parentZip;
        /// <summary>
        /// HMDA Parent Zipcode [HMDA.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "HMDA Parent Zipcode")]
        public string ParentZip { get => _parentZip; set => _parentZip = value; }
        private DirtyValue<StringEnumValue<Preapprovals>> _preapprovals;
        /// <summary>
        /// Trans Details Preapprovals [HMDA.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Preapprovals")]
        public StringEnumValue<Preapprovals> Preapprovals { get => _preapprovals; set => _preapprovals = value; }
        private DirtyValue<string> _prepaymentPenaltyPeriod;
        /// <summary>
        /// Prepayment Penalty Period [HMDA.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Prepayment Penalty Period")]
        public string PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => _prepaymentPenaltyPeriod = value; }
        private DirtyValue<StringEnumValue<HmdaPropertyType>> _propertyType;
        /// <summary>
        /// Subject Property Type [HMDA.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Type")]
        public StringEnumValue<HmdaPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<NA<decimal>> _propertyValue;
        /// <summary>
        /// Property Value [HMDA.X85]
        /// </summary>
        [LoanFieldProperty(Description = "Property Value")]
        public NA<decimal> PropertyValue { get => _propertyValue; set => _propertyValue = value; }
        private DirtyValue<StringEnumValue<QMStatus>> _qMStatus;
        /// <summary>
        /// QM Status [HMDA.X26]
        /// </summary>
        [LoanFieldProperty(Description = "QM Status")]
        public StringEnumValue<QMStatus> QMStatus { get => _qMStatus; set => _qMStatus = value; }
        private DirtyValue<NA<decimal>> _rateSpread;
        /// <summary>
        /// Trans Details Rate Spread [HMDA.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Spread")]
        public NA<decimal> RateSpread { get => _rateSpread; set => _rateSpread = value; }
        private DirtyValue<int?> _reportingYear;
        /// <summary>
        /// HMDA Reporting Year [HMDA.X27]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Reporting Year")]
        public int? ReportingYear { get => _reportingYear; set => _reportingYear = value; }
        private DirtyValue<bool?> _reportPurposeOfLoanIndicator;
        /// <summary>
        /// Loan Purpose is Home Improvement [HMDA.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Purpose is Home Improvement", OptionsJson = "{\"true\":\"Report the purpose of this loan as Home Improvement (one to four family)\"}")]
        public bool? ReportPurposeOfLoanIndicator { get => _reportPurposeOfLoanIndicator; set => _reportPurposeOfLoanIndicator = value; }
        private DirtyValue<string> _repurchasedActionDate;
        /// <summary>
        /// Repurchased Action Date [HMDA.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Repurchased Action Date")]
        public string RepurchasedActionDate { get => _repurchasedActionDate; set => _repurchasedActionDate = value; }
        private DirtyValue<StringEnumValue<ActionTaken>> _repurchasedActionTaken;
        /// <summary>
        /// HMDA Repurchased Trans Details Current Loan Status [HMDA.X95]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Repurchased Trans Details Current Loan Status")]
        public StringEnumValue<ActionTaken> RepurchasedActionTaken { get => _repurchasedActionTaken; set => _repurchasedActionTaken = value; }
        private DirtyValue<decimal?> _repurchasedLoanAmount;
        /// <summary>
        /// HMDA Repurchased Loan Amount [HMDA.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HMDA Repurchased Loan Amount")]
        public decimal? RepurchasedLoanAmount { get => _repurchasedLoanAmount; set => _repurchasedLoanAmount = value; }
        private DirtyValue<int?> _repurchasedReportingYear;
        /// <summary>
        /// HMDA Repurchased Reporting Year [HMDA.X92]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Repurchased Reporting Year")]
        public int? RepurchasedReportingYear { get => _repurchasedReportingYear; set => _repurchasedReportingYear = value; }
        private DirtyValue<StringEnumValue<TypeOfPurchaser>> _repurchasedTypeOfPurchaser;
        /// <summary>
        /// HMDA Repurchased Trans Details Purchaser Type [HMDA.X94]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Repurchased Trans Details Purchaser Type")]
        public StringEnumValue<TypeOfPurchaser> RepurchasedTypeOfPurchaser { get => _repurchasedTypeOfPurchaser; set => _repurchasedTypeOfPurchaser = value; }
        private DirtyValue<string> _respondentID;
        /// <summary>
        /// HMDA Respondent ID [HMDA.X71]
        /// </summary>
        [LoanFieldProperty(Description = "HMDA Respondent ID")]
        public string RespondentID { get => _respondentID; set => _respondentID = value; }
        private DirtyValue<StringEnumValue<ReverseMortgage>> _reverseMortgage;
        /// <summary>
        /// Reverse Mortgage [HMDA.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Reverse Mortgage")]
        public StringEnumValue<ReverseMortgage> ReverseMortgage { get => _reverseMortgage; set => _reverseMortgage = value; }
        private DirtyValue<string> _stateCode;
        /// <summary>
        /// Subject Property State Code [1395]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property State Code")]
        public string StateCode { get => _stateCode; set => _stateCode = value; }
        private DirtyValue<StringEnumValue<SubmissionOfApplication>> _submissionOfApplication;
        /// <summary>
        /// Submission of Application [HMDA.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Submission of Application")]
        public StringEnumValue<SubmissionOfApplication> SubmissionOfApplication { get => _submissionOfApplication; set => _submissionOfApplication = value; }
        private DirtyValue<string> _totalLoanCosts;
        /// <summary>
        /// Total Loan Costs [HMDA.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Total Loan Costs")]
        public string TotalLoanCosts { get => _totalLoanCosts; set => _totalLoanCosts = value; }
        private DirtyValue<string> _totalPointsAndFees;
        /// <summary>
        /// Total Points and Fees [HMDA.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Total Points and Fees")]
        public string TotalPointsAndFees { get => _totalPointsAndFees; set => _totalPointsAndFees = value; }
        private DirtyValue<StringEnumValue<TypeOfPurchaser>> _typeOfPurchaser;
        /// <summary>
        /// Trans Details Purchaser Type [1397]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Purchaser Type")]
        public StringEnumValue<TypeOfPurchaser> TypeOfPurchaser { get => _typeOfPurchaser; set => _typeOfPurchaser = value; }
        private DirtyValue<string> _universalLoanId;
        /// <summary>
        /// Universal Loan Id [HMDA.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Universal Loan Id")]
        public string UniversalLoanId { get => _universalLoanId; set => _universalLoanId = value; }
        internal override bool DirtyInternal
        {
            get => _actionTaken.Dirty
                || _applicationDate.Dirty
                || _aUS1.Dirty
                || _aUS2.Dirty
                || _aUS3.Dirty
                || _aUS4.Dirty
                || _aUS5.Dirty
                || _aUSRecommendation1.Dirty
                || _aUSRecommendation2.Dirty
                || _aUSRecommendation3.Dirty
                || _aUSRecommendation4.Dirty
                || _aUSRecommendation5.Dirty
                || _businessOrCommercialPurpose.Dirty
                || _censusTrack.Dirty
                || _cLTV.Dirty
                || _contactEmailAddress.Dirty
                || _contactFaxNumber.Dirty
                || _contactName.Dirty
                || _contactOfficeCity.Dirty
                || _contactOfficeState.Dirty
                || _contactOfficeStreetAddress.Dirty
                || _contactOfficeZIPCode.Dirty
                || _contactPhoneNumber.Dirty
                || _countyCode.Dirty
                || _debtToIncomeRatio.Dirty
                || _denialReason1.Dirty
                || _denialReason2.Dirty
                || _denialReason3.Dirty
                || _denialReason4.Dirty
                || _discountPoints.Dirty
                || _excludeLoanFromHMDAReportIndicator.Dirty
                || _federalAgency.Dirty
                || _federalTaxpayerIdNumber.Dirty
                || _financialInstitutionName.Dirty
                || _hmdaCltvIndicator.Dirty
                || _hmdaDtiIndicator.Dirty
                || _hmdaIncomeIndicator.Dirty
                || _hmdaInterestOnlyIndicator.Dirty
                || _hMDALoanPurpose.Dirty
                || _hMDAProfileApplicationDateValue.Dirty
                || _hMDAProfileCLTVValue.Dirty
                || _hMDAProfileDTIValue.Dirty
                || _hMDAProfileID.Dirty
                || _hMDAProfileIncomeValue.Dirty
                || _hmdaPropertyAddress.Dirty
                || _hmdaPropertyCity.Dirty
                || _hmdaPropertyState.Dirty
                || _hmdaPropertyValueNotReliedUponIndicator.Dirty
                || _hmdaPropertyZipCode.Dirty
                || _hmdaSyncAddressIndicator.Dirty
                || _hOEPAStatus.Dirty
                || _id.Dirty
                || _income.Dirty
                || _incomeExcludedFromHmda.Dirty
                || _initiallyPayableToYourInstitution.Dirty
                || _interestRate.Dirty
                || _introRatePeriod.Dirty
                || _legalEntityIdentifier.Dirty
                || _legalEntityIdentifierReporting.Dirty
                || _legalEntityIdentifierUsed.Dirty
                || _lenderCredits.Dirty
                || _lienStatus.Dirty
                || _loanAmount.Dirty
                || _loanPurpose.Dirty
                || _loanTerm.Dirty
                || _loanType.Dirty
                || _manufacturedHomeLandPropertyInterest.Dirty
                || _manufacturedSecuredProperyType.Dirty
                || _mSANumber.Dirty
                || _multifamilyNoUnits.Dirty
                || _nMLSLoanOriginatorID.Dirty
                || _openEndLineOfCredit.Dirty
                || _originationCharges.Dirty
                || _otherAUS.Dirty
                || _otherAUSRecommendations.Dirty
                || _otherDenialReason.Dirty
                || _otherNonAmortization.Dirty
                || _parentAddress.Dirty
                || _parentCity.Dirty
                || _parentName.Dirty
                || _parentState.Dirty
                || _parentZip.Dirty
                || _preapprovals.Dirty
                || _prepaymentPenaltyPeriod.Dirty
                || _propertyType.Dirty
                || _propertyValue.Dirty
                || _qMStatus.Dirty
                || _rateSpread.Dirty
                || _reportingYear.Dirty
                || _reportPurposeOfLoanIndicator.Dirty
                || _repurchasedActionDate.Dirty
                || _repurchasedActionTaken.Dirty
                || _repurchasedLoanAmount.Dirty
                || _repurchasedReportingYear.Dirty
                || _repurchasedTypeOfPurchaser.Dirty
                || _respondentID.Dirty
                || _reverseMortgage.Dirty
                || _stateCode.Dirty
                || _submissionOfApplication.Dirty
                || _totalLoanCosts.Dirty
                || _totalPointsAndFees.Dirty
                || _typeOfPurchaser.Dirty
                || _universalLoanId.Dirty;
            set
            {
                _actionTaken.Dirty = value;
                _applicationDate.Dirty = value;
                _aUS1.Dirty = value;
                _aUS2.Dirty = value;
                _aUS3.Dirty = value;
                _aUS4.Dirty = value;
                _aUS5.Dirty = value;
                _aUSRecommendation1.Dirty = value;
                _aUSRecommendation2.Dirty = value;
                _aUSRecommendation3.Dirty = value;
                _aUSRecommendation4.Dirty = value;
                _aUSRecommendation5.Dirty = value;
                _businessOrCommercialPurpose.Dirty = value;
                _censusTrack.Dirty = value;
                _cLTV.Dirty = value;
                _contactEmailAddress.Dirty = value;
                _contactFaxNumber.Dirty = value;
                _contactName.Dirty = value;
                _contactOfficeCity.Dirty = value;
                _contactOfficeState.Dirty = value;
                _contactOfficeStreetAddress.Dirty = value;
                _contactOfficeZIPCode.Dirty = value;
                _contactPhoneNumber.Dirty = value;
                _countyCode.Dirty = value;
                _debtToIncomeRatio.Dirty = value;
                _denialReason1.Dirty = value;
                _denialReason2.Dirty = value;
                _denialReason3.Dirty = value;
                _denialReason4.Dirty = value;
                _discountPoints.Dirty = value;
                _excludeLoanFromHMDAReportIndicator.Dirty = value;
                _federalAgency.Dirty = value;
                _federalTaxpayerIdNumber.Dirty = value;
                _financialInstitutionName.Dirty = value;
                _hmdaCltvIndicator.Dirty = value;
                _hmdaDtiIndicator.Dirty = value;
                _hmdaIncomeIndicator.Dirty = value;
                _hmdaInterestOnlyIndicator.Dirty = value;
                _hMDALoanPurpose.Dirty = value;
                _hMDAProfileApplicationDateValue.Dirty = value;
                _hMDAProfileCLTVValue.Dirty = value;
                _hMDAProfileDTIValue.Dirty = value;
                _hMDAProfileID.Dirty = value;
                _hMDAProfileIncomeValue.Dirty = value;
                _hmdaPropertyAddress.Dirty = value;
                _hmdaPropertyCity.Dirty = value;
                _hmdaPropertyState.Dirty = value;
                _hmdaPropertyValueNotReliedUponIndicator.Dirty = value;
                _hmdaPropertyZipCode.Dirty = value;
                _hmdaSyncAddressIndicator.Dirty = value;
                _hOEPAStatus.Dirty = value;
                _id.Dirty = value;
                _income.Dirty = value;
                _incomeExcludedFromHmda.Dirty = value;
                _initiallyPayableToYourInstitution.Dirty = value;
                _interestRate.Dirty = value;
                _introRatePeriod.Dirty = value;
                _legalEntityIdentifier.Dirty = value;
                _legalEntityIdentifierReporting.Dirty = value;
                _legalEntityIdentifierUsed.Dirty = value;
                _lenderCredits.Dirty = value;
                _lienStatus.Dirty = value;
                _loanAmount.Dirty = value;
                _loanPurpose.Dirty = value;
                _loanTerm.Dirty = value;
                _loanType.Dirty = value;
                _manufacturedHomeLandPropertyInterest.Dirty = value;
                _manufacturedSecuredProperyType.Dirty = value;
                _mSANumber.Dirty = value;
                _multifamilyNoUnits.Dirty = value;
                _nMLSLoanOriginatorID.Dirty = value;
                _openEndLineOfCredit.Dirty = value;
                _originationCharges.Dirty = value;
                _otherAUS.Dirty = value;
                _otherAUSRecommendations.Dirty = value;
                _otherDenialReason.Dirty = value;
                _otherNonAmortization.Dirty = value;
                _parentAddress.Dirty = value;
                _parentCity.Dirty = value;
                _parentName.Dirty = value;
                _parentState.Dirty = value;
                _parentZip.Dirty = value;
                _preapprovals.Dirty = value;
                _prepaymentPenaltyPeriod.Dirty = value;
                _propertyType.Dirty = value;
                _propertyValue.Dirty = value;
                _qMStatus.Dirty = value;
                _rateSpread.Dirty = value;
                _reportingYear.Dirty = value;
                _reportPurposeOfLoanIndicator.Dirty = value;
                _repurchasedActionDate.Dirty = value;
                _repurchasedActionTaken.Dirty = value;
                _repurchasedLoanAmount.Dirty = value;
                _repurchasedReportingYear.Dirty = value;
                _repurchasedTypeOfPurchaser.Dirty = value;
                _respondentID.Dirty = value;
                _reverseMortgage.Dirty = value;
                _stateCode.Dirty = value;
                _submissionOfApplication.Dirty = value;
                _totalLoanCosts.Dirty = value;
                _totalPointsAndFees.Dirty = value;
                _typeOfPurchaser.Dirty = value;
                _universalLoanId.Dirty = value;
            }
        }
    }
}