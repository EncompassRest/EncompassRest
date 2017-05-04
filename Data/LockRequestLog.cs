
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class LockRequestLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public DateTime? buySideExpirationDate { get; set; }
public DateTime? buySideNewLockExtensionDate { get; set; }
public int? buySideNumDayExtended { get; set; }
public int? buySideNumDayLocked { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public DateTime? dateUtc { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? hideLogIndicator { get; set; }
public bool? isFakeRequestIndicator { get; set; }
public bool? isLockCancellationIndicator { get; set; }
public bool? isLockExtensionIndicator { get; set; }
public bool? isReLockIndicator { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public int? numDayLocked { get; set; }
public string parentLockGuid { get; set; }
public string requestedBy { get; set; }
public string requestedName { get; set; }
public string requestedStatus { get; set; }
public string sellSideDeliveredBy { get; set; }
public DateTime? sellSideDeliveryDate { get; set; }
public DateTime? sellSideExpirationDate { get; set; }
public DateTime? sellSideNewLockExtensionDate { get; set; }
public int? sellSideNumDayExtended { get; set; }
public string systemId { get; set; }
public string timeRequested { get; set; }
public string investorCommitment { get; set; }
public string snapshotXml { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}