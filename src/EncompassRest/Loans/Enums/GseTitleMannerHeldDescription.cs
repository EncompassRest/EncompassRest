using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum GseTitleMannerHeldDescription
    {
        [EnumMember(Value = "Community property")]
        CommunityProperty = 0,
        [EnumMember(Value = "Joint tenants")]
        JointTenants = 1,
        [EnumMember(Value = "Single man")]
        SingleMan = 2,
        [EnumMember(Value = "Single woman")]
        SingleWoman = 3,
        [EnumMember(Value = "Married man")]
        MarriedMan = 4,
        [EnumMember(Value = "Married woman")]
        MarriedWoman = 5,
        [EnumMember(Value = "Tenants in common")]
        TenantsInCommon = 6,
        [EnumMember(Value = "Tenancy by entirety")]
        TenancyByEntirety = 7,
        [EnumMember(Value = "To be decided in escrow")]
        ToBeDecidedInEscrow = 8,
        [EnumMember(Value = "Unmarried man")]
        UnmarriedMan = 9,
        [EnumMember(Value = "Unmarried woman")]
        UnmarriedWoman = 10,
        [EnumMember(Value = "Spouses Married to Each Other")]
        SpousesMarriedToEachOther = 11,
        Other = 12
    }
}