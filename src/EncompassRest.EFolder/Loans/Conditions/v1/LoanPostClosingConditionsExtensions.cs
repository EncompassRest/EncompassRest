using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan Post Closing Conditions Api extension methods.
    /// </summary>
    public static class LoanPostClosingConditionsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanPostClosingConditionsV1? V1 { get; set; }

        private static ILoanPostClosingConditionsV1 GetV1(ILoanPostClosingConditions postClosingConditions)
        {
            var v1 = V1;
            if (postClosingConditions is LoanPostClosingConditions c)
            {
                v1 = c.ExtensionData.GetOrAdd(() => new LoanPostClosingConditionsV1(c.Client, c.LoanApis, c.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(postClosingConditions, nameof(postClosingConditions));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, AssignmentAction action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => AssignConditionDocumentsAsync(postClosingConditions, conditionId, action.Validate(nameof(action)).GetValue(), documents, cancellationToken);

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, string action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).AssignConditionDocumentsAsync(conditionId, action, documents, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan and returns the id of the condition created.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="condition">The condition to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanPostClosingConditions postClosingConditions, PostClosingCondition condition, CancellationToken cancellationToken = default) => CreateConditionAsync(postClosingConditions, condition, populate: false, cancellationToken);

        /// <summary>
        /// Creates a condion for the loan and returns the id of the condition created and optionally populates the condition object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="condition">The condition to create.</param>
        /// <param name="populate">Indicates if the condition object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanPostClosingConditions postClosingConditions, PostClosingCondition condition, bool populate, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).CreateConditionAsync(condition, populate, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, IEnumerable<Comment> comments, CancellationToken cancellationToken = default) => CreateConditionCommentsAsync(postClosingConditions, conditionId, comments, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition and optionally populates the comment objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="populate">Indicates if the comment objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, IEnumerable<Comment> comments, bool populate, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).CreateConditionCommentsAsync(conditionId, comments, populate, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan from raw json and returns the response's body if not empty else the id of the condition created.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="condition">The condition to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionRawAsync(this ILoanPostClosingConditions postClosingConditions, string condition, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).CreateConditionRawAsync(condition, queryString, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanPostClosingConditions postClosingConditions, IEnumerable<PostClosingCondition> conditions, CancellationToken cancellationToken = default) => CreateConditionsAsync(postClosingConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanPostClosingConditions postClosingConditions, IEnumerable<PostClosingCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).CreateConditionsAsync(conditions, populate, cancellationToken);

        /// <summary>
        /// Deletes multiple condition comments from the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to remove comments.</param>
        /// <param name="commentIds">The ids of the condition comments to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionCommentsAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, IEnumerable<string> commentIds, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).DeleteConditionCommentsAsync(conditionId, commentIds, cancellationToken);

        /// <summary>
        /// Deletes multiple conditions from the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionIds">The ids of the conditions to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionsAsync(this ILoanPostClosingConditions postClosingConditions, IEnumerable<string> conditionIds, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).DeleteConditionsAsync(conditionIds, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<PostClosingCondition> GetConditionAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).GetConditionAsync(conditionId, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionRawAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).GetConditionRawAsync(conditionId, queryString, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<PostClosingCondition>> GetConditionsAsync(this ILoanPostClosingConditions postClosingConditions, ConditionQueryParameters? queryParameters = null, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).GetConditionsAsync(queryParameters, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionsRawAsync(this ILoanPostClosingConditions postClosingConditions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).GetConditionsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Manages multiple condition comments from raw json.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add or remove comments.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionCommentsRawAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).ManageConditionCommentsRawAsync(conditionId, content, queryString, cancellationToken);
        /// <summary>
        /// Manages multiple condition documents from raw json.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionDocumentsRawAsync(this ILoanPostClosingConditions postClosingConditions, string conditionId, string documents, string queryString, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).ManageConditionDocumentsRawAsync(conditionId, documents, queryString, cancellationToken);

        /// <summary>
        /// Manages multiple conditions from raw json.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionsRawAsync(this ILoanPostClosingConditions postClosingConditions, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).ManageConditionsRawAsync(content, queryString, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanPostClosingConditions postClosingConditions, IEnumerable<PostClosingCondition> conditions, CancellationToken cancellationToken = default) => UpdateConditionsAsync(postClosingConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="postClosingConditions">The Loan Post Closing Conditions Api Object.</param>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanPostClosingConditions postClosingConditions, IEnumerable<PostClosingCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(postClosingConditions).UpdateConditionsAsync(conditions, populate, cancellationToken);
    }
}