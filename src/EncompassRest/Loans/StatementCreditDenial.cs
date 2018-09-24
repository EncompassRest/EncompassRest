using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// StatementCreditDenial
    /// </summary>
    public sealed partial class StatementCreditDenial : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _additionalStatement;
        private DirtyValue<bool?> _bankruptcy;
        private DirtyValue<bool?> _collateralNotSufficient;
        private DirtyValue<bool?> _creditApplicationIncomplete;
        private DirtyValue<bool?> _creditReportObtainedFromConsumerReportingAgency;
        private DirtyValue<bool?> _delinquentCreditObligations;
        private DirtyValue<DateTime?> _denialDate;
        private DirtyValue<string> _denialDescription;
        private DirtyValue<DateTime?> _denialMailedOn;
        private DirtyValue<bool?> _denialOther1;
        private DirtyValue<bool?> _denialOther2;
        private DirtyValue<string> _denialOtherDesc1;
        private DirtyValue<string> _denialOtherDesc2;
        private DirtyValue<string> _deniedBy;
        private DirtyValue<bool?> _deniedByFhlmc;
        private DirtyValue<bool?> _deniedByFnma;
        private DirtyValue<bool?> _deniedByHud;
        private DirtyValue<bool?> _deniedByOther;
        private DirtyValue<bool?> _deniedByVa;
        private DirtyValue<string> _descriptionofAccount1;
        private DirtyValue<string> _descriptionofAccount2;
        private DirtyValue<string> _descriptionofAccount3;
        private DirtyValue<string> _descriptionofActionTaken1;
        private DirtyValue<string> _descriptionofActionTaken2;
        private DirtyValue<string> _ecoaAddress;
        private DirtyValue<string> _ecoaAddress2;
        private DirtyValue<string> _ecoaCity;
        private DirtyValue<string> _ecoaName;
        private DirtyValue<string> _ecoaPhone;
        private DirtyValue<string> _ecoaPostalCode;
        private DirtyValue<StringEnumValue<State>> _ecoaState;
        private DirtyValue<bool?> _excessiveObligations;
        private DirtyValue<bool?> _garnishment;
        private DirtyValue<string> _id;
        private DirtyValue<bool?> _inadequateCollateral;
        private DirtyValue<bool?> _informationFromAConsumerReportingAgency;
        private DirtyValue<bool?> _informationObtainedFromOutsideSource;
        private DirtyValue<bool?> _informationObtainedInReportFromCra;
        private DirtyValue<bool?> _insufficientCreditFile;
        private DirtyValue<bool?> _insufficientCreditReference;
        private DirtyValue<bool?> _insufficientData;
        private DirtyValue<bool?> _insufficientFundsToCloseLoan;
        private DirtyValue<bool?> _insufficientIncomeForTotalObligations;
        private DirtyValue<bool?> _insufficientStabilityOfIncome;
        private DirtyValue<bool?> _lackOfCashReserves;
        private DirtyValue<string> _lenderInvestorAddress;
        private DirtyValue<string> _lenderInvestorCity;
        private DirtyValue<string> _lenderInvestorName;
        private DirtyValue<string> _lenderInvestorPhone;
        private DirtyValue<string> _lenderInvestorPostalCode;
        private DirtyValue<StringEnumValue<State>> _lenderInvestorState;
        private DirtyValue<bool?> _lengthOfEmployment;
        private DirtyValue<bool?> _noCreditFile;
        private DirtyValue<bool?> _numberRecentInquiriesCredit;
        private DirtyValue<string> _otherDescription;
        private DirtyValue<bool?> _poorCreditPerformance;
        private DirtyValue<bool?> _temporaryOrIrregularEmployment;
        private DirtyValue<bool?> _temporaryResidence;
        private DirtyValue<bool?> _toShortPeriodOfResidence;
        private DirtyValue<bool?> _unableToVerifyCreditReferences;
        private DirtyValue<bool?> _unableToVerifyEmployment;
        private DirtyValue<bool?> _unableToVerifyIncome;
        private DirtyValue<bool?> _unableToVerifyResidence;
        private DirtyValue<bool?> _unacceptableAppraisal;
        private DirtyValue<bool?> _unacceptableCreditReferencesProvided;
        private DirtyValue<bool?> _unacceptableLeaseholdEstate;
        private DirtyValue<bool?> _unacceptablePaymentRecordOnPreviousMtg;
        private DirtyValue<bool?> _unacceptableProperty;
        private DirtyValue<bool?> _weDoNotGrantCredit;
        private DirtyValue<bool?> _withdrawnByApplicant;

        /// <summary>
        /// Denial Discl Additional Stmt [DENIAL.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Additional Stmt", OptionsJson = "{\"true\":\"Additional Statement\"}")]
        public bool? AdditionalStatement { get => _additionalStatement; set => SetField(ref _additionalStatement, value); }

        /// <summary>
        /// Denial Credit - Bankruptcy [DENIAL.X40]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Bankruptcy", OptionsJson = "{\"true\":\"Bankruptcy\"}")]
        public bool? Bankruptcy { get => _bankruptcy; set => SetField(ref _bankruptcy, value); }

        /// <summary>
        /// Denial Credit - Value or Type of Collateral is Not Sufficient [DENIAL.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Value or Type of Collateral is Not Sufficient", OptionsJson = "{\"true\":\"Value or Type of Collateral is Not Sufficient\"}")]
        public bool? CollateralNotSufficient { get => _collateralNotSufficient; set => SetField(ref _collateralNotSufficient, value); }

        /// <summary>
        /// Denial Other - Credit Appl Incomplete [DENIAL.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Credit Appl Incomplete", OptionsJson = "{\"true\":\"Credit Application Incomplete\"}")]
        public bool? CreditApplicationIncomplete { get => _creditApplicationIncomplete; set => SetField(ref _creditApplicationIncomplete, value); }

        /// <summary>
        /// Denial Discl Info Obtained Your Credit Score from this Consumer Reporting Agency  [DENIAL.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info Obtained Your Credit Score from this Consumer Reporting Agency ")]
        public bool? CreditReportObtainedFromConsumerReportingAgency { get => _creditReportObtainedFromConsumerReportingAgency; set => SetField(ref _creditReportObtainedFromConsumerReportingAgency, value); }

        /// <summary>
        /// Denial Credit - Delinq Credit Oblig [DENIAL.X39]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Delinq Credit Oblig", OptionsJson = "{\"true\":\"Delinquent Credit Obligations\"}")]
        public bool? DelinquentCreditObligations { get => _delinquentCreditObligations; set => SetField(ref _delinquentCreditObligations, value); }

        /// <summary>
        /// Denial Date [DENIAL.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Date")]
        public DateTime? DenialDate { get => _denialDate; set => SetField(ref _denialDate, value); }

        /// <summary>
        /// Denial Discl Additional Stmt Detail [DENIAL.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Additional Stmt Detail")]
        public string DenialDescription { get => _denialDescription; set => SetField(ref _denialDescription, value); }

        /// <summary>
        /// Denial Mailed Date [DENIAL.X11]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Mailed Date")]
        public DateTime? DenialMailedOn { get => _denialMailedOn; set => SetField(ref _denialMailedOn, value); }

        /// <summary>
        /// Denial Other - Other 1 [DENIAL.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Other 1", OptionsJson = "{\"true\":\"-\"}")]
        public bool? DenialOther1 { get => _denialOther1; set => SetField(ref _denialOther1, value); }

        /// <summary>
        /// Denial Other - Other 2 [DENIAL.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Other 2", OptionsJson = "{\"true\":\"-\"}")]
        public bool? DenialOther2 { get => _denialOther2; set => SetField(ref _denialOther2, value); }

        /// <summary>
        /// Denial Other - Other 1 Descr [DENIAL.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Other 1 Descr")]
        public string DenialOtherDesc1 { get => _denialOtherDesc1; set => SetField(ref _denialOtherDesc1, value); }

        /// <summary>
        /// Denial Other - Other 2 Descr [DENIAL.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Other 2 Descr")]
        public string DenialOtherDesc2 { get => _denialOtherDesc2; set => SetField(ref _denialOtherDesc2, value); }

        /// <summary>
        /// Denied By [DENIAL.X70]
        /// </summary>
        [LoanFieldProperty(Description = "Denied By")]
        public string DeniedBy { get => _deniedBy; set => SetField(ref _deniedBy, value); }

        /// <summary>
        /// Denial - Denied By FHLMC [DENIAL.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By FHLMC", OptionsJson = "{\"true\":\"Federal Home Loan Mortgage Corporation\"}")]
        public bool? DeniedByFhlmc { get => _deniedByFhlmc; set => SetField(ref _deniedByFhlmc, value); }

        /// <summary>
        /// Denial - Denied By FNMA [DENIAL.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By FNMA", OptionsJson = "{\"true\":\"Federal National Mortgage Association\"}")]
        public bool? DeniedByFnma { get => _deniedByFnma; set => SetField(ref _deniedByFnma, value); }

        /// <summary>
        /// Denial - Denied By HUD [DENIAL.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By HUD", OptionsJson = "{\"true\":\"Department of Housing and Urban Dev\"}")]
        public bool? DeniedByHud { get => _deniedByHud; set => SetField(ref _deniedByHud, value); }

        /// <summary>
        /// Denial - Denied By Other [DENIAL.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By Other", OptionsJson = "{\"true\":\"-\"}")]
        public bool? DeniedByOther { get => _deniedByOther; set => SetField(ref _deniedByOther, value); }

        /// <summary>
        /// Denial - Denied By VA [DENIAL.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By VA", OptionsJson = "{\"true\":\"Department of Veterans Affairs\"}")]
        public bool? DeniedByVa { get => _deniedByVa; set => SetField(ref _deniedByVa, value); }

        /// <summary>
        /// Statement of Denial - Description of Account, Transaction or Request Credit Line 1 [DENIAL.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Statement of Denial - Description of Account, Transaction or Request Credit Line 1")]
        public string DescriptionofAccount1 { get => _descriptionofAccount1; set => SetField(ref _descriptionofAccount1, value); }

        /// <summary>
        /// Statement of Denial - Description of Account, Transaction or Request Credit Line 2 [DENIAL.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Statement of Denial - Description of Account, Transaction or Request Credit Line 2")]
        public string DescriptionofAccount2 { get => _descriptionofAccount2; set => SetField(ref _descriptionofAccount2, value); }

        /// <summary>
        /// Statement of Denial - Description of Account, Transaction or Request Credit Line 3 [DENIAL.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Statement of Denial - Description of Account, Transaction or Request Credit Line 3")]
        public string DescriptionofAccount3 { get => _descriptionofAccount3; set => SetField(ref _descriptionofAccount3, value); }

        /// <summary>
        /// Statement of Denial - Description of Action Taken Line 1 [DENIAL.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Statement of Denial - Description of Action Taken Line 1")]
        public string DescriptionofActionTaken1 { get => _descriptionofActionTaken1; set => SetField(ref _descriptionofActionTaken1, value); }

        /// <summary>
        /// Statement of Denial - Description of Action Taken Line 2 [DENIAL.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Statement of Denial - Description of Action Taken Line 2")]
        public string DescriptionofActionTaken2 { get => _descriptionofActionTaken2; set => SetField(ref _descriptionofActionTaken2, value); }

        /// <summary>
        /// Denial ECOA Addr [ECOA_ADDR]
        /// </summary>
        [LoanFieldProperty(Description = "Denial ECOA Addr")]
        public string EcoaAddress { get => _ecoaAddress; set => SetField(ref _ecoaAddress, value); }

        /// <summary>
        /// Denial ECOA Addr2 [ECOA_ADDR2]
        /// </summary>
        [LoanFieldProperty(Description = "Denial ECOA Addr2")]
        public string EcoaAddress2 { get => _ecoaAddress2; set => SetField(ref _ecoaAddress2, value); }

        /// <summary>
        /// Denial ECOA City [ECOA_CITY]
        /// </summary>
        [LoanFieldProperty(Description = "Denial ECOA City")]
        public string EcoaCity { get => _ecoaCity; set => SetField(ref _ecoaCity, value); }

        /// <summary>
        /// Denial ECOA Name [ECOA_NAME]
        /// </summary>
        [LoanFieldProperty(Description = "Denial ECOA Name")]
        public string EcoaName { get => _ecoaName; set => SetField(ref _ecoaName, value); }

        /// <summary>
        /// Denial ECOA Phone [ECOA_PHONE]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Denial ECOA Phone")]
        public string EcoaPhone { get => _ecoaPhone; set => SetField(ref _ecoaPhone, value); }

        /// <summary>
        /// Denial ECOA Zip [ECOA_ZIP]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Denial ECOA Zip")]
        public string EcoaPostalCode { get => _ecoaPostalCode; set => SetField(ref _ecoaPostalCode, value); }

        /// <summary>
        /// Denial ECOA State [ECOA_ST]
        /// </summary>
        [LoanFieldProperty(Description = "Denial ECOA State")]
        public StringEnumValue<State> EcoaState { get => _ecoaState; set => SetField(ref _ecoaState, value); }

        /// <summary>
        /// Denial Credit - Excessive Obligations [DENIAL.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Excessive Obligations", OptionsJson = "{\"true\":\"Excessive Obligations\"}")]
        public bool? ExcessiveObligations { get => _excessiveObligations; set => SetField(ref _excessiveObligations, value); }

        /// <summary>
        /// Denial Credit - Garnish, Attach, Foreclsr, Repo, Suit [DENIAL.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Garnish, Attach, Foreclsr, Repo, Suit", OptionsJson = "{\"true\":\"Garnishment, Attachment, Foreclosure,\"}")]
        public bool? Garnishment { get => _garnishment; set => SetField(ref _garnishment, value); }

        /// <summary>
        /// StatementCreditDenial Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Denial Other - Inadequate Collateral [DENIAL.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Inadequate Collateral", OptionsJson = "{\"true\":\"Inadequate Collateral\"}")]
        public bool? InadequateCollateral { get => _inadequateCollateral; set => SetField(ref _inadequateCollateral, value); }

        /// <summary>
        /// Denial Credit - Info from Credit Rpt Agency [DENIAL.X41]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Info from Credit Rpt Agency", OptionsJson = "{\"true\":\"Information from a Consumer Reporting\"}")]
        public bool? InformationFromAConsumerReportingAgency { get => _informationFromAConsumerReportingAgency; set => SetField(ref _informationFromAConsumerReportingAgency, value); }

        /// <summary>
        /// Denial Discl Info From Other Source [DENIAL.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info From Other Source", OptionsJson = "{\"true\":\"Information obtained from an outside source other than a consumer reporting agency. You have the right to\"}")]
        public bool? InformationObtainedFromOutsideSource { get => _informationObtainedFromOutsideSource; set => SetField(ref _informationObtainedFromOutsideSource, value); }

        /// <summary>
        /// Denial Discl Info Obtained from Credit Rpt Agency [DENIAL.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Discl Info Obtained from Credit Rpt Agency", OptionsJson = "{\"true\":\"Information obtained in a report from a consumer reporting agency:\"}")]
        public bool? InformationObtainedInReportFromCra { get => _informationObtainedInReportFromCra; set => SetField(ref _informationObtainedInReportFromCra, value); }

        /// <summary>
        /// Denial Credit - Insuff File [DENIAL.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Insuff File", OptionsJson = "{\"true\":\"Insufficient Credit File\"}")]
        public bool? InsufficientCreditFile { get => _insufficientCreditFile; set => SetField(ref _insufficientCreditFile, value); }

        /// <summary>
        /// Denial Credit - Insuff Reference [DENIAL.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Insuff Reference", OptionsJson = "{\"true\":\"Insufficient Credit Reference\"}")]
        public bool? InsufficientCreditReference { get => _insufficientCreditReference; set => SetField(ref _insufficientCreditReference, value); }

        /// <summary>
        /// Denial Other - Inadequate Collateral Insuff Prpty Info [DENIAL.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Inadequate Collateral Insuff Prpty Info", OptionsJson = "{\"true\":\"Insufficient Data - Property\"}")]
        public bool? InsufficientData { get => _insufficientData; set => SetField(ref _insufficientData, value); }

        /// <summary>
        /// Denial Other - Insuff Funds to Close [DENIAL.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Insuff Funds to Close", OptionsJson = "{\"true\":\"Insufficient Funds to Close the Loan\"}")]
        public bool? InsufficientFundsToCloseLoan { get => _insufficientFundsToCloseLoan; set => SetField(ref _insufficientFundsToCloseLoan, value); }

        /// <summary>
        /// Denial Credit - Excess Oblig/Insuff Income [DENIAL.X36]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Excess Oblig/Insuff Income", OptionsJson = "{\"true\":\"Insufficient Income for Total Obligations\"}")]
        public bool? InsufficientIncomeForTotalObligations { get => _insufficientIncomeForTotalObligations; set => SetField(ref _insufficientIncomeForTotalObligations, value); }

        /// <summary>
        /// Denial Income - Insuff [DENIAL.X45]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Income - Insuff", OptionsJson = "{\"true\":\"Insufficient Stability of Income\"}")]
        public bool? InsufficientStabilityOfIncome { get => _insufficientStabilityOfIncome; set => SetField(ref _insufficientStabilityOfIncome, value); }

        /// <summary>
        /// Denial Credit - Excess Oblig/Lack Cash Resrvs [DENIAL.X38]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Excess Oblig/Lack Cash Resrvs", OptionsJson = "{\"true\":\"Lack of Cash Reserves\"}")]
        public bool? LackOfCashReserves { get => _lackOfCashReserves; set => SetField(ref _lackOfCashReserves, value); }

        /// <summary>
        /// File Contacts Addr [DENIAL.X92]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Addr")]
        public string LenderInvestorAddress { get => _lenderInvestorAddress; set => SetField(ref _lenderInvestorAddress, value); }

        /// <summary>
        /// File Contacts City [DENIAL.X93]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts City")]
        public string LenderInvestorCity { get => _lenderInvestorCity; set => SetField(ref _lenderInvestorCity, value); }

        /// <summary>
        /// File Contacts Co Name [DENIAL.X91]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts Co Name")]
        public string LenderInvestorName { get => _lenderInvestorName; set => SetField(ref _lenderInvestorName, value); }

        /// <summary>
        /// File Contacts Phone [DENIAL.X96]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "File Contacts Phone")]
        public string LenderInvestorPhone { get => _lenderInvestorPhone; set => SetField(ref _lenderInvestorPhone, value); }

        /// <summary>
        /// File Contacts Zip [DENIAL.X95]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "File Contacts Zip")]
        public string LenderInvestorPostalCode { get => _lenderInvestorPostalCode; set => SetField(ref _lenderInvestorPostalCode, value); }

        /// <summary>
        /// File Contacts State [DENIAL.X94]
        /// </summary>
        [LoanFieldProperty(Description = "File Contacts State")]
        public StringEnumValue<State> LenderInvestorState { get => _lenderInvestorState; set => SetField(ref _lenderInvestorState, value); }

        /// <summary>
        /// Denial Empl Status - Length [DENIAL.X43]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Empl Status - Length", OptionsJson = "{\"true\":\"Length of Employment\"}")]
        public bool? LengthOfEmployment { get => _lengthOfEmployment; set => SetField(ref _lengthOfEmployment, value); }

        /// <summary>
        /// Denial Credit - No File [DENIAL.X30]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - No File", OptionsJson = "{\"true\":\"No Credit File\"}")]
        public bool? NoCreditFile { get => _noCreditFile; set => SetField(ref _noCreditFile, value); }

        /// <summary>
        /// Denial Credit - Number of Recent Inquiries on Credit Bureau Report [DENIAL.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Number of Recent Inquiries on Credit Bureau Report", OptionsJson = "{\"true\":\"Number of Recent Inquiries on Credit Bureau Report\"}")]
        public bool? NumberRecentInquiriesCredit { get => _numberRecentInquiriesCredit; set => SetField(ref _numberRecentInquiriesCredit, value); }

        /// <summary>
        /// Denial - Denied By Other Descr [DENIAL.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Denial - Denied By Other Descr")]
        public string OtherDescription { get => _otherDescription; set => SetField(ref _otherDescription, value); }

        /// <summary>
        /// Denial Credit - Poor Credit Performance With Us [DENIAL.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Poor Credit Performance With Us", OptionsJson = "{\"true\":\"Poor Credit Performance With Us\"}")]
        public bool? PoorCreditPerformance { get => _poorCreditPerformance; set => SetField(ref _poorCreditPerformance, value); }

        /// <summary>
        /// Denial Empl Status - Temp or Irregular [DENIAL.X44]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Empl Status - Temp or Irregular", OptionsJson = "{\"true\":\"Temporary or Irregular Employment,\"}")]
        public bool? TemporaryOrIrregularEmployment { get => _temporaryOrIrregularEmployment; set => SetField(ref _temporaryOrIrregularEmployment, value); }

        /// <summary>
        /// Denial Residency Temp [DENIAL.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Residency Temp", OptionsJson = "{\"true\":\"Temporary Residence\"}")]
        public bool? TemporaryResidence { get => _temporaryResidence; set => SetField(ref _temporaryResidence, value); }

        /// <summary>
        /// Denial Residency Too Short [DENIAL.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Residency Too Short", OptionsJson = "{\"true\":\"Too Short a Period of Residence\"}")]
        public bool? ToShortPeriodOfResidence { get => _toShortPeriodOfResidence; set => SetField(ref _toShortPeriodOfResidence, value); }

        /// <summary>
        /// Denial Credit - Unable to Verify Refs [DENIAL.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Unable to Verify Refs", OptionsJson = "{\"true\":\"Unable to Verify Credit References\"}")]
        public bool? UnableToVerifyCreditReferences { get => _unableToVerifyCreditReferences; set => SetField(ref _unableToVerifyCreditReferences, value); }

        /// <summary>
        /// Denial Empl Status - Unable to Verify [DENIAL.X42]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Empl Status - Unable to Verify", OptionsJson = "{\"true\":\"Unable to Verify Employment\"}")]
        public bool? UnableToVerifyEmployment { get => _unableToVerifyEmployment; set => SetField(ref _unableToVerifyEmployment, value); }

        /// <summary>
        /// Denial Income - Unable to Verify [DENIAL.X46]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Income - Unable to Verify", OptionsJson = "{\"true\":\"Unable to Verify Income\"}")]
        public bool? UnableToVerifyIncome { get => _unableToVerifyIncome; set => SetField(ref _unableToVerifyIncome, value); }

        /// <summary>
        /// Denial Residency Unable to Verify [DENIAL.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Residency Unable to Verify", OptionsJson = "{\"true\":\"Unable to Verify Residence\"}")]
        public bool? UnableToVerifyResidence { get => _unableToVerifyResidence; set => SetField(ref _unableToVerifyResidence, value); }

        /// <summary>
        /// Denial Other - Inadequate Collateral Apprais Unaccept [DENIAL.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Inadequate Collateral Apprais Unaccept", OptionsJson = "{\"true\":\"Unacceptable Appraisal\"}")]
        public bool? UnacceptableAppraisal { get => _unacceptableAppraisal; set => SetField(ref _unacceptableAppraisal, value); }

        /// <summary>
        /// Denial Credit - Unacceptable Type of Credit References Provided [DENIAL.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Unacceptable Type of Credit References Provided", OptionsJson = "{\"true\":\"Unacceptable Type of Credit References Provided\"}")]
        public bool? UnacceptableCreditReferencesProvided { get => _unacceptableCreditReferencesProvided; set => SetField(ref _unacceptableCreditReferencesProvided, value); }

        /// <summary>
        /// Denial Other - Inadequate Collateral Unaccept Leasehld [DENIAL.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Inadequate Collateral Unaccept Leasehld", OptionsJson = "{\"true\":\"Unacceptable Leasehold Estate\"}")]
        public bool? UnacceptableLeaseholdEstate { get => _unacceptableLeaseholdEstate; set => SetField(ref _unacceptableLeaseholdEstate, value); }

        /// <summary>
        /// Denial Credit - Excess Oblig/Unaccept Pymt Record [DENIAL.X37]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Credit - Excess Oblig/Unaccept Pymt Record", OptionsJson = "{\"true\":\"Unacceptable Payment Record on\"}")]
        public bool? UnacceptablePaymentRecordOnPreviousMtg { get => _unacceptablePaymentRecordOnPreviousMtg; set => SetField(ref _unacceptablePaymentRecordOnPreviousMtg, value); }

        /// <summary>
        /// Denial Other - Inadequate Collateral Prpty Unaccept [DENIAL.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Inadequate Collateral Prpty Unaccept", OptionsJson = "{\"true\":\"Unacceptable Property\"}")]
        public bool? UnacceptableProperty { get => _unacceptableProperty; set => SetField(ref _unacceptableProperty, value); }

        /// <summary>
        /// Denial Other - we do not grant credit to any appl on? [DENIAL.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - we do not grant credit to any appl on?", OptionsJson = "{\"true\":\"We do not grant credit to any applicant on...\"}")]
        public bool? WeDoNotGrantCredit { get => _weDoNotGrantCredit; set => SetField(ref _weDoNotGrantCredit, value); }

        /// <summary>
        /// Denial Other - Withdrawn by Applicant [DENIAL.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Denial Other - Withdrawn by Applicant", OptionsJson = "{\"true\":\"Withdrawn by Applicant\"}")]
        public bool? WithdrawnByApplicant { get => _withdrawnByApplicant; set => SetField(ref _withdrawnByApplicant, value); }
    }
}