using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class UnderwriterSummary : IDirty
    {
        private DirtyValue<string> _appraisal;
        public string Appraisal { get { return _appraisal; } set { _appraisal = value; } }
        private DirtyValue<DateTime?> _appraisalCompletedDate;
        public DateTime? AppraisalCompletedDate { get { return _appraisalCompletedDate; } set { _appraisalCompletedDate = value; } }
        private DirtyValue<DateTime?> _appraisalExpiredDate;
        public DateTime? AppraisalExpiredDate { get { return _appraisalExpiredDate; } set { _appraisalExpiredDate = value; } }
        private DirtyValue<DateTime?> _appraisalOrderedDate;
        public DateTime? AppraisalOrderedDate { get { return _appraisalOrderedDate; } set { _appraisalOrderedDate = value; } }
        private DirtyValue<string> _appraisalType;
        public string AppraisalType { get { return _appraisalType; } set { _appraisalType = value; } }
        private DirtyValue<DateTime?> _approvalExpiredDate;
        public DateTime? ApprovalExpiredDate { get { return _approvalExpiredDate; } set { _approvalExpiredDate = value; } }
        private DirtyValue<string> _approvedBy;
        public string ApprovedBy { get { return _approvedBy; } set { _approvedBy = value; } }
        private DirtyValue<DateTime?> _approvedDate;
        public DateTime? ApprovedDate { get { return _approvedDate; } set { _approvedDate = value; } }
        private DirtyValue<string> _ausNumber;
        public string AusNumber { get { return _ausNumber; } set { _ausNumber = value; } }
        private DirtyValue<DateTime?> _ausRunDate;
        public DateTime? AusRunDate { get { return _ausRunDate; } set { _ausRunDate = value; } }
        private DirtyValue<string> _ausSource;
        public string AusSource { get { return _ausSource; } set { _ausSource = value; } }
        private DirtyValue<bool?> _benefitRequiredIndicator;
        public bool? BenefitRequiredIndicator { get { return _benefitRequiredIndicator; } set { _benefitRequiredIndicator = value; } }
        private DirtyValue<DateTime?> _clearToCloseDate;
        public DateTime? ClearToCloseDate { get { return _clearToCloseDate; } set { _clearToCloseDate = value; } }
        private DirtyValue<string> _concerns;
        public string Concerns { get { return _concerns; } set { _concerns = value; } }
        private DirtyValue<string> _conditions;
        public string Conditions { get { return _conditions; } set { _conditions = value; } }
        private DirtyValue<string> _credit;
        public string Credit { get { return _credit; } set { _credit = value; } }
        private DirtyValue<DateTime?> _creditApprovalDate;
        public DateTime? CreditApprovalDate { get { return _creditApprovalDate; } set { _creditApprovalDate = value; } }
        private DirtyValue<string> _deniedBy;
        public string DeniedBy { get { return _deniedBy; } set { _deniedBy = value; } }
        private DirtyValue<DateTime?> _deniedDate;
        public DateTime? DeniedDate { get { return _deniedDate; } set { _deniedDate = value; } }
        private DirtyValue<DateTime?> _differentApprovalExpiredDate;
        public DateTime? DifferentApprovalExpiredDate { get { return _differentApprovalExpiredDate; } set { _differentApprovalExpiredDate = value; } }
        private DirtyValue<string> _differentApprovedBy;
        public string DifferentApprovedBy { get { return _differentApprovedBy; } set { _differentApprovedBy = value; } }
        private DirtyValue<DateTime?> _differentApprovedDate;
        public DateTime? DifferentApprovedDate { get { return _differentApprovedDate; } set { _differentApprovedDate = value; } }
        private DirtyValue<string> _exceptions;
        public string Exceptions { get { return _exceptions; } set { _exceptions = value; } }
        private DirtyValue<string> _exceptionSignOffBy;
        public string ExceptionSignOffBy { get { return _exceptionSignOffBy; } set { _exceptionSignOffBy = value; } }
        private DirtyValue<DateTime?> _exceptionSignOffDate;
        public DateTime? ExceptionSignOffDate { get { return _exceptionSignOffDate; } set { _exceptionSignOffDate = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isAgencyManually;
        public bool? IsAgencyManually { get { return _isAgencyManually; } set { _isAgencyManually = value; } }
        private DirtyValue<bool?> _isAgencyWaiver;
        public bool? IsAgencyWaiver { get { return _isAgencyWaiver; } set { _isAgencyWaiver = value; } }
        private DirtyValue<bool?> _isAgencyWithAgreement;
        public bool? IsAgencyWithAgreement { get { return _isAgencyWithAgreement; } set { _isAgencyWithAgreement = value; } }
        private DirtyValue<decimal?> _maxRate;
        public decimal? MaxRate { get { return _maxRate; } set { _maxRate = value; } }
        private DirtyValue<DateTime?> _miOrderedDate;
        public DateTime? MiOrderedDate { get { return _miOrderedDate; } set { _miOrderedDate = value; } }
        private DirtyValue<DateTime?> _miReceivedDate;
        public DateTime? MiReceivedDate { get { return _miReceivedDate; } set { _miReceivedDate = value; } }
        private DirtyValue<decimal?> _modifiedLoanAmount;
        public decimal? ModifiedLoanAmount { get { return _modifiedLoanAmount; } set { _modifiedLoanAmount = value; } }
        private DirtyValue<decimal?> _modifiedLoanRate;
        public decimal? ModifiedLoanRate { get { return _modifiedLoanRate; } set { _modifiedLoanRate = value; } }
        private DirtyValue<int?> _modifiedLoanTerm;
        public int? ModifiedLoanTerm { get { return _modifiedLoanTerm; } set { _modifiedLoanTerm = value; } }
        private DirtyValue<decimal?> _modifiedLtv;
        public decimal? ModifiedLtv { get { return _modifiedLtv; } set { _modifiedLtv = value; } }
        private DirtyValue<decimal?> _modifiedMonthlyPayment;
        public decimal? ModifiedMonthlyPayment { get { return _modifiedMonthlyPayment; } set { _modifiedMonthlyPayment = value; } }
        private DirtyValue<string> _originalAppraiser;
        public string OriginalAppraiser { get { return _originalAppraiser; } set { _originalAppraiser = value; } }
        private DirtyValue<decimal?> _originalAppraisersValue;
        public decimal? OriginalAppraisersValue { get { return _originalAppraisersValue; } set { _originalAppraisersValue = value; } }
        private DirtyValue<DateTime?> _resubmittedDate;
        public DateTime? ResubmittedDate { get { return _resubmittedDate; } set { _resubmittedDate = value; } }
        private DirtyValue<string> _reviewAppraiser;
        public string ReviewAppraiser { get { return _reviewAppraiser; } set { _reviewAppraiser = value; } }
        private DirtyValue<DateTime?> _reviewCompletedDate;
        public DateTime? ReviewCompletedDate { get { return _reviewCompletedDate; } set { _reviewCompletedDate = value; } }
        private DirtyValue<DateTime?> _reviewRequestedDate;
        public DateTime? ReviewRequestedDate { get { return _reviewRequestedDate; } set { _reviewRequestedDate = value; } }
        private DirtyValue<string> _reviewType;
        public string ReviewType { get { return _reviewType; } set { _reviewType = value; } }
        private DirtyValue<decimal?> _reviewValue;
        public decimal? ReviewValue { get { return _reviewValue; } set { _reviewValue = value; } }
        private DirtyValue<DateTime?> _sentToDate;
        public DateTime? SentToDate { get { return _sentToDate; } set { _sentToDate = value; } }
        private DirtyValue<string> _signOffBy;
        public string SignOffBy { get { return _signOffBy; } set { _signOffBy = value; } }
        private DirtyValue<DateTime?> _signOffDate;
        public DateTime? SignOffDate { get { return _signOffDate; } set { _signOffDate = value; } }
        private DirtyValue<string> _strengths;
        public string Strengths { get { return _strengths; } set { _strengths = value; } }
        private DirtyValue<DateTime?> _submittedDate;
        public DateTime? SubmittedDate { get { return _submittedDate; } set { _submittedDate = value; } }
        private DirtyValue<string> _supervisoryAppraiserLicenseNumber;
        public string SupervisoryAppraiserLicenseNumber { get { return _supervisoryAppraiserLicenseNumber; } set { _supervisoryAppraiserLicenseNumber = value; } }
        private DirtyValue<string> _suspendedBy;
        public string SuspendedBy { get { return _suspendedBy; } set { _suspendedBy = value; } }
        private DirtyValue<DateTime?> _suspendedDate;
        public DateTime? SuspendedDate { get { return _suspendedDate; } set { _suspendedDate = value; } }
        private DirtyValue<string> _suspendedReasons;
        public string SuspendedReasons { get { return _suspendedReasons; } set { _suspendedReasons = value; } }
        private ExtensionDataObject _extensionDataInternal;
        [JsonExtensionData]
        private ExtensionDataObject ExtensionDataInternal { get { return _extensionDataInternal ?? (_extensionDataInternal = new ExtensionDataObject()); } set { _extensionDataInternal = value; } }
        [JsonIgnore]
        public IDictionary<string, object> ExtensionData { get { return ExtensionDataInternal.InternalDictionary; } set { _extensionDataInternal = new ExtensionDataObject(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _appraisal.Dirty
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
                    || _suspendedReasons.Dirty
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}