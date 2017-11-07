using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    public enum ProjectDesignType
    {
        [EnumMember(Value = "Garden Project")]
        GardenProject = 0,
        [EnumMember(Value = "Highrise Project")]
        HighriseProject = 1,
        [EnumMember(Value = "Midrise Project")]
        MidriseProject = 2,
        [EnumMember(Value = "Townhouse Rowhouse")]
        TownhouseRowhouse = 3,
        Other = 4
    }
}