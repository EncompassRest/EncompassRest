using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class AdditionalStateDisclosure
    {
        public string StateCode { get; set; }
        public string DisclosureName { get; set; }
        public string DisclosureValue { get; set; }
        public string Id { get; set; }
    }
}