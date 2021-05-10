using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing information about the child branches and users of the organization.
    /// </summary>
    public sealed class OrganizationReference : EntityReference
    {
        private DirtyValue<string?>? _parentOrgId;
        private DirtyValue<string?>? _orgId;

        /// <summary>
        /// OrganizationReference ParentOrgId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentOrgId { get => _parentOrgId; set => SetField(ref _parentOrgId, value); }

        /// <summary>
        /// OrganizationReference OrgId
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? OrgId { get => _orgId; set => SetField(ref _orgId, value); }

        /// <summary>
        /// OrganizationReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public OrganizationReference(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// OrganizationReference constructor.
        /// </summary>
        /// <param name="entityId">The entity id.</param>
        /// <param name="entityType">The entity type.</param>
        public OrganizationReference(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        /// <summary>
        /// OrganizationReference deserialization constructor.
        /// </summary>
        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public OrganizationReference()
        {
        }
    }
}