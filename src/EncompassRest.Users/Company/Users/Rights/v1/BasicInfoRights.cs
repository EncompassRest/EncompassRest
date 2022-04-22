namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// BasicInfoRights
    /// </summary>
    public sealed class BasicInfoRights : ParentAccessRights
    {
        /// <summary>
        /// BasicInfoRights EditBasicInformation
        /// </summary>
        public bool? EditBasicInformation { get => GetValue<bool?>(); set => SetValue(value); }
    }
}