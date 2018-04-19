using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// StateLicenseType
    /// </summary>
    public enum StateLicenseType
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// LoanOfficerLicensePermit
        /// </summary>
        LoanOfficerLicensePermit = 1,
        /// <summary>
        /// CompanyLicense
        /// </summary>
        CompanyLicense = 2
    }
}