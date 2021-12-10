using System;

namespace EncompassRest.Loans.v3;

/// <summary>
/// Rider
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class Rider : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _id;
    private DirtyValue<bool?>? _received;
    private DirtyValue<bool?>? _required;
    private DirtyValue<DateTime?>? _riderDate;
    private DirtyValue<string?>? _riderName;

    /// <summary>
    /// RiderContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// Rider Received [RIDER0003]
    /// </summary>
    public bool? Received { get => _received; set => SetField(ref _received, value); }

    /// <summary>
    /// Rider Required [RIDER0002]
    /// </summary>
    public bool? Required { get => _required; set => SetField(ref _required, value); }

    /// <summary>
    /// Rider Date [RIDER0004]
    /// </summary>
    public DateTime? RiderDate { get => _riderDate; set => SetField(ref _riderDate, value); }

    /// <summary>
    /// Rider Name [RIDER0001]
    /// </summary>
    public string? RiderName { get => _riderName; set => SetField(ref _riderName, value); }
}