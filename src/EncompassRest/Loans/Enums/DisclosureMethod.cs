using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum DisclosureMethod
    {
        [EnumMember(Value = "U.S. Mail")]
        USMail = 0,
        [EnumMember(Value = "eFolder eDisclosures")]
        EFolderEDisclosures = 1,
        Fax = 2,
        [EnumMember(Value = "In Person")]
        InPerson = 3,
        Other = 4
    }
}