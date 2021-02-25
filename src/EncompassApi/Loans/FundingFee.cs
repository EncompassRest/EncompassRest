namespace EncompassApi.Loans
{
    /// <summary>
    /// FundingFee
    /// </summary>
    public sealed partial class FundingFee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _amount;
        private DirtyValue<bool?>? _balanceChecked;
        private DirtyValue<string?>? _cdLineId;
        private DirtyValue<string?>? _feeDescription;
        private DirtyValue<string?>? _feeDescription2015;
        private DirtyValue<string?>? _lineId;
        private DirtyValue<int?>? _lineNumber;
        private DirtyValue<decimal?>? _pacBroker2015;
        private DirtyValue<decimal?>? _pacLender2015;
        private DirtyValue<decimal?>? _pacOther2015;
        private DirtyValue<string?>? _paidBy;
        private DirtyValue<string?>? _paidTo;
        private DirtyValue<string?>? _payee;
        private DirtyValue<decimal?>? _pocAmount;
        private DirtyValue<decimal?>? _pocBorrower2015;
        private DirtyValue<decimal?>? _pocBroker2015;
        private DirtyValue<decimal?>? _pocLender2015;
        private DirtyValue<decimal?>? _pocOther2015;
        private DirtyValue<string?>? _pocPaidBy;
        private DirtyValue<decimal?>? _pocSeller2015;
        private DirtyValue<decimal?>? _ptcAmount;
        private DirtyValue<string?>? _ptcPaidBy;

        /// <summary>
        /// FundingFee Amount
        /// </summary>
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// FundingFee BalanceChecked
        /// </summary>
        public bool? BalanceChecked { get => _balanceChecked; set => SetField(ref _balanceChecked, value); }

        /// <summary>
        /// FundingFee CdLineId
        /// </summary>
        public string? CdLineId { get => _cdLineId; set => SetField(ref _cdLineId, value); }

        /// <summary>
        /// FundingFee FeeDescription
        /// </summary>
        public string? FeeDescription { get => _feeDescription; set => SetField(ref _feeDescription, value); }

        /// <summary>
        /// FundingFee FeeDescription2015
        /// </summary>
        public string? FeeDescription2015 { get => _feeDescription2015; set => SetField(ref _feeDescription2015, value); }

        /// <summary>
        /// FundingFee LineId
        /// </summary>
        public string? LineId { get => _lineId; set => SetField(ref _lineId, value); }

        /// <summary>
        /// FundingFee LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

        /// <summary>
        /// FundingFee PacBroker2015
        /// </summary>
        public decimal? PacBroker2015 { get => _pacBroker2015; set => SetField(ref _pacBroker2015, value); }

        /// <summary>
        /// FundingFee PacLender2015
        /// </summary>
        public decimal? PacLender2015 { get => _pacLender2015; set => SetField(ref _pacLender2015, value); }

        /// <summary>
        /// FundingFee PacOther2015
        /// </summary>
        public decimal? PacOther2015 { get => _pacOther2015; set => SetField(ref _pacOther2015, value); }

        /// <summary>
        /// FundingFee PaidBy
        /// </summary>
        public string? PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

        /// <summary>
        /// FundingFee PaidTo
        /// </summary>
        public string? PaidTo { get => _paidTo; set => SetField(ref _paidTo, value); }

        /// <summary>
        /// FundingFee Payee
        /// </summary>
        public string? Payee { get => _payee; set => SetField(ref _payee, value); }

        /// <summary>
        /// FundingFee PocAmount
        /// </summary>
        public decimal? PocAmount { get => _pocAmount; set => SetField(ref _pocAmount, value); }

        /// <summary>
        /// FundingFee PocBorrower2015
        /// </summary>
        public decimal? PocBorrower2015 { get => _pocBorrower2015; set => SetField(ref _pocBorrower2015, value); }

        /// <summary>
        /// FundingFee PocBroker2015
        /// </summary>
        public decimal? PocBroker2015 { get => _pocBroker2015; set => SetField(ref _pocBroker2015, value); }

        /// <summary>
        /// FundingFee PocLender2015
        /// </summary>
        public decimal? PocLender2015 { get => _pocLender2015; set => SetField(ref _pocLender2015, value); }

        /// <summary>
        /// FundingFee PocOther2015
        /// </summary>
        public decimal? PocOther2015 { get => _pocOther2015; set => SetField(ref _pocOther2015, value); }

        /// <summary>
        /// FundingFee PocPaidBy
        /// </summary>
        public string? PocPaidBy { get => _pocPaidBy; set => SetField(ref _pocPaidBy, value); }

        /// <summary>
        /// FundingFee PocSeller2015
        /// </summary>
        public decimal? PocSeller2015 { get => _pocSeller2015; set => SetField(ref _pocSeller2015, value); }

        /// <summary>
        /// FundingFee PtcAmount
        /// </summary>
        public decimal? PtcAmount { get => _ptcAmount; set => SetField(ref _ptcAmount, value); }

        /// <summary>
        /// FundingFee PtcPaidBy
        /// </summary>
        public string? PtcPaidBy { get => _ptcPaidBy; set => SetField(ref _ptcPaidBy, value); }
    }
}