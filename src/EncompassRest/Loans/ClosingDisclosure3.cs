using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure3
    /// </summary>
    public sealed partial class ClosingDisclosure3 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _actualLECD3TotalClosingCostJFromLatestRec;
        private DirtyValue<decimal?> _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec;
        private DirtyValue<decimal?> _actualLELoanAmountFromLatestRec;
        private DirtyValue<decimal?> _actualLenderCredits;
        private DirtyValue<decimal?> _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLEClosingCostFinancedFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLEDepositFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLEDownPaymentFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLEFundForBorrowerFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLESellerCredits;
        private DirtyValue<decimal?> _actualSTDLESellerCreditsFromLatestRec;
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJ;
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJFromLatestRec;
        private DirtyValue<string> _adjustments061;
        private DirtyValue<decimal?> _adjustments062;
        private DirtyValue<string> _adjustments071;
        private DirtyValue<decimal?> _adjustments072;
        private DirtyValue<string> _adjustments101;
        private DirtyValue<decimal?> _adjustments102;
        private DirtyValue<string> _adjustments111;
        private DirtyValue<decimal?> _adjustments112;
        private DirtyValue<string> _adjustments151;
        private DirtyValue<decimal?> _adjustments152;
        private DirtyValue<string> _adjustments81;
        private DirtyValue<decimal?> _adjustments82;
        private DirtyValue<string> _adjustments91;
        private DirtyValue<decimal?> _adjustments92;
        private DirtyValue<string> _adjustmentsforItemsPaidbySellerinAdvance161;
        private DirtyValue<decimal?> _adjustmentsforItemsPaidbySellerinAdvance162;
        private DirtyValue<string> _aLTCashToCloseDidChangeCol;
        private DirtyValue<decimal?> _aLTCashToCloseRemark;
        private DirtyValue<string> _aLTClosingCostBeforeClosingDidChangeCol;
        private DirtyValue<decimal?> _aLTLegalLimit;
        private DirtyValue<string> _aLTLoanAmountDidChangeCol;
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _aLTLoanAmountIncDecRemark;
        private DirtyValue<string> _aLTTotalClosingCostDidChangeCol;
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _aLTTotalClosingCostRemark;
        private DirtyValue<string> _aLTTotalPayoffsDidChangeCol;
        private DirtyValue<decimal?> _cash;
        private DirtyValue<decimal?> _cashToClose;
        private DirtyValue<decimal?> _cD3CashToClose;
        private DirtyValue<string> _cD3CashToCloseFromToBorrower;
        private DirtyValue<decimal?> _cD3ClosingCostsPaidBeforeClosing;
        private DirtyValue<decimal?> _cD3TotalClosingCostJ;
        private DirtyValue<decimal?> _cD3TotalPayoffsAndPaymentsK;
        private DirtyValue<decimal?> _closingCostsPaidAtClosing;
        private DirtyValue<decimal?> _closingCostsPaidatClosingJ;
        private DirtyValue<string> _duefromSelleratClosing111;
        private DirtyValue<decimal?> _duefromSelleratClosing112;
        private DirtyValue<string> _duefromSelleratClosing121;
        private DirtyValue<decimal?> _duefromSelleratClosing122;
        private DirtyValue<string> _duefromSelleratClosing131;
        private DirtyValue<decimal?> _duefromSelleratClosing132;
        private DirtyValue<string> _dueToSellerAtClosing61;
        private DirtyValue<decimal?> _dueToSellerAtClosing62;
        private DirtyValue<string> _dueToSellerAtClosing71;
        private DirtyValue<decimal?> _dueToSellerAtClosing72;
        private DirtyValue<string> _dueToSellerAtClosing81;
        private DirtyValue<decimal?> _dueToSellerAtClosing82;
        private DirtyValue<bool?> _excludeBorrowerClosingCosts;
        private DirtyValue<decimal?> _finalCashToClose;
        private DirtyValue<string> _fromToBorrower;
        private DirtyValue<string> _fromToSeller;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _lECD3CashToClose;
        private DirtyValue<string> _lECD3CashToCloseFromToBorrower;
        private DirtyValue<decimal?> _lECD3ClosingCostsPaidBeforeClosing;
        private DirtyValue<decimal?> _lECD3TotalClosingCostJ;
        private DirtyValue<decimal?> _lECD3TotalPayoffsAndPaymentsK;
        private DirtyValue<decimal?> _lELoanAmount;
        private DirtyValue<decimal?> _liabilityAmount1;
        private DirtyValue<decimal?> _liabilityAmount10;
        private DirtyValue<decimal?> _liabilityAmount11;
        private DirtyValue<decimal?> _liabilityAmount12;
        private DirtyValue<decimal?> _liabilityAmount13;
        private DirtyValue<decimal?> _liabilityAmount14;
        private DirtyValue<decimal?> _liabilityAmount15;
        private DirtyValue<decimal?> _liabilityAmount2;
        private DirtyValue<decimal?> _liabilityAmount3;
        private DirtyValue<decimal?> _liabilityAmount4;
        private DirtyValue<decimal?> _liabilityAmount5;
        private DirtyValue<decimal?> _liabilityAmount6;
        private DirtyValue<decimal?> _liabilityAmount7;
        private DirtyValue<decimal?> _liabilityAmount8;
        private DirtyValue<decimal?> _liabilityAmount9;
        private DirtyValue<string> _liabilityTo1;
        private DirtyValue<string> _liabilityTo10;
        private DirtyValue<string> _liabilityTo11;
        private DirtyValue<string> _liabilityTo12;
        private DirtyValue<string> _liabilityTo13;
        private DirtyValue<string> _liabilityTo14;
        private DirtyValue<string> _liabilityTo15;
        private DirtyValue<string> _liabilityTo2;
        private DirtyValue<string> _liabilityTo3;
        private DirtyValue<string> _liabilityTo4;
        private DirtyValue<string> _liabilityTo5;
        private DirtyValue<string> _liabilityTo6;
        private DirtyValue<string> _liabilityTo7;
        private DirtyValue<string> _liabilityTo8;
        private DirtyValue<string> _liabilityTo9;
        private DirtyValue<decimal?> _liabilityTotal;
        private DirtyValue<decimal?> _loanAmount;
        private DirtyValue<decimal?> _nonUCDTotalAdjustmentsAndOtherCredits;
        private DirtyValue<bool?> _omitFromPrintSellersTransaction;
        private DirtyValue<string> _otherCredits61;
        private DirtyValue<decimal?> _otherCredits62;
        private DirtyValue<string> _otherCredits71;
        private DirtyValue<decimal?> _otherCredits72;
        private DirtyValue<decimal?> _priorToleranceCureAmount;
        private DirtyValue<StringEnumValue<STDAdjustmentAndOtherCreditsRemark>> _sTDAdjustmentAndOtherCreditsRemark;
        private DirtyValue<string> _sTDAdjustmentsDidChangeCol;
        private DirtyValue<string> _sTDClosingCostFinancedDidChangeCol;
        private DirtyValue<string> _sTDDepositDidChangeCol;
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDepositIncDecRemark;
        private DirtyValue<string> _sTDDownPaymentDidChangeCol;
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDownPaymentIncDecRemark;
        private DirtyValue<StringEnumValue<STDDownPaymentSectionRemark>> _sTDDownPaymentSectionRemark;
        private DirtyValue<decimal?> _sTDFinalAdjustmentAndOtherCredits;
        private DirtyValue<decimal?> _sTDFinalCashToClose;
        private DirtyValue<decimal?> _sTDFinalCD3ClosingCostsPaidBeforeClosing;
        private DirtyValue<decimal?> _sTDFinalClosingCostFinanced;
        private DirtyValue<decimal?> _sTDFinalDeposit;
        private DirtyValue<decimal?> _sTDFinalDownPayment;
        private DirtyValue<decimal?> _sTDFinalFundForBorrower;
        private DirtyValue<decimal?> _sTDFinalSellerCredits;
        private DirtyValue<decimal?> _sTDFinalTotalClosingCostJ;
        private DirtyValue<string> _sTDFundsForBorrowerDidChangeCol;
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDFundsForBorrowerIncDecRemark;
        private DirtyValue<decimal?> _sTDLEAdjustmentAndOtherCredits;
        private DirtyValue<decimal?> _sTDLECashToClose;
        private DirtyValue<decimal?> _sTDLECD3ClosingCostsPaidBeforeClosing;
        private DirtyValue<decimal?> _sTDLEClosingCostFinanced;
        private DirtyValue<decimal?> _sTDLEDeposit;
        private DirtyValue<decimal?> _sTDLEDownPayment;
        private DirtyValue<decimal?> _sTDLEFundForBorrower;
        private DirtyValue<decimal?> _sTDLegalLimit;
        private DirtyValue<decimal?> _sTDLESellerCredits;
        private DirtyValue<decimal?> _sTDLETotalClosingCostJ;
        private DirtyValue<string> _sTDSellerCreditsDidChangeCol;
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDSellerCreditsIncDecRemark;
        private DirtyValue<string> _sTDTotalClosingCostBeforeClosingDidChangeCol;
        private DirtyValue<string> _sTDTotalClosingCostDidChangeCol;
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _sTDTotalClosingCostRemark;
        private DirtyValue<decimal?> _totalAdjustmentsAndOtherCredits;
        private DirtyValue<decimal?> _totalDuefromBorrowerAtClosing;
        private DirtyValue<decimal?> _totalDuefromSelleratClosingN;
        private DirtyValue<decimal?> _totalDuetoSelleratClosingM;
        private DirtyValue<decimal?> _totalFromK;
        private DirtyValue<decimal?> _totalFromL;
        private DirtyValue<decimal?> _totalFromM;
        private DirtyValue<decimal?> _totalFromN;
        private DirtyValue<decimal?> _totalPaidAlreadybyoronBehalfofBoroweratClosing;
        private DirtyList<UCDDetail> _uCDDetails;
        private DirtyValue<decimal?> _uCDKSubTotal;
        private DirtyValue<decimal?> _uCDLSubTotal;
        private DirtyValue<decimal?> _uCDTotalAdjustmentsAndOtherCredits;

        /// <summary>
        /// Decimal Value of Alternate LE CD3 Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get => _actualLECD3TotalClosingCostJFromLatestRec; set => SetField(ref _actualLECD3TotalClosingCostJFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of Alternate LE CD3 Total Payoffs And Payments K From Latest Disclosure Tracking Log [CD3.XH90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get => _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; set => SetField(ref _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of Alternate LE Loan Amount From Latest Disclosure Tracking Log [CD3.XH87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualLELoanAmountFromLatestRec { get => _actualLELoanAmountFromLatestRec; set => SetField(ref _actualLELoanAmountFromLatestRec, value); }

        /// <summary>
        /// ClosingDisclosure3 ActualLenderCredits
        /// </summary>
        public decimal? ActualLenderCredits { get => _actualLenderCredits; set => SetField(ref _actualLenderCredits, value); }

        /// <summary>
        /// Decimal Value of STD LE Adjustments And Other Credits From Latest Disclosure Tracking Log [CD3.XH100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get => _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; set => SetField(ref _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of STD LE Closing Costs Financed From Latest Disclosure Tracking Log [CD3.XH95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get => _actualSTDLEClosingCostFinancedFromLatestRec; set => SetField(ref _actualSTDLEClosingCostFinancedFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of STD LE Deposit From Latest Disclosure Tracking Log [CD3.XH97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLEDepositFromLatestRec { get => _actualSTDLEDepositFromLatestRec; set => SetField(ref _actualSTDLEDepositFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of STD LE Down Payment From Latest Disclosure Tracking Log [CD3.XH96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLEDownPaymentFromLatestRec { get => _actualSTDLEDownPaymentFromLatestRec; set => SetField(ref _actualSTDLEDownPaymentFromLatestRec, value); }

        /// <summary>
        /// Decimal Value of STD LE Funds For Borrower From Latest Disclosure Tracking Log [CD3.XH98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get => _actualSTDLEFundForBorrowerFromLatestRec; set => SetField(ref _actualSTDLEFundForBorrowerFromLatestRec, value); }

        /// <summary>
        /// ClosingDisclosure3 ActualSTDLESellerCredits
        /// </summary>
        public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => SetField(ref _actualSTDLESellerCredits, value); }

        /// <summary>
        /// Decimal Value of STD LE Seller Credits From Latest Disclosure Tracking Log [CD3.XH99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLESellerCreditsFromLatestRec { get => _actualSTDLESellerCreditsFromLatestRec; set => SetField(ref _actualSTDLESellerCreditsFromLatestRec, value); }

        /// <summary>
        /// ClosingDisclosure3 ActualSTDLETotalClosingCostJ
        /// </summary>
        public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => SetField(ref _actualSTDLETotalClosingCostJ, value); }

        /// <summary>
        /// Decimal Value of STD LE Total Closing Costs J From Latest Disclosure Tracking Log [CD3.XH93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get => _actualSTDLETotalClosingCostJFromLatestRec; set => SetField(ref _actualSTDLETotalClosingCostJFromLatestRec, value); }

        /// <summary>
        /// Adjustments06_1 [CD3.X2]
        /// </summary>
        public string Adjustments061 { get => _adjustments061; set => SetField(ref _adjustments061, value); }

        /// <summary>
        /// Adjustments06_2 [CD3.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments062 { get => _adjustments062; set => SetField(ref _adjustments062, value); }

        /// <summary>
        /// Adjustments07_1 [CD3.X4]
        /// </summary>
        public string Adjustments071 { get => _adjustments071; set => SetField(ref _adjustments071, value); }

        /// <summary>
        /// Adjustments07_2 [CD3.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments072 { get => _adjustments072; set => SetField(ref _adjustments072, value); }

        /// <summary>
        /// Adjustments10_1 [CD3.X17]
        /// </summary>
        public string Adjustments101 { get => _adjustments101; set => SetField(ref _adjustments101, value); }

        /// <summary>
        /// Adjustments10_2 [CD3.X18]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments102 { get => _adjustments102; set => SetField(ref _adjustments102, value); }

        /// <summary>
        /// Adjustments11_1 [CD3.X19]
        /// </summary>
        public string Adjustments111 { get => _adjustments111; set => SetField(ref _adjustments111, value); }

        /// <summary>
        /// Adjustments11_2 [CD3.X20]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments112 { get => _adjustments112; set => SetField(ref _adjustments112, value); }

        /// <summary>
        /// Adjustments15_1 [CD3.X6]
        /// </summary>
        public string Adjustments151 { get => _adjustments151; set => SetField(ref _adjustments151, value); }

        /// <summary>
        /// Adjustments15_2 [CD3.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments152 { get => _adjustments152; set => SetField(ref _adjustments152, value); }

        /// <summary>
        /// Adjustments8_1 [CD3.X13]
        /// </summary>
        public string Adjustments81 { get => _adjustments81; set => SetField(ref _adjustments81, value); }

        /// <summary>
        /// Adjustments8_2 [CD3.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments82 { get => _adjustments82; set => SetField(ref _adjustments82, value); }

        /// <summary>
        /// Adjustments9_1 [CD3.X15]
        /// </summary>
        public string Adjustments91 { get => _adjustments91; set => SetField(ref _adjustments91, value); }

        /// <summary>
        /// Adjustments9_2 [CD3.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Adjustments92 { get => _adjustments92; set => SetField(ref _adjustments92, value); }

        /// <summary>
        /// AdjustmentsforItemsPaidbySellerinAdvance16_1 [CD3.X30]
        /// </summary>
        public string AdjustmentsforItemsPaidbySellerinAdvance161 { get => _adjustmentsforItemsPaidbySellerinAdvance161; set => SetField(ref _adjustmentsforItemsPaidbySellerinAdvance161, value); }

        /// <summary>
        /// AdjustmentsforItemsPaidbySellerinAdvance16_2 [CD3.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get => _adjustmentsforItemsPaidbySellerinAdvance162; set => SetField(ref _adjustmentsforItemsPaidbySellerinAdvance162, value); }

        /// <summary>
        /// ALT Cash To Close Did Change Col [CD3.X122]
        /// </summary>
        public string ALTCashToCloseDidChangeCol { get => _aLTCashToCloseDidChangeCol; set => SetField(ref _aLTCashToCloseDidChangeCol, value); }

        /// <summary>
        /// ALT Cash To Close Remark [CD3.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ALTCashToCloseRemark { get => _aLTCashToCloseRemark; set => SetField(ref _aLTCashToCloseRemark, value); }

        /// <summary>
        /// ALT CLosing Cost Before Did Change Col [CD3.X120]
        /// </summary>
        public string ALTClosingCostBeforeClosingDidChangeCol { get => _aLTClosingCostBeforeClosingDidChangeCol; set => SetField(ref _aLTClosingCostBeforeClosingDidChangeCol, value); }

        /// <summary>
        /// ALT Legal Limit [CD3.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ALTLegalLimit { get => _aLTLegalLimit; set => SetField(ref _aLTLegalLimit, value); }

        /// <summary>
        /// ALT Loan Amount Did Change Col [CD3.X118]
        /// </summary>
        public string ALTLoanAmountDidChangeCol { get => _aLTLoanAmountDidChangeCol; set => SetField(ref _aLTLoanAmountDidChangeCol, value); }

        /// <summary>
        /// ALT Loan Amount IncDec Remark [CD3.X130]
        /// </summary>
        public StringEnumValue<IncreasedOrDecreased> ALTLoanAmountIncDecRemark { get => _aLTLoanAmountIncDecRemark; set => SetField(ref _aLTLoanAmountIncDecRemark, value); }

        /// <summary>
        /// ALT Total Closing Cost Did Change Col [CD3.X119]
        /// </summary>
        public string ALTTotalClosingCostDidChangeCol { get => _aLTTotalClosingCostDidChangeCol; set => SetField(ref _aLTTotalClosingCostDidChangeCol, value); }

        /// <summary>
        /// ALT Total Closing Cost Remark [CD3.X131]
        /// </summary>
        public StringEnumValue<TotalClosingCostRemark> ALTTotalClosingCostRemark { get => _aLTTotalClosingCostRemark; set => SetField(ref _aLTTotalClosingCostRemark, value); }

        /// <summary>
        /// ALT Total Payoffs Did Change Col [CD3.X121]
        /// </summary>
        public string ALTTotalPayoffsDidChangeCol { get => _aLTTotalPayoffsDidChangeCol; set => SetField(ref _aLTTotalPayoffsDidChangeCol, value); }

        /// <summary>
        /// Cash [CD3.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Cash { get => _cash; set => SetField(ref _cash, value); }

        /// <summary>
        /// Cash To Close [CD3.X23]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CashToClose { get => _cashToClose; set => SetField(ref _cashToClose, value); }

        /// <summary>
        /// CD3 Cash To Close [CD3.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD3CashToClose { get => _cD3CashToClose; set => SetField(ref _cD3CashToClose, value); }

        /// <summary>
        /// CD3 Cash To Close From To Borrower [CD3.X86]
        /// </summary>
        public string CD3CashToCloseFromToBorrower { get => _cD3CashToCloseFromToBorrower; set => SetField(ref _cD3CashToCloseFromToBorrower, value); }

        /// <summary>
        /// CD3 Closing Costs Paid Before Closing [CD3.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD3ClosingCostsPaidBeforeClosing { get => _cD3ClosingCostsPaidBeforeClosing; set => SetField(ref _cD3ClosingCostsPaidBeforeClosing, value); }

        /// <summary>
        /// CD3 Total Closing Cost J [CD3.X82]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD3TotalClosingCostJ { get => _cD3TotalClosingCostJ; set => SetField(ref _cD3TotalClosingCostJ, value); }

        /// <summary>
        /// CD3 Total Payoffs And Payments K [CD3.X84]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD3TotalPayoffsAndPaymentsK { get => _cD3TotalPayoffsAndPaymentsK; set => SetField(ref _cD3TotalPayoffsAndPaymentsK, value); }

        /// <summary>
        /// Closing Costs Paid At Closing [CD3.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClosingCostsPaidAtClosing { get => _closingCostsPaidAtClosing; set => SetField(ref _closingCostsPaidAtClosing, value); }

        /// <summary>
        /// Closing Costs Paid at Closing J [CD3.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ClosingCostsPaidatClosingJ { get => _closingCostsPaidatClosingJ; set => SetField(ref _closingCostsPaidatClosingJ, value); }

        /// <summary>
        /// DuefromSelleratClosing11_1 [CD3.X32]
        /// </summary>
        public string DuefromSelleratClosing111 { get => _duefromSelleratClosing111; set => SetField(ref _duefromSelleratClosing111, value); }

        /// <summary>
        /// DuefromSelleratClosing11_2 [CD3.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DuefromSelleratClosing112 { get => _duefromSelleratClosing112; set => SetField(ref _duefromSelleratClosing112, value); }

        /// <summary>
        /// DuefromSelleratClosing12_1 [CD3.X34]
        /// </summary>
        public string DuefromSelleratClosing121 { get => _duefromSelleratClosing121; set => SetField(ref _duefromSelleratClosing121, value); }

        /// <summary>
        /// DuefromSelleratClosing12_2 [CD3.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DuefromSelleratClosing122 { get => _duefromSelleratClosing122; set => SetField(ref _duefromSelleratClosing122, value); }

        /// <summary>
        /// DuefromSelleratClosing13_1 [CD3.X36]
        /// </summary>
        public string DuefromSelleratClosing131 { get => _duefromSelleratClosing131; set => SetField(ref _duefromSelleratClosing131, value); }

        /// <summary>
        /// DuefromSelleratClosing13_2 [CD3.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DuefromSelleratClosing132 { get => _duefromSelleratClosing132; set => SetField(ref _duefromSelleratClosing132, value); }

        /// <summary>
        /// DueToSellerAtClosing6_1 [CD3.X24]
        /// </summary>
        public string DueToSellerAtClosing61 { get => _dueToSellerAtClosing61; set => SetField(ref _dueToSellerAtClosing61, value); }

        /// <summary>
        /// DueToSellerAtClosing6_2 [CD3.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueToSellerAtClosing62 { get => _dueToSellerAtClosing62; set => SetField(ref _dueToSellerAtClosing62, value); }

        /// <summary>
        /// DueToSellerAtClosing7_1 [CD3.X26]
        /// </summary>
        public string DueToSellerAtClosing71 { get => _dueToSellerAtClosing71; set => SetField(ref _dueToSellerAtClosing71, value); }

        /// <summary>
        /// DueToSellerAtClosing7_2 [CD3.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueToSellerAtClosing72 { get => _dueToSellerAtClosing72; set => SetField(ref _dueToSellerAtClosing72, value); }

        /// <summary>
        /// DueToSellerAtClosing8_1 [CD3.X28]
        /// </summary>
        public string DueToSellerAtClosing81 { get => _dueToSellerAtClosing81; set => SetField(ref _dueToSellerAtClosing81, value); }

        /// <summary>
        /// DueToSellerAtClosing8_2 [CD3.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueToSellerAtClosing82 { get => _dueToSellerAtClosing82; set => SetField(ref _dueToSellerAtClosing82, value); }

        /// <summary>
        /// Exclude Borrower Closing Costs [CD3.X137]
        /// </summary>
        public bool? ExcludeBorrowerClosingCosts { get => _excludeBorrowerClosingCosts; set => SetField(ref _excludeBorrowerClosingCosts, value); }

        /// <summary>
        /// Closing disclosure - Final Cash To Close [CD3.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinalCashToClose { get => _finalCashToClose; set => SetField(ref _finalCashToClose, value); }

        /// <summary>
        /// From To Borrower [CD3.X48]
        /// </summary>
        public string FromToBorrower { get => _fromToBorrower; set => SetField(ref _fromToBorrower, value); }

        /// <summary>
        /// From To Seller [CD3.X49]
        /// </summary>
        public string FromToSeller { get => _fromToSeller; set => SetField(ref _fromToSeller, value); }

        /// <summary>
        /// ClosingDisclosure3 Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// LE CD3 Cash To Close [CD3.X91]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LECD3CashToClose { get => _lECD3CashToClose; set => SetField(ref _lECD3CashToClose, value); }

        /// <summary>
        /// LE CD3 Cash To Close From To Borrower [CD3.X92]
        /// </summary>
        public string LECD3CashToCloseFromToBorrower { get => _lECD3CashToCloseFromToBorrower; set => SetField(ref _lECD3CashToCloseFromToBorrower, value); }

        /// <summary>
        /// LE CD3 Closing Costs Paid Before Closing [CD3.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LECD3ClosingCostsPaidBeforeClosing { get => _lECD3ClosingCostsPaidBeforeClosing; set => SetField(ref _lECD3ClosingCostsPaidBeforeClosing, value); }

        /// <summary>
        /// LE CD3 Total Closing Cost J [CD3.X88]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LECD3TotalClosingCostJ { get => _lECD3TotalClosingCostJ; set => SetField(ref _lECD3TotalClosingCostJ, value); }

        /// <summary>
        /// LE CD3 Total Payoffs And Payments K [CD3.X90]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LECD3TotalPayoffsAndPaymentsK { get => _lECD3TotalPayoffsAndPaymentsK; set => SetField(ref _lECD3TotalPayoffsAndPaymentsK, value); }

        /// <summary>
        /// LE Loan Amount [CD3.X87]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LELoanAmount { get => _lELoanAmount; set => SetField(ref _lELoanAmount, value); }

        /// <summary>
        /// Liability Amount 1 [CD3.X65]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount1 { get => _liabilityAmount1; set => SetField(ref _liabilityAmount1, value); }

        /// <summary>
        /// Liability Amount 10 [CD3.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount10 { get => _liabilityAmount10; set => SetField(ref _liabilityAmount10, value); }

        /// <summary>
        /// Liability Amount 11 [CD3.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount11 { get => _liabilityAmount11; set => SetField(ref _liabilityAmount11, value); }

        /// <summary>
        /// Liability Amount 12 [CD3.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount12 { get => _liabilityAmount12; set => SetField(ref _liabilityAmount12, value); }

        /// <summary>
        /// Liability Amount 13 [CD3.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount13 { get => _liabilityAmount13; set => SetField(ref _liabilityAmount13, value); }

        /// <summary>
        /// Liability Amount 14 [CD3.X78]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount14 { get => _liabilityAmount14; set => SetField(ref _liabilityAmount14, value); }

        /// <summary>
        /// Liability Amount 15 [CD3.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount15 { get => _liabilityAmount15; set => SetField(ref _liabilityAmount15, value); }

        /// <summary>
        /// Liability Amount 3 [CD3.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount2 { get => _liabilityAmount2; set => SetField(ref _liabilityAmount2, value); }

        /// <summary>
        /// Liability Amount 3 [CD3.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount3 { get => _liabilityAmount3; set => SetField(ref _liabilityAmount3, value); }

        /// <summary>
        /// Liability Amount 4 [CD3.X68]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount4 { get => _liabilityAmount4; set => SetField(ref _liabilityAmount4, value); }

        /// <summary>
        /// Liability Amount  5 [CD3.X69]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount5 { get => _liabilityAmount5; set => SetField(ref _liabilityAmount5, value); }

        /// <summary>
        ///  Liability Amount 6 [CD3.X70]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount6 { get => _liabilityAmount6; set => SetField(ref _liabilityAmount6, value); }

        /// <summary>
        /// Liability Amount 7 [CD3.X71]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount7 { get => _liabilityAmount7; set => SetField(ref _liabilityAmount7, value); }

        /// <summary>
        /// Liability Amount 8 [CD3.X72]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount8 { get => _liabilityAmount8; set => SetField(ref _liabilityAmount8, value); }

        /// <summary>
        /// Liability Amount 9 [CD3.X73]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityAmount9 { get => _liabilityAmount9; set => SetField(ref _liabilityAmount9, value); }

        /// <summary>
        /// Liability To 1 [CD3.X50]
        /// </summary>
        public string LiabilityTo1 { get => _liabilityTo1; set => SetField(ref _liabilityTo1, value); }

        /// <summary>
        /// Liability To 10 [CD3.X59]
        /// </summary>
        public string LiabilityTo10 { get => _liabilityTo10; set => SetField(ref _liabilityTo10, value); }

        /// <summary>
        /// Liability To 11 [CD3.X60]
        /// </summary>
        public string LiabilityTo11 { get => _liabilityTo11; set => SetField(ref _liabilityTo11, value); }

        /// <summary>
        /// Liability To 12 [CD3.X61]
        /// </summary>
        public string LiabilityTo12 { get => _liabilityTo12; set => SetField(ref _liabilityTo12, value); }

        /// <summary>
        /// Liability To 13 [CD3.X62]
        /// </summary>
        public string LiabilityTo13 { get => _liabilityTo13; set => SetField(ref _liabilityTo13, value); }

        /// <summary>
        /// Liability To 14 [CD3.X63]
        /// </summary>
        public string LiabilityTo14 { get => _liabilityTo14; set => SetField(ref _liabilityTo14, value); }

        /// <summary>
        /// Liability To 15 [CD3.X64]
        /// </summary>
        public string LiabilityTo15 { get => _liabilityTo15; set => SetField(ref _liabilityTo15, value); }

        /// <summary>
        /// Liability To 3 [CD3.X51]
        /// </summary>
        public string LiabilityTo2 { get => _liabilityTo2; set => SetField(ref _liabilityTo2, value); }

        /// <summary>
        /// Liability To 3 [CD3.X52]
        /// </summary>
        public string LiabilityTo3 { get => _liabilityTo3; set => SetField(ref _liabilityTo3, value); }

        /// <summary>
        /// Liability To 4 [CD3.X53]
        /// </summary>
        public string LiabilityTo4 { get => _liabilityTo4; set => SetField(ref _liabilityTo4, value); }

        /// <summary>
        /// Liability To  5 [CD3.X54]
        /// </summary>
        public string LiabilityTo5 { get => _liabilityTo5; set => SetField(ref _liabilityTo5, value); }

        /// <summary>
        ///  Liability To 6 [CD3.X55]
        /// </summary>
        public string LiabilityTo6 { get => _liabilityTo6; set => SetField(ref _liabilityTo6, value); }

        /// <summary>
        /// Liability To 7 [CD3.X56]
        /// </summary>
        public string LiabilityTo7 { get => _liabilityTo7; set => SetField(ref _liabilityTo7, value); }

        /// <summary>
        /// Liability To 8 [CD3.X57]
        /// </summary>
        public string LiabilityTo8 { get => _liabilityTo8; set => SetField(ref _liabilityTo8, value); }

        /// <summary>
        /// Liability To 9 [CD3.X58]
        /// </summary>
        public string LiabilityTo9 { get => _liabilityTo9; set => SetField(ref _liabilityTo9, value); }

        /// <summary>
        /// Liability Total [CD3.X80]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LiabilityTotal { get => _liabilityTotal; set => SetField(ref _liabilityTotal, value); }

        /// <summary>
        /// Loan Amount [CD3.X81]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LoanAmount { get => _loanAmount; set => SetField(ref _loanAmount, value); }

        /// <summary>
        /// Non UCD Total Adjustments And Other Credits [CD3.X1505]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get => _nonUCDTotalAdjustmentsAndOtherCredits; set => SetField(ref _nonUCDTotalAdjustmentsAndOtherCredits, value); }

        /// <summary>
        /// Omit from Print Seller's Transaction [CD3.X138]
        /// </summary>
        public bool? OmitFromPrintSellersTransaction { get => _omitFromPrintSellersTransaction; set => SetField(ref _omitFromPrintSellersTransaction, value); }

        /// <summary>
        /// OtherCredits6_1 [CD3.X9]
        /// </summary>
        public string OtherCredits61 { get => _otherCredits61; set => SetField(ref _otherCredits61, value); }

        /// <summary>
        /// OtherCredits6_2 [CD3.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherCredits62 { get => _otherCredits62; set => SetField(ref _otherCredits62, value); }

        /// <summary>
        /// OtherCredits7_1 [CD3.X11]
        /// </summary>
        public string OtherCredits71 { get => _otherCredits71; set => SetField(ref _otherCredits71, value); }

        /// <summary>
        /// OtherCredits7_2 [CD3.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? OtherCredits72 { get => _otherCredits72; set => SetField(ref _otherCredits72, value); }

        /// <summary>
        /// Prior Tolerance Cure Amount [CD3.X135]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PriorToleranceCureAmount { get => _priorToleranceCureAmount; set => SetField(ref _priorToleranceCureAmount, value); }

        /// <summary>
        /// STD Adjustment And Other Credits Remark [CD3.X136]
        /// </summary>
        public StringEnumValue<STDAdjustmentAndOtherCreditsRemark> STDAdjustmentAndOtherCreditsRemark { get => _sTDAdjustmentAndOtherCreditsRemark; set => SetField(ref _sTDAdjustmentAndOtherCreditsRemark, value); }

        /// <summary>
        /// STD Adjustments Did Change Col [CD3.X117]
        /// </summary>
        public string STDAdjustmentsDidChangeCol { get => _sTDAdjustmentsDidChangeCol; set => SetField(ref _sTDAdjustmentsDidChangeCol, value); }

        /// <summary>
        /// STD Closing Cost Financed Did Change Col [CD3.X134]
        /// </summary>
        public string STDClosingCostFinancedDidChangeCol { get => _sTDClosingCostFinancedDidChangeCol; set => SetField(ref _sTDClosingCostFinancedDidChangeCol, value); }

        /// <summary>
        /// STD Deposit Did Change Col [CD3.X114]
        /// </summary>
        public string STDDepositDidChangeCol { get => _sTDDepositDidChangeCol; set => SetField(ref _sTDDepositDidChangeCol, value); }

        /// <summary>
        /// STD Deposit IncDec Remark [CD3.X126]
        /// </summary>
        public StringEnumValue<IncreasedOrDecreased> STDDepositIncDecRemark { get => _sTDDepositIncDecRemark; set => SetField(ref _sTDDepositIncDecRemark, value); }

        /// <summary>
        /// STD Down Payment Did Change Col [CD3.X113]
        /// </summary>
        public string STDDownPaymentDidChangeCol { get => _sTDDownPaymentDidChangeCol; set => SetField(ref _sTDDownPaymentDidChangeCol, value); }

        /// <summary>
        /// STD Down Payment IncDec Remark [CD3.X124]
        /// </summary>
        public StringEnumValue<IncreasedOrDecreased> STDDownPaymentIncDecRemark { get => _sTDDownPaymentIncDecRemark; set => SetField(ref _sTDDownPaymentIncDecRemark, value); }

        /// <summary>
        /// STD Down Payment Section Remark [CD3.X125]
        /// </summary>
        public StringEnumValue<STDDownPaymentSectionRemark> STDDownPaymentSectionRemark { get => _sTDDownPaymentSectionRemark; set => SetField(ref _sTDDownPaymentSectionRemark, value); }

        /// <summary>
        /// STD Final Adjustment And Other Credits [CD3.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalAdjustmentAndOtherCredits { get => _sTDFinalAdjustmentAndOtherCredits; set => SetField(ref _sTDFinalAdjustmentAndOtherCredits, value); }

        /// <summary>
        /// STD Final Cash To Close [CD3.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalCashToClose { get => _sTDFinalCashToClose; set => SetField(ref _sTDFinalCashToClose, value); }

        /// <summary>
        ///  STD Final CD3 Closing Costs Paid Before Closing [CD3.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get => _sTDFinalCD3ClosingCostsPaidBeforeClosing; set => SetField(ref _sTDFinalCD3ClosingCostsPaidBeforeClosing, value); }

        /// <summary>
        /// STD Final Closing Cost Financed [CD3.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalClosingCostFinanced { get => _sTDFinalClosingCostFinanced; set => SetField(ref _sTDFinalClosingCostFinanced, value); }

        /// <summary>
        /// STD Final  Deposit [CD3.X106]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalDeposit { get => _sTDFinalDeposit; set => SetField(ref _sTDFinalDeposit, value); }

        /// <summary>
        /// STD Final Down Payment [CD3.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalDownPayment { get => _sTDFinalDownPayment; set => SetField(ref _sTDFinalDownPayment, value); }

        /// <summary>
        /// STD Final Fund For Borrower [CD3.X107]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalFundForBorrower { get => _sTDFinalFundForBorrower; set => SetField(ref _sTDFinalFundForBorrower, value); }

        /// <summary>
        ///  STD Final  Seller Credits [CD3.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalSellerCredits { get => _sTDFinalSellerCredits; set => SetField(ref _sTDFinalSellerCredits, value); }

        /// <summary>
        /// STD Final Total Closing Cost J [CD3.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDFinalTotalClosingCostJ { get => _sTDFinalTotalClosingCostJ; set => SetField(ref _sTDFinalTotalClosingCostJ, value); }

        /// <summary>
        /// STD Funds for Borrower Did Change Col [CD3.X115]
        /// </summary>
        public string STDFundsForBorrowerDidChangeCol { get => _sTDFundsForBorrowerDidChangeCol; set => SetField(ref _sTDFundsForBorrowerDidChangeCol, value); }

        /// <summary>
        /// STD Funds For Borrower IncDec Remark [CD3.X127]
        /// </summary>
        public StringEnumValue<IncreasedOrDecreased> STDFundsForBorrowerIncDecRemark { get => _sTDFundsForBorrowerIncDecRemark; set => SetField(ref _sTDFundsForBorrowerIncDecRemark, value); }

        /// <summary>
        /// STD LE Adjustmen And Other Credits [CD3.X100]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLEAdjustmentAndOtherCredits { get => _sTDLEAdjustmentAndOtherCredits; set => SetField(ref _sTDLEAdjustmentAndOtherCredits, value); }

        /// <summary>
        /// STD LE Cash To Close [CD3.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLECashToClose { get => _sTDLECashToClose; set => SetField(ref _sTDLECashToClose, value); }

        /// <summary>
        /// STD LE CD3 Closing Costs Paid Before Closing [CD3.X94]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get => _sTDLECD3ClosingCostsPaidBeforeClosing; set => SetField(ref _sTDLECD3ClosingCostsPaidBeforeClosing, value); }

        /// <summary>
        /// STD LE Closing Cost Financed [CD3.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLEClosingCostFinanced { get => _sTDLEClosingCostFinanced; set => SetField(ref _sTDLEClosingCostFinanced, value); }

        /// <summary>
        /// STD LE Deposit [CD3.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLEDeposit { get => _sTDLEDeposit; set => SetField(ref _sTDLEDeposit, value); }

        /// <summary>
        /// STD LE Down Payment [CD3.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLEDownPayment { get => _sTDLEDownPayment; set => SetField(ref _sTDLEDownPayment, value); }

        /// <summary>
        ///  STD LE Fund For Borrower [CD3.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLEFundForBorrower { get => _sTDLEFundForBorrower; set => SetField(ref _sTDLEFundForBorrower, value); }

        /// <summary>
        /// Tolerance Cure [CD3.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLegalLimit { get => _sTDLegalLimit; set => SetField(ref _sTDLegalLimit, value); }

        /// <summary>
        /// STD LE Seller Credits [CD3.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLESellerCredits { get => _sTDLESellerCredits; set => SetField(ref _sTDLESellerCredits, value); }

        /// <summary>
        ///  STD LE Total Closing Cost J [CD3.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? STDLETotalClosingCostJ { get => _sTDLETotalClosingCostJ; set => SetField(ref _sTDLETotalClosingCostJ, value); }

        /// <summary>
        /// STD Seller Credits Did Change Col [CD3.X116]
        /// </summary>
        public string STDSellerCreditsDidChangeCol { get => _sTDSellerCreditsDidChangeCol; set => SetField(ref _sTDSellerCreditsDidChangeCol, value); }

        /// <summary>
        /// STD Seller Credits IncDec Remark [CD3.X128]
        /// </summary>
        public StringEnumValue<IncreasedOrDecreased> STDSellerCreditsIncDecRemark { get => _sTDSellerCreditsIncDecRemark; set => SetField(ref _sTDSellerCreditsIncDecRemark, value); }

        /// <summary>
        /// STD Total Closing Cost Before CLosing Did Change Col [CD3.X112]
        /// </summary>
        public string STDTotalClosingCostBeforeClosingDidChangeCol { get => _sTDTotalClosingCostBeforeClosingDidChangeCol; set => SetField(ref _sTDTotalClosingCostBeforeClosingDidChangeCol, value); }

        /// <summary>
        /// STD Total Closing Cost Did Change Col [CD3.X111]
        /// </summary>
        public string STDTotalClosingCostDidChangeCol { get => _sTDTotalClosingCostDidChangeCol; set => SetField(ref _sTDTotalClosingCostDidChangeCol, value); }

        /// <summary>
        /// STD Total Closing Cost Remark [CD3.X123]
        /// </summary>
        public StringEnumValue<TotalClosingCostRemark> STDTotalClosingCostRemark { get => _sTDTotalClosingCostRemark; set => SetField(ref _sTDTotalClosingCostRemark, value); }

        /// <summary>
        /// Total Adjustments And Other Credits [CD3.X1506]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalAdjustmentsAndOtherCredits { get => _totalAdjustmentsAndOtherCredits; set => SetField(ref _totalAdjustmentsAndOtherCredits, value); }

        /// <summary>
        /// Total Due from Borrower At Closing [CD3.X21]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalDuefromBorrowerAtClosing { get => _totalDuefromBorrowerAtClosing; set => SetField(ref _totalDuefromBorrowerAtClosing, value); }

        /// <summary>
        /// Total Due from Seller at Closing N  [CD3.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalDuefromSelleratClosingN { get => _totalDuefromSelleratClosingN; set => SetField(ref _totalDuefromSelleratClosingN, value); }

        /// <summary>
        /// Total Due to Seller at Closing M [CD3.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalDuetoSelleratClosingM { get => _totalDuetoSelleratClosingM; set => SetField(ref _totalDuetoSelleratClosingM, value); }

        /// <summary>
        /// Total From K [CD3.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalFromK { get => _totalFromK; set => SetField(ref _totalFromK, value); }

        /// <summary>
        /// Total From L  [CD3.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalFromL { get => _totalFromL; set => SetField(ref _totalFromL, value); }

        /// <summary>
        /// Total From M [CD3.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalFromM { get => _totalFromM; set => SetField(ref _totalFromM, value); }

        /// <summary>
        /// Total From N [CD3.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalFromN { get => _totalFromN; set => SetField(ref _totalFromN, value); }

        /// <summary>
        /// Total Paid Already by or on Behalf of Borower at Closing  [CD3.X22]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get => _totalPaidAlreadybyoronBehalfofBoroweratClosing; set => SetField(ref _totalPaidAlreadybyoronBehalfofBoroweratClosing, value); }

        /// <summary>
        /// ClosingDisclosure3 UCDDetails
        /// </summary>
        public IList<UCDDetail> UCDDetails { get => GetField(ref _uCDDetails); set => SetField(ref _uCDDetails, value); }

        /// <summary>
        /// UCD K Line Subtotal [CD3.X1502]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UCDKSubTotal { get => _uCDKSubTotal; set => SetField(ref _uCDKSubTotal, value); }

        /// <summary>
        /// UCD K Line Subtotal [CD3.X1503]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UCDLSubTotal { get => _uCDLSubTotal; set => SetField(ref _uCDLSubTotal, value); }

        /// <summary>
        /// UCD Total Adjustments And Other Credits [CD3.X1504]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? UCDTotalAdjustmentsAndOtherCredits { get => _uCDTotalAdjustmentsAndOtherCredits; set => SetField(ref _uCDTotalAdjustmentsAndOtherCredits, value); }
    }
}