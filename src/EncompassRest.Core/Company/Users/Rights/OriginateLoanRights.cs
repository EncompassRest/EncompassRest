namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// OriginateLoanRights
    /// </summary>
    public sealed class OriginateLoanRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _newBlankLoan;
        private DirtyValue<bool?>? _newFromTemplate;

        /// <summary>
        /// OriginateLoanRights NewBlankLoan
        /// </summary>
        public bool? NewBlankLoan { get => _newBlankLoan; set => SetField(ref _newBlankLoan, value); }

        /// <summary>
        /// OriginateLoanRights NewFromTemplate
        /// </summary>
        public bool? NewFromTemplate { get => _newFromTemplate; set => SetField(ref _newFromTemplate, value); }
    }
}