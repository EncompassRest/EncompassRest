using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum IfYouPurchaseType
    {
        Property = 0,
        Flood = 1,
        [EnumMember(Value = "Property and Flood")]
        PropertyAndFlood = 2
    }
}