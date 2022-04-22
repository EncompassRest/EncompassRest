namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// DBARights
    /// </summary>
    public sealed class DBARights : ParentAccessRights
    {
        /// <summary>
        /// DBARights EditDBA
        /// </summary>
        public bool? EditDBA { get => GetValue<bool?>(); set => SetValue(value); }
    }
}