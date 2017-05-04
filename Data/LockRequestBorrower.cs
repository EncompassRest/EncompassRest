
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class LockRequestBorrower
{
public string firstName { get; set; }
public string lastName { get; set; }
public string sSN { get; set; }
public string experianScore { get; set; }
public string transUnionScore { get; set; }
public string equifaxScore { get; set; }
public string id { get; set; }
public bool? isEmpty { get; set; }
public int? lrbIndex { get; set; }

    }
}