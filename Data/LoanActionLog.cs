
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class LoanActionLog
{
public string id { get; set; }
public DateTime? dateUtc { get; set; }
public string loanActionType { get; set; }
public string triggeredBy { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }

    }
}