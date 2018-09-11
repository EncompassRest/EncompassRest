using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010Section
    /// </summary>
    public sealed partial class Gfe2010Section : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _borrowerSelectIndicator903;
        /// <summary>
        /// Fees Line 903 Borr Select [NEWHUD.X651]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 903 Borr Select")]
        public bool? BorrowerSelectIndicator903 { get => _borrowerSelectIndicator903; set => SetField(ref _borrowerSelectIndicator903, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator904;
        /// <summary>
        /// Fees Line 904 Borr Select [NEWHUD.X597]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 904 Borr Select")]
        public bool? BorrowerSelectIndicator904 { get => _borrowerSelectIndicator904; set => SetField(ref _borrowerSelectIndicator904, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator906;
        /// <summary>
        /// Fees Line 906 Borr Select [NEWHUD.X598]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 906 Borr Select")]
        public bool? BorrowerSelectIndicator906 { get => _borrowerSelectIndicator906; set => SetField(ref _borrowerSelectIndicator906, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator907;
        /// <summary>
        /// Fees Line 907 Borr Select [NEWHUD.X599]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 907 Borr Select")]
        public bool? BorrowerSelectIndicator907 { get => _borrowerSelectIndicator907; set => SetField(ref _borrowerSelectIndicator907, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator908;
        /// <summary>
        /// Fees Line 908 Borr Select [NEWHUD.X600]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 908 Borr Select")]
        public bool? BorrowerSelectIndicator908 { get => _borrowerSelectIndicator908; set => SetField(ref _borrowerSelectIndicator908, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator909;
        /// <summary>
        /// Fees Line 909 Borr Select [NEWHUD.X601]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 909 Borr Select")]
        public bool? BorrowerSelectIndicator909 { get => _borrowerSelectIndicator909; set => SetField(ref _borrowerSelectIndicator909, value); }
        private DirtyValue<bool?> _borrowerSelectIndicator910;
        /// <summary>
        /// Fees Line 910 Borr Select [NEWHUD.X602]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 910 Borr Select")]
        public bool? BorrowerSelectIndicator910 { get => _borrowerSelectIndicator910; set => SetField(ref _borrowerSelectIndicator910, value); }
        private DirtyValue<decimal?> _hudGfeLine1109;
        /// <summary>
        /// Fees Line 1109 Applied to GFE [NEWHUD.X565]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1109 Applied to GFE")]
        public decimal? HudGfeLine1109 { get => _hudGfeLine1109; set => SetField(ref _hudGfeLine1109, value); }
        private DirtyValue<decimal?> _hudGfeLine1110;
        /// <summary>
        /// Fees Line 1110 Applied to GFE [NEWHUD.X566]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1110 Applied to GFE")]
        public decimal? HudGfeLine1110 { get => _hudGfeLine1110; set => SetField(ref _hudGfeLine1110, value); }
        private DirtyValue<decimal?> _hudGfeLine1111;
        /// <summary>
        /// Fees Line 1111 Applied to GFE [NEWHUD.X567]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1111 Applied to GFE")]
        public decimal? HudGfeLine1111 { get => _hudGfeLine1111; set => SetField(ref _hudGfeLine1111, value); }
        private DirtyValue<decimal?> _hudGfeLine1112;
        /// <summary>
        /// Fees Line 1112 Applied to GFE [NEWHUD.X568]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1112 Applied to GFE")]
        public decimal? HudGfeLine1112 { get => _hudGfeLine1112; set => SetField(ref _hudGfeLine1112, value); }
        private DirtyValue<decimal?> _hudGfeLine1113;
        /// <summary>
        /// Fees Line 1113 Applied to GFE [NEWHUD.X569]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1113 Applied to GFE")]
        public decimal? HudGfeLine1113 { get => _hudGfeLine1113; set => SetField(ref _hudGfeLine1113, value); }
        private DirtyValue<decimal?> _hudGfeLine1114;
        /// <summary>
        /// Fees Line 1114 Applied to GFE [NEWHUD.X570]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1114 Applied to GFE")]
        public decimal? HudGfeLine1114 { get => _hudGfeLine1114; set => SetField(ref _hudGfeLine1114, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010Section Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<string> _line1001;
        /// <summary>
        /// Gfe2010Section Line1001
        /// </summary>
        public string Line1001 { get => _line1001; set => SetField(ref _line1001, value); }
        private DirtyValue<decimal?> _line1001BorPaidTotal;
        /// <summary>
        /// Borr Fees Line 1001 for HUD-1 Page 2 [NEWHUD.X1716]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Fees Line 1001 for HUD-1 Page 2")]
        public decimal? Line1001BorPaidTotal { get => _line1001BorPaidTotal; set => SetField(ref _line1001BorPaidTotal, value); }
        private DirtyValue<string> _line1002;
        /// <summary>
        /// Gfe2010Section Line1002
        /// </summary>
        public string Line1002 { get => _line1002; set => SetField(ref _line1002, value); }
        private DirtyValue<string> _line1003;
        /// <summary>
        /// Gfe2010Section Line1003
        /// </summary>
        public string Line1003 { get => _line1003; set => SetField(ref _line1003, value); }
        private DirtyValue<string> _line1004;
        /// <summary>
        /// Gfe2010Section Line1004
        /// </summary>
        public string Line1004 { get => _line1004; set => SetField(ref _line1004, value); }
        private DirtyValue<string> _line1005;
        /// <summary>
        /// Gfe2010Section Line1005
        /// </summary>
        public string Line1005 { get => _line1005; set => SetField(ref _line1005, value); }
        private DirtyValue<string> _line1006;
        /// <summary>
        /// Gfe2010Section Line1006
        /// </summary>
        public string Line1006 { get => _line1006; set => SetField(ref _line1006, value); }
        private DirtyValue<string> _line1007;
        /// <summary>
        /// Gfe2010Section Line1007
        /// </summary>
        public string Line1007 { get => _line1007; set => SetField(ref _line1007, value); }
        private DirtyValue<string> _line1008;
        /// <summary>
        /// Gfe2010Section Line1008
        /// </summary>
        public string Line1008 { get => _line1008; set => SetField(ref _line1008, value); }
        private DirtyValue<string> _line1009;
        /// <summary>
        /// Gfe2010Section Line1009
        /// </summary>
        public string Line1009 { get => _line1009; set => SetField(ref _line1009, value); }
        private DirtyValue<string> _line1010;
        /// <summary>
        /// Gfe2010Section Line1010
        /// </summary>
        public string Line1010 { get => _line1010; set => SetField(ref _line1010, value); }
        private DirtyValue<string> _line1011;
        /// <summary>
        /// Gfe2010Section Line1011
        /// </summary>
        public string Line1011 { get => _line1011; set => SetField(ref _line1011, value); }
        private DirtyValue<string> _line1101;
        /// <summary>
        /// Title Serv &amp; Lender Title Ins Provider [NEWHUD.X202]
        /// </summary>
        [LoanFieldProperty(Description = "Title Serv & Lender Title Ins Provider")]
        public string Line1101 { get => _line1101; set => SetField(ref _line1101, value); }
        private DirtyValue<decimal?> _line1101BorPaidTotal;
        /// <summary>
        /// Borr Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Fees Line 1101 for HUD-1 Page 2")]
        public decimal? Line1101BorPaidTotal { get => _line1101BorPaidTotal; set => SetField(ref _line1101BorPaidTotal, value); }
        private DirtyValue<decimal?> _line1101SellerPaidAtoF;
        /// <summary>
        /// Seller Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X708]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Seller Fees Line 1101 for HUD-1 Page 2")]
        public decimal? Line1101SellerPaidAtoF { get => _line1101SellerPaidAtoF; set => SetField(ref _line1101SellerPaidAtoF, value); }
        private DirtyValue<string> _line1102;
        /// <summary>
        /// Sttlmnt or Closing Fee Provider [NEWHUD.X203]
        /// </summary>
        [LoanFieldProperty(Description = "Sttlmnt or Closing Fee Provider")]
        public string Line1102 { get => _line1102; set => SetField(ref _line1102, value); }
        private DirtyValue<string> _line1103;
        /// <summary>
        /// Owner Title Ins Provider [NEWHUD.X204]
        /// </summary>
        [LoanFieldProperty(Description = "Owner Title Ins Provider")]
        public string Line1103 { get => _line1103; set => SetField(ref _line1103, value); }
        private DirtyValue<decimal?> _line1103PTAAmount;
        /// <summary>
        /// Owner's Title Insurance Paid To Affiliate Amount [NEWHUD.X1724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Owner's Title Insurance Paid To Affiliate Amount")]
        public decimal? Line1103PTAAmount { get => _line1103PTAAmount; set => SetField(ref _line1103PTAAmount, value); }
        private DirtyValue<string> _line1104;
        /// <summary>
        /// Lender Title Ins Provider [NEWHUD.X205]
        /// </summary>
        [LoanFieldProperty(Description = "Lender Title Ins Provider")]
        public string Line1104 { get => _line1104; set => SetField(ref _line1104, value); }
        private DirtyValue<decimal?> _line1104PTAAmount;
        /// <summary>
        /// Lender's Title Insurance Paid To Affiliate Amount [NEWHUD.X1725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lender's Title Insurance Paid To Affiliate Amount")]
        public decimal? Line1104PTAAmount { get => _line1104PTAAmount; set => SetField(ref _line1104PTAAmount, value); }
        private DirtyValue<string> _line1107;
        /// <summary>
        /// Total Title Ins Prem - Recipient Agent Portion [NEWHUD.X206]
        /// </summary>
        [LoanFieldProperty(Description = "Total Title Ins Prem - Recipient Agent Portion")]
        public string Line1107 { get => _line1107; set => SetField(ref _line1107, value); }
        private DirtyValue<string> _line1108;
        /// <summary>
        /// Total Title Ins Prem - Recipient Underwiter Portion [NEWHUD.X207]
        /// </summary>
        [LoanFieldProperty(Description = "Total Title Ins Prem - Recipient Underwiter Portion")]
        public string Line1108 { get => _line1108; set => SetField(ref _line1108, value); }
        private DirtyValue<string> _line1109;
        /// <summary>
        /// Fees Line 1109 Descr [NEWHUD.X208]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1109 Descr")]
        public string Line1109 { get => _line1109; set => SetField(ref _line1109, value); }
        private DirtyValue<string> _line1110;
        /// <summary>
        /// Fees Line 1110 Descr [NEWHUD.X209]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1110 Descr")]
        public string Line1110 { get => _line1110; set => SetField(ref _line1110, value); }
        private DirtyValue<string> _line1115;
        /// <summary>
        /// Fees Line 1115 Descr [NEWHUD.X1602]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1115 Descr")]
        public string Line1115 { get => _line1115; set => SetField(ref _line1115, value); }
        private DirtyValue<string> _line1116;
        /// <summary>
        /// Fees Line 1116 Descr [NEWHUD.X1610]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1116 Descr")]
        public string Line1116 { get => _line1116; set => SetField(ref _line1116, value); }
        private DirtyValue<decimal?> _line1201BorPaidTotal;
        /// <summary>
        /// Borr Fees Line 1201 for HUD-1 Page 2 [NEWHUD.X776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Fees Line 1201 for HUD-1 Page 2")]
        public decimal? Line1201BorPaidTotal { get => _line1201BorPaidTotal; set => SetField(ref _line1201BorPaidTotal, value); }
        private DirtyValue<string> _line1209;
        /// <summary>
        /// Fees Line 1209 Descr [NEWHUD.X1618]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1209 Descr")]
        public string Line1209 { get => _line1209; set => SetField(ref _line1209, value); }
        private DirtyValue<string> _line1210;
        /// <summary>
        /// Fees Line 1210 Descr [NEWHUD.X1625]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1210 Descr")]
        public string Line1210 { get => _line1210; set => SetField(ref _line1210, value); }
        private DirtyValue<decimal?> _line1301BorPaidTotal;
        /// <summary>
        /// Borr Fees Line 1301 for HUD-1 Page 2 [NEWHUD.X777]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Fees Line 1301 for HUD-1 Page 2")]
        public decimal? Line1301BorPaidTotal { get => _line1301BorPaidTotal; set => SetField(ref _line1301BorPaidTotal, value); }
        private DirtyValue<string> _line1302;
        /// <summary>
        /// Fees Line 1302 Descr [NEWHUD.X251]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1302 Descr")]
        public string Line1302 { get => _line1302; set => SetField(ref _line1302, value); }
        private DirtyValue<string> _line1310;
        /// <summary>
        /// Fees Line 1310 Descr [NEWHUD.X252]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1310 Descr")]
        public string Line1310 { get => _line1310; set => SetField(ref _line1310, value); }
        private DirtyValue<string> _line1311;
        /// <summary>
        /// Fees Line 1311 Descr [NEWHUD.X253]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1311 Descr")]
        public string Line1311 { get => _line1311; set => SetField(ref _line1311, value); }
        private DirtyValue<string> _line1312;
        /// <summary>
        /// Fees Line 1312 Descr [NEWHUD.X1632]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1312 Descr")]
        public string Line1312 { get => _line1312; set => SetField(ref _line1312, value); }
        private DirtyValue<string> _line1313;
        /// <summary>
        /// Fees Line 1313 Descr [NEWHUD.X1640]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1313 Descr")]
        public string Line1313 { get => _line1313; set => SetField(ref _line1313, value); }
        private DirtyValue<string> _line1314;
        /// <summary>
        /// Fees Line 1314 Descr [NEWHUD.X1648]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1314 Descr")]
        public string Line1314 { get => _line1314; set => SetField(ref _line1314, value); }
        private DirtyValue<string> _line1315;
        /// <summary>
        /// Fees Line 1315 Descr [NEWHUD.X1656]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1315 Descr")]
        public string Line1315 { get => _line1315; set => SetField(ref _line1315, value); }
        private DirtyValue<string> _line1316;
        /// <summary>
        /// Fees Line 1316 Descr [NEWHUD2.X4610]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1316 Descr")]
        public string Line1316 { get => _line1316; set => SetField(ref _line1316, value); }
        private DirtyValue<string> _line1317;
        /// <summary>
        /// Fees Line 1317 Descr [NEWHUD2.X4617]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1317 Descr")]
        public string Line1317 { get => _line1317; set => SetField(ref _line1317, value); }
        private DirtyValue<string> _line1318;
        /// <summary>
        /// Fees Line 1318 Descr [NEWHUD2.X4624]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1318 Descr")]
        public string Line1318 { get => _line1318; set => SetField(ref _line1318, value); }
        private DirtyValue<string> _line1319;
        /// <summary>
        /// Fees Line 1319 Descr [NEWHUD2.X4631]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1319 Descr")]
        public string Line1319 { get => _line1319; set => SetField(ref _line1319, value); }
        private DirtyValue<string> _line1320;
        /// <summary>
        /// Fees Line 1320 Descr [NEWHUD2.X4638]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1320 Descr")]
        public string Line1320 { get => _line1320; set => SetField(ref _line1320, value); }
        private DirtyValue<string> _line701;
        /// <summary>
        /// Gfe2010Section Line701
        /// </summary>
        public string Line701 { get => _line701; set => SetField(ref _line701, value); }
        private DirtyValue<string> _line702;
        /// <summary>
        /// Gfe2010Section Line702
        /// </summary>
        public string Line702 { get => _line702; set => SetField(ref _line702, value); }
        private DirtyValue<string> _line703;
        /// <summary>
        /// Gfe2010Section Line703
        /// </summary>
        public string Line703 { get => _line703; set => SetField(ref _line703, value); }
        private DirtyValue<string> _line704;
        /// <summary>
        /// Gfe2010Section Line704
        /// </summary>
        public string Line704 { get => _line704; set => SetField(ref _line704, value); }
        private DirtyValue<string> _line803x;
        /// <summary>
        /// Fees Line 803 Description [NEWHUD2.X7]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 803 Description")]
        public string Line803x { get => _line803x; set => SetField(ref _line803x, value); }
        private DirtyValue<string> _line807Company;
        /// <summary>
        /// Flood Certification To [NEWHUD.X399]
        /// </summary>
        [LoanFieldProperty(Description = "Flood Certification To")]
        public string Line807Company { get => _line807Company; set => SetField(ref _line807Company, value); }
        private DirtyValue<string> _line808;
        /// <summary>
        /// Fees Line 808 Descr [NEWHUD.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 808 Descr")]
        public string Line808 { get => _line808; set => SetField(ref _line808, value); }
        private DirtyValue<string> _line809;
        /// <summary>
        /// Fees Line 809 Descr [NEWHUD.X127]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 809 Descr")]
        public string Line809 { get => _line809; set => SetField(ref _line809, value); }
        private DirtyValue<string> _line810;
        /// <summary>
        /// Fees Line 810 Descr [NEWHUD.X128]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 810 Descr")]
        public string Line810 { get => _line810; set => SetField(ref _line810, value); }
        private DirtyValue<string> _line811;
        /// <summary>
        /// Fees Line 811 Descr [NEWHUD.X129]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 811 Descr")]
        public string Line811 { get => _line811; set => SetField(ref _line811, value); }
        private DirtyValue<string> _line812;
        /// <summary>
        /// Fees Line 812 Descr [NEWHUD.X130]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 812 Descr")]
        public string Line812 { get => _line812; set => SetField(ref _line812, value); }
        private DirtyValue<string> _line819;
        /// <summary>
        /// Fees Line 835 Descr [NEWHUD.X656]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 835 Descr")]
        public string Line819 { get => _line819; set => SetField(ref _line819, value); }
        private DirtyValue<string> _line820;
        /// <summary>
        /// Fees Line 818 Descr [NEWHUD.X1291]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 818 Descr")]
        public string Line820 { get => _line820; set => SetField(ref _line820, value); }
        private DirtyValue<string> _line821;
        /// <summary>
        /// Fees Line 819 Descr [NEWHUD.X1299]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 819 Descr")]
        public string Line821 { get => _line821; set => SetField(ref _line821, value); }
        private DirtyValue<string> _line822;
        /// <summary>
        /// Fees Line 820 Descr [NEWHUD.X1307]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 820 Descr")]
        public string Line822 { get => _line822; set => SetField(ref _line822, value); }
        private DirtyValue<string> _line823;
        /// <summary>
        /// Fees Line 821 Descr [NEWHUD.X1315]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 821 Descr")]
        public string Line823 { get => _line823; set => SetField(ref _line823, value); }
        private DirtyValue<string> _line824;
        /// <summary>
        /// Fees Line 822 Descr [NEWHUD.X1323]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 822 Descr")]
        public string Line824 { get => _line824; set => SetField(ref _line824, value); }
        private DirtyValue<string> _line825;
        /// <summary>
        /// Fees Line 823 Descr [NEWHUD.X1331]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 823 Descr")]
        public string Line825 { get => _line825; set => SetField(ref _line825, value); }
        private DirtyValue<string> _line826;
        /// <summary>
        /// Fees Line 824 Descr [NEWHUD.X1339]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 824 Descr")]
        public string Line826 { get => _line826; set => SetField(ref _line826, value); }
        private DirtyValue<string> _line827;
        /// <summary>
        /// Fees Line 825 Descr [NEWHUD.X1347]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 825 Descr")]
        public string Line827 { get => _line827; set => SetField(ref _line827, value); }
        private DirtyValue<string> _line828;
        /// <summary>
        /// Fees Line 826 Descr [NEWHUD.X1355]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 826 Descr")]
        public string Line828 { get => _line828; set => SetField(ref _line828, value); }
        private DirtyValue<string> _line829;
        /// <summary>
        /// Fees Line 827 Descr [NEWHUD.X1363]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 827 Descr")]
        public string Line829 { get => _line829; set => SetField(ref _line829, value); }
        private DirtyValue<string> _line830;
        /// <summary>
        /// Fees Line 828 Descr [NEWHUD.X1371]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 828 Descr")]
        public string Line830 { get => _line830; set => SetField(ref _line830, value); }
        private DirtyValue<string> _line831;
        /// <summary>
        /// Fees Line 829 Descr [NEWHUD.X1379]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 829 Descr")]
        public string Line831 { get => _line831; set => SetField(ref _line831, value); }
        private DirtyValue<string> _line832;
        /// <summary>
        /// Fees Line 830 Descr [NEWHUD.X1387]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 830 Descr")]
        public string Line832 { get => _line832; set => SetField(ref _line832, value); }
        private DirtyValue<string> _line833;
        /// <summary>
        /// Fees Line 831 Descr [NEWHUD.X1395]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 831 Descr")]
        public string Line833 { get => _line833; set => SetField(ref _line833, value); }
        private DirtyValue<string> _line834;
        /// <summary>
        /// Fees Line 832 Descr [NEWHUD.X1403]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 832 Descr")]
        public string Line834 { get => _line834; set => SetField(ref _line834, value); }
        private DirtyValue<string> _line835;
        /// <summary>
        /// Fees Line 833 Descr [NEWHUD.X1411]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 833 Descr")]
        public string Line835 { get => _line835; set => SetField(ref _line835, value); }
        private DirtyValue<string> _line904;
        /// <summary>
        /// Fees Line 904 User Def Fee Descr [NEWHUD.X582]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 904 User Def Fee Descr")]
        public string Line904 { get => _line904; set => SetField(ref _line904, value); }
        private DirtyValue<string> _line909;
        /// <summary>
        /// Fees Line 909 User Def Fee Descr [NEWHUD.X583]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 909 User Def Fee Descr")]
        public string Line909 { get => _line909; set => SetField(ref _line909, value); }
        private DirtyValue<string> _line910;
        /// <summary>
        /// Fees Line 910 User Def Fee Descr [NEWHUD.X584]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 910 User Def Fee Descr")]
        public string Line910 { get => _line910; set => SetField(ref _line910, value); }
        private DirtyValue<string> _line911;
        /// <summary>
        /// Fees Line 911 Descr [NEWHUD.X1586]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 911 Descr")]
        public string Line911 { get => _line911; set => SetField(ref _line911, value); }
        private DirtyValue<string> _line912;
        /// <summary>
        /// Fees Line 912 Descr [NEWHUD.X1594]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 912 Descr")]
        public string Line912 { get => _line912; set => SetField(ref _line912, value); }
        private DirtyValue<string> _linePC1;
        /// <summary>
        /// Fees Line PC1 Descr [NEWHUD2.X4660]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line PC1 Descr")]
        public string LinePC1 { get => _linePC1; set => SetField(ref _linePC1, value); }
        private DirtyValue<string> _linePC2;
        /// <summary>
        /// Fees Line PC2 Descr [NEWHUD2.X4683]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line PC2 Descr")]
        public string LinePC2 { get => _linePC2; set => SetField(ref _linePC2, value); }
        private DirtyValue<string> _linePC3;
        /// <summary>
        /// Fees Line PC3 Descr [NEWHUD2.X4706]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line PC3 Descr")]
        public string LinePC3 { get => _linePC3; set => SetField(ref _linePC3, value); }
        private DirtyValue<string> _linePC4;
        /// <summary>
        /// Fees Line PC4 Descr [NEWHUD2.X4729]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line PC4 Descr")]
        public string LinePC4 { get => _linePC4; set => SetField(ref _linePC4, value); }
        private DirtyValue<bool?> _loanTermTableCustomized;
        /// <summary>
        /// Loan Term Table Is Customized [LOANTERMTABLE.CUSTOMIZE]
        /// </summary>
        [LoanFieldProperty(Description = "Loan Term Table Is Customized")]
        public bool? LoanTermTableCustomized { get => _loanTermTableCustomized; set => SetField(ref _loanTermTableCustomized, value); }
        private DirtyValue<bool?> _loCompensationItemizeFeesIndicator;
        /// <summary>
        /// Itemize Fees on Line 802 [NEWHUD.X1140]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Fees on Line 802")]
        public bool? LoCompensationItemizeFeesIndicator { get => _loCompensationItemizeFeesIndicator; set => SetField(ref _loCompensationItemizeFeesIndicator, value); }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmount;
        /// <summary>
        /// Total Credit for Rate Chosen [NEWHUD.X1149]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Total Credit for Rate Chosen")]
        public decimal? LoCompensationLenderTotalPaidOriginatorAmount { get => _loCompensationLenderTotalPaidOriginatorAmount; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmount, value); }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForGFE;
        /// <summary>
        /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForGFE
        /// </summary>
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForGFE { get => _loCompensationLenderTotalPaidOriginatorAmountForGFE; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmountForGFE, value); }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForLOTool;
        /// <summary>
        /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForLOTool
        /// </summary>
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForLOTool { get => _loCompensationLenderTotalPaidOriginatorAmountForLOTool; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmountForLOTool, value); }
        private DirtyValue<decimal?> _loCompensationNewHudLenderTotalPaidOriginatorAmount;
        /// <summary>
        /// LO Compensation - GFE -Total Lender Paid Originator Compensation [NEWHUD.X1206]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "LO Compensation - GFE -Total Lender Paid Originator Compensation")]
        public decimal? LoCompensationNewHudLenderTotalPaidOriginatorAmount { get => _loCompensationNewHudLenderTotalPaidOriginatorAmount; set => SetField(ref _loCompensationNewHudLenderTotalPaidOriginatorAmount, value); }
        private DirtyValue<decimal?> _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount;
        /// <summary>
        /// LO Compensation - GFE -Total Borrower Paid Discount Point Amount [NEWHUD.X1215]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "LO Compensation - GFE -Total Borrower Paid Discount Point Amount")]
        public decimal? LoCompensationNewHudTotalBorrowerPaidDiscountPointAmount { get => _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount; set => SetField(ref _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount, value); }
        private DirtyValue<decimal?> _loCompensationNewHudTotalLoCompensationAmount;
        /// <summary>
        /// LO Compensation - GFE -Total Origination or Discount Points [NEWHUD.X1216]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "LO Compensation - GFE -Total Origination or Discount Points")]
        public decimal? LoCompensationNewHudTotalLoCompensationAmount { get => _loCompensationNewHudTotalLoCompensationAmount; set => SetField(ref _loCompensationNewHudTotalLoCompensationAmount, value); }
        private DirtyValue<decimal?> _loCompensationTotalBorrowerPaidDiscountPointAmount4;
        /// <summary>
        /// LO Compensation - TotalBorrower Paid Discount Point Amount Line 4 [NEWHUD.X1165]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "LO Compensation - TotalBorrower Paid Discount Point Amount Line 4")]
        public decimal? LoCompensationTotalBorrowerPaidDiscountPointAmount4 { get => _loCompensationTotalBorrowerPaidDiscountPointAmount4; set => SetField(ref _loCompensationTotalBorrowerPaidDiscountPointAmount4, value); }
        private DirtyValue<decimal?> _loCompensationTotalLoCompensationAmount;
        /// <summary>
        /// LO Compensation - Total Origination or Discount Points [NEWHUD.X1191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "LO Compensation - Total Origination or Discount Points")]
        public decimal? LoCompensationTotalLoCompensationAmount { get => _loCompensationTotalLoCompensationAmount; set => SetField(ref _loCompensationTotalLoCompensationAmount, value); }
        private DirtyValue<decimal?> _loCompensationTotalSellerPaidDiscountPointAmount4;
        /// <summary>
        /// LO Compensation - Total Seller Paid Discount Point Amount Line 4 [NEWHUD.X1166]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "LO Compensation - Total Seller Paid Discount Point Amount Line 4")]
        public decimal? LoCompensationTotalSellerPaidDiscountPointAmount4 { get => _loCompensationTotalSellerPaidDiscountPointAmount4; set => SetField(ref _loCompensationTotalSellerPaidDiscountPointAmount4, value); }
        private DirtyValue<bool?> _loCompensationUseLoCompensationToolIndicator;
        /// <summary>
        /// Itemize Fees on Line 802 Use LO Compensation Tool [NEWHUD.X1139]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Fees on Line 802 Use LO Compensation Tool")]
        public bool? LoCompensationUseLoCompensationToolIndicator { get => _loCompensationUseLoCompensationToolIndicator; set => SetField(ref _loCompensationUseLoCompensationToolIndicator, value); }
        private DirtyValue<string> _projectedPaymentTableColumns;
        /// <summary>
        /// Projected Payment Table number of columns [NEWHUD2.XPJTCOLUMNS]
        /// </summary>
        [LoanFieldProperty(Description = "Projected Payment Table number of columns")]
        public string ProjectedPaymentTableColumns { get => _projectedPaymentTableColumns; set => SetField(ref _projectedPaymentTableColumns, value); }
        private DirtyValue<bool?> _projectedPaymentTableCustomized;
        /// <summary>
        /// Projected Payment Table Is Customized [PAYMENTTABLE.CUSTOMIZE]
        /// </summary>
        [LoanFieldProperty(Description = "Projected Payment Table Is Customized")]
        public bool? ProjectedPaymentTableCustomized { get => _projectedPaymentTableCustomized; set => SetField(ref _projectedPaymentTableCustomized, value); }
        private DirtyValue<string> _projectedPaymentTableType;
        /// <summary>
        /// Projected Payment Table [NEWHUD2.XPJT]
        /// </summary>
        [LoanFieldProperty(Description = "Projected Payment Table")]
        public string ProjectedPaymentTableType { get => _projectedPaymentTableType; set => SetField(ref _projectedPaymentTableType, value); }
        private DirtyValue<decimal?> _section1000AggregateAdjust;
        /// <summary>
        /// Fees Line 1010 Aggregate Adjust Applied to GFE [NEWHUD.X948]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Line 1010 Aggregate Adjust Applied to GFE")]
        public decimal? Section1000AggregateAdjust { get => _section1000AggregateAdjust; set => SetField(ref _section1000AggregateAdjust, value); }
        private DirtyValue<bool?> _section1000HudGuaranteeFeeAprIndicator;
        /// <summary>
        /// Fees Line 1010 Guarantee Fee APR [NEWHUD.X1711]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1010 Guarantee Fee APR")]
        public bool? Section1000HudGuaranteeFeeAprIndicator { get => _section1000HudGuaranteeFeeAprIndicator; set => SetField(ref _section1000HudGuaranteeFeeAprIndicator, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator1;
        /// <summary>
        /// Fees Line 1104 Borr Selects [NEWHUD.X573]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1104 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator1 { get => _section1100BorrowerSelectIndicator1; set => SetField(ref _section1100BorrowerSelectIndicator1, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator10;
        /// <summary>
        /// Fees Line 1102 Borr Select [NEWHUD.X646]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1102 Borr Select")]
        public bool? Section1100BorrowerSelectIndicator10 { get => _section1100BorrowerSelectIndicator10; set => SetField(ref _section1100BorrowerSelectIndicator10, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator2;
        /// <summary>
        /// Fees Line 1107 Borr Selects [NEWHUD.X574]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1107 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator2 { get => _section1100BorrowerSelectIndicator2; set => SetField(ref _section1100BorrowerSelectIndicator2, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator3;
        /// <summary>
        /// Fees Line 1108 Borr Selects [NEWHUD.X575]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1108 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator3 { get => _section1100BorrowerSelectIndicator3; set => SetField(ref _section1100BorrowerSelectIndicator3, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator4;
        /// <summary>
        /// Fees Line 1109 Borr Selects [NEWHUD.X576]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1109 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator4 { get => _section1100BorrowerSelectIndicator4; set => SetField(ref _section1100BorrowerSelectIndicator4, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator5;
        /// <summary>
        /// Fees Line 1110 Borr Selects [NEWHUD.X577]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1110 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator5 { get => _section1100BorrowerSelectIndicator5; set => SetField(ref _section1100BorrowerSelectIndicator5, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator6;
        /// <summary>
        /// Fees Line 1111 Borr Selects [NEWHUD.X578]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1111 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator6 { get => _section1100BorrowerSelectIndicator6; set => SetField(ref _section1100BorrowerSelectIndicator6, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator7;
        /// <summary>
        /// Fees Line 1112 Borr Selects [NEWHUD.X579]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1112 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator7 { get => _section1100BorrowerSelectIndicator7; set => SetField(ref _section1100BorrowerSelectIndicator7, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator8;
        /// <summary>
        /// Fees Line 1113 Borr Selects [NEWHUD.X580]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1113 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator8 { get => _section1100BorrowerSelectIndicator8; set => SetField(ref _section1100BorrowerSelectIndicator8, value); }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator9;
        /// <summary>
        /// Fees Line 1114 Borr Selects [NEWHUD.X581]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1114 Borr Selects")]
        public bool? Section1100BorrowerSelectIndicator9 { get => _section1100BorrowerSelectIndicator9; set => SetField(ref _section1100BorrowerSelectIndicator9, value); }
        private DirtyValue<bool?> _section1100ItemizeFeesIndicator;
        /// <summary>
        /// Itemize Fees on Line 1101 [NEWHUD.X1017]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Fees on Line 1101")]
        public bool? Section1100ItemizeFeesIndicator { get => _section1100ItemizeFeesIndicator; set => SetField(ref _section1100ItemizeFeesIndicator, value); }
        private DirtyValue<decimal?> _section1200TotalTransferTaxes;
        /// <summary>
        /// Trans Tax Total for HUD-1 Page 2 [NEWHUD.X778]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Tax Total for HUD-1 Page 2")]
        public decimal? Section1200TotalTransferTaxes { get => _section1200TotalTransferTaxes; set => SetField(ref _section1200TotalTransferTaxes, value); }
        private DirtyValue<bool?> _section800BonaFideIndicator;
        /// <summary>
        /// Fees Bona Fide Indicator [NEWHUD.X1067]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Bona Fide Indicator")]
        public bool? Section800BonaFideIndicator { get => _section800BonaFideIndicator; set => SetField(ref _section800BonaFideIndicator, value); }
        private DirtyValue<decimal?> _section800BorrowerPaidInitialDiscountPointAmount;
        /// <summary>
        /// Fees Borrower Paid Initial Discount Point Amount [NEWHUD.X1723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Fees Borrower Paid Initial Discount Point Amount")]
        public decimal? Section800BorrowerPaidInitialDiscountPointAmount { get => _section800BorrowerPaidInitialDiscountPointAmount; set => SetField(ref _section800BorrowerPaidInitialDiscountPointAmount, value); }
        private DirtyValue<decimal?> _section800ChargeAmount;
        /// <summary>
        /// Gfe2010Section Section800ChargeAmount [NEWHUD.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section800ChargeAmount { get => _section800ChargeAmount; set => SetField(ref _section800ChargeAmount, value); }
        private DirtyValue<StringEnumValue<CreditChargeType>> _section800CreditChargeType;
        /// <summary>
        /// Include Points/Credit in Orig Chrg [NEWHUD.X713]
        /// </summary>
        [LoanFieldProperty(Description = "Include Points/Credit in Orig Chrg")]
        public StringEnumValue<CreditChargeType> Section800CreditChargeType { get => _section800CreditChargeType; set => SetField(ref _section800CreditChargeType, value); }
        private DirtyValue<StringEnumValue<IncludeOriginationPointsCreditType>> _section800IncludeOriginationPointsCreditType;
        /// <summary>
        /// Borr Receives Credit/Pays Fee [NEWHUD.X715]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Receives Credit/Pays Fee")]
        public StringEnumValue<IncludeOriginationPointsCreditType> Section800IncludeOriginationPointsCreditType { get => _section800IncludeOriginationPointsCreditType; set => SetField(ref _section800IncludeOriginationPointsCreditType, value); }
        private DirtyValue<decimal?> _section800InitialDiscountPoint;
        /// <summary>
        /// Fees Initial Discount Point [NEWHUD.X1721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Fees Initial Discount Point")]
        public decimal? Section800InitialDiscountPoint { get => _section800InitialDiscountPoint; set => SetField(ref _section800InitialDiscountPoint, value); }
        private DirtyValue<decimal?> _section800InitialDiscountPointAdditionalAmount;
        /// <summary>
        /// Fees Initial Discount Point Additional Amount [NEWHUD.X1722]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Initial Discount Point Additional Amount")]
        public decimal? Section800InitialDiscountPointAdditionalAmount { get => _section800InitialDiscountPointAdditionalAmount; set => SetField(ref _section800InitialDiscountPointAdditionalAmount, value); }
        private DirtyValue<decimal?> _section800InitialDiscountRate;
        /// <summary>
        /// Fees Initial Discount Rate [NEWHUD.X1720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Fees Initial Discount Rate")]
        public decimal? Section800InitialDiscountRate { get => _section800InitialDiscountRate; set => SetField(ref _section800InitialDiscountRate, value); }
        private DirtyValue<bool?> _section800ItemizeFeesIndicator;
        /// <summary>
        /// Itemize Fees on Line 801 [NEWHUD.X750]
        /// </summary>
        [LoanFieldProperty(Description = "Itemize Fees on Line 801")]
        public bool? Section800ItemizeFeesIndicator { get => _section800ItemizeFeesIndicator; set => SetField(ref _section800ItemizeFeesIndicator, value); }
        private DirtyValue<decimal?> _section800SelChargeAmount;
        /// <summary>
        /// Fees Line 802 Orig Charge Amt Seller [NEWHUD.X788]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 802 Orig Charge Amt Seller")]
        public decimal? Section800SelChargeAmount { get => _section800SelChargeAmount; set => SetField(ref _section800SelChargeAmount, value); }
        private DirtyValue<decimal?> _section800TotalTransferTaxes;
        /// <summary>
        /// Trans Tax Total HUD-1 P3 [NEWHUD.X700]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Trans Tax Total HUD-1 P3")]
        public decimal? Section800TotalTransferTaxes { get => _section800TotalTransferTaxes; set => SetField(ref _section800TotalTransferTaxes, value); }
        private DirtyValue<decimal?> _section900HomeownerInsurance;
        /// <summary>
        /// New HUD Homeowner Ins Total Amt [NEWHUD.X723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "New HUD Homeowner Ins Total Amt")]
        public decimal? Section900HomeownerInsurance { get => _section900HomeownerInsurance; set => SetField(ref _section900HomeownerInsurance, value); }
        private DirtyValue<decimal?> _section900HudGfeVaFundingFee;
        /// <summary>
        /// Fees Line 905 Fee Applied to GFE [NEWHUD.X661]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 905 Fee Applied to GFE")]
        public decimal? Section900HudGfeVaFundingFee { get => _section900HudGfeVaFundingFee; set => SetField(ref _section900HudGfeVaFundingFee, value); }
        private DirtyValue<bool?> _useActualPaymentChange;
        /// <summary>
        /// Projected Payment Table - Use Actual Payment Change [PAYMENTTABLE.USEACTUALPAYMENTCHANGE]
        /// </summary>
        [LoanFieldProperty(Description = "Projected Payment Table - Use Actual Payment Change")]
        public bool? UseActualPaymentChange { get => _useActualPaymentChange; set => SetField(ref _useActualPaymentChange, value); }
    }
}