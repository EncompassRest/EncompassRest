using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TrustAccount
    /// </summary>
    public sealed partial class TrustAccount : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _balance;
        /// <summary>
        /// Trust Acct Balance [TABALANCE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Balance")]
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// TrustAccount Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _total1;
        /// <summary>
        /// Trust Acct Pymts Total [TATOTAL1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Pymts Total")]
        public decimal? Total1 { get => _total1; set => _total1 = value; }
        private DirtyValue<decimal?> _total2;
        /// <summary>
        /// Trust Acct Receipts Total [TATOTAL2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Receipts Total")]
        public decimal? Total2 { get => _total2; set => _total2 = value; }
        private DirtyList<TrustAccountItem> _trustAccountItems;
        /// <summary>
        /// TrustAccount TrustAccountItems
        /// </summary>
        public IList<TrustAccountItem> TrustAccountItems { get => _trustAccountItems ?? (_trustAccountItems = new DirtyList<TrustAccountItem>()); set => _trustAccountItems = new DirtyList<TrustAccountItem>(value); }
        internal override bool DirtyInternal
        {
            get => _balance.Dirty
                || _id.Dirty
                || _total1.Dirty
                || _total2.Dirty
                || _trustAccountItems?.Dirty == true;
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