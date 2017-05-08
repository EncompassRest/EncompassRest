
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class LockConfirmLog
{
public string id { get; set; }
public bool? alertIndicator { get; set; }
public List<LogAlert> alerts { get; set; }
public DateTime? buySideExpirationDate { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string confirmedBy { get; set; }
public bool? confirmedByIdIndicator { get; set; }
public DateTime? dateUtc { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string requestGuid { get; set; }
public string sellSideDeliveredBy { get; set; }
public DateTime? sellSideDeliveryDate { get; set; }
public DateTime? sellSideExpirationDate { get; set; }
public string systemId { get; set; }
public string timeConfirmed { get; set; }

    }
}