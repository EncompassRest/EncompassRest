using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class AdditionalStateDisclosure
    {
        public string DisclosureName { get; set; }
        public string DisclosureValue { get; set; }
        public string Id { get; set; }
        public string StateCode { get; set; }
    }
}