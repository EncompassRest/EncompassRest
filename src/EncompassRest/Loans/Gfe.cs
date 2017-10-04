using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe : IDirty
    {
        private DirtyValue<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private DirtyValue<decimal?> _agregateAdjustment;
        public decimal? AgregateAdjustment { get { return _agregateAdjustment; } set { _agregateAdjustment = value; } }
        private DirtyValue<decimal?> _brokerCommission;
        public decimal? BrokerCommission { get { return _brokerCommission; } set { _brokerCommission = value; } }
        private DirtyValue<string> _brokerLicense;
        public string BrokerLicense { get { return _brokerLicense; } set { _brokerLicense = value; } }
        private DirtyValue<string> _brokerName;
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }
        private DirtyValue<string> _brokerRepresentative;
        public string BrokerRepresentative { get { return _brokerRepresentative; } set { _brokerRepresentative = value; } }
        private DirtyValue<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private DirtyValue<decimal?> _compensationFromLenderAmount;
        public decimal? CompensationFromLenderAmount { get { return _compensationFromLenderAmount; } set { _compensationFromLenderAmount = value; } }
        private DirtyValue<decimal?> _compensationFromLenderPercentage;
        public decimal? CompensationFromLenderPercentage { get { return _compensationFromLenderPercentage; } set { _compensationFromLenderPercentage = value; } }
        private DirtyValue<decimal?> _compensationFromLenderTotalAmount;
        public decimal? CompensationFromLenderTotalAmount { get { return _compensationFromLenderTotalAmount; } set { _compensationFromLenderTotalAmount = value; } }
        private DirtyValue<decimal?> _creditLifeOrDisabilityPremium;
        public decimal? CreditLifeOrDisabilityPremium { get { return _creditLifeOrDisabilityPremium; } set { _creditLifeOrDisabilityPremium = value; } }
        private DirtyValue<decimal?> _creditToBorrowerAmount;
        public decimal? CreditToBorrowerAmount { get { return _creditToBorrowerAmount; } set { _creditToBorrowerAmount = value; } }
        private DirtyValue<decimal?> _estimatedCashAtClosing;
        public decimal? EstimatedCashAtClosing { get { return _estimatedCashAtClosing; } set { _estimatedCashAtClosing = value; } }
        private DirtyValue<decimal?> _estimatedCashToBorrower;
        public decimal? EstimatedCashToBorrower { get { return _estimatedCashToBorrower; } set { _estimatedCashToBorrower = value; } }
        private DirtyValue<DateTime?> _estimatedDueDate;
        public DateTime? EstimatedDueDate { get { return _estimatedDueDate; } set { _estimatedDueDate = value; } }
        private DirtyValue<decimal?> _finalBalloonPayment;
        public decimal? FinalBalloonPayment { get { return _finalBalloonPayment; } set { _finalBalloonPayment = value; } }
        private DirtyValue<decimal?> _firstChangePayment;
        public decimal? FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        private DirtyValue<decimal?> _firstChangePercent;
        public decimal? FirstChangePercent { get { return _firstChangePercent; } set { _firstChangePercent = value; } }
        private DirtyValue<decimal?> _fundingAmount;
        public decimal? FundingAmount { get { return _fundingAmount; } set { _fundingAmount = value; } }
        private DirtyList<GfeFee> _gfeFees;
        public IList<GfeFee> GfeFees { get { var v = _gfeFees; return v ?? Interlocked.CompareExchange(ref _gfeFees, (v = new DirtyList<GfeFee>()), null) ?? v; } set { _gfeFees = new DirtyList<GfeFee>(value); } }
        private DirtyList<GfeLien> _gfeLiens;
        public IList<GfeLien> GfeLiens { get { var v = _gfeLiens; return v ?? Interlocked.CompareExchange(ref _gfeLiens, (v = new DirtyList<GfeLien>()), null) ?? v; } set { _gfeLiens = new DirtyList<GfeLien>(value); } }
        private DirtyList<GfePayment> _gfePayments;
        public IList<GfePayment> GfePayments { get { var v = _gfePayments; return v ?? Interlocked.CompareExchange(ref _gfePayments, (v = new DirtyList<GfePayment>()), null) ?? v; } set { _gfePayments = new DirtyList<GfePayment>(value); } }
        private DirtyList<GfePayoff> _gfePayoffs;
        public IList<GfePayoff> GfePayoffs { get { var v = _gfePayoffs; return v ?? Interlocked.CompareExchange(ref _gfePayoffs, (v = new DirtyList<GfePayoff>()), null) ?? v; } set { _gfePayoffs = new DirtyList<GfePayoff>(value); } }
        private DirtyValue<bool?> _gfeProvidedByBrokerIndicator;
        public bool? GfeProvidedByBrokerIndicator { get { return _gfeProvidedByBrokerIndicator; } set { _gfeProvidedByBrokerIndicator = value; } }
        private DirtyValue<bool?> _hasAdditionalCompensationIndicator;
        public bool? HasAdditionalCompensationIndicator { get { return _hasAdditionalCompensationIndicator; } set { _hasAdditionalCompensationIndicator = value; } }
        private DirtyValue<bool?> _hasLateChargesIndicator;
        public bool? HasLateChargesIndicator { get { return _hasLateChargesIndicator; } set { _hasLateChargesIndicator = value; } }
        private DirtyValue<bool?> _hasPrepaymentPenaltyIndicator;
        public bool? HasPrepaymentPenaltyIndicator { get { return _hasPrepaymentPenaltyIndicator; } set { _hasPrepaymentPenaltyIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _initialFixedOrArmType;
        public string InitialFixedOrArmType { get { return _initialFixedOrArmType; } set { _initialFixedOrArmType = value; } }
        private DirtyValue<decimal?> _lenderOriginationFee;
        public decimal? LenderOriginationFee { get { return _lenderOriginationFee; } set { _lenderOriginationFee = value; } }
        private DirtyValue<string> _loanFromBrokerControledFundsType;
        public string LoanFromBrokerControledFundsType { get { return _loanFromBrokerControledFundsType; } set { _loanFromBrokerControledFundsType = value; } }
        private DirtyValue<bool?> _lockField;
        public bool? LockField { get { return _lockField; } set { _lockField = value; } }
        private DirtyValue<decimal?> _maxLifePayment;
        public decimal? MaxLifePayment { get { return _maxLifePayment; } set { _maxLifePayment = value; } }
        private DirtyValue<int?> _maxPaymentAfterMonth;
        public int? MaxPaymentAfterMonth { get { return _maxPaymentAfterMonth; } set { _maxPaymentAfterMonth = value; } }
        private DirtyValue<decimal?> _monthlyPaymentAndEscrow;
        public decimal? MonthlyPaymentAndEscrow { get { return _monthlyPaymentAndEscrow; } set { _monthlyPaymentAndEscrow = value; } }
        private DirtyValue<decimal?> _mortgageBrokerComissionFee;
        public decimal? MortgageBrokerComissionFee { get { return _mortgageBrokerComissionFee; } set { _mortgageBrokerComissionFee = value; } }
        private DirtyValue<string> _mortgageBrokerComissionFeePaidToName;
        public string MortgageBrokerComissionFeePaidToName { get { return _mortgageBrokerComissionFeePaidToName; } set { _mortgageBrokerComissionFeePaidToName = value; } }
        private DirtyValue<string> _natureLien1Description;
        public string NatureLien1Description { get { return _natureLien1Description; } set { _natureLien1Description = value; } }
        private DirtyValue<string> _natureLien1PayoffDescription;
        public string NatureLien1PayoffDescription { get { return _natureLien1PayoffDescription; } set { _natureLien1PayoffDescription = value; } }
        private DirtyValue<string> _natureLien2Description;
        public string NatureLien2Description { get { return _natureLien2Description; } set { _natureLien2Description = value; } }
        private DirtyValue<string> _natureLien2PayoffDescription;
        public string NatureLien2PayoffDescription { get { return _natureLien2PayoffDescription; } set { _natureLien2PayoffDescription = value; } }
        private DirtyValue<string> _natureLien3Description;
        public string NatureLien3Description { get { return _natureLien3Description; } set { _natureLien3Description = value; } }
        private DirtyValue<string> _natureLien3PayoffDescription;
        public string NatureLien3PayoffDescription { get { return _natureLien3PayoffDescription; } set { _natureLien3PayoffDescription = value; } }
        private DirtyValue<bool?> _paymentOfPrincipleIndicator;
        public bool? PaymentOfPrincipleIndicator { get { return _paymentOfPrincipleIndicator; } set { _paymentOfPrincipleIndicator = value; } }
        private DirtyValue<string> _paymentOfPrincipleType;
        public string PaymentOfPrincipleType { get { return _paymentOfPrincipleType; } set { _paymentOfPrincipleType = value; } }
        private DirtyValue<int?> _penaltyNotToExceedMonths;
        public int? PenaltyNotToExceedMonths { get { return _penaltyNotToExceedMonths; } set { _penaltyNotToExceedMonths = value; } }
        private DirtyValue<string> _pocPaid1;
        public string PocPaid1 { get { return _pocPaid1; } set { _pocPaid1 = value; } }
        private DirtyValue<string> _pocPaid2;
        public string PocPaid2 { get { return _pocPaid2; } set { _pocPaid2 = value; } }
        private DirtyValue<string> _pocPaid3;
        public string PocPaid3 { get { return _pocPaid3; } set { _pocPaid3 = value; } }
        private DirtyValue<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private DirtyValue<string> _prepaymentOtherDescription;
        public string PrepaymentOtherDescription { get { return _prepaymentOtherDescription; } set { _prepaymentOtherDescription = value; } }
        private DirtyValue<bool?> _prepaymentOtherTypeIndicator;
        public bool? PrepaymentOtherTypeIndicator { get { return _prepaymentOtherTypeIndicator; } set { _prepaymentOtherTypeIndicator = value; } }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get { return _prepaymentPenaltyAmount; } set { _prepaymentPenaltyAmount = value; } }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private DirtyValue<int?> _prepaymentPenaltyPeriod;
        public int? PrepaymentPenaltyPeriod { get { return _prepaymentPenaltyPeriod; } set { _prepaymentPenaltyPeriod = value; } }
        private DirtyValue<decimal?> _principalAmount;
        public decimal? PrincipalAmount { get { return _principalAmount; } set { _principalAmount = value; } }
        private DirtyValue<decimal?> _purchasePayOff;
        public decimal? PurchasePayOff { get { return _purchasePayOff; } set { _purchasePayOff = value; } }
        private DirtyValue<decimal?> _re882AdditionalCompensation;
        public decimal? Re882AdditionalCompensation { get { return _re882AdditionalCompensation; } set { _re882AdditionalCompensation = value; } }
        private DirtyValue<decimal?> _receivedFromLenderAmount;
        public decimal? ReceivedFromLenderAmount { get { return _receivedFromLenderAmount; } set { _receivedFromLenderAmount = value; } }
        private DirtyValue<string> _representativeLicense;
        public string RepresentativeLicense { get { return _representativeLicense; } set { _representativeLicense = value; } }
        private DirtyValue<bool?> _sourcesDeemedReliableIndicator;
        public bool? SourcesDeemedReliableIndicator { get { return _sourcesDeemedReliableIndicator; } set { _sourcesDeemedReliableIndicator = value; } }
        private DirtyValue<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private DirtyValue<decimal?> _subtotalOfAllDeductions;
        public decimal? SubtotalOfAllDeductions { get { return _subtotalOfAllDeductions; } set { _subtotalOfAllDeductions = value; } }
        private DirtyValue<decimal?> _totalBrokerCompensationAmount;
        public decimal? TotalBrokerCompensationAmount { get { return _totalBrokerCompensationAmount; } set { _totalBrokerCompensationAmount = value; } }
        private DirtyValue<decimal?> _totalClosingCostWithDiscount;
        public decimal? TotalClosingCostWithDiscount { get { return _totalClosingCostWithDiscount; } set { _totalClosingCostWithDiscount = value; } }
        private DirtyValue<decimal?> _totalCostsExpenses;
        public decimal? TotalCostsExpenses { get { return _totalCostsExpenses; } set { _totalCostsExpenses = value; } }
        private DirtyValue<decimal?> _totalMaximumCostsExpenses;
        public decimal? TotalMaximumCostsExpenses { get { return _totalMaximumCostsExpenses; } set { _totalMaximumCostsExpenses = value; } }
        private DirtyValue<decimal?> _totalOfInitialFees;
        public decimal? TotalOfInitialFees { get { return _totalOfInitialFees; } set { _totalOfInitialFees = value; } }
        private DirtyValue<decimal?> _totalPrepaidClosingCost;
        public decimal? TotalPrepaidClosingCost { get { return _totalPrepaidClosingCost; } set { _totalPrepaidClosingCost = value; } }
        private DirtyValue<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get { return _totalSettlementCharges; } set { _totalSettlementCharges = value; } }
        private DirtyValue<decimal?> _totalTaxAndInsurance;
        public decimal? TotalTaxAndInsurance { get { return _totalTaxAndInsurance; } set { _totalTaxAndInsurance = value; } }
        private DirtyValue<decimal?> _yearlyFloodInsurance;
        public decimal? YearlyFloodInsurance { get { return _yearlyFloodInsurance; } set { _yearlyFloodInsurance = value; } }
        private DirtyValue<decimal?> _yearlyInsurance;
        public decimal? YearlyInsurance { get { return _yearlyInsurance; } set { _yearlyInsurance = value; } }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        private DirtyValue<decimal?> _yearlyOtherInsurance;
        public decimal? YearlyOtherInsurance { get { return _yearlyOtherInsurance; } set { _yearlyOtherInsurance = value; } }
        private DirtyValue<string> _yearlyOtherInsuranceDescription;
        public string YearlyOtherInsuranceDescription { get { return _yearlyOtherInsuranceDescription; } set { _yearlyOtherInsuranceDescription = value; } }
        private DirtyValue<decimal?> _yearlyTax;
        public decimal? YearlyTax { get { return _yearlyTax; } set { _yearlyTax = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _address.Dirty
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
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
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
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}