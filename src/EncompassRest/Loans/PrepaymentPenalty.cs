using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrepaymentPenalty
    /// </summary>
    public sealed partial class PrepaymentPenalty : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        /// <summary>
        /// PrepaymentPenalty FullPrepaymentPenaltyOptionType
        /// </summary>
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => SetField(ref _fullPrepaymentPenaltyOptionType, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// PrepaymentPenalty Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        /// <summary>
        /// PrepaymentPenalty PrepaymentPenaltyPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => SetField(ref _prepaymentPenaltyPercent, value); }
        private DirtyValue<int?> _termMonthsCount;
        /// <summary>
        /// PrepaymentPenalty TermMonthsCount
        /// </summary>
        public int? TermMonthsCount { get => _termMonthsCount; set => SetField(ref _termMonthsCount, value); }
    }
}