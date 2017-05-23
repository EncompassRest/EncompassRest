using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingCost
    {
        public JsonNullable<decimal?> AdjustmentFactor { get; set; }
        public string AggregateAdjustmentFwbc { get; set; }
        public JsonNullable<decimal?> BorrowerPaidDiscountPointsTotalAmount { get; set; }
        public JsonNullable<decimal?> BrokerCommissionBasedPrice { get; set; }
        public JsonNullable<decimal?> BrokerCommissionBasedUnitPercentage { get; set; }
        public JsonNullable<decimal?> BrokerCommissionBasedUnitPrice { get; set; }
        public string ClosingCostProgram { get; set; }
        public string ClosingCostScenarioXml { get; set; }
        public ClosingDisclosure1 ClosingDisclosure1 { get; set; }
        public ClosingDisclosure2 ClosingDisclosure2 { get; set; }
        public ClosingDisclosure3 ClosingDisclosure3 { get; set; }
        public ClosingDisclosure4 ClosingDisclosure4 { get; set; }
        public ClosingDisclosure5 ClosingDisclosure5 { get; set; }
        public string EscrowCompanyName { get; set; }
        public string EscrowTableDesc1 { get; set; }
        public string EscrowTableDesc2 { get; set; }
        public string EscrowTableDesc3 { get; set; }
        public string EscrowTableDesc4 { get; set; }
        public string EscrowTableDesc5 { get; set; }
        public JsonNullable<decimal?> EscrowTableFee { get; set; }
        public JsonNullable<decimal?> EscrowTableFee1 { get; set; }
        public JsonNullable<decimal?> EscrowTableFee2 { get; set; }
        public JsonNullable<decimal?> EscrowTableFee3 { get; set; }
        public JsonNullable<decimal?> EscrowTableFee4 { get; set; }
        public JsonNullable<decimal?> EscrowTableFee5 { get; set; }
        public string EscrowTableName { get; set; }
        public FeeVarianceOther FeeVarianceOther { get; set; }
        public JsonNullable<List<FeeVariance>> FeeVariances { get; set; }
        public Gfe2010 Gfe2010 { get; set; }
        public Gfe2010Page Gfe2010Page { get; set; }
        public Gfe2010Section Gfe2010Section { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> ImpoundHazInsRate { get; set; }
        public JsonNullable<decimal?> ImpoundMortgInsPremRate { get; set; }
        public string ImpoundMortgInsPremYearlyBasis { get; set; }
        public JsonNullable<decimal?> ImpoundTaxesRate { get; set; }
        public string ImpoundType1 { get; set; }
        public string ImpoundType2 { get; set; }
        public string ImpoundType3 { get; set; }
        public string ImpoundType4 { get; set; }
        public LoanEstimate1 LoanEstimate1 { get; set; }
        public LoanEstimate2 LoanEstimate2 { get; set; }
        public LoanEstimate3 LoanEstimate3 { get; set; }
        public JsonNullable<decimal?> ProposedMonthlyHazardInsurance { get; set; }
        public JsonNullable<decimal?> ProposedMonthlyMortgageInsurance { get; set; }
        public JsonNullable<decimal?> Section1000BorrowerPaidTotalAmount { get; set; }
        public JsonNullable<decimal?> Section1000SellerPaidTotalAmount { get; set; }
        public JsonNullable<decimal?> SettlementClosingFeeNewHudBorPaidAmount { get; set; }
        public JsonNullable<decimal?> SettlementClosingFeeNewHudSelPaidAmount { get; set; }
        public string TitleCompanyName { get; set; }
        public JsonNullable<decimal?> TitleExaminationNewHudSelPaidAmount { get; set; }
        public string TitleTable2010Name { get; set; }
        public string TitleTableName { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid1 { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid2 { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid3 { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid4 { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid5 { get; set; }
        public JsonNullable<decimal?> TotalForBorPaid6 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid1 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid2 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid3 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid4 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid5 { get; set; }
        public JsonNullable<decimal?> TotalForSellerPaid6 { get; set; }
    }
}