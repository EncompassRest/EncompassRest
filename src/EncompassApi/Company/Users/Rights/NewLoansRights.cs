namespace EncompassApi.Company.Users.Rights
{
    /// <summary>
    /// NewLoansRights
    /// </summary>
    public sealed class NewLoansRights : DirtyExtensibleObject
    {
        private DirtyValue<bool?>? _newBlankLoan;
        private DirtyValue<bool?>? _newFromTemplate;

        /// <summary>
        /// NewLoansRights NewBlankLoan
        /// </summary>
        public bool? NewBlankLoan { get => _newBlankLoan; set => SetField(ref _newBlankLoan, value); }

        /// <summary>
        /// NewLoansRights NewFromTemplate
        /// </summary>
        public bool? NewFromTemplate { get => _newFromTemplate; set => SetField(ref _newFromTemplate, value); }
    }
}