using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// InvestorDeliveryLog
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(DeliveryStatusDate), SerializeWholeListWhenDirty = true)]
public sealed partial class InvestorDeliveryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Category Delivered To [INVESTORCONN0004]
    /// </summary>
    public string? CategoryDeliveredTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Company Delivered To [INVESTORCONN0003]
    /// </summary>
    public string? CompanyDeliveredTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Delivery Status [INVESTORCONN0002]
    /// </summary>
    public string? DeliveryStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Delivery Status Date/Time [INVESTORCONN0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DeliveryStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InvestorDeliveryLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}