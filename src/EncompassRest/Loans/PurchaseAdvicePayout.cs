using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PurchaseAdvicePayout
    /// </summary>
    public sealed partial class PurchaseAdvicePayout : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// PurchaseAdvicePayout Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// PurchaseAdvicePayout Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<decimal?> _diffAmount;
        /// <summary>
        /// PurchaseAdvicePayout DiffAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DiffAmount { get => _diffAmount; set => _diffAmount = value; }
        private DirtyValue<decimal?> _expectedAmount;
        /// <summary>
        /// PurchaseAdvicePayout ExpectedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExpectedAmount { get => _expectedAmount; set => _expectedAmount = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// PurchaseAdvicePayout Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _description.Dirty
                || _diffAmount.Dirty
                || _expectedAmount.Dirty
                || _id.Dirty;
            set
            {
                _amount.Dirty = value;
                _description.Dirty = value;
                _diffAmount.Dirty = value;
                _expectedAmount.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}