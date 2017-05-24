using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure4
    {
        private Value<string> _demandFeature;
        public string DemandFeature { get { return _demandFeature; } set { _demandFeature = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDemandFeature() => !_demandFeature.Clean;
        private Value<bool?> _escrowIndicator;
        public bool? EscrowIndicator { get { return _escrowIndicator; } set { _escrowIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowIndicator() => !_escrowIndicator.Clean;
        private Value<decimal?> _estimatedPropertyCosts;
        public decimal? EstimatedPropertyCosts { get { return _estimatedPropertyCosts; } set { _estimatedPropertyCosts = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedPropertyCosts() => !_estimatedPropertyCosts.Clean;
        private Value<string> _firstChangeAmt;
        public string FirstChangeAmt { get { return _firstChangeAmt; } set { _firstChangeAmt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeAmt() => !_firstChangeAmt.Clean;
        private Value<decimal?> _firstChangeMaxAmt;
        public decimal? FirstChangeMaxAmt { get { return _firstChangeMaxAmt; } set { _firstChangeMaxAmt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeMaxAmt() => !_firstChangeMaxAmt.Clean;
        private Value<decimal?> _firstChangeMinAmt;
        public decimal? FirstChangeMinAmt { get { return _firstChangeMinAmt; } set { _firstChangeMinAmt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangeMinAmt() => !_firstChangeMinAmt.Clean;
        private Value<string> _firstChangePayment;
        public string FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePayment() => !_firstChangePayment.Clean;
        private Value<bool?> _hOADuesIsEscrow;
        public bool? HOADuesIsEscrow { get { return _hOADuesIsEscrow; } set { _hOADuesIsEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHOADuesIsEscrow() => !_hOADuesIsEscrow.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<bool?> _ignoreARMAdj;
        public bool? IgnoreARMAdj { get { return _ignoreARMAdj; } set { _ignoreARMAdj = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeIgnoreARMAdj() => !_ignoreARMAdj.Clean;
        private Value<decimal?> _initialEscrowPayment;
        public decimal? InitialEscrowPayment { get { return _initialEscrowPayment; } set { _initialEscrowPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialEscrowPayment() => !_initialEscrowPayment.Clean;
        private Value<int?> _interestOnlyPaymentMonths;
        public int? InterestOnlyPaymentMonths { get { return _interestOnlyPaymentMonths; } set { _interestOnlyPaymentMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyPaymentMonths() => !_interestOnlyPaymentMonths.Clean;
        private Value<bool?> _interestOnlyPayments;
        public bool? InterestOnlyPayments { get { return _interestOnlyPayments; } set { _interestOnlyPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestOnlyPayments() => !_interestOnlyPayments.Clean;
        private Value<int?> _interestRateAdjustments;
        public int? InterestRateAdjustments { get { return _interestRateAdjustments; } set { _interestRateAdjustments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInterestRateAdjustments() => !_interestRateAdjustments.Clean;
        private Value<bool?> _lender;
        public bool? Lender { get { return _lender; } set { _lender = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLender() => !_lender.Clean;
        private Value<string> _maximumPaymentAmt;
        public string MaximumPaymentAmt { get { return _maximumPaymentAmt; } set { _maximumPaymentAmt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaximumPaymentAmt() => !_maximumPaymentAmt.Clean;
        private Value<string> _maxPayment;
        public string MaxPayment { get { return _maxPayment; } set { _maxPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPayment() => !_maxPayment.Clean;
        private Value<decimal?> _maxPaymentAmt;
        public decimal? MaxPaymentAmt { get { return _maxPaymentAmt; } set { _maxPaymentAmt = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPaymentAmt() => !_maxPaymentAmt.Clean;
        private Value<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get { return _monthlyEscrowPayment; } set { _monthlyEscrowPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyEscrowPayment() => !_monthlyEscrowPayment.Clean;
        private Value<string> _negativeAmortization;
        public string NegativeAmortization { get { return _negativeAmortization; } set { _negativeAmortization = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNegativeAmortization() => !_negativeAmortization.Clean;
        private Value<decimal?> _nonEscrowedPropertyCosts1YearConsummation;
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get { return _nonEscrowedPropertyCosts1YearConsummation; } set { _nonEscrowedPropertyCosts1YearConsummation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonEscrowedPropertyCosts1YearConsummation() => !_nonEscrowedPropertyCosts1YearConsummation.Clean;
        private Value<bool?> _other1;
        public bool? Other1 { get { return _other1; } set { _other1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther1() => !_other1.Clean;
        private Value<bool?> _other2;
        public bool? Other2 { get { return _other2; } set { _other2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther2() => !_other2.Clean;
        private Value<bool?> _other3;
        public bool? Other3 { get { return _other3; } set { _other3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOther3() => !_other3.Clean;
        private Value<string> _partialPayment;
        public string PartialPayment { get { return _partialPayment; } set { _partialPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPayment() => !_partialPayment.Clean;
        private Value<string> _partialPaymentHoldUntilComplete;
        public string PartialPaymentHoldUntilComplete { get { return _partialPaymentHoldUntilComplete; } set { _partialPaymentHoldUntilComplete = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPaymentHoldUntilComplete() => !_partialPaymentHoldUntilComplete.Clean;
        private Value<string> _partialPaymentNone;
        public string PartialPaymentNone { get { return _partialPaymentNone; } set { _partialPaymentNone = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePartialPaymentNone() => !_partialPaymentNone.Clean;
        private Value<string> _seasonalPaymentFromYr;
        public string SeasonalPaymentFromYr { get { return _seasonalPaymentFromYr; } set { _seasonalPaymentFromYr = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeasonalPaymentFromYr() => !_seasonalPaymentFromYr.Clean;
        private Value<bool?> _seasonalPayments;
        public bool? SeasonalPayments { get { return _seasonalPayments; } set { _seasonalPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSeasonalPayments() => !_seasonalPayments.Clean;
        private Value<int?> _stepPayment;
        public int? StepPayment { get { return _stepPayment; } set { _stepPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepPayment() => !_stepPayment.Clean;
        private Value<bool?> _stepPayments;
        public bool? StepPayments { get { return _stepPayments; } set { _stepPayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepPayments() => !_stepPayments.Clean;
        private Value<decimal?> _stepRateFirstChange;
        public decimal? StepRateFirstChange { get { return _stepRateFirstChange; } set { _stepRateFirstChange = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeStepRateFirstChange() => !_stepRateFirstChange.Clean;
        private Value<string> _subsequentChanges;
        public string SubsequentChanges { get { return _subsequentChanges; } set { _subsequentChanges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubsequentChanges() => !_subsequentChanges.Clean;
        private Value<decimal?> _totalDisbursed1YearConsummation;
        public decimal? TotalDisbursed1YearConsummation { get { return _totalDisbursed1YearConsummation; } set { _totalDisbursed1YearConsummation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalDisbursed1YearConsummation() => !_totalDisbursed1YearConsummation.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _demandFeature.Clean
                    && _escrowIndicator.Clean
                    && _estimatedPropertyCosts.Clean
                    && _firstChangeAmt.Clean
                    && _firstChangeMaxAmt.Clean
                    && _firstChangeMinAmt.Clean
                    && _firstChangePayment.Clean
                    && _hOADuesIsEscrow.Clean
                    && _id.Clean
                    && _ignoreARMAdj.Clean
                    && _initialEscrowPayment.Clean
                    && _interestOnlyPaymentMonths.Clean
                    && _interestOnlyPayments.Clean
                    && _interestRateAdjustments.Clean
                    && _lender.Clean
                    && _maximumPaymentAmt.Clean
                    && _maxPayment.Clean
                    && _maxPaymentAmt.Clean
                    && _monthlyEscrowPayment.Clean
                    && _negativeAmortization.Clean
                    && _nonEscrowedPropertyCosts1YearConsummation.Clean
                    && _other1.Clean
                    && _other2.Clean
                    && _other3.Clean
                    && _partialPayment.Clean
                    && _partialPaymentHoldUntilComplete.Clean
                    && _partialPaymentNone.Clean
                    && _seasonalPaymentFromYr.Clean
                    && _seasonalPayments.Clean
                    && _stepPayment.Clean
                    && _stepPayments.Clean
                    && _stepRateFirstChange.Clean
                    && _subsequentChanges.Clean
                    && _totalDisbursed1YearConsummation.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _demandFeature; v0.Clean = value; _demandFeature = v0;
                var v1 = _escrowIndicator; v1.Clean = value; _escrowIndicator = v1;
                var v2 = _estimatedPropertyCosts; v2.Clean = value; _estimatedPropertyCosts = v2;
                var v3 = _firstChangeAmt; v3.Clean = value; _firstChangeAmt = v3;
                var v4 = _firstChangeMaxAmt; v4.Clean = value; _firstChangeMaxAmt = v4;
                var v5 = _firstChangeMinAmt; v5.Clean = value; _firstChangeMinAmt = v5;
                var v6 = _firstChangePayment; v6.Clean = value; _firstChangePayment = v6;
                var v7 = _hOADuesIsEscrow; v7.Clean = value; _hOADuesIsEscrow = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _ignoreARMAdj; v9.Clean = value; _ignoreARMAdj = v9;
                var v10 = _initialEscrowPayment; v10.Clean = value; _initialEscrowPayment = v10;
                var v11 = _interestOnlyPaymentMonths; v11.Clean = value; _interestOnlyPaymentMonths = v11;
                var v12 = _interestOnlyPayments; v12.Clean = value; _interestOnlyPayments = v12;
                var v13 = _interestRateAdjustments; v13.Clean = value; _interestRateAdjustments = v13;
                var v14 = _lender; v14.Clean = value; _lender = v14;
                var v15 = _maximumPaymentAmt; v15.Clean = value; _maximumPaymentAmt = v15;
                var v16 = _maxPayment; v16.Clean = value; _maxPayment = v16;
                var v17 = _maxPaymentAmt; v17.Clean = value; _maxPaymentAmt = v17;
                var v18 = _monthlyEscrowPayment; v18.Clean = value; _monthlyEscrowPayment = v18;
                var v19 = _negativeAmortization; v19.Clean = value; _negativeAmortization = v19;
                var v20 = _nonEscrowedPropertyCosts1YearConsummation; v20.Clean = value; _nonEscrowedPropertyCosts1YearConsummation = v20;
                var v21 = _other1; v21.Clean = value; _other1 = v21;
                var v22 = _other2; v22.Clean = value; _other2 = v22;
                var v23 = _other3; v23.Clean = value; _other3 = v23;
                var v24 = _partialPayment; v24.Clean = value; _partialPayment = v24;
                var v25 = _partialPaymentHoldUntilComplete; v25.Clean = value; _partialPaymentHoldUntilComplete = v25;
                var v26 = _partialPaymentNone; v26.Clean = value; _partialPaymentNone = v26;
                var v27 = _seasonalPaymentFromYr; v27.Clean = value; _seasonalPaymentFromYr = v27;
                var v28 = _seasonalPayments; v28.Clean = value; _seasonalPayments = v28;
                var v29 = _stepPayment; v29.Clean = value; _stepPayment = v29;
                var v30 = _stepPayments; v30.Clean = value; _stepPayments = v30;
                var v31 = _stepRateFirstChange; v31.Clean = value; _stepRateFirstChange = v31;
                var v32 = _subsequentChanges; v32.Clean = value; _subsequentChanges = v32;
                var v33 = _totalDisbursed1YearConsummation; v33.Clean = value; _totalDisbursed1YearConsummation = v33;
                _settingClean = 0;
            }
        }
    }
}