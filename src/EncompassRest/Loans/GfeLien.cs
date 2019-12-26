using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// GfeLien
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(GfeLienIndex) + "," + nameof(GfeLienType))]
    public sealed partial class GfeLien : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _amountOwing;
        private DirtyValue<int?>? _gfeLienIndex;
        private DirtyValue<StringEnumValue<GfeLienType>>? _gfeLienType;
        private DirtyValue<string?>? _holderName;
        private DirtyValue<string?>? _id;
        private DirtyValue<string?>? _priority;

        /// <summary>
        /// GfeLien AmountOwing
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountOwing { get => _amountOwing; set => SetField(ref _amountOwing, value); }

        /// <summary>
        /// GfeLien GfeLienIndex
        /// </summary>
        public int? GfeLienIndex { get => _gfeLienIndex; set => SetField(ref _gfeLienIndex, value); }

        /// <summary>
        /// GfeLien GfeLienType
        /// </summary>
        public StringEnumValue<GfeLienType> GfeLienType { get => _gfeLienType; set => SetField(ref _gfeLienType, value); }

        /// <summary>
        /// GfeLien HolderName
        /// </summary>
        public string? HolderName { get => _holderName; set => SetField(ref _holderName, value); }

        /// <summary>
        /// GfeLien Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// GfeLien Priority
        /// </summary>
        public string? Priority { get => _priority; set => SetField(ref _priority, value); }
    }
}