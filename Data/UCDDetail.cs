
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class UCDDetail
{
public string section { get; set; }
public int? lineNumber { get; set; }
public int? feeIndex { get; set; }
public string feeDesc { get; set; }
public decimal? feeAmount { get; set; }
public string feePaidTo { get; set; }
public string feeAccountType { get; set; }
public bool? feePOC { get; set; }
public DateTime? feeDateFrom { get; set; }
public DateTime? feeDateTo { get; set; }
public string id { get; set; }

    }
}