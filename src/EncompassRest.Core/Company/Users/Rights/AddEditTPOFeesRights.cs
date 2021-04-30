namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// AddEditTPOFeesRights
    /// </summary>
    public sealed class AddEditTPOFeesRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _deleteTPOFees;

        /// <summary>
        /// AddEditTPOFeesRights DeleteTPOFees
        /// </summary>
        public bool? DeleteTPOFees { get => _deleteTPOFees; set => SetField(ref _deleteTPOFees, value); }
    }
}