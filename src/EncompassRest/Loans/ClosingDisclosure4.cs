using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingDisclosure4 : IClean
    {
        private Value<string> _demandFeature;
        public string DemandFeature { get { return _demandFeature; } set { _demandFeature = value; } }
        private Value<bool?> _escrowIndicator;
        public bool? EscrowIndicator { get { return _escrowIndicator; } set { _escrowIndicator = value; } }
        private Value<decimal?> _estimatedPropertyCosts;
        public decimal? EstimatedPropertyCosts { get { return _estimatedPropertyCosts; } set { _estimatedPropertyCosts = value; } }
        private Value<string> _firstChangeAmt;
        public string FirstChangeAmt { get { return _firstChangeAmt; } set { _firstChangeAmt = value; } }
        private Value<decimal?> _firstChangeMaxAmt;
        public decimal? FirstChangeMaxAmt { get { return _firstChangeMaxAmt; } set { _firstChangeMaxAmt = value; } }
        private Value<decimal?> _firstChangeMinAmt;
        public decimal? FirstChangeMinAmt { get { return _firstChangeMinAmt; } set { _firstChangeMinAmt = value; } }
        private Value<string> _firstChangePayment;
        public string FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        private Value<bool?> _hOADuesIsEscrow;
        public bool? HOADuesIsEscrow { get { return _hOADuesIsEscrow; } set { _hOADuesIsEscrow = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _ignoreARMAdj;
        public bool? IgnoreARMAdj { get { return _ignoreARMAdj; } set { _ignoreARMAdj = value; } }
        private Value<decimal?> _initialEscrowPayment;
        public decimal? InitialEscrowPayment { get { return _initialEscrowPayment; } set { _initialEscrowPayment = value; } }
        private Value<int?> _interestOnlyPaymentMonths;
        public int? InterestOnlyPaymentMonths { get { return _interestOnlyPaymentMonths; } set { _interestOnlyPaymentMonths = value; } }
        private Value<bool?> _interestOnlyPayments;
        public bool? InterestOnlyPayments { get { return _interestOnlyPayments; } set { _interestOnlyPayments = value; } }
        private Value<int?> _interestRateAdjustments;
        public int? InterestRateAdjustments { get { return _interestRateAdjustments; } set { _interestRateAdjustments = value; } }
        private Value<bool?> _lender;
        public bool? Lender { get { return _lender; } set { _lender = value; } }
        private Value<string> _maximumPaymentAmt;
        public string MaximumPaymentAmt { get { return _maximumPaymentAmt; } set { _maximumPaymentAmt = value; } }
        private Value<string> _maxPayment;
        public string MaxPayment { get { return _maxPayment; } set { _maxPayment = value; } }
        private Value<decimal?> _maxPaymentAmt;
        public decimal? MaxPaymentAmt { get { return _maxPaymentAmt; } set { _maxPaymentAmt = value; } }
        private Value<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get { return _monthlyEscrowPayment; } set { _monthlyEscrowPayment = value; } }
        private Value<string> _negativeAmortization;
        public string NegativeAmortization { get { return _negativeAmortization; } set { _negativeAmortization = value; } }
        private Value<decimal?> _nonEscrowedPropertyCosts1YearConsummation;
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get { return _nonEscrowedPropertyCosts1YearConsummation; } set { _nonEscrowedPropertyCosts1YearConsummation = value; } }
        private Value<bool?> _other1;
        public bool? Other1 { get { return _other1; } set { _other1 = value; } }
        private Value<bool?> _other2;
        public bool? Other2 { get { return _other2; } set { _other2 = value; } }
        private Value<bool?> _other3;
        public bool? Other3 { get { return _other3; } set { _other3 = value; } }
        private Value<string> _partialPayment;
        public string PartialPayment { get { return _partialPayment; } set { _partialPayment = value; } }
        private Value<string> _partialPaymentHoldUntilComplete;
        public string PartialPaymentHoldUntilComplete { get { return _partialPaymentHoldUntilComplete; } set { _partialPaymentHoldUntilComplete = value; } }
        private Value<string> _partialPaymentNone;
        public string PartialPaymentNone { get { return _partialPaymentNone; } set { _partialPaymentNone = value; } }
        private Value<string> _seasonalPaymentFromYr;
        public string SeasonalPaymentFromYr { get { return _seasonalPaymentFromYr; } set { _seasonalPaymentFromYr = value; } }
        private Value<bool?> _seasonalPayments;
        public bool? SeasonalPayments { get { return _seasonalPayments; } set { _seasonalPayments = value; } }
        private Value<int?> _stepPayment;
        public int? StepPayment { get { return _stepPayment; } set { _stepPayment = value; } }
        private Value<bool?> _stepPayments;
        public bool? StepPayments { get { return _stepPayments; } set { _stepPayments = value; } }
        private Value<decimal?> _stepRateFirstChange;
        public decimal? StepRateFirstChange { get { return _stepRateFirstChange; } set { _stepRateFirstChange = value; } }
        private Value<string> _subsequentChanges;
        public string SubsequentChanges { get { return _subsequentChanges; } set { _subsequentChanges = value; } }
        private Value<decimal?> _totalDisbursed1YearConsummation;
        public decimal? TotalDisbursed1YearConsummation { get { return _totalDisbursed1YearConsummation; } set { _totalDisbursed1YearConsummation = value; } }
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
                var demandFeature = _demandFeature; demandFeature.Clean = value; _demandFeature = demandFeature;
                var escrowIndicator = _escrowIndicator; escrowIndicator.Clean = value; _escrowIndicator = escrowIndicator;
                var estimatedPropertyCosts = _estimatedPropertyCosts; estimatedPropertyCosts.Clean = value; _estimatedPropertyCosts = estimatedPropertyCosts;
                var firstChangeAmt = _firstChangeAmt; firstChangeAmt.Clean = value; _firstChangeAmt = firstChangeAmt;
                var firstChangeMaxAmt = _firstChangeMaxAmt; firstChangeMaxAmt.Clean = value; _firstChangeMaxAmt = firstChangeMaxAmt;
                var firstChangeMinAmt = _firstChangeMinAmt; firstChangeMinAmt.Clean = value; _firstChangeMinAmt = firstChangeMinAmt;
                var firstChangePayment = _firstChangePayment; firstChangePayment.Clean = value; _firstChangePayment = firstChangePayment;
                var hOADuesIsEscrow = _hOADuesIsEscrow; hOADuesIsEscrow.Clean = value; _hOADuesIsEscrow = hOADuesIsEscrow;
                var id = _id; id.Clean = value; _id = id;
                var ignoreARMAdj = _ignoreARMAdj; ignoreARMAdj.Clean = value; _ignoreARMAdj = ignoreARMAdj;
                var initialEscrowPayment = _initialEscrowPayment; initialEscrowPayment.Clean = value; _initialEscrowPayment = initialEscrowPayment;
                var interestOnlyPaymentMonths = _interestOnlyPaymentMonths; interestOnlyPaymentMonths.Clean = value; _interestOnlyPaymentMonths = interestOnlyPaymentMonths;
                var interestOnlyPayments = _interestOnlyPayments; interestOnlyPayments.Clean = value; _interestOnlyPayments = interestOnlyPayments;
                var interestRateAdjustments = _interestRateAdjustments; interestRateAdjustments.Clean = value; _interestRateAdjustments = interestRateAdjustments;
                var lender = _lender; lender.Clean = value; _lender = lender;
                var maximumPaymentAmt = _maximumPaymentAmt; maximumPaymentAmt.Clean = value; _maximumPaymentAmt = maximumPaymentAmt;
                var maxPayment = _maxPayment; maxPayment.Clean = value; _maxPayment = maxPayment;
                var maxPaymentAmt = _maxPaymentAmt; maxPaymentAmt.Clean = value; _maxPaymentAmt = maxPaymentAmt;
                var monthlyEscrowPayment = _monthlyEscrowPayment; monthlyEscrowPayment.Clean = value; _monthlyEscrowPayment = monthlyEscrowPayment;
                var negativeAmortization = _negativeAmortization; negativeAmortization.Clean = value; _negativeAmortization = negativeAmortization;
                var nonEscrowedPropertyCosts1YearConsummation = _nonEscrowedPropertyCosts1YearConsummation; nonEscrowedPropertyCosts1YearConsummation.Clean = value; _nonEscrowedPropertyCosts1YearConsummation = nonEscrowedPropertyCosts1YearConsummation;
                var other1 = _other1; other1.Clean = value; _other1 = other1;
                var other2 = _other2; other2.Clean = value; _other2 = other2;
                var other3 = _other3; other3.Clean = value; _other3 = other3;
                var partialPayment = _partialPayment; partialPayment.Clean = value; _partialPayment = partialPayment;
                var partialPaymentHoldUntilComplete = _partialPaymentHoldUntilComplete; partialPaymentHoldUntilComplete.Clean = value; _partialPaymentHoldUntilComplete = partialPaymentHoldUntilComplete;
                var partialPaymentNone = _partialPaymentNone; partialPaymentNone.Clean = value; _partialPaymentNone = partialPaymentNone;
                var seasonalPaymentFromYr = _seasonalPaymentFromYr; seasonalPaymentFromYr.Clean = value; _seasonalPaymentFromYr = seasonalPaymentFromYr;
                var seasonalPayments = _seasonalPayments; seasonalPayments.Clean = value; _seasonalPayments = seasonalPayments;
                var stepPayment = _stepPayment; stepPayment.Clean = value; _stepPayment = stepPayment;
                var stepPayments = _stepPayments; stepPayments.Clean = value; _stepPayments = stepPayments;
                var stepRateFirstChange = _stepRateFirstChange; stepRateFirstChange.Clean = value; _stepRateFirstChange = stepRateFirstChange;
                var subsequentChanges = _subsequentChanges; subsequentChanges.Clean = value; _subsequentChanges = subsequentChanges;
                var totalDisbursed1YearConsummation = _totalDisbursed1YearConsummation; totalDisbursed1YearConsummation.Clean = value; _totalDisbursed1YearConsummation = totalDisbursed1YearConsummation;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingDisclosure4()
        {
            Clean = true;
        }
    }
}