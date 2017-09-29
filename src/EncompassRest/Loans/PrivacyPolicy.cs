using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class PrivacyPolicy : IDirty
    {
        private DirtyValue<string> _additionalRightsDescription;
        public string AdditionalRightsDescription { get { return _additionalRightsDescription; } set { _additionalRightsDescription = value; } }
        private DirtyValue<string> _affiliateType;
        public string AffiliateType { get { return _affiliateType; } set { _affiliateType = value; } }
        private DirtyValue<string> _affiliateTypeExample1;
        public string AffiliateTypeExample1 { get { return _affiliateTypeExample1; } set { _affiliateTypeExample1 = value; } }
        private DirtyValue<string> _affiliateTypeExample2;
        public string AffiliateTypeExample2 { get { return _affiliateTypeExample2; } set { _affiliateTypeExample2 = value; } }
        private DirtyValue<string> _affiliateTypeExample3;
        public string AffiliateTypeExample3 { get { return _affiliateTypeExample3; } set { _affiliateTypeExample3 = value; } }
        private DirtyValue<string> _alsoCollectFrom;
        public string AlsoCollectFrom { get { return _alsoCollectFrom; } set { _alsoCollectFrom = value; } }
        private DirtyValue<int?> _daysToUse;
        public int? DaysToUse { get { return _daysToUse; } set { _daysToUse = value; } }
        private DirtyValue<string> _howToShare;
        public string HowToShare { get { return _howToShare; } set { _howToShare = value; } }
        private DirtyValue<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private DirtyValue<string> _informationShare1;
        public string InformationShare1 { get { return _informationShare1; } set { _informationShare1 = value; } }
        private DirtyValue<string> _informationShare2;
        public string InformationShare2 { get { return _informationShare2; } set { _informationShare2 = value; } }
        private DirtyValue<string> _informationShare3;
        public string InformationShare3 { get { return _informationShare3; } set { _informationShare3 = value; } }
        private DirtyValue<string> _informationShare4;
        public string InformationShare4 { get { return _informationShare4; } set { _informationShare4 = value; } }
        private DirtyValue<string> _informationShare5;
        public string InformationShare5 { get { return _informationShare5; } set { _informationShare5 = value; } }
        private DirtyValue<string> _informationShare6;
        public string InformationShare6 { get { return _informationShare6; } set { _informationShare6 = value; } }
        private DirtyValue<string> _informationShare7;
        public string InformationShare7 { get { return _informationShare7; } set { _informationShare7 = value; } }
        private DirtyValue<string> _informationTypesWeCollect1;
        public string InformationTypesWeCollect1 { get { return _informationTypesWeCollect1; } set { _informationTypesWeCollect1 = value; } }
        private DirtyValue<string> _informationTypesWeCollect2;
        public string InformationTypesWeCollect2 { get { return _informationTypesWeCollect2; } set { _informationTypesWeCollect2 = value; } }
        private DirtyValue<string> _informationTypesWeCollect3;
        public string InformationTypesWeCollect3 { get { return _informationTypesWeCollect3; } set { _informationTypesWeCollect3 = value; } }
        private DirtyValue<string> _informationTypesWeCollect4;
        public string InformationTypesWeCollect4 { get { return _informationTypesWeCollect4; } set { _informationTypesWeCollect4 = value; } }
        private DirtyValue<string> _informationTypesWeCollect5;
        public string InformationTypesWeCollect5 { get { return _informationTypesWeCollect5; } set { _informationTypesWeCollect5 = value; } }
        private DirtyValue<string> _jointMarketType;
        public string JointMarketType { get { return _jointMarketType; } set { _jointMarketType = value; } }
        private DirtyValue<string> _jointMarketTypeExample1;
        public string JointMarketTypeExample1 { get { return _jointMarketTypeExample1; } set { _jointMarketTypeExample1 = value; } }
        private DirtyValue<string> _limitSharing1;
        public string LimitSharing1 { get { return _limitSharing1; } set { _limitSharing1 = value; } }
        private DirtyValue<string> _limitSharing2;
        public string LimitSharing2 { get { return _limitSharing2; } set { _limitSharing2 = value; } }
        private DirtyValue<string> _limitSharing3;
        public string LimitSharing3 { get { return _limitSharing3; } set { _limitSharing3 = value; } }
        private DirtyValue<string> _limitSharing4;
        public string LimitSharing4 { get { return _limitSharing4; } set { _limitSharing4 = value; } }
        private DirtyValue<string> _limitSharing5;
        public string LimitSharing5 { get { return _limitSharing5; } set { _limitSharing5 = value; } }
        private DirtyValue<string> _limitSharing6;
        public string LimitSharing6 { get { return _limitSharing6; } set { _limitSharing6 = value; } }
        private DirtyValue<string> _limitSharing7;
        public string LimitSharing7 { get { return _limitSharing7; } set { _limitSharing7 = value; } }
        private DirtyValue<string> _month;
        public string Month { get { return _month; } set { _month = value; } }
        private DirtyValue<string> _nonaffiliateType;
        public string NonaffiliateType { get { return _nonaffiliateType; } set { _nonaffiliateType = value; } }
        private DirtyValue<string> _nonaffiliateTypeExample1;
        public string NonaffiliateTypeExample1 { get { return _nonaffiliateTypeExample1; } set { _nonaffiliateTypeExample1 = value; } }
        private DirtyValue<string> _notesForProtectPrivacy;
        public string NotesForProtectPrivacy { get { return _notesForProtectPrivacy; } set { _notesForProtectPrivacy = value; } }
        private DirtyValue<string> _otherInformation;
        public string OtherInformation { get { return _otherInformation; } set { _otherInformation = value; } }
        private DirtyValue<string> _phoneForQuestion;
        public string PhoneForQuestion { get { return _phoneForQuestion; } set { _phoneForQuestion = value; } }
        private DirtyValue<string> _phoneToLimit;
        public string PhoneToLimit { get { return _phoneToLimit; } set { _phoneToLimit = value; } }
        private DirtyValue<string> _printSelection;
        public string PrintSelection { get { return _printSelection; } set { _printSelection = value; } }
        private DirtyValue<string> _shareInfoWithJointMarketing;
        public string ShareInfoWithJointMarketing { get { return _shareInfoWithJointMarketing; } set { _shareInfoWithJointMarketing = value; } }
        private DirtyValue<string> _timesToCollect1;
        public string TimesToCollect1 { get { return _timesToCollect1; } set { _timesToCollect1 = value; } }
        private DirtyValue<string> _timesToCollect2;
        public string TimesToCollect2 { get { return _timesToCollect2; } set { _timesToCollect2 = value; } }
        private DirtyValue<string> _timesToCollect3;
        public string TimesToCollect3 { get { return _timesToCollect3; } set { _timesToCollect3 = value; } }
        private DirtyValue<string> _timesToCollect4;
        public string TimesToCollect4 { get { return _timesToCollect4; } set { _timesToCollect4 = value; } }
        private DirtyValue<string> _timesToCollect5;
        public string TimesToCollect5 { get { return _timesToCollect5; } set { _timesToCollect5 = value; } }
        private DirtyValue<string> _websiteForQuestion;
        public string WebsiteForQuestion { get { return _websiteForQuestion; } set { _websiteForQuestion = value; } }
        private DirtyValue<string> _websiteToLimit;
        public string WebsiteToLimit { get { return _websiteToLimit; } set { _websiteToLimit = value; } }
        private DirtyValue<int?> _year;
        public int? Year { get { return _year; } set { _year = value; } }
        private int _gettingDirty;
        private int _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingDirty, 1, 0) != 0) return false;
                var dirty = _additionalRightsDescription.Dirty
                    || _affiliateType.Dirty
                    || _affiliateTypeExample1.Dirty
                    || _affiliateTypeExample2.Dirty
                    || _affiliateTypeExample3.Dirty
                    || _alsoCollectFrom.Dirty
                    || _daysToUse.Dirty
                    || _howToShare.Dirty
                    || _id.Dirty
                    || _informationShare1.Dirty
                    || _informationShare2.Dirty
                    || _informationShare3.Dirty
                    || _informationShare4.Dirty
                    || _informationShare5.Dirty
                    || _informationShare6.Dirty
                    || _informationShare7.Dirty
                    || _informationTypesWeCollect1.Dirty
                    || _informationTypesWeCollect2.Dirty
                    || _informationTypesWeCollect3.Dirty
                    || _informationTypesWeCollect4.Dirty
                    || _informationTypesWeCollect5.Dirty
                    || _jointMarketType.Dirty
                    || _jointMarketTypeExample1.Dirty
                    || _limitSharing1.Dirty
                    || _limitSharing2.Dirty
                    || _limitSharing3.Dirty
                    || _limitSharing4.Dirty
                    || _limitSharing5.Dirty
                    || _limitSharing6.Dirty
                    || _limitSharing7.Dirty
                    || _month.Dirty
                    || _nonaffiliateType.Dirty
                    || _nonaffiliateTypeExample1.Dirty
                    || _notesForProtectPrivacy.Dirty
                    || _otherInformation.Dirty
                    || _phoneForQuestion.Dirty
                    || _phoneToLimit.Dirty
                    || _printSelection.Dirty
                    || _shareInfoWithJointMarketing.Dirty
                    || _timesToCollect1.Dirty
                    || _timesToCollect2.Dirty
                    || _timesToCollect3.Dirty
                    || _timesToCollect4.Dirty
                    || _timesToCollect5.Dirty
                    || _websiteForQuestion.Dirty
                    || _websiteToLimit.Dirty
                    || _year.Dirty;
                _gettingDirty = 0;
                return dirty;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingDirty, 1, 0) != 0) return;
                _additionalRightsDescription.Dirty = value;
                _affiliateType.Dirty = value;
                _affiliateTypeExample1.Dirty = value;
                _affiliateTypeExample2.Dirty = value;
                _affiliateTypeExample3.Dirty = value;
                _alsoCollectFrom.Dirty = value;
                _daysToUse.Dirty = value;
                _howToShare.Dirty = value;
                _id.Dirty = value;
                _informationShare1.Dirty = value;
                _informationShare2.Dirty = value;
                _informationShare3.Dirty = value;
                _informationShare4.Dirty = value;
                _informationShare5.Dirty = value;
                _informationShare6.Dirty = value;
                _informationShare7.Dirty = value;
                _informationTypesWeCollect1.Dirty = value;
                _informationTypesWeCollect2.Dirty = value;
                _informationTypesWeCollect3.Dirty = value;
                _informationTypesWeCollect4.Dirty = value;
                _informationTypesWeCollect5.Dirty = value;
                _jointMarketType.Dirty = value;
                _jointMarketTypeExample1.Dirty = value;
                _limitSharing1.Dirty = value;
                _limitSharing2.Dirty = value;
                _limitSharing3.Dirty = value;
                _limitSharing4.Dirty = value;
                _limitSharing5.Dirty = value;
                _limitSharing6.Dirty = value;
                _limitSharing7.Dirty = value;
                _month.Dirty = value;
                _nonaffiliateType.Dirty = value;
                _nonaffiliateTypeExample1.Dirty = value;
                _notesForProtectPrivacy.Dirty = value;
                _otherInformation.Dirty = value;
                _phoneForQuestion.Dirty = value;
                _phoneToLimit.Dirty = value;
                _printSelection.Dirty = value;
                _shareInfoWithJointMarketing.Dirty = value;
                _timesToCollect1.Dirty = value;
                _timesToCollect2.Dirty = value;
                _timesToCollect3.Dirty = value;
                _timesToCollect4.Dirty = value;
                _timesToCollect5.Dirty = value;
                _websiteForQuestion.Dirty = value;
                _websiteToLimit.Dirty = value;
                _year.Dirty = value;
                _settingDirty = 0;
            }
        }
        bool IDirty.Dirty { get { return Dirty; } set { Dirty = value; } }
    }
}