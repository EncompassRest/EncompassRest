using EncompassRest.Company.v1;

namespace EncompassRest.Organizations.v1
{
    /// <summary>
    /// Object containing Nationwide Mortgage Licensing System (NMLS) information.
    /// </summary>
    public sealed class NmlsInformation : ParentInformation
    {
        /// <summary>
        /// The organization's NMLS license number.
        /// </summary>
        public string? Code { get => GetValue<string?>(); set => SetValue(value); }
    }
}