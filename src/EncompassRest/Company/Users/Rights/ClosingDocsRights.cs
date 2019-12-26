using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// ClosingDocsRights
    /// </summary>
    public sealed class ClosingDocsRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _manageAltLenders;
        private OrderClosingDocsRights? _orderClosingDocs;
        private ViewClosingDocumentDataRights? _viewClosingDocumentData;

        /// <summary>
        /// ClosingDocsRights ManageAltLenders
        /// </summary>
        public bool? ManageAltLenders { get => _manageAltLenders; set => SetField(ref _manageAltLenders, value); }

        /// <summary>
        /// ClosingDocsRights OrderClosingDocs
        /// </summary>
        [AllowNull]
        public OrderClosingDocsRights OrderClosingDocs { get => GetField(ref _orderClosingDocs); set => SetField(ref _orderClosingDocs, value); }

        /// <summary>
        /// ClosingDocsRights ViewClosingDocumentData
        /// </summary>
        [AllowNull]
        public ViewClosingDocumentDataRights ViewClosingDocumentData { get => GetField(ref _viewClosingDocumentData); set => SetField(ref _viewClosingDocumentData, value); }
    }
}