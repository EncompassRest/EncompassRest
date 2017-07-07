using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwriterSummary : IClean
    {
        private Value<string> _appraisal;
        public string Appraisal { get { return _appraisal; } set { _appraisal = value; } }
        private Value<DateTime?> _appraisalCompletedDate;
        public DateTime? AppraisalCompletedDate { get { return _appraisalCompletedDate; } set { _appraisalCompletedDate = value; } }
        private Value<DateTime?> _appraisalExpiredDate;
        public DateTime? AppraisalExpiredDate { get { return _appraisalExpiredDate; } set { _appraisalExpiredDate = value; } }
        private Value<DateTime?> _appraisalOrderedDate;
        public DateTime? AppraisalOrderedDate { get { return _appraisalOrderedDate; } set { _appraisalOrderedDate = value; } }
        private Value<string> _appraisalType;
        public string AppraisalType { get { return _appraisalType; } set { _appraisalType = value; } }
        private Value<DateTime?> _approvalExpiredDate;
        public DateTime? ApprovalExpiredDate { get { return _approvalExpiredDate; } set { _approvalExpiredDate = value; } }
        private Value<string> _approvedBy;
        public string ApprovedBy { get { return _approvedBy; } set { _approvedBy = value; } }
        private Value<DateTime?> _approvedDate;
        public DateTime? ApprovedDate { get { return _approvedDate; } set { _approvedDate = value; } }
        private Value<string> _ausNumber;
        public string AusNumber { get { return _ausNumber; } set { _ausNumber = value; } }
        private Value<DateTime?> _ausRunDate;
        public DateTime? AusRunDate { get { return _ausRunDate; } set { _ausRunDate = value; } }
        private Value<string> _ausSource;
        public string AusSource { get { return _ausSource; } set { _ausSource = value; } }
        private Value<bool?> _benefitRequiredIndicator;
        public bool? BenefitRequiredIndicator { get { return _benefitRequiredIndicator; } set { _benefitRequiredIndicator = value; } }
        private Value<DateTime?> _clearToCloseDate;
        public DateTime? ClearToCloseDate { get { return _clearToCloseDate; } set { _clearToCloseDate = value; } }
        private Value<string> _concerns;
        public string Concerns { get { return _concerns; } set { _concerns = value; } }
        private Value<string> _conditions;
        public string Conditions { get { return _conditions; } set { _conditions = value; } }
        private Value<string> _credit;
        public string Credit { get { return _credit; } set { _credit = value; } }
        private Value<DateTime?> _creditApprovalDate;
        public DateTime? CreditApprovalDate { get { return _creditApprovalDate; } set { _creditApprovalDate = value; } }
        private Value<string> _deniedBy;
        public string DeniedBy { get { return _deniedBy; } set { _deniedBy = value; } }
        private Value<DateTime?> _deniedDate;
        public DateTime? DeniedDate { get { return _deniedDate; } set { _deniedDate = value; } }
        private Value<DateTime?> _differentApprovalExpiredDate;
        public DateTime? DifferentApprovalExpiredDate { get { return _differentApprovalExpiredDate; } set { _differentApprovalExpiredDate = value; } }
        private Value<string> _differentApprovedBy;
        public string DifferentApprovedBy { get { return _differentApprovedBy; } set { _differentApprovedBy = value; } }
        private Value<DateTime?> _differentApprovedDate;
        public DateTime? DifferentApprovedDate { get { return _differentApprovedDate; } set { _differentApprovedDate = value; } }
        private Value<string> _exceptions;
        public string Exceptions { get { return _exceptions; } set { _exceptions = value; } }
        private Value<string> _exceptionSignOffBy;
        public string ExceptionSignOffBy { get { return _exceptionSignOffBy; } set { _exceptionSignOffBy = value; } }
        private Value<DateTime?> _exceptionSignOffDate;
        public DateTime? ExceptionSignOffDate { get { return _exceptionSignOffDate; } set { _exceptionSignOffDate = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isAgencyManually;
        public bool? IsAgencyManually { get { return _isAgencyManually; } set { _isAgencyManually = value; } }
        private Value<bool?> _isAgencyWaiver;
        public bool? IsAgencyWaiver { get { return _isAgencyWaiver; } set { _isAgencyWaiver = value; } }
        private Value<bool?> _isAgencyWithAgreement;
        public bool? IsAgencyWithAgreement { get { return _isAgencyWithAgreement; } set { _isAgencyWithAgreement = value; } }
        private Value<decimal?> _maxRate;
        public decimal? MaxRate { get { return _maxRate; } set { _maxRate = value; } }
        private Value<DateTime?> _miOrderedDate;
        public DateTime? MiOrderedDate { get { return _miOrderedDate; } set { _miOrderedDate = value; } }
        private Value<DateTime?> _miReceivedDate;
        public DateTime? MiReceivedDate { get { return _miReceivedDate; } set { _miReceivedDate = value; } }
        private Value<decimal?> _modifiedLoanAmount;
        public decimal? ModifiedLoanAmount { get { return _modifiedLoanAmount; } set { _modifiedLoanAmount = value; } }
        private Value<decimal?> _modifiedLoanRate;
        public decimal? ModifiedLoanRate { get { return _modifiedLoanRate; } set { _modifiedLoanRate = value; } }
        private Value<int?> _modifiedLoanTerm;
        public int? ModifiedLoanTerm { get { return _modifiedLoanTerm; } set { _modifiedLoanTerm = value; } }
        private Value<decimal?> _modifiedLtv;
        public decimal? ModifiedLtv { get { return _modifiedLtv; } set { _modifiedLtv = value; } }
        private Value<decimal?> _modifiedMonthlyPayment;
        public decimal? ModifiedMonthlyPayment { get { return _modifiedMonthlyPayment; } set { _modifiedMonthlyPayment = value; } }
        private Value<string> _originalAppraiser;
        public string OriginalAppraiser { get { return _originalAppraiser; } set { _originalAppraiser = value; } }
        private Value<decimal?> _originalAppraisersValue;
        public decimal? OriginalAppraisersValue { get { return _originalAppraisersValue; } set { _originalAppraisersValue = value; } }
        private Value<DateTime?> _resubmittedDate;
        public DateTime? ResubmittedDate { get { return _resubmittedDate; } set { _resubmittedDate = value; } }
        private Value<string> _reviewAppraiser;
        public string ReviewAppraiser { get { return _reviewAppraiser; } set { _reviewAppraiser = value; } }
        private Value<DateTime?> _reviewCompletedDate;
        public DateTime? ReviewCompletedDate { get { return _reviewCompletedDate; } set { _reviewCompletedDate = value; } }
        private Value<DateTime?> _reviewRequestedDate;
        public DateTime? ReviewRequestedDate { get { return _reviewRequestedDate; } set { _reviewRequestedDate = value; } }
        private Value<string> _reviewType;
        public string ReviewType { get { return _reviewType; } set { _reviewType = value; } }
        private Value<decimal?> _reviewValue;
        public decimal? ReviewValue { get { return _reviewValue; } set { _reviewValue = value; } }
        private Value<DateTime?> _sentToDate;
        public DateTime? SentToDate { get { return _sentToDate; } set { _sentToDate = value; } }
        private Value<string> _signOffBy;
        public string SignOffBy { get { return _signOffBy; } set { _signOffBy = value; } }
        private Value<DateTime?> _signOffDate;
        public DateTime? SignOffDate { get { return _signOffDate; } set { _signOffDate = value; } }
        private Value<string> _strengths;
        public string Strengths { get { return _strengths; } set { _strengths = value; } }
        private Value<DateTime?> _submittedDate;
        public DateTime? SubmittedDate { get { return _submittedDate; } set { _submittedDate = value; } }
        private Value<string> _supervisoryAppraiserLicenseNumber;
        public string SupervisoryAppraiserLicenseNumber { get { return _supervisoryAppraiserLicenseNumber; } set { _supervisoryAppraiserLicenseNumber = value; } }
        private Value<string> _suspendedBy;
        public string SuspendedBy { get { return _suspendedBy; } set { _suspendedBy = value; } }
        private Value<DateTime?> _suspendedDate;
        public DateTime? SuspendedDate { get { return _suspendedDate; } set { _suspendedDate = value; } }
        private Value<string> _suspendedReasons;
        public string SuspendedReasons { get { return _suspendedReasons; } set { _suspendedReasons = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _appraisal.Clean
                    && _appraisalCompletedDate.Clean
                    && _appraisalExpiredDate.Clean
                    && _appraisalOrderedDate.Clean
                    && _appraisalType.Clean
                    && _approvalExpiredDate.Clean
                    && _approvedBy.Clean
                    && _approvedDate.Clean
                    && _ausNumber.Clean
                    && _ausRunDate.Clean
                    && _ausSource.Clean
                    && _benefitRequiredIndicator.Clean
                    && _clearToCloseDate.Clean
                    && _concerns.Clean
                    && _conditions.Clean
                    && _credit.Clean
                    && _creditApprovalDate.Clean
                    && _deniedBy.Clean
                    && _deniedDate.Clean
                    && _differentApprovalExpiredDate.Clean
                    && _differentApprovedBy.Clean
                    && _differentApprovedDate.Clean
                    && _exceptions.Clean
                    && _exceptionSignOffBy.Clean
                    && _exceptionSignOffDate.Clean
                    && _id.Clean
                    && _isAgencyManually.Clean
                    && _isAgencyWaiver.Clean
                    && _isAgencyWithAgreement.Clean
                    && _maxRate.Clean
                    && _miOrderedDate.Clean
                    && _miReceivedDate.Clean
                    && _modifiedLoanAmount.Clean
                    && _modifiedLoanRate.Clean
                    && _modifiedLoanTerm.Clean
                    && _modifiedLtv.Clean
                    && _modifiedMonthlyPayment.Clean
                    && _originalAppraiser.Clean
                    && _originalAppraisersValue.Clean
                    && _resubmittedDate.Clean
                    && _reviewAppraiser.Clean
                    && _reviewCompletedDate.Clean
                    && _reviewRequestedDate.Clean
                    && _reviewType.Clean
                    && _reviewValue.Clean
                    && _sentToDate.Clean
                    && _signOffBy.Clean
                    && _signOffDate.Clean
                    && _strengths.Clean
                    && _submittedDate.Clean
                    && _supervisoryAppraiserLicenseNumber.Clean
                    && _suspendedBy.Clean
                    && _suspendedDate.Clean
                    && _suspendedReasons.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var appraisal = _appraisal; appraisal.Clean = value; _appraisal = appraisal;
                var appraisalCompletedDate = _appraisalCompletedDate; appraisalCompletedDate.Clean = value; _appraisalCompletedDate = appraisalCompletedDate;
                var appraisalExpiredDate = _appraisalExpiredDate; appraisalExpiredDate.Clean = value; _appraisalExpiredDate = appraisalExpiredDate;
                var appraisalOrderedDate = _appraisalOrderedDate; appraisalOrderedDate.Clean = value; _appraisalOrderedDate = appraisalOrderedDate;
                var appraisalType = _appraisalType; appraisalType.Clean = value; _appraisalType = appraisalType;
                var approvalExpiredDate = _approvalExpiredDate; approvalExpiredDate.Clean = value; _approvalExpiredDate = approvalExpiredDate;
                var approvedBy = _approvedBy; approvedBy.Clean = value; _approvedBy = approvedBy;
                var approvedDate = _approvedDate; approvedDate.Clean = value; _approvedDate = approvedDate;
                var ausNumber = _ausNumber; ausNumber.Clean = value; _ausNumber = ausNumber;
                var ausRunDate = _ausRunDate; ausRunDate.Clean = value; _ausRunDate = ausRunDate;
                var ausSource = _ausSource; ausSource.Clean = value; _ausSource = ausSource;
                var benefitRequiredIndicator = _benefitRequiredIndicator; benefitRequiredIndicator.Clean = value; _benefitRequiredIndicator = benefitRequiredIndicator;
                var clearToCloseDate = _clearToCloseDate; clearToCloseDate.Clean = value; _clearToCloseDate = clearToCloseDate;
                var concerns = _concerns; concerns.Clean = value; _concerns = concerns;
                var conditions = _conditions; conditions.Clean = value; _conditions = conditions;
                var credit = _credit; credit.Clean = value; _credit = credit;
                var creditApprovalDate = _creditApprovalDate; creditApprovalDate.Clean = value; _creditApprovalDate = creditApprovalDate;
                var deniedBy = _deniedBy; deniedBy.Clean = value; _deniedBy = deniedBy;
                var deniedDate = _deniedDate; deniedDate.Clean = value; _deniedDate = deniedDate;
                var differentApprovalExpiredDate = _differentApprovalExpiredDate; differentApprovalExpiredDate.Clean = value; _differentApprovalExpiredDate = differentApprovalExpiredDate;
                var differentApprovedBy = _differentApprovedBy; differentApprovedBy.Clean = value; _differentApprovedBy = differentApprovedBy;
                var differentApprovedDate = _differentApprovedDate; differentApprovedDate.Clean = value; _differentApprovedDate = differentApprovedDate;
                var exceptions = _exceptions; exceptions.Clean = value; _exceptions = exceptions;
                var exceptionSignOffBy = _exceptionSignOffBy; exceptionSignOffBy.Clean = value; _exceptionSignOffBy = exceptionSignOffBy;
                var exceptionSignOffDate = _exceptionSignOffDate; exceptionSignOffDate.Clean = value; _exceptionSignOffDate = exceptionSignOffDate;
                var id = _id; id.Clean = value; _id = id;
                var isAgencyManually = _isAgencyManually; isAgencyManually.Clean = value; _isAgencyManually = isAgencyManually;
                var isAgencyWaiver = _isAgencyWaiver; isAgencyWaiver.Clean = value; _isAgencyWaiver = isAgencyWaiver;
                var isAgencyWithAgreement = _isAgencyWithAgreement; isAgencyWithAgreement.Clean = value; _isAgencyWithAgreement = isAgencyWithAgreement;
                var maxRate = _maxRate; maxRate.Clean = value; _maxRate = maxRate;
                var miOrderedDate = _miOrderedDate; miOrderedDate.Clean = value; _miOrderedDate = miOrderedDate;
                var miReceivedDate = _miReceivedDate; miReceivedDate.Clean = value; _miReceivedDate = miReceivedDate;
                var modifiedLoanAmount = _modifiedLoanAmount; modifiedLoanAmount.Clean = value; _modifiedLoanAmount = modifiedLoanAmount;
                var modifiedLoanRate = _modifiedLoanRate; modifiedLoanRate.Clean = value; _modifiedLoanRate = modifiedLoanRate;
                var modifiedLoanTerm = _modifiedLoanTerm; modifiedLoanTerm.Clean = value; _modifiedLoanTerm = modifiedLoanTerm;
                var modifiedLtv = _modifiedLtv; modifiedLtv.Clean = value; _modifiedLtv = modifiedLtv;
                var modifiedMonthlyPayment = _modifiedMonthlyPayment; modifiedMonthlyPayment.Clean = value; _modifiedMonthlyPayment = modifiedMonthlyPayment;
                var originalAppraiser = _originalAppraiser; originalAppraiser.Clean = value; _originalAppraiser = originalAppraiser;
                var originalAppraisersValue = _originalAppraisersValue; originalAppraisersValue.Clean = value; _originalAppraisersValue = originalAppraisersValue;
                var resubmittedDate = _resubmittedDate; resubmittedDate.Clean = value; _resubmittedDate = resubmittedDate;
                var reviewAppraiser = _reviewAppraiser; reviewAppraiser.Clean = value; _reviewAppraiser = reviewAppraiser;
                var reviewCompletedDate = _reviewCompletedDate; reviewCompletedDate.Clean = value; _reviewCompletedDate = reviewCompletedDate;
                var reviewRequestedDate = _reviewRequestedDate; reviewRequestedDate.Clean = value; _reviewRequestedDate = reviewRequestedDate;
                var reviewType = _reviewType; reviewType.Clean = value; _reviewType = reviewType;
                var reviewValue = _reviewValue; reviewValue.Clean = value; _reviewValue = reviewValue;
                var sentToDate = _sentToDate; sentToDate.Clean = value; _sentToDate = sentToDate;
                var signOffBy = _signOffBy; signOffBy.Clean = value; _signOffBy = signOffBy;
                var signOffDate = _signOffDate; signOffDate.Clean = value; _signOffDate = signOffDate;
                var strengths = _strengths; strengths.Clean = value; _strengths = strengths;
                var submittedDate = _submittedDate; submittedDate.Clean = value; _submittedDate = submittedDate;
                var supervisoryAppraiserLicenseNumber = _supervisoryAppraiserLicenseNumber; supervisoryAppraiserLicenseNumber.Clean = value; _supervisoryAppraiserLicenseNumber = supervisoryAppraiserLicenseNumber;
                var suspendedBy = _suspendedBy; suspendedBy.Clean = value; _suspendedBy = suspendedBy;
                var suspendedDate = _suspendedDate; suspendedDate.Clean = value; _suspendedDate = suspendedDate;
                var suspendedReasons = _suspendedReasons; suspendedReasons.Clean = value; _suspendedReasons = suspendedReasons;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public UnderwriterSummary()
        {
            Clean = true;
        }
    }
}