using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class InterimServicing : IDirty
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
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
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
                    || _escrowDisbursementTransactions.Dirty
                    || _escrowInterestTransactions.Dirty
                    || _floodInsurance.Dirty
                    || _id.Dirty
                    || _interimServicingTransactions.Dirty
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
                    || _otherTransactions.Dirty
                    || _paymentDueDatePrinted.Dirty
                    || _paymentReversalTransactions.Dirty
                    || _paymentTransactions.Dirty
                    || _printedByUserId.Dirty
                    || _printedByUserName.Dirty
                    || _purchasedPrincipal.Dirty
                    || _scheduledPayments.Dirty
                    || _schedulePaymentTransactions.Dirty
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
                    || LastScheduledPayment?.Dirty == true
                    || NextScheduledPayment?.Dirty == true;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _escrowDisbursementTransactions.Dirty = value;
                _escrowInterestTransactions.Dirty = value;
                _floodInsurance.Dirty = value;
                _id.Dirty = value;
                _interimServicingTransactions.Dirty = value;
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
                _otherTransactions.Dirty = value;
                _paymentDueDatePrinted.Dirty = value;
                _paymentReversalTransactions.Dirty = value;
                _paymentTransactions.Dirty = value;
                _printedByUserId.Dirty = value;
                _printedByUserName.Dirty = value;
                _purchasedPrincipal.Dirty = value;
                _scheduledPayments.Dirty = value;
                _schedulePaymentTransactions.Dirty = value;
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
                if (LastScheduledPayment != null) LastScheduledPayment.Dirty = value;
                if (NextScheduledPayment != null) NextScheduledPayment.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}