using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure3
    /// </summary>
    public sealed partial class ClosingDisclosure3 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualLECD3TotalClosingCostJFromLatestRec;
        /// <summary>
        /// Decimal Value of Alternate LE CD3 Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of Alternate LE CD3 Total Closing Costs J From Latest Disclosure Tracking Log")]
        public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get => _actualLECD3TotalClosingCostJFromLatestRec; set => _actualLECD3TotalClosingCostJFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec;
        /// <summary>
        /// Decimal Value of Alternate LE CD3 Total Payoffs And Payments K From Latest Disclosure Tracking Log [CD3.XH90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of Alternate LE CD3 Total Payoffs And Payments K From Latest Disclosure Tracking Log")]
        public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get => _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; set => _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLELoanAmountFromLatestRec;
        /// <summary>
        /// Decimal Value of Alternate LE Loan Amount From Latest Disclosure Tracking Log [CD3.XH87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of Alternate LE Loan Amount From Latest Disclosure Tracking Log")]
        public decimal? ActualLELoanAmountFromLatestRec { get => _actualLELoanAmountFromLatestRec; set => _actualLELoanAmountFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLenderCredits;
        /// <summary>
        /// ClosingDisclosure3 ActualLenderCredits
        /// </summary>
        public decimal? ActualLenderCredits { get => _actualLenderCredits; set => _actualLenderCredits = value; }
        private DirtyValue<decimal?> _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Adjustments And Other Credits From Latest Disclosure Tracking Log [CD3.XH100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Adjustments And Other Credits From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get => _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; set => _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEClosingCostFinancedFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Closing Costs Financed From Latest Disclosure Tracking Log [CD3.XH95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Closing Costs Financed From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get => _actualSTDLEClosingCostFinancedFromLatestRec; set => _actualSTDLEClosingCostFinancedFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEDepositFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Deposit From Latest Disclosure Tracking Log [CD3.XH97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Deposit From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLEDepositFromLatestRec { get => _actualSTDLEDepositFromLatestRec; set => _actualSTDLEDepositFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEDownPaymentFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Down Payment From Latest Disclosure Tracking Log [CD3.XH96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Down Payment From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLEDownPaymentFromLatestRec { get => _actualSTDLEDownPaymentFromLatestRec; set => _actualSTDLEDownPaymentFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEFundForBorrowerFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Funds For Borrower From Latest Disclosure Tracking Log [CD3.XH98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Funds For Borrower From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get => _actualSTDLEFundForBorrowerFromLatestRec; set => _actualSTDLEFundForBorrowerFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCredits;
        /// <summary>
        /// ClosingDisclosure3 ActualSTDLESellerCredits
        /// </summary>
        public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => _actualSTDLESellerCredits = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCreditsFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Seller Credits From Latest Disclosure Tracking Log [CD3.XH99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Seller Credits From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLESellerCreditsFromLatestRec { get => _actualSTDLESellerCreditsFromLatestRec; set => _actualSTDLESellerCreditsFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJ;
        /// <summary>
        /// ClosingDisclosure3 ActualSTDLETotalClosingCostJ
        /// </summary>
        public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => _actualSTDLETotalClosingCostJ = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJFromLatestRec;
        /// <summary>
        /// Decimal Value of STD LE Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Decimal Value of STD LE Total Closing Costs J From Latest Disclosure Tracking Log")]
        public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get => _actualSTDLETotalClosingCostJFromLatestRec; set => _actualSTDLETotalClosingCostJFromLatestRec = value; }
        private DirtyValue<string> _adjustments061;
        /// <summary>
        /// Adjustments06_1 [CD3.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments06_1")]
        public string Adjustments061 { get => _adjustments061; set => _adjustments061 = value; }
        private DirtyValue<decimal?> _adjustments062;
        /// <summary>
        /// Adjustments06_2 [CD3.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments06_2")]
        public decimal? Adjustments062 { get => _adjustments062; set => _adjustments062 = value; }
        private DirtyValue<string> _adjustments071;
        /// <summary>
        /// Adjustments07_1 [CD3.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments07_1")]
        public string Adjustments071 { get => _adjustments071; set => _adjustments071 = value; }
        private DirtyValue<decimal?> _adjustments072;
        /// <summary>
        /// Adjustments07_2 [CD3.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments07_2")]
        public decimal? Adjustments072 { get => _adjustments072; set => _adjustments072 = value; }
        private DirtyValue<string> _adjustments101;
        /// <summary>
        /// Adjustments10_1 [CD3.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments10_1")]
        public string Adjustments101 { get => _adjustments101; set => _adjustments101 = value; }
        private DirtyValue<decimal?> _adjustments102;
        /// <summary>
        /// Adjustments10_2 [CD3.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments10_2")]
        public decimal? Adjustments102 { get => _adjustments102; set => _adjustments102 = value; }
        private DirtyValue<string> _adjustments111;
        /// <summary>
        /// Adjustments11_1 [CD3.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments11_1")]
        public string Adjustments111 { get => _adjustments111; set => _adjustments111 = value; }
        private DirtyValue<decimal?> _adjustments112;
        /// <summary>
        /// Adjustments11_2 [CD3.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments11_2")]
        public decimal? Adjustments112 { get => _adjustments112; set => _adjustments112 = value; }
        private DirtyValue<string> _adjustments151;
        /// <summary>
        /// Adjustments15_1 [CD3.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments15_1")]
        public string Adjustments151 { get => _adjustments151; set => _adjustments151 = value; }
        private DirtyValue<decimal?> _adjustments152;
        /// <summary>
        /// Adjustments15_2 [CD3.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments15_2")]
        public decimal? Adjustments152 { get => _adjustments152; set => _adjustments152 = value; }
        private DirtyValue<string> _adjustments81;
        /// <summary>
        /// Adjustments8_1 [CD3.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments8_1")]
        public string Adjustments81 { get => _adjustments81; set => _adjustments81 = value; }
        private DirtyValue<decimal?> _adjustments82;
        /// <summary>
        /// Adjustments8_2 [CD3.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments8_2")]
        public decimal? Adjustments82 { get => _adjustments82; set => _adjustments82 = value; }
        private DirtyValue<string> _adjustments91;
        /// <summary>
        /// Adjustments9_1 [CD3.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustments9_1")]
        public string Adjustments91 { get => _adjustments91; set => _adjustments91 = value; }
        private DirtyValue<decimal?> _adjustments92;
        /// <summary>
        /// Adjustments9_2 [CD3.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustments9_2")]
        public decimal? Adjustments92 { get => _adjustments92; set => _adjustments92 = value; }
        private DirtyValue<string> _adjustmentsforItemsPaidbySellerinAdvance161;
        /// <summary>
        /// AdjustmentsforItemsPaidbySellerinAdvance16_1 [CD3.X30]
        /// </summary>
        [LoanFieldProperty(Description = "AdjustmentsforItemsPaidbySellerinAdvance16_1")]
        public string AdjustmentsforItemsPaidbySellerinAdvance161 { get => _adjustmentsforItemsPaidbySellerinAdvance161; set => _adjustmentsforItemsPaidbySellerinAdvance161 = value; }
        private DirtyValue<decimal?> _adjustmentsforItemsPaidbySellerinAdvance162;
        /// <summary>
        /// AdjustmentsforItemsPaidbySellerinAdvance16_2 [CD3.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "AdjustmentsforItemsPaidbySellerinAdvance16_2")]
        public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get => _adjustmentsforItemsPaidbySellerinAdvance162; set => _adjustmentsforItemsPaidbySellerinAdvance162 = value; }
        private DirtyValue<string> _aLTCashToCloseDidChangeCol;
        /// <summary>
        /// ALT Cash To Close Did Change Col [CD3.X122]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Cash To Close Did Change Col")]
        public string ALTCashToCloseDidChangeCol { get => _aLTCashToCloseDidChangeCol; set => _aLTCashToCloseDidChangeCol = value; }
        private DirtyValue<decimal?> _aLTCashToCloseRemark;
        /// <summary>
        /// ALT Cash To Close Remark [CD3.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ALT Cash To Close Remark")]
        public decimal? ALTCashToCloseRemark { get => _aLTCashToCloseRemark; set => _aLTCashToCloseRemark = value; }
        private DirtyValue<string> _aLTClosingCostBeforeClosingDidChangeCol;
        /// <summary>
        /// ALT CLosing Cost Before Did Change Col [CD3.X120]
        /// </summary>
        [LoanFieldProperty(Description = "ALT CLosing Cost Before Did Change Col")]
        public string ALTClosingCostBeforeClosingDidChangeCol { get => _aLTClosingCostBeforeClosingDidChangeCol; set => _aLTClosingCostBeforeClosingDidChangeCol = value; }
        private DirtyValue<decimal?> _aLTLegalLimit;
        /// <summary>
        /// ALT Legal Limit [CD3.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ALT Legal Limit")]
        public decimal? ALTLegalLimit { get => _aLTLegalLimit; set => _aLTLegalLimit = value; }
        private DirtyValue<string> _aLTLoanAmountDidChangeCol;
        /// <summary>
        /// ALT Loan Amount Did Change Col [CD3.X118]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Loan Amount Did Change Col")]
        public string ALTLoanAmountDidChangeCol { get => _aLTLoanAmountDidChangeCol; set => _aLTLoanAmountDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _aLTLoanAmountIncDecRemark;
        /// <summary>
        /// ALT Loan Amount IncDec Remark [CD3.X130]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Loan Amount IncDec Remark")]
        public StringEnumValue<IncreasedOrDecreased> ALTLoanAmountIncDecRemark { get => _aLTLoanAmountIncDecRemark; set => _aLTLoanAmountIncDecRemark = value; }
        private DirtyValue<string> _aLTTotalClosingCostDidChangeCol;
        /// <summary>
        /// ALT Total Closing Cost Did Change Col [CD3.X119]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Total Closing Cost Did Change Col")]
        public string ALTTotalClosingCostDidChangeCol { get => _aLTTotalClosingCostDidChangeCol; set => _aLTTotalClosingCostDidChangeCol = value; }
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _aLTTotalClosingCostRemark;
        /// <summary>
        /// ALT Total Closing Cost Remark [CD3.X131]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Total Closing Cost Remark")]
        public StringEnumValue<TotalClosingCostRemark> ALTTotalClosingCostRemark { get => _aLTTotalClosingCostRemark; set => _aLTTotalClosingCostRemark = value; }
        private DirtyValue<string> _aLTTotalPayoffsDidChangeCol;
        /// <summary>
        /// ALT Total Payoffs Did Change Col [CD3.X121]
        /// </summary>
        [LoanFieldProperty(Description = "ALT Total Payoffs Did Change Col")]
        public string ALTTotalPayoffsDidChangeCol { get => _aLTTotalPayoffsDidChangeCol; set => _aLTTotalPayoffsDidChangeCol = value; }
        private DirtyValue<decimal?> _cash;
        /// <summary>
        /// Cash [CD3.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Cash")]
        public decimal? Cash { get => _cash; set => _cash = value; }
        private DirtyValue<decimal?> _cashToClose;
        /// <summary>
        /// Cash To Close [CD3.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Cash To Close")]
        public decimal? CashToClose { get => _cashToClose; set => _cashToClose = value; }
        private DirtyValue<decimal?> _cD3CashToClose;
        /// <summary>
        /// CD3 Cash To Close [CD3.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD3 Cash To Close")]
        public decimal? CD3CashToClose { get => _cD3CashToClose; set => _cD3CashToClose = value; }
        private DirtyValue<string> _cD3CashToCloseFromToBorrower;
        /// <summary>
        /// CD3 Cash To Close From To Borrower [CD3.X86]
        /// </summary>
        [LoanFieldProperty(Description = "CD3 Cash To Close From To Borrower")]
        public string CD3CashToCloseFromToBorrower { get => _cD3CashToCloseFromToBorrower; set => _cD3CashToCloseFromToBorrower = value; }
        private DirtyValue<decimal?> _cD3ClosingCostsPaidBeforeClosing;
        /// <summary>
        /// CD3 Closing Costs Paid Before Closing [CD3.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD3 Closing Costs Paid Before Closing")]
        public decimal? CD3ClosingCostsPaidBeforeClosing { get => _cD3ClosingCostsPaidBeforeClosing; set => _cD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _cD3TotalClosingCostJ;
        /// <summary>
        /// CD3 Total Closing Cost J [CD3.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD3 Total Closing Cost J")]
        public decimal? CD3TotalClosingCostJ { get => _cD3TotalClosingCostJ; set => _cD3TotalClosingCostJ = value; }
        private DirtyValue<decimal?> _cD3TotalPayoffsAndPaymentsK;
        /// <summary>
        /// CD3 Total Payoffs And Payments K [CD3.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "CD3 Total Payoffs And Payments K")]
        public decimal? CD3TotalPayoffsAndPaymentsK { get => _cD3TotalPayoffsAndPaymentsK; set => _cD3TotalPayoffsAndPaymentsK = value; }
        private DirtyValue<decimal?> _closingCostsPaidAtClosing;
        /// <summary>
        /// Closing Costs Paid At Closing [CD3.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Costs Paid At Closing")]
        public decimal? ClosingCostsPaidAtClosing { get => _closingCostsPaidAtClosing; set => _closingCostsPaidAtClosing = value; }
        private DirtyValue<decimal?> _closingCostsPaidatClosingJ;
        /// <summary>
        /// Closing Costs Paid at Closing J [CD3.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Costs Paid at Closing J")]
        public decimal? ClosingCostsPaidatClosingJ { get => _closingCostsPaidatClosingJ; set => _closingCostsPaidatClosingJ = value; }
        private DirtyValue<string> _duefromSelleratClosing111;
        /// <summary>
        /// DuefromSelleratClosing11_1 [CD3.X32]
        /// </summary>
        [LoanFieldProperty(Description = "DuefromSelleratClosing11_1")]
        public string DuefromSelleratClosing111 { get => _duefromSelleratClosing111; set => _duefromSelleratClosing111 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing112;
        /// <summary>
        /// DuefromSelleratClosing11_2 [CD3.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DuefromSelleratClosing11_2")]
        public decimal? DuefromSelleratClosing112 { get => _duefromSelleratClosing112; set => _duefromSelleratClosing112 = value; }
        private DirtyValue<string> _duefromSelleratClosing121;
        /// <summary>
        /// DuefromSelleratClosing12_1 [CD3.X34]
        /// </summary>
        [LoanFieldProperty(Description = "DuefromSelleratClosing12_1")]
        public string DuefromSelleratClosing121 { get => _duefromSelleratClosing121; set => _duefromSelleratClosing121 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing122;
        /// <summary>
        /// DuefromSelleratClosing12_2 [CD3.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DuefromSelleratClosing12_2")]
        public decimal? DuefromSelleratClosing122 { get => _duefromSelleratClosing122; set => _duefromSelleratClosing122 = value; }
        private DirtyValue<string> _duefromSelleratClosing131;
        /// <summary>
        /// DuefromSelleratClosing13_1 [CD3.X36]
        /// </summary>
        [LoanFieldProperty(Description = "DuefromSelleratClosing13_1")]
        public string DuefromSelleratClosing131 { get => _duefromSelleratClosing131; set => _duefromSelleratClosing131 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing132;
        /// <summary>
        /// DuefromSelleratClosing13_2 [CD3.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DuefromSelleratClosing13_2")]
        public decimal? DuefromSelleratClosing132 { get => _duefromSelleratClosing132; set => _duefromSelleratClosing132 = value; }
        private DirtyValue<string> _dueToSellerAtClosing61;
        /// <summary>
        /// DueToSellerAtClosing6_1 [CD3.X24]
        /// </summary>
        [LoanFieldProperty(Description = "DueToSellerAtClosing6_1")]
        public string DueToSellerAtClosing61 { get => _dueToSellerAtClosing61; set => _dueToSellerAtClosing61 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing62;
        /// <summary>
        /// DueToSellerAtClosing6_2 [CD3.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DueToSellerAtClosing6_2")]
        public decimal? DueToSellerAtClosing62 { get => _dueToSellerAtClosing62; set => _dueToSellerAtClosing62 = value; }
        private DirtyValue<string> _dueToSellerAtClosing71;
        /// <summary>
        /// DueToSellerAtClosing7_1 [CD3.X26]
        /// </summary>
        [LoanFieldProperty(Description = "DueToSellerAtClosing7_1")]
        public string DueToSellerAtClosing71 { get => _dueToSellerAtClosing71; set => _dueToSellerAtClosing71 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing72;
        /// <summary>
        /// DueToSellerAtClosing7_2 [CD3.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DueToSellerAtClosing7_2")]
        public decimal? DueToSellerAtClosing72 { get => _dueToSellerAtClosing72; set => _dueToSellerAtClosing72 = value; }
        private DirtyValue<string> _dueToSellerAtClosing81;
        /// <summary>
        /// DueToSellerAtClosing8_1 [CD3.X28]
        /// </summary>
        [LoanFieldProperty(Description = "DueToSellerAtClosing8_1")]
        public string DueToSellerAtClosing81 { get => _dueToSellerAtClosing81; set => _dueToSellerAtClosing81 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing82;
        /// <summary>
        /// DueToSellerAtClosing8_2 [CD3.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "DueToSellerAtClosing8_2")]
        public decimal? DueToSellerAtClosing82 { get => _dueToSellerAtClosing82; set => _dueToSellerAtClosing82 = value; }
        private DirtyValue<bool?> _excludeBorrowerClosingCosts;
        /// <summary>
        /// Exclude Borrower Closing Costs [CD3.X137]
        /// </summary>
        [LoanFieldProperty(Description = "Exclude Borrower Closing Costs")]
        public bool? ExcludeBorrowerClosingCosts { get => _excludeBorrowerClosingCosts; set => _excludeBorrowerClosingCosts = value; }
        private DirtyValue<decimal?> _finalCashToClose;
        /// <summary>
        /// Closing disclosure - Final Cash To Close [CD3.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing disclosure - Final Cash To Close")]
        public decimal? FinalCashToClose { get => _finalCashToClose; set => _finalCashToClose = value; }
        private DirtyValue<string> _fromToBorrower;
        /// <summary>
        /// From To Borrower [CD3.X48]
        /// </summary>
        [LoanFieldProperty(Description = "From To Borrower")]
        public string FromToBorrower { get => _fromToBorrower; set => _fromToBorrower = value; }
        private DirtyValue<string> _fromToSeller;
        /// <summary>
        /// From To Seller [CD3.X49]
        /// </summary>
        [LoanFieldProperty(Description = "From To Seller")]
        public string FromToSeller { get => _fromToSeller; set => _fromToSeller = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure3 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lECD3CashToClose;
        /// <summary>
        /// LE CD3 Cash To Close [CD3.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LE CD3 Cash To Close")]
        public decimal? LECD3CashToClose { get => _lECD3CashToClose; set => _lECD3CashToClose = value; }
        private DirtyValue<string> _lECD3CashToCloseFromToBorrower;
        /// <summary>
        /// LE CD3 Cash To Close From To Borrower [CD3.X92]
        /// </summary>
        [LoanFieldProperty(Description = "LE CD3 Cash To Close From To Borrower")]
        public string LECD3CashToCloseFromToBorrower { get => _lECD3CashToCloseFromToBorrower; set => _lECD3CashToCloseFromToBorrower = value; }
        private DirtyValue<decimal?> _lECD3ClosingCostsPaidBeforeClosing;
        /// <summary>
        /// LE CD3 Closing Costs Paid Before Closing [CD3.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LE CD3 Closing Costs Paid Before Closing")]
        public decimal? LECD3ClosingCostsPaidBeforeClosing { get => _lECD3ClosingCostsPaidBeforeClosing; set => _lECD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _lECD3TotalClosingCostJ;
        /// <summary>
        /// LE CD3 Total Closing Cost J [CD3.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LE CD3 Total Closing Cost J")]
        public decimal? LECD3TotalClosingCostJ { get => _lECD3TotalClosingCostJ; set => _lECD3TotalClosingCostJ = value; }
        private DirtyValue<decimal?> _lECD3TotalPayoffsAndPaymentsK;
        /// <summary>
        /// LE CD3 Total Payoffs And Payments K [CD3.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LE CD3 Total Payoffs And Payments K")]
        public decimal? LECD3TotalPayoffsAndPaymentsK { get => _lECD3TotalPayoffsAndPaymentsK; set => _lECD3TotalPayoffsAndPaymentsK = value; }
        private DirtyValue<decimal?> _lELoanAmount;
        /// <summary>
        /// LE Loan Amount [CD3.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LE Loan Amount")]
        public decimal? LELoanAmount { get => _lELoanAmount; set => _lELoanAmount = value; }
        private DirtyValue<decimal?> _liabilityAmount1;
        /// <summary>
        /// Liability Amount 1 [CD3.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 1")]
        public decimal? LiabilityAmount1 { get => _liabilityAmount1; set => _liabilityAmount1 = value; }
        private DirtyValue<decimal?> _liabilityAmount10;
        /// <summary>
        /// Liability Amount 10 [CD3.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 10")]
        public decimal? LiabilityAmount10 { get => _liabilityAmount10; set => _liabilityAmount10 = value; }
        private DirtyValue<decimal?> _liabilityAmount11;
        /// <summary>
        /// Liability Amount 11 [CD3.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 11")]
        public decimal? LiabilityAmount11 { get => _liabilityAmount11; set => _liabilityAmount11 = value; }
        private DirtyValue<decimal?> _liabilityAmount12;
        /// <summary>
        /// Liability Amount 12 [CD3.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 12")]
        public decimal? LiabilityAmount12 { get => _liabilityAmount12; set => _liabilityAmount12 = value; }
        private DirtyValue<decimal?> _liabilityAmount13;
        /// <summary>
        /// Liability Amount 13 [CD3.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 13")]
        public decimal? LiabilityAmount13 { get => _liabilityAmount13; set => _liabilityAmount13 = value; }
        private DirtyValue<decimal?> _liabilityAmount14;
        /// <summary>
        /// Liability Amount 14 [CD3.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 14")]
        public decimal? LiabilityAmount14 { get => _liabilityAmount14; set => _liabilityAmount14 = value; }
        private DirtyValue<decimal?> _liabilityAmount15;
        /// <summary>
        /// Liability Amount 15 [CD3.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 15")]
        public decimal? LiabilityAmount15 { get => _liabilityAmount15; set => _liabilityAmount15 = value; }
        private DirtyValue<decimal?> _liabilityAmount2;
        /// <summary>
        /// Liability Amount 3 [CD3.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 3")]
        public decimal? LiabilityAmount2 { get => _liabilityAmount2; set => _liabilityAmount2 = value; }
        private DirtyValue<decimal?> _liabilityAmount3;
        /// <summary>
        /// Liability Amount 3 [CD3.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 3")]
        public decimal? LiabilityAmount3 { get => _liabilityAmount3; set => _liabilityAmount3 = value; }
        private DirtyValue<decimal?> _liabilityAmount4;
        /// <summary>
        /// Liability Amount 4 [CD3.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 4")]
        public decimal? LiabilityAmount4 { get => _liabilityAmount4; set => _liabilityAmount4 = value; }
        private DirtyValue<decimal?> _liabilityAmount5;
        /// <summary>
        /// Liability Amount  5 [CD3.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount  5")]
        public decimal? LiabilityAmount5 { get => _liabilityAmount5; set => _liabilityAmount5 = value; }
        private DirtyValue<decimal?> _liabilityAmount6;
        /// <summary>
        ///  Liability Amount 6 [CD3.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = " Liability Amount 6")]
        public decimal? LiabilityAmount6 { get => _liabilityAmount6; set => _liabilityAmount6 = value; }
        private DirtyValue<decimal?> _liabilityAmount7;
        /// <summary>
        /// Liability Amount 7 [CD3.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 7")]
        public decimal? LiabilityAmount7 { get => _liabilityAmount7; set => _liabilityAmount7 = value; }
        private DirtyValue<decimal?> _liabilityAmount8;
        /// <summary>
        /// Liability Amount 8 [CD3.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 8")]
        public decimal? LiabilityAmount8 { get => _liabilityAmount8; set => _liabilityAmount8 = value; }
        private DirtyValue<decimal?> _liabilityAmount9;
        /// <summary>
        /// Liability Amount 9 [CD3.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Amount 9")]
        public decimal? LiabilityAmount9 { get => _liabilityAmount9; set => _liabilityAmount9 = value; }
        private DirtyValue<string> _liabilityTo1;
        /// <summary>
        /// Liability To 1 [CD3.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 1")]
        public string LiabilityTo1 { get => _liabilityTo1; set => _liabilityTo1 = value; }
        private DirtyValue<string> _liabilityTo10;
        /// <summary>
        /// Liability To 10 [CD3.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 10")]
        public string LiabilityTo10 { get => _liabilityTo10; set => _liabilityTo10 = value; }
        private DirtyValue<string> _liabilityTo11;
        /// <summary>
        /// Liability To 11 [CD3.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 11")]
        public string LiabilityTo11 { get => _liabilityTo11; set => _liabilityTo11 = value; }
        private DirtyValue<string> _liabilityTo12;
        /// <summary>
        /// Liability To 12 [CD3.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 12")]
        public string LiabilityTo12 { get => _liabilityTo12; set => _liabilityTo12 = value; }
        private DirtyValue<string> _liabilityTo13;
        /// <summary>
        /// Liability To 13 [CD3.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 13")]
        public string LiabilityTo13 { get => _liabilityTo13; set => _liabilityTo13 = value; }
        private DirtyValue<string> _liabilityTo14;
        /// <summary>
        /// Liability To 14 [CD3.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 14")]
        public string LiabilityTo14 { get => _liabilityTo14; set => _liabilityTo14 = value; }
        private DirtyValue<string> _liabilityTo15;
        /// <summary>
        /// Liability To 15 [CD3.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 15")]
        public string LiabilityTo15 { get => _liabilityTo15; set => _liabilityTo15 = value; }
        private DirtyValue<string> _liabilityTo2;
        /// <summary>
        /// Liability To 3 [CD3.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 3")]
        public string LiabilityTo2 { get => _liabilityTo2; set => _liabilityTo2 = value; }
        private DirtyValue<string> _liabilityTo3;
        /// <summary>
        /// Liability To 3 [CD3.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 3")]
        public string LiabilityTo3 { get => _liabilityTo3; set => _liabilityTo3 = value; }
        private DirtyValue<string> _liabilityTo4;
        /// <summary>
        /// Liability To 4 [CD3.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 4")]
        public string LiabilityTo4 { get => _liabilityTo4; set => _liabilityTo4 = value; }
        private DirtyValue<string> _liabilityTo5;
        /// <summary>
        /// Liability To  5 [CD3.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To  5")]
        public string LiabilityTo5 { get => _liabilityTo5; set => _liabilityTo5 = value; }
        private DirtyValue<string> _liabilityTo6;
        /// <summary>
        ///  Liability To 6 [CD3.X55]
        /// </summary>
        [LoanFieldProperty(Description = " Liability To 6")]
        public string LiabilityTo6 { get => _liabilityTo6; set => _liabilityTo6 = value; }
        private DirtyValue<string> _liabilityTo7;
        /// <summary>
        /// Liability To 7 [CD3.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 7")]
        public string LiabilityTo7 { get => _liabilityTo7; set => _liabilityTo7 = value; }
        private DirtyValue<string> _liabilityTo8;
        /// <summary>
        /// Liability To 8 [CD3.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 8")]
        public string LiabilityTo8 { get => _liabilityTo8; set => _liabilityTo8 = value; }
        private DirtyValue<string> _liabilityTo9;
        /// <summary>
        /// Liability To 9 [CD3.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Liability To 9")]
        public string LiabilityTo9 { get => _liabilityTo9; set => _liabilityTo9 = value; }
        private DirtyValue<decimal?> _liabilityTotal;
        /// <summary>
        /// Liability Total [CD3.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Liability Total")]
        public decimal? LiabilityTotal { get => _liabilityTotal; set => _liabilityTotal = value; }
        private DirtyValue<decimal?> _loanAmount;
        /// <summary>
        /// Loan Amount [CD3.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Amount")]
        public decimal? LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<decimal?> _nonUCDTotalAdjustmentsAndOtherCredits;
        /// <summary>
        /// Non UCD Total Adjustments And Other Credits [CD3.X1505]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Non UCD Total Adjustments And Other Credits")]
        public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get => _nonUCDTotalAdjustmentsAndOtherCredits; set => _nonUCDTotalAdjustmentsAndOtherCredits = value; }
        private DirtyValue<bool?> _omitFromPrintSellersTransaction;
        /// <summary>
        /// Omit from Print Seller's Transaction [CD3.X138]
        /// </summary>
        [LoanFieldProperty(Description = "Omit from Print Seller's Transaction")]
        public bool? OmitFromPrintSellersTransaction { get => _omitFromPrintSellersTransaction; set => _omitFromPrintSellersTransaction = value; }
        private DirtyValue<string> _otherCredits61;
        /// <summary>
        /// OtherCredits6_1 [CD3.X9]
        /// </summary>
        [LoanFieldProperty(Description = "OtherCredits6_1")]
        public string OtherCredits61 { get => _otherCredits61; set => _otherCredits61 = value; }
        private DirtyValue<decimal?> _otherCredits62;
        /// <summary>
        /// OtherCredits6_2 [CD3.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "OtherCredits6_2")]
        public decimal? OtherCredits62 { get => _otherCredits62; set => _otherCredits62 = value; }
        private DirtyValue<string> _otherCredits71;
        /// <summary>
        /// OtherCredits7_1 [CD3.X11]
        /// </summary>
        [LoanFieldProperty(Description = "OtherCredits7_1")]
        public string OtherCredits71 { get => _otherCredits71; set => _otherCredits71 = value; }
        private DirtyValue<decimal?> _otherCredits72;
        /// <summary>
        /// OtherCredits7_2 [CD3.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "OtherCredits7_2")]
        public decimal? OtherCredits72 { get => _otherCredits72; set => _otherCredits72 = value; }
        private DirtyValue<decimal?> _priorToleranceCureAmount;
        /// <summary>
        /// Prior Tolerance Cure Amount [CD3.X135]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Prior Tolerance Cure Amount")]
        public decimal? PriorToleranceCureAmount { get => _priorToleranceCureAmount; set => _priorToleranceCureAmount = value; }
        private DirtyValue<StringEnumValue<STDAdjustmentAndOtherCreditsRemark>> _sTDAdjustmentAndOtherCreditsRemark;
        /// <summary>
        /// STD Adjustment And Other Credits Remark [CD3.X136]
        /// </summary>
        [LoanFieldProperty(Description = "STD Adjustment And Other Credits Remark")]
        public StringEnumValue<STDAdjustmentAndOtherCreditsRemark> STDAdjustmentAndOtherCreditsRemark { get => _sTDAdjustmentAndOtherCreditsRemark; set => _sTDAdjustmentAndOtherCreditsRemark = value; }
        private DirtyValue<string> _sTDAdjustmentsDidChangeCol;
        /// <summary>
        /// STD Adjustments Did Change Col [CD3.X117]
        /// </summary>
        [LoanFieldProperty(Description = "STD Adjustments Did Change Col")]
        public string STDAdjustmentsDidChangeCol { get => _sTDAdjustmentsDidChangeCol; set => _sTDAdjustmentsDidChangeCol = value; }
        private DirtyValue<string> _sTDClosingCostFinancedDidChangeCol;
        /// <summary>
        /// STD Closing Cost Financed Did Change Col [CD3.X134]
        /// </summary>
        [LoanFieldProperty(Description = "STD Closing Cost Financed Did Change Col")]
        public string STDClosingCostFinancedDidChangeCol { get => _sTDClosingCostFinancedDidChangeCol; set => _sTDClosingCostFinancedDidChangeCol = value; }
        private DirtyValue<string> _sTDDepositDidChangeCol;
        /// <summary>
        /// STD Deposit Did Change Col [CD3.X114]
        /// </summary>
        [LoanFieldProperty(Description = "STD Deposit Did Change Col")]
        public string STDDepositDidChangeCol { get => _sTDDepositDidChangeCol; set => _sTDDepositDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDepositIncDecRemark;
        /// <summary>
        /// STD Deposit IncDec Remark [CD3.X126]
        /// </summary>
        [LoanFieldProperty(Description = "STD Deposit IncDec Remark")]
        public StringEnumValue<IncreasedOrDecreased> STDDepositIncDecRemark { get => _sTDDepositIncDecRemark; set => _sTDDepositIncDecRemark = value; }
        private DirtyValue<string> _sTDDownPaymentDidChangeCol;
        /// <summary>
        /// STD Down Payment Did Change Col [CD3.X113]
        /// </summary>
        [LoanFieldProperty(Description = "STD Down Payment Did Change Col")]
        public string STDDownPaymentDidChangeCol { get => _sTDDownPaymentDidChangeCol; set => _sTDDownPaymentDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDownPaymentIncDecRemark;
        /// <summary>
        /// STD Down Payment IncDec Remark [CD3.X124]
        /// </summary>
        [LoanFieldProperty(Description = "STD Down Payment IncDec Remark")]
        public StringEnumValue<IncreasedOrDecreased> STDDownPaymentIncDecRemark { get => _sTDDownPaymentIncDecRemark; set => _sTDDownPaymentIncDecRemark = value; }
        private DirtyValue<StringEnumValue<STDDownPaymentSectionRemark>> _sTDDownPaymentSectionRemark;
        /// <summary>
        /// STD Down Payment Section Remark [CD3.X125]
        /// </summary>
        [LoanFieldProperty(Description = "STD Down Payment Section Remark")]
        public StringEnumValue<STDDownPaymentSectionRemark> STDDownPaymentSectionRemark { get => _sTDDownPaymentSectionRemark; set => _sTDDownPaymentSectionRemark = value; }
        private DirtyValue<decimal?> _sTDFinalAdjustmentAndOtherCredits;
        /// <summary>
        /// STD Final Adjustment And Other Credits [CD3.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Adjustment And Other Credits")]
        public decimal? STDFinalAdjustmentAndOtherCredits { get => _sTDFinalAdjustmentAndOtherCredits; set => _sTDFinalAdjustmentAndOtherCredits = value; }
        private DirtyValue<decimal?> _sTDFinalCashToClose;
        /// <summary>
        /// STD Final Cash To Close [CD3.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Cash To Close")]
        public decimal? STDFinalCashToClose { get => _sTDFinalCashToClose; set => _sTDFinalCashToClose = value; }
        private DirtyValue<decimal?> _sTDFinalCD3ClosingCostsPaidBeforeClosing;
        /// <summary>
        ///  STD Final CD3 Closing Costs Paid Before Closing [CD3.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = " STD Final CD3 Closing Costs Paid Before Closing")]
        public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get => _sTDFinalCD3ClosingCostsPaidBeforeClosing; set => _sTDFinalCD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _sTDFinalClosingCostFinanced;
        /// <summary>
        /// STD Final Closing Cost Financed [CD3.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Closing Cost Financed")]
        public decimal? STDFinalClosingCostFinanced { get => _sTDFinalClosingCostFinanced; set => _sTDFinalClosingCostFinanced = value; }
        private DirtyValue<decimal?> _sTDFinalDeposit;
        /// <summary>
        /// STD Final  Deposit [CD3.X106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final  Deposit")]
        public decimal? STDFinalDeposit { get => _sTDFinalDeposit; set => _sTDFinalDeposit = value; }
        private DirtyValue<decimal?> _sTDFinalDownPayment;
        /// <summary>
        /// STD Final Down Payment [CD3.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Down Payment")]
        public decimal? STDFinalDownPayment { get => _sTDFinalDownPayment; set => _sTDFinalDownPayment = value; }
        private DirtyValue<decimal?> _sTDFinalFundForBorrower;
        /// <summary>
        /// STD Final Fund For Borrower [CD3.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Fund For Borrower")]
        public decimal? STDFinalFundForBorrower { get => _sTDFinalFundForBorrower; set => _sTDFinalFundForBorrower = value; }
        private DirtyValue<decimal?> _sTDFinalSellerCredits;
        /// <summary>
        ///  STD Final  Seller Credits [CD3.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = " STD Final  Seller Credits")]
        public decimal? STDFinalSellerCredits { get => _sTDFinalSellerCredits; set => _sTDFinalSellerCredits = value; }
        private DirtyValue<decimal?> _sTDFinalTotalClosingCostJ;
        /// <summary>
        /// STD Final Total Closing Cost J [CD3.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD Final Total Closing Cost J")]
        public decimal? STDFinalTotalClosingCostJ { get => _sTDFinalTotalClosingCostJ; set => _sTDFinalTotalClosingCostJ = value; }
        private DirtyValue<string> _sTDFundsForBorrowerDidChangeCol;
        /// <summary>
        /// STD Funds for Borrower Did Change Col [CD3.X115]
        /// </summary>
        [LoanFieldProperty(Description = "STD Funds for Borrower Did Change Col")]
        public string STDFundsForBorrowerDidChangeCol { get => _sTDFundsForBorrowerDidChangeCol; set => _sTDFundsForBorrowerDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDFundsForBorrowerIncDecRemark;
        /// <summary>
        /// STD Funds For Borrower IncDec Remark [CD3.X127]
        /// </summary>
        [LoanFieldProperty(Description = "STD Funds For Borrower IncDec Remark")]
        public StringEnumValue<IncreasedOrDecreased> STDFundsForBorrowerIncDecRemark { get => _sTDFundsForBorrowerIncDecRemark; set => _sTDFundsForBorrowerIncDecRemark = value; }
        private DirtyValue<decimal?> _sTDLEAdjustmentAndOtherCredits;
        /// <summary>
        /// STD LE Adjustmen And Other Credits [CD3.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Adjustmen And Other Credits")]
        public decimal? STDLEAdjustmentAndOtherCredits { get => _sTDLEAdjustmentAndOtherCredits; set => _sTDLEAdjustmentAndOtherCredits = value; }
        private DirtyValue<decimal?> _sTDLECashToClose;
        /// <summary>
        /// STD LE Cash To Close [CD3.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Cash To Close")]
        public decimal? STDLECashToClose { get => _sTDLECashToClose; set => _sTDLECashToClose = value; }
        private DirtyValue<decimal?> _sTDLECD3ClosingCostsPaidBeforeClosing;
        /// <summary>
        /// STD LE CD3 Closing Costs Paid Before Closing [CD3.X94]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE CD3 Closing Costs Paid Before Closing")]
        public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get => _sTDLECD3ClosingCostsPaidBeforeClosing; set => _sTDLECD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _sTDLEClosingCostFinanced;
        /// <summary>
        /// STD LE Closing Cost Financed [CD3.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Closing Cost Financed")]
        public decimal? STDLEClosingCostFinanced { get => _sTDLEClosingCostFinanced; set => _sTDLEClosingCostFinanced = value; }
        private DirtyValue<decimal?> _sTDLEDeposit;
        /// <summary>
        /// STD LE Deposit [CD3.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Deposit")]
        public decimal? STDLEDeposit { get => _sTDLEDeposit; set => _sTDLEDeposit = value; }
        private DirtyValue<decimal?> _sTDLEDownPayment;
        /// <summary>
        /// STD LE Down Payment [CD3.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Down Payment")]
        public decimal? STDLEDownPayment { get => _sTDLEDownPayment; set => _sTDLEDownPayment = value; }
        private DirtyValue<decimal?> _sTDLEFundForBorrower;
        /// <summary>
        ///  STD LE Fund For Borrower [CD3.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = " STD LE Fund For Borrower")]
        public decimal? STDLEFundForBorrower { get => _sTDLEFundForBorrower; set => _sTDLEFundForBorrower = value; }
        private DirtyValue<decimal?> _sTDLegalLimit;
        /// <summary>
        /// Tolerance Cure [CD3.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Tolerance Cure")]
        public decimal? STDLegalLimit { get => _sTDLegalLimit; set => _sTDLegalLimit = value; }
        private DirtyValue<decimal?> _sTDLESellerCredits;
        /// <summary>
        /// STD LE Seller Credits [CD3.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "STD LE Seller Credits")]
        public decimal? STDLESellerCredits { get => _sTDLESellerCredits; set => _sTDLESellerCredits = value; }
        private DirtyValue<decimal?> _sTDLETotalClosingCostJ;
        /// <summary>
        ///  STD LE Total Closing Cost J [CD3.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = " STD LE Total Closing Cost J")]
        public decimal? STDLETotalClosingCostJ { get => _sTDLETotalClosingCostJ; set => _sTDLETotalClosingCostJ = value; }
        private DirtyValue<string> _sTDSellerCreditsDidChangeCol;
        /// <summary>
        /// STD Seller Credits Did Change Col [CD3.X116]
        /// </summary>
        [LoanFieldProperty(Description = "STD Seller Credits Did Change Col")]
        public string STDSellerCreditsDidChangeCol { get => _sTDSellerCreditsDidChangeCol; set => _sTDSellerCreditsDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDSellerCreditsIncDecRemark;
        /// <summary>
        /// STD Seller Credits IncDec Remark [CD3.X128]
        /// </summary>
        [LoanFieldProperty(Description = "STD Seller Credits IncDec Remark")]
        public StringEnumValue<IncreasedOrDecreased> STDSellerCreditsIncDecRemark { get => _sTDSellerCreditsIncDecRemark; set => _sTDSellerCreditsIncDecRemark = value; }
        private DirtyValue<string> _sTDTotalClosingCostBeforeClosingDidChangeCol;
        /// <summary>
        /// STD Total Closing Cost Before CLosing Did Change Col [CD3.X112]
        /// </summary>
        [LoanFieldProperty(Description = "STD Total Closing Cost Before CLosing Did Change Col")]
        public string STDTotalClosingCostBeforeClosingDidChangeCol { get => _sTDTotalClosingCostBeforeClosingDidChangeCol; set => _sTDTotalClosingCostBeforeClosingDidChangeCol = value; }
        private DirtyValue<string> _sTDTotalClosingCostDidChangeCol;
        /// <summary>
        /// STD Total Closing Cost Did Change Col [CD3.X111]
        /// </summary>
        [LoanFieldProperty(Description = "STD Total Closing Cost Did Change Col")]
        public string STDTotalClosingCostDidChangeCol { get => _sTDTotalClosingCostDidChangeCol; set => _sTDTotalClosingCostDidChangeCol = value; }
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _sTDTotalClosingCostRemark;
        /// <summary>
        /// STD Total Closing Cost Remark [CD3.X123]
        /// </summary>
        [LoanFieldProperty(Description = "STD Total Closing Cost Remark")]
        public StringEnumValue<TotalClosingCostRemark> STDTotalClosingCostRemark { get => _sTDTotalClosingCostRemark; set => _sTDTotalClosingCostRemark = value; }
        private DirtyValue<decimal?> _totalAdjustmentsAndOtherCredits;
        /// <summary>
        /// Total Adjustments And Other Credits [CD3.X1506]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Adjustments And Other Credits")]
        public decimal? TotalAdjustmentsAndOtherCredits { get => _totalAdjustmentsAndOtherCredits; set => _totalAdjustmentsAndOtherCredits = value; }
        private DirtyValue<decimal?> _totalDuefromBorrowerAtClosing;
        /// <summary>
        /// Total Due from Borrower At Closing [CD3.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Due from Borrower At Closing")]
        public decimal? TotalDuefromBorrowerAtClosing { get => _totalDuefromBorrowerAtClosing; set => _totalDuefromBorrowerAtClosing = value; }
        private DirtyValue<decimal?> _totalDuefromSelleratClosingN;
        /// <summary>
        /// Total Due from Seller at Closing N  [CD3.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Due from Seller at Closing N ")]
        public decimal? TotalDuefromSelleratClosingN { get => _totalDuefromSelleratClosingN; set => _totalDuefromSelleratClosingN = value; }
        private DirtyValue<decimal?> _totalDuetoSelleratClosingM;
        /// <summary>
        /// Total Due to Seller at Closing M [CD3.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Due to Seller at Closing M")]
        public decimal? TotalDuetoSelleratClosingM { get => _totalDuetoSelleratClosingM; set => _totalDuetoSelleratClosingM = value; }
        private DirtyValue<decimal?> _totalFromK;
        /// <summary>
        /// Total From K [CD3.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total From K")]
        public decimal? TotalFromK { get => _totalFromK; set => _totalFromK = value; }
        private DirtyValue<decimal?> _totalFromL;
        /// <summary>
        /// Total From L  [CD3.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total From L ")]
        public decimal? TotalFromL { get => _totalFromL; set => _totalFromL = value; }
        private DirtyValue<decimal?> _totalFromM;
        /// <summary>
        /// Total From M [CD3.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total From M")]
        public decimal? TotalFromM { get => _totalFromM; set => _totalFromM = value; }
        private DirtyValue<decimal?> _totalFromN;
        /// <summary>
        /// Total From N [CD3.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total From N")]
        public decimal? TotalFromN { get => _totalFromN; set => _totalFromN = value; }
        private DirtyValue<decimal?> _totalPaidAlreadybyoronBehalfofBoroweratClosing;
        /// <summary>
        /// Total Paid Already by or on Behalf of Borower at Closing  [CD3.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Paid Already by or on Behalf of Borower at Closing ")]
        public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get => _totalPaidAlreadybyoronBehalfofBoroweratClosing; set => _totalPaidAlreadybyoronBehalfofBoroweratClosing = value; }
        private DirtyList<UCDDetail> _uCDDetails;
        /// <summary>
        /// ClosingDisclosure3 UCDDetails
        /// </summary>
        public IList<UCDDetail> UCDDetails { get => _uCDDetails ?? (_uCDDetails = new DirtyList<UCDDetail>()); set => _uCDDetails = new DirtyList<UCDDetail>(value); }
        private DirtyValue<decimal?> _uCDKSubTotal;
        /// <summary>
        /// UCD K Line Subtotal [CD3.X1502]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "UCD K Line Subtotal")]
        public decimal? UCDKSubTotal { get => _uCDKSubTotal; set => _uCDKSubTotal = value; }
        private DirtyValue<decimal?> _uCDLSubTotal;
        /// <summary>
        /// UCD K Line Subtotal [CD3.X1503]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "UCD K Line Subtotal")]
        public decimal? UCDLSubTotal { get => _uCDLSubTotal; set => _uCDLSubTotal = value; }
        private DirtyValue<decimal?> _uCDTotalAdjustmentsAndOtherCredits;
        /// <summary>
        /// UCD Total Adjustments And Other Credits [CD3.X1504]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "UCD Total Adjustments And Other Credits")]
        public decimal? UCDTotalAdjustmentsAndOtherCredits { get => _uCDTotalAdjustmentsAndOtherCredits; set => _uCDTotalAdjustmentsAndOtherCredits = value; }
        internal override bool DirtyInternal
        {
            get => _actualLECD3TotalClosingCostJFromLatestRec.Dirty
                || _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Dirty
                || _actualLELoanAmountFromLatestRec.Dirty
                || _actualLenderCredits.Dirty
                || _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Dirty
                || _actualSTDLEClosingCostFinancedFromLatestRec.Dirty
                || _actualSTDLEDepositFromLatestRec.Dirty
                || _actualSTDLEDownPaymentFromLatestRec.Dirty
                || _actualSTDLEFundForBorrowerFromLatestRec.Dirty
                || _actualSTDLESellerCredits.Dirty
                || _actualSTDLESellerCreditsFromLatestRec.Dirty
                || _actualSTDLETotalClosingCostJ.Dirty
                || _actualSTDLETotalClosingCostJFromLatestRec.Dirty
                || _adjustments061.Dirty
                || _adjustments062.Dirty
                || _adjustments071.Dirty
                || _adjustments072.Dirty
                || _adjustments101.Dirty
                || _adjustments102.Dirty
                || _adjustments111.Dirty
                || _adjustments112.Dirty
                || _adjustments151.Dirty
                || _adjustments152.Dirty
                || _adjustments81.Dirty
                || _adjustments82.Dirty
                || _adjustments91.Dirty
                || _adjustments92.Dirty
                || _adjustmentsforItemsPaidbySellerinAdvance161.Dirty
                || _adjustmentsforItemsPaidbySellerinAdvance162.Dirty
                || _aLTCashToCloseDidChangeCol.Dirty
                || _aLTCashToCloseRemark.Dirty
                || _aLTClosingCostBeforeClosingDidChangeCol.Dirty
                || _aLTLegalLimit.Dirty
                || _aLTLoanAmountDidChangeCol.Dirty
                || _aLTLoanAmountIncDecRemark.Dirty
                || _aLTTotalClosingCostDidChangeCol.Dirty
                || _aLTTotalClosingCostRemark.Dirty
                || _aLTTotalPayoffsDidChangeCol.Dirty
                || _cash.Dirty
                || _cashToClose.Dirty
                || _cD3CashToClose.Dirty
                || _cD3CashToCloseFromToBorrower.Dirty
                || _cD3ClosingCostsPaidBeforeClosing.Dirty
                || _cD3TotalClosingCostJ.Dirty
                || _cD3TotalPayoffsAndPaymentsK.Dirty
                || _closingCostsPaidAtClosing.Dirty
                || _closingCostsPaidatClosingJ.Dirty
                || _duefromSelleratClosing111.Dirty
                || _duefromSelleratClosing112.Dirty
                || _duefromSelleratClosing121.Dirty
                || _duefromSelleratClosing122.Dirty
                || _duefromSelleratClosing131.Dirty
                || _duefromSelleratClosing132.Dirty
                || _dueToSellerAtClosing61.Dirty
                || _dueToSellerAtClosing62.Dirty
                || _dueToSellerAtClosing71.Dirty
                || _dueToSellerAtClosing72.Dirty
                || _dueToSellerAtClosing81.Dirty
                || _dueToSellerAtClosing82.Dirty
                || _excludeBorrowerClosingCosts.Dirty
                || _finalCashToClose.Dirty
                || _fromToBorrower.Dirty
                || _fromToSeller.Dirty
                || _id.Dirty
                || _lECD3CashToClose.Dirty
                || _lECD3CashToCloseFromToBorrower.Dirty
                || _lECD3ClosingCostsPaidBeforeClosing.Dirty
                || _lECD3TotalClosingCostJ.Dirty
                || _lECD3TotalPayoffsAndPaymentsK.Dirty
                || _lELoanAmount.Dirty
                || _liabilityAmount1.Dirty
                || _liabilityAmount10.Dirty
                || _liabilityAmount11.Dirty
                || _liabilityAmount12.Dirty
                || _liabilityAmount13.Dirty
                || _liabilityAmount14.Dirty
                || _liabilityAmount15.Dirty
                || _liabilityAmount2.Dirty
                || _liabilityAmount3.Dirty
                || _liabilityAmount4.Dirty
                || _liabilityAmount5.Dirty
                || _liabilityAmount6.Dirty
                || _liabilityAmount7.Dirty
                || _liabilityAmount8.Dirty
                || _liabilityAmount9.Dirty
                || _liabilityTo1.Dirty
                || _liabilityTo10.Dirty
                || _liabilityTo11.Dirty
                || _liabilityTo12.Dirty
                || _liabilityTo13.Dirty
                || _liabilityTo14.Dirty
                || _liabilityTo15.Dirty
                || _liabilityTo2.Dirty
                || _liabilityTo3.Dirty
                || _liabilityTo4.Dirty
                || _liabilityTo5.Dirty
                || _liabilityTo6.Dirty
                || _liabilityTo7.Dirty
                || _liabilityTo8.Dirty
                || _liabilityTo9.Dirty
                || _liabilityTotal.Dirty
                || _loanAmount.Dirty
                || _nonUCDTotalAdjustmentsAndOtherCredits.Dirty
                || _omitFromPrintSellersTransaction.Dirty
                || _otherCredits61.Dirty
                || _otherCredits62.Dirty
                || _otherCredits71.Dirty
                || _otherCredits72.Dirty
                || _priorToleranceCureAmount.Dirty
                || _sTDAdjustmentAndOtherCreditsRemark.Dirty
                || _sTDAdjustmentsDidChangeCol.Dirty
                || _sTDClosingCostFinancedDidChangeCol.Dirty
                || _sTDDepositDidChangeCol.Dirty
                || _sTDDepositIncDecRemark.Dirty
                || _sTDDownPaymentDidChangeCol.Dirty
                || _sTDDownPaymentIncDecRemark.Dirty
                || _sTDDownPaymentSectionRemark.Dirty
                || _sTDFinalAdjustmentAndOtherCredits.Dirty
                || _sTDFinalCashToClose.Dirty
                || _sTDFinalCD3ClosingCostsPaidBeforeClosing.Dirty
                || _sTDFinalClosingCostFinanced.Dirty
                || _sTDFinalDeposit.Dirty
                || _sTDFinalDownPayment.Dirty
                || _sTDFinalFundForBorrower.Dirty
                || _sTDFinalSellerCredits.Dirty
                || _sTDFinalTotalClosingCostJ.Dirty
                || _sTDFundsForBorrowerDidChangeCol.Dirty
                || _sTDFundsForBorrowerIncDecRemark.Dirty
                || _sTDLEAdjustmentAndOtherCredits.Dirty
                || _sTDLECashToClose.Dirty
                || _sTDLECD3ClosingCostsPaidBeforeClosing.Dirty
                || _sTDLEClosingCostFinanced.Dirty
                || _sTDLEDeposit.Dirty
                || _sTDLEDownPayment.Dirty
                || _sTDLEFundForBorrower.Dirty
                || _sTDLegalLimit.Dirty
                || _sTDLESellerCredits.Dirty
                || _sTDLETotalClosingCostJ.Dirty
                || _sTDSellerCreditsDidChangeCol.Dirty
                || _sTDSellerCreditsIncDecRemark.Dirty
                || _sTDTotalClosingCostBeforeClosingDidChangeCol.Dirty
                || _sTDTotalClosingCostDidChangeCol.Dirty
                || _sTDTotalClosingCostRemark.Dirty
                || _totalAdjustmentsAndOtherCredits.Dirty
                || _totalDuefromBorrowerAtClosing.Dirty
                || _totalDuefromSelleratClosingN.Dirty
                || _totalDuetoSelleratClosingM.Dirty
                || _totalFromK.Dirty
                || _totalFromL.Dirty
                || _totalFromM.Dirty
                || _totalFromN.Dirty
                || _totalPaidAlreadybyoronBehalfofBoroweratClosing.Dirty
                || _uCDKSubTotal.Dirty
                || _uCDLSubTotal.Dirty
                || _uCDTotalAdjustmentsAndOtherCredits.Dirty
                || _uCDDetails?.Dirty == true;
            set
            {
                _actualLECD3TotalClosingCostJFromLatestRec.Dirty = value;
                _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Dirty = value;
                _actualLELoanAmountFromLatestRec.Dirty = value;
                _actualLenderCredits.Dirty = value;
                _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Dirty = value;
                _actualSTDLEClosingCostFinancedFromLatestRec.Dirty = value;
                _actualSTDLEDepositFromLatestRec.Dirty = value;
                _actualSTDLEDownPaymentFromLatestRec.Dirty = value;
                _actualSTDLEFundForBorrowerFromLatestRec.Dirty = value;
                _actualSTDLESellerCredits.Dirty = value;
                _actualSTDLESellerCreditsFromLatestRec.Dirty = value;
                _actualSTDLETotalClosingCostJ.Dirty = value;
                _actualSTDLETotalClosingCostJFromLatestRec.Dirty = value;
                _adjustments061.Dirty = value;
                _adjustments062.Dirty = value;
                _adjustments071.Dirty = value;
                _adjustments072.Dirty = value;
                _adjustments101.Dirty = value;
                _adjustments102.Dirty = value;
                _adjustments111.Dirty = value;
                _adjustments112.Dirty = value;
                _adjustments151.Dirty = value;
                _adjustments152.Dirty = value;
                _adjustments81.Dirty = value;
                _adjustments82.Dirty = value;
                _adjustments91.Dirty = value;
                _adjustments92.Dirty = value;
                _adjustmentsforItemsPaidbySellerinAdvance161.Dirty = value;
                _adjustmentsforItemsPaidbySellerinAdvance162.Dirty = value;
                _aLTCashToCloseDidChangeCol.Dirty = value;
                _aLTCashToCloseRemark.Dirty = value;
                _aLTClosingCostBeforeClosingDidChangeCol.Dirty = value;
                _aLTLegalLimit.Dirty = value;
                _aLTLoanAmountDidChangeCol.Dirty = value;
                _aLTLoanAmountIncDecRemark.Dirty = value;
                _aLTTotalClosingCostDidChangeCol.Dirty = value;
                _aLTTotalClosingCostRemark.Dirty = value;
                _aLTTotalPayoffsDidChangeCol.Dirty = value;
                _cash.Dirty = value;
                _cashToClose.Dirty = value;
                _cD3CashToClose.Dirty = value;
                _cD3CashToCloseFromToBorrower.Dirty = value;
                _cD3ClosingCostsPaidBeforeClosing.Dirty = value;
                _cD3TotalClosingCostJ.Dirty = value;
                _cD3TotalPayoffsAndPaymentsK.Dirty = value;
                _closingCostsPaidAtClosing.Dirty = value;
                _closingCostsPaidatClosingJ.Dirty = value;
                _duefromSelleratClosing111.Dirty = value;
                _duefromSelleratClosing112.Dirty = value;
                _duefromSelleratClosing121.Dirty = value;
                _duefromSelleratClosing122.Dirty = value;
                _duefromSelleratClosing131.Dirty = value;
                _duefromSelleratClosing132.Dirty = value;
                _dueToSellerAtClosing61.Dirty = value;
                _dueToSellerAtClosing62.Dirty = value;
                _dueToSellerAtClosing71.Dirty = value;
                _dueToSellerAtClosing72.Dirty = value;
                _dueToSellerAtClosing81.Dirty = value;
                _dueToSellerAtClosing82.Dirty = value;
                _excludeBorrowerClosingCosts.Dirty = value;
                _finalCashToClose.Dirty = value;
                _fromToBorrower.Dirty = value;
                _fromToSeller.Dirty = value;
                _id.Dirty = value;
                _lECD3CashToClose.Dirty = value;
                _lECD3CashToCloseFromToBorrower.Dirty = value;
                _lECD3ClosingCostsPaidBeforeClosing.Dirty = value;
                _lECD3TotalClosingCostJ.Dirty = value;
                _lECD3TotalPayoffsAndPaymentsK.Dirty = value;
                _lELoanAmount.Dirty = value;
                _liabilityAmount1.Dirty = value;
                _liabilityAmount10.Dirty = value;
                _liabilityAmount11.Dirty = value;
                _liabilityAmount12.Dirty = value;
                _liabilityAmount13.Dirty = value;
                _liabilityAmount14.Dirty = value;
                _liabilityAmount15.Dirty = value;
                _liabilityAmount2.Dirty = value;
                _liabilityAmount3.Dirty = value;
                _liabilityAmount4.Dirty = value;
                _liabilityAmount5.Dirty = value;
                _liabilityAmount6.Dirty = value;
                _liabilityAmount7.Dirty = value;
                _liabilityAmount8.Dirty = value;
                _liabilityAmount9.Dirty = value;
                _liabilityTo1.Dirty = value;
                _liabilityTo10.Dirty = value;
                _liabilityTo11.Dirty = value;
                _liabilityTo12.Dirty = value;
                _liabilityTo13.Dirty = value;
                _liabilityTo14.Dirty = value;
                _liabilityTo15.Dirty = value;
                _liabilityTo2.Dirty = value;
                _liabilityTo3.Dirty = value;
                _liabilityTo4.Dirty = value;
                _liabilityTo5.Dirty = value;
                _liabilityTo6.Dirty = value;
                _liabilityTo7.Dirty = value;
                _liabilityTo8.Dirty = value;
                _liabilityTo9.Dirty = value;
                _liabilityTotal.Dirty = value;
                _loanAmount.Dirty = value;
                _nonUCDTotalAdjustmentsAndOtherCredits.Dirty = value;
                _omitFromPrintSellersTransaction.Dirty = value;
                _otherCredits61.Dirty = value;
                _otherCredits62.Dirty = value;
                _otherCredits71.Dirty = value;
                _otherCredits72.Dirty = value;
                _priorToleranceCureAmount.Dirty = value;
                _sTDAdjustmentAndOtherCreditsRemark.Dirty = value;
                _sTDAdjustmentsDidChangeCol.Dirty = value;
                _sTDClosingCostFinancedDidChangeCol.Dirty = value;
                _sTDDepositDidChangeCol.Dirty = value;
                _sTDDepositIncDecRemark.Dirty = value;
                _sTDDownPaymentDidChangeCol.Dirty = value;
                _sTDDownPaymentIncDecRemark.Dirty = value;
                _sTDDownPaymentSectionRemark.Dirty = value;
                _sTDFinalAdjustmentAndOtherCredits.Dirty = value;
                _sTDFinalCashToClose.Dirty = value;
                _sTDFinalCD3ClosingCostsPaidBeforeClosing.Dirty = value;
                _sTDFinalClosingCostFinanced.Dirty = value;
                _sTDFinalDeposit.Dirty = value;
                _sTDFinalDownPayment.Dirty = value;
                _sTDFinalFundForBorrower.Dirty = value;
                _sTDFinalSellerCredits.Dirty = value;
                _sTDFinalTotalClosingCostJ.Dirty = value;
                _sTDFundsForBorrowerDidChangeCol.Dirty = value;
                _sTDFundsForBorrowerIncDecRemark.Dirty = value;
                _sTDLEAdjustmentAndOtherCredits.Dirty = value;
                _sTDLECashToClose.Dirty = value;
                _sTDLECD3ClosingCostsPaidBeforeClosing.Dirty = value;
                _sTDLEClosingCostFinanced.Dirty = value;
                _sTDLEDeposit.Dirty = value;
                _sTDLEDownPayment.Dirty = value;
                _sTDLEFundForBorrower.Dirty = value;
                _sTDLegalLimit.Dirty = value;
                _sTDLESellerCredits.Dirty = value;
                _sTDLETotalClosingCostJ.Dirty = value;
                _sTDSellerCreditsDidChangeCol.Dirty = value;
                _sTDSellerCreditsIncDecRemark.Dirty = value;
                _sTDTotalClosingCostBeforeClosingDidChangeCol.Dirty = value;
                _sTDTotalClosingCostDidChangeCol.Dirty = value;
                _sTDTotalClosingCostRemark.Dirty = value;
                _totalAdjustmentsAndOtherCredits.Dirty = value;
                _totalDuefromBorrowerAtClosing.Dirty = value;
                _totalDuefromSelleratClosingN.Dirty = value;
                _totalDuetoSelleratClosingM.Dirty = value;
                _totalFromK.Dirty = value;
                _totalFromL.Dirty = value;
                _totalFromM.Dirty = value;
                _totalFromN.Dirty = value;
                _totalPaidAlreadybyoronBehalfofBoroweratClosing.Dirty = value;
                _uCDKSubTotal.Dirty = value;
                _uCDLSubTotal.Dirty = value;
                _uCDTotalAdjustmentsAndOtherCredits.Dirty = value;
                if (_uCDDetails != null) _uCDDetails.Dirty = value;
            }
        }
    }
}