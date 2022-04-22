using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipientTracking
/// </summary>
public sealed partial class DisclosureRecipientTracking : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureRecipientTracking AcceptConsentDate
    /// </summary>
    public DateTime? AcceptConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking AcceptConsentIP
    /// </summary>
    public string? AcceptConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking AuthenticatedDate
    /// </summary>
    public DateTime? AuthenticatedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking AuthenticatedIP
    /// </summary>
    public string? AuthenticatedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ESignedDate
    /// </summary>
    public DateTime? ESignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ESignedIP
    /// </summary>
    public string? ESignedIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking LoanLevelConsent
    /// </summary>
    public StringEnumValue<LoanLevelConsent> LoanLevelConsent { get => GetValue<StringEnumValue<LoanLevelConsent>>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking RejectConsentDate
    /// </summary>
    public DateTime? RejectConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking RejectConsentIP
    /// </summary>
    public string? RejectConsentIP { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ViewConsentDate
    /// </summary>
    public DateTime? ViewConsentDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ViewESignedDate
    /// </summary>
    public DateTime? ViewESignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ViewMessageDate
    /// </summary>
    public DateTime? ViewMessageDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking ViewWetSignedDate
    /// </summary>
    public DateTime? ViewWetSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientTracking WetSignedDate
    /// </summary>
    public DateTime? WetSignedDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}