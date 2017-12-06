#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Form : ExtensibleObject
    {
        private DirtyValue<int?> _formId;
        public int? FormId { get => _formId; set => _formId = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _systemId;
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _formId.Dirty
                    || _id.Dirty
                    || _name.Dirty
                    || _systemId.Dirty;
            }
            set
            {
                _formId.Dirty = value;
                _id.Dirty = value;
                _name.Dirty = value;
                _systemId.Dirty = value;
            }
        }
    }
}