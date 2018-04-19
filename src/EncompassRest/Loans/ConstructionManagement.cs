using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ConstructionManagement
    /// </summary>
    public sealed partial class ConstructionManagement : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _additionalDisbursementsConditions;
        /// <summary>
        /// Construction Management Project Data - Additional Disbursements Conditions [CONST.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Additional Disbursements Conditions")]
        public string AdditionalDisbursementsConditions { get => _additionalDisbursementsConditions; set => _additionalDisbursementsConditions = value; }
        private DirtyValue<DateTime?> _architectsCertificateDate;
        /// <summary>
        /// Construction Management Project Data - Architect's Certificate Date [CONST.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Architect's Certificate Date")]
        public DateTime? ArchitectsCertificateDate { get => _architectsCertificateDate; set => _architectsCertificateDate = value; }
        private DirtyValue<bool?> _architectsCertificateIndicator;
        /// <summary>
        /// Construction Management Project Data - Architect's Certificate Indicator [CONST.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Architect's Certificate Indicator")]
        public bool? ArchitectsCertificateIndicator { get => _architectsCertificateIndicator; set => _architectsCertificateIndicator = value; }
        private DirtyValue<decimal?> _asCompletedAppraisedValue;
        /// <summary>
        /// As Completed Appraised Value [CONST.X59]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "As Completed Appraised Value")]
        public decimal? AsCompletedAppraisedValue { get => _asCompletedAppraisedValue; set => _asCompletedAppraisedValue = value; }
        private DirtyValue<decimal?> _asCompletedPurchasePrice;
        /// <summary>
        /// As Completed Purchase Price [CONST.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "As Completed Purchase Price")]
        public decimal? AsCompletedPurchasePrice { get => _asCompletedPurchasePrice; set => _asCompletedPurchasePrice = value; }
        private DirtyValue<DateTime?> _budgetDate;
        /// <summary>
        /// Construction Management Project Data - Budget Date [CONST.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Budget Date")]
        public DateTime? BudgetDate { get => _budgetDate; set => _budgetDate = value; }
        private DirtyValue<bool?> _budgetIndicator;
        /// <summary>
        /// Construction Management Project Data - Budget Indicator [CONST.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Budget Indicator")]
        public bool? BudgetIndicator { get => _budgetIndicator; set => _budgetIndicator = value; }
        private DirtyValue<DateTime?> _commitmentExpirationDate;
        /// <summary>
        /// Construction Management Project Data - Commitment Expiration Date [CONST.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Commitment Expiration Date")]
        public DateTime? CommitmentExpirationDate { get => _commitmentExpirationDate; set => _commitmentExpirationDate = value; }
        private DirtyValue<DateTime?> _commitmentLetterDate;
        /// <summary>
        /// Construction Management Project Data - Commitment Letter Date [CONST.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Commitment Letter Date")]
        public DateTime? CommitmentLetterDate { get => _commitmentLetterDate; set => _commitmentLetterDate = value; }
        private DirtyValue<DateTime?> _constCompletionDate;
        /// <summary>
        /// Construction Management Loan Info - Const. Completion Date [CONST.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Loan Info - Const. Completion Date")]
        public DateTime? ConstCompletionDate { get => _constCompletionDate; set => _constCompletionDate = value; }
        private DirtyValue<StringEnumValue<ConstOnlyAmortizationType>> _constOnlyAmortizationType;
        /// <summary>
        /// Construction Management Loan Info - Construction Only Amortization Type [CONST.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Loan Info - Construction Only Amortization Type")]
        public StringEnumValue<ConstOnlyAmortizationType> ConstOnlyAmortizationType { get => _constOnlyAmortizationType; set => _constOnlyAmortizationType = value; }
        private DirtyValue<bool?> _constructionContractIndicator;
        /// <summary>
        /// Construction Management Project Data - Construction Contract Indicator [CONST.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Construction Contract Indicator")]
        public bool? ConstructionContractIndicator { get => _constructionContractIndicator; set => _constructionContractIndicator = value; }
        private DirtyValue<DateTime?> _constructionContractIssuedDate;
        /// <summary>
        /// Construction Management Project Data - Construction Contract Issued Date [CONST.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Construction Contract Issued Date")]
        public DateTime? ConstructionContractIssuedDate { get => _constructionContractIssuedDate; set => _constructionContractIssuedDate = value; }
        private DirtyValue<DateTime?> _constructionContractReceivedDate;
        /// <summary>
        /// Construction Management Project Data - Construction Contract Received Date [CONST.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Construction Contract Received Date")]
        public DateTime? ConstructionContractReceivedDate { get => _constructionContractReceivedDate; set => _constructionContractReceivedDate = value; }
        private DirtyValue<bool?> _constructionPeriodIncludedInLoanTermFlag;
        /// <summary>
        /// Construction period included in the Loan Terms Flag [CONST.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Construction period included in the Loan Terms Flag")]
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get => _constructionPeriodIncludedInLoanTermFlag; set => _constructionPeriodIncludedInLoanTermFlag = value; }
        private DirtyValue<DateTime?> _contractorsAgreementDate;
        /// <summary>
        /// Construction Management Project Data - Contractor's Agreement Date [CONST.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Contractor's Agreement Date")]
        public DateTime? ContractorsAgreementDate { get => _contractorsAgreementDate; set => _contractorsAgreementDate = value; }
        private DirtyValue<bool?> _contractorsAgreementIndicator;
        /// <summary>
        /// Construction Management Project Data - Contractor's Agreement Indicator [CONST.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Contractor's Agreement Indicator")]
        public bool? ContractorsAgreementIndicator { get => _contractorsAgreementIndicator; set => _contractorsAgreementIndicator = value; }
        private DirtyValue<bool?> _costImprovementsIncluded;
        /// <summary>
        /// Cost of Improvements Included in Liabilities [CONST.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Cost of Improvements Included in Liabilities")]
        public bool? CostImprovementsIncluded { get => _costImprovementsIncluded; set => _costImprovementsIncluded = value; }
        private DirtyValue<DateTime?> _environmentalAssessmentDate;
        /// <summary>
        /// Construction Management Project Data - Environmental Assessment Date [CONST.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Environmental Assessment Date")]
        public DateTime? EnvironmentalAssessmentDate { get => _environmentalAssessmentDate; set => _environmentalAssessmentDate = value; }
        private DirtyValue<bool?> _environmentalAssessmentIndicator;
        /// <summary>
        /// Construction Management Project Data - Environmental Assessment Indicator [CONST.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Environmental Assessment Indicator")]
        public bool? EnvironmentalAssessmentIndicator { get => _environmentalAssessmentIndicator; set => _environmentalAssessmentIndicator = value; }
        private DirtyValue<DateTime?> _floodHazardDeterminationDate;
        /// <summary>
        /// Construction Management Project Data - Flood Hazard Determination Date [CONST.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Flood Hazard Determination Date")]
        public DateTime? FloodHazardDeterminationDate { get => _floodHazardDeterminationDate; set => _floodHazardDeterminationDate = value; }
        private DirtyValue<bool?> _floodHazardDeterminationIndicator;
        /// <summary>
        /// Construction Management Project Data - Flood Hazard Determination Indicator [CONST.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Flood Hazard Determination Indicator")]
        public bool? FloodHazardDeterminationIndicator { get => _floodHazardDeterminationIndicator; set => _floodHazardDeterminationIndicator = value; }
        private DirtyValue<int?> _futureAdvancePeriod;
        /// <summary>
        /// Construction Management Project Data - Future Advance Period (mths) [CONST.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Future Advance Period (mths)")]
        public int? FutureAdvancePeriod { get => _futureAdvancePeriod; set => _futureAdvancePeriod = value; }
        private DirtyValue<decimal?> _holdbackAmount;
        /// <summary>
        /// Construction Management Loan Info - Holdback $ [CONST.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Construction Management Loan Info - Holdback $")]
        public decimal? HoldbackAmount { get => _holdbackAmount; set => _holdbackAmount = value; }
        private DirtyValue<decimal?> _holdbackPercent;
        /// <summary>
        /// Construction Management Loan Info - Holdback % [CONST.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Construction Management Loan Info - Holdback %")]
        public decimal? HoldbackPercent { get => _holdbackPercent; set => _holdbackPercent = value; }
        private DirtyValue<DateTime?> _lienAgentNorthCarolinaDate;
        /// <summary>
        /// Construction Management Project Data - Lien Agent (North Carolina) Date [CONST.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Lien Agent (North Carolina) Date")]
        public DateTime? LienAgentNorthCarolinaDate { get => _lienAgentNorthCarolinaDate; set => _lienAgentNorthCarolinaDate = value; }
        private DirtyValue<bool?> _lienAgentNorthCarolinaIndicator;
        /// <summary>
        /// Construction Management Project Data - Lien Agent (North Carolina) Indicator [CONST.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Lien Agent (North Carolina) Indicator")]
        public bool? LienAgentNorthCarolinaIndicator { get => _lienAgentNorthCarolinaIndicator; set => _lienAgentNorthCarolinaIndicator = value; }
        private DirtyValue<DateTime?> _listOfConstructionAgreementsDate;
        /// <summary>
        /// Construction Management Project Data - List of Construction Agreements Date [CONST.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - List of Construction Agreements Date")]
        public DateTime? ListOfConstructionAgreementsDate { get => _listOfConstructionAgreementsDate; set => _listOfConstructionAgreementsDate = value; }
        private DirtyValue<bool?> _listOfConstructionAgreementsIndicator;
        /// <summary>
        /// Construction Management Project Data - List of Construction Agreements Indicator [CONST.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - List of Construction Agreements Indicator")]
        public bool? ListOfConstructionAgreementsIndicator { get => _listOfConstructionAgreementsIndicator; set => _listOfConstructionAgreementsIndicator = value; }
        private DirtyValue<decimal?> _maxLTVPercent;
        /// <summary>
        /// Construction Management Loan Info - Max LTV % [CONST.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Construction Management Loan Info - Max LTV %")]
        public decimal? MaxLTVPercent { get => _maxLTVPercent; set => _maxLTVPercent = value; }
        private DirtyValue<int?> _minimumDaysBetweenDisbursements;
        /// <summary>
        /// Construction Management Project Data - Minimum days between disbursements [CONST.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Minimum days between disbursements")]
        public int? MinimumDaysBetweenDisbursements { get => _minimumDaysBetweenDisbursements; set => _minimumDaysBetweenDisbursements = value; }
        private DirtyValue<DateTime?> _otherDate;
        /// <summary>
        /// Construction Management Project Data - Other Date [CONST.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Other Date")]
        public DateTime? OtherDate { get => _otherDate; set => _otherDate = value; }
        private DirtyValue<string> _otherDescription;
        /// <summary>
        /// Construction Management Project Data - Other Description [CONST.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Other Description")]
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _otherIndicator;
        /// <summary>
        /// Construction Management Project Data - Other Indicator [CONST.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Other Indicator")]
        public bool? OtherIndicator { get => _otherIndicator; set => _otherIndicator = value; }
        private DirtyValue<StringEnumValue<PartialPrepaymentsElection>> _partialPrepaymentsElection;
        /// <summary>
        /// Partial Prepayments Election [CONST.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Partial Prepayments Election")]
        public StringEnumValue<PartialPrepaymentsElection> PartialPrepaymentsElection { get => _partialPrepaymentsElection; set => _partialPrepaymentsElection = value; }
        private DirtyValue<DateTime?> _paymentAndPerformanceBondsDate;
        /// <summary>
        /// Construction Management Project Data - Payment and Performance Bonds Date [CONST.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Payment and Performance Bonds Date")]
        public DateTime? PaymentAndPerformanceBondsDate { get => _paymentAndPerformanceBondsDate; set => _paymentAndPerformanceBondsDate = value; }
        private DirtyValue<bool?> _paymentAndPerformanceBondsIndicator;
        /// <summary>
        /// Construction Management Project Data - Payment and Performance Bonds Indicator [CONST.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Payment and Performance Bonds Indicator")]
        public bool? PaymentAndPerformanceBondsIndicator { get => _paymentAndPerformanceBondsIndicator; set => _paymentAndPerformanceBondsIndicator = value; }
        private DirtyValue<DateTime?> _percolationTestDate;
        /// <summary>
        /// Construction Management Project Data - Percolation Test Date [CONST.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Percolation Test Date")]
        public DateTime? PercolationTestDate { get => _percolationTestDate; set => _percolationTestDate = value; }
        private DirtyValue<bool?> _percolationTestIndicator;
        /// <summary>
        /// Construction Management Project Data - Percolation Test Indicator [CONST.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Percolation Test Indicator")]
        public bool? PercolationTestIndicator { get => _percolationTestIndicator; set => _percolationTestIndicator = value; }
        private DirtyValue<DateTime?> _permitsDate;
        /// <summary>
        /// Construction Management Project Data - Permits Date [CONST.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Permits Date")]
        public DateTime? PermitsDate { get => _permitsDate; set => _permitsDate = value; }
        private DirtyValue<bool?> _permitsIndicator;
        /// <summary>
        /// Construction Management Project Data - Permits Indicator [CONST.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Permits Indicator")]
        public bool? PermitsIndicator { get => _permitsIndicator; set => _permitsIndicator = value; }
        private DirtyValue<DateTime?> _plansAndSpecificationsDate;
        /// <summary>
        /// Construction Management Project Data - Plans and Specifications Date [CONST.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Plans and Specifications Date")]
        public DateTime? PlansAndSpecificationsDate { get => _plansAndSpecificationsDate; set => _plansAndSpecificationsDate = value; }
        private DirtyValue<bool?> _plansAndSpecificationsIndicator;
        /// <summary>
        /// Construction Management Project Data - Plans and Specifications Indicator [CONST.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Plans and Specifications Indicator")]
        public bool? PlansAndSpecificationsIndicator { get => _plansAndSpecificationsIndicator; set => _plansAndSpecificationsIndicator = value; }
        private DirtyValue<decimal?> _projectDelaySurchargePercent;
        /// <summary>
        /// Construction Management Loan Info - Project Delay Surcharge % [CONST.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Construction Management Loan Info - Project Delay Surcharge %")]
        public decimal? ProjectDelaySurchargePercent { get => _projectDelaySurchargePercent; set => _projectDelaySurchargePercent = value; }
        private DirtyValue<int?> _returnLendersCopyCommitmentDays;
        /// <summary>
        /// Construction Management Project Data - Return Lender's copy of this commitment within days [CONST.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Return Lender's copy of this commitment within days")]
        public int? ReturnLendersCopyCommitmentDays { get => _returnLendersCopyCommitmentDays; set => _returnLendersCopyCommitmentDays = value; }
        private DirtyValue<bool?> _securedBySeparateProperty;
        /// <summary>
        /// Construction Management Loan Info - Secured by Separate Property [CONST.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Loan Info - Secured by Separate Property")]
        public bool? SecuredBySeparateProperty { get => _securedBySeparateProperty; set => _securedBySeparateProperty = value; }
        private DirtyValue<DateTime?> _soilReportDate;
        /// <summary>
        /// Construction Management Project Data - Soil Report Date [CONST.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Soil Report Date")]
        public DateTime? SoilReportDate { get => _soilReportDate; set => _soilReportDate = value; }
        private DirtyValue<bool?> _soilReportIndicator;
        /// <summary>
        /// Construction Management Project Data - Soil Report Indicator [CONST.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Soil Report Indicator")]
        public bool? SoilReportIndicator { get => _soilReportIndicator; set => _soilReportIndicator = value; }
        private DirtyValue<DateTime?> _surveyDate;
        /// <summary>
        /// Construction Management Project Data - Survey Date [CONST.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Survey Date")]
        public DateTime? SurveyDate { get => _surveyDate; set => _surveyDate = value; }
        private DirtyValue<bool?> _surveyIndicator;
        /// <summary>
        /// Construction Management Project Data - Survey Indicator [CONST.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Survey Indicator")]
        public bool? SurveyIndicator { get => _surveyIndicator; set => _surveyIndicator = value; }
        private DirtyValue<DateTime?> _takeOutCommitmentDate;
        /// <summary>
        /// Construction Management Project Data - Take-out Commitment Date [CONST.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Take-out Commitment Date")]
        public DateTime? TakeOutCommitmentDate { get => _takeOutCommitmentDate; set => _takeOutCommitmentDate = value; }
        private DirtyValue<bool?> _takeOutCommitmentIndicator;
        /// <summary>
        /// Construction Management Project Data - Take-out Commitment Indicator [CONST.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Take-out Commitment Indicator")]
        public bool? TakeOutCommitmentIndicator { get => _takeOutCommitmentIndicator; set => _takeOutCommitmentIndicator = value; }
        private DirtyValue<DateTime?> _takeOutCommitmentIssuedDate;
        /// <summary>
        /// Take-Out Commitment Letter Date [CONST.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Commitment Letter Date")]
        public DateTime? TakeOutCommitmentIssuedDate { get => _takeOutCommitmentIssuedDate; set => _takeOutCommitmentIssuedDate = value; }
        private DirtyValue<string> _takeOutLenderAddress;
        /// <summary>
        /// Take-Out Lender Address [CONST.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Address")]
        public string TakeOutLenderAddress { get => _takeOutLenderAddress; set => _takeOutLenderAddress = value; }
        private DirtyValue<string> _takeOutLenderCity;
        /// <summary>
        /// Take-Out Lender City [CONST.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender City")]
        public string TakeOutLenderCity { get => _takeOutLenderCity; set => _takeOutLenderCity = value; }
        private DirtyValue<string> _takeOutLenderContactName;
        /// <summary>
        /// Take-Out Lender Contact Name [CONST.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Contact Name")]
        public string TakeOutLenderContactName { get => _takeOutLenderContactName; set => _takeOutLenderContactName = value; }
        private DirtyValue<string> _takeOutLenderContactTitle;
        /// <summary>
        /// Take-Out Lender Contact Title [CONST.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Contact Title")]
        public string TakeOutLenderContactTitle { get => _takeOutLenderContactTitle; set => _takeOutLenderContactTitle = value; }
        private DirtyValue<string> _takeOutLenderEmail;
        /// <summary>
        /// Take-Out Lender Email [CONST.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Email")]
        public string TakeOutLenderEmail { get => _takeOutLenderEmail; set => _takeOutLenderEmail = value; }
        private DirtyValue<string> _takeOutLenderFax;
        /// <summary>
        /// Take-Out Lender Fax [CONST.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Fax")]
        public string TakeOutLenderFax { get => _takeOutLenderFax; set => _takeOutLenderFax = value; }
        private DirtyValue<string> _takeOutLenderLicenseNumber;
        /// <summary>
        /// Take-Out Lender License # [CONST.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender License #")]
        public string TakeOutLenderLicenseNumber { get => _takeOutLenderLicenseNumber; set => _takeOutLenderLicenseNumber = value; }
        private DirtyValue<string> _takeOutLenderName;
        /// <summary>
        /// Take-Out Lender Name [CONST.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Name")]
        public string TakeOutLenderName { get => _takeOutLenderName; set => _takeOutLenderName = value; }
        private DirtyValue<string> _takeOutLenderNMLSNumber;
        /// <summary>
        /// Take-Out Lender NMLS # [CONST.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender NMLS #")]
        public string TakeOutLenderNMLSNumber { get => _takeOutLenderNMLSNumber; set => _takeOutLenderNMLSNumber = value; }
        private DirtyValue<string> _takeOutLenderPhone;
        /// <summary>
        /// Take-Out Lender Phone [CONST.X70]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Phone")]
        public string TakeOutLenderPhone { get => _takeOutLenderPhone; set => _takeOutLenderPhone = value; }
        private DirtyValue<string> _takeOutLenderState;
        /// <summary>
        /// Take-Out Lender State [CONST.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender State")]
        public string TakeOutLenderState { get => _takeOutLenderState; set => _takeOutLenderState = value; }
        private DirtyValue<string> _takeOutLenderZip;
        /// <summary>
        /// Take-Out Lender Zipcode [CONST.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Take-Out Lender Zipcode")]
        public string TakeOutLenderZip { get => _takeOutLenderZip; set => _takeOutLenderZip = value; }
        private DirtyValue<DateTime?> _titleInsuranceDate;
        /// <summary>
        /// Construction Management Project Data - Title Insurance Date [CONST.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Title Insurance Date")]
        public DateTime? TitleInsuranceDate { get => _titleInsuranceDate; set => _titleInsuranceDate = value; }
        private DirtyValue<bool?> _titleInsuranceIndicator;
        /// <summary>
        /// Construction Management Project Data - Title Insurance Indicator [CONST.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Title Insurance Indicator")]
        public bool? TitleInsuranceIndicator { get => _titleInsuranceIndicator; set => _titleInsuranceIndicator = value; }
        private DirtyValue<DateTime?> _utilityLettersDate;
        /// <summary>
        /// Construction Management Project Data - Utility Letters Date [CONST.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Utility Letters Date")]
        public DateTime? UtilityLettersDate { get => _utilityLettersDate; set => _utilityLettersDate = value; }
        private DirtyValue<bool?> _utilityLettersIndicator;
        /// <summary>
        /// Construction Management Project Data - Utility Letters Indicator [CONST.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Utility Letters Indicator")]
        public bool? UtilityLettersIndicator { get => _utilityLettersIndicator; set => _utilityLettersIndicator = value; }
        private DirtyValue<DateTime?> _waterTestDate;
        /// <summary>
        /// Construction Management Project Data - Water Test Date [CONST.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Water Test Date")]
        public DateTime? WaterTestDate { get => _waterTestDate; set => _waterTestDate = value; }
        private DirtyValue<bool?> _waterTestIndicator;
        /// <summary>
        /// Construction Management Project Data - Water Test Indicator [CONST.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Management Project Data - Water Test Indicator")]
        public bool? WaterTestIndicator { get => _waterTestIndicator; set => _waterTestIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _additionalDisbursementsConditions.Dirty
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
                || _costImprovementsIncluded.Dirty
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
                _costImprovementsIncluded.Dirty = value;
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