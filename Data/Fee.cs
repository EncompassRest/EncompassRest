using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class Fee
    {
        public string feeType { get; set; }
        public decimal? sellerPaidAmount { get; set; }
        public string description { get; set; }
        public decimal? borPaidAmount { get; set; }
        public string paidToName { get; set; }
        public decimal? monthlyPayment { get; set; }
        public bool? use4Decimals { get; set; }
        public int? days { get; set; }
        public decimal? amountPerDay { get; set; }
        public decimal? truncatedAmountPerDay { get; set; }
        public int numberOfMonths { get; set; }
        public decimal? percentage { get; set; }
        public decimal? amount { get; set; }
        public decimal? paidInAdvance { get; set; }
        public decimal? lenderCoverage { get; set; }
        public decimal? ownerCoverage { get; set; }
        public decimal? deedAmount { get; set; }
        public decimal? mortgageAmount { get; set; }
        public decimal? releasesAmount { get; set; }
        public string includeAboveNumber { get; set; }
        public DateTime? dateFrom { get; set; }
        public DateTime? dateTo { get; set; }
        public decimal? paidToOthers { get; set; }
        public decimal? paidToBroker { get; set; }
        public bool? fHA { get; set; }
        public bool? pFC { get; set; }
        public bool? pOC { get; set; }
        public string paidBy { get; set; }
        public string pTB { get; set; }
        public string fWBC { get; set; }
        public string fWSC { get; set; }
        public string newHUDBorPaidAmount { get; set; }
        public string id { get; set; }

    }
}
