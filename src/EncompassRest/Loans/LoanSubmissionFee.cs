using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// LoanSubmissionFee
    /// </summary>
    public sealed partial class LoanSubmissionFee : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _description;
        /// <summary>
        /// LoanSubmissionFee Description
        /// </summary>
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<decimal?> _dueBroker;
        /// <summary>
        /// LoanSubmissionFee DueBroker
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueBroker { get => _dueBroker; set => _dueBroker = value; }
        private DirtyValue<decimal?> _dueLender;
        /// <summary>
        /// LoanSubmissionFee DueLender
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? DueLender { get => _dueLender; set => _dueLender = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// LoanSubmissionFee Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<LoanSubmissionFeeType>> _loanSubmissionFeeType;
        /// <summary>
        /// LoanSubmissionFee LoanSubmissionFeeType
        /// </summary>
        public StringEnumValue<LoanSubmissionFeeType> LoanSubmissionFeeType { get => _loanSubmissionFeeType; set => _loanSubmissionFeeType = value; }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// LoanSubmissionFee Total
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Total { get => _total; set => _total = value; }
    }
}