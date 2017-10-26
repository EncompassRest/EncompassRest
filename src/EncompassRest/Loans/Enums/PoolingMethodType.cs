using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum PoolingMethodType
    {
        [EnumMember(Value = "ConcurrentDate ")]
        ConcurrentDate = 0,
        InternalReserve = 1
    }
}