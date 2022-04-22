namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessToFeesRights
    /// </summary>
    public sealed class AccessToFeesRights : ParentAccessRights
    {
        /// <summary>
        /// AccessToFeesRights AcceptFees
        /// </summary>
        public bool? AcceptFees { get => GetValue<bool?>(); set => SetValue(value); }
    }
}