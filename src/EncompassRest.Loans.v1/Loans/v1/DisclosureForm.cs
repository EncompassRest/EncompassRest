using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v1;

/// <summary>
/// DisclosureForm
/// </summary>
public sealed partial class DisclosureForm : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureForm FormName
    /// </summary>
    public string? FormName { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureForm FormType
    /// </summary>
    public StringEnumValue<DisclosureFormType> FormType { get => GetValue<StringEnumValue<DisclosureFormType>>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureForm Id
    /// </summary>
    public string? Id { get => GetValue<string?>(); set => SetValue(value); }
}