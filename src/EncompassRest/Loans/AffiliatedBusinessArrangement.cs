using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// AffiliatedBusinessArrangement
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class AffiliatedBusinessArrangement : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _affiliatedBusinessArrangementIndex;
        private DirtyValue<string?>? _affiliateName;
        private DirtyValue<string?>? _chargeRangeChargesDescription1;
        private DirtyValue<string?>? _chargeRangeChargesDescription2;
        private DirtyValue<string?>? _chargeRangeChargesDescription3;
        private DirtyValue<string?>? _chargeRangeChargesDescription4;
        private DirtyValue<string?>? _chargeRangeChargesDescription5;
        private DirtyValue<string?>? _chargeRangeChargesDescription6;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _lenderAddress;
        private DirtyValue<string?>? _lenderAddressCity;
        private DirtyValue<StringEnumValue<State>>? _lenderAddressState;
        private DirtyValue<string?>? _lenderAddressZipcode;
        private DirtyValue<string?>? _lenderName;
        private DirtyValue<string?>? _natureOfRelationship;
        private DirtyValue<decimal?>? _percentOwnershipInterest;
        private DirtyValue<bool?>? _purchaseSaleRefinanceIndicator;
        private DirtyValue<bool?>? _requiredUseIndicator1;
        private DirtyValue<bool?>? _requiredUseIndicator2;
        private DirtyValue<bool?>? _requiredUseIndicator3;
        private DirtyValue<bool?>? _requiredUseIndicator4;
        private DirtyValue<bool?>? _requiredUseIndicator5;
        private DirtyValue<bool?>? _requiredUseIndicator6;
        private DirtyValue<string?>? _serviceDescription1;
        private DirtyValue<string?>? _serviceDescription2;
        private DirtyValue<string?>? _serviceDescription3;
        private DirtyValue<string?>? _serviceDescription4;
        private DirtyValue<string?>? _serviceDescription5;
        private DirtyValue<string?>? _serviceDescription6;
        private DirtyValue<bool?>? _settlementIndicator;

        /// <summary>
        /// AffiliatedBusinessArrangement AffiliatedBusinessArrangementIndex
        /// </summary>
        public int? AffiliatedBusinessArrangementIndex { get => _affiliatedBusinessArrangementIndex; set => SetField(ref _affiliatedBusinessArrangementIndex, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Affiliate Name [ABNN06]
        /// </summary>
        public string? AffiliateName { get => _affiliateName; set => SetField(ref _affiliateName, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 1 [ABNN16]
        /// </summary>
        public string? ChargeRangeChargesDescription1 { get => _chargeRangeChargesDescription1; set => SetField(ref _chargeRangeChargesDescription1, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 2 [ABNN17]
        /// </summary>
        public string? ChargeRangeChargesDescription2 { get => _chargeRangeChargesDescription2; set => SetField(ref _chargeRangeChargesDescription2, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 3 [ABNN18]
        /// </summary>
        public string? ChargeRangeChargesDescription3 { get => _chargeRangeChargesDescription3; set => SetField(ref _chargeRangeChargesDescription3, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 4 [ABNN19]
        /// </summary>
        public string? ChargeRangeChargesDescription4 { get => _chargeRangeChargesDescription4; set => SetField(ref _chargeRangeChargesDescription4, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 5 [ABNN20]
        /// </summary>
        public string? ChargeRangeChargesDescription5 { get => _chargeRangeChargesDescription5; set => SetField(ref _chargeRangeChargesDescription5, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Charge or Range of Charges Line 6 [ABNN21]
        /// </summary>
        public string? ChargeRangeChargesDescription6 { get => _chargeRangeChargesDescription6; set => SetField(ref _chargeRangeChargesDescription6, value); }

        /// <summary>
        /// AffiliatedBusinessArrangement Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address [ABNN02]
        /// </summary>
        public string? LenderAddress { get => _lenderAddress; set => SetField(ref _lenderAddress, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address City [ABNN03]
        /// </summary>
        public string? LenderAddressCity { get => _lenderAddressCity; set => SetField(ref _lenderAddressCity, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address State [ABNN04]
        /// </summary>
        public StringEnumValue<State> LenderAddressState { get => _lenderAddressState; set => SetField(ref _lenderAddressState, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Lender's Address Zipcode [ABNN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? LenderAddressZipcode { get => _lenderAddressZipcode; set => SetField(ref _lenderAddressZipcode, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Lender Name [ABNN01]
        /// </summary>
        public string? LenderName { get => _lenderName; set => SetField(ref _lenderName, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Nature of Relationship [ABNN07]
        /// </summary>
        public string? NatureOfRelationship { get => _natureOfRelationship; set => SetField(ref _natureOfRelationship, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Percentage of Ownership Interest [ABNN28]
        /// </summary>
        public decimal? PercentOwnershipInterest { get => _percentOwnershipInterest; set => SetField(ref _percentOwnershipInterest, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Purchase/Sale/Refinance Indicator [ABNN09]
        /// </summary>
        public bool? PurchaseSaleRefinanceIndicator { get => _purchaseSaleRefinanceIndicator; set => SetField(ref _purchaseSaleRefinanceIndicator, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 1 [ABNN22]
        /// </summary>
        public bool? RequiredUseIndicator1 { get => _requiredUseIndicator1; set => SetField(ref _requiredUseIndicator1, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 2 [ABNN23]
        /// </summary>
        public bool? RequiredUseIndicator2 { get => _requiredUseIndicator2; set => SetField(ref _requiredUseIndicator2, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 3 [ABNN24]
        /// </summary>
        public bool? RequiredUseIndicator3 { get => _requiredUseIndicator3; set => SetField(ref _requiredUseIndicator3, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 4 [ABNN25]
        /// </summary>
        public bool? RequiredUseIndicator4 { get => _requiredUseIndicator4; set => SetField(ref _requiredUseIndicator4, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 5 [ABNN26]
        /// </summary>
        public bool? RequiredUseIndicator5 { get => _requiredUseIndicator5; set => SetField(ref _requiredUseIndicator5, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Required Use Indicator Line 6 [ABNN27]
        /// </summary>
        public bool? RequiredUseIndicator6 { get => _requiredUseIndicator6; set => SetField(ref _requiredUseIndicator6, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 1 [ABNN10]
        /// </summary>
        public string? ServiceDescription1 { get => _serviceDescription1; set => SetField(ref _serviceDescription1, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 2 [ABNN11]
        /// </summary>
        public string? ServiceDescription2 { get => _serviceDescription2; set => SetField(ref _serviceDescription2, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 3 [ABNN12]
        /// </summary>
        public string? ServiceDescription3 { get => _serviceDescription3; set => SetField(ref _serviceDescription3, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 4 [ABNN13]
        /// </summary>
        public string? ServiceDescription4 { get => _serviceDescription4; set => SetField(ref _serviceDescription4, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 5 [ABNN14]
        /// </summary>
        public string? ServiceDescription5 { get => _serviceDescription5; set => SetField(ref _serviceDescription5, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Service Description Line 6 [ABNN15]
        /// </summary>
        public string? ServiceDescription6 { get => _serviceDescription6; set => SetField(ref _serviceDescription6, value); }

        /// <summary>
        /// Affiliated Business Arrangements - Settlement Indicator [ABNN08]
        /// </summary>
        public bool? SettlementIndicator { get => _settlementIndicator; set => SetField(ref _settlementIndicator, value); }
    }
}