using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ClosingDisclosure4 : IDirty
    {
        private DirtyValue<StringEnumValue<DemandFeature>> _demandFeature;
        public StringEnumValue<DemandFeature> DemandFeature { get => _demandFeature; set => _demandFeature = value; }
        private DirtyValue<bool?> _escrowIndicator;
        public bool? EscrowIndicator { get => _escrowIndicator; set => _escrowIndicator = value; }
        private DirtyValue<decimal?> _estimatedPropertyCosts;
        public decimal? EstimatedPropertyCosts { get => _estimatedPropertyCosts; set => _estimatedPropertyCosts = value; }
        private DirtyValue<string> _firstChangeAmt;
        public string FirstChangeAmt { get => _firstChangeAmt; set => _firstChangeAmt = value; }
        private DirtyValue<decimal?> _firstChangeMaxAmt;
        public decimal? FirstChangeMaxAmt { get => _firstChangeMaxAmt; set => _firstChangeMaxAmt = value; }
        private DirtyValue<decimal?> _firstChangeMinAmt;
        public decimal? FirstChangeMinAmt { get => _firstChangeMinAmt; set => _firstChangeMinAmt = value; }
        private DirtyValue<string> _firstChangePayment;
        public string FirstChangePayment { get => _firstChangePayment; set => _firstChangePayment = value; }
        private DirtyValue<bool?> _hOADuesIsEscrow;
        public bool? HOADuesIsEscrow { get => _hOADuesIsEscrow; set => _hOADuesIsEscrow = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ignoreARMAdj;
        public bool? IgnoreARMAdj { get => _ignoreARMAdj; set => _ignoreARMAdj = value; }
        private DirtyValue<decimal?> _initialEscrowPayment;
        public decimal? InitialEscrowPayment { get => _initialEscrowPayment; set => _initialEscrowPayment = value; }
        private DirtyValue<int?> _interestOnlyPaymentMonths;
        public int? InterestOnlyPaymentMonths { get => _interestOnlyPaymentMonths; set => _interestOnlyPaymentMonths = value; }
        private DirtyValue<bool?> _interestOnlyPayments;
        public bool? InterestOnlyPayments { get => _interestOnlyPayments; set => _interestOnlyPayments = value; }
        private DirtyValue<int?> _interestRateAdjustments;
        public int? InterestRateAdjustments { get => _interestRateAdjustments; set => _interestRateAdjustments = value; }
        private DirtyValue<bool?> _lender;
        public bool? Lender { get => _lender; set => _lender = value; }
        private DirtyValue<string> _maximumPaymentAmt;
        public string MaximumPaymentAmt { get => _maximumPaymentAmt; set => _maximumPaymentAmt = value; }
        private DirtyValue<string> _maxPayment;
        public string MaxPayment { get => _maxPayment; set => _maxPayment = value; }
        private DirtyValue<decimal?> _maxPaymentAmt;
        public decimal? MaxPaymentAmt { get => _maxPaymentAmt; set => _maxPaymentAmt = value; }
        private DirtyValue<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => _monthlyEscrowPayment = value; }
        private DirtyValue<StringEnumValue<NegativeAmortization>> _negativeAmortization;
        public StringEnumValue<NegativeAmortization> NegativeAmortization { get => _negativeAmortization; set => _negativeAmortization = value; }
        private DirtyValue<decimal?> _nonEscrowedPropertyCosts1YearConsummation;
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get => _nonEscrowedPropertyCosts1YearConsummation; set => _nonEscrowedPropertyCosts1YearConsummation = value; }
        private DirtyValue<bool?> _other1;
        public bool? Other1 { get => _other1; set => _other1 = value; }
        private DirtyValue<bool?> _other2;
        public bool? Other2 { get => _other2; set => _other2 = value; }
        private DirtyValue<bool?> _other3;
        public bool? Other3 { get => _other3; set => _other3 = value; }
        private DirtyValue<string> _partialPayment;
        public string PartialPayment { get => _partialPayment; set => _partialPayment = value; }
        private DirtyValue<string> _partialPaymentHoldUntilComplete;
        public string PartialPaymentHoldUntilComplete { get => _partialPaymentHoldUntilComplete; set => _partialPaymentHoldUntilComplete = value; }
        private DirtyValue<string> _partialPaymentNone;
        public string PartialPaymentNone { get => _partialPaymentNone; set => _partialPaymentNone = value; }
        private DirtyValue<string> _seasonalPaymentFromYr;
        public string SeasonalPaymentFromYr { get => _seasonalPaymentFromYr; set => _seasonalPaymentFromYr = value; }
        private DirtyValue<bool?> _seasonalPayments;
        public bool? SeasonalPayments { get => _seasonalPayments; set => _seasonalPayments = value; }
        private DirtyValue<int?> _stepPayment;
        public int? StepPayment { get => _stepPayment; set => _stepPayment = value; }
        private DirtyValue<bool?> _stepPayments;
        public bool? StepPayments { get => _stepPayments; set => _stepPayments = value; }
        private DirtyValue<decimal?> _stepRateFirstChange;
        public decimal? StepRateFirstChange { get => _stepRateFirstChange; set => _stepRateFirstChange = value; }
        private DirtyValue<string> _subsequentChanges;
        public string SubsequentChanges { get => _subsequentChanges; set => _subsequentChanges = value; }
        private DirtyValue<decimal?> _totalDisbursed1YearConsummation;
        public decimal? TotalDisbursed1YearConsummation { get => _totalDisbursed1YearConsummation; set => _totalDisbursed1YearConsummation = value; }
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
                var dirty = _demandFeature.Dirty
                    || _escrowIndicator.Dirty
                    || _estimatedPropertyCosts.Dirty
                    || _firstChangeAmt.Dirty
                    || _firstChangeMaxAmt.Dirty
                    || _firstChangeMinAmt.Dirty
                    || _firstChangePayment.Dirty
                    || _hOADuesIsEscrow.Dirty
                    || _id.Dirty
                    || _ignoreARMAdj.Dirty
                    || _initialEscrowPayment.Dirty
                    || _interestOnlyPaymentMonths.Dirty
                    || _interestOnlyPayments.Dirty
                    || _interestRateAdjustments.Dirty
                    || _lender.Dirty
                    || _maximumPaymentAmt.Dirty
                    || _maxPayment.Dirty
                    || _maxPaymentAmt.Dirty
                    || _monthlyEscrowPayment.Dirty
                    || _negativeAmortization.Dirty
                    || _nonEscrowedPropertyCosts1YearConsummation.Dirty
                    || _other1.Dirty
                    || _other2.Dirty
                    || _other3.Dirty
                    || _partialPayment.Dirty
                    || _partialPaymentHoldUntilComplete.Dirty
                    || _partialPaymentNone.Dirty
                    || _seasonalPaymentFromYr.Dirty
                    || _seasonalPayments.Dirty
                    || _stepPayment.Dirty
                    || _stepPayments.Dirty
                    || _stepRateFirstChange.Dirty
                    || _subsequentChanges.Dirty
                    || _totalDisbursed1YearConsummation.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _demandFeature.Dirty = value;
                _escrowIndicator.Dirty = value;
                _estimatedPropertyCosts.Dirty = value;
                _firstChangeAmt.Dirty = value;
                _firstChangeMaxAmt.Dirty = value;
                _firstChangeMinAmt.Dirty = value;
                _firstChangePayment.Dirty = value;
                _hOADuesIsEscrow.Dirty = value;
                _id.Dirty = value;
                _ignoreARMAdj.Dirty = value;
                _initialEscrowPayment.Dirty = value;
                _interestOnlyPaymentMonths.Dirty = value;
                _interestOnlyPayments.Dirty = value;
                _interestRateAdjustments.Dirty = value;
                _lender.Dirty = value;
                _maximumPaymentAmt.Dirty = value;
                _maxPayment.Dirty = value;
                _maxPaymentAmt.Dirty = value;
                _monthlyEscrowPayment.Dirty = value;
                _negativeAmortization.Dirty = value;
                _nonEscrowedPropertyCosts1YearConsummation.Dirty = value;
                _other1.Dirty = value;
                _other2.Dirty = value;
                _other3.Dirty = value;
                _partialPayment.Dirty = value;
                _partialPaymentHoldUntilComplete.Dirty = value;
                _partialPaymentNone.Dirty = value;
                _seasonalPaymentFromYr.Dirty = value;
                _seasonalPayments.Dirty = value;
                _stepPayment.Dirty = value;
                _stepPayments.Dirty = value;
                _stepRateFirstChange.Dirty = value;
                _subsequentChanges.Dirty = value;
                _totalDisbursed1YearConsummation.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}