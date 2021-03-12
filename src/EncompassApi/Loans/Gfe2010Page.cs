using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassApi.Schema;

namespace EncompassApi.Loans
{
    /// <summary>
    /// Gfe2010Page
    /// </summary>
    public sealed partial class Gfe2010Page : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?>? _balloonPaymentDueInYears;
        private DirtyValue<string?>? _brokerCompensationFwbc;
        private DirtyValue<string?>? _brokerCompensationFwsc;
        private DirtyValue<decimal?>? _curedGfeTotalTolerance;
        private DirtyValue<DateTime?>? _firstArmChangeDate;
        private DirtyList<Gfe2010FwbcFwsc>? _gfe2010FwbcFwscs;
        private DirtyList<Gfe2010GfeCharge>? _gfe2010GfeCharges;
        private DirtyValue<string?>? _gfeRecordingCharges;
        private DirtyValue<decimal?>? _gfeTotalTolerance;
        private DirtyValue<bool?>? _hasEscrowAccountIndicator;
        private DirtyValue<bool?>? _hasEscrowCityPropertyTaxesIndicator;
        private DirtyValue<bool?>? _hasEscrowFloodInsurancesIndicator;
        private DirtyValue<bool?>? _hasEscrowHomeownerInsurancesIndicator;
        private DirtyValue<bool?>? _hasEscrowPropertyTaxesIndicator;
        private DirtyValue<bool?>? _hasEscrowUserDefinedIndicator1;
        private DirtyValue<bool?>? _hasEscrowUserDefinedIndicator2;
        private DirtyValue<bool?>? _hasEscrowUserDefinedIndicator3;
        private DirtyValue<bool?>? _hasEscrowUserDefinedIndicator4;
        private DirtyValue<decimal?>? _highestArmRate;
        private DirtyValue<decimal?>? _hud1GovernmentRecordingCharge;
        private DirtyValue<decimal?>? _hud1Pg1SellerPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _hud1Pg1TotalSettlementCharges;
        private DirtyValue<decimal?>? _hud1Pg2SellerPaidClosingCostsAmount;
        private DirtyValue<decimal?>? _hud1Pg2TotalSettlementCharges;
        private DirtyValue<decimal?>? _hudTotalTolerance;
        private DirtyValue<decimal?>? _hudTotalToleranceIncreasePercent;
        private DirtyValue<string?>? _id;
        private DirtyValue<decimal?>? _line1101SellerPaidTotal;
        private DirtyValue<decimal?>? _line1201SellerPaidTotal;
        private DirtyValue<decimal?>? _line1301SellerPaidTotal;
        private DirtyValue<decimal?>? _line801BorrowerPaidTotal;
        private DirtyValue<decimal?>? _line801SellerPaidTotal;
        private DirtyValue<decimal?>? _line802BorrowerPaidTotal;
        private DirtyValue<decimal?>? _line803BorrowerPaidTotal;
        private DirtyValue<decimal?>? _line803SellerPaidTotal;
        private DirtyValue<bool?>? _line818FwbcIndicator;
        private DirtyValue<bool?>? _line818FwscIndicator;
        private DirtyValue<bool?>? _line819FwbcIndicator;
        private DirtyValue<bool?>? _line819FwscIndicator;
        private DirtyValue<bool?>? _line820FwbcIndicator;
        private DirtyValue<bool?>? _line820FwscIndicator;
        private DirtyValue<bool?>? _line821FwbcIndicator;
        private DirtyValue<bool?>? _line821FwscIndicator;
        private DirtyValue<bool?>? _line822FwbcIndicator;
        private DirtyValue<bool?>? _line822FwscIndicator;
        private DirtyValue<bool?>? _line823FwbcIndicator;
        private DirtyValue<bool?>? _line823FwscIndicator;
        private DirtyValue<bool?>? _line824FwbcIndicator;
        private DirtyValue<bool?>? _line824FwscIndicator;
        private DirtyValue<bool?>? _line825FwbcIndicator;
        private DirtyValue<bool?>? _line825FwscIndicator;
        private DirtyValue<bool?>? _line826FwbcIndicator;
        private DirtyValue<bool?>? _line826FwscIndicator;
        private DirtyValue<bool?>? _line827FwbcIndicator;
        private DirtyValue<bool?>? _line827FwscIndicator;
        private DirtyValue<bool?>? _line828FwbcIndicator;
        private DirtyValue<bool?>? _line828FwscIndicator;
        private DirtyValue<bool?>? _line829FwbcIndicator;
        private DirtyValue<bool?>? _line829FwscIndicator;
        private DirtyValue<bool?>? _line830FwbcIndicator;
        private DirtyValue<bool?>? _line830FwscIndicator;
        private DirtyValue<bool?>? _line831FwbcIndicator;
        private DirtyValue<bool?>? _line831FwscIndicator;
        private DirtyValue<bool?>? _line832FwbcIndicator;
        private DirtyValue<bool?>? _line832FwscIndicator;
        private DirtyValue<bool?>? _line833FwbcIndicator;
        private DirtyValue<bool?>? _line833FwscIndicator;
        private DirtyValue<bool?>? _lineLFwbcIndicator;
        private DirtyValue<bool?>? _lineLFwscIndicator;
        private DirtyValue<bool?>? _lineMFwbcIndicator;
        private DirtyValue<bool?>? _lineMFwscIndicator;
        private DirtyValue<bool?>? _lineNFwbcIndicator;
        private DirtyValue<bool?>? _lineNFwscIndicator;
        private DirtyValue<bool?>? _lineOFwbcIndicator;
        private DirtyValue<bool?>? _lineOFwscIndicator;
        private DirtyValue<bool?>? _linePFwbcIndicator;
        private DirtyValue<bool?>? _linePFwscIndicator;
        private DirtyValue<bool?>? _lineQFwbcIndicator;
        private DirtyValue<bool?>? _lineQFwscIndicator;
        private DirtyValue<bool?>? _lineRFwbcIndicator;
        private DirtyValue<bool?>? _lineRFwscIndicator;
        private DirtyValue<decimal?>? _lowestArmRate;
        private DirtyValue<bool?>? _monthlyAmountIncludeInterestIndicator;
        private DirtyValue<bool?>? _monthlyAmountIncludeMiIndicator;
        private DirtyValue<bool?>? _monthlyAmountIncludePrincipalIndicator;
        private DirtyValue<decimal?>? _monthlyAmountWithEscrow;
        private DirtyValue<decimal?>? _monthlyEscrowPayment;
        private DirtyValue<decimal?>? _prepaidInterest;
        private DirtyValue<decimal?>? _totalToleranceIncreaseAmount;

