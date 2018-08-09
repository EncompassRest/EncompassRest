using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// FeeVariance
    /// </summary>
    public sealed partial class FeeVariance : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _cD;
        /// <summary>
        /// FeeVariance CD
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CD { get => _cD; set => _cD = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// FeeVariance Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<int?> _feeVarianceChargeIndex;
        /// <summary>
        /// FeeVariance FeeVarianceChargeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"10\":\"10\",\"8\":\"8\",\"9\":\"9\",\"11\":\"11\",\"12\":\"12\",\"13\":\"13\",\"14\":\"14\",\"15\":\"15\",\"16\":\"16\",\"17\":\"17\",\"18\":\"18\",\"19\":\"19\",\"20\":\"20\",\"21\":\"21\",\"22\":\"22\",\"23\":\"23\",\"24\":\"24\",\"25\":\"25\",\"26\":\"26\",\"27\":\"27\",\"30\":\"30\",\"31\":\"31\",\"28\":\"28\",\"29\":\"29\",\"32\":\"32\",\"33\":\"33\",\"34\":\"34\"}")]
        public int? FeeVarianceChargeIndex { get => _feeVarianceChargeIndex; set => _feeVarianceChargeIndex = value; }
        private DirtyValue<StringEnumValue<FeeVarianceFeeType>> _feeVarianceFeeType;
        /// <summary>
        /// FeeVariance FeeVarianceFeeType
        /// </summary>
        public StringEnumValue<FeeVarianceFeeType> FeeVarianceFeeType { get => _feeVarianceFeeType; set => _feeVarianceFeeType = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// FeeVariance Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialLE;
        /// <summary>
        /// FeeVariance InitialLE
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? InitialLE { get => _initialLE; set => _initialLE = value; }
        private DirtyValue<decimal?> _itemization;
        /// <summary>
        /// FeeVariance Itemization
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Itemization { get => _itemization; set => _itemization = value; }
        private DirtyValue<decimal?> _lE;
        /// <summary>
        /// FeeVariance LE
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LE { get => _lE; set => _lE = value; }
        private DirtyValue<string> _line;
        /// <summary>
        /// FeeVariance Line
        /// </summary>
        public string Line { get => _line; set => _line = value; }
    }
}