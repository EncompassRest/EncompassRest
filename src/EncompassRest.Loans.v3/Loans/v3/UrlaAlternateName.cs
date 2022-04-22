namespace EncompassRest.Loans.v3;

/// <summary>
/// UrlaAlternateName
/// </summary>
[Entity(SerializeWholeListWhenDirty = true)]
public sealed partial class UrlaAlternateName : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// UrlaAlternateName AltId [URLABAKA0006], [URLACAKA0006]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName FirstName [URLABAKA0001], [URLACAKA0001]
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName FullName [URLABAKA0005], [URLACAKA0005]
    /// </summary>
    public string? FullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName LastName [URLABAKA0003], [URLACAKA0003]
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName MiddleName [URLABAKA0002], [URLACAKA0002]
    /// </summary>
    public string? MiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// UrlaAlternateName Suffix [URLABAKA0004], [URLACAKA0004]
    /// </summary>
    public string? Suffix { get => GetValue<string?>(); set => SetValue(value); }
}