namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// AccessCorrespondentRights
    /// </summary>
    public sealed class AccessCorrespondentRights : ParentAccessRights
    {
        /// <summary>
        /// AccessCorrespondentRights RegisterCorrespondentLoan
        /// </summary>
        public bool? RegisterCorrespondentLoan { get => GetValue<bool?>(); set => SetValue(value); }
    }
}