using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// CondoClass
    /// </summary>
    public enum CondoClass
    {
        /// <summary>
        /// Under Development
        /// </summary>
        [Description("Under Development")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// Complete &amp; controlled for less than 1 year
        /// </summary>
        [Description("Complete & controlled for less than 1 year")]
        [EnumMember(Value = "2")]
        n2 = 2,
        /// <summary>
        /// Complete &amp; controlled for 1 year or more
        /// </summary>
        [Description("Complete & controlled for 1 year or more")]
        [EnumMember(Value = "3")]
        n3 = 3,
        /// <summary>
        /// Approved FHA / VA condominium project
        /// </summary>
        [Description("Approved FHA / VA condominium project")]
        [EnumMember(Value = "4")]
        n4 = 4
    }
}