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
                var actualLECD3TotalClosingCostJFromLatestRec = _actualLECD3TotalClosingCostJFromLatestRec; actualLECD3TotalClosingCostJFromLatestRec.Clean = value; _actualLECD3TotalClosingCostJFromLatestRec = actualLECD3TotalClosingCostJFromLatestRec;
                var actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; actualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Clean = value; _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = actualLECD3TotalPayoffsAndPaymentsKFromLatestRec;
                var actualLELoanAmountFromLatestRec = _actualLELoanAmountFromLatestRec; actualLELoanAmountFromLatestRec.Clean = value; _actualLELoanAmountFromLatestRec = actualLELoanAmountFromLatestRec;
                var actualLenderCredits = _actualLenderCredits; actualLenderCredits.Clean = value; _actualLenderCredits = actualLenderCredits;
                var actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; actualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Clean = value; _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = actualSTDLEAdjustmentAndOtherCreditsFromLatestRec;
                var actualSTDLEClosingCostFinancedFromLatestRec = _actualSTDLEClosingCostFinancedFromLatestRec; actualSTDLEClosingCostFinancedFromLatestRec.Clean = value; _actualSTDLEClosingCostFinancedFromLatestRec = actualSTDLEClosingCostFinancedFromLatestRec;
                var actualSTDLEDepositFromLatestRec = _actualSTDLEDepositFromLatestRec; actualSTDLEDepositFromLatestRec.Clean = value; _actualSTDLEDepositFromLatestRec = actualSTDLEDepositFromLatestRec;
                var actualSTDLEDownPaymentFromLatestRec = _actualSTDLEDownPaymentFromLatestRec; actualSTDLEDownPaymentFromLatestRec.Clean = value; _actualSTDLEDownPaymentFromLatestRec = actualSTDLEDownPaymentFromLatestRec;
                var actualSTDLEFundForBorrowerFromLatestRec = _actualSTDLEFundForBorrowerFromLatestRec; actualSTDLEFundForBorrowerFromLatestRec.Clean = value; _actualSTDLEFundForBorrowerFromLatestRec = actualSTDLEFundForBorrowerFromLatestRec;
                var actualSTDLESellerCredits = _actualSTDLESellerCredits; actualSTDLESellerCredits.Clean = value; _actualSTDLESellerCredits = actualSTDLESellerCredits;
                var actualSTDLESellerCreditsFromLatestRec = _actualSTDLESellerCreditsFromLatestRec; actualSTDLESellerCreditsFromLatestRec.Clean = value; _actualSTDLESellerCreditsFromLatestRec = actualSTDLESellerCreditsFromLatestRec;
                var actualSTDLETotalClosingCostJ = _actualSTDLETotalClosingCostJ; actualSTDLETotalClosingCostJ.Clean = value; _actualSTDLETotalClosingCostJ = actualSTDLETotalClosingCostJ;
                var actualSTDLETotalClosingCostJFromLatestRec = _actualSTDLETotalClosingCostJFromLatestRec; actualSTDLETotalClosingCostJFromLatestRec.Clean = value; _actualSTDLETotalClosingCostJFromLatestRec = actualSTDLETotalClosingCostJFromLatestRec;
                var adjustments06_1 = _adjustments06_1; adjustments06_1.Clean = value; _adjustments06_1 = adjustments06_1;
                var adjustments06_2 = _adjustments06_2; adjustments06_2.Clean = value; _adjustments06_2 = adjustments06_2;
                var adjustments07_1 = _adjustments07_1; adjustments07_1.Clean = value; _adjustments07_1 = adjustments07_1;
                var adjustments07_2 = _adjustments07_2; adjustments07_2.Clean = value; _adjustments07_2 = adjustments07_2;
                var adjustments10_1 = _adjustments10_1; adjustments10_1.Clean = value; _adjustments10_1 = adjustments10_1;
                var adjustments10_2 = _adjustments10_2; adjustments10_2.Clean = value; _adjustments10_2 = adjustments10_2;
                var adjustments11_1 = _adjustments11_1; adjustments11_1.Clean = value; _adjustments11_1 = adjustments11_1;
                var adjustments11_2 = _adjustments11_2; adjustments11_2.Clean = value; _adjustments11_2 = adjustments11_2;
                var adjustments15_1 = _adjustments15_1; adjustments15_1.Clean = value; _adjustments15_1 = adjustments15_1;
                var adjustments15_2 = _adjustments15_2; adjustments15_2.Clean = value; _adjustments15_2 = adjustments15_2;
                var adjustments8_1 = _adjustments8_1; adjustments8_1.Clean = value; _adjustments8_1 = adjustments8_1;
                var adjustments8_2 = _adjustments8_2; adjustments8_2.Clean = value; _adjustments8_2 = adjustments8_2;
                var adjustments9_1 = _adjustments9_1; adjustments9_1.Clean = value; _adjustments9_1 = adjustments9_1;
                var adjustments9_2 = _adjustments9_2; adjustments9_2.Clean = value; _adjustments9_2 = adjustments9_2;
                var adjustmentsforItemsPaidbySellerinAdvance16_1 = _adjustmentsforItemsPaidbySellerinAdvance16_1; adjustmentsforItemsPaidbySellerinAdvance16_1.Clean = value; _adjustmentsforItemsPaidbySellerinAdvance16_1 = adjustmentsforItemsPaidbySellerinAdvance16_1;
                var adjustmentsforItemsPaidbySellerinAdvance16_2 = _adjustmentsforItemsPaidbySellerinAdvance16_2; adjustmentsforItemsPaidbySellerinAdvance16_2.Clean = value; _adjustmentsforItemsPaidbySellerinAdvance16_2 = adjustmentsforItemsPaidbySellerinAdvance16_2;
                var aLTCashToCloseDidChangeCol = _aLTCashToCloseDidChangeCol; aLTCashToCloseDidChangeCol.Clean = value; _aLTCashToCloseDidChangeCol = aLTCashToCloseDidChangeCol;
                var aLTCashToCloseRemark = _aLTCashToCloseRemark; aLTCashToCloseRemark.Clean = value; _aLTCashToCloseRemark = aLTCashToCloseRemark;
                var aLTClosingCostBeforeClosingDidChangeCol = _aLTClosingCostBeforeClosingDidChangeCol; aLTClosingCostBeforeClosingDidChangeCol.Clean = value; _aLTClosingCostBeforeClosingDidChangeCol = aLTClosingCostBeforeClosingDidChangeCol;
                var aLTLegalLimit = _aLTLegalLimit; aLTLegalLimit.Clean = value; _aLTLegalLimit = aLTLegalLimit;
                var aLTLoanAmountDidChangeCol = _aLTLoanAmountDidChangeCol; aLTLoanAmountDidChangeCol.Clean = value; _aLTLoanAmountDidChangeCol = aLTLoanAmountDidChangeCol;
                var aLTLoanAmountIncDecRemark = _aLTLoanAmountIncDecRemark; aLTLoanAmountIncDecRemark.Clean = value; _aLTLoanAmountIncDecRemark = aLTLoanAmountIncDecRemark;
                var aLTTotalClosingCostDidChangeCol = _aLTTotalClosingCostDidChangeCol; aLTTotalClosingCostDidChangeCol.Clean = value; _aLTTotalClosingCostDidChangeCol = aLTTotalClosingCostDidChangeCol;
                var aLTTotalClosingCostRemark = _aLTTotalClosingCostRemark; aLTTotalClosingCostRemark.Clean = value; _aLTTotalClosingCostRemark = aLTTotalClosingCostRemark;
                var aLTTotalPayoffsDidChangeCol = _aLTTotalPayoffsDidChangeCol; aLTTotalPayoffsDidChangeCol.Clean = value; _aLTTotalPayoffsDidChangeCol = aLTTotalPayoffsDidChangeCol;
                var cash = _cash; cash.Clean = value; _cash = cash;
                var cashToClose = _cashToClose; cashToClose.Clean = value; _cashToClose = cashToClose;
                var cD3CashToClose = _cD3CashToClose; cD3CashToClose.Clean = value; _cD3CashToClose = cD3CashToClose;
                var cD3CashToCloseFromToBorrower = _cD3CashToCloseFromToBorrower; cD3CashToCloseFromToBorrower.Clean = value; _cD3CashToCloseFromToBorrower = cD3CashToCloseFromToBorrower;
                var cD3ClosingCostsPaidBeforeClosing = _cD3ClosingCostsPaidBeforeClosing; cD3ClosingCostsPaidBeforeClosing.Clean = value; _cD3ClosingCostsPaidBeforeClosing = cD3ClosingCostsPaidBeforeClosing;
                var cD3TotalClosingCost_J = _cD3TotalClosingCost_J; cD3TotalClosingCost_J.Clean = value; _cD3TotalClosingCost_J = cD3TotalClosingCost_J;
                var cD3TotalPayoffsAndPayments_K = _cD3TotalPayoffsAndPayments_K; cD3TotalPayoffsAndPayments_K.Clean = value; _cD3TotalPayoffsAndPayments_K = cD3TotalPayoffsAndPayments_K;
                var closingCostsPaidAtClosing = _closingCostsPaidAtClosing; closingCostsPaidAtClosing.Clean = value; _closingCostsPaidAtClosing = closingCostsPaidAtClosing;
                var closingCostsPaidatClosing_J = _closingCostsPaidatClosing_J; closingCostsPaidatClosing_J.Clean = value; _closingCostsPaidatClosing_J = closingCostsPaidatClosing_J;
                var duefromSelleratClosing11_1 = _duefromSelleratClosing11_1; duefromSelleratClosing11_1.Clean = value; _duefromSelleratClosing11_1 = duefromSelleratClosing11_1;
                var duefromSelleratClosing11_2 = _duefromSelleratClosing11_2; duefromSelleratClosing11_2.Clean = value; _duefromSelleratClosing11_2 = duefromSelleratClosing11_2;
                var duefromSelleratClosing12_1 = _duefromSelleratClosing12_1; duefromSelleratClosing12_1.Clean = value; _duefromSelleratClosing12_1 = duefromSelleratClosing12_1;
                var duefromSelleratClosing12_2 = _duefromSelleratClosing12_2; duefromSelleratClosing12_2.Clean = value; _duefromSelleratClosing12_2 = duefromSelleratClosing12_2;
                var duefromSelleratClosing13_1 = _duefromSelleratClosing13_1; duefromSelleratClosing13_1.Clean = value; _duefromSelleratClosing13_1 = duefromSelleratClosing13_1;
                var duefromSelleratClosing13_2 = _duefromSelleratClosing13_2; duefromSelleratClosing13_2.Clean = value; _duefromSelleratClosing13_2 = duefromSelleratClosing13_2;
                var dueToSellerAtClosing6_1 = _dueToSellerAtClosing6_1; dueToSellerAtClosing6_1.Clean = value; _dueToSellerAtClosing6_1 = dueToSellerAtClosing6_1;
                var dueToSellerAtClosing6_2 = _dueToSellerAtClosing6_2; dueToSellerAtClosing6_2.Clean = value; _dueToSellerAtClosing6_2 = dueToSellerAtClosing6_2;
                var dueToSellerAtClosing7_1 = _dueToSellerAtClosing7_1; dueToSellerAtClosing7_1.Clean = value; _dueToSellerAtClosing7_1 = dueToSellerAtClosing7_1;
                var dueToSellerAtClosing7_2 = _dueToSellerAtClosing7_2; dueToSellerAtClosing7_2.Clean = value; _dueToSellerAtClosing7_2 = dueToSellerAtClosing7_2;
                var dueToSellerAtClosing8_1 = _dueToSellerAtClosing8_1; dueToSellerAtClosing8_1.Clean = value; _dueToSellerAtClosing8_1 = dueToSellerAtClosing8_1;
                var dueToSellerAtClosing8_2 = _dueToSellerAtClosing8_2; dueToSellerAtClosing8_2.Clean = value; _dueToSellerAtClosing8_2 = dueToSellerAtClosing8_2;
                var excludeBorrowerClosingCosts = _excludeBorrowerClosingCosts; excludeBorrowerClosingCosts.Clean = value; _excludeBorrowerClosingCosts = excludeBorrowerClosingCosts;
                var finalCashToClose = _finalCashToClose; finalCashToClose.Clean = value; _finalCashToClose = finalCashToClose;
                var fromToBorrower = _fromToBorrower; fromToBorrower.Clean = value; _fromToBorrower = fromToBorrower;
                var fromToSeller = _fromToSeller; fromToSeller.Clean = value; _fromToSeller = fromToSeller;
                var id = _id; id.Clean = value; _id = id;
                var lECD3CashToClose = _lECD3CashToClose; lECD3CashToClose.Clean = value; _lECD3CashToClose = lECD3CashToClose;
                var lECD3CashToCloseFromToBorrower = _lECD3CashToCloseFromToBorrower; lECD3CashToCloseFromToBorrower.Clean = value; _lECD3CashToCloseFromToBorrower = lECD3CashToCloseFromToBorrower;
                var lECD3ClosingCostsPaidBeforeClosing = _lECD3ClosingCostsPaidBeforeClosing; lECD3ClosingCostsPaidBeforeClosing.Clean = value; _lECD3ClosingCostsPaidBeforeClosing = lECD3ClosingCostsPaidBeforeClosing;
                var lECD3TotalClosingCost_J = _lECD3TotalClosingCost_J; lECD3TotalClosingCost_J.Clean = value; _lECD3TotalClosingCost_J = lECD3TotalClosingCost_J;
                var lECD3TotalPayoffsAndPayments_K = _lECD3TotalPayoffsAndPayments_K; lECD3TotalPayoffsAndPayments_K.Clean = value; _lECD3TotalPayoffsAndPayments_K = lECD3TotalPayoffsAndPayments_K;
                var lELoanAmount = _lELoanAmount; lELoanAmount.Clean = value; _lELoanAmount = lELoanAmount;
                var liabilityAmount1 = _liabilityAmount1; liabilityAmount1.Clean = value; _liabilityAmount1 = liabilityAmount1;
                var liabilityAmount10 = _liabilityAmount10; liabilityAmount10.Clean = value; _liabilityAmount10 = liabilityAmount10;
                var liabilityAmount11 = _liabilityAmount11; liabilityAmount11.Clean = value; _liabilityAmount11 = liabilityAmount11;
                var liabilityAmount12 = _liabilityAmount12; liabilityAmount12.Clean = value; _liabilityAmount12 = liabilityAmount12;
                var liabilityAmount13 = _liabilityAmount13; liabilityAmount13.Clean = value; _liabilityAmount13 = liabilityAmount13;
                var liabilityAmount14 = _liabilityAmount14; liabilityAmount14.Clean = value; _liabilityAmount14 = liabilityAmount14;
                var liabilityAmount15 = _liabilityAmount15; liabilityAmount15.Clean = value; _liabilityAmount15 = liabilityAmount15;
                var liabilityAmount2 = _liabilityAmount2; liabilityAmount2.Clean = value; _liabilityAmount2 = liabilityAmount2;
                var liabilityAmount3 = _liabilityAmount3; liabilityAmount3.Clean = value; _liabilityAmount3 = liabilityAmount3;
                var liabilityAmount4 = _liabilityAmount4; liabilityAmount4.Clean = value; _liabilityAmount4 = liabilityAmount4;
                var liabilityAmount5 = _liabilityAmount5; liabilityAmount5.Clean = value; _liabilityAmount5 = liabilityAmount5;
                var liabilityAmount6 = _liabilityAmount6; liabilityAmount6.Clean = value; _liabilityAmount6 = liabilityAmount6;
                var liabilityAmount7 = _liabilityAmount7; liabilityAmount7.Clean = value; _liabilityAmount7 = liabilityAmount7;
                var liabilityAmount8 = _liabilityAmount8; liabilityAmount8.Clean = value; _liabilityAmount8 = liabilityAmount8;
                var liabilityAmount9 = _liabilityAmount9; liabilityAmount9.Clean = value; _liabilityAmount9 = liabilityAmount9;
                var liabilityTo1 = _liabilityTo1; liabilityTo1.Clean = value; _liabilityTo1 = liabilityTo1;
                var liabilityTo10 = _liabilityTo10; liabilityTo10.Clean = value; _liabilityTo10 = liabilityTo10;
                var liabilityTo11 = _liabilityTo11; liabilityTo11.Clean = value; _liabilityTo11 = liabilityTo11;
                var liabilityTo12 = _liabilityTo12; liabilityTo12.Clean = value; _liabilityTo12 = liabilityTo12;
                var liabilityTo13 = _liabilityTo13; liabilityTo13.Clean = value; _liabilityTo13 = liabilityTo13;
                var liabilityTo14 = _liabilityTo14; liabilityTo14.Clean = value; _liabilityTo14 = liabilityTo14;
                var liabilityTo15 = _liabilityTo15; liabilityTo15.Clean = value; _liabilityTo15 = liabilityTo15;
                var liabilityTo2 = _liabilityTo2; liabilityTo2.Clean = value; _liabilityTo2 = liabilityTo2;
                var liabilityTo3 = _liabilityTo3; liabilityTo3.Clean = value; _liabilityTo3 = liabilityTo3;
                var liabilityTo4 = _liabilityTo4; liabilityTo4.Clean = value; _liabilityTo4 = liabilityTo4;
                var liabilityTo5 = _liabilityTo5; liabilityTo5.Clean = value; _liabilityTo5 = liabilityTo5;
                var liabilityTo6 = _liabilityTo6; liabilityTo6.Clean = value; _liabilityTo6 = liabilityTo6;
                var liabilityTo7 = _liabilityTo7; liabilityTo7.Clean = value; _liabilityTo7 = liabilityTo7;
                var liabilityTo8 = _liabilityTo8; liabilityTo8.Clean = value; _liabilityTo8 = liabilityTo8;
                var liabilityTo9 = _liabilityTo9; liabilityTo9.Clean = value; _liabilityTo9 = liabilityTo9;
                var liabilityTotal = _liabilityTotal; liabilityTotal.Clean = value; _liabilityTotal = liabilityTotal;
                var loanAmount = _loanAmount; loanAmount.Clean = value; _loanAmount = loanAmount;
                var nonUCDTotalAdjustmentsAndOtherCredits = _nonUCDTotalAdjustmentsAndOtherCredits; nonUCDTotalAdjustmentsAndOtherCredits.Clean = value; _nonUCDTotalAdjustmentsAndOtherCredits = nonUCDTotalAdjustmentsAndOtherCredits;
                var omitFromPrintSellersTransaction = _omitFromPrintSellersTransaction; omitFromPrintSellersTransaction.Clean = value; _omitFromPrintSellersTransaction = omitFromPrintSellersTransaction;
                var otherCredits6_1 = _otherCredits6_1; otherCredits6_1.Clean = value; _otherCredits6_1 = otherCredits6_1;
                var otherCredits6_2 = _otherCredits6_2; otherCredits6_2.Clean = value; _otherCredits6_2 = otherCredits6_2;
                var otherCredits7_1 = _otherCredits7_1; otherCredits7_1.Clean = value; _otherCredits7_1 = otherCredits7_1;
                var otherCredits7_2 = _otherCredits7_2; otherCredits7_2.Clean = value; _otherCredits7_2 = otherCredits7_2;
                var priorToleranceCureAmount = _priorToleranceCureAmount; priorToleranceCureAmount.Clean = value; _priorToleranceCureAmount = priorToleranceCureAmount;
                var sTDAdjustmentAndOtherCreditsRemark = _sTDAdjustmentAndOtherCreditsRemark; sTDAdjustmentAndOtherCreditsRemark.Clean = value; _sTDAdjustmentAndOtherCreditsRemark = sTDAdjustmentAndOtherCreditsRemark;
                var sTDAdjustmentsDidChangeCol = _sTDAdjustmentsDidChangeCol; sTDAdjustmentsDidChangeCol.Clean = value; _sTDAdjustmentsDidChangeCol = sTDAdjustmentsDidChangeCol;
                var sTDClosingCostFinancedDidChangeCol = _sTDClosingCostFinancedDidChangeCol; sTDClosingCostFinancedDidChangeCol.Clean = value; _sTDClosingCostFinancedDidChangeCol = sTDClosingCostFinancedDidChangeCol;
                var sTDDepositDidChangeCol = _sTDDepositDidChangeCol; sTDDepositDidChangeCol.Clean = value; _sTDDepositDidChangeCol = sTDDepositDidChangeCol;
                var sTDDepositIncDecRemark = _sTDDepositIncDecRemark; sTDDepositIncDecRemark.Clean = value; _sTDDepositIncDecRemark = sTDDepositIncDecRemark;
                var sTDDownPaymentDidChangeCol = _sTDDownPaymentDidChangeCol; sTDDownPaymentDidChangeCol.Clean = value; _sTDDownPaymentDidChangeCol = sTDDownPaymentDidChangeCol;
                var sTDDownPaymentIncDecRemark = _sTDDownPaymentIncDecRemark; sTDDownPaymentIncDecRemark.Clean = value; _sTDDownPaymentIncDecRemark = sTDDownPaymentIncDecRemark;
                var sTDDownPaymentSectionRemark = _sTDDownPaymentSectionRemark; sTDDownPaymentSectionRemark.Clean = value; _sTDDownPaymentSectionRemark = sTDDownPaymentSectionRemark;
                var sTDFinalAdjustmentAndOtherCredits = _sTDFinalAdjustmentAndOtherCredits; sTDFinalAdjustmentAndOtherCredits.Clean = value; _sTDFinalAdjustmentAndOtherCredits = sTDFinalAdjustmentAndOtherCredits;
                var sTDFinalCashToClose = _sTDFinalCashToClose; sTDFinalCashToClose.Clean = value; _sTDFinalCashToClose = sTDFinalCashToClose;
                var sTDFinalCD3ClosingCostsPaidBeforeClosing = _sTDFinalCD3ClosingCostsPaidBeforeClosing; sTDFinalCD3ClosingCostsPaidBeforeClosing.Clean = value; _sTDFinalCD3ClosingCostsPaidBeforeClosing = sTDFinalCD3ClosingCostsPaidBeforeClosing;
                var sTDFinalClosingCostFinanced = _sTDFinalClosingCostFinanced; sTDFinalClosingCostFinanced.Clean = value; _sTDFinalClosingCostFinanced = sTDFinalClosingCostFinanced;
                var sTDFinalDeposit = _sTDFinalDeposit; sTDFinalDeposit.Clean = value; _sTDFinalDeposit = sTDFinalDeposit;
                var sTDFinalDownPayment = _sTDFinalDownPayment; sTDFinalDownPayment.Clean = value; _sTDFinalDownPayment = sTDFinalDownPayment;
                var sTDFinalFundForBorrower = _sTDFinalFundForBorrower; sTDFinalFundForBorrower.Clean = value; _sTDFinalFundForBorrower = sTDFinalFundForBorrower;
                var sTDFinalSellerCredits = _sTDFinalSellerCredits; sTDFinalSellerCredits.Clean = value; _sTDFinalSellerCredits = sTDFinalSellerCredits;
                var sTDFinalTotalClosingCostJ = _sTDFinalTotalClosingCostJ; sTDFinalTotalClosingCostJ.Clean = value; _sTDFinalTotalClosingCostJ = sTDFinalTotalClosingCostJ;
                var sTDFundsForBorrowerDidChangeCol = _sTDFundsForBorrowerDidChangeCol; sTDFundsForBorrowerDidChangeCol.Clean = value; _sTDFundsForBorrowerDidChangeCol = sTDFundsForBorrowerDidChangeCol;
                var sTDFundsForBorrowerIncDecRemark = _sTDFundsForBorrowerIncDecRemark; sTDFundsForBorrowerIncDecRemark.Clean = value; _sTDFundsForBorrowerIncDecRemark = sTDFundsForBorrowerIncDecRemark;
                var sTDLEAdjustmentAndOtherCredits = _sTDLEAdjustmentAndOtherCredits; sTDLEAdjustmentAndOtherCredits.Clean = value; _sTDLEAdjustmentAndOtherCredits = sTDLEAdjustmentAndOtherCredits;
                var sTDLECashToClose = _sTDLECashToClose; sTDLECashToClose.Clean = value; _sTDLECashToClose = sTDLECashToClose;
                var sTDLECD3ClosingCostsPaidBeforeClosing = _sTDLECD3ClosingCostsPaidBeforeClosing; sTDLECD3ClosingCostsPaidBeforeClosing.Clean = value; _sTDLECD3ClosingCostsPaidBeforeClosing = sTDLECD3ClosingCostsPaidBeforeClosing;
                var sTDLEClosingCostFinanced = _sTDLEClosingCostFinanced; sTDLEClosingCostFinanced.Clean = value; _sTDLEClosingCostFinanced = sTDLEClosingCostFinanced;
                var sTDLEDeposit = _sTDLEDeposit; sTDLEDeposit.Clean = value; _sTDLEDeposit = sTDLEDeposit;
                var sTDLEDownPayment = _sTDLEDownPayment; sTDLEDownPayment.Clean = value; _sTDLEDownPayment = sTDLEDownPayment;
                var sTDLEFundForBorrower = _sTDLEFundForBorrower; sTDLEFundForBorrower.Clean = value; _sTDLEFundForBorrower = sTDLEFundForBorrower;
                var sTDLegalLimit = _sTDLegalLimit; sTDLegalLimit.Clean = value; _sTDLegalLimit = sTDLegalLimit;
                var sTDLESellerCredits = _sTDLESellerCredits; sTDLESellerCredits.Clean = value; _sTDLESellerCredits = sTDLESellerCredits;
                var sTDLETotalClosingCostJ = _sTDLETotalClosingCostJ; sTDLETotalClosingCostJ.Clean = value; _sTDLETotalClosingCostJ = sTDLETotalClosingCostJ;
                var sTDSellerCreditsDidChangeCol = _sTDSellerCreditsDidChangeCol; sTDSellerCreditsDidChangeCol.Clean = value; _sTDSellerCreditsDidChangeCol = sTDSellerCreditsDidChangeCol;
                var sTDSellerCreditsIncDecRemark = _sTDSellerCreditsIncDecRemark; sTDSellerCreditsIncDecRemark.Clean = value; _sTDSellerCreditsIncDecRemark = sTDSellerCreditsIncDecRemark;
                var sTDTotalClosingCostBeforeClosingDidChangeCol = _sTDTotalClosingCostBeforeClosingDidChangeCol; sTDTotalClosingCostBeforeClosingDidChangeCol.Clean = value; _sTDTotalClosingCostBeforeClosingDidChangeCol = sTDTotalClosingCostBeforeClosingDidChangeCol;
                var sTDTotalClosingCostDidChangeCol = _sTDTotalClosingCostDidChangeCol; sTDTotalClosingCostDidChangeCol.Clean = value; _sTDTotalClosingCostDidChangeCol = sTDTotalClosingCostDidChangeCol;
                var sTDTotalClosingCostRemark = _sTDTotalClosingCostRemark; sTDTotalClosingCostRemark.Clean = value; _sTDTotalClosingCostRemark = sTDTotalClosingCostRemark;
                var totalAdjustmentsAndOtherCredits = _totalAdjustmentsAndOtherCredits; totalAdjustmentsAndOtherCredits.Clean = value; _totalAdjustmentsAndOtherCredits = totalAdjustmentsAndOtherCredits;
                var totalDuefromBorrowerAtClosing = _totalDuefromBorrowerAtClosing; totalDuefromBorrowerAtClosing.Clean = value; _totalDuefromBorrowerAtClosing = totalDuefromBorrowerAtClosing;
                var totalDuefromSelleratClosing_N = _totalDuefromSelleratClosing_N; totalDuefromSelleratClosing_N.Clean = value; _totalDuefromSelleratClosing_N = totalDuefromSelleratClosing_N;
                var totalDuetoSelleratClosing_M = _totalDuetoSelleratClosing_M; totalDuetoSelleratClosing_M.Clean = value; _totalDuetoSelleratClosing_M = totalDuetoSelleratClosing_M;
                var totalFromK = _totalFromK; totalFromK.Clean = value; _totalFromK = totalFromK;
                var totalFromL = _totalFromL; totalFromL.Clean = value; _totalFromL = totalFromL;
                var totalFromM = _totalFromM; totalFromM.Clean = value; _totalFromM = totalFromM;
                var totalFromN = _totalFromN; totalFromN.Clean = value; _totalFromN = totalFromN;
                var totalPaidAlreadybyoronBehalfofBoroweratClosing = _totalPaidAlreadybyoronBehalfofBoroweratClosing; totalPaidAlreadybyoronBehalfofBoroweratClosing.Clean = value; _totalPaidAlreadybyoronBehalfofBoroweratClosing = totalPaidAlreadybyoronBehalfofBoroweratClosing;
                var uCDDetails = _uCDDetails; uCDDetails.Clean = value; _uCDDetails = uCDDetails;
                var uCDKSubTotal = _uCDKSubTotal; uCDKSubTotal.Clean = value; _uCDKSubTotal = uCDKSubTotal;
                var uCDLSubTotal = _uCDLSubTotal; uCDLSubTotal.Clean = value; _uCDLSubTotal = uCDLSubTotal;
                var uCDTotalAdjustmentsAndOtherCredits = _uCDTotalAdjustmentsAndOtherCredits; uCDTotalAdjustmentsAndOtherCredits.Clean = value; _uCDTotalAdjustmentsAndOtherCredits = uCDTotalAdjustmentsAndOtherCredits;
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