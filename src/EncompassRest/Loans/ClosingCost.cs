using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class ClosingCost : IDirty
    {
        private DirtyValue<decimal?> _adjustmentFactor;
        public decimal? AdjustmentFactor { get => _adjustmentFactor; set => _adjustmentFactor = value; }
        private DirtyValue<string> _aggregateAdjustmentFwbc;
        public string AggregateAdjustmentFwbc { get => _aggregateAdjustmentFwbc; set => _aggregateAdjustmentFwbc = value; }
        private DirtyValue<decimal?> _borrowerPaidDiscountPointsTotalAmount;
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get => _borrowerPaidDiscountPointsTotalAmount; set => _borrowerPaidDiscountPointsTotalAmount = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedPrice;
        public decimal? BrokerCommissionBasedPrice { get => _brokerCommissionBasedPrice; set => _brokerCommissionBasedPrice = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedUnitPercentage;
        public decimal? BrokerCommissionBasedUnitPercentage { get => _brokerCommissionBasedUnitPercentage; set => _brokerCommissionBasedUnitPercentage = value; }
        private DirtyValue<decimal?> _brokerCommissionBasedUnitPrice;
        public decimal? BrokerCommissionBasedUnitPrice { get => _brokerCommissionBasedUnitPrice; set => _brokerCommissionBasedUnitPrice = value; }
        private DirtyValue<string> _closingCostProgram;
        public string ClosingCostProgram { get => _closingCostProgram; set => _closingCostProgram = value; }
        private DirtyValue<string> _closingCostScenarioXml;
        public string ClosingCostScenarioXml { get => _closingCostScenarioXml; set => _closingCostScenarioXml = value; }
        private ClosingDisclosure1 _closingDisclosure1;
        public ClosingDisclosure1 ClosingDisclosure1 { get => _closingDisclosure1 ?? (_closingDisclosure1 = new ClosingDisclosure1()); set => _closingDisclosure1 = value; }
        private ClosingDisclosure2 _closingDisclosure2;
        public ClosingDisclosure2 ClosingDisclosure2 { get => _closingDisclosure2 ?? (_closingDisclosure2 = new ClosingDisclosure2()); set => _closingDisclosure2 = value; }
        private ClosingDisclosure3 _closingDisclosure3;
        public ClosingDisclosure3 ClosingDisclosure3 { get => _closingDisclosure3 ?? (_closingDisclosure3 = new ClosingDisclosure3()); set => _closingDisclosure3 = value; }
        private ClosingDisclosure4 _closingDisclosure4;
        public ClosingDisclosure4 ClosingDisclosure4 { get => _closingDisclosure4 ?? (_closingDisclosure4 = new ClosingDisclosure4()); set => _closingDisclosure4 = value; }
        private ClosingDisclosure5 _closingDisclosure5;
        public ClosingDisclosure5 ClosingDisclosure5 { get => _closingDisclosure5 ?? (_closingDisclosure5 = new ClosingDisclosure5()); set => _closingDisclosure5 = value; }
        private DirtyValue<decimal?> _disclosedSalesPrice;
        public decimal? DisclosedSalesPrice { get => _disclosedSalesPrice; set => _disclosedSalesPrice = value; }
        private DirtyValue<string> _escrowCompanyName;
        public string EscrowCompanyName { get => _escrowCompanyName; set => _escrowCompanyName = value; }
        private DirtyValue<string> _escrowTableDesc1;
        public string EscrowTableDesc1 { get => _escrowTableDesc1; set => _escrowTableDesc1 = value; }
        private DirtyValue<string> _escrowTableDesc2;
        public string EscrowTableDesc2 { get => _escrowTableDesc2; set => _escrowTableDesc2 = value; }
        private DirtyValue<string> _escrowTableDesc3;
        public string EscrowTableDesc3 { get => _escrowTableDesc3; set => _escrowTableDesc3 = value; }
        private DirtyValue<string> _escrowTableDesc4;
        public string EscrowTableDesc4 { get => _escrowTableDesc4; set => _escrowTableDesc4 = value; }
        private DirtyValue<string> _escrowTableDesc5;
        public string EscrowTableDesc5 { get => _escrowTableDesc5; set => _escrowTableDesc5 = value; }
        private DirtyValue<decimal?> _escrowTableFee;
        public decimal? EscrowTableFee { get => _escrowTableFee; set => _escrowTableFee = value; }
        private DirtyValue<decimal?> _escrowTableFee1;
        public decimal? EscrowTableFee1 { get => _escrowTableFee1; set => _escrowTableFee1 = value; }
        private DirtyValue<decimal?> _escrowTableFee2;
        public decimal? EscrowTableFee2 { get => _escrowTableFee2; set => _escrowTableFee2 = value; }
        private DirtyValue<decimal?> _escrowTableFee3;
        public decimal? EscrowTableFee3 { get => _escrowTableFee3; set => _escrowTableFee3 = value; }
        private DirtyValue<decimal?> _escrowTableFee4;
        public decimal? EscrowTableFee4 { get => _escrowTableFee4; set => _escrowTableFee4 = value; }
        private DirtyValue<decimal?> _escrowTableFee5;
        public decimal? EscrowTableFee5 { get => _escrowTableFee5; set => _escrowTableFee5 = value; }
        private DirtyValue<string> _escrowTableName;
        public string EscrowTableName { get => _escrowTableName; set => _escrowTableName = value; }
        private FeeVarianceOther _feeVarianceOther;
        public FeeVarianceOther FeeVarianceOther { get => _feeVarianceOther ?? (_feeVarianceOther = new FeeVarianceOther()); set => _feeVarianceOther = value; }
        private DirtyList<FeeVariance> _feeVariances;
        public IList<FeeVariance> FeeVariances { get => _feeVariances ?? (_feeVariances = new DirtyList<FeeVariance>()); set => _feeVariances = new DirtyList<FeeVariance>(value); }
        private Gfe2010 _gfe2010;
        public Gfe2010 Gfe2010 { get => _gfe2010 ?? (_gfe2010 = new Gfe2010()); set => _gfe2010 = value; }
        private Gfe2010Page _gfe2010Page;
        public Gfe2010Page Gfe2010Page { get => _gfe2010Page ?? (_gfe2010Page = new Gfe2010Page()); set => _gfe2010Page = value; }
        private Gfe2010Section _gfe2010Section;
        public Gfe2010Section Gfe2010Section { get => _gfe2010Section ?? (_gfe2010Section = new Gfe2010Section()); set => _gfe2010Section = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _impoundHazInsRate;
        public decimal? ImpoundHazInsRate { get => _impoundHazInsRate; set => _impoundHazInsRate = value; }
        private DirtyValue<decimal?> _impoundMortgInsPremRate;
        public decimal? ImpoundMortgInsPremRate { get => _impoundMortgInsPremRate; set => _impoundMortgInsPremRate = value; }
        private DirtyValue<string> _impoundMortgInsPremYearlyBasis;
        public string ImpoundMortgInsPremYearlyBasis { get => _impoundMortgInsPremYearlyBasis; set => _impoundMortgInsPremYearlyBasis = value; }
        private DirtyValue<decimal?> _impoundTaxesRate;
        public decimal? ImpoundTaxesRate { get => _impoundTaxesRate; set => _impoundTaxesRate = value; }
        private StringEnumValue<ClosingCostImpoundType> _impoundType1;
        public StringEnumValue<ClosingCostImpoundType> ImpoundType1 { get => _impoundType1; set => _impoundType1 = value; }
        private DirtyValue<string> _impoundType2;
        public string ImpoundType2 { get => _impoundType2; set => _impoundType2 = value; }
        private StringEnumValue<ImpoundType3> _impoundType3;
        public StringEnumValue<ImpoundType3> ImpoundType3 { get => _impoundType3; set => _impoundType3 = value; }
        private DirtyValue<string> _impoundType4;
        public string ImpoundType4 { get => _impoundType4; set => _impoundType4 = value; }
        private LoanEstimate1 _loanEstimate1;
        public LoanEstimate1 LoanEstimate1 { get => _loanEstimate1 ?? (_loanEstimate1 = new LoanEstimate1()); set => _loanEstimate1 = value; }
        private LoanEstimate2 _loanEstimate2;
        public LoanEstimate2 LoanEstimate2 { get => _loanEstimate2 ?? (_loanEstimate2 = new LoanEstimate2()); set => _loanEstimate2 = value; }
        private LoanEstimate3 _loanEstimate3;
        public LoanEstimate3 LoanEstimate3 { get => _loanEstimate3 ?? (_loanEstimate3 = new LoanEstimate3()); set => _loanEstimate3 = value; }
        private DirtyValue<decimal?> _proposedMonthlyHazardInsurance;
        public decimal? ProposedMonthlyHazardInsurance { get => _proposedMonthlyHazardInsurance; set => _proposedMonthlyHazardInsurance = value; }
        private DirtyValue<decimal?> _proposedMonthlyMortgageInsurance;
        public decimal? ProposedMonthlyMortgageInsurance { get => _proposedMonthlyMortgageInsurance; set => _proposedMonthlyMortgageInsurance = value; }
        private DirtyValue<decimal?> _section1000BorrowerPaidTotalAmount;
        public decimal? Section1000BorrowerPaidTotalAmount { get => _section1000BorrowerPaidTotalAmount; set => _section1000BorrowerPaidTotalAmount = value; }
        private DirtyValue<decimal?> _section1000SellerPaidTotalAmount;
        public decimal? Section1000SellerPaidTotalAmount { get => _section1000SellerPaidTotalAmount; set => _section1000SellerPaidTotalAmount = value; }
        private DirtyValue<decimal?> _settlementClosingFeeNewHudBorPaidAmount;
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get => _settlementClosingFeeNewHudBorPaidAmount; set => _settlementClosingFeeNewHudBorPaidAmount = value; }
        private DirtyValue<decimal?> _settlementClosingFeeNewHudSelPaidAmount;
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get => _settlementClosingFeeNewHudSelPaidAmount; set => _settlementClosingFeeNewHudSelPaidAmount = value; }
        private DirtyValue<string> _titleCompanyName;
        public string TitleCompanyName { get => _titleCompanyName; set => _titleCompanyName = value; }
        private DirtyValue<decimal?> _titleExaminationNewHudSelPaidAmount;
        public decimal? TitleExaminationNewHudSelPaidAmount { get => _titleExaminationNewHudSelPaidAmount; set => _titleExaminationNewHudSelPaidAmount = value; }
        private DirtyValue<string> _titleTable2010Name;
        public string TitleTable2010Name { get => _titleTable2010Name; set => _titleTable2010Name = value; }
        private DirtyValue<string> _titleTableName;
        public string TitleTableName { get => _titleTableName; set => _titleTableName = value; }
        private DirtyValue<decimal?> _totalForBorPaid1;
        public decimal? TotalForBorPaid1 { get => _totalForBorPaid1; set => _totalForBorPaid1 = value; }
        private DirtyValue<decimal?> _totalForBorPaid2;
        public decimal? TotalForBorPaid2 { get => _totalForBorPaid2; set => _totalForBorPaid2 = value; }
        private DirtyValue<decimal?> _totalForBorPaid3;
        public decimal? TotalForBorPaid3 { get => _totalForBorPaid3; set => _totalForBorPaid3 = value; }
        private DirtyValue<decimal?> _totalForBorPaid4;
        public decimal? TotalForBorPaid4 { get => _totalForBorPaid4; set => _totalForBorPaid4 = value; }
        private DirtyValue<decimal?> _totalForBorPaid5;
        public decimal? TotalForBorPaid5 { get => _totalForBorPaid5; set => _totalForBorPaid5 = value; }
        private DirtyValue<decimal?> _totalForBorPaid6;
        public decimal? TotalForBorPaid6 { get => _totalForBorPaid6; set => _totalForBorPaid6 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid1;
        public decimal? TotalForSellerPaid1 { get => _totalForSellerPaid1; set => _totalForSellerPaid1 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid2;
        public decimal? TotalForSellerPaid2 { get => _totalForSellerPaid2; set => _totalForSellerPaid2 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid3;
        public decimal? TotalForSellerPaid3 { get => _totalForSellerPaid3; set => _totalForSellerPaid3 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid4;
        public decimal? TotalForSellerPaid4 { get => _totalForSellerPaid4; set => _totalForSellerPaid4 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid5;
        public decimal? TotalForSellerPaid5 { get => _totalForSellerPaid5; set => _totalForSellerPaid5 = value; }
        private DirtyValue<decimal?> _totalForSellerPaid6;
        public decimal? TotalForSellerPaid6 { get => _totalForSellerPaid6; set => _totalForSellerPaid6 = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _adjustmentFactor.Dirty
                    || _aggregateAdjustmentFwbc.Dirty
                    || _borrowerPaidDiscountPointsTotalAmount.Dirty
                    || _brokerCommissionBasedPrice.Dirty
                    || _brokerCommissionBasedUnitPercentage.Dirty
                    || _brokerCommissionBasedUnitPrice.Dirty
                    || _closingCostProgram.Dirty
                    || _closingCostScenarioXml.Dirty
                    || _disclosedSalesPrice.Dirty
                    || _escrowCompanyName.Dirty
                    || _escrowTableDesc1.Dirty
                    || _escrowTableDesc2.Dirty
                    || _escrowTableDesc3.Dirty
                    || _escrowTableDesc4.Dirty
                    || _escrowTableDesc5.Dirty
                    || _escrowTableFee.Dirty
                    || _escrowTableFee1.Dirty
                    || _escrowTableFee2.Dirty
                    || _escrowTableFee3.Dirty
                    || _escrowTableFee4.Dirty
                    || _escrowTableFee5.Dirty
                    || _escrowTableName.Dirty
                    || _id.Dirty
                    || _impoundHazInsRate.Dirty
                    || _impoundMortgInsPremRate.Dirty
                    || _impoundMortgInsPremYearlyBasis.Dirty
                    || _impoundTaxesRate.Dirty
                    || _impoundType1.Dirty
                    || _impoundType2.Dirty
                    || _impoundType3.Dirty
                    || _impoundType4.Dirty
                    || _proposedMonthlyHazardInsurance.Dirty
                    || _proposedMonthlyMortgageInsurance.Dirty
                    || _section1000BorrowerPaidTotalAmount.Dirty
                    || _section1000SellerPaidTotalAmount.Dirty
                    || _settlementClosingFeeNewHudBorPaidAmount.Dirty
                    || _settlementClosingFeeNewHudSelPaidAmount.Dirty
                    || _titleCompanyName.Dirty
                    || _titleExaminationNewHudSelPaidAmount.Dirty
                    || _titleTable2010Name.Dirty
                    || _titleTableName.Dirty
                    || _totalForBorPaid1.Dirty
                    || _totalForBorPaid2.Dirty
                    || _totalForBorPaid3.Dirty
                    || _totalForBorPaid4.Dirty
                    || _totalForBorPaid5.Dirty
                    || _totalForBorPaid6.Dirty
                    || _totalForSellerPaid1.Dirty
                    || _totalForSellerPaid2.Dirty
                    || _totalForSellerPaid3.Dirty
                    || _totalForSellerPaid4.Dirty
                    || _totalForSellerPaid5.Dirty
                    || _totalForSellerPaid6.Dirty
                    || _closingDisclosure1?.Dirty == true
                    || _closingDisclosure2?.Dirty == true
                    || _closingDisclosure3?.Dirty == true
                    || _closingDisclosure4?.Dirty == true
                    || _closingDisclosure5?.Dirty == true
                    || _feeVarianceOther?.Dirty == true
                    || _feeVariances?.Dirty == true
                    || _gfe2010?.Dirty == true
                    || _gfe2010Page?.Dirty == true
                    || _gfe2010Section?.Dirty == true
                    || _loanEstimate1?.Dirty == true
                    || _loanEstimate2?.Dirty == true
                    || _loanEstimate3?.Dirty == true
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _adjustmentFactor.Dirty = value;
                _aggregateAdjustmentFwbc.Dirty = value;
                _borrowerPaidDiscountPointsTotalAmount.Dirty = value;
                _brokerCommissionBasedPrice.Dirty = value;
                _brokerCommissionBasedUnitPercentage.Dirty = value;
                _brokerCommissionBasedUnitPrice.Dirty = value;
                _closingCostProgram.Dirty = value;
                _closingCostScenarioXml.Dirty = value;
                _disclosedSalesPrice.Dirty = value;
                _escrowCompanyName.Dirty = value;
                _escrowTableDesc1.Dirty = value;
                _escrowTableDesc2.Dirty = value;
                _escrowTableDesc3.Dirty = value;
                _escrowTableDesc4.Dirty = value;
                _escrowTableDesc5.Dirty = value;
                _escrowTableFee.Dirty = value;
                _escrowTableFee1.Dirty = value;
                _escrowTableFee2.Dirty = value;
                _escrowTableFee3.Dirty = value;
                _escrowTableFee4.Dirty = value;
                _escrowTableFee5.Dirty = value;
                _escrowTableName.Dirty = value;
                _id.Dirty = value;
                _impoundHazInsRate.Dirty = value;
                _impoundMortgInsPremRate.Dirty = value;
                _impoundMortgInsPremYearlyBasis.Dirty = value;
                _impoundTaxesRate.Dirty = value;
                _impoundType1.Dirty = value;
                _impoundType2.Dirty = value;
                _impoundType3.Dirty = value;
                _impoundType4.Dirty = value;
                _proposedMonthlyHazardInsurance.Dirty = value;
                _proposedMonthlyMortgageInsurance.Dirty = value;
                _section1000BorrowerPaidTotalAmount.Dirty = value;
                _section1000SellerPaidTotalAmount.Dirty = value;
                _settlementClosingFeeNewHudBorPaidAmount.Dirty = value;
                _settlementClosingFeeNewHudSelPaidAmount.Dirty = value;
                _titleCompanyName.Dirty = value;
                _titleExaminationNewHudSelPaidAmount.Dirty = value;
                _titleTable2010Name.Dirty = value;
                _titleTableName.Dirty = value;
                _totalForBorPaid1.Dirty = value;
                _totalForBorPaid2.Dirty = value;
                _totalForBorPaid3.Dirty = value;
                _totalForBorPaid4.Dirty = value;
                _totalForBorPaid5.Dirty = value;
                _totalForBorPaid6.Dirty = value;
                _totalForSellerPaid1.Dirty = value;
                _totalForSellerPaid2.Dirty = value;
                _totalForSellerPaid3.Dirty = value;
                _totalForSellerPaid4.Dirty = value;
                _totalForSellerPaid5.Dirty = value;
                _totalForSellerPaid6.Dirty = value;
                if (_closingDisclosure1 != null) _closingDisclosure1.Dirty = value;
                if (_closingDisclosure2 != null) _closingDisclosure2.Dirty = value;
                if (_closingDisclosure3 != null) _closingDisclosure3.Dirty = value;
                if (_closingDisclosure4 != null) _closingDisclosure4.Dirty = value;
                if (_closingDisclosure5 != null) _closingDisclosure5.Dirty = value;
                if (_feeVarianceOther != null) _feeVarianceOther.Dirty = value;
                if (_feeVariances != null) _feeVariances.Dirty = value;
                if (_gfe2010 != null) _gfe2010.Dirty = value;
                if (_gfe2010Page != null) _gfe2010Page.Dirty = value;
                if (_gfe2010Section != null) _gfe2010Section.Dirty = value;
                if (_loanEstimate1 != null) _loanEstimate1.Dirty = value;
                if (_loanEstimate2 != null) _loanEstimate2.Dirty = value;
                if (_loanEstimate3 != null) _loanEstimate3.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}