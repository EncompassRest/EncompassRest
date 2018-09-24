using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrepaymentPenalty
    /// </summary>
    [Entity(SerializeWholeListWhenDirty = true)]
    public sealed partial class PrepaymentPenalty : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<StringEnumValue<FullPrepaymentPenaltyOptionType>> _fullPrepaymentPenaltyOptionType;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _prepaymentPenaltyPercent;
        private DirtyValue<int?> _termMonthsCount;

        /// <summary>
        /// PrepaymentPenalty FullPrepaymentPenaltyOptionType
        /// </summary>
        public StringEnumValue<FullPrepaymentPenaltyOptionType> FullPrepaymentPenaltyOptionType { get => _fullPrepaymentPenaltyOptionType; set => SetField(ref _fullPrepaymentPenaltyOptionType, value); }

        /// <summary>
        /// PrepaymentPenalty Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// PrepaymentPenalty PrepaymentPenaltyPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? PrepaymentPenaltyPercent { get => _prepaymentPenaltyPercent; set => SetField(ref _prepaymentPenaltyPercent, value); }

        /// <summary>
        /// PrepaymentPenalty TermMonthsCount
        /// </summary>
        public int? TermMonthsCount { get => _termMonthsCount; set => SetField(ref _termMonthsCount, value); }
    }
}