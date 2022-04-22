using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ClosingPackageManagmentDigitalClosingRights
    /// </summary>
    public sealed class ClosingPackageManagmentDigitalClosingRights : DirtyExtensibleObject
    {
        /// <summary>
        /// ClosingPackageManagmentDigitalClosingRights ApproveForSigning
        /// </summary>
        [AllowNull]
        public ApproveForSigningRights ApproveForSigning { get => GetEntity<ApproveForSigningRights>(); set => SetEntity(value); }
    }
}