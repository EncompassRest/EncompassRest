namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CorrespondentMastersRights
    /// </summary>
    public sealed class CorrespondentMastersRights : ParentAccessRights
    {
        /// <summary>
        /// CorrespondentMastersRights EditCorrespondentMasters
        /// </summary>
        public bool? EditCorrespondentMasters { get => GetValue<bool?>(); set => SetValue(value); }
    }
}