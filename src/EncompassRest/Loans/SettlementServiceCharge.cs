using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SettlementServiceCharge
    /// </summary>
    public sealed partial class SettlementServiceCharge : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _amount;
        /// <summary>
        /// SettlementServiceCharge Amount
        /// </summary>
        public string Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// SettlementServiceCharge Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// SettlementServiceCharge Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _description.Dirty
                || _id.Dirty;
            set
            {
                _amount.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}