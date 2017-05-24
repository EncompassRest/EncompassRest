using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class ClosingCost
    {
        public Value<decimal?> AdjustmentFactor { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdjustmentFactor() => !AdjustmentFactor.Clean;
        public Value<string> AggregateAdjustmentFwbc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAggregateAdjustmentFwbc() => !AggregateAdjustmentFwbc.Clean;
        public Value<decimal?> BorrowerPaidDiscountPointsTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPaidDiscountPointsTotalAmount() => !BorrowerPaidDiscountPointsTotalAmount.Clean;
        public Value<decimal?> BrokerCommissionBasedPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCommissionBasedPrice() => !BrokerCommissionBasedPrice.Clean;
        public Value<decimal?> BrokerCommissionBasedUnitPercentage { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCommissionBasedUnitPercentage() => !BrokerCommissionBasedUnitPercentage.Clean;
        public Value<decimal?> BrokerCommissionBasedUnitPrice { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCommissionBasedUnitPrice() => !BrokerCommissionBasedUnitPrice.Clean;
        public Value<string> ClosingCostProgram { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostProgram() => !ClosingCostProgram.Clean;
        public Value<string> ClosingCostScenarioXml { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingCostScenarioXml() => !ClosingCostScenarioXml.Clean;
        public ClosingDisclosure1 ClosingDisclosure1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosure1() => ClosingDisclosure1?.Clean == false;
        public ClosingDisclosure2 ClosingDisclosure2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosure2() => ClosingDisclosure2?.Clean == false;
        public ClosingDisclosure3 ClosingDisclosure3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosure3() => ClosingDisclosure3?.Clean == false;
        public ClosingDisclosure4 ClosingDisclosure4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosure4() => ClosingDisclosure4?.Clean == false;
        public ClosingDisclosure5 ClosingDisclosure5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeClosingDisclosure5() => ClosingDisclosure5?.Clean == false;
        public Value<string> EscrowCompanyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowCompanyName() => !EscrowCompanyName.Clean;
        public Value<string> EscrowTableDesc1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableDesc1() => !EscrowTableDesc1.Clean;
        public Value<string> EscrowTableDesc2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableDesc2() => !EscrowTableDesc2.Clean;
        public Value<string> EscrowTableDesc3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableDesc3() => !EscrowTableDesc3.Clean;
        public Value<string> EscrowTableDesc4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableDesc4() => !EscrowTableDesc4.Clean;
        public Value<string> EscrowTableDesc5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableDesc5() => !EscrowTableDesc5.Clean;
        public Value<decimal?> EscrowTableFee { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee() => !EscrowTableFee.Clean;
        public Value<decimal?> EscrowTableFee1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee1() => !EscrowTableFee1.Clean;
        public Value<decimal?> EscrowTableFee2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee2() => !EscrowTableFee2.Clean;
        public Value<decimal?> EscrowTableFee3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee3() => !EscrowTableFee3.Clean;
        public Value<decimal?> EscrowTableFee4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee4() => !EscrowTableFee4.Clean;
        public Value<decimal?> EscrowTableFee5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableFee5() => !EscrowTableFee5.Clean;
        public Value<string> EscrowTableName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowTableName() => !EscrowTableName.Clean;
        public FeeVarianceOther FeeVarianceOther { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVarianceOther() => FeeVarianceOther?.Clean == false;
        public Value<List<FeeVariance>> FeeVariances { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFeeVariances() => !FeeVariances.Clean;
        public Gfe2010 Gfe2010 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010() => Gfe2010?.Clean == false;
        public Gfe2010Page Gfe2010Page { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010Page() => Gfe2010Page?.Clean == false;
        public Gfe2010Section Gfe2010Section { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010Section() => Gfe2010Section?.Clean == false;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> ImpoundHazInsRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundHazInsRate() => !ImpoundHazInsRate.Clean;
        public Value<decimal?> ImpoundMortgInsPremRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundMortgInsPremRate() => !ImpoundMortgInsPremRate.Clean;
        public Value<string> ImpoundMortgInsPremYearlyBasis { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundMortgInsPremYearlyBasis() => !ImpoundMortgInsPremYearlyBasis.Clean;
        public Value<decimal?> ImpoundTaxesRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundTaxesRate() => !ImpoundTaxesRate.Clean;
        public Value<string> ImpoundType1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundType1() => !ImpoundType1.Clean;
        public Value<string> ImpoundType2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundType2() => !ImpoundType2.Clean;
        public Value<string> ImpoundType3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundType3() => !ImpoundType3.Clean;
        public Value<string> ImpoundType4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeImpoundType4() => !ImpoundType4.Clean;
        public LoanEstimate1 LoanEstimate1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate1() => LoanEstimate1?.Clean == false;
        public LoanEstimate2 LoanEstimate2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate2() => LoanEstimate2?.Clean == false;
        public LoanEstimate3 LoanEstimate3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLoanEstimate3() => LoanEstimate3?.Clean == false;
        public Value<decimal?> ProposedMonthlyHazardInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMonthlyHazardInsurance() => !ProposedMonthlyHazardInsurance.Clean;
        public Value<decimal?> ProposedMonthlyMortgageInsurance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeProposedMonthlyMortgageInsurance() => !ProposedMonthlyMortgageInsurance.Clean;
        public Value<decimal?> Section1000BorrowerPaidTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000BorrowerPaidTotalAmount() => !Section1000BorrowerPaidTotalAmount.Clean;
        public Value<decimal?> Section1000SellerPaidTotalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSection1000SellerPaidTotalAmount() => !Section1000SellerPaidTotalAmount.Clean;
        public Value<decimal?> SettlementClosingFeeNewHudBorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementClosingFeeNewHudBorPaidAmount() => !SettlementClosingFeeNewHudBorPaidAmount.Clean;
        public Value<decimal?> SettlementClosingFeeNewHudSelPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSettlementClosingFeeNewHudSelPaidAmount() => !SettlementClosingFeeNewHudSelPaidAmount.Clean;
        public Value<string> TitleCompanyName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleCompanyName() => !TitleCompanyName.Clean;
        public Value<decimal?> TitleExaminationNewHudSelPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleExaminationNewHudSelPaidAmount() => !TitleExaminationNewHudSelPaidAmount.Clean;
        public Value<string> TitleTable2010Name { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleTable2010Name() => !TitleTable2010Name.Clean;
        public Value<string> TitleTableName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleTableName() => !TitleTableName.Clean;
        public Value<decimal?> TotalForBorPaid1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid1() => !TotalForBorPaid1.Clean;
        public Value<decimal?> TotalForBorPaid2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid2() => !TotalForBorPaid2.Clean;
        public Value<decimal?> TotalForBorPaid3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid3() => !TotalForBorPaid3.Clean;
        public Value<decimal?> TotalForBorPaid4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid4() => !TotalForBorPaid4.Clean;
        public Value<decimal?> TotalForBorPaid5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid5() => !TotalForBorPaid5.Clean;
        public Value<decimal?> TotalForBorPaid6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForBorPaid6() => !TotalForBorPaid6.Clean;
        public Value<decimal?> TotalForSellerPaid1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid1() => !TotalForSellerPaid1.Clean;
        public Value<decimal?> TotalForSellerPaid2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid2() => !TotalForSellerPaid2.Clean;
        public Value<decimal?> TotalForSellerPaid3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid3() => !TotalForSellerPaid3.Clean;
        public Value<decimal?> TotalForSellerPaid4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid4() => !TotalForSellerPaid4.Clean;
        public Value<decimal?> TotalForSellerPaid5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid5() => !TotalForSellerPaid5.Clean;
        public Value<decimal?> TotalForSellerPaid6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalForSellerPaid6() => !TotalForSellerPaid6.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdjustmentFactor.Clean
                    && AggregateAdjustmentFwbc.Clean
                    && BorrowerPaidDiscountPointsTotalAmount.Clean
                    && BrokerCommissionBasedPrice.Clean
                    && BrokerCommissionBasedUnitPercentage.Clean
                    && BrokerCommissionBasedUnitPrice.Clean
                    && ClosingCostProgram.Clean
                    && ClosingCostScenarioXml.Clean
                    && EscrowCompanyName.Clean
                    && EscrowTableDesc1.Clean
                    && EscrowTableDesc2.Clean
                    && EscrowTableDesc3.Clean
                    && EscrowTableDesc4.Clean
                    && EscrowTableDesc5.Clean
                    && EscrowTableFee.Clean
                    && EscrowTableFee1.Clean
                    && EscrowTableFee2.Clean
                    && EscrowTableFee3.Clean
                    && EscrowTableFee4.Clean
                    && EscrowTableFee5.Clean
                    && EscrowTableName.Clean
                    && FeeVariances.Clean
                    && Id.Clean
                    && ImpoundHazInsRate.Clean
                    && ImpoundMortgInsPremRate.Clean
                    && ImpoundMortgInsPremYearlyBasis.Clean
                    && ImpoundTaxesRate.Clean
                    && ImpoundType1.Clean
                    && ImpoundType2.Clean
                    && ImpoundType3.Clean
                    && ImpoundType4.Clean
                    && ProposedMonthlyHazardInsurance.Clean
                    && ProposedMonthlyMortgageInsurance.Clean
                    && Section1000BorrowerPaidTotalAmount.Clean
                    && Section1000SellerPaidTotalAmount.Clean
                    && SettlementClosingFeeNewHudBorPaidAmount.Clean
                    && SettlementClosingFeeNewHudSelPaidAmount.Clean
                    && TitleCompanyName.Clean
                    && TitleExaminationNewHudSelPaidAmount.Clean
                    && TitleTable2010Name.Clean
                    && TitleTableName.Clean
                    && TotalForBorPaid1.Clean
                    && TotalForBorPaid2.Clean
                    && TotalForBorPaid3.Clean
                    && TotalForBorPaid4.Clean
                    && TotalForBorPaid5.Clean
                    && TotalForBorPaid6.Clean
                    && TotalForSellerPaid1.Clean
                    && TotalForSellerPaid2.Clean
                    && TotalForSellerPaid3.Clean
                    && TotalForSellerPaid4.Clean
                    && TotalForSellerPaid5.Clean
                    && TotalForSellerPaid6.Clean
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
                var v0 = AdjustmentFactor; v0.Clean = value; AdjustmentFactor = v0;
                var v1 = AggregateAdjustmentFwbc; v1.Clean = value; AggregateAdjustmentFwbc = v1;
                var v2 = BorrowerPaidDiscountPointsTotalAmount; v2.Clean = value; BorrowerPaidDiscountPointsTotalAmount = v2;
                var v3 = BrokerCommissionBasedPrice; v3.Clean = value; BrokerCommissionBasedPrice = v3;
                var v4 = BrokerCommissionBasedUnitPercentage; v4.Clean = value; BrokerCommissionBasedUnitPercentage = v4;
                var v5 = BrokerCommissionBasedUnitPrice; v5.Clean = value; BrokerCommissionBasedUnitPrice = v5;
                var v6 = ClosingCostProgram; v6.Clean = value; ClosingCostProgram = v6;
                var v7 = ClosingCostScenarioXml; v7.Clean = value; ClosingCostScenarioXml = v7;
                var v8 = EscrowCompanyName; v8.Clean = value; EscrowCompanyName = v8;
                var v9 = EscrowTableDesc1; v9.Clean = value; EscrowTableDesc1 = v9;
                var v10 = EscrowTableDesc2; v10.Clean = value; EscrowTableDesc2 = v10;
                var v11 = EscrowTableDesc3; v11.Clean = value; EscrowTableDesc3 = v11;
                var v12 = EscrowTableDesc4; v12.Clean = value; EscrowTableDesc4 = v12;
                var v13 = EscrowTableDesc5; v13.Clean = value; EscrowTableDesc5 = v13;
                var v14 = EscrowTableFee; v14.Clean = value; EscrowTableFee = v14;
                var v15 = EscrowTableFee1; v15.Clean = value; EscrowTableFee1 = v15;
                var v16 = EscrowTableFee2; v16.Clean = value; EscrowTableFee2 = v16;
                var v17 = EscrowTableFee3; v17.Clean = value; EscrowTableFee3 = v17;
                var v18 = EscrowTableFee4; v18.Clean = value; EscrowTableFee4 = v18;
                var v19 = EscrowTableFee5; v19.Clean = value; EscrowTableFee5 = v19;
                var v20 = EscrowTableName; v20.Clean = value; EscrowTableName = v20;
                var v21 = FeeVariances; v21.Clean = value; FeeVariances = v21;
                var v22 = Id; v22.Clean = value; Id = v22;
                var v23 = ImpoundHazInsRate; v23.Clean = value; ImpoundHazInsRate = v23;
                var v24 = ImpoundMortgInsPremRate; v24.Clean = value; ImpoundMortgInsPremRate = v24;
                var v25 = ImpoundMortgInsPremYearlyBasis; v25.Clean = value; ImpoundMortgInsPremYearlyBasis = v25;
                var v26 = ImpoundTaxesRate; v26.Clean = value; ImpoundTaxesRate = v26;
                var v27 = ImpoundType1; v27.Clean = value; ImpoundType1 = v27;
                var v28 = ImpoundType2; v28.Clean = value; ImpoundType2 = v28;
                var v29 = ImpoundType3; v29.Clean = value; ImpoundType3 = v29;
                var v30 = ImpoundType4; v30.Clean = value; ImpoundType4 = v30;
                var v31 = ProposedMonthlyHazardInsurance; v31.Clean = value; ProposedMonthlyHazardInsurance = v31;
                var v32 = ProposedMonthlyMortgageInsurance; v32.Clean = value; ProposedMonthlyMortgageInsurance = v32;
                var v33 = Section1000BorrowerPaidTotalAmount; v33.Clean = value; Section1000BorrowerPaidTotalAmount = v33;
                var v34 = Section1000SellerPaidTotalAmount; v34.Clean = value; Section1000SellerPaidTotalAmount = v34;
                var v35 = SettlementClosingFeeNewHudBorPaidAmount; v35.Clean = value; SettlementClosingFeeNewHudBorPaidAmount = v35;
                var v36 = SettlementClosingFeeNewHudSelPaidAmount; v36.Clean = value; SettlementClosingFeeNewHudSelPaidAmount = v36;
                var v37 = TitleCompanyName; v37.Clean = value; TitleCompanyName = v37;
                var v38 = TitleExaminationNewHudSelPaidAmount; v38.Clean = value; TitleExaminationNewHudSelPaidAmount = v38;
                var v39 = TitleTable2010Name; v39.Clean = value; TitleTable2010Name = v39;
                var v40 = TitleTableName; v40.Clean = value; TitleTableName = v40;
                var v41 = TotalForBorPaid1; v41.Clean = value; TotalForBorPaid1 = v41;
                var v42 = TotalForBorPaid2; v42.Clean = value; TotalForBorPaid2 = v42;
                var v43 = TotalForBorPaid3; v43.Clean = value; TotalForBorPaid3 = v43;
                var v44 = TotalForBorPaid4; v44.Clean = value; TotalForBorPaid4 = v44;
                var v45 = TotalForBorPaid5; v45.Clean = value; TotalForBorPaid5 = v45;
                var v46 = TotalForBorPaid6; v46.Clean = value; TotalForBorPaid6 = v46;
                var v47 = TotalForSellerPaid1; v47.Clean = value; TotalForSellerPaid1 = v47;
                var v48 = TotalForSellerPaid2; v48.Clean = value; TotalForSellerPaid2 = v48;
                var v49 = TotalForSellerPaid3; v49.Clean = value; TotalForSellerPaid3 = v49;
                var v50 = TotalForSellerPaid4; v50.Clean = value; TotalForSellerPaid4 = v50;
                var v51 = TotalForSellerPaid5; v51.Clean = value; TotalForSellerPaid5 = v51;
                var v52 = TotalForSellerPaid6; v52.Clean = value; TotalForSellerPaid6 = v52;
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
    }
}