namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AddEditTPOFeesRights
    /// </summary>
    public sealed class AddEditTPOFeesRights : ParentAccessRights
    {
        /// <summary>
        /// AddEditTPOFeesRights DeleteTPOFees
        /// </summary>
        public bool? DeleteTPOFees { get => GetValue<bool?>(); set => SetValue(value); }
    }
}