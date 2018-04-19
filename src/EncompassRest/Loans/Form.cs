using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Form
    /// </summary>
    public sealed partial class Form : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _formId;
        /// <summary>
        /// Form FormId
        /// </summary>
        public int? FormId { get => _formId; set => _formId = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Form Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// Form Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// Form SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => _systemId = value; }
        internal override bool DirtyInternal
        {
            get => _formId.Dirty
                || _id.Dirty
                || _name.Dirty
                || _systemId.Dirty;
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