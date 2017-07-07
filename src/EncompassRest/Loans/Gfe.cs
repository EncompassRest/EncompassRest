using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe : IClean
    {
        private Value<string> _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Value<decimal?> _agregateAdjustment;
        public decimal? AgregateAdjustment { get { return _agregateAdjustment; } set { _agregateAdjustment = value; } }
        private Value<decimal?> _brokerCommission;
        public decimal? BrokerCommission { get { return _brokerCommission; } set { _brokerCommission = value; } }
        private Value<string> _brokerLicense;
        public string BrokerLicense { get { return _brokerLicense; } set { _brokerLicense = value; } }
        private Value<string> _brokerName;
        public string BrokerName { get { return _brokerName; } set { _brokerName = value; } }
        private Value<string> _brokerRepresentative;
        public string BrokerRepresentative { get { return _brokerRepresentative; } set { _brokerRepresentative = value; } }
        private Value<string> _city;
        public string City { get { return _city; } set { _city = value; } }
        private Value<decimal?> _compensationFromLenderAmount;
        public decimal? CompensationFromLenderAmount { get { return _compensationFromLenderAmount; } set { _compensationFromLenderAmount = value; } }
        private Value<decimal?> _compensationFromLenderPercentage;
        public decimal? CompensationFromLenderPercentage { get { return _compensationFromLenderPercentage; } set { _compensationFromLenderPercentage = value; } }
        private Value<decimal?> _compensationFromLenderTotalAmount;
        public decimal? CompensationFromLenderTotalAmount { get { return _compensationFromLenderTotalAmount; } set { _compensationFromLenderTotalAmount = value; } }
        private Value<decimal?> _creditLifeOrDisabilityPremium;
        public decimal? CreditLifeOrDisabilityPremium { get { return _creditLifeOrDisabilityPremium; } set { _creditLifeOrDisabilityPremium = value; } }
        private Value<decimal?> _creditToBorrowerAmount;
        public decimal? CreditToBorrowerAmount { get { return _creditToBorrowerAmount; } set { _creditToBorrowerAmount = value; } }
        private Value<decimal?> _estimatedCashAtClosing;
        public decimal? EstimatedCashAtClosing { get { return _estimatedCashAtClosing; } set { _estimatedCashAtClosing = value; } }
        private Value<decimal?> _estimatedCashToBorrower;
        public decimal? EstimatedCashToBorrower { get { return _estimatedCashToBorrower; } set { _estimatedCashToBorrower = value; } }
        private Value<DateTime?> _estimatedDueDate;
        public DateTime? EstimatedDueDate { get { return _estimatedDueDate; } set { _estimatedDueDate = value; } }
        private Value<decimal?> _finalBalloonPayment;
        public decimal? FinalBalloonPayment { get { return _finalBalloonPayment; } set { _finalBalloonPayment = value; } }
        private Value<decimal?> _firstChangePayment;
        public decimal? FirstChangePayment { get { return _firstChangePayment; } set { _firstChangePayment = value; } }
        private Value<decimal?> _firstChangePercent;
        public decimal? FirstChangePercent { get { return _firstChangePercent; } set { _firstChangePercent = value; } }
        private Value<decimal?> _fundingAmount;
        public decimal? FundingAmount { get { return _fundingAmount; } set { _fundingAmount = value; } }
        private Value<List<GfeFee>> _gfeFees;
        public List<GfeFee> GfeFees { get { return _gfeFees; } set { _gfeFees = value; } }
        private Value<List<GfeLien>> _gfeLiens;
        public List<GfeLien> GfeLiens { get { return _gfeLiens; } set { _gfeLiens = value; } }
        private Value<List<GfePayment>> _gfePayments;
        public List<GfePayment> GfePayments { get { return _gfePayments; } set { _gfePayments = value; } }
        private Value<List<GfePayoff>> _gfePayoffs;
        public List<GfePayoff> GfePayoffs { get { return _gfePayoffs; } set { _gfePayoffs = value; } }
        private Value<bool?> _gfeProvidedByBrokerIndicator;
        public bool? GfeProvidedByBrokerIndicator { get { return _gfeProvidedByBrokerIndicator; } set { _gfeProvidedByBrokerIndicator = value; } }
        private Value<bool?> _hasAdditionalCompensationIndicator;
        public bool? HasAdditionalCompensationIndicator { get { return _hasAdditionalCompensationIndicator; } set { _hasAdditionalCompensationIndicator = value; } }
        private Value<bool?> _hasLateChargesIndicator;
        public bool? HasLateChargesIndicator { get { return _hasLateChargesIndicator; } set { _hasLateChargesIndicator = value; } }
        private Value<bool?> _hasPrepaymentPenaltyIndicator;
        public bool? HasPrepaymentPenaltyIndicator { get { return _hasPrepaymentPenaltyIndicator; } set { _hasPrepaymentPenaltyIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _initialFixedOrArmType;
        public string InitialFixedOrArmType { get { return _initialFixedOrArmType; } set { _initialFixedOrArmType = value; } }
        private Value<decimal?> _lenderOriginationFee;
        public decimal? LenderOriginationFee { get { return _lenderOriginationFee; } set { _lenderOriginationFee = value; } }
        private Value<string> _loanFromBrokerControledFundsType;
        public string LoanFromBrokerControledFundsType { get { return _loanFromBrokerControledFundsType; } set { _loanFromBrokerControledFundsType = value; } }
        private Value<bool?> _lockField;
        public bool? LockField { get { return _lockField; } set { _lockField = value; } }
        private Value<decimal?> _maxLifePayment;
        public decimal? MaxLifePayment { get { return _maxLifePayment; } set { _maxLifePayment = value; } }
        private Value<int?> _maxPaymentAfterMonth;
        public int? MaxPaymentAfterMonth { get { return _maxPaymentAfterMonth; } set { _maxPaymentAfterMonth = value; } }
        private Value<decimal?> _monthlyPaymentAndEscrow;
        public decimal? MonthlyPaymentAndEscrow { get { return _monthlyPaymentAndEscrow; } set { _monthlyPaymentAndEscrow = value; } }
        private Value<decimal?> _mortgageBrokerComissionFee;
        public decimal? MortgageBrokerComissionFee { get { return _mortgageBrokerComissionFee; } set { _mortgageBrokerComissionFee = value; } }
        private Value<string> _mortgageBrokerComissionFeePaidToName;
        public string MortgageBrokerComissionFeePaidToName { get { return _mortgageBrokerComissionFeePaidToName; } set { _mortgageBrokerComissionFeePaidToName = value; } }
        private Value<string> _natureLien1Description;
        public string NatureLien1Description { get { return _natureLien1Description; } set { _natureLien1Description = value; } }
        private Value<string> _natureLien1PayoffDescription;
        public string NatureLien1PayoffDescription { get { return _natureLien1PayoffDescription; } set { _natureLien1PayoffDescription = value; } }
        private Value<string> _natureLien2Description;
        public string NatureLien2Description { get { return _natureLien2Description; } set { _natureLien2Description = value; } }
        private Value<string> _natureLien2PayoffDescription;
        public string NatureLien2PayoffDescription { get { return _natureLien2PayoffDescription; } set { _natureLien2PayoffDescription = value; } }
        private Value<string> _natureLien3Description;
        public string NatureLien3Description { get { return _natureLien3Description; } set { _natureLien3Description = value; } }
        private Value<string> _natureLien3PayoffDescription;
        public string NatureLien3PayoffDescription { get { return _natureLien3PayoffDescription; } set { _natureLien3PayoffDescription = value; } }
        private Value<bool?> _paymentOfPrincipleIndicator;
        public bool? PaymentOfPrincipleIndicator { get { return _paymentOfPrincipleIndicator; } set { _paymentOfPrincipleIndicator = value; } }
        private Value<string> _paymentOfPrincipleType;
        public string PaymentOfPrincipleType { get { return _paymentOfPrincipleType; } set { _paymentOfPrincipleType = value; } }
        private Value<int?> _penaltyNotToExceedMonths;
        public int? PenaltyNotToExceedMonths { get { return _penaltyNotToExceedMonths; } set { _penaltyNotToExceedMonths = value; } }
        private Value<string> _pocPaid1;
        public string PocPaid1 { get { return _pocPaid1; } set { _pocPaid1 = value; } }
        private Value<string> _pocPaid2;
        public string PocPaid2 { get { return _pocPaid2; } set { _pocPaid2 = value; } }
        private Value<string> _pocPaid3;
        public string PocPaid3 { get { return _pocPaid3; } set { _pocPaid3 = value; } }
        private Value<string> _postalCode;
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        private Value<string> _prepaymentOtherDescription;
        public string PrepaymentOtherDescription { get { return _prepaymentOtherDescription; } set { _prepaymentOtherDescription = value; } }
        private Value<bool?> _prepaymentOtherTypeIndicator;
        public bool? PrepaymentOtherTypeIndicator { get { return _prepaymentOtherTypeIndicator; } set { _prepaymentOtherTypeIndicator = value; } }
        private Value<decimal?> _prepaymentPenaltyAmount;
        public decimal? PrepaymentPenaltyAmount { get { return _prepaymentPenaltyAmount; } set { _prepaymentPenaltyAmount = value; } }
        private Value<bool?> _prepaymentPenaltyIndicator;
        public bool? PrepaymentPenaltyIndicator { get { return _prepaymentPenaltyIndicator; } set { _prepaymentPenaltyIndicator = value; } }
        private Value<int?> _prepaymentPenaltyPeriod;
        public int? PrepaymentPenaltyPeriod { get { return _prepaymentPenaltyPeriod; } set { _prepaymentPenaltyPeriod = value; } }
        private Value<decimal?> _principalAmount;
        public decimal? PrincipalAmount { get { return _principalAmount; } set { _principalAmount = value; } }
        private Value<decimal?> _purchasePayOff;
        public decimal? PurchasePayOff { get { return _purchasePayOff; } set { _purchasePayOff = value; } }
        private Value<decimal?> _re882AdditionalCompensation;
        public decimal? Re882AdditionalCompensation { get { return _re882AdditionalCompensation; } set { _re882AdditionalCompensation = value; } }
        private Value<decimal?> _receivedFromLenderAmount;
        public decimal? ReceivedFromLenderAmount { get { return _receivedFromLenderAmount; } set { _receivedFromLenderAmount = value; } }
        private Value<string> _representativeLicense;
        public string RepresentativeLicense { get { return _representativeLicense; } set { _representativeLicense = value; } }
        private Value<bool?> _sourcesDeemedReliableIndicator;
        public bool? SourcesDeemedReliableIndicator { get { return _sourcesDeemedReliableIndicator; } set { _sourcesDeemedReliableIndicator = value; } }
        private Value<string> _state;
        public string State { get { return _state; } set { _state = value; } }
        private Value<decimal?> _subtotalOfAllDeductions;
        public decimal? SubtotalOfAllDeductions { get { return _subtotalOfAllDeductions; } set { _subtotalOfAllDeductions = value; } }
        private Value<decimal?> _totalBrokerCompensationAmount;
        public decimal? TotalBrokerCompensationAmount { get { return _totalBrokerCompensationAmount; } set { _totalBrokerCompensationAmount = value; } }
        private Value<decimal?> _totalClosingCostWithDiscount;
        public decimal? TotalClosingCostWithDiscount { get { return _totalClosingCostWithDiscount; } set { _totalClosingCostWithDiscount = value; } }
        private Value<decimal?> _totalCostsExpenses;
        public decimal? TotalCostsExpenses { get { return _totalCostsExpenses; } set { _totalCostsExpenses = value; } }
        private Value<decimal?> _totalMaximumCostsExpenses;
        public decimal? TotalMaximumCostsExpenses { get { return _totalMaximumCostsExpenses; } set { _totalMaximumCostsExpenses = value; } }
        private Value<decimal?> _totalOfInitialFees;
        public decimal? TotalOfInitialFees { get { return _totalOfInitialFees; } set { _totalOfInitialFees = value; } }
        private Value<decimal?> _totalPrepaidClosingCost;
        public decimal? TotalPrepaidClosingCost { get { return _totalPrepaidClosingCost; } set { _totalPrepaidClosingCost = value; } }
        private Value<decimal?> _totalSettlementCharges;
        public decimal? TotalSettlementCharges { get { return _totalSettlementCharges; } set { _totalSettlementCharges = value; } }
        private Value<decimal?> _totalTaxAndInsurance;
        public decimal? TotalTaxAndInsurance { get { return _totalTaxAndInsurance; } set { _totalTaxAndInsurance = value; } }
        private Value<decimal?> _yearlyFloodInsurance;
        public decimal? YearlyFloodInsurance { get { return _yearlyFloodInsurance; } set { _yearlyFloodInsurance = value; } }
        private Value<decimal?> _yearlyInsurance;
        public decimal? YearlyInsurance { get { return _yearlyInsurance; } set { _yearlyInsurance = value; } }
        private Value<decimal?> _yearlyMortgageInsurance;
        public decimal? YearlyMortgageInsurance { get { return _yearlyMortgageInsurance; } set { _yearlyMortgageInsurance = value; } }
        private Value<decimal?> _yearlyOtherInsurance;
        public decimal? YearlyOtherInsurance { get { return _yearlyOtherInsurance; } set { _yearlyOtherInsurance = value; } }
        private Value<string> _yearlyOtherInsuranceDescription;
        public string YearlyOtherInsuranceDescription { get { return _yearlyOtherInsuranceDescription; } set { _yearlyOtherInsuranceDescription = value; } }
        private Value<decimal?> _yearlyTax;
        public decimal? YearlyTax { get { return _yearlyTax; } set { _yearlyTax = value; } }
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
                var address = _address; address.Clean = value; _address = address;
                var agregateAdjustment = _agregateAdjustment; agregateAdjustment.Clean = value; _agregateAdjustment = agregateAdjustment;
                var brokerCommission = _brokerCommission; brokerCommission.Clean = value; _brokerCommission = brokerCommission;
                var brokerLicense = _brokerLicense; brokerLicense.Clean = value; _brokerLicense = brokerLicense;
                var brokerName = _brokerName; brokerName.Clean = value; _brokerName = brokerName;
                var brokerRepresentative = _brokerRepresentative; brokerRepresentative.Clean = value; _brokerRepresentative = brokerRepresentative;
                var city = _city; city.Clean = value; _city = city;
                var compensationFromLenderAmount = _compensationFromLenderAmount; compensationFromLenderAmount.Clean = value; _compensationFromLenderAmount = compensationFromLenderAmount;
                var compensationFromLenderPercentage = _compensationFromLenderPercentage; compensationFromLenderPercentage.Clean = value; _compensationFromLenderPercentage = compensationFromLenderPercentage;
                var compensationFromLenderTotalAmount = _compensationFromLenderTotalAmount; compensationFromLenderTotalAmount.Clean = value; _compensationFromLenderTotalAmount = compensationFromLenderTotalAmount;
                var creditLifeOrDisabilityPremium = _creditLifeOrDisabilityPremium; creditLifeOrDisabilityPremium.Clean = value; _creditLifeOrDisabilityPremium = creditLifeOrDisabilityPremium;
                var creditToBorrowerAmount = _creditToBorrowerAmount; creditToBorrowerAmount.Clean = value; _creditToBorrowerAmount = creditToBorrowerAmount;
                var estimatedCashAtClosing = _estimatedCashAtClosing; estimatedCashAtClosing.Clean = value; _estimatedCashAtClosing = estimatedCashAtClosing;
                var estimatedCashToBorrower = _estimatedCashToBorrower; estimatedCashToBorrower.Clean = value; _estimatedCashToBorrower = estimatedCashToBorrower;
                var estimatedDueDate = _estimatedDueDate; estimatedDueDate.Clean = value; _estimatedDueDate = estimatedDueDate;
                var finalBalloonPayment = _finalBalloonPayment; finalBalloonPayment.Clean = value; _finalBalloonPayment = finalBalloonPayment;
                var firstChangePayment = _firstChangePayment; firstChangePayment.Clean = value; _firstChangePayment = firstChangePayment;
                var firstChangePercent = _firstChangePercent; firstChangePercent.Clean = value; _firstChangePercent = firstChangePercent;
                var fundingAmount = _fundingAmount; fundingAmount.Clean = value; _fundingAmount = fundingAmount;
                var gfeFees = _gfeFees; gfeFees.Clean = value; _gfeFees = gfeFees;
                var gfeLiens = _gfeLiens; gfeLiens.Clean = value; _gfeLiens = gfeLiens;
                var gfePayments = _gfePayments; gfePayments.Clean = value; _gfePayments = gfePayments;
                var gfePayoffs = _gfePayoffs; gfePayoffs.Clean = value; _gfePayoffs = gfePayoffs;
                var gfeProvidedByBrokerIndicator = _gfeProvidedByBrokerIndicator; gfeProvidedByBrokerIndicator.Clean = value; _gfeProvidedByBrokerIndicator = gfeProvidedByBrokerIndicator;
                var hasAdditionalCompensationIndicator = _hasAdditionalCompensationIndicator; hasAdditionalCompensationIndicator.Clean = value; _hasAdditionalCompensationIndicator = hasAdditionalCompensationIndicator;
                var hasLateChargesIndicator = _hasLateChargesIndicator; hasLateChargesIndicator.Clean = value; _hasLateChargesIndicator = hasLateChargesIndicator;
                var hasPrepaymentPenaltyIndicator = _hasPrepaymentPenaltyIndicator; hasPrepaymentPenaltyIndicator.Clean = value; _hasPrepaymentPenaltyIndicator = hasPrepaymentPenaltyIndicator;
                var id = _id; id.Clean = value; _id = id;
                var initialFixedOrArmType = _initialFixedOrArmType; initialFixedOrArmType.Clean = value; _initialFixedOrArmType = initialFixedOrArmType;
                var lenderOriginationFee = _lenderOriginationFee; lenderOriginationFee.Clean = value; _lenderOriginationFee = lenderOriginationFee;
                var loanFromBrokerControledFundsType = _loanFromBrokerControledFundsType; loanFromBrokerControledFundsType.Clean = value; _loanFromBrokerControledFundsType = loanFromBrokerControledFundsType;
                var lockField = _lockField; lockField.Clean = value; _lockField = lockField;
                var maxLifePayment = _maxLifePayment; maxLifePayment.Clean = value; _maxLifePayment = maxLifePayment;
                var maxPaymentAfterMonth = _maxPaymentAfterMonth; maxPaymentAfterMonth.Clean = value; _maxPaymentAfterMonth = maxPaymentAfterMonth;
                var monthlyPaymentAndEscrow = _monthlyPaymentAndEscrow; monthlyPaymentAndEscrow.Clean = value; _monthlyPaymentAndEscrow = monthlyPaymentAndEscrow;
                var mortgageBrokerComissionFee = _mortgageBrokerComissionFee; mortgageBrokerComissionFee.Clean = value; _mortgageBrokerComissionFee = mortgageBrokerComissionFee;
                var mortgageBrokerComissionFeePaidToName = _mortgageBrokerComissionFeePaidToName; mortgageBrokerComissionFeePaidToName.Clean = value; _mortgageBrokerComissionFeePaidToName = mortgageBrokerComissionFeePaidToName;
                var natureLien1Description = _natureLien1Description; natureLien1Description.Clean = value; _natureLien1Description = natureLien1Description;
                var natureLien1PayoffDescription = _natureLien1PayoffDescription; natureLien1PayoffDescription.Clean = value; _natureLien1PayoffDescription = natureLien1PayoffDescription;
                var natureLien2Description = _natureLien2Description; natureLien2Description.Clean = value; _natureLien2Description = natureLien2Description;
                var natureLien2PayoffDescription = _natureLien2PayoffDescription; natureLien2PayoffDescription.Clean = value; _natureLien2PayoffDescription = natureLien2PayoffDescription;
                var natureLien3Description = _natureLien3Description; natureLien3Description.Clean = value; _natureLien3Description = natureLien3Description;
                var natureLien3PayoffDescription = _natureLien3PayoffDescription; natureLien3PayoffDescription.Clean = value; _natureLien3PayoffDescription = natureLien3PayoffDescription;
                var paymentOfPrincipleIndicator = _paymentOfPrincipleIndicator; paymentOfPrincipleIndicator.Clean = value; _paymentOfPrincipleIndicator = paymentOfPrincipleIndicator;
                var paymentOfPrincipleType = _paymentOfPrincipleType; paymentOfPrincipleType.Clean = value; _paymentOfPrincipleType = paymentOfPrincipleType;
                var penaltyNotToExceedMonths = _penaltyNotToExceedMonths; penaltyNotToExceedMonths.Clean = value; _penaltyNotToExceedMonths = penaltyNotToExceedMonths;
                var pocPaid1 = _pocPaid1; pocPaid1.Clean = value; _pocPaid1 = pocPaid1;
                var pocPaid2 = _pocPaid2; pocPaid2.Clean = value; _pocPaid2 = pocPaid2;
                var pocPaid3 = _pocPaid3; pocPaid3.Clean = value; _pocPaid3 = pocPaid3;
                var postalCode = _postalCode; postalCode.Clean = value; _postalCode = postalCode;
                var prepaymentOtherDescription = _prepaymentOtherDescription; prepaymentOtherDescription.Clean = value; _prepaymentOtherDescription = prepaymentOtherDescription;
                var prepaymentOtherTypeIndicator = _prepaymentOtherTypeIndicator; prepaymentOtherTypeIndicator.Clean = value; _prepaymentOtherTypeIndicator = prepaymentOtherTypeIndicator;
                var prepaymentPenaltyAmount = _prepaymentPenaltyAmount; prepaymentPenaltyAmount.Clean = value; _prepaymentPenaltyAmount = prepaymentPenaltyAmount;
                var prepaymentPenaltyIndicator = _prepaymentPenaltyIndicator; prepaymentPenaltyIndicator.Clean = value; _prepaymentPenaltyIndicator = prepaymentPenaltyIndicator;
                var prepaymentPenaltyPeriod = _prepaymentPenaltyPeriod; prepaymentPenaltyPeriod.Clean = value; _prepaymentPenaltyPeriod = prepaymentPenaltyPeriod;
                var principalAmount = _principalAmount; principalAmount.Clean = value; _principalAmount = principalAmount;
                var purchasePayOff = _purchasePayOff; purchasePayOff.Clean = value; _purchasePayOff = purchasePayOff;
                var re882AdditionalCompensation = _re882AdditionalCompensation; re882AdditionalCompensation.Clean = value; _re882AdditionalCompensation = re882AdditionalCompensation;
                var receivedFromLenderAmount = _receivedFromLenderAmount; receivedFromLenderAmount.Clean = value; _receivedFromLenderAmount = receivedFromLenderAmount;
                var representativeLicense = _representativeLicense; representativeLicense.Clean = value; _representativeLicense = representativeLicense;
                var sourcesDeemedReliableIndicator = _sourcesDeemedReliableIndicator; sourcesDeemedReliableIndicator.Clean = value; _sourcesDeemedReliableIndicator = sourcesDeemedReliableIndicator;
                var state = _state; state.Clean = value; _state = state;
                var subtotalOfAllDeductions = _subtotalOfAllDeductions; subtotalOfAllDeductions.Clean = value; _subtotalOfAllDeductions = subtotalOfAllDeductions;
                var totalBrokerCompensationAmount = _totalBrokerCompensationAmount; totalBrokerCompensationAmount.Clean = value; _totalBrokerCompensationAmount = totalBrokerCompensationAmount;
                var totalClosingCostWithDiscount = _totalClosingCostWithDiscount; totalClosingCostWithDiscount.Clean = value; _totalClosingCostWithDiscount = totalClosingCostWithDiscount;
                var totalCostsExpenses = _totalCostsExpenses; totalCostsExpenses.Clean = value; _totalCostsExpenses = totalCostsExpenses;
                var totalMaximumCostsExpenses = _totalMaximumCostsExpenses; totalMaximumCostsExpenses.Clean = value; _totalMaximumCostsExpenses = totalMaximumCostsExpenses;
                var totalOfInitialFees = _totalOfInitialFees; totalOfInitialFees.Clean = value; _totalOfInitialFees = totalOfInitialFees;
                var totalPrepaidClosingCost = _totalPrepaidClosingCost; totalPrepaidClosingCost.Clean = value; _totalPrepaidClosingCost = totalPrepaidClosingCost;
                var totalSettlementCharges = _totalSettlementCharges; totalSettlementCharges.Clean = value; _totalSettlementCharges = totalSettlementCharges;
                var totalTaxAndInsurance = _totalTaxAndInsurance; totalTaxAndInsurance.Clean = value; _totalTaxAndInsurance = totalTaxAndInsurance;
                var yearlyFloodInsurance = _yearlyFloodInsurance; yearlyFloodInsurance.Clean = value; _yearlyFloodInsurance = yearlyFloodInsurance;
                var yearlyInsurance = _yearlyInsurance; yearlyInsurance.Clean = value; _yearlyInsurance = yearlyInsurance;
                var yearlyMortgageInsurance = _yearlyMortgageInsurance; yearlyMortgageInsurance.Clean = value; _yearlyMortgageInsurance = yearlyMortgageInsurance;
                var yearlyOtherInsurance = _yearlyOtherInsurance; yearlyOtherInsurance.Clean = value; _yearlyOtherInsurance = yearlyOtherInsurance;
                var yearlyOtherInsuranceDescription = _yearlyOtherInsuranceDescription; yearlyOtherInsuranceDescription.Clean = value; _yearlyOtherInsuranceDescription = yearlyOtherInsuranceDescription;
                var yearlyTax = _yearlyTax; yearlyTax.Clean = value; _yearlyTax = yearlyTax;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe()
        {
            Clean = true;
        }
    }
}