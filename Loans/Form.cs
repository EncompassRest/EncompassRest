using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Form
    {
        public string Id { get; set; }
        public int? FormId { get; set; }
        public string Name { get; set; }
        public string SystemId { get; set; }
    }
}