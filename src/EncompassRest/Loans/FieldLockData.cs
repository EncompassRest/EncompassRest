using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FieldLockData
    {
        public string ModelPath { get; set; }
        public bool? LockRemoved { get; set; }
        public string Value { get; set; }
    }
}