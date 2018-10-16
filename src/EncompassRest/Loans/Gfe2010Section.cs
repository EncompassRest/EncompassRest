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
        private DirtyValue<bool?> _borrowerSelectIndicator904;
        private DirtyValue<bool?> _borrowerSelectIndicator906;
        private DirtyValue<bool?> _borrowerSelectIndicator907;
        private DirtyValue<bool?> _borrowerSelectIndicator908;
        private DirtyValue<bool?> _borrowerSelectIndicator909;
        private DirtyValue<bool?> _borrowerSelectIndicator910;
        private DirtyValue<decimal?> _hudGfeLine1109;
        private DirtyValue<decimal?> _hudGfeLine1110;
        private DirtyValue<decimal?> _hudGfeLine1111;
        private DirtyValue<decimal?> _hudGfeLine1112;
        private DirtyValue<decimal?> _hudGfeLine1113;
        private DirtyValue<decimal?> _hudGfeLine1114;
        private DirtyValue<string> _id;
        private DirtyValue<string> _line1001;
        private DirtyValue<decimal?> _line1001BorPaidTotal;
        private DirtyValue<string> _line1002;
        private DirtyValue<string> _line1003;
        private DirtyValue<string> _line1004;
        private DirtyValue<string> _line1005;
        private DirtyValue<string> _line1006;
        private DirtyValue<string> _line1007;
        private DirtyValue<string> _line1008;
        private DirtyValue<string> _line1009;
        private DirtyValue<string> _line1010;
        private DirtyValue<string> _line1011;
        private DirtyValue<string> _line1101;
        private DirtyValue<decimal?> _line1101BorPaidTotal;
        private DirtyValue<decimal?> _line1101SellerPaidAtoF;
        private DirtyValue<string> _line1102;
        private DirtyValue<string> _line1103;
        private DirtyValue<decimal?> _line1103PTAAmount;
        private DirtyValue<string> _line1104;
        private DirtyValue<decimal?> _line1104PTAAmount;
        private DirtyValue<string> _line1107;
        private DirtyValue<string> _line1108;
        private DirtyValue<string> _line1109;
        private DirtyValue<string> _line1110;
        private DirtyValue<string> _line1115;
        private DirtyValue<string> _line1116;
        private DirtyValue<decimal?> _line1201BorPaidTotal;
        private DirtyValue<string> _line1209;
        private DirtyValue<string> _line1210;
        private DirtyValue<decimal?> _line1301BorPaidTotal;
        private DirtyValue<string> _line1302;
        private DirtyValue<string> _line1310;
        private DirtyValue<string> _line1311;
        private DirtyValue<string> _line1312;
        private DirtyValue<string> _line1313;
        private DirtyValue<string> _line1314;
        private DirtyValue<string> _line1315;
        private DirtyValue<string> _line1316;
        private DirtyValue<string> _line1317;
        private DirtyValue<string> _line1318;
        private DirtyValue<string> _line1319;
        private DirtyValue<string> _line1320;
        private DirtyValue<string> _line701;
        private DirtyValue<string> _line702;
        private DirtyValue<string> _line703;
        private DirtyValue<string> _line704;
        private DirtyValue<string> _line803x;
        private DirtyValue<string> _line807Company;
        private DirtyValue<string> _line808;
        private DirtyValue<string> _line809;
        private DirtyValue<string> _line810;
        private DirtyValue<string> _line811;
        private DirtyValue<string> _line812;
        private DirtyValue<string> _line819;
        private DirtyValue<string> _line820;
        private DirtyValue<string> _line821;
        private DirtyValue<string> _line822;
        private DirtyValue<string> _line823;
        private DirtyValue<string> _line824;
        private DirtyValue<string> _line825;
        private DirtyValue<string> _line826;
        private DirtyValue<string> _line827;
        private DirtyValue<string> _line828;
        private DirtyValue<string> _line829;
        private DirtyValue<string> _line830;
        private DirtyValue<string> _line831;
        private DirtyValue<string> _line832;
        private DirtyValue<string> _line833;
        private DirtyValue<string> _line834;
        private DirtyValue<string> _line835;
        private DirtyValue<string> _line904;
        private DirtyValue<string> _line909;
        private DirtyValue<string> _line910;
        private DirtyValue<string> _line911;
        private DirtyValue<string> _line912;
        private DirtyValue<string> _linePC1;
        private DirtyValue<string> _linePC2;
        private DirtyValue<string> _linePC3;
        private DirtyValue<string> _linePC4;
        private DirtyValue<bool?> _loanTermTableCustomized;
        private DirtyValue<bool?> _loCompensationItemizeFeesIndicator;
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmount;
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForGFE;
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForLOTool;
        private DirtyValue<decimal?> _loCompensationNewHudLenderTotalPaidOriginatorAmount;
        private DirtyValue<decimal?> _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount;
        private DirtyValue<decimal?> _loCompensationNewHudTotalLoCompensationAmount;
        private DirtyValue<decimal?> _loCompensationTotalBorrowerPaidDiscountPointAmount4;
        private DirtyValue<decimal?> _loCompensationTotalLoCompensationAmount;
        private DirtyValue<decimal?> _loCompensationTotalSellerPaidDiscountPointAmount4;
        private DirtyValue<bool?> _loCompensationUseLoCompensationToolIndicator;
        private DirtyValue<string> _projectedPaymentTableColumns;
        private DirtyValue<bool?> _projectedPaymentTableCustomized;
        private DirtyValue<string> _projectedPaymentTableType;
        private DirtyValue<decimal?> _section1000AggregateAdjust;
        private DirtyValue<bool?> _section1000HudGuaranteeFeeAprIndicator;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator1;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator10;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator2;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator3;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator4;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator5;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator6;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator7;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator8;
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator9;
        private DirtyValue<bool?> _section1100ItemizeFeesIndicator;
        private DirtyValue<decimal?> _section1200TotalTransferTaxes;
        private DirtyValue<bool?> _section800BonaFideIndicator;
        private DirtyValue<decimal?> _section800BorrowerPaidInitialDiscountPointAmount;
        private DirtyValue<decimal?> _section800ChargeAmount;
        private DirtyValue<StringEnumValue<CreditChargeType>> _section800CreditChargeType;
        private DirtyValue<StringEnumValue<IncludeOriginationPointsCreditType>> _section800IncludeOriginationPointsCreditType;
        private DirtyValue<decimal?> _section800InitialDiscountPoint;
        private DirtyValue<decimal?> _section800InitialDiscountPointAdditionalAmount;
        private DirtyValue<decimal?> _section800InitialDiscountRate;
        private DirtyValue<bool?> _section800ItemizeFeesIndicator;
        private DirtyValue<decimal?> _section800SelChargeAmount;
        private DirtyValue<decimal?> _section800TotalTransferTaxes;
        private DirtyValue<decimal?> _section900HomeownerInsurance;
        private DirtyValue<decimal?> _section900HudGfeVaFundingFee;
        private DirtyValue<bool?> _useActualPaymentChange;

        /// <summary>
        /// Fees Line 903 Borr Select [NEWHUD.X651]
        /// </summary>
        public bool? BorrowerSelectIndicator903 { get => _borrowerSelectIndicator903; set => SetField(ref _borrowerSelectIndicator903, value); }

        /// <summary>
        /// Fees Line 904 Borr Select [NEWHUD.X597]
        /// </summary>
        public bool? BorrowerSelectIndicator904 { get => _borrowerSelectIndicator904; set => SetField(ref _borrowerSelectIndicator904, value); }

        /// <summary>
        /// Fees Line 906 Borr Select [NEWHUD.X598]
        /// </summary>
        public bool? BorrowerSelectIndicator906 { get => _borrowerSelectIndicator906; set => SetField(ref _borrowerSelectIndicator906, value); }

        /// <summary>
        /// Fees Line 907 Borr Select [NEWHUD.X599]
        /// </summary>
        public bool? BorrowerSelectIndicator907 { get => _borrowerSelectIndicator907; set => SetField(ref _borrowerSelectIndicator907, value); }

        /// <summary>
        /// Fees Line 908 Borr Select [NEWHUD.X600]
        /// </summary>
        public bool? BorrowerSelectIndicator908 { get => _borrowerSelectIndicator908; set => SetField(ref _borrowerSelectIndicator908, value); }

        /// <summary>
        /// Fees Line 909 Borr Select [NEWHUD.X601]
        /// </summary>
        public bool? BorrowerSelectIndicator909 { get => _borrowerSelectIndicator909; set => SetField(ref _borrowerSelectIndicator909, value); }

        /// <summary>
        /// Fees Line 910 Borr Select [NEWHUD.X602]
        /// </summary>
        public bool? BorrowerSelectIndicator910 { get => _borrowerSelectIndicator910; set => SetField(ref _borrowerSelectIndicator910, value); }

        /// <summary>
        /// Fees Line 1109 Applied to GFE [NEWHUD.X565]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1109 { get => _hudGfeLine1109; set => SetField(ref _hudGfeLine1109, value); }

        /// <summary>
        /// Fees Line 1110 Applied to GFE [NEWHUD.X566]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1110 { get => _hudGfeLine1110; set => SetField(ref _hudGfeLine1110, value); }

        /// <summary>
        /// Fees Line 1111 Applied to GFE [NEWHUD.X567]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1111 { get => _hudGfeLine1111; set => SetField(ref _hudGfeLine1111, value); }

        /// <summary>
        /// Fees Line 1112 Applied to GFE [NEWHUD.X568]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1112 { get => _hudGfeLine1112; set => SetField(ref _hudGfeLine1112, value); }

        /// <summary>
        /// Fees Line 1113 Applied to GFE [NEWHUD.X569]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1113 { get => _hudGfeLine1113; set => SetField(ref _hudGfeLine1113, value); }

        /// <summary>
        /// Fees Line 1114 Applied to GFE [NEWHUD.X570]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? HudGfeLine1114 { get => _hudGfeLine1114; set => SetField(ref _hudGfeLine1114, value); }

        /// <summary>
        /// Gfe2010Section Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Gfe2010Section Line1001
        /// </summary>
        public string Line1001 { get => _line1001; set => SetField(ref _line1001, value); }

        /// <summary>
        /// Borr Fees Line 1001 for HUD-1 Page 2 [NEWHUD.X1716]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1001BorPaidTotal { get => _line1001BorPaidTotal; set => SetField(ref _line1001BorPaidTotal, value); }

        /// <summary>
        /// Gfe2010Section Line1002
        /// </summary>
        public string Line1002 { get => _line1002; set => SetField(ref _line1002, value); }

        /// <summary>
        /// Gfe2010Section Line1003
        /// </summary>
        public string Line1003 { get => _line1003; set => SetField(ref _line1003, value); }

        /// <summary>
        /// Gfe2010Section Line1004
        /// </summary>
        public string Line1004 { get => _line1004; set => SetField(ref _line1004, value); }

        /// <summary>
        /// Gfe2010Section Line1005
        /// </summary>
        public string Line1005 { get => _line1005; set => SetField(ref _line1005, value); }

        /// <summary>
        /// Gfe2010Section Line1006
        /// </summary>
        public string Line1006 { get => _line1006; set => SetField(ref _line1006, value); }

        /// <summary>
        /// Gfe2010Section Line1007
        /// </summary>
        public string Line1007 { get => _line1007; set => SetField(ref _line1007, value); }

        /// <summary>
        /// Gfe2010Section Line1008
        /// </summary>
        public string Line1008 { get => _line1008; set => SetField(ref _line1008, value); }

        /// <summary>
        /// Gfe2010Section Line1009
        /// </summary>
        public string Line1009 { get => _line1009; set => SetField(ref _line1009, value); }

        /// <summary>
        /// Gfe2010Section Line1010
        /// </summary>
        public string Line1010 { get => _line1010; set => SetField(ref _line1010, value); }

        /// <summary>
        /// Gfe2010Section Line1011
        /// </summary>
        public string Line1011 { get => _line1011; set => SetField(ref _line1011, value); }

        /// <summary>
        /// Title Serv &amp; Lender Title Ins Provider [NEWHUD.X202]
        /// </summary>
        public string Line1101 { get => _line1101; set => SetField(ref _line1101, value); }

        /// <summary>
        /// Borr Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X775]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1101BorPaidTotal { get => _line1101BorPaidTotal; set => SetField(ref _line1101BorPaidTotal, value); }

        /// <summary>
        /// Seller Fees Line 1101 for HUD-1 Page 2 [NEWHUD.X708]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1101SellerPaidAtoF { get => _line1101SellerPaidAtoF; set => SetField(ref _line1101SellerPaidAtoF, value); }

        /// <summary>
        /// Sttlmnt or Closing Fee Provider [NEWHUD.X203]
        /// </summary>
        public string Line1102 { get => _line1102; set => SetField(ref _line1102, value); }

        /// <summary>
        /// Owner Title Ins Provider [NEWHUD.X204]
        /// </summary>
        public string Line1103 { get => _line1103; set => SetField(ref _line1103, value); }

        /// <summary>
        /// Owner's Title Insurance Paid To Affiliate Amount [NEWHUD.X1724]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1103PTAAmount { get => _line1103PTAAmount; set => SetField(ref _line1103PTAAmount, value); }

        /// <summary>
        /// Lender Title Ins Provider [NEWHUD.X205]
        /// </summary>
        public string Line1104 { get => _line1104; set => SetField(ref _line1104, value); }

        /// <summary>
        /// Lender's Title Insurance Paid To Affiliate Amount [NEWHUD.X1725]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1104PTAAmount { get => _line1104PTAAmount; set => SetField(ref _line1104PTAAmount, value); }

        /// <summary>
        /// Total Title Ins Prem - Recipient Agent Portion [NEWHUD.X206]
        /// </summary>
        public string Line1107 { get => _line1107; set => SetField(ref _line1107, value); }

        /// <summary>
        /// Total Title Ins Prem - Recipient Underwiter Portion [NEWHUD.X207]
        /// </summary>
        public string Line1108 { get => _line1108; set => SetField(ref _line1108, value); }

        /// <summary>
        /// Fees Line 1109 Descr [NEWHUD.X208]
        /// </summary>
        public string Line1109 { get => _line1109; set => SetField(ref _line1109, value); }

        /// <summary>
        /// Fees Line 1110 Descr [NEWHUD.X209]
        /// </summary>
        public string Line1110 { get => _line1110; set => SetField(ref _line1110, value); }

        /// <summary>
        /// Fees Line 1115 Descr [NEWHUD.X1602]
        /// </summary>
        public string Line1115 { get => _line1115; set => SetField(ref _line1115, value); }

        /// <summary>
        /// Fees Line 1116 Descr [NEWHUD.X1610]
        /// </summary>
        public string Line1116 { get => _line1116; set => SetField(ref _line1116, value); }

        /// <summary>
        /// Borr Fees Line 1201 for HUD-1 Page 2 [NEWHUD.X776]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1201BorPaidTotal { get => _line1201BorPaidTotal; set => SetField(ref _line1201BorPaidTotal, value); }

        /// <summary>
        /// Fees Line 1209 Descr [NEWHUD.X1618]
        /// </summary>
        public string Line1209 { get => _line1209; set => SetField(ref _line1209, value); }

        /// <summary>
        /// Fees Line 1210 Descr [NEWHUD.X1625]
        /// </summary>
        public string Line1210 { get => _line1210; set => SetField(ref _line1210, value); }

        /// <summary>
        /// Borr Fees Line 1301 for HUD-1 Page 2 [NEWHUD.X777]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Line1301BorPaidTotal { get => _line1301BorPaidTotal; set => SetField(ref _line1301BorPaidTotal, value); }

        /// <summary>
        /// Fees Line 1302 Descr [NEWHUD.X251]
        /// </summary>
        public string Line1302 { get => _line1302; set => SetField(ref _line1302, value); }

        /// <summary>
        /// Fees Line 1310 Descr [NEWHUD.X252]
        /// </summary>
        public string Line1310 { get => _line1310; set => SetField(ref _line1310, value); }

        /// <summary>
        /// Fees Line 1311 Descr [NEWHUD.X253]
        /// </summary>
        public string Line1311 { get => _line1311; set => SetField(ref _line1311, value); }

        /// <summary>
        /// Fees Line 1312 Descr [NEWHUD.X1632]
        /// </summary>
        public string Line1312 { get => _line1312; set => SetField(ref _line1312, value); }

        /// <summary>
        /// Fees Line 1313 Descr [NEWHUD.X1640]
        /// </summary>
        public string Line1313 { get => _line1313; set => SetField(ref _line1313, value); }

        /// <summary>
        /// Fees Line 1314 Descr [NEWHUD.X1648]
        /// </summary>
        public string Line1314 { get => _line1314; set => SetField(ref _line1314, value); }

        /// <summary>
        /// Fees Line 1315 Descr [NEWHUD.X1656]
        /// </summary>
        public string Line1315 { get => _line1315; set => SetField(ref _line1315, value); }

        /// <summary>
        /// Fees Line 1316 Descr [NEWHUD2.X4610]
        /// </summary>
        public string Line1316 { get => _line1316; set => SetField(ref _line1316, value); }

        /// <summary>
        /// Fees Line 1317 Descr [NEWHUD2.X4617]
        /// </summary>
        public string Line1317 { get => _line1317; set => SetField(ref _line1317, value); }

        /// <summary>
        /// Fees Line 1318 Descr [NEWHUD2.X4624]
        /// </summary>
        public string Line1318 { get => _line1318; set => SetField(ref _line1318, value); }

        /// <summary>
        /// Fees Line 1319 Descr [NEWHUD2.X4631]
        /// </summary>
        public string Line1319 { get => _line1319; set => SetField(ref _line1319, value); }

        /// <summary>
        /// Fees Line 1320 Descr [NEWHUD2.X4638]
        /// </summary>
        public string Line1320 { get => _line1320; set => SetField(ref _line1320, value); }

        /// <summary>
        /// Gfe2010Section Line701
        /// </summary>
        public string Line701 { get => _line701; set => SetField(ref _line701, value); }

        /// <summary>
        /// Gfe2010Section Line702
        /// </summary>
        public string Line702 { get => _line702; set => SetField(ref _line702, value); }

        /// <summary>
        /// Gfe2010Section Line703
        /// </summary>
        public string Line703 { get => _line703; set => SetField(ref _line703, value); }

        /// <summary>
        /// Gfe2010Section Line704
        /// </summary>
        public string Line704 { get => _line704; set => SetField(ref _line704, value); }

        /// <summary>
        /// Fees Line 803 Description [NEWHUD2.X7]
        /// </summary>
        public string Line803x { get => _line803x; set => SetField(ref _line803x, value); }

        /// <summary>
        /// Flood Certification To [NEWHUD.X399]
        /// </summary>
        public string Line807Company { get => _line807Company; set => SetField(ref _line807Company, value); }

        /// <summary>
        /// Fees Line 808 Descr [NEWHUD.X126]
        /// </summary>
        public string Line808 { get => _line808; set => SetField(ref _line808, value); }

        /// <summary>
        /// Fees Line 809 Descr [NEWHUD.X127]
        /// </summary>
        public string Line809 { get => _line809; set => SetField(ref _line809, value); }

        /// <summary>
        /// Fees Line 810 Descr [NEWHUD.X128]
        /// </summary>
        public string Line810 { get => _line810; set => SetField(ref _line810, value); }

        /// <summary>
        /// Fees Line 811 Descr [NEWHUD.X129]
        /// </summary>
        public string Line811 { get => _line811; set => SetField(ref _line811, value); }

        /// <summary>
        /// Fees Line 812 Descr [NEWHUD.X130]
        /// </summary>
        public string Line812 { get => _line812; set => SetField(ref _line812, value); }

        /// <summary>
        /// Fees Line 835 Descr [NEWHUD.X656]
        /// </summary>
        public string Line819 { get => _line819; set => SetField(ref _line819, value); }

        /// <summary>
        /// Fees Line 818 Descr [NEWHUD.X1291]
        /// </summary>
        public string Line820 { get => _line820; set => SetField(ref _line820, value); }

        /// <summary>
        /// Fees Line 819 Descr [NEWHUD.X1299]
        /// </summary>
        public string Line821 { get => _line821; set => SetField(ref _line821, value); }

        /// <summary>
        /// Fees Line 820 Descr [NEWHUD.X1307]
        /// </summary>
        public string Line822 { get => _line822; set => SetField(ref _line822, value); }

        /// <summary>
        /// Fees Line 821 Descr [NEWHUD.X1315]
        /// </summary>
        public string Line823 { get => _line823; set => SetField(ref _line823, value); }

        /// <summary>
        /// Fees Line 822 Descr [NEWHUD.X1323]
        /// </summary>
        public string Line824 { get => _line824; set => SetField(ref _line824, value); }

        /// <summary>
        /// Fees Line 823 Descr [NEWHUD.X1331]
        /// </summary>
        public string Line825 { get => _line825; set => SetField(ref _line825, value); }

        /// <summary>
        /// Fees Line 824 Descr [NEWHUD.X1339]
        /// </summary>
        public string Line826 { get => _line826; set => SetField(ref _line826, value); }

        /// <summary>
        /// Fees Line 825 Descr [NEWHUD.X1347]
        /// </summary>
        public string Line827 { get => _line827; set => SetField(ref _line827, value); }

        /// <summary>
        /// Fees Line 826 Descr [NEWHUD.X1355]
        /// </summary>
        public string Line828 { get => _line828; set => SetField(ref _line828, value); }

        /// <summary>
        /// Fees Line 827 Descr [NEWHUD.X1363]
        /// </summary>
        public string Line829 { get => _line829; set => SetField(ref _line829, value); }

        /// <summary>
        /// Fees Line 828 Descr [NEWHUD.X1371]
        /// </summary>
        public string Line830 { get => _line830; set => SetField(ref _line830, value); }

        /// <summary>
        /// Fees Line 829 Descr [NEWHUD.X1379]
        /// </summary>
        public string Line831 { get => _line831; set => SetField(ref _line831, value); }

        /// <summary>
        /// Fees Line 830 Descr [NEWHUD.X1387]
        /// </summary>
        public string Line832 { get => _line832; set => SetField(ref _line832, value); }

        /// <summary>
        /// Fees Line 831 Descr [NEWHUD.X1395]
        /// </summary>
        public string Line833 { get => _line833; set => SetField(ref _line833, value); }

        /// <summary>
        /// Fees Line 832 Descr [NEWHUD.X1403]
        /// </summary>
        public string Line834 { get => _line834; set => SetField(ref _line834, value); }

        /// <summary>
        /// Fees Line 833 Descr [NEWHUD.X1411]
        /// </summary>
        public string Line835 { get => _line835; set => SetField(ref _line835, value); }

        /// <summary>
        /// Fees Line 904 User Def Fee Descr [NEWHUD.X582]
        /// </summary>
        public string Line904 { get => _line904; set => SetField(ref _line904, value); }

        /// <summary>
        /// Fees Line 909 User Def Fee Descr [NEWHUD.X583]
        /// </summary>
        public string Line909 { get => _line909; set => SetField(ref _line909, value); }

        /// <summary>
        /// Fees Line 910 User Def Fee Descr [NEWHUD.X584]
        /// </summary>
        public string Line910 { get => _line910; set => SetField(ref _line910, value); }

        /// <summary>
        /// Fees Line 911 Descr [NEWHUD.X1586]
        /// </summary>
        public string Line911 { get => _line911; set => SetField(ref _line911, value); }

        /// <summary>
        /// Fees Line 912 Descr [NEWHUD.X1594]
        /// </summary>
        public string Line912 { get => _line912; set => SetField(ref _line912, value); }

        /// <summary>
        /// Fees Line PC1 Descr [NEWHUD2.X4660]
        /// </summary>
        public string LinePC1 { get => _linePC1; set => SetField(ref _linePC1, value); }

        /// <summary>
        /// Fees Line PC2 Descr [NEWHUD2.X4683]
        /// </summary>
        public string LinePC2 { get => _linePC2; set => SetField(ref _linePC2, value); }

        /// <summary>
        /// Fees Line PC3 Descr [NEWHUD2.X4706]
        /// </summary>
        public string LinePC3 { get => _linePC3; set => SetField(ref _linePC3, value); }

        /// <summary>
        /// Fees Line PC4 Descr [NEWHUD2.X4729]
        /// </summary>
        public string LinePC4 { get => _linePC4; set => SetField(ref _linePC4, value); }

        /// <summary>
        /// Loan Term Table Is Customized [LOANTERMTABLE.CUSTOMIZE]
        /// </summary>
        public bool? LoanTermTableCustomized { get => _loanTermTableCustomized; set => SetField(ref _loanTermTableCustomized, value); }

        /// <summary>
        /// Itemize Fees on Line 802 [NEWHUD.X1140]
        /// </summary>
        public bool? LoCompensationItemizeFeesIndicator { get => _loCompensationItemizeFeesIndicator; set => SetField(ref _loCompensationItemizeFeesIndicator, value); }

        /// <summary>
        /// Total Credit for Rate Chosen [NEWHUD.X1149]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationLenderTotalPaidOriginatorAmount { get => _loCompensationLenderTotalPaidOriginatorAmount; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmount, value); }

        /// <summary>
        /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForGFE
        /// </summary>
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForGFE { get => _loCompensationLenderTotalPaidOriginatorAmountForGFE; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmountForGFE, value); }

        /// <summary>
        /// Gfe2010Section LoCompensationLenderTotalPaidOriginatorAmountForLOTool
        /// </summary>
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForLOTool { get => _loCompensationLenderTotalPaidOriginatorAmountForLOTool; set => SetField(ref _loCompensationLenderTotalPaidOriginatorAmountForLOTool, value); }

        /// <summary>
        /// LO Compensation - GFE -Total Lender Paid Originator Compensation [NEWHUD.X1206]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationNewHudLenderTotalPaidOriginatorAmount { get => _loCompensationNewHudLenderTotalPaidOriginatorAmount; set => SetField(ref _loCompensationNewHudLenderTotalPaidOriginatorAmount, value); }

        /// <summary>
        /// LO Compensation - GFE -Total Borrower Paid Discount Point Amount [NEWHUD.X1215]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationNewHudTotalBorrowerPaidDiscountPointAmount { get => _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount; set => SetField(ref _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount, value); }

        /// <summary>
        /// LO Compensation - GFE -Total Origination or Discount Points [NEWHUD.X1216]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? LoCompensationNewHudTotalLoCompensationAmount { get => _loCompensationNewHudTotalLoCompensationAmount; set => SetField(ref _loCompensationNewHudTotalLoCompensationAmount, value); }

        /// <summary>
        /// LO Compensation - TotalBorrower Paid Discount Point Amount Line 4 [NEWHUD.X1165]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationTotalBorrowerPaidDiscountPointAmount4 { get => _loCompensationTotalBorrowerPaidDiscountPointAmount4; set => SetField(ref _loCompensationTotalBorrowerPaidDiscountPointAmount4, value); }

        /// <summary>
        /// LO Compensation - Total Origination or Discount Points [NEWHUD.X1191]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationTotalLoCompensationAmount { get => _loCompensationTotalLoCompensationAmount; set => SetField(ref _loCompensationTotalLoCompensationAmount, value); }

        /// <summary>
        /// LO Compensation - Total Seller Paid Discount Point Amount Line 4 [NEWHUD.X1166]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? LoCompensationTotalSellerPaidDiscountPointAmount4 { get => _loCompensationTotalSellerPaidDiscountPointAmount4; set => SetField(ref _loCompensationTotalSellerPaidDiscountPointAmount4, value); }

        /// <summary>
        /// Itemize Fees on Line 802 Use LO Compensation Tool [NEWHUD.X1139]
        /// </summary>
        public bool? LoCompensationUseLoCompensationToolIndicator { get => _loCompensationUseLoCompensationToolIndicator; set => SetField(ref _loCompensationUseLoCompensationToolIndicator, value); }

        /// <summary>
        /// Projected Payment Table number of columns [NEWHUD2.XPJTCOLUMNS]
        /// </summary>
        public string ProjectedPaymentTableColumns { get => _projectedPaymentTableColumns; set => SetField(ref _projectedPaymentTableColumns, value); }

        /// <summary>
        /// Projected Payment Table Is Customized [PAYMENTTABLE.CUSTOMIZE]
        /// </summary>
        public bool? ProjectedPaymentTableCustomized { get => _projectedPaymentTableCustomized; set => SetField(ref _projectedPaymentTableCustomized, value); }

        /// <summary>
        /// Projected Payment Table [NEWHUD2.XPJT]
        /// </summary>
        public string ProjectedPaymentTableType { get => _projectedPaymentTableType; set => SetField(ref _projectedPaymentTableType, value); }

        /// <summary>
        /// Fees Line 1010 Aggregate Adjust Applied to GFE [NEWHUD.X948]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Section1000AggregateAdjust { get => _section1000AggregateAdjust; set => SetField(ref _section1000AggregateAdjust, value); }

        /// <summary>
        /// Fees Line 1010 Guarantee Fee APR [NEWHUD.X1711]
        /// </summary>
        public bool? Section1000HudGuaranteeFeeAprIndicator { get => _section1000HudGuaranteeFeeAprIndicator; set => SetField(ref _section1000HudGuaranteeFeeAprIndicator, value); }

        /// <summary>
        /// Fees Line 1104 Borr Selects [NEWHUD.X573]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator1 { get => _section1100BorrowerSelectIndicator1; set => SetField(ref _section1100BorrowerSelectIndicator1, value); }

        /// <summary>
        /// Fees Line 1102 Borr Select [NEWHUD.X646]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator10 { get => _section1100BorrowerSelectIndicator10; set => SetField(ref _section1100BorrowerSelectIndicator10, value); }

        /// <summary>
        /// Fees Line 1107 Borr Selects [NEWHUD.X574]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator2 { get => _section1100BorrowerSelectIndicator2; set => SetField(ref _section1100BorrowerSelectIndicator2, value); }

        /// <summary>
        /// Fees Line 1108 Borr Selects [NEWHUD.X575]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator3 { get => _section1100BorrowerSelectIndicator3; set => SetField(ref _section1100BorrowerSelectIndicator3, value); }

        /// <summary>
        /// Fees Line 1109 Borr Selects [NEWHUD.X576]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator4 { get => _section1100BorrowerSelectIndicator4; set => SetField(ref _section1100BorrowerSelectIndicator4, value); }

        /// <summary>
        /// Fees Line 1110 Borr Selects [NEWHUD.X577]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator5 { get => _section1100BorrowerSelectIndicator5; set => SetField(ref _section1100BorrowerSelectIndicator5, value); }

        /// <summary>
        /// Fees Line 1111 Borr Selects [NEWHUD.X578]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator6 { get => _section1100BorrowerSelectIndicator6; set => SetField(ref _section1100BorrowerSelectIndicator6, value); }

        /// <summary>
        /// Fees Line 1112 Borr Selects [NEWHUD.X579]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator7 { get => _section1100BorrowerSelectIndicator7; set => SetField(ref _section1100BorrowerSelectIndicator7, value); }

        /// <summary>
        /// Fees Line 1113 Borr Selects [NEWHUD.X580]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator8 { get => _section1100BorrowerSelectIndicator8; set => SetField(ref _section1100BorrowerSelectIndicator8, value); }

        /// <summary>
        /// Fees Line 1114 Borr Selects [NEWHUD.X581]
        /// </summary>
        public bool? Section1100BorrowerSelectIndicator9 { get => _section1100BorrowerSelectIndicator9; set => SetField(ref _section1100BorrowerSelectIndicator9, value); }

        /// <summary>
        /// Itemize Fees on Line 1101 [NEWHUD.X1017]
        /// </summary>
        public bool? Section1100ItemizeFeesIndicator { get => _section1100ItemizeFeesIndicator; set => SetField(ref _section1100ItemizeFeesIndicator, value); }

        /// <summary>
        /// Trans Tax Total for HUD-1 Page 2 [NEWHUD.X778]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section1200TotalTransferTaxes { get => _section1200TotalTransferTaxes; set => SetField(ref _section1200TotalTransferTaxes, value); }

        /// <summary>
        /// Fees Bona Fide Indicator [NEWHUD.X1067]
        /// </summary>
        public bool? Section800BonaFideIndicator { get => _section800BonaFideIndicator; set => SetField(ref _section800BonaFideIndicator, value); }

        /// <summary>
        /// Fees Borrower Paid Initial Discount Point Amount [NEWHUD.X1723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Section800BorrowerPaidInitialDiscountPointAmount { get => _section800BorrowerPaidInitialDiscountPointAmount; set => SetField(ref _section800BorrowerPaidInitialDiscountPointAmount, value); }

        /// <summary>
        /// Gfe2010Section Section800ChargeAmount [NEWHUD.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section800ChargeAmount { get => _section800ChargeAmount; set => SetField(ref _section800ChargeAmount, value); }

        /// <summary>
        /// Include Points/Credit in Orig Chrg [NEWHUD.X713]
        /// </summary>
        public StringEnumValue<CreditChargeType> Section800CreditChargeType { get => _section800CreditChargeType; set => SetField(ref _section800CreditChargeType, value); }

        /// <summary>
        /// Borr Receives Credit/Pays Fee [NEWHUD.X715]
        /// </summary>
        public StringEnumValue<IncludeOriginationPointsCreditType> Section800IncludeOriginationPointsCreditType { get => _section800IncludeOriginationPointsCreditType; set => SetField(ref _section800IncludeOriginationPointsCreditType, value); }

        /// <summary>
        /// Fees Initial Discount Point [NEWHUD.X1721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Section800InitialDiscountPoint { get => _section800InitialDiscountPoint; set => SetField(ref _section800InitialDiscountPoint, value); }

        /// <summary>
        /// Fees Initial Discount Point Additional Amount [NEWHUD.X1722]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section800InitialDiscountPointAdditionalAmount { get => _section800InitialDiscountPointAdditionalAmount; set => SetField(ref _section800InitialDiscountPointAdditionalAmount, value); }

        /// <summary>
        /// Fees Initial Discount Rate [NEWHUD.X1720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Section800InitialDiscountRate { get => _section800InitialDiscountRate; set => SetField(ref _section800InitialDiscountRate, value); }

        /// <summary>
        /// Itemize Fees on Line 801 [NEWHUD.X750]
        /// </summary>
        public bool? Section800ItemizeFeesIndicator { get => _section800ItemizeFeesIndicator; set => SetField(ref _section800ItemizeFeesIndicator, value); }

        /// <summary>
        /// Fees Line 802 Orig Charge Amt Seller [NEWHUD.X788]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section800SelChargeAmount { get => _section800SelChargeAmount; set => SetField(ref _section800SelChargeAmount, value); }

        /// <summary>
        /// Trans Tax Total HUD-1 P3 [NEWHUD.X700]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section800TotalTransferTaxes { get => _section800TotalTransferTaxes; set => SetField(ref _section800TotalTransferTaxes, value); }

        /// <summary>
        /// New HUD Homeowner Ins Total Amt [NEWHUD.X723]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section900HomeownerInsurance { get => _section900HomeownerInsurance; set => SetField(ref _section900HomeownerInsurance, value); }

        /// <summary>
        /// Fees Line 905 Fee Applied to GFE [NEWHUD.X661]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? Section900HudGfeVaFundingFee { get => _section900HudGfeVaFundingFee; set => SetField(ref _section900HudGfeVaFundingFee, value); }

        /// <summary>
        /// Projected Payment Table - Use Actual Payment Change [PAYMENTTABLE.USEACTUALPAYMENTCHANGE]
        /// </summary>
        public bool? UseActualPaymentChange { get => _useActualPaymentChange; set => SetField(ref _useActualPaymentChange, value); }
    }
}