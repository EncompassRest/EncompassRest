using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class PrintForm : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        public string Name { get => _name; set => _name = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _name.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _name.Dirty = value;
            }
        }
    }
}