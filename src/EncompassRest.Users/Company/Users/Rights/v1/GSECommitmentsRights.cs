namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// GSECommitmentsRights
    /// </summary>
    public sealed class GSECommitmentsRights : ParentAccessRights
    {
        /// <summary>
        /// GSECommitmentsRights EditGSECommitments
        /// </summary>
        public bool? EditGSECommitments { get => GetValue<bool?>(); set => SetValue(value); }
    }
}