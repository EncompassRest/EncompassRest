using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Tsum
    /// </summary>
    public sealed partial class Tsum : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _aboveOrBelowRatePercent;
        private DirtyValue<string?>? _adjustorCoverage;
        private DirtyValue<string?>? _ausRecommendation;
        private DirtyValue<int?>? _bedroomsUnit1;
        private DirtyValue<int?>? _bedroomsUnit2;
        private DirtyValue<int?>? _bedroomsUnit3;
        private DirtyValue<int?>? _bedroomsUnit4;
        private DirtyValue<string?>? _certificateNumber;
        private DirtyValue<string?>? _commitmentNumber;
        private DirtyValue<bool?>? _communityLendingAfordableHousingInitiative;
        private DirtyValue<string?>? _contactTitle;
        private DirtyValue<string?>? _contractNumber;
        private DirtyValue<string?>? _cpmProjectId;
        private DirtyValue<string?>? _duCaseIdLpAusKey;
        private DirtyValue<string?>? _formNumber;
        private DirtyValue<int?>? _grossRentUnit1;
        private DirtyValue<int?>? _grossRentUnit2;
        private DirtyValue<int?>? _grossRentUnit3;
        private DirtyValue<int?>? _grossRentUnit4;
        private DirtyValue<StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile>>? _homeBuyersOwnershipEducationCertificateInFile;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _insurerCode;
        private DirtyValue<decimal?>? _interestedPartyContributions;
        private DirtyValue<string?>? _investorLoanNumber;
        private DirtyValue<StringEnumValue<LevelOfPropertyReviewType>>? _levelOfPropertyReviewType;
        private DirtyValue<string?>? _lpDocClass;
        private DirtyValue<StringEnumValue<TsumMortgageOriginator>>? _mortgageOriginator;
        private DirtyValue<DateTime?>? _noteDate;
        private DirtyValue<StringEnumValue<NoteRateType>>? _noteRateType;
        private DirtyValue<int?>? _numberOfBorrowers;
        private DirtyValue<int?>? _numberOfMonthsReserves;
        private DirtyValue<decimal?>? _originalAmountOfFirstMortgage;
        private DirtyValue<StringEnumValue<OtherTypeDescription>>? _otherTypeDescription;
        private DirtyValue<string?>? _percentageofCoverage;
        private DirtyValue<string?>? _projectName;
        private DirtyValue<StringEnumValue<PropertyFormType>>? _propertyFormType;
        private DirtyValue<StringEnumValue<OtherPropertyType>>? _propertyType;
        private DirtyValue<decimal?>? _required;
        private DirtyValue<StringEnumValue<RiskAssessmentType>>? _riskAssessmentType;
        private DirtyValue<string?>? _sellerAddress;
        private DirtyValue<string?>? _sellerCity;
        private DirtyValue<string?>? _sellerContactName;
        private DirtyValue<string?>? _sellerCountry;
        private DirtyValue<bool?>? _sellerForeignAddressIndicator;
        private DirtyValue<string?>? _sellerName;
        private DirtyValue<string?>? _sellerNumber;
        private DirtyValue<string?>? _sellerPhone;
        private DirtyValue<string?>? _sellerPostalCode;
        private DirtyValue<StringEnumValue<State>>? _sellerState;
        private DirtyValue<string?>? _specialFeatureCode1;
        private DirtyValue<string?>? _specialFeatureCode2;
        private DirtyValue<string?>? _specialFeatureCode3;
        private DirtyValue<string?>? _specialFeatureCode4;
        private DirtyValue<string?>? _specialFeatureCode5;
        private DirtyValue<string?>? _specialFeatureCode6;
        private DirtyValue<string?>? _thirdPartyName1;
        private DirtyValue<string?>? _thirdPartyName2;
        private DirtyValue<string?>? _typeOfCommitment;
        private DirtyValue<string?>? _underwritingComment1;
        private DirtyValue<string?>? _underwritingComment2;
        private DirtyValue<string?>? _underwritingComment3;
        private DirtyValue<string?>? _underwritingComment4;
        private DirtyValue<string?>? _underwritingComment5;
        private DirtyValue<string?>? _underwritingComment6;
        private DirtyValue<string?>? _underwritingComment7;
        private DirtyValue<string?>? _underwritingComment8;
        private DirtyValue<decimal?>? _unpaidBalance;
        private DirtyValue<decimal?>? _verified;

        /// <summary>
        /// Trans Details Qual Rate Amt Increase/Decrease [1660]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AboveOrBelowRatePercent { get => _aboveOrBelowRatePercent; set => SetField(ref _aboveOrBelowRatePercent, value); }

        /// <summary>
        /// Tsum AdjustorCoverage [TSUM.X31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? AdjustorCoverage { get => _adjustorCoverage; set => SetField(ref _adjustorCoverage, value); }

        /// <summary>
        /// Underwriting Risk Assess AUS Recomm [1544]
        /// </summary>
        public string? AusRecommendation { get => _ausRecommendation; set => SetField(ref _ausRecommendation, value); }

        /// <summary>
        /// Tsum BedroomsUnit1 [TSUM.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit1 { get => _bedroomsUnit1; set => SetField(ref _bedroomsUnit1, value); }

        /// <summary>
        /// Tsum BedroomsUnit2 [TSUM.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit2 { get => _bedroomsUnit2; set => SetField(ref _bedroomsUnit2, value); }

        /// <summary>
        /// Tsum BedroomsUnit3 [TSUM.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit3 { get => _bedroomsUnit3; set => SetField(ref _bedroomsUnit3, value); }

        /// <summary>
        /// Tsum BedroomsUnit4 [TSUM.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit4 { get => _bedroomsUnit4; set => SetField(ref _bedroomsUnit4, value); }

        /// <summary>
        /// Tsum CertificateNumber [TSUM.X30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CertificateNumber { get => _certificateNumber; set => SetField(ref _certificateNumber, value); }

        /// <summary>
        /// Trans Details Commitment # [996]
        /// </summary>
        public string? CommitmentNumber { get => _commitmentNumber; set => SetField(ref _commitmentNumber, value); }

        /// <summary>
        /// Underwriting Commun Lending/AHI [1551]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Community Lending/Affordable Housing Initiative\"}")]
        public bool? CommunityLendingAfordableHousingInitiative { get => _communityLendingAfordableHousingInitiative; set => SetField(ref _communityLendingAfordableHousingInitiative, value); }

        /// <summary>
        /// File Contacts Seller Title [1143]
        /// </summary>
        public string? ContactTitle { get => _contactTitle; set => SetField(ref _contactTitle, value); }

        /// <summary>
        /// Trans Details Contract # [971]
        /// </summary>
        public string? ContractNumber { get => _contractNumber; set => SetField(ref _contractNumber, value); }

        /// <summary>
        /// Condo Project ID Number [3050]
        /// </summary>
        public string? CpmProjectId { get => _cpmProjectId; set => SetField(ref _cpmProjectId, value); }

        /// <summary>
        /// Underwriting DU Case ID/LP AUS Key # [DU.LP.ID]
        /// </summary>
        public string? DuCaseIdLpAusKey { get => _duCaseIdLpAusKey; set => SetField(ref _duCaseIdLpAusKey, value); }

        /// <summary>
        /// Underwriting Level of Prpty Review Form # [1542]
        /// </summary>
        public string? FormNumber { get => _formNumber; set => SetField(ref _formNumber, value); }

        /// <summary>
        /// Tsum GrossRentUnit1 [TSUM.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit1 { get => _grossRentUnit1; set => SetField(ref _grossRentUnit1, value); }

        /// <summary>
        /// Tsum GrossRentUnit2 [TSUM.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit2 { get => _grossRentUnit2; set => SetField(ref _grossRentUnit2, value); }

        /// <summary>
        /// Tsum GrossRentUnit3 [TSUM.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit3 { get => _grossRentUnit3; set => SetField(ref _grossRentUnit3, value); }

        /// <summary>
        /// Tsum GrossRentUnit4 [TSUM.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit4 { get => _grossRentUnit4; set => SetField(ref _grossRentUnit4, value); }

        /// <summary>
        /// Underwriting Buyer/Homeownrshp Edu Cert [1552]
        /// </summary>
        public StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile> HomeBuyersOwnershipEducationCertificateInFile { get => _homeBuyersOwnershipEducationCertificateInFile; set => SetField(ref _homeBuyersOwnershipEducationCertificateInFile, value); }

        /// <summary>
        /// Tsum Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Tsum InsurerCode [TSUM.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? InsurerCode { get => _insurerCode; set => SetField(ref _insurerCode, value); }

        /// <summary>
        /// Borr Funds to Close - Interested Party Contrib % [1549]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InterestedPartyContributions { get => _interestedPartyContributions; set => SetField(ref _interestedPartyContributions, value); }

        /// <summary>
        /// Trans Details Investor Case/Loan # [352]
        /// </summary>
        public string? InvestorLoanNumber { get => _investorLoanNumber; set => SetField(ref _investorLoanNumber, value); }

        /// <summary>
        /// Underwriting Level of Prpty Review [1541]
        /// </summary>
        public StringEnumValue<LevelOfPropertyReviewType> LevelOfPropertyReviewType { get => _levelOfPropertyReviewType; set => SetField(ref _levelOfPropertyReviewType, value); }

        /// <summary>
        /// Underwriting Risk Assess LP Doc Class [1545]
        /// </summary>
        public string? LpDocClass { get => _lpDocClass; set => SetField(ref _lpDocClass, value); }

        /// <summary>
        /// Trans Details Mtg Originator [1149]
        /// </summary>
        public StringEnumValue<TsumMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => SetField(ref _mortgageOriginator, value); }

        /// <summary>
        /// Trans Details Note Date [992]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? NoteDate { get => _noteDate; set => SetField(ref _noteDate, value); }

        /// <summary>
        /// Trans Details Qual Rate Basis [1086]
        /// </summary>
        public StringEnumValue<NoteRateType> NoteRateType { get => _noteRateType; set => SetField(ref _noteRateType, value); }

        /// <summary>
        /// Tsum NumberOfBorrowers [TSUM.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? NumberOfBorrowers { get => _numberOfBorrowers; set => SetField(ref _numberOfBorrowers, value); }

        /// <summary>
        /// Borr Funds to Close - Mos Resrv [1548]
        /// </summary>
        public int? NumberOfMonthsReserves { get => _numberOfMonthsReserves; set => SetField(ref _numberOfMonthsReserves, value); }

        /// <summary>
        /// Trans Details Original Loan Amt [1085]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OriginalAmountOfFirstMortgage { get => _originalAmountOfFirstMortgage; set => SetField(ref _originalAmountOfFirstMortgage, value); }

        /// <summary>
        /// Underwriting Risk Assess Other Descr [1556]
        /// </summary>
        public StringEnumValue<OtherTypeDescription> OtherTypeDescription { get => _otherTypeDescription; set => SetField(ref _otherTypeDescription, value); }

        /// <summary>
        /// Tsum PercentageofCoverage [TSUM.X29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? PercentageofCoverage { get => _percentageofCoverage; set => SetField(ref _percentageofCoverage, value); }

        /// <summary>
        /// Subject Property Project Name [1298]
        /// </summary>
        public string? ProjectName { get => _projectName; set => SetField(ref _projectName, value); }

        /// <summary>
        /// Property Valuation Form Type [TSUM.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(MissingOptionsJson = "[\"One Unit Residential Appraisal Desk Review Report\"]")]
        public StringEnumValue<PropertyFormType> PropertyFormType { get => _propertyFormType; set => SetField(ref _propertyFormType, value); }

        /// <summary>
        /// Subject Property Type [1553]
        /// </summary>
        public StringEnumValue<OtherPropertyType> PropertyType { get => _propertyType; set => SetField(ref _propertyType, value); }

        /// <summary>
        /// Borr Funds to Close - Required [1546]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Required { get => _required; set => SetField(ref _required, value); }

        /// <summary>
        /// Underwriting Risk Assess Type [1543]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"LP\":\"LPA\"}")]
        public StringEnumValue<RiskAssessmentType> RiskAssessmentType { get => _riskAssessmentType; set => SetField(ref _riskAssessmentType, value); }

        /// <summary>
        /// File Contacts Seller Addr [1302]
        /// </summary>
        public string? SellerAddress { get => _sellerAddress; set => SetField(ref _sellerAddress, value); }

        /// <summary>
        /// File Contacts Seller City [1304]
        /// </summary>
        public string? SellerCity { get => _sellerCity; set => SetField(ref _sellerCity, value); }

        /// <summary>
        /// File Contacts Seller Contact [1303]
        /// </summary>
        public string? SellerContactName { get => _sellerContactName; set => SetField(ref _sellerContactName, value); }

        /// <summary>
        /// File Contacts Seller Country [4679]
        /// </summary>
        public string? SellerCountry { get => _sellerCountry; set => SetField(ref _sellerCountry, value); }

        /// <summary>
        /// File Contacts Seller Foreign Address Indicator [4678]
        /// </summary>
        public bool? SellerForeignAddressIndicator { get => _sellerForeignAddressIndicator; set => SetField(ref _sellerForeignAddressIndicator, value); }

        /// <summary>
        /// File Contacts Seller Co Name [1301]
        /// </summary>
        public string? SellerName { get => _sellerName; set => SetField(ref _sellerName, value); }

        /// <summary>
        /// File Contacts Seller # [997]
        /// </summary>
        public string? SellerNumber { get => _sellerNumber; set => SetField(ref _sellerNumber, value); }

        /// <summary>
        /// File Contacts Seller Phone [1293]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? SellerPhone { get => _sellerPhone; set => SetField(ref _sellerPhone, value); }

        /// <summary>
        /// File Contacts Seller Zip [1305]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? SellerPostalCode { get => _sellerPostalCode; set => SetField(ref _sellerPostalCode, value); }

        /// <summary>
        /// File Contacts Seller State [1292]
        /// </summary>
        public StringEnumValue<State> SellerState { get => _sellerState; set => SetField(ref _sellerState, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode1 [TSUM.X32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode1 { get => _specialFeatureCode1; set => SetField(ref _specialFeatureCode1, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode2 [TSUM.X35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode2 { get => _specialFeatureCode2; set => SetField(ref _specialFeatureCode2, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode3 [TSUM.X33]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode3 { get => _specialFeatureCode3; set => SetField(ref _specialFeatureCode3, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode4 [TSUM.X36]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode4 { get => _specialFeatureCode4; set => SetField(ref _specialFeatureCode4, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode5 [TSUM.X34]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode5 { get => _specialFeatureCode5; set => SetField(ref _specialFeatureCode5, value); }

        /// <summary>
        /// Tsum SpecialFeatureCode6 [TSUM.X37]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? SpecialFeatureCode6 { get => _specialFeatureCode6; set => SetField(ref _specialFeatureCode6, value); }

        /// <summary>
        /// Trans Details Mtg Orig Third Party Name [1133]
        /// </summary>
        public string? ThirdPartyName1 { get => _thirdPartyName1; set => SetField(ref _thirdPartyName1, value); }

        /// <summary>
        /// Loan Info Third Party Name [1714]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ThirdPartyName2 { get => _thirdPartyName2; set => SetField(ref _thirdPartyName2, value); }

        /// <summary>
        /// Trans Details Commitment Type [987]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TypeOfCommitment { get => _typeOfCommitment; set => SetField(ref _typeOfCommitment, value); }

        /// <summary>
        /// Underwriting Comment 1 [1216]
        /// </summary>
        public string? UnderwritingComment1 { get => _underwritingComment1; set => SetField(ref _underwritingComment1, value); }

        /// <summary>
        /// Underwriting Comment 2 [1217]
        /// </summary>
        public string? UnderwritingComment2 { get => _underwritingComment2; set => SetField(ref _underwritingComment2, value); }

        /// <summary>
        /// Underwriting Comment 3 [1218]
        /// </summary>
        public string? UnderwritingComment3 { get => _underwritingComment3; set => SetField(ref _underwritingComment3, value); }

        /// <summary>
        /// Underwriting Comment 4 [1219]
        /// </summary>
        public string? UnderwritingComment4 { get => _underwritingComment4; set => SetField(ref _underwritingComment4, value); }

        /// <summary>
        /// Underwriting Comment 5 [1220]
        /// </summary>
        public string? UnderwritingComment5 { get => _underwritingComment5; set => SetField(ref _underwritingComment5, value); }

        /// <summary>
        /// Underwriting Comment 6 [1221]
        /// </summary>
        public string? UnderwritingComment6 { get => _underwritingComment6; set => SetField(ref _underwritingComment6, value); }

        /// <summary>
        /// Underwriting Comment 7 [1222]
        /// </summary>
        public string? UnderwritingComment7 { get => _underwritingComment7; set => SetField(ref _underwritingComment7, value); }

        /// <summary>
        /// Underwriting Comment 8 [1829]
        /// </summary>
        public string? UnderwritingComment8 { get => _underwritingComment8; set => SetField(ref _underwritingComment8, value); }

        /// <summary>
        /// Trans Details Sub Fin Additional Mtgs [1732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UnpaidBalance { get => _unpaidBalance; set => SetField(ref _unpaidBalance, value); }

        /// <summary>
        /// Borr Funds to Close - Verif [1547]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Verified { get => _verified; set => SetField(ref _verified, value); }
    }
}