
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class Hud1EsPayTo
    {
        public int? hud1EsPayToIndex { get; set; }
        public decimal? maxDeductiblePercentage { get; set; }
        public decimal? maxDeductibleAmount { get; set; }
        public string policyNumber { get; set; }
        public decimal? premium { get; set; }
        public DateTime? renewalDate { get; set; }
        public string paymentSchedule { get; set; }
        public decimal? amountLastPay { get; set; }
        public DateTime? datePaid { get; set; }
        public decimal? amountNextDue { get; set; }
        public DateTime? nextDueDate { get; set; }
        public DateTime? delinquentDate { get; set; }
        public string feeType { get; set; }
        public decimal? coverageAmount { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string contactName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string id { get; set; }

    }
}