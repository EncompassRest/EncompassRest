using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe
/// </summary>
public sealed partial class Gfe : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MLDS Broker Street Address [RE88395.X338]
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Aggregate Adj [558]
    /// </summary>
    public decimal? AgregateAdjustment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Broker Commission/Origination Fee [RE882.X26]
    /// </summary>
    public decimal? BrokerCommission { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker License # [RE88395.X182]
    /// </summary>
    public string? BrokerLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Name [RE88395.X150]
    /// </summary>
    public string? BrokerName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Rep [RE88395.X151]
    /// </summary>
    public string? BrokerRepresentative { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker City [RE88395.X339]
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Comp Add From Lender $ [RE88395.X179]
    /// </summary>
    public decimal? CompensationFromLenderAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Comp Add From Lender % [RE88395.X154]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? CompensationFromLenderPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Comp Add From Lender Amt [RE88395.X109]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CompensationFromLenderTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Credit Life/Disability Premium [RE88395.X111]
    /// </summary>
    public decimal? CreditLifeOrDisabilityPremium { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Credit to Borrower Amount [RE882.X67]
    /// </summary>
    public decimal? CreditToBorrowerAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Est Cash at Closing [RE88395.X118]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EstimatedCashAtClosing { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Estimated Cash Payable to Borrower [RE882.X6]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? EstimatedCashToBorrower { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Balloon Pymt Due Date [RE88395.X122]
    /// </summary>
    public DateTime? EstimatedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Final Balloon Pymt Amt [RE88395.X121]
    /// </summary>
    public decimal? FinalBalloonPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS S3 1st Monthly Pymt [RE88395.X324]
    /// </summary>
    public decimal? FirstChangePayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS S3 1st Change Percent [RE88395.X323]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? FirstChangePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI MIP Funding Amt [1826]
    /// </summary>
    public decimal? FundingAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe GfeFees
    /// </summary>
    [AllowNull]
    public IList<GfeFee> GfeFees { get => GetList<GfeFee>(); set => SetList(value); }

    /// <summary>
    /// Gfe GfeLiens
    /// </summary>
    [AllowNull]
    public IList<GfeLien> GfeLiens { get => GetList<GfeLien>(); set => SetList(value); }

    /// <summary>
    /// Gfe GfePayments
    /// </summary>
    [AllowNull]
    public IList<GfePayment> GfePayments { get => GetList<GfePayment>(); set => SetList(value); }

    /// <summary>
    /// Gfe GfePayoffs
    /// </summary>
    [AllowNull]
    public IList<GfePayoff> GfePayoffs { get => GetList<GfePayoff>(); set => SetList(value); }

    /// <summary>
    /// Trans Details GFE Provided By Broker [1814]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"This Good Faith Estimate is being provided by broker...\"}")]
    public bool? GfeProvidedByBrokerIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Add?l Comp Will/May Be Received from Lender [RE882.X4]
    /// </summary>
    public bool? HasAdditionalCompensationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Loan has late charges [RE882.X48]
    /// </summary>
    public bool? HasLateChargesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty [RE88395.X322]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Prepayment penalty\"}")]
    public bool? HasPrepaymentPenaltyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Loan Type Check Boxes [RE88395.X326]
    /// </summary>
    public StringEnumValue<InitialFixedOrArmType> InitialFixedOrArmType { get => GetValue<StringEnumValue<InitialFixedOrArmType>>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Lender Origination Fee/Discounts [RE882.X27]
    /// </summary>
    public decimal? LenderOriginationFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Loan May/May not be from Broker funds [RE88395.X149]
    /// </summary>
    public StringEnumValue<LoanFromBrokerControledFundsType> LoanFromBrokerControledFundsType { get => GetValue<StringEnumValue<LoanFromBrokerControledFundsType>>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Lock [1765]
    /// </summary>
    public bool? LockField { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS S3 Max Life Monthly Pymt [RE88395.X325]
    /// </summary>
    public decimal? MaxLifePayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS S3 Months to Max Life Monthly Pymt [RE88395.X327]
    /// </summary>
    public int? MaxPaymentAfterMonth { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Monthly Pymt With Escrow [RE88395.X318]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyPaymentAndEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Commission Fee Amt [1119]
    /// </summary>
    public decimal? MortgageBrokerComissionFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Commission Fee Descr [RE88395.X190]
    /// </summary>
    public string? MortgageBrokerComissionFeePaidToName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature of Lien 1 Descr Remain on Property [RE882.X52]
    /// </summary>
    public string? NatureLien1Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature Lien 1 Descr Borr Obligated to Pay [RE882.X49]
    /// </summary>
    public string? NatureLien1PayoffDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature of Lien 2 Descr Remain on Property [RE882.X53]
    /// </summary>
    public string? NatureLien2Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature Lien 2 Descr Borr Obligated to Pay [RE882.X50]
    /// </summary>
    public string? NatureLien2PayoffDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature of Lien 3 Descr Remain on Property [RE882.X54]
    /// </summary>
    public string? NatureLien3Description { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Nature Lien 3 Descr Borr Obligated to Pay [RE882.X51]
    /// </summary>
    public string? NatureLien3PayoffDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty [RE88395.X191]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Any payment of principle in excess of 20% of the\"}")]
    public bool? PaymentOfPrincipleIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty Orig/Unpaid Bal [RE88395.X126]
    /// </summary>
    public StringEnumValue<PaymentOfPrincipleType> PaymentOfPrincipleType { get => GetValue<StringEnumValue<PaymentOfPrincipleType>>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty Not To Exceed [RE88395.X127]
    /// </summary>
    public int? PenaltyNotToExceedMonths { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe PocPaid1 [GFE1]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PocPaid1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe PocPaid2 [GFE2]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PocPaid2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe PocPaid3 [GFE3]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? PocPaid3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker Zip Code [RE88395.X341]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Other Descr [RE88395.X317]
    /// </summary>
    public string? PrepaymentOtherDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Other [RE88395.X124]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"Other (see loan documents for details)\"}")]
    public bool? PrepaymentOtherTypeIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty Amt [RE88395.X315]
    /// </summary>
    public decimal? PrepaymentPenaltyAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty None [RE88395.X123]
    /// </summary>
    [LoanFieldProperty(OptionsJson = "{\"Y\":\"No prepayment penalty\"}")]
    public bool? PrepaymentPenaltyIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt Penalty Period [RE88395.X316]
    /// </summary>
    public int? PrepaymentPenaltyPeriod { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Principal Amount [RE882.X55]
    /// </summary>
    public decimal? PrincipalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Purchase/Payoff Amt [RE88395.X193]
    /// </summary>
    public decimal? PurchasePayOff { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Add'l Comp Will be Received from Lender [RE882.X5]
    /// </summary>
    public decimal? Re882AdditionalCompensation { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Received From Lender Amount [RE882.X66]
    /// </summary>
    public decimal? ReceivedFromLenderAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Broker Rep License # [RE88395.X183]
    /// </summary>
    public string? RepresentativeLicense { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Sources Deemed Reliable [RE88395.X337]
    /// </summary>
    public bool? SourcesDeemedReliableIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Broker State [RE88395.X340]
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// Trans Details Subtotal of Deductions [RE88395.X116]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? SubtotalOfAllDeductions { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Total Amount of Compensation Retained by Broker [RE882.X63]
    /// </summary>
    public decimal? TotalBrokerCompensationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Cost [TOTAL_CC]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalClosingCostWithDiscount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Total Costs and Expenses [RE882.X47]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalCostsExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS RE882 Total Est Max Costs and Expenses [RE882.X25]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalMaximumCostsExpenses { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Fees, Commiss, Costs, Exp [RE88395.X108]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalOfInitialFees { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Prepaid Cost [TOTAL_PREPAID]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalPrepaidClosingCost { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Closing Costs Borr [304]
    /// </summary>
    public decimal? TotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Tax and Insurance [RE88395.X321]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalTaxAndInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Yearly Flood Insurance [RE88395.X334]
    /// </summary>
    public decimal? YearlyFloodInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Yearly Insurance [RE88395.X320]
    /// </summary>
    public decimal? YearlyInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Yearly Mortgage Insurance [RE88395.X333]
    /// </summary>
    public decimal? YearlyMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Yearly Other Insurance [RE88395.X335]
    /// </summary>
    public decimal? YearlyOtherInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Prepymt - Yearly Other Insurance Description [RE88395.X336]
    /// </summary>
    public string? YearlyOtherInsuranceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Yearly Tax [RE88395.X319]
    /// </summary>
    public decimal? YearlyTax { get => GetValue<decimal?>(); set => SetValue(value); }
}