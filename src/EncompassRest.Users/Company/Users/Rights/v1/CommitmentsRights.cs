namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CommitmentsRights
    /// </summary>
    public sealed class CommitmentsRights : ParentAccessRights
    {
        /// <summary>
        /// CommitmentsRights EditCommitments
        /// </summary>
        public bool? EditCommitments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}