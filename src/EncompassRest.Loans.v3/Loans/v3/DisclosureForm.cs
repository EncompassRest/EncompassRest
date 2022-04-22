using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

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
    /// DisclosureForm SignatureType
    /// </summary>
    public StringEnumValue<DisclosureFormSignatureType> SignatureType { get => GetValue<StringEnumValue<DisclosureFormSignatureType>>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureForm ViewableFormFile
    /// </summary>
    public string? ViewableFormFile { get => GetValue<string?>(); set => SetValue(value); }
}