using System;

namespace EncompassApi.Loans
{
    /// <summary>
    /// ExtraPayment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
    public sealed partial class ExtraPayment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _amount;
        private DirtyValue<DateTime?>? _date;
        private DirtyValue<int?>? _extraPaymentIndex;
        private DirtyValue<string?>? _id;
        private DirtyValue<int?>? _lineNumber;

        /// <summary>
        /// ExtraPayment Amount
        /// </summary>
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }

        /// <summary>
        /// ExtraPayment Date
        /// </summary>
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }

        /// <summary>
        /// ExtraPayment ExtraPaymentIndex
        /// </summary>
        public int? ExtraPaymentIndex { get => _extraPaymentIndex; set => SetField(ref _extraPaymentIndex, value); }

        /// <summary>
        /// ExtraPayment Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// ExtraPayment LineNumber
        /// </summary>
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
    }
}