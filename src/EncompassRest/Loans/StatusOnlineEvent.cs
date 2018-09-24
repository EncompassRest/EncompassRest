using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StatusOnlineEvent
    /// </summary>
    public sealed partial class StatusOnlineEvent : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _dateText;
        private DirtyValue<string> _description;
        private DirtyValue<string> _id;

        /// <summary>
        /// StatusOnlineEvent DateText
        /// </summary>
        public string DateText { get => _dateText; set => SetField(ref _dateText, value); }

        /// <summary>
        /// StatusOnlineEvent Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// StatusOnlineEvent Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}