using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ElliLOCompensation
    /// </summary>
    public sealed partial class ElliLOCompensation : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount [LCP.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Additional Amount")]
        public decimal? AdjustedPlanAdditonalAmountForBroker { get => _adjustedPlanAdditonalAmountForBroker; set => _adjustedPlanAdditonalAmountForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanAdditonalAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount [LCP.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Additional Amount")]
        public decimal? AdjustedPlanAdditonalAmountForOfficer { get => _adjustedPlanAdditonalAmountForOfficer; set => _adjustedPlanAdditonalAmountForOfficer = value; }
        private DirtyValue<decimal?> _adjustedPlanAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount [LCP.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Amount")]
        public decimal? AdjustedPlanAmountForBroker { get => _adjustedPlanAmountForBroker; set => _adjustedPlanAmountForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount [LCP.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Amount")]
        public decimal? AdjustedPlanAmountForOfficer { get => _adjustedPlanAmountForOfficer; set => _adjustedPlanAmountForOfficer = value; }
        private DirtyValue<decimal?> _adjustedPlanRateForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage [LCP.X11]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Adjusted Plan Percentage")]
        public decimal? AdjustedPlanRateForBroker { get => _adjustedPlanRateForBroker; set => _adjustedPlanRateForBroker = value; }
        private DirtyValue<decimal?> _adjustedPlanRateForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage [LCP.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjusted Plan Percentage")]
        public decimal? AdjustedPlanRateForOfficer { get => _adjustedPlanRateForOfficer; set => _adjustedPlanRateForOfficer = value; }
        private DirtyValue<string> _adjustmentDescription;
        /// <summary>
        /// Loan Compensation Plan - Adjustment Description [LCP.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Adjustment Description")]
        public string AdjustmentDescription { get => _adjustmentDescription; set => _adjustmentDescription = value; }
        private DirtyValue<string> _adjustmentDescriptionForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description [LCP.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Adjustment Description")]
        public string AdjustmentDescriptionForOfficer { get => _adjustmentDescriptionForOfficer; set => _adjustmentDescriptionForOfficer = value; }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount [LCP.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Additional Amount")]
        public decimal? BasePlanAdditonalAmountForBroker { get => _basePlanAdditonalAmountForBroker; set => _basePlanAdditonalAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanAdditonalAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount [LCP.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Additional Amount")]
        public decimal? BasePlanAdditonalAmountForOfficer { get => _basePlanAdditonalAmountForOfficer; set => _basePlanAdditonalAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount [LCP.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Amount")]
        public decimal? BasePlanAmountForBroker { get => _basePlanAmountForBroker; set => _basePlanAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount [LCP.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Amount")]
        public decimal? BasePlanAmountForOfficer { get => _basePlanAmountForOfficer; set => _basePlanAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanMaximumAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount [LCP.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Maximum Amount")]
        public decimal? BasePlanMaximumAmountForBroker { get => _basePlanMaximumAmountForBroker; set => _basePlanMaximumAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanMaximumAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount [LCP.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Maximum Amount")]
        public decimal? BasePlanMaximumAmountForOfficer { get => _basePlanMaximumAmountForOfficer; set => _basePlanMaximumAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanMinimumAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount [LCP.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Minimum Amount")]
        public decimal? BasePlanMinimumAmountForBroker { get => _basePlanMinimumAmountForBroker; set => _basePlanMinimumAmountForBroker = value; }
        private DirtyValue<decimal?> _basePlanMinimumAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount [LCP.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Minimum Amount")]
        public decimal? BasePlanMinimumAmountForOfficer { get => _basePlanMinimumAmountForOfficer; set => _basePlanMinimumAmountForOfficer = value; }
        private DirtyValue<decimal?> _basePlanRateForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage [LCP.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Base Plan Percentage")]
        public decimal? BasePlanRateForBroker { get => _basePlanRateForBroker; set => _basePlanRateForBroker = value; }
        private DirtyValue<decimal?> _basePlanRateForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage [LCP.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Base Plan Percentage")]
        public decimal? BasePlanRateForOfficer { get => _basePlanRateForOfficer; set => _basePlanRateForOfficer = value; }
        private DirtyValue<decimal?> _bonusCompAdditonalAmount;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount [LCP.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Additional Amount")]
        public decimal? BonusCompAdditonalAmount { get => _bonusCompAdditonalAmount; set => _bonusCompAdditonalAmount = value; }
        private DirtyValue<decimal?> _bonusCompAmount;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount [LCP.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Amount")]
        public decimal? BonusCompAmount { get => _bonusCompAmount; set => _bonusCompAmount = value; }
        private DirtyValue<decimal?> _bonusCompRate;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage [LCP.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_5, Description = "Loan Compensation Plan - Loan Officer Plan Details - Bonus Comp Percentage")]
        public decimal? BonusCompRate { get => _bonusCompRate; set => _bonusCompRate = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ElliLOCompensation Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<DateTime?> _lastAppliedDate;
        /// <summary>
        /// Loan Compensation Plan - Last Applied Date [LCP.X20]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Compensation Plan - Last Applied Date")]
        public DateTime? LastAppliedDate { get => _lastAppliedDate; set => _lastAppliedDate = value; }
        private DirtyValue<string> _lastAppliedDateTime;
        /// <summary>
        /// Loan Compensation Plan - Last Applied Date and Time [LCP.X19]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Compensation Plan - Last Applied Date and Time")]
        public string LastAppliedDateTime { get => _lastAppliedDateTime; set => _lastAppliedDateTime = value; }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountType;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type [LCP.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Amount Type")]
        public StringEnumValue<LoanAmountType> LoanAmountType { get => _loanAmountType; set => _loanAmountType = value; }
        private DirtyValue<StringEnumValue<LoanAmountType>> _loanAmountTypeForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type [LCP.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Amount Type")]
        public StringEnumValue<LoanAmountType> LoanAmountTypeForOfficer { get => _loanAmountTypeForOfficer; set => _loanAmountTypeForOfficer = value; }
        private DirtyValue<string> _loanOriginatorID;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID [LCP.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator ID")]
        public string LoanOriginatorID { get => _loanOriginatorID; set => _loanOriginatorID = value; }
        private DirtyValue<string> _loanOriginatorIDForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID [LCP.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Officer ID")]
        public string LoanOriginatorIDForOfficer { get => _loanOriginatorIDForOfficer; set => _loanOriginatorIDForOfficer = value; }
        private DirtyValue<string> _loanOriginatorName;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name [LCP.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Loan Originator Name")]
        public string LoanOriginatorName { get => _loanOriginatorName; set => _loanOriginatorName = value; }
        private DirtyValue<string> _loanOriginatorNameForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name [LCP.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Loan Officer Name")]
        public string LoanOriginatorNameForOfficer { get => _loanOriginatorNameForOfficer; set => _loanOriginatorNameForOfficer = value; }
        private DirtyValue<decimal?> _netAdjustedAmountForBroker;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount [LCP.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Net Adjusted Amount")]
        public decimal? NetAdjustedAmountForBroker { get => _netAdjustedAmountForBroker; set => _netAdjustedAmountForBroker = value; }
        private DirtyValue<decimal?> _netAdjustedAmountForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount [LCP.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Compensation Plan - Loan Officer Plan Details - Net Adjusted Amount")]
        public decimal? NetAdjustedAmountForOfficer { get => _netAdjustedAmountForOfficer; set => _netAdjustedAmountForOfficer = value; }
        private DirtyValue<DateTime?> _planDate;
        /// <summary>
        /// Loan Compensation Plan - Plan Date [LCP.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Plan Date")]
        public DateTime? PlanDate { get => _planDate; set => _planDate = value; }
        private DirtyValue<string> _planName;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name [LCP.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Plan Name")]
        public string PlanName { get => _planName; set => _planName = value; }
        private DirtyValue<string> _planNameForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Plan Name [LCP.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Plan Name")]
        public string PlanNameForOfficer { get => _planNameForOfficer; set => _planNameForOfficer = value; }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethod;
        /// <summary>
        /// Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method [LCP.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Wholesale/Broker Plan Details - Rounding Method")]
        public StringEnumValue<RoundingMethod> RoundingMethod { get => _roundingMethod; set => _roundingMethod = value; }
        private DirtyValue<StringEnumValue<RoundingMethod>> _roundingMethodForOfficer;
        /// <summary>
        /// Loan Compensation Plan - Loan Officer Plan Details - Rounding Method [LCP.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Loan Officer Plan Details - Rounding Method")]
        public StringEnumValue<RoundingMethod> RoundingMethodForOfficer { get => _roundingMethodForOfficer; set => _roundingMethodForOfficer = value; }
        private DirtyValue<string> _triggerField;
        /// <summary>
        /// Loan Compensation Plan - Trigger Field [LCP.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Trigger Field")]
        public string TriggerField { get => _triggerField; set => _triggerField = value; }
        private DirtyValue<StringEnumValue<WhoPaidCompensation>> _whoPaidCompensation;
        /// <summary>
        /// Loan Compensation Plan - Brrower/Lender Paid [LCP.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Compensation Plan - Brrower/Lender Paid")]
        public StringEnumValue<WhoPaidCompensation> WhoPaidCompensation { get => _whoPaidCompensation; set => _whoPaidCompensation = value; }
        internal override bool DirtyInternal
        {
            get => _adjustedPlanAdditonalAmountForBroker.Dirty
                || _adjustedPlanAdditonalAmountForOfficer.Dirty
                || _adjustedPlanAmountForBroker.Dirty
                || _adjustedPlanAmountForOfficer.Dirty
                || _adjustedPlanRateForBroker.Dirty
                || _adjustedPlanRateForOfficer.Dirty
                || _adjustmentDescription.Dirty
                || _adjustmentDescriptionForOfficer.Dirty
                || _basePlanAdditonalAmountForBroker.Dirty
                || _basePlanAdditonalAmountForOfficer.Dirty
                || _basePlanAmountForBroker.Dirty
                || _basePlanAmountForOfficer.Dirty
                || _basePlanMaximumAmountForBroker.Dirty
                || _basePlanMaximumAmountForOfficer.Dirty
                || _basePlanMinimumAmountForBroker.Dirty
                || _basePlanMinimumAmountForOfficer.Dirty
                || _basePlanRateForBroker.Dirty
                || _basePlanRateForOfficer.Dirty
                || _bonusCompAdditonalAmount.Dirty
                || _bonusCompAmount.Dirty
                || _bonusCompRate.Dirty
                || _id.Dirty
                || _lastAppliedDate.Dirty
                || _lastAppliedDateTime.Dirty
                || _loanAmountType.Dirty
                || _loanAmountTypeForOfficer.Dirty
                || _loanOriginatorID.Dirty
                || _loanOriginatorIDForOfficer.Dirty
                || _loanOriginatorName.Dirty
                || _loanOriginatorNameForOfficer.Dirty
                || _netAdjustedAmountForBroker.Dirty
                || _netAdjustedAmountForOfficer.Dirty
                || _planDate.Dirty
                || _planName.Dirty
                || _planNameForOfficer.Dirty
                || _roundingMethod.Dirty
                || _roundingMethodForOfficer.Dirty
                || _triggerField.Dirty
                || _whoPaidCompensation.Dirty;
            set
            {
                _adjustedPlanAdditonalAmountForBroker.Dirty = value;
                _adjustedPlanAdditonalAmountForOfficer.Dirty = value;
                _adjustedPlanAmountForBroker.Dirty = value;
                _adjustedPlanAmountForOfficer.Dirty = value;
                _adjustedPlanRateForBroker.Dirty = value;
                _adjustedPlanRateForOfficer.Dirty = value;
                _adjustmentDescription.Dirty = value;
                _adjustmentDescriptionForOfficer.Dirty = value;
                _basePlanAdditonalAmountForBroker.Dirty = value;
                _basePlanAdditonalAmountForOfficer.Dirty = value;
                _basePlanAmountForBroker.Dirty = value;
                _basePlanAmountForOfficer.Dirty = value;
                _basePlanMaximumAmountForBroker.Dirty = value;
                _basePlanMaximumAmountForOfficer.Dirty = value;
                _basePlanMinimumAmountForBroker.Dirty = value;
                _basePlanMinimumAmountForOfficer.Dirty = value;
                _basePlanRateForBroker.Dirty = value;
                _basePlanRateForOfficer.Dirty = value;
                _bonusCompAdditonalAmount.Dirty = value;
                _bonusCompAmount.Dirty = value;
                _bonusCompRate.Dirty = value;
                _id.Dirty = value;
                _lastAppliedDate.Dirty = value;
                _lastAppliedDateTime.Dirty = value;
                _loanAmountType.Dirty = value;
                _loanAmountTypeForOfficer.Dirty = value;
                _loanOriginatorID.Dirty = value;
                _loanOriginatorIDForOfficer.Dirty = value;
                _loanOriginatorName.Dirty = value;
                _loanOriginatorNameForOfficer.Dirty = value;
                _netAdjustedAmountForBroker.Dirty = value;
                _netAdjustedAmountForOfficer.Dirty = value;
                _planDate.Dirty = value;
                _planName.Dirty = value;
                _planNameForOfficer.Dirty = value;
                _roundingMethod.Dirty = value;
                _roundingMethodForOfficer.Dirty = value;
                _triggerField.Dirty = value;
                _whoPaidCompensation.Dirty = value;
            }
        }
    }
}