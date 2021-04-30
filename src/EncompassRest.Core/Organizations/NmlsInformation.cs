using EncompassRest.Company;

namespace EncompassRest.Organizations
{
    /// <summary>
    /// Object containing Nationwide Mortgage Licensing System (NMLS) information.
    /// </summary>
    public sealed class NmlsInformation : ParentInformation
    {
        private DirtyValue<string?>? _code;

        /// <summary>
        /// The organization's NMLS license number.
        /// </summary>
        public string? Code { get => _code; set => SetField(ref _code, value); }
    }
}