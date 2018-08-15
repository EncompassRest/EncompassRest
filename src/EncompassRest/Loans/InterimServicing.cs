using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// InterimServicing
    /// </summary>
    public sealed partial class InterimServicing : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _beginningBalance;
        /// <summary>
        /// Intrm Serv Beginning Balance [SERVICE.X144]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Beginning Balance")]
        public decimal? BeginningBalance { get => _beginningBalance; set => SetField(ref _beginningBalance, value); }
        private DirtyValue<string> _borrCellPhoneNumber;
        /// <summary>
        /// Intrm Serv Borr Cell [SERVICE.X142]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Intrm Serv Borr Cell")]
        public string BorrCellPhoneNumber { get => _borrCellPhoneNumber; set => SetField(ref _borrCellPhoneNumber, value); }
        private DirtyValue<string> _borrHomeEmail;
        /// <summary>
        /// Intrm Serv Borr Email [SERVICE.X143]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Borr Email")]
        public string BorrHomeEmail { get => _borrHomeEmail; set => SetField(ref _borrHomeEmail, value); }
        private DirtyValue<string> _borrHomePhoneNumber;
        /// <summary>
        /// Intrm Serv Borr Home Phone [SERVICE.X140]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Intrm Serv Borr Home Phone")]
        public string BorrHomePhoneNumber { get => _borrHomePhoneNumber; set => SetField(ref _borrHomePhoneNumber, value); }
        private DirtyValue<string> _borrowerFirstName;
        /// <summary>
        /// Intrm Serv Borrower First Name [SERVICE.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Borrower First Name")]
        public string BorrowerFirstName { get => _borrowerFirstName; set => SetField(ref _borrowerFirstName, value); }
        private DirtyValue<string> _borrowerLastName;
        /// <summary>
        /// Intrm Serv Borrower Last Name [SERVICE.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Borrower Last Name")]
        public string BorrowerLastName { get => _borrowerLastName; set => SetField(ref _borrowerLastName, value); }
        private DirtyValue<string> _borrWorkPhoneNumber;
        /// <summary>
        /// Intrm Serv Borr Business Phone [SERVICE.X141]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Intrm Serv Borr Business Phone")]
        public string BorrWorkPhoneNumber { get => _borrWorkPhoneNumber; set => SetField(ref _borrWorkPhoneNumber, value); }
        private DirtyValue<string> _calcTriggered;
        /// <summary>
        /// Intrm Serv Calc Flag [SERVICE.X999]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Calc Flag")]
        public string CalcTriggered { get => _calcTriggered; set => SetField(ref _calcTriggered, value); }
        private DirtyValue<decimal?> _cityInsurance;
        /// <summary>
        /// Intrm Serv Escrow Summary City Insurance [SERVICE.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary City Insurance")]
        public decimal? CityInsurance { get => _cityInsurance; set => SetField(ref _cityInsurance, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// Intrm Serv Comments [SERVICE.Comments]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Comments")]
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<decimal?> _currentPrincipalBalance;
        /// <summary>
        /// Intrm Serv Pymnt Summary Prncpl Balance [SERVICE.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Prncpl Balance")]
        public decimal? CurrentPrincipalBalance { get => _currentPrincipalBalance; set => SetField(ref _currentPrincipalBalance, value); }
        private DirtyValue<decimal?> _escrowBalance;
        /// <summary>
        /// Intrm Serv Escrow Summary Balance [SERVICE.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Balance")]
        public decimal? EscrowBalance { get => _escrowBalance; set => SetField(ref _escrowBalance, value); }
        private DirtyList<EscrowDisbursementTransaction> _escrowDisbursementTransactions;
        /// <summary>
        /// InterimServicing EscrowDisbursementTransactions
        /// </summary>
        public IList<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get => GetField(ref _escrowDisbursementTransactions); set => SetField(ref _escrowDisbursementTransactions, value); }
        private DirtyList<EscrowInterestTransaction> _escrowInterestTransactions;
        /// <summary>
        /// InterimServicing EscrowInterestTransactions
        /// </summary>
        public IList<EscrowInterestTransaction> EscrowInterestTransactions { get => GetField(ref _escrowInterestTransactions); set => SetField(ref _escrowInterestTransactions, value); }
        private DirtyValue<decimal?> _floodInsurance;
        /// <summary>
        /// Intrm Serv Escrow Summary Flood Insurance [SERVICE.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Flood Insurance")]
        public decimal? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// InterimServicing Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyList<InterimServicingTransaction> _interimServicingTransactions;
        /// <summary>
        /// InterimServicing InterimServicingTransactions
        /// </summary>
        public IList<InterimServicingTransaction> InterimServicingTransactions { get => GetField(ref _interimServicingTransactions); set => SetField(ref _interimServicingTransactions, value); }
        private DirtyValue<decimal?> _lastPaymentAdditionalEscrow;
        /// <summary>
        /// Intrm Serv Last Pymnt Add'l Escrow [SERVICE.X86]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Add'l Escrow")]
        public decimal? LastPaymentAdditionalEscrow { get => _lastPaymentAdditionalEscrow; set => SetField(ref _lastPaymentAdditionalEscrow, value); }
        private DirtyValue<decimal?> _lastPaymentAdditionalPrincipal;
        /// <summary>
        /// Intrm Serv Last Pymnt Add'l Pnicpl [SERVICE.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Add'l Pnicpl")]
        public decimal? LastPaymentAdditionalPrincipal { get => _lastPaymentAdditionalPrincipal; set => SetField(ref _lastPaymentAdditionalPrincipal, value); }
        private DirtyValue<decimal?> _lastPaymentBuydownSubsidyAmount;
        /// <summary>
        /// Intrm Serv Last Pymt Buydown Subsidy Amt [SERVICE.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymt Buydown Subsidy Amt")]
        public decimal? LastPaymentBuydownSubsidyAmount { get => _lastPaymentBuydownSubsidyAmount; set => SetField(ref _lastPaymentBuydownSubsidyAmount, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowAmount;
        /// <summary>
        /// Intrm Serv Last Pymnt Escrow [SERVICE.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Escrow")]
        public decimal? LastPaymentEscrowAmount { get => _lastPaymentEscrowAmount; set => SetField(ref _lastPaymentEscrowAmount, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowCityPropertyTax;
        /// <summary>
        /// Intrm Serv Last Pymnt City Property Tax [SERVICE.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt City Property Tax")]
        public decimal? LastPaymentEscrowCityPropertyTax { get => _lastPaymentEscrowCityPropertyTax; set => SetField(ref _lastPaymentEscrowCityPropertyTax, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowFloodInsurance;
        /// <summary>
        /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X124]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Escrow Tax")]
        public decimal? LastPaymentEscrowFloodInsurance { get => _lastPaymentEscrowFloodInsurance; set => SetField(ref _lastPaymentEscrowFloodInsurance, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowHazardInsurance;
        /// <summary>
        /// Intrm Serv Last Pymnt Hazard Insurance [SERVICE.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Hazard Insurance")]
        public decimal? LastPaymentEscrowHazardInsurance { get => _lastPaymentEscrowHazardInsurance; set => SetField(ref _lastPaymentEscrowHazardInsurance, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowMortgageInsurance;
        /// <summary>
        /// Intrm Serv Last Pymnt Mortgage Insurance [SERVICE.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Mortgage Insurance")]
        public decimal? LastPaymentEscrowMortgageInsurance { get => _lastPaymentEscrowMortgageInsurance; set => SetField(ref _lastPaymentEscrowMortgageInsurance, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowOther1;
        /// <summary>
        /// Intrm Serv Last Pymnt Other1 Escrow [SERVICE.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Other1 Escrow")]
        public decimal? LastPaymentEscrowOther1 { get => _lastPaymentEscrowOther1; set => SetField(ref _lastPaymentEscrowOther1, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowOther2;
        /// <summary>
        /// Intrm Serv Last Pymnt Other2 Escrow [SERVICE.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Other2 Escrow")]
        public decimal? LastPaymentEscrowOther2 { get => _lastPaymentEscrowOther2; set => SetField(ref _lastPaymentEscrowOther2, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowOther3;
        /// <summary>
        /// Intrm Serv Last Pymnt Other3 Escrow [SERVICE.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Other3 Escrow")]
        public decimal? LastPaymentEscrowOther3 { get => _lastPaymentEscrowOther3; set => SetField(ref _lastPaymentEscrowOther3, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowTax;
        /// <summary>
        /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Escrow Tax")]
        public decimal? LastPaymentEscrowTax { get => _lastPaymentEscrowTax; set => SetField(ref _lastPaymentEscrowTax, value); }
        private DirtyValue<decimal?> _lastPaymentEscrowUSDAMonthlyPremium;
        /// <summary>
        /// Intrm Serv Last Pymnt USDA Monthly Premuim [SERVICE.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt USDA Monthly Premuim")]
        public decimal? LastPaymentEscrowUSDAMonthlyPremium { get => _lastPaymentEscrowUSDAMonthlyPremium; set => SetField(ref _lastPaymentEscrowUSDAMonthlyPremium, value); }
        private DirtyValue<string> _lastPaymentGuid;
        /// <summary>
        /// Intrm Serv Last Pymnt GUID [SERVICE.LASTGUID]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Last Pymnt GUID")]
        public string LastPaymentGuid { get => _lastPaymentGuid; set => SetField(ref _lastPaymentGuid, value); }
        private DirtyValue<decimal?> _lastPaymentInterest;
        /// <summary>
        /// Intrm Serv Last Pymnt Interest [SERVICE.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Interest")]
        public decimal? LastPaymentInterest { get => _lastPaymentInterest; set => SetField(ref _lastPaymentInterest, value); }
        private DirtyValue<decimal?> _lastPaymentLateFee;
        /// <summary>
        /// Intrm Serv Last Pymnt Late Fee [SERVICE.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Late Fee")]
        public decimal? LastPaymentLateFee { get => _lastPaymentLateFee; set => SetField(ref _lastPaymentLateFee, value); }
        private DirtyValue<decimal?> _lastPaymentMiscFee;
        /// <summary>
        /// Intrm Serv Last Pymnt Misc Fee [SERVICE.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Misc Fee")]
        public decimal? LastPaymentMiscFee { get => _lastPaymentMiscFee; set => SetField(ref _lastPaymentMiscFee, value); }
        private DirtyValue<int?> _lastPaymentNumber;
        /// <summary>
        /// Intrm Serv Last Pymnt Pymnt Number [SERVICE.X30]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Last Pymnt Pymnt Number")]
        public int? LastPaymentNumber { get => _lastPaymentNumber; set => SetField(ref _lastPaymentNumber, value); }
        private DirtyValue<decimal?> _lastPaymentPrincipal;
        /// <summary>
        /// Intrm Serv Last Pymnt Principal [SERVICE.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Principal")]
        public decimal? LastPaymentPrincipal { get => _lastPaymentPrincipal; set => SetField(ref _lastPaymentPrincipal, value); }
        private DirtyValue<decimal?> _lastPaymentPrincipalAndInterest;
        /// <summary>
        /// Intrm Serv Last Pymnt Prncpl and Int. [SERVICE.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Prncpl and Int.")]
        public decimal? LastPaymentPrincipalAndInterest { get => _lastPaymentPrincipalAndInterest; set => SetField(ref _lastPaymentPrincipalAndInterest, value); }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        /// <summary>
        /// Intrm Serv Last Pymnt Rcvd Date [SERVICE.X32]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Last Pymnt Rcvd Date")]
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => SetField(ref _lastPaymentReceivedDate, value); }
        private DirtyValue<DateTime?> _lastPaymentStatementDate;
        /// <summary>
        /// Intrm Serv Last Pymnt Statement Date [SERVICE.X31]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Last Pymnt Statement Date")]
        public DateTime? LastPaymentStatementDate { get => _lastPaymentStatementDate; set => SetField(ref _lastPaymentStatementDate, value); }
        private DirtyValue<decimal?> _lastPaymentTotalAmountReceived;
        /// <summary>
        /// Intrm Serv Last Pymnt Amount Rcvd [SERVICE.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Last Pymnt Amount Rcvd")]
        public decimal? LastPaymentTotalAmountReceived { get => _lastPaymentTotalAmountReceived; set => SetField(ref _lastPaymentTotalAmountReceived, value); }
        private SchedulePaymentTransaction _lastScheduledPayment;
        /// <summary>
        /// InterimServicing LastScheduledPayment
        /// </summary>
        public SchedulePaymentTransaction LastScheduledPayment { get => GetField(ref _lastScheduledPayment); set => SetField(ref _lastScheduledPayment, value); }
        private DirtyValue<DateTime?> _lastStatementPrintedDate;
        /// <summary>
        /// Intrm Serv Current Status Last Statement Printed [SERVICE.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Current Status Last Statement Printed")]
        public DateTime? LastStatementPrintedDate { get => _lastStatementPrintedDate; set => SetField(ref _lastStatementPrintedDate, value); }
        private DirtyList<LoanPurchaseTransaction> _loanPurchaseTransactions;
        /// <summary>
        /// InterimServicing LoanPurchaseTransactions
        /// </summary>
        public IList<LoanPurchaseTransaction> LoanPurchaseTransactions { get => GetField(ref _loanPurchaseTransactions); set => SetField(ref _loanPurchaseTransactions, value); }
        private DirtyValue<string> _loanSnapshotXml;
        /// <summary>
        /// InterimServicing LoanSnapshotXml
        /// </summary>
        public string LoanSnapshotXml { get => _loanSnapshotXml; set => SetField(ref _loanSnapshotXml, value); }
        private DirtyValue<string> _mailingCity;
        /// <summary>
        /// Intrm Serv Mailing Address City [SERVICE.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Mailing Address City")]
        public string MailingCity { get => _mailingCity; set => SetField(ref _mailingCity, value); }
        private DirtyValue<string> _mailingPostalCode;
        /// <summary>
        /// Intrm Serv Mailing Address ZIP Code [SERVICE.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Intrm Serv Mailing Address ZIP Code")]
        public string MailingPostalCode { get => _mailingPostalCode; set => SetField(ref _mailingPostalCode, value); }
        private DirtyValue<StringEnumValue<State>> _mailingState;
        /// <summary>
        /// Intrm Serv Mailing Address State [SERVICE.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Mailing Address State")]
        public StringEnumValue<State> MailingState { get => _mailingState; set => SetField(ref _mailingState, value); }
        private DirtyValue<string> _mailingStreetAddress;
        /// <summary>
        /// Intrm Serv Mailing Address Street [SERVICE.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Mailing Address Street")]
        public string MailingStreetAddress { get => _mailingStreetAddress; set => SetField(ref _mailingStreetAddress, value); }
        private DirtyValue<string> _mortgageAccount;
        /// <summary>
        /// Intrm Serv Mrtg Accnt No [SERVICE.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Mrtg Accnt No")]
        public string MortgageAccount { get => _mortgageAccount; set => SetField(ref _mortgageAccount, value); }
        private DirtyValue<decimal?> _nextEscrowTotalFloodInsurance;
        /// <summary>
        /// Intrm Serv Next Escrow Total Flood Insurance [SERVICE.X64]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Total Flood Insurance")]
        public decimal? NextEscrowTotalFloodInsurance { get => _nextEscrowTotalFloodInsurance; set => SetField(ref _nextEscrowTotalFloodInsurance, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalFloodInsuranceDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Flood Insurance Due Date [SERVICE.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Flood Insurance Due Date")]
        public DateTime? NextEscrowTotalFloodInsuranceDueDate { get => _nextEscrowTotalFloodInsuranceDueDate; set => SetField(ref _nextEscrowTotalFloodInsuranceDueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalHazardInsurance;
        /// <summary>
        /// Intrm Serv Next Escrow Total Hzrd Insurance [SERVICE.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Total Hzrd Insurance")]
        public decimal? NextEscrowTotalHazardInsurance { get => _nextEscrowTotalHazardInsurance; set => SetField(ref _nextEscrowTotalHazardInsurance, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalHazardInsuranceDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Hzrd Insurance Due Date [SERVICE.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Hzrd Insurance Due Date")]
        public DateTime? NextEscrowTotalHazardInsuranceDueDate { get => _nextEscrowTotalHazardInsuranceDueDate; set => SetField(ref _nextEscrowTotalHazardInsuranceDueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalMortgageInsurance;
        /// <summary>
        /// Intrm Serv Next Escrow Total Mortgage Insurance [SERVICE.X62]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Total Mortgage Insurance")]
        public decimal? NextEscrowTotalMortgageInsurance { get => _nextEscrowTotalMortgageInsurance; set => SetField(ref _nextEscrowTotalMortgageInsurance, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalMortgageInsuranceDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Mortgage Insurance Due Date [SERVICE.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Mortgage Insurance Due Date")]
        public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get => _nextEscrowTotalMortgageInsuranceDueDate; set => SetField(ref _nextEscrowTotalMortgageInsuranceDueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax1;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 1 [SERVICE.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Other Tax 1")]
        public decimal? NextEscrowTotalOtherTax1 { get => _nextEscrowTotalOtherTax1; set => SetField(ref _nextEscrowTotalOtherTax1, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax1DueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 1 Due Date [SERVICE.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Other Tax 1 Due Date")]
        public DateTime? NextEscrowTotalOtherTax1DueDate { get => _nextEscrowTotalOtherTax1DueDate; set => SetField(ref _nextEscrowTotalOtherTax1DueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax2;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 2 [SERVICE.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Other Tax 2")]
        public decimal? NextEscrowTotalOtherTax2 { get => _nextEscrowTotalOtherTax2; set => SetField(ref _nextEscrowTotalOtherTax2, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax2DueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 2 Due Date [SERVICE.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Other Tax 2 Due Date")]
        public DateTime? NextEscrowTotalOtherTax2DueDate { get => _nextEscrowTotalOtherTax2DueDate; set => SetField(ref _nextEscrowTotalOtherTax2DueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalOtherTax3;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 3 [SERVICE.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Other Tax 3")]
        public decimal? NextEscrowTotalOtherTax3 { get => _nextEscrowTotalOtherTax3; set => SetField(ref _nextEscrowTotalOtherTax3, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalOtherTax3DueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Other Tax 3 Due Date [SERVICE.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Other Tax 3 Due Date")]
        public DateTime? NextEscrowTotalOtherTax3DueDate { get => _nextEscrowTotalOtherTax3DueDate; set => SetField(ref _nextEscrowTotalOtherTax3DueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalPropertyTax;
        /// <summary>
        /// Intrm Serv Next Escrow Total PropertyTax [SERVICE.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Total PropertyTax")]
        public decimal? NextEscrowTotalPropertyTax { get => _nextEscrowTotalPropertyTax; set => SetField(ref _nextEscrowTotalPropertyTax, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalPropertyTaxDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Property Tax Due Date [SERVICE.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Property Tax Due Date")]
        public DateTime? NextEscrowTotalPropertyTaxDueDate { get => _nextEscrowTotalPropertyTaxDueDate; set => SetField(ref _nextEscrowTotalPropertyTaxDueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalTax;
        /// <summary>
        /// Intrm Serv Next Escrow Total Taxes [SERVICE.X58]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow Total Taxes")]
        public decimal? NextEscrowTotalTax { get => _nextEscrowTotalTax; set => SetField(ref _nextEscrowTotalTax, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalTaxDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow Tax Due Date [SERVICE.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow Tax Due Date")]
        public DateTime? NextEscrowTotalTaxDueDate { get => _nextEscrowTotalTaxDueDate; set => SetField(ref _nextEscrowTotalTaxDueDate, value); }
        private DirtyValue<decimal?> _nextEscrowTotalUsdaMonthlyPremium;
        /// <summary>
        /// Intrm Serv Next Escrow USDA Monthly Premium [SERVICE.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Escrow USDA Monthly Premium")]
        public decimal? NextEscrowTotalUsdaMonthlyPremium { get => _nextEscrowTotalUsdaMonthlyPremium; set => SetField(ref _nextEscrowTotalUsdaMonthlyPremium, value); }
        private DirtyValue<DateTime?> _nextEscrowTotalUsdaMonthlyPremiumDueDate;
        /// <summary>
        /// Intrm Serv Next Escrow USDA Monthly Premium Due Date [SERVICE.X106]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Escrow USDA Monthly Premium Due Date")]
        public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get => _nextEscrowTotalUsdaMonthlyPremiumDueDate; set => SetField(ref _nextEscrowTotalUsdaMonthlyPremiumDueDate, value); }
        private DirtyValue<decimal?> _nextPaymentBuydownSubsidyAmount;
        /// <summary>
        /// Intrm Serv Next Pymt Buydown Subsidy Amt [SERVICE.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymt Buydown Subsidy Amt")]
        public decimal? NextPaymentBuydownSubsidyAmount { get => _nextPaymentBuydownSubsidyAmount; set => SetField(ref _nextPaymentBuydownSubsidyAmount, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowAmount;
        /// <summary>
        /// Intrm Serv Next Pymnt Escrow [SERVICE.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Escrow")]
        public decimal? NextPaymentEscrowAmount { get => _nextPaymentEscrowAmount; set => SetField(ref _nextPaymentEscrowAmount, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowCityPropertyTax;
        /// <summary>
        /// Intrm Serv Next Payment City Property Tax [SERVICE.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment City Property Tax")]
        public decimal? NextPaymentEscrowCityPropertyTax { get => _nextPaymentEscrowCityPropertyTax; set => SetField(ref _nextPaymentEscrowCityPropertyTax, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowFloodInsurance;
        /// <summary>
        /// Intrm Serv Next Payment Flood Insurance [SERVICE.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Flood Insurance")]
        public decimal? NextPaymentEscrowFloodInsurance { get => _nextPaymentEscrowFloodInsurance; set => SetField(ref _nextPaymentEscrowFloodInsurance, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowHazardInsurance;
        /// <summary>
        /// Intrm Serv Next Payment Hazard Insurance [SERVICE.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Hazard Insurance")]
        public decimal? NextPaymentEscrowHazardInsurance { get => _nextPaymentEscrowHazardInsurance; set => SetField(ref _nextPaymentEscrowHazardInsurance, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowMortgageInsurance;
        /// <summary>
        /// Intrm Serv Next Payment Mortgage Insurance [SERVICE.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Mortgage Insurance")]
        public decimal? NextPaymentEscrowMortgageInsurance { get => _nextPaymentEscrowMortgageInsurance; set => SetField(ref _nextPaymentEscrowMortgageInsurance, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowOther1;
        /// <summary>
        /// Intrm Serv Next Payment Other1 Escrow [SERVICE.X117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Other1 Escrow")]
        public decimal? NextPaymentEscrowOther1 { get => _nextPaymentEscrowOther1; set => SetField(ref _nextPaymentEscrowOther1, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowOther2;
        /// <summary>
        /// Intrm Serv Next Payment Other2 Escrow [SERVICE.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Other2 Escrow")]
        public decimal? NextPaymentEscrowOther2 { get => _nextPaymentEscrowOther2; set => SetField(ref _nextPaymentEscrowOther2, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowOther3;
        /// <summary>
        /// Intrm Serv Next Payment Other3 Escrow [SERVICE.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Other3 Escrow")]
        public decimal? NextPaymentEscrowOther3 { get => _nextPaymentEscrowOther3; set => SetField(ref _nextPaymentEscrowOther3, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowTax;
        /// <summary>
        /// Intrm Serv Next Payment Escrow Taxes [SERVICE.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment Escrow Taxes")]
        public decimal? NextPaymentEscrowTax { get => _nextPaymentEscrowTax; set => SetField(ref _nextPaymentEscrowTax, value); }
        private DirtyValue<decimal?> _nextPaymentEscrowUSDAMonthlyPremium;
        /// <summary>
        /// Intrm Serv Next Payment USDA Monthly Premuim [SERVICE.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Payment USDA Monthly Premuim")]
        public decimal? NextPaymentEscrowUSDAMonthlyPremium { get => _nextPaymentEscrowUSDAMonthlyPremium; set => SetField(ref _nextPaymentEscrowUSDAMonthlyPremium, value); }
        private DirtyValue<decimal?> _nextPaymentIndexCurrentValuePercent;
        /// <summary>
        /// Intrm Serv Next Pymnt Index Rate [SERVICE.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Intrm Serv Next Pymnt Index Rate")]
        public decimal? NextPaymentIndexCurrentValuePercent { get => _nextPaymentIndexCurrentValuePercent; set => SetField(ref _nextPaymentIndexCurrentValuePercent, value); }
        private DirtyValue<decimal?> _nextPaymentInterest;
        /// <summary>
        /// Intrm Serv Next Pymnt Interest [SERVICE.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Interest")]
        public decimal? NextPaymentInterest { get => _nextPaymentInterest; set => SetField(ref _nextPaymentInterest, value); }
        private DirtyValue<decimal?> _nextPaymentLateFee;
        /// <summary>
        /// Intrm Serv Next Pymnt Late Fee [SERVICE.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Late Fee")]
        public decimal? NextPaymentLateFee { get => _nextPaymentLateFee; set => SetField(ref _nextPaymentLateFee, value); }
        private DirtyValue<DateTime?> _nextPaymentLatePaymentDate;
        /// <summary>
        /// Intrm Serv Next Pymnt Late Pymnt Date [SERVICE.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Pymnt Late Pymnt Date")]
        public DateTime? NextPaymentLatePaymentDate { get => _nextPaymentLatePaymentDate; set => SetField(ref _nextPaymentLatePaymentDate, value); }
        private DirtyValue<decimal?> _nextPaymentMiscFee;
        /// <summary>
        /// Intrm Serv Next Pymnt Misc Fee [SERVICE.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Misc Fee")]
        public decimal? NextPaymentMiscFee { get => _nextPaymentMiscFee; set => SetField(ref _nextPaymentMiscFee, value); }
        private DirtyValue<decimal?> _nextPaymentPastDueAmount;
        /// <summary>
        /// Intrm Serv Next Pymnt Past Due Amnt [SERVICE.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Past Due Amnt")]
        public decimal? NextPaymentPastDueAmount { get => _nextPaymentPastDueAmount; set => SetField(ref _nextPaymentPastDueAmount, value); }
        private DirtyValue<DateTime?> _nextPaymentPaymentDueDate;
        /// <summary>
        /// Intrm Serv Next Pymnt Pymnt Due Date [SERVICE.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Pymnt Pymnt Due Date")]
        public DateTime? NextPaymentPaymentDueDate { get => _nextPaymentPaymentDueDate; set => SetField(ref _nextPaymentPaymentDueDate, value); }
        private DirtyValue<DateTime?> _nextPaymentPaymentIndexDate;
        /// <summary>
        /// Intrm Serv Next Payment Index Date [SERVICE.X99]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Next Payment Index Date")]
        public DateTime? NextPaymentPaymentIndexDate { get => _nextPaymentPaymentIndexDate; set => SetField(ref _nextPaymentPaymentIndexDate, value); }
        private DirtyValue<decimal?> _nextPaymentPrincipal;
        /// <summary>
        /// Intrm Serv Next Pymnt Principal [SERVICE.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Principal")]
        public decimal? NextPaymentPrincipal { get => _nextPaymentPrincipal; set => SetField(ref _nextPaymentPrincipal, value); }
        private DirtyValue<decimal?> _nextPaymentPrincipalAndInterest;
        /// <summary>
        /// Intrm Serv Next Pymnt Prncpl and Int. [SERVICE.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Next Pymnt Prncpl and Int.")]
        public decimal? NextPaymentPrincipalAndInterest { get => _nextPaymentPrincipalAndInterest; set => SetField(ref _nextPaymentPrincipalAndInterest, value); }
        private DirtyValue<decimal?> _nextPaymentRequestedInterestRatePercent;
        /// <summary>
        /// Intrm Serv Next Pymnt Interest Rate [SERVICE.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Intrm Serv Next Pymnt Interest Rate")]
        public decimal? NextPaymentRequestedInterestRatePercent { get => _nextPaymentRequestedInterestRatePercent; set => SetField(ref _nextPaymentRequestedInterestRatePercent, value); }
        private DirtyValue<DateTime?> _nextPaymentStatementDueDate;
        /// <summary>
        /// Intrm Serv Next Pymnt Statement Due Date [SERVICE.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Next Pymnt Statement Due Date")]
        public DateTime? NextPaymentStatementDueDate { get => _nextPaymentStatementDueDate; set => SetField(ref _nextPaymentStatementDueDate, value); }
        private DirtyValue<decimal?> _nextPaymentTotalAmountDue;
        /// <summary>
        /// Intrm Serv Next Pymnt Total Amnt Due [SERVICE.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Next Pymnt Total Amnt Due")]
        public decimal? NextPaymentTotalAmountDue { get => _nextPaymentTotalAmountDue; set => SetField(ref _nextPaymentTotalAmountDue, value); }
        private DirtyValue<decimal?> _nextPaymentTotalAmountWithLateFee;
        /// <summary>
        /// Intrm Serv Next Pymnt Total Amnt and Late Fee [SERVICE.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Next Pymnt Total Amnt and Late Fee")]
        public decimal? NextPaymentTotalAmountWithLateFee { get => _nextPaymentTotalAmountWithLateFee; set => SetField(ref _nextPaymentTotalAmountWithLateFee, value); }
        private DirtyValue<decimal?> _nextPaymentUnpaidLateFee;
        /// <summary>
        /// Intrm Serv Next Pymnt Unpaid Late Fee [SERVICE.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Next Pymnt Unpaid Late Fee")]
        public decimal? NextPaymentUnpaidLateFee { get => _nextPaymentUnpaidLateFee; set => SetField(ref _nextPaymentUnpaidLateFee, value); }
        private SchedulePaymentTransaction _nextScheduledPayment;
        /// <summary>
        /// InterimServicing NextScheduledPayment
        /// </summary>
        public SchedulePaymentTransaction NextScheduledPayment { get => GetField(ref _nextScheduledPayment); set => SetField(ref _nextScheduledPayment, value); }
        private DirtyValue<int?> _numberOfDisbursement;
        /// <summary>
        /// Intrm Serv Escrow Summary Number of Disbursement [SERVICE.X74]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Escrow Summary Number of Disbursement")]
        public int? NumberOfDisbursement { get => _numberOfDisbursement; set => SetField(ref _numberOfDisbursement, value); }
        private DirtyList<OtherTransaction> _otherTransactions;
        /// <summary>
        /// InterimServicing OtherTransactions
        /// </summary>
        public IList<OtherTransaction> OtherTransactions { get => GetField(ref _otherTransactions); set => SetField(ref _otherTransactions, value); }
        private DirtyValue<DateTime?> _paymentDueDatePrinted;
        /// <summary>
        /// Intrm Serv Pymnt Due Date Printed [SERVICE.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Pymnt Due Date Printed")]
        public DateTime? PaymentDueDatePrinted { get => _paymentDueDatePrinted; set => SetField(ref _paymentDueDatePrinted, value); }
        private DirtyList<PaymentReversalTransaction> _paymentReversalTransactions;
        /// <summary>
        /// InterimServicing PaymentReversalTransactions
        /// </summary>
        public IList<PaymentReversalTransaction> PaymentReversalTransactions { get => GetField(ref _paymentReversalTransactions); set => SetField(ref _paymentReversalTransactions, value); }
        private DirtyList<PaymentTransaction> _paymentTransactions;
        /// <summary>
        /// InterimServicing PaymentTransactions
        /// </summary>
        public IList<PaymentTransaction> PaymentTransactions { get => GetField(ref _paymentTransactions); set => SetField(ref _paymentTransactions, value); }
        private DirtyValue<string> _printedByUserId;
        /// <summary>
        /// Intrm Serv Current Status Printed By User ID [SERVICE.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Current Status Printed By User ID")]
        public string PrintedByUserId { get => _printedByUserId; set => SetField(ref _printedByUserId, value); }
        private DirtyValue<string> _printedByUserName;
        /// <summary>
        /// Intrm Serv Current Status Printed By User Name [SERVICE.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Current Status Printed By User Name")]
        public string PrintedByUserName { get => _printedByUserName; set => SetField(ref _printedByUserName, value); }
        private DirtyValue<decimal?> _purchasedPrincipal;
        /// <summary>
        /// Intrm Serv Purchase Advice Summary Principal [SERVICE.X139]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Intrm Serv Purchase Advice Summary Principal")]
        public decimal? PurchasedPrincipal { get => _purchasedPrincipal; set => SetField(ref _purchasedPrincipal, value); }
        private DirtyList<SchedulePaymentTransaction> _scheduledPayments;
        /// <summary>
        /// InterimServicing ScheduledPayments
        /// </summary>
        public IList<SchedulePaymentTransaction> ScheduledPayments { get => GetField(ref _scheduledPayments); set => SetField(ref _scheduledPayments, value); }
        private DirtyList<SchedulePaymentTransaction> _schedulePaymentTransactions;
        /// <summary>
        /// InterimServicing SchedulePaymentTransactions
        /// </summary>
        public IList<SchedulePaymentTransaction> SchedulePaymentTransactions { get => GetField(ref _schedulePaymentTransactions); set => SetField(ref _schedulePaymentTransactions, value); }
        private DirtyValue<string> _servicerLoanNumber;
        /// <summary>
        /// Intrm Serv Servicer Loan Number [SERVICE.X108]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Servicer Loan Number")]
        public string ServicerLoanNumber { get => _servicerLoanNumber; set => SetField(ref _servicerLoanNumber, value); }
        private DirtyValue<StringEnumValue<ServicingStatus>> _servicingStatus;
        /// <summary>
        /// Intrm Serv Current Status [SERVICE.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Current Status")]
        public StringEnumValue<ServicingStatus> ServicingStatus { get => _servicingStatus; set => SetField(ref _servicingStatus, value); }
        private DirtyValue<DateTime?> _servicingTransferDate;
        /// <summary>
        /// Intrm Serv Servicing Transfer Date [SERVICE.X109]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Servicing Transfer Date")]
        public DateTime? ServicingTransferDate { get => _servicingTransferDate; set => SetField(ref _servicingTransferDate, value); }
        private DirtyValue<string> _subServicer;
        /// <summary>
        /// Intrm Serv Servicing Sub - Servicer [SERVICE.X110]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Servicing Sub - Servicer")]
        public string SubServicer { get => _subServicer; set => SetField(ref _subServicer, value); }
        private DirtyValue<string> _subServicerLoanNumber;
        /// <summary>
        /// Intrm Serv Sub - Servicer Loan Number [SERVICE.X111]
        /// </summary>
        [LoanFieldProperty(Description = "Intrm Serv Sub - Servicer Loan Number")]
        public string SubServicerLoanNumber { get => _subServicerLoanNumber; set => SetField(ref _subServicerLoanNumber, value); }
        private DirtyValue<decimal?> _totalAdditionalEscrow;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Add'l Escrow [SERVICE.X53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Add'l Escrow")]
        public decimal? TotalAdditionalEscrow { get => _totalAdditionalEscrow; set => SetField(ref _totalAdditionalEscrow, value); }
        private DirtyValue<decimal?> _totalAdditionalEscrowYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Add'l Escrow [SERVICE.X54]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Add'l Escrow")]
        public decimal? TotalAdditionalEscrowYearToDate { get => _totalAdditionalEscrowYearToDate; set => SetField(ref _totalAdditionalEscrowYearToDate, value); }
        private DirtyValue<decimal?> _totalAdditionalPrincipal;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Add'l Prncpl [SERVICE.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Add'l Prncpl")]
        public decimal? TotalAdditionalPrincipal { get => _totalAdditionalPrincipal; set => SetField(ref _totalAdditionalPrincipal, value); }
        private DirtyValue<decimal?> _totalAdditionalPrincipalYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Add'l Prncpl [SERVICE.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Add'l Prncpl")]
        public decimal? TotalAdditionalPrincipalYearToDate { get => _totalAdditionalPrincipalYearToDate; set => SetField(ref _totalAdditionalPrincipalYearToDate, value); }
        private DirtyValue<decimal?> _totalAmountDisbursed;
        /// <summary>
        /// Intrm Serv Escrow Summary Total Amnt Disbursed [SERVICE.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total Amnt Disbursed")]
        public decimal? TotalAmountDisbursed { get => _totalAmountDisbursed; set => SetField(ref _totalAmountDisbursed, value); }
        private DirtyValue<decimal?> _totalBuydownSubsidyAmount;
        /// <summary>
        /// Intrm Serv Pymt Summary Total Bdown Subsidy Amt [SERVICE.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymt Summary Total Bdown Subsidy Amt")]
        public decimal? TotalBuydownSubsidyAmount { get => _totalBuydownSubsidyAmount; set => SetField(ref _totalBuydownSubsidyAmount, value); }
        private DirtyValue<decimal?> _totalBuydownSubsidyAmountYearToDate;
        /// <summary>
        /// Intrm Serv Pymt Summary Yr to Date Bdown Subsidy [SERVICE.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymt Summary Yr to Date Bdown Subsidy")]
        public decimal? TotalBuydownSubsidyAmountYearToDate { get => _totalBuydownSubsidyAmountYearToDate; set => SetField(ref _totalBuydownSubsidyAmountYearToDate, value); }
        private DirtyValue<decimal?> _totalEscrow;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Escrow [SERVICE.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Escrow")]
        public decimal? TotalEscrow { get => _totalEscrow; set => SetField(ref _totalEscrow, value); }
        private DirtyValue<decimal?> _totalEscrowYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Escrow [SERVICE.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Escrow")]
        public decimal? TotalEscrowYearToDate { get => _totalEscrowYearToDate; set => SetField(ref _totalEscrowYearToDate, value); }
        private DirtyValue<decimal?> _totalHazardInsurance;
        /// <summary>
        /// Intrm Serv Escrow Summary Total Hzrd Insurance [SERVICE.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total Hzrd Insurance")]
        public decimal? TotalHazardInsurance { get => _totalHazardInsurance; set => SetField(ref _totalHazardInsurance, value); }
        private DirtyValue<decimal?> _totalInterest;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Interest [SERVICE.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Interest")]
        public decimal? TotalInterest { get => _totalInterest; set => SetField(ref _totalInterest, value); }
        private DirtyValue<decimal?> _totalInterestYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Int [SERVICE.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Total Int")]
        public decimal? TotalInterestYearToDate { get => _totalInterestYearToDate; set => SetField(ref _totalInterestYearToDate, value); }
        private DirtyValue<decimal?> _totalLateFee;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Late Fee [SERVICE.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Late Fee")]
        public decimal? TotalLateFee { get => _totalLateFee; set => SetField(ref _totalLateFee, value); }
        private DirtyValue<decimal?> _totalLateFeeYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Late Fee [SERVICE.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Total Late Fee")]
        public decimal? TotalLateFeeYearToDate { get => _totalLateFeeYearToDate; set => SetField(ref _totalLateFeeYearToDate, value); }
        private DirtyValue<decimal?> _totalMiscFee;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Misc Fee [SERVICE.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Misc Fee")]
        public decimal? TotalMiscFee { get => _totalMiscFee; set => SetField(ref _totalMiscFee, value); }
        private DirtyValue<decimal?> _totalMiscFeeYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Misc Fee [SERVICE.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Total Misc Fee")]
        public decimal? TotalMiscFeeYearToDate { get => _totalMiscFeeYearToDate; set => SetField(ref _totalMiscFeeYearToDate, value); }
        private DirtyValue<decimal?> _totalMortgageInsurance;
        /// <summary>
        /// Intrm Serv Escrow Summary Total Mrtg Insurance [SERVICE.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total Mrtg Insurance")]
        public decimal? TotalMortgageInsurance { get => _totalMortgageInsurance; set => SetField(ref _totalMortgageInsurance, value); }
        private DirtyValue<int?> _totalNumberOfLatePayment;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Nmbr of Late Pymnts [SERVICE.X40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Nmbr of Late Pymnts")]
        public int? TotalNumberOfLatePayment { get => _totalNumberOfLatePayment; set => SetField(ref _totalNumberOfLatePayment, value); }
        private DirtyValue<int?> _totalNumberOfPayment;
        /// <summary>
        /// Intrm Serv Pymnt Summary Nmbr of Pymnt [SERVICE.X39]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Intrm Serv Pymnt Summary Nmbr of Pymnt")]
        public int? TotalNumberOfPayment { get => _totalNumberOfPayment; set => SetField(ref _totalNumberOfPayment, value); }
        private DirtyValue<decimal?> _totalOtherTaxes;
        /// <summary>
        /// Intrm Serv Escrow Summary Total Other Taxes [SERVICE.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total Other Taxes")]
        public decimal? TotalOtherTaxes { get => _totalOtherTaxes; set => SetField(ref _totalOtherTaxes, value); }
        private DirtyValue<decimal?> _totalPAndI;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Prncpl and Int [SERVICE.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Prncpl and Int")]
        public decimal? TotalPAndI { get => _totalPAndI; set => SetField(ref _totalPAndI, value); }
        private DirtyValue<decimal?> _totalPAndIYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Prncpl and Int [SERVICE.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Prncpl and Int")]
        public decimal? TotalPAndIYearToDate { get => _totalPAndIYearToDate; set => SetField(ref _totalPAndIYearToDate, value); }
        private DirtyValue<decimal?> _totalPaymentCollected;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Pymnt Collected [SERVICE.X55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Pymnt Collected")]
        public decimal? TotalPaymentCollected { get => _totalPaymentCollected; set => SetField(ref _totalPaymentCollected, value); }
        private DirtyValue<decimal?> _totalPaymentCollectedYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Pymnt Collected [SERVICE.X56]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Pymnt Collected")]
        public decimal? TotalPaymentCollectedYearToDate { get => _totalPaymentCollectedYearToDate; set => SetField(ref _totalPaymentCollectedYearToDate, value); }
        private DirtyValue<decimal?> _totalPrincipal;
        /// <summary>
        /// Intrm Serv Pymnt Summary Total Prncpl [SERVICE.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Total Prncpl")]
        public decimal? TotalPrincipal { get => _totalPrincipal; set => SetField(ref _totalPrincipal, value); }
        private DirtyValue<decimal?> _totalPrincipalYearToDate;
        /// <summary>
        /// Intrm Serv Pymnt Summary Year to Date Total Prncpl [SERVICE.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Pymnt Summary Year to Date Total Prncpl")]
        public decimal? TotalPrincipalYearToDate { get => _totalPrincipalYearToDate; set => SetField(ref _totalPrincipalYearToDate, value); }
        private DirtyValue<decimal?> _totalTaxes;
        /// <summary>
        /// Intrm Serv Escrow Summary Total Property City Taxes [SERVICE.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total Property City Taxes")]
        public decimal? TotalTaxes { get => _totalTaxes; set => SetField(ref _totalTaxes, value); }
        private DirtyValue<decimal?> _totalUsdaMonthlyPremium;
        /// <summary>
        /// Intrm Serv Escrow Summary Total USDA Monthly Premium [SERVICE.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Summary Total USDA Monthly Premium")]
        public decimal? TotalUsdaMonthlyPremium { get => _totalUsdaMonthlyPremium; set => SetField(ref _totalUsdaMonthlyPremium, value); }
        private DirtyValue<decimal?> _unpaidBuydownSubsidyAmount;
        /// <summary>
        /// Intrm Serv Escrow Sumry Unpaid Bdown Subsidy Amt [SERVICE.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Escrow Sumry Unpaid Bdown Subsidy Amt")]
        public decimal? UnpaidBuydownSubsidyAmount { get => _unpaidBuydownSubsidyAmount; set => SetField(ref _unpaidBuydownSubsidyAmount, value); }
        private DirtyValue<decimal?> _unpaidEscrow;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow [SERVICE.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow")]
        public decimal? UnpaidEscrow { get => _unpaidEscrow; set => SetField(ref _unpaidEscrow, value); }
        private DirtyValue<decimal?> _unpaidEscrowCityPropertyTax;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow City Property Tax [SERVICE.X134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow City Property Tax")]
        public decimal? UnpaidEscrowCityPropertyTax { get => _unpaidEscrowCityPropertyTax; set => SetField(ref _unpaidEscrowCityPropertyTax, value); }
        private DirtyValue<decimal?> _unpaidEscrowFloodInsurance;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Flood Insurance [SERVICE.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Flood Insurance")]
        public decimal? UnpaidEscrowFloodInsurance { get => _unpaidEscrowFloodInsurance; set => SetField(ref _unpaidEscrowFloodInsurance, value); }
        private DirtyValue<decimal?> _unpaidEscrowHazardInsurance;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Hazard Insurance [SERVICE.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Hazard Insurance")]
        public decimal? UnpaidEscrowHazardInsurance { get => _unpaidEscrowHazardInsurance; set => SetField(ref _unpaidEscrowHazardInsurance, value); }
        private DirtyValue<decimal?> _unpaidEscrowMortgageInsurance;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Mortgage Insurance [SERVICE.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Mortgage Insurance")]
        public decimal? UnpaidEscrowMortgageInsurance { get => _unpaidEscrowMortgageInsurance; set => SetField(ref _unpaidEscrowMortgageInsurance, value); }
        private DirtyValue<decimal?> _unpaidEscrowOther1;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other1 [SERVICE.X135]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Other1")]
        public decimal? UnpaidEscrowOther1 { get => _unpaidEscrowOther1; set => SetField(ref _unpaidEscrowOther1, value); }
        private DirtyValue<decimal?> _unpaidEscrowOther2;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other2 [SERVICE.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Other2")]
        public decimal? UnpaidEscrowOther2 { get => _unpaidEscrowOther2; set => SetField(ref _unpaidEscrowOther2, value); }
        private DirtyValue<decimal?> _unpaidEscrowOther3;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Other3 [SERVICE.X137]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Other3")]
        public decimal? UnpaidEscrowOther3 { get => _unpaidEscrowOther3; set => SetField(ref _unpaidEscrowOther3, value); }
        private DirtyValue<decimal?> _unpaidEscrowTax;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Escrow Tax [SERVICE.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Escrow Tax")]
        public decimal? UnpaidEscrowTax { get => _unpaidEscrowTax; set => SetField(ref _unpaidEscrowTax, value); }
        private DirtyValue<decimal?> _unpaidEscrowUSDAMonthlyPremium;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid USDA Monthly Premium [SERVICE.X138]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid USDA Monthly Premium")]
        public decimal? UnpaidEscrowUSDAMonthlyPremium { get => _unpaidEscrowUSDAMonthlyPremium; set => SetField(ref _unpaidEscrowUSDAMonthlyPremium, value); }
        private DirtyValue<decimal?> _unpaidInterest;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Interest [SERVICE.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Interest")]
        public decimal? UnpaidInterest { get => _unpaidInterest; set => SetField(ref _unpaidInterest, value); }
        private DirtyValue<decimal?> _unpaidLateFee;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Late Fee [SERVICE.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Late Fee")]
        public decimal? UnpaidLateFee { get => _unpaidLateFee; set => SetField(ref _unpaidLateFee, value); }
        private DirtyValue<decimal?> _unpaidMiscrFee;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Misc Fee [SERVICE.X94]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Misc Fee")]
        public decimal? UnpaidMiscrFee { get => _unpaidMiscrFee; set => SetField(ref _unpaidMiscrFee, value); }
        private DirtyValue<decimal?> _unpaidPrincipal;
        /// <summary>
        /// Intrm Serv Payment Summary Unpaid Principal [SERVICE.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Intrm Serv Payment Summary Unpaid Principal")]
        public decimal? UnpaidPrincipal { get => _unpaidPrincipal; set => SetField(ref _unpaidPrincipal, value); }
    }
}