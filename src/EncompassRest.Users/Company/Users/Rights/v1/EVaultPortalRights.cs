namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EVaultPortalRights
    /// </summary>
    public sealed class EVaultPortalRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deactivateENote;
        private DirtyValue<bool?>? _reverseDeactivateENote;
        private DirtyValue<bool?>? _reverseRegistration;
        private DirtyValue<bool?>? _transferServicing;

        /// <summary>
        /// EVaultPortalRights DeactivateENote
        /// </summary>
        public bool? DeactivateENote { get => _deactivateENote; set => SetField(ref _deactivateENote, value); }

        /// <summary>
        /// EVaultPortalRights ReverseDeactivateENote
        /// </summary>
        public bool? ReverseDeactivateENote { get => _reverseDeactivateENote; set => SetField(ref _reverseDeactivateENote, value); }

        /// <summary>
        /// EVaultPortalRights ReverseRegistration
        /// </summary>
        public bool? ReverseRegistration { get => _reverseRegistration; set => SetField(ref _reverseRegistration, value); }

        /// <summary>
        /// EVaultPortalRights TransferServicing
        /// </summary>
        public bool? TransferServicing { get => _transferServicing; set => SetField(ref _transferServicing, value); }
    }
}