using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ManufacturedSecuredProperyType
    {
        [EnumMember(Value = "Manufactured home and land")]
        ManufacturedHomeAndLand = 0,
        [EnumMember(Value = "Manufactured home and not land")]
        ManufacturedHomeAndNotLand = 1,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 2
    }
}