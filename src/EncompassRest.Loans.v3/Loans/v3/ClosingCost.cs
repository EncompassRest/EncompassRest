using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// ClosingCost
/// </summary>
public sealed partial class ClosingCost : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Insurance Mtg Ins Periodic Factor 1 [1199]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
    public decimal? AdjustmentFactor { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Funding Aggregate Adjustment Checked Borrower [SYS.X545]
    /// </summary>
    public string? AggregateAdjustmentFwbc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Details Bor Paid Discount Points Total [1776]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BorrowerPaidDiscountPointsTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Total Sales Broker Comm [L210]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? BrokerCommissionBasedPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Total Sales Broker Comm Based on % [L209]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? BrokerCommissionBasedUnitPercentage { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD1 Total Sales Broker Comm Based on Amt [L725]
    /// </summary>
    public decimal? BrokerCommissionBasedUnitPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Info Closing Cost Program [1805]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ClosingCostProgram { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingCost ClosingDisclosure1
    /// </summary>
    [AllowNull]
    public ClosingDisclosure1 ClosingDisclosure1 { get => GetEntity<ClosingDisclosure1>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost ClosingDisclosure2
    /// </summary>
    [AllowNull]
    public ClosingDisclosure2 ClosingDisclosure2 { get => GetEntity<ClosingDisclosure2>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost ClosingDisclosure3
    /// </summary>
    [AllowNull]
    public ClosingDisclosure3 ClosingDisclosure3 { get => GetEntity<ClosingDisclosure3>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost ClosingDisclosure4
    /// </summary>
    [AllowNull]
    public ClosingDisclosure4 ClosingDisclosure4 { get => GetEntity<ClosingDisclosure4>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost ClosingDisclosure5
    /// </summary>
    [AllowNull]
    public ClosingDisclosure5 ClosingDisclosure5 { get => GetEntity<ClosingDisclosure5>(); set => SetEntity(value); }

    /// <summary>
    /// Disclosed Sales Price [L726]
    /// </summary>
    public decimal? DisclosedSalesPrice { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Escrow Co Name [610]
    /// </summary>
    public string? EscrowCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Description 1 [NEWHUD.X809]
    /// </summary>
    public string? EscrowTableDesc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Description 2 [NEWHUD.X811]
    /// </summary>
    public string? EscrowTableDesc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Description 3 [NEWHUD.X813]
    /// </summary>
    public string? EscrowTableDesc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Description 4 [NEWHUD.X815]
    /// </summary>
    public string? EscrowTableDesc4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Description 5 [NEWHUD.X817]
    /// </summary>
    public string? EscrowTableDesc5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// 2010 Escrow Fee [NEWHUD.X808]
    /// </summary>
    public decimal? EscrowTableFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Fee 1 [NEWHUD.X810]
    /// </summary>
    public decimal? EscrowTableFee1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Fee 2 [NEWHUD.X812]
    /// </summary>
    public decimal? EscrowTableFee2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Fee 3 [NEWHUD.X814]
    /// </summary>
    public decimal? EscrowTableFee3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Fee 4 [NEWHUD.X816]
    /// </summary>
    public decimal? EscrowTableFee4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Fee 5 [NEWHUD.X818]
    /// </summary>
    public decimal? EscrowTableFee5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Escrow Table [ESCROW_TABLE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? EscrowTableName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingCost FeeVarianceOther
    /// </summary>
    [AllowNull]
    public FeeVarianceOther FeeVarianceOther { get => GetEntity<FeeVarianceOther>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost FeeVariances
    /// </summary>
    [AllowNull]
    public IList<FeeVariance> FeeVariances { get => GetList<FeeVariance>(); set => SetList(value); }

    /// <summary>
    /// ClosingCost Gfe2010
    /// </summary>
    [AllowNull]
    public Gfe2010 Gfe2010 { get => GetEntity<Gfe2010>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost Gfe2010Page
    /// </summary>
    [AllowNull]
    public Gfe2010Page Gfe2010Page { get => GetEntity<Gfe2010Page>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost Gfe2010Section
    /// </summary>
    [AllowNull]
    public Gfe2010Section Gfe2010Section { get => GetEntity<Gfe2010Section>(); set => SetEntity(value); }

    /// <summary>
    /// Expenses Calc Hazard Ins Based On [1322]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
    public decimal? ImpoundHazInsRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP Rate [1807]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true)]
    public decimal? ImpoundMortgInsPremRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP Yrly Basis Check Box [1808]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ImpoundMortgInsPremYearlyBasis { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Tax Resrv Rate [1752]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true)]
    public decimal? ImpoundTaxesRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Hazard Ins Rate [1750]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<ClosingCostImpoundType> ImpoundType1 { get => GetValue<StringEnumValue<ClosingCostImpoundType>>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc Tax Resrv Based On [1751]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public StringEnumValue<ClosingCostImpoundType> ImpoundType2 { get => GetValue<StringEnumValue<ClosingCostImpoundType>>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP/PMI Based On [1757]
    /// </summary>
    public StringEnumValue<ImpoundType3> ImpoundType3 { get => GetValue<StringEnumValue<ImpoundType3>>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Calc MIP Based On [1806]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ImpoundType4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// ClosingCost LoanEstimate1
    /// </summary>
    [AllowNull]
    public LoanEstimate1 LoanEstimate1 { get => GetEntity<LoanEstimate1>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost LoanEstimate2
    /// </summary>
    [AllowNull]
    public LoanEstimate2 LoanEstimate2 { get => GetEntity<LoanEstimate2>(); set => SetEntity(value); }

    /// <summary>
    /// ClosingCost LoanEstimate3
    /// </summary>
    [AllowNull]
    public LoanEstimate3 LoanEstimate3 { get => GetEntity<LoanEstimate3>(); set => SetEntity(value); }

    /// <summary>
    /// Expenses Proposed Monthly Hazard Ins [1780]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedMonthlyHazardInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Expenses Proposed Monthly Mort Ins [1781]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ProposedMonthlyMortgageInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Section 1000 Borrower Paid Total Amount [NEWHUD.X1719]
    /// </summary>
    public decimal? Section1000BorrowerPaidTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Section 1000 Seller Paid Total Amount [NEWHUD.X1713]
    /// </summary>
    public decimal? Section1000SellerPaidTotalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1102 Borr [NEWHUD.X645]
    /// </summary>
    public decimal? SettlementClosingFeeNewHudBorPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1102 Seller [NEWHUD.X782]
    /// </summary>
    public decimal? SettlementClosingFeeNewHudSelPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// File Contacts Title Co Name [411]
    /// </summary>
    public string? TitleCompanyName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1103 Seller [NEWHUD.X783]
    /// </summary>
    public decimal? TitleExaminationNewHudSelPaidAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// 2010 Fees Title Table [2010TITLE_TABLE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TitleTable2010Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Title Table [TITLE_TABLE]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? TitleTableName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 1 - Bor Paid [1671]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 2 - Bor Paid [1673]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 3 - Bor Paid [1675]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Bor Paid Additional Items 4 [RE88395.X213]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Bor Paid Additional Items 5 [RE88395.X223]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Bor Paid Additional Items 6 [RE88395.X233]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForBorPaid6 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 1 - Seller [1672]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid1 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 2 - Seller [1674]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid2 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Total Additional Items 3 - Seller [1676]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid3 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Seller Paid Additional Items 4 [RE88395.X214]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Seller Paid Additional Items 5 [RE88395.X224]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid5 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// MLDS Total Seller Paid Additional Items 6 [RE88395.X234]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? TotalForSellerPaid6 { get => GetValue<decimal?>(); set => SetValue(value); }
}