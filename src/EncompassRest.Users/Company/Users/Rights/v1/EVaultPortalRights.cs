namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// EVaultPortalRights
    /// </summary>
    public sealed class EVaultPortalRights : ParentAccessRights
    {
        /// <summary>
        /// EVaultPortalRights DeactivateENote
        /// </summary>
        public bool? DeactivateENote { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EVaultPortalRights ReverseDeactivateENote
        /// </summary>
        public bool? ReverseDeactivateENote { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EVaultPortalRights ReverseRegistration
        /// </summary>
        public bool? ReverseRegistration { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// EVaultPortalRights TransferServicing
        /// </summary>
        public bool? TransferServicing { get => GetValue<bool?>(); set => SetValue(value); }
    }
}