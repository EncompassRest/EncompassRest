using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PrivacyPolicy : IClean
    {
        private Value<string> _additionalRightsDescription;
        public string AdditionalRightsDescription { get { return _additionalRightsDescription; } set { _additionalRightsDescription = value; } }
        private Value<string> _affiliateType;
        public string AffiliateType { get { return _affiliateType; } set { _affiliateType = value; } }
        private Value<string> _affiliateTypeExample1;
        public string AffiliateTypeExample1 { get { return _affiliateTypeExample1; } set { _affiliateTypeExample1 = value; } }
        private Value<string> _affiliateTypeExample2;
        public string AffiliateTypeExample2 { get { return _affiliateTypeExample2; } set { _affiliateTypeExample2 = value; } }
        private Value<string> _affiliateTypeExample3;
        public string AffiliateTypeExample3 { get { return _affiliateTypeExample3; } set { _affiliateTypeExample3 = value; } }
        private Value<string> _alsoCollectFrom;
        public string AlsoCollectFrom { get { return _alsoCollectFrom; } set { _alsoCollectFrom = value; } }
        private Value<int?> _daysToUse;
        public int? DaysToUse { get { return _daysToUse; } set { _daysToUse = value; } }
        private Value<string> _howToShare;
        public string HowToShare { get { return _howToShare; } set { _howToShare = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<string> _informationShare1;
        public string InformationShare1 { get { return _informationShare1; } set { _informationShare1 = value; } }
        private Value<string> _informationShare2;
        public string InformationShare2 { get { return _informationShare2; } set { _informationShare2 = value; } }
        private Value<string> _informationShare3;
        public string InformationShare3 { get { return _informationShare3; } set { _informationShare3 = value; } }
        private Value<string> _informationShare4;
        public string InformationShare4 { get { return _informationShare4; } set { _informationShare4 = value; } }
        private Value<string> _informationShare5;
        public string InformationShare5 { get { return _informationShare5; } set { _informationShare5 = value; } }
        private Value<string> _informationShare6;
        public string InformationShare6 { get { return _informationShare6; } set { _informationShare6 = value; } }
        private Value<string> _informationShare7;
        public string InformationShare7 { get { return _informationShare7; } set { _informationShare7 = value; } }
        private Value<string> _informationTypesWeCollect1;
        public string InformationTypesWeCollect1 { get { return _informationTypesWeCollect1; } set { _informationTypesWeCollect1 = value; } }
        private Value<string> _informationTypesWeCollect2;
        public string InformationTypesWeCollect2 { get { return _informationTypesWeCollect2; } set { _informationTypesWeCollect2 = value; } }
        private Value<string> _informationTypesWeCollect3;
        public string InformationTypesWeCollect3 { get { return _informationTypesWeCollect3; } set { _informationTypesWeCollect3 = value; } }
        private Value<string> _informationTypesWeCollect4;
        public string InformationTypesWeCollect4 { get { return _informationTypesWeCollect4; } set { _informationTypesWeCollect4 = value; } }
        private Value<string> _informationTypesWeCollect5;
        public string InformationTypesWeCollect5 { get { return _informationTypesWeCollect5; } set { _informationTypesWeCollect5 = value; } }
        private Value<string> _jointMarketType;
        public string JointMarketType { get { return _jointMarketType; } set { _jointMarketType = value; } }
        private Value<string> _jointMarketTypeExample1;
        public string JointMarketTypeExample1 { get { return _jointMarketTypeExample1; } set { _jointMarketTypeExample1 = value; } }
        private Value<string> _limitSharing1;
        public string LimitSharing1 { get { return _limitSharing1; } set { _limitSharing1 = value; } }
        private Value<string> _limitSharing2;
        public string LimitSharing2 { get { return _limitSharing2; } set { _limitSharing2 = value; } }
        private Value<string> _limitSharing3;
        public string LimitSharing3 { get { return _limitSharing3; } set { _limitSharing3 = value; } }
        private Value<string> _limitSharing4;
        public string LimitSharing4 { get { return _limitSharing4; } set { _limitSharing4 = value; } }
        private Value<string> _limitSharing5;
        public string LimitSharing5 { get { return _limitSharing5; } set { _limitSharing5 = value; } }
        private Value<string> _limitSharing6;
        public string LimitSharing6 { get { return _limitSharing6; } set { _limitSharing6 = value; } }
        private Value<string> _limitSharing7;
        public string LimitSharing7 { get { return _limitSharing7; } set { _limitSharing7 = value; } }
        private Value<string> _month;
        public string Month { get { return _month; } set { _month = value; } }
        private Value<string> _nonaffiliateType;
        public string NonaffiliateType { get { return _nonaffiliateType; } set { _nonaffiliateType = value; } }
        private Value<string> _nonaffiliateTypeExample1;
        public string NonaffiliateTypeExample1 { get { return _nonaffiliateTypeExample1; } set { _nonaffiliateTypeExample1 = value; } }
        private Value<string> _notesForProtectPrivacy;
        public string NotesForProtectPrivacy { get { return _notesForProtectPrivacy; } set { _notesForProtectPrivacy = value; } }
        private Value<string> _otherInformation;
        public string OtherInformation { get { return _otherInformation; } set { _otherInformation = value; } }
        private Value<string> _phoneForQuestion;
        public string PhoneForQuestion { get { return _phoneForQuestion; } set { _phoneForQuestion = value; } }
        private Value<string> _phoneToLimit;
        public string PhoneToLimit { get { return _phoneToLimit; } set { _phoneToLimit = value; } }
        private Value<string> _printSelection;
        public string PrintSelection { get { return _printSelection; } set { _printSelection = value; } }
        private Value<string> _shareInfoWithJointMarketing;
        public string ShareInfoWithJointMarketing { get { return _shareInfoWithJointMarketing; } set { _shareInfoWithJointMarketing = value; } }
        private Value<string> _timesToCollect1;
        public string TimesToCollect1 { get { return _timesToCollect1; } set { _timesToCollect1 = value; } }
        private Value<string> _timesToCollect2;
        public string TimesToCollect2 { get { return _timesToCollect2; } set { _timesToCollect2 = value; } }
        private Value<string> _timesToCollect3;
        public string TimesToCollect3 { get { return _timesToCollect3; } set { _timesToCollect3 = value; } }
        private Value<string> _timesToCollect4;
        public string TimesToCollect4 { get { return _timesToCollect4; } set { _timesToCollect4 = value; } }
        private Value<string> _timesToCollect5;
        public string TimesToCollect5 { get { return _timesToCollect5; } set { _timesToCollect5 = value; } }
        private Value<string> _websiteForQuestion;
        public string WebsiteForQuestion { get { return _websiteForQuestion; } set { _websiteForQuestion = value; } }
        private Value<string> _websiteToLimit;
        public string WebsiteToLimit { get { return _websiteToLimit; } set { _websiteToLimit = value; } }
        private Value<int?> _year;
        public int? Year { get { return _year; } set { _year = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _additionalRightsDescription.Clean
                    && _affiliateType.Clean
                    && _affiliateTypeExample1.Clean
                    && _affiliateTypeExample2.Clean
                    && _affiliateTypeExample3.Clean
                    && _alsoCollectFrom.Clean
                    && _daysToUse.Clean
                    && _howToShare.Clean
                    && _id.Clean
                    && _informationShare1.Clean
                    && _informationShare2.Clean
                    && _informationShare3.Clean
                    && _informationShare4.Clean
                    && _informationShare5.Clean
                    && _informationShare6.Clean
                    && _informationShare7.Clean
                    && _informationTypesWeCollect1.Clean
                    && _informationTypesWeCollect2.Clean
                    && _informationTypesWeCollect3.Clean
                    && _informationTypesWeCollect4.Clean
                    && _informationTypesWeCollect5.Clean
                    && _jointMarketType.Clean
                    && _jointMarketTypeExample1.Clean
                    && _limitSharing1.Clean
                    && _limitSharing2.Clean
                    && _limitSharing3.Clean
                    && _limitSharing4.Clean
                    && _limitSharing5.Clean
                    && _limitSharing6.Clean
                    && _limitSharing7.Clean
                    && _month.Clean
                    && _nonaffiliateType.Clean
                    && _nonaffiliateTypeExample1.Clean
                    && _notesForProtectPrivacy.Clean
                    && _otherInformation.Clean
                    && _phoneForQuestion.Clean
                    && _phoneToLimit.Clean
                    && _printSelection.Clean
                    && _shareInfoWithJointMarketing.Clean
                    && _timesToCollect1.Clean
                    && _timesToCollect2.Clean
                    && _timesToCollect3.Clean
                    && _timesToCollect4.Clean
                    && _timesToCollect5.Clean
                    && _websiteForQuestion.Clean
                    && _websiteToLimit.Clean
                    && _year.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var additionalRightsDescription = _additionalRightsDescription; additionalRightsDescription.Clean = value; _additionalRightsDescription = additionalRightsDescription;
                var affiliateType = _affiliateType; affiliateType.Clean = value; _affiliateType = affiliateType;
                var affiliateTypeExample1 = _affiliateTypeExample1; affiliateTypeExample1.Clean = value; _affiliateTypeExample1 = affiliateTypeExample1;
                var affiliateTypeExample2 = _affiliateTypeExample2; affiliateTypeExample2.Clean = value; _affiliateTypeExample2 = affiliateTypeExample2;
                var affiliateTypeExample3 = _affiliateTypeExample3; affiliateTypeExample3.Clean = value; _affiliateTypeExample3 = affiliateTypeExample3;
                var alsoCollectFrom = _alsoCollectFrom; alsoCollectFrom.Clean = value; _alsoCollectFrom = alsoCollectFrom;
                var daysToUse = _daysToUse; daysToUse.Clean = value; _daysToUse = daysToUse;
                var howToShare = _howToShare; howToShare.Clean = value; _howToShare = howToShare;
                var id = _id; id.Clean = value; _id = id;
                var informationShare1 = _informationShare1; informationShare1.Clean = value; _informationShare1 = informationShare1;
                var informationShare2 = _informationShare2; informationShare2.Clean = value; _informationShare2 = informationShare2;
                var informationShare3 = _informationShare3; informationShare3.Clean = value; _informationShare3 = informationShare3;
                var informationShare4 = _informationShare4; informationShare4.Clean = value; _informationShare4 = informationShare4;
                var informationShare5 = _informationShare5; informationShare5.Clean = value; _informationShare5 = informationShare5;
                var informationShare6 = _informationShare6; informationShare6.Clean = value; _informationShare6 = informationShare6;
                var informationShare7 = _informationShare7; informationShare7.Clean = value; _informationShare7 = informationShare7;
                var informationTypesWeCollect1 = _informationTypesWeCollect1; informationTypesWeCollect1.Clean = value; _informationTypesWeCollect1 = informationTypesWeCollect1;
                var informationTypesWeCollect2 = _informationTypesWeCollect2; informationTypesWeCollect2.Clean = value; _informationTypesWeCollect2 = informationTypesWeCollect2;
                var informationTypesWeCollect3 = _informationTypesWeCollect3; informationTypesWeCollect3.Clean = value; _informationTypesWeCollect3 = informationTypesWeCollect3;
                var informationTypesWeCollect4 = _informationTypesWeCollect4; informationTypesWeCollect4.Clean = value; _informationTypesWeCollect4 = informationTypesWeCollect4;
                var informationTypesWeCollect5 = _informationTypesWeCollect5; informationTypesWeCollect5.Clean = value; _informationTypesWeCollect5 = informationTypesWeCollect5;
                var jointMarketType = _jointMarketType; jointMarketType.Clean = value; _jointMarketType = jointMarketType;
                var jointMarketTypeExample1 = _jointMarketTypeExample1; jointMarketTypeExample1.Clean = value; _jointMarketTypeExample1 = jointMarketTypeExample1;
                var limitSharing1 = _limitSharing1; limitSharing1.Clean = value; _limitSharing1 = limitSharing1;
                var limitSharing2 = _limitSharing2; limitSharing2.Clean = value; _limitSharing2 = limitSharing2;
                var limitSharing3 = _limitSharing3; limitSharing3.Clean = value; _limitSharing3 = limitSharing3;
                var limitSharing4 = _limitSharing4; limitSharing4.Clean = value; _limitSharing4 = limitSharing4;
                var limitSharing5 = _limitSharing5; limitSharing5.Clean = value; _limitSharing5 = limitSharing5;
                var limitSharing6 = _limitSharing6; limitSharing6.Clean = value; _limitSharing6 = limitSharing6;
                var limitSharing7 = _limitSharing7; limitSharing7.Clean = value; _limitSharing7 = limitSharing7;
                var month = _month; month.Clean = value; _month = month;
                var nonaffiliateType = _nonaffiliateType; nonaffiliateType.Clean = value; _nonaffiliateType = nonaffiliateType;
                var nonaffiliateTypeExample1 = _nonaffiliateTypeExample1; nonaffiliateTypeExample1.Clean = value; _nonaffiliateTypeExample1 = nonaffiliateTypeExample1;
                var notesForProtectPrivacy = _notesForProtectPrivacy; notesForProtectPrivacy.Clean = value; _notesForProtectPrivacy = notesForProtectPrivacy;
                var otherInformation = _otherInformation; otherInformation.Clean = value; _otherInformation = otherInformation;
                var phoneForQuestion = _phoneForQuestion; phoneForQuestion.Clean = value; _phoneForQuestion = phoneForQuestion;
                var phoneToLimit = _phoneToLimit; phoneToLimit.Clean = value; _phoneToLimit = phoneToLimit;
                var printSelection = _printSelection; printSelection.Clean = value; _printSelection = printSelection;
                var shareInfoWithJointMarketing = _shareInfoWithJointMarketing; shareInfoWithJointMarketing.Clean = value; _shareInfoWithJointMarketing = shareInfoWithJointMarketing;
                var timesToCollect1 = _timesToCollect1; timesToCollect1.Clean = value; _timesToCollect1 = timesToCollect1;
                var timesToCollect2 = _timesToCollect2; timesToCollect2.Clean = value; _timesToCollect2 = timesToCollect2;
                var timesToCollect3 = _timesToCollect3; timesToCollect3.Clean = value; _timesToCollect3 = timesToCollect3;
                var timesToCollect4 = _timesToCollect4; timesToCollect4.Clean = value; _timesToCollect4 = timesToCollect4;
                var timesToCollect5 = _timesToCollect5; timesToCollect5.Clean = value; _timesToCollect5 = timesToCollect5;
                var websiteForQuestion = _websiteForQuestion; websiteForQuestion.Clean = value; _websiteForQuestion = websiteForQuestion;
                var websiteToLimit = _websiteToLimit; websiteToLimit.Clean = value; _websiteToLimit = websiteToLimit;
                var year = _year; year.Clean = value; _year = year;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public PrivacyPolicy()
        {
            Clean = true;
        }
    }
}