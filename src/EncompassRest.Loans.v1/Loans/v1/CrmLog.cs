using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v1;

/// <summary>
/// CrmLog
/// </summary>
public sealed partial class CrmLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// CrmLog Alerts
    /// </summary>
    [AllowNull]
    public IList<LogAlert> Alerts { get => GetList<LogAlert>(); set => SetList(value); }

    /// <summary>
    /// CrmLog CommentList
    /// </summary>
    [AllowNull]
    public IList<LogComment> CommentList { get => GetList<LogComment>(); set => SetList(value); }

    /// <summary>
    /// CrmLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog ContactGuid
    /// </summary>
    public string? ContactGuid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog DateUtc
    /// </summary>
    public DateTime? DateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog FileAttachmentsMigrated
    /// </summary>
    public bool? FileAttachmentsMigrated { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog IsSystemSpecificIndicator
    /// </summary>
    public bool? IsSystemSpecificIndicator { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog LogRecordIndex
    /// </summary>
    public int? LogRecordIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog MappingId
    /// </summary>
    public string? MappingId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog MappingType
    /// </summary>
    public int? MappingType { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog RoleType
    /// </summary>
    public int? RoleType { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// CrmLog SystemId
    /// </summary>
    public string? SystemId { get => GetValue<string?>(); set => SetValue(value); }
}