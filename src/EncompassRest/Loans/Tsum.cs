using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Tsum : ExtensibleObject
    {
        private DirtyValue<decimal?> _aboveOrBelowRatePercent;
        public decimal? AboveOrBelowRatePercent { get => _aboveOrBelowRatePercent; set => _aboveOrBelowRatePercent = value; }
        private DirtyValue<string> _adjustorCoverage;
        public string AdjustorCoverage { get => _adjustorCoverage; set => _adjustorCoverage = value; }
        private DirtyValue<string> _ausRecommendation;
        public string AusRecommendation { get => _ausRecommendation; set => _ausRecommendation = value; }
        private DirtyValue<int?> _bedroomsUnit1;
        public int? BedroomsUnit1 { get => _bedroomsUnit1; set => _bedroomsUnit1 = value; }
        private DirtyValue<int?> _bedroomsUnit2;
        public int? BedroomsUnit2 { get => _bedroomsUnit2; set => _bedroomsUnit2 = value; }
        private DirtyValue<int?> _bedroomsUnit3;
        public int? BedroomsUnit3 { get => _bedroomsUnit3; set => _bedroomsUnit3 = value; }
        private DirtyValue<int?> _bedroomsUnit4;
        public int? BedroomsUnit4 { get => _bedroomsUnit4; set => _bedroomsUnit4 = value; }
        private DirtyValue<string> _certificateNumber;
        public string CertificateNumber { get => _certificateNumber; set => _certificateNumber = value; }
        private DirtyValue<string> _commitmentNumber;
        public string CommitmentNumber { get => _commitmentNumber; set => _commitmentNumber = value; }
        private DirtyValue<bool?> _communityLendingAfordableHousingInitiative;
        public bool? CommunityLendingAfordableHousingInitiative { get => _communityLendingAfordableHousingInitiative; set => _communityLendingAfordableHousingInitiative = value; }
        private DirtyValue<string> _contactTitle;
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        private DirtyValue<string> _contractNumber;
        public string ContractNumber { get => _contractNumber; set => _contractNumber = value; }
        private DirtyValue<string> _cpmProjectId;
        public string CpmProjectId { get => _cpmProjectId; set => _cpmProjectId = value; }
        private DirtyValue<string> _duCaseIdLpAusKey;
        public string DuCaseIdLpAusKey { get => _duCaseIdLpAusKey; set => _duCaseIdLpAusKey = value; }
        private DirtyValue<string> _formNumber;
        public string FormNumber { get => _formNumber; set => _formNumber = value; }
        private DirtyValue<int?> _grossRentUnit1;
        public int? GrossRentUnit1 { get => _grossRentUnit1; set => _grossRentUnit1 = value; }
        private DirtyValue<int?> _grossRentUnit2;
        public int? GrossRentUnit2 { get => _grossRentUnit2; set => _grossRentUnit2 = value; }
        private DirtyValue<int?> _grossRentUnit3;
        public int? GrossRentUnit3 { get => _grossRentUnit3; set => _grossRentUnit3 = value; }
        private DirtyValue<int?> _grossRentUnit4;
        public int? GrossRentUnit4 { get => _grossRentUnit4; set => _grossRentUnit4 = value; }
        private DirtyValue<StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile>> _homeBuyersOwnershipEducationCertificateInFile;
        public StringEnumValue<HomeBuyersOwnershipEducationCertificateInFile> HomeBuyersOwnershipEducationCertificateInFile { get => _homeBuyersOwnershipEducationCertificateInFile; set => _homeBuyersOwnershipEducationCertificateInFile = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _insurerCode;
        public string InsurerCode { get => _insurerCode; set => _insurerCode = value; }
        private DirtyValue<decimal?> _interestedPartyContributions;
        public decimal? InterestedPartyContributions { get => _interestedPartyContributions; set => _interestedPartyContributions = value; }
        private DirtyValue<string> _investorLoanNumber;
        public string InvestorLoanNumber { get => _investorLoanNumber; set => _investorLoanNumber = value; }
        private DirtyValue<StringEnumValue<LevelOfPropertyReviewType>> _levelOfPropertyReviewType;
        public StringEnumValue<LevelOfPropertyReviewType> LevelOfPropertyReviewType { get => _levelOfPropertyReviewType; set => _levelOfPropertyReviewType = value; }
        private DirtyValue<string> _lpDocClass;
        public string LpDocClass { get => _lpDocClass; set => _lpDocClass = value; }
        private DirtyValue<StringEnumValue<TsumMortgageOriginator>> _mortgageOriginator;
        public StringEnumValue<TsumMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => _mortgageOriginator = value; }
        private DirtyValue<DateTime?> _noteDate;
        public DateTime? NoteDate { get => _noteDate; set => _noteDate = value; }
        private DirtyValue<StringEnumValue<NoteRateType>> _noteRateType;
        public StringEnumValue<NoteRateType> NoteRateType { get => _noteRateType; set => _noteRateType = value; }
        private DirtyValue<int?> _numberOfBorrowers;
        public int? NumberOfBorrowers { get => _numberOfBorrowers; set => _numberOfBorrowers = value; }
        private DirtyValue<int?> _numberOfMonthsReserves;
        public int? NumberOfMonthsReserves { get => _numberOfMonthsReserves; set => _numberOfMonthsReserves = value; }
        private DirtyValue<decimal?> _originalAmountOfFirstMortgage;
        public decimal? OriginalAmountOfFirstMortgage { get => _originalAmountOfFirstMortgage; set => _originalAmountOfFirstMortgage = value; }
        private DirtyValue<StringEnumValue<OtherTypeDescription>> _otherTypeDescription;
        public StringEnumValue<OtherTypeDescription> OtherTypeDescription { get => _otherTypeDescription; set => _otherTypeDescription = value; }
        private DirtyValue<string> _percentageofCoverage;
        public string PercentageofCoverage { get => _percentageofCoverage; set => _percentageofCoverage = value; }
        private DirtyValue<string> _projectName;
        public string ProjectName { get => _projectName; set => _projectName = value; }
        private DirtyValue<StringEnumValue<PropertyFormType>> _propertyFormType;
        public StringEnumValue<PropertyFormType> PropertyFormType { get => _propertyFormType; set => _propertyFormType = value; }
        private DirtyValue<StringEnumValue<OtherPropertyType>> _propertyType;
        public StringEnumValue<OtherPropertyType> PropertyType { get => _propertyType; set => _propertyType = value; }
        private DirtyValue<decimal?> _required;
        public decimal? Required { get => _required; set => _required = value; }
        private DirtyValue<StringEnumValue<RiskAssessmentType>> _riskAssessmentType;
        public StringEnumValue<RiskAssessmentType> RiskAssessmentType { get => _riskAssessmentType; set => _riskAssessmentType = value; }
        private DirtyValue<string> _sellerAddress;
        public string SellerAddress { get => _sellerAddress; set => _sellerAddress = value; }
        private DirtyValue<string> _sellerCity;
        public string SellerCity { get => _sellerCity; set => _sellerCity = value; }
        private DirtyValue<string> _sellerContactName;
        public string SellerContactName { get => _sellerContactName; set => _sellerContactName = value; }
        private DirtyValue<string> _sellerName;
        public string SellerName { get => _sellerName; set => _sellerName = value; }
        private DirtyValue<string> _sellerNumber;
        public string SellerNumber { get => _sellerNumber; set => _sellerNumber = value; }
        private DirtyValue<string> _sellerPhone;
        public string SellerPhone { get => _sellerPhone; set => _sellerPhone = value; }
        private DirtyValue<string> _sellerPostalCode;
        public string SellerPostalCode { get => _sellerPostalCode; set => _sellerPostalCode = value; }
        private DirtyValue<string> _sellerState;
        public string SellerState { get => _sellerState; set => _sellerState = value; }
        private DirtyValue<string> _specialFeatureCode1;
        public string SpecialFeatureCode1 { get => _specialFeatureCode1; set => _specialFeatureCode1 = value; }
        private DirtyValue<string> _specialFeatureCode2;
        public string SpecialFeatureCode2 { get => _specialFeatureCode2; set => _specialFeatureCode2 = value; }
        private DirtyValue<string> _specialFeatureCode3;
        public string SpecialFeatureCode3 { get => _specialFeatureCode3; set => _specialFeatureCode3 = value; }
        private DirtyValue<string> _specialFeatureCode4;
        public string SpecialFeatureCode4 { get => _specialFeatureCode4; set => _specialFeatureCode4 = value; }
        private DirtyValue<string> _specialFeatureCode5;
        public string SpecialFeatureCode5 { get => _specialFeatureCode5; set => _specialFeatureCode5 = value; }
        private DirtyValue<string> _specialFeatureCode6;
        public string SpecialFeatureCode6 { get => _specialFeatureCode6; set => _specialFeatureCode6 = value; }
        private DirtyValue<string> _thirdPartyName1;
        public string ThirdPartyName1 { get => _thirdPartyName1; set => _thirdPartyName1 = value; }
        private DirtyValue<string> _thirdPartyName2;
        public string ThirdPartyName2 { get => _thirdPartyName2; set => _thirdPartyName2 = value; }
        private DirtyValue<string> _typeOfCommitment;
        public string TypeOfCommitment { get => _typeOfCommitment; set => _typeOfCommitment = value; }
        private DirtyValue<string> _underwritingComment1;
        public string UnderwritingComment1 { get => _underwritingComment1; set => _underwritingComment1 = value; }
        private DirtyValue<string> _underwritingComment2;
        public string UnderwritingComment2 { get => _underwritingComment2; set => _underwritingComment2 = value; }
        private DirtyValue<string> _underwritingComment3;
        public string UnderwritingComment3 { get => _underwritingComment3; set => _underwritingComment3 = value; }
        private DirtyValue<string> _underwritingComment4;
        public string UnderwritingComment4 { get => _underwritingComment4; set => _underwritingComment4 = value; }
        private DirtyValue<string> _underwritingComment5;
        public string UnderwritingComment5 { get => _underwritingComment5; set => _underwritingComment5 = value; }
        private DirtyValue<string> _underwritingComment6;
        public string UnderwritingComment6 { get => _underwritingComment6; set => _underwritingComment6 = value; }
        private DirtyValue<string> _underwritingComment7;
        public string UnderwritingComment7 { get => _underwritingComment7; set => _underwritingComment7 = value; }
        private DirtyValue<string> _underwritingComment8;
        public string UnderwritingComment8 { get => _underwritingComment8; set => _underwritingComment8 = value; }
        private DirtyValue<decimal?> _unpaidBalance;
        public decimal? UnpaidBalance { get => _unpaidBalance; set => _unpaidBalance = value; }
        private DirtyValue<decimal?> _verified;
        public decimal? Verified { get => _verified; set => _verified = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _aboveOrBelowRatePercent.Dirty
                    || _adjustorCoverage.Dirty
                    || _ausRecommendation.Dirty
                    || _bedroomsUnit1.Dirty
                    || _bedroomsUnit2.Dirty
                    || _bedroomsUnit3.Dirty
                    || _bedroomsUnit4.Dirty
                    || _certificateNumber.Dirty
                    || _commitmentNumber.Dirty
                    || _communityLendingAfordableHousingInitiative.Dirty
                    || _contactTitle.Dirty
                    || _contractNumber.Dirty
                    || _cpmProjectId.Dirty
                    || _duCaseIdLpAusKey.Dirty
                    || _formNumber.Dirty
                    || _grossRentUnit1.Dirty
                    || _grossRentUnit2.Dirty
                    || _grossRentUnit3.Dirty
                    || _grossRentUnit4.Dirty
                    || _homeBuyersOwnershipEducationCertificateInFile.Dirty
                    || _id.Dirty
                    || _insurerCode.Dirty
                    || _interestedPartyContributions.Dirty
                    || _investorLoanNumber.Dirty
                    || _levelOfPropertyReviewType.Dirty
                    || _lpDocClass.Dirty
                    || _mortgageOriginator.Dirty
                    || _noteDate.Dirty
                    || _noteRateType.Dirty
                    || _numberOfBorrowers.Dirty
                    || _numberOfMonthsReserves.Dirty
                    || _originalAmountOfFirstMortgage.Dirty
                    || _otherTypeDescription.Dirty
                    || _percentageofCoverage.Dirty
                    || _projectName.Dirty
                    || _propertyFormType.Dirty
                    || _propertyType.Dirty
                    || _required.Dirty
                    || _riskAssessmentType.Dirty
                    || _sellerAddress.Dirty
                    || _sellerCity.Dirty
                    || _sellerContactName.Dirty
                    || _sellerName.Dirty
                    || _sellerNumber.Dirty
                    || _sellerPhone.Dirty
                    || _sellerPostalCode.Dirty
                    || _sellerState.Dirty
                    || _specialFeatureCode1.Dirty
                    || _specialFeatureCode2.Dirty
                    || _specialFeatureCode3.Dirty
                    || _specialFeatureCode4.Dirty
                    || _specialFeatureCode5.Dirty
                    || _specialFeatureCode6.Dirty
                    || _thirdPartyName1.Dirty
                    || _thirdPartyName2.Dirty
                    || _typeOfCommitment.Dirty
                    || _underwritingComment1.Dirty
                    || _underwritingComment2.Dirty
                    || _underwritingComment3.Dirty
                    || _underwritingComment4.Dirty
                    || _underwritingComment5.Dirty
                    || _underwritingComment6.Dirty
                    || _underwritingComment7.Dirty
                    || _underwritingComment8.Dirty
                    || _unpaidBalance.Dirty
                    || _verified.Dirty;
            }
            set
            {
                _aboveOrBelowRatePercent.Dirty = value;
                _adjustorCoverage.Dirty = value;
                _ausRecommendation.Dirty = value;
                _bedroomsUnit1.Dirty = value;
                _bedroomsUnit2.Dirty = value;
                _bedroomsUnit3.Dirty = value;
                _bedroomsUnit4.Dirty = value;
                _certificateNumber.Dirty = value;
                _commitmentNumber.Dirty = value;
                _communityLendingAfordableHousingInitiative.Dirty = value;
                _contactTitle.Dirty = value;
                _contractNumber.Dirty = value;
                _cpmProjectId.Dirty = value;
                _duCaseIdLpAusKey.Dirty = value;
                _formNumber.Dirty = value;
                _grossRentUnit1.Dirty = value;
                _grossRentUnit2.Dirty = value;
                _grossRentUnit3.Dirty = value;
                _grossRentUnit4.Dirty = value;
                _homeBuyersOwnershipEducationCertificateInFile.Dirty = value;
                _id.Dirty = value;
                _insurerCode.Dirty = value;
                _interestedPartyContributions.Dirty = value;
                _investorLoanNumber.Dirty = value;
                _levelOfPropertyReviewType.Dirty = value;
                _lpDocClass.Dirty = value;
                _mortgageOriginator.Dirty = value;
                _noteDate.Dirty = value;
                _noteRateType.Dirty = value;
                _numberOfBorrowers.Dirty = value;
                _numberOfMonthsReserves.Dirty = value;
                _originalAmountOfFirstMortgage.Dirty = value;
                _otherTypeDescription.Dirty = value;
                _percentageofCoverage.Dirty = value;
                _projectName.Dirty = value;
                _propertyFormType.Dirty = value;
                _propertyType.Dirty = value;
                _required.Dirty = value;
                _riskAssessmentType.Dirty = value;
                _sellerAddress.Dirty = value;
                _sellerCity.Dirty = value;
                _sellerContactName.Dirty = value;
                _sellerName.Dirty = value;
                _sellerNumber.Dirty = value;
                _sellerPhone.Dirty = value;
                _sellerPostalCode.Dirty = value;
                _sellerState.Dirty = value;
                _specialFeatureCode1.Dirty = value;
                _specialFeatureCode2.Dirty = value;
                _specialFeatureCode3.Dirty = value;
                _specialFeatureCode4.Dirty = value;
                _specialFeatureCode5.Dirty = value;
                _specialFeatureCode6.Dirty = value;
                _thirdPartyName1.Dirty = value;
                _thirdPartyName2.Dirty = value;
                _typeOfCommitment.Dirty = value;
                _underwritingComment1.Dirty = value;
                _underwritingComment2.Dirty = value;
                _underwritingComment3.Dirty = value;
                _underwritingComment4.Dirty = value;
                _underwritingComment5.Dirty = value;
                _underwritingComment6.Dirty = value;
                _underwritingComment7.Dirty = value;
                _underwritingComment8.Dirty = value;
                _unpaidBalance.Dirty = value;
                _verified.Dirty = value;
            }
        }
    }
}