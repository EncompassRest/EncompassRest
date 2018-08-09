using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureForm
    /// </summary>
    public sealed partial class DisclosureForm : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _formName;
        /// <summary>
        /// DisclosureForm FormName
        /// </summary>
        public string FormName { get => _formName; set => _formName = value; }
        private DirtyValue<string> _formType;
        /// <summary>
        /// DisclosureForm FormType
        /// </summary>
        public string FormType { get => _formType; set => _formType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureForm Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
    }
}