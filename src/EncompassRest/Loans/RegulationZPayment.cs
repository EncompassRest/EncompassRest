using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class RegulationZPayment : ExtensibleObject
    {
        private DirtyValue<decimal?> _balance;
        public decimal? Balance { get => _balance; set => _balance = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestRatePercent;
        public decimal? InterestRatePercent { get => _interestRatePercent; set => _interestRatePercent = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<int?> _numberOfPayments;
        public int? NumberOfPayments { get => _numberOfPayments; set => _numberOfPayments = value; }
        private DirtyValue<DateTime?> _paymentDate;
        public DateTime? PaymentDate { get => _paymentDate; set => _paymentDate = value; }
        private DirtyValue<int?> _regulationZPaymentIndex;
        public int? RegulationZPaymentIndex { get => _regulationZPaymentIndex; set => _regulationZPaymentIndex = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _balance.Dirty
                    || _id.Dirty
                    || _interestRatePercent.Dirty
                    || _monthlyPayment.Dirty
                    || _numberOfPayments.Dirty
                    || _paymentDate.Dirty
                    || _regulationZPaymentIndex.Dirty;
            }
            set
            {
                _balance.Dirty = value;
                _id.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _numberOfPayments.Dirty = value;
                _paymentDate.Dirty = value;
                _regulationZPaymentIndex.Dirty = value;
            }
        }
    }
}