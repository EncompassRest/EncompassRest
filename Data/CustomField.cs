
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class CustomField
    {
        public string stringValue { get; set; }
        public string id { get; set; }
        public DateTime? dateValue { get; set; }
        public string fieldName { get; set; }
        public decimal? numericValue { get; set; }

    }
}