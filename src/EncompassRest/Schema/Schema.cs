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

        public Task<LoanSchema> GetLoanSchemaAsync(CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, (IEnumerable<string>)null, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(includeFieldExtensions, (IEnumerable<string>)null, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, entities, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(IEnumerable<string> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(false, entities, cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<LoanEntity> entities, CancellationToken cancellationToken = default) => GetLoanSchemaAsync(includeFieldExtensions, entities?.Select(e => e.AsString()), cancellationToken);

        public Task<LoanSchema> GetLoanSchemaAsync(bool includeFieldExtensions, IEnumerable<string> entities, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }
            queryParameters.Add("includeFieldExtensions", includeFieldExtensions.ToString().ToLower());

            return GetAsync<LoanSchema>(null, queryParameters.ToString(), nameof(GetLoanSchemaAsync), null, cancellationToken);
        }

        public Task<string> GetLoanSchemaRawAsync(string queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetLoanSchemaRawAsync), null, cancellationToken);

        public Task<LoanSchema> GetFieldSchemaAsync(string fieldId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetAsync<LoanSchema>(fieldId, null, nameof(GetFieldSchemaAsync), fieldId, cancellationToken);
        }

        public Task<string> GetFieldSchemaRawAsync(string fieldId, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldId, nameof(fieldId));

            return GetRawAsync(fieldId, queryString, nameof(GetFieldSchemaRawAsync), fieldId, cancellationToken);
        }

        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, null, null, cancellationToken);

        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, bool? ignoreInvalidFields, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, ignoreInvalidFields, null, cancellationToken);

        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, string fieldNamePattern, CancellationToken cancellationToken = default) => GeneratePathsAsync(fieldIds, null, fieldNamePattern, cancellationToken);

        public Task<Dictionary<string, string>> GeneratePathsAsync(IEnumerable<string> fieldIds, bool? ignoreInvalidFields, string fieldNamePattern, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(fieldIds, nameof(fieldIds));

            var queryParameters = new QueryParameters();
            if (ignoreInvalidFields.HasValue)
            {
                queryParameters.Add("ignoreInvalidFields", ignoreInvalidFields.ToString().ToLower());
            }
            if (!string.IsNullOrEmpty(fieldNamePattern))
            {
                queryParameters.Add("fieldNamePattern", fieldNamePattern);
            }

            return PostAsync<Dictionary<string, string>>("pathGenerator", queryParameters.ToString(), JsonStreamContent.Create(fieldIds), nameof(GeneratePathsAsync), null, cancellationToken);
        }

        public Task<string> GeneratePathsRawAsync(string fieldIds, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldIds, nameof(fieldIds));

            return PostRawAsync("pathGenerator", queryString, new JsonStringContent(fieldIds), nameof(GeneratePathsRawAsync), null, cancellationToken);
        }
    }
}