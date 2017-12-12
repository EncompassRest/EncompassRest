#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amountAvailable;
        public decimal? AmountAvailable { get => _amountAvailable; set => _amountAvailable = value; }
        private DirtyValue<decimal?> _amountRequiredToClose;
        public decimal? AmountRequiredToClose { get => _amountRequiredToClose; set => _amountRequiredToClose = value; }
        private DirtyValue<string> _buydownDescription;
        public string BuydownDescription { get => _buydownDescription; set => _buydownDescription = value; }
        private DirtyValue<string> _buydownMonthsPerAdjustment;
        public string BuydownMonthsPerAdjustment { get => _buydownMonthsPerAdjustment; set => _buydownMonthsPerAdjustment = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => _currentRateSetDate = value; }
        private DirtyValue<DateTime?> _dateLastPaymentReceived;
        public DateTime? DateLastPaymentReceived { get => _dateLastPaymentReceived; set => _dateLastPaymentReceived = value; }
        private DirtyValue<bool?> _floodIndicator;
        public bool? FloodIndicator { get => _floodIndicator; set => _floodIndicator = value; }
        private DirtyValue<bool?> _hazardIndicator;
        public bool? HazardIndicator { get => _hazardIndicator; set => _hazardIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSecondaryRegistration;
        public bool? IsSecondaryRegistration { get => _isSecondaryRegistration; set => _isSecondaryRegistration = value; }
        private DirtyList<LoanSubmissionFee> _loanSubmissionFees;
        public IList<LoanSubmissionFee> LoanSubmissionFees { get => _loanSubmissionFees ?? (_loanSubmissionFees = new DirtyList<LoanSubmissionFee>()); set => _loanSubmissionFees = new DirtyList<LoanSubmissionFee>(value); }
        private DirtyValue<DateTime?> _lockDate;
        public DateTime? LockDate { get => _lockDate; set => _lockDate = value; }
        private DirtyValue<DateTime?> _lockDateTimestampUtc;
        public DateTime? LockDateTimestampUtc { get => _lockDateTimestampUtc; set => _lockDateTimestampUtc = value; }
        private DirtyValue<DateTime?> _lockExpiresDate;
        public DateTime? LockExpiresDate { get => _lockExpiresDate; set => _lockExpiresDate = value; }
        private DirtyValue<bool?> _mmmPmiIndicator;
        public bool? MmmPmiIndicator { get => _mmmPmiIndicator; set => _mmmPmiIndicator = value; }
        private DirtyValue<int?> _numberOfDays;
        public int? NumberOfDays { get => _numberOfDays; set => _numberOfDays = value; }
        private DirtyValue<string> _otherDescription;
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _otherIndicator;
        public bool? OtherIndicator { get => _otherIndicator; set => _otherIndicator = value; }
        private DirtyValue<string> _programCode;
        public string ProgramCode { get => _programCode; set => _programCode = value; }
        private DirtyValue<string> _rateLock;
        public string RateLock { get => _rateLock; set => _rateLock = value; }
        private DirtyValue<DateTime?> _rateLockDisclosureDate;
        public DateTime? RateLockDisclosureDate { get => _rateLockDisclosureDate; set => _rateLockDisclosureDate = value; }
        private DirtyValue<bool?> _reducedDocsIndicator;
        public bool? ReducedDocsIndicator { get => _reducedDocsIndicator; set => _reducedDocsIndicator = value; }
        private DirtyValue<bool?> _taxesIndicator;
        public bool? TaxesIndicator { get => _taxesIndicator; set => _taxesIndicator = value; }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => _totalDiscountPointCharged = value; }
        private DirtyValue<decimal?> _totalForDueBroker;
        public decimal? TotalForDueBroker { get => _totalForDueBroker; set => _totalForDueBroker = value; }
        private DirtyValue<decimal?> _totalForDueLender;
        public decimal? TotalForDueLender { get => _totalForDueLender; set => _totalForDueLender = value; }
        private DirtyValue<decimal?> _totalForPrimaryResidence;
        public decimal? TotalForPrimaryResidence { get => _totalForPrimaryResidence; set => _totalForPrimaryResidence = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amountAvailable.Dirty
                    || _amountRequiredToClose.Dirty
                    || _buydownDescription.Dirty
                    || _buydownMonthsPerAdjustment.Dirty
                    || _comments.Dirty
                    || _currentRateSetDate.Dirty
                    || _dateLastPaymentReceived.Dirty
                    || _floodIndicator.Dirty
                    || _hazardIndicator.Dirty
                    || _id.Dirty
                    || _isSecondaryRegistration.Dirty
                    || _lockDate.Dirty
                    || _lockDateTimestampUtc.Dirty
                    || _lockExpiresDate.Dirty
                    || _mmmPmiIndicator.Dirty
                    || _numberOfDays.Dirty
                    || _otherDescription.Dirty
                    || _otherIndicator.Dirty
                    || _programCode.Dirty
                    || _rateLock.Dirty
                    || _rateLockDisclosureDate.Dirty
                    || _reducedDocsIndicator.Dirty
                    || _taxesIndicator.Dirty
                    || _total.Dirty
                    || _totalDiscountPointCharged.Dirty
                    || _totalForDueBroker.Dirty
                    || _totalForDueLender.Dirty
                    || _totalForPrimaryResidence.Dirty
                    || _loanSubmissionFees?.Dirty == true;
            }
            set
            {
                _amountAvailable.Dirty = value;
                _amountRequiredToClose.Dirty = value;
                _buydownDescription.Dirty = value;
                _buydownMonthsPerAdjustment.Dirty = value;
                _comments.Dirty = value;
                _currentRateSetDate.Dirty = value;
                _dateLastPaymentReceived.Dirty = value;
                _floodIndicator.Dirty = value;
                _hazardIndicator.Dirty = value;
                _id.Dirty = value;
                _isSecondaryRegistration.Dirty = value;
                _lockDate.Dirty = value;
                _lockDateTimestampUtc.Dirty = value;
                _lockExpiresDate.Dirty = value;
                _mmmPmiIndicator.Dirty = value;
                _numberOfDays.Dirty = value;
                _otherDescription.Dirty = value;
                _otherIndicator.Dirty = value;
                _programCode.Dirty = value;
                _rateLock.Dirty = value;
                _rateLockDisclosureDate.Dirty = value;
                _reducedDocsIndicator.Dirty = value;
                _taxesIndicator.Dirty = value;
                _total.Dirty = value;
                _totalDiscountPointCharged.Dirty = value;
                _totalForDueBroker.Dirty = value;
                _totalForDueLender.Dirty = value;
                _totalForPrimaryResidence.Dirty = value;
                if (_loanSubmissionFees != null) _loanSubmissionFees.Dirty = value;
            }
        }
    }
}