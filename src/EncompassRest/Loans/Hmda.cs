using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Hmda
    {
        public Value<string> ActionTaken { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActionTaken() => !ActionTaken.Clean;
        public Value<string> ApplicationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApplicationDate() => !ApplicationDate.Clean;
        public Value<string> AUS1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUS1() => !AUS1.Clean;
        public Value<string> AUS2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUS2() => !AUS2.Clean;
        public Value<string> AUS3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUS3() => !AUS3.Clean;
        public Value<string> AUS4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUS4() => !AUS4.Clean;
        public Value<string> AUS5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUS5() => !AUS5.Clean;
        public Value<string> AUSRecommendation1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation1() => !AUSRecommendation1.Clean;
        public Value<string> AUSRecommendation2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation2() => !AUSRecommendation2.Clean;
        public Value<string> AUSRecommendation3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation3() => !AUSRecommendation3.Clean;
        public Value<string> AUSRecommendation4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation4() => !AUSRecommendation4.Clean;
        public Value<string> AUSRecommendation5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAUSRecommendation5() => !AUSRecommendation5.Clean;
        public Value<string> BusinessOrCommercialPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBusinessOrCommercialPurpose() => !BusinessOrCommercialPurpose.Clean;
        public Value<string> CensusTrack { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCensusTrack() => !CensusTrack.Clean;
        public Value<decimal?> CLTV { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCLTV() => !CLTV.Clean;
        public Value<string> ContactEmailAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactEmailAddress() => !ContactEmailAddress.Clean;
        public Value<string> ContactFaxNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactFaxNumber() => !ContactFaxNumber.Clean;
        public Value<string> ContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactName() => !ContactName.Clean;
        public Value<string> ContactOfficeCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactOfficeCity() => !ContactOfficeCity.Clean;
        public Value<string> ContactOfficeState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactOfficeState() => !ContactOfficeState.Clean;
        public Value<string> ContactOfficeStreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactOfficeStreetAddress() => !ContactOfficeStreetAddress.Clean;
        public Value<string> ContactOfficeZIPCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactOfficeZIPCode() => !ContactOfficeZIPCode.Clean;
        public Value<string> ContactPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContactPhoneNumber() => !ContactPhoneNumber.Clean;
        public Value<string> CountyCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCountyCode() => !CountyCode.Clean;
        public Value<decimal?> DebtToIncomeRatio { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDebtToIncomeRatio() => !DebtToIncomeRatio.Clean;
        public Value<string> DenialReason1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialReason1() => !DenialReason1.Clean;
        public Value<string> DenialReason2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialReason2() => !DenialReason2.Clean;
        public Value<string> DenialReason3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialReason3() => !DenialReason3.Clean;
        public Value<string> DenialReason4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDenialReason4() => !DenialReason4.Clean;
        public Value<decimal?> DiscountPoints { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDiscountPoints() => !DiscountPoints.Clean;
        public Value<bool?> ExcludeLoanFromHMDAReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcludeLoanFromHMDAReportIndicator() => !ExcludeLoanFromHMDAReportIndicator.Clean;
        public Value<string> FederalAgency { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFederalAgency() => !FederalAgency.Clean;
        public Value<string> FederalTaxpayerIdNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFederalTaxpayerIdNumber() => !FederalTaxpayerIdNumber.Clean;
        public Value<string> FinancialInstitutionName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancialInstitutionName() => !FinancialInstitutionName.Clean;
        public Value<string> HmdaPropertyZipCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHmdaPropertyZipCode() => !HmdaPropertyZipCode.Clean;
        public Value<string> HOEPAStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHOEPAStatus() => !HOEPAStatus.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> Income { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIncome() => !Income.Clean;
        public Value<string> InitiallyPayableToYourInstitution { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitiallyPayableToYourInstitution() => !InitiallyPayableToYourInstitution.Clean;
        public Value<decimal?> InterestRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRate() => !InterestRate.Clean;
        public Value<string> IntroRatePeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIntroRatePeriod() => !IntroRatePeriod.Clean;
        public Value<string> LegalEntityIdentifier { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLegalEntityIdentifier() => !LegalEntityIdentifier.Clean;
        public Value<decimal?> LenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderCredits() => !LenderCredits.Clean;
        public Value<string> LienStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienStatus() => !LienStatus.Clean;
        public Value<decimal?> LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !LoanAmount.Clean;
        public Value<string> LoanPurpose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanPurpose() => !LoanPurpose.Clean;
        public Value<string> LoanTerm { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanTerm() => !LoanTerm.Clean;
        public Value<string> LoanType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanType() => !LoanType.Clean;
        public Value<string> ManufacturedHomeLandPropertyInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedHomeLandPropertyInterest() => !ManufacturedHomeLandPropertyInterest.Clean;
        public Value<string> ManufacturedSecuredProperyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeManufacturedSecuredProperyType() => !ManufacturedSecuredProperyType.Clean;
        public Value<string> MSANumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMSANumber() => !MSANumber.Clean;
        public Value<string> MultifamilyNoUnits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMultifamilyNoUnits() => !MultifamilyNoUnits.Clean;
        public Value<string> NMLSLoanOriginatorID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNMLSLoanOriginatorID() => !NMLSLoanOriginatorID.Clean;
        public Value<string> OpenEndLineOfCredit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOpenEndLineOfCredit() => !OpenEndLineOfCredit.Clean;
        public Value<decimal?> OriginationCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOriginationCharges() => !OriginationCharges.Clean;
        public Value<string> OtherAUS { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAUS() => !OtherAUS.Clean;
        public Value<string> OtherAUSRecommendations { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAUSRecommendations() => !OtherAUSRecommendations.Clean;
        public Value<string> OtherDenialReason { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDenialReason() => !OtherDenialReason.Clean;
        public Value<string> OtherNonAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherNonAmortization() => !OtherNonAmortization.Clean;
        public Value<string> ParentAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentAddress() => !ParentAddress.Clean;
        public Value<string> ParentCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentCity() => !ParentCity.Clean;
        public Value<string> ParentName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentName() => !ParentName.Clean;
        public Value<string> ParentState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentState() => !ParentState.Clean;
        public Value<string> ParentZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeParentZip() => !ParentZip.Clean;
        public Value<string> Preapprovals { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePreapprovals() => !Preapprovals.Clean;
        public Value<string> PrepaymentPenaltyPeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPeriod() => !PrepaymentPenaltyPeriod.Clean;
        public Value<string> PropertyType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyType() => !PropertyType.Clean;
        public Value<decimal?> PropertyValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyValue() => !PropertyValue.Clean;
        public Value<string> QMStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQMStatus() => !QMStatus.Clean;
        public Value<decimal?> RateSpread { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateSpread() => !RateSpread.Clean;
        public Value<int?> ReportingYear { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportingYear() => !ReportingYear.Clean;
        public Value<bool?> ReportPurposeOfLoanIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReportPurposeOfLoanIndicator() => !ReportPurposeOfLoanIndicator.Clean;
        public Value<string> RespondentID { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRespondentID() => !RespondentID.Clean;
        public Value<string> ReverseMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReverseMortgage() => !ReverseMortgage.Clean;
        public Value<string> StateCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStateCode() => !StateCode.Clean;
        public Value<string> SubmissionOfApplication { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubmissionOfApplication() => !SubmissionOfApplication.Clean;
        public Value<decimal?> TotalLoanCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanCosts() => !TotalLoanCosts.Clean;
        public Value<decimal?> TotalPointsAndFees { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPointsAndFees() => !TotalPointsAndFees.Clean;
        public Value<string> TypeOfPurchaser { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTypeOfPurchaser() => !TypeOfPurchaser.Clean;
        public Value<string> UniversalLoanId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUniversalLoanId() => !UniversalLoanId.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActionTaken.Clean
                    && ApplicationDate.Clean
                    && AUS1.Clean
                    && AUS2.Clean
                    && AUS3.Clean
                    && AUS4.Clean
                    && AUS5.Clean
                    && AUSRecommendation1.Clean
                    && AUSRecommendation2.Clean
                    && AUSRecommendation3.Clean
                    && AUSRecommendation4.Clean
                    && AUSRecommendation5.Clean
                    && BusinessOrCommercialPurpose.Clean
                    && CensusTrack.Clean
                    && CLTV.Clean
                    && ContactEmailAddress.Clean
                    && ContactFaxNumber.Clean
                    && ContactName.Clean
                    && ContactOfficeCity.Clean
                    && ContactOfficeState.Clean
                    && ContactOfficeStreetAddress.Clean
                    && ContactOfficeZIPCode.Clean
                    && ContactPhoneNumber.Clean
                    && CountyCode.Clean
                    && DebtToIncomeRatio.Clean
                    && DenialReason1.Clean
                    && DenialReason2.Clean
                    && DenialReason3.Clean
                    && DenialReason4.Clean
                    && DiscountPoints.Clean
                    && ExcludeLoanFromHMDAReportIndicator.Clean
                    && FederalAgency.Clean
                    && FederalTaxpayerIdNumber.Clean
                    && FinancialInstitutionName.Clean
                    && HmdaPropertyZipCode.Clean
                    && HOEPAStatus.Clean
                    && Id.Clean
                    && Income.Clean
                    && InitiallyPayableToYourInstitution.Clean
                    && InterestRate.Clean
                    && IntroRatePeriod.Clean
                    && LegalEntityIdentifier.Clean
                    && LenderCredits.Clean
                    && LienStatus.Clean
                    && LoanAmount.Clean
                    && LoanPurpose.Clean
                    && LoanTerm.Clean
                    && LoanType.Clean
                    && ManufacturedHomeLandPropertyInterest.Clean
                    && ManufacturedSecuredProperyType.Clean
                    && MSANumber.Clean
                    && MultifamilyNoUnits.Clean
                    && NMLSLoanOriginatorID.Clean
                    && OpenEndLineOfCredit.Clean
                    && OriginationCharges.Clean
                    && OtherAUS.Clean
                    && OtherAUSRecommendations.Clean
                    && OtherDenialReason.Clean
                    && OtherNonAmortization.Clean
                    && ParentAddress.Clean
                    && ParentCity.Clean
                    && ParentName.Clean
                    && ParentState.Clean
                    && ParentZip.Clean
                    && Preapprovals.Clean
                    && PrepaymentPenaltyPeriod.Clean
                    && PropertyType.Clean
                    && PropertyValue.Clean
                    && QMStatus.Clean
                    && RateSpread.Clean
                    && ReportingYear.Clean
                    && ReportPurposeOfLoanIndicator.Clean
                    && RespondentID.Clean
                    && ReverseMortgage.Clean
                    && StateCode.Clean
                    && SubmissionOfApplication.Clean
                    && TotalLoanCosts.Clean
                    && TotalPointsAndFees.Clean
                    && TypeOfPurchaser.Clean
                    && UniversalLoanId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActionTaken; v0.Clean = value; ActionTaken = v0;
                var v1 = ApplicationDate; v1.Clean = value; ApplicationDate = v1;
                var v2 = AUS1; v2.Clean = value; AUS1 = v2;
                var v3 = AUS2; v3.Clean = value; AUS2 = v3;
                var v4 = AUS3; v4.Clean = value; AUS3 = v4;
                var v5 = AUS4; v5.Clean = value; AUS4 = v5;
                var v6 = AUS5; v6.Clean = value; AUS5 = v6;
                var v7 = AUSRecommendation1; v7.Clean = value; AUSRecommendation1 = v7;
                var v8 = AUSRecommendation2; v8.Clean = value; AUSRecommendation2 = v8;
                var v9 = AUSRecommendation3; v9.Clean = value; AUSRecommendation3 = v9;
                var v10 = AUSRecommendation4; v10.Clean = value; AUSRecommendation4 = v10;
                var v11 = AUSRecommendation5; v11.Clean = value; AUSRecommendation5 = v11;
                var v12 = BusinessOrCommercialPurpose; v12.Clean = value; BusinessOrCommercialPurpose = v12;
                var v13 = CensusTrack; v13.Clean = value; CensusTrack = v13;
                var v14 = CLTV; v14.Clean = value; CLTV = v14;
                var v15 = ContactEmailAddress; v15.Clean = value; ContactEmailAddress = v15;
                var v16 = ContactFaxNumber; v16.Clean = value; ContactFaxNumber = v16;
                var v17 = ContactName; v17.Clean = value; ContactName = v17;
                var v18 = ContactOfficeCity; v18.Clean = value; ContactOfficeCity = v18;
                var v19 = ContactOfficeState; v19.Clean = value; ContactOfficeState = v19;
                var v20 = ContactOfficeStreetAddress; v20.Clean = value; ContactOfficeStreetAddress = v20;
                var v21 = ContactOfficeZIPCode; v21.Clean = value; ContactOfficeZIPCode = v21;
                var v22 = ContactPhoneNumber; v22.Clean = value; ContactPhoneNumber = v22;
                var v23 = CountyCode; v23.Clean = value; CountyCode = v23;
                var v24 = DebtToIncomeRatio; v24.Clean = value; DebtToIncomeRatio = v24;
                var v25 = DenialReason1; v25.Clean = value; DenialReason1 = v25;
                var v26 = DenialReason2; v26.Clean = value; DenialReason2 = v26;
                var v27 = DenialReason3; v27.Clean = value; DenialReason3 = v27;
                var v28 = DenialReason4; v28.Clean = value; DenialReason4 = v28;
                var v29 = DiscountPoints; v29.Clean = value; DiscountPoints = v29;
                var v30 = ExcludeLoanFromHMDAReportIndicator; v30.Clean = value; ExcludeLoanFromHMDAReportIndicator = v30;
                var v31 = FederalAgency; v31.Clean = value; FederalAgency = v31;
                var v32 = FederalTaxpayerIdNumber; v32.Clean = value; FederalTaxpayerIdNumber = v32;
                var v33 = FinancialInstitutionName; v33.Clean = value; FinancialInstitutionName = v33;
                var v34 = HmdaPropertyZipCode; v34.Clean = value; HmdaPropertyZipCode = v34;
                var v35 = HOEPAStatus; v35.Clean = value; HOEPAStatus = v35;
                var v36 = Id; v36.Clean = value; Id = v36;
                var v37 = Income; v37.Clean = value; Income = v37;
                var v38 = InitiallyPayableToYourInstitution; v38.Clean = value; InitiallyPayableToYourInstitution = v38;
                var v39 = InterestRate; v39.Clean = value; InterestRate = v39;
                var v40 = IntroRatePeriod; v40.Clean = value; IntroRatePeriod = v40;
                var v41 = LegalEntityIdentifier; v41.Clean = value; LegalEntityIdentifier = v41;
                var v42 = LenderCredits; v42.Clean = value; LenderCredits = v42;
                var v43 = LienStatus; v43.Clean = value; LienStatus = v43;
                var v44 = LoanAmount; v44.Clean = value; LoanAmount = v44;
                var v45 = LoanPurpose; v45.Clean = value; LoanPurpose = v45;
                var v46 = LoanTerm; v46.Clean = value; LoanTerm = v46;
                var v47 = LoanType; v47.Clean = value; LoanType = v47;
                var v48 = ManufacturedHomeLandPropertyInterest; v48.Clean = value; ManufacturedHomeLandPropertyInterest = v48;
                var v49 = ManufacturedSecuredProperyType; v49.Clean = value; ManufacturedSecuredProperyType = v49;
                var v50 = MSANumber; v50.Clean = value; MSANumber = v50;
                var v51 = MultifamilyNoUnits; v51.Clean = value; MultifamilyNoUnits = v51;
                var v52 = NMLSLoanOriginatorID; v52.Clean = value; NMLSLoanOriginatorID = v52;
                var v53 = OpenEndLineOfCredit; v53.Clean = value; OpenEndLineOfCredit = v53;
                var v54 = OriginationCharges; v54.Clean = value; OriginationCharges = v54;
                var v55 = OtherAUS; v55.Clean = value; OtherAUS = v55;
                var v56 = OtherAUSRecommendations; v56.Clean = value; OtherAUSRecommendations = v56;
                var v57 = OtherDenialReason; v57.Clean = value; OtherDenialReason = v57;
                var v58 = OtherNonAmortization; v58.Clean = value; OtherNonAmortization = v58;
                var v59 = ParentAddress; v59.Clean = value; ParentAddress = v59;
                var v60 = ParentCity; v60.Clean = value; ParentCity = v60;
                var v61 = ParentName; v61.Clean = value; ParentName = v61;
                var v62 = ParentState; v62.Clean = value; ParentState = v62;
                var v63 = ParentZip; v63.Clean = value; ParentZip = v63;
                var v64 = Preapprovals; v64.Clean = value; Preapprovals = v64;
                var v65 = PrepaymentPenaltyPeriod; v65.Clean = value; PrepaymentPenaltyPeriod = v65;
                var v66 = PropertyType; v66.Clean = value; PropertyType = v66;
                var v67 = PropertyValue; v67.Clean = value; PropertyValue = v67;
                var v68 = QMStatus; v68.Clean = value; QMStatus = v68;
                var v69 = RateSpread; v69.Clean = value; RateSpread = v69;
                var v70 = ReportingYear; v70.Clean = value; ReportingYear = v70;
                var v71 = ReportPurposeOfLoanIndicator; v71.Clean = value; ReportPurposeOfLoanIndicator = v71;
                var v72 = RespondentID; v72.Clean = value; RespondentID = v72;
                var v73 = ReverseMortgage; v73.Clean = value; ReverseMortgage = v73;
                var v74 = StateCode; v74.Clean = value; StateCode = v74;
                var v75 = SubmissionOfApplication; v75.Clean = value; SubmissionOfApplication = v75;
                var v76 = TotalLoanCosts; v76.Clean = value; TotalLoanCosts = v76;
                var v77 = TotalPointsAndFees; v77.Clean = value; TotalPointsAndFees = v77;
                var v78 = TypeOfPurchaser; v78.Clean = value; TypeOfPurchaser = v78;
                var v79 = UniversalLoanId; v79.Clean = value; UniversalLoanId = v79;
                _settingClean = 0;
            }
        }
    }
}