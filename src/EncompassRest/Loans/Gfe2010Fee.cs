using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Fee
    {
        public Value<decimal?> AdditionalAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalAmount() => !AdditionalAmount.Clean;
        public Value<decimal?> Amount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAmount() => !Amount.Clean;
        public Value<bool?> AprIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAprIndicator() => !AprIndicator.Clean;
        public Value<decimal?> BorPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorPaidAmount() => !BorPaidAmount.Clean;
        public Value<decimal?> BorrowerAmountPaid2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerAmountPaid2015() => !BorrowerAmountPaid2015.Clean;
        public Value<bool?> BorrowerCanShopForIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerCanShopForIndicator2015() => !BorrowerCanShopForIndicator2015.Clean;
        public Value<bool?> BorrowerDidShopForIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerDidShopForIndicator2015() => !BorrowerDidShopForIndicator2015.Clean;
        public Value<decimal?> BorrowerFinanced2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerFinanced2015() => !BorrowerFinanced2015.Clean;
        public Value<decimal?> BorrowerPAC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPAC2015() => !BorrowerPAC2015.Clean;
        public Value<decimal?> BorrowerPOC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPOC2015() => !BorrowerPOC2015.Clean;
        public Value<decimal?> BorrowerPTC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerPTC2015() => !BorrowerPTC2015.Clean;
        public Value<bool?> BorrowerSelectIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBorrowerSelectIndicator() => !BorrowerSelectIndicator.Clean;
        public Value<decimal?> BrokerAmountPaid2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerAmountPaid2015() => !BrokerAmountPaid2015.Clean;
        public Value<decimal?> BrokerPAC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPAC2015() => !BrokerPAC2015.Clean;
        public Value<decimal?> BrokerPOC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerPOC2015() => !BrokerPOC2015.Clean;
        public Value<string> Description { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDescription() => !Description.Clean;
        public Value<bool?> EscrowedIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeEscrowedIndicator2015() => !EscrowedIndicator2015.Clean;
        public Value<bool?> FinancedIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFinancedIndicator() => !FinancedIndicator.Clean;
        public Value<int?> Gfe2010FeeIndex { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FeeIndex() => !Gfe2010FeeIndex.Clean;
        public Value<string> Gfe2010FeeParentType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FeeParentType() => !Gfe2010FeeParentType.Clean;
        public Value<string> Gfe2010FeeType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FeeType() => !Gfe2010FeeType.Clean;
        public Value<decimal?> GfeAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeAmount() => !GfeAmount.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<bool?> InsuranceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInsuranceIndicator2015() => !InsuranceIndicator2015.Clean;
        public Value<decimal?> LastDisclosedClosingDisclosure2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedClosingDisclosure2015() => !LastDisclosedClosingDisclosure2015.Clean;
        public Value<int?> LastDisclosedLoanEstimate2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLastDisclosedLoanEstimate2015() => !LastDisclosedLoanEstimate2015.Clean;
        public Value<decimal?> LenderAmountPaid2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderAmountPaid2015() => !LenderAmountPaid2015.Clean;
        public Value<decimal?> LenderPAC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPAC2015() => !LenderPAC2015.Clean;
        public Value<decimal?> LenderPOC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLenderPOC2015() => !LenderPOC2015.Clean;
        public Value<decimal?> MonthlyPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyPayment() => !MonthlyPayment.Clean;
        public Value<int?> NumberOfMonths { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNumberOfMonths() => !NumberOfMonths.Clean;
        public Value<bool?> OptionalIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOptionalIndicator2015() => !OptionalIndicator2015.Clean;
        public Value<decimal?> OtherAmountPaid2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherAmountPaid2015() => !OtherAmountPaid2015.Clean;
        public Value<decimal?> OtherPAC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherPAC2015() => !OtherPAC2015.Clean;
        public Value<decimal?> OtherPOC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherPOC2015() => !OtherPOC2015.Clean;
        public Value<string> PaidByType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidByType() => !PaidByType.Clean;
        public Value<string> PaidToName { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePaidToName() => !PaidToName.Clean;
        public Value<bool?> PocPtcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePocPtcIndicator() => !PocPtcIndicator.Clean;
        public Value<bool?> PropertyIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePropertyIndicator2015() => !PropertyIndicator2015.Clean;
        public Value<string> PtbType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePtbType() => !PtbType.Clean;
        public Value<decimal?> Rate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRate() => !Rate.Clean;
        public Value<decimal?> RetainedAmount2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeRetainedAmount2015() => !RetainedAmount2015.Clean;
        public Value<decimal?> Sec32PointsAndFees2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSec32PointsAndFees2015() => !Sec32PointsAndFees2015.Clean;
        public Value<decimal?> SellerAmountPaid2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerAmountPaid2015() => !SellerAmountPaid2015.Clean;
        public Value<bool?> SellerCreditIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerCreditIndicator2015() => !SellerCreditIndicator2015.Clean;
        public Value<decimal?> SellerObligatedAmount2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerObligatedAmount2015() => !SellerObligatedAmount2015.Clean;
        public Value<bool?> SellerObligatedIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerObligatedIndicator2015() => !SellerObligatedIndicator2015.Clean;
        public Value<decimal?> SellerPAC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPAC2015() => !SellerPAC2015.Clean;
        public Value<decimal?> SellerPOC2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSellerPOC2015() => !SellerPOC2015.Clean;
        public Value<decimal?> SelPaidAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSelPaidAmount() => !SelPaidAmount.Clean;
        public Value<bool?> SimultaneousIssuanceIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeSimultaneousIssuanceIndicator2015() => !SimultaneousIssuanceIndicator2015.Clean;
        public Value<bool?> TaxesIndicator2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTaxesIndicator2015() => !TaxesIndicator2015.Clean;
        public Value<bool?> TitleServiceSelectIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTitleServiceSelectIndicator() => !TitleServiceSelectIndicator.Clean;
        public Value<decimal?> TotalFeeAmount2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFeeAmount2015() => !TotalFeeAmount2015.Clean;
        public Value<decimal?> TotalFeePercentage2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalFeePercentage2015() => !TotalFeePercentage2015.Clean;
        public Value<decimal?> TotalPaidByBLO2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalPaidByBLO2015() => !TotalPaidByBLO2015.Clean;
        public Value<decimal?> UndiscountedInsurance2015 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeUndiscountedInsurance2015() => !UndiscountedInsurance2015.Clean;
        public Value<decimal?> WholePoc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWholePoc() => !WholePoc.Clean;
        public Value<string> WholePocPaidByType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWholePocPaidByType() => !WholePocPaidByType.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalAmount.Clean
                    && Amount.Clean
                    && AprIndicator.Clean
                    && BorPaidAmount.Clean
                    && BorrowerAmountPaid2015.Clean
                    && BorrowerCanShopForIndicator2015.Clean
                    && BorrowerDidShopForIndicator2015.Clean
                    && BorrowerFinanced2015.Clean
                    && BorrowerPAC2015.Clean
                    && BorrowerPOC2015.Clean
                    && BorrowerPTC2015.Clean
                    && BorrowerSelectIndicator.Clean
                    && BrokerAmountPaid2015.Clean
                    && BrokerPAC2015.Clean
                    && BrokerPOC2015.Clean
                    && Description.Clean
                    && EscrowedIndicator2015.Clean
                    && FinancedIndicator.Clean
                    && Gfe2010FeeIndex.Clean
                    && Gfe2010FeeParentType.Clean
                    && Gfe2010FeeType.Clean
                    && GfeAmount.Clean
                    && Id.Clean
                    && InsuranceIndicator2015.Clean
                    && LastDisclosedClosingDisclosure2015.Clean
                    && LastDisclosedLoanEstimate2015.Clean
                    && LenderAmountPaid2015.Clean
                    && LenderPAC2015.Clean
                    && LenderPOC2015.Clean
                    && MonthlyPayment.Clean
                    && NumberOfMonths.Clean
                    && OptionalIndicator2015.Clean
                    && OtherAmountPaid2015.Clean
                    && OtherPAC2015.Clean
                    && OtherPOC2015.Clean
                    && PaidByType.Clean
                    && PaidToName.Clean
                    && PocPtcIndicator.Clean
                    && PropertyIndicator2015.Clean
                    && PtbType.Clean
                    && Rate.Clean
                    && RetainedAmount2015.Clean
                    && Sec32PointsAndFees2015.Clean
                    && SellerAmountPaid2015.Clean
                    && SellerCreditIndicator2015.Clean
                    && SellerObligatedAmount2015.Clean
                    && SellerObligatedIndicator2015.Clean
                    && SellerPAC2015.Clean
                    && SellerPOC2015.Clean
                    && SelPaidAmount.Clean
                    && SimultaneousIssuanceIndicator2015.Clean
                    && TaxesIndicator2015.Clean
                    && TitleServiceSelectIndicator.Clean
                    && TotalFeeAmount2015.Clean
                    && TotalFeePercentage2015.Clean
                    && TotalPaidByBLO2015.Clean
                    && UndiscountedInsurance2015.Clean
                    && WholePoc.Clean
                    && WholePocPaidByType.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalAmount; v0.Clean = value; AdditionalAmount = v0;
                var v1 = Amount; v1.Clean = value; Amount = v1;
                var v2 = AprIndicator; v2.Clean = value; AprIndicator = v2;
                var v3 = BorPaidAmount; v3.Clean = value; BorPaidAmount = v3;
                var v4 = BorrowerAmountPaid2015; v4.Clean = value; BorrowerAmountPaid2015 = v4;
                var v5 = BorrowerCanShopForIndicator2015; v5.Clean = value; BorrowerCanShopForIndicator2015 = v5;
                var v6 = BorrowerDidShopForIndicator2015; v6.Clean = value; BorrowerDidShopForIndicator2015 = v6;
                var v7 = BorrowerFinanced2015; v7.Clean = value; BorrowerFinanced2015 = v7;
                var v8 = BorrowerPAC2015; v8.Clean = value; BorrowerPAC2015 = v8;
                var v9 = BorrowerPOC2015; v9.Clean = value; BorrowerPOC2015 = v9;
                var v10 = BorrowerPTC2015; v10.Clean = value; BorrowerPTC2015 = v10;
                var v11 = BorrowerSelectIndicator; v11.Clean = value; BorrowerSelectIndicator = v11;
                var v12 = BrokerAmountPaid2015; v12.Clean = value; BrokerAmountPaid2015 = v12;
                var v13 = BrokerPAC2015; v13.Clean = value; BrokerPAC2015 = v13;
                var v14 = BrokerPOC2015; v14.Clean = value; BrokerPOC2015 = v14;
                var v15 = Description; v15.Clean = value; Description = v15;
                var v16 = EscrowedIndicator2015; v16.Clean = value; EscrowedIndicator2015 = v16;
                var v17 = FinancedIndicator; v17.Clean = value; FinancedIndicator = v17;
                var v18 = Gfe2010FeeIndex; v18.Clean = value; Gfe2010FeeIndex = v18;
                var v19 = Gfe2010FeeParentType; v19.Clean = value; Gfe2010FeeParentType = v19;
                var v20 = Gfe2010FeeType; v20.Clean = value; Gfe2010FeeType = v20;
                var v21 = GfeAmount; v21.Clean = value; GfeAmount = v21;
                var v22 = Id; v22.Clean = value; Id = v22;
                var v23 = InsuranceIndicator2015; v23.Clean = value; InsuranceIndicator2015 = v23;
                var v24 = LastDisclosedClosingDisclosure2015; v24.Clean = value; LastDisclosedClosingDisclosure2015 = v24;
                var v25 = LastDisclosedLoanEstimate2015; v25.Clean = value; LastDisclosedLoanEstimate2015 = v25;
                var v26 = LenderAmountPaid2015; v26.Clean = value; LenderAmountPaid2015 = v26;
                var v27 = LenderPAC2015; v27.Clean = value; LenderPAC2015 = v27;
                var v28 = LenderPOC2015; v28.Clean = value; LenderPOC2015 = v28;
                var v29 = MonthlyPayment; v29.Clean = value; MonthlyPayment = v29;
                var v30 = NumberOfMonths; v30.Clean = value; NumberOfMonths = v30;
                var v31 = OptionalIndicator2015; v31.Clean = value; OptionalIndicator2015 = v31;
                var v32 = OtherAmountPaid2015; v32.Clean = value; OtherAmountPaid2015 = v32;
                var v33 = OtherPAC2015; v33.Clean = value; OtherPAC2015 = v33;
                var v34 = OtherPOC2015; v34.Clean = value; OtherPOC2015 = v34;
                var v35 = PaidByType; v35.Clean = value; PaidByType = v35;
                var v36 = PaidToName; v36.Clean = value; PaidToName = v36;
                var v37 = PocPtcIndicator; v37.Clean = value; PocPtcIndicator = v37;
                var v38 = PropertyIndicator2015; v38.Clean = value; PropertyIndicator2015 = v38;
                var v39 = PtbType; v39.Clean = value; PtbType = v39;
                var v40 = Rate; v40.Clean = value; Rate = v40;
                var v41 = RetainedAmount2015; v41.Clean = value; RetainedAmount2015 = v41;
                var v42 = Sec32PointsAndFees2015; v42.Clean = value; Sec32PointsAndFees2015 = v42;
                var v43 = SellerAmountPaid2015; v43.Clean = value; SellerAmountPaid2015 = v43;
                var v44 = SellerCreditIndicator2015; v44.Clean = value; SellerCreditIndicator2015 = v44;
                var v45 = SellerObligatedAmount2015; v45.Clean = value; SellerObligatedAmount2015 = v45;
                var v46 = SellerObligatedIndicator2015; v46.Clean = value; SellerObligatedIndicator2015 = v46;
                var v47 = SellerPAC2015; v47.Clean = value; SellerPAC2015 = v47;
                var v48 = SellerPOC2015; v48.Clean = value; SellerPOC2015 = v48;
                var v49 = SelPaidAmount; v49.Clean = value; SelPaidAmount = v49;
                var v50 = SimultaneousIssuanceIndicator2015; v50.Clean = value; SimultaneousIssuanceIndicator2015 = v50;
                var v51 = TaxesIndicator2015; v51.Clean = value; TaxesIndicator2015 = v51;
                var v52 = TitleServiceSelectIndicator; v52.Clean = value; TitleServiceSelectIndicator = v52;
                var v53 = TotalFeeAmount2015; v53.Clean = value; TotalFeeAmount2015 = v53;
                var v54 = TotalFeePercentage2015; v54.Clean = value; TotalFeePercentage2015 = v54;
                var v55 = TotalPaidByBLO2015; v55.Clean = value; TotalPaidByBLO2015 = v55;
                var v56 = UndiscountedInsurance2015; v56.Clean = value; UndiscountedInsurance2015 = v56;
                var v57 = WholePoc; v57.Clean = value; WholePoc = v57;
                var v58 = WholePocPaidByType; v58.Clean = value; WholePocPaidByType = v58;
                _settingClean = 0;
            }
        }
    }
}