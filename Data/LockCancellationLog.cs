
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class LockCancellationLog
{
public string id { get; set; }
public bool? alertIndicator { get; set; }
public string cancelledBy { get; set; }
public string cancelledById { get; set; }
public string comments { get; set; }
public DateTime? dateUtc { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string requestGuid { get; set; }
public string systemId { get; set; }
public string timeCancelled { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}