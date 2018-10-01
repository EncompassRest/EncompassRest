using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ConstructionManagement
    /// </summary>
    public sealed partial class ConstructionManagement : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _additionalDisbursementsConditions;
        private DirtyValue<DateTime?> _architectsCertificateDate;
        private DirtyValue<bool?> _architectsCertificateIndicator;
        private DirtyValue<decimal?> _asCompletedAppraisedValue;
        private DirtyValue<decimal?> _asCompletedPurchasePrice;
        private DirtyValue<DateTime?> _budgetDate;
        private DirtyValue<bool?> _budgetIndicator;
        private DirtyValue<DateTime?> _commitmentExpirationDate;
        private DirtyValue<DateTime?> _commitmentLetterDate;
        private DirtyValue<DateTime?> _constCompletionDate;
        private DirtyValue<StringEnumValue<ConstOnlyAmortizationType>> _constOnlyAmortizationType;
        private DirtyValue<bool?> _constructionContractIndicator;
        private DirtyValue<DateTime?> _constructionContractIssuedDate;
        private DirtyValue<DateTime?> _constructionContractReceivedDate;
        private DirtyValue<bool?> _constructionPeriodIncludedInLoanTermFlag;
        private DirtyValue<DateTime?> _contractorsAgreementDate;
        private DirtyValue<bool?> _contractorsAgreementIndicator;
        private DirtyValue<bool?> _costImprovementsIncluded;
        private DirtyValue<DateTime?> _environmentalAssessmentDate;
        private DirtyValue<bool?> _environmentalAssessmentIndicator;
        private DirtyValue<DateTime?> _floodHazardDeterminationDate;
        private DirtyValue<bool?> _floodHazardDeterminationIndicator;
        private DirtyValue<int?> _futureAdvancePeriod;
        private DirtyValue<decimal?> _holdbackAmount;
        private DirtyValue<decimal?> _holdbackPercent;
        private DirtyValue<DateTime?> _lienAgentNorthCarolinaDate;
        private DirtyValue<bool?> _lienAgentNorthCarolinaIndicator;
        private DirtyValue<DateTime?> _listOfConstructionAgreementsDate;
        private DirtyValue<bool?> _listOfConstructionAgreementsIndicator;
        private DirtyValue<decimal?> _maxLTVPercent;
        private DirtyValue<int?> _minimumDaysBetweenDisbursements;
        private DirtyValue<DateTime?> _otherDate;
        private DirtyValue<string> _otherDescription;
        private DirtyValue<bool?> _otherIndicator;
        private DirtyValue<StringEnumValue<PartialPrepaymentsElection>> _partialPrepaymentsElection;
        private DirtyValue<DateTime?> _paymentAndPerformanceBondsDate;
        private DirtyValue<bool?> _paymentAndPerformanceBondsIndicator;
        private DirtyValue<DateTime?> _percolationTestDate;
        private DirtyValue<bool?> _percolationTestIndicator;
        private DirtyValue<DateTime?> _permitsDate;
        private DirtyValue<bool?> _permitsIndicator;
        private DirtyValue<DateTime?> _plansAndSpecificationsDate;
        private DirtyValue<bool?> _plansAndSpecificationsIndicator;
        private DirtyValue<decimal?> _projectDelaySurchargePercent;
        private DirtyValue<int?> _returnLendersCopyCommitmentDays;
        private DirtyValue<bool?> _securedBySeparateProperty;
        private DirtyValue<DateTime?> _soilReportDate;
        private DirtyValue<bool?> _soilReportIndicator;
        private DirtyValue<DateTime?> _surveyDate;
        private DirtyValue<bool?> _surveyIndicator;
        private DirtyValue<DateTime?> _takeOutCommitmentDate;
        private DirtyValue<bool?> _takeOutCommitmentIndicator;
        private DirtyValue<DateTime?> _takeOutCommitmentIssuedDate;
        private DirtyValue<string> _takeOutLenderAddress;
        private DirtyValue<string> _takeOutLenderCity;
        private DirtyValue<string> _takeOutLenderContactName;
        private DirtyValue<string> _takeOutLenderContactTitle;
        private DirtyValue<string> _takeOutLenderEmail;
        private DirtyValue<string> _takeOutLenderFax;
        private DirtyValue<string> _takeOutLenderLicenseNumber;
        private DirtyValue<string> _takeOutLenderName;
        private DirtyValue<string> _takeOutLenderNMLSNumber;
        private DirtyValue<string> _takeOutLenderPhone;
        private DirtyValue<string> _takeOutLenderState;
        private DirtyValue<string> _takeOutLenderZip;
        private DirtyValue<DateTime?> _titleInsuranceDate;
        private DirtyValue<bool?> _titleInsuranceIndicator;
        private DirtyValue<DateTime?> _utilityLettersDate;
        private DirtyValue<bool?> _utilityLettersIndicator;
        private DirtyValue<DateTime?> _waterTestDate;
        private DirtyValue<bool?> _waterTestIndicator;

        /// <summary>
        /// Construction Management Project Data - Additional Disbursements Conditions [CONST.X56]
        /// </summary>
        public string AdditionalDisbursementsConditions { get => _additionalDisbursementsConditions; set => SetField(ref _additionalDisbursementsConditions, value); }

        /// <summary>
        /// Construction Management Project Data - Architect's Certificate Date [CONST.X34]
        /// </summary>
        public DateTime? ArchitectsCertificateDate { get => _architectsCertificateDate; set => SetField(ref _architectsCertificateDate, value); }

        /// <summary>
        /// Construction Management Project Data - Architect's Certificate Indicator [CONST.X33]
        /// </summary>
        public bool? ArchitectsCertificateIndicator { get => _architectsCertificateIndicator; set => SetField(ref _architectsCertificateIndicator, value); }

        /// <summary>
        /// As Completed Appraised Value [CONST.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AsCompletedAppraisedValue { get => _asCompletedAppraisedValue; set => SetField(ref _asCompletedAppraisedValue, value); }

        /// <summary>
        /// As Completed Purchase Price [CONST.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AsCompletedPurchasePrice { get => _asCompletedPurchasePrice; set => SetField(ref _asCompletedPurchasePrice, value); }

        /// <summary>
        /// Construction Management Project Data - Budget Date [CONST.X30]
        /// </summary>
        public DateTime? BudgetDate { get => _budgetDate; set => SetField(ref _budgetDate, value); }

        /// <summary>
        /// Construction Management Project Data - Budget Indicator [CONST.X29]
        /// </summary>
        public bool? BudgetIndicator { get => _budgetIndicator; set => SetField(ref _budgetIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Commitment Expiration Date [CONST.X12]
        /// </summary>
        public DateTime? CommitmentExpirationDate { get => _commitmentExpirationDate; set => SetField(ref _commitmentExpirationDate, value); }

        /// <summary>
        /// Construction Management Project Data - Commitment Letter Date [CONST.X11]
        /// </summary>
        public DateTime? CommitmentLetterDate { get => _commitmentLetterDate; set => SetField(ref _commitmentLetterDate, value); }

        /// <summary>
        /// Construction Management Loan Info - Const. Completion Date [CONST.X3]
        /// </summary>
        public DateTime? ConstCompletionDate { get => _constCompletionDate; set => SetField(ref _constCompletionDate, value); }

        /// <summary>
        /// Construction Management Loan Info - Construction Only Amortization Type [CONST.X13]
        /// </summary>
        public StringEnumValue<ConstOnlyAmortizationType> ConstOnlyAmortizationType { get => _constOnlyAmortizationType; set => SetField(ref _constOnlyAmortizationType, value); }

        /// <summary>
        /// Construction Management Project Data - Construction Contract Indicator [CONST.X27]
        /// </summary>
        public bool? ConstructionContractIndicator { get => _constructionContractIndicator; set => SetField(ref _constructionContractIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Construction Contract Issued Date [CONST.X10]
        /// </summary>
        public DateTime? ConstructionContractIssuedDate { get => _constructionContractIssuedDate; set => SetField(ref _constructionContractIssuedDate, value); }

        /// <summary>
        /// Construction Management Project Data - Construction Contract Received Date [CONST.X28]
        /// </summary>
        public DateTime? ConstructionContractReceivedDate { get => _constructionContractReceivedDate; set => SetField(ref _constructionContractReceivedDate, value); }

        /// <summary>
        /// Construction period included in the Loan Terms Flag [CONST.X1]
        /// </summary>
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get => _constructionPeriodIncludedInLoanTermFlag; set => SetField(ref _constructionPeriodIncludedInLoanTermFlag, value); }

        /// <summary>
        /// Construction Management Project Data - Contractor's Agreement Date [CONST.X32]
        /// </summary>
        public DateTime? ContractorsAgreementDate { get => _contractorsAgreementDate; set => SetField(ref _contractorsAgreementDate, value); }

        /// <summary>
        /// Construction Management Project Data - Contractor's Agreement Indicator [CONST.X31]
        /// </summary>
        public bool? ContractorsAgreementIndicator { get => _contractorsAgreementIndicator; set => SetField(ref _contractorsAgreementIndicator, value); }

        /// <summary>
        /// Cost of Improvements Included in Liabilities [CONST.X73]
        /// </summary>
        public bool? CostImprovementsIncluded { get => _costImprovementsIncluded; set => SetField(ref _costImprovementsIncluded, value); }

        /// <summary>
        /// Construction Management Project Data - Environmental Assessment Date [CONST.X36]
        /// </summary>
        public DateTime? EnvironmentalAssessmentDate { get => _environmentalAssessmentDate; set => SetField(ref _environmentalAssessmentDate, value); }

        /// <summary>
        /// Construction Management Project Data - Environmental Assessment Indicator [CONST.X35]
        /// </summary>
        public bool? EnvironmentalAssessmentIndicator { get => _environmentalAssessmentIndicator; set => SetField(ref _environmentalAssessmentIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Flood Hazard Determination Date [CONST.X48]
        /// </summary>
        public DateTime? FloodHazardDeterminationDate { get => _floodHazardDeterminationDate; set => SetField(ref _floodHazardDeterminationDate, value); }

        /// <summary>
        /// Construction Management Project Data - Flood Hazard Determination Indicator [CONST.X47]
        /// </summary>
        public bool? FloodHazardDeterminationIndicator { get => _floodHazardDeterminationIndicator; set => SetField(ref _floodHazardDeterminationIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Future Advance Period (mths) [CONST.X54]
        /// </summary>
        public int? FutureAdvancePeriod { get => _futureAdvancePeriod; set => SetField(ref _futureAdvancePeriod, value); }

        /// <summary>
        /// Construction Management Loan Info - Holdback $ [CONST.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HoldbackAmount { get => _holdbackAmount; set => SetField(ref _holdbackAmount, value); }

        /// <summary>
        /// Construction Management Loan Info - Holdback % [CONST.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? HoldbackPercent { get => _holdbackPercent; set => SetField(ref _holdbackPercent, value); }

        /// <summary>
        /// Construction Management Project Data - Lien Agent (North Carolina) Date [CONST.X46]
        /// </summary>
        public DateTime? LienAgentNorthCarolinaDate { get => _lienAgentNorthCarolinaDate; set => SetField(ref _lienAgentNorthCarolinaDate, value); }

        /// <summary>
        /// Construction Management Project Data - Lien Agent (North Carolina) Indicator [CONST.X45]
        /// </summary>
        public bool? LienAgentNorthCarolinaIndicator { get => _lienAgentNorthCarolinaIndicator; set => SetField(ref _lienAgentNorthCarolinaIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - List of Construction Agreements Date [CONST.X50]
        /// </summary>
        public DateTime? ListOfConstructionAgreementsDate { get => _listOfConstructionAgreementsDate; set => SetField(ref _listOfConstructionAgreementsDate, value); }

        /// <summary>
        /// Construction Management Project Data - List of Construction Agreements Indicator [CONST.X49]
        /// </summary>
        public bool? ListOfConstructionAgreementsIndicator { get => _listOfConstructionAgreementsIndicator; set => SetField(ref _listOfConstructionAgreementsIndicator, value); }

        /// <summary>
        /// Construction Management Loan Info - Max LTV % [CONST.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxLTVPercent { get => _maxLTVPercent; set => SetField(ref _maxLTVPercent, value); }

        /// <summary>
        /// Construction Management Project Data - Minimum days between disbursements [CONST.X55]
        /// </summary>
        public int? MinimumDaysBetweenDisbursements { get => _minimumDaysBetweenDisbursements; set => SetField(ref _minimumDaysBetweenDisbursements, value); }

        /// <summary>
        /// Construction Management Project Data - Other Date [CONST.X52]
        /// </summary>
        public DateTime? OtherDate { get => _otherDate; set => SetField(ref _otherDate, value); }

        /// <summary>
        /// Construction Management Project Data - Other Description [CONST.X53]
        /// </summary>
        public string OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

        /// <summary>
        /// Construction Management Project Data - Other Indicator [CONST.X51]
        /// </summary>
        public bool? OtherIndicator { get => _otherIndicator; set => SetField(ref _otherIndicator, value); }

        /// <summary>
        /// Partial Prepayments Election [CONST.X57]
        /// </summary>
        public StringEnumValue<PartialPrepaymentsElection> PartialPrepaymentsElection { get => _partialPrepaymentsElection; set => SetField(ref _partialPrepaymentsElection, value); }

        /// <summary>
        /// Construction Management Project Data - Payment and Performance Bonds Date [CONST.X44]
        /// </summary>
        public DateTime? PaymentAndPerformanceBondsDate { get => _paymentAndPerformanceBondsDate; set => SetField(ref _paymentAndPerformanceBondsDate, value); }

        /// <summary>
        /// Construction Management Project Data - Payment and Performance Bonds Indicator [CONST.X43]
        /// </summary>
        public bool? PaymentAndPerformanceBondsIndicator { get => _paymentAndPerformanceBondsIndicator; set => SetField(ref _paymentAndPerformanceBondsIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Percolation Test Date [CONST.X42]
        /// </summary>
        public DateTime? PercolationTestDate { get => _percolationTestDate; set => SetField(ref _percolationTestDate, value); }

        /// <summary>
        /// Construction Management Project Data - Percolation Test Indicator [CONST.X41]
        /// </summary>
        public bool? PercolationTestIndicator { get => _percolationTestIndicator; set => SetField(ref _percolationTestIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Permits Date [CONST.X22]
        /// </summary>
        public DateTime? PermitsDate { get => _permitsDate; set => SetField(ref _permitsDate, value); }

        /// <summary>
        /// Construction Management Project Data - Permits Indicator [CONST.X21]
        /// </summary>
        public bool? PermitsIndicator { get => _permitsIndicator; set => SetField(ref _permitsIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Plans and Specifications Date [CONST.X26]
        /// </summary>
        public DateTime? PlansAndSpecificationsDate { get => _plansAndSpecificationsDate; set => SetField(ref _plansAndSpecificationsDate, value); }

        /// <summary>
        /// Construction Management Project Data - Plans and Specifications Indicator [CONST.X25]
        /// </summary>
        public bool? PlansAndSpecificationsIndicator { get => _plansAndSpecificationsIndicator; set => SetField(ref _plansAndSpecificationsIndicator, value); }

        /// <summary>
        /// Construction Management Loan Info - Project Delay Surcharge % [CONST.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ProjectDelaySurchargePercent { get => _projectDelaySurchargePercent; set => SetField(ref _projectDelaySurchargePercent, value); }

        /// <summary>
        /// Construction Management Project Data - Return Lender's copy of this commitment within days [CONST.X14]
        /// </summary>
        public int? ReturnLendersCopyCommitmentDays { get => _returnLendersCopyCommitmentDays; set => SetField(ref _returnLendersCopyCommitmentDays, value); }

        /// <summary>
        /// Construction Management Loan Info - Secured by Separate Property [CONST.X2]
        /// </summary>
        public bool? SecuredBySeparateProperty { get => _securedBySeparateProperty; set => SetField(ref _securedBySeparateProperty, value); }

        /// <summary>
        /// Construction Management Project Data - Soil Report Date [CONST.X38]
        /// </summary>
        public DateTime? SoilReportDate { get => _soilReportDate; set => SetField(ref _soilReportDate, value); }

        /// <summary>
        /// Construction Management Project Data - Soil Report Indicator [CONST.X37]
        /// </summary>
        public bool? SoilReportIndicator { get => _soilReportIndicator; set => SetField(ref _soilReportIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Survey Date [CONST.X20]
        /// </summary>
        public DateTime? SurveyDate { get => _surveyDate; set => SetField(ref _surveyDate, value); }

        /// <summary>
        /// Construction Management Project Data - Survey Indicator [CONST.X19]
        /// </summary>
        public bool? SurveyIndicator { get => _surveyIndicator; set => SetField(ref _surveyIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Take-out Commitment Date [CONST.X16]
        /// </summary>
        public DateTime? TakeOutCommitmentDate { get => _takeOutCommitmentDate; set => SetField(ref _takeOutCommitmentDate, value); }

        /// <summary>
        /// Construction Management Project Data - Take-out Commitment Indicator [CONST.X15]
        /// </summary>
        public bool? TakeOutCommitmentIndicator { get => _takeOutCommitmentIndicator; set => SetField(ref _takeOutCommitmentIndicator, value); }

        /// <summary>
        /// Take-Out Commitment Letter Date [CONST.X67]
        /// </summary>
        public DateTime? TakeOutCommitmentIssuedDate { get => _takeOutCommitmentIssuedDate; set => SetField(ref _takeOutCommitmentIssuedDate, value); }

        /// <summary>
        /// Take-Out Lender Address [CONST.X63]
        /// </summary>
        public string TakeOutLenderAddress { get => _takeOutLenderAddress; set => SetField(ref _takeOutLenderAddress, value); }

        /// <summary>
        /// Take-Out Lender City [CONST.X64]
        /// </summary>
        public string TakeOutLenderCity { get => _takeOutLenderCity; set => SetField(ref _takeOutLenderCity, value); }

        /// <summary>
        /// Take-Out Lender Contact Name [CONST.X68]
        /// </summary>
        public string TakeOutLenderContactName { get => _takeOutLenderContactName; set => SetField(ref _takeOutLenderContactName, value); }

        /// <summary>
        /// Take-Out Lender Contact Title [CONST.X69]
        /// </summary>
        public string TakeOutLenderContactTitle { get => _takeOutLenderContactTitle; set => SetField(ref _takeOutLenderContactTitle, value); }

        /// <summary>
        /// Take-Out Lender Email [CONST.X71]
        /// </summary>
        public string TakeOutLenderEmail { get => _takeOutLenderEmail; set => SetField(ref _takeOutLenderEmail, value); }

        /// <summary>
        /// Take-Out Lender Fax [CONST.X72]
        /// </summary>
        public string TakeOutLenderFax { get => _takeOutLenderFax; set => SetField(ref _takeOutLenderFax, value); }

        /// <summary>
        /// Take-Out Lender License # [CONST.X62]
        /// </summary>
        public string TakeOutLenderLicenseNumber { get => _takeOutLenderLicenseNumber; set => SetField(ref _takeOutLenderLicenseNumber, value); }

        /// <summary>
        /// Take-Out Lender Name [CONST.X60]
        /// </summary>
        public string TakeOutLenderName { get => _takeOutLenderName; set => SetField(ref _takeOutLenderName, value); }

        /// <summary>
        /// Take-Out Lender NMLS # [CONST.X61]
        /// </summary>
        public string TakeOutLenderNMLSNumber { get => _takeOutLenderNMLSNumber; set => SetField(ref _takeOutLenderNMLSNumber, value); }

        /// <summary>
        /// Take-Out Lender Phone [CONST.X70]
        /// </summary>
        public string TakeOutLenderPhone { get => _takeOutLenderPhone; set => SetField(ref _takeOutLenderPhone, value); }

        /// <summary>
        /// Take-Out Lender State [CONST.X65]
        /// </summary>
        public string TakeOutLenderState { get => _takeOutLenderState; set => SetField(ref _takeOutLenderState, value); }

        /// <summary>
        /// Take-Out Lender Zipcode [CONST.X66]
        /// </summary>
        public string TakeOutLenderZip { get => _takeOutLenderZip; set => SetField(ref _takeOutLenderZip, value); }

        /// <summary>
        /// Construction Management Project Data - Title Insurance Date [CONST.X18]
        /// </summary>
        public DateTime? TitleInsuranceDate { get => _titleInsuranceDate; set => SetField(ref _titleInsuranceDate, value); }

        /// <summary>
        /// Construction Management Project Data - Title Insurance Indicator [CONST.X17]
        /// </summary>
        public bool? TitleInsuranceIndicator { get => _titleInsuranceIndicator; set => SetField(ref _titleInsuranceIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Utility Letters Date [CONST.X24]
        /// </summary>
        public DateTime? UtilityLettersDate { get => _utilityLettersDate; set => SetField(ref _utilityLettersDate, value); }

        /// <summary>
        /// Construction Management Project Data - Utility Letters Indicator [CONST.X23]
        /// </summary>
        public bool? UtilityLettersIndicator { get => _utilityLettersIndicator; set => SetField(ref _utilityLettersIndicator, value); }

        /// <summary>
        /// Construction Management Project Data - Water Test Date [CONST.X40]
        /// </summary>
        public DateTime? WaterTestDate { get => _waterTestDate; set => SetField(ref _waterTestDate, value); }

        /// <summary>
        /// Construction Management Project Data - Water Test Indicator [CONST.X39]
        /// </summary>
        public bool? WaterTestIndicator { get => _waterTestIndicator; set => SetField(ref _waterTestIndicator, value); }
    }
}