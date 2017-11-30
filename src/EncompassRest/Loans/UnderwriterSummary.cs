using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwriterSummary : ExtensibleObject
    {
        private DirtyValue<string> _appraisal;
        public string Appraisal { get => _appraisal; set => _appraisal = value; }
        private DirtyValue<DateTime?> _appraisalCompletedDate;
        public DateTime? AppraisalCompletedDate { get => _appraisalCompletedDate; set => _appraisalCompletedDate = value; }
        private DirtyValue<DateTime?> _appraisalExpiredDate;
        public DateTime? AppraisalExpiredDate { get => _appraisalExpiredDate; set => _appraisalExpiredDate = value; }
        private DirtyValue<DateTime?> _appraisalOrderedDate;
        public DateTime? AppraisalOrderedDate { get => _appraisalOrderedDate; set => _appraisalOrderedDate = value; }
        private DirtyValue<StringEnumValue<UnderwriterSummaryAppraisalType>> _appraisalType;
        public StringEnumValue<UnderwriterSummaryAppraisalType> AppraisalType { get => _appraisalType; set => _appraisalType = value; }
        private DirtyValue<DateTime?> _approvalExpiredDate;
        public DateTime? ApprovalExpiredDate { get => _approvalExpiredDate; set => _approvalExpiredDate = value; }
        private DirtyValue<string> _approvedBy;
        public string ApprovedBy { get => _approvedBy; set => _approvedBy = value; }
        private DirtyValue<DateTime?> _approvedDate;
        public DateTime? ApprovedDate { get => _approvedDate; set => _approvedDate = value; }
        private DirtyValue<string> _ausNumber;
        public string AusNumber { get => _ausNumber; set => _ausNumber = value; }
        private DirtyValue<DateTime?> _ausRunDate;
        public DateTime? AusRunDate { get => _ausRunDate; set => _ausRunDate = value; }
        private DirtyValue<string> _ausSource;
        public string AusSource { get => _ausSource; set => _ausSource = value; }
        private DirtyValue<bool?> _benefitRequiredIndicator;
        public bool? BenefitRequiredIndicator { get => _benefitRequiredIndicator; set => _benefitRequiredIndicator = value; }
        private DirtyValue<DateTime?> _clearToCloseDate;
        public DateTime? ClearToCloseDate { get => _clearToCloseDate; set => _clearToCloseDate = value; }
        private DirtyValue<string> _concerns;
        public string Concerns { get => _concerns; set => _concerns = value; }
        private DirtyValue<string> _conditions;
        public string Conditions { get => _conditions; set => _conditions = value; }
        private DirtyValue<string> _credit;
        public string Credit { get => _credit; set => _credit = value; }
        private DirtyValue<DateTime?> _creditApprovalDate;
        public DateTime? CreditApprovalDate { get => _creditApprovalDate; set => _creditApprovalDate = value; }
        private DirtyValue<string> _deniedBy;
        public string DeniedBy { get => _deniedBy; set => _deniedBy = value; }
        private DirtyValue<DateTime?> _deniedDate;
        public DateTime? DeniedDate { get => _deniedDate; set => _deniedDate = value; }
        private DirtyValue<DateTime?> _differentApprovalExpiredDate;
        public DateTime? DifferentApprovalExpiredDate { get => _differentApprovalExpiredDate; set => _differentApprovalExpiredDate = value; }
        private DirtyValue<string> _differentApprovedBy;
        public string DifferentApprovedBy { get => _differentApprovedBy; set => _differentApprovedBy = value; }
        private DirtyValue<DateTime?> _differentApprovedDate;
        public DateTime? DifferentApprovedDate { get => _differentApprovedDate; set => _differentApprovedDate = value; }
        private DirtyValue<string> _exceptions;
        public string Exceptions { get => _exceptions; set => _exceptions = value; }
        private DirtyValue<string> _exceptionSignOffBy;
        public string ExceptionSignOffBy { get => _exceptionSignOffBy; set => _exceptionSignOffBy = value; }
        private DirtyValue<DateTime?> _exceptionSignOffDate;
        public DateTime? ExceptionSignOffDate { get => _exceptionSignOffDate; set => _exceptionSignOffDate = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isAgencyManually;
        public bool? IsAgencyManually { get => _isAgencyManually; set => _isAgencyManually = value; }
        private DirtyValue<bool?> _isAgencyWaiver;
        public bool? IsAgencyWaiver { get => _isAgencyWaiver; set => _isAgencyWaiver = value; }
        private DirtyValue<bool?> _isAgencyWithAgreement;
        public bool? IsAgencyWithAgreement { get => _isAgencyWithAgreement; set => _isAgencyWithAgreement = value; }
        private DirtyValue<decimal?> _maxRate;
        public decimal? MaxRate { get => _maxRate; set => _maxRate = value; }
        private DirtyValue<DateTime?> _miOrderedDate;
        public DateTime? MiOrderedDate { get => _miOrderedDate; set => _miOrderedDate = value; }
        private DirtyValue<DateTime?> _miReceivedDate;
        public DateTime? MiReceivedDate { get => _miReceivedDate; set => _miReceivedDate = value; }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        public decimal? ModifiedLoanAmount { get => _modifiedLoanAmount; set => _modifiedLoanAmount = value; }
        private DirtyValue<decimal?> _modifiedLoanRate;
        public decimal? ModifiedLoanRate { get => _modifiedLoanRate; set => _modifiedLoanRate = value; }
        private DirtyValue<int?> _modifiedLoanTerm;
        public int? ModifiedLoanTerm { get => _modifiedLoanTerm; set => _modifiedLoanTerm = value; }
        private DirtyValue<decimal?> _modifiedLtv;
        public decimal? ModifiedLtv { get => _modifiedLtv; set => _modifiedLtv = value; }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        public decimal? ModifiedMonthlyPayment { get => _modifiedMonthlyPayment; set => _modifiedMonthlyPayment = value; }
        private DirtyValue<string> _originalAppraiser;
        public string OriginalAppraiser { get => _originalAppraiser; set => _originalAppraiser = value; }
        private DirtyValue<decimal?> _originalAppraisersValue;
        public decimal? OriginalAppraisersValue { get => _originalAppraisersValue; set => _originalAppraisersValue = value; }
        private DirtyValue<DateTime?> _resubmittedDate;
        public DateTime? ResubmittedDate { get => _resubmittedDate; set => _resubmittedDate = value; }
        private DirtyValue<string> _reviewAppraiser;
        public string ReviewAppraiser { get => _reviewAppraiser; set => _reviewAppraiser = value; }
        private DirtyValue<DateTime?> _reviewCompletedDate;
        public DateTime? ReviewCompletedDate { get => _reviewCompletedDate; set => _reviewCompletedDate = value; }
        private DirtyValue<DateTime?> _reviewRequestedDate;
        public DateTime? ReviewRequestedDate { get => _reviewRequestedDate; set => _reviewRequestedDate = value; }
        private DirtyValue<StringEnumValue<ReviewType>> _reviewType;
        public StringEnumValue<ReviewType> ReviewType { get => _reviewType; set => _reviewType = value; }
        private DirtyValue<decimal?> _reviewValue;
        public decimal? ReviewValue { get => _reviewValue; set => _reviewValue = value; }
        private DirtyValue<DateTime?> _sentToDate;
        public DateTime? SentToDate { get => _sentToDate; set => _sentToDate = value; }
        private DirtyValue<string> _signOffBy;
        public string SignOffBy { get => _signOffBy; set => _signOffBy = value; }
        private DirtyValue<DateTime?> _signOffDate;
        public DateTime? SignOffDate { get => _signOffDate; set => _signOffDate = value; }
        private DirtyValue<string> _strengths;
        public string Strengths { get => _strengths; set => _strengths = value; }
        private DirtyValue<DateTime?> _submittedDate;
        public DateTime? SubmittedDate { get => _submittedDate; set => _submittedDate = value; }
        private DirtyValue<string> _supervisoryAppraiserLicenseNumber;
        public string SupervisoryAppraiserLicenseNumber { get => _supervisoryAppraiserLicenseNumber; set => _supervisoryAppraiserLicenseNumber = value; }
        private DirtyValue<string> _suspendedBy;
        public string SuspendedBy { get => _suspendedBy; set => _suspendedBy = value; }
        private DirtyValue<DateTime?> _suspendedDate;
        public DateTime? SuspendedDate { get => _suspendedDate; set => _suspendedDate = value; }
        private DirtyValue<string> _suspendedReasons;
        public string SuspendedReasons { get => _suspendedReasons; set => _suspendedReasons = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _appraisal.Dirty
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
            }
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