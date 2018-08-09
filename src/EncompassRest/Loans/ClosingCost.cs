using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ClosingCost
    /// </summary>
    public sealed partial class ClosingCost : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustmentFactor;
        /// <summary>
        /// Insurance Mtg Ins Periodic Factor 1 [1199]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_6, Description = "Insurance Mtg Ins Periodic Factor 1")]
        public decimal? AdjustmentFactor { get => _adjustmentFactor; set => _adjustmentFactor = value; }
        private DirtyValue<string> _aggregateAdjustmentFwbc;
        /// <summary>
        /// Funding Aggregate Adjustment Checked Borrower [SYS.X545]
        /// </summary>
        [LoanFieldProperty(Description = "Funding Aggregate Adjustment Checked Borrower")]
        public string AggregateAdjustmentFwbc { get => _aggregateAdjustmentFwbc; set => _aggregateAdjustmentFwbc = value; }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        /// <summary>
        /// Loan Details Bor Paid Discount Points Total [1776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Loan Details Bor Paid Discount Points Total")]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => _borrowerPaidDiscountPointsTotalAmount = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedPrice;
        /// <summary>
        /// HUD1 Total Sales Broker Comm [L210]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD1 Total Sales Broker Comm")]
        public decimal? BrokerCommissionBasedPrice { get => _brokerCommissionBasedPrice; set => _brokerCommissionBasedPrice = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedUnitPercentage;
        /// <summary>
        /// HUD1 Total Sales Broker Comm Based on % [L209]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "HUD1 Total Sales Broker Comm Based on %")]
        public decimal? BrokerCommissionBasedUnitPercentage { get => _brokerCommissionBasedUnitPercentage; set => _brokerCommissionBasedUnitPercentage = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedUnitPrice;
        /// <summary>
        /// HUD1 Total Sales Broker Comm Based on Amt [L725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD1 Total Sales Broker Comm Based on Amt")]
        public decimal? BrokerCommissionBasedUnitPrice { get => _brokerCommissionBasedUnitPrice; set => _brokerCommissionBasedUnitPrice = value; }
        private DirtyValue<string> _closingCostProgram;
        /// <summary>
        /// Loan Info Closing Cost Program [1805]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Loan Info Closing Cost Program")]
        public string ClosingCostProgram { get => _closingCostProgram; set => _closingCostProgram = value; }
        private DirtyValue<string> _closingCostScenarioXml;
        /// <summary>
        /// ClosingCost ClosingCostScenarioXml
        /// </summary>
        public string ClosingCostScenarioXml { get => _closingCostScenarioXml; set => _closingCostScenarioXml = value; }
        private ClosingDisclosure1 _closingDisclosure1;
        /// <summary>
        /// ClosingCost ClosingDisclosure1
        /// </summary>
        public ClosingDisclosure1 ClosingDisclosure1 { get => _closingDisclosure1 ?? (_closingDisclosure1 = new ClosingDisclosure1()); set => _closingDisclosure1 = value; }
        private ClosingDisclosure2 _closingDisclosure2;
        /// <summary>
        /// ClosingCost ClosingDisclosure2
        /// </summary>
        public ClosingDisclosure2 ClosingDisclosure2 { get => _closingDisclosure2 ?? (_closingDisclosure2 = new ClosingDisclosure2()); set => _closingDisclosure2 = value; }
        private ClosingDisclosure3 _closingDisclosure3;
        /// <summary>
        /// ClosingCost ClosingDisclosure3
        /// </summary>
        public ClosingDisclosure3 ClosingDisclosure3 { get => _closingDisclosure3 ?? (_closingDisclosure3 = new ClosingDisclosure3()); set => _closingDisclosure3 = value; }
        private ClosingDisclosure4 _closingDisclosure4;
        /// <summary>
        /// ClosingCost ClosingDisclosure4
        /// </summary>
        public ClosingDisclosure4 ClosingDisclosure4 { get => _closingDisclosure4 ?? (_closingDisclosure4 = new ClosingDisclosure4()); set => _closingDisclosure4 = value; }
        private ClosingDisclosure5 _closingDisclosure5;
        /// <summary>
        /// ClosingCost ClosingDisclosure5
        /// </summary>
        public ClosingDisclosure5 ClosingDisclosure5 { get => _closingDisclosure5 ?? (_closingDisclosure5 = new ClosingDisclosure5()); set => _closingDisclosure5 = value; }
        private DirtyValue<decimal?> _disclosedSalesPrice;
        /// <summary>
        /// Disclosed Sales Price [L726]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Disclosed Sales Price")]
        public decimal? DisclosedSalesPrice { get => _disclosedSalesPrice; set => _disclosedSalesPrice = value; }
        private DirtyValue<string> _escrowCompanyName;
        /// <summary>
        /// File Contacts Escrow Co Name [610]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Escrow Co Name")]
        public string EscrowCompanyName { get => _escrowCompanyName; set => _escrowCompanyName = value; }
        private DirtyValue<string> _escrowTableDesc1;
        /// <summary>
        /// Fees Escrow Description 1 [NEWHUD.X809]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Escrow Description 1")]
        public string EscrowTableDesc1 { get => _escrowTableDesc1; set => _escrowTableDesc1 = value; }
        private DirtyValue<string> _escrowTableDesc2;
        /// <summary>
        /// Fees Escrow Description 2 [NEWHUD.X811]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Escrow Description 2")]
        public string EscrowTableDesc2 { get => _escrowTableDesc2; set => _escrowTableDesc2 = value; }
        private DirtyValue<string> _escrowTableDesc3;
        /// <summary>
        /// Fees Escrow Description 3 [NEWHUD.X813]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Escrow Description 3")]
        public string EscrowTableDesc3 { get => _escrowTableDesc3; set => _escrowTableDesc3 = value; }
        private DirtyValue<string> _escrowTableDesc4;
        /// <summary>
        /// Fees Escrow Description 4 [NEWHUD.X815]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Escrow Description 4")]
        public string EscrowTableDesc4 { get => _escrowTableDesc4; set => _escrowTableDesc4 = value; }
        private DirtyValue<string> _escrowTableDesc5;
        /// <summary>
        /// Fees Escrow Description 5 [NEWHUD.X817]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Escrow Description 5")]
        public string EscrowTableDesc5 { get => _escrowTableDesc5; set => _escrowTableDesc5 = value; }
        private DirtyValue<decimal?> _escrowTableFee;
        /// <summary>
        /// 2010 Escrow Fee [NEWHUD.X808]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "2010 Escrow Fee")]
        public decimal? EscrowTableFee { get => _escrowTableFee; set => _escrowTableFee = value; }
        private DirtyValue<decimal?> _escrowTableFee1;
        /// <summary>
        /// Fees Escrow Fee 1 [NEWHUD.X810]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Escrow Fee 1")]
        public decimal? EscrowTableFee1 { get => _escrowTableFee1; set => _escrowTableFee1 = value; }
        private DirtyValue<decimal?> _escrowTableFee2;
        /// <summary>
        /// Fees Escrow Fee 2 [NEWHUD.X812]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Escrow Fee 2")]
        public decimal? EscrowTableFee2 { get => _escrowTableFee2; set => _escrowTableFee2 = value; }
        private DirtyValue<decimal?> _escrowTableFee3;
        /// <summary>
        /// Fees Escrow Fee 3 [NEWHUD.X814]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Escrow Fee 3")]
        public decimal? EscrowTableFee3 { get => _escrowTableFee3; set => _escrowTableFee3 = value; }
        private DirtyValue<decimal?> _escrowTableFee4;
        /// <summary>
        /// Fees Escrow Fee 4 [NEWHUD.X816]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Escrow Fee 4")]
        public decimal? EscrowTableFee4 { get => _escrowTableFee4; set => _escrowTableFee4 = value; }
        private DirtyValue<decimal?> _escrowTableFee5;
        /// <summary>
        /// Fees Escrow Fee 5 [NEWHUD.X818]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Escrow Fee 5")]
        public decimal? EscrowTableFee5 { get => _escrowTableFee5; set => _escrowTableFee5 = value; }
        private DirtyValue<string> _escrowTableName;
        /// <summary>
        /// Fees Escrow Table [ESCROW_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fees Escrow Table")]
        public string EscrowTableName { get => _escrowTableName; set => _escrowTableName = value; }
        private FeeVarianceOther _feeVarianceOther;
        /// <summary>
        /// ClosingCost FeeVarianceOther
        /// </summary>
        public FeeVarianceOther FeeVarianceOther { get => _feeVarianceOther ?? (_feeVarianceOther = new FeeVarianceOther()); set => _feeVarianceOther = value; }
        private DirtyList<FeeVariance> _feeVariances;
        /// <summary>
        /// ClosingCost FeeVariances
        /// </summary>
        public IList<FeeVariance> FeeVariances { get => _feeVariances ?? (_feeVariances = new DirtyList<FeeVariance>()); set => _feeVariances = new DirtyList<FeeVariance>(value); }
        private Gfe2010 _gfe2010;
        /// <summary>
        /// ClosingCost Gfe2010
        /// </summary>
        public Gfe2010 Gfe2010 { get => _gfe2010 ?? (_gfe2010 = new Gfe2010()); set => _gfe2010 = value; }
        private Gfe2010Page _gfe2010Page;
        /// <summary>
        /// ClosingCost Gfe2010Page
        /// </summary>
        public Gfe2010Page Gfe2010Page { get => _gfe2010Page ?? (_gfe2010Page = new Gfe2010Page()); set => _gfe2010Page = value; }
        private Gfe2010Section _gfe2010Section;
        /// <summary>
        /// ClosingCost Gfe2010Section
        /// </summary>
        public Gfe2010Section Gfe2010Section { get => _gfe2010Section ?? (_gfe2010Section = new Gfe2010Section()); set => _gfe2010Section = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ClosingCost Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _impoundHazInsRate;
        /// <summary>
        /// Expenses Calc Hazard Ins Based On [1322]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, Description = "Expenses Calc Hazard Ins Based On")]
        public decimal? ImpoundHazInsRate { get => _impoundHazInsRate; set => _impoundHazInsRate = value; }
        private DirtyValue<decimal?> _impoundMortgInsPremRate;
        /// <summary>
        /// Expenses Calc MIP Rate [1807]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true, Description = "Expenses Calc MIP Rate")]
        public decimal? ImpoundMortgInsPremRate { get => _impoundMortgInsPremRate; set => _impoundMortgInsPremRate = value; }
        private DirtyValue<string> _impoundMortgInsPremYearlyBasis;
        /// <summary>
        /// Expenses Calc MIP Yrly Basis Check Box [1808]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc MIP Yrly Basis Check Box")]
        public string ImpoundMortgInsPremYearlyBasis { get => _impoundMortgInsPremYearlyBasis; set => _impoundMortgInsPremYearlyBasis = value; }
        private DirtyValue<decimal?> _impoundTaxesRate;
        /// <summary>
        /// Expenses Calc Tax Resrv Rate [1752]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_4, ReadOnly = true, Description = "Expenses Calc Tax Resrv Rate")]
        public decimal? ImpoundTaxesRate { get => _impoundTaxesRate; set => _impoundTaxesRate = value; }
        private DirtyValue<StringEnumValue<ClosingCostImpoundType>> _impoundType1;
        /// <summary>
        /// Expenses Calc Hazard Ins Rate [1750]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc Hazard Ins Rate")]
        public StringEnumValue<ClosingCostImpoundType> ImpoundType1 { get => _impoundType1; set => _impoundType1 = value; }
        private DirtyValue<StringEnumValue<ClosingCostImpoundType>> _impoundType2;
        /// <summary>
        /// Expenses Calc Tax Resrv Based On [1751]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc Tax Resrv Based On")]
        public StringEnumValue<ClosingCostImpoundType> ImpoundType2 { get => _impoundType2; set => _impoundType2 = value; }
        private DirtyValue<StringEnumValue<ImpoundType3>> _impoundType3;
        /// <summary>
        /// Expenses Calc MIP/PMI Based On [1757]
        /// </summary>
        [LoanFieldProperty(Description = "Expenses Calc MIP/PMI Based On")]
        public StringEnumValue<ImpoundType3> ImpoundType3 { get => _impoundType3; set => _impoundType3 = value; }
        private DirtyValue<string> _impoundType4;
        /// <summary>
        /// Expenses Calc MIP Based On [1806]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Expenses Calc MIP Based On")]
        public string ImpoundType4 { get => _impoundType4; set => _impoundType4 = value; }
        private LoanEstimate1 _loanEstimate1;
        /// <summary>
        /// ClosingCost LoanEstimate1
        /// </summary>
        public LoanEstimate1 LoanEstimate1 { get => _loanEstimate1 ?? (_loanEstimate1 = new LoanEstimate1()); set => _loanEstimate1 = value; }
        private LoanEstimate2 _loanEstimate2;
        /// <summary>
        /// ClosingCost LoanEstimate2
        /// </summary>
        public LoanEstimate2 LoanEstimate2 { get => _loanEstimate2 ?? (_loanEstimate2 = new LoanEstimate2()); set => _loanEstimate2 = value; }
        private LoanEstimate3 _loanEstimate3;
        /// <summary>
        /// ClosingCost LoanEstimate3
        /// </summary>
        public LoanEstimate3 LoanEstimate3 { get => _loanEstimate3 ?? (_loanEstimate3 = new LoanEstimate3()); set => _loanEstimate3 = value; }
        private DirtyValue<decimal?> _proposedMonthlyHazardInsurance;
        /// <summary>
        /// Expenses Proposed Monthly Hazard Ins [1780]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Proposed Monthly Hazard Ins")]
        public decimal? ProposedMonthlyHazardInsurance { get => _proposedMonthlyHazardInsurance; set => _proposedMonthlyHazardInsurance = value; }
        private DirtyValue<decimal?> _proposedMonthlyMortgageInsurance;
        /// <summary>
        /// Expenses Proposed Monthly Mort Ins [1781]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Expenses Proposed Monthly Mort Ins")]
        public decimal? ProposedMonthlyMortgageInsurance { get => _proposedMonthlyMortgageInsurance; set => _proposedMonthlyMortgageInsurance = value; }
        private DirtyValue<decimal?> _section1000BorrowerPaidTotalAmount;
        /// <summary>
        /// Fees Section 1000 Borrower Paid Total Amount [NEWHUD.X1719]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Section 1000 Borrower Paid Total Amount")]
        public decimal? Section1000BorrowerPaidTotalAmount { get => _section1000BorrowerPaidTotalAmount; set => _section1000BorrowerPaidTotalAmount = value; }
        private DirtyValue<decimal?> _section1000SellerPaidTotalAmount;
        /// <summary>
        /// Fees Section 1000 Seller Paid Total Amount [NEWHUD.X1713]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Section 1000 Seller Paid Total Amount")]
        public decimal? Section1000SellerPaidTotalAmount { get => _section1000SellerPaidTotalAmount; set => _section1000SellerPaidTotalAmount = value; }
        private DirtyValue<decimal?> _settlementClosingFeeNewHudBorPaidAmount;
        /// <summary>
        /// Fees Line 1102 Borr [NEWHUD.X645]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1102 Borr")]
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get => _settlementClosingFeeNewHudBorPaidAmount; set => _settlementClosingFeeNewHudBorPaidAmount = value; }
        private DirtyValue<decimal?> _settlementClosingFeeNewHudSelPaidAmount;
        /// <summary>
        /// Fees Line 1102 Seller [NEWHUD.X782]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1102 Seller")]
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get => _settlementClosingFeeNewHudSelPaidAmount; set => _settlementClosingFeeNewHudSelPaidAmount = value; }
        private DirtyValue<string> _titleCompanyName;
        /// <summary>
        /// File Contacts Title Co Name [411]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Title Co Name")]
        public string TitleCompanyName { get => _titleCompanyName; set => _titleCompanyName = value; }
        private DirtyValue<decimal?> _titleExaminationNewHudSelPaidAmount;
        /// <summary>
        /// Fees Line 1103 Seller [NEWHUD.X783]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1103 Seller")]
        public decimal? TitleExaminationNewHudSelPaidAmount { get => _titleExaminationNewHudSelPaidAmount; set => _titleExaminationNewHudSelPaidAmount = value; }
        private DirtyValue<string> _titleTable2010Name;
        /// <summary>
        /// 2010 Fees Title Table [2010TITLE_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "2010 Fees Title Table")]
        public string TitleTable2010Name { get => _titleTable2010Name; set => _titleTable2010Name = value; }
        private DirtyValue<string> _titleTableName;
        /// <summary>
        /// Fees Title Table [TITLE_TABLE]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fees Title Table")]
        public string TitleTableName { get => _titleTableName; set => _titleTableName = value; }
        private DirtyValue<decimal?> _totalForBorPaid1;
        /// <summary>
        /// Fees Total Additional Items 1 - Bor Paid [1671]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 1 - Bor Paid")]
        public decimal? TotalForBorPaid1 { get => _totalForBorPaid1; set => _totalForBorPaid1 = value; }
        private DirtyValue<decimal?> _totalForBorPaid2;
        /// <summary>
        /// Fees Total Additional Items 2 - Bor Paid [1673]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 2 - Bor Paid")]
        public decimal? TotalForBorPaid2 { get => _totalForBorPaid2; set => _totalForBorPaid2 = value; }
        private DirtyValue<decimal?> _totalForBorPaid3;
        /// <summary>
        /// Fees Total Additional Items 3 - Bor Paid [1675]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 3 - Bor Paid")]
        public decimal? TotalForBorPaid3 { get => _totalForBorPaid3; set => _totalForBorPaid3 = value; }
        private DirtyValue<decimal?> _totalForBorPaid4;
        /// <summary>
        /// MLDS Total Bor Paid Additional Items 4 [RE88395.X213]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Bor Paid Additional Items 4")]
        public decimal? TotalForBorPaid4 { get => _totalForBorPaid4; set => _totalForBorPaid4 = value; }
        private DirtyValue<decimal?> _totalForBorPaid5;
        /// <summary>
        /// MLDS Total Bor Paid Additional Items 5 [RE88395.X223]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Bor Paid Additional Items 5")]
        public decimal? TotalForBorPaid5 { get => _totalForBorPaid5; set => _totalForBorPaid5 = value; }
        private DirtyValue<decimal?> _totalForBorPaid6;
        /// <summary>
        /// MLDS Total Bor Paid Additional Items 6 [RE88395.X233]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Bor Paid Additional Items 6")]
        public decimal? TotalForBorPaid6 { get => _totalForBorPaid6; set => _totalForBorPaid6 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid1;
        /// <summary>
        /// Fees Total Additional Items 1 - Seller [1672]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 1 - Seller")]
        public decimal? TotalForSellerPaid1 { get => _totalForSellerPaid1; set => _totalForSellerPaid1 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid2;
        /// <summary>
        /// Fees Total Additional Items 2 - Seller [1674]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 2 - Seller")]
        public decimal? TotalForSellerPaid2 { get => _totalForSellerPaid2; set => _totalForSellerPaid2 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid3;
        /// <summary>
        /// Fees Total Additional Items 3 - Seller [1676]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Total Additional Items 3 - Seller")]
        public decimal? TotalForSellerPaid3 { get => _totalForSellerPaid3; set => _totalForSellerPaid3 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid4;
        /// <summary>
        /// MLDS Total Seller Paid Additional Items 4 [RE88395.X214]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Seller Paid Additional Items 4")]
        public decimal? TotalForSellerPaid4 { get => _totalForSellerPaid4; set => _totalForSellerPaid4 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid5;
        /// <summary>
        /// MLDS Total Seller Paid Additional Items 5 [RE88395.X224]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Seller Paid Additional Items 5")]
        public decimal? TotalForSellerPaid5 { get => _totalForSellerPaid5; set => _totalForSellerPaid5 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid6;
        /// <summary>
        /// MLDS Total Seller Paid Additional Items 6 [RE88395.X234]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "MLDS Total Seller Paid Additional Items 6")]
        public decimal? TotalForSellerPaid6 { get => _totalForSellerPaid6; set => _totalForSellerPaid6 = value; }
    }
}