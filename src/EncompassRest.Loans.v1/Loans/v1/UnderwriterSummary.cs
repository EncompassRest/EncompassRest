using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// UnderwriterSummary
    /// </summary>
    public sealed partial class UnderwriterSummary : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _appraisal;
        private DirtyValue<DateTime?>? _appraisalCompletedDate;
        private DirtyValue<DateTime?>? _appraisalExpiredDate;
        private DirtyValue<DateTime?>? _appraisalOrderedDate;
        private DirtyValue<StringEnumValue<UnderwriterSummaryAppraisalType>>? _appraisalType;
        private DirtyValue<DateTime?>? _approvalExpiredDate;
        private DirtyValue<string?>? _approvedBy;
        private DirtyValue<DateTime?>? _approvedDate;
        private DirtyValue<string?>? _ausNumber;
        private DirtyValue<DateTime?>? _ausRunDate;
        private DirtyValue<string?>? _ausSource;
        private DirtyValue<bool?>? _benefitRequiredIndicator;
        private DirtyValue<DateTime?>? _clearToCloseDate;
        private DirtyValue<string?>? _concerns;
        private DirtyValue<string?>? _conditions;
        private DirtyValue<DateTime?>? _counterOfferDate;
        private DirtyValue<StringEnumValue<CounterOfferStatus>>? _counterOfferStatus;
        private DirtyValue<string?>? _credit;
        private DirtyValue<DateTime?>? _creditApprovalDate;
        private DirtyValue<string?>? _deniedBy;
        private DirtyValue<DateTime?>? _deniedDate;
        private DirtyValue<DateTime?>? _differentApprovalExpiredDate;
        private DirtyValue<string?>? _differentApprovedBy;
        private DirtyValue<DateTime?>? _differentApprovedDate;
        private DirtyValue<string?>? _exceptions;
        private DirtyValue<string?>? _exceptionSignOffBy;
        private DirtyValue<DateTime?>? _exceptionSignOffDate;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _isAgencyManually;
        private DirtyValue<bool?>? _isAgencyWaiver;
        private DirtyValue<bool?>? _isAgencyWithAgreement;
        private DirtyValue<decimal?>? _maxRate;
        private DirtyValue<DateTime?>? _miOrderedDate;
        private DirtyValue<DateTime?>? _miReceivedDate;
        private DirtyValue<decimal?>? _modifiedLoanAmount;
        private DirtyValue<decimal?>? _modifiedLoanRate;
        private DirtyValue<int?>? _modifiedLoanTerm;
        private DirtyValue<decimal?>? _modifiedLtv;
        private DirtyValue<decimal?>? _modifiedMonthlyPayment;
        private DirtyValue<string?>? _originalAppraiser;
        private DirtyValue<decimal?>? _originalAppraisersValue;
        private DirtyValue<DateTime?>? _resubmittedDate;
        private DirtyValue<string?>? _reviewAppraiser;
        private DirtyValue<DateTime?>? _reviewCompletedDate;
        private DirtyValue<DateTime?>? _reviewRequestedDate;
        private DirtyValue<StringEnumValue<ReviewType>>? _reviewType;
        private DirtyValue<decimal?>? _reviewValue;
        private DirtyValue<DateTime?>? _sentToDate;
        private DirtyValue<string?>? _signOffBy;
        private DirtyValue<DateTime?>? _signOffDate;
        private DirtyValue<string?>? _strengths;
        private DirtyValue<DateTime?>? _submittedDate;
        private DirtyValue<string?>? _supervisoryAppraiserLicenseNumber;
        private DirtyValue<string?>? _suspendedBy;
        private DirtyValue<DateTime?>? _suspendedDate;
        private DirtyValue<string?>? _suspendedReasons;

        /// <summary>
        /// Underwriting Appraisal Comments [2322]
        /// </summary>
        public string? Appraisal { get => _appraisal; set => SetField(ref _appraisal, value); }

        /// <summary>
        /// Underwriting Appraisal Completed Date [2353]
        /// </summary>
        public DateTime? AppraisalCompletedDate { get => _appraisalCompletedDate; set => SetField(ref _appraisalCompletedDate, value); }

        /// <summary>
        /// Underwriting Appraisal Expired Date [2354]
        /// </summary>
        public DateTime? AppraisalExpiredDate { get => _appraisalExpiredDate; set => SetField(ref _appraisalExpiredDate, value); }

        /// <summary>
        /// Underwriting Appraisal Ordered Date [2352]
        /// </summary>
        public DateTime? AppraisalOrderedDate { get => _appraisalOrderedDate; set => SetField(ref _appraisalOrderedDate, value); }

        /// <summary>
        /// Underwriting Appraisal Type [2356]
        /// </summary>
        public StringEnumValue<UnderwriterSummaryAppraisalType> AppraisalType { get => _appraisalType; set => SetField(ref _appraisalType, value); }

        /// <summary>
        /// Underwriting Approval Expired Date [2302]
        /// </summary>
        public DateTime? ApprovalExpiredDate { get => _approvalExpiredDate; set => SetField(ref _approvalExpiredDate, value); }

        /// <summary>
        /// Underwriting Approved By [2984]
        /// </summary>
        public string? ApprovedBy { get => _approvedBy; set => SetField(ref _approvedBy, value); }

        /// <summary>
        /// Underwriting Approval Date [2301]
        /// </summary>
        public DateTime? ApprovedDate { get => _approvedDate; set => SetField(ref _approvedDate, value); }

        /// <summary>
        /// Underwriting AUS Number [2316]
        /// </summary>
        public string? AusNumber { get => _ausNumber; set => SetField(ref _ausNumber, value); }

        /// <summary>
        /// Underwriting AUS Run [2313]
        /// </summary>
        public DateTime? AusRunDate { get => _ausRunDate; set => SetField(ref _ausRunDate, value); }

        /// <summary>
        /// Underwriting AUS Source [2312]
        /// </summary>
        public string? AusSource { get => _ausSource; set => SetField(ref _ausSource, value); }

        /// <summary>
        /// Underwriting Net Tangible Benefit Required [2983]
        /// </summary>
        public bool? BenefitRequiredIndicator { get => _benefitRequiredIndicator; set => SetField(ref _benefitRequiredIndicator, value); }

        /// <summary>
        /// Underwriting Clear to Close Date [2305]
        /// </summary>
        public DateTime? ClearToCloseDate { get => _clearToCloseDate; set => SetField(ref _clearToCloseDate, value); }

        /// <summary>
        /// Underwriting Concerns [2320]
        /// </summary>
        public string? Concerns { get => _concerns; set => SetField(ref _concerns, value); }

        /// <summary>
        /// Underwriting Appraisal Conditions [2362]
        /// </summary>
        public string? Conditions { get => _conditions; set => SetField(ref _conditions, value); }

        /// <summary>
        /// Underwriting Counter Offer Date [4457]
        /// </summary>
        public DateTime? CounterOfferDate { get => _counterOfferDate; set => SetField(ref _counterOfferDate, value); }

        /// <summary>
        /// Underwriting Counteroffer Status [4458]
        /// </summary>
        public StringEnumValue<CounterOfferStatus> CounterOfferStatus { get => _counterOfferStatus; set => SetField(ref _counterOfferStatus, value); }

        /// <summary>
        /// Underwriting Credit Comments [2321]
        /// </summary>
        public string? Credit { get => _credit; set => SetField(ref _credit, value); }

        /// <summary>
        /// Underwriting Credit Approval Date [2300]
        /// </summary>
        public DateTime? CreditApprovalDate { get => _creditApprovalDate; set => SetField(ref _creditApprovalDate, value); }

        /// <summary>
        /// Underwriting Denied By [2986]
        /// </summary>
        public string? DeniedBy { get => _deniedBy; set => SetField(ref _deniedBy, value); }

        /// <summary>
        /// Underwriting Denied Date [2987]
        /// </summary>
        public DateTime? DeniedDate { get => _deniedDate; set => SetField(ref _deniedDate, value); }

        /// <summary>
        /// Underwriting Different Approval Expired Date [2990]
        /// </summary>
        public DateTime? DifferentApprovalExpiredDate { get => _differentApprovalExpiredDate; set => SetField(ref _differentApprovalExpiredDate, value); }

        /// <summary>
        /// Underwriting Different Approved By [2988]
        /// </summary>
        public string? DifferentApprovedBy { get => _differentApprovedBy; set => SetField(ref _differentApprovedBy, value); }

        /// <summary>
        /// Underwriting Different Approved Date [2989]
        /// </summary>
        public DateTime? DifferentApprovedDate { get => _differentApprovedDate; set => SetField(ref _differentApprovedDate, value); }

        /// <summary>
        /// Underwriting Exceptions Comments [2323]
        /// </summary>
        public string? Exceptions { get => _exceptions; set => SetField(ref _exceptions, value); }

        /// <summary>
        /// Underwriting Exception Sign Off By [2318]
        /// </summary>
        public string? ExceptionSignOffBy { get => _exceptionSignOffBy; set => SetField(ref _exceptionSignOffBy, value); }

        /// <summary>
        /// Underwriting Exception Sign Off Date [2317]
        /// </summary>
        public DateTime? ExceptionSignOffDate { get => _exceptionSignOffDate; set => SetField(ref _exceptionSignOffDate, value); }

        /// <summary>
        /// UnderwriterSummary Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Manually Underwritten according to Agency/GSE Guidelines [3880]
        /// </summary>
        public bool? IsAgencyManually { get => _isAgencyManually; set => SetField(ref _isAgencyManually, value); }

        /// <summary>
        /// Received Waiver for Agency/GSE Guidelines [3879]
        /// </summary>
        public bool? IsAgencyWaiver { get => _isAgencyWaiver; set => SetField(ref _isAgencyWaiver, value); }

        /// <summary>
        /// Underwritten According to Contractual Agreement with Agency/GSE [3878]
        /// </summary>
        public bool? IsAgencyWithAgreement { get => _isAgencyWithAgreement; set => SetField(ref _isAgencyWithAgreement, value); }

        /// <summary>
        /// Underwriting Max Rate [2310]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
        public decimal? MaxRate { get => _maxRate; set => SetField(ref _maxRate, value); }

        /// <summary>
        /// Underwriting MI Ordered Date [2308]
        /// </summary>
        public DateTime? MiOrderedDate { get => _miOrderedDate; set => SetField(ref _miOrderedDate, value); }

        /// <summary>
        /// Underwriting MI Received Date [2309]
        /// </summary>
        public DateTime? MiReceivedDate { get => _miReceivedDate; set => SetField(ref _miReceivedDate, value); }

        /// <summary>
        /// Underwriting Modified Terms Loan Amount [2991]
        /// </summary>
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => SetField(ref _modifiedLoanAmount, value); }

        /// <summary>
        /// Underwriting Modified Terms Interest Rate [2992]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? ModifiedLoanRate { get => _modifiedLoanRate; set => SetField(ref _modifiedLoanRate, value); }

        /// <summary>
        /// Underwriting Modified Terms Loan Term [2993]
        /// </summary>
        public int? ModifiedLoanTerm { get => _modifiedLoanTerm; set => SetField(ref _modifiedLoanTerm, value); }

        /// <summary>
        /// Underwriting Modified Terms Loan to Value [2995]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? ModifiedLtv { get => _modifiedLtv; set => SetField(ref _modifiedLtv, value); }

        /// <summary>
        /// Underwriting Modified Terms Principal and Interest [2994]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => SetField(ref _modifiedMonthlyPayment, value); }

        /// <summary>
        /// Underwriting Original Appraiser [2351]
        /// </summary>
        public string? OriginalAppraiser { get => _originalAppraiser; set => SetField(ref _originalAppraiser, value); }

        /// <summary>
        /// Underwriting Original Appraisers Value [2355]
        /// </summary>
        public decimal? OriginalAppraisersValue { get => _originalAppraisersValue; set => SetField(ref _originalAppraisersValue, value); }

        /// <summary>
        /// Underwriting Resubmitted Date [2299]
        /// </summary>
        public DateTime? ResubmittedDate { get => _resubmittedDate; set => SetField(ref _resubmittedDate, value); }

        /// <summary>
        /// Underwriting Review Appraiser [2357]
        /// </summary>
        public string? ReviewAppraiser { get => _reviewAppraiser; set => SetField(ref _reviewAppraiser, value); }

        /// <summary>
        /// Underwriting Appraisal Review Completed Date [2360]
        /// </summary>
        public DateTime? ReviewCompletedDate { get => _reviewCompletedDate; set => SetField(ref _reviewCompletedDate, value); }

        /// <summary>
        /// Underwriting Appraisal Review Requested Date [2359]
        /// </summary>
        public DateTime? ReviewRequestedDate { get => _reviewRequestedDate; set => SetField(ref _reviewRequestedDate, value); }

        /// <summary>
        /// Underwriting Appraisal Review Type [2358]
        /// </summary>
        public StringEnumValue<ReviewType> ReviewType { get => _reviewType; set => SetField(ref _reviewType, value); }

        /// <summary>
        /// Underwriting Appraisal Review Value [2361]
        /// </summary>
        public decimal? ReviewValue { get => _reviewValue; set => SetField(ref _reviewValue, value); }

        /// <summary>
        /// Underwriting Date Sent to [2981]
        /// </summary>
        public DateTime? SentToDate { get => _sentToDate; set => SetField(ref _sentToDate, value); }

        /// <summary>
        /// Underwriting AUS Sign Off By [2315]
        /// </summary>
        public string? SignOffBy { get => _signOffBy; set => SetField(ref _signOffBy, value); }

        /// <summary>
        /// UnderwriterSummary SignOffDate [2304]
        /// </summary>
        public DateTime? SignOffDate { get => _signOffDate; set => SetField(ref _signOffDate, value); }

        /// <summary>
        /// Underwriting Strengths [2319]
        /// </summary>
        public string? Strengths { get => _strengths; set => SetField(ref _strengths, value); }

        /// <summary>
        /// Underwriting Submitted Date [2298]
        /// </summary>
        public DateTime? SubmittedDate { get => _submittedDate; set => SetField(ref _submittedDate, value); }

        /// <summary>
        /// Supervisory Appraisal Co License # [3243]
        /// </summary>
        public string? SupervisoryAppraiserLicenseNumber { get => _supervisoryAppraiserLicenseNumber; set => SetField(ref _supervisoryAppraiserLicenseNumber, value); }

        /// <summary>
        /// Underwriting Suspended By [2985]
        /// </summary>
        public string? SuspendedBy { get => _suspendedBy; set => SetField(ref _suspendedBy, value); }

        /// <summary>
        /// Underwriting Suspended Date [2303]
        /// </summary>
        public DateTime? SuspendedDate { get => _suspendedDate; set => SetField(ref _suspendedDate, value); }

        /// <summary>
        /// Underwriting Suspended Reasons [2311]
        /// </summary>
        public string? SuspendedReasons { get => _suspendedReasons; set => SetField(ref _suspendedReasons, value); }
    }
}