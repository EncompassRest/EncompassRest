using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ConstructionManagement
    {
        public Value<string> AdditionalDisbursementsConditions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalDisbursementsConditions() => !AdditionalDisbursementsConditions.Clean;
        public Value<DateTime?> ArchitectsCertificateDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchitectsCertificateDate() => !ArchitectsCertificateDate.Clean;
        public Value<bool?> ArchitectsCertificateIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeArchitectsCertificateIndicator() => !ArchitectsCertificateIndicator.Clean;
        public Value<decimal?> AsCompletedAppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsCompletedAppraisedValue() => !AsCompletedAppraisedValue.Clean;
        public Value<decimal?> AsCompletedPurchasePrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAsCompletedPurchasePrice() => !AsCompletedPurchasePrice.Clean;
        public Value<DateTime?> BudgetDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBudgetDate() => !BudgetDate.Clean;
        public Value<bool?> BudgetIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBudgetIndicator() => !BudgetIndicator.Clean;
        public Value<DateTime?> CommitmentExpirationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentExpirationDate() => !CommitmentExpirationDate.Clean;
        public Value<DateTime?> CommitmentLetterDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCommitmentLetterDate() => !CommitmentLetterDate.Clean;
        public Value<DateTime?> ConstCompletionDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstCompletionDate() => !ConstCompletionDate.Clean;
        public Value<string> ConstOnlyAmortizationType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstOnlyAmortizationType() => !ConstOnlyAmortizationType.Clean;
        public Value<bool?> ConstructionContractIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionContractIndicator() => !ConstructionContractIndicator.Clean;
        public Value<DateTime?> ConstructionContractIssuedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionContractIssuedDate() => !ConstructionContractIssuedDate.Clean;
        public Value<DateTime?> ConstructionContractReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionContractReceivedDate() => !ConstructionContractReceivedDate.Clean;
        public Value<bool?> ConstructionPeriodIncludedInLoanTermFlag { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeConstructionPeriodIncludedInLoanTermFlag() => !ConstructionPeriodIncludedInLoanTermFlag.Clean;
        public Value<DateTime?> ContractorsAgreementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractorsAgreementDate() => !ContractorsAgreementDate.Clean;
        public Value<bool?> ContractorsAgreementIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeContractorsAgreementIndicator() => !ContractorsAgreementIndicator.Clean;
        public Value<DateTime?> EnvironmentalAssessmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnvironmentalAssessmentDate() => !EnvironmentalAssessmentDate.Clean;
        public Value<bool?> EnvironmentalAssessmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEnvironmentalAssessmentIndicator() => !EnvironmentalAssessmentIndicator.Clean;
        public Value<DateTime?> FloodHazardDeterminationDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodHazardDeterminationDate() => !FloodHazardDeterminationDate.Clean;
        public Value<bool?> FloodHazardDeterminationIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodHazardDeterminationIndicator() => !FloodHazardDeterminationIndicator.Clean;
        public Value<int?> FutureAdvancePeriod { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFutureAdvancePeriod() => !FutureAdvancePeriod.Clean;
        public Value<decimal?> HoldbackAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoldbackAmount() => !HoldbackAmount.Clean;
        public Value<decimal?> HoldbackPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHoldbackPercent() => !HoldbackPercent.Clean;
        public Value<DateTime?> LienAgentNorthCarolinaDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienAgentNorthCarolinaDate() => !LienAgentNorthCarolinaDate.Clean;
        public Value<bool?> LienAgentNorthCarolinaIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLienAgentNorthCarolinaIndicator() => !LienAgentNorthCarolinaIndicator.Clean;
        public Value<DateTime?> ListOfConstructionAgreementsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeListOfConstructionAgreementsDate() => !ListOfConstructionAgreementsDate.Clean;
        public Value<bool?> ListOfConstructionAgreementsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeListOfConstructionAgreementsIndicator() => !ListOfConstructionAgreementsIndicator.Clean;
        public Value<decimal?> MaxLTVPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLTVPercent() => !MaxLTVPercent.Clean;
        public Value<int?> MinimumDaysBetweenDisbursements { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumDaysBetweenDisbursements() => !MinimumDaysBetweenDisbursements.Clean;
        public Value<DateTime?> OtherDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDate() => !OtherDate.Clean;
        public Value<string> OtherDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !OtherDescription.Clean;
        public Value<bool?> OtherIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIndicator() => !OtherIndicator.Clean;
        public Value<string> PartialPrepaymentsElection { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPrepaymentsElection() => !PartialPrepaymentsElection.Clean;
        public Value<DateTime?> PaymentAndPerformanceBondsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAndPerformanceBondsDate() => !PaymentAndPerformanceBondsDate.Clean;
        public Value<bool?> PaymentAndPerformanceBondsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentAndPerformanceBondsIndicator() => !PaymentAndPerformanceBondsIndicator.Clean;
        public Value<DateTime?> PercolationTestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercolationTestDate() => !PercolationTestDate.Clean;
        public Value<bool?> PercolationTestIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePercolationTestIndicator() => !PercolationTestIndicator.Clean;
        public Value<DateTime?> PermitsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePermitsDate() => !PermitsDate.Clean;
        public Value<bool?> PermitsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePermitsIndicator() => !PermitsIndicator.Clean;
        public Value<DateTime?> PlansAndSpecificationsDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlansAndSpecificationsDate() => !PlansAndSpecificationsDate.Clean;
        public Value<bool?> PlansAndSpecificationsIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePlansAndSpecificationsIndicator() => !PlansAndSpecificationsIndicator.Clean;
        public Value<decimal?> ProjectDelaySurchargePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProjectDelaySurchargePercent() => !ProjectDelaySurchargePercent.Clean;
        public Value<int?> ReturnLendersCopyCommitmentDays { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReturnLendersCopyCommitmentDays() => !ReturnLendersCopyCommitmentDays.Clean;
        public Value<bool?> SecuredBySeparateProperty { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSecuredBySeparateProperty() => !SecuredBySeparateProperty.Clean;
        public Value<DateTime?> SoilReportDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSoilReportDate() => !SoilReportDate.Clean;
        public Value<bool?> SoilReportIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSoilReportIndicator() => !SoilReportIndicator.Clean;
        public Value<DateTime?> SurveyDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSurveyDate() => !SurveyDate.Clean;
        public Value<bool?> SurveyIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSurveyIndicator() => !SurveyIndicator.Clean;
        public Value<DateTime?> TakeOutCommitmentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutCommitmentDate() => !TakeOutCommitmentDate.Clean;
        public Value<bool?> TakeOutCommitmentIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutCommitmentIndicator() => !TakeOutCommitmentIndicator.Clean;
        public Value<DateTime?> TakeOutCommitmentIssuedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutCommitmentIssuedDate() => !TakeOutCommitmentIssuedDate.Clean;
        public Value<string> TakeOutLenderAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderAddress() => !TakeOutLenderAddress.Clean;
        public Value<string> TakeOutLenderCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderCity() => !TakeOutLenderCity.Clean;
        public Value<string> TakeOutLenderContactName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderContactName() => !TakeOutLenderContactName.Clean;
        public Value<string> TakeOutLenderContactTitle { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderContactTitle() => !TakeOutLenderContactTitle.Clean;
        public Value<string> TakeOutLenderEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderEmail() => !TakeOutLenderEmail.Clean;
        public Value<string> TakeOutLenderFax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderFax() => !TakeOutLenderFax.Clean;
        public Value<string> TakeOutLenderLicenseNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderLicenseNumber() => !TakeOutLenderLicenseNumber.Clean;
        public Value<string> TakeOutLenderName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderName() => !TakeOutLenderName.Clean;
        public Value<string> TakeOutLenderNMLSNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderNMLSNumber() => !TakeOutLenderNMLSNumber.Clean;
        public Value<string> TakeOutLenderPhone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderPhone() => !TakeOutLenderPhone.Clean;
        public Value<string> TakeOutLenderState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderState() => !TakeOutLenderState.Clean;
        public Value<string> TakeOutLenderZip { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTakeOutLenderZip() => !TakeOutLenderZip.Clean;
        public Value<DateTime?> TitleInsuranceDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleInsuranceDate() => !TitleInsuranceDate.Clean;
        public Value<bool?> TitleInsuranceIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleInsuranceIndicator() => !TitleInsuranceIndicator.Clean;
        public Value<DateTime?> UtilityLettersDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilityLettersDate() => !UtilityLettersDate.Clean;
        public Value<bool?> UtilityLettersIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUtilityLettersIndicator() => !UtilityLettersIndicator.Clean;
        public Value<DateTime?> WaterTestDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWaterTestDate() => !WaterTestDate.Clean;
        public Value<bool?> WaterTestIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWaterTestIndicator() => !WaterTestIndicator.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalDisbursementsConditions.Clean
                    && ArchitectsCertificateDate.Clean
                    && ArchitectsCertificateIndicator.Clean
                    && AsCompletedAppraisedValue.Clean
                    && AsCompletedPurchasePrice.Clean
                    && BudgetDate.Clean
                    && BudgetIndicator.Clean
                    && CommitmentExpirationDate.Clean
                    && CommitmentLetterDate.Clean
                    && ConstCompletionDate.Clean
                    && ConstOnlyAmortizationType.Clean
                    && ConstructionContractIndicator.Clean
                    && ConstructionContractIssuedDate.Clean
                    && ConstructionContractReceivedDate.Clean
                    && ConstructionPeriodIncludedInLoanTermFlag.Clean
                    && ContractorsAgreementDate.Clean
                    && ContractorsAgreementIndicator.Clean
                    && EnvironmentalAssessmentDate.Clean
                    && EnvironmentalAssessmentIndicator.Clean
                    && FloodHazardDeterminationDate.Clean
                    && FloodHazardDeterminationIndicator.Clean
                    && FutureAdvancePeriod.Clean
                    && HoldbackAmount.Clean
                    && HoldbackPercent.Clean
                    && LienAgentNorthCarolinaDate.Clean
                    && LienAgentNorthCarolinaIndicator.Clean
                    && ListOfConstructionAgreementsDate.Clean
                    && ListOfConstructionAgreementsIndicator.Clean
                    && MaxLTVPercent.Clean
                    && MinimumDaysBetweenDisbursements.Clean
                    && OtherDate.Clean
                    && OtherDescription.Clean
                    && OtherIndicator.Clean
                    && PartialPrepaymentsElection.Clean
                    && PaymentAndPerformanceBondsDate.Clean
                    && PaymentAndPerformanceBondsIndicator.Clean
                    && PercolationTestDate.Clean
                    && PercolationTestIndicator.Clean
                    && PermitsDate.Clean
                    && PermitsIndicator.Clean
                    && PlansAndSpecificationsDate.Clean
                    && PlansAndSpecificationsIndicator.Clean
                    && ProjectDelaySurchargePercent.Clean
                    && ReturnLendersCopyCommitmentDays.Clean
                    && SecuredBySeparateProperty.Clean
                    && SoilReportDate.Clean
                    && SoilReportIndicator.Clean
                    && SurveyDate.Clean
                    && SurveyIndicator.Clean
                    && TakeOutCommitmentDate.Clean
                    && TakeOutCommitmentIndicator.Clean
                    && TakeOutCommitmentIssuedDate.Clean
                    && TakeOutLenderAddress.Clean
                    && TakeOutLenderCity.Clean
                    && TakeOutLenderContactName.Clean
                    && TakeOutLenderContactTitle.Clean
                    && TakeOutLenderEmail.Clean
                    && TakeOutLenderFax.Clean
                    && TakeOutLenderLicenseNumber.Clean
                    && TakeOutLenderName.Clean
                    && TakeOutLenderNMLSNumber.Clean
                    && TakeOutLenderPhone.Clean
                    && TakeOutLenderState.Clean
                    && TakeOutLenderZip.Clean
                    && TitleInsuranceDate.Clean
                    && TitleInsuranceIndicator.Clean
                    && UtilityLettersDate.Clean
                    && UtilityLettersIndicator.Clean
                    && WaterTestDate.Clean
                    && WaterTestIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalDisbursementsConditions; v0.Clean = value; AdditionalDisbursementsConditions = v0;
                var v1 = ArchitectsCertificateDate; v1.Clean = value; ArchitectsCertificateDate = v1;
                var v2 = ArchitectsCertificateIndicator; v2.Clean = value; ArchitectsCertificateIndicator = v2;
                var v3 = AsCompletedAppraisedValue; v3.Clean = value; AsCompletedAppraisedValue = v3;
                var v4 = AsCompletedPurchasePrice; v4.Clean = value; AsCompletedPurchasePrice = v4;
                var v5 = BudgetDate; v5.Clean = value; BudgetDate = v5;
                var v6 = BudgetIndicator; v6.Clean = value; BudgetIndicator = v6;
                var v7 = CommitmentExpirationDate; v7.Clean = value; CommitmentExpirationDate = v7;
                var v8 = CommitmentLetterDate; v8.Clean = value; CommitmentLetterDate = v8;
                var v9 = ConstCompletionDate; v9.Clean = value; ConstCompletionDate = v9;
                var v10 = ConstOnlyAmortizationType; v10.Clean = value; ConstOnlyAmortizationType = v10;
                var v11 = ConstructionContractIndicator; v11.Clean = value; ConstructionContractIndicator = v11;
                var v12 = ConstructionContractIssuedDate; v12.Clean = value; ConstructionContractIssuedDate = v12;
                var v13 = ConstructionContractReceivedDate; v13.Clean = value; ConstructionContractReceivedDate = v13;
                var v14 = ConstructionPeriodIncludedInLoanTermFlag; v14.Clean = value; ConstructionPeriodIncludedInLoanTermFlag = v14;
                var v15 = ContractorsAgreementDate; v15.Clean = value; ContractorsAgreementDate = v15;
                var v16 = ContractorsAgreementIndicator; v16.Clean = value; ContractorsAgreementIndicator = v16;
                var v17 = EnvironmentalAssessmentDate; v17.Clean = value; EnvironmentalAssessmentDate = v17;
                var v18 = EnvironmentalAssessmentIndicator; v18.Clean = value; EnvironmentalAssessmentIndicator = v18;
                var v19 = FloodHazardDeterminationDate; v19.Clean = value; FloodHazardDeterminationDate = v19;
                var v20 = FloodHazardDeterminationIndicator; v20.Clean = value; FloodHazardDeterminationIndicator = v20;
                var v21 = FutureAdvancePeriod; v21.Clean = value; FutureAdvancePeriod = v21;
                var v22 = HoldbackAmount; v22.Clean = value; HoldbackAmount = v22;
                var v23 = HoldbackPercent; v23.Clean = value; HoldbackPercent = v23;
                var v24 = LienAgentNorthCarolinaDate; v24.Clean = value; LienAgentNorthCarolinaDate = v24;
                var v25 = LienAgentNorthCarolinaIndicator; v25.Clean = value; LienAgentNorthCarolinaIndicator = v25;
                var v26 = ListOfConstructionAgreementsDate; v26.Clean = value; ListOfConstructionAgreementsDate = v26;
                var v27 = ListOfConstructionAgreementsIndicator; v27.Clean = value; ListOfConstructionAgreementsIndicator = v27;
                var v28 = MaxLTVPercent; v28.Clean = value; MaxLTVPercent = v28;
                var v29 = MinimumDaysBetweenDisbursements; v29.Clean = value; MinimumDaysBetweenDisbursements = v29;
                var v30 = OtherDate; v30.Clean = value; OtherDate = v30;
                var v31 = OtherDescription; v31.Clean = value; OtherDescription = v31;
                var v32 = OtherIndicator; v32.Clean = value; OtherIndicator = v32;
                var v33 = PartialPrepaymentsElection; v33.Clean = value; PartialPrepaymentsElection = v33;
                var v34 = PaymentAndPerformanceBondsDate; v34.Clean = value; PaymentAndPerformanceBondsDate = v34;
                var v35 = PaymentAndPerformanceBondsIndicator; v35.Clean = value; PaymentAndPerformanceBondsIndicator = v35;
                var v36 = PercolationTestDate; v36.Clean = value; PercolationTestDate = v36;
                var v37 = PercolationTestIndicator; v37.Clean = value; PercolationTestIndicator = v37;
                var v38 = PermitsDate; v38.Clean = value; PermitsDate = v38;
                var v39 = PermitsIndicator; v39.Clean = value; PermitsIndicator = v39;
                var v40 = PlansAndSpecificationsDate; v40.Clean = value; PlansAndSpecificationsDate = v40;
                var v41 = PlansAndSpecificationsIndicator; v41.Clean = value; PlansAndSpecificationsIndicator = v41;
                var v42 = ProjectDelaySurchargePercent; v42.Clean = value; ProjectDelaySurchargePercent = v42;
                var v43 = ReturnLendersCopyCommitmentDays; v43.Clean = value; ReturnLendersCopyCommitmentDays = v43;
                var v44 = SecuredBySeparateProperty; v44.Clean = value; SecuredBySeparateProperty = v44;
                var v45 = SoilReportDate; v45.Clean = value; SoilReportDate = v45;
                var v46 = SoilReportIndicator; v46.Clean = value; SoilReportIndicator = v46;
                var v47 = SurveyDate; v47.Clean = value; SurveyDate = v47;
                var v48 = SurveyIndicator; v48.Clean = value; SurveyIndicator = v48;
                var v49 = TakeOutCommitmentDate; v49.Clean = value; TakeOutCommitmentDate = v49;
                var v50 = TakeOutCommitmentIndicator; v50.Clean = value; TakeOutCommitmentIndicator = v50;
                var v51 = TakeOutCommitmentIssuedDate; v51.Clean = value; TakeOutCommitmentIssuedDate = v51;
                var v52 = TakeOutLenderAddress; v52.Clean = value; TakeOutLenderAddress = v52;
                var v53 = TakeOutLenderCity; v53.Clean = value; TakeOutLenderCity = v53;
                var v54 = TakeOutLenderContactName; v54.Clean = value; TakeOutLenderContactName = v54;
                var v55 = TakeOutLenderContactTitle; v55.Clean = value; TakeOutLenderContactTitle = v55;
                var v56 = TakeOutLenderEmail; v56.Clean = value; TakeOutLenderEmail = v56;
                var v57 = TakeOutLenderFax; v57.Clean = value; TakeOutLenderFax = v57;
                var v58 = TakeOutLenderLicenseNumber; v58.Clean = value; TakeOutLenderLicenseNumber = v58;
                var v59 = TakeOutLenderName; v59.Clean = value; TakeOutLenderName = v59;
                var v60 = TakeOutLenderNMLSNumber; v60.Clean = value; TakeOutLenderNMLSNumber = v60;
                var v61 = TakeOutLenderPhone; v61.Clean = value; TakeOutLenderPhone = v61;
                var v62 = TakeOutLenderState; v62.Clean = value; TakeOutLenderState = v62;
                var v63 = TakeOutLenderZip; v63.Clean = value; TakeOutLenderZip = v63;
                var v64 = TitleInsuranceDate; v64.Clean = value; TitleInsuranceDate = v64;
                var v65 = TitleInsuranceIndicator; v65.Clean = value; TitleInsuranceIndicator = v65;
                var v66 = UtilityLettersDate; v66.Clean = value; UtilityLettersDate = v66;
                var v67 = UtilityLettersIndicator; v67.Clean = value; UtilityLettersIndicator = v67;
                var v68 = WaterTestDate; v68.Clean = value; WaterTestDate = v68;
                var v69 = WaterTestIndicator; v69.Clean = value; WaterTestIndicator = v69;
                _settingClean = 0;
            }
        }
    }
}