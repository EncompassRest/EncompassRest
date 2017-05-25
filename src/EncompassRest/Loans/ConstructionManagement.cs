using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ConstructionManagement : IClean
    {
        private Value<string> _additionalDisbursementsConditions;
        public string AdditionalDisbursementsConditions { get { return _additionalDisbursementsConditions; } set { _additionalDisbursementsConditions = value; } }
        private Value<DateTime?> _architectsCertificateDate;
        public DateTime? ArchitectsCertificateDate { get { return _architectsCertificateDate; } set { _architectsCertificateDate = value; } }
        private Value<bool?> _architectsCertificateIndicator;
        public bool? ArchitectsCertificateIndicator { get { return _architectsCertificateIndicator; } set { _architectsCertificateIndicator = value; } }
        private Value<decimal?> _asCompletedAppraisedValue;
        public decimal? AsCompletedAppraisedValue { get { return _asCompletedAppraisedValue; } set { _asCompletedAppraisedValue = value; } }
        private Value<decimal?> _asCompletedPurchasePrice;
        public decimal? AsCompletedPurchasePrice { get { return _asCompletedPurchasePrice; } set { _asCompletedPurchasePrice = value; } }
        private Value<DateTime?> _budgetDate;
        public DateTime? BudgetDate { get { return _budgetDate; } set { _budgetDate = value; } }
        private Value<bool?> _budgetIndicator;
        public bool? BudgetIndicator { get { return _budgetIndicator; } set { _budgetIndicator = value; } }
        private Value<DateTime?> _commitmentExpirationDate;
        public DateTime? CommitmentExpirationDate { get { return _commitmentExpirationDate; } set { _commitmentExpirationDate = value; } }
        private Value<DateTime?> _commitmentLetterDate;
        public DateTime? CommitmentLetterDate { get { return _commitmentLetterDate; } set { _commitmentLetterDate = value; } }
        private Value<DateTime?> _constCompletionDate;
        public DateTime? ConstCompletionDate { get { return _constCompletionDate; } set { _constCompletionDate = value; } }
        private Value<string> _constOnlyAmortizationType;
        public string ConstOnlyAmortizationType { get { return _constOnlyAmortizationType; } set { _constOnlyAmortizationType = value; } }
        private Value<bool?> _constructionContractIndicator;
        public bool? ConstructionContractIndicator { get { return _constructionContractIndicator; } set { _constructionContractIndicator = value; } }
        private Value<DateTime?> _constructionContractIssuedDate;
        public DateTime? ConstructionContractIssuedDate { get { return _constructionContractIssuedDate; } set { _constructionContractIssuedDate = value; } }
        private Value<DateTime?> _constructionContractReceivedDate;
        public DateTime? ConstructionContractReceivedDate { get { return _constructionContractReceivedDate; } set { _constructionContractReceivedDate = value; } }
        private Value<bool?> _constructionPeriodIncludedInLoanTermFlag;
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get { return _constructionPeriodIncludedInLoanTermFlag; } set { _constructionPeriodIncludedInLoanTermFlag = value; } }
        private Value<DateTime?> _contractorsAgreementDate;
        public DateTime? ContractorsAgreementDate { get { return _contractorsAgreementDate; } set { _contractorsAgreementDate = value; } }
        private Value<bool?> _contractorsAgreementIndicator;
        public bool? ContractorsAgreementIndicator { get { return _contractorsAgreementIndicator; } set { _contractorsAgreementIndicator = value; } }
        private Value<DateTime?> _environmentalAssessmentDate;
        public DateTime? EnvironmentalAssessmentDate { get { return _environmentalAssessmentDate; } set { _environmentalAssessmentDate = value; } }
        private Value<bool?> _environmentalAssessmentIndicator;
        public bool? EnvironmentalAssessmentIndicator { get { return _environmentalAssessmentIndicator; } set { _environmentalAssessmentIndicator = value; } }
        private Value<DateTime?> _floodHazardDeterminationDate;
        public DateTime? FloodHazardDeterminationDate { get { return _floodHazardDeterminationDate; } set { _floodHazardDeterminationDate = value; } }
        private Value<bool?> _floodHazardDeterminationIndicator;
        public bool? FloodHazardDeterminationIndicator { get { return _floodHazardDeterminationIndicator; } set { _floodHazardDeterminationIndicator = value; } }
        private Value<int?> _futureAdvancePeriod;
        public int? FutureAdvancePeriod { get { return _futureAdvancePeriod; } set { _futureAdvancePeriod = value; } }
        private Value<decimal?> _holdbackAmount;
        public decimal? HoldbackAmount { get { return _holdbackAmount; } set { _holdbackAmount = value; } }
        private Value<decimal?> _holdbackPercent;
        public decimal? HoldbackPercent { get { return _holdbackPercent; } set { _holdbackPercent = value; } }
        private Value<DateTime?> _lienAgentNorthCarolinaDate;
        public DateTime? LienAgentNorthCarolinaDate { get { return _lienAgentNorthCarolinaDate; } set { _lienAgentNorthCarolinaDate = value; } }
        private Value<bool?> _lienAgentNorthCarolinaIndicator;
        public bool? LienAgentNorthCarolinaIndicator { get { return _lienAgentNorthCarolinaIndicator; } set { _lienAgentNorthCarolinaIndicator = value; } }
        private Value<DateTime?> _listOfConstructionAgreementsDate;
        public DateTime? ListOfConstructionAgreementsDate { get { return _listOfConstructionAgreementsDate; } set { _listOfConstructionAgreementsDate = value; } }
        private Value<bool?> _listOfConstructionAgreementsIndicator;
        public bool? ListOfConstructionAgreementsIndicator { get { return _listOfConstructionAgreementsIndicator; } set { _listOfConstructionAgreementsIndicator = value; } }
        private Value<decimal?> _maxLTVPercent;
        public decimal? MaxLTVPercent { get { return _maxLTVPercent; } set { _maxLTVPercent = value; } }
        private Value<int?> _minimumDaysBetweenDisbursements;
        public int? MinimumDaysBetweenDisbursements { get { return _minimumDaysBetweenDisbursements; } set { _minimumDaysBetweenDisbursements = value; } }
        private Value<DateTime?> _otherDate;
        public DateTime? OtherDate { get { return _otherDate; } set { _otherDate = value; } }
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private Value<bool?> _otherIndicator;
        public bool? OtherIndicator { get { return _otherIndicator; } set { _otherIndicator = value; } }
        private Value<string> _partialPrepaymentsElection;
        public string PartialPrepaymentsElection { get { return _partialPrepaymentsElection; } set { _partialPrepaymentsElection = value; } }
        private Value<DateTime?> _paymentAndPerformanceBondsDate;
        public DateTime? PaymentAndPerformanceBondsDate { get { return _paymentAndPerformanceBondsDate; } set { _paymentAndPerformanceBondsDate = value; } }
        private Value<bool?> _paymentAndPerformanceBondsIndicator;
        public bool? PaymentAndPerformanceBondsIndicator { get { return _paymentAndPerformanceBondsIndicator; } set { _paymentAndPerformanceBondsIndicator = value; } }
        private Value<DateTime?> _percolationTestDate;
        public DateTime? PercolationTestDate { get { return _percolationTestDate; } set { _percolationTestDate = value; } }
        private Value<bool?> _percolationTestIndicator;
        public bool? PercolationTestIndicator { get { return _percolationTestIndicator; } set { _percolationTestIndicator = value; } }
        private Value<DateTime?> _permitsDate;
        public DateTime? PermitsDate { get { return _permitsDate; } set { _permitsDate = value; } }
        private Value<bool?> _permitsIndicator;
        public bool? PermitsIndicator { get { return _permitsIndicator; } set { _permitsIndicator = value; } }
        private Value<DateTime?> _plansAndSpecificationsDate;
        public DateTime? PlansAndSpecificationsDate { get { return _plansAndSpecificationsDate; } set { _plansAndSpecificationsDate = value; } }
        private Value<bool?> _plansAndSpecificationsIndicator;
        public bool? PlansAndSpecificationsIndicator { get { return _plansAndSpecificationsIndicator; } set { _plansAndSpecificationsIndicator = value; } }
        private Value<decimal?> _projectDelaySurchargePercent;
        public decimal? ProjectDelaySurchargePercent { get { return _projectDelaySurchargePercent; } set { _projectDelaySurchargePercent = value; } }
        private Value<int?> _returnLendersCopyCommitmentDays;
        public int? ReturnLendersCopyCommitmentDays { get { return _returnLendersCopyCommitmentDays; } set { _returnLendersCopyCommitmentDays = value; } }
        private Value<bool?> _securedBySeparateProperty;
        public bool? SecuredBySeparateProperty { get { return _securedBySeparateProperty; } set { _securedBySeparateProperty = value; } }
        private Value<DateTime?> _soilReportDate;
        public DateTime? SoilReportDate { get { return _soilReportDate; } set { _soilReportDate = value; } }
        private Value<bool?> _soilReportIndicator;
        public bool? SoilReportIndicator { get { return _soilReportIndicator; } set { _soilReportIndicator = value; } }
        private Value<DateTime?> _surveyDate;
        public DateTime? SurveyDate { get { return _surveyDate; } set { _surveyDate = value; } }
        private Value<bool?> _surveyIndicator;
        public bool? SurveyIndicator { get { return _surveyIndicator; } set { _surveyIndicator = value; } }
        private Value<DateTime?> _takeOutCommitmentDate;
        public DateTime? TakeOutCommitmentDate { get { return _takeOutCommitmentDate; } set { _takeOutCommitmentDate = value; } }
        private Value<bool?> _takeOutCommitmentIndicator;
        public bool? TakeOutCommitmentIndicator { get { return _takeOutCommitmentIndicator; } set { _takeOutCommitmentIndicator = value; } }
        private Value<DateTime?> _takeOutCommitmentIssuedDate;
        public DateTime? TakeOutCommitmentIssuedDate { get { return _takeOutCommitmentIssuedDate; } set { _takeOutCommitmentIssuedDate = value; } }
        private Value<string> _takeOutLenderAddress;
        public string TakeOutLenderAddress { get { return _takeOutLenderAddress; } set { _takeOutLenderAddress = value; } }
        private Value<string> _takeOutLenderCity;
        public string TakeOutLenderCity { get { return _takeOutLenderCity; } set { _takeOutLenderCity = value; } }
        private Value<string> _takeOutLenderContactName;
        public string TakeOutLenderContactName { get { return _takeOutLenderContactName; } set { _takeOutLenderContactName = value; } }
        private Value<string> _takeOutLenderContactTitle;
        public string TakeOutLenderContactTitle { get { return _takeOutLenderContactTitle; } set { _takeOutLenderContactTitle = value; } }
        private Value<string> _takeOutLenderEmail;
        public string TakeOutLenderEmail { get { return _takeOutLenderEmail; } set { _takeOutLenderEmail = value; } }
        private Value<string> _takeOutLenderFax;
        public string TakeOutLenderFax { get { return _takeOutLenderFax; } set { _takeOutLenderFax = value; } }
        private Value<string> _takeOutLenderLicenseNumber;
        public string TakeOutLenderLicenseNumber { get { return _takeOutLenderLicenseNumber; } set { _takeOutLenderLicenseNumber = value; } }
        private Value<string> _takeOutLenderName;
        public string TakeOutLenderName { get { return _takeOutLenderName; } set { _takeOutLenderName = value; } }
        private Value<string> _takeOutLenderNMLSNumber;
        public string TakeOutLenderNMLSNumber { get { return _takeOutLenderNMLSNumber; } set { _takeOutLenderNMLSNumber = value; } }
        private Value<string> _takeOutLenderPhone;
        public string TakeOutLenderPhone { get { return _takeOutLenderPhone; } set { _takeOutLenderPhone = value; } }
        private Value<string> _takeOutLenderState;
        public string TakeOutLenderState { get { return _takeOutLenderState; } set { _takeOutLenderState = value; } }
        private Value<string> _takeOutLenderZip;
        public string TakeOutLenderZip { get { return _takeOutLenderZip; } set { _takeOutLenderZip = value; } }
        private Value<DateTime?> _titleInsuranceDate;
        public DateTime? TitleInsuranceDate { get { return _titleInsuranceDate; } set { _titleInsuranceDate = value; } }
        private Value<bool?> _titleInsuranceIndicator;
        public bool? TitleInsuranceIndicator { get { return _titleInsuranceIndicator; } set { _titleInsuranceIndicator = value; } }
        private Value<DateTime?> _utilityLettersDate;
        public DateTime? UtilityLettersDate { get { return _utilityLettersDate; } set { _utilityLettersDate = value; } }
        private Value<bool?> _utilityLettersIndicator;
        public bool? UtilityLettersIndicator { get { return _utilityLettersIndicator; } set { _utilityLettersIndicator = value; } }
        private Value<DateTime?> _waterTestDate;
        public DateTime? WaterTestDate { get { return _waterTestDate; } set { _waterTestDate = value; } }
        private Value<bool?> _waterTestIndicator;
        public bool? WaterTestIndicator { get { return _waterTestIndicator; } set { _waterTestIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalDisbursementsConditions.Clean
                    && _architectsCertificateDate.Clean
                    && _architectsCertificateIndicator.Clean
                    && _asCompletedAppraisedValue.Clean
                    && _asCompletedPurchasePrice.Clean
                    && _budgetDate.Clean
                    && _budgetIndicator.Clean
                    && _commitmentExpirationDate.Clean
                    && _commitmentLetterDate.Clean
                    && _constCompletionDate.Clean
                    && _constOnlyAmortizationType.Clean
                    && _constructionContractIndicator.Clean
                    && _constructionContractIssuedDate.Clean
                    && _constructionContractReceivedDate.Clean
                    && _constructionPeriodIncludedInLoanTermFlag.Clean
                    && _contractorsAgreementDate.Clean
                    && _contractorsAgreementIndicator.Clean
                    && _environmentalAssessmentDate.Clean
                    && _environmentalAssessmentIndicator.Clean
                    && _floodHazardDeterminationDate.Clean
                    && _floodHazardDeterminationIndicator.Clean
                    && _futureAdvancePeriod.Clean
                    && _holdbackAmount.Clean
                    && _holdbackPercent.Clean
                    && _lienAgentNorthCarolinaDate.Clean
                    && _lienAgentNorthCarolinaIndicator.Clean
                    && _listOfConstructionAgreementsDate.Clean
                    && _listOfConstructionAgreementsIndicator.Clean
                    && _maxLTVPercent.Clean
                    && _minimumDaysBetweenDisbursements.Clean
                    && _otherDate.Clean
                    && _otherDescription.Clean
                    && _otherIndicator.Clean
                    && _partialPrepaymentsElection.Clean
                    && _paymentAndPerformanceBondsDate.Clean
                    && _paymentAndPerformanceBondsIndicator.Clean
                    && _percolationTestDate.Clean
                    && _percolationTestIndicator.Clean
                    && _permitsDate.Clean
                    && _permitsIndicator.Clean
                    && _plansAndSpecificationsDate.Clean
                    && _plansAndSpecificationsIndicator.Clean
                    && _projectDelaySurchargePercent.Clean
                    && _returnLendersCopyCommitmentDays.Clean
                    && _securedBySeparateProperty.Clean
                    && _soilReportDate.Clean
                    && _soilReportIndicator.Clean
                    && _surveyDate.Clean
                    && _surveyIndicator.Clean
                    && _takeOutCommitmentDate.Clean
                    && _takeOutCommitmentIndicator.Clean
                    && _takeOutCommitmentIssuedDate.Clean
                    && _takeOutLenderAddress.Clean
                    && _takeOutLenderCity.Clean
                    && _takeOutLenderContactName.Clean
                    && _takeOutLenderContactTitle.Clean
                    && _takeOutLenderEmail.Clean
                    && _takeOutLenderFax.Clean
                    && _takeOutLenderLicenseNumber.Clean
                    && _takeOutLenderName.Clean
                    && _takeOutLenderNMLSNumber.Clean
                    && _takeOutLenderPhone.Clean
                    && _takeOutLenderState.Clean
                    && _takeOutLenderZip.Clean
                    && _titleInsuranceDate.Clean
                    && _titleInsuranceIndicator.Clean
                    && _utilityLettersDate.Clean
                    && _utilityLettersIndicator.Clean
                    && _waterTestDate.Clean
                    && _waterTestIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalDisbursementsConditions; v0.Clean = value; _additionalDisbursementsConditions = v0;
                var v1 = _architectsCertificateDate; v1.Clean = value; _architectsCertificateDate = v1;
                var v2 = _architectsCertificateIndicator; v2.Clean = value; _architectsCertificateIndicator = v2;
                var v3 = _asCompletedAppraisedValue; v3.Clean = value; _asCompletedAppraisedValue = v3;
                var v4 = _asCompletedPurchasePrice; v4.Clean = value; _asCompletedPurchasePrice = v4;
                var v5 = _budgetDate; v5.Clean = value; _budgetDate = v5;
                var v6 = _budgetIndicator; v6.Clean = value; _budgetIndicator = v6;
                var v7 = _commitmentExpirationDate; v7.Clean = value; _commitmentExpirationDate = v7;
                var v8 = _commitmentLetterDate; v8.Clean = value; _commitmentLetterDate = v8;
                var v9 = _constCompletionDate; v9.Clean = value; _constCompletionDate = v9;
                var v10 = _constOnlyAmortizationType; v10.Clean = value; _constOnlyAmortizationType = v10;
                var v11 = _constructionContractIndicator; v11.Clean = value; _constructionContractIndicator = v11;
                var v12 = _constructionContractIssuedDate; v12.Clean = value; _constructionContractIssuedDate = v12;
                var v13 = _constructionContractReceivedDate; v13.Clean = value; _constructionContractReceivedDate = v13;
                var v14 = _constructionPeriodIncludedInLoanTermFlag; v14.Clean = value; _constructionPeriodIncludedInLoanTermFlag = v14;
                var v15 = _contractorsAgreementDate; v15.Clean = value; _contractorsAgreementDate = v15;
                var v16 = _contractorsAgreementIndicator; v16.Clean = value; _contractorsAgreementIndicator = v16;
                var v17 = _environmentalAssessmentDate; v17.Clean = value; _environmentalAssessmentDate = v17;
                var v18 = _environmentalAssessmentIndicator; v18.Clean = value; _environmentalAssessmentIndicator = v18;
                var v19 = _floodHazardDeterminationDate; v19.Clean = value; _floodHazardDeterminationDate = v19;
                var v20 = _floodHazardDeterminationIndicator; v20.Clean = value; _floodHazardDeterminationIndicator = v20;
                var v21 = _futureAdvancePeriod; v21.Clean = value; _futureAdvancePeriod = v21;
                var v22 = _holdbackAmount; v22.Clean = value; _holdbackAmount = v22;
                var v23 = _holdbackPercent; v23.Clean = value; _holdbackPercent = v23;
                var v24 = _lienAgentNorthCarolinaDate; v24.Clean = value; _lienAgentNorthCarolinaDate = v24;
                var v25 = _lienAgentNorthCarolinaIndicator; v25.Clean = value; _lienAgentNorthCarolinaIndicator = v25;
                var v26 = _listOfConstructionAgreementsDate; v26.Clean = value; _listOfConstructionAgreementsDate = v26;
                var v27 = _listOfConstructionAgreementsIndicator; v27.Clean = value; _listOfConstructionAgreementsIndicator = v27;
                var v28 = _maxLTVPercent; v28.Clean = value; _maxLTVPercent = v28;
                var v29 = _minimumDaysBetweenDisbursements; v29.Clean = value; _minimumDaysBetweenDisbursements = v29;
                var v30 = _otherDate; v30.Clean = value; _otherDate = v30;
                var v31 = _otherDescription; v31.Clean = value; _otherDescription = v31;
                var v32 = _otherIndicator; v32.Clean = value; _otherIndicator = v32;
                var v33 = _partialPrepaymentsElection; v33.Clean = value; _partialPrepaymentsElection = v33;
                var v34 = _paymentAndPerformanceBondsDate; v34.Clean = value; _paymentAndPerformanceBondsDate = v34;
                var v35 = _paymentAndPerformanceBondsIndicator; v35.Clean = value; _paymentAndPerformanceBondsIndicator = v35;
                var v36 = _percolationTestDate; v36.Clean = value; _percolationTestDate = v36;
                var v37 = _percolationTestIndicator; v37.Clean = value; _percolationTestIndicator = v37;
                var v38 = _permitsDate; v38.Clean = value; _permitsDate = v38;
                var v39 = _permitsIndicator; v39.Clean = value; _permitsIndicator = v39;
                var v40 = _plansAndSpecificationsDate; v40.Clean = value; _plansAndSpecificationsDate = v40;
                var v41 = _plansAndSpecificationsIndicator; v41.Clean = value; _plansAndSpecificationsIndicator = v41;
                var v42 = _projectDelaySurchargePercent; v42.Clean = value; _projectDelaySurchargePercent = v42;
                var v43 = _returnLendersCopyCommitmentDays; v43.Clean = value; _returnLendersCopyCommitmentDays = v43;
                var v44 = _securedBySeparateProperty; v44.Clean = value; _securedBySeparateProperty = v44;
                var v45 = _soilReportDate; v45.Clean = value; _soilReportDate = v45;
                var v46 = _soilReportIndicator; v46.Clean = value; _soilReportIndicator = v46;
                var v47 = _surveyDate; v47.Clean = value; _surveyDate = v47;
                var v48 = _surveyIndicator; v48.Clean = value; _surveyIndicator = v48;
                var v49 = _takeOutCommitmentDate; v49.Clean = value; _takeOutCommitmentDate = v49;
                var v50 = _takeOutCommitmentIndicator; v50.Clean = value; _takeOutCommitmentIndicator = v50;
                var v51 = _takeOutCommitmentIssuedDate; v51.Clean = value; _takeOutCommitmentIssuedDate = v51;
                var v52 = _takeOutLenderAddress; v52.Clean = value; _takeOutLenderAddress = v52;
                var v53 = _takeOutLenderCity; v53.Clean = value; _takeOutLenderCity = v53;
                var v54 = _takeOutLenderContactName; v54.Clean = value; _takeOutLenderContactName = v54;
                var v55 = _takeOutLenderContactTitle; v55.Clean = value; _takeOutLenderContactTitle = v55;
                var v56 = _takeOutLenderEmail; v56.Clean = value; _takeOutLenderEmail = v56;
                var v57 = _takeOutLenderFax; v57.Clean = value; _takeOutLenderFax = v57;
                var v58 = _takeOutLenderLicenseNumber; v58.Clean = value; _takeOutLenderLicenseNumber = v58;
                var v59 = _takeOutLenderName; v59.Clean = value; _takeOutLenderName = v59;
                var v60 = _takeOutLenderNMLSNumber; v60.Clean = value; _takeOutLenderNMLSNumber = v60;
                var v61 = _takeOutLenderPhone; v61.Clean = value; _takeOutLenderPhone = v61;
                var v62 = _takeOutLenderState; v62.Clean = value; _takeOutLenderState = v62;
                var v63 = _takeOutLenderZip; v63.Clean = value; _takeOutLenderZip = v63;
                var v64 = _titleInsuranceDate; v64.Clean = value; _titleInsuranceDate = v64;
                var v65 = _titleInsuranceIndicator; v65.Clean = value; _titleInsuranceIndicator = v65;
                var v66 = _utilityLettersDate; v66.Clean = value; _utilityLettersDate = v66;
                var v67 = _utilityLettersIndicator; v67.Clean = value; _utilityLettersIndicator = v67;
                var v68 = _waterTestDate; v68.Clean = value; _waterTestDate = v68;
                var v69 = _waterTestIndicator; v69.Clean = value; _waterTestIndicator = v69;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}