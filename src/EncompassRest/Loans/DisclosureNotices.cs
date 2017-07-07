using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureNotices : IClean
    {
        private Value<bool?> _antiCoercionStatementIndicator;
        public bool? AntiCoercionStatementIndicator { get { return _antiCoercionStatementIndicator; } set { _antiCoercionStatementIndicator = value; } }
        private Value<string> _commitmentIssuedByAddress;
        public string CommitmentIssuedByAddress { get { return _commitmentIssuedByAddress; } set { _commitmentIssuedByAddress = value; } }
        private Value<string> _commitmentIssuedByCity;
        public string CommitmentIssuedByCity { get { return _commitmentIssuedByCity; } set { _commitmentIssuedByCity = value; } }
        private Value<string> _commitmentIssuedByContactName;
        public string CommitmentIssuedByContactName { get { return _commitmentIssuedByContactName; } set { _commitmentIssuedByContactName = value; } }
        private Value<string> _commitmentIssuedByName;
        public string CommitmentIssuedByName { get { return _commitmentIssuedByName; } set { _commitmentIssuedByName = value; } }
        private Value<string> _commitmentIssuedByPhone;
        public string CommitmentIssuedByPhone { get { return _commitmentIssuedByPhone; } set { _commitmentIssuedByPhone = value; } }
        private Value<string> _commitmentIssuedByPostalCode;
        public string CommitmentIssuedByPostalCode { get { return _commitmentIssuedByPostalCode; } set { _commitmentIssuedByPostalCode = value; } }
        private Value<string> _commitmentIssuedByState;
        public string CommitmentIssuedByState { get { return _commitmentIssuedByState; } set { _commitmentIssuedByState = value; } }
        private Value<string> _consumerHandbookOnAdjustableRateMortgages;
        public string ConsumerHandbookOnAdjustableRateMortgages { get { return _consumerHandbookOnAdjustableRateMortgages; } set { _consumerHandbookOnAdjustableRateMortgages = value; } }
        private Value<string> _daysToReceiveWrittenRequest;
        public string DaysToReceiveWrittenRequest { get { return _daysToReceiveWrittenRequest; } set { _daysToReceiveWrittenRequest = value; } }
        private Value<int?> _daysToReturnToLender;
        public int? DaysToReturnToLender { get { return _daysToReturnToLender; } set { _daysToReturnToLender = value; } }
        private Value<string> _discloseNonPublicPersonalInformation;
        public string DiscloseNonPublicPersonalInformation { get { return _discloseNonPublicPersonalInformation; } set { _discloseNonPublicPersonalInformation = value; } }
        private Value<string> _ecoaAddress;
        public string EcoaAddress { get { return _ecoaAddress; } set { _ecoaAddress = value; } }
        private Value<string> _ecoaAddress2;
        public string EcoaAddress2 { get { return _ecoaAddress2; } set { _ecoaAddress2 = value; } }
        private Value<string> _ecoaCity;
        public string EcoaCity { get { return _ecoaCity; } set { _ecoaCity = value; } }
        private Value<string> _ecoaName;
        public string EcoaName { get { return _ecoaName; } set { _ecoaName = value; } }
        private Value<string> _ecoaPhone;
        public string EcoaPhone { get { return _ecoaPhone; } set { _ecoaPhone = value; } }
        private Value<string> _ecoaPostalCode;
        public string EcoaPostalCode { get { return _ecoaPostalCode; } set { _ecoaPostalCode = value; } }
        private Value<string> _ecoaState;
        public string EcoaState { get { return _ecoaState; } set { _ecoaState = value; } }
        private Value<string> _fairLendingNoticeDescription1;
        public string FairLendingNoticeDescription1 { get { return _fairLendingNoticeDescription1; } set { _fairLendingNoticeDescription1 = value; } }
        private Value<string> _fairLendingNoticeDescription2;
        public string FairLendingNoticeDescription2 { get { return _fairLendingNoticeDescription2; } set { _fairLendingNoticeDescription2 = value; } }
        private Value<string> _fairLendingNoticeDescription3;
        public string FairLendingNoticeDescription3 { get { return _fairLendingNoticeDescription3; } set { _fairLendingNoticeDescription3 = value; } }
        private Value<string> _fairLendingNoticeDescription4;
        public string FairLendingNoticeDescription4 { get { return _fairLendingNoticeDescription4; } set { _fairLendingNoticeDescription4 = value; } }
        private Value<string> _fairLendingNoticeDescription5;
        public string FairLendingNoticeDescription5 { get { return _fairLendingNoticeDescription5; } set { _fairLendingNoticeDescription5 = value; } }
        private Value<string> _fairLendingNoticeDescription6;
        public string FairLendingNoticeDescription6 { get { return _fairLendingNoticeDescription6; } set { _fairLendingNoticeDescription6 = value; } }
        private Value<string> _fairLendingNoticeDescription7;
        public string FairLendingNoticeDescription7 { get { return _fairLendingNoticeDescription7; } set { _fairLendingNoticeDescription7 = value; } }
        private Value<string> _fairLendingNoticeDescription8;
        public string FairLendingNoticeDescription8 { get { return _fairLendingNoticeDescription8; } set { _fairLendingNoticeDescription8 = value; } }
        private Value<string> _femaCommunityName;
        public string FemaCommunityName { get { return _femaCommunityName; } set { _femaCommunityName = value; } }
        private Value<bool?> _floodInsuranceNotificationIndicator;
        public bool? FloodInsuranceNotificationIndicator { get { return _floodInsuranceNotificationIndicator; } set { _floodInsuranceNotificationIndicator = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<bool?> _informationDisclosureAuthorizationIndicator;
        public bool? InformationDisclosureAuthorizationIndicator { get { return _informationDisclosureAuthorizationIndicator; } set { _informationDisclosureAuthorizationIndicator = value; } }
        private Value<string> _licensedMortgageBrokerUnder;
        public string LicensedMortgageBrokerUnder { get { return _licensedMortgageBrokerUnder; } set { _licensedMortgageBrokerUnder = value; } }
        private Value<bool?> _locatedInNfipIndicator;
        public bool? LocatedInNfipIndicator { get { return _locatedInNfipIndicator; } set { _locatedInNfipIndicator = value; } }
        private Value<string> _lossPayeeClause;
        public string LossPayeeClause { get { return _lossPayeeClause; } set { _lossPayeeClause = value; } }
        private Value<string> _mapPanelNumber;
        public string MapPanelNumber { get { return _mapPanelNumber; } set { _mapPanelNumber = value; } }
        private Value<string> _nFIPCommunityNumber;
        public string NFIPCommunityNumber { get { return _nFIPCommunityNumber; } set { _nFIPCommunityNumber = value; } }
        private Value<DateTime?> _nFIPMapEffectiveRevisedDate;
        public DateTime? NFIPMapEffectiveRevisedDate { get { return _nFIPMapEffectiveRevisedDate; } set { _nFIPMapEffectiveRevisedDate = value; } }
        private Value<string> _nonFinancialCompaniesDescription1;
        public string NonFinancialCompaniesDescription1 { get { return _nonFinancialCompaniesDescription1; } set { _nonFinancialCompaniesDescription1 = value; } }
        private Value<string> _nonFinancialCompaniesDescription2;
        public string NonFinancialCompaniesDescription2 { get { return _nonFinancialCompaniesDescription2; } set { _nonFinancialCompaniesDescription2 = value; } }
        private Value<string> _nonFinancialCompaniesDescription3;
        public string NonFinancialCompaniesDescription3 { get { return _nonFinancialCompaniesDescription3; } set { _nonFinancialCompaniesDescription3 = value; } }
        private Value<string> _nonFinancialCompaniesDescription4;
        public string NonFinancialCompaniesDescription4 { get { return _nonFinancialCompaniesDescription4; } set { _nonFinancialCompaniesDescription4 = value; } }
        private Value<bool?> _notLocatedInNfipIndicator;
        public bool? NotLocatedInNfipIndicator { get { return _notLocatedInNfipIndicator; } set { _notLocatedInNfipIndicator = value; } }
        private Value<bool?> _occupancyStatementIndicator;
        public bool? OccupancyStatementIndicator { get { return _occupancyStatementIndicator; } set { _occupancyStatementIndicator = value; } }
        private Value<string> _optOut;
        public string OptOut { get { return _optOut; } set { _optOut = value; } }
        private Value<string> _optOutPhone;
        public string OptOutPhone { get { return _optOutPhone; } set { _optOutPhone = value; } }
        private Value<bool?> _releaseBankingInformationIndicator;
        public bool? ReleaseBankingInformationIndicator { get { return _releaseBankingInformationIndicator; } set { _releaseBankingInformationIndicator = value; } }
        private Value<bool?> _releaseEmploymentInformationIndicator;
        public bool? ReleaseEmploymentInformationIndicator { get { return _releaseEmploymentInformationIndicator; } set { _releaseEmploymentInformationIndicator = value; } }
        private Value<bool?> _releaseInformationInConnectionWithCreditReportIndicator;
        public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get { return _releaseInformationInConnectionWithCreditReportIndicator; } set { _releaseInformationInConnectionWithCreditReportIndicator = value; } }
        private Value<bool?> _releaseMortgageInformationIndicator;
        public bool? ReleaseMortgageInformationIndicator { get { return _releaseMortgageInformationIndicator; } set { _releaseMortgageInformationIndicator = value; } }
        private Value<bool?> _rightToFinancialPrivacyActIndicator;
        public bool? RightToFinancialPrivacyActIndicator { get { return _rightToFinancialPrivacyActIndicator; } set { _rightToFinancialPrivacyActIndicator = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _antiCoercionStatementIndicator.Clean
                    && _commitmentIssuedByAddress.Clean
                    && _commitmentIssuedByCity.Clean
                    && _commitmentIssuedByContactName.Clean
                    && _commitmentIssuedByName.Clean
                    && _commitmentIssuedByPhone.Clean
                    && _commitmentIssuedByPostalCode.Clean
                    && _commitmentIssuedByState.Clean
                    && _consumerHandbookOnAdjustableRateMortgages.Clean
                    && _daysToReceiveWrittenRequest.Clean
                    && _daysToReturnToLender.Clean
                    && _discloseNonPublicPersonalInformation.Clean
                    && _ecoaAddress.Clean
                    && _ecoaAddress2.Clean
                    && _ecoaCity.Clean
                    && _ecoaName.Clean
                    && _ecoaPhone.Clean
                    && _ecoaPostalCode.Clean
                    && _ecoaState.Clean
                    && _fairLendingNoticeDescription1.Clean
                    && _fairLendingNoticeDescription2.Clean
                    && _fairLendingNoticeDescription3.Clean
                    && _fairLendingNoticeDescription4.Clean
                    && _fairLendingNoticeDescription5.Clean
                    && _fairLendingNoticeDescription6.Clean
                    && _fairLendingNoticeDescription7.Clean
                    && _fairLendingNoticeDescription8.Clean
                    && _femaCommunityName.Clean
                    && _floodInsuranceNotificationIndicator.Clean
                    && _id.Clean
                    && _informationDisclosureAuthorizationIndicator.Clean
                    && _licensedMortgageBrokerUnder.Clean
                    && _locatedInNfipIndicator.Clean
                    && _lossPayeeClause.Clean
                    && _mapPanelNumber.Clean
                    && _nFIPCommunityNumber.Clean
                    && _nFIPMapEffectiveRevisedDate.Clean
                    && _nonFinancialCompaniesDescription1.Clean
                    && _nonFinancialCompaniesDescription2.Clean
                    && _nonFinancialCompaniesDescription3.Clean
                    && _nonFinancialCompaniesDescription4.Clean
                    && _notLocatedInNfipIndicator.Clean
                    && _occupancyStatementIndicator.Clean
                    && _optOut.Clean
                    && _optOutPhone.Clean
                    && _releaseBankingInformationIndicator.Clean
                    && _releaseEmploymentInformationIndicator.Clean
                    && _releaseInformationInConnectionWithCreditReportIndicator.Clean
                    && _releaseMortgageInformationIndicator.Clean
                    && _rightToFinancialPrivacyActIndicator.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var antiCoercionStatementIndicator = _antiCoercionStatementIndicator; antiCoercionStatementIndicator.Clean = value; _antiCoercionStatementIndicator = antiCoercionStatementIndicator;
                var commitmentIssuedByAddress = _commitmentIssuedByAddress; commitmentIssuedByAddress.Clean = value; _commitmentIssuedByAddress = commitmentIssuedByAddress;
                var commitmentIssuedByCity = _commitmentIssuedByCity; commitmentIssuedByCity.Clean = value; _commitmentIssuedByCity = commitmentIssuedByCity;
                var commitmentIssuedByContactName = _commitmentIssuedByContactName; commitmentIssuedByContactName.Clean = value; _commitmentIssuedByContactName = commitmentIssuedByContactName;
                var commitmentIssuedByName = _commitmentIssuedByName; commitmentIssuedByName.Clean = value; _commitmentIssuedByName = commitmentIssuedByName;
                var commitmentIssuedByPhone = _commitmentIssuedByPhone; commitmentIssuedByPhone.Clean = value; _commitmentIssuedByPhone = commitmentIssuedByPhone;
                var commitmentIssuedByPostalCode = _commitmentIssuedByPostalCode; commitmentIssuedByPostalCode.Clean = value; _commitmentIssuedByPostalCode = commitmentIssuedByPostalCode;
                var commitmentIssuedByState = _commitmentIssuedByState; commitmentIssuedByState.Clean = value; _commitmentIssuedByState = commitmentIssuedByState;
                var consumerHandbookOnAdjustableRateMortgages = _consumerHandbookOnAdjustableRateMortgages; consumerHandbookOnAdjustableRateMortgages.Clean = value; _consumerHandbookOnAdjustableRateMortgages = consumerHandbookOnAdjustableRateMortgages;
                var daysToReceiveWrittenRequest = _daysToReceiveWrittenRequest; daysToReceiveWrittenRequest.Clean = value; _daysToReceiveWrittenRequest = daysToReceiveWrittenRequest;
                var daysToReturnToLender = _daysToReturnToLender; daysToReturnToLender.Clean = value; _daysToReturnToLender = daysToReturnToLender;
                var discloseNonPublicPersonalInformation = _discloseNonPublicPersonalInformation; discloseNonPublicPersonalInformation.Clean = value; _discloseNonPublicPersonalInformation = discloseNonPublicPersonalInformation;
                var ecoaAddress = _ecoaAddress; ecoaAddress.Clean = value; _ecoaAddress = ecoaAddress;
                var ecoaAddress2 = _ecoaAddress2; ecoaAddress2.Clean = value; _ecoaAddress2 = ecoaAddress2;
                var ecoaCity = _ecoaCity; ecoaCity.Clean = value; _ecoaCity = ecoaCity;
                var ecoaName = _ecoaName; ecoaName.Clean = value; _ecoaName = ecoaName;
                var ecoaPhone = _ecoaPhone; ecoaPhone.Clean = value; _ecoaPhone = ecoaPhone;
                var ecoaPostalCode = _ecoaPostalCode; ecoaPostalCode.Clean = value; _ecoaPostalCode = ecoaPostalCode;
                var ecoaState = _ecoaState; ecoaState.Clean = value; _ecoaState = ecoaState;
                var fairLendingNoticeDescription1 = _fairLendingNoticeDescription1; fairLendingNoticeDescription1.Clean = value; _fairLendingNoticeDescription1 = fairLendingNoticeDescription1;
                var fairLendingNoticeDescription2 = _fairLendingNoticeDescription2; fairLendingNoticeDescription2.Clean = value; _fairLendingNoticeDescription2 = fairLendingNoticeDescription2;
                var fairLendingNoticeDescription3 = _fairLendingNoticeDescription3; fairLendingNoticeDescription3.Clean = value; _fairLendingNoticeDescription3 = fairLendingNoticeDescription3;
                var fairLendingNoticeDescription4 = _fairLendingNoticeDescription4; fairLendingNoticeDescription4.Clean = value; _fairLendingNoticeDescription4 = fairLendingNoticeDescription4;
                var fairLendingNoticeDescription5 = _fairLendingNoticeDescription5; fairLendingNoticeDescription5.Clean = value; _fairLendingNoticeDescription5 = fairLendingNoticeDescription5;
                var fairLendingNoticeDescription6 = _fairLendingNoticeDescription6; fairLendingNoticeDescription6.Clean = value; _fairLendingNoticeDescription6 = fairLendingNoticeDescription6;
                var fairLendingNoticeDescription7 = _fairLendingNoticeDescription7; fairLendingNoticeDescription7.Clean = value; _fairLendingNoticeDescription7 = fairLendingNoticeDescription7;
                var fairLendingNoticeDescription8 = _fairLendingNoticeDescription8; fairLendingNoticeDescription8.Clean = value; _fairLendingNoticeDescription8 = fairLendingNoticeDescription8;
                var femaCommunityName = _femaCommunityName; femaCommunityName.Clean = value; _femaCommunityName = femaCommunityName;
                var floodInsuranceNotificationIndicator = _floodInsuranceNotificationIndicator; floodInsuranceNotificationIndicator.Clean = value; _floodInsuranceNotificationIndicator = floodInsuranceNotificationIndicator;
                var id = _id; id.Clean = value; _id = id;
                var informationDisclosureAuthorizationIndicator = _informationDisclosureAuthorizationIndicator; informationDisclosureAuthorizationIndicator.Clean = value; _informationDisclosureAuthorizationIndicator = informationDisclosureAuthorizationIndicator;
                var licensedMortgageBrokerUnder = _licensedMortgageBrokerUnder; licensedMortgageBrokerUnder.Clean = value; _licensedMortgageBrokerUnder = licensedMortgageBrokerUnder;
                var locatedInNfipIndicator = _locatedInNfipIndicator; locatedInNfipIndicator.Clean = value; _locatedInNfipIndicator = locatedInNfipIndicator;
                var lossPayeeClause = _lossPayeeClause; lossPayeeClause.Clean = value; _lossPayeeClause = lossPayeeClause;
                var mapPanelNumber = _mapPanelNumber; mapPanelNumber.Clean = value; _mapPanelNumber = mapPanelNumber;
                var nFIPCommunityNumber = _nFIPCommunityNumber; nFIPCommunityNumber.Clean = value; _nFIPCommunityNumber = nFIPCommunityNumber;
                var nFIPMapEffectiveRevisedDate = _nFIPMapEffectiveRevisedDate; nFIPMapEffectiveRevisedDate.Clean = value; _nFIPMapEffectiveRevisedDate = nFIPMapEffectiveRevisedDate;
                var nonFinancialCompaniesDescription1 = _nonFinancialCompaniesDescription1; nonFinancialCompaniesDescription1.Clean = value; _nonFinancialCompaniesDescription1 = nonFinancialCompaniesDescription1;
                var nonFinancialCompaniesDescription2 = _nonFinancialCompaniesDescription2; nonFinancialCompaniesDescription2.Clean = value; _nonFinancialCompaniesDescription2 = nonFinancialCompaniesDescription2;
                var nonFinancialCompaniesDescription3 = _nonFinancialCompaniesDescription3; nonFinancialCompaniesDescription3.Clean = value; _nonFinancialCompaniesDescription3 = nonFinancialCompaniesDescription3;
                var nonFinancialCompaniesDescription4 = _nonFinancialCompaniesDescription4; nonFinancialCompaniesDescription4.Clean = value; _nonFinancialCompaniesDescription4 = nonFinancialCompaniesDescription4;
                var notLocatedInNfipIndicator = _notLocatedInNfipIndicator; notLocatedInNfipIndicator.Clean = value; _notLocatedInNfipIndicator = notLocatedInNfipIndicator;
                var occupancyStatementIndicator = _occupancyStatementIndicator; occupancyStatementIndicator.Clean = value; _occupancyStatementIndicator = occupancyStatementIndicator;
                var optOut = _optOut; optOut.Clean = value; _optOut = optOut;
                var optOutPhone = _optOutPhone; optOutPhone.Clean = value; _optOutPhone = optOutPhone;
                var releaseBankingInformationIndicator = _releaseBankingInformationIndicator; releaseBankingInformationIndicator.Clean = value; _releaseBankingInformationIndicator = releaseBankingInformationIndicator;
                var releaseEmploymentInformationIndicator = _releaseEmploymentInformationIndicator; releaseEmploymentInformationIndicator.Clean = value; _releaseEmploymentInformationIndicator = releaseEmploymentInformationIndicator;
                var releaseInformationInConnectionWithCreditReportIndicator = _releaseInformationInConnectionWithCreditReportIndicator; releaseInformationInConnectionWithCreditReportIndicator.Clean = value; _releaseInformationInConnectionWithCreditReportIndicator = releaseInformationInConnectionWithCreditReportIndicator;
                var releaseMortgageInformationIndicator = _releaseMortgageInformationIndicator; releaseMortgageInformationIndicator.Clean = value; _releaseMortgageInformationIndicator = releaseMortgageInformationIndicator;
                var rightToFinancialPrivacyActIndicator = _rightToFinancialPrivacyActIndicator; rightToFinancialPrivacyActIndicator.Clean = value; _rightToFinancialPrivacyActIndicator = rightToFinancialPrivacyActIndicator;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public DisclosureNotices()
        {
            Clean = true;
        }
    }
}