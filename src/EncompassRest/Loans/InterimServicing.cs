using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicing : IClean
    {
        private Value<decimal?> _beginningBalance;
        public decimal? BeginningBalance { get { return _beginningBalance; } set { _beginningBalance = value; } }
        private Value<string> _borrCellPhoneNumber;
        public string BorrCellPhoneNumber { get { return _borrCellPhoneNumber; } set { _borrCellPhoneNumber = value; } }
        private Value<string> _borrHomeEmail;
        public string BorrHomeEmail { get { return _borrHomeEmail; } set { _borrHomeEmail = value; } }
        private Value<string> _borrHomePhoneNumber;
        public string BorrHomePhoneNumber { get { return _borrHomePhoneNumber; } set { _borrHomePhoneNumber = value; } }
        private Value<string> _borrowerFirstName;
        public string BorrowerFirstName { get { return _borrowerFirstName; } set { _borrowerFirstName = value; } }
        private Value<string> _borrowerLastName;
        public string BorrowerLastName { get { return _borrowerLastName; } set { _borrowerLastName = value; } }
        private Value<string> _borrWorkPhoneNumber;
        public string BorrWorkPhoneNumber { get { return _borrWorkPhoneNumber; } set { _borrWorkPhoneNumber = value; } }
        private Value<string> _calcTriggered;
        public string CalcTriggered { get { return _calcTriggered; } set { _calcTriggered = value; } }
        private Value<decimal?> _cityInsurance;
        public decimal? CityInsurance { get { return _cityInsurance; } set { _cityInsurance = value; } }
        private Value<string> _comments;
        public string Comments { get { return _comments; } set { _comments = value; } }
        private Value<decimal?> _currentPrincipalBalance;
        public decimal? CurrentPrincipalBalance { get { return _currentPrincipalBalance; } set { _currentPrincipalBalance = value; } }
        private Value<decimal?> _escrowBalance;
        public decimal? EscrowBalance { get { return _escrowBalance; } set { _escrowBalance = value; } }
        private Value<List<EscrowDisbursementTransaction>> _escrowDisbursementTransactions;
        public List<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get { return _escrowDisbursementTransactions; } set { _escrowDisbursementTransactions = value; } }
        private Value<List<EscrowInterestTransaction>> _escrowInterestTransactions;
        public List<EscrowInterestTransaction> EscrowInterestTransactions { get { return _escrowInterestTransactions; } set { _escrowInterestTransactions = value; } }
        private Value<decimal?> _floodInsurance;
        public decimal? FloodInsurance { get { return _floodInsurance; } set { _floodInsurance = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<List<InterimServicingTransaction>> _interimServicingTransactions;
        public List<InterimServicingTransaction> InterimServicingTransactions { get { return _interimServicingTransactions; } set { _interimServicingTransactions = value; } }
        private Value<decimal?> _lastPaymentAdditionalEscrow;
        public decimal? LastPaymentAdditionalEscrow { get { return _lastPaymentAdditionalEscrow; } set { _lastPaymentAdditionalEscrow = value; } }
        private Value<decimal?> _lastPaymentAdditionalPrincipal;
        public decimal? LastPaymentAdditionalPrincipal { get { return _lastPaymentAdditionalPrincipal; } set { _lastPaymentAdditionalPrincipal = value; } }
        private Value<decimal?> _lastPaymentBuydownSubsidyAmount;
        public decimal? LastPaymentBuydownSubsidyAmount { get { return _lastPaymentBuydownSubsidyAmount; } set { _lastPaymentBuydownSubsidyAmount = value; } }
        private Value<decimal?> _lastPaymentEscrowAmount;
        public decimal? LastPaymentEscrowAmount { get { return _lastPaymentEscrowAmount; } set { _lastPaymentEscrowAmount = value; } }
        private Value<decimal?> _lastPaymentEscrowCityPropertyTax;
        public decimal? LastPaymentEscrowCityPropertyTax { get { return _lastPaymentEscrowCityPropertyTax; } set { _lastPaymentEscrowCityPropertyTax = value; } }
        private Value<decimal?> _lastPaymentEscrowFloodInsurance;
        public decimal? LastPaymentEscrowFloodInsurance { get { return _lastPaymentEscrowFloodInsurance; } set { _lastPaymentEscrowFloodInsurance = value; } }
        private Value<decimal?> _lastPaymentEscrowHazardInsurance;
        public decimal? LastPaymentEscrowHazardInsurance { get { return _lastPaymentEscrowHazardInsurance; } set { _lastPaymentEscrowHazardInsurance = value; } }
        private Value<decimal?> _lastPaymentEscrowMortgageInsurance;
        public decimal? LastPaymentEscrowMortgageInsurance { get { return _lastPaymentEscrowMortgageInsurance; } set { _lastPaymentEscrowMortgageInsurance = value; } }
        private Value<decimal?> _lastPaymentEscrowOther1;
        public decimal? LastPaymentEscrowOther1 { get { return _lastPaymentEscrowOther1; } set { _lastPaymentEscrowOther1 = value; } }
        private Value<decimal?> _lastPaymentEscrowOther2;
        public decimal? LastPaymentEscrowOther2 { get { return _lastPaymentEscrowOther2; } set { _lastPaymentEscrowOther2 = value; } }
        private Value<decimal?> _lastPaymentEscrowOther3;
        public decimal? LastPaymentEscrowOther3 { get { return _lastPaymentEscrowOther3; } set { _lastPaymentEscrowOther3 = value; } }
        private Value<decimal?> _lastPaymentEscrowTax;
        public decimal? LastPaymentEscrowTax { get { return _lastPaymentEscrowTax; } set { _lastPaymentEscrowTax = value; } }
        private Value<decimal?> _lastPaymentEscrowUSDAMonthlyPremium;
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get { return _lastPaymentEscrowUSDAMonthlyPremium; } set { _lastPaymentEscrowUSDAMonthlyPremium = value; } }
        private Value<string> _lastPaymentGuid;
        public string LastPaymentGuid { get { return _lastPaymentGuid; } set { _lastPaymentGuid = value; } }
        private Value<decimal?> _lastPaymentInterest;
        public decimal? LastPaymentInterest { get { return _lastPaymentInterest; } set { _lastPaymentInterest = value; } }
        private Value<decimal?> _lastPaymentLateFee;
        public decimal? LastPaymentLateFee { get { return _lastPaymentLateFee; } set { _lastPaymentLateFee = value; } }
        private Value<decimal?> _lastPaymentMiscFee;
        public decimal? LastPaymentMiscFee { get { return _lastPaymentMiscFee; } set { _lastPaymentMiscFee = value; } }
        private Value<int?> _lastPaymentNumber;
        public int? LastPaymentNumber { get { return _lastPaymentNumber; } set { _lastPaymentNumber = value; } }
        private Value<decimal?> _lastPaymentPrincipal;
        public decimal? LastPaymentPrincipal { get { return _lastPaymentPrincipal; } set { _lastPaymentPrincipal = value; } }
        private Value<decimal?> _lastPaymentPrincipalAndInterest;
        public decimal? LastPaymentPrincipalAndInterest { get { return _lastPaymentPrincipalAndInterest; } set { _lastPaymentPrincipalAndInterest = value; } }
        private Value<DateTime?> _lastPaymentReceivedDate;
        public DateTime? LastPaymentReceivedDate { get { return _lastPaymentReceivedDate; } set { _lastPaymentReceivedDate = value; } }
        private Value<DateTime?> _lastPaymentStatementDate;
        public DateTime? LastPaymentStatementDate { get { return _lastPaymentStatementDate; } set { _lastPaymentStatementDate = value; } }
        private Value<decimal?> _lastPaymentTotalAmountReceived;
        public decimal? LastPaymentTotalAmountReceived { get { return _lastPaymentTotalAmountReceived; } set { _lastPaymentTotalAmountReceived = value; } }
        public SchedulePaymentTransaction LastScheduledPayment { get; set; }
        private Value<DateTime?> _lastStatementPrintedDate;
        public DateTime? LastStatementPrintedDate { get { return _lastStatementPrintedDate; } set { _lastStatementPrintedDate = value; } }
        private Value<string> _loanSnapshotXml;
        public string LoanSnapshotXml { get { return _loanSnapshotXml; } set { _loanSnapshotXml = value; } }
        private Value<string> _mailingCity;
        public string MailingCity { get { return _mailingCity; } set { _mailingCity = value; } }
        private Value<string> _mailingPostalCode;
        public string MailingPostalCode { get { return _mailingPostalCode; } set { _mailingPostalCode = value; } }
        private Value<string> _mailingState;
        public string MailingState { get { return _mailingState; } set { _mailingState = value; } }
        private Value<string> _mailingStreetAddress;
        public string MailingStreetAddress { get { return _mailingStreetAddress; } set { _mailingStreetAddress = value; } }
        private Value<string> _mortgageAccount;
        public string MortgageAccount { get { return _mortgageAccount; } set { _mortgageAccount = value; } }
        private Value<decimal?> _nextEscrowTotalFloodInsurance;
        public decimal? NextEscrowTotalFloodInsurance { get { return _nextEscrowTotalFloodInsurance; } set { _nextEscrowTotalFloodInsurance = value; } }
        private Value<DateTime?> _nextEscrowTotalFloodInsuranceDueDate;
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get { return _nextEscrowTotalFloodInsuranceDueDate; } set { _nextEscrowTotalFloodInsuranceDueDate = value; } }
        private Value<decimal?> _nextEscrowTotalHazardInsurance;
        public decimal? NextEscrowTotalHazardInsurance { get { return _nextEscrowTotalHazardInsurance; } set { _nextEscrowTotalHazardInsurance = value; } }
        private Value<DateTime?> _nextEscrowTotalHazardInsuranceDueDate;
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get { return _nextEscrowTotalHazardInsuranceDueDate; } set { _nextEscrowTotalHazardInsuranceDueDate = value; } }
        private Value<decimal?> _nextEscrowTotalMortgageInsurance;
        public decimal? NextEscrowTotalMortgageInsurance { get { return _nextEscrowTotalMortgageInsurance; } set { _nextEscrowTotalMortgageInsurance = value; } }
        private Value<DateTime?> _nextEscrowTotalMortgageInsuranceDueDate;
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get { return _nextEscrowTotalMortgageInsuranceDueDate; } set { _nextEscrowTotalMortgageInsuranceDueDate = value; } }
        private Value<decimal?> _nextEscrowTotalOtherTax1;
        public decimal? NextEscrowTotalOtherTax1 { get { return _nextEscrowTotalOtherTax1; } set { _nextEscrowTotalOtherTax1 = value; } }
        private Value<DateTime?> _nextEscrowTotalOtherTax1DueDate;
        public DateTime? NextEscrowTotalOtherTax1DueDate { get { return _nextEscrowTotalOtherTax1DueDate; } set { _nextEscrowTotalOtherTax1DueDate = value; } }
        private Value<decimal?> _nextEscrowTotalOtherTax2;
        public decimal? NextEscrowTotalOtherTax2 { get { return _nextEscrowTotalOtherTax2; } set { _nextEscrowTotalOtherTax2 = value; } }
        private Value<DateTime?> _nextEscrowTotalOtherTax2DueDate;
        public DateTime? NextEscrowTotalOtherTax2DueDate { get { return _nextEscrowTotalOtherTax2DueDate; } set { _nextEscrowTotalOtherTax2DueDate = value; } }
        private Value<decimal?> _nextEscrowTotalOtherTax3;
        public decimal? NextEscrowTotalOtherTax3 { get { return _nextEscrowTotalOtherTax3; } set { _nextEscrowTotalOtherTax3 = value; } }
        private Value<DateTime?> _nextEscrowTotalOtherTax3DueDate;
        public DateTime? NextEscrowTotalOtherTax3DueDate { get { return _nextEscrowTotalOtherTax3DueDate; } set { _nextEscrowTotalOtherTax3DueDate = value; } }
        private Value<decimal?> _nextEscrowTotalPropertyTax;
        public decimal? NextEscrowTotalPropertyTax { get { return _nextEscrowTotalPropertyTax; } set { _nextEscrowTotalPropertyTax = value; } }
        private Value<DateTime?> _nextEscrowTotalPropertyTaxDueDate;
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get { return _nextEscrowTotalPropertyTaxDueDate; } set { _nextEscrowTotalPropertyTaxDueDate = value; } }
        private Value<decimal?> _nextEscrowTotalTax;
        public decimal? NextEscrowTotalTax { get { return _nextEscrowTotalTax; } set { _nextEscrowTotalTax = value; } }
        private Value<DateTime?> _nextEscrowTotalTaxDueDate;
        public DateTime? NextEscrowTotalTaxDueDate { get { return _nextEscrowTotalTaxDueDate; } set { _nextEscrowTotalTaxDueDate = value; } }
        private Value<decimal?> _nextEscrowTotalUsdaMonthlyPremium;
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get { return _nextEscrowTotalUsdaMonthlyPremium; } set { _nextEscrowTotalUsdaMonthlyPremium = value; } }
        private Value<DateTime?> _nextEscrowTotalUsdaMonthlyPremiumDueDate;
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get { return _nextEscrowTotalUsdaMonthlyPremiumDueDate; } set { _nextEscrowTotalUsdaMonthlyPremiumDueDate = value; } }
        private Value<decimal?> _nextPaymentBuydownSubsidyAmount;
        public decimal? NextPaymentBuydownSubsidyAmount { get { return _nextPaymentBuydownSubsidyAmount; } set { _nextPaymentBuydownSubsidyAmount = value; } }
        private Value<decimal?> _nextPaymentEscrowAmount;
        public decimal? NextPaymentEscrowAmount { get { return _nextPaymentEscrowAmount; } set { _nextPaymentEscrowAmount = value; } }
        private Value<decimal?> _nextPaymentEscrowCityPropertyTax;
        public decimal? NextPaymentEscrowCityPropertyTax { get { return _nextPaymentEscrowCityPropertyTax; } set { _nextPaymentEscrowCityPropertyTax = value; } }
        private Value<decimal?> _nextPaymentEscrowFloodInsurance;
        public decimal? NextPaymentEscrowFloodInsurance { get { return _nextPaymentEscrowFloodInsurance; } set { _nextPaymentEscrowFloodInsurance = value; } }
        private Value<decimal?> _nextPaymentEscrowHazardInsurance;
        public decimal? NextPaymentEscrowHazardInsurance { get { return _nextPaymentEscrowHazardInsurance; } set { _nextPaymentEscrowHazardInsurance = value; } }
        private Value<decimal?> _nextPaymentEscrowMortgageInsurance;
        public decimal? NextPaymentEscrowMortgageInsurance { get { return _nextPaymentEscrowMortgageInsurance; } set { _nextPaymentEscrowMortgageInsurance = value; } }
        private Value<decimal?> _nextPaymentEscrowOther1;
        public decimal? NextPaymentEscrowOther1 { get { return _nextPaymentEscrowOther1; } set { _nextPaymentEscrowOther1 = value; } }
        private Value<decimal?> _nextPaymentEscrowOther2;
        public decimal? NextPaymentEscrowOther2 { get { return _nextPaymentEscrowOther2; } set { _nextPaymentEscrowOther2 = value; } }
        private Value<decimal?> _nextPaymentEscrowOther3;
        public decimal? NextPaymentEscrowOther3 { get { return _nextPaymentEscrowOther3; } set { _nextPaymentEscrowOther3 = value; } }
        private Value<decimal?> _nextPaymentEscrowTax;
        public decimal? NextPaymentEscrowTax { get { return _nextPaymentEscrowTax; } set { _nextPaymentEscrowTax = value; } }
        private Value<decimal?> _nextPaymentEscrowUSDAMonthlyPremium;
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get { return _nextPaymentEscrowUSDAMonthlyPremium; } set { _nextPaymentEscrowUSDAMonthlyPremium = value; } }
        private Value<decimal?> _nextPaymentIndexCurrentValuePercent;
        public decimal? NextPaymentIndexCurrentValuePercent { get { return _nextPaymentIndexCurrentValuePercent; } set { _nextPaymentIndexCurrentValuePercent = value; } }
        private Value<decimal?> _nextPaymentInterest;
        public decimal? NextPaymentInterest { get { return _nextPaymentInterest; } set { _nextPaymentInterest = value; } }
        private Value<decimal?> _nextPaymentLateFee;
        public decimal? NextPaymentLateFee { get { return _nextPaymentLateFee; } set { _nextPaymentLateFee = value; } }
        private Value<DateTime?> _nextPaymentLatePaymentDate;
        public DateTime? NextPaymentLatePaymentDate { get { return _nextPaymentLatePaymentDate; } set { _nextPaymentLatePaymentDate = value; } }
        private Value<decimal?> _nextPaymentMiscFee;
        public decimal? NextPaymentMiscFee { get { return _nextPaymentMiscFee; } set { _nextPaymentMiscFee = value; } }
        private Value<decimal?> _nextPaymentPastDueAmount;
        public decimal? NextPaymentPastDueAmount { get { return _nextPaymentPastDueAmount; } set { _nextPaymentPastDueAmount = value; } }
        private Value<DateTime?> _nextPaymentPaymentDueDate;
        public DateTime? NextPaymentPaymentDueDate { get { return _nextPaymentPaymentDueDate; } set { _nextPaymentPaymentDueDate = value; } }
        private Value<DateTime?> _nextPaymentPaymentIndexDate;
        public DateTime? NextPaymentPaymentIndexDate { get { return _nextPaymentPaymentIndexDate; } set { _nextPaymentPaymentIndexDate = value; } }
        private Value<decimal?> _nextPaymentPrincipal;
        public decimal? NextPaymentPrincipal { get { return _nextPaymentPrincipal; } set { _nextPaymentPrincipal = value; } }
        private Value<decimal?> _nextPaymentPrincipalAndInterest;
        public decimal? NextPaymentPrincipalAndInterest { get { return _nextPaymentPrincipalAndInterest; } set { _nextPaymentPrincipalAndInterest = value; } }
        private Value<decimal?> _nextPaymentRequestedInterestRatePercent;
        public decimal? NextPaymentRequestedInterestRatePercent { get { return _nextPaymentRequestedInterestRatePercent; } set { _nextPaymentRequestedInterestRatePercent = value; } }
        private Value<DateTime?> _nextPaymentStatementDueDate;
        public DateTime? NextPaymentStatementDueDate { get { return _nextPaymentStatementDueDate; } set { _nextPaymentStatementDueDate = value; } }
        private Value<decimal?> _nextPaymentTotalAmountDue;
        public decimal? NextPaymentTotalAmountDue { get { return _nextPaymentTotalAmountDue; } set { _nextPaymentTotalAmountDue = value; } }
        private Value<decimal?> _nextPaymentTotalAmountWithLateFee;
        public decimal? NextPaymentTotalAmountWithLateFee { get { return _nextPaymentTotalAmountWithLateFee; } set { _nextPaymentTotalAmountWithLateFee = value; } }
        private Value<decimal?> _nextPaymentUnpaidLateFee;
        public decimal? NextPaymentUnpaidLateFee { get { return _nextPaymentUnpaidLateFee; } set { _nextPaymentUnpaidLateFee = value; } }
        public SchedulePaymentTransaction NextScheduledPayment { get; set; }
        private Value<int?> _numberOfDisbursement;
        public int? NumberOfDisbursement { get { return _numberOfDisbursement; } set { _numberOfDisbursement = value; } }
        private Value<List<OtherTransaction>> _otherTransactions;
        public List<OtherTransaction> OtherTransactions { get { return _otherTransactions; } set { _otherTransactions = value; } }
        private Value<DateTime?> _paymentDueDatePrinted;
        public DateTime? PaymentDueDatePrinted { get { return _paymentDueDatePrinted; } set { _paymentDueDatePrinted = value; } }
        private Value<List<PaymentReversalTransaction>> _paymentReversalTransactions;
        public List<PaymentReversalTransaction> PaymentReversalTransactions { get { return _paymentReversalTransactions; } set { _paymentReversalTransactions = value; } }
        private Value<List<PaymentTransaction>> _paymentTransactions;
        public List<PaymentTransaction> PaymentTransactions { get { return _paymentTransactions; } set { _paymentTransactions = value; } }
        private Value<string> _printedByUserId;
        public string PrintedByUserId { get { return _printedByUserId; } set { _printedByUserId = value; } }
        private Value<string> _printedByUserName;
        public string PrintedByUserName { get { return _printedByUserName; } set { _printedByUserName = value; } }
        private Value<decimal?> _purchasedPrincipal;
        public decimal? PurchasedPrincipal { get { return _purchasedPrincipal; } set { _purchasedPrincipal = value; } }
        private Value<List<SchedulePaymentTransaction>> _scheduledPayments;
        public List<SchedulePaymentTransaction> ScheduledPayments { get { return _scheduledPayments; } set { _scheduledPayments = value; } }
        private Value<List<SchedulePaymentTransaction>> _schedulePaymentTransactions;
        public List<SchedulePaymentTransaction> SchedulePaymentTransactions { get { return _schedulePaymentTransactions; } set { _schedulePaymentTransactions = value; } }
        private Value<string> _servicerLoanNumber;
        public string ServicerLoanNumber { get { return _servicerLoanNumber; } set { _servicerLoanNumber = value; } }
        private Value<string> _servicingStatus;
        public string ServicingStatus { get { return _servicingStatus; } set { _servicingStatus = value; } }
        private Value<DateTime?> _servicingTransferDate;
        public DateTime? ServicingTransferDate { get { return _servicingTransferDate; } set { _servicingTransferDate = value; } }
        private Value<string> _subServicer;
        public string SubServicer { get { return _subServicer; } set { _subServicer = value; } }
        private Value<string> _subServicerLoanNumber;
        public string SubServicerLoanNumber { get { return _subServicerLoanNumber; } set { _subServicerLoanNumber = value; } }
        private Value<decimal?> _totalAdditionalEscrow;
        public decimal? TotalAdditionalEscrow { get { return _totalAdditionalEscrow; } set { _totalAdditionalEscrow = value; } }
        private Value<decimal?> _totalAdditionalEscrowYearToDate;
        public decimal? TotalAdditionalEscrowYearToDate { get { return _totalAdditionalEscrowYearToDate; } set { _totalAdditionalEscrowYearToDate = value; } }
        private Value<decimal?> _totalAdditionalPrincipal;
        public decimal? TotalAdditionalPrincipal { get { return _totalAdditionalPrincipal; } set { _totalAdditionalPrincipal = value; } }
        private Value<decimal?> _totalAdditionalPrincipalYearToDate;
        public decimal? TotalAdditionalPrincipalYearToDate { get { return _totalAdditionalPrincipalYearToDate; } set { _totalAdditionalPrincipalYearToDate = value; } }
        private Value<decimal?> _totalAmountDisbursed;
        public decimal? TotalAmountDisbursed { get { return _totalAmountDisbursed; } set { _totalAmountDisbursed = value; } }
        private Value<decimal?> _totalBuydownSubsidyAmount;
        public decimal? TotalBuydownSubsidyAmount { get { return _totalBuydownSubsidyAmount; } set { _totalBuydownSubsidyAmount = value; } }
        private Value<decimal?> _totalBuydownSubsidyAmountYearToDate;
        public decimal? TotalBuydownSubsidyAmountYearToDate { get { return _totalBuydownSubsidyAmountYearToDate; } set { _totalBuydownSubsidyAmountYearToDate = value; } }
        private Value<decimal?> _totalEscrow;
        public decimal? TotalEscrow { get { return _totalEscrow; } set { _totalEscrow = value; } }
        private Value<decimal?> _totalEscrowYearToDate;
        public decimal? TotalEscrowYearToDate { get { return _totalEscrowYearToDate; } set { _totalEscrowYearToDate = value; } }
        private Value<decimal?> _totalHazardInsurance;
        public decimal? TotalHazardInsurance { get { return _totalHazardInsurance; } set { _totalHazardInsurance = value; } }
        private Value<decimal?> _totalInterest;
        public decimal? TotalInterest { get { return _totalInterest; } set { _totalInterest = value; } }
        private Value<decimal?> _totalInterestYearToDate;
        public decimal? TotalInterestYearToDate { get { return _totalInterestYearToDate; } set { _totalInterestYearToDate = value; } }
        private Value<decimal?> _totalLateFee;
        public decimal? TotalLateFee { get { return _totalLateFee; } set { _totalLateFee = value; } }
        private Value<decimal?> _totalLateFeeYearToDate;
        public decimal? TotalLateFeeYearToDate { get { return _totalLateFeeYearToDate; } set { _totalLateFeeYearToDate = value; } }
        private Value<decimal?> _totalMiscFee;
        public decimal? TotalMiscFee { get { return _totalMiscFee; } set { _totalMiscFee = value; } }
        private Value<decimal?> _totalMiscFeeYearToDate;
        public decimal? TotalMiscFeeYearToDate { get { return _totalMiscFeeYearToDate; } set { _totalMiscFeeYearToDate = value; } }
        private Value<decimal?> _totalMortgageInsurance;
        public decimal? TotalMortgageInsurance { get { return _totalMortgageInsurance; } set { _totalMortgageInsurance = value; } }
        private Value<int?> _totalNumberOfLatePayment;
        public int? TotalNumberOfLatePayment { get { return _totalNumberOfLatePayment; } set { _totalNumberOfLatePayment = value; } }
        private Value<int?> _totalNumberOfPayment;
        public int? TotalNumberOfPayment { get { return _totalNumberOfPayment; } set { _totalNumberOfPayment = value; } }
        private Value<decimal?> _totalOtherTaxes;
        public decimal? TotalOtherTaxes { get { return _totalOtherTaxes; } set { _totalOtherTaxes = value; } }
        private Value<decimal?> _totalPAndI;
        public decimal? TotalPAndI { get { return _totalPAndI; } set { _totalPAndI = value; } }
        private Value<decimal?> _totalPAndIYearToDate;
        public decimal? TotalPAndIYearToDate { get { return _totalPAndIYearToDate; } set { _totalPAndIYearToDate = value; } }
        private Value<decimal?> _totalPaymentCollected;
        public decimal? TotalPaymentCollected { get { return _totalPaymentCollected; } set { _totalPaymentCollected = value; } }
        private Value<decimal?> _totalPaymentCollectedYearToDate;
        public decimal? TotalPaymentCollectedYearToDate { get { return _totalPaymentCollectedYearToDate; } set { _totalPaymentCollectedYearToDate = value; } }
        private Value<decimal?> _totalPrincipal;
        public decimal? TotalPrincipal { get { return _totalPrincipal; } set { _totalPrincipal = value; } }
        private Value<decimal?> _totalPrincipalYearToDate;
        public decimal? TotalPrincipalYearToDate { get { return _totalPrincipalYearToDate; } set { _totalPrincipalYearToDate = value; } }
        private Value<decimal?> _totalTaxes;
        public decimal? TotalTaxes { get { return _totalTaxes; } set { _totalTaxes = value; } }
        private Value<decimal?> _totalUsdaMonthlyPremium;
        public decimal? TotalUsdaMonthlyPremium { get { return _totalUsdaMonthlyPremium; } set { _totalUsdaMonthlyPremium = value; } }
        private Value<decimal?> _unpaidBuydownSubsidyAmount;
        public decimal? UnpaidBuydownSubsidyAmount { get { return _unpaidBuydownSubsidyAmount; } set { _unpaidBuydownSubsidyAmount = value; } }
        private Value<decimal?> _unpaidEscrow;
        public decimal? UnpaidEscrow { get { return _unpaidEscrow; } set { _unpaidEscrow = value; } }
        private Value<decimal?> _unpaidEscrowCityPropertyTax;
        public decimal? UnpaidEscrowCityPropertyTax { get { return _unpaidEscrowCityPropertyTax; } set { _unpaidEscrowCityPropertyTax = value; } }
        private Value<decimal?> _unpaidEscrowFloodInsurance;
        public decimal? UnpaidEscrowFloodInsurance { get { return _unpaidEscrowFloodInsurance; } set { _unpaidEscrowFloodInsurance = value; } }
        private Value<decimal?> _unpaidEscrowHazardInsurance;
        public decimal? UnpaidEscrowHazardInsurance { get { return _unpaidEscrowHazardInsurance; } set { _unpaidEscrowHazardInsurance = value; } }
        private Value<decimal?> _unpaidEscrowMortgageInsurance;
        public decimal? UnpaidEscrowMortgageInsurance { get { return _unpaidEscrowMortgageInsurance; } set { _unpaidEscrowMortgageInsurance = value; } }
        private Value<decimal?> _unpaidEscrowOther1;
        public decimal? UnpaidEscrowOther1 { get { return _unpaidEscrowOther1; } set { _unpaidEscrowOther1 = value; } }
        private Value<decimal?> _unpaidEscrowOther2;
        public decimal? UnpaidEscrowOther2 { get { return _unpaidEscrowOther2; } set { _unpaidEscrowOther2 = value; } }
        private Value<decimal?> _unpaidEscrowOther3;
        public decimal? UnpaidEscrowOther3 { get { return _unpaidEscrowOther3; } set { _unpaidEscrowOther3 = value; } }
        private Value<decimal?> _unpaidEscrowTax;
        public decimal? UnpaidEscrowTax { get { return _unpaidEscrowTax; } set { _unpaidEscrowTax = value; } }
        private Value<decimal?> _unpaidEscrowUSDAMonthlyPremium;
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get { return _unpaidEscrowUSDAMonthlyPremium; } set { _unpaidEscrowUSDAMonthlyPremium = value; } }
        private Value<decimal?> _unpaidInterest;
        public decimal? UnpaidInterest { get { return _unpaidInterest; } set { _unpaidInterest = value; } }
        private Value<decimal?> _unpaidLateFee;
        public decimal? UnpaidLateFee { get { return _unpaidLateFee; } set { _unpaidLateFee = value; } }
        private Value<decimal?> _unpaidMiscrFee;
        public decimal? UnpaidMiscrFee { get { return _unpaidMiscrFee; } set { _unpaidMiscrFee = value; } }
        private Value<decimal?> _unpaidPrincipal;
        public decimal? UnpaidPrincipal { get { return _unpaidPrincipal; } set { _unpaidPrincipal = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _beginningBalance.Clean
                    && _borrCellPhoneNumber.Clean
                    && _borrHomeEmail.Clean
                    && _borrHomePhoneNumber.Clean
                    && _borrowerFirstName.Clean
                    && _borrowerLastName.Clean
                    && _borrWorkPhoneNumber.Clean
                    && _calcTriggered.Clean
                    && _cityInsurance.Clean
                    && _comments.Clean
                    && _currentPrincipalBalance.Clean
                    && _escrowBalance.Clean
                    && _escrowDisbursementTransactions.Clean
                    && _escrowInterestTransactions.Clean
                    && _floodInsurance.Clean
                    && _id.Clean
                    && _interimServicingTransactions.Clean
                    && _lastPaymentAdditionalEscrow.Clean
                    && _lastPaymentAdditionalPrincipal.Clean
                    && _lastPaymentBuydownSubsidyAmount.Clean
                    && _lastPaymentEscrowAmount.Clean
                    && _lastPaymentEscrowCityPropertyTax.Clean
                    && _lastPaymentEscrowFloodInsurance.Clean
                    && _lastPaymentEscrowHazardInsurance.Clean
                    && _lastPaymentEscrowMortgageInsurance.Clean
                    && _lastPaymentEscrowOther1.Clean
                    && _lastPaymentEscrowOther2.Clean
                    && _lastPaymentEscrowOther3.Clean
                    && _lastPaymentEscrowTax.Clean
                    && _lastPaymentEscrowUSDAMonthlyPremium.Clean
                    && _lastPaymentGuid.Clean
                    && _lastPaymentInterest.Clean
                    && _lastPaymentLateFee.Clean
                    && _lastPaymentMiscFee.Clean
                    && _lastPaymentNumber.Clean
                    && _lastPaymentPrincipal.Clean
                    && _lastPaymentPrincipalAndInterest.Clean
                    && _lastPaymentReceivedDate.Clean
                    && _lastPaymentStatementDate.Clean
                    && _lastPaymentTotalAmountReceived.Clean
                    && _lastStatementPrintedDate.Clean
                    && _loanSnapshotXml.Clean
                    && _mailingCity.Clean
                    && _mailingPostalCode.Clean
                    && _mailingState.Clean
                    && _mailingStreetAddress.Clean
                    && _mortgageAccount.Clean
                    && _nextEscrowTotalFloodInsurance.Clean
                    && _nextEscrowTotalFloodInsuranceDueDate.Clean
                    && _nextEscrowTotalHazardInsurance.Clean
                    && _nextEscrowTotalHazardInsuranceDueDate.Clean
                    && _nextEscrowTotalMortgageInsurance.Clean
                    && _nextEscrowTotalMortgageInsuranceDueDate.Clean
                    && _nextEscrowTotalOtherTax1.Clean
                    && _nextEscrowTotalOtherTax1DueDate.Clean
                    && _nextEscrowTotalOtherTax2.Clean
                    && _nextEscrowTotalOtherTax2DueDate.Clean
                    && _nextEscrowTotalOtherTax3.Clean
                    && _nextEscrowTotalOtherTax3DueDate.Clean
                    && _nextEscrowTotalPropertyTax.Clean
                    && _nextEscrowTotalPropertyTaxDueDate.Clean
                    && _nextEscrowTotalTax.Clean
                    && _nextEscrowTotalTaxDueDate.Clean
                    && _nextEscrowTotalUsdaMonthlyPremium.Clean
                    && _nextEscrowTotalUsdaMonthlyPremiumDueDate.Clean
                    && _nextPaymentBuydownSubsidyAmount.Clean
                    && _nextPaymentEscrowAmount.Clean
                    && _nextPaymentEscrowCityPropertyTax.Clean
                    && _nextPaymentEscrowFloodInsurance.Clean
                    && _nextPaymentEscrowHazardInsurance.Clean
                    && _nextPaymentEscrowMortgageInsurance.Clean
                    && _nextPaymentEscrowOther1.Clean
                    && _nextPaymentEscrowOther2.Clean
                    && _nextPaymentEscrowOther3.Clean
                    && _nextPaymentEscrowTax.Clean
                    && _nextPaymentEscrowUSDAMonthlyPremium.Clean
                    && _nextPaymentIndexCurrentValuePercent.Clean
                    && _nextPaymentInterest.Clean
                    && _nextPaymentLateFee.Clean
                    && _nextPaymentLatePaymentDate.Clean
                    && _nextPaymentMiscFee.Clean
                    && _nextPaymentPastDueAmount.Clean
                    && _nextPaymentPaymentDueDate.Clean
                    && _nextPaymentPaymentIndexDate.Clean
                    && _nextPaymentPrincipal.Clean
                    && _nextPaymentPrincipalAndInterest.Clean
                    && _nextPaymentRequestedInterestRatePercent.Clean
                    && _nextPaymentStatementDueDate.Clean
                    && _nextPaymentTotalAmountDue.Clean
                    && _nextPaymentTotalAmountWithLateFee.Clean
                    && _nextPaymentUnpaidLateFee.Clean
                    && _numberOfDisbursement.Clean
                    && _otherTransactions.Clean
                    && _paymentDueDatePrinted.Clean
                    && _paymentReversalTransactions.Clean
                    && _paymentTransactions.Clean
                    && _printedByUserId.Clean
                    && _printedByUserName.Clean
                    && _purchasedPrincipal.Clean
                    && _scheduledPayments.Clean
                    && _schedulePaymentTransactions.Clean
                    && _servicerLoanNumber.Clean
                    && _servicingStatus.Clean
                    && _servicingTransferDate.Clean
                    && _subServicer.Clean
                    && _subServicerLoanNumber.Clean
                    && _totalAdditionalEscrow.Clean
                    && _totalAdditionalEscrowYearToDate.Clean
                    && _totalAdditionalPrincipal.Clean
                    && _totalAdditionalPrincipalYearToDate.Clean
                    && _totalAmountDisbursed.Clean
                    && _totalBuydownSubsidyAmount.Clean
                    && _totalBuydownSubsidyAmountYearToDate.Clean
                    && _totalEscrow.Clean
                    && _totalEscrowYearToDate.Clean
                    && _totalHazardInsurance.Clean
                    && _totalInterest.Clean
                    && _totalInterestYearToDate.Clean
                    && _totalLateFee.Clean
                    && _totalLateFeeYearToDate.Clean
                    && _totalMiscFee.Clean
                    && _totalMiscFeeYearToDate.Clean
                    && _totalMortgageInsurance.Clean
                    && _totalNumberOfLatePayment.Clean
                    && _totalNumberOfPayment.Clean
                    && _totalOtherTaxes.Clean
                    && _totalPAndI.Clean
                    && _totalPAndIYearToDate.Clean
                    && _totalPaymentCollected.Clean
                    && _totalPaymentCollectedYearToDate.Clean
                    && _totalPrincipal.Clean
                    && _totalPrincipalYearToDate.Clean
                    && _totalTaxes.Clean
                    && _totalUsdaMonthlyPremium.Clean
                    && _unpaidBuydownSubsidyAmount.Clean
                    && _unpaidEscrow.Clean
                    && _unpaidEscrowCityPropertyTax.Clean
                    && _unpaidEscrowFloodInsurance.Clean
                    && _unpaidEscrowHazardInsurance.Clean
                    && _unpaidEscrowMortgageInsurance.Clean
                    && _unpaidEscrowOther1.Clean
                    && _unpaidEscrowOther2.Clean
                    && _unpaidEscrowOther3.Clean
                    && _unpaidEscrowTax.Clean
                    && _unpaidEscrowUSDAMonthlyPremium.Clean
                    && _unpaidInterest.Clean
                    && _unpaidLateFee.Clean
                    && _unpaidMiscrFee.Clean
                    && _unpaidPrincipal.Clean
                    && LastScheduledPayment?.Clean != false
                    && NextScheduledPayment?.Clean != false;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var beginningBalance = _beginningBalance; beginningBalance.Clean = value; _beginningBalance = beginningBalance;
                var borrCellPhoneNumber = _borrCellPhoneNumber; borrCellPhoneNumber.Clean = value; _borrCellPhoneNumber = borrCellPhoneNumber;
                var borrHomeEmail = _borrHomeEmail; borrHomeEmail.Clean = value; _borrHomeEmail = borrHomeEmail;
                var borrHomePhoneNumber = _borrHomePhoneNumber; borrHomePhoneNumber.Clean = value; _borrHomePhoneNumber = borrHomePhoneNumber;
                var borrowerFirstName = _borrowerFirstName; borrowerFirstName.Clean = value; _borrowerFirstName = borrowerFirstName;
                var borrowerLastName = _borrowerLastName; borrowerLastName.Clean = value; _borrowerLastName = borrowerLastName;
                var borrWorkPhoneNumber = _borrWorkPhoneNumber; borrWorkPhoneNumber.Clean = value; _borrWorkPhoneNumber = borrWorkPhoneNumber;
                var calcTriggered = _calcTriggered; calcTriggered.Clean = value; _calcTriggered = calcTriggered;
                var cityInsurance = _cityInsurance; cityInsurance.Clean = value; _cityInsurance = cityInsurance;
                var comments = _comments; comments.Clean = value; _comments = comments;
                var currentPrincipalBalance = _currentPrincipalBalance; currentPrincipalBalance.Clean = value; _currentPrincipalBalance = currentPrincipalBalance;
                var escrowBalance = _escrowBalance; escrowBalance.Clean = value; _escrowBalance = escrowBalance;
                var escrowDisbursementTransactions = _escrowDisbursementTransactions; escrowDisbursementTransactions.Clean = value; _escrowDisbursementTransactions = escrowDisbursementTransactions;
                var escrowInterestTransactions = _escrowInterestTransactions; escrowInterestTransactions.Clean = value; _escrowInterestTransactions = escrowInterestTransactions;
                var floodInsurance = _floodInsurance; floodInsurance.Clean = value; _floodInsurance = floodInsurance;
                var id = _id; id.Clean = value; _id = id;
                var interimServicingTransactions = _interimServicingTransactions; interimServicingTransactions.Clean = value; _interimServicingTransactions = interimServicingTransactions;
                var lastPaymentAdditionalEscrow = _lastPaymentAdditionalEscrow; lastPaymentAdditionalEscrow.Clean = value; _lastPaymentAdditionalEscrow = lastPaymentAdditionalEscrow;
                var lastPaymentAdditionalPrincipal = _lastPaymentAdditionalPrincipal; lastPaymentAdditionalPrincipal.Clean = value; _lastPaymentAdditionalPrincipal = lastPaymentAdditionalPrincipal;
                var lastPaymentBuydownSubsidyAmount = _lastPaymentBuydownSubsidyAmount; lastPaymentBuydownSubsidyAmount.Clean = value; _lastPaymentBuydownSubsidyAmount = lastPaymentBuydownSubsidyAmount;
                var lastPaymentEscrowAmount = _lastPaymentEscrowAmount; lastPaymentEscrowAmount.Clean = value; _lastPaymentEscrowAmount = lastPaymentEscrowAmount;
                var lastPaymentEscrowCityPropertyTax = _lastPaymentEscrowCityPropertyTax; lastPaymentEscrowCityPropertyTax.Clean = value; _lastPaymentEscrowCityPropertyTax = lastPaymentEscrowCityPropertyTax;
                var lastPaymentEscrowFloodInsurance = _lastPaymentEscrowFloodInsurance; lastPaymentEscrowFloodInsurance.Clean = value; _lastPaymentEscrowFloodInsurance = lastPaymentEscrowFloodInsurance;
                var lastPaymentEscrowHazardInsurance = _lastPaymentEscrowHazardInsurance; lastPaymentEscrowHazardInsurance.Clean = value; _lastPaymentEscrowHazardInsurance = lastPaymentEscrowHazardInsurance;
                var lastPaymentEscrowMortgageInsurance = _lastPaymentEscrowMortgageInsurance; lastPaymentEscrowMortgageInsurance.Clean = value; _lastPaymentEscrowMortgageInsurance = lastPaymentEscrowMortgageInsurance;
                var lastPaymentEscrowOther1 = _lastPaymentEscrowOther1; lastPaymentEscrowOther1.Clean = value; _lastPaymentEscrowOther1 = lastPaymentEscrowOther1;
                var lastPaymentEscrowOther2 = _lastPaymentEscrowOther2; lastPaymentEscrowOther2.Clean = value; _lastPaymentEscrowOther2 = lastPaymentEscrowOther2;
                var lastPaymentEscrowOther3 = _lastPaymentEscrowOther3; lastPaymentEscrowOther3.Clean = value; _lastPaymentEscrowOther3 = lastPaymentEscrowOther3;
                var lastPaymentEscrowTax = _lastPaymentEscrowTax; lastPaymentEscrowTax.Clean = value; _lastPaymentEscrowTax = lastPaymentEscrowTax;
                var lastPaymentEscrowUSDAMonthlyPremium = _lastPaymentEscrowUSDAMonthlyPremium; lastPaymentEscrowUSDAMonthlyPremium.Clean = value; _lastPaymentEscrowUSDAMonthlyPremium = lastPaymentEscrowUSDAMonthlyPremium;
                var lastPaymentGuid = _lastPaymentGuid; lastPaymentGuid.Clean = value; _lastPaymentGuid = lastPaymentGuid;
                var lastPaymentInterest = _lastPaymentInterest; lastPaymentInterest.Clean = value; _lastPaymentInterest = lastPaymentInterest;
                var lastPaymentLateFee = _lastPaymentLateFee; lastPaymentLateFee.Clean = value; _lastPaymentLateFee = lastPaymentLateFee;
                var lastPaymentMiscFee = _lastPaymentMiscFee; lastPaymentMiscFee.Clean = value; _lastPaymentMiscFee = lastPaymentMiscFee;
                var lastPaymentNumber = _lastPaymentNumber; lastPaymentNumber.Clean = value; _lastPaymentNumber = lastPaymentNumber;
                var lastPaymentPrincipal = _lastPaymentPrincipal; lastPaymentPrincipal.Clean = value; _lastPaymentPrincipal = lastPaymentPrincipal;
                var lastPaymentPrincipalAndInterest = _lastPaymentPrincipalAndInterest; lastPaymentPrincipalAndInterest.Clean = value; _lastPaymentPrincipalAndInterest = lastPaymentPrincipalAndInterest;
                var lastPaymentReceivedDate = _lastPaymentReceivedDate; lastPaymentReceivedDate.Clean = value; _lastPaymentReceivedDate = lastPaymentReceivedDate;
                var lastPaymentStatementDate = _lastPaymentStatementDate; lastPaymentStatementDate.Clean = value; _lastPaymentStatementDate = lastPaymentStatementDate;
                var lastPaymentTotalAmountReceived = _lastPaymentTotalAmountReceived; lastPaymentTotalAmountReceived.Clean = value; _lastPaymentTotalAmountReceived = lastPaymentTotalAmountReceived;
                var lastStatementPrintedDate = _lastStatementPrintedDate; lastStatementPrintedDate.Clean = value; _lastStatementPrintedDate = lastStatementPrintedDate;
                var loanSnapshotXml = _loanSnapshotXml; loanSnapshotXml.Clean = value; _loanSnapshotXml = loanSnapshotXml;
                var mailingCity = _mailingCity; mailingCity.Clean = value; _mailingCity = mailingCity;
                var mailingPostalCode = _mailingPostalCode; mailingPostalCode.Clean = value; _mailingPostalCode = mailingPostalCode;
                var mailingState = _mailingState; mailingState.Clean = value; _mailingState = mailingState;
                var mailingStreetAddress = _mailingStreetAddress; mailingStreetAddress.Clean = value; _mailingStreetAddress = mailingStreetAddress;
                var mortgageAccount = _mortgageAccount; mortgageAccount.Clean = value; _mortgageAccount = mortgageAccount;
                var nextEscrowTotalFloodInsurance = _nextEscrowTotalFloodInsurance; nextEscrowTotalFloodInsurance.Clean = value; _nextEscrowTotalFloodInsurance = nextEscrowTotalFloodInsurance;
                var nextEscrowTotalFloodInsuranceDueDate = _nextEscrowTotalFloodInsuranceDueDate; nextEscrowTotalFloodInsuranceDueDate.Clean = value; _nextEscrowTotalFloodInsuranceDueDate = nextEscrowTotalFloodInsuranceDueDate;
                var nextEscrowTotalHazardInsurance = _nextEscrowTotalHazardInsurance; nextEscrowTotalHazardInsurance.Clean = value; _nextEscrowTotalHazardInsurance = nextEscrowTotalHazardInsurance;
                var nextEscrowTotalHazardInsuranceDueDate = _nextEscrowTotalHazardInsuranceDueDate; nextEscrowTotalHazardInsuranceDueDate.Clean = value; _nextEscrowTotalHazardInsuranceDueDate = nextEscrowTotalHazardInsuranceDueDate;
                var nextEscrowTotalMortgageInsurance = _nextEscrowTotalMortgageInsurance; nextEscrowTotalMortgageInsurance.Clean = value; _nextEscrowTotalMortgageInsurance = nextEscrowTotalMortgageInsurance;
                var nextEscrowTotalMortgageInsuranceDueDate = _nextEscrowTotalMortgageInsuranceDueDate; nextEscrowTotalMortgageInsuranceDueDate.Clean = value; _nextEscrowTotalMortgageInsuranceDueDate = nextEscrowTotalMortgageInsuranceDueDate;
                var nextEscrowTotalOtherTax1 = _nextEscrowTotalOtherTax1; nextEscrowTotalOtherTax1.Clean = value; _nextEscrowTotalOtherTax1 = nextEscrowTotalOtherTax1;
                var nextEscrowTotalOtherTax1DueDate = _nextEscrowTotalOtherTax1DueDate; nextEscrowTotalOtherTax1DueDate.Clean = value; _nextEscrowTotalOtherTax1DueDate = nextEscrowTotalOtherTax1DueDate;
                var nextEscrowTotalOtherTax2 = _nextEscrowTotalOtherTax2; nextEscrowTotalOtherTax2.Clean = value; _nextEscrowTotalOtherTax2 = nextEscrowTotalOtherTax2;
                var nextEscrowTotalOtherTax2DueDate = _nextEscrowTotalOtherTax2DueDate; nextEscrowTotalOtherTax2DueDate.Clean = value; _nextEscrowTotalOtherTax2DueDate = nextEscrowTotalOtherTax2DueDate;
                var nextEscrowTotalOtherTax3 = _nextEscrowTotalOtherTax3; nextEscrowTotalOtherTax3.Clean = value; _nextEscrowTotalOtherTax3 = nextEscrowTotalOtherTax3;
                var nextEscrowTotalOtherTax3DueDate = _nextEscrowTotalOtherTax3DueDate; nextEscrowTotalOtherTax3DueDate.Clean = value; _nextEscrowTotalOtherTax3DueDate = nextEscrowTotalOtherTax3DueDate;
                var nextEscrowTotalPropertyTax = _nextEscrowTotalPropertyTax; nextEscrowTotalPropertyTax.Clean = value; _nextEscrowTotalPropertyTax = nextEscrowTotalPropertyTax;
                var nextEscrowTotalPropertyTaxDueDate = _nextEscrowTotalPropertyTaxDueDate; nextEscrowTotalPropertyTaxDueDate.Clean = value; _nextEscrowTotalPropertyTaxDueDate = nextEscrowTotalPropertyTaxDueDate;
                var nextEscrowTotalTax = _nextEscrowTotalTax; nextEscrowTotalTax.Clean = value; _nextEscrowTotalTax = nextEscrowTotalTax;
                var nextEscrowTotalTaxDueDate = _nextEscrowTotalTaxDueDate; nextEscrowTotalTaxDueDate.Clean = value; _nextEscrowTotalTaxDueDate = nextEscrowTotalTaxDueDate;
                var nextEscrowTotalUsdaMonthlyPremium = _nextEscrowTotalUsdaMonthlyPremium; nextEscrowTotalUsdaMonthlyPremium.Clean = value; _nextEscrowTotalUsdaMonthlyPremium = nextEscrowTotalUsdaMonthlyPremium;
                var nextEscrowTotalUsdaMonthlyPremiumDueDate = _nextEscrowTotalUsdaMonthlyPremiumDueDate; nextEscrowTotalUsdaMonthlyPremiumDueDate.Clean = value; _nextEscrowTotalUsdaMonthlyPremiumDueDate = nextEscrowTotalUsdaMonthlyPremiumDueDate;
                var nextPaymentBuydownSubsidyAmount = _nextPaymentBuydownSubsidyAmount; nextPaymentBuydownSubsidyAmount.Clean = value; _nextPaymentBuydownSubsidyAmount = nextPaymentBuydownSubsidyAmount;
                var nextPaymentEscrowAmount = _nextPaymentEscrowAmount; nextPaymentEscrowAmount.Clean = value; _nextPaymentEscrowAmount = nextPaymentEscrowAmount;
                var nextPaymentEscrowCityPropertyTax = _nextPaymentEscrowCityPropertyTax; nextPaymentEscrowCityPropertyTax.Clean = value; _nextPaymentEscrowCityPropertyTax = nextPaymentEscrowCityPropertyTax;
                var nextPaymentEscrowFloodInsurance = _nextPaymentEscrowFloodInsurance; nextPaymentEscrowFloodInsurance.Clean = value; _nextPaymentEscrowFloodInsurance = nextPaymentEscrowFloodInsurance;
                var nextPaymentEscrowHazardInsurance = _nextPaymentEscrowHazardInsurance; nextPaymentEscrowHazardInsurance.Clean = value; _nextPaymentEscrowHazardInsurance = nextPaymentEscrowHazardInsurance;
                var nextPaymentEscrowMortgageInsurance = _nextPaymentEscrowMortgageInsurance; nextPaymentEscrowMortgageInsurance.Clean = value; _nextPaymentEscrowMortgageInsurance = nextPaymentEscrowMortgageInsurance;
                var nextPaymentEscrowOther1 = _nextPaymentEscrowOther1; nextPaymentEscrowOther1.Clean = value; _nextPaymentEscrowOther1 = nextPaymentEscrowOther1;
                var nextPaymentEscrowOther2 = _nextPaymentEscrowOther2; nextPaymentEscrowOther2.Clean = value; _nextPaymentEscrowOther2 = nextPaymentEscrowOther2;
                var nextPaymentEscrowOther3 = _nextPaymentEscrowOther3; nextPaymentEscrowOther3.Clean = value; _nextPaymentEscrowOther3 = nextPaymentEscrowOther3;
                var nextPaymentEscrowTax = _nextPaymentEscrowTax; nextPaymentEscrowTax.Clean = value; _nextPaymentEscrowTax = nextPaymentEscrowTax;
                var nextPaymentEscrowUSDAMonthlyPremium = _nextPaymentEscrowUSDAMonthlyPremium; nextPaymentEscrowUSDAMonthlyPremium.Clean = value; _nextPaymentEscrowUSDAMonthlyPremium = nextPaymentEscrowUSDAMonthlyPremium;
                var nextPaymentIndexCurrentValuePercent = _nextPaymentIndexCurrentValuePercent; nextPaymentIndexCurrentValuePercent.Clean = value; _nextPaymentIndexCurrentValuePercent = nextPaymentIndexCurrentValuePercent;
                var nextPaymentInterest = _nextPaymentInterest; nextPaymentInterest.Clean = value; _nextPaymentInterest = nextPaymentInterest;
                var nextPaymentLateFee = _nextPaymentLateFee; nextPaymentLateFee.Clean = value; _nextPaymentLateFee = nextPaymentLateFee;
                var nextPaymentLatePaymentDate = _nextPaymentLatePaymentDate; nextPaymentLatePaymentDate.Clean = value; _nextPaymentLatePaymentDate = nextPaymentLatePaymentDate;
                var nextPaymentMiscFee = _nextPaymentMiscFee; nextPaymentMiscFee.Clean = value; _nextPaymentMiscFee = nextPaymentMiscFee;
                var nextPaymentPastDueAmount = _nextPaymentPastDueAmount; nextPaymentPastDueAmount.Clean = value; _nextPaymentPastDueAmount = nextPaymentPastDueAmount;
                var nextPaymentPaymentDueDate = _nextPaymentPaymentDueDate; nextPaymentPaymentDueDate.Clean = value; _nextPaymentPaymentDueDate = nextPaymentPaymentDueDate;
                var nextPaymentPaymentIndexDate = _nextPaymentPaymentIndexDate; nextPaymentPaymentIndexDate.Clean = value; _nextPaymentPaymentIndexDate = nextPaymentPaymentIndexDate;
                var nextPaymentPrincipal = _nextPaymentPrincipal; nextPaymentPrincipal.Clean = value; _nextPaymentPrincipal = nextPaymentPrincipal;
                var nextPaymentPrincipalAndInterest = _nextPaymentPrincipalAndInterest; nextPaymentPrincipalAndInterest.Clean = value; _nextPaymentPrincipalAndInterest = nextPaymentPrincipalAndInterest;
                var nextPaymentRequestedInterestRatePercent = _nextPaymentRequestedInterestRatePercent; nextPaymentRequestedInterestRatePercent.Clean = value; _nextPaymentRequestedInterestRatePercent = nextPaymentRequestedInterestRatePercent;
                var nextPaymentStatementDueDate = _nextPaymentStatementDueDate; nextPaymentStatementDueDate.Clean = value; _nextPaymentStatementDueDate = nextPaymentStatementDueDate;
                var nextPaymentTotalAmountDue = _nextPaymentTotalAmountDue; nextPaymentTotalAmountDue.Clean = value; _nextPaymentTotalAmountDue = nextPaymentTotalAmountDue;
                var nextPaymentTotalAmountWithLateFee = _nextPaymentTotalAmountWithLateFee; nextPaymentTotalAmountWithLateFee.Clean = value; _nextPaymentTotalAmountWithLateFee = nextPaymentTotalAmountWithLateFee;
                var nextPaymentUnpaidLateFee = _nextPaymentUnpaidLateFee; nextPaymentUnpaidLateFee.Clean = value; _nextPaymentUnpaidLateFee = nextPaymentUnpaidLateFee;
                var numberOfDisbursement = _numberOfDisbursement; numberOfDisbursement.Clean = value; _numberOfDisbursement = numberOfDisbursement;
                var otherTransactions = _otherTransactions; otherTransactions.Clean = value; _otherTransactions = otherTransactions;
                var paymentDueDatePrinted = _paymentDueDatePrinted; paymentDueDatePrinted.Clean = value; _paymentDueDatePrinted = paymentDueDatePrinted;
                var paymentReversalTransactions = _paymentReversalTransactions; paymentReversalTransactions.Clean = value; _paymentReversalTransactions = paymentReversalTransactions;
                var paymentTransactions = _paymentTransactions; paymentTransactions.Clean = value; _paymentTransactions = paymentTransactions;
                var printedByUserId = _printedByUserId; printedByUserId.Clean = value; _printedByUserId = printedByUserId;
                var printedByUserName = _printedByUserName; printedByUserName.Clean = value; _printedByUserName = printedByUserName;
                var purchasedPrincipal = _purchasedPrincipal; purchasedPrincipal.Clean = value; _purchasedPrincipal = purchasedPrincipal;
                var scheduledPayments = _scheduledPayments; scheduledPayments.Clean = value; _scheduledPayments = scheduledPayments;
                var schedulePaymentTransactions = _schedulePaymentTransactions; schedulePaymentTransactions.Clean = value; _schedulePaymentTransactions = schedulePaymentTransactions;
                var servicerLoanNumber = _servicerLoanNumber; servicerLoanNumber.Clean = value; _servicerLoanNumber = servicerLoanNumber;
                var servicingStatus = _servicingStatus; servicingStatus.Clean = value; _servicingStatus = servicingStatus;
                var servicingTransferDate = _servicingTransferDate; servicingTransferDate.Clean = value; _servicingTransferDate = servicingTransferDate;
                var subServicer = _subServicer; subServicer.Clean = value; _subServicer = subServicer;
                var subServicerLoanNumber = _subServicerLoanNumber; subServicerLoanNumber.Clean = value; _subServicerLoanNumber = subServicerLoanNumber;
                var totalAdditionalEscrow = _totalAdditionalEscrow; totalAdditionalEscrow.Clean = value; _totalAdditionalEscrow = totalAdditionalEscrow;
                var totalAdditionalEscrowYearToDate = _totalAdditionalEscrowYearToDate; totalAdditionalEscrowYearToDate.Clean = value; _totalAdditionalEscrowYearToDate = totalAdditionalEscrowYearToDate;
                var totalAdditionalPrincipal = _totalAdditionalPrincipal; totalAdditionalPrincipal.Clean = value; _totalAdditionalPrincipal = totalAdditionalPrincipal;
                var totalAdditionalPrincipalYearToDate = _totalAdditionalPrincipalYearToDate; totalAdditionalPrincipalYearToDate.Clean = value; _totalAdditionalPrincipalYearToDate = totalAdditionalPrincipalYearToDate;
                var totalAmountDisbursed = _totalAmountDisbursed; totalAmountDisbursed.Clean = value; _totalAmountDisbursed = totalAmountDisbursed;
                var totalBuydownSubsidyAmount = _totalBuydownSubsidyAmount; totalBuydownSubsidyAmount.Clean = value; _totalBuydownSubsidyAmount = totalBuydownSubsidyAmount;
                var totalBuydownSubsidyAmountYearToDate = _totalBuydownSubsidyAmountYearToDate; totalBuydownSubsidyAmountYearToDate.Clean = value; _totalBuydownSubsidyAmountYearToDate = totalBuydownSubsidyAmountYearToDate;
                var totalEscrow = _totalEscrow; totalEscrow.Clean = value; _totalEscrow = totalEscrow;
                var totalEscrowYearToDate = _totalEscrowYearToDate; totalEscrowYearToDate.Clean = value; _totalEscrowYearToDate = totalEscrowYearToDate;
                var totalHazardInsurance = _totalHazardInsurance; totalHazardInsurance.Clean = value; _totalHazardInsurance = totalHazardInsurance;
                var totalInterest = _totalInterest; totalInterest.Clean = value; _totalInterest = totalInterest;
                var totalInterestYearToDate = _totalInterestYearToDate; totalInterestYearToDate.Clean = value; _totalInterestYearToDate = totalInterestYearToDate;
                var totalLateFee = _totalLateFee; totalLateFee.Clean = value; _totalLateFee = totalLateFee;
                var totalLateFeeYearToDate = _totalLateFeeYearToDate; totalLateFeeYearToDate.Clean = value; _totalLateFeeYearToDate = totalLateFeeYearToDate;
                var totalMiscFee = _totalMiscFee; totalMiscFee.Clean = value; _totalMiscFee = totalMiscFee;
                var totalMiscFeeYearToDate = _totalMiscFeeYearToDate; totalMiscFeeYearToDate.Clean = value; _totalMiscFeeYearToDate = totalMiscFeeYearToDate;
                var totalMortgageInsurance = _totalMortgageInsurance; totalMortgageInsurance.Clean = value; _totalMortgageInsurance = totalMortgageInsurance;
                var totalNumberOfLatePayment = _totalNumberOfLatePayment; totalNumberOfLatePayment.Clean = value; _totalNumberOfLatePayment = totalNumberOfLatePayment;
                var totalNumberOfPayment = _totalNumberOfPayment; totalNumberOfPayment.Clean = value; _totalNumberOfPayment = totalNumberOfPayment;
                var totalOtherTaxes = _totalOtherTaxes; totalOtherTaxes.Clean = value; _totalOtherTaxes = totalOtherTaxes;
                var totalPAndI = _totalPAndI; totalPAndI.Clean = value; _totalPAndI = totalPAndI;
                var totalPAndIYearToDate = _totalPAndIYearToDate; totalPAndIYearToDate.Clean = value; _totalPAndIYearToDate = totalPAndIYearToDate;
                var totalPaymentCollected = _totalPaymentCollected; totalPaymentCollected.Clean = value; _totalPaymentCollected = totalPaymentCollected;
                var totalPaymentCollectedYearToDate = _totalPaymentCollectedYearToDate; totalPaymentCollectedYearToDate.Clean = value; _totalPaymentCollectedYearToDate = totalPaymentCollectedYearToDate;
                var totalPrincipal = _totalPrincipal; totalPrincipal.Clean = value; _totalPrincipal = totalPrincipal;
                var totalPrincipalYearToDate = _totalPrincipalYearToDate; totalPrincipalYearToDate.Clean = value; _totalPrincipalYearToDate = totalPrincipalYearToDate;
                var totalTaxes = _totalTaxes; totalTaxes.Clean = value; _totalTaxes = totalTaxes;
                var totalUsdaMonthlyPremium = _totalUsdaMonthlyPremium; totalUsdaMonthlyPremium.Clean = value; _totalUsdaMonthlyPremium = totalUsdaMonthlyPremium;
                var unpaidBuydownSubsidyAmount = _unpaidBuydownSubsidyAmount; unpaidBuydownSubsidyAmount.Clean = value; _unpaidBuydownSubsidyAmount = unpaidBuydownSubsidyAmount;
                var unpaidEscrow = _unpaidEscrow; unpaidEscrow.Clean = value; _unpaidEscrow = unpaidEscrow;
                var unpaidEscrowCityPropertyTax = _unpaidEscrowCityPropertyTax; unpaidEscrowCityPropertyTax.Clean = value; _unpaidEscrowCityPropertyTax = unpaidEscrowCityPropertyTax;
                var unpaidEscrowFloodInsurance = _unpaidEscrowFloodInsurance; unpaidEscrowFloodInsurance.Clean = value; _unpaidEscrowFloodInsurance = unpaidEscrowFloodInsurance;
                var unpaidEscrowHazardInsurance = _unpaidEscrowHazardInsurance; unpaidEscrowHazardInsurance.Clean = value; _unpaidEscrowHazardInsurance = unpaidEscrowHazardInsurance;
                var unpaidEscrowMortgageInsurance = _unpaidEscrowMortgageInsurance; unpaidEscrowMortgageInsurance.Clean = value; _unpaidEscrowMortgageInsurance = unpaidEscrowMortgageInsurance;
                var unpaidEscrowOther1 = _unpaidEscrowOther1; unpaidEscrowOther1.Clean = value; _unpaidEscrowOther1 = unpaidEscrowOther1;
                var unpaidEscrowOther2 = _unpaidEscrowOther2; unpaidEscrowOther2.Clean = value; _unpaidEscrowOther2 = unpaidEscrowOther2;
                var unpaidEscrowOther3 = _unpaidEscrowOther3; unpaidEscrowOther3.Clean = value; _unpaidEscrowOther3 = unpaidEscrowOther3;
                var unpaidEscrowTax = _unpaidEscrowTax; unpaidEscrowTax.Clean = value; _unpaidEscrowTax = unpaidEscrowTax;
                var unpaidEscrowUSDAMonthlyPremium = _unpaidEscrowUSDAMonthlyPremium; unpaidEscrowUSDAMonthlyPremium.Clean = value; _unpaidEscrowUSDAMonthlyPremium = unpaidEscrowUSDAMonthlyPremium;
                var unpaidInterest = _unpaidInterest; unpaidInterest.Clean = value; _unpaidInterest = unpaidInterest;
                var unpaidLateFee = _unpaidLateFee; unpaidLateFee.Clean = value; _unpaidLateFee = unpaidLateFee;
                var unpaidMiscrFee = _unpaidMiscrFee; unpaidMiscrFee.Clean = value; _unpaidMiscrFee = unpaidMiscrFee;
                var unpaidPrincipal = _unpaidPrincipal; unpaidPrincipal.Clean = value; _unpaidPrincipal = unpaidPrincipal;
                if (LastScheduledPayment != null) LastScheduledPayment.Clean = value;
                if (NextScheduledPayment != null) NextScheduledPayment.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public InterimServicing()
        {
            Clean = true;
        }
    }
}