using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class DisclosureNotices : IDirty
    {
        private DirtyValue<bool?> _antiCoercionStatementIndicator;
        public bool? AntiCoercionStatementIndicator { get { return _antiCoercionStatementIndicator; } set { _antiCoercionStatementIndicator = value; } }
        private DirtyValue<string> _commitmentIssuedByAddress;
        public string CommitmentIssuedByAddress { get { return _commitmentIssuedByAddress; } set { _commitmentIssuedByAddress = value; } }
        private DirtyValue<string> _commitmentIssuedByCity;
        public string CommitmentIssuedByCity { get { return _commitmentIssuedByCity; } set { _commitmentIssuedByCity = value; } }
        private DirtyValue<string> _commitmentIssuedByContactName;
        public string CommitmentIssuedByContactName { get { return _commitmentIssuedByContactName; } set { _commitmentIssuedByContactName = value; } }
        private DirtyValue<string> _commitmentIssuedByName;
        public string CommitmentIssuedByName { get { return _commitmentIssuedByName; } set { _commitmentIssuedByName = value; } }
        private DirtyValue<string> _commitmentIssuedByPhone;
        public string CommitmentIssuedByPhone { get { return _commitmentIssuedByPhone; } set { _commitmentIssuedByPhone = value; } }
        private DirtyValue<string> _commitmentIssuedByPostalCode;
        public string CommitmentIssuedByPostalCode { get { return _commitmentIssuedByPostalCode; } set { _commitmentIssuedByPostalCode = value; } }
        private DirtyValue<string> _commitmentIssuedByState;
        public string CommitmentIssuedByState { get { return _commitmentIssuedByState; } set { _commitmentIssuedByState = value; } }
        private DirtyValue<string> _consumerHandbookOnAdjustableRateMortgages;
        public string ConsumerHandbookOnAdjustableRateMortgages { get { return _consumerHandbookOnAdjustableRateMortgages; } set { _consumerHandbookOnAdjustableRateMortgages = value; } }
        private DirtyValue<string> _daysToReceiveWrittenRequest;
        public string DaysToReceiveWrittenRequest { get { return _daysToReceiveWrittenRequest; } set { _daysToReceiveWrittenRequest = value; } }
        private DirtyValue<int?> _daysToReturnToLender;
        public int? DaysToReturnToLender { get { return _daysToReturnToLender; } set { _daysToReturnToLender = value; } }
        private DirtyValue<string> _discloseNonPublicPersonalInformation;
        public string DiscloseNonPublicPersonalInformation { get { return _discloseNonPublicPersonalInformation; } set { _discloseNonPublicPersonalInformation = value; } }
        private DirtyValue<string> _ecoaAddress;
        public string EcoaAddress { get { return _ecoaAddress; } set { _ecoaAddress = value; } }
        private DirtyValue<string> _ecoaAddress2;
        public string EcoaAddress2 { get { return _ecoaAddress2; } set { _ecoaAddress2 = value; } }
        private DirtyValue<string> _ecoaCity;
        public string EcoaCity { get { return _ecoaCity; } set { _ecoaCity = value; } }
        private DirtyValue<string> _ecoaName;
        public string EcoaName { get { return _ecoaName; } set { _ecoaName = value; } }
        private DirtyValue<string> _ecoaPhone;
        public string EcoaPhone { get { return _ecoaPhone; } set { _ecoaPhone = value; } }
        private DirtyValue<string> _ecoaPostalCode;
        public string EcoaPostalCode { get { return _ecoaPostalCode; } set { _ecoaPostalCode = value; } }
        private DirtyValue<string> _ecoaState;
        public string EcoaState { get { return _ecoaState; } set { _ecoaState = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription1;
        public string FairLendingNoticeDescription1 { get { return _fairLendingNoticeDescription1; } set { _fairLendingNoticeDescription1 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription2;
        public string FairLendingNoticeDescription2 { get { return _fairLendingNoticeDescription2; } set { _fairLendingNoticeDescription2 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription3;
        public string FairLendingNoticeDescription3 { get { return _fairLendingNoticeDescription3; } set { _fairLendingNoticeDescription3 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription4;
        public string FairLendingNoticeDescription4 { get { return _fairLendingNoticeDescription4; } set { _fairLendingNoticeDescription4 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription5;
        public string FairLendingNoticeDescription5 { get { return _fairLendingNoticeDescription5; } set { _fairLendingNoticeDescription5 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription6;
        public string FairLendingNoticeDescription6 { get { return _fairLendingNoticeDescription6; } set { _fairLendingNoticeDescription6 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription7;
        public string FairLendingNoticeDescription7 { get { return _fairLendingNoticeDescription7; } set { _fairLendingNoticeDescription7 = value; } }
        private DirtyValue<string> _fairLendingNoticeDescription8;
        public string FairLendingNoticeDescription8 { get { return _fairLendingNoticeDescription8; } set { _fairLendingNoticeDescription8 = value; } }
        private DirtyValue<string> _femaCommunityName;
        public string FemaCommunityName { get { return _femaCommunityName; } set { _femaCommunityName = value; } }
        private DirtyValue<bool?> _floodInsuranceNotificationIndicator;
        public bool? FloodInsuranceNotificationIndicator { get { return _floodInsuranceNotificationIndicator; } set { _floodInsuranceNotificationIndicator = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<bool?> _informationDisclosureAuthorizationIndicator;
        public bool? InformationDisclosureAuthorizationIndicator { get { return _informationDisclosureAuthorizationIndicator; } set { _informationDisclosureAuthorizationIndicator = value; } }
        private DirtyValue<string> _licensedMortgageBrokerUnder;
        public string LicensedMortgageBrokerUnder { get { return _licensedMortgageBrokerUnder; } set { _licensedMortgageBrokerUnder = value; } }
        private DirtyValue<bool?> _locatedInNfipIndicator;
        public bool? LocatedInNfipIndicator { get { return _locatedInNfipIndicator; } set { _locatedInNfipIndicator = value; } }
        private DirtyValue<string> _lossPayeeClause;
        public string LossPayeeClause { get { return _lossPayeeClause; } set { _lossPayeeClause = value; } }
        private DirtyValue<string> _mapPanelNumber;
        public string MapPanelNumber { get { return _mapPanelNumber; } set { _mapPanelNumber = value; } }
        private DirtyValue<string> _nFIPCommunityNumber;
        public string NFIPCommunityNumber { get { return _nFIPCommunityNumber; } set { _nFIPCommunityNumber = value; } }
        private DirtyValue<DateTime?> _nFIPMapEffectiveRevisedDate;
        public DateTime? NFIPMapEffectiveRevisedDate { get { return _nFIPMapEffectiveRevisedDate; } set { _nFIPMapEffectiveRevisedDate = value; } }
        private DirtyValue<string> _nonFinancialCompaniesDescription1;
        public string NonFinancialCompaniesDescription1 { get { return _nonFinancialCompaniesDescription1; } set { _nonFinancialCompaniesDescription1 = value; } }
        private DirtyValue<string> _nonFinancialCompaniesDescription2;
        public string NonFinancialCompaniesDescription2 { get { return _nonFinancialCompaniesDescription2; } set { _nonFinancialCompaniesDescription2 = value; } }
        private DirtyValue<string> _nonFinancialCompaniesDescription3;
        public string NonFinancialCompaniesDescription3 { get { return _nonFinancialCompaniesDescription3; } set { _nonFinancialCompaniesDescription3 = value; } }
        private DirtyValue<string> _nonFinancialCompaniesDescription4;
        public string NonFinancialCompaniesDescription4 { get { return _nonFinancialCompaniesDescription4; } set { _nonFinancialCompaniesDescription4 = value; } }
        private DirtyValue<bool?> _notLocatedInNfipIndicator;
        public bool? NotLocatedInNfipIndicator { get { return _notLocatedInNfipIndicator; } set { _notLocatedInNfipIndicator = value; } }
        private DirtyValue<bool?> _occupancyStatementIndicator;
        public bool? OccupancyStatementIndicator { get { return _occupancyStatementIndicator; } set { _occupancyStatementIndicator = value; } }
        private DirtyValue<string> _optOut;
        public string OptOut { get { return _optOut; } set { _optOut = value; } }
        private DirtyValue<string> _optOutPhone;
        public string OptOutPhone { get { return _optOutPhone; } set { _optOutPhone = value; } }
        private DirtyValue<bool?> _releaseBankingInformationIndicator;
        public bool? ReleaseBankingInformationIndicator { get { return _releaseBankingInformationIndicator; } set { _releaseBankingInformationIndicator = value; } }
        private DirtyValue<bool?> _releaseEmploymentInformationIndicator;
        public bool? ReleaseEmploymentInformationIndicator { get { return _releaseEmploymentInformationIndicator; } set { _releaseEmploymentInformationIndicator = value; } }
        private DirtyValue<bool?> _releaseInformationInConnectionWithCreditReportIndicator;
        public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get { return _releaseInformationInConnectionWithCreditReportIndicator; } set { _releaseInformationInConnectionWithCreditReportIndicator = value; } }
        private DirtyValue<bool?> _releaseMortgageInformationIndicator;
        public bool? ReleaseMortgageInformationIndicator { get { return _releaseMortgageInformationIndicator; } set { _releaseMortgageInformationIndicator = value; } }
        private DirtyValue<bool?> _rightToFinancialPrivacyActIndicator;
        public bool? RightToFinancialPrivacyActIndicator { get { return _rightToFinancialPrivacyActIndicator; } set { _rightToFinancialPrivacyActIndicator = value; } }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
                var dirty = _antiCoercionStatementIndicator.Dirty
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
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}