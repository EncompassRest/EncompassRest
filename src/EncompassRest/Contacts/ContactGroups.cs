using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Contacts
{
    /// <summary>
    /// The Contact Groups Apis.
    /// </summary>
    public interface IContactGroups : IApiObject
    {
        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignGroupContactsAsync(string groupId, AssignmentAction action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignGroupContactsAsync(string groupId, string action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds or removes contacts in a contact group from raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="contacts">The contacts to add or remove as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignGroupContactsRawAsync(string groupId, string contacts, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id.
        /// </summary>
        /// <param name="group">The contact group to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="group">The contact group to create.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateGroupAsync(ContactGroup group, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new borrower or business contact group from raw json and returns the response's body if not empty else the contact group's id.
        /// </summary>
        /// <param name="group">The contact group to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateGroupRawAsync(string group, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteGroupAsync(string groupId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<ContactGroup> GetGroupAsync(string groupId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all contacts associated with a specified group Id.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of items to return in a page. Response size is limited to 6 MB; however, the limit is recalculated if the response size exceeds 6 MB. The default value is 1000 and max value for this parameter is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<EntityReference>> GetGroupContactsAsync(string groupId, int? start = null, int? limit = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns all contacts associated with a specified group Id as raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetGroupContactsRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetGroupRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ContactGroup>> GetGroupsAsync(ContactType contactType, ContactGroupType? groupType = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<ContactGroup>> GetGroupsAsync(string contactType, string groupType = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request. This should include a contactType parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetGroupsRawAsync(string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteGroupAsync(string groupId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the details of the specified contact group.
        /// </summary>
        /// <param name="group">The contact group to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the details of the specified contact group and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="group">The contact group to update.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateGroupAsync(ContactGroup group, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the details of the specified contact group from raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="group">The contact group to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateGroupRawAsync(string groupId, string group, string queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Contact Groups Apis.
    /// </summary>
    public sealed class ContactGroups : ApiObject, IContactGroups
    {
        internal ContactGroups(EncompassRestClient client)
            : base(client, "encompass/v1/contactGroups")
        {
        }

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<ContactGroup>> GetGroupsAsync(ContactType contactType, ContactGroupType? groupType = null, CancellationToken cancellationToken = default) => GetGroupsAsync(contactType.Validate(nameof(contactType)).GetValue(), groupType?.Validate(nameof(groupType)).GetValue(), cancellationToken);

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<ContactGroup>> GetGroupsAsync(string contactType, string groupType = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(contactType, nameof(contactType));

            var queryParameters = new QueryParameters();
            queryParameters.Add(nameof(contactType), contactType);
            if (!string.IsNullOrEmpty(groupType))
            {
                queryParameters.Add(nameof(groupType), groupType);
            }

            return GetDirtyListAsync<ContactGroup>(null, queryParameters.ToString(), nameof(GetGroupsAsync), null, cancellationToken);
        }

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request. This should include a contactType parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetGroupsRawAsync(string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return GetRawAsync(null, queryString, nameof(GetGroupsRawAsync), null, cancellationToken);
        }

        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<ContactGroup> GetGroupAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetDirtyAsync<ContactGroup>(groupId, null, nameof(GetGroupAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetGroupRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetRawAsync(groupId, queryString, nameof(GetGroupRawAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Returns all contacts associated with a specified group Id.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of items to return in a page. Response size is limited to 6 MB; however, the limit is recalculated if the response size exceeds 6 MB. The default value is 1000 and max value for this parameter is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns all contacts associated with a specified group Id as raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetGroupContactsRawAsync(string groupId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return GetRawAsync($"{groupId}/contacts", queryString, nameof(GetGroupContactsRawAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id.
        /// </summary>
        /// <param name="group">The contact group to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default) => CreateGroupAsync(group, false, cancellationToken);

        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="group">The contact group to create.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateGroupAsync(ContactGroup group, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(group, nameof(group));
            Preconditions.NullOrEmpty(group.Id, $"{nameof(group)}.{nameof(group.Id)}");

            return PostPopulateDirtyAsync(null, nameof(CreateGroupAsync), group, populate, cancellationToken);
        }

        /// <summary>
        /// Creates a new borrower or business contact group from raw json and returns the response's body if not empty else the contact group's id.
        /// </summary>
        /// <param name="group">The contact group to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateGroupRawAsync(string group, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(group, nameof(group));

            return PostAsync(null, queryString, new JsonStringContent(group), nameof(CreateGroupRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AssignGroupContactsAsync(string groupId, AssignmentAction action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default) => AssignGroupContactsAsync(groupId, action.Validate(nameof(action)).GetValue(), contacts, cancellationToken);

        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AssignGroupContactsAsync(string groupId, string action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            Preconditions.NotNullOrEmpty(action, nameof(action));
            Preconditions.NotNullOrEmpty(contacts, nameof(contacts));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action));
            return PatchAsync($"{groupId}/contacts", queryParameters.ToString(), JsonStreamContent.Create(contacts), nameof(AssignGroupContactsAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Adds or removes contacts in a contact group from raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="contacts">The contacts to add or remove as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AssignGroupContactsRawAsync(string groupId, string contacts, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            Preconditions.NotNullOrEmpty(contacts, nameof(contacts));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchAsync($"{groupId}/contacts", queryString, new JsonStringContent(contacts), nameof(AssignGroupContactsRawAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Updates the details of the specified contact group.
        /// </summary>
        /// <param name="group">The contact group to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateGroupAsync(ContactGroup group, CancellationToken cancellationToken = default) => UpdateGroupAsync(group, false, cancellationToken);

        /// <summary>
        /// Updates the details of the specified contact group and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="group">The contact group to update.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateGroupAsync(ContactGroup group, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(group, nameof(group));
            Preconditions.NotNullOrEmpty(group.Id, $"{nameof(group)}.{nameof(group.Id)}");

            return PatchPopulateDirtyAsync(group.Id, JsonStreamContent.Create(group), nameof(UpdateGroupAsync), group.Id, group, populate, cancellationToken);
        }

        /// <summary>
        /// Updates the details of the specified contact group from raw json.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="group">The contact group to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> UpdateGroupRawAsync(string groupId, string group, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));
            Preconditions.NotNullOrEmpty(group, nameof(group));

            return PatchRawAsync(groupId, queryString, new JsonStringContent(group), nameof(UpdateGroupRawAsync), groupId, cancellationToken);
        }

        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> TryDeleteGroupAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return TryDeleteAsync(groupId, null, cancellationToken);
        }

        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task DeleteGroupAsync(string groupId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(groupId, nameof(groupId));

            return DeleteAsync(groupId, null, cancellationToken);
        }
    }
}