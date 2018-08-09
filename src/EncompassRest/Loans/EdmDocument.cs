using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// EdmDocument
    /// </summary>
    public sealed partial class EdmDocument : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// EdmDocument Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<string> _title;
        /// <summary>
        /// EdmDocument Title
        /// </summary>
        public string Title { get => _title; set => _title = value; }
    }
}