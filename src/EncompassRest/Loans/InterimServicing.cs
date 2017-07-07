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
                    && LastScheduledPayment.Clean
                    && NextScheduledPayment.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _beginningBalance; v0.Clean = value; _beginningBalance = v0;
                var v1 = _borrCellPhoneNumber; v1.Clean = value; _borrCellPhoneNumber = v1;
                var v2 = _borrHomeEmail; v2.Clean = value; _borrHomeEmail = v2;
                var v3 = _borrHomePhoneNumber; v3.Clean = value; _borrHomePhoneNumber = v3;
                var v4 = _borrowerFirstName; v4.Clean = value; _borrowerFirstName = v4;
                var v5 = _borrowerLastName; v5.Clean = value; _borrowerLastName = v5;
                var v6 = _borrWorkPhoneNumber; v6.Clean = value; _borrWorkPhoneNumber = v6;
                var v7 = _calcTriggered; v7.Clean = value; _calcTriggered = v7;
                var v8 = _cityInsurance; v8.Clean = value; _cityInsurance = v8;
                var v9 = _comments; v9.Clean = value; _comments = v9;
                var v10 = _currentPrincipalBalance; v10.Clean = value; _currentPrincipalBalance = v10;
                var v11 = _escrowBalance; v11.Clean = value; _escrowBalance = v11;
                var v12 = _escrowDisbursementTransactions; v12.Clean = value; _escrowDisbursementTransactions = v12;
                var v13 = _escrowInterestTransactions; v13.Clean = value; _escrowInterestTransactions = v13;
                var v14 = _floodInsurance; v14.Clean = value; _floodInsurance = v14;
                var v15 = _id; v15.Clean = value; _id = v15;
                var v16 = _interimServicingTransactions; v16.Clean = value; _interimServicingTransactions = v16;
                var v17 = _lastPaymentAdditionalEscrow; v17.Clean = value; _lastPaymentAdditionalEscrow = v17;
                var v18 = _lastPaymentAdditionalPrincipal; v18.Clean = value; _lastPaymentAdditionalPrincipal = v18;
                var v19 = _lastPaymentBuydownSubsidyAmount; v19.Clean = value; _lastPaymentBuydownSubsidyAmount = v19;
                var v20 = _lastPaymentEscrowAmount; v20.Clean = value; _lastPaymentEscrowAmount = v20;
                var v21 = _lastPaymentEscrowCityPropertyTax; v21.Clean = value; _lastPaymentEscrowCityPropertyTax = v21;
                var v22 = _lastPaymentEscrowFloodInsurance; v22.Clean = value; _lastPaymentEscrowFloodInsurance = v22;
                var v23 = _lastPaymentEscrowHazardInsurance; v23.Clean = value; _lastPaymentEscrowHazardInsurance = v23;
                var v24 = _lastPaymentEscrowMortgageInsurance; v24.Clean = value; _lastPaymentEscrowMortgageInsurance = v24;
                var v25 = _lastPaymentEscrowOther1; v25.Clean = value; _lastPaymentEscrowOther1 = v25;
                var v26 = _lastPaymentEscrowOther2; v26.Clean = value; _lastPaymentEscrowOther2 = v26;
                var v27 = _lastPaymentEscrowOther3; v27.Clean = value; _lastPaymentEscrowOther3 = v27;
                var v28 = _lastPaymentEscrowTax; v28.Clean = value; _lastPaymentEscrowTax = v28;
                var v29 = _lastPaymentEscrowUSDAMonthlyPremium; v29.Clean = value; _lastPaymentEscrowUSDAMonthlyPremium = v29;
                var v30 = _lastPaymentGuid; v30.Clean = value; _lastPaymentGuid = v30;
                var v31 = _lastPaymentInterest; v31.Clean = value; _lastPaymentInterest = v31;
                var v32 = _lastPaymentLateFee; v32.Clean = value; _lastPaymentLateFee = v32;
                var v33 = _lastPaymentMiscFee; v33.Clean = value; _lastPaymentMiscFee = v33;
                var v34 = _lastPaymentNumber; v34.Clean = value; _lastPaymentNumber = v34;
                var v35 = _lastPaymentPrincipal; v35.Clean = value; _lastPaymentPrincipal = v35;
                var v36 = _lastPaymentPrincipalAndInterest; v36.Clean = value; _lastPaymentPrincipalAndInterest = v36;
                var v37 = _lastPaymentReceivedDate; v37.Clean = value; _lastPaymentReceivedDate = v37;
                var v38 = _lastPaymentStatementDate; v38.Clean = value; _lastPaymentStatementDate = v38;
                var v39 = _lastPaymentTotalAmountReceived; v39.Clean = value; _lastPaymentTotalAmountReceived = v39;
                var v40 = _lastStatementPrintedDate; v40.Clean = value; _lastStatementPrintedDate = v40;
                var v41 = _loanSnapshotXml; v41.Clean = value; _loanSnapshotXml = v41;
                var v42 = _mailingCity; v42.Clean = value; _mailingCity = v42;
                var v43 = _mailingPostalCode; v43.Clean = value; _mailingPostalCode = v43;
                var v44 = _mailingState; v44.Clean = value; _mailingState = v44;
                var v45 = _mailingStreetAddress; v45.Clean = value; _mailingStreetAddress = v45;
                var v46 = _mortgageAccount; v46.Clean = value; _mortgageAccount = v46;
                var v47 = _nextEscrowTotalFloodInsurance; v47.Clean = value; _nextEscrowTotalFloodInsurance = v47;
                var v48 = _nextEscrowTotalFloodInsuranceDueDate; v48.Clean = value; _nextEscrowTotalFloodInsuranceDueDate = v48;
                var v49 = _nextEscrowTotalHazardInsurance; v49.Clean = value; _nextEscrowTotalHazardInsurance = v49;
                var v50 = _nextEscrowTotalHazardInsuranceDueDate; v50.Clean = value; _nextEscrowTotalHazardInsuranceDueDate = v50;
                var v51 = _nextEscrowTotalMortgageInsurance; v51.Clean = value; _nextEscrowTotalMortgageInsurance = v51;
                var v52 = _nextEscrowTotalMortgageInsuranceDueDate; v52.Clean = value; _nextEscrowTotalMortgageInsuranceDueDate = v52;
                var v53 = _nextEscrowTotalOtherTax1; v53.Clean = value; _nextEscrowTotalOtherTax1 = v53;
                var v54 = _nextEscrowTotalOtherTax1DueDate; v54.Clean = value; _nextEscrowTotalOtherTax1DueDate = v54;
                var v55 = _nextEscrowTotalOtherTax2; v55.Clean = value; _nextEscrowTotalOtherTax2 = v55;
                var v56 = _nextEscrowTotalOtherTax2DueDate; v56.Clean = value; _nextEscrowTotalOtherTax2DueDate = v56;
                var v57 = _nextEscrowTotalOtherTax3; v57.Clean = value; _nextEscrowTotalOtherTax3 = v57;
                var v58 = _nextEscrowTotalOtherTax3DueDate; v58.Clean = value; _nextEscrowTotalOtherTax3DueDate = v58;
                var v59 = _nextEscrowTotalPropertyTax; v59.Clean = value; _nextEscrowTotalPropertyTax = v59;
                var v60 = _nextEscrowTotalPropertyTaxDueDate; v60.Clean = value; _nextEscrowTotalPropertyTaxDueDate = v60;
                var v61 = _nextEscrowTotalTax; v61.Clean = value; _nextEscrowTotalTax = v61;
                var v62 = _nextEscrowTotalTaxDueDate; v62.Clean = value; _nextEscrowTotalTaxDueDate = v62;
                var v63 = _nextEscrowTotalUsdaMonthlyPremium; v63.Clean = value; _nextEscrowTotalUsdaMonthlyPremium = v63;
                var v64 = _nextEscrowTotalUsdaMonthlyPremiumDueDate; v64.Clean = value; _nextEscrowTotalUsdaMonthlyPremiumDueDate = v64;
                var v65 = _nextPaymentBuydownSubsidyAmount; v65.Clean = value; _nextPaymentBuydownSubsidyAmount = v65;
                var v66 = _nextPaymentEscrowAmount; v66.Clean = value; _nextPaymentEscrowAmount = v66;
                var v67 = _nextPaymentEscrowCityPropertyTax; v67.Clean = value; _nextPaymentEscrowCityPropertyTax = v67;
                var v68 = _nextPaymentEscrowFloodInsurance; v68.Clean = value; _nextPaymentEscrowFloodInsurance = v68;
                var v69 = _nextPaymentEscrowHazardInsurance; v69.Clean = value; _nextPaymentEscrowHazardInsurance = v69;
                var v70 = _nextPaymentEscrowMortgageInsurance; v70.Clean = value; _nextPaymentEscrowMortgageInsurance = v70;
                var v71 = _nextPaymentEscrowOther1; v71.Clean = value; _nextPaymentEscrowOther1 = v71;
                var v72 = _nextPaymentEscrowOther2; v72.Clean = value; _nextPaymentEscrowOther2 = v72;
                var v73 = _nextPaymentEscrowOther3; v73.Clean = value; _nextPaymentEscrowOther3 = v73;
                var v74 = _nextPaymentEscrowTax; v74.Clean = value; _nextPaymentEscrowTax = v74;
                var v75 = _nextPaymentEscrowUSDAMonthlyPremium; v75.Clean = value; _nextPaymentEscrowUSDAMonthlyPremium = v75;
                var v76 = _nextPaymentIndexCurrentValuePercent; v76.Clean = value; _nextPaymentIndexCurrentValuePercent = v76;
                var v77 = _nextPaymentInterest; v77.Clean = value; _nextPaymentInterest = v77;
                var v78 = _nextPaymentLateFee; v78.Clean = value; _nextPaymentLateFee = v78;
                var v79 = _nextPaymentLatePaymentDate; v79.Clean = value; _nextPaymentLatePaymentDate = v79;
                var v80 = _nextPaymentMiscFee; v80.Clean = value; _nextPaymentMiscFee = v80;
                var v81 = _nextPaymentPastDueAmount; v81.Clean = value; _nextPaymentPastDueAmount = v81;
                var v82 = _nextPaymentPaymentDueDate; v82.Clean = value; _nextPaymentPaymentDueDate = v82;
                var v83 = _nextPaymentPaymentIndexDate; v83.Clean = value; _nextPaymentPaymentIndexDate = v83;
                var v84 = _nextPaymentPrincipal; v84.Clean = value; _nextPaymentPrincipal = v84;
                var v85 = _nextPaymentPrincipalAndInterest; v85.Clean = value; _nextPaymentPrincipalAndInterest = v85;
                var v86 = _nextPaymentRequestedInterestRatePercent; v86.Clean = value; _nextPaymentRequestedInterestRatePercent = v86;
                var v87 = _nextPaymentStatementDueDate; v87.Clean = value; _nextPaymentStatementDueDate = v87;
                var v88 = _nextPaymentTotalAmountDue; v88.Clean = value; _nextPaymentTotalAmountDue = v88;
                var v89 = _nextPaymentTotalAmountWithLateFee; v89.Clean = value; _nextPaymentTotalAmountWithLateFee = v89;
                var v90 = _nextPaymentUnpaidLateFee; v90.Clean = value; _nextPaymentUnpaidLateFee = v90;
                var v91 = _numberOfDisbursement; v91.Clean = value; _numberOfDisbursement = v91;
                var v92 = _otherTransactions; v92.Clean = value; _otherTransactions = v92;
                var v93 = _paymentDueDatePrinted; v93.Clean = value; _paymentDueDatePrinted = v93;
                var v94 = _paymentReversalTransactions; v94.Clean = value; _paymentReversalTransactions = v94;
                var v95 = _paymentTransactions; v95.Clean = value; _paymentTransactions = v95;
                var v96 = _printedByUserId; v96.Clean = value; _printedByUserId = v96;
                var v97 = _printedByUserName; v97.Clean = value; _printedByUserName = v97;
                var v98 = _purchasedPrincipal; v98.Clean = value; _purchasedPrincipal = v98;
                var v99 = _scheduledPayments; v99.Clean = value; _scheduledPayments = v99;
                var v100 = _schedulePaymentTransactions; v100.Clean = value; _schedulePaymentTransactions = v100;
                var v101 = _servicerLoanNumber; v101.Clean = value; _servicerLoanNumber = v101;
                var v102 = _servicingStatus; v102.Clean = value; _servicingStatus = v102;
                var v103 = _servicingTransferDate; v103.Clean = value; _servicingTransferDate = v103;
                var v104 = _subServicer; v104.Clean = value; _subServicer = v104;
                var v105 = _subServicerLoanNumber; v105.Clean = value; _subServicerLoanNumber = v105;
                var v106 = _totalAdditionalEscrow; v106.Clean = value; _totalAdditionalEscrow = v106;
                var v107 = _totalAdditionalEscrowYearToDate; v107.Clean = value; _totalAdditionalEscrowYearToDate = v107;
                var v108 = _totalAdditionalPrincipal; v108.Clean = value; _totalAdditionalPrincipal = v108;
                var v109 = _totalAdditionalPrincipalYearToDate; v109.Clean = value; _totalAdditionalPrincipalYearToDate = v109;
                var v110 = _totalAmountDisbursed; v110.Clean = value; _totalAmountDisbursed = v110;
                var v111 = _totalBuydownSubsidyAmount; v111.Clean = value; _totalBuydownSubsidyAmount = v111;
                var v112 = _totalBuydownSubsidyAmountYearToDate; v112.Clean = value; _totalBuydownSubsidyAmountYearToDate = v112;
                var v113 = _totalEscrow; v113.Clean = value; _totalEscrow = v113;
                var v114 = _totalEscrowYearToDate; v114.Clean = value; _totalEscrowYearToDate = v114;
                var v115 = _totalHazardInsurance; v115.Clean = value; _totalHazardInsurance = v115;
                var v116 = _totalInterest; v116.Clean = value; _totalInterest = v116;
                var v117 = _totalInterestYearToDate; v117.Clean = value; _totalInterestYearToDate = v117;
                var v118 = _totalLateFee; v118.Clean = value; _totalLateFee = v118;
                var v119 = _totalLateFeeYearToDate; v119.Clean = value; _totalLateFeeYearToDate = v119;
                var v120 = _totalMiscFee; v120.Clean = value; _totalMiscFee = v120;
                var v121 = _totalMiscFeeYearToDate; v121.Clean = value; _totalMiscFeeYearToDate = v121;
                var v122 = _totalMortgageInsurance; v122.Clean = value; _totalMortgageInsurance = v122;
                var v123 = _totalNumberOfLatePayment; v123.Clean = value; _totalNumberOfLatePayment = v123;
                var v124 = _totalNumberOfPayment; v124.Clean = value; _totalNumberOfPayment = v124;
                var v125 = _totalOtherTaxes; v125.Clean = value; _totalOtherTaxes = v125;
                var v126 = _totalPAndI; v126.Clean = value; _totalPAndI = v126;
                var v127 = _totalPAndIYearToDate; v127.Clean = value; _totalPAndIYearToDate = v127;
                var v128 = _totalPaymentCollected; v128.Clean = value; _totalPaymentCollected = v128;
                var v129 = _totalPaymentCollectedYearToDate; v129.Clean = value; _totalPaymentCollectedYearToDate = v129;
                var v130 = _totalPrincipal; v130.Clean = value; _totalPrincipal = v130;
                var v131 = _totalPrincipalYearToDate; v131.Clean = value; _totalPrincipalYearToDate = v131;
                var v132 = _totalTaxes; v132.Clean = value; _totalTaxes = v132;
                var v133 = _totalUsdaMonthlyPremium; v133.Clean = value; _totalUsdaMonthlyPremium = v133;
                var v134 = _unpaidBuydownSubsidyAmount; v134.Clean = value; _unpaidBuydownSubsidyAmount = v134;
                var v135 = _unpaidEscrow; v135.Clean = value; _unpaidEscrow = v135;
                var v136 = _unpaidEscrowCityPropertyTax; v136.Clean = value; _unpaidEscrowCityPropertyTax = v136;
                var v137 = _unpaidEscrowFloodInsurance; v137.Clean = value; _unpaidEscrowFloodInsurance = v137;
                var v138 = _unpaidEscrowHazardInsurance; v138.Clean = value; _unpaidEscrowHazardInsurance = v138;
                var v139 = _unpaidEscrowMortgageInsurance; v139.Clean = value; _unpaidEscrowMortgageInsurance = v139;
                var v140 = _unpaidEscrowOther1; v140.Clean = value; _unpaidEscrowOther1 = v140;
                var v141 = _unpaidEscrowOther2; v141.Clean = value; _unpaidEscrowOther2 = v141;
                var v142 = _unpaidEscrowOther3; v142.Clean = value; _unpaidEscrowOther3 = v142;
                var v143 = _unpaidEscrowTax; v143.Clean = value; _unpaidEscrowTax = v143;
                var v144 = _unpaidEscrowUSDAMonthlyPremium; v144.Clean = value; _unpaidEscrowUSDAMonthlyPremium = v144;
                var v145 = _unpaidInterest; v145.Clean = value; _unpaidInterest = v145;
                var v146 = _unpaidLateFee; v146.Clean = value; _unpaidLateFee = v146;
                var v147 = _unpaidMiscrFee; v147.Clean = value; _unpaidMiscrFee = v147;
                var v148 = _unpaidPrincipal; v148.Clean = value; _unpaidPrincipal = v148;
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