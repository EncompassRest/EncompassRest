namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CollateralTrackingRights
    /// </summary>
    public sealed class CollateralTrackingRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _importShippingDetails;

        /// <summary>
        /// CollateralTrackingRights ImportShippingDetails
        /// </summary>
        public bool? ImportShippingDetails { get => _importShippingDetails; set => SetField(ref _importShippingDetails, value); }
    }
}