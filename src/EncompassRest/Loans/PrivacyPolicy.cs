using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// PrivacyPolicy
    /// </summary>
    public sealed partial class PrivacyPolicy : DirtyExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _additionalRightsDescription;
        private DirtyValue<StringEnumValue<AffiliateType>> _affiliateType;
        private DirtyValue<string> _affiliateTypeExample1;
        private DirtyValue<string> _affiliateTypeExample2;
        private DirtyValue<string> _affiliateTypeExample3;
        private DirtyValue<StringEnumValue<AlsoCollectFrom>> _alsoCollectFrom;
        private DirtyValue<int?> _daysToUse;
        private DirtyValue<StringEnumValue<HowToShare>> _howToShare;
        private DirtyValue<string> _id;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare1;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare2;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare3;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare4;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare5;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare6;
        private DirtyValue<StringEnumValue<YesOrNo>> _informationShare7;
        private DirtyValue<StringEnumValue<InformationTypesWeCollect>> _informationTypesWeCollect1;
        private DirtyValue<StringEnumValue<InformationTypesWeCollect>> _informationTypesWeCollect2;
        private DirtyValue<StringEnumValue<InformationTypesWeCollect>> _informationTypesWeCollect3;
        private DirtyValue<StringEnumValue<InformationTypesWeCollect>> _informationTypesWeCollect4;
        private DirtyValue<StringEnumValue<InformationTypesWeCollect>> _informationTypesWeCollect5;
        private DirtyValue<StringEnumValue<JointMarketType>> _jointMarketType;
        private DirtyValue<string> _jointMarketTypeExample1;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing1;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing2;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing3;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing4;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing5;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing6;
        private DirtyValue<StringEnumValue<LimitSharing>> _limitSharing7;
        private DirtyValue<StringEnumValue<Month>> _month;
        private DirtyValue<StringEnumValue<NonaffiliateType>> _nonaffiliateType;
        private DirtyValue<string> _nonaffiliateTypeExample1;
        private DirtyValue<string> _notesForProtectPrivacy;
        private DirtyValue<string> _otherInformation;
        private DirtyValue<string> _phoneForQuestion;
        private DirtyValue<string> _phoneToLimit;
        private DirtyValue<StringEnumValue<PrintSelection>> _printSelection;
        private DirtyValue<StringEnumValue<ShareInfoWithJointMarketing>> _shareInfoWithJointMarketing;
        private DirtyValue<StringEnumValue<TimesToCollect>> _timesToCollect1;
        private DirtyValue<StringEnumValue<TimesToCollect>> _timesToCollect2;
        private DirtyValue<StringEnumValue<TimesToCollect>> _timesToCollect3;
        private DirtyValue<StringEnumValue<TimesToCollect>> _timesToCollect4;
        private DirtyValue<StringEnumValue<TimesToCollect>> _timesToCollect5;
        private DirtyValue<string> _websiteForQuestion;
        private DirtyValue<string> _websiteToLimit;
        private DirtyValue<int?> _year;

        /// <summary>
        /// Privacy Policy Information Describe Additional Rights to Limit Sharing [NOTICES.X78]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Describe Additional Rights to Limit Sharing")]
        public string AdditionalRightsDescription { get => _additionalRightsDescription; set => SetField(ref _additionalRightsDescription, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Affiliates? [NOTICES.X79]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Affiliates?")]
        public StringEnumValue<AffiliateType> AffiliateType { get => _affiliateType; set => SetField(ref _affiliateType, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Affiliates Example 1 [NOTICES.X80]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Affiliates Example 1")]
        public string AffiliateTypeExample1 { get => _affiliateTypeExample1; set => SetField(ref _affiliateTypeExample1, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Affiliates Example 2 [NOTICES.X81]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Affiliates Example 2")]
        public string AffiliateTypeExample2 { get => _affiliateTypeExample2; set => SetField(ref _affiliateTypeExample2, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Affiliates Example 3 [NOTICES.X82]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Affiliates Example 3")]
        public string AffiliateTypeExample3 { get => _affiliateTypeExample3; set => SetField(ref _affiliateTypeExample3, value); }

        /// <summary>
        /// Privacy Policy Information Institutions that collect personal information from their affiliates and credit bureaus [NOTICES.X94]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Institutions that collect personal information from their affiliates and credit bureaus")]
        public StringEnumValue<AlsoCollectFrom> AlsoCollectFrom { get => _alsoCollectFrom; set => SetField(ref _alsoCollectFrom, value); }

        /// <summary>
        /// Privacy Policy Information Number of Days After Providing Notice Can We Begin Sharing Information (must be more than 30) [NOTICES.X91]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Number of Days After Providing Notice Can We Begin Sharing Information (must be more than 30)")]
        public int? DaysToUse { get => _daysToUse; set => SetField(ref _daysToUse, value); }

        /// <summary>
        /// Privacy Policy How to Share Customer or Member [NOTICES.X57]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy How to Share Customer or Member")]
        public StringEnumValue<HowToShare> HowToShare { get => _howToShare; set => SetField(ref _howToShare, value); }

        /// <summary>
        /// PrivacyPolicy Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 1 [NOTICES.X58]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 1")]
        public StringEnumValue<YesOrNo> InformationShare1 { get => _informationShare1; set => SetField(ref _informationShare1, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 2 [NOTICES.X59]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 2")]
        public StringEnumValue<YesOrNo> InformationShare2 { get => _informationShare2; set => SetField(ref _informationShare2, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 3 [NOTICES.X60]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 3")]
        public StringEnumValue<YesOrNo> InformationShare3 { get => _informationShare3; set => SetField(ref _informationShare3, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 4 [NOTICES.X61]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 4")]
        public StringEnumValue<YesOrNo> InformationShare4 { get => _informationShare4; set => SetField(ref _informationShare4, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 5 [NOTICES.X62]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 5")]
        public StringEnumValue<YesOrNo> InformationShare5 { get => _informationShare5; set => SetField(ref _informationShare5, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 6 [NOTICES.X63]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 6")]
        public StringEnumValue<YesOrNo> InformationShare6 { get => _informationShare6; set => SetField(ref _informationShare6, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information 7 [NOTICES.X64]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information 7")]
        public StringEnumValue<YesOrNo> InformationShare7 { get => _informationShare7; set => SetField(ref _informationShare7, value); }

        /// <summary>
        /// Privacy Policy Information Types We Collect 1st Field [NOTICES.X52]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Types We Collect 1st Field")]
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect1 { get => _informationTypesWeCollect1; set => SetField(ref _informationTypesWeCollect1, value); }

        /// <summary>
        /// Privacy Policy Information Types We Collect 2nd Field [NOTICES.X53]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Types We Collect 2nd Field")]
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect2 { get => _informationTypesWeCollect2; set => SetField(ref _informationTypesWeCollect2, value); }

        /// <summary>
        /// Privacy Policy Information Types We Collect 3rd Field [NOTICES.X54]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Types We Collect 3rd Field")]
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect3 { get => _informationTypesWeCollect3; set => SetField(ref _informationTypesWeCollect3, value); }

        /// <summary>
        /// Privacy Policy Information Types We Collect 4th Field [NOTICES.X55]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Types We Collect 4th Field")]
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect4 { get => _informationTypesWeCollect4; set => SetField(ref _informationTypesWeCollect4, value); }

        /// <summary>
        /// Privacy Policy Information Types We Collect 5th Field [NOTICES.X56]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Types We Collect 5th Field")]
        public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect5 { get => _informationTypesWeCollect5; set => SetField(ref _informationTypesWeCollect5, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Joint Marketing? [NOTICES.X85]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Joint Marketing?")]
        public StringEnumValue<JointMarketType> JointMarketType { get => _jointMarketType; set => SetField(ref _jointMarketType, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Joint Marketing Example 1 [NOTICES.X86]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Joint Marketing Example 1")]
        public string JointMarketTypeExample1 { get => _jointMarketTypeExample1; set => SetField(ref _jointMarketTypeExample1, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 1 [NOTICES.X65]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 1")]
        public StringEnumValue<LimitSharing> LimitSharing1 { get => _limitSharing1; set => SetField(ref _limitSharing1, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 2 [NOTICES.X66]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 2")]
        public StringEnumValue<LimitSharing> LimitSharing2 { get => _limitSharing2; set => SetField(ref _limitSharing2, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 3 [NOTICES.X67]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 3")]
        public StringEnumValue<LimitSharing> LimitSharing3 { get => _limitSharing3; set => SetField(ref _limitSharing3, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 4 [NOTICES.X68]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 4")]
        public StringEnumValue<LimitSharing> LimitSharing4 { get => _limitSharing4; set => SetField(ref _limitSharing4, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 5 [NOTICES.X69]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 5")]
        public StringEnumValue<LimitSharing> LimitSharing5 { get => _limitSharing5; set => SetField(ref _limitSharing5, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 6 [NOTICES.X70]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 6")]
        public StringEnumValue<LimitSharing> LimitSharing6 { get => _limitSharing6; set => SetField(ref _limitSharing6, value); }

        /// <summary>
        /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 7 [NOTICES.X71]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 7")]
        public StringEnumValue<LimitSharing> LimitSharing7 { get => _limitSharing7; set => SetField(ref _limitSharing7, value); }

        /// <summary>
        /// Privacy Policy Month [NOTICES.X98]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Month")]
        public StringEnumValue<Month> Month { get => _month; set => SetField(ref _month, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Nonaffiliates? [NOTICES.X83]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Nonaffiliates?")]
        public StringEnumValue<NonaffiliateType> NonaffiliateType { get => _nonaffiliateType; set => SetField(ref _nonaffiliateType, value); }

        /// <summary>
        /// Privacy Policy Information Do You Have Nonaffiliates Example 1 [NOTICES.X84]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Have Nonaffiliates Example 1")]
        public string NonaffiliateTypeExample1 { get => _nonaffiliateTypeExample1; set => SetField(ref _nonaffiliateTypeExample1, value); }

        /// <summary>
        /// Privacy Policy How Does Company Protect My Personal Information [NOTICES.X72]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy How Does Company Protect My Personal Information")]
        public string NotesForProtectPrivacy { get => _notesForProtectPrivacy; set => SetField(ref _notesForProtectPrivacy, value); }

        /// <summary>
        /// Privacy Policy Information Other Information [NOTICES.X87]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Other Information")]
        public string OtherInformation { get => _otherInformation; set => SetField(ref _otherInformation, value); }

        /// <summary>
        /// Privacy Policy Information Phone Number for Question [NOTICES.X92]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Privacy Policy Information Phone Number for Question")]
        public string PhoneForQuestion { get => _phoneForQuestion; set => SetField(ref _phoneForQuestion, value); }

        /// <summary>
        /// Privacy Policy Information Phone Number for Limit Our Sharing [NOTICES.X89]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.PHONE, Description = "Privacy Policy Information Phone Number for Limit Our Sharing")]
        public string PhoneToLimit { get => _phoneToLimit; set => SetField(ref _phoneToLimit, value); }

        /// <summary>
        /// Privacy Policy Information Selection [NOTICES.X51]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Selection")]
        public StringEnumValue<PrintSelection> PrintSelection { get => _printSelection; set => SetField(ref _printSelection, value); }

        /// <summary>
        /// Privacy Policy Information Do You Share Personal Information in Joint Marketing? [NOTICES.X88]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Do You Share Personal Information in Joint Marketing?")]
        public StringEnumValue<ShareInfoWithJointMarketing> ShareInfoWithJointMarketing { get => _shareInfoWithJointMarketing; set => SetField(ref _shareInfoWithJointMarketing, value); }

        /// <summary>
        /// Privacy Policy Information We Collect Customer Personal Information at These Times 1 [NOTICES.X73]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information We Collect Customer Personal Information at These Times 1")]
        public StringEnumValue<TimesToCollect> TimesToCollect1 { get => _timesToCollect1; set => SetField(ref _timesToCollect1, value); }

        /// <summary>
        /// Privacy Policy Information We Collect Customer Personal Information at These Times 2 [NOTICES.X74]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information We Collect Customer Personal Information at These Times 2")]
        public StringEnumValue<TimesToCollect> TimesToCollect2 { get => _timesToCollect2; set => SetField(ref _timesToCollect2, value); }

        /// <summary>
        /// Privacy Policy Information We Collect Customer Personal Information at These Times 3 [NOTICES.X75]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information We Collect Customer Personal Information at These Times 3")]
        public StringEnumValue<TimesToCollect> TimesToCollect3 { get => _timesToCollect3; set => SetField(ref _timesToCollect3, value); }

        /// <summary>
        /// Privacy Policy Information We Collect Customer Personal Information at These Times 4 [NOTICES.X76]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information We Collect Customer Personal Information at These Times 4")]
        public StringEnumValue<TimesToCollect> TimesToCollect4 { get => _timesToCollect4; set => SetField(ref _timesToCollect4, value); }

        /// <summary>
        /// Privacy Policy Information We Collect Customer Personal Information at These Times 5 [NOTICES.X77]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information We Collect Customer Personal Information at These Times 5")]
        public StringEnumValue<TimesToCollect> TimesToCollect5 { get => _timesToCollect5; set => SetField(ref _timesToCollect5, value); }

        /// <summary>
        /// Privacy Policy Information Website for Question [NOTICES.X93]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Website for Question")]
        public string WebsiteForQuestion { get => _websiteForQuestion; set => SetField(ref _websiteForQuestion, value); }

        /// <summary>
        /// Privacy Policy Information Website for Limit Our Sharing [NOTICES.X90]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Information Website for Limit Our Sharing")]
        public string WebsiteToLimit { get => _websiteToLimit; set => SetField(ref _websiteToLimit, value); }

        /// <summary>
        /// Privacy Policy Year [NOTICES.X99]
        /// </summary>
        [LoanFieldProperty(Description = "Privacy Policy Year")]
        public int? Year { get => _year; set => SetField(ref _year, value); }
    }
}