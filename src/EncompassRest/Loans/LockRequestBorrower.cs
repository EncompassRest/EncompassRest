using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class LockRequestBorrower
    {
        public string EquifaxScore { get; set; }
        public string ExperianScore { get; set; }
        public string FirstName { get; set; }
        public string Id { get; set; }
        public bool? IsEmpty { get; set; }
        public string LastName { get; set; }
        public int? LrbIndex { get; set; }
        public string SSN { get; set; }
        public string TransUnionScore { get; set; }
    }
}