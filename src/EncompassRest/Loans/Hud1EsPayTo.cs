using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Hud1EsPayTo
    /// </summary>
    public sealed partial class Hud1EsPayTo : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// Hud1EsPayTo Address
        /// </summary>
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _amountLastPay;
        /// <summary>
        /// Hud1EsPayTo AmountLastPay
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountLastPay { get => _amountLastPay; set => _amountLastPay = value; }
        private DirtyValue<decimal?> _amountNextDue;
        /// <summary>
        /// Hud1EsPayTo AmountNextDue
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AmountNextDue { get => _amountNextDue; set => _amountNextDue = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// Hud1EsPayTo City
        /// </summary>
        public string City { get => _city; set => _city = value; }
        private DirtyValue<string> _contactName;
        /// <summary>
        /// Hud1EsPayTo ContactName
        /// </summary>
        public string ContactName { get => _contactName; set => _contactName = value; }
        private DirtyValue<decimal?> _coverageAmount;
        /// <summary>
        /// Hud1EsPayTo CoverageAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CoverageAmount { get => _coverageAmount; set => _coverageAmount = value; }
        private DirtyValue<DateTime?> _datePaid;
        /// <summary>
        /// Hud1EsPayTo DatePaid
        /// </summary>
        public DateTime? DatePaid { get => _datePaid; set => _datePaid = value; }
        private DirtyValue<DateTime?> _delinquentDate;
        /// <summary>
        /// Hud1EsPayTo DelinquentDate
        /// </summary>
        public DateTime? DelinquentDate { get => _delinquentDate; set => _delinquentDate = value; }
        private DirtyValue<string> _email;
        /// <summary>
        /// Hud1EsPayTo Email
        /// </summary>
        public string Email { get => _email; set => _email = value; }
        private DirtyValue<string> _fax;
        /// <summary>
        /// Hud1EsPayTo Fax
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Fax { get => _fax; set => _fax = value; }
        private DirtyValue<StringEnumValue<Hud1EsPayToFeeType>> _feeType;
        /// <summary>
        /// Hud1EsPayTo FeeType
        /// </summary>
        public StringEnumValue<Hud1EsPayToFeeType> FeeType { get => _feeType; set => _feeType = value; }
        private DirtyValue<int?> _hud1EsPayToIndex;
        /// <summary>
        /// Hud1EsPayTo Hud1EsPayToIndex
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"1\":\"1\",\"2\":\"2\",\"3\":\"3\"}")]
        public int? Hud1EsPayToIndex { get => _hud1EsPayToIndex; set => _hud1EsPayToIndex = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Hud1EsPayTo Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _maxDeductibleAmount;
        /// <summary>
        /// Hud1EsPayTo MaxDeductibleAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaxDeductibleAmount { get => _maxDeductibleAmount; set => _maxDeductibleAmount = value; }
        private DirtyValue<decimal?> _maxDeductiblePercentage;
        /// <summary>
        /// Hud1EsPayTo MaxDeductiblePercentage
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxDeductiblePercentage { get => _maxDeductiblePercentage; set => _maxDeductiblePercentage = value; }
        private DirtyValue<string> _name;
        /// <summary>
        /// Hud1EsPayTo Name
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        private DirtyValue<DateTime?> _nextDueDate;
        /// <summary>
        /// Hud1EsPayTo NextDueDate
        /// </summary>
        public DateTime? NextDueDate { get => _nextDueDate; set => _nextDueDate = value; }
        private DirtyValue<string> _paymentSchedule;
        /// <summary>
        /// Hud1EsPayTo PaymentSchedule
        /// </summary>
        public string PaymentSchedule { get => _paymentSchedule; set => _paymentSchedule = value; }
        private DirtyValue<string> _phone;
        /// <summary>
        /// Hud1EsPayTo Phone
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
        public string Phone { get => _phone; set => _phone = value; }
        private DirtyValue<string> _policyNumber;
        /// <summary>
        /// Hud1EsPayTo PolicyNumber
        /// </summary>
        public string PolicyNumber { get => _policyNumber; set => _policyNumber = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// Hud1EsPayTo PostalCode
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<decimal?> _premium;
        /// <summary>
        /// Hud1EsPayTo Premium
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Premium { get => _premium; set => _premium = value; }
        private DirtyValue<DateTime?> _renewalDate;
        /// <summary>
        /// Hud1EsPayTo RenewalDate
        /// </summary>
        public DateTime? RenewalDate { get => _renewalDate; set => _renewalDate = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// Hud1EsPayTo State
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
                || _amountLastPay.Dirty
                || _amountNextDue.Dirty
                || _city.Dirty
                || _contactName.Dirty
                || _coverageAmount.Dirty
                || _datePaid.Dirty
                || _delinquentDate.Dirty
                || _email.Dirty
                || _fax.Dirty
                || _feeType.Dirty
                || _hud1EsPayToIndex.Dirty
                || _id.Dirty
                || _maxDeductibleAmount.Dirty
                || _maxDeductiblePercentage.Dirty
                || _name.Dirty
                || _nextDueDate.Dirty
                || _paymentSchedule.Dirty
                || _phone.Dirty
                || _policyNumber.Dirty
                || _postalCode.Dirty
                || _premium.Dirty
                || _renewalDate.Dirty
                || _state.Dirty;
            set
            {
                _address.Dirty = value;
                _amountLastPay.Dirty = value;
                _amountNextDue.Dirty = value;
                _city.Dirty = value;
                _contactName.Dirty = value;
                _coverageAmount.Dirty = value;
                _datePaid.Dirty = value;
                _delinquentDate.Dirty = value;
                _email.Dirty = value;
                _fax.Dirty = value;
                _feeType.Dirty = value;
                _hud1EsPayToIndex.Dirty = value;
                _id.Dirty = value;
                _maxDeductibleAmount.Dirty = value;
                _maxDeductiblePercentage.Dirty = value;
                _name.Dirty = value;
                _nextDueDate.Dirty = value;
                _paymentSchedule.Dirty = value;
                _phone.Dirty = value;
                _policyNumber.Dirty = value;
                _postalCode.Dirty = value;
                _premium.Dirty = value;
                _renewalDate.Dirty = value;
                _state.Dirty = value;
            }
        }
    }
}