namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CollateralTrackingRights
    /// </summary>
    public sealed class CollateralTrackingRights : ParentAccessRights
    {
        /// <summary>
        /// CollateralTrackingRights ImportShippingDetails
        /// </summary>
        public bool? ImportShippingDetails { get => GetValue<bool?>(); set => SetValue(value); }
    }
}