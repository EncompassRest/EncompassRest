using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing Mortgage Electronic Registration System (MERS) MIN information.
    /// </summary>
    public sealed class MersMinInformation : ParentInformation
    {
        /// <summary>
        /// The MERS MIN number for the organization.
        /// </summary>
        public string? Code { get => GetValue<string?>(); set => SetValue(value); }
    }
}