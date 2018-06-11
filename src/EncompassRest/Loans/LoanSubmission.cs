using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanSubmission
    /// </summary>
    public sealed partial class LoanSubmission : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amountAvailable;
        /// <summary>
        /// Trans Details Amt Available [199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Amt Available")]
        public decimal? AmountAvailable { get => _amountAvailable; set => _amountAvailable = value; }
        private DirtyValue<decimal?> _amountRequiredToClose;
        /// <summary>
        /// Trans Details Amt Required To Close [743]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Amt Required To Close")]
        public decimal? AmountRequiredToClose { get => _amountRequiredToClose; set => _amountRequiredToClose = value; }
        private DirtyValue<string> _buydownDescription;
        /// <summary>
        /// Loan Info Buydown Descr [1297]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown Descr")]
        public string BuydownDescription { get => _buydownDescription; set => _buydownDescription = value; }
        private DirtyValue<string> _buydownMonthsPerAdjustment;
        /// <summary>
        /// Loan Info Buydown Mos [1275]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown Mos")]
        public string BuydownMonthsPerAdjustment { get => _buydownMonthsPerAdjustment; set => _buydownMonthsPerAdjustment = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Trans Details Comments/Special Instr [472]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Comments/Special Instr")]
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<DateTime?> _currentRateSetDate;
        /// <summary>
        /// Last Rate Set Date [3253]
        /// </summary>
        [LoanFieldProperty(Description = "Last Rate Set Date")]
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => _currentRateSetDate = value; }
        private DirtyValue<DateTime?> _dateLastPaymentReceived;
        /// <summary>
        /// Trans Details Date Last Pymt Recd [LOANSUB.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Date Last Pymt Recd")]
        public DateTime? DateLastPaymentReceived { get => _dateLastPaymentReceived; set => _dateLastPaymentReceived = value; }
        private DirtyValue<bool?> _floodIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Flood [LOANSUB.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Flood", OptionsJson = "{\"true\":\"Flood\"}")]
        public bool? FloodIndicator { get => _floodIndicator; set => _floodIndicator = value; }
        private DirtyValue<bool?> _hazardIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Hazard [LOANSUB.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Hazard", OptionsJson = "{\"true\":\"Hazard\"}")]
        public bool? HazardIndicator { get => _hazardIndicator; set => _hazardIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanSubmission Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _isSecondaryRegistration;
        /// <summary>
        /// Secondary Registration [3941]
        /// </summary>
        [LoanFieldProperty(Description = "Secondary Registration")]
        public bool? IsSecondaryRegistration { get => _isSecondaryRegistration; set => _isSecondaryRegistration = value; }
        private DirtyList<LoanSubmissionFee> _loanSubmissionFees;
        /// <summary>
        /// LoanSubmission LoanSubmissionFees
        /// </summary>
        public IList<LoanSubmissionFee> LoanSubmissionFees { get => _loanSubmissionFees ?? (_loanSubmissionFees = new DirtyList<LoanSubmissionFee>()); set => _loanSubmissionFees = new DirtyList<LoanSubmissionFee>(value); }
        private DirtyValue<DateTime?> _lockDate;
        /// <summary>
        /// Trans Details Lock Date [761]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lock Date")]
        public DateTime? LockDate { get => _lockDate; set => _lockDate = value; }
        private DirtyValue<DateTime?> _lockDateTimestampUtc;
        /// <summary>
        /// Trans Details Lock Date Modification Timestamp [3200]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, Description = "Trans Details Lock Date Modification Timestamp")]
        public DateTime? LockDateTimestampUtc { get => _lockDateTimestampUtc; set => _lockDateTimestampUtc = value; }
        private DirtyValue<DateTime?> _lockExpiresDate;
        /// <summary>
        /// Trans Details Rate Lock Expires [762]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock Expires")]
        public DateTime? LockExpiresDate { get => _lockExpiresDate; set => _lockExpiresDate = value; }
        private DirtyValue<bool?> _mmmPmiIndicator;
        /// <summary>
        /// Loan Info ARM Impounds MMI/PMI [LOANSUB.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds MMI/PMI", OptionsJson = "{\"true\":\"MMI / PMI\"}")]
        public bool? MmmPmiIndicator { get => _mmmPmiIndicator; set => _mmmPmiIndicator = value; }
        private DirtyValue<int?> _numberOfDays;
        /// <summary>
        /// Trans Details Rate Lock # Days [432]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock # Days")]
        public int? NumberOfDays { get => _numberOfDays; set => _numberOfDays = value; }
        private DirtyValue<string> _otherDescription;
        /// <summary>
        /// Loan Info ARM Impounds Other Descr [LOANSUB.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Other Descr")]
        public string OtherDescription { get => _otherDescription; set => _otherDescription = value; }
        private DirtyValue<bool?> _otherIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Other [LOANSUB.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Other")]
        public bool? OtherIndicator { get => _otherIndicator; set => _otherIndicator = value; }
        private DirtyValue<string> _programCode;
        /// <summary>
        /// Trans Details Loan Product Code [1130]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Product Code")]
        public string ProgramCode { get => _programCode; set => _programCode = value; }
        private DirtyValue<string> _rateLock;
        /// <summary>
        /// Trans Details Rate Lock Type [431]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock Type")]
        public string RateLock { get => _rateLock; set => _rateLock = value; }
        private DirtyValue<DateTime?> _rateLockDisclosureDate;
        /// <summary>
        /// Rate Lock Disclosure Date [3259]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Disclosure Date")]
        public DateTime? RateLockDisclosureDate { get => _rateLockDisclosureDate; set => _rateLockDisclosureDate = value; }
        private DirtyValue<bool?> _reducedDocsIndicator;
        /// <summary>
        /// Trans Details Reduced Documents [246]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Reduced Documents")]
        public bool? ReducedDocsIndicator { get => _reducedDocsIndicator; set => _reducedDocsIndicator = value; }
        private DirtyValue<bool?> _taxesIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Taxes [LOANSUB.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Taxes", OptionsJson = "{\"true\":\"Taxes\"}")]
        public bool? TaxesIndicator { get => _taxesIndicator; set => _taxesIndicator = value; }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// Fees Total Payable Items (Broker/Lender) [435]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items (Broker/Lender)")]
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        /// <summary>
        /// Fees Total Payable Items Discount Fee [331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Discount Fee")]
        public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => _totalDiscountPointCharged = value; }
        private DirtyValue<decimal?> _totalForDueBroker;
        /// <summary>
        /// Fees Total Payable Items Broker [434]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Broker")]
        public decimal? TotalForDueBroker { get => _totalForDueBroker; set => _totalForDueBroker = value; }
        private DirtyValue<decimal?> _totalForDueLender;
        /// <summary>
        /// Fees Total Payable Items Lender [433]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Lender")]
        public decimal? TotalForDueLender { get => _totalForDueLender; set => _totalForDueLender = value; }
        private DirtyValue<decimal?> _totalForPrimaryResidence;
        /// <summary>
        /// Expenses Total Primary Housing Exp Plus Co-mort [1299]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Primary Housing Exp Plus Co-mort")]
        public decimal? TotalForPrimaryResidence { get => _totalForPrimaryResidence; set => _totalForPrimaryResidence = value; }
        internal override bool DirtyInternal
        {
            get => _amountAvailable.Dirty
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