using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneHistoryLog
/// </summary>
public sealed partial class MilestoneHistoryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneHistoryLog AddedByUserId
    /// </summary>
    public string? AddedByUserId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog ChangeReason
    /// </summary>
    public string? ChangeReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog DateAddedUtc
    /// </summary>
    public DateTime? DateAddedUtc { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog MilestoneTemplate
    /// </summary>
    public string? MilestoneTemplate { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneHistoryLog RecordXML
    /// </summary>
    public string? RecordXML { get => GetValue<string?>(); set => SetValue(value); }
}