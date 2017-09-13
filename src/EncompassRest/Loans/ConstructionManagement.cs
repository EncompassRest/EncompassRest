using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ConstructionManagement : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _additionalDisbursementsConditions.Dirty
                    || _architectsCertificateDate.Dirty
                    || _architectsCertificateIndicator.Dirty
                    || _asCompletedAppraisedValue.Dirty
                    || _asCompletedPurchasePrice.Dirty
                    || _budgetDate.Dirty
                    || _budgetIndicator.Dirty
                    || _commitmentExpirationDate.Dirty
                    || _commitmentLetterDate.Dirty
                    || _constCompletionDate.Dirty
                    || _constOnlyAmortizationType.Dirty
                    || _constructionContractIndicator.Dirty
                    || _constructionContractIssuedDate.Dirty
                    || _constructionContractReceivedDate.Dirty
                    || _constructionPeriodIncludedInLoanTermFlag.Dirty
                    || _contractorsAgreementDate.Dirty
                    || _contractorsAgreementIndicator.Dirty
                    || _environmentalAssessmentDate.Dirty
                    || _environmentalAssessmentIndicator.Dirty
                    || _floodHazardDeterminationDate.Dirty
                    || _floodHazardDeterminationIndicator.Dirty
                    || _futureAdvancePeriod.Dirty
                    || _holdbackAmount.Dirty
                    || _holdbackPercent.Dirty
                    || _lienAgentNorthCarolinaDate.Dirty
                    || _lienAgentNorthCarolinaIndicator.Dirty
                    || _listOfConstructionAgreementsDate.Dirty
                    || _listOfConstructionAgreementsIndicator.Dirty
                    || _maxLTVPercent.Dirty
                    || _minimumDaysBetweenDisbursements.Dirty
                    || _otherDate.Dirty
                    || _otherDescription.Dirty
                    || _otherIndicator.Dirty
                    || _partialPrepaymentsElection.Dirty
                    || _paymentAndPerformanceBondsDate.Dirty
                    || _paymentAndPerformanceBondsIndicator.Dirty
                    || _percolationTestDate.Dirty
                    || _percolationTestIndicator.Dirty
                    || _permitsDate.Dirty
                    || _permitsIndicator.Dirty
                    || _plansAndSpecificationsDate.Dirty
                    || _plansAndSpecificationsIndicator.Dirty
                    || _projectDelaySurchargePercent.Dirty
                    || _returnLendersCopyCommitmentDays.Dirty
                    || _securedBySeparateProperty.Dirty
                    || _soilReportDate.Dirty
                    || _soilReportIndicator.Dirty
                    || _surveyDate.Dirty
                    || _surveyIndicator.Dirty
                    || _takeOutCommitmentDate.Dirty
                    || _takeOutCommitmentIndicator.Dirty
                    || _takeOutCommitmentIssuedDate.Dirty
                    || _takeOutLenderAddress.Dirty
                    || _takeOutLenderCity.Dirty
                    || _takeOutLenderContactName.Dirty
                    || _takeOutLenderContactTitle.Dirty
                    || _takeOutLenderEmail.Dirty
                    || _takeOutLenderFax.Dirty
                    || _takeOutLenderLicenseNumber.Dirty
                    || _takeOutLenderName.Dirty
                    || _takeOutLenderNMLSNumber.Dirty
                    || _takeOutLenderPhone.Dirty
                    || _takeOutLenderState.Dirty
                    || _takeOutLenderZip.Dirty
                    || _titleInsuranceDate.Dirty
                    || _titleInsuranceIndicator.Dirty
                    || _utilityLettersDate.Dirty
                    || _utilityLettersIndicator.Dirty
                    || _waterTestDate.Dirty
                    || _waterTestIndicator.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _additionalDisbursementsConditions.Dirty = value;
                _architectsCertificateDate.Dirty = value;
                _architectsCertificateIndicator.Dirty = value;
                _asCompletedAppraisedValue.Dirty = value;
                _asCompletedPurchasePrice.Dirty = value;
                _budgetDate.Dirty = value;
                _budgetIndicator.Dirty = value;
                _commitmentExpirationDate.Dirty = value;
                _commitmentLetterDate.Dirty = value;
                _constCompletionDate.Dirty = value;
                _constOnlyAmortizationType.Dirty = value;
                _constructionContractIndicator.Dirty = value;
                _constructionContractIssuedDate.Dirty = value;
                _constructionContractReceivedDate.Dirty = value;
                _constructionPeriodIncludedInLoanTermFlag.Dirty = value;
                _contractorsAgreementDate.Dirty = value;
                _contractorsAgreementIndicator.Dirty = value;
                _environmentalAssessmentDate.Dirty = value;
                _environmentalAssessmentIndicator.Dirty = value;
                _floodHazardDeterminationDate.Dirty = value;
                _floodHazardDeterminationIndicator.Dirty = value;
                _futureAdvancePeriod.Dirty = value;
                _holdbackAmount.Dirty = value;
                _holdbackPercent.Dirty = value;
                _lienAgentNorthCarolinaDate.Dirty = value;
                _lienAgentNorthCarolinaIndicator.Dirty = value;
                _listOfConstructionAgreementsDate.Dirty = value;
                _listOfConstructionAgreementsIndicator.Dirty = value;
                _maxLTVPercent.Dirty = value;
                _minimumDaysBetweenDisbursements.Dirty = value;
                _otherDate.Dirty = value;
                _otherDescription.Dirty = value;
                _otherIndicator.Dirty = value;
                _partialPrepaymentsElection.Dirty = value;
                _paymentAndPerformanceBondsDate.Dirty = value;
                _paymentAndPerformanceBondsIndicator.Dirty = value;
                _percolationTestDate.Dirty = value;
                _percolationTestIndicator.Dirty = value;
                _permitsDate.Dirty = value;
                _permitsIndicator.Dirty = value;
                _plansAndSpecificationsDate.Dirty = value;
                _plansAndSpecificationsIndicator.Dirty = value;
                _projectDelaySurchargePercent.Dirty = value;
                _returnLendersCopyCommitmentDays.Dirty = value;
                _securedBySeparateProperty.Dirty = value;
                _soilReportDate.Dirty = value;
                _soilReportIndicator.Dirty = value;
                _surveyDate.Dirty = value;
                _surveyIndicator.Dirty = value;
                _takeOutCommitmentDate.Dirty = value;
                _takeOutCommitmentIndicator.Dirty = value;
                _takeOutCommitmentIssuedDate.Dirty = value;
                _takeOutLenderAddress.Dirty = value;
                _takeOutLenderCity.Dirty = value;
                _takeOutLenderContactName.Dirty = value;
                _takeOutLenderContactTitle.Dirty = value;
                _takeOutLenderEmail.Dirty = value;
                _takeOutLenderFax.Dirty = value;
                _takeOutLenderLicenseNumber.Dirty = value;
                _takeOutLenderName.Dirty = value;
                _takeOutLenderNMLSNumber.Dirty = value;
                _takeOutLenderPhone.Dirty = value;
                _takeOutLenderState.Dirty = value;
                _takeOutLenderZip.Dirty = value;
                _titleInsuranceDate.Dirty = value;
                _titleInsuranceIndicator.Dirty = value;
                _utilityLettersDate.Dirty = value;
                _utilityLettersIndicator.Dirty = value;
                _waterTestDate.Dirty = value;
                _waterTestIndicator.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}