using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingCost : IClean
    {
        private Value<decimal?> _adjustmentFactor;
        public decimal? AdjustmentFactor { get { return _adjustmentFactor; } set { _adjustmentFactor = value; } }
        private Value<string> _aggregateAdjustmentFwbc;
        public string AggregateAdjustmentFwbc { get { return _aggregateAdjustmentFwbc; } set { _aggregateAdjustmentFwbc = value; } }
        private Value<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get { return _borrowerPaidDiscountPointsTotalAmount; } set { _borrowerPaidDiscountPointsTotalAmount = value; } }
        private Value<decimal?> _brokerCommissionBasedPrice;
        public decimal? BrokerCommissionBasedPrice { get { return _brokerCommissionBasedPrice; } set { _brokerCommissionBasedPrice = value; } }
        private Value<decimal?> _brokerCommissionBasedUnitPercentage;
        public decimal? BrokerCommissionBasedUnitPercentage { get { return _brokerCommissionBasedUnitPercentage; } set { _brokerCommissionBasedUnitPercentage = value; } }
        private Value<decimal?> _brokerCommissionBasedUnitPrice;
        public decimal? BrokerCommissionBasedUnitPrice { get { return _brokerCommissionBasedUnitPrice; } set { _brokerCommissionBasedUnitPrice = value; } }
        private Value<string> _closingCostProgram;
        public string ClosingCostProgram { get { return _closingCostProgram; } set { _closingCostProgram = value; } }
        private Value<string> _closingCostScenarioXml;
        public string ClosingCostScenarioXml { get { return _closingCostScenarioXml; } set { _closingCostScenarioXml = value; } }
        public ClosingDisclosure1 ClosingDisclosure1 { get; set; }
        public ClosingDisclosure2 ClosingDisclosure2 { get; set; }
        public ClosingDisclosure3 ClosingDisclosure3 { get; set; }
        public ClosingDisclosure4 ClosingDisclosure4 { get; set; }
        public ClosingDisclosure5 ClosingDisclosure5 { get; set; }
        private Value<decimal?> _disclosedSalesPrice;
        public decimal? DisclosedSalesPrice { get { return _disclosedSalesPrice; } set { _disclosedSalesPrice = value; } }
        private Value<string> _escrowCompanyName;
        public string EscrowCompanyName { get { return _escrowCompanyName; } set { _escrowCompanyName = value; } }
        private Value<string> _escrowTableDesc1;
        public string EscrowTableDesc1 { get { return _escrowTableDesc1; } set { _escrowTableDesc1 = value; } }
        private Value<string> _escrowTableDesc2;
        public string EscrowTableDesc2 { get { return _escrowTableDesc2; } set { _escrowTableDesc2 = value; } }
        private Value<string> _escrowTableDesc3;
        public string EscrowTableDesc3 { get { return _escrowTableDesc3; } set { _escrowTableDesc3 = value; } }
        private Value<string> _escrowTableDesc4;
        public string EscrowTableDesc4 { get { return _escrowTableDesc4; } set { _escrowTableDesc4 = value; } }
        private Value<string> _escrowTableDesc5;
        public string EscrowTableDesc5 { get { return _escrowTableDesc5; } set { _escrowTableDesc5 = value; } }
        private Value<decimal?> _escrowTableFee;
        public decimal? EscrowTableFee { get { return _escrowTableFee; } set { _escrowTableFee = value; } }
        private Value<decimal?> _escrowTableFee1;
        public decimal? EscrowTableFee1 { get { return _escrowTableFee1; } set { _escrowTableFee1 = value; } }
        private Value<decimal?> _escrowTableFee2;
        public decimal? EscrowTableFee2 { get { return _escrowTableFee2; } set { _escrowTableFee2 = value; } }
        private Value<decimal?> _escrowTableFee3;
        public decimal? EscrowTableFee3 { get { return _escrowTableFee3; } set { _escrowTableFee3 = value; } }
        private Value<decimal?> _escrowTableFee4;
        public decimal? EscrowTableFee4 { get { return _escrowTableFee4; } set { _escrowTableFee4 = value; } }
        private Value<decimal?> _escrowTableFee5;
        public decimal? EscrowTableFee5 { get { return _escrowTableFee5; } set { _escrowTableFee5 = value; } }
        private Value<string> _escrowTableName;
        public string EscrowTableName { get { return _escrowTableName; } set { _escrowTableName = value; } }
        public FeeVarianceOther FeeVarianceOther { get; set; }
        private Value<List<FeeVariance>> _feeVariances;
        public List<FeeVariance> FeeVariances { get { return _feeVariances; } set { _feeVariances = value; } }
        public Gfe2010 Gfe2010 { get; set; }
        public Gfe2010Page Gfe2010Page { get; set; }
        public Gfe2010Section Gfe2010Section { get; set; }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _impoundHazInsRate;
        public decimal? ImpoundHazInsRate { get { return _impoundHazInsRate; } set { _impoundHazInsRate = value; } }
        private Value<decimal?> _impoundMortgInsPremRate;
        public decimal? ImpoundMortgInsPremRate { get { return _impoundMortgInsPremRate; } set { _impoundMortgInsPremRate = value; } }
        private Value<string> _impoundMortgInsPremYearlyBasis;
        public string ImpoundMortgInsPremYearlyBasis { get { return _impoundMortgInsPremYearlyBasis; } set { _impoundMortgInsPremYearlyBasis = value; } }
        private Value<decimal?> _impoundTaxesRate;
        public decimal? ImpoundTaxesRate { get { return _impoundTaxesRate; } set { _impoundTaxesRate = value; } }
        private Value<string> _impoundType1;
        public string ImpoundType1 { get { return _impoundType1; } set { _impoundType1 = value; } }
        private Value<string> _impoundType2;
        public string ImpoundType2 { get { return _impoundType2; } set { _impoundType2 = value; } }
        private Value<string> _impoundType3;
        public string ImpoundType3 { get { return _impoundType3; } set { _impoundType3 = value; } }
        private Value<string> _impoundType4;
        public string ImpoundType4 { get { return _impoundType4; } set { _impoundType4 = value; } }
        public LoanEstimate1 LoanEstimate1 { get; set; }
        public LoanEstimate2 LoanEstimate2 { get; set; }
        public LoanEstimate3 LoanEstimate3 { get; set; }
        private Value<decimal?> _proposedMonthlyHazardInsurance;
        public decimal? ProposedMonthlyHazardInsurance { get { return _proposedMonthlyHazardInsurance; } set { _proposedMonthlyHazardInsurance = value; } }
        private Value<decimal?> _proposedMonthlyMortgageInsurance;
        public decimal? ProposedMonthlyMortgageInsurance { get { return _proposedMonthlyMortgageInsurance; } set { _proposedMonthlyMortgageInsurance = value; } }
        private Value<decimal?> _section1000BorrowerPaidTotalAmount;
        public decimal? Section1000BorrowerPaidTotalAmount { get { return _section1000BorrowerPaidTotalAmount; } set { _section1000BorrowerPaidTotalAmount = value; } }
        private Value<decimal?> _section1000SellerPaidTotalAmount;
        public decimal? Section1000SellerPaidTotalAmount { get { return _section1000SellerPaidTotalAmount; } set { _section1000SellerPaidTotalAmount = value; } }
        private Value<decimal?> _settlementClosingFeeNewHudBorPaidAmount;
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get { return _settlementClosingFeeNewHudBorPaidAmount; } set { _settlementClosingFeeNewHudBorPaidAmount = value; } }
        private Value<decimal?> _settlementClosingFeeNewHudSelPaidAmount;
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get { return _settlementClosingFeeNewHudSelPaidAmount; } set { _settlementClosingFeeNewHudSelPaidAmount = value; } }
        private Value<string> _titleCompanyName;
        public string TitleCompanyName { get { return _titleCompanyName; } set { _titleCompanyName = value; } }
        private Value<decimal?> _titleExaminationNewHudSelPaidAmount;
        public decimal? TitleExaminationNewHudSelPaidAmount { get { return _titleExaminationNewHudSelPaidAmount; } set { _titleExaminationNewHudSelPaidAmount = value; } }
        private Value<string> _titleTable2010Name;
        public string TitleTable2010Name { get { return _titleTable2010Name; } set { _titleTable2010Name = value; } }
        private Value<string> _titleTableName;
        public string TitleTableName { get { return _titleTableName; } set { _titleTableName = value; } }
        private Value<decimal?> _totalForBorPaid1;
        public decimal? TotalForBorPaid1 { get { return _totalForBorPaid1; } set { _totalForBorPaid1 = value; } }
        private Value<decimal?> _totalForBorPaid2;
        public decimal? TotalForBorPaid2 { get { return _totalForBorPaid2; } set { _totalForBorPaid2 = value; } }
        private Value<decimal?> _totalForBorPaid3;
        public decimal? TotalForBorPaid3 { get { return _totalForBorPaid3; } set { _totalForBorPaid3 = value; } }
        private Value<decimal?> _totalForBorPaid4;
        public decimal? TotalForBorPaid4 { get { return _totalForBorPaid4; } set { _totalForBorPaid4 = value; } }
        private Value<decimal?> _totalForBorPaid5;
        public decimal? TotalForBorPaid5 { get { return _totalForBorPaid5; } set { _totalForBorPaid5 = value; } }
        private Value<decimal?> _totalForBorPaid6;
        public decimal? TotalForBorPaid6 { get { return _totalForBorPaid6; } set { _totalForBorPaid6 = value; } }
        private Value<decimal?> _totalForSellerPaid1;
        public decimal? TotalForSellerPaid1 { get { return _totalForSellerPaid1; } set { _totalForSellerPaid1 = value; } }
        private Value<decimal?> _totalForSellerPaid2;
        public decimal? TotalForSellerPaid2 { get { return _totalForSellerPaid2; } set { _totalForSellerPaid2 = value; } }
        private Value<decimal?> _totalForSellerPaid3;
        public decimal? TotalForSellerPaid3 { get { return _totalForSellerPaid3; } set { _totalForSellerPaid3 = value; } }
        private Value<decimal?> _totalForSellerPaid4;
        public decimal? TotalForSellerPaid4 { get { return _totalForSellerPaid4; } set { _totalForSellerPaid4 = value; } }
        private Value<decimal?> _totalForSellerPaid5;
        public decimal? TotalForSellerPaid5 { get { return _totalForSellerPaid5; } set { _totalForSellerPaid5 = value; } }
        private Value<decimal?> _totalForSellerPaid6;
        public decimal? TotalForSellerPaid6 { get { return _totalForSellerPaid6; } set { _totalForSellerPaid6 = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _adjustmentFactor.Clean
                    && _aggregateAdjustmentFwbc.Clean
                    && _borrowerPaidDiscountPointsTotalAmount.Clean
                    && _brokerCommissionBasedPrice.Clean
                    && _brokerCommissionBasedUnitPercentage.Clean
                    && _brokerCommissionBasedUnitPrice.Clean
                    && _closingCostProgram.Clean
                    && _closingCostScenarioXml.Clean
                    && _disclosedSalesPrice.Clean
                    && _escrowCompanyName.Clean
                    && _escrowTableDesc1.Clean
                    && _escrowTableDesc2.Clean
                    && _escrowTableDesc3.Clean
                    && _escrowTableDesc4.Clean
                    && _escrowTableDesc5.Clean
                    && _escrowTableFee.Clean
                    && _escrowTableFee1.Clean
                    && _escrowTableFee2.Clean
                    && _escrowTableFee3.Clean
                    && _escrowTableFee4.Clean
                    && _escrowTableFee5.Clean
                    && _escrowTableName.Clean
                    && _feeVariances.Clean
                    && _id.Clean
                    && _impoundHazInsRate.Clean
                    && _impoundMortgInsPremRate.Clean
                    && _impoundMortgInsPremYearlyBasis.Clean
                    && _impoundTaxesRate.Clean
                    && _impoundType1.Clean
                    && _impoundType2.Clean
                    && _impoundType3.Clean
                    && _impoundType4.Clean
                    && _proposedMonthlyHazardInsurance.Clean
                    && _proposedMonthlyMortgageInsurance.Clean
                    && _section1000BorrowerPaidTotalAmount.Clean
                    && _section1000SellerPaidTotalAmount.Clean
                    && _settlementClosingFeeNewHudBorPaidAmount.Clean
                    && _settlementClosingFeeNewHudSelPaidAmount.Clean
                    && _titleCompanyName.Clean
                    && _titleExaminationNewHudSelPaidAmount.Clean
                    && _titleTable2010Name.Clean
                    && _titleTableName.Clean
                    && _totalForBorPaid1.Clean
                    && _totalForBorPaid2.Clean
                    && _totalForBorPaid3.Clean
                    && _totalForBorPaid4.Clean
                    && _totalForBorPaid5.Clean
                    && _totalForBorPaid6.Clean
                    && _totalForSellerPaid1.Clean
                    && _totalForSellerPaid2.Clean
                    && _totalForSellerPaid3.Clean
                    && _totalForSellerPaid4.Clean
                    && _totalForSellerPaid5.Clean
                    && _totalForSellerPaid6.Clean
                    && ClosingDisclosure1.Clean
                    && ClosingDisclosure2.Clean
                    && ClosingDisclosure3.Clean
                    && ClosingDisclosure4.Clean
                    && ClosingDisclosure5.Clean
                    && FeeVarianceOther.Clean
                    && Gfe2010.Clean
                    && Gfe2010Page.Clean
                    && Gfe2010Section.Clean
                    && LoanEstimate1.Clean
                    && LoanEstimate2.Clean
                    && LoanEstimate3.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var adjustmentFactor = _adjustmentFactor; adjustmentFactor.Clean = value; _adjustmentFactor = adjustmentFactor;
                var aggregateAdjustmentFwbc = _aggregateAdjustmentFwbc; aggregateAdjustmentFwbc.Clean = value; _aggregateAdjustmentFwbc = aggregateAdjustmentFwbc;
                var borrowerPaidDiscountPointsTotalAmount = _borrowerPaidDiscountPointsTotalAmount; borrowerPaidDiscountPointsTotalAmount.Clean = value; _borrowerPaidDiscountPointsTotalAmount = borrowerPaidDiscountPointsTotalAmount;
                var brokerCommissionBasedPrice = _brokerCommissionBasedPrice; brokerCommissionBasedPrice.Clean = value; _brokerCommissionBasedPrice = brokerCommissionBasedPrice;
                var brokerCommissionBasedUnitPercentage = _brokerCommissionBasedUnitPercentage; brokerCommissionBasedUnitPercentage.Clean = value; _brokerCommissionBasedUnitPercentage = brokerCommissionBasedUnitPercentage;
                var brokerCommissionBasedUnitPrice = _brokerCommissionBasedUnitPrice; brokerCommissionBasedUnitPrice.Clean = value; _brokerCommissionBasedUnitPrice = brokerCommissionBasedUnitPrice;
                var closingCostProgram = _closingCostProgram; closingCostProgram.Clean = value; _closingCostProgram = closingCostProgram;
                var closingCostScenarioXml = _closingCostScenarioXml; closingCostScenarioXml.Clean = value; _closingCostScenarioXml = closingCostScenarioXml;
                var disclosedSalesPrice = _disclosedSalesPrice; disclosedSalesPrice.Clean = value; _disclosedSalesPrice = disclosedSalesPrice;
                var escrowCompanyName = _escrowCompanyName; escrowCompanyName.Clean = value; _escrowCompanyName = escrowCompanyName;
                var escrowTableDesc1 = _escrowTableDesc1; escrowTableDesc1.Clean = value; _escrowTableDesc1 = escrowTableDesc1;
                var escrowTableDesc2 = _escrowTableDesc2; escrowTableDesc2.Clean = value; _escrowTableDesc2 = escrowTableDesc2;
                var escrowTableDesc3 = _escrowTableDesc3; escrowTableDesc3.Clean = value; _escrowTableDesc3 = escrowTableDesc3;
                var escrowTableDesc4 = _escrowTableDesc4; escrowTableDesc4.Clean = value; _escrowTableDesc4 = escrowTableDesc4;
                var escrowTableDesc5 = _escrowTableDesc5; escrowTableDesc5.Clean = value; _escrowTableDesc5 = escrowTableDesc5;
                var escrowTableFee = _escrowTableFee; escrowTableFee.Clean = value; _escrowTableFee = escrowTableFee;
                var escrowTableFee1 = _escrowTableFee1; escrowTableFee1.Clean = value; _escrowTableFee1 = escrowTableFee1;
                var escrowTableFee2 = _escrowTableFee2; escrowTableFee2.Clean = value; _escrowTableFee2 = escrowTableFee2;
                var escrowTableFee3 = _escrowTableFee3; escrowTableFee3.Clean = value; _escrowTableFee3 = escrowTableFee3;
                var escrowTableFee4 = _escrowTableFee4; escrowTableFee4.Clean = value; _escrowTableFee4 = escrowTableFee4;
                var escrowTableFee5 = _escrowTableFee5; escrowTableFee5.Clean = value; _escrowTableFee5 = escrowTableFee5;
                var escrowTableName = _escrowTableName; escrowTableName.Clean = value; _escrowTableName = escrowTableName;
                var feeVariances = _feeVariances; feeVariances.Clean = value; _feeVariances = feeVariances;
                var id = _id; id.Clean = value; _id = id;
                var impoundHazInsRate = _impoundHazInsRate; impoundHazInsRate.Clean = value; _impoundHazInsRate = impoundHazInsRate;
                var impoundMortgInsPremRate = _impoundMortgInsPremRate; impoundMortgInsPremRate.Clean = value; _impoundMortgInsPremRate = impoundMortgInsPremRate;
                var impoundMortgInsPremYearlyBasis = _impoundMortgInsPremYearlyBasis; impoundMortgInsPremYearlyBasis.Clean = value; _impoundMortgInsPremYearlyBasis = impoundMortgInsPremYearlyBasis;
                var impoundTaxesRate = _impoundTaxesRate; impoundTaxesRate.Clean = value; _impoundTaxesRate = impoundTaxesRate;
                var impoundType1 = _impoundType1; impoundType1.Clean = value; _impoundType1 = impoundType1;
                var impoundType2 = _impoundType2; impoundType2.Clean = value; _impoundType2 = impoundType2;
                var impoundType3 = _impoundType3; impoundType3.Clean = value; _impoundType3 = impoundType3;
                var impoundType4 = _impoundType4; impoundType4.Clean = value; _impoundType4 = impoundType4;
                var proposedMonthlyHazardInsurance = _proposedMonthlyHazardInsurance; proposedMonthlyHazardInsurance.Clean = value; _proposedMonthlyHazardInsurance = proposedMonthlyHazardInsurance;
                var proposedMonthlyMortgageInsurance = _proposedMonthlyMortgageInsurance; proposedMonthlyMortgageInsurance.Clean = value; _proposedMonthlyMortgageInsurance = proposedMonthlyMortgageInsurance;
                var section1000BorrowerPaidTotalAmount = _section1000BorrowerPaidTotalAmount; section1000BorrowerPaidTotalAmount.Clean = value; _section1000BorrowerPaidTotalAmount = section1000BorrowerPaidTotalAmount;
                var section1000SellerPaidTotalAmount = _section1000SellerPaidTotalAmount; section1000SellerPaidTotalAmount.Clean = value; _section1000SellerPaidTotalAmount = section1000SellerPaidTotalAmount;
                var settlementClosingFeeNewHudBorPaidAmount = _settlementClosingFeeNewHudBorPaidAmount; settlementClosingFeeNewHudBorPaidAmount.Clean = value; _settlementClosingFeeNewHudBorPaidAmount = settlementClosingFeeNewHudBorPaidAmount;
                var settlementClosingFeeNewHudSelPaidAmount = _settlementClosingFeeNewHudSelPaidAmount; settlementClosingFeeNewHudSelPaidAmount.Clean = value; _settlementClosingFeeNewHudSelPaidAmount = settlementClosingFeeNewHudSelPaidAmount;
                var titleCompanyName = _titleCompanyName; titleCompanyName.Clean = value; _titleCompanyName = titleCompanyName;
                var titleExaminationNewHudSelPaidAmount = _titleExaminationNewHudSelPaidAmount; titleExaminationNewHudSelPaidAmount.Clean = value; _titleExaminationNewHudSelPaidAmount = titleExaminationNewHudSelPaidAmount;
                var titleTable2010Name = _titleTable2010Name; titleTable2010Name.Clean = value; _titleTable2010Name = titleTable2010Name;
                var titleTableName = _titleTableName; titleTableName.Clean = value; _titleTableName = titleTableName;
                var totalForBorPaid1 = _totalForBorPaid1; totalForBorPaid1.Clean = value; _totalForBorPaid1 = totalForBorPaid1;
                var totalForBorPaid2 = _totalForBorPaid2; totalForBorPaid2.Clean = value; _totalForBorPaid2 = totalForBorPaid2;
                var totalForBorPaid3 = _totalForBorPaid3; totalForBorPaid3.Clean = value; _totalForBorPaid3 = totalForBorPaid3;
                var totalForBorPaid4 = _totalForBorPaid4; totalForBorPaid4.Clean = value; _totalForBorPaid4 = totalForBorPaid4;
                var totalForBorPaid5 = _totalForBorPaid5; totalForBorPaid5.Clean = value; _totalForBorPaid5 = totalForBorPaid5;
                var totalForBorPaid6 = _totalForBorPaid6; totalForBorPaid6.Clean = value; _totalForBorPaid6 = totalForBorPaid6;
                var totalForSellerPaid1 = _totalForSellerPaid1; totalForSellerPaid1.Clean = value; _totalForSellerPaid1 = totalForSellerPaid1;
                var totalForSellerPaid2 = _totalForSellerPaid2; totalForSellerPaid2.Clean = value; _totalForSellerPaid2 = totalForSellerPaid2;
                var totalForSellerPaid3 = _totalForSellerPaid3; totalForSellerPaid3.Clean = value; _totalForSellerPaid3 = totalForSellerPaid3;
                var totalForSellerPaid4 = _totalForSellerPaid4; totalForSellerPaid4.Clean = value; _totalForSellerPaid4 = totalForSellerPaid4;
                var totalForSellerPaid5 = _totalForSellerPaid5; totalForSellerPaid5.Clean = value; _totalForSellerPaid5 = totalForSellerPaid5;
                var totalForSellerPaid6 = _totalForSellerPaid6; totalForSellerPaid6.Clean = value; _totalForSellerPaid6 = totalForSellerPaid6;
                if (ClosingDisclosure1 != null) ClosingDisclosure1.Clean = value;
                if (ClosingDisclosure2 != null) ClosingDisclosure2.Clean = value;
                if (ClosingDisclosure3 != null) ClosingDisclosure3.Clean = value;
                if (ClosingDisclosure4 != null) ClosingDisclosure4.Clean = value;
                if (ClosingDisclosure5 != null) ClosingDisclosure5.Clean = value;
                if (FeeVarianceOther != null) FeeVarianceOther.Clean = value;
                if (Gfe2010 != null) Gfe2010.Clean = value;
                if (Gfe2010Page != null) Gfe2010Page.Clean = value;
                if (Gfe2010Section != null) Gfe2010Section.Clean = value;
                if (LoanEstimate1 != null) LoanEstimate1.Clean = value;
                if (LoanEstimate2 != null) LoanEstimate2.Clean = value;
                if (LoanEstimate3 != null) LoanEstimate3.Clean = value;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public ClosingCost()
        {
            Clean = true;
        }
    }
}