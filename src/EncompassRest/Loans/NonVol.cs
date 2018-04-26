using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// NonVol
    /// </summary>
    public sealed partial class NonVol : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustmentAmount;
        /// <summary>
        /// Adjustment Amount [UNFLNN04]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Adjustment Amount")]
        public decimal? AdjustmentAmount { get => _adjustmentAmount; set => _adjustmentAmount = value; }
        private DirtyValue<string> _adjustmentDescription;
        /// <summary>
        /// Adjustment Description [UNFLNN02]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustment Description")]
        public string AdjustmentDescription { get => _adjustmentDescription; set => _adjustmentDescription = value; }
        private DirtyValue<string> _adjustmentOtherDescription;
        /// <summary>
        /// Adjustment Other Description [UNFLNN03]
        /// </summary>
        [LoanFieldProperty(Description = "Adjustment Other Description")]
        public string AdjustmentOtherDescription { get => _adjustmentOtherDescription; set => _adjustmentOtherDescription = value; }
        private DirtyValue<StringEnumValue<AdjustmentType>> _adjustmentType;
        /// <summary>
        /// UCD Adjustment Type [UNFLNN01]
        /// </summary>
        [LoanFieldProperty(Description = "UCD Adjustment Type")]
        public StringEnumValue<AdjustmentType> AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<bool?> _includedIndicator;
        /// <summary>
        /// Liability Will be Paid Off and will be included [UNFLNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off and will be included", OptionsJson = "{\"true\":\"Paid off (*) will be included\"}")]
        public bool? IncludedIndicator { get => _includedIndicator; set => _includedIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _adjustmentAmount.Dirty
                || _adjustmentDescription.Dirty
                || _adjustmentOtherDescription.Dirty
                || _adjustmentType.Dirty
                || _includedIndicator.Dirty;
            set
            {
                _adjustmentAmount.Dirty = value;
                _adjustmentDescription.Dirty = value;
                _adjustmentOtherDescription.Dirty = value;
                _adjustmentType.Dirty = value;
                _includedIndicator.Dirty = value;
            }
        }
    }
}