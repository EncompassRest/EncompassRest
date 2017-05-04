
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class EscrowDisbursementTransaction
{
public string id { get; set; }
public string comments { get; set; }
public string createdById { get; set; }
public string createdByName { get; set; }
public DateTime? createdDateTimeUtc { get; set; }
public DateTime? disbursementDueDate { get; set; }
public int? disbursementNumber { get; set; }
public string disbursementType { get; set; }
public string guid { get; set; }
public string institutionName { get; set; }
public string modifiedById { get; set; }
public string modifiedByName { get; set; }
public DateTime? modifiedDateTimeUtc { get; set; }
public string servicingPaymentMethod { get; set; }
public string servicingTransactionType { get; set; }
public decimal? transactionAmount { get; set; }
public DateTime? transactionDate { get; set; }

    }
}