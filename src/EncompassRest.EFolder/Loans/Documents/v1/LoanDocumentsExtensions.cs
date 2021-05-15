using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents.v1
{
    /// <summary>
    /// The Loan Documents Api extension methods.
    /// </summary>
    public static class LoanDocumentsExtensions
    {
        /// <summary>
        /// The custom v1 Api implementation for unit testing.
        /// </summary>
        public static ILoanDocumentsV1? V1 { get; set; }

        private static ILoanDocumentsV1 GetV1(ILoanDocuments loanDocuments)
        {
            var v1 = V1;
            if (loanDocuments is LoanDocuments d)
            {
                v1 = d.ExtensionData.GetOrAdd(() => new LoanDocumentsV1(d.Client, d.LoanApis, d.LoanId));
            }
            else if (v1 == null)
            {
                Preconditions.NotNull(loanDocuments, nameof(loanDocuments));
                throw new InvalidOperationException("Must set V1 property when not using the default implementation");
            }
            return v1;
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
        public static Task AssignDocumentAttachmentsAsync(this ILoanDocuments loanDocuments, string documentId, AssignmentAction action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default) => AssignDocumentAttachmentsAsync(loanDocuments, documentId, action.Validate(nameof(action)).GetValue()!, attachmentEntities, cancellationToken);

        /// <summary>
        /// Assigns or unassigns attachments.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="action">The action to perform, assign or unassign.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignDocumentAttachmentsAsync(this ILoanDocuments loanDocuments, string documentId, string action, IEnumerable<EntityReference> attachmentEntities, CancellationToken cancellationToken = default) => GetV1(loanDocuments).AssignDocumentAttachmentsAsync(documentId, action, attachmentEntities, cancellationToken);

        /// <summary>
        /// Assigns or unassigns attachments from raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="attachmentEntities">The attachment entity references to assign or unassign as raw json.</param>
        /// <param name="queryString">The query string to include in the request. This should include an action parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task AssignDocumentAttachmentsRawAsync(this ILoanDocuments loanDocuments, string documentId, string attachmentEntities, string queryString, CancellationToken cancellationToken = default) => GetV1(loanDocuments).AssignDocumentAttachmentsRawAsync(documentId, attachmentEntities, queryString, cancellationToken);

        /// <summary>
        /// Creates a new document for the loan and returns the document ID.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="document">The document to create.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateDocumentAsync(this ILoanDocuments loanDocuments, LoanDocument document, CancellationToken cancellationToken = default) => CreateDocumentAsync(loanDocuments, document, populate: false, cancellationToken);

        /// <summary>
        /// Creates a new document for the loan and returns the document ID and optionally populates the document object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="document">The document to create.</param>
        /// <param name="populate">Indicates if the document object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateDocumentAsync(this ILoanDocuments loanDocuments, LoanDocument document, bool populate, CancellationToken cancellationToken = default) => GetV1(loanDocuments).CreateDocumentAsync(document, populate, cancellationToken);

        /// <summary>
        /// Creates a new document for the loan from raw json and returns the response body if not empty else the document ID.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="document">The document to create as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> CreateDocumentRawAsync(this ILoanDocuments loanDocuments, string document, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanDocuments).CreateDocumentRawAsync(document, queryString, cancellationToken);

        /// <summary>
        /// Retrieves properties for the specified eFolder document. The response includes roles that have access to the document, any comments applied to the document, and file attachment information.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<LoanDocument> GetDocumentAsync(this ILoanDocuments loanDocuments, string documentId, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentAsync(documentId, cancellationToken);

        /// <summary>
        /// Retrieves a list of file attachments for the document with the specified <paramref name="documentId"/>.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<EntityReference>> GetDocumentAttachmentsAsync(this ILoanDocuments loanDocuments, string documentId, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentAttachmentsAsync(documentId, cancellationToken);

        /// <summary>
        /// Retrieves a list of file attachments for the document with the specified <paramref name="documentId"/> as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentAttachmentsRawAsync(this ILoanDocuments loanDocuments, string documentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentAttachmentsRawAsync(documentId, queryString, cancellationToken);

        /// <summary>
        /// Retrieves properties for the specified eFolder document as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentRawAsync(this ILoanDocuments loanDocuments, string documentId, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentRawAsync(documentId, queryString, cancellationToken);

        /// <summary>
        /// Returns all eFolder documents for the loan. The response includes a list of eFolder documents for the loan, roles that have access to the documents, and any comments applied to the documents.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<List<LoanDocument>> GetDocumentsAsync(this ILoanDocuments loanDocuments, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentsAsync(cancellationToken);

        /// <summary>
        /// Returns all eFolder documents for the loan as raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> GetDocumentsRawAsync(this ILoanDocuments loanDocuments, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanDocuments).GetDocumentsRawAsync(queryString, cancellationToken);

        /// <summary>
        /// Updates properties of the specified <paramref name="document"/>.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="document">The document to update.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateDocumentAsync(this ILoanDocuments loanDocuments, LoanDocument document, CancellationToken cancellationToken = default) => UpdateDocumentAsync(loanDocuments, document, populate: false, cancellationToken);

        /// <summary>
        /// Updates properties of the specified <paramref name="document"/> and optionally populates the document object with the response's body through the use of the entity view query parameter.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="document">The document to update.</param>
        /// <param name="populate">Indicates if the document object should be populated with the response's body through the use of the entity view query parameter.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task UpdateDocumentAsync(this ILoanDocuments loanDocuments, LoanDocument document, bool populate, CancellationToken cancellationToken = default) => GetV1(loanDocuments).UpdateDocumentAsync(document, populate, cancellationToken);

        /// <summary>
        /// Updates properties of the document with the specified <paramref name="documentId"/> from raw json.
        /// </summary>
        /// <param name="loanDocuments">The Loan Documents Api Object.</param>
        /// <param name="documentId">The unique identifier assigned to the document.</param>
        /// <param name="document">The document to update as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        public static Task<string> UpdateDocumentRawAsync(this ILoanDocuments loanDocuments, string documentId, string document, string? queryString = null, CancellationToken cancellationToken = default) => GetV1(loanDocuments).UpdateDocumentRawAsync(documentId, document, queryString, cancellationToken);
    }
}