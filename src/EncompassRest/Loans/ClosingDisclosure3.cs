using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ClosingDisclosure3 : IDirty
    {
        private DirtyValue<decimal?> _actualLECD3TotalClosingCostJFromLatestRec;
        public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get => _actualLECD3TotalClosingCostJFromLatestRec; set => _actualLECD3TotalClosingCostJFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec;
        public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get => _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec; set => _actualLECD3TotalPayoffsAndPaymentsKFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLELoanAmountFromLatestRec;
        public decimal? ActualLELoanAmountFromLatestRec { get => _actualLELoanAmountFromLatestRec; set => _actualLELoanAmountFromLatestRec = value; }
        private DirtyValue<decimal?> _actualLenderCredits;
        public decimal? ActualLenderCredits { get => _actualLenderCredits; set => _actualLenderCredits = value; }
        private DirtyValue<decimal?> _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec;
        public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get => _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec; set => _actualSTDLEAdjustmentAndOtherCreditsFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEClosingCostFinancedFromLatestRec;
        public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get => _actualSTDLEClosingCostFinancedFromLatestRec; set => _actualSTDLEClosingCostFinancedFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEDepositFromLatestRec;
        public decimal? ActualSTDLEDepositFromLatestRec { get => _actualSTDLEDepositFromLatestRec; set => _actualSTDLEDepositFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEDownPaymentFromLatestRec;
        public decimal? ActualSTDLEDownPaymentFromLatestRec { get => _actualSTDLEDownPaymentFromLatestRec; set => _actualSTDLEDownPaymentFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLEFundForBorrowerFromLatestRec;
        public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get => _actualSTDLEFundForBorrowerFromLatestRec; set => _actualSTDLEFundForBorrowerFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCredits;
        public decimal? ActualSTDLESellerCredits { get => _actualSTDLESellerCredits; set => _actualSTDLESellerCredits = value; }
        private DirtyValue<decimal?> _actualSTDLESellerCreditsFromLatestRec;
        public decimal? ActualSTDLESellerCreditsFromLatestRec { get => _actualSTDLESellerCreditsFromLatestRec; set => _actualSTDLESellerCreditsFromLatestRec = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJ;
        public decimal? ActualSTDLETotalClosingCostJ { get => _actualSTDLETotalClosingCostJ; set => _actualSTDLETotalClosingCostJ = value; }
        private DirtyValue<decimal?> _actualSTDLETotalClosingCostJFromLatestRec;
        public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get => _actualSTDLETotalClosingCostJFromLatestRec; set => _actualSTDLETotalClosingCostJFromLatestRec = value; }
        private DirtyValue<string> _adjustments06_1;
        public string Adjustments06_1 { get => _adjustments06_1; set => _adjustments06_1 = value; }
        private DirtyValue<decimal?> _adjustments06_2;
        public decimal? Adjustments06_2 { get => _adjustments06_2; set => _adjustments06_2 = value; }
        private DirtyValue<string> _adjustments07_1;
        public string Adjustments07_1 { get => _adjustments07_1; set => _adjustments07_1 = value; }
        private DirtyValue<decimal?> _adjustments07_2;
        public decimal? Adjustments07_2 { get => _adjustments07_2; set => _adjustments07_2 = value; }
        private DirtyValue<string> _adjustments10_1;
        public string Adjustments10_1 { get => _adjustments10_1; set => _adjustments10_1 = value; }
        private DirtyValue<decimal?> _adjustments10_2;
        public decimal? Adjustments10_2 { get => _adjustments10_2; set => _adjustments10_2 = value; }
        private DirtyValue<string> _adjustments11_1;
        public string Adjustments11_1 { get => _adjustments11_1; set => _adjustments11_1 = value; }
        private DirtyValue<decimal?> _adjustments11_2;
        public decimal? Adjustments11_2 { get => _adjustments11_2; set => _adjustments11_2 = value; }
        private DirtyValue<string> _adjustments15_1;
        public string Adjustments15_1 { get => _adjustments15_1; set => _adjustments15_1 = value; }
        private DirtyValue<decimal?> _adjustments15_2;
        public decimal? Adjustments15_2 { get => _adjustments15_2; set => _adjustments15_2 = value; }
        private DirtyValue<string> _adjustments8_1;
        public string Adjustments8_1 { get => _adjustments8_1; set => _adjustments8_1 = value; }
        private DirtyValue<decimal?> _adjustments8_2;
        public decimal? Adjustments8_2 { get => _adjustments8_2; set => _adjustments8_2 = value; }
        private DirtyValue<string> _adjustments9_1;
        public string Adjustments9_1 { get => _adjustments9_1; set => _adjustments9_1 = value; }
        private DirtyValue<decimal?> _adjustments9_2;
        public decimal? Adjustments9_2 { get => _adjustments9_2; set => _adjustments9_2 = value; }
        private DirtyValue<string> _adjustmentsforItemsPaidbySellerinAdvance16_1;
        public string AdjustmentsforItemsPaidbySellerinAdvance16_1 { get => _adjustmentsforItemsPaidbySellerinAdvance16_1; set => _adjustmentsforItemsPaidbySellerinAdvance16_1 = value; }
        private DirtyValue<decimal?> _adjustmentsforItemsPaidbySellerinAdvance16_2;
        public decimal? AdjustmentsforItemsPaidbySellerinAdvance16_2 { get => _adjustmentsforItemsPaidbySellerinAdvance16_2; set => _adjustmentsforItemsPaidbySellerinAdvance16_2 = value; }
        private DirtyValue<string> _aLTCashToCloseDidChangeCol;
        public string ALTCashToCloseDidChangeCol { get => _aLTCashToCloseDidChangeCol; set => _aLTCashToCloseDidChangeCol = value; }
        private DirtyValue<decimal?> _aLTCashToCloseRemark;
        public decimal? ALTCashToCloseRemark { get => _aLTCashToCloseRemark; set => _aLTCashToCloseRemark = value; }
        private DirtyValue<string> _aLTClosingCostBeforeClosingDidChangeCol;
        public string ALTClosingCostBeforeClosingDidChangeCol { get => _aLTClosingCostBeforeClosingDidChangeCol; set => _aLTClosingCostBeforeClosingDidChangeCol = value; }
        private DirtyValue<decimal?> _aLTLegalLimit;
        public decimal? ALTLegalLimit { get => _aLTLegalLimit; set => _aLTLegalLimit = value; }
        private DirtyValue<string> _aLTLoanAmountDidChangeCol;
        public string ALTLoanAmountDidChangeCol { get => _aLTLoanAmountDidChangeCol; set => _aLTLoanAmountDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _aLTLoanAmountIncDecRemark;
        public StringEnumValue<IncreasedOrDecreased> ALTLoanAmountIncDecRemark { get => _aLTLoanAmountIncDecRemark; set => _aLTLoanAmountIncDecRemark = value; }
        private DirtyValue<string> _aLTTotalClosingCostDidChangeCol;
        public string ALTTotalClosingCostDidChangeCol { get => _aLTTotalClosingCostDidChangeCol; set => _aLTTotalClosingCostDidChangeCol = value; }
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _aLTTotalClosingCostRemark;
        public StringEnumValue<TotalClosingCostRemark> ALTTotalClosingCostRemark { get => _aLTTotalClosingCostRemark; set => _aLTTotalClosingCostRemark = value; }
        private DirtyValue<string> _aLTTotalPayoffsDidChangeCol;
        public string ALTTotalPayoffsDidChangeCol { get => _aLTTotalPayoffsDidChangeCol; set => _aLTTotalPayoffsDidChangeCol = value; }
        private DirtyValue<decimal?> _cash;
        public decimal? Cash { get => _cash; set => _cash = value; }
        private DirtyValue<decimal?> _cashToClose;
        public decimal? CashToClose { get => _cashToClose; set => _cashToClose = value; }
        private DirtyValue<decimal?> _cD3CashToClose;
        public decimal? CD3CashToClose { get => _cD3CashToClose; set => _cD3CashToClose = value; }
        private DirtyValue<string> _cD3CashToCloseFromToBorrower;
        public string CD3CashToCloseFromToBorrower { get => _cD3CashToCloseFromToBorrower; set => _cD3CashToCloseFromToBorrower = value; }
        private DirtyValue<decimal?> _cD3ClosingCostsPaidBeforeClosing;
        public decimal? CD3ClosingCostsPaidBeforeClosing { get => _cD3ClosingCostsPaidBeforeClosing; set => _cD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _cD3TotalClosingCost_J;
        public decimal? CD3TotalClosingCost_J { get => _cD3TotalClosingCost_J; set => _cD3TotalClosingCost_J = value; }
        private DirtyValue<decimal?> _cD3TotalPayoffsAndPayments_K;
        public decimal? CD3TotalPayoffsAndPayments_K { get => _cD3TotalPayoffsAndPayments_K; set => _cD3TotalPayoffsAndPayments_K = value; }
        private DirtyValue<decimal?> _closingCostsPaidAtClosing;
        public decimal? ClosingCostsPaidAtClosing { get => _closingCostsPaidAtClosing; set => _closingCostsPaidAtClosing = value; }
        private DirtyValue<decimal?> _closingCostsPaidatClosing_J;
        public decimal? ClosingCostsPaidatClosing_J { get => _closingCostsPaidatClosing_J; set => _closingCostsPaidatClosing_J = value; }
        private DirtyValue<string> _duefromSelleratClosing11_1;
        public string DuefromSelleratClosing11_1 { get => _duefromSelleratClosing11_1; set => _duefromSelleratClosing11_1 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing11_2;
        public decimal? DuefromSelleratClosing11_2 { get => _duefromSelleratClosing11_2; set => _duefromSelleratClosing11_2 = value; }
        private DirtyValue<string> _duefromSelleratClosing12_1;
        public string DuefromSelleratClosing12_1 { get => _duefromSelleratClosing12_1; set => _duefromSelleratClosing12_1 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing12_2;
        public decimal? DuefromSelleratClosing12_2 { get => _duefromSelleratClosing12_2; set => _duefromSelleratClosing12_2 = value; }
        private DirtyValue<string> _duefromSelleratClosing13_1;
        public string DuefromSelleratClosing13_1 { get => _duefromSelleratClosing13_1; set => _duefromSelleratClosing13_1 = value; }
        private DirtyValue<decimal?> _duefromSelleratClosing13_2;
        public decimal? DuefromSelleratClosing13_2 { get => _duefromSelleratClosing13_2; set => _duefromSelleratClosing13_2 = value; }
        private DirtyValue<string> _dueToSellerAtClosing6_1;
        public string DueToSellerAtClosing6_1 { get => _dueToSellerAtClosing6_1; set => _dueToSellerAtClosing6_1 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing6_2;
        public decimal? DueToSellerAtClosing6_2 { get => _dueToSellerAtClosing6_2; set => _dueToSellerAtClosing6_2 = value; }
        private DirtyValue<string> _dueToSellerAtClosing7_1;
        public string DueToSellerAtClosing7_1 { get => _dueToSellerAtClosing7_1; set => _dueToSellerAtClosing7_1 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing7_2;
        public decimal? DueToSellerAtClosing7_2 { get => _dueToSellerAtClosing7_2; set => _dueToSellerAtClosing7_2 = value; }
        private DirtyValue<string> _dueToSellerAtClosing8_1;
        public string DueToSellerAtClosing8_1 { get => _dueToSellerAtClosing8_1; set => _dueToSellerAtClosing8_1 = value; }
        private DirtyValue<decimal?> _dueToSellerAtClosing8_2;
        public decimal? DueToSellerAtClosing8_2 { get => _dueToSellerAtClosing8_2; set => _dueToSellerAtClosing8_2 = value; }
        private DirtyValue<bool?> _excludeBorrowerClosingCosts;
        public bool? ExcludeBorrowerClosingCosts { get => _excludeBorrowerClosingCosts; set => _excludeBorrowerClosingCosts = value; }
        private DirtyValue<decimal?> _finalCashToClose;
        public decimal? FinalCashToClose { get => _finalCashToClose; set => _finalCashToClose = value; }
        private DirtyValue<string> _fromToBorrower;
        public string FromToBorrower { get => _fromToBorrower; set => _fromToBorrower = value; }
        private DirtyValue<string> _fromToSeller;
        public string FromToSeller { get => _fromToSeller; set => _fromToSeller = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _lECD3CashToClose;
        public decimal? LECD3CashToClose { get => _lECD3CashToClose; set => _lECD3CashToClose = value; }
        private DirtyValue<string> _lECD3CashToCloseFromToBorrower;
        public string LECD3CashToCloseFromToBorrower { get => _lECD3CashToCloseFromToBorrower; set => _lECD3CashToCloseFromToBorrower = value; }
        private DirtyValue<decimal?> _lECD3ClosingCostsPaidBeforeClosing;
        public decimal? LECD3ClosingCostsPaidBeforeClosing { get => _lECD3ClosingCostsPaidBeforeClosing; set => _lECD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _lECD3TotalClosingCost_J;
        public decimal? LECD3TotalClosingCost_J { get => _lECD3TotalClosingCost_J; set => _lECD3TotalClosingCost_J = value; }
        private DirtyValue<decimal?> _lECD3TotalPayoffsAndPayments_K;
        public decimal? LECD3TotalPayoffsAndPayments_K { get => _lECD3TotalPayoffsAndPayments_K; set => _lECD3TotalPayoffsAndPayments_K = value; }
        private DirtyValue<decimal?> _lELoanAmount;
        public decimal? LELoanAmount { get => _lELoanAmount; set => _lELoanAmount = value; }
        private DirtyValue<decimal?> _liabilityAmount1;
        public decimal? LiabilityAmount1 { get => _liabilityAmount1; set => _liabilityAmount1 = value; }
        private DirtyValue<decimal?> _liabilityAmount10;
        public decimal? LiabilityAmount10 { get => _liabilityAmount10; set => _liabilityAmount10 = value; }
        private DirtyValue<decimal?> _liabilityAmount11;
        public decimal? LiabilityAmount11 { get => _liabilityAmount11; set => _liabilityAmount11 = value; }
        private DirtyValue<decimal?> _liabilityAmount12;
        public decimal? LiabilityAmount12 { get => _liabilityAmount12; set => _liabilityAmount12 = value; }
        private DirtyValue<decimal?> _liabilityAmount13;
        public decimal? LiabilityAmount13 { get => _liabilityAmount13; set => _liabilityAmount13 = value; }
        private DirtyValue<decimal?> _liabilityAmount14;
        public decimal? LiabilityAmount14 { get => _liabilityAmount14; set => _liabilityAmount14 = value; }
        private DirtyValue<decimal?> _liabilityAmount15;
        public decimal? LiabilityAmount15 { get => _liabilityAmount15; set => _liabilityAmount15 = value; }
        private DirtyValue<decimal?> _liabilityAmount2;
        public decimal? LiabilityAmount2 { get => _liabilityAmount2; set => _liabilityAmount2 = value; }
        private DirtyValue<decimal?> _liabilityAmount3;
        public decimal? LiabilityAmount3 { get => _liabilityAmount3; set => _liabilityAmount3 = value; }
        private DirtyValue<decimal?> _liabilityAmount4;
        public decimal? LiabilityAmount4 { get => _liabilityAmount4; set => _liabilityAmount4 = value; }
        private DirtyValue<decimal?> _liabilityAmount5;
        public decimal? LiabilityAmount5 { get => _liabilityAmount5; set => _liabilityAmount5 = value; }
        private DirtyValue<decimal?> _liabilityAmount6;
        public decimal? LiabilityAmount6 { get => _liabilityAmount6; set => _liabilityAmount6 = value; }
        private DirtyValue<decimal?> _liabilityAmount7;
        public decimal? LiabilityAmount7 { get => _liabilityAmount7; set => _liabilityAmount7 = value; }
        private DirtyValue<decimal?> _liabilityAmount8;
        public decimal? LiabilityAmount8 { get => _liabilityAmount8; set => _liabilityAmount8 = value; }
        private DirtyValue<decimal?> _liabilityAmount9;
        public decimal? LiabilityAmount9 { get => _liabilityAmount9; set => _liabilityAmount9 = value; }
        private DirtyValue<string> _liabilityTo1;
        public string LiabilityTo1 { get => _liabilityTo1; set => _liabilityTo1 = value; }
        private DirtyValue<string> _liabilityTo10;
        public string LiabilityTo10 { get => _liabilityTo10; set => _liabilityTo10 = value; }
        private DirtyValue<string> _liabilityTo11;
        public string LiabilityTo11 { get => _liabilityTo11; set => _liabilityTo11 = value; }
        private DirtyValue<string> _liabilityTo12;
        public string LiabilityTo12 { get => _liabilityTo12; set => _liabilityTo12 = value; }
        private DirtyValue<string> _liabilityTo13;
        public string LiabilityTo13 { get => _liabilityTo13; set => _liabilityTo13 = value; }
        private DirtyValue<string> _liabilityTo14;
        public string LiabilityTo14 { get => _liabilityTo14; set => _liabilityTo14 = value; }
        private DirtyValue<string> _liabilityTo15;
        public string LiabilityTo15 { get => _liabilityTo15; set => _liabilityTo15 = value; }
        private DirtyValue<string> _liabilityTo2;
        public string LiabilityTo2 { get => _liabilityTo2; set => _liabilityTo2 = value; }
        private DirtyValue<string> _liabilityTo3;
        public string LiabilityTo3 { get => _liabilityTo3; set => _liabilityTo3 = value; }
        private DirtyValue<string> _liabilityTo4;
        public string LiabilityTo4 { get => _liabilityTo4; set => _liabilityTo4 = value; }
        private DirtyValue<string> _liabilityTo5;
        public string LiabilityTo5 { get => _liabilityTo5; set => _liabilityTo5 = value; }
        private DirtyValue<string> _liabilityTo6;
        public string LiabilityTo6 { get => _liabilityTo6; set => _liabilityTo6 = value; }
        private DirtyValue<string> _liabilityTo7;
        public string LiabilityTo7 { get => _liabilityTo7; set => _liabilityTo7 = value; }
        private DirtyValue<string> _liabilityTo8;
        public string LiabilityTo8 { get => _liabilityTo8; set => _liabilityTo8 = value; }
        private DirtyValue<string> _liabilityTo9;
        public string LiabilityTo9 { get => _liabilityTo9; set => _liabilityTo9 = value; }
        private DirtyValue<decimal?> _liabilityTotal;
        public decimal? LiabilityTotal { get => _liabilityTotal; set => _liabilityTotal = value; }
        private DirtyValue<decimal?> _loanAmount;
        public decimal? LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        private DirtyValue<decimal?> _nonUCDTotalAdjustmentsAndOtherCredits;
        public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get => _nonUCDTotalAdjustmentsAndOtherCredits; set => _nonUCDTotalAdjustmentsAndOtherCredits = value; }
        private DirtyValue<bool?> _omitFromPrintSellersTransaction;
        public bool? OmitFromPrintSellersTransaction { get => _omitFromPrintSellersTransaction; set => _omitFromPrintSellersTransaction = value; }
        private DirtyValue<string> _otherCredits6_1;
        public string OtherCredits6_1 { get => _otherCredits6_1; set => _otherCredits6_1 = value; }
        private DirtyValue<decimal?> _otherCredits6_2;
        public decimal? OtherCredits6_2 { get => _otherCredits6_2; set => _otherCredits6_2 = value; }
        private DirtyValue<string> _otherCredits7_1;
        public string OtherCredits7_1 { get => _otherCredits7_1; set => _otherCredits7_1 = value; }
        private DirtyValue<decimal?> _otherCredits7_2;
        public decimal? OtherCredits7_2 { get => _otherCredits7_2; set => _otherCredits7_2 = value; }
        private DirtyValue<decimal?> _priorToleranceCureAmount;
        public decimal? PriorToleranceCureAmount { get => _priorToleranceCureAmount; set => _priorToleranceCureAmount = value; }
        private DirtyValue<StringEnumValue<STDAdjustmentAndOtherCreditsRemark>> _sTDAdjustmentAndOtherCreditsRemark;
        public StringEnumValue<STDAdjustmentAndOtherCreditsRemark> STDAdjustmentAndOtherCreditsRemark { get => _sTDAdjustmentAndOtherCreditsRemark; set => _sTDAdjustmentAndOtherCreditsRemark = value; }
        private DirtyValue<string> _sTDAdjustmentsDidChangeCol;
        public string STDAdjustmentsDidChangeCol { get => _sTDAdjustmentsDidChangeCol; set => _sTDAdjustmentsDidChangeCol = value; }
        private DirtyValue<string> _sTDClosingCostFinancedDidChangeCol;
        public string STDClosingCostFinancedDidChangeCol { get => _sTDClosingCostFinancedDidChangeCol; set => _sTDClosingCostFinancedDidChangeCol = value; }
        private DirtyValue<string> _sTDDepositDidChangeCol;
        public string STDDepositDidChangeCol { get => _sTDDepositDidChangeCol; set => _sTDDepositDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDepositIncDecRemark;
        public StringEnumValue<IncreasedOrDecreased> STDDepositIncDecRemark { get => _sTDDepositIncDecRemark; set => _sTDDepositIncDecRemark = value; }
        private DirtyValue<string> _sTDDownPaymentDidChangeCol;
        public string STDDownPaymentDidChangeCol { get => _sTDDownPaymentDidChangeCol; set => _sTDDownPaymentDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDDownPaymentIncDecRemark;
        public StringEnumValue<IncreasedOrDecreased> STDDownPaymentIncDecRemark { get => _sTDDownPaymentIncDecRemark; set => _sTDDownPaymentIncDecRemark = value; }
        private DirtyValue<StringEnumValue<STDDownPaymentSectionRemark>> _sTDDownPaymentSectionRemark;
        public StringEnumValue<STDDownPaymentSectionRemark> STDDownPaymentSectionRemark { get => _sTDDownPaymentSectionRemark; set => _sTDDownPaymentSectionRemark = value; }
        private DirtyValue<decimal?> _sTDFinalAdjustmentAndOtherCredits;
        public decimal? STDFinalAdjustmentAndOtherCredits { get => _sTDFinalAdjustmentAndOtherCredits; set => _sTDFinalAdjustmentAndOtherCredits = value; }
        private DirtyValue<decimal?> _sTDFinalCashToClose;
        public decimal? STDFinalCashToClose { get => _sTDFinalCashToClose; set => _sTDFinalCashToClose = value; }
        private DirtyValue<decimal?> _sTDFinalCD3ClosingCostsPaidBeforeClosing;
        public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get => _sTDFinalCD3ClosingCostsPaidBeforeClosing; set => _sTDFinalCD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _sTDFinalClosingCostFinanced;
        public decimal? STDFinalClosingCostFinanced { get => _sTDFinalClosingCostFinanced; set => _sTDFinalClosingCostFinanced = value; }
        private DirtyValue<decimal?> _sTDFinalDeposit;
        public decimal? STDFinalDeposit { get => _sTDFinalDeposit; set => _sTDFinalDeposit = value; }
        private DirtyValue<decimal?> _sTDFinalDownPayment;
        public decimal? STDFinalDownPayment { get => _sTDFinalDownPayment; set => _sTDFinalDownPayment = value; }
        private DirtyValue<decimal?> _sTDFinalFundForBorrower;
        public decimal? STDFinalFundForBorrower { get => _sTDFinalFundForBorrower; set => _sTDFinalFundForBorrower = value; }
        private DirtyValue<decimal?> _sTDFinalSellerCredits;
        public decimal? STDFinalSellerCredits { get => _sTDFinalSellerCredits; set => _sTDFinalSellerCredits = value; }
        private DirtyValue<decimal?> _sTDFinalTotalClosingCostJ;
        public decimal? STDFinalTotalClosingCostJ { get => _sTDFinalTotalClosingCostJ; set => _sTDFinalTotalClosingCostJ = value; }
        private DirtyValue<string> _sTDFundsForBorrowerDidChangeCol;
        public string STDFundsForBorrowerDidChangeCol { get => _sTDFundsForBorrowerDidChangeCol; set => _sTDFundsForBorrowerDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDFundsForBorrowerIncDecRemark;
        public StringEnumValue<IncreasedOrDecreased> STDFundsForBorrowerIncDecRemark { get => _sTDFundsForBorrowerIncDecRemark; set => _sTDFundsForBorrowerIncDecRemark = value; }
        private DirtyValue<decimal?> _sTDLEAdjustmentAndOtherCredits;
        public decimal? STDLEAdjustmentAndOtherCredits { get => _sTDLEAdjustmentAndOtherCredits; set => _sTDLEAdjustmentAndOtherCredits = value; }
        private DirtyValue<decimal?> _sTDLECashToClose;
        public decimal? STDLECashToClose { get => _sTDLECashToClose; set => _sTDLECashToClose = value; }
        private DirtyValue<decimal?> _sTDLECD3ClosingCostsPaidBeforeClosing;
        public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get => _sTDLECD3ClosingCostsPaidBeforeClosing; set => _sTDLECD3ClosingCostsPaidBeforeClosing = value; }
        private DirtyValue<decimal?> _sTDLEClosingCostFinanced;
        public decimal? STDLEClosingCostFinanced { get => _sTDLEClosingCostFinanced; set => _sTDLEClosingCostFinanced = value; }
        private DirtyValue<decimal?> _sTDLEDeposit;
        public decimal? STDLEDeposit { get => _sTDLEDeposit; set => _sTDLEDeposit = value; }
        private DirtyValue<decimal?> _sTDLEDownPayment;
        public decimal? STDLEDownPayment { get => _sTDLEDownPayment; set => _sTDLEDownPayment = value; }
        private DirtyValue<decimal?> _sTDLEFundForBorrower;
        public decimal? STDLEFundForBorrower { get => _sTDLEFundForBorrower; set => _sTDLEFundForBorrower = value; }
        private DirtyValue<decimal?> _sTDLegalLimit;
        public decimal? STDLegalLimit { get => _sTDLegalLimit; set => _sTDLegalLimit = value; }
        private DirtyValue<decimal?> _sTDLESellerCredits;
        public decimal? STDLESellerCredits { get => _sTDLESellerCredits; set => _sTDLESellerCredits = value; }
        private DirtyValue<decimal?> _sTDLETotalClosingCostJ;
        public decimal? STDLETotalClosingCostJ { get => _sTDLETotalClosingCostJ; set => _sTDLETotalClosingCostJ = value; }
        private DirtyValue<string> _sTDSellerCreditsDidChangeCol;
        public string STDSellerCreditsDidChangeCol { get => _sTDSellerCreditsDidChangeCol; set => _sTDSellerCreditsDidChangeCol = value; }
        private DirtyValue<StringEnumValue<IncreasedOrDecreased>> _sTDSellerCreditsIncDecRemark;
        public StringEnumValue<IncreasedOrDecreased> STDSellerCreditsIncDecRemark { get => _sTDSellerCreditsIncDecRemark; set => _sTDSellerCreditsIncDecRemark = value; }
        private DirtyValue<string> _sTDTotalClosingCostBeforeClosingDidChangeCol;
        public string STDTotalClosingCostBeforeClosingDidChangeCol { get => _sTDTotalClosingCostBeforeClosingDidChangeCol; set => _sTDTotalClosingCostBeforeClosingDidChangeCol = value; }
        private DirtyValue<string> _sTDTotalClosingCostDidChangeCol;
        public string STDTotalClosingCostDidChangeCol { get => _sTDTotalClosingCostDidChangeCol; set => _sTDTotalClosingCostDidChangeCol = value; }
        private DirtyValue<StringEnumValue<TotalClosingCostRemark>> _sTDTotalClosingCostRemark;
        public StringEnumValue<TotalClosingCostRemark> STDTotalClosingCostRemark { get => _sTDTotalClosingCostRemark; set => _sTDTotalClosingCostRemark = value; }
        private DirtyValue<decimal?> _totalAdjustmentsAndOtherCredits;
        public decimal? TotalAdjustmentsAndOtherCredits { get => _totalAdjustmentsAndOtherCredits; set => _totalAdjustmentsAndOtherCredits = value; }
        private DirtyValue<decimal?> _totalDuefromBorrowerAtClosing;
        public decimal? TotalDuefromBorrowerAtClosing { get => _totalDuefromBorrowerAtClosing; set => _totalDuefromBorrowerAtClosing = value; }
        private DirtyValue<decimal?> _totalDuefromSelleratClosing_N;
        public decimal? TotalDuefromSelleratClosing_N { get => _totalDuefromSelleratClosing_N; set => _totalDuefromSelleratClosing_N = value; }
        private DirtyValue<decimal?> _totalDuetoSelleratClosing_M;
        public decimal? TotalDuetoSelleratClosing_M { get => _totalDuetoSelleratClosing_M; set => _totalDuetoSelleratClosing_M = value; }
        private DirtyValue<decimal?> _totalFromK;
        public decimal? TotalFromK { get => _totalFromK; set => _totalFromK = value; }
        private DirtyValue<decimal?> _totalFromL;
        public decimal? TotalFromL { get => _totalFromL; set => _totalFromL = value; }
        private DirtyValue<decimal?> _totalFromM;
        public decimal? TotalFromM { get => _totalFromM; set => _totalFromM = value; }
        private DirtyValue<decimal?> _totalFromN;
        public decimal? TotalFromN { get => _totalFromN; set => _totalFromN = value; }
        private DirtyValue<decimal?> _totalPaidAlreadybyoronBehalfofBoroweratClosing;
        public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get => _totalPaidAlreadybyoronBehalfofBoroweratClosing; set => _totalPaidAlreadybyoronBehalfofBoroweratClosing = value; }
        private DirtyList<UCDDetail> _uCDDetails;
        public IList<UCDDetail> UCDDetails { get => _uCDDetails ?? (_uCDDetails = new DirtyList<UCDDetail>()); set => _uCDDetails = new DirtyList<UCDDetail>(value); }
        private DirtyValue<decimal?> _uCDKSubTotal;
        public decimal? UCDKSubTotal { get => _uCDKSubTotal; set => _uCDKSubTotal = value; }
        private DirtyValue<decimal?> _uCDLSubTotal;
        public decimal? UCDLSubTotal { get => _uCDLSubTotal; set => _uCDLSubTotal = value; }
        private DirtyValue<decimal?> _uCDTotalAdjustmentsAndOtherCredits;
        public decimal? UCDTotalAdjustmentsAndOtherCredits { get => _uCDTotalAdjustmentsAndOtherCredits; set => _uCDTotalAdjustmentsAndOtherCredits = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _actualLECD3TotalClosingCostJFromLatestRec.Dirty
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
                    || _adjustments06_1.Dirty
                    || _adjustments06_2.Dirty
                    || _adjustments07_1.Dirty
                    || _adjustments07_2.Dirty
                    || _adjustments10_1.Dirty
                    || _adjustments10_2.Dirty
                    || _adjustments11_1.Dirty
                    || _adjustments11_2.Dirty
                    || _adjustments15_1.Dirty
                    || _adjustments15_2.Dirty
                    || _adjustments8_1.Dirty
                    || _adjustments8_2.Dirty
                    || _adjustments9_1.Dirty
                    || _adjustments9_2.Dirty
                    || _adjustmentsforItemsPaidbySellerinAdvance16_1.Dirty
                    || _adjustmentsforItemsPaidbySellerinAdvance16_2.Dirty
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
                    || _cD3TotalClosingCost_J.Dirty
                    || _cD3TotalPayoffsAndPayments_K.Dirty
                    || _closingCostsPaidAtClosing.Dirty
                    || _closingCostsPaidatClosing_J.Dirty
                    || _duefromSelleratClosing11_1.Dirty
                    || _duefromSelleratClosing11_2.Dirty
                    || _duefromSelleratClosing12_1.Dirty
                    || _duefromSelleratClosing12_2.Dirty
                    || _duefromSelleratClosing13_1.Dirty
                    || _duefromSelleratClosing13_2.Dirty
                    || _dueToSellerAtClosing6_1.Dirty
                    || _dueToSellerAtClosing6_2.Dirty
                    || _dueToSellerAtClosing7_1.Dirty
                    || _dueToSellerAtClosing7_2.Dirty
                    || _dueToSellerAtClosing8_1.Dirty
                    || _dueToSellerAtClosing8_2.Dirty
                    || _excludeBorrowerClosingCosts.Dirty
                    || _finalCashToClose.Dirty
                    || _fromToBorrower.Dirty
                    || _fromToSeller.Dirty
                    || _id.Dirty
                    || _lECD3CashToClose.Dirty
                    || _lECD3CashToCloseFromToBorrower.Dirty
                    || _lECD3ClosingCostsPaidBeforeClosing.Dirty
                    || _lECD3TotalClosingCost_J.Dirty
                    || _lECD3TotalPayoffsAndPayments_K.Dirty
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
                    || _otherCredits6_1.Dirty
                    || _otherCredits6_2.Dirty
                    || _otherCredits7_1.Dirty
                    || _otherCredits7_2.Dirty
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
                    || _totalDuefromSelleratClosing_N.Dirty
                    || _totalDuetoSelleratClosing_M.Dirty
                    || _totalFromK.Dirty
                    || _totalFromL.Dirty
                    || _totalFromM.Dirty
                    || _totalFromN.Dirty
                    || _totalPaidAlreadybyoronBehalfofBoroweratClosing.Dirty
                    || _uCDKSubTotal.Dirty
                    || _uCDLSubTotal.Dirty
                    || _uCDTotalAdjustmentsAndOtherCredits.Dirty
                    || _uCDDetails?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                _adjustments06_1.Dirty = value;
                _adjustments06_2.Dirty = value;
                _adjustments07_1.Dirty = value;
                _adjustments07_2.Dirty = value;
                _adjustments10_1.Dirty = value;
                _adjustments10_2.Dirty = value;
                _adjustments11_1.Dirty = value;
                _adjustments11_2.Dirty = value;
                _adjustments15_1.Dirty = value;
                _adjustments15_2.Dirty = value;
                _adjustments8_1.Dirty = value;
                _adjustments8_2.Dirty = value;
                _adjustments9_1.Dirty = value;
                _adjustments9_2.Dirty = value;
                _adjustmentsforItemsPaidbySellerinAdvance16_1.Dirty = value;
                _adjustmentsforItemsPaidbySellerinAdvance16_2.Dirty = value;
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
                _cD3TotalClosingCost_J.Dirty = value;
                _cD3TotalPayoffsAndPayments_K.Dirty = value;
                _closingCostsPaidAtClosing.Dirty = value;
                _closingCostsPaidatClosing_J.Dirty = value;
                _duefromSelleratClosing11_1.Dirty = value;
                _duefromSelleratClosing11_2.Dirty = value;
                _duefromSelleratClosing12_1.Dirty = value;
                _duefromSelleratClosing12_2.Dirty = value;
                _duefromSelleratClosing13_1.Dirty = value;
                _duefromSelleratClosing13_2.Dirty = value;
                _dueToSellerAtClosing6_1.Dirty = value;
                _dueToSellerAtClosing6_2.Dirty = value;
                _dueToSellerAtClosing7_1.Dirty = value;
                _dueToSellerAtClosing7_2.Dirty = value;
                _dueToSellerAtClosing8_1.Dirty = value;
                _dueToSellerAtClosing8_2.Dirty = value;
                _excludeBorrowerClosingCosts.Dirty = value;
                _finalCashToClose.Dirty = value;
                _fromToBorrower.Dirty = value;
                _fromToSeller.Dirty = value;
                _id.Dirty = value;
                _lECD3CashToClose.Dirty = value;
                _lECD3CashToCloseFromToBorrower.Dirty = value;
                _lECD3ClosingCostsPaidBeforeClosing.Dirty = value;
                _lECD3TotalClosingCost_J.Dirty = value;
                _lECD3TotalPayoffsAndPayments_K.Dirty = value;
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
                _otherCredits6_1.Dirty = value;
                _otherCredits6_2.Dirty = value;
                _otherCredits7_1.Dirty = value;
                _otherCredits7_2.Dirty = value;
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
                _totalDuefromSelleratClosing_N.Dirty = value;
                _totalDuetoSelleratClosing_M.Dirty = value;
                _totalFromK.Dirty = value;
                _totalFromL.Dirty = value;
                _totalFromM.Dirty = value;
                _totalFromN.Dirty = value;
                _totalPaidAlreadybyoronBehalfofBoroweratClosing.Dirty = value;
                _uCDKSubTotal.Dirty = value;
                _uCDLSubTotal.Dirty = value;
                _uCDTotalAdjustmentsAndOtherCredits.Dirty = value;
                if (_uCDDetails != null) _uCDDetails.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}