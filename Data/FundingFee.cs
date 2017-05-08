
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class FundingFee
{
public string cdLineId { get; set; }
public string lineId { get; set; }
public int? lineNumber { get; set; }
public bool? balanceChecked { get; set; }
public string feeDescription { get; set; }
public string feeDescription2015 { get; set; }
public string payee { get; set; }
public string paidBy { get; set; }
public string paidTo { get; set; }
public string pocPaidBy { get; set; }
public string ptcPaidBy { get; set; }

    }
}