using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace EncompassRest.Loans
{
    public sealed partial class PrivacyPolicy
    {
        public Value<string> AdditionalRightsDescription { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAdditionalRightsDescription() => !AdditionalRightsDescription.Clean;
        public Value<string> AffiliateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateType() => !AffiliateType.Clean;
        public Value<string> AffiliateTypeExample1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateTypeExample1() => !AffiliateTypeExample1.Clean;
        public Value<string> AffiliateTypeExample2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateTypeExample2() => !AffiliateTypeExample2.Clean;
        public Value<string> AffiliateTypeExample3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAffiliateTypeExample3() => !AffiliateTypeExample3.Clean;
        public Value<string> AlsoCollectFrom { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeAlsoCollectFrom() => !AlsoCollectFrom.Clean;
        public Value<int?> DaysToUse { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeDaysToUse() => !DaysToUse.Clean;
        public Value<string> HowToShare { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeHowToShare() => !HowToShare.Clean;
        public Value<string> Id { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeId() => !Id.Clean;
        public Value<string> InformationShare1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare1() => !InformationShare1.Clean;
        public Value<string> InformationShare2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare2() => !InformationShare2.Clean;
        public Value<string> InformationShare3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare3() => !InformationShare3.Clean;
        public Value<string> InformationShare4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare4() => !InformationShare4.Clean;
        public Value<string> InformationShare5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare5() => !InformationShare5.Clean;
        public Value<string> InformationShare6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare6() => !InformationShare6.Clean;
        public Value<string> InformationShare7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationShare7() => !InformationShare7.Clean;
        public Value<string> InformationTypesWeCollect1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationTypesWeCollect1() => !InformationTypesWeCollect1.Clean;
        public Value<string> InformationTypesWeCollect2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationTypesWeCollect2() => !InformationTypesWeCollect2.Clean;
        public Value<string> InformationTypesWeCollect3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationTypesWeCollect3() => !InformationTypesWeCollect3.Clean;
        public Value<string> InformationTypesWeCollect4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationTypesWeCollect4() => !InformationTypesWeCollect4.Clean;
        public Value<string> InformationTypesWeCollect5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeInformationTypesWeCollect5() => !InformationTypesWeCollect5.Clean;
        public Value<string> JointMarketType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeJointMarketType() => !JointMarketType.Clean;
        public Value<string> JointMarketTypeExample1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeJointMarketTypeExample1() => !JointMarketTypeExample1.Clean;
        public Value<string> LimitSharing1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing1() => !LimitSharing1.Clean;
        public Value<string> LimitSharing2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing2() => !LimitSharing2.Clean;
        public Value<string> LimitSharing3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing3() => !LimitSharing3.Clean;
        public Value<string> LimitSharing4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing4() => !LimitSharing4.Clean;
        public Value<string> LimitSharing5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing5() => !LimitSharing5.Clean;
        public Value<string> LimitSharing6 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing6() => !LimitSharing6.Clean;
        public Value<string> LimitSharing7 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeLimitSharing7() => !LimitSharing7.Clean;
        public Value<string> NonaffiliateType { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonaffiliateType() => !NonaffiliateType.Clean;
        public Value<string> NonaffiliateTypeExample1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNonaffiliateTypeExample1() => !NonaffiliateTypeExample1.Clean;
        public Value<string> NotesForProtectPrivacy { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeNotesForProtectPrivacy() => !NotesForProtectPrivacy.Clean;
        public Value<string> OtherInformation { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeOtherInformation() => !OtherInformation.Clean;
        public Value<string> PhoneForQuestion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhoneForQuestion() => !PhoneForQuestion.Clean;
        public Value<string> PhoneToLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePhoneToLimit() => !PhoneToLimit.Clean;
        public Value<string> PrintSelection { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializePrintSelection() => !PrintSelection.Clean;
        public Value<string> ShareInfoWithJointMarketing { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeShareInfoWithJointMarketing() => !ShareInfoWithJointMarketing.Clean;
        public Value<string> TimesToCollect1 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimesToCollect1() => !TimesToCollect1.Clean;
        public Value<string> TimesToCollect2 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimesToCollect2() => !TimesToCollect2.Clean;
        public Value<string> TimesToCollect3 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimesToCollect3() => !TimesToCollect3.Clean;
        public Value<string> TimesToCollect4 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimesToCollect4() => !TimesToCollect4.Clean;
        public Value<string> TimesToCollect5 { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeTimesToCollect5() => !TimesToCollect5.Clean;
        public Value<string> WebsiteForQuestion { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWebsiteForQuestion() => !WebsiteForQuestion.Clean;
        public Value<string> WebsiteToLimit { get; set; }
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool ShouldSerializeWebsiteToLimit() => !WebsiteToLimit.Clean;
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = AdditionalRightsDescription.Clean
                    && AffiliateType.Clean
                    && AffiliateTypeExample1.Clean
                    && AffiliateTypeExample2.Clean
                    && AffiliateTypeExample3.Clean
                    && AlsoCollectFrom.Clean
                    && DaysToUse.Clean
                    && HowToShare.Clean
                    && Id.Clean
                    && InformationShare1.Clean
                    && InformationShare2.Clean
                    && InformationShare3.Clean
                    && InformationShare4.Clean
                    && InformationShare5.Clean
                    && InformationShare6.Clean
                    && InformationShare7.Clean
                    && InformationTypesWeCollect1.Clean
                    && InformationTypesWeCollect2.Clean
                    && InformationTypesWeCollect3.Clean
                    && InformationTypesWeCollect4.Clean
                    && InformationTypesWeCollect5.Clean
                    && JointMarketType.Clean
                    && JointMarketTypeExample1.Clean
                    && LimitSharing1.Clean
                    && LimitSharing2.Clean
                    && LimitSharing3.Clean
                    && LimitSharing4.Clean
                    && LimitSharing5.Clean
                    && LimitSharing6.Clean
                    && LimitSharing7.Clean
                    && NonaffiliateType.Clean
                    && NonaffiliateTypeExample1.Clean
                    && NotesForProtectPrivacy.Clean
                    && OtherInformation.Clean
                    && PhoneForQuestion.Clean
                    && PhoneToLimit.Clean
                    && PrintSelection.Clean
                    && ShareInfoWithJointMarketing.Clean
                    && TimesToCollect1.Clean
                    && TimesToCollect2.Clean
                    && TimesToCollect3.Clean
                    && TimesToCollect4.Clean
                    && TimesToCollect5.Clean
                    && WebsiteForQuestion.Clean
                    && WebsiteToLimit.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = AdditionalRightsDescription; v0.Clean = value; AdditionalRightsDescription = v0;
                var v1 = AffiliateType; v1.Clean = value; AffiliateType = v1;
                var v2 = AffiliateTypeExample1; v2.Clean = value; AffiliateTypeExample1 = v2;
                var v3 = AffiliateTypeExample2; v3.Clean = value; AffiliateTypeExample2 = v3;
                var v4 = AffiliateTypeExample3; v4.Clean = value; AffiliateTypeExample3 = v4;
                var v5 = AlsoCollectFrom; v5.Clean = value; AlsoCollectFrom = v5;
                var v6 = DaysToUse; v6.Clean = value; DaysToUse = v6;
                var v7 = HowToShare; v7.Clean = value; HowToShare = v7;
                var v8 = Id; v8.Clean = value; Id = v8;
                var v9 = InformationShare1; v9.Clean = value; InformationShare1 = v9;
                var v10 = InformationShare2; v10.Clean = value; InformationShare2 = v10;
                var v11 = InformationShare3; v11.Clean = value; InformationShare3 = v11;
                var v12 = InformationShare4; v12.Clean = value; InformationShare4 = v12;
                var v13 = InformationShare5; v13.Clean = value; InformationShare5 = v13;
                var v14 = InformationShare6; v14.Clean = value; InformationShare6 = v14;
                var v15 = InformationShare7; v15.Clean = value; InformationShare7 = v15;
                var v16 = InformationTypesWeCollect1; v16.Clean = value; InformationTypesWeCollect1 = v16;
                var v17 = InformationTypesWeCollect2; v17.Clean = value; InformationTypesWeCollect2 = v17;
                var v18 = InformationTypesWeCollect3; v18.Clean = value; InformationTypesWeCollect3 = v18;
                var v19 = InformationTypesWeCollect4; v19.Clean = value; InformationTypesWeCollect4 = v19;
                var v20 = InformationTypesWeCollect5; v20.Clean = value; InformationTypesWeCollect5 = v20;
                var v21 = JointMarketType; v21.Clean = value; JointMarketType = v21;
                var v22 = JointMarketTypeExample1; v22.Clean = value; JointMarketTypeExample1 = v22;
                var v23 = LimitSharing1; v23.Clean = value; LimitSharing1 = v23;
                var v24 = LimitSharing2; v24.Clean = value; LimitSharing2 = v24;
                var v25 = LimitSharing3; v25.Clean = value; LimitSharing3 = v25;
                var v26 = LimitSharing4; v26.Clean = value; LimitSharing4 = v26;
                var v27 = LimitSharing5; v27.Clean = value; LimitSharing5 = v27;
                var v28 = LimitSharing6; v28.Clean = value; LimitSharing6 = v28;
                var v29 = LimitSharing7; v29.Clean = value; LimitSharing7 = v29;
                var v30 = NonaffiliateType; v30.Clean = value; NonaffiliateType = v30;
                var v31 = NonaffiliateTypeExample1; v31.Clean = value; NonaffiliateTypeExample1 = v31;
                var v32 = NotesForProtectPrivacy; v32.Clean = value; NotesForProtectPrivacy = v32;
                var v33 = OtherInformation; v33.Clean = value; OtherInformation = v33;
                var v34 = PhoneForQuestion; v34.Clean = value; PhoneForQuestion = v34;
                var v35 = PhoneToLimit; v35.Clean = value; PhoneToLimit = v35;
                var v36 = PrintSelection; v36.Clean = value; PrintSelection = v36;
                var v37 = ShareInfoWithJointMarketing; v37.Clean = value; ShareInfoWithJointMarketing = v37;
                var v38 = TimesToCollect1; v38.Clean = value; TimesToCollect1 = v38;
                var v39 = TimesToCollect2; v39.Clean = value; TimesToCollect2 = v39;
                var v40 = TimesToCollect3; v40.Clean = value; TimesToCollect3 = v40;
                var v41 = TimesToCollect4; v41.Clean = value; TimesToCollect4 = v41;
                var v42 = TimesToCollect5; v42.Clean = value; TimesToCollect5 = v42;
                var v43 = WebsiteForQuestion; v43.Clean = value; WebsiteForQuestion = v43;
                var v44 = WebsiteToLimit; v44.Clean = value; WebsiteToLimit = v44;
                _settingClean = 0;
            }
        }
    }
}