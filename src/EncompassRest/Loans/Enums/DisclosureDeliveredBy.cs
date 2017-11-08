using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DisclosureDeliveredBy
    {
        [EnumMember(Value = "In Person")]
        InPerson = 0,
        [EnumMember(Value = "By Fax")]
        ByFax = 1,
        [EnumMember(Value = "By E-Mail")]
        ByEMail = 2,
        Other = 3
    }
}