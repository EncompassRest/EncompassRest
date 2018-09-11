using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ExtraPayment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(LineNumber))]
    public sealed partial class ExtraPayment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _amount;
        /// <summary>
        /// ExtraPayment Amount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Amount { get => _amount; set => SetField(ref _amount, value); }
        private DirtyValue<DateTime?> _date;
        /// <summary>
        /// ExtraPayment Date
        /// </summary>
        public DateTime? Date { get => _date; set => SetField(ref _date, value); }
        private DirtyValue<int?> _extraPaymentIndex;
        /// <summary>
        /// ExtraPayment ExtraPaymentIndex
        /// </summary>
        public int? ExtraPaymentIndex { get => _extraPaymentIndex; set => SetField(ref _extraPaymentIndex, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ExtraPayment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<int?> _lineNumber;
        /// <summary>
        /// ExtraPayment LineNumber
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\",\"4\":\"4\",\"5\":\"5\",\"6\":\"6\",\"7\":\"7\",\"8\":\"8\",\"9\":\"9\",\"10\":\"10\",\"11\":\"11\"}")]
        public int? LineNumber { get => _lineNumber; set => SetField(ref _lineNumber, value); }
    }
}