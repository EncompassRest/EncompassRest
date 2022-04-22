namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AUSTrackingRights
    /// </summary>
    public sealed class AUSTrackingRights : ParentAccessRights
    {
        /// <summary>
        /// AUSTrackingRights CreateManualEntry
        /// </summary>
        public bool? CreateManualEntry { get => GetValue<bool?>(); set => SetValue(value); }
    }
}