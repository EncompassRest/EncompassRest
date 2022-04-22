namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MBSPoolsRights
    /// </summary>
    public sealed class MBSPoolsRights : ParentAccessRights
    {
        /// <summary>
        /// MBSPoolsRights EditMBSPools
        /// </summary>
        public bool? EditMBSPools { get => GetValue<bool?>(); set => SetValue(value); }
    }
}