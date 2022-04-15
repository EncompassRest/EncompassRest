namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ENoteTabRights
    /// </summary>
    public sealed class ENoteTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deactivateEnote;
        private DirtyValue<bool?>? _reverseDeactivateEnote;
        private DirtyValue<bool?>? _reverseRegistration;
        private DirtyValue<bool?>? _transfer;

        /// <summary>
        /// ENoteTabRights DeactivateEnote
        /// </summary>
        public bool? DeactivateEnote { get => _deactivateEnote; set => SetField(ref _deactivateEnote, value); }

        /// <summary>
        /// ENoteTabRights ReverseDeactivateEnote
        /// </summary>
        public bool? ReverseDeactivateEnote { get => _reverseDeactivateEnote; set => SetField(ref _reverseDeactivateEnote, value); }

        /// <summary>
        /// ENoteTabRights ReverseRegistration
        /// </summary>
        public bool? ReverseRegistration { get => _reverseRegistration; set => SetField(ref _reverseRegistration, value); }

        /// <summary>
        /// ENoteTabRights Transfer
        /// </summary>
        public bool? Transfer { get => _transfer; set => SetField(ref _transfer, value); }
    }
}