        /// <summary>
        /// Years Until Balloon Pymt Due [NEWHUD.X348]
        /// </summary>
        public int? BalloonPaymentDueInYears { get => _balloonPaymentDueInYears; set => SetField(ref _balloonPaymentDueInYears, value); }

        /// <summary>
        /// Fees Line Fees Line 801 Broker Compensation Borrower Checked [NEWHUD.X672]
        /// </summary>
        public string? BrokerCompensationFwbc { get => _brokerCompensationFwbc; set => SetField(ref _brokerCompensationFwbc, value); }

        /// <summary>
        /// Fees Line Fees Line 801 Broker Compensation Seller Checked [NEWHUD.X673]
        /// </summary>
        public string? BrokerCompensationFwsc { get => _brokerCompensationFwsc; set => SetField(ref _brokerCompensationFwsc, value); }

        /// <summary>
        /// Cured Total GFE Tolerance [NEWHUD.CuredX312]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CuredGfeTotalTolerance { get => _curedGfeTotalTolerance; set => SetField(ref _curedGfeTotalTolerance, value); }

        /// <summary>
        /// First ARM Change Date [NEWHUD.X332]
        /// </summary>
        public DateTime? FirstArmChangeDate { get => _firstArmChangeDate; set => SetField(ref _firstArmChangeDate, value); }

