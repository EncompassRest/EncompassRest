namespace EncompassApi.Loans
{
    /// <summary>
    /// Disclosure
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Disclosure : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _cdAppraisalFee;
        private DirtyValue<decimal?>? _cdCreditReportFee;
        private DirtyValue<decimal?>? _cdLoanDiscountFee;
        private DirtyValue<decimal?>? _cdNonShoppableServices;
        private DirtyValue<decimal?>? _cdOriginationCharges;
        private DirtyValue<decimal?>? _cdShoppableServices;
        private DirtyValue<decimal?>? _cdTaxesGovtFees;
        private DirtyValue<int?>? _disclosureIndex;
        private DirtyValue<bool?>? _entityDeleted;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _leAppraisalFee;
        private DirtyValue<decimal?>? _leCreditReportFee;
        private DirtyValue<decimal?>? _leLoanDiscountFee;
        private DirtyValue<decimal?>? _leNonShoppableServices;
        private DirtyValue<decimal?>? _leOriginationCharges;
        private DirtyValue<decimal?>? _leShoppableServices;
        private DirtyValue<decimal?>? _leTaxesGovtFees;
        private DirtyValue<decimal?>? _pcAppraisalFee;
        private DirtyValue<decimal?>? _pcCreditReportFee;
        private DirtyValue<decimal?>? _pcLoanDiscountFee;
        private DirtyValue<decimal?>? _pcNonShoppableServices;
        private DirtyValue<decimal?>? _pcOriginationCharges;
        private DirtyValue<decimal?>? _pcShoppableServices;
        private DirtyValue<decimal?>? _pcTaxesGovtFees;

        /// <summary>
        /// CD Appraisal Fee [DISCNN20]
        /// </summary>
        public decimal? CdAppraisalFee { get => _cdAppraisalFee; set => SetField(ref _cdAppraisalFee, value); }

        /// <summary>
        /// CD Credit Report Fee [DISCNN17]
        /// </summary>
        public decimal? CdCreditReportFee { get => _cdCreditReportFee; set => SetField(ref _cdCreditReportFee, value); }

        /// <summary>
        /// CD Loan Discount Fee [DISCNN14]
        /// </summary>
        public decimal? CdLoanDiscountFee { get => _cdLoanDiscountFee; set => SetField(ref _cdLoanDiscountFee, value); }

        /// <summary>
        /// CD Non Shoppable Services [DISCNN05]
        /// </summary>
        public decimal? CdNonShoppableServices { get => _cdNonShoppableServices; set => SetField(ref _cdNonShoppableServices, value); }

        /// <summary>
        /// CD Origination Charges [DISCNN02]
        /// </summary>
        public decimal? CdOriginationCharges { get => _cdOriginationCharges; set => SetField(ref _cdOriginationCharges, value); }

        /// <summary>
        /// CD Shoppable Services [DISCNN08]
        /// </summary>
        public decimal? CdShoppableServices { get => _cdShoppableServices; set => SetField(ref _cdShoppableServices, value); }

        /// <summary>
        /// CD Taxes and Goveernment Fees [DISCNN11]
        /// </summary>
        public decimal? CdTaxesGovtFees { get => _cdTaxesGovtFees; set => SetField(ref _cdTaxesGovtFees, value); }

        /// <summary>
        /// Disclosure DisclosureIndex
        /// </summary>
        public int? DisclosureIndex { get => _disclosureIndex; set => SetField(ref _disclosureIndex, value); }

        /// <summary>
        /// Disclosure EntityDeleted
        /// </summary>
        public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

        /// <summary>
        /// Disclosure Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LE Appraisal Fee [DISCNN19]
        /// </summary>
        public decimal? LeAppraisalFee { get => _leAppraisalFee; set => SetField(ref _leAppraisalFee, value); }

        /// <summary>
        /// LE Credit Report Fee [DISCNN16]
        /// </summary>
        public decimal? LeCreditReportFee { get => _leCreditReportFee; set => SetField(ref _leCreditReportFee, value); }

        /// <summary>
        /// LE Loan Discount Fee [DISCNN13]
        /// </summary>
        public decimal? LeLoanDiscountFee { get => _leLoanDiscountFee; set => SetField(ref _leLoanDiscountFee, value); }

        /// <summary>
        /// LE Non Shoppable Services [DISCNN04]
        /// </summary>
        public decimal? LeNonShoppableServices { get => _leNonShoppableServices; set => SetField(ref _leNonShoppableServices, value); }

        /// <summary>
        /// LE Origination Charges [DISCNN01]
        /// </summary>
        public decimal? LeOriginationCharges { get => _leOriginationCharges; set => SetField(ref _leOriginationCharges, value); }

        /// <summary>
        /// LE Shoppable Services [DISCNN07]
        /// </summary>
        public decimal? LeShoppableServices { get => _leShoppableServices; set => SetField(ref _leShoppableServices, value); }

        /// <summary>
        /// LE Taxes and Goveernment Fees [DISCNN10]
        /// </summary>
        public decimal? LeTaxesGovtFees { get => _leTaxesGovtFees; set => SetField(ref _leTaxesGovtFees, value); }

        /// <summary>
        /// PC Appraisal Fee [DISCNN21]
        /// </summary>
        public decimal? PcAppraisalFee { get => _pcAppraisalFee; set => SetField(ref _pcAppraisalFee, value); }

        /// <summary>
        /// PC Credit Report Fee [DISCNN18]
        /// </summary>
        public decimal? PcCreditReportFee { get => _pcCreditReportFee; set => SetField(ref _pcCreditReportFee, value); }

        /// <summary>
        /// PC Loan Discount Fee [DISCNN15]
        /// </summary>
        public decimal? PcLoanDiscountFee { get => _pcLoanDiscountFee; set => SetField(ref _pcLoanDiscountFee, value); }

        /// <summary>
        /// PC Non Shoppable Services [DISCNN06]
        /// </summary>
        public decimal? PcNonShoppableServices { get => _pcNonShoppableServices; set => SetField(ref _pcNonShoppableServices, value); }

        /// <summary>
        /// PC Origination Charges [DISCNN03]
        /// </summary>
        public decimal? PcOriginationCharges { get => _pcOriginationCharges; set => SetField(ref _pcOriginationCharges, value); }

        /// <summary>
        /// PC Shoppable Services [DISCNN09]
        /// </summary>
        public decimal? PcShoppableServices { get => _pcShoppableServices; set => SetField(ref _pcShoppableServices, value); }

        /// <summary>
        /// PC Taxes and Goveernment Fees [DISCNN12]
        /// </summary>
        public decimal? PcTaxesGovtFees { get => _pcTaxesGovtFees; set => SetField(ref _pcTaxesGovtFees, value); }
    }
}