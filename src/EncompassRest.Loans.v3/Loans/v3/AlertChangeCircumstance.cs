using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AlertChangeCircumstance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AlertChangeCircumstance : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<int?>? _alertChangeCircumstanceIndex;
    private DirtyValue<string?>? _alertTriggerFieldId;
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
    private DirtyValue<string?>? _id;
    private DirtyValue<DateTime?>? _revisedDueDate;

    /// <summary>
    /// AlertChangeCircumstanceContract AlertChangeCircumstanceIndex
    /// </summary>
    public int? AlertChangeCircumstanceIndex { get => _alertChangeCircumstanceIndex; set => SetField(ref _alertChangeCircumstanceIndex, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert Trigger Field ID [XCOC0001]
    /// </summary>
    public string? AlertTriggerFieldId { get => _alertTriggerFieldId; set => SetField(ref _alertTriggerFieldId, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Record ID [XCOC0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Baseline [XCOC0012]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertBaseline { get => _changedCircumstanceAlertBaseline; set => SetField(ref _changedCircumstanceAlertBaseline, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Disclosed Amount [XCOC0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertDisclosedAmount { get => _changedCircumstanceAlertDisclosedAmount; set => SetField(ref _changedCircumstanceAlertDisclosedAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Fee Description [XCOC0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertFeeDescription { get => _changedCircumstanceAlertFeeDescription; set => SetField(ref _changedCircumstanceAlertFeeDescription, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Initial Amount [XCOC0011]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertInitialAmount { get => _changedCircumstanceAlertInitialAmount; set => SetField(ref _changedCircumstanceAlertInitialAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Itemization Amount [XCOC0014]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertItemizationAmount { get => _changedCircumstanceAlertItemizationAmount; set => SetField(ref _changedCircumstanceAlertItemizationAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Variance Amount [XCOC0015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertVarianceAmount { get => _changedCircumstanceAlertVarianceAmount; set => SetField(ref _changedCircumstanceAlertVarianceAmount, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Category [XCOC0009]
    /// </summary>
    public StringEnumValue<ChangedCircumstanceCategory> ChangedCircumstanceCategory { get => _changedCircumstanceCategory; set => SetField(ref _changedCircumstanceCategory, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Comments [XCOC0006]
    /// </summary>
    public string? ChangedCircumstanceComments { get => _changedCircumstanceComments; set => SetField(ref _changedCircumstanceComments, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changes Received Date [XCOC0003]
    /// </summary>
    public DateTime? ChangedCircumstanceDate { get => _changedCircumstanceDate; set => SetField(ref _changedCircumstanceDate, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Description [XCOC0005]
    /// </summary>
    public string? ChangedCircumstanceDescription { get => _changedCircumstanceDescription; set => SetField(ref _changedCircumstanceDescription, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason [XCOC0007]
    /// </summary>
    public string? ChangedCircumstanceReason { get => _changedCircumstanceReason; set => SetField(ref _changedCircumstanceReason, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason Other [XCOC0008]
    /// </summary>
    public string? ChangedCircumstanceReasonOther { get => _changedCircumstanceReasonOther; set => SetField(ref _changedCircumstanceReasonOther, value); }

    /// <summary>
    /// AlertChangeCircumstanceContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Revised LE/CD Due Date [XCOC0004]
    /// </summary>
    public DateTime? RevisedDueDate { get => _revisedDueDate; set => SetField(ref _revisedDueDate, value); }
}