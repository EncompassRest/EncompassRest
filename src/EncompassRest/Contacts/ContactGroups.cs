using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Contacts
{
    public sealed class ContactGroups : ApiObject
    {
        internal ContactGroups(EncompassRestClient client)
            : base(client, "encompass/v1/contactGroups")
        {
        }

        public Task<List<ContactGroup>> GetGroupsAsync(ContactType contactType, ContactGroupType? groupType = null, CancellationToken cancellationToken = default)
        {
            contactType.Validate(nameof(contactType));

            var queryParameters = new QueryParameters();
            queryParameters.Add(nameof(contactType), contactType.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name));
            if (groupType.HasValue)
            {
                groupType.GetValueOrDefault().Validate(nameof(groupType));
                queryParameters.Add(nameof(groupType), groupType.GetValueOrDefault().AsString(EnumFormat.EnumMemberValue, EnumFormat.Name));
            }

            return GetDirtyListAsync<ContactGroup>(null, queryParameters.ToString(), nameof(GetGroupsAsync), null, cancellationToken);
        }

        public Task<string> GetGroupsRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync(null, queryString, nameof(GetGroupsRawAsync), null, cancellationToken);
        }

        public Task<ContactGroup> GetGroupAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetDirtyAsync<ContactGroup>(groupId, null, nameof(GetGroupAsync), groupId, cancellationToken);
        }

        public Task<string> GetGroupRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetRawAsync(groupId, queryString, nameof(GetGroupRawAsync), groupId, cancellationToken);
        }

        public Task<List<EntityReference>> GetGroupContactsAsync(string groupId, int? start = null, int? limit = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            var queryParameters = new QueryParameters();
            if (start.HasValue)
            {
                Preconditions.GreaterThanOrEquals(start.GetValueOrDefault(), nameof(start), 0);
                queryParameters.Add(nameof(start), start.ToString());
            }
            if (limit.HasValue)
            {
                Preconditions.GreaterThan(limit.GetValueOrDefault(), nameof(limit), 0);
                queryParameters.Add(nameof(limit), limit.ToString());
            }
            return GetAsync<List<EntityReference>>($"{groupId}/contacts", queryParameters.ToString(), nameof(GetGroupContactsAsync), groupId, cancellationToken);
        }

        public Task<string> GetGroupContactsRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetRawAsync($"{groupId}/contacts", queryString, nameof(GetGroupContactsRawAsync), groupId, cancellationToken);
        }

        public Task<string> CreateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(group, nameof(group));
            Preconditions.NullOrEmpty(group.Id, $"{nameof(group)}.{nameof(group.Id)}");

            return PostPopulateDirtyAsync(null, nameof(CreateGroupAsync), group, false, cancellationToken);
        }

        public Task<string> CreateGroupRawAsync(string group, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(group, nameof(group));

            return PostRawAsync(null, queryString, new JsonStringContent(group), nameof(CreateGroupRawAsync), null, cancellationToken);
        }

        public Task AssignGroupContactsAsync(string groupId, AssignmentAction action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            action.Validate(nameof(action));
            Preconditions.NotNullOrEmpty(contacts, nameof(contacts));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action.AsString(EnumJsonConverter.CamelCaseNameFormat)));
            return PatchAsync($"{groupId}/contacts", queryParameters.ToString(), JsonStreamContent.Create(contacts), nameof(AssignGroupContactsAsync), groupId, cancellationToken);
        }

        public Task AssignGroupContactsRawAsync(string groupId, string contacts, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            Preconditions.NotNullOrEmpty(contacts, nameof(contacts));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));
            
            return PatchAsync($"{groupId}/contacts", queryString, new JsonStringContent(contacts), nameof(AssignGroupContactsRawAsync), groupId, cancellationToken);
        }

        public Task UpdateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(group, nameof(group));
            Preconditions.NotNullOrEmpty(group.Id, $"{nameof(group)}.{nameof(group.Id)}");

            return PatchPopulateDirtyAsync(group.Id, JsonStreamContent.Create(group), nameof(UpdateGroupAsync), group.Id, group, false, true, cancellationToken);
        }

        public Task<string> UpdateGroupRawAsync(string groupId, string group, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            Preconditions.NotNullOrEmpty(group, nameof(group));

            return PatchRawAsync(groupId, queryString, new JsonStringContent(group), nameof(UpdateGroupRawAsync), groupId, cancellationToken);
        }

        public Task<bool> DeleteGroupAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return DeleteAsync(groupId, null, cancellationToken);
        }
    }
}