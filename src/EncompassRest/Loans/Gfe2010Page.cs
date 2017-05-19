using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class Gfe2010Page
    {
        public decimal? Hud1Pg2TotalSettlementCharges { get; set; }
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get; set; }
        public List<Gfe2010GfeCharge> Gfe2010GfeCharges { get; set; }
        public string GfeRecordingCharges { get; set; }
        public decimal? GfeTotalTolerance { get; set; }
        public decimal? CuredGfeTotalTolerance { get; set; }
        public decimal? HudTotalTolerance { get; set; }
        public decimal? TotalToleranceIncreaseAmount { get; set; }
        public decimal? HudTotalToleranceIncreasePercent { get; set; }
        public DateTime? FirstArmChangeDate { get; set; }
        public decimal? LowestArmRate { get; set; }
        public decimal? HighestArmRate { get; set; }
        public bool? HasEscrowAccountIndicator { get; set; }
        public decimal? Hud1GovernmentRecordingCharge { get; set; }
        public bool? HasEscrowPropertyTaxesIndicator { get; set; }
        public bool? HasEscrowFloodInsurancesIndicator { get; set; }
        public bool? HasEscrowHomeownerInsurancesIndicator { get; set; }
        public bool? HasEscrowUserDefinedIndicator1 { get; set; }
        public bool? HasEscrowUserDefinedIndicator2 { get; set; }
        public bool? HasEscrowUserDefinedIndicator3 { get; set; }
        public bool? HasEscrowUserDefinedIndicator4 { get; set; }
        public bool? HasEscrowCityPropertyTaxesIndicator { get; set; }
        public int? BalloonPaymentDueInYears { get; set; }
        public bool? MonthlyAmountIncludePrincipalIndicator { get; set; }
        public bool? MonthlyAmountIncludeInterestIndicator { get; set; }
        public bool? MonthlyAmountIncludeMiIndicator { get; set; }
        public List<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get; set; }
        public string BrokerCompensationFwbc { get; set; }
        public string BrokerCompensationFwsc { get; set; }
        public decimal? Hud1Pg1TotalSettlementCharges { get; set; }
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get; set; }
        public decimal? Line801SellerPaidTotal { get; set; }
        public decimal? Line801BorrowerPaidTotal { get; set; }
        public decimal? Line803BorrowerPaidTotal { get; set; }
        public decimal? Line802BorrowerPaidTotal { get; set; }
        public decimal? Line1101SellerPaidTotal { get; set; }
        public decimal? Line1201SellerPaidTotal { get; set; }
        public decimal? Line1301SellerPaidTotal { get; set; }
        public decimal? Line803SellerPaidTotal { get; set; }
        public decimal? MonthlyAmountWithEscrow { get; set; }
        public decimal? PrepaidInterest { get; set; }
        public decimal? MonthlyEscrowPayment { get; set; }
        public bool? LineLFwbcIndicator { get; set; }
        public bool? LineMFwbcIndicator { get; set; }
        public bool? LineNFwbcIndicator { get; set; }
        public bool? LineOFwbcIndicator { get; set; }
        public bool? LinePFwbcIndicator { get; set; }
        public bool? LineQFwbcIndicator { get; set; }
        public bool? LineRFwbcIndicator { get; set; }
        public bool? Line818FwbcIndicator { get; set; }
        public bool? Line819FwbcIndicator { get; set; }
        public bool? Line820FwbcIndicator { get; set; }
        public bool? Line821FwbcIndicator { get; set; }
        public bool? Line822FwbcIndicator { get; set; }
        public bool? Line823FwbcIndicator { get; set; }
        public bool? Line824FwbcIndicator { get; set; }
        public bool? Line825FwbcIndicator { get; set; }
        public bool? Line826FwbcIndicator { get; set; }
        public bool? Line827FwbcIndicator { get; set; }
        public bool? Line828FwbcIndicator { get; set; }
        public bool? Line829FwbcIndicator { get; set; }
        public bool? Line830FwbcIndicator { get; set; }
        public bool? Line831FwbcIndicator { get; set; }
        public bool? Line832FwbcIndicator { get; set; }
        public bool? Line833FwbcIndicator { get; set; }
        public bool? LineLFwscIndicator { get; set; }
        public bool? LineMFwscIndicator { get; set; }
        public bool? LineNFwscIndicator { get; set; }
        public bool? LineOFwscIndicator { get; set; }
        public bool? LinePFwscIndicator { get; set; }
        public bool? LineQFwscIndicator { get; set; }
        public bool? LineRFwscIndicator { get; set; }
        public bool? Line818FwscIndicator { get; set; }
        public bool? Line819FwscIndicator { get; set; }
        public bool? Line820FwscIndicator { get; set; }
        public bool? Line821FwscIndicator { get; set; }
        public bool? Line822FwscIndicator { get; set; }
        public bool? Line823FwscIndicator { get; set; }
        public bool? Line824FwscIndicator { get; set; }
        public bool? Line825FwscIndicator { get; set; }
        public bool? Line826FwscIndicator { get; set; }
        public bool? Line827FwscIndicator { get; set; }
        public bool? Line828FwscIndicator { get; set; }
        public bool? Line829FwscIndicator { get; set; }
        public bool? Line830FwscIndicator { get; set; }
        public bool? Line831FwscIndicator { get; set; }
        public bool? Line832FwscIndicator { get; set; }
        public bool? Line833FwscIndicator { get; set; }
        public string Id { get; set; }
    }
}