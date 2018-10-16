using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FeeVariance
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(FeeVarianceChargeIndex) + "," + nameof(FeeVarianceFeeType))]
    public sealed partial class FeeVariance : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _cD;
        private DirtyValue<string> _description;
        private DirtyValue<int?> _feeVarianceChargeIndex;
        private DirtyValue<StringEnumValue<FeeVarianceFeeType>> _feeVarianceFeeType;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _initialLE;
        private DirtyValue<decimal?> _itemization;
        private DirtyValue<decimal?> _lE;
        private DirtyValue<string> _line;

        /// <summary>
        /// FeeVariance CD
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD { get => _cD; set => SetField(ref _cD, value); }

        /// <summary>
        /// FeeVariance Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }

        /// <summary>
        /// FeeVariance FeeVarianceChargeIndex
        /// </summary>
        public int? FeeVarianceChargeIndex { get => _feeVarianceChargeIndex; set => SetField(ref _feeVarianceChargeIndex, value); }

        /// <summary>
        /// FeeVariance FeeVarianceFeeType
        /// </summary>
        public StringEnumValue<FeeVarianceFeeType> FeeVarianceFeeType { get => _feeVarianceFeeType; set => SetField(ref _feeVarianceFeeType, value); }

        /// <summary>
        /// FeeVariance Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// FeeVariance InitialLE
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialLE { get => _initialLE; set => SetField(ref _initialLE, value); }

        /// <summary>
        /// FeeVariance Itemization
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Itemization { get => _itemization; set => SetField(ref _itemization, value); }

        /// <summary>
        /// FeeVariance LE
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LE { get => _lE; set => SetField(ref _lE, value); }

        /// <summary>
        /// FeeVariance Line
        /// </summary>
        public string Line { get => _line; set => SetField(ref _line, value); }
    }
}