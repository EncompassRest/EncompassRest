namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOCompToolRights
    /// </summary>
    public sealed class LOCompToolRights : ParentAccessRights
    {
        /// <summary>
        /// LOCompToolRights BrokerComp
        /// </summary>
        public bool? BrokerComp { get => GetValue<bool?>(); set => SetValue(value); }

        /// <summary>
        /// LOCompToolRights LoanOfficerComp
        /// </summary>
        public bool? LoanOfficerComp { get => GetValue<bool?>(); set => SetValue(value); }
    }
}