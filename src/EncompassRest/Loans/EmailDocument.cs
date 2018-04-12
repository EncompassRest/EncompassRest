#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EmailDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _docId;
        public string DocId { get => _docId; set => _docId = value; }
        private DirtyValue<string> _docTitle;
        public string DocTitle { get => _docTitle; set => _docTitle = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _docId.Dirty
                    || _docTitle.Dirty;
            }
            set
            {
                _docId.Dirty = value;
                _docTitle.Dirty = value;
            }
        }
    }
}