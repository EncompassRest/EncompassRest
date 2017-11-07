using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GinnieConstructionMethodType
    {
        Manufactured = 0,
        [EnumMember(Value = "Site Built")]
        SiteBuilt = 1,
        Other = 2
    }
}