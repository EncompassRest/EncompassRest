using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure3 : IClean
    {
        private Value<decimal?> _actualLECD3TotalClosingCostJFromLatestRec;
        public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get { return _actualLECD3TotalClosingCostJFromLatestRec; } set { _actualLECD3TotalClosingCostJFromLatestRec = value; } }
        private Value<decimal?> _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec;
        public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get { return _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; } set { _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = value; } }
        private Value<decimal?> _actualLELoanAmountFromLatestRec;
        public decimal? ActualLELoanAmountFromLatestRec { get { return _actualLELoanAmountFromLatestRec; } set { _actualLELoanAmountFromLatestRec = value; } }
        private Value<decimal?> _actualLenderCredits;
        public decimal? ActualLenderCredits { get { return _actualLenderCredits; } set { _actualLenderCredits = value; } }
        private Value<decimal?> _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec;
        public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get { return _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; } set { _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLEClosingCostFinancedFromLatestRec;
        public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get { return _actualSTDLEClosingCostFinancedFromLatestRec; } set { _actualSTDLEClosingCostFinancedFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLEDepositFromLatestRec;
        public decimal? ActualSTDLEDepositFromLatestRec { get { return _actualSTDLEDepositFromLatestRec; } set { _actualSTDLEDepositFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLEDownPaymentFromLatestRec;
        public decimal? ActualSTDLEDownPaymentFromLatestRec { get { return _actualSTDLEDownPaymentFromLatestRec; } set { _actualSTDLEDownPaymentFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLEFundForBorrowerFromLatestRec;
        public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get { return _actualSTDLEFundForBorrowerFromLatestRec; } set { _actualSTDLEFundForBorrowerFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLESellerCredits;
        public decimal? ActualSTDLESellerCredits { get { return _actualSTDLESellerCredits; } set { _actualSTDLESellerCredits = value; } }
        private Value<decimal?> _actualSTDLESellerCreditsFromLatestRec;
        public decimal? ActualSTDLESellerCreditsFromLatestRec { get { return _actualSTDLESellerCreditsFromLatestRec; } set { _actualSTDLESellerCreditsFromLatestRec = value; } }
        private Value<decimal?> _actualSTDLETotalClosingCostJ;
        public decimal? ActualSTDLETotalClosingCostJ { get { return _actualSTDLETotalClosingCostJ; } set { _actualSTDLETotalClosingCostJ = value; } }
        private Value<decimal?> _actualSTDLETotalClosingCostJFromLatestRec;
        public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get { return _actualSTDLETotalClosingCostJFromLatestRec; } set { _actualSTDLETotalClosingCostJFromLatestRec = value; } }
        private Value<string> _adjustments06_1;
        public string Adjustments06_1 { get { return _adjustments06_1; } set { _adjustments06_1 = value; } }
        private Value<decimal?> _adjustments06_2;
        public decimal? Adjustments06_2 { get { return _adjustments06_2; } set { _adjustments06_2 = value; } }
        private Value<string> _adjustments07_1;
        public string Adjustments07_1 { get { return _adjustments07_1; } set { _adjustments07_1 = value; } }
        private Value<decimal?> _adjustments07_2;
        public decimal? Adjustments07_2 { get { return _adjustments07_2; } set { _adjustments07_2 = value; } }
        private Value<string> _adjustments10_1;
        public string Adjustments10_1 { get { return _adjustments10_1; } set { _adjustments10_1 = value; } }
        private Value<decimal?> _adjustments10_2;
        public decimal? Adjustments10_2 { get { return _adjustments10_2; } set { _adjustments10_2 = value; } }
        private Value<string> _adjustments11_1;
        public string Adjustments11_1 { get { return _adjustments11_1; } set { _adjustments11_1 = value; } }
        private Value<decimal?> _adjustments11_2;
        public decimal? Adjustments11_2 { get { return _adjustments11_2; } set { _adjustments11_2 = value; } }
        private Value<string> _adjustments15_1;
        public string Adjustments15_1 { get { return _adjustments15_1; } set { _adjustments15_1 = value; } }
        private Value<decimal?> _adjustments15_2;
        public decimal? Adjustments15_2 { get { return _adjustments15_2; } set { _adjustments15_2 = value; } }
        private Value<string> _adjustments8_1;
        public string Adjustments8_1 { get { return _adjustments8_1; } set { _adjustments8_1 = value; } }
        private Value<decimal?> _adjustments8_2;
        public decimal? Adjustments8_2 { get { return _adjustments8_2; } set { _adjustments8_2 = value; } }
        private Value<string> _adjustments9_1;
        public string Adjustments9_1 { get { return _adjustments9_1; } set { _adjustments9_1 = value; } }
        private Value<decimal?> _adjustments9_2;
        public decimal? Adjustments9_2 { get { return _adjustments9_2; } set { _adjustments9_2 = value; } }
        private Value<string> _adjustmentsforItemsPaidbySellerinAdvance16_1;
        public string AdjustmentsforItemsPaidbySellerinAdvance16_1 { get { return _adjustmentsforItemsPaidbySellerinAdvance16_1; } set { _adjustmentsforItemsPaidbySellerinAdvance16_1 = value; } }
        private Value<decimal?> _adjustmentsforItemsPaidbySellerinAdvance16_2;
        public decimal? AdjustmentsforItemsPaidbySellerinAdvance16_2 { get { return _adjustmentsforItemsPaidbySellerinAdvance16_2; } set { _adjustmentsforItemsPaidbySellerinAdvance16_2 = value; } }
        private Value<string> _aLTCashToCloseDidChangeCol;
        public string ALTCashToCloseDidChangeCol { get { return _aLTCashToCloseDidChangeCol; } set { _aLTCashToCloseDidChangeCol = value; } }
        private Value<decimal?> _aLTCashToCloseRemark;
        public decimal? ALTCashToCloseRemark { get { return _aLTCashToCloseRemark; } set { _aLTCashToCloseRemark = value; } }
        private Value<string> _aLTClosingCostBeforeClosingDidChangeCol;
        public string ALTClosingCostBeforeClosingDidChangeCol { get { return _aLTClosingCostBeforeClosingDidChangeCol; } set { _aLTClosingCostBeforeClosingDidChangeCol = value; } }
        private Value<decimal?> _aLTLegalLimit;
        public decimal? ALTLegalLimit { get { return _aLTLegalLimit; } set { _aLTLegalLimit = value; } }
        private Value<string> _aLTLoanAmountDidChangeCol;
        public string ALTLoanAmountDidChangeCol { get { return _aLTLoanAmountDidChangeCol; } set { _aLTLoanAmountDidChangeCol = value; } }
        private Value<string> _aLTLoanAmountIncDecRemark;
        public string ALTLoanAmountIncDecRemark { get { return _aLTLoanAmountIncDecRemark; } set { _aLTLoanAmountIncDecRemark = value; } }
        private Value<string> _aLTTotalClosingCostDidChangeCol;
        public string ALTTotalClosingCostDidChangeCol { get { return _aLTTotalClosingCostDidChangeCol; } set { _aLTTotalClosingCostDidChangeCol = value; } }
        private Value<string> _aLTTotalClosingCostRemark;
        public string ALTTotalClosingCostRemark { get { return _aLTTotalClosingCostRemark; } set { _aLTTotalClosingCostRemark = value; } }
        private Value<string> _aLTTotalPayoffsDidChangeCol;
        public string ALTTotalPayoffsDidChangeCol { get { return _aLTTotalPayoffsDidChangeCol; } set { _aLTTotalPayoffsDidChangeCol = value; } }
        private Value<decimal?> _cash;
        public decimal? Cash { get { return _cash; } set { _cash = value; } }
        private Value<decimal?> _cashToClose;
        public decimal? CashToClose { get { return _cashToClose; } set { _cashToClose = value; } }
        private Value<decimal?> _cD3CashToClose;
        public decimal? CD3CashToClose { get { return _cD3CashToClose; } set { _cD3CashToClose = value; } }
        private Value<string> _cD3CashToCloseFromToBorrower;
        public string CD3CashToCloseFromToBorrower { get { return _cD3CashToCloseFromToBorrower; } set { _cD3CashToCloseFromToBorrower = value; } }
        private Value<decimal?> _cD3ClosingCostsPaidBeforeClosing;
        public decimal? CD3ClosingCostsPaidBeforeClosing { get { return _cD3ClosingCostsPaidBeforeClosing; } set { _cD3ClosingCostsPaidBeforeClosing = value; } }
        private Value<decimal?> _cD3TotalClosingCost_J;
        public decimal? CD3TotalClosingCost_J { get { return _cD3TotalClosingCost_J; } set { _cD3TotalClosingCost_J = value; } }
        private Value<decimal?> _cD3TotalPayoffsAndPayments_K;
        public decimal? CD3TotalPayoffsAndPayments_K { get { return _cD3TotalPayoffsAndPayments_K; } set { _cD3TotalPayoffsAndPayments_K = value; } }
        private Value<decimal?> _closingCostsPaidAtClosing;
        public decimal? ClosingCostsPaidAtClosing { get { return _closingCostsPaidAtClosing; } set { _closingCostsPaidAtClosing = value; } }
        private Value<decimal?> _closingCostsPaidatClosing_J;
        public decimal? ClosingCostsPaidatClosing_J { get { return _closingCostsPaidatClosing_J; } set { _closingCostsPaidatClosing_J = value; } }
        private Value<string> _duefromSelleratClosing11_1;
        public string DuefromSelleratClosing11_1 { get { return _duefromSelleratClosing11_1; } set { _duefromSelleratClosing11_1 = value; } }
        private Value<decimal?> _duefromSelleratClosing11_2;
        public decimal? DuefromSelleratClosing11_2 { get { return _duefromSelleratClosing11_2; } set { _duefromSelleratClosing11_2 = value; } }
        private Value<string> _duefromSelleratClosing12_1;
        public string DuefromSelleratClosing12_1 { get { return _duefromSelleratClosing12_1; } set { _duefromSelleratClosing12_1 = value; } }
        private Value<decimal?> _duefromSelleratClosing12_2;
        public decimal? DuefromSelleratClosing12_2 { get { return _duefromSelleratClosing12_2; } set { _duefromSelleratClosing12_2 = value; } }
        private Value<string> _duefromSelleratClosing13_1;
        public string DuefromSelleratClosing13_1 { get { return _duefromSelleratClosing13_1; } set { _duefromSelleratClosing13_1 = value; } }
        private Value<decimal?> _duefromSelleratClosing13_2;
        public decimal? DuefromSelleratClosing13_2 { get { return _duefromSelleratClosing13_2; } set { _duefromSelleratClosing13_2 = value; } }
        private Value<string> _dueToSellerAtClosing6_1;
        public string DueToSellerAtClosing6_1 { get { return _dueToSellerAtClosing6_1; } set { _dueToSellerAtClosing6_1 = value; } }
        private Value<decimal?> _dueToSellerAtClosing6_2;
        public decimal? DueToSellerAtClosing6_2 { get { return _dueToSellerAtClosing6_2; } set { _dueToSellerAtClosing6_2 = value; } }
        private Value<string> _dueToSellerAtClosing7_1;
        public string DueToSellerAtClosing7_1 { get { return _dueToSellerAtClosing7_1; } set { _dueToSellerAtClosing7_1 = value; } }
        private Value<decimal?> _dueToSellerAtClosing7_2;
        public decimal? DueToSellerAtClosing7_2 { get { return _dueToSellerAtClosing7_2; } set { _dueToSellerAtClosing7_2 = value; } }
        private Value<string> _dueToSellerAtClosing8_1;
        public string DueToSellerAtClosing8_1 { get { return _dueToSellerAtClosing8_1; } set { _dueToSellerAtClosing8_1 = value; } }
        private Value<decimal?> _dueToSellerAtClosing8_2;
        public decimal? DueToSellerAtClosing8_2 { get { return _dueToSellerAtClosing8_2; } set { _dueToSellerAtClosing8_2 = value; } }
        private Value<bool?> _excludeBorrowerClosingCosts;
        public bool? ExcludeBorrowerClosingCosts { get { return _excludeBorrowerClosingCosts; } set { _excludeBorrowerClosingCosts = value; } }
        private Value<decimal?> _finalCashToClose;
        public decimal? FinalCashToClose { get { return _finalCashToClose; } set { _finalCashToClose = value; } }
        private Value<string> _fromToBorrower;
        public string FromToBorrower { get { return _fromToBorrower; } set { _fromToBorrower = value; } }
        private Value<string> _fromToSeller;
        public string FromToSeller { get { return _fromToSeller; } set { _fromToSeller = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _lECD3CashToClose;
        public decimal? LECD3CashToClose { get { return _lECD3CashToClose; } set { _lECD3CashToClose = value; } }
        private Value<string> _lECD3CashToCloseFromToBorrower;
        public string LECD3CashToCloseFromToBorrower { get { return _lECD3CashToCloseFromToBorrower; } set { _lECD3CashToCloseFromToBorrower = value; } }
        private Value<decimal?> _lECD3ClosingCostsPaidBeforeClosing;
        public decimal? LECD3ClosingCostsPaidBeforeClosing { get { return _lECD3ClosingCostsPaidBeforeClosing; } set { _lECD3ClosingCostsPaidBeforeClosing = value; } }
        private Value<decimal?> _lECD3TotalClosingCost_J;
        public decimal? LECD3TotalClosingCost_J { get { return _lECD3TotalClosingCost_J; } set { _lECD3TotalClosingCost_J = value; } }
        private Value<decimal?> _lECD3TotalPayoffsAndPayments_K;
        public decimal? LECD3TotalPayoffsAndPayments_K { get { return _lECD3TotalPayoffsAndPayments_K; } set { _lECD3TotalPayoffsAndPayments_K = value; } }
        private Value<decimal?> _lELoanAmount;
        public decimal? LELoanAmount { get { return _lELoanAmount; } set { _lELoanAmount = value; } }
        private Value<decimal?> _liabilityAmount1;
        public decimal? LiabilityAmount1 { get { return _liabilityAmount1; } set { _liabilityAmount1 = value; } }
        private Value<decimal?> _liabilityAmount10;
        public decimal? LiabilityAmount10 { get { return _liabilityAmount10; } set { _liabilityAmount10 = value; } }
        private Value<decimal?> _liabilityAmount11;
        public decimal? LiabilityAmount11 { get { return _liabilityAmount11; } set { _liabilityAmount11 = value; } }
        private Value<decimal?> _liabilityAmount12;
        public decimal? LiabilityAmount12 { get { return _liabilityAmount12; } set { _liabilityAmount12 = value; } }
        private Value<decimal?> _liabilityAmount13;
        public decimal? LiabilityAmount13 { get { return _liabilityAmount13; } set { _liabilityAmount13 = value; } }
        private Value<decimal?> _liabilityAmount14;
        public decimal? LiabilityAmount14 { get { return _liabilityAmount14; } set { _liabilityAmount14 = value; } }
        private Value<decimal?> _liabilityAmount15;
        public decimal? LiabilityAmount15 { get { return _liabilityAmount15; } set { _liabilityAmount15 = value; } }
        private Value<decimal?> _liabilityAmount2;
        public decimal? LiabilityAmount2 { get { return _liabilityAmount2; } set { _liabilityAmount2 = value; } }
        private Value<decimal?> _liabilityAmount3;
        public decimal? LiabilityAmount3 { get { return _liabilityAmount3; } set { _liabilityAmount3 = value; } }
        private Value<decimal?> _liabilityAmount4;
        public decimal? LiabilityAmount4 { get { return _liabilityAmount4; } set { _liabilityAmount4 = value; } }
        private Value<decimal?> _liabilityAmount5;
        public decimal? LiabilityAmount5 { get { return _liabilityAmount5; } set { _liabilityAmount5 = value; } }
        private Value<decimal?> _liabilityAmount6;
        public decimal? LiabilityAmount6 { get { return _liabilityAmount6; } set { _liabilityAmount6 = value; } }
        private Value<decimal?> _liabilityAmount7;
        public decimal? LiabilityAmount7 { get { return _liabilityAmount7; } set { _liabilityAmount7 = value; } }
        private Value<decimal?> _liabilityAmount8;
        public decimal? LiabilityAmount8 { get { return _liabilityAmount8; } set { _liabilityAmount8 = value; } }
        private Value<decimal?> _liabilityAmount9;
        public decimal? LiabilityAmount9 { get { return _liabilityAmount9; } set { _liabilityAmount9 = value; } }
        private Value<string> _liabilityTo1;
        public string LiabilityTo1 { get { return _liabilityTo1; } set { _liabilityTo1 = value; } }
        private Value<string> _liabilityTo10;
        public string LiabilityTo10 { get { return _liabilityTo10; } set { _liabilityTo10 = value; } }
        private Value<string> _liabilityTo11;
        public string LiabilityTo11 { get { return _liabilityTo11; } set { _liabilityTo11 = value; } }
        private Value<string> _liabilityTo12;
        public string LiabilityTo12 { get { return _liabilityTo12; } set { _liabilityTo12 = value; } }
        private Value<string> _liabilityTo13;
        public string LiabilityTo13 { get { return _liabilityTo13; } set { _liabilityTo13 = value; } }
        private Value<string> _liabilityTo14;
        public string LiabilityTo14 { get { return _liabilityTo14; } set { _liabilityTo14 = value; } }
        private Value<string> _liabilityTo15;
        public string LiabilityTo15 { get { return _liabilityTo15; } set { _liabilityTo15 = value; } }
        private Value<string> _liabilityTo2;
        public string LiabilityTo2 { get { return _liabilityTo2; } set { _liabilityTo2 = value; } }
        private Value<string> _liabilityTo3;
        public string LiabilityTo3 { get { return _liabilityTo3; } set { _liabilityTo3 = value; } }
        private Value<string> _liabilityTo4;
        public string LiabilityTo4 { get { return _liabilityTo4; } set { _liabilityTo4 = value; } }
        private Value<string> _liabilityTo5;
        public string LiabilityTo5 { get { return _liabilityTo5; } set { _liabilityTo5 = value; } }
        private Value<string> _liabilityTo6;
        public string LiabilityTo6 { get { return _liabilityTo6; } set { _liabilityTo6 = value; } }
        private Value<string> _liabilityTo7;
        public string LiabilityTo7 { get { return _liabilityTo7; } set { _liabilityTo7 = value; } }
        private Value<string> _liabilityTo8;
        public string LiabilityTo8 { get { return _liabilityTo8; } set { _liabilityTo8 = value; } }
        private Value<string> _liabilityTo9;
        public string LiabilityTo9 { get { return _liabilityTo9; } set { _liabilityTo9 = value; } }
        private Value<decimal?> _liabilityTotal;
        public decimal? LiabilityTotal { get { return _liabilityTotal; } set { _liabilityTotal = value; } }
        private Value<decimal?> _loanAmount;
        public decimal? LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<decimal?> _nonUCDTotalAdjustmentsAndOtherCredits;
        public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get { return _nonUCDTotalAdjustmentsAndOtherCredits; } set { _nonUCDTotalAdjustmentsAndOtherCredits = value; } }
        private Value<bool?> _omitFromPrintSellersTransaction;
        public bool? OmitFromPrintSellersTransaction { get { return _omitFromPrintSellersTransaction; } set { _omitFromPrintSellersTransaction = value; } }
        private Value<string> _otherCredits6_1;
        public string OtherCredits6_1 { get { return _otherCredits6_1; } set { _otherCredits6_1 = value; } }
        private Value<decimal?> _otherCredits6_2;
        public decimal? OtherCredits6_2 { get { return _otherCredits6_2; } set { _otherCredits6_2 = value; } }
        private Value<string> _otherCredits7_1;
        public string OtherCredits7_1 { get { return _otherCredits7_1; } set { _otherCredits7_1 = value; } }
        private Value<decimal?> _otherCredits7_2;
        public decimal? OtherCredits7_2 { get { return _otherCredits7_2; } set { _otherCredits7_2 = value; } }
        private Value<decimal?> _priorToleranceCureAmount;
        public decimal? PriorToleranceCureAmount { get { return _priorToleranceCureAmount; } set { _priorToleranceCureAmount = value; } }
        private Value<string> _sTDAdjustmentAndOtherCreditsRemark;
        public string STDAdjustmentAndOtherCreditsRemark { get { return _sTDAdjustmentAndOtherCreditsRemark; } set { _sTDAdjustmentAndOtherCreditsRemark = value; } }
        private Value<string> _sTDAdjustmentsDidChangeCol;
        public string STDAdjustmentsDidChangeCol { get { return _sTDAdjustmentsDidChangeCol; } set { _sTDAdjustmentsDidChangeCol = value; } }
        private Value<string> _sTDClosingCostFinancedDidChangeCol;
        public string STDClosingCostFinancedDidChangeCol { get { return _sTDClosingCostFinancedDidChangeCol; } set { _sTDClosingCostFinancedDidChangeCol = value; } }
        private Value<string> _sTDDepositDidChangeCol;
        public string STDDepositDidChangeCol { get { return _sTDDepositDidChangeCol; } set { _sTDDepositDidChangeCol = value; } }
        private Value<string> _sTDDepositIncDecRemark;
        public string STDDepositIncDecRemark { get { return _sTDDepositIncDecRemark; } set { _sTDDepositIncDecRemark = value; } }
        private Value<string> _sTDDownPaymentDidChangeCol;
        public string STDDownPaymentDidChangeCol { get { return _sTDDownPaymentDidChangeCol; } set { _sTDDownPaymentDidChangeCol = value; } }
        private Value<string> _sTDDownPaymentIncDecRemark;
        public string STDDownPaymentIncDecRemark { get { return _sTDDownPaymentIncDecRemark; } set { _sTDDownPaymentIncDecRemark = value; } }
        private Value<string> _sTDDownPaymentSectionRemark;
        public string STDDownPaymentSectionRemark { get { return _sTDDownPaymentSectionRemark; } set { _sTDDownPaymentSectionRemark = value; } }
        private Value<decimal?> _sTDFinalAdjustmentAndOtherCredits;
        public decimal? STDFinalAdjustmentAndOtherCredits { get { return _sTDFinalAdjustmentAndOtherCredits; } set { _sTDFinalAdjustmentAndOtherCredits = value; } }
        private Value<decimal?> _sTDFinalCashToClose;
        public decimal? STDFinalCashToClose { get { return _sTDFinalCashToClose; } set { _sTDFinalCashToClose = value; } }
        private Value<decimal?> _sTDFinalCD3ClosingCostsPaidBeforeClosing;
        public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get { return _sTDFinalCD3ClosingCostsPaidBeforeClosing; } set { _sTDFinalCD3ClosingCostsPaidBeforeClosing = value; } }
        private Value<decimal?> _sTDFinalClosingCostFinanced;
        public decimal? STDFinalClosingCostFinanced { get { return _sTDFinalClosingCostFinanced; } set { _sTDFinalClosingCostFinanced = value; } }
        private Value<decimal?> _sTDFinalDeposit;
        public decimal? STDFinalDeposit { get { return _sTDFinalDeposit; } set { _sTDFinalDeposit = value; } }
        private Value<decimal?> _sTDFinalDownPayment;
        public decimal? STDFinalDownPayment { get { return _sTDFinalDownPayment; } set { _sTDFinalDownPayment = value; } }
        private Value<decimal?> _sTDFinalFundForBorrower;
        public decimal? STDFinalFundForBorrower { get { return _sTDFinalFundForBorrower; } set { _sTDFinalFundForBorrower = value; } }
        private Value<decimal?> _sTDFinalSellerCredits;
        public decimal? STDFinalSellerCredits { get { return _sTDFinalSellerCredits; } set { _sTDFinalSellerCredits = value; } }
        private Value<decimal?> _sTDFinalTotalClosingCostJ;
        public decimal? STDFinalTotalClosingCostJ { get { return _sTDFinalTotalClosingCostJ; } set { _sTDFinalTotalClosingCostJ = value; } }
        private Value<string> _sTDFundsForBorrowerDidChangeCol;
        public string STDFundsForBorrowerDidChangeCol { get { return _sTDFundsForBorrowerDidChangeCol; } set { _sTDFundsForBorrowerDidChangeCol = value; } }
        private Value<string> _sTDFundsForBorrowerIncDecRemark;
        public string STDFundsForBorrowerIncDecRemark { get { return _sTDFundsForBorrowerIncDecRemark; } set { _sTDFundsForBorrowerIncDecRemark = value; } }
        private Value<decimal?> _sTDLEAdjustmentAndOtherCredits;
        public decimal? STDLEAdjustmentAndOtherCredits { get { return _sTDLEAdjustmentAndOtherCredits; } set { _sTDLEAdjustmentAndOtherCredits = value; } }
        private Value<decimal?> _sTDLECashToClose;
        public decimal? STDLECashToClose { get { return _sTDLECashToClose; } set { _sTDLECashToClose = value; } }
        private Value<decimal?> _sTDLECD3ClosingCostsPaidBeforeClosing;
        public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get { return _sTDLECD3ClosingCostsPaidBeforeClosing; } set { _sTDLECD3ClosingCostsPaidBeforeClosing = value; } }
        private Value<decimal?> _sTDLEClosingCostFinanced;
        public decimal? STDLEClosingCostFinanced { get { return _sTDLEClosingCostFinanced; } set { _sTDLEClosingCostFinanced = value; } }
        private Value<decimal?> _sTDLEDeposit;
        public decimal? STDLEDeposit { get { return _sTDLEDeposit; } set { _sTDLEDeposit = value; } }
        private Value<decimal?> _sTDLEDownPayment;
        public decimal? STDLEDownPayment { get { return _sTDLEDownPayment; } set { _sTDLEDownPayment = value; } }
        private Value<decimal?> _sTDLEFundForBorrower;
        public decimal? STDLEFundForBorrower { get { return _sTDLEFundForBorrower; } set { _sTDLEFundForBorrower = value; } }
        private Value<decimal?> _sTDLegalLimit;
        public decimal? STDLegalLimit { get { return _sTDLegalLimit; } set { _sTDLegalLimit = value; } }
        private Value<decimal?> _sTDLESellerCredits;
        public decimal? STDLESellerCredits { get { return _sTDLESellerCredits; } set { _sTDLESellerCredits = value; } }
        private Value<decimal?> _sTDLETotalClosingCostJ;
        public decimal? STDLETotalClosingCostJ { get { return _sTDLETotalClosingCostJ; } set { _sTDLETotalClosingCostJ = value; } }
        private Value<string> _sTDSellerCreditsDidChangeCol;
        public string STDSellerCreditsDidChangeCol { get { return _sTDSellerCreditsDidChangeCol; } set { _sTDSellerCreditsDidChangeCol = value; } }
        private Value<string> _sTDSellerCreditsIncDecRemark;
        public string STDSellerCreditsIncDecRemark { get { return _sTDSellerCreditsIncDecRemark; } set { _sTDSellerCreditsIncDecRemark = value; } }
        private Value<string> _sTDTotalClosingCostBeforeClosingDidChangeCol;
        public string STDTotalClosingCostBeforeClosingDidChangeCol { get { return _sTDTotalClosingCostBeforeClosingDidChangeCol; } set { _sTDTotalClosingCostBeforeClosingDidChangeCol = value; } }
        private Value<string> _sTDTotalClosingCostDidChangeCol;
        public string STDTotalClosingCostDidChangeCol { get { return _sTDTotalClosingCostDidChangeCol; } set { _sTDTotalClosingCostDidChangeCol = value; } }
        private Value<string> _sTDTotalClosingCostRemark;
        public string STDTotalClosingCostRemark { get { return _sTDTotalClosingCostRemark; } set { _sTDTotalClosingCostRemark = value; } }
        private Value<decimal?> _totalAdjustmentsAndOtherCredits;
        public decimal? TotalAdjustmentsAndOtherCredits { get { return _totalAdjustmentsAndOtherCredits; } set { _totalAdjustmentsAndOtherCredits = value; } }
        private Value<decimal?> _totalDuefromBorrowerAtClosing;
        public decimal? TotalDuefromBorrowerAtClosing { get { return _totalDuefromBorrowerAtClosing; } set { _totalDuefromBorrowerAtClosing = value; } }
        private Value<decimal?> _totalDuefromSelleratClosing_N;
        public decimal? TotalDuefromSelleratClosing_N { get { return _totalDuefromSelleratClosing_N; } set { _totalDuefromSelleratClosing_N = value; } }
        private Value<decimal?> _totalDuetoSelleratClosing_M;
        public decimal? TotalDuetoSelleratClosing_M { get { return _totalDuetoSelleratClosing_M; } set { _totalDuetoSelleratClosing_M = value; } }
        private Value<decimal?> _totalFromK;
        public decimal? TotalFromK { get { return _totalFromK; } set { _totalFromK = value; } }
        private Value<decimal?> _totalFromL;
        public decimal? TotalFromL { get { return _totalFromL; } set { _totalFromL = value; } }
        private Value<decimal?> _totalFromM;
        public decimal? TotalFromM { get { return _totalFromM; } set { _totalFromM = value; } }
        private Value<decimal?> _totalFromN;
        public decimal? TotalFromN { get { return _totalFromN; } set { _totalFromN = value; } }
        private Value<decimal?> _totalPaidAlreadybyoronBehalfofBoroweratClosing;
        public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get { return _totalPaidAlreadybyoronBehalfofBoroweratClosing; } set { _totalPaidAlreadybyoronBehalfofBoroweratClosing = value; } }
        private Value<List<UCDDetail>> _uCDDetails;
        public List<UCDDetail> UCDDetails { get { return _uCDDetails; } set { _uCDDetails = value; } }
        private Value<decimal?> _uCDKSubTotal;
        public decimal? UCDKSubTotal { get { return _uCDKSubTotal; } set { _uCDKSubTotal = value; } }
        private Value<decimal?> _uCDLSubTotal;
        public decimal? UCDLSubTotal { get { return _uCDLSubTotal; } set { _uCDLSubTotal = value; } }
        private Value<decimal?> _uCDTotalAdjustmentsAndOtherCredits;
        public decimal? UCDTotalAdjustmentsAndOtherCredits { get { return _uCDTotalAdjustmentsAndOtherCredits; } set { _uCDTotalAdjustmentsAndOtherCredits = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actualLECD3TotalClosingCostJFromLatestRec.Clean
                    && _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Clean
                    && _actualLELoanAmountFromLatestRec.Clean
                    && _actualLenderCredits.Clean
                    && _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Clean
                    && _actualSTDLEClosingCostFinancedFromLatestRec.Clean
                    && _actualSTDLEDepositFromLatestRec.Clean
                    && _actualSTDLEDownPaymentFromLatestRec.Clean
                    && _actualSTDLEFundForBorrowerFromLatestRec.Clean
                    && _actualSTDLESellerCredits.Clean
                    && _actualSTDLESellerCreditsFromLatestRec.Clean
                    && _actualSTDLETotalClosingCostJ.Clean
                    && _actualSTDLETotalClosingCostJFromLatestRec.Clean
                    && _adjustments06_1.Clean
                    && _adjustments06_2.Clean
                    && _adjustments07_1.Clean
                    && _adjustments07_2.Clean
                    && _adjustments10_1.Clean
                    && _adjustments10_2.Clean
                    && _adjustments11_1.Clean
                    && _adjustments11_2.Clean
                    && _adjustments15_1.Clean
                    && _adjustments15_2.Clean
                    && _adjustments8_1.Clean
                    && _adjustments8_2.Clean
                    && _adjustments9_1.Clean
                    && _adjustments9_2.Clean
                    && _adjustmentsforItemsPaidbySellerinAdvance16_1.Clean
                    && _adjustmentsforItemsPaidbySellerinAdvance16_2.Clean
                    && _aLTCashToCloseDidChangeCol.Clean
                    && _aLTCashToCloseRemark.Clean
                    && _aLTClosingCostBeforeClosingDidChangeCol.Clean
                    && _aLTLegalLimit.Clean
                    && _aLTLoanAmountDidChangeCol.Clean
                    && _aLTLoanAmountIncDecRemark.Clean
                    && _aLTTotalClosingCostDidChangeCol.Clean
                    && _aLTTotalClosingCostRemark.Clean
                    && _aLTTotalPayoffsDidChangeCol.Clean
                    && _cash.Clean
                    && _cashToClose.Clean
                    && _cD3CashToClose.Clean
                    && _cD3CashToCloseFromToBorrower.Clean
                    && _cD3ClosingCostsPaidBeforeClosing.Clean
                    && _cD3TotalClosingCost_J.Clean
                    && _cD3TotalPayoffsAndPayments_K.Clean
                    && _closingCostsPaidAtClosing.Clean
                    && _closingCostsPaidatClosing_J.Clean
                    && _duefromSelleratClosing11_1.Clean
                    && _duefromSelleratClosing11_2.Clean
                    && _duefromSelleratClosing12_1.Clean
                    && _duefromSelleratClosing12_2.Clean
                    && _duefromSelleratClosing13_1.Clean
                    && _duefromSelleratClosing13_2.Clean
                    && _dueToSellerAtClosing6_1.Clean
                    && _dueToSellerAtClosing6_2.Clean
                    && _dueToSellerAtClosing7_1.Clean
                    && _dueToSellerAtClosing7_2.Clean
                    && _dueToSellerAtClosing8_1.Clean
                    && _dueToSellerAtClosing8_2.Clean
                    && _excludeBorrowerClosingCosts.Clean
                    && _finalCashToClose.Clean
                    && _fromToBorrower.Clean
                    && _fromToSeller.Clean
                    && _id.Clean
                    && _lECD3CashToClose.Clean
                    && _lECD3CashToCloseFromToBorrower.Clean
                    && _lECD3ClosingCostsPaidBeforeClosing.Clean
                    && _lECD3TotalClosingCost_J.Clean
                    && _lECD3TotalPayoffsAndPayments_K.Clean
                    && _lELoanAmount.Clean
                    && _liabilityAmount1.Clean
                    && _liabilityAmount10.Clean
                    && _liabilityAmount11.Clean
                    && _liabilityAmount12.Clean
                    && _liabilityAmount13.Clean
                    && _liabilityAmount14.Clean
                    && _liabilityAmount15.Clean
                    && _liabilityAmount2.Clean
                    && _liabilityAmount3.Clean
                    && _liabilityAmount4.Clean
                    && _liabilityAmount5.Clean
                    && _liabilityAmount6.Clean
                    && _liabilityAmount7.Clean
                    && _liabilityAmount8.Clean
                    && _liabilityAmount9.Clean
                    && _liabilityTo1.Clean
                    && _liabilityTo10.Clean
                    && _liabilityTo11.Clean
                    && _liabilityTo12.Clean
                    && _liabilityTo13.Clean
                    && _liabilityTo14.Clean
                    && _liabilityTo15.Clean
                    && _liabilityTo2.Clean
                    && _liabilityTo3.Clean
                    && _liabilityTo4.Clean
                    && _liabilityTo5.Clean
                    && _liabilityTo6.Clean
                    && _liabilityTo7.Clean
                    && _liabilityTo8.Clean
                    && _liabilityTo9.Clean
                    && _liabilityTotal.Clean
                    && _loanAmount.Clean
                    && _nonUCDTotalAdjustmentsAndOtherCredits.Clean
                    && _omitFromPrintSellersTransaction.Clean
                    && _otherCredits6_1.Clean
                    && _otherCredits6_2.Clean
                    && _otherCredits7_1.Clean
                    && _otherCredits7_2.Clean
                    && _priorToleranceCureAmount.Clean
                    && _sTDAdjustmentAndOtherCreditsRemark.Clean
                    && _sTDAdjustmentsDidChangeCol.Clean
                    && _sTDClosingCostFinancedDidChangeCol.Clean
                    && _sTDDepositDidChangeCol.Clean
                    && _sTDDepositIncDecRemark.Clean
                    && _sTDDownPaymentDidChangeCol.Clean
                    && _sTDDownPaymentIncDecRemark.Clean
                    && _sTDDownPaymentSectionRemark.Clean
                    && _sTDFinalAdjustmentAndOtherCredits.Clean
                    && _sTDFinalCashToClose.Clean
                    && _sTDFinalCD3ClosingCostsPaidBeforeClosing.Clean
                    && _sTDFinalClosingCostFinanced.Clean
                    && _sTDFinalDeposit.Clean
                    && _sTDFinalDownPayment.Clean
                    && _sTDFinalFundForBorrower.Clean
                    && _sTDFinalSellerCredits.Clean
                    && _sTDFinalTotalClosingCostJ.Clean
                    && _sTDFundsForBorrowerDidChangeCol.Clean
                    && _sTDFundsForBorrowerIncDecRemark.Clean
                    && _sTDLEAdjustmentAndOtherCredits.Clean
                    && _sTDLECashToClose.Clean
                    && _sTDLECD3ClosingCostsPaidBeforeClosing.Clean
                    && _sTDLEClosingCostFinanced.Clean
                    && _sTDLEDeposit.Clean
                    && _sTDLEDownPayment.Clean
                    && _sTDLEFundForBorrower.Clean
                    && _sTDLegalLimit.Clean
                    && _sTDLESellerCredits.Clean
                    && _sTDLETotalClosingCostJ.Clean
                    && _sTDSellerCreditsDidChangeCol.Clean
                    && _sTDSellerCreditsIncDecRemark.Clean
                    && _sTDTotalClosingCostBeforeClosingDidChangeCol.Clean
                    && _sTDTotalClosingCostDidChangeCol.Clean
                    && _sTDTotalClosingCostRemark.Clean
                    && _totalAdjustmentsAndOtherCredits.Clean
                    && _totalDuefromBorrowerAtClosing.Clean
                    && _totalDuefromSelleratClosing_N.Clean
                    && _totalDuetoSelleratClosing_M.Clean
                    && _totalFromK.Clean
                    && _totalFromL.Clean
                    && _totalFromM.Clean
                    && _totalFromN.Clean
                    && _totalPaidAlreadybyoronBehalfofBoroweratClosing.Clean
                    && _uCDDetails.Clean
                    && _uCDKSubTotal.Clean
                    && _uCDLSubTotal.Clean
                    && _uCDTotalAdjustmentsAndOtherCredits.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actualLECD3TotalClosingCostJFromLatestRec; v0.Clean = value; _actualLECD3TotalClosingCostJFromLatestRec = v0;
                var v1 = _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; v1.Clean = value; _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = v1;
                var v2 = _actualLELoanAmountFromLatestRec; v2.Clean = value; _actualLELoanAmountFromLatestRec = v2;
                var v3 = _actualLenderCredits; v3.Clean = value; _actualLenderCredits = v3;
                var v4 = _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; v4.Clean = value; _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = v4;
                var v5 = _actualSTDLEClosingCostFinancedFromLatestRec; v5.Clean = value; _actualSTDLEClosingCostFinancedFromLatestRec = v5;
                var v6 = _actualSTDLEDepositFromLatestRec; v6.Clean = value; _actualSTDLEDepositFromLatestRec = v6;
                var v7 = _actualSTDLEDownPaymentFromLatestRec; v7.Clean = value; _actualSTDLEDownPaymentFromLatestRec = v7;
                var v8 = _actualSTDLEFundForBorrowerFromLatestRec; v8.Clean = value; _actualSTDLEFundForBorrowerFromLatestRec = v8;
                var v9 = _actualSTDLESellerCredits; v9.Clean = value; _actualSTDLESellerCredits = v9;
                var v10 = _actualSTDLESellerCreditsFromLatestRec; v10.Clean = value; _actualSTDLESellerCreditsFromLatestRec = v10;
                var v11 = _actualSTDLETotalClosingCostJ; v11.Clean = value; _actualSTDLETotalClosingCostJ = v11;
                var v12 = _actualSTDLETotalClosingCostJFromLatestRec; v12.Clean = value; _actualSTDLETotalClosingCostJFromLatestRec = v12;
                var v13 = _adjustments06_1; v13.Clean = value; _adjustments06_1 = v13;
                var v14 = _adjustments06_2; v14.Clean = value; _adjustments06_2 = v14;
                var v15 = _adjustments07_1; v15.Clean = value; _adjustments07_1 = v15;
                var v16 = _adjustments07_2; v16.Clean = value; _adjustments07_2 = v16;
                var v17 = _adjustments10_1; v17.Clean = value; _adjustments10_1 = v17;
                var v18 = _adjustments10_2; v18.Clean = value; _adjustments10_2 = v18;
                var v19 = _adjustments11_1; v19.Clean = value; _adjustments11_1 = v19;
                var v20 = _adjustments11_2; v20.Clean = value; _adjustments11_2 = v20;
                var v21 = _adjustments15_1; v21.Clean = value; _adjustments15_1 = v21;
                var v22 = _adjustments15_2; v22.Clean = value; _adjustments15_2 = v22;
                var v23 = _adjustments8_1; v23.Clean = value; _adjustments8_1 = v23;
                var v24 = _adjustments8_2; v24.Clean = value; _adjustments8_2 = v24;
                var v25 = _adjustments9_1; v25.Clean = value; _adjustments9_1 = v25;
                var v26 = _adjustments9_2; v26.Clean = value; _adjustments9_2 = v26;
                var v27 = _adjustmentsforItemsPaidbySellerinAdvance16_1; v27.Clean = value; _adjustmentsforItemsPaidbySellerinAdvance16_1 = v27;
                var v28 = _adjustmentsforItemsPaidbySellerinAdvance16_2; v28.Clean = value; _adjustmentsforItemsPaidbySellerinAdvance16_2 = v28;
                var v29 = _aLTCashToCloseDidChangeCol; v29.Clean = value; _aLTCashToCloseDidChangeCol = v29;
                var v30 = _aLTCashToCloseRemark; v30.Clean = value; _aLTCashToCloseRemark = v30;
                var v31 = _aLTClosingCostBeforeClosingDidChangeCol; v31.Clean = value; _aLTClosingCostBeforeClosingDidChangeCol = v31;
                var v32 = _aLTLegalLimit; v32.Clean = value; _aLTLegalLimit = v32;
                var v33 = _aLTLoanAmountDidChangeCol; v33.Clean = value; _aLTLoanAmountDidChangeCol = v33;
                var v34 = _aLTLoanAmountIncDecRemark; v34.Clean = value; _aLTLoanAmountIncDecRemark = v34;
                var v35 = _aLTTotalClosingCostDidChangeCol; v35.Clean = value; _aLTTotalClosingCostDidChangeCol = v35;
                var v36 = _aLTTotalClosingCostRemark; v36.Clean = value; _aLTTotalClosingCostRemark = v36;
                var v37 = _aLTTotalPayoffsDidChangeCol; v37.Clean = value; _aLTTotalPayoffsDidChangeCol = v37;
                var v38 = _cash; v38.Clean = value; _cash = v38;
                var v39 = _cashToClose; v39.Clean = value; _cashToClose = v39;
                var v40 = _cD3CashToClose; v40.Clean = value; _cD3CashToClose = v40;
                var v41 = _cD3CashToCloseFromToBorrower; v41.Clean = value; _cD3CashToCloseFromToBorrower = v41;
                var v42 = _cD3ClosingCostsPaidBeforeClosing; v42.Clean = value; _cD3ClosingCostsPaidBeforeClosing = v42;
                var v43 = _cD3TotalClosingCost_J; v43.Clean = value; _cD3TotalClosingCost_J = v43;
                var v44 = _cD3TotalPayoffsAndPayments_K; v44.Clean = value; _cD3TotalPayoffsAndPayments_K = v44;
                var v45 = _closingCostsPaidAtClosing; v45.Clean = value; _closingCostsPaidAtClosing = v45;
                var v46 = _closingCostsPaidatClosing_J; v46.Clean = value; _closingCostsPaidatClosing_J = v46;
                var v47 = _duefromSelleratClosing11_1; v47.Clean = value; _duefromSelleratClosing11_1 = v47;
                var v48 = _duefromSelleratClosing11_2; v48.Clean = value; _duefromSelleratClosing11_2 = v48;
                var v49 = _duefromSelleratClosing12_1; v49.Clean = value; _duefromSelleratClosing12_1 = v49;
                var v50 = _duefromSelleratClosing12_2; v50.Clean = value; _duefromSelleratClosing12_2 = v50;
                var v51 = _duefromSelleratClosing13_1; v51.Clean = value; _duefromSelleratClosing13_1 = v51;
                var v52 = _duefromSelleratClosing13_2; v52.Clean = value; _duefromSelleratClosing13_2 = v52;
                var v53 = _dueToSellerAtClosing6_1; v53.Clean = value; _dueToSellerAtClosing6_1 = v53;
                var v54 = _dueToSellerAtClosing6_2; v54.Clean = value; _dueToSellerAtClosing6_2 = v54;
                var v55 = _dueToSellerAtClosing7_1; v55.Clean = value; _dueToSellerAtClosing7_1 = v55;
                var v56 = _dueToSellerAtClosing7_2; v56.Clean = value; _dueToSellerAtClosing7_2 = v56;
                var v57 = _dueToSellerAtClosing8_1; v57.Clean = value; _dueToSellerAtClosing8_1 = v57;
                var v58 = _dueToSellerAtClosing8_2; v58.Clean = value; _dueToSellerAtClosing8_2 = v58;
                var v59 = _excludeBorrowerClosingCosts; v59.Clean = value; _excludeBorrowerClosingCosts = v59;
                var v60 = _finalCashToClose; v60.Clean = value; _finalCashToClose = v60;
                var v61 = _fromToBorrower; v61.Clean = value; _fromToBorrower = v61;
                var v62 = _fromToSeller; v62.Clean = value; _fromToSeller = v62;
                var v63 = _id; v63.Clean = value; _id = v63;
                var v64 = _lECD3CashToClose; v64.Clean = value; _lECD3CashToClose = v64;
                var v65 = _lECD3CashToCloseFromToBorrower; v65.Clean = value; _lECD3CashToCloseFromToBorrower = v65;
                var v66 = _lECD3ClosingCostsPaidBeforeClosing; v66.Clean = value; _lECD3ClosingCostsPaidBeforeClosing = v66;
                var v67 = _lECD3TotalClosingCost_J; v67.Clean = value; _lECD3TotalClosingCost_J = v67;
                var v68 = _lECD3TotalPayoffsAndPayments_K; v68.Clean = value; _lECD3TotalPayoffsAndPayments_K = v68;
                var v69 = _lELoanAmount; v69.Clean = value; _lELoanAmount = v69;
                var v70 = _liabilityAmount1; v70.Clean = value; _liabilityAmount1 = v70;
                var v71 = _liabilityAmount10; v71.Clean = value; _liabilityAmount10 = v71;
                var v72 = _liabilityAmount11; v72.Clean = value; _liabilityAmount11 = v72;
                var v73 = _liabilityAmount12; v73.Clean = value; _liabilityAmount12 = v73;
                var v74 = _liabilityAmount13; v74.Clean = value; _liabilityAmount13 = v74;
                var v75 = _liabilityAmount14; v75.Clean = value; _liabilityAmount14 = v75;
                var v76 = _liabilityAmount15; v76.Clean = value; _liabilityAmount15 = v76;
                var v77 = _liabilityAmount2; v77.Clean = value; _liabilityAmount2 = v77;
                var v78 = _liabilityAmount3; v78.Clean = value; _liabilityAmount3 = v78;
                var v79 = _liabilityAmount4; v79.Clean = value; _liabilityAmount4 = v79;
                var v80 = _liabilityAmount5; v80.Clean = value; _liabilityAmount5 = v80;
                var v81 = _liabilityAmount6; v81.Clean = value; _liabilityAmount6 = v81;
                var v82 = _liabilityAmount7; v82.Clean = value; _liabilityAmount7 = v82;
                var v83 = _liabilityAmount8; v83.Clean = value; _liabilityAmount8 = v83;
                var v84 = _liabilityAmount9; v84.Clean = value; _liabilityAmount9 = v84;
                var v85 = _liabilityTo1; v85.Clean = value; _liabilityTo1 = v85;
                var v86 = _liabilityTo10; v86.Clean = value; _liabilityTo10 = v86;
                var v87 = _liabilityTo11; v87.Clean = value; _liabilityTo11 = v87;
                var v88 = _liabilityTo12; v88.Clean = value; _liabilityTo12 = v88;
                var v89 = _liabilityTo13; v89.Clean = value; _liabilityTo13 = v89;
                var v90 = _liabilityTo14; v90.Clean = value; _liabilityTo14 = v90;
                var v91 = _liabilityTo15; v91.Clean = value; _liabilityTo15 = v91;
                var v92 = _liabilityTo2; v92.Clean = value; _liabilityTo2 = v92;
                var v93 = _liabilityTo3; v93.Clean = value; _liabilityTo3 = v93;
                var v94 = _liabilityTo4; v94.Clean = value; _liabilityTo4 = v94;
                var v95 = _liabilityTo5; v95.Clean = value; _liabilityTo5 = v95;
                var v96 = _liabilityTo6; v96.Clean = value; _liabilityTo6 = v96;
                var v97 = _liabilityTo7; v97.Clean = value; _liabilityTo7 = v97;
                var v98 = _liabilityTo8; v98.Clean = value; _liabilityTo8 = v98;
                var v99 = _liabilityTo9; v99.Clean = value; _liabilityTo9 = v99;
                var v100 = _liabilityTotal; v100.Clean = value; _liabilityTotal = v100;
                var v101 = _loanAmount; v101.Clean = value; _loanAmount = v101;
                var v102 = _nonUCDTotalAdjustmentsAndOtherCredits; v102.Clean = value; _nonUCDTotalAdjustmentsAndOtherCredits = v102;
                var v103 = _omitFromPrintSellersTransaction; v103.Clean = value; _omitFromPrintSellersTransaction = v103;
                var v104 = _otherCredits6_1; v104.Clean = value; _otherCredits6_1 = v104;
                var v105 = _otherCredits6_2; v105.Clean = value; _otherCredits6_2 = v105;
                var v106 = _otherCredits7_1; v106.Clean = value; _otherCredits7_1 = v106;
                var v107 = _otherCredits7_2; v107.Clean = value; _otherCredits7_2 = v107;
                var v108 = _priorToleranceCureAmount; v108.Clean = value; _priorToleranceCureAmount = v108;
                var v109 = _sTDAdjustmentAndOtherCreditsRemark; v109.Clean = value; _sTDAdjustmentAndOtherCreditsRemark = v109;
                var v110 = _sTDAdjustmentsDidChangeCol; v110.Clean = value; _sTDAdjustmentsDidChangeCol = v110;
                var v111 = _sTDClosingCostFinancedDidChangeCol; v111.Clean = value; _sTDClosingCostFinancedDidChangeCol = v111;
                var v112 = _sTDDepositDidChangeCol; v112.Clean = value; _sTDDepositDidChangeCol = v112;
                var v113 = _sTDDepositIncDecRemark; v113.Clean = value; _sTDDepositIncDecRemark = v113;
                var v114 = _sTDDownPaymentDidChangeCol; v114.Clean = value; _sTDDownPaymentDidChangeCol = v114;
                var v115 = _sTDDownPaymentIncDecRemark; v115.Clean = value; _sTDDownPaymentIncDecRemark = v115;
                var v116 = _sTDDownPaymentSectionRemark; v116.Clean = value; _sTDDownPaymentSectionRemark = v116;
                var v117 = _sTDFinalAdjustmentAndOtherCredits; v117.Clean = value; _sTDFinalAdjustmentAndOtherCredits = v117;
                var v118 = _sTDFinalCashToClose; v118.Clean = value; _sTDFinalCashToClose = v118;
                var v119 = _sTDFinalCD3ClosingCostsPaidBeforeClosing; v119.Clean = value; _sTDFinalCD3ClosingCostsPaidBeforeClosing = v119;
                var v120 = _sTDFinalClosingCostFinanced; v120.Clean = value; _sTDFinalClosingCostFinanced = v120;
                var v121 = _sTDFinalDeposit; v121.Clean = value; _sTDFinalDeposit = v121;
                var v122 = _sTDFinalDownPayment; v122.Clean = value; _sTDFinalDownPayment = v122;
                var v123 = _sTDFinalFundForBorrower; v123.Clean = value; _sTDFinalFundForBorrower = v123;
                var v124 = _sTDFinalSellerCredits; v124.Clean = value; _sTDFinalSellerCredits = v124;
                var v125 = _sTDFinalTotalClosingCostJ; v125.Clean = value; _sTDFinalTotalClosingCostJ = v125;
                var v126 = _sTDFundsForBorrowerDidChangeCol; v126.Clean = value; _sTDFundsForBorrowerDidChangeCol = v126;
                var v127 = _sTDFundsForBorrowerIncDecRemark; v127.Clean = value; _sTDFundsForBorrowerIncDecRemark = v127;
                var v128 = _sTDLEAdjustmentAndOtherCredits; v128.Clean = value; _sTDLEAdjustmentAndOtherCredits = v128;
                var v129 = _sTDLECashToClose; v129.Clean = value; _sTDLECashToClose = v129;
                var v130 = _sTDLECD3ClosingCostsPaidBeforeClosing; v130.Clean = value; _sTDLECD3ClosingCostsPaidBeforeClosing = v130;
                var v131 = _sTDLEClosingCostFinanced; v131.Clean = value; _sTDLEClosingCostFinanced = v131;
                var v132 = _sTDLEDeposit; v132.Clean = value; _sTDLEDeposit = v132;
                var v133 = _sTDLEDownPayment; v133.Clean = value; _sTDLEDownPayment = v133;
                var v134 = _sTDLEFundForBorrower; v134.Clean = value; _sTDLEFundForBorrower = v134;
                var v135 = _sTDLegalLimit; v135.Clean = value; _sTDLegalLimit = v135;
                var v136 = _sTDLESellerCredits; v136.Clean = value; _sTDLESellerCredits = v136;
                var v137 = _sTDLETotalClosingCostJ; v137.Clean = value; _sTDLETotalClosingCostJ = v137;
                var v138 = _sTDSellerCreditsDidChangeCol; v138.Clean = value; _sTDSellerCreditsDidChangeCol = v138;
                var v139 = _sTDSellerCreditsIncDecRemark; v139.Clean = value; _sTDSellerCreditsIncDecRemark = v139;
                var v140 = _sTDTotalClosingCostBeforeClosingDidChangeCol; v140.Clean = value; _sTDTotalClosingCostBeforeClosingDidChangeCol = v140;
                var v141 = _sTDTotalClosingCostDidChangeCol; v141.Clean = value; _sTDTotalClosingCostDidChangeCol = v141;
                var v142 = _sTDTotalClosingCostRemark; v142.Clean = value; _sTDTotalClosingCostRemark = v142;
                var v143 = _totalAdjustmentsAndOtherCredits; v143.Clean = value; _totalAdjustmentsAndOtherCredits = v143;
                var v144 = _totalDuefromBorrowerAtClosing; v144.Clean = value; _totalDuefromBorrowerAtClosing = v144;
                var v145 = _totalDuefromSelleratClosing_N; v145.Clean = value; _totalDuefromSelleratClosing_N = v145;
                var v146 = _totalDuetoSelleratClosing_M; v146.Clean = value; _totalDuetoSelleratClosing_M = v146;
                var v147 = _totalFromK; v147.Clean = value; _totalFromK = v147;
                var v148 = _totalFromL; v148.Clean = value; _totalFromL = v148;
                var v149 = _totalFromM; v149.Clean = value; _totalFromM = v149;
                var v150 = _totalFromN; v150.Clean = value; _totalFromN = v150;
                var v151 = _totalPaidAlreadybyoronBehalfofBoroweratClosing; v151.Clean = value; _totalPaidAlreadybyoronBehalfofBoroweratClosing = v151;
                var v152 = _uCDDetails; v152.Clean = value; _uCDDetails = v152;
                var v153 = _uCDKSubTotal; v153.Clean = value; _uCDKSubTotal = v153;
                var v154 = _uCDLSubTotal; v154.Clean = value; _uCDLSubTotal = v154;
                var v155 = _uCDTotalAdjustmentsAndOtherCredits; v155.Clean = value; _uCDTotalAdjustmentsAndOtherCredits = v155;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDisclosure3()
        {
            Clean = true;
        }
    }
}