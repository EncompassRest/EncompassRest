using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ComplianceTestLog
    /// </summary>
    public sealed partial class ComplianceTestLog : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _details;
        /// <summary>
        /// ComplianceTestLog Details
        /// </summary>
        public string Details { get => _details; set => _details = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// ComplianceTestLog Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<string> _result;
        /// <summary>
        /// ComplianceTestLog Result
        /// </summary>
        public string Result { get => _result; set => _result = value; }
        private DirtyValue<bool?> _showAlert;
        /// <summary>
        /// ComplianceTestLog ShowAlert
        /// </summary>
        public bool? ShowAlert { get => _showAlert; set => _showAlert = value; }
    }
}