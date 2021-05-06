namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessWholesaleRights
    /// </summary>
    public sealed class AccessWholesaleRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _registerWholesaleLoan;

        /// <summary>
        /// AccessWholesaleRights RegisterWholesaleLoan
        /// </summary>
        public bool? RegisterWholesaleLoan { get => _registerWholesaleLoan; set => SetField(ref _registerWholesaleLoan, value); }
    }
}