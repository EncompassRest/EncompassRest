using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// AdditionalStateDisclosure
/// </summary>
public sealed partial class AdditionalStateDisclosure : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// AdditionalStateDisclosure DisclosureName
    /// </summary>
    public StringEnumValue<DisclosureName> DisclosureName { get => GetValue<StringEnumValue<DisclosureName>>(); set => SetValue(value); }

    /// <summary>
    /// AdditionalStateDisclosure StateCode
    /// </summary>
    public StringEnumValue<State> StateCode { get => GetValue<StringEnumValue<State>>(); set => SetValue(value); }
}