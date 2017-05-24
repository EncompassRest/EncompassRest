using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrequalificationScenario
    {
        public Value<int?> AppraisedValue { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAppraisedValue() => !AppraisedValue.Clean;
        public Value<decimal?> Apr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeApr() => !Apr.Clean;
        public Value<decimal?> CashToClose { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCashToClose() => !CashToClose.Clean;
        public Value<decimal?> ClosingCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCost() => !ClosingCost.Clean;
        public Value<decimal?> Cltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCltv() => !Cltv.Clean;
        public Value<string> Comments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeComments() => !Comments.Clean;
        public Value<string> CreditScore { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditScore() => !CreditScore.Clean;
        public Value<string> CurrentStatus { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCurrentStatus() => !CurrentStatus.Clean;
        public Value<decimal?> DownPaymentAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentAmount() => !DownPaymentAmount.Clean;
        public Value<decimal?> DownPaymentPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDownPaymentPercent() => !DownPaymentPercent.Clean;
        public Value<decimal?> FhaUpfrontMIPremiumPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFhaUpfrontMIPremiumPercent() => !FhaUpfrontMIPremiumPercent.Clean;
        public Value<decimal?> GrossNegativeCashFlow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGrossNegativeCashFlow() => !GrossNegativeCashFlow.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> LoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanAmount() => !LoanAmount.Clean;
        public Value<decimal?> Ltv { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLtv() => !Ltv.Clean;
        public Value<decimal?> MaximumDebt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumDebt() => !MaximumDebt.Clean;
        public Value<decimal?> MaximumLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumLoanAmount() => !MaximumLoanAmount.Clean;
        public Value<decimal?> MiAndFundingFeeFinancedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMiAndFundingFeeFinancedAmount() => !MiAndFundingFeeFinancedAmount.Clean;
        public Value<decimal?> MinimumIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMinimumIncome() => !MinimumIncome.Clean;
        public Value<decimal?> MonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !MonthlyPayment.Clean;
        public Value<decimal?> PrepaidItemsEstimatedAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidItemsEstimatedAmount() => !PrepaidItemsEstimatedAmount.Clean;
        public Value<int?> PrequalificationScenarioIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrequalificationScenarioIndex() => !PrequalificationScenarioIndex.Clean;
        public Value<decimal?> QualBottomRatioPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQualBottomRatioPercent() => !QualBottomRatioPercent.Clean;
        public Value<decimal?> QualTopRatioPercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeQualTopRatioPercent() => !QualTopRatioPercent.Clean;
        public Value<decimal?> SalesPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSalesPrice() => !SalesPrice.Clean;
        public Value<decimal?> SubordinateFin { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubordinateFin() => !SubordinateFin.Clean;
        public Value<decimal?> TotalBaseCost { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBaseCost() => !TotalBaseCost.Clean;
        public Value<decimal?> TotalCashAvailable { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCashAvailable() => !TotalCashAvailable.Clean;
        public Value<decimal?> TotalCashLeft { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCashLeft() => !TotalCashLeft.Clean;
        public Value<decimal?> TotalCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCosts() => !TotalCosts.Clean;
        public Value<decimal?> TotalFinancing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFinancing() => !TotalFinancing.Clean;
        public Value<decimal?> TotalHe { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalHe() => !TotalHe.Clean;
        public Value<decimal?> TotalIncome { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalIncome() => !TotalIncome.Clean;
        public Value<decimal?> TotalLoanAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalLoanAmount() => !TotalLoanAmount.Clean;
        public Value<decimal?> TotalOtherExpense { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOtherExpense() => !TotalOtherExpense.Clean;
        public Value<decimal?> TotalPaidOffMortgage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidOffMortgage() => !TotalPaidOffMortgage.Clean;
        public Value<decimal?> TotalPaidOffOthers { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidOffOthers() => !TotalPaidOffOthers.Clean;
        public Value<decimal?> TotalPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPayments() => !TotalPayments.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AppraisedValue.Clean
                    && Apr.Clean
                    && CashToClose.Clean
                    && ClosingCost.Clean
                    && Cltv.Clean
                    && Comments.Clean
                    && CreditScore.Clean
                    && CurrentStatus.Clean
                    && DownPaymentAmount.Clean
                    && DownPaymentPercent.Clean
                    && FhaUpfrontMIPremiumPercent.Clean
                    && GrossNegativeCashFlow.Clean
                    && Id.Clean
                    && LoanAmount.Clean
                    && Ltv.Clean
                    && MaximumDebt.Clean
                    && MaximumLoanAmount.Clean
                    && MiAndFundingFeeFinancedAmount.Clean
                    && MinimumIncome.Clean
                    && MonthlyPayment.Clean
                    && PrepaidItemsEstimatedAmount.Clean
                    && PrequalificationScenarioIndex.Clean
                    && QualBottomRatioPercent.Clean
                    && QualTopRatioPercent.Clean
                    && SalesPrice.Clean
                    && SubordinateFin.Clean
                    && TotalBaseCost.Clean
                    && TotalCashAvailable.Clean
                    && TotalCashLeft.Clean
                    && TotalCosts.Clean
                    && TotalFinancing.Clean
                    && TotalHe.Clean
                    && TotalIncome.Clean
                    && TotalLoanAmount.Clean
                    && TotalOtherExpense.Clean
                    && TotalPaidOffMortgage.Clean
                    && TotalPaidOffOthers.Clean
                    && TotalPayments.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AppraisedValue; v0.Clean = value; AppraisedValue = v0;
                var v1 = Apr; v1.Clean = value; Apr = v1;
                var v2 = CashToClose; v2.Clean = value; CashToClose = v2;
                var v3 = ClosingCost; v3.Clean = value; ClosingCost = v3;
                var v4 = Cltv; v4.Clean = value; Cltv = v4;
                var v5 = Comments; v5.Clean = value; Comments = v5;
                var v6 = CreditScore; v6.Clean = value; CreditScore = v6;
                var v7 = CurrentStatus; v7.Clean = value; CurrentStatus = v7;
                var v8 = DownPaymentAmount; v8.Clean = value; DownPaymentAmount = v8;
                var v9 = DownPaymentPercent; v9.Clean = value; DownPaymentPercent = v9;
                var v10 = FhaUpfrontMIPremiumPercent; v10.Clean = value; FhaUpfrontMIPremiumPercent = v10;
                var v11 = GrossNegativeCashFlow; v11.Clean = value; GrossNegativeCashFlow = v11;
                var v12 = Id; v12.Clean = value; Id = v12;
                var v13 = LoanAmount; v13.Clean = value; LoanAmount = v13;
                var v14 = Ltv; v14.Clean = value; Ltv = v14;
                var v15 = MaximumDebt; v15.Clean = value; MaximumDebt = v15;
                var v16 = MaximumLoanAmount; v16.Clean = value; MaximumLoanAmount = v16;
                var v17 = MiAndFundingFeeFinancedAmount; v17.Clean = value; MiAndFundingFeeFinancedAmount = v17;
                var v18 = MinimumIncome; v18.Clean = value; MinimumIncome = v18;
                var v19 = MonthlyPayment; v19.Clean = value; MonthlyPayment = v19;
                var v20 = PrepaidItemsEstimatedAmount; v20.Clean = value; PrepaidItemsEstimatedAmount = v20;
                var v21 = PrequalificationScenarioIndex; v21.Clean = value; PrequalificationScenarioIndex = v21;
                var v22 = QualBottomRatioPercent; v22.Clean = value; QualBottomRatioPercent = v22;
                var v23 = QualTopRatioPercent; v23.Clean = value; QualTopRatioPercent = v23;
                var v24 = SalesPrice; v24.Clean = value; SalesPrice = v24;
                var v25 = SubordinateFin; v25.Clean = value; SubordinateFin = v25;
                var v26 = TotalBaseCost; v26.Clean = value; TotalBaseCost = v26;
                var v27 = TotalCashAvailable; v27.Clean = value; TotalCashAvailable = v27;
                var v28 = TotalCashLeft; v28.Clean = value; TotalCashLeft = v28;
                var v29 = TotalCosts; v29.Clean = value; TotalCosts = v29;
                var v30 = TotalFinancing; v30.Clean = value; TotalFinancing = v30;
                var v31 = TotalHe; v31.Clean = value; TotalHe = v31;
                var v32 = TotalIncome; v32.Clean = value; TotalIncome = v32;
                var v33 = TotalLoanAmount; v33.Clean = value; TotalLoanAmount = v33;
                var v34 = TotalOtherExpense; v34.Clean = value; TotalOtherExpense = v34;
                var v35 = TotalPaidOffMortgage; v35.Clean = value; TotalPaidOffMortgage = v35;
                var v36 = TotalPaidOffOthers; v36.Clean = value; TotalPaidOffOthers = v36;
                var v37 = TotalPayments; v37.Clean = value; TotalPayments = v37;
                _settingClean = 0;
            }
        }
    }
}