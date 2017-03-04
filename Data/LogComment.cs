
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class LogComment
{
public string id { get; set; }
public string addedBy { get; set; }
public string addedByName { get; set; }
public string comments { get; set; }
public DateTime? date { get; set; }
public int? forRoleId { get; set; }
public string guid { get; set; }
public bool? isInternal { get; set; }
public string reviewedBy { get; set; }
public DateTime? reviewedDate { get; set; }

    }
}