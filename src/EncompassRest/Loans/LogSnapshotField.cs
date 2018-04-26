using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LogSnapshotField
    /// </summary>
    public sealed partial class LogSnapshotField : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _fieldID;
        /// <summary>
        /// LogSnapshotField FieldID
        /// </summary>
        public string FieldID { get => _fieldID; set => _fieldID = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LogSnapshotField Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _modalPath;
        /// <summary>
        /// LogSnapshotField ModalPath
        /// </summary>
        public string ModalPath { get => _modalPath; set => _modalPath = value; }
        private DirtyValue<string> _value;
        /// <summary>
        /// LogSnapshotField Value
        /// </summary>
        public string Value { get => _value; set => _value = value; }
        internal override bool DirtyInternal
        {
            get => _fieldID.Dirty
                || _id.Dirty
                || _modalPath.Dirty
                || _value.Dirty;
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