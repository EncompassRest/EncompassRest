using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// CounselTypeOther
    /// </summary>
    public enum CounselTypeOther
    {
        /// <summary>
        /// Borrower Did Not Participate
        /// </summary>
        [EnumMember(Value = "Borrower Did Not Participate")]
        BorrowerDidNotParticipate = 0,
        /// <summary>
        /// Mortgage Insurance Company
        /// </summary>
        [EnumMember(Value = "Mortgage Insurance Company")]
        MortgageInsuranceCompany = 1,
        /// <summary>
        /// Nonprofit Organization
        /// </summary>
        [EnumMember(Value = "Nonprofit Organization")]
        NonprofitOrganization = 2
    }
}