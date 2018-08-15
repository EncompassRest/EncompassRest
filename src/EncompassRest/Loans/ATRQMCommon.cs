using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ATRQMCommon
    /// </summary>
    public sealed partial class ATRQMCommon : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _affiliatesFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Fees Paid to Affiliates [QM.X134]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Fees Paid to Affiliates")]
        public decimal? AffiliatesFees { get => _affiliatesFees; set => SetField(ref _affiliatesFees, value); }
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - APOR Max Bona Fide Discount Point % [QM.X364]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - APOR Max Bona Fide Discount Point %")]
        public decimal? APORMaxBonaFideDiscountPoint { get => _aPORMaxBonaFideDiscountPoint; set => SetField(ref _aPORMaxBonaFideDiscountPoint, value); }
        private DirtyValue<DateTime?> _aRMRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date [QM.X8]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date")]
        public DateTime? ARMRecastDate { get => _aRMRecastDate; set => SetField(ref _aRMRecastDate, value); }
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment [QM.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment")]
        public decimal? ARMRecastMonthlyPayment { get => _aRMRecastMonthlyPayment; set => SetField(ref _aRMRecastMonthlyPayment, value); }
        private DirtyValue<string> _assetRepresentationAndWarrantyReliefEligibilityType;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type [AUSF.X62]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type")]
        public string AssetRepresentationAndWarrantyReliefEligibilityType { get => _assetRepresentationAndWarrantyReliefEligibilityType; set => SetField(ref _assetRepresentationAndWarrantyReliefEligibilityType, value); }
        private DirtyValue<StringEnumValue<ATRLoanType>> _aTRLoanType;
        /// <summary>
        /// ATR QM - Eligibility - Ability-to-Repay Loan Type [QM.X23]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Ability-to-Repay Loan Type")]
        public StringEnumValue<ATRLoanType> ATRLoanType { get => _aTRLoanType; set => SetField(ref _aTRLoanType, value); }
        private DirtyValue<string> _aUSDataDiscrepencyResolutionComments;
        /// <summary>
        /// AUS Data Discrepency Resolution Comments [AUSF.X20]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution Comments")]
        public string AUSDataDiscrepencyResolutionComments { get => _aUSDataDiscrepencyResolutionComments; set => SetField(ref _aUSDataDiscrepencyResolutionComments, value); }
        private DirtyValue<DateTime?> _aUSDataDiscrepencyResolutionDate;
        /// <summary>
        /// AUS Data Discrepency Resolution Date [AUSF.X19]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution Date")]
        public DateTime? AUSDataDiscrepencyResolutionDate { get => _aUSDataDiscrepencyResolutionDate; set => SetField(ref _aUSDataDiscrepencyResolutionDate, value); }
        private DirtyValue<string> _aUSDataDiscrepencyResolvedBy;
        /// <summary>
        /// AUS Data Discrepency Resolution User [AUSF.X21]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution User")]
        public string AUSDataDiscrepencyResolvedBy { get => _aUSDataDiscrepencyResolvedBy; set => SetField(ref _aUSDataDiscrepencyResolvedBy, value); }
        private DirtyValue<decimal?> _bonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point % [QM.X369]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Bona Fide Discount Point %")]
        public decimal? BonaFideDiscountPoint { get => _bonaFideDiscountPoint; set => SetField(ref _bonaFideDiscountPoint, value); }
        private DirtyValue<decimal?> _bonaFideDiscountPointAmount;
        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point Amount [QM.X370]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "ATR QM - Qualification - Bona Fide Discount Point Amount")]
        public decimal? BonaFideDiscountPointAmount { get => _bonaFideDiscountPointAmount; set => SetField(ref _bonaFideDiscountPointAmount, value); }
        private DirtyValue<bool?> _brokerCompensationWhenRateSet;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set [QM.X372]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set")]
        public bool? BrokerCompensationWhenRateSet { get => _brokerCompensationWhenRateSet; set => SetField(ref _brokerCompensationWhenRateSet, value); }
        private DirtyValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>> _collateralRepandWarrReliefEligibilityType;
        /// <summary>
        /// Collateral Rep and Warranty Relief Eligibility Type [AUSF.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Collateral Rep and Warranty Relief Eligibility Type")]
        public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => SetField(ref _collateralRepandWarrReliefEligibilityType, value); }
        private DirtyValue<decimal?> _compensationPTBFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers [QM.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers")]
        public decimal? CompensationPTBFees { get => _compensationPTBFees; set => SetField(ref _compensationPTBFees, value); }
        private DirtyValue<decimal?> _creditInsPremiumFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium [QM.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium")]
        public decimal? CreditInsPremiumFees { get => _creditInsPremiumFees; set => SetField(ref _creditInsPremiumFees, value); }
        private DirtyValue<bool?> _creditorType;
        /// <summary>
        /// ATR QM - Eligibility - Creditor Type [QM.X104]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Creditor Type")]
        public bool? CreditorType { get => _creditorType; set => SetField(ref _creditorType, value); }
        private DirtyValue<StringEnumValue<CreditorTypeDescription>> _creditorTypeDescription;
        /// <summary>
        /// ATR QM - Eligibility - Creditor Type Description [QM.X105]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Creditor Type Description")]
        public StringEnumValue<CreditorTypeDescription> CreditorTypeDescription { get => _creditorTypeDescription; set => SetField(ref _creditorTypeDescription, value); }
        private DirtyValue<bool?> _creditType;
        /// <summary>
        /// ATR QM - Eligibility - Credit Type [QM.X110]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Credit Type")]
        public bool? CreditType { get => _creditType; set => SetField(ref _creditType, value); }
        private DirtyValue<decimal?> _currentQMFeeThresholdAmt;
        /// <summary>
        /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount [QM.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount")]
        public decimal? CurrentQMFeeThresholdAmt { get => _currentQMFeeThresholdAmt; set => SetField(ref _currentQMFeeThresholdAmt, value); }
        private DirtyValue<decimal?> _currentQMFeeThresholdPercent;
        /// <summary>
        /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage [QM.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage")]
        public decimal? CurrentQMFeeThresholdPercent { get => _currentQMFeeThresholdPercent; set => SetField(ref _currentQMFeeThresholdPercent, value); }
        private DirtyValue<DateTime?> _dateOfLastMonthlyPayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment [QM.X4]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment")]
        public DateTime? DateOfLastMonthlyPayment { get => _dateOfLastMonthlyPayment; set => SetField(ref _dateOfLastMonthlyPayment, value); }
        private DirtyValue<decimal?> _discountPointAmount;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount [QM.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount")]
        public decimal? DiscountPointAmount { get => _discountPointAmount; set => SetField(ref _discountPointAmount, value); }
        private DirtyValue<decimal?> _discountPointFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees [QM.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees")]
        public decimal? DiscountPointFees { get => _discountPointFees; set => SetField(ref _discountPointFees, value); }
        private DirtyValue<decimal?> _discountPointPercentage;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points % [QM.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fees from 2010 Itemization - Discount Points %")]
        public decimal? DiscountPointPercentage { get => _discountPointPercentage; set => SetField(ref _discountPointPercentage, value); }
        private DirtyValue<string> _documentationGuidelineMessages4V;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V) [AUSF.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V)")]
        public string DocumentationGuidelineMessages4V { get => _documentationGuidelineMessages4V; set => SetField(ref _documentationGuidelineMessages4V, value); }
        private DirtyValue<string> _documentationGuidelineMessages5C;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C) [AUSF.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C)")]
        public string DocumentationGuidelineMessages5C { get => _documentationGuidelineMessages5C; set => SetField(ref _documentationGuidelineMessages5C, value); }
        private DirtyValue<string> _documentationGuidelineMessages8Y;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y) [AUSF.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y)")]
        public string DocumentationGuidelineMessages8Y { get => _documentationGuidelineMessages8Y; set => SetField(ref _documentationGuidelineMessages8Y, value); }
        private DirtyValue<string> _documentationGuidelineMessagesCN;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN) [AUSF.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN)")]
        public string DocumentationGuidelineMessagesCN { get => _documentationGuidelineMessagesCN; set => SetField(ref _documentationGuidelineMessagesCN, value); }
        private DirtyValue<string> _documentationGuidelineMessagesCP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP) [AUSF.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP)")]
        public string DocumentationGuidelineMessagesCP { get => _documentationGuidelineMessagesCP; set => SetField(ref _documentationGuidelineMessagesCP, value); }
        private DirtyValue<string> _documentationGuidelineMessagesCV;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV) [AUSF.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV)")]
        public string DocumentationGuidelineMessagesCV { get => _documentationGuidelineMessagesCV; set => SetField(ref _documentationGuidelineMessagesCV, value); }
        private DirtyValue<string> _documentationGuidelineMessagesCY;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY) [AUSF.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY)")]
        public string DocumentationGuidelineMessagesCY { get => _documentationGuidelineMessagesCY; set => SetField(ref _documentationGuidelineMessagesCY, value); }
        private DirtyValue<string> _documentationGuidelineMessagesCZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ) [AUSF.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ)")]
        public string DocumentationGuidelineMessagesCZ { get => _documentationGuidelineMessagesCZ; set => SetField(ref _documentationGuidelineMessagesCZ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesDP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP) [AUSF.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP)")]
        public string DocumentationGuidelineMessagesDP { get => _documentationGuidelineMessagesDP; set => SetField(ref _documentationGuidelineMessagesDP, value); }
        private DirtyValue<string> _documentationGuidelineMessagesDZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ) [AUSF.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ)")]
        public string DocumentationGuidelineMessagesDZ { get => _documentationGuidelineMessagesDZ; set => SetField(ref _documentationGuidelineMessagesDZ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesE5;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5) [AUSF.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5)")]
        public string DocumentationGuidelineMessagesE5 { get => _documentationGuidelineMessagesE5; set => SetField(ref _documentationGuidelineMessagesE5, value); }
        private DirtyValue<string> _documentationGuidelineMessagesIM;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM) [AUSF.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM)")]
        public string DocumentationGuidelineMessagesIM { get => _documentationGuidelineMessagesIM; set => SetField(ref _documentationGuidelineMessagesIM, value); }
        private DirtyValue<string> _documentationGuidelineMessagesIQ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ) [AUSF.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ)")]
        public string DocumentationGuidelineMessagesIQ { get => _documentationGuidelineMessagesIQ; set => SetField(ref _documentationGuidelineMessagesIQ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesJF;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF) [AUSF.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF)")]
        public string DocumentationGuidelineMessagesJF { get => _documentationGuidelineMessagesJF; set => SetField(ref _documentationGuidelineMessagesJF, value); }
        private DirtyValue<string> _documentationGuidelineMessagesQJ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ) [AUSF.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ)")]
        public string DocumentationGuidelineMessagesQJ { get => _documentationGuidelineMessagesQJ; set => SetField(ref _documentationGuidelineMessagesQJ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesQN;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN) [AUSF.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN)")]
        public string DocumentationGuidelineMessagesQN { get => _documentationGuidelineMessagesQN; set => SetField(ref _documentationGuidelineMessagesQN, value); }
        private DirtyValue<string> _documentationGuidelineMessagesQQ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ) [AUSF.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ)")]
        public string DocumentationGuidelineMessagesQQ { get => _documentationGuidelineMessagesQQ; set => SetField(ref _documentationGuidelineMessagesQQ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesQS;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS) [AUSF.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS)")]
        public string DocumentationGuidelineMessagesQS { get => _documentationGuidelineMessagesQS; set => SetField(ref _documentationGuidelineMessagesQS, value); }
        private DirtyValue<string> _documentationGuidelineMessagesU7;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7) [AUSF.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7)")]
        public string DocumentationGuidelineMessagesU7 { get => _documentationGuidelineMessagesU7; set => SetField(ref _documentationGuidelineMessagesU7, value); }
        private DirtyValue<string> _documentationGuidelineMessagesX1;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1) [AUSF.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1)")]
        public string DocumentationGuidelineMessagesX1 { get => _documentationGuidelineMessagesX1; set => SetField(ref _documentationGuidelineMessagesX1, value); }
        private DirtyValue<string> _documentationGuidelineMessagesX3;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3) [AUSF.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3)")]
        public string DocumentationGuidelineMessagesX3 { get => _documentationGuidelineMessagesX3; set => SetField(ref _documentationGuidelineMessagesX3, value); }
        private DirtyValue<string> _documentationGuidelineMessagesX5;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5) [AUSF.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5)")]
        public string DocumentationGuidelineMessagesX5 { get => _documentationGuidelineMessagesX5; set => SetField(ref _documentationGuidelineMessagesX5, value); }
        private DirtyValue<string> _documentationGuidelineMessagesX7;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7) [AUSF.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7)")]
        public string DocumentationGuidelineMessagesX7 { get => _documentationGuidelineMessagesX7; set => SetField(ref _documentationGuidelineMessagesX7, value); }
        private DirtyValue<string> _documentationGuidelineMessagesXA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA) [AUSF.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA)")]
        public string DocumentationGuidelineMessagesXA { get => _documentationGuidelineMessagesXA; set => SetField(ref _documentationGuidelineMessagesXA, value); }
        private DirtyValue<string> _documentationGuidelineMessagesXM;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM) [AUSF.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM)")]
        public string DocumentationGuidelineMessagesXM { get => _documentationGuidelineMessagesXM; set => SetField(ref _documentationGuidelineMessagesXM, value); }
        private DirtyValue<string> _documentationGuidelineMessagesXP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP) [AUSF.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP)")]
        public string DocumentationGuidelineMessagesXP { get => _documentationGuidelineMessagesXP; set => SetField(ref _documentationGuidelineMessagesXP, value); }
        private DirtyValue<string> _documentationGuidelineMessagesXR;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR) [AUSF.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR)")]
        public string DocumentationGuidelineMessagesXR { get => _documentationGuidelineMessagesXR; set => SetField(ref _documentationGuidelineMessagesXR, value); }
        private DirtyValue<string> _documentationGuidelineMessagesXT;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT) [AUSF.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT)")]
        public string DocumentationGuidelineMessagesXT { get => _documentationGuidelineMessagesXT; set => SetField(ref _documentationGuidelineMessagesXT, value); }
        private DirtyValue<string> _documentationGuidelineMessagesY8;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8) [AUSF.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8)")]
        public string DocumentationGuidelineMessagesY8 { get => _documentationGuidelineMessagesY8; set => SetField(ref _documentationGuidelineMessagesY8, value); }
        private DirtyValue<string> _documentationGuidelineMessagesYG;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG) [AUSF.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG)")]
        public string DocumentationGuidelineMessagesYG { get => _documentationGuidelineMessagesYG; set => SetField(ref _documentationGuidelineMessagesYG, value); }
        private DirtyValue<string> _documentationGuidelineMessagesYJ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ) [AUSF.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ)")]
        public string DocumentationGuidelineMessagesYJ { get => _documentationGuidelineMessagesYJ; set => SetField(ref _documentationGuidelineMessagesYJ, value); }
        private DirtyValue<string> _documentationGuidelineMessagesYY;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY) [AUSF.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY)")]
        public string DocumentationGuidelineMessagesYY { get => _documentationGuidelineMessagesYY; set => SetField(ref _documentationGuidelineMessagesYY, value); }
        private DirtyValue<string> _documentationGuidelineMessagesYZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ) [AUSF.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ)")]
        public string DocumentationGuidelineMessagesYZ { get => _documentationGuidelineMessagesYZ; set => SetField(ref _documentationGuidelineMessagesYZ, value); }
        private DirtyValue<StringEnumValue<EligibleNonStandardToStandard>> _eligibleNonStandardToStandard;
        /// <summary>
        /// ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM [QM.X1]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM")]
        public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => _eligibleNonStandardToStandard; set => SetField(ref _eligibleNonStandardToStandard, value); }
        private DirtyValue<decimal?> _financeChargeFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees [QM.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees")]
        public decimal? FinanceChargeFees { get => _financeChargeFees; set => SetField(ref _financeChargeFees, value); }
        private DirtyValue<int?> _firstChangeRecase;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast [QM.X7]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast")]
        public int? FirstChangeRecase { get => _firstChangeRecase; set => SetField(ref _firstChangeRecase, value); }
        private DirtyValue<DateTime?> _firstPmtDateAfterRecast;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast [QM.X15]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast")]
        public DateTime? FirstPmtDateAfterRecast { get => _firstPmtDateAfterRecast; set => SetField(ref _firstPmtDateAfterRecast, value); }
        private DirtyValue<decimal?> _fullPaymentAfterInterestOnly;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast [QM.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast")]
        public decimal? FullPaymentAfterInterestOnly { get => _fullPaymentAfterInterestOnly; set => SetField(ref _fullPaymentAfterInterestOnly, value); }
        private DirtyValue<decimal?> _fullyARMPaymentAfterNegAm;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast [QM.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast")]
        public decimal? FullyARMPaymentAfterNegAm { get => _fullyARMPaymentAfterNegAm; set => SetField(ref _fullyARMPaymentAfterNegAm, value); }
        private DirtyValue<decimal?> _fullyIndexRateHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Housing Ratio [QM.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fully Index Rate Housing Ratio")]
        public decimal? FullyIndexRateHousingRatio { get => _fullyIndexRateHousingRatio; set => SetField(ref _fullyIndexRateHousingRatio, value); }
        private DirtyValue<decimal?> _fullyIndexRateMaxTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Max Total Payment [QM.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fully Index Rate Max Total Payment")]
        public decimal? FullyIndexRateMaxTotalPayment { get => _fullyIndexRateMaxTotalPayment; set => SetField(ref _fullyIndexRateMaxTotalPayment, value); }
        private DirtyValue<decimal?> _fullyIndexRateMonthlyPayment;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Monthly Payment [QM.X373]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fully Index Rate Monthly Payment")]
        public decimal? FullyIndexRateMonthlyPayment { get => _fullyIndexRateMonthlyPayment; set => SetField(ref _fullyIndexRateMonthlyPayment, value); }
        private DirtyValue<decimal?> _fullyIndexRateTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Total Debt Ratio [QM.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fully Index Rate Total Debt Ratio")]
        public decimal? FullyIndexRateTotalDebtRatio { get => _fullyIndexRateTotalDebtRatio; set => SetField(ref _fullyIndexRateTotalDebtRatio, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Alimony [QM.X37]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Alimony")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAlimony { get => _generalATRStatusAlimony; set => SetField(ref _generalATRStatusAlimony, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Assets [QM.X35]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Assets")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAssets { get => _generalATRStatusAssets; set => SetField(ref _generalATRStatusAssets, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Child Support [QM.X38]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Child Support")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusChildSupport { get => _generalATRStatusChildSupport; set => SetField(ref _generalATRStatusChildSupport, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Covered Loan [QM.X29]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Covered Loan")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCoveredLoan { get => _generalATRStatusCoveredLoan; set => SetField(ref _generalATRStatusCoveredLoan, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Credit History [QM.X39]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Credit History")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCreditHistory { get => _generalATRStatusCreditHistory; set => SetField(ref _generalATRStatusCreditHistory, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations [QM.X36]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDebtObligations { get => _generalATRStatusDebtObligations; set => SetField(ref _generalATRStatusDebtObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio [QM.X27]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDTI { get => _generalATRStatusDTI; set => SetField(ref _generalATRStatusDTI, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Employment [QM.X33]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Employment")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusEmployment { get => _generalATRStatusEmployment; set => SetField(ref _generalATRStatusEmployment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Income [QM.X34]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Income")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusIncome { get => _generalATRStatusIncome; set => SetField(ref _generalATRStatusIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations [QM.X31]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusMtgRelatedObligations { get => _generalATRStatusMtgRelatedObligations; set => SetField(ref _generalATRStatusMtgRelatedObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility [QM.X26]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusOverall { get => _generalATRStatusOverall; set => SetField(ref _generalATRStatusOverall, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Residual Income [QM.X28]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Residual Income")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusResidualIncome { get => _generalATRStatusResidualIncome; set => SetField(ref _generalATRStatusResidualIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan [QM.X30]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusSimultaneousLoan { get => _generalATRStatusSimultaneousLoan; set => SetField(ref _generalATRStatusSimultaneousLoan, value); }
        private DirtyValue<decimal?> _gSEAgencyQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold [QM.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold")]
        public decimal? GSEAgencyQMCalculatedThreshold { get => _gSEAgencyQMCalculatedThreshold; set => SetField(ref _gSEAgencyQMCalculatedThreshold, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony [QM.X79]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAlimony { get => _gSEAgencyQMStatusAlimony; set => SetField(ref _gSEAgencyQMStatusAlimony, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets [QM.X77]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAssets { get => _gSEAgencyQMStatusAssets; set => SetField(ref _gSEAgencyQMStatusAssets, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment [QM.X66]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusBalloonPayment { get => _gSEAgencyQMStatusBalloonPayment; set => SetField(ref _gSEAgencyQMStatusBalloonPayment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support [QM.X80]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusChildSupport { get => _gSEAgencyQMStatusChildSupport; set => SetField(ref _gSEAgencyQMStatusChildSupport, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan [QM.X71]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCoveredLoan { get => _gSEAgencyQMStatusCoveredLoan; set => SetField(ref _gSEAgencyQMStatusCoveredLoan, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History [QM.X81]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCreditHistory { get => _gSEAgencyQMStatusCreditHistory; set => SetField(ref _gSEAgencyQMStatusCreditHistory, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations [QM.X78]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDebtObligations { get => _gSEAgencyQMStatusDebtObligations; set => SetField(ref _gSEAgencyQMStatusDebtObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio [QM.X69]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDTI { get => _gSEAgencyQMStatusDTI; set => SetField(ref _gSEAgencyQMStatusDTI, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment [QM.X75]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusEmployment { get => _gSEAgencyQMStatusEmployment; set => SetField(ref _gSEAgencyQMStatusEmployment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income [QM.X76]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusIncome { get => _gSEAgencyQMStatusIncome; set => SetField(ref _gSEAgencyQMStatusIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only [QM.X64]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusInterestOnly { get => _gSEAgencyQMStatusInterestOnly; set => SetField(ref _gSEAgencyQMStatusInterestOnly, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term [QM.X63]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusLoanTerm { get => _gSEAgencyQMStatusLoanTerm; set => SetField(ref _gSEAgencyQMStatusLoanTerm, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations [QM.X73]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusMtgRelatedObligations { get => _gSEAgencyQMStatusMtgRelatedObligations; set => SetField(ref _gSEAgencyQMStatusMtgRelatedObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization [QM.X65]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusNegativeAmortization { get => _gSEAgencyQMStatusNegativeAmortization; set => SetField(ref _gSEAgencyQMStatusNegativeAmortization, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility [QM.X62]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusOverall { get => _gSEAgencyQMStatusOverall; set => SetField(ref _gSEAgencyQMStatusOverall, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit [QM.X68]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPointsFeesLimit { get => _gSEAgencyQMStatusPointsFeesLimit; set => SetField(ref _gSEAgencyQMStatusPointsFeesLimit, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty [QM.X67]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPrepaymentPenalty { get => _gSEAgencyQMStatusPrepaymentPenalty; set => SetField(ref _gSEAgencyQMStatusPrepaymentPenalty, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income [QM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusResidualIncome { get => _gSEAgencyQMStatusResidualIncome; set => SetField(ref _gSEAgencyQMStatusResidualIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility [QM.X82]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSafeHarborEligibility { get => _gSEAgencyQMStatusSafeHarborEligibility; set => SetField(ref _gSEAgencyQMStatusSafeHarborEligibility, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan [QM.X72]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSimultaneousLoan { get => _gSEAgencyQMStatusSimultaneousLoan; set => SetField(ref _gSEAgencyQMStatusSimultaneousLoan, value); }
        private DirtyValue<bool?> _has30DayLatePayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months? [QM.X3]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months?")]
        public bool? Has30DayLatePayment { get => _has30DayLatePayment; set => SetField(ref _has30DayLatePayment, value); }
        private DirtyValue<string> _id;
        /// <summary>
        /// ATRQMCommon Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<decimal?> _initialMaxTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Initial Max Total Payment [QM.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Initial Max Total Payment")]
        public decimal? InitialMaxTotalPayment { get => _initialMaxTotalPayment; set => SetField(ref _initialMaxTotalPayment, value); }
        private DirtyValue<decimal?> _initialRateHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Housing Ratio [QM.X375]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Initial Rate Housing Ratio")]
        public decimal? InitialRateHousingRatio { get => _initialRateHousingRatio; set => SetField(ref _initialRateHousingRatio, value); }
        private DirtyValue<decimal?> _initialRateMonthlyPayment;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Monthly Payment [QM.X374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Initial Rate Monthly Payment")]
        public decimal? InitialRateMonthlyPayment { get => _initialRateMonthlyPayment; set => SetField(ref _initialRateMonthlyPayment, value); }
        private DirtyValue<decimal?> _initialRateTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Total Debt Ratio [QM.X376]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Initial Rate Total Debt Ratio")]
        public decimal? InitialRateTotalDebtRatio { get => _initialRateTotalDebtRatio; set => SetField(ref _initialRateTotalDebtRatio, value); }
        private DirtyValue<int?> _interestOnlyMonths;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months [QM.X10]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months")]
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => SetField(ref _interestOnlyMonths, value); }
        private DirtyValue<DateTime?> _interestOnlyRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date [QM.X11]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date")]
        public DateTime? InterestOnlyRecastDate { get => _interestOnlyRecastDate; set => SetField(ref _interestOnlyRecastDate, value); }
        private DirtyValue<bool?> _isConsumerLiklyDefault;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount? [QM.X16]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount?")]
        public bool? IsConsumerLiklyDefault { get => _isConsumerLiklyDefault; set => SetField(ref _isConsumerLiklyDefault, value); }
        private DirtyValue<StringEnumValue<YesNoOrNA>> _isEligibleForSafeHarbor;
        /// <summary>
        /// ATR QM - Eligibility - Is Loan Eligible for Safe Harbor? [QM.X25]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Is Loan Eligible for Safe Harbor?")]
        public StringEnumValue<YesNoOrNA> IsEligibleForSafeHarbor { get => _isEligibleForSafeHarbor; set => SetField(ref _isEligibleForSafeHarbor, value); }
        private DirtyValue<bool?> _isEvaluatedAlimonyObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations [QM.X343]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations")]
        public bool? IsEvaluatedAlimonyObligations { get => _isEvaluatedAlimonyObligations; set => SetField(ref _isEvaluatedAlimonyObligations, value); }
        private DirtyValue<bool?> _isEvaluatedChildSupportObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations [QM.X342]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations")]
        public bool? IsEvaluatedChildSupportObligations { get => _isEvaluatedChildSupportObligations; set => SetField(ref _isEvaluatedChildSupportObligations, value); }
        private DirtyValue<bool?> _isEvaluatedCreditHistory;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History [QM.X347]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History")]
        public bool? IsEvaluatedCreditHistory { get => _isEvaluatedCreditHistory; set => SetField(ref _isEvaluatedCreditHistory, value); }
        private DirtyValue<bool?> _isEvaluatedCurrentEmploymentStatus;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status [QM.X344]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status")]
        public bool? IsEvaluatedCurrentEmploymentStatus { get => _isEvaluatedCurrentEmploymentStatus; set => SetField(ref _isEvaluatedCurrentEmploymentStatus, value); }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedAssets;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets [QM.X346]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets")]
        public bool? IsEvaluatedCurrentExpectedAssets { get => _isEvaluatedCurrentExpectedAssets; set => SetField(ref _isEvaluatedCurrentExpectedAssets, value); }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedIncome;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income [QM.X345]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income")]
        public bool? IsEvaluatedCurrentExpectedIncome { get => _isEvaluatedCurrentExpectedIncome; set => SetField(ref _isEvaluatedCurrentExpectedIncome, value); }
        private DirtyValue<bool?> _isEvaluatedDebtObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations [QM.X341]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations")]
        public bool? IsEvaluatedDebtObligations { get => _isEvaluatedDebtObligations; set => SetField(ref _isEvaluatedDebtObligations, value); }
        private DirtyValue<bool?> _isEvaluatedDebtToIncomeRatio;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio [QM.X348]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio")]
        public bool? IsEvaluatedDebtToIncomeRatio { get => _isEvaluatedDebtToIncomeRatio; set => SetField(ref _isEvaluatedDebtToIncomeRatio, value); }
        private DirtyValue<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment [QM.X338]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment")]
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get => _isEvaluatedMonthlyCoveredLoanPayment; set => SetField(ref _isEvaluatedMonthlyCoveredLoanPayment, value); }
        private DirtyValue<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations [QM.X340]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations")]
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get => _isEvaluatedMonthlyMortgageRelatedObligations; set => SetField(ref _isEvaluatedMonthlyMortgageRelatedObligations, value); }
        private DirtyValue<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment [QM.X339]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment")]
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get => _isEvaluatedMonthlySimultaneousLoanPayment; set => SetField(ref _isEvaluatedMonthlySimultaneousLoanPayment, value); }
        private DirtyValue<bool?> _isEvaluatedResidualIncome;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income [QM.X349]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income")]
        public bool? IsEvaluatedResidualIncome { get => _isEvaluatedResidualIncome; set => SetField(ref _isEvaluatedResidualIncome, value); }
        private DirtyValue<StringEnumValue<IsOrIsNot>> _isHigherPricedLoan;
        /// <summary>
        /// ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction [QM.X135]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction")]
        public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => _isHigherPricedLoan; set => SetField(ref _isHigherPricedLoan, value); }
        private DirtyValue<string> _loanProcessingInformationCode24;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24 [AUSF.X63]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24")]
        public string LoanProcessingInformationCode24 { get => _loanProcessingInformationCode24; set => SetField(ref _loanProcessingInformationCode24, value); }
        private DirtyValue<string> _loanProcessingInformationCode31;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31 [AUSF.X64]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31")]
        public string LoanProcessingInformationCode31 { get => _loanProcessingInformationCode31; set => SetField(ref _loanProcessingInformationCode31, value); }
        private DirtyValue<string> _loanProcessingInformationCode32;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32 [AUSF.X65]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32")]
        public string LoanProcessingInformationCode32 { get => _loanProcessingInformationCode32; set => SetField(ref _loanProcessingInformationCode32, value); }
        private DirtyValue<string> _loanProcessingInformationCode33;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33 [AUSF.X66]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33")]
        public string LoanProcessingInformationCode33 { get => _loanProcessingInformationCode33; set => SetField(ref _loanProcessingInformationCode33, value); }
        private DirtyValue<string> _loanProcessingInformationCode97;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97 [AUSF.X67]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97")]
        public string LoanProcessingInformationCode97 { get => _loanProcessingInformationCode97; set => SetField(ref _loanProcessingInformationCode97, value); }
        private DirtyValue<string> _loanProcessingInformationCodeJr;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR [AUSF.X68]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR")]
        public string LoanProcessingInformationCodeJr { get => _loanProcessingInformationCodeJr; set => SetField(ref _loanProcessingInformationCodeJr, value); }
        private DirtyValue<string> _loanProcessingInformationCodeJt;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT [AUSF.X69]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT")]
        public string LoanProcessingInformationCodeJt { get => _loanProcessingInformationCodeJt; set => SetField(ref _loanProcessingInformationCodeJt, value); }
        private DirtyValue<string> _loanProcessingInformationD4;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4) [AUSF.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4)")]
        public string LoanProcessingInformationD4 { get => _loanProcessingInformationD4; set => SetField(ref _loanProcessingInformationD4, value); }
        private DirtyValue<string> _loanProcessingInformationGO;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO) [AUSF.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO)")]
        public string LoanProcessingInformationGO { get => _loanProcessingInformationGO; set => SetField(ref _loanProcessingInformationGO, value); }
        private DirtyValue<string> _loanProcessingInformationHA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA) [AUSF.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA)")]
        public string LoanProcessingInformationHA { get => _loanProcessingInformationHA; set => SetField(ref _loanProcessingInformationHA, value); }
        private DirtyValue<string> _loanProcessingInformationLE;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE) [AUSF.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE)")]
        public string LoanProcessingInformationLE { get => _loanProcessingInformationLE; set => SetField(ref _loanProcessingInformationLE, value); }
        private DirtyValue<string> _loanProcessingInformationLF;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF) [AUSF.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF)")]
        public string LoanProcessingInformationLF { get => _loanProcessingInformationLF; set => SetField(ref _loanProcessingInformationLF, value); }
        private DirtyValue<string> _loanProcessingInformationMA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA) [AUSF.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA)")]
        public string LoanProcessingInformationMA { get => _loanProcessingInformationMA; set => SetField(ref _loanProcessingInformationMA, value); }
        private DirtyValue<bool?> _loanProgram;
        /// <summary>
        /// ATR QM - Eligibility - Loan Program [QM.X106]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Loan Program")]
        public bool? LoanProgram { get => _loanProgram; set => SetField(ref _loanProgram, value); }
        private DirtyValue<StringEnumValue<LoanProgramDescription>> _loanProgramDescription;
        /// <summary>
        /// ATR QM - Eligibility - Loan Program Description [QM.X107]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Loan Program Description")]
        public StringEnumValue<LoanProgramDescription> LoanProgramDescription { get => _loanProgramDescription; set => SetField(ref _loanProgramDescription, value); }
        private DirtyValue<bool?> _loanRateFixedin5Years;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years? [QM.X17]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years?")]
        public bool? LoanRateFixedin5Years { get => _loanRateFixedin5Years; set => SetField(ref _loanRateFixedin5Years, value); }
        private DirtyValue<decimal?> _lOBrokerCompensationAmount;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation [QM.X371]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation")]
        public decimal? LOBrokerCompensationAmount { get => _lOBrokerCompensationAmount; set => SetField(ref _lOBrokerCompensationAmount, value); }
        private DirtyValue<decimal?> _max5YrsHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio [QM.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio")]
        public decimal? Max5YrsHousingRatio { get => _max5YrsHousingRatio; set => SetField(ref _max5YrsHousingRatio, value); }
        private DirtyValue<decimal?> _max5YrsPrincipleAndInterest;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [QM.X337]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Max P & I")]
        public decimal? Max5YrsPrincipleAndInterest { get => _max5YrsPrincipleAndInterest; set => SetField(ref _max5YrsPrincipleAndInterest, value); }
        private DirtyValue<decimal?> _max5YrsTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio [QM.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio")]
        public decimal? Max5YrsTotalDebtRatio { get => _max5YrsTotalDebtRatio; set => SetField(ref _max5YrsTotalDebtRatio, value); }
        private DirtyValue<decimal?> _max5YrsTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment [QM.X117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment")]
        public decimal? Max5YrsTotalPayment { get => _max5YrsTotalPayment; set => SetField(ref _max5YrsTotalPayment, value); }
        private DirtyValue<decimal?> _maxPrepaymentPenaltyFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty [QM.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty")]
        public decimal? MaxPrepaymentPenaltyFees { get => _maxPrepaymentPenaltyFees; set => SetField(ref _maxPrepaymentPenaltyFees, value); }
        private DirtyValue<DateTime?> _negAmRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date [QM.X13]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date")]
        public DateTime? NegAmRecastDate { get => _negAmRecastDate; set => SetField(ref _negAmRecastDate, value); }
        private DirtyValue<bool?> _paymentDecreasedBy10Percent;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more? [QM.X18]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more?")]
        public bool? PaymentDecreasedBy10Percent { get => _paymentDecreasedBy10Percent; set => SetField(ref _paymentDecreasedBy10Percent, value); }
        private DirtyValue<bool?> _pointsFeesThresholdMet;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met? [QM.X21]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met?")]
        public bool? PointsFeesThresholdMet { get => _pointsFeesThresholdMet; set => SetField(ref _pointsFeesThresholdMet, value); }
        private DirtyValue<decimal?> _prepaymentPenaltyPayoffFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff [QM.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff")]
        public decimal? PrepaymentPenaltyPayoffFees { get => _prepaymentPenaltyPayoffFees; set => SetField(ref _prepaymentPenaltyPayoffFees, value); }
        private DirtyValue<decimal?> _prepayPenaltyPercentage;
        /// <summary>
        /// ATR QM - Qualification - Prepay Penalty Percentage [QM.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Prepay Penalty Percentage")]
        public decimal? PrepayPenaltyPercentage { get => _prepayPenaltyPercentage; set => SetField(ref _prepayPenaltyPercentage, value); }
        private DirtyValue<bool?> _preventConsumersDefault;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default? [QM.X22]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default?")]
        public bool? PreventConsumersDefault { get => _preventConsumersDefault; set => SetField(ref _preventConsumersDefault, value); }
        private DirtyValue<bool?> _principalBalanceIncreased;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase? [QM.X6]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase?")]
        public bool? PrincipalBalanceIncreased { get => _principalBalanceIncreased; set => SetField(ref _principalBalanceIncreased, value); }
        private DirtyValue<bool?> _principalHasDeferred;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments? [QM.X20]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments?")]
        public bool? PrincipalHasDeferred { get => _principalHasDeferred; set => SetField(ref _principalHasDeferred, value); }
        private DirtyValue<StringEnumValue<QMLoanType>> _qMLoanType;
        /// <summary>
        /// ATR QM - Eligibility - Qualified Mortgage Loan Type [QM.X24]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Qualified Mortgage Loan Type")]
        public StringEnumValue<QMLoanType> QMLoanType { get => _qMLoanType; set => SetField(ref _qMLoanType, value); }
        private DirtyValue<decimal?> _rateReductionBasisPoints;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Basis Points % [QM.X365]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Rate Reduction Basis Points %")]
        public decimal? RateReductionBasisPoints { get => _rateReductionBasisPoints; set => SetField(ref _rateReductionBasisPoints, value); }
        private DirtyValue<decimal?> _rateReductionDiscountPoints;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Discount Points % [QM.X366]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Rate Reduction Discount Points %")]
        public decimal? RateReductionDiscountPoints { get => _rateReductionDiscountPoints; set => SetField(ref _rateReductionDiscountPoints, value); }
        private DirtyValue<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point % [QM.X367]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point %")]
        public decimal? RateReductionMaxBonaFideDiscountPoint { get => _rateReductionMaxBonaFideDiscountPoint; set => SetField(ref _rateReductionMaxBonaFideDiscountPoint, value); }
        private DirtyValue<decimal?> _realEstateFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees [QM.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees")]
        public decimal? RealEstateFees { get => _realEstateFees; set => SetField(ref _realEstateFees, value); }
        private DirtyValue<decimal?> _recastDifferencePayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment [QM.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment")]
        public decimal? RecastDifferencePayment { get => _recastDifferencePayment; set => SetField(ref _recastDifferencePayment, value); }
        private DirtyValue<decimal?> _regZTotalLoanAmount;
        /// <summary>
        /// ATR QM - Qualification - Reg-Z Total Loan Amount [QM.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Reg-Z Total Loan Amount")]
        public decimal? RegZTotalLoanAmount { get => _regZTotalLoanAmount; set => SetField(ref _regZTotalLoanAmount, value); }
        private DirtyValue<decimal?> _requiredServicesLenderSelectedAmt;
        /// <summary>
        /// ATR QM - Qualification - Required Services - Lender Selected Amount [QM.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Required Services - Lender Selected Amount")]
        public decimal? RequiredServicesLenderSelectedAmt { get => _requiredServicesLenderSelectedAmt; set => SetField(ref _requiredServicesLenderSelectedAmt, value); }
        private DirtyValue<decimal?> _smallCreditorQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold [QM.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold")]
        public decimal? SmallCreditorQMCalculatedThreshold { get => _smallCreditorQMCalculatedThreshold; set => SetField(ref _smallCreditorQMCalculatedThreshold, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony [QM.X99]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAlimony { get => _smallCreditorQMStatusAlimony; set => SetField(ref _smallCreditorQMStatusAlimony, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets [QM.X97]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAssets { get => _smallCreditorQMStatusAssets; set => SetField(ref _smallCreditorQMStatusAssets, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment [QM.X88]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusBalloonPayment { get => _smallCreditorQMStatusBalloonPayment; set => SetField(ref _smallCreditorQMStatusBalloonPayment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support [QM.X100]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusChildSupport { get => _smallCreditorQMStatusChildSupport; set => SetField(ref _smallCreditorQMStatusChildSupport, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan [QM.X93]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusCoveredLoan { get => _smallCreditorQMStatusCoveredLoan; set => SetField(ref _smallCreditorQMStatusCoveredLoan, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations [QM.X98]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDebtObligations { get => _smallCreditorQMStatusDebtObligations; set => SetField(ref _smallCreditorQMStatusDebtObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio [QM.X91]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDTI { get => _smallCreditorQMStatusDTI; set => SetField(ref _smallCreditorQMStatusDTI, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income [QM.X96]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusIncome { get => _smallCreditorQMStatusIncome; set => SetField(ref _smallCreditorQMStatusIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only [QM.X86]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusInterestOnly { get => _smallCreditorQMStatusInterestOnly; set => SetField(ref _smallCreditorQMStatusInterestOnly, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term [QM.X85]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusLoanTerm { get => _smallCreditorQMStatusLoanTerm; set => SetField(ref _smallCreditorQMStatusLoanTerm, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations [QM.X94]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusMtgRelatedObligations { get => _smallCreditorQMStatusMtgRelatedObligations; set => SetField(ref _smallCreditorQMStatusMtgRelatedObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization [QM.X87]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusNegativeAmortization { get => _smallCreditorQMStatusNegativeAmortization; set => SetField(ref _smallCreditorQMStatusNegativeAmortization, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility [QM.X84]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusOverall { get => _smallCreditorQMStatusOverall; set => SetField(ref _smallCreditorQMStatusOverall, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit [QM.X90]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPointsFeesLimit { get => _smallCreditorQMStatusPointsFeesLimit; set => SetField(ref _smallCreditorQMStatusPointsFeesLimit, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty [QM.X89]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPrepaymentPenalty { get => _smallCreditorQMStatusPrepaymentPenalty; set => SetField(ref _smallCreditorQMStatusPrepaymentPenalty, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income [QM.X92]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusResidualIncome { get => _smallCreditorQMStatusResidualIncome; set => SetField(ref _smallCreditorQMStatusResidualIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility [QM.X101]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusSafeHarborEligibility { get => _smallCreditorQMStatusSafeHarborEligibility; set => SetField(ref _smallCreditorQMStatusSafeHarborEligibility, value); }
        private DirtyValue<decimal?> _standardQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold [QM.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold")]
        public decimal? StandardQMCalculatedThreshold { get => _standardQMCalculatedThreshold; set => SetField(ref _standardQMCalculatedThreshold, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Alimony [QM.X57]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusAlimony { get => _standardQMStatusAlimony; set => SetField(ref _standardQMStatusAlimony, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Assets [QM.X55]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusAssets { get => _standardQMStatusAssets; set => SetField(ref _standardQMStatusAssets, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment [QM.X44]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusBalloonPayment { get => _standardQMStatusBalloonPayment; set => SetField(ref _standardQMStatusBalloonPayment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Child Support [QM.X58]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusChildSupport { get => _standardQMStatusChildSupport; set => SetField(ref _standardQMStatusChildSupport, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan [QM.X49]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusCoveredLoan { get => _standardQMStatusCoveredLoan; set => SetField(ref _standardQMStatusCoveredLoan, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Credit History [QM.X59]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusCreditHistory { get => _standardQMStatusCreditHistory; set => SetField(ref _standardQMStatusCreditHistory, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations [QM.X56]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusDebtObligations { get => _standardQMStatusDebtObligations; set => SetField(ref _standardQMStatusDebtObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio [QM.X47]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusDTI { get => _standardQMStatusDTI; set => SetField(ref _standardQMStatusDTI, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Employment [QM.X53]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Employment")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusEmployment { get => _standardQMStatusEmployment; set => SetField(ref _standardQMStatusEmployment, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Income [QM.X54]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusIncome { get => _standardQMStatusIncome; set => SetField(ref _standardQMStatusIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only [QM.X42]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusInterestOnly { get => _standardQMStatusInterestOnly; set => SetField(ref _standardQMStatusInterestOnly, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term [QM.X41]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusLoanTerm { get => _standardQMStatusLoanTerm; set => SetField(ref _standardQMStatusLoanTerm, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations [QM.X51]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusMtgRelatedObligations { get => _standardQMStatusMtgRelatedObligations; set => SetField(ref _standardQMStatusMtgRelatedObligations, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization [QM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusNegativeAmortization { get => _standardQMStatusNegativeAmortization; set => SetField(ref _standardQMStatusNegativeAmortization, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility [QM.X40]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusOverall { get => _standardQMStatusOverall; set => SetField(ref _standardQMStatusOverall, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit [QM.X46]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusPointsFeesLimit { get => _standardQMStatusPointsFeesLimit; set => SetField(ref _standardQMStatusPointsFeesLimit, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty [QM.X45]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusPrepaymentPenalty { get => _standardQMStatusPrepaymentPenalty; set => SetField(ref _standardQMStatusPrepaymentPenalty, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income [QM.X48]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusResidualIncome { get => _standardQMStatusResidualIncome; set => SetField(ref _standardQMStatusResidualIncome, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility [QM.X60]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusSafeHarborEligibility { get => _standardQMStatusSafeHarborEligibility; set => SetField(ref _standardQMStatusSafeHarborEligibility, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan [QM.X50]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusSimultaneousLoan { get => _standardQMStatusSimultaneousLoan; set => SetField(ref _standardQMStatusSimultaneousLoan, value); }
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point % [QM.X368]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point %")]
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => _startingAdjustedRateMaxBonaFideDiscountPoint; set => SetField(ref _startingAdjustedRateMaxBonaFideDiscountPoint, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History [QM.X351]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> StatusCreditHistory { get => _statusCreditHistory; set => SetField(ref _statusCreditHistory, value); }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan [QM.X350]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> StatusSimultaneousLoan { get => _statusSimultaneousLoan; set => SetField(ref _statusSimultaneousLoan, value); }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thresholdExceedsQM;
        /// <summary>
        /// ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages [QM.X124]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages")]
        public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQM { get => _thresholdExceedsQM; set => SetField(ref _thresholdExceedsQM, value); }
        private DirtyValue<decimal?> _titleServicesLenderTitleinsuranceFee;
        /// <summary>
        /// ATR QM - Qualification - Title Services and Lender's Title Ins [QM.X377]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Title Services and Lender's Title Ins")]
        public decimal? TitleServicesLenderTitleinsuranceFee { get => _titleServicesLenderTitleinsuranceFee; set => SetField(ref _titleServicesLenderTitleinsuranceFee, value); }
        private DirtyValue<decimal?> _totalCoMortgagorIncome;
        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income [QM.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income")]
        public decimal? TotalCoMortgagorIncome { get => _totalCoMortgagorIncome; set => SetField(ref _totalCoMortgagorIncome, value); }
        private DirtyValue<decimal?> _totalIncome;
        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Income [QM.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR/QM Management - Appendix Q - Income - Total Income")]
        public decimal? TotalIncome { get => _totalIncome; set => SetField(ref _totalIncome, value); }
        private DirtyValue<decimal?> _totalPointsFeesSec32Percent;
        /// <summary>
        /// ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32 [QM.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32")]
        public decimal? TotalPointsFeesSec32Percent { get => _totalPointsFeesSec32Percent; set => SetField(ref _totalPointsFeesSec32Percent, value); }
        private DirtyValue<bool?> _transactionExemptFromRegZ;
        /// <summary>
        /// ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements [QM.X103]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements")]
        public bool? TransactionExemptFromRegZ { get => _transactionExemptFromRegZ; set => SetField(ref _transactionExemptFromRegZ, value); }
        private DirtyValue<string> _ucdRequirement;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - UCD Requirement [AUSF.X70]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - UCD Requirement")]
        public string UcdRequirement { get => _ucdRequirement; set => SetField(ref _ucdRequirement, value); }
        private DirtyValue<bool?> _unitCount;
        /// <summary>
        /// ATR QM - Eligibility - Unit Count [QM.X108]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Unit Count")]
        public bool? UnitCount { get => _unitCount; set => SetField(ref _unitCount, value); }
        private DirtyValue<decimal?> _upfrontPMIFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI [QM.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI")]
        public decimal? UpfrontPMIFees { get => _upfrontPMIFees; set => SetField(ref _upfrontPMIFees, value); }
        private DirtyValue<bool?> _withOriginalCreditor;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor  [QM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor ")]
        public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => SetField(ref _withOriginalCreditor, value); }
        private DirtyValue<DateTime?> _writtenApplicationDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date [QM.X5]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date")]
        public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => SetField(ref _writtenApplicationDate, value); }
    }
}