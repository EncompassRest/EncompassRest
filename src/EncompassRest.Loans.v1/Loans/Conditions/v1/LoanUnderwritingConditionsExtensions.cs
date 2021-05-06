using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Conditions.v1
{
    public static class LoanUnderwritingConditionsExtensions
    {
        public static ILoanUnderwritingConditionsV1? V1 { get; set; }

        private static ILoanUnderwritingConditionsV1 GetV1(ILoanUnderwritingConditions underwritingConditions)
        {
            var v1 = V1;
            if (underwritingConditions is LoanUnderwritingConditions c)
            {
                v1 = (ILoanUnderwritingConditionsV1)c.ExtensionData.GetOrAdd("v1", k => new LoanUnderwritingConditionsV1(c.Client, c.LoanApis, c.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(underwritingConditions, nameof(underwritingConditions));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, AssignmentAction action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => AssignConditionDocumentsAsync(underwritingConditions, conditionId, action.Validate(nameof(action)).GetValue()!, documents, cancellationToken);

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, string action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).AssignConditionDocumentsAsync(conditionId, action, documents, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan and returns the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanUnderwritingConditions underwritingConditions, UnderwritingCondition condition, CancellationToken cancellationToken = default) => CreateConditionAsync(underwritingConditions, condition, populate: false, cancellationToken);

        /// <summary>
        /// Creates a condion for the loan and returns the id of the condition created and optionally populates the condition object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="populate">Indicates if the condition object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanUnderwritingConditions underwritingConditions, UnderwritingCondition condition, bool populate, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).CreateConditionAsync(condition, populate, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, IEnumerable<Comment> comments, CancellationToken cancellationToken = default) => CreateConditionCommentsAsync(underwritingConditions, conditionId, comments, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition and optionally populates the comment objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="populate">Indicates if the comment objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, IEnumerable<Comment> comments, bool populate, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).CreateConditionCommentsAsync(conditionId, comments, populate, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan from raw json and returns the response's body if not empty else the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionRawAsync(this ILoanUnderwritingConditions underwritingConditions, string condition, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).CreateConditionRawAsync(condition, queryString, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, IEnumerable<UnderwritingCondition> conditions, CancellationToken cancellationToken = default) => CreateConditionsAsync(underwritingConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, IEnumerable<UnderwritingCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).CreateConditionsAsync(conditions, populate, cancellationToken);

        /// <summary>
        /// Deletes multiple condition comments from the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to remove comments.</param>
        /// <param name="commentIds">The ids of the condition comments to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionCommentsAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, IEnumerable<string> commentIds, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).DeleteConditionCommentsAsync(conditionId, commentIds, cancellationToken);

        /// <summary>
        /// Deletes multiple conditions from the loan.
        /// </summary>
        /// <param name="conditionIds">The ids of the conditions to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, IEnumerable<string> conditionIds, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).DeleteConditionsAsync(conditionIds, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<UnderwritingCondition> GetConditionAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).GetConditionAsync(conditionId, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionRawAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).GetConditionRawAsync(conditionId, queryString, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<UnderwritingCondition>> GetConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, ConditionQueryParameters? queryParameters = null, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).GetConditionsAsync(queryParameters, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionsRawAsync(this ILoanUnderwritingConditions underwritingConditions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).GetConditionsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Manages multiple condition comments from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add or remove comments.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionCommentsRawAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).ManageConditionCommentsRawAsync(conditionId, content, queryString, cancellationToken);
        /// <summary>
        /// Manages multiple condition documents from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionDocumentsRawAsync(this ILoanUnderwritingConditions underwritingConditions, string conditionId, string documents, string queryString, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).ManageConditionDocumentsRawAsync(conditionId, documents, queryString, cancellationToken);

        /// <summary>
        /// Manages multiple conditions from raw json.
        /// </summary>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionsRawAsync(this ILoanUnderwritingConditions underwritingConditions, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).ManageConditionsRawAsync(content, queryString, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, IEnumerable<UnderwritingCondition> conditions, CancellationToken cancellationToken = default) => UpdateConditionsAsync(underwritingConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanUnderwritingConditions underwritingConditions, IEnumerable<UnderwritingCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(underwritingConditions).UpdateConditionsAsync(conditions, populate, cancellationToken);
    }
}