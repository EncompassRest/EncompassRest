using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegulationZPayment
    /// </summary>
    [Entity(PropertiesToAlwaysSerialize = nameof(RegulationZPaymentIndex))]
    public sealed partial class RegulationZPayment : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _balance;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _interestRatePercent;
        private DirtyValue<decimal?> _monthlyPayment;
        private DirtyValue<int?> _numberOfPayments;
        private DirtyValue<DateTime?> _paymentDate;
        private DirtyValue<int?> _regulationZPaymentIndex;

        /// <summary>
        /// RegulationZPayment Balance
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Balance { get => _balance; set => SetField(ref _balance, value); }

        /// <summary>
        /// RegulationZPayment Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// RegulationZPayment InterestRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? InterestRatePercent { get => _interestRatePercent; set => SetField(ref _interestRatePercent, value); }

        /// <summary>
        /// RegulationZPayment MonthlyPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => SetField(ref _monthlyPayment, value); }

        /// <summary>
        /// RegulationZPayment NumberOfPayments
        /// </summary>
        public int? NumberOfPayments { get => _numberOfPayments; set => SetField(ref _numberOfPayments, value); }

        /// <summary>
        /// RegulationZPayment PaymentDate
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? PaymentDate { get => _paymentDate; set => SetField(ref _paymentDate, value); }

        /// <summary>
        /// RegulationZPayment RegulationZPaymentIndex
        /// </summary>
        public int? RegulationZPaymentIndex { get => _regulationZPaymentIndex; set => SetField(ref _regulationZPaymentIndex, value); }
    }
}