using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureTrackingDocuments
/// </summary>
public sealed partial class DisclosureTrackingDocuments : DirtyExtensibleObject, IIdentifiable
{
    private DirtyList<DisclosureForm>? _forms;
    private DirtyValue<string?>? _viewableFormsFile;

    /// <summary>
    /// DisclosureTrackingDocumentsContract Forms
    /// </summary>
    [AllowNull]
    public IList<DisclosureForm> Forms { get => GetField(ref _forms); set => SetField(ref _forms, value); }

    /// <summary>
    /// DisclosureTrackingDocumentsContract ViewableFormsFile
    /// </summary>
    public string? ViewableFormsFile { get => _viewableFormsFile; set => SetField(ref _viewableFormsFile, value); }
}