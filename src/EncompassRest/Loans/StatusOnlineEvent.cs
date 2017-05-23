using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class StatusOnlineEvent
    {
        public string DateText { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
    }
}