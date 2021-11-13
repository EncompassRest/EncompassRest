namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ENoteTabRights
    /// </summary>
    public sealed class ENoteTabRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _reverseRegistration;
        private DirtyValue<bool?>? _transfer;

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