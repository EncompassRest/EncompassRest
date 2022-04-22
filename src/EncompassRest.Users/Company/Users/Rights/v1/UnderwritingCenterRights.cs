namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// UnderwritingCenterRights
    /// </summary>
    public sealed class UnderwritingCenterRights : ParentAccessRights
    {
        /// <summary>
        /// UnderwritingCenterRights CreateManualEntry
        /// </summary>
        public bool? CreateManualEntry { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// UnderwritingCenterRights RepWarrantTracker
        /// </summary>
        public bool? RepWarrantTracker { get => GetValue<bool?>(); set => SetValue(value); }
    }
}