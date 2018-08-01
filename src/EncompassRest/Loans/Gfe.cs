using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe
    /// </summary>
    public sealed partial class Gfe : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _address;
        /// <summary>
        /// MLDS Broker Street Address [RE88395.X338]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Street Address")]
        public string Address { get => _address; set => _address = value; }
        private DirtyValue<decimal?> _agregateAdjustment;
        /// <summary>
        /// Fees Aggregate Adj [558]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Aggregate Adj")]
        public decimal? AgregateAdjustment { get => _agregateAdjustment; set => _agregateAdjustment = value; }
        private DirtyValue<decimal?> _brokerCommission;
        /// <summary>
        /// MLDS RE882 Broker Commission/Origination Fee [RE882.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Broker Commission/Origination Fee")]
        public decimal? BrokerCommission { get => _brokerCommission; set => _brokerCommission = value; }
        private DirtyValue<string> _brokerLicense;
        /// <summary>
        /// File Contacts Broker License # [RE88395.X182]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker License #")]
        public string BrokerLicense { get => _brokerLicense; set => _brokerLicense = value; }
        private DirtyValue<string> _brokerName;
        /// <summary>
        /// MLDS Broker Name [RE88395.X150]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Name")]
        public string BrokerName { get => _brokerName; set => _brokerName = value; }
        private DirtyValue<string> _brokerRepresentative;
        /// <summary>
        /// MLDS Broker Rep [RE88395.X151]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Rep")]
        public string BrokerRepresentative { get => _brokerRepresentative; set => _brokerRepresentative = value; }
        private DirtyValue<string> _city;
        /// <summary>
        /// MLDS Broker City [RE88395.X339]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker City")]
        public string City { get => _city; set => _city = value; }
        private DirtyValue<decimal?> _compensationFromLenderAmount;
        /// <summary>
        /// MLDS Broker Comp Add From Lender $ [RE88395.X179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Broker Comp Add From Lender $")]
        public decimal? CompensationFromLenderAmount { get => _compensationFromLenderAmount; set => _compensationFromLenderAmount = value; }
        private DirtyValue<decimal?> _compensationFromLenderPercentage;
        /// <summary>
        /// MLDS Broker Comp Add From Lender % [RE88395.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS Broker Comp Add From Lender %")]
        public decimal? CompensationFromLenderPercentage { get => _compensationFromLenderPercentage; set => _compensationFromLenderPercentage = value; }
        private DirtyValue<decimal?> _compensationFromLenderTotalAmount;
        /// <summary>
        /// MLDS Broker Comp Add From Lender Amt [RE88395.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Broker Comp Add From Lender Amt")]
        public decimal? CompensationFromLenderTotalAmount { get => _compensationFromLenderTotalAmount; set => _compensationFromLenderTotalAmount = value; }
        private DirtyValue<decimal?> _creditLifeOrDisabilityPremium;
        /// <summary>
        /// MLDS Credit Life/Disability Premium [RE88395.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Credit Life/Disability Premium")]
        public decimal? CreditLifeOrDisabilityPremium { get => _creditLifeOrDisabilityPremium; set => _creditLifeOrDisabilityPremium = value; }
        private DirtyValue<decimal?> _creditToBorrowerAmount;
        /// <summary>
        /// MLDS RE882 Credit to Borrower Amount [RE882.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Credit to Borrower Amount")]
        public decimal? CreditToBorrowerAmount { get => _creditToBorrowerAmount; set => _creditToBorrowerAmount = value; }
        private DirtyValue<decimal?> _estimatedCashAtClosing;
        /// <summary>
        /// MLDS Est Cash at Closing [RE88395.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Est Cash at Closing")]
        public decimal? EstimatedCashAtClosing { get => _estimatedCashAtClosing; set => _estimatedCashAtClosing = value; }
        private DirtyValue<decimal?> _estimatedCashToBorrower;
        /// <summary>
        /// MLDS RE882 Estimated Cash Payable to Borrower [RE882.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Estimated Cash Payable to Borrower")]
        public decimal? EstimatedCashToBorrower { get => _estimatedCashToBorrower; set => _estimatedCashToBorrower = value; }
        private DirtyValue<DateTime?> _estimatedDueDate;
        /// <summary>
        /// MLDS Balloon Pymt Due Date [RE88395.X122]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Balloon Pymt Due Date")]
        public DateTime? EstimatedDueDate { get => _estimatedDueDate; set => _estimatedDueDate = value; }
        private DirtyValue<decimal?> _finalBalloonPayment;
        /// <summary>
        /// MLDS Final Balloon Pymt Amt [RE88395.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Final Balloon Pymt Amt")]
        public decimal? FinalBalloonPayment { get => _finalBalloonPayment; set => _finalBalloonPayment = value; }
        private DirtyValue<decimal?> _firstChangePayment;
        /// <summary>
        /// MLDS S3 1st Monthly Pymt [RE88395.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS S3 1st Monthly Pymt")]
        public decimal? FirstChangePayment { get => _firstChangePayment; set => _firstChangePayment = value; }
        private DirtyValue<decimal?> _firstChangePercent;
        /// <summary>
        /// MLDS S3 1st Change Percent [RE88395.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS S3 1st Change Percent")]
        public decimal? FirstChangePercent { get => _firstChangePercent; set => _firstChangePercent = value; }
        private DirtyValue<decimal?> _fundingAmount;
        /// <summary>
        /// Expenses Calc MIP/PMI MIP Funding Amt [1826]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Calc MIP/PMI MIP Funding Amt")]
        public decimal? FundingAmount { get => _fundingAmount; set => _fundingAmount = value; }
        private DirtyList<GfeFee> _gfeFees;
        /// <summary>
        /// Gfe GfeFees
        /// </summary>
        public IList<GfeFee> GfeFees { get => _gfeFees ?? (_gfeFees = new DirtyList<GfeFee>()); set => _gfeFees = new DirtyList<GfeFee>(value); }
        private DirtyList<GfeLien> _gfeLiens;
        /// <summary>
        /// Gfe GfeLiens
        /// </summary>
        public IList<GfeLien> GfeLiens { get => _gfeLiens ?? (_gfeLiens = new DirtyList<GfeLien>()); set => _gfeLiens = new DirtyList<GfeLien>(value); }
        private DirtyList<GfePayment> _gfePayments;
        /// <summary>
        /// Gfe GfePayments
        /// </summary>
        public IList<GfePayment> GfePayments { get => _gfePayments ?? (_gfePayments = new DirtyList<GfePayment>()); set => _gfePayments = new DirtyList<GfePayment>(value); }
        private DirtyList<GfePayoff> _gfePayoffs;
        /// <summary>
        /// Gfe GfePayoffs
        /// </summary>
        public IList<GfePayoff> GfePayoffs { get => _gfePayoffs ?? (_gfePayoffs = new DirtyList<GfePayoff>()); set => _gfePayoffs = new DirtyList<GfePayoff>(value); }
        private DirtyValue<bool?> _gfeProvidedByBrokerIndicator;
        /// <summary>
        /// Trans Details GFE Provided By Broker [1814]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details GFE Provided By Broker", OptionsJson = "{\"true\":\"This Good Faith Estimate is being provided by broker...\"}")]
        public bool? GfeProvidedByBrokerIndicator { get => _gfeProvidedByBrokerIndicator; set => _gfeProvidedByBrokerIndicator = value; }
        private DirtyValue<bool?> _hasAdditionalCompensationIndicator;
        /// <summary>
        /// MLDS RE882 Add?l Comp Will/May Be Received from Lender [RE882.X4]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Add?l Comp Will/May Be Received from Lender")]
        public bool? HasAdditionalCompensationIndicator { get => _hasAdditionalCompensationIndicator; set => _hasAdditionalCompensationIndicator = value; }
        private DirtyValue<bool?> _hasLateChargesIndicator;
        /// <summary>
        /// Loan has late charges [RE882.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Loan has late charges")]
        public bool? HasLateChargesIndicator { get => _hasLateChargesIndicator; set => _hasLateChargesIndicator = value; }
        private DirtyValue<bool?> _hasPrepaymentPenaltyIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X322]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty", OptionsJson = "{\"true\":\"Prepayment penalty\"}")]
        public bool? HasPrepaymentPenaltyIndicator { get => _hasPrepaymentPenaltyIndicator; set => _hasPrepaymentPenaltyIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<InitialFixedOrArmType>> _initialFixedOrArmType;
        /// <summary>
        /// MLDS Loan Type Check Boxes [RE88395.X326]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Loan Type Check Boxes")]
        public StringEnumValue<InitialFixedOrArmType> InitialFixedOrArmType { get => _initialFixedOrArmType; set => _initialFixedOrArmType = value; }
        private DirtyValue<decimal?> _lenderOriginationFee;
        /// <summary>
        /// MLDS RE882 Lender Origination Fee/Discounts [RE882.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Lender Origination Fee/Discounts")]
        public decimal? LenderOriginationFee { get => _lenderOriginationFee; set => _lenderOriginationFee = value; }
        private DirtyValue<StringEnumValue<LoanFromBrokerControledFundsType>> _loanFromBrokerControledFundsType;
        /// <summary>
        /// MLDS Loan May/May not be from Broker funds [RE88395.X149]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Loan May/May not be from Broker funds")]
        public StringEnumValue<LoanFromBrokerControledFundsType> LoanFromBrokerControledFundsType { get => _loanFromBrokerControledFundsType; set => _loanFromBrokerControledFundsType = value; }
        private DirtyValue<bool?> _lockField;
        /// <summary>
        /// Expenses Calc MIP/PMI Lock [1765]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc MIP/PMI Lock")]
        public bool? LockField { get => _lockField; set => _lockField = value; }
        private DirtyValue<decimal?> _maxLifePayment;
        /// <summary>
        /// MLDS S3 Max Life Monthly Pymt [RE88395.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS S3 Max Life Monthly Pymt")]
        public decimal? MaxLifePayment { get => _maxLifePayment; set => _maxLifePayment = value; }
        private DirtyValue<int?> _maxPaymentAfterMonth;
        /// <summary>
        /// MLDS S3 Months to Max Life Monthly Pymt [RE88395.X327]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS S3 Months to Max Life Monthly Pymt")]
        public int? MaxPaymentAfterMonth { get => _maxPaymentAfterMonth; set => _maxPaymentAfterMonth = value; }
        private DirtyValue<decimal?> _monthlyPaymentAndEscrow;
        /// <summary>
        /// MLDS Monthly Pymt With Escrow [RE88395.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Monthly Pymt With Escrow")]
        public decimal? MonthlyPaymentAndEscrow { get => _monthlyPaymentAndEscrow; set => _monthlyPaymentAndEscrow = value; }
        private DirtyValue<decimal?> _mortgageBrokerComissionFee;
        /// <summary>
        /// MLDS Broker Commission Fee Amt [1119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Broker Commission Fee Amt")]
        public decimal? MortgageBrokerComissionFee { get => _mortgageBrokerComissionFee; set => _mortgageBrokerComissionFee = value; }
        private DirtyValue<string> _mortgageBrokerComissionFeePaidToName;
        /// <summary>
        /// MLDS Broker Commission Fee Descr [RE88395.X190]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Commission Fee Descr")]
        public string MortgageBrokerComissionFeePaidToName { get => _mortgageBrokerComissionFeePaidToName; set => _mortgageBrokerComissionFeePaidToName = value; }
        private DirtyValue<string> _natureLien1Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 1 Descr Remain on Property [RE882.X52]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 1 Descr Remain on Property")]
        public string NatureLien1Description { get => _natureLien1Description; set => _natureLien1Description = value; }
        private DirtyValue<string> _natureLien1PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay [RE882.X49]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay")]
        public string NatureLien1PayoffDescription { get => _natureLien1PayoffDescription; set => _natureLien1PayoffDescription = value; }
        private DirtyValue<string> _natureLien2Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 2 Descr Remain on Property [RE882.X53]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 2 Descr Remain on Property")]
        public string NatureLien2Description { get => _natureLien2Description; set => _natureLien2Description = value; }
        private DirtyValue<string> _natureLien2PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay [RE882.X50]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay")]
        public string NatureLien2PayoffDescription { get => _natureLien2PayoffDescription; set => _natureLien2PayoffDescription = value; }
        private DirtyValue<string> _natureLien3Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 3 Descr Remain on Property [RE882.X54]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 3 Descr Remain on Property")]
        public string NatureLien3Description { get => _natureLien3Description; set => _natureLien3Description = value; }
        private DirtyValue<string> _natureLien3PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay [RE882.X51]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay")]
        public string NatureLien3PayoffDescription { get => _natureLien3PayoffDescription; set => _natureLien3PayoffDescription = value; }
        private DirtyValue<bool?> _paymentOfPrincipleIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X191]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty", OptionsJson = "{\"true\":\"Any payment of principle in excess of 20% of the\"}")]
        public bool? PaymentOfPrincipleIndicator { get => _paymentOfPrincipleIndicator; set => _paymentOfPrincipleIndicator = value; }
        private DirtyValue<StringEnumValue<PaymentOfPrincipleType>> _paymentOfPrincipleType;
        /// <summary>
        /// MLDS Prepymt Penalty Orig/Unpaid Bal [RE88395.X126]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Orig/Unpaid Bal")]
        public StringEnumValue<PaymentOfPrincipleType> PaymentOfPrincipleType { get => _paymentOfPrincipleType; set => _paymentOfPrincipleType = value; }
        private DirtyValue<int?> _penaltyNotToExceedMonths;
        /// <summary>
        /// MLDS Prepymt Penalty Not To Exceed [RE88395.X127]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Not To Exceed")]
        public int? PenaltyNotToExceedMonths { get => _penaltyNotToExceedMonths; set => _penaltyNotToExceedMonths = value; }
        private DirtyValue<string> _pocPaid1;
        /// <summary>
        /// Gfe PocPaid1 [GFE1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid1 { get => _pocPaid1; set => _pocPaid1 = value; }
        private DirtyValue<string> _pocPaid2;
        /// <summary>
        /// Gfe PocPaid2 [GFE2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid2 { get => _pocPaid2; set => _pocPaid2 = value; }
        private DirtyValue<string> _pocPaid3;
        /// <summary>
        /// Gfe PocPaid3 [GFE3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid3 { get => _pocPaid3; set => _pocPaid3 = value; }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// MLDS Broker Zip Code [RE88395.X341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "MLDS Broker Zip Code")]
        public string PostalCode { get => _postalCode; set => _postalCode = value; }
        private DirtyValue<string> _prepaymentOtherDescription;
        /// <summary>
        /// MLDS Prepymt Other Descr [RE88395.X317]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Other Descr")]
        public string PrepaymentOtherDescription { get => _prepaymentOtherDescription; set => _prepaymentOtherDescription = value; }
        private DirtyValue<bool?> _prepaymentOtherTypeIndicator;
        /// <summary>
        /// MLDS Prepymt - Other [RE88395.X124]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Other", OptionsJson = "{\"true\":\"Other (see loan documents for details)\"}")]
        public bool? PrepaymentOtherTypeIndicator { get => _prepaymentOtherTypeIndicator; set => _prepaymentOtherTypeIndicator = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        /// <summary>
        /// MLDS Prepymt Penalty Amt [RE88395.X315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt Penalty Amt")]
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => _prepaymentPenaltyAmount = value; }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty None [RE88395.X123]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty None", OptionsJson = "{\"true\":\"No prepayment penalty\"}")]
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => _prepaymentPenaltyIndicator = value; }
        private DirtyValue<int?> _prepaymentPenaltyPeriod;
        /// <summary>
        /// MLDS Prepymt Penalty Period [RE88395.X316]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Period")]
        public int? PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => _prepaymentPenaltyPeriod = value; }
        private DirtyValue<decimal?> _principalAmount;
        /// <summary>
        /// MLDS RE882 Principal Amount [RE882.X55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Principal Amount")]
        public decimal? PrincipalAmount { get => _principalAmount; set => _principalAmount = value; }
        private DirtyValue<decimal?> _purchasePayOff;
        /// <summary>
        /// MLDS Purchase/Payoff Amt [RE88395.X193]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Purchase/Payoff Amt")]
        public decimal? PurchasePayOff { get => _purchasePayOff; set => _purchasePayOff = value; }
        private DirtyValue<decimal?> _re882AdditionalCompensation;
        /// <summary>
        /// MLDS RE882 Add'l Comp Will be Received from Lender [RE882.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Add'l Comp Will be Received from Lender")]
        public decimal? Re882AdditionalCompensation { get => _re882AdditionalCompensation; set => _re882AdditionalCompensation = value; }
        private DirtyValue<decimal?> _receivedFromLenderAmount;
        /// <summary>
        /// MLDS RE882 Received From Lender Amount [RE882.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Received From Lender Amount")]
        public decimal? ReceivedFromLenderAmount { get => _receivedFromLenderAmount; set => _receivedFromLenderAmount = value; }
        private DirtyValue<string> _representativeLicense;
        /// <summary>
        /// File Contacts Broker Rep License # [RE88395.X183]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Rep License #")]
        public string RepresentativeLicense { get => _representativeLicense; set => _representativeLicense = value; }
        private DirtyValue<bool?> _sourcesDeemedReliableIndicator;
        /// <summary>
        /// MLDS Prepymt - Sources Deemed Reliable [RE88395.X337]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Sources Deemed Reliable")]
        public bool? SourcesDeemedReliableIndicator { get => _sourcesDeemedReliableIndicator; set => _sourcesDeemedReliableIndicator = value; }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// MLDS Broker State [RE88395.X340]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker State")]
        public StringEnumValue<State> State { get => _state; set => _state = value; }
        private DirtyValue<decimal?> _subtotalOfAllDeductions;
        /// <summary>
        /// Trans Details Subtotal of Deductions [RE88395.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Subtotal of Deductions")]
        public decimal? SubtotalOfAllDeductions { get => _subtotalOfAllDeductions; set => _subtotalOfAllDeductions = value; }
        private DirtyValue<decimal?> _totalBrokerCompensationAmount;
        /// <summary>
        /// MLDS RE882 Total Amount of Compensation Retained by Broker [RE882.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Total Amount of Compensation Retained by Broker")]
        public decimal? TotalBrokerCompensationAmount { get => _totalBrokerCompensationAmount; set => _totalBrokerCompensationAmount = value; }
        private DirtyValue<decimal?> _totalClosingCostWithDiscount;
        /// <summary>
        /// Fees Total Closing Cost [TOTAL_CC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Closing Cost")]
        public decimal? TotalClosingCostWithDiscount { get => _totalClosingCostWithDiscount; set => _totalClosingCostWithDiscount = value; }
        private DirtyValue<decimal?> _totalCostsExpenses;
        /// <summary>
        /// MLDS RE882 Total Costs and Expenses [RE882.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Total Costs and Expenses")]
        public decimal? TotalCostsExpenses { get => _totalCostsExpenses; set => _totalCostsExpenses = value; }
        private DirtyValue<decimal?> _totalMaximumCostsExpenses;
        /// <summary>
        /// MLDS RE882 Total Est Max Costs and Expenses [RE882.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Total Est Max Costs and Expenses")]
        public decimal? TotalMaximumCostsExpenses { get => _totalMaximumCostsExpenses; set => _totalMaximumCostsExpenses = value; }
        private DirtyValue<decimal?> _totalOfInitialFees;
        /// <summary>
        /// Fees Total Fees, Commiss, Costs, Exp [RE88395.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Fees, Commiss, Costs, Exp")]
        public decimal? TotalOfInitialFees { get => _totalOfInitialFees; set => _totalOfInitialFees = value; }
        private DirtyValue<decimal?> _totalPrepaidClosingCost;
        /// <summary>
        /// Fees Total Prepaid Cost [TOTAL_PREPAID]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Prepaid Cost")]
        public decimal? TotalPrepaidClosingCost { get => _totalPrepaidClosingCost; set => _totalPrepaidClosingCost = value; }
        private DirtyValue<decimal?> _totalSettlementCharges;
        /// <summary>
        /// Fees Total Closing Costs Borr [304]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Borr")]
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => _totalSettlementCharges = value; }
        private DirtyValue<decimal?> _totalTaxAndInsurance;
        /// <summary>
        /// MLDS Total Tax and Insurance [RE88395.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Tax and Insurance")]
        public decimal? TotalTaxAndInsurance { get => _totalTaxAndInsurance; set => _totalTaxAndInsurance = value; }
        private DirtyValue<decimal?> _yearlyFloodInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Flood Insurance [RE88395.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Flood Insurance")]
        public decimal? YearlyFloodInsurance { get => _yearlyFloodInsurance; set => _yearlyFloodInsurance = value; }
        private DirtyValue<decimal?> _yearlyInsurance;
        /// <summary>
        /// MLDS Yearly Insurance [RE88395.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Yearly Insurance")]
        public decimal? YearlyInsurance { get => _yearlyInsurance; set => _yearlyInsurance = value; }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Mortgage Insurance [RE88395.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Mortgage Insurance")]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => _yearlyMortgageInsurance = value; }
        private DirtyValue<decimal?> _yearlyOtherInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance [RE88395.X335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Other Insurance")]
        public decimal? YearlyOtherInsurance { get => _yearlyOtherInsurance; set => _yearlyOtherInsurance = value; }
        private DirtyValue<string> _yearlyOtherInsuranceDescription;
        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance Description [RE88395.X336]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Yearly Other Insurance Description")]
        public string YearlyOtherInsuranceDescription { get => _yearlyOtherInsuranceDescription; set => _yearlyOtherInsuranceDescription = value; }
        private DirtyValue<decimal?> _yearlyTax;
        /// <summary>
        /// MLDS Yearly Tax [RE88395.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Yearly Tax")]
        public decimal? YearlyTax { get => _yearlyTax; set => _yearlyTax = value; }
        internal override bool DirtyInternal
        {
            get => _address.Dirty
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