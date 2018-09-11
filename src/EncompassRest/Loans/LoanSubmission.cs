using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanSubmission
    /// </summary>
    public sealed partial class LoanSubmission : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amountAvailable;
        /// <summary>
        /// Trans Details Amt Available [199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Amt Available")]
        public decimal? AmountAvailable { get => _amountAvailable; set => SetField(ref _amountAvailable, value); }
        private DirtyValue<decimal?> _amountRequiredToClose;
        /// <summary>
        /// Trans Details Amt Required To Close [743]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Details Amt Required To Close")]
        public decimal? AmountRequiredToClose { get => _amountRequiredToClose; set => SetField(ref _amountRequiredToClose, value); }
        private DirtyValue<string> _buydownDescription;
        /// <summary>
        /// Loan Info Buydown Descr [1297]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown Descr")]
        public string BuydownDescription { get => _buydownDescription; set => SetField(ref _buydownDescription, value); }
        private DirtyValue<string> _buydownMonthsPerAdjustment;
        /// <summary>
        /// Loan Info Buydown Mos [1275]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info Buydown Mos")]
        public string BuydownMonthsPerAdjustment { get => _buydownMonthsPerAdjustment; set => SetField(ref _buydownMonthsPerAdjustment, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Trans Details Comments/Special Instr [472]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Comments/Special Instr")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<DateTime?> _currentRateSetDate;
        /// <summary>
        /// Last Rate Set Date [3253]
        /// </summary>
        [LoanFieldProperty(Description = "Last Rate Set Date")]
        public DateTime? CurrentRateSetDate { get => _currentRateSetDate; set => SetField(ref _currentRateSetDate, value); }
        private DirtyValue<DateTime?> _dateLastPaymentReceived;
        /// <summary>
        /// Trans Details Date Last Pymt Recd [LOANSUB.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Date Last Pymt Recd")]
        public DateTime? DateLastPaymentReceived { get => _dateLastPaymentReceived; set => SetField(ref _dateLastPaymentReceived, value); }
        private DirtyValue<bool?> _floodIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Flood [LOANSUB.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Flood", OptionsJson = "{\"true\":\"Flood\"}")]
        public bool? FloodIndicator { get => _floodIndicator; set => SetField(ref _floodIndicator, value); }
        private DirtyValue<bool?> _hazardIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Hazard [LOANSUB.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Hazard", OptionsJson = "{\"true\":\"Hazard\"}")]
        public bool? HazardIndicator { get => _hazardIndicator; set => SetField(ref _hazardIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanSubmission Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _isSecondaryRegistration;
        /// <summary>
        /// Secondary Registration [3941]
        /// </summary>
        [LoanFieldProperty(Description = "Secondary Registration")]
        public bool? IsSecondaryRegistration { get => _isSecondaryRegistration; set => SetField(ref _isSecondaryRegistration, value); }
        private DirtyList<LoanSubmissionFee> _loanSubmissionFees;
        /// <summary>
        /// LoanSubmission LoanSubmissionFees
        /// </summary>
        public IList<LoanSubmissionFee> LoanSubmissionFees { get => GetField(ref _loanSubmissionFees); set => SetField(ref _loanSubmissionFees, value); }
        private DirtyValue<DateTime?> _lockDate;
        /// <summary>
        /// Trans Details Lock Date [761]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Lock Date")]
        public DateTime? LockDate { get => _lockDate; set => SetField(ref _lockDate, value); }
        private DirtyValue<DateTime?> _lockDateTimestampUtc;
        /// <summary>
        /// Trans Details Lock Date Modification Timestamp [3200]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME, Description = "Trans Details Lock Date Modification Timestamp")]
        public DateTime? LockDateTimestampUtc { get => _lockDateTimestampUtc; set => SetField(ref _lockDateTimestampUtc, value); }
        private DirtyValue<DateTime?> _lockExpiresDate;
        /// <summary>
        /// Trans Details Rate Lock Expires [762]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock Expires")]
        public DateTime? LockExpiresDate { get => _lockExpiresDate; set => SetField(ref _lockExpiresDate, value); }
        private DirtyValue<bool?> _mmmPmiIndicator;
        /// <summary>
        /// Loan Info ARM Impounds MMI/PMI [LOANSUB.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds MMI/PMI", OptionsJson = "{\"true\":\"MMI / PMI\"}")]
        public bool? MmmPmiIndicator { get => _mmmPmiIndicator; set => SetField(ref _mmmPmiIndicator, value); }
        private DirtyValue<int?> _numberOfDays;
        /// <summary>
        /// Trans Details Rate Lock # Days [432]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock # Days")]
        public int? NumberOfDays { get => _numberOfDays; set => SetField(ref _numberOfDays, value); }
        private DirtyValue<string> _otherDescription;
        /// <summary>
        /// Loan Info ARM Impounds Other Descr [LOANSUB.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Other Descr")]
        public string OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }
        private DirtyValue<bool?> _otherIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Other [LOANSUB.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Other")]
        public bool? OtherIndicator { get => _otherIndicator; set => SetField(ref _otherIndicator, value); }
        private DirtyValue<string> _programCode;
        /// <summary>
        /// Trans Details Loan Product Code [1130]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Product Code")]
        public string ProgramCode { get => _programCode; set => SetField(ref _programCode, value); }
        private DirtyValue<string> _rateLock;
        /// <summary>
        /// Trans Details Rate Lock Type [431]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Rate Lock Type")]
        public string RateLock { get => _rateLock; set => SetField(ref _rateLock, value); }
        private DirtyValue<DateTime?> _rateLockDisclosureDate;
        /// <summary>
        /// Rate Lock Disclosure Date [3259]
        /// </summary>
        [LoanFieldProperty(Description = "Rate Lock Disclosure Date")]
        public DateTime? RateLockDisclosureDate { get => _rateLockDisclosureDate; set => SetField(ref _rateLockDisclosureDate, value); }
        private DirtyValue<bool?> _reducedDocsIndicator;
        /// <summary>
        /// Trans Details Reduced Documents [246]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Reduced Documents")]
        public bool? ReducedDocsIndicator { get => _reducedDocsIndicator; set => SetField(ref _reducedDocsIndicator, value); }
        private DirtyValue<bool?> _taxesIndicator;
        /// <summary>
        /// Loan Info ARM Impounds Taxes [LOANSUB.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Info ARM Impounds Taxes", OptionsJson = "{\"true\":\"Taxes\"}")]
        public bool? TaxesIndicator { get => _taxesIndicator; set => SetField(ref _taxesIndicator, value); }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// Fees Total Payable Items (Broker/Lender) [435]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items (Broker/Lender)")]
        public decimal? Total { get => _total; set => SetField(ref _total, value); }
        private DirtyValue<decimal?> _totalDiscountPointCharged;
        /// <summary>
        /// Fees Total Payable Items Discount Fee [331]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Discount Fee")]
        public decimal? TotalDiscountPointCharged { get => _totalDiscountPointCharged; set => SetField(ref _totalDiscountPointCharged, value); }
        private DirtyValue<decimal?> _totalForDueBroker;
        /// <summary>
        /// Fees Total Payable Items Broker [434]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Broker")]
        public decimal? TotalForDueBroker { get => _totalForDueBroker; set => SetField(ref _totalForDueBroker, value); }
        private DirtyValue<decimal?> _totalForDueLender;
        /// <summary>
        /// Fees Total Payable Items Lender [433]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Payable Items Lender")]
        public decimal? TotalForDueLender { get => _totalForDueLender; set => SetField(ref _totalForDueLender, value); }
        private DirtyValue<decimal?> _totalForPrimaryResidence;
        /// <summary>
        /// Expenses Total Primary Housing Exp Plus Co-mort [1299]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Total Primary Housing Exp Plus Co-mort")]
        public decimal? TotalForPrimaryResidence { get => _totalForPrimaryResidence; set => SetField(ref _totalForPrimaryResidence, value); }
    }
}