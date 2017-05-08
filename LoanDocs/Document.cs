using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.LoanDocs
{
    public class Document
    {
        public string documentId { get; set; }
        public string titleWithIndex { get; set; }
        public string applicationName { get; set; }
        public string milestoneId { get; set; }
        public bool? webCenterAllowed { get; set; }
        public bool? tpoAllowed { get; set; }
        public bool? thirdPartyAllowed { get; set; }
        public bool? isRequested { get; set; }
        public string requestedBy { get; set; }
        public int? daysDue { get; set; }
        public bool? isRecieved { get; set; }
        public string recievedBy { get; set; }
        public int? daysTillExpire { get; set; }
        public bool? isReviewed { get; set; }
        public string reviewedBy { get; set; }
        public bool? isReadyForUw { get; set; }
        public string readyForUwBy { get; set; }
        public bool? isReadyToShip { get; set; }
        public string readyToShipBy { get; set; }
        public DateTime? dateExpires { get; set; }
        public string creadedBy { get; set; }
        public DateTime? dateCreated { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string requestedFrom { get; set; }
        public string applicationId { get; set; }
        public string emnSignature { get; set; }
        public string status { get; set; }
        public DateTime? statusDate { get; set; }
        public DateTime? dateRequested { get; set; }
        public DateTime? dateRecieved { get; set; }
        public DateTime? dateReviewed { get; set; }
        public DateTime? dateReadyForUw { get; set; }
        public DateTime? dateReadyToShip { get; set; }
        public List<Comment> comments { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<Role> roles { get; set; }

        public Document()
        {
            comments = new List<Comment>();
            attachments = new List<LoanDocs.Attachment>();
            roles = new List<Role>();
        }

    }
}
