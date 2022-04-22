namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// CorrespondentTradesRights
    /// </summary>
    public sealed class CorrespondentTradesRights : ParentAccessRights
    {
        /// <summary>
        /// CorrespondentTradesRights EditCorrespondentTrades
        /// </summary>
        public bool? EditCorrespondentTrades { get => GetValue<bool?>(); set => SetValue(value); }
    }
}