
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Hud1EsSetup
    {
        public string date { get; set; }
        public int? taxDisb { get; set; }
        public int? hazInsDisb { get; set; }
        public int? mtgInsDisb { get; set; }
        public int? floodInsDisb { get; set; }
        public int? schoolTaxes { get; set; }
        public int? userDefined1 { get; set; }
        public int? userDefined2 { get; set; }
        public int? userDefined3 { get; set; }
        public int? annualFees { get; set; }
        public bool? taxPrepaid { get; set; }
        public bool? hazInsPrepaid { get; set; }
        public bool? mtgInsPrepaid { get; set; }
        public bool? floodInsPrepaid { get; set; }
        public bool? schoolTaxesPrepaid { get; set; }
        public bool? userDefinedPrepaid1 { get; set; }
        public bool? userDefinedPrepaid2 { get; set; }
        public bool? userDefinedPrepaid3 { get; set; }
        public bool? annualFeePrepaid { get; set; }
        public string id { get; set; }
        public int? hud1EsSetupIndex { get; set; }

    }
}