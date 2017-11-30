using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe : ExtensibleObject
    {
        private DirtyValue<string> _address;
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _agregateAdjustment;
        public decimal? AgregateAdjustment { get => _agregateAdjustment; set => _agregateAdjustment = value; }
        private DirtyValue<decimal?> _brokerCommission;
        public decimal? BrokerCommission { get => _brokerCommission; set => _brokerCommission = value; }
        private DirtyValue<string> _brokerLicense;
        public string BrokerLicense { get => _brokerLicense; set => _brokerLicense = value; }
        private DirtyValue<string> _brokerName;
        public string BrokerName { get => _brokerName; set => _brokerName = value; }
        private DirtyValue<string> _brokerRepresentative;
        public string BrokerRepresentative { get => _brokerRepresentative; set => _brokerRepresentative = value; }
        private DirtyValue<string> _city;
        public string City { get => _city; set => _city = value; }
        private DirtyValue<decimal?> _compensationFromLenderAmount;
        public decimal? CompensationFromLenderAmount { get => _compensationFromLenderAmount; set => _compensationFromLenderAmount = value; }
        private DirtyValue<decimal?> _compensationFromLenderPercentage;
        public decimal? CompensationFromLenderPercentage { get => _compensationFromLenderPercentage; set => _compensationFromLenderPercentage = value; }
        private DirtyValue<decimal?> _compensationFromLenderTotalAmount;
        public decimal? CompensationFromLenderTotalAmount { get => _compensationFromLenderTotalAmount; set => _compensationFromLenderTotalAmount = value; }
        private DirtyValue<decimal?> _creditLifeOrDisabilityPremium;
        public decimal? CreditLifeOrDisabilityPremium { get => _creditLifeOrDisabilityPremium; set => _creditLifeOrDisabilityPremium = value; }
        private DirtyValue<decimal?> _creditToBorrowerAmount;
        public decimal? CreditToBorrowerAmount { get => _creditToBorrowerAmount; set => _creditToBorrowerAmount = value; }
        private DirtyValue<decimal?> _estimatedCashAtClosing;
        public decimal? EstimatedCashAtClosing { get => _estimatedCashAtClosing; set => _estimatedCashAtClosing = value; }
        private DirtyValue<decimal?> _estimatedCashToBorrower;
        public decimal? EstimatedCashToBorrower { get => _estimatedCashToBorrower; set => _estimatedCashToBorrower = value; }
        private DirtyValue<DateTime?> _estimatedDueDate;
        public DateTime? EstimatedDueDate { get => _estimatedDueDate; set => _estimatedDueDate = value; }
        private DirtyValue<decimal?> _finalBalloonPayment;
        public decimal? FinalBalloonPayment { get => _finalBalloonPayment; set => _finalBalloonPayment = value; }
        private DirtyValue<decimal?> _firstChangePayment;
        public decimal? FirstChangePayment { get => _firstChangePayment; set => _firstChangePayment = value; }
        private DirtyValue<decimal?> _firstChangePercent;
        public decimal? FirstChangePercent { get => _firstChangePercent; set => _firstChangePercent = value; }
        private DirtyValue<decimal?> _fundingAmount;
        public decimal? FundingAmount { get => _fundingAmount; set => _fundingAmount = value; }
        private DirtyList<GfeFee> _gfeFees;
        public IList<GfeFee> GfeFees { get => _gfeFees ?? (_gfeFees = new DirtyList<GfeFee>()); set => _gfeFees = new DirtyList<GfeFee>(value); }
        private DirtyList<GfeLien> _gfeLiens;
        public IList<GfeLien> GfeLiens { get => _gfeLiens ?? (_gfeLiens = new DirtyList<GfeLien>()); set => _gfeLiens = new DirtyList<GfeLien>(value); }
        private DirtyList<GfePayment> _gfePayments;
        public IList<GfePayment> GfePayments { get => _gfePayments ?? (_gfePayments = new DirtyList<GfePayment>()); set => _gfePayments = new DirtyList<GfePayment>(value); }
        private DirtyList<GfePayoff> _gfePayoffs;
        public IList<GfePayoff> GfePayoffs { get => _gfePayoffs ?? (_gfePayoffs = new DirtyList<GfePayoff>()); set => _gfePayoffs = new DirtyList<GfePayoff>(value); }
        private DirtyValue<bool?> _gfeProvidedByBrokerIndicator;
        public bool? GfeProvidedByBrokerIndicator { get => _gfeProvidedByBrokerIndicator; set => _gfeProvidedByBrokerIndicator = value; }
        private DirtyValue<bool?> _hasAdditionalCompensationIndicator;
        public bool? HasAdditionalCompensationIndicator { get => _hasAdditionalCompensationIndicator; set => _hasAdditionalCompensationIndicator = value; }
        private DirtyValue<bool?> _hasLateChargesIndicator;
        public bool? HasLateChargesIndicator { get => _hasLateChargesIndicator; set => _hasLateChargesIndicator = value; }
        private DirtyValue<bool?> _hasPrepaymentPenaltyIndicator;
        public bool? HasPrepaymentPenaltyIndicator { get => _hasPrepaymentPenaltyIndicator; set => _hasPrepaymentPenaltyIndicator = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<InitialFixedOrArmType>> _initialFixedOrArmType;
        public StringEnumValue<InitialFixedOrArmType> InitialFixedOrArmType { get => _initialFixedOrArmType; set => _initialFixedOrArmType = value; }
        private DirtyValue<decimal?> _lenderOriginationFee;
        public decimal? LenderOriginationFee { get => _lenderOriginationFee; set => _lenderOriginationFee = value; }
        private DirtyValue<StringEnumValue<LoanFromBrokerControledFundsType>> _loanFromBrokerControledFundsType;
        public StringEnumValue<LoanFromBrokerControledFundsType> LoanFromBrokerControledFundsType { get => _loanFromBrokerControledFundsType; set => _loanFromBrokerControledFundsType = value; }
        private DirtyValue<bool?> _lockField;
        public bool? LockField { get => _lockField; set => _lockField = value; }
        private DirtyValue<decimal?> _maxLifePayment;
        public decimal? MaxLifePayment { get => _maxLifePayment; set => _maxLifePayment = value; }
        private DirtyValue<int?> _maxPaymentAfterMonth;
        public int? MaxPaymentAfterMonth { get => _maxPaymentAfterMonth; set => _maxPaymentAfterMonth = value; }
        private DirtyValue<decimal?> _monthlyPaymentAndEscrow;
        public decimal? MonthlyPaymentAndEscrow { get => _monthlyPaymentAndEscrow; set => _monthlyPaymentAndEscrow = value; }
        private DirtyValue<decimal?> _mortgageBrokerComissionFee;
        public decimal? MortgageBrokerComissionFee { get => _mortgageBrokerComissionFee; set => _mortgageBrokerComissionFee = value; }
        private DirtyValue<string> _mortgageBrokerComissionFeePaidToName;
        public string MortgageBrokerComissionFeePaidToName { get => _mortgageBrokerComissionFeePaidToName; set => _mortgageBrokerComissionFeePaidToName = value; }
        private DirtyValue<string> _natureLien1Description;
        public string NatureLien1Description { get => _natureLien1Description; set => _natureLien1Description = value; }
        private DirtyValue<string> _natureLien1PayoffDescription;
        public string NatureLien1PayoffDescription { get => _natureLien1PayoffDescription; set => _natureLien1PayoffDescription = value; }
        private DirtyValue<string> _natureLien2Description;
        public string NatureLien2Description { get => _natureLien2Description; set => _natureLien2Description = value; }
        private DirtyValue<string> _natureLien2PayoffDescription;
        public string NatureLien2PayoffDescription { get => _natureLien2PayoffDescription; set => _natureLien2PayoffDescription = value; }
        private DirtyValue<string> _natureLien3Description;
        public string NatureLien3Description { get => _natureLien3Description; set => _natureLien3Description = value; }
        private DirtyValue<string> _natureLien3PayoffDescription;
        public string NatureLien3PayoffDescription { get => _natureLien3PayoffDescription; set => _natureLien3PayoffDescription = value; }
        private DirtyValue<bool?> _paymentOfPrincipleIndicator;
        public bool? PaymentOfPrincipleIndicator { get => _paymentOfPrincipleIndicator; set => _paymentOfPrincipleIndicator = value; }
        private DirtyValue<StringEnumValue<PaymentOfPrincipleType>> _paymentOfPrincipleType;
        public StringEnumValue<PaymentOfPrincipleType> PaymentOfPrincipleType { get => _paymentOfPrincipleType; set => _paymentOfPrincipleType = value; }
        private DirtyValue<int?> _penaltyNotToExceedMonths;
        public int? PenaltyNotToExceedMonths { get => _penaltyNotToExceedMonths; set => _penaltyNotToExceedMonths = value; }
        private DirtyValue<string> _pocPaid1;
        public string PocPaid1 { get => _pocPaid1; set => _pocPaid1 = value; }
        private DirtyValue<string> _pocPaid2;
        public string PocPaid2 { get => _pocPaid2; set => _pocPaid2 = value; }
        private DirtyValue<string> _pocPaid3;
        public string PocPaid3 { get => _pocPaid3; set => _pocPaid3 = value; }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _prepaymentOtherDescription;
        public string PrepaymentOtherDescription { get => _prepaymentOtherDescription; set => _prepaymentOtherDescription = value; }
        private DirtyValue<bool?> _prepaymentOtherTypeIndicator;
        public bool? PrepaymentOtherTypeIndicator { get => _prepaymentOtherTypeIndicator; set => _prepaymentOtherTypeIndicator = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => _prepaymentPenaltyAmount = value; }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<int?> _prepaymentPenaltyPeriod;
        public int? PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => _prepaymentPenaltyPeriod = value; }
        private DirtyValue<decimal?> _principalAmount;
        public decimal? PrincipalAmount { get => _principalAmount; set => _principalAmount = value; }
        private DirtyValue<decimal?> _purchasePayOff;
        public decimal? PurchasePayOff { get => _purchasePayOff; set => _purchasePayOff = value; }
        private DirtyValue<decimal?> _re882AdditionalCompensation;
        public decimal? Re882AdditionalCompensation { get => _re882AdditionalCompensation; set => _re882AdditionalCompensation = value; }
        private DirtyValue<decimal?> _receivedFromLenderAmount;
        public decimal? ReceivedFromLenderAmount { get => _receivedFromLenderAmount; set => _receivedFromLenderAmount = value; }
        private DirtyValue<string> _representativeLicense;
        public string RepresentativeLicense { get => _representativeLicense; set => _representativeLicense = value; }
        private DirtyValue<bool?> _sourcesDeemedReliableIndicator;
        public bool? SourcesDeemedReliableIndicator { get => _sourcesDeemedReliableIndicator; set => _sourcesDeemedReliableIndicator = value; }
        private DirtyValue<string> _state;
        public string State { get => _state; set => _state = value; }
        private DirtyValue<decimal?> _subtotalOfAllDeductions;
        public decimal? SubtotalOfAllDeductions { get => _subtotalOfAllDeductions; set => _subtotalOfAllDeductions = value; }
        private DirtyValue<decimal?> _totalBrokerCompensationAmount;
        public decimal? TotalBrokerCompensationAmount { get => _totalBrokerCompensationAmount; set => _totalBrokerCompensationAmount = value; }
        private DirtyValue<decimal?> _totalClosingCostWithDiscount;
        public decimal? TotalClosingCostWithDiscount { get => _totalClosingCostWithDiscount; set => _totalClosingCostWithDiscount = value; }
        private DirtyValue<decimal?> _totalCostsExpenses;
        public decimal? TotalCostsExpenses { get => _totalCostsExpenses; set => _totalCostsExpenses = value; }
        private DirtyValue<decimal?> _totalMaximumCostsExpenses;
        public decimal? TotalMaximumCostsExpenses { get => _totalMaximumCostsExpenses; set => _totalMaximumCostsExpenses = value; }
        private DirtyValue<decimal?> _totalOfInitialFees;
        public decimal? TotalOfInitialFees { get => _totalOfInitialFees; set => _totalOfInitialFees = value; }
        private DirtyValue<decimal?> _totalPrepaidClosingCost;
        public decimal? TotalPrepaidClosingCost { get => _totalPrepaidClosingCost; set => _totalPrepaidClosingCost = value; }
        private DirtyValue<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => _totalSettlementCharges = value; }
        private DirtyValue<decimal?> _totalTaxAndInsurance;
        public decimal? TotalTaxAndInsurance { get => _totalTaxAndInsurance; set => _totalTaxAndInsurance = value; }
        private DirtyValue<decimal?> _yearlyFloodInsurance;
        public decimal? YearlyFloodInsurance { get => _yearlyFloodInsurance; set => _yearlyFloodInsurance = value; }
        private DirtyValue<decimal?> _yearlyInsurance;
        public decimal? YearlyInsurance { get => _yearlyInsurance; set => _yearlyInsurance = value; }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => _yearlyMortgageInsurance = value; }
        private DirtyValue<decimal?> _yearlyOtherInsurance;
        public decimal? YearlyOtherInsurance { get => _yearlyOtherInsurance; set => _yearlyOtherInsurance = value; }
        private DirtyValue<string> _yearlyOtherInsuranceDescription;
        public string YearlyOtherInsuranceDescription { get => _yearlyOtherInsuranceDescription; set => _yearlyOtherInsuranceDescription = value; }
        private DirtyValue<decimal?> _yearlyTax;
        public decimal? YearlyTax { get => _yearlyTax; set => _yearlyTax = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _address.Dirty
                    || _agregateAdjustment.Dirty
                    || _brokerCommission.Dirty
                    || _brokerLicense.Dirty
                    || _brokerName.Dirty
                    || _brokerRepresentative.Dirty
                    || _city.Dirty
                    || _compensationFromLenderAmount.Dirty
                    || _compensationFromLenderPercentage.Dirty
                    || _compensationFromLenderTotalAmount.Dirty
                    || _creditLifeOrDisabilityPremium.Dirty
                    || _creditToBorrowerAmount.Dirty
                    || _estimatedCashAtClosing.Dirty
                    || _estimatedCashToBorrower.Dirty
                    || _estimatedDueDate.Dirty
                    || _finalBalloonPayment.Dirty
                    || _firstChangePayment.Dirty
                    || _firstChangePercent.Dirty
                    || _fundingAmount.Dirty
                    || _gfeProvidedByBrokerIndicator.Dirty
                    || _hasAdditionalCompensationIndicator.Dirty
                    || _hasLateChargesIndicator.Dirty
                    || _hasPrepaymentPenaltyIndicator.Dirty
                    || _id.Dirty
                    || _initialFixedOrArmType.Dirty
                    || _lenderOriginationFee.Dirty
                    || _loanFromBrokerControledFundsType.Dirty
                    || _lockField.Dirty
                    || _maxLifePayment.Dirty
                    || _maxPaymentAfterMonth.Dirty
                    || _monthlyPaymentAndEscrow.Dirty
                    || _mortgageBrokerComissionFee.Dirty
                    || _mortgageBrokerComissionFeePaidToName.Dirty
                    || _natureLien1Description.Dirty
                    || _natureLien1PayoffDescription.Dirty
                    || _natureLien2Description.Dirty
                    || _natureLien2PayoffDescription.Dirty
                    || _natureLien3Description.Dirty
                    || _natureLien3PayoffDescription.Dirty
                    || _paymentOfPrincipleIndicator.Dirty
                    || _paymentOfPrincipleType.Dirty
                    || _penaltyNotToExceedMonths.Dirty
                    || _pocPaid1.Dirty
                    || _pocPaid2.Dirty
                    || _pocPaid3.Dirty
                    || _postalCode.Dirty
                    || _prepaymentOtherDescription.Dirty
                    || _prepaymentOtherTypeIndicator.Dirty
                    || _prepaymentPenaltyAmount.Dirty
                    || _prepaymentPenaltyIndicator.Dirty
                    || _prepaymentPenaltyPeriod.Dirty
                    || _principalAmount.Dirty
                    || _purchasePayOff.Dirty
                    || _re882AdditionalCompensation.Dirty
                    || _receivedFromLenderAmount.Dirty
                    || _representativeLicense.Dirty
                    || _sourcesDeemedReliableIndicator.Dirty
                    || _state.Dirty
                    || _subtotalOfAllDeductions.Dirty
                    || _totalBrokerCompensationAmount.Dirty
                    || _totalClosingCostWithDiscount.Dirty
                    || _totalCostsExpenses.Dirty
                    || _totalMaximumCostsExpenses.Dirty
                    || _totalOfInitialFees.Dirty
                    || _totalPrepaidClosingCost.Dirty
                    || _totalSettlementCharges.Dirty
                    || _totalTaxAndInsurance.Dirty
                    || _yearlyFloodInsurance.Dirty
                    || _yearlyInsurance.Dirty
                    || _yearlyMortgageInsurance.Dirty
                    || _yearlyOtherInsurance.Dirty
                    || _yearlyOtherInsuranceDescription.Dirty
                    || _yearlyTax.Dirty
                    || _gfeFees?.Dirty == true
                    || _gfeLiens?.Dirty == true
                    || _gfePayments?.Dirty == true
                    || _gfePayoffs?.Dirty == true;
            }
            set
            {
                _address.Dirty = value;
                _agregateAdjustment.Dirty = value;
                _brokerCommission.Dirty = value;
                _brokerLicense.Dirty = value;
                _brokerName.Dirty = value;
                _brokerRepresentative.Dirty = value;
                _city.Dirty = value;
                _compensationFromLenderAmount.Dirty = value;
                _compensationFromLenderPercentage.Dirty = value;
                _compensationFromLenderTotalAmount.Dirty = value;
                _creditLifeOrDisabilityPremium.Dirty = value;
                _creditToBorrowerAmount.Dirty = value;
                _estimatedCashAtClosing.Dirty = value;
                _estimatedCashToBorrower.Dirty = value;
                _estimatedDueDate.Dirty = value;
                _finalBalloonPayment.Dirty = value;
                _firstChangePayment.Dirty = value;
                _firstChangePercent.Dirty = value;
                _fundingAmount.Dirty = value;
                _gfeProvidedByBrokerIndicator.Dirty = value;
                _hasAdditionalCompensationIndicator.Dirty = value;
                _hasLateChargesIndicator.Dirty = value;
                _hasPrepaymentPenaltyIndicator.Dirty = value;
                _id.Dirty = value;
                _initialFixedOrArmType.Dirty = value;
                _lenderOriginationFee.Dirty = value;
                _loanFromBrokerControledFundsType.Dirty = value;
                _lockField.Dirty = value;
                _maxLifePayment.Dirty = value;
                _maxPaymentAfterMonth.Dirty = value;
                _monthlyPaymentAndEscrow.Dirty = value;
                _mortgageBrokerComissionFee.Dirty = value;
                _mortgageBrokerComissionFeePaidToName.Dirty = value;
                _natureLien1Description.Dirty = value;
                _natureLien1PayoffDescription.Dirty = value;
                _natureLien2Description.Dirty = value;
                _natureLien2PayoffDescription.Dirty = value;
                _natureLien3Description.Dirty = value;
                _natureLien3PayoffDescription.Dirty = value;
                _paymentOfPrincipleIndicator.Dirty = value;
                _paymentOfPrincipleType.Dirty = value;
                _penaltyNotToExceedMonths.Dirty = value;
                _pocPaid1.Dirty = value;
                _pocPaid2.Dirty = value;
                _pocPaid3.Dirty = value;
                _postalCode.Dirty = value;
                _prepaymentOtherDescription.Dirty = value;
                _prepaymentOtherTypeIndicator.Dirty = value;
                _prepaymentPenaltyAmount.Dirty = value;
                _prepaymentPenaltyIndicator.Dirty = value;
                _prepaymentPenaltyPeriod.Dirty = value;
                _principalAmount.Dirty = value;
                _purchasePayOff.Dirty = value;
                _re882AdditionalCompensation.Dirty = value;
                _receivedFromLenderAmount.Dirty = value;
                _representativeLicense.Dirty = value;
                _sourcesDeemedReliableIndicator.Dirty = value;
                _state.Dirty = value;
                _subtotalOfAllDeductions.Dirty = value;
                _totalBrokerCompensationAmount.Dirty = value;
                _totalClosingCostWithDiscount.Dirty = value;
                _totalCostsExpenses.Dirty = value;
                _totalMaximumCostsExpenses.Dirty = value;
                _totalOfInitialFees.Dirty = value;
                _totalPrepaidClosingCost.Dirty = value;
                _totalSettlementCharges.Dirty = value;
                _totalTaxAndInsurance.Dirty = value;
                _yearlyFloodInsurance.Dirty = value;
                _yearlyInsurance.Dirty = value;
                _yearlyMortgageInsurance.Dirty = value;
                _yearlyOtherInsurance.Dirty = value;
                _yearlyOtherInsuranceDescription.Dirty = value;
                _yearlyTax.Dirty = value;
                if (_gfeFees != null) _gfeFees.Dirty = value;
                if (_gfeLiens != null) _gfeLiens.Dirty = value;
                if (_gfePayments != null) _gfePayments.Dirty = value;
                if (_gfePayoffs != null) _gfePayoffs.Dirty = value;
            }
        }
    }
}