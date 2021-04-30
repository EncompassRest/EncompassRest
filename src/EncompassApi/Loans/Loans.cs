using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using EncompassApi.Extensions;
using EncompassApi.Utilities;
using EnumsNET;

namespace EncompassApi.Loans
{
    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public interface ILoans : IApiObject
    {
        /// <summary>
        /// The loan field descriptors.
        /// </summary>
        ILoanFieldDescriptors FieldDescriptors { get; }

        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass and returns the loan id of the loan created and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loan">The loan to create.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default);
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="loan">Returns a loan object if <paramref name="createLoanOptions"/>.Populate is <c>true</c>.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new loan in Encompass using loan data imported from a Fannie Mae 3.x loan file and returns the loan id of the loan created.
        /// </summary>
        /// <param name="importFileType">The format of the file being sent in the request body.</param>
        /// <param name="importFile">The Fannie Mae loan file to import.</param>
        /// <param name="createLoanOptions">The loan creation options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default);
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
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> CreateLoanFromImportFileAsync(string importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default);
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
        /// Gets the Loan Apis for the loan with the specified <paramref name="loanId"/>.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <returns></returns>
        ILoanApis GetLoanApis(string loanId);
        /// <summary>
        /// Gets the Loan Apis for the loan.
        /// </summary>
        /// <param name="loan">The loan.</param>
        /// <returns></returns>
        ILoanObjectBoundApis GetLoanApis(Loan loan);
        /// <summary>
        /// Returns the entire loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns the specific entities of a loan.
        /// </summary>
        /// <param name="loanId">The unique identifier assigned to the loan.</param>
        /// <param name="entities">The list of loan entities to retrieve from the loan.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default);
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
        /// Updates an existing loan by modifying the values of the loan data elements passed.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an existing loan by modifying the values of the loan data elements passed and optionally populates the loan object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loan">The loan to update.</param>
        /// <param name="populate">Indicates if the loan object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default);
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

    /// <summary>
    /// The Loans Apis.
    /// </summary>
    public sealed class Loans : ApiObject, ILoans
    {
        private LoanFieldDescriptors? _fieldDescriptors;
        public event EventHandler<ApiResponseEventArgs> ApiResponseEventHandler;
        internal override void ApiResponse(HttpResponseMessage response)
        {
            if (ApiResponseEventHandler != null)
            {
                ApiResponseEventHandler(null, new ApiResponseEventArgs(response));
            }
        }
        /// <summary>
        /// The loan field descriptors.
        /// </summary>
        public LoanFieldDescriptors FieldDescriptors
        {
            get
            {
                var fieldDescriptors = _fieldDescriptors;
                return fieldDescriptors ?? Interlocked.CompareExchange(ref _fieldDescriptors, (fieldDescriptors = new LoanFieldDescriptors(Client)), null) ?? fieldDescriptors;
            }
        }

        ILoanFieldDescriptors ILoans.FieldDescriptors => FieldDescriptors;

        internal Loans(IEncompassApiClient client)
            : base(client, "encompass/v1")
        {
        }

        /// <summary>
        /// Gets the Loan Apis for the loan with the specified <paramref name="loanId"/>.
        /// </summary>
        /// <param name="loanId">The loan id.</param>
        /// <returns></returns>
        public LoanApis GetLoanApis(string loanId)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return new LoanApis(Client, loanId);
        }

        ILoanApis ILoans.GetLoanApis(string loanId) => GetLoanApis(loanId);

        ILoanObjectBoundApis ILoans.GetLoanApis(Loan loan)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            return new LoanObjectBoundApis(Client, loan);
        }

        /// <inheritdoc/>
        public Task<Loan> GetLoanAsync(string loanId, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, (IEnumerable<string>?)null, cancellationToken);

