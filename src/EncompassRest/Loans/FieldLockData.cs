using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FieldLockData
    /// </summary>
    public sealed partial class FieldLockData : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _lockRemoved;
        /// <summary>
        /// FieldLockData LockRemoved
        /// </summary>
        public bool? LockRemoved { get => _lockRemoved; set => _lockRemoved = value; }
        private DirtyValue<string> _value;
        /// <summary>
        /// FieldLockData Value
        /// </summary>
        public string Value { get => _value; set => _value = value; }
    }
}