
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class ConversationLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string company { get; set; }
public DateTime? dateUtc { get; set; }
public string email { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? inLogIndicator { get; set; }
public bool? isEmailIndicator { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string name { get; set; }
public string phone { get; set; }
public string systemId { get; set; }
public string userId { get; set; }

    }
}