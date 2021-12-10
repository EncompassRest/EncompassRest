using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingDisclosure3
/// </summary>
public sealed partial class ClosingDisclosure3 : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<decimal?>? _actualLecd3TotalClosingCostJFromLatestRec;
    private DirtyValue<decimal?>? _actualLecd3TotalPayoffsAndPaymentsKFromLatestRec;
    private DirtyValue<decimal?>? _actualLeLoanAmountFromLatestRec;
    private DirtyValue<decimal?>? _actualLenderCredits;
    private DirtyValue<decimal?>? _actualStdleAdjustmentAndOtherCreditsFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleClosingCostFinancedFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleDepositFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleDownPaymentFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleFundForBorrowerFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleSellerCredits;
    private DirtyValue<decimal?>? _actualStdleSellerCreditsFromLatestRec;
    private DirtyValue<decimal?>? _actualStdleTotalClosingCostJ;
    private DirtyValue<decimal?>? _actualStdleTotalClosingCostJFromLatestRec;
    private DirtyValue<string?>? _adjustments061;
    private DirtyValue<decimal?>? _adjustments062;
    private DirtyValue<string?>? _adjustments071;
    private DirtyValue<decimal?>? _adjustments072;
    private DirtyValue<string?>? _adjustments101;
    private DirtyValue<decimal?>? _adjustments102;
    private DirtyValue<string?>? _adjustments111;
    private DirtyValue<decimal?>? _adjustments112;
    private DirtyValue<string?>? _adjustments151;
    private DirtyValue<decimal?>? _adjustments152;
    private DirtyValue<string?>? _adjustments81;
    private DirtyValue<decimal?>? _adjustments82;
    private DirtyValue<string?>? _adjustments91;
    private DirtyValue<decimal?>? _adjustments92;
    private DirtyValue<string?>? _adjustmentsforItemsPaidbySellerinAdvance161;
    private DirtyValue<decimal?>? _adjustmentsforItemsPaidbySellerinAdvance162;
    private DirtyValue<string?>? _altCashToCloseDidChangeCol;
    private DirtyValue<decimal?>? _altCashToCloseRemark;
    private DirtyValue<string?>? _altClosingCostBeforeClosingDidChangeCol;
    private DirtyValue<decimal?>? _altLegalLimit;
    private DirtyValue<string?>? _altLoanAmountDidChangeCol;
    private DirtyValue<StringEnumValue<IncreasedOrDecreased>>? _altLoanAmountIncDecRemark;
    private DirtyValue<string?>? _altTotalClosingCostDidChangeCol;
    private DirtyValue<StringEnumValue<TotalClosingCostRemark>>? _altTotalClosingCostRemark;
    private DirtyValue<string?>? _altTotalPayoffsDidChangeCol;
    private DirtyValue<decimal?>? _cash;
    private DirtyValue<decimal?>? _cashToClose;
    private DirtyValue<decimal?>? _cd3CashToClose;
    private DirtyValue<string?>? _cd3CashToCloseFromToBorrower;
    private DirtyValue<decimal?>? _cd3ClosingCostsPaidBeforeClosing;
    private DirtyValue<decimal?>? _cd3TotalClosingCostJ;
    private DirtyValue<decimal?>? _cd3TotalPayoffsAndPaymentsK;
    private DirtyValue<decimal?>? _closingCostsPaidAtClosing;
    private DirtyValue<decimal?>? _closingCostsPaidatClosingJ;
    private DirtyValue<string?>? _duefromSelleratClosing111;
    private DirtyValue<decimal?>? _duefromSelleratClosing112;
    private DirtyValue<string?>? _duefromSelleratClosing121;
    private DirtyValue<decimal?>? _duefromSelleratClosing122;
    private DirtyValue<string?>? _duefromSelleratClosing131;
    private DirtyValue<decimal?>? _duefromSelleratClosing132;
    private DirtyValue<string?>? _dueToSellerAtClosing61;
    private DirtyValue<decimal?>? _dueToSellerAtClosing62;
    private DirtyValue<string?>? _dueToSellerAtClosing71;
    private DirtyValue<decimal?>? _dueToSellerAtClosing72;
    private DirtyValue<string?>? _dueToSellerAtClosing81;
    private DirtyValue<decimal?>? _dueToSellerAtClosing82;
    private DirtyValue<bool?>? _excludeBorrowerClosingCosts;
    private DirtyValue<decimal?>? _finalCashToClose;
    private DirtyValue<string?>? _fromToBorrower;
    private DirtyValue<string?>? _fromToSeller;
    private DirtyValue<decimal?>? _lecd3CashToClose;
    private DirtyValue<string?>? _lecd3CashToCloseFromToBorrower;
    private DirtyValue<decimal?>? _lecd3ClosingCostsPaidBeforeClosing;
    private DirtyValue<decimal?>? _lecd3TotalClosingCostJ;
    private DirtyValue<decimal?>? _lecd3TotalPayoffsAndPaymentsK;
    private DirtyValue<decimal?>? _leLoanAmount;
    private DirtyValue<decimal?>? _liabilityAmount1;
    private DirtyValue<decimal?>? _liabilityAmount10;
    private DirtyValue<decimal?>? _liabilityAmount11;
    private DirtyValue<decimal?>? _liabilityAmount12;
    private DirtyValue<decimal?>? _liabilityAmount13;
    private DirtyValue<decimal?>? _liabilityAmount14;
    private DirtyValue<decimal?>? _liabilityAmount15;
    private DirtyValue<decimal?>? _liabilityAmount2;
    private DirtyValue<decimal?>? _liabilityAmount3;
    private DirtyValue<decimal?>? _liabilityAmount4;
    private DirtyValue<decimal?>? _liabilityAmount5;
    private DirtyValue<decimal?>? _liabilityAmount6;
    private DirtyValue<decimal?>? _liabilityAmount7;
    private DirtyValue<decimal?>? _liabilityAmount8;
    private DirtyValue<decimal?>? _liabilityAmount9;
    private DirtyValue<string?>? _liabilityTo1;
    private DirtyValue<string?>? _liabilityTo10;
    private DirtyValue<string?>? _liabilityTo11;
    private DirtyValue<string?>? _liabilityTo12;
    private DirtyValue<string?>? _liabilityTo13;
    private DirtyValue<string?>? _liabilityTo14;
    private DirtyValue<string?>? _liabilityTo15;
    private DirtyValue<string?>? _liabilityTo2;
    private DirtyValue<string?>? _liabilityTo3;
    private DirtyValue<string?>? _liabilityTo4;
    private DirtyValue<string?>? _liabilityTo5;
    private DirtyValue<string?>? _liabilityTo6;
    private DirtyValue<string?>? _liabilityTo7;
    private DirtyValue<string?>? _liabilityTo8;
    private DirtyValue<string?>? _liabilityTo9;
    private DirtyValue<decimal?>? _liabilityTotal;
    private DirtyValue<decimal?>? _loanAmount;
    private DirtyValue<bool?>? _newVerbiageDisclosed;
    private DirtyValue<decimal?>? _nonUcdTotalAdjustmentsAndOtherCredits;
    private DirtyValue<bool?>? _omitFromPrintSellersTransaction;
    private DirtyValue<string?>? _otherCredits61;
    private DirtyValue<decimal?>? _otherCredits62;
    private DirtyValue<string?>? _otherCredits71;
    private DirtyValue<decimal?>? _otherCredits72;
    private DirtyValue<decimal?>? _priorToleranceCureAmount;
    private DirtyValue<StringEnumValue<STDAdjustmentAndOtherCreditsRemark>>? _stdAdjustmentAndOtherCreditsRemark;
    private DirtyValue<string?>? _stdAdjustmentsDidChangeCol;
    private DirtyValue<string?>? _stdClosingCostFinancedDidChangeCol;
    private DirtyValue<string?>? _stdDepositDidChangeCol;
    private DirtyValue<StringEnumValue<IncreasedOrDecreased>>? _stdDepositIncDecRemark;
    private DirtyValue<string?>? _stdDownPaymentDidChangeCol;
    private DirtyValue<StringEnumValue<IncreasedOrDecreased>>? _stdDownPaymentIncDecRemark;
    private DirtyValue<StringEnumValue<STDDownPaymentSectionRemark>>? _stdDownPaymentSectionRemark;
    private DirtyValue<decimal?>? _stdFinalAdjustmentAndOtherCredits;
    private DirtyValue<decimal?>? _stdFinalCashToClose;
    private DirtyValue<decimal?>? _stdFinalCd3ClosingCostsPaidBeforeClosing;
    private DirtyValue<decimal?>? _stdFinalClosingCostFinanced;
    private DirtyValue<decimal?>? _stdFinalDeposit;
    private DirtyValue<decimal?>? _stdFinalDownPayment;
    private DirtyValue<decimal?>? _stdFinalFundForBorrower;
    private DirtyValue<decimal?>? _stdFinalSellerCredits;
    private DirtyValue<decimal?>? _stdFinalTotalClosingCostJ;
    private DirtyValue<string?>? _stdFundsForBorrowerDidChangeCol;
    private DirtyValue<StringEnumValue<IncreasedOrDecreased>>? _stdFundsForBorrowerIncDecRemark;
    private DirtyValue<decimal?>? _stdleAdjustmentAndOtherCredits;
    private DirtyValue<decimal?>? _stdleCashToClose;
    private DirtyValue<decimal?>? _stdleCd3ClosingCostsPaidBeforeClosing;
    private DirtyValue<decimal?>? _stdleClosingCostFinanced;
    private DirtyValue<decimal?>? _stdleDeposit;
    private DirtyValue<decimal?>? _stdleDownPayment;
    private DirtyValue<decimal?>? _stdleFundForBorrower;
    private DirtyValue<decimal?>? _stdLegalLimit;
    private DirtyValue<decimal?>? _stdleSellerCredits;
    private DirtyValue<decimal?>? _stdleTotalClosingCostJ;
    private DirtyValue<string?>? _stdSellerCreditsDidChangeCol;
    private DirtyValue<StringEnumValue<IncreasedOrDecreased>>? _stdSellerCreditsIncDecRemark;
    private DirtyValue<string?>? _stdTotalClosingCostBeforeClosingDidChangeCol;
    private DirtyValue<string?>? _stdTotalClosingCostDidChangeCol;
    private DirtyValue<StringEnumValue<TotalClosingCostRemark>>? _stdTotalClosingCostRemark;
    private DirtyValue<decimal?>? _totalAdjustmentsAndOtherCredits;
    private DirtyValue<decimal?>? _totalDuefromBorrowerAtClosing;
    private DirtyValue<decimal?>? _totalDuefromSelleratClosingN;
    private DirtyValue<decimal?>? _totalDuetoSelleratClosingM;
    private DirtyValue<decimal?>? _totalFromK;
    private DirtyValue<decimal?>? _totalFromL;
    private DirtyValue<decimal?>? _totalFromM;
    private DirtyValue<decimal?>? _totalFromN;
    private DirtyValue<decimal?>? _totalPaidAlreadybyoronBehalfofBoroweratClosing;
    private DirtyValue<decimal?>? _totalPurchasePayoffsIncluded;
    private DirtyList<UcdDetail>? _ucdDetails;
    private DirtyValue<decimal?>? _ucdkSubTotal;
    private DirtyValue<decimal?>? _ucdlSubTotal;
    private DirtyValue<decimal?>? _ucdTotalAdjustmentsAndOtherCredits;

    /// <summary>
    /// Decimal Value of Alternate LE CD3 Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH88]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLecd3TotalClosingCostJFromLatestRec { get => _actualLecd3TotalClosingCostJFromLatestRec; set => SetField(ref _actualLecd3TotalClosingCostJFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of Alternate LE CD3 Total Payoffs And Payments K From Latest Disclosure Tracking Log [CD3.XH90]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLecd3TotalPayoffsAndPaymentsKFromLatestRec { get => _actualLecd3TotalPayoffsAndPaymentsKFromLatestRec; set => SetField(ref _actualLecd3TotalPayoffsAndPaymentsKFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of Alternate LE Loan Amount From Latest Disclosure Tracking Log [CD3.XH87]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualLeLoanAmountFromLatestRec { get => _actualLeLoanAmountFromLatestRec; set => SetField(ref _actualLeLoanAmountFromLatestRec, value); }

    /// <summary>
    /// ClosingDisclosure3Contract ActualLenderCredits
    /// </summary>
    public decimal? ActualLenderCredits { get => _actualLenderCredits; set => SetField(ref _actualLenderCredits, value); }

    /// <summary>
    /// Decimal Value of STD LE Adjustments And Other Credits From Latest Disclosure Tracking Log [CD3.XH100]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleAdjustmentAndOtherCreditsFromLatestRec { get => _actualStdleAdjustmentAndOtherCreditsFromLatestRec; set => SetField(ref _actualStdleAdjustmentAndOtherCreditsFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of STD LE Closing Costs Financed From Latest Disclosure Tracking Log [CD3.XH95]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleClosingCostFinancedFromLatestRec { get => _actualStdleClosingCostFinancedFromLatestRec; set => SetField(ref _actualStdleClosingCostFinancedFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of STD LE Deposit From Latest Disclosure Tracking Log [CD3.XH97]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleDepositFromLatestRec { get => _actualStdleDepositFromLatestRec; set => SetField(ref _actualStdleDepositFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of STD LE Down Payment From Latest Disclosure Tracking Log [CD3.XH96]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleDownPaymentFromLatestRec { get => _actualStdleDownPaymentFromLatestRec; set => SetField(ref _actualStdleDownPaymentFromLatestRec, value); }

    /// <summary>
    /// Decimal Value of STD LE Funds For Borrower From Latest Disclosure Tracking Log [CD3.XH98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleFundForBorrowerFromLatestRec { get => _actualStdleFundForBorrowerFromLatestRec; set => SetField(ref _actualStdleFundForBorrowerFromLatestRec, value); }

    /// <summary>
    /// ClosingDisclosure3Contract ActualStdleSellerCredits
    /// </summary>
    public decimal? ActualStdleSellerCredits { get => _actualStdleSellerCredits; set => SetField(ref _actualStdleSellerCredits, value); }

    /// <summary>
    /// Decimal Value of STD LE Seller Credits From Latest Disclosure Tracking Log [CD3.XH99]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleSellerCreditsFromLatestRec { get => _actualStdleSellerCreditsFromLatestRec; set => SetField(ref _actualStdleSellerCreditsFromLatestRec, value); }

    /// <summary>
    /// ClosingDisclosure3Contract ActualStdleTotalClosingCostJ
    /// </summary>
    public decimal? ActualStdleTotalClosingCostJ { get => _actualStdleTotalClosingCostJ; set => SetField(ref _actualStdleTotalClosingCostJ, value); }

    /// <summary>
    /// Decimal Value of STD LE Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH93]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ActualStdleTotalClosingCostJFromLatestRec { get => _actualStdleTotalClosingCostJFromLatestRec; set => SetField(ref _actualStdleTotalClosingCostJFromLatestRec, value); }

    /// <summary>
    /// Adjustments06_1 [CD3.X2]
    /// </summary>
    public string? Adjustments061 { get => _adjustments061; set => SetField(ref _adjustments061, value); }

    /// <summary>
    /// Adjustments06_2 [CD3.X3]
    /// </summary>
    public decimal? Adjustments062 { get => _adjustments062; set => SetField(ref _adjustments062, value); }

    /// <summary>
    /// Adjustments07_1 [CD3.X4]
    /// </summary>
    public string? Adjustments071 { get => _adjustments071; set => SetField(ref _adjustments071, value); }

    /// <summary>
    /// Adjustments07_2 [CD3.X5]
    /// </summary>
    public decimal? Adjustments072 { get => _adjustments072; set => SetField(ref _adjustments072, value); }

    /// <summary>
    /// Adjustments10_1 [CD3.X17]
    /// </summary>
    public string? Adjustments101 { get => _adjustments101; set => SetField(ref _adjustments101, value); }

    /// <summary>
    /// Adjustments10_2 [CD3.X18]
    /// </summary>
    public decimal? Adjustments102 { get => _adjustments102; set => SetField(ref _adjustments102, value); }

    /// <summary>
    /// Adjustments11_1 [CD3.X19]
    /// </summary>
    public string? Adjustments111 { get => _adjustments111; set => SetField(ref _adjustments111, value); }

    /// <summary>
    /// Adjustments11_2 [CD3.X20]
    /// </summary>
    public decimal? Adjustments112 { get => _adjustments112; set => SetField(ref _adjustments112, value); }

    /// <summary>
    /// Adjustments15_1 [CD3.X6]
    /// </summary>
    public string? Adjustments151 { get => _adjustments151; set => SetField(ref _adjustments151, value); }

    /// <summary>
    /// Adjustments15_2 [CD3.X7]
    /// </summary>
    public decimal? Adjustments152 { get => _adjustments152; set => SetField(ref _adjustments152, value); }

    /// <summary>
    /// Adjustments8_1 [CD3.X13]
    /// </summary>
    public string? Adjustments81 { get => _adjustments81; set => SetField(ref _adjustments81, value); }

    /// <summary>
    /// Adjustments8_2 [CD3.X14]
    /// </summary>
    public decimal? Adjustments82 { get => _adjustments82; set => SetField(ref _adjustments82, value); }

    /// <summary>
    /// Adjustments9_1 [CD3.X15]
    /// </summary>
    public string? Adjustments91 { get => _adjustments91; set => SetField(ref _adjustments91, value); }

    /// <summary>
    /// Adjustments9_2 [CD3.X16]
    /// </summary>
    public decimal? Adjustments92 { get => _adjustments92; set => SetField(ref _adjustments92, value); }

    /// <summary>
    /// AdjustmentsforItemsPaidbySellerinAdvance16_1 [CD3.X30]
    /// </summary>
    public string? AdjustmentsforItemsPaidbySellerinAdvance161 { get => _adjustmentsforItemsPaidbySellerinAdvance161; set => SetField(ref _adjustmentsforItemsPaidbySellerinAdvance161, value); }

    /// <summary>
    /// AdjustmentsforItemsPaidbySellerinAdvance16_2 [CD3.X31]
    /// </summary>
    public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get => _adjustmentsforItemsPaidbySellerinAdvance162; set => SetField(ref _adjustmentsforItemsPaidbySellerinAdvance162, value); }

    /// <summary>
    /// ALT Cash To Close Did Change Col [CD3.X122]
    /// </summary>
    public string? AltCashToCloseDidChangeCol { get => _altCashToCloseDidChangeCol; set => SetField(ref _altCashToCloseDidChangeCol, value); }

    /// <summary>
    /// ALT Cash To Close Remark [CD3.X133]
    /// </summary>
    public decimal? AltCashToCloseRemark { get => _altCashToCloseRemark; set => SetField(ref _altCashToCloseRemark, value); }

    /// <summary>
    /// ALT CLosing Cost Before Did Change Col [CD3.X120]
    /// </summary>
    public string? AltClosingCostBeforeClosingDidChangeCol { get => _altClosingCostBeforeClosingDidChangeCol; set => SetField(ref _altClosingCostBeforeClosingDidChangeCol, value); }

    /// <summary>
    /// ALT Legal Limit [CD3.X132]
    /// </summary>
    public decimal? AltLegalLimit { get => _altLegalLimit; set => SetField(ref _altLegalLimit, value); }

    /// <summary>
    /// ALT Loan Amount Did Change Col [CD3.X118]
    /// </summary>
    public string? AltLoanAmountDidChangeCol { get => _altLoanAmountDidChangeCol; set => SetField(ref _altLoanAmountDidChangeCol, value); }

    /// <summary>
    /// ALT Loan Amount IncDec Remark [CD3.X130]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> AltLoanAmountIncDecRemark { get => _altLoanAmountIncDecRemark; set => SetField(ref _altLoanAmountIncDecRemark, value); }

    /// <summary>
    /// ALT Total Closing Cost Did Change Col [CD3.X119]
    /// </summary>
    public string? AltTotalClosingCostDidChangeCol { get => _altTotalClosingCostDidChangeCol; set => SetField(ref _altTotalClosingCostDidChangeCol, value); }

    /// <summary>
    /// ALT Total Closing Cost Remark [CD3.X131]
    /// </summary>
    public StringEnumValue<TotalClosingCostRemark> AltTotalClosingCostRemark { get => _altTotalClosingCostRemark; set => SetField(ref _altTotalClosingCostRemark, value); }

    /// <summary>
    /// ALT Total Payoffs Did Change Col [CD3.X121]
    /// </summary>
    public string? AltTotalPayoffsDidChangeCol { get => _altTotalPayoffsDidChangeCol; set => SetField(ref _altTotalPayoffsDidChangeCol, value); }

    /// <summary>
    /// Cash [CD3.X40]
    /// </summary>
    public decimal? Cash { get => _cash; set => SetField(ref _cash, value); }

    /// <summary>
    /// Cash To Close [CD3.X23]
    /// </summary>
    public decimal? CashToClose { get => _cashToClose; set => SetField(ref _cashToClose, value); }

    /// <summary>
    /// CD3 Cash To Close [CD3.X85]
    /// </summary>
    public decimal? Cd3CashToClose { get => _cd3CashToClose; set => SetField(ref _cd3CashToClose, value); }

    /// <summary>
    /// CD3 Cash To Close From To Borrower [CD3.X86]
    /// </summary>
    public string? Cd3CashToCloseFromToBorrower { get => _cd3CashToCloseFromToBorrower; set => SetField(ref _cd3CashToCloseFromToBorrower, value); }

    /// <summary>
    /// CD3 Closing Costs Paid Before Closing [CD3.X83]
    /// </summary>
    public decimal? Cd3ClosingCostsPaidBeforeClosing { get => _cd3ClosingCostsPaidBeforeClosing; set => SetField(ref _cd3ClosingCostsPaidBeforeClosing, value); }

    /// <summary>
    /// CD3 Total Closing Cost J [CD3.X82]
    /// </summary>
    public decimal? Cd3TotalClosingCostJ { get => _cd3TotalClosingCostJ; set => SetField(ref _cd3TotalClosingCostJ, value); }

    /// <summary>
    /// CD3 Total Payoffs And Payments K [CD3.X84]
    /// </summary>
    public decimal? Cd3TotalPayoffsAndPaymentsK { get => _cd3TotalPayoffsAndPaymentsK; set => SetField(ref _cd3TotalPayoffsAndPaymentsK, value); }

    /// <summary>
    /// Closing Costs Paid At Closing [CD3.X1]
    /// </summary>
    public decimal? ClosingCostsPaidAtClosing { get => _closingCostsPaidAtClosing; set => SetField(ref _closingCostsPaidAtClosing, value); }

    /// <summary>
    /// Closing Costs Paid at Closing J [CD3.X46]
    /// </summary>
    public decimal? ClosingCostsPaidatClosingJ { get => _closingCostsPaidatClosingJ; set => SetField(ref _closingCostsPaidatClosingJ, value); }

    /// <summary>
    /// DuefromSelleratClosing11_1 [CD3.X32]
    /// </summary>
    public string? DuefromSelleratClosing111 { get => _duefromSelleratClosing111; set => SetField(ref _duefromSelleratClosing111, value); }

    /// <summary>
    /// DuefromSelleratClosing11_2 [CD3.X33]
    /// </summary>
    public decimal? DuefromSelleratClosing112 { get => _duefromSelleratClosing112; set => SetField(ref _duefromSelleratClosing112, value); }

    /// <summary>
    /// DuefromSelleratClosing12_1 [CD3.X34]
    /// </summary>
    public string? DuefromSelleratClosing121 { get => _duefromSelleratClosing121; set => SetField(ref _duefromSelleratClosing121, value); }

    /// <summary>
    /// DuefromSelleratClosing12_2 [CD3.X35]
    /// </summary>
    public decimal? DuefromSelleratClosing122 { get => _duefromSelleratClosing122; set => SetField(ref _duefromSelleratClosing122, value); }

    /// <summary>
    /// DuefromSelleratClosing13_1 [CD3.X36]
    /// </summary>
    public string? DuefromSelleratClosing131 { get => _duefromSelleratClosing131; set => SetField(ref _duefromSelleratClosing131, value); }

    /// <summary>
    /// DuefromSelleratClosing13_2 [CD3.X37]
    /// </summary>
    public decimal? DuefromSelleratClosing132 { get => _duefromSelleratClosing132; set => SetField(ref _duefromSelleratClosing132, value); }

    /// <summary>
    /// DueToSellerAtClosing6_1 [CD3.X24]
    /// </summary>
    public string? DueToSellerAtClosing61 { get => _dueToSellerAtClosing61; set => SetField(ref _dueToSellerAtClosing61, value); }

    /// <summary>
    /// DueToSellerAtClosing6_2 [CD3.X25]
    /// </summary>
    public decimal? DueToSellerAtClosing62 { get => _dueToSellerAtClosing62; set => SetField(ref _dueToSellerAtClosing62, value); }

    /// <summary>
    /// DueToSellerAtClosing7_1 [CD3.X26]
    /// </summary>
    public string? DueToSellerAtClosing71 { get => _dueToSellerAtClosing71; set => SetField(ref _dueToSellerAtClosing71, value); }

    /// <summary>
    /// DueToSellerAtClosing7_2 [CD3.X27]
    /// </summary>
    public decimal? DueToSellerAtClosing72 { get => _dueToSellerAtClosing72; set => SetField(ref _dueToSellerAtClosing72, value); }

    /// <summary>
    /// DueToSellerAtClosing8_1 [CD3.X28]
    /// </summary>
    public string? DueToSellerAtClosing81 { get => _dueToSellerAtClosing81; set => SetField(ref _dueToSellerAtClosing81, value); }

    /// <summary>
    /// DueToSellerAtClosing8_2 [CD3.X29]
    /// </summary>
    public decimal? DueToSellerAtClosing82 { get => _dueToSellerAtClosing82; set => SetField(ref _dueToSellerAtClosing82, value); }

    /// <summary>
    /// Exclude Borrower Closing Costs [CD3.X137]
    /// </summary>
    public bool? ExcludeBorrowerClosingCosts { get => _excludeBorrowerClosingCosts; set => SetField(ref _excludeBorrowerClosingCosts, value); }

    /// <summary>
    /// Closing disclosure - Final Cash To Close [CD3.X45]
    /// </summary>
    public decimal? FinalCashToClose { get => _finalCashToClose; set => SetField(ref _finalCashToClose, value); }

    /// <summary>
    /// From To Borrower [CD3.X48]
    /// </summary>
    public string? FromToBorrower { get => _fromToBorrower; set => SetField(ref _fromToBorrower, value); }

    /// <summary>
    /// From To Seller [CD3.X49]
    /// </summary>
    public string? FromToSeller { get => _fromToSeller; set => SetField(ref _fromToSeller, value); }

    /// <summary>
    /// LE CD3 Cash To Close [CD3.X91]
    /// </summary>
    public decimal? Lecd3CashToClose { get => _lecd3CashToClose; set => SetField(ref _lecd3CashToClose, value); }

    /// <summary>
    /// LE CD3 Cash To Close From To Borrower [CD3.X92]
    /// </summary>
    public string? Lecd3CashToCloseFromToBorrower { get => _lecd3CashToCloseFromToBorrower; set => SetField(ref _lecd3CashToCloseFromToBorrower, value); }

    /// <summary>
    /// LE CD3 Closing Costs Paid Before Closing [CD3.X89]
    /// </summary>
    public decimal? Lecd3ClosingCostsPaidBeforeClosing { get => _lecd3ClosingCostsPaidBeforeClosing; set => SetField(ref _lecd3ClosingCostsPaidBeforeClosing, value); }

    /// <summary>
    /// LE CD3 Total Closing Cost J [CD3.X88]
    /// </summary>
    public decimal? Lecd3TotalClosingCostJ { get => _lecd3TotalClosingCostJ; set => SetField(ref _lecd3TotalClosingCostJ, value); }

    /// <summary>
    /// LE CD3 Total Payoffs And Payments K [CD3.X90]
    /// </summary>
    public decimal? Lecd3TotalPayoffsAndPaymentsK { get => _lecd3TotalPayoffsAndPaymentsK; set => SetField(ref _lecd3TotalPayoffsAndPaymentsK, value); }

    /// <summary>
    /// LE Loan Amount [CD3.X87]
    /// </summary>
    public decimal? LeLoanAmount { get => _leLoanAmount; set => SetField(ref _leLoanAmount, value); }

    /// <summary>
    /// Liability Amount 1 [CD3.X65]
    /// </summary>
    public decimal? LiabilityAmount1 { get => _liabilityAmount1; set => SetField(ref _liabilityAmount1, value); }

    /// <summary>
    /// Liability Amount 10 [CD3.X74]
    /// </summary>
    public decimal? LiabilityAmount10 { get => _liabilityAmount10; set => SetField(ref _liabilityAmount10, value); }

    /// <summary>
    /// Liability Amount 11 [CD3.X75]
    /// </summary>
    public decimal? LiabilityAmount11 { get => _liabilityAmount11; set => SetField(ref _liabilityAmount11, value); }

    /// <summary>
    /// Liability Amount 12 [CD3.X76]
    /// </summary>
    public decimal? LiabilityAmount12 { get => _liabilityAmount12; set => SetField(ref _liabilityAmount12, value); }

    /// <summary>
    /// Liability Amount 13 [CD3.X77]
    /// </summary>
    public decimal? LiabilityAmount13 { get => _liabilityAmount13; set => SetField(ref _liabilityAmount13, value); }

    /// <summary>
    /// Liability Amount 14 [CD3.X78]
    /// </summary>
    public decimal? LiabilityAmount14 { get => _liabilityAmount14; set => SetField(ref _liabilityAmount14, value); }

    /// <summary>
    /// Liability Amount 15 [CD3.X79]
    /// </summary>
    public decimal? LiabilityAmount15 { get => _liabilityAmount15; set => SetField(ref _liabilityAmount15, value); }

    /// <summary>
    /// Liability Amount 3 [CD3.X66]
    /// </summary>
    public decimal? LiabilityAmount2 { get => _liabilityAmount2; set => SetField(ref _liabilityAmount2, value); }

    /// <summary>
    /// Liability Amount 3 [CD3.X67]
    /// </summary>
    public decimal? LiabilityAmount3 { get => _liabilityAmount3; set => SetField(ref _liabilityAmount3, value); }

    /// <summary>
    /// Liability Amount 4 [CD3.X68]
    /// </summary>
    public decimal? LiabilityAmount4 { get => _liabilityAmount4; set => SetField(ref _liabilityAmount4, value); }

    /// <summary>
    /// Liability Amount  5 [CD3.X69]
    /// </summary>
    public decimal? LiabilityAmount5 { get => _liabilityAmount5; set => SetField(ref _liabilityAmount5, value); }

    /// <summary>
    ///  Liability Amount 6 [CD3.X70]
    /// </summary>
    public decimal? LiabilityAmount6 { get => _liabilityAmount6; set => SetField(ref _liabilityAmount6, value); }

    /// <summary>
    /// Liability Amount 7 [CD3.X71]
    /// </summary>
    public decimal? LiabilityAmount7 { get => _liabilityAmount7; set => SetField(ref _liabilityAmount7, value); }

    /// <summary>
    /// Liability Amount 8 [CD3.X72]
    /// </summary>
    public decimal? LiabilityAmount8 { get => _liabilityAmount8; set => SetField(ref _liabilityAmount8, value); }

    /// <summary>
    /// Liability Amount 9 [CD3.X73]
    /// </summary>
    public decimal? LiabilityAmount9 { get => _liabilityAmount9; set => SetField(ref _liabilityAmount9, value); }

    /// <summary>
    /// Liability To 1 [CD3.X50]
    /// </summary>
    public string? LiabilityTo1 { get => _liabilityTo1; set => SetField(ref _liabilityTo1, value); }

    /// <summary>
    /// Liability To 10 [CD3.X59]
    /// </summary>
    public string? LiabilityTo10 { get => _liabilityTo10; set => SetField(ref _liabilityTo10, value); }

    /// <summary>
    /// Liability To 11 [CD3.X60]
    /// </summary>
    public string? LiabilityTo11 { get => _liabilityTo11; set => SetField(ref _liabilityTo11, value); }

    /// <summary>
    /// Liability To 12 [CD3.X61]
    /// </summary>
    public string? LiabilityTo12 { get => _liabilityTo12; set => SetField(ref _liabilityTo12, value); }

    /// <summary>
    /// Liability To 13 [CD3.X62]
    /// </summary>
    public string? LiabilityTo13 { get => _liabilityTo13; set => SetField(ref _liabilityTo13, value); }

    /// <summary>
    /// Liability To 14 [CD3.X63]
    /// </summary>
    public string? LiabilityTo14 { get => _liabilityTo14; set => SetField(ref _liabilityTo14, value); }

    /// <summary>
    /// Liability To 15 [CD3.X64]
    /// </summary>
    public string? LiabilityTo15 { get => _liabilityTo15; set => SetField(ref _liabilityTo15, value); }

    /// <summary>
    /// Liability To 3 [CD3.X51]
    /// </summary>
    public string? LiabilityTo2 { get => _liabilityTo2; set => SetField(ref _liabilityTo2, value); }

    /// <summary>
    /// Liability To 3 [CD3.X52]
    /// </summary>
    public string? LiabilityTo3 { get => _liabilityTo3; set => SetField(ref _liabilityTo3, value); }

    /// <summary>
    /// Liability To 4 [CD3.X53]
    /// </summary>
    public string? LiabilityTo4 { get => _liabilityTo4; set => SetField(ref _liabilityTo4, value); }

    /// <summary>
    /// Liability To  5 [CD3.X54]
    /// </summary>
    public string? LiabilityTo5 { get => _liabilityTo5; set => SetField(ref _liabilityTo5, value); }

    /// <summary>
    ///  Liability To 6 [CD3.X55]
    /// </summary>
    public string? LiabilityTo6 { get => _liabilityTo6; set => SetField(ref _liabilityTo6, value); }

    /// <summary>
    /// Liability To 7 [CD3.X56]
    /// </summary>
    public string? LiabilityTo7 { get => _liabilityTo7; set => SetField(ref _liabilityTo7, value); }

    /// <summary>
    /// Liability To 8 [CD3.X57]
    /// </summary>
    public string? LiabilityTo8 { get => _liabilityTo8; set => SetField(ref _liabilityTo8, value); }

    /// <summary>
    /// Liability To 9 [CD3.X58]
    /// </summary>
    public string? LiabilityTo9 { get => _liabilityTo9; set => SetField(ref _liabilityTo9, value); }

    /// <summary>
    /// Liability Total [CD3.X80]
    /// </summary>
    public decimal? LiabilityTotal { get => _liabilityTotal; set => SetField(ref _liabilityTotal, value); }

    /// <summary>
    /// Loan Amount [CD3.X81]
    /// </summary>
    public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

    /// <summary>
    /// New Verbiage Disclosed [CD3.X1542]
    /// </summary>
    public bool? NewVerbiageDisclosed { get => _newVerbiageDisclosed; set => SetField(ref _newVerbiageDisclosed, value); }

    /// <summary>
    /// Non UCD Total Adjustments And Other Credits [CD3.X1505]
    /// </summary>
    public decimal? NonUcdTotalAdjustmentsAndOtherCredits { get => _nonUcdTotalAdjustmentsAndOtherCredits; set => SetField(ref _nonUcdTotalAdjustmentsAndOtherCredits, value); }

    /// <summary>
    /// Omit from Print Seller's Transaction [CD3.X138]
    /// </summary>
    public bool? OmitFromPrintSellersTransaction { get => _omitFromPrintSellersTransaction; set => SetField(ref _omitFromPrintSellersTransaction, value); }

    /// <summary>
    /// OtherCredits6_1 [CD3.X9]
    /// </summary>
    public string? OtherCredits61 { get => _otherCredits61; set => SetField(ref _otherCredits61, value); }

    /// <summary>
    /// OtherCredits6_2 [CD3.X10]
    /// </summary>
    public decimal? OtherCredits62 { get => _otherCredits62; set => SetField(ref _otherCredits62, value); }

    /// <summary>
    /// OtherCredits7_1 [CD3.X11]
    /// </summary>
    public string? OtherCredits71 { get => _otherCredits71; set => SetField(ref _otherCredits71, value); }

    /// <summary>
    /// OtherCredits7_2 [CD3.X12]
    /// </summary>
    public decimal? OtherCredits72 { get => _otherCredits72; set => SetField(ref _otherCredits72, value); }

    /// <summary>
    /// Prior Tolerance Cure Amount [CD3.X135]
    /// </summary>
    public decimal? PriorToleranceCureAmount { get => _priorToleranceCureAmount; set => SetField(ref _priorToleranceCureAmount, value); }

    /// <summary>
    /// STD Adjustment And Other Credits Remark [CD3.X136]
    /// </summary>
    public StringEnumValue<STDAdjustmentAndOtherCreditsRemark> StdAdjustmentAndOtherCreditsRemark { get => _stdAdjustmentAndOtherCreditsRemark; set => SetField(ref _stdAdjustmentAndOtherCreditsRemark, value); }

    /// <summary>
    /// STD Adjustments Did Change Col [CD3.X117]
    /// </summary>
    public string? StdAdjustmentsDidChangeCol { get => _stdAdjustmentsDidChangeCol; set => SetField(ref _stdAdjustmentsDidChangeCol, value); }

    /// <summary>
    /// STD Closing Cost Financed Did Change Col [CD3.X134]
    /// </summary>
    public string? StdClosingCostFinancedDidChangeCol { get => _stdClosingCostFinancedDidChangeCol; set => SetField(ref _stdClosingCostFinancedDidChangeCol, value); }

    /// <summary>
    /// STD Deposit Did Change Col [CD3.X114]
    /// </summary>
    public string? StdDepositDidChangeCol { get => _stdDepositDidChangeCol; set => SetField(ref _stdDepositDidChangeCol, value); }

    /// <summary>
    /// STD Deposit IncDec Remark [CD3.X126]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> StdDepositIncDecRemark { get => _stdDepositIncDecRemark; set => SetField(ref _stdDepositIncDecRemark, value); }

    /// <summary>
    /// STD Down Payment Did Change Col [CD3.X113]
    /// </summary>
    public string? StdDownPaymentDidChangeCol { get => _stdDownPaymentDidChangeCol; set => SetField(ref _stdDownPaymentDidChangeCol, value); }

    /// <summary>
    /// STD Down Payment IncDec Remark [CD3.X124]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> StdDownPaymentIncDecRemark { get => _stdDownPaymentIncDecRemark; set => SetField(ref _stdDownPaymentIncDecRemark, value); }

    /// <summary>
    /// STD Down Payment Section Remark [CD3.X125]
    /// </summary>
    public StringEnumValue<STDDownPaymentSectionRemark> StdDownPaymentSectionRemark { get => _stdDownPaymentSectionRemark; set => SetField(ref _stdDownPaymentSectionRemark, value); }

    /// <summary>
    /// STD Final Adjustment And Other Credits [CD3.X109]
    /// </summary>
    public decimal? StdFinalAdjustmentAndOtherCredits { get => _stdFinalAdjustmentAndOtherCredits; set => SetField(ref _stdFinalAdjustmentAndOtherCredits, value); }

    /// <summary>
    /// STD Final Cash To Close [CD3.X110]
    /// </summary>
    public decimal? StdFinalCashToClose { get => _stdFinalCashToClose; set => SetField(ref _stdFinalCashToClose, value); }

    /// <summary>
    ///  STD Final CD3 Closing Costs Paid Before Closing [CD3.X103]
    /// </summary>
    public decimal? StdFinalCd3ClosingCostsPaidBeforeClosing { get => _stdFinalCd3ClosingCostsPaidBeforeClosing; set => SetField(ref _stdFinalCd3ClosingCostsPaidBeforeClosing, value); }

    /// <summary>
    /// STD Final Closing Cost Financed [CD3.X104]
    /// </summary>
    public decimal? StdFinalClosingCostFinanced { get => _stdFinalClosingCostFinanced; set => SetField(ref _stdFinalClosingCostFinanced, value); }

    /// <summary>
    /// STD Final  Deposit [CD3.X106]
    /// </summary>
    public decimal? StdFinalDeposit { get => _stdFinalDeposit; set => SetField(ref _stdFinalDeposit, value); }

    /// <summary>
    /// STD Final Down Payment [CD3.X105]
    /// </summary>
    public decimal? StdFinalDownPayment { get => _stdFinalDownPayment; set => SetField(ref _stdFinalDownPayment, value); }

    /// <summary>
    /// STD Final Fund For Borrower [CD3.X107]
    /// </summary>
    public decimal? StdFinalFundForBorrower { get => _stdFinalFundForBorrower; set => SetField(ref _stdFinalFundForBorrower, value); }

    /// <summary>
    ///  STD Final  Seller Credits [CD3.X108]
    /// </summary>
    public decimal? StdFinalSellerCredits { get => _stdFinalSellerCredits; set => SetField(ref _stdFinalSellerCredits, value); }

    /// <summary>
    /// STD Final Total Closing Cost J [CD3.X102]
    /// </summary>
    public decimal? StdFinalTotalClosingCostJ { get => _stdFinalTotalClosingCostJ; set => SetField(ref _stdFinalTotalClosingCostJ, value); }

    /// <summary>
    /// STD Funds for Borrower Did Change Col [CD3.X115]
    /// </summary>
    public string? StdFundsForBorrowerDidChangeCol { get => _stdFundsForBorrowerDidChangeCol; set => SetField(ref _stdFundsForBorrowerDidChangeCol, value); }

    /// <summary>
    /// STD Funds For Borrower IncDec Remark [CD3.X127]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> StdFundsForBorrowerIncDecRemark { get => _stdFundsForBorrowerIncDecRemark; set => SetField(ref _stdFundsForBorrowerIncDecRemark, value); }

    /// <summary>
    /// STD LE Adjustmen And Other Credits [CD3.X100]
    /// </summary>
    public decimal? StdleAdjustmentAndOtherCredits { get => _stdleAdjustmentAndOtherCredits; set => SetField(ref _stdleAdjustmentAndOtherCredits, value); }

    /// <summary>
    /// STD LE Cash To Close [CD3.X101]
    /// </summary>
    public decimal? StdleCashToClose { get => _stdleCashToClose; set => SetField(ref _stdleCashToClose, value); }

    /// <summary>
    /// STD LE CD3 Closing Costs Paid Before Closing [CD3.X94]
    /// </summary>
    public decimal? StdleCd3ClosingCostsPaidBeforeClosing { get => _stdleCd3ClosingCostsPaidBeforeClosing; set => SetField(ref _stdleCd3ClosingCostsPaidBeforeClosing, value); }

    /// <summary>
    /// STD LE Closing Cost Financed [CD3.X95]
    /// </summary>
    public decimal? StdleClosingCostFinanced { get => _stdleClosingCostFinanced; set => SetField(ref _stdleClosingCostFinanced, value); }

    /// <summary>
    /// STD LE Deposit [CD3.X97]
    /// </summary>
    public decimal? StdleDeposit { get => _stdleDeposit; set => SetField(ref _stdleDeposit, value); }

    /// <summary>
    /// STD LE Down Payment [CD3.X96]
    /// </summary>
    public decimal? StdleDownPayment { get => _stdleDownPayment; set => SetField(ref _stdleDownPayment, value); }

    /// <summary>
    ///  STD LE Fund For Borrower [CD3.X98]
    /// </summary>
    public decimal? StdleFundForBorrower { get => _stdleFundForBorrower; set => SetField(ref _stdleFundForBorrower, value); }

    /// <summary>
    /// Tolerance Cure [CD3.X129]
    /// </summary>
    public decimal? StdLegalLimit { get => _stdLegalLimit; set => SetField(ref _stdLegalLimit, value); }

    /// <summary>
    /// STD LE Seller Credits [CD3.X99]
    /// </summary>
    public decimal? StdleSellerCredits { get => _stdleSellerCredits; set => SetField(ref _stdleSellerCredits, value); }

    /// <summary>
    ///  STD LE Total Closing Cost J [CD3.X93]
    /// </summary>
    public decimal? StdleTotalClosingCostJ { get => _stdleTotalClosingCostJ; set => SetField(ref _stdleTotalClosingCostJ, value); }

    /// <summary>
    /// STD Seller Credits Did Change Col [CD3.X116]
    /// </summary>
    public string? StdSellerCreditsDidChangeCol { get => _stdSellerCreditsDidChangeCol; set => SetField(ref _stdSellerCreditsDidChangeCol, value); }

    /// <summary>
    /// STD Seller Credits IncDec Remark [CD3.X128]
    /// </summary>
    public StringEnumValue<IncreasedOrDecreased> StdSellerCreditsIncDecRemark { get => _stdSellerCreditsIncDecRemark; set => SetField(ref _stdSellerCreditsIncDecRemark, value); }

    /// <summary>
    /// STD Total Closing Cost Before CLosing Did Change Col [CD3.X112]
    /// </summary>
    public string? StdTotalClosingCostBeforeClosingDidChangeCol { get => _stdTotalClosingCostBeforeClosingDidChangeCol; set => SetField(ref _stdTotalClosingCostBeforeClosingDidChangeCol, value); }

    /// <summary>
    /// STD Total Closing Cost Did Change Col [CD3.X111]
    /// </summary>
    public string? StdTotalClosingCostDidChangeCol { get => _stdTotalClosingCostDidChangeCol; set => SetField(ref _stdTotalClosingCostDidChangeCol, value); }

    /// <summary>
    /// STD Total Closing Cost Remark [CD3.X123]
    /// </summary>
    public StringEnumValue<TotalClosingCostRemark> StdTotalClosingCostRemark { get => _stdTotalClosingCostRemark; set => SetField(ref _stdTotalClosingCostRemark, value); }

    /// <summary>
    /// Total Adjustments And Other Credits [CD3.X1506]
    /// </summary>
    public decimal? TotalAdjustmentsAndOtherCredits { get => _totalAdjustmentsAndOtherCredits; set => SetField(ref _totalAdjustmentsAndOtherCredits, value); }

    /// <summary>
    /// Total Due from Borrower At Closing [CD3.X21]
    /// </summary>
    public decimal? TotalDuefromBorrowerAtClosing { get => _totalDuefromBorrowerAtClosing; set => SetField(ref _totalDuefromBorrowerAtClosing, value); }

    /// <summary>
    /// Total Due from Seller at Closing N  [CD3.X39]
    /// </summary>
    public decimal? TotalDuefromSelleratClosingN { get => _totalDuefromSelleratClosingN; set => SetField(ref _totalDuefromSelleratClosingN, value); }

    /// <summary>
    /// Total Due to Seller at Closing M [CD3.X38]
    /// </summary>
    public decimal? TotalDuetoSelleratClosingM { get => _totalDuetoSelleratClosingM; set => SetField(ref _totalDuetoSelleratClosingM, value); }

    /// <summary>
    /// Total From K [CD3.X41]
    /// </summary>
    public decimal? TotalFromK { get => _totalFromK; set => SetField(ref _totalFromK, value); }

    /// <summary>
    /// Total From L  [CD3.X42]
    /// </summary>
    public decimal? TotalFromL { get => _totalFromL; set => SetField(ref _totalFromL, value); }

    /// <summary>
    /// Total From M [CD3.X43]
    /// </summary>
    public decimal? TotalFromM { get => _totalFromM; set => SetField(ref _totalFromM, value); }

    /// <summary>
    /// Total From N [CD3.X44]
    /// </summary>
    public decimal? TotalFromN { get => _totalFromN; set => SetField(ref _totalFromN, value); }

    /// <summary>
    /// Total Paid Already by or on Behalf of Borower at Closing  [CD3.X22]
    /// </summary>
    public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get => _totalPaidAlreadybyoronBehalfofBoroweratClosing; set => SetField(ref _totalPaidAlreadybyoronBehalfofBoroweratClosing, value); }

    /// <summary>
    /// Total Purchase Payoffs Included [CD3.X1543]
    /// </summary>
    public decimal? TotalPurchasePayoffsIncluded { get => _totalPurchasePayoffsIncluded; set => SetField(ref _totalPurchasePayoffsIncluded, value); }

    /// <summary>
    /// ClosingDisclosure3Contract UcdDetails
    /// </summary>
    [AllowNull]
    public IList<UcdDetail> UcdDetails { get => GetField(ref _ucdDetails); set => SetField(ref _ucdDetails, value); }

    /// <summary>
    /// UCD K Line Subtotal [CD3.X1502]
    /// </summary>
    public decimal? UcdkSubTotal { get => _ucdkSubTotal; set => SetField(ref _ucdkSubTotal, value); }

    /// <summary>
    /// UCD K Line Subtotal [CD3.X1503]
    /// </summary>
    public decimal? UcdlSubTotal { get => _ucdlSubTotal; set => SetField(ref _ucdlSubTotal, value); }

    /// <summary>
    /// UCD Total Adjustments And Other Credits [CD3.X1504]
    /// </summary>
    public decimal? UcdTotalAdjustmentsAndOtherCredits { get => _ucdTotalAdjustmentsAndOtherCredits; set => SetField(ref _ucdTotalAdjustmentsAndOtherCredits, value); }
}