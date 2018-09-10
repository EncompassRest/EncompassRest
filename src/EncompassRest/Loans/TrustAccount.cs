using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TrustAccount
    /// </summary>
    public sealed partial class TrustAccount : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _balance;
        /// <summary>
        /// Trust Acct Balance [TABALANCE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Balance")]
        public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// TrustAccount Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _total1;
        /// <summary>
        /// Trust Acct Pymts Total [TATOTAL1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Pymts Total")]
        public decimal? Total1 { get => _total1; set => SetField(ref _total1, value); }
        private DirtyValue<decimal?> _total2;
        /// <summary>
        /// Trust Acct Receipts Total [TATOTAL2]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trust Acct Receipts Total")]
        public decimal? Total2 { get => _total2; set => SetField(ref _total2, value); }
        private DirtyList<TrustAccountItem> _trustAccountItems;
        /// <summary>
        /// TrustAccount TrustAccountItems
        /// </summary>
        public IList<TrustAccountItem> TrustAccountItems { get => GetField(ref _trustAccountItems); set => SetField(ref _trustAccountItems, value); }
    }
}