
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Employment
    {
        public string employerName { get; set; }
        public string attention { get; set; }
        public string addressStreetLine1 { get; set; }
        public string addressCity { get; set; }
        public string addressState { get; set; }
        public string addressPostalCode { get; set; }
        public string owner { get; set; }
        public bool? currentEmploymentIndicator { get; set; }
        public string positionDescription { get; set; }
        public DateTime? startDate { get; set; }
        public int? monthlyIncomeAmount { get; set; }
        public int? timeOnJobTermYears { get; set; }
        public DateTime? endDate { get; set; }
        public bool? selfEmployedIndicator { get; set; }
        public int? timeInLineOfWorkYears { get; set; }
        public string phoneNumber { get; set; }
        public decimal? basePayAmount { get; set; }
        public decimal? overtimeAmount { get; set; }
        public decimal? bonusAmount { get; set; }
        public decimal? commissionsAmount { get; set; }
        public decimal? otherAmount { get; set; }
        public decimal? businessOwnedPercent { get; set; }
        public string businessPhone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string employerComments { get; set; }
        public string businessName { get; set; }
        public int? timeOnJobTermMonths { get; set; }
        public bool? printAttachmentIndicator { get; set; }
        public string title { get; set; }
        public bool? printUserNameIndicator { get; set; }
        public string badgeOrEmployeeID { get; set; }
        public string titlePhone { get; set; }
        public string titleFax { get; set; }
        public bool? noLinkToDocTrackIndicator { get; set; }
        public DateTime? verificationRequestDate { get; set; }
        public string altId { get; set; }
        public string id { get; set; }
        public bool? entityDeleted { get; set; }
        public int? timeInLineOfWorkMonths { get; set; }

    }
}