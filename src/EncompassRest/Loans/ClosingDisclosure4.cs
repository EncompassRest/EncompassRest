using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingDisclosure4
    /// </summary>
    public sealed partial class ClosingDisclosure4 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<DemandFeature>> _demandFeature;
        /// <summary>
        /// Demand Feature [CD4.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Demand Feature")]
        public StringEnumValue<DemandFeature> DemandFeature { get => _demandFeature; set => _demandFeature = value; }
        private DirtyValue<bool?> _escrowIndicator;
        /// <summary>
        /// Closing Disclosure Page 4 Escrow Indicator [CD4.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure Page 4 Escrow Indicator", OptionsJson = "{\"true\":\"Escrow (T&I)\"}")]
        public bool? EscrowIndicator { get => _escrowIndicator; set => _escrowIndicator = value; }
        private DirtyValue<decimal?> _estimatedPropertyCosts;
        /// <summary>
        /// Estimated Property Costs [CD4.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Estimated Property Costs")]
        public decimal? EstimatedPropertyCosts { get => _estimatedPropertyCosts; set => _estimatedPropertyCosts = value; }
        private DirtyValue<string> _firstChangeAmt;
        /// <summary>
        /// First Change Min Amount [CD4.X30]
        /// </summary>
        [LoanFieldProperty(Description = "First Change Min Amount")]
        public string FirstChangeAmt { get => _firstChangeAmt; set => _firstChangeAmt = value; }
        private DirtyValue<decimal?> _firstChangeMaxAmt;
        /// <summary>
        /// First Change Max Amt [CD4.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "First Change Max Amt")]
        public decimal? FirstChangeMaxAmt { get => _firstChangeMaxAmt; set => _firstChangeMaxAmt = value; }
        private DirtyValue<decimal?> _firstChangeMinAmt;
        /// <summary>
        /// First Change Min Amt [CD4.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "First Change Min Amt")]
        public decimal? FirstChangeMinAmt { get => _firstChangeMinAmt; set => _firstChangeMinAmt = value; }
        private DirtyValue<string> _firstChangePayment;
        /// <summary>
        /// FirstChange Payment [CD4.X37]
        /// </summary>
        [LoanFieldProperty(Description = "FirstChange Payment")]
        public string FirstChangePayment { get => _firstChangePayment; set => _firstChangePayment = value; }
        private DirtyValue<bool?> _hOADuesIsEscrow;
        /// <summary>
        /// Closing Disclosure Page 4 - Is HOA Dues Escrow [CD4.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure Page 4 - Is HOA Dues Escrow")]
        public bool? HOADuesIsEscrow { get => _hOADuesIsEscrow; set => _hOADuesIsEscrow = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingDisclosure4 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _ignoreARMAdj;
        /// <summary>
        /// Ignore 1st ARM Adjustment [CD4.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Ignore 1st ARM Adjustment")]
        public bool? IgnoreARMAdj { get => _ignoreARMAdj; set => _ignoreARMAdj = value; }
        private DirtyValue<decimal?> _initialEscrowPayment;
        /// <summary>
        /// Closing Disclosure Page 4 - Initial Escrow Payment [CD4.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure Page 4 - Initial Escrow Payment")]
        public decimal? InitialEscrowPayment { get => _initialEscrowPayment; set => _initialEscrowPayment = value; }
        private DirtyValue<int?> _interestOnlyPaymentMonths;
        /// <summary>
        /// Closing Disclosure Page 4 Interest Only Payment Months [CD4.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure Page 4 Interest Only Payment Months")]
        public int? InterestOnlyPaymentMonths { get => _interestOnlyPaymentMonths; set => _interestOnlyPaymentMonths = value; }
        private DirtyValue<bool?> _interestOnlyPayments;
        /// <summary>
        /// Interest Only Payments [CD4.X23]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Interest Only Payments")]
        public bool? InterestOnlyPayments { get => _interestOnlyPayments; set => _interestOnlyPayments = value; }
        private DirtyValue<int?> _interestRateAdjustments;
        /// <summary>
        /// Closing Disclosure Page 4 Interest Rate Adjustments [CD4.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Closing Disclosure Page 4 Interest Rate Adjustments")]
        public int? InterestRateAdjustments { get => _interestRateAdjustments; set => _interestRateAdjustments = value; }
        private DirtyValue<bool?> _lender;
        /// <summary>
        /// your lender does not offer one. [CD4.X7]
        /// </summary>
        [LoanFieldProperty(Description = "your lender does not offer one.", OptionsJson = "{\"true\":\"your lender does not offer one\"}")]
        public bool? Lender { get => _lender; set => _lender = value; }
        private DirtyValue<int?> _maximumARMPaymentAmount;
        /// <summary>
        /// Maximum ARM Payment Amount [CD4.X49]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Maximum ARM Payment Amount")]
        public int? MaximumARMPaymentAmount { get => _maximumARMPaymentAmount; set => _maximumARMPaymentAmount = value; }
        private DirtyValue<int?> _maximumARMPaymentMonthReached;
        /// <summary>
        /// Maximum ARM Payment Month Reached [CD4.X50]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Maximum ARM Payment Month Reached")]
        public int? MaximumARMPaymentMonthReached { get => _maximumARMPaymentMonthReached; set => _maximumARMPaymentMonthReached = value; }
        private DirtyValue<string> _maximumPaymentAmt;
        /// <summary>
        /// Maximum Payment Amount [CD4.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Maximum Payment Amount")]
        public string MaximumPaymentAmt { get => _maximumPaymentAmt; set => _maximumPaymentAmt = value; }
        private DirtyValue<string> _maxPayment;
        /// <summary>
        /// Max Payment [CD4.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Max Payment")]
        public string MaxPayment { get => _maxPayment; set => _maxPayment = value; }
        private DirtyValue<decimal?> _maxPaymentAmt;
        /// <summary>
        /// Max payment Amt [CD4.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Max payment Amt")]
        public decimal? MaxPaymentAmt { get => _maxPaymentAmt; set => _maxPaymentAmt = value; }
        private DirtyValue<decimal?> _monthlyEscrowPayment;
        /// <summary>
        /// Closing Disclosure Page 4 Monthly Escrow Payment [CD4.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure Page 4 Monthly Escrow Payment")]
        public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => _monthlyEscrowPayment = value; }
        private DirtyValue<StringEnumValue<NegativeAmortization>> _negativeAmortization;
        /// <summary>
        /// Negative Amortization [CD4.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Negative Amortization")]
        public StringEnumValue<NegativeAmortization> NegativeAmortization { get => _negativeAmortization; set => _negativeAmortization = value; }
        private DirtyValue<decimal?> _nonEscrowedPropertyCosts1YearConsummation;
        /// <summary>
        /// Closing Disclosure Page 4 Non-Escrowed Property Costs Within 1 Year of Consummation [CD4.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure Page 4 Non-Escrowed Property Costs Within 1 Year of Consummation")]
        public decimal? NonEscrowedPropertyCosts1YearConsummation { get => _nonEscrowedPropertyCosts1YearConsummation; set => _nonEscrowedPropertyCosts1YearConsummation = value; }
        private DirtyValue<bool?> _other1;
        /// <summary>
        /// Escrow Other1 [CD4.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Other1")]
        public bool? Other1 { get => _other1; set => _other1 = value; }
        private DirtyValue<bool?> _other2;
        /// <summary>
        /// Escrow Other2 [CD4.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Other2")]
        public bool? Other2 { get => _other2; set => _other2 = value; }
        private DirtyValue<bool?> _other3;
        /// <summary>
        /// Escrow Other3 [CD4.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Other3")]
        public bool? Other3 { get => _other3; set => _other3 = value; }
        private DirtyValue<string> _partialPayment;
        /// <summary>
        /// Partial Payments - Apply Partial Payment [CD4.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Partial Payments - Apply Partial Payment")]
        public string PartialPayment { get => _partialPayment; set => _partialPayment = value; }
        private DirtyValue<string> _partialPaymentHoldUntilComplete;
        /// <summary>
        /// Partial Payments - Hold Until Complete [CD4.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Partial Payments - Hold Until Complete")]
        public string PartialPaymentHoldUntilComplete { get => _partialPaymentHoldUntilComplete; set => _partialPaymentHoldUntilComplete = value; }
        private DirtyValue<string> _partialPaymentNone;
        /// <summary>
        /// Partial Payments - None [CD4.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Partial Payments - None")]
        public string PartialPaymentNone { get => _partialPaymentNone; set => _partialPaymentNone = value; }
        private DirtyValue<string> _seasonalPaymentFromYr;
        /// <summary>
        /// Seasonal Payment From Year [CD4.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Seasonal Payment From Year")]
        public string SeasonalPaymentFromYr { get => _seasonalPaymentFromYr; set => _seasonalPaymentFromYr = value; }
        private DirtyValue<bool?> _seasonalPayments;
        /// <summary>
        /// Seasonal Payments [CD4.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Seasonal Payments")]
        public bool? SeasonalPayments { get => _seasonalPayments; set => _seasonalPayments = value; }
        private DirtyValue<int?> _stepPayment;
        /// <summary>
        /// Step Payment [CD4.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Step Payment")]
        public int? StepPayment { get => _stepPayment; set => _stepPayment = value; }
        private DirtyValue<bool?> _stepPayments;
        /// <summary>
        /// Step Payments [CD4.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Step Payments")]
        public bool? StepPayments { get => _stepPayments; set => _stepPayments = value; }
        private DirtyValue<decimal?> _stepRateFirstChange;
        /// <summary>
        /// Closing Disclosure Page 4 Step Rate First Change [CD4.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Closing Disclosure Page 4 Step Rate First Change")]
        public decimal? StepRateFirstChange { get => _stepRateFirstChange; set => _stepRateFirstChange = value; }
        private DirtyValue<string> _subsequentChanges;
        /// <summary>
        /// Subsequent Changes [CD4.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Subsequent Changes")]
        public string SubsequentChanges { get => _subsequentChanges; set => _subsequentChanges = value; }
        private DirtyValue<decimal?> _totalDisbursed1YearConsummation;
        /// <summary>
        /// Closing Disclosure Page 4 Escrowed Property Costs Within 1 Year of Consummation [CD4.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Closing Disclosure Page 4 Escrowed Property Costs Within 1 Year of Consummation")]
        public decimal? TotalDisbursed1YearConsummation { get => _totalDisbursed1YearConsummation; set => _totalDisbursed1YearConsummation = value; }
        internal override bool DirtyInternal
        {
            get => _demandFeature.Dirty
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
                || _maximumARMPaymentAmount.Dirty
                || _maximumARMPaymentMonthReached.Dirty
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
                || _totalDisbursed1YearConsummation.Dirty;
            set
            {
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
                _maximumARMPaymentAmount.Dirty = value;
                _maximumARMPaymentMonthReached.Dirty = value;
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
            }
        }
    }
}