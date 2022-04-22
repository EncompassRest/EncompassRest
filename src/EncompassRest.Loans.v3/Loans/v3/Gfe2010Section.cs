using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Gfe2010Section
/// </summary>
public sealed partial class Gfe2010Section : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Fees Line 903 Borr Select [NEWHUD.X651]
    /// </summary>
    public bool? BorrowerSelectIndicator903 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 904 Borr Select [NEWHUD.X597]
    /// </summary>
    public bool? BorrowerSelectIndicator904 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 906 Borr Select [NEWHUD.X598]
    /// </summary>
    public bool? BorrowerSelectIndicator906 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 907 Borr Select [NEWHUD.X599]
    /// </summary>
    public bool? BorrowerSelectIndicator907 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 908 Borr Select [NEWHUD.X600]
    /// </summary>
    public bool? BorrowerSelectIndicator908 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 909 Borr Select [NEWHUD.X601]
    /// </summary>
    public bool? BorrowerSelectIndicator909 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 910 Borr Select [NEWHUD.X602]
    /// </summary>
    public bool? BorrowerSelectIndicator910 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1109 Applied to GFE [NEWHUD.X565]
    /// </summary>
    public decimal? HudGfeLine1109 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1110 Applied to GFE [NEWHUD.X566]
    /// </summary>
    public decimal? HudGfeLine1110 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1111 Applied to GFE [NEWHUD.X567]
    /// </summary>
    public decimal? HudGfeLine1111 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1112 Applied to GFE [NEWHUD.X568]
    /// </summary>
    public decimal? HudGfeLine1112 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1113 Applied to GFE [NEWHUD.X569]
    /// </summary>
    public decimal? HudGfeLine1113 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1114 Applied to GFE [NEWHUD.X570]
    /// </summary>
    public decimal? HudGfeLine1114 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1001
    /// </summary>
    public string? Line1001 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fees Line 1001 for HUD-1 Page 2 [NEWHUD.X1716]
    /// </summary>
    public decimal? Line1001BorPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1002
    /// </summary>
    public string? Line1002 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1003
    /// </summary>
    public string? Line1003 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1004
    /// </summary>
    public string? Line1004 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1005
    /// </summary>
    public string? Line1005 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1006
    /// </summary>
    public string? Line1006 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1007
    /// </summary>
    public string? Line1007 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1008
    /// </summary>
    public string? Line1008 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1009
    /// </summary>
    public string? Line1009 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1010
    /// </summary>
    public string? Line1010 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line1011
    /// </summary>
    public string? Line1011 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Title Serv &amp; Lender Title Ins Provider [NEWHUD.X202]
    /// </summary>
    public string? Line1101 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X775]
    /// </summary>
    public decimal? Line1101BorPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Seller Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X708]
    /// </summary>
    public decimal? Line1101SellerPaidAtoF { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Sttlmnt or Closing Fee Provider [NEWHUD.X203]
    /// </summary>
    public string? Line1102 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Owner Title Ins Provider [NEWHUD.X204]
    /// </summary>
    public string? Line1103 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Owner's Title Insurance Paid To Affiliate Amount [NEWHUD.X1724]
    /// </summary>
    public decimal? Line1103PtaAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Lender Title Ins Provider [NEWHUD.X205]
    /// </summary>
    public string? Line1104 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Lender's Title Insurance Paid To Affiliate Amount [NEWHUD.X1725]
    /// </summary>
    public decimal? Line1104PtaAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Total Title Ins Prem - Recipient Agent Portion [NEWHUD.X206]
    /// </summary>
    public string? Line1107 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Total Title Ins Prem - Recipient Underwiter Portion [NEWHUD.X207]
    /// </summary>
    public string? Line1108 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1109 Descr [NEWHUD.X208]
    /// </summary>
    public string? Line1109 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1110 Descr [NEWHUD.X209]
    /// </summary>
    public string? Line1110 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1115 Descr [NEWHUD.X1602]
    /// </summary>
    public string? Line1115 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1116 Descr [NEWHUD.X1610]
    /// </summary>
    public string? Line1116 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fees Line 1201 for HUD-1 Page 2 [NEWHUD.X776]
    /// </summary>
    public decimal? Line1201BorPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1209 Descr [NEWHUD.X1618]
    /// </summary>
    public string? Line1209 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1210 Descr [NEWHUD.X1625]
    /// </summary>
    public string? Line1210 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Borr Fees Line 1301 for HUD-1 Page 2 [NEWHUD.X777]
    /// </summary>
    public decimal? Line1301BorPaidTotal { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1302 Descr [NEWHUD.X251]
    /// </summary>
    public string? Line1302 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1310 Descr [NEWHUD.X252]
    /// </summary>
    public string? Line1310 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1311 Descr [NEWHUD.X253]
    /// </summary>
    public string? Line1311 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1312 Descr [NEWHUD.X1632]
    /// </summary>
    public string? Line1312 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1313 Descr [NEWHUD.X1640]
    /// </summary>
    public string? Line1313 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1314 Descr [NEWHUD.X1648]
    /// </summary>
    public string? Line1314 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1315 Descr [NEWHUD.X1656]
    /// </summary>
    public string? Line1315 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1316 Descr [NEWHUD2.X4610]
    /// </summary>
    public string? Line1316 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1317 Descr [NEWHUD2.X4617]
    /// </summary>
    public string? Line1317 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1318 Descr [NEWHUD2.X4624]
    /// </summary>
    public string? Line1318 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1319 Descr [NEWHUD2.X4631]
    /// </summary>
    public string? Line1319 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1320 Descr [NEWHUD2.X4638]
    /// </summary>
    public string? Line1320 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line701
    /// </summary>
    public string? Line701 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line702
    /// </summary>
    public string? Line702 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line703
    /// </summary>
    public string? Line703 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Line704
    /// </summary>
    public string? Line704 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 803 Description [NEWHUD2.X7]
    /// </summary>
    public string? Line803x { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Flood Certification To [NEWHUD.X399]
    /// </summary>
    public string? Line807Company { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 808 Descr [NEWHUD.X126]
    /// </summary>
    public string? Line808 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 809 Descr [NEWHUD.X127]
    /// </summary>
    public string? Line809 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 810 Descr [NEWHUD.X128]
    /// </summary>
    public string? Line810 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 811 Descr [NEWHUD.X129]
    /// </summary>
    public string? Line811 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 812 Descr [NEWHUD.X130]
    /// </summary>
    public string? Line812 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 835 Descr [NEWHUD.X656]
    /// </summary>
    public string? Line819 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 818 Descr [NEWHUD.X1291]
    /// </summary>
    public string? Line820 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 819 Descr [NEWHUD.X1299]
    /// </summary>
    public string? Line821 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 820 Descr [NEWHUD.X1307]
    /// </summary>
    public string? Line822 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 821 Descr [NEWHUD.X1315]
    /// </summary>
    public string? Line823 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 822 Descr [NEWHUD.X1323]
    /// </summary>
    public string? Line824 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 823 Descr [NEWHUD.X1331]
    /// </summary>
    public string? Line825 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 824 Descr [NEWHUD.X1339]
    /// </summary>
    public string? Line826 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 825 Descr [NEWHUD.X1347]
    /// </summary>
    public string? Line827 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 826 Descr [NEWHUD.X1355]
    /// </summary>
    public string? Line828 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 827 Descr [NEWHUD.X1363]
    /// </summary>
    public string? Line829 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 828 Descr [NEWHUD.X1371]
    /// </summary>
    public string? Line830 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 829 Descr [NEWHUD.X1379]
    /// </summary>
    public string? Line831 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 830 Descr [NEWHUD.X1387]
    /// </summary>
    public string? Line832 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 831 Descr [NEWHUD.X1395]
    /// </summary>
    public string? Line833 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 832 Descr [NEWHUD.X1403]
    /// </summary>
    public string? Line834 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 833 Descr [NEWHUD.X1411]
    /// </summary>
    public string? Line835 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 904 User Def Fee Descr [NEWHUD.X582]
    /// </summary>
    public string? Line904 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 909 User Def Fee Descr [NEWHUD.X583]
    /// </summary>
    public string? Line909 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 910 User Def Fee Descr [NEWHUD.X584]
    /// </summary>
    public string? Line910 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 911 Descr [NEWHUD.X1586]
    /// </summary>
    public string? Line911 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 912 Descr [NEWHUD.X1594]
    /// </summary>
    public string? Line912 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line PC1 Descr [NEWHUD2.X4660]
    /// </summary>
    public string? LinePc1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line PC2 Descr [NEWHUD2.X4683]
    /// </summary>
    public string? LinePc2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line PC3 Descr [NEWHUD2.X4706]
    /// </summary>
    public string? LinePc3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line PC4 Descr [NEWHUD2.X4729]
    /// </summary>
    public string? LinePc4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Loan Term Table Is Customized [LOANTERMTABLE.CUSTOMIZE]
    /// </summary>
    public bool? LoanTermTableCustomized { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Fees on Line 802 [NEWHUD.X1140]
    /// </summary>
    public bool? LoCompensationItemizeFeesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Total Credit for Rate Chosen [NEWHUD.X1149]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationLenderTotalPaidOriginatorAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForGfe
    /// </summary>
    public decimal? LoCompensationLenderTotalPaidOriginatorAmountForGfe { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForLoTool
    /// </summary>
    public decimal? LoCompensationLenderTotalPaidOriginatorAmountForLoTool { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - GFE -Total Lender Paid Originator Compensation [NEWHUD.X1206]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationNewHudLenderTotalPaidOriginatorAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - GFE -Total Borrower Paid Discount Point Amount [NEWHUD.X1215]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationNewHudTotalBorrowerPaidDiscountPointAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - GFE -Total Origination or Discount Points [NEWHUD.X1216]
    /// </summary>
    public decimal? LoCompensationNewHudTotalLoCompensationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - TotalBorrower Paid Discount Point Amount Line 4 [NEWHUD.X1165]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationTotalBorrowerPaidDiscountPointAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - Total Origination or Discount Points [NEWHUD.X1191]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationTotalLoCompensationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// LO Compensation - Total Seller Paid Discount Point Amount Line 4 [NEWHUD.X1166]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? LoCompensationTotalSellerPaidDiscountPointAmount4 { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Fees on Line 802 Use LO Compensation Tool [NEWHUD.X1139]
    /// </summary>
    public bool? LoCompensationUseLoCompensationToolIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Projected Payment Table number of columns [NEWHUD2.XPJTCOLUMNS]
    /// </summary>
    public string? ProjectedPaymentTableColumns { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Projected Payment Table Is Customized [PAYMENTTABLE.CUSTOMIZE]
    /// </summary>
    public bool? ProjectedPaymentTableCustomized { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Projected Payment Table [NEWHUD2.XPJT]
    /// </summary>
    public string? ProjectedPaymentTableType { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1010 Aggregate Adjust Applied to GFE [NEWHUD.X948]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Section1000AggregateAdjust { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1010 Guarantee Fee APR [NEWHUD.X1711]
    /// </summary>
    public bool? Section1000HudGuaranteeFeeAprIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1104 Borr Selects [NEWHUD.X573]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator1 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1102 Borr Select [NEWHUD.X646]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator10 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1107 Borr Selects [NEWHUD.X574]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator2 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1108 Borr Selects [NEWHUD.X575]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator3 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1109 Borr Selects [NEWHUD.X576]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator4 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1110 Borr Selects [NEWHUD.X577]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator5 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1111 Borr Selects [NEWHUD.X578]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator6 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1112 Borr Selects [NEWHUD.X579]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator7 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1113 Borr Selects [NEWHUD.X580]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator8 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 1114 Borr Selects [NEWHUD.X581]
    /// </summary>
    public bool? Section1100BorrowerSelectIndicator9 { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Fees on Line 1101 [NEWHUD.X1017]
    /// </summary>
    public bool? Section1100ItemizeFeesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Tax Total for HUD-1 Page 2 [NEWHUD.X778]
    /// </summary>
    public decimal? Section1200TotalTransferTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Bona Fide Indicator [NEWHUD.X1067]
    /// </summary>
    public bool? Section800BonaFideIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Borrower Paid Initial Discount Point Amount [NEWHUD.X1723]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? Section800BorrowerPaidInitialDiscountPointAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Gfe2010Section Section800ChargeAmount [NEWHUD.X15], [NEWHUD.X717]
    /// </summary>
    public decimal? Section800ChargeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Include Points/Credit in Orig Chrg [NEWHUD.X713]
    /// </summary>
    public StringEnumValue<CreditChargeType> Section800CreditChargeType { get => GetValue<StringEnumValue<CreditChargeType>>(); set => SetValue(value); }

    /// <summary>
    /// Borr Receives Credit/Pays Fee [NEWHUD.X715]
    /// </summary>
    public StringEnumValue<IncludeOriginationPointsCreditType> Section800IncludeOriginationPointsCreditType { get => GetValue<StringEnumValue<IncludeOriginationPointsCreditType>>(); set => SetValue(value); }

    /// <summary>
    /// Fees Initial Discount Point [NEWHUD.X1721]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Section800InitialDiscountPoint { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Initial Discount Point Additional Amount [NEWHUD.X1722]
    /// </summary>
    public decimal? Section800InitialDiscountPointAdditionalAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Initial Discount Rate [NEWHUD.X1720]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
    public decimal? Section800InitialDiscountRate { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Itemize Fees on Line 801 [NEWHUD.X750]
    /// </summary>
    public bool? Section800ItemizeFeesIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 802 Orig Charge Amt Seller [NEWHUD.X788]
    /// </summary>
    public decimal? Section800SelChargeAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Trans Tax Total HUD-1 P3 [NEWHUD.X700]
    /// </summary>
    public decimal? Section800TotalTransferTaxes { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// New HUD Homeowner Ins Total Amt [NEWHUD.X723]
    /// </summary>
    public decimal? Section900HomeownerInsurance { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Fees Line 905 Fee Applied to GFE [NEWHUD.X661]
    /// </summary>
    public decimal? Section900HudGfeVaFundingFee { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Projected Payment Table - Use Actual Payment Change [PAYMENTTABLE.USEACTUALPAYMENTCHANGE]
    /// </summary>
    public bool? UseActualPaymentChange { get => GetValue<bool?>(); set => SetValue(value); }
}