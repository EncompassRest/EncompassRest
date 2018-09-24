using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// UCDDetail
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(FeeIndex) + "," + nameof(LineNumber) + "," + nameof(Section))]
    public sealed partial class UCDDetail : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<UCDPayoffType>> _feeAccountType;
        private DirtyValue<decimal?> _feeAmount;
        private DirtyValue<DateTime?> _feeDateFrom;
        private DirtyValue<DateTime?> _feeDateTo;
        private DirtyValue<string> _feeDesc;
        private DirtyValue<int?> _feeIndex;
        private DirtyValue<StringEnumValue<PaidToOrBy>> _feePaidBy;
        private DirtyValue<string> _feePaidTo;
        private DirtyValue<bool?> _feePOC;
        private DirtyValue<string> _id;
        private DirtyValue<int?> _lineNumber;
        private DirtyValue<StringEnumValue<Section>> _section;

        /// <summary>
        /// UCDDetail FeeAccountType
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Open30DayChargeAccount\":\"Open 30 Day Charge Account\"}")]
        public StringEnumValue<UCDPayoffType> FeeAccountType { get => _feeAccountType; set => SetField(ref _feeAccountType, value); }

        /// <summary>
        /// UCDDetail FeeAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FeeAmount { get => _feeAmount; set => SetField(ref _feeAmount, value); }

        /// <summary>
        /// UCDDetail FeeDateFrom
        /// </summary>
        public DateTime? FeeDateFrom { get => _feeDateFrom; set => SetField(ref _feeDateFrom, value); }

        /// <summary>
        /// UCDDetail FeeDateTo
        /// </summary>
        public DateTime? FeeDateTo { get => _feeDateTo; set => SetField(ref _feeDateTo, value); }

        /// <summary>
        /// UCDDetail FeeDesc
        /// </summary>
        public string FeeDesc { get => _feeDesc; set => SetField(ref _feeDesc, value); }

        /// <summary>
        /// UCDDetail FeeIndex
        /// </summary>
        public int? FeeIndex { get => _feeIndex; set => SetField(ref _feeIndex, value); }

        /// <summary>
        /// UCDDetail FeePaidBy
        /// </summary>
        public StringEnumValue<PaidToOrBy> FeePaidBy { get => _feePaidBy; set => SetField(ref _feePaidBy, value); }

        /// <summary>
        /// UCDDetail FeePaidTo
        /// </summary>
        public string FeePaidTo { get => _feePaidTo; set => SetField(ref _feePaidTo, value); }

        /// <summary>
        /// UCDDetail FeePOC
        /// </summary>
        public bool? FeePOC { get => _feePOC; set => SetField(ref _feePOC, value); }

        /// <summary>
        /// UCDDetail Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// UCDDetail LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }

        /// <summary>
        /// UCDDetail Section
        /// </summary>
        public StringEnumValue<Section> Section { get => _section; set => SetField(ref _section, value); }
    }
}