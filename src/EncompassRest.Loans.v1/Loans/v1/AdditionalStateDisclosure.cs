using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AdditionalStateDisclosure
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(DisclosureName) + "," + nameof(StateCode))]
public sealed partial class AdditionalStateDisclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AdditionalStateDisclosure DisclosureName
    /// </summary>
    public StringEnumValue<DisclosureName> DisclosureName { get => GetValue<StringEnumValue<DisclosureName>>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalStateDisclosure DisclosureValue
    /// </summary>
    public string? DisclosureValue { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalStateDisclosure Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalStateDisclosure StateCode
    /// </summary>
    public StringEnumValue<State> StateCode { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }
}