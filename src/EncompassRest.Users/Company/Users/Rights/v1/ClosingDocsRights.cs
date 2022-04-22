using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ClosingDocsRights
    /// </summary>
    public sealed class ClosingDocsRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ClosingDocsRights DigitalClosing
        /// </summary>
        [AllowNull]
        public DigitalClosingRights DigitalClosing { get => GetEntity<DigitalClosingRights>(); set => SetEntity(value); }

        /// <summary>
        /// ClosingDocsRights ENoteTab
        /// </summary>
        [AllowNull]
        public ENoteTabRights ENoteTab { get => GetEntity<ENoteTabRights>(); set => SetEntity(value); }

        /// <summary>
        /// ClosingDocsRights ManageAltLenders
        /// </summary>
        public bool? ManageAltLenders { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ClosingDocsRights OrderClosingDocs
        /// </summary>
        [AllowNull]
        public OrderClosingDocsRights OrderClosingDocs { get => GetEntity<OrderClosingDocsRights>(); set => SetEntity(value); }

        /// <summary>
        /// ClosingDocsRights ViewClosingDocumentData
        /// </summary>
        [AllowNull]
        public ViewClosingDocumentDataRights ViewClosingDocumentData { get => GetEntity<ViewClosingDocumentDataRights>(); set => SetEntity(value); }
    }
}