using EncompassRest.Utilities;
using EnumsNET;

namespace EncompassRest.Loans.Documents.v3
{
    /// <summary>
    /// The eFolder management options.
    /// </summary>
    public sealed class EFolderManagementOptions
    {
        /// <summary>
        /// The document management action.
        /// </summary>
        public StringEnumValue<ManagementAction> Action { get; }

        /// <summary>
        /// The unique identifier of the loan lock. This can be specified if the user has an existing lock on the loan.
        /// </summary>
        public string? LockId { get; set; }

        /// <summary>
        /// Indicates if the document objects should be populated with the response's body through the use of the entity view query parameter.
        /// </summary>
        public bool Populate { get; set; } = false;

        /// <summary>
        /// The DocumentManagementOptions constructor.
        /// </summary>
        /// <param name="action">The document management action.</param>
        public EFolderManagementOptions(ManagementAction action)
            : this(action.Validate(nameof(action)).GetValue())
        {
        }

        /// <summary>
        /// The DocumentManagementOptions constructor.
        /// </summary>
        /// <param name="action">The document management action.</param>
        public EFolderManagementOptions(string action)
        {
            Preconditions.NotNullOrEmpty(action, nameof(action));
            Action = action;
        }

        internal QueryParameters ToQueryParameters()
        {
            var queryParameters = new QueryParameters();
            queryParameters.Add("action", Action.Value);
            if (!string.IsNullOrEmpty(LockId))
            {
                queryParameters.Add("lockId", LockId);
            }
            queryParameters.Add("view", Populate ? "entity" : "id");
            return queryParameters;
        }
    }
}