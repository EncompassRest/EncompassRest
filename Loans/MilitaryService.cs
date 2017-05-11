using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class MilitaryService
    {
        public int? MilitaryServiceIndex { get; set; }
        public string SSN { get; set; }
        public string ServiceNumber { get; set; }
        public string Branch { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Name { get; set; }
        public string OfficerOrEnlisted { get; set; }
        public string Id { get; set; }
    }
}