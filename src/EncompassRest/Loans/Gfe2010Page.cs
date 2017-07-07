using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Page : IClean
    {
        private Value<int?> _balloonPaymentDueInYears;
        public int? BalloonPaymentDueInYears { get { return _balloonPaymentDueInYears; } set { _balloonPaymentDueInYears = value; } }
        private Value<string> _brokerCompensationFwbc;
        public string BrokerCompensationFwbc { get { return _brokerCompensationFwbc; } set { _brokerCompensationFwbc = value; } }
        private Value<string> _brokerCompensationFwsc;
        public string BrokerCompensationFwsc { get { return _brokerCompensationFwsc; } set { _brokerCompensationFwsc = value; } }
        private Value<decimal?> _curedGfeTotalTolerance;
        public decimal? CuredGfeTotalTolerance { get { return _curedGfeTotalTolerance; } set { _curedGfeTotalTolerance = value; } }
        private Value<DateTime?> _firstArmChangeDate;
        public DateTime? FirstArmChangeDate { get { return _firstArmChangeDate; } set { _firstArmChangeDate = value; } }
        private Value<List<Gfe2010FwbcFwsc>> _gfe2010FwbcFwscs;
        public List<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get { return _gfe2010FwbcFwscs; } set { _gfe2010FwbcFwscs = value; } }
        private Value<List<Gfe2010GfeCharge>> _gfe2010GfeCharges;
        public List<Gfe2010GfeCharge> Gfe2010GfeCharges { get { return _gfe2010GfeCharges; } set { _gfe2010GfeCharges = value; } }
        private Value<string> _gfeRecordingCharges;
        public string GfeRecordingCharges { get { return _gfeRecordingCharges; } set { _gfeRecordingCharges = value; } }
        private Value<decimal?> _gfeTotalTolerance;
        public decimal? GfeTotalTolerance { get { return _gfeTotalTolerance; } set { _gfeTotalTolerance = value; } }
        private Value<bool?> _hasEscrowAccountIndicator;
        public bool? HasEscrowAccountIndicator { get { return _hasEscrowAccountIndicator; } set { _hasEscrowAccountIndicator = value; } }
        private Value<bool?> _hasEscrowCityPropertyTaxesIndicator;
        public bool? HasEscrowCityPropertyTaxesIndicator { get { return _hasEscrowCityPropertyTaxesIndicator; } set { _hasEscrowCityPropertyTaxesIndicator = value; } }
        private Value<bool?> _hasEscrowFloodInsurancesIndicator;
        public bool? HasEscrowFloodInsurancesIndicator { get { return _hasEscrowFloodInsurancesIndicator; } set { _hasEscrowFloodInsurancesIndicator = value; } }
        private Value<bool?> _hasEscrowHomeownerInsurancesIndicator;
        public bool? HasEscrowHomeownerInsurancesIndicator { get { return _hasEscrowHomeownerInsurancesIndicator; } set { _hasEscrowHomeownerInsurancesIndicator = value; } }
        private Value<bool?> _hasEscrowPropertyTaxesIndicator;
        public bool? HasEscrowPropertyTaxesIndicator { get { return _hasEscrowPropertyTaxesIndicator; } set { _hasEscrowPropertyTaxesIndicator = value; } }
        private Value<bool?> _hasEscrowUserDefinedIndicator1;
        public bool? HasEscrowUserDefinedIndicator1 { get { return _hasEscrowUserDefinedIndicator1; } set { _hasEscrowUserDefinedIndicator1 = value; } }
        private Value<bool?> _hasEscrowUserDefinedIndicator2;
        public bool? HasEscrowUserDefinedIndicator2 { get { return _hasEscrowUserDefinedIndicator2; } set { _hasEscrowUserDefinedIndicator2 = value; } }
        private Value<bool?> _hasEscrowUserDefinedIndicator3;
        public bool? HasEscrowUserDefinedIndicator3 { get { return _hasEscrowUserDefinedIndicator3; } set { _hasEscrowUserDefinedIndicator3 = value; } }
        private Value<bool?> _hasEscrowUserDefinedIndicator4;
        public bool? HasEscrowUserDefinedIndicator4 { get { return _hasEscrowUserDefinedIndicator4; } set { _hasEscrowUserDefinedIndicator4 = value; } }
        private Value<decimal?> _highestArmRate;
        public decimal? HighestArmRate { get { return _highestArmRate; } set { _highestArmRate = value; } }
        private Value<decimal?> _hud1GovernmentRecordingCharge;
        public decimal? Hud1GovernmentRecordingCharge { get { return _hud1GovernmentRecordingCharge; } set { _hud1GovernmentRecordingCharge = value; } }
        private Value<decimal?> _hud1Pg1SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get { return _hud1Pg1SellerPaidClosingCostsAmount; } set { _hud1Pg1SellerPaidClosingCostsAmount = value; } }
        private Value<decimal?> _hud1Pg1TotalSettlementCharges;
        public decimal? Hud1Pg1TotalSettlementCharges { get { return _hud1Pg1TotalSettlementCharges; } set { _hud1Pg1TotalSettlementCharges = value; } }
        private Value<decimal?> _hud1Pg2SellerPaidClosingCostsAmount;
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get { return _hud1Pg2SellerPaidClosingCostsAmount; } set { _hud1Pg2SellerPaidClosingCostsAmount = value; } }
        private Value<decimal?> _hud1Pg2TotalSettlementCharges;
        public decimal? Hud1Pg2TotalSettlementCharges { get { return _hud1Pg2TotalSettlementCharges; } set { _hud1Pg2TotalSettlementCharges = value; } }
        private Value<decimal?> _hudTotalTolerance;
        public decimal? HudTotalTolerance { get { return _hudTotalTolerance; } set { _hudTotalTolerance = value; } }
        private Value<decimal?> _hudTotalToleranceIncreasePercent;
        public decimal? HudTotalToleranceIncreasePercent { get { return _hudTotalToleranceIncreasePercent; } set { _hudTotalToleranceIncreasePercent = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<decimal?> _line1101SellerPaidTotal;
        public decimal? Line1101SellerPaidTotal { get { return _line1101SellerPaidTotal; } set { _line1101SellerPaidTotal = value; } }
        private Value<decimal?> _line1201SellerPaidTotal;
        public decimal? Line1201SellerPaidTotal { get { return _line1201SellerPaidTotal; } set { _line1201SellerPaidTotal = value; } }
        private Value<decimal?> _line1301SellerPaidTotal;
        public decimal? Line1301SellerPaidTotal { get { return _line1301SellerPaidTotal; } set { _line1301SellerPaidTotal = value; } }
        private Value<decimal?> _line801BorrowerPaidTotal;
        public decimal? Line801BorrowerPaidTotal { get { return _line801BorrowerPaidTotal; } set { _line801BorrowerPaidTotal = value; } }
        private Value<decimal?> _line801SellerPaidTotal;
        public decimal? Line801SellerPaidTotal { get { return _line801SellerPaidTotal; } set { _line801SellerPaidTotal = value; } }
        private Value<decimal?> _line802BorrowerPaidTotal;
        public decimal? Line802BorrowerPaidTotal { get { return _line802BorrowerPaidTotal; } set { _line802BorrowerPaidTotal = value; } }
        private Value<decimal?> _line803BorrowerPaidTotal;
        public decimal? Line803BorrowerPaidTotal { get { return _line803BorrowerPaidTotal; } set { _line803BorrowerPaidTotal = value; } }
        private Value<decimal?> _line803SellerPaidTotal;
        public decimal? Line803SellerPaidTotal { get { return _line803SellerPaidTotal; } set { _line803SellerPaidTotal = value; } }
        private Value<bool?> _line818FwbcIndicator;
        public bool? Line818FwbcIndicator { get { return _line818FwbcIndicator; } set { _line818FwbcIndicator = value; } }
        private Value<bool?> _line818FwscIndicator;
        public bool? Line818FwscIndicator { get { return _line818FwscIndicator; } set { _line818FwscIndicator = value; } }
        private Value<bool?> _line819FwbcIndicator;
        public bool? Line819FwbcIndicator { get { return _line819FwbcIndicator; } set { _line819FwbcIndicator = value; } }
        private Value<bool?> _line819FwscIndicator;
        public bool? Line819FwscIndicator { get { return _line819FwscIndicator; } set { _line819FwscIndicator = value; } }
        private Value<bool?> _line820FwbcIndicator;
        public bool? Line820FwbcIndicator { get { return _line820FwbcIndicator; } set { _line820FwbcIndicator = value; } }
        private Value<bool?> _line820FwscIndicator;
        public bool? Line820FwscIndicator { get { return _line820FwscIndicator; } set { _line820FwscIndicator = value; } }
        private Value<bool?> _line821FwbcIndicator;
        public bool? Line821FwbcIndicator { get { return _line821FwbcIndicator; } set { _line821FwbcIndicator = value; } }
        private Value<bool?> _line821FwscIndicator;
        public bool? Line821FwscIndicator { get { return _line821FwscIndicator; } set { _line821FwscIndicator = value; } }
        private Value<bool?> _line822FwbcIndicator;
        public bool? Line822FwbcIndicator { get { return _line822FwbcIndicator; } set { _line822FwbcIndicator = value; } }
        private Value<bool?> _line822FwscIndicator;
        public bool? Line822FwscIndicator { get { return _line822FwscIndicator; } set { _line822FwscIndicator = value; } }
        private Value<bool?> _line823FwbcIndicator;
        public bool? Line823FwbcIndicator { get { return _line823FwbcIndicator; } set { _line823FwbcIndicator = value; } }
        private Value<bool?> _line823FwscIndicator;
        public bool? Line823FwscIndicator { get { return _line823FwscIndicator; } set { _line823FwscIndicator = value; } }
        private Value<bool?> _line824FwbcIndicator;
        public bool? Line824FwbcIndicator { get { return _line824FwbcIndicator; } set { _line824FwbcIndicator = value; } }
        private Value<bool?> _line824FwscIndicator;
        public bool? Line824FwscIndicator { get { return _line824FwscIndicator; } set { _line824FwscIndicator = value; } }
        private Value<bool?> _line825FwbcIndicator;
        public bool? Line825FwbcIndicator { get { return _line825FwbcIndicator; } set { _line825FwbcIndicator = value; } }
        private Value<bool?> _line825FwscIndicator;
        public bool? Line825FwscIndicator { get { return _line825FwscIndicator; } set { _line825FwscIndicator = value; } }
        private Value<bool?> _line826FwbcIndicator;
        public bool? Line826FwbcIndicator { get { return _line826FwbcIndicator; } set { _line826FwbcIndicator = value; } }
        private Value<bool?> _line826FwscIndicator;
        public bool? Line826FwscIndicator { get { return _line826FwscIndicator; } set { _line826FwscIndicator = value; } }
        private Value<bool?> _line827FwbcIndicator;
        public bool? Line827FwbcIndicator { get { return _line827FwbcIndicator; } set { _line827FwbcIndicator = value; } }
        private Value<bool?> _line827FwscIndicator;
        public bool? Line827FwscIndicator { get { return _line827FwscIndicator; } set { _line827FwscIndicator = value; } }
        private Value<bool?> _line828FwbcIndicator;
        public bool? Line828FwbcIndicator { get { return _line828FwbcIndicator; } set { _line828FwbcIndicator = value; } }
        private Value<bool?> _line828FwscIndicator;
        public bool? Line828FwscIndicator { get { return _line828FwscIndicator; } set { _line828FwscIndicator = value; } }
        private Value<bool?> _line829FwbcIndicator;
        public bool? Line829FwbcIndicator { get { return _line829FwbcIndicator; } set { _line829FwbcIndicator = value; } }
        private Value<bool?> _line829FwscIndicator;
        public bool? Line829FwscIndicator { get { return _line829FwscIndicator; } set { _line829FwscIndicator = value; } }
        private Value<bool?> _line830FwbcIndicator;
        public bool? Line830FwbcIndicator { get { return _line830FwbcIndicator; } set { _line830FwbcIndicator = value; } }
        private Value<bool?> _line830FwscIndicator;
        public bool? Line830FwscIndicator { get { return _line830FwscIndicator; } set { _line830FwscIndicator = value; } }
        private Value<bool?> _line831FwbcIndicator;
        public bool? Line831FwbcIndicator { get { return _line831FwbcIndicator; } set { _line831FwbcIndicator = value; } }
        private Value<bool?> _line831FwscIndicator;
        public bool? Line831FwscIndicator { get { return _line831FwscIndicator; } set { _line831FwscIndicator = value; } }
        private Value<bool?> _line832FwbcIndicator;
        public bool? Line832FwbcIndicator { get { return _line832FwbcIndicator; } set { _line832FwbcIndicator = value; } }
        private Value<bool?> _line832FwscIndicator;
        public bool? Line832FwscIndicator { get { return _line832FwscIndicator; } set { _line832FwscIndicator = value; } }
        private Value<bool?> _line833FwbcIndicator;
        public bool? Line833FwbcIndicator { get { return _line833FwbcIndicator; } set { _line833FwbcIndicator = value; } }
        private Value<bool?> _line833FwscIndicator;
        public bool? Line833FwscIndicator { get { return _line833FwscIndicator; } set { _line833FwscIndicator = value; } }
        private Value<bool?> _lineLFwbcIndicator;
        public bool? LineLFwbcIndicator { get { return _lineLFwbcIndicator; } set { _lineLFwbcIndicator = value; } }
        private Value<bool?> _lineLFwscIndicator;
        public bool? LineLFwscIndicator { get { return _lineLFwscIndicator; } set { _lineLFwscIndicator = value; } }
        private Value<bool?> _lineMFwbcIndicator;
        public bool? LineMFwbcIndicator { get { return _lineMFwbcIndicator; } set { _lineMFwbcIndicator = value; } }
        private Value<bool?> _lineMFwscIndicator;
        public bool? LineMFwscIndicator { get { return _lineMFwscIndicator; } set { _lineMFwscIndicator = value; } }
        private Value<bool?> _lineNFwbcIndicator;
        public bool? LineNFwbcIndicator { get { return _lineNFwbcIndicator; } set { _lineNFwbcIndicator = value; } }
        private Value<bool?> _lineNFwscIndicator;
        public bool? LineNFwscIndicator { get { return _lineNFwscIndicator; } set { _lineNFwscIndicator = value; } }
        private Value<bool?> _lineOFwbcIndicator;
        public bool? LineOFwbcIndicator { get { return _lineOFwbcIndicator; } set { _lineOFwbcIndicator = value; } }
        private Value<bool?> _lineOFwscIndicator;
        public bool? LineOFwscIndicator { get { return _lineOFwscIndicator; } set { _lineOFwscIndicator = value; } }
        private Value<bool?> _linePFwbcIndicator;
        public bool? LinePFwbcIndicator { get { return _linePFwbcIndicator; } set { _linePFwbcIndicator = value; } }
        private Value<bool?> _linePFwscIndicator;
        public bool? LinePFwscIndicator { get { return _linePFwscIndicator; } set { _linePFwscIndicator = value; } }
        private Value<bool?> _lineQFwbcIndicator;
        public bool? LineQFwbcIndicator { get { return _lineQFwbcIndicator; } set { _lineQFwbcIndicator = value; } }
        private Value<bool?> _lineQFwscIndicator;
        public bool? LineQFwscIndicator { get { return _lineQFwscIndicator; } set { _lineQFwscIndicator = value; } }
        private Value<bool?> _lineRFwbcIndicator;
        public bool? LineRFwbcIndicator { get { return _lineRFwbcIndicator; } set { _lineRFwbcIndicator = value; } }
        private Value<bool?> _lineRFwscIndicator;
        public bool? LineRFwscIndicator { get { return _lineRFwscIndicator; } set { _lineRFwscIndicator = value; } }
        private Value<decimal?> _lowestArmRate;
        public decimal? LowestArmRate { get { return _lowestArmRate; } set { _lowestArmRate = value; } }
        private Value<bool?> _monthlyAmountIncludeInterestIndicator;
        public bool? MonthlyAmountIncludeInterestIndicator { get { return _monthlyAmountIncludeInterestIndicator; } set { _monthlyAmountIncludeInterestIndicator = value; } }
        private Value<bool?> _monthlyAmountIncludeMiIndicator;
        public bool? MonthlyAmountIncludeMiIndicator { get { return _monthlyAmountIncludeMiIndicator; } set { _monthlyAmountIncludeMiIndicator = value; } }
        private Value<bool?> _monthlyAmountIncludePrincipalIndicator;
        public bool? MonthlyAmountIncludePrincipalIndicator { get { return _monthlyAmountIncludePrincipalIndicator; } set { _monthlyAmountIncludePrincipalIndicator = value; } }
        private Value<decimal?> _monthlyAmountWithEscrow;
        public decimal? MonthlyAmountWithEscrow { get { return _monthlyAmountWithEscrow; } set { _monthlyAmountWithEscrow = value; } }
        private Value<decimal?> _monthlyEscrowPayment;
        public decimal? MonthlyEscrowPayment { get { return _monthlyEscrowPayment; } set { _monthlyEscrowPayment = value; } }
        private Value<decimal?> _prepaidInterest;
        public decimal? PrepaidInterest { get { return _prepaidInterest; } set { _prepaidInterest = value; } }
        private Value<decimal?> _totalToleranceIncreaseAmount;
        public decimal? TotalToleranceIncreaseAmount { get { return _totalToleranceIncreaseAmount; } set { _totalToleranceIncreaseAmount = value; } }
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
                var balloonPaymentDueInYears = _balloonPaymentDueInYears; balloonPaymentDueInYears.Clean = value; _balloonPaymentDueInYears = balloonPaymentDueInYears;
                var brokerCompensationFwbc = _brokerCompensationFwbc; brokerCompensationFwbc.Clean = value; _brokerCompensationFwbc = brokerCompensationFwbc;
                var brokerCompensationFwsc = _brokerCompensationFwsc; brokerCompensationFwsc.Clean = value; _brokerCompensationFwsc = brokerCompensationFwsc;
                var curedGfeTotalTolerance = _curedGfeTotalTolerance; curedGfeTotalTolerance.Clean = value; _curedGfeTotalTolerance = curedGfeTotalTolerance;
                var firstArmChangeDate = _firstArmChangeDate; firstArmChangeDate.Clean = value; _firstArmChangeDate = firstArmChangeDate;
                var gfe2010FwbcFwscs = _gfe2010FwbcFwscs; gfe2010FwbcFwscs.Clean = value; _gfe2010FwbcFwscs = gfe2010FwbcFwscs;
                var gfe2010GfeCharges = _gfe2010GfeCharges; gfe2010GfeCharges.Clean = value; _gfe2010GfeCharges = gfe2010GfeCharges;
                var gfeRecordingCharges = _gfeRecordingCharges; gfeRecordingCharges.Clean = value; _gfeRecordingCharges = gfeRecordingCharges;
                var gfeTotalTolerance = _gfeTotalTolerance; gfeTotalTolerance.Clean = value; _gfeTotalTolerance = gfeTotalTolerance;
                var hasEscrowAccountIndicator = _hasEscrowAccountIndicator; hasEscrowAccountIndicator.Clean = value; _hasEscrowAccountIndicator = hasEscrowAccountIndicator;
                var hasEscrowCityPropertyTaxesIndicator = _hasEscrowCityPropertyTaxesIndicator; hasEscrowCityPropertyTaxesIndicator.Clean = value; _hasEscrowCityPropertyTaxesIndicator = hasEscrowCityPropertyTaxesIndicator;
                var hasEscrowFloodInsurancesIndicator = _hasEscrowFloodInsurancesIndicator; hasEscrowFloodInsurancesIndicator.Clean = value; _hasEscrowFloodInsurancesIndicator = hasEscrowFloodInsurancesIndicator;
                var hasEscrowHomeownerInsurancesIndicator = _hasEscrowHomeownerInsurancesIndicator; hasEscrowHomeownerInsurancesIndicator.Clean = value; _hasEscrowHomeownerInsurancesIndicator = hasEscrowHomeownerInsurancesIndicator;
                var hasEscrowPropertyTaxesIndicator = _hasEscrowPropertyTaxesIndicator; hasEscrowPropertyTaxesIndicator.Clean = value; _hasEscrowPropertyTaxesIndicator = hasEscrowPropertyTaxesIndicator;
                var hasEscrowUserDefinedIndicator1 = _hasEscrowUserDefinedIndicator1; hasEscrowUserDefinedIndicator1.Clean = value; _hasEscrowUserDefinedIndicator1 = hasEscrowUserDefinedIndicator1;
                var hasEscrowUserDefinedIndicator2 = _hasEscrowUserDefinedIndicator2; hasEscrowUserDefinedIndicator2.Clean = value; _hasEscrowUserDefinedIndicator2 = hasEscrowUserDefinedIndicator2;
                var hasEscrowUserDefinedIndicator3 = _hasEscrowUserDefinedIndicator3; hasEscrowUserDefinedIndicator3.Clean = value; _hasEscrowUserDefinedIndicator3 = hasEscrowUserDefinedIndicator3;
                var hasEscrowUserDefinedIndicator4 = _hasEscrowUserDefinedIndicator4; hasEscrowUserDefinedIndicator4.Clean = value; _hasEscrowUserDefinedIndicator4 = hasEscrowUserDefinedIndicator4;
                var highestArmRate = _highestArmRate; highestArmRate.Clean = value; _highestArmRate = highestArmRate;
                var hud1GovernmentRecordingCharge = _hud1GovernmentRecordingCharge; hud1GovernmentRecordingCharge.Clean = value; _hud1GovernmentRecordingCharge = hud1GovernmentRecordingCharge;
                var hud1Pg1SellerPaidClosingCostsAmount = _hud1Pg1SellerPaidClosingCostsAmount; hud1Pg1SellerPaidClosingCostsAmount.Clean = value; _hud1Pg1SellerPaidClosingCostsAmount = hud1Pg1SellerPaidClosingCostsAmount;
                var hud1Pg1TotalSettlementCharges = _hud1Pg1TotalSettlementCharges; hud1Pg1TotalSettlementCharges.Clean = value; _hud1Pg1TotalSettlementCharges = hud1Pg1TotalSettlementCharges;
                var hud1Pg2SellerPaidClosingCostsAmount = _hud1Pg2SellerPaidClosingCostsAmount; hud1Pg2SellerPaidClosingCostsAmount.Clean = value; _hud1Pg2SellerPaidClosingCostsAmount = hud1Pg2SellerPaidClosingCostsAmount;
                var hud1Pg2TotalSettlementCharges = _hud1Pg2TotalSettlementCharges; hud1Pg2TotalSettlementCharges.Clean = value; _hud1Pg2TotalSettlementCharges = hud1Pg2TotalSettlementCharges;
                var hudTotalTolerance = _hudTotalTolerance; hudTotalTolerance.Clean = value; _hudTotalTolerance = hudTotalTolerance;
                var hudTotalToleranceIncreasePercent = _hudTotalToleranceIncreasePercent; hudTotalToleranceIncreasePercent.Clean = value; _hudTotalToleranceIncreasePercent = hudTotalToleranceIncreasePercent;
                var id = _id; id.Clean = value; _id = id;
                var line1101SellerPaidTotal = _line1101SellerPaidTotal; line1101SellerPaidTotal.Clean = value; _line1101SellerPaidTotal = line1101SellerPaidTotal;
                var line1201SellerPaidTotal = _line1201SellerPaidTotal; line1201SellerPaidTotal.Clean = value; _line1201SellerPaidTotal = line1201SellerPaidTotal;
                var line1301SellerPaidTotal = _line1301SellerPaidTotal; line1301SellerPaidTotal.Clean = value; _line1301SellerPaidTotal = line1301SellerPaidTotal;
                var line801BorrowerPaidTotal = _line801BorrowerPaidTotal; line801BorrowerPaidTotal.Clean = value; _line801BorrowerPaidTotal = line801BorrowerPaidTotal;
                var line801SellerPaidTotal = _line801SellerPaidTotal; line801SellerPaidTotal.Clean = value; _line801SellerPaidTotal = line801SellerPaidTotal;
                var line802BorrowerPaidTotal = _line802BorrowerPaidTotal; line802BorrowerPaidTotal.Clean = value; _line802BorrowerPaidTotal = line802BorrowerPaidTotal;
                var line803BorrowerPaidTotal = _line803BorrowerPaidTotal; line803BorrowerPaidTotal.Clean = value; _line803BorrowerPaidTotal = line803BorrowerPaidTotal;
                var line803SellerPaidTotal = _line803SellerPaidTotal; line803SellerPaidTotal.Clean = value; _line803SellerPaidTotal = line803SellerPaidTotal;
                var line818FwbcIndicator = _line818FwbcIndicator; line818FwbcIndicator.Clean = value; _line818FwbcIndicator = line818FwbcIndicator;
                var line818FwscIndicator = _line818FwscIndicator; line818FwscIndicator.Clean = value; _line818FwscIndicator = line818FwscIndicator;
                var line819FwbcIndicator = _line819FwbcIndicator; line819FwbcIndicator.Clean = value; _line819FwbcIndicator = line819FwbcIndicator;
                var line819FwscIndicator = _line819FwscIndicator; line819FwscIndicator.Clean = value; _line819FwscIndicator = line819FwscIndicator;
                var line820FwbcIndicator = _line820FwbcIndicator; line820FwbcIndicator.Clean = value; _line820FwbcIndicator = line820FwbcIndicator;
                var line820FwscIndicator = _line820FwscIndicator; line820FwscIndicator.Clean = value; _line820FwscIndicator = line820FwscIndicator;
                var line821FwbcIndicator = _line821FwbcIndicator; line821FwbcIndicator.Clean = value; _line821FwbcIndicator = line821FwbcIndicator;
                var line821FwscIndicator = _line821FwscIndicator; line821FwscIndicator.Clean = value; _line821FwscIndicator = line821FwscIndicator;
                var line822FwbcIndicator = _line822FwbcIndicator; line822FwbcIndicator.Clean = value; _line822FwbcIndicator = line822FwbcIndicator;
                var line822FwscIndicator = _line822FwscIndicator; line822FwscIndicator.Clean = value; _line822FwscIndicator = line822FwscIndicator;
                var line823FwbcIndicator = _line823FwbcIndicator; line823FwbcIndicator.Clean = value; _line823FwbcIndicator = line823FwbcIndicator;
                var line823FwscIndicator = _line823FwscIndicator; line823FwscIndicator.Clean = value; _line823FwscIndicator = line823FwscIndicator;
                var line824FwbcIndicator = _line824FwbcIndicator; line824FwbcIndicator.Clean = value; _line824FwbcIndicator = line824FwbcIndicator;
                var line824FwscIndicator = _line824FwscIndicator; line824FwscIndicator.Clean = value; _line824FwscIndicator = line824FwscIndicator;
                var line825FwbcIndicator = _line825FwbcIndicator; line825FwbcIndicator.Clean = value; _line825FwbcIndicator = line825FwbcIndicator;
                var line825FwscIndicator = _line825FwscIndicator; line825FwscIndicator.Clean = value; _line825FwscIndicator = line825FwscIndicator;
                var line826FwbcIndicator = _line826FwbcIndicator; line826FwbcIndicator.Clean = value; _line826FwbcIndicator = line826FwbcIndicator;
                var line826FwscIndicator = _line826FwscIndicator; line826FwscIndicator.Clean = value; _line826FwscIndicator = line826FwscIndicator;
                var line827FwbcIndicator = _line827FwbcIndicator; line827FwbcIndicator.Clean = value; _line827FwbcIndicator = line827FwbcIndicator;
                var line827FwscIndicator = _line827FwscIndicator; line827FwscIndicator.Clean = value; _line827FwscIndicator = line827FwscIndicator;
                var line828FwbcIndicator = _line828FwbcIndicator; line828FwbcIndicator.Clean = value; _line828FwbcIndicator = line828FwbcIndicator;
                var line828FwscIndicator = _line828FwscIndicator; line828FwscIndicator.Clean = value; _line828FwscIndicator = line828FwscIndicator;
                var line829FwbcIndicator = _line829FwbcIndicator; line829FwbcIndicator.Clean = value; _line829FwbcIndicator = line829FwbcIndicator;
                var line829FwscIndicator = _line829FwscIndicator; line829FwscIndicator.Clean = value; _line829FwscIndicator = line829FwscIndicator;
                var line830FwbcIndicator = _line830FwbcIndicator; line830FwbcIndicator.Clean = value; _line830FwbcIndicator = line830FwbcIndicator;
                var line830FwscIndicator = _line830FwscIndicator; line830FwscIndicator.Clean = value; _line830FwscIndicator = line830FwscIndicator;
                var line831FwbcIndicator = _line831FwbcIndicator; line831FwbcIndicator.Clean = value; _line831FwbcIndicator = line831FwbcIndicator;
                var line831FwscIndicator = _line831FwscIndicator; line831FwscIndicator.Clean = value; _line831FwscIndicator = line831FwscIndicator;
                var line832FwbcIndicator = _line832FwbcIndicator; line832FwbcIndicator.Clean = value; _line832FwbcIndicator = line832FwbcIndicator;
                var line832FwscIndicator = _line832FwscIndicator; line832FwscIndicator.Clean = value; _line832FwscIndicator = line832FwscIndicator;
                var line833FwbcIndicator = _line833FwbcIndicator; line833FwbcIndicator.Clean = value; _line833FwbcIndicator = line833FwbcIndicator;
                var line833FwscIndicator = _line833FwscIndicator; line833FwscIndicator.Clean = value; _line833FwscIndicator = line833FwscIndicator;
                var lineLFwbcIndicator = _lineLFwbcIndicator; lineLFwbcIndicator.Clean = value; _lineLFwbcIndicator = lineLFwbcIndicator;
                var lineLFwscIndicator = _lineLFwscIndicator; lineLFwscIndicator.Clean = value; _lineLFwscIndicator = lineLFwscIndicator;
                var lineMFwbcIndicator = _lineMFwbcIndicator; lineMFwbcIndicator.Clean = value; _lineMFwbcIndicator = lineMFwbcIndicator;
                var lineMFwscIndicator = _lineMFwscIndicator; lineMFwscIndicator.Clean = value; _lineMFwscIndicator = lineMFwscIndicator;
                var lineNFwbcIndicator = _lineNFwbcIndicator; lineNFwbcIndicator.Clean = value; _lineNFwbcIndicator = lineNFwbcIndicator;
                var lineNFwscIndicator = _lineNFwscIndicator; lineNFwscIndicator.Clean = value; _lineNFwscIndicator = lineNFwscIndicator;
                var lineOFwbcIndicator = _lineOFwbcIndicator; lineOFwbcIndicator.Clean = value; _lineOFwbcIndicator = lineOFwbcIndicator;
                var lineOFwscIndicator = _lineOFwscIndicator; lineOFwscIndicator.Clean = value; _lineOFwscIndicator = lineOFwscIndicator;
                var linePFwbcIndicator = _linePFwbcIndicator; linePFwbcIndicator.Clean = value; _linePFwbcIndicator = linePFwbcIndicator;
                var linePFwscIndicator = _linePFwscIndicator; linePFwscIndicator.Clean = value; _linePFwscIndicator = linePFwscIndicator;
                var lineQFwbcIndicator = _lineQFwbcIndicator; lineQFwbcIndicator.Clean = value; _lineQFwbcIndicator = lineQFwbcIndicator;
                var lineQFwscIndicator = _lineQFwscIndicator; lineQFwscIndicator.Clean = value; _lineQFwscIndicator = lineQFwscIndicator;
                var lineRFwbcIndicator = _lineRFwbcIndicator; lineRFwbcIndicator.Clean = value; _lineRFwbcIndicator = lineRFwbcIndicator;
                var lineRFwscIndicator = _lineRFwscIndicator; lineRFwscIndicator.Clean = value; _lineRFwscIndicator = lineRFwscIndicator;
                var lowestArmRate = _lowestArmRate; lowestArmRate.Clean = value; _lowestArmRate = lowestArmRate;
                var monthlyAmountIncludeInterestIndicator = _monthlyAmountIncludeInterestIndicator; monthlyAmountIncludeInterestIndicator.Clean = value; _monthlyAmountIncludeInterestIndicator = monthlyAmountIncludeInterestIndicator;
                var monthlyAmountIncludeMiIndicator = _monthlyAmountIncludeMiIndicator; monthlyAmountIncludeMiIndicator.Clean = value; _monthlyAmountIncludeMiIndicator = monthlyAmountIncludeMiIndicator;
                var monthlyAmountIncludePrincipalIndicator = _monthlyAmountIncludePrincipalIndicator; monthlyAmountIncludePrincipalIndicator.Clean = value; _monthlyAmountIncludePrincipalIndicator = monthlyAmountIncludePrincipalIndicator;
                var monthlyAmountWithEscrow = _monthlyAmountWithEscrow; monthlyAmountWithEscrow.Clean = value; _monthlyAmountWithEscrow = monthlyAmountWithEscrow;
                var monthlyEscrowPayment = _monthlyEscrowPayment; monthlyEscrowPayment.Clean = value; _monthlyEscrowPayment = monthlyEscrowPayment;
                var prepaidInterest = _prepaidInterest; prepaidInterest.Clean = value; _prepaidInterest = prepaidInterest;
                var totalToleranceIncreaseAmount = _totalToleranceIncreaseAmount; totalToleranceIncreaseAmount.Clean = value; _totalToleranceIncreaseAmount = totalToleranceIncreaseAmount;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010Page()
        {
            Clean = true;
        }
    }
}