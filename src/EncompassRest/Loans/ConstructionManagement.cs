using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

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
                var additionalDisbursementsConditions = _additionalDisbursementsConditions; additionalDisbursementsConditions.Clean = value; _additionalDisbursementsConditions = additionalDisbursementsConditions;
                var architectsCertificateDate = _architectsCertificateDate; architectsCertificateDate.Clean = value; _architectsCertificateDate = architectsCertificateDate;
                var architectsCertificateIndicator = _architectsCertificateIndicator; architectsCertificateIndicator.Clean = value; _architectsCertificateIndicator = architectsCertificateIndicator;
                var asCompletedAppraisedValue = _asCompletedAppraisedValue; asCompletedAppraisedValue.Clean = value; _asCompletedAppraisedValue = asCompletedAppraisedValue;
                var asCompletedPurchasePrice = _asCompletedPurchasePrice; asCompletedPurchasePrice.Clean = value; _asCompletedPurchasePrice = asCompletedPurchasePrice;
                var budgetDate = _budgetDate; budgetDate.Clean = value; _budgetDate = budgetDate;
                var budgetIndicator = _budgetIndicator; budgetIndicator.Clean = value; _budgetIndicator = budgetIndicator;
                var commitmentExpirationDate = _commitmentExpirationDate; commitmentExpirationDate.Clean = value; _commitmentExpirationDate = commitmentExpirationDate;
                var commitmentLetterDate = _commitmentLetterDate; commitmentLetterDate.Clean = value; _commitmentLetterDate = commitmentLetterDate;
                var constCompletionDate = _constCompletionDate; constCompletionDate.Clean = value; _constCompletionDate = constCompletionDate;
                var constOnlyAmortizationType = _constOnlyAmortizationType; constOnlyAmortizationType.Clean = value; _constOnlyAmortizationType = constOnlyAmortizationType;
                var constructionContractIndicator = _constructionContractIndicator; constructionContractIndicator.Clean = value; _constructionContractIndicator = constructionContractIndicator;
                var constructionContractIssuedDate = _constructionContractIssuedDate; constructionContractIssuedDate.Clean = value; _constructionContractIssuedDate = constructionContractIssuedDate;
                var constructionContractReceivedDate = _constructionContractReceivedDate; constructionContractReceivedDate.Clean = value; _constructionContractReceivedDate = constructionContractReceivedDate;
                var constructionPeriodIncludedInLoanTermFlag = _constructionPeriodIncludedInLoanTermFlag; constructionPeriodIncludedInLoanTermFlag.Clean = value; _constructionPeriodIncludedInLoanTermFlag = constructionPeriodIncludedInLoanTermFlag;
                var contractorsAgreementDate = _contractorsAgreementDate; contractorsAgreementDate.Clean = value; _contractorsAgreementDate = contractorsAgreementDate;
                var contractorsAgreementIndicator = _contractorsAgreementIndicator; contractorsAgreementIndicator.Clean = value; _contractorsAgreementIndicator = contractorsAgreementIndicator;
                var environmentalAssessmentDate = _environmentalAssessmentDate; environmentalAssessmentDate.Clean = value; _environmentalAssessmentDate = environmentalAssessmentDate;
                var environmentalAssessmentIndicator = _environmentalAssessmentIndicator; environmentalAssessmentIndicator.Clean = value; _environmentalAssessmentIndicator = environmentalAssessmentIndicator;
                var floodHazardDeterminationDate = _floodHazardDeterminationDate; floodHazardDeterminationDate.Clean = value; _floodHazardDeterminationDate = floodHazardDeterminationDate;
                var floodHazardDeterminationIndicator = _floodHazardDeterminationIndicator; floodHazardDeterminationIndicator.Clean = value; _floodHazardDeterminationIndicator = floodHazardDeterminationIndicator;
                var futureAdvancePeriod = _futureAdvancePeriod; futureAdvancePeriod.Clean = value; _futureAdvancePeriod = futureAdvancePeriod;
                var holdbackAmount = _holdbackAmount; holdbackAmount.Clean = value; _holdbackAmount = holdbackAmount;
                var holdbackPercent = _holdbackPercent; holdbackPercent.Clean = value; _holdbackPercent = holdbackPercent;
                var lienAgentNorthCarolinaDate = _lienAgentNorthCarolinaDate; lienAgentNorthCarolinaDate.Clean = value; _lienAgentNorthCarolinaDate = lienAgentNorthCarolinaDate;
                var lienAgentNorthCarolinaIndicator = _lienAgentNorthCarolinaIndicator; lienAgentNorthCarolinaIndicator.Clean = value; _lienAgentNorthCarolinaIndicator = lienAgentNorthCarolinaIndicator;
                var listOfConstructionAgreementsDate = _listOfConstructionAgreementsDate; listOfConstructionAgreementsDate.Clean = value; _listOfConstructionAgreementsDate = listOfConstructionAgreementsDate;
                var listOfConstructionAgreementsIndicator = _listOfConstructionAgreementsIndicator; listOfConstructionAgreementsIndicator.Clean = value; _listOfConstructionAgreementsIndicator = listOfConstructionAgreementsIndicator;
                var maxLTVPercent = _maxLTVPercent; maxLTVPercent.Clean = value; _maxLTVPercent = maxLTVPercent;
                var minimumDaysBetweenDisbursements = _minimumDaysBetweenDisbursements; minimumDaysBetweenDisbursements.Clean = value; _minimumDaysBetweenDisbursements = minimumDaysBetweenDisbursements;
                var otherDate = _otherDate; otherDate.Clean = value; _otherDate = otherDate;
                var otherDescription = _otherDescription; otherDescription.Clean = value; _otherDescription = otherDescription;
                var otherIndicator = _otherIndicator; otherIndicator.Clean = value; _otherIndicator = otherIndicator;
                var partialPrepaymentsElection = _partialPrepaymentsElection; partialPrepaymentsElection.Clean = value; _partialPrepaymentsElection = partialPrepaymentsElection;
                var paymentAndPerformanceBondsDate = _paymentAndPerformanceBondsDate; paymentAndPerformanceBondsDate.Clean = value; _paymentAndPerformanceBondsDate = paymentAndPerformanceBondsDate;
                var paymentAndPerformanceBondsIndicator = _paymentAndPerformanceBondsIndicator; paymentAndPerformanceBondsIndicator.Clean = value; _paymentAndPerformanceBondsIndicator = paymentAndPerformanceBondsIndicator;
                var percolationTestDate = _percolationTestDate; percolationTestDate.Clean = value; _percolationTestDate = percolationTestDate;
                var percolationTestIndicator = _percolationTestIndicator; percolationTestIndicator.Clean = value; _percolationTestIndicator = percolationTestIndicator;
                var permitsDate = _permitsDate; permitsDate.Clean = value; _permitsDate = permitsDate;
                var permitsIndicator = _permitsIndicator; permitsIndicator.Clean = value; _permitsIndicator = permitsIndicator;
                var plansAndSpecificationsDate = _plansAndSpecificationsDate; plansAndSpecificationsDate.Clean = value; _plansAndSpecificationsDate = plansAndSpecificationsDate;
                var plansAndSpecificationsIndicator = _plansAndSpecificationsIndicator; plansAndSpecificationsIndicator.Clean = value; _plansAndSpecificationsIndicator = plansAndSpecificationsIndicator;
                var projectDelaySurchargePercent = _projectDelaySurchargePercent; projectDelaySurchargePercent.Clean = value; _projectDelaySurchargePercent = projectDelaySurchargePercent;
                var returnLendersCopyCommitmentDays = _returnLendersCopyCommitmentDays; returnLendersCopyCommitmentDays.Clean = value; _returnLendersCopyCommitmentDays = returnLendersCopyCommitmentDays;
                var securedBySeparateProperty = _securedBySeparateProperty; securedBySeparateProperty.Clean = value; _securedBySeparateProperty = securedBySeparateProperty;
                var soilReportDate = _soilReportDate; soilReportDate.Clean = value; _soilReportDate = soilReportDate;
                var soilReportIndicator = _soilReportIndicator; soilReportIndicator.Clean = value; _soilReportIndicator = soilReportIndicator;
                var surveyDate = _surveyDate; surveyDate.Clean = value; _surveyDate = surveyDate;
                var surveyIndicator = _surveyIndicator; surveyIndicator.Clean = value; _surveyIndicator = surveyIndicator;
                var takeOutCommitmentDate = _takeOutCommitmentDate; takeOutCommitmentDate.Clean = value; _takeOutCommitmentDate = takeOutCommitmentDate;
                var takeOutCommitmentIndicator = _takeOutCommitmentIndicator; takeOutCommitmentIndicator.Clean = value; _takeOutCommitmentIndicator = takeOutCommitmentIndicator;
                var takeOutCommitmentIssuedDate = _takeOutCommitmentIssuedDate; takeOutCommitmentIssuedDate.Clean = value; _takeOutCommitmentIssuedDate = takeOutCommitmentIssuedDate;
                var takeOutLenderAddress = _takeOutLenderAddress; takeOutLenderAddress.Clean = value; _takeOutLenderAddress = takeOutLenderAddress;
                var takeOutLenderCity = _takeOutLenderCity; takeOutLenderCity.Clean = value; _takeOutLenderCity = takeOutLenderCity;
                var takeOutLenderContactName = _takeOutLenderContactName; takeOutLenderContactName.Clean = value; _takeOutLenderContactName = takeOutLenderContactName;
                var takeOutLenderContactTitle = _takeOutLenderContactTitle; takeOutLenderContactTitle.Clean = value; _takeOutLenderContactTitle = takeOutLenderContactTitle;
                var takeOutLenderEmail = _takeOutLenderEmail; takeOutLenderEmail.Clean = value; _takeOutLenderEmail = takeOutLenderEmail;
                var takeOutLenderFax = _takeOutLenderFax; takeOutLenderFax.Clean = value; _takeOutLenderFax = takeOutLenderFax;
                var takeOutLenderLicenseNumber = _takeOutLenderLicenseNumber; takeOutLenderLicenseNumber.Clean = value; _takeOutLenderLicenseNumber = takeOutLenderLicenseNumber;
                var takeOutLenderName = _takeOutLenderName; takeOutLenderName.Clean = value; _takeOutLenderName = takeOutLenderName;
                var takeOutLenderNMLSNumber = _takeOutLenderNMLSNumber; takeOutLenderNMLSNumber.Clean = value; _takeOutLenderNMLSNumber = takeOutLenderNMLSNumber;
                var takeOutLenderPhone = _takeOutLenderPhone; takeOutLenderPhone.Clean = value; _takeOutLenderPhone = takeOutLenderPhone;
                var takeOutLenderState = _takeOutLenderState; takeOutLenderState.Clean = value; _takeOutLenderState = takeOutLenderState;
                var takeOutLenderZip = _takeOutLenderZip; takeOutLenderZip.Clean = value; _takeOutLenderZip = takeOutLenderZip;
                var titleInsuranceDate = _titleInsuranceDate; titleInsuranceDate.Clean = value; _titleInsuranceDate = titleInsuranceDate;
                var titleInsuranceIndicator = _titleInsuranceIndicator; titleInsuranceIndicator.Clean = value; _titleInsuranceIndicator = titleInsuranceIndicator;
                var utilityLettersDate = _utilityLettersDate; utilityLettersDate.Clean = value; _utilityLettersDate = utilityLettersDate;
                var utilityLettersIndicator = _utilityLettersIndicator; utilityLettersIndicator.Clean = value; _utilityLettersIndicator = utilityLettersIndicator;
                var waterTestDate = _waterTestDate; waterTestDate.Clean = value; _waterTestDate = waterTestDate;
                var waterTestIndicator = _waterTestIndicator; waterTestIndicator.Clean = value; _waterTestIndicator = waterTestIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ConstructionManagement()
        {
            Clean = true;
        }
    }
}