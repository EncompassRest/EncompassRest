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
                var v0 = _appraisal; v0.Clean = value; _appraisal = v0;
                var v1 = _appraisalCompletedDate; v1.Clean = value; _appraisalCompletedDate = v1;
                var v2 = _appraisalExpiredDate; v2.Clean = value; _appraisalExpiredDate = v2;
                var v3 = _appraisalOrderedDate; v3.Clean = value; _appraisalOrderedDate = v3;
                var v4 = _appraisalType; v4.Clean = value; _appraisalType = v4;
                var v5 = _approvalExpiredDate; v5.Clean = value; _approvalExpiredDate = v5;
                var v6 = _approvedBy; v6.Clean = value; _approvedBy = v6;
                var v7 = _approvedDate; v7.Clean = value; _approvedDate = v7;
                var v8 = _ausNumber; v8.Clean = value; _ausNumber = v8;
                var v9 = _ausRunDate; v9.Clean = value; _ausRunDate = v9;
                var v10 = _ausSource; v10.Clean = value; _ausSource = v10;
                var v11 = _benefitRequiredIndicator; v11.Clean = value; _benefitRequiredIndicator = v11;
                var v12 = _clearToCloseDate; v12.Clean = value; _clearToCloseDate = v12;
                var v13 = _concerns; v13.Clean = value; _concerns = v13;
                var v14 = _conditions; v14.Clean = value; _conditions = v14;
                var v15 = _credit; v15.Clean = value; _credit = v15;
                var v16 = _creditApprovalDate; v16.Clean = value; _creditApprovalDate = v16;
                var v17 = _deniedBy; v17.Clean = value; _deniedBy = v17;
                var v18 = _deniedDate; v18.Clean = value; _deniedDate = v18;
                var v19 = _differentApprovalExpiredDate; v19.Clean = value; _differentApprovalExpiredDate = v19;
                var v20 = _differentApprovedBy; v20.Clean = value; _differentApprovedBy = v20;
                var v21 = _differentApprovedDate; v21.Clean = value; _differentApprovedDate = v21;
                var v22 = _exceptions; v22.Clean = value; _exceptions = v22;
                var v23 = _exceptionSignOffBy; v23.Clean = value; _exceptionSignOffBy = v23;
                var v24 = _exceptionSignOffDate; v24.Clean = value; _exceptionSignOffDate = v24;
                var v25 = _id; v25.Clean = value; _id = v25;
                var v26 = _isAgencyManually; v26.Clean = value; _isAgencyManually = v26;
                var v27 = _isAgencyWaiver; v27.Clean = value; _isAgencyWaiver = v27;
                var v28 = _isAgencyWithAgreement; v28.Clean = value; _isAgencyWithAgreement = v28;
                var v29 = _maxRate; v29.Clean = value; _maxRate = v29;
                var v30 = _miOrderedDate; v30.Clean = value; _miOrderedDate = v30;
                var v31 = _miReceivedDate; v31.Clean = value; _miReceivedDate = v31;
                var v32 = _modifiedLoanAmount; v32.Clean = value; _modifiedLoanAmount = v32;
                var v33 = _modifiedLoanRate; v33.Clean = value; _modifiedLoanRate = v33;
                var v34 = _modifiedLoanTerm; v34.Clean = value; _modifiedLoanTerm = v34;
                var v35 = _modifiedLtv; v35.Clean = value; _modifiedLtv = v35;
                var v36 = _modifiedMonthlyPayment; v36.Clean = value; _modifiedMonthlyPayment = v36;
                var v37 = _originalAppraiser; v37.Clean = value; _originalAppraiser = v37;
                var v38 = _originalAppraisersValue; v38.Clean = value; _originalAppraisersValue = v38;
                var v39 = _resubmittedDate; v39.Clean = value; _resubmittedDate = v39;
                var v40 = _reviewAppraiser; v40.Clean = value; _reviewAppraiser = v40;
                var v41 = _reviewCompletedDate; v41.Clean = value; _reviewCompletedDate = v41;
                var v42 = _reviewRequestedDate; v42.Clean = value; _reviewRequestedDate = v42;
                var v43 = _reviewType; v43.Clean = value; _reviewType = v43;
                var v44 = _reviewValue; v44.Clean = value; _reviewValue = v44;
                var v45 = _sentToDate; v45.Clean = value; _sentToDate = v45;
                var v46 = _signOffBy; v46.Clean = value; _signOffBy = v46;
                var v47 = _signOffDate; v47.Clean = value; _signOffDate = v47;
                var v48 = _strengths; v48.Clean = value; _strengths = v48;
                var v49 = _submittedDate; v49.Clean = value; _submittedDate = v49;
                var v50 = _supervisoryAppraiserLicenseNumber; v50.Clean = value; _supervisoryAppraiserLicenseNumber = v50;
                var v51 = _suspendedBy; v51.Clean = value; _suspendedBy = v51;
                var v52 = _suspendedDate; v52.Clean = value; _suspendedDate = v52;
                var v53 = _suspendedReasons; v53.Clean = value; _suspendedReasons = v53;
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