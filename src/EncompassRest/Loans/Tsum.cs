using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Tsum
    /// </summary>
    public sealed partial class Tsum : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _aboveOrBelowRatePercent;
        /// <summary>
        /// Trans Details Qual Rate Amt Increase/Decrease [1660]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Trans Details Qual Rate Amt Increase/Decrease")]
        public decimal? AboveOrBelowRatePercent { get => _aboveOrBelowRatePercent; set => _aboveOrBelowRatePercent = value; }
        private DirtyValue<string> _adjustorCoverage;
        /// <summary>
        /// Tsum AdjustorCoverage [TSUM.X31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string AdjustorCoverage { get => _adjustorCoverage; set => _adjustorCoverage = value; }
        private DirtyValue<string> _ausRecommendation;
        /// <summary>
        /// Underwriting Risk Assess AUS Recomm [1544]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Risk Assess AUS Recomm")]
        public string AusRecommendation { get => _ausRecommendation; set => _ausRecommendation = value; }
        private DirtyValue<int?> _bedroomsUnit1;
        /// <summary>
        /// Tsum BedroomsUnit1 [TSUM.X5]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit1 { get => _bedroomsUnit1; set => _bedroomsUnit1 = value; }
        private DirtyValue<int?> _bedroomsUnit2;
        /// <summary>
        /// Tsum BedroomsUnit2 [TSUM.X6]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit2 { get => _bedroomsUnit2; set => _bedroomsUnit2 = value; }
        private DirtyValue<int?> _bedroomsUnit3;
        /// <summary>
        /// Tsum BedroomsUnit3 [TSUM.X7]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit3 { get => _bedroomsUnit3; set => _bedroomsUnit3 = value; }
        private DirtyValue<int?> _bedroomsUnit4;
        /// <summary>
        /// Tsum BedroomsUnit4 [TSUM.X8]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? BedroomsUnit4 { get => _bedroomsUnit4; set => _bedroomsUnit4 = value; }
        private DirtyValue<string> _certificateNumber;
        /// <summary>
        /// Tsum CertificateNumber [TSUM.X30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string CertificateNumber { get => _certificateNumber; set => _certificateNumber = value; }
        private DirtyValue<string> _commitmentNumber;
        /// <summary>
        /// Trans Details Commitment # [996]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Commitment #")]
        public string CommitmentNumber { get => _commitmentNumber; set => _commitmentNumber = value; }
        private DirtyValue<bool?> _communityLendingAfordableHousingInitiative;
        /// <summary>
        /// Underwriting Commun Lending/AHI [1551]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Commun Lending/AHI", OptionsJson = "{\"true\":\"Community Lending/Affordable Housing Initiative\"}")]
        public bool? CommunityLendingAfordableHousingInitiative { get => _communityLendingAfordableHousingInitiative; set => _communityLendingAfordableHousingInitiative = value; }
        private DirtyValue<string> _contactTitle;
        /// <summary>
        /// File Contacts Seller Title [1143]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller Title")]
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        private DirtyValue<string> _contractNumber;
        /// <summary>
        /// Trans Details Contract # [971]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Contract #")]
        public string ContractNumber { get => _contractNumber; set => _contractNumber = value; }
        private DirtyValue<string> _cpmProjectId;
        /// <summary>
        /// Condo Project ID Number [3050]
        /// </summary>
        [LoanFieldProperty(Description = "Condo Project ID Number")]
        public string CpmProjectId { get => _cpmProjectId; set => _cpmProjectId = value; }
        private DirtyValue<string> _duCaseIdLpAusKey;
        /// <summary>
        /// Underwriting DU Case ID/LP AUS Key # [DU.LP.ID]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting DU Case ID/LP AUS Key #")]
        public string DuCaseIdLpAusKey { get => _duCaseIdLpAusKey; set => _duCaseIdLpAusKey = value; }
        private DirtyValue<string> _formNumber;
        /// <summary>
        /// Underwriting Level of Prpty Review Form # [1542]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Level of Prpty Review Form #")]
        public string FormNumber { get => _formNumber; set => _formNumber = value; }
        private DirtyValue<int?> _grossRentUnit1;
        /// <summary>
        /// Tsum GrossRentUnit1 [TSUM.X9]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit1 { get => _grossRentUnit1; set => _grossRentUnit1 = value; }
        private DirtyValue<int?> _grossRentUnit2;
        /// <summary>
        /// Tsum GrossRentUnit2 [TSUM.X10]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit2 { get => _grossRentUnit2; set => _grossRentUnit2 = value; }
        private DirtyValue<int?> _grossRentUnit3;
        /// <summary>
        /// Tsum GrossRentUnit3 [TSUM.X11]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit3 { get => _grossRentUnit3; set => _grossRentUnit3 = value; }
        private DirtyValue<int?> _grossRentUnit4;
        /// <summary>
        /// Tsum GrossRentUnit4 [TSUM.X12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? GrossRentUnit4 { get => _grossRentUnit4; set => _grossRentUnit4 = value; }
        private DirtyValue<StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile>> _homeBuyersOwnershipEducationCertificateInFile;
        /// <summary>
        /// Underwriting Buyer/Homeownrshp Edu Cert [1552]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Buyer/Homeownrshp Edu Cert")]
        public StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile> HomeBuyersOwnershipEducationCertificateInFile { get => _homeBuyersOwnershipEducationCertificateInFile; set => _homeBuyersOwnershipEducationCertificateInFile = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Tsum Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _insurerCode;
        /// <summary>
        /// Tsum InsurerCode [TSUM.X13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string InsurerCode { get => _insurerCode; set => _insurerCode = value; }
        private DirtyValue<decimal?> _interestedPartyContributions;
        /// <summary>
        /// Borr Funds to Close - Interested Party Contrib % [1549]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Borr Funds to Close - Interested Party Contrib %")]
        public decimal? InterestedPartyContributions { get => _interestedPartyContributions; set => _interestedPartyContributions = value; }
        private DirtyValue<string> _investorLoanNumber;
        /// <summary>
        /// Trans Details Investor Case/Loan # [352]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Investor Case/Loan #")]
        public string InvestorLoanNumber { get => _investorLoanNumber; set => _investorLoanNumber = value; }
        private DirtyValue<StringEnumValue<LevelOfPropertyReviewType>> _levelOfPropertyReviewType;
        /// <summary>
        /// Underwriting Level of Prpty Review [1541]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Level of Prpty Review")]
        public StringEnumValue<LevelOfPropertyReviewType> LevelOfPropertyReviewType { get => _levelOfPropertyReviewType; set => _levelOfPropertyReviewType = value; }
        private DirtyValue<string> _lpDocClass;
        /// <summary>
        /// Underwriting Risk Assess LP Doc Class [1545]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Risk Assess LP Doc Class")]
        public string LpDocClass { get => _lpDocClass; set => _lpDocClass = value; }
        private DirtyValue<StringEnumValue<TsumMortgageOriginator>> _mortgageOriginator;
        /// <summary>
        /// Trans Details Mtg Originator [1149]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Mtg Originator")]
        public StringEnumValue<TsumMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => _mortgageOriginator = value; }
        private DirtyValue<DateTime?> _noteDate;
        /// <summary>
        /// Trans Details Note Date [992]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Note Date")]
        public DateTime? NoteDate { get => _noteDate; set => _noteDate = value; }
        private DirtyValue<StringEnumValue<NoteRateType>> _noteRateType;
        /// <summary>
        /// Trans Details Qual Rate Basis [1086]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Qual Rate Basis")]
        public StringEnumValue<NoteRateType> NoteRateType { get => _noteRateType; set => _noteRateType = value; }
        private DirtyValue<int?> _numberOfBorrowers;
        /// <summary>
        /// Tsum NumberOfBorrowers [TSUM.X4]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? NumberOfBorrowers { get => _numberOfBorrowers; set => _numberOfBorrowers = value; }
        private DirtyValue<int?> _numberOfMonthsReserves;
        /// <summary>
        /// Borr Funds to Close - Mos Resrv [1548]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Funds to Close - Mos Resrv")]
        public int? NumberOfMonthsReserves { get => _numberOfMonthsReserves; set => _numberOfMonthsReserves = value; }
        private DirtyValue<decimal?> _originalAmountOfFirstMortgage;
        /// <summary>
        /// Trans Details Original Loan Amt [1085]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Original Loan Amt")]
        public decimal? OriginalAmountOfFirstMortgage { get => _originalAmountOfFirstMortgage; set => _originalAmountOfFirstMortgage = value; }
        private DirtyValue<StringEnumValue<OtherTypeDescription>> _otherTypeDescription;
        /// <summary>
        /// Underwriting Risk Assess Other Descr [1556]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Risk Assess Other Descr")]
        public StringEnumValue<OtherTypeDescription> OtherTypeDescription { get => _otherTypeDescription; set => _otherTypeDescription = value; }
        private DirtyValue<string> _percentageofCoverage;
        /// <summary>
        /// Tsum PercentageofCoverage [TSUM.X29]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PercentageofCoverage { get => _percentageofCoverage; set => _percentageofCoverage = value; }
        private DirtyValue<string> _projectName;
        /// <summary>
        /// Subject Property Project Name [1298]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Project Name")]
        public string ProjectName { get => _projectName; set => _projectName = value; }
        private DirtyValue<StringEnumValue<PropertyFormType>> _propertyFormType;
        /// <summary>
        /// Property Valuation Form Type [TSUM.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(Description = "Property Valuation Form Type")]
        public StringEnumValue<PropertyFormType> PropertyFormType { get => _propertyFormType; set => _propertyFormType = value; }
        private DirtyValue<StringEnumValue<OtherPropertyType>> _propertyType;
        /// <summary>
        /// Subject Property Type [1553]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Type")]
        public StringEnumValue<OtherPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<decimal?> _required;
        /// <summary>
        /// Borr Funds to Close - Required [1546]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Funds to Close - Required")]
        public decimal? Required { get => _required; set => _required = value; }
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _riskAssessmentType;
        /// <summary>
        /// Underwriting Risk Assess Type [1543]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Risk Assess Type")]
        public StringEnumValue<RiskAssessmentType> RiskAssessmentType { get => _riskAssessmentType; set => _riskAssessmentType = value; }
        private DirtyValue<string> _sellerAddress;
        /// <summary>
        /// File Contacts Seller Addr [1302]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller Addr")]
        public string SellerAddress { get => _sellerAddress; set => _sellerAddress = value; }
        private DirtyValue<string> _sellerCity;
        /// <summary>
        /// File Contacts Seller City [1304]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller City")]
        public string SellerCity { get => _sellerCity; set => _sellerCity = value; }
        private DirtyValue<string> _sellerContactName;
        /// <summary>
        /// File Contacts Seller Contact [1303]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller Contact")]
        public string SellerContactName { get => _sellerContactName; set => _sellerContactName = value; }
        private DirtyValue<string> _sellerName;
        /// <summary>
        /// File Contacts Seller Co Name [1301]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller Co Name")]
        public string SellerName { get => _sellerName; set => _sellerName = value; }
        private DirtyValue<string> _sellerNumber;
        /// <summary>
        /// File Contacts Seller # [997]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller #")]
        public string SellerNumber { get => _sellerNumber; set => _sellerNumber = value; }
        private DirtyValue<string> _sellerPhone;
        /// <summary>
        /// File Contacts Seller Phone [1293]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "File Contacts Seller Phone")]
        public string SellerPhone { get => _sellerPhone; set => _sellerPhone = value; }
        private DirtyValue<string> _sellerPostalCode;
        /// <summary>
        /// File Contacts Seller Zip [1305]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "File Contacts Seller Zip")]
        public string SellerPostalCode { get => _sellerPostalCode; set => _sellerPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _sellerState;
        /// <summary>
        /// File Contacts Seller State [1292]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Seller State")]
        public StringEnumValue<State> SellerState { get => _sellerState; set => _sellerState = value; }
        private DirtyValue<string> _specialFeatureCode1;
        /// <summary>
        /// Tsum SpecialFeatureCode1 [TSUM.X32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode1 { get => _specialFeatureCode1; set => _specialFeatureCode1 = value; }
        private DirtyValue<string> _specialFeatureCode2;
        /// <summary>
        /// Tsum SpecialFeatureCode2 [TSUM.X35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode2 { get => _specialFeatureCode2; set => _specialFeatureCode2 = value; }
        private DirtyValue<string> _specialFeatureCode3;
        /// <summary>
        /// Tsum SpecialFeatureCode3 [TSUM.X33]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode3 { get => _specialFeatureCode3; set => _specialFeatureCode3 = value; }
        private DirtyValue<string> _specialFeatureCode4;
        /// <summary>
        /// Tsum SpecialFeatureCode4 [TSUM.X36]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode4 { get => _specialFeatureCode4; set => _specialFeatureCode4 = value; }
        private DirtyValue<string> _specialFeatureCode5;
        /// <summary>
        /// Tsum SpecialFeatureCode5 [TSUM.X34]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode5 { get => _specialFeatureCode5; set => _specialFeatureCode5 = value; }
        private DirtyValue<string> _specialFeatureCode6;
        /// <summary>
        /// Tsum SpecialFeatureCode6 [TSUM.X37]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string SpecialFeatureCode6 { get => _specialFeatureCode6; set => _specialFeatureCode6 = value; }
        private DirtyValue<string> _thirdPartyName1;
        /// <summary>
        /// Trans Details Mtg Orig Third Party Name [1133]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Mtg Orig Third Party Name")]
        public string ThirdPartyName1 { get => _thirdPartyName1; set => _thirdPartyName1 = value; }
        private DirtyValue<string> _thirdPartyName2;
        /// <summary>
        /// Loan Info Third Party Name [1714]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info Third Party Name")]
        public string ThirdPartyName2 { get => _thirdPartyName2; set => _thirdPartyName2 = value; }
        private DirtyValue<string> _typeOfCommitment;
        /// <summary>
        /// Trans Details Commitment Type [987]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Trans Details Commitment Type")]
        public string TypeOfCommitment { get => _typeOfCommitment; set => _typeOfCommitment = value; }
        private DirtyValue<string> _underwritingComment1;
        /// <summary>
        /// Underwriting Comment 1 [1216]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 1")]
        public string UnderwritingComment1 { get => _underwritingComment1; set => _underwritingComment1 = value; }
        private DirtyValue<string> _underwritingComment2;
        /// <summary>
        /// Underwriting Comment 2 [1217]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 2")]
        public string UnderwritingComment2 { get => _underwritingComment2; set => _underwritingComment2 = value; }
        private DirtyValue<string> _underwritingComment3;
        /// <summary>
        /// Underwriting Comment 3 [1218]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 3")]
        public string UnderwritingComment3 { get => _underwritingComment3; set => _underwritingComment3 = value; }
        private DirtyValue<string> _underwritingComment4;
        /// <summary>
        /// Underwriting Comment 4 [1219]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 4")]
        public string UnderwritingComment4 { get => _underwritingComment4; set => _underwritingComment4 = value; }
        private DirtyValue<string> _underwritingComment5;
        /// <summary>
        /// Underwriting Comment 5 [1220]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 5")]
        public string UnderwritingComment5 { get => _underwritingComment5; set => _underwritingComment5 = value; }
        private DirtyValue<string> _underwritingComment6;
        /// <summary>
        /// Underwriting Comment 6 [1221]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 6")]
        public string UnderwritingComment6 { get => _underwritingComment6; set => _underwritingComment6 = value; }
        private DirtyValue<string> _underwritingComment7;
        /// <summary>
        /// Underwriting Comment 7 [1222]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 7")]
        public string UnderwritingComment7 { get => _underwritingComment7; set => _underwritingComment7 = value; }
        private DirtyValue<string> _underwritingComment8;
        /// <summary>
        /// Underwriting Comment 8 [1829]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Comment 8")]
        public string UnderwritingComment8 { get => _underwritingComment8; set => _underwritingComment8 = value; }
        private DirtyValue<decimal?> _unpaidBalance;
        /// <summary>
        /// Trans Details Sub Fin Additional Mtgs [1732]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Sub Fin Additional Mtgs")]
        public decimal? UnpaidBalance { get => _unpaidBalance; set => _unpaidBalance = value; }
        private DirtyValue<decimal?> _verified;
        /// <summary>
        /// Borr Funds to Close - Verif [1547]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Funds to Close - Verif")]
        public decimal? Verified { get => _verified; set => _verified = value; }
    }
}