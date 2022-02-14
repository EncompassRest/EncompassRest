using System;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// InvestorDeliveryLog
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(DeliveryStatusDate), SerializeWholeListWhenDirty = true)]
public sealed partial class InvestorDeliveryLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _categoryDeliveredTo;
    private DirtyValue<string?>? _companyDeliveredTo;
    private DirtyValue<string?>? _deliveryStatus;
    private DirtyValue<DateTime?>? _deliveryStatusDate;
    private DirtyValue<string?>? _id;

    /// <summary>
    /// Category Delivered To [INVESTORCONN0004]
    /// </summary>
    public string? CategoryDeliveredTo { get => _categoryDeliveredTo; set => SetField(ref _categoryDeliveredTo, value); }

    /// <summary>
    /// Company Delivered To [INVESTORCONN0003]
    /// </summary>
    public string? CompanyDeliveredTo { get => _companyDeliveredTo; set => SetField(ref _companyDeliveredTo, value); }

    /// <summary>
    /// Delivery Status [INVESTORCONN0002]
    /// </summary>
    public string? DeliveryStatus { get => _deliveryStatus; set => SetField(ref _deliveryStatus, value); }

    /// <summary>
    /// Delivery Status Date/Time [INVESTORCONN0001]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? DeliveryStatusDate { get => _deliveryStatusDate; set => SetField(ref _deliveryStatusDate, value); }

    /// <summary>
    /// InvestorDeliveryLogContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }
}