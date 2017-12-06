#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class EdmDocument : ExtensibleObject
    {
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _title;
        public string Title { get => _title; set => _title = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _id.Dirty
                    || _title.Dirty;
            }
            set
            {
                _id.Dirty = value;
                _title.Dirty = value;
            }
        }
    }
}