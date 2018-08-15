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
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => SetField(ref _feeAccountType, value); }
        private DirtyValue<decimal?> _feeAmount;
        /// <summary>
        /// UCDDetail FeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeeAmount { get => _feeAmount; set => SetField(ref _feeAmount, value); }
        private DirtyValue<DateTime?> _feeDateFrom;
        /// <summary>
        /// UCDDetail FeeDateFrom
        /// </summary>
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => SetField(ref _feeDateFrom, value); }
        private DirtyValue<DateTime?> _feeDateTo;
        /// <summary>
        /// UCDDetail FeeDateTo
        /// </summary>
        public DateTime? FeeDateTo { get => _feeDateTo; set => SetField(ref _feeDateTo, value); }
        private DirtyValue<string> _feeDesc;
        /// <summary>
        /// UCDDetail FeeDesc
        /// </summary>
        public string FeeDesc { get => _feeDesc; set => SetField(ref _feeDesc, value); }
        private DirtyValue<int?> _feeIndex;
        /// <summary>
        /// UCDDetail FeeIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\",\"12\":\"12\",\"13\":\"13\",\"14\":\"14\",\"15\":\"15\",\"16\":\"16\",\"17\":\"17\",\"18\":\"18\",\"19\":\"19\",\"20\":\"20\",\"21\":\"21\",\"0\":\"0\"}")]
        public int? FeeIndex { get => _feeIndex; set => SetField(ref _feeIndex, value); }
        private DirtyValue<StringEnumValue<PaidToOrBy>> _feePaidBy;
        /// <summary>
        /// UCDDetail FeePaidBy
        /// </summary>
        public StringEnumValue<PaidToOrBy> FeePaidBy { get => _feePaidBy; set => SetField(ref _feePaidBy, value); }
        private DirtyValue<string> _feePaidTo;
        /// <summary>
        /// UCDDetail FeePaidTo
        /// </summary>
        public string FeePaidTo { get => _feePaidTo; set => SetField(ref _feePaidTo, value); }
        private DirtyValue<bool?> _feePOC;
        /// <summary>
        /// UCDDetail FeePOC
        /// </summary>
        public bool? FeePOC { get => _feePOC; set => SetField(ref _feePOC, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// UCDDetail Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// UCDDetail LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\",\"17\":\"17\",\"3\":\"3\",\"16\":\"16\",\"13\":\"13\",\"19\":\"19\",\"12\":\"12\",\"14\":\"14\",\"15\":\"15\",\"18\":\"18\"}")]
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
        private DirtyValue<StringEnumValue<Section>> _section;
        /// <summary>
        /// UCDDetail Section
        /// </summary>
        public StringEnumValue<Section> Section { get => _section; set => SetField(ref _section, value); }
    }
}