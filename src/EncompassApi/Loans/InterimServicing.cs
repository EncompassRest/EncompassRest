using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassApi.Loans.Enums;
using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// InterimServicing
    /// </summary>
    public sealed partial class InterimServicing : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _beginningBalance;
        private DirtyValue<string?>? _borrCellPhoneNumber;
        private DirtyValue<string?>? _borrHomeEmail;
        private DirtyValue<string?>? _borrHomePhoneNumber;
        private DirtyValue<string?>? _borrowerFirstName;
        private DirtyValue<string?>? _borrowerLastName;
        private DirtyValue<string?>? _borrWorkPhoneNumber;
        private DirtyValue<string?>? _calcTriggered;
        private DirtyValue<decimal?>? _cityInsurance;
        private DirtyValue<string?>? _comments;
        private DirtyValue<decimal?>? _currentPrincipalBalance;
        private DirtyValue<decimal?>? _escrowBalance;
        private DirtyList<EscrowDisbursementTransaction>? _escrowDisbursementTransactions;
        private DirtyList<EscrowInterestTransaction>? _escrowInterestTransactions;
        private DirtyValue<decimal?>? _floodInsurance;
        private DirtyValue<string?>? _id;
        private DirtyList<InterimServicingTransaction>? _interimServicingTransactions;
        private DirtyValue<decimal?>? _lastPaymentAdditionalEscrow;
        private DirtyValue<decimal?>? _lastPaymentAdditionalPrincipal;
        private DirtyValue<decimal?>? _lastPaymentBuydownSubsidyAmount;
        private DirtyValue<decimal?>? _lastPaymentEscrowAmount;
        private DirtyValue<decimal?>? _lastPaymentEscrowCityPropertyTax;
        private DirtyValue<decimal?>? _lastPaymentEscrowFloodInsurance;
        private DirtyValue<decimal?>? _lastPaymentEscrowHazardInsurance;
        private DirtyValue<decimal?>? _lastPaymentEscrowMortgageInsurance;
        private DirtyValue<decimal?>? _lastPaymentEscrowOther1;
        private DirtyValue<decimal?>? _lastPaymentEscrowOther2;
        private DirtyValue<decimal?>? _lastPaymentEscrowOther3;
        private DirtyValue<decimal?>? _lastPaymentEscrowTax;
        private DirtyValue<decimal?>? _lastPaymentEscrowUSDAMonthlyPremium;
        private DirtyValue<string?>? _lastPaymentGuid;
        private DirtyValue<decimal?>? _lastPaymentInterest;
        private DirtyValue<decimal?>? _lastPaymentLateFee;
        private DirtyValue<decimal?>? _lastPaymentMiscFee;
        private DirtyValue<int?>? _lastPaymentNumber;
        private DirtyValue<decimal?>? _lastPaymentPrincipal;
        private DirtyValue<decimal?>? _lastPaymentPrincipalAndInterest;
        private DirtyValue<DateTime?>? _lastPaymentReceivedDate;
        private DirtyValue<DateTime?>? _lastPaymentStatementDate;
        private DirtyValue<decimal?>? _lastPaymentTotalAmountReceived;
        private DirtyValue<SchedulePaymentTransaction?>? _lastScheduledPayment;
        private DirtyValue<DateTime?>? _lastStatementPrintedDate;
        private DirtyList<LoanPurchaseTransaction>? _loanPurchaseTransactions;
        private DirtyValue<string?>? _loanSnapshotXml;
        private DirtyValue<string?>? _mailingCity;
        private DirtyValue<string?>? _mailingPostalCode;
        private DirtyValue<StringEnumValue<State>>? _mailingState;
        private DirtyValue<string?>? _mailingStreetAddress;
        private DirtyValue<string?>? _mortgageAccount;
        private DirtyValue<decimal?>? _nextEscrowTotalFloodInsurance;
        private DirtyValue<DateTime?>? _nextEscrowTotalFloodInsuranceDueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalHazardInsurance;
        private DirtyValue<DateTime?>? _nextEscrowTotalHazardInsuranceDueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalMortgageInsurance;
        private DirtyValue<DateTime?>? _nextEscrowTotalMortgageInsuranceDueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalOtherTax1;
        private DirtyValue<DateTime?>? _nextEscrowTotalOtherTax1DueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalOtherTax2;
        private DirtyValue<DateTime?>? _nextEscrowTotalOtherTax2DueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalOtherTax3;
        private DirtyValue<DateTime?>? _nextEscrowTotalOtherTax3DueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalPropertyTax;
        private DirtyValue<DateTime?>? _nextEscrowTotalPropertyTaxDueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalTax;
        private DirtyValue<DateTime?>? _nextEscrowTotalTaxDueDate;
        private DirtyValue<decimal?>? _nextEscrowTotalUsdaMonthlyPremium;
        private DirtyValue<DateTime?>? _nextEscrowTotalUsdaMonthlyPremiumDueDate;
        private DirtyValue<decimal?>? _nextPaymentBuydownSubsidyAmount;
        private DirtyValue<decimal?>? _nextPaymentEscrowAmount;
        private DirtyValue<decimal?>? _nextPaymentEscrowCityPropertyTax;
        private DirtyValue<decimal?>? _nextPaymentEscrowFloodInsurance;
        private DirtyValue<decimal?>? _nextPaymentEscrowHazardInsurance;
        private DirtyValue<decimal?>? _nextPaymentEscrowMortgageInsurance;
        private DirtyValue<decimal?>? _nextPaymentEscrowOther1;
        private DirtyValue<decimal?>? _nextPaymentEscrowOther2;
        private DirtyValue<decimal?>? _nextPaymentEscrowOther3;
        private DirtyValue<decimal?>? _nextPaymentEscrowTax;
        private DirtyValue<decimal?>? _nextPaymentEscrowUSDAMonthlyPremium;
        private DirtyValue<decimal?>? _nextPaymentIndexCurrentValuePercent;
        private DirtyValue<decimal?>? _nextPaymentInterest;
        private DirtyValue<decimal?>? _nextPaymentLateFee;
        private DirtyValue<DateTime?>? _nextPaymentLatePaymentDate;
        private DirtyValue<decimal?>? _nextPaymentMiscFee;
        private DirtyValue<decimal?>? _nextPaymentPastDueAmount;
        private DirtyValue<DateTime?>? _nextPaymentPaymentDueDate;
        private DirtyValue<DateTime?>? _nextPaymentPaymentIndexDate;
        private DirtyValue<decimal?>? _nextPaymentPrincipal;
        private DirtyValue<decimal?>? _nextPaymentPrincipalAndInterest;
        private DirtyValue<decimal?>? _nextPaymentRequestedInterestRatePercent;
        private DirtyValue<DateTime?>? _nextPaymentStatementDueDate;
        private DirtyValue<decimal?>? _nextPaymentTotalAmountDue;
        private DirtyValue<decimal?>? _nextPaymentTotalAmountWithLateFee;
        private DirtyValue<decimal?>? _nextPaymentUnpaidLateFee;
        private DirtyValue<SchedulePaymentTransaction?>? _nextScheduledPayment;
        private DirtyValue<int?>? _numberOfDisbursement;
        private DirtyList<OtherTransaction>? _otherTransactions;
        private DirtyValue<DateTime?>? _paymentDueDatePrinted;
        private DirtyList<PaymentReversalTransaction>? _paymentReversalTransactions;
        private DirtyList<PaymentTransaction>? _paymentTransactions;
        private DirtyValue<string?>? _printedByUserId;
        private DirtyValue<string?>? _printedByUserName;
        private DirtyValue<decimal?>? _purchasedPrincipal;
        private DirtyList<SchedulePaymentTransaction>? _scheduledPayments;
        private DirtyList<SchedulePaymentTransaction>? _schedulePaymentTransactions;
        private DirtyValue<string?>? _servicerLoanNumber;
        private DirtyValue<StringEnumValue<ServicingStatus>>? _servicingStatus;
        private DirtyValue<DateTime?>? _servicingTransferDate;
        private DirtyValue<string?>? _subServicer;
        private DirtyValue<string?>? _subServicerLoanNumber;
        private DirtyValue<decimal?>? _totalAdditionalEscrow;
        private DirtyValue<decimal?>? _totalAdditionalEscrowYearToDate;
        private DirtyValue<decimal?>? _totalAdditionalPrincipal;
        private DirtyValue<decimal?>? _totalAdditionalPrincipalYearToDate;
        private DirtyValue<decimal?>? _totalAmountDisbursed;
        private DirtyValue<decimal?>? _totalBuydownSubsidyAmount;
        private DirtyValue<decimal?>? _totalBuydownSubsidyAmountYearToDate;
        private DirtyValue<decimal?>? _totalEscrow;
        private DirtyValue<decimal?>? _totalEscrowYearToDate;
        private DirtyValue<decimal?>? _totalHazardInsurance;
        private DirtyValue<decimal?>? _totalInterest;
        private DirtyValue<decimal?>? _totalInterestYearToDate;
        private DirtyValue<decimal?>? _totalLateFee;
        private DirtyValue<decimal?>? _totalLateFeeYearToDate;
        private DirtyValue<decimal?>? _totalMiscFee;
        private DirtyValue<decimal?>? _totalMiscFeeYearToDate;
        private DirtyValue<decimal?>? _totalMortgageInsurance;
        private DirtyValue<int?>? _totalNumberOfLatePayment;
        private DirtyValue<int?>? _totalNumberOfPayment;
        private DirtyValue<decimal?>? _totalOtherTaxes;
        private DirtyValue<decimal?>? _totalPAndI;
        private DirtyValue<decimal?>? _totalPAndIYearToDate;
        private DirtyValue<decimal?>? _totalPaymentCollected;
        private DirtyValue<decimal?>? _totalPaymentCollectedYearToDate;
        private DirtyValue<decimal?>? _totalPrincipal;
        private DirtyValue<decimal?>? _totalPrincipalYearToDate;
        private DirtyValue<decimal?>? _totalTaxes;
        private DirtyValue<decimal?>? _totalUsdaMonthlyPremium;
        private DirtyValue<decimal?>? _unpaidBuydownSubsidyAmount;
        private DirtyValue<decimal?>? _unpaidEscrow;
        private DirtyValue<decimal?>? _unpaidEscrowCityPropertyTax;
        private DirtyValue<decimal?>? _unpaidEscrowFloodInsurance;
        private DirtyValue<decimal?>? _unpaidEscrowHazardInsurance;
        private DirtyValue<decimal?>? _unpaidEscrowMortgageInsurance;
        private DirtyValue<decimal?>? _unpaidEscrowOther1;
        private DirtyValue<decimal?>? _unpaidEscrowOther2;
        private DirtyValue<decimal?>? _unpaidEscrowOther3;
        private DirtyValue<decimal?>? _unpaidEscrowTax;
        private DirtyValue<decimal?>? _unpaidEscrowUSDAMonthlyPremium;
        private DirtyValue<decimal?>? _unpaidInterest;
        private DirtyValue<decimal?>? _unpaidLateFee;
        private DirtyValue<decimal?>? _unpaidMiscrFee;
        private DirtyValue<decimal?>? _unpaidPrincipal;

        /// <summary>
        /// Intrm Serv Beginning Balance [SERVICE.X144]
        /// </summary>
        public decimal? BeginningBalance { get => _beginningBalance; set => SetField(ref _beginningBalance, value); }

        /// <summary>
        /// Intrm Serv Borr Cell [SERVICE.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? BorrCellPhoneNumber { get => _borrCellPhoneNumber; set => SetField(ref _borrCellPhoneNumber, value); }

        /// <summary>
        /// Intrm Serv Borr Email [SERVICE.X143]
        /// </summary>
        public string? BorrHomeEmail { get => _borrHomeEmail; set => SetField(ref _borrHomeEmail, value); }

        /// <summary>
        /// Intrm Serv Borr Home Phone [SERVICE.X140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? BorrHomePhoneNumber { get => _borrHomePhoneNumber; set => SetField(ref _borrHomePhoneNumber, value); }

        /// <summary>
        /// Intrm Serv Borrower First Name [SERVICE.X2]
        /// </summary>
        public string? BorrowerFirstName { get => _borrowerFirstName; set => SetField(ref _borrowerFirstName, value); }

        /// <summary>
        /// Intrm Serv Borrower Last Name [SERVICE.X3]
        /// </summary>
        public string? BorrowerLastName { get => _borrowerLastName; set => SetField(ref _borrowerLastName, value); }

        /// <summary>
        /// Intrm Serv Borr Business Phone [SERVICE.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string? BorrWorkPhoneNumber { get => _borrWorkPhoneNumber; set => SetField(ref _borrWorkPhoneNumber, value); }

        /// <summary>
        /// Intrm Serv Calc Flag [SERVICE.X999]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? CalcTriggered { get => _calcTriggered; set => SetField(ref _calcTriggered, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary City Insurance [SERVICE.X90]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CityInsurance { get => _cityInsurance; set => SetField(ref _cityInsurance, value); }

        /// <summary>
        /// Intrm Serv Comments [SERVICE.Comments]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Prncpl Balance [SERVICE.X57]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CurrentPrincipalBalance { get => _currentPrincipalBalance; set => SetField(ref _currentPrincipalBalance, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Balance [SERVICE.X81]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? EscrowBalance { get => _escrowBalance; set => SetField(ref _escrowBalance, value); }

        /// <summary>
        /// InterimServicing EscrowDisbursementTransactions
        /// </summary>
        [AllowNull]
        public IList<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get => GetField(ref _escrowDisbursementTransactions); set => SetField(ref _escrowDisbursementTransactions, value); }

        /// <summary>
        /// InterimServicing EscrowInterestTransactions
        /// </summary>
        [AllowNull]
        public IList<EscrowInterestTransaction> EscrowInterestTransactions { get => GetField(ref _escrowInterestTransactions); set => SetField(ref _escrowInterestTransactions, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Flood Insurance [SERVICE.X89]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }

        /// <summary>
        /// InterimServicing Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// InterimServicing InterimServicingTransactions
        /// </summary>
        [AllowNull]
        public IList<InterimServicingTransaction> InterimServicingTransactions { get => GetField(ref _interimServicingTransactions); set => SetField(ref _interimServicingTransactions, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Add'l Escrow [SERVICE.X86]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentAdditionalEscrow { get => _lastPaymentAdditionalEscrow; set => SetField(ref _lastPaymentAdditionalEscrow, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Add'l Pnicpl [SERVICE.X38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentAdditionalPrincipal { get => _lastPaymentAdditionalPrincipal; set => SetField(ref _lastPaymentAdditionalPrincipal, value); }

        /// <summary>
        /// Intrm Serv Last Pymt Buydown Subsidy Amt [SERVICE.X101]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentBuydownSubsidyAmount { get => _lastPaymentBuydownSubsidyAmount; set => SetField(ref _lastPaymentBuydownSubsidyAmount, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Escrow [SERVICE.X36]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowAmount { get => _lastPaymentEscrowAmount; set => SetField(ref _lastPaymentEscrowAmount, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt City Property Tax [SERVICE.X125]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowCityPropertyTax { get => _lastPaymentEscrowCityPropertyTax; set => SetField(ref _lastPaymentEscrowCityPropertyTax, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X124]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowFloodInsurance { get => _lastPaymentEscrowFloodInsurance; set => SetField(ref _lastPaymentEscrowFloodInsurance, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Hazard Insurance [SERVICE.X122]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowHazardInsurance { get => _lastPaymentEscrowHazardInsurance; set => SetField(ref _lastPaymentEscrowHazardInsurance, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Mortgage Insurance [SERVICE.X123]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowMortgageInsurance { get => _lastPaymentEscrowMortgageInsurance; set => SetField(ref _lastPaymentEscrowMortgageInsurance, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Other1 Escrow [SERVICE.X126]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowOther1 { get => _lastPaymentEscrowOther1; set => SetField(ref _lastPaymentEscrowOther1, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Other2 Escrow [SERVICE.X127]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowOther2 { get => _lastPaymentEscrowOther2; set => SetField(ref _lastPaymentEscrowOther2, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Other3 Escrow [SERVICE.X128]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowOther3 { get => _lastPaymentEscrowOther3; set => SetField(ref _lastPaymentEscrowOther3, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X121]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowTax { get => _lastPaymentEscrowTax; set => SetField(ref _lastPaymentEscrowTax, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt USDA Monthly Premuim [SERVICE.X129]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get => _lastPaymentEscrowUSDAMonthlyPremium; set => SetField(ref _lastPaymentEscrowUSDAMonthlyPremium, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt GUID [SERVICE.LASTGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? LastPaymentGuid { get => _lastPaymentGuid; set => SetField(ref _lastPaymentGuid, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Interest [SERVICE.X35]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentInterest { get => _lastPaymentInterest; set => SetField(ref _lastPaymentInterest, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Late Fee [SERVICE.X37]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentLateFee { get => _lastPaymentLateFee; set => SetField(ref _lastPaymentLateFee, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Misc Fee [SERVICE.X85]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentMiscFee { get => _lastPaymentMiscFee; set => SetField(ref _lastPaymentMiscFee, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Pymnt Number [SERVICE.X30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? LastPaymentNumber { get => _lastPaymentNumber; set => SetField(ref _lastPaymentNumber, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Principal [SERVICE.X34]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentPrincipal { get => _lastPaymentPrincipal; set => SetField(ref _lastPaymentPrincipal, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Prncpl and Int. [SERVICE.X83]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentPrincipalAndInterest { get => _lastPaymentPrincipalAndInterest; set => SetField(ref _lastPaymentPrincipalAndInterest, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Rcvd Date [SERVICE.X32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => SetField(ref _lastPaymentReceivedDate, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Statement Date [SERVICE.X31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? LastPaymentStatementDate { get => _lastPaymentStatementDate; set => SetField(ref _lastPaymentStatementDate, value); }

        /// <summary>
        /// Intrm Serv Last Pymnt Amount Rcvd [SERVICE.X33]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? LastPaymentTotalAmountReceived { get => _lastPaymentTotalAmountReceived; set => SetField(ref _lastPaymentTotalAmountReceived, value); }

        /// <summary>
        /// InterimServicing LastScheduledPayment
        /// </summary>
        public SchedulePaymentTransaction? LastScheduledPayment { get => _lastScheduledPayment; set => SetField(ref _lastScheduledPayment, value); }

        /// <summary>
        /// Intrm Serv Current Status Last Statement Printed [SERVICE.X9]
        /// </summary>
        public DateTime? LastStatementPrintedDate { get => _lastStatementPrintedDate; set => SetField(ref _lastStatementPrintedDate, value); }

        /// <summary>
        /// InterimServicing LoanPurchaseTransactions
        /// </summary>
        [AllowNull]
        public IList<LoanPurchaseTransaction> LoanPurchaseTransactions { get => GetField(ref _loanPurchaseTransactions); set => SetField(ref _loanPurchaseTransactions, value); }

        /// <summary>
        /// InterimServicing LoanSnapshotXml
        /// </summary>
        public string? LoanSnapshotXml { get => _loanSnapshotXml; set => SetField(ref _loanSnapshotXml, value); }

        /// <summary>
        /// Intrm Serv Mailing Address City [SERVICE.X5]
        /// </summary>
        public string? MailingCity { get => _mailingCity; set => SetField(ref _mailingCity, value); }

        /// <summary>
        /// Intrm Serv Mailing Address ZIP Code [SERVICE.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string? MailingPostalCode { get => _mailingPostalCode; set => SetField(ref _mailingPostalCode, value); }

        /// <summary>
        /// Intrm Serv Mailing Address State [SERVICE.X6]
        /// </summary>
        public StringEnumValue<State> MailingState { get => _mailingState; set => SetField(ref _mailingState, value); }

        /// <summary>
        /// Intrm Serv Mailing Address Street [SERVICE.X4]
        /// </summary>
        public string? MailingStreetAddress { get => _mailingStreetAddress; set => SetField(ref _mailingStreetAddress, value); }

        /// <summary>
        /// Intrm Serv Mrtg Accnt No [SERVICE.X1]
        /// </summary>
        public string? MortgageAccount { get => _mortgageAccount; set => SetField(ref _mortgageAccount, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Total Flood Insurance [SERVICE.X64]
        /// </summary>
        public decimal? NextEscrowTotalFloodInsurance { get => _nextEscrowTotalFloodInsurance; set => SetField(ref _nextEscrowTotalFloodInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Flood Insurance Due Date [SERVICE.X65]
        /// </summary>
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get => _nextEscrowTotalFloodInsuranceDueDate; set => SetField(ref _nextEscrowTotalFloodInsuranceDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Total Hzrd Insurance [SERVICE.X60]
        /// </summary>
        public decimal? NextEscrowTotalHazardInsurance { get => _nextEscrowTotalHazardInsurance; set => SetField(ref _nextEscrowTotalHazardInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Hzrd Insurance Due Date [SERVICE.X61]
        /// </summary>
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get => _nextEscrowTotalHazardInsuranceDueDate; set => SetField(ref _nextEscrowTotalHazardInsuranceDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Total Mortgage Insurance [SERVICE.X62]
        /// </summary>
        public decimal? NextEscrowTotalMortgageInsurance { get => _nextEscrowTotalMortgageInsurance; set => SetField(ref _nextEscrowTotalMortgageInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Mortgage Insurance Due Date [SERVICE.X63]
        /// </summary>
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get => _nextEscrowTotalMortgageInsuranceDueDate; set => SetField(ref _nextEscrowTotalMortgageInsuranceDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 1 [SERVICE.X68]
        /// </summary>
        public decimal? NextEscrowTotalOtherTax1 { get => _nextEscrowTotalOtherTax1; set => SetField(ref _nextEscrowTotalOtherTax1, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 1 Due Date [SERVICE.X69]
        /// </summary>
        public DateTime? NextEscrowTotalOtherTax1DueDate { get => _nextEscrowTotalOtherTax1DueDate; set => SetField(ref _nextEscrowTotalOtherTax1DueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 2 [SERVICE.X70]
        /// </summary>
        public decimal? NextEscrowTotalOtherTax2 { get => _nextEscrowTotalOtherTax2; set => SetField(ref _nextEscrowTotalOtherTax2, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 2 Due Date [SERVICE.X71]
        /// </summary>
        public DateTime? NextEscrowTotalOtherTax2DueDate { get => _nextEscrowTotalOtherTax2DueDate; set => SetField(ref _nextEscrowTotalOtherTax2DueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 3 [SERVICE.X72]
        /// </summary>
        public decimal? NextEscrowTotalOtherTax3 { get => _nextEscrowTotalOtherTax3; set => SetField(ref _nextEscrowTotalOtherTax3, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 3 Due Date [SERVICE.X73]
        /// </summary>
        public DateTime? NextEscrowTotalOtherTax3DueDate { get => _nextEscrowTotalOtherTax3DueDate; set => SetField(ref _nextEscrowTotalOtherTax3DueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Total PropertyTax [SERVICE.X66]
        /// </summary>
        public decimal? NextEscrowTotalPropertyTax { get => _nextEscrowTotalPropertyTax; set => SetField(ref _nextEscrowTotalPropertyTax, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Property Tax Due Date [SERVICE.X67]
        /// </summary>
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get => _nextEscrowTotalPropertyTaxDueDate; set => SetField(ref _nextEscrowTotalPropertyTaxDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Total Taxes [SERVICE.X58]
        /// </summary>
        public decimal? NextEscrowTotalTax { get => _nextEscrowTotalTax; set => SetField(ref _nextEscrowTotalTax, value); }

        /// <summary>
        /// Intrm Serv Next Escrow Tax Due Date [SERVICE.X59]
        /// </summary>
        public DateTime? NextEscrowTotalTaxDueDate { get => _nextEscrowTotalTaxDueDate; set => SetField(ref _nextEscrowTotalTaxDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Escrow USDA Monthly Premium [SERVICE.X105]
        /// </summary>
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get => _nextEscrowTotalUsdaMonthlyPremium; set => SetField(ref _nextEscrowTotalUsdaMonthlyPremium, value); }

        /// <summary>
        /// Intrm Serv Next Escrow USDA Monthly Premium Due Date [SERVICE.X106]
        /// </summary>
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get => _nextEscrowTotalUsdaMonthlyPremiumDueDate; set => SetField(ref _nextEscrowTotalUsdaMonthlyPremiumDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Pymt Buydown Subsidy Amt [SERVICE.X100]
        /// </summary>
        public decimal? NextPaymentBuydownSubsidyAmount { get => _nextPaymentBuydownSubsidyAmount; set => SetField(ref _nextPaymentBuydownSubsidyAmount, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Escrow [SERVICE.X20]
        /// </summary>
        public decimal? NextPaymentEscrowAmount { get => _nextPaymentEscrowAmount; set => SetField(ref _nextPaymentEscrowAmount, value); }

        /// <summary>
        /// Intrm Serv Next Payment City Property Tax [SERVICE.X116]
        /// </summary>
        public decimal? NextPaymentEscrowCityPropertyTax { get => _nextPaymentEscrowCityPropertyTax; set => SetField(ref _nextPaymentEscrowCityPropertyTax, value); }

        /// <summary>
        /// Intrm Serv Next Payment Flood Insurance [SERVICE.X115]
        /// </summary>
        public decimal? NextPaymentEscrowFloodInsurance { get => _nextPaymentEscrowFloodInsurance; set => SetField(ref _nextPaymentEscrowFloodInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Payment Hazard Insurance [SERVICE.X113]
        /// </summary>
        public decimal? NextPaymentEscrowHazardInsurance { get => _nextPaymentEscrowHazardInsurance; set => SetField(ref _nextPaymentEscrowHazardInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Payment Mortgage Insurance [SERVICE.X114]
        /// </summary>
        public decimal? NextPaymentEscrowMortgageInsurance { get => _nextPaymentEscrowMortgageInsurance; set => SetField(ref _nextPaymentEscrowMortgageInsurance, value); }

        /// <summary>
        /// Intrm Serv Next Payment Other1 Escrow [SERVICE.X117]
        /// </summary>
        public decimal? NextPaymentEscrowOther1 { get => _nextPaymentEscrowOther1; set => SetField(ref _nextPaymentEscrowOther1, value); }

        /// <summary>
        /// Intrm Serv Next Payment Other2 Escrow [SERVICE.X119]
        /// </summary>
        public decimal? NextPaymentEscrowOther2 { get => _nextPaymentEscrowOther2; set => SetField(ref _nextPaymentEscrowOther2, value); }

        /// <summary>
        /// Intrm Serv Next Payment Other3 Escrow [SERVICE.X120]
        /// </summary>
        public decimal? NextPaymentEscrowOther3 { get => _nextPaymentEscrowOther3; set => SetField(ref _nextPaymentEscrowOther3, value); }

        /// <summary>
        /// Intrm Serv Next Payment Escrow Taxes [SERVICE.X112]
        /// </summary>
        public decimal? NextPaymentEscrowTax { get => _nextPaymentEscrowTax; set => SetField(ref _nextPaymentEscrowTax, value); }

        /// <summary>
        /// Intrm Serv Next Payment USDA Monthly Premuim [SERVICE.X118]
        /// </summary>
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get => _nextPaymentEscrowUSDAMonthlyPremium; set => SetField(ref _nextPaymentEscrowUSDAMonthlyPremium, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Index Rate [SERVICE.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? NextPaymentIndexCurrentValuePercent { get => _nextPaymentIndexCurrentValuePercent; set => SetField(ref _nextPaymentIndexCurrentValuePercent, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Interest [SERVICE.X19]
        /// </summary>
        public decimal? NextPaymentInterest { get => _nextPaymentInterest; set => SetField(ref _nextPaymentInterest, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Late Fee [SERVICE.X25]
        /// </summary>
        public decimal? NextPaymentLateFee { get => _nextPaymentLateFee; set => SetField(ref _nextPaymentLateFee, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Late Pymnt Date [SERVICE.X15]
        /// </summary>
        public DateTime? NextPaymentLatePaymentDate { get => _nextPaymentLatePaymentDate; set => SetField(ref _nextPaymentLatePaymentDate, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Misc Fee [SERVICE.X23]
        /// </summary>
        public decimal? NextPaymentMiscFee { get => _nextPaymentMiscFee; set => SetField(ref _nextPaymentMiscFee, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Past Due Amnt [SERVICE.X21]
        /// </summary>
        public decimal? NextPaymentPastDueAmount { get => _nextPaymentPastDueAmount; set => SetField(ref _nextPaymentPastDueAmount, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Pymnt Due Date [SERVICE.X14]
        /// </summary>
        public DateTime? NextPaymentPaymentDueDate { get => _nextPaymentPaymentDueDate; set => SetField(ref _nextPaymentPaymentDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Payment Index Date [SERVICE.X99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? NextPaymentPaymentIndexDate { get => _nextPaymentPaymentIndexDate; set => SetField(ref _nextPaymentPaymentIndexDate, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Principal [SERVICE.X18]
        /// </summary>
        public decimal? NextPaymentPrincipal { get => _nextPaymentPrincipal; set => SetField(ref _nextPaymentPrincipal, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Prncpl and Int. [SERVICE.X82]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? NextPaymentPrincipalAndInterest { get => _nextPaymentPrincipalAndInterest; set => SetField(ref _nextPaymentPrincipalAndInterest, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Interest Rate [SERVICE.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? NextPaymentRequestedInterestRatePercent { get => _nextPaymentRequestedInterestRatePercent; set => SetField(ref _nextPaymentRequestedInterestRatePercent, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Statement Due Date [SERVICE.X13]
        /// </summary>
        public DateTime? NextPaymentStatementDueDate { get => _nextPaymentStatementDueDate; set => SetField(ref _nextPaymentStatementDueDate, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Total Amnt Due [SERVICE.X24]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? NextPaymentTotalAmountDue { get => _nextPaymentTotalAmountDue; set => SetField(ref _nextPaymentTotalAmountDue, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Total Amnt and Late Fee [SERVICE.X26]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? NextPaymentTotalAmountWithLateFee { get => _nextPaymentTotalAmountWithLateFee; set => SetField(ref _nextPaymentTotalAmountWithLateFee, value); }

        /// <summary>
        /// Intrm Serv Next Pymnt Unpaid Late Fee [SERVICE.X22]
        /// </summary>
        public decimal? NextPaymentUnpaidLateFee { get => _nextPaymentUnpaidLateFee; set => SetField(ref _nextPaymentUnpaidLateFee, value); }

        /// <summary>
        /// InterimServicing NextScheduledPayment
        /// </summary>
        public SchedulePaymentTransaction? NextScheduledPayment { get => _nextScheduledPayment; set => SetField(ref _nextScheduledPayment, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Number of Disbursement [SERVICE.X74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? NumberOfDisbursement { get => _numberOfDisbursement; set => SetField(ref _numberOfDisbursement, value); }

        /// <summary>
        /// InterimServicing OtherTransactions
        /// </summary>
        [AllowNull]
        public IList<OtherTransaction> OtherTransactions { get => GetField(ref _otherTransactions); set => SetField(ref _otherTransactions, value); }

        /// <summary>
        /// Intrm Serv Pymnt Due Date Printed [SERVICE.X10]
        /// </summary>
        public DateTime? PaymentDueDatePrinted { get => _paymentDueDatePrinted; set => SetField(ref _paymentDueDatePrinted, value); }

        /// <summary>
        /// InterimServicing PaymentReversalTransactions
        /// </summary>
        [AllowNull]
        public IList<PaymentReversalTransaction> PaymentReversalTransactions { get => GetField(ref _paymentReversalTransactions); set => SetField(ref _paymentReversalTransactions, value); }

        /// <summary>
        /// InterimServicing PaymentTransactions
        /// </summary>
        [AllowNull]
        public IList<PaymentTransaction> PaymentTransactions { get => GetField(ref _paymentTransactions); set => SetField(ref _paymentTransactions, value); }

        /// <summary>
        /// Intrm Serv Current Status Printed By User ID [SERVICE.X12]
        /// </summary>
        public string? PrintedByUserId { get => _printedByUserId; set => SetField(ref _printedByUserId, value); }

        /// <summary>
        /// Intrm Serv Current Status Printed By User Name [SERVICE.X11]
        /// </summary>
        public string? PrintedByUserName { get => _printedByUserName; set => SetField(ref _printedByUserName, value); }

        /// <summary>
        /// Intrm Serv Purchase Advice Summary Principal [SERVICE.X139]
        /// </summary>
        public decimal? PurchasedPrincipal { get => _purchasedPrincipal; set => SetField(ref _purchasedPrincipal, value); }

        /// <summary>
        /// InterimServicing ScheduledPayments
        /// </summary>
        [AllowNull]
        public IList<SchedulePaymentTransaction> ScheduledPayments { get => GetField(ref _scheduledPayments); set => SetField(ref _scheduledPayments, value); }

        /// <summary>
        /// InterimServicing SchedulePaymentTransactions
        /// </summary>
        [AllowNull]
        public IList<SchedulePaymentTransaction> SchedulePaymentTransactions { get => GetField(ref _schedulePaymentTransactions); set => SetField(ref _schedulePaymentTransactions, value); }

        /// <summary>
        /// Intrm Serv Servicer Loan Number [SERVICE.X108]
        /// </summary>
        public string? ServicerLoanNumber { get => _servicerLoanNumber; set => SetField(ref _servicerLoanNumber, value); }

        /// <summary>
        /// Intrm Serv Current Status [SERVICE.X8]
        /// </summary>
        public StringEnumValue<ServicingStatus> ServicingStatus { get => _servicingStatus; set => SetField(ref _servicingStatus, value); }

        /// <summary>
        /// Intrm Serv Servicing Transfer Date [SERVICE.X109]
        /// </summary>
        public DateTime? ServicingTransferDate { get => _servicingTransferDate; set => SetField(ref _servicingTransferDate, value); }

        /// <summary>
        /// Intrm Serv Servicing Sub - Servicer [SERVICE.X110]
        /// </summary>
        public string? SubServicer { get => _subServicer; set => SetField(ref _subServicer, value); }

        /// <summary>
        /// Intrm Serv Sub - Servicer Loan Number [SERVICE.X111]
        /// </summary>
        public string? SubServicerLoanNumber { get => _subServicerLoanNumber; set => SetField(ref _subServicerLoanNumber, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Add'l Escrow [SERVICE.X53]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalAdditionalEscrow { get => _totalAdditionalEscrow; set => SetField(ref _totalAdditionalEscrow, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Add'l Escrow [SERVICE.X54]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalAdditionalEscrowYearToDate { get => _totalAdditionalEscrowYearToDate; set => SetField(ref _totalAdditionalEscrowYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Add'l Prncpl [SERVICE.X51]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalAdditionalPrincipal { get => _totalAdditionalPrincipal; set => SetField(ref _totalAdditionalPrincipal, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Add'l Prncpl [SERVICE.X52]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalAdditionalPrincipalYearToDate { get => _totalAdditionalPrincipalYearToDate; set => SetField(ref _totalAdditionalPrincipalYearToDate, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total Amnt Disbursed [SERVICE.X80]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalAmountDisbursed { get => _totalAmountDisbursed; set => SetField(ref _totalAmountDisbursed, value); }

        /// <summary>
        /// Intrm Serv Pymt Summary Total Bdown Subsidy Amt [SERVICE.X102]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalBuydownSubsidyAmount { get => _totalBuydownSubsidyAmount; set => SetField(ref _totalBuydownSubsidyAmount, value); }

        /// <summary>
        /// Intrm Serv Pymt Summary Yr to Date Bdown Subsidy [SERVICE.X103]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalBuydownSubsidyAmountYearToDate { get => _totalBuydownSubsidyAmountYearToDate; set => SetField(ref _totalBuydownSubsidyAmountYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Escrow [SERVICE.X47]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalEscrow { get => _totalEscrow; set => SetField(ref _totalEscrow, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Escrow [SERVICE.X48]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalEscrowYearToDate { get => _totalEscrowYearToDate; set => SetField(ref _totalEscrowYearToDate, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total Hzrd Insurance [SERVICE.X76]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalHazardInsurance { get => _totalHazardInsurance; set => SetField(ref _totalHazardInsurance, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Interest [SERVICE.X43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalInterest { get => _totalInterest; set => SetField(ref _totalInterest, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Int [SERVICE.X44]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalInterestYearToDate { get => _totalInterestYearToDate; set => SetField(ref _totalInterestYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Late Fee [SERVICE.X49]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalLateFee { get => _totalLateFee; set => SetField(ref _totalLateFee, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Late Fee [SERVICE.X50]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalLateFeeYearToDate { get => _totalLateFeeYearToDate; set => SetField(ref _totalLateFeeYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Misc Fee [SERVICE.X87]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMiscFee { get => _totalMiscFee; set => SetField(ref _totalMiscFee, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Misc Fee [SERVICE.X88]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMiscFeeYearToDate { get => _totalMiscFeeYearToDate; set => SetField(ref _totalMiscFeeYearToDate, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total Mrtg Insurance [SERVICE.X77]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalMortgageInsurance { get => _totalMortgageInsurance; set => SetField(ref _totalMortgageInsurance, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Nmbr of Late Pymnts [SERVICE.X40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? TotalNumberOfLatePayment { get => _totalNumberOfLatePayment; set => SetField(ref _totalNumberOfLatePayment, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Nmbr of Pymnt [SERVICE.X39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? TotalNumberOfPayment { get => _totalNumberOfPayment; set => SetField(ref _totalNumberOfPayment, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total Other Taxes [SERVICE.X79]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalOtherTaxes { get => _totalOtherTaxes; set => SetField(ref _totalOtherTaxes, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Prncpl and Int [SERVICE.X45]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPAndI { get => _totalPAndI; set => SetField(ref _totalPAndI, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Prncpl and Int [SERVICE.X46]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPAndIYearToDate { get => _totalPAndIYearToDate; set => SetField(ref _totalPAndIYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Pymnt Collected [SERVICE.X55]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPaymentCollected { get => _totalPaymentCollected; set => SetField(ref _totalPaymentCollected, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Pymnt Collected [SERVICE.X56]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPaymentCollectedYearToDate { get => _totalPaymentCollectedYearToDate; set => SetField(ref _totalPaymentCollectedYearToDate, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Total Prncpl [SERVICE.X41]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPrincipal { get => _totalPrincipal; set => SetField(ref _totalPrincipal, value); }

        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Prncpl [SERVICE.X42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalPrincipalYearToDate { get => _totalPrincipalYearToDate; set => SetField(ref _totalPrincipalYearToDate, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total Property City Taxes [SERVICE.X75]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalTaxes { get => _totalTaxes; set => SetField(ref _totalTaxes, value); }

        /// <summary>
        /// Intrm Serv Escrow Summary Total USDA Monthly Premium [SERVICE.X107]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalUsdaMonthlyPremium { get => _totalUsdaMonthlyPremium; set => SetField(ref _totalUsdaMonthlyPremium, value); }

        /// <summary>
        /// Intrm Serv Escrow Sumry Unpaid Bdown Subsidy Amt [SERVICE.X104]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidBuydownSubsidyAmount { get => _unpaidBuydownSubsidyAmount; set => SetField(ref _unpaidBuydownSubsidyAmount, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow [SERVICE.X93]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrow { get => _unpaidEscrow; set => SetField(ref _unpaidEscrow, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow City Property Tax [SERVICE.X134]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowCityPropertyTax { get => _unpaidEscrowCityPropertyTax; set => SetField(ref _unpaidEscrowCityPropertyTax, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Flood Insurance [SERVICE.X133]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowFloodInsurance { get => _unpaidEscrowFloodInsurance; set => SetField(ref _unpaidEscrowFloodInsurance, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Hazard Insurance [SERVICE.X132]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowHazardInsurance { get => _unpaidEscrowHazardInsurance; set => SetField(ref _unpaidEscrowHazardInsurance, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Mortgage Insurance [SERVICE.X131]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowMortgageInsurance { get => _unpaidEscrowMortgageInsurance; set => SetField(ref _unpaidEscrowMortgageInsurance, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other1 [SERVICE.X135]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowOther1 { get => _unpaidEscrowOther1; set => SetField(ref _unpaidEscrowOther1, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other2 [SERVICE.X136]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowOther2 { get => _unpaidEscrowOther2; set => SetField(ref _unpaidEscrowOther2, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other3 [SERVICE.X137]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowOther3 { get => _unpaidEscrowOther3; set => SetField(ref _unpaidEscrowOther3, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Tax [SERVICE.X130]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowTax { get => _unpaidEscrowTax; set => SetField(ref _unpaidEscrowTax, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid USDA Monthly Premium [SERVICE.X138]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get => _unpaidEscrowUSDAMonthlyPremium; set => SetField(ref _unpaidEscrowUSDAMonthlyPremium, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Interest [SERVICE.X92]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidInterest { get => _unpaidInterest; set => SetField(ref _unpaidInterest, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Late Fee [SERVICE.X95]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidLateFee { get => _unpaidLateFee; set => SetField(ref _unpaidLateFee, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Misc Fee [SERVICE.X94]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidMiscrFee { get => _unpaidMiscrFee; set => SetField(ref _unpaidMiscrFee, value); }

        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Principal [SERVICE.X91]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? UnpaidPrincipal { get => _unpaidPrincipal; set => SetField(ref _unpaidPrincipal, value); }
    }
}