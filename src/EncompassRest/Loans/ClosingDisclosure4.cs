using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure4
    {
        public Value<string> DemandFeature { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDemandFeature() => !DemandFeature.Clean;
        public Value<bool?> EscrowIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowIndicator() => !EscrowIndicator.Clean;
        public Value<decimal?> EstimatedPropertyCosts { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedPropertyCosts() => !EstimatedPropertyCosts.Clean;
        public Value<string> FirstChangeAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeAmt() => !FirstChangeAmt.Clean;
        public Value<decimal?> FirstChangeMaxAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeMaxAmt() => !FirstChangeMaxAmt.Clean;
        public Value<decimal?> FirstChangeMinAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeMinAmt() => !FirstChangeMinAmt.Clean;
        public Value<string> FirstChangePayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePayment() => !FirstChangePayment.Clean;
        public Value<bool?> HOADuesIsEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHOADuesIsEscrow() => !HOADuesIsEscrow.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> IgnoreARMAdj { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIgnoreARMAdj() => !IgnoreARMAdj.Clean;
        public Value<decimal?> InitialEscrowPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialEscrowPayment() => !InitialEscrowPayment.Clean;
        public Value<int?> InterestOnlyPaymentMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyPaymentMonths() => !InterestOnlyPaymentMonths.Clean;
        public Value<bool?> InterestOnlyPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyPayments() => !InterestOnlyPayments.Clean;
        public Value<int?> InterestRateAdjustments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustments() => !InterestRateAdjustments.Clean;
        public Value<bool?> Lender { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLender() => !Lender.Clean;
        public Value<string> MaximumPaymentAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumPaymentAmt() => !MaximumPaymentAmt.Clean;
        public Value<string> MaxPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPayment() => !MaxPayment.Clean;
        public Value<decimal?> MaxPaymentAmt { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPaymentAmt() => !MaxPaymentAmt.Clean;
        public Value<decimal?> MonthlyEscrowPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyEscrowPayment() => !MonthlyEscrowPayment.Clean;
        public Value<string> NegativeAmortization { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegativeAmortization() => !NegativeAmortization.Clean;
        public Value<decimal?> NonEscrowedPropertyCosts1YearConsummation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonEscrowedPropertyCosts1YearConsummation() => !NonEscrowedPropertyCosts1YearConsummation.Clean;
        public Value<bool?> Other1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther1() => !Other1.Clean;
        public Value<bool?> Other2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther2() => !Other2.Clean;
        public Value<bool?> Other3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther3() => !Other3.Clean;
        public Value<string> PartialPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPayment() => !PartialPayment.Clean;
        public Value<string> PartialPaymentHoldUntilComplete { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPaymentHoldUntilComplete() => !PartialPaymentHoldUntilComplete.Clean;
        public Value<string> PartialPaymentNone { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPaymentNone() => !PartialPaymentNone.Clean;
        public Value<string> SeasonalPaymentFromYr { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeasonalPaymentFromYr() => !SeasonalPaymentFromYr.Clean;
        public Value<bool?> SeasonalPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeasonalPayments() => !SeasonalPayments.Clean;
        public Value<int?> StepPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepPayment() => !StepPayment.Clean;
        public Value<bool?> StepPayments { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepPayments() => !StepPayments.Clean;
        public Value<decimal?> StepRateFirstChange { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepRateFirstChange() => !StepRateFirstChange.Clean;
        public Value<string> SubsequentChanges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentChanges() => !SubsequentChanges.Clean;
        public Value<decimal?> TotalDisbursed1YearConsummation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDisbursed1YearConsummation() => !TotalDisbursed1YearConsummation.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = DemandFeature.Clean
                    && EscrowIndicator.Clean
                    && EstimatedPropertyCosts.Clean
                    && FirstChangeAmt.Clean
                    && FirstChangeMaxAmt.Clean
                    && FirstChangeMinAmt.Clean
                    && FirstChangePayment.Clean
                    && HOADuesIsEscrow.Clean
                    && Id.Clean
                    && IgnoreARMAdj.Clean
                    && InitialEscrowPayment.Clean
                    && InterestOnlyPaymentMonths.Clean
                    && InterestOnlyPayments.Clean
                    && InterestRateAdjustments.Clean
                    && Lender.Clean
                    && MaximumPaymentAmt.Clean
                    && MaxPayment.Clean
                    && MaxPaymentAmt.Clean
                    && MonthlyEscrowPayment.Clean
                    && NegativeAmortization.Clean
                    && NonEscrowedPropertyCosts1YearConsummation.Clean
                    && Other1.Clean
                    && Other2.Clean
                    && Other3.Clean
                    && PartialPayment.Clean
                    && PartialPaymentHoldUntilComplete.Clean
                    && PartialPaymentNone.Clean
                    && SeasonalPaymentFromYr.Clean
                    && SeasonalPayments.Clean
                    && StepPayment.Clean
                    && StepPayments.Clean
                    && StepRateFirstChange.Clean
                    && SubsequentChanges.Clean
                    && TotalDisbursed1YearConsummation.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = DemandFeature; v0.Clean = value; DemandFeature = v0;
                var v1 = EscrowIndicator; v1.Clean = value; EscrowIndicator = v1;
                var v2 = EstimatedPropertyCosts; v2.Clean = value; EstimatedPropertyCosts = v2;
                var v3 = FirstChangeAmt; v3.Clean = value; FirstChangeAmt = v3;
                var v4 = FirstChangeMaxAmt; v4.Clean = value; FirstChangeMaxAmt = v4;
                var v5 = FirstChangeMinAmt; v5.Clean = value; FirstChangeMinAmt = v5;
                var v6 = FirstChangePayment; v6.Clean = value; FirstChangePayment = v6;
                var v7 = HOADuesIsEscrow; v7.Clean = value; HOADuesIsEscrow = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = IgnoreARMAdj; v9.Clean = value; IgnoreARMAdj = v9;
                var v10 = InitialEscrowPayment; v10.Clean = value; InitialEscrowPayment = v10;
                var v11 = InterestOnlyPaymentMonths; v11.Clean = value; InterestOnlyPaymentMonths = v11;
                var v12 = InterestOnlyPayments; v12.Clean = value; InterestOnlyPayments = v12;
                var v13 = InterestRateAdjustments; v13.Clean = value; InterestRateAdjustments = v13;
                var v14 = Lender; v14.Clean = value; Lender = v14;
                var v15 = MaximumPaymentAmt; v15.Clean = value; MaximumPaymentAmt = v15;
                var v16 = MaxPayment; v16.Clean = value; MaxPayment = v16;
                var v17 = MaxPaymentAmt; v17.Clean = value; MaxPaymentAmt = v17;
                var v18 = MonthlyEscrowPayment; v18.Clean = value; MonthlyEscrowPayment = v18;
                var v19 = NegativeAmortization; v19.Clean = value; NegativeAmortization = v19;
                var v20 = NonEscrowedPropertyCosts1YearConsummation; v20.Clean = value; NonEscrowedPropertyCosts1YearConsummation = v20;
                var v21 = Other1; v21.Clean = value; Other1 = v21;
                var v22 = Other2; v22.Clean = value; Other2 = v22;
                var v23 = Other3; v23.Clean = value; Other3 = v23;
                var v24 = PartialPayment; v24.Clean = value; PartialPayment = v24;
                var v25 = PartialPaymentHoldUntilComplete; v25.Clean = value; PartialPaymentHoldUntilComplete = v25;
                var v26 = PartialPaymentNone; v26.Clean = value; PartialPaymentNone = v26;
                var v27 = SeasonalPaymentFromYr; v27.Clean = value; SeasonalPaymentFromYr = v27;
                var v28 = SeasonalPayments; v28.Clean = value; SeasonalPayments = v28;
                var v29 = StepPayment; v29.Clean = value; StepPayment = v29;
                var v30 = StepPayments; v30.Clean = value; StepPayments = v30;
                var v31 = StepRateFirstChange; v31.Clean = value; StepRateFirstChange = v31;
                var v32 = SubsequentChanges; v32.Clean = value; SubsequentChanges = v32;
                var v33 = TotalDisbursed1YearConsummation; v33.Clean = value; TotalDisbursed1YearConsummation = v33;
                _settingClean = 0;
            }
        }
    }
}