using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassRest.Data
{
    public class ClosingCost
    {
        public string titleCompanyName { get; set; }
        public string escrowCompanyName { get; set; }
        public decimal? adjustmentFactor { get; set; }
        public decimal? impoundHazInsRate { get; set; }
        public decimal? totalForBorPaid1 { get; set; }
        public decimal? totalForSellerPaid1 { get; set; }
        public decimal? totalForBorPaid2 { get; set; }
        public decimal? totalForSellerPaid2 { get; set; }
        public decimal? totalForBorPaid3 { get; set; }
        public decimal? totalForSellerPaid3 { get; set; }
        public string impoundType1 { get; set; }
        public string impoundType2 { get; set; }
        public decimal? impoundTaxesRate { get; set; }
        public string impoundType3 { get; set; }
        public decimal? borrowerPaidDiscountPointsTotalAmount { get; set; }
        public decimal? proposedMonthlyHazardInsurance { get; set; }
        public decimal? proposedMonthlyMortgageInsurance { get; set; }
        public string closingCostProgram { get; set; }
        public string impoundType4 { get; set; }
        public decimal? impoundMortgInsPremRate { get; set; }
        public string impoundMortgInsPremYearlyBasis { get; set; }
        public string escrowTableName { get; set; }
        public decimal? brokerCommissionBasedUnitPercentage { get; set; }
        public decimal? brokerCommissionBasedPrice { get; set; }
        public decimal? brokerCommissionBasedUnitPrice { get; set; }
        public decimal? totalForBorPaid4 { get; set; }
        public decimal? totalForSellerPaid4 { get; set; }
        public decimal? totalForBorPaid5 { get; set; }
        public decimal? totalForSellerPaid5 { get; set; }
        public decimal? totalForBorPaid6 { get; set; }
        public decimal? totalForSellerPaid6 { get; set; }
        public string aggregateAdjustmentFwbc { get; set; }
        public string titleTableName { get; set; }
        public string titleTable2010Name { get; set; }
        public Gfe2010 gfe2010 { get; set; }
        public Loan loan { get; set; }
        public Gfe2010Section gfe2010Section { get; set; }
        public Gfe2010Page gfe2010Page { get; set; }
        public decimal? settlementClosingFeeNewHudBorPaidAmount { get; set; }
        public decimal? settlementClosingFeeNewHudSelPaidAmount { get; set; }
        public decimal? titleExaminationNewHudSelPaidAmount { get; set; }
        public decimal? escrowTableFee { get; set; }
        public string escrowTableDesc1 { get; set; }
        public decimal? escrowTableFee1 { get; set; }
        public string escrowTableDesc2 { get; set; }
        public decimal? escrowTableFee2 { get; set; }
        public string escrowTableDesc3 { get; set; }
        public decimal? escrowTableFee3 { get; set; }
        public string escrowTableDesc4 { get; set; }
        public decimal? escrowTableFee4 { get; set; }
        public string escrowTableDesc5 { get; set; }
        public decimal? escrowTableFee5 { get; set; }
        public decimal? section1000SellerPaidTotalAmount { get; set; }
        public decimal? section1000BorrowerPaidTotalAmount { get; set; }
        public ClosingDisclosure1 closingDisclosure1 { get; set; }
        public ClosingDisclosure2 closingDisclosure2 { get; set; }
        public ClosingDisclosure3 closingDisclosure3 { get; set; }
        public LoanEstimate2 loanEstimate2 { get; set; }
        public ClosingDisclosure4 closingDisclosure4 { get; set; }
        public ClosingDisclosure5 closingDisclosure5 { get; set; }
        public LoanEstimate1 loanEstimate1 { get; set; }
        public LoanEstimate3 loanEstimate3 { get; set; }
        public FeeVarianceOther feeVarianceOther { get; set; }
        public List<FeeVariance> feeVariances { get; set; }
        public string id { get; set; }
        public string closingCostScenarioXml { get; set; }

    }
}
