using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class UCDDetail
    {
        public string Section { get; set; }
        public int? LineNumber { get; set; }
        public int? FeeIndex { get; set; }
        public string FeeDesc { get; set; }
        public decimal? FeeAmount { get; set; }
        public string FeePaidTo { get; set; }
        public string FeeAccountType { get; set; }
        public bool? FeePOC { get; set; }
        public DateTime? FeeDateFrom { get; set; }
        public DateTime? FeeDateTo { get; set; }
        public string Id { get; set; }
    }
}