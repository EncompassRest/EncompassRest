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
                var v0 = _adjustmentFactor; v0.Clean = value; _adjustmentFactor = v0;
                var v1 = _aggregateAdjustmentFwbc; v1.Clean = value; _aggregateAdjustmentFwbc = v1;
                var v2 = _borrowerPaidDiscountPointsTotalAmount; v2.Clean = value; _borrowerPaidDiscountPointsTotalAmount = v2;
                var v3 = _brokerCommissionBasedPrice; v3.Clean = value; _brokerCommissionBasedPrice = v3;
                var v4 = _brokerCommissionBasedUnitPercentage; v4.Clean = value; _brokerCommissionBasedUnitPercentage = v4;
                var v5 = _brokerCommissionBasedUnitPrice; v5.Clean = value; _brokerCommissionBasedUnitPrice = v5;
                var v6 = _closingCostProgram; v6.Clean = value; _closingCostProgram = v6;
                var v7 = _closingCostScenarioXml; v7.Clean = value; _closingCostScenarioXml = v7;
                var v8 = _disclosedSalesPrice; v8.Clean = value; _disclosedSalesPrice = v8;
                var v9 = _escrowCompanyName; v9.Clean = value; _escrowCompanyName = v9;
                var v10 = _escrowTableDesc1; v10.Clean = value; _escrowTableDesc1 = v10;
                var v11 = _escrowTableDesc2; v11.Clean = value; _escrowTableDesc2 = v11;
                var v12 = _escrowTableDesc3; v12.Clean = value; _escrowTableDesc3 = v12;
                var v13 = _escrowTableDesc4; v13.Clean = value; _escrowTableDesc4 = v13;
                var v14 = _escrowTableDesc5; v14.Clean = value; _escrowTableDesc5 = v14;
                var v15 = _escrowTableFee; v15.Clean = value; _escrowTableFee = v15;
                var v16 = _escrowTableFee1; v16.Clean = value; _escrowTableFee1 = v16;
                var v17 = _escrowTableFee2; v17.Clean = value; _escrowTableFee2 = v17;
                var v18 = _escrowTableFee3; v18.Clean = value; _escrowTableFee3 = v18;
                var v19 = _escrowTableFee4; v19.Clean = value; _escrowTableFee4 = v19;
                var v20 = _escrowTableFee5; v20.Clean = value; _escrowTableFee5 = v20;
                var v21 = _escrowTableName; v21.Clean = value; _escrowTableName = v21;
                var v22 = _feeVariances; v22.Clean = value; _feeVariances = v22;
                var v23 = _id; v23.Clean = value; _id = v23;
                var v24 = _impoundHazInsRate; v24.Clean = value; _impoundHazInsRate = v24;
                var v25 = _impoundMortgInsPremRate; v25.Clean = value; _impoundMortgInsPremRate = v25;
                var v26 = _impoundMortgInsPremYearlyBasis; v26.Clean = value; _impoundMortgInsPremYearlyBasis = v26;
                var v27 = _impoundTaxesRate; v27.Clean = value; _impoundTaxesRate = v27;
                var v28 = _impoundType1; v28.Clean = value; _impoundType1 = v28;
                var v29 = _impoundType2; v29.Clean = value; _impoundType2 = v29;
                var v30 = _impoundType3; v30.Clean = value; _impoundType3 = v30;
                var v31 = _impoundType4; v31.Clean = value; _impoundType4 = v31;
                var v32 = _proposedMonthlyHazardInsurance; v32.Clean = value; _proposedMonthlyHazardInsurance = v32;
                var v33 = _proposedMonthlyMortgageInsurance; v33.Clean = value; _proposedMonthlyMortgageInsurance = v33;
                var v34 = _section1000BorrowerPaidTotalAmount; v34.Clean = value; _section1000BorrowerPaidTotalAmount = v34;
                var v35 = _section1000SellerPaidTotalAmount; v35.Clean = value; _section1000SellerPaidTotalAmount = v35;
                var v36 = _settlementClosingFeeNewHudBorPaidAmount; v36.Clean = value; _settlementClosingFeeNewHudBorPaidAmount = v36;
                var v37 = _settlementClosingFeeNewHudSelPaidAmount; v37.Clean = value; _settlementClosingFeeNewHudSelPaidAmount = v37;
                var v38 = _titleCompanyName; v38.Clean = value; _titleCompanyName = v38;
                var v39 = _titleExaminationNewHudSelPaidAmount; v39.Clean = value; _titleExaminationNewHudSelPaidAmount = v39;
                var v40 = _titleTable2010Name; v40.Clean = value; _titleTable2010Name = v40;
                var v41 = _titleTableName; v41.Clean = value; _titleTableName = v41;
                var v42 = _totalForBorPaid1; v42.Clean = value; _totalForBorPaid1 = v42;
                var v43 = _totalForBorPaid2; v43.Clean = value; _totalForBorPaid2 = v43;
                var v44 = _totalForBorPaid3; v44.Clean = value; _totalForBorPaid3 = v44;
                var v45 = _totalForBorPaid4; v45.Clean = value; _totalForBorPaid4 = v45;
                var v46 = _totalForBorPaid5; v46.Clean = value; _totalForBorPaid5 = v46;
                var v47 = _totalForBorPaid6; v47.Clean = value; _totalForBorPaid6 = v47;
                var v48 = _totalForSellerPaid1; v48.Clean = value; _totalForSellerPaid1 = v48;
                var v49 = _totalForSellerPaid2; v49.Clean = value; _totalForSellerPaid2 = v49;
                var v50 = _totalForSellerPaid3; v50.Clean = value; _totalForSellerPaid3 = v50;
                var v51 = _totalForSellerPaid4; v51.Clean = value; _totalForSellerPaid4 = v51;
                var v52 = _totalForSellerPaid5; v52.Clean = value; _totalForSellerPaid5 = v52;
                var v53 = _totalForSellerPaid6; v53.Clean = value; _totalForSellerPaid6 = v53;
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