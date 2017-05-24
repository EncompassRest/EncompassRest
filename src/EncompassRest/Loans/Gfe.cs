using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAddress() => !_address.Clean;
        private Value<decimal?> _agregateAdjustment;
        public decimal? AgregateAdjustment { get { return _agregateAdjustment; } set { _agregateAdjustment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAgregateAdjustment() => !_agregateAdjustment.Clean;
        private Value<decimal?> _brokerCommission;
        public decimal? BrokerCommission { get { return _brokerCommission; } set { _brokerCommission = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCommission() => !_brokerCommission.Clean;
        private Value<string> _brokerLicense;
        public string BrokerLicense { get { return _brokerLicense; } set { _brokerLicense = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerLicense() => !_brokerLicense.Clean;
        private Value<string> _brokerName;
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerName() => !_brokerName.Clean;
        private Value<string> _brokerRepresentative;
        public string BrokerRepresentative { get { return _brokerRepresentative; } set { _brokerRepresentative = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerRepresentative() => !_brokerRepresentative.Clean;
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCity() => !_city.Clean;
        private Value<decimal?> _compensationFromLenderAmount;
        public decimal? CompensationFromLenderAmount { get { return _compensationFromLenderAmount; } set { _compensationFromLenderAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderAmount() => !_compensationFromLenderAmount.Clean;
        private Value<decimal?> _compensationFromLenderPercentage;
        public decimal? CompensationFromLenderPercentage { get { return _compensationFromLenderPercentage; } set { _compensationFromLenderPercentage = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderPercentage() => !_compensationFromLenderPercentage.Clean;
        private Value<decimal?> _compensationFromLenderTotalAmount;
        public decimal? CompensationFromLenderTotalAmount { get { return _compensationFromLenderTotalAmount; } set { _compensationFromLenderTotalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCompensationFromLenderTotalAmount() => !_compensationFromLenderTotalAmount.Clean;
        private Value<decimal?> _creditLifeOrDisabilityPremium;
        public decimal? CreditLifeOrDisabilityPremium { get { return _creditLifeOrDisabilityPremium; } set { _creditLifeOrDisabilityPremium = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditLifeOrDisabilityPremium() => !_creditLifeOrDisabilityPremium.Clean;
        private Value<decimal?> _creditToBorrowerAmount;
        public decimal? CreditToBorrowerAmount { get { return _creditToBorrowerAmount; } set { _creditToBorrowerAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCreditToBorrowerAmount() => !_creditToBorrowerAmount.Clean;
        private Value<decimal?> _estimatedCashAtClosing;
        public decimal? EstimatedCashAtClosing { get { return _estimatedCashAtClosing; } set { _estimatedCashAtClosing = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashAtClosing() => !_estimatedCashAtClosing.Clean;
        private Value<decimal?> _estimatedCashToBorrower;
        public decimal? EstimatedCashToBorrower { get { return _estimatedCashToBorrower; } set { _estimatedCashToBorrower = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedCashToBorrower() => !_estimatedCashToBorrower.Clean;
        private Value<DateTime?> _estimatedDueDate;
        public DateTime? EstimatedDueDate { get { return _estimatedDueDate; } set { _estimatedDueDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEstimatedDueDate() => !_estimatedDueDate.Clean;
        private Value<decimal?> _finalBalloonPayment;
        public decimal? FinalBalloonPayment { get { return _finalBalloonPayment; } set { _finalBalloonPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinalBalloonPayment() => !_finalBalloonPayment.Clean;
        private Value<decimal?> _firstChangePayment;
        public decimal? FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePayment() => !_firstChangePayment.Clean;
        private Value<decimal?> _firstChangePercent;
        public decimal? FirstChangePercent { get { return _firstChangePercent; } set { _firstChangePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstChangePercent() => !_firstChangePercent.Clean;
        private Value<decimal?> _fundingAmount;
        public decimal? FundingAmount { get { return _fundingAmount; } set { _fundingAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFundingAmount() => !_fundingAmount.Clean;
        private Value<List<GfeFee>> _gfeFees;
        public List<GfeFee> GfeFees { get { return _gfeFees; } set { _gfeFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeFees() => !_gfeFees.Clean;
        private Value<List<GfeLien>> _gfeLiens;
        public List<GfeLien> GfeLiens { get { return _gfeLiens; } set { _gfeLiens = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeLiens() => !_gfeLiens.Clean;
        private Value<List<GfePayment>> _gfePayments;
        public List<GfePayment> GfePayments { get { return _gfePayments; } set { _gfePayments = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePayments() => !_gfePayments.Clean;
        private Value<List<GfePayoff>> _gfePayoffs;
        public List<GfePayoff> GfePayoffs { get { return _gfePayoffs; } set { _gfePayoffs = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfePayoffs() => !_gfePayoffs.Clean;
        private Value<bool?> _gfeProvidedByBrokerIndicator;
        public bool? GfeProvidedByBrokerIndicator { get { return _gfeProvidedByBrokerIndicator; } set { _gfeProvidedByBrokerIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeProvidedByBrokerIndicator() => !_gfeProvidedByBrokerIndicator.Clean;
        private Value<bool?> _hasAdditionalCompensationIndicator;
        public bool? HasAdditionalCompensationIndicator { get { return _hasAdditionalCompensationIndicator; } set { _hasAdditionalCompensationIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasAdditionalCompensationIndicator() => !_hasAdditionalCompensationIndicator.Clean;
        private Value<bool?> _hasLateChargesIndicator;
        public bool? HasLateChargesIndicator { get { return _hasLateChargesIndicator; } set { _hasLateChargesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasLateChargesIndicator() => !_hasLateChargesIndicator.Clean;
        private Value<bool?> _hasPrepaymentPenaltyIndicator;
        public bool? HasPrepaymentPenaltyIndicator { get { return _hasPrepaymentPenaltyIndicator; } set { _hasPrepaymentPenaltyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasPrepaymentPenaltyIndicator() => !_hasPrepaymentPenaltyIndicator.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<string> _initialFixedOrArmType;
        public string InitialFixedOrArmType { get { return _initialFixedOrArmType; } set { _initialFixedOrArmType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInitialFixedOrArmType() => !_initialFixedOrArmType.Clean;
        private Value<decimal?> _lenderOriginationFee;
        public decimal? LenderOriginationFee { get { return _lenderOriginationFee; } set { _lenderOriginationFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderOriginationFee() => !_lenderOriginationFee.Clean;
        private Value<string> _loanFromBrokerControledFundsType;
        public string LoanFromBrokerControledFundsType { get { return _loanFromBrokerControledFundsType; } set { _loanFromBrokerControledFundsType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanFromBrokerControledFundsType() => !_loanFromBrokerControledFundsType.Clean;
        private Value<bool?> _lockField;
        public bool? LockField { get { return _lockField; } set { _lockField = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLockField() => !_lockField.Clean;
        private Value<decimal?> _maxLifePayment;
        public decimal? MaxLifePayment { get { return _maxLifePayment; } set { _maxLifePayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxLifePayment() => !_maxLifePayment.Clean;
        private Value<int?> _maxPaymentAfterMonth;
        public int? MaxPaymentAfterMonth { get { return _maxPaymentAfterMonth; } set { _maxPaymentAfterMonth = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMaxPaymentAfterMonth() => !_maxPaymentAfterMonth.Clean;
        private Value<decimal?> _monthlyPaymentAndEscrow;
        public decimal? MonthlyPaymentAndEscrow { get { return _monthlyPaymentAndEscrow; } set { _monthlyPaymentAndEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPaymentAndEscrow() => !_monthlyPaymentAndEscrow.Clean;
        private Value<decimal?> _mortgageBrokerComissionFee;
        public decimal? MortgageBrokerComissionFee { get { return _mortgageBrokerComissionFee; } set { _mortgageBrokerComissionFee = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerComissionFee() => !_mortgageBrokerComissionFee.Clean;
        private Value<string> _mortgageBrokerComissionFeePaidToName;
        public string MortgageBrokerComissionFeePaidToName { get { return _mortgageBrokerComissionFeePaidToName; } set { _mortgageBrokerComissionFeePaidToName = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMortgageBrokerComissionFeePaidToName() => !_mortgageBrokerComissionFeePaidToName.Clean;
        private Value<string> _natureLien1Description;
        public string NatureLien1Description { get { return _natureLien1Description; } set { _natureLien1Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien1Description() => !_natureLien1Description.Clean;
        private Value<string> _natureLien1PayoffDescription;
        public string NatureLien1PayoffDescription { get { return _natureLien1PayoffDescription; } set { _natureLien1PayoffDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien1PayoffDescription() => !_natureLien1PayoffDescription.Clean;
        private Value<string> _natureLien2Description;
        public string NatureLien2Description { get { return _natureLien2Description; } set { _natureLien2Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien2Description() => !_natureLien2Description.Clean;
        private Value<string> _natureLien2PayoffDescription;
        public string NatureLien2PayoffDescription { get { return _natureLien2PayoffDescription; } set { _natureLien2PayoffDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien2PayoffDescription() => !_natureLien2PayoffDescription.Clean;
        private Value<string> _natureLien3Description;
        public string NatureLien3Description { get { return _natureLien3Description; } set { _natureLien3Description = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien3Description() => !_natureLien3Description.Clean;
        private Value<string> _natureLien3PayoffDescription;
        public string NatureLien3PayoffDescription { get { return _natureLien3PayoffDescription; } set { _natureLien3PayoffDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNatureLien3PayoffDescription() => !_natureLien3PayoffDescription.Clean;
        private Value<bool?> _paymentOfPrincipleIndicator;
        public bool? PaymentOfPrincipleIndicator { get { return _paymentOfPrincipleIndicator; } set { _paymentOfPrincipleIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentOfPrincipleIndicator() => !_paymentOfPrincipleIndicator.Clean;
        private Value<string> _paymentOfPrincipleType;
        public string PaymentOfPrincipleType { get { return _paymentOfPrincipleType; } set { _paymentOfPrincipleType = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaymentOfPrincipleType() => !_paymentOfPrincipleType.Clean;
        private Value<int?> _penaltyNotToExceedMonths;
        public int? PenaltyNotToExceedMonths { get { return _penaltyNotToExceedMonths; } set { _penaltyNotToExceedMonths = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePenaltyNotToExceedMonths() => !_penaltyNotToExceedMonths.Clean;
        private Value<string> _pocPaid1;
        public string PocPaid1 { get { return _pocPaid1; } set { _pocPaid1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid1() => !_pocPaid1.Clean;
        private Value<string> _pocPaid2;
        public string PocPaid2 { get { return _pocPaid2; } set { _pocPaid2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid2() => !_pocPaid2.Clean;
        private Value<string> _pocPaid3;
        public string PocPaid3 { get { return _pocPaid3; } set { _pocPaid3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPaid3() => !_pocPaid3.Clean;
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePostalCode() => !_postalCode.Clean;
        private Value<string> _prepaymentOtherDescription;
        public string PrepaymentOtherDescription { get { return _prepaymentOtherDescription; } set { _prepaymentOtherDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentOtherDescription() => !_prepaymentOtherDescription.Clean;
        private Value<bool?> _prepaymentOtherTypeIndicator;
        public bool? PrepaymentOtherTypeIndicator { get { return _prepaymentOtherTypeIndicator; } set { _prepaymentOtherTypeIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentOtherTypeIndicator() => !_prepaymentOtherTypeIndicator.Clean;
        private Value<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get { return _prepaymentPenaltyAmount; } set { _prepaymentPenaltyAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyAmount() => !_prepaymentPenaltyAmount.Clean;
        private Value<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyIndicator() => !_prepaymentPenaltyIndicator.Clean;
        private Value<int?> _prepaymentPenaltyPeriod;
        public int? PrepaymentPenaltyPeriod { get { return _prepaymentPenaltyPeriod; } set { _prepaymentPenaltyPeriod = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaymentPenaltyPeriod() => !_prepaymentPenaltyPeriod.Clean;
        private Value<decimal?> _principalAmount;
        public decimal? PrincipalAmount { get { return _principalAmount; } set { _principalAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrincipalAmount() => !_principalAmount.Clean;
        private Value<decimal?> _purchasePayOff;
        public decimal? PurchasePayOff { get { return _purchasePayOff; } set { _purchasePayOff = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePurchasePayOff() => !_purchasePayOff.Clean;
        private Value<decimal?> _re882AdditionalCompensation;
        public decimal? Re882AdditionalCompensation { get { return _re882AdditionalCompensation; } set { _re882AdditionalCompensation = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRe882AdditionalCompensation() => !_re882AdditionalCompensation.Clean;
        private Value<decimal?> _receivedFromLenderAmount;
        public decimal? ReceivedFromLenderAmount { get { return _receivedFromLenderAmount; } set { _receivedFromLenderAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeReceivedFromLenderAmount() => !_receivedFromLenderAmount.Clean;
        private Value<string> _representativeLicense;
        public string RepresentativeLicense { get { return _representativeLicense; } set { _representativeLicense = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRepresentativeLicense() => !_representativeLicense.Clean;
        private Value<bool?> _sourcesDeemedReliableIndicator;
        public bool? SourcesDeemedReliableIndicator { get { return _sourcesDeemedReliableIndicator; } set { _sourcesDeemedReliableIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSourcesDeemedReliableIndicator() => !_sourcesDeemedReliableIndicator.Clean;
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeState() => !_state.Clean;
        private Value<decimal?> _subtotalOfAllDeductions;
        public decimal? SubtotalOfAllDeductions { get { return _subtotalOfAllDeductions; } set { _subtotalOfAllDeductions = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSubtotalOfAllDeductions() => !_subtotalOfAllDeductions.Clean;
        private Value<decimal?> _totalBrokerCompensationAmount;
        public decimal? TotalBrokerCompensationAmount { get { return _totalBrokerCompensationAmount; } set { _totalBrokerCompensationAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalBrokerCompensationAmount() => !_totalBrokerCompensationAmount.Clean;
        private Value<decimal?> _totalClosingCostWithDiscount;
        public decimal? TotalClosingCostWithDiscount { get { return _totalClosingCostWithDiscount; } set { _totalClosingCostWithDiscount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalClosingCostWithDiscount() => !_totalClosingCostWithDiscount.Clean;
        private Value<decimal?> _totalCostsExpenses;
        public decimal? TotalCostsExpenses { get { return _totalCostsExpenses; } set { _totalCostsExpenses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalCostsExpenses() => !_totalCostsExpenses.Clean;
        private Value<decimal?> _totalMaximumCostsExpenses;
        public decimal? TotalMaximumCostsExpenses { get { return _totalMaximumCostsExpenses; } set { _totalMaximumCostsExpenses = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalMaximumCostsExpenses() => !_totalMaximumCostsExpenses.Clean;
        private Value<decimal?> _totalOfInitialFees;
        public decimal? TotalOfInitialFees { get { return _totalOfInitialFees; } set { _totalOfInitialFees = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalOfInitialFees() => !_totalOfInitialFees.Clean;
        private Value<decimal?> _totalPrepaidClosingCost;
        public decimal? TotalPrepaidClosingCost { get { return _totalPrepaidClosingCost; } set { _totalPrepaidClosingCost = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPrepaidClosingCost() => !_totalPrepaidClosingCost.Clean;
        private Value<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get { return _totalSettlementCharges; } set { _totalSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalSettlementCharges() => !_totalSettlementCharges.Clean;
        private Value<decimal?> _totalTaxAndInsurance;
        public decimal? TotalTaxAndInsurance { get { return _totalTaxAndInsurance; } set { _totalTaxAndInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalTaxAndInsurance() => !_totalTaxAndInsurance.Clean;
        private Value<decimal?> _yearlyFloodInsurance;
        public decimal? YearlyFloodInsurance { get { return _yearlyFloodInsurance; } set { _yearlyFloodInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyFloodInsurance() => !_yearlyFloodInsurance.Clean;
        private Value<decimal?> _yearlyInsurance;
        public decimal? YearlyInsurance { get { return _yearlyInsurance; } set { _yearlyInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyInsurance() => !_yearlyInsurance.Clean;
        private Value<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyMortgageInsurance() => !_yearlyMortgageInsurance.Clean;
        private Value<decimal?> _yearlyOtherInsurance;
        public decimal? YearlyOtherInsurance { get { return _yearlyOtherInsurance; } set { _yearlyOtherInsurance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyOtherInsurance() => !_yearlyOtherInsurance.Clean;
        private Value<string> _yearlyOtherInsuranceDescription;
        public string YearlyOtherInsuranceDescription { get { return _yearlyOtherInsuranceDescription; } set { _yearlyOtherInsuranceDescription = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyOtherInsuranceDescription() => !_yearlyOtherInsuranceDescription.Clean;
        private Value<decimal?> _yearlyTax;
        public decimal? YearlyTax { get { return _yearlyTax; } set { _yearlyTax = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeYearlyTax() => !_yearlyTax.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _address.Clean
                    && _agregateAdjustment.Clean
                    && _brokerCommission.Clean
                    && _brokerLicense.Clean
                    && _brokerName.Clean
                    && _brokerRepresentative.Clean
                    && _city.Clean
                    && _compensationFromLenderAmount.Clean
                    && _compensationFromLenderPercentage.Clean
                    && _compensationFromLenderTotalAmount.Clean
                    && _creditLifeOrDisabilityPremium.Clean
                    && _creditToBorrowerAmount.Clean
                    && _estimatedCashAtClosing.Clean
                    && _estimatedCashToBorrower.Clean
                    && _estimatedDueDate.Clean
                    && _finalBalloonPayment.Clean
                    && _firstChangePayment.Clean
                    && _firstChangePercent.Clean
                    && _fundingAmount.Clean
                    && _gfeFees.Clean
                    && _gfeLiens.Clean
                    && _gfePayments.Clean
                    && _gfePayoffs.Clean
                    && _gfeProvidedByBrokerIndicator.Clean
                    && _hasAdditionalCompensationIndicator.Clean
                    && _hasLateChargesIndicator.Clean
                    && _hasPrepaymentPenaltyIndicator.Clean
                    && _id.Clean
                    && _initialFixedOrArmType.Clean
                    && _lenderOriginationFee.Clean
                    && _loanFromBrokerControledFundsType.Clean
                    && _lockField.Clean
                    && _maxLifePayment.Clean
                    && _maxPaymentAfterMonth.Clean
                    && _monthlyPaymentAndEscrow.Clean
                    && _mortgageBrokerComissionFee.Clean
                    && _mortgageBrokerComissionFeePaidToName.Clean
                    && _natureLien1Description.Clean
                    && _natureLien1PayoffDescription.Clean
                    && _natureLien2Description.Clean
                    && _natureLien2PayoffDescription.Clean
                    && _natureLien3Description.Clean
                    && _natureLien3PayoffDescription.Clean
                    && _paymentOfPrincipleIndicator.Clean
                    && _paymentOfPrincipleType.Clean
                    && _penaltyNotToExceedMonths.Clean
                    && _pocPaid1.Clean
                    && _pocPaid2.Clean
                    && _pocPaid3.Clean
                    && _postalCode.Clean
                    && _prepaymentOtherDescription.Clean
                    && _prepaymentOtherTypeIndicator.Clean
                    && _prepaymentPenaltyAmount.Clean
                    && _prepaymentPenaltyIndicator.Clean
                    && _prepaymentPenaltyPeriod.Clean
                    && _principalAmount.Clean
                    && _purchasePayOff.Clean
                    && _re882AdditionalCompensation.Clean
                    && _receivedFromLenderAmount.Clean
                    && _representativeLicense.Clean
                    && _sourcesDeemedReliableIndicator.Clean
                    && _state.Clean
                    && _subtotalOfAllDeductions.Clean
                    && _totalBrokerCompensationAmount.Clean
                    && _totalClosingCostWithDiscount.Clean
                    && _totalCostsExpenses.Clean
                    && _totalMaximumCostsExpenses.Clean
                    && _totalOfInitialFees.Clean
                    && _totalPrepaidClosingCost.Clean
                    && _totalSettlementCharges.Clean
                    && _totalTaxAndInsurance.Clean
                    && _yearlyFloodInsurance.Clean
                    && _yearlyInsurance.Clean
                    && _yearlyMortgageInsurance.Clean
                    && _yearlyOtherInsurance.Clean
                    && _yearlyOtherInsuranceDescription.Clean
                    && _yearlyTax.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _address; v0.Clean = value; _address = v0;
                var v1 = _agregateAdjustment; v1.Clean = value; _agregateAdjustment = v1;
                var v2 = _brokerCommission; v2.Clean = value; _brokerCommission = v2;
                var v3 = _brokerLicense; v3.Clean = value; _brokerLicense = v3;
                var v4 = _brokerName; v4.Clean = value; _brokerName = v4;
                var v5 = _brokerRepresentative; v5.Clean = value; _brokerRepresentative = v5;
                var v6 = _city; v6.Clean = value; _city = v6;
                var v7 = _compensationFromLenderAmount; v7.Clean = value; _compensationFromLenderAmount = v7;
                var v8 = _compensationFromLenderPercentage; v8.Clean = value; _compensationFromLenderPercentage = v8;
                var v9 = _compensationFromLenderTotalAmount; v9.Clean = value; _compensationFromLenderTotalAmount = v9;
                var v10 = _creditLifeOrDisabilityPremium; v10.Clean = value; _creditLifeOrDisabilityPremium = v10;
                var v11 = _creditToBorrowerAmount; v11.Clean = value; _creditToBorrowerAmount = v11;
                var v12 = _estimatedCashAtClosing; v12.Clean = value; _estimatedCashAtClosing = v12;
                var v13 = _estimatedCashToBorrower; v13.Clean = value; _estimatedCashToBorrower = v13;
                var v14 = _estimatedDueDate; v14.Clean = value; _estimatedDueDate = v14;
                var v15 = _finalBalloonPayment; v15.Clean = value; _finalBalloonPayment = v15;
                var v16 = _firstChangePayment; v16.Clean = value; _firstChangePayment = v16;
                var v17 = _firstChangePercent; v17.Clean = value; _firstChangePercent = v17;
                var v18 = _fundingAmount; v18.Clean = value; _fundingAmount = v18;
                var v19 = _gfeFees; v19.Clean = value; _gfeFees = v19;
                var v20 = _gfeLiens; v20.Clean = value; _gfeLiens = v20;
                var v21 = _gfePayments; v21.Clean = value; _gfePayments = v21;
                var v22 = _gfePayoffs; v22.Clean = value; _gfePayoffs = v22;
                var v23 = _gfeProvidedByBrokerIndicator; v23.Clean = value; _gfeProvidedByBrokerIndicator = v23;
                var v24 = _hasAdditionalCompensationIndicator; v24.Clean = value; _hasAdditionalCompensationIndicator = v24;
                var v25 = _hasLateChargesIndicator; v25.Clean = value; _hasLateChargesIndicator = v25;
                var v26 = _hasPrepaymentPenaltyIndicator; v26.Clean = value; _hasPrepaymentPenaltyIndicator = v26;
                var v27 = _id; v27.Clean = value; _id = v27;
                var v28 = _initialFixedOrArmType; v28.Clean = value; _initialFixedOrArmType = v28;
                var v29 = _lenderOriginationFee; v29.Clean = value; _lenderOriginationFee = v29;
                var v30 = _loanFromBrokerControledFundsType; v30.Clean = value; _loanFromBrokerControledFundsType = v30;
                var v31 = _lockField; v31.Clean = value; _lockField = v31;
                var v32 = _maxLifePayment; v32.Clean = value; _maxLifePayment = v32;
                var v33 = _maxPaymentAfterMonth; v33.Clean = value; _maxPaymentAfterMonth = v33;
                var v34 = _monthlyPaymentAndEscrow; v34.Clean = value; _monthlyPaymentAndEscrow = v34;
                var v35 = _mortgageBrokerComissionFee; v35.Clean = value; _mortgageBrokerComissionFee = v35;
                var v36 = _mortgageBrokerComissionFeePaidToName; v36.Clean = value; _mortgageBrokerComissionFeePaidToName = v36;
                var v37 = _natureLien1Description; v37.Clean = value; _natureLien1Description = v37;
                var v38 = _natureLien1PayoffDescription; v38.Clean = value; _natureLien1PayoffDescription = v38;
                var v39 = _natureLien2Description; v39.Clean = value; _natureLien2Description = v39;
                var v40 = _natureLien2PayoffDescription; v40.Clean = value; _natureLien2PayoffDescription = v40;
                var v41 = _natureLien3Description; v41.Clean = value; _natureLien3Description = v41;
                var v42 = _natureLien3PayoffDescription; v42.Clean = value; _natureLien3PayoffDescription = v42;
                var v43 = _paymentOfPrincipleIndicator; v43.Clean = value; _paymentOfPrincipleIndicator = v43;
                var v44 = _paymentOfPrincipleType; v44.Clean = value; _paymentOfPrincipleType = v44;
                var v45 = _penaltyNotToExceedMonths; v45.Clean = value; _penaltyNotToExceedMonths = v45;
                var v46 = _pocPaid1; v46.Clean = value; _pocPaid1 = v46;
                var v47 = _pocPaid2; v47.Clean = value; _pocPaid2 = v47;
                var v48 = _pocPaid3; v48.Clean = value; _pocPaid3 = v48;
                var v49 = _postalCode; v49.Clean = value; _postalCode = v49;
                var v50 = _prepaymentOtherDescription; v50.Clean = value; _prepaymentOtherDescription = v50;
                var v51 = _prepaymentOtherTypeIndicator; v51.Clean = value; _prepaymentOtherTypeIndicator = v51;
                var v52 = _prepaymentPenaltyAmount; v52.Clean = value; _prepaymentPenaltyAmount = v52;
                var v53 = _prepaymentPenaltyIndicator; v53.Clean = value; _prepaymentPenaltyIndicator = v53;
                var v54 = _prepaymentPenaltyPeriod; v54.Clean = value; _prepaymentPenaltyPeriod = v54;
                var v55 = _principalAmount; v55.Clean = value; _principalAmount = v55;
                var v56 = _purchasePayOff; v56.Clean = value; _purchasePayOff = v56;
                var v57 = _re882AdditionalCompensation; v57.Clean = value; _re882AdditionalCompensation = v57;
                var v58 = _receivedFromLenderAmount; v58.Clean = value; _receivedFromLenderAmount = v58;
                var v59 = _representativeLicense; v59.Clean = value; _representativeLicense = v59;
                var v60 = _sourcesDeemedReliableIndicator; v60.Clean = value; _sourcesDeemedReliableIndicator = v60;
                var v61 = _state; v61.Clean = value; _state = v61;
                var v62 = _subtotalOfAllDeductions; v62.Clean = value; _subtotalOfAllDeductions = v62;
                var v63 = _totalBrokerCompensationAmount; v63.Clean = value; _totalBrokerCompensationAmount = v63;
                var v64 = _totalClosingCostWithDiscount; v64.Clean = value; _totalClosingCostWithDiscount = v64;
                var v65 = _totalCostsExpenses; v65.Clean = value; _totalCostsExpenses = v65;
                var v66 = _totalMaximumCostsExpenses; v66.Clean = value; _totalMaximumCostsExpenses = v66;
                var v67 = _totalOfInitialFees; v67.Clean = value; _totalOfInitialFees = v67;
                var v68 = _totalPrepaidClosingCost; v68.Clean = value; _totalPrepaidClosingCost = v68;
                var v69 = _totalSettlementCharges; v69.Clean = value; _totalSettlementCharges = v69;
                var v70 = _totalTaxAndInsurance; v70.Clean = value; _totalTaxAndInsurance = v70;
                var v71 = _yearlyFloodInsurance; v71.Clean = value; _yearlyFloodInsurance = v71;
                var v72 = _yearlyInsurance; v72.Clean = value; _yearlyInsurance = v72;
                var v73 = _yearlyMortgageInsurance; v73.Clean = value; _yearlyMortgageInsurance = v73;
                var v74 = _yearlyOtherInsurance; v74.Clean = value; _yearlyOtherInsurance = v74;
                var v75 = _yearlyOtherInsuranceDescription; v75.Clean = value; _yearlyOtherInsuranceDescription = v75;
                var v76 = _yearlyTax; v76.Clean = value; _yearlyTax = v76;
                _settingClean = 0;
            }
        }
    }
}