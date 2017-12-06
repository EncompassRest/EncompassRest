#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureForm : ExtensibleObject
    {
        private DirtyValue<string> _formName;
        public string FormName { get => _formName; set => _formName = value; }
        private DirtyValue<string> _formType;
        public string FormType { get => _formType; set => _formType = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _formName.Dirty
                    || _formType.Dirty
                    || _id.Dirty;
            }
            set
            {
                _formName.Dirty = value;
                _formType.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}