using System;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// InvestorDeliveryLog
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class InvestorDeliveryLog : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _categoryDeliveredTo;
    private DirtyValue<string?>? _companyDeliveredTo;
    private DirtyValue<string?>? _deliveryStatus;
    private DirtyValue<DateTime?>? _deliveryStatusDate;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<DeliveryStatus>>? _status;
    private DirtyValue<DateTime?>? _statusDate;

    /// <summary>
    /// Category Delivered To [INVESTORCONNNN04]
    /// </summary>
    public string? CategoryDeliveredTo { get => _categoryDeliveredTo; set => SetField(ref _categoryDeliveredTo, value); }

    /// <summary>
    /// Company Delivered To [INVESTORCONNNN03]
    /// </summary>
    public string? CompanyDeliveredTo { get => _companyDeliveredTo; set => SetField(ref _companyDeliveredTo, value); }

    /// <summary>
    /// InvestorDeliveryLog DeliveryStatus
    /// </summary>
    public string? DeliveryStatus { get => _deliveryStatus; set => SetField(ref _deliveryStatus, value); }

    /// <summary>
    /// InvestorDeliveryLog DeliveryStatusDate
    /// </summary>
    public DateTime? DeliveryStatusDate { get => _deliveryStatusDate; set => SetField(ref _deliveryStatusDate, value); }

    /// <summary>
    /// InvestorDeliveryLog Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Delivery Status [INVESTORCONNNN02]
    /// </summary>
    public StringEnumValue<DeliveryStatus> Status { get => _status; set => SetField(ref _status, value); }

    /// <summary>
    /// Delivery Status Date/Time [INVESTORCONNNN01]
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.DATETIME)]
    public DateTime? StatusDate { get => _statusDate; set => SetField(ref _statusDate, value); }
}