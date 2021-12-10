using EncompassRest.Schema;

namespace EncompassRest.Loans.v3;

/// <summary>
/// NewYorkPrimaryLender
/// </summary>
public sealed partial class NewYorkPrimaryLender : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _address;
    private DirtyValue<string?>? _city;
    private DirtyValue<string?>? _comments;
    private DirtyValue<string?>? _name;
    private DirtyValue<int?>? _newYorkPrimaryLenderIndex;
    private DirtyValue<string?>? _postalCode;
    private DirtyValue<string?>? _state;

    /// <summary>
    /// NewYorkPrimaryLenderContract Address
    /// </summary>
    public string? Address { get => _address; set => SetField(ref _address, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract City
    /// </summary>
    public string? City { get => _city; set => SetField(ref _city, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract Comments
    /// </summary>
    public string? Comments { get => _comments; set => SetField(ref _comments, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract Name
    /// </summary>
    public string? Name { get => _name; set => SetField(ref _name, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract NewYorkPrimaryLenderIndex
    /// </summary>
    public int? NewYorkPrimaryLenderIndex { get => _newYorkPrimaryLenderIndex; set => SetField(ref _newYorkPrimaryLenderIndex, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract PostalCode
    /// </summary>
    [LoanFieldProperty(Format = LoanFieldFormat.ZIPCODE)]
    public string? PostalCode { get => _postalCode; set => SetField(ref _postalCode, value); }

    /// <summary>
    /// NewYorkPrimaryLenderContract State
    /// </summary>
    public string? State { get => _state; set => SetField(ref _state, value); }
}