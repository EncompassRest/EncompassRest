
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class DataTracLog
{
public string id { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string creator { get; set; }
public DateTime? dateUtc { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string fileId { get; set; }
public string guid { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string message { get; set; }
public string systemId { get; set; }

    }
}