using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v1;
using EncompassRest.Utilities;

namespace EncompassRest.Schema.v1
{
    /// <summary>
    /// The Schema Apis.
    /// </summary>
    public interface ISchemaLoansV1 : IApiObject
    {
        /// <summary>
        /// Generates the loan contract from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract.</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid loan fields if specified in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default);
        /// <summary>
        /// Generates the loan contract as raw json from the specified <paramref name="fieldValues"/>.
        /// </summary>
        /// <param name="fieldValues">The field values to generate the loan contract as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GenerateContractRawAsync(string fieldValues, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class SchemaLoansV1 : ApiObject, ISchemaLoansV1
    {
        internal SchemaLoansV1(EncompassRestClient client)
            : base(client, "encompass/v1/schema/loan")
        {
        }

        public async Task<Loan> GenerateContractAsync(IDictionary<string, object> fieldValues, bool? ignoreInvalidFields, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldValues, nameof(fieldValues));

            var queryParameters = new QueryParameters();
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }

            var loan = await PostAsync<Loan>("contractGenerator", queryParameters.ToString(), JsonStreamContent.Create(fieldValues), nameof(GenerateContractAsync), null, cancellationToken).ConfigureAwait(false);
            loan.Client = Client;
            return loan;
        }

        public Task<string> GenerateContractRawAsync(string fieldValues, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldValues, nameof(fieldValues));

            return PostRawAsync("contractGenerator", queryString, new JsonStringContent(fieldValues), nameof(GenerateContractRawAsync), null, cancellationToken);
        }
    }
}