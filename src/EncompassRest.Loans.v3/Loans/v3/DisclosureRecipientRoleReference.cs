using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipientRoleReference
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(EntityType))]
public sealed partial class DisclosureRecipientRoleReference : EntityReference, IIdentifiable
{
    private ApplicationReference? _application;
    private DirtyValue<string?>? _entityDescription;
    private DirtyValue<string?>? _legacyId;

    /// <summary>
    /// DisclosureRecipientRoleReferenceContract Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetField(ref _application); set => SetField(ref _application, value); }

    /// <summary>
    /// DisclosureRecipientRoleReferenceContract EntityDescription
    /// </summary>
    public string? EntityDescription { get => _entityDescription; set => SetField(ref _entityDescription, value); }

    /// <summary>
    /// DisclosureRecipientRoleReferenceContract LegacyId
    /// </summary>
    public string? LegacyId { get => _legacyId; set => SetField(ref _legacyId, value); }
}