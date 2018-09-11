using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DocumentAuditAlert
    /// </summary>
    public sealed partial class DocumentAuditAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyList<string> _fields;
        /// <summary>
        /// DocumentAuditAlert Fields
        /// </summary>
        public IList<string> Fields { get => GetField(ref _fields); set => SetField(ref _fields, value); }
        private DirtyValue<string> _source;
        /// <summary>
        /// DocumentAuditAlert Source
        /// </summary>
        public string Source { get => _source; set => SetField(ref _source, value); }
        private DirtyValue<string> _text;
        /// <summary>
        /// DocumentAuditAlert Text
        /// </summary>
        public string Text { get => _text; set => SetField(ref _text, value); }
        private DirtyValue<string> _type;
        /// <summary>
        /// DocumentAuditAlert Type
        /// </summary>
        public string Type { get => _type; set => SetField(ref _type, value); }
    }
}