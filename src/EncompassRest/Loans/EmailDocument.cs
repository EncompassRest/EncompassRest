using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EmailDocument
    /// </summary>
    public sealed partial class EmailDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _docId;
        /// <summary>
        /// EmailDocument DocId
        /// </summary>
        public string DocId { get => _docId; set => SetField(ref _docId, value); }
        private DirtyValue<string> _docTitle;
        /// <summary>
        /// EmailDocument DocTitle
        /// </summary>
        public string DocTitle { get => _docTitle; set => SetField(ref _docTitle, value); }
    }
}