using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission : IDirty
    {
        private Value<decimal?> _amountAvailable;
        public decimal? AmountAvailable { get { return _amountAvailable; } set { _amountAvailable = value; } }
        private Value<decimal?> _amountRequiredToClose;
        public decimal? AmountRequiredToClose { get { return _amountRequiredToClose; } set { _amountRequiredToClose = value; } }
        private Value<string> _buydownDescription;
        public string BuydownDescription { get { return _buydownDescription; } set { _buydownDescription = value; } }
        private Value<string> _buydownMonthsPerAdjustment;
        public string BuydownMonthsPerAdjustment { get { return _buydownMonthsPerAdjustment; } set { _buydownMonthsPerAdjustment = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get { return _currentRateSetDate; } set { _currentRateSetDate = value; } }
        private Value<DateTime?> _dateLastPaymentReceived;
        public DateTime? DateLastPaymentReceived { get { return _dateLastPaymentReceived; } set { _dateLastPaymentReceived = value; } }
        private Value<bool?> _floodIndicator;
        public bool? FloodIndicator { get { return _floodIndicator; } set { _floodIndicator = value; } }
        private Value<bool?> _hazardIndicator;
        public bool? HazardIndicator { get { return _hazardIndicator; } set { _hazardIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _isSecondaryRegistration;
        public bool? IsSecondaryRegistration { get { return _isSecondaryRegistration; } set { _isSecondaryRegistration = value; } }
        private DirtyList<LoanSubmissionFee> _loanSubmissionFees;
        public IList<LoanSubmissionFee> LoanSubmissionFees { get { var v = _loanSubmissionFees; return v ?? Interlocked.CompareExchange(ref _loanSubmissionFees, (v = new DirtyList<LoanSubmissionFee>()), null) ?? v; } set { _loanSubmissionFees = new DirtyList<LoanSubmissionFee>(value); } }
        private Value<DateTime?> _lockDate;
        public DateTime? LockDate { get { return _lockDate; } set { _lockDate = value; } }
        private Value<DateTime?> _lockDateTimestampUtc;
        public DateTime? LockDateTimestampUtc { get { return _lockDateTimestampUtc; } set { _lockDateTimestampUtc = value; } }
        private Value<DateTime?> _lockExpiresDate;
        public DateTime? LockExpiresDate { get { return _lockExpiresDate; } set { _lockExpiresDate = value; } }
        private Value<bool?> _mmmPmiIndicator;
        public bool? MmmPmiIndicator { get { return _mmmPmiIndicator; } set { _mmmPmiIndicator = value; } }
        private Value<int?> _numberOfDays;
        public int? NumberOfDays { get { return _numberOfDays; } set { _numberOfDays = value; } }
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private Value<bool?> _otherIndicator;
        public bool? OtherIndicator { get { return _otherIndicator; } set { _otherIndicator = value; } }
        private Value<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        private Value<string> _rateLock;
        public string RateLock { get { return _rateLock; } set { _rateLock = value; } }
        private Value<DateTime?> _rateLockDisclosureDate;
        public DateTime? RateLockDisclosureDate { get { return _rateLockDisclosureDate; } set { _rateLockDisclosureDate = value; } }
        private Value<bool?> _reducedDocsIndicator;
        public bool? ReducedDocsIndicator { get { return _reducedDocsIndicator; } set { _reducedDocsIndicator = value; } }
        private Value<bool?> _taxesIndicator;
        public bool? TaxesIndicator { get { return _taxesIndicator; } set { _taxesIndicator = value; } }
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private Value<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        private Value<decimal?> _totalForDueBroker;
        public decimal? TotalForDueBroker { get { return _totalForDueBroker; } set { _totalForDueBroker = value; } }
        private Value<decimal?> _totalForDueLender;
        public decimal? TotalForDueLender { get { return _totalForDueLender; } set { _totalForDueLender = value; } }
        private Value<decimal?> _totalForPrimaryResidence;
        public decimal? TotalForPrimaryResidence { get { return _totalForPrimaryResidence; } set { _totalForPrimaryResidence = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _amountAvailable.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}