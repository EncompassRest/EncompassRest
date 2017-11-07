using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum WeConductBusiness
    {
        [EnumMember(Value = "An Individual")]
        AnIndividual = 0,
        [EnumMember(Value = "A Corporation")]
        ACorporation = 1,
        [EnumMember(Value = "A Partnership")]
        APartnership = 2,
        [EnumMember(Value = "An Association")]
        AnAssociation = 3,
        LLC = 4,
        Other = 5
    }
}