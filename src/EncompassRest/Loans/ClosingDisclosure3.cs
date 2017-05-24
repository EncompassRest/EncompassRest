using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure3
    {
        public Value<decimal?> ActualLECD3TotalClosingCostJFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualLECD3TotalClosingCostJFromLatestRec() => !ActualLECD3TotalClosingCostJFromLatestRec.Clean;
        public Value<decimal?> ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualLECD3TotalPayoffsAndPaymentsKFromLatestRec() => !ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Clean;
        public Value<decimal?> ActualLELoanAmountFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualLELoanAmountFromLatestRec() => !ActualLELoanAmountFromLatestRec.Clean;
        public Value<decimal?> ActualLenderCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualLenderCredits() => !ActualLenderCredits.Clean;
        public Value<decimal?> ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLEAdjustmentAndOtherCreditsFromLatestRec() => !ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLEClosingCostFinancedFromLatestRec() => !ActualSTDLEClosingCostFinancedFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLEDepositFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLEDepositFromLatestRec() => !ActualSTDLEDepositFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLEDownPaymentFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLEDownPaymentFromLatestRec() => !ActualSTDLEDownPaymentFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLEFundForBorrowerFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLEFundForBorrowerFromLatestRec() => !ActualSTDLEFundForBorrowerFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLESellerCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLESellerCredits() => !ActualSTDLESellerCredits.Clean;
        public Value<decimal?> ActualSTDLESellerCreditsFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLESellerCreditsFromLatestRec() => !ActualSTDLESellerCreditsFromLatestRec.Clean;
        public Value<decimal?> ActualSTDLETotalClosingCostJ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLETotalClosingCostJ() => !ActualSTDLETotalClosingCostJ.Clean;
        public Value<decimal?> ActualSTDLETotalClosingCostJFromLatestRec { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeActualSTDLETotalClosingCostJFromLatestRec() => !ActualSTDLETotalClosingCostJFromLatestRec.Clean;
        public Value<string> Adjustments06_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments06_1() => !Adjustments06_1.Clean;
        public Value<decimal?> Adjustments06_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments06_2() => !Adjustments06_2.Clean;
        public Value<string> Adjustments07_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments07_1() => !Adjustments07_1.Clean;
        public Value<decimal?> Adjustments07_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments07_2() => !Adjustments07_2.Clean;
        public Value<string> Adjustments10_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments10_1() => !Adjustments10_1.Clean;
        public Value<decimal?> Adjustments10_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments10_2() => !Adjustments10_2.Clean;
        public Value<string> Adjustments11_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments11_1() => !Adjustments11_1.Clean;
        public Value<decimal?> Adjustments11_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments11_2() => !Adjustments11_2.Clean;
        public Value<string> Adjustments15_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments15_1() => !Adjustments15_1.Clean;
        public Value<decimal?> Adjustments15_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments15_2() => !Adjustments15_2.Clean;
        public Value<string> Adjustments8_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments8_1() => !Adjustments8_1.Clean;
        public Value<decimal?> Adjustments8_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments8_2() => !Adjustments8_2.Clean;
        public Value<string> Adjustments9_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments9_1() => !Adjustments9_1.Clean;
        public Value<decimal?> Adjustments9_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustments9_2() => !Adjustments9_2.Clean;
        public Value<string> AdjustmentsforItemsPaidbySellerinAdvance16_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsforItemsPaidbySellerinAdvance16_1() => !AdjustmentsforItemsPaidbySellerinAdvance16_1.Clean;
        public Value<decimal?> AdjustmentsforItemsPaidbySellerinAdvance16_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentsforItemsPaidbySellerinAdvance16_2() => !AdjustmentsforItemsPaidbySellerinAdvance16_2.Clean;
        public Value<string> ALTCashToCloseDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTCashToCloseDidChangeCol() => !ALTCashToCloseDidChangeCol.Clean;
        public Value<decimal?> ALTCashToCloseRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTCashToCloseRemark() => !ALTCashToCloseRemark.Clean;
        public Value<string> ALTClosingCostBeforeClosingDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTClosingCostBeforeClosingDidChangeCol() => !ALTClosingCostBeforeClosingDidChangeCol.Clean;
        public Value<decimal?> ALTLegalLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTLegalLimit() => !ALTLegalLimit.Clean;
        public Value<string> ALTLoanAmountDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTLoanAmountDidChangeCol() => !ALTLoanAmountDidChangeCol.Clean;
        public Value<string> ALTLoanAmountIncDecRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTLoanAmountIncDecRemark() => !ALTLoanAmountIncDecRemark.Clean;
        public Value<string> ALTTotalClosingCostDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTTotalClosingCostDidChangeCol() => !ALTTotalClosingCostDidChangeCol.Clean;
        public Value<string> ALTTotalClosingCostRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTTotalClosingCostRemark() => !ALTTotalClosingCostRemark.Clean;
        public Value<string> ALTTotalPayoffsDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeALTTotalPayoffsDidChangeCol() => !ALTTotalPayoffsDidChangeCol.Clean;
        public Value<decimal?> Cash { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCash() => !Cash.Clean;
        public Value<decimal?> CashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashToClose() => !CashToClose.Clean;
        public Value<decimal?> CD3CashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD3CashToClose() => !CD3CashToClose.Clean;
        public Value<string> CD3CashToCloseFromToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD3CashToCloseFromToBorrower() => !CD3CashToCloseFromToBorrower.Clean;
        public Value<decimal?> CD3ClosingCostsPaidBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD3ClosingCostsPaidBeforeClosing() => !CD3ClosingCostsPaidBeforeClosing.Clean;
        public Value<decimal?> CD3TotalClosingCost_J { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD3TotalClosingCost_J() => !CD3TotalClosingCost_J.Clean;
        public Value<decimal?> CD3TotalPayoffsAndPayments_K { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCD3TotalPayoffsAndPayments_K() => !CD3TotalPayoffsAndPayments_K.Clean;
        public Value<decimal?> ClosingCostsPaidAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostsPaidAtClosing() => !ClosingCostsPaidAtClosing.Clean;
        public Value<decimal?> ClosingCostsPaidatClosing_J { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostsPaidatClosing_J() => !ClosingCostsPaidatClosing_J.Clean;
        public Value<string> DuefromSelleratClosing11_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing11_1() => !DuefromSelleratClosing11_1.Clean;
        public Value<decimal?> DuefromSelleratClosing11_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing11_2() => !DuefromSelleratClosing11_2.Clean;
        public Value<string> DuefromSelleratClosing12_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing12_1() => !DuefromSelleratClosing12_1.Clean;
        public Value<decimal?> DuefromSelleratClosing12_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing12_2() => !DuefromSelleratClosing12_2.Clean;
        public Value<string> DuefromSelleratClosing13_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing13_1() => !DuefromSelleratClosing13_1.Clean;
        public Value<decimal?> DuefromSelleratClosing13_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDuefromSelleratClosing13_2() => !DuefromSelleratClosing13_2.Clean;
        public Value<string> DueToSellerAtClosing6_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing6_1() => !DueToSellerAtClosing6_1.Clean;
        public Value<decimal?> DueToSellerAtClosing6_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing6_2() => !DueToSellerAtClosing6_2.Clean;
        public Value<string> DueToSellerAtClosing7_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing7_1() => !DueToSellerAtClosing7_1.Clean;
        public Value<decimal?> DueToSellerAtClosing7_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing7_2() => !DueToSellerAtClosing7_2.Clean;
        public Value<string> DueToSellerAtClosing8_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing8_1() => !DueToSellerAtClosing8_1.Clean;
        public Value<decimal?> DueToSellerAtClosing8_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDueToSellerAtClosing8_2() => !DueToSellerAtClosing8_2.Clean;
        public Value<bool?> ExcludeBorrowerClosingCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeExcludeBorrowerClosingCosts() => !ExcludeBorrowerClosingCosts.Clean;
        public Value<decimal?> FinalCashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalCashToClose() => !FinalCashToClose.Clean;
        public Value<string> FromToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFromToBorrower() => !FromToBorrower.Clean;
        public Value<string> FromToSeller { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFromToSeller() => !FromToSeller.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> LECD3CashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLECD3CashToClose() => !LECD3CashToClose.Clean;
        public Value<string> LECD3CashToCloseFromToBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLECD3CashToCloseFromToBorrower() => !LECD3CashToCloseFromToBorrower.Clean;
        public Value<decimal?> LECD3ClosingCostsPaidBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLECD3ClosingCostsPaidBeforeClosing() => !LECD3ClosingCostsPaidBeforeClosing.Clean;
        public Value<decimal?> LECD3TotalClosingCost_J { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLECD3TotalClosingCost_J() => !LECD3TotalClosingCost_J.Clean;
        public Value<decimal?> LECD3TotalPayoffsAndPayments_K { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLECD3TotalPayoffsAndPayments_K() => !LECD3TotalPayoffsAndPayments_K.Clean;
        public Value<decimal?> LELoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLELoanAmount() => !LELoanAmount.Clean;
        public Value<decimal?> LiabilityAmount1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount1() => !LiabilityAmount1.Clean;
        public Value<decimal?> LiabilityAmount10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount10() => !LiabilityAmount10.Clean;
        public Value<decimal?> LiabilityAmount11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount11() => !LiabilityAmount11.Clean;
        public Value<decimal?> LiabilityAmount12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount12() => !LiabilityAmount12.Clean;
        public Value<decimal?> LiabilityAmount13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount13() => !LiabilityAmount13.Clean;
        public Value<decimal?> LiabilityAmount14 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount14() => !LiabilityAmount14.Clean;
        public Value<decimal?> LiabilityAmount15 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount15() => !LiabilityAmount15.Clean;
        public Value<decimal?> LiabilityAmount2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount2() => !LiabilityAmount2.Clean;
        public Value<decimal?> LiabilityAmount3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount3() => !LiabilityAmount3.Clean;
        public Value<decimal?> LiabilityAmount4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount4() => !LiabilityAmount4.Clean;
        public Value<decimal?> LiabilityAmount5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount5() => !LiabilityAmount5.Clean;
        public Value<decimal?> LiabilityAmount6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount6() => !LiabilityAmount6.Clean;
        public Value<decimal?> LiabilityAmount7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount7() => !LiabilityAmount7.Clean;
        public Value<decimal?> LiabilityAmount8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount8() => !LiabilityAmount8.Clean;
        public Value<decimal?> LiabilityAmount9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityAmount9() => !LiabilityAmount9.Clean;
        public Value<string> LiabilityTo1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo1() => !LiabilityTo1.Clean;
        public Value<string> LiabilityTo10 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo10() => !LiabilityTo10.Clean;
        public Value<string> LiabilityTo11 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo11() => !LiabilityTo11.Clean;
        public Value<string> LiabilityTo12 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo12() => !LiabilityTo12.Clean;
        public Value<string> LiabilityTo13 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo13() => !LiabilityTo13.Clean;
        public Value<string> LiabilityTo14 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo14() => !LiabilityTo14.Clean;
        public Value<string> LiabilityTo15 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo15() => !LiabilityTo15.Clean;
        public Value<string> LiabilityTo2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo2() => !LiabilityTo2.Clean;
        public Value<string> LiabilityTo3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo3() => !LiabilityTo3.Clean;
        public Value<string> LiabilityTo4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo4() => !LiabilityTo4.Clean;
        public Value<string> LiabilityTo5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo5() => !LiabilityTo5.Clean;
        public Value<string> LiabilityTo6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo6() => !LiabilityTo6.Clean;
        public Value<string> LiabilityTo7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo7() => !LiabilityTo7.Clean;
        public Value<string> LiabilityTo8 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo8() => !LiabilityTo8.Clean;
        public Value<string> LiabilityTo9 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTo9() => !LiabilityTo9.Clean;
        public Value<decimal?> LiabilityTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLiabilityTotal() => !LiabilityTotal.Clean;
        public Value<decimal?> LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !LoanAmount.Clean;
        public Value<decimal?> NonUCDTotalAdjustmentsAndOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonUCDTotalAdjustmentsAndOtherCredits() => !NonUCDTotalAdjustmentsAndOtherCredits.Clean;
        public Value<bool?> OmitFromPrintSellersTransaction { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOmitFromPrintSellersTransaction() => !OmitFromPrintSellersTransaction.Clean;
        public Value<string> OtherCredits6_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherCredits6_1() => !OtherCredits6_1.Clean;
        public Value<decimal?> OtherCredits6_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherCredits6_2() => !OtherCredits6_2.Clean;
        public Value<string> OtherCredits7_1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherCredits7_1() => !OtherCredits7_1.Clean;
        public Value<decimal?> OtherCredits7_2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherCredits7_2() => !OtherCredits7_2.Clean;
        public Value<decimal?> PriorToleranceCureAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePriorToleranceCureAmount() => !PriorToleranceCureAmount.Clean;
        public Value<string> STDAdjustmentAndOtherCreditsRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDAdjustmentAndOtherCreditsRemark() => !STDAdjustmentAndOtherCreditsRemark.Clean;
        public Value<string> STDAdjustmentsDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDAdjustmentsDidChangeCol() => !STDAdjustmentsDidChangeCol.Clean;
        public Value<string> STDClosingCostFinancedDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDClosingCostFinancedDidChangeCol() => !STDClosingCostFinancedDidChangeCol.Clean;
        public Value<string> STDDepositDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDDepositDidChangeCol() => !STDDepositDidChangeCol.Clean;
        public Value<string> STDDepositIncDecRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDDepositIncDecRemark() => !STDDepositIncDecRemark.Clean;
        public Value<string> STDDownPaymentDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDDownPaymentDidChangeCol() => !STDDownPaymentDidChangeCol.Clean;
        public Value<string> STDDownPaymentIncDecRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDDownPaymentIncDecRemark() => !STDDownPaymentIncDecRemark.Clean;
        public Value<string> STDDownPaymentSectionRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDDownPaymentSectionRemark() => !STDDownPaymentSectionRemark.Clean;
        public Value<decimal?> STDFinalAdjustmentAndOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalAdjustmentAndOtherCredits() => !STDFinalAdjustmentAndOtherCredits.Clean;
        public Value<decimal?> STDFinalCashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalCashToClose() => !STDFinalCashToClose.Clean;
        public Value<decimal?> STDFinalCD3ClosingCostsPaidBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalCD3ClosingCostsPaidBeforeClosing() => !STDFinalCD3ClosingCostsPaidBeforeClosing.Clean;
        public Value<decimal?> STDFinalClosingCostFinanced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalClosingCostFinanced() => !STDFinalClosingCostFinanced.Clean;
        public Value<decimal?> STDFinalDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalDeposit() => !STDFinalDeposit.Clean;
        public Value<decimal?> STDFinalDownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalDownPayment() => !STDFinalDownPayment.Clean;
        public Value<decimal?> STDFinalFundForBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalFundForBorrower() => !STDFinalFundForBorrower.Clean;
        public Value<decimal?> STDFinalSellerCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalSellerCredits() => !STDFinalSellerCredits.Clean;
        public Value<decimal?> STDFinalTotalClosingCostJ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFinalTotalClosingCostJ() => !STDFinalTotalClosingCostJ.Clean;
        public Value<string> STDFundsForBorrowerDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFundsForBorrowerDidChangeCol() => !STDFundsForBorrowerDidChangeCol.Clean;
        public Value<string> STDFundsForBorrowerIncDecRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDFundsForBorrowerIncDecRemark() => !STDFundsForBorrowerIncDecRemark.Clean;
        public Value<decimal?> STDLEAdjustmentAndOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLEAdjustmentAndOtherCredits() => !STDLEAdjustmentAndOtherCredits.Clean;
        public Value<decimal?> STDLECashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLECashToClose() => !STDLECashToClose.Clean;
        public Value<decimal?> STDLECD3ClosingCostsPaidBeforeClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLECD3ClosingCostsPaidBeforeClosing() => !STDLECD3ClosingCostsPaidBeforeClosing.Clean;
        public Value<decimal?> STDLEClosingCostFinanced { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLEClosingCostFinanced() => !STDLEClosingCostFinanced.Clean;
        public Value<decimal?> STDLEDeposit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLEDeposit() => !STDLEDeposit.Clean;
        public Value<decimal?> STDLEDownPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLEDownPayment() => !STDLEDownPayment.Clean;
        public Value<decimal?> STDLEFundForBorrower { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLEFundForBorrower() => !STDLEFundForBorrower.Clean;
        public Value<decimal?> STDLegalLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLegalLimit() => !STDLegalLimit.Clean;
        public Value<decimal?> STDLESellerCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLESellerCredits() => !STDLESellerCredits.Clean;
        public Value<decimal?> STDLETotalClosingCostJ { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDLETotalClosingCostJ() => !STDLETotalClosingCostJ.Clean;
        public Value<string> STDSellerCreditsDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDSellerCreditsDidChangeCol() => !STDSellerCreditsDidChangeCol.Clean;
        public Value<string> STDSellerCreditsIncDecRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDSellerCreditsIncDecRemark() => !STDSellerCreditsIncDecRemark.Clean;
        public Value<string> STDTotalClosingCostBeforeClosingDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDTotalClosingCostBeforeClosingDidChangeCol() => !STDTotalClosingCostBeforeClosingDidChangeCol.Clean;
        public Value<string> STDTotalClosingCostDidChangeCol { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDTotalClosingCostDidChangeCol() => !STDTotalClosingCostDidChangeCol.Clean;
        public Value<string> STDTotalClosingCostRemark { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSTDTotalClosingCostRemark() => !STDTotalClosingCostRemark.Clean;
        public Value<decimal?> TotalAdjustmentsAndOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalAdjustmentsAndOtherCredits() => !TotalAdjustmentsAndOtherCredits.Clean;
        public Value<decimal?> TotalDuefromBorrowerAtClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDuefromBorrowerAtClosing() => !TotalDuefromBorrowerAtClosing.Clean;
        public Value<decimal?> TotalDuefromSelleratClosing_N { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDuefromSelleratClosing_N() => !TotalDuefromSelleratClosing_N.Clean;
        public Value<decimal?> TotalDuetoSelleratClosing_M { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDuetoSelleratClosing_M() => !TotalDuetoSelleratClosing_M.Clean;
        public Value<decimal?> TotalFromK { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFromK() => !TotalFromK.Clean;
        public Value<decimal?> TotalFromL { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFromL() => !TotalFromL.Clean;
        public Value<decimal?> TotalFromM { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFromM() => !TotalFromM.Clean;
        public Value<decimal?> TotalFromN { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFromN() => !TotalFromN.Clean;
        public Value<decimal?> TotalPaidAlreadybyoronBehalfofBoroweratClosing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidAlreadybyoronBehalfofBoroweratClosing() => !TotalPaidAlreadybyoronBehalfofBoroweratClosing.Clean;
        public Value<List<UCDDetail>> UCDDetails { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDDetails() => !UCDDetails.Clean;
        public Value<decimal?> UCDKSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDKSubTotal() => !UCDKSubTotal.Clean;
        public Value<decimal?> UCDLSubTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDLSubTotal() => !UCDLSubTotal.Clean;
        public Value<decimal?> UCDTotalAdjustmentsAndOtherCredits { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUCDTotalAdjustmentsAndOtherCredits() => !UCDTotalAdjustmentsAndOtherCredits.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = ActualLECD3TotalClosingCostJFromLatestRec.Clean
                    && ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec.Clean
                    && ActualLELoanAmountFromLatestRec.Clean
                    && ActualLenderCredits.Clean
                    && ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec.Clean
                    && ActualSTDLEClosingCostFinancedFromLatestRec.Clean
                    && ActualSTDLEDepositFromLatestRec.Clean
                    && ActualSTDLEDownPaymentFromLatestRec.Clean
                    && ActualSTDLEFundForBorrowerFromLatestRec.Clean
                    && ActualSTDLESellerCredits.Clean
                    && ActualSTDLESellerCreditsFromLatestRec.Clean
                    && ActualSTDLETotalClosingCostJ.Clean
                    && ActualSTDLETotalClosingCostJFromLatestRec.Clean
                    && Adjustments06_1.Clean
                    && Adjustments06_2.Clean
                    && Adjustments07_1.Clean
                    && Adjustments07_2.Clean
                    && Adjustments10_1.Clean
                    && Adjustments10_2.Clean
                    && Adjustments11_1.Clean
                    && Adjustments11_2.Clean
                    && Adjustments15_1.Clean
                    && Adjustments15_2.Clean
                    && Adjustments8_1.Clean
                    && Adjustments8_2.Clean
                    && Adjustments9_1.Clean
                    && Adjustments9_2.Clean
                    && AdjustmentsforItemsPaidbySellerinAdvance16_1.Clean
                    && AdjustmentsforItemsPaidbySellerinAdvance16_2.Clean
                    && ALTCashToCloseDidChangeCol.Clean
                    && ALTCashToCloseRemark.Clean
                    && ALTClosingCostBeforeClosingDidChangeCol.Clean
                    && ALTLegalLimit.Clean
                    && ALTLoanAmountDidChangeCol.Clean
                    && ALTLoanAmountIncDecRemark.Clean
                    && ALTTotalClosingCostDidChangeCol.Clean
                    && ALTTotalClosingCostRemark.Clean
                    && ALTTotalPayoffsDidChangeCol.Clean
                    && Cash.Clean
                    && CashToClose.Clean
                    && CD3CashToClose.Clean
                    && CD3CashToCloseFromToBorrower.Clean
                    && CD3ClosingCostsPaidBeforeClosing.Clean
                    && CD3TotalClosingCost_J.Clean
                    && CD3TotalPayoffsAndPayments_K.Clean
                    && ClosingCostsPaidAtClosing.Clean
                    && ClosingCostsPaidatClosing_J.Clean
                    && DuefromSelleratClosing11_1.Clean
                    && DuefromSelleratClosing11_2.Clean
                    && DuefromSelleratClosing12_1.Clean
                    && DuefromSelleratClosing12_2.Clean
                    && DuefromSelleratClosing13_1.Clean
                    && DuefromSelleratClosing13_2.Clean
                    && DueToSellerAtClosing6_1.Clean
                    && DueToSellerAtClosing6_2.Clean
                    && DueToSellerAtClosing7_1.Clean
                    && DueToSellerAtClosing7_2.Clean
                    && DueToSellerAtClosing8_1.Clean
                    && DueToSellerAtClosing8_2.Clean
                    && ExcludeBorrowerClosingCosts.Clean
                    && FinalCashToClose.Clean
                    && FromToBorrower.Clean
                    && FromToSeller.Clean
                    && Id.Clean
                    && LECD3CashToClose.Clean
                    && LECD3CashToCloseFromToBorrower.Clean
                    && LECD3ClosingCostsPaidBeforeClosing.Clean
                    && LECD3TotalClosingCost_J.Clean
                    && LECD3TotalPayoffsAndPayments_K.Clean
                    && LELoanAmount.Clean
                    && LiabilityAmount1.Clean
                    && LiabilityAmount10.Clean
                    && LiabilityAmount11.Clean
                    && LiabilityAmount12.Clean
                    && LiabilityAmount13.Clean
                    && LiabilityAmount14.Clean
                    && LiabilityAmount15.Clean
                    && LiabilityAmount2.Clean
                    && LiabilityAmount3.Clean
                    && LiabilityAmount4.Clean
                    && LiabilityAmount5.Clean
                    && LiabilityAmount6.Clean
                    && LiabilityAmount7.Clean
                    && LiabilityAmount8.Clean
                    && LiabilityAmount9.Clean
                    && LiabilityTo1.Clean
                    && LiabilityTo10.Clean
                    && LiabilityTo11.Clean
                    && LiabilityTo12.Clean
                    && LiabilityTo13.Clean
                    && LiabilityTo14.Clean
                    && LiabilityTo15.Clean
                    && LiabilityTo2.Clean
                    && LiabilityTo3.Clean
                    && LiabilityTo4.Clean
                    && LiabilityTo5.Clean
                    && LiabilityTo6.Clean
                    && LiabilityTo7.Clean
                    && LiabilityTo8.Clean
                    && LiabilityTo9.Clean
                    && LiabilityTotal.Clean
                    && LoanAmount.Clean
                    && NonUCDTotalAdjustmentsAndOtherCredits.Clean
                    && OmitFromPrintSellersTransaction.Clean
                    && OtherCredits6_1.Clean
                    && OtherCredits6_2.Clean
                    && OtherCredits7_1.Clean
                    && OtherCredits7_2.Clean
                    && PriorToleranceCureAmount.Clean
                    && STDAdjustmentAndOtherCreditsRemark.Clean
                    && STDAdjustmentsDidChangeCol.Clean
                    && STDClosingCostFinancedDidChangeCol.Clean
                    && STDDepositDidChangeCol.Clean
                    && STDDepositIncDecRemark.Clean
                    && STDDownPaymentDidChangeCol.Clean
                    && STDDownPaymentIncDecRemark.Clean
                    && STDDownPaymentSectionRemark.Clean
                    && STDFinalAdjustmentAndOtherCredits.Clean
                    && STDFinalCashToClose.Clean
                    && STDFinalCD3ClosingCostsPaidBeforeClosing.Clean
                    && STDFinalClosingCostFinanced.Clean
                    && STDFinalDeposit.Clean
                    && STDFinalDownPayment.Clean
                    && STDFinalFundForBorrower.Clean
                    && STDFinalSellerCredits.Clean
                    && STDFinalTotalClosingCostJ.Clean
                    && STDFundsForBorrowerDidChangeCol.Clean
                    && STDFundsForBorrowerIncDecRemark.Clean
                    && STDLEAdjustmentAndOtherCredits.Clean
                    && STDLECashToClose.Clean
                    && STDLECD3ClosingCostsPaidBeforeClosing.Clean
                    && STDLEClosingCostFinanced.Clean
                    && STDLEDeposit.Clean
                    && STDLEDownPayment.Clean
                    && STDLEFundForBorrower.Clean
                    && STDLegalLimit.Clean
                    && STDLESellerCredits.Clean
                    && STDLETotalClosingCostJ.Clean
                    && STDSellerCreditsDidChangeCol.Clean
                    && STDSellerCreditsIncDecRemark.Clean
                    && STDTotalClosingCostBeforeClosingDidChangeCol.Clean
                    && STDTotalClosingCostDidChangeCol.Clean
                    && STDTotalClosingCostRemark.Clean
                    && TotalAdjustmentsAndOtherCredits.Clean
                    && TotalDuefromBorrowerAtClosing.Clean
                    && TotalDuefromSelleratClosing_N.Clean
                    && TotalDuetoSelleratClosing_M.Clean
                    && TotalFromK.Clean
                    && TotalFromL.Clean
                    && TotalFromM.Clean
                    && TotalFromN.Clean
                    && TotalPaidAlreadybyoronBehalfofBoroweratClosing.Clean
                    && UCDDetails.Clean
                    && UCDKSubTotal.Clean
                    && UCDLSubTotal.Clean
                    && UCDTotalAdjustmentsAndOtherCredits.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = ActualLECD3TotalClosingCostJFromLatestRec; v0.Clean = value; ActualLECD3TotalClosingCostJFromLatestRec = v0;
                var v1 = ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec; v1.Clean = value; ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec = v1;
                var v2 = ActualLELoanAmountFromLatestRec; v2.Clean = value; ActualLELoanAmountFromLatestRec = v2;
                var v3 = ActualLenderCredits; v3.Clean = value; ActualLenderCredits = v3;
                var v4 = ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec; v4.Clean = value; ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec = v4;
                var v5 = ActualSTDLEClosingCostFinancedFromLatestRec; v5.Clean = value; ActualSTDLEClosingCostFinancedFromLatestRec = v5;
                var v6 = ActualSTDLEDepositFromLatestRec; v6.Clean = value; ActualSTDLEDepositFromLatestRec = v6;
                var v7 = ActualSTDLEDownPaymentFromLatestRec; v7.Clean = value; ActualSTDLEDownPaymentFromLatestRec = v7;
                var v8 = ActualSTDLEFundForBorrowerFromLatestRec; v8.Clean = value; ActualSTDLEFundForBorrowerFromLatestRec = v8;
                var v9 = ActualSTDLESellerCredits; v9.Clean = value; ActualSTDLESellerCredits = v9;
                var v10 = ActualSTDLESellerCreditsFromLatestRec; v10.Clean = value; ActualSTDLESellerCreditsFromLatestRec = v10;
                var v11 = ActualSTDLETotalClosingCostJ; v11.Clean = value; ActualSTDLETotalClosingCostJ = v11;
                var v12 = ActualSTDLETotalClosingCostJFromLatestRec; v12.Clean = value; ActualSTDLETotalClosingCostJFromLatestRec = v12;
                var v13 = Adjustments06_1; v13.Clean = value; Adjustments06_1 = v13;
                var v14 = Adjustments06_2; v14.Clean = value; Adjustments06_2 = v14;
                var v15 = Adjustments07_1; v15.Clean = value; Adjustments07_1 = v15;
                var v16 = Adjustments07_2; v16.Clean = value; Adjustments07_2 = v16;
                var v17 = Adjustments10_1; v17.Clean = value; Adjustments10_1 = v17;
                var v18 = Adjustments10_2; v18.Clean = value; Adjustments10_2 = v18;
                var v19 = Adjustments11_1; v19.Clean = value; Adjustments11_1 = v19;
                var v20 = Adjustments11_2; v20.Clean = value; Adjustments11_2 = v20;
                var v21 = Adjustments15_1; v21.Clean = value; Adjustments15_1 = v21;
                var v22 = Adjustments15_2; v22.Clean = value; Adjustments15_2 = v22;
                var v23 = Adjustments8_1; v23.Clean = value; Adjustments8_1 = v23;
                var v24 = Adjustments8_2; v24.Clean = value; Adjustments8_2 = v24;
                var v25 = Adjustments9_1; v25.Clean = value; Adjustments9_1 = v25;
                var v26 = Adjustments9_2; v26.Clean = value; Adjustments9_2 = v26;
                var v27 = AdjustmentsforItemsPaidbySellerinAdvance16_1; v27.Clean = value; AdjustmentsforItemsPaidbySellerinAdvance16_1 = v27;
                var v28 = AdjustmentsforItemsPaidbySellerinAdvance16_2; v28.Clean = value; AdjustmentsforItemsPaidbySellerinAdvance16_2 = v28;
                var v29 = ALTCashToCloseDidChangeCol; v29.Clean = value; ALTCashToCloseDidChangeCol = v29;
                var v30 = ALTCashToCloseRemark; v30.Clean = value; ALTCashToCloseRemark = v30;
                var v31 = ALTClosingCostBeforeClosingDidChangeCol; v31.Clean = value; ALTClosingCostBeforeClosingDidChangeCol = v31;
                var v32 = ALTLegalLimit; v32.Clean = value; ALTLegalLimit = v32;
                var v33 = ALTLoanAmountDidChangeCol; v33.Clean = value; ALTLoanAmountDidChangeCol = v33;
                var v34 = ALTLoanAmountIncDecRemark; v34.Clean = value; ALTLoanAmountIncDecRemark = v34;
                var v35 = ALTTotalClosingCostDidChangeCol; v35.Clean = value; ALTTotalClosingCostDidChangeCol = v35;
                var v36 = ALTTotalClosingCostRemark; v36.Clean = value; ALTTotalClosingCostRemark = v36;
                var v37 = ALTTotalPayoffsDidChangeCol; v37.Clean = value; ALTTotalPayoffsDidChangeCol = v37;
                var v38 = Cash; v38.Clean = value; Cash = v38;
                var v39 = CashToClose; v39.Clean = value; CashToClose = v39;
                var v40 = CD3CashToClose; v40.Clean = value; CD3CashToClose = v40;
                var v41 = CD3CashToCloseFromToBorrower; v41.Clean = value; CD3CashToCloseFromToBorrower = v41;
                var v42 = CD3ClosingCostsPaidBeforeClosing; v42.Clean = value; CD3ClosingCostsPaidBeforeClosing = v42;
                var v43 = CD3TotalClosingCost_J; v43.Clean = value; CD3TotalClosingCost_J = v43;
                var v44 = CD3TotalPayoffsAndPayments_K; v44.Clean = value; CD3TotalPayoffsAndPayments_K = v44;
                var v45 = ClosingCostsPaidAtClosing; v45.Clean = value; ClosingCostsPaidAtClosing = v45;
                var v46 = ClosingCostsPaidatClosing_J; v46.Clean = value; ClosingCostsPaidatClosing_J = v46;
                var v47 = DuefromSelleratClosing11_1; v47.Clean = value; DuefromSelleratClosing11_1 = v47;
                var v48 = DuefromSelleratClosing11_2; v48.Clean = value; DuefromSelleratClosing11_2 = v48;
                var v49 = DuefromSelleratClosing12_1; v49.Clean = value; DuefromSelleratClosing12_1 = v49;
                var v50 = DuefromSelleratClosing12_2; v50.Clean = value; DuefromSelleratClosing12_2 = v50;
                var v51 = DuefromSelleratClosing13_1; v51.Clean = value; DuefromSelleratClosing13_1 = v51;
                var v52 = DuefromSelleratClosing13_2; v52.Clean = value; DuefromSelleratClosing13_2 = v52;
                var v53 = DueToSellerAtClosing6_1; v53.Clean = value; DueToSellerAtClosing6_1 = v53;
                var v54 = DueToSellerAtClosing6_2; v54.Clean = value; DueToSellerAtClosing6_2 = v54;
                var v55 = DueToSellerAtClosing7_1; v55.Clean = value; DueToSellerAtClosing7_1 = v55;
                var v56 = DueToSellerAtClosing7_2; v56.Clean = value; DueToSellerAtClosing7_2 = v56;
                var v57 = DueToSellerAtClosing8_1; v57.Clean = value; DueToSellerAtClosing8_1 = v57;
                var v58 = DueToSellerAtClosing8_2; v58.Clean = value; DueToSellerAtClosing8_2 = v58;
                var v59 = ExcludeBorrowerClosingCosts; v59.Clean = value; ExcludeBorrowerClosingCosts = v59;
                var v60 = FinalCashToClose; v60.Clean = value; FinalCashToClose = v60;
                var v61 = FromToBorrower; v61.Clean = value; FromToBorrower = v61;
                var v62 = FromToSeller; v62.Clean = value; FromToSeller = v62;
                var v63 = Id; v63.Clean = value; Id = v63;
                var v64 = LECD3CashToClose; v64.Clean = value; LECD3CashToClose = v64;
                var v65 = LECD3CashToCloseFromToBorrower; v65.Clean = value; LECD3CashToCloseFromToBorrower = v65;
                var v66 = LECD3ClosingCostsPaidBeforeClosing; v66.Clean = value; LECD3ClosingCostsPaidBeforeClosing = v66;
                var v67 = LECD3TotalClosingCost_J; v67.Clean = value; LECD3TotalClosingCost_J = v67;
                var v68 = LECD3TotalPayoffsAndPayments_K; v68.Clean = value; LECD3TotalPayoffsAndPayments_K = v68;
                var v69 = LELoanAmount; v69.Clean = value; LELoanAmount = v69;
                var v70 = LiabilityAmount1; v70.Clean = value; LiabilityAmount1 = v70;
                var v71 = LiabilityAmount10; v71.Clean = value; LiabilityAmount10 = v71;
                var v72 = LiabilityAmount11; v72.Clean = value; LiabilityAmount11 = v72;
                var v73 = LiabilityAmount12; v73.Clean = value; LiabilityAmount12 = v73;
                var v74 = LiabilityAmount13; v74.Clean = value; LiabilityAmount13 = v74;
                var v75 = LiabilityAmount14; v75.Clean = value; LiabilityAmount14 = v75;
                var v76 = LiabilityAmount15; v76.Clean = value; LiabilityAmount15 = v76;
                var v77 = LiabilityAmount2; v77.Clean = value; LiabilityAmount2 = v77;
                var v78 = LiabilityAmount3; v78.Clean = value; LiabilityAmount3 = v78;
                var v79 = LiabilityAmount4; v79.Clean = value; LiabilityAmount4 = v79;
                var v80 = LiabilityAmount5; v80.Clean = value; LiabilityAmount5 = v80;
                var v81 = LiabilityAmount6; v81.Clean = value; LiabilityAmount6 = v81;
                var v82 = LiabilityAmount7; v82.Clean = value; LiabilityAmount7 = v82;
                var v83 = LiabilityAmount8; v83.Clean = value; LiabilityAmount8 = v83;
                var v84 = LiabilityAmount9; v84.Clean = value; LiabilityAmount9 = v84;
                var v85 = LiabilityTo1; v85.Clean = value; LiabilityTo1 = v85;
                var v86 = LiabilityTo10; v86.Clean = value; LiabilityTo10 = v86;
                var v87 = LiabilityTo11; v87.Clean = value; LiabilityTo11 = v87;
                var v88 = LiabilityTo12; v88.Clean = value; LiabilityTo12 = v88;
                var v89 = LiabilityTo13; v89.Clean = value; LiabilityTo13 = v89;
                var v90 = LiabilityTo14; v90.Clean = value; LiabilityTo14 = v90;
                var v91 = LiabilityTo15; v91.Clean = value; LiabilityTo15 = v91;
                var v92 = LiabilityTo2; v92.Clean = value; LiabilityTo2 = v92;
                var v93 = LiabilityTo3; v93.Clean = value; LiabilityTo3 = v93;
                var v94 = LiabilityTo4; v94.Clean = value; LiabilityTo4 = v94;
                var v95 = LiabilityTo5; v95.Clean = value; LiabilityTo5 = v95;
                var v96 = LiabilityTo6; v96.Clean = value; LiabilityTo6 = v96;
                var v97 = LiabilityTo7; v97.Clean = value; LiabilityTo7 = v97;
                var v98 = LiabilityTo8; v98.Clean = value; LiabilityTo8 = v98;
                var v99 = LiabilityTo9; v99.Clean = value; LiabilityTo9 = v99;
                var v100 = LiabilityTotal; v100.Clean = value; LiabilityTotal = v100;
                var v101 = LoanAmount; v101.Clean = value; LoanAmount = v101;
                var v102 = NonUCDTotalAdjustmentsAndOtherCredits; v102.Clean = value; NonUCDTotalAdjustmentsAndOtherCredits = v102;
                var v103 = OmitFromPrintSellersTransaction; v103.Clean = value; OmitFromPrintSellersTransaction = v103;
                var v104 = OtherCredits6_1; v104.Clean = value; OtherCredits6_1 = v104;
                var v105 = OtherCredits6_2; v105.Clean = value; OtherCredits6_2 = v105;
                var v106 = OtherCredits7_1; v106.Clean = value; OtherCredits7_1 = v106;
                var v107 = OtherCredits7_2; v107.Clean = value; OtherCredits7_2 = v107;
                var v108 = PriorToleranceCureAmount; v108.Clean = value; PriorToleranceCureAmount = v108;
                var v109 = STDAdjustmentAndOtherCreditsRemark; v109.Clean = value; STDAdjustmentAndOtherCreditsRemark = v109;
                var v110 = STDAdjustmentsDidChangeCol; v110.Clean = value; STDAdjustmentsDidChangeCol = v110;
                var v111 = STDClosingCostFinancedDidChangeCol; v111.Clean = value; STDClosingCostFinancedDidChangeCol = v111;
                var v112 = STDDepositDidChangeCol; v112.Clean = value; STDDepositDidChangeCol = v112;
                var v113 = STDDepositIncDecRemark; v113.Clean = value; STDDepositIncDecRemark = v113;
                var v114 = STDDownPaymentDidChangeCol; v114.Clean = value; STDDownPaymentDidChangeCol = v114;
                var v115 = STDDownPaymentIncDecRemark; v115.Clean = value; STDDownPaymentIncDecRemark = v115;
                var v116 = STDDownPaymentSectionRemark; v116.Clean = value; STDDownPaymentSectionRemark = v116;
                var v117 = STDFinalAdjustmentAndOtherCredits; v117.Clean = value; STDFinalAdjustmentAndOtherCredits = v117;
                var v118 = STDFinalCashToClose; v118.Clean = value; STDFinalCashToClose = v118;
                var v119 = STDFinalCD3ClosingCostsPaidBeforeClosing; v119.Clean = value; STDFinalCD3ClosingCostsPaidBeforeClosing = v119;
                var v120 = STDFinalClosingCostFinanced; v120.Clean = value; STDFinalClosingCostFinanced = v120;
                var v121 = STDFinalDeposit; v121.Clean = value; STDFinalDeposit = v121;
                var v122 = STDFinalDownPayment; v122.Clean = value; STDFinalDownPayment = v122;
                var v123 = STDFinalFundForBorrower; v123.Clean = value; STDFinalFundForBorrower = v123;
                var v124 = STDFinalSellerCredits; v124.Clean = value; STDFinalSellerCredits = v124;
                var v125 = STDFinalTotalClosingCostJ; v125.Clean = value; STDFinalTotalClosingCostJ = v125;
                var v126 = STDFundsForBorrowerDidChangeCol; v126.Clean = value; STDFundsForBorrowerDidChangeCol = v126;
                var v127 = STDFundsForBorrowerIncDecRemark; v127.Clean = value; STDFundsForBorrowerIncDecRemark = v127;
                var v128 = STDLEAdjustmentAndOtherCredits; v128.Clean = value; STDLEAdjustmentAndOtherCredits = v128;
                var v129 = STDLECashToClose; v129.Clean = value; STDLECashToClose = v129;
                var v130 = STDLECD3ClosingCostsPaidBeforeClosing; v130.Clean = value; STDLECD3ClosingCostsPaidBeforeClosing = v130;
                var v131 = STDLEClosingCostFinanced; v131.Clean = value; STDLEClosingCostFinanced = v131;
                var v132 = STDLEDeposit; v132.Clean = value; STDLEDeposit = v132;
                var v133 = STDLEDownPayment; v133.Clean = value; STDLEDownPayment = v133;
                var v134 = STDLEFundForBorrower; v134.Clean = value; STDLEFundForBorrower = v134;
                var v135 = STDLegalLimit; v135.Clean = value; STDLegalLimit = v135;
                var v136 = STDLESellerCredits; v136.Clean = value; STDLESellerCredits = v136;
                var v137 = STDLETotalClosingCostJ; v137.Clean = value; STDLETotalClosingCostJ = v137;
                var v138 = STDSellerCreditsDidChangeCol; v138.Clean = value; STDSellerCreditsDidChangeCol = v138;
                var v139 = STDSellerCreditsIncDecRemark; v139.Clean = value; STDSellerCreditsIncDecRemark = v139;
                var v140 = STDTotalClosingCostBeforeClosingDidChangeCol; v140.Clean = value; STDTotalClosingCostBeforeClosingDidChangeCol = v140;
                var v141 = STDTotalClosingCostDidChangeCol; v141.Clean = value; STDTotalClosingCostDidChangeCol = v141;
                var v142 = STDTotalClosingCostRemark; v142.Clean = value; STDTotalClosingCostRemark = v142;
                var v143 = TotalAdjustmentsAndOtherCredits; v143.Clean = value; TotalAdjustmentsAndOtherCredits = v143;
                var v144 = TotalDuefromBorrowerAtClosing; v144.Clean = value; TotalDuefromBorrowerAtClosing = v144;
                var v145 = TotalDuefromSelleratClosing_N; v145.Clean = value; TotalDuefromSelleratClosing_N = v145;
                var v146 = TotalDuetoSelleratClosing_M; v146.Clean = value; TotalDuetoSelleratClosing_M = v146;
                var v147 = TotalFromK; v147.Clean = value; TotalFromK = v147;
                var v148 = TotalFromL; v148.Clean = value; TotalFromL = v148;
                var v149 = TotalFromM; v149.Clean = value; TotalFromM = v149;
                var v150 = TotalFromN; v150.Clean = value; TotalFromN = v150;
                var v151 = TotalPaidAlreadybyoronBehalfofBoroweratClosing; v151.Clean = value; TotalPaidAlreadybyoronBehalfofBoroweratClosing = v151;
                var v152 = UCDDetails; v152.Clean = value; UCDDetails = v152;
                var v153 = UCDKSubTotal; v153.Clean = value; UCDKSubTotal = v153;
                var v154 = UCDLSubTotal; v154.Clean = value; UCDLSubTotal = v154;
                var v155 = UCDTotalAdjustmentsAndOtherCredits; v155.Clean = value; UCDTotalAdjustmentsAndOtherCredits = v155;
                _settingClean = 0;
            }
        }
    }
}