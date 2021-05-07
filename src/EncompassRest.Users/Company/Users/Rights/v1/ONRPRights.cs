namespace EncompassRest.Company.Users.Rights.v1
{
    /// <summary>
    /// ONRPRights
    /// </summary>
    public sealed class ONRPRights : ParentAccessRights
    {
        private DirtyValue<bool?>? _editONRP;

        /// <summary>
        /// ONRPRights EditONRP
        /// </summary>
        public bool? EditONRP { get => _editONRP; set => _editONRP = value; }
    }
}