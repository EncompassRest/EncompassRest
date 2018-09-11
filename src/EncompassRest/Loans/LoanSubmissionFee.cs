using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanSubmissionFee
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(LoanSubmissionFeeType))]
    public sealed partial class LoanSubmissionFee : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _description;
        /// <summary>
        /// LoanSubmissionFee Description
        /// </summary>
        public string Description { get => _description; set => SetField(ref _description, value); }
        private DirtyValue<decimal?> _dueBroker;
        /// <summary>
        /// LoanSubmissionFee DueBroker
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueBroker { get => _dueBroker; set => SetField(ref _dueBroker, value); }
        private DirtyValue<decimal?> _dueLender;
        /// <summary>
        /// LoanSubmissionFee DueLender
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueLender { get => _dueLender; set => SetField(ref _dueLender, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanSubmissionFee Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<LoanSubmissionFeeType>> _loanSubmissionFeeType;
        /// <summary>
        /// LoanSubmissionFee LoanSubmissionFeeType
        /// </summary>
        public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => _loanSubmissionFeeType; set => SetField(ref _loanSubmissionFeeType, value); }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// LoanSubmissionFee Total
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Total { get => _total; set => SetField(ref _total, value); }
    }
}