
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class DownloadLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public string barcodePage { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string dateReceived { get; set; }
public DateTime? dateUtc { get; set; }
public string documentId { get; set; }
public string downloadId { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string fileSource { get; set; }
public string fileType { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string receivedBy { get; set; }
public string sender { get; set; }
public string systemId { get; set; }
public string title { get; set; }

    }
}