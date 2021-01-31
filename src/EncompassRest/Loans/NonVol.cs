using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NonVol
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class NonVol : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _adjustmentAmount;
        private DirtyValue<string?>? _adjustmentDescription;
        private DirtyValue<string?>? _adjustmentOtherDescription;
        private DirtyValue<StringEnumValue<NonVolAdjustmentType>>? _adjustmentType;
        private DirtyValue<string?>? _id;
        private DirtyValue<bool?>? _includedIndicator;
        private DirtyValue<string?>? _nonVolId;
        private DirtyValue<int?>? _nonVolIndex;
        private DirtyValue<StringEnumValue<PaidToOrBy>>? _paidBy;
        private DirtyValue<StringEnumValue<PaidToOrBy>>? _paidTo;
        private DirtyValue<bool?>? _pOCIndicator;
        private DirtyValue<string?>? _principalCureAddendum;

        /// <summary>
        /// Adjustment Amount [UNFLNN04]
        /// </summary>
        public decimal? AdjustmentAmount { get => _adjustmentAmount; set => SetField(ref _adjustmentAmount, value); }

        /// <summary>
        /// Adjustment Description [UNFLNN02]
        /// </summary>
        public string? AdjustmentDescription { get => _adjustmentDescription; set => SetField(ref _adjustmentDescription, value); }

        /// <summary>
        /// Adjustment Other Description [UNFLNN03]
        /// </summary>
        public string? AdjustmentOtherDescription { get => _adjustmentOtherDescription; set => SetField(ref _adjustmentOtherDescription, value); }

        /// <summary>
        /// UCD Adjustment Type [UNFLNN01]
        /// </summary>
        public StringEnumValue<NonVolAdjustmentType> AdjustmentType { get => _adjustmentType; set => SetField(ref _adjustmentType, value); }

        /// <summary>
        /// NonVol Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Liability Will be Paid Off and will be included [UNFLNN05]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Paid off (*) will be included\"}")]
        public bool? IncludedIndicator { get => _includedIndicator; set => SetField(ref _includedIndicator, value); }

        /// <summary>
        /// NonVol NonVolId
        /// </summary>
        public string? NonVolId { get => _nonVolId; set => SetField(ref _nonVolId, value); }

        /// <summary>
        /// NonVol NonVolIndex
        /// </summary>
        public int? NonVolIndex { get => _nonVolIndex; set => SetField(ref _nonVolIndex, value); }

        /// <summary>
        /// Paid By [UNFLNN07]
        /// </summary>
        public StringEnumValue<PaidToOrBy> PaidBy { get => _paidBy; set => SetField(ref _paidBy, value); }

        /// <summary>
        /// Paid To [UNFLNN09]
        /// </summary>
        public StringEnumValue<PaidToOrBy> PaidTo { get => _paidTo; set => SetField(ref _paidTo, value); }

        /// <summary>
        /// POC Indicator [UNFLNN06]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Paid off (*) will be included\"}")]
        public bool? POCIndicator { get => _pOCIndicator; set => SetField(ref _pOCIndicator, value); }

        /// <summary>
        /// PrincipalCureAddendum Amount [UNFLNN08]
        /// </summary>
        public string? PrincipalCureAddendum { get => _principalCureAddendum; set => SetField(ref _principalCureAddendum, value); }
    }
}