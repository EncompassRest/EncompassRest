using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class LogSnapshotField
    {
        public string Id { get; set; }
        public string FieldID { get; set; }
        public string ModalPath { get; set; }
        public string Value { get; set; }
    }
}