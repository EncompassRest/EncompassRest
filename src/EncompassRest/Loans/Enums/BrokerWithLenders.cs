using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum BrokerWithLenders
    {
        [EnumMember(Value = "Only One")]
        OnlyOne = 0,
        [EnumMember(Value = "3 or Fewer")]
        n3OrFewer = 1,
        [EnumMember(Value = "More Than 3")]
        MoreThan3 = 2
    }
}