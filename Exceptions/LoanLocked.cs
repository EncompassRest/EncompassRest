using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Exceptions
{
    public class LoanLocked
    {
        public string ErrorMessage { get; set; }
        public string Id { get; set; }
        public string InnerErrorMessage { get; set; }
        public LoanLockedDetails Details { get; set; }
    }

    public class LoanLockedDetails
    {
        public bool CurrentlyLoggedOn { get; set; }
        public string LoanId { get; set; }
        public string LockedByFirstName { get; set; }
        public string LockedByLastName { get; set; }
        public string LockedBySessionId { get; set; }
        public string LockedByUserId { get; set; }
        public DateTime LockedSince { get; set; }
    }
}
