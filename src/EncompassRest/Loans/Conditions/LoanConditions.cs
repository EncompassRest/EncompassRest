using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Conditions
{
    /// <summary>
    /// The Loan Conditions Apis.
    /// </summary>
    public interface ILoanConditions : ILoanApiObject
    {
        /// <summary>
        /// The Loan PostClosing Conditions Apis.
        /// </summary>
        ILoanPostClosingConditions PostClosing { get; }
        /// <summary>
        /// The Loan Preliminary Conditions Apis.
        /// </summary>
        ILoanPreliminaryConditions Preliminary { get; }
        /// <summary>
        /// The Loan Underwriting Conditions Apis.
        /// </summary>
        ILoanUnderwritingConditions Underwriting { get; }
    }

    /// <summary>
    /// The Loan Conditions Apis.
    /// </summary>
    public sealed class LoanConditions : LoanApiObject, ILoanConditions
    {
        private LoanUnderwritingConditions _underwriting;
        private LoanPreliminaryConditions _preliminary;
        private LoanPostClosingConditions _postClosing;

        /// <summary>
        /// The Loan Underwriting Conditions Apis.
        /// </summary>
        public LoanUnderwritingConditions Underwriting => _underwriting ?? (_underwriting = new LoanUnderwritingConditions(Client, LoanId));

        ILoanUnderwritingConditions ILoanConditions.Underwriting => Underwriting;

        /// <summary>
        /// The Loan Preliminary Conditions Apis.
        /// </summary>
        public LoanPreliminaryConditions Preliminary => _preliminary ?? (_preliminary = new LoanPreliminaryConditions(Client, LoanId));

        ILoanPreliminaryConditions ILoanConditions.Preliminary => Preliminary;

        /// <summary>
        /// The Loan PostClosing Conditions Apis.
        /// </summary>
        public LoanPostClosingConditions PostClosing => _postClosing ?? (_postClosing = new LoanPostClosingConditions(Client, LoanId));

        ILoanPostClosingConditions ILoanConditions.PostClosing => PostClosing;

        internal LoanConditions(EncompassRestClient client, string loanId)
            : base(client, loanId, "conditions")
        {
        }
    }

    /// <summary>
    /// The Base Loan Conditions Apis Interface.
    /// </summary>
    /// <typeparam name="TCondition"></typeparam>
    public interface ILoanConditions<TCondition> : ILoanApiObject
        where TCondition : LoanCondition
    {
        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignConditionDocumentsAsync(string conditionId, AssignmentAction action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignConditionDocumentsAsync(string conditionId, string action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a condition for the loan and returns the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateConditionAsync(TCondition condition, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a condion for the loan and returns the id of the condition created and optionally populates the condition object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="populate">Indicates if the condition object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateConditionAsync(TCondition condition, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates multiple comments for the loan condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CreateConditionCommentsAsync(string conditionId, IEnumerable<Comment> comments, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates multiple comments for the loan condition and optionally populates the comment objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="populate">Indicates if the comment objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CreateConditionCommentsAsync(string conditionId, IEnumerable<Comment> comments, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a condition for the loan from raw json and returns the response's body if not empty else the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateConditionRawAsync(string condition, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CreateConditionsAsync(IEnumerable<TCondition> conditions, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CreateConditionsAsync(IEnumerable<TCondition> conditions, bool populate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes multiple condition comments from the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to remove comments.</param>
        /// <param name="commentIds">The ids of the condition comments to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> DeleteConditionCommentsAsync(string conditionId, IEnumerable<string> commentIds, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes multiple conditions from the loan.
        /// </summary>
        /// <param name="conditionIds">The ids of the conditions to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> DeleteConditionsAsync(IEnumerable<string> conditionIds, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<TCondition> GetConditionAsync(string conditionId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetConditionRawAsync(string conditionId, string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<TCondition>> GetConditionsAsync(ConditionQueryParameters queryParameters = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetConditionsRawAsync(string queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Manages multiple condition comments from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add or remove comments.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ManageConditionCommentsRawAsync(string conditionId, string content, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Manages multiple condition documents from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ManageConditionDocumentsRawAsync(string conditionId, string documents, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Manages multiple conditions from raw json.
        /// </summary>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> ManageConditionsRawAsync(string content, string queryString, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateConditionsAsync(IEnumerable<TCondition> conditions, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateConditionsAsync(IEnumerable<TCondition> conditions, bool populate, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Base Loan Conditions Apis Class.
    /// </summary>
    /// <typeparam name="TCondition"></typeparam>
    public abstract class LoanConditions<TCondition> : LoanApiObject, ILoanConditions<TCondition>
        where TCondition : LoanCondition
    {
        internal LoanConditions(EncompassRestClient client, string loanId, string baseApiPath)
            : base(client, loanId, $"conditions{baseApiPath?.PrecedeWith("/")}")
        {
        }

        /// <summary>
        /// Gets conditions for the loan.
        /// </summary>
        /// <param name="queryParameters">The condition query parameters to sent in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<List<TCondition>> GetConditionsAsync(ConditionQueryParameters queryParameters = null, CancellationToken cancellationToken = default) => GetDirtyListAsync<TCondition>(null, queryParameters?.ToString(), nameof(GetConditionsAsync), null, cancellationToken);

        /// <summary>
        /// Gets conditions for the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetConditionsRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetConditionsRawAsync), null, cancellationToken);

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<TCondition> GetConditionAsync(string conditionId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));

            return GetDirtyAsync<TCondition>(conditionId, null, nameof(GetConditionAsync), conditionId, cancellationToken);
        }

        /// <summary>
        /// Gets the condition with the specified <paramref name="conditionId"/> for the loan as raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> GetConditionRawAsync(string conditionId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));

            return GetRawAsync(conditionId, queryString, nameof(GetConditionRawAsync), conditionId, cancellationToken);
        }

        /// <summary>
        /// Creates a condition for the loan and returns the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateConditionAsync(TCondition condition, CancellationToken cancellationToken = default) => CreateConditionAsync(condition, false, cancellationToken);

        /// <summary>
        /// Creates a condion for the loan and returns the id of the condition created and optionally populates the condition object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="condition">The condition to create.</param>
        /// <param name="populate">Indicates if the condition object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateConditionAsync(TCondition condition, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(condition, nameof(condition));
            Preconditions.NullOrEmpty(condition.Id, $"{nameof(condition)}.{nameof(condition.Id)}");

            return PostPopulateDirtyAsync(null, nameof(CreateConditionAsync), condition, populate, cancellationToken);
        }

        /// <summary>
        /// Creates a condition for the loan from raw json and returns the response's body if not empty else the id of the condition created.
        /// </summary>
        /// <param name="condition">The condition to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> CreateConditionRawAsync(string condition, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(condition, nameof(condition));

            return PostAsync(null, queryString, new JsonStringContent(condition), nameof(CreateConditionRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <summary>
        /// Creates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task CreateConditionsAsync(IEnumerable<TCondition> conditions, CancellationToken cancellationToken = default) => CreateConditionsAsync(conditions, false, cancellationToken);

        /// <summary>
        /// Creates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to create.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task CreateConditionsAsync(IEnumerable<TCondition> conditions, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(conditions, nameof(conditions));

            var dirtyList = new DirtyList<TCondition>(conditions);

            Preconditions.NotNullOrEmpty(dirtyList, nameof(conditions));

            var i = 0;
            foreach (var condition in dirtyList)
            {
                Preconditions.NullOrEmpty(condition.Id, $"{nameof(conditions)}[{i++}].Id");
            }

            var queryParameters = new QueryParameters();
            queryParameters.Add("action", "add");
            queryParameters.Add("view", populate ? "entity" : "id");

            return PatchPopulateDirtyAsync(null, queryParameters.ToString(), JsonStreamContent.Create(conditions), nameof(CreateConditionsAsync), null, dirtyList, true, cancellationToken);
        }

        /// <summary>
        /// Updates multiple conditions for the loan.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateConditionsAsync(IEnumerable<TCondition> conditions, CancellationToken cancellationToken = default) => UpdateConditionsAsync(conditions, false, cancellationToken);

        /// <summary>
        /// Updates multiple conditions for the loan and optionally populates the condition objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditions">The conditions to update.</param>
        /// <param name="populate">Indicates if the condition objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task UpdateConditionsAsync(IEnumerable<TCondition> conditions, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(conditions, nameof(conditions));

            var dirtyList = new DirtyList<TCondition>(conditions);

            Preconditions.NotNullOrEmpty(dirtyList, nameof(conditions));

            var i = 0;
            foreach (var condition in dirtyList)
            {
                Preconditions.NotNullOrEmpty(condition.Id, $"{nameof(conditions)}[{i++}].Id");
            }

            var queryParameters = new QueryParameters();
            queryParameters.Add("action", "update");
            if (populate)
            {
                queryParameters.Add("view", "entity");
            }

            return PatchPopulateDirtyAsync(null, queryParameters.ToString(), JsonStreamContent.Create(conditions), nameof(UpdateConditionsAsync), null, dirtyList, populate, cancellationToken);
        }

        /// <summary>
        /// Deletes multiple conditions from the loan.
        /// </summary>
        /// <param name="conditionIds">The ids of the conditions to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteConditionsAsync(IEnumerable<string> conditionIds, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(conditionIds, nameof(conditionIds));

            var list = conditionIds.Select(id => new { Id = id }).ToList();

            Preconditions.NotNullOrEmpty(list, nameof(conditionIds));

            var i = 0;
            foreach (var condition in list)
            {
                Preconditions.NotNullOrEmpty(condition.Id, $"{nameof(conditionIds)}[{i++}]");
            }

            return SendAsync(PatchMethod, null, "action=remove", JsonStreamContent.Create(list), nameof(DeleteConditionsAsync), null, cancellationToken, r => Task.FromResult(r.IsSuccessStatusCode), false);
        }

        /// <summary>
        /// Manages multiple conditions from raw json.
        /// </summary>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> ManageConditionsRawAsync(string content, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(content, nameof(content));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchRawAsync(null, queryString, new JsonStringContent(content), nameof(ManageConditionsRawAsync), null, cancellationToken);
        }

        /// <summary>
        /// Creates multiple comments for the loan condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task CreateConditionCommentsAsync(string conditionId, IEnumerable<Comment> comments, CancellationToken cancellationToken = default) => CreateConditionCommentsAsync(conditionId, comments, false, cancellationToken);

        /// <summary>
        /// Creates multiple comments for the loan condition and optionally populates the comment objects with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add comments.</param>
        /// <param name="comments">The condition comments to create.</param>
        /// <param name="populate">Indicates if the comment objects should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task CreateConditionCommentsAsync(string conditionId, IEnumerable<Comment> comments, bool populate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));
            Preconditions.NotNull(comments, nameof(comments));

            var dirtyList = new DirtyList<Comment>(comments);

            var i = 0;
            foreach (var comment in dirtyList)
            {
                Preconditions.NullOrEmpty(comment.CommentId, $"{nameof(comments)}[{i++}].CommentId");
            }

            var queryParameters = new QueryParameters();
            queryParameters.Add("action", "add");
            queryParameters.Add("view", populate ? "entity" : "id");

            return PatchPopulateDirtyAsync($"{conditionId}/comments", JsonStreamContent.Create(dirtyList), nameof(CreateConditionCommentsAsync), conditionId, dirtyList, true, cancellationToken);
        }

        /// <summary>
        /// Deletes multiple condition comments from the loan.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to remove comments.</param>
        /// <param name="commentIds">The ids of the condition comments to delete.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<bool> DeleteConditionCommentsAsync(string conditionId, IEnumerable<string> commentIds, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(commentIds, nameof(commentIds));

            var list = commentIds.Select(id => new { CommentId = id }).ToList();

            Preconditions.NotNullOrEmpty(list, nameof(commentIds));

            var i = 0;
            foreach (var comment in list)
            {
                Preconditions.NotNullOrEmpty(comment.CommentId, $"{nameof(commentIds)}[{i++}]");
            }

            return SendAsync(PatchMethod, $"{conditionId}/comments", "action=remove", JsonStreamContent.Create(list), nameof(DeleteConditionCommentsAsync), conditionId, cancellationToken, r => Task.FromResult(r.IsSuccessStatusCode), false);
        }

        /// <summary>
        /// Manages multiple condition comments from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to add or remove comments.</param>
        /// <param name="content">The content as raw json to send.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> ManageConditionCommentsRawAsync(string conditionId, string content, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));
            Preconditions.NotNullOrEmpty(content, nameof(content));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchRawAsync($"{conditionId}/comments", queryString, new JsonStringContent(content), nameof(ManageConditionCommentsRawAsync), conditionId, cancellationToken);
        }

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AssignConditionDocumentsAsync(string conditionId, AssignmentAction action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default) => AssignConditionDocumentsAsync(conditionId, action.Validate(nameof(action)).GetValue(), documents, cancellationToken);

        /// <summary>
        /// Assigns or unassigns documents from the specified condition.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="action">Action to perform.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task AssignConditionDocumentsAsync(string conditionId, string action, IEnumerable<EntityReference> documents, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));
            Preconditions.NotNullOrEmpty(action, nameof(action));
            Preconditions.NotNullOrEmpty(documents, nameof(documents));

            var queryParameters = new QueryParameters();
            queryParameters.Add("action", action);
            return PatchAsync($"{conditionId}/documents", queryParameters.ToString(), JsonStreamContent.Create(documents), nameof(AssignConditionDocumentsAsync), conditionId, cancellationToken);
        }

        /// <summary>
        /// Manages multiple condition documents from raw json.
        /// </summary>
        /// <param name="conditionId">The unique identifier assigned to the condition for which to assign or unassign documents.</param>
        /// <param name="documents">The documents to assign or unassign.</param>
        /// <param name="queryString">The query string to include in the request. Must include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public Task<string> ManageConditionDocumentsRawAsync(string conditionId, string documents, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(conditionId, nameof(conditionId));
            Preconditions.NotNullOrEmpty(documents, nameof(documents));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchRawAsync($"{conditionId}/documents", queryString, new JsonStringContent(documents), nameof(ManageConditionDocumentsRawAsync), conditionId, cancellationToken);
        }
    }
}