using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

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
                    && _websiteToLimit.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _additionalRightsDescription; v0.Clean = value; _additionalRightsDescription = v0;
                var v1 = _affiliateType; v1.Clean = value; _affiliateType = v1;
                var v2 = _affiliateTypeExample1; v2.Clean = value; _affiliateTypeExample1 = v2;
                var v3 = _affiliateTypeExample2; v3.Clean = value; _affiliateTypeExample2 = v3;
                var v4 = _affiliateTypeExample3; v4.Clean = value; _affiliateTypeExample3 = v4;
                var v5 = _alsoCollectFrom; v5.Clean = value; _alsoCollectFrom = v5;
                var v6 = _daysToUse; v6.Clean = value; _daysToUse = v6;
                var v7 = _howToShare; v7.Clean = value; _howToShare = v7;
                var v8 = _id; v8.Clean = value; _id = v8;
                var v9 = _informationShare1; v9.Clean = value; _informationShare1 = v9;
                var v10 = _informationShare2; v10.Clean = value; _informationShare2 = v10;
                var v11 = _informationShare3; v11.Clean = value; _informationShare3 = v11;
                var v12 = _informationShare4; v12.Clean = value; _informationShare4 = v12;
                var v13 = _informationShare5; v13.Clean = value; _informationShare5 = v13;
                var v14 = _informationShare6; v14.Clean = value; _informationShare6 = v14;
                var v15 = _informationShare7; v15.Clean = value; _informationShare7 = v15;
                var v16 = _informationTypesWeCollect1; v16.Clean = value; _informationTypesWeCollect1 = v16;
                var v17 = _informationTypesWeCollect2; v17.Clean = value; _informationTypesWeCollect2 = v17;
                var v18 = _informationTypesWeCollect3; v18.Clean = value; _informationTypesWeCollect3 = v18;
                var v19 = _informationTypesWeCollect4; v19.Clean = value; _informationTypesWeCollect4 = v19;
                var v20 = _informationTypesWeCollect5; v20.Clean = value; _informationTypesWeCollect5 = v20;
                var v21 = _jointMarketType; v21.Clean = value; _jointMarketType = v21;
                var v22 = _jointMarketTypeExample1; v22.Clean = value; _jointMarketTypeExample1 = v22;
                var v23 = _limitSharing1; v23.Clean = value; _limitSharing1 = v23;
                var v24 = _limitSharing2; v24.Clean = value; _limitSharing2 = v24;
                var v25 = _limitSharing3; v25.Clean = value; _limitSharing3 = v25;
                var v26 = _limitSharing4; v26.Clean = value; _limitSharing4 = v26;
                var v27 = _limitSharing5; v27.Clean = value; _limitSharing5 = v27;
                var v28 = _limitSharing6; v28.Clean = value; _limitSharing6 = v28;
                var v29 = _limitSharing7; v29.Clean = value; _limitSharing7 = v29;
                var v30 = _nonaffiliateType; v30.Clean = value; _nonaffiliateType = v30;
                var v31 = _nonaffiliateTypeExample1; v31.Clean = value; _nonaffiliateTypeExample1 = v31;
                var v32 = _notesForProtectPrivacy; v32.Clean = value; _notesForProtectPrivacy = v32;
                var v33 = _otherInformation; v33.Clean = value; _otherInformation = v33;
                var v34 = _phoneForQuestion; v34.Clean = value; _phoneForQuestion = v34;
                var v35 = _phoneToLimit; v35.Clean = value; _phoneToLimit = v35;
                var v36 = _printSelection; v36.Clean = value; _printSelection = v36;
                var v37 = _shareInfoWithJointMarketing; v37.Clean = value; _shareInfoWithJointMarketing = v37;
                var v38 = _timesToCollect1; v38.Clean = value; _timesToCollect1 = v38;
                var v39 = _timesToCollect2; v39.Clean = value; _timesToCollect2 = v39;
                var v40 = _timesToCollect3; v40.Clean = value; _timesToCollect3 = v40;
                var v41 = _timesToCollect4; v41.Clean = value; _timesToCollect4 = v41;
                var v42 = _timesToCollect5; v42.Clean = value; _timesToCollect5 = v42;
                var v43 = _websiteForQuestion; v43.Clean = value; _websiteForQuestion = v43;
                var v44 = _websiteToLimit; v44.Clean = value; _websiteToLimit = v44;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
    }
}