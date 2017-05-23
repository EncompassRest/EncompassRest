using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class TQLDocument
    {
        public string Id { get; set; }
        public JsonNullable<DateTime?> TQLDocumentDeliveredDate { get; set; }
    }
}