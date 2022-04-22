using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// ClosingDisclosure3
/// </summary>
public sealed partial class ClosingDisclosure3 : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Decimal Value of Alternate LE CD3 Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of Alternate LE CD3 Total Payoffs And Payments K From Latest Disclosure Tracking Log [CD3.XH90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of Alternate LE Loan Amount From Latest Disclosure Tracking Log [CD3.XH87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLELoanAmountFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure3 ActualLenderCredits
    /// </summary>
    public decimal? ActualLenderCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Adjustments And Other Credits From Latest Disclosure Tracking Log [CD3.XH100]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Closing Costs Financed From Latest Disclosure Tracking Log [CD3.XH95]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Deposit From Latest Disclosure Tracking Log [CD3.XH97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLEDepositFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Down Payment From Latest Disclosure Tracking Log [CD3.XH96]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLEDownPaymentFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Funds For Borrower From Latest Disclosure Tracking Log [CD3.XH98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure3 ActualSTDLESellerCredits
    /// </summary>
    public decimal? ActualSTDLESellerCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Seller Credits From Latest Disclosure Tracking Log [CD3.XH99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLESellerCreditsFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure3 ActualSTDLETotalClosingCostJ
    /// </summary>
    public decimal? ActualSTDLETotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Decimal Value of STD LE Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH93]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments06_1 [CD3.X2]
    /// </summary>
    public string? Adjustments061 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments06_2 [CD3.X3]
    /// </summary>
    public decimal? Adjustments062 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments07_1 [CD3.X4]
    /// </summary>
    public string? Adjustments071 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments07_2 [CD3.X5]
    /// </summary>
    public decimal? Adjustments072 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments10_1 [CD3.X17]
    /// </summary>
    public string? Adjustments101 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments10_2 [CD3.X18]
    /// </summary>
    public decimal? Adjustments102 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments11_1 [CD3.X19]
    /// </summary>
    public string? Adjustments111 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments11_2 [CD3.X20]
    /// </summary>
    public decimal? Adjustments112 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments15_1 [CD3.X6]
    /// </summary>
    public string? Adjustments151 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments15_2 [CD3.X7]
    /// </summary>
    public decimal? Adjustments152 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments8_1 [CD3.X13]
    /// </summary>
    public string? Adjustments81 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments8_2 [CD3.X14]
    /// </summary>
    public decimal? Adjustments82 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments9_1 [CD3.X15]
    /// </summary>
    public string? Adjustments91 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Adjustments9_2 [CD3.X16]
    /// </summary>
    public decimal? Adjustments92 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// AdjustmentsforItemsPaidbySellerinAdvance16_1 [CD3.X30]
    /// </summary>
    public string? AdjustmentsforItemsPaidbySellerinAdvance161 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AdjustmentsforItemsPaidbySellerinAdvance16_2 [CD3.X31]
    /// </summary>
    public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Cash To Close Did Change Col [CD3.X122]
    /// </summary>
    public string? ALTCashToCloseDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Cash To Close Remark [CD3.X133]
    /// </summary>
    public decimal? ALTCashToCloseRemark { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ALT CLosing Cost Before Did Change Col [CD3.X120]
    /// </summary>
    public string? ALTClosingCostBeforeClosingDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Legal Limit [CD3.X132]
    /// </summary>
    public decimal? ALTLegalLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Loan Amount Did Change Col [CD3.X118]
    /// </summary>
    public string? ALTLoanAmountDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Loan Amount IncDec Remark [CD3.X130]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> ALTLoanAmountIncDecRemark { get => GetValue<StringEnumValue<IncreasedOrDecreased>>(); set => SetValue(value); }

    /// <summary>
    /// ALT Total Closing Cost Did Change Col [CD3.X119]
    /// </summary>
    public string? ALTTotalClosingCostDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ALT Total Closing Cost Remark [CD3.X131]
    /// </summary>
    public StringEnumValue<TotalClosingCostRemark> ALTTotalClosingCostRemark { get => GetValue<StringEnumValue<TotalClosingCostRemark>>(); set => SetValue(value); }

    /// <summary>
    /// ALT Total Payoffs Did Change Col [CD3.X121]
    /// </summary>
    public string? ALTTotalPayoffsDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cash [CD3.X40]
    /// </summary>
    public decimal? Cash { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Cash To Close [CD3.X23]
    /// </summary>
    public decimal? CashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD3 Cash To Close [CD3.X85]
    /// </summary>
    public decimal? CD3CashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD3 Cash To Close From To Borrower [CD3.X86]
    /// </summary>
    public string? CD3CashToCloseFromToBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CD3 Closing Costs Paid Before Closing [CD3.X83]
    /// </summary>
    public decimal? CD3ClosingCostsPaidBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD3 Total Closing Cost J [CD3.X82]
    /// </summary>
    public decimal? CD3TotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// CD3 Total Payoffs And Payments K [CD3.X84]
    /// </summary>
    public decimal? CD3TotalPayoffsAndPaymentsK { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Costs Paid At Closing [CD3.X1]
    /// </summary>
    public decimal? ClosingCostsPaidAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Closing Costs Paid at Closing J [CD3.X46]
    /// </summary>
    public decimal? ClosingCostsPaidatClosingJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing11_1 [CD3.X32]
    /// </summary>
    public string? DuefromSelleratClosing111 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing11_2 [CD3.X33]
    /// </summary>
    public decimal? DuefromSelleratClosing112 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing12_1 [CD3.X34]
    /// </summary>
    public string? DuefromSelleratClosing121 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing12_2 [CD3.X35]
    /// </summary>
    public decimal? DuefromSelleratClosing122 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing13_1 [CD3.X36]
    /// </summary>
    public string? DuefromSelleratClosing131 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DuefromSelleratClosing13_2 [CD3.X37]
    /// </summary>
    public decimal? DuefromSelleratClosing132 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing6_1 [CD3.X24]
    /// </summary>
    public string? DueToSellerAtClosing61 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing6_2 [CD3.X25]
    /// </summary>
    public decimal? DueToSellerAtClosing62 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing7_1 [CD3.X26]
    /// </summary>
    public string? DueToSellerAtClosing71 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing7_2 [CD3.X27]
    /// </summary>
    public decimal? DueToSellerAtClosing72 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing8_1 [CD3.X28]
    /// </summary>
    public string? DueToSellerAtClosing81 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DueToSellerAtClosing8_2 [CD3.X29]
    /// </summary>
    public decimal? DueToSellerAtClosing82 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Exclude Borrower Closing Costs [CD3.X137]
    /// </summary>
    public bool? ExcludeBorrowerClosingCosts { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Closing disclosure - Final Cash To Close [CD3.X45]
    /// </summary>
    public decimal? FinalCashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// From To Borrower [CD3.X48]
    /// </summary>
    public string? FromToBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// From To Seller [CD3.X49]
    /// </summary>
    public string? FromToSeller { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure3 Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE CD3 Cash To Close [CD3.X91]
    /// </summary>
    public decimal? LECD3CashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE CD3 Cash To Close From To Borrower [CD3.X92]
    /// </summary>
    public string? LECD3CashToCloseFromToBorrower { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// LE CD3 Closing Costs Paid Before Closing [CD3.X89]
    /// </summary>
    public decimal? LECD3ClosingCostsPaidBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE CD3 Total Closing Cost J [CD3.X88]
    /// </summary>
    public decimal? LECD3TotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE CD3 Total Payoffs And Payments K [CD3.X90]
    /// </summary>
    public decimal? LECD3TotalPayoffsAndPaymentsK { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LE Loan Amount [CD3.X87]
    /// </summary>
    public decimal? LELoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 1 [CD3.X65]
    /// </summary>
    public decimal? LiabilityAmount1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 10 [CD3.X74]
    /// </summary>
    public decimal? LiabilityAmount10 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 11 [CD3.X75]
    /// </summary>
    public decimal? LiabilityAmount11 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 12 [CD3.X76]
    /// </summary>
    public decimal? LiabilityAmount12 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 13 [CD3.X77]
    /// </summary>
    public decimal? LiabilityAmount13 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 14 [CD3.X78]
    /// </summary>
    public decimal? LiabilityAmount14 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 15 [CD3.X79]
    /// </summary>
    public decimal? LiabilityAmount15 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 3 [CD3.X66]
    /// </summary>
    public decimal? LiabilityAmount2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 3 [CD3.X67]
    /// </summary>
    public decimal? LiabilityAmount3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 4 [CD3.X68]
    /// </summary>
    public decimal? LiabilityAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount  5 [CD3.X69]
    /// </summary>
    public decimal? LiabilityAmount5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  Liability Amount 6 [CD3.X70]
    /// </summary>
    public decimal? LiabilityAmount6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 7 [CD3.X71]
    /// </summary>
    public decimal? LiabilityAmount7 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 8 [CD3.X72]
    /// </summary>
    public decimal? LiabilityAmount8 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Amount 9 [CD3.X73]
    /// </summary>
    public decimal? LiabilityAmount9 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 1 [CD3.X50]
    /// </summary>
    public string? LiabilityTo1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 10 [CD3.X59]
    /// </summary>
    public string? LiabilityTo10 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 11 [CD3.X60]
    /// </summary>
    public string? LiabilityTo11 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 12 [CD3.X61]
    /// </summary>
    public string? LiabilityTo12 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 13 [CD3.X62]
    /// </summary>
    public string? LiabilityTo13 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 14 [CD3.X63]
    /// </summary>
    public string? LiabilityTo14 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 15 [CD3.X64]
    /// </summary>
    public string? LiabilityTo15 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 3 [CD3.X51]
    /// </summary>
    public string? LiabilityTo2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 3 [CD3.X52]
    /// </summary>
    public string? LiabilityTo3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 4 [CD3.X53]
    /// </summary>
    public string? LiabilityTo4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To  5 [CD3.X54]
    /// </summary>
    public string? LiabilityTo5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    ///  Liability To 6 [CD3.X55]
    /// </summary>
    public string? LiabilityTo6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 7 [CD3.X56]
    /// </summary>
    public string? LiabilityTo7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 8 [CD3.X57]
    /// </summary>
    public string? LiabilityTo8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability To 9 [CD3.X58]
    /// </summary>
    public string? LiabilityTo9 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Liability Total [CD3.X80]
    /// </summary>
    public decimal? LiabilityTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Amount [CD3.X81]
    /// </summary>
    public decimal? LoanAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// New Verbiage Disclosed [CD3.X1542]
    /// </summary>
    public bool? NewVerbiageDisclosed { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Non UCD Total Adjustments And Other Credits [CD3.X1505]
    /// </summary>
    public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Omit from Print Seller's Transaction [CD3.X138]
    /// </summary>
    public bool? OmitFromPrintSellersTransaction { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// OtherCredits6_1 [CD3.X9]
    /// </summary>
    public string? OtherCredits61 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherCredits6_2 [CD3.X10]
    /// </summary>
    public decimal? OtherCredits62 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// OtherCredits7_1 [CD3.X11]
    /// </summary>
    public string? OtherCredits71 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// OtherCredits7_2 [CD3.X12]
    /// </summary>
    public decimal? OtherCredits72 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Prior Tolerance Cure Amount [CD3.X135]
    /// </summary>
    public decimal? PriorToleranceCureAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Adjustment And Other Credits Remark [CD3.X136]
    /// </summary>
    public StringEnumValue<STDAdjustmentAndOtherCreditsRemark> STDAdjustmentAndOtherCreditsRemark { get => GetValue<StringEnumValue<STDAdjustmentAndOtherCreditsRemark>>(); set => SetValue(value); }

    /// <summary>
    /// STD Adjustments Did Change Col [CD3.X117]
    /// </summary>
    public string? STDAdjustmentsDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Closing Cost Financed Did Change Col [CD3.X134]
    /// </summary>
    public string? STDClosingCostFinancedDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Deposit Did Change Col [CD3.X114]
    /// </summary>
    public string? STDDepositDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Deposit IncDec Remark [CD3.X126]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> STDDepositIncDecRemark { get => GetValue<StringEnumValue<IncreasedOrDecreased>>(); set => SetValue(value); }

    /// <summary>
    /// STD Down Payment Did Change Col [CD3.X113]
    /// </summary>
    public string? STDDownPaymentDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Down Payment IncDec Remark [CD3.X124]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> STDDownPaymentIncDecRemark { get => GetValue<StringEnumValue<IncreasedOrDecreased>>(); set => SetValue(value); }

    /// <summary>
    /// STD Down Payment Section Remark [CD3.X125]
    /// </summary>
    public StringEnumValue<STDDownPaymentSectionRemark> STDDownPaymentSectionRemark { get => GetValue<StringEnumValue<STDDownPaymentSectionRemark>>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Adjustment And Other Credits [CD3.X109]
    /// </summary>
    public decimal? STDFinalAdjustmentAndOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Cash To Close [CD3.X110]
    /// </summary>
    public decimal? STDFinalCashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  STD Final CD3 Closing Costs Paid Before Closing [CD3.X103]
    /// </summary>
    public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Closing Cost Financed [CD3.X104]
    /// </summary>
    public decimal? STDFinalClosingCostFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final  Deposit [CD3.X106]
    /// </summary>
    public decimal? STDFinalDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Down Payment [CD3.X105]
    /// </summary>
    public decimal? STDFinalDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Fund For Borrower [CD3.X107]
    /// </summary>
    public decimal? STDFinalFundForBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  STD Final  Seller Credits [CD3.X108]
    /// </summary>
    public decimal? STDFinalSellerCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Final Total Closing Cost J [CD3.X102]
    /// </summary>
    public decimal? STDFinalTotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Funds for Borrower Did Change Col [CD3.X115]
    /// </summary>
    public string? STDFundsForBorrowerDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Funds For Borrower IncDec Remark [CD3.X127]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> STDFundsForBorrowerIncDecRemark { get => GetValue<StringEnumValue<IncreasedOrDecreased>>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Adjustmen And Other Credits [CD3.X100]
    /// </summary>
    public decimal? STDLEAdjustmentAndOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Cash To Close [CD3.X101]
    /// </summary>
    public decimal? STDLECashToClose { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE CD3 Closing Costs Paid Before Closing [CD3.X94]
    /// </summary>
    public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Closing Cost Financed [CD3.X95]
    /// </summary>
    public decimal? STDLEClosingCostFinanced { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Deposit [CD3.X97]
    /// </summary>
    public decimal? STDLEDeposit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Down Payment [CD3.X96]
    /// </summary>
    public decimal? STDLEDownPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  STD LE Fund For Borrower [CD3.X98]
    /// </summary>
    public decimal? STDLEFundForBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Tolerance Cure [CD3.X129]
    /// </summary>
    public decimal? STDLegalLimit { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD LE Seller Credits [CD3.X99]
    /// </summary>
    public decimal? STDLESellerCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    ///  STD LE Total Closing Cost J [CD3.X93]
    /// </summary>
    public decimal? STDLETotalClosingCostJ { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// STD Seller Credits Did Change Col [CD3.X116]
    /// </summary>
    public string? STDSellerCreditsDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Seller Credits IncDec Remark [CD3.X128]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> STDSellerCreditsIncDecRemark { get => GetValue<StringEnumValue<IncreasedOrDecreased>>(); set => SetValue(value); }

    /// <summary>
    /// STD Total Closing Cost Before CLosing Did Change Col [CD3.X112]
    /// </summary>
    public string? STDTotalClosingCostBeforeClosingDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Total Closing Cost Did Change Col [CD3.X111]
    /// </summary>
    public string? STDTotalClosingCostDidChangeCol { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// STD Total Closing Cost Remark [CD3.X123]
    /// </summary>
    public StringEnumValue<TotalClosingCostRemark> STDTotalClosingCostRemark { get => GetValue<StringEnumValue<TotalClosingCostRemark>>(); set => SetValue(value); }

    /// <summary>
    /// Total Adjustments And Other Credits [CD3.X1506]
    /// </summary>
    public decimal? TotalAdjustmentsAndOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Due from Borrower At Closing [CD3.X21]
    /// </summary>
    public decimal? TotalDuefromBorrowerAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Due from Seller at Closing N  [CD3.X39]
    /// </summary>
    public decimal? TotalDuefromSelleratClosingN { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Due to Seller at Closing M [CD3.X38]
    /// </summary>
    public decimal? TotalDuetoSelleratClosingM { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total From K [CD3.X41]
    /// </summary>
    public decimal? TotalFromK { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total From L  [CD3.X42]
    /// </summary>
    public decimal? TotalFromL { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total From M [CD3.X43]
    /// </summary>
    public decimal? TotalFromM { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total From N [CD3.X44]
    /// </summary>
    public decimal? TotalFromN { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Paid Already by or on Behalf of Borower at Closing  [CD3.X22]
    /// </summary>
    public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Purchase Payoffs Included [CD3.X1543]
    /// </summary>
    public decimal? TotalPurchasePayoffsIncluded { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingDisclosure3 UCDDetails
    /// </summary>
    [AllowNull]
    public IList<UCDDetail> UCDDetails { get => GetList<UCDDetail>(); set => SetList(value); }

    /// <summary>
    /// UCD K Line Subtotal [CD3.X1502]
    /// </summary>
    public decimal? UCDKSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UCD K Line Subtotal [CD3.X1503]
    /// </summary>
    public decimal? UCDLSubTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// UCD Total Adjustments And Other Credits [CD3.X1504]
    /// </summary>
    public decimal? UCDTotalAdjustmentsAndOtherCredits { get => GetValue<decimal?>(); set => SetValue(value); }
}