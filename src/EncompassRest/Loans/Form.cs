using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Form
    {
        public int? FormId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public JsonNullable<string> SystemId { get; set; }
    }
}