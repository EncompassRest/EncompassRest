using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// Gfe2010Page
/// </summary>
public sealed partial class Gfe2010Page : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Years/Months Until Balloon Pymt Due [NEWHUD.X348]
    /// </summary>
    public int? BalloonPaymentDueInYears { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line Fees Line 801 Broker Compensation Borrower Checked [NEWHUD.X672]
    /// </summary>
    public string? BrokerCompensationFwbc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line Fees Line 801 Broker Compensation Seller Checked [NEWHUD.X673]
    /// </summary>
    public string? BrokerCompensationFwsc { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Cured Total GFE Tolerance [NEWHUD.CuredX312]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? CuredGfeTotalTolerance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// First ARM Change Date [NEWHUD.X332]
    /// </summary>
    public DateTime? FirstArmChangeDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Page Gfe2010FwbcFwscs
    /// </summary>
    [AllowNull]
    public IList<Gfe2010FwbcFwsc> Gfe2010FwbcFwscs { get => GetList<Gfe2010FwbcFwsc>(); set => SetList(value); }

    /// <summary>
    /// Gfe2010Page Gfe2010GfeCharges
    /// </summary>
    [AllowNull]
    public IList<Gfe2010GfeCharge> Gfe2010GfeCharges { get => GetList<Gfe2010GfeCharge>(); set => SetList(value); }

    /// <summary>
    /// GFE Gov Recording Chrgs [NEWHUD.X295]
    /// </summary>
    public string? GfeRecordingCharges { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Total GFE Tolerance [NEWHUD.X312]
    /// </summary>
    public decimal? GfeTotalTolerance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Has Escrow Acct [NEWHUD.X335]
    /// </summary>
    public bool? HasEscrowAccountIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-City Prop Taxes [NEWHUD.X1726]
    /// </summary>
    public bool? HasEscrowCityPropertyTaxesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-Flood Ins [NEWHUD.X338]
    /// </summary>
    public bool? HasEscrowFloodInsurancesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-Homeowners Ins [NEWHUD.X339]
    /// </summary>
    public bool? HasEscrowHomeownerInsurancesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-Prop Taxes [NEWHUD.X337]
    /// </summary>
    public bool? HasEscrowPropertyTaxesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-User Defined 1 [NEWHUD.X340]
    /// </summary>
    public bool? HasEscrowUserDefinedIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-User Defined 2 [NEWHUD.X341]
    /// </summary>
    public bool? HasEscrowUserDefinedIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Incl Escrow-User Defined 3 [NEWHUD.X342]
    /// </summary>
    public bool? HasEscrowUserDefinedIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// New HUD-1 Page 3 Include Escrow Annual Fee [NEWHUD.X343]
    /// </summary>
    public bool? HasEscrowUserDefinedIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Highest ARM Rate [NEWHUD.X334]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? HighestArmRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// 10% Tolerance Comp Chart - HUD1 Government Recording Charge [NEWHUD.X336]
    /// </summary>
    public decimal? Hud1GovernmentRecordingCharge { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Seller Total Closing Cost for HUD-1 Pg1 [NEWHUD.X774]
    /// </summary>
    public decimal? Hud1Pg1SellerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Total Closing Cost for HUD-1 Pg1 [NEWHUD.X773]
    /// </summary>
    public decimal? Hud1Pg1TotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Seller Total Closing Costs [NEWHUD.X278]
    /// </summary>
    public decimal? Hud1Pg2SellerPaidClosingCostsAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Total Closing Costs [NEWHUD.X277]
    /// </summary>
    public decimal? Hud1Pg2TotalSettlementCharges { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total HUD Tolerance [NEWHUD.X313]
    /// </summary>
    public decimal? HudTotalTolerance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total GFE Tolerance Increase % [NEWHUD.X315]
    /// </summary>
    public decimal? HudTotalToleranceIncreasePercent { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Page Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1101 Seller Paid Total [NEWHUD.X798]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line1101SellerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1201 Seller Paid Total [NEWHUD.X799]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line1201SellerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1301 Seller Paid Total [NEWHUD.X800]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line1301SellerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 Borrower Paid Total [NEWHUD.X795]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line801BorrowerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 Seller Paid Total [NEWHUD.X794]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line801SellerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 802 Borrower Paid Total [NEWHUD.X797]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line802BorrowerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 803 Borrower Paid Total [NEWHUD.X796]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line803BorrowerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 803 Seller Paid Total [NEWHUD.X801]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Line803SellerPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 820 Funding Worksheet Checkbox for Borrower [NEWHUD.X1486]
    /// </summary>
    public bool? Line818FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 820 Funding Worksheet Checkbox for Seller [NEWHUD.X1509]
    /// </summary>
    public bool? Line818FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 821 Funding Worksheet Checkbox for Borrower [NEWHUD.X1487]
    /// </summary>
    public bool? Line819FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 821 Funding Worksheet Checkbox for Seller [NEWHUD.X1510]
    /// </summary>
    public bool? Line819FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 822 Funding Worksheet Checkbox for Borrower [NEWHUD.X1488]
    /// </summary>
    public bool? Line820FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 822 Funding Worksheet Checkbox for Seller [NEWHUD.X1511]
    /// </summary>
    public bool? Line820FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 823 Funding Worksheet Checkbox for Borrower [NEWHUD.X1489]
    /// </summary>
    public bool? Line821FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 823 Funding Worksheet Checkbox for Seller [NEWHUD.X1512]
    /// </summary>
    public bool? Line821FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 824 Funding Worksheet Checkbox for Borrower [NEWHUD.X1490]
    /// </summary>
    public bool? Line822FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 824 Funding Worksheet Checkbox for Seller [NEWHUD.X1513]
    /// </summary>
    public bool? Line822FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 825 Funding Worksheet Checkbox for Borrower [NEWHUD.X1491]
    /// </summary>
    public bool? Line823FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 825 Funding Worksheet Checkbox for Seller [NEWHUD.X1514]
    /// </summary>
    public bool? Line823FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 826 Funding Worksheet Checkbox for Borrower [NEWHUD.X1492]
    /// </summary>
    public bool? Line824FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 826 Funding Worksheet Checkbox for Seller [NEWHUD.X1515]
    /// </summary>
    public bool? Line824FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 827 Funding Worksheet Checkbox for Borrower [NEWHUD.X1493]
    /// </summary>
    public bool? Line825FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 827 Funding Worksheet Checkbox for Seller [NEWHUD.X1516]
    /// </summary>
    public bool? Line825FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 828 Funding Worksheet Checkbox for Borrower [NEWHUD.X1494]
    /// </summary>
    public bool? Line826FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 828 Funding Worksheet Checkbox for Seller [NEWHUD.X1517]
    /// </summary>
    public bool? Line826FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 829 Funding Worksheet Checkbox for Borrower [NEWHUD.X1495]
    /// </summary>
    public bool? Line827FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 829 Funding Worksheet Checkbox for Seller [NEWHUD.X1518]
    /// </summary>
    public bool? Line827FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 830 Funding Worksheet Checkbox for Borrower [NEWHUD.X1496]
    /// </summary>
    public bool? Line828FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 830 Funding Worksheet Checkbox for Seller [NEWHUD.X1519]
    /// </summary>
    public bool? Line828FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 831 Funding Worksheet Checkbox for Borrower [NEWHUD.X1497]
    /// </summary>
    public bool? Line829FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 831 Funding Worksheet Checkbox for Seller [NEWHUD.X1520]
    /// </summary>
    public bool? Line829FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 832 Funding Worksheet Checkbox for Borrower [NEWHUD.X1498]
    /// </summary>
    public bool? Line830FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 832 Funding Worksheet Checkbox for Seller [NEWHUD.X1521]
    /// </summary>
    public bool? Line830FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 833 Funding Worksheet Checkbox for Borrower [NEWHUD.X1499]
    /// </summary>
    public bool? Line831FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 833 Funding Worksheet Checkbox for Seller [NEWHUD.X1522]
    /// </summary>
    public bool? Line831FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 834 Funding Worksheet Checkbox for Borrower [NEWHUD.X1500]
    /// </summary>
    public bool? Line832FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 834 Funding Worksheet Checkbox for Seller [NEWHUD.X1523]
    /// </summary>
    public bool? Line832FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 835 Funding Worksheet Checkbox for Borrower [NEWHUD.X1501]
    /// </summary>
    public bool? Line833FwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 835 Funding Worksheet Checkbox for Seller [NEWHUD.X1524]
    /// </summary>
    public bool? Line833FwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 L Funding Worksheet Checkbox for Borrower [NEWHUD.X1479]
    /// </summary>
    public bool? LineLFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 L Funding Worksheet Checkbox for Seller [NEWHUD.X1502]
    /// </summary>
    public bool? LineLFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 M Funding Worksheet Checkbox for Borrower [NEWHUD.X1480]
    /// </summary>
    public bool? LineMFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 M Funding Worksheet Checkbox for Seller [NEWHUD.X1503]
    /// </summary>
    public bool? LineMFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 N Funding Worksheet Checkbox for Borrower [NEWHUD.X1481]
    /// </summary>
    public bool? LineNFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 N Funding Worksheet Checkbox for Seller [NEWHUD.X1504]
    /// </summary>
    public bool? LineNFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 O Funding Worksheet Checkbox for Borrower [NEWHUD.X1482]
    /// </summary>
    public bool? LineOFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 O Funding Worksheet Checkbox for Seller [NEWHUD.X1505]
    /// </summary>
    public bool? LineOFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 P Funding Worksheet Checkbox for Borrower [NEWHUD.X1483]
    /// </summary>
    public bool? LinePFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 P Funding Worksheet Checkbox for Seller [NEWHUD.X1506]
    /// </summary>
    public bool? LinePFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 Q Funding Worksheet Checkbox for Borrower [NEWHUD.X1484]
    /// </summary>
    public bool? LineQFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 Q Funding Worksheet Checkbox for Seller [NEWHUD.X1507]
    /// </summary>
    public bool? LineQFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 R Funding Worksheet Checkbox for Borrower [NEWHUD.X1485]
    /// </summary>
    public bool? LineRFwbcIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 801 R Funding Worksheet Checkbox for Seller [NEWHUD.X1508]
    /// </summary>
    public bool? LineRFwscIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Lowest ARM Rate [NEWHUD.X333]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? LowestArmRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Mnthly Amt Includes Interest [NEWHUD.X356]
    /// </summary>
    public bool? MonthlyAmountIncludeInterestIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mnthly Amt Includes Mortg Ins [NEWHUD.X357]
    /// </summary>
    public bool? MonthlyAmountIncludeMiIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Mnthly Amt Includes Principal [NEWHUD.X355]
    /// </summary>
    public bool? MonthlyAmountIncludePrincipalIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1 Pg 3 Initial Mthly Amt w/Escrow [NEWHUD.X802]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyAmountWithEscrow { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// HUD-1 Pg 3 Mthly Escrow Pymt w/o Mrtg Ins [NEWHUD.X950]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? MonthlyEscrowPayment { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// New HUD HUD-1 Page 3 Prepaid Interest [NEWHUD.X949]
    /// </summary>
    public decimal? PrepaidInterest { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total GFE Tolerance Increase Amt [NEWHUD.X314]
    /// </summary>
    public decimal? TotalToleranceIncreaseAmount { get => GetValue<decimal?>(); set => SetValue(value); }
}