using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrintForm
    /// </summary>
    public sealed partial class PrintForm : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        private DirtyValue<string> _name;

        /// <summary>
        /// PrintForm Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PrintForm Name
        /// </summary>
        public string Name { get => _name; set => SetField(ref _name, value); }
    }
}