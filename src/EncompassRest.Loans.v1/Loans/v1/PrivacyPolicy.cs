using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// PrivacyPolicy
/// </summary>
public sealed partial class PrivacyPolicy : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Privacy Policy Information Describe Additional Rights to Limit Sharing [NOTICES.X78]
    /// </summary>
    public string? AdditionalRightsDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Affiliates? [NOTICES.X79]
    /// </summary>
    public StringEnumValue<AffiliateType> AffiliateType { get => GetValue<StringEnumValue<AffiliateType>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Affiliates Example 1 [NOTICES.X80]
    /// </summary>
    public string? AffiliateTypeExample1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Affiliates Example 2 [NOTICES.X81]
    /// </summary>
    public string? AffiliateTypeExample2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Affiliates Example 3 [NOTICES.X82]
    /// </summary>
    public string? AffiliateTypeExample3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Institutions that collect personal information from their affiliates and credit bureaus [NOTICES.X94]
    /// </summary>
    public StringEnumValue<AlsoCollectFrom> AlsoCollectFrom { get => GetValue<StringEnumValue<AlsoCollectFrom>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Number of Days After Providing Notice Can We Begin Sharing Information (must be more than 30) [NOTICES.X91]
    /// </summary>
    public int? DaysToUse { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy How to Share Customer or Member [NOTICES.X57]
    /// </summary>
    public StringEnumValue<HowToShare> HowToShare { get => GetValue<StringEnumValue<HowToShare>>(); set => SetValue(value); }

    /// <summary>
    /// PrivacyPolicy Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 1 [NOTICES.X58]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare1 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 2 [NOTICES.X59]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare2 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 3 [NOTICES.X60]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare3 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 4 [NOTICES.X61]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare4 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 5 [NOTICES.X62]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare5 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 6 [NOTICES.X63]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare6 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information 7 [NOTICES.X64]
    /// </summary>
    public StringEnumValue<YesOrNo> InformationShare7 { get => GetValue<StringEnumValue<YesOrNo>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Types We Collect 1st Field [NOTICES.X52]
    /// </summary>
    public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect1 { get => GetValue<StringEnumValue<InformationTypesWeCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Types We Collect 2nd Field [NOTICES.X53]
    /// </summary>
    public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect2 { get => GetValue<StringEnumValue<InformationTypesWeCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Types We Collect 3rd Field [NOTICES.X54]
    /// </summary>
    public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect3 { get => GetValue<StringEnumValue<InformationTypesWeCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Types We Collect 4th Field [NOTICES.X55]
    /// </summary>
    public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect4 { get => GetValue<StringEnumValue<InformationTypesWeCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Types We Collect 5th Field [NOTICES.X56]
    /// </summary>
    public StringEnumValue<InformationTypesWeCollect> InformationTypesWeCollect5 { get => GetValue<StringEnumValue<InformationTypesWeCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Joint Marketing? [NOTICES.X85]
    /// </summary>
    public StringEnumValue<JointMarketType> JointMarketType { get => GetValue<StringEnumValue<JointMarketType>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Joint Marketing Example 1 [NOTICES.X86]
    /// </summary>
    public string? JointMarketTypeExample1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 1 [NOTICES.X65]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing1 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 2 [NOTICES.X66]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing2 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 3 [NOTICES.X67]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing3 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 4 [NOTICES.X68]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing4 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 5 [NOTICES.X69]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing5 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 6 [NOTICES.X70]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing6 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Reasons We Can Share Your Personal Information Limit Sharing 7 [NOTICES.X71]
    /// </summary>
    public StringEnumValue<LimitSharing> LimitSharing7 { get => GetValue<StringEnumValue<LimitSharing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Month [NOTICES.X98]
    /// </summary>
    public StringEnumValue<Month> Month { get => GetValue<StringEnumValue<Month>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Nonaffiliates? [NOTICES.X83]
    /// </summary>
    public StringEnumValue<NonaffiliateType> NonaffiliateType { get => GetValue<StringEnumValue<NonaffiliateType>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Have Nonaffiliates Example 1 [NOTICES.X84]
    /// </summary>
    public string? NonaffiliateTypeExample1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy How Does Company Protect My Personal Information [NOTICES.X72]
    /// </summary>
    public string? NotesForProtectPrivacy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Other Information [NOTICES.X87]
    /// </summary>
    public string? OtherInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Phone Number for Question [NOTICES.X92]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhoneForQuestion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Phone Number for Limit Our Sharing [NOTICES.X89]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? PhoneToLimit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Selection [NOTICES.X51]
    /// </summary>
    public StringEnumValue<PrintSelection> PrintSelection { get => GetValue<StringEnumValue<PrintSelection>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Do You Share Personal Information in Joint Marketing? [NOTICES.X88]
    /// </summary>
    public StringEnumValue<ShareInfoWithJointMarketing> ShareInfoWithJointMarketing { get => GetValue<StringEnumValue<ShareInfoWithJointMarketing>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information We Collect Customer Personal Information at These Times 1 [NOTICES.X73]
    /// </summary>
    public StringEnumValue<TimesToCollect> TimesToCollect1 { get => GetValue<StringEnumValue<TimesToCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information We Collect Customer Personal Information at These Times 2 [NOTICES.X74]
    /// </summary>
    public StringEnumValue<TimesToCollect> TimesToCollect2 { get => GetValue<StringEnumValue<TimesToCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information We Collect Customer Personal Information at These Times 3 [NOTICES.X75]
    /// </summary>
    public StringEnumValue<TimesToCollect> TimesToCollect3 { get => GetValue<StringEnumValue<TimesToCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information We Collect Customer Personal Information at These Times 4 [NOTICES.X76]
    /// </summary>
    public StringEnumValue<TimesToCollect> TimesToCollect4 { get => GetValue<StringEnumValue<TimesToCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information We Collect Customer Personal Information at These Times 5 [NOTICES.X77]
    /// </summary>
    public StringEnumValue<TimesToCollect> TimesToCollect5 { get => GetValue<StringEnumValue<TimesToCollect>>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Website for Question [NOTICES.X93]
    /// </summary>
    public string? WebsiteForQuestion { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Information Website for Limit Our Sharing [NOTICES.X90]
    /// </summary>
    public string? WebsiteToLimit { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Privacy Policy Year [NOTICES.X99]
    /// </summary>
    public int? Year { get => GetValue<int?>(); set => SetValue(value); }
}