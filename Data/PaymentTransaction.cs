
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class PaymentTransaction
{
public string id { get; set; }
public string accountHolder { get; set; }
public string accountNumber { get; set; }
public decimal? additionalEscrow { get; set; }
public decimal? additionalPrincipal { get; set; }
public decimal? buydownSubsidyAmount { get; set; }
public string checkNumber { get; set; }
public string comments { get; set; }
public decimal? commonAmount { get; set; }
public DateTime? commonDate { get; set; }
public string createdById { get; set; }
public string createdByName { get; set; }
public DateTime? createdDateTimeUtc { get; set; }
public decimal? escrow { get; set; }
public string guid { get; set; }
public decimal? indexRate { get; set; }
public string institutionName { get; set; }
public string institutionRouting { get; set; }
public decimal? interest { get; set; }
public decimal? interestRate { get; set; }
public decimal? lateFee { get; set; }
public decimal? lateFeeIfLate { get; set; }
public DateTime? latePaymentDate { get; set; }
public decimal? miscFee { get; set; }
public string modifiedById { get; set; }
public string modifiedByName { get; set; }
public DateTime? modifiedDateTimeUtc { get; set; }
public DateTime? paymentDepositedDate { get; set; }
public DateTime? paymentDueDate { get; set; }
public DateTime? paymentIndexDate { get; set; }
public int? paymentNumber { get; set; }
public DateTime? paymentReceivedDate { get; set; }
public decimal? principal { get; set; }
public string reference { get; set; }
public string servicingPaymentMethod { get; set; }
public string servicingTransactionType { get; set; }
public DateTime? statementDate { get; set; }
public decimal? totalAmountDue { get; set; }
public decimal? totalAmountReceived { get; set; }
public decimal? transactionAmount { get; set; }
public DateTime? transactionDate { get; set; }
public decimal? escrowUSDAMonthlyPremium { get; set; }
public decimal? schedulePayLogMiscFee { get; set; }
public decimal? escrowTax { get; set; }
public decimal? escrowMortgageInsurance { get; set; }
public decimal? escrowHazardInsurance { get; set; }
public decimal? escrowFloodInsurance { get; set; }
public decimal? escrowCityPropertyTax { get; set; }
public decimal? escrowOther1 { get; set; }
public decimal? escrowOther2 { get; set; }
public decimal? escrowOther3 { get; set; }

    }
}