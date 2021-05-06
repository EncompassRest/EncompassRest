using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Services.v1.Verification
{
    /// <summary>
    /// EV4506TOrderProduct
    /// </summary>
    public enum EV4506TOrderProduct
    {
        /// <summary>
        /// NoOrder
        /// </summary>
        [EnumMember(Value = "0")]
        NoOrder = 0,
        /// <summary>
        /// Order
        /// </summary>
        [EnumMember(Value = "1")]
        Order = 1
    }
}