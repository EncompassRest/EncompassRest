using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfePayoff
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(GfePayoffIndex))]
    public sealed partial class GfePayoff : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// GfePayoff Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<string> _description;
        /// <summary>
        /// GfePayoff Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<int?> _gfePayoffIndex;
        /// <summary>
        /// GfePayoff GfePayoffIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? GfePayoffIndex { get => _gfePayoffIndex; set => SetField(ref _gfePayoffIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// GfePayoff Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
    }
}