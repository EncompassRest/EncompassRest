using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class Gfe2010Section : IDirty
    {
        private DirtyValue<bool?> _borrowerSelectIndicator903;
        public bool? BorrowerSelectIndicator903 { get { return _borrowerSelectIndicator903; } set { _borrowerSelectIndicator903 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator904;
        public bool? BorrowerSelectIndicator904 { get { return _borrowerSelectIndicator904; } set { _borrowerSelectIndicator904 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator906;
        public bool? BorrowerSelectIndicator906 { get { return _borrowerSelectIndicator906; } set { _borrowerSelectIndicator906 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator907;
        public bool? BorrowerSelectIndicator907 { get { return _borrowerSelectIndicator907; } set { _borrowerSelectIndicator907 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator908;
        public bool? BorrowerSelectIndicator908 { get { return _borrowerSelectIndicator908; } set { _borrowerSelectIndicator908 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator909;
        public bool? BorrowerSelectIndicator909 { get { return _borrowerSelectIndicator909; } set { _borrowerSelectIndicator909 = value; } }
        private DirtyValue<bool?> _borrowerSelectIndicator910;
        public bool? BorrowerSelectIndicator910 { get { return _borrowerSelectIndicator910; } set { _borrowerSelectIndicator910 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1109;
        public decimal? HudGfeLine1109 { get { return _hudGfeLine1109; } set { _hudGfeLine1109 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1110;
        public decimal? HudGfeLine1110 { get { return _hudGfeLine1110; } set { _hudGfeLine1110 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1111;
        public decimal? HudGfeLine1111 { get { return _hudGfeLine1111; } set { _hudGfeLine1111 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1112;
        public decimal? HudGfeLine1112 { get { return _hudGfeLine1112; } set { _hudGfeLine1112 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1113;
        public decimal? HudGfeLine1113 { get { return _hudGfeLine1113; } set { _hudGfeLine1113 = value; } }
        private DirtyValue<decimal?> _hudGfeLine1114;
        public decimal? HudGfeLine1114 { get { return _hudGfeLine1114; } set { _hudGfeLine1114 = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _line1001;
        public string Line1001 { get { return _line1001; } set { _line1001 = value; } }
        private DirtyValue<decimal?> _line1001BorPaidTotal;
        public decimal? Line1001BorPaidTotal { get { return _line1001BorPaidTotal; } set { _line1001BorPaidTotal = value; } }
        private DirtyValue<string> _line1002;
        public string Line1002 { get { return _line1002; } set { _line1002 = value; } }
        private DirtyValue<string> _line1003;
        public string Line1003 { get { return _line1003; } set { _line1003 = value; } }
        private DirtyValue<string> _line1004;
        public string Line1004 { get { return _line1004; } set { _line1004 = value; } }
        private DirtyValue<string> _line1005;
        public string Line1005 { get { return _line1005; } set { _line1005 = value; } }
        private DirtyValue<string> _line1006;
        public string Line1006 { get { return _line1006; } set { _line1006 = value; } }
        private DirtyValue<string> _line1007;
        public string Line1007 { get { return _line1007; } set { _line1007 = value; } }
        private DirtyValue<string> _line1008;
        public string Line1008 { get { return _line1008; } set { _line1008 = value; } }
        private DirtyValue<string> _line1009;
        public string Line1009 { get { return _line1009; } set { _line1009 = value; } }
        private DirtyValue<string> _line1010;
        public string Line1010 { get { return _line1010; } set { _line1010 = value; } }
        private DirtyValue<string> _line1011;
        public string Line1011 { get { return _line1011; } set { _line1011 = value; } }
        private DirtyValue<string> _line1101;
        public string Line1101 { get { return _line1101; } set { _line1101 = value; } }
        private DirtyValue<decimal?> _line1101BorPaidTotal;
        public decimal? Line1101BorPaidTotal { get { return _line1101BorPaidTotal; } set { _line1101BorPaidTotal = value; } }
        private DirtyValue<decimal?> _line1101SellerPaidAtoF;
        public decimal? Line1101SellerPaidAtoF { get { return _line1101SellerPaidAtoF; } set { _line1101SellerPaidAtoF = value; } }
        private DirtyValue<string> _line1102;
        public string Line1102 { get { return _line1102; } set { _line1102 = value; } }
        private DirtyValue<string> _line1103;
        public string Line1103 { get { return _line1103; } set { _line1103 = value; } }
        private DirtyValue<decimal?> _line1103PTAAmount;
        public decimal? Line1103PTAAmount { get { return _line1103PTAAmount; } set { _line1103PTAAmount = value; } }
        private DirtyValue<string> _line1104;
        public string Line1104 { get { return _line1104; } set { _line1104 = value; } }
        private DirtyValue<decimal?> _line1104PTAAmount;
        public decimal? Line1104PTAAmount { get { return _line1104PTAAmount; } set { _line1104PTAAmount = value; } }
        private DirtyValue<string> _line1107;
        public string Line1107 { get { return _line1107; } set { _line1107 = value; } }
        private DirtyValue<string> _line1108;
        public string Line1108 { get { return _line1108; } set { _line1108 = value; } }
        private DirtyValue<string> _line1109;
        public string Line1109 { get { return _line1109; } set { _line1109 = value; } }
        private DirtyValue<string> _line1110;
        public string Line1110 { get { return _line1110; } set { _line1110 = value; } }
        private DirtyValue<string> _line1115;
        public string Line1115 { get { return _line1115; } set { _line1115 = value; } }
        private DirtyValue<string> _line1116;
        public string Line1116 { get { return _line1116; } set { _line1116 = value; } }
        private DirtyValue<decimal?> _line1201BorPaidTotal;
        public decimal? Line1201BorPaidTotal { get { return _line1201BorPaidTotal; } set { _line1201BorPaidTotal = value; } }
        private DirtyValue<string> _line1209;
        public string Line1209 { get { return _line1209; } set { _line1209 = value; } }
        private DirtyValue<string> _line1210;
        public string Line1210 { get { return _line1210; } set { _line1210 = value; } }
        private DirtyValue<decimal?> _line1301BorPaidTotal;
        public decimal? Line1301BorPaidTotal { get { return _line1301BorPaidTotal; } set { _line1301BorPaidTotal = value; } }
        private DirtyValue<string> _line1302;
        public string Line1302 { get { return _line1302; } set { _line1302 = value; } }
        private DirtyValue<string> _line1310;
        public string Line1310 { get { return _line1310; } set { _line1310 = value; } }
        private DirtyValue<string> _line1311;
        public string Line1311 { get { return _line1311; } set { _line1311 = value; } }
        private DirtyValue<string> _line1312;
        public string Line1312 { get { return _line1312; } set { _line1312 = value; } }
        private DirtyValue<string> _line1313;
        public string Line1313 { get { return _line1313; } set { _line1313 = value; } }
        private DirtyValue<string> _line1314;
        public string Line1314 { get { return _line1314; } set { _line1314 = value; } }
        private DirtyValue<string> _line1315;
        public string Line1315 { get { return _line1315; } set { _line1315 = value; } }
        private DirtyValue<string> _line1316;
        public string Line1316 { get { return _line1316; } set { _line1316 = value; } }
        private DirtyValue<string> _line1317;
        public string Line1317 { get { return _line1317; } set { _line1317 = value; } }
        private DirtyValue<string> _line1318;
        public string Line1318 { get { return _line1318; } set { _line1318 = value; } }
        private DirtyValue<string> _line1319;
        public string Line1319 { get { return _line1319; } set { _line1319 = value; } }
        private DirtyValue<string> _line1320;
        public string Line1320 { get { return _line1320; } set { _line1320 = value; } }
        private DirtyValue<string> _line701;
        public string Line701 { get { return _line701; } set { _line701 = value; } }
        private DirtyValue<string> _line702;
        public string Line702 { get { return _line702; } set { _line702 = value; } }
        private DirtyValue<string> _line703;
        public string Line703 { get { return _line703; } set { _line703 = value; } }
        private DirtyValue<string> _line704;
        public string Line704 { get { return _line704; } set { _line704 = value; } }
        private DirtyValue<string> _line803x;
        public string Line803x { get { return _line803x; } set { _line803x = value; } }
        private DirtyValue<string> _line807Company;
        public string Line807Company { get { return _line807Company; } set { _line807Company = value; } }
        private DirtyValue<string> _line808;
        public string Line808 { get { return _line808; } set { _line808 = value; } }
        private DirtyValue<string> _line809;
        public string Line809 { get { return _line809; } set { _line809 = value; } }
        private DirtyValue<string> _line810;
        public string Line810 { get { return _line810; } set { _line810 = value; } }
        private DirtyValue<string> _line811;
        public string Line811 { get { return _line811; } set { _line811 = value; } }
        private DirtyValue<string> _line812;
        public string Line812 { get { return _line812; } set { _line812 = value; } }
        private DirtyValue<string> _line819;
        public string Line819 { get { return _line819; } set { _line819 = value; } }
        private DirtyValue<string> _line820;
        public string Line820 { get { return _line820; } set { _line820 = value; } }
        private DirtyValue<string> _line821;
        public string Line821 { get { return _line821; } set { _line821 = value; } }
        private DirtyValue<string> _line822;
        public string Line822 { get { return _line822; } set { _line822 = value; } }
        private DirtyValue<string> _line823;
        public string Line823 { get { return _line823; } set { _line823 = value; } }
        private DirtyValue<string> _line824;
        public string Line824 { get { return _line824; } set { _line824 = value; } }
        private DirtyValue<string> _line825;
        public string Line825 { get { return _line825; } set { _line825 = value; } }
        private DirtyValue<string> _line826;
        public string Line826 { get { return _line826; } set { _line826 = value; } }
        private DirtyValue<string> _line827;
        public string Line827 { get { return _line827; } set { _line827 = value; } }
        private DirtyValue<string> _line828;
        public string Line828 { get { return _line828; } set { _line828 = value; } }
        private DirtyValue<string> _line829;
        public string Line829 { get { return _line829; } set { _line829 = value; } }
        private DirtyValue<string> _line830;
        public string Line830 { get { return _line830; } set { _line830 = value; } }
        private DirtyValue<string> _line831;
        public string Line831 { get { return _line831; } set { _line831 = value; } }
        private DirtyValue<string> _line832;
        public string Line832 { get { return _line832; } set { _line832 = value; } }
        private DirtyValue<string> _line833;
        public string Line833 { get { return _line833; } set { _line833 = value; } }
        private DirtyValue<string> _line834;
        public string Line834 { get { return _line834; } set { _line834 = value; } }
        private DirtyValue<string> _line835;
        public string Line835 { get { return _line835; } set { _line835 = value; } }
        private DirtyValue<string> _line904;
        public string Line904 { get { return _line904; } set { _line904 = value; } }
        private DirtyValue<string> _line909;
        public string Line909 { get { return _line909; } set { _line909 = value; } }
        private DirtyValue<string> _line910;
        public string Line910 { get { return _line910; } set { _line910 = value; } }
        private DirtyValue<string> _line911;
        public string Line911 { get { return _line911; } set { _line911 = value; } }
        private DirtyValue<string> _line912;
        public string Line912 { get { return _line912; } set { _line912 = value; } }
        private DirtyValue<bool?> _loanTermTableCustomized;
        public bool? LoanTermTableCustomized { get { return _loanTermTableCustomized; } set { _loanTermTableCustomized = value; } }
        private DirtyValue<bool?> _loCompensationItemizeFeesIndicator;
        public bool? LoCompensationItemizeFeesIndicator { get { return _loCompensationItemizeFeesIndicator; } set { _loCompensationItemizeFeesIndicator = value; } }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmount;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmount { get { return _loCompensationLenderTotalPaidOriginatorAmount; } set { _loCompensationLenderTotalPaidOriginatorAmount = value; } }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForGFE;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForGFE { get { return _loCompensationLenderTotalPaidOriginatorAmountForGFE; } set { _loCompensationLenderTotalPaidOriginatorAmountForGFE = value; } }
        private DirtyValue<decimal?> _loCompensationLenderTotalPaidOriginatorAmountForLOTool;
        public decimal? LoCompensationLenderTotalPaidOriginatorAmountForLOTool { get { return _loCompensationLenderTotalPaidOriginatorAmountForLOTool; } set { _loCompensationLenderTotalPaidOriginatorAmountForLOTool = value; } }
        private DirtyValue<decimal?> _loCompensationNewHudLenderTotalPaidOriginatorAmount;
        public decimal? LoCompensationNewHudLenderTotalPaidOriginatorAmount { get { return _loCompensationNewHudLenderTotalPaidOriginatorAmount; } set { _loCompensationNewHudLenderTotalPaidOriginatorAmount = value; } }
        private DirtyValue<decimal?> _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount;
        public decimal? LoCompensationNewHudTotalBorrowerPaidDiscountPointAmount { get { return _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount; } set { _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount = value; } }
        private DirtyValue<decimal?> _loCompensationNewHudTotalLoCompensationAmount;
        public decimal? LoCompensationNewHudTotalLoCompensationAmount { get { return _loCompensationNewHudTotalLoCompensationAmount; } set { _loCompensationNewHudTotalLoCompensationAmount = value; } }
        private DirtyValue<decimal?> _loCompensationTotalBorrowerPaidDiscountPointAmount4;
        public decimal? LoCompensationTotalBorrowerPaidDiscountPointAmount4 { get { return _loCompensationTotalBorrowerPaidDiscountPointAmount4; } set { _loCompensationTotalBorrowerPaidDiscountPointAmount4 = value; } }
        private DirtyValue<decimal?> _loCompensationTotalLoCompensationAmount;
        public decimal? LoCompensationTotalLoCompensationAmount { get { return _loCompensationTotalLoCompensationAmount; } set { _loCompensationTotalLoCompensationAmount = value; } }
        private DirtyValue<decimal?> _loCompensationTotalSellerPaidDiscountPointAmount4;
        public decimal? LoCompensationTotalSellerPaidDiscountPointAmount4 { get { return _loCompensationTotalSellerPaidDiscountPointAmount4; } set { _loCompensationTotalSellerPaidDiscountPointAmount4 = value; } }
        private DirtyValue<bool?> _loCompensationUseLoCompensationToolIndicator;
        public bool? LoCompensationUseLoCompensationToolIndicator { get { return _loCompensationUseLoCompensationToolIndicator; } set { _loCompensationUseLoCompensationToolIndicator = value; } }
        private DirtyValue<string> _projectedPaymentTableColumns;
        public string ProjectedPaymentTableColumns { get { return _projectedPaymentTableColumns; } set { _projectedPaymentTableColumns = value; } }
        private DirtyValue<bool?> _projectedPaymentTableCustomized;
        public bool? ProjectedPaymentTableCustomized { get { return _projectedPaymentTableCustomized; } set { _projectedPaymentTableCustomized = value; } }
        private DirtyValue<string> _projectedPaymentTableType;
        public string ProjectedPaymentTableType { get { return _projectedPaymentTableType; } set { _projectedPaymentTableType = value; } }
        private DirtyValue<decimal?> _section1000AggregateAdjust;
        public decimal? Section1000AggregateAdjust { get { return _section1000AggregateAdjust; } set { _section1000AggregateAdjust = value; } }
        private DirtyValue<bool?> _section1000HudGuaranteeFeeAprIndicator;
        public bool? Section1000HudGuaranteeFeeAprIndicator { get { return _section1000HudGuaranteeFeeAprIndicator; } set { _section1000HudGuaranteeFeeAprIndicator = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator1;
        public bool? Section1100BorrowerSelectIndicator1 { get { return _section1100BorrowerSelectIndicator1; } set { _section1100BorrowerSelectIndicator1 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator10;
        public bool? Section1100BorrowerSelectIndicator10 { get { return _section1100BorrowerSelectIndicator10; } set { _section1100BorrowerSelectIndicator10 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator2;
        public bool? Section1100BorrowerSelectIndicator2 { get { return _section1100BorrowerSelectIndicator2; } set { _section1100BorrowerSelectIndicator2 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator3;
        public bool? Section1100BorrowerSelectIndicator3 { get { return _section1100BorrowerSelectIndicator3; } set { _section1100BorrowerSelectIndicator3 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator4;
        public bool? Section1100BorrowerSelectIndicator4 { get { return _section1100BorrowerSelectIndicator4; } set { _section1100BorrowerSelectIndicator4 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator5;
        public bool? Section1100BorrowerSelectIndicator5 { get { return _section1100BorrowerSelectIndicator5; } set { _section1100BorrowerSelectIndicator5 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator6;
        public bool? Section1100BorrowerSelectIndicator6 { get { return _section1100BorrowerSelectIndicator6; } set { _section1100BorrowerSelectIndicator6 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator7;
        public bool? Section1100BorrowerSelectIndicator7 { get { return _section1100BorrowerSelectIndicator7; } set { _section1100BorrowerSelectIndicator7 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator8;
        public bool? Section1100BorrowerSelectIndicator8 { get { return _section1100BorrowerSelectIndicator8; } set { _section1100BorrowerSelectIndicator8 = value; } }
        private DirtyValue<bool?> _section1100BorrowerSelectIndicator9;
        public bool? Section1100BorrowerSelectIndicator9 { get { return _section1100BorrowerSelectIndicator9; } set { _section1100BorrowerSelectIndicator9 = value; } }
        private DirtyValue<bool?> _section1100ItemizeFeesIndicator;
        public bool? Section1100ItemizeFeesIndicator { get { return _section1100ItemizeFeesIndicator; } set { _section1100ItemizeFeesIndicator = value; } }
        private DirtyValue<decimal?> _section1200TotalTransferTaxes;
        public decimal? Section1200TotalTransferTaxes { get { return _section1200TotalTransferTaxes; } set { _section1200TotalTransferTaxes = value; } }
        private DirtyValue<bool?> _section800BonaFideIndicator;
        public bool? Section800BonaFideIndicator { get { return _section800BonaFideIndicator; } set { _section800BonaFideIndicator = value; } }
        private DirtyValue<decimal?> _section800BorrowerPaidInitialDiscountPointAmount;
        public decimal? Section800BorrowerPaidInitialDiscountPointAmount { get { return _section800BorrowerPaidInitialDiscountPointAmount; } set { _section800BorrowerPaidInitialDiscountPointAmount = value; } }
        private DirtyValue<decimal?> _section800ChargeAmount;
        public decimal? Section800ChargeAmount { get { return _section800ChargeAmount; } set { _section800ChargeAmount = value; } }
        private StringEnumValue<CreditChargeType> _section800CreditChargeType;
        public StringEnumValue<CreditChargeType> Section800CreditChargeType { get { return _section800CreditChargeType; } set { _section800CreditChargeType = value; } }
        private StringEnumValue<IncludeOriginationPointsCreditType> _section800IncludeOriginationPointsCreditType;
        public StringEnumValue<IncludeOriginationPointsCreditType> Section800IncludeOriginationPointsCreditType { get { return _section800IncludeOriginationPointsCreditType; } set { _section800IncludeOriginationPointsCreditType = value; } }
        private DirtyValue<decimal?> _section800InitialDiscountPoint;
        public decimal? Section800InitialDiscountPoint { get { return _section800InitialDiscountPoint; } set { _section800InitialDiscountPoint = value; } }
        private DirtyValue<decimal?> _section800InitialDiscountPointAdditionalAmount;
        public decimal? Section800InitialDiscountPointAdditionalAmount { get { return _section800InitialDiscountPointAdditionalAmount; } set { _section800InitialDiscountPointAdditionalAmount = value; } }
        private DirtyValue<decimal?> _section800InitialDiscountRate;
        public decimal? Section800InitialDiscountRate { get { return _section800InitialDiscountRate; } set { _section800InitialDiscountRate = value; } }
        private DirtyValue<bool?> _section800ItemizeFeesIndicator;
        public bool? Section800ItemizeFeesIndicator { get { return _section800ItemizeFeesIndicator; } set { _section800ItemizeFeesIndicator = value; } }
        private DirtyValue<decimal?> _section800SelChargeAmount;
        public decimal? Section800SelChargeAmount { get { return _section800SelChargeAmount; } set { _section800SelChargeAmount = value; } }
        private DirtyValue<decimal?> _section800TotalTransferTaxes;
        public decimal? Section800TotalTransferTaxes { get { return _section800TotalTransferTaxes; } set { _section800TotalTransferTaxes = value; } }
        private DirtyValue<decimal?> _section900HomeownerInsurance;
        public decimal? Section900HomeownerInsurance { get { return _section900HomeownerInsurance; } set { _section900HomeownerInsurance = value; } }
        private DirtyValue<decimal?> _section900HudGfeVaFundingFee;
        public decimal? Section900HudGfeVaFundingFee { get { return _section900HudGfeVaFundingFee; } set { _section900HudGfeVaFundingFee = value; } }
        private DirtyValue<bool?> _useActualPaymentChange;
        public bool? UseActualPaymentChange { get { return _useActualPaymentChange; } set { _useActualPaymentChange = value; } }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get { return _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); } set { _extensionData = new DirtyDictionary<string, object>(value); } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _borrowerSelectIndicator903.Dirty
                    || _borrowerSelectIndicator904.Dirty
                    || _borrowerSelectIndicator906.Dirty
                    || _borrowerSelectIndicator907.Dirty
                    || _borrowerSelectIndicator908.Dirty
                    || _borrowerSelectIndicator909.Dirty
                    || _borrowerSelectIndicator910.Dirty
                    || _hudGfeLine1109.Dirty
                    || _hudGfeLine1110.Dirty
                    || _hudGfeLine1111.Dirty
                    || _hudGfeLine1112.Dirty
                    || _hudGfeLine1113.Dirty
                    || _hudGfeLine1114.Dirty
                    || _id.Dirty
                    || _line1001.Dirty
                    || _line1001BorPaidTotal.Dirty
                    || _line1002.Dirty
                    || _line1003.Dirty
                    || _line1004.Dirty
                    || _line1005.Dirty
                    || _line1006.Dirty
                    || _line1007.Dirty
                    || _line1008.Dirty
                    || _line1009.Dirty
                    || _line1010.Dirty
                    || _line1011.Dirty
                    || _line1101.Dirty
                    || _line1101BorPaidTotal.Dirty
                    || _line1101SellerPaidAtoF.Dirty
                    || _line1102.Dirty
                    || _line1103.Dirty
                    || _line1103PTAAmount.Dirty
                    || _line1104.Dirty
                    || _line1104PTAAmount.Dirty
                    || _line1107.Dirty
                    || _line1108.Dirty
                    || _line1109.Dirty
                    || _line1110.Dirty
                    || _line1115.Dirty
                    || _line1116.Dirty
                    || _line1201BorPaidTotal.Dirty
                    || _line1209.Dirty
                    || _line1210.Dirty
                    || _line1301BorPaidTotal.Dirty
                    || _line1302.Dirty
                    || _line1310.Dirty
                    || _line1311.Dirty
                    || _line1312.Dirty
                    || _line1313.Dirty
                    || _line1314.Dirty
                    || _line1315.Dirty
                    || _line1316.Dirty
                    || _line1317.Dirty
                    || _line1318.Dirty
                    || _line1319.Dirty
                    || _line1320.Dirty
                    || _line701.Dirty
                    || _line702.Dirty
                    || _line703.Dirty
                    || _line704.Dirty
                    || _line803x.Dirty
                    || _line807Company.Dirty
                    || _line808.Dirty
                    || _line809.Dirty
                    || _line810.Dirty
                    || _line811.Dirty
                    || _line812.Dirty
                    || _line819.Dirty
                    || _line820.Dirty
                    || _line821.Dirty
                    || _line822.Dirty
                    || _line823.Dirty
                    || _line824.Dirty
                    || _line825.Dirty
                    || _line826.Dirty
                    || _line827.Dirty
                    || _line828.Dirty
                    || _line829.Dirty
                    || _line830.Dirty
                    || _line831.Dirty
                    || _line832.Dirty
                    || _line833.Dirty
                    || _line834.Dirty
                    || _line835.Dirty
                    || _line904.Dirty
                    || _line909.Dirty
                    || _line910.Dirty
                    || _line911.Dirty
                    || _line912.Dirty
                    || _loanTermTableCustomized.Dirty
                    || _loCompensationItemizeFeesIndicator.Dirty
                    || _loCompensationLenderTotalPaidOriginatorAmount.Dirty
                    || _loCompensationLenderTotalPaidOriginatorAmountForGFE.Dirty
                    || _loCompensationLenderTotalPaidOriginatorAmountForLOTool.Dirty
                    || _loCompensationNewHudLenderTotalPaidOriginatorAmount.Dirty
                    || _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount.Dirty
                    || _loCompensationNewHudTotalLoCompensationAmount.Dirty
                    || _loCompensationTotalBorrowerPaidDiscountPointAmount4.Dirty
                    || _loCompensationTotalLoCompensationAmount.Dirty
                    || _loCompensationTotalSellerPaidDiscountPointAmount4.Dirty
                    || _loCompensationUseLoCompensationToolIndicator.Dirty
                    || _projectedPaymentTableColumns.Dirty
                    || _projectedPaymentTableCustomized.Dirty
                    || _projectedPaymentTableType.Dirty
                    || _section1000AggregateAdjust.Dirty
                    || _section1000HudGuaranteeFeeAprIndicator.Dirty
                    || _section1100BorrowerSelectIndicator1.Dirty
                    || _section1100BorrowerSelectIndicator10.Dirty
                    || _section1100BorrowerSelectIndicator2.Dirty
                    || _section1100BorrowerSelectIndicator3.Dirty
                    || _section1100BorrowerSelectIndicator4.Dirty
                    || _section1100BorrowerSelectIndicator5.Dirty
                    || _section1100BorrowerSelectIndicator6.Dirty
                    || _section1100BorrowerSelectIndicator7.Dirty
                    || _section1100BorrowerSelectIndicator8.Dirty
                    || _section1100BorrowerSelectIndicator9.Dirty
                    || _section1100ItemizeFeesIndicator.Dirty
                    || _section1200TotalTransferTaxes.Dirty
                    || _section800BonaFideIndicator.Dirty
                    || _section800BorrowerPaidInitialDiscountPointAmount.Dirty
                    || _section800ChargeAmount.Dirty
                    || _section800CreditChargeType.Dirty
                    || _section800IncludeOriginationPointsCreditType.Dirty
                    || _section800InitialDiscountPoint.Dirty
                    || _section800InitialDiscountPointAdditionalAmount.Dirty
                    || _section800InitialDiscountRate.Dirty
                    || _section800ItemizeFeesIndicator.Dirty
                    || _section800SelChargeAmount.Dirty
                    || _section800TotalTransferTaxes.Dirty
                    || _section900HomeownerInsurance.Dirty
                    || _section900HudGfeVaFundingFee.Dirty
                    || _useActualPaymentChange.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
                _borrowerSelectIndicator903.Dirty = value;
                _borrowerSelectIndicator904.Dirty = value;
                _borrowerSelectIndicator906.Dirty = value;
                _borrowerSelectIndicator907.Dirty = value;
                _borrowerSelectIndicator908.Dirty = value;
                _borrowerSelectIndicator909.Dirty = value;
                _borrowerSelectIndicator910.Dirty = value;
                _hudGfeLine1109.Dirty = value;
                _hudGfeLine1110.Dirty = value;
                _hudGfeLine1111.Dirty = value;
                _hudGfeLine1112.Dirty = value;
                _hudGfeLine1113.Dirty = value;
                _hudGfeLine1114.Dirty = value;
                _id.Dirty = value;
                _line1001.Dirty = value;
                _line1001BorPaidTotal.Dirty = value;
                _line1002.Dirty = value;
                _line1003.Dirty = value;
                _line1004.Dirty = value;
                _line1005.Dirty = value;
                _line1006.Dirty = value;
                _line1007.Dirty = value;
                _line1008.Dirty = value;
                _line1009.Dirty = value;
                _line1010.Dirty = value;
                _line1011.Dirty = value;
                _line1101.Dirty = value;
                _line1101BorPaidTotal.Dirty = value;
                _line1101SellerPaidAtoF.Dirty = value;
                _line1102.Dirty = value;
                _line1103.Dirty = value;
                _line1103PTAAmount.Dirty = value;
                _line1104.Dirty = value;
                _line1104PTAAmount.Dirty = value;
                _line1107.Dirty = value;
                _line1108.Dirty = value;
                _line1109.Dirty = value;
                _line1110.Dirty = value;
                _line1115.Dirty = value;
                _line1116.Dirty = value;
                _line1201BorPaidTotal.Dirty = value;
                _line1209.Dirty = value;
                _line1210.Dirty = value;
                _line1301BorPaidTotal.Dirty = value;
                _line1302.Dirty = value;
                _line1310.Dirty = value;
                _line1311.Dirty = value;
                _line1312.Dirty = value;
                _line1313.Dirty = value;
                _line1314.Dirty = value;
                _line1315.Dirty = value;
                _line1316.Dirty = value;
                _line1317.Dirty = value;
                _line1318.Dirty = value;
                _line1319.Dirty = value;
                _line1320.Dirty = value;
                _line701.Dirty = value;
                _line702.Dirty = value;
                _line703.Dirty = value;
                _line704.Dirty = value;
                _line803x.Dirty = value;
                _line807Company.Dirty = value;
                _line808.Dirty = value;
                _line809.Dirty = value;
                _line810.Dirty = value;
                _line811.Dirty = value;
                _line812.Dirty = value;
                _line819.Dirty = value;
                _line820.Dirty = value;
                _line821.Dirty = value;
                _line822.Dirty = value;
                _line823.Dirty = value;
                _line824.Dirty = value;
                _line825.Dirty = value;
                _line826.Dirty = value;
                _line827.Dirty = value;
                _line828.Dirty = value;
                _line829.Dirty = value;
                _line830.Dirty = value;
                _line831.Dirty = value;
                _line832.Dirty = value;
                _line833.Dirty = value;
                _line834.Dirty = value;
                _line835.Dirty = value;
                _line904.Dirty = value;
                _line909.Dirty = value;
                _line910.Dirty = value;
                _line911.Dirty = value;
                _line912.Dirty = value;
                _loanTermTableCustomized.Dirty = value;
                _loCompensationItemizeFeesIndicator.Dirty = value;
                _loCompensationLenderTotalPaidOriginatorAmount.Dirty = value;
                _loCompensationLenderTotalPaidOriginatorAmountForGFE.Dirty = value;
                _loCompensationLenderTotalPaidOriginatorAmountForLOTool.Dirty = value;
                _loCompensationNewHudLenderTotalPaidOriginatorAmount.Dirty = value;
                _loCompensationNewHudTotalBorrowerPaidDiscountPointAmount.Dirty = value;
                _loCompensationNewHudTotalLoCompensationAmount.Dirty = value;
                _loCompensationTotalBorrowerPaidDiscountPointAmount4.Dirty = value;
                _loCompensationTotalLoCompensationAmount.Dirty = value;
                _loCompensationTotalSellerPaidDiscountPointAmount4.Dirty = value;
                _loCompensationUseLoCompensationToolIndicator.Dirty = value;
                _projectedPaymentTableColumns.Dirty = value;
                _projectedPaymentTableCustomized.Dirty = value;
                _projectedPaymentTableType.Dirty = value;
                _section1000AggregateAdjust.Dirty = value;
                _section1000HudGuaranteeFeeAprIndicator.Dirty = value;
                _section1100BorrowerSelectIndicator1.Dirty = value;
                _section1100BorrowerSelectIndicator10.Dirty = value;
                _section1100BorrowerSelectIndicator2.Dirty = value;
                _section1100BorrowerSelectIndicator3.Dirty = value;
                _section1100BorrowerSelectIndicator4.Dirty = value;
                _section1100BorrowerSelectIndicator5.Dirty = value;
                _section1100BorrowerSelectIndicator6.Dirty = value;
                _section1100BorrowerSelectIndicator7.Dirty = value;
                _section1100BorrowerSelectIndicator8.Dirty = value;
                _section1100BorrowerSelectIndicator9.Dirty = value;
                _section1100ItemizeFeesIndicator.Dirty = value;
                _section1200TotalTransferTaxes.Dirty = value;
                _section800BonaFideIndicator.Dirty = value;
                _section800BorrowerPaidInitialDiscountPointAmount.Dirty = value;
                _section800ChargeAmount.Dirty = value;
                _section800CreditChargeType.Dirty = value;
                _section800IncludeOriginationPointsCreditType.Dirty = value;
                _section800InitialDiscountPoint.Dirty = value;
                _section800InitialDiscountPointAdditionalAmount.Dirty = value;
                _section800InitialDiscountRate.Dirty = value;
                _section800ItemizeFeesIndicator.Dirty = value;
                _section800SelChargeAmount.Dirty = value;
                _section800TotalTransferTaxes.Dirty = value;
                _section900HomeownerInsurance.Dirty = value;
                _section900HudGfeVaFundingFee.Dirty = value;
                _useActualPaymentChange.Dirty = value;
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}