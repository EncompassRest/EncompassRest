using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// InvestorDeliveryLog
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class InvestorDeliveryLog : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// Category Delivered To [INVESTORCONNNN04]
    /// </summary>
    public string? CategoryDeliveredTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Company Delivered To [INVESTORCONNNN03]
    /// </summary>
    public string? CompanyDeliveredTo { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InvestorDeliveryLog DeliveryStatus
    /// </summary>
    public string? DeliveryStatus { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// InvestorDeliveryLog DeliveryStatusDate
    /// </summary>
    public DateTime? DeliveryStatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }

    /// <summary>
    /// InvestorDeliveryLog Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Delivery Status [INVESTORCONNNN02]
    /// </summary>
    public string? Status { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// Delivery Status Date/Time [INVESTORCONNNN01]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? StatusDate { get => GetValue<DateTime?>(); set => SetValue(value); }
}