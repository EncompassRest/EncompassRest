using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                var v0 = _antiCoercionStatementIndicator; v0.Clean = value; _antiCoercionStatementIndicator = v0;
                var v1 = _commitmentIssuedByAddress; v1.Clean = value; _commitmentIssuedByAddress = v1;
                var v2 = _commitmentIssuedByCity; v2.Clean = value; _commitmentIssuedByCity = v2;
                var v3 = _commitmentIssuedByContactName; v3.Clean = value; _commitmentIssuedByContactName = v3;
                var v4 = _commitmentIssuedByName; v4.Clean = value; _commitmentIssuedByName = v4;
                var v5 = _commitmentIssuedByPhone; v5.Clean = value; _commitmentIssuedByPhone = v5;
                var v6 = _commitmentIssuedByPostalCode; v6.Clean = value; _commitmentIssuedByPostalCode = v6;
                var v7 = _commitmentIssuedByState; v7.Clean = value; _commitmentIssuedByState = v7;
                var v8 = _consumerHandbookOnAdjustableRateMortgages; v8.Clean = value; _consumerHandbookOnAdjustableRateMortgages = v8;
                var v9 = _daysToReceiveWrittenRequest; v9.Clean = value; _daysToReceiveWrittenRequest = v9;
                var v10 = _daysToReturnToLender; v10.Clean = value; _daysToReturnToLender = v10;
                var v11 = _discloseNonPublicPersonalInformation; v11.Clean = value; _discloseNonPublicPersonalInformation = v11;
                var v12 = _ecoaAddress; v12.Clean = value; _ecoaAddress = v12;
                var v13 = _ecoaAddress2; v13.Clean = value; _ecoaAddress2 = v13;
                var v14 = _ecoaCity; v14.Clean = value; _ecoaCity = v14;
                var v15 = _ecoaName; v15.Clean = value; _ecoaName = v15;
                var v16 = _ecoaPhone; v16.Clean = value; _ecoaPhone = v16;
                var v17 = _ecoaPostalCode; v17.Clean = value; _ecoaPostalCode = v17;
                var v18 = _ecoaState; v18.Clean = value; _ecoaState = v18;
                var v19 = _fairLendingNoticeDescription1; v19.Clean = value; _fairLendingNoticeDescription1 = v19;
                var v20 = _fairLendingNoticeDescription2; v20.Clean = value; _fairLendingNoticeDescription2 = v20;
                var v21 = _fairLendingNoticeDescription3; v21.Clean = value; _fairLendingNoticeDescription3 = v21;
                var v22 = _fairLendingNoticeDescription4; v22.Clean = value; _fairLendingNoticeDescription4 = v22;
                var v23 = _fairLendingNoticeDescription5; v23.Clean = value; _fairLendingNoticeDescription5 = v23;
                var v24 = _fairLendingNoticeDescription6; v24.Clean = value; _fairLendingNoticeDescription6 = v24;
                var v25 = _fairLendingNoticeDescription7; v25.Clean = value; _fairLendingNoticeDescription7 = v25;
                var v26 = _fairLendingNoticeDescription8; v26.Clean = value; _fairLendingNoticeDescription8 = v26;
                var v27 = _femaCommunityName; v27.Clean = value; _femaCommunityName = v27;
                var v28 = _floodInsuranceNotificationIndicator; v28.Clean = value; _floodInsuranceNotificationIndicator = v28;
                var v29 = _id; v29.Clean = value; _id = v29;
                var v30 = _informationDisclosureAuthorizationIndicator; v30.Clean = value; _informationDisclosureAuthorizationIndicator = v30;
                var v31 = _licensedMortgageBrokerUnder; v31.Clean = value; _licensedMortgageBrokerUnder = v31;
                var v32 = _locatedInNfipIndicator; v32.Clean = value; _locatedInNfipIndicator = v32;
                var v33 = _lossPayeeClause; v33.Clean = value; _lossPayeeClause = v33;
                var v34 = _mapPanelNumber; v34.Clean = value; _mapPanelNumber = v34;
                var v35 = _nFIPCommunityNumber; v35.Clean = value; _nFIPCommunityNumber = v35;
                var v36 = _nFIPMapEffectiveRevisedDate; v36.Clean = value; _nFIPMapEffectiveRevisedDate = v36;
                var v37 = _nonFinancialCompaniesDescription1; v37.Clean = value; _nonFinancialCompaniesDescription1 = v37;
                var v38 = _nonFinancialCompaniesDescription2; v38.Clean = value; _nonFinancialCompaniesDescription2 = v38;
                var v39 = _nonFinancialCompaniesDescription3; v39.Clean = value; _nonFinancialCompaniesDescription3 = v39;
                var v40 = _nonFinancialCompaniesDescription4; v40.Clean = value; _nonFinancialCompaniesDescription4 = v40;
                var v41 = _notLocatedInNfipIndicator; v41.Clean = value; _notLocatedInNfipIndicator = v41;
                var v42 = _occupancyStatementIndicator; v42.Clean = value; _occupancyStatementIndicator = v42;
                var v43 = _optOut; v43.Clean = value; _optOut = v43;
                var v44 = _optOutPhone; v44.Clean = value; _optOutPhone = v44;
                var v45 = _releaseBankingInformationIndicator; v45.Clean = value; _releaseBankingInformationIndicator = v45;
                var v46 = _releaseEmploymentInformationIndicator; v46.Clean = value; _releaseEmploymentInformationIndicator = v46;
                var v47 = _releaseInformationInConnectionWithCreditReportIndicator; v47.Clean = value; _releaseInformationInConnectionWithCreditReportIndicator = v47;
                var v48 = _releaseMortgageInformationIndicator; v48.Clean = value; _releaseMortgageInformationIndicator = v48;
                var v49 = _rightToFinancialPrivacyActIndicator; v49.Clean = value; _rightToFinancialPrivacyActIndicator = v49;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}