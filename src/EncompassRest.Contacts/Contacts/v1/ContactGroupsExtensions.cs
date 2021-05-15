using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Contacts.v1
{
    /// <summary>
    /// The Contact Groups Api extension methods.
    /// </summary>
    public static class ContactGroupsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static IContactGroupsV1? V1 { get; set; }

        private static IContactGroupsV1 GetV1(IContactGroups contactGroups)
        {
            var v1 = V1;
            if (contactGroups is ContactGroups g)
            {
                v1 = g.ExtensionData.GetOrAdd(() => new ContactGroupsV1(g.Client));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(contactGroups, nameof(contactGroups));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignGroupContactsAsync(this IContactGroups contactGroups, string groupId, AssignmentAction action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default) => AssignGroupContactsAsync(contactGroups, groupId, action.Validate(nameof(action)).GetValue()!, contacts, cancellationToken);

        /// <summary>
        /// Adds or removes contacts in a contact group.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="action">Whether to add or remove the contact.</param>
        /// <param name="contacts">The contacts to add or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignGroupContactsAsync(this IContactGroups contactGroups, string groupId, string action, IEnumerable<EntityReference> contacts, CancellationToken cancellationToken = default) => GetV1(contactGroups).AssignGroupContactsAsync(groupId, action, contacts, cancellationToken);

        /// <summary>
        /// Adds or removes contacts in a contact group from raw json.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="contacts">The contacts to add or remove as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignGroupContactsRawAsync(this IContactGroups contactGroups, string groupId, string contacts, string queryString, CancellationToken cancellationToken = default) => GetV1(contactGroups).AssignGroupContactsRawAsync(groupId, contacts, queryString, cancellationToken);

        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="group">The contact group to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateGroupAsync(this IContactGroups contactGroups, ContactGroup group, CancellationToken cancellationToken = default) => CreateGroupAsync(contactGroups, group, populate: false, cancellationToken);

        /// <summary>
        /// Creates a new borrower or business contact group and returns the contact group's id and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="group">The contact group to create.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateGroupAsync(this IContactGroups contactGroups, ContactGroup group, bool populate, CancellationToken cancellationToken = default) => GetV1(contactGroups).CreateGroupAsync(group, populate, cancellationToken);

        /// <summary>
        /// Creates a new borrower or business contact group from raw json and returns the response's body if not empty else the contact group's id.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="group">The contact group to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateGroupRawAsync(this IContactGroups contactGroups, string group, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).CreateGroupRawAsync(group, queryString, cancellationToken);

        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task DeleteGroupAsync(this IContactGroups contactGroups, string groupId, CancellationToken cancellationToken = default) => GetV1(contactGroups).DeleteGroupAsync(groupId, cancellationToken);

        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<ContactGroup> GetGroupAsync(this IContactGroups contactGroups, string groupId, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupAsync(groupId, cancellationToken);

        /// <summary>
        /// Returns all contacts associated with a specified group Id.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="start">Starting index or record number from which to retrieve the contacts. The default is 1.</param>
        /// <param name="limit">The maximum number of items to return in a page. Response size is limited to 6 MB; however, the limit is recalculated if the response size exceeds 6 MB. The default value is 1000 and max value for this parameter is limited to 10000.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<EntityReference>> GetGroupContactsAsync(this IContactGroups contactGroups, string groupId, int? start = null, int? limit = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupContactsAsync(groupId, start, limit, cancellationToken);

        /// <summary>
        /// Returns all contacts associated with a specified group Id as raw json.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetGroupContactsRawAsync(this IContactGroups contactGroups, string groupId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupContactsRawAsync(groupId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves information about the specified contact group.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetGroupRawAsync(this IContactGroups contactGroups, string groupId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupRawAsync(groupId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactGroup>> GetGroupsAsync(this IContactGroups contactGroups, ContactType contactType, ContactGroupType? groupType = null, CancellationToken cancellationToken = default) => GetGroupsAsync(contactGroups, contactType.Validate(nameof(contactType)).GetValue()!, groupType?.Validate(nameof(groupType)).GetValue(), cancellationToken);

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="contactType">The contact type.</param>
        /// <param name="groupType">The contact group type.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<ContactGroup>> GetGroupsAsync(this IContactGroups contactGroups, string contactType, string? groupType = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupsAsync(contactType, groupType, cancellationToken);

        /// <summary>
        /// Retrieves all contact groups for a given contact type and group type as raw json.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="queryString">The query string to include in the request. This should include a contactType parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetGroupsRawAsync(this IContactGroups contactGroups, string queryString, CancellationToken cancellationToken = default) => GetV1(contactGroups).GetGroupsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Permanently removes the specified contact group from the Encompass contacts database.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> TryDeleteGroupAsync(this IContactGroups contactGroups, string groupId, CancellationToken cancellationToken = default) => GetV1(contactGroups).TryDeleteGroupAsync(groupId, cancellationToken);

        /// <summary>
        /// Updates the details of the specified contact group.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="group">The contact group to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateGroupAsync(this IContactGroups contactGroups, ContactGroup group, CancellationToken cancellationToken = default) => UpdateGroupAsync(contactGroups, group, populate: false, cancellationToken);

        /// <summary>
        /// Updates the details of the specified contact group and optionally populates the contact group object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="group">The contact group to update.</param>
        /// <param name="populate">Indicates if the contact group object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateGroupAsync(this IContactGroups contactGroups, ContactGroup group, bool populate, CancellationToken cancellationToken = default) => GetV1(contactGroups).UpdateGroupAsync(group, populate, cancellationToken);

        /// <summary>
        /// Updates the details of the specified contact group from raw json.
        /// </summary>
        /// <param name="contactGroups">The Contact Groups Api Object.</param>
        /// <param name="groupId">The unique identifier of the contact group to update.</param>
        /// <param name="group">The contact group to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateGroupRawAsync(this IContactGroups contactGroups, string groupId, string group, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(contactGroups).UpdateGroupRawAsync(groupId, group, queryString, cancellationToken);
    }
}