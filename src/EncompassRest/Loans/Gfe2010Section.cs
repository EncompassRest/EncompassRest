using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Gfe2010Section : IClean
    {
        private Value<bool?> _borrowerSelectIndicator903;
        public bool? BorrowerSelectIndicator903 { get { return _borrowerSelectIndicator903; } set { _borrowerSelectIndicator903 = value; } }
        private Value<bool?> _borrowerSelectIndicator904;
        public bool? BorrowerSelectIndicator904 { get { return _borrowerSelectIndicator904; } set { _borrowerSelectIndicator904 = value; } }
        private Value<bool?> _borrowerSelectIndicator906;
        public bool? BorrowerSelectIndicator906 { get { return _borrowerSelectIndicator906; } set { _borrowerSelectIndicator906 = value; } }
        private Value<bool?> _borrowerSelectIndicator907;
        public bool? BorrowerSelectIndicator907 { get { return _borrowerSelectIndicator907; } set { _borrowerSelectIndicator907 = value; } }
        private Value<bool?> _borrowerSelectIndicator908;
        public bool? BorrowerSelectIndicator908 { get { return _borrowerSelectIndicator908; } set { _borrowerSelectIndicator908 = value; } }
        private Value<bool?> _borrowerSelectIndicator909;
        public bool? BorrowerSelectIndicator909 { get { return _borrowerSelectIndicator909; } set { _borrowerSelectIndicator909 = value; } }
        private Value<bool?> _borrowerSelectIndicator910;
        public bool? BorrowerSelectIndicator910 { get { return _borrowerSelectIndicator910; } set { _borrowerSelectIndicator910 = value; } }
        private Value<decimal?> _hudGfeLine1109;
        public decimal? HudGfeLine1109 { get { return _hudGfeLine1109; } set { _hudGfeLine1109 = value; } }
        private Value<decimal?> _hudGfeLine1110;
        public decimal? HudGfeLine1110 { get { return _hudGfeLine1110; } set { _hudGfeLine1110 = value; } }
        private Value<decimal?> _hudGfeLine1111;
        public decimal? HudGfeLine1111 { get { return _hudGfeLine1111; } set { _hudGfeLine1111 = value; } }
        private Value<decimal?> _hudGfeLine1112;
        public decimal? HudGfeLine1112 { get { return _hudGfeLine1112; } set { _hudGfeLine1112 = value; } }
        private Value<decimal?> _hudGfeLine1113;
        public decimal? HudGfeLine1113 { get { return _hudGfeLine1113; } set { _hudGfeLine1113 = value; } }
        private Value<decimal?> _hudGfeLine1114;
        public decimal? HudGfeLine1114 { get { return _hudGfeLine1114; } set { _hudGfeLine1114 = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _line1001;
        public string Line1001 { get { return _line1001; } set { _line1001 = value; } }
        private Value<decimal?> _line1001BorPaidTotal;
        public decimal? Line1001BorPaidTotal { get { return _line1001BorPaidTotal; } set { _line1001BorPaidTotal = value; } }
        private Value<string> _line1002;
        public string Line1002 { get { return _line1002; } set { _line1002 = value; } }
        private Value<string> _line1003;
        public string Line1003 { get { return _line1003; } set { _line1003 = value; } }
        private Value<string> _line1004;
        public string Line1004 { get { return _line1004; } set { _line1004 = value; } }
        private Value<string> _line1005;
        public string Line1005 { get { return _line1005; } set { _line1005 = value; } }
        private Value<string> _line1006;
        public string Line1006 { get { return _line1006; } set { _line1006 = value; } }
        private Value<string> _line1007;
        public string Line1007 { get { return _line1007; } set { _line1007 = value; } }
        private Value<string> _line1008;
        public string Line1008 { get { return _line1008; } set { _line1008 = value; } }
        private Value<string> _line1009;
        public string Line1009 { get { return _line1009; } set { _line1009 = value; } }
        private Value<string> _line1010;
        public string Line1010 { get { return _line1010; } set { _line1010 = value; } }
        private Value<string> _line1011;
        public string Line1011 { get { return _line1011; } set { _line1011 = value; } }
        private Value<string> _line1101;
        public string Line1101 { get { return _line1101; } set { _line1101 = value; } }
        private Value<decimal?> _line1101BorPaidTotal;
        public decimal? Line1101BorPaidTotal { get { return _line1101BorPaidTotal; } set { _line1101BorPaidTotal = value; } }
        private Value<decimal?> _line1101SellerPaidAtoF;
        public decimal? Line1101SellerPaidAtoF { get { return _line1101SellerPaidAtoF; } set { _line1101SellerPaidAtoF = value; } }
        private Value<string> _line1102;
        public string Line1102 { get { return _line1102; } set { _line1102 = value; } }
        private Value<string> _line1103;
        public string Line1103 { get { return _line1103; } set { _line1103 = value; } }
        private Value<decimal?> _line1103PTAAmount;
        public decimal? Line1103PTAAmount { get { return _line1103PTAAmount; } set { _line1103PTAAmount = value; } }
        private Value<string> _line1104;
        public string Line1104 { get { return _line1104; } set { _line1104 = value; } }
        private Value<decimal?> _line1104PTAAmount;
        public decimal? Line1104PTAAmount { get { return _line1104PTAAmount; } set { _line1104PTAAmount = value; } }
        private Value<string> _line1107;
        public string Line1107 { get { return _line1107; } set { _line1107 = value; } }
        private Value<string> _line1108;
        public string Line1108 { get { return _line1108; } set { _line1108 = value; } }
        private Value<string> _line1109;
        public string Line1109 { get { return _line1109; } set { _line1109 = value; } }
        private Value<string> _line1110;
        public string Line1110 { get { return _line1110; } set { _line1110 = value; } }
        private Value<string> _line1115;
        public string Line1115 { get { return _line1115; } set { _line1115 = value; } }
        private Value<string> _line1116;
        public string Line1116 { get { return _line1116; } set { _line1116 = value; } }
        private Value<decimal?> _line1201BorPaidTotal;
        public decimal? Line1201BorPaidTotal { get { return _line1201BorPaidTotal; } set { _line1201BorPaidTotal = value; } }
        private Value<string> _line1209;
        public string Line1209 { get { return _line1209; } set { _line1209 = value; } }
        private Value<string> _line1210;
        public string Line1210 { get { return _line1210; } set { _line1210 = value; } }
        private Value<decimal?> _line1301BorPaidTotal;
        public decimal? Line1301BorPaidTotal { get { return _line1301BorPaidTotal; } set { _line1301BorPaidTotal = value; } }
        private Value<string> _line1302;
        public string Line1302 { get { return _line1302; } set { _line1302 = value; } }
        private Value<string> _line1310;
        public string Line1310 { get { return _line1310; } set { _line1310 = value; } }
        private Value<string> _line1311;
        public string Line1311 { get { return _line1311; } set { _line1311 = value; } }
        private Value<string> _line1312;
        public string Line1312 { get { return _line1312; } set { _line1312 = value; } }
        private Value<string> _line1313;
        public string Line1313 { get { return _line1313; } set { _line1313 = value; } }
        private Value<string> _line1314;
        public string Line1314 { get { return _line1314; } set { _line1314 = value; } }
        private Value<string> _line1315;
        public string Line1315 { get { return _line1315; } set { _line1315 = value; } }
        private Value<string> _line1316;
        public string Line1316 { get { return _line1316; } set { _line1316 = value; } }
        private Value<string> _line1317;
        public string Line1317 { get { return _line1317; } set { _line1317 = value; } }
        private Value<string> _line1318;
        public string Line1318 { get { return _line1318; } set { _line1318 = value; } }
        private Value<string> _line1319;
        public string Line1319 { get { return _line1319; } set { _line1319 = value; } }
        private Value<string> _line1320;
        public string Line1320 { get { return _line1320; } set { _line1320 = value; } }
        private Value<string> _line701;
        public string Line701 { get { return _line701; } set { _line701 = value; } }
        private Value<string> _line702;
        public string Line702 { get { return _line702; } set { _line702 = value; } }
        private Value<string> _line703;
        public string Line703 { get { return _line703; } set { _line703 = value; } }
        private Value<string> _line704;
        public string Line704 { get { return _line704; } set { _line704 = value; } }
        private Value<string> _line803x;
        public string Line803x { get { return _line803x; } set { _line803x = value; } }
        private Value<string> _line807Company;
        public string Line807Company { get { return _line807Company; } set { _line807Company = value; } }
        private Value<string> _line808;
        public string Line808 { get { return _line808; } set { _line808 = value; } }
        private Value<string> _line809;
        public string Line809 { get { return _line809; } set { _line809 = value; } }
        private Value<string> _line810;
        public string Line810 { get { return _line810; } set { _line810 = value; } }
        private Value<string> _line811;
        public string Line811 { get { return _line811; } set { _line811 = value; } }
        private Value<string> _line812;
        public string Line812 { get { return _line812; } set { _line812 = value; } }
        private Value<string> _line819;
        public string Line819 { get { return _line819; } set { _line819 = value; } }
        private Value<string> _line820;
        public string Line820 { get { return _line820; } set { _line820 = value; } }
        private Value<string> _line821;
        public string Line821 { get { return _line821; } set { _line821 = value; } }
        private Value<string> _line822;
        public string Line822 { get { return _line822; } set { _line822 = value; } }
        private Value<string> _line823;
        public string Line823 { get { return _line823; } set { _line823 = value; } }
        private Value<string> _line824;
        public string Line824 { get { return _line824; } set { _line824 = value; } }
        private Value<string> _line825;
        public string Line825 { get { return _line825; } set { _line825 = value; } }
        private Value<string> _line826;
        public string Line826 { get { return _line826; } set { _line826 = value; } }
        private Value<string> _line827;
        public string Line827 { get { return _line827; } set { _line827 = value; } }
        private Value<string> _line828;
        public string Line828 { get { return _line828; } set { _line828 = value; } }
        private Value<string> _line829;
        public string Line829 { get { return _line829; } set { _line829 = value; } }
        private Value<string> _line830;
        public string Line830 { get { return _line830; } set { _line830 = value; } }
        private Value<string> _line831;
        public string Line831 { get { return _line831; } set { _line831 = value; } }
        private Value<string> _line832;
        public string Line832 { get { return _line832; } set { _line832 = value; } }
        private Value<string> _line833;
        public string Line833 { get { return _line833; } set { _line833 = value; } }
        private Value<string> _line834;
        public string Line834 { get { return _line834; } set { _line834 = value; } }
        private Value<string> _line835;
        public string Line835 { get { return _line835; } set { _line835 = value; } }
        private Value<string> _line904;
        public string Line904 { get { return _line904; } set { _line904 = value; } }
        private Value<string> _line909;
        public string Line909 { get { return _line909; } set { _line909 = value; } }
        private Value<string> _line910;
        public string Line910 { get { return _line910; } set { _line910 = value; } }
        private Value<string> _line911;
        public string Line911 { get { return _line911; } set { _line911 = value; } }
        private Value<string> _line912;
        public string Line912 { get { return _line912; } set { _line912 = value; } }
        private Value<bool?> _loanTermTableCustomized;
        public bool? LoanTermTableCustomized { get { return _loanTermTableCustomized; } set { _loanTermTableCustomized = value; } }
        private Value<bool?> _loCompensationItemizeFeesIndicator;
        public bool? LoCompensationItemizeFeesIndicator { get { return _loCompensationItemizeFeesIndicator; } set { _loCompensationItemizeFeesIndicator = value; } }
        private Value<decimal?> _loCompensationLenderTotalPaidOriginatorAmount;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmount { get { return _loCompensationLenderTotalPaidOriginatorAmount; } set { _loCompensationLenderTotalPaidOriginatorAmount = value; } }
        private Value<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForGFE;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForGFE { get { return _loCompensationLenderTotalPaidOriginatorAmountForGFE; } set { _loCompensationLenderTotalPaidOriginatorAmountForGFE = value; } }
        private Value<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForLOTool;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForLOTool { get { return _loCompensationLenderTotalPaidOriginatorAmountForLOTool; } set { _loCompensationLenderTotalPaidOriginatorAmountForLOTool = value; } }
        private Value<decimal?> _loCompensationNewHudLenderTotalPaidOriginatorAmount;
        public decimal? LoCompensationNewHudLenderTotalPaidOriginatorAmount { get { return _loCompensationNewHudLenderTotalPaidOriginatorAmount; } set { _loCompensationNewHudLenderTotalPaidOriginatorAmount = value; } }
        private Value<decimal?> _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount;
        public decimal? LoCompensationNewHudTotalBorrowerPaidDiscountPointAmount { get { return _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount; } set { _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount = value; } }
        private Value<decimal?> _loCompensationNewHudTotalLoCompensationAmount;
        public decimal? LoCompensationNewHudTotalLoCompensationAmount { get { return _loCompensationNewHudTotalLoCompensationAmount; } set { _loCompensationNewHudTotalLoCompensationAmount = value; } }
        private Value<decimal?> _loCompensationTotalBorrowerPaidDiscountPointAmount4;
        public decimal? LoCompensationTotalBorrowerPaidDiscountPointAmount4 { get { return _loCompensationTotalBorrowerPaidDiscountPointAmount4; } set { _loCompensationTotalBorrowerPaidDiscountPointAmount4 = value; } }
        private Value<decimal?> _loCompensationTotalLoCompensationAmount;
        public decimal? LoCompensationTotalLoCompensationAmount { get { return _loCompensationTotalLoCompensationAmount; } set { _loCompensationTotalLoCompensationAmount = value; } }
        private Value<decimal?> _loCompensationTotalSellerPaidDiscountPointAmount4;
        public decimal? LoCompensationTotalSellerPaidDiscountPointAmount4 { get { return _loCompensationTotalSellerPaidDiscountPointAmount4; } set { _loCompensationTotalSellerPaidDiscountPointAmount4 = value; } }
        private Value<bool?> _loCompensationUseLoCompensationToolIndicator;
        public bool? LoCompensationUseLoCompensationToolIndicator { get { return _loCompensationUseLoCompensationToolIndicator; } set { _loCompensationUseLoCompensationToolIndicator = value; } }
        private Value<string> _projectedPaymentTableColumns;
        public string ProjectedPaymentTableColumns { get { return _projectedPaymentTableColumns; } set { _projectedPaymentTableColumns = value; } }
        private Value<bool?> _projectedPaymentTableCustomized;
        public bool? ProjectedPaymentTableCustomized { get { return _projectedPaymentTableCustomized; } set { _projectedPaymentTableCustomized = value; } }
        private Value<string> _projectedPaymentTableType;
        public string ProjectedPaymentTableType { get { return _projectedPaymentTableType; } set { _projectedPaymentTableType = value; } }
        private Value<decimal?> _section1000AggregateAdjust;
        public decimal? Section1000AggregateAdjust { get { return _section1000AggregateAdjust; } set { _section1000AggregateAdjust = value; } }
        private Value<bool?> _section1000HudGuaranteeFeeAprIndicator;
        public bool? Section1000HudGuaranteeFeeAprIndicator { get { return _section1000HudGuaranteeFeeAprIndicator; } set { _section1000HudGuaranteeFeeAprIndicator = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator1;
        public bool? Section1100BorrowerSelectIndicator1 { get { return _section1100BorrowerSelectIndicator1; } set { _section1100BorrowerSelectIndicator1 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator10;
        public bool? Section1100BorrowerSelectIndicator10 { get { return _section1100BorrowerSelectIndicator10; } set { _section1100BorrowerSelectIndicator10 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator2;
        public bool? Section1100BorrowerSelectIndicator2 { get { return _section1100BorrowerSelectIndicator2; } set { _section1100BorrowerSelectIndicator2 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator3;
        public bool? Section1100BorrowerSelectIndicator3 { get { return _section1100BorrowerSelectIndicator3; } set { _section1100BorrowerSelectIndicator3 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator4;
        public bool? Section1100BorrowerSelectIndicator4 { get { return _section1100BorrowerSelectIndicator4; } set { _section1100BorrowerSelectIndicator4 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator5;
        public bool? Section1100BorrowerSelectIndicator5 { get { return _section1100BorrowerSelectIndicator5; } set { _section1100BorrowerSelectIndicator5 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator6;
        public bool? Section1100BorrowerSelectIndicator6 { get { return _section1100BorrowerSelectIndicator6; } set { _section1100BorrowerSelectIndicator6 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator7;
        public bool? Section1100BorrowerSelectIndicator7 { get { return _section1100BorrowerSelectIndicator7; } set { _section1100BorrowerSelectIndicator7 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator8;
        public bool? Section1100BorrowerSelectIndicator8 { get { return _section1100BorrowerSelectIndicator8; } set { _section1100BorrowerSelectIndicator8 = value; } }
        private Value<bool?> _section1100BorrowerSelectIndicator9;
        public bool? Section1100BorrowerSelectIndicator9 { get { return _section1100BorrowerSelectIndicator9; } set { _section1100BorrowerSelectIndicator9 = value; } }
        private Value<bool?> _section1100ItemizeFeesIndicator;
        public bool? Section1100ItemizeFeesIndicator { get { return _section1100ItemizeFeesIndicator; } set { _section1100ItemizeFeesIndicator = value; } }
        private Value<decimal?> _section1200TotalTransferTaxes;
        public decimal? Section1200TotalTransferTaxes { get { return _section1200TotalTransferTaxes; } set { _section1200TotalTransferTaxes = value; } }
        private Value<bool?> _section800BonaFideIndicator;
        public bool? Section800BonaFideIndicator { get { return _section800BonaFideIndicator; } set { _section800BonaFideIndicator = value; } }
        private Value<decimal?> _section800BorrowerPaidInitialDiscountPointAmount;
        public decimal? Section800BorrowerPaidInitialDiscountPointAmount { get { return _section800BorrowerPaidInitialDiscountPointAmount; } set { _section800BorrowerPaidInitialDiscountPointAmount = value; } }
        private Value<decimal?> _section800ChargeAmount;
        public decimal? Section800ChargeAmount { get { return _section800ChargeAmount; } set { _section800ChargeAmount = value; } }
        private Value<string> _section800CreditChargeType;
        public string Section800CreditChargeType { get { return _section800CreditChargeType; } set { _section800CreditChargeType = value; } }
        private Value<string> _section800IncludeOriginationPointsCreditType;
        public string Section800IncludeOriginationPointsCreditType { get { return _section800IncludeOriginationPointsCreditType; } set { _section800IncludeOriginationPointsCreditType = value; } }
        private Value<decimal?> _section800InitialDiscountPoint;
        public decimal? Section800InitialDiscountPoint { get { return _section800InitialDiscountPoint; } set { _section800InitialDiscountPoint = value; } }
        private Value<decimal?> _section800InitialDiscountPointAdditionalAmount;
        public decimal? Section800InitialDiscountPointAdditionalAmount { get { return _section800InitialDiscountPointAdditionalAmount; } set { _section800InitialDiscountPointAdditionalAmount = value; } }
        private Value<decimal?> _section800InitialDiscountRate;
        public decimal? Section800InitialDiscountRate { get { return _section800InitialDiscountRate; } set { _section800InitialDiscountRate = value; } }
        private Value<bool?> _section800ItemizeFeesIndicator;
        public bool? Section800ItemizeFeesIndicator { get { return _section800ItemizeFeesIndicator; } set { _section800ItemizeFeesIndicator = value; } }
        private Value<decimal?> _section800SelChargeAmount;
        public decimal? Section800SelChargeAmount { get { return _section800SelChargeAmount; } set { _section800SelChargeAmount = value; } }
        private Value<decimal?> _section800TotalTransferTaxes;
        public decimal? Section800TotalTransferTaxes { get { return _section800TotalTransferTaxes; } set { _section800TotalTransferTaxes = value; } }
        private Value<decimal?> _section900HomeownerInsurance;
        public decimal? Section900HomeownerInsurance { get { return _section900HomeownerInsurance; } set { _section900HomeownerInsurance = value; } }
        private Value<decimal?> _section900HudGfeVaFundingFee;
        public decimal? Section900HudGfeVaFundingFee { get { return _section900HudGfeVaFundingFee; } set { _section900HudGfeVaFundingFee = value; } }
        private Value<bool?> _useActualPaymentChange;
        public bool? UseActualPaymentChange { get { return _useActualPaymentChange; } set { _useActualPaymentChange = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _borrowerSelectIndicator903.Clean
                    && _borrowerSelectIndicator904.Clean
                    && _borrowerSelectIndicator906.Clean
                    && _borrowerSelectIndicator907.Clean
                    && _borrowerSelectIndicator908.Clean
                    && _borrowerSelectIndicator909.Clean
                    && _borrowerSelectIndicator910.Clean
                    && _hudGfeLine1109.Clean
                    && _hudGfeLine1110.Clean
                    && _hudGfeLine1111.Clean
                    && _hudGfeLine1112.Clean
                    && _hudGfeLine1113.Clean
                    && _hudGfeLine1114.Clean
                    && _id.Clean
                    && _line1001.Clean
                    && _line1001BorPaidTotal.Clean
                    && _line1002.Clean
                    && _line1003.Clean
                    && _line1004.Clean
                    && _line1005.Clean
                    && _line1006.Clean
                    && _line1007.Clean
                    && _line1008.Clean
                    && _line1009.Clean
                    && _line1010.Clean
                    && _line1011.Clean
                    && _line1101.Clean
                    && _line1101BorPaidTotal.Clean
                    && _line1101SellerPaidAtoF.Clean
                    && _line1102.Clean
                    && _line1103.Clean
                    && _line1103PTAAmount.Clean
                    && _line1104.Clean
                    && _line1104PTAAmount.Clean
                    && _line1107.Clean
                    && _line1108.Clean
                    && _line1109.Clean
                    && _line1110.Clean
                    && _line1115.Clean
                    && _line1116.Clean
                    && _line1201BorPaidTotal.Clean
                    && _line1209.Clean
                    && _line1210.Clean
                    && _line1301BorPaidTotal.Clean
                    && _line1302.Clean
                    && _line1310.Clean
                    && _line1311.Clean
                    && _line1312.Clean
                    && _line1313.Clean
                    && _line1314.Clean
                    && _line1315.Clean
                    && _line1316.Clean
                    && _line1317.Clean
                    && _line1318.Clean
                    && _line1319.Clean
                    && _line1320.Clean
                    && _line701.Clean
                    && _line702.Clean
                    && _line703.Clean
                    && _line704.Clean
                    && _line803x.Clean
                    && _line807Company.Clean
                    && _line808.Clean
                    && _line809.Clean
                    && _line810.Clean
                    && _line811.Clean
                    && _line812.Clean
                    && _line819.Clean
                    && _line820.Clean
                    && _line821.Clean
                    && _line822.Clean
                    && _line823.Clean
                    && _line824.Clean
                    && _line825.Clean
                    && _line826.Clean
                    && _line827.Clean
                    && _line828.Clean
                    && _line829.Clean
                    && _line830.Clean
                    && _line831.Clean
                    && _line832.Clean
                    && _line833.Clean
                    && _line834.Clean
                    && _line835.Clean
                    && _line904.Clean
                    && _line909.Clean
                    && _line910.Clean
                    && _line911.Clean
                    && _line912.Clean
                    && _loanTermTableCustomized.Clean
                    && _loCompensationItemizeFeesIndicator.Clean
                    && _loCompensationLenderTotalPaidOriginatorAmount.Clean
                    && _loCompensationLenderTotalPaidOriginatorAmountForGFE.Clean
                    && _loCompensationLenderTotalPaidOriginatorAmountForLOTool.Clean
                    && _loCompensationNewHudLenderTotalPaidOriginatorAmount.Clean
                    && _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount.Clean
                    && _loCompensationNewHudTotalLoCompensationAmount.Clean
                    && _loCompensationTotalBorrowerPaidDiscountPointAmount4.Clean
                    && _loCompensationTotalLoCompensationAmount.Clean
                    && _loCompensationTotalSellerPaidDiscountPointAmount4.Clean
                    && _loCompensationUseLoCompensationToolIndicator.Clean
                    && _projectedPaymentTableColumns.Clean
                    && _projectedPaymentTableCustomized.Clean
                    && _projectedPaymentTableType.Clean
                    && _section1000AggregateAdjust.Clean
                    && _section1000HudGuaranteeFeeAprIndicator.Clean
                    && _section1100BorrowerSelectIndicator1.Clean
                    && _section1100BorrowerSelectIndicator10.Clean
                    && _section1100BorrowerSelectIndicator2.Clean
                    && _section1100BorrowerSelectIndicator3.Clean
                    && _section1100BorrowerSelectIndicator4.Clean
                    && _section1100BorrowerSelectIndicator5.Clean
                    && _section1100BorrowerSelectIndicator6.Clean
                    && _section1100BorrowerSelectIndicator7.Clean
                    && _section1100BorrowerSelectIndicator8.Clean
                    && _section1100BorrowerSelectIndicator9.Clean
                    && _section1100ItemizeFeesIndicator.Clean
                    && _section1200TotalTransferTaxes.Clean
                    && _section800BonaFideIndicator.Clean
                    && _section800BorrowerPaidInitialDiscountPointAmount.Clean
                    && _section800ChargeAmount.Clean
                    && _section800CreditChargeType.Clean
                    && _section800IncludeOriginationPointsCreditType.Clean
                    && _section800InitialDiscountPoint.Clean
                    && _section800InitialDiscountPointAdditionalAmount.Clean
                    && _section800InitialDiscountRate.Clean
                    && _section800ItemizeFeesIndicator.Clean
                    && _section800SelChargeAmount.Clean
                    && _section800TotalTransferTaxes.Clean
                    && _section900HomeownerInsurance.Clean
                    && _section900HudGfeVaFundingFee.Clean
                    && _useActualPaymentChange.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var borrowerSelectIndicator903 = _borrowerSelectIndicator903; borrowerSelectIndicator903.Clean = value; _borrowerSelectIndicator903 = borrowerSelectIndicator903;
                var borrowerSelectIndicator904 = _borrowerSelectIndicator904; borrowerSelectIndicator904.Clean = value; _borrowerSelectIndicator904 = borrowerSelectIndicator904;
                var borrowerSelectIndicator906 = _borrowerSelectIndicator906; borrowerSelectIndicator906.Clean = value; _borrowerSelectIndicator906 = borrowerSelectIndicator906;
                var borrowerSelectIndicator907 = _borrowerSelectIndicator907; borrowerSelectIndicator907.Clean = value; _borrowerSelectIndicator907 = borrowerSelectIndicator907;
                var borrowerSelectIndicator908 = _borrowerSelectIndicator908; borrowerSelectIndicator908.Clean = value; _borrowerSelectIndicator908 = borrowerSelectIndicator908;
                var borrowerSelectIndicator909 = _borrowerSelectIndicator909; borrowerSelectIndicator909.Clean = value; _borrowerSelectIndicator909 = borrowerSelectIndicator909;
                var borrowerSelectIndicator910 = _borrowerSelectIndicator910; borrowerSelectIndicator910.Clean = value; _borrowerSelectIndicator910 = borrowerSelectIndicator910;
                var hudGfeLine1109 = _hudGfeLine1109; hudGfeLine1109.Clean = value; _hudGfeLine1109 = hudGfeLine1109;
                var hudGfeLine1110 = _hudGfeLine1110; hudGfeLine1110.Clean = value; _hudGfeLine1110 = hudGfeLine1110;
                var hudGfeLine1111 = _hudGfeLine1111; hudGfeLine1111.Clean = value; _hudGfeLine1111 = hudGfeLine1111;
                var hudGfeLine1112 = _hudGfeLine1112; hudGfeLine1112.Clean = value; _hudGfeLine1112 = hudGfeLine1112;
                var hudGfeLine1113 = _hudGfeLine1113; hudGfeLine1113.Clean = value; _hudGfeLine1113 = hudGfeLine1113;
                var hudGfeLine1114 = _hudGfeLine1114; hudGfeLine1114.Clean = value; _hudGfeLine1114 = hudGfeLine1114;
                var id = _id; id.Clean = value; _id = id;
                var line1001 = _line1001; line1001.Clean = value; _line1001 = line1001;
                var line1001BorPaidTotal = _line1001BorPaidTotal; line1001BorPaidTotal.Clean = value; _line1001BorPaidTotal = line1001BorPaidTotal;
                var line1002 = _line1002; line1002.Clean = value; _line1002 = line1002;
                var line1003 = _line1003; line1003.Clean = value; _line1003 = line1003;
                var line1004 = _line1004; line1004.Clean = value; _line1004 = line1004;
                var line1005 = _line1005; line1005.Clean = value; _line1005 = line1005;
                var line1006 = _line1006; line1006.Clean = value; _line1006 = line1006;
                var line1007 = _line1007; line1007.Clean = value; _line1007 = line1007;
                var line1008 = _line1008; line1008.Clean = value; _line1008 = line1008;
                var line1009 = _line1009; line1009.Clean = value; _line1009 = line1009;
                var line1010 = _line1010; line1010.Clean = value; _line1010 = line1010;
                var line1011 = _line1011; line1011.Clean = value; _line1011 = line1011;
                var line1101 = _line1101; line1101.Clean = value; _line1101 = line1101;
                var line1101BorPaidTotal = _line1101BorPaidTotal; line1101BorPaidTotal.Clean = value; _line1101BorPaidTotal = line1101BorPaidTotal;
                var line1101SellerPaidAtoF = _line1101SellerPaidAtoF; line1101SellerPaidAtoF.Clean = value; _line1101SellerPaidAtoF = line1101SellerPaidAtoF;
                var line1102 = _line1102; line1102.Clean = value; _line1102 = line1102;
                var line1103 = _line1103; line1103.Clean = value; _line1103 = line1103;
                var line1103PTAAmount = _line1103PTAAmount; line1103PTAAmount.Clean = value; _line1103PTAAmount = line1103PTAAmount;
                var line1104 = _line1104; line1104.Clean = value; _line1104 = line1104;
                var line1104PTAAmount = _line1104PTAAmount; line1104PTAAmount.Clean = value; _line1104PTAAmount = line1104PTAAmount;
                var line1107 = _line1107; line1107.Clean = value; _line1107 = line1107;
                var line1108 = _line1108; line1108.Clean = value; _line1108 = line1108;
                var line1109 = _line1109; line1109.Clean = value; _line1109 = line1109;
                var line1110 = _line1110; line1110.Clean = value; _line1110 = line1110;
                var line1115 = _line1115; line1115.Clean = value; _line1115 = line1115;
                var line1116 = _line1116; line1116.Clean = value; _line1116 = line1116;
                var line1201BorPaidTotal = _line1201BorPaidTotal; line1201BorPaidTotal.Clean = value; _line1201BorPaidTotal = line1201BorPaidTotal;
                var line1209 = _line1209; line1209.Clean = value; _line1209 = line1209;
                var line1210 = _line1210; line1210.Clean = value; _line1210 = line1210;
                var line1301BorPaidTotal = _line1301BorPaidTotal; line1301BorPaidTotal.Clean = value; _line1301BorPaidTotal = line1301BorPaidTotal;
                var line1302 = _line1302; line1302.Clean = value; _line1302 = line1302;
                var line1310 = _line1310; line1310.Clean = value; _line1310 = line1310;
                var line1311 = _line1311; line1311.Clean = value; _line1311 = line1311;
                var line1312 = _line1312; line1312.Clean = value; _line1312 = line1312;
                var line1313 = _line1313; line1313.Clean = value; _line1313 = line1313;
                var line1314 = _line1314; line1314.Clean = value; _line1314 = line1314;
                var line1315 = _line1315; line1315.Clean = value; _line1315 = line1315;
                var line1316 = _line1316; line1316.Clean = value; _line1316 = line1316;
                var line1317 = _line1317; line1317.Clean = value; _line1317 = line1317;
                var line1318 = _line1318; line1318.Clean = value; _line1318 = line1318;
                var line1319 = _line1319; line1319.Clean = value; _line1319 = line1319;
                var line1320 = _line1320; line1320.Clean = value; _line1320 = line1320;
                var line701 = _line701; line701.Clean = value; _line701 = line701;
                var line702 = _line702; line702.Clean = value; _line702 = line702;
                var line703 = _line703; line703.Clean = value; _line703 = line703;
                var line704 = _line704; line704.Clean = value; _line704 = line704;
                var line803x = _line803x; line803x.Clean = value; _line803x = line803x;
                var line807Company = _line807Company; line807Company.Clean = value; _line807Company = line807Company;
                var line808 = _line808; line808.Clean = value; _line808 = line808;
                var line809 = _line809; line809.Clean = value; _line809 = line809;
                var line810 = _line810; line810.Clean = value; _line810 = line810;
                var line811 = _line811; line811.Clean = value; _line811 = line811;
                var line812 = _line812; line812.Clean = value; _line812 = line812;
                var line819 = _line819; line819.Clean = value; _line819 = line819;
                var line820 = _line820; line820.Clean = value; _line820 = line820;
                var line821 = _line821; line821.Clean = value; _line821 = line821;
                var line822 = _line822; line822.Clean = value; _line822 = line822;
                var line823 = _line823; line823.Clean = value; _line823 = line823;
                var line824 = _line824; line824.Clean = value; _line824 = line824;
                var line825 = _line825; line825.Clean = value; _line825 = line825;
                var line826 = _line826; line826.Clean = value; _line826 = line826;
                var line827 = _line827; line827.Clean = value; _line827 = line827;
                var line828 = _line828; line828.Clean = value; _line828 = line828;
                var line829 = _line829; line829.Clean = value; _line829 = line829;
                var line830 = _line830; line830.Clean = value; _line830 = line830;
                var line831 = _line831; line831.Clean = value; _line831 = line831;
                var line832 = _line832; line832.Clean = value; _line832 = line832;
                var line833 = _line833; line833.Clean = value; _line833 = line833;
                var line834 = _line834; line834.Clean = value; _line834 = line834;
                var line835 = _line835; line835.Clean = value; _line835 = line835;
                var line904 = _line904; line904.Clean = value; _line904 = line904;
                var line909 = _line909; line909.Clean = value; _line909 = line909;
                var line910 = _line910; line910.Clean = value; _line910 = line910;
                var line911 = _line911; line911.Clean = value; _line911 = line911;
                var line912 = _line912; line912.Clean = value; _line912 = line912;
                var loanTermTableCustomized = _loanTermTableCustomized; loanTermTableCustomized.Clean = value; _loanTermTableCustomized = loanTermTableCustomized;
                var loCompensationItemizeFeesIndicator = _loCompensationItemizeFeesIndicator; loCompensationItemizeFeesIndicator.Clean = value; _loCompensationItemizeFeesIndicator = loCompensationItemizeFeesIndicator;
                var loCompensationLenderTotalPaidOriginatorAmount = _loCompensationLenderTotalPaidOriginatorAmount; loCompensationLenderTotalPaidOriginatorAmount.Clean = value; _loCompensationLenderTotalPaidOriginatorAmount = loCompensationLenderTotalPaidOriginatorAmount;
                var loCompensationLenderTotalPaidOriginatorAmountForGFE = _loCompensationLenderTotalPaidOriginatorAmountForGFE; loCompensationLenderTotalPaidOriginatorAmountForGFE.Clean = value; _loCompensationLenderTotalPaidOriginatorAmountForGFE = loCompensationLenderTotalPaidOriginatorAmountForGFE;
                var loCompensationLenderTotalPaidOriginatorAmountForLOTool = _loCompensationLenderTotalPaidOriginatorAmountForLOTool; loCompensationLenderTotalPaidOriginatorAmountForLOTool.Clean = value; _loCompensationLenderTotalPaidOriginatorAmountForLOTool = loCompensationLenderTotalPaidOriginatorAmountForLOTool;
                var loCompensationNewHudLenderTotalPaidOriginatorAmount = _loCompensationNewHudLenderTotalPaidOriginatorAmount; loCompensationNewHudLenderTotalPaidOriginatorAmount.Clean = value; _loCompensationNewHudLenderTotalPaidOriginatorAmount = loCompensationNewHudLenderTotalPaidOriginatorAmount;
                var loCompensationNewHudTotalBorrowerPaidDiscountPointAmount = _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount; loCompensationNewHudTotalBorrowerPaidDiscountPointAmount.Clean = value; _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount = loCompensationNewHudTotalBorrowerPaidDiscountPointAmount;
                var loCompensationNewHudTotalLoCompensationAmount = _loCompensationNewHudTotalLoCompensationAmount; loCompensationNewHudTotalLoCompensationAmount.Clean = value; _loCompensationNewHudTotalLoCompensationAmount = loCompensationNewHudTotalLoCompensationAmount;
                var loCompensationTotalBorrowerPaidDiscountPointAmount4 = _loCompensationTotalBorrowerPaidDiscountPointAmount4; loCompensationTotalBorrowerPaidDiscountPointAmount4.Clean = value; _loCompensationTotalBorrowerPaidDiscountPointAmount4 = loCompensationTotalBorrowerPaidDiscountPointAmount4;
                var loCompensationTotalLoCompensationAmount = _loCompensationTotalLoCompensationAmount; loCompensationTotalLoCompensationAmount.Clean = value; _loCompensationTotalLoCompensationAmount = loCompensationTotalLoCompensationAmount;
                var loCompensationTotalSellerPaidDiscountPointAmount4 = _loCompensationTotalSellerPaidDiscountPointAmount4; loCompensationTotalSellerPaidDiscountPointAmount4.Clean = value; _loCompensationTotalSellerPaidDiscountPointAmount4 = loCompensationTotalSellerPaidDiscountPointAmount4;
                var loCompensationUseLoCompensationToolIndicator = _loCompensationUseLoCompensationToolIndicator; loCompensationUseLoCompensationToolIndicator.Clean = value; _loCompensationUseLoCompensationToolIndicator = loCompensationUseLoCompensationToolIndicator;
                var projectedPaymentTableColumns = _projectedPaymentTableColumns; projectedPaymentTableColumns.Clean = value; _projectedPaymentTableColumns = projectedPaymentTableColumns;
                var projectedPaymentTableCustomized = _projectedPaymentTableCustomized; projectedPaymentTableCustomized.Clean = value; _projectedPaymentTableCustomized = projectedPaymentTableCustomized;
                var projectedPaymentTableType = _projectedPaymentTableType; projectedPaymentTableType.Clean = value; _projectedPaymentTableType = projectedPaymentTableType;
                var section1000AggregateAdjust = _section1000AggregateAdjust; section1000AggregateAdjust.Clean = value; _section1000AggregateAdjust = section1000AggregateAdjust;
                var section1000HudGuaranteeFeeAprIndicator = _section1000HudGuaranteeFeeAprIndicator; section1000HudGuaranteeFeeAprIndicator.Clean = value; _section1000HudGuaranteeFeeAprIndicator = section1000HudGuaranteeFeeAprIndicator;
                var section1100BorrowerSelectIndicator1 = _section1100BorrowerSelectIndicator1; section1100BorrowerSelectIndicator1.Clean = value; _section1100BorrowerSelectIndicator1 = section1100BorrowerSelectIndicator1;
                var section1100BorrowerSelectIndicator10 = _section1100BorrowerSelectIndicator10; section1100BorrowerSelectIndicator10.Clean = value; _section1100BorrowerSelectIndicator10 = section1100BorrowerSelectIndicator10;
                var section1100BorrowerSelectIndicator2 = _section1100BorrowerSelectIndicator2; section1100BorrowerSelectIndicator2.Clean = value; _section1100BorrowerSelectIndicator2 = section1100BorrowerSelectIndicator2;
                var section1100BorrowerSelectIndicator3 = _section1100BorrowerSelectIndicator3; section1100BorrowerSelectIndicator3.Clean = value; _section1100BorrowerSelectIndicator3 = section1100BorrowerSelectIndicator3;
                var section1100BorrowerSelectIndicator4 = _section1100BorrowerSelectIndicator4; section1100BorrowerSelectIndicator4.Clean = value; _section1100BorrowerSelectIndicator4 = section1100BorrowerSelectIndicator4;
                var section1100BorrowerSelectIndicator5 = _section1100BorrowerSelectIndicator5; section1100BorrowerSelectIndicator5.Clean = value; _section1100BorrowerSelectIndicator5 = section1100BorrowerSelectIndicator5;
                var section1100BorrowerSelectIndicator6 = _section1100BorrowerSelectIndicator6; section1100BorrowerSelectIndicator6.Clean = value; _section1100BorrowerSelectIndicator6 = section1100BorrowerSelectIndicator6;
                var section1100BorrowerSelectIndicator7 = _section1100BorrowerSelectIndicator7; section1100BorrowerSelectIndicator7.Clean = value; _section1100BorrowerSelectIndicator7 = section1100BorrowerSelectIndicator7;
                var section1100BorrowerSelectIndicator8 = _section1100BorrowerSelectIndicator8; section1100BorrowerSelectIndicator8.Clean = value; _section1100BorrowerSelectIndicator8 = section1100BorrowerSelectIndicator8;
                var section1100BorrowerSelectIndicator9 = _section1100BorrowerSelectIndicator9; section1100BorrowerSelectIndicator9.Clean = value; _section1100BorrowerSelectIndicator9 = section1100BorrowerSelectIndicator9;
                var section1100ItemizeFeesIndicator = _section1100ItemizeFeesIndicator; section1100ItemizeFeesIndicator.Clean = value; _section1100ItemizeFeesIndicator = section1100ItemizeFeesIndicator;
                var section1200TotalTransferTaxes = _section1200TotalTransferTaxes; section1200TotalTransferTaxes.Clean = value; _section1200TotalTransferTaxes = section1200TotalTransferTaxes;
                var section800BonaFideIndicator = _section800BonaFideIndicator; section800BonaFideIndicator.Clean = value; _section800BonaFideIndicator = section800BonaFideIndicator;
                var section800BorrowerPaidInitialDiscountPointAmount = _section800BorrowerPaidInitialDiscountPointAmount; section800BorrowerPaidInitialDiscountPointAmount.Clean = value; _section800BorrowerPaidInitialDiscountPointAmount = section800BorrowerPaidInitialDiscountPointAmount;
                var section800ChargeAmount = _section800ChargeAmount; section800ChargeAmount.Clean = value; _section800ChargeAmount = section800ChargeAmount;
                var section800CreditChargeType = _section800CreditChargeType; section800CreditChargeType.Clean = value; _section800CreditChargeType = section800CreditChargeType;
                var section800IncludeOriginationPointsCreditType = _section800IncludeOriginationPointsCreditType; section800IncludeOriginationPointsCreditType.Clean = value; _section800IncludeOriginationPointsCreditType = section800IncludeOriginationPointsCreditType;
                var section800InitialDiscountPoint = _section800InitialDiscountPoint; section800InitialDiscountPoint.Clean = value; _section800InitialDiscountPoint = section800InitialDiscountPoint;
                var section800InitialDiscountPointAdditionalAmount = _section800InitialDiscountPointAdditionalAmount; section800InitialDiscountPointAdditionalAmount.Clean = value; _section800InitialDiscountPointAdditionalAmount = section800InitialDiscountPointAdditionalAmount;
                var section800InitialDiscountRate = _section800InitialDiscountRate; section800InitialDiscountRate.Clean = value; _section800InitialDiscountRate = section800InitialDiscountRate;
                var section800ItemizeFeesIndicator = _section800ItemizeFeesIndicator; section800ItemizeFeesIndicator.Clean = value; _section800ItemizeFeesIndicator = section800ItemizeFeesIndicator;
                var section800SelChargeAmount = _section800SelChargeAmount; section800SelChargeAmount.Clean = value; _section800SelChargeAmount = section800SelChargeAmount;
                var section800TotalTransferTaxes = _section800TotalTransferTaxes; section800TotalTransferTaxes.Clean = value; _section800TotalTransferTaxes = section800TotalTransferTaxes;
                var section900HomeownerInsurance = _section900HomeownerInsurance; section900HomeownerInsurance.Clean = value; _section900HomeownerInsurance = section900HomeownerInsurance;
                var section900HudGfeVaFundingFee = _section900HudGfeVaFundingFee; section900HudGfeVaFundingFee.Clean = value; _section900HudGfeVaFundingFee = section900HudGfeVaFundingFee;
                var useActualPaymentChange = _useActualPaymentChange; useActualPaymentChange.Clean = value; _useActualPaymentChange = useActualPaymentChange;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Gfe2010Section()
        {
            Clean = true;
        }
    }
}