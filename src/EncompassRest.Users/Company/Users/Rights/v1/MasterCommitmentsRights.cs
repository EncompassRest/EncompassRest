namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// MasterCommitmentsRights
    /// </summary>
    public sealed class MasterCommitmentsRights : ParentAccessRights
    {
        /// <summary>
        /// MasterCommitmentsRights EditMasterContracts
        /// </summary>
        public bool? EditMasterContracts { get => GetValue<bool?>(); set => SetValue(value); }
    }
}