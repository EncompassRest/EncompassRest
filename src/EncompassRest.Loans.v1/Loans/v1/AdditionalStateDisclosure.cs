using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// AdditionalStateDisclosure
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(DisclosureName) + "," + nameof(StateCode))]
public sealed partial class AdditionalStateDisclosure : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<DisclosureName>>? _disclosureName;
    private DirtyValue<string?>? _disclosureValue;
    private DirtyValue<string?>? _id;
    private DirtyValue<StringEnumValue<State>>? _stateCode;

    /// <summary>
    /// AdditionalStateDisclosure DisclosureName
    /// </summary>
    public StringEnumValue<DisclosureName> DisclosureName { get => _disclosureName; set => SetField(ref _disclosureName, value); }

    /// <summary>
    /// AdditionalStateDisclosure DisclosureValue
    /// </summary>
    public string? DisclosureValue { get => _disclosureValue; set => SetField(ref _disclosureValue, value); }

    /// <summary>
    /// AdditionalStateDisclosure Id
    /// </summary>
    public string? Id { get => _id; set => SetField(ref _id, value); }

    /// <summary>
    /// AdditionalStateDisclosure StateCode
    /// </summary>
    public StringEnumValue<State> StateCode { get => _stateCode; set => SetField(ref _stateCode, value); }
}