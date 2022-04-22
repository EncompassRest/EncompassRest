using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// URLAAlternateName
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(Owner), SerializeWholeListWhenDirty = true)]
public sealed partial class URLAAlternateName : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// URLAAlternateName AltId [URLABAKANN06], [URLACAKANN06]
    /// </summary>
    [LoanFieldProperty(ReadOnly = true)]
    public string? AltId { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName Contact
    /// </summary>
    public EntityReference? Contact { get => GetValue<EntityReference?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName EntityDeleted
    /// </summary>
    public bool? EntityDeleted { get => GetValue<bool?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName FirstName [URLABAKANN01], [URLACAKANN01]
    /// </summary>
    public string? FirstName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName FullName [URLABAKANN05], [URLACAKANN05]
    /// </summary>
    public string? FullName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName LastName [URLABAKANN03], [URLACAKANN03]
    /// </summary>
    public string? LastName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName MiddleName [URLABAKANN02], [URLACAKANN02]
    /// </summary>
    public string? MiddleName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName Owner
    /// </summary>
    public StringEnumValue<BorrowerOrCoBorrower> Owner { get => GetValue<StringEnumValue<BorrowerOrCoBorrower>>(); set => SetValue(value); }

    /// <summary>
    /// URLAAlternateName Suffix [URLABAKANN04], [URLACAKANN04]
    /// </summary>
    public string? Suffix { get => GetValue<string?>(); set => SetValue(value); }
}