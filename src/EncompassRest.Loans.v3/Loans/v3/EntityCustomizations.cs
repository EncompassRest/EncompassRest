using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Loans.v3;

partial class DisclosureRecipientRoleReference
{
    /// <summary>
    /// DisclosureRecipientRoleReference constructor.
    /// </summary>
    /// <param name="entityId">The entity id.</param>
    /// <param name="entityType">The entity type.</param>
    public DisclosureRecipientRoleReference(string entityId, EntityType entityType)
        : base(entityId, entityType)
    {
    }

    /// <summary>
    /// DisclosureRecipientRoleReference constructor.
    /// </summary>
    /// <param name="entityId">The entity id.</param>
    /// <param name="entityType">The entity type.</param>
    public DisclosureRecipientRoleReference(string entityId, string entityType)
        : base(entityId, entityType)
    {
    }

    /// <summary>
    /// DisclosureRecipientRoleReference deserialization constructor.
    /// </summary>
    [Obsolete("Use another constructor instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [JsonConstructor]
    public DisclosureRecipientRoleReference()
    {
    }
}

partial class CustomField
{
    [IdPropertyName(nameof(FieldName))]
    string? IIdentifiable.Id { get => FieldName; set => FieldName = value; }
}

partial class DisclosureForm
{
    [IdPropertyName(nameof(FormName))]
    string? IIdentifiable.Id { get => FormName; set => FormName = value; }
}

partial class OrderedDocumentOverflow
{
    [IdPropertyName(nameof(FieldName))]
    string? IIdentifiable.Id { get => FieldName; set => FieldName = value; }
}