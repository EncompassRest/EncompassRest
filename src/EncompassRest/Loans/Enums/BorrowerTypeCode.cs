using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// BorrowerTypeCode
    /// </summary>
    public enum BorrowerTypeCode
    {
        /// <summary>
        /// 1. Individual
        /// </summary>
        [EnumMember(Value = "1. Individual")]
        n1Individual = 1,
        /// <summary>
        /// 2. Corporation
        /// </summary>
        [EnumMember(Value = "2. Corporation")]
        n2Corporation = 2,
        /// <summary>
        /// 3. Proprietorship
        /// </summary>
        [EnumMember(Value = "3. Proprietorship")]
        n3Proprietorship = 3,
        /// <summary>
        /// 4. Cooperative
        /// </summary>
        [EnumMember(Value = "4. Cooperative")]
        n4Cooperative = 4,
        /// <summary>
        /// 5. Public Body
        /// </summary>
        [EnumMember(Value = "5. Public Body")]
        n5PublicBody = 5,
        /// <summary>
        /// 6. Partnership
        /// </summary>
        [EnumMember(Value = "6. Partnership")]
        n6Partnership = 6,
        /// <summary>
        /// 7. Other
        /// </summary>
        [EnumMember(Value = "7. Other")]
        n7Other = 7,
        /// <summary>
        /// 8. Indian Tribe
        /// </summary>
        [EnumMember(Value = "8. Indian Tribe")]
        n8IndianTribe = 8,
        /// <summary>
        /// 9. Trust
        /// </summary>
        [EnumMember(Value = "9. Trust")]
        n9Trust = 9,
        /// <summary>
        /// 10. Limited Partnership
        /// </summary>
        [EnumMember(Value = "10. Limited Partnership")]
        n10LimitedPartnership = 10,
        /// <summary>
        /// 11. Association of Farmers
        /// </summary>
        [EnumMember(Value = "11. Association of Farmers")]
        n11AssociationOfFarmers = 11,
        /// <summary>
        /// 12. Organization of Farm Workers
        /// </summary>
        [EnumMember(Value = "12. Organization of Farm Workers")]
        n12OrganizationOfFarmWorkers = 12,
        /// <summary>
        /// 13. Joint Operation
        /// </summary>
        [EnumMember(Value = "13. Joint Operation")]
        n13JointOperation = 13
    }
}