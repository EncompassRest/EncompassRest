using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using EnumsNET;
using Newtonsoft.Json;

namespace EncompassRest.Calculators
{
    /// <summary>
    /// The Calculators Apis.
    /// </summary>
    public interface ICalculators : IApiObject
    {
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, bool? calcAllOnly, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, IEnumerable<LoanEntity>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, IEnumerable<string>? entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="loan">The loan to recalculate.</param>
        /// <param name="entities">The list of loan entities to populate for the loan.</param>
        /// <param name="calcAllOnly">Indicates whether calculations will be executed for all fields. The default is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task CalculateLoanAsync(Loan loan, IEnumerable<string>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview calculations for a loan. This API calculates fields similar to the calculations performed in Update Loan, however, the transient calculations provide a preview and do not save to the loan file.
        /// </summary>
        /// <param name="body">The request body as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns>The loan with calculations performed as raw json.</returns>
        Task<string> CalculateLoanRawAsync(string body, string? queryString = null, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Calculators Apis.
    /// </summary>
    public sealed class Calculators : ApiObject, ICalculators
    {
        internal Calculators(EncompassRestClient client)
            : base(client, "encompass/v1/calculators")
        {
        }

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => CalculateLoanAsync(loan, (IEnumerable<string>?)null, null, cancellationToken);

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, IEnumerable<string>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(loan, entities, null, cancellationToken);

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => CalculateLoanAsync(loan, entities, null, cancellationToken);

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(loan, (IEnumerable<string>?)null, calcAllOnly, cancellationToken);

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, IEnumerable<LoanEntity>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default) => CalculateLoanAsync(loan, entities?.Select(e => e.Validate(nameof(entities)).GetValue()!), calcAllOnly, cancellationToken);

        /// <inheritdoc/>
        public Task CalculateLoanAsync(Loan loan, IEnumerable<string>? entities, bool? calcAllOnly, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var queryParameters = new QueryParameters();
            if (calcAllOnly.HasValue)
            {
                queryParameters.Add(nameof(calcAllOnly), calcAllOnly.ToString().ToLower());
            }
            var body = new CalculateLoanBody(loan) { Entities = entities };
            loan.Initialize(Client, loan.EncompassId);
            return PostAsync("loan", queryParameters.ToString(), JsonStreamContent.Create(body), nameof(CalculateLoanAsync), loan.EncompassId, cancellationToken, async (HttpResponseMessage response) =>
            {
                var loanAsJson = loan.ToString(SerializationOptions.Dirty);
                await response.Content.PopulateAsync(loan).ConfigureAwait(false);
                loan.Dirty = false;
                // Repopulate with original dirty loan to maintain loan dirtiness.
                // This may overwrite calculated values but they shouldn't have been dirty to begin with if they're calculated values.
                JsonHelper.PopulateFromJson(loanAsJson, loan);
                return string.Empty;
            });
        }

        /// <inheritdoc/>
        public Task<string> CalculateLoanRawAsync(string body, string? queryString = null, CancellationToken cancellationToken = default) => PostRawAsync("loan", queryString, new JsonStringContent(body), nameof(CalculateLoanRawAsync), null, cancellationToken);

        private sealed class CalculateLoanBody
        {
            public string LoanId => LoanData.EncompassId!;

            public Loan LoanData { get; }

            [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
            public IEnumerable<string>? Entities { get; set; }

            public CalculateLoanBody(Loan loanData)
            {
                LoanData = loanData;
            }
        }
    }
}