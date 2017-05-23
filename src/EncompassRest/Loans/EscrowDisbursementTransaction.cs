using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class EscrowDisbursementTransaction
    {
        public string Comments { get; set; }
        public string CreatedById { get; set; }
        public string CreatedByName { get; set; }
        public JsonNullable<DateTime?> CreatedDateTimeUtc { get; set; }
        public JsonNullable<DateTime?> DisbursementDueDate { get; set; }
        public JsonNullable<int?> DisbursementNumber { get; set; }
        public string DisbursementType { get; set; }
        public string Guid { get; set; }
        public string Id { get; set; }
        public string InstitutionName { get; set; }
        public string ModifiedById { get; set; }
        public string ModifiedByName { get; set; }
        public JsonNullable<DateTime?> ModifiedDateTimeUtc { get; set; }
        public string ServicingPaymentMethod { get; set; }
        public string ServicingTransactionType { get; set; }
        public JsonNullable<decimal?> TransactionAmount { get; set; }
        public JsonNullable<DateTime?> TransactionDate { get; set; }
    }
}