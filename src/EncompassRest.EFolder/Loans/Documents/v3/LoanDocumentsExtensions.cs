using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Loans.v3;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents.v3
{
    /// <summary>
    /// The Loan Documents Api extension methods.
    /// </summary>
    public static class LoanDocumentsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanDocumentsV3? V3 { get; set; }

        private static ILoanDocumentsV3 GetV3(ILoanDocuments loanDocuments)
        {
            var v3 = V3;
            if (loanDocuments is LoanDocuments d)
            {
                v3 = d.ExtensionData.GetOrAdd(() => new LoanDocumentsV3(d.Client, d.LoanApis, d.LoanId));
            }
            else if (v3 == null)
            {
                Preconditions.NotNull(loanDocuments, nameof(loanDocuments));
                throw new InvalidOperationException("Must set V3 property when not using the default implementation");
            }
            return v3;
        }

        /// <summary>
        /// Assigns or unassigns attachments.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="action">The action to perform, assign or unassign.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignDocumentAttachmentsAsync(this ILoanDocuments loanDocuments, string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default) => AssignDocumentAttachmentsAsync(loanDocuments, documentId, action.Validate(nameof(action)).GetValue(), attachmentEntities, cancellationToken);

        /// <summary>
        /// Assigns or unassigns attachments.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="action">The action to perform, assign or unassign.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignDocumentAttachmentsAsync(this ILoanDocuments loanDocuments, string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default) => GetV3(loanDocuments).AssignDocumentAttachmentsAsync(documentId, action, attachmentEntities, cancellationToken);

        /// <summary>
        /// Assigns or unassigns attachments from raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignDocumentAttachmentsRawAsync(this ILoanDocuments loanDocuments, string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default) => GetV3(loanDocuments).AssignDocumentAttachmentsRawAsync(documentId, attachmentEntities, queryString, cancellationToken);

        /// <summary>
        /// Retrieves properties for the specified eFolder document. The response includes roles that have access to the document, any comments applied to the document, and file attachment information.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<Document> GetDocumentAsync(this ILoanDocuments loanDocuments, string documentId, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentAsync(documentId, cancellationToken);

        /// <summary>
        /// Retrieves properties for the specified eFolder document as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentRawAsync(this ILoanDocuments loanDocuments, string documentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentRawAsync(documentId, queryString, cancellationToken);

        /// <summary>
        /// Returns all eFolder documents for the loan. The response includes a list of eFolder documents for the loan, roles that have access to the documents, and any comments applied to the documents.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="options">The document retrieval options.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<Document>> GetDocumentsAsync(this ILoanDocuments loanDocuments, DocumentRetrievalOptions? options, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentsAsync(options, cancellationToken);

        /// <summary>
        /// Returns all eFolder documents for the loan as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentsRawAsync(this ILoanDocuments loanDocuments, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Use this API to add a document, update an existing document, or remove a document from a loan file.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="options">The eFolder management options.</param>
        /// <param name="documents">The documents to add, update, or remove.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task ManageDocumentsAsync(this ILoanDocuments loanDocuments, EFolderManagementOptions options, IEnumerable<Document> documents, CancellationToken cancellationToken = default) => GetV3(loanDocuments).ManageDocumentsAsync(options, documents, cancellationToken);

        /// <summary>
        /// Use this API to add a document, update an existing document, or remove a document from a loan file as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documents">The documents to add, update, or remove.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> ManageDocumentsRawAsync(this ILoanDocuments loanDocuments, string documents, string queryString, CancellationToken cancellationToken = default) => GetV3(loanDocuments).ManageDocumentsRawAsync(documents, queryString, cancellationToken);

        /// <summary>
        /// Use this API to add a comment to a document. Note that once a comment is added, it cannot be updated or deleted.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="options">The eFolder management options.</param>
        /// <param name="comments">The comments to add.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task ManageDocumentCommentsAsync(this ILoanDocuments loanDocuments, string documentId, EFolderManagementOptions options, IEnumerable<LogComment> comments, CancellationToken cancellationToken = default) => GetV3(loanDocuments).ManageDocumentCommentsAsync(documentId, options, comments, cancellationToken);

        /// <summary>
        /// Use this API to add a comment to a document as raw json. Note that once a comment is added, it cannot be updated or deleted.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="comments">The comments as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task ManageDocumentCommentsRawAsync(this ILoanDocuments loanDocuments, string documentId, string comments, string queryString, CancellationToken cancellationToken = default) => GetV3(loanDocuments).ManageDocumentCommentsRawAsync(documentId, comments, queryString, cancellationToken);

        /// <summary>
        /// Gets the comments for a document.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LogComment>> GetDocumentCommentsAsync(this ILoanDocuments loanDocuments, string documentId, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentCommentsAsync(documentId, cancellationToken);

        /// <summary>
        /// Gets the comments for a document as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentCommentsRawAsync(this ILoanDocuments loanDocuments, string documentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV3(loanDocuments).GetDocumentCommentsRawAsync(documentId, queryString, cancellationToken);
    }
}