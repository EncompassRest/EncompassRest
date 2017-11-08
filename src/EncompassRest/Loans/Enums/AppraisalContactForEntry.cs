using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum AppraisalContactForEntry
    {
        Borrower = 0,
        CoBorrower = 1,
        [EnumMember(Value = "Property Manager")]
        PropertyManager = 2,
        [EnumMember(Value = "Real Estate Agent")]
        RealEstateAgent = 3,
        Relative = 4
    }
}