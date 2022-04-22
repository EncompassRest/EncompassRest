namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ONRPRights
    /// </summary>
    public sealed class ONRPRights : ParentAccessRights
    {
        /// <summary>
        /// ONRPRights EditONRP
        /// </summary>
        public bool? EditONRP { get => GetValue<bool?>(); set => SetValue(value); }
    }
}