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
        private DirtyValue<string> _id;
        private DirtyValue<string> _name;
        private DirtyValue<string> _systemId;

        /// <summary>
        /// Form FormId
        /// </summary>
        public int? FormId { get => _formId; set => SetField(ref _formId, value); }

        /// <summary>
        /// Form Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Form Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }

        /// <summary>
        /// Form SystemId
        /// </summary>
        public string SystemId { get => _systemId; set => SetField(ref _systemId, value); }
    }
}