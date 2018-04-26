using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010WholePoc
    /// </summary>
    public sealed partial class Gfe2010WholePoc : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _gfe2010WholePocIndex;
        /// <summary>
        /// Gfe2010WholePoc Gfe2010WholePocIndex
        /// </summary>
        public int? Gfe2010WholePocIndex { get => _gfe2010WholePocIndex; set => _gfe2010WholePocIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010WholePoc Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// Gfe2010WholePoc LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => _lineNumber = value; }
        private DirtyValue<decimal?> _wholePoc;
        /// <summary>
        /// Gfe2010WholePoc WholePoc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? WholePoc { get => _wholePoc; set => _wholePoc = value; }
        private DirtyValue<StringEnumValue<WholePocPaidByType>> _wholePocPaidByType;
        /// <summary>
        /// Gfe2010WholePoc WholePocPaidByType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Other\":\"O\"}")]
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => _wholePocPaidByType = value; }
        internal override bool DirtyInternal
        {
            get => _gfe2010WholePocIndex.Dirty
                || _id.Dirty
                || _lineNumber.Dirty
                || _wholePoc.Dirty
                || _wholePocPaidByType.Dirty;
            set
            {
                _gfe2010WholePocIndex.Dirty = value;
                _id.Dirty = value;
                _lineNumber.Dirty = value;
                _wholePoc.Dirty = value;
                _wholePocPaidByType.Dirty = value;
            }
        }
    }
}