using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe
    /// </summary>
    public sealed partial class Gfe : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        private DirtyValue<decimal?> _agregateAdjustment;
        private DirtyValue<decimal?> _brokerCommission;
        private DirtyValue<string> _brokerLicense;
        private DirtyValue<string> _brokerName;
        private DirtyValue<string> _brokerRepresentative;
        private DirtyValue<string> _city;
        private DirtyValue<decimal?> _compensationFromLenderAmount;
        private DirtyValue<decimal?> _compensationFromLenderPercentage;
        private DirtyValue<decimal?> _compensationFromLenderTotalAmount;
        private DirtyValue<decimal?> _creditLifeOrDisabilityPremium;
        private DirtyValue<decimal?> _creditToBorrowerAmount;
        private DirtyValue<decimal?> _estimatedCashAtClosing;
        private DirtyValue<decimal?> _estimatedCashToBorrower;
        private DirtyValue<DateTime?> _estimatedDueDate;
        private DirtyValue<decimal?> _finalBalloonPayment;
        private DirtyValue<decimal?> _firstChangePayment;
        private DirtyValue<decimal?> _firstChangePercent;
        private DirtyValue<decimal?> _fundingAmount;
        private DirtyList<GfeFee> _gfeFees;
        private DirtyList<GfeLien> _gfeLiens;
        private DirtyList<GfePayment> _gfePayments;
        private DirtyList<GfePayoff> _gfePayoffs;
        private DirtyValue<bool?> _gfeProvidedByBrokerIndicator;
        private DirtyValue<bool?> _hasAdditionalCompensationIndicator;
        private DirtyValue<bool?> _hasLateChargesIndicator;
        private DirtyValue<bool?> _hasPrepaymentPenaltyIndicator;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<InitialFixedOrArmType>> _initialFixedOrArmType;
        private DirtyValue<decimal?> _lenderOriginationFee;
        private DirtyValue<StringEnumValue<LoanFromBrokerControledFundsType>> _loanFromBrokerControledFundsType;
        private DirtyValue<bool?> _lockField;
        private DirtyValue<decimal?> _maxLifePayment;
        private DirtyValue<int?> _maxPaymentAfterMonth;
        private DirtyValue<decimal?> _monthlyPaymentAndEscrow;
        private DirtyValue<decimal?> _mortgageBrokerComissionFee;
        private DirtyValue<string> _mortgageBrokerComissionFeePaidToName;
        private DirtyValue<string> _natureLien1Description;
        private DirtyValue<string> _natureLien1PayoffDescription;
        private DirtyValue<string> _natureLien2Description;
        private DirtyValue<string> _natureLien2PayoffDescription;
        private DirtyValue<string> _natureLien3Description;
        private DirtyValue<string> _natureLien3PayoffDescription;
        private DirtyValue<bool?> _paymentOfPrincipleIndicator;
        private DirtyValue<StringEnumValue<PaymentOfPrincipleType>> _paymentOfPrincipleType;
        private DirtyValue<int?> _penaltyNotToExceedMonths;
        private DirtyValue<string> _pocPaid1;
        private DirtyValue<string> _pocPaid2;
        private DirtyValue<string> _pocPaid3;
        private DirtyValue<string> _postalCode;
        private DirtyValue<string> _prepaymentOtherDescription;
        private DirtyValue<bool?> _prepaymentOtherTypeIndicator;
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        private DirtyValue<int?> _prepaymentPenaltyPeriod;
        private DirtyValue<decimal?> _principalAmount;
        private DirtyValue<decimal?> _purchasePayOff;
        private DirtyValue<decimal?> _re882AdditionalCompensation;
        private DirtyValue<decimal?> _receivedFromLenderAmount;
        private DirtyValue<string> _representativeLicense;
        private DirtyValue<bool?> _sourcesDeemedReliableIndicator;
        private DirtyValue<StringEnumValue<State>> _state;
        private DirtyValue<decimal?> _subtotalOfAllDeductions;
        private DirtyValue<decimal?> _totalBrokerCompensationAmount;
        private DirtyValue<decimal?> _totalClosingCostWithDiscount;
        private DirtyValue<decimal?> _totalCostsExpenses;
        private DirtyValue<decimal?> _totalMaximumCostsExpenses;
        private DirtyValue<decimal?> _totalOfInitialFees;
        private DirtyValue<decimal?> _totalPrepaidClosingCost;
        private DirtyValue<decimal?> _totalSettlementCharges;
        private DirtyValue<decimal?> _totalTaxAndInsurance;
        private DirtyValue<decimal?> _yearlyFloodInsurance;
        private DirtyValue<decimal?> _yearlyInsurance;
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        private DirtyValue<decimal?> _yearlyOtherInsurance;
        private DirtyValue<string> _yearlyOtherInsuranceDescription;
        private DirtyValue<decimal?> _yearlyTax;

        /// <summary>
        /// MLDS Broker Street Address [RE88395.X338]
        /// </summary>
        public string Address { get => _address; set => SetField(ref _address, value); }

        /// <summary>
        /// Fees Aggregate Adj [558]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? AgregateAdjustment { get => _agregateAdjustment; set => SetField(ref _agregateAdjustment, value); }

        /// <summary>
        /// MLDS RE882 Broker Commission/Origination Fee [RE882.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? BrokerCommission { get => _brokerCommission; set => SetField(ref _brokerCommission, value); }

        /// <summary>
        /// File Contacts Broker License # [RE88395.X182]
        /// </summary>
        public string BrokerLicense { get => _brokerLicense; set => SetField(ref _brokerLicense, value); }

        /// <summary>
        /// MLDS Broker Name [RE88395.X150]
        /// </summary>
        public string BrokerName { get => _brokerName; set => SetField(ref _brokerName, value); }

        /// <summary>
        /// MLDS Broker Rep [RE88395.X151]
        /// </summary>
        public string BrokerRepresentative { get => _brokerRepresentative; set => SetField(ref _brokerRepresentative, value); }

        /// <summary>
        /// MLDS Broker City [RE88395.X339]
        /// </summary>
        public string City { get => _city; set => SetField(ref _city, value); }

        /// <summary>
        /// MLDS Broker Comp Add From Lender $ [RE88395.X179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CompensationFromLenderAmount { get => _compensationFromLenderAmount; set => SetField(ref _compensationFromLenderAmount, value); }

        /// <summary>
        /// MLDS Broker Comp Add From Lender % [RE88395.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? CompensationFromLenderPercentage { get => _compensationFromLenderPercentage; set => SetField(ref _compensationFromLenderPercentage, value); }

        /// <summary>
        /// MLDS Broker Comp Add From Lender Amt [RE88395.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? CompensationFromLenderTotalAmount { get => _compensationFromLenderTotalAmount; set => SetField(ref _compensationFromLenderTotalAmount, value); }

        /// <summary>
        /// MLDS Credit Life/Disability Premium [RE88395.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CreditLifeOrDisabilityPremium { get => _creditLifeOrDisabilityPremium; set => SetField(ref _creditLifeOrDisabilityPremium, value); }

        /// <summary>
        /// MLDS RE882 Credit to Borrower Amount [RE882.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? CreditToBorrowerAmount { get => _creditToBorrowerAmount; set => SetField(ref _creditToBorrowerAmount, value); }

        /// <summary>
        /// MLDS Est Cash at Closing [RE88395.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EstimatedCashAtClosing { get => _estimatedCashAtClosing; set => SetField(ref _estimatedCashAtClosing, value); }

        /// <summary>
        /// MLDS RE882 Estimated Cash Payable to Borrower [RE882.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? EstimatedCashToBorrower { get => _estimatedCashToBorrower; set => SetField(ref _estimatedCashToBorrower, value); }

        /// <summary>
        /// MLDS Balloon Pymt Due Date [RE88395.X122]
        /// </summary>
        public DateTime? EstimatedDueDate { get => _estimatedDueDate; set => SetField(ref _estimatedDueDate, value); }

        /// <summary>
        /// MLDS Final Balloon Pymt Amt [RE88395.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FinalBalloonPayment { get => _finalBalloonPayment; set => SetField(ref _finalBalloonPayment, value); }

        /// <summary>
        /// MLDS S3 1st Monthly Pymt [RE88395.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FirstChangePayment { get => _firstChangePayment; set => SetField(ref _firstChangePayment, value); }

        /// <summary>
        /// MLDS S3 1st Change Percent [RE88395.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? FirstChangePercent { get => _firstChangePercent; set => SetField(ref _firstChangePercent, value); }

        /// <summary>
        /// Expenses Calc MIP/PMI MIP Funding Amt [1826]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? FundingAmount { get => _fundingAmount; set => SetField(ref _fundingAmount, value); }

        /// <summary>
        /// Gfe GfeFees
        /// </summary>
        public IList<GfeFee> GfeFees { get => GetField(ref _gfeFees); set => SetField(ref _gfeFees, value); }

        /// <summary>
        /// Gfe GfeLiens
        /// </summary>
        public IList<GfeLien> GfeLiens { get => GetField(ref _gfeLiens); set => SetField(ref _gfeLiens, value); }

        /// <summary>
        /// Gfe GfePayments
        /// </summary>
        public IList<GfePayment> GfePayments { get => GetField(ref _gfePayments); set => SetField(ref _gfePayments, value); }

        /// <summary>
        /// Gfe GfePayoffs
        /// </summary>
        public IList<GfePayoff> GfePayoffs { get => GetField(ref _gfePayoffs); set => SetField(ref _gfePayoffs, value); }

        /// <summary>
        /// Trans Details GFE Provided By Broker [1814]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"This Good Faith Estimate is being provided by broker...\"}")]
        public bool? GfeProvidedByBrokerIndicator { get => _gfeProvidedByBrokerIndicator; set => SetField(ref _gfeProvidedByBrokerIndicator, value); }

        /// <summary>
        /// MLDS RE882 Add?l Comp Will/May Be Received from Lender [RE882.X4]
        /// </summary>
        public bool? HasAdditionalCompensationIndicator { get => _hasAdditionalCompensationIndicator; set => SetField(ref _hasAdditionalCompensationIndicator, value); }

        /// <summary>
        /// Loan has late charges [RE882.X48]
        /// </summary>
        public bool? HasLateChargesIndicator { get => _hasLateChargesIndicator; set => SetField(ref _hasLateChargesIndicator, value); }

        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X322]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prepayment penalty\"}")]
        public bool? HasPrepaymentPenaltyIndicator { get => _hasPrepaymentPenaltyIndicator; set => SetField(ref _hasPrepaymentPenaltyIndicator, value); }

        /// <summary>
        /// Gfe Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// MLDS Loan Type Check Boxes [RE88395.X326]
        /// </summary>
        public StringEnumValue<InitialFixedOrArmType> InitialFixedOrArmType { get => _initialFixedOrArmType; set => SetField(ref _initialFixedOrArmType, value); }

        /// <summary>
        /// MLDS RE882 Lender Origination Fee/Discounts [RE882.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LenderOriginationFee { get => _lenderOriginationFee; set => SetField(ref _lenderOriginationFee, value); }

        /// <summary>
        /// MLDS Loan May/May not be from Broker funds [RE88395.X149]
        /// </summary>
        public StringEnumValue<LoanFromBrokerControledFundsType> LoanFromBrokerControledFundsType { get => _loanFromBrokerControledFundsType; set => SetField(ref _loanFromBrokerControledFundsType, value); }

        /// <summary>
        /// Expenses Calc MIP/PMI Lock [1765]
        /// </summary>
        public bool? LockField { get => _lockField; set => SetField(ref _lockField, value); }

        /// <summary>
        /// MLDS S3 Max Life Monthly Pymt [RE88395.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MaxLifePayment { get => _maxLifePayment; set => SetField(ref _maxLifePayment, value); }

        /// <summary>
        /// MLDS S3 Months to Max Life Monthly Pymt [RE88395.X327]
        /// </summary>
        public int? MaxPaymentAfterMonth { get => _maxPaymentAfterMonth; set => SetField(ref _maxPaymentAfterMonth, value); }

        /// <summary>
        /// MLDS Monthly Pymt With Escrow [RE88395.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MonthlyPaymentAndEscrow { get => _monthlyPaymentAndEscrow; set => SetField(ref _monthlyPaymentAndEscrow, value); }

        /// <summary>
        /// MLDS Broker Commission Fee Amt [1119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? MortgageBrokerComissionFee { get => _mortgageBrokerComissionFee; set => SetField(ref _mortgageBrokerComissionFee, value); }

        /// <summary>
        /// MLDS Broker Commission Fee Descr [RE88395.X190]
        /// </summary>
        public string MortgageBrokerComissionFeePaidToName { get => _mortgageBrokerComissionFeePaidToName; set => SetField(ref _mortgageBrokerComissionFeePaidToName, value); }

        /// <summary>
        /// MLDS RE882 Nature of Lien 1 Descr Remain on Property [RE882.X52]
        /// </summary>
        public string NatureLien1Description { get => _natureLien1Description; set => SetField(ref _natureLien1Description, value); }

        /// <summary>
        /// MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay [RE882.X49]
        /// </summary>
        public string NatureLien1PayoffDescription { get => _natureLien1PayoffDescription; set => SetField(ref _natureLien1PayoffDescription, value); }

        /// <summary>
        /// MLDS RE882 Nature of Lien 2 Descr Remain on Property [RE882.X53]
        /// </summary>
        public string NatureLien2Description { get => _natureLien2Description; set => SetField(ref _natureLien2Description, value); }

        /// <summary>
        /// MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay [RE882.X50]
        /// </summary>
        public string NatureLien2PayoffDescription { get => _natureLien2PayoffDescription; set => SetField(ref _natureLien2PayoffDescription, value); }

        /// <summary>
        /// MLDS RE882 Nature of Lien 3 Descr Remain on Property [RE882.X54]
        /// </summary>
        public string NatureLien3Description { get => _natureLien3Description; set => SetField(ref _natureLien3Description, value); }

        /// <summary>
        /// MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay [RE882.X51]
        /// </summary>
        public string NatureLien3PayoffDescription { get => _natureLien3PayoffDescription; set => SetField(ref _natureLien3PayoffDescription, value); }

        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X191]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Any payment of principle in excess of 20% of the\"}")]
        public bool? PaymentOfPrincipleIndicator { get => _paymentOfPrincipleIndicator; set => SetField(ref _paymentOfPrincipleIndicator, value); }

        /// <summary>
        /// MLDS Prepymt Penalty Orig/Unpaid Bal [RE88395.X126]
        /// </summary>
        public StringEnumValue<PaymentOfPrincipleType> PaymentOfPrincipleType { get => _paymentOfPrincipleType; set => SetField(ref _paymentOfPrincipleType, value); }

        /// <summary>
        /// MLDS Prepymt Penalty Not To Exceed [RE88395.X127]
        /// </summary>
        public int? PenaltyNotToExceedMonths { get => _penaltyNotToExceedMonths; set => SetField(ref _penaltyNotToExceedMonths, value); }

        /// <summary>
        /// Gfe PocPaid1 [GFE1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid1 { get => _pocPaid1; set => SetField(ref _pocPaid1, value); }

        /// <summary>
        /// Gfe PocPaid2 [GFE2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid2 { get => _pocPaid2; set => SetField(ref _pocPaid2, value); }

        /// <summary>
        /// Gfe PocPaid3 [GFE3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid3 { get => _pocPaid3; set => SetField(ref _pocPaid3, value); }

        /// <summary>
        /// MLDS Broker Zip Code [RE88395.X341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

        /// <summary>
        /// MLDS Prepymt Other Descr [RE88395.X317]
        /// </summary>
        public string PrepaymentOtherDescription { get => _prepaymentOtherDescription; set => SetField(ref _prepaymentOtherDescription, value); }

        /// <summary>
        /// MLDS Prepymt - Other [RE88395.X124]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"Other (see loan documents for details)\"}")]
        public bool? PrepaymentOtherTypeIndicator { get => _prepaymentOtherTypeIndicator; set => SetField(ref _prepaymentOtherTypeIndicator, value); }

        /// <summary>
        /// MLDS Prepymt Penalty Amt [RE88395.X315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => SetField(ref _prepaymentPenaltyAmount, value); }

        /// <summary>
        /// MLDS Prepymt Penalty None [RE88395.X123]
        /// </summary>
        [LoanFieldProperty(OptionsJson = "{\"Y\":\"No prepayment penalty\"}")]
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }

        /// <summary>
        /// MLDS Prepymt Penalty Period [RE88395.X316]
        /// </summary>
        public int? PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => SetField(ref _prepaymentPenaltyPeriod, value); }

        /// <summary>
        /// MLDS RE882 Principal Amount [RE882.X55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PrincipalAmount { get => _principalAmount; set => SetField(ref _principalAmount, value); }

        /// <summary>
        /// MLDS Purchase/Payoff Amt [RE88395.X193]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PurchasePayOff { get => _purchasePayOff; set => SetField(ref _purchasePayOff, value); }

        /// <summary>
        /// MLDS RE882 Add'l Comp Will be Received from Lender [RE882.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Re882AdditionalCompensation { get => _re882AdditionalCompensation; set => SetField(ref _re882AdditionalCompensation, value); }

        /// <summary>
        /// MLDS RE882 Received From Lender Amount [RE882.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? ReceivedFromLenderAmount { get => _receivedFromLenderAmount; set => SetField(ref _receivedFromLenderAmount, value); }

        /// <summary>
        /// File Contacts Broker Rep License # [RE88395.X183]
        /// </summary>
        public string RepresentativeLicense { get => _representativeLicense; set => SetField(ref _representativeLicense, value); }

        /// <summary>
        /// MLDS Prepymt - Sources Deemed Reliable [RE88395.X337]
        /// </summary>
        public bool? SourcesDeemedReliableIndicator { get => _sourcesDeemedReliableIndicator; set => SetField(ref _sourcesDeemedReliableIndicator, value); }

        /// <summary>
        /// MLDS Broker State [RE88395.X340]
        /// </summary>
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

        /// <summary>
        /// Trans Details Subtotal of Deductions [RE88395.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? SubtotalOfAllDeductions { get => _subtotalOfAllDeductions; set => SetField(ref _subtotalOfAllDeductions, value); }

        /// <summary>
        /// MLDS RE882 Total Amount of Compensation Retained by Broker [RE882.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalBrokerCompensationAmount { get => _totalBrokerCompensationAmount; set => SetField(ref _totalBrokerCompensationAmount, value); }

        /// <summary>
        /// Fees Total Closing Cost [TOTAL_CC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalClosingCostWithDiscount { get => _totalClosingCostWithDiscount; set => SetField(ref _totalClosingCostWithDiscount, value); }

        /// <summary>
        /// MLDS RE882 Total Costs and Expenses [RE882.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalCostsExpenses { get => _totalCostsExpenses; set => SetField(ref _totalCostsExpenses, value); }

        /// <summary>
        /// MLDS RE882 Total Est Max Costs and Expenses [RE882.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalMaximumCostsExpenses { get => _totalMaximumCostsExpenses; set => SetField(ref _totalMaximumCostsExpenses, value); }

        /// <summary>
        /// Fees Total Fees, Commiss, Costs, Exp [RE88395.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalOfInitialFees { get => _totalOfInitialFees; set => SetField(ref _totalOfInitialFees, value); }

        /// <summary>
        /// Fees Total Prepaid Cost [TOTAL_PREPAID]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPrepaidClosingCost { get => _totalPrepaidClosingCost; set => SetField(ref _totalPrepaidClosingCost, value); }

        /// <summary>
        /// Fees Total Closing Costs Borr [304]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => SetField(ref _totalSettlementCharges, value); }

        /// <summary>
        /// MLDS Total Tax and Insurance [RE88395.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalTaxAndInsurance { get => _totalTaxAndInsurance; set => SetField(ref _totalTaxAndInsurance, value); }

        /// <summary>
        /// MLDS Prepymt - Yearly Flood Insurance [RE88395.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? YearlyFloodInsurance { get => _yearlyFloodInsurance; set => SetField(ref _yearlyFloodInsurance, value); }

        /// <summary>
        /// MLDS Yearly Insurance [RE88395.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? YearlyInsurance { get => _yearlyInsurance; set => SetField(ref _yearlyInsurance, value); }

        /// <summary>
        /// MLDS Prepymt - Yearly Mortgage Insurance [RE88395.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => SetField(ref _yearlyMortgageInsurance, value); }

        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance [RE88395.X335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? YearlyOtherInsurance { get => _yearlyOtherInsurance; set => SetField(ref _yearlyOtherInsurance, value); }

        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance Description [RE88395.X336]
        /// </summary>
        public string YearlyOtherInsuranceDescription { get => _yearlyOtherInsuranceDescription; set => SetField(ref _yearlyOtherInsuranceDescription, value); }

        /// <summary>
        /// MLDS Yearly Tax [RE88395.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? YearlyTax { get => _yearlyTax; set => SetField(ref _yearlyTax, value); }
    }
}