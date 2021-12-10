using System.ComponentModel;
using System.Runtime.Serialization;

namespace EncompassRest.Loans.Enums
{
    /// <summary>
    /// Print2003Application
    /// </summary>
    public enum Print2003Application
    {
        /// <summary>
        /// 
        /// </summary>
        N = 0,
        /// <summary>
        /// Print 2003 Application
        /// </summary>
        [Description("Print 2003 Application")]
        Y = 1,
        /// <summary>
        /// Print 2004 &amp; 2005 Application
        /// </summary>
        [Description("Print 2004 & 2005 Application")]
        [EnumMember(Value = "2004")]
        n2004 = 2004,
        /// <summary>
        /// Print 2006 Application
        /// </summary>
        [Description("Print 2006 Application")]
        [EnumMember(Value = "2006")]
        n2006 = 2006,
        /// <summary>
        /// Print 2009 Application
        /// </summary>
        [Description("Print 2009 Application")]
        [EnumMember(Value = "2009")]
        n2009 = 2009,
        /// <summary>
        /// Print 2020 Application
        /// </summary>
        [Description("Print 2020 Application")]
        [EnumMember(Value = "2020")]
        n2020 = 2020
    }
}