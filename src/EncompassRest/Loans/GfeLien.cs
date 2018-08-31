using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfeLien
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(GfeLienIndex) + "," + nameof(GfeLienType))]
    public sealed partial class GfeLien : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amountOwing;
        /// <summary>
        /// GfeLien AmountOwing
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountOwing { get => _amountOwing; set => SetField(ref _amountOwing, value); }
        private DirtyValue<int?> _gfeLienIndex;
        /// <summary>
        /// GfeLien GfeLienIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? GfeLienIndex { get => _gfeLienIndex; set => SetField(ref _gfeLienIndex, value); }
        private DirtyValue<StringEnumValue<GfeLienType>> _gfeLienType;
        /// <summary>
        /// GfeLien GfeLienType
        /// </summary>
        public StringEnumValue<GfeLienType> GfeLienType { get => _gfeLienType; set => SetField(ref _gfeLienType, value); }
        private DirtyValue<string> _holderName;
        /// <summary>
        /// GfeLien HolderName
        /// </summary>
        public string HolderName { get => _holderName; set => SetField(ref _holderName, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// GfeLien Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _priority;
        /// <summary>
        /// GfeLien Priority
        /// </summary>
        public string Priority { get => _priority; set => SetField(ref _priority, value); }
    }
}