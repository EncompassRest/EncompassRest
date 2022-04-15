using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.v1
{
    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public interface ILoansV1 : IApiObject
    {
        /// <summary>
        /// The loan field descriptors.
        /// </summary>
        ILoanFieldDescriptors FieldDescriptors { get; }

        /// <summary>
        /// Creates a new loan in Encompass with the optionally specified <paramref name="createLoanOptions"/> and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(string importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the response content or else the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileRawAsync(string importFileType, Stream importFile, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the response content or else the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileRawAsync(string importFileType, string importFile, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using raw json and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanRawAsync(string loan, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a specified loan by moving it to the Recycle Bin or Trash folder.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryDeleteLoanAsync(string loanId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the Loan Apis for the loan.
        /// </summary>
        /// <param name="loan">The loan.</param>
        /// <returns></returns>
        ILoanObjectBoundApis GetLoanApis(Loan loan);
        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GetLoanAsync(string loanId, IEnumerable<string>? entities, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the entire loan or specific entities of a loan as raw json.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetLoanRawAsync(string loanId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the list of loan entities that can be retrieved from a loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetSupportedEntitiesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed with the optionally specified <paramref name="updateLoanOptions"/>.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="updateLoanOptions">The loan update options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateLoanAsync(Loan loan, UpdateLoanOptions? updateLoanOptions, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed or by applying a loan template using raw json.
        /// </summary>
        /// <param name="loanId">The loan id of the loan to update.</param>
        /// <param name="loan">The loan to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> UpdateLoanRawAsync(string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class LoansV1 : ApiObject, ILoansV1
    {
        private LoanFieldDescriptors? _fieldDescriptors;

        public ILoanFieldDescriptors FieldDescriptors
        {
            get
            {
                var fieldDescriptors = _fieldDescriptors;
                return fieldDescriptors ?? Interlocked.CompareExchange(ref _fieldDescriptors, (fieldDescriptors = new LoanFieldDescriptors(Client)), null) ?? fieldDescriptors;
            }
        }

        internal LoansV1(EncompassRestClient client)
            : base(client, "encompass/v1")
        {
        }

        public ILoanObjectBoundApis GetLoanApis(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            return new LoanObjectBoundApis(Client, loan);
        }

        public async Task<Loan> GetLoanAsync(string loanId, IEnumerable<string>? entities, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            var queryParameters = new QueryParameters();
            if (entities?.Any() == true)
            {
                queryParameters.Add("entities", string.Join(",", entities));
            }

            var loan = await GetDirtyAsync<Loan>($"loans/{loanId}", queryParameters.ToString(), nameof(GetLoanAsync), loanId, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loan.EncompassId!);
            return loan;
        }

        public Task<string> GetLoanRawAsync(string loanId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync($"loans/{loanId}", queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default) => GetListAsync<StringEnumValue<LoanEntity>>("loans/supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        public Task<string> GetSupportedEntitiesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("loans/supportedEntities", queryString, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        public async Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var loanId = await PostPopulateDirtyAsync("loans", createLoanOptions?.ToString(), nameof(CreateLoanAsync), loan, createLoanOptions?.Populate == true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        public Task<string> CreateLoanRawAsync(string loan, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PostAsync("loans", queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        public Task UpdateLoanAsync(Loan loan, UpdateLoanOptions? updateLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client, loan.EncompassId);
            return PatchPopulateDirtyAsync($"loans/{loan.EncompassId}", updateLoanOptions?.ToString(), JsonStreamContent.Create(loan), nameof(UpdateLoanAsync), loan.EncompassId, loan, updateLoanOptions?.Populate == true, cancellationToken);
        }

        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PatchRawAsync($"loans/{loanId}", queryString, new JsonStringContent(loan), nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        public Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync($"loans/{loanId}", null, cancellationToken);
        }

        public Task<bool> TryDeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return TryDeleteAsync($"loans/{loanId}", null, cancellationToken);
        }

        public Task<string> CreateLoanFromImportFileAsync(string importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(importFileType, nameof(importFileType));
            Preconditions.NotNullOrEmpty(importFile, nameof(importFile));

            var populate = createLoanOptions?.Populate == true;
            loan = populate ? new Loan(Client) : null;
            var content = new StringContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType);
            return CreateLoanFromImportFileInternalAsync(content, loan, populate, createLoanOptions, cancellationToken);
        }

        public Task<string> CreateLoanFromImportFileAsync(string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(importFileType, nameof(importFileType));
            Preconditions.NotNull(importFile, nameof(importFile));

            var populate = createLoanOptions?.Populate == true;
            loan = populate ? new Loan(Client) : null;
            var content = new StreamContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType);
            return CreateLoanFromImportFileInternalAsync(content, loan, populate, createLoanOptions, cancellationToken);
        }

        private async Task<string> CreateLoanFromImportFileInternalAsync(HttpContent content, Loan? loan, bool populate, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken)
        {
            var loanId = await PostPopulateDirtyAsync("importers/loan", createLoanOptions?.ToString(), content, nameof(CreateLoanFromImportFileAsync), loan, populate, cancellationToken).ConfigureAwait(false);
            loan?.Initialize(Client, loanId);
            return loanId;
        }

        public Task<string> CreateLoanFromImportFileRawAsync(string importFileType, string importFile, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(importFileType, nameof(importFileType));
            Preconditions.NotNullOrEmpty(importFile, nameof(importFile));

            var content = new StringContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType);
            return CreateLoanFromImportFileRawInternalAsync(queryString, content, cancellationToken);
        }

        public Task<string> CreateLoanFromImportFileRawAsync(string importFileType, Stream importFile, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(importFileType, nameof(importFileType));
            Preconditions.NotNull(importFile, nameof(importFile));

            var content = new StreamContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType);
            return CreateLoanFromImportFileRawInternalAsync(queryString, content, cancellationToken);
        }

        private Task<string> CreateLoanFromImportFileRawInternalAsync(string? queryString, HttpContent content, CancellationToken cancellationToken) => PostAsync("importers/loan", queryString, content, nameof(CreateLoanFromImportFileRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
    }
}