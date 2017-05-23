using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ComplianceTestLog
    {
        public string Details { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public JsonNullable<bool?> ShowAlert { get; set; }
    }
}