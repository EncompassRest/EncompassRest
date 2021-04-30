using EncompassRest.Loans.v1.Enums;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Gfe2010WholePoc
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(Gfe2010WholePocIndex) + "," + nameof(LineNumber))]
    public sealed partial class Gfe2010WholePoc : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _gfe2010WholePocIndex;
        private DirtyValue<string?>? _id;
        private DirtyValue<int?>? _lineNumber;
        private DirtyValue<decimal?>? _wholePoc;
        private DirtyValue<StringEnumValue<WholePocPaidByType>>? _wholePocPaidByType;

        /// <summary>
        /// Gfe2010WholePoc Gfe2010WholePocIndex
        /// </summary>
        public int? Gfe2010WholePocIndex { get => _gfe2010WholePocIndex; set => SetField(ref _gfe2010WholePocIndex, value); }

        /// <summary>
        /// Gfe2010WholePoc Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Gfe2010WholePoc LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

        /// <summary>
        /// Gfe2010WholePoc WholePoc
        /// </summary>
        public decimal? WholePoc { get => _wholePoc; set => SetField(ref _wholePoc, value); }

        /// <summary>
        /// Gfe2010WholePoc WholePocPaidByType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Other\":\"O\"}")]
        public StringEnumValue<WholePocPaidByType> WholePocPaidByType { get => _wholePocPaidByType; set => SetField(ref _wholePocPaidByType, value); }
    }
}