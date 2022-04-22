namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ContactSetupRights
    /// </summary>
    public sealed class ContactSetupRights : ParentAccessRights
    {
        /// <summary>
        /// ContactSetupRights BorrowerContactStatus
        /// </summary>
        public bool? BorrowerContactStatus { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights BorrowerCustomFields
        /// </summary>
        public bool? BorrowerCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights BorrwerContactUpdate
        /// </summary>
        public bool? BorrwerContactUpdate { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights BusinessCategories
        /// </summary>
        public bool? BusinessCategories { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights BusinessCustomFields
        /// </summary>
        public bool? BusinessCustomFields { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights EmailServerSettings
        /// </summary>
        public bool? EmailServerSettings { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// ContactSetupRights PublicBusinessContactGroups
        /// </summary>
        public bool? PublicBusinessContactGroups { get => GetValue<bool?>(); set => SetValue(value); }
    }
}