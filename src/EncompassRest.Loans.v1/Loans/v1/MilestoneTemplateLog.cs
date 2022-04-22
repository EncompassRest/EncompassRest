using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneTemplateLog
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class MilestoneTemplateLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneTemplateLog ElliLogRecordId
    /// </summary>
    public int? ElliLogRecordId { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTemplateLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Milestone Dates Mode [3670]
    /// </summary>
    public bool? IsTemplateDatesLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// Milestones List Lock [3669]
    /// </summary>
    public bool? IsTemplateLocked { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTemplateLog MilestoneTemplateID
    /// </summary>
    public string? MilestoneTemplateID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTemplateLog MilestoneTemplateName
    /// </summary>
    public string? MilestoneTemplateName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTemplateLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => GetValue<DateTime?>(); set => SetValue(value); }
}