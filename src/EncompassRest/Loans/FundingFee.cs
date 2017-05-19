using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class FundingFee
    {
        public string CdLineId { get; set; }
        public string LineId { get; set; }
        public int? LineNumber { get; set; }
        public bool? BalanceChecked { get; set; }
        public string FeeDescription { get; set; }
        public string FeeDescription2015 { get; set; }
        public string Payee { get; set; }
        public string PaidBy { get; set; }
        public string PaidTo { get; set; }
        public string PocPaidBy { get; set; }
        public string PtcPaidBy { get; set; }
    }
}