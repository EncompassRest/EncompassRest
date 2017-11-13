using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    [JsonConverter(typeof(PublicallySerializableConverter))]
    public sealed partial class PrivacyPolicy : IDirty
    {
        private DirtyValue<string> _additionalRightsDescription;
        public string AdditionalRightsDescription { get => _additionalRightsDescription; set => _additionalRightsDescription = value; }
        private StringEnumValue<AffiliateType> _affiliateType;
        public StringEnumValue<AffiliateType> AffiliateType { get => _affiliateType; set => _affiliateType = value; }
        private DirtyValue<string> _affiliateTypeExample1;
        public string AffiliateTypeExample1 { get => _affiliateTypeExample1; set => _affiliateTypeExample1 = value; }
        private DirtyValue<string> _affiliateTypeExample2;
        public string AffiliateTypeExample2 { get => _affiliateTypeExample2; set => _affiliateTypeExample2 = value; }
        private DirtyValue<string> _affiliateTypeExample3;
        public string AffiliateTypeExample3 { get => _affiliateTypeExample3; set => _affiliateTypeExample3 = value; }
        private StringEnumValue<AlsoCollectFrom> _alsoCollectFrom;
        public StringEnumValue<AlsoCollectFrom> AlsoCollectFrom { get => _alsoCollectFrom; set => _alsoCollectFrom = value; }
        private DirtyValue<int?> _daysToUse;
        public int? DaysToUse { get => _daysToUse; set => _daysToUse = value; }
        private StringEnumValue<HowToShare> _howToShare;
        public StringEnumValue<HowToShare> HowToShare { get => _howToShare; set => _howToShare = value; }
        private DirtyValue<string> _id;
        public string Id { get => _id; set => _id = value; }
        private StringEnumValue<YesOrNo> _informationShare1;
        public StringEnumValue<YesOrNo> InformationShare1 { get => _informationShare1; set => _informationShare1 = value; }
        private StringEnumValue<YesOrNo> _informationShare2;
        public StringEnumValue<YesOrNo> InformationShare2 { get => _informationShare2; set => _informationShare2 = value; }
        private StringEnumValue<YesOrNo> _informationShare3;
        public StringEnumValue<YesOrNo> InformationShare3 { get => _informationShare3; set => _informationShare3 = value; }
        private StringEnumValue<YesOrNo> _informationShare4;
        public StringEnumValue<YesOrNo> InformationShare4 { get => _informationShare4; set => _informationShare4 = value; }
        private StringEnumValue<YesOrNo> _informationShare5;
        public StringEnumValue<YesOrNo> InformationShare5 { get => _informationShare5; set => _informationShare5 = value; }
        private StringEnumValue<YesOrNo> _informationShare6;
        public StringEnumValue<YesOrNo> InformationShare6 { get => _informationShare6; set => _informationShare6 = value; }
        private StringEnumValue<YesOrNo> _informationShare7;
        public StringEnumValue<YesOrNo> InformationShare7 { get => _informationShare7; set => _informationShare7 = value; }
        private StringEnumValue<InformationTypesWeCollect> _informationTypesWeCollect1;
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect1 { get => _informationTypesWeCollect1; set => _informationTypesWeCollect1 = value; }
        private StringEnumValue<InformationTypesWeCollect> _informationTypesWeCollect2;
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect2 { get => _informationTypesWeCollect2; set => _informationTypesWeCollect2 = value; }
        private StringEnumValue<InformationTypesWeCollect> _informationTypesWeCollect3;
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect3 { get => _informationTypesWeCollect3; set => _informationTypesWeCollect3 = value; }
        private StringEnumValue<InformationTypesWeCollect> _informationTypesWeCollect4;
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect4 { get => _informationTypesWeCollect4; set => _informationTypesWeCollect4 = value; }
        private StringEnumValue<InformationTypesWeCollect> _informationTypesWeCollect5;
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect5 { get => _informationTypesWeCollect5; set => _informationTypesWeCollect5 = value; }
        private StringEnumValue<JointMarketType> _jointMarketType;
        public StringEnumValue<JointMarketType> JointMarketType { get => _jointMarketType; set => _jointMarketType = value; }
        private DirtyValue<string> _jointMarketTypeExample1;
        public string JointMarketTypeExample1 { get => _jointMarketTypeExample1; set => _jointMarketTypeExample1 = value; }
        private StringEnumValue<LimitSharing> _limitSharing1;
        public StringEnumValue<LimitSharing> LimitSharing1 { get => _limitSharing1; set => _limitSharing1 = value; }
        private StringEnumValue<LimitSharing> _limitSharing2;
        public StringEnumValue<LimitSharing> LimitSharing2 { get => _limitSharing2; set => _limitSharing2 = value; }
        private StringEnumValue<LimitSharing> _limitSharing3;
        public StringEnumValue<LimitSharing> LimitSharing3 { get => _limitSharing3; set => _limitSharing3 = value; }
        private StringEnumValue<LimitSharing> _limitSharing4;
        public StringEnumValue<LimitSharing> LimitSharing4 { get => _limitSharing4; set => _limitSharing4 = value; }
        private StringEnumValue<LimitSharing> _limitSharing5;
        public StringEnumValue<LimitSharing> LimitSharing5 { get => _limitSharing5; set => _limitSharing5 = value; }
        private StringEnumValue<LimitSharing> _limitSharing6;
        public StringEnumValue<LimitSharing> LimitSharing6 { get => _limitSharing6; set => _limitSharing6 = value; }
        private StringEnumValue<LimitSharing> _limitSharing7;
        public StringEnumValue<LimitSharing> LimitSharing7 { get => _limitSharing7; set => _limitSharing7 = value; }
        private StringEnumValue<Month> _month;
        public StringEnumValue<Month> Month { get => _month; set => _month = value; }
        private StringEnumValue<NonaffiliateType> _nonaffiliateType;
        public StringEnumValue<NonaffiliateType> NonaffiliateType { get => _nonaffiliateType; set => _nonaffiliateType = value; }
        private DirtyValue<string> _nonaffiliateTypeExample1;
        public string NonaffiliateTypeExample1 { get => _nonaffiliateTypeExample1; set => _nonaffiliateTypeExample1 = value; }
        private DirtyValue<string> _notesForProtectPrivacy;
        public string NotesForProtectPrivacy { get => _notesForProtectPrivacy; set => _notesForProtectPrivacy = value; }
        private DirtyValue<string> _otherInformation;
        public string OtherInformation { get => _otherInformation; set => _otherInformation = value; }
        private DirtyValue<string> _phoneForQuestion;
        public string PhoneForQuestion { get => _phoneForQuestion; set => _phoneForQuestion = value; }
        private DirtyValue<string> _phoneToLimit;
        public string PhoneToLimit { get => _phoneToLimit; set => _phoneToLimit = value; }
        private StringEnumValue<PrintSelection> _printSelection;
        public StringEnumValue<PrintSelection> PrintSelection { get => _printSelection; set => _printSelection = value; }
        private StringEnumValue<ShareInfoWithJointMarketing> _shareInfoWithJointMarketing;
        public StringEnumValue<ShareInfoWithJointMarketing> ShareInfoWithJointMarketing { get => _shareInfoWithJointMarketing; set => _shareInfoWithJointMarketing = value; }
        private StringEnumValue<TimesToCollect> _timesToCollect1;
        public StringEnumValue<TimesToCollect> TimesToCollect1 { get => _timesToCollect1; set => _timesToCollect1 = value; }
        private StringEnumValue<TimesToCollect> _timesToCollect2;
        public StringEnumValue<TimesToCollect> TimesToCollect2 { get => _timesToCollect2; set => _timesToCollect2 = value; }
        private StringEnumValue<TimesToCollect> _timesToCollect3;
        public StringEnumValue<TimesToCollect> TimesToCollect3 { get => _timesToCollect3; set => _timesToCollect3 = value; }
        private StringEnumValue<TimesToCollect> _timesToCollect4;
        public StringEnumValue<TimesToCollect> TimesToCollect4 { get => _timesToCollect4; set => _timesToCollect4 = value; }
        private StringEnumValue<TimesToCollect> _timesToCollect5;
        public StringEnumValue<TimesToCollect> TimesToCollect5 { get => _timesToCollect5; set => _timesToCollect5 = value; }
        private DirtyValue<string> _websiteForQuestion;
        public string WebsiteForQuestion { get => _websiteForQuestion; set => _websiteForQuestion = value; }
        private DirtyValue<string> _websiteToLimit;
        public string WebsiteToLimit { get => _websiteToLimit; set => _websiteToLimit = value; }
        private DirtyValue<int?> _year;
        public int? Year { get => _year; set => _year = value; }
        private DirtyDictionary<string, object> _extensionData;
        public IDictionary<string, object> ExtensionData { get => _extensionData ?? (_extensionData = new DirtyDictionary<string, object>()); set => _extensionData = new DirtyDictionary<string, object>(value); }
        private bool _gettingDirty;
        private bool _settingDirty; 
        internal bool Dirty
        {
            get
            {
                if (_gettingDirty) return false;
                _gettingDirty = true;
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
                    || _year.Dirty
                    || _extensionData?.Dirty == true;
                _gettingDirty = false;
                return dirty;
            }
            set
            {
                if (_settingDirty) return;
                _settingDirty = true;
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
                if (_extensionData != null) _extensionData.Dirty = value;
                _settingDirty = false;
            }
        }
        bool IDirty.Dirty { get => Dirty; set => Dirty = value; }
    }
}