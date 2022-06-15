using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Tsum
/// </summary>
public sealed partial class Tsum : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Trans Details Qual Rate Amt Increase/Decrease [1660]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? AboveOrBelowRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X31 [TSUM.X31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AdjustorCoverage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Risk Assess AUS Recomm [1544]
    /// </summary>
    public string? AusRecommendation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X5 [TSUM.X5]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BedroomsUnit1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X6 [TSUM.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BedroomsUnit2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X7 [TSUM.X7]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BedroomsUnit3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X8 [TSUM.X8]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? BedroomsUnit4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X30 [TSUM.X30]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CertificateNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Commitment # [996]
    /// </summary>
    public string? CommitmentNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Commun Lending/AHI [1551]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Lending/Affordable Housing Initiative\"}")]
    public bool? CommunityLendingAffordableHousingInitiative { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Title [1143]
    /// </summary>
    public string? ContactTitle { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Contract # [971]
    /// </summary>
    public string? ContractNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Condo Project ID Number [3050]
    /// </summary>
    public string? CpmProjectId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting DU Case ID/LP AUS Key # [DU.LP.ID]
    /// </summary>
    public string? DuCaseIdLpAusKey { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Level of Prpty Review Form # [1542]
    /// </summary>
    public string? FormNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X9 [TSUM.X9]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GrossRentUnit1 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X10 [TSUM.X10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GrossRentUnit2 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X11 [TSUM.X11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GrossRentUnit3 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X12 [TSUM.X12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? GrossRentUnit4 { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Buyer/Homeownrshp Edu Cert [1552]
    /// </summary>
    public StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile> HomeBuyersOwnershipEducationCertificateInFile { get => GetValue<StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile>>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X13 [TSUM.X13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? InsurerCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Interested Party Contrib % [1549]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? InterestedPartyContributions { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Investor Case/Loan # [352]
    /// </summary>
    public string? InvestorLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Level of Prpty Review [1541]
    /// </summary>
    public StringEnumValue<LevelOfPropertyReviewType> LevelOfPropertyReviewType { get => GetValue<StringEnumValue<LevelOfPropertyReviewType>>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Risk Assess LP Doc Class [1545]
    /// </summary>
    public string? LpDocClass { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Mtg Originator [1149]
    /// </summary>
    public StringEnumValue<TsumMortgageOriginator> MortgageOriginator { get => GetValue<StringEnumValue<TsumMortgageOriginator>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Note Date [992]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? NoteDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Qual Rate Basis [1086]
    /// </summary>
    public StringEnumValue<NoteRateType> NoteRateType { get => GetValue<StringEnumValue<NoteRateType>>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X4 [TSUM.X4]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? NumberOfBorrowers { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Mos Resrv [1548]
    /// </summary>
    public int? NumberOfMonthsReserves { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Original Loan Amt [1085]
    /// </summary>
    public decimal? OriginalAmountOfFirstMortgage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Risk Assess Other Descr [1556]
    /// </summary>
    public StringEnumValue<OtherTypeDescription> OtherTypeDescription { get => GetValue<StringEnumValue<OtherTypeDescription>>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X29 [TSUM.X29]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PercentageofCoverage { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Project Name [1298]
    /// </summary>
    public string? ProjectName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Valuation Form Type [TSUM.PropertyFormType]
    /// </summary>
    [LoanFieldProperty(MissingOptionsJson = "[\"One Unit Residential Appraisal Desk Review Report\"]")]
    public StringEnumValue<PropertyFormType> PropertyFormType { get => GetValue<StringEnumValue<PropertyFormType>>(); set => SetValue(value); }

    /// <summary>
    /// Subject Property Type [1553]
    /// </summary>
    public StringEnumValue<OtherPropertyType> PropertyType { get => GetValue<StringEnumValue<OtherPropertyType>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Required [1546]
    /// </summary>
    public decimal? Required { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Risk Assess Type [1543]
    /// </summary>
    public StringEnumValue<RiskAssessmentType> RiskAssessmentType { get => GetValue<StringEnumValue<RiskAssessmentType>>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Addr [1302]
    /// </summary>
    public string? SellerAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller City [1304]
    /// </summary>
    public string? SellerCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Contact [1303]
    /// </summary>
    public string? SellerContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Country [4679]
    /// </summary>
    public string? SellerCountry { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Foreign Address Indicator [4678]
    /// </summary>
    public bool? SellerForeignAddressIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Co Name [1301]
    /// </summary>
    public string? SellerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller # [997]
    /// </summary>
    public string? SellerNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Phone [1293]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? SellerPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller Zip [1305]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? SellerPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Seller State [1292]
    /// </summary>
    public string? SellerState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X32 [TSUM.X32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X35 [TSUM.X35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X33 [TSUM.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X36 [TSUM.X36]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X34 [TSUM.X34]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Field TSUM.X37 [TSUM.X37]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? SpecialFeatureCode6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Mtg Orig Third Party Name [1133]
    /// </summary>
    public string? ThirdPartyName1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Third Party Name [1714]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ThirdPartyName2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Commitment Type [987]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TypeOfCommitment { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 1 [1216]
    /// </summary>
    public string? UnderwritingComment1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 2 [1217]
    /// </summary>
    public string? UnderwritingComment2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 3 [1218]
    /// </summary>
    public string? UnderwritingComment3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 4 [1219]
    /// </summary>
    public string? UnderwritingComment4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 5 [1220]
    /// </summary>
    public string? UnderwritingComment5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 6 [1221]
    /// </summary>
    public string? UnderwritingComment6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 7 [1222]
    /// </summary>
    public string? UnderwritingComment7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Underwriting Comment 8 [1829]
    /// </summary>
    public string? UnderwritingComment8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Sub Fin Additional Mtgs [1732]
    /// </summary>
    public decimal? UnpaidBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Funds to Close - Verif [1547]
    /// </summary>
    public decimal? Verified { get => GetValue<decimal?>(); set => SetValue(value); }
}