#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TrustAccount : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _total1;
        public decimal? Total1 { get => _total1; set => _total1 = value; }
        private DirtyValue<decimal?> _total2;
        public decimal? Total2 { get => _total2; set => _total2 = value; }
        private DirtyList<TrustAccountItem> _trustAccountItems;
        public IList<TrustAccountItem> TrustAccountItems { get => _trustAccountItems ?? (_trustAccountItems = new DirtyList<TrustAccountItem>()); set => _trustAccountItems = new DirtyList<TrustAccountItem>(value); }
        internal override bool DirtyInternal
        {
            get
            {
                return _balance.Dirty
                    || _id.Dirty
                    || _total1.Dirty
                    || _total2.Dirty
                    || _trustAccountItems?.Dirty == true;
            }
            set
            {
                _balance.Dirty = value;
                _id.Dirty = value;
                _total1.Dirty = value;
                _total2.Dirty = value;
                if (_trustAccountItems != null) _trustAccountItems.Dirty = value;
            }
        }
    }
}