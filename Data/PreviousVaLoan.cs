
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class PreviousVaLoan
{
public int? previousVaLoanIndex { get; set; }
public string loanType { get; set; }
public string propertyAddress { get; set; }
public DateTime? dateOfLoan { get; set; }
public bool? propertyOwned { get; set; }
public DateTime? dateSold { get; set; }
public string vALoanNumber { get; set; }
public string propertyCity { get; set; }
public string propertyState { get; set; }
public string propertyPostalCode { get; set; }
public string id { get; set; }

    }
}