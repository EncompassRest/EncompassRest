using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsItemize
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class Hud1EsItemize : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _date;
        /// <summary>
        /// Itemize Escrow Payment Date [AEANN01]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Payment Date")]
        public string Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<decimal?> _escrowPaymentBalance;
        /// <summary>
        /// Itemize Escrow Payment Balance [AEANN05]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Itemize Escrow Payment Balance")]
        public decimal? EscrowPaymentBalance { get => _escrowPaymentBalance; set => SetField(ref _escrowPaymentBalance, value); }
        private DirtyValue<string> _escrowPaymentDescription;
        /// <summary>
        /// Itemize Escrow Payment Description [AEANN04]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Escrow Payment Description")]
        public string EscrowPaymentDescription { get => _escrowPaymentDescription; set => SetField(ref _escrowPaymentDescription, value); }
        private DirtyValue<decimal?> _escrowPaymentFrom;
        /// <summary>
        /// Itemize Escrow Payment From [AEANN03]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Itemize Escrow Payment From")]
        public decimal? EscrowPaymentFrom { get => _escrowPaymentFrom; set => SetField(ref _escrowPaymentFrom, value); }
        private DirtyValue<decimal?> _escrowPaymentTo;
        /// <summary>
        /// Itemize Escrow Payment To [AEANN02]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Itemize Escrow Payment To")]
        public decimal? EscrowPaymentTo { get => _escrowPaymentTo; set => SetField(ref _escrowPaymentTo, value); }
        private DirtyValue<int?> _hud1EsItemizeIndex;
        /// <summary>
        /// Hud1EsItemize Hud1EsItemizeIndex
        /// </summary>
        public int? Hud1EsItemizeIndex { get => _hud1EsItemizeIndex; set => SetField(ref _hud1EsItemizeIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1EsItemize Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}