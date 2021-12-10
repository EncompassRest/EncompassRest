using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AdditionalStateDisclosure
/// </summary>
public sealed partial class AdditionalStateDisclosure : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<StringEnumValue<DisclosureName>>? _disclosureName;
    private DirtyValue<StringEnumValue<State>>? _stateCode;

    /// <summary>
    /// AdditionalStateDisclosureContract DisclosureName
    /// </summary>
    public StringEnumValue<DisclosureName> DisclosureName { get => _disclosureName; set => SetField(ref _disclosureName, value); }

    /// <summary>
    /// AdditionalStateDisclosureContract StateCode
    /// </summary>
    public StringEnumValue<State> StateCode { get => _stateCode; set => SetField(ref _stateCode, value); }
}