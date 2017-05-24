using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Tsum
    {
        public Value<decimal?> AboveOrBelowRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAboveOrBelowRatePercent() => !AboveOrBelowRatePercent.Clean;
        public Value<string> AdjustorCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustorCoverage() => !AdjustorCoverage.Clean;
        public Value<string> AusRecommendation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAusRecommendation() => !AusRecommendation.Clean;
        public Value<int?> BedroomsUnit1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBedroomsUnit1() => !BedroomsUnit1.Clean;
        public Value<int?> BedroomsUnit2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBedroomsUnit2() => !BedroomsUnit2.Clean;
        public Value<int?> BedroomsUnit3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBedroomsUnit3() => !BedroomsUnit3.Clean;
        public Value<int?> BedroomsUnit4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBedroomsUnit4() => !BedroomsUnit4.Clean;
        public Value<string> CertificateNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCertificateNumber() => !CertificateNumber.Clean;
        public Value<string> CommitmentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentNumber() => !CommitmentNumber.Clean;
        public Value<bool?> CommunityLendingAfordableHousingInitiative { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommunityLendingAfordableHousingInitiative() => !CommunityLendingAfordableHousingInitiative.Clean;
        public Value<string> ContactTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactTitle() => !ContactTitle.Clean;
        public Value<string> ContractNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractNumber() => !ContractNumber.Clean;
        public Value<string> CpmProjectId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCpmProjectId() => !CpmProjectId.Clean;
        public Value<string> DuCaseIdLpAusKey { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuCaseIdLpAusKey() => !DuCaseIdLpAusKey.Clean;
        public Value<string> FormNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFormNumber() => !FormNumber.Clean;
        public Value<int?> GrossRentUnit1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossRentUnit1() => !GrossRentUnit1.Clean;
        public Value<int?> GrossRentUnit2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossRentUnit2() => !GrossRentUnit2.Clean;
        public Value<int?> GrossRentUnit3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossRentUnit3() => !GrossRentUnit3.Clean;
        public Value<int?> GrossRentUnit4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossRentUnit4() => !GrossRentUnit4.Clean;
        public Value<string> HomeBuyersOwnershipEducationCertificateInFile { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHomeBuyersOwnershipEducationCertificateInFile() => !HomeBuyersOwnershipEducationCertificateInFile.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InsurerCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsurerCode() => !InsurerCode.Clean;
        public Value<decimal?> InterestedPartyContributions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestedPartyContributions() => !InterestedPartyContributions.Clean;
        public Value<string> InvestorLoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInvestorLoanNumber() => !InvestorLoanNumber.Clean;
        public Value<string> LevelOfPropertyReviewType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLevelOfPropertyReviewType() => !LevelOfPropertyReviewType.Clean;
        public Value<string> LpDocClass { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLpDocClass() => !LpDocClass.Clean;
        public Value<string> MortgageOriginator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageOriginator() => !MortgageOriginator.Clean;
        public Value<DateTime?> NoteDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoteDate() => !NoteDate.Clean;
        public Value<string> NoteRateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNoteRateType() => !NoteRateType.Clean;
        public Value<int?> NumberOfBorrowers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfBorrowers() => !NumberOfBorrowers.Clean;
        public Value<int?> NumberOfMonthsReserves { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMonthsReserves() => !NumberOfMonthsReserves.Clean;
        public Value<decimal?> OriginalAmountOfFirstMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginalAmountOfFirstMortgage() => !OriginalAmountOfFirstMortgage.Clean;
        public Value<string> OtherTypeDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherTypeDescription() => !OtherTypeDescription.Clean;
        public Value<string> PercentageofCoverage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercentageofCoverage() => !PercentageofCoverage.Clean;
        public Value<string> ProjectName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectName() => !ProjectName.Clean;
        public Value<string> PropertyFormType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyFormType() => !PropertyFormType.Clean;
        public Value<string> PropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyType() => !PropertyType.Clean;
        public Value<decimal?> Required { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRequired() => !Required.Clean;
        public Value<string> RiskAssessmentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRiskAssessmentType() => !RiskAssessmentType.Clean;
        public Value<string> SellerAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerAddress() => !SellerAddress.Clean;
        public Value<string> SellerCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerCity() => !SellerCity.Clean;
        public Value<string> SellerContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerContactName() => !SellerContactName.Clean;
        public Value<string> SellerName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerName() => !SellerName.Clean;
        public Value<string> SellerNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerNumber() => !SellerNumber.Clean;
        public Value<string> SellerPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPhone() => !SellerPhone.Clean;
        public Value<string> SellerPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPostalCode() => !SellerPostalCode.Clean;
        public Value<string> SellerState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerState() => !SellerState.Clean;
        public Value<string> SpecialFeatureCode1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode1() => !SpecialFeatureCode1.Clean;
        public Value<string> SpecialFeatureCode2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode2() => !SpecialFeatureCode2.Clean;
        public Value<string> SpecialFeatureCode3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode3() => !SpecialFeatureCode3.Clean;
        public Value<string> SpecialFeatureCode4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode4() => !SpecialFeatureCode4.Clean;
        public Value<string> SpecialFeatureCode5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode5() => !SpecialFeatureCode5.Clean;
        public Value<string> SpecialFeatureCode6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSpecialFeatureCode6() => !SpecialFeatureCode6.Clean;
        public Value<string> ThirdPartyName1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyName1() => !ThirdPartyName1.Clean;
        public Value<string> ThirdPartyName2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeThirdPartyName2() => !ThirdPartyName2.Clean;
        public Value<string> TypeOfCommitment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfCommitment() => !TypeOfCommitment.Clean;
        public Value<string> UnderwritingComment1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment1() => !UnderwritingComment1.Clean;
        public Value<string> UnderwritingComment2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment2() => !UnderwritingComment2.Clean;
        public Value<string> UnderwritingComment3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment3() => !UnderwritingComment3.Clean;
        public Value<string> UnderwritingComment4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment4() => !UnderwritingComment4.Clean;
        public Value<string> UnderwritingComment5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment5() => !UnderwritingComment5.Clean;
        public Value<string> UnderwritingComment6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment6() => !UnderwritingComment6.Clean;
        public Value<string> UnderwritingComment7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment7() => !UnderwritingComment7.Clean;
        public Value<string> UnderwritingComment8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnderwritingComment8() => !UnderwritingComment8.Clean;
        public Value<decimal?> UnpaidBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidBalance() => !UnpaidBalance.Clean;
        public Value<decimal?> Verified { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeVerified() => !Verified.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AboveOrBelowRatePercent.Clean
                    && AdjustorCoverage.Clean
                    && AusRecommendation.Clean
                    && BedroomsUnit1.Clean
                    && BedroomsUnit2.Clean
                    && BedroomsUnit3.Clean
                    && BedroomsUnit4.Clean
                    && CertificateNumber.Clean
                    && CommitmentNumber.Clean
                    && CommunityLendingAfordableHousingInitiative.Clean
                    && ContactTitle.Clean
                    && ContractNumber.Clean
                    && CpmProjectId.Clean
                    && DuCaseIdLpAusKey.Clean
                    && FormNumber.Clean
                    && GrossRentUnit1.Clean
                    && GrossRentUnit2.Clean
                    && GrossRentUnit3.Clean
                    && GrossRentUnit4.Clean
                    && HomeBuyersOwnershipEducationCertificateInFile.Clean
                    && Id.Clean
                    && InsurerCode.Clean
                    && InterestedPartyContributions.Clean
                    && InvestorLoanNumber.Clean
                    && LevelOfPropertyReviewType.Clean
                    && LpDocClass.Clean
                    && MortgageOriginator.Clean
                    && NoteDate.Clean
                    && NoteRateType.Clean
                    && NumberOfBorrowers.Clean
                    && NumberOfMonthsReserves.Clean
                    && OriginalAmountOfFirstMortgage.Clean
                    && OtherTypeDescription.Clean
                    && PercentageofCoverage.Clean
                    && ProjectName.Clean
                    && PropertyFormType.Clean
                    && PropertyType.Clean
                    && Required.Clean
                    && RiskAssessmentType.Clean
                    && SellerAddress.Clean
                    && SellerCity.Clean
                    && SellerContactName.Clean
                    && SellerName.Clean
                    && SellerNumber.Clean
                    && SellerPhone.Clean
                    && SellerPostalCode.Clean
                    && SellerState.Clean
                    && SpecialFeatureCode1.Clean
                    && SpecialFeatureCode2.Clean
                    && SpecialFeatureCode3.Clean
                    && SpecialFeatureCode4.Clean
                    && SpecialFeatureCode5.Clean
                    && SpecialFeatureCode6.Clean
                    && ThirdPartyName1.Clean
                    && ThirdPartyName2.Clean
                    && TypeOfCommitment.Clean
                    && UnderwritingComment1.Clean
                    && UnderwritingComment2.Clean
                    && UnderwritingComment3.Clean
                    && UnderwritingComment4.Clean
                    && UnderwritingComment5.Clean
                    && UnderwritingComment6.Clean
                    && UnderwritingComment7.Clean
                    && UnderwritingComment8.Clean
                    && UnpaidBalance.Clean
                    && Verified.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AboveOrBelowRatePercent; v0.Clean = value; AboveOrBelowRatePercent = v0;
                var v1 = AdjustorCoverage; v1.Clean = value; AdjustorCoverage = v1;
                var v2 = AusRecommendation; v2.Clean = value; AusRecommendation = v2;
                var v3 = BedroomsUnit1; v3.Clean = value; BedroomsUnit1 = v3;
                var v4 = BedroomsUnit2; v4.Clean = value; BedroomsUnit2 = v4;
                var v5 = BedroomsUnit3; v5.Clean = value; BedroomsUnit3 = v5;
                var v6 = BedroomsUnit4; v6.Clean = value; BedroomsUnit4 = v6;
                var v7 = CertificateNumber; v7.Clean = value; CertificateNumber = v7;
                var v8 = CommitmentNumber; v8.Clean = value; CommitmentNumber = v8;
                var v9 = CommunityLendingAfordableHousingInitiative; v9.Clean = value; CommunityLendingAfordableHousingInitiative = v9;
                var v10 = ContactTitle; v10.Clean = value; ContactTitle = v10;
                var v11 = ContractNumber; v11.Clean = value; ContractNumber = v11;
                var v12 = CpmProjectId; v12.Clean = value; CpmProjectId = v12;
                var v13 = DuCaseIdLpAusKey; v13.Clean = value; DuCaseIdLpAusKey = v13;
                var v14 = FormNumber; v14.Clean = value; FormNumber = v14;
                var v15 = GrossRentUnit1; v15.Clean = value; GrossRentUnit1 = v15;
                var v16 = GrossRentUnit2; v16.Clean = value; GrossRentUnit2 = v16;
                var v17 = GrossRentUnit3; v17.Clean = value; GrossRentUnit3 = v17;
                var v18 = GrossRentUnit4; v18.Clean = value; GrossRentUnit4 = v18;
                var v19 = HomeBuyersOwnershipEducationCertificateInFile; v19.Clean = value; HomeBuyersOwnershipEducationCertificateInFile = v19;
                var v20 = Id; v20.Clean = value; Id = v20;
                var v21 = InsurerCode; v21.Clean = value; InsurerCode = v21;
                var v22 = InterestedPartyContributions; v22.Clean = value; InterestedPartyContributions = v22;
                var v23 = InvestorLoanNumber; v23.Clean = value; InvestorLoanNumber = v23;
                var v24 = LevelOfPropertyReviewType; v24.Clean = value; LevelOfPropertyReviewType = v24;
                var v25 = LpDocClass; v25.Clean = value; LpDocClass = v25;
                var v26 = MortgageOriginator; v26.Clean = value; MortgageOriginator = v26;
                var v27 = NoteDate; v27.Clean = value; NoteDate = v27;
                var v28 = NoteRateType; v28.Clean = value; NoteRateType = v28;
                var v29 = NumberOfBorrowers; v29.Clean = value; NumberOfBorrowers = v29;
                var v30 = NumberOfMonthsReserves; v30.Clean = value; NumberOfMonthsReserves = v30;
                var v31 = OriginalAmountOfFirstMortgage; v31.Clean = value; OriginalAmountOfFirstMortgage = v31;
                var v32 = OtherTypeDescription; v32.Clean = value; OtherTypeDescription = v32;
                var v33 = PercentageofCoverage; v33.Clean = value; PercentageofCoverage = v33;
                var v34 = ProjectName; v34.Clean = value; ProjectName = v34;
                var v35 = PropertyFormType; v35.Clean = value; PropertyFormType = v35;
                var v36 = PropertyType; v36.Clean = value; PropertyType = v36;
                var v37 = Required; v37.Clean = value; Required = v37;
                var v38 = RiskAssessmentType; v38.Clean = value; RiskAssessmentType = v38;
                var v39 = SellerAddress; v39.Clean = value; SellerAddress = v39;
                var v40 = SellerCity; v40.Clean = value; SellerCity = v40;
                var v41 = SellerContactName; v41.Clean = value; SellerContactName = v41;
                var v42 = SellerName; v42.Clean = value; SellerName = v42;
                var v43 = SellerNumber; v43.Clean = value; SellerNumber = v43;
                var v44 = SellerPhone; v44.Clean = value; SellerPhone = v44;
                var v45 = SellerPostalCode; v45.Clean = value; SellerPostalCode = v45;
                var v46 = SellerState; v46.Clean = value; SellerState = v46;
                var v47 = SpecialFeatureCode1; v47.Clean = value; SpecialFeatureCode1 = v47;
                var v48 = SpecialFeatureCode2; v48.Clean = value; SpecialFeatureCode2 = v48;
                var v49 = SpecialFeatureCode3; v49.Clean = value; SpecialFeatureCode3 = v49;
                var v50 = SpecialFeatureCode4; v50.Clean = value; SpecialFeatureCode4 = v50;
                var v51 = SpecialFeatureCode5; v51.Clean = value; SpecialFeatureCode5 = v51;
                var v52 = SpecialFeatureCode6; v52.Clean = value; SpecialFeatureCode6 = v52;
                var v53 = ThirdPartyName1; v53.Clean = value; ThirdPartyName1 = v53;
                var v54 = ThirdPartyName2; v54.Clean = value; ThirdPartyName2 = v54;
                var v55 = TypeOfCommitment; v55.Clean = value; TypeOfCommitment = v55;
                var v56 = UnderwritingComment1; v56.Clean = value; UnderwritingComment1 = v56;
                var v57 = UnderwritingComment2; v57.Clean = value; UnderwritingComment2 = v57;
                var v58 = UnderwritingComment3; v58.Clean = value; UnderwritingComment3 = v58;
                var v59 = UnderwritingComment4; v59.Clean = value; UnderwritingComment4 = v59;
                var v60 = UnderwritingComment5; v60.Clean = value; UnderwritingComment5 = v60;
                var v61 = UnderwritingComment6; v61.Clean = value; UnderwritingComment6 = v61;
                var v62 = UnderwritingComment7; v62.Clean = value; UnderwritingComment7 = v62;
                var v63 = UnderwritingComment8; v63.Clean = value; UnderwritingComment8 = v63;
                var v64 = UnpaidBalance; v64.Clean = value; UnpaidBalance = v64;
                var v65 = Verified; v65.Clean = value; Verified = v65;
                _settingClean = 0;
            }
        }
    }
}