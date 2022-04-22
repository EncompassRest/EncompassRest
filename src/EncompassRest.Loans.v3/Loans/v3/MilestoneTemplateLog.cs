namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneTemplateLog
/// </summary>
public sealed partial class MilestoneTemplateLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneTemplateLog Comments
    /// </summary>
    public string? Comments { get => GetValue<string?>(); set => SetValue(value); }

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
    /// MilestoneTemplateLog MilestoneTemplateId
    /// </summary>
    public string? MilestoneTemplateId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTemplateLog MilestoneTemplateName
    /// </summary>
    public string? MilestoneTemplateName { get => GetValue<string?>(); set => SetValue(value); }
}