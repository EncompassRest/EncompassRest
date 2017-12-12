#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class LogSnapshotField : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _fieldID;
        public string FieldID { get => _fieldID; set => _fieldID = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _modalPath;
        public string ModalPath { get => _modalPath; set => _modalPath = value; }
        private DirtyValue<string> _value;
        public string Value { get => _value; set => _value = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _fieldID.Dirty
                    || _id.Dirty
                    || _modalPath.Dirty
                    || _value.Dirty;
            }
            set
            {
                _fieldID.Dirty = value;
                _id.Dirty = value;
                _modalPath.Dirty = value;
                _value.Dirty = value;
            }
        }
    }
}