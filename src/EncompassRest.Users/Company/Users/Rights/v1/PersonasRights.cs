namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// PersonasRights
    /// </summary>
    public sealed class PersonasRights : ParentAccessRights
    {
        /// <summary>
        /// PersonasRights Edit
        /// </summary>
        public bool? Edit { get => GetValue<bool?>(); set => SetValue(value); }
    }
}