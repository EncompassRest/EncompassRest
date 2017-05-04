
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class PreliminaryConditionLog
{
public string id { get; set; }
public string addedBy { get; set; }
public List<LogAlert> alerts { get; set; }
public string category { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public DateTime? dateAddedUtc { get; set; }
public DateTime? dateFulfilled { get; set; }
public DateTime? dateUtc { get; set; }
public string description { get; set; }
public string details { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string fulfilledBy { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string pairId { get; set; }
public string priorTo { get; set; }
public string source { get; set; }
public string systemId { get; set; }
public string title { get; set; }
public bool? underwriterAccessIndicator { get; set; }
public bool? fulfilled { get; set; }
public string status { get; set; }
public string statusDescription { get; set; }
public bool? expected { get; set; }
public DateTime? dateExpected { get; set; }
public DateTime? dateRequestedUtc { get; set; }
public string requestedBy { get; set; }
public DateTime? dateRerequestedUtc { get; set; }
public string rerequestedBy { get; set; }
public DateTime? dateReceived { get; set; }
public string receivedBy { get; set; }
public bool? received { get; set; }
public bool? requested { get; set; }
public bool? rerequested { get; set; }
public bool? isPastDue { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}