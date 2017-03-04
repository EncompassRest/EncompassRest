using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Residence
    {
        public string applicantType { get; set; }
        public bool? mailingAddressIndicator { get; set; }
        public string addressStreetLine1 { get; set; }
        public string addressCity { get; set; }
        public string addressState { get; set; }
        public string addressPostalCode { get; set; }
        public string landlordName { get; set; }
        public string landlordAttention { get; set; }
        public string landlordStreet { get; set; }
        public string landlordCity { get; set; }
        public string landlordState { get; set; }
        public string landlordPostalCode { get; set; }
        public int? durationTermYears { get; set; }
        public string accountName { get; set; }
        public string residencyBasisType { get; set; }
        public int? rent { get; set; }
        public string landlordPhone { get; set; }
        public string landlordFax { get; set; }
        public string landlordEmail { get; set; }
        public string landlordComments { get; set; }
        public string county { get; set; }
        public string residencyType { get; set; }
        public int? durationTermMonths { get; set; }
        public bool? printAttachmentIndicator { get; set; }
        public string title { get; set; }
        public bool? printUserNameIndicator { get; set; }
        public string titlePhone { get; set; }
        public string titleFax { get; set; }
        public bool? noLinkToDocTrackIndicator { get; set; }
        public DateTime? requestDate { get; set; }
        public string altId { get; set; }
        public string id { get; set; }
        public bool? entityDeleted { get; set; }

    }
}
