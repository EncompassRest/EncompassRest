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
        private DirtyValue<StringEnumValue<NonVolAdjustmentType>> _adjustmentType;
        /// <summary>
        /// UCD Adjustment Type [UNFLNN01]
        /// </summary>
        [LoanFieldProperty(Description = "UCD Adjustment Type")]
        public StringEnumValue<NonVolAdjustmentType> AdjustmentType { get => _adjustmentType; set => _adjustmentType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// NonVol Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _includedIndicator;
        /// <summary>
        /// Liability Will be Paid Off and will be included [UNFLNN05]
        /// </summary>
        [LoanFieldProperty(Description = "Liability Will be Paid Off and will be included", OptionsJson = "{\"true\":\"Paid off (*) will be included\"}")]
        public bool? IncludedIndicator { get => _includedIndicator; set => _includedIndicator = value; }
        private DirtyValue<string> _nonVolId;
        /// <summary>
        /// NonVol NonVolId
        /// </summary>
        public string NonVolId { get => _nonVolId; set => _nonVolId = value; }
        private DirtyValue<int?> _nonVolIndex;
        /// <summary>
        /// NonVol NonVolIndex
        /// </summary>
        public int? NonVolIndex { get => _nonVolIndex; set => _nonVolIndex = value; }
        private DirtyValue<StringEnumValue<PaidToOrBy>> _paidBy;
        /// <summary>
        /// Paid By [UNFLNN07]
        /// </summary>
        [LoanFieldProperty(Description = "Paid By")]
        public StringEnumValue<PaidToOrBy> PaidBy { get => _paidBy; set => _paidBy = value; }
        private DirtyValue<StringEnumValue<PaidToOrBy>> _paidTo;
        /// <summary>
        /// Paid To [UNFLNN09]
        /// </summary>
        [LoanFieldProperty(Description = "Paid To")]
        public StringEnumValue<PaidToOrBy> PaidTo { get => _paidTo; set => _paidTo = value; }
        private DirtyValue<bool?> _pOCIndicator;
        /// <summary>
        /// POC Indicator [UNFLNN06]
        /// </summary>
        [LoanFieldProperty(Description = "POC Indicator", OptionsJson = "{\"true\":\"Paid off (*) will be included\"}")]
        public bool? POCIndicator { get => _pOCIndicator; set => _pOCIndicator = value; }
        private DirtyValue<string> _principalCureAddendum;
        /// <summary>
        /// PrincipalCureAddendum Amount [UNFLNN08]
        /// </summary>
        [LoanFieldProperty(Description = "PrincipalCureAddendum Amount")]
        public string PrincipalCureAddendum { get => _principalCureAddendum; set => _principalCureAddendum = value; }
    }
}