using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum CounselTypeOther
    {
        [EnumMember(Value = "Borrower Did Not Participate")]
        BorrowerDidNotParticipate = 0,
        [EnumMember(Value = "Mortgage Insurance Company")]
        MortgageInsuranceCompany = 1,
        [EnumMember(Value = "Nonprofit Organization")]
        NonprofitOrganization = 2
    }
}