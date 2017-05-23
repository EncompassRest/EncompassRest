using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Page
    {
        public JsonNullable<int?> BalloonPaymentDueInYears { get; set; }
        public string BrokerCompensationFwbc { get; set; }
        public string BrokerCompensationFwsc { get; set; }
        public JsonNullable<decimal?> CuredGfeTotalTolerance { get; set; }
        public JsonNullable<DateTime?> FirstArmChangeDate { get; set; }
        public JsonNullable<List<Gfe2010FwbcFwsc>> Gfe2010FwbcFwscs { get; set; }
        public JsonNullable<List<Gfe2010GfeCharge>> Gfe2010GfeCharges { get; set; }
        public string GfeRecordingCharges { get; set; }
        public JsonNullable<decimal?> GfeTotalTolerance { get; set; }
        public JsonNullable<bool?> HasEscrowAccountIndicator { get; set; }
        public JsonNullable<bool?> HasEscrowCityPropertyTaxesIndicator { get; set; }
        public JsonNullable<bool?> HasEscrowFloodInsurancesIndicator { get; set; }
        public JsonNullable<bool?> HasEscrowHomeownerInsurancesIndicator { get; set; }
        public JsonNullable<bool?> HasEscrowPropertyTaxesIndicator { get; set; }
        public JsonNullable<bool?> HasEscrowUserDefinedIndicator1 { get; set; }
        public JsonNullable<bool?> HasEscrowUserDefinedIndicator2 { get; set; }
        public JsonNullable<bool?> HasEscrowUserDefinedIndicator3 { get; set; }
        public JsonNullable<bool?> HasEscrowUserDefinedIndicator4 { get; set; }
        public JsonNullable<decimal?> HighestArmRate { get; set; }
        public JsonNullable<decimal?> Hud1GovernmentRecordingCharge { get; set; }
        public JsonNullable<decimal?> Hud1Pg1SellerPaidClosingCostsAmount { get; set; }
        public JsonNullable<decimal?> Hud1Pg1TotalSettlementCharges { get; set; }
        public JsonNullable<decimal?> Hud1Pg2SellerPaidClosingCostsAmount { get; set; }
        public JsonNullable<decimal?> Hud1Pg2TotalSettlementCharges { get; set; }
        public JsonNullable<decimal?> HudTotalTolerance { get; set; }
        public JsonNullable<decimal?> HudTotalToleranceIncreasePercent { get; set; }
        public string Id { get; set; }
        public JsonNullable<decimal?> Line1101SellerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line1201SellerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line1301SellerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line801BorrowerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line801SellerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line802BorrowerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line803BorrowerPaidTotal { get; set; }
        public JsonNullable<decimal?> Line803SellerPaidTotal { get; set; }
        public JsonNullable<bool?> Line818FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line818FwscIndicator { get; set; }
        public JsonNullable<bool?> Line819FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line819FwscIndicator { get; set; }
        public JsonNullable<bool?> Line820FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line820FwscIndicator { get; set; }
        public JsonNullable<bool?> Line821FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line821FwscIndicator { get; set; }
        public JsonNullable<bool?> Line822FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line822FwscIndicator { get; set; }
        public JsonNullable<bool?> Line823FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line823FwscIndicator { get; set; }
        public JsonNullable<bool?> Line824FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line824FwscIndicator { get; set; }
        public JsonNullable<bool?> Line825FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line825FwscIndicator { get; set; }
        public JsonNullable<bool?> Line826FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line826FwscIndicator { get; set; }
        public JsonNullable<bool?> Line827FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line827FwscIndicator { get; set; }
        public JsonNullable<bool?> Line828FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line828FwscIndicator { get; set; }
        public JsonNullable<bool?> Line829FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line829FwscIndicator { get; set; }
        public JsonNullable<bool?> Line830FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line830FwscIndicator { get; set; }
        public JsonNullable<bool?> Line831FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line831FwscIndicator { get; set; }
        public JsonNullable<bool?> Line832FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line832FwscIndicator { get; set; }
        public JsonNullable<bool?> Line833FwbcIndicator { get; set; }
        public JsonNullable<bool?> Line833FwscIndicator { get; set; }
        public JsonNullable<bool?> LineLFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineLFwscIndicator { get; set; }
        public JsonNullable<bool?> LineMFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineMFwscIndicator { get; set; }
        public JsonNullable<bool?> LineNFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineNFwscIndicator { get; set; }
        public JsonNullable<bool?> LineOFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineOFwscIndicator { get; set; }
        public JsonNullable<bool?> LinePFwbcIndicator { get; set; }
        public JsonNullable<bool?> LinePFwscIndicator { get; set; }
        public JsonNullable<bool?> LineQFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineQFwscIndicator { get; set; }
        public JsonNullable<bool?> LineRFwbcIndicator { get; set; }
        public JsonNullable<bool?> LineRFwscIndicator { get; set; }
        public JsonNullable<decimal?> LowestArmRate { get; set; }
        public JsonNullable<bool?> MonthlyAmountIncludeInterestIndicator { get; set; }
        public JsonNullable<bool?> MonthlyAmountIncludeMiIndicator { get; set; }
        public JsonNullable<bool?> MonthlyAmountIncludePrincipalIndicator { get; set; }
        public JsonNullable<decimal?> MonthlyAmountWithEscrow { get; set; }
        public JsonNullable<decimal?> MonthlyEscrowPayment { get; set; }
        public JsonNullable<decimal?> PrepaidInterest { get; set; }
        public JsonNullable<decimal?> TotalToleranceIncreaseAmount { get; set; }
    }
}