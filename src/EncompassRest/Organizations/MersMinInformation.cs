using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Object containing Mortgage Electronic Registration System (MERS) MIN information.
    /// </summary>
    public sealed class MersMinInformation : ParentInformation
    {
        private DirtyValue<string> _code;

        /// <summary>
        /// The MERS MIN number for the organization.
        /// </summary>
        public string Code { get => _code; set => SetField(ref _code, value); }
    }
}