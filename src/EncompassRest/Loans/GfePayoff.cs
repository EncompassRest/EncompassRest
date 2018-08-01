using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfePayoff
    /// </summary>
    public sealed partial class GfePayoff : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// GfePayoff Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => _amount = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// GfePayoff Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _gfePayoffIndex;
        /// <summary>
        /// GfePayoff GfePayoffIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? GfePayoffIndex { get => _gfePayoffIndex; set => _gfePayoffIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// GfePayoff Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        internal override bool DirtyInternal
        {
            get => _amount.Dirty
                || _description.Dirty
                || _gfePayoffIndex.Dirty
                || _id.Dirty;
            set
            {
                _amount.Dirty = value;
                _description.Dirty = value;
                _gfePayoffIndex.Dirty = value;
                _id.Dirty = value;
            }
        }
    }
}