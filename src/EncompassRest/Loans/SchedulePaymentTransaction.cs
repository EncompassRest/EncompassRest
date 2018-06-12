using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SchedulePaymentTransaction
    /// </summary>
    public sealed partial class SchedulePaymentTransaction : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalEscrow;
        /// <summary>
        /// SchedulePaymentTransaction AdditionalEscrow
        /// </summary>
        public decimal? AdditionalEscrow { get => _additionalEscrow; set => _additionalEscrow = value; }
        private DirtyValue<decimal?> _additionalPrincipal;
        /// <summary>
        /// SchedulePaymentTransaction AdditionalPrincipal
        /// </summary>
        public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => _additionalPrincipal = value; }
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmount
        /// </summary>
        public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => _buydownSubsidyAmount = value; }
        private DirtyValue<decimal?> _buydownSubsidyAmountDue;
        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmountDue
        /// </summary>
        public decimal? BuydownSubsidyAmountDue { get => _buydownSubsidyAmountDue; set => _buydownSubsidyAmountDue = value; }
        private DirtyValue<decimal?> _cityPropertyTax;
        /// <summary>
        /// SchedulePaymentTransaction CityPropertyTax
        /// </summary>
        public decimal? CityPropertyTax { get => _cityPropertyTax; set => _cityPropertyTax = value; }
        private DirtyValue<string> _comments;
        /// <summary>
        /// SchedulePaymentTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => _comments = value; }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// SchedulePaymentTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => _createdById = value; }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// SchedulePaymentTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => _createdByName = value; }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// SchedulePaymentTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => _createdDateTimeUtc = value; }
        private DirtyValue<decimal?> _escrow;
        /// <summary>
        /// SchedulePaymentTransaction Escrow
        /// </summary>
        public decimal? Escrow { get => _escrow; set => _escrow = value; }
        private DirtyValue<decimal?> _escrowCityPropertyTaxDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowCityPropertyTaxDue
        /// </summary>
        public decimal? EscrowCityPropertyTaxDue { get => _escrowCityPropertyTaxDue; set => _escrowCityPropertyTaxDue = value; }
        private DirtyValue<decimal?> _escrowDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowDue
        /// </summary>
        public decimal? EscrowDue { get => _escrowDue; set => _escrowDue = value; }
        private DirtyValue<decimal?> _escrowFloodInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowFloodInsuranceDue
        /// </summary>
        public decimal? EscrowFloodInsuranceDue { get => _escrowFloodInsuranceDue; set => _escrowFloodInsuranceDue = value; }
        private DirtyValue<decimal?> _escrowHazardInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowHazardInsuranceDue
        /// </summary>
        public decimal? EscrowHazardInsuranceDue { get => _escrowHazardInsuranceDue; set => _escrowHazardInsuranceDue = value; }
        private DirtyValue<decimal?> _escrowMortgageInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowMortgageInsuranceDue
        /// </summary>
        public decimal? EscrowMortgageInsuranceDue { get => _escrowMortgageInsuranceDue; set => _escrowMortgageInsuranceDue = value; }
        private DirtyValue<decimal?> _escrowOther1Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther1Due
        /// </summary>
        public decimal? EscrowOther1Due { get => _escrowOther1Due; set => _escrowOther1Due = value; }
        private DirtyValue<decimal?> _escrowOther2Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther2Due
        /// </summary>
        public decimal? EscrowOther2Due { get => _escrowOther2Due; set => _escrowOther2Due = value; }
        private DirtyValue<decimal?> _escrowOther3Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther3Due
        /// </summary>
        public decimal? EscrowOther3Due { get => _escrowOther3Due; set => _escrowOther3Due = value; }
        private DirtyValue<decimal?> _escrowTaxDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowTaxDue
        /// </summary>
        public decimal? EscrowTaxDue { get => _escrowTaxDue; set => _escrowTaxDue = value; }
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremiumDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowUSDAMonthlyPremiumDue
        /// </summary>
        public decimal? EscrowUSDAMonthlyPremiumDue { get => _escrowUSDAMonthlyPremiumDue; set => _escrowUSDAMonthlyPremiumDue = value; }
        private DirtyValue<decimal?> _floodInsurance;
        /// <summary>
        /// SchedulePaymentTransaction FloodInsurance
        /// </summary>
        public decimal? FloodInsurance { get => _floodInsurance; set => _floodInsurance = value; }
        private DirtyValue<string> _guid;
        /// <summary>
        /// SchedulePaymentTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => _guid = value; }
        private DirtyValue<decimal?> _hazardInsurance;
        /// <summary>
        /// SchedulePaymentTransaction HazardInsurance
        /// </summary>
        public decimal? HazardInsurance { get => _hazardInsurance; set => _hazardInsurance = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// SchedulePaymentTransaction Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRate;
        /// <summary>
        /// SchedulePaymentTransaction IndexRate
        /// </summary>
        public decimal? IndexRate { get => _indexRate; set => _indexRate = value; }
        private DirtyValue<decimal?> _interest;
        /// <summary>
        /// SchedulePaymentTransaction Interest
        /// </summary>
        public decimal? Interest { get => _interest; set => _interest = value; }
        private DirtyValue<decimal?> _interestDue;
        /// <summary>
        /// SchedulePaymentTransaction InterestDue
        /// </summary>
        public decimal? InterestDue { get => _interestDue; set => _interestDue = value; }
        private DirtyValue<decimal?> _interestRate;
        /// <summary>
        /// SchedulePaymentTransaction InterestRate
        /// </summary>
        public decimal? InterestRate { get => _interestRate; set => _interestRate = value; }
        private DirtyValue<decimal?> _lateFee;
        /// <summary>
        /// SchedulePaymentTransaction LateFee
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => _lateFee = value; }
        private DirtyValue<DateTime?> _latePaymentDate;
        /// <summary>
        /// SchedulePaymentTransaction LatePaymentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LatePaymentDate { get => _latePaymentDate; set => _latePaymentDate = value; }
        private DirtyValue<decimal?> _miscFee;
        /// <summary>
        /// SchedulePaymentTransaction MiscFee
        /// </summary>
        public decimal? MiscFee { get => _miscFee; set => _miscFee = value; }
        private DirtyValue<decimal?> _miscFeeDue;
        /// <summary>
        /// SchedulePaymentTransaction MiscFeeDue
        /// </summary>
        public decimal? MiscFeeDue { get => _miscFeeDue; set => _miscFeeDue = value; }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => _modifiedById = value; }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => _modifiedByName = value; }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => _modifiedDateTimeUtc = value; }
        private DirtyValue<decimal?> _mortgageInsurance;
        /// <summary>
        /// SchedulePaymentTransaction MortgageInsurance
        /// </summary>
        public decimal? MortgageInsurance { get => _mortgageInsurance; set => _mortgageInsurance = value; }
        private DirtyValue<decimal?> _other1Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other1Escrow
        /// </summary>
        public decimal? Other1Escrow { get => _other1Escrow; set => _other1Escrow = value; }
        private DirtyValue<decimal?> _other2Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other2Escrow
        /// </summary>
        public decimal? Other2Escrow { get => _other2Escrow; set => _other2Escrow = value; }
        private DirtyValue<decimal?> _other3Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other3Escrow
        /// </summary>
        public decimal? Other3Escrow { get => _other3Escrow; set => _other3Escrow = value; }
        private DirtyValue<int?> _paymentNumber;
        /// <summary>
        /// SchedulePaymentTransaction PaymentNumber
        /// </summary>
        public int? PaymentNumber { get => _paymentNumber; set => _paymentNumber = value; }
        private DirtyValue<DateTime?> _paymentReceiveDate;
        /// <summary>
        /// SchedulePaymentTransaction PaymentReceiveDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentReceiveDate { get => _paymentReceiveDate; set => _paymentReceiveDate = value; }
        private DirtyValue<decimal?> _principal;
        /// <summary>
        /// SchedulePaymentTransaction Principal
        /// </summary>
        public decimal? Principal { get => _principal; set => _principal = value; }
        private DirtyValue<decimal?> _principalDue;
        /// <summary>
        /// SchedulePaymentTransaction PrincipalDue
        /// </summary>
        public decimal? PrincipalDue { get => _principalDue; set => _principalDue = value; }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// SchedulePaymentTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => _servicingPaymentMethod = value; }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// SchedulePaymentTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => _servicingTransactionType = value; }
        private DirtyValue<decimal?> _taxes;
        /// <summary>
        /// SchedulePaymentTransaction Taxes
        /// </summary>
        public decimal? Taxes { get => _taxes; set => _taxes = value; }
        private DirtyValue<decimal?> _totalPastDue;
        /// <summary>
        /// SchedulePaymentTransaction TotalPastDue
        /// </summary>
        public decimal? TotalPastDue { get => _totalPastDue; set => _totalPastDue = value; }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// SchedulePaymentTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => _transactionAmount = value; }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// SchedulePaymentTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => _transactionDate = value; }
        private DirtyValue<decimal?> _unpaidLateFeeDue;
        /// <summary>
        /// SchedulePaymentTransaction UnpaidLateFeeDue
        /// </summary>
        public decimal? UnpaidLateFeeDue { get => _unpaidLateFeeDue; set => _unpaidLateFeeDue = value; }
        private DirtyValue<decimal?> _uSDAMonthlyPremium;
        /// <summary>
        /// SchedulePaymentTransaction USDAMonthlyPremium
        /// </summary>
        public decimal? USDAMonthlyPremium { get => _uSDAMonthlyPremium; set => _uSDAMonthlyPremium = value; }
        internal override bool DirtyInternal
        {
            get => _additionalEscrow.Dirty
                || _additionalPrincipal.Dirty
                || _buydownSubsidyAmount.Dirty
                || _buydownSubsidyAmountDue.Dirty
                || _cityPropertyTax.Dirty
                || _comments.Dirty
                || _createdById.Dirty
                || _createdByName.Dirty
                || _createdDateTimeUtc.Dirty
                || _escrow.Dirty
                || _escrowCityPropertyTaxDue.Dirty
                || _escrowDue.Dirty
                || _escrowFloodInsuranceDue.Dirty
                || _escrowHazardInsuranceDue.Dirty
                || _escrowMortgageInsuranceDue.Dirty
                || _escrowOther1Due.Dirty
                || _escrowOther2Due.Dirty
                || _escrowOther3Due.Dirty
                || _escrowTaxDue.Dirty
                || _escrowUSDAMonthlyPremiumDue.Dirty
                || _floodInsurance.Dirty
                || _guid.Dirty
                || _hazardInsurance.Dirty
                || _id.Dirty
                || _indexRate.Dirty
                || _interest.Dirty
                || _interestDue.Dirty
                || _interestRate.Dirty
                || _lateFee.Dirty
                || _latePaymentDate.Dirty
                || _miscFee.Dirty
                || _miscFeeDue.Dirty
                || _modifiedById.Dirty
                || _modifiedByName.Dirty
                || _modifiedDateTimeUtc.Dirty
                || _mortgageInsurance.Dirty
                || _other1Escrow.Dirty
                || _other2Escrow.Dirty
                || _other3Escrow.Dirty
                || _paymentNumber.Dirty
                || _paymentReceiveDate.Dirty
                || _principal.Dirty
                || _principalDue.Dirty
                || _servicingPaymentMethod.Dirty
                || _servicingTransactionType.Dirty
                || _taxes.Dirty
                || _totalPastDue.Dirty
                || _transactionAmount.Dirty
                || _transactionDate.Dirty
                || _unpaidLateFeeDue.Dirty
                || _uSDAMonthlyPremium.Dirty;
            set
            {
                _additionalEscrow.Dirty = value;
                _additionalPrincipal.Dirty = value;
                _buydownSubsidyAmount.Dirty = value;
                _buydownSubsidyAmountDue.Dirty = value;
                _cityPropertyTax.Dirty = value;
                _comments.Dirty = value;
                _createdById.Dirty = value;
                _createdByName.Dirty = value;
                _createdDateTimeUtc.Dirty = value;
                _escrow.Dirty = value;
                _escrowCityPropertyTaxDue.Dirty = value;
                _escrowDue.Dirty = value;
                _escrowFloodInsuranceDue.Dirty = value;
                _escrowHazardInsuranceDue.Dirty = value;
                _escrowMortgageInsuranceDue.Dirty = value;
                _escrowOther1Due.Dirty = value;
                _escrowOther2Due.Dirty = value;
                _escrowOther3Due.Dirty = value;
                _escrowTaxDue.Dirty = value;
                _escrowUSDAMonthlyPremiumDue.Dirty = value;
                _floodInsurance.Dirty = value;
                _guid.Dirty = value;
                _hazardInsurance.Dirty = value;
                _id.Dirty = value;
                _indexRate.Dirty = value;
                _interest.Dirty = value;
                _interestDue.Dirty = value;
                _interestRate.Dirty = value;
                _lateFee.Dirty = value;
                _latePaymentDate.Dirty = value;
                _miscFee.Dirty = value;
                _miscFeeDue.Dirty = value;
                _modifiedById.Dirty = value;
                _modifiedByName.Dirty = value;
                _modifiedDateTimeUtc.Dirty = value;
                _mortgageInsurance.Dirty = value;
                _other1Escrow.Dirty = value;
                _other2Escrow.Dirty = value;
                _other3Escrow.Dirty = value;
                _paymentNumber.Dirty = value;
                _paymentReceiveDate.Dirty = value;
                _principal.Dirty = value;
                _principalDue.Dirty = value;
                _servicingPaymentMethod.Dirty = value;
                _servicingTransactionType.Dirty = value;
                _taxes.Dirty = value;
                _totalPastDue.Dirty = value;
                _transactionAmount.Dirty = value;
                _transactionDate.Dirty = value;
                _unpaidLateFeeDue.Dirty = value;
                _uSDAMonthlyPremium.Dirty = value;
            }
        }
    }
}