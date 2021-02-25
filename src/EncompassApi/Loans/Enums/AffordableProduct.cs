using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// AffordableProduct
    /// </summary>
    public enum AffordableProduct
    {
        /// <summary>
        /// Not Affordable product
        /// </summary>
        [Description("Not Affordable product")]
        [EnumMember(Value = "0")]
        n0 = 0,
        /// <summary>
        /// Affordable Gold 5
        /// </summary>
        [Description("Affordable Gold 5")]
        [EnumMember(Value = "1")]
        n1 = 1,
        /// <summary>
        /// Affordable Gold 3/2
        /// </summary>
        [Description("Affordable Gold 3/2")]
        [EnumMember(Value = "2")]
        n2 = 2,
        /// <summary>
        /// Affordable Gold 97
        /// </summary>
        [Description("Affordable Gold 97")]
        [EnumMember(Value = "3")]
        n3 = 3,
        /// <summary>
        /// Specially-negotiated Affordable 5
        /// </summary>
        [Description("Specially-negotiated Affordable 5")]
        [EnumMember(Value = "4")]
        n4 = 4,
        /// <summary>
        /// Specially-negotiated Affordable 3/2
        /// </summary>
        [Description("Specially-negotiated Affordable 3/2")]
        [EnumMember(Value = "5")]
        n5 = 5,
        /// <summary>
        /// Specially-negotiated Affordable 97
        /// </summary>
        [Description("Specially-negotiated Affordable 97")]
        [EnumMember(Value = "6")]
        n6 = 6
    }
}