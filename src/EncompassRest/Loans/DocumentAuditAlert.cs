#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DocumentAuditAlert : ExtensibleObject, IIdentifiable
    {
        private DirtyList<string> _fields;
        public IList<string> Fields { get => _fields ?? (_fields = new DirtyList<string>()); set => _fields = new DirtyList<string>(value); }
        private DirtyValue<string> _source;
        public string Source { get => _source; set => _source = value; }
        private DirtyValue<string> _text;
        public string Text { get => _text; set => _text = value; }
        private DirtyValue<string> _type;
        public string Type { get => _type; set => _type = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _source.Dirty
                    || _text.Dirty
                    || _type.Dirty
                    || _fields?.Dirty == true;
            }
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