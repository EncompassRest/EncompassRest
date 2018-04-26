using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UnderwriterSummary
    /// </summary>
    public sealed partial class UnderwriterSummary : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _appraisal;
        /// <summary>
        /// Underwriting Appraisal Comments [2322]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Comments")]
        public string Appraisal { get => _appraisal; set => _appraisal = value; }
        private DirtyValue<DateTime?> _appraisalCompletedDate;
        /// <summary>
        /// Underwriting Appraisal Completed Date [2353]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Completed Date")]
        public DateTime? AppraisalCompletedDate { get => _appraisalCompletedDate; set => _appraisalCompletedDate = value; }
        private DirtyValue<DateTime?> _appraisalExpiredDate;
        /// <summary>
        /// Underwriting Appraisal Expired Date [2354]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Expired Date")]
        public DateTime? AppraisalExpiredDate { get => _appraisalExpiredDate; set => _appraisalExpiredDate = value; }
        private DirtyValue<DateTime?> _appraisalOrderedDate;
        /// <summary>
        /// Underwriting Appraisal Ordered Date [2352]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Ordered Date")]
        public DateTime? AppraisalOrderedDate { get => _appraisalOrderedDate; set => _appraisalOrderedDate = value; }
        private DirtyValue<StringEnumValue<UnderwriterSummaryAppraisalType>> _appraisalType;
        /// <summary>
        /// Underwriting Appraisal Type [2356]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Type")]
        public StringEnumValue<UnderwriterSummaryAppraisalType> AppraisalType { get => _appraisalType; set => _appraisalType = value; }
        private DirtyValue<DateTime?> _approvalExpiredDate;
        /// <summary>
        /// Underwriting Approval Expired Date [2302]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Approval Expired Date")]
        public DateTime? ApprovalExpiredDate { get => _approvalExpiredDate; set => _approvalExpiredDate = value; }
        private DirtyValue<string> _approvedBy;
        /// <summary>
        /// Underwriting Approved By [2984]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Approved By")]
        public string ApprovedBy { get => _approvedBy; set => _approvedBy = value; }
        private DirtyValue<DateTime?> _approvedDate;
        /// <summary>
        /// Underwriting Approval Date [2301]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Approval Date")]
        public DateTime? ApprovedDate { get => _approvedDate; set => _approvedDate = value; }
        private DirtyValue<string> _ausNumber;
        /// <summary>
        /// Underwriting AUS Number [2316]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting AUS Number")]
        public string AusNumber { get => _ausNumber; set => _ausNumber = value; }
        private DirtyValue<DateTime?> _ausRunDate;
        /// <summary>
        /// Underwriting AUS Run [2313]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting AUS Run")]
        public DateTime? AusRunDate { get => _ausRunDate; set => _ausRunDate = value; }
        private DirtyValue<string> _ausSource;
        /// <summary>
        /// Underwriting AUS Source [2312]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting AUS Source")]
        public string AusSource { get => _ausSource; set => _ausSource = value; }
        private DirtyValue<bool?> _benefitRequiredIndicator;
        /// <summary>
        /// Underwriting Net Tangible Benefit Required [2983]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Net Tangible Benefit Required")]
        public bool? BenefitRequiredIndicator { get => _benefitRequiredIndicator; set => _benefitRequiredIndicator = value; }
        private DirtyValue<DateTime?> _clearToCloseDate;
        /// <summary>
        /// Underwriting Clear to Close Date [2305]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Clear to Close Date")]
        public DateTime? ClearToCloseDate { get => _clearToCloseDate; set => _clearToCloseDate = value; }
        private DirtyValue<string> _concerns;
        /// <summary>
        /// Underwriting Concerns [2320]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Concerns")]
        public string Concerns { get => _concerns; set => _concerns = value; }
        private DirtyValue<string> _conditions;
        /// <summary>
        /// Underwriting Appraisal Conditions [2362]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Conditions")]
        public string Conditions { get => _conditions; set => _conditions = value; }
        private DirtyValue<DateTime?> _counterOfferDate;
        /// <summary>
        /// Underwriting Counter Offer Date [4457]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Counter Offer Date")]
        public DateTime? CounterOfferDate { get => _counterOfferDate; set => _counterOfferDate = value; }
        private DirtyValue<StringEnumValue<CounterOfferStatus>> _counterOfferStatus;
        /// <summary>
        /// Underwriting Counteroffer Status [4458]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Counteroffer Status")]
        public StringEnumValue<CounterOfferStatus> CounterOfferStatus { get => _counterOfferStatus; set => _counterOfferStatus = value; }
        private DirtyValue<string> _credit;
        /// <summary>
        /// Underwriting Credit Comments [2321]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Credit Comments")]
        public string Credit { get => _credit; set => _credit = value; }
        private DirtyValue<DateTime?> _creditApprovalDate;
        /// <summary>
        /// Underwriting Credit Approval Date [2300]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Credit Approval Date")]
        public DateTime? CreditApprovalDate { get => _creditApprovalDate; set => _creditApprovalDate = value; }
        private DirtyValue<string> _deniedBy;
        /// <summary>
        /// Underwriting Denied By [2986]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Denied By")]
        public string DeniedBy { get => _deniedBy; set => _deniedBy = value; }
        private DirtyValue<DateTime?> _deniedDate;
        /// <summary>
        /// Underwriting Denied Date [2987]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Denied Date")]
        public DateTime? DeniedDate { get => _deniedDate; set => _deniedDate = value; }
        private DirtyValue<DateTime?> _differentApprovalExpiredDate;
        /// <summary>
        /// Underwriting Different Approval Expired Date [2990]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Different Approval Expired Date")]
        public DateTime? DifferentApprovalExpiredDate { get => _differentApprovalExpiredDate; set => _differentApprovalExpiredDate = value; }
        private DirtyValue<string> _differentApprovedBy;
        /// <summary>
        /// Underwriting Different Approved By [2988]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Different Approved By")]
        public string DifferentApprovedBy { get => _differentApprovedBy; set => _differentApprovedBy = value; }
        private DirtyValue<DateTime?> _differentApprovedDate;
        /// <summary>
        /// Underwriting Different Approved Date [2989]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Different Approved Date")]
        public DateTime? DifferentApprovedDate { get => _differentApprovedDate; set => _differentApprovedDate = value; }
        private DirtyValue<string> _exceptions;
        /// <summary>
        /// Underwriting Exceptions Comments [2323]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Exceptions Comments")]
        public string Exceptions { get => _exceptions; set => _exceptions = value; }
        private DirtyValue<string> _exceptionSignOffBy;
        /// <summary>
        /// Underwriting Exception Sign Off By [2318]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Exception Sign Off By")]
        public string ExceptionSignOffBy { get => _exceptionSignOffBy; set => _exceptionSignOffBy = value; }
        private DirtyValue<DateTime?> _exceptionSignOffDate;
        /// <summary>
        /// Underwriting Exception Sign Off Date [2317]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Exception Sign Off Date")]
        public DateTime? ExceptionSignOffDate { get => _exceptionSignOffDate; set => _exceptionSignOffDate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// UnderwriterSummary Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isAgencyManually;
        /// <summary>
        /// Manually Underwritten according to Agency/GSE Guidelines [3880]
        /// </summary>
        [LoanFieldProperty(Description = "Manually Underwritten according to Agency/GSE Guidelines")]
        public bool? IsAgencyManually { get => _isAgencyManually; set => _isAgencyManually = value; }
        private DirtyValue<bool?> _isAgencyWaiver;
        /// <summary>
        /// Received Waiver for Agency/GSE Guidelines [3879]
        /// </summary>
        [LoanFieldProperty(Description = "Received Waiver for Agency/GSE Guidelines")]
        public bool? IsAgencyWaiver { get => _isAgencyWaiver; set => _isAgencyWaiver = value; }
        private DirtyValue<bool?> _isAgencyWithAgreement;
        /// <summary>
        /// Underwritten According to Contractual Agreement with Agency/GSE [3878]
        /// </summary>
        [LoanFieldProperty(Description = "Underwritten According to Contractual Agreement with Agency/GSE")]
        public bool? IsAgencyWithAgreement { get => _isAgencyWithAgreement; set => _isAgencyWithAgreement = value; }
        private DirtyValue<decimal?> _maxRate;
        /// <summary>
        /// Underwriting Max Rate [2310]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Underwriting Max Rate")]
        public decimal? MaxRate { get => _maxRate; set => _maxRate = value; }
        private DirtyValue<DateTime?> _miOrderedDate;
        /// <summary>
        /// Underwriting MI Ordered Date [2308]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting MI Ordered Date")]
        public DateTime? MiOrderedDate { get => _miOrderedDate; set => _miOrderedDate = value; }
        private DirtyValue<DateTime?> _miReceivedDate;
        /// <summary>
        /// Underwriting MI Received Date [2309]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting MI Received Date")]
        public DateTime? MiReceivedDate { get => _miReceivedDate; set => _miReceivedDate = value; }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        /// <summary>
        /// Underwriting Modified Terms Loan Amount [2991]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Modified Terms Loan Amount")]
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => _modifiedLoanAmount = value; }
        private DirtyValue<decimal?> _modifiedLoanRate;
        /// <summary>
        /// Underwriting Modified Terms Interest Rate [2992]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Underwriting Modified Terms Interest Rate")]
        public decimal? ModifiedLoanRate { get => _modifiedLoanRate; set => _modifiedLoanRate = value; }
        private DirtyValue<int?> _modifiedLoanTerm;
        /// <summary>
        /// Underwriting Modified Terms Loan Term [2993]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Modified Terms Loan Term")]
        public int? ModifiedLoanTerm { get => _modifiedLoanTerm; set => _modifiedLoanTerm = value; }
        private DirtyValue<decimal?> _modifiedLtv;
        /// <summary>
        /// Underwriting Modified Terms Loan to Value [2995]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "Underwriting Modified Terms Loan to Value")]
        public decimal? ModifiedLtv { get => _modifiedLtv; set => _modifiedLtv = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        /// <summary>
        /// Underwriting Modified Terms Principal and Interest [2994]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Underwriting Modified Terms Principal and Interest")]
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => _modifiedMonthlyPayment = value; }
        private DirtyValue<string> _originalAppraiser;
        /// <summary>
        /// Underwriting Original Appraiser [2351]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Original Appraiser")]
        public string OriginalAppraiser { get => _originalAppraiser; set => _originalAppraiser = value; }
        private DirtyValue<decimal?> _originalAppraisersValue;
        /// <summary>
        /// Underwriting Original Appraisers Value [2355]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Original Appraisers Value")]
        public decimal? OriginalAppraisersValue { get => _originalAppraisersValue; set => _originalAppraisersValue = value; }
        private DirtyValue<DateTime?> _resubmittedDate;
        /// <summary>
        /// Underwriting Resubmitted Date [2299]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Resubmitted Date")]
        public DateTime? ResubmittedDate { get => _resubmittedDate; set => _resubmittedDate = value; }
        private DirtyValue<string> _reviewAppraiser;
        /// <summary>
        /// Underwriting Review Appraiser [2357]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Review Appraiser")]
        public string ReviewAppraiser { get => _reviewAppraiser; set => _reviewAppraiser = value; }
        private DirtyValue<DateTime?> _reviewCompletedDate;
        /// <summary>
        /// Underwriting Appraisal Review Completed Date [2360]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Review Completed Date")]
        public DateTime? ReviewCompletedDate { get => _reviewCompletedDate; set => _reviewCompletedDate = value; }
        private DirtyValue<DateTime?> _reviewRequestedDate;
        /// <summary>
        /// Underwriting Appraisal Review Requested Date [2359]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Review Requested Date")]
        public DateTime? ReviewRequestedDate { get => _reviewRequestedDate; set => _reviewRequestedDate = value; }
        private DirtyValue<StringEnumValue<ReviewType>> _reviewType;
        /// <summary>
        /// Underwriting Appraisal Review Type [2358]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Appraisal Review Type")]
        public StringEnumValue<ReviewType> ReviewType { get => _reviewType; set => _reviewType = value; }
        private DirtyValue<decimal?> _reviewValue;
        /// <summary>
        /// Underwriting Appraisal Review Value [2361]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Underwriting Appraisal Review Value")]
        public decimal? ReviewValue { get => _reviewValue; set => _reviewValue = value; }
        private DirtyValue<DateTime?> _sentToDate;
        /// <summary>
        /// Underwriting Date Sent to [2981]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Date Sent to")]
        public DateTime? SentToDate { get => _sentToDate; set => _sentToDate = value; }
        private DirtyValue<string> _signOffBy;
        /// <summary>
        /// Underwriting AUS Sign Off By [2315]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting AUS Sign Off By")]
        public string SignOffBy { get => _signOffBy; set => _signOffBy = value; }
        private DirtyValue<DateTime?> _signOffDate;
        /// <summary>
        /// UnderwriterSummary SignOffDate [2304]
        /// </summary>
        public DateTime? SignOffDate { get => _signOffDate; set => _signOffDate = value; }
        private DirtyValue<string> _strengths;
        /// <summary>
        /// Underwriting Strengths [2319]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Strengths")]
        public string Strengths { get => _strengths; set => _strengths = value; }
        private DirtyValue<DateTime?> _submittedDate;
        /// <summary>
        /// Underwriting Submitted Date [2298]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Submitted Date")]
        public DateTime? SubmittedDate { get => _submittedDate; set => _submittedDate = value; }
        private DirtyValue<string> _supervisoryAppraiserLicenseNumber;
        /// <summary>
        /// Supervisory Appraisal Co License # [3243]
        /// </summary>
        [LoanFieldProperty(Description = "Supervisory Appraisal Co License #")]
        public string SupervisoryAppraiserLicenseNumber { get => _supervisoryAppraiserLicenseNumber; set => _supervisoryAppraiserLicenseNumber = value; }
        private DirtyValue<string> _suspendedBy;
        /// <summary>
        /// Underwriting Suspended By [2985]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Suspended By")]
        public string SuspendedBy { get => _suspendedBy; set => _suspendedBy = value; }
        private DirtyValue<DateTime?> _suspendedDate;
        /// <summary>
        /// Underwriting Suspended Date [2303]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Suspended Date")]
        public DateTime? SuspendedDate { get => _suspendedDate; set => _suspendedDate = value; }
        private DirtyValue<string> _suspendedReasons;
        /// <summary>
        /// Underwriting Suspended Reasons [2311]
        /// </summary>
        [LoanFieldProperty(Description = "Underwriting Suspended Reasons")]
        public string SuspendedReasons { get => _suspendedReasons; set => _suspendedReasons = value; }
        internal override bool DirtyInternal
        {
            get => _appraisal.Dirty
                || _appraisalCompletedDate.Dirty
                || _appraisalExpiredDate.Dirty
                || _appraisalOrderedDate.Dirty
                || _appraisalType.Dirty
                || _approvalExpiredDate.Dirty
                || _approvedBy.Dirty
                || _approvedDate.Dirty
                || _ausNumber.Dirty
                || _ausRunDate.Dirty
                || _ausSource.Dirty
                || _benefitRequiredIndicator.Dirty
                || _clearToCloseDate.Dirty
                || _concerns.Dirty
                || _conditions.Dirty
                || _counterOfferDate.Dirty
                || _counterOfferStatus.Dirty
                || _credit.Dirty
                || _creditApprovalDate.Dirty
                || _deniedBy.Dirty
                || _deniedDate.Dirty
                || _differentApprovalExpiredDate.Dirty
                || _differentApprovedBy.Dirty
                || _differentApprovedDate.Dirty
                || _exceptions.Dirty
                || _exceptionSignOffBy.Dirty
                || _exceptionSignOffDate.Dirty
                || _id.Dirty
                || _isAgencyManually.Dirty
                || _isAgencyWaiver.Dirty
                || _isAgencyWithAgreement.Dirty
                || _maxRate.Dirty
                || _miOrderedDate.Dirty
                || _miReceivedDate.Dirty
                || _modifiedLoanAmount.Dirty
                || _modifiedLoanRate.Dirty
                || _modifiedLoanTerm.Dirty
                || _modifiedLtv.Dirty
                || _modifiedMonthlyPayment.Dirty
                || _originalAppraiser.Dirty
                || _originalAppraisersValue.Dirty
                || _resubmittedDate.Dirty
                || _reviewAppraiser.Dirty
                || _reviewCompletedDate.Dirty
                || _reviewRequestedDate.Dirty
                || _reviewType.Dirty
                || _reviewValue.Dirty
                || _sentToDate.Dirty
                || _signOffBy.Dirty
                || _signOffDate.Dirty
                || _strengths.Dirty
                || _submittedDate.Dirty
                || _supervisoryAppraiserLicenseNumber.Dirty
                || _suspendedBy.Dirty
                || _suspendedDate.Dirty
                || _suspendedReasons.Dirty;
            set
            {
                _appraisal.Dirty = value;
                _appraisalCompletedDate.Dirty = value;
                _appraisalExpiredDate.Dirty = value;
                _appraisalOrderedDate.Dirty = value;
                _appraisalType.Dirty = value;
                _approvalExpiredDate.Dirty = value;
                _approvedBy.Dirty = value;
                _approvedDate.Dirty = value;
                _ausNumber.Dirty = value;
                _ausRunDate.Dirty = value;
                _ausSource.Dirty = value;
                _benefitRequiredIndicator.Dirty = value;
                _clearToCloseDate.Dirty = value;
                _concerns.Dirty = value;
                _conditions.Dirty = value;
                _counterOfferDate.Dirty = value;
                _counterOfferStatus.Dirty = value;
                _credit.Dirty = value;
                _creditApprovalDate.Dirty = value;
                _deniedBy.Dirty = value;
                _deniedDate.Dirty = value;
                _differentApprovalExpiredDate.Dirty = value;
                _differentApprovedBy.Dirty = value;
                _differentApprovedDate.Dirty = value;
                _exceptions.Dirty = value;
                _exceptionSignOffBy.Dirty = value;
                _exceptionSignOffDate.Dirty = value;
                _id.Dirty = value;
                _isAgencyManually.Dirty = value;
                _isAgencyWaiver.Dirty = value;
                _isAgencyWithAgreement.Dirty = value;
                _maxRate.Dirty = value;
                _miOrderedDate.Dirty = value;
                _miReceivedDate.Dirty = value;
                _modifiedLoanAmount.Dirty = value;
                _modifiedLoanRate.Dirty = value;
                _modifiedLoanTerm.Dirty = value;
                _modifiedLtv.Dirty = value;
                _modifiedMonthlyPayment.Dirty = value;
                _originalAppraiser.Dirty = value;
                _originalAppraisersValue.Dirty = value;
                _resubmittedDate.Dirty = value;
                _reviewAppraiser.Dirty = value;
                _reviewCompletedDate.Dirty = value;
                _reviewRequestedDate.Dirty = value;
                _reviewType.Dirty = value;
                _reviewValue.Dirty = value;
                _sentToDate.Dirty = value;
                _signOffBy.Dirty = value;
                _signOffDate.Dirty = value;
                _strengths.Dirty = value;
                _submittedDate.Dirty = value;
                _supervisoryAppraiserLicenseNumber.Dirty = value;
                _suspendedBy.Dirty = value;
                _suspendedDate.Dirty = value;
                _suspendedReasons.Dirty = value;
            }
        }
    }
}