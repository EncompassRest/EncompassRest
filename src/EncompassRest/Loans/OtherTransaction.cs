using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class OtherTransaction
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string Comments { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public DateTime? CreatedDateTimeUtc { get; set; }
        public string Guid { get; set; }
        public string InstitutionName { get; set; }
        public string InstitutionRouting { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public DateTime? ModifiedDateTimeUtc { get; set; }
        public string Reference { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}