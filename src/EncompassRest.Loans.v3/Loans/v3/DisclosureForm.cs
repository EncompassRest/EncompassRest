using EncompassRest.Loans.Enums;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureForm
/// </summary>
public sealed partial class DisclosureForm : DirtyExtensibleObject, IIdentifiable
{
    private DirtyValue<string?>? _formName;
    private DirtyValue<StringEnumValue<DisclosureFormType>>? _formType;
    private DirtyValue<StringEnumValue<DisclosureFormSignatureType>>? _signatureType;
    private DirtyValue<string?>? _viewableFormFile;

    /// <summary>
    /// DisclosureFormContract FormName
    /// </summary>
    public string? FormName { get => _formName; set => SetField(ref _formName, value); }

    /// <summary>
    /// DisclosureFormContract FormType
    /// </summary>
    public StringEnumValue<DisclosureFormType> FormType { get => _formType; set => SetField(ref _formType, value); }

    /// <summary>
    /// DisclosureFormContract SignatureType
    /// </summary>
    public StringEnumValue<DisclosureFormSignatureType> SignatureType { get => _signatureType; set => SetField(ref _signatureType, value); }

    /// <summary>
    /// DisclosureFormContract ViewableFormFile
    /// </summary>
    public string? ViewableFormFile { get => _viewableFormFile; set => SetField(ref _viewableFormFile, value); }
}