#pragma warning disable 1591
using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Page : ExtensibleObject
    {
        private DirtyValue<int?> _balloonPaymentDueInYears;
        public int? BalloonPaymentDueInYears { get => _balloonPaymentDueInYears; set => _balloonPaymentDueInYears = value; }
        private DirtyValue<string> _brokerCompensationFwbc;
        public string BrokerCompensationFwbc { get => _brokerCompensationFwbc; set => _brokerCompensationFwbc = value; }
        private DirtyValue<string> _brokerCompensationFwsc;
        public string BrokerCompensationFwsc { get => _brokerCompensationFwsc; set => _brokerCompensationFwsc = value; }
        private DirtyValue<decimal?> _curedGfeTotalTolerance;
        public decimal? CuredGfeTotalTolerance { get => _curedGfeTotalTolerance; set => _curedGfeTotalTolerance = value; }
        private DirtyValue<DateTime?> _firstArmChangeDate;
        public DateTime? FirstArmChangeDate { get => _firstArmChangeDate; set => _firstArmChangeDate = value; }
        private DirtyList<Gfe2010FwbcFwsc> _gfe2010FwbcFwscs;
        public IList<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get => _gfe2010FwbcFwscs ?? (_gfe2010FwbcFwscs = new DirtyList<Gfe2010FwbcFwsc>()); set => _gfe2010FwbcFwscs = new DirtyList<Gfe2010FwbcFwsc>(value); }
        private DirtyList<Gfe2010GfeCharge> _gfe2010GfeCharges;
        public IList<Gfe2010GfeCharge> Gfe2010GfeCharges { get => _gfe2010GfeCharges ?? (_gfe2010GfeCharges = new DirtyList<Gfe2010GfeCharge>()); set => _gfe2010GfeCharges = new DirtyList<Gfe2010GfeCharge>(value); }
        private DirtyValue<string> _gfeRecordingCharges;
        public string GfeRecordingCharges { get => _gfeRecordingCharges; set => _gfeRecordingCharges = value; }
        private DirtyValue<decimal?> _gfeTotalTolerance;
        public decimal? GfeTotalTolerance { get => _gfeTotalTolerance; set => _gfeTotalTolerance = value; }
        private DirtyValue<bool?> _hasEscrowAccountIndicator;
        public bool? HasEscrowAccountIndicator { get => _hasEscrowAccountIndicator; set => _hasEscrowAccountIndicator = value; }
        private DirtyValue<bool?> _hasEscrowCityPropertyTaxesIndicator;
        public bool? HasEscrowCityPropertyTaxesIndicator { get => _hasEscrowCityPropertyTaxesIndicator; set => _hasEscrowCityPropertyTaxesIndicator = value; }
        private DirtyValue<bool?> _hasEscrowFloodInsurancesIndicator;
        public bool? HasEscrowFloodInsurancesIndicator { get => _hasEscrowFloodInsurancesIndicator; set => _hasEscrowFloodInsurancesIndicator = value; }
        private DirtyValue<bool?> _hasEscrowHomeownerInsurancesIndicator;
        public bool? HasEscrowHomeownerInsurancesIndicator { get => _hasEscrowHomeownerInsurancesIndicator; set => _hasEscrowHomeownerInsurancesIndicator = value; }
        private DirtyValue<bool?> _hasEscrowPropertyTaxesIndicator;
        public bool? HasEscrowPropertyTaxesIndicator { get => _hasEscrowPropertyTaxesIndicator; set => _hasEscrowPropertyTaxesIndicator = value; }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator1;
        public bool? HasEscrowUserDefinedIndicator1 { get => _hasEscrowUserDefinedIndicator1; set => _hasEscrowUserDefinedIndicator1 = value; }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator2;
        public bool? HasEscrowUserDefinedIndicator2 { get => _hasEscrowUserDefinedIndicator2; set => _hasEscrowUserDefinedIndicator2 = value; }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator3;
        public bool? HasEscrowUserDefinedIndicator3 { get => _hasEscrowUserDefinedIndicator3; set => _hasEscrowUserDefinedIndicator3 = value; }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator4;
        public bool? HasEscrowUserDefinedIndicator4 { get => _hasEscrowUserDefinedIndicator4; set => _hasEscrowUserDefinedIndicator4 = value; }
        private DirtyValue<decimal?> _highestArmRate;
        public decimal? HighestArmRate { get => _highestArmRate; set => _highestArmRate = value; }
        private DirtyValue<decimal?> _hud1GovernmentRecordingCharge;
        public decimal? Hud1GovernmentRecordingCharge { get => _hud1GovernmentRecordingCharge; set => _hud1GovernmentRecordingCharge = value; }
        private DirtyValue<decimal?> _hud1Pg1SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get => _hud1Pg1SellerPaidClosingCostsAmount; set => _hud1Pg1SellerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _hud1Pg1TotalSettlementCharges;
        public decimal? Hud1Pg1TotalSettlementCharges { get => _hud1Pg1TotalSettlementCharges; set => _hud1Pg1TotalSettlementCharges = value; }
        private DirtyValue<decimal?> _hud1Pg2SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get => _hud1Pg2SellerPaidClosingCostsAmount; set => _hud1Pg2SellerPaidClosingCostsAmount = value; }
        private DirtyValue<decimal?> _hud1Pg2TotalSettlementCharges;
        public decimal? Hud1Pg2TotalSettlementCharges { get => _hud1Pg2TotalSettlementCharges; set => _hud1Pg2TotalSettlementCharges = value; }
        private DirtyValue<decimal?> _hudTotalTolerance;
        public decimal? HudTotalTolerance { get => _hudTotalTolerance; set => _hudTotalTolerance = value; }
        private DirtyValue<decimal?> _hudTotalToleranceIncreasePercent;
        public decimal? HudTotalToleranceIncreasePercent { get => _hudTotalToleranceIncreasePercent; set => _hudTotalToleranceIncreasePercent = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _line1101SellerPaidTotal;
        public decimal? Line1101SellerPaidTotal { get => _line1101SellerPaidTotal; set => _line1101SellerPaidTotal = value; }
        private DirtyValue<decimal?> _line1201SellerPaidTotal;
        public decimal? Line1201SellerPaidTotal { get => _line1201SellerPaidTotal; set => _line1201SellerPaidTotal = value; }
        private DirtyValue<decimal?> _line1301SellerPaidTotal;
        public decimal? Line1301SellerPaidTotal { get => _line1301SellerPaidTotal; set => _line1301SellerPaidTotal = value; }
        private DirtyValue<decimal?> _line801BorrowerPaidTotal;
        public decimal? Line801BorrowerPaidTotal { get => _line801BorrowerPaidTotal; set => _line801BorrowerPaidTotal = value; }
        private DirtyValue<decimal?> _line801SellerPaidTotal;
        public decimal? Line801SellerPaidTotal { get => _line801SellerPaidTotal; set => _line801SellerPaidTotal = value; }
        private DirtyValue<decimal?> _line802BorrowerPaidTotal;
        public decimal? Line802BorrowerPaidTotal { get => _line802BorrowerPaidTotal; set => _line802BorrowerPaidTotal = value; }
        private DirtyValue<decimal?> _line803BorrowerPaidTotal;
        public decimal? Line803BorrowerPaidTotal { get => _line803BorrowerPaidTotal; set => _line803BorrowerPaidTotal = value; }
        private DirtyValue<decimal?> _line803SellerPaidTotal;
        public decimal? Line803SellerPaidTotal { get => _line803SellerPaidTotal; set => _line803SellerPaidTotal = value; }
        private DirtyValue<bool?> _line818FwbcIndicator;
        public bool? Line818FwbcIndicator { get => _line818FwbcIndicator; set => _line818FwbcIndicator = value; }
        private DirtyValue<bool?> _line818FwscIndicator;
        public bool? Line818FwscIndicator { get => _line818FwscIndicator; set => _line818FwscIndicator = value; }
        private DirtyValue<bool?> _line819FwbcIndicator;
        public bool? Line819FwbcIndicator { get => _line819FwbcIndicator; set => _line819FwbcIndicator = value; }
        private DirtyValue<bool?> _line819FwscIndicator;
        public bool? Line819FwscIndicator { get => _line819FwscIndicator; set => _line819FwscIndicator = value; }
        private DirtyValue<bool?> _line820FwbcIndicator;
        public bool? Line820FwbcIndicator { get => _line820FwbcIndicator; set => _line820FwbcIndicator = value; }
        private DirtyValue<bool?> _line820FwscIndicator;
        public bool? Line820FwscIndicator { get => _line820FwscIndicator; set => _line820FwscIndicator = value; }
        private DirtyValue<bool?> _line821FwbcIndicator;
        public bool? Line821FwbcIndicator { get => _line821FwbcIndicator; set => _line821FwbcIndicator = value; }
        private DirtyValue<bool?> _line821FwscIndicator;
        public bool? Line821FwscIndicator { get => _line821FwscIndicator; set => _line821FwscIndicator = value; }
        private DirtyValue<bool?> _line822FwbcIndicator;
        public bool? Line822FwbcIndicator { get => _line822FwbcIndicator; set => _line822FwbcIndicator = value; }
        private DirtyValue<bool?> _line822FwscIndicator;
        public bool? Line822FwscIndicator { get => _line822FwscIndicator; set => _line822FwscIndicator = value; }
        private DirtyValue<bool?> _line823FwbcIndicator;
        public bool? Line823FwbcIndicator { get => _line823FwbcIndicator; set => _line823FwbcIndicator = value; }
        private DirtyValue<bool?> _line823FwscIndicator;
        public bool? Line823FwscIndicator { get => _line823FwscIndicator; set => _line823FwscIndicator = value; }
        private DirtyValue<bool?> _line824FwbcIndicator;
        public bool? Line824FwbcIndicator { get => _line824FwbcIndicator; set => _line824FwbcIndicator = value; }
        private DirtyValue<bool?> _line824FwscIndicator;
        public bool? Line824FwscIndicator { get => _line824FwscIndicator; set => _line824FwscIndicator = value; }
        private DirtyValue<bool?> _line825FwbcIndicator;
        public bool? Line825FwbcIndicator { get => _line825FwbcIndicator; set => _line825FwbcIndicator = value; }
        private DirtyValue<bool?> _line825FwscIndicator;
        public bool? Line825FwscIndicator { get => _line825FwscIndicator; set => _line825FwscIndicator = value; }
        private DirtyValue<bool?> _line826FwbcIndicator;
        public bool? Line826FwbcIndicator { get => _line826FwbcIndicator; set => _line826FwbcIndicator = value; }
        private DirtyValue<bool?> _line826FwscIndicator;
        public bool? Line826FwscIndicator { get => _line826FwscIndicator; set => _line826FwscIndicator = value; }
        private DirtyValue<bool?> _line827FwbcIndicator;
        public bool? Line827FwbcIndicator { get => _line827FwbcIndicator; set => _line827FwbcIndicator = value; }
        private DirtyValue<bool?> _line827FwscIndicator;
        public bool? Line827FwscIndicator { get => _line827FwscIndicator; set => _line827FwscIndicator = value; }
        private DirtyValue<bool?> _line828FwbcIndicator;
        public bool? Line828FwbcIndicator { get => _line828FwbcIndicator; set => _line828FwbcIndicator = value; }
        private DirtyValue<bool?> _line828FwscIndicator;
        public bool? Line828FwscIndicator { get => _line828FwscIndicator; set => _line828FwscIndicator = value; }
        private DirtyValue<bool?> _line829FwbcIndicator;
        public bool? Line829FwbcIndicator { get => _line829FwbcIndicator; set => _line829FwbcIndicator = value; }
        private DirtyValue<bool?> _line829FwscIndicator;
        public bool? Line829FwscIndicator { get => _line829FwscIndicator; set => _line829FwscIndicator = value; }
        private DirtyValue<bool?> _line830FwbcIndicator;
        public bool? Line830FwbcIndicator { get => _line830FwbcIndicator; set => _line830FwbcIndicator = value; }
        private DirtyValue<bool?> _line830FwscIndicator;
        public bool? Line830FwscIndicator { get => _line830FwscIndicator; set => _line830FwscIndicator = value; }
        private DirtyValue<bool?> _line831FwbcIndicator;
        public bool? Line831FwbcIndicator { get => _line831FwbcIndicator; set => _line831FwbcIndicator = value; }
        private DirtyValue<bool?> _line831FwscIndicator;
        public bool? Line831FwscIndicator { get => _line831FwscIndicator; set => _line831FwscIndicator = value; }
        private DirtyValue<bool?> _line832FwbcIndicator;
        public bool? Line832FwbcIndicator { get => _line832FwbcIndicator; set => _line832FwbcIndicator = value; }
        private DirtyValue<bool?> _line832FwscIndicator;
        public bool? Line832FwscIndicator { get => _line832FwscIndicator; set => _line832FwscIndicator = value; }
        private DirtyValue<bool?> _line833FwbcIndicator;
        public bool? Line833FwbcIndicator { get => _line833FwbcIndicator; set => _line833FwbcIndicator = value; }
        private DirtyValue<bool?> _line833FwscIndicator;
        public bool? Line833FwscIndicator { get => _line833FwscIndicator; set => _line833FwscIndicator = value; }
        private DirtyValue<bool?> _lineLFwbcIndicator;
        public bool? LineLFwbcIndicator { get => _lineLFwbcIndicator; set => _lineLFwbcIndicator = value; }
        private DirtyValue<bool?> _lineLFwscIndicator;
        public bool? LineLFwscIndicator { get => _lineLFwscIndicator; set => _lineLFwscIndicator = value; }
        private DirtyValue<bool?> _lineMFwbcIndicator;
        public bool? LineMFwbcIndicator { get => _lineMFwbcIndicator; set => _lineMFwbcIndicator = value; }
        private DirtyValue<bool?> _lineMFwscIndicator;
        public bool? LineMFwscIndicator { get => _lineMFwscIndicator; set => _lineMFwscIndicator = value; }
        private DirtyValue<bool?> _lineNFwbcIndicator;
        public bool? LineNFwbcIndicator { get => _lineNFwbcIndicator; set => _lineNFwbcIndicator = value; }
        private DirtyValue<bool?> _lineNFwscIndicator;
        public bool? LineNFwscIndicator { get => _lineNFwscIndicator; set => _lineNFwscIndicator = value; }
        private DirtyValue<bool?> _lineOFwbcIndicator;
        public bool? LineOFwbcIndicator { get => _lineOFwbcIndicator; set => _lineOFwbcIndicator = value; }
        private DirtyValue<bool?> _lineOFwscIndicator;
        public bool? LineOFwscIndicator { get => _lineOFwscIndicator; set => _lineOFwscIndicator = value; }
        private DirtyValue<bool?> _linePFwbcIndicator;
        public bool? LinePFwbcIndicator { get => _linePFwbcIndicator; set => _linePFwbcIndicator = value; }
        private DirtyValue<bool?> _linePFwscIndicator;
        public bool? LinePFwscIndicator { get => _linePFwscIndicator; set => _linePFwscIndicator = value; }
        private DirtyValue<bool?> _lineQFwbcIndicator;
        public bool? LineQFwbcIndicator { get => _lineQFwbcIndicator; set => _lineQFwbcIndicator = value; }
        private DirtyValue<bool?> _lineQFwscIndicator;
        public bool? LineQFwscIndicator { get => _lineQFwscIndicator; set => _lineQFwscIndicator = value; }
        private DirtyValue<bool?> _lineRFwbcIndicator;
        public bool? LineRFwbcIndicator { get => _lineRFwbcIndicator; set => _lineRFwbcIndicator = value; }
        private DirtyValue<bool?> _lineRFwscIndicator;
        public bool? LineRFwscIndicator { get => _lineRFwscIndicator; set => _lineRFwscIndicator = value; }
        private DirtyValue<decimal?> _lowestArmRate;
        public decimal? LowestArmRate { get => _lowestArmRate; set => _lowestArmRate = value; }
        private DirtyValue<bool?> _monthlyAmountIncludeInterestIndicator;
        public bool? MonthlyAmountIncludeInterestIndicator { get => _monthlyAmountIncludeInterestIndicator; set => _monthlyAmountIncludeInterestIndicator = value; }
        private DirtyValue<bool?> _monthlyAmountIncludeMiIndicator;
        public bool? MonthlyAmountIncludeMiIndicator { get => _monthlyAmountIncludeMiIndicator; set => _monthlyAmountIncludeMiIndicator = value; }
        private DirtyValue<bool?> _monthlyAmountIncludePrincipalIndicator;
        public bool? MonthlyAmountIncludePrincipalIndicator { get => _monthlyAmountIncludePrincipalIndicator; set => _monthlyAmountIncludePrincipalIndicator = value; }
        private DirtyValue<decimal?> _monthlyAmountWithEscrow;
        public decimal? MonthlyAmountWithEscrow { get => _monthlyAmountWithEscrow; set => _monthlyAmountWithEscrow = value; }
        private DirtyValue<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => _monthlyEscrowPayment = value; }
        private DirtyValue<decimal?> _prepaidInterest;
        public decimal? PrepaidInterest { get => _prepaidInterest; set => _prepaidInterest = value; }
        private DirtyValue<decimal?> _totalToleranceIncreaseAmount;
        public decimal? TotalToleranceIncreaseAmount { get => _totalToleranceIncreaseAmount; set => _totalToleranceIncreaseAmount = value; }
        internal override bool DirtyInternal
        {
            get
            {
                return _balloonPaymentDueInYears.Dirty
                    || _brokerCompensationFwbc.Dirty
                    || _brokerCompensationFwsc.Dirty
                    || _curedGfeTotalTolerance.Dirty
                    || _firstArmChangeDate.Dirty
                    || _gfeRecordingCharges.Dirty
                    || _gfeTotalTolerance.Dirty
                    || _hasEscrowAccountIndicator.Dirty
                    || _hasEscrowCityPropertyTaxesIndicator.Dirty
                    || _hasEscrowFloodInsurancesIndicator.Dirty
                    || _hasEscrowHomeownerInsurancesIndicator.Dirty
                    || _hasEscrowPropertyTaxesIndicator.Dirty
                    || _hasEscrowUserDefinedIndicator1.Dirty
                    || _hasEscrowUserDefinedIndicator2.Dirty
                    || _hasEscrowUserDefinedIndicator3.Dirty
                    || _hasEscrowUserDefinedIndicator4.Dirty
                    || _highestArmRate.Dirty
                    || _hud1GovernmentRecordingCharge.Dirty
                    || _hud1Pg1SellerPaidClosingCostsAmount.Dirty
                    || _hud1Pg1TotalSettlementCharges.Dirty
                    || _hud1Pg2SellerPaidClosingCostsAmount.Dirty
                    || _hud1Pg2TotalSettlementCharges.Dirty
                    || _hudTotalTolerance.Dirty
                    || _hudTotalToleranceIncreasePercent.Dirty
                    || _id.Dirty
                    || _line1101SellerPaidTotal.Dirty
                    || _line1201SellerPaidTotal.Dirty
                    || _line1301SellerPaidTotal.Dirty
                    || _line801BorrowerPaidTotal.Dirty
                    || _line801SellerPaidTotal.Dirty
                    || _line802BorrowerPaidTotal.Dirty
                    || _line803BorrowerPaidTotal.Dirty
                    || _line803SellerPaidTotal.Dirty
                    || _line818FwbcIndicator.Dirty
                    || _line818FwscIndicator.Dirty
                    || _line819FwbcIndicator.Dirty
                    || _line819FwscIndicator.Dirty
                    || _line820FwbcIndicator.Dirty
                    || _line820FwscIndicator.Dirty
                    || _line821FwbcIndicator.Dirty
                    || _line821FwscIndicator.Dirty
                    || _line822FwbcIndicator.Dirty
                    || _line822FwscIndicator.Dirty
                    || _line823FwbcIndicator.Dirty
                    || _line823FwscIndicator.Dirty
                    || _line824FwbcIndicator.Dirty
                    || _line824FwscIndicator.Dirty
                    || _line825FwbcIndicator.Dirty
                    || _line825FwscIndicator.Dirty
                    || _line826FwbcIndicator.Dirty
                    || _line826FwscIndicator.Dirty
                    || _line827FwbcIndicator.Dirty
                    || _line827FwscIndicator.Dirty
                    || _line828FwbcIndicator.Dirty
                    || _line828FwscIndicator.Dirty
                    || _line829FwbcIndicator.Dirty
                    || _line829FwscIndicator.Dirty
                    || _line830FwbcIndicator.Dirty
                    || _line830FwscIndicator.Dirty
                    || _line831FwbcIndicator.Dirty
                    || _line831FwscIndicator.Dirty
                    || _line832FwbcIndicator.Dirty
                    || _line832FwscIndicator.Dirty
                    || _line833FwbcIndicator.Dirty
                    || _line833FwscIndicator.Dirty
                    || _lineLFwbcIndicator.Dirty
                    || _lineLFwscIndicator.Dirty
                    || _lineMFwbcIndicator.Dirty
                    || _lineMFwscIndicator.Dirty
                    || _lineNFwbcIndicator.Dirty
                    || _lineNFwscIndicator.Dirty
                    || _lineOFwbcIndicator.Dirty
                    || _lineOFwscIndicator.Dirty
                    || _linePFwbcIndicator.Dirty
                    || _linePFwscIndicator.Dirty
                    || _lineQFwbcIndicator.Dirty
                    || _lineQFwscIndicator.Dirty
                    || _lineRFwbcIndicator.Dirty
                    || _lineRFwscIndicator.Dirty
                    || _lowestArmRate.Dirty
                    || _monthlyAmountIncludeInterestIndicator.Dirty
                    || _monthlyAmountIncludeMiIndicator.Dirty
                    || _monthlyAmountIncludePrincipalIndicator.Dirty
                    || _monthlyAmountWithEscrow.Dirty
                    || _monthlyEscrowPayment.Dirty
                    || _prepaidInterest.Dirty
                    || _totalToleranceIncreaseAmount.Dirty
                    || _gfe2010FwbcFwscs?.Dirty == true
                    || _gfe2010GfeCharges?.Dirty == true;
            }
            set
            {
                _balloonPaymentDueInYears.Dirty = value;
                _brokerCompensationFwbc.Dirty = value;
                _brokerCompensationFwsc.Dirty = value;
                _curedGfeTotalTolerance.Dirty = value;
                _firstArmChangeDate.Dirty = value;
                _gfeRecordingCharges.Dirty = value;
                _gfeTotalTolerance.Dirty = value;
                _hasEscrowAccountIndicator.Dirty = value;
                _hasEscrowCityPropertyTaxesIndicator.Dirty = value;
                _hasEscrowFloodInsurancesIndicator.Dirty = value;
                _hasEscrowHomeownerInsurancesIndicator.Dirty = value;
                _hasEscrowPropertyTaxesIndicator.Dirty = value;
                _hasEscrowUserDefinedIndicator1.Dirty = value;
                _hasEscrowUserDefinedIndicator2.Dirty = value;
                _hasEscrowUserDefinedIndicator3.Dirty = value;
                _hasEscrowUserDefinedIndicator4.Dirty = value;
                _highestArmRate.Dirty = value;
                _hud1GovernmentRecordingCharge.Dirty = value;
                _hud1Pg1SellerPaidClosingCostsAmount.Dirty = value;
                _hud1Pg1TotalSettlementCharges.Dirty = value;
                _hud1Pg2SellerPaidClosingCostsAmount.Dirty = value;
                _hud1Pg2TotalSettlementCharges.Dirty = value;
                _hudTotalTolerance.Dirty = value;
                _hudTotalToleranceIncreasePercent.Dirty = value;
                _id.Dirty = value;
                _line1101SellerPaidTotal.Dirty = value;
                _line1201SellerPaidTotal.Dirty = value;
                _line1301SellerPaidTotal.Dirty = value;
                _line801BorrowerPaidTotal.Dirty = value;
                _line801SellerPaidTotal.Dirty = value;
                _line802BorrowerPaidTotal.Dirty = value;
                _line803BorrowerPaidTotal.Dirty = value;
                _line803SellerPaidTotal.Dirty = value;
                _line818FwbcIndicator.Dirty = value;
                _line818FwscIndicator.Dirty = value;
                _line819FwbcIndicator.Dirty = value;
                _line819FwscIndicator.Dirty = value;
                _line820FwbcIndicator.Dirty = value;
                _line820FwscIndicator.Dirty = value;
                _line821FwbcIndicator.Dirty = value;
                _line821FwscIndicator.Dirty = value;
                _line822FwbcIndicator.Dirty = value;
                _line822FwscIndicator.Dirty = value;
                _line823FwbcIndicator.Dirty = value;
                _line823FwscIndicator.Dirty = value;
                _line824FwbcIndicator.Dirty = value;
                _line824FwscIndicator.Dirty = value;
                _line825FwbcIndicator.Dirty = value;
                _line825FwscIndicator.Dirty = value;
                _line826FwbcIndicator.Dirty = value;
                _line826FwscIndicator.Dirty = value;
                _line827FwbcIndicator.Dirty = value;
                _line827FwscIndicator.Dirty = value;
                _line828FwbcIndicator.Dirty = value;
                _line828FwscIndicator.Dirty = value;
                _line829FwbcIndicator.Dirty = value;
                _line829FwscIndicator.Dirty = value;
                _line830FwbcIndicator.Dirty = value;
                _line830FwscIndicator.Dirty = value;
                _line831FwbcIndicator.Dirty = value;
                _line831FwscIndicator.Dirty = value;
                _line832FwbcIndicator.Dirty = value;
                _line832FwscIndicator.Dirty = value;
                _line833FwbcIndicator.Dirty = value;
                _line833FwscIndicator.Dirty = value;
                _lineLFwbcIndicator.Dirty = value;
                _lineLFwscIndicator.Dirty = value;
                _lineMFwbcIndicator.Dirty = value;
                _lineMFwscIndicator.Dirty = value;
                _lineNFwbcIndicator.Dirty = value;
                _lineNFwscIndicator.Dirty = value;
                _lineOFwbcIndicator.Dirty = value;
                _lineOFwscIndicator.Dirty = value;
                _linePFwbcIndicator.Dirty = value;
                _linePFwscIndicator.Dirty = value;
                _lineQFwbcIndicator.Dirty = value;
                _lineQFwscIndicator.Dirty = value;
                _lineRFwbcIndicator.Dirty = value;
                _lineRFwscIndicator.Dirty = value;
                _lowestArmRate.Dirty = value;
                _monthlyAmountIncludeInterestIndicator.Dirty = value;
                _monthlyAmountIncludeMiIndicator.Dirty = value;
                _monthlyAmountIncludePrincipalIndicator.Dirty = value;
                _monthlyAmountWithEscrow.Dirty = value;
                _monthlyEscrowPayment.Dirty = value;
                _prepaidInterest.Dirty = value;
                _totalToleranceIncreaseAmount.Dirty = value;
                if (_gfe2010FwbcFwscs != null) _gfe2010FwbcFwscs.Dirty = value;
                if (_gfe2010GfeCharges != null) _gfe2010GfeCharges.Dirty = value;
            }
        }
    }
}