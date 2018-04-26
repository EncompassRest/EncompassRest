using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StatusOnlineEvent
    /// </summary>
    public sealed partial class StatusOnlineEvent : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _dateText;
        /// <summary>
        /// StatusOnlineEvent DateText
        /// </summary>
        public string DateText { get => _dateText; set => _dateText = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// StatusOnlineEvent Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// StatusOnlineEvent Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get => _dateText.Dirty
                || _description.Dirty
                || _id.Dirty;
            set
            {
                _dateText.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}