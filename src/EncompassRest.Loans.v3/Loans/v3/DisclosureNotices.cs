using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureNotices
/// </summary>
public sealed partial class DisclosureNotices : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Disclosure Anti-Coerc Stmnt [NOTICES.X16]
    /// </summary>
    public bool? AntiCoercionStatementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By Addr [NOTICES.X33]
    /// </summary>
    public string? CommitmentIssuedByAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By City [NOTICES.X34]
    /// </summary>
    public string? CommitmentIssuedByCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By Contact Name [NOTICES.X31]
    /// </summary>
    public string? CommitmentIssuedByContactName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By Company [NOTICES.X32]
    /// </summary>
    public string? CommitmentIssuedByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By Phone [NOTICES.X37]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? CommitmentIssuedByPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By Zip [NOTICES.X36]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? CommitmentIssuedByPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Commit Issued By State [NOTICES.X35]
    /// </summary>
    public string? CommitmentIssuedByState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Consumer/ARM Handbook [NOTICES.X19]
    /// </summary>
    public StringEnumValue<YOrN> ConsumerHandbookOnAdjustableRateMortgages { get => GetValue<StringEnumValue<YOrN>>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Appraisal Notice Days [NOTICES.X28]
    /// </summary>
    public string? DaysToReceiveWrittenRequest { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Days to Return Lenders Copy [NOTICES.X47]
    /// </summary>
    public int? DaysToReturnToLender { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Privacy Policy Options 1 [NOTICES.X38]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? DiscloseNonPublicPersonalInformation { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA Addr [NOTICES.X3]
    /// </summary>
    public string? EcoaAddress { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA Addr 2 [NOTICES.X4]
    /// </summary>
    public string? EcoaAddress2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA City [NOTICES.X5]
    /// </summary>
    public string? EcoaCity { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA Name [NOTICES.X2]
    /// </summary>
    public string? EcoaName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA Phone [NOTICES.X8]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE)]
    public string? EcoaPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA Zip [NOTICES.X7]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? EcoaPostalCode { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure ECOA State [NOTICES.X6]
    /// </summary>
    public string? EcoaState { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 1 [NOTICES.X20]
    /// </summary>
    public string? FairLendingNoticeDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 2 [NOTICES.X21]
    /// </summary>
    public string? FairLendingNoticeDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 3 [NOTICES.X22]
    /// </summary>
    public string? FairLendingNoticeDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 4 [NOTICES.X23]
    /// </summary>
    public string? FairLendingNoticeDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 5 [NOTICES.X24]
    /// </summary>
    public string? FairLendingNoticeDescription5 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 6 [NOTICES.X25]
    /// </summary>
    public string? FairLendingNoticeDescription6 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 7 [NOTICES.X26]
    /// </summary>
    public string? FairLendingNoticeDescription7 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Fair Lending Contact 8 [NOTICES.X27]
    /// </summary>
    public string? FairLendingNoticeDescription8 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Community Name for FEMA [NOTICES.X50]
    /// </summary>
    public string? FemaCommunityName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Flood Ins Notif [NOTICES.X17]
    /// </summary>
    public bool? FloodInsuranceNotificationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Info Discl Auth [NOTICES.X10]
    /// </summary>
    public bool? InformationDisclosureAuthorizationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Mtg Broker License Auth [NOTICES.X29]
    /// </summary>
    public string? LicensedMortgageBrokerUnder { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Community participates in NFIP [NOTICES.X48]
    /// </summary>
    public bool? LocatedInNfipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Flood Ins Clause [NOTICES.X18]
    /// </summary>
    public string? LossPayeeClause { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Map Panel Number [NOTICES.X97]
    /// </summary>
    public string? MapPanelNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure NFIP Community Number [NOTICES.X95]
    /// </summary>
    public string? NfipCommunityNumber { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure NFIP Map Panel Effective/Revised Date [NOTICES.X96]
    /// </summary>
    public DateTime? NfipMapEffectiveRevisedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure NFIP Participation Status Type [NOTICES.X100]
    /// </summary>
    public string? NfipParticipationStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Non-Finance Company 1 Desc [NOTICES.X40]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NonFinancialCompaniesDescription1 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Non-Finance Company 2 Desc [NOTICES.X41]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NonFinancialCompaniesDescription2 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Non-Finance Company 3 Desc [NOTICES.X42]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NonFinancialCompaniesDescription3 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Non-Finance Company 4 Desc [NOTICES.X43]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? NonFinancialCompaniesDescription4 { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Property Community does not participates in NFIP [NOTICES.X49]
    /// </summary>
    public bool? NotLocatedInNfipIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Occupancy Stmnt [NOTICES.X1]
    /// </summary>
    public bool? OccupancyStatementIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Privacy Policy Options 2 [NOTICES.X45]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? OptOut { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Opt-Out Phone Number [NOTICES.X44]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.PHONE, ReadOnly = true)]
    public string? OptOutPhone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Auth Bank Acct Verif [NOTICES.X13]
    /// </summary>
    public bool? ReleaseBankingInformationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Auth Empl Hist Verif [NOTICES.X12]
    /// </summary>
    public bool? ReleaseEmploymentInformationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Auth Any Info Necessary [NOTICES.X15]
    /// </summary>
    public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Auth Loan Rating Verif [NOTICES.X14]
    /// </summary>
    public bool? ReleaseMortgageInformationIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Disclosure Right to Privacy Act [NOTICES.X9]
    /// </summary>
    public bool? RightToFinancialPrivacyActIndicator { get => GetValue<bool?>(); set => SetValue(value); }
}