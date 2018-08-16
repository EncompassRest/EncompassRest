using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PurchaseAdvicePayout
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PurchaseAdvicePayout : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// PurchaseAdvicePayout Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// PurchaseAdvicePayout Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<decimal?> _diffAmount;
        /// <summary>
        /// PurchaseAdvicePayout DiffAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? DiffAmount { get => _diffAmount; set => SetField(ref _diffAmount, value); }
        private DirtyValue<decimal?> _expectedAmount;
        /// <summary>
        /// PurchaseAdvicePayout ExpectedAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ExpectedAmount { get => _expectedAmount; set => SetField(ref _expectedAmount, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PurchaseAdvicePayout Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}