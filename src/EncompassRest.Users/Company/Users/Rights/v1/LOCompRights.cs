namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// LOCompRights
    /// </summary>
    public sealed class LOCompRights : ParentAccessRights
    {
        /// <summary>
        /// LOCompRights EditLOComp
        /// </summary>
        public bool? EditLOComp { get => GetValue<bool?>(); set => SetValue(value); }
    }
}