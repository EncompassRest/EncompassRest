using System.Diagnostics.CodeAnalysis;
namespace EncompassRest.Loans.v3;

/// <summary>
/// DisclosureRecipientRoleReference
/// </summary>
[Entity(PropertiesToAlwaysSerialize = nameof(EntityType))]
public sealed partial class DisclosureRecipientRoleReference : EntityReference, IIdentifiable
{
    /// <summary>
    /// DisclosureRecipientRoleReference Application
    /// </summary>
    [AllowNull]
    public ApplicationReference Application { get => GetEntity<ApplicationReference>(); set => SetEntity(value); }

    /// <summary>
    /// DisclosureRecipientRoleReference EntityDescription
    /// </summary>
    public string? EntityDescription { get => GetValue<string?>(); set => SetValue(value); }

    /// <summary>
    /// DisclosureRecipientRoleReference LegacyId
    /// </summary>
    public string? LegacyId { get => GetValue<string?>(); set => SetValue(value); }
}