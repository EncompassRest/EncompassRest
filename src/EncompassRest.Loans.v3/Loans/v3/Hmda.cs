using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Hmda
/// </summary>
public sealed partial class Hmda : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trans Details Current Loan Status [1393]
    /// </summary>
    public StringEnumValue<ActionTaken> ActionTaken { get => GetValue<StringEnumValue<ActionTaken>>(); set => SetValue(value); }

    /// <summary>
    /// Application Date [HMDA.X29]
    /// </summary>
    public DateTime? ApplicationDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// AUS #1 [HMDA.X44]
    /// </summary>
    public StringEnumValue<AUS> Aus1 { get => GetValue<StringEnumValue<AUS>>(); set => SetValue(value); }

    /// <summary>
    /// AUS #2 [HMDA.X45]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> Aus2 { get => GetValue<StringEnumValue<AUS>>(); set => SetValue(value); }

    /// <summary>
    /// AUS #3 [HMDA.X46]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> Aus3 { get => GetValue<StringEnumValue<AUS>>(); set => SetValue(value); }

    /// <summary>
    /// AUS #4 [HMDA.X47]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> Aus4 { get => GetValue<StringEnumValue<AUS>>(); set => SetValue(value); }

    /// <summary>
    /// AUS #5 [HMDA.X48]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUS> Aus5 { get => GetValue<StringEnumValue<AUS>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Recommendation #1 [HMDA.X50]
    /// </summary>
    public StringEnumValue<AUSRecommendation> AusRecommendation1 { get => GetValue<StringEnumValue<AUSRecommendation>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Recommendation #2 [HMDA.X51]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AusRecommendation2 { get => GetValue<StringEnumValue<AUSRecommendation>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Recommendation #3 [HMDA.X52]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AusRecommendation3 { get => GetValue<StringEnumValue<AUSRecommendation>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Recommendation #4 [HMDA.X53]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AusRecommendation4 { get => GetValue<StringEnumValue<AUSRecommendation>>(); set => SetValue(value); }

    /// <summary>
    /// AUS Recommendation #5 [HMDA.X54]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<AUSRecommendation> AusRecommendation5 { get => GetValue<StringEnumValue<AUSRecommendation>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Amort Type Balloon [HMDA.X114]
    /// </summary>
    public StringEnumValue<YNOrExempt> BalloonIndicator { get => GetValue<StringEnumValue<YNOrExempt>>(); set => SetValue(value); }

    /// <summary>
    /// Business or Commercial Purpose [HMDA.X58]
    /// </summary>
    public StringEnumValue<BusinessOrCommercialPurpose> BusinessOrCommercialPurpose { get => GetValue<StringEnumValue<BusinessOrCommercialPurpose>>(); set => SetValue(value); }

    /// <summary>
    /// CD Required [HMDA.X121]
    /// </summary>
    public bool? CdRequired { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Census Tract [700]
    /// </summary>
    public string? CensusTrack { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CLTV [HMDA.X37]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_3)]
    public string? Cltv { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person Email [HMDA.X62]
    /// </summary>
    public string? ContactEmailAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person Fax # [HMDA.X67]
    /// </summary>
    public string? ContactFaxNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person Name [HMDA.X60]
    /// </summary>
    public string? ContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person City [HMDA.X64]
    /// </summary>
    public string? ContactOfficeCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person State [HMDA.X65]
    /// </summary>
    public string? ContactOfficeState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person Street Address [HMDA.X63]
    /// </summary>
    public string? ContactOfficeStreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person ZIP [HMDA.X66]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ContactOfficeZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Contact Person Phone # [HMDA.X61]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? ContactPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property County Code [1396]
    /// </summary>
    public string? CountyCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Debt to Income Ratio [HMDA.X36]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_3)]
    public string? DebtToIncomeRatio { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Denial Reason 1 [HMDA.X21]
    /// </summary>
    public StringEnumValue<DenialReason> DenialReason1 { get => GetValue<StringEnumValue<DenialReason>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Reason 2 [HMDA.X22]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason2 { get => GetValue<StringEnumValue<DenialReason>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Reason 3 [HMDA.X23]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason3 { get => GetValue<StringEnumValue<DenialReason>>(); set => SetValue(value); }

    /// <summary>
    /// Denial Reason 4 [HMDA.X33]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"Not applicable\",\"Exempt\"]")]
    public StringEnumValue<DenialReason> DenialReason4 { get => GetValue<StringEnumValue<DenialReason>>(); set => SetValue(value); }

    /// <summary>
    /// Discount Points [HMDA.X35]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? DiscountPoints { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Exclude from HMDA Report [HMDA.X24]
    /// </summary>
    public bool? ExcludeLoanFromHmdaReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Federal Agency [HMDA.X68]
    /// </summary>
    public StringEnumValue<FederalAgency> FederalAgency { get => GetValue<StringEnumValue<FederalAgency>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Fedral Tax ID [HMDA.X69]
    /// </summary>
    public string? FederalTaxpayerIdNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Company Name [HMDA.X59]
    /// </summary>
    public string? FinancialInstitutionName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [HMDA.X120]
    /// </summary>
    public StringEnumValue<YNOrExempt> Hmda2InterestOnlyIndicator { get => GetValue<StringEnumValue<YNOrExempt>>(); set => SetValue(value); }

    /// <summary>
    /// CFPB HMDA Census Tract [HMDA.X112]
    /// </summary>
    public string? HmdaCensusTrack { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA CLTV [HMDA.X98]
    /// </summary>
    public bool? HmdaCltvIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CFPB HMDA County Code [HMDA.X111]
    /// </summary>
    public string? HmdaCountyCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA DTI [HMDA.X97]
    /// </summary>
    public bool? HmdaDtiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Income [HMDA.X99]
    /// </summary>
    public bool? HmdaIncomeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Interest Only Indicator [HMDA.X109]
    /// </summary>
    public bool? HmdaInterestOnlyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Loan Purpose [HMDA.X107]
    /// </summary>
    public StringEnumValue<HmdaLoanPurpose> HmdaLoanPurpose { get => GetValue<StringEnumValue<HmdaLoanPurpose>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Profile - Application Date value from Setting [HMDA.X104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? HmdaProfileApplicationDateValue { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Profile - CLTV value from Setting [HMDA.X102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaProfileCltvValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Profile - DTI value from Setting [HMDA.X101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaProfileDtiValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Profile ID [HMDA.X100]
    /// </summary>
    public string? HmdaProfileId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Profile - Income value from Setting [HMDA.X103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? HmdaProfileIncomeValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Property Address [HMDA.X88]
    /// </summary>
    public string? HmdaPropertyAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Property City [HMDA.X89]
    /// </summary>
    public string? HmdaPropertyCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Property State [HMDA.X90]
    /// </summary>
    public string? HmdaPropertyState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Value Not Relied Upon [HMDA.X108]
    /// </summary>
    public bool? HmdaPropertyValueNotReliedUponIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Property Zip Code [HMDA.X87]
    /// </summary>
    public string? HmdaPropertyZipCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Sync address fields with subject property address [HMDA.X91]
    /// </summary>
    public bool? HmdaSyncAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details HOEPA Status [HMDA.X13]
    /// </summary>
    public StringEnumValue<HOEPAStatus> HoepaStatus { get => GetValue<StringEnumValue<HOEPAStatus>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Income [HMDA.X32]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public NA<decimal> Income { get => GetValue<NA<decimal>>(); set => SetValue(value); }

    /// <summary>
    /// Income Excluded From HMDA [HMDA.X110]
    /// </summary>
    public decimal? IncomeExcludedFromHmda { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Initially Payable to Your Institution [HMDA.X43]
    /// </summary>
    public StringEnumValue<InitiallyPayableToYourInstitution> InitiallyPayableToYourInstitution { get => GetValue<StringEnumValue<InitiallyPayableToYourInstitution>>(); set => SetValue(value); }

    /// <summary>
    /// Interest Rate [HMDA.X81]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_3)]
    public string? InterestRate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intro Rate Period [HMDA.X84]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public string? IntroRatePeriod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA LEI [HMDA.X70]
    /// </summary>
    public string? LegalEntityIdentifier { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA LEI Reporting [HMDA.X106]
    /// </summary>
    public string? LegalEntityIdentifierReporting { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA LEI Used [HMDA.X105]
    /// </summary>
    public StringEnumValue<LegalEntityIdentifierUsed> LegalEntityIdentifierUsed { get => GetValue<StringEnumValue<LegalEntityIdentifierUsed>>(); set => SetValue(value); }

    /// <summary>
    /// Lender Credits [HMDA.X80]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? LenderCredits { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Lien Status [HMDA.X14]
    /// </summary>
    public StringEnumValue<LienStatus> LienStatus { get => GetValue<StringEnumValue<LienStatus>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Loan Amount [HMDA.X31]
    /// </summary>
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Can Your Loan Balance Rise [HMDA.X115]
    /// </summary>
    public StringEnumValue<YNOrExempt> LoanBalanceRiseIndicator { get => GetValue<StringEnumValue<YNOrExempt>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Loan Purpose [384]
    /// </summary>
    public StringEnumValue<HmdaLoanPurpose> LoanPurpose { get => GetValue<StringEnumValue<HmdaLoanPurpose>>(); set => SetValue(value); }

    /// <summary>
    /// Loan Term [HMDA.X83]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public string? LoanTerm { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Loan Type [HMDA.X30]
    /// </summary>
    public StringEnumValue<HmdaLoanType> LoanType { get => GetValue<StringEnumValue<HmdaLoanType>>(); set => SetValue(value); }

    /// <summary>
    /// Manufactured Home Land Property Interest [HMDA.X40]
    /// </summary>
    public StringEnumValue<ManufacturedHomeLandPropertyInterest> ManufacturedHomeLandPropertyInterest { get => GetValue<StringEnumValue<ManufacturedHomeLandPropertyInterest>>(); set => SetValue(value); }

    /// <summary>
    /// Manufactured Secured Property Type [HMDA.X39]
    /// </summary>
    public StringEnumValue<ManufacturedSecuredProperyType> ManufacturedSecuredPropertyType { get => GetValue<StringEnumValue<ManufacturedSecuredProperyType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property MSA # [699]
    /// </summary>
    public string? MsaNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Multifamily No Units [HMDA.X41]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public string? MultifamilyNoUnits { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// NMLS Loan Originator ID [HMDA.X86]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_STRING)]
    public string? NmlsLoanOriginatorId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Open-End Line of Credit [HMDA.X57]
    /// </summary>
    public StringEnumValue<OpenEndLineOfCredit> OpenEndLineOfCredit { get => GetValue<StringEnumValue<OpenEndLineOfCredit>>(); set => SetValue(value); }

    /// <summary>
    /// Origination Charges [HMDA.X79]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? OriginationCharges { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other AUX(s) [HMDA.X49]
    /// </summary>
    public string? OtherAus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other AUS Recommendation(s) [HMDA.X55]
    /// </summary>
    public string? OtherAusRecommendations { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Denial Reason [HMDA.X34]
    /// </summary>
    public string? OtherDenialReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Other Non-Amortization [HMDA.X38]
    /// </summary>
    public StringEnumValue<OtherNonAmortization> OtherNonAmortization { get => GetValue<StringEnumValue<OtherNonAmortization>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Parent Address [HMDA.X73]
    /// </summary>
    public string? ParentAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Parent City [HMDA.X74]
    /// </summary>
    public string? ParentCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Parent Contact Name [HMDA.X72]
    /// </summary>
    public string? ParentName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Parent State [HMDA.X75]
    /// </summary>
    public string? ParentState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Parent Zipcode [HMDA.X76]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? ParentZip { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Report loan as Partially Exempt [HMDA.X113]
    /// </summary>
    public bool? PartiallyExemptLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Preapprovals [HMDA.X12]
    /// </summary>
    public StringEnumValue<Preapprovals> Preapprovals { get => GetValue<StringEnumValue<Preapprovals>>(); set => SetValue(value); }

    /// <summary>
    /// Prepayment Penalty Period [HMDA.X82]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public string? PrepaymentPenaltyPeriod { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Type [HMDA.X11]
    /// </summary>
    public StringEnumValue<HmdaPropertyType> PropertyType { get => GetValue<StringEnumValue<HmdaPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Property Value [HMDA.X85]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_INTEGER)]
    public string? PropertyValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// QM Status [HMDA.X26]
    /// </summary>
    public StringEnumValue<QMStatus> QmStatus { get => GetValue<StringEnumValue<QMStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Rate Spread [HMDA.X15]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_3)]
    public string? RateSpread { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Reporting Year [HMDA.X27]
    /// </summary>
    public int? ReportingYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Purpose is Home Improvement [HMDA.X25]
    /// </summary>
    public bool? ReportPurposeOfLoanIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Repurchased Action Date [HMDA.X96]
    /// </summary>
    public DateTime? RepurchasedActionDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Repurchased Trans Details Current Loan Status [HMDA.X95]
    /// </summary>
    public StringEnumValue<ActionTaken> RepurchasedActionTaken { get => GetValue<StringEnumValue<ActionTaken>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Repurchased Loan Amount [HMDA.X93]
    /// </summary>
    public decimal? RepurchasedLoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Repurchased Reporting Year [HMDA.X92]
    /// </summary>
    public int? RepurchasedReportingYear { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Repurchased Trans Details Purchaser Type [HMDA.X94]
    /// </summary>
    public StringEnumValue<TypeOfPurchaser> RepurchasedTypeOfPurchaser { get => GetValue<StringEnumValue<TypeOfPurchaser>>(); set => SetValue(value); }

    /// <summary>
    /// HMDA Respondent ID [HMDA.X71]
    /// </summary>
    public string? RespondentId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Reverse Mortgage [HMDA.X56]
    /// </summary>
    public StringEnumValue<ReverseMortgage> ReverseMortgage { get => GetValue<StringEnumValue<ReverseMortgage>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property State Code [1395]
    /// </summary>
    public string? StateCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Submission of Application [HMDA.X42]
    /// </summary>
    public StringEnumValue<SubmissionOfApplication> SubmissionOfApplication { get => GetValue<StringEnumValue<SubmissionOfApplication>>(); set => SetValue(value); }

    /// <summary>
    /// Total Loan Costs [HMDA.X77]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? TotalLoanCosts { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Total Points and Fees [HMDA.X78]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.RA_DECIMAL_2)]
    public string? TotalPointsAndFees { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Purchaser Type [1397]
    /// </summary>
    public StringEnumValue<TypeOfPurchaser> TypeOfPurchaser { get => GetValue<StringEnumValue<TypeOfPurchaser>>(); set => SetValue(value); }

    /// <summary>
    /// Universal Loan Id [HMDA.X28]
    /// </summary>
    public string? UniversalLoanId { get => GetValue<string?>(); set => SetValue(value); }
}