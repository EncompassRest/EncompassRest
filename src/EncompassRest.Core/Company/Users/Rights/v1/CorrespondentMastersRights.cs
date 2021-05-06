namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CorrespondentMastersRights
    /// </summary>
    public sealed class CorrespondentMastersRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editCorrespondentMasters;

        /// <summary>
        /// CorrespondentMastersRights EditCorrespondentMasters
        /// </summary>
        public bool? EditCorrespondentMasters { get => _editCorrespondentMasters; set => SetField(ref _editCorrespondentMasters, value); }
    }
}