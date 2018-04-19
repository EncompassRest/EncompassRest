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
        public decimal? AffiliatesFees { get => _affiliatesFees; set => _affiliatesFees = value; }
        private DirtyValue<decimal?> _aPORMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - APOR Max Bona Fide Discount Point % [QM.X364]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - APOR Max Bona Fide Discount Point %")]
        public decimal? APORMaxBonaFideDiscountPoint { get => _aPORMaxBonaFideDiscountPoint; set => _aPORMaxBonaFideDiscountPoint = value; }
        private DirtyValue<DateTime?> _aRMRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date [QM.X8]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Date")]
        public DateTime? ARMRecastDate { get => _aRMRecastDate; set => _aRMRecastDate = value; }
        private DirtyValue<decimal?> _aRMRecastMonthlyPayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment [QM.X9]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - ARM Recast Monthly Payment")]
        public decimal? ARMRecastMonthlyPayment { get => _aRMRecastMonthlyPayment; set => _aRMRecastMonthlyPayment = value; }
        private DirtyValue<string> _assetRepresentationAndWarrantyReliefEligibilityType;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type [AUSF.X62]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Asset Representation And Warranty Relief Eligibility Type")]
        public string AssetRepresentationAndWarrantyReliefEligibilityType { get => _assetRepresentationAndWarrantyReliefEligibilityType; set => _assetRepresentationAndWarrantyReliefEligibilityType = value; }
        private DirtyValue<StringEnumValue<ATRLoanType>> _aTRLoanType;
        /// <summary>
        /// ATR QM - Eligibility - Ability-to-Repay Loan Type [QM.X23]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Ability-to-Repay Loan Type")]
        public StringEnumValue<ATRLoanType> ATRLoanType { get => _aTRLoanType; set => _aTRLoanType = value; }
        private DirtyValue<string> _aUSDataDiscrepencyResolutionComments;
        /// <summary>
        /// AUS Data Discrepency Resolution Comments [AUSF.X20]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution Comments")]
        public string AUSDataDiscrepencyResolutionComments { get => _aUSDataDiscrepencyResolutionComments; set => _aUSDataDiscrepencyResolutionComments = value; }
        private DirtyValue<DateTime?> _aUSDataDiscrepencyResolutionDate;
        /// <summary>
        /// AUS Data Discrepency Resolution Date [AUSF.X19]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution Date")]
        public DateTime? AUSDataDiscrepencyResolutionDate { get => _aUSDataDiscrepencyResolutionDate; set => _aUSDataDiscrepencyResolutionDate = value; }
        private DirtyValue<string> _aUSDataDiscrepencyResolvedBy;
        /// <summary>
        /// AUS Data Discrepency Resolution User [AUSF.X21]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Data Discrepency Resolution User")]
        public string AUSDataDiscrepencyResolvedBy { get => _aUSDataDiscrepencyResolvedBy; set => _aUSDataDiscrepencyResolvedBy = value; }
        private DirtyValue<decimal?> _bonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point % [QM.X369]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Bona Fide Discount Point %")]
        public decimal? BonaFideDiscountPoint { get => _bonaFideDiscountPoint; set => _bonaFideDiscountPoint = value; }
        private DirtyValue<decimal?> _bonaFideDiscountPointAmount;
        /// <summary>
        /// ATR QM - Qualification - Bona Fide Discount Point Amount [QM.X370]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "ATR QM - Qualification - Bona Fide Discount Point Amount")]
        public decimal? BonaFideDiscountPointAmount { get => _bonaFideDiscountPointAmount; set => _bonaFideDiscountPointAmount = value; }
        private DirtyValue<bool?> _brokerCompensationWhenRateSet;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set [QM.X372]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - Fees from 2010 Itemization - Broker Compensation when rate was set")]
        public bool? BrokerCompensationWhenRateSet { get => _brokerCompensationWhenRateSet; set => _brokerCompensationWhenRateSet = value; }
        private DirtyValue<StringEnumValue<CollateralRepandWarrReliefEligibilityType>> _collateralRepandWarrReliefEligibilityType;
        /// <summary>
        /// Collateral Rep and Warranty Relief Eligibility Type [AUSF.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Collateral Rep and Warranty Relief Eligibility Type")]
        public StringEnumValue<CollateralRepandWarrReliefEligibilityType> CollateralRepandWarrReliefEligibilityType { get => _collateralRepandWarrReliefEligibilityType; set => _collateralRepandWarrReliefEligibilityType = value; }
        private DirtyValue<decimal?> _compensationPTBFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers [QM.X133]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Compensation Paid to Brokers")]
        public decimal? CompensationPTBFees { get => _compensationPTBFees; set => _compensationPTBFees = value; }
        private DirtyValue<decimal?> _creditInsPremiumFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium [QM.X132]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Credit Related Insurance Premium")]
        public decimal? CreditInsPremiumFees { get => _creditInsPremiumFees; set => _creditInsPremiumFees = value; }
        private DirtyValue<bool?> _creditorType;
        /// <summary>
        /// ATR QM - Eligibility - Creditor Type [QM.X104]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Creditor Type")]
        public bool? CreditorType { get => _creditorType; set => _creditorType = value; }
        private DirtyValue<StringEnumValue<CreditorTypeDescription>> _creditorTypeDescription;
        /// <summary>
        /// ATR QM - Eligibility - Creditor Type Description [QM.X105]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Creditor Type Description")]
        public StringEnumValue<CreditorTypeDescription> CreditorTypeDescription { get => _creditorTypeDescription; set => _creditorTypeDescription = value; }
        private DirtyValue<bool?> _creditType;
        /// <summary>
        /// ATR QM - Eligibility - Credit Type [QM.X110]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Credit Type")]
        public bool? CreditType { get => _creditType; set => _creditType = value; }
        private DirtyValue<decimal?> _currentQMFeeThresholdAmt;
        /// <summary>
        /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount [QM.X121]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Amount")]
        public decimal? CurrentQMFeeThresholdAmt { get => _currentQMFeeThresholdAmt; set => _currentQMFeeThresholdAmt = value; }
        private DirtyValue<decimal?> _currentQMFeeThresholdPercent;
        /// <summary>
        /// ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage [QM.X122]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Current Qualified Mortgage Fee Threshold Percentage")]
        public decimal? CurrentQMFeeThresholdPercent { get => _currentQMFeeThresholdPercent; set => _currentQMFeeThresholdPercent = value; }
        private DirtyValue<DateTime?> _dateOfLastMonthlyPayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment [QM.X4]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Date of last monthly payment")]
        public DateTime? DateOfLastMonthlyPayment { get => _dateOfLastMonthlyPayment; set => _dateOfLastMonthlyPayment = value; }
        private DirtyValue<decimal?> _discountPointAmount;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount [QM.X111]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees from 2010 Itemization - Discount Points Amount")]
        public decimal? DiscountPointAmount { get => _discountPointAmount; set => _discountPointAmount = value; }
        private DirtyValue<decimal?> _discountPointFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees [QM.X128]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Discount Point Fees")]
        public decimal? DiscountPointFees { get => _discountPointFees; set => _discountPointFees = value; }
        private DirtyValue<decimal?> _discountPointPercentage;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - Discount Points % [QM.X136]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fees from 2010 Itemization - Discount Points %")]
        public decimal? DiscountPointPercentage { get => _discountPointPercentage; set => _discountPointPercentage = value; }
        private DirtyValue<string> _documentationGuidelineMessages4V;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V) [AUSF.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (4V)")]
        public string DocumentationGuidelineMessages4V { get => _documentationGuidelineMessages4V; set => _documentationGuidelineMessages4V = value; }
        private DirtyValue<string> _documentationGuidelineMessages5C;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C) [AUSF.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (5C)")]
        public string DocumentationGuidelineMessages5C { get => _documentationGuidelineMessages5C; set => _documentationGuidelineMessages5C = value; }
        private DirtyValue<string> _documentationGuidelineMessages8Y;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y) [AUSF.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (8Y)")]
        public string DocumentationGuidelineMessages8Y { get => _documentationGuidelineMessages8Y; set => _documentationGuidelineMessages8Y = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCN;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN) [AUSF.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CN)")]
        public string DocumentationGuidelineMessagesCN { get => _documentationGuidelineMessagesCN; set => _documentationGuidelineMessagesCN = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP) [AUSF.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CP)")]
        public string DocumentationGuidelineMessagesCP { get => _documentationGuidelineMessagesCP; set => _documentationGuidelineMessagesCP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCV;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV) [AUSF.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CV)")]
        public string DocumentationGuidelineMessagesCV { get => _documentationGuidelineMessagesCV; set => _documentationGuidelineMessagesCV = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCY;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY) [AUSF.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CY)")]
        public string DocumentationGuidelineMessagesCY { get => _documentationGuidelineMessagesCY; set => _documentationGuidelineMessagesCY = value; }
        private DirtyValue<string> _documentationGuidelineMessagesCZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ) [AUSF.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (CZ)")]
        public string DocumentationGuidelineMessagesCZ { get => _documentationGuidelineMessagesCZ; set => _documentationGuidelineMessagesCZ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesDP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP) [AUSF.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DP)")]
        public string DocumentationGuidelineMessagesDP { get => _documentationGuidelineMessagesDP; set => _documentationGuidelineMessagesDP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesDZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ) [AUSF.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (DZ)")]
        public string DocumentationGuidelineMessagesDZ { get => _documentationGuidelineMessagesDZ; set => _documentationGuidelineMessagesDZ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesE5;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5) [AUSF.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (E5)")]
        public string DocumentationGuidelineMessagesE5 { get => _documentationGuidelineMessagesE5; set => _documentationGuidelineMessagesE5 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesIM;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM) [AUSF.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IM)")]
        public string DocumentationGuidelineMessagesIM { get => _documentationGuidelineMessagesIM; set => _documentationGuidelineMessagesIM = value; }
        private DirtyValue<string> _documentationGuidelineMessagesIQ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ) [AUSF.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (IQ)")]
        public string DocumentationGuidelineMessagesIQ { get => _documentationGuidelineMessagesIQ; set => _documentationGuidelineMessagesIQ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesJF;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF) [AUSF.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (JF)")]
        public string DocumentationGuidelineMessagesJF { get => _documentationGuidelineMessagesJF; set => _documentationGuidelineMessagesJF = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQJ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ) [AUSF.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QJ)")]
        public string DocumentationGuidelineMessagesQJ { get => _documentationGuidelineMessagesQJ; set => _documentationGuidelineMessagesQJ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQN;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN) [AUSF.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QN)")]
        public string DocumentationGuidelineMessagesQN { get => _documentationGuidelineMessagesQN; set => _documentationGuidelineMessagesQN = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQQ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ) [AUSF.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QQ)")]
        public string DocumentationGuidelineMessagesQQ { get => _documentationGuidelineMessagesQQ; set => _documentationGuidelineMessagesQQ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesQS;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS) [AUSF.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (QS)")]
        public string DocumentationGuidelineMessagesQS { get => _documentationGuidelineMessagesQS; set => _documentationGuidelineMessagesQS = value; }
        private DirtyValue<string> _documentationGuidelineMessagesU7;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7) [AUSF.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (U7)")]
        public string DocumentationGuidelineMessagesU7 { get => _documentationGuidelineMessagesU7; set => _documentationGuidelineMessagesU7 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX1;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1) [AUSF.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X1)")]
        public string DocumentationGuidelineMessagesX1 { get => _documentationGuidelineMessagesX1; set => _documentationGuidelineMessagesX1 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX3;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3) [AUSF.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X3)")]
        public string DocumentationGuidelineMessagesX3 { get => _documentationGuidelineMessagesX3; set => _documentationGuidelineMessagesX3 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX5;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5) [AUSF.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X5)")]
        public string DocumentationGuidelineMessagesX5 { get => _documentationGuidelineMessagesX5; set => _documentationGuidelineMessagesX5 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesX7;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7) [AUSF.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (X7)")]
        public string DocumentationGuidelineMessagesX7 { get => _documentationGuidelineMessagesX7; set => _documentationGuidelineMessagesX7 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA) [AUSF.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XA)")]
        public string DocumentationGuidelineMessagesXA { get => _documentationGuidelineMessagesXA; set => _documentationGuidelineMessagesXA = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXM;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM) [AUSF.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XM)")]
        public string DocumentationGuidelineMessagesXM { get => _documentationGuidelineMessagesXM; set => _documentationGuidelineMessagesXM = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXP;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP) [AUSF.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XP)")]
        public string DocumentationGuidelineMessagesXP { get => _documentationGuidelineMessagesXP; set => _documentationGuidelineMessagesXP = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXR;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR) [AUSF.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XR)")]
        public string DocumentationGuidelineMessagesXR { get => _documentationGuidelineMessagesXR; set => _documentationGuidelineMessagesXR = value; }
        private DirtyValue<string> _documentationGuidelineMessagesXT;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT) [AUSF.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (XT)")]
        public string DocumentationGuidelineMessagesXT { get => _documentationGuidelineMessagesXT; set => _documentationGuidelineMessagesXT = value; }
        private DirtyValue<string> _documentationGuidelineMessagesY8;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8) [AUSF.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (Y8)")]
        public string DocumentationGuidelineMessagesY8 { get => _documentationGuidelineMessagesY8; set => _documentationGuidelineMessagesY8 = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYG;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG) [AUSF.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YG)")]
        public string DocumentationGuidelineMessagesYG { get => _documentationGuidelineMessagesYG; set => _documentationGuidelineMessagesYG = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYJ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ) [AUSF.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YJ)")]
        public string DocumentationGuidelineMessagesYJ { get => _documentationGuidelineMessagesYJ; set => _documentationGuidelineMessagesYJ = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYY;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY) [AUSF.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YY)")]
        public string DocumentationGuidelineMessagesYY { get => _documentationGuidelineMessagesYY; set => _documentationGuidelineMessagesYY = value; }
        private DirtyValue<string> _documentationGuidelineMessagesYZ;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ) [AUSF.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - DocumentationGuidelineMessages (YZ)")]
        public string DocumentationGuidelineMessagesYZ { get => _documentationGuidelineMessagesYZ; set => _documentationGuidelineMessagesYZ = value; }
        private DirtyValue<StringEnumValue<EligibleNonStandardToStandard>> _eligibleNonStandardToStandard;
        /// <summary>
        /// ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM [QM.X1]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM - Non-Stardard to Standard Refinance Eligibility - This Loan may or may not be eligible for the Non-Standard to Standard Refinance exception to ATR QM")]
        public StringEnumValue<EligibleNonStandardToStandard> EligibleNonStandardToStandard { get => _eligibleNonStandardToStandard; set => _eligibleNonStandardToStandard = value; }
        private DirtyValue<decimal?> _financeChargeFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees [QM.X126]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Finance Charge Fees")]
        public decimal? FinanceChargeFees { get => _financeChargeFees; set => _financeChargeFees = value; }
        private DirtyValue<int?> _firstChangeRecase;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast [QM.X7]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Change/Recast")]
        public int? FirstChangeRecase { get => _firstChangeRecase; set => _firstChangeRecase = value; }
        private DirtyValue<DateTime?> _firstPmtDateAfterRecast;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast [QM.X15]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - First Pmt Due Date after recast")]
        public DateTime? FirstPmtDateAfterRecast { get => _firstPmtDateAfterRecast; set => _firstPmtDateAfterRecast = value; }
        private DirtyValue<decimal?> _fullPaymentAfterInterestOnly;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast [QM.X12]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Interest Only Recast")]
        public decimal? FullPaymentAfterInterestOnly { get => _fullPaymentAfterInterestOnly; set => _fullPaymentAfterInterestOnly = value; }
        private DirtyValue<decimal?> _fullyARMPaymentAfterNegAm;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast [QM.X14]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Fully Amortized Monthly payment after Neg. Am Recast")]
        public decimal? FullyARMPaymentAfterNegAm { get => _fullyARMPaymentAfterNegAm; set => _fullyARMPaymentAfterNegAm = value; }
        private DirtyValue<decimal?> _fullyIndexRateHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Housing Ratio [QM.X115]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fully Index Rate Housing Ratio")]
        public decimal? FullyIndexRateHousingRatio { get => _fullyIndexRateHousingRatio; set => _fullyIndexRateHousingRatio = value; }
        private DirtyValue<decimal?> _fullyIndexRateMaxTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Max Total Payment [QM.X114]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fully Index Rate Max Total Payment")]
        public decimal? FullyIndexRateMaxTotalPayment { get => _fullyIndexRateMaxTotalPayment; set => _fullyIndexRateMaxTotalPayment = value; }
        private DirtyValue<decimal?> _fullyIndexRateMonthlyPayment;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Monthly Payment [QM.X373]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fully Index Rate Monthly Payment")]
        public decimal? FullyIndexRateMonthlyPayment { get => _fullyIndexRateMonthlyPayment; set => _fullyIndexRateMonthlyPayment = value; }
        private DirtyValue<decimal?> _fullyIndexRateTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Fully Index Rate Total Debt Ratio [QM.X116]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Fully Index Rate Total Debt Ratio")]
        public decimal? FullyIndexRateTotalDebtRatio { get => _fullyIndexRateTotalDebtRatio; set => _fullyIndexRateTotalDebtRatio = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Alimony [QM.X37]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Alimony")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAlimony { get => _generalATRStatusAlimony; set => _generalATRStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Assets [QM.X35]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Assets")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusAssets { get => _generalATRStatusAssets; set => _generalATRStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Child Support [QM.X38]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Child Support")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusChildSupport { get => _generalATRStatusChildSupport; set => _generalATRStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Covered Loan [QM.X29]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Covered Loan")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCoveredLoan { get => _generalATRStatusCoveredLoan; set => _generalATRStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Credit History [QM.X39]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Credit History")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusCreditHistory { get => _generalATRStatusCreditHistory; set => _generalATRStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations [QM.X36]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDebtObligations { get => _generalATRStatusDebtObligations; set => _generalATRStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio [QM.X27]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusDTI { get => _generalATRStatusDTI; set => _generalATRStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Employment [QM.X33]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Employment")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusEmployment { get => _generalATRStatusEmployment; set => _generalATRStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Income [QM.X34]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Income")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusIncome { get => _generalATRStatusIncome; set => _generalATRStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations [QM.X31]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusMtgRelatedObligations { get => _generalATRStatusMtgRelatedObligations; set => _generalATRStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility [QM.X26]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusOverall { get => _generalATRStatusOverall; set => _generalATRStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Residual Income [QM.X28]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Residual Income")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusResidualIncome { get => _generalATRStatusResidualIncome; set => _generalATRStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _generalATRStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan [QM.X30]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - General Ability-to-Repay - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> GeneralATRStatusSimultaneousLoan { get => _generalATRStatusSimultaneousLoan; set => _generalATRStatusSimultaneousLoan = value; }
        private DirtyValue<decimal?> _gSEAgencyQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold [QM.X83]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Calculated Threshold")]
        public decimal? GSEAgencyQMCalculatedThreshold { get => _gSEAgencyQMCalculatedThreshold; set => _gSEAgencyQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony [QM.X79]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAlimony { get => _gSEAgencyQMStatusAlimony; set => _gSEAgencyQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets [QM.X77]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusAssets { get => _gSEAgencyQMStatusAssets; set => _gSEAgencyQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment [QM.X66]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusBalloonPayment { get => _gSEAgencyQMStatusBalloonPayment; set => _gSEAgencyQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support [QM.X80]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusChildSupport { get => _gSEAgencyQMStatusChildSupport; set => _gSEAgencyQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan [QM.X71]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCoveredLoan { get => _gSEAgencyQMStatusCoveredLoan; set => _gSEAgencyQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History [QM.X81]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusCreditHistory { get => _gSEAgencyQMStatusCreditHistory; set => _gSEAgencyQMStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations [QM.X78]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDebtObligations { get => _gSEAgencyQMStatusDebtObligations; set => _gSEAgencyQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio [QM.X69]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusDTI { get => _gSEAgencyQMStatusDTI; set => _gSEAgencyQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment [QM.X75]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Employment")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusEmployment { get => _gSEAgencyQMStatusEmployment; set => _gSEAgencyQMStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income [QM.X76]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusIncome { get => _gSEAgencyQMStatusIncome; set => _gSEAgencyQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only [QM.X64]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusInterestOnly { get => _gSEAgencyQMStatusInterestOnly; set => _gSEAgencyQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term [QM.X63]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusLoanTerm { get => _gSEAgencyQMStatusLoanTerm; set => _gSEAgencyQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations [QM.X73]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusMtgRelatedObligations { get => _gSEAgencyQMStatusMtgRelatedObligations; set => _gSEAgencyQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization [QM.X65]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusNegativeAmortization { get => _gSEAgencyQMStatusNegativeAmortization; set => _gSEAgencyQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility [QM.X62]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusOverall { get => _gSEAgencyQMStatusOverall; set => _gSEAgencyQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit [QM.X68]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPointsFeesLimit { get => _gSEAgencyQMStatusPointsFeesLimit; set => _gSEAgencyQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty [QM.X67]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusPrepaymentPenalty { get => _gSEAgencyQMStatusPrepaymentPenalty; set => _gSEAgencyQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income [QM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusResidualIncome { get => _gSEAgencyQMStatusResidualIncome; set => _gSEAgencyQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility [QM.X82]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSafeHarborEligibility { get => _gSEAgencyQMStatusSafeHarborEligibility; set => _gSEAgencyQMStatusSafeHarborEligibility = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _gSEAgencyQMStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan [QM.X72]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - GSE/Agency Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> GSEAgencyQMStatusSimultaneousLoan { get => _gSEAgencyQMStatusSimultaneousLoan; set => _gSEAgencyQMStatusSimultaneousLoan = value; }
        private DirtyValue<bool?> _has30DayLatePayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months? [QM.X3]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Has the Consumer had more than one 30-day Late Mortgage Payment in the last 12 Months?")]
        public bool? Has30DayLatePayment { get => _has30DayLatePayment; set => _has30DayLatePayment = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ATRQMCommon Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _initialMaxTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Initial Max Total Payment [QM.X113]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Initial Max Total Payment")]
        public decimal? InitialMaxTotalPayment { get => _initialMaxTotalPayment; set => _initialMaxTotalPayment = value; }
        private DirtyValue<decimal?> _initialRateHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Housing Ratio [QM.X375]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Initial Rate Housing Ratio")]
        public decimal? InitialRateHousingRatio { get => _initialRateHousingRatio; set => _initialRateHousingRatio = value; }
        private DirtyValue<decimal?> _initialRateMonthlyPayment;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Monthly Payment [QM.X374]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Initial Rate Monthly Payment")]
        public decimal? InitialRateMonthlyPayment { get => _initialRateMonthlyPayment; set => _initialRateMonthlyPayment = value; }
        private DirtyValue<decimal?> _initialRateTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Initial Rate Total Debt Ratio [QM.X376]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Initial Rate Total Debt Ratio")]
        public decimal? InitialRateTotalDebtRatio { get => _initialRateTotalDebtRatio; set => _initialRateTotalDebtRatio = value; }
        private DirtyValue<int?> _interestOnlyMonths;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months [QM.X10]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Months")]
        public int? InterestOnlyMonths { get => _interestOnlyMonths; set => _interestOnlyMonths = value; }
        private DirtyValue<DateTime?> _interestOnlyRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date [QM.X11]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Interest Only Recast Date")]
        public DateTime? InterestOnlyRecastDate { get => _interestOnlyRecastDate; set => _interestOnlyRecastDate = value; }
        private DirtyValue<bool?> _isConsumerLiklyDefault;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount? [QM.X16]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Is the Consumer likely to Default at the Recast Payment Amount?")]
        public bool? IsConsumerLiklyDefault { get => _isConsumerLiklyDefault; set => _isConsumerLiklyDefault = value; }
        private DirtyValue<StringEnumValue<YesNoOrNA>> _isEligibleForSafeHarbor;
        /// <summary>
        /// ATR QM - Eligibility - Is Loan Eligible for Safe Harbor? [QM.X25]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Is Loan Eligible for Safe Harbor?")]
        public StringEnumValue<YesNoOrNA> IsEligibleForSafeHarbor { get => _isEligibleForSafeHarbor; set => _isEligibleForSafeHarbor = value; }
        private DirtyValue<bool?> _isEvaluatedAlimonyObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations [QM.X343]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Alimony Obligations")]
        public bool? IsEvaluatedAlimonyObligations { get => _isEvaluatedAlimonyObligations; set => _isEvaluatedAlimonyObligations = value; }
        private DirtyValue<bool?> _isEvaluatedChildSupportObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations [QM.X342]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Child Support Obligations")]
        public bool? IsEvaluatedChildSupportObligations { get => _isEvaluatedChildSupportObligations; set => _isEvaluatedChildSupportObligations = value; }
        private DirtyValue<bool?> _isEvaluatedCreditHistory;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History [QM.X347]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Credit History")]
        public bool? IsEvaluatedCreditHistory { get => _isEvaluatedCreditHistory; set => _isEvaluatedCreditHistory = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentEmploymentStatus;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status [QM.X344]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current Employment Status")]
        public bool? IsEvaluatedCurrentEmploymentStatus { get => _isEvaluatedCurrentEmploymentStatus; set => _isEvaluatedCurrentEmploymentStatus = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedAssets;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets [QM.X346]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Assets")]
        public bool? IsEvaluatedCurrentExpectedAssets { get => _isEvaluatedCurrentExpectedAssets; set => _isEvaluatedCurrentExpectedAssets = value; }
        private DirtyValue<bool?> _isEvaluatedCurrentExpectedIncome;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income [QM.X345]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Current or Expected Income")]
        public bool? IsEvaluatedCurrentExpectedIncome { get => _isEvaluatedCurrentExpectedIncome; set => _isEvaluatedCurrentExpectedIncome = value; }
        private DirtyValue<bool?> _isEvaluatedDebtObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations [QM.X341]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt Obligations")]
        public bool? IsEvaluatedDebtObligations { get => _isEvaluatedDebtObligations; set => _isEvaluatedDebtObligations = value; }
        private DirtyValue<bool?> _isEvaluatedDebtToIncomeRatio;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio [QM.X348]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Debt to Income Ratio")]
        public bool? IsEvaluatedDebtToIncomeRatio { get => _isEvaluatedDebtToIncomeRatio; set => _isEvaluatedDebtToIncomeRatio = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlyCoveredLoanPayment;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment [QM.X338]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Covered Loan Payment")]
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get => _isEvaluatedMonthlyCoveredLoanPayment; set => _isEvaluatedMonthlyCoveredLoanPayment = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlyMortgageRelatedObligations;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations [QM.X340]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Mortgage Related Obligations")]
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get => _isEvaluatedMonthlyMortgageRelatedObligations; set => _isEvaluatedMonthlyMortgageRelatedObligations = value; }
        private DirtyValue<bool?> _isEvaluatedMonthlySimultaneousLoanPayment;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment [QM.X339]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Monthly Simultaneous Loan Payment")]
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get => _isEvaluatedMonthlySimultaneousLoanPayment; set => _isEvaluatedMonthlySimultaneousLoanPayment = value; }
        private DirtyValue<bool?> _isEvaluatedResidualIncome;
        /// <summary>
        /// ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income [QM.X349]
        /// </summary>
        [LoanFieldProperty(Description = "ATR/QM Management - Eligibility - Underwriter Has Evaluated - Residual Income")]
        public bool? IsEvaluatedResidualIncome { get => _isEvaluatedResidualIncome; set => _isEvaluatedResidualIncome = value; }
        private DirtyValue<StringEnumValue<IsOrIsNot>> _isHigherPricedLoan;
        /// <summary>
        /// ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction [QM.X135]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - This Loan is a Higher-Priced Covered Transaction")]
        public StringEnumValue<IsOrIsNot> IsHigherPricedLoan { get => _isHigherPricedLoan; set => _isHigherPricedLoan = value; }
        private DirtyValue<string> _loanProcessingInformationCode24;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24 [AUSF.X63]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 24")]
        public string LoanProcessingInformationCode24 { get => _loanProcessingInformationCode24; set => _loanProcessingInformationCode24 = value; }
        private DirtyValue<string> _loanProcessingInformationCode31;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31 [AUSF.X64]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 31")]
        public string LoanProcessingInformationCode31 { get => _loanProcessingInformationCode31; set => _loanProcessingInformationCode31 = value; }
        private DirtyValue<string> _loanProcessingInformationCode32;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32 [AUSF.X65]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 32")]
        public string LoanProcessingInformationCode32 { get => _loanProcessingInformationCode32; set => _loanProcessingInformationCode32 = value; }
        private DirtyValue<string> _loanProcessingInformationCode33;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33 [AUSF.X66]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 33")]
        public string LoanProcessingInformationCode33 { get => _loanProcessingInformationCode33; set => _loanProcessingInformationCode33 = value; }
        private DirtyValue<string> _loanProcessingInformationCode97;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97 [AUSF.X67]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code 97")]
        public string LoanProcessingInformationCode97 { get => _loanProcessingInformationCode97; set => _loanProcessingInformationCode97 = value; }
        private DirtyValue<string> _loanProcessingInformationCodeJr;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR [AUSF.X68]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JR")]
        public string LoanProcessingInformationCodeJr { get => _loanProcessingInformationCodeJr; set => _loanProcessingInformationCodeJr = value; }
        private DirtyValue<string> _loanProcessingInformationCodeJt;
        /// <summary>
        /// AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT [AUSF.X69]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LPA - Loan Processing Information - Message Code JT")]
        public string LoanProcessingInformationCodeJt { get => _loanProcessingInformationCodeJt; set => _loanProcessingInformationCodeJt = value; }
        private DirtyValue<string> _loanProcessingInformationD4;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4) [AUSF.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (D4)")]
        public string LoanProcessingInformationD4 { get => _loanProcessingInformationD4; set => _loanProcessingInformationD4 = value; }
        private DirtyValue<string> _loanProcessingInformationGO;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO) [AUSF.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (GO)")]
        public string LoanProcessingInformationGO { get => _loanProcessingInformationGO; set => _loanProcessingInformationGO = value; }
        private DirtyValue<string> _loanProcessingInformationHA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA) [AUSF.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (HA)")]
        public string LoanProcessingInformationHA { get => _loanProcessingInformationHA; set => _loanProcessingInformationHA = value; }
        private DirtyValue<string> _loanProcessingInformationLE;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE) [AUSF.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LE)")]
        public string LoanProcessingInformationLE { get => _loanProcessingInformationLE; set => _loanProcessingInformationLE = value; }
        private DirtyValue<string> _loanProcessingInformationLF;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF) [AUSF.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (LF)")]
        public string LoanProcessingInformationLF { get => _loanProcessingInformationLF; set => _loanProcessingInformationLF = value; }
        private DirtyValue<string> _loanProcessingInformationMA;
        /// <summary>
        /// Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA) [AUSF.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Last Snapshot - AUS Tracking - Freddie Mac LPA - LoanProcessingInformation (MA)")]
        public string LoanProcessingInformationMA { get => _loanProcessingInformationMA; set => _loanProcessingInformationMA = value; }
        private DirtyValue<bool?> _loanProgram;
        /// <summary>
        /// ATR QM - Eligibility - Loan Program [QM.X106]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Loan Program")]
        public bool? LoanProgram { get => _loanProgram; set => _loanProgram = value; }
        private DirtyValue<StringEnumValue<LoanProgramDescription>> _loanProgramDescription;
        /// <summary>
        /// ATR QM - Eligibility - Loan Program Description [QM.X107]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Loan Program Description")]
        public StringEnumValue<LoanProgramDescription> LoanProgramDescription { get => _loanProgramDescription; set => _loanProgramDescription = value; }
        private DirtyValue<bool?> _loanRateFixedin5Years;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years? [QM.X17]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the Interest Rate fixed for at least 5 years?")]
        public bool? LoanRateFixedin5Years { get => _loanRateFixedin5Years; set => _loanRateFixedin5Years = value; }
        private DirtyValue<decimal?> _lOBrokerCompensationAmount;
        /// <summary>
        /// ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation [QM.X371]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees from 2010 Itemization - LO (Broker) Compensation")]
        public decimal? LOBrokerCompensationAmount { get => _lOBrokerCompensationAmount; set => _lOBrokerCompensationAmount = value; }
        private DirtyValue<decimal?> _max5YrsHousingRatio;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio [QM.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Housing Ratio")]
        public decimal? Max5YrsHousingRatio { get => _max5YrsHousingRatio; set => _max5YrsHousingRatio = value; }
        private DirtyValue<decimal?> _max5YrsPrincipleAndInterest;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max P &amp; I [QM.X337]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Max P & I")]
        public decimal? Max5YrsPrincipleAndInterest { get => _max5YrsPrincipleAndInterest; set => _max5YrsPrincipleAndInterest = value; }
        private DirtyValue<decimal?> _max5YrsTotalDebtRatio;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio [QM.X119]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Total Debt Ratio")]
        public decimal? Max5YrsTotalDebtRatio { get => _max5YrsTotalDebtRatio; set => _max5YrsTotalDebtRatio = value; }
        private DirtyValue<decimal?> _max5YrsTotalPayment;
        /// <summary>
        /// ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment [QM.X117]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Max Rate During First 5 Years - Max Total Payment")]
        public decimal? Max5YrsTotalPayment { get => _max5YrsTotalPayment; set => _max5YrsTotalPayment = value; }
        private DirtyValue<decimal?> _maxPrepaymentPenaltyFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty [QM.X130]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Max Prepayment Penalty")]
        public decimal? MaxPrepaymentPenaltyFees { get => _maxPrepaymentPenaltyFees; set => _maxPrepaymentPenaltyFees = value; }
        private DirtyValue<DateTime?> _negAmRecastDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date [QM.X13]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Existing Loan - Neg. Am Recast Date")]
        public DateTime? NegAmRecastDate { get => _negAmRecastDate; set => _negAmRecastDate = value; }
        private DirtyValue<bool?> _paymentDecreasedBy10Percent;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more? [QM.X18]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Monthly payment decrease by 10% or more?")]
        public bool? PaymentDecreasedBy10Percent { get => _paymentDecreasedBy10Percent; set => _paymentDecreasedBy10Percent = value; }
        private DirtyValue<bool?> _pointsFeesThresholdMet;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met? [QM.X21]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Points and Fees Threshold met?")]
        public bool? PointsFeesThresholdMet { get => _pointsFeesThresholdMet; set => _pointsFeesThresholdMet = value; }
        private DirtyValue<decimal?> _prepaymentPenaltyPayoffFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff [QM.X131]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Prepayment Penalty Payoff")]
        public decimal? PrepaymentPenaltyPayoffFees { get => _prepaymentPenaltyPayoffFees; set => _prepaymentPenaltyPayoffFees = value; }
        private DirtyValue<decimal?> _prepayPenaltyPercentage;
        /// <summary>
        /// ATR QM - Qualification - Prepay Penalty Percentage [QM.X112]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Prepay Penalty Percentage")]
        public decimal? PrepayPenaltyPercentage { get => _prepayPenaltyPercentage; set => _prepayPenaltyPercentage = value; }
        private DirtyValue<bool?> _preventConsumersDefault;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default? [QM.X22]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Is the New loan likely to prevent the Consumers default?")]
        public bool? PreventConsumersDefault { get => _preventConsumersDefault; set => _preventConsumersDefault = value; }
        private DirtyValue<bool?> _principalBalanceIncreased;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase? [QM.X6]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Will this refinance cause the Principal Balance to increase?")]
        public bool? PrincipalBalanceIncreased { get => _principalBalanceIncreased; set => _principalBalanceIncreased = value; }
        private DirtyValue<bool?> _principalHasDeferred;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments? [QM.X20]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Does the New Loan have deferred Principal payments?")]
        public bool? PrincipalHasDeferred { get => _principalHasDeferred; set => _principalHasDeferred = value; }
        private DirtyValue<StringEnumValue<QMLoanType>> _qMLoanType;
        /// <summary>
        /// ATR QM - Eligibility - Qualified Mortgage Loan Type [QM.X24]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Qualified Mortgage Loan Type")]
        public StringEnumValue<QMLoanType> QMLoanType { get => _qMLoanType; set => _qMLoanType = value; }
        private DirtyValue<decimal?> _rateReductionBasisPoints;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Basis Points % [QM.X365]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Rate Reduction Basis Points %")]
        public decimal? RateReductionBasisPoints { get => _rateReductionBasisPoints; set => _rateReductionBasisPoints = value; }
        private DirtyValue<decimal?> _rateReductionDiscountPoints;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Discount Points % [QM.X366]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Rate Reduction Discount Points %")]
        public decimal? RateReductionDiscountPoints { get => _rateReductionDiscountPoints; set => _rateReductionDiscountPoints = value; }
        private DirtyValue<decimal?> _rateReductionMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point % [QM.X367]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Rate Reduction Max Bona Fide Discount Point %")]
        public decimal? RateReductionMaxBonaFideDiscountPoint { get => _rateReductionMaxBonaFideDiscountPoint; set => _rateReductionMaxBonaFideDiscountPoint = value; }
        private DirtyValue<decimal?> _realEstateFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees [QM.X127]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Real Estate Related Fees")]
        public decimal? RealEstateFees { get => _realEstateFees; set => _realEstateFees = value; }
        private DirtyValue<decimal?> _recastDifferencePayment;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment [QM.X19]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - New Loan - Difference between recast monthly payment and new payment")]
        public decimal? RecastDifferencePayment { get => _recastDifferencePayment; set => _recastDifferencePayment = value; }
        private DirtyValue<decimal?> _regZTotalLoanAmount;
        /// <summary>
        /// ATR QM - Qualification - Reg-Z Total Loan Amount [QM.X120]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Reg-Z Total Loan Amount")]
        public decimal? RegZTotalLoanAmount { get => _regZTotalLoanAmount; set => _regZTotalLoanAmount = value; }
        private DirtyValue<decimal?> _requiredServicesLenderSelectedAmt;
        /// <summary>
        /// ATR QM - Qualification - Required Services - Lender Selected Amount [QM.X125]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Required Services - Lender Selected Amount")]
        public decimal? RequiredServicesLenderSelectedAmt { get => _requiredServicesLenderSelectedAmt; set => _requiredServicesLenderSelectedAmt = value; }
        private DirtyValue<decimal?> _smallCreditorQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold [QM.X102]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Calculated Threshold")]
        public decimal? SmallCreditorQMCalculatedThreshold { get => _smallCreditorQMCalculatedThreshold; set => _smallCreditorQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony [QM.X99]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAlimony { get => _smallCreditorQMStatusAlimony; set => _smallCreditorQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets [QM.X97]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusAssets { get => _smallCreditorQMStatusAssets; set => _smallCreditorQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment [QM.X88]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusBalloonPayment { get => _smallCreditorQMStatusBalloonPayment; set => _smallCreditorQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support [QM.X100]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusChildSupport { get => _smallCreditorQMStatusChildSupport; set => _smallCreditorQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan [QM.X93]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusCoveredLoan { get => _smallCreditorQMStatusCoveredLoan; set => _smallCreditorQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations [QM.X98]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDebtObligations { get => _smallCreditorQMStatusDebtObligations; set => _smallCreditorQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio [QM.X91]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusDTI { get => _smallCreditorQMStatusDTI; set => _smallCreditorQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income [QM.X96]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusIncome { get => _smallCreditorQMStatusIncome; set => _smallCreditorQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only [QM.X86]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusInterestOnly { get => _smallCreditorQMStatusInterestOnly; set => _smallCreditorQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term [QM.X85]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusLoanTerm { get => _smallCreditorQMStatusLoanTerm; set => _smallCreditorQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations [QM.X94]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusMtgRelatedObligations { get => _smallCreditorQMStatusMtgRelatedObligations; set => _smallCreditorQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization [QM.X87]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusNegativeAmortization { get => _smallCreditorQMStatusNegativeAmortization; set => _smallCreditorQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility [QM.X84]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusOverall { get => _smallCreditorQMStatusOverall; set => _smallCreditorQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit [QM.X90]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPointsFeesLimit { get => _smallCreditorQMStatusPointsFeesLimit; set => _smallCreditorQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty [QM.X89]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusPrepaymentPenalty { get => _smallCreditorQMStatusPrepaymentPenalty; set => _smallCreditorQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income [QM.X92]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusResidualIncome { get => _smallCreditorQMStatusResidualIncome; set => _smallCreditorQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _smallCreditorQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility [QM.X101]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> SmallCreditorQMStatusSafeHarborEligibility { get => _smallCreditorQMStatusSafeHarborEligibility; set => _smallCreditorQMStatusSafeHarborEligibility = value; }
        private DirtyValue<decimal?> _standardQMCalculatedThreshold;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold [QM.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Calculated Threshold")]
        public decimal? StandardQMCalculatedThreshold { get => _standardQMCalculatedThreshold; set => _standardQMCalculatedThreshold = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAlimony;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Alimony [QM.X57]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Alimony")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusAlimony { get => _standardQMStatusAlimony; set => _standardQMStatusAlimony = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusAssets;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Assets [QM.X55]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Assets")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusAssets { get => _standardQMStatusAssets; set => _standardQMStatusAssets = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusBalloonPayment;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment [QM.X44]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Balloon Payment")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusBalloonPayment { get => _standardQMStatusBalloonPayment; set => _standardQMStatusBalloonPayment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusChildSupport;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Child Support [QM.X58]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Child Support")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusChildSupport { get => _standardQMStatusChildSupport; set => _standardQMStatusChildSupport = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCoveredLoan;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan [QM.X49]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Covered Loan")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusCoveredLoan { get => _standardQMStatusCoveredLoan; set => _standardQMStatusCoveredLoan = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Credit History [QM.X59]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusCreditHistory { get => _standardQMStatusCreditHistory; set => _standardQMStatusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDebtObligations;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations [QM.X56]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Debt Obligations")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusDebtObligations { get => _standardQMStatusDebtObligations; set => _standardQMStatusDebtObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusDTI;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio [QM.X47]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Debt to Income Ratio")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusDTI { get => _standardQMStatusDTI; set => _standardQMStatusDTI = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusEmployment;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Employment [QM.X53]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Employment")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusEmployment { get => _standardQMStatusEmployment; set => _standardQMStatusEmployment = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusIncome;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Income [QM.X54]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Income")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusIncome { get => _standardQMStatusIncome; set => _standardQMStatusIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusInterestOnly;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only [QM.X42]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Interest Only")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusInterestOnly { get => _standardQMStatusInterestOnly; set => _standardQMStatusInterestOnly = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusLoanTerm;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term [QM.X41]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Loan Term")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusLoanTerm { get => _standardQMStatusLoanTerm; set => _standardQMStatusLoanTerm = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusMtgRelatedObligations;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations [QM.X51]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Mtg. Related Obligations")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusMtgRelatedObligations { get => _standardQMStatusMtgRelatedObligations; set => _standardQMStatusMtgRelatedObligations = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusNegativeAmortization;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization [QM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Negative Amortization")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusNegativeAmortization { get => _standardQMStatusNegativeAmortization; set => _standardQMStatusNegativeAmortization = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusOverall;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility [QM.X40]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Status of Eligibility")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusOverall { get => _standardQMStatusOverall; set => _standardQMStatusOverall = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPointsFeesLimit;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit [QM.X46]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Points and Fees Limit")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusPointsFeesLimit { get => _standardQMStatusPointsFeesLimit; set => _standardQMStatusPointsFeesLimit = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusPrepaymentPenalty;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty [QM.X45]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Prepayment Penalty")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusPrepaymentPenalty { get => _standardQMStatusPrepaymentPenalty; set => _standardQMStatusPrepaymentPenalty = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusResidualIncome;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income [QM.X48]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Residual Income")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusResidualIncome { get => _standardQMStatusResidualIncome; set => _standardQMStatusResidualIncome = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSafeHarborEligibility;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility [QM.X60]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Safe Harbor Eligibility")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusSafeHarborEligibility { get => _standardQMStatusSafeHarborEligibility; set => _standardQMStatusSafeHarborEligibility = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _standardQMStatusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan [QM.X50]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Standard Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> StandardQMStatusSimultaneousLoan { get => _standardQMStatusSimultaneousLoan; set => _standardQMStatusSimultaneousLoan = value; }
        private DirtyValue<decimal?> _startingAdjustedRateMaxBonaFideDiscountPoint;
        /// <summary>
        /// ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point % [QM.X368]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true, Description = "ATR QM - Qualification - Starting Adjusted Rate Max Bona Fide Discount Point %")]
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get => _startingAdjustedRateMaxBonaFideDiscountPoint; set => _startingAdjustedRateMaxBonaFideDiscountPoint = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusCreditHistory;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History [QM.X351]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Credit History")]
        public StringEnumValue<ATRQMStatus> StatusCreditHistory { get => _statusCreditHistory; set => _statusCreditHistory = value; }
        private DirtyValue<StringEnumValue<ATRQMStatus>> _statusSimultaneousLoan;
        /// <summary>
        /// ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan [QM.X350]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Small Creditor Qualified Mortgage - Simultaneous Loan")]
        public StringEnumValue<ATRQMStatus> StatusSimultaneousLoan { get => _statusSimultaneousLoan; set => _statusSimultaneousLoan = value; }
        private DirtyValue<StringEnumValue<DoesOrDoesNot2>> _thresholdExceedsQM;
        /// <summary>
        /// ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages [QM.X124]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Qualification - This Loan exceed the threshold for Qualified Mortgages")]
        public StringEnumValue<DoesOrDoesNot2> ThresholdExceedsQM { get => _thresholdExceedsQM; set => _thresholdExceedsQM = value; }
        private DirtyValue<decimal?> _titleServicesLenderTitleinsuranceFee;
        /// <summary>
        /// ATR QM - Qualification - Title Services and Lender's Title Ins [QM.X377]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Title Services and Lender's Title Ins")]
        public decimal? TitleServicesLenderTitleinsuranceFee { get => _titleServicesLenderTitleinsuranceFee; set => _titleServicesLenderTitleinsuranceFee = value; }
        private DirtyValue<decimal?> _totalCoMortgagorIncome;
        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income [QM.X153]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR/QM Management - Appendix Q - Income - Total Co-Mortgagor Income")]
        public decimal? TotalCoMortgagorIncome { get => _totalCoMortgagorIncome; set => _totalCoMortgagorIncome = value; }
        private DirtyValue<decimal?> _totalIncome;
        /// <summary>
        /// ATR/QM Management - Appendix Q - Income - Total Income [QM.X154]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR/QM Management - Appendix Q - Income - Total Income")]
        public decimal? TotalIncome { get => _totalIncome; set => _totalIncome = value; }
        private DirtyValue<decimal?> _totalPointsFeesSec32Percent;
        /// <summary>
        /// ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32 [QM.X123]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ATR QM - Qualification - Total Points and Fees Percentage Applicable Under Section 32")]
        public decimal? TotalPointsFeesSec32Percent { get => _totalPointsFeesSec32Percent; set => _totalPointsFeesSec32Percent = value; }
        private DirtyValue<bool?> _transactionExemptFromRegZ;
        /// <summary>
        /// ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements [QM.X103]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Transaction is exempt from Reg. Z Ability-to-Repay requirements")]
        public bool? TransactionExemptFromRegZ { get => _transactionExemptFromRegZ; set => _transactionExemptFromRegZ = value; }
        private DirtyValue<string> _ucdRequirement;
        /// <summary>
        /// AUS Tracking - Freddie Mac LCLA - UCD Requirement [AUSF.X70]
        /// </summary>
        [LoanFieldProperty(Description = "AUS Tracking - Freddie Mac LCLA - UCD Requirement")]
        public string UcdRequirement { get => _ucdRequirement; set => _ucdRequirement = value; }
        private DirtyValue<bool?> _unitCount;
        /// <summary>
        /// ATR QM - Eligibility - Unit Count [QM.X108]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Eligibility - Unit Count")]
        public bool? UnitCount { get => _unitCount; set => _unitCount = value; }
        private DirtyValue<decimal?> _upfrontPMIFees;
        /// <summary>
        /// ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI [QM.X129]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ATR QM - Qualification - Fees Included in Points and Fees Test - Upfront PMI")]
        public decimal? UpfrontPMIFees { get => _upfrontPMIFees; set => _upfrontPMIFees = value; }
        private DirtyValue<bool?> _withOriginalCreditor;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor  [QM.X2]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Refinance with Original Creditor ")]
        public bool? WithOriginalCreditor { get => _withOriginalCreditor; set => _withOriginalCreditor = value; }
        private DirtyValue<DateTime?> _writtenApplicationDate;
        /// <summary>
        /// ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date [QM.X5]
        /// </summary>
        [LoanFieldProperty(Description = "ATR QM - Non-Stardard to Standard Refinance Eligibility - Written Application Date")]
        public DateTime? WrittenApplicationDate { get => _writtenApplicationDate; set => _writtenApplicationDate = value; }
        internal override bool DirtyInternal
        {
            get => _affiliatesFees.Dirty
                || _aPORMaxBonaFideDiscountPoint.Dirty
                || _aRMRecastDate.Dirty
                || _aRMRecastMonthlyPayment.Dirty
                || _assetRepresentationAndWarrantyReliefEligibilityType.Dirty
                || _aTRLoanType.Dirty
                || _aUSDataDiscrepencyResolutionComments.Dirty
                || _aUSDataDiscrepencyResolutionDate.Dirty
                || _aUSDataDiscrepencyResolvedBy.Dirty
                || _bonaFideDiscountPoint.Dirty
                || _bonaFideDiscountPointAmount.Dirty
                || _brokerCompensationWhenRateSet.Dirty
                || _collateralRepandWarrReliefEligibilityType.Dirty
                || _compensationPTBFees.Dirty
                || _creditInsPremiumFees.Dirty
                || _creditorType.Dirty
                || _creditorTypeDescription.Dirty
                || _creditType.Dirty
                || _currentQMFeeThresholdAmt.Dirty
                || _currentQMFeeThresholdPercent.Dirty
                || _dateOfLastMonthlyPayment.Dirty
                || _discountPointAmount.Dirty
                || _discountPointFees.Dirty
                || _discountPointPercentage.Dirty
                || _documentationGuidelineMessages4V.Dirty
                || _documentationGuidelineMessages5C.Dirty
                || _documentationGuidelineMessages8Y.Dirty
                || _documentationGuidelineMessagesCN.Dirty
                || _documentationGuidelineMessagesCP.Dirty
                || _documentationGuidelineMessagesCV.Dirty
                || _documentationGuidelineMessagesCY.Dirty
                || _documentationGuidelineMessagesCZ.Dirty
                || _documentationGuidelineMessagesDP.Dirty
                || _documentationGuidelineMessagesDZ.Dirty
                || _documentationGuidelineMessagesE5.Dirty
                || _documentationGuidelineMessagesIM.Dirty
                || _documentationGuidelineMessagesIQ.Dirty
                || _documentationGuidelineMessagesJF.Dirty
                || _documentationGuidelineMessagesQJ.Dirty
                || _documentationGuidelineMessagesQN.Dirty
                || _documentationGuidelineMessagesQQ.Dirty
                || _documentationGuidelineMessagesQS.Dirty
                || _documentationGuidelineMessagesU7.Dirty
                || _documentationGuidelineMessagesX1.Dirty
                || _documentationGuidelineMessagesX3.Dirty
                || _documentationGuidelineMessagesX5.Dirty
                || _documentationGuidelineMessagesX7.Dirty
                || _documentationGuidelineMessagesXA.Dirty
                || _documentationGuidelineMessagesXM.Dirty
                || _documentationGuidelineMessagesXP.Dirty
                || _documentationGuidelineMessagesXR.Dirty
                || _documentationGuidelineMessagesXT.Dirty
                || _documentationGuidelineMessagesY8.Dirty
                || _documentationGuidelineMessagesYG.Dirty
                || _documentationGuidelineMessagesYJ.Dirty
                || _documentationGuidelineMessagesYY.Dirty
                || _documentationGuidelineMessagesYZ.Dirty
                || _eligibleNonStandardToStandard.Dirty
                || _financeChargeFees.Dirty
                || _firstChangeRecase.Dirty
                || _firstPmtDateAfterRecast.Dirty
                || _fullPaymentAfterInterestOnly.Dirty
                || _fullyARMPaymentAfterNegAm.Dirty
                || _fullyIndexRateHousingRatio.Dirty
                || _fullyIndexRateMaxTotalPayment.Dirty
                || _fullyIndexRateMonthlyPayment.Dirty
                || _fullyIndexRateTotalDebtRatio.Dirty
                || _generalATRStatusAlimony.Dirty
                || _generalATRStatusAssets.Dirty
                || _generalATRStatusChildSupport.Dirty
                || _generalATRStatusCoveredLoan.Dirty
                || _generalATRStatusCreditHistory.Dirty
                || _generalATRStatusDebtObligations.Dirty
                || _generalATRStatusDTI.Dirty
                || _generalATRStatusEmployment.Dirty
                || _generalATRStatusIncome.Dirty
                || _generalATRStatusMtgRelatedObligations.Dirty
                || _generalATRStatusOverall.Dirty
                || _generalATRStatusResidualIncome.Dirty
                || _generalATRStatusSimultaneousLoan.Dirty
                || _gSEAgencyQMCalculatedThreshold.Dirty
                || _gSEAgencyQMStatusAlimony.Dirty
                || _gSEAgencyQMStatusAssets.Dirty
                || _gSEAgencyQMStatusBalloonPayment.Dirty
                || _gSEAgencyQMStatusChildSupport.Dirty
                || _gSEAgencyQMStatusCoveredLoan.Dirty
                || _gSEAgencyQMStatusCreditHistory.Dirty
                || _gSEAgencyQMStatusDebtObligations.Dirty
                || _gSEAgencyQMStatusDTI.Dirty
                || _gSEAgencyQMStatusEmployment.Dirty
                || _gSEAgencyQMStatusIncome.Dirty
                || _gSEAgencyQMStatusInterestOnly.Dirty
                || _gSEAgencyQMStatusLoanTerm.Dirty
                || _gSEAgencyQMStatusMtgRelatedObligations.Dirty
                || _gSEAgencyQMStatusNegativeAmortization.Dirty
                || _gSEAgencyQMStatusOverall.Dirty
                || _gSEAgencyQMStatusPointsFeesLimit.Dirty
                || _gSEAgencyQMStatusPrepaymentPenalty.Dirty
                || _gSEAgencyQMStatusResidualIncome.Dirty
                || _gSEAgencyQMStatusSafeHarborEligibility.Dirty
                || _gSEAgencyQMStatusSimultaneousLoan.Dirty
                || _has30DayLatePayment.Dirty
                || _id.Dirty
                || _initialMaxTotalPayment.Dirty
                || _initialRateHousingRatio.Dirty
                || _initialRateMonthlyPayment.Dirty
                || _initialRateTotalDebtRatio.Dirty
                || _interestOnlyMonths.Dirty
                || _interestOnlyRecastDate.Dirty
                || _isConsumerLiklyDefault.Dirty
                || _isEligibleForSafeHarbor.Dirty
                || _isEvaluatedAlimonyObligations.Dirty
                || _isEvaluatedChildSupportObligations.Dirty
                || _isEvaluatedCreditHistory.Dirty
                || _isEvaluatedCurrentEmploymentStatus.Dirty
                || _isEvaluatedCurrentExpectedAssets.Dirty
                || _isEvaluatedCurrentExpectedIncome.Dirty
                || _isEvaluatedDebtObligations.Dirty
                || _isEvaluatedDebtToIncomeRatio.Dirty
                || _isEvaluatedMonthlyCoveredLoanPayment.Dirty
                || _isEvaluatedMonthlyMortgageRelatedObligations.Dirty
                || _isEvaluatedMonthlySimultaneousLoanPayment.Dirty
                || _isEvaluatedResidualIncome.Dirty
                || _isHigherPricedLoan.Dirty
                || _loanProcessingInformationCode24.Dirty
                || _loanProcessingInformationCode31.Dirty
                || _loanProcessingInformationCode32.Dirty
                || _loanProcessingInformationCode33.Dirty
                || _loanProcessingInformationCode97.Dirty
                || _loanProcessingInformationCodeJr.Dirty
                || _loanProcessingInformationCodeJt.Dirty
                || _loanProcessingInformationD4.Dirty
                || _loanProcessingInformationGO.Dirty
                || _loanProcessingInformationHA.Dirty
                || _loanProcessingInformationLE.Dirty
                || _loanProcessingInformationLF.Dirty
                || _loanProcessingInformationMA.Dirty
                || _loanProgram.Dirty
                || _loanProgramDescription.Dirty
                || _loanRateFixedin5Years.Dirty
                || _lOBrokerCompensationAmount.Dirty
                || _max5YrsHousingRatio.Dirty
                || _max5YrsPrincipleAndInterest.Dirty
                || _max5YrsTotalDebtRatio.Dirty
                || _max5YrsTotalPayment.Dirty
                || _maxPrepaymentPenaltyFees.Dirty
                || _negAmRecastDate.Dirty
                || _paymentDecreasedBy10Percent.Dirty
                || _pointsFeesThresholdMet.Dirty
                || _prepaymentPenaltyPayoffFees.Dirty
                || _prepayPenaltyPercentage.Dirty
                || _preventConsumersDefault.Dirty
                || _principalBalanceIncreased.Dirty
                || _principalHasDeferred.Dirty
                || _qMLoanType.Dirty
                || _rateReductionBasisPoints.Dirty
                || _rateReductionDiscountPoints.Dirty
                || _rateReductionMaxBonaFideDiscountPoint.Dirty
                || _realEstateFees.Dirty
                || _recastDifferencePayment.Dirty
                || _regZTotalLoanAmount.Dirty
                || _requiredServicesLenderSelectedAmt.Dirty
                || _smallCreditorQMCalculatedThreshold.Dirty
                || _smallCreditorQMStatusAlimony.Dirty
                || _smallCreditorQMStatusAssets.Dirty
                || _smallCreditorQMStatusBalloonPayment.Dirty
                || _smallCreditorQMStatusChildSupport.Dirty
                || _smallCreditorQMStatusCoveredLoan.Dirty
                || _smallCreditorQMStatusDebtObligations.Dirty
                || _smallCreditorQMStatusDTI.Dirty
                || _smallCreditorQMStatusIncome.Dirty
                || _smallCreditorQMStatusInterestOnly.Dirty
                || _smallCreditorQMStatusLoanTerm.Dirty
                || _smallCreditorQMStatusMtgRelatedObligations.Dirty
                || _smallCreditorQMStatusNegativeAmortization.Dirty
                || _smallCreditorQMStatusOverall.Dirty
                || _smallCreditorQMStatusPointsFeesLimit.Dirty
                || _smallCreditorQMStatusPrepaymentPenalty.Dirty
                || _smallCreditorQMStatusResidualIncome.Dirty
                || _smallCreditorQMStatusSafeHarborEligibility.Dirty
                || _standardQMCalculatedThreshold.Dirty
                || _standardQMStatusAlimony.Dirty
                || _standardQMStatusAssets.Dirty
                || _standardQMStatusBalloonPayment.Dirty
                || _standardQMStatusChildSupport.Dirty
                || _standardQMStatusCoveredLoan.Dirty
                || _standardQMStatusCreditHistory.Dirty
                || _standardQMStatusDebtObligations.Dirty
                || _standardQMStatusDTI.Dirty
                || _standardQMStatusEmployment.Dirty
                || _standardQMStatusIncome.Dirty
                || _standardQMStatusInterestOnly.Dirty
                || _standardQMStatusLoanTerm.Dirty
                || _standardQMStatusMtgRelatedObligations.Dirty
                || _standardQMStatusNegativeAmortization.Dirty
                || _standardQMStatusOverall.Dirty
                || _standardQMStatusPointsFeesLimit.Dirty
                || _standardQMStatusPrepaymentPenalty.Dirty
                || _standardQMStatusResidualIncome.Dirty
                || _standardQMStatusSafeHarborEligibility.Dirty
                || _standardQMStatusSimultaneousLoan.Dirty
                || _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty
                || _statusCreditHistory.Dirty
                || _statusSimultaneousLoan.Dirty
                || _thresholdExceedsQM.Dirty
                || _titleServicesLenderTitleinsuranceFee.Dirty
                || _totalCoMortgagorIncome.Dirty
                || _totalIncome.Dirty
                || _totalPointsFeesSec32Percent.Dirty
                || _transactionExemptFromRegZ.Dirty
                || _ucdRequirement.Dirty
                || _unitCount.Dirty
                || _upfrontPMIFees.Dirty
                || _withOriginalCreditor.Dirty
                || _writtenApplicationDate.Dirty;
            set
            {
                _affiliatesFees.Dirty = value;
                _aPORMaxBonaFideDiscountPoint.Dirty = value;
                _aRMRecastDate.Dirty = value;
                _aRMRecastMonthlyPayment.Dirty = value;
                _assetRepresentationAndWarrantyReliefEligibilityType.Dirty = value;
                _aTRLoanType.Dirty = value;
                _aUSDataDiscrepencyResolutionComments.Dirty = value;
                _aUSDataDiscrepencyResolutionDate.Dirty = value;
                _aUSDataDiscrepencyResolvedBy.Dirty = value;
                _bonaFideDiscountPoint.Dirty = value;
                _bonaFideDiscountPointAmount.Dirty = value;
                _brokerCompensationWhenRateSet.Dirty = value;
                _collateralRepandWarrReliefEligibilityType.Dirty = value;
                _compensationPTBFees.Dirty = value;
                _creditInsPremiumFees.Dirty = value;
                _creditorType.Dirty = value;
                _creditorTypeDescription.Dirty = value;
                _creditType.Dirty = value;
                _currentQMFeeThresholdAmt.Dirty = value;
                _currentQMFeeThresholdPercent.Dirty = value;
                _dateOfLastMonthlyPayment.Dirty = value;
                _discountPointAmount.Dirty = value;
                _discountPointFees.Dirty = value;
                _discountPointPercentage.Dirty = value;
                _documentationGuidelineMessages4V.Dirty = value;
                _documentationGuidelineMessages5C.Dirty = value;
                _documentationGuidelineMessages8Y.Dirty = value;
                _documentationGuidelineMessagesCN.Dirty = value;
                _documentationGuidelineMessagesCP.Dirty = value;
                _documentationGuidelineMessagesCV.Dirty = value;
                _documentationGuidelineMessagesCY.Dirty = value;
                _documentationGuidelineMessagesCZ.Dirty = value;
                _documentationGuidelineMessagesDP.Dirty = value;
                _documentationGuidelineMessagesDZ.Dirty = value;
                _documentationGuidelineMessagesE5.Dirty = value;
                _documentationGuidelineMessagesIM.Dirty = value;
                _documentationGuidelineMessagesIQ.Dirty = value;
                _documentationGuidelineMessagesJF.Dirty = value;
                _documentationGuidelineMessagesQJ.Dirty = value;
                _documentationGuidelineMessagesQN.Dirty = value;
                _documentationGuidelineMessagesQQ.Dirty = value;
                _documentationGuidelineMessagesQS.Dirty = value;
                _documentationGuidelineMessagesU7.Dirty = value;
                _documentationGuidelineMessagesX1.Dirty = value;
                _documentationGuidelineMessagesX3.Dirty = value;
                _documentationGuidelineMessagesX5.Dirty = value;
                _documentationGuidelineMessagesX7.Dirty = value;
                _documentationGuidelineMessagesXA.Dirty = value;
                _documentationGuidelineMessagesXM.Dirty = value;
                _documentationGuidelineMessagesXP.Dirty = value;
                _documentationGuidelineMessagesXR.Dirty = value;
                _documentationGuidelineMessagesXT.Dirty = value;
                _documentationGuidelineMessagesY8.Dirty = value;
                _documentationGuidelineMessagesYG.Dirty = value;
                _documentationGuidelineMessagesYJ.Dirty = value;
                _documentationGuidelineMessagesYY.Dirty = value;
                _documentationGuidelineMessagesYZ.Dirty = value;
                _eligibleNonStandardToStandard.Dirty = value;
                _financeChargeFees.Dirty = value;
                _firstChangeRecase.Dirty = value;
                _firstPmtDateAfterRecast.Dirty = value;
                _fullPaymentAfterInterestOnly.Dirty = value;
                _fullyARMPaymentAfterNegAm.Dirty = value;
                _fullyIndexRateHousingRatio.Dirty = value;
                _fullyIndexRateMaxTotalPayment.Dirty = value;
                _fullyIndexRateMonthlyPayment.Dirty = value;
                _fullyIndexRateTotalDebtRatio.Dirty = value;
                _generalATRStatusAlimony.Dirty = value;
                _generalATRStatusAssets.Dirty = value;
                _generalATRStatusChildSupport.Dirty = value;
                _generalATRStatusCoveredLoan.Dirty = value;
                _generalATRStatusCreditHistory.Dirty = value;
                _generalATRStatusDebtObligations.Dirty = value;
                _generalATRStatusDTI.Dirty = value;
                _generalATRStatusEmployment.Dirty = value;
                _generalATRStatusIncome.Dirty = value;
                _generalATRStatusMtgRelatedObligations.Dirty = value;
                _generalATRStatusOverall.Dirty = value;
                _generalATRStatusResidualIncome.Dirty = value;
                _generalATRStatusSimultaneousLoan.Dirty = value;
                _gSEAgencyQMCalculatedThreshold.Dirty = value;
                _gSEAgencyQMStatusAlimony.Dirty = value;
                _gSEAgencyQMStatusAssets.Dirty = value;
                _gSEAgencyQMStatusBalloonPayment.Dirty = value;
                _gSEAgencyQMStatusChildSupport.Dirty = value;
                _gSEAgencyQMStatusCoveredLoan.Dirty = value;
                _gSEAgencyQMStatusCreditHistory.Dirty = value;
                _gSEAgencyQMStatusDebtObligations.Dirty = value;
                _gSEAgencyQMStatusDTI.Dirty = value;
                _gSEAgencyQMStatusEmployment.Dirty = value;
                _gSEAgencyQMStatusIncome.Dirty = value;
                _gSEAgencyQMStatusInterestOnly.Dirty = value;
                _gSEAgencyQMStatusLoanTerm.Dirty = value;
                _gSEAgencyQMStatusMtgRelatedObligations.Dirty = value;
                _gSEAgencyQMStatusNegativeAmortization.Dirty = value;
                _gSEAgencyQMStatusOverall.Dirty = value;
                _gSEAgencyQMStatusPointsFeesLimit.Dirty = value;
                _gSEAgencyQMStatusPrepaymentPenalty.Dirty = value;
                _gSEAgencyQMStatusResidualIncome.Dirty = value;
                _gSEAgencyQMStatusSafeHarborEligibility.Dirty = value;
                _gSEAgencyQMStatusSimultaneousLoan.Dirty = value;
                _has30DayLatePayment.Dirty = value;
                _id.Dirty = value;
                _initialMaxTotalPayment.Dirty = value;
                _initialRateHousingRatio.Dirty = value;
                _initialRateMonthlyPayment.Dirty = value;
                _initialRateTotalDebtRatio.Dirty = value;
                _interestOnlyMonths.Dirty = value;
                _interestOnlyRecastDate.Dirty = value;
                _isConsumerLiklyDefault.Dirty = value;
                _isEligibleForSafeHarbor.Dirty = value;
                _isEvaluatedAlimonyObligations.Dirty = value;
                _isEvaluatedChildSupportObligations.Dirty = value;
                _isEvaluatedCreditHistory.Dirty = value;
                _isEvaluatedCurrentEmploymentStatus.Dirty = value;
                _isEvaluatedCurrentExpectedAssets.Dirty = value;
                _isEvaluatedCurrentExpectedIncome.Dirty = value;
                _isEvaluatedDebtObligations.Dirty = value;
                _isEvaluatedDebtToIncomeRatio.Dirty = value;
                _isEvaluatedMonthlyCoveredLoanPayment.Dirty = value;
                _isEvaluatedMonthlyMortgageRelatedObligations.Dirty = value;
                _isEvaluatedMonthlySimultaneousLoanPayment.Dirty = value;
                _isEvaluatedResidualIncome.Dirty = value;
                _isHigherPricedLoan.Dirty = value;
                _loanProcessingInformationCode24.Dirty = value;
                _loanProcessingInformationCode31.Dirty = value;
                _loanProcessingInformationCode32.Dirty = value;
                _loanProcessingInformationCode33.Dirty = value;
                _loanProcessingInformationCode97.Dirty = value;
                _loanProcessingInformationCodeJr.Dirty = value;
                _loanProcessingInformationCodeJt.Dirty = value;
                _loanProcessingInformationD4.Dirty = value;
                _loanProcessingInformationGO.Dirty = value;
                _loanProcessingInformationHA.Dirty = value;
                _loanProcessingInformationLE.Dirty = value;
                _loanProcessingInformationLF.Dirty = value;
                _loanProcessingInformationMA.Dirty = value;
                _loanProgram.Dirty = value;
                _loanProgramDescription.Dirty = value;
                _loanRateFixedin5Years.Dirty = value;
                _lOBrokerCompensationAmount.Dirty = value;
                _max5YrsHousingRatio.Dirty = value;
                _max5YrsPrincipleAndInterest.Dirty = value;
                _max5YrsTotalDebtRatio.Dirty = value;
                _max5YrsTotalPayment.Dirty = value;
                _maxPrepaymentPenaltyFees.Dirty = value;
                _negAmRecastDate.Dirty = value;
                _paymentDecreasedBy10Percent.Dirty = value;
                _pointsFeesThresholdMet.Dirty = value;
                _prepaymentPenaltyPayoffFees.Dirty = value;
                _prepayPenaltyPercentage.Dirty = value;
                _preventConsumersDefault.Dirty = value;
                _principalBalanceIncreased.Dirty = value;
                _principalHasDeferred.Dirty = value;
                _qMLoanType.Dirty = value;
                _rateReductionBasisPoints.Dirty = value;
                _rateReductionDiscountPoints.Dirty = value;
                _rateReductionMaxBonaFideDiscountPoint.Dirty = value;
                _realEstateFees.Dirty = value;
                _recastDifferencePayment.Dirty = value;
                _regZTotalLoanAmount.Dirty = value;
                _requiredServicesLenderSelectedAmt.Dirty = value;
                _smallCreditorQMCalculatedThreshold.Dirty = value;
                _smallCreditorQMStatusAlimony.Dirty = value;
                _smallCreditorQMStatusAssets.Dirty = value;
                _smallCreditorQMStatusBalloonPayment.Dirty = value;
                _smallCreditorQMStatusChildSupport.Dirty = value;
                _smallCreditorQMStatusCoveredLoan.Dirty = value;
                _smallCreditorQMStatusDebtObligations.Dirty = value;
                _smallCreditorQMStatusDTI.Dirty = value;
                _smallCreditorQMStatusIncome.Dirty = value;
                _smallCreditorQMStatusInterestOnly.Dirty = value;
                _smallCreditorQMStatusLoanTerm.Dirty = value;
                _smallCreditorQMStatusMtgRelatedObligations.Dirty = value;
                _smallCreditorQMStatusNegativeAmortization.Dirty = value;
                _smallCreditorQMStatusOverall.Dirty = value;
                _smallCreditorQMStatusPointsFeesLimit.Dirty = value;
                _smallCreditorQMStatusPrepaymentPenalty.Dirty = value;
                _smallCreditorQMStatusResidualIncome.Dirty = value;
                _smallCreditorQMStatusSafeHarborEligibility.Dirty = value;
                _standardQMCalculatedThreshold.Dirty = value;
                _standardQMStatusAlimony.Dirty = value;
                _standardQMStatusAssets.Dirty = value;
                _standardQMStatusBalloonPayment.Dirty = value;
                _standardQMStatusChildSupport.Dirty = value;
                _standardQMStatusCoveredLoan.Dirty = value;
                _standardQMStatusCreditHistory.Dirty = value;
                _standardQMStatusDebtObligations.Dirty = value;
                _standardQMStatusDTI.Dirty = value;
                _standardQMStatusEmployment.Dirty = value;
                _standardQMStatusIncome.Dirty = value;
                _standardQMStatusInterestOnly.Dirty = value;
                _standardQMStatusLoanTerm.Dirty = value;
                _standardQMStatusMtgRelatedObligations.Dirty = value;
                _standardQMStatusNegativeAmortization.Dirty = value;
                _standardQMStatusOverall.Dirty = value;
                _standardQMStatusPointsFeesLimit.Dirty = value;
                _standardQMStatusPrepaymentPenalty.Dirty = value;
                _standardQMStatusResidualIncome.Dirty = value;
                _standardQMStatusSafeHarborEligibility.Dirty = value;
                _standardQMStatusSimultaneousLoan.Dirty = value;
                _startingAdjustedRateMaxBonaFideDiscountPoint.Dirty = value;
                _statusCreditHistory.Dirty = value;
                _statusSimultaneousLoan.Dirty = value;
                _thresholdExceedsQM.Dirty = value;
                _titleServicesLenderTitleinsuranceFee.Dirty = value;
                _totalCoMortgagorIncome.Dirty = value;
                _totalIncome.Dirty = value;
                _totalPointsFeesSec32Percent.Dirty = value;
                _transactionExemptFromRegZ.Dirty = value;
                _ucdRequirement.Dirty = value;
                _unitCount.Dirty = value;
                _upfrontPMIFees.Dirty = value;
                _withOriginalCreditor.Dirty = value;
                _writtenApplicationDate.Dirty = value;
            }
        }
    }
}