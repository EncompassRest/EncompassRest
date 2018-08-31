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
        public string Address { get => _address; set => SetField(ref _address, value); }
        private DirtyValue<decimal?> _agregateAdjustment;
        /// <summary>
        /// Fees Aggregate Adj [558]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Aggregate Adj")]
        public decimal? AgregateAdjustment { get => _agregateAdjustment; set => SetField(ref _agregateAdjustment, value); }
        private DirtyValue<decimal?> _brokerCommission;
        /// <summary>
        /// MLDS RE882 Broker Commission/Origination Fee [RE882.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Broker Commission/Origination Fee")]
        public decimal? BrokerCommission { get => _brokerCommission; set => SetField(ref _brokerCommission, value); }
        private DirtyValue<string> _brokerLicense;
        /// <summary>
        /// File Contacts Broker License # [RE88395.X182]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker License #")]
        public string BrokerLicense { get => _brokerLicense; set => SetField(ref _brokerLicense, value); }
        private DirtyValue<string> _brokerName;
        /// <summary>
        /// MLDS Broker Name [RE88395.X150]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Name")]
        public string BrokerName { get => _brokerName; set => SetField(ref _brokerName, value); }
        private DirtyValue<string> _brokerRepresentative;
        /// <summary>
        /// MLDS Broker Rep [RE88395.X151]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Rep")]
        public string BrokerRepresentative { get => _brokerRepresentative; set => SetField(ref _brokerRepresentative, value); }
        private DirtyValue<string> _city;
        /// <summary>
        /// MLDS Broker City [RE88395.X339]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker City")]
        public string City { get => _city; set => SetField(ref _city, value); }
        private DirtyValue<decimal?> _compensationFromLenderAmount;
        /// <summary>
        /// MLDS Broker Comp Add From Lender $ [RE88395.X179]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Broker Comp Add From Lender $")]
        public decimal? CompensationFromLenderAmount { get => _compensationFromLenderAmount; set => SetField(ref _compensationFromLenderAmount, value); }
        private DirtyValue<decimal?> _compensationFromLenderPercentage;
        /// <summary>
        /// MLDS Broker Comp Add From Lender % [RE88395.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS Broker Comp Add From Lender %")]
        public decimal? CompensationFromLenderPercentage { get => _compensationFromLenderPercentage; set => SetField(ref _compensationFromLenderPercentage, value); }
        private DirtyValue<decimal?> _compensationFromLenderTotalAmount;
        /// <summary>
        /// MLDS Broker Comp Add From Lender Amt [RE88395.X109]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Broker Comp Add From Lender Amt")]
        public decimal? CompensationFromLenderTotalAmount { get => _compensationFromLenderTotalAmount; set => SetField(ref _compensationFromLenderTotalAmount, value); }
        private DirtyValue<decimal?> _creditLifeOrDisabilityPremium;
        /// <summary>
        /// MLDS Credit Life/Disability Premium [RE88395.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Credit Life/Disability Premium")]
        public decimal? CreditLifeOrDisabilityPremium { get => _creditLifeOrDisabilityPremium; set => SetField(ref _creditLifeOrDisabilityPremium, value); }
        private DirtyValue<decimal?> _creditToBorrowerAmount;
        /// <summary>
        /// MLDS RE882 Credit to Borrower Amount [RE882.X67]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Credit to Borrower Amount")]
        public decimal? CreditToBorrowerAmount { get => _creditToBorrowerAmount; set => SetField(ref _creditToBorrowerAmount, value); }
        private DirtyValue<decimal?> _estimatedCashAtClosing;
        /// <summary>
        /// MLDS Est Cash at Closing [RE88395.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Est Cash at Closing")]
        public decimal? EstimatedCashAtClosing { get => _estimatedCashAtClosing; set => SetField(ref _estimatedCashAtClosing, value); }
        private DirtyValue<decimal?> _estimatedCashToBorrower;
        /// <summary>
        /// MLDS RE882 Estimated Cash Payable to Borrower [RE882.X6]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Estimated Cash Payable to Borrower")]
        public decimal? EstimatedCashToBorrower { get => _estimatedCashToBorrower; set => SetField(ref _estimatedCashToBorrower, value); }
        private DirtyValue<DateTime?> _estimatedDueDate;
        /// <summary>
        /// MLDS Balloon Pymt Due Date [RE88395.X122]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Balloon Pymt Due Date")]
        public DateTime? EstimatedDueDate { get => _estimatedDueDate; set => SetField(ref _estimatedDueDate, value); }
        private DirtyValue<decimal?> _finalBalloonPayment;
        /// <summary>
        /// MLDS Final Balloon Pymt Amt [RE88395.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Final Balloon Pymt Amt")]
        public decimal? FinalBalloonPayment { get => _finalBalloonPayment; set => SetField(ref _finalBalloonPayment, value); }
        private DirtyValue<decimal?> _firstChangePayment;
        /// <summary>
        /// MLDS S3 1st Monthly Pymt [RE88395.X324]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS S3 1st Monthly Pymt")]
        public decimal? FirstChangePayment { get => _firstChangePayment; set => SetField(ref _firstChangePayment, value); }
        private DirtyValue<decimal?> _firstChangePercent;
        /// <summary>
        /// MLDS S3 1st Change Percent [RE88395.X323]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "MLDS S3 1st Change Percent")]
        public decimal? FirstChangePercent { get => _firstChangePercent; set => SetField(ref _firstChangePercent, value); }
        private DirtyValue<decimal?> _fundingAmount;
        /// <summary>
        /// Expenses Calc MIP/PMI MIP Funding Amt [1826]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Expenses Calc MIP/PMI MIP Funding Amt")]
        public decimal? FundingAmount { get => _fundingAmount; set => SetField(ref _fundingAmount, value); }
        private DirtyList<GfeFee> _gfeFees;
        /// <summary>
        /// Gfe GfeFees
        /// </summary>
        public IList<GfeFee> GfeFees { get => GetField(ref _gfeFees); set => SetField(ref _gfeFees, value); }
        private DirtyList<GfeLien> _gfeLiens;
        /// <summary>
        /// Gfe GfeLiens
        /// </summary>
        public IList<GfeLien> GfeLiens { get => GetField(ref _gfeLiens); set => SetField(ref _gfeLiens, value); }
        private DirtyList<GfePayment> _gfePayments;
        /// <summary>
        /// Gfe GfePayments
        /// </summary>
        public IList<GfePayment> GfePayments { get => GetField(ref _gfePayments); set => SetField(ref _gfePayments, value); }
        private DirtyList<GfePayoff> _gfePayoffs;
        /// <summary>
        /// Gfe GfePayoffs
        /// </summary>
        public IList<GfePayoff> GfePayoffs { get => GetField(ref _gfePayoffs); set => SetField(ref _gfePayoffs, value); }
        private DirtyValue<bool?> _gfeProvidedByBrokerIndicator;
        /// <summary>
        /// Trans Details GFE Provided By Broker [1814]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details GFE Provided By Broker", OptionsJson = "{\"true\":\"This Good Faith Estimate is being provided by broker...\"}")]
        public bool? GfeProvidedByBrokerIndicator { get => _gfeProvidedByBrokerIndicator; set => SetField(ref _gfeProvidedByBrokerIndicator, value); }
        private DirtyValue<bool?> _hasAdditionalCompensationIndicator;
        /// <summary>
        /// MLDS RE882 Add?l Comp Will/May Be Received from Lender [RE882.X4]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Add?l Comp Will/May Be Received from Lender")]
        public bool? HasAdditionalCompensationIndicator { get => _hasAdditionalCompensationIndicator; set => SetField(ref _hasAdditionalCompensationIndicator, value); }
        private DirtyValue<bool?> _hasLateChargesIndicator;
        /// <summary>
        /// Loan has late charges [RE882.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Loan has late charges")]
        public bool? HasLateChargesIndicator { get => _hasLateChargesIndicator; set => SetField(ref _hasLateChargesIndicator, value); }
        private DirtyValue<bool?> _hasPrepaymentPenaltyIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X322]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty", OptionsJson = "{\"true\":\"Prepayment penalty\"}")]
        public bool? HasPrepaymentPenaltyIndicator { get => _hasPrepaymentPenaltyIndicator; set => SetField(ref _hasPrepaymentPenaltyIndicator, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<StringEnumValue<InitialFixedOrArmType>> _initialFixedOrArmType;
        /// <summary>
        /// MLDS Loan Type Check Boxes [RE88395.X326]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Loan Type Check Boxes")]
        public StringEnumValue<InitialFixedOrArmType> InitialFixedOrArmType { get => _initialFixedOrArmType; set => SetField(ref _initialFixedOrArmType, value); }
        private DirtyValue<decimal?> _lenderOriginationFee;
        /// <summary>
        /// MLDS RE882 Lender Origination Fee/Discounts [RE882.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Lender Origination Fee/Discounts")]
        public decimal? LenderOriginationFee { get => _lenderOriginationFee; set => SetField(ref _lenderOriginationFee, value); }
        private DirtyValue<StringEnumValue<LoanFromBrokerControledFundsType>> _loanFromBrokerControledFundsType;
        /// <summary>
        /// MLDS Loan May/May not be from Broker funds [RE88395.X149]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Loan May/May not be from Broker funds")]
        public StringEnumValue<LoanFromBrokerControledFundsType> LoanFromBrokerControledFundsType { get => _loanFromBrokerControledFundsType; set => SetField(ref _loanFromBrokerControledFundsType, value); }
        private DirtyValue<bool?> _lockField;
        /// <summary>
        /// Expenses Calc MIP/PMI Lock [1765]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc MIP/PMI Lock")]
        public bool? LockField { get => _lockField; set => SetField(ref _lockField, value); }
        private DirtyValue<decimal?> _maxLifePayment;
        /// <summary>
        /// MLDS S3 Max Life Monthly Pymt [RE88395.X325]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS S3 Max Life Monthly Pymt")]
        public decimal? MaxLifePayment { get => _maxLifePayment; set => SetField(ref _maxLifePayment, value); }
        private DirtyValue<int?> _maxPaymentAfterMonth;
        /// <summary>
        /// MLDS S3 Months to Max Life Monthly Pymt [RE88395.X327]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS S3 Months to Max Life Monthly Pymt")]
        public int? MaxPaymentAfterMonth { get => _maxPaymentAfterMonth; set => SetField(ref _maxPaymentAfterMonth, value); }
        private DirtyValue<decimal?> _monthlyPaymentAndEscrow;
        /// <summary>
        /// MLDS Monthly Pymt With Escrow [RE88395.X318]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Monthly Pymt With Escrow")]
        public decimal? MonthlyPaymentAndEscrow { get => _monthlyPaymentAndEscrow; set => SetField(ref _monthlyPaymentAndEscrow, value); }
        private DirtyValue<decimal?> _mortgageBrokerComissionFee;
        /// <summary>
        /// MLDS Broker Commission Fee Amt [1119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Broker Commission Fee Amt")]
        public decimal? MortgageBrokerComissionFee { get => _mortgageBrokerComissionFee; set => SetField(ref _mortgageBrokerComissionFee, value); }
        private DirtyValue<string> _mortgageBrokerComissionFeePaidToName;
        /// <summary>
        /// MLDS Broker Commission Fee Descr [RE88395.X190]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker Commission Fee Descr")]
        public string MortgageBrokerComissionFeePaidToName { get => _mortgageBrokerComissionFeePaidToName; set => SetField(ref _mortgageBrokerComissionFeePaidToName, value); }
        private DirtyValue<string> _natureLien1Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 1 Descr Remain on Property [RE882.X52]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 1 Descr Remain on Property")]
        public string NatureLien1Description { get => _natureLien1Description; set => SetField(ref _natureLien1Description, value); }
        private DirtyValue<string> _natureLien1PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay [RE882.X49]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay")]
        public string NatureLien1PayoffDescription { get => _natureLien1PayoffDescription; set => SetField(ref _natureLien1PayoffDescription, value); }
        private DirtyValue<string> _natureLien2Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 2 Descr Remain on Property [RE882.X53]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 2 Descr Remain on Property")]
        public string NatureLien2Description { get => _natureLien2Description; set => SetField(ref _natureLien2Description, value); }
        private DirtyValue<string> _natureLien2PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay [RE882.X50]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay")]
        public string NatureLien2PayoffDescription { get => _natureLien2PayoffDescription; set => SetField(ref _natureLien2PayoffDescription, value); }
        private DirtyValue<string> _natureLien3Description;
        /// <summary>
        /// MLDS RE882 Nature of Lien 3 Descr Remain on Property [RE882.X54]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature of Lien 3 Descr Remain on Property")]
        public string NatureLien3Description { get => _natureLien3Description; set => SetField(ref _natureLien3Description, value); }
        private DirtyValue<string> _natureLien3PayoffDescription;
        /// <summary>
        /// MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay [RE882.X51]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay")]
        public string NatureLien3PayoffDescription { get => _natureLien3PayoffDescription; set => SetField(ref _natureLien3PayoffDescription, value); }
        private DirtyValue<bool?> _paymentOfPrincipleIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty [RE88395.X191]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty", OptionsJson = "{\"true\":\"Any payment of principle in excess of 20% of the\"}")]
        public bool? PaymentOfPrincipleIndicator { get => _paymentOfPrincipleIndicator; set => SetField(ref _paymentOfPrincipleIndicator, value); }
        private DirtyValue<StringEnumValue<PaymentOfPrincipleType>> _paymentOfPrincipleType;
        /// <summary>
        /// MLDS Prepymt Penalty Orig/Unpaid Bal [RE88395.X126]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Orig/Unpaid Bal")]
        public StringEnumValue<PaymentOfPrincipleType> PaymentOfPrincipleType { get => _paymentOfPrincipleType; set => SetField(ref _paymentOfPrincipleType, value); }
        private DirtyValue<int?> _penaltyNotToExceedMonths;
        /// <summary>
        /// MLDS Prepymt Penalty Not To Exceed [RE88395.X127]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Not To Exceed")]
        public int? PenaltyNotToExceedMonths { get => _penaltyNotToExceedMonths; set => SetField(ref _penaltyNotToExceedMonths, value); }
        private DirtyValue<string> _pocPaid1;
        /// <summary>
        /// Gfe PocPaid1 [GFE1]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid1 { get => _pocPaid1; set => SetField(ref _pocPaid1, value); }
        private DirtyValue<string> _pocPaid2;
        /// <summary>
        /// Gfe PocPaid2 [GFE2]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid2 { get => _pocPaid2; set => SetField(ref _pocPaid2, value); }
        private DirtyValue<string> _pocPaid3;
        /// <summary>
        /// Gfe PocPaid3 [GFE3]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string PocPaid3 { get => _pocPaid3; set => SetField(ref _pocPaid3, value); }
        private DirtyValue<string> _postalCode;
        /// <summary>
        /// MLDS Broker Zip Code [RE88395.X341]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "MLDS Broker Zip Code")]
        public string PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }
        private DirtyValue<string> _prepaymentOtherDescription;
        /// <summary>
        /// MLDS Prepymt Other Descr [RE88395.X317]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Other Descr")]
        public string PrepaymentOtherDescription { get => _prepaymentOtherDescription; set => SetField(ref _prepaymentOtherDescription, value); }
        private DirtyValue<bool?> _prepaymentOtherTypeIndicator;
        /// <summary>
        /// MLDS Prepymt - Other [RE88395.X124]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Other", OptionsJson = "{\"true\":\"Other (see loan documents for details)\"}")]
        public bool? PrepaymentOtherTypeIndicator { get => _prepaymentOtherTypeIndicator; set => SetField(ref _prepaymentOtherTypeIndicator, value); }
        private DirtyValue<decimal?> _prepaymentPenaltyAmount;
        /// <summary>
        /// MLDS Prepymt Penalty Amt [RE88395.X315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt Penalty Amt")]
        public decimal? PrepaymentPenaltyAmount { get => _prepaymentPenaltyAmount; set => SetField(ref _prepaymentPenaltyAmount, value); }
        private DirtyValue<bool?> _prepaymentPenaltyIndicator;
        /// <summary>
        /// MLDS Prepymt Penalty None [RE88395.X123]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty None", OptionsJson = "{\"true\":\"No prepayment penalty\"}")]
        public bool? PrepaymentPenaltyIndicator { get => _prepaymentPenaltyIndicator; set => SetField(ref _prepaymentPenaltyIndicator, value); }
        private DirtyValue<int?> _prepaymentPenaltyPeriod;
        /// <summary>
        /// MLDS Prepymt Penalty Period [RE88395.X316]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt Penalty Period")]
        public int? PrepaymentPenaltyPeriod { get => _prepaymentPenaltyPeriod; set => SetField(ref _prepaymentPenaltyPeriod, value); }
        private DirtyValue<decimal?> _principalAmount;
        /// <summary>
        /// MLDS RE882 Principal Amount [RE882.X55]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Principal Amount")]
        public decimal? PrincipalAmount { get => _principalAmount; set => SetField(ref _principalAmount, value); }
        private DirtyValue<decimal?> _purchasePayOff;
        /// <summary>
        /// MLDS Purchase/Payoff Amt [RE88395.X193]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Purchase/Payoff Amt")]
        public decimal? PurchasePayOff { get => _purchasePayOff; set => SetField(ref _purchasePayOff, value); }
        private DirtyValue<decimal?> _re882AdditionalCompensation;
        /// <summary>
        /// MLDS RE882 Add'l Comp Will be Received from Lender [RE882.X5]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Add'l Comp Will be Received from Lender")]
        public decimal? Re882AdditionalCompensation { get => _re882AdditionalCompensation; set => SetField(ref _re882AdditionalCompensation, value); }
        private DirtyValue<decimal?> _receivedFromLenderAmount;
        /// <summary>
        /// MLDS RE882 Received From Lender Amount [RE882.X66]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Received From Lender Amount")]
        public decimal? ReceivedFromLenderAmount { get => _receivedFromLenderAmount; set => SetField(ref _receivedFromLenderAmount, value); }
        private DirtyValue<string> _representativeLicense;
        /// <summary>
        /// File Contacts Broker Rep License # [RE88395.X183]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Broker Rep License #")]
        public string RepresentativeLicense { get => _representativeLicense; set => SetField(ref _representativeLicense, value); }
        private DirtyValue<bool?> _sourcesDeemedReliableIndicator;
        /// <summary>
        /// MLDS Prepymt - Sources Deemed Reliable [RE88395.X337]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Sources Deemed Reliable")]
        public bool? SourcesDeemedReliableIndicator { get => _sourcesDeemedReliableIndicator; set => SetField(ref _sourcesDeemedReliableIndicator, value); }
        private DirtyValue<StringEnumValue<State>> _state;
        /// <summary>
        /// MLDS Broker State [RE88395.X340]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Broker State")]
        public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
        private DirtyValue<decimal?> _subtotalOfAllDeductions;
        /// <summary>
        /// Trans Details Subtotal of Deductions [RE88395.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Trans Details Subtotal of Deductions")]
        public decimal? SubtotalOfAllDeductions { get => _subtotalOfAllDeductions; set => SetField(ref _subtotalOfAllDeductions, value); }
        private DirtyValue<decimal?> _totalBrokerCompensationAmount;
        /// <summary>
        /// MLDS RE882 Total Amount of Compensation Retained by Broker [RE882.X63]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS RE882 Total Amount of Compensation Retained by Broker")]
        public decimal? TotalBrokerCompensationAmount { get => _totalBrokerCompensationAmount; set => SetField(ref _totalBrokerCompensationAmount, value); }
        private DirtyValue<decimal?> _totalClosingCostWithDiscount;
        /// <summary>
        /// Fees Total Closing Cost [TOTAL_CC]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Closing Cost")]
        public decimal? TotalClosingCostWithDiscount { get => _totalClosingCostWithDiscount; set => SetField(ref _totalClosingCostWithDiscount, value); }
        private DirtyValue<decimal?> _totalCostsExpenses;
        /// <summary>
        /// MLDS RE882 Total Costs and Expenses [RE882.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Total Costs and Expenses")]
        public decimal? TotalCostsExpenses { get => _totalCostsExpenses; set => SetField(ref _totalCostsExpenses, value); }
        private DirtyValue<decimal?> _totalMaximumCostsExpenses;
        /// <summary>
        /// MLDS RE882 Total Est Max Costs and Expenses [RE882.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS RE882 Total Est Max Costs and Expenses")]
        public decimal? TotalMaximumCostsExpenses { get => _totalMaximumCostsExpenses; set => SetField(ref _totalMaximumCostsExpenses, value); }
        private DirtyValue<decimal?> _totalOfInitialFees;
        /// <summary>
        /// Fees Total Fees, Commiss, Costs, Exp [RE88395.X108]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Fees, Commiss, Costs, Exp")]
        public decimal? TotalOfInitialFees { get => _totalOfInitialFees; set => SetField(ref _totalOfInitialFees, value); }
        private DirtyValue<decimal?> _totalPrepaidClosingCost;
        /// <summary>
        /// Fees Total Prepaid Cost [TOTAL_PREPAID]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Prepaid Cost")]
        public decimal? TotalPrepaidClosingCost { get => _totalPrepaidClosingCost; set => SetField(ref _totalPrepaidClosingCost, value); }
        private DirtyValue<decimal?> _totalSettlementCharges;
        /// <summary>
        /// Fees Total Closing Costs Borr [304]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Total Closing Costs Borr")]
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => SetField(ref _totalSettlementCharges, value); }
        private DirtyValue<decimal?> _totalTaxAndInsurance;
        /// <summary>
        /// MLDS Total Tax and Insurance [RE88395.X321]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Tax and Insurance")]
        public decimal? TotalTaxAndInsurance { get => _totalTaxAndInsurance; set => SetField(ref _totalTaxAndInsurance, value); }
        private DirtyValue<decimal?> _yearlyFloodInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Flood Insurance [RE88395.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Flood Insurance")]
        public decimal? YearlyFloodInsurance { get => _yearlyFloodInsurance; set => SetField(ref _yearlyFloodInsurance, value); }
        private DirtyValue<decimal?> _yearlyInsurance;
        /// <summary>
        /// MLDS Yearly Insurance [RE88395.X320]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Yearly Insurance")]
        public decimal? YearlyInsurance { get => _yearlyInsurance; set => SetField(ref _yearlyInsurance, value); }
        private DirtyValue<decimal?> _yearlyMortgageInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Mortgage Insurance [RE88395.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Mortgage Insurance")]
        public decimal? YearlyMortgageInsurance { get => _yearlyMortgageInsurance; set => SetField(ref _yearlyMortgageInsurance, value); }
        private DirtyValue<decimal?> _yearlyOtherInsurance;
        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance [RE88395.X335]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Prepymt - Yearly Other Insurance")]
        public decimal? YearlyOtherInsurance { get => _yearlyOtherInsurance; set => SetField(ref _yearlyOtherInsurance, value); }
        private DirtyValue<string> _yearlyOtherInsuranceDescription;
        /// <summary>
        /// MLDS Prepymt - Yearly Other Insurance Description [RE88395.X336]
        /// </summary>
        [LoanFieldProperty(Description = "MLDS Prepymt - Yearly Other Insurance Description")]
        public string YearlyOtherInsuranceDescription { get => _yearlyOtherInsuranceDescription; set => SetField(ref _yearlyOtherInsuranceDescription, value); }
        private DirtyValue<decimal?> _yearlyTax;
        /// <summary>
        /// MLDS Yearly Tax [RE88395.X319]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "MLDS Yearly Tax")]
        public decimal? YearlyTax { get => _yearlyTax; set => SetField(ref _yearlyTax, value); }
    }
}