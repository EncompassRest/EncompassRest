namespace EncompassRest.Loans.v3;

/// <summary>
/// UrlaAlternateName
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class UrlaAlternateName : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _altId;
    private DirtyValue<string?>? _firstName;
    private DirtyValue<string?>? _fullName;
    private DirtyValue<string?>? _id;
    private DirtyValue<string?>? _lastName;
    private DirtyValue<string?>? _middleName;
    private DirtyValue<string?>? _suffix;

    /// <summary>
    /// UrlaAlternateNameContract AltId [URLABAKA0006], [URLACAKA0006]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => _altId; set => SetField(ref _altId, value); }

    /// <summary>
    /// UrlaAlternateNameContract FirstName [URLABAKA0001], [URLACAKA0001]
    /// </summary>
    public string? FirstName { get => _firstName; set => SetField(ref _firstName, value); }

    /// <summary>
    /// UrlaAlternateNameContract FullName [URLABAKA0005], [URLACAKA0005]
    /// </summary>
    public string? FullName { get => _fullName; set => SetField(ref _fullName, value); }

    /// <summary>
    /// UrlaAlternateNameContract Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// UrlaAlternateNameContract LastName [URLABAKA0003], [URLACAKA0003]
    /// </summary>
    public string? LastName { get => _lastName; set => SetField(ref _lastName, value); }

    /// <summary>
    /// UrlaAlternateNameContract MiddleName [URLABAKA0002], [URLACAKA0002]
    /// </summary>
    public string? MiddleName { get => _middleName; set => SetField(ref _middleName, value); }

    /// <summary>
    /// UrlaAlternateNameContract Suffix [URLABAKA0004], [URLACAKA0004]
    /// </summary>
    public string? Suffix { get => _suffix; set => SetField(ref _suffix, value); }
}