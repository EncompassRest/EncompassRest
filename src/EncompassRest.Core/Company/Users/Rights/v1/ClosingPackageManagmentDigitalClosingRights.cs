namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ClosingPackageManagmentDigitalClosingRights
    /// </summary>
    public sealed class ClosingPackageManagmentDigitalClosingRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _approveForSigning;

        /// <summary>
        /// ClosingPackageManagmentDigitalClosingRights ApproveForSigning
        /// </summary>
        public bool? ApproveForSigning { get => _approveForSigning; set => SetField(ref _approveForSigning, value); }
    }
}