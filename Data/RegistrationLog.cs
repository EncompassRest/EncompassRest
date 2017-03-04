
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class RegistrationLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public bool? currentIndicator { get; set; }
public DateTime? dateUtc { get; set; }
public DateTime? expiredDate { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public string investorName { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string reference { get; set; }
public string registeredById { get; set; }
public string registeredByName { get; set; }
public DateTime? registeredDate { get; set; }
public string systemId { get; set; }

    }
}