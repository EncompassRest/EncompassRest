using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BorrowerTypeCode
    {
        [EnumMember(Value = "1. Individual")]
        n1Individual = 0,
        [EnumMember(Value = "2. Corporation")]
        n2Corporation = 1,
        [EnumMember(Value = "3. Proprietorship")]
        n3Proprietorship = 2,
        [EnumMember(Value = "4. Cooperative")]
        n4Cooperative = 3,
        [EnumMember(Value = "5. Public Body")]
        n5PublicBody = 4,
        [EnumMember(Value = "6. Partnership")]
        n6Partnership = 5,
        [EnumMember(Value = "7. Other")]
        n7Other = 6,
        [EnumMember(Value = "8. Indian Tribe")]
        n8IndianTribe = 7,
        [EnumMember(Value = "9. Trust")]
        n9Trust = 8,
        [EnumMember(Value = "10. Limited Partnership")]
        n10LimitedPartnership = 9,
        [EnumMember(Value = "11. Association of Farmers")]
        n11AssociationOfFarmers = 10,
        [EnumMember(Value = "12. Organization of Farm Workers")]
        n12OrganizationOfFarmWorkers = 11,
        [EnumMember(Value = "13. Joint Operation")]
        n13JointOperation = 12
    }
}