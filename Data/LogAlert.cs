
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class LogAlert
{
public string id { get; set; }
public DateTime? dueDate { get; set; }
public DateTime? followedUpDate { get; set; }
public LogRecord logRecord { get; set; }
public int? roleId { get; set; }
public string systemId { get; set; }
public string userId { get; set; }

    }
}