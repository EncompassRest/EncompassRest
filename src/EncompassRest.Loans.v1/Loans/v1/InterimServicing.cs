using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// InterimServicing
/// </summary>
public sealed partial class InterimServicing : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Intrm Serv Beginning Balance [SERVICE.X144]
    /// </summary>
    public decimal? BeginningBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borr Cell [SERVICE.X142]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BorrCellPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borr Email [SERVICE.X143]
    /// </summary>
    public string? BorrHomeEmail { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borr Home Phone [SERVICE.X140]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BorrHomePhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borrower First Name [SERVICE.X2]
    /// </summary>
    public string? BorrowerFirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borrower Last Name [SERVICE.X3]
    /// </summary>
    public string? BorrowerLastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Borr Business Phone [SERVICE.X141]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? BorrWorkPhoneNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Calc Flag [SERVICE.X999]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? CalcTriggered { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary City Insurance [SERVICE.X90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CityInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Comments [SERVICE.Comments]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Prncpl Balance [SERVICE.X57]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CurrentPrincipalBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Balance [SERVICE.X81]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EscrowBalance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing EscrowDisbursementTransactions
    /// </summary>
    [AllowNull]
    public IList<EscrowDisbursementTransaction> EscrowDisbursementTransactions { get => GetList<EscrowDisbursementTransaction>(); set => SetList(value); }

    /// <summary>
    /// InterimServicing EscrowInterestTransactions
    /// </summary>
    [AllowNull]
    public IList<EscrowInterestTransaction> EscrowInterestTransactions { get => GetList<EscrowInterestTransaction>(); set => SetList(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Flood Insurance [SERVICE.X89]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? FloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing InterimServicingTransactions
    /// </summary>
    [AllowNull]
    public IList<InterimServicingTransaction> InterimServicingTransactions { get => GetList<InterimServicingTransaction>(); set => SetList(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Add'l Escrow [SERVICE.X86]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentAdditionalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Add'l Pnicpl [SERVICE.X38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentAdditionalPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymt Buydown Subsidy Amt [SERVICE.X101]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentBuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Escrow [SERVICE.X36]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt City Property Tax [SERVICE.X125]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X124]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Hazard Insurance [SERVICE.X122]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Mortgage Insurance [SERVICE.X123]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Other1 Escrow [SERVICE.X126]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowOther1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Other2 Escrow [SERVICE.X127]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowOther2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Other3 Escrow [SERVICE.X128]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowOther3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Escrow Tax [SERVICE.X121]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt USDA Monthly Premuim [SERVICE.X129]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentEscrowUSDAMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt GUID [SERVICE.LASTGUID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? LastPaymentGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Interest [SERVICE.X35]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Late Fee [SERVICE.X37]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Misc Fee [SERVICE.X85]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentMiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Pymnt Number [SERVICE.X30]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? LastPaymentNumber { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Principal [SERVICE.X34]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Prncpl and Int. [SERVICE.X83]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentPrincipalAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Rcvd Date [SERVICE.X32]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastPaymentReceivedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Statement Date [SERVICE.X31]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? LastPaymentStatementDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Last Pymnt Amount Rcvd [SERVICE.X33]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LastPaymentTotalAmountReceived { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing LastScheduledPayment
    /// </summary>
    public SchedulePaymentTransaction? LastScheduledPayment { get => GetValue<SchedulePaymentTransaction?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Current Status Last Statement Printed [SERVICE.X9]
    /// </summary>
    public DateTime? LastStatementPrintedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing LoanPurchaseTransactions
    /// </summary>
    [AllowNull]
    public IList<LoanPurchaseTransaction> LoanPurchaseTransactions { get => GetList<LoanPurchaseTransaction>(); set => SetList(value); }

    /// <summary>
    /// InterimServicing LoanSnapshotXml
    /// </summary>
    public string? LoanSnapshotXml { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Mailing Address City [SERVICE.X5]
    /// </summary>
    public string? MailingCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Mailing Address ZIP Code [SERVICE.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? MailingPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Mailing Address State [SERVICE.X6]
    /// </summary>
    public StringEnumValue<State> MailingState { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Mailing Address Street [SERVICE.X4]
    /// </summary>
    public string? MailingStreetAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Mrtg Accnt No [SERVICE.X1]
    /// </summary>
    public string? MortgageAccount { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Total Flood Insurance [SERVICE.X64]
    /// </summary>
    public decimal? NextEscrowTotalFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Flood Insurance Due Date [SERVICE.X65]
    /// </summary>
    public DateTime? NextEscrowTotalFloodInsuranceDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Total Hzrd Insurance [SERVICE.X60]
    /// </summary>
    public decimal? NextEscrowTotalHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Hzrd Insurance Due Date [SERVICE.X61]
    /// </summary>
    public DateTime? NextEscrowTotalHazardInsuranceDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Total Mortgage Insurance [SERVICE.X62]
    /// </summary>
    public decimal? NextEscrowTotalMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Mortgage Insurance Due Date [SERVICE.X63]
    /// </summary>
    public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 1 [SERVICE.X68]
    /// </summary>
    public decimal? NextEscrowTotalOtherTax1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 1 Due Date [SERVICE.X69]
    /// </summary>
    public DateTime? NextEscrowTotalOtherTax1DueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 2 [SERVICE.X70]
    /// </summary>
    public decimal? NextEscrowTotalOtherTax2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 2 Due Date [SERVICE.X71]
    /// </summary>
    public DateTime? NextEscrowTotalOtherTax2DueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 3 [SERVICE.X72]
    /// </summary>
    public decimal? NextEscrowTotalOtherTax3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Other Tax 3 Due Date [SERVICE.X73]
    /// </summary>
    public DateTime? NextEscrowTotalOtherTax3DueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Total PropertyTax [SERVICE.X66]
    /// </summary>
    public decimal? NextEscrowTotalPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Property Tax Due Date [SERVICE.X67]
    /// </summary>
    public DateTime? NextEscrowTotalPropertyTaxDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Total Taxes [SERVICE.X58]
    /// </summary>
    public decimal? NextEscrowTotalTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow Tax Due Date [SERVICE.X59]
    /// </summary>
    public DateTime? NextEscrowTotalTaxDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow USDA Monthly Premium [SERVICE.X105]
    /// </summary>
    public decimal? NextEscrowTotalUsdaMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Escrow USDA Monthly Premium Due Date [SERVICE.X106]
    /// </summary>
    public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymt Buydown Subsidy Amt [SERVICE.X100]
    /// </summary>
    public decimal? NextPaymentBuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Escrow [SERVICE.X20]
    /// </summary>
    public decimal? NextPaymentEscrowAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment City Property Tax [SERVICE.X116]
    /// </summary>
    public decimal? NextPaymentEscrowCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Flood Insurance [SERVICE.X115]
    /// </summary>
    public decimal? NextPaymentEscrowFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Hazard Insurance [SERVICE.X113]
    /// </summary>
    public decimal? NextPaymentEscrowHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Mortgage Insurance [SERVICE.X114]
    /// </summary>
    public decimal? NextPaymentEscrowMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Other1 Escrow [SERVICE.X117]
    /// </summary>
    public decimal? NextPaymentEscrowOther1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Other2 Escrow [SERVICE.X119]
    /// </summary>
    public decimal? NextPaymentEscrowOther2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Other3 Escrow [SERVICE.X120]
    /// </summary>
    public decimal? NextPaymentEscrowOther3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Escrow Taxes [SERVICE.X112]
    /// </summary>
    public decimal? NextPaymentEscrowTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment USDA Monthly Premuim [SERVICE.X118]
    /// </summary>
    public decimal? NextPaymentEscrowUSDAMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Index Rate [SERVICE.X16]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NextPaymentIndexCurrentValuePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Interest [SERVICE.X19]
    /// </summary>
    public decimal? NextPaymentInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Late Fee [SERVICE.X25]
    /// </summary>
    public decimal? NextPaymentLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Late Pymnt Date [SERVICE.X15]
    /// </summary>
    public DateTime? NextPaymentLatePaymentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Misc Fee [SERVICE.X23]
    /// </summary>
    public decimal? NextPaymentMiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Past Due Amnt [SERVICE.X21]
    /// </summary>
    public decimal? NextPaymentPastDueAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Pymnt Due Date [SERVICE.X14]
    /// </summary>
    public DateTime? NextPaymentPaymentDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Payment Index Date [SERVICE.X99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public DateTime? NextPaymentPaymentIndexDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Principal [SERVICE.X18]
    /// </summary>
    public decimal? NextPaymentPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Prncpl and Int. [SERVICE.X82]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NextPaymentPrincipalAndInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Interest Rate [SERVICE.X17]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? NextPaymentRequestedInterestRatePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Statement Due Date [SERVICE.X13]
    /// </summary>
    public DateTime? NextPaymentStatementDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Total Amnt Due [SERVICE.X24]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NextPaymentTotalAmountDue { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Total Amnt and Late Fee [SERVICE.X26]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? NextPaymentTotalAmountWithLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Next Pymnt Unpaid Late Fee [SERVICE.X22]
    /// </summary>
    public decimal? NextPaymentUnpaidLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing NextScheduledPayment
    /// </summary>
    public SchedulePaymentTransaction? NextScheduledPayment { get => GetValue<SchedulePaymentTransaction?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Number of Disbursement [SERVICE.X74]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? NumberOfDisbursement { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing OtherTransactions
    /// </summary>
    [AllowNull]
    public IList<OtherTransaction> OtherTransactions { get => GetList<OtherTransaction>(); set => SetList(value); }

    /// <summary>
    /// Intrm Serv Pymnt Due Date Printed [SERVICE.X10]
    /// </summary>
    public DateTime? PaymentDueDatePrinted { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing PaymentReversalTransactions
    /// </summary>
    [AllowNull]
    public IList<PaymentReversalTransaction> PaymentReversalTransactions { get => GetList<PaymentReversalTransaction>(); set => SetList(value); }

    /// <summary>
    /// InterimServicing PaymentTransactions
    /// </summary>
    [AllowNull]
    public IList<PaymentTransaction> PaymentTransactions { get => GetList<PaymentTransaction>(); set => SetList(value); }

    /// <summary>
    /// Intrm Serv Current Status Printed By User ID [SERVICE.X12]
    /// </summary>
    public string? PrintedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Current Status Printed By User Name [SERVICE.X11]
    /// </summary>
    public string? PrintedByUserName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Purchase Advice Summary Principal [SERVICE.X139]
    /// </summary>
    public decimal? PurchasedPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// InterimServicing ScheduledPayments
    /// </summary>
    [AllowNull]
    public IList<SchedulePaymentTransaction> ScheduledPayments { get => GetList<SchedulePaymentTransaction>(); set => SetList(value); }

    /// <summary>
    /// InterimServicing SchedulePaymentTransactions
    /// </summary>
    [AllowNull]
    public IList<SchedulePaymentTransaction> SchedulePaymentTransactions { get => GetList<SchedulePaymentTransaction>(); set => SetList(value); }

    /// <summary>
    /// Intrm Serv Servicer Loan Number [SERVICE.X108]
    /// </summary>
    public string? ServicerLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Current Status [SERVICE.X8]
    /// </summary>
    public StringEnumValue<ServicingStatus> ServicingStatus { get => GetValue<StringEnumValue<ServicingStatus>>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Servicing Transfer Date [SERVICE.X109]
    /// </summary>
    public DateTime? ServicingTransferDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Servicing Sub - Servicer [SERVICE.X110]
    /// </summary>
    public string? SubServicer { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Sub - Servicer Loan Number [SERVICE.X111]
    /// </summary>
    public string? SubServicerLoanNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Add'l Escrow [SERVICE.X53]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAdditionalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Add'l Escrow [SERVICE.X54]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAdditionalEscrowYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Add'l Prncpl [SERVICE.X51]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAdditionalPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Add'l Prncpl [SERVICE.X52]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAdditionalPrincipalYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total Amnt Disbursed [SERVICE.X80]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalAmountDisbursed { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymt Summary Total Bdown Subsidy Amt [SERVICE.X102]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymt Summary Yr to Date Bdown Subsidy [SERVICE.X103]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalBuydownSubsidyAmountYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Escrow [SERVICE.X47]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Escrow [SERVICE.X48]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalEscrowYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total Hzrd Insurance [SERVICE.X76]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Interest [SERVICE.X43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Total Int [SERVICE.X44]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalInterestYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Late Fee [SERVICE.X49]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Total Late Fee [SERVICE.X50]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalLateFeeYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Misc Fee [SERVICE.X87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMiscFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Total Misc Fee [SERVICE.X88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMiscFeeYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total Mrtg Insurance [SERVICE.X77]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Nmbr of Late Pymnts [SERVICE.X40]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalNumberOfLatePayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Nmbr of Pymnt [SERVICE.X39]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public int? TotalNumberOfPayment { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total Other Taxes [SERVICE.X79]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOtherTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Prncpl and Int [SERVICE.X45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPAndI { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Prncpl and Int [SERVICE.X46]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPAndIYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Pymnt Collected [SERVICE.X55]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaymentCollected { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Pymnt Collected [SERVICE.X56]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPaymentCollectedYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Total Prncpl [SERVICE.X41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Pymnt Summary Year to Date Total Prncpl [SERVICE.X42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPrincipalYearToDate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total Property City Taxes [SERVICE.X75]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Summary Total USDA Monthly Premium [SERVICE.X107]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalUsdaMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Escrow Sumry Unpaid Bdown Subsidy Amt [SERVICE.X104]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidBuydownSubsidyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow [SERVICE.X93]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow City Property Tax [SERVICE.X134]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowCityPropertyTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Flood Insurance [SERVICE.X133]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Hazard Insurance [SERVICE.X132]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Mortgage Insurance [SERVICE.X131]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Other1 [SERVICE.X135]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowOther1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Other2 [SERVICE.X136]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowOther2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Other3 [SERVICE.X137]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowOther3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Escrow Tax [SERVICE.X130]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowTax { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid USDA Monthly Premium [SERVICE.X138]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidEscrowUSDAMonthlyPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Interest [SERVICE.X92]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Late Fee [SERVICE.X95]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidLateFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Misc Fee [SERVICE.X94]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidMiscrFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Intrm Serv Payment Summary Unpaid Principal [SERVICE.X91]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? UnpaidPrincipal { get => GetValue<decimal?>(); set => SetValue(value); }
}