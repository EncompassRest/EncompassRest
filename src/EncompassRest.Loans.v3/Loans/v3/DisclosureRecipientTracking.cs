using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipientTracking
/// </summary>
public sealed partial class DisclosureRecipientTracking : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<DateTime?>? _acceptConsentDate;
    private DirtyValue<string?>? _acceptConsentIP;
    private DirtyValue<DateTime?>? _authenticatedDate;
    private DirtyValue<string?>? _authenticatedIP;
    private DirtyValue<DateTime?>? _eSignedDate;
    private DirtyValue<string?>? _eSignedIP;
    private DirtyValue<StringEnumValue<LoanLevelConsent>>? _loanLevelConsent;
    private DirtyValue<DateTime?>? _rejectConsentDate;
    private DirtyValue<string?>? _rejectConsentIP;
    private DirtyValue<DateTime?>? _viewConsentDate;
    private DirtyValue<DateTime?>? _viewESignedDate;
    private DirtyValue<DateTime?>? _viewMessageDate;
    private DirtyValue<DateTime?>? _viewWetSignedDate;
    private DirtyValue<DateTime?>? _wetSignedDate;

    /// <summary>
    /// DisclosureRecipientTrackingContract AcceptConsentDate
    /// </summary>
    public DateTime? AcceptConsentDate { get => _acceptConsentDate; set => SetField(ref _acceptConsentDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract AcceptConsentIP
    /// </summary>
    public string? AcceptConsentIP { get => _acceptConsentIP; set => SetField(ref _acceptConsentIP, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract AuthenticatedDate
    /// </summary>
    public DateTime? AuthenticatedDate { get => _authenticatedDate; set => SetField(ref _authenticatedDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract AuthenticatedIP
    /// </summary>
    public string? AuthenticatedIP { get => _authenticatedIP; set => SetField(ref _authenticatedIP, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ESignedDate
    /// </summary>
    public DateTime? ESignedDate { get => _eSignedDate; set => SetField(ref _eSignedDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ESignedIP
    /// </summary>
    public string? ESignedIP { get => _eSignedIP; set => SetField(ref _eSignedIP, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract LoanLevelConsent
    /// </summary>
    public StringEnumValue<LoanLevelConsent> LoanLevelConsent { get => _loanLevelConsent; set => SetField(ref _loanLevelConsent, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract RejectConsentDate
    /// </summary>
    public DateTime? RejectConsentDate { get => _rejectConsentDate; set => SetField(ref _rejectConsentDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract RejectConsentIP
    /// </summary>
    public string? RejectConsentIP { get => _rejectConsentIP; set => SetField(ref _rejectConsentIP, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ViewConsentDate
    /// </summary>
    public DateTime? ViewConsentDate { get => _viewConsentDate; set => SetField(ref _viewConsentDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ViewESignedDate
    /// </summary>
    public DateTime? ViewESignedDate { get => _viewESignedDate; set => SetField(ref _viewESignedDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ViewMessageDate
    /// </summary>
    public DateTime? ViewMessageDate { get => _viewMessageDate; set => SetField(ref _viewMessageDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract ViewWetSignedDate
    /// </summary>
    public DateTime? ViewWetSignedDate { get => _viewWetSignedDate; set => SetField(ref _viewWetSignedDate, value); }

    /// <summary>
    /// DisclosureRecipientTrackingContract WetSignedDate
    /// </summary>
    public DateTime? WetSignedDate { get => _wetSignedDate; set => SetField(ref _wetSignedDate, value); }
}