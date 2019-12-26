using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsItemize
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Hud1EsItemize : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string?>? _date;
        private DirtyValue<decimal?>? _escrowPaymentBalance;
        private DirtyValue<string?>? _escrowPaymentDescription;
        private DirtyValue<decimal?>? _escrowPaymentFrom;
        private DirtyValue<decimal?>? _escrowPaymentTo;
        private DirtyValue<int?>? _hud1EsItemizeIndex;
        private DirtyValue<string?>? _id;

        /// <summary>
        /// Itemize Escrow Payment Date [AEANN01]
        /// </summary>
        public string? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// Itemize Escrow Payment Balance [AEANN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EscrowPaymentBalance { get => _escrowPaymentBalance; set => SetField(ref _escrowPaymentBalance, value); }

        /// <summary>
        /// Itemize Escrow Payment Description [AEANN04]
        /// </summary>
        public string? EscrowPaymentDescription { get => _escrowPaymentDescription; set => SetField(ref _escrowPaymentDescription, value); }

        /// <summary>
        /// Itemize Escrow Payment From [AEANN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EscrowPaymentFrom { get => _escrowPaymentFrom; set => SetField(ref _escrowPaymentFrom, value); }

        /// <summary>
        /// Itemize Escrow Payment To [AEANN02]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? EscrowPaymentTo { get => _escrowPaymentTo; set => SetField(ref _escrowPaymentTo, value); }

        /// <summary>
        /// Hud1EsItemize Hud1EsItemizeIndex
        /// </summary>
        public int? Hud1EsItemizeIndex { get => _hud1EsItemizeIndex; set => SetField(ref _hud1EsItemizeIndex, value); }

        /// <summary>
        /// Hud1EsItemize Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }
    }
}