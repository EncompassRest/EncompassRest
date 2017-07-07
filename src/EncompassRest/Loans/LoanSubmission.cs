using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission : IClean
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
        private Value<List<LoanSubmissionFee>> _loanSubmissionFees;
        public List<LoanSubmissionFee> LoanSubmissionFees { get { return _loanSubmissionFees; } set { _loanSubmissionFees = value; } }
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
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _amountAvailable.Clean
                    && _amountRequiredToClose.Clean
                    && _buydownDescription.Clean
                    && _buydownMonthsPerAdjustment.Clean
                    && _comments.Clean
                    && _currentRateSetDate.Clean
                    && _dateLastPaymentReceived.Clean
                    && _floodIndicator.Clean
                    && _hazardIndicator.Clean
                    && _id.Clean
                    && _isSecondaryRegistration.Clean
                    && _loanSubmissionFees.Clean
                    && _lockDate.Clean
                    && _lockDateTimestampUtc.Clean
                    && _lockExpiresDate.Clean
                    && _mmmPmiIndicator.Clean
                    && _numberOfDays.Clean
                    && _otherDescription.Clean
                    && _otherIndicator.Clean
                    && _programCode.Clean
                    && _rateLock.Clean
                    && _rateLockDisclosureDate.Clean
                    && _reducedDocsIndicator.Clean
                    && _taxesIndicator.Clean
                    && _total.Clean
                    && _totalDiscountPointCharged.Clean
                    && _totalForDueBroker.Clean
                    && _totalForDueLender.Clean
                    && _totalForPrimaryResidence.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var amountAvailable = _amountAvailable; amountAvailable.Clean = value; _amountAvailable = amountAvailable;
                var amountRequiredToClose = _amountRequiredToClose; amountRequiredToClose.Clean = value; _amountRequiredToClose = amountRequiredToClose;
                var buydownDescription = _buydownDescription; buydownDescription.Clean = value; _buydownDescription = buydownDescription;
                var buydownMonthsPerAdjustment = _buydownMonthsPerAdjustment; buydownMonthsPerAdjustment.Clean = value; _buydownMonthsPerAdjustment = buydownMonthsPerAdjustment;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var currentRateSetDate = _currentRateSetDate; currentRateSetDate.Clean = value; _currentRateSetDate = currentRateSetDate;
                var dateLastPaymentReceived = _dateLastPaymentReceived; dateLastPaymentReceived.Clean = value; _dateLastPaymentReceived = dateLastPaymentReceived;
                var floodIndicator = _floodIndicator; floodIndicator.Clean = value; _floodIndicator = floodIndicator;
                var hazardIndicator = _hazardIndicator; hazardIndicator.Clean = value; _hazardIndicator = hazardIndicator;
                var id = _id; id.Clean = value; _id = id;
                var isSecondaryRegistration = _isSecondaryRegistration; isSecondaryRegistration.Clean = value; _isSecondaryRegistration = isSecondaryRegistration;
                var loanSubmissionFees = _loanSubmissionFees; loanSubmissionFees.Clean = value; _loanSubmissionFees = loanSubmissionFees;
                var lockDate = _lockDate; lockDate.Clean = value; _lockDate = lockDate;
                var lockDateTimestampUtc = _lockDateTimestampUtc; lockDateTimestampUtc.Clean = value; _lockDateTimestampUtc = lockDateTimestampUtc;
                var lockExpiresDate = _lockExpiresDate; lockExpiresDate.Clean = value; _lockExpiresDate = lockExpiresDate;
                var mmmPmiIndicator = _mmmPmiIndicator; mmmPmiIndicator.Clean = value; _mmmPmiIndicator = mmmPmiIndicator;
                var numberOfDays = _numberOfDays; numberOfDays.Clean = value; _numberOfDays = numberOfDays;
                var otherDescription = _otherDescription; otherDescription.Clean = value; _otherDescription = otherDescription;
                var otherIndicator = _otherIndicator; otherIndicator.Clean = value; _otherIndicator = otherIndicator;
                var programCode = _programCode; programCode.Clean = value; _programCode = programCode;
                var rateLock = _rateLock; rateLock.Clean = value; _rateLock = rateLock;
                var rateLockDisclosureDate = _rateLockDisclosureDate; rateLockDisclosureDate.Clean = value; _rateLockDisclosureDate = rateLockDisclosureDate;
                var reducedDocsIndicator = _reducedDocsIndicator; reducedDocsIndicator.Clean = value; _reducedDocsIndicator = reducedDocsIndicator;
                var taxesIndicator = _taxesIndicator; taxesIndicator.Clean = value; _taxesIndicator = taxesIndicator;
                var total = _total; total.Clean = value; _total = total;
                var totalDiscountPointCharged = _totalDiscountPointCharged; totalDiscountPointCharged.Clean = value; _totalDiscountPointCharged = totalDiscountPointCharged;
                var totalForDueBroker = _totalForDueBroker; totalForDueBroker.Clean = value; _totalForDueBroker = totalForDueBroker;
                var totalForDueLender = _totalForDueLender; totalForDueLender.Clean = value; _totalForDueLender = totalForDueLender;
                var totalForPrimaryResidence = _totalForPrimaryResidence; totalForPrimaryResidence.Clean = value; _totalForPrimaryResidence = totalForPrimaryResidence;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public LoanSubmission()
        {
            Clean = true;
        }
    }
}