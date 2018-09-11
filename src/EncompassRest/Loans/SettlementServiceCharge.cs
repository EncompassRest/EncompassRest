using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SettlementServiceCharge
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class SettlementServiceCharge : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _amount;
        /// <summary>
        /// SettlementServiceCharge Amount
        /// </summary>
        public string Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// SettlementServiceCharge Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// SettlementServiceCharge Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}