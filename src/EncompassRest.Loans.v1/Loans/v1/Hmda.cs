using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Hmda
/// </summary>
public sealed partial class Hmda : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<ActionTaken>>? _actionTaken;
    private DirtyValue<string?>? _applicationDate;
    private DirtyValue<StringEnumValue<AUS>>? _aUS1;
    private DirtyValue<StringEnumValue<AUS>>? _aUS2;
    private DirtyValue<StringEnumValue<AUS>>? _aUS3;
    private DirtyValue<StringEnumValue<AUS>>? _aUS4;
    private DirtyValue<StringEnumValue<AUS>>? _aUS5;
    private DirtyValue<StringEnumValue<AUSRecommendation>>? _aUSRecommendation1;
    private DirtyValue<StringEnumValue<AUSRecommendation>>? _aUSRecommendation2;
    private DirtyValue<StringEnumValue<AUSRecommendation>>? _aUSRecommendation3;
    private DirtyValue<StringEnumValue<AUSRecommendation>>? _aUSRecommendation4;
    private DirtyValue<StringEnumValue<AUSRecommendation>>? _aUSRecommendation5;
    private DirtyValue<StringEnumValue<YNOrExempt>>? _balloonIndicator;
    private DirtyValue<StringEnumValue<BusinessOrCommercialPurpose>>? _businessOrCommercialPurpose;
    private DirtyValue<bool?>? _cDRequired;
    private DirtyValue<string?>? _censusTrack;
    private DirtyValue<StringDecimalValue>? _cLTV;
    private DirtyValue<string?>? _contactEmailAddress;
    private DirtyValue<string?>? _contactFaxNumber;
    private DirtyValue<string?>? _contactName;
    private DirtyValue<string?>? _contactOfficeCity;
    private DirtyValue<StringEnumValue<State>>? _contactOfficeState;
    private DirtyValue<string?>? _contactOfficeStreetAddress;
    private DirtyValue<string?>? _contactOfficeZIPCode;
    private DirtyValue<string?>? _contactPhoneNumber;
    private DirtyValue<string?>? _countyCode;
    private DirtyValue<StringDecimalValue>? _debtToIncomeRatio;
    private DirtyValue<StringEnumValue<DenialReason>>? _denialReason1;
    private DirtyValue<StringEnumValue<DenialReason>>? _denialReason2;
    private DirtyValue<StringEnumValue<DenialReason>>? _denialReason3;
    private DirtyValue<StringEnumValue<DenialReason>>? _denialReason4;
    private DirtyValue<StringDecimalValue>? _discountPoints;
    private DirtyValue<bool?>? _excludeLoanFromHMDAReportIndicator;
    private DirtyValue<StringEnumValue<FederalAgency>>? _federalAgency;
    private DirtyValue<string?>? _federalTaxpayerIdNumber;
    private DirtyValue<string?>? _financialInstitutionName;
    private DirtyValue<StringEnumValue<YNOrExempt>>? _hmda2InterestOnlyIndicator;
    private DirtyValue<string?>? _hMDACensusTrack;
    private DirtyValue<bool?>? _hmdaCltvIndicator;
    private DirtyValue<string?>? _hMDACountyCode;
    private DirtyValue<bool?>? _hmdaDtiIndicator;
    private DirtyValue<bool?>? _hmdaIncomeIndicator;
    private DirtyValue<bool?>? _hmdaInterestOnlyIndicator;
    private DirtyValue<StringEnumValue<HmdaLoanPurpose>>? _hMDALoanPurpose;
    private DirtyValue<string?>? _hMDAProfileApplicationDateValue;
    private DirtyValue<string?>? _hMDAProfileCLTVValue;
    private DirtyValue<string?>? _hMDAProfileDTIValue;
    private DirtyValue<string?>? _hMDAProfileID;
    private DirtyValue<string?>? _hMDAProfileIncomeValue;
    private DirtyValue<string?>? _hmdaPropertyAddress;
    private DirtyValue<string?>? _hmdaPropertyCity;
    private DirtyValue<StringEnumValue<State>>? _hmdaPropertyState;
    private DirtyValue<bool?>? _hmdaPropertyValueNotReliedUponIndicator;
    private DirtyValue<string?>? _hmdaPropertyZipCode;
    private DirtyValue<bool?>? _hmdaSyncAddressIndicator;
    private DirtyValue<StringEnumValue<HOEPAStatus>>? _hOEPAStatus;
    private DirtyValue<string?>? _id;
    private DirtyValue<NA<decimal>>? _income;
    private DirtyValue<decimal?>? _incomeExcludedFromHmda;
    private DirtyValue<StringEnumValue<InitiallyPayableToYourInstitution>>? _initiallyPayableToYourInstitution;
    private DirtyValue<StringDecimalValue>? _interestRate;
    private DirtyValue<string?>? _introRatePeriod;
    private DirtyValue<string?>? _legalEntityIdentifier;
    private DirtyValue<string?>? _legalEntityIdentifierReporting;
    private DirtyValue<StringEnumValue<LegalEntityIdentifierUsed>>? _legalEntityIdentifierUsed;
    private DirtyValue<StringDecimalValue>? _lenderCredits;
    private DirtyValue<StringEnumValue<LienStatus>>? _lienStatus;
    private DirtyValue<decimal?>? _loanAmount;
    private DirtyValue<StringEnumValue<YNOrExempt>>? _loanBalanceRiseIndicator;
    private DirtyValue<StringEnumValue<HmdaLoanPurpose>>? _loanPurpose;
    private DirtyValue<string?>? _loanTerm;
    private DirtyValue<StringEnumValue<HmdaLoanType>>? _loanType;
    private DirtyValue<StringEnumValue<ManufacturedHomeLandPropertyInterest>>? _manufacturedHomeLandPropertyInterest;
    private DirtyValue<StringEnumValue<ManufacturedSecuredProperyType>>? _manufacturedSecuredProperyType;
    private DirtyValue<string?>? _mSANumber;
    private DirtyValue<string?>? _multifamilyNoUnits;
    private DirtyValue<string?>? _nMLSLoanOriginatorID;
    private DirtyValue<StringEnumValue<OpenEndLineOfCredit>>? _openEndLineOfCredit;
    private DirtyValue<string?>? _originationCharges;
    private DirtyValue<string?>? _otherAUS;
    private DirtyValue<string?>? _otherAUSRecommendations;
    private DirtyValue<string?>? _otherDenialReason;
    private DirtyValue<StringEnumValue<OtherNonAmortization>>? _otherNonAmortization;
    private DirtyValue<string?>? _parentAddress;
    private DirtyValue<string?>? _parentCity;
    private DirtyValue<string?>? _parentName;
    private DirtyValue<StringEnumValue<State>>? _parentState;
    private DirtyValue<string?>? _parentZip;
    private DirtyValue<bool?>? _partiallyExemptLoanIndicator;
    private DirtyValue<StringEnumValue<Preapprovals>>? _preapprovals;
    private DirtyValue<string?>? _prepaymentPenaltyPeriod;
    private DirtyValue<StringEnumValue<HmdaPropertyType>>? _propertyType;
    private DirtyValue<StringDecimalValue>? _propertyValue;
    private DirtyValue<StringEnumValue<QMStatus>>? _qMStatus;
    private DirtyValue<StringDecimalValue>? _rateSpread;
    private DirtyValue<int?>? _reportingYear;
    private DirtyValue<bool?>? _reportPurposeOfLoanIndicator;
    private DirtyValue<string?>? _repurchasedActionDate;
    private DirtyValue<StringEnumValue<ActionTaken>>? _repurchasedActionTaken;
    private DirtyValue<decimal?>? _repurchasedLoanAmount;
    private DirtyValue<int?>? _repurchasedReportingYear;
    private DirtyValue<StringEnumValue<TypeOfPurchaser>>? _repurchasedTypeOfPurchaser;
    private DirtyValue<string?>? _respondentID;
    private DirtyValue<StringEnumValue<ReverseMortgage>>? _reverseMortgage;
    private DirtyValue<string?>? _stateCode;
    private DirtyValue<StringEnumValue<SubmissionOfApplication>>? _submissionOfApplication;
    private DirtyValue<string?>? _totalLoanCosts;
    private DirtyValue<string?>? _totalPointsAndFees;
    private DirtyValue<StringEnumValue<TypeOfPurchaser>>? _typeOfPurchaser;
    private DirtyValue<string?>? _universalLoanId;

    /// <summary>
    /// Trans Details Current Loan Status [1393]
    /// </summary>
    public StringEnumValue<ActionTaken> ActionTaken { get => _actionTaken; set => SetField(ref _actionTaken, value); }

    /// <summary>
    /// Application Date [HMDA.X29]
    /// </summary>
    public string? ApplicationDate { get => _applicationDate; set => SetField(ref _applicationDate, value); }

    /// <summary>
    /// AUS #1 [HMDA.X44]
    /// </summary>
    public StringEnumValue<AUS> AUS1 { get => _aUS1; set => SetField(ref _aUS1, value); }

    /// <summary>
    /// AUS #2 [HMDA.X45]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> AUS2 { get => _aUS2; set => SetField(ref _aUS2, value); }

    /// <summary>
    /// AUS #3 [HMDA.X46]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> AUS3 { get => _aUS3; set => SetField(ref _aUS3, value); }

    /// <summary>
    /// AUS #4 [HMDA.X47]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> AUS4 { get => _aUS4; set => SetField(ref _aUS4, value); }

    /// <summary>
    /// AUS #5 [HMDA.X48]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> AUS5 { get => _aUS5; set => SetField(ref _aUS5, value); }

    /// <summary>
    /// AUS Recommendation #1 [HMDA.X50]
    /// </summary>
    public StringEnumValue<AUSRecommendation> AUSRecommendation1 { get => _aUSRecommendation1; set => SetField(ref _aUSRecommendation1, value); }

    /// <summary>
    /// AUS Recommendation #2 [HMDA.X51]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AUSRecommendation2 { get => _aUSRecommendation2; set => SetField(ref _aUSRecommendation2, value); }

    /// <summary>
    /// AUS Recommendation #3 [HMDA.X52]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AUSRecommendation3 { get => _aUSRecommendation3; set => SetField(ref _aUSRecommendation3, value); }

    /// <summary>
    /// AUS Recommendation #4 [HMDA.X53]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AUSRecommendation4 { get => _aUSRecommendation4; set => SetField(ref _aUSRecommendation4, value); }

    /// <summary>
    /// AUS Recommendation #5 [HMDA.X54]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AUSRecommendation5 { get => _aUSRecommendation5; set => SetField(ref _aUSRecommendation5, value); }

    /// <summary>
    /// Trans Details Amort Type Balloon [HMDA.X114]
    /// </summary>
    public StringEnumValue<YNOrExempt> BalloonIndicator { get => _balloonIndicator; set => SetField(ref _balloonIndicator, value); }

    /// <summary>
    /// Business or Commercial Purpose [HMDA.X58]
    /// </summary>
    public StringEnumValue<BusinessOrCommercialPurpose> BusinessOrCommercialPurpose { get => _businessOrCommercialPurpose; set => SetField(ref _businessOrCommercialPurpose, value); }

    /// <summary>
    /// CD Required [HMDA.X121]
    /// </summary>
    public bool? CDRequired { get => _cDRequired; set => SetField(ref _cDRequired, value); }

    /// <summary>
    /// Subject Property Census Tract [700]
    /// </summary>
    public string? CensusTrack { get => _censusTrack; set => SetField(ref _censusTrack, value); }

    /// <summary>
    /// CLTV [HMDA.X37]
    /// </summary>
    public StringDecimalValue CLTV { get => _cLTV; set => SetField(ref _cLTV, value); }

    /// <summary>
    /// HMDA Contact Person Email [HMDA.X62]
    /// </summary>
    public string? ContactEmailAddress { get => _contactEmailAddress; set => SetField(ref _contactEmailAddress, value); }

    /// <summary>
    /// HMDA Contact Person Fax # [HMDA.X67]
    /// </summary>
    public string? ContactFaxNumber { get => _contactFaxNumber; set => SetField(ref _contactFaxNumber, value); }

    /// <summary>
    /// HMDA Contact Person Name [HMDA.X60]
    /// </summary>
    public string? ContactName { get => _contactName; set => SetField(ref _contactName, value); }

    /// <summary>
    /// HMDA Contact Person City [HMDA.X64]
    /// </summary>
    public string? ContactOfficeCity { get => _contactOfficeCity; set => SetField(ref _contactOfficeCity, value); }

    /// <summary>
    /// HMDA Contact Person State [HMDA.X65]
    /// </summary>
    public StringEnumValue<State> ContactOfficeState { get => _contactOfficeState; set => SetField(ref _contactOfficeState, value); }

    /// <summary>
    /// HMDA Contact Person Street Address [HMDA.X63]
    /// </summary>
    public string? ContactOfficeStreetAddress { get => _contactOfficeStreetAddress; set => SetField(ref _contactOfficeStreetAddress, value); }

    /// <summary>
    /// HMDA Contact Person ZIP [HMDA.X66]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ContactOfficeZIPCode { get => _contactOfficeZIPCode; set => SetField(ref _contactOfficeZIPCode, value); }

    /// <summary>
    /// HMDA Contact Person Phone # [HMDA.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ContactPhoneNumber { get => _contactPhoneNumber; set => SetField(ref _contactPhoneNumber, value); }

    /// <summary>
    /// Subject Property County Code [1396]
    /// </summary>
    public string? CountyCode { get => _countyCode; set => SetField(ref _countyCode, value); }

    /// <summary>
    /// Debt to Income Ratio [HMDA.X36]
    /// </summary>
    public StringDecimalValue DebtToIncomeRatio { get => _debtToIncomeRatio; set => SetField(ref _debtToIncomeRatio, value); }

    /// <summary>
    /// Denial Reason 1 [HMDA.X21]
    /// </summary>
    public StringEnumValue<DenialReason> DenialReason1 { get => _denialReason1; set => SetField(ref _denialReason1, value); }

    /// <summary>
    /// Denial Reason 2 [HMDA.X22]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason2 { get => _denialReason2; set => SetField(ref _denialReason2, value); }

    /// <summary>
    /// Denial Reason 3 [HMDA.X23]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason3 { get => _denialReason3; set => SetField(ref _denialReason3, value); }

    /// <summary>
    /// Denial Reason 4 [HMDA.X33]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason4 { get => _denialReason4; set => SetField(ref _denialReason4, value); }

    /// <summary>
    /// Discount Points [HMDA.X35]
    /// </summary>
    public StringDecimalValue DiscountPoints { get => _discountPoints; set => SetField(ref _discountPoints, value); }

    /// <summary>
    /// Subject Property Exclude from HMDA Report [HMDA.X24]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Exclude loan from HMDA report\"}")]
    public bool? ExcludeLoanFromHMDAReportIndicator { get => _excludeLoanFromHMDAReportIndicator; set => SetField(ref _excludeLoanFromHMDAReportIndicator, value); }

    /// <summary>
    /// HMDA Federal Agency [HMDA.X68]
    /// </summary>
    public StringEnumValue<FederalAgency> FederalAgency { get => _federalAgency; set => SetField(ref _federalAgency, value); }

    /// <summary>
    /// HMDA Fedral Tax ID [HMDA.X69]
    /// </summary>
    public string? FederalTaxpayerIdNumber { get => _federalTaxpayerIdNumber; set => SetField(ref _federalTaxpayerIdNumber, value); }

    /// <summary>
    /// HMDA Company Name [HMDA.X59]
    /// </summary>
    public string? FinancialInstitutionName { get => _financialInstitutionName; set => SetField(ref _financialInstitutionName, value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [HMDA.X120]
    /// </summary>
    public StringEnumValue<YNOrExempt> Hmda2InterestOnlyIndicator { get => _hmda2InterestOnlyIndicator; set => SetField(ref _hmda2InterestOnlyIndicator, value); }

    /// <summary>
    /// CFPB HMDA Census Tract [HMDA.X112]
    /// </summary>
    public string? HMDACensusTrack { get => _hMDACensusTrack; set => SetField(ref _hMDACensusTrack, value); }

    /// <summary>
    /// HMDA CLTV [HMDA.X98]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"HMDA CLTV\"}")]
    public bool? HmdaCltvIndicator { get => _hmdaCltvIndicator; set => SetField(ref _hmdaCltvIndicator, value); }

    /// <summary>
    /// CFPB HMDA County Code [HMDA.X111]
    /// </summary>
    public string? HMDACountyCode { get => _hMDACountyCode; set => SetField(ref _hMDACountyCode, value); }

    /// <summary>
    /// HMDA DTI [HMDA.X97]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"HMDA DTI\"}")]
    public bool? HmdaDtiIndicator { get => _hmdaDtiIndicator; set => SetField(ref _hmdaDtiIndicator, value); }

    /// <summary>
    /// HMDA Income [HMDA.X99]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"HMDA Income\"}")]
    public bool? HmdaIncomeIndicator { get => _hmdaIncomeIndicator; set => SetField(ref _hmdaIncomeIndicator, value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [HMDA.X109]
    /// </summary>
    public bool? HmdaInterestOnlyIndicator { get => _hmdaInterestOnlyIndicator; set => SetField(ref _hmdaInterestOnlyIndicator, value); }

    /// <summary>
    /// HMDA Loan Purpose [HMDA.X107]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Home Purchase\":\"1. Home purchase\",\"Home Improvement\":\"2. Home improvement\",\"Cash-out refinancing\":\"32. Cash-out refinancing (consumer only)\",\"Other purpose\":\"4. Other purpose (consumer only)\"}")]
    public StringEnumValue<HmdaLoanPurpose> HMDALoanPurpose { get => _hMDALoanPurpose; set => SetField(ref _hMDALoanPurpose, value); }

    /// <summary>
    /// HMDA Profile - Application Date value from Setting [HMDA.X104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HMDAProfileApplicationDateValue { get => _hMDAProfileApplicationDateValue; set => SetField(ref _hMDAProfileApplicationDateValue, value); }

    /// <summary>
    /// HMDA Profile - CLTV value from Setting [HMDA.X102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HMDAProfileCLTVValue { get => _hMDAProfileCLTVValue; set => SetField(ref _hMDAProfileCLTVValue, value); }

    /// <summary>
    /// HMDA Profile - DTI value from Setting [HMDA.X101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HMDAProfileDTIValue { get => _hMDAProfileDTIValue; set => SetField(ref _hMDAProfileDTIValue, value); }

    /// <summary>
    /// HMDA Profile ID [HMDA.X100]
    /// </summary>
    public string? HMDAProfileID { get => _hMDAProfileID; set => SetField(ref _hMDAProfileID, value); }

    /// <summary>
    /// HMDA Profile - Income value from Setting [HMDA.X103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HMDAProfileIncomeValue { get => _hMDAProfileIncomeValue; set => SetField(ref _hMDAProfileIncomeValue, value); }

    /// <summary>
    /// HMDA Property Address [HMDA.X88]
    /// </summary>
    public string? HmdaPropertyAddress { get => _hmdaPropertyAddress; set => SetField(ref _hmdaPropertyAddress, value); }

    /// <summary>
    /// HMDA Property City [HMDA.X89]
    /// </summary>
    public string? HmdaPropertyCity { get => _hmdaPropertyCity; set => SetField(ref _hmdaPropertyCity, value); }

    /// <summary>
    /// HMDA Property State [HMDA.X90]
    /// </summary>
    public StringEnumValue<State> HmdaPropertyState { get => _hmdaPropertyState; set => SetField(ref _hmdaPropertyState, value); }

    /// <summary>
    /// Property Value Not Relied Upon [HMDA.X108]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Property Value Not Relied Upon\"}")]
    public bool? HmdaPropertyValueNotReliedUponIndicator { get => _hmdaPropertyValueNotReliedUponIndicator; set => SetField(ref _hmdaPropertyValueNotReliedUponIndicator, value); }

    /// <summary>
    /// HMDA Property Zip Code [HMDA.X87]
    /// </summary>
    public string? HmdaPropertyZipCode { get => _hmdaPropertyZipCode; set => SetField(ref _hmdaPropertyZipCode, value); }

    /// <summary>
    /// HMDA Sync address fields with subject property address [HMDA.X91]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"HMDA Sync Address Indicator\"}")]
    public bool? HmdaSyncAddressIndicator { get => _hmdaSyncAddressIndicator; set => SetField(ref _hmdaSyncAddressIndicator, value); }

    /// <summary>
    /// Trans Details HOEPA Status [HMDA.X13]
    /// </summary>
    public StringEnumValue<HOEPAStatus> HOEPAStatus { get => _hOEPAStatus; set => SetField(ref _hOEPAStatus, value); }

    /// <summary>
    /// Hmda Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// HMDA Income [HMDA.X32]
    /// </summary>
    public NA<decimal> Income { get => _income; set => SetField(ref _income, value); }

    /// <summary>
    /// Income Excluded From HMDA [HMDA.X110]
    /// </summary>
    public decimal? IncomeExcludedFromHmda { get => _incomeExcludedFromHmda; set => SetField(ref _incomeExcludedFromHmda, value); }

    /// <summary>
    /// Initially Payable to Your Institution [HMDA.X43]
    /// </summary>
    public StringEnumValue<InitiallyPayableToYourInstitution> InitiallyPayableToYourInstitution { get => _initiallyPayableToYourInstitution; set => SetField(ref _initiallyPayableToYourInstitution, value); }

    /// <summary>
    /// Interest Rate [HMDA.X81]
    /// </summary>
    public StringDecimalValue InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

    /// <summary>
    /// Intro Rate Period [HMDA.X84]
    /// </summary>
    public string? IntroRatePeriod { get => _introRatePeriod; set => SetField(ref _introRatePeriod, value); }

    /// <summary>
    /// HMDA LEI [HMDA.X70]
    /// </summary>
    public string? LegalEntityIdentifier { get => _legalEntityIdentifier; set => SetField(ref _legalEntityIdentifier, value); }

    /// <summary>
    /// HMDA LEI Reporting [HMDA.X106]
    /// </summary>
    public string? LegalEntityIdentifierReporting { get => _legalEntityIdentifierReporting; set => SetField(ref _legalEntityIdentifierReporting, value); }

    /// <summary>
    /// HMDA LEI Used [HMDA.X105]
    /// </summary>
    public StringEnumValue<LegalEntityIdentifierUsed> LegalEntityIdentifierUsed { get => _legalEntityIdentifierUsed; set => SetField(ref _legalEntityIdentifierUsed, value); }

    /// <summary>
    /// Lender Credits [HMDA.X80]
    /// </summary>
    public StringDecimalValue LenderCredits { get => _lenderCredits; set => SetField(ref _lenderCredits, value); }

    /// <summary>
    /// Trans Details Lien Status [HMDA.X14]
    /// </summary>
    public StringEnumValue<LienStatus> LienStatus { get => _lienStatus; set => SetField(ref _lienStatus, value); }

    /// <summary>
    /// HMDA Loan Amount [HMDA.X31]
    /// </summary>
    public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// Can Your Loan Balance Rise [HMDA.X115]
    /// </summary>
    public StringEnumValue<YNOrExempt> LoanBalanceRiseIndicator { get => _loanBalanceRiseIndicator; set => SetField(ref _loanBalanceRiseIndicator, value); }

    /// <summary>
    /// Trans Details Loan Purpose [384]
    /// </summary>
    public StringEnumValue<HmdaLoanPurpose> LoanPurpose { get => _loanPurpose; set => SetField(ref _loanPurpose, value); }

    /// <summary>
    /// Loan Term [HMDA.X83]
    /// </summary>
    public string? LoanTerm { get => _loanTerm; set => SetField(ref _loanTerm, value); }

    /// <summary>
    /// HMDA Loan Type [HMDA.X30]
    /// </summary>
    public StringEnumValue<HmdaLoanType> LoanType { get => _loanType; set => SetField(ref _loanType, value); }

    /// <summary>
    /// Manufactured Home Land Property Interest [HMDA.X40]
    /// </summary>
    public StringEnumValue<ManufacturedHomeLandPropertyInterest> ManufacturedHomeLandPropertyInterest { get => _manufacturedHomeLandPropertyInterest; set => SetField(ref _manufacturedHomeLandPropertyInterest, value); }

    /// <summary>
    /// Manufactured Secured Property Type [HMDA.X39]
    /// </summary>
    public StringEnumValue<ManufacturedSecuredProperyType> ManufacturedSecuredProperyType { get => _manufacturedSecuredProperyType; set => SetField(ref _manufacturedSecuredProperyType, value); }

    /// <summary>
    /// Subject Property MSA # [699]
    /// </summary>
    public string? MSANumber { get => _mSANumber; set => SetField(ref _mSANumber, value); }

    /// <summary>
    /// Multifamily No Units [HMDA.X41]
    /// </summary>
    public string? MultifamilyNoUnits { get => _multifamilyNoUnits; set => SetField(ref _multifamilyNoUnits, value); }

    /// <summary>
    /// NMLS Loan Originator ID [HMDA.X86]
    /// </summary>
    public string? NMLSLoanOriginatorID { get => _nMLSLoanOriginatorID; set => SetField(ref _nMLSLoanOriginatorID, value); }

    /// <summary>
    /// Open-End Line of Credit [HMDA.X57]
    /// </summary>
    public StringEnumValue<OpenEndLineOfCredit> OpenEndLineOfCredit { get => _openEndLineOfCredit; set => SetField(ref _openEndLineOfCredit, value); }

    /// <summary>
    /// Origination Charges [HMDA.X79]
    /// </summary>
    public string? OriginationCharges { get => _originationCharges; set => SetField(ref _originationCharges, value); }

    /// <summary>
    /// Other AUX(s) [HMDA.X49]
    /// </summary>
    public string? OtherAUS { get => _otherAUS; set => SetField(ref _otherAUS, value); }

    /// <summary>
    /// Other AUS Recommendation(s) [HMDA.X55]
    /// </summary>
    public string? OtherAUSRecommendations { get => _otherAUSRecommendations; set => SetField(ref _otherAUSRecommendations, value); }

    /// <summary>
    /// Other Denial Reason [HMDA.X34]
    /// </summary>
    public string? OtherDenialReason { get => _otherDenialReason; set => SetField(ref _otherDenialReason, value); }

    /// <summary>
    /// Other Non-Amortization [HMDA.X38]
    /// </summary>
    public StringEnumValue<OtherNonAmortization> OtherNonAmortization { get => _otherNonAmortization; set => SetField(ref _otherNonAmortization, value); }

    /// <summary>
    /// HMDA Parent Address [HMDA.X73]
    /// </summary>
    public string? ParentAddress { get => _parentAddress; set => SetField(ref _parentAddress, value); }

    /// <summary>
    /// HMDA Parent City [HMDA.X74]
    /// </summary>
    public string? ParentCity { get => _parentCity; set => SetField(ref _parentCity, value); }

    /// <summary>
    /// HMDA Parent Contact Name [HMDA.X72]
    /// </summary>
    public string? ParentName { get => _parentName; set => SetField(ref _parentName, value); }

    /// <summary>
    /// HMDA Parent State [HMDA.X75]
    /// </summary>
    public StringEnumValue<State> ParentState { get => _parentState; set => SetField(ref _parentState, value); }

    /// <summary>
    /// HMDA Parent Zipcode [HMDA.X76]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ParentZip { get => _parentZip; set => SetField(ref _parentZip, value); }

    /// <summary>
    /// Report loan as Partially Exempt [HMDA.X113]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Loan is Partially Exempt\"}")]
    public bool? PartiallyExemptLoanIndicator { get => _partiallyExemptLoanIndicator; set => SetField(ref _partiallyExemptLoanIndicator, value); }

    /// <summary>
    /// Trans Details Preapprovals [HMDA.X12]
    /// </summary>
    public StringEnumValue<Preapprovals> Preapprovals { get => _preapprovals; set => SetField(ref _preapprovals, value); }

    /// <summary>
    /// Prepayment Penalty Period [HMDA.X82]
    /// </summary>
    public string? PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => SetField(ref _prepaymentPenaltyPeriod, value); }

    /// <summary>
    /// Subject Property Type [HMDA.X11]
    /// </summary>
    public StringEnumValue<HmdaPropertyType> PropertyType { get => _propertyType; set => SetField(ref _propertyType, value); }

    /// <summary>
    /// Property Value [HMDA.X85]
    /// </summary>
    public StringDecimalValue PropertyValue { get => _propertyValue; set => SetField(ref _propertyValue, value); }

    /// <summary>
    /// QM Status [HMDA.X26]
    /// </summary>
    public StringEnumValue<QMStatus> QMStatus { get => _qMStatus; set => SetField(ref _qMStatus, value); }

    /// <summary>
    /// Trans Details Rate Spread [HMDA.X15]
    /// </summary>
    public StringDecimalValue RateSpread { get => _rateSpread; set => SetField(ref _rateSpread, value); }

    /// <summary>
    /// HMDA Reporting Year [HMDA.X27]
    /// </summary>
    public int? ReportingYear { get => _reportingYear; set => SetField(ref _reportingYear, value); }

    /// <summary>
    /// Loan Purpose is Home Improvement [HMDA.X25]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Report the purpose of this loan as Home Improvement (one to four family)\"}")]
    public bool? ReportPurposeOfLoanIndicator { get => _reportPurposeOfLoanIndicator; set => SetField(ref _reportPurposeOfLoanIndicator, value); }

    /// <summary>
    /// Repurchased Action Date [HMDA.X96]
    /// </summary>
    public string? RepurchasedActionDate { get => _repurchasedActionDate; set => SetField(ref _repurchasedActionDate, value); }

    /// <summary>
    /// HMDA Repurchased Trans Details Current Loan Status [HMDA.X95]
    /// </summary>
    public StringEnumValue<ActionTaken> RepurchasedActionTaken { get => _repurchasedActionTaken; set => SetField(ref _repurchasedActionTaken, value); }

    /// <summary>
    /// HMDA Repurchased Loan Amount [HMDA.X93]
    /// </summary>
    public decimal? RepurchasedLoanAmount { get => _repurchasedLoanAmount; set => SetField(ref _repurchasedLoanAmount, value); }

    /// <summary>
    /// HMDA Repurchased Reporting Year [HMDA.X92]
    /// </summary>
    public int? RepurchasedReportingYear { get => _repurchasedReportingYear; set => SetField(ref _repurchasedReportingYear, value); }

    /// <summary>
    /// HMDA Repurchased Trans Details Purchaser Type [HMDA.X94]
    /// </summary>
    public StringEnumValue<TypeOfPurchaser> RepurchasedTypeOfPurchaser { get => _repurchasedTypeOfPurchaser; set => SetField(ref _repurchasedTypeOfPurchaser, value); }

    /// <summary>
    /// HMDA Respondent ID [HMDA.X71]
    /// </summary>
    public string? RespondentID { get => _respondentID; set => SetField(ref _respondentID, value); }

    /// <summary>
    /// Reverse Mortgage [HMDA.X56]
    /// </summary>
    public StringEnumValue<ReverseMortgage> ReverseMortgage { get => _reverseMortgage; set => SetField(ref _reverseMortgage, value); }

    /// <summary>
    /// Subject Property State Code [1395]
    /// </summary>
    public string? StateCode { get => _stateCode; set => SetField(ref _stateCode, value); }

    /// <summary>
    /// Submission of Application [HMDA.X42]
    /// </summary>
    public StringEnumValue<SubmissionOfApplication> SubmissionOfApplication { get => _submissionOfApplication; set => SetField(ref _submissionOfApplication, value); }

    /// <summary>
    /// Total Loan Costs [HMDA.X77]
    /// </summary>
    public string? TotalLoanCosts { get => _totalLoanCosts; set => SetField(ref _totalLoanCosts, value); }

    /// <summary>
    /// Total Points and Fees [HMDA.X78]
    /// </summary>
    public string? TotalPointsAndFees { get => _totalPointsAndFees; set => SetField(ref _totalPointsAndFees, value); }

    /// <summary>
    /// Trans Details Purchaser Type [1397]
    /// </summary>
    public StringEnumValue<TypeOfPurchaser> TypeOfPurchaser { get => _typeOfPurchaser; set => SetField(ref _typeOfPurchaser, value); }

    /// <summary>
    /// Universal Loan Id [HMDA.X28]
    /// </summary>
    public string? UniversalLoanId { get => _universalLoanId; set => SetField(ref _universalLoanId, value); }
}