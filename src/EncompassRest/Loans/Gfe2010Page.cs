using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Page
    {
        private Value<int?> _balloonPaymentDueInYears;
        public int? BalloonPaymentDueInYears { get { return _balloonPaymentDueInYears; } set { _balloonPaymentDueInYears = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBalloonPaymentDueInYears() => !_balloonPaymentDueInYears.Clean;
        private Value<string> _brokerCompensationFwbc;
        public string BrokerCompensationFwbc { get { return _brokerCompensationFwbc; } set { _brokerCompensationFwbc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFwbc() => !_brokerCompensationFwbc.Clean;
        private Value<string> _brokerCompensationFwsc;
        public string BrokerCompensationFwsc { get { return _brokerCompensationFwsc; } set { _brokerCompensationFwsc = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeBrokerCompensationFwsc() => !_brokerCompensationFwsc.Clean;
        private Value<decimal?> _curedGfeTotalTolerance;
        public decimal? CuredGfeTotalTolerance { get { return _curedGfeTotalTolerance; } set { _curedGfeTotalTolerance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeCuredGfeTotalTolerance() => !_curedGfeTotalTolerance.Clean;
        private Value<DateTime?> _firstArmChangeDate;
        public DateTime? FirstArmChangeDate { get { return _firstArmChangeDate; } set { _firstArmChangeDate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeFirstArmChangeDate() => !_firstArmChangeDate.Clean;
        private Value<List<Gfe2010FwbcFwsc>> _gfe2010FwbcFwscs;
        public List<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get { return _gfe2010FwbcFwscs; } set { _gfe2010FwbcFwscs = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010FwbcFwscs() => !_gfe2010FwbcFwscs.Clean;
        private Value<List<Gfe2010GfeCharge>> _gfe2010GfeCharges;
        public List<Gfe2010GfeCharge> Gfe2010GfeCharges { get { return _gfe2010GfeCharges; } set { _gfe2010GfeCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfe2010GfeCharges() => !_gfe2010GfeCharges.Clean;
        private Value<string> _gfeRecordingCharges;
        public string GfeRecordingCharges { get { return _gfeRecordingCharges; } set { _gfeRecordingCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeRecordingCharges() => !_gfeRecordingCharges.Clean;
        private Value<decimal?> _gfeTotalTolerance;
        public decimal? GfeTotalTolerance { get { return _gfeTotalTolerance; } set { _gfeTotalTolerance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeGfeTotalTolerance() => !_gfeTotalTolerance.Clean;
        private Value<bool?> _hasEscrowAccountIndicator;
        public bool? HasEscrowAccountIndicator { get { return _hasEscrowAccountIndicator; } set { _hasEscrowAccountIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowAccountIndicator() => !_hasEscrowAccountIndicator.Clean;
        private Value<bool?> _hasEscrowCityPropertyTaxesIndicator;
        public bool? HasEscrowCityPropertyTaxesIndicator { get { return _hasEscrowCityPropertyTaxesIndicator; } set { _hasEscrowCityPropertyTaxesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowCityPropertyTaxesIndicator() => !_hasEscrowCityPropertyTaxesIndicator.Clean;
        private Value<bool?> _hasEscrowFloodInsurancesIndicator;
        public bool? HasEscrowFloodInsurancesIndicator { get { return _hasEscrowFloodInsurancesIndicator; } set { _hasEscrowFloodInsurancesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowFloodInsurancesIndicator() => !_hasEscrowFloodInsurancesIndicator.Clean;
        private Value<bool?> _hasEscrowHomeownerInsurancesIndicator;
        public bool? HasEscrowHomeownerInsurancesIndicator { get { return _hasEscrowHomeownerInsurancesIndicator; } set { _hasEscrowHomeownerInsurancesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowHomeownerInsurancesIndicator() => !_hasEscrowHomeownerInsurancesIndicator.Clean;
        private Value<bool?> _hasEscrowPropertyTaxesIndicator;
        public bool? HasEscrowPropertyTaxesIndicator { get { return _hasEscrowPropertyTaxesIndicator; } set { _hasEscrowPropertyTaxesIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowPropertyTaxesIndicator() => !_hasEscrowPropertyTaxesIndicator.Clean;
        private Value<bool?> _hasEscrowUserDefinedIndicator1;
        public bool? HasEscrowUserDefinedIndicator1 { get { return _hasEscrowUserDefinedIndicator1; } set { _hasEscrowUserDefinedIndicator1 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator1() => !_hasEscrowUserDefinedIndicator1.Clean;
        private Value<bool?> _hasEscrowUserDefinedIndicator2;
        public bool? HasEscrowUserDefinedIndicator2 { get { return _hasEscrowUserDefinedIndicator2; } set { _hasEscrowUserDefinedIndicator2 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator2() => !_hasEscrowUserDefinedIndicator2.Clean;
        private Value<bool?> _hasEscrowUserDefinedIndicator3;
        public bool? HasEscrowUserDefinedIndicator3 { get { return _hasEscrowUserDefinedIndicator3; } set { _hasEscrowUserDefinedIndicator3 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator3() => !_hasEscrowUserDefinedIndicator3.Clean;
        private Value<bool?> _hasEscrowUserDefinedIndicator4;
        public bool? HasEscrowUserDefinedIndicator4 { get { return _hasEscrowUserDefinedIndicator4; } set { _hasEscrowUserDefinedIndicator4 = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHasEscrowUserDefinedIndicator4() => !_hasEscrowUserDefinedIndicator4.Clean;
        private Value<decimal?> _highestArmRate;
        public decimal? HighestArmRate { get { return _highestArmRate; } set { _highestArmRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHighestArmRate() => !_highestArmRate.Clean;
        private Value<decimal?> _hud1GovernmentRecordingCharge;
        public decimal? Hud1GovernmentRecordingCharge { get { return _hud1GovernmentRecordingCharge; } set { _hud1GovernmentRecordingCharge = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1GovernmentRecordingCharge() => !_hud1GovernmentRecordingCharge.Clean;
        private Value<decimal?> _hud1Pg1SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get { return _hud1Pg1SellerPaidClosingCostsAmount; } set { _hud1Pg1SellerPaidClosingCostsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg1SellerPaidClosingCostsAmount() => !_hud1Pg1SellerPaidClosingCostsAmount.Clean;
        private Value<decimal?> _hud1Pg1TotalSettlementCharges;
        public decimal? Hud1Pg1TotalSettlementCharges { get { return _hud1Pg1TotalSettlementCharges; } set { _hud1Pg1TotalSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg1TotalSettlementCharges() => !_hud1Pg1TotalSettlementCharges.Clean;
        private Value<decimal?> _hud1Pg2SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get { return _hud1Pg2SellerPaidClosingCostsAmount; } set { _hud1Pg2SellerPaidClosingCostsAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg2SellerPaidClosingCostsAmount() => !_hud1Pg2SellerPaidClosingCostsAmount.Clean;
        private Value<decimal?> _hud1Pg2TotalSettlementCharges;
        public decimal? Hud1Pg2TotalSettlementCharges { get { return _hud1Pg2TotalSettlementCharges; } set { _hud1Pg2TotalSettlementCharges = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHud1Pg2TotalSettlementCharges() => !_hud1Pg2TotalSettlementCharges.Clean;
        private Value<decimal?> _hudTotalTolerance;
        public decimal? HudTotalTolerance { get { return _hudTotalTolerance; } set { _hudTotalTolerance = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudTotalTolerance() => !_hudTotalTolerance.Clean;
        private Value<decimal?> _hudTotalToleranceIncreasePercent;
        public decimal? HudTotalToleranceIncreasePercent { get { return _hudTotalToleranceIncreasePercent; } set { _hudTotalToleranceIncreasePercent = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHudTotalToleranceIncreasePercent() => !_hudTotalToleranceIncreasePercent.Clean;
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !_id.Clean;
        private Value<decimal?> _line1101SellerPaidTotal;
        public decimal? Line1101SellerPaidTotal { get { return _line1101SellerPaidTotal; } set { _line1101SellerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1101SellerPaidTotal() => !_line1101SellerPaidTotal.Clean;
        private Value<decimal?> _line1201SellerPaidTotal;
        public decimal? Line1201SellerPaidTotal { get { return _line1201SellerPaidTotal; } set { _line1201SellerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1201SellerPaidTotal() => !_line1201SellerPaidTotal.Clean;
        private Value<decimal?> _line1301SellerPaidTotal;
        public decimal? Line1301SellerPaidTotal { get { return _line1301SellerPaidTotal; } set { _line1301SellerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine1301SellerPaidTotal() => !_line1301SellerPaidTotal.Clean;
        private Value<decimal?> _line801BorrowerPaidTotal;
        public decimal? Line801BorrowerPaidTotal { get { return _line801BorrowerPaidTotal; } set { _line801BorrowerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801BorrowerPaidTotal() => !_line801BorrowerPaidTotal.Clean;
        private Value<decimal?> _line801SellerPaidTotal;
        public decimal? Line801SellerPaidTotal { get { return _line801SellerPaidTotal; } set { _line801SellerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine801SellerPaidTotal() => !_line801SellerPaidTotal.Clean;
        private Value<decimal?> _line802BorrowerPaidTotal;
        public decimal? Line802BorrowerPaidTotal { get { return _line802BorrowerPaidTotal; } set { _line802BorrowerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine802BorrowerPaidTotal() => !_line802BorrowerPaidTotal.Clean;
        private Value<decimal?> _line803BorrowerPaidTotal;
        public decimal? Line803BorrowerPaidTotal { get { return _line803BorrowerPaidTotal; } set { _line803BorrowerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine803BorrowerPaidTotal() => !_line803BorrowerPaidTotal.Clean;
        private Value<decimal?> _line803SellerPaidTotal;
        public decimal? Line803SellerPaidTotal { get { return _line803SellerPaidTotal; } set { _line803SellerPaidTotal = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine803SellerPaidTotal() => !_line803SellerPaidTotal.Clean;
        private Value<bool?> _line818FwbcIndicator;
        public bool? Line818FwbcIndicator { get { return _line818FwbcIndicator; } set { _line818FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine818FwbcIndicator() => !_line818FwbcIndicator.Clean;
        private Value<bool?> _line818FwscIndicator;
        public bool? Line818FwscIndicator { get { return _line818FwscIndicator; } set { _line818FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine818FwscIndicator() => !_line818FwscIndicator.Clean;
        private Value<bool?> _line819FwbcIndicator;
        public bool? Line819FwbcIndicator { get { return _line819FwbcIndicator; } set { _line819FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine819FwbcIndicator() => !_line819FwbcIndicator.Clean;
        private Value<bool?> _line819FwscIndicator;
        public bool? Line819FwscIndicator { get { return _line819FwscIndicator; } set { _line819FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine819FwscIndicator() => !_line819FwscIndicator.Clean;
        private Value<bool?> _line820FwbcIndicator;
        public bool? Line820FwbcIndicator { get { return _line820FwbcIndicator; } set { _line820FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine820FwbcIndicator() => !_line820FwbcIndicator.Clean;
        private Value<bool?> _line820FwscIndicator;
        public bool? Line820FwscIndicator { get { return _line820FwscIndicator; } set { _line820FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine820FwscIndicator() => !_line820FwscIndicator.Clean;
        private Value<bool?> _line821FwbcIndicator;
        public bool? Line821FwbcIndicator { get { return _line821FwbcIndicator; } set { _line821FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine821FwbcIndicator() => !_line821FwbcIndicator.Clean;
        private Value<bool?> _line821FwscIndicator;
        public bool? Line821FwscIndicator { get { return _line821FwscIndicator; } set { _line821FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine821FwscIndicator() => !_line821FwscIndicator.Clean;
        private Value<bool?> _line822FwbcIndicator;
        public bool? Line822FwbcIndicator { get { return _line822FwbcIndicator; } set { _line822FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine822FwbcIndicator() => !_line822FwbcIndicator.Clean;
        private Value<bool?> _line822FwscIndicator;
        public bool? Line822FwscIndicator { get { return _line822FwscIndicator; } set { _line822FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine822FwscIndicator() => !_line822FwscIndicator.Clean;
        private Value<bool?> _line823FwbcIndicator;
        public bool? Line823FwbcIndicator { get { return _line823FwbcIndicator; } set { _line823FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine823FwbcIndicator() => !_line823FwbcIndicator.Clean;
        private Value<bool?> _line823FwscIndicator;
        public bool? Line823FwscIndicator { get { return _line823FwscIndicator; } set { _line823FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine823FwscIndicator() => !_line823FwscIndicator.Clean;
        private Value<bool?> _line824FwbcIndicator;
        public bool? Line824FwbcIndicator { get { return _line824FwbcIndicator; } set { _line824FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine824FwbcIndicator() => !_line824FwbcIndicator.Clean;
        private Value<bool?> _line824FwscIndicator;
        public bool? Line824FwscIndicator { get { return _line824FwscIndicator; } set { _line824FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine824FwscIndicator() => !_line824FwscIndicator.Clean;
        private Value<bool?> _line825FwbcIndicator;
        public bool? Line825FwbcIndicator { get { return _line825FwbcIndicator; } set { _line825FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine825FwbcIndicator() => !_line825FwbcIndicator.Clean;
        private Value<bool?> _line825FwscIndicator;
        public bool? Line825FwscIndicator { get { return _line825FwscIndicator; } set { _line825FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine825FwscIndicator() => !_line825FwscIndicator.Clean;
        private Value<bool?> _line826FwbcIndicator;
        public bool? Line826FwbcIndicator { get { return _line826FwbcIndicator; } set { _line826FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine826FwbcIndicator() => !_line826FwbcIndicator.Clean;
        private Value<bool?> _line826FwscIndicator;
        public bool? Line826FwscIndicator { get { return _line826FwscIndicator; } set { _line826FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine826FwscIndicator() => !_line826FwscIndicator.Clean;
        private Value<bool?> _line827FwbcIndicator;
        public bool? Line827FwbcIndicator { get { return _line827FwbcIndicator; } set { _line827FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine827FwbcIndicator() => !_line827FwbcIndicator.Clean;
        private Value<bool?> _line827FwscIndicator;
        public bool? Line827FwscIndicator { get { return _line827FwscIndicator; } set { _line827FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine827FwscIndicator() => !_line827FwscIndicator.Clean;
        private Value<bool?> _line828FwbcIndicator;
        public bool? Line828FwbcIndicator { get { return _line828FwbcIndicator; } set { _line828FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine828FwbcIndicator() => !_line828FwbcIndicator.Clean;
        private Value<bool?> _line828FwscIndicator;
        public bool? Line828FwscIndicator { get { return _line828FwscIndicator; } set { _line828FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine828FwscIndicator() => !_line828FwscIndicator.Clean;
        private Value<bool?> _line829FwbcIndicator;
        public bool? Line829FwbcIndicator { get { return _line829FwbcIndicator; } set { _line829FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine829FwbcIndicator() => !_line829FwbcIndicator.Clean;
        private Value<bool?> _line829FwscIndicator;
        public bool? Line829FwscIndicator { get { return _line829FwscIndicator; } set { _line829FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine829FwscIndicator() => !_line829FwscIndicator.Clean;
        private Value<bool?> _line830FwbcIndicator;
        public bool? Line830FwbcIndicator { get { return _line830FwbcIndicator; } set { _line830FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine830FwbcIndicator() => !_line830FwbcIndicator.Clean;
        private Value<bool?> _line830FwscIndicator;
        public bool? Line830FwscIndicator { get { return _line830FwscIndicator; } set { _line830FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine830FwscIndicator() => !_line830FwscIndicator.Clean;
        private Value<bool?> _line831FwbcIndicator;
        public bool? Line831FwbcIndicator { get { return _line831FwbcIndicator; } set { _line831FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine831FwbcIndicator() => !_line831FwbcIndicator.Clean;
        private Value<bool?> _line831FwscIndicator;
        public bool? Line831FwscIndicator { get { return _line831FwscIndicator; } set { _line831FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine831FwscIndicator() => !_line831FwscIndicator.Clean;
        private Value<bool?> _line832FwbcIndicator;
        public bool? Line832FwbcIndicator { get { return _line832FwbcIndicator; } set { _line832FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine832FwbcIndicator() => !_line832FwbcIndicator.Clean;
        private Value<bool?> _line832FwscIndicator;
        public bool? Line832FwscIndicator { get { return _line832FwscIndicator; } set { _line832FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine832FwscIndicator() => !_line832FwscIndicator.Clean;
        private Value<bool?> _line833FwbcIndicator;
        public bool? Line833FwbcIndicator { get { return _line833FwbcIndicator; } set { _line833FwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine833FwbcIndicator() => !_line833FwbcIndicator.Clean;
        private Value<bool?> _line833FwscIndicator;
        public bool? Line833FwscIndicator { get { return _line833FwscIndicator; } set { _line833FwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLine833FwscIndicator() => !_line833FwscIndicator.Clean;
        private Value<bool?> _lineLFwbcIndicator;
        public bool? LineLFwbcIndicator { get { return _lineLFwbcIndicator; } set { _lineLFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLFwbcIndicator() => !_lineLFwbcIndicator.Clean;
        private Value<bool?> _lineLFwscIndicator;
        public bool? LineLFwscIndicator { get { return _lineLFwscIndicator; } set { _lineLFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineLFwscIndicator() => !_lineLFwscIndicator.Clean;
        private Value<bool?> _lineMFwbcIndicator;
        public bool? LineMFwbcIndicator { get { return _lineMFwbcIndicator; } set { _lineMFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineMFwbcIndicator() => !_lineMFwbcIndicator.Clean;
        private Value<bool?> _lineMFwscIndicator;
        public bool? LineMFwscIndicator { get { return _lineMFwscIndicator; } set { _lineMFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineMFwscIndicator() => !_lineMFwscIndicator.Clean;
        private Value<bool?> _lineNFwbcIndicator;
        public bool? LineNFwbcIndicator { get { return _lineNFwbcIndicator; } set { _lineNFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNFwbcIndicator() => !_lineNFwbcIndicator.Clean;
        private Value<bool?> _lineNFwscIndicator;
        public bool? LineNFwscIndicator { get { return _lineNFwscIndicator; } set { _lineNFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineNFwscIndicator() => !_lineNFwscIndicator.Clean;
        private Value<bool?> _lineOFwbcIndicator;
        public bool? LineOFwbcIndicator { get { return _lineOFwbcIndicator; } set { _lineOFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineOFwbcIndicator() => !_lineOFwbcIndicator.Clean;
        private Value<bool?> _lineOFwscIndicator;
        public bool? LineOFwscIndicator { get { return _lineOFwscIndicator; } set { _lineOFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineOFwscIndicator() => !_lineOFwscIndicator.Clean;
        private Value<bool?> _linePFwbcIndicator;
        public bool? LinePFwbcIndicator { get { return _linePFwbcIndicator; } set { _linePFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinePFwbcIndicator() => !_linePFwbcIndicator.Clean;
        private Value<bool?> _linePFwscIndicator;
        public bool? LinePFwscIndicator { get { return _linePFwscIndicator; } set { _linePFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLinePFwscIndicator() => !_linePFwscIndicator.Clean;
        private Value<bool?> _lineQFwbcIndicator;
        public bool? LineQFwbcIndicator { get { return _lineQFwbcIndicator; } set { _lineQFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineQFwbcIndicator() => !_lineQFwbcIndicator.Clean;
        private Value<bool?> _lineQFwscIndicator;
        public bool? LineQFwscIndicator { get { return _lineQFwscIndicator; } set { _lineQFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineQFwscIndicator() => !_lineQFwscIndicator.Clean;
        private Value<bool?> _lineRFwbcIndicator;
        public bool? LineRFwbcIndicator { get { return _lineRFwbcIndicator; } set { _lineRFwbcIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineRFwbcIndicator() => !_lineRFwbcIndicator.Clean;
        private Value<bool?> _lineRFwscIndicator;
        public bool? LineRFwscIndicator { get { return _lineRFwscIndicator; } set { _lineRFwscIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLineRFwscIndicator() => !_lineRFwscIndicator.Clean;
        private Value<decimal?> _lowestArmRate;
        public decimal? LowestArmRate { get { return _lowestArmRate; } set { _lowestArmRate = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLowestArmRate() => !_lowestArmRate.Clean;
        private Value<bool?> _monthlyAmountIncludeInterestIndicator;
        public bool? MonthlyAmountIncludeInterestIndicator { get { return _monthlyAmountIncludeInterestIndicator; } set { _monthlyAmountIncludeInterestIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludeInterestIndicator() => !_monthlyAmountIncludeInterestIndicator.Clean;
        private Value<bool?> _monthlyAmountIncludeMiIndicator;
        public bool? MonthlyAmountIncludeMiIndicator { get { return _monthlyAmountIncludeMiIndicator; } set { _monthlyAmountIncludeMiIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludeMiIndicator() => !_monthlyAmountIncludeMiIndicator.Clean;
        private Value<bool?> _monthlyAmountIncludePrincipalIndicator;
        public bool? MonthlyAmountIncludePrincipalIndicator { get { return _monthlyAmountIncludePrincipalIndicator; } set { _monthlyAmountIncludePrincipalIndicator = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountIncludePrincipalIndicator() => !_monthlyAmountIncludePrincipalIndicator.Clean;
        private Value<decimal?> _monthlyAmountWithEscrow;
        public decimal? MonthlyAmountWithEscrow { get { return _monthlyAmountWithEscrow; } set { _monthlyAmountWithEscrow = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyAmountWithEscrow() => !_monthlyAmountWithEscrow.Clean;
        private Value<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get { return _monthlyEscrowPayment; } set { _monthlyEscrowPayment = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeMonthlyEscrowPayment() => !_monthlyEscrowPayment.Clean;
        private Value<decimal?> _prepaidInterest;
        public decimal? PrepaidInterest { get { return _prepaidInterest; } set { _prepaidInterest = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrepaidInterest() => !_prepaidInterest.Clean;
        private Value<decimal?> _totalToleranceIncreaseAmount;
        public decimal? TotalToleranceIncreaseAmount { get { return _totalToleranceIncreaseAmount; } set { _totalToleranceIncreaseAmount = value; } }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTotalToleranceIncreaseAmount() => !_totalToleranceIncreaseAmount.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _balloonPaymentDueInYears.Clean
                    && _brokerCompensationFwbc.Clean
                    && _brokerCompensationFwsc.Clean
                    && _curedGfeTotalTolerance.Clean
                    && _firstArmChangeDate.Clean
                    && _gfe2010FwbcFwscs.Clean
                    && _gfe2010GfeCharges.Clean
                    && _gfeRecordingCharges.Clean
                    && _gfeTotalTolerance.Clean
                    && _hasEscrowAccountIndicator.Clean
                    && _hasEscrowCityPropertyTaxesIndicator.Clean
                    && _hasEscrowFloodInsurancesIndicator.Clean
                    && _hasEscrowHomeownerInsurancesIndicator.Clean
                    && _hasEscrowPropertyTaxesIndicator.Clean
                    && _hasEscrowUserDefinedIndicator1.Clean
                    && _hasEscrowUserDefinedIndicator2.Clean
                    && _hasEscrowUserDefinedIndicator3.Clean
                    && _hasEscrowUserDefinedIndicator4.Clean
                    && _highestArmRate.Clean
                    && _hud1GovernmentRecordingCharge.Clean
                    && _hud1Pg1SellerPaidClosingCostsAmount.Clean
                    && _hud1Pg1TotalSettlementCharges.Clean
                    && _hud1Pg2SellerPaidClosingCostsAmount.Clean
                    && _hud1Pg2TotalSettlementCharges.Clean
                    && _hudTotalTolerance.Clean
                    && _hudTotalToleranceIncreasePercent.Clean
                    && _id.Clean
                    && _line1101SellerPaidTotal.Clean
                    && _line1201SellerPaidTotal.Clean
                    && _line1301SellerPaidTotal.Clean
                    && _line801BorrowerPaidTotal.Clean
                    && _line801SellerPaidTotal.Clean
                    && _line802BorrowerPaidTotal.Clean
                    && _line803BorrowerPaidTotal.Clean
                    && _line803SellerPaidTotal.Clean
                    && _line818FwbcIndicator.Clean
                    && _line818FwscIndicator.Clean
                    && _line819FwbcIndicator.Clean
                    && _line819FwscIndicator.Clean
                    && _line820FwbcIndicator.Clean
                    && _line820FwscIndicator.Clean
                    && _line821FwbcIndicator.Clean
                    && _line821FwscIndicator.Clean
                    && _line822FwbcIndicator.Clean
                    && _line822FwscIndicator.Clean
                    && _line823FwbcIndicator.Clean
                    && _line823FwscIndicator.Clean
                    && _line824FwbcIndicator.Clean
                    && _line824FwscIndicator.Clean
                    && _line825FwbcIndicator.Clean
                    && _line825FwscIndicator.Clean
                    && _line826FwbcIndicator.Clean
                    && _line826FwscIndicator.Clean
                    && _line827FwbcIndicator.Clean
                    && _line827FwscIndicator.Clean
                    && _line828FwbcIndicator.Clean
                    && _line828FwscIndicator.Clean
                    && _line829FwbcIndicator.Clean
                    && _line829FwscIndicator.Clean
                    && _line830FwbcIndicator.Clean
                    && _line830FwscIndicator.Clean
                    && _line831FwbcIndicator.Clean
                    && _line831FwscIndicator.Clean
                    && _line832FwbcIndicator.Clean
                    && _line832FwscIndicator.Clean
                    && _line833FwbcIndicator.Clean
                    && _line833FwscIndicator.Clean
                    && _lineLFwbcIndicator.Clean
                    && _lineLFwscIndicator.Clean
                    && _lineMFwbcIndicator.Clean
                    && _lineMFwscIndicator.Clean
                    && _lineNFwbcIndicator.Clean
                    && _lineNFwscIndicator.Clean
                    && _lineOFwbcIndicator.Clean
                    && _lineOFwscIndicator.Clean
                    && _linePFwbcIndicator.Clean
                    && _linePFwscIndicator.Clean
                    && _lineQFwbcIndicator.Clean
                    && _lineQFwscIndicator.Clean
                    && _lineRFwbcIndicator.Clean
                    && _lineRFwscIndicator.Clean
                    && _lowestArmRate.Clean
                    && _monthlyAmountIncludeInterestIndicator.Clean
                    && _monthlyAmountIncludeMiIndicator.Clean
                    && _monthlyAmountIncludePrincipalIndicator.Clean
                    && _monthlyAmountWithEscrow.Clean
                    && _monthlyEscrowPayment.Clean
                    && _prepaidInterest.Clean
                    && _totalToleranceIncreaseAmount.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _balloonPaymentDueInYears; v0.Clean = value; _balloonPaymentDueInYears = v0;
                var v1 = _brokerCompensationFwbc; v1.Clean = value; _brokerCompensationFwbc = v1;
                var v2 = _brokerCompensationFwsc; v2.Clean = value; _brokerCompensationFwsc = v2;
                var v3 = _curedGfeTotalTolerance; v3.Clean = value; _curedGfeTotalTolerance = v3;
                var v4 = _firstArmChangeDate; v4.Clean = value; _firstArmChangeDate = v4;
                var v5 = _gfe2010FwbcFwscs; v5.Clean = value; _gfe2010FwbcFwscs = v5;
                var v6 = _gfe2010GfeCharges; v6.Clean = value; _gfe2010GfeCharges = v6;
                var v7 = _gfeRecordingCharges; v7.Clean = value; _gfeRecordingCharges = v7;
                var v8 = _gfeTotalTolerance; v8.Clean = value; _gfeTotalTolerance = v8;
                var v9 = _hasEscrowAccountIndicator; v9.Clean = value; _hasEscrowAccountIndicator = v9;
                var v10 = _hasEscrowCityPropertyTaxesIndicator; v10.Clean = value; _hasEscrowCityPropertyTaxesIndicator = v10;
                var v11 = _hasEscrowFloodInsurancesIndicator; v11.Clean = value; _hasEscrowFloodInsurancesIndicator = v11;
                var v12 = _hasEscrowHomeownerInsurancesIndicator; v12.Clean = value; _hasEscrowHomeownerInsurancesIndicator = v12;
                var v13 = _hasEscrowPropertyTaxesIndicator; v13.Clean = value; _hasEscrowPropertyTaxesIndicator = v13;
                var v14 = _hasEscrowUserDefinedIndicator1; v14.Clean = value; _hasEscrowUserDefinedIndicator1 = v14;
                var v15 = _hasEscrowUserDefinedIndicator2; v15.Clean = value; _hasEscrowUserDefinedIndicator2 = v15;
                var v16 = _hasEscrowUserDefinedIndicator3; v16.Clean = value; _hasEscrowUserDefinedIndicator3 = v16;
                var v17 = _hasEscrowUserDefinedIndicator4; v17.Clean = value; _hasEscrowUserDefinedIndicator4 = v17;
                var v18 = _highestArmRate; v18.Clean = value; _highestArmRate = v18;
                var v19 = _hud1GovernmentRecordingCharge; v19.Clean = value; _hud1GovernmentRecordingCharge = v19;
                var v20 = _hud1Pg1SellerPaidClosingCostsAmount; v20.Clean = value; _hud1Pg1SellerPaidClosingCostsAmount = v20;
                var v21 = _hud1Pg1TotalSettlementCharges; v21.Clean = value; _hud1Pg1TotalSettlementCharges = v21;
                var v22 = _hud1Pg2SellerPaidClosingCostsAmount; v22.Clean = value; _hud1Pg2SellerPaidClosingCostsAmount = v22;
                var v23 = _hud1Pg2TotalSettlementCharges; v23.Clean = value; _hud1Pg2TotalSettlementCharges = v23;
                var v24 = _hudTotalTolerance; v24.Clean = value; _hudTotalTolerance = v24;
                var v25 = _hudTotalToleranceIncreasePercent; v25.Clean = value; _hudTotalToleranceIncreasePercent = v25;
                var v26 = _id; v26.Clean = value; _id = v26;
                var v27 = _line1101SellerPaidTotal; v27.Clean = value; _line1101SellerPaidTotal = v27;
                var v28 = _line1201SellerPaidTotal; v28.Clean = value; _line1201SellerPaidTotal = v28;
                var v29 = _line1301SellerPaidTotal; v29.Clean = value; _line1301SellerPaidTotal = v29;
                var v30 = _line801BorrowerPaidTotal; v30.Clean = value; _line801BorrowerPaidTotal = v30;
                var v31 = _line801SellerPaidTotal; v31.Clean = value; _line801SellerPaidTotal = v31;
                var v32 = _line802BorrowerPaidTotal; v32.Clean = value; _line802BorrowerPaidTotal = v32;
                var v33 = _line803BorrowerPaidTotal; v33.Clean = value; _line803BorrowerPaidTotal = v33;
                var v34 = _line803SellerPaidTotal; v34.Clean = value; _line803SellerPaidTotal = v34;
                var v35 = _line818FwbcIndicator; v35.Clean = value; _line818FwbcIndicator = v35;
                var v36 = _line818FwscIndicator; v36.Clean = value; _line818FwscIndicator = v36;
                var v37 = _line819FwbcIndicator; v37.Clean = value; _line819FwbcIndicator = v37;
                var v38 = _line819FwscIndicator; v38.Clean = value; _line819FwscIndicator = v38;
                var v39 = _line820FwbcIndicator; v39.Clean = value; _line820FwbcIndicator = v39;
                var v40 = _line820FwscIndicator; v40.Clean = value; _line820FwscIndicator = v40;
                var v41 = _line821FwbcIndicator; v41.Clean = value; _line821FwbcIndicator = v41;
                var v42 = _line821FwscIndicator; v42.Clean = value; _line821FwscIndicator = v42;
                var v43 = _line822FwbcIndicator; v43.Clean = value; _line822FwbcIndicator = v43;
                var v44 = _line822FwscIndicator; v44.Clean = value; _line822FwscIndicator = v44;
                var v45 = _line823FwbcIndicator; v45.Clean = value; _line823FwbcIndicator = v45;
                var v46 = _line823FwscIndicator; v46.Clean = value; _line823FwscIndicator = v46;
                var v47 = _line824FwbcIndicator; v47.Clean = value; _line824FwbcIndicator = v47;
                var v48 = _line824FwscIndicator; v48.Clean = value; _line824FwscIndicator = v48;
                var v49 = _line825FwbcIndicator; v49.Clean = value; _line825FwbcIndicator = v49;
                var v50 = _line825FwscIndicator; v50.Clean = value; _line825FwscIndicator = v50;
                var v51 = _line826FwbcIndicator; v51.Clean = value; _line826FwbcIndicator = v51;
                var v52 = _line826FwscIndicator; v52.Clean = value; _line826FwscIndicator = v52;
                var v53 = _line827FwbcIndicator; v53.Clean = value; _line827FwbcIndicator = v53;
                var v54 = _line827FwscIndicator; v54.Clean = value; _line827FwscIndicator = v54;
                var v55 = _line828FwbcIndicator; v55.Clean = value; _line828FwbcIndicator = v55;
                var v56 = _line828FwscIndicator; v56.Clean = value; _line828FwscIndicator = v56;
                var v57 = _line829FwbcIndicator; v57.Clean = value; _line829FwbcIndicator = v57;
                var v58 = _line829FwscIndicator; v58.Clean = value; _line829FwscIndicator = v58;
                var v59 = _line830FwbcIndicator; v59.Clean = value; _line830FwbcIndicator = v59;
                var v60 = _line830FwscIndicator; v60.Clean = value; _line830FwscIndicator = v60;
                var v61 = _line831FwbcIndicator; v61.Clean = value; _line831FwbcIndicator = v61;
                var v62 = _line831FwscIndicator; v62.Clean = value; _line831FwscIndicator = v62;
                var v63 = _line832FwbcIndicator; v63.Clean = value; _line832FwbcIndicator = v63;
                var v64 = _line832FwscIndicator; v64.Clean = value; _line832FwscIndicator = v64;
                var v65 = _line833FwbcIndicator; v65.Clean = value; _line833FwbcIndicator = v65;
                var v66 = _line833FwscIndicator; v66.Clean = value; _line833FwscIndicator = v66;
                var v67 = _lineLFwbcIndicator; v67.Clean = value; _lineLFwbcIndicator = v67;
                var v68 = _lineLFwscIndicator; v68.Clean = value; _lineLFwscIndicator = v68;
                var v69 = _lineMFwbcIndicator; v69.Clean = value; _lineMFwbcIndicator = v69;
                var v70 = _lineMFwscIndicator; v70.Clean = value; _lineMFwscIndicator = v70;
                var v71 = _lineNFwbcIndicator; v71.Clean = value; _lineNFwbcIndicator = v71;
                var v72 = _lineNFwscIndicator; v72.Clean = value; _lineNFwscIndicator = v72;
                var v73 = _lineOFwbcIndicator; v73.Clean = value; _lineOFwbcIndicator = v73;
                var v74 = _lineOFwscIndicator; v74.Clean = value; _lineOFwscIndicator = v74;
                var v75 = _linePFwbcIndicator; v75.Clean = value; _linePFwbcIndicator = v75;
                var v76 = _linePFwscIndicator; v76.Clean = value; _linePFwscIndicator = v76;
                var v77 = _lineQFwbcIndicator; v77.Clean = value; _lineQFwbcIndicator = v77;
                var v78 = _lineQFwscIndicator; v78.Clean = value; _lineQFwscIndicator = v78;
                var v79 = _lineRFwbcIndicator; v79.Clean = value; _lineRFwbcIndicator = v79;
                var v80 = _lineRFwscIndicator; v80.Clean = value; _lineRFwscIndicator = v80;
                var v81 = _lowestArmRate; v81.Clean = value; _lowestArmRate = v81;
                var v82 = _monthlyAmountIncludeInterestIndicator; v82.Clean = value; _monthlyAmountIncludeInterestIndicator = v82;
                var v83 = _monthlyAmountIncludeMiIndicator; v83.Clean = value; _monthlyAmountIncludeMiIndicator = v83;
                var v84 = _monthlyAmountIncludePrincipalIndicator; v84.Clean = value; _monthlyAmountIncludePrincipalIndicator = v84;
                var v85 = _monthlyAmountWithEscrow; v85.Clean = value; _monthlyAmountWithEscrow = v85;
                var v86 = _monthlyEscrowPayment; v86.Clean = value; _monthlyEscrowPayment = v86;
                var v87 = _prepaidInterest; v87.Clean = value; _prepaidInterest = v87;
                var v88 = _totalToleranceIncreaseAmount; v88.Clean = value; _totalToleranceIncreaseAmount = v88;
                _settingClean = 0;
            }
        }
    }
}