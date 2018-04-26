using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrintForm
    /// </summary>
    public sealed partial class PrintForm : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// PrintForm Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// PrintForm Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        internal override bool DirtyInternal
        {
            get => _id.Dirty
                || _name.Dirty;
            set
            {
                _id.Dirty = value;
                _name.Dirty = value;
            }
        }
    }
}