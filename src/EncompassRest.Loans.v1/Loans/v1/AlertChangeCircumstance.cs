using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AlertChangeCircumstance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AlertChangeCircumstance : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Good Faith Change of Circumstance - Alert Trigger Field ID [XCOCNN01]
    /// </summary>
    public string? AlertTriggerFieldID { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Record ID [XCOCNN98]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Baseline [XCOCNN12]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertBaseline { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Disclosed Amount [XCOCNN13]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertDisclosedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Fee Description [XCOCNN10]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertFeeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Initial Amount [XCOCNN11]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertInitialAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Itemization Amount [XCOCNN14]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertItemizationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Variance Amount [XCOCNN15]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertVarianceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Category [XCOCNN09]
    /// </summary>
    public StringEnumValue<ChangedCircumstanceCategory> ChangedCircumstanceCategory { get => GetValue<StringEnumValue<ChangedCircumstanceCategory>>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Comments [XCOCNN06]
    /// </summary>
    public string? ChangedCircumstanceComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changes Received Date [XCOCNN03]
    /// </summary>
    public DateTime? ChangedCircumstanceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Description [XCOCNN05]
    /// </summary>
    public string? ChangedCircumstanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason [XCOCNN07]
    /// </summary>
    public string? ChangedCircumstanceReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason Other [XCOCNN08]
    /// </summary>
    public string? ChangedCircumstanceReasonOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AlertChangeCircumstance EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// AlertChangeCircumstance Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Revised LE/CD Due Date [XCOCNN04]
    /// </summary>
    public DateTime? RevisedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}