using EncompassRest.Schema;

namespace EncompassRest.Loans.v1;

/// <summary>
/// NewYorkPrimaryLender
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(NewYorkPrimaryLenderIndex))]
public sealed partial class NewYorkPrimaryLender : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _name;
    private DirtyValue<int?>? _newYorkPrimaryLenderIndex;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<StringEnumValue<State>>? _state;

    /// <summary>
    /// NewYorkPrimaryLender Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// NewYorkPrimaryLender City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// NewYorkPrimaryLender Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// NewYorkPrimaryLender Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// NewYorkPrimaryLender Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// NewYorkPrimaryLender NewYorkPrimaryLenderIndex
    /// </summary>
    public int? NewYorkPrimaryLenderIndex { get => _newYorkPrimaryLenderIndex; set => SetField(ref _newYorkPrimaryLenderIndex, value); }

    /// <summary>
    /// NewYorkPrimaryLender PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// NewYorkPrimaryLender State
    /// </summary>
    public StringEnumValue<State> State { get => _state; set => SetField(ref _state, value); }
}