using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class UCDDetail
    {
        public string FeeAccountType { get; set; }
        public JsonNullable<decimal?> FeeAmount { get; set; }
        public JsonNullable<DateTime?> FeeDateFrom { get; set; }
        public JsonNullable<DateTime?> FeeDateTo { get; set; }
        public string FeeDesc { get; set; }
        public int? FeeIndex { get; set; }
        public string FeePaidTo { get; set; }
        public JsonNullable<bool?> FeePOC { get; set; }
        public string Id { get; set; }
        public int? LineNumber { get; set; }
        public string Section { get; set; }
    }
}