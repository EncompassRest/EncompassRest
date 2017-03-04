
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class InterimServicingTransaction
{
public string id { get; set; }
public string comments { get; set; }
public string createdById { get; set; }
public string createdByName { get; set; }
public DateTime? createdDateTimeUtc { get; set; }
public string guid { get; set; }
public string modifiedById { get; set; }
public string modifiedByName { get; set; }
public DateTime? modifiedDateTimeUtc { get; set; }
public string servicingPaymentMethod { get; set; }
public string servicingTransactionType { get; set; }
public decimal? transactionAmount { get; set; }
public DateTime? transactionDate { get; set; }

    }
}