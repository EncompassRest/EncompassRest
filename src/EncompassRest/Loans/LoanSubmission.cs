using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission : IDirty
    {
        private DirtyValue<decimal?> _amountAvailable;
        public decimal? AmountAvailable { get { return _amountAvailable; } set { _amountAvailable = value; } }
        private DirtyValue<decimal?> _amountRequiredToClose;
        public decimal? AmountRequiredToClose { get { return _amountRequiredToClose; } set { _amountRequiredToClose = value; } }
        private DirtyValue<string> _buydownDescription;
        public string BuydownDescription { get { return _buydownDescription; } set { _buydownDescription = value; } }
        private DirtyValue<string> _buydownMonthsPerAdjustment;
        public string BuydownMonthsPerAdjustment { get { return _buydownMonthsPerAdjustment; } set { _buydownMonthsPerAdjustment = value; } }
        private DirtyValue<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private DirtyValue<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get { return _currentRateSetDate; } set { _currentRateSetDate = value; } }
        private DirtyValue<DateTime?> _dateLastPaymentReceived;
        public DateTime? DateLastPaymentReceived { get { return _dateLastPaymentReceived; } set { _dateLastPaymentReceived = value; } }
        private DirtyValue<bool?> _floodIndicator;
        public bool? FloodIndicator { get { return _floodIndicator; } set { _floodIndicator = value; } }
        private DirtyValue<bool?> _hazardIndicator;
        public bool? HazardIndicator { get { return _hazardIndicator; } set { _hazardIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _isSecondaryRegistration;
        public bool? IsSecondaryRegistration { get { return _isSecondaryRegistration; } set { _isSecondaryRegistration = value; } }
        private DirtyList<LoanSubmissionFee> _loanSubmissionFees;
        public IList<LoanSubmissionFee> LoanSubmissionFees { get { return _loanSubmissionFees ?? (_loanSubmissionFees = new DirtyList<LoanSubmissionFee>()); } set { _loanSubmissionFees = new DirtyList<LoanSubmissionFee>(value); } }
        private DirtyValue<DateTime?> _lockDate;
        public DateTime? LockDate { get { return _lockDate; } set { _lockDate = value; } }
        private DirtyValue<DateTime?> _lockDateTimestampUtc;
        public DateTime? LockDateTimestampUtc { get { return _lockDateTimestampUtc; } set { _lockDateTimestampUtc = value; } }
        private DirtyValue<DateTime?> _lockExpiresDate;
        public DateTime? LockExpiresDate { get { return _lockExpiresDate; } set { _lockExpiresDate = value; } }
        private DirtyValue<bool?> _mmmPmiIndicator;
        public bool? MmmPmiIndicator { get { return _mmmPmiIndicator; } set { _mmmPmiIndicator = value; } }
        private DirtyValue<int?> _numberOfDays;
        public int? NumberOfDays { get { return _numberOfDays; } set { _numberOfDays = value; } }
        private DirtyValue<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        private DirtyValue<bool?> _otherIndicator;
        public bool? OtherIndicator { get { return _otherIndicator; } set { _otherIndicator = value; } }
        private DirtyValue<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        private DirtyValue<string> _rateLock;
        public string RateLock { get { return _rateLock; } set { _rateLock = value; } }
        private DirtyValue<DateTime?> _rateLockDisclosureDate;
        public DateTime? RateLockDisclosureDate { get { return _rateLockDisclosureDate; } set { _rateLockDisclosureDate = value; } }
        private DirtyValue<bool?> _reducedDocsIndicator;
        public bool? ReducedDocsIndicator { get { return _reducedDocsIndicator; } set { _reducedDocsIndicator = value; } }
        private DirtyValue<bool?> _taxesIndicator;
        public bool? TaxesIndicator { get { return _taxesIndicator; } set { _taxesIndicator = value; } }
        private DirtyValue<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        private DirtyValue<decimal?> _totalForDueBroker;
        public decimal? TotalForDueBroker { get { return _totalForDueBroker; } set { _totalForDueBroker = value; } }
        private DirtyValue<decimal?> _totalForDueLender;
        public decimal? TotalForDueLender { get { return _totalForDueLender; } set { _totalForDueLender = value; } }
        private DirtyValue<decimal?> _totalForPrimaryResidence;
        public decimal? TotalForPrimaryResidence { get { return _totalForPrimaryResidence; } set { _totalForPrimaryResidence = value; } }
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
                    || _loanSubmissionFees?.Dirty == true
                    || _extensionDataInternal?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionDataInternal != null) _extensionDataInternal.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}