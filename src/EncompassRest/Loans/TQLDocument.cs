#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class TQLDocument : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _tQLDocumentDeliveredDate;
        public DateTime? TQLDocumentDeliveredDate { get => _tQLDocumentDeliveredDate; set => _tQLDocumentDeliveredDate = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _tQLDocumentDeliveredDate.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _tQLDocumentDeliveredDate.Dirty = value;
            }
        }
    }
}