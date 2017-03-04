
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Hud1EsDueDate
    {
        public DateTime? taxDisb { get; set; }
        public DateTime? hazInsDisb { get; set; }
        public DateTime? mtgInsDisb { get; set; }
        public DateTime? floodInsDisb { get; set; }
        public DateTime? schoolTaxes { get; set; }
        public DateTime? userDefined1 { get; set; }
        public DateTime? userDefined2 { get; set; }
        public DateTime? userDefined3 { get; set; }
        public DateTime? annualFee { get; set; }
        public string id { get; set; }
        public int? hud1EsDueDateIndex { get; set; }

    }
}