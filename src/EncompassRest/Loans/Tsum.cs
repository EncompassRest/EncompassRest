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
                var v0 = _aboveOrBelowRatePercent; v0.Clean = value; _aboveOrBelowRatePercent = v0;
                var v1 = _adjustorCoverage; v1.Clean = value; _adjustorCoverage = v1;
                var v2 = _ausRecommendation; v2.Clean = value; _ausRecommendation = v2;
                var v3 = _bedroomsUnit1; v3.Clean = value; _bedroomsUnit1 = v3;
                var v4 = _bedroomsUnit2; v4.Clean = value; _bedroomsUnit2 = v4;
                var v5 = _bedroomsUnit3; v5.Clean = value; _bedroomsUnit3 = v5;
                var v6 = _bedroomsUnit4; v6.Clean = value; _bedroomsUnit4 = v6;
                var v7 = _certificateNumber; v7.Clean = value; _certificateNumber = v7;
                var v8 = _commitmentNumber; v8.Clean = value; _commitmentNumber = v8;
                var v9 = _communityLendingAfordableHousingInitiative; v9.Clean = value; _communityLendingAfordableHousingInitiative = v9;
                var v10 = _contactTitle; v10.Clean = value; _contactTitle = v10;
                var v11 = _contractNumber; v11.Clean = value; _contractNumber = v11;
                var v12 = _cpmProjectId; v12.Clean = value; _cpmProjectId = v12;
                var v13 = _duCaseIdLpAusKey; v13.Clean = value; _duCaseIdLpAusKey = v13;
                var v14 = _formNumber; v14.Clean = value; _formNumber = v14;
                var v15 = _grossRentUnit1; v15.Clean = value; _grossRentUnit1 = v15;
                var v16 = _grossRentUnit2; v16.Clean = value; _grossRentUnit2 = v16;
                var v17 = _grossRentUnit3; v17.Clean = value; _grossRentUnit3 = v17;
                var v18 = _grossRentUnit4; v18.Clean = value; _grossRentUnit4 = v18;
                var v19 = _homeBuyersOwnershipEducationCertificateInFile; v19.Clean = value; _homeBuyersOwnershipEducationCertificateInFile = v19;
                var v20 = _id; v20.Clean = value; _id = v20;
                var v21 = _insurerCode; v21.Clean = value; _insurerCode = v21;
                var v22 = _interestedPartyContributions; v22.Clean = value; _interestedPartyContributions = v22;
                var v23 = _investorLoanNumber; v23.Clean = value; _investorLoanNumber = v23;
                var v24 = _levelOfPropertyReviewType; v24.Clean = value; _levelOfPropertyReviewType = v24;
                var v25 = _lpDocClass; v25.Clean = value; _lpDocClass = v25;
                var v26 = _mortgageOriginator; v26.Clean = value; _mortgageOriginator = v26;
                var v27 = _noteDate; v27.Clean = value; _noteDate = v27;
                var v28 = _noteRateType; v28.Clean = value; _noteRateType = v28;
                var v29 = _numberOfBorrowers; v29.Clean = value; _numberOfBorrowers = v29;
                var v30 = _numberOfMonthsReserves; v30.Clean = value; _numberOfMonthsReserves = v30;
                var v31 = _originalAmountOfFirstMortgage; v31.Clean = value; _originalAmountOfFirstMortgage = v31;
                var v32 = _otherTypeDescription; v32.Clean = value; _otherTypeDescription = v32;
                var v33 = _percentageofCoverage; v33.Clean = value; _percentageofCoverage = v33;
                var v34 = _projectName; v34.Clean = value; _projectName = v34;
                var v35 = _propertyFormType; v35.Clean = value; _propertyFormType = v35;
                var v36 = _propertyType; v36.Clean = value; _propertyType = v36;
                var v37 = _required; v37.Clean = value; _required = v37;
                var v38 = _riskAssessmentType; v38.Clean = value; _riskAssessmentType = v38;
                var v39 = _sellerAddress; v39.Clean = value; _sellerAddress = v39;
                var v40 = _sellerCity; v40.Clean = value; _sellerCity = v40;
                var v41 = _sellerContactName; v41.Clean = value; _sellerContactName = v41;
                var v42 = _sellerName; v42.Clean = value; _sellerName = v42;
                var v43 = _sellerNumber; v43.Clean = value; _sellerNumber = v43;
                var v44 = _sellerPhone; v44.Clean = value; _sellerPhone = v44;
                var v45 = _sellerPostalCode; v45.Clean = value; _sellerPostalCode = v45;
                var v46 = _sellerState; v46.Clean = value; _sellerState = v46;
                var v47 = _specialFeatureCode1; v47.Clean = value; _specialFeatureCode1 = v47;
                var v48 = _specialFeatureCode2; v48.Clean = value; _specialFeatureCode2 = v48;
                var v49 = _specialFeatureCode3; v49.Clean = value; _specialFeatureCode3 = v49;
                var v50 = _specialFeatureCode4; v50.Clean = value; _specialFeatureCode4 = v50;
                var v51 = _specialFeatureCode5; v51.Clean = value; _specialFeatureCode5 = v51;
                var v52 = _specialFeatureCode6; v52.Clean = value; _specialFeatureCode6 = v52;
                var v53 = _thirdPartyName1; v53.Clean = value; _thirdPartyName1 = v53;
                var v54 = _thirdPartyName2; v54.Clean = value; _thirdPartyName2 = v54;
                var v55 = _typeOfCommitment; v55.Clean = value; _typeOfCommitment = v55;
                var v56 = _underwritingComment1; v56.Clean = value; _underwritingComment1 = v56;
                var v57 = _underwritingComment2; v57.Clean = value; _underwritingComment2 = v57;
                var v58 = _underwritingComment3; v58.Clean = value; _underwritingComment3 = v58;
                var v59 = _underwritingComment4; v59.Clean = value; _underwritingComment4 = v59;
                var v60 = _underwritingComment5; v60.Clean = value; _underwritingComment5 = v60;
                var v61 = _underwritingComment6; v61.Clean = value; _underwritingComment6 = v61;
                var v62 = _underwritingComment7; v62.Clean = value; _underwritingComment7 = v62;
                var v63 = _underwritingComment8; v63.Clean = value; _underwritingComment8 = v63;
                var v64 = _unpaidBalance; v64.Clean = value; _unpaidBalance = v64;
                var v65 = _verified; v65.Clean = value; _verified = v65;
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