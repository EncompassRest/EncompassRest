using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010Page
    /// </summary>
    public sealed partial class Gfe2010Page : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<int?> _balloonPaymentDueInYears;
        /// <summary>
        /// Years Until Balloon Pymt Due [NEWHUD.X348]
        /// </summary>
        [LoanFieldProperty(Description = "Years Until Balloon Pymt Due")]
        public int? BalloonPaymentDueInYears { get => _balloonPaymentDueInYears; set => SetField(ref _balloonPaymentDueInYears, value); }
        private DirtyValue<string> _brokerCompensationFwbc;
        /// <summary>
        /// Fees Line Fees Line 801 Broker Compensation Borrower Checked [NEWHUD.X672]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line Fees Line 801 Broker Compensation Borrower Checked")]
        public string BrokerCompensationFwbc { get => _brokerCompensationFwbc; set => SetField(ref _brokerCompensationFwbc, value); }
        private DirtyValue<string> _brokerCompensationFwsc;
        /// <summary>
        /// Fees Line Fees Line 801 Broker Compensation Seller Checked [NEWHUD.X673]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line Fees Line 801 Broker Compensation Seller Checked")]
        public string BrokerCompensationFwsc { get => _brokerCompensationFwsc; set => SetField(ref _brokerCompensationFwsc, value); }
        private DirtyValue<decimal?> _curedGfeTotalTolerance;
        /// <summary>
        /// Cured Total GFE Tolerance [NEWHUD.CuredX312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured Total GFE Tolerance")]
        public decimal? CuredGfeTotalTolerance { get => _curedGfeTotalTolerance; set => SetField(ref _curedGfeTotalTolerance, value); }
        private DirtyValue<DateTime?> _firstArmChangeDate;
        /// <summary>
        /// First ARM Change Date [NEWHUD.X332]
        /// </summary>
        [LoanFieldProperty(Description = "First ARM Change Date")]
        public DateTime? FirstArmChangeDate { get => _firstArmChangeDate; set => SetField(ref _firstArmChangeDate, value); }
        private DirtyList<Gfe2010FwbcFwsc> _gfe2010FwbcFwscs;
        /// <summary>
        /// Gfe2010Page Gfe2010FwbcFwscs
        /// </summary>
        public IList<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get => GetField(ref _gfe2010FwbcFwscs); set => SetField(ref _gfe2010FwbcFwscs, value); }
        private DirtyList<Gfe2010GfeCharge> _gfe2010GfeCharges;
        /// <summary>
        /// Gfe2010Page Gfe2010GfeCharges
        /// </summary>
        public IList<Gfe2010GfeCharge> Gfe2010GfeCharges { get => GetField(ref _gfe2010GfeCharges); set => SetField(ref _gfe2010GfeCharges, value); }
        private DirtyValue<string> _gfeRecordingCharges;
        /// <summary>
        /// GFE Gov Recording Chrgs [NEWHUD.X295]
        /// </summary>
        [LoanFieldProperty(Description = "GFE Gov Recording Chrgs")]
        public string GfeRecordingCharges { get => _gfeRecordingCharges; set => SetField(ref _gfeRecordingCharges, value); }
        private DirtyValue<decimal?> _gfeTotalTolerance;
        /// <summary>
        /// Total GFE Tolerance [NEWHUD.X312]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total GFE Tolerance")]
        public decimal? GfeTotalTolerance { get => _gfeTotalTolerance; set => SetField(ref _gfeTotalTolerance, value); }
        private DirtyValue<bool?> _hasEscrowAccountIndicator;
        /// <summary>
        /// Has Escrow Acct [NEWHUD.X335]
        /// </summary>
        [LoanFieldProperty(Description = "Has Escrow Acct")]
        public bool? HasEscrowAccountIndicator { get => _hasEscrowAccountIndicator; set => SetField(ref _hasEscrowAccountIndicator, value); }
        private DirtyValue<bool?> _hasEscrowCityPropertyTaxesIndicator;
        /// <summary>
        /// Incl Escrow-City Prop Taxes [NEWHUD.X1726]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-City Prop Taxes")]
        public bool? HasEscrowCityPropertyTaxesIndicator { get => _hasEscrowCityPropertyTaxesIndicator; set => SetField(ref _hasEscrowCityPropertyTaxesIndicator, value); }
        private DirtyValue<bool?> _hasEscrowFloodInsurancesIndicator;
        /// <summary>
        /// Incl Escrow-Flood Ins [NEWHUD.X338]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-Flood Ins")]
        public bool? HasEscrowFloodInsurancesIndicator { get => _hasEscrowFloodInsurancesIndicator; set => SetField(ref _hasEscrowFloodInsurancesIndicator, value); }
        private DirtyValue<bool?> _hasEscrowHomeownerInsurancesIndicator;
        /// <summary>
        /// Incl Escrow-Homeowners Ins [NEWHUD.X339]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-Homeowners Ins")]
        public bool? HasEscrowHomeownerInsurancesIndicator { get => _hasEscrowHomeownerInsurancesIndicator; set => SetField(ref _hasEscrowHomeownerInsurancesIndicator, value); }
        private DirtyValue<bool?> _hasEscrowPropertyTaxesIndicator;
        /// <summary>
        /// Incl Escrow-Prop Taxes [NEWHUD.X337]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-Prop Taxes")]
        public bool? HasEscrowPropertyTaxesIndicator { get => _hasEscrowPropertyTaxesIndicator; set => SetField(ref _hasEscrowPropertyTaxesIndicator, value); }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator1;
        /// <summary>
        /// Incl Escrow-User Defined 1 [NEWHUD.X340]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-User Defined 1")]
        public bool? HasEscrowUserDefinedIndicator1 { get => _hasEscrowUserDefinedIndicator1; set => SetField(ref _hasEscrowUserDefinedIndicator1, value); }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator2;
        /// <summary>
        /// Incl Escrow-User Defined 2 [NEWHUD.X341]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-User Defined 2")]
        public bool? HasEscrowUserDefinedIndicator2 { get => _hasEscrowUserDefinedIndicator2; set => SetField(ref _hasEscrowUserDefinedIndicator2, value); }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator3;
        /// <summary>
        /// Incl Escrow-User Defined 3 [NEWHUD.X342]
        /// </summary>
        [LoanFieldProperty(Description = "Incl Escrow-User Defined 3")]
        public bool? HasEscrowUserDefinedIndicator3 { get => _hasEscrowUserDefinedIndicator3; set => SetField(ref _hasEscrowUserDefinedIndicator3, value); }
        private DirtyValue<bool?> _hasEscrowUserDefinedIndicator4;
        /// <summary>
        /// New HUD-1 Page 3 Include Escrow Annual Fee [NEWHUD.X343]
        /// </summary>
        [LoanFieldProperty(Description = "New HUD-1 Page 3 Include Escrow Annual Fee")]
        public bool? HasEscrowUserDefinedIndicator4 { get => _hasEscrowUserDefinedIndicator4; set => SetField(ref _hasEscrowUserDefinedIndicator4, value); }
        private DirtyValue<decimal?> _highestArmRate;
        /// <summary>
        /// Highest ARM Rate [NEWHUD.X334]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Highest ARM Rate")]
        public decimal? HighestArmRate { get => _highestArmRate; set => SetField(ref _highestArmRate, value); }
        private DirtyValue<decimal?> _hud1GovernmentRecordingCharge;
        /// <summary>
        /// 10% Tolerance Comp Chart - HUD1 Government Recording Charge [NEWHUD.X336]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "10% Tolerance Comp Chart - HUD1 Government Recording Charge")]
        public decimal? Hud1GovernmentRecordingCharge { get => _hud1GovernmentRecordingCharge; set => SetField(ref _hud1GovernmentRecordingCharge, value); }
        private DirtyValue<decimal?> _hud1Pg1SellerPaidClosingCostsAmount;
        /// <summary>
        /// Seller Total Closing Cost for HUD-1 Pg1 [NEWHUD.X774]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Seller Total Closing Cost for HUD-1 Pg1")]
        public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get => _hud1Pg1SellerPaidClosingCostsAmount; set => SetField(ref _hud1Pg1SellerPaidClosingCostsAmount, value); }
        private DirtyValue<decimal?> _hud1Pg1TotalSettlementCharges;
        /// <summary>
        /// Borr Total Closing Cost for HUD-1 Pg1 [NEWHUD.X773]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Total Closing Cost for HUD-1 Pg1")]
        public decimal? Hud1Pg1TotalSettlementCharges { get => _hud1Pg1TotalSettlementCharges; set => SetField(ref _hud1Pg1TotalSettlementCharges, value); }
        private DirtyValue<decimal?> _hud1Pg2SellerPaidClosingCostsAmount;
        /// <summary>
        /// Seller Total Closing Costs [NEWHUD.X278]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Seller Total Closing Costs")]
        public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get => _hud1Pg2SellerPaidClosingCostsAmount; set => SetField(ref _hud1Pg2SellerPaidClosingCostsAmount, value); }
        private DirtyValue<decimal?> _hud1Pg2TotalSettlementCharges;
        /// <summary>
        /// Borr Total Closing Costs [NEWHUD.X277]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Total Closing Costs")]
        public decimal? Hud1Pg2TotalSettlementCharges { get => _hud1Pg2TotalSettlementCharges; set => SetField(ref _hud1Pg2TotalSettlementCharges, value); }
        private DirtyValue<decimal?> _hudTotalTolerance;
        /// <summary>
        /// Total HUD Tolerance [NEWHUD.X313]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total HUD Tolerance")]
        public decimal? HudTotalTolerance { get => _hudTotalTolerance; set => SetField(ref _hudTotalTolerance, value); }
        private DirtyValue<decimal?> _hudTotalToleranceIncreasePercent;
        /// <summary>
        /// Total GFE Tolerance Increase % [NEWHUD.X315]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total GFE Tolerance Increase %")]
        public decimal? HudTotalToleranceIncreasePercent { get => _hudTotalToleranceIncreasePercent; set => SetField(ref _hudTotalToleranceIncreasePercent, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010Page Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _line1101SellerPaidTotal;
        /// <summary>
        /// Fees Line 1101 Seller Paid Total [NEWHUD.X798]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 1101 Seller Paid Total")]
        public decimal? Line1101SellerPaidTotal { get => _line1101SellerPaidTotal; set => SetField(ref _line1101SellerPaidTotal, value); }
        private DirtyValue<decimal?> _line1201SellerPaidTotal;
        /// <summary>
        /// Fees Line 1201 Seller Paid Total [NEWHUD.X799]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 1201 Seller Paid Total")]
        public decimal? Line1201SellerPaidTotal { get => _line1201SellerPaidTotal; set => SetField(ref _line1201SellerPaidTotal, value); }
        private DirtyValue<decimal?> _line1301SellerPaidTotal;
        /// <summary>
        /// Fees Line 1301 Seller Paid Total [NEWHUD.X800]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 1301 Seller Paid Total")]
        public decimal? Line1301SellerPaidTotal { get => _line1301SellerPaidTotal; set => SetField(ref _line1301SellerPaidTotal, value); }
        private DirtyValue<decimal?> _line801BorrowerPaidTotal;
        /// <summary>
        /// Fees Line 801 Borrower Paid Total [NEWHUD.X795]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 801 Borrower Paid Total")]
        public decimal? Line801BorrowerPaidTotal { get => _line801BorrowerPaidTotal; set => SetField(ref _line801BorrowerPaidTotal, value); }
        private DirtyValue<decimal?> _line801SellerPaidTotal;
        /// <summary>
        /// Fees Line 801 Seller Paid Total [NEWHUD.X794]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 801 Seller Paid Total")]
        public decimal? Line801SellerPaidTotal { get => _line801SellerPaidTotal; set => SetField(ref _line801SellerPaidTotal, value); }
        private DirtyValue<decimal?> _line802BorrowerPaidTotal;
        /// <summary>
        /// Fees Line 802 Borrower Paid Total [NEWHUD.X797]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 802 Borrower Paid Total")]
        public decimal? Line802BorrowerPaidTotal { get => _line802BorrowerPaidTotal; set => SetField(ref _line802BorrowerPaidTotal, value); }
        private DirtyValue<decimal?> _line803BorrowerPaidTotal;
        /// <summary>
        /// Fees Line 803 Borrower Paid Total [NEWHUD.X796]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 803 Borrower Paid Total")]
        public decimal? Line803BorrowerPaidTotal { get => _line803BorrowerPaidTotal; set => SetField(ref _line803BorrowerPaidTotal, value); }
        private DirtyValue<decimal?> _line803SellerPaidTotal;
        /// <summary>
        /// Fees Line 803 Seller Paid Total [NEWHUD.X801]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 803 Seller Paid Total")]
        public decimal? Line803SellerPaidTotal { get => _line803SellerPaidTotal; set => SetField(ref _line803SellerPaidTotal, value); }
        private DirtyValue<bool?> _line818FwbcIndicator;
        /// <summary>
        /// Fees Line 820 Funding Worksheet Checkbox for Borrower [NEWHUD.X1486]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 820 Funding Worksheet Checkbox for Borrower")]
        public bool? Line818FwbcIndicator { get => _line818FwbcIndicator; set => SetField(ref _line818FwbcIndicator, value); }
        private DirtyValue<bool?> _line818FwscIndicator;
        /// <summary>
        /// Fees Line 820 Funding Worksheet Checkbox for Seller [NEWHUD.X1509]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 820 Funding Worksheet Checkbox for Seller")]
        public bool? Line818FwscIndicator { get => _line818FwscIndicator; set => SetField(ref _line818FwscIndicator, value); }
        private DirtyValue<bool?> _line819FwbcIndicator;
        /// <summary>
        /// Fees Line 821 Funding Worksheet Checkbox for Borrower [NEWHUD.X1487]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 821 Funding Worksheet Checkbox for Borrower")]
        public bool? Line819FwbcIndicator { get => _line819FwbcIndicator; set => SetField(ref _line819FwbcIndicator, value); }
        private DirtyValue<bool?> _line819FwscIndicator;
        /// <summary>
        /// Fees Line 821 Funding Worksheet Checkbox for Seller [NEWHUD.X1510]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 821 Funding Worksheet Checkbox for Seller")]
        public bool? Line819FwscIndicator { get => _line819FwscIndicator; set => SetField(ref _line819FwscIndicator, value); }
        private DirtyValue<bool?> _line820FwbcIndicator;
        /// <summary>
        /// Fees Line 822 Funding Worksheet Checkbox for Borrower [NEWHUD.X1488]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 822 Funding Worksheet Checkbox for Borrower")]
        public bool? Line820FwbcIndicator { get => _line820FwbcIndicator; set => SetField(ref _line820FwbcIndicator, value); }
        private DirtyValue<bool?> _line820FwscIndicator;
        /// <summary>
        /// Fees Line 822 Funding Worksheet Checkbox for Seller [NEWHUD.X1511]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 822 Funding Worksheet Checkbox for Seller")]
        public bool? Line820FwscIndicator { get => _line820FwscIndicator; set => SetField(ref _line820FwscIndicator, value); }
        private DirtyValue<bool?> _line821FwbcIndicator;
        /// <summary>
        /// Fees Line 823 Funding Worksheet Checkbox for Borrower [NEWHUD.X1489]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 823 Funding Worksheet Checkbox for Borrower")]
        public bool? Line821FwbcIndicator { get => _line821FwbcIndicator; set => SetField(ref _line821FwbcIndicator, value); }
        private DirtyValue<bool?> _line821FwscIndicator;
        /// <summary>
        /// Fees Line 823 Funding Worksheet Checkbox for Seller [NEWHUD.X1512]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 823 Funding Worksheet Checkbox for Seller")]
        public bool? Line821FwscIndicator { get => _line821FwscIndicator; set => SetField(ref _line821FwscIndicator, value); }
        private DirtyValue<bool?> _line822FwbcIndicator;
        /// <summary>
        /// Fees Line 824 Funding Worksheet Checkbox for Borrower [NEWHUD.X1490]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 824 Funding Worksheet Checkbox for Borrower")]
        public bool? Line822FwbcIndicator { get => _line822FwbcIndicator; set => SetField(ref _line822FwbcIndicator, value); }
        private DirtyValue<bool?> _line822FwscIndicator;
        /// <summary>
        /// Fees Line 824 Funding Worksheet Checkbox for Seller [NEWHUD.X1513]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 824 Funding Worksheet Checkbox for Seller")]
        public bool? Line822FwscIndicator { get => _line822FwscIndicator; set => SetField(ref _line822FwscIndicator, value); }
        private DirtyValue<bool?> _line823FwbcIndicator;
        /// <summary>
        /// Fees Line 825 Funding Worksheet Checkbox for Borrower [NEWHUD.X1491]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 825 Funding Worksheet Checkbox for Borrower")]
        public bool? Line823FwbcIndicator { get => _line823FwbcIndicator; set => SetField(ref _line823FwbcIndicator, value); }
        private DirtyValue<bool?> _line823FwscIndicator;
        /// <summary>
        /// Fees Line 825 Funding Worksheet Checkbox for Seller [NEWHUD.X1514]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 825 Funding Worksheet Checkbox for Seller")]
        public bool? Line823FwscIndicator { get => _line823FwscIndicator; set => SetField(ref _line823FwscIndicator, value); }
        private DirtyValue<bool?> _line824FwbcIndicator;
        /// <summary>
        /// Fees Line 826 Funding Worksheet Checkbox for Borrower [NEWHUD.X1492]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 826 Funding Worksheet Checkbox for Borrower")]
        public bool? Line824FwbcIndicator { get => _line824FwbcIndicator; set => SetField(ref _line824FwbcIndicator, value); }
        private DirtyValue<bool?> _line824FwscIndicator;
        /// <summary>
        /// Fees Line 826 Funding Worksheet Checkbox for Seller [NEWHUD.X1515]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 826 Funding Worksheet Checkbox for Seller")]
        public bool? Line824FwscIndicator { get => _line824FwscIndicator; set => SetField(ref _line824FwscIndicator, value); }
        private DirtyValue<bool?> _line825FwbcIndicator;
        /// <summary>
        /// Fees Line 827 Funding Worksheet Checkbox for Borrower [NEWHUD.X1493]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 827 Funding Worksheet Checkbox for Borrower")]
        public bool? Line825FwbcIndicator { get => _line825FwbcIndicator; set => SetField(ref _line825FwbcIndicator, value); }
        private DirtyValue<bool?> _line825FwscIndicator;
        /// <summary>
        /// Fees Line 827 Funding Worksheet Checkbox for Seller [NEWHUD.X1516]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 827 Funding Worksheet Checkbox for Seller")]
        public bool? Line825FwscIndicator { get => _line825FwscIndicator; set => SetField(ref _line825FwscIndicator, value); }
        private DirtyValue<bool?> _line826FwbcIndicator;
        /// <summary>
        /// Fees Line 828 Funding Worksheet Checkbox for Borrower [NEWHUD.X1494]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 828 Funding Worksheet Checkbox for Borrower")]
        public bool? Line826FwbcIndicator { get => _line826FwbcIndicator; set => SetField(ref _line826FwbcIndicator, value); }
        private DirtyValue<bool?> _line826FwscIndicator;
        /// <summary>
        /// Fees Line 828 Funding Worksheet Checkbox for Seller [NEWHUD.X1517]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 828 Funding Worksheet Checkbox for Seller")]
        public bool? Line826FwscIndicator { get => _line826FwscIndicator; set => SetField(ref _line826FwscIndicator, value); }
        private DirtyValue<bool?> _line827FwbcIndicator;
        /// <summary>
        /// Fees Line 829 Funding Worksheet Checkbox for Borrower [NEWHUD.X1495]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 829 Funding Worksheet Checkbox for Borrower")]
        public bool? Line827FwbcIndicator { get => _line827FwbcIndicator; set => SetField(ref _line827FwbcIndicator, value); }
        private DirtyValue<bool?> _line827FwscIndicator;
        /// <summary>
        /// Fees Line 829 Funding Worksheet Checkbox for Seller [NEWHUD.X1518]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 829 Funding Worksheet Checkbox for Seller")]
        public bool? Line827FwscIndicator { get => _line827FwscIndicator; set => SetField(ref _line827FwscIndicator, value); }
        private DirtyValue<bool?> _line828FwbcIndicator;
        /// <summary>
        /// Fees Line 830 Funding Worksheet Checkbox for Borrower [NEWHUD.X1496]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 830 Funding Worksheet Checkbox for Borrower")]
        public bool? Line828FwbcIndicator { get => _line828FwbcIndicator; set => SetField(ref _line828FwbcIndicator, value); }
        private DirtyValue<bool?> _line828FwscIndicator;
        /// <summary>
        /// Fees Line 830 Funding Worksheet Checkbox for Seller [NEWHUD.X1519]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 830 Funding Worksheet Checkbox for Seller")]
        public bool? Line828FwscIndicator { get => _line828FwscIndicator; set => SetField(ref _line828FwscIndicator, value); }
        private DirtyValue<bool?> _line829FwbcIndicator;
        /// <summary>
        /// Fees Line 831 Funding Worksheet Checkbox for Borrower [NEWHUD.X1497]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 831 Funding Worksheet Checkbox for Borrower")]
        public bool? Line829FwbcIndicator { get => _line829FwbcIndicator; set => SetField(ref _line829FwbcIndicator, value); }
        private DirtyValue<bool?> _line829FwscIndicator;
        /// <summary>
        /// Fees Line 831 Funding Worksheet Checkbox for Seller [NEWHUD.X1520]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 831 Funding Worksheet Checkbox for Seller")]
        public bool? Line829FwscIndicator { get => _line829FwscIndicator; set => SetField(ref _line829FwscIndicator, value); }
        private DirtyValue<bool?> _line830FwbcIndicator;
        /// <summary>
        /// Fees Line 832 Funding Worksheet Checkbox for Borrower [NEWHUD.X1498]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 832 Funding Worksheet Checkbox for Borrower")]
        public bool? Line830FwbcIndicator { get => _line830FwbcIndicator; set => SetField(ref _line830FwbcIndicator, value); }
        private DirtyValue<bool?> _line830FwscIndicator;
        /// <summary>
        /// Fees Line 832 Funding Worksheet Checkbox for Seller [NEWHUD.X1521]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 832 Funding Worksheet Checkbox for Seller")]
        public bool? Line830FwscIndicator { get => _line830FwscIndicator; set => SetField(ref _line830FwscIndicator, value); }
        private DirtyValue<bool?> _line831FwbcIndicator;
        /// <summary>
        /// Fees Line 833 Funding Worksheet Checkbox for Borrower [NEWHUD.X1499]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 833 Funding Worksheet Checkbox for Borrower")]
        public bool? Line831FwbcIndicator { get => _line831FwbcIndicator; set => SetField(ref _line831FwbcIndicator, value); }
        private DirtyValue<bool?> _line831FwscIndicator;
        /// <summary>
        /// Fees Line 833 Funding Worksheet Checkbox for Seller [NEWHUD.X1522]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 833 Funding Worksheet Checkbox for Seller")]
        public bool? Line831FwscIndicator { get => _line831FwscIndicator; set => SetField(ref _line831FwscIndicator, value); }
        private DirtyValue<bool?> _line832FwbcIndicator;
        /// <summary>
        /// Fees Line 834 Funding Worksheet Checkbox for Borrower [NEWHUD.X1500]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 834 Funding Worksheet Checkbox for Borrower")]
        public bool? Line832FwbcIndicator { get => _line832FwbcIndicator; set => SetField(ref _line832FwbcIndicator, value); }
        private DirtyValue<bool?> _line832FwscIndicator;
        /// <summary>
        /// Fees Line 834 Funding Worksheet Checkbox for Seller [NEWHUD.X1523]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 834 Funding Worksheet Checkbox for Seller")]
        public bool? Line832FwscIndicator { get => _line832FwscIndicator; set => SetField(ref _line832FwscIndicator, value); }
        private DirtyValue<bool?> _line833FwbcIndicator;
        /// <summary>
        /// Fees Line 835 Funding Worksheet Checkbox for Borrower [NEWHUD.X1501]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 835 Funding Worksheet Checkbox for Borrower")]
        public bool? Line833FwbcIndicator { get => _line833FwbcIndicator; set => SetField(ref _line833FwbcIndicator, value); }
        private DirtyValue<bool?> _line833FwscIndicator;
        /// <summary>
        /// Fees Line 835 Funding Worksheet Checkbox for Seller [NEWHUD.X1524]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 835 Funding Worksheet Checkbox for Seller")]
        public bool? Line833FwscIndicator { get => _line833FwscIndicator; set => SetField(ref _line833FwscIndicator, value); }
        private DirtyValue<bool?> _lineLFwbcIndicator;
        /// <summary>
        /// Fees Line 801 L Funding Worksheet Checkbox for Borrower [NEWHUD.X1479]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 L Funding Worksheet Checkbox for Borrower")]
        public bool? LineLFwbcIndicator { get => _lineLFwbcIndicator; set => SetField(ref _lineLFwbcIndicator, value); }
        private DirtyValue<bool?> _lineLFwscIndicator;
        /// <summary>
        /// Fees Line 801 L Funding Worksheet Checkbox for Seller [NEWHUD.X1502]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 L Funding Worksheet Checkbox for Seller")]
        public bool? LineLFwscIndicator { get => _lineLFwscIndicator; set => SetField(ref _lineLFwscIndicator, value); }
        private DirtyValue<bool?> _lineMFwbcIndicator;
        /// <summary>
        /// Fees Line 801 M Funding Worksheet Checkbox for Borrower [NEWHUD.X1480]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 M Funding Worksheet Checkbox for Borrower")]
        public bool? LineMFwbcIndicator { get => _lineMFwbcIndicator; set => SetField(ref _lineMFwbcIndicator, value); }
        private DirtyValue<bool?> _lineMFwscIndicator;
        /// <summary>
        /// Fees Line 801 M Funding Worksheet Checkbox for Seller [NEWHUD.X1503]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 M Funding Worksheet Checkbox for Seller")]
        public bool? LineMFwscIndicator { get => _lineMFwscIndicator; set => SetField(ref _lineMFwscIndicator, value); }
        private DirtyValue<bool?> _lineNFwbcIndicator;
        /// <summary>
        /// Fees Line 801 N Funding Worksheet Checkbox for Borrower [NEWHUD.X1481]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 N Funding Worksheet Checkbox for Borrower")]
        public bool? LineNFwbcIndicator { get => _lineNFwbcIndicator; set => SetField(ref _lineNFwbcIndicator, value); }
        private DirtyValue<bool?> _lineNFwscIndicator;
        /// <summary>
        /// Fees Line 801 N Funding Worksheet Checkbox for Seller [NEWHUD.X1504]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 N Funding Worksheet Checkbox for Seller")]
        public bool? LineNFwscIndicator { get => _lineNFwscIndicator; set => SetField(ref _lineNFwscIndicator, value); }
        private DirtyValue<bool?> _lineOFwbcIndicator;
        /// <summary>
        /// Fees Line 801 O Funding Worksheet Checkbox for Borrower [NEWHUD.X1482]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 O Funding Worksheet Checkbox for Borrower")]
        public bool? LineOFwbcIndicator { get => _lineOFwbcIndicator; set => SetField(ref _lineOFwbcIndicator, value); }
        private DirtyValue<bool?> _lineOFwscIndicator;
        /// <summary>
        /// Fees Line 801 O Funding Worksheet Checkbox for Seller [NEWHUD.X1505]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 O Funding Worksheet Checkbox for Seller")]
        public bool? LineOFwscIndicator { get => _lineOFwscIndicator; set => SetField(ref _lineOFwscIndicator, value); }
        private DirtyValue<bool?> _linePFwbcIndicator;
        /// <summary>
        /// Fees Line 801 P Funding Worksheet Checkbox for Borrower [NEWHUD.X1483]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 P Funding Worksheet Checkbox for Borrower")]
        public bool? LinePFwbcIndicator { get => _linePFwbcIndicator; set => SetField(ref _linePFwbcIndicator, value); }
        private DirtyValue<bool?> _linePFwscIndicator;
        /// <summary>
        /// Fees Line 801 P Funding Worksheet Checkbox for Seller [NEWHUD.X1506]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 P Funding Worksheet Checkbox for Seller")]
        public bool? LinePFwscIndicator { get => _linePFwscIndicator; set => SetField(ref _linePFwscIndicator, value); }
        private DirtyValue<bool?> _lineQFwbcIndicator;
        /// <summary>
        /// Fees Line 801 Q Funding Worksheet Checkbox for Borrower [NEWHUD.X1484]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 Q Funding Worksheet Checkbox for Borrower")]
        public bool? LineQFwbcIndicator { get => _lineQFwbcIndicator; set => SetField(ref _lineQFwbcIndicator, value); }
        private DirtyValue<bool?> _lineQFwscIndicator;
        /// <summary>
        /// Fees Line 801 Q Funding Worksheet Checkbox for Seller [NEWHUD.X1507]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 Q Funding Worksheet Checkbox for Seller")]
        public bool? LineQFwscIndicator { get => _lineQFwscIndicator; set => SetField(ref _lineQFwscIndicator, value); }
        private DirtyValue<bool?> _lineRFwbcIndicator;
        /// <summary>
        /// Fees Line 801 R Funding Worksheet Checkbox for Borrower [NEWHUD.X1485]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 R Funding Worksheet Checkbox for Borrower")]
        public bool? LineRFwbcIndicator { get => _lineRFwbcIndicator; set => SetField(ref _lineRFwbcIndicator, value); }
        private DirtyValue<bool?> _lineRFwscIndicator;
        /// <summary>
        /// Fees Line 801 R Funding Worksheet Checkbox for Seller [NEWHUD.X1508]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 R Funding Worksheet Checkbox for Seller")]
        public bool? LineRFwscIndicator { get => _lineRFwscIndicator; set => SetField(ref _lineRFwscIndicator, value); }
        private DirtyValue<decimal?> _lowestArmRate;
        /// <summary>
        /// Lowest ARM Rate [NEWHUD.X333]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lowest ARM Rate")]
        public decimal? LowestArmRate { get => _lowestArmRate; set => SetField(ref _lowestArmRate, value); }
        private DirtyValue<bool?> _monthlyAmountIncludeInterestIndicator;
        /// <summary>
        /// Mnthly Amt Includes Interest [NEWHUD.X356]
        /// </summary>
        [LoanFieldProperty(Description = "Mnthly Amt Includes Interest")]
        public bool? MonthlyAmountIncludeInterestIndicator { get => _monthlyAmountIncludeInterestIndicator; set => SetField(ref _monthlyAmountIncludeInterestIndicator, value); }
        private DirtyValue<bool?> _monthlyAmountIncludeMiIndicator;
        /// <summary>
        /// Mnthly Amt Includes Mortg Ins [NEWHUD.X357]
        /// </summary>
        [LoanFieldProperty(Description = "Mnthly Amt Includes Mortg Ins")]
        public bool? MonthlyAmountIncludeMiIndicator { get => _monthlyAmountIncludeMiIndicator; set => SetField(ref _monthlyAmountIncludeMiIndicator, value); }
        private DirtyValue<bool?> _monthlyAmountIncludePrincipalIndicator;
        /// <summary>
        /// Mnthly Amt Includes Principal [NEWHUD.X355]
        /// </summary>
        [LoanFieldProperty(Description = "Mnthly Amt Includes Principal")]
        public bool? MonthlyAmountIncludePrincipalIndicator { get => _monthlyAmountIncludePrincipalIndicator; set => SetField(ref _monthlyAmountIncludePrincipalIndicator, value); }
        private DirtyValue<decimal?> _monthlyAmountWithEscrow;
        /// <summary>
        /// HUD-1 Pg 3 Initial Mthly Amt w/Escrow [NEWHUD.X802]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD-1 Pg 3 Initial Mthly Amt w/Escrow")]
        public decimal? MonthlyAmountWithEscrow { get => _monthlyAmountWithEscrow; set => SetField(ref _monthlyAmountWithEscrow, value); }
        private DirtyValue<decimal?> _monthlyEscrowPayment;
        /// <summary>
        /// HUD-1 Pg 3 Mthly Escrow Pymt w/o Mrtg Ins [NEWHUD.X950]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "HUD-1 Pg 3 Mthly Escrow Pymt w/o Mrtg Ins")]
        public decimal? MonthlyEscrowPayment { get => _monthlyEscrowPayment; set => SetField(ref _monthlyEscrowPayment, value); }
        private DirtyValue<decimal?> _prepaidInterest;
        /// <summary>
        /// New HUD HUD-1 Page 3 Prepaid Interest [NEWHUD.X949]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "New HUD HUD-1 Page 3 Prepaid Interest")]
        public decimal? PrepaidInterest { get => _prepaidInterest; set => SetField(ref _prepaidInterest, value); }
        private DirtyValue<decimal?> _totalToleranceIncreaseAmount;
        /// <summary>
        /// Total GFE Tolerance Increase Amt [NEWHUD.X314]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total GFE Tolerance Increase Amt")]
        public decimal? TotalToleranceIncreaseAmount { get => _totalToleranceIncreaseAmount; set => SetField(ref _totalToleranceIncreaseAmount, value); }
    }
}