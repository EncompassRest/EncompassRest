namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToFeesRights
    /// </summary>
    public sealed class AccessToFeesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _acceptFees;

        /// <summary>
        /// AccessToFeesRights AcceptFees
        /// </summary>
        public bool? AcceptFees { get => _acceptFees; set => SetField(ref _acceptFees, value); }
    }
}