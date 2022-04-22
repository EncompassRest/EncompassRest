namespace EncompassRest.Loans.v1;

/// <summary>
/// MilestoneTaskContact
/// </summary>
public sealed partial class MilestoneTaskContact : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// MilestoneTaskContact Address
    /// </summary>
    public string? Address { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact City
    /// </summary>
    public string? City { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact ContactId
    /// </summary>
    public string? ContactId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Email
    /// </summary>
    public string? Email { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Guid
    /// </summary>
    public string? Guid { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Name
    /// </summary>
    public string? Name { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Phone
    /// </summary>
    public string? Phone { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Role
    /// </summary>
    public string? Role { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact State
    /// </summary>
    public StringEnumValue<State> State { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }

    /// <summary>
    /// MilestoneTaskContact Zip
    /// </summary>
    public string? Zip { get => GetValue<string?>(); set => SetValue(value); }
}