using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class InterimServicing : IDirty
    {
        private DirtyValue<decimal?> _beginningBalance;
        public decimal? BeginningBalance { get => _beginningBalance; set => _beginningBalance = value; }
        private DirtyValue<string> _borrCellPhoneNumber;
        public string BorrCellPhoneNumber { get => _borrCellPhoneNumber; set => _borrCellPhoneNumber = value; }
        private DirtyValue<string> _borrHomeEmail;
        public string BorrHomeEmail { get => _borrHomeEmail; set => _borrHomeEmail = value; }
        private DirtyValue<string> _borrHomePhoneNumber;
        public string BorrHomePhoneNumber { get => _borrHomePhoneNumber; set => _borrHomePhoneNumber = value; }
        private DirtyValue<string> _borrowerFirstName;
        public string BorrowerFirstName { get => _borrowerFirstName; set => _borrowerFirstName = value; }
        private DirtyValue<string> _borrowerLastName;
        public string BorrowerLastName { get => _borrowerLastName; set => _borrowerLastName = value; }
        private DirtyValue<string> _borrWorkPhoneNumber;
        public string BorrWorkPhoneNumber { get => _borrWorkPhoneNumber; set => _borrWorkPhoneNumber = value; }
        private DirtyValue<string> _calcTriggered;
        public string CalcTriggered { get => _calcTriggered; set => _calcTriggered = value; }
        private DirtyValue<decimal?> _cityInsurance;
        public decimal? CityInsurance { get => _cityInsurance; set => _cityInsurance = value; }
        private DirtyValue<string> _comments;
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<decimal?> _currentPrincipalBalance;
        public decimal? CurrentPrincipalBalance { get => _currentPrincipalBalance; set => _currentPrincipalBalance = value; }
        private DirtyValue<decimal?> _escrowBalance;
        public decimal? EscrowBalance { get => _escrowBalance; set => _escrowBalance = value; }
        private DirtyList<EscrowDisbursementTransaction> _escrowDisbursementTransactions;
        public IList<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get => _escrowDisbursementTransactions ?? (_escrowDisbursementTransactions = new DirtyList<EscrowDisbursementTransaction>()); set => _escrowDisbursementTransactions = new DirtyList<EscrowDisbursementTransaction>(value); }
        private DirtyList<EscrowInterestTransaction> _escrowInterestTransactions;
        public IList<EscrowInterestTransaction> EscrowInterestTransactions { get => _escrowInterestTransactions ?? (_escrowInterestTransactions = new DirtyList<EscrowInterestTransaction>()); set => _escrowInterestTransactions = new DirtyList<EscrowInterestTransaction>(value); }
        private DirtyValue<decimal?> _floodInsurance;
        public decimal? FloodInsurance { get => _floodInsurance; set => _floodInsurance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyList<InterimServicingTransaction> _interimServicingTransactions;
        public IList<InterimServicingTransaction> InterimServicingTransactions { get => _interimServicingTransactions ?? (_interimServicingTransactions = new DirtyList<InterimServicingTransaction>()); set => _interimServicingTransactions = new DirtyList<InterimServicingTransaction>(value); }
        private DirtyValue<decimal?> _lastPaymentAdditionalEscrow;
        public decimal? LastPaymentAdditionalEscrow { get => _lastPaymentAdditionalEscrow; set => _lastPaymentAdditionalEscrow = value; }
        private DirtyValue<decimal?> _lastPaymentAdditionalPrincipal;
        public decimal? LastPaymentAdditionalPrincipal { get => _lastPaymentAdditionalPrincipal; set => _lastPaymentAdditionalPrincipal = value; }
        private DirtyValue<decimal?> _lastPaymentBuydownSubsidyAmount;
        public decimal? LastPaymentBuydownSubsidyAmount { get => _lastPaymentBuydownSubsidyAmount; set => _lastPaymentBuydownSubsidyAmount = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowAmount;
        public decimal? LastPaymentEscrowAmount { get => _lastPaymentEscrowAmount; set => _lastPaymentEscrowAmount = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowCityPropertyTax;
        public decimal? LastPaymentEscrowCityPropertyTax { get => _lastPaymentEscrowCityPropertyTax; set => _lastPaymentEscrowCityPropertyTax = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowFloodInsurance;
        public decimal? LastPaymentEscrowFloodInsurance { get => _lastPaymentEscrowFloodInsurance; set => _lastPaymentEscrowFloodInsurance = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowHazardInsurance;
        public decimal? LastPaymentEscrowHazardInsurance { get => _lastPaymentEscrowHazardInsurance; set => _lastPaymentEscrowHazardInsurance = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowMortgageInsurance;
        public decimal? LastPaymentEscrowMortgageInsurance { get => _lastPaymentEscrowMortgageInsurance; set => _lastPaymentEscrowMortgageInsurance = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowOther1;
        public decimal? LastPaymentEscrowOther1 { get => _lastPaymentEscrowOther1; set => _lastPaymentEscrowOther1 = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowOther2;
        public decimal? LastPaymentEscrowOther2 { get => _lastPaymentEscrowOther2; set => _lastPaymentEscrowOther2 = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowOther3;
        public decimal? LastPaymentEscrowOther3 { get => _lastPaymentEscrowOther3; set => _lastPaymentEscrowOther3 = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowTax;
        public decimal? LastPaymentEscrowTax { get => _lastPaymentEscrowTax; set => _lastPaymentEscrowTax = value; }
        private DirtyValue<decimal?> _lastPaymentEscrowUSDAMonthlyPremium;
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get => _lastPaymentEscrowUSDAMonthlyPremium; set => _lastPaymentEscrowUSDAMonthlyPremium = value; }
        private DirtyValue<string> _lastPaymentGuid;
        public string LastPaymentGuid { get => _lastPaymentGuid; set => _lastPaymentGuid = value; }
        private DirtyValue<decimal?> _lastPaymentInterest;
        public decimal? LastPaymentInterest { get => _lastPaymentInterest; set => _lastPaymentInterest = value; }
        private DirtyValue<decimal?> _lastPaymentLateFee;
        public decimal? LastPaymentLateFee { get => _lastPaymentLateFee; set => _lastPaymentLateFee = value; }
        private DirtyValue<decimal?> _lastPaymentMiscFee;
        public decimal? LastPaymentMiscFee { get => _lastPaymentMiscFee; set => _lastPaymentMiscFee = value; }
        private DirtyValue<int?> _lastPaymentNumber;
        public int? LastPaymentNumber { get => _lastPaymentNumber; set => _lastPaymentNumber = value; }
        private DirtyValue<decimal?> _lastPaymentPrincipal;
        public decimal? LastPaymentPrincipal { get => _lastPaymentPrincipal; set => _lastPaymentPrincipal = value; }
        private DirtyValue<decimal?> _lastPaymentPrincipalAndInterest;
        public decimal? LastPaymentPrincipalAndInterest { get => _lastPaymentPrincipalAndInterest; set => _lastPaymentPrincipalAndInterest = value; }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => _lastPaymentReceivedDate = value; }
        private DirtyValue<DateTime?> _lastPaymentStatementDate;
        public DateTime? LastPaymentStatementDate { get => _lastPaymentStatementDate; set => _lastPaymentStatementDate = value; }
        private DirtyValue<decimal?> _lastPaymentTotalAmountReceived;
        public decimal? LastPaymentTotalAmountReceived { get => _lastPaymentTotalAmountReceived; set => _lastPaymentTotalAmountReceived = value; }
        private SchedulePaymentTransaction _lastScheduledPayment;
        public SchedulePaymentTransaction LastScheduledPayment { get => _lastScheduledPayment ?? (_lastScheduledPayment = new SchedulePaymentTransaction()); set => _lastScheduledPayment = value; }
        private DirtyValue<DateTime?> _lastStatementPrintedDate;
        public DateTime? LastStatementPrintedDate { get => _lastStatementPrintedDate; set => _lastStatementPrintedDate = value; }
        private DirtyValue<string> _loanSnapshotXml;
        public string LoanSnapshotXml { get => _loanSnapshotXml; set => _loanSnapshotXml = value; }
        private DirtyValue<string> _mailingCity;
        public string MailingCity { get => _mailingCity; set => _mailingCity = value; }
        private DirtyValue<string> _mailingPostalCode;
        public string MailingPostalCode { get => _mailingPostalCode; set => _mailingPostalCode = value; }
        private DirtyValue<string> _mailingState;
        public string MailingState { get => _mailingState; set => _mailingState = value; }
        private DirtyValue<string> _mailingStreetAddress;
        public string MailingStreetAddress { get => _mailingStreetAddress; set => _mailingStreetAddress = value; }
        private DirtyValue<string> _mortgageAccount;
        public string MortgageAccount { get => _mortgageAccount; set => _mortgageAccount = value; }
        private DirtyValue<decimal?> _nextEscrowTotalFloodInsurance;
        public decimal? NextEscrowTotalFloodInsurance { get => _nextEscrowTotalFloodInsurance; set => _nextEscrowTotalFloodInsurance = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalFloodInsuranceDueDate;
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get => _nextEscrowTotalFloodInsuranceDueDate; set => _nextEscrowTotalFloodInsuranceDueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalHazardInsurance;
        public decimal? NextEscrowTotalHazardInsurance { get => _nextEscrowTotalHazardInsurance; set => _nextEscrowTotalHazardInsurance = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalHazardInsuranceDueDate;
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get => _nextEscrowTotalHazardInsuranceDueDate; set => _nextEscrowTotalHazardInsuranceDueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalMortgageInsurance;
        public decimal? NextEscrowTotalMortgageInsurance { get => _nextEscrowTotalMortgageInsurance; set => _nextEscrowTotalMortgageInsurance = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalMortgageInsuranceDueDate;
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get => _nextEscrowTotalMortgageInsuranceDueDate; set => _nextEscrowTotalMortgageInsuranceDueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax1;
        public decimal? NextEscrowTotalOtherTax1 { get => _nextEscrowTotalOtherTax1; set => _nextEscrowTotalOtherTax1 = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax1DueDate;
        public DateTime? NextEscrowTotalOtherTax1DueDate { get => _nextEscrowTotalOtherTax1DueDate; set => _nextEscrowTotalOtherTax1DueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax2;
        public decimal? NextEscrowTotalOtherTax2 { get => _nextEscrowTotalOtherTax2; set => _nextEscrowTotalOtherTax2 = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax2DueDate;
        public DateTime? NextEscrowTotalOtherTax2DueDate { get => _nextEscrowTotalOtherTax2DueDate; set => _nextEscrowTotalOtherTax2DueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax3;
        public decimal? NextEscrowTotalOtherTax3 { get => _nextEscrowTotalOtherTax3; set => _nextEscrowTotalOtherTax3 = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax3DueDate;
        public DateTime? NextEscrowTotalOtherTax3DueDate { get => _nextEscrowTotalOtherTax3DueDate; set => _nextEscrowTotalOtherTax3DueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalPropertyTax;
        public decimal? NextEscrowTotalPropertyTax { get => _nextEscrowTotalPropertyTax; set => _nextEscrowTotalPropertyTax = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalPropertyTaxDueDate;
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get => _nextEscrowTotalPropertyTaxDueDate; set => _nextEscrowTotalPropertyTaxDueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalTax;
        public decimal? NextEscrowTotalTax { get => _nextEscrowTotalTax; set => _nextEscrowTotalTax = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalTaxDueDate;
        public DateTime? NextEscrowTotalTaxDueDate { get => _nextEscrowTotalTaxDueDate; set => _nextEscrowTotalTaxDueDate = value; }
        private DirtyValue<decimal?> _nextEscrowTotalUsdaMonthlyPremium;
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get => _nextEscrowTotalUsdaMonthlyPremium; set => _nextEscrowTotalUsdaMonthlyPremium = value; }
        private DirtyValue<DateTime?> _nextEscrowTotalUsdaMonthlyPremiumDueDate;
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get => _nextEscrowTotalUsdaMonthlyPremiumDueDate; set => _nextEscrowTotalUsdaMonthlyPremiumDueDate = value; }
        private DirtyValue<decimal?> _nextPaymentBuydownSubsidyAmount;
        public decimal? NextPaymentBuydownSubsidyAmount { get => _nextPaymentBuydownSubsidyAmount; set => _nextPaymentBuydownSubsidyAmount = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowAmount;
        public decimal? NextPaymentEscrowAmount { get => _nextPaymentEscrowAmount; set => _nextPaymentEscrowAmount = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowCityPropertyTax;
        public decimal? NextPaymentEscrowCityPropertyTax { get => _nextPaymentEscrowCityPropertyTax; set => _nextPaymentEscrowCityPropertyTax = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowFloodInsurance;
        public decimal? NextPaymentEscrowFloodInsurance { get => _nextPaymentEscrowFloodInsurance; set => _nextPaymentEscrowFloodInsurance = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowHazardInsurance;
        public decimal? NextPaymentEscrowHazardInsurance { get => _nextPaymentEscrowHazardInsurance; set => _nextPaymentEscrowHazardInsurance = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowMortgageInsurance;
        public decimal? NextPaymentEscrowMortgageInsurance { get => _nextPaymentEscrowMortgageInsurance; set => _nextPaymentEscrowMortgageInsurance = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowOther1;
        public decimal? NextPaymentEscrowOther1 { get => _nextPaymentEscrowOther1; set => _nextPaymentEscrowOther1 = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowOther2;
        public decimal? NextPaymentEscrowOther2 { get => _nextPaymentEscrowOther2; set => _nextPaymentEscrowOther2 = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowOther3;
        public decimal? NextPaymentEscrowOther3 { get => _nextPaymentEscrowOther3; set => _nextPaymentEscrowOther3 = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowTax;
        public decimal? NextPaymentEscrowTax { get => _nextPaymentEscrowTax; set => _nextPaymentEscrowTax = value; }
        private DirtyValue<decimal?> _nextPaymentEscrowUSDAMonthlyPremium;
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get => _nextPaymentEscrowUSDAMonthlyPremium; set => _nextPaymentEscrowUSDAMonthlyPremium = value; }
        private DirtyValue<decimal?> _nextPaymentIndexCurrentValuePercent;
        public decimal? NextPaymentIndexCurrentValuePercent { get => _nextPaymentIndexCurrentValuePercent; set => _nextPaymentIndexCurrentValuePercent = value; }
        private DirtyValue<decimal?> _nextPaymentInterest;
        public decimal? NextPaymentInterest { get => _nextPaymentInterest; set => _nextPaymentInterest = value; }
        private DirtyValue<decimal?> _nextPaymentLateFee;
        public decimal? NextPaymentLateFee { get => _nextPaymentLateFee; set => _nextPaymentLateFee = value; }
        private DirtyValue<DateTime?> _nextPaymentLatePaymentDate;
        public DateTime? NextPaymentLatePaymentDate { get => _nextPaymentLatePaymentDate; set => _nextPaymentLatePaymentDate = value; }
        private DirtyValue<decimal?> _nextPaymentMiscFee;
        public decimal? NextPaymentMiscFee { get => _nextPaymentMiscFee; set => _nextPaymentMiscFee = value; }
        private DirtyValue<decimal?> _nextPaymentPastDueAmount;
        public decimal? NextPaymentPastDueAmount { get => _nextPaymentPastDueAmount; set => _nextPaymentPastDueAmount = value; }
        private DirtyValue<DateTime?> _nextPaymentPaymentDueDate;
        public DateTime? NextPaymentPaymentDueDate { get => _nextPaymentPaymentDueDate; set => _nextPaymentPaymentDueDate = value; }
        private DirtyValue<DateTime?> _nextPaymentPaymentIndexDate;
        public DateTime? NextPaymentPaymentIndexDate { get => _nextPaymentPaymentIndexDate; set => _nextPaymentPaymentIndexDate = value; }
        private DirtyValue<decimal?> _nextPaymentPrincipal;
        public decimal? NextPaymentPrincipal { get => _nextPaymentPrincipal; set => _nextPaymentPrincipal = value; }
        private DirtyValue<decimal?> _nextPaymentPrincipalAndInterest;
        public decimal? NextPaymentPrincipalAndInterest { get => _nextPaymentPrincipalAndInterest; set => _nextPaymentPrincipalAndInterest = value; }
        private DirtyValue<decimal?> _nextPaymentRequestedInterestRatePercent;
        public decimal? NextPaymentRequestedInterestRatePercent { get => _nextPaymentRequestedInterestRatePercent; set => _nextPaymentRequestedInterestRatePercent = value; }
        private DirtyValue<DateTime?> _nextPaymentStatementDueDate;
        public DateTime? NextPaymentStatementDueDate { get => _nextPaymentStatementDueDate; set => _nextPaymentStatementDueDate = value; }
        private DirtyValue<decimal?> _nextPaymentTotalAmountDue;
        public decimal? NextPaymentTotalAmountDue { get => _nextPaymentTotalAmountDue; set => _nextPaymentTotalAmountDue = value; }
        private DirtyValue<decimal?> _nextPaymentTotalAmountWithLateFee;
        public decimal? NextPaymentTotalAmountWithLateFee { get => _nextPaymentTotalAmountWithLateFee; set => _nextPaymentTotalAmountWithLateFee = value; }
        private DirtyValue<decimal?> _nextPaymentUnpaidLateFee;
        public decimal? NextPaymentUnpaidLateFee { get => _nextPaymentUnpaidLateFee; set => _nextPaymentUnpaidLateFee = value; }
        private SchedulePaymentTransaction _nextScheduledPayment;
        public SchedulePaymentTransaction NextScheduledPayment { get => _nextScheduledPayment ?? (_nextScheduledPayment = new SchedulePaymentTransaction()); set => _nextScheduledPayment = value; }
        private DirtyValue<int?> _numberOfDisbursement;
        public int? NumberOfDisbursement { get => _numberOfDisbursement; set => _numberOfDisbursement = value; }
        private DirtyList<OtherTransaction> _otherTransactions;
        public IList<OtherTransaction> OtherTransactions { get => _otherTransactions ?? (_otherTransactions = new DirtyList<OtherTransaction>()); set => _otherTransactions = new DirtyList<OtherTransaction>(value); }
        private DirtyValue<DateTime?> _paymentDueDatePrinted;
        public DateTime? PaymentDueDatePrinted { get => _paymentDueDatePrinted; set => _paymentDueDatePrinted = value; }
        private DirtyList<PaymentReversalTransaction> _paymentReversalTransactions;
        public IList<PaymentReversalTransaction> PaymentReversalTransactions { get => _paymentReversalTransactions ?? (_paymentReversalTransactions = new DirtyList<PaymentReversalTransaction>()); set => _paymentReversalTransactions = new DirtyList<PaymentReversalTransaction>(value); }
        private DirtyList<PaymentTransaction> _paymentTransactions;
        public IList<PaymentTransaction> PaymentTransactions { get => _paymentTransactions ?? (_paymentTransactions = new DirtyList<PaymentTransaction>()); set => _paymentTransactions = new DirtyList<PaymentTransaction>(value); }
        private DirtyValue<string> _printedByUserId;
        public string PrintedByUserId { get => _printedByUserId; set => _printedByUserId = value; }
        private DirtyValue<string> _printedByUserName;
        public string PrintedByUserName { get => _printedByUserName; set => _printedByUserName = value; }
        private DirtyValue<decimal?> _purchasedPrincipal;
        public decimal? PurchasedPrincipal { get => _purchasedPrincipal; set => _purchasedPrincipal = value; }
        private DirtyList<SchedulePaymentTransaction> _scheduledPayments;
        public IList<SchedulePaymentTransaction> ScheduledPayments { get => _scheduledPayments ?? (_scheduledPayments = new DirtyList<SchedulePaymentTransaction>()); set => _scheduledPayments = new DirtyList<SchedulePaymentTransaction>(value); }
        private DirtyList<SchedulePaymentTransaction> _schedulePaymentTransactions;
        public IList<SchedulePaymentTransaction> SchedulePaymentTransactions { get => _schedulePaymentTransactions ?? (_schedulePaymentTransactions = new DirtyList<SchedulePaymentTransaction>()); set => _schedulePaymentTransactions = new DirtyList<SchedulePaymentTransaction>(value); }
        private DirtyValue<string> _servicerLoanNumber;
        public string ServicerLoanNumber { get => _servicerLoanNumber; set => _servicerLoanNumber = value; }
        private DirtyValue<StringEnumValue<ServicingStatus>> _servicingStatus;
        public StringEnumValue<ServicingStatus> ServicingStatus { get => _servicingStatus; set => _servicingStatus = value; }
        private DirtyValue<DateTime?> _servicingTransferDate;
        public DateTime? ServicingTransferDate { get => _servicingTransferDate; set => _servicingTransferDate = value; }
        private DirtyValue<string> _subServicer;
        public string SubServicer { get => _subServicer; set => _subServicer = value; }
        private DirtyValue<string> _subServicerLoanNumber;
        public string SubServicerLoanNumber { get => _subServicerLoanNumber; set => _subServicerLoanNumber = value; }
        private DirtyValue<decimal?> _totalAdditionalEscrow;
        public decimal? TotalAdditionalEscrow { get => _totalAdditionalEscrow; set => _totalAdditionalEscrow = value; }
        private DirtyValue<decimal?> _totalAdditionalEscrowYearToDate;
        public decimal? TotalAdditionalEscrowYearToDate { get => _totalAdditionalEscrowYearToDate; set => _totalAdditionalEscrowYearToDate = value; }
        private DirtyValue<decimal?> _totalAdditionalPrincipal;
        public decimal? TotalAdditionalPrincipal { get => _totalAdditionalPrincipal; set => _totalAdditionalPrincipal = value; }
        private DirtyValue<decimal?> _totalAdditionalPrincipalYearToDate;
        public decimal? TotalAdditionalPrincipalYearToDate { get => _totalAdditionalPrincipalYearToDate; set => _totalAdditionalPrincipalYearToDate = value; }
        private DirtyValue<decimal?> _totalAmountDisbursed;
        public decimal? TotalAmountDisbursed { get => _totalAmountDisbursed; set => _totalAmountDisbursed = value; }
        private DirtyValue<decimal?> _totalBuydownSubsidyAmount;
        public decimal? TotalBuydownSubsidyAmount { get => _totalBuydownSubsidyAmount; set => _totalBuydownSubsidyAmount = value; }
        private DirtyValue<decimal?> _totalBuydownSubsidyAmountYearToDate;
        public decimal? TotalBuydownSubsidyAmountYearToDate { get => _totalBuydownSubsidyAmountYearToDate; set => _totalBuydownSubsidyAmountYearToDate = value; }
        private DirtyValue<decimal?> _totalEscrow;
        public decimal? TotalEscrow { get => _totalEscrow; set => _totalEscrow = value; }
        private DirtyValue<decimal?> _totalEscrowYearToDate;
        public decimal? TotalEscrowYearToDate { get => _totalEscrowYearToDate; set => _totalEscrowYearToDate = value; }
        private DirtyValue<decimal?> _totalHazardInsurance;
        public decimal? TotalHazardInsurance { get => _totalHazardInsurance; set => _totalHazardInsurance = value; }
        private DirtyValue<decimal?> _totalInterest;
        public decimal? TotalInterest { get => _totalInterest; set => _totalInterest = value; }
        private DirtyValue<decimal?> _totalInterestYearToDate;
        public decimal? TotalInterestYearToDate { get => _totalInterestYearToDate; set => _totalInterestYearToDate = value; }
        private DirtyValue<decimal?> _totalLateFee;
        public decimal? TotalLateFee { get => _totalLateFee; set => _totalLateFee = value; }
        private DirtyValue<decimal?> _totalLateFeeYearToDate;
        public decimal? TotalLateFeeYearToDate { get => _totalLateFeeYearToDate; set => _totalLateFeeYearToDate = value; }
        private DirtyValue<decimal?> _totalMiscFee;
        public decimal? TotalMiscFee { get => _totalMiscFee; set => _totalMiscFee = value; }
        private DirtyValue<decimal?> _totalMiscFeeYearToDate;
        public decimal? TotalMiscFeeYearToDate { get => _totalMiscFeeYearToDate; set => _totalMiscFeeYearToDate = value; }
        private DirtyValue<decimal?> _totalMortgageInsurance;
        public decimal? TotalMortgageInsurance { get => _totalMortgageInsurance; set => _totalMortgageInsurance = value; }
        private DirtyValue<int?> _totalNumberOfLatePayment;
        public int? TotalNumberOfLatePayment { get => _totalNumberOfLatePayment; set => _totalNumberOfLatePayment = value; }
        private DirtyValue<int?> _totalNumberOfPayment;
        public int? TotalNumberOfPayment { get => _totalNumberOfPayment; set => _totalNumberOfPayment = value; }
        private DirtyValue<decimal?> _totalOtherTaxes;
        public decimal? TotalOtherTaxes { get => _totalOtherTaxes; set => _totalOtherTaxes = value; }
        private DirtyValue<decimal?> _totalPAndI;
        public decimal? TotalPAndI { get => _totalPAndI; set => _totalPAndI = value; }
        private DirtyValue<decimal?> _totalPAndIYearToDate;
        public decimal? TotalPAndIYearToDate { get => _totalPAndIYearToDate; set => _totalPAndIYearToDate = value; }
        private DirtyValue<decimal?> _totalPaymentCollected;
        public decimal? TotalPaymentCollected { get => _totalPaymentCollected; set => _totalPaymentCollected = value; }
        private DirtyValue<decimal?> _totalPaymentCollectedYearToDate;
        public decimal? TotalPaymentCollectedYearToDate { get => _totalPaymentCollectedYearToDate; set => _totalPaymentCollectedYearToDate = value; }
        private DirtyValue<decimal?> _totalPrincipal;
        public decimal? TotalPrincipal { get => _totalPrincipal; set => _totalPrincipal = value; }
        private DirtyValue<decimal?> _totalPrincipalYearToDate;
        public decimal? TotalPrincipalYearToDate { get => _totalPrincipalYearToDate; set => _totalPrincipalYearToDate = value; }
        private DirtyValue<decimal?> _totalTaxes;
        public decimal? TotalTaxes { get => _totalTaxes; set => _totalTaxes = value; }
        private DirtyValue<decimal?> _totalUsdaMonthlyPremium;
        public decimal? TotalUsdaMonthlyPremium { get => _totalUsdaMonthlyPremium; set => _totalUsdaMonthlyPremium = value; }
        private DirtyValue<decimal?> _unpaidBuydownSubsidyAmount;
        public decimal? UnpaidBuydownSubsidyAmount { get => _unpaidBuydownSubsidyAmount; set => _unpaidBuydownSubsidyAmount = value; }
        private DirtyValue<decimal?> _unpaidEscrow;
        public decimal? UnpaidEscrow { get => _unpaidEscrow; set => _unpaidEscrow = value; }
        private DirtyValue<decimal?> _unpaidEscrowCityPropertyTax;
        public decimal? UnpaidEscrowCityPropertyTax { get => _unpaidEscrowCityPropertyTax; set => _unpaidEscrowCityPropertyTax = value; }
        private DirtyValue<decimal?> _unpaidEscrowFloodInsurance;
        public decimal? UnpaidEscrowFloodInsurance { get => _unpaidEscrowFloodInsurance; set => _unpaidEscrowFloodInsurance = value; }
        private DirtyValue<decimal?> _unpaidEscrowHazardInsurance;
        public decimal? UnpaidEscrowHazardInsurance { get => _unpaidEscrowHazardInsurance; set => _unpaidEscrowHazardInsurance = value; }
        private DirtyValue<decimal?> _unpaidEscrowMortgageInsurance;
        public decimal? UnpaidEscrowMortgageInsurance { get => _unpaidEscrowMortgageInsurance; set => _unpaidEscrowMortgageInsurance = value; }
        private DirtyValue<decimal?> _unpaidEscrowOther1;
        public decimal? UnpaidEscrowOther1 { get => _unpaidEscrowOther1; set => _unpaidEscrowOther1 = value; }
        private DirtyValue<decimal?> _unpaidEscrowOther2;
        public decimal? UnpaidEscrowOther2 { get => _unpaidEscrowOther2; set => _unpaidEscrowOther2 = value; }
        private DirtyValue<decimal?> _unpaidEscrowOther3;
        public decimal? UnpaidEscrowOther3 { get => _unpaidEscrowOther3; set => _unpaidEscrowOther3 = value; }
        private DirtyValue<decimal?> _unpaidEscrowTax;
        public decimal? UnpaidEscrowTax { get => _unpaidEscrowTax; set => _unpaidEscrowTax = value; }
        private DirtyValue<decimal?> _unpaidEscrowUSDAMonthlyPremium;
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get => _unpaidEscrowUSDAMonthlyPremium; set => _unpaidEscrowUSDAMonthlyPremium = value; }
        private DirtyValue<decimal?> _unpaidInterest;
        public decimal? UnpaidInterest { get => _unpaidInterest; set => _unpaidInterest = value; }
        private DirtyValue<decimal?> _unpaidLateFee;
        public decimal? UnpaidLateFee { get => _unpaidLateFee; set => _unpaidLateFee = value; }
        private DirtyValue<decimal?> _unpaidMiscrFee;
        public decimal? UnpaidMiscrFee { get => _unpaidMiscrFee; set => _unpaidMiscrFee = value; }
        private DirtyValue<decimal?> _unpaidPrincipal;
        public decimal? UnpaidPrincipal { get => _unpaidPrincipal; set => _unpaidPrincipal = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _beginningBalance.Dirty
                    || _borrCellPhoneNumber.Dirty
                    || _borrHomeEmail.Dirty
                    || _borrHomePhoneNumber.Dirty
                    || _borrowerFirstName.Dirty
                    || _borrowerLastName.Dirty
                    || _borrWorkPhoneNumber.Dirty
                    || _calcTriggered.Dirty
                    || _cityInsurance.Dirty
                    || _comments.Dirty
                    || _currentPrincipalBalance.Dirty
                    || _escrowBalance.Dirty
                    || _floodInsurance.Dirty
                    || _id.Dirty
                    || _lastPaymentAdditionalEscrow.Dirty
                    || _lastPaymentAdditionalPrincipal.Dirty
                    || _lastPaymentBuydownSubsidyAmount.Dirty
                    || _lastPaymentEscrowAmount.Dirty
                    || _lastPaymentEscrowCityPropertyTax.Dirty
                    || _lastPaymentEscrowFloodInsurance.Dirty
                    || _lastPaymentEscrowHazardInsurance.Dirty
                    || _lastPaymentEscrowMortgageInsurance.Dirty
                    || _lastPaymentEscrowOther1.Dirty
                    || _lastPaymentEscrowOther2.Dirty
                    || _lastPaymentEscrowOther3.Dirty
                    || _lastPaymentEscrowTax.Dirty
                    || _lastPaymentEscrowUSDAMonthlyPremium.Dirty
                    || _lastPaymentGuid.Dirty
                    || _lastPaymentInterest.Dirty
                    || _lastPaymentLateFee.Dirty
                    || _lastPaymentMiscFee.Dirty
                    || _lastPaymentNumber.Dirty
                    || _lastPaymentPrincipal.Dirty
                    || _lastPaymentPrincipalAndInterest.Dirty
                    || _lastPaymentReceivedDate.Dirty
                    || _lastPaymentStatementDate.Dirty
                    || _lastPaymentTotalAmountReceived.Dirty
                    || _lastStatementPrintedDate.Dirty
                    || _loanSnapshotXml.Dirty
                    || _mailingCity.Dirty
                    || _mailingPostalCode.Dirty
                    || _mailingState.Dirty
                    || _mailingStreetAddress.Dirty
                    || _mortgageAccount.Dirty
                    || _nextEscrowTotalFloodInsurance.Dirty
                    || _nextEscrowTotalFloodInsuranceDueDate.Dirty
                    || _nextEscrowTotalHazardInsurance.Dirty
                    || _nextEscrowTotalHazardInsuranceDueDate.Dirty
                    || _nextEscrowTotalMortgageInsurance.Dirty
                    || _nextEscrowTotalMortgageInsuranceDueDate.Dirty
                    || _nextEscrowTotalOtherTax1.Dirty
                    || _nextEscrowTotalOtherTax1DueDate.Dirty
                    || _nextEscrowTotalOtherTax2.Dirty
                    || _nextEscrowTotalOtherTax2DueDate.Dirty
                    || _nextEscrowTotalOtherTax3.Dirty
                    || _nextEscrowTotalOtherTax3DueDate.Dirty
                    || _nextEscrowTotalPropertyTax.Dirty
                    || _nextEscrowTotalPropertyTaxDueDate.Dirty
                    || _nextEscrowTotalTax.Dirty
                    || _nextEscrowTotalTaxDueDate.Dirty
                    || _nextEscrowTotalUsdaMonthlyPremium.Dirty
                    || _nextEscrowTotalUsdaMonthlyPremiumDueDate.Dirty
                    || _nextPaymentBuydownSubsidyAmount.Dirty
                    || _nextPaymentEscrowAmount.Dirty
                    || _nextPaymentEscrowCityPropertyTax.Dirty
                    || _nextPaymentEscrowFloodInsurance.Dirty
                    || _nextPaymentEscrowHazardInsurance.Dirty
                    || _nextPaymentEscrowMortgageInsurance.Dirty
                    || _nextPaymentEscrowOther1.Dirty
                    || _nextPaymentEscrowOther2.Dirty
                    || _nextPaymentEscrowOther3.Dirty
                    || _nextPaymentEscrowTax.Dirty
                    || _nextPaymentEscrowUSDAMonthlyPremium.Dirty
                    || _nextPaymentIndexCurrentValuePercent.Dirty
                    || _nextPaymentInterest.Dirty
                    || _nextPaymentLateFee.Dirty
                    || _nextPaymentLatePaymentDate.Dirty
                    || _nextPaymentMiscFee.Dirty
                    || _nextPaymentPastDueAmount.Dirty
                    || _nextPaymentPaymentDueDate.Dirty
                    || _nextPaymentPaymentIndexDate.Dirty
                    || _nextPaymentPrincipal.Dirty
                    || _nextPaymentPrincipalAndInterest.Dirty
                    || _nextPaymentRequestedInterestRatePercent.Dirty
                    || _nextPaymentStatementDueDate.Dirty
                    || _nextPaymentTotalAmountDue.Dirty
                    || _nextPaymentTotalAmountWithLateFee.Dirty
                    || _nextPaymentUnpaidLateFee.Dirty
                    || _numberOfDisbursement.Dirty
                    || _paymentDueDatePrinted.Dirty
                    || _printedByUserId.Dirty
                    || _printedByUserName.Dirty
                    || _purchasedPrincipal.Dirty
                    || _servicerLoanNumber.Dirty
                    || _servicingStatus.Dirty
                    || _servicingTransferDate.Dirty
                    || _subServicer.Dirty
                    || _subServicerLoanNumber.Dirty
                    || _totalAdditionalEscrow.Dirty
                    || _totalAdditionalEscrowYearToDate.Dirty
                    || _totalAdditionalPrincipal.Dirty
                    || _totalAdditionalPrincipalYearToDate.Dirty
                    || _totalAmountDisbursed.Dirty
                    || _totalBuydownSubsidyAmount.Dirty
                    || _totalBuydownSubsidyAmountYearToDate.Dirty
                    || _totalEscrow.Dirty
                    || _totalEscrowYearToDate.Dirty
                    || _totalHazardInsurance.Dirty
                    || _totalInterest.Dirty
                    || _totalInterestYearToDate.Dirty
                    || _totalLateFee.Dirty
                    || _totalLateFeeYearToDate.Dirty
                    || _totalMiscFee.Dirty
                    || _totalMiscFeeYearToDate.Dirty
                    || _totalMortgageInsurance.Dirty
                    || _totalNumberOfLatePayment.Dirty
                    || _totalNumberOfPayment.Dirty
                    || _totalOtherTaxes.Dirty
                    || _totalPAndI.Dirty
                    || _totalPAndIYearToDate.Dirty
                    || _totalPaymentCollected.Dirty
                    || _totalPaymentCollectedYearToDate.Dirty
                    || _totalPrincipal.Dirty
                    || _totalPrincipalYearToDate.Dirty
                    || _totalTaxes.Dirty
                    || _totalUsdaMonthlyPremium.Dirty
                    || _unpaidBuydownSubsidyAmount.Dirty
                    || _unpaidEscrow.Dirty
                    || _unpaidEscrowCityPropertyTax.Dirty
                    || _unpaidEscrowFloodInsurance.Dirty
                    || _unpaidEscrowHazardInsurance.Dirty
                    || _unpaidEscrowMortgageInsurance.Dirty
                    || _unpaidEscrowOther1.Dirty
                    || _unpaidEscrowOther2.Dirty
                    || _unpaidEscrowOther3.Dirty
                    || _unpaidEscrowTax.Dirty
                    || _unpaidEscrowUSDAMonthlyPremium.Dirty
                    || _unpaidInterest.Dirty
                    || _unpaidLateFee.Dirty
                    || _unpaidMiscrFee.Dirty
                    || _unpaidPrincipal.Dirty
                    || _escrowDisbursementTransactions?.Dirty == true
                    || _escrowInterestTransactions?.Dirty == true
                    || _interimServicingTransactions?.Dirty == true
                    || _lastScheduledPayment?.Dirty == true
                    || _nextScheduledPayment?.Dirty == true
                    || _otherTransactions?.Dirty == true
                    || _paymentReversalTransactions?.Dirty == true
                    || _paymentTransactions?.Dirty == true
                    || _scheduledPayments?.Dirty == true
                    || _schedulePaymentTransactions?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _beginningBalance.Dirty = value;
                _borrCellPhoneNumber.Dirty = value;
                _borrHomeEmail.Dirty = value;
                _borrHomePhoneNumber.Dirty = value;
                _borrowerFirstName.Dirty = value;
                _borrowerLastName.Dirty = value;
                _borrWorkPhoneNumber.Dirty = value;
                _calcTriggered.Dirty = value;
                _cityInsurance.Dirty = value;
                _comments.Dirty = value;
                _currentPrincipalBalance.Dirty = value;
                _escrowBalance.Dirty = value;
                _floodInsurance.Dirty = value;
                _id.Dirty = value;
                _lastPaymentAdditionalEscrow.Dirty = value;
                _lastPaymentAdditionalPrincipal.Dirty = value;
                _lastPaymentBuydownSubsidyAmount.Dirty = value;
                _lastPaymentEscrowAmount.Dirty = value;
                _lastPaymentEscrowCityPropertyTax.Dirty = value;
                _lastPaymentEscrowFloodInsurance.Dirty = value;
                _lastPaymentEscrowHazardInsurance.Dirty = value;
                _lastPaymentEscrowMortgageInsurance.Dirty = value;
                _lastPaymentEscrowOther1.Dirty = value;
                _lastPaymentEscrowOther2.Dirty = value;
                _lastPaymentEscrowOther3.Dirty = value;
                _lastPaymentEscrowTax.Dirty = value;
                _lastPaymentEscrowUSDAMonthlyPremium.Dirty = value;
                _lastPaymentGuid.Dirty = value;
                _lastPaymentInterest.Dirty = value;
                _lastPaymentLateFee.Dirty = value;
                _lastPaymentMiscFee.Dirty = value;
                _lastPaymentNumber.Dirty = value;
                _lastPaymentPrincipal.Dirty = value;
                _lastPaymentPrincipalAndInterest.Dirty = value;
                _lastPaymentReceivedDate.Dirty = value;
                _lastPaymentStatementDate.Dirty = value;
                _lastPaymentTotalAmountReceived.Dirty = value;
                _lastStatementPrintedDate.Dirty = value;
                _loanSnapshotXml.Dirty = value;
                _mailingCity.Dirty = value;
                _mailingPostalCode.Dirty = value;
                _mailingState.Dirty = value;
                _mailingStreetAddress.Dirty = value;
                _mortgageAccount.Dirty = value;
                _nextEscrowTotalFloodInsurance.Dirty = value;
                _nextEscrowTotalFloodInsuranceDueDate.Dirty = value;
                _nextEscrowTotalHazardInsurance.Dirty = value;
                _nextEscrowTotalHazardInsuranceDueDate.Dirty = value;
                _nextEscrowTotalMortgageInsurance.Dirty = value;
                _nextEscrowTotalMortgageInsuranceDueDate.Dirty = value;
                _nextEscrowTotalOtherTax1.Dirty = value;
                _nextEscrowTotalOtherTax1DueDate.Dirty = value;
                _nextEscrowTotalOtherTax2.Dirty = value;
                _nextEscrowTotalOtherTax2DueDate.Dirty = value;
                _nextEscrowTotalOtherTax3.Dirty = value;
                _nextEscrowTotalOtherTax3DueDate.Dirty = value;
                _nextEscrowTotalPropertyTax.Dirty = value;
                _nextEscrowTotalPropertyTaxDueDate.Dirty = value;
                _nextEscrowTotalTax.Dirty = value;
                _nextEscrowTotalTaxDueDate.Dirty = value;
                _nextEscrowTotalUsdaMonthlyPremium.Dirty = value;
                _nextEscrowTotalUsdaMonthlyPremiumDueDate.Dirty = value;
                _nextPaymentBuydownSubsidyAmount.Dirty = value;
                _nextPaymentEscrowAmount.Dirty = value;
                _nextPaymentEscrowCityPropertyTax.Dirty = value;
                _nextPaymentEscrowFloodInsurance.Dirty = value;
                _nextPaymentEscrowHazardInsurance.Dirty = value;
                _nextPaymentEscrowMortgageInsurance.Dirty = value;
                _nextPaymentEscrowOther1.Dirty = value;
                _nextPaymentEscrowOther2.Dirty = value;
                _nextPaymentEscrowOther3.Dirty = value;
                _nextPaymentEscrowTax.Dirty = value;
                _nextPaymentEscrowUSDAMonthlyPremium.Dirty = value;
                _nextPaymentIndexCurrentValuePercent.Dirty = value;
                _nextPaymentInterest.Dirty = value;
                _nextPaymentLateFee.Dirty = value;
                _nextPaymentLatePaymentDate.Dirty = value;
                _nextPaymentMiscFee.Dirty = value;
                _nextPaymentPastDueAmount.Dirty = value;
                _nextPaymentPaymentDueDate.Dirty = value;
                _nextPaymentPaymentIndexDate.Dirty = value;
                _nextPaymentPrincipal.Dirty = value;
                _nextPaymentPrincipalAndInterest.Dirty = value;
                _nextPaymentRequestedInterestRatePercent.Dirty = value;
                _nextPaymentStatementDueDate.Dirty = value;
                _nextPaymentTotalAmountDue.Dirty = value;
                _nextPaymentTotalAmountWithLateFee.Dirty = value;
                _nextPaymentUnpaidLateFee.Dirty = value;
                _numberOfDisbursement.Dirty = value;
                _paymentDueDatePrinted.Dirty = value;
                _printedByUserId.Dirty = value;
                _printedByUserName.Dirty = value;
                _purchasedPrincipal.Dirty = value;
                _servicerLoanNumber.Dirty = value;
                _servicingStatus.Dirty = value;
                _servicingTransferDate.Dirty = value;
                _subServicer.Dirty = value;
                _subServicerLoanNumber.Dirty = value;
                _totalAdditionalEscrow.Dirty = value;
                _totalAdditionalEscrowYearToDate.Dirty = value;
                _totalAdditionalPrincipal.Dirty = value;
                _totalAdditionalPrincipalYearToDate.Dirty = value;
                _totalAmountDisbursed.Dirty = value;
                _totalBuydownSubsidyAmount.Dirty = value;
                _totalBuydownSubsidyAmountYearToDate.Dirty = value;
                _totalEscrow.Dirty = value;
                _totalEscrowYearToDate.Dirty = value;
                _totalHazardInsurance.Dirty = value;
                _totalInterest.Dirty = value;
                _totalInterestYearToDate.Dirty = value;
                _totalLateFee.Dirty = value;
                _totalLateFeeYearToDate.Dirty = value;
                _totalMiscFee.Dirty = value;
                _totalMiscFeeYearToDate.Dirty = value;
                _totalMortgageInsurance.Dirty = value;
                _totalNumberOfLatePayment.Dirty = value;
                _totalNumberOfPayment.Dirty = value;
                _totalOtherTaxes.Dirty = value;
                _totalPAndI.Dirty = value;
                _totalPAndIYearToDate.Dirty = value;
                _totalPaymentCollected.Dirty = value;
                _totalPaymentCollectedYearToDate.Dirty = value;
                _totalPrincipal.Dirty = value;
                _totalPrincipalYearToDate.Dirty = value;
                _totalTaxes.Dirty = value;
                _totalUsdaMonthlyPremium.Dirty = value;
                _unpaidBuydownSubsidyAmount.Dirty = value;
                _unpaidEscrow.Dirty = value;
                _unpaidEscrowCityPropertyTax.Dirty = value;
                _unpaidEscrowFloodInsurance.Dirty = value;
                _unpaidEscrowHazardInsurance.Dirty = value;
                _unpaidEscrowMortgageInsurance.Dirty = value;
                _unpaidEscrowOther1.Dirty = value;
                _unpaidEscrowOther2.Dirty = value;
                _unpaidEscrowOther3.Dirty = value;
                _unpaidEscrowTax.Dirty = value;
                _unpaidEscrowUSDAMonthlyPremium.Dirty = value;
                _unpaidInterest.Dirty = value;
                _unpaidLateFee.Dirty = value;
                _unpaidMiscrFee.Dirty = value;
                _unpaidPrincipal.Dirty = value;
                if (_escrowDisbursementTransactions != null) _escrowDisbursementTransactions.Dirty = value;
                if (_escrowInterestTransactions != null) _escrowInterestTransactions.Dirty = value;
                if (_interimServicingTransactions != null) _interimServicingTransactions.Dirty = value;
                if (_lastScheduledPayment != null) _lastScheduledPayment.Dirty = value;
                if (_nextScheduledPayment != null) _nextScheduledPayment.Dirty = value;
                if (_otherTransactions != null) _otherTransactions.Dirty = value;
                if (_paymentReversalTransactions != null) _paymentReversalTransactions.Dirty = value;
                if (_paymentTransactions != null) _paymentTransactions.Dirty = value;
                if (_scheduledPayments != null) _scheduledPayments.Dirty = value;
                if (_schedulePaymentTransactions != null) _schedulePaymentTransactions.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}