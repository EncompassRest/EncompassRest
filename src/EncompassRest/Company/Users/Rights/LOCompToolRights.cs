namespace EncompassRest.Company.Users.Rights
{
    /// <summary>
    /// LOCompToolRights
    /// </summary>
    public sealed class LOCompToolRights : ParentAccessRights
    {
        private DirtyValue<bool?> _brokerComp;
        private DirtyValue<bool?> _loanOfficerComp;

        /// <summary>
        /// LOCompToolRights BrokerComp
        /// </summary>
        public bool? BrokerComp { get => _brokerComp; set => SetField(ref _brokerComp, value); }

        /// <summary>
        /// LOCompToolRights LoanOfficerComp
        /// </summary>
        public bool? LoanOfficerComp { get => _loanOfficerComp; set => SetField(ref _loanOfficerComp, value); }
    }
}