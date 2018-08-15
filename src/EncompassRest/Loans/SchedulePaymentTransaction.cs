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
        public decimal? AdditionalEscrow { get => _additionalEscrow; set => SetField(ref _additionalEscrow, value); }
        private DirtyValue<decimal?> _additionalPrincipal;
        /// <summary>
        /// SchedulePaymentTransaction AdditionalPrincipal
        /// </summary>
        public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => SetField(ref _additionalPrincipal, value); }
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmount
        /// </summary>
        public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => SetField(ref _buydownSubsidyAmount, value); }
        private DirtyValue<decimal?> _buydownSubsidyAmountDue;
        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmountDue
        /// </summary>
        public decimal? BuydownSubsidyAmountDue { get => _buydownSubsidyAmountDue; set => SetField(ref _buydownSubsidyAmountDue, value); }
        private DirtyValue<decimal?> _cityPropertyTax;
        /// <summary>
        /// SchedulePaymentTransaction CityPropertyTax
        /// </summary>
        public decimal? CityPropertyTax { get => _cityPropertyTax; set => SetField(ref _cityPropertyTax, value); }
        private DirtyValue<string> _comments;
        /// <summary>
        /// SchedulePaymentTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }
        private DirtyValue<string> _createdById;
        /// <summary>
        /// SchedulePaymentTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }
        private DirtyValue<string> _createdByName;
        /// <summary>
        /// SchedulePaymentTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        /// <summary>
        /// SchedulePaymentTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }
        private DirtyValue<decimal?> _escrow;
        /// <summary>
        /// SchedulePaymentTransaction Escrow
        /// </summary>
        public decimal? Escrow { get => _escrow; set => SetField(ref _escrow, value); }
        private DirtyValue<decimal?> _escrowCityPropertyTaxDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowCityPropertyTaxDue
        /// </summary>
        public decimal? EscrowCityPropertyTaxDue { get => _escrowCityPropertyTaxDue; set => SetField(ref _escrowCityPropertyTaxDue, value); }
        private DirtyValue<decimal?> _escrowDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowDue
        /// </summary>
        public decimal? EscrowDue { get => _escrowDue; set => SetField(ref _escrowDue, value); }
        private DirtyValue<decimal?> _escrowFloodInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowFloodInsuranceDue
        /// </summary>
        public decimal? EscrowFloodInsuranceDue { get => _escrowFloodInsuranceDue; set => SetField(ref _escrowFloodInsuranceDue, value); }
        private DirtyValue<decimal?> _escrowHazardInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowHazardInsuranceDue
        /// </summary>
        public decimal? EscrowHazardInsuranceDue { get => _escrowHazardInsuranceDue; set => SetField(ref _escrowHazardInsuranceDue, value); }
        private DirtyValue<decimal?> _escrowMortgageInsuranceDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowMortgageInsuranceDue
        /// </summary>
        public decimal? EscrowMortgageInsuranceDue { get => _escrowMortgageInsuranceDue; set => SetField(ref _escrowMortgageInsuranceDue, value); }
        private DirtyValue<decimal?> _escrowOther1Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther1Due
        /// </summary>
        public decimal? EscrowOther1Due { get => _escrowOther1Due; set => SetField(ref _escrowOther1Due, value); }
        private DirtyValue<decimal?> _escrowOther2Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther2Due
        /// </summary>
        public decimal? EscrowOther2Due { get => _escrowOther2Due; set => SetField(ref _escrowOther2Due, value); }
        private DirtyValue<decimal?> _escrowOther3Due;
        /// <summary>
        /// SchedulePaymentTransaction EscrowOther3Due
        /// </summary>
        public decimal? EscrowOther3Due { get => _escrowOther3Due; set => SetField(ref _escrowOther3Due, value); }
        private DirtyValue<decimal?> _escrowTaxDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowTaxDue
        /// </summary>
        public decimal? EscrowTaxDue { get => _escrowTaxDue; set => SetField(ref _escrowTaxDue, value); }
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremiumDue;
        /// <summary>
        /// SchedulePaymentTransaction EscrowUSDAMonthlyPremiumDue
        /// </summary>
        public decimal? EscrowUSDAMonthlyPremiumDue { get => _escrowUSDAMonthlyPremiumDue; set => SetField(ref _escrowUSDAMonthlyPremiumDue, value); }
        private DirtyValue<decimal?> _floodInsurance;
        /// <summary>
        /// SchedulePaymentTransaction FloodInsurance
        /// </summary>
        public decimal? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }
        private DirtyValue<string> _guid;
        /// <summary>
        /// SchedulePaymentTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }
        private DirtyValue<decimal?> _hazardInsurance;
        /// <summary>
        /// SchedulePaymentTransaction HazardInsurance
        /// </summary>
        public decimal? HazardInsurance { get => _hazardInsurance; set => SetField(ref _hazardInsurance, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// SchedulePaymentTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _indexRate;
        /// <summary>
        /// SchedulePaymentTransaction IndexRate
        /// </summary>
        public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }
        private DirtyValue<decimal?> _interest;
        /// <summary>
        /// SchedulePaymentTransaction Interest
        /// </summary>
        public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }
        private DirtyValue<decimal?> _interestDue;
        /// <summary>
        /// SchedulePaymentTransaction InterestDue
        /// </summary>
        public decimal? InterestDue { get => _interestDue; set => SetField(ref _interestDue, value); }
        private DirtyValue<decimal?> _interestRate;
        /// <summary>
        /// SchedulePaymentTransaction InterestRate
        /// </summary>
        public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }
        private DirtyValue<decimal?> _lateFee;
        /// <summary>
        /// SchedulePaymentTransaction LateFee
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }
        private DirtyValue<DateTime?> _latePaymentDate;
        /// <summary>
        /// SchedulePaymentTransaction LatePaymentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LatePaymentDate { get => _latePaymentDate; set => SetField(ref _latePaymentDate, value); }
        private DirtyValue<decimal?> _miscFee;
        /// <summary>
        /// SchedulePaymentTransaction MiscFee
        /// </summary>
        public decimal? MiscFee { get => _miscFee; set => SetField(ref _miscFee, value); }
        private DirtyValue<decimal?> _miscFeeDue;
        /// <summary>
        /// SchedulePaymentTransaction MiscFeeDue
        /// </summary>
        public decimal? MiscFeeDue { get => _miscFeeDue; set => SetField(ref _miscFeeDue, value); }
        private DirtyValue<string> _modifiedById;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }
        private DirtyValue<string> _modifiedByName;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        /// <summary>
        /// SchedulePaymentTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }
        private DirtyValue<decimal?> _mortgageInsurance;
        /// <summary>
        /// SchedulePaymentTransaction MortgageInsurance
        /// </summary>
        public decimal? MortgageInsurance { get => _mortgageInsurance; set => SetField(ref _mortgageInsurance, value); }
        private DirtyValue<decimal?> _other1Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other1Escrow
        /// </summary>
        public decimal? Other1Escrow { get => _other1Escrow; set => SetField(ref _other1Escrow, value); }
        private DirtyValue<decimal?> _other2Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other2Escrow
        /// </summary>
        public decimal? Other2Escrow { get => _other2Escrow; set => SetField(ref _other2Escrow, value); }
        private DirtyValue<decimal?> _other3Escrow;
        /// <summary>
        /// SchedulePaymentTransaction Other3Escrow
        /// </summary>
        public decimal? Other3Escrow { get => _other3Escrow; set => SetField(ref _other3Escrow, value); }
        private DirtyValue<int?> _paymentNumber;
        /// <summary>
        /// SchedulePaymentTransaction PaymentNumber
        /// </summary>
        public int? PaymentNumber { get => _paymentNumber; set => SetField(ref _paymentNumber, value); }
        private DirtyValue<DateTime?> _paymentReceiveDate;
        /// <summary>
        /// SchedulePaymentTransaction PaymentReceiveDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentReceiveDate { get => _paymentReceiveDate; set => SetField(ref _paymentReceiveDate, value); }
        private DirtyValue<decimal?> _principal;
        /// <summary>
        /// SchedulePaymentTransaction Principal
        /// </summary>
        public decimal? Principal { get => _principal; set => SetField(ref _principal, value); }
        private DirtyValue<decimal?> _principalDue;
        /// <summary>
        /// SchedulePaymentTransaction PrincipalDue
        /// </summary>
        public decimal? PrincipalDue { get => _principalDue; set => SetField(ref _principalDue, value); }
        private DirtyValue<string> _servicingPaymentMethod;
        /// <summary>
        /// SchedulePaymentTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }
        private DirtyValue<string> _servicingTransactionType;
        /// <summary>
        /// SchedulePaymentTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }
        private DirtyValue<decimal?> _taxes;
        /// <summary>
        /// SchedulePaymentTransaction Taxes
        /// </summary>
        public decimal? Taxes { get => _taxes; set => SetField(ref _taxes, value); }
        private DirtyValue<decimal?> _totalPastDue;
        /// <summary>
        /// SchedulePaymentTransaction TotalPastDue
        /// </summary>
        public decimal? TotalPastDue { get => _totalPastDue; set => SetField(ref _totalPastDue, value); }
        private DirtyValue<decimal?> _transactionAmount;
        /// <summary>
        /// SchedulePaymentTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }
        private DirtyValue<DateTime?> _transactionDate;
        /// <summary>
        /// SchedulePaymentTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }
        private DirtyValue<decimal?> _unpaidLateFeeDue;
        /// <summary>
        /// SchedulePaymentTransaction UnpaidLateFeeDue
        /// </summary>
        public decimal? UnpaidLateFeeDue { get => _unpaidLateFeeDue; set => SetField(ref _unpaidLateFeeDue, value); }
        private DirtyValue<decimal?> _uSDAMonthlyPremium;
        /// <summary>
        /// SchedulePaymentTransaction USDAMonthlyPremium
        /// </summary>
        public decimal? USDAMonthlyPremium { get => _uSDAMonthlyPremium; set => SetField(ref _uSDAMonthlyPremium, value); }
    }
}