using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UCDDetail
    /// </summary>
    public sealed partial class UCDDetail : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<UCDPayoffType>> _feeAccountType;
        /// <summary>
        /// UCDDetail FeeAccountType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Open30DayChargeAccount\":\"Open 30 Day Charge Account\"}")]
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => _feeAccountType = value; }
        private DirtyValue<decimal?> _feeAmount;
        /// <summary>
        /// UCDDetail FeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeeAmount { get => _feeAmount; set => _feeAmount = value; }
        private DirtyValue<DateTime?> _feeDateFrom;
        /// <summary>
        /// UCDDetail FeeDateFrom
        /// </summary>
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => _feeDateFrom = value; }
        private DirtyValue<DateTime?> _feeDateTo;
        /// <summary>
        /// UCDDetail FeeDateTo
        /// </summary>
        public DateTime? FeeDateTo { get => _feeDateTo; set => _feeDateTo = value; }
        private DirtyValue<string> _feeDesc;
        /// <summary>
        /// UCDDetail FeeDesc
        /// </summary>
        public string FeeDesc { get => _feeDesc; set => _feeDesc = value; }
        private DirtyValue<int?> _feeIndex;
        /// <summary>
        /// UCDDetail FeeIndex
        /// </summary>
        public int? FeeIndex { get => _feeIndex; set => _feeIndex = value; }
        private DirtyValue<StringEnumValue<FeePaidBy>> _feePaidBy;
        /// <summary>
        /// UCDDetail FeePaidBy
        /// </summary>
        public StringEnumValue<FeePaidBy> FeePaidBy { get => _feePaidBy; set => _feePaidBy = value; }
        private DirtyValue<string> _feePaidTo;
        /// <summary>
        /// UCDDetail FeePaidTo
        /// </summary>
        public string FeePaidTo { get => _feePaidTo; set => _feePaidTo = value; }
        private DirtyValue<bool?> _feePOC;
        /// <summary>
        /// UCDDetail FeePOC
        /// </summary>
        public bool? FeePOC { get => _feePOC; set => _feePOC = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// UCDDetail Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// UCDDetail LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<string> _section;
        /// <summary>
        /// UCDDetail Section
        /// </summary>
        public string Section { get => _section; set => _section = value; }
        internal override bool DirtyInternal
        {
            get => _feeAccountType.Dirty
                || _feeAmount.Dirty
                || _feeDateFrom.Dirty
                || _feeDateTo.Dirty
                || _feeDesc.Dirty
                || _feeIndex.Dirty
                || _feePaidBy.Dirty
                || _feePaidTo.Dirty
                || _feePOC.Dirty
                || _id.Dirty
                || _lineNumber.Dirty
                || _section.Dirty;
            set
            {
                _feeAccountType.Dirty = value;
                _feeAmount.Dirty = value;
                _feeDateFrom.Dirty = value;
                _feeDateTo.Dirty = value;
                _feeDesc.Dirty = value;
                _feeIndex.Dirty = value;
                _feePaidBy.Dirty = value;
                _feePaidTo.Dirty = value;
                _feePOC.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _section.Dirty = value;
            }
        }
    }
}