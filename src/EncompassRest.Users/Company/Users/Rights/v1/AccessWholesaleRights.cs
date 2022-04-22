namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessWholesaleRights
    /// </summary>
    public sealed class AccessWholesaleRights : ParentAccessRights
    {
        /// <summary>
        /// AccessWholesaleRights RegisterWholesaleLoan
        /// </summary>
        public bool? RegisterWholesaleLoan { get => GetValue<bool?>(); set => SetValue(value); }
    }
}