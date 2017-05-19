using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class ClosingCost
    {
        public string TitleCompanyName { get; set; }
        public string EscrowCompanyName { get; set; }
        public decimal? AdjustmentFactor { get; set; }
        public decimal? ImpoundHazInsRate { get; set; }
        public decimal? TotalForBorPaid1 { get; set; }
        public decimal? TotalForSellerPaid1 { get; set; }
        public decimal? TotalForBorPaid2 { get; set; }
        public decimal? TotalForSellerPaid2 { get; set; }
        public decimal? TotalForBorPaid3 { get; set; }
        public decimal? TotalForSellerPaid3 { get; set; }
        public string ImpoundType1 { get; set; }
        public string ImpoundType2 { get; set; }
        public decimal? ImpoundTaxesRate { get; set; }
        public string ImpoundType3 { get; set; }
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get; set; }
        public decimal? ProposedMonthlyHazardInsurance { get; set; }
        public decimal? ProposedMonthlyMortgageInsurance { get; set; }
        public string ClosingCostProgram { get; set; }
        public string ImpoundType4 { get; set; }
        public decimal? ImpoundMortgInsPremRate { get; set; }
        public string ImpoundMortgInsPremYearlyBasis { get; set; }
        public string EscrowTableName { get; set; }
        public decimal? BrokerCommissionBasedUnitPercentage { get; set; }
        public decimal? BrokerCommissionBasedPrice { get; set; }
        public decimal? BrokerCommissionBasedUnitPrice { get; set; }
        public decimal? TotalForBorPaid4 { get; set; }
        public decimal? TotalForSellerPaid4 { get; set; }
        public decimal? TotalForBorPaid5 { get; set; }
        public decimal? TotalForSellerPaid5 { get; set; }
        public decimal? TotalForBorPaid6 { get; set; }
        public decimal? TotalForSellerPaid6 { get; set; }
        public string AggregateAdjustmentFwbc { get; set; }
        public string TitleTableName { get; set; }
        public string TitleTable2010Name { get; set; }
        public Gfe2010 Gfe2010 { get; set; }
        public Gfe2010Section Gfe2010Section { get; set; }
        public Gfe2010Page Gfe2010Page { get; set; }
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get; set; }
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get; set; }
        public decimal? TitleExaminationNewHudSelPaidAmount { get; set; }
        public decimal? EscrowTableFee { get; set; }
        public string EscrowTableDesc1 { get; set; }
        public decimal? EscrowTableFee1 { get; set; }
        public string EscrowTableDesc2 { get; set; }
        public decimal? EscrowTableFee2 { get; set; }
        public string EscrowTableDesc3 { get; set; }
        public decimal? EscrowTableFee3 { get; set; }
        public string EscrowTableDesc4 { get; set; }
        public decimal? EscrowTableFee4 { get; set; }
        public string EscrowTableDesc5 { get; set; }
        public decimal? EscrowTableFee5 { get; set; }
        public decimal? Section1000SellerPaidTotalAmount { get; set; }
        public decimal? Section1000BorrowerPaidTotalAmount { get; set; }
        public ClosingDisclosure1 ClosingDisclosure1 { get; set; }
        public ClosingDisclosure2 ClosingDisclosure2 { get; set; }
        public ClosingDisclosure3 ClosingDisclosure3 { get; set; }
        public LoanEstimate2 LoanEstimate2 { get; set; }
        public ClosingDisclosure4 ClosingDisclosure4 { get; set; }
        public ClosingDisclosure5 ClosingDisclosure5 { get; set; }
        public LoanEstimate1 LoanEstimate1 { get; set; }
        public LoanEstimate3 LoanEstimate3 { get; set; }
        public FeeVarianceOther FeeVarianceOther { get; set; }
        public List<FeeVariance> FeeVariances { get; set; }
        public string Id { get; set; }
        public string ClosingCostScenarioXml { get; set; }
    }
}