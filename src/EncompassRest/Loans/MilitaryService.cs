using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class MilitaryService
    {
        public string Branch { get; set; }
        public JsonNullable<DateTime?> EndDate { get; set; }
        public string Id { get; set; }
        public int? MilitaryServiceIndex { get; set; }
        public string Name { get; set; }
        public string OfficerOrEnlisted { get; set; }
        public string ServiceNumber { get; set; }
        public string SSN { get; set; }
        public JsonNullable<DateTime?> StartDate { get; set; }
    }
}