        /// <inheritdoc/>
        public Task<Loan> GetLoanAsync(string loanId, IEnumerable<LoanEntity>? entities, CancellationToken cancellationToken = default) => GetLoanAsync(loanId, entities?.Select(e => e.Validate(nameof(entities)).GetValue()!), cancellationToken);

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public Task<string> GetLoanRawAsync(string loanId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return GetRawAsync($"loans/{loanId}", queryString, nameof(GetLoanRawAsync), loanId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<List<StringEnumValue<LoanEntity>>> GetSupportedEntitiesAsync(CancellationToken cancellationToken = default) => GetAsync<List<StringEnumValue<LoanEntity>>>("loans/supportedEntities", null, nameof(GetSupportedEntitiesAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> GetSupportedEntitiesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync("loans/supportedEntities", queryString, nameof(GetSupportedEntitiesRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> CreateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, null, cancellationToken);

        /// <inheritdoc/>
        public Task<string> CreateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => CreateLoanAsync(loan, new CreateLoanOptions { Populate = populate }, cancellationToken);

        /// <inheritdoc/>
        public async Task<string> CreateLoanAsync(Loan loan, CreateLoanOptions? createLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            var loanId = await PostPopulateDirtyAsync("loans", createLoanOptions?.ToQueryParameters().ToString(), nameof(CreateLoanAsync), loan, createLoanOptions?.Populate == true, cancellationToken).ConfigureAwait(false);
            loan.Initialize(Client, loanId);
            return loanId;
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanRawAsync(string loan, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PostAsync("loans", queryString, new JsonStringContent(loan), nameof(CreateLoanRawAsync), null, cancellationToken, ReadAsStringElseLocationFunc);
        }

        /// <inheritdoc/>
        public Task UpdateLoanAsync(Loan loan, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, null, cancellationToken);

        /// <inheritdoc/>
        public Task UpdateLoanAsync(Loan loan, bool populate, CancellationToken cancellationToken = default) => UpdateLoanAsync(loan, new UpdateLoanOptions { Populate = populate }, cancellationToken);

        /// <inheritdoc/>
        public Task UpdateLoanAsync(Loan loan, UpdateLoanOptions? updateLoanOptions, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(loan, nameof(loan));
            Preconditions.NotNullOrEmpty(loan.EncompassId, $"{nameof(loan)}.{nameof(loan.EncompassId)}");

            loan.Initialize(Client, loan.EncompassId);
            return PatchPopulateDirtyAsync($"loans/{loan.EncompassId}", updateLoanOptions?.ToQueryParameters().ToString(), JsonStreamContent.Create(loan), nameof(UpdateLoanAsync), loan.EncompassId, loan, updateLoanOptions?.Populate == true, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> UpdateLoanRawAsync(string loanId, string loan, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));
            Preconditions.NotNullOrEmpty(loan, nameof(loan));

            return PatchRawAsync($"loans/{loanId}", queryString, new JsonStringContent(loan), nameof(UpdateLoanRawAsync), loanId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return DeleteAsync($"loans/{loanId}", null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<bool> TryDeleteLoanAsync(string loanId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(loanId, nameof(loanId));

            return TryDeleteAsync($"loans/{loanId}", null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, string importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default)
        {
            importFileType.Validate(nameof(importFileType));
            Preconditions.NotNullOrEmpty(importFile, nameof(importFile));

            var populate = createLoanOptions?.Populate == true;
            loan = populate ? new Loan(Client) : null;
            var content = new StringContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType.GetValue());
            return CreateLoanFromImportFileInternalAsync(content, loan, populate, createLoanOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(ImportFileType importFileType, Stream importFile, CreateLoanOptions? createLoanOptions, out Loan? loan, CancellationToken cancellationToken = default)
        {
            importFileType.Validate(nameof(importFileType));
            Preconditions.NotNull(importFile, nameof(importFile));

            var populate = createLoanOptions?.Populate == true;
            loan = populate ? new Loan(Client) : null;
            var content = new StreamContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType.GetValue());
            return CreateLoanFromImportFileInternalAsync(content, loan, populate, createLoanOptions, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(string importFileType, string importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
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

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileAsync(string importFileType, Stream importFile, CreateLoanOptions? createLoanOptions = null, CancellationToken cancellationToken = default)
        {
            if (createLoanOptions?.Populate == true)
            {
                throw new InvalidOperationException("Use other CreateLoanFromImportFileAsync overload to populate a loan object.");
            }

            return CreateLoanFromImportFileAsync(importFileType, importFile, createLoanOptions, out _, cancellationToken);
        }

        /// <inheritdoc/>
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
            var loanId = await PostPopulateDirtyAsync("importers/loan", createLoanOptions?.ToQueryParameters().ToString(), content, nameof(CreateLoanFromImportFileAsync), loan, populate, cancellationToken).ConfigureAwait(false);
            loan?.Initialize(Client, loanId);
            return loanId;
        }

        /// <inheritdoc/>
        public Task<string> CreateLoanFromImportFileRawAsync(string importFileType, string importFile, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(importFileType, nameof(importFileType));
            Preconditions.NotNullOrEmpty(importFile, nameof(importFile));

            var content = new StringContent(importFile);
            content.Headers.ContentType = new MediaTypeHeaderValue(importFileType);
            return CreateLoanFromImportFileRawInternalAsync(queryString, content, cancellationToken);
        }

        /// <inheritdoc/>
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