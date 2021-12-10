using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// Gfe2010
    /// </summary>
    public sealed partial class Gfe2010 : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?>? _adjustedOriginationCharges;
        private DirtyValue<decimal?>? _allOtherServiceAmount;
        private DirtyValue<decimal?>? _applicationFees;
        private DirtyValue<bool?>? _borrowerSelectIndicator10;
        private DirtyValue<bool?>? _borrowerSelectIndicator11;
        private DirtyValue<bool?>? _borrowerSelectIndicator12;
        private DirtyValue<bool?>? _borrowerSelectIndicator13;
        private DirtyValue<bool?>? _borrowerSelectIndicator14;
        private DirtyValue<bool?>? _borrowerSelectIndicator15;
        private DirtyValue<bool?>? _borrowerSelectIndicator16;
        private DirtyValue<bool?>? _borrowerSelectIndicator17;
        private DirtyValue<bool?>? _borrowerSelectIndicator18;
        private DirtyValue<bool?>? _borrowerSelectIndicator19;
        private DirtyValue<bool?>? _borrowerSelectIndicator2;
        private DirtyValue<bool?>? _borrowerSelectIndicator20;
        private DirtyValue<bool?>? _borrowerSelectIndicator3;
        private DirtyValue<bool?>? _borrowerSelectIndicator4;
        private DirtyValue<bool?>? _borrowerSelectIndicator5;
        private DirtyValue<bool?>? _borrowerSelectIndicator6;
        private DirtyValue<bool?>? _borrowerSelectIndicator7;
        private DirtyValue<bool?>? _borrowerSelectIndicator8;
        private DirtyValue<bool?>? _borrowerSelectIndicator9;
        private DirtyValue<decimal?>? _brokerAdditionalFees;
        private DirtyValue<decimal?>? _brokerFees;
        private DirtyValue<decimal?>? _brokerFeesPercentage;
        private DirtyValue<decimal?>? _chargeAmount;
        private DirtyValue<decimal?>? _chargeAmountForPrint;
        private DirtyValue<bool?>? _copyFromGfeIndicator1;
        private DirtyValue<bool?>? _copyFromGfeIndicator10;
        private DirtyValue<bool?>? _copyFromGfeIndicator11;
        private DirtyValue<bool?>? _copyFromGfeIndicator12;
        private DirtyValue<bool?>? _copyFromGfeIndicator13;
        private DirtyValue<bool?>? _copyFromGfeIndicator14;
        private DirtyValue<bool?>? _copyFromGfeIndicator15;
        private DirtyValue<bool?>? _copyFromGfeIndicator16;
        private DirtyValue<bool?>? _copyFromGfeIndicator17;
        private DirtyValue<bool?>? _copyFromGfeIndicator18;
        private DirtyValue<bool?>? _copyFromGfeIndicator19;
        private DirtyValue<bool?>? _copyFromGfeIndicator2;
        private DirtyValue<bool?>? _copyFromGfeIndicator20;
        private DirtyValue<bool?>? _copyFromGfeIndicator21;
        private DirtyValue<bool?>? _copyFromGfeIndicator22;
        private DirtyValue<bool?>? _copyFromGfeIndicator23;
        private DirtyValue<bool?>? _copyFromGfeIndicator24;
        private DirtyValue<bool?>? _copyFromGfeIndicator25;
        private DirtyValue<bool?>? _copyFromGfeIndicator26;
        private DirtyValue<bool?>? _copyFromGfeIndicator27;
        private DirtyValue<bool?>? _copyFromGfeIndicator28;
        private DirtyValue<bool?>? _copyFromGfeIndicator29;
        private DirtyValue<bool?>? _copyFromGfeIndicator3;
        private DirtyValue<bool?>? _copyFromGfeIndicator30;
        private DirtyValue<bool?>? _copyFromGfeIndicator31;
        private DirtyValue<bool?>? _copyFromGfeIndicator32;
        private DirtyValue<bool?>? _copyFromGfeIndicator33;
        private DirtyValue<bool?>? _copyFromGfeIndicator34;
        private DirtyValue<bool?>? _copyFromGfeIndicator35;
        private DirtyValue<bool?>? _copyFromGfeIndicator4;
        private DirtyValue<bool?>? _copyFromGfeIndicator5;
        private DirtyValue<bool?>? _copyFromGfeIndicator6;
        private DirtyValue<bool?>? _copyFromGfeIndicator7;
        private DirtyValue<bool?>? _copyFromGfeIndicator8;
        private DirtyValue<bool?>? _copyFromGfeIndicator9;
        private DirtyValue<decimal?>? _creditAmount;
        private DirtyValue<decimal?>? _creditAmountForPrint;
        private DirtyValue<StringEnumValue<CreditChargeType>>? _creditChargeType;
        private DirtyValue<decimal?>? _creditOrChange;
        private DirtyValue<decimal?>? _curedAdjustedOriginationCharges;
        private DirtyValue<decimal?>? _curedCreditOrChange;
        private DirtyValue<decimal?>? _curedOriginationCharges;
        private DirtyValue<decimal?>? _curedTotalTransferTaxes;
        private DirtyValue<decimal?>? _dailyInterestCharges;
        private DirtyValue<DateTime?>? _dateForCharges;
        private DirtyValue<string?>? _dateForRate;
        private DirtyValue<string?>? _daysToSettlement;
        private DirtyValue<int?>? _durationMonths;
        private DirtyValue<bool?>? _escrowChargeAllInsuranceIndicator;
        private DirtyValue<bool?>? _escrowChargeAllPropertyTaxesIndicator;
        private DirtyValue<bool?>? _escrowChargeOtherIndicator;
        private DirtyValue<string?>? _escrowOtherDescription;
        private DirtyValue<decimal?>? _financedFeesFromPrepaid;
        private DirtyList<Gfe2010Fee>? _gfe2010Fees;
        private DirtyList<Gfe2010WholePoc>? _gfe2010WholePocs;
        private DirtyValue<decimal?>? _gfeGovernmentRecordingCharges;
        private DirtyValue<decimal?>? _hazardInsurance;
        private DirtyValue<decimal?>? _homeownerInsurance;
        private DirtyValue<decimal?>? _hudGuaranteeFee;
        private DirtyValue<string?>? _id;
        private DirtyValue<StringEnumValue<IncludeOriginationPointsCreditType>>? _includeOriginationPointsCreditType;
        private DirtyValue<decimal?>? _initialLoanAmount;
        private DirtyValue<decimal?>? _initialMonthlyAmount;
        private DirtyValue<bool?>? _interestRateRiseIndicator;
        private DirtyValue<bool?>? _isCDValidForEarliestClosingDate;
        private DirtyValue<decimal?>? _line1001Fee;
        private DirtyValue<decimal?>? _line1002Fee;
        private DirtyValue<decimal?>? _line1003Fee;
        private DirtyValue<decimal?>? _line1004Fee;
        private DirtyValue<decimal?>? _line1005Fee;
        private DirtyValue<decimal?>? _line1006Fee;
        private DirtyValue<decimal?>? _line1007Fee;
        private DirtyValue<decimal?>? _line1008Fee;
        private DirtyValue<decimal?>? _line1009Fee;
        private DirtyValue<decimal?>? _line801BrokerCompensationAdditionalAmount;
        private DirtyValue<decimal?>? _line801BrokerCompensationFees;
        private DirtyValue<decimal?>? _line801BrokerCompensationRate;
        private DirtyValue<decimal?>? _line808Fee;
        private DirtyValue<decimal?>? _line809Fee;
        private DirtyValue<decimal?>? _line810Fee;
        private DirtyValue<decimal?>? _line811Fee;
        private DirtyValue<decimal?>? _line812Fee;
        private DirtyValue<decimal?>? _line813Fee;
        private DirtyValue<decimal?>? _line814Fee;
        private DirtyValue<decimal?>? _line815Fee;
        private DirtyValue<decimal?>? _line816Fee;
        private DirtyValue<decimal?>? _line817Fee;
        private DirtyValue<decimal?>? _line818Fee;
        private DirtyValue<decimal?>? _line819Fee;
        private DirtyValue<decimal?>? _line820Fee;
        private DirtyValue<decimal?>? _line821Fee;
        private DirtyValue<decimal?>? _line822Fee;
        private DirtyValue<decimal?>? _line823Fee;
        private DirtyValue<decimal?>? _line824Fee;
        private DirtyValue<decimal?>? _line825Fee;
        private DirtyValue<decimal?>? _line826Fee;
        private DirtyValue<decimal?>? _line827Fee;
        private DirtyValue<decimal?>? _line828Fee;
        private DirtyValue<decimal?>? _line829Fee;
        private DirtyValue<decimal?>? _line830Fee;
        private DirtyValue<decimal?>? _line831Fee;
        private DirtyValue<decimal?>? _line832Fee;
        private DirtyValue<decimal?>? _line833Fee;
        private DirtyValue<bool?>? _loanBalanceRiseIndicator;
        private DirtyValue<decimal?>? _loanOriginationFees;
        private DirtyValue<decimal?>? _loanOriginationPercentage;
        private DirtyValue<string?>? _loanOriginatorName;
        private DirtyValue<decimal?>? _lowerInterestInitialInterestRate;
        private DirtyValue<decimal?>? _lowerInterestInitialMonthlyAmountOwed;
        private DirtyValue<decimal?>? _lowerInterestMonthlyPaymentReduced;
        private DirtyValue<decimal?>? _lowerInterestServiceChargeIncreasedAmount;
        private DirtyValue<decimal?>? _lowerInterestTotalSettlementCharges;
        private DirtyValue<decimal?>? _lowerSettlementInitialInterestRate;
        private DirtyValue<decimal?>? _lowerSettlementInitialMonthlyAmountOwed;
        private DirtyValue<decimal?>? _lowerSettlementMonthlyPaymentIncreased;
        private DirtyValue<decimal?>? _lowerSettlementServiceChargeReducedAmount;
        private DirtyValue<decimal?>? _lowerSettlementTotalSettlementCharges;
        private DirtyValue<decimal?>? _maximumLoanBalance;
        private DirtyValue<decimal?>? _maximumOwedMonthlyPayment;
        private DirtyValue<decimal?>? _maxLifeInterestCapPercent;
        private DirtyValue<string?>? _maxLifeInterestCapPercentUI;
        private DirtyValue<int?>? _monthlyPaymentFirstIncreaseDate;
        private DirtyValue<bool?>? _monthlyPaymentRiseIndicator;
        private DirtyValue<decimal?>? _mortgageInsurancePremium;
        private DirtyValue<string?>? _mustLockRateDays;
        private DirtyValue<decimal?>? _newHudSection1100Line1104BorPaidAmount;
        private DirtyValue<decimal?>? _newHudSection1100Line1104SelPaidAmount;
        private DirtyValue<decimal?>? _newHudSection1100Line1107BorPaidAmount;
        private DirtyValue<decimal?>? _newHudSection1100Line1108BorPaidAmount;
        private DirtyValue<decimal?>? _originationCharges;
        private DirtyValue<decimal?>? _originationCreditYsp;
        private DirtyValue<decimal?>? _originationCreditYspAdditional;
        private DirtyValue<decimal?>? _originationPoints;
        private DirtyValue<decimal?>? _originationPointsAdditional;
        private DirtyValue<decimal?>? _originationPointsPercentage;
        private DirtyValue<NA<decimal>>? _ownerTitleInsuranceAmount;
        private DirtyValue<bool?>? _printNAInLockRateDays;
        private DirtyValue<bool?>? _printShoppingChartIndicator;
        private DirtyValue<decimal?>? _processingFees;
        private DirtyValue<decimal?>? _requiredAppraisalFee;
        private DirtyValue<decimal?>? _requiredCreditReportFee;
        private DirtyValue<decimal?>? _requiredFloodCertificationFee;
        private DirtyValue<decimal?>? _requiredServicesAmount;
        private DirtyValue<decimal?>? _requiredTaxServiceFee;
        private DirtyValue<decimal?>? _section1000TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section1000TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section1000TotalPaidAmount;
        private DirtyValue<decimal?>? _section1000TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section1100TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section1100TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section1100TotalPaidAmount;
        private DirtyValue<decimal?>? _section1100TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section1200TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section1200TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section1200TotalPaidAmount;
        private DirtyValue<decimal?>? _section1200TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section1300TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section1300TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section1300TotalPaidAmount;
        private DirtyValue<decimal?>? _section1300TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section1400TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section1400TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section1400TotalPaidAmount;
        private DirtyValue<decimal?>? _section1400TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section700TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section700TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section700TotalPaidAmount;
        private DirtyValue<decimal?>? _section700TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section800TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section800TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section800TotalPaidAmount;
        private DirtyValue<decimal?>? _section800TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _section900TotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _section900TotalOtherPaidAmount;
        private DirtyValue<decimal?>? _section900TotalPaidAmount;
        private DirtyValue<decimal?>? _section900TotalSellerPaidAmount;
        private DirtyValue<decimal?>? _sectionPCTotalBorrowerPaidAmount;
        private DirtyValue<decimal?>? _sectionPCTotalOtherPaidAmount;
        private DirtyValue<decimal?>? _sectionPCTotalPaidAmount;
        private DirtyValue<decimal?>? _sectionPCTotalSellerPaidAmount;
        private DirtyValue<decimal?>? _shopRequiredServicesAmount;
        private DirtyValue<decimal?>? _subsequentCapPercent;
        private DirtyValue<decimal?>? _subsequentlyPaidFinanceCharge;
        private DirtyValue<int?>? _subsequentRateAdjustmentMonths;
        private DirtyValue<bool?>? _tableFundedIndicator;
        private DirtyValue<string?>? _timeForRate;
        private DirtyValue<decimal?>? _titleServiceAmount;
        private DirtyValue<decimal?>? _totalBelow10;
        private DirtyValue<decimal?>? _totalOfFinancedFees;
        private DirtyValue<decimal?>? _totalSettlementCharges;
        private DirtyValue<decimal?>? _totalTransferTaxes;
        private DirtyValue<decimal?>? _transferTaxes;
        private DirtyValue<decimal?>? _underwritingFees;
        private DirtyValue<bool?>? _useLOCompTool;

        /// <summary>
        /// Fees Adj Orig Chrgs Applied to GFE [NEWHUD.X16]
        /// </summary>
        public decimal? AdjustedOriginationCharges { get => _adjustedOriginationCharges; set => SetField(ref _adjustedOriginationCharges, value); }

        /// <summary>
        /// HUD-All Other Settlement Services [NEWHUD.X92]
        /// </summary>
        public decimal? AllOtherServiceAmount { get => _allOtherServiceAmount; set => SetField(ref _allOtherServiceAmount, value); }

        /// <summary>
        /// Fees Application Fees Applied to GFE [NEWHUD.X702]
        /// </summary>
        public decimal? ApplicationFees { get => _applicationFees; set => SetField(ref _applicationFees, value); }

        /// <summary>
        /// Fees Line 1309 Borr Selects [NEWHUD.X115]
        /// </summary>
        public bool? BorrowerSelectIndicator10 { get => _borrowerSelectIndicator10; set => SetField(ref _borrowerSelectIndicator10, value); }

        /// <summary>
        /// Fees Line 1310 Borr Selects [NEWHUD.X116]
        /// </summary>
        public bool? BorrowerSelectIndicator11 { get => _borrowerSelectIndicator11; set => SetField(ref _borrowerSelectIndicator11, value); }

        /// <summary>
        /// Fees Line 1311 Borr Selects [NEWHUD.X117]
        /// </summary>
        public bool? BorrowerSelectIndicator12 { get => _borrowerSelectIndicator12; set => SetField(ref _borrowerSelectIndicator12, value); }

        /// <summary>
        /// Gfe2010 BorrowerSelectIndicator13
        /// </summary>
        public bool? BorrowerSelectIndicator13 { get => _borrowerSelectIndicator13; set => SetField(ref _borrowerSelectIndicator13, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 1 [NEWHUD.X119]
        /// </summary>
        public bool? BorrowerSelectIndicator14 { get => _borrowerSelectIndicator14; set => SetField(ref _borrowerSelectIndicator14, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 2 [NEWHUD.X120]
        /// </summary>
        public bool? BorrowerSelectIndicator15 { get => _borrowerSelectIndicator15; set => SetField(ref _borrowerSelectIndicator15, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 3 [NEWHUD.X121]
        /// </summary>
        public bool? BorrowerSelectIndicator16 { get => _borrowerSelectIndicator16; set => SetField(ref _borrowerSelectIndicator16, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 4 [NEWHUD.X122]
        /// </summary>
        public bool? BorrowerSelectIndicator17 { get => _borrowerSelectIndicator17; set => SetField(ref _borrowerSelectIndicator17, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 5 [NEWHUD.X123]
        /// </summary>
        public bool? BorrowerSelectIndicator18 { get => _borrowerSelectIndicator18; set => SetField(ref _borrowerSelectIndicator18, value); }

        /// <summary>
        /// Borr Selects Homeowner Ins - Line 6 [NEWHUD.X124]
        /// </summary>
        public bool? BorrowerSelectIndicator19 { get => _borrowerSelectIndicator19; set => SetField(ref _borrowerSelectIndicator19, value); }

        /// <summary>
        /// Fees Line 1103 Borr Selects [NEWHUD.X107]
        /// </summary>
        public bool? BorrowerSelectIndicator2 { get => _borrowerSelectIndicator2; set => SetField(ref _borrowerSelectIndicator2, value); }

        /// <summary>
        /// Homeowner Ins 7 Borr Select [NEWHUD.X655]
        /// </summary>
        public bool? BorrowerSelectIndicator20 { get => _borrowerSelectIndicator20; set => SetField(ref _borrowerSelectIndicator20, value); }

        /// <summary>
        /// Fees Line 1302 Borr Selects [NEWHUD.X108]
        /// </summary>
        public bool? BorrowerSelectIndicator3 { get => _borrowerSelectIndicator3; set => SetField(ref _borrowerSelectIndicator3, value); }

        /// <summary>
        /// Fees Line 1303 Borr Selects [NEWHUD.X109]
        /// </summary>
        public bool? BorrowerSelectIndicator4 { get => _borrowerSelectIndicator4; set => SetField(ref _borrowerSelectIndicator4, value); }

        /// <summary>
        /// Fees Line 1304 Borr Selects [NEWHUD.X110]
        /// </summary>
        public bool? BorrowerSelectIndicator5 { get => _borrowerSelectIndicator5; set => SetField(ref _borrowerSelectIndicator5, value); }

        /// <summary>
        /// Fees Line 1305 Borr Selects [NEWHUD.X111]
        /// </summary>
        public bool? BorrowerSelectIndicator6 { get => _borrowerSelectIndicator6; set => SetField(ref _borrowerSelectIndicator6, value); }

        /// <summary>
        /// Fees Line 1306 Borr Selects [NEWHUD.X112]
        /// </summary>
        public bool? BorrowerSelectIndicator7 { get => _borrowerSelectIndicator7; set => SetField(ref _borrowerSelectIndicator7, value); }

        /// <summary>
        /// Fees Line 1307 Borr Selects [NEWHUD.X113]
        /// </summary>
        public bool? BorrowerSelectIndicator8 { get => _borrowerSelectIndicator8; set => SetField(ref _borrowerSelectIndicator8, value); }

        /// <summary>
        /// Fees Line 1308 Borr Selects [NEWHUD.X114]
        /// </summary>
        public bool? BorrowerSelectIndicator9 { get => _borrowerSelectIndicator9; set => SetField(ref _borrowerSelectIndicator9, value); }

        /// <summary>
        /// Broker Additional Fees [NEWHUD.X706]
        /// </summary>
        public decimal? BrokerAdditionalFees { get => _brokerAdditionalFees; set => SetField(ref _brokerAdditionalFees, value); }

        /// <summary>
        /// Broker Fees Applied to GFE [NEWHUD.X707]
        /// </summary>
        public decimal? BrokerFees { get => _brokerFees; set => SetField(ref _brokerFees, value); }

        /// <summary>
        /// Broker Fees Percent [NEWHUD.X705]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? BrokerFeesPercentage { get => _brokerFeesPercentage; set => SetField(ref _brokerFeesPercentage, value); }

        /// <summary>
        /// Borr Charge Amt for Points - Itemization [NEWHUD.X720]
        /// </summary>
        public decimal? ChargeAmount { get => _chargeAmount; set => SetField(ref _chargeAmount, value); }

        /// <summary>
        /// Borr Charge Amt for Points - GFE [NEWHUD.X722]
        /// </summary>
        public decimal? ChargeAmountForPrint { get => _chargeAmountForPrint; set => SetField(ref _chargeAmountForPrint, value); }

        /// <summary>
        /// HUD Copy from Itemization 1 [NEWHUD.X522]
        /// </summary>
        public bool? CopyFromGfeIndicator1 { get => _copyFromGfeIndicator1; set => SetField(ref _copyFromGfeIndicator1, value); }

        /// <summary>
        /// HUD Copy from Itemization 10 [NEWHUD.X531]
        /// </summary>
        public bool? CopyFromGfeIndicator10 { get => _copyFromGfeIndicator10; set => SetField(ref _copyFromGfeIndicator10, value); }

        /// <summary>
        /// HUD Copy from Itemization 11 [NEWHUD.X532]
        /// </summary>
        public bool? CopyFromGfeIndicator11 { get => _copyFromGfeIndicator11; set => SetField(ref _copyFromGfeIndicator11, value); }

        /// <summary>
        /// HUD Copy from Itemization 12 [NEWHUD.X533]
        /// </summary>
        public bool? CopyFromGfeIndicator12 { get => _copyFromGfeIndicator12; set => SetField(ref _copyFromGfeIndicator12, value); }

        /// <summary>
        /// HUD Copy from Itemization 13 [NEWHUD.X534]
        /// </summary>
        public bool? CopyFromGfeIndicator13 { get => _copyFromGfeIndicator13; set => SetField(ref _copyFromGfeIndicator13, value); }

        /// <summary>
        /// HUD Copy from Itemization 14 [NEWHUD.X535]
        /// </summary>
        public bool? CopyFromGfeIndicator14 { get => _copyFromGfeIndicator14; set => SetField(ref _copyFromGfeIndicator14, value); }

        /// <summary>
        /// HUD Copy from Itemization 15 [NEWHUD.X536]
        /// </summary>
        public bool? CopyFromGfeIndicator15 { get => _copyFromGfeIndicator15; set => SetField(ref _copyFromGfeIndicator15, value); }

        /// <summary>
        /// HUD Copy from Itemization 16 [NEWHUD.X537]
        /// </summary>
        public bool? CopyFromGfeIndicator16 { get => _copyFromGfeIndicator16; set => SetField(ref _copyFromGfeIndicator16, value); }

        /// <summary>
        /// HUD Copy from Itemization 17 [NEWHUD.X538]
        /// </summary>
        public bool? CopyFromGfeIndicator17 { get => _copyFromGfeIndicator17; set => SetField(ref _copyFromGfeIndicator17, value); }

        /// <summary>
        /// HUD Copy from Itemization 18 [NEWHUD.X539]
        /// </summary>
        public bool? CopyFromGfeIndicator18 { get => _copyFromGfeIndicator18; set => SetField(ref _copyFromGfeIndicator18, value); }

        /// <summary>
        /// HUD Copy from Itemization 19 [NEWHUD.X540]
        /// </summary>
        public bool? CopyFromGfeIndicator19 { get => _copyFromGfeIndicator19; set => SetField(ref _copyFromGfeIndicator19, value); }

        /// <summary>
        /// HUD Copy from Itemization 2 [NEWHUD.X523]
        /// </summary>
        public bool? CopyFromGfeIndicator2 { get => _copyFromGfeIndicator2; set => SetField(ref _copyFromGfeIndicator2, value); }

        /// <summary>
        /// HUD Copy from Itemization 20 [NEWHUD.X541]
        /// </summary>
        public bool? CopyFromGfeIndicator20 { get => _copyFromGfeIndicator20; set => SetField(ref _copyFromGfeIndicator20, value); }

        /// <summary>
        /// HUD Copy from Itemization 21 [NEWHUD.X542]
        /// </summary>
        public bool? CopyFromGfeIndicator21 { get => _copyFromGfeIndicator21; set => SetField(ref _copyFromGfeIndicator21, value); }

        /// <summary>
        /// HUD Copy from Itemization 22 [NEWHUD.X543]
        /// </summary>
        public bool? CopyFromGfeIndicator22 { get => _copyFromGfeIndicator22; set => SetField(ref _copyFromGfeIndicator22, value); }

        /// <summary>
        /// HUD Copy from Itemization 23 [NEWHUD.X544]
        /// </summary>
        public bool? CopyFromGfeIndicator23 { get => _copyFromGfeIndicator23; set => SetField(ref _copyFromGfeIndicator23, value); }

        /// <summary>
        /// HUD Copy from Itemization 24 [NEWHUD.X545]
        /// </summary>
        public bool? CopyFromGfeIndicator24 { get => _copyFromGfeIndicator24; set => SetField(ref _copyFromGfeIndicator24, value); }

        /// <summary>
        /// HUD Copy from Itemization 25 [NEWHUD.X546]
        /// </summary>
        public bool? CopyFromGfeIndicator25 { get => _copyFromGfeIndicator25; set => SetField(ref _copyFromGfeIndicator25, value); }

        /// <summary>
        /// HUD Copy from Itemization 26 [NEWHUD.X547]
        /// </summary>
        public bool? CopyFromGfeIndicator26 { get => _copyFromGfeIndicator26; set => SetField(ref _copyFromGfeIndicator26, value); }

        /// <summary>
        /// HUD Copy from Itemization 27 [NEWHUD.X548]
        /// </summary>
        public bool? CopyFromGfeIndicator27 { get => _copyFromGfeIndicator27; set => SetField(ref _copyFromGfeIndicator27, value); }

        /// <summary>
        /// HUD Copy from Itemization 28 [NEWHUD.X549]
        /// </summary>
        public bool? CopyFromGfeIndicator28 { get => _copyFromGfeIndicator28; set => SetField(ref _copyFromGfeIndicator28, value); }

        /// <summary>
        /// HUD Copy from Itemization 29 [NEWHUD.X550]
        /// </summary>
        public bool? CopyFromGfeIndicator29 { get => _copyFromGfeIndicator29; set => SetField(ref _copyFromGfeIndicator29, value); }

        /// <summary>
        /// HUD Copy from Itemization 3 [NEWHUD.X524]
        /// </summary>
        public bool? CopyFromGfeIndicator3 { get => _copyFromGfeIndicator3; set => SetField(ref _copyFromGfeIndicator3, value); }

        /// <summary>
        /// HUD Copy from Itemization 30 [NEWHUD.X551]
        /// </summary>
        public bool? CopyFromGfeIndicator30 { get => _copyFromGfeIndicator30; set => SetField(ref _copyFromGfeIndicator30, value); }

        /// <summary>
        /// HUD Copy from Itemization 31 [NEWHUD.X552]
        /// </summary>
        public bool? CopyFromGfeIndicator31 { get => _copyFromGfeIndicator31; set => SetField(ref _copyFromGfeIndicator31, value); }

        /// <summary>
        /// HUD Copy from Itemization 32 [NEWHUD.X553]
        /// </summary>
        public bool? CopyFromGfeIndicator32 { get => _copyFromGfeIndicator32; set => SetField(ref _copyFromGfeIndicator32, value); }

        /// <summary>
        /// HUD Copy from Itemization 33 [NEWHUD.X554]
        /// </summary>
        public bool? CopyFromGfeIndicator33 { get => _copyFromGfeIndicator33; set => SetField(ref _copyFromGfeIndicator33, value); }

        /// <summary>
        /// HUD Copy from Itemization 34 [NEWHUD.X620]
        /// </summary>
        public bool? CopyFromGfeIndicator34 { get => _copyFromGfeIndicator34; set => SetField(ref _copyFromGfeIndicator34, value); }

        /// <summary>
        /// HUD Copy from Itemization 35 [NEWHUD.X621]
        /// </summary>
        public bool? CopyFromGfeIndicator35 { get => _copyFromGfeIndicator35; set => SetField(ref _copyFromGfeIndicator35, value); }

        /// <summary>
        /// HUD Copy from Itemization 4 [NEWHUD.X525]
        /// </summary>
        public bool? CopyFromGfeIndicator4 { get => _copyFromGfeIndicator4; set => SetField(ref _copyFromGfeIndicator4, value); }

        /// <summary>
        /// HUD Copy from Itemization 5 [NEWHUD.X526]
        /// </summary>
        public bool? CopyFromGfeIndicator5 { get => _copyFromGfeIndicator5; set => SetField(ref _copyFromGfeIndicator5, value); }

        /// <summary>
        /// HUD Copy from Itemization 6 [NEWHUD.X527]
        /// </summary>
        public bool? CopyFromGfeIndicator6 { get => _copyFromGfeIndicator6; set => SetField(ref _copyFromGfeIndicator6, value); }

        /// <summary>
        /// HUD Copy from Itemization 7 [NEWHUD.X528]
        /// </summary>
        public bool? CopyFromGfeIndicator7 { get => _copyFromGfeIndicator7; set => SetField(ref _copyFromGfeIndicator7, value); }

        /// <summary>
        /// HUD Copy from Itemization 8 [NEWHUD.X529]
        /// </summary>
        public bool? CopyFromGfeIndicator8 { get => _copyFromGfeIndicator8; set => SetField(ref _copyFromGfeIndicator8, value); }

        /// <summary>
        /// HUD Copy from Itemization 9 [NEWHUD.X530]
        /// </summary>
        public bool? CopyFromGfeIndicator9 { get => _copyFromGfeIndicator9; set => SetField(ref _copyFromGfeIndicator9, value); }

        /// <summary>
        /// GFE Credit Amount [NEWHUD.X718]
        /// </summary>
        public decimal? CreditAmount { get => _creditAmount; set => SetField(ref _creditAmount, value); }

        /// <summary>
        /// Borr Orig Fee Credit for Int Rate [NEWHUD.X721]
        /// </summary>
        public decimal? CreditAmountForPrint { get => _creditAmountForPrint; set => SetField(ref _creditAmountForPrint, value); }

        /// <summary>
        /// Can Monthly Payment Rise [NEWHUD.X14]
        /// </summary>
        public StringEnumValue<CreditChargeType> CreditChargeType { get => _creditChargeType; set => SetField(ref _creditChargeType, value); }

        /// <summary>
        /// Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.X13]
        /// </summary>
        public decimal? CreditOrChange { get => _creditOrChange; set => SetField(ref _creditOrChange, value); }

        /// <summary>
        /// Cured Fees Adj Orig Chrgs Applied to GFE [NEWHUD.CuredX16]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CuredAdjustedOriginationCharges { get => _curedAdjustedOriginationCharges; set => SetField(ref _curedAdjustedOriginationCharges, value); }

        /// <summary>
        /// Cured Cred/Chrgs for Spec Int Rate Applied to GFE [NEWHUD.CuredX13]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CuredCreditOrChange { get => _curedCreditOrChange; set => SetField(ref _curedCreditOrChange, value); }

        /// <summary>
        /// Cured Total Est Origination Charges [NEWHUD.CuredX12]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CuredOriginationCharges { get => _curedOriginationCharges; set => SetField(ref _curedOriginationCharges, value); }

        /// <summary>
        /// Cured Transfer Tax Total GFE [NEWHUD.CuredX76]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public decimal? CuredTotalTransferTaxes { get => _curedTotalTransferTaxes; set => SetField(ref _curedTotalTransferTaxes, value); }

        /// <summary>
        /// Fees Daily Int Chrgs Applied to GFE [NEWHUD.X701]
        /// </summary>
        public decimal? DailyInterestCharges { get => _dailyInterestCharges; set => SetField(ref _dailyInterestCharges, value); }

        /// <summary>
        /// Avail Date for All Other GFE Sttlmnt Chrgs [NEWHUD.X2]
        /// </summary>
        public DateTime? DateForCharges { get => _dateForCharges; set => SetField(ref _dateForCharges, value); }

        /// <summary>
        /// Avail Date for GFE Interest Rate [NEWHUD.X1]
        /// </summary>
        public string? DateForRate { get => _dateForRate; set => SetField(ref _dateForRate, value); }

        /// <summary>
        /// No. Days from Rate Lock to Settlement [NEWHUD.X719]
        /// </summary>
        public string? DaysToSettlement { get => _daysToSettlement; set => SetField(ref _daysToSettlement, value); }

        /// <summary>
        /// ARM Rate Adj Period [NEWHUD.X557]
        /// </summary>
        public int? DurationMonths { get => _durationMonths; set => SetField(ref _durationMonths, value); }

        /// <summary>
        /// Escrow Acct Chrg Type All Insurance [NEWHUD.X350]
        /// </summary>
        public bool? EscrowChargeAllInsuranceIndicator { get => _escrowChargeAllInsuranceIndicator; set => SetField(ref _escrowChargeAllInsuranceIndicator, value); }

        /// <summary>
        /// Escrow Acct Chrg Type All Prop Taxes [NEWHUD.X349]
        /// </summary>
        public bool? EscrowChargeAllPropertyTaxesIndicator { get => _escrowChargeAllPropertyTaxesIndicator; set => SetField(ref _escrowChargeAllPropertyTaxesIndicator, value); }

        /// <summary>
        /// Escrow Acct Chrg Type Other [NEWHUD.X351]
        /// </summary>
        public bool? EscrowChargeOtherIndicator { get => _escrowChargeOtherIndicator; set => SetField(ref _escrowChargeOtherIndicator, value); }

        /// <summary>
        /// Other Escrow Descr [NEWHUD.X78]
        /// </summary>
        public string? EscrowOtherDescription { get => _escrowOtherDescription; set => SetField(ref _escrowOtherDescription, value); }

        /// <summary>
        /// Borr Total of Prepaid Financed Fees [NEWHUD.X1704]
        /// </summary>
        public decimal? FinancedFeesFromPrepaid { get => _financedFeesFromPrepaid; set => SetField(ref _financedFeesFromPrepaid, value); }

        /// <summary>
        /// Gfe2010 Gfe2010Fees
        /// </summary>
        [AllowNull]
        public IList<Gfe2010Fee> Gfe2010Fees { get => GetField(ref _gfe2010Fees); set => SetField(ref _gfe2010Fees, value); }

        /// <summary>
        /// Gfe2010 Gfe2010WholePocs
        /// </summary>
        [AllowNull]
        public IList<Gfe2010WholePoc> Gfe2010WholePocs { get => GetField(ref _gfe2010WholePocs); set => SetField(ref _gfe2010WholePocs, value); }

        /// <summary>
        /// Fees Line 1201 Applied to GFE [NEWHUD.X214]
        /// </summary>
        public decimal? GfeGovernmentRecordingCharges { get => _gfeGovernmentRecordingCharges; set => SetField(ref _gfeGovernmentRecordingCharges, value); }

        /// <summary>
        /// Fees Homeowner's Ins Fee Applied to GFE [NEWHUD.X650]
        /// </summary>
        public decimal? HazardInsurance { get => _hazardInsurance; set => SetField(ref _hazardInsurance, value); }

        /// <summary>
        /// Homeowner Ins Total Amt [NEWHUD.X79]
        /// </summary>
        public decimal? HomeownerInsurance { get => _homeownerInsurance; set => SetField(ref _homeownerInsurance, value); }

        /// <summary>
        /// Fees Line 1010 Guarantee Fee Applied to GFE [NEWHUD.X1709]
        /// </summary>
        public decimal? HudGuaranteeFee { get => _hudGuaranteeFee; set => SetField(ref _hudGuaranteeFee, value); }

        /// <summary>
        /// Gfe2010 Id
        /// </summary>
        public string? Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Include Points/Credit in Orig Chrg [NEWHUD.X714]
        /// </summary>
        public StringEnumValue<IncludeOriginationPointsCreditType> IncludeOriginationPointsCreditType { get => _includeOriginationPointsCreditType; set => SetField(ref _includeOriginationPointsCreditType, value); }

        /// <summary>
        /// Initial Loan Amount [NEWHUD.X4]
        /// </summary>
        public decimal? InitialLoanAmount { get => _initialLoanAmount; set => SetField(ref _initialLoanAmount, value); }

        /// <summary>
        /// Initial Mthly Pymt Princpl, Int, &amp; Mrtg Ins [NEWHUD.X217]
        /// </summary>
        public decimal? InitialMonthlyAmount { get => _initialMonthlyAmount; set => SetField(ref _initialMonthlyAmount, value); }

        /// <summary>
        /// Can Your Interest Rate Rise [NEWHUD.X5]
        /// </summary>
        public bool? InterestRateRiseIndicator { get => _interestRateRiseIndicator; set => SetField(ref _interestRateRiseIndicator, value); }

        /// <summary>
        /// Is CD Valid for Earliest Closing Date Calculation [4082]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public bool? IsCDValidForEarliestClosingDate { get => _isCDValidForEarliestClosingDate; set => SetField(ref _isCDValidForEarliestClosingDate, value); }

        /// <summary>
        /// Fees Line 1001 Applied to GFE [NEWHUD.X691]
        /// </summary>
        public decimal? Line1001Fee { get => _line1001Fee; set => SetField(ref _line1001Fee, value); }

        /// <summary>
        /// Fees Line 1002 Applied to GFE [NEWHUD.X692]
        /// </summary>
        public decimal? Line1002Fee { get => _line1002Fee; set => SetField(ref _line1002Fee, value); }

        /// <summary>
        /// Fees Line 1003 Applied to GFE [NEWHUD.X693]
        /// </summary>
        public decimal? Line1003Fee { get => _line1003Fee; set => SetField(ref _line1003Fee, value); }

        /// <summary>
        /// Fees Line 1004 Applied to GFE [NEWHUD.X694]
        /// </summary>
        public decimal? Line1004Fee { get => _line1004Fee; set => SetField(ref _line1004Fee, value); }

        /// <summary>
        /// Fees Line 1005 Applied to GFE [NEWHUD.X695]
        /// </summary>
        public decimal? Line1005Fee { get => _line1005Fee; set => SetField(ref _line1005Fee, value); }

        /// <summary>
        /// Fees Line 1006 Applied to GFE [NEWHUD.X696]
        /// </summary>
        public decimal? Line1006Fee { get => _line1006Fee; set => SetField(ref _line1006Fee, value); }

        /// <summary>
        /// Fees Line 1007 Applied to GFE [NEWHUD.X697]
        /// </summary>
        public decimal? Line1007Fee { get => _line1007Fee; set => SetField(ref _line1007Fee, value); }

        /// <summary>
        /// Fees Line 1008 Applied to GFE [NEWHUD.X698]
        /// </summary>
        public decimal? Line1008Fee { get => _line1008Fee; set => SetField(ref _line1008Fee, value); }

        /// <summary>
        /// Fees Line 1009 Applied to GFE [NEWHUD.X699]
        /// </summary>
        public decimal? Line1009Fee { get => _line1009Fee; set => SetField(ref _line1009Fee, value); }

        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Additional Amount [NEWHUD.X247]
        /// </summary>
        public decimal? Line801BrokerCompensationAdditionalAmount { get => _line801BrokerCompensationAdditionalAmount; set => SetField(ref _line801BrokerCompensationAdditionalAmount, value); }

        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Fees [NEWHUD.X250]
        /// </summary>
        public decimal? Line801BrokerCompensationFees { get => _line801BrokerCompensationFees; set => SetField(ref _line801BrokerCompensationFees, value); }

        /// <summary>
        /// Fees Line 801 HUD GFE Broker Compensation Rate [NEWHUD.X246]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? Line801BrokerCompensationRate { get => _line801BrokerCompensationRate; set => SetField(ref _line801BrokerCompensationRate, value); }

        /// <summary>
        /// Fees Line 808 Fee Applied to GFE [NEWHUD.X662]
        /// </summary>
        public decimal? Line808Fee { get => _line808Fee; set => SetField(ref _line808Fee, value); }

        /// <summary>
        /// Fees Line 809 Fee Applied to GFE [NEWHUD.X663]
        /// </summary>
        public decimal? Line809Fee { get => _line809Fee; set => SetField(ref _line809Fee, value); }

        /// <summary>
        /// Fees Line 810 Fee Applied to GFE [NEWHUD.X664]
        /// </summary>
        public decimal? Line810Fee { get => _line810Fee; set => SetField(ref _line810Fee, value); }

        /// <summary>
        /// Fees Line 811 Fee Applied to GFE [NEWHUD.X665]
        /// </summary>
        public decimal? Line811Fee { get => _line811Fee; set => SetField(ref _line811Fee, value); }

        /// <summary>
        /// Fees Line 812 Fee Applied to GFE [NEWHUD.X666]
        /// </summary>
        public decimal? Line812Fee { get => _line812Fee; set => SetField(ref _line812Fee, value); }

        /// <summary>
        /// Fees Line 813 Fee Applied to GFE [NEWHUD.X667]
        /// </summary>
        public decimal? Line813Fee { get => _line813Fee; set => SetField(ref _line813Fee, value); }

        /// <summary>
        /// Fees Line 814 Fee Applied to GFE [NEWHUD.X668]
        /// </summary>
        public decimal? Line814Fee { get => _line814Fee; set => SetField(ref _line814Fee, value); }

        /// <summary>
        /// Fees Line 815 Fee Applied to GFE [NEWHUD.X669]
        /// </summary>
        public decimal? Line815Fee { get => _line815Fee; set => SetField(ref _line815Fee, value); }

        /// <summary>
        /// Fees Line 816 Fee Applied to GFE [NEWHUD.X670]
        /// </summary>
        public decimal? Line816Fee { get => _line816Fee; set => SetField(ref _line816Fee, value); }

        /// <summary>
        /// Fees Line 817 Fee Applied to GFE [NEWHUD.X671]
        /// </summary>
        public decimal? Line817Fee { get => _line817Fee; set => SetField(ref _line817Fee, value); }

        /// <summary>
        /// Fees Line 818 Fee Applied to GFE [NEWHUD.X1525]
        /// </summary>
        public decimal? Line818Fee { get => _line818Fee; set => SetField(ref _line818Fee, value); }

        /// <summary>
        /// Fees Line 819 Fee Applied to GFE [NEWHUD.X1526]
        /// </summary>
        public decimal? Line819Fee { get => _line819Fee; set => SetField(ref _line819Fee, value); }

        /// <summary>
        /// Fees Line 820 Fee Applied to GFE [NEWHUD.X1527]
        /// </summary>
        public decimal? Line820Fee { get => _line820Fee; set => SetField(ref _line820Fee, value); }

        /// <summary>
        /// Fees Line 821 Fee Applied to GFE [NEWHUD.X1528]
        /// </summary>
        public decimal? Line821Fee { get => _line821Fee; set => SetField(ref _line821Fee, value); }

        /// <summary>
        /// Fees Line 822 Fee Applied to GFE [NEWHUD.X1529]
        /// </summary>
        public decimal? Line822Fee { get => _line822Fee; set => SetField(ref _line822Fee, value); }

        /// <summary>
        /// Fees Line 823 Fee Applied to GFE [NEWHUD.X1530]
        /// </summary>
        public decimal? Line823Fee { get => _line823Fee; set => SetField(ref _line823Fee, value); }

        /// <summary>
        /// Fees Line 824 Fee Applied to GFE [NEWHUD.X1531]
        /// </summary>
        public decimal? Line824Fee { get => _line824Fee; set => SetField(ref _line824Fee, value); }

        /// <summary>
        /// Fees Line 825 Fee Applied to GFE [NEWHUD.X1532]
        /// </summary>
        public decimal? Line825Fee { get => _line825Fee; set => SetField(ref _line825Fee, value); }

        /// <summary>
        /// Fees Line 826 Fee Applied to GFE [NEWHUD.X1533]
        /// </summary>
        public decimal? Line826Fee { get => _line826Fee; set => SetField(ref _line826Fee, value); }

        /// <summary>
        /// Fees Line 827 Fee Applied to GFE [NEWHUD.X1534]
        /// </summary>
        public decimal? Line827Fee { get => _line827Fee; set => SetField(ref _line827Fee, value); }

        /// <summary>
        /// Fees Line 828 Fee Applied to GFE [NEWHUD.X1535]
        /// </summary>
        public decimal? Line828Fee { get => _line828Fee; set => SetField(ref _line828Fee, value); }

        /// <summary>
        /// Fees Line 829 Fee Applied to GFE [NEWHUD.X1536]
        /// </summary>
        public decimal? Line829Fee { get => _line829Fee; set => SetField(ref _line829Fee, value); }

        /// <summary>
        /// Fees Line 830 Fee Applied to GFE [NEWHUD.X1537]
        /// </summary>
        public decimal? Line830Fee { get => _line830Fee; set => SetField(ref _line830Fee, value); }

        /// <summary>
        /// Fees Line 831 Fee Applied to GFE [NEWHUD.X1538]
        /// </summary>
        public decimal? Line831Fee { get => _line831Fee; set => SetField(ref _line831Fee, value); }

        /// <summary>
        /// Fees Line 832 Fee Applied to GFE [NEWHUD.X1539]
        /// </summary>
        public decimal? Line832Fee { get => _line832Fee; set => SetField(ref _line832Fee, value); }

        /// <summary>
        /// Fees Line 833 Fee Applied to GFE [NEWHUD.X1540]
        /// </summary>
        public decimal? Line833Fee { get => _line833Fee; set => SetField(ref _line833Fee, value); }

        /// <summary>
        /// Can Your Loan Balance Rise [NEWHUD.X6]
        /// </summary>
        public bool? LoanBalanceRiseIndicator { get => _loanBalanceRiseIndicator; set => SetField(ref _loanBalanceRiseIndicator, value); }

        /// <summary>
        /// Loan Origination Fees Applied to GFE [NEWHUD.X770]
        /// </summary>
        public decimal? LoanOriginationFees { get => _loanOriginationFees; set => SetField(ref _loanOriginationFees, value); }

        /// <summary>
        /// Loan Origination Fees Percent [NEWHUD.X769]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LoanOriginationPercentage { get => _loanOriginationPercentage; set => SetField(ref _loanOriginationPercentage, value); }

        /// <summary>
        /// 2010 GFE Loan Originator Name [NEWHUD.X806]
        /// </summary>
        public string? LoanOriginatorName { get => _loanOriginatorName; set => SetField(ref _loanOriginatorName, value); }

        /// <summary>
        /// Lower Int Rate-Initial Interest Rate [NEWHUD.X101]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LowerInterestInitialInterestRate { get => _lowerInterestInitialInterestRate; set => SetField(ref _lowerInterestInitialInterestRate, value); }

        /// <summary>
        /// Lower Int Rate-Initial Monthly Amt Owed [NEWHUD.X102]
        /// </summary>
        public decimal? LowerInterestInitialMonthlyAmountOwed { get => _lowerInterestInitialMonthlyAmountOwed; set => SetField(ref _lowerInterestInitialMonthlyAmountOwed, value); }

        /// <summary>
        /// Lower Int Rate-Mnthly Pymt Reduction [NEWHUD.X103]
        /// </summary>
        public decimal? LowerInterestMonthlyPaymentReduced { get => _lowerInterestMonthlyPaymentReduced; set => SetField(ref _lowerInterestMonthlyPaymentReduced, value); }

        /// <summary>
        /// Lower Int Rate-Sttlmnt Chrgs Increase [NEWHUD.X104]
        /// </summary>
        public decimal? LowerInterestServiceChargeIncreasedAmount { get => _lowerInterestServiceChargeIncreasedAmount; set => SetField(ref _lowerInterestServiceChargeIncreasedAmount, value); }

        /// <summary>
        /// Lower Int Rate-Total Est Sttlmnt Chrgs [NEWHUD.X105]
        /// </summary>
        public decimal? LowerInterestTotalSettlementCharges { get => _lowerInterestTotalSettlementCharges; set => SetField(ref _lowerInterestTotalSettlementCharges, value); }

        /// <summary>
        /// Lower Sttlmnt Chrgs-Intl Int Rate [NEWHUD.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? LowerSettlementInitialInterestRate { get => _lowerSettlementInitialInterestRate; set => SetField(ref _lowerSettlementInitialInterestRate, value); }

        /// <summary>
        /// Lower Sttlmnt Chrgs-Intl  Mnthly Amt Owed [NEWHUD.X96]
        /// </summary>
        public decimal? LowerSettlementInitialMonthlyAmountOwed { get => _lowerSettlementInitialMonthlyAmountOwed; set => SetField(ref _lowerSettlementInitialMonthlyAmountOwed, value); }

        /// <summary>
        /// Lower Sttlmnt Chrgs-Mthly Pymt Increase [NEWHUD.X97]
        /// </summary>
        public decimal? LowerSettlementMonthlyPaymentIncreased { get => _lowerSettlementMonthlyPaymentIncreased; set => SetField(ref _lowerSettlementMonthlyPaymentIncreased, value); }

        /// <summary>
        /// Lower Sttlmnt Chrgs-Sttlmnt Chrgs Reduction [NEWHUD.X98]
        /// </summary>
        public decimal? LowerSettlementServiceChargeReducedAmount { get => _lowerSettlementServiceChargeReducedAmount; set => SetField(ref _lowerSettlementServiceChargeReducedAmount, value); }

        /// <summary>
        /// Lower Sttlmnt Chrgs-Total Est Sttlmnt Chrgs [NEWHUD.X99]
        /// </summary>
        public decimal? LowerSettlementTotalSettlementCharges { get => _lowerSettlementTotalSettlementCharges; set => SetField(ref _lowerSettlementTotalSettlementCharges, value); }

        /// <summary>
        /// HUD-Maximum Loan Balance [NEWHUD.X7]
        /// </summary>
        public decimal? MaximumLoanBalance { get => _maximumLoanBalance; set => SetField(ref _maximumLoanBalance, value); }

        /// <summary>
        /// Max Mthly Pymt After 1st Increase [NEWHUD.X10]
        /// </summary>
        public decimal? MaximumOwedMonthlyPayment { get => _maximumOwedMonthlyPayment; set => SetField(ref _maximumOwedMonthlyPayment, value); }

        /// <summary>
        /// ARM Max Life Interest Cap [NEWHUD.X555]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? MaxLifeInterestCapPercent { get => _maxLifeInterestCapPercent; set => SetField(ref _maxLifeInterestCapPercent, value); }

        /// <summary>
        /// ARM Max Life Interest Cap - Display fields with KBYO rounding rules [KBYO.NEWHUDXD555]
        /// </summary>
        public string? MaxLifeInterestCapPercentUI { get => _maxLifeInterestCapPercentUI; set => SetField(ref _maxLifeInterestCapPercentUI, value); }

        /// <summary>
        /// Mnths Until 1st Mnthly Pymt Increase [NEWHUD.X9]
        /// </summary>
        public int? MonthlyPaymentFirstIncreaseDate { get => _monthlyPaymentFirstIncreaseDate; set => SetField(ref _monthlyPaymentFirstIncreaseDate, value); }

        /// <summary>
        /// Can Monthly Payments Rise [NEWHUD.X8]
        /// </summary>
        public bool? MonthlyPaymentRiseIndicator { get => _monthlyPaymentRiseIndicator; set => SetField(ref _monthlyPaymentRiseIndicator, value); }

        /// <summary>
        /// Fees Mtg Ins Premium Applied to GFE [NEWHUD.X622]
        /// </summary>
        public decimal? MortgageInsurancePremium { get => _mortgageInsurancePremium; set => SetField(ref _mortgageInsurancePremium, value); }

        /// <summary>
        /// Days Before Sttlmtn to Lock Int Rate [NEWHUD.X3]
        /// </summary>
        public string? MustLockRateDays { get => _mustLockRateDays; set => SetField(ref _mustLockRateDays, value); }

        /// <summary>
        /// Gfe2010 NewHudSection1100Line1104BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1104BorPaidAmount { get => _newHudSection1100Line1104BorPaidAmount; set => SetField(ref _newHudSection1100Line1104BorPaidAmount, value); }

        /// <summary>
        /// Gfe2010 NewHudSection1100Line1104SelPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1104SelPaidAmount { get => _newHudSection1100Line1104SelPaidAmount; set => SetField(ref _newHudSection1100Line1104SelPaidAmount, value); }

        /// <summary>
        /// Gfe2010 NewHudSection1100Line1107BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1107BorPaidAmount { get => _newHudSection1100Line1107BorPaidAmount; set => SetField(ref _newHudSection1100Line1107BorPaidAmount, value); }

        /// <summary>
        /// Gfe2010 NewHudSection1100Line1108BorPaidAmount
        /// </summary>
        public decimal? NewHudSection1100Line1108BorPaidAmount { get => _newHudSection1100Line1108BorPaidAmount; set => SetField(ref _newHudSection1100Line1108BorPaidAmount, value); }

        /// <summary>
        /// Total Est Origination Charges [NEWHUD.X12]
        /// </summary>
        public decimal? OriginationCharges { get => _originationCharges; set => SetField(ref _originationCharges, value); }

        /// <summary>
        /// Origination Credit (YSP) [NEWHUD.X712]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationCreditYsp { get => _originationCreditYsp; set => SetField(ref _originationCreditYsp, value); }

        /// <summary>
        /// Fees Loan Origination Fee + $ [NEWHUD.X741]
        /// </summary>
        public decimal? OriginationCreditYspAdditional { get => _originationCreditYspAdditional; set => SetField(ref _originationCreditYspAdditional, value); }

        /// <summary>
        /// Orig Charge Paid by Borrower [NEWHUD.X711]
        /// </summary>
        public decimal? OriginationPoints { get => _originationPoints; set => SetField(ref _originationPoints, value); }

        /// <summary>
        /// Origination Points Additional [NEWHUD.X710]
        /// </summary>
        public decimal? OriginationPointsAdditional { get => _originationPointsAdditional; set => SetField(ref _originationPointsAdditional, value); }

        /// <summary>
        /// Origination Points [NEWHUD.X709]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? OriginationPointsPercentage { get => _originationPointsPercentage; set => SetField(ref _originationPointsPercentage, value); }

        /// <summary>
        /// Owner's Title Ins Applied to GFE [NEWHUD.X39]
        /// </summary>
        public NA<decimal> OwnerTitleInsuranceAmount { get => _ownerTitleInsuranceAmount; set => SetField(ref _ownerTitleInsuranceAmount, value); }

        /// <summary>
        /// Print N/A to Days Before Sttlmtn to Lock Int Rate [NEWHUD.X1717]
        /// </summary>
        public bool? PrintNAInLockRateDays { get => _printNAInLockRateDays; set => SetField(ref _printNAInLockRateDays, value); }

        /// <summary>
        /// 2010 GFE Print Shopping Chart 1st Column [NEWHUD.X807]
        /// </summary>
        public bool? PrintShoppingChartIndicator { get => _printShoppingChartIndicator; set => SetField(ref _printShoppingChartIndicator, value); }

        /// <summary>
        /// Fees Processing Fees Applied to GFE [NEWHUD.X703]
        /// </summary>
        public decimal? ProcessingFees { get => _processingFees; set => SetField(ref _processingFees, value); }

        /// <summary>
        /// Fees Apprsl Fee Applied to GFE [NEWHUD.X609]
        /// </summary>
        public decimal? RequiredAppraisalFee { get => _requiredAppraisalFee; set => SetField(ref _requiredAppraisalFee, value); }

        /// <summary>
        /// Fees Credit Report Fee Applied to GFE [NEWHUD.X610]
        /// </summary>
        public decimal? RequiredCreditReportFee { get => _requiredCreditReportFee; set => SetField(ref _requiredCreditReportFee, value); }

        /// <summary>
        /// Fees Flood Cert Fee Applied to GFE [NEWHUD.X612]
        /// </summary>
        public decimal? RequiredFloodCertificationFee { get => _requiredFloodCertificationFee; set => SetField(ref _requiredFloodCertificationFee, value); }

        /// <summary>
        /// Required Services We Select [NEWHUD.X17]
        /// </summary>
        public decimal? RequiredServicesAmount { get => _requiredServicesAmount; set => SetField(ref _requiredServicesAmount, value); }

        /// <summary>
        /// Fees Tax Service Fee Applied to GFE [NEWHUD.X611]
        /// </summary>
        public decimal? RequiredTaxServiceFee { get => _requiredTaxServiceFee; set => SetField(ref _requiredTaxServiceFee, value); }

        /// <summary>
        /// Line 1000 Total Borrower Paid Amount [NEWHUD2.X36]
        /// </summary>
        public decimal? Section1000TotalBorrowerPaidAmount { get => _section1000TotalBorrowerPaidAmount; set => SetField(ref _section1000TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 1000 Total Other Paid Amount [NEWHUD2.X38]
        /// </summary>
        public decimal? Section1000TotalOtherPaidAmount { get => _section1000TotalOtherPaidAmount; set => SetField(ref _section1000TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 1000 Total Paid Amount [NEWHUD2.X39]
        /// </summary>
        public decimal? Section1000TotalPaidAmount { get => _section1000TotalPaidAmount; set => SetField(ref _section1000TotalPaidAmount, value); }

        /// <summary>
        /// Line 1000 Total Seller Paid Amount [NEWHUD2.X37]
        /// </summary>
        public decimal? Section1000TotalSellerPaidAmount { get => _section1000TotalSellerPaidAmount; set => SetField(ref _section1000TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 1100 Total Borrower Paid Amount [NEWHUD2.X40]
        /// </summary>
        public decimal? Section1100TotalBorrowerPaidAmount { get => _section1100TotalBorrowerPaidAmount; set => SetField(ref _section1100TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 1100 Total Other Paid Amount [NEWHUD2.X42]
        /// </summary>
        public decimal? Section1100TotalOtherPaidAmount { get => _section1100TotalOtherPaidAmount; set => SetField(ref _section1100TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 1100 Total Paid Amount [NEWHUD2.X43]
        /// </summary>
        public decimal? Section1100TotalPaidAmount { get => _section1100TotalPaidAmount; set => SetField(ref _section1100TotalPaidAmount, value); }

        /// <summary>
        /// Line 1100 Total Seller Paid Amount [NEWHUD2.X41]
        /// </summary>
        public decimal? Section1100TotalSellerPaidAmount { get => _section1100TotalSellerPaidAmount; set => SetField(ref _section1100TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 1200 Total Borrower Paid Amount [NEWHUD2.X44]
        /// </summary>
        public decimal? Section1200TotalBorrowerPaidAmount { get => _section1200TotalBorrowerPaidAmount; set => SetField(ref _section1200TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 1200 Total Other Paid Amount [NEWHUD2.X46]
        /// </summary>
        public decimal? Section1200TotalOtherPaidAmount { get => _section1200TotalOtherPaidAmount; set => SetField(ref _section1200TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 1200 Total Paid Amount [NEWHUD2.X47]
        /// </summary>
        public decimal? Section1200TotalPaidAmount { get => _section1200TotalPaidAmount; set => SetField(ref _section1200TotalPaidAmount, value); }

        /// <summary>
        /// Line 1200 Total Seller Paid Amount [NEWHUD2.X45]
        /// </summary>
        public decimal? Section1200TotalSellerPaidAmount { get => _section1200TotalSellerPaidAmount; set => SetField(ref _section1200TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 1300 Total Borrower Paid Amount [NEWHUD2.X48]
        /// </summary>
        public decimal? Section1300TotalBorrowerPaidAmount { get => _section1300TotalBorrowerPaidAmount; set => SetField(ref _section1300TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 1300 Total Other Paid Amount [NEWHUD2.X50]
        /// </summary>
        public decimal? Section1300TotalOtherPaidAmount { get => _section1300TotalOtherPaidAmount; set => SetField(ref _section1300TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 1300 Total Paid Amount [NEWHUD2.X51]
        /// </summary>
        public decimal? Section1300TotalPaidAmount { get => _section1300TotalPaidAmount; set => SetField(ref _section1300TotalPaidAmount, value); }

        /// <summary>
        /// Line 1300 Total Seller Paid Amount [NEWHUD2.X49]
        /// </summary>
        public decimal? Section1300TotalSellerPaidAmount { get => _section1300TotalSellerPaidAmount; set => SetField(ref _section1300TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 1400 Total Borrower Paid Amount [NEWHUD2.X4427]
        /// </summary>
        public decimal? Section1400TotalBorrowerPaidAmount { get => _section1400TotalBorrowerPaidAmount; set => SetField(ref _section1400TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 1400 Total Other Paid Amount [NEWHUD2.X52]
        /// </summary>
        public decimal? Section1400TotalOtherPaidAmount { get => _section1400TotalOtherPaidAmount; set => SetField(ref _section1400TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 1400 Total Paid Amount [NEWHUD2.X53]
        /// </summary>
        public decimal? Section1400TotalPaidAmount { get => _section1400TotalPaidAmount; set => SetField(ref _section1400TotalPaidAmount, value); }

        /// <summary>
        /// Line 1400 Total Seller Amount [NEWHUD2.X4428]
        /// </summary>
        public decimal? Section1400TotalSellerPaidAmount { get => _section1400TotalSellerPaidAmount; set => SetField(ref _section1400TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 700 Total Borrower Paid Amount [NEWHUD2.X24]
        /// </summary>
        public decimal? Section700TotalBorrowerPaidAmount { get => _section700TotalBorrowerPaidAmount; set => SetField(ref _section700TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 700 Total Other Paid Amount [NEWHUD2.X26]
        /// </summary>
        public decimal? Section700TotalOtherPaidAmount { get => _section700TotalOtherPaidAmount; set => SetField(ref _section700TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 700 Total Paid Amount [NEWHUD2.X27]
        /// </summary>
        public decimal? Section700TotalPaidAmount { get => _section700TotalPaidAmount; set => SetField(ref _section700TotalPaidAmount, value); }

        /// <summary>
        /// Line 700 Total Seller Paid Amount [NEWHUD2.X25]
        /// </summary>
        public decimal? Section700TotalSellerPaidAmount { get => _section700TotalSellerPaidAmount; set => SetField(ref _section700TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 800 Total Borrower Paid Amount [NEWHUD2.X28]
        /// </summary>
        public decimal? Section800TotalBorrowerPaidAmount { get => _section800TotalBorrowerPaidAmount; set => SetField(ref _section800TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 800 Total Other Paid Amount [NEWHUD2.X30]
        /// </summary>
        public decimal? Section800TotalOtherPaidAmount { get => _section800TotalOtherPaidAmount; set => SetField(ref _section800TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 800 Total Paid Amount [NEWHUD2.X31]
        /// </summary>
        public decimal? Section800TotalPaidAmount { get => _section800TotalPaidAmount; set => SetField(ref _section800TotalPaidAmount, value); }

        /// <summary>
        /// Line 800 Total Seller Paid Amount [NEWHUD2.X29]
        /// </summary>
        public decimal? Section800TotalSellerPaidAmount { get => _section800TotalSellerPaidAmount; set => SetField(ref _section800TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line 900 Total Borrower Paid Amount [NEWHUD2.X32]
        /// </summary>
        public decimal? Section900TotalBorrowerPaidAmount { get => _section900TotalBorrowerPaidAmount; set => SetField(ref _section900TotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line 900 Total Other Paid Amount [NEWHUD2.X34]
        /// </summary>
        public decimal? Section900TotalOtherPaidAmount { get => _section900TotalOtherPaidAmount; set => SetField(ref _section900TotalOtherPaidAmount, value); }

        /// <summary>
        /// Line 900 Total Paid Amount [NEWHUD2.X35]
        /// </summary>
        public decimal? Section900TotalPaidAmount { get => _section900TotalPaidAmount; set => SetField(ref _section900TotalPaidAmount, value); }

        /// <summary>
        /// Line 900 Total Seller Paid Amount [NEWHUD2.X33]
        /// </summary>
        public decimal? Section900TotalSellerPaidAmount { get => _section900TotalSellerPaidAmount; set => SetField(ref _section900TotalSellerPaidAmount, value); }

        /// <summary>
        /// Line PC Total Borrower Paid Amount [NEWHUD2.X4760]
        /// </summary>
        public decimal? SectionPCTotalBorrowerPaidAmount { get => _sectionPCTotalBorrowerPaidAmount; set => SetField(ref _sectionPCTotalBorrowerPaidAmount, value); }

        /// <summary>
        /// Line PC Total Other Paid Amount [NEWHUD2.X4762]
        /// </summary>
        public decimal? SectionPCTotalOtherPaidAmount { get => _sectionPCTotalOtherPaidAmount; set => SetField(ref _sectionPCTotalOtherPaidAmount, value); }

        /// <summary>
        /// Line PC Total Paid Amount [NEWHUD2.X4763]
        /// </summary>
        public decimal? SectionPCTotalPaidAmount { get => _sectionPCTotalPaidAmount; set => SetField(ref _sectionPCTotalPaidAmount, value); }

        /// <summary>
        /// Line PC Total Seller Amount [NEWHUD2.X4761]
        /// </summary>
        public decimal? SectionPCTotalSellerPaidAmount { get => _sectionPCTotalSellerPaidAmount; set => SetField(ref _sectionPCTotalSellerPaidAmount, value); }

        /// <summary>
        /// Fees Line 1301l Applied to GFE [NEWHUD.X40]
        /// </summary>
        public decimal? ShopRequiredServicesAmount { get => _shopRequiredServicesAmount; set => SetField(ref _shopRequiredServicesAmount, value); }

        /// <summary>
        /// ARM Rate Cap [NEWHUD.X558]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? SubsequentCapPercent { get => _subsequentCapPercent; set => SetField(ref _subsequentCapPercent, value); }

        /// <summary>
        /// Section PC Subsequently Paid Finance Charge [NEWHUD2.X4768]
        /// </summary>
        public decimal? SubsequentlyPaidFinanceCharge { get => _subsequentlyPaidFinanceCharge; set => SetField(ref _subsequentlyPaidFinanceCharge, value); }

        /// <summary>
        /// ARM First Period Change [NEWHUD.X556]
        /// </summary>
        public int? SubsequentRateAdjustmentMonths { get => _subsequentRateAdjustmentMonths; set => SetField(ref _subsequentRateAdjustmentMonths, value); }

        /// <summary>
        /// Table Funded Transactions Indicator [NEWHUD.X1068]
        /// </summary>
        public bool? TableFundedIndicator { get => _tableFundedIndicator; set => SetField(ref _tableFundedIndicator, value); }

        /// <summary>
        /// Avail Time for GFE Interest Rate [NEWHUD.X725]
        /// </summary>
        public string? TimeForRate { get => _timeForRate; set => SetField(ref _timeForRate, value); }

        /// <summary>
        /// Title Serv &amp; Lender's Title Ins Applied to GFE [NEWHUD.X38]
        /// </summary>
        public decimal? TitleServiceAmount { get => _titleServiceAmount; set => SetField(ref _titleServiceAmount, value); }

        /// <summary>
        /// Chrgs That Cannot Incr 10% in Total [NEWHUD.X61]
        /// </summary>
        public decimal? TotalBelow10 { get => _totalBelow10; set => SetField(ref _totalBelow10, value); }

        /// <summary>
        /// Borr Total of Financed Fees [NEWHUD.X1585]
        /// </summary>
        public decimal? TotalOfFinancedFees { get => _totalOfFinancedFees; set => SetField(ref _totalOfFinancedFees, value); }

        /// <summary>
        /// HUD-Est Total Settlement Charges [NEWHUD.X93]
        /// </summary>
        public decimal? TotalSettlementCharges { get => _totalSettlementCharges; set => SetField(ref _totalSettlementCharges, value); }

        /// <summary>
        /// Transfer Tax Total GFE [NEWHUD.X76]
        /// </summary>
        public decimal? TotalTransferTaxes { get => _totalTransferTaxes; set => SetField(ref _totalTransferTaxes, value); }

        /// <summary>
        /// Fees Line 1203 Borr [NEWHUD.X730]
        /// </summary>
        public decimal? TransferTaxes { get => _transferTaxes; set => SetField(ref _transferTaxes, value); }

        /// <summary>
        /// Fees Underwriting Fees Applied to GFE [NEWHUD.X704]
        /// </summary>
        public decimal? UnderwritingFees { get => _underwritingFees; set => SetField(ref _underwritingFees, value); }

        /// <summary>
        /// Fees Line 801 Broker Compensation Use LO Comp Tool [NEWHUD.X1718]
        /// </summary>
        public bool? UseLOCompTool { get => _useLOCompTool; set => SetField(ref _useLOCompTool, value); }
    }
}