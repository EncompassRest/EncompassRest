
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class MilestoneLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public DateTime? dateUtc { get; set; }
public int? days { get; set; }
public bool? doneIndicator { get; set; }
public int? duration { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public LoanAssociate loanAssociate { get; set; }
public int? logRecordIndex { get; set; }
public string milestoneIdString { get; set; }
public bool? reviewedIndicator { get; set; }
public string roleRequired { get; set; }
public string stage { get; set; }
public string systemId { get; set; }

    }
}