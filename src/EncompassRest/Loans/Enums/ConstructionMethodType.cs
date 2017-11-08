using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ConstructionMethodType
    {
        [EnumMember(Value = "Site Built")]
        SiteBuilt = 0,
        Manufactured = 1
    }
}