using System;
using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AlertChangeCircumstance
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class AlertChangeCircumstance : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AlertChangeCircumstance AlertChangeCircumstanceIndex
    /// </summary>
    public int? AlertChangeCircumstanceIndex { get => GetValue<int?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert Trigger Field ID [XCOC0001]
    /// </summary>
    public string? AlertTriggerFieldId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Record ID [XCOC0098]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Baseline [XCOC0012]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertBaseline { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Disclosed Amount [XCOC0013]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertDisclosedAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Fee Description [XCOC0010]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? ChangedCircumstanceAlertFeeDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Initial Amount [XCOC0011]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertInitialAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Itemization Amount [XCOC0014]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertItemizationAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Alert - Variance Amount [XCOC0015]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public decimal? ChangedCircumstanceAlertVarianceAmount { get => GetValue<decimal?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Category [XCOC0009]
    /// </summary>
    public StringEnumValue<ChangedCircumstanceCategory> ChangedCircumstanceCategory { get => GetValue<StringEnumValue<ChangedCircumstanceCategory>>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Comments [XCOC0006]
    /// </summary>
    public string? ChangedCircumstanceComments { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changes Received Date [XCOC0003]
    /// </summary>
    public DateTime? ChangedCircumstanceDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Description [XCOC0005]
    /// </summary>
    public string? ChangedCircumstanceDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason [XCOC0007]
    /// </summary>
    public string? ChangedCircumstanceReason { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Changed Circumstance Reason Other [XCOC0008]
    /// </summary>
    public string? ChangedCircumstanceReasonOther { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AlertChangeCircumstance Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Good Faith Change of Circumstance - Revised LE/CD Due Date [XCOC0004]
    /// </summary>
    public DateTime? RevisedDueDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}