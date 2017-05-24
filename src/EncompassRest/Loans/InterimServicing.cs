using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicing
    {
        public Value<string> BorrCellPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrCellPhoneNumber() => !BorrCellPhoneNumber.Clean;
        public Value<string> BorrHomeEmail { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrHomeEmail() => !BorrHomeEmail.Clean;
        public Value<string> BorrHomePhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrHomePhoneNumber() => !BorrHomePhoneNumber.Clean;
        public Value<string> BorrowerFirstName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerFirstName() => !BorrowerFirstName.Clean;
        public Value<string> BorrowerLastName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerLastName() => !BorrowerLastName.Clean;
        public Value<string> BorrWorkPhoneNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrWorkPhoneNumber() => !BorrWorkPhoneNumber.Clean;
        public Value<string> CalcTriggered { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCalcTriggered() => !CalcTriggered.Clean;
        public Value<decimal?> CityInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCityInsurance() => !CityInsurance.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<decimal?> CurrentPrincipalBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentPrincipalBalance() => !CurrentPrincipalBalance.Clean;
        public Value<decimal?> EscrowBalance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowBalance() => !EscrowBalance.Clean;
        public Value<List<EscrowDisbursementTransaction>> EscrowDisbursementTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowDisbursementTransactions() => !EscrowDisbursementTransactions.Clean;
        public Value<List<EscrowInterestTransaction>> EscrowInterestTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowInterestTransactions() => !EscrowInterestTransactions.Clean;
        public Value<decimal?> FloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFloodInsurance() => !FloodInsurance.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<List<InterimServicingTransaction>> InterimServicingTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterimServicingTransactions() => !InterimServicingTransactions.Clean;
        public Value<decimal?> LastPaymentAdditionalEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentAdditionalEscrow() => !LastPaymentAdditionalEscrow.Clean;
        public Value<decimal?> LastPaymentAdditionalPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentAdditionalPrincipal() => !LastPaymentAdditionalPrincipal.Clean;
        public Value<decimal?> LastPaymentBuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentBuydownSubsidyAmount() => !LastPaymentBuydownSubsidyAmount.Clean;
        public Value<decimal?> LastPaymentEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowAmount() => !LastPaymentEscrowAmount.Clean;
        public Value<decimal?> LastPaymentEscrowCityPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowCityPropertyTax() => !LastPaymentEscrowCityPropertyTax.Clean;
        public Value<decimal?> LastPaymentEscrowFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowFloodInsurance() => !LastPaymentEscrowFloodInsurance.Clean;
        public Value<decimal?> LastPaymentEscrowHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowHazardInsurance() => !LastPaymentEscrowHazardInsurance.Clean;
        public Value<decimal?> LastPaymentEscrowMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowMortgageInsurance() => !LastPaymentEscrowMortgageInsurance.Clean;
        public Value<decimal?> LastPaymentEscrowOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther1() => !LastPaymentEscrowOther1.Clean;
        public Value<decimal?> LastPaymentEscrowOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther2() => !LastPaymentEscrowOther2.Clean;
        public Value<decimal?> LastPaymentEscrowOther3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowOther3() => !LastPaymentEscrowOther3.Clean;
        public Value<decimal?> LastPaymentEscrowTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowTax() => !LastPaymentEscrowTax.Clean;
        public Value<decimal?> LastPaymentEscrowUSDAMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentEscrowUSDAMonthlyPremium() => !LastPaymentEscrowUSDAMonthlyPremium.Clean;
        public Value<string> LastPaymentGuid { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentGuid() => !LastPaymentGuid.Clean;
        public Value<decimal?> LastPaymentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentInterest() => !LastPaymentInterest.Clean;
        public Value<decimal?> LastPaymentLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentLateFee() => !LastPaymentLateFee.Clean;
        public Value<decimal?> LastPaymentMiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentMiscFee() => !LastPaymentMiscFee.Clean;
        public Value<int?> LastPaymentNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentNumber() => !LastPaymentNumber.Clean;
        public Value<decimal?> LastPaymentPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentPrincipal() => !LastPaymentPrincipal.Clean;
        public Value<decimal?> LastPaymentPrincipalAndInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentPrincipalAndInterest() => !LastPaymentPrincipalAndInterest.Clean;
        public Value<DateTime?> LastPaymentReceivedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentReceivedDate() => !LastPaymentReceivedDate.Clean;
        public Value<DateTime?> LastPaymentStatementDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentStatementDate() => !LastPaymentStatementDate.Clean;
        public Value<decimal?> LastPaymentTotalAmountReceived { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastPaymentTotalAmountReceived() => !LastPaymentTotalAmountReceived.Clean;
        public SchedulePaymentTransaction LastScheduledPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastScheduledPayment() => LastScheduledPayment?.Clean == false;
        public Value<DateTime?> LastStatementPrintedDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastStatementPrintedDate() => !LastStatementPrintedDate.Clean;
        public Value<string> LoanSnapshotXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanSnapshotXml() => !LoanSnapshotXml.Clean;
        public Value<string> MailingCity { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingCity() => !MailingCity.Clean;
        public Value<string> MailingPostalCode { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingPostalCode() => !MailingPostalCode.Clean;
        public Value<string> MailingState { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingState() => !MailingState.Clean;
        public Value<string> MailingStreetAddress { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMailingStreetAddress() => !MailingStreetAddress.Clean;
        public Value<string> MortgageAccount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageAccount() => !MortgageAccount.Clean;
        public Value<decimal?> NextEscrowTotalFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalFloodInsurance() => !NextEscrowTotalFloodInsurance.Clean;
        public Value<DateTime?> NextEscrowTotalFloodInsuranceDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalFloodInsuranceDueDate() => !NextEscrowTotalFloodInsuranceDueDate.Clean;
        public Value<decimal?> NextEscrowTotalHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalHazardInsurance() => !NextEscrowTotalHazardInsurance.Clean;
        public Value<DateTime?> NextEscrowTotalHazardInsuranceDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalHazardInsuranceDueDate() => !NextEscrowTotalHazardInsuranceDueDate.Clean;
        public Value<decimal?> NextEscrowTotalMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalMortgageInsurance() => !NextEscrowTotalMortgageInsurance.Clean;
        public Value<DateTime?> NextEscrowTotalMortgageInsuranceDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalMortgageInsuranceDueDate() => !NextEscrowTotalMortgageInsuranceDueDate.Clean;
        public Value<decimal?> NextEscrowTotalOtherTax1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax1() => !NextEscrowTotalOtherTax1.Clean;
        public Value<DateTime?> NextEscrowTotalOtherTax1DueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax1DueDate() => !NextEscrowTotalOtherTax1DueDate.Clean;
        public Value<decimal?> NextEscrowTotalOtherTax2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax2() => !NextEscrowTotalOtherTax2.Clean;
        public Value<DateTime?> NextEscrowTotalOtherTax2DueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax2DueDate() => !NextEscrowTotalOtherTax2DueDate.Clean;
        public Value<decimal?> NextEscrowTotalOtherTax3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax3() => !NextEscrowTotalOtherTax3.Clean;
        public Value<DateTime?> NextEscrowTotalOtherTax3DueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalOtherTax3DueDate() => !NextEscrowTotalOtherTax3DueDate.Clean;
        public Value<decimal?> NextEscrowTotalPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalPropertyTax() => !NextEscrowTotalPropertyTax.Clean;
        public Value<DateTime?> NextEscrowTotalPropertyTaxDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalPropertyTaxDueDate() => !NextEscrowTotalPropertyTaxDueDate.Clean;
        public Value<decimal?> NextEscrowTotalTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalTax() => !NextEscrowTotalTax.Clean;
        public Value<DateTime?> NextEscrowTotalTaxDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalTaxDueDate() => !NextEscrowTotalTaxDueDate.Clean;
        public Value<decimal?> NextEscrowTotalUsdaMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalUsdaMonthlyPremium() => !NextEscrowTotalUsdaMonthlyPremium.Clean;
        public Value<DateTime?> NextEscrowTotalUsdaMonthlyPremiumDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextEscrowTotalUsdaMonthlyPremiumDueDate() => !NextEscrowTotalUsdaMonthlyPremiumDueDate.Clean;
        public Value<decimal?> NextPaymentBuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentBuydownSubsidyAmount() => !NextPaymentBuydownSubsidyAmount.Clean;
        public Value<decimal?> NextPaymentEscrowAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowAmount() => !NextPaymentEscrowAmount.Clean;
        public Value<decimal?> NextPaymentEscrowCityPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowCityPropertyTax() => !NextPaymentEscrowCityPropertyTax.Clean;
        public Value<decimal?> NextPaymentEscrowFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowFloodInsurance() => !NextPaymentEscrowFloodInsurance.Clean;
        public Value<decimal?> NextPaymentEscrowHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowHazardInsurance() => !NextPaymentEscrowHazardInsurance.Clean;
        public Value<decimal?> NextPaymentEscrowMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowMortgageInsurance() => !NextPaymentEscrowMortgageInsurance.Clean;
        public Value<decimal?> NextPaymentEscrowOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther1() => !NextPaymentEscrowOther1.Clean;
        public Value<decimal?> NextPaymentEscrowOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther2() => !NextPaymentEscrowOther2.Clean;
        public Value<decimal?> NextPaymentEscrowOther3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowOther3() => !NextPaymentEscrowOther3.Clean;
        public Value<decimal?> NextPaymentEscrowTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowTax() => !NextPaymentEscrowTax.Clean;
        public Value<decimal?> NextPaymentEscrowUSDAMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentEscrowUSDAMonthlyPremium() => !NextPaymentEscrowUSDAMonthlyPremium.Clean;
        public Value<decimal?> NextPaymentIndexCurrentValuePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentIndexCurrentValuePercent() => !NextPaymentIndexCurrentValuePercent.Clean;
        public Value<decimal?> NextPaymentInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentInterest() => !NextPaymentInterest.Clean;
        public Value<decimal?> NextPaymentLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentLateFee() => !NextPaymentLateFee.Clean;
        public Value<DateTime?> NextPaymentLatePaymentDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentLatePaymentDate() => !NextPaymentLatePaymentDate.Clean;
        public Value<decimal?> NextPaymentMiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentMiscFee() => !NextPaymentMiscFee.Clean;
        public Value<decimal?> NextPaymentPastDueAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPastDueAmount() => !NextPaymentPastDueAmount.Clean;
        public Value<DateTime?> NextPaymentPaymentDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPaymentDueDate() => !NextPaymentPaymentDueDate.Clean;
        public Value<DateTime?> NextPaymentPaymentIndexDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPaymentIndexDate() => !NextPaymentPaymentIndexDate.Clean;
        public Value<decimal?> NextPaymentPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPrincipal() => !NextPaymentPrincipal.Clean;
        public Value<decimal?> NextPaymentPrincipalAndInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentPrincipalAndInterest() => !NextPaymentPrincipalAndInterest.Clean;
        public Value<decimal?> NextPaymentRequestedInterestRatePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentRequestedInterestRatePercent() => !NextPaymentRequestedInterestRatePercent.Clean;
        public Value<DateTime?> NextPaymentStatementDueDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentStatementDueDate() => !NextPaymentStatementDueDate.Clean;
        public Value<decimal?> NextPaymentTotalAmountDue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentTotalAmountDue() => !NextPaymentTotalAmountDue.Clean;
        public Value<decimal?> NextPaymentTotalAmountWithLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentTotalAmountWithLateFee() => !NextPaymentTotalAmountWithLateFee.Clean;
        public Value<decimal?> NextPaymentUnpaidLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextPaymentUnpaidLateFee() => !NextPaymentUnpaidLateFee.Clean;
        public SchedulePaymentTransaction NextScheduledPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNextScheduledPayment() => NextScheduledPayment?.Clean == false;
        public Value<int?> NumberOfDisbursement { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfDisbursement() => !NumberOfDisbursement.Clean;
        public Value<List<OtherTransaction>> OtherTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherTransactions() => !OtherTransactions.Clean;
        public Value<DateTime?> PaymentDueDatePrinted { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentDueDatePrinted() => !PaymentDueDatePrinted.Clean;
        public Value<List<PaymentReversalTransaction>> PaymentReversalTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentReversalTransactions() => !PaymentReversalTransactions.Clean;
        public Value<List<PaymentTransaction>> PaymentTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentTransactions() => !PaymentTransactions.Clean;
        public Value<string> PrintedByUserId { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByUserId() => !PrintedByUserId.Clean;
        public Value<string> PrintedByUserName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintedByUserName() => !PrintedByUserName.Clean;
        public Value<decimal?> PurchasedPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasedPrincipal() => !PurchasedPrincipal.Clean;
        public Value<List<SchedulePaymentTransaction>> ScheduledPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeScheduledPayments() => !ScheduledPayments.Clean;
        public Value<List<SchedulePaymentTransaction>> SchedulePaymentTransactions { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSchedulePaymentTransactions() => !SchedulePaymentTransactions.Clean;
        public Value<string> ServicerLoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicerLoanNumber() => !ServicerLoanNumber.Clean;
        public Value<string> ServicingStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingStatus() => !ServicingStatus.Clean;
        public Value<DateTime?> ServicingTransferDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeServicingTransferDate() => !ServicingTransferDate.Clean;
        public Value<string> SubServicer { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubServicer() => !SubServicer.Clean;
        public Value<string> SubServicerLoanNumber { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubServicerLoanNumber() => !SubServicerLoanNumber.Clean;
        public Value<decimal?> TotalAdditionalEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalEscrow() => !TotalAdditionalEscrow.Clean;
        public Value<decimal?> TotalAdditionalEscrowYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalEscrowYearToDate() => !TotalAdditionalEscrowYearToDate.Clean;
        public Value<decimal?> TotalAdditionalPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalPrincipal() => !TotalAdditionalPrincipal.Clean;
        public Value<decimal?> TotalAdditionalPrincipalYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdditionalPrincipalYearToDate() => !TotalAdditionalPrincipalYearToDate.Clean;
        public Value<decimal?> TotalAmountDisbursed { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAmountDisbursed() => !TotalAmountDisbursed.Clean;
        public Value<decimal?> TotalBuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBuydownSubsidyAmount() => !TotalBuydownSubsidyAmount.Clean;
        public Value<decimal?> TotalBuydownSubsidyAmountYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBuydownSubsidyAmountYearToDate() => !TotalBuydownSubsidyAmountYearToDate.Clean;
        public Value<decimal?> TotalEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrow() => !TotalEscrow.Clean;
        public Value<decimal?> TotalEscrowYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalEscrowYearToDate() => !TotalEscrowYearToDate.Clean;
        public Value<decimal?> TotalHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHazardInsurance() => !TotalHazardInsurance.Clean;
        public Value<decimal?> TotalInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterest() => !TotalInterest.Clean;
        public Value<decimal?> TotalInterestYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalInterestYearToDate() => !TotalInterestYearToDate.Clean;
        public Value<decimal?> TotalLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateFee() => !TotalLateFee.Clean;
        public Value<decimal?> TotalLateFeeYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLateFeeYearToDate() => !TotalLateFeeYearToDate.Clean;
        public Value<decimal?> TotalMiscFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMiscFee() => !TotalMiscFee.Clean;
        public Value<decimal?> TotalMiscFeeYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMiscFeeYearToDate() => !TotalMiscFeeYearToDate.Clean;
        public Value<decimal?> TotalMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMortgageInsurance() => !TotalMortgageInsurance.Clean;
        public Value<int?> TotalNumberOfLatePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNumberOfLatePayment() => !TotalNumberOfLatePayment.Clean;
        public Value<int?> TotalNumberOfPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalNumberOfPayment() => !TotalNumberOfPayment.Clean;
        public Value<decimal?> TotalOtherTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherTaxes() => !TotalOtherTaxes.Clean;
        public Value<decimal?> TotalPAndI { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPAndI() => !TotalPAndI.Clean;
        public Value<decimal?> TotalPAndIYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPAndIYearToDate() => !TotalPAndIYearToDate.Clean;
        public Value<decimal?> TotalPaymentCollected { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaymentCollected() => !TotalPaymentCollected.Clean;
        public Value<decimal?> TotalPaymentCollectedYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaymentCollectedYearToDate() => !TotalPaymentCollectedYearToDate.Clean;
        public Value<decimal?> TotalPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrincipal() => !TotalPrincipal.Clean;
        public Value<decimal?> TotalPrincipalYearToDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrincipalYearToDate() => !TotalPrincipalYearToDate.Clean;
        public Value<decimal?> TotalTaxes { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalTaxes() => !TotalTaxes.Clean;
        public Value<decimal?> TotalUsdaMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalUsdaMonthlyPremium() => !TotalUsdaMonthlyPremium.Clean;
        public Value<decimal?> UnpaidBuydownSubsidyAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidBuydownSubsidyAmount() => !UnpaidBuydownSubsidyAmount.Clean;
        public Value<decimal?> UnpaidEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrow() => !UnpaidEscrow.Clean;
        public Value<decimal?> UnpaidEscrowCityPropertyTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowCityPropertyTax() => !UnpaidEscrowCityPropertyTax.Clean;
        public Value<decimal?> UnpaidEscrowFloodInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowFloodInsurance() => !UnpaidEscrowFloodInsurance.Clean;
        public Value<decimal?> UnpaidEscrowHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowHazardInsurance() => !UnpaidEscrowHazardInsurance.Clean;
        public Value<decimal?> UnpaidEscrowMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowMortgageInsurance() => !UnpaidEscrowMortgageInsurance.Clean;
        public Value<decimal?> UnpaidEscrowOther1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther1() => !UnpaidEscrowOther1.Clean;
        public Value<decimal?> UnpaidEscrowOther2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther2() => !UnpaidEscrowOther2.Clean;
        public Value<decimal?> UnpaidEscrowOther3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowOther3() => !UnpaidEscrowOther3.Clean;
        public Value<decimal?> UnpaidEscrowTax { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowTax() => !UnpaidEscrowTax.Clean;
        public Value<decimal?> UnpaidEscrowUSDAMonthlyPremium { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidEscrowUSDAMonthlyPremium() => !UnpaidEscrowUSDAMonthlyPremium.Clean;
        public Value<decimal?> UnpaidInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidInterest() => !UnpaidInterest.Clean;
        public Value<decimal?> UnpaidLateFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidLateFee() => !UnpaidLateFee.Clean;
        public Value<decimal?> UnpaidMiscrFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidMiscrFee() => !UnpaidMiscrFee.Clean;
        public Value<decimal?> UnpaidPrincipal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUnpaidPrincipal() => !UnpaidPrincipal.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BorrCellPhoneNumber.Clean
                    && BorrHomeEmail.Clean
                    && BorrHomePhoneNumber.Clean
                    && BorrowerFirstName.Clean
                    && BorrowerLastName.Clean
                    && BorrWorkPhoneNumber.Clean
                    && CalcTriggered.Clean
                    && CityInsurance.Clean
                    && Comments.Clean
                    && CurrentPrincipalBalance.Clean
                    && EscrowBalance.Clean
                    && EscrowDisbursementTransactions.Clean
                    && EscrowInterestTransactions.Clean
                    && FloodInsurance.Clean
                    && Id.Clean
                    && InterimServicingTransactions.Clean
                    && LastPaymentAdditionalEscrow.Clean
                    && LastPaymentAdditionalPrincipal.Clean
                    && LastPaymentBuydownSubsidyAmount.Clean
                    && LastPaymentEscrowAmount.Clean
                    && LastPaymentEscrowCityPropertyTax.Clean
                    && LastPaymentEscrowFloodInsurance.Clean
                    && LastPaymentEscrowHazardInsurance.Clean
                    && LastPaymentEscrowMortgageInsurance.Clean
                    && LastPaymentEscrowOther1.Clean
                    && LastPaymentEscrowOther2.Clean
                    && LastPaymentEscrowOther3.Clean
                    && LastPaymentEscrowTax.Clean
                    && LastPaymentEscrowUSDAMonthlyPremium.Clean
                    && LastPaymentGuid.Clean
                    && LastPaymentInterest.Clean
                    && LastPaymentLateFee.Clean
                    && LastPaymentMiscFee.Clean
                    && LastPaymentNumber.Clean
                    && LastPaymentPrincipal.Clean
                    && LastPaymentPrincipalAndInterest.Clean
                    && LastPaymentReceivedDate.Clean
                    && LastPaymentStatementDate.Clean
                    && LastPaymentTotalAmountReceived.Clean
                    && LastStatementPrintedDate.Clean
                    && LoanSnapshotXml.Clean
                    && MailingCity.Clean
                    && MailingPostalCode.Clean
                    && MailingState.Clean
                    && MailingStreetAddress.Clean
                    && MortgageAccount.Clean
                    && NextEscrowTotalFloodInsurance.Clean
                    && NextEscrowTotalFloodInsuranceDueDate.Clean
                    && NextEscrowTotalHazardInsurance.Clean
                    && NextEscrowTotalHazardInsuranceDueDate.Clean
                    && NextEscrowTotalMortgageInsurance.Clean
                    && NextEscrowTotalMortgageInsuranceDueDate.Clean
                    && NextEscrowTotalOtherTax1.Clean
                    && NextEscrowTotalOtherTax1DueDate.Clean
                    && NextEscrowTotalOtherTax2.Clean
                    && NextEscrowTotalOtherTax2DueDate.Clean
                    && NextEscrowTotalOtherTax3.Clean
                    && NextEscrowTotalOtherTax3DueDate.Clean
                    && NextEscrowTotalPropertyTax.Clean
                    && NextEscrowTotalPropertyTaxDueDate.Clean
                    && NextEscrowTotalTax.Clean
                    && NextEscrowTotalTaxDueDate.Clean
                    && NextEscrowTotalUsdaMonthlyPremium.Clean
                    && NextEscrowTotalUsdaMonthlyPremiumDueDate.Clean
                    && NextPaymentBuydownSubsidyAmount.Clean
                    && NextPaymentEscrowAmount.Clean
                    && NextPaymentEscrowCityPropertyTax.Clean
                    && NextPaymentEscrowFloodInsurance.Clean
                    && NextPaymentEscrowHazardInsurance.Clean
                    && NextPaymentEscrowMortgageInsurance.Clean
                    && NextPaymentEscrowOther1.Clean
                    && NextPaymentEscrowOther2.Clean
                    && NextPaymentEscrowOther3.Clean
                    && NextPaymentEscrowTax.Clean
                    && NextPaymentEscrowUSDAMonthlyPremium.Clean
                    && NextPaymentIndexCurrentValuePercent.Clean
                    && NextPaymentInterest.Clean
                    && NextPaymentLateFee.Clean
                    && NextPaymentLatePaymentDate.Clean
                    && NextPaymentMiscFee.Clean
                    && NextPaymentPastDueAmount.Clean
                    && NextPaymentPaymentDueDate.Clean
                    && NextPaymentPaymentIndexDate.Clean
                    && NextPaymentPrincipal.Clean
                    && NextPaymentPrincipalAndInterest.Clean
                    && NextPaymentRequestedInterestRatePercent.Clean
                    && NextPaymentStatementDueDate.Clean
                    && NextPaymentTotalAmountDue.Clean
                    && NextPaymentTotalAmountWithLateFee.Clean
                    && NextPaymentUnpaidLateFee.Clean
                    && NumberOfDisbursement.Clean
                    && OtherTransactions.Clean
                    && PaymentDueDatePrinted.Clean
                    && PaymentReversalTransactions.Clean
                    && PaymentTransactions.Clean
                    && PrintedByUserId.Clean
                    && PrintedByUserName.Clean
                    && PurchasedPrincipal.Clean
                    && ScheduledPayments.Clean
                    && SchedulePaymentTransactions.Clean
                    && ServicerLoanNumber.Clean
                    && ServicingStatus.Clean
                    && ServicingTransferDate.Clean
                    && SubServicer.Clean
                    && SubServicerLoanNumber.Clean
                    && TotalAdditionalEscrow.Clean
                    && TotalAdditionalEscrowYearToDate.Clean
                    && TotalAdditionalPrincipal.Clean
                    && TotalAdditionalPrincipalYearToDate.Clean
                    && TotalAmountDisbursed.Clean
                    && TotalBuydownSubsidyAmount.Clean
                    && TotalBuydownSubsidyAmountYearToDate.Clean
                    && TotalEscrow.Clean
                    && TotalEscrowYearToDate.Clean
                    && TotalHazardInsurance.Clean
                    && TotalInterest.Clean
                    && TotalInterestYearToDate.Clean
                    && TotalLateFee.Clean
                    && TotalLateFeeYearToDate.Clean
                    && TotalMiscFee.Clean
                    && TotalMiscFeeYearToDate.Clean
                    && TotalMortgageInsurance.Clean
                    && TotalNumberOfLatePayment.Clean
                    && TotalNumberOfPayment.Clean
                    && TotalOtherTaxes.Clean
                    && TotalPAndI.Clean
                    && TotalPAndIYearToDate.Clean
                    && TotalPaymentCollected.Clean
                    && TotalPaymentCollectedYearToDate.Clean
                    && TotalPrincipal.Clean
                    && TotalPrincipalYearToDate.Clean
                    && TotalTaxes.Clean
                    && TotalUsdaMonthlyPremium.Clean
                    && UnpaidBuydownSubsidyAmount.Clean
                    && UnpaidEscrow.Clean
                    && UnpaidEscrowCityPropertyTax.Clean
                    && UnpaidEscrowFloodInsurance.Clean
                    && UnpaidEscrowHazardInsurance.Clean
                    && UnpaidEscrowMortgageInsurance.Clean
                    && UnpaidEscrowOther1.Clean
                    && UnpaidEscrowOther2.Clean
                    && UnpaidEscrowOther3.Clean
                    && UnpaidEscrowTax.Clean
                    && UnpaidEscrowUSDAMonthlyPremium.Clean
                    && UnpaidInterest.Clean
                    && UnpaidLateFee.Clean
                    && UnpaidMiscrFee.Clean
                    && UnpaidPrincipal.Clean
                    && LastScheduledPayment.Clean
                    && NextScheduledPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BorrCellPhoneNumber; v0.Clean = value; BorrCellPhoneNumber = v0;
                var v1 = BorrHomeEmail; v1.Clean = value; BorrHomeEmail = v1;
                var v2 = BorrHomePhoneNumber; v2.Clean = value; BorrHomePhoneNumber = v2;
                var v3 = BorrowerFirstName; v3.Clean = value; BorrowerFirstName = v3;
                var v4 = BorrowerLastName; v4.Clean = value; BorrowerLastName = v4;
                var v5 = BorrWorkPhoneNumber; v5.Clean = value; BorrWorkPhoneNumber = v5;
                var v6 = CalcTriggered; v6.Clean = value; CalcTriggered = v6;
                var v7 = CityInsurance; v7.Clean = value; CityInsurance = v7;
                var v8 = Comments; v8.Clean = value; Comments = v8;
                var v9 = CurrentPrincipalBalance; v9.Clean = value; CurrentPrincipalBalance = v9;
                var v10 = EscrowBalance; v10.Clean = value; EscrowBalance = v10;
                var v11 = EscrowDisbursementTransactions; v11.Clean = value; EscrowDisbursementTransactions = v11;
                var v12 = EscrowInterestTransactions; v12.Clean = value; EscrowInterestTransactions = v12;
                var v13 = FloodInsurance; v13.Clean = value; FloodInsurance = v13;
                var v14 = Id; v14.Clean = value; Id = v14;
                var v15 = InterimServicingTransactions; v15.Clean = value; InterimServicingTransactions = v15;
                var v16 = LastPaymentAdditionalEscrow; v16.Clean = value; LastPaymentAdditionalEscrow = v16;
                var v17 = LastPaymentAdditionalPrincipal; v17.Clean = value; LastPaymentAdditionalPrincipal = v17;
                var v18 = LastPaymentBuydownSubsidyAmount; v18.Clean = value; LastPaymentBuydownSubsidyAmount = v18;
                var v19 = LastPaymentEscrowAmount; v19.Clean = value; LastPaymentEscrowAmount = v19;
                var v20 = LastPaymentEscrowCityPropertyTax; v20.Clean = value; LastPaymentEscrowCityPropertyTax = v20;
                var v21 = LastPaymentEscrowFloodInsurance; v21.Clean = value; LastPaymentEscrowFloodInsurance = v21;
                var v22 = LastPaymentEscrowHazardInsurance; v22.Clean = value; LastPaymentEscrowHazardInsurance = v22;
                var v23 = LastPaymentEscrowMortgageInsurance; v23.Clean = value; LastPaymentEscrowMortgageInsurance = v23;
                var v24 = LastPaymentEscrowOther1; v24.Clean = value; LastPaymentEscrowOther1 = v24;
                var v25 = LastPaymentEscrowOther2; v25.Clean = value; LastPaymentEscrowOther2 = v25;
                var v26 = LastPaymentEscrowOther3; v26.Clean = value; LastPaymentEscrowOther3 = v26;
                var v27 = LastPaymentEscrowTax; v27.Clean = value; LastPaymentEscrowTax = v27;
                var v28 = LastPaymentEscrowUSDAMonthlyPremium; v28.Clean = value; LastPaymentEscrowUSDAMonthlyPremium = v28;
                var v29 = LastPaymentGuid; v29.Clean = value; LastPaymentGuid = v29;
                var v30 = LastPaymentInterest; v30.Clean = value; LastPaymentInterest = v30;
                var v31 = LastPaymentLateFee; v31.Clean = value; LastPaymentLateFee = v31;
                var v32 = LastPaymentMiscFee; v32.Clean = value; LastPaymentMiscFee = v32;
                var v33 = LastPaymentNumber; v33.Clean = value; LastPaymentNumber = v33;
                var v34 = LastPaymentPrincipal; v34.Clean = value; LastPaymentPrincipal = v34;
                var v35 = LastPaymentPrincipalAndInterest; v35.Clean = value; LastPaymentPrincipalAndInterest = v35;
                var v36 = LastPaymentReceivedDate; v36.Clean = value; LastPaymentReceivedDate = v36;
                var v37 = LastPaymentStatementDate; v37.Clean = value; LastPaymentStatementDate = v37;
                var v38 = LastPaymentTotalAmountReceived; v38.Clean = value; LastPaymentTotalAmountReceived = v38;
                var v39 = LastStatementPrintedDate; v39.Clean = value; LastStatementPrintedDate = v39;
                var v40 = LoanSnapshotXml; v40.Clean = value; LoanSnapshotXml = v40;
                var v41 = MailingCity; v41.Clean = value; MailingCity = v41;
                var v42 = MailingPostalCode; v42.Clean = value; MailingPostalCode = v42;
                var v43 = MailingState; v43.Clean = value; MailingState = v43;
                var v44 = MailingStreetAddress; v44.Clean = value; MailingStreetAddress = v44;
                var v45 = MortgageAccount; v45.Clean = value; MortgageAccount = v45;
                var v46 = NextEscrowTotalFloodInsurance; v46.Clean = value; NextEscrowTotalFloodInsurance = v46;
                var v47 = NextEscrowTotalFloodInsuranceDueDate; v47.Clean = value; NextEscrowTotalFloodInsuranceDueDate = v47;
                var v48 = NextEscrowTotalHazardInsurance; v48.Clean = value; NextEscrowTotalHazardInsurance = v48;
                var v49 = NextEscrowTotalHazardInsuranceDueDate; v49.Clean = value; NextEscrowTotalHazardInsuranceDueDate = v49;
                var v50 = NextEscrowTotalMortgageInsurance; v50.Clean = value; NextEscrowTotalMortgageInsurance = v50;
                var v51 = NextEscrowTotalMortgageInsuranceDueDate; v51.Clean = value; NextEscrowTotalMortgageInsuranceDueDate = v51;
                var v52 = NextEscrowTotalOtherTax1; v52.Clean = value; NextEscrowTotalOtherTax1 = v52;
                var v53 = NextEscrowTotalOtherTax1DueDate; v53.Clean = value; NextEscrowTotalOtherTax1DueDate = v53;
                var v54 = NextEscrowTotalOtherTax2; v54.Clean = value; NextEscrowTotalOtherTax2 = v54;
                var v55 = NextEscrowTotalOtherTax2DueDate; v55.Clean = value; NextEscrowTotalOtherTax2DueDate = v55;
                var v56 = NextEscrowTotalOtherTax3; v56.Clean = value; NextEscrowTotalOtherTax3 = v56;
                var v57 = NextEscrowTotalOtherTax3DueDate; v57.Clean = value; NextEscrowTotalOtherTax3DueDate = v57;
                var v58 = NextEscrowTotalPropertyTax; v58.Clean = value; NextEscrowTotalPropertyTax = v58;
                var v59 = NextEscrowTotalPropertyTaxDueDate; v59.Clean = value; NextEscrowTotalPropertyTaxDueDate = v59;
                var v60 = NextEscrowTotalTax; v60.Clean = value; NextEscrowTotalTax = v60;
                var v61 = NextEscrowTotalTaxDueDate; v61.Clean = value; NextEscrowTotalTaxDueDate = v61;
                var v62 = NextEscrowTotalUsdaMonthlyPremium; v62.Clean = value; NextEscrowTotalUsdaMonthlyPremium = v62;
                var v63 = NextEscrowTotalUsdaMonthlyPremiumDueDate; v63.Clean = value; NextEscrowTotalUsdaMonthlyPremiumDueDate = v63;
                var v64 = NextPaymentBuydownSubsidyAmount; v64.Clean = value; NextPaymentBuydownSubsidyAmount = v64;
                var v65 = NextPaymentEscrowAmount; v65.Clean = value; NextPaymentEscrowAmount = v65;
                var v66 = NextPaymentEscrowCityPropertyTax; v66.Clean = value; NextPaymentEscrowCityPropertyTax = v66;
                var v67 = NextPaymentEscrowFloodInsurance; v67.Clean = value; NextPaymentEscrowFloodInsurance = v67;
                var v68 = NextPaymentEscrowHazardInsurance; v68.Clean = value; NextPaymentEscrowHazardInsurance = v68;
                var v69 = NextPaymentEscrowMortgageInsurance; v69.Clean = value; NextPaymentEscrowMortgageInsurance = v69;
                var v70 = NextPaymentEscrowOther1; v70.Clean = value; NextPaymentEscrowOther1 = v70;
                var v71 = NextPaymentEscrowOther2; v71.Clean = value; NextPaymentEscrowOther2 = v71;
                var v72 = NextPaymentEscrowOther3; v72.Clean = value; NextPaymentEscrowOther3 = v72;
                var v73 = NextPaymentEscrowTax; v73.Clean = value; NextPaymentEscrowTax = v73;
                var v74 = NextPaymentEscrowUSDAMonthlyPremium; v74.Clean = value; NextPaymentEscrowUSDAMonthlyPremium = v74;
                var v75 = NextPaymentIndexCurrentValuePercent; v75.Clean = value; NextPaymentIndexCurrentValuePercent = v75;
                var v76 = NextPaymentInterest; v76.Clean = value; NextPaymentInterest = v76;
                var v77 = NextPaymentLateFee; v77.Clean = value; NextPaymentLateFee = v77;
                var v78 = NextPaymentLatePaymentDate; v78.Clean = value; NextPaymentLatePaymentDate = v78;
                var v79 = NextPaymentMiscFee; v79.Clean = value; NextPaymentMiscFee = v79;
                var v80 = NextPaymentPastDueAmount; v80.Clean = value; NextPaymentPastDueAmount = v80;
                var v81 = NextPaymentPaymentDueDate; v81.Clean = value; NextPaymentPaymentDueDate = v81;
                var v82 = NextPaymentPaymentIndexDate; v82.Clean = value; NextPaymentPaymentIndexDate = v82;
                var v83 = NextPaymentPrincipal; v83.Clean = value; NextPaymentPrincipal = v83;
                var v84 = NextPaymentPrincipalAndInterest; v84.Clean = value; NextPaymentPrincipalAndInterest = v84;
                var v85 = NextPaymentRequestedInterestRatePercent; v85.Clean = value; NextPaymentRequestedInterestRatePercent = v85;
                var v86 = NextPaymentStatementDueDate; v86.Clean = value; NextPaymentStatementDueDate = v86;
                var v87 = NextPaymentTotalAmountDue; v87.Clean = value; NextPaymentTotalAmountDue = v87;
                var v88 = NextPaymentTotalAmountWithLateFee; v88.Clean = value; NextPaymentTotalAmountWithLateFee = v88;
                var v89 = NextPaymentUnpaidLateFee; v89.Clean = value; NextPaymentUnpaidLateFee = v89;
                var v90 = NumberOfDisbursement; v90.Clean = value; NumberOfDisbursement = v90;
                var v91 = OtherTransactions; v91.Clean = value; OtherTransactions = v91;
                var v92 = PaymentDueDatePrinted; v92.Clean = value; PaymentDueDatePrinted = v92;
                var v93 = PaymentReversalTransactions; v93.Clean = value; PaymentReversalTransactions = v93;
                var v94 = PaymentTransactions; v94.Clean = value; PaymentTransactions = v94;
                var v95 = PrintedByUserId; v95.Clean = value; PrintedByUserId = v95;
                var v96 = PrintedByUserName; v96.Clean = value; PrintedByUserName = v96;
                var v97 = PurchasedPrincipal; v97.Clean = value; PurchasedPrincipal = v97;
                var v98 = ScheduledPayments; v98.Clean = value; ScheduledPayments = v98;
                var v99 = SchedulePaymentTransactions; v99.Clean = value; SchedulePaymentTransactions = v99;
                var v100 = ServicerLoanNumber; v100.Clean = value; ServicerLoanNumber = v100;
                var v101 = ServicingStatus; v101.Clean = value; ServicingStatus = v101;
                var v102 = ServicingTransferDate; v102.Clean = value; ServicingTransferDate = v102;
                var v103 = SubServicer; v103.Clean = value; SubServicer = v103;
                var v104 = SubServicerLoanNumber; v104.Clean = value; SubServicerLoanNumber = v104;
                var v105 = TotalAdditionalEscrow; v105.Clean = value; TotalAdditionalEscrow = v105;
                var v106 = TotalAdditionalEscrowYearToDate; v106.Clean = value; TotalAdditionalEscrowYearToDate = v106;
                var v107 = TotalAdditionalPrincipal; v107.Clean = value; TotalAdditionalPrincipal = v107;
                var v108 = TotalAdditionalPrincipalYearToDate; v108.Clean = value; TotalAdditionalPrincipalYearToDate = v108;
                var v109 = TotalAmountDisbursed; v109.Clean = value; TotalAmountDisbursed = v109;
                var v110 = TotalBuydownSubsidyAmount; v110.Clean = value; TotalBuydownSubsidyAmount = v110;
                var v111 = TotalBuydownSubsidyAmountYearToDate; v111.Clean = value; TotalBuydownSubsidyAmountYearToDate = v111;
                var v112 = TotalEscrow; v112.Clean = value; TotalEscrow = v112;
                var v113 = TotalEscrowYearToDate; v113.Clean = value; TotalEscrowYearToDate = v113;
                var v114 = TotalHazardInsurance; v114.Clean = value; TotalHazardInsurance = v114;
                var v115 = TotalInterest; v115.Clean = value; TotalInterest = v115;
                var v116 = TotalInterestYearToDate; v116.Clean = value; TotalInterestYearToDate = v116;
                var v117 = TotalLateFee; v117.Clean = value; TotalLateFee = v117;
                var v118 = TotalLateFeeYearToDate; v118.Clean = value; TotalLateFeeYearToDate = v118;
                var v119 = TotalMiscFee; v119.Clean = value; TotalMiscFee = v119;
                var v120 = TotalMiscFeeYearToDate; v120.Clean = value; TotalMiscFeeYearToDate = v120;
                var v121 = TotalMortgageInsurance; v121.Clean = value; TotalMortgageInsurance = v121;
                var v122 = TotalNumberOfLatePayment; v122.Clean = value; TotalNumberOfLatePayment = v122;
                var v123 = TotalNumberOfPayment; v123.Clean = value; TotalNumberOfPayment = v123;
                var v124 = TotalOtherTaxes; v124.Clean = value; TotalOtherTaxes = v124;
                var v125 = TotalPAndI; v125.Clean = value; TotalPAndI = v125;
                var v126 = TotalPAndIYearToDate; v126.Clean = value; TotalPAndIYearToDate = v126;
                var v127 = TotalPaymentCollected; v127.Clean = value; TotalPaymentCollected = v127;
                var v128 = TotalPaymentCollectedYearToDate; v128.Clean = value; TotalPaymentCollectedYearToDate = v128;
                var v129 = TotalPrincipal; v129.Clean = value; TotalPrincipal = v129;
                var v130 = TotalPrincipalYearToDate; v130.Clean = value; TotalPrincipalYearToDate = v130;
                var v131 = TotalTaxes; v131.Clean = value; TotalTaxes = v131;
                var v132 = TotalUsdaMonthlyPremium; v132.Clean = value; TotalUsdaMonthlyPremium = v132;
                var v133 = UnpaidBuydownSubsidyAmount; v133.Clean = value; UnpaidBuydownSubsidyAmount = v133;
                var v134 = UnpaidEscrow; v134.Clean = value; UnpaidEscrow = v134;
                var v135 = UnpaidEscrowCityPropertyTax; v135.Clean = value; UnpaidEscrowCityPropertyTax = v135;
                var v136 = UnpaidEscrowFloodInsurance; v136.Clean = value; UnpaidEscrowFloodInsurance = v136;
                var v137 = UnpaidEscrowHazardInsurance; v137.Clean = value; UnpaidEscrowHazardInsurance = v137;
                var v138 = UnpaidEscrowMortgageInsurance; v138.Clean = value; UnpaidEscrowMortgageInsurance = v138;
                var v139 = UnpaidEscrowOther1; v139.Clean = value; UnpaidEscrowOther1 = v139;
                var v140 = UnpaidEscrowOther2; v140.Clean = value; UnpaidEscrowOther2 = v140;
                var v141 = UnpaidEscrowOther3; v141.Clean = value; UnpaidEscrowOther3 = v141;
                var v142 = UnpaidEscrowTax; v142.Clean = value; UnpaidEscrowTax = v142;
                var v143 = UnpaidEscrowUSDAMonthlyPremium; v143.Clean = value; UnpaidEscrowUSDAMonthlyPremium = v143;
                var v144 = UnpaidInterest; v144.Clean = value; UnpaidInterest = v144;
                var v145 = UnpaidLateFee; v145.Clean = value; UnpaidLateFee = v145;
                var v146 = UnpaidMiscrFee; v146.Clean = value; UnpaidMiscrFee = v146;
                var v147 = UnpaidPrincipal; v147.Clean = value; UnpaidPrincipal = v147;
                if (LastScheduledPayment != null) LastScheduledPayment.Clean = value;
                if (NextScheduledPayment != null) NextScheduledPayment.Clean = value;
                _settingClean = 0;
            }
        }
    }
}