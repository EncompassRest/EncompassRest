namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ENoteTabRights
    /// </summary>
    public sealed class ENoteTabRights : ParentAccessRights
    {
        /// <summary>
        /// ENoteTabRights DeactivateEnote
        /// </summary>
        public bool? DeactivateEnote { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ENoteTabRights ReverseDeactivateEnote
        /// </summary>
        public bool? ReverseDeactivateEnote { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ENoteTabRights ReverseRegistration
        /// </summary>
        public bool? ReverseRegistration { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ENoteTabRights Transfer
        /// </summary>
        public bool? Transfer { get => GetValue<bool?>(); set => SetValue(value); }
    }
}