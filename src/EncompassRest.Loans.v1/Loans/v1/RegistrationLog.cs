using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// RegistrationLog
/// </summary>
public sealed partial class RegistrationLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// RegistrationLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// RegistrationLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// RegistrationLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog CurrentIndicator
    /// </summary>
    public bool? CurrentIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog ExpiredDate
    /// </summary>
    public DateTime? ExpiredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog InvestorName
    /// </summary>
    public string? InvestorName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog Reference
    /// </summary>
    public string? Reference { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog RegisteredById
    /// </summary>
    public string? RegisteredById { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog RegisteredByName
    /// </summary>
    public string? RegisteredByName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog RegisteredDate
    /// </summary>
    public DateTime? RegisteredDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// RegistrationLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}