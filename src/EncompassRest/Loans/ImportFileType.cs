using System.Runtime.Serialization;
using EnumsNET;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ImportFileType
    /// </summary>
    public enum ImportFileType
    {
        /// <summary>
        /// FNMA 3.0 file
        /// </summary>
        [EnumMember(Value = "application/vnd.elliemae.fnma30+text")]
        FNMA30 = 0,
        /// <summary>
        /// FNMA 3.2 file
        /// </summary>
        [EnumMember(Value = "application/vnd.elliemae.fnma32+text")]
        FNMA32 = 1
    }
}