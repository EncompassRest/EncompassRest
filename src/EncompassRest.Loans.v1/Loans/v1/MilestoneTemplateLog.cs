using System;

namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneTemplateLog
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class MilestoneTemplateLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _elliLogRecordId;
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _isTemplateDatesLocked;
    private DirtyValue<bool?>? _isTemplateLocked;
    private DirtyValue<string?>? _milestoneTemplateID;
    private DirtyValue<string?>? _milestoneTemplateName;
    private DirtyValue<DateTime?>? _updatedDateUtc;

    /// <summary>
    /// MilestoneTemplateLog ElliLogRecordId
    /// </summary>
    public int? ElliLogRecordId { get => _elliLogRecordId; set => SetField(ref _elliLogRecordId, value); }

    /// <summary>
    /// MilestoneTemplateLog Id
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
    /// MilestoneTemplateLog MilestoneTemplateID
    /// </summary>
    public string? MilestoneTemplateID { get => _milestoneTemplateID; set => SetField(ref _milestoneTemplateID, value); }

    /// <summary>
    /// MilestoneTemplateLog MilestoneTemplateName
    /// </summary>
    public string? MilestoneTemplateName { get => _milestoneTemplateName; set => SetField(ref _milestoneTemplateName, value); }

    /// <summary>
    /// MilestoneTemplateLog UpdatedDateUtc
    /// </summary>
    public DateTime? UpdatedDateUtc { get => _updatedDateUtc; set => SetField(ref _updatedDateUtc, value); }
}