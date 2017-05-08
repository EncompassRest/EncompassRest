
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class MilestoneTaskLog
{
public string id { get; set; }
public string addedBy { get; set; }
public string addedByUserId { get; set; }
public List<LogAlert> alerts { get; set; }
public List<LogComment> commentList { get; set; }
public string comments { get; set; }
public string completedBy { get; set; }
public string completedByUserId { get; set; }
public DateTime? completedDateUtc { get; set; }
public List<MilestoneTaskContact> contacts { get; set; }
public DateTime? dateUtc { get; set; }
public int? daysToComplete { get; set; }
public int? daysToCompleteFromSetting { get; set; }
public bool? fileAttachmentsMigrated { get; set; }
public string guid { get; set; }
public bool? isRequiredIndicator { get; set; }
public bool? isSystemSpecificIndicator { get; set; }
public int? logRecordIndex { get; set; }
public string priority { get; set; }
public string stage { get; set; }
public string systemId { get; set; }
public string taskDescription { get; set; }
public string taskGuid { get; set; }
public string taskName { get; set; }
public bool? completed { get; set; }
public int? contactCount { get; set; }
public DateTime? expectedDate { get; set; }
public DateTime? addDate { get; set; }
public DateTime? milestoneTaskLogDateUtc { get; set; }
public string contactsXml { get; set; }
public string alertsXml { get; set; }
public string commentListXml { get; set; }

    }
}