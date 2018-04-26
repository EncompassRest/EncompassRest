using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// TQLDocument
    /// </summary>
    public sealed partial class TQLDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// TQLDocument Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _tQLDocumentDeliveredDate;
        /// <summary>
        /// TQL Documents Delivered to Investor [TQLDOCDATENN01]
        /// </summary>
        [LoanFieldProperty(Description = "TQL Documents Delivered to Investor")]
        public DateTime? TQLDocumentDeliveredDate { get => _tQLDocumentDeliveredDate; set => _tQLDocumentDeliveredDate = value; }
        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _tQLDocumentDeliveredDate.Dirty;
            set
            {
                _id.Dirty = value;
                _tQLDocumentDeliveredDate.Dirty = value;
            }
        }
    }
}