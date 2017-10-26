using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ManufacturedHomeLandPropertyInterest
    {
        [EnumMember(Value = "Direct ownership")]
        DirectOwnership = 0,
        [EnumMember(Value = "Indirect ownership")]
        IndirectOwnership = 1,
        [EnumMember(Value = "Paid leasehold")]
        PaidLeasehold = 2,
        [EnumMember(Value = "Unpaid leasehold")]
        UnpaidLeasehold = 3,
        [EnumMember(Value = "Not applicable")]
        NotApplicable = 4
    }
}