
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassRest.Data
    {
        public class SchedulePaymentTransaction
{
public string id { get; set; }
public decimal? buydownSubsidyAmountDue { get; set; }
public string comments { get; set; }
public string createdById { get; set; }
public string createdByName { get; set; }
public DateTime? createdDateTimeUtc { get; set; }
public decimal? escrowDue { get; set; }
public string guid { get; set; }
public decimal? indexRate { get; set; }
public decimal? interestDue { get; set; }
public decimal? interestRate { get; set; }
public DateTime? latePaymentDate { get; set; }
public decimal? miscFeeDue { get; set; }
public string modifiedById { get; set; }
public string modifiedByName { get; set; }
public DateTime? modifiedDateTimeUtc { get; set; }
public int? paymentNumber { get; set; }
public decimal? principalDue { get; set; }
public string servicingPaymentMethod { get; set; }
public string servicingTransactionType { get; set; }
public decimal? totalPastDue { get; set; }
public decimal? transactionAmount { get; set; }
public DateTime? transactionDate { get; set; }
public decimal? unpaidLateFeeDue { get; set; }
public DateTime? paymentReceiveDate { get; set; }
public decimal? escrowTaxDue { get; set; }
public decimal? escrowHazardInsuranceDue { get; set; }
public decimal? escrowMortgageInsuranceDue { get; set; }
public decimal? escrowFloodInsuranceDue { get; set; }
public decimal? escrowCityPropertyTaxDue { get; set; }
public decimal? escrowOther1Due { get; set; }
public decimal? escrowOther2Due { get; set; }
public decimal? escrowOther3Due { get; set; }
public decimal? escrowUSDAMonthlyPremiumDue { get; set; }
public decimal? principal { get; set; }
public decimal? interest { get; set; }
public decimal? escrow { get; set; }
public decimal? miscFee { get; set; }
public decimal? lateFee { get; set; }
public decimal? additionalPrincipal { get; set; }
public decimal? additionalEscrow { get; set; }
public decimal? taxes { get; set; }
public decimal? hazardInsurance { get; set; }
public decimal? mortgageInsurance { get; set; }
public decimal? floodInsurance { get; set; }
public decimal? cityPropertyTax { get; set; }
public decimal? other1Escrow { get; set; }
public decimal? other2Escrow { get; set; }
public decimal? other3Escrow { get; set; }
public decimal? uSDAMonthlyPremium { get; set; }
public decimal? buydownSubsidyAmount { get; set; }

    }
}