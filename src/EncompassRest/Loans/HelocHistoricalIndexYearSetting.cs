using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HelocHistoricalIndexYearSetting
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class HelocHistoricalIndexYearSetting : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _helocHistoricalIndexYearSettingIndex;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _indexRate;
        private DirtyValue<int?> _year;

        /// <summary>
        /// HelocHistoricalIndexYearSetting HelocHistoricalIndexYearSettingIndex
        /// </summary>
        public int? HelocHistoricalIndexYearSettingIndex { get => _helocHistoricalIndexYearSettingIndex; set => SetField(ref _helocHistoricalIndexYearSettingIndex, value); }

        /// <summary>
        /// HelocHistoricalIndexYearSetting Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// HELOC Index Table Index [HHINN02]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

        /// <summary>
        /// HELOC Index Table Year [HHINN01]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? Year { get => _year; set => SetField(ref _year, value); }
    }
}