namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// NewLoansRights
    /// </summary>
    public sealed class NewLoansRights : DirtyExtensibleObject
    {
        /// <summary>
        /// NewLoansRights NewBlankLoan
        /// </summary>
        public bool? NewBlankLoan { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// NewLoansRights NewFromTemplate
        /// </summary>
        public bool? NewFromTemplate { get => GetValue<bool?>(); set => SetValue(value); }
    }
}