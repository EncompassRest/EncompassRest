using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Conditions.v1
{
    /// <summary>
    /// The Loan Preliminary Conditions Api extension methods.
    /// </summary>
    public static class LoanPreliminaryConditionsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanPreliminaryConditionsV1? V1 { get; set; }

        private static ILoanPreliminaryConditionsV1 GetV1(ILoanPreliminaryConditions preliminaryConditions)
        {
            var v1 = V1;
            if (preliminaryConditions is LoanPreliminaryConditions c)
            {
                v1 = c.ExtensionData.GetOrAdd(() => new LoanPreliminaryConditionsV1(c.Client, c.LoanApis, c.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(preliminaryConditions, nameof(preliminaryConditions));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
        }

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, AssignmentAction action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => AssignConditionDocumentsAsync(preliminaryConditions, conditionId, action.Validate(nameof(action)).GetValue(), documents, cancellationToken);

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignConditionDocumentsAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, string action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).AssignConditionDocumentsAsync(conditionId, action, documents, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan and returns the id of the condition created.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="condition">The condition to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanPreliminaryConditions preliminaryConditions, PreliminaryCondition condition, CancellationToken cancellationToken = default) => CreateConditionAsync(preliminaryConditions, condition, populate: false, cancellationToken);

        /// <summary>
        /// Creates a condion for the loan and returns the id of the condition created and optionally populates the condition object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="condition">The condition to create.</param>
        /// <param name="populate">Indicates if the condition object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionAsync(this ILoanPreliminaryConditions preliminaryConditions, PreliminaryCondition condition, bool populate, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).CreateConditionAsync(condition, populate, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, IEnumerable<Comment> comments, CancellationToken cancellationToken = default) => CreateConditionCommentsAsync(preliminaryConditions, conditionId, comments, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition and optionally populates the comment objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="populate">Indicates if the comment objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionCommentsAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, IEnumerable<Comment> comments, bool populate, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).CreateConditionCommentsAsync(conditionId, comments, populate, cancellationToken);

        /// <summary>
        /// Creates a condition for the loan from raw json and returns the response's body if not empty else the id of the condition created.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="condition">The condition to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateConditionRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string condition, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).CreateConditionRawAsync(condition, queryString, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, IEnumerable<PreliminaryCondition> conditions, CancellationToken cancellationToken = default) => CreateConditionsAsync(preliminaryConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task CreateConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, IEnumerable<PreliminaryCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).CreateConditionsAsync(conditions, populate, cancellationToken);

        /// <summary>
        /// Deletes multiple condition comments from the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to remove comments.</param>
        /// <param name="commentIds">The ids of the condition comments to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionCommentsAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, IEnumerable<string> commentIds, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).DeleteConditionCommentsAsync(conditionId, commentIds, cancellationToken);

        /// <summary>
        /// Deletes multiple conditions from the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionIds">The ids of the conditions to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<bool> DeleteConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, IEnumerable<string> conditionIds, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).DeleteConditionsAsync(conditionIds, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<PreliminaryCondition> GetConditionAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).GetConditionAsync(conditionId, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).GetConditionRawAsync(conditionId, queryString, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<PreliminaryCondition>> GetConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, ConditionQueryParameters? queryParameters = null, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).GetConditionsAsync(queryParameters, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetConditionsRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).GetConditionsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Manages multiple condition comments from raw json.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add or remove comments.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionCommentsRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).ManageConditionCommentsRawAsync(conditionId, content, queryString, cancellationToken);
        /// <summary>
        /// Manages multiple condition documents from raw json.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionDocumentsRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string conditionId, string documents, string queryString, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).ManageConditionDocumentsRawAsync(conditionId, documents, queryString, cancellationToken);

        /// <summary>
        /// Manages multiple conditions from raw json.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageConditionsRawAsync(this ILoanPreliminaryConditions preliminaryConditions, string content, string queryString, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).ManageConditionsRawAsync(content, queryString, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, IEnumerable<PreliminaryCondition> conditions, CancellationToken cancellationToken = default) => UpdateConditionsAsync(preliminaryConditions, conditions, populate: false, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="preliminaryConditions">The Loan Preliminary Conditions Api Object.</param>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateConditionsAsync(this ILoanPreliminaryConditions preliminaryConditions, IEnumerable<PreliminaryCondition> conditions, bool populate, CancellationToken cancellationToken = default) => GetV1(preliminaryConditions).UpdateConditionsAsync(conditions, populate, cancellationToken);
    }
}