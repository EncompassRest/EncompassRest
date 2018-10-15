using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ExportLogServiceType
    /// </summary>
    public sealed partial class ExportLogServiceType : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _name;

        /// <summary>
        /// ExportLogServiceType Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ExportLogServiceType Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
    }
}