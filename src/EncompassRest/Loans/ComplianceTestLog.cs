using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ComplianceTestLog
    {
        public string Name { get; set; }
        public string Result { get; set; }
        public string Details { get; set; }
        public bool? ShowAlert { get; set; }
    }
}