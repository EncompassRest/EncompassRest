#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class ConstructionManagement : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _additionalDisbursementsConditions;
        public string AdditionalDisbursementsConditions { get => _additionalDisbursementsConditions; set => _additionalDisbursementsConditions = value; }
        private DirtyValue<DateTime?> _architectsCertificateDate;
        public DateTime? ArchitectsCertificateDate { get => _architectsCertificateDate; set => _architectsCertificateDate = value; }
        private DirtyValue<bool?> _architectsCertificateIndicator;
        public bool? ArchitectsCertificateIndicator { get => _architectsCertificateIndicator; set => _architectsCertificateIndicator = value; }
        private DirtyValue<decimal?> _asCompletedAppraisedValue;
        public decimal? AsCompletedAppraisedValue { get => _asCompletedAppraisedValue; set => _asCompletedAppraisedValue = value; }
        private DirtyValue<decimal?> _asCompletedPurchasePrice;
        public decimal? AsCompletedPurchasePrice { get => _asCompletedPurchasePrice; set => _asCompletedPurchasePrice = value; }
        private DirtyValue<DateTime?> _budgetDate;
        public DateTime? BudgetDate { get => _budgetDate; set => _budgetDate = value; }
        private DirtyValue<bool?> _budgetIndicator;
        public bool? BudgetIndicator { get => _budgetIndicator; set => _budgetIndicator = value; }
        private DirtyValue<DateTime?> _commitmentExpirationDate;
        public DateTime? CommitmentExpirationDate { get => _commitmentExpirationDate; set => _commitmentExpirationDate = value; }
        private DirtyValue<DateTime?> _commitmentLetterDate;
        public DateTime? CommitmentLetterDate { get => _commitmentLetterDate; set => _commitmentLetterDate = value; }
        private DirtyValue<DateTime?> _constCompletionDate;
        public DateTime? ConstCompletionDate { get => _constCompletionDate; set => _constCompletionDate = value; }
        private DirtyValue<StringEnumValue<ConstOnlyAmortizationType>> _constOnlyAmortizationType;
        public StringEnumValue<ConstOnlyAmortizationType> ConstOnlyAmortizationType { get => _constOnlyAmortizationType; set => _constOnlyAmortizationType = value; }
        private DirtyValue<bool?> _constructionContractIndicator;
        public bool? ConstructionContractIndicator { get => _constructionContractIndicator; set => _constructionContractIndicator = value; }
        private DirtyValue<DateTime?> _constructionContractIssuedDate;
        public DateTime? ConstructionContractIssuedDate { get => _constructionContractIssuedDate; set => _constructionContractIssuedDate = value; }
        private DirtyValue<DateTime?> _constructionContractReceivedDate;
        public DateTime? ConstructionContractReceivedDate { get => _constructionContractReceivedDate; set => _constructionContractReceivedDate = value; }
        private DirtyValue<bool?> _constructionPeriodIncludedInLoanTermFlag;
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get => _constructionPeriodIncludedInLoanTermFlag; set => _constructionPeriodIncludedInLoanTermFlag = value; }
        private DirtyValue<DateTime?> _contractorsAgreementDate;
        public DateTime? ContractorsAgreementDate { get => _contractorsAgreementDate; set => _contractorsAgreementDate = value; }
        private DirtyValue<bool?> _contractorsAgreementIndicator;
        public bool? ContractorsAgreementIndicator { get => _contractorsAgreementIndicator; set => _contractorsAgreementIndicator = value; }
        private DirtyValue<DateTime?> _environmentalAssessmentDate;
        public DateTime? EnvironmentalAssessmentDate { get => _environmentalAssessmentDate; set => _environmentalAssessmentDate = value; }
        private DirtyValue<bool?> _environmentalAssessmentIndicator;
        public bool? EnvironmentalAssessmentIndicator { get => _environmentalAssessmentIndicator; set => _environmentalAssessmentIndicator = value; }
        private DirtyValue<DateTime?> _floodHazardDeterminationDate;
        public DateTime? FloodHazardDeterminationDate { get => _floodHazardDeterminationDate; set => _floodHazardDeterminationDate = value; }
        private DirtyValue<bool?> _floodHazardDeterminationIndicator;
        public bool? FloodHazardDeterminationIndicator { get => _floodHazardDeterminationIndicator; set => _floodHazardDeterminationIndicator = value; }
        private DirtyValue<int?> _futureAdvancePeriod;
        public int? FutureAdvancePeriod { get => _futureAdvancePeriod; set => _futureAdvancePeriod = value; }
        private DirtyValue<decimal?> _holdbackAmount;
        public decimal? HoldbackAmount { get => _holdbackAmount; set => _holdbackAmount = value; }
        private DirtyValue<decimal?> _holdbackPercent;
        public decimal? HoldbackPercent { get => _holdbackPercent; set => _holdbackPercent = value; }
        private DirtyValue<DateTime?> _lienAgentNorthCarolinaDate;
        public DateTime? LienAgentNorthCarolinaDate { get => _lienAgentNorthCarolinaDate; set => _lienAgentNorthCarolinaDate = value; }
        private DirtyValue<bool?> _lienAgentNorthCarolinaIndicator;
        public bool? LienAgentNorthCarolinaIndicator { get => _lienAgentNorthCarolinaIndicator; set => _lienAgentNorthCarolinaIndicator = value; }
        private DirtyValue<DateTime?> _listOfConstructionAgreementsDate;
        public DateTime? ListOfConstructionAgreementsDate { get => _listOfConstructionAgreementsDate; set => _listOfConstructionAgreementsDate = value; }
        private DirtyValue<bool?> _listOfConstructionAgreementsIndicator;
        public bool? ListOfConstructionAgreementsIndicator { get => _listOfConstructionAgreementsIndicator; set => _listOfConstructionAgreementsIndicator = value; }
        private DirtyValue<decimal?> _maxLTVPercent;
        public decimal? MaxLTVPercent { get => _maxLTVPercent; set => _maxLTVPercent = value; }
        private DirtyValue<int?> _minimumDaysBetweenDisbursements;
        public int? MinimumDaysBetweenDisbursements { get => _minimumDaysBetweenDisbursements; set => _minimumDaysBetweenDisbursements = value; }
        private DirtyValue<DateTime?> _otherDate;
        public DateTime? OtherDate { get => _otherDate; set => _otherDate = value; }
        private DirtyValue<string> _otherDescription;
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _otherIndicator;
        public bool? OtherIndicator { get => _otherIndicator; set => _otherIndicator = value; }
        private DirtyValue<StringEnumValue<PartialPrepaymentsElection>> _partialPrepaymentsElection;
        public StringEnumValue<PartialPrepaymentsElection> PartialPrepaymentsElection { get => _partialPrepaymentsElection; set => _partialPrepaymentsElection = value; }
        private DirtyValue<DateTime?> _paymentAndPerformanceBondsDate;
        public DateTime? PaymentAndPerformanceBondsDate { get => _paymentAndPerformanceBondsDate; set => _paymentAndPerformanceBondsDate = value; }
        private DirtyValue<bool?> _paymentAndPerformanceBondsIndicator;
        public bool? PaymentAndPerformanceBondsIndicator { get => _paymentAndPerformanceBondsIndicator; set => _paymentAndPerformanceBondsIndicator = value; }
        private DirtyValue<DateTime?> _percolationTestDate;
        public DateTime? PercolationTestDate { get => _percolationTestDate; set => _percolationTestDate = value; }
        private DirtyValue<bool?> _percolationTestIndicator;
        public bool? PercolationTestIndicator { get => _percolationTestIndicator; set => _percolationTestIndicator = value; }
        private DirtyValue<DateTime?> _permitsDate;
        public DateTime? PermitsDate { get => _permitsDate; set => _permitsDate = value; }
        private DirtyValue<bool?> _permitsIndicator;
        public bool? PermitsIndicator { get => _permitsIndicator; set => _permitsIndicator = value; }
        private DirtyValue<DateTime?> _plansAndSpecificationsDate;
        public DateTime? PlansAndSpecificationsDate { get => _plansAndSpecificationsDate; set => _plansAndSpecificationsDate = value; }
        private DirtyValue<bool?> _plansAndSpecificationsIndicator;
        public bool? PlansAndSpecificationsIndicator { get => _plansAndSpecificationsIndicator; set => _plansAndSpecificationsIndicator = value; }
        private DirtyValue<decimal?> _projectDelaySurchargePercent;
        public decimal? ProjectDelaySurchargePercent { get => _projectDelaySurchargePercent; set => _projectDelaySurchargePercent = value; }
        private DirtyValue<int?> _returnLendersCopyCommitmentDays;
        public int? ReturnLendersCopyCommitmentDays { get => _returnLendersCopyCommitmentDays; set => _returnLendersCopyCommitmentDays = value; }
        private DirtyValue<bool?> _securedBySeparateProperty;
        public bool? SecuredBySeparateProperty { get => _securedBySeparateProperty; set => _securedBySeparateProperty = value; }
        private DirtyValue<DateTime?> _soilReportDate;
        public DateTime? SoilReportDate { get => _soilReportDate; set => _soilReportDate = value; }
        private DirtyValue<bool?> _soilReportIndicator;
        public bool? SoilReportIndicator { get => _soilReportIndicator; set => _soilReportIndicator = value; }
        private DirtyValue<DateTime?> _surveyDate;
        public DateTime? SurveyDate { get => _surveyDate; set => _surveyDate = value; }
        private DirtyValue<bool?> _surveyIndicator;
        public bool? SurveyIndicator { get => _surveyIndicator; set => _surveyIndicator = value; }
        private DirtyValue<DateTime?> _takeOutCommitmentDate;
        public DateTime? TakeOutCommitmentDate { get => _takeOutCommitmentDate; set => _takeOutCommitmentDate = value; }
        private DirtyValue<bool?> _takeOutCommitmentIndicator;
        public bool? TakeOutCommitmentIndicator { get => _takeOutCommitmentIndicator; set => _takeOutCommitmentIndicator = value; }
        private DirtyValue<DateTime?> _takeOutCommitmentIssuedDate;
        public DateTime? TakeOutCommitmentIssuedDate { get => _takeOutCommitmentIssuedDate; set => _takeOutCommitmentIssuedDate = value; }
        private DirtyValue<string> _takeOutLenderAddress;
        public string TakeOutLenderAddress { get => _takeOutLenderAddress; set => _takeOutLenderAddress = value; }
        private DirtyValue<string> _takeOutLenderCity;
        public string TakeOutLenderCity { get => _takeOutLenderCity; set => _takeOutLenderCity = value; }
        private DirtyValue<string> _takeOutLenderContactName;
        public string TakeOutLenderContactName { get => _takeOutLenderContactName; set => _takeOutLenderContactName = value; }
        private DirtyValue<string> _takeOutLenderContactTitle;
        public string TakeOutLenderContactTitle { get => _takeOutLenderContactTitle; set => _takeOutLenderContactTitle = value; }
        private DirtyValue<string> _takeOutLenderEmail;
        public string TakeOutLenderEmail { get => _takeOutLenderEmail; set => _takeOutLenderEmail = value; }
        private DirtyValue<string> _takeOutLenderFax;
        public string TakeOutLenderFax { get => _takeOutLenderFax; set => _takeOutLenderFax = value; }
        private DirtyValue<string> _takeOutLenderLicenseNumber;
        public string TakeOutLenderLicenseNumber { get => _takeOutLenderLicenseNumber; set => _takeOutLenderLicenseNumber = value; }
        private DirtyValue<string> _takeOutLenderName;
        public string TakeOutLenderName { get => _takeOutLenderName; set => _takeOutLenderName = value; }
        private DirtyValue<string> _takeOutLenderNMLSNumber;
        public string TakeOutLenderNMLSNumber { get => _takeOutLenderNMLSNumber; set => _takeOutLenderNMLSNumber = value; }
        private DirtyValue<string> _takeOutLenderPhone;
        public string TakeOutLenderPhone { get => _takeOutLenderPhone; set => _takeOutLenderPhone = value; }
        private DirtyValue<string> _takeOutLenderState;
        public string TakeOutLenderState { get => _takeOutLenderState; set => _takeOutLenderState = value; }
        private DirtyValue<string> _takeOutLenderZip;
        public string TakeOutLenderZip { get => _takeOutLenderZip; set => _takeOutLenderZip = value; }
        private DirtyValue<DateTime?> _titleInsuranceDate;
        public DateTime? TitleInsuranceDate { get => _titleInsuranceDate; set => _titleInsuranceDate = value; }
        private DirtyValue<bool?> _titleInsuranceIndicator;
        public bool? TitleInsuranceIndicator { get => _titleInsuranceIndicator; set => _titleInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _utilityLettersDate;
        public DateTime? UtilityLettersDate { get => _utilityLettersDate; set => _utilityLettersDate = value; }
        private DirtyValue<bool?> _utilityLettersIndicator;
        public bool? UtilityLettersIndicator { get => _utilityLettersIndicator; set => _utilityLettersIndicator = value; }
        private DirtyValue<DateTime?> _waterTestDate;
        public DateTime? WaterTestDate { get => _waterTestDate; set => _waterTestDate = value; }
        private DirtyValue<bool?> _waterTestIndicator;
        public bool? WaterTestIndicator { get => _waterTestIndicator; set => _waterTestIndicator = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _additionalDisbursementsConditions.Dirty
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
            }
            set
            {
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
            }
        }
    }
}