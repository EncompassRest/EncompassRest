using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Tsum : IClean
    {
        private Value<decimal?> _aboveOrBelowRatePercent;
        public decimal? AboveOrBelowRatePercent { get { return _aboveOrBelowRatePercent; } set { _aboveOrBelowRatePercent = value; } }
        private Value<string> _adjustorCoverage;
        public string AdjustorCoverage { get { return _adjustorCoverage; } set { _adjustorCoverage = value; } }
        private Value<string> _ausRecommendation;
        public string AusRecommendation { get { return _ausRecommendation; } set { _ausRecommendation = value; } }
        private Value<int?> _bedroomsUnit1;
        public int? BedroomsUnit1 { get { return _bedroomsUnit1; } set { _bedroomsUnit1 = value; } }
        private Value<int?> _bedroomsUnit2;
        public int? BedroomsUnit2 { get { return _bedroomsUnit2; } set { _bedroomsUnit2 = value; } }
        private Value<int?> _bedroomsUnit3;
        public int? BedroomsUnit3 { get { return _bedroomsUnit3; } set { _bedroomsUnit3 = value; } }
        private Value<int?> _bedroomsUnit4;
        public int? BedroomsUnit4 { get { return _bedroomsUnit4; } set { _bedroomsUnit4 = value; } }
        private Value<string> _certificateNumber;
        public string CertificateNumber { get { return _certificateNumber; } set { _certificateNumber = value; } }
        private Value<string> _commitmentNumber;
        public string CommitmentNumber { get { return _commitmentNumber; } set { _commitmentNumber = value; } }
        private Value<bool?> _communityLendingAfordableHousingInitiative;
        public bool? CommunityLendingAfordableHousingInitiative { get { return _communityLendingAfordableHousingInitiative; } set { _communityLendingAfordableHousingInitiative = value; } }
        private Value<string> _contactTitle;
        public string ContactTitle { get { return _contactTitle; } set { _contactTitle = value; } }
        private Value<string> _contractNumber;
        public string ContractNumber { get { return _contractNumber; } set { _contractNumber = value; } }
        private Value<string> _cpmProjectId;
        public string CpmProjectId { get { return _cpmProjectId; } set { _cpmProjectId = value; } }
        private Value<string> _duCaseIdLpAusKey;
        public string DuCaseIdLpAusKey { get { return _duCaseIdLpAusKey; } set { _duCaseIdLpAusKey = value; } }
        private Value<string> _formNumber;
        public string FormNumber { get { return _formNumber; } set { _formNumber = value; } }
        private Value<int?> _grossRentUnit1;
        public int? GrossRentUnit1 { get { return _grossRentUnit1; } set { _grossRentUnit1 = value; } }
        private Value<int?> _grossRentUnit2;
        public int? GrossRentUnit2 { get { return _grossRentUnit2; } set { _grossRentUnit2 = value; } }
        private Value<int?> _grossRentUnit3;
        public int? GrossRentUnit3 { get { return _grossRentUnit3; } set { _grossRentUnit3 = value; } }
        private Value<int?> _grossRentUnit4;
        public int? GrossRentUnit4 { get { return _grossRentUnit4; } set { _grossRentUnit4 = value; } }
        private Value<string> _homeBuyersOwnershipEducationCertificateInFile;
        public string HomeBuyersOwnershipEducationCertificateInFile { get { return _homeBuyersOwnershipEducationCertificateInFile; } set { _homeBuyersOwnershipEducationCertificateInFile = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _insurerCode;
        public string InsurerCode { get { return _insurerCode; } set { _insurerCode = value; } }
        private Value<decimal?> _interestedPartyContributions;
        public decimal? InterestedPartyContributions { get { return _interestedPartyContributions; } set { _interestedPartyContributions = value; } }
        private Value<string> _investorLoanNumber;
        public string InvestorLoanNumber { get { return _investorLoanNumber; } set { _investorLoanNumber = value; } }
        private Value<string> _levelOfPropertyReviewType;
        public string LevelOfPropertyReviewType { get { return _levelOfPropertyReviewType; } set { _levelOfPropertyReviewType = value; } }
        private Value<string> _lpDocClass;
        public string LpDocClass { get { return _lpDocClass; } set { _lpDocClass = value; } }
        private Value<string> _mortgageOriginator;
        public string MortgageOriginator { get { return _mortgageOriginator; } set { _mortgageOriginator = value; } }
        private Value<DateTime?> _noteDate;
        public DateTime? NoteDate { get { return _noteDate; } set { _noteDate = value; } }
        private Value<string> _noteRateType;
        public string NoteRateType { get { return _noteRateType; } set { _noteRateType = value; } }
        private Value<int?> _numberOfBorrowers;
        public int? NumberOfBorrowers { get { return _numberOfBorrowers; } set { _numberOfBorrowers = value; } }
        private Value<int?> _numberOfMonthsReserves;
        public int? NumberOfMonthsReserves { get { return _numberOfMonthsReserves; } set { _numberOfMonthsReserves = value; } }
        private Value<decimal?> _originalAmountOfFirstMortgage;
        public decimal? OriginalAmountOfFirstMortgage { get { return _originalAmountOfFirstMortgage; } set { _originalAmountOfFirstMortgage = value; } }
        private Value<string> _otherTypeDescription;
        public string OtherTypeDescription { get { return _otherTypeDescription; } set { _otherTypeDescription = value; } }
        private Value<string> _percentageofCoverage;
        public string PercentageofCoverage { get { return _percentageofCoverage; } set { _percentageofCoverage = value; } }
        private Value<string> _projectName;
        public string ProjectName { get { return _projectName; } set { _projectName = value; } }
        private Value<string> _propertyFormType;
        public string PropertyFormType { get { return _propertyFormType; } set { _propertyFormType = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<decimal?> _required;
        public decimal? Required { get { return _required; } set { _required = value; } }
        private Value<string> _riskAssessmentType;
        public string RiskAssessmentType { get { return _riskAssessmentType; } set { _riskAssessmentType = value; } }
        private Value<string> _sellerAddress;
        public string SellerAddress { get { return _sellerAddress; } set { _sellerAddress = value; } }
        private Value<string> _sellerCity;
        public string SellerCity { get { return _sellerCity; } set { _sellerCity = value; } }
        private Value<string> _sellerContactName;
        public string SellerContactName { get { return _sellerContactName; } set { _sellerContactName = value; } }
        private Value<string> _sellerName;
        public string SellerName { get { return _sellerName; } set { _sellerName = value; } }
        private Value<string> _sellerNumber;
        public string SellerNumber { get { return _sellerNumber; } set { _sellerNumber = value; } }
        private Value<string> _sellerPhone;
        public string SellerPhone { get { return _sellerPhone; } set { _sellerPhone = value; } }
        private Value<string> _sellerPostalCode;
        public string SellerPostalCode { get { return _sellerPostalCode; } set { _sellerPostalCode = value; } }
        private Value<string> _sellerState;
        public string SellerState { get { return _sellerState; } set { _sellerState = value; } }
        private Value<string> _specialFeatureCode1;
        public string SpecialFeatureCode1 { get { return _specialFeatureCode1; } set { _specialFeatureCode1 = value; } }
        private Value<string> _specialFeatureCode2;
        public string SpecialFeatureCode2 { get { return _specialFeatureCode2; } set { _specialFeatureCode2 = value; } }
        private Value<string> _specialFeatureCode3;
        public string SpecialFeatureCode3 { get { return _specialFeatureCode3; } set { _specialFeatureCode3 = value; } }
        private Value<string> _specialFeatureCode4;
        public string SpecialFeatureCode4 { get { return _specialFeatureCode4; } set { _specialFeatureCode4 = value; } }
        private Value<string> _specialFeatureCode5;
        public string SpecialFeatureCode5 { get { return _specialFeatureCode5; } set { _specialFeatureCode5 = value; } }
        private Value<string> _specialFeatureCode6;
        public string SpecialFeatureCode6 { get { return _specialFeatureCode6; } set { _specialFeatureCode6 = value; } }
        private Value<string> _thirdPartyName1;
        public string ThirdPartyName1 { get { return _thirdPartyName1; } set { _thirdPartyName1 = value; } }
        private Value<string> _thirdPartyName2;
        public string ThirdPartyName2 { get { return _thirdPartyName2; } set { _thirdPartyName2 = value; } }
        private Value<string> _typeOfCommitment;
        public string TypeOfCommitment { get { return _typeOfCommitment; } set { _typeOfCommitment = value; } }
        private Value<string> _underwritingComment1;
        public string UnderwritingComment1 { get { return _underwritingComment1; } set { _underwritingComment1 = value; } }
        private Value<string> _underwritingComment2;
        public string UnderwritingComment2 { get { return _underwritingComment2; } set { _underwritingComment2 = value; } }
        private Value<string> _underwritingComment3;
        public string UnderwritingComment3 { get { return _underwritingComment3; } set { _underwritingComment3 = value; } }
        private Value<string> _underwritingComment4;
        public string UnderwritingComment4 { get { return _underwritingComment4; } set { _underwritingComment4 = value; } }
        private Value<string> _underwritingComment5;
        public string UnderwritingComment5 { get { return _underwritingComment5; } set { _underwritingComment5 = value; } }
        private Value<string> _underwritingComment6;
        public string UnderwritingComment6 { get { return _underwritingComment6; } set { _underwritingComment6 = value; } }
        private Value<string> _underwritingComment7;
        public string UnderwritingComment7 { get { return _underwritingComment7; } set { _underwritingComment7 = value; } }
        private Value<string> _underwritingComment8;
        public string UnderwritingComment8 { get { return _underwritingComment8; } set { _underwritingComment8 = value; } }
        private Value<decimal?> _unpaidBalance;
        public decimal? UnpaidBalance { get { return _unpaidBalance; } set { _unpaidBalance = value; } }
        private Value<decimal?> _verified;
        public decimal? Verified { get { return _verified; } set { _verified = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _aboveOrBelowRatePercent.Clean
                    && _adjustorCoverage.Clean
                    && _ausRecommendation.Clean
                    && _bedroomsUnit1.Clean
                    && _bedroomsUnit2.Clean
                    && _bedroomsUnit3.Clean
                    && _bedroomsUnit4.Clean
                    && _certificateNumber.Clean
                    && _commitmentNumber.Clean
                    && _communityLendingAfordableHousingInitiative.Clean
                    && _contactTitle.Clean
                    && _contractNumber.Clean
                    && _cpmProjectId.Clean
                    && _duCaseIdLpAusKey.Clean
                    && _formNumber.Clean
                    && _grossRentUnit1.Clean
                    && _grossRentUnit2.Clean
                    && _grossRentUnit3.Clean
                    && _grossRentUnit4.Clean
                    && _homeBuyersOwnershipEducationCertificateInFile.Clean
                    && _id.Clean
                    && _insurerCode.Clean
                    && _interestedPartyContributions.Clean
                    && _investorLoanNumber.Clean
                    && _levelOfPropertyReviewType.Clean
                    && _lpDocClass.Clean
                    && _mortgageOriginator.Clean
                    && _noteDate.Clean
                    && _noteRateType.Clean
                    && _numberOfBorrowers.Clean
                    && _numberOfMonthsReserves.Clean
                    && _originalAmountOfFirstMortgage.Clean
                    && _otherTypeDescription.Clean
                    && _percentageofCoverage.Clean
                    && _projectName.Clean
                    && _propertyFormType.Clean
                    && _propertyType.Clean
                    && _required.Clean
                    && _riskAssessmentType.Clean
                    && _sellerAddress.Clean
                    && _sellerCity.Clean
                    && _sellerContactName.Clean
                    && _sellerName.Clean
                    && _sellerNumber.Clean
                    && _sellerPhone.Clean
                    && _sellerPostalCode.Clean
                    && _sellerState.Clean
                    && _specialFeatureCode1.Clean
                    && _specialFeatureCode2.Clean
                    && _specialFeatureCode3.Clean
                    && _specialFeatureCode4.Clean
                    && _specialFeatureCode5.Clean
                    && _specialFeatureCode6.Clean
                    && _thirdPartyName1.Clean
                    && _thirdPartyName2.Clean
                    && _typeOfCommitment.Clean
                    && _underwritingComment1.Clean
                    && _underwritingComment2.Clean
                    && _underwritingComment3.Clean
                    && _underwritingComment4.Clean
                    && _underwritingComment5.Clean
                    && _underwritingComment6.Clean
                    && _underwritingComment7.Clean
                    && _underwritingComment8.Clean
                    && _unpaidBalance.Clean
                    && _verified.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var aboveOrBelowRatePercent = _aboveOrBelowRatePercent; aboveOrBelowRatePercent.Clean = value; _aboveOrBelowRatePercent = aboveOrBelowRatePercent;
                var adjustorCoverage = _adjustorCoverage; adjustorCoverage.Clean = value; _adjustorCoverage = adjustorCoverage;
                var ausRecommendation = _ausRecommendation; ausRecommendation.Clean = value; _ausRecommendation = ausRecommendation;
                var bedroomsUnit1 = _bedroomsUnit1; bedroomsUnit1.Clean = value; _bedroomsUnit1 = bedroomsUnit1;
                var bedroomsUnit2 = _bedroomsUnit2; bedroomsUnit2.Clean = value; _bedroomsUnit2 = bedroomsUnit2;
                var bedroomsUnit3 = _bedroomsUnit3; bedroomsUnit3.Clean = value; _bedroomsUnit3 = bedroomsUnit3;
                var bedroomsUnit4 = _bedroomsUnit4; bedroomsUnit4.Clean = value; _bedroomsUnit4 = bedroomsUnit4;
                var certificateNumber = _certificateNumber; certificateNumber.Clean = value; _certificateNumber = certificateNumber;
                var commitmentNumber = _commitmentNumber; commitmentNumber.Clean = value; _commitmentNumber = commitmentNumber;
                var communityLendingAfordableHousingInitiative = _communityLendingAfordableHousingInitiative; communityLendingAfordableHousingInitiative.Clean = value; _communityLendingAfordableHousingInitiative = communityLendingAfordableHousingInitiative;
                var contactTitle = _contactTitle; contactTitle.Clean = value; _contactTitle = contactTitle;
                var contractNumber = _contractNumber; contractNumber.Clean = value; _contractNumber = contractNumber;
                var cpmProjectId = _cpmProjectId; cpmProjectId.Clean = value; _cpmProjectId = cpmProjectId;
                var duCaseIdLpAusKey = _duCaseIdLpAusKey; duCaseIdLpAusKey.Clean = value; _duCaseIdLpAusKey = duCaseIdLpAusKey;
                var formNumber = _formNumber; formNumber.Clean = value; _formNumber = formNumber;
                var grossRentUnit1 = _grossRentUnit1; grossRentUnit1.Clean = value; _grossRentUnit1 = grossRentUnit1;
                var grossRentUnit2 = _grossRentUnit2; grossRentUnit2.Clean = value; _grossRentUnit2 = grossRentUnit2;
                var grossRentUnit3 = _grossRentUnit3; grossRentUnit3.Clean = value; _grossRentUnit3 = grossRentUnit3;
                var grossRentUnit4 = _grossRentUnit4; grossRentUnit4.Clean = value; _grossRentUnit4 = grossRentUnit4;
                var homeBuyersOwnershipEducationCertificateInFile = _homeBuyersOwnershipEducationCertificateInFile; homeBuyersOwnershipEducationCertificateInFile.Clean = value; _homeBuyersOwnershipEducationCertificateInFile = homeBuyersOwnershipEducationCertificateInFile;
                var id = _id; id.Clean = value; _id = id;
                var insurerCode = _insurerCode; insurerCode.Clean = value; _insurerCode = insurerCode;
                var interestedPartyContributions = _interestedPartyContributions; interestedPartyContributions.Clean = value; _interestedPartyContributions = interestedPartyContributions;
                var investorLoanNumber = _investorLoanNumber; investorLoanNumber.Clean = value; _investorLoanNumber = investorLoanNumber;
                var levelOfPropertyReviewType = _levelOfPropertyReviewType; levelOfPropertyReviewType.Clean = value; _levelOfPropertyReviewType = levelOfPropertyReviewType;
                var lpDocClass = _lpDocClass; lpDocClass.Clean = value; _lpDocClass = lpDocClass;
                var mortgageOriginator = _mortgageOriginator; mortgageOriginator.Clean = value; _mortgageOriginator = mortgageOriginator;
                var noteDate = _noteDate; noteDate.Clean = value; _noteDate = noteDate;
                var noteRateType = _noteRateType; noteRateType.Clean = value; _noteRateType = noteRateType;
                var numberOfBorrowers = _numberOfBorrowers; numberOfBorrowers.Clean = value; _numberOfBorrowers = numberOfBorrowers;
                var numberOfMonthsReserves = _numberOfMonthsReserves; numberOfMonthsReserves.Clean = value; _numberOfMonthsReserves = numberOfMonthsReserves;
                var originalAmountOfFirstMortgage = _originalAmountOfFirstMortgage; originalAmountOfFirstMortgage.Clean = value; _originalAmountOfFirstMortgage = originalAmountOfFirstMortgage;
                var otherTypeDescription = _otherTypeDescription; otherTypeDescription.Clean = value; _otherTypeDescription = otherTypeDescription;
                var percentageofCoverage = _percentageofCoverage; percentageofCoverage.Clean = value; _percentageofCoverage = percentageofCoverage;
                var projectName = _projectName; projectName.Clean = value; _projectName = projectName;
                var propertyFormType = _propertyFormType; propertyFormType.Clean = value; _propertyFormType = propertyFormType;
                var propertyType = _propertyType; propertyType.Clean = value; _propertyType = propertyType;
                var required = _required; required.Clean = value; _required = required;
                var riskAssessmentType = _riskAssessmentType; riskAssessmentType.Clean = value; _riskAssessmentType = riskAssessmentType;
                var sellerAddress = _sellerAddress; sellerAddress.Clean = value; _sellerAddress = sellerAddress;
                var sellerCity = _sellerCity; sellerCity.Clean = value; _sellerCity = sellerCity;
                var sellerContactName = _sellerContactName; sellerContactName.Clean = value; _sellerContactName = sellerContactName;
                var sellerName = _sellerName; sellerName.Clean = value; _sellerName = sellerName;
                var sellerNumber = _sellerNumber; sellerNumber.Clean = value; _sellerNumber = sellerNumber;
                var sellerPhone = _sellerPhone; sellerPhone.Clean = value; _sellerPhone = sellerPhone;
                var sellerPostalCode = _sellerPostalCode; sellerPostalCode.Clean = value; _sellerPostalCode = sellerPostalCode;
                var sellerState = _sellerState; sellerState.Clean = value; _sellerState = sellerState;
                var specialFeatureCode1 = _specialFeatureCode1; specialFeatureCode1.Clean = value; _specialFeatureCode1 = specialFeatureCode1;
                var specialFeatureCode2 = _specialFeatureCode2; specialFeatureCode2.Clean = value; _specialFeatureCode2 = specialFeatureCode2;
                var specialFeatureCode3 = _specialFeatureCode3; specialFeatureCode3.Clean = value; _specialFeatureCode3 = specialFeatureCode3;
                var specialFeatureCode4 = _specialFeatureCode4; specialFeatureCode4.Clean = value; _specialFeatureCode4 = specialFeatureCode4;
                var specialFeatureCode5 = _specialFeatureCode5; specialFeatureCode5.Clean = value; _specialFeatureCode5 = specialFeatureCode5;
                var specialFeatureCode6 = _specialFeatureCode6; specialFeatureCode6.Clean = value; _specialFeatureCode6 = specialFeatureCode6;
                var thirdPartyName1 = _thirdPartyName1; thirdPartyName1.Clean = value; _thirdPartyName1 = thirdPartyName1;
                var thirdPartyName2 = _thirdPartyName2; thirdPartyName2.Clean = value; _thirdPartyName2 = thirdPartyName2;
                var typeOfCommitment = _typeOfCommitment; typeOfCommitment.Clean = value; _typeOfCommitment = typeOfCommitment;
                var underwritingComment1 = _underwritingComment1; underwritingComment1.Clean = value; _underwritingComment1 = underwritingComment1;
                var underwritingComment2 = _underwritingComment2; underwritingComment2.Clean = value; _underwritingComment2 = underwritingComment2;
                var underwritingComment3 = _underwritingComment3; underwritingComment3.Clean = value; _underwritingComment3 = underwritingComment3;
                var underwritingComment4 = _underwritingComment4; underwritingComment4.Clean = value; _underwritingComment4 = underwritingComment4;
                var underwritingComment5 = _underwritingComment5; underwritingComment5.Clean = value; _underwritingComment5 = underwritingComment5;
                var underwritingComment6 = _underwritingComment6; underwritingComment6.Clean = value; _underwritingComment6 = underwritingComment6;
                var underwritingComment7 = _underwritingComment7; underwritingComment7.Clean = value; _underwritingComment7 = underwritingComment7;
                var underwritingComment8 = _underwritingComment8; underwritingComment8.Clean = value; _underwritingComment8 = underwritingComment8;
                var unpaidBalance = _unpaidBalance; unpaidBalance.Clean = value; _unpaidBalance = unpaidBalance;
                var verified = _verified; verified.Clean = value; _verified = verified;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Tsum()
        {
            Clean = true;
        }
    }
}