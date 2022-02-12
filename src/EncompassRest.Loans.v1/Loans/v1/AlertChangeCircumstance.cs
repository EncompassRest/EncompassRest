using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AlertChangeCircumstance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AlertChangeCircumstance : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _alertTriggerFieldID;
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _changedCircumstanceAlertBaseline;
    private DirtyValue<decimal?>? _changedCircumstanceAlertDisclosedAmount;
    private DirtyValue<string?>? _changedCircumstanceAlertFeeDescription;
    private DirtyValue<decimal?>? _changedCircumstanceAlertInitialAmount;
    private DirtyValue<decimal?>? _changedCircumstanceAlertItemizationAmount;
    private DirtyValue<decimal?>? _changedCircumstanceAlertVarianceAmount;
    private DirtyValue<StringEnumValue<ChangedCircumstanceCategory>>? _changedCircumstanceCategory;
    private DirtyValue<string?>? _changedCircumstanceComments;
    private DirtyValue<DateTime?>? _changedCircumstanceDate;
    private DirtyValue<string?>? _changedCircumstanceDescription;
    private DirtyValue<string?>? _changedCircumstanceReason;
    private DirtyValue<string?>? _changedCircumstanceReasonOther;
    private DirtyValue<bool?>? _entityDeleted;
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _revisedDueDate;

    /// <summary>
    /// Good Faith Change of Circumstance - Alert Trigger Field ID [XCOCNN01]
    /// </summary>
    public string? AlertTriggerFieldID { get => _alertTriggerFieldID; set => SetField(ref _alertTriggerFieldID, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Record ID [XCOCNN98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Baseline [XCOCNN12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertBaseline { get => _changedCircumstanceAlertBaseline; set => SetField(ref _changedCircumstanceAlertBaseline, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Disclosed Amount [XCOCNN13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertDisclosedAmount { get => _changedCircumstanceAlertDisclosedAmount; set => SetField(ref _changedCircumstanceAlertDisclosedAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Fee Description [XCOCNN10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertFeeDescription { get => _changedCircumstanceAlertFeeDescription; set => SetField(ref _changedCircumstanceAlertFeeDescription, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Initial Amount [XCOCNN11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertInitialAmount { get => _changedCircumstanceAlertInitialAmount; set => SetField(ref _changedCircumstanceAlertInitialAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Itemization Amount [XCOCNN14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertItemizationAmount { get => _changedCircumstanceAlertItemizationAmount; set => SetField(ref _changedCircumstanceAlertItemizationAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Variance Amount [XCOCNN15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertVarianceAmount { get => _changedCircumstanceAlertVarianceAmount; set => SetField(ref _changedCircumstanceAlertVarianceAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Category [XCOCNN09]
    /// </summary>
    public StringEnumValue<ChangedCircumstanceCategory> ChangedCircumstanceCategory { get => _changedCircumstanceCategory; set => SetField(ref _changedCircumstanceCategory, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Comments [XCOCNN06]
    /// </summary>
    public string? ChangedCircumstanceComments { get => _changedCircumstanceComments; set => SetField(ref _changedCircumstanceComments, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changes Received Date [XCOCNN03]
    /// </summary>
    public DateTime? ChangedCircumstanceDate { get => _changedCircumstanceDate; set => SetField(ref _changedCircumstanceDate, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Description [XCOCNN05]
    /// </summary>
    public string? ChangedCircumstanceDescription { get => _changedCircumstanceDescription; set => SetField(ref _changedCircumstanceDescription, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason [XCOCNN07]
    /// </summary>
    public string? ChangedCircumstanceReason { get => _changedCircumstanceReason; set => SetField(ref _changedCircumstanceReason, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason Other [XCOCNN08]
    /// </summary>
    public string? ChangedCircumstanceReasonOther { get => _changedCircumstanceReasonOther; set => SetField(ref _changedCircumstanceReasonOther, value); }

    /// <summary>
    /// AlertChangeCircumstance EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => _entityDeleted; set => SetField(ref _entityDeleted, value); }

    /// <summary>
    /// AlertChangeCircumstance Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Revised LE/CD Due Date [XCOCNN04]
    /// </summary>
    public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
}