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
        public IList<string> Fields { get => _fields ?? (_fields = new DirtyList<string>()); set => _fields = new DirtyList<string>(value); }
        private DirtyValue<string> _source;
        /// <summary>
        /// DocumentAuditAlert Source
        /// </summary>
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<string> _text;
        /// <summary>
        /// DocumentAuditAlert Text
        /// </summary>
        public string Text { get => _text; set => _text = value; }
        private DirtyValue<string> _type;
        /// <summary>
        /// DocumentAuditAlert Type
        /// </summary>
        public string Type { get => _type; set => _type = value; }
        internal override bool DirtyInternal
        {
            get => _source.Dirty
                || _text.Dirty
                || _type.Dirty
                || _fields?.Dirty == true;
            set
            {
                _source.Dirty = value;
                _text.Dirty = value;
                _type.Dirty = value;
                if (_fields != null) _fields.Dirty = value;
            }
        }
    }
}