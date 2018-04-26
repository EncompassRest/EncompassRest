using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Gfe2010
    /// </summary>
    public sealed partial class Gfe2010 : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _adjustedOriginationCharges;
        /// <summary>
        /// Fees Adj Orig Chrgs Applied to GFE [NEWHUD.X16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Adj Orig Chrgs Applied to GFE")]
        public decimal? AdjustedOriginationCharges { get => _adjustedOriginationCharges; set => _adjustedOriginationCharges = value; }
        private DirtyValue<decimal?> _allOtherServiceAmount;
        /// <summary>
        /// HUD-All Other Settlement Services [NEWHUD.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD-All Other Settlement Services")]
        public decimal? AllOtherServiceAmount { get => _allOtherServiceAmount; set => _allOtherServiceAmount = value; }
        private DirtyValue<decimal?> _applicationFees;
        /// <summary>
        /// Fees Application Fees Applied to GFE [NEWHUD.X702]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Application Fees Applied to GFE")]
        public decimal? ApplicationFees { get => _applicationFees; set => _applicationFees = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator10;
        /// <summary>
        /// Fees Line 1309 Borr Selects [NEWHUD.X115]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1309 Borr Selects")]
        public bool? BorrowerSelectIndicator10 { get => _borrowerSelectIndicator10; set => _borrowerSelectIndicator10 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator11;
        /// <summary>
        /// Fees Line 1310 Borr Selects [NEWHUD.X116]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1310 Borr Selects")]
        public bool? BorrowerSelectIndicator11 { get => _borrowerSelectIndicator11; set => _borrowerSelectIndicator11 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator12;
        /// <summary>
        /// Fees Line 1311 Borr Selects [NEWHUD.X117]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1311 Borr Selects")]
        public bool? BorrowerSelectIndicator12 { get => _borrowerSelectIndicator12; set => _borrowerSelectIndicator12 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator13;
        /// <summary>
        /// Gfe2010 BorrowerSelectIndicator13
        /// </summary>
        public bool? BorrowerSelectIndicator13 { get => _borrowerSelectIndicator13; set => _borrowerSelectIndicator13 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator14;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 1 [NEWHUD.X119]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 1")]
        public bool? BorrowerSelectIndicator14 { get => _borrowerSelectIndicator14; set => _borrowerSelectIndicator14 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator15;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 2 [NEWHUD.X120]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 2")]
        public bool? BorrowerSelectIndicator15 { get => _borrowerSelectIndicator15; set => _borrowerSelectIndicator15 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator16;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 3 [NEWHUD.X121]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 3")]
        public bool? BorrowerSelectIndicator16 { get => _borrowerSelectIndicator16; set => _borrowerSelectIndicator16 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator17;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 4 [NEWHUD.X122]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 4")]
        public bool? BorrowerSelectIndicator17 { get => _borrowerSelectIndicator17; set => _borrowerSelectIndicator17 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator18;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 5 [NEWHUD.X123]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 5")]
        public bool? BorrowerSelectIndicator18 { get => _borrowerSelectIndicator18; set => _borrowerSelectIndicator18 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator19;
        /// <summary>
        /// Borr Selects Homeowner Ins - Line 6 [NEWHUD.X124]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Selects Homeowner Ins - Line 6")]
        public bool? BorrowerSelectIndicator19 { get => _borrowerSelectIndicator19; set => _borrowerSelectIndicator19 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator2;
        /// <summary>
        /// Fees Line 1103 Borr Selects [NEWHUD.X107]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1103 Borr Selects")]
        public bool? BorrowerSelectIndicator2 { get => _borrowerSelectIndicator2; set => _borrowerSelectIndicator2 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator20;
        /// <summary>
        /// Homeowner Ins 7 Borr Select [NEWHUD.X655]
        /// </summary>
        [LoanFieldProperty(Description = "Homeowner Ins 7 Borr Select")]
        public bool? BorrowerSelectIndicator20 { get => _borrowerSelectIndicator20; set => _borrowerSelectIndicator20 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator3;
        /// <summary>
        /// Fees Line 1302 Borr Selects [NEWHUD.X108]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1302 Borr Selects")]
        public bool? BorrowerSelectIndicator3 { get => _borrowerSelectIndicator3; set => _borrowerSelectIndicator3 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator4;
        /// <summary>
        /// Fees Line 1303 Borr Selects [NEWHUD.X109]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1303 Borr Selects")]
        public bool? BorrowerSelectIndicator4 { get => _borrowerSelectIndicator4; set => _borrowerSelectIndicator4 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator5;
        /// <summary>
        /// Fees Line 1304 Borr Selects [NEWHUD.X110]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1304 Borr Selects")]
        public bool? BorrowerSelectIndicator5 { get => _borrowerSelectIndicator5; set => _borrowerSelectIndicator5 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator6;
        /// <summary>
        /// Fees Line 1305 Borr Selects [NEWHUD.X111]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1305 Borr Selects")]
        public bool? BorrowerSelectIndicator6 { get => _borrowerSelectIndicator6; set => _borrowerSelectIndicator6 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator7;
        /// <summary>
        /// Fees Line 1306 Borr Selects [NEWHUD.X112]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1306 Borr Selects")]
        public bool? BorrowerSelectIndicator7 { get => _borrowerSelectIndicator7; set => _borrowerSelectIndicator7 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator8;
        /// <summary>
        /// Fees Line 1307 Borr Selects [NEWHUD.X113]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1307 Borr Selects")]
        public bool? BorrowerSelectIndicator8 { get => _borrowerSelectIndicator8; set => _borrowerSelectIndicator8 = value; }
        private DirtyValue<bool?> _borrowerSelectIndicator9;
        /// <summary>
        /// Fees Line 1308 Borr Selects [NEWHUD.X114]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 1308 Borr Selects")]
        public bool? BorrowerSelectIndicator9 { get => _borrowerSelectIndicator9; set => _borrowerSelectIndicator9 = value; }
        private DirtyValue<decimal?> _brokerAdditionalFees;
        /// <summary>
        /// Broker Additional Fees [NEWHUD.X706]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Broker Additional Fees")]
        public decimal? BrokerAdditionalFees { get => _brokerAdditionalFees; set => _brokerAdditionalFees = value; }
        private DirtyValue<decimal?> _brokerFees;
        /// <summary>
        /// Broker Fees Applied to GFE [NEWHUD.X707]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Broker Fees Applied to GFE")]
        public decimal? BrokerFees { get => _brokerFees; set => _brokerFees = value; }
        private DirtyValue<decimal?> _brokerFeesPercentage;
        /// <summary>
        /// Broker Fees Percent [NEWHUD.X705]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Broker Fees Percent")]
        public decimal? BrokerFeesPercentage { get => _brokerFeesPercentage; set => _brokerFeesPercentage = value; }
        private DirtyValue<decimal?> _chargeAmount;
        /// <summary>
        /// Borr Charge Amt for Points - Itemization [NEWHUD.X720]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Charge Amt for Points - Itemization")]
        public decimal? ChargeAmount { get => _chargeAmount; set => _chargeAmount = value; }
        private DirtyValue<decimal?> _chargeAmountForPrint;
        /// <summary>
        /// Borr Charge Amt for Points - GFE [NEWHUD.X722]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Charge Amt for Points - GFE")]
        public decimal? ChargeAmountForPrint { get => _chargeAmountForPrint; set => _chargeAmountForPrint = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator1;
        /// <summary>
        /// HUD Copy from Itemization 1 [NEWHUD.X522]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 1")]
        public bool? CopyFromGfeIndicator1 { get => _copyFromGfeIndicator1; set => _copyFromGfeIndicator1 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator10;
        /// <summary>
        /// HUD Copy from Itemization 10 [NEWHUD.X531]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 10")]
        public bool? CopyFromGfeIndicator10 { get => _copyFromGfeIndicator10; set => _copyFromGfeIndicator10 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator11;
        /// <summary>
        /// HUD Copy from Itemization 11 [NEWHUD.X532]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 11")]
        public bool? CopyFromGfeIndicator11 { get => _copyFromGfeIndicator11; set => _copyFromGfeIndicator11 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator12;
        /// <summary>
        /// HUD Copy from Itemization 12 [NEWHUD.X533]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 12")]
        public bool? CopyFromGfeIndicator12 { get => _copyFromGfeIndicator12; set => _copyFromGfeIndicator12 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator13;
        /// <summary>
        /// HUD Copy from Itemization 13 [NEWHUD.X534]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 13")]
        public bool? CopyFromGfeIndicator13 { get => _copyFromGfeIndicator13; set => _copyFromGfeIndicator13 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator14;
        /// <summary>
        /// HUD Copy from Itemization 14 [NEWHUD.X535]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 14")]
        public bool? CopyFromGfeIndicator14 { get => _copyFromGfeIndicator14; set => _copyFromGfeIndicator14 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator15;
        /// <summary>
        /// HUD Copy from Itemization 15 [NEWHUD.X536]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 15")]
        public bool? CopyFromGfeIndicator15 { get => _copyFromGfeIndicator15; set => _copyFromGfeIndicator15 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator16;
        /// <summary>
        /// HUD Copy from Itemization 16 [NEWHUD.X537]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 16")]
        public bool? CopyFromGfeIndicator16 { get => _copyFromGfeIndicator16; set => _copyFromGfeIndicator16 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator17;
        /// <summary>
        /// HUD Copy from Itemization 17 [NEWHUD.X538]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 17")]
        public bool? CopyFromGfeIndicator17 { get => _copyFromGfeIndicator17; set => _copyFromGfeIndicator17 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator18;
        /// <summary>
        /// HUD Copy from Itemization 18 [NEWHUD.X539]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 18")]
        public bool? CopyFromGfeIndicator18 { get => _copyFromGfeIndicator18; set => _copyFromGfeIndicator18 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator19;
        /// <summary>
        /// HUD Copy from Itemization 19 [NEWHUD.X540]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 19")]
        public bool? CopyFromGfeIndicator19 { get => _copyFromGfeIndicator19; set => _copyFromGfeIndicator19 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator2;
        /// <summary>
        /// HUD Copy from Itemization 2 [NEWHUD.X523]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 2")]
        public bool? CopyFromGfeIndicator2 { get => _copyFromGfeIndicator2; set => _copyFromGfeIndicator2 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator20;
        /// <summary>
        /// HUD Copy from Itemization 20 [NEWHUD.X541]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 20")]
        public bool? CopyFromGfeIndicator20 { get => _copyFromGfeIndicator20; set => _copyFromGfeIndicator20 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator21;
        /// <summary>
        /// HUD Copy from Itemization 21 [NEWHUD.X542]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 21")]
        public bool? CopyFromGfeIndicator21 { get => _copyFromGfeIndicator21; set => _copyFromGfeIndicator21 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator22;
        /// <summary>
        /// HUD Copy from Itemization 22 [NEWHUD.X543]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 22")]
        public bool? CopyFromGfeIndicator22 { get => _copyFromGfeIndicator22; set => _copyFromGfeIndicator22 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator23;
        /// <summary>
        /// HUD Copy from Itemization 23 [NEWHUD.X544]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 23")]
        public bool? CopyFromGfeIndicator23 { get => _copyFromGfeIndicator23; set => _copyFromGfeIndicator23 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator24;
        /// <summary>
        /// HUD Copy from Itemization 24 [NEWHUD.X545]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 24")]
        public bool? CopyFromGfeIndicator24 { get => _copyFromGfeIndicator24; set => _copyFromGfeIndicator24 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator25;
        /// <summary>
        /// HUD Copy from Itemization 25 [NEWHUD.X546]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 25")]
        public bool? CopyFromGfeIndicator25 { get => _copyFromGfeIndicator25; set => _copyFromGfeIndicator25 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator26;
        /// <summary>
        /// HUD Copy from Itemization 26 [NEWHUD.X547]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 26")]
        public bool? CopyFromGfeIndicator26 { get => _copyFromGfeIndicator26; set => _copyFromGfeIndicator26 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator27;
        /// <summary>
        /// HUD Copy from Itemization 27 [NEWHUD.X548]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 27")]
        public bool? CopyFromGfeIndicator27 { get => _copyFromGfeIndicator27; set => _copyFromGfeIndicator27 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator28;
        /// <summary>
        /// HUD Copy from Itemization 28 [NEWHUD.X549]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 28")]
        public bool? CopyFromGfeIndicator28 { get => _copyFromGfeIndicator28; set => _copyFromGfeIndicator28 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator29;
        /// <summary>
        /// HUD Copy from Itemization 29 [NEWHUD.X550]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 29")]
        public bool? CopyFromGfeIndicator29 { get => _copyFromGfeIndicator29; set => _copyFromGfeIndicator29 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator3;
        /// <summary>
        /// HUD Copy from Itemization 3 [NEWHUD.X524]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 3")]
        public bool? CopyFromGfeIndicator3 { get => _copyFromGfeIndicator3; set => _copyFromGfeIndicator3 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator30;
        /// <summary>
        /// HUD Copy from Itemization 30 [NEWHUD.X551]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 30")]
        public bool? CopyFromGfeIndicator30 { get => _copyFromGfeIndicator30; set => _copyFromGfeIndicator30 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator31;
        /// <summary>
        /// HUD Copy from Itemization 31 [NEWHUD.X552]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 31")]
        public bool? CopyFromGfeIndicator31 { get => _copyFromGfeIndicator31; set => _copyFromGfeIndicator31 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator32;
        /// <summary>
        /// HUD Copy from Itemization 32 [NEWHUD.X553]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 32")]
        public bool? CopyFromGfeIndicator32 { get => _copyFromGfeIndicator32; set => _copyFromGfeIndicator32 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator33;
        /// <summary>
        /// HUD Copy from Itemization 33 [NEWHUD.X554]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 33")]
        public bool? CopyFromGfeIndicator33 { get => _copyFromGfeIndicator33; set => _copyFromGfeIndicator33 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator34;
        /// <summary>
        /// HUD Copy from Itemization 34 [NEWHUD.X620]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 34")]
        public bool? CopyFromGfeIndicator34 { get => _copyFromGfeIndicator34; set => _copyFromGfeIndicator34 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator35;
        /// <summary>
        /// HUD Copy from Itemization 35 [NEWHUD.X621]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 35")]
        public bool? CopyFromGfeIndicator35 { get => _copyFromGfeIndicator35; set => _copyFromGfeIndicator35 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator4;
        /// <summary>
        /// HUD Copy from Itemization 4 [NEWHUD.X525]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 4")]
        public bool? CopyFromGfeIndicator4 { get => _copyFromGfeIndicator4; set => _copyFromGfeIndicator4 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator5;
        /// <summary>
        /// HUD Copy from Itemization 5 [NEWHUD.X526]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 5")]
        public bool? CopyFromGfeIndicator5 { get => _copyFromGfeIndicator5; set => _copyFromGfeIndicator5 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator6;
        /// <summary>
        /// HUD Copy from Itemization 6 [NEWHUD.X527]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 6")]
        public bool? CopyFromGfeIndicator6 { get => _copyFromGfeIndicator6; set => _copyFromGfeIndicator6 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator7;
        /// <summary>
        /// HUD Copy from Itemization 7 [NEWHUD.X528]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 7")]
        public bool? CopyFromGfeIndicator7 { get => _copyFromGfeIndicator7; set => _copyFromGfeIndicator7 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator8;
        /// <summary>
        /// HUD Copy from Itemization 8 [NEWHUD.X529]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 8")]
        public bool? CopyFromGfeIndicator8 { get => _copyFromGfeIndicator8; set => _copyFromGfeIndicator8 = value; }
        private DirtyValue<bool?> _copyFromGfeIndicator9;
        /// <summary>
        /// HUD Copy from Itemization 9 [NEWHUD.X530]
        /// </summary>
        [LoanFieldProperty(Description = "HUD Copy from Itemization 9")]
        public bool? CopyFromGfeIndicator9 { get => _copyFromGfeIndicator9; set => _copyFromGfeIndicator9 = value; }
        private DirtyValue<decimal?> _creditAmount;
        /// <summary>
        /// GFE Credit Amount [NEWHUD.X718]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "GFE Credit Amount")]
        public decimal? CreditAmount { get => _creditAmount; set => _creditAmount = value; }
        private DirtyValue<decimal?> _creditAmountForPrint;
        /// <summary>
        /// Borr Orig Fee Credit for Int Rate [NEWHUD.X721]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Orig Fee Credit for Int Rate")]
        public decimal? CreditAmountForPrint { get => _creditAmountForPrint; set => _creditAmountForPrint = value; }
        private DirtyValue<StringEnumValue<CreditChargeType>> _creditChargeType;
        /// <summary>
        /// Can Monthly Payment Rise [NEWHUD.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Can Monthly Payment Rise")]
        public StringEnumValue<CreditChargeType> CreditChargeType { get => _creditChargeType; set => _creditChargeType = value; }
        private DirtyValue<decimal?> _creditOrChange;
        /// <summary>
        /// Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.X13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Cred/Chrgs for Spec Int Rate Applied to GFE")]
        public decimal? CreditOrChange { get => _creditOrChange; set => _creditOrChange = value; }
        private DirtyValue<decimal?> _curedAdjustedOriginationCharges;
        /// <summary>
        /// Cured Fees Adj Orig Chrgs Applied to GFE [NEWHUD.CuredX16]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured Fees Adj Orig Chrgs Applied to GFE")]
        public decimal? CuredAdjustedOriginationCharges { get => _curedAdjustedOriginationCharges; set => _curedAdjustedOriginationCharges = value; }
        private DirtyValue<decimal?> _curedCreditOrChange;
        /// <summary>
        /// Cured Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.CuredX13]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured Cred/Chrgs for Spec Int Rate Applied to GFE")]
        public decimal? CuredCreditOrChange { get => _curedCreditOrChange; set => _curedCreditOrChange = value; }
        private DirtyValue<decimal?> _curedOriginationCharges;
        /// <summary>
        /// Cured Total Est Origination Charges [NEWHUD.CuredX12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured Total Est Origination Charges")]
        public decimal? CuredOriginationCharges { get => _curedOriginationCharges; set => _curedOriginationCharges = value; }
        private DirtyValue<decimal?> _curedTotalTransferTaxes;
        /// <summary>
        /// Cured Transfer Tax Total GFE [NEWHUD.CuredX76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "Cured Transfer Tax Total GFE")]
        public decimal? CuredTotalTransferTaxes { get => _curedTotalTransferTaxes; set => _curedTotalTransferTaxes = value; }
        private DirtyValue<decimal?> _dailyInterestCharges;
        /// <summary>
        /// Fees Daily Int Chrgs Applied to GFE [NEWHUD.X701]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Daily Int Chrgs Applied to GFE")]
        public decimal? DailyInterestCharges { get => _dailyInterestCharges; set => _dailyInterestCharges = value; }
        private DirtyValue<DateTime?> _dateForCharges;
        /// <summary>
        /// Avail Date for All Other GFE Sttlmnt Chrgs [NEWHUD.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Avail Date for All Other GFE Sttlmnt Chrgs")]
        public DateTime? DateForCharges { get => _dateForCharges; set => _dateForCharges = value; }
        private DirtyValue<string> _dateForRate;
        /// <summary>
        /// Avail Date for GFE Interest Rate [NEWHUD.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Avail Date for GFE Interest Rate")]
        public string DateForRate { get => _dateForRate; set => _dateForRate = value; }
        private DirtyValue<string> _daysToSettlement;
        /// <summary>
        /// No. Days from Rate Lock to Settlement [NEWHUD.X719]
        /// </summary>
        [LoanFieldProperty(Description = "No. Days from Rate Lock to Settlement")]
        public string DaysToSettlement { get => _daysToSettlement; set => _daysToSettlement = value; }
        private DirtyValue<int?> _durationMonths;
        /// <summary>
        /// ARM Rate Adj Period [NEWHUD.X557]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Rate Adj Period")]
        public int? DurationMonths { get => _durationMonths; set => _durationMonths = value; }
        private DirtyValue<bool?> _escrowChargeAllInsuranceIndicator;
        /// <summary>
        /// Escrow Acct Chrg Type All Insurance [NEWHUD.X350]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Acct Chrg Type All Insurance")]
        public bool? EscrowChargeAllInsuranceIndicator { get => _escrowChargeAllInsuranceIndicator; set => _escrowChargeAllInsuranceIndicator = value; }
        private DirtyValue<bool?> _escrowChargeAllPropertyTaxesIndicator;
        /// <summary>
        /// Escrow Acct Chrg Type All Prop Taxes [NEWHUD.X349]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Acct Chrg Type All Prop Taxes")]
        public bool? EscrowChargeAllPropertyTaxesIndicator { get => _escrowChargeAllPropertyTaxesIndicator; set => _escrowChargeAllPropertyTaxesIndicator = value; }
        private DirtyValue<bool?> _escrowChargeOtherIndicator;
        /// <summary>
        /// Escrow Acct Chrg Type Other [NEWHUD.X351]
        /// </summary>
        [LoanFieldProperty(Description = "Escrow Acct Chrg Type Other")]
        public bool? EscrowChargeOtherIndicator { get => _escrowChargeOtherIndicator; set => _escrowChargeOtherIndicator = value; }
        private DirtyValue<string> _escrowOtherDescription;
        /// <summary>
        /// Other Escrow Descr [NEWHUD.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Other Escrow Descr")]
        public string EscrowOtherDescription { get => _escrowOtherDescription; set => _escrowOtherDescription = value; }
        private DirtyValue<decimal?> _financedFeesFromPrepaid;
        /// <summary>
        /// Borr Total of Prepaid Financed Fees [NEWHUD.X1704]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Total of Prepaid Financed Fees")]
        public decimal? FinancedFeesFromPrepaid { get => _financedFeesFromPrepaid; set => _financedFeesFromPrepaid = value; }
        private DirtyList<Gfe2010Fee> _gfe2010Fees;
        /// <summary>
        /// Gfe2010 Gfe2010Fees
        /// </summary>
        public IList<Gfe2010Fee> Gfe2010Fees { get => _gfe2010Fees ?? (_gfe2010Fees = new DirtyList<Gfe2010Fee>()); set => _gfe2010Fees = new DirtyList<Gfe2010Fee>(value); }
        private DirtyList<Gfe2010WholePoc> _gfe2010WholePocs;
        /// <summary>
        /// Gfe2010 Gfe2010WholePocs
        /// </summary>
        public IList<Gfe2010WholePoc> Gfe2010WholePocs { get => _gfe2010WholePocs ?? (_gfe2010WholePocs = new DirtyList<Gfe2010WholePoc>()); set => _gfe2010WholePocs = new DirtyList<Gfe2010WholePoc>(value); }
        private DirtyValue<decimal?> _gfeGovernmentRecordingCharges;
        /// <summary>
        /// Fees Line 1201 Applied to GFE [NEWHUD.X214]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1201 Applied to GFE")]
        public decimal? GfeGovernmentRecordingCharges { get => _gfeGovernmentRecordingCharges; set => _gfeGovernmentRecordingCharges = value; }
        private DirtyValue<decimal?> _hazardInsurance;
        /// <summary>
        /// Fees Homeowner's Ins Fee Applied to GFE [NEWHUD.X650]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Homeowner's Ins Fee Applied to GFE")]
        public decimal? HazardInsurance { get => _hazardInsurance; set => _hazardInsurance = value; }
        private DirtyValue<decimal?> _homeownerInsurance;
        /// <summary>
        /// Homeowner Ins Total Amt [NEWHUD.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Homeowner Ins Total Amt")]
        public decimal? HomeownerInsurance { get => _homeownerInsurance; set => _homeownerInsurance = value; }
        private DirtyValue<decimal?> _hudGuaranteeFee;
        /// <summary>
        /// Fees Line 1010 Guarantee Fee Applied to GFE [NEWHUD.X1709]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1010 Guarantee Fee Applied to GFE")]
        public decimal? HudGuaranteeFee { get => _hudGuaranteeFee; set => _hudGuaranteeFee = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Gfe2010 Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IncludeOriginationPointsCreditType>> _includeOriginationPointsCreditType;
        /// <summary>
        /// Include Points/Credit in Orig Chrg [NEWHUD.X714]
        /// </summary>
        [LoanFieldProperty(Description = "Include Points/Credit in Orig Chrg")]
        public StringEnumValue<IncludeOriginationPointsCreditType> IncludeOriginationPointsCreditType { get => _includeOriginationPointsCreditType; set => _includeOriginationPointsCreditType = value; }
        private DirtyValue<decimal?> _initialLoanAmount;
        /// <summary>
        /// Initial Loan Amount [NEWHUD.X4]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Loan Amount")]
        public decimal? InitialLoanAmount { get => _initialLoanAmount; set => _initialLoanAmount = value; }
        private DirtyValue<decimal?> _initialMonthlyAmount;
        /// <summary>
        /// Initial Mthly Pymt Princpl, Int, &amp; Mrtg Ins [NEWHUD.X217]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Initial Mthly Pymt Princpl, Int, & Mrtg Ins")]
        public decimal? InitialMonthlyAmount { get => _initialMonthlyAmount; set => _initialMonthlyAmount = value; }
        private DirtyValue<bool?> _interestRateRiseIndicator;
        /// <summary>
        /// Can Your Interest Rate Rise [NEWHUD.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Can Your Interest Rate Rise")]
        public bool? InterestRateRiseIndicator { get => _interestRateRiseIndicator; set => _interestRateRiseIndicator = value; }
        private DirtyValue<bool?> _isCDValidForEarliestClosingDate;
        /// <summary>
        /// Is CD Valid for Earliest Closing Date Calculation [4082]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Is CD Valid for Earliest Closing Date Calculation")]
        public bool? IsCDValidForEarliestClosingDate { get => _isCDValidForEarliestClosingDate; set => _isCDValidForEarliestClosingDate = value; }
        private DirtyValue<decimal?> _line1001Fee;
        /// <summary>
        /// Fees Line 1001 Applied to GFE [NEWHUD.X691]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1001 Applied to GFE")]
        public decimal? Line1001Fee { get => _line1001Fee; set => _line1001Fee = value; }
        private DirtyValue<decimal?> _line1002Fee;
        /// <summary>
        /// Fees Line 1002 Applied to GFE [NEWHUD.X692]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1002 Applied to GFE")]
        public decimal? Line1002Fee { get => _line1002Fee; set => _line1002Fee = value; }
        private DirtyValue<decimal?> _line1003Fee;
        /// <summary>
        /// Fees Line 1003 Applied to GFE [NEWHUD.X693]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1003 Applied to GFE")]
        public decimal? Line1003Fee { get => _line1003Fee; set => _line1003Fee = value; }
        private DirtyValue<decimal?> _line1004Fee;
        /// <summary>
        /// Fees Line 1004 Applied to GFE [NEWHUD.X694]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1004 Applied to GFE")]
        public decimal? Line1004Fee { get => _line1004Fee; set => _line1004Fee = value; }
        private DirtyValue<decimal?> _line1005Fee;
        /// <summary>
        /// Fees Line 1005 Applied to GFE [NEWHUD.X695]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1005 Applied to GFE")]
        public decimal? Line1005Fee { get => _line1005Fee; set => _line1005Fee = value; }
        private DirtyValue<decimal?> _line1006Fee;
        /// <summary>
        /// Fees Line 1006 Applied to GFE [NEWHUD.X696]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1006 Applied to GFE")]
        public decimal? Line1006Fee { get => _line1006Fee; set => _line1006Fee = value; }
        private DirtyValue<decimal?> _line1007Fee;
        /// <summary>
        /// Fees Line 1007 Applied to GFE [NEWHUD.X697]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1007 Applied to GFE")]
        public decimal? Line1007Fee { get => _line1007Fee; set => _line1007Fee = value; }
        private DirtyValue<decimal?> _line1008Fee;
        /// <summary>
        /// Fees Line 1008 Applied to GFE [NEWHUD.X698]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1008 Applied to GFE")]
        public decimal? Line1008Fee { get => _line1008Fee; set => _line1008Fee = value; }
        private DirtyValue<decimal?> _line1009Fee;
        /// <summary>
        /// Fees Line 1009 Applied to GFE [NEWHUD.X699]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1009 Applied to GFE")]
        public decimal? Line1009Fee { get => _line1009Fee; set => _line1009Fee = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationAdditionalAmount;
        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Additional Amount [NEWHUD.X247]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 801 HUD GFE Broker Compensation Additional Amount")]
        public decimal? Line801BrokerCompensationAdditionalAmount { get => _line801BrokerCompensationAdditionalAmount; set => _line801BrokerCompensationAdditionalAmount = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationFees;
        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Fees [NEWHUD.X250]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 801 HUD GFE Broker Compensation Fees")]
        public decimal? Line801BrokerCompensationFees { get => _line801BrokerCompensationFees; set => _line801BrokerCompensationFees = value; }
        private DirtyValue<decimal?> _line801BrokerCompensationRate;
        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Rate [NEWHUD.X246]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Fees Line 801 HUD GFE Broker Compensation Rate")]
        public decimal? Line801BrokerCompensationRate { get => _line801BrokerCompensationRate; set => _line801BrokerCompensationRate = value; }
        private DirtyValue<decimal?> _line808Fee;
        /// <summary>
        /// Fees Line 808 Fee Applied to GFE [NEWHUD.X662]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 808 Fee Applied to GFE")]
        public decimal? Line808Fee { get => _line808Fee; set => _line808Fee = value; }
        private DirtyValue<decimal?> _line809Fee;
        /// <summary>
        /// Fees Line 809 Fee Applied to GFE [NEWHUD.X663]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 809 Fee Applied to GFE")]
        public decimal? Line809Fee { get => _line809Fee; set => _line809Fee = value; }
        private DirtyValue<decimal?> _line810Fee;
        /// <summary>
        /// Fees Line 810 Fee Applied to GFE [NEWHUD.X664]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 810 Fee Applied to GFE")]
        public decimal? Line810Fee { get => _line810Fee; set => _line810Fee = value; }
        private DirtyValue<decimal?> _line811Fee;
        /// <summary>
        /// Fees Line 811 Fee Applied to GFE [NEWHUD.X665]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 811 Fee Applied to GFE")]
        public decimal? Line811Fee { get => _line811Fee; set => _line811Fee = value; }
        private DirtyValue<decimal?> _line812Fee;
        /// <summary>
        /// Fees Line 812 Fee Applied to GFE [NEWHUD.X666]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 812 Fee Applied to GFE")]
        public decimal? Line812Fee { get => _line812Fee; set => _line812Fee = value; }
        private DirtyValue<decimal?> _line813Fee;
        /// <summary>
        /// Fees Line 813 Fee Applied to GFE [NEWHUD.X667]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 813 Fee Applied to GFE")]
        public decimal? Line813Fee { get => _line813Fee; set => _line813Fee = value; }
        private DirtyValue<decimal?> _line814Fee;
        /// <summary>
        /// Fees Line 814 Fee Applied to GFE [NEWHUD.X668]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 814 Fee Applied to GFE")]
        public decimal? Line814Fee { get => _line814Fee; set => _line814Fee = value; }
        private DirtyValue<decimal?> _line815Fee;
        /// <summary>
        /// Fees Line 815 Fee Applied to GFE [NEWHUD.X669]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 815 Fee Applied to GFE")]
        public decimal? Line815Fee { get => _line815Fee; set => _line815Fee = value; }
        private DirtyValue<decimal?> _line816Fee;
        /// <summary>
        /// Fees Line 816 Fee Applied to GFE [NEWHUD.X670]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 816 Fee Applied to GFE")]
        public decimal? Line816Fee { get => _line816Fee; set => _line816Fee = value; }
        private DirtyValue<decimal?> _line817Fee;
        /// <summary>
        /// Fees Line 817 Fee Applied to GFE [NEWHUD.X671]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 817 Fee Applied to GFE")]
        public decimal? Line817Fee { get => _line817Fee; set => _line817Fee = value; }
        private DirtyValue<decimal?> _line818Fee;
        /// <summary>
        /// Fees Line 818 Fee Applied to GFE [NEWHUD.X1525]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 818 Fee Applied to GFE")]
        public decimal? Line818Fee { get => _line818Fee; set => _line818Fee = value; }
        private DirtyValue<decimal?> _line819Fee;
        /// <summary>
        /// Fees Line 819 Fee Applied to GFE [NEWHUD.X1526]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 819 Fee Applied to GFE")]
        public decimal? Line819Fee { get => _line819Fee; set => _line819Fee = value; }
        private DirtyValue<decimal?> _line820Fee;
        /// <summary>
        /// Fees Line 820 Fee Applied to GFE [NEWHUD.X1527]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 820 Fee Applied to GFE")]
        public decimal? Line820Fee { get => _line820Fee; set => _line820Fee = value; }
        private DirtyValue<decimal?> _line821Fee;
        /// <summary>
        /// Fees Line 821 Fee Applied to GFE [NEWHUD.X1528]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 821 Fee Applied to GFE")]
        public decimal? Line821Fee { get => _line821Fee; set => _line821Fee = value; }
        private DirtyValue<decimal?> _line822Fee;
        /// <summary>
        /// Fees Line 822 Fee Applied to GFE [NEWHUD.X1529]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 822 Fee Applied to GFE")]
        public decimal? Line822Fee { get => _line822Fee; set => _line822Fee = value; }
        private DirtyValue<decimal?> _line823Fee;
        /// <summary>
        /// Fees Line 823 Fee Applied to GFE [NEWHUD.X1530]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 823 Fee Applied to GFE")]
        public decimal? Line823Fee { get => _line823Fee; set => _line823Fee = value; }
        private DirtyValue<decimal?> _line824Fee;
        /// <summary>
        /// Fees Line 824 Fee Applied to GFE [NEWHUD.X1531]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 824 Fee Applied to GFE")]
        public decimal? Line824Fee { get => _line824Fee; set => _line824Fee = value; }
        private DirtyValue<decimal?> _line825Fee;
        /// <summary>
        /// Fees Line 825 Fee Applied to GFE [NEWHUD.X1532]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 825 Fee Applied to GFE")]
        public decimal? Line825Fee { get => _line825Fee; set => _line825Fee = value; }
        private DirtyValue<decimal?> _line826Fee;
        /// <summary>
        /// Fees Line 826 Fee Applied to GFE [NEWHUD.X1533]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 826 Fee Applied to GFE")]
        public decimal? Line826Fee { get => _line826Fee; set => _line826Fee = value; }
        private DirtyValue<decimal?> _line827Fee;
        /// <summary>
        /// Fees Line 827 Fee Applied to GFE [NEWHUD.X1534]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 827 Fee Applied to GFE")]
        public decimal? Line827Fee { get => _line827Fee; set => _line827Fee = value; }
        private DirtyValue<decimal?> _line828Fee;
        /// <summary>
        /// Fees Line 828 Fee Applied to GFE [NEWHUD.X1535]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 828 Fee Applied to GFE")]
        public decimal? Line828Fee { get => _line828Fee; set => _line828Fee = value; }
        private DirtyValue<decimal?> _line829Fee;
        /// <summary>
        /// Fees Line 829 Fee Applied to GFE [NEWHUD.X1536]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 829 Fee Applied to GFE")]
        public decimal? Line829Fee { get => _line829Fee; set => _line829Fee = value; }
        private DirtyValue<decimal?> _line830Fee;
        /// <summary>
        /// Fees Line 830 Fee Applied to GFE [NEWHUD.X1537]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 830 Fee Applied to GFE")]
        public decimal? Line830Fee { get => _line830Fee; set => _line830Fee = value; }
        private DirtyValue<decimal?> _line831Fee;
        /// <summary>
        /// Fees Line 831 Fee Applied to GFE [NEWHUD.X1538]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 831 Fee Applied to GFE")]
        public decimal? Line831Fee { get => _line831Fee; set => _line831Fee = value; }
        private DirtyValue<decimal?> _line832Fee;
        /// <summary>
        /// Fees Line 832 Fee Applied to GFE [NEWHUD.X1539]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 832 Fee Applied to GFE")]
        public decimal? Line832Fee { get => _line832Fee; set => _line832Fee = value; }
        private DirtyValue<decimal?> _line833Fee;
        /// <summary>
        /// Fees Line 833 Fee Applied to GFE [NEWHUD.X1540]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 833 Fee Applied to GFE")]
        public decimal? Line833Fee { get => _line833Fee; set => _line833Fee = value; }
        private DirtyValue<bool?> _loanBalanceRiseIndicator;
        /// <summary>
        /// Can Your Loan Balance Rise [NEWHUD.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Can Your Loan Balance Rise")]
        public bool? LoanBalanceRiseIndicator { get => _loanBalanceRiseIndicator; set => _loanBalanceRiseIndicator = value; }
        private DirtyValue<decimal?> _loanOriginationFees;
        /// <summary>
        /// Loan Origination Fees Applied to GFE [NEWHUD.X770]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Loan Origination Fees Applied to GFE")]
        public decimal? LoanOriginationFees { get => _loanOriginationFees; set => _loanOriginationFees = value; }
        private DirtyValue<decimal?> _loanOriginationPercentage;
        /// <summary>
        /// Loan Origination Fees Percent [NEWHUD.X769]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Loan Origination Fees Percent")]
        public decimal? LoanOriginationPercentage { get => _loanOriginationPercentage; set => _loanOriginationPercentage = value; }
        private DirtyValue<string> _loanOriginatorName;
        /// <summary>
        /// 2010 GFE Loan Originator Name [NEWHUD.X806]
        /// </summary>
        [LoanFieldProperty(Description = "2010 GFE Loan Originator Name")]
        public string LoanOriginatorName { get => _loanOriginatorName; set => _loanOriginatorName = value; }
        private DirtyValue<decimal?> _lowerInterestInitialInterestRate;
        /// <summary>
        /// Lower Int Rate-Initial Interest Rate [NEWHUD.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lower Int Rate-Initial Interest Rate")]
        public decimal? LowerInterestInitialInterestRate { get => _lowerInterestInitialInterestRate; set => _lowerInterestInitialInterestRate = value; }
        private DirtyValue<decimal?> _lowerInterestInitialMonthlyAmountOwed;
        /// <summary>
        /// Lower Int Rate-Initial Monthly Amt Owed [NEWHUD.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Int Rate-Initial Monthly Amt Owed")]
        public decimal? LowerInterestInitialMonthlyAmountOwed { get => _lowerInterestInitialMonthlyAmountOwed; set => _lowerInterestInitialMonthlyAmountOwed = value; }
        private DirtyValue<decimal?> _lowerInterestMonthlyPaymentReduced;
        /// <summary>
        /// Lower Int Rate-Mnthly Pymt Reduction [NEWHUD.X103]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Int Rate-Mnthly Pymt Reduction")]
        public decimal? LowerInterestMonthlyPaymentReduced { get => _lowerInterestMonthlyPaymentReduced; set => _lowerInterestMonthlyPaymentReduced = value; }
        private DirtyValue<decimal?> _lowerInterestServiceChargeIncreasedAmount;
        /// <summary>
        /// Lower Int Rate-Sttlmnt Chrgs Increase [NEWHUD.X104]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Int Rate-Sttlmnt Chrgs Increase")]
        public decimal? LowerInterestServiceChargeIncreasedAmount { get => _lowerInterestServiceChargeIncreasedAmount; set => _lowerInterestServiceChargeIncreasedAmount = value; }
        private DirtyValue<decimal?> _lowerInterestTotalSettlementCharges;
        /// <summary>
        /// Lower Int Rate-Total Est Sttlmnt Chrgs [NEWHUD.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Int Rate-Total Est Sttlmnt Chrgs")]
        public decimal? LowerInterestTotalSettlementCharges { get => _lowerInterestTotalSettlementCharges; set => _lowerInterestTotalSettlementCharges = value; }
        private DirtyValue<decimal?> _lowerSettlementInitialInterestRate;
        /// <summary>
        /// Lower Sttlmnt Chrgs-Intl Int Rate [NEWHUD.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Lower Sttlmnt Chrgs-Intl Int Rate")]
        public decimal? LowerSettlementInitialInterestRate { get => _lowerSettlementInitialInterestRate; set => _lowerSettlementInitialInterestRate = value; }
        private DirtyValue<decimal?> _lowerSettlementInitialMonthlyAmountOwed;
        /// <summary>
        /// Lower Sttlmnt Chrgs-Intl  Mnthly Amt Owed [NEWHUD.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Sttlmnt Chrgs-Intl  Mnthly Amt Owed")]
        public decimal? LowerSettlementInitialMonthlyAmountOwed { get => _lowerSettlementInitialMonthlyAmountOwed; set => _lowerSettlementInitialMonthlyAmountOwed = value; }
        private DirtyValue<decimal?> _lowerSettlementMonthlyPaymentIncreased;
        /// <summary>
        /// Lower Sttlmnt Chrgs-Mthly Pymt Increase [NEWHUD.X97]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Sttlmnt Chrgs-Mthly Pymt Increase")]
        public decimal? LowerSettlementMonthlyPaymentIncreased { get => _lowerSettlementMonthlyPaymentIncreased; set => _lowerSettlementMonthlyPaymentIncreased = value; }
        private DirtyValue<decimal?> _lowerSettlementServiceChargeReducedAmount;
        /// <summary>
        /// Lower Sttlmnt Chrgs-Sttlmnt Chrgs Reduction [NEWHUD.X98]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Sttlmnt Chrgs-Sttlmnt Chrgs Reduction")]
        public decimal? LowerSettlementServiceChargeReducedAmount { get => _lowerSettlementServiceChargeReducedAmount; set => _lowerSettlementServiceChargeReducedAmount = value; }
        private DirtyValue<decimal?> _lowerSettlementTotalSettlementCharges;
        /// <summary>
        /// Lower Sttlmnt Chrgs-Total Est Sttlmnt Chrgs [NEWHUD.X99]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Lower Sttlmnt Chrgs-Total Est Sttlmnt Chrgs")]
        public decimal? LowerSettlementTotalSettlementCharges { get => _lowerSettlementTotalSettlementCharges; set => _lowerSettlementTotalSettlementCharges = value; }
        private DirtyValue<decimal?> _maximumLoanBalance;
        /// <summary>
        /// HUD-Maximum Loan Balance [NEWHUD.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD-Maximum Loan Balance")]
        public decimal? MaximumLoanBalance { get => _maximumLoanBalance; set => _maximumLoanBalance = value; }
        private DirtyValue<decimal?> _maximumOwedMonthlyPayment;
        /// <summary>
        /// Max Mthly Pymt After 1st Increase [NEWHUD.X10]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Max Mthly Pymt After 1st Increase")]
        public decimal? MaximumOwedMonthlyPayment { get => _maximumOwedMonthlyPayment; set => _maximumOwedMonthlyPayment = value; }
        private DirtyValue<decimal?> _maxLifeInterestCapPercent;
        /// <summary>
        /// ARM Max Life Interest Cap [NEWHUD.X555]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ARM Max Life Interest Cap")]
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => _maxLifeInterestCapPercent = value; }
        private DirtyValue<string> _maxLifeInterestCapPercentUI;
        /// <summary>
        /// ARM Max Life Interest Cap - Display fields with KBYO rounding rules [KBYO.NEWHUDXD555]
        /// </summary>
        [LoanFieldProperty(Description = "ARM Max Life Interest Cap - Display fields with KBYO rounding rules")]
        public string MaxLifeInterestCapPercentUI { get => _maxLifeInterestCapPercentUI; set => _maxLifeInterestCapPercentUI = value; }
        private DirtyValue<int?> _monthlyPaymentFirstIncreaseDate;
        /// <summary>
        /// Mnths Until 1st Mnthly Pymt Increase [NEWHUD.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Mnths Until 1st Mnthly Pymt Increase")]
        public int? MonthlyPaymentFirstIncreaseDate { get => _monthlyPaymentFirstIncreaseDate; set => _monthlyPaymentFirstIncreaseDate = value; }
        private DirtyValue<bool?> _monthlyPaymentRiseIndicator;
        /// <summary>
        /// Can Monthly Payments Rise [NEWHUD.X8]
        /// </summary>
        [LoanFieldProperty(Description = "Can Monthly Payments Rise")]
        public bool? MonthlyPaymentRiseIndicator { get => _monthlyPaymentRiseIndicator; set => _monthlyPaymentRiseIndicator = value; }
        private DirtyValue<decimal?> _mortgageInsurancePremium;
        /// <summary>
        /// Fees Mtg Ins Premium Applied to GFE [NEWHUD.X622]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Mtg Ins Premium Applied to GFE")]
        public decimal? MortgageInsurancePremium { get => _mortgageInsurancePremium; set => _mortgageInsurancePremium = value; }
        private DirtyValue<string> _mustLockRateDays;
        /// <summary>
        /// Days Before Sttlmtn to Lock Int Rate [NEWHUD.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Days Before Sttlmtn to Lock Int Rate")]
        public string MustLockRateDays { get => _mustLockRateDays; set => _mustLockRateDays = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1104BorPaidAmount;
        /// <summary>
        /// Gfe2010 NewHudSection1100Line1104BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1104BorPaidAmount { get => _newHudSection1100Line1104BorPaidAmount; set => _newHudSection1100Line1104BorPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1104SelPaidAmount;
        /// <summary>
        /// Gfe2010 NewHudSection1100Line1104SelPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1104SelPaidAmount { get => _newHudSection1100Line1104SelPaidAmount; set => _newHudSection1100Line1104SelPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1107BorPaidAmount;
        /// <summary>
        /// Gfe2010 NewHudSection1100Line1107BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1107BorPaidAmount { get => _newHudSection1100Line1107BorPaidAmount; set => _newHudSection1100Line1107BorPaidAmount = value; }
        private DirtyValue<decimal?> _newHudSection1100Line1108BorPaidAmount;
        /// <summary>
        /// Gfe2010 NewHudSection1100Line1108BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1108BorPaidAmount { get => _newHudSection1100Line1108BorPaidAmount; set => _newHudSection1100Line1108BorPaidAmount = value; }
        private DirtyValue<decimal?> _originationCharges;
        /// <summary>
        /// Total Est Origination Charges [NEWHUD.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Total Est Origination Charges")]
        public decimal? OriginationCharges { get => _originationCharges; set => _originationCharges = value; }
        private DirtyValue<decimal?> _originationCreditYsp;
        /// <summary>
        /// Origination Credit (YSP) [NEWHUD.X712]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Origination Credit (YSP)")]
        public decimal? OriginationCreditYsp { get => _originationCreditYsp; set => _originationCreditYsp = value; }
        private DirtyValue<decimal?> _originationCreditYspAdditional;
        /// <summary>
        /// Fees Loan Origination Fee + $ [NEWHUD.X741]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Loan Origination Fee + $")]
        public decimal? OriginationCreditYspAdditional { get => _originationCreditYspAdditional; set => _originationCreditYspAdditional = value; }
        private DirtyValue<decimal?> _originationPoints;
        /// <summary>
        /// Orig Charge Paid by Borrower [NEWHUD.X711]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Orig Charge Paid by Borrower")]
        public decimal? OriginationPoints { get => _originationPoints; set => _originationPoints = value; }
        private DirtyValue<decimal?> _originationPointsAdditional;
        /// <summary>
        /// Origination Points Additional [NEWHUD.X710]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Origination Points Additional")]
        public decimal? OriginationPointsAdditional { get => _originationPointsAdditional; set => _originationPointsAdditional = value; }
        private DirtyValue<decimal?> _originationPointsPercentage;
        /// <summary>
        /// Origination Points [NEWHUD.X709]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Origination Points")]
        public decimal? OriginationPointsPercentage { get => _originationPointsPercentage; set => _originationPointsPercentage = value; }
        private DirtyValue<NA<decimal>> _ownerTitleInsuranceAmount;
        /// <summary>
        /// Owner's Title Ins Applied to GFE [NEWHUD.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Owner's Title Ins Applied to GFE")]
        public NA<decimal> OwnerTitleInsuranceAmount { get => _ownerTitleInsuranceAmount; set => _ownerTitleInsuranceAmount = value; }
        private DirtyValue<bool?> _printNAInLockRateDays;
        /// <summary>
        /// Print N/A to Days Before Sttlmtn to Lock Int Rate [NEWHUD.X1717]
        /// </summary>
        [LoanFieldProperty(Description = "Print N/A to Days Before Sttlmtn to Lock Int Rate")]
        public bool? PrintNAInLockRateDays { get => _printNAInLockRateDays; set => _printNAInLockRateDays = value; }
        private DirtyValue<bool?> _printShoppingChartIndicator;
        /// <summary>
        /// 2010 GFE Print Shopping Chart 1st Column [NEWHUD.X807]
        /// </summary>
        [LoanFieldProperty(Description = "2010 GFE Print Shopping Chart 1st Column")]
        public bool? PrintShoppingChartIndicator { get => _printShoppingChartIndicator; set => _printShoppingChartIndicator = value; }
        private DirtyValue<decimal?> _processingFees;
        /// <summary>
        /// Fees Processing Fees Applied to GFE [NEWHUD.X703]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Processing Fees Applied to GFE")]
        public decimal? ProcessingFees { get => _processingFees; set => _processingFees = value; }
        private DirtyValue<decimal?> _requiredAppraisalFee;
        /// <summary>
        /// Fees Apprsl Fee Applied to GFE [NEWHUD.X609]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Apprsl Fee Applied to GFE")]
        public decimal? RequiredAppraisalFee { get => _requiredAppraisalFee; set => _requiredAppraisalFee = value; }
        private DirtyValue<decimal?> _requiredCreditReportFee;
        /// <summary>
        /// Fees Credit Report Fee Applied to GFE [NEWHUD.X610]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Credit Report Fee Applied to GFE")]
        public decimal? RequiredCreditReportFee { get => _requiredCreditReportFee; set => _requiredCreditReportFee = value; }
        private DirtyValue<decimal?> _requiredFloodCertificationFee;
        /// <summary>
        /// Fees Flood Cert Fee Applied to GFE [NEWHUD.X612]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Flood Cert Fee Applied to GFE")]
        public decimal? RequiredFloodCertificationFee { get => _requiredFloodCertificationFee; set => _requiredFloodCertificationFee = value; }
        private DirtyValue<decimal?> _requiredServicesAmount;
        /// <summary>
        /// Required Services We Select [NEWHUD.X17]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Required Services We Select")]
        public decimal? RequiredServicesAmount { get => _requiredServicesAmount; set => _requiredServicesAmount = value; }
        private DirtyValue<decimal?> _requiredTaxServiceFee;
        /// <summary>
        /// Fees Tax Service Fee Applied to GFE [NEWHUD.X611]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Tax Service Fee Applied to GFE")]
        public decimal? RequiredTaxServiceFee { get => _requiredTaxServiceFee; set => _requiredTaxServiceFee = value; }
        private DirtyValue<decimal?> _section1000TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 1000 Total Borrower Paid Amount [NEWHUD2.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1000 Total Borrower Paid Amount")]
        public decimal? Section1000TotalBorrowerPaidAmount { get => _section1000TotalBorrowerPaidAmount; set => _section1000TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalOtherPaidAmount;
        /// <summary>
        /// Line 1000 Total Other Paid Amount [NEWHUD2.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1000 Total Other Paid Amount")]
        public decimal? Section1000TotalOtherPaidAmount { get => _section1000TotalOtherPaidAmount; set => _section1000TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalPaidAmount;
        /// <summary>
        /// Line 1000 Total Paid Amount [NEWHUD2.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1000 Total Paid Amount")]
        public decimal? Section1000TotalPaidAmount { get => _section1000TotalPaidAmount; set => _section1000TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1000TotalSellerPaidAmount;
        /// <summary>
        /// Line 1000 Total Seller Paid Amount [NEWHUD2.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1000 Total Seller Paid Amount")]
        public decimal? Section1000TotalSellerPaidAmount { get => _section1000TotalSellerPaidAmount; set => _section1000TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 1100 Total Borrower Paid Amount [NEWHUD2.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1100 Total Borrower Paid Amount")]
        public decimal? Section1100TotalBorrowerPaidAmount { get => _section1100TotalBorrowerPaidAmount; set => _section1100TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalOtherPaidAmount;
        /// <summary>
        /// Line 1100 Total Other Paid Amount [NEWHUD2.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1100 Total Other Paid Amount")]
        public decimal? Section1100TotalOtherPaidAmount { get => _section1100TotalOtherPaidAmount; set => _section1100TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalPaidAmount;
        /// <summary>
        /// Line 1100 Total Paid Amount [NEWHUD2.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1100 Total Paid Amount")]
        public decimal? Section1100TotalPaidAmount { get => _section1100TotalPaidAmount; set => _section1100TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1100TotalSellerPaidAmount;
        /// <summary>
        /// Line 1100 Total Seller Paid Amount [NEWHUD2.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1100 Total Seller Paid Amount")]
        public decimal? Section1100TotalSellerPaidAmount { get => _section1100TotalSellerPaidAmount; set => _section1100TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 1200 Total Borrower Paid Amount [NEWHUD2.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1200 Total Borrower Paid Amount")]
        public decimal? Section1200TotalBorrowerPaidAmount { get => _section1200TotalBorrowerPaidAmount; set => _section1200TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalOtherPaidAmount;
        /// <summary>
        /// Line 1200 Total Other Paid Amount [NEWHUD2.X46]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1200 Total Other Paid Amount")]
        public decimal? Section1200TotalOtherPaidAmount { get => _section1200TotalOtherPaidAmount; set => _section1200TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalPaidAmount;
        /// <summary>
        /// Line 1200 Total Paid Amount [NEWHUD2.X47]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1200 Total Paid Amount")]
        public decimal? Section1200TotalPaidAmount { get => _section1200TotalPaidAmount; set => _section1200TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1200TotalSellerPaidAmount;
        /// <summary>
        /// Line 1200 Total Seller Paid Amount [NEWHUD2.X45]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1200 Total Seller Paid Amount")]
        public decimal? Section1200TotalSellerPaidAmount { get => _section1200TotalSellerPaidAmount; set => _section1200TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 1300 Total Borrower Paid Amount [NEWHUD2.X48]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1300 Total Borrower Paid Amount")]
        public decimal? Section1300TotalBorrowerPaidAmount { get => _section1300TotalBorrowerPaidAmount; set => _section1300TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalOtherPaidAmount;
        /// <summary>
        /// Line 1300 Total Other Paid Amount [NEWHUD2.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1300 Total Other Paid Amount")]
        public decimal? Section1300TotalOtherPaidAmount { get => _section1300TotalOtherPaidAmount; set => _section1300TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalPaidAmount;
        /// <summary>
        /// Line 1300 Total Paid Amount [NEWHUD2.X51]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1300 Total Paid Amount")]
        public decimal? Section1300TotalPaidAmount { get => _section1300TotalPaidAmount; set => _section1300TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1300TotalSellerPaidAmount;
        /// <summary>
        /// Line 1300 Total Seller Paid Amount [NEWHUD2.X49]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1300 Total Seller Paid Amount")]
        public decimal? Section1300TotalSellerPaidAmount { get => _section1300TotalSellerPaidAmount; set => _section1300TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 1400 Total Borrower Paid Amount [NEWHUD2.X4427]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1400 Total Borrower Paid Amount")]
        public decimal? Section1400TotalBorrowerPaidAmount { get => _section1400TotalBorrowerPaidAmount; set => _section1400TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalOtherPaidAmount;
        /// <summary>
        /// Line 1400 Total Other Paid Amount [NEWHUD2.X52]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1400 Total Other Paid Amount")]
        public decimal? Section1400TotalOtherPaidAmount { get => _section1400TotalOtherPaidAmount; set => _section1400TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalPaidAmount;
        /// <summary>
        /// Line 1400 Total Paid Amount [NEWHUD2.X53]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1400 Total Paid Amount")]
        public decimal? Section1400TotalPaidAmount { get => _section1400TotalPaidAmount; set => _section1400TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section1400TotalSellerPaidAmount;
        /// <summary>
        /// Line 1400 Total Seller Amount [NEWHUD2.X4428]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 1400 Total Seller Amount")]
        public decimal? Section1400TotalSellerPaidAmount { get => _section1400TotalSellerPaidAmount; set => _section1400TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 700 Total Borrower Paid Amount [NEWHUD2.X24]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 700 Total Borrower Paid Amount")]
        public decimal? Section700TotalBorrowerPaidAmount { get => _section700TotalBorrowerPaidAmount; set => _section700TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalOtherPaidAmount;
        /// <summary>
        /// Line 700 Total Other Paid Amount [NEWHUD2.X26]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 700 Total Other Paid Amount")]
        public decimal? Section700TotalOtherPaidAmount { get => _section700TotalOtherPaidAmount; set => _section700TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalPaidAmount;
        /// <summary>
        /// Line 700 Total Paid Amount [NEWHUD2.X27]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 700 Total Paid Amount")]
        public decimal? Section700TotalPaidAmount { get => _section700TotalPaidAmount; set => _section700TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section700TotalSellerPaidAmount;
        /// <summary>
        /// Line 700 Total Seller Paid Amount [NEWHUD2.X25]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 700 Total Seller Paid Amount")]
        public decimal? Section700TotalSellerPaidAmount { get => _section700TotalSellerPaidAmount; set => _section700TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 800 Total Borrower Paid Amount [NEWHUD2.X28]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 800 Total Borrower Paid Amount")]
        public decimal? Section800TotalBorrowerPaidAmount { get => _section800TotalBorrowerPaidAmount; set => _section800TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalOtherPaidAmount;
        /// <summary>
        /// Line 800 Total Other Paid Amount [NEWHUD2.X30]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 800 Total Other Paid Amount")]
        public decimal? Section800TotalOtherPaidAmount { get => _section800TotalOtherPaidAmount; set => _section800TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalPaidAmount;
        /// <summary>
        /// Line 800 Total Paid Amount [NEWHUD2.X31]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 800 Total Paid Amount")]
        public decimal? Section800TotalPaidAmount { get => _section800TotalPaidAmount; set => _section800TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section800TotalSellerPaidAmount;
        /// <summary>
        /// Line 800 Total Seller Paid Amount [NEWHUD2.X29]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 800 Total Seller Paid Amount")]
        public decimal? Section800TotalSellerPaidAmount { get => _section800TotalSellerPaidAmount; set => _section800TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalBorrowerPaidAmount;
        /// <summary>
        /// Line 900 Total Borrower Paid Amount [NEWHUD2.X32]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 900 Total Borrower Paid Amount")]
        public decimal? Section900TotalBorrowerPaidAmount { get => _section900TotalBorrowerPaidAmount; set => _section900TotalBorrowerPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalOtherPaidAmount;
        /// <summary>
        /// Line 900 Total Other Paid Amount [NEWHUD2.X34]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 900 Total Other Paid Amount")]
        public decimal? Section900TotalOtherPaidAmount { get => _section900TotalOtherPaidAmount; set => _section900TotalOtherPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalPaidAmount;
        /// <summary>
        /// Line 900 Total Paid Amount [NEWHUD2.X35]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 900 Total Paid Amount")]
        public decimal? Section900TotalPaidAmount { get => _section900TotalPaidAmount; set => _section900TotalPaidAmount = value; }
        private DirtyValue<decimal?> _section900TotalSellerPaidAmount;
        /// <summary>
        /// Line 900 Total Seller Paid Amount [NEWHUD2.X33]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Line 900 Total Seller Paid Amount")]
        public decimal? Section900TotalSellerPaidAmount { get => _section900TotalSellerPaidAmount; set => _section900TotalSellerPaidAmount = value; }
        private DirtyValue<decimal?> _shopRequiredServicesAmount;
        /// <summary>
        /// Fees Line 1301l Applied to GFE [NEWHUD.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1301l Applied to GFE")]
        public decimal? ShopRequiredServicesAmount { get => _shopRequiredServicesAmount; set => _shopRequiredServicesAmount = value; }
        private DirtyValue<decimal?> _subsequentCapPercent;
        /// <summary>
        /// ARM Rate Cap [NEWHUD.X558]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ARM Rate Cap")]
        public decimal? SubsequentCapPercent { get => _subsequentCapPercent; set => _subsequentCapPercent = value; }
        private DirtyValue<int?> _subsequentRateAdjustmentMonths;
        /// <summary>
        /// ARM First Period Change [NEWHUD.X556]
        /// </summary>
        [LoanFieldProperty(Description = "ARM First Period Change")]
        public int? SubsequentRateAdjustmentMonths { get => _subsequentRateAdjustmentMonths; set => _subsequentRateAdjustmentMonths = value; }
        private DirtyValue<bool?> _tableFundedIndicator;
        /// <summary>
        /// Table Funded Transactions Indicator [NEWHUD.X1068]
        /// </summary>
        [LoanFieldProperty(Description = "Table Funded Transactions Indicator")]
        public bool? TableFundedIndicator { get => _tableFundedIndicator; set => _tableFundedIndicator = value; }
        private DirtyValue<string> _timeForRate;
        /// <summary>
        /// Avail Time for GFE Interest Rate [NEWHUD.X725]
        /// </summary>
        [LoanFieldProperty(Description = "Avail Time for GFE Interest Rate")]
        public string TimeForRate { get => _timeForRate; set => _timeForRate = value; }
        private DirtyValue<decimal?> _titleServiceAmount;
        /// <summary>
        /// Title Serv &amp; Lender's Title Ins Applied to GFE [NEWHUD.X38]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Title Serv & Lender's Title Ins Applied to GFE")]
        public decimal? TitleServiceAmount { get => _titleServiceAmount; set => _titleServiceAmount = value; }
        private DirtyValue<decimal?> _totalBelow10;
        /// <summary>
        /// Chrgs That Cannot Incr 10% in Total [NEWHUD.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Chrgs That Cannot Incr 10% in Total")]
        public decimal? TotalBelow10 { get => _totalBelow10; set => _totalBelow10 = value; }
        private DirtyValue<decimal?> _totalOfFinancedFees;
        /// <summary>
        /// Borr Total of Financed Fees [NEWHUD.X1585]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Borr Total of Financed Fees")]
        public decimal? TotalOfFinancedFees { get => _totalOfFinancedFees; set => _totalOfFinancedFees = value; }
        private DirtyValue<decimal?> _totalSettlementCharges;
        /// <summary>
        /// HUD-Est Total Settlement Charges [NEWHUD.X93]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "HUD-Est Total Settlement Charges")]
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => _totalSettlementCharges = value; }
        private DirtyValue<decimal?> _totalTransferTaxes;
        /// <summary>
        /// Transfer Tax Total GFE [NEWHUD.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Transfer Tax Total GFE")]
        public decimal? TotalTransferTaxes { get => _totalTransferTaxes; set => _totalTransferTaxes = value; }
        private DirtyValue<decimal?> _transferTaxes;
        /// <summary>
        /// Fees Line 1203 Borr [NEWHUD.X730]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Line 1203 Borr")]
        public decimal? TransferTaxes { get => _transferTaxes; set => _transferTaxes = value; }
        private DirtyValue<decimal?> _underwritingFees;
        /// <summary>
        /// Fees Underwriting Fees Applied to GFE [NEWHUD.X704]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Fees Underwriting Fees Applied to GFE")]
        public decimal? UnderwritingFees { get => _underwritingFees; set => _underwritingFees = value; }
        private DirtyValue<bool?> _useLOCompTool;
        /// <summary>
        /// Fees Line 801 Broker Compensation Use LO Comp Tool [NEWHUD.X1718]
        /// </summary>
        [LoanFieldProperty(Description = "Fees Line 801 Broker Compensation Use LO Comp Tool")]
        public bool? UseLOCompTool { get => _useLOCompTool; set => _useLOCompTool = value; }
        internal override bool DirtyInternal
        {
            get => _adjustedOriginationCharges.Dirty
                || _allOtherServiceAmount.Dirty
                || _applicationFees.Dirty
                || _borrowerSelectIndicator10.Dirty
                || _borrowerSelectIndicator11.Dirty
                || _borrowerSelectIndicator12.Dirty
                || _borrowerSelectIndicator13.Dirty
                || _borrowerSelectIndicator14.Dirty
                || _borrowerSelectIndicator15.Dirty
                || _borrowerSelectIndicator16.Dirty
                || _borrowerSelectIndicator17.Dirty
                || _borrowerSelectIndicator18.Dirty
                || _borrowerSelectIndicator19.Dirty
                || _borrowerSelectIndicator2.Dirty
                || _borrowerSelectIndicator20.Dirty
                || _borrowerSelectIndicator3.Dirty
                || _borrowerSelectIndicator4.Dirty
                || _borrowerSelectIndicator5.Dirty
                || _borrowerSelectIndicator6.Dirty
                || _borrowerSelectIndicator7.Dirty
                || _borrowerSelectIndicator8.Dirty
                || _borrowerSelectIndicator9.Dirty
                || _brokerAdditionalFees.Dirty
                || _brokerFees.Dirty
                || _brokerFeesPercentage.Dirty
                || _chargeAmount.Dirty
                || _chargeAmountForPrint.Dirty
                || _copyFromGfeIndicator1.Dirty
                || _copyFromGfeIndicator10.Dirty
                || _copyFromGfeIndicator11.Dirty
                || _copyFromGfeIndicator12.Dirty
                || _copyFromGfeIndicator13.Dirty
                || _copyFromGfeIndicator14.Dirty
                || _copyFromGfeIndicator15.Dirty
                || _copyFromGfeIndicator16.Dirty
                || _copyFromGfeIndicator17.Dirty
                || _copyFromGfeIndicator18.Dirty
                || _copyFromGfeIndicator19.Dirty
                || _copyFromGfeIndicator2.Dirty
                || _copyFromGfeIndicator20.Dirty
                || _copyFromGfeIndicator21.Dirty
                || _copyFromGfeIndicator22.Dirty
                || _copyFromGfeIndicator23.Dirty
                || _copyFromGfeIndicator24.Dirty
                || _copyFromGfeIndicator25.Dirty
                || _copyFromGfeIndicator26.Dirty
                || _copyFromGfeIndicator27.Dirty
                || _copyFromGfeIndicator28.Dirty
                || _copyFromGfeIndicator29.Dirty
                || _copyFromGfeIndicator3.Dirty
                || _copyFromGfeIndicator30.Dirty
                || _copyFromGfeIndicator31.Dirty
                || _copyFromGfeIndicator32.Dirty
                || _copyFromGfeIndicator33.Dirty
                || _copyFromGfeIndicator34.Dirty
                || _copyFromGfeIndicator35.Dirty
                || _copyFromGfeIndicator4.Dirty
                || _copyFromGfeIndicator5.Dirty
                || _copyFromGfeIndicator6.Dirty
                || _copyFromGfeIndicator7.Dirty
                || _copyFromGfeIndicator8.Dirty
                || _copyFromGfeIndicator9.Dirty
                || _creditAmount.Dirty
                || _creditAmountForPrint.Dirty
                || _creditChargeType.Dirty
                || _creditOrChange.Dirty
                || _curedAdjustedOriginationCharges.Dirty
                || _curedCreditOrChange.Dirty
                || _curedOriginationCharges.Dirty
                || _curedTotalTransferTaxes.Dirty
                || _dailyInterestCharges.Dirty
                || _dateForCharges.Dirty
                || _dateForRate.Dirty
                || _daysToSettlement.Dirty
                || _durationMonths.Dirty
                || _escrowChargeAllInsuranceIndicator.Dirty
                || _escrowChargeAllPropertyTaxesIndicator.Dirty
                || _escrowChargeOtherIndicator.Dirty
                || _escrowOtherDescription.Dirty
                || _financedFeesFromPrepaid.Dirty
                || _gfeGovernmentRecordingCharges.Dirty
                || _hazardInsurance.Dirty
                || _homeownerInsurance.Dirty
                || _hudGuaranteeFee.Dirty
                || _id.Dirty
                || _includeOriginationPointsCreditType.Dirty
                || _initialLoanAmount.Dirty
                || _initialMonthlyAmount.Dirty
                || _interestRateRiseIndicator.Dirty
                || _isCDValidForEarliestClosingDate.Dirty
                || _line1001Fee.Dirty
                || _line1002Fee.Dirty
                || _line1003Fee.Dirty
                || _line1004Fee.Dirty
                || _line1005Fee.Dirty
                || _line1006Fee.Dirty
                || _line1007Fee.Dirty
                || _line1008Fee.Dirty
                || _line1009Fee.Dirty
                || _line801BrokerCompensationAdditionalAmount.Dirty
                || _line801BrokerCompensationFees.Dirty
                || _line801BrokerCompensationRate.Dirty
                || _line808Fee.Dirty
                || _line809Fee.Dirty
                || _line810Fee.Dirty
                || _line811Fee.Dirty
                || _line812Fee.Dirty
                || _line813Fee.Dirty
                || _line814Fee.Dirty
                || _line815Fee.Dirty
                || _line816Fee.Dirty
                || _line817Fee.Dirty
                || _line818Fee.Dirty
                || _line819Fee.Dirty
                || _line820Fee.Dirty
                || _line821Fee.Dirty
                || _line822Fee.Dirty
                || _line823Fee.Dirty
                || _line824Fee.Dirty
                || _line825Fee.Dirty
                || _line826Fee.Dirty
                || _line827Fee.Dirty
                || _line828Fee.Dirty
                || _line829Fee.Dirty
                || _line830Fee.Dirty
                || _line831Fee.Dirty
                || _line832Fee.Dirty
                || _line833Fee.Dirty
                || _loanBalanceRiseIndicator.Dirty
                || _loanOriginationFees.Dirty
                || _loanOriginationPercentage.Dirty
                || _loanOriginatorName.Dirty
                || _lowerInterestInitialInterestRate.Dirty
                || _lowerInterestInitialMonthlyAmountOwed.Dirty
                || _lowerInterestMonthlyPaymentReduced.Dirty
                || _lowerInterestServiceChargeIncreasedAmount.Dirty
                || _lowerInterestTotalSettlementCharges.Dirty
                || _lowerSettlementInitialInterestRate.Dirty
                || _lowerSettlementInitialMonthlyAmountOwed.Dirty
                || _lowerSettlementMonthlyPaymentIncreased.Dirty
                || _lowerSettlementServiceChargeReducedAmount.Dirty
                || _lowerSettlementTotalSettlementCharges.Dirty
                || _maximumLoanBalance.Dirty
                || _maximumOwedMonthlyPayment.Dirty
                || _maxLifeInterestCapPercent.Dirty
                || _maxLifeInterestCapPercentUI.Dirty
                || _monthlyPaymentFirstIncreaseDate.Dirty
                || _monthlyPaymentRiseIndicator.Dirty
                || _mortgageInsurancePremium.Dirty
                || _mustLockRateDays.Dirty
                || _newHudSection1100Line1104BorPaidAmount.Dirty
                || _newHudSection1100Line1104SelPaidAmount.Dirty
                || _newHudSection1100Line1107BorPaidAmount.Dirty
                || _newHudSection1100Line1108BorPaidAmount.Dirty
                || _originationCharges.Dirty
                || _originationCreditYsp.Dirty
                || _originationCreditYspAdditional.Dirty
                || _originationPoints.Dirty
                || _originationPointsAdditional.Dirty
                || _originationPointsPercentage.Dirty
                || _ownerTitleInsuranceAmount.Dirty
                || _printNAInLockRateDays.Dirty
                || _printShoppingChartIndicator.Dirty
                || _processingFees.Dirty
                || _requiredAppraisalFee.Dirty
                || _requiredCreditReportFee.Dirty
                || _requiredFloodCertificationFee.Dirty
                || _requiredServicesAmount.Dirty
                || _requiredTaxServiceFee.Dirty
                || _section1000TotalBorrowerPaidAmount.Dirty
                || _section1000TotalOtherPaidAmount.Dirty
                || _section1000TotalPaidAmount.Dirty
                || _section1000TotalSellerPaidAmount.Dirty
                || _section1100TotalBorrowerPaidAmount.Dirty
                || _section1100TotalOtherPaidAmount.Dirty
                || _section1100TotalPaidAmount.Dirty
                || _section1100TotalSellerPaidAmount.Dirty
                || _section1200TotalBorrowerPaidAmount.Dirty
                || _section1200TotalOtherPaidAmount.Dirty
                || _section1200TotalPaidAmount.Dirty
                || _section1200TotalSellerPaidAmount.Dirty
                || _section1300TotalBorrowerPaidAmount.Dirty
                || _section1300TotalOtherPaidAmount.Dirty
                || _section1300TotalPaidAmount.Dirty
                || _section1300TotalSellerPaidAmount.Dirty
                || _section1400TotalBorrowerPaidAmount.Dirty
                || _section1400TotalOtherPaidAmount.Dirty
                || _section1400TotalPaidAmount.Dirty
                || _section1400TotalSellerPaidAmount.Dirty
                || _section700TotalBorrowerPaidAmount.Dirty
                || _section700TotalOtherPaidAmount.Dirty
                || _section700TotalPaidAmount.Dirty
                || _section700TotalSellerPaidAmount.Dirty
                || _section800TotalBorrowerPaidAmount.Dirty
                || _section800TotalOtherPaidAmount.Dirty
                || _section800TotalPaidAmount.Dirty
                || _section800TotalSellerPaidAmount.Dirty
                || _section900TotalBorrowerPaidAmount.Dirty
                || _section900TotalOtherPaidAmount.Dirty
                || _section900TotalPaidAmount.Dirty
                || _section900TotalSellerPaidAmount.Dirty
                || _shopRequiredServicesAmount.Dirty
                || _subsequentCapPercent.Dirty
                || _subsequentRateAdjustmentMonths.Dirty
                || _tableFundedIndicator.Dirty
                || _timeForRate.Dirty
                || _titleServiceAmount.Dirty
                || _totalBelow10.Dirty
                || _totalOfFinancedFees.Dirty
                || _totalSettlementCharges.Dirty
                || _totalTransferTaxes.Dirty
                || _transferTaxes.Dirty
                || _underwritingFees.Dirty
                || _useLOCompTool.Dirty
                || _gfe2010Fees?.Dirty == true
                || _gfe2010WholePocs?.Dirty == true;
            set
            {
                _adjustedOriginationCharges.Dirty = value;
                _allOtherServiceAmount.Dirty = value;
                _applicationFees.Dirty = value;
                _borrowerSelectIndicator10.Dirty = value;
                _borrowerSelectIndicator11.Dirty = value;
                _borrowerSelectIndicator12.Dirty = value;
                _borrowerSelectIndicator13.Dirty = value;
                _borrowerSelectIndicator14.Dirty = value;
                _borrowerSelectIndicator15.Dirty = value;
                _borrowerSelectIndicator16.Dirty = value;
                _borrowerSelectIndicator17.Dirty = value;
                _borrowerSelectIndicator18.Dirty = value;
                _borrowerSelectIndicator19.Dirty = value;
                _borrowerSelectIndicator2.Dirty = value;
                _borrowerSelectIndicator20.Dirty = value;
                _borrowerSelectIndicator3.Dirty = value;
                _borrowerSelectIndicator4.Dirty = value;
                _borrowerSelectIndicator5.Dirty = value;
                _borrowerSelectIndicator6.Dirty = value;
                _borrowerSelectIndicator7.Dirty = value;
                _borrowerSelectIndicator8.Dirty = value;
                _borrowerSelectIndicator9.Dirty = value;
                _brokerAdditionalFees.Dirty = value;
                _brokerFees.Dirty = value;
                _brokerFeesPercentage.Dirty = value;
                _chargeAmount.Dirty = value;
                _chargeAmountForPrint.Dirty = value;
                _copyFromGfeIndicator1.Dirty = value;
                _copyFromGfeIndicator10.Dirty = value;
                _copyFromGfeIndicator11.Dirty = value;
                _copyFromGfeIndicator12.Dirty = value;
                _copyFromGfeIndicator13.Dirty = value;
                _copyFromGfeIndicator14.Dirty = value;
                _copyFromGfeIndicator15.Dirty = value;
                _copyFromGfeIndicator16.Dirty = value;
                _copyFromGfeIndicator17.Dirty = value;
                _copyFromGfeIndicator18.Dirty = value;
                _copyFromGfeIndicator19.Dirty = value;
                _copyFromGfeIndicator2.Dirty = value;
                _copyFromGfeIndicator20.Dirty = value;
                _copyFromGfeIndicator21.Dirty = value;
                _copyFromGfeIndicator22.Dirty = value;
                _copyFromGfeIndicator23.Dirty = value;
                _copyFromGfeIndicator24.Dirty = value;
                _copyFromGfeIndicator25.Dirty = value;
                _copyFromGfeIndicator26.Dirty = value;
                _copyFromGfeIndicator27.Dirty = value;
                _copyFromGfeIndicator28.Dirty = value;
                _copyFromGfeIndicator29.Dirty = value;
                _copyFromGfeIndicator3.Dirty = value;
                _copyFromGfeIndicator30.Dirty = value;
                _copyFromGfeIndicator31.Dirty = value;
                _copyFromGfeIndicator32.Dirty = value;
                _copyFromGfeIndicator33.Dirty = value;
                _copyFromGfeIndicator34.Dirty = value;
                _copyFromGfeIndicator35.Dirty = value;
                _copyFromGfeIndicator4.Dirty = value;
                _copyFromGfeIndicator5.Dirty = value;
                _copyFromGfeIndicator6.Dirty = value;
                _copyFromGfeIndicator7.Dirty = value;
                _copyFromGfeIndicator8.Dirty = value;
                _copyFromGfeIndicator9.Dirty = value;
                _creditAmount.Dirty = value;
                _creditAmountForPrint.Dirty = value;
                _creditChargeType.Dirty = value;
                _creditOrChange.Dirty = value;
                _curedAdjustedOriginationCharges.Dirty = value;
                _curedCreditOrChange.Dirty = value;
                _curedOriginationCharges.Dirty = value;
                _curedTotalTransferTaxes.Dirty = value;
                _dailyInterestCharges.Dirty = value;
                _dateForCharges.Dirty = value;
                _dateForRate.Dirty = value;
                _daysToSettlement.Dirty = value;
                _durationMonths.Dirty = value;
                _escrowChargeAllInsuranceIndicator.Dirty = value;
                _escrowChargeAllPropertyTaxesIndicator.Dirty = value;
                _escrowChargeOtherIndicator.Dirty = value;
                _escrowOtherDescription.Dirty = value;
                _financedFeesFromPrepaid.Dirty = value;
                _gfeGovernmentRecordingCharges.Dirty = value;
                _hazardInsurance.Dirty = value;
                _homeownerInsurance.Dirty = value;
                _hudGuaranteeFee.Dirty = value;
                _id.Dirty = value;
                _includeOriginationPointsCreditType.Dirty = value;
                _initialLoanAmount.Dirty = value;
                _initialMonthlyAmount.Dirty = value;
                _interestRateRiseIndicator.Dirty = value;
                _isCDValidForEarliestClosingDate.Dirty = value;
                _line1001Fee.Dirty = value;
                _line1002Fee.Dirty = value;
                _line1003Fee.Dirty = value;
                _line1004Fee.Dirty = value;
                _line1005Fee.Dirty = value;
                _line1006Fee.Dirty = value;
                _line1007Fee.Dirty = value;
                _line1008Fee.Dirty = value;
                _line1009Fee.Dirty = value;
                _line801BrokerCompensationAdditionalAmount.Dirty = value;
                _line801BrokerCompensationFees.Dirty = value;
                _line801BrokerCompensationRate.Dirty = value;
                _line808Fee.Dirty = value;
                _line809Fee.Dirty = value;
                _line810Fee.Dirty = value;
                _line811Fee.Dirty = value;
                _line812Fee.Dirty = value;
                _line813Fee.Dirty = value;
                _line814Fee.Dirty = value;
                _line815Fee.Dirty = value;
                _line816Fee.Dirty = value;
                _line817Fee.Dirty = value;
                _line818Fee.Dirty = value;
                _line819Fee.Dirty = value;
                _line820Fee.Dirty = value;
                _line821Fee.Dirty = value;
                _line822Fee.Dirty = value;
                _line823Fee.Dirty = value;
                _line824Fee.Dirty = value;
                _line825Fee.Dirty = value;
                _line826Fee.Dirty = value;
                _line827Fee.Dirty = value;
                _line828Fee.Dirty = value;
                _line829Fee.Dirty = value;
                _line830Fee.Dirty = value;
                _line831Fee.Dirty = value;
                _line832Fee.Dirty = value;
                _line833Fee.Dirty = value;
                _loanBalanceRiseIndicator.Dirty = value;
                _loanOriginationFees.Dirty = value;
                _loanOriginationPercentage.Dirty = value;
                _loanOriginatorName.Dirty = value;
                _lowerInterestInitialInterestRate.Dirty = value;
                _lowerInterestInitialMonthlyAmountOwed.Dirty = value;
                _lowerInterestMonthlyPaymentReduced.Dirty = value;
                _lowerInterestServiceChargeIncreasedAmount.Dirty = value;
                _lowerInterestTotalSettlementCharges.Dirty = value;
                _lowerSettlementInitialInterestRate.Dirty = value;
                _lowerSettlementInitialMonthlyAmountOwed.Dirty = value;
                _lowerSettlementMonthlyPaymentIncreased.Dirty = value;
                _lowerSettlementServiceChargeReducedAmount.Dirty = value;
                _lowerSettlementTotalSettlementCharges.Dirty = value;
                _maximumLoanBalance.Dirty = value;
                _maximumOwedMonthlyPayment.Dirty = value;
                _maxLifeInterestCapPercent.Dirty = value;
                _maxLifeInterestCapPercentUI.Dirty = value;
                _monthlyPaymentFirstIncreaseDate.Dirty = value;
                _monthlyPaymentRiseIndicator.Dirty = value;
                _mortgageInsurancePremium.Dirty = value;
                _mustLockRateDays.Dirty = value;
                _newHudSection1100Line1104BorPaidAmount.Dirty = value;
                _newHudSection1100Line1104SelPaidAmount.Dirty = value;
                _newHudSection1100Line1107BorPaidAmount.Dirty = value;
                _newHudSection1100Line1108BorPaidAmount.Dirty = value;
                _originationCharges.Dirty = value;
                _originationCreditYsp.Dirty = value;
                _originationCreditYspAdditional.Dirty = value;
                _originationPoints.Dirty = value;
                _originationPointsAdditional.Dirty = value;
                _originationPointsPercentage.Dirty = value;
                _ownerTitleInsuranceAmount.Dirty = value;
                _printNAInLockRateDays.Dirty = value;
                _printShoppingChartIndicator.Dirty = value;
                _processingFees.Dirty = value;
                _requiredAppraisalFee.Dirty = value;
                _requiredCreditReportFee.Dirty = value;
                _requiredFloodCertificationFee.Dirty = value;
                _requiredServicesAmount.Dirty = value;
                _requiredTaxServiceFee.Dirty = value;
                _section1000TotalBorrowerPaidAmount.Dirty = value;
                _section1000TotalOtherPaidAmount.Dirty = value;
                _section1000TotalPaidAmount.Dirty = value;
                _section1000TotalSellerPaidAmount.Dirty = value;
                _section1100TotalBorrowerPaidAmount.Dirty = value;
                _section1100TotalOtherPaidAmount.Dirty = value;
                _section1100TotalPaidAmount.Dirty = value;
                _section1100TotalSellerPaidAmount.Dirty = value;
                _section1200TotalBorrowerPaidAmount.Dirty = value;
                _section1200TotalOtherPaidAmount.Dirty = value;
                _section1200TotalPaidAmount.Dirty = value;
                _section1200TotalSellerPaidAmount.Dirty = value;
                _section1300TotalBorrowerPaidAmount.Dirty = value;
                _section1300TotalOtherPaidAmount.Dirty = value;
                _section1300TotalPaidAmount.Dirty = value;
                _section1300TotalSellerPaidAmount.Dirty = value;
                _section1400TotalBorrowerPaidAmount.Dirty = value;
                _section1400TotalOtherPaidAmount.Dirty = value;
                _section1400TotalPaidAmount.Dirty = value;
                _section1400TotalSellerPaidAmount.Dirty = value;
                _section700TotalBorrowerPaidAmount.Dirty = value;
                _section700TotalOtherPaidAmount.Dirty = value;
                _section700TotalPaidAmount.Dirty = value;
                _section700TotalSellerPaidAmount.Dirty = value;
                _section800TotalBorrowerPaidAmount.Dirty = value;
                _section800TotalOtherPaidAmount.Dirty = value;
                _section800TotalPaidAmount.Dirty = value;
                _section800TotalSellerPaidAmount.Dirty = value;
                _section900TotalBorrowerPaidAmount.Dirty = value;
                _section900TotalOtherPaidAmount.Dirty = value;
                _section900TotalPaidAmount.Dirty = value;
                _section900TotalSellerPaidAmount.Dirty = value;
                _shopRequiredServicesAmount.Dirty = value;
                _subsequentCapPercent.Dirty = value;
                _subsequentRateAdjustmentMonths.Dirty = value;
                _tableFundedIndicator.Dirty = value;
                _timeForRate.Dirty = value;
                _titleServiceAmount.Dirty = value;
                _totalBelow10.Dirty = value;
                _totalOfFinancedFees.Dirty = value;
                _totalSettlementCharges.Dirty = value;
                _totalTransferTaxes.Dirty = value;
                _transferTaxes.Dirty = value;
                _underwritingFees.Dirty = value;
                _useLOCompTool.Dirty = value;
                if (_gfe2010Fees != null) _gfe2010Fees.Dirty = value;
                if (_gfe2010WholePocs != null) _gfe2010WholePocs.Dirty = value;
            }
        }
    }
}