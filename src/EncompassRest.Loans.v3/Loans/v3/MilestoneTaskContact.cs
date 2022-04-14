namespace EncompassRest.Loans.v3;

/// <summary>
/// MilestoneTaskContact
/// </summary>
public sealed partial class MilestoneTaskContact : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _contactId;
    private DirtyValue<string?>? _email;
    private DirtyValue<string?>? _guid;
    private DirtyValue<string?>? _name;
    private DirtyValue<string?>? _phone;
    private DirtyValue<string?>? _role;
    private DirtyValue<StringEnumValue<State>>? _state;
    private DirtyValue<string?>? _zip;

    /// <summary>
    /// MilestoneTaskContactContract Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// MilestoneTaskContactContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// MilestoneTaskContactContract ContactId
    /// </summary>
    public string? ContactId { get => _contactId; set => SetField(ref _contactId, value); }

    /// <summary>
    /// MilestoneTaskContactContract Email
    /// </summary>
    public string? Email { get => _email; set => SetField(ref _email, value); }

    /// <summary>
    /// MilestoneTaskContactContract Guid
    /// </summary>
    public string? Guid { get => _guid; set => SetField(ref _guid, value); }

    /// <summary>
    /// MilestoneTaskContactContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// MilestoneTaskContactContract Phone
    /// </summary>
    public string? Phone { get => _phone; set => SetField(ref _phone, value); }

    /// <summary>
    /// MilestoneTaskContactContract Role
    /// </summary>
    public string? Role { get => _role; set => SetField(ref _role, value); }

    /// <summary>
    /// MilestoneTaskContactContract State
    /// </summary>
    public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }

    /// <summary>
    /// MilestoneTaskContactContract Zip
    /// </summary>
    public string? Zip { get => _zip; set => SetField(ref _zip, value); }
}