using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureTrackingDocuments
/// </summary>
public sealed partial class DisclosureTrackingDocuments : DirtyExtensibleObject, IIdentifiable
{
    /// <summary>
    /// DisclosureTrackingDocuments Forms
    /// </summary>
    [AllowNull]
    public IList<DisclosureForm> Forms { get => GetList<DisclosureForm>(); set => SetList(value); }

    /// <summary>
    /// DisclosureTrackingDocuments ViewableFormsFile
    /// </summary>
    public string? ViewableFormsFile { get => GetValue<string?>(); set => SetValue(value); }
}