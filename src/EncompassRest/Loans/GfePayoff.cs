#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class GfePayoff : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _description;
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfePayoffIndex;
        public int? GfePayoffIndex { get => _gfePayoffIndex; set => _gfePayoffIndex = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _amount.Dirty
                    || _description.Dirty
                    || _gfePayoffIndex.Dirty
                    || _id.Dirty;
            }
            set
            {
                _amount.Dirty = value;
                _description.Dirty = value;
                _gfePayoffIndex.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}