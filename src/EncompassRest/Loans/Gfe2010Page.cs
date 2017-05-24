using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Page
    {
        public Value<int?> BalloonPaymentDueInYears { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonPaymentDueInYears() => !BalloonPaymentDueInYears.Clean;
        public Value<string> BrokerCompensationFwbc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFwbc() => !BrokerCompensationFwbc.Clean;
        public Value<string> BrokerCompensationFwsc { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFwsc() => !BrokerCompensationFwsc.Clean;
        public Value<decimal?> CuredGfeTotalTolerance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredGfeTotalTolerance() => !CuredGfeTotalTolerance.Clean;
        public Value<DateTime?> FirstArmChangeDate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstArmChangeDate() => !FirstArmChangeDate.Clean;
        public Value<List<Gfe2010FwbcFwsc>> Gfe2010FwbcFwscs { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FwbcFwscs() => !Gfe2010FwbcFwscs.Clean;
        public Value<List<Gfe2010GfeCharge>> Gfe2010GfeCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010GfeCharges() => !Gfe2010GfeCharges.Clean;
        public Value<string> GfeRecordingCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeRecordingCharges() => !GfeRecordingCharges.Clean;
        public Value<decimal?> GfeTotalTolerance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeTotalTolerance() => !GfeTotalTolerance.Clean;
        public Value<bool?> HasEscrowAccountIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowAccountIndicator() => !HasEscrowAccountIndicator.Clean;
        public Value<bool?> HasEscrowCityPropertyTaxesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowCityPropertyTaxesIndicator() => !HasEscrowCityPropertyTaxesIndicator.Clean;
        public Value<bool?> HasEscrowFloodInsurancesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowFloodInsurancesIndicator() => !HasEscrowFloodInsurancesIndicator.Clean;
        public Value<bool?> HasEscrowHomeownerInsurancesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowHomeownerInsurancesIndicator() => !HasEscrowHomeownerInsurancesIndicator.Clean;
        public Value<bool?> HasEscrowPropertyTaxesIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowPropertyTaxesIndicator() => !HasEscrowPropertyTaxesIndicator.Clean;
        public Value<bool?> HasEscrowUserDefinedIndicator1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator1() => !HasEscrowUserDefinedIndicator1.Clean;
        public Value<bool?> HasEscrowUserDefinedIndicator2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator2() => !HasEscrowUserDefinedIndicator2.Clean;
        public Value<bool?> HasEscrowUserDefinedIndicator3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator3() => !HasEscrowUserDefinedIndicator3.Clean;
        public Value<bool?> HasEscrowUserDefinedIndicator4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator4() => !HasEscrowUserDefinedIndicator4.Clean;
        public Value<decimal?> HighestArmRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighestArmRate() => !HighestArmRate.Clean;
        public Value<decimal?> Hud1GovernmentRecordingCharge { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1GovernmentRecordingCharge() => !Hud1GovernmentRecordingCharge.Clean;
        public Value<decimal?> Hud1Pg1SellerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg1SellerPaidClosingCostsAmount() => !Hud1Pg1SellerPaidClosingCostsAmount.Clean;
        public Value<decimal?> Hud1Pg1TotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg1TotalSettlementCharges() => !Hud1Pg1TotalSettlementCharges.Clean;
        public Value<decimal?> Hud1Pg2SellerPaidClosingCostsAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg2SellerPaidClosingCostsAmount() => !Hud1Pg2SellerPaidClosingCostsAmount.Clean;
        public Value<decimal?> Hud1Pg2TotalSettlementCharges { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg2TotalSettlementCharges() => !Hud1Pg2TotalSettlementCharges.Clean;
        public Value<decimal?> HudTotalTolerance { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudTotalTolerance() => !HudTotalTolerance.Clean;
        public Value<decimal?> HudTotalToleranceIncreasePercent { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudTotalToleranceIncreasePercent() => !HudTotalToleranceIncreasePercent.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<decimal?> Line1101SellerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1101SellerPaidTotal() => !Line1101SellerPaidTotal.Clean;
        public Value<decimal?> Line1201SellerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1201SellerPaidTotal() => !Line1201SellerPaidTotal.Clean;
        public Value<decimal?> Line1301SellerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1301SellerPaidTotal() => !Line1301SellerPaidTotal.Clean;
        public Value<decimal?> Line801BorrowerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801BorrowerPaidTotal() => !Line801BorrowerPaidTotal.Clean;
        public Value<decimal?> Line801SellerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801SellerPaidTotal() => !Line801SellerPaidTotal.Clean;
        public Value<decimal?> Line802BorrowerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802BorrowerPaidTotal() => !Line802BorrowerPaidTotal.Clean;
        public Value<decimal?> Line803BorrowerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine803BorrowerPaidTotal() => !Line803BorrowerPaidTotal.Clean;
        public Value<decimal?> Line803SellerPaidTotal { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine803SellerPaidTotal() => !Line803SellerPaidTotal.Clean;
        public Value<bool?> Line818FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine818FwbcIndicator() => !Line818FwbcIndicator.Clean;
        public Value<bool?> Line818FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine818FwscIndicator() => !Line818FwscIndicator.Clean;
        public Value<bool?> Line819FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine819FwbcIndicator() => !Line819FwbcIndicator.Clean;
        public Value<bool?> Line819FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine819FwscIndicator() => !Line819FwscIndicator.Clean;
        public Value<bool?> Line820FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine820FwbcIndicator() => !Line820FwbcIndicator.Clean;
        public Value<bool?> Line820FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine820FwscIndicator() => !Line820FwscIndicator.Clean;
        public Value<bool?> Line821FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine821FwbcIndicator() => !Line821FwbcIndicator.Clean;
        public Value<bool?> Line821FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine821FwscIndicator() => !Line821FwscIndicator.Clean;
        public Value<bool?> Line822FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine822FwbcIndicator() => !Line822FwbcIndicator.Clean;
        public Value<bool?> Line822FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine822FwscIndicator() => !Line822FwscIndicator.Clean;
        public Value<bool?> Line823FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine823FwbcIndicator() => !Line823FwbcIndicator.Clean;
        public Value<bool?> Line823FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine823FwscIndicator() => !Line823FwscIndicator.Clean;
        public Value<bool?> Line824FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine824FwbcIndicator() => !Line824FwbcIndicator.Clean;
        public Value<bool?> Line824FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine824FwscIndicator() => !Line824FwscIndicator.Clean;
        public Value<bool?> Line825FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine825FwbcIndicator() => !Line825FwbcIndicator.Clean;
        public Value<bool?> Line825FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine825FwscIndicator() => !Line825FwscIndicator.Clean;
        public Value<bool?> Line826FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine826FwbcIndicator() => !Line826FwbcIndicator.Clean;
        public Value<bool?> Line826FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine826FwscIndicator() => !Line826FwscIndicator.Clean;
        public Value<bool?> Line827FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine827FwbcIndicator() => !Line827FwbcIndicator.Clean;
        public Value<bool?> Line827FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine827FwscIndicator() => !Line827FwscIndicator.Clean;
        public Value<bool?> Line828FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine828FwbcIndicator() => !Line828FwbcIndicator.Clean;
        public Value<bool?> Line828FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine828FwscIndicator() => !Line828FwscIndicator.Clean;
        public Value<bool?> Line829FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine829FwbcIndicator() => !Line829FwbcIndicator.Clean;
        public Value<bool?> Line829FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine829FwscIndicator() => !Line829FwscIndicator.Clean;
        public Value<bool?> Line830FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine830FwbcIndicator() => !Line830FwbcIndicator.Clean;
        public Value<bool?> Line830FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine830FwscIndicator() => !Line830FwscIndicator.Clean;
        public Value<bool?> Line831FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine831FwbcIndicator() => !Line831FwbcIndicator.Clean;
        public Value<bool?> Line831FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine831FwscIndicator() => !Line831FwscIndicator.Clean;
        public Value<bool?> Line832FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine832FwbcIndicator() => !Line832FwbcIndicator.Clean;
        public Value<bool?> Line832FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine832FwscIndicator() => !Line832FwscIndicator.Clean;
        public Value<bool?> Line833FwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine833FwbcIndicator() => !Line833FwbcIndicator.Clean;
        public Value<bool?> Line833FwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine833FwscIndicator() => !Line833FwscIndicator.Clean;
        public Value<bool?> LineLFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLFwbcIndicator() => !LineLFwbcIndicator.Clean;
        public Value<bool?> LineLFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLFwscIndicator() => !LineLFwscIndicator.Clean;
        public Value<bool?> LineMFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineMFwbcIndicator() => !LineMFwbcIndicator.Clean;
        public Value<bool?> LineMFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineMFwscIndicator() => !LineMFwscIndicator.Clean;
        public Value<bool?> LineNFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNFwbcIndicator() => !LineNFwbcIndicator.Clean;
        public Value<bool?> LineNFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNFwscIndicator() => !LineNFwscIndicator.Clean;
        public Value<bool?> LineOFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineOFwbcIndicator() => !LineOFwbcIndicator.Clean;
        public Value<bool?> LineOFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineOFwscIndicator() => !LineOFwscIndicator.Clean;
        public Value<bool?> LinePFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinePFwbcIndicator() => !LinePFwbcIndicator.Clean;
        public Value<bool?> LinePFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinePFwscIndicator() => !LinePFwscIndicator.Clean;
        public Value<bool?> LineQFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineQFwbcIndicator() => !LineQFwbcIndicator.Clean;
        public Value<bool?> LineQFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineQFwscIndicator() => !LineQFwscIndicator.Clean;
        public Value<bool?> LineRFwbcIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineRFwbcIndicator() => !LineRFwbcIndicator.Clean;
        public Value<bool?> LineRFwscIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineRFwscIndicator() => !LineRFwscIndicator.Clean;
        public Value<decimal?> LowestArmRate { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowestArmRate() => !LowestArmRate.Clean;
        public Value<bool?> MonthlyAmountIncludeInterestIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludeInterestIndicator() => !MonthlyAmountIncludeInterestIndicator.Clean;
        public Value<bool?> MonthlyAmountIncludeMiIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludeMiIndicator() => !MonthlyAmountIncludeMiIndicator.Clean;
        public Value<bool?> MonthlyAmountIncludePrincipalIndicator { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludePrincipalIndicator() => !MonthlyAmountIncludePrincipalIndicator.Clean;
        public Value<decimal?> MonthlyAmountWithEscrow { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountWithEscrow() => !MonthlyAmountWithEscrow.Clean;
        public Value<decimal?> MonthlyEscrowPayment { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyEscrowPayment() => !MonthlyEscrowPayment.Clean;
        public Value<decimal?> PrepaidInterest { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidInterest() => !PrepaidInterest.Clean;
        public Value<decimal?> TotalToleranceIncreaseAmount { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalToleranceIncreaseAmount() => !TotalToleranceIncreaseAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = BalloonPaymentDueInYears.Clean
                    && BrokerCompensationFwbc.Clean
                    && BrokerCompensationFwsc.Clean
                    && CuredGfeTotalTolerance.Clean
                    && FirstArmChangeDate.Clean
                    && Gfe2010FwbcFwscs.Clean
                    && Gfe2010GfeCharges.Clean
                    && GfeRecordingCharges.Clean
                    && GfeTotalTolerance.Clean
                    && HasEscrowAccountIndicator.Clean
                    && HasEscrowCityPropertyTaxesIndicator.Clean
                    && HasEscrowFloodInsurancesIndicator.Clean
                    && HasEscrowHomeownerInsurancesIndicator.Clean
                    && HasEscrowPropertyTaxesIndicator.Clean
                    && HasEscrowUserDefinedIndicator1.Clean
                    && HasEscrowUserDefinedIndicator2.Clean
                    && HasEscrowUserDefinedIndicator3.Clean
                    && HasEscrowUserDefinedIndicator4.Clean
                    && HighestArmRate.Clean
                    && Hud1GovernmentRecordingCharge.Clean
                    && Hud1Pg1SellerPaidClosingCostsAmount.Clean
                    && Hud1Pg1TotalSettlementCharges.Clean
                    && Hud1Pg2SellerPaidClosingCostsAmount.Clean
                    && Hud1Pg2TotalSettlementCharges.Clean
                    && HudTotalTolerance.Clean
                    && HudTotalToleranceIncreasePercent.Clean
                    && Id.Clean
                    && Line1101SellerPaidTotal.Clean
                    && Line1201SellerPaidTotal.Clean
                    && Line1301SellerPaidTotal.Clean
                    && Line801BorrowerPaidTotal.Clean
                    && Line801SellerPaidTotal.Clean
                    && Line802BorrowerPaidTotal.Clean
                    && Line803BorrowerPaidTotal.Clean
                    && Line803SellerPaidTotal.Clean
                    && Line818FwbcIndicator.Clean
                    && Line818FwscIndicator.Clean
                    && Line819FwbcIndicator.Clean
                    && Line819FwscIndicator.Clean
                    && Line820FwbcIndicator.Clean
                    && Line820FwscIndicator.Clean
                    && Line821FwbcIndicator.Clean
                    && Line821FwscIndicator.Clean
                    && Line822FwbcIndicator.Clean
                    && Line822FwscIndicator.Clean
                    && Line823FwbcIndicator.Clean
                    && Line823FwscIndicator.Clean
                    && Line824FwbcIndicator.Clean
                    && Line824FwscIndicator.Clean
                    && Line825FwbcIndicator.Clean
                    && Line825FwscIndicator.Clean
                    && Line826FwbcIndicator.Clean
                    && Line826FwscIndicator.Clean
                    && Line827FwbcIndicator.Clean
                    && Line827FwscIndicator.Clean
                    && Line828FwbcIndicator.Clean
                    && Line828FwscIndicator.Clean
                    && Line829FwbcIndicator.Clean
                    && Line829FwscIndicator.Clean
                    && Line830FwbcIndicator.Clean
                    && Line830FwscIndicator.Clean
                    && Line831FwbcIndicator.Clean
                    && Line831FwscIndicator.Clean
                    && Line832FwbcIndicator.Clean
                    && Line832FwscIndicator.Clean
                    && Line833FwbcIndicator.Clean
                    && Line833FwscIndicator.Clean
                    && LineLFwbcIndicator.Clean
                    && LineLFwscIndicator.Clean
                    && LineMFwbcIndicator.Clean
                    && LineMFwscIndicator.Clean
                    && LineNFwbcIndicator.Clean
                    && LineNFwscIndicator.Clean
                    && LineOFwbcIndicator.Clean
                    && LineOFwscIndicator.Clean
                    && LinePFwbcIndicator.Clean
                    && LinePFwscIndicator.Clean
                    && LineQFwbcIndicator.Clean
                    && LineQFwscIndicator.Clean
                    && LineRFwbcIndicator.Clean
                    && LineRFwscIndicator.Clean
                    && LowestArmRate.Clean
                    && MonthlyAmountIncludeInterestIndicator.Clean
                    && MonthlyAmountIncludeMiIndicator.Clean
                    && MonthlyAmountIncludePrincipalIndicator.Clean
                    && MonthlyAmountWithEscrow.Clean
                    && MonthlyEscrowPayment.Clean
                    && PrepaidInterest.Clean
                    && TotalToleranceIncreaseAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = BalloonPaymentDueInYears; v0.Clean = value; BalloonPaymentDueInYears = v0;
                var v1 = BrokerCompensationFwbc; v1.Clean = value; BrokerCompensationFwbc = v1;
                var v2 = BrokerCompensationFwsc; v2.Clean = value; BrokerCompensationFwsc = v2;
                var v3 = CuredGfeTotalTolerance; v3.Clean = value; CuredGfeTotalTolerance = v3;
                var v4 = FirstArmChangeDate; v4.Clean = value; FirstArmChangeDate = v4;
                var v5 = Gfe2010FwbcFwscs; v5.Clean = value; Gfe2010FwbcFwscs = v5;
                var v6 = Gfe2010GfeCharges; v6.Clean = value; Gfe2010GfeCharges = v6;
                var v7 = GfeRecordingCharges; v7.Clean = value; GfeRecordingCharges = v7;
                var v8 = GfeTotalTolerance; v8.Clean = value; GfeTotalTolerance = v8;
                var v9 = HasEscrowAccountIndicator; v9.Clean = value; HasEscrowAccountIndicator = v9;
                var v10 = HasEscrowCityPropertyTaxesIndicator; v10.Clean = value; HasEscrowCityPropertyTaxesIndicator = v10;
                var v11 = HasEscrowFloodInsurancesIndicator; v11.Clean = value; HasEscrowFloodInsurancesIndicator = v11;
                var v12 = HasEscrowHomeownerInsurancesIndicator; v12.Clean = value; HasEscrowHomeownerInsurancesIndicator = v12;
                var v13 = HasEscrowPropertyTaxesIndicator; v13.Clean = value; HasEscrowPropertyTaxesIndicator = v13;
                var v14 = HasEscrowUserDefinedIndicator1; v14.Clean = value; HasEscrowUserDefinedIndicator1 = v14;
                var v15 = HasEscrowUserDefinedIndicator2; v15.Clean = value; HasEscrowUserDefinedIndicator2 = v15;
                var v16 = HasEscrowUserDefinedIndicator3; v16.Clean = value; HasEscrowUserDefinedIndicator3 = v16;
                var v17 = HasEscrowUserDefinedIndicator4; v17.Clean = value; HasEscrowUserDefinedIndicator4 = v17;
                var v18 = HighestArmRate; v18.Clean = value; HighestArmRate = v18;
                var v19 = Hud1GovernmentRecordingCharge; v19.Clean = value; Hud1GovernmentRecordingCharge = v19;
                var v20 = Hud1Pg1SellerPaidClosingCostsAmount; v20.Clean = value; Hud1Pg1SellerPaidClosingCostsAmount = v20;
                var v21 = Hud1Pg1TotalSettlementCharges; v21.Clean = value; Hud1Pg1TotalSettlementCharges = v21;
                var v22 = Hud1Pg2SellerPaidClosingCostsAmount; v22.Clean = value; Hud1Pg2SellerPaidClosingCostsAmount = v22;
                var v23 = Hud1Pg2TotalSettlementCharges; v23.Clean = value; Hud1Pg2TotalSettlementCharges = v23;
                var v24 = HudTotalTolerance; v24.Clean = value; HudTotalTolerance = v24;
                var v25 = HudTotalToleranceIncreasePercent; v25.Clean = value; HudTotalToleranceIncreasePercent = v25;
                var v26 = Id; v26.Clean = value; Id = v26;
                var v27 = Line1101SellerPaidTotal; v27.Clean = value; Line1101SellerPaidTotal = v27;
                var v28 = Line1201SellerPaidTotal; v28.Clean = value; Line1201SellerPaidTotal = v28;
                var v29 = Line1301SellerPaidTotal; v29.Clean = value; Line1301SellerPaidTotal = v29;
                var v30 = Line801BorrowerPaidTotal; v30.Clean = value; Line801BorrowerPaidTotal = v30;
                var v31 = Line801SellerPaidTotal; v31.Clean = value; Line801SellerPaidTotal = v31;
                var v32 = Line802BorrowerPaidTotal; v32.Clean = value; Line802BorrowerPaidTotal = v32;
                var v33 = Line803BorrowerPaidTotal; v33.Clean = value; Line803BorrowerPaidTotal = v33;
                var v34 = Line803SellerPaidTotal; v34.Clean = value; Line803SellerPaidTotal = v34;
                var v35 = Line818FwbcIndicator; v35.Clean = value; Line818FwbcIndicator = v35;
                var v36 = Line818FwscIndicator; v36.Clean = value; Line818FwscIndicator = v36;
                var v37 = Line819FwbcIndicator; v37.Clean = value; Line819FwbcIndicator = v37;
                var v38 = Line819FwscIndicator; v38.Clean = value; Line819FwscIndicator = v38;
                var v39 = Line820FwbcIndicator; v39.Clean = value; Line820FwbcIndicator = v39;
                var v40 = Line820FwscIndicator; v40.Clean = value; Line820FwscIndicator = v40;
                var v41 = Line821FwbcIndicator; v41.Clean = value; Line821FwbcIndicator = v41;
                var v42 = Line821FwscIndicator; v42.Clean = value; Line821FwscIndicator = v42;
                var v43 = Line822FwbcIndicator; v43.Clean = value; Line822FwbcIndicator = v43;
                var v44 = Line822FwscIndicator; v44.Clean = value; Line822FwscIndicator = v44;
                var v45 = Line823FwbcIndicator; v45.Clean = value; Line823FwbcIndicator = v45;
                var v46 = Line823FwscIndicator; v46.Clean = value; Line823FwscIndicator = v46;
                var v47 = Line824FwbcIndicator; v47.Clean = value; Line824FwbcIndicator = v47;
                var v48 = Line824FwscIndicator; v48.Clean = value; Line824FwscIndicator = v48;
                var v49 = Line825FwbcIndicator; v49.Clean = value; Line825FwbcIndicator = v49;
                var v50 = Line825FwscIndicator; v50.Clean = value; Line825FwscIndicator = v50;
                var v51 = Line826FwbcIndicator; v51.Clean = value; Line826FwbcIndicator = v51;
                var v52 = Line826FwscIndicator; v52.Clean = value; Line826FwscIndicator = v52;
                var v53 = Line827FwbcIndicator; v53.Clean = value; Line827FwbcIndicator = v53;
                var v54 = Line827FwscIndicator; v54.Clean = value; Line827FwscIndicator = v54;
                var v55 = Line828FwbcIndicator; v55.Clean = value; Line828FwbcIndicator = v55;
                var v56 = Line828FwscIndicator; v56.Clean = value; Line828FwscIndicator = v56;
                var v57 = Line829FwbcIndicator; v57.Clean = value; Line829FwbcIndicator = v57;
                var v58 = Line829FwscIndicator; v58.Clean = value; Line829FwscIndicator = v58;
                var v59 = Line830FwbcIndicator; v59.Clean = value; Line830FwbcIndicator = v59;
                var v60 = Line830FwscIndicator; v60.Clean = value; Line830FwscIndicator = v60;
                var v61 = Line831FwbcIndicator; v61.Clean = value; Line831FwbcIndicator = v61;
                var v62 = Line831FwscIndicator; v62.Clean = value; Line831FwscIndicator = v62;
                var v63 = Line832FwbcIndicator; v63.Clean = value; Line832FwbcIndicator = v63;
                var v64 = Line832FwscIndicator; v64.Clean = value; Line832FwscIndicator = v64;
                var v65 = Line833FwbcIndicator; v65.Clean = value; Line833FwbcIndicator = v65;
                var v66 = Line833FwscIndicator; v66.Clean = value; Line833FwscIndicator = v66;
                var v67 = LineLFwbcIndicator; v67.Clean = value; LineLFwbcIndicator = v67;
                var v68 = LineLFwscIndicator; v68.Clean = value; LineLFwscIndicator = v68;
                var v69 = LineMFwbcIndicator; v69.Clean = value; LineMFwbcIndicator = v69;
                var v70 = LineMFwscIndicator; v70.Clean = value; LineMFwscIndicator = v70;
                var v71 = LineNFwbcIndicator; v71.Clean = value; LineNFwbcIndicator = v71;
                var v72 = LineNFwscIndicator; v72.Clean = value; LineNFwscIndicator = v72;
                var v73 = LineOFwbcIndicator; v73.Clean = value; LineOFwbcIndicator = v73;
                var v74 = LineOFwscIndicator; v74.Clean = value; LineOFwscIndicator = v74;
                var v75 = LinePFwbcIndicator; v75.Clean = value; LinePFwbcIndicator = v75;
                var v76 = LinePFwscIndicator; v76.Clean = value; LinePFwscIndicator = v76;
                var v77 = LineQFwbcIndicator; v77.Clean = value; LineQFwbcIndicator = v77;
                var v78 = LineQFwscIndicator; v78.Clean = value; LineQFwscIndicator = v78;
                var v79 = LineRFwbcIndicator; v79.Clean = value; LineRFwbcIndicator = v79;
                var v80 = LineRFwscIndicator; v80.Clean = value; LineRFwscIndicator = v80;
                var v81 = LowestArmRate; v81.Clean = value; LowestArmRate = v81;
                var v82 = MonthlyAmountIncludeInterestIndicator; v82.Clean = value; MonthlyAmountIncludeInterestIndicator = v82;
                var v83 = MonthlyAmountIncludeMiIndicator; v83.Clean = value; MonthlyAmountIncludeMiIndicator = v83;
                var v84 = MonthlyAmountIncludePrincipalIndicator; v84.Clean = value; MonthlyAmountIncludePrincipalIndicator = v84;
                var v85 = MonthlyAmountWithEscrow; v85.Clean = value; MonthlyAmountWithEscrow = v85;
                var v86 = MonthlyEscrowPayment; v86.Clean = value; MonthlyEscrowPayment = v86;
                var v87 = PrepaidInterest; v87.Clean = value; PrepaidInterest = v87;
                var v88 = TotalToleranceIncreaseAmount; v88.Clean = value; TotalToleranceIncreaseAmount = v88;
                _settingClean = 0;
            }
        }
    }
}