using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// SchedulePaymentTransaction
    /// </summary>
    public sealed partial class SchedulePaymentTransaction : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _additionalEscrow;
        private DirtyValue<decimal?> _additionalPrincipal;
        private DirtyValue<decimal?> _buydownSubsidyAmount;
        private DirtyValue<decimal?> _buydownSubsidyAmountDue;
        private DirtyValue<decimal?> _cityPropertyTax;
        private DirtyValue<string> _comments;
        private DirtyValue<string> _createdById;
        private DirtyValue<string> _createdByName;
        private DirtyValue<DateTime?> _createdDateTimeUtc;
        private DirtyValue<decimal?> _escrow;
        private DirtyValue<decimal?> _escrowCityPropertyTaxDue;
        private DirtyValue<decimal?> _escrowDue;
        private DirtyValue<decimal?> _escrowFloodInsuranceDue;
        private DirtyValue<decimal?> _escrowHazardInsuranceDue;
        private DirtyValue<decimal?> _escrowMortgageInsuranceDue;
        private DirtyValue<decimal?> _escrowOther1Due;
        private DirtyValue<decimal?> _escrowOther2Due;
        private DirtyValue<decimal?> _escrowOther3Due;
        private DirtyValue<decimal?> _escrowTaxDue;
        private DirtyValue<decimal?> _escrowUSDAMonthlyPremiumDue;
        private DirtyValue<decimal?> _floodInsurance;
        private DirtyValue<string> _guid;
        private DirtyValue<decimal?> _hazardInsurance;
        private DirtyValue<string> _id;
        private DirtyValue<decimal?> _indexRate;
        private DirtyValue<decimal?> _interest;
        private DirtyValue<decimal?> _interestDue;
        private DirtyValue<decimal?> _interestRate;
        private DirtyValue<decimal?> _lateFee;
        private DirtyValue<DateTime?> _latePaymentDate;
        private DirtyValue<decimal?> _miscFee;
        private DirtyValue<decimal?> _miscFeeDue;
        private DirtyValue<string> _modifiedById;
        private DirtyValue<string> _modifiedByName;
        private DirtyValue<DateTime?> _modifiedDateTimeUtc;
        private DirtyValue<decimal?> _mortgageInsurance;
        private DirtyValue<decimal?> _other1Escrow;
        private DirtyValue<decimal?> _other2Escrow;
        private DirtyValue<decimal?> _other3Escrow;
        private DirtyValue<int?> _paymentNumber;
        private DirtyValue<DateTime?> _paymentReceiveDate;
        private DirtyValue<decimal?> _principal;
        private DirtyValue<decimal?> _principalDue;
        private DirtyValue<string> _servicingPaymentMethod;
        private DirtyValue<string> _servicingTransactionType;
        private DirtyValue<decimal?> _taxes;
        private DirtyValue<decimal?> _totalPastDue;
        private DirtyValue<decimal?> _transactionAmount;
        private DirtyValue<DateTime?> _transactionDate;
        private DirtyValue<decimal?> _unpaidLateFeeDue;
        private DirtyValue<decimal?> _uSDAMonthlyPremium;

        /// <summary>
        /// SchedulePaymentTransaction AdditionalEscrow
        /// </summary>
        public decimal? AdditionalEscrow { get => _additionalEscrow; set => SetField(ref _additionalEscrow, value); }

        /// <summary>
        /// SchedulePaymentTransaction AdditionalPrincipal
        /// </summary>
        public decimal? AdditionalPrincipal { get => _additionalPrincipal; set => SetField(ref _additionalPrincipal, value); }

        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmount
        /// </summary>
        public decimal? BuydownSubsidyAmount { get => _buydownSubsidyAmount; set => SetField(ref _buydownSubsidyAmount, value); }

        /// <summary>
        /// SchedulePaymentTransaction BuydownSubsidyAmountDue
        /// </summary>
        public decimal? BuydownSubsidyAmountDue { get => _buydownSubsidyAmountDue; set => SetField(ref _buydownSubsidyAmountDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction CityPropertyTax
        /// </summary>
        public decimal? CityPropertyTax { get => _cityPropertyTax; set => SetField(ref _cityPropertyTax, value); }

        /// <summary>
        /// SchedulePaymentTransaction Comments
        /// </summary>
        public string Comments { get => _comments; set => SetField(ref _comments, value); }

        /// <summary>
        /// SchedulePaymentTransaction CreatedById
        /// </summary>
        public string CreatedById { get => _createdById; set => SetField(ref _createdById, value); }

        /// <summary>
        /// SchedulePaymentTransaction CreatedByName
        /// </summary>
        public string CreatedByName { get => _createdByName; set => SetField(ref _createdByName, value); }

        /// <summary>
        /// SchedulePaymentTransaction CreatedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? CreatedDateTimeUtc { get => _createdDateTimeUtc; set => SetField(ref _createdDateTimeUtc, value); }

        /// <summary>
        /// SchedulePaymentTransaction Escrow
        /// </summary>
        public decimal? Escrow { get => _escrow; set => SetField(ref _escrow, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowCityPropertyTaxDue
        /// </summary>
        public decimal? EscrowCityPropertyTaxDue { get => _escrowCityPropertyTaxDue; set => SetField(ref _escrowCityPropertyTaxDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowDue
        /// </summary>
        public decimal? EscrowDue { get => _escrowDue; set => SetField(ref _escrowDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowFloodInsuranceDue
        /// </summary>
        public decimal? EscrowFloodInsuranceDue { get => _escrowFloodInsuranceDue; set => SetField(ref _escrowFloodInsuranceDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowHazardInsuranceDue
        /// </summary>
        public decimal? EscrowHazardInsuranceDue { get => _escrowHazardInsuranceDue; set => SetField(ref _escrowHazardInsuranceDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowMortgageInsuranceDue
        /// </summary>
        public decimal? EscrowMortgageInsuranceDue { get => _escrowMortgageInsuranceDue; set => SetField(ref _escrowMortgageInsuranceDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowOther1Due
        /// </summary>
        public decimal? EscrowOther1Due { get => _escrowOther1Due; set => SetField(ref _escrowOther1Due, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowOther2Due
        /// </summary>
        public decimal? EscrowOther2Due { get => _escrowOther2Due; set => SetField(ref _escrowOther2Due, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowOther3Due
        /// </summary>
        public decimal? EscrowOther3Due { get => _escrowOther3Due; set => SetField(ref _escrowOther3Due, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowTaxDue
        /// </summary>
        public decimal? EscrowTaxDue { get => _escrowTaxDue; set => SetField(ref _escrowTaxDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction EscrowUSDAMonthlyPremiumDue
        /// </summary>
        public decimal? EscrowUSDAMonthlyPremiumDue { get => _escrowUSDAMonthlyPremiumDue; set => SetField(ref _escrowUSDAMonthlyPremiumDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction FloodInsurance
        /// </summary>
        public decimal? FloodInsurance { get => _floodInsurance; set => SetField(ref _floodInsurance, value); }

        /// <summary>
        /// SchedulePaymentTransaction Guid
        /// </summary>
        public string Guid { get => _guid; set => SetField(ref _guid, value); }

        /// <summary>
        /// SchedulePaymentTransaction HazardInsurance
        /// </summary>
        public decimal? HazardInsurance { get => _hazardInsurance; set => SetField(ref _hazardInsurance, value); }

        /// <summary>
        /// SchedulePaymentTransaction Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// SchedulePaymentTransaction IndexRate
        /// </summary>
        public decimal? IndexRate { get => _indexRate; set => SetField(ref _indexRate, value); }

        /// <summary>
        /// SchedulePaymentTransaction Interest
        /// </summary>
        public decimal? Interest { get => _interest; set => SetField(ref _interest, value); }

        /// <summary>
        /// SchedulePaymentTransaction InterestDue
        /// </summary>
        public decimal? InterestDue { get => _interestDue; set => SetField(ref _interestDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction InterestRate
        /// </summary>
        public decimal? InterestRate { get => _interestRate; set => SetField(ref _interestRate, value); }

        /// <summary>
        /// SchedulePaymentTransaction LateFee
        /// </summary>
        public decimal? LateFee { get => _lateFee; set => SetField(ref _lateFee, value); }

        /// <summary>
        /// SchedulePaymentTransaction LatePaymentDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? LatePaymentDate { get => _latePaymentDate; set => SetField(ref _latePaymentDate, value); }

        /// <summary>
        /// SchedulePaymentTransaction MiscFee
        /// </summary>
        public decimal? MiscFee { get => _miscFee; set => SetField(ref _miscFee, value); }

        /// <summary>
        /// SchedulePaymentTransaction MiscFeeDue
        /// </summary>
        public decimal? MiscFeeDue { get => _miscFeeDue; set => SetField(ref _miscFeeDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction ModifiedById
        /// </summary>
        public string ModifiedById { get => _modifiedById; set => SetField(ref _modifiedById, value); }

        /// <summary>
        /// SchedulePaymentTransaction ModifiedByName
        /// </summary>
        public string ModifiedByName { get => _modifiedByName; set => SetField(ref _modifiedByName, value); }

        /// <summary>
        /// SchedulePaymentTransaction ModifiedDateTimeUtc
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? ModifiedDateTimeUtc { get => _modifiedDateTimeUtc; set => SetField(ref _modifiedDateTimeUtc, value); }

        /// <summary>
        /// SchedulePaymentTransaction MortgageInsurance
        /// </summary>
        public decimal? MortgageInsurance { get => _mortgageInsurance; set => SetField(ref _mortgageInsurance, value); }

        /// <summary>
        /// SchedulePaymentTransaction Other1Escrow
        /// </summary>
        public decimal? Other1Escrow { get => _other1Escrow; set => SetField(ref _other1Escrow, value); }

        /// <summary>
        /// SchedulePaymentTransaction Other2Escrow
        /// </summary>
        public decimal? Other2Escrow { get => _other2Escrow; set => SetField(ref _other2Escrow, value); }

        /// <summary>
        /// SchedulePaymentTransaction Other3Escrow
        /// </summary>
        public decimal? Other3Escrow { get => _other3Escrow; set => SetField(ref _other3Escrow, value); }

        /// <summary>
        /// SchedulePaymentTransaction PaymentNumber
        /// </summary>
        public int? PaymentNumber { get => _paymentNumber; set => SetField(ref _paymentNumber, value); }

        /// <summary>
        /// SchedulePaymentTransaction PaymentReceiveDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? PaymentReceiveDate { get => _paymentReceiveDate; set => SetField(ref _paymentReceiveDate, value); }

        /// <summary>
        /// SchedulePaymentTransaction Principal
        /// </summary>
        public decimal? Principal { get => _principal; set => SetField(ref _principal, value); }

        /// <summary>
        /// SchedulePaymentTransaction PrincipalDue
        /// </summary>
        public decimal? PrincipalDue { get => _principalDue; set => SetField(ref _principalDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction ServicingPaymentMethod
        /// </summary>
        public string ServicingPaymentMethod { get => _servicingPaymentMethod; set => SetField(ref _servicingPaymentMethod, value); }

        /// <summary>
        /// SchedulePaymentTransaction ServicingTransactionType
        /// </summary>
        public string ServicingTransactionType { get => _servicingTransactionType; set => SetField(ref _servicingTransactionType, value); }

        /// <summary>
        /// SchedulePaymentTransaction Taxes
        /// </summary>
        public decimal? Taxes { get => _taxes; set => SetField(ref _taxes, value); }

        /// <summary>
        /// SchedulePaymentTransaction TotalPastDue
        /// </summary>
        public decimal? TotalPastDue { get => _totalPastDue; set => SetField(ref _totalPastDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction TransactionAmount
        /// </summary>
        public decimal? TransactionAmount { get => _transactionAmount; set => SetField(ref _transactionAmount, value); }

        /// <summary>
        /// SchedulePaymentTransaction TransactionDate
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
        public DateTime? TransactionDate { get => _transactionDate; set => SetField(ref _transactionDate, value); }

        /// <summary>
        /// SchedulePaymentTransaction UnpaidLateFeeDue
        /// </summary>
        public decimal? UnpaidLateFeeDue { get => _unpaidLateFeeDue; set => SetField(ref _unpaidLateFeeDue, value); }

        /// <summary>
        /// SchedulePaymentTransaction USDAMonthlyPremium
        /// </summary>
        public decimal? USDAMonthlyPremium { get => _uSDAMonthlyPremium; set => SetField(ref _uSDAMonthlyPremium, value); }
    }
}