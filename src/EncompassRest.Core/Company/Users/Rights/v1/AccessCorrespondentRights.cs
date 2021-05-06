namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessCorrespondentRights
    /// </summary>
    public sealed class AccessCorrespondentRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _registerCorrespondentLoan;

        /// <summary>
        /// AccessCorrespondentRights RegisterCorrespondentLoan
        /// </summary>
        public bool? RegisterCorrespondentLoan { get => _registerCorrespondentLoan; set => SetField(ref _registerCorrespondentLoan, value); }
    }
}