using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class LoanSubmission
    {
        private Value<decimal?> _amountAvailable;
        public decimal? AmountAvailable { get { return _amountAvailable; } set { _amountAvailable = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountAvailable() => !_amountAvailable.Clean;
        private Value<decimal?> _amountRequiredToClose;
        public decimal? AmountRequiredToClose { get { return _amountRequiredToClose; } set { _amountRequiredToClose = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmountRequiredToClose() => !_amountRequiredToClose.Clean;
        private Value<string> _buydownDescription;
        public string BuydownDescription { get { return _buydownDescription; } set { _buydownDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownDescription() => !_buydownDescription.Clean;
        private Value<string> _buydownMonthsPerAdjustment;
        public string BuydownMonthsPerAdjustment { get { return _buydownMonthsPerAdjustment; } set { _buydownMonthsPerAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBuydownMonthsPerAdjustment() => !_buydownMonthsPerAdjustment.Clean;
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !_comments.Clean;
        private Value<DateTime?> _currentRateSetDate;
        public DateTime? CurrentRateSetDate { get { return _currentRateSetDate; } set { _currentRateSetDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentRateSetDate() => !_currentRateSetDate.Clean;
        private Value<DateTime?> _dateLastPaymentReceived;
        public DateTime? DateLastPaymentReceived { get { return _dateLastPaymentReceived; } set { _dateLastPaymentReceived = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDateLastPaymentReceived() => !_dateLastPaymentReceived.Clean;
        private Value<bool?> _floodIndicator;
        public bool? FloodIndicator { get { return _floodIndicator; } set { _floodIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodIndicator() => !_floodIndicator.Clean;
        private Value<bool?> _hazardIndicator;
        public bool? HazardIndicator { get { return _hazardIndicator; } set { _hazardIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHazardIndicator() => !_hazardIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _isSecondaryRegistration;
        public bool? IsSecondaryRegistration { get { return _isSecondaryRegistration; } set { _isSecondaryRegistration = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIsSecondaryRegistration() => !_isSecondaryRegistration.Clean;
        private Value<List<LoanSubmissionFee>> _loanSubmissionFees;
        public List<LoanSubmissionFee> LoanSubmissionFees { get { return _loanSubmissionFees; } set { _loanSubmissionFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSubmissionFees() => !_loanSubmissionFees.Clean;
        private Value<DateTime?> _lockDate;
        public DateTime? LockDate { get { return _lockDate; } set { _lockDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockDate() => !_lockDate.Clean;
        private Value<DateTime?> _lockDateTimestampUtc;
        public DateTime? LockDateTimestampUtc { get { return _lockDateTimestampUtc; } set { _lockDateTimestampUtc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockDateTimestampUtc() => !_lockDateTimestampUtc.Clean;
        private Value<DateTime?> _lockExpiresDate;
        public DateTime? LockExpiresDate { get { return _lockExpiresDate; } set { _lockExpiresDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockExpiresDate() => !_lockExpiresDate.Clean;
        private Value<bool?> _mmmPmiIndicator;
        public bool? MmmPmiIndicator { get { return _mmmPmiIndicator; } set { _mmmPmiIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMmmPmiIndicator() => !_mmmPmiIndicator.Clean;
        private Value<int?> _numberOfDays;
        public int? NumberOfDays { get { return _numberOfDays; } set { _numberOfDays = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfDays() => !_numberOfDays.Clean;
        private Value<string> _otherDescription;
        public string OtherDescription { get { return _otherDescription; } set { _otherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherDescription() => !_otherDescription.Clean;
        private Value<bool?> _otherIndicator;
        public bool? OtherIndicator { get { return _otherIndicator; } set { _otherIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherIndicator() => !_otherIndicator.Clean;
        private Value<string> _programCode;
        public string ProgramCode { get { return _programCode; } set { _programCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProgramCode() => !_programCode.Clean;
        private Value<string> _rateLock;
        public string RateLock { get { return _rateLock; } set { _rateLock = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLock() => !_rateLock.Clean;
        private Value<DateTime?> _rateLockDisclosureDate;
        public DateTime? RateLockDisclosureDate { get { return _rateLockDisclosureDate; } set { _rateLockDisclosureDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRateLockDisclosureDate() => !_rateLockDisclosureDate.Clean;
        private Value<bool?> _reducedDocsIndicator;
        public bool? ReducedDocsIndicator { get { return _reducedDocsIndicator; } set { _reducedDocsIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReducedDocsIndicator() => !_reducedDocsIndicator.Clean;
        private Value<bool?> _taxesIndicator;
        public bool? TaxesIndicator { get { return _taxesIndicator; } set { _taxesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesIndicator() => !_taxesIndicator.Clean;
        private Value<decimal?> _total;
        public decimal? Total { get { return _total; } set { _total = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotal() => !_total.Clean;
        private Value<decimal?> _totalDiscountPointCharged;
        public decimal? TotalDiscountPointCharged { get { return _totalDiscountPointCharged; } set { _totalDiscountPointCharged = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDiscountPointCharged() => !_totalDiscountPointCharged.Clean;
        private Value<decimal?> _totalForDueBroker;
        public decimal? TotalForDueBroker { get { return _totalForDueBroker; } set { _totalForDueBroker = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForDueBroker() => !_totalForDueBroker.Clean;
        private Value<decimal?> _totalForDueLender;
        public decimal? TotalForDueLender { get { return _totalForDueLender; } set { _totalForDueLender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForDueLender() => !_totalForDueLender.Clean;
        private Value<decimal?> _totalForPrimaryResidence;
        public decimal? TotalForPrimaryResidence { get { return _totalForPrimaryResidence; } set { _totalForPrimaryResidence = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForPrimaryResidence() => !_totalForPrimaryResidence.Clean;
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
                var v0 = _amountAvailable; v0.Clean = value; _amountAvailable = v0;
                var v1 = _amountRequiredToClose; v1.Clean = value; _amountRequiredToClose = v1;
                var v2 = _buydownDescription; v2.Clean = value; _buydownDescription = v2;
                var v3 = _buydownMonthsPerAdjustment; v3.Clean = value; _buydownMonthsPerAdjustment = v3;
                var v4 = _comments; v4.Clean = value; _comments = v4;
                var v5 = _currentRateSetDate; v5.Clean = value; _currentRateSetDate = v5;
                var v6 = _dateLastPaymentReceived; v6.Clean = value; _dateLastPaymentReceived = v6;
                var v7 = _floodIndicator; v7.Clean = value; _floodIndicator = v7;
                var v8 = _hazardIndicator; v8.Clean = value; _hazardIndicator = v8;
                var v9 = _id; v9.Clean = value; _id = v9;
                var v10 = _isSecondaryRegistration; v10.Clean = value; _isSecondaryRegistration = v10;
                var v11 = _loanSubmissionFees; v11.Clean = value; _loanSubmissionFees = v11;
                var v12 = _lockDate; v12.Clean = value; _lockDate = v12;
                var v13 = _lockDateTimestampUtc; v13.Clean = value; _lockDateTimestampUtc = v13;
                var v14 = _lockExpiresDate; v14.Clean = value; _lockExpiresDate = v14;
                var v15 = _mmmPmiIndicator; v15.Clean = value; _mmmPmiIndicator = v15;
                var v16 = _numberOfDays; v16.Clean = value; _numberOfDays = v16;
                var v17 = _otherDescription; v17.Clean = value; _otherDescription = v17;
                var v18 = _otherIndicator; v18.Clean = value; _otherIndicator = v18;
                var v19 = _programCode; v19.Clean = value; _programCode = v19;
                var v20 = _rateLock; v20.Clean = value; _rateLock = v20;
                var v21 = _rateLockDisclosureDate; v21.Clean = value; _rateLockDisclosureDate = v21;
                var v22 = _reducedDocsIndicator; v22.Clean = value; _reducedDocsIndicator = v22;
                var v23 = _taxesIndicator; v23.Clean = value; _taxesIndicator = v23;
                var v24 = _total; v24.Clean = value; _total = v24;
                var v25 = _totalDiscountPointCharged; v25.Clean = value; _totalDiscountPointCharged = v25;
                var v26 = _totalForDueBroker; v26.Clean = value; _totalForDueBroker = v26;
                var v27 = _totalForDueLender; v27.Clean = value; _totalForDueLender = v27;
                var v28 = _totalForPrimaryResidence; v28.Clean = value; _totalForPrimaryResidence = v28;
                _settingClean = 0;
            }
        }
    }
}