        /// <summary>
        /// Gfe2010Page Gfe2010FwbcFwscs
        /// </summary>
        [AllowNull]
        public IList<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get => GetField(ref _gfe2010FwbcFwscs); set => SetField(ref _gfe2010FwbcFwscs, value); }

        /// <summary>
        /// Gfe2010Page Gfe2010GfeCharges
        /// </summary>
        [AllowNull]
        public IList<Gfe2010GfeCharge> Gfe2010GfeCharges { get => GetField(ref _gfe2010GfeCharges); set => SetField(ref _gfe2010GfeCharges, value); }

        /// <summary>
        /// GFE Gov Recording Chrgs [NEWHUD.X295]
        /// </summary>
        public string? GfeRecordingCharges { get => _gfeRecordingCharges; set => SetField(ref _gfeRecordingCharges, value); }

        /// <summary>
        /// Total GFE Tolerance [NEWHUD.X312]
        /// </summary>
        public decimal? GfeTotalTolerance { get => _gfeTotalTolerance; set => SetField(ref _gfeTotalTolerance, value); }

        /// <summary>
        /// Has Escrow Acct [NEWHUD.X335]
        /// </summary>
        public bool? HasEscrowAccountIndicator { get => _hasEscrowAccountIndicator; set => SetField(ref _hasEscrowAccountIndicator, value); }

        /// <summary>
        /// Incl Escrow-City Prop Taxes [NEWHUD.X1726]
        /// </summary>
        public bool? HasEscrowCityPropertyTaxesIndicator { get => _hasEscrowCityPropertyTaxesIndicator; set => SetField(ref _hasEscrowCityPropertyTaxesIndicator, value); }

        /// <summary>
        /// Incl Escrow-Flood Ins [NEWHUD.X338]
        /// </summary>
        public bool? HasEscrowFloodInsurancesIndicator { get => _hasEscrowFloodInsurancesIndicator; set => SetField(ref _hasEscrowFloodInsurancesIndicator, value); }

        /// <summary>
        /// Incl Escrow-Homeowners Ins [NEWHUD.X339]
        /// </summary>
        public bool? HasEscrowHomeownerInsurancesIndicator { get => _hasEscrowHomeownerInsurancesIndicator; set => SetField(ref _hasEscrowHomeownerInsurancesIndicator, value); }

        /// <summary>
        /// Incl Escrow-Prop Taxes [NEWHUD.X337]
        /// </summary>
        public bool? HasEscrowPropertyTaxesIndicator { get => _hasEscrowPropertyTaxesIndicator; set => SetField(ref _hasEscrowPropertyTaxesIndicator, value); }

        /// <summary>
        /// Incl Escrow-User Defined 1 [NEWHUD.X340]
        /// </summary>
        public bool? HasEscrowUserDefinedIndicator1 { get => _hasEscrowUserDefinedIndicator1; set => SetField(ref _hasEscrowUserDefinedIndicator1, value); }

        /// <summary>
        /// Incl Escrow-User Defined 2 [NEWHUD.X341]
        /// </summary>
        public bool? HasEscrowUserDefinedIndicator2 { get => _hasEscrowUserDefinedIndicator2; set => SetField(ref _hasEscrowUserDefinedIndicator2, value); }

        /// <summary>
        /// Incl Escrow-User Defined 3 [NEWHUD.X342]
        /// </summary>
        public bool? HasEscrowUserDefinedIndicator3 { get => _hasEscrowUserDefinedIndicator3; set => SetField(ref _hasEscrowUserDefinedIndicator3, value); }

        /// <summary>
        /// New HUD-1 Page 3 Include Escrow Annual Fee [NEWHUD.X343]
        /// </summary>
        public bool? HasEscrowUserDefinedIndicator4 { get => _hasEscrowUserDefinedIndicator4; set => SetField(ref _hasEscrowUserDefinedIndicator4, value); }

        /// <summary>
        /// Highest ARM Rate [NEWHUD.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? HighestArmRate { get => _highestArmRate; set => SetField(ref _highestArmRate, value); }

        /// <summary>
        /// 10% Tolerance Comp Chart - HUD1 Government Recording Charge [NEWHUD.X336]
        /// </summary>
        public decimal? Hud1GovernmentRecordingCharge { get => _hud1GovernmentRecordingCharge; set => SetField(ref _hud1GovernmentRecordingCharge, value); }

        /// <summary>
        /// Seller Total Closing Cost for HUD-1 Pg1 [NEWHUD.X774]
        /// </summary>
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get => _hud1Pg1SellerPaidClosingCostsAmount; set => SetField(ref _hud1Pg1SellerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Borr Total Closing Cost for HUD-1 Pg1 [NEWHUD.X773]
        /// </summary>
        public decimal? Hud1Pg1TotalSettlementCharges { get => _hud1Pg1TotalSettlementCharges; set => SetField(ref _hud1Pg1TotalSettlementCharges, value); }

        /// <summary>
        /// Seller Total Closing Costs [NEWHUD.X278]
        /// </summary>
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get => _hud1Pg2SellerPaidClosingCostsAmount; set => SetField(ref _hud1Pg2SellerPaidClosingCostsAmount, value); }

        /// <summary>
        /// Borr Total Closing Costs [NEWHUD.X277]
        /// </summary>
        public decimal? Hud1Pg2TotalSettlementCharges { get => _hud1Pg2TotalSettlementCharges; set => SetField(ref _hud1Pg2TotalSettlementCharges, value); }

        /// <summary>
        /// Total HUD Tolerance [NEWHUD.X313]
        /// </summary>
        public decimal? HudTotalTolerance { get => _hudTotalTolerance; set => SetField(ref _hudTotalTolerance, value); }

        /// <summary>
        /// Total GFE Tolerance Increase % [NEWHUD.X315]
        /// </summary>
        public decimal? HudTotalToleranceIncreasePercent { get => _hudTotalToleranceIncreasePercent; set => SetField(ref _hudTotalToleranceIncreasePercent, value); }

        /// <summary>
        /// Gfe2010Page Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Fees Line 1101 Seller Paid Total [NEWHUD.X798]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line1101SellerPaidTotal { get => _line1101SellerPaidTotal; set => SetField(ref _line1101SellerPaidTotal, value); }

        /// <summary>
        /// Fees Line 1201 Seller Paid Total [NEWHUD.X799]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line1201SellerPaidTotal { get => _line1201SellerPaidTotal; set => SetField(ref _line1201SellerPaidTotal, value); }

        /// <summary>
        /// Fees Line 1301 Seller Paid Total [NEWHUD.X800]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line1301SellerPaidTotal { get => _line1301SellerPaidTotal; set => SetField(ref _line1301SellerPaidTotal, value); }

        /// <summary>
        /// Fees Line 801 Borrower Paid Total [NEWHUD.X795]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line801BorrowerPaidTotal { get => _line801BorrowerPaidTotal; set => SetField(ref _line801BorrowerPaidTotal, value); }

        /// <summary>
        /// Fees Line 801 Seller Paid Total [NEWHUD.X794]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line801SellerPaidTotal { get => _line801SellerPaidTotal; set => SetField(ref _line801SellerPaidTotal, value); }

        /// <summary>
        /// Fees Line 802 Borrower Paid Total [NEWHUD.X797]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line802BorrowerPaidTotal { get => _line802BorrowerPaidTotal; set => SetField(ref _line802BorrowerPaidTotal, value); }

        /// <summary>
        /// Fees Line 803 Borrower Paid Total [NEWHUD.X796]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line803BorrowerPaidTotal { get => _line803BorrowerPaidTotal; set => SetField(ref _line803BorrowerPaidTotal, value); }

        /// <summary>
        /// Fees Line 803 Seller Paid Total [NEWHUD.X801]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? Line803SellerPaidTotal { get => _line803SellerPaidTotal; set => SetField(ref _line803SellerPaidTotal, value); }

        /// <summary>
        /// Fees Line 820 Funding Worksheet Checkbox for Borrower [NEWHUD.X1486]
        /// </summary>
        public bool? Line818FwbcIndicator { get => _line818FwbcIndicator; set => SetField(ref _line818FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 820 Funding Worksheet Checkbox for Seller [NEWHUD.X1509]
        /// </summary>
        public bool? Line818FwscIndicator { get => _line818FwscIndicator; set => SetField(ref _line818FwscIndicator, value); }

        /// <summary>
        /// Fees Line 821 Funding Worksheet Checkbox for Borrower [NEWHUD.X1487]
        /// </summary>
        public bool? Line819FwbcIndicator { get => _line819FwbcIndicator; set => SetField(ref _line819FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 821 Funding Worksheet Checkbox for Seller [NEWHUD.X1510]
        /// </summary>
        public bool? Line819FwscIndicator { get => _line819FwscIndicator; set => SetField(ref _line819FwscIndicator, value); }

        /// <summary>
        /// Fees Line 822 Funding Worksheet Checkbox for Borrower [NEWHUD.X1488]
        /// </summary>
        public bool? Line820FwbcIndicator { get => _line820FwbcIndicator; set => SetField(ref _line820FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 822 Funding Worksheet Checkbox for Seller [NEWHUD.X1511]
        /// </summary>
        public bool? Line820FwscIndicator { get => _line820FwscIndicator; set => SetField(ref _line820FwscIndicator, value); }

        /// <summary>
        /// Fees Line 823 Funding Worksheet Checkbox for Borrower [NEWHUD.X1489]
        /// </summary>
        public bool? Line821FwbcIndicator { get => _line821FwbcIndicator; set => SetField(ref _line821FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 823 Funding Worksheet Checkbox for Seller [NEWHUD.X1512]
        /// </summary>
        public bool? Line821FwscIndicator { get => _line821FwscIndicator; set => SetField(ref _line821FwscIndicator, value); }

        /// <summary>
        /// Fees Line 824 Funding Worksheet Checkbox for Borrower [NEWHUD.X1490]
        /// </summary>
        public bool? Line822FwbcIndicator { get => _line822FwbcIndicator; set => SetField(ref _line822FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 824 Funding Worksheet Checkbox for Seller [NEWHUD.X1513]
        /// </summary>
        public bool? Line822FwscIndicator { get => _line822FwscIndicator; set => SetField(ref _line822FwscIndicator, value); }

        /// <summary>
        /// Fees Line 825 Funding Worksheet Checkbox for Borrower [NEWHUD.X1491]
        /// </summary>
        public bool? Line823FwbcIndicator { get => _line823FwbcIndicator; set => SetField(ref _line823FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 825 Funding Worksheet Checkbox for Seller [NEWHUD.X1514]
        /// </summary>
        public bool? Line823FwscIndicator { get => _line823FwscIndicator; set => SetField(ref _line823FwscIndicator, value); }

        /// <summary>
        /// Fees Line 826 Funding Worksheet Checkbox for Borrower [NEWHUD.X1492]
        /// </summary>
        public bool? Line824FwbcIndicator { get => _line824FwbcIndicator; set => SetField(ref _line824FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 826 Funding Worksheet Checkbox for Seller [NEWHUD.X1515]
        /// </summary>
        public bool? Line824FwscIndicator { get => _line824FwscIndicator; set => SetField(ref _line824FwscIndicator, value); }

        /// <summary>
        /// Fees Line 827 Funding Worksheet Checkbox for Borrower [NEWHUD.X1493]
        /// </summary>
        public bool? Line825FwbcIndicator { get => _line825FwbcIndicator; set => SetField(ref _line825FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 827 Funding Worksheet Checkbox for Seller [NEWHUD.X1516]
        /// </summary>
        public bool? Line825FwscIndicator { get => _line825FwscIndicator; set => SetField(ref _line825FwscIndicator, value); }

        /// <summary>
        /// Fees Line 828 Funding Worksheet Checkbox for Borrower [NEWHUD.X1494]
        /// </summary>
        public bool? Line826FwbcIndicator { get => _line826FwbcIndicator; set => SetField(ref _line826FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 828 Funding Worksheet Checkbox for Seller [NEWHUD.X1517]
        /// </summary>
        public bool? Line826FwscIndicator { get => _line826FwscIndicator; set => SetField(ref _line826FwscIndicator, value); }

        /// <summary>
        /// Fees Line 829 Funding Worksheet Checkbox for Borrower [NEWHUD.X1495]
        /// </summary>
        public bool? Line827FwbcIndicator { get => _line827FwbcIndicator; set => SetField(ref _line827FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 829 Funding Worksheet Checkbox for Seller [NEWHUD.X1518]
        /// </summary>
        public bool? Line827FwscIndicator { get => _line827FwscIndicator; set => SetField(ref _line827FwscIndicator, value); }

        /// <summary>
        /// Fees Line 830 Funding Worksheet Checkbox for Borrower [NEWHUD.X1496]
        /// </summary>
        public bool? Line828FwbcIndicator { get => _line828FwbcIndicator; set => SetField(ref _line828FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 830 Funding Worksheet Checkbox for Seller [NEWHUD.X1519]
        /// </summary>
        public bool? Line828FwscIndicator { get => _line828FwscIndicator; set => SetField(ref _line828FwscIndicator, value); }

        /// <summary>
        /// Fees Line 831 Funding Worksheet Checkbox for Borrower [NEWHUD.X1497]
        /// </summary>
        public bool? Line829FwbcIndicator { get => _line829FwbcIndicator; set => SetField(ref _line829FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 831 Funding Worksheet Checkbox for Seller [NEWHUD.X1520]
        /// </summary>
        public bool? Line829FwscIndicator { get => _line829FwscIndicator; set => SetField(ref _line829FwscIndicator, value); }

        /// <summary>
        /// Fees Line 832 Funding Worksheet Checkbox for Borrower [NEWHUD.X1498]
        /// </summary>
        public bool? Line830FwbcIndicator { get => _line830FwbcIndicator; set => SetField(ref _line830FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 832 Funding Worksheet Checkbox for Seller [NEWHUD.X1521]
        /// </summary>
        public bool? Line830FwscIndicator { get => _line830FwscIndicator; set => SetField(ref _line830FwscIndicator, value); }

        /// <summary>
        /// Fees Line 833 Funding Worksheet Checkbox for Borrower [NEWHUD.X1499]
        /// </summary>
        public bool? Line831FwbcIndicator { get => _line831FwbcIndicator; set => SetField(ref _line831FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 833 Funding Worksheet Checkbox for Seller [NEWHUD.X1522]
        /// </summary>
        public bool? Line831FwscIndicator { get => _line831FwscIndicator; set => SetField(ref _line831FwscIndicator, value); }

        /// <summary>
        /// Fees Line 834 Funding Worksheet Checkbox for Borrower [NEWHUD.X1500]
        /// </summary>
        public bool? Line832FwbcIndicator { get => _line832FwbcIndicator; set => SetField(ref _line832FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 834 Funding Worksheet Checkbox for Seller [NEWHUD.X1523]
        /// </summary>
        public bool? Line832FwscIndicator { get => _line832FwscIndicator; set => SetField(ref _line832FwscIndicator, value); }

        /// <summary>
        /// Fees Line 835 Funding Worksheet Checkbox for Borrower [NEWHUD.X1501]
        /// </summary>
        public bool? Line833FwbcIndicator { get => _line833FwbcIndicator; set => SetField(ref _line833FwbcIndicator, value); }

        /// <summary>
        /// Fees Line 835 Funding Worksheet Checkbox for Seller [NEWHUD.X1524]
        /// </summary>
        public bool? Line833FwscIndicator { get => _line833FwscIndicator; set => SetField(ref _line833FwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 L Funding Worksheet Checkbox for Borrower [NEWHUD.X1479]
        /// </summary>
        public bool? LineLFwbcIndicator { get => _lineLFwbcIndicator; set => SetField(ref _lineLFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 L Funding Worksheet Checkbox for Seller [NEWHUD.X1502]
        /// </summary>
        public bool? LineLFwscIndicator { get => _lineLFwscIndicator; set => SetField(ref _lineLFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 M Funding Worksheet Checkbox for Borrower [NEWHUD.X1480]
        /// </summary>
        public bool? LineMFwbcIndicator { get => _lineMFwbcIndicator; set => SetField(ref _lineMFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 M Funding Worksheet Checkbox for Seller [NEWHUD.X1503]
        /// </summary>
        public bool? LineMFwscIndicator { get => _lineMFwscIndicator; set => SetField(ref _lineMFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 N Funding Worksheet Checkbox for Borrower [NEWHUD.X1481]
        /// </summary>
        public bool? LineNFwbcIndicator { get => _lineNFwbcIndicator; set => SetField(ref _lineNFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 N Funding Worksheet Checkbox for Seller [NEWHUD.X1504]
        /// </summary>
        public bool? LineNFwscIndicator { get => _lineNFwscIndicator; set => SetField(ref _lineNFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 O Funding Worksheet Checkbox for Borrower [NEWHUD.X1482]
        /// </summary>
        public bool? LineOFwbcIndicator { get => _lineOFwbcIndicator; set => SetField(ref _lineOFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 O Funding Worksheet Checkbox for Seller [NEWHUD.X1505]
        /// </summary>
        public bool? LineOFwscIndicator { get => _lineOFwscIndicator; set => SetField(ref _lineOFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 P Funding Worksheet Checkbox for Borrower [NEWHUD.X1483]
        /// </summary>
        public bool? LinePFwbcIndicator { get => _linePFwbcIndicator; set => SetField(ref _linePFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 P Funding Worksheet Checkbox for Seller [NEWHUD.X1506]
        /// </summary>
        public bool? LinePFwscIndicator { get => _linePFwscIndicator; set => SetField(ref _linePFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 Q Funding Worksheet Checkbox for Borrower [NEWHUD.X1484]
        /// </summary>
        public bool? LineQFwbcIndicator { get => _lineQFwbcIndicator; set => SetField(ref _lineQFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 Q Funding Worksheet Checkbox for Seller [NEWHUD.X1507]
        /// </summary>
        public bool? LineQFwscIndicator { get => _lineQFwscIndicator; set => SetField(ref _lineQFwscIndicator, value); }

        /// <summary>
        /// Fees Line 801 R Funding Worksheet Checkbox for Borrower [NEWHUD.X1485]
        /// </summary>
        public bool? LineRFwbcIndicator { get => _lineRFwbcIndicator; set => SetField(ref _lineRFwbcIndicator, value); }

        /// <summary>
        /// Fees Line 801 R Funding Worksheet Checkbox for Seller [NEWHUD.X1508]
        /// </summary>
        public bool? LineRFwscIndicator { get => _lineRFwscIndicator; set => SetField(ref _lineRFwscIndicator, value); }

        /// <summary>
        /// Lowest ARM Rate [NEWHUD.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LowestArmRate { get => _lowestArmRate; set => SetField(ref _lowestArmRate, value); }

        /// <summary>
        /// Mnthly Amt Includes Interest [NEWHUD.X356]
        /// </summary>
        public bool? MonthlyAmountIncludeInterestIndicator { get => _monthlyAmountIncludeInterestIndicator; set => SetField(ref _monthlyAmountIncludeInterestIndicator, value); }

        /// <summary>
        /// Mnthly Amt Includes Mortg Ins [NEWHUD.X357]
        /// </summary>
        public bool? MonthlyAmountIncludeMiIndicator { get => _monthlyAmountIncludeMiIndicator; set => SetField(ref _monthlyAmountIncludeMiIndicator, value); }

        /// <summary>
        /// Mnthly Amt Includes Principal [NEWHUD.X355]
        /// </summary>
        public bool? MonthlyAmountIncludePrincipalIndicator { get => _monthlyAmountIncludePrincipalIndicator; set => SetField(ref _monthlyAmountIncludePrincipalIndicator, value); }

        /// <summary>
        /// HUD-1 Pg 3 Initial Mthly Amt w/Escrow [NEWHUD.X802]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MonthlyAmountWithEscrow { get => _monthlyAmountWithEscrow; set => SetField(ref _monthlyAmountWithEscrow, value); }

        /// <summary>
        /// HUD-1 Pg 3 Mthly Escrow Pymt w/o Mrtg Ins [NEWHUD.X950]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => SetField(ref _monthlyEscrowPayment, value); }

        /// <summary>
        /// New HUD HUD-1 Page 3 Prepaid Interest [NEWHUD.X949]
        /// </summary>
        public decimal? PrepaidInterest { get => _prepaidInterest; set => SetField(ref _prepaidInterest, value); }

        /// <summary>
        /// Total GFE Tolerance Increase Amt [NEWHUD.X314]
        /// </summary>
        public decimal? TotalToleranceIncreaseAmount { get => _totalToleranceIncreaseAmount; set => SetField(ref _totalToleranceIncreaseAmount, value); }
    }
}