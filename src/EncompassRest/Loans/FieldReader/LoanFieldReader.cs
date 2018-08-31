using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.FieldReader
{
    internal sealed class LoanFieldReader : LoanApiObject
    {
        internal LoanFieldReader(EncompassRestClient client, string loanId)
            : base(client, loanId, "fieldReader")
        {
        }

        public Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(params string[] fieldIds) => GetLoanFieldValuesAsync(fieldIds, default);

        public Task<List<LoanFieldValue>> GetLoanFieldValuesAsync(IEnumerable<string> fieldIds, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldIds, nameof(fieldIds));

            return PostAsync<List<LoanFieldValue>>(null, null, JsonStreamContent.Create(fieldIds), nameof(GetLoanFieldValuesAsync), null, cancellationToken);
        }

        public Task<string> GetLoanFieldValuesRawAsync(string fieldIds, string queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(fieldIds, nameof(fieldIds));

            return PostRawAsync(null, queryString, new JsonStringContent(fieldIds), nameof(GetLoanFieldValuesRawAsync), null, cancellationToken);
        }
    }
}