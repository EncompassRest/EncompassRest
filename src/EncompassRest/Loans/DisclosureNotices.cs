using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// DisclosureNotices
    /// </summary>
    public sealed partial class DisclosureNotices : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<bool?> _antiCoercionStatementIndicator;
        /// <summary>
        /// Disclosure Anti-Coerc Stmnt [NOTICES.X16]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Anti-Coerc Stmnt", OptionsJson = "{\"true\":\"Anti-Coercion Statement\"}")]
        public bool? AntiCoercionStatementIndicator { get => _antiCoercionStatementIndicator; set => _antiCoercionStatementIndicator = value; }
        private DirtyValue<string> _commitmentIssuedByAddress;
        /// <summary>
        /// Disclosure Commit Issued By Addr [NOTICES.X33]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Addr")]
        public string CommitmentIssuedByAddress { get => _commitmentIssuedByAddress; set => _commitmentIssuedByAddress = value; }
        private DirtyValue<string> _commitmentIssuedByCity;
        /// <summary>
        /// Disclosure Commit Issued By City [NOTICES.X34]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By City")]
        public string CommitmentIssuedByCity { get => _commitmentIssuedByCity; set => _commitmentIssuedByCity = value; }
        private DirtyValue<string> _commitmentIssuedByContactName;
        /// <summary>
        /// Disclosure Commit Issued By Contact Name [NOTICES.X31]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Contact Name")]
        public string CommitmentIssuedByContactName { get => _commitmentIssuedByContactName; set => _commitmentIssuedByContactName = value; }
        private DirtyValue<string> _commitmentIssuedByName;
        /// <summary>
        /// Disclosure Commit Issued By Company [NOTICES.X32]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By Company")]
        public string CommitmentIssuedByName { get => _commitmentIssuedByName; set => _commitmentIssuedByName = value; }
        private DirtyValue<string> _commitmentIssuedByPhone;
        /// <summary>
        /// Disclosure Commit Issued By Phone [NOTICES.X37]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure Commit Issued By Phone")]
        public string CommitmentIssuedByPhone { get => _commitmentIssuedByPhone; set => _commitmentIssuedByPhone = value; }
        private DirtyValue<string> _commitmentIssuedByPostalCode;
        /// <summary>
        /// Disclosure Commit Issued By Zip [NOTICES.X36]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure Commit Issued By Zip")]
        public string CommitmentIssuedByPostalCode { get => _commitmentIssuedByPostalCode; set => _commitmentIssuedByPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _commitmentIssuedByState;
        /// <summary>
        /// Disclosure Commit Issued By State [NOTICES.X35]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Commit Issued By State")]
        public StringEnumValue<State> CommitmentIssuedByState { get => _commitmentIssuedByState; set => _commitmentIssuedByState = value; }
        private DirtyValue<StringEnumValue<YOrN>> _consumerHandbookOnAdjustableRateMortgages;
        /// <summary>
        /// Disclosure Consumer/ARM Handbook [NOTICES.X19]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Consumer/ARM Handbook", OptionsJson = "{\"Y\":\"Consumer Handbook on Adjustable Rate Mortgages\",\"N\":\"\"}")]
        public StringEnumValue<YOrN> ConsumerHandbookOnAdjustableRateMortgages { get => _consumerHandbookOnAdjustableRateMortgages; set => _consumerHandbookOnAdjustableRateMortgages = value; }
        private DirtyValue<string> _daysToReceiveWrittenRequest;
        /// <summary>
        /// Disclosure Appraisal Notice Days [NOTICES.X28]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Appraisal Notice Days")]
        public string DaysToReceiveWrittenRequest { get => _daysToReceiveWrittenRequest; set => _daysToReceiveWrittenRequest = value; }
        private DirtyValue<int?> _daysToReturnToLender;
        /// <summary>
        /// Disclosure Days to Return Lenders Copy [NOTICES.X47]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Days to Return Lenders Copy")]
        public int? DaysToReturnToLender { get => _daysToReturnToLender; set => _daysToReturnToLender = value; }
        private DirtyValue<string> _discloseNonPublicPersonalInformation;
        /// <summary>
        /// Disclosure Privacy Policy Options 1 [NOTICES.X38]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Privacy Policy Options 1")]
        public string DiscloseNonPublicPersonalInformation { get => _discloseNonPublicPersonalInformation; set => _discloseNonPublicPersonalInformation = value; }
        private DirtyValue<string> _ecoaAddress;
        /// <summary>
        /// Disclosure ECOA Addr [NOTICES.X3]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Addr")]
        public string EcoaAddress { get => _ecoaAddress; set => _ecoaAddress = value; }
        private DirtyValue<string> _ecoaAddress2;
        /// <summary>
        /// Disclosure ECOA Addr 2 [NOTICES.X4]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Addr 2")]
        public string EcoaAddress2 { get => _ecoaAddress2; set => _ecoaAddress2 = value; }
        private DirtyValue<string> _ecoaCity;
        /// <summary>
        /// Disclosure ECOA City [NOTICES.X5]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA City")]
        public string EcoaCity { get => _ecoaCity; set => _ecoaCity = value; }
        private DirtyValue<string> _ecoaName;
        /// <summary>
        /// Disclosure ECOA Name [NOTICES.X2]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA Name")]
        public string EcoaName { get => _ecoaName; set => _ecoaName = value; }
        private DirtyValue<string> _ecoaPhone;
        /// <summary>
        /// Disclosure ECOA Phone [NOTICES.X8]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Disclosure ECOA Phone")]
        public string EcoaPhone { get => _ecoaPhone; set => _ecoaPhone = value; }
        private DirtyValue<string> _ecoaPostalCode;
        /// <summary>
        /// Disclosure ECOA Zip [NOTICES.X7]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE, Description = "Disclosure ECOA Zip")]
        public string EcoaPostalCode { get => _ecoaPostalCode; set => _ecoaPostalCode = value; }
        private DirtyValue<StringEnumValue<State>> _ecoaState;
        /// <summary>
        /// Disclosure ECOA State [NOTICES.X6]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure ECOA State")]
        public StringEnumValue<State> EcoaState { get => _ecoaState; set => _ecoaState = value; }
        private DirtyValue<string> _fairLendingNoticeDescription1;
        /// <summary>
        /// Disclosure Fair Lending Contact 1 [NOTICES.X20]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 1")]
        public string FairLendingNoticeDescription1 { get => _fairLendingNoticeDescription1; set => _fairLendingNoticeDescription1 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription2;
        /// <summary>
        /// Disclosure Fair Lending Contact 2 [NOTICES.X21]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 2")]
        public string FairLendingNoticeDescription2 { get => _fairLendingNoticeDescription2; set => _fairLendingNoticeDescription2 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription3;
        /// <summary>
        /// Disclosure Fair Lending Contact 3 [NOTICES.X22]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 3")]
        public string FairLendingNoticeDescription3 { get => _fairLendingNoticeDescription3; set => _fairLendingNoticeDescription3 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription4;
        /// <summary>
        /// Disclosure Fair Lending Contact 4 [NOTICES.X23]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 4")]
        public string FairLendingNoticeDescription4 { get => _fairLendingNoticeDescription4; set => _fairLendingNoticeDescription4 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription5;
        /// <summary>
        /// Disclosure Fair Lending Contact 5 [NOTICES.X24]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 5")]
        public string FairLendingNoticeDescription5 { get => _fairLendingNoticeDescription5; set => _fairLendingNoticeDescription5 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription6;
        /// <summary>
        /// Disclosure Fair Lending Contact 6 [NOTICES.X25]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 6")]
        public string FairLendingNoticeDescription6 { get => _fairLendingNoticeDescription6; set => _fairLendingNoticeDescription6 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription7;
        /// <summary>
        /// Disclosure Fair Lending Contact 7 [NOTICES.X26]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 7")]
        public string FairLendingNoticeDescription7 { get => _fairLendingNoticeDescription7; set => _fairLendingNoticeDescription7 = value; }
        private DirtyValue<string> _fairLendingNoticeDescription8;
        /// <summary>
        /// Disclosure Fair Lending Contact 8 [NOTICES.X27]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Fair Lending Contact 8")]
        public string FairLendingNoticeDescription8 { get => _fairLendingNoticeDescription8; set => _fairLendingNoticeDescription8 = value; }
        private DirtyValue<string> _femaCommunityName;
        /// <summary>
        /// Disclosure Community Name for FEMA [NOTICES.X50]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Community Name for FEMA")]
        public string FemaCommunityName { get => _femaCommunityName; set => _femaCommunityName = value; }
        private DirtyValue<bool?> _floodInsuranceNotificationIndicator;
        /// <summary>
        /// Disclosure Flood Ins Notif [NOTICES.X17]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Flood Ins Notif", OptionsJson = "{\"true\":\"Flood Insurance Notification\"}")]
        public bool? FloodInsuranceNotificationIndicator { get => _floodInsuranceNotificationIndicator; set => _floodInsuranceNotificationIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// DisclosureNotices Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<bool?> _informationDisclosureAuthorizationIndicator;
        /// <summary>
        /// Disclosure Info Discl Auth [NOTICES.X10]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Info Discl Auth", OptionsJson = "{\"true\":\"Information Disclosure Authorization\"}")]
        public bool? InformationDisclosureAuthorizationIndicator { get => _informationDisclosureAuthorizationIndicator; set => _informationDisclosureAuthorizationIndicator = value; }
        private DirtyValue<string> _licensedMortgageBrokerUnder;
        /// <summary>
        /// Disclosure Mtg Broker License Auth [NOTICES.X29]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Mtg Broker License Auth")]
        public string LicensedMortgageBrokerUnder { get => _licensedMortgageBrokerUnder; set => _licensedMortgageBrokerUnder = value; }
        private DirtyValue<bool?> _locatedInNfipIndicator;
        /// <summary>
        /// Property Community participates in NFIP [NOTICES.X48]
        /// </summary>
        [LoanFieldProperty(Description = "Property Community participates in NFIP", OptionsJson = "{\"true\":\"Community in which the property is located participates in the National Flood Insurance program (NFIP). Federal law will not allow us to make the loan that you have applied for if you do not purchase flood insurance.\"}")]
        public bool? LocatedInNfipIndicator { get => _locatedInNfipIndicator; set => _locatedInNfipIndicator = value; }
        private DirtyValue<string> _lossPayeeClause;
        /// <summary>
        /// Disclosure Flood Ins Clause [NOTICES.X18]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Flood Ins Clause")]
        public string LossPayeeClause { get => _lossPayeeClause; set => _lossPayeeClause = value; }
        private DirtyValue<string> _mapPanelNumber;
        /// <summary>
        /// Disclosure Map Panel Number [NOTICES.X97]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Map Panel Number")]
        public string MapPanelNumber { get => _mapPanelNumber; set => _mapPanelNumber = value; }
        private DirtyValue<string> _nFIPCommunityNumber;
        /// <summary>
        /// Disclosure NFIP Community Number [NOTICES.X95]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Community Number")]
        public string NFIPCommunityNumber { get => _nFIPCommunityNumber; set => _nFIPCommunityNumber = value; }
        private DirtyValue<DateTime?> _nFIPMapEffectiveRevisedDate;
        /// <summary>
        /// Disclosure NFIP Map Panel Effective/Revised Date [NOTICES.X96]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Map Panel Effective/Revised Date")]
        public DateTime? NFIPMapEffectiveRevisedDate { get => _nFIPMapEffectiveRevisedDate; set => _nFIPMapEffectiveRevisedDate = value; }
        private DirtyValue<string> _nFIPParticipationStatus;
        /// <summary>
        /// Disclosure NFIP Participation Status Type [NOTICES.X100]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure NFIP Participation Status Type")]
        public string NFIPParticipationStatus { get => _nFIPParticipationStatus; set => _nFIPParticipationStatus = value; }
        private DirtyValue<string> _nonFinancialCompaniesDescription1;
        /// <summary>
        /// Disclosure Non-Finance Company 1 Desc [NOTICES.X40]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 1 Desc")]
        public string NonFinancialCompaniesDescription1 { get => _nonFinancialCompaniesDescription1; set => _nonFinancialCompaniesDescription1 = value; }
        private DirtyValue<string> _nonFinancialCompaniesDescription2;
        /// <summary>
        /// Disclosure Non-Finance Company 2 Desc [NOTICES.X41]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 2 Desc")]
        public string NonFinancialCompaniesDescription2 { get => _nonFinancialCompaniesDescription2; set => _nonFinancialCompaniesDescription2 = value; }
        private DirtyValue<string> _nonFinancialCompaniesDescription3;
        /// <summary>
        /// Disclosure Non-Finance Company 3 Desc [NOTICES.X42]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 3 Desc")]
        public string NonFinancialCompaniesDescription3 { get => _nonFinancialCompaniesDescription3; set => _nonFinancialCompaniesDescription3 = value; }
        private DirtyValue<string> _nonFinancialCompaniesDescription4;
        /// <summary>
        /// Disclosure Non-Finance Company 4 Desc [NOTICES.X43]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Non-Finance Company 4 Desc")]
        public string NonFinancialCompaniesDescription4 { get => _nonFinancialCompaniesDescription4; set => _nonFinancialCompaniesDescription4 = value; }
        private DirtyValue<bool?> _notLocatedInNfipIndicator;
        /// <summary>
        /// Property Community does not participates in NFIP [NOTICES.X49]
        /// </summary>
        [LoanFieldProperty(Description = "Property Community does not participates in NFIP", OptionsJson = "{\"true\":\"Flood insurance coverage is not available for the property securing the loan because the community in which the property is located does not participate in NFIP.\"}")]
        public bool? NotLocatedInNfipIndicator { get => _notLocatedInNfipIndicator; set => _notLocatedInNfipIndicator = value; }
        private DirtyValue<bool?> _occupancyStatementIndicator;
        /// <summary>
        /// Disclosure Occupancy Stmnt [NOTICES.X1]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Occupancy Stmnt", OptionsJson = "{\"true\":\"Occupancy Statement\"}")]
        public bool? OccupancyStatementIndicator { get => _occupancyStatementIndicator; set => _occupancyStatementIndicator = value; }
        private DirtyValue<string> _optOut;
        /// <summary>
        /// Disclosure Privacy Policy Options 2 [NOTICES.X45]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Disclosure Privacy Policy Options 2")]
        public string OptOut { get => _optOut; set => _optOut = value; }
        private DirtyValue<string> _optOutPhone;
        /// <summary>
        /// Disclosure Opt-Out Phone Number [NOTICES.X44]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true, Description = "Disclosure Opt-Out Phone Number")]
        public string OptOutPhone { get => _optOutPhone; set => _optOutPhone = value; }
        private DirtyValue<bool?> _releaseBankingInformationIndicator;
        /// <summary>
        /// Disclosure Auth Bank Acct Verif [NOTICES.X13]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Bank Acct Verif", OptionsJson = "{\"true\":\"Banking (checking & savings) account of record\"}")]
        public bool? ReleaseBankingInformationIndicator { get => _releaseBankingInformationIndicator; set => _releaseBankingInformationIndicator = value; }
        private DirtyValue<bool?> _releaseEmploymentInformationIndicator;
        /// <summary>
        /// Disclosure Auth Empl Hist Verif [NOTICES.X12]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Empl Hist Verif", OptionsJson = "{\"true\":\"Employment History, dates, title(s), income, hours worked, etc.\"}")]
        public bool? ReleaseEmploymentInformationIndicator { get => _releaseEmploymentInformationIndicator; set => _releaseEmploymentInformationIndicator = value; }
        private DirtyValue<bool?> _releaseInformationInConnectionWithCreditReportIndicator;
        /// <summary>
        /// Disclosure Auth Any Info Necessary [NOTICES.X15]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Any Info Necessary", OptionsJson = "{\"true\":\"Any information deemed necessary in connection with consumer credit report for real estate transaction\"}")]
        public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get => _releaseInformationInConnectionWithCreditReportIndicator; set => _releaseInformationInConnectionWithCreditReportIndicator = value; }
        private DirtyValue<bool?> _releaseMortgageInformationIndicator;
        /// <summary>
        /// Disclosure Auth Loan Rating Verif [NOTICES.X14]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Auth Loan Rating Verif", OptionsJson = "{\"true\":\"Mortgage loan rating, (opening date, high credit, payment amount, loan balance and payment)\"}")]
        public bool? ReleaseMortgageInformationIndicator { get => _releaseMortgageInformationIndicator; set => _releaseMortgageInformationIndicator = value; }
        private DirtyValue<bool?> _rightToFinancialPrivacyActIndicator;
        /// <summary>
        /// Disclosure Right to Privacy Act [NOTICES.X9]
        /// </summary>
        [LoanFieldProperty(Description = "Disclosure Right to Privacy Act", OptionsJson = "{\"true\":\"Right to Financial Privacy Act\"}")]
        public bool? RightToFinancialPrivacyActIndicator { get => _rightToFinancialPrivacyActIndicator; set => _rightToFinancialPrivacyActIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _antiCoercionStatementIndicator.Dirty
                || _commitmentIssuedByAddress.Dirty
                || _commitmentIssuedByCity.Dirty
                || _commitmentIssuedByContactName.Dirty
                || _commitmentIssuedByName.Dirty
                || _commitmentIssuedByPhone.Dirty
                || _commitmentIssuedByPostalCode.Dirty
                || _commitmentIssuedByState.Dirty
                || _consumerHandbookOnAdjustableRateMortgages.Dirty
                || _daysToReceiveWrittenRequest.Dirty
                || _daysToReturnToLender.Dirty
                || _discloseNonPublicPersonalInformation.Dirty
                || _ecoaAddress.Dirty
                || _ecoaAddress2.Dirty
                || _ecoaCity.Dirty
                || _ecoaName.Dirty
                || _ecoaPhone.Dirty
                || _ecoaPostalCode.Dirty
                || _ecoaState.Dirty
                || _fairLendingNoticeDescription1.Dirty
                || _fairLendingNoticeDescription2.Dirty
                || _fairLendingNoticeDescription3.Dirty
                || _fairLendingNoticeDescription4.Dirty
                || _fairLendingNoticeDescription5.Dirty
                || _fairLendingNoticeDescription6.Dirty
                || _fairLendingNoticeDescription7.Dirty
                || _fairLendingNoticeDescription8.Dirty
                || _femaCommunityName.Dirty
                || _floodInsuranceNotificationIndicator.Dirty
                || _id.Dirty
                || _informationDisclosureAuthorizationIndicator.Dirty
                || _licensedMortgageBrokerUnder.Dirty
                || _locatedInNfipIndicator.Dirty
                || _lossPayeeClause.Dirty
                || _mapPanelNumber.Dirty
                || _nFIPCommunityNumber.Dirty
                || _nFIPMapEffectiveRevisedDate.Dirty
                || _nFIPParticipationStatus.Dirty
                || _nonFinancialCompaniesDescription1.Dirty
                || _nonFinancialCompaniesDescription2.Dirty
                || _nonFinancialCompaniesDescription3.Dirty
                || _nonFinancialCompaniesDescription4.Dirty
                || _notLocatedInNfipIndicator.Dirty
                || _occupancyStatementIndicator.Dirty
                || _optOut.Dirty
                || _optOutPhone.Dirty
                || _releaseBankingInformationIndicator.Dirty
                || _releaseEmploymentInformationIndicator.Dirty
                || _releaseInformationInConnectionWithCreditReportIndicator.Dirty
                || _releaseMortgageInformationIndicator.Dirty
                || _rightToFinancialPrivacyActIndicator.Dirty;
            set
            {
                _antiCoercionStatementIndicator.Dirty = value;
                _commitmentIssuedByAddress.Dirty = value;
                _commitmentIssuedByCity.Dirty = value;
                _commitmentIssuedByContactName.Dirty = value;
                _commitmentIssuedByName.Dirty = value;
                _commitmentIssuedByPhone.Dirty = value;
                _commitmentIssuedByPostalCode.Dirty = value;
                _commitmentIssuedByState.Dirty = value;
                _consumerHandbookOnAdjustableRateMortgages.Dirty = value;
                _daysToReceiveWrittenRequest.Dirty = value;
                _daysToReturnToLender.Dirty = value;
                _discloseNonPublicPersonalInformation.Dirty = value;
                _ecoaAddress.Dirty = value;
                _ecoaAddress2.Dirty = value;
                _ecoaCity.Dirty = value;
                _ecoaName.Dirty = value;
                _ecoaPhone.Dirty = value;
                _ecoaPostalCode.Dirty = value;
                _ecoaState.Dirty = value;
                _fairLendingNoticeDescription1.Dirty = value;
                _fairLendingNoticeDescription2.Dirty = value;
                _fairLendingNoticeDescription3.Dirty = value;
                _fairLendingNoticeDescription4.Dirty = value;
                _fairLendingNoticeDescription5.Dirty = value;
                _fairLendingNoticeDescription6.Dirty = value;
                _fairLendingNoticeDescription7.Dirty = value;
                _fairLendingNoticeDescription8.Dirty = value;
                _femaCommunityName.Dirty = value;
                _floodInsuranceNotificationIndicator.Dirty = value;
                _id.Dirty = value;
                _informationDisclosureAuthorizationIndicator.Dirty = value;
                _licensedMortgageBrokerUnder.Dirty = value;
                _locatedInNfipIndicator.Dirty = value;
                _lossPayeeClause.Dirty = value;
                _mapPanelNumber.Dirty = value;
                _nFIPCommunityNumber.Dirty = value;
                _nFIPMapEffectiveRevisedDate.Dirty = value;
                _nFIPParticipationStatus.Dirty = value;
                _nonFinancialCompaniesDescription1.Dirty = value;
                _nonFinancialCompaniesDescription2.Dirty = value;
                _nonFinancialCompaniesDescription3.Dirty = value;
                _nonFinancialCompaniesDescription4.Dirty = value;
                _notLocatedInNfipIndicator.Dirty = value;
                _occupancyStatementIndicator.Dirty = value;
                _optOut.Dirty = value;
                _optOutPhone.Dirty = value;
                _releaseBankingInformationIndicator.Dirty = value;
                _releaseEmploymentInformationIndicator.Dirty = value;
                _releaseInformationInConnectionWithCreditReportIndicator.Dirty = value;
                _releaseMortgageInformationIndicator.Dirty = value;
                _rightToFinancialPrivacyActIndicator.Dirty = value;
            }
        }
    }
}