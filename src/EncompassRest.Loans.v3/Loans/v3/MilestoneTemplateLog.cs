namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneTemplateLog
/// </summary>
public sealed partial class MilestoneTemplateLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _comments;
    private DirtyValue<int?>? _elliLogRecordId;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isTemplateDatesLocked;
    private DirtyValue<bool?>? _isTemplateLocked;
    private DirtyValue<string?>? _milestoneTemplateId;
    private DirtyValue<string?>? _milestoneTemplateName;

    /// <summary>
    /// MilestoneTemplateLogContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// MilestoneTemplateLogContract ElliLogRecordId
    /// </summary>
    public int? ElliLogRecordId { get => _elliLogRecordId; set => SetField(ref _elliLogRecordId, value); }

    /// <summary>
    /// MilestoneTemplateLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Milestone Dates Mode [3670]
    /// </summary>
    public bool? IsTemplateDatesLocked { get => _isTemplateDatesLocked; set => SetField(ref _isTemplateDatesLocked, value); }

    /// <summary>
    /// Milestones List Lock [3669]
    /// </summary>
    public bool? IsTemplateLocked { get => _isTemplateLocked; set => SetField(ref _isTemplateLocked, value); }

    /// <summary>
    /// MilestoneTemplateLogContract MilestoneTemplateId
    /// </summary>
    public string? MilestoneTemplateId { get => _milestoneTemplateId; set => SetField(ref _milestoneTemplateId, value); }

    /// <summary>
    /// MilestoneTemplateLogContract MilestoneTemplateName
    /// </summary>
    public string? MilestoneTemplateName { get => _milestoneTemplateName; set => SetField(ref _milestoneTemplateName, value); }
}