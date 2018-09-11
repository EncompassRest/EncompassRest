using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Form
    /// </summary>
    public sealed partial class Form : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _formId;
        /// <summary>
        /// Form FormId
        /// </summary>
        public int? FormId { get => _formId; set => SetField(ref _formId, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Form Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _name;
        /// <summary>
        /// Form Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
        private DirtyValue<string> _systemId;
        /// <summary>
        /// Form SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}