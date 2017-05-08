
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class SelfEmployedIncome
    {
        public string formType { get; set; }
        public string fieldName { get; set; }
        public bool? boolFieldValue { get; set; }
        public decimal? firstYearAmount { get; set; }
        public decimal? fieldValue { get; set; }
        public decimal? secondYearAmount { get; set; }
        public string businessName { get; set; }
        public string id { get; set; }

    }
}