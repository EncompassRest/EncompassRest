using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Schema
{
    public sealed class Schema : ApiObject
    {
        internal Schema(EncompassRestClient client)
            : base(client, "encompass/v1/schema/loan")
        {
        }

        public Task<LoanSchema> GetLoanSchemaAsync() => GetLoanSchemaAsync(false, (IEnumerable<string>)null, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(CancellationToken cancellationToken) => GetLoanSchemaAsync(false, (IEnumerable<string>)null, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions) => GetLoanSchemaAsync(includeFieldExtensions, (IEnumerable<string>)null, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, CancellationToken cancellationToken) => GetLoanSchemaAsync(includeFieldExtensions, (IEnumerable<string>)null, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities) => GetLoanSchemaAsync(false, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaAsync(false, entities, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities) => GetLoanSchemaAsync(false, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities, CancellationToken cancellationToken) => GetLoanSchemaAsync(false, entities, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaAsync(includeFieldExtensions, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities) => GetLoanSchemaAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            return GetAsync<LoanSchema>(null, queryParameters.ToString(), nameof(GetLoanSchemaAsync), null, cancellationToken);
        }

        public Task<string> GetLoanSchemaRawAsync() => GetLoanSchemaRawAsync((string)null, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(CancellationToken cancellationToken) => GetLoanSchemaRawAsync((string)null, cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions) => GetLoanSchemaRawAsync(includeFieldExtensions, (IEnumerable<string>)null, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, CancellationToken cancellationToken) => GetLoanSchemaRawAsync(includeFieldExtensions, (IEnumerable<string>)null, cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<LoanEntity> entities) => GetLoanSchemaRawAsync(false, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaRawAsync(false, entities, cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<string> entities) => GetLoanSchemaRawAsync(false, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(IEnumerable<string> entities, CancellationToken cancellationToken) => GetLoanSchemaRawAsync(false, entities, cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken) => GetLoanSchemaRawAsync(includeFieldExtensions, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<string> entities) => GetLoanSchemaRawAsync(includeFieldExtensions, entities, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            return GetLoanSchemaRawAsync(queryParameters.ToString(), cancellationToken);
        }

        public Task<string> GetLoanSchemaRawAsync(string queryString) => GetLoanSchemaRawAsync(queryString, CancellationToken.None);

        public Task<string> GetLoanSchemaRawAsync(string queryString, CancellationToken cancellationToken) => GetRawAsync(null, queryString, nameof(GetLoanSchemaRawAsync), null, cancellationToken);

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId) => GetFieldSchemaAsync(fieldId, CancellationToken.None);

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetAsync<LoanSchema>(fieldId, null, nameof(GetFieldSchemaAsync), fieldId, cancellationToken);
        }

        public Task<string> GetFieldSchemaRawAsync(string fieldId) => GetFieldSchemaRawAsync(fieldId, CancellationToken.None);

        public Task<string> GetFieldSchemaRawAsync(string fieldId, CancellationToken cancellationToken)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, null, nameof(GetFieldSchemaRawAsync), fieldId, cancellationToken);
        }
    }
}