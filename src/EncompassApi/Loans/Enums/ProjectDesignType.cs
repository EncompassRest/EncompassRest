using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// ProjectDesignType
    /// </summary>
    public enum ProjectDesignType
    {
        /// <summary>
        /// GardenProject - 1 to 3 stories
        /// </summary>
        [Description("GardenProject - 1 to 3 stories")]
        [EnumMember(Value = "Garden Project")]
        GardenProject = 0,
        /// <summary>
        /// HighriseProject - 8+ stories
        /// </summary>
        [Description("HighriseProject - 8+ stories")]
        [EnumMember(Value = "Highrise Project")]
        HighriseProject = 1,
        /// <summary>
        /// MidriseProject - 4 to 7 stories
        /// </summary>
        [Description("MidriseProject - 4 to 7 stories")]
        [EnumMember(Value = "Midrise Project")]
        MidriseProject = 2,
        /// <summary>
        /// TownhouseRowhouse - attached via common wall
        /// </summary>
        [Description("TownhouseRowhouse - attached via common wall")]
        [EnumMember(Value = "Townhouse Rowhouse")]
        TownhouseRowhouse = 3,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4
    }
}