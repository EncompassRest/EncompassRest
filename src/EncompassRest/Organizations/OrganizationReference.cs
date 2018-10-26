using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace EncompassRest.Organizations
{
    public sealed class OrganizationReference : EntityReference
    {
        private DirtyValue<string> _parentOrgId;
        private DirtyValue<string> _orgId;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrgId { get => _parentOrgId; set => SetField(ref _parentOrgId, value); }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string OrgId { get => _orgId; set => SetField(ref _orgId, value); }

        public OrganizationReference(string entityId, EntityType entityType)
            : base(entityId, entityType)
        {
        }

        public OrganizationReference(string entityId, string entityType)
            : base(entityId, entityType)
        {
        }

        [Obsolete("Use another constructor instead.")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsonConstructor]
        public OrganizationReference()
        {
        }
    }
}