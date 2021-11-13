using System.Diagnostics.CodeAnalysis;

namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ClosingPackageManagmentDigitalClosingRights
    /// </summary>
    public sealed class ClosingPackageManagmentDigitalClosingRights : DirtyExtensibleObject
    {
        private ApproveForSigningRights? _approveForSigning;

        /// <summary>
        /// ClosingPackageManagmentDigitalClosingRights ApproveForSigning
        /// </summary>
        [AllowNull]
        public ApproveForSigningRights ApproveForSigning { get => GetField(ref _approveForSigning); set => SetField(ref _approveForSigning, value); }
    }
}