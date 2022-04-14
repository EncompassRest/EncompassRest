using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v3;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Documents.v3
{
    /// <summary>
    /// The Loan Documents Apis.
    /// </summary>
    public interface ILoanDocumentsV3 : ILoanApiObject
    {
        /// <inheritdoc cref="LoanDocumentsExtensions.AssignDocumentAttachmentsAsync(ILoanDocuments, string, string, IEnumerable{EntityReference}, CancellationToken)"/>
        Task AssignDocumentAttachmentsAsync(string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.AssignDocumentAttachmentsRawAsync(ILoanDocuments, string, string, string, CancellationToken)"/>
        Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentAsync(ILoanDocuments, string, CancellationToken)"/>
        Task<Document> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentRawAsync(ILoanDocuments, string, string?, CancellationToken)"/>
        Task<string> GetDocumentRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentsAsync(ILoanDocuments, DocumentRetrievalOptions?, CancellationToken)"/>
        Task<List<Document>> GetDocumentsAsync(DocumentRetrievalOptions? options = null, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentsRawAsync(ILoanDocuments, string?, CancellationToken)"/>
        Task<string> GetDocumentsRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.ManageDocumentsAsync(ILoanDocuments, EFolderManagementOptions, IEnumerable{Document}, CancellationToken)"/>
        Task ManageDocumentsAsync(EFolderManagementOptions options, IEnumerable<Document> documents, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.ManageDocumentsRawAsync(ILoanDocuments, string, string, CancellationToken)"/>
        Task<string> ManageDocumentsRawAsync(string documents, string queryString, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.ManageDocumentCommentsAsync(ILoanDocuments, string, EFolderManagementOptions, IEnumerable{LogComment}, CancellationToken)"/>
        Task ManageDocumentCommentsAsync(string documentId, EFolderManagementOptions options, IEnumerable<LogComment> comments, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.ManageDocumentCommentsRawAsync(ILoanDocuments, string, string, string, CancellationToken)"/>
        Task ManageDocumentCommentsRawAsync(string documentId, string comments, string queryString, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentCommentsAsync(ILoanDocuments, string, CancellationToken)"/>
        Task<List<LogComment>> GetDocumentCommentsAsync(string documentId, CancellationToken cancellationToken = default);
        /// <inheritdoc cref="LoanDocumentsExtensions.GetDocumentCommentsRawAsync(ILoanDocuments, string, string?, CancellationToken)"/>
        Task<string> GetDocumentCommentsRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default);
    }

    internal sealed class LoanDocumentsV3 : LoanApiObjectV3, ILoanDocumentsV3
    {
        internal LoanDocumentsV3(EncompassRestClient client, ILoanApis loanApis, string loanId)
            : base(client, loanApis, loanId, "documents")
        {
        }

        public Task<List<Document>> GetDocumentsAsync(DocumentRetrievalOptions? options = null, CancellationToken cancellationToken = default) => GetDirtyListAsync<Document>(null, options?.ToQueryParameters().ToString(), nameof(GetDocumentsAsync), null, cancellationToken);

        public Task<string> GetDocumentsRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetDocumentsRawAsync), null, cancellationToken);

        public Task<Document> GetDocumentAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetDirtyAsync<Document>(documentId, null, nameof(GetDocumentAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync(documentId, queryString, nameof(GetDocumentRawAsync), documentId, cancellationToken);
        }

        public Task ManageDocumentsAsync(EFolderManagementOptions options, IEnumerable<Document> documents, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNull(options, nameof(options));
            Preconditions.NotNull(documents, nameof(documents));

            var dirtyList = new DirtyList<Document>(documents);

            Preconditions.NotNullOrEmpty(dirtyList, nameof(documents));

            var i = 0;
            foreach (var document in dirtyList)
            {
                switch (options.Action.EnumValue)
                {
                    case ManagementAction.Add:
                        Preconditions.NullOrEmpty(document.Id, $"{nameof(documents)}[{i}].Id");
                        break;
                    case ManagementAction.Remove:
                    case ManagementAction.Update:
                        Preconditions.NotNullOrEmpty(document.Id, $"{nameof(documents)}[{i}].Id");
                        break;
                }
                ++i;
            }

            return PatchPopulateDirtyAsync(null, options.ToQueryParameters().ToString(), JsonStreamContent.Create(dirtyList), nameof(ManageDocumentsAsync), null, dirtyList, populate: true, cancellationToken);
        }

        public Task<string> ManageDocumentsRawAsync(string documents, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documents, nameof(documents));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchRawAsync(null, queryString, new JsonStringContent(documents), nameof(ManageDocumentsRawAsync), null, cancellationToken);
        }

        public Task AssignDocumentAttachmentsAsync(string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(action, nameof(action));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));

            var queryParameters = new QueryParameters(new QueryParameter(nameof(action), action));
            return PatchAsync($"{documentId}/attachments", queryParameters.ToString(), JsonStreamContent.Create(attachmentEntities), nameof(AssignDocumentAttachmentsAsync), documentId, cancellationToken);
        }

        public Task AssignDocumentAttachmentsRawAsync(string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(attachmentEntities, nameof(attachmentEntities));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchAsync($"{documentId}/attachments", queryString, new JsonStringContent(attachmentEntities), nameof(AssignDocumentAttachmentsRawAsync), documentId, cancellationToken);
        }

        public Task ManageDocumentCommentsAsync(string documentId, EFolderManagementOptions options, IEnumerable<LogComment> comments, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNull(options, nameof(options));
            Preconditions.NotNull(comments, nameof(comments));

            var dirtyList = new DirtyList<LogComment>(comments);

            Preconditions.NotNullOrEmpty(dirtyList, nameof(comments));

            var i = 0;
            foreach (var comment in dirtyList)
            {
                switch (options.Action.EnumValue)
                {
                    case ManagementAction.Add:
                        Preconditions.NullOrEmpty(comment.Id, $"{nameof(comments)}[{i}].Id");
                        break;
                    case ManagementAction.Remove:
                    case ManagementAction.Update:
                        Preconditions.NotNullOrEmpty(comment.Id, $"{nameof(comments)}[{i}].Id");
                        break;
                }
                ++i;
            }

            return PatchPopulateDirtyAsync($"{documentId}/comments", options.ToQueryParameters().ToString(), JsonStreamContent.Create(dirtyList), nameof(ManageDocumentCommentsAsync), documentId, dirtyList, populate: true, cancellationToken);
        }

        public Task ManageDocumentCommentsRawAsync(string documentId, string comments, string queryString, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));
            Preconditions.NotNullOrEmpty(comments, nameof(comments));
            Preconditions.NotNullOrEmpty(queryString, nameof(queryString));

            return PatchRawAsync($"{documentId}/comments", queryString, new JsonStringContent(comments), nameof(ManageDocumentCommentsRawAsync), documentId, cancellationToken);
        }

        public Task<List<LogComment>> GetDocumentCommentsAsync(string documentId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetListAsync<LogComment>($"{documentId}/comments", null, nameof(GetDocumentCommentsAsync), documentId, cancellationToken);
        }

        public Task<string> GetDocumentCommentsRawAsync(string documentId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(documentId, nameof(documentId));

            return GetRawAsync($"{documentId}/comments", queryString, nameof(GetDocumentCommentsRawAsync), documentId, cancellationToken);
        }
    }
}