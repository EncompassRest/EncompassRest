#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Hud1EsItemize : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _date;
        public string Date { get => _date; set => _date = value; }
        private DirtyValue<decimal?> _escrowPaymentBalance;
        public decimal? EscrowPaymentBalance { get => _escrowPaymentBalance; set => _escrowPaymentBalance = value; }
        private DirtyValue<string> _escrowPaymentDescription;
        public string EscrowPaymentDescription { get => _escrowPaymentDescription; set => _escrowPaymentDescription = value; }
        private DirtyValue<decimal?> _escrowPaymentFrom;
        public decimal? EscrowPaymentFrom { get => _escrowPaymentFrom; set => _escrowPaymentFrom = value; }
        private DirtyValue<decimal?> _escrowPaymentTo;
        public decimal? EscrowPaymentTo { get => _escrowPaymentTo; set => _escrowPaymentTo = value; }
        private DirtyValue<int?> _hud1EsItemizeIndex;
        public int? Hud1EsItemizeIndex { get => _hud1EsItemizeIndex; set => _hud1EsItemizeIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _date.Dirty
                    || _escrowPaymentBalance.Dirty
                    || _escrowPaymentDescription.Dirty
                    || _escrowPaymentFrom.Dirty
                    || _escrowPaymentTo.Dirty
                    || _hud1EsItemizeIndex.Dirty
                    || _id.Dirty;
            }
            set
            {
                _date.Dirty = value;
                _escrowPaymentBalance.Dirty = value;
                _escrowPaymentDescription.Dirty = value;
                _escrowPaymentFrom.Dirty = value;
                _escrowPaymentTo.Dirty = value;
                _hud1EsItemizeIndex.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}