
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class DocumentLog
{
public string id { get; set; }
public string accessedBy { get; set; }
public DateTime? accessedDateUtc { get; set; }
public string addedBy { get; set; }
public List<LogAlert> alerts { get; set; }
public List<EntityReference> allowedRoles { get; set; }
public DateTime? archiveDateUtc { get; set; }
public string archivedBy { get; set; }
public bool? closingDocumentIndicator { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string company { get; set; }
public List<EntityReference> conditions { get; set; }
public DateTime? dateAddedUtc { get; set; }
public DateTime? dateUtc { get; set; }
public int? daysDue { get; set; }
public int? daysTillExpire { get; set; }
public bool? eDisclosureIndicator { get; set; }
public string ePassSignature { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public List<FileAttachmentReference> fileAttachmentReferences { get; set; }
public string guid { get; set; }
public bool? isEPassIndicator { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public bool? isThirdPartyDocIndicator { get; set; }
public bool? isTPOWebcenterPortalIndicator { get; set; }
public bool? isWebCenterIndicator { get; set; }
public int? logRecordIndex { get; set; }
public DateTime? orderDateUtc { get; set; }
public string pairId { get; set; }
public DateTime? receiveDateUtc { get; set; }
public string receivedBy { get; set; }
public DateTime? reorderDateUtc { get; set; }
public string requestedBy { get; set; }
public string rerequestedBy { get; set; }
public string reviewedBy { get; set; }
public DateTime? reviewedDateUtc { get; set; }
public string shippingReadyBy { get; set; }
public DateTime? shippingReadyDateUtc { get; set; }
public string stage { get; set; }
public string systemId { get; set; }
public string title { get; set; }
public string underwritingReadyBy { get; set; }
public DateTime? underwritingReadyDateUtc { get; set; }
public string documentDateTimeType { get; set; }
public bool? preClosingDocumentIndicator { get; set; }
public string requestedFrom { get; set; }
public bool? requested { get; set; }
public DateTime? dateRequested { get; set; }
public bool? rerequested { get; set; }
public DateTime? dateRerequested { get; set; }
public bool? received { get; set; }
public DateTime? dateReceived { get; set; }
public DateTime? dateExpected { get; set; }
public DateTime? dateExpires { get; set; }
public bool? expires { get; set; }
public bool? isExpired { get; set; }
public bool? shippingReady { get; set; }
public bool? underwritingReady { get; set; }
public bool? reviewed { get; set; }
public bool? expected { get; set; }
public bool? isPastDue { get; set; }
public string status { get; set; }
public string conditionsXml { get; set; }
public string allowedRolesXml { get; set; }
public string allowedRoleDelimitedList { get; set; }
public string fileAttachmentsXml { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}