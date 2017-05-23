using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class FieldLockData
    {
        public JsonNullable<bool?> LockRemoved { get; set; }
        public string ModelPath { get; set; }
        public string Value { get; set; }
    }
}