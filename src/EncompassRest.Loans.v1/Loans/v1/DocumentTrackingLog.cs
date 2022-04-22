using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DocumentTrackingLog
/// </summary>
public sealed partial class DocumentTrackingLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DocumentTrackingLog Action
    /// </summary>
    public string? Action { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog ActionCd
    /// </summary>
    public string? ActionCd { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog Contact
    /// </summary>
    public string? Contact { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog DOT
    /// </summary>
    public bool? DOT { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog Email
    /// </summary>
    public bool? Email { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog ExecutedNote
    /// </summary>
    public bool? ExecutedNote { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog FTP
    /// </summary>
    public bool? FTP { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog LogBy
    /// </summary>
    public string? LogBy { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog LogDate
    /// </summary>
    public string? LogDate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog Organization
    /// </summary>
    public string? Organization { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog Phone
    /// </summary>
    public bool? Phone { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// DocumentTrackingLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}