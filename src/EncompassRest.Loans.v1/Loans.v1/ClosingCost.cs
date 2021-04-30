using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.v1.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// ClosingCost
    /// </summary>
    public sealed partial class ClosingCost : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _adjustmentFactor;
        private DirtyValue<string?>? _aggregateAdjustmentFwbc;
        private DirtyValue<decimal?>? _borrowerPaidDiscountPointsTotalAmount;
        private DirtyValue<decimal?>? _brokerCommissionBasedPrice;
        private DirtyValue<decimal?>? _brokerCommissionBasedUnitPercentage;
        private DirtyValue<decimal?>? _brokerCommissionBasedUnitPrice;
        private DirtyValue<string?>? _closingCostProgram;
        private DirtyValue<string?>? _closingCostScenarioXml;
        private ClosingDisclosure1? _closingDisclosure1;
        private ClosingDisclosure2? _closingDisclosure2;
        private ClosingDisclosure3? _closingDisclosure3;
        private ClosingDisclosure4? _closingDisclosure4;
        private ClosingDisclosure5? _closingDisclosure5;
        private DirtyValue<decimal?>? _disclosedSalesPrice;
        private DirtyValue<string?>? _escrowCompanyName;
        private DirtyValue<string?>? _escrowTableDesc1;
        private DirtyValue<string?>? _escrowTableDesc2;
        private DirtyValue<string?>? _escrowTableDesc3;
        private DirtyValue<string?>? _escrowTableDesc4;
        private DirtyValue<string?>? _escrowTableDesc5;
        private DirtyValue<decimal?>? _escrowTableFee;
        private DirtyValue<decimal?>? _escrowTableFee1;
        private DirtyValue<decimal?>? _escrowTableFee2;
        private DirtyValue<decimal?>? _escrowTableFee3;
        private DirtyValue<decimal?>? _escrowTableFee4;
        private DirtyValue<decimal?>? _escrowTableFee5;
        private DirtyValue<string?>? _escrowTableName;
        private FeeVarianceOther? _feeVarianceOther;
        private DirtyList<FeeVariance>? _feeVariances;
        private Gfe2010? _gfe2010;
        private Gfe2010Page? _gfe2010Page;
        private Gfe2010Section? _gfe2010Section;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _impoundHazInsRate;
        private DirtyValue<decimal?>? _impoundMortgInsPremRate;
        private DirtyValue<string?>? _impoundMortgInsPremYearlyBasis;
        private DirtyValue<decimal?>? _impoundTaxesRate;
        private DirtyValue<StringEnumValue<ClosingCostImpoundType>>? _impoundType1;
        private DirtyValue<StringEnumValue<ClosingCostImpoundType>>? _impoundType2;
        private DirtyValue<StringEnumValue<ImpoundType3>>? _impoundType3;
        private DirtyValue<string?>? _impoundType4;
        private LoanEstimate1? _loanEstimate1;
        private LoanEstimate2? _loanEstimate2;
        private LoanEstimate3? _loanEstimate3;
        private DirtyValue<decimal?>? _proposedMonthlyHazardInsurance;
        private DirtyValue<decimal?>? _proposedMonthlyMortgageInsurance;
        private DirtyValue<decimal?>? _section1000BorrowerPaidTotalAmount;
        private DirtyValue<decimal?>? _section1000SellerPaidTotalAmount;
        private DirtyValue<decimal?>? _settlementClosingFeeNewHudBorPaidAmount;
        private DirtyValue<decimal?>? _settlementClosingFeeNewHudSelPaidAmount;
        private DirtyValue<string?>? _titleCompanyName;
        private DirtyValue<decimal?>? _titleExaminationNewHudSelPaidAmount;
        private DirtyValue<string?>? _titleTable2010Name;
        private DirtyValue<string?>? _titleTableName;
        private DirtyValue<decimal?>? _totalForBorPaid1;
        private DirtyValue<decimal?>? _totalForBorPaid2;
        private DirtyValue<decimal?>? _totalForBorPaid3;
        private DirtyValue<decimal?>? _totalForBorPaid4;
        private DirtyValue<decimal?>? _totalForBorPaid5;
        private DirtyValue<decimal?>? _totalForBorPaid6;
        private DirtyValue<decimal?>? _totalForSellerPaid1;
        private DirtyValue<decimal?>? _totalForSellerPaid2;
        private DirtyValue<decimal?>? _totalForSellerPaid3;
        private DirtyValue<decimal?>? _totalForSellerPaid4;
        private DirtyValue<decimal?>? _totalForSellerPaid5;
        private DirtyValue<decimal?>? _totalForSellerPaid6;

        /// <summary>
        /// Insurance Mtg Ins Periodic Factor 1 [1199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6)]
        public decimal? AdjustmentFactor { get => _adjustmentFactor; set => SetField(ref _adjustmentFactor, value); }

        /// <summary>
        /// Funding Aggregate Adjustment Checked Borrower [SYS.X545]
        /// </summary>
        public string? AggregateAdjustmentFwbc { get => _aggregateAdjustmentFwbc; set => SetField(ref _aggregateAdjustmentFwbc, value); }

        /// <summary>
        /// Loan Details Bor Paid Discount Points Total [1776]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => SetField(ref _borrowerPaidDiscountPointsTotalAmount, value); }

        /// <summary>
        /// HUD1 Total Sales Broker Comm [L210]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? BrokerCommissionBasedPrice { get => _brokerCommissionBasedPrice; set => SetField(ref _brokerCommissionBasedPrice, value); }

        /// <summary>
        /// HUD1 Total Sales Broker Comm Based on % [L209]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerCommissionBasedUnitPercentage { get => _brokerCommissionBasedUnitPercentage; set => SetField(ref _brokerCommissionBasedUnitPercentage, value); }

        /// <summary>
        /// HUD1 Total Sales Broker Comm Based on Amt [L725]
        /// </summary>
        public decimal? BrokerCommissionBasedUnitPrice { get => _brokerCommissionBasedUnitPrice; set => SetField(ref _brokerCommissionBasedUnitPrice, value); }

        /// <summary>
        /// Loan Info Closing Cost Program [1805]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ClosingCostProgram { get => _closingCostProgram; set => SetField(ref _closingCostProgram, value); }

        /// <summary>
        /// ClosingCost ClosingCostScenarioXml
        /// </summary>
        public string? ClosingCostScenarioXml { get => _closingCostScenarioXml; set => SetField(ref _closingCostScenarioXml, value); }

        /// <summary>
        /// ClosingCost ClosingDisclosure1
        /// </summary>
        [AllowNull]
        public ClosingDisclosure1 ClosingDisclosure1 { get => GetField(ref _closingDisclosure1); set => SetField(ref _closingDisclosure1, value); }

        /// <summary>
        /// ClosingCost ClosingDisclosure2
        /// </summary>
        [AllowNull]
        public ClosingDisclosure2 ClosingDisclosure2 { get => GetField(ref _closingDisclosure2); set => SetField(ref _closingDisclosure2, value); }

        /// <summary>
        /// ClosingCost ClosingDisclosure3
        /// </summary>
        [AllowNull]
        public ClosingDisclosure3 ClosingDisclosure3 { get => GetField(ref _closingDisclosure3); set => SetField(ref _closingDisclosure3, value); }

        /// <summary>
        /// ClosingCost ClosingDisclosure4
        /// </summary>
        [AllowNull]
        public ClosingDisclosure4 ClosingDisclosure4 { get => GetField(ref _closingDisclosure4); set => SetField(ref _closingDisclosure4, value); }

        /// <summary>
        /// ClosingCost ClosingDisclosure5
        /// </summary>
        [AllowNull]
        public ClosingDisclosure5 ClosingDisclosure5 { get => GetField(ref _closingDisclosure5); set => SetField(ref _closingDisclosure5, value); }

        /// <summary>
        /// Disclosed Sales Price [L726]
        /// </summary>
        public decimal? DisclosedSalesPrice { get => _disclosedSalesPrice; set => SetField(ref _disclosedSalesPrice, value); }

        /// <summary>
        /// File Contacts Escrow Co Name [610]
        /// </summary>
        public string? EscrowCompanyName { get => _escrowCompanyName; set => SetField(ref _escrowCompanyName, value); }

        /// <summary>
        /// Fees Escrow Description 1 [NEWHUD.X809]
        /// </summary>
        public string? EscrowTableDesc1 { get => _escrowTableDesc1; set => SetField(ref _escrowTableDesc1, value); }

        /// <summary>
        /// Fees Escrow Description 2 [NEWHUD.X811]
        /// </summary>
        public string? EscrowTableDesc2 { get => _escrowTableDesc2; set => SetField(ref _escrowTableDesc2, value); }

        /// <summary>
        /// Fees Escrow Description 3 [NEWHUD.X813]
        /// </summary>
        public string? EscrowTableDesc3 { get => _escrowTableDesc3; set => SetField(ref _escrowTableDesc3, value); }

        /// <summary>
        /// Fees Escrow Description 4 [NEWHUD.X815]
        /// </summary>
        public string? EscrowTableDesc4 { get => _escrowTableDesc4; set => SetField(ref _escrowTableDesc4, value); }

        /// <summary>
        /// Fees Escrow Description 5 [NEWHUD.X817]
        /// </summary>
        public string? EscrowTableDesc5 { get => _escrowTableDesc5; set => SetField(ref _escrowTableDesc5, value); }

        /// <summary>
        /// 2010 Escrow Fee [NEWHUD.X808]
        /// </summary>
        public decimal? EscrowTableFee { get => _escrowTableFee; set => SetField(ref _escrowTableFee, value); }

        /// <summary>
        /// Fees Escrow Fee 1 [NEWHUD.X810]
        /// </summary>
        public decimal? EscrowTableFee1 { get => _escrowTableFee1; set => SetField(ref _escrowTableFee1, value); }

        /// <summary>
        /// Fees Escrow Fee 2 [NEWHUD.X812]
        /// </summary>
        public decimal? EscrowTableFee2 { get => _escrowTableFee2; set => SetField(ref _escrowTableFee2, value); }

        /// <summary>
        /// Fees Escrow Fee 3 [NEWHUD.X814]
        /// </summary>
        public decimal? EscrowTableFee3 { get => _escrowTableFee3; set => SetField(ref _escrowTableFee3, value); }

        /// <summary>
        /// Fees Escrow Fee 4 [NEWHUD.X816]
        /// </summary>
        public decimal? EscrowTableFee4 { get => _escrowTableFee4; set => SetField(ref _escrowTableFee4, value); }

        /// <summary>
        /// Fees Escrow Fee 5 [NEWHUD.X818]
        /// </summary>
        public decimal? EscrowTableFee5 { get => _escrowTableFee5; set => SetField(ref _escrowTableFee5, value); }

        /// <summary>
        /// Fees Escrow Table [ESCROW_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? EscrowTableName { get => _escrowTableName; set => SetField(ref _escrowTableName, value); }

        /// <summary>
        /// ClosingCost FeeVarianceOther
        /// </summary>
        [AllowNull]
        public FeeVarianceOther FeeVarianceOther { get => GetField(ref _feeVarianceOther); set => SetField(ref _feeVarianceOther, value); }

        /// <summary>
        /// ClosingCost FeeVariances
        /// </summary>
        [AllowNull]
        public IList<FeeVariance> FeeVariances { get => GetField(ref _feeVariances); set => SetField(ref _feeVariances, value); }

        /// <summary>
        /// ClosingCost Gfe2010
        /// </summary>
        [AllowNull]
        public Gfe2010 Gfe2010 { get => GetField(ref _gfe2010); set => SetField(ref _gfe2010, value); }

        /// <summary>
        /// ClosingCost Gfe2010Page
        /// </summary>
        [AllowNull]
        public Gfe2010Page Gfe2010Page { get => GetField(ref _gfe2010Page); set => SetField(ref _gfe2010Page, value); }

        /// <summary>
        /// ClosingCost Gfe2010Section
        /// </summary>
        [AllowNull]
        public Gfe2010Section Gfe2010Section { get => GetField(ref _gfe2010Section); set => SetField(ref _gfe2010Section, value); }

        /// <summary>
        /// ClosingCost Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Expenses Calc Hazard Ins Based On [1322]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4)]
        public decimal? ImpoundHazInsRate { get => _impoundHazInsRate; set => SetField(ref _impoundHazInsRate, value); }

        /// <summary>
        /// Expenses Calc MIP Rate [1807]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true)]
        public decimal? ImpoundMortgInsPremRate { get => _impoundMortgInsPremRate; set => SetField(ref _impoundMortgInsPremRate, value); }

        /// <summary>
        /// Expenses Calc MIP Yrly Basis Check Box [1808]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ImpoundMortgInsPremYearlyBasis { get => _impoundMortgInsPremYearlyBasis; set => SetField(ref _impoundMortgInsPremYearlyBasis, value); }

        /// <summary>
        /// Expenses Calc Tax Resrv Rate [1752]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true)]
        public decimal? ImpoundTaxesRate { get => _impoundTaxesRate; set => SetField(ref _impoundTaxesRate, value); }

        /// <summary>
        /// Expenses Calc Hazard Ins Rate [1750]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<ClosingCostImpoundType> ImpoundType1 { get => _impoundType1; set => SetField(ref _impoundType1, value); }

        /// <summary>
        /// Expenses Calc Tax Resrv Based On [1751]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public StringEnumValue<ClosingCostImpoundType> ImpoundType2 { get => _impoundType2; set => SetField(ref _impoundType2, value); }

        /// <summary>
        /// Expenses Calc MIP/PMI Based On [1757]
        /// </summary>
        public StringEnumValue<ImpoundType3> ImpoundType3 { get => _impoundType3; set => SetField(ref _impoundType3, value); }

        /// <summary>
        /// Expenses Calc MIP Based On [1806]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? ImpoundType4 { get => _impoundType4; set => SetField(ref _impoundType4, value); }

        /// <summary>
        /// ClosingCost LoanEstimate1
        /// </summary>
        [AllowNull]
        public LoanEstimate1 LoanEstimate1 { get => GetField(ref _loanEstimate1); set => SetField(ref _loanEstimate1, value); }

        /// <summary>
        /// ClosingCost LoanEstimate2
        /// </summary>
        [AllowNull]
        public LoanEstimate2 LoanEstimate2 { get => GetField(ref _loanEstimate2); set => SetField(ref _loanEstimate2, value); }

        /// <summary>
        /// ClosingCost LoanEstimate3
        /// </summary>
        [AllowNull]
        public LoanEstimate3 LoanEstimate3 { get => GetField(ref _loanEstimate3); set => SetField(ref _loanEstimate3, value); }

        /// <summary>
        /// Expenses Proposed Monthly Hazard Ins [1780]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ProposedMonthlyHazardInsurance { get => _proposedMonthlyHazardInsurance; set => SetField(ref _proposedMonthlyHazardInsurance, value); }

        /// <summary>
        /// Expenses Proposed Monthly Mort Ins [1781]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? ProposedMonthlyMortgageInsurance { get => _proposedMonthlyMortgageInsurance; set => SetField(ref _proposedMonthlyMortgageInsurance, value); }

        /// <summary>
        /// Fees Section 1000 Borrower Paid Total Amount [NEWHUD.X1719]
        /// </summary>
        public decimal? Section1000BorrowerPaidTotalAmount { get => _section1000BorrowerPaidTotalAmount; set => SetField(ref _section1000BorrowerPaidTotalAmount, value); }

        /// <summary>
        /// Fees Section 1000 Seller Paid Total Amount [NEWHUD.X1713]
        /// </summary>
        public decimal? Section1000SellerPaidTotalAmount { get => _section1000SellerPaidTotalAmount; set => SetField(ref _section1000SellerPaidTotalAmount, value); }

        /// <summary>
        /// Fees Line 1102 Borr [NEWHUD.X645]
        /// </summary>
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get => _settlementClosingFeeNewHudBorPaidAmount; set => SetField(ref _settlementClosingFeeNewHudBorPaidAmount, value); }

        /// <summary>
        /// Fees Line 1102 Seller [NEWHUD.X782]
        /// </summary>
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get => _settlementClosingFeeNewHudSelPaidAmount; set => SetField(ref _settlementClosingFeeNewHudSelPaidAmount, value); }

        /// <summary>
        /// File Contacts Title Co Name [411]
        /// </summary>
        public string? TitleCompanyName { get => _titleCompanyName; set => SetField(ref _titleCompanyName, value); }

        /// <summary>
        /// Fees Line 1103 Seller [NEWHUD.X783]
        /// </summary>
        public decimal? TitleExaminationNewHudSelPaidAmount { get => _titleExaminationNewHudSelPaidAmount; set => SetField(ref _titleExaminationNewHudSelPaidAmount, value); }

        /// <summary>
        /// 2010 Fees Title Table [2010TITLE_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TitleTable2010Name { get => _titleTable2010Name; set => SetField(ref _titleTable2010Name, value); }

        /// <summary>
        /// Fees Title Table [TITLE_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public string? TitleTableName { get => _titleTableName; set => SetField(ref _titleTableName, value); }

        /// <summary>
        /// Fees Total Additional Items 1 - Bor Paid [1671]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid1 { get => _totalForBorPaid1; set => SetField(ref _totalForBorPaid1, value); }

        /// <summary>
        /// Fees Total Additional Items 2 - Bor Paid [1673]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid2 { get => _totalForBorPaid2; set => SetField(ref _totalForBorPaid2, value); }

        /// <summary>
        /// Fees Total Additional Items 3 - Bor Paid [1675]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid3 { get => _totalForBorPaid3; set => SetField(ref _totalForBorPaid3, value); }

        /// <summary>
        /// MLDS Total Bor Paid Additional Items 4 [RE88395.X213]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid4 { get => _totalForBorPaid4; set => SetField(ref _totalForBorPaid4, value); }

        /// <summary>
        /// MLDS Total Bor Paid Additional Items 5 [RE88395.X223]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid5 { get => _totalForBorPaid5; set => SetField(ref _totalForBorPaid5, value); }

        /// <summary>
        /// MLDS Total Bor Paid Additional Items 6 [RE88395.X233]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForBorPaid6 { get => _totalForBorPaid6; set => SetField(ref _totalForBorPaid6, value); }

        /// <summary>
        /// Fees Total Additional Items 1 - Seller [1672]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid1 { get => _totalForSellerPaid1; set => SetField(ref _totalForSellerPaid1, value); }

        /// <summary>
        /// Fees Total Additional Items 2 - Seller [1674]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid2 { get => _totalForSellerPaid2; set => SetField(ref _totalForSellerPaid2, value); }

        /// <summary>
        /// Fees Total Additional Items 3 - Seller [1676]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid3 { get => _totalForSellerPaid3; set => SetField(ref _totalForSellerPaid3, value); }

        /// <summary>
        /// MLDS Total Seller Paid Additional Items 4 [RE88395.X214]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid4 { get => _totalForSellerPaid4; set => SetField(ref _totalForSellerPaid4, value); }

        /// <summary>
        /// MLDS Total Seller Paid Additional Items 5 [RE88395.X224]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid5 { get => _totalForSellerPaid5; set => SetField(ref _totalForSellerPaid5, value); }

        /// <summary>
        /// MLDS Total Seller Paid Additional Items 6 [RE88395.X234]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? TotalForSellerPaid6 { get => _totalForSellerPaid6; set => SetField(ref _totalForSellerPaid6, value); }
    }
}