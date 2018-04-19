using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PurchaseCredit
    /// </summary>
    public sealed partial class PurchaseCredit : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// PurchaseCredit Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PurchaseCredit Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<PurchaseCreditType>> _purchaseCreditType;
        /// <summary>
        /// PurchaseCredit PurchaseCreditType
        /// </summary>
        public StringEnumValue<PurchaseCreditType> PurchaseCreditType { get => _purchaseCreditType; set => _purchaseCreditType = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _id.Dirty
                || _purchaseCreditType.Dirty;
            set
            {
                _amount.Dirty = value;
                _id.Dirty = value;
                _purchaseCreditType.Dirty = value;
            }
        }
    }
}