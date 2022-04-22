namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// OriginateLoanRights
    /// </summary>
    public sealed class OriginateLoanRights : ParentAccessRights
    {
        /// <summary>
        /// OriginateLoanRights NewBlankLoan
        /// </summary>
        public bool? NewBlankLoan { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// OriginateLoanRights NewFromTemplate
        /// </summary>
        public bool? NewFromTemplate { get => GetValue<bool?>(); set => SetValue(value); }
    }
}