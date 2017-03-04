using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.LoanDocs
{
    public class Comment
    {
        public string comments { get; set; }
        public int forRoleId { get; set; }
        public string commentId { get; set; }
        public DateTime? dateCreated { get; set; }
        public string createdBy { get; set; }
        public string createdByName { get; set; }
        public DateTime? dateReviewed { get; set; }
        public string reviewedBy { get; set; }
    }